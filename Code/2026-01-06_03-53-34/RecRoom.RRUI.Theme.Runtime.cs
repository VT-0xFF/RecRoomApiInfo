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
		[Cpp2IlInjected.Address(RVA = "0x8E050E0", Offset = "0x8E03AE0", VA = "0x188E050E0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		private sealed class KSOSAENBDBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TMP_FontAsset VNSLVJTODQO;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KSOSAENBDBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8E04CE0", Offset = "0x8E036E0", VA = "0x188E04CE0")]
			internal bool LMGEARTXZON(LocalizedFontMapping a)
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
		[Cpp2IlInjected.Address(RVA = "0x8E03EF0", Offset = "0x8E028F0", VA = "0x188E03EF0")]
		public bool IsLocalizedFontAsset(TMP_FontAsset font)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E03A30", Offset = "0x8E02430", VA = "0x188E03A30")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E037F0", Offset = "0x8E021F0", VA = "0x188E037F0")]
		public TMP_FontAsset GetLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material localizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E03B90", Offset = "0x8E02590", VA = "0x188E03B90")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E03CF0", Offset = "0x8E026F0", VA = "0x188E03CF0")]
		public TMP_FontAsset GetNonLocalizedFontAsset(TMP_FontAsset font, Material overrideMaterial, [Out] Material nonLocalizedOverrideMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E04010", Offset = "0x8E02A10", VA = "0x188E04010")]
		private static bool VRQMJIFZUAF(TMP_FontAsset a, LocalizedFontMapping b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E040C0", Offset = "0x8E02AC0", VA = "0x188E040C0")]
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
		public Palette LMVCCNBHTBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E3C0", Offset = "0x8E0CDC0", VA = "0x188E0E3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E360", Offset = "0x8E0CD60", VA = "0x188E0E360")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E041A0", Offset = "0x8E02BA0", VA = "0x188E041A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E04140", Offset = "0x8E02B40", VA = "0x188E04140", Slot = "4")]
		public bool Equals(GradientBlock other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E04280", Offset = "0x8E02C80", VA = "0x188E04280", Slot = "2")]
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
		public List<Graphic> ZCXHGEQLCST
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB4F9A0", Offset = "0xB4E3A0", VA = "0x180B4F9A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB4FA60", Offset = "0xB4E460", VA = "0x180B4FA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ColorBlock DLJCQPEWYEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8E06350", Offset = "0x8E04D50", VA = "0x188E06350")]
			get
			{
				return default(ColorBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E063D0", Offset = "0x8E04DD0", VA = "0x188E063D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public UIGradient BDHOEYZELYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCAF4A0", Offset = "0xCADEA0", VA = "0x180CAF4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1369D40", Offset = "0x1368740", VA = "0x181369D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public GradientBlock ZOZZOIFJQHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8E063A0", Offset = "0x8E04DA0", VA = "0x188E063A0")]
			get
			{
				return default(GradientBlock);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8E06420", Offset = "0x8E04E20", VA = "0x188E06420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E061E0", Offset = "0x8E04BE0", VA = "0x188E061E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E06230", Offset = "0x8E04C30", VA = "0x188E06230")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E060A0", Offset = "0x8E04AA0", VA = "0x188E060A0")]
		public void ForceHighlighted(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E060C0", Offset = "0x8E04AC0", VA = "0x188E060C0")]
		public void ForceNormal(bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E05D40", Offset = "0x8E04740", VA = "0x188E05D40", Slot = "28")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E05C50", Offset = "0x8E04650", VA = "0x188E05C50")]
		private void BALSAMKLGVR(Graphic a, Color b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8E060E0", Offset = "0x8E04AE0", VA = "0x188E060E0")]
		private void IWYRJSROBUG(SelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E06260", Offset = "0x8E04C60", VA = "0x188E06260")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(ButtonAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ButtonAudioPaletteAsset ButtonAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(ScrollingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public ScrollingAudioPaletteAsset ScrollingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(ContentLoadingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public ContentLoadingAudioPaletteAsset ContentLoadingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(RecyclingAudioPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public RecyclingAudioPaletteAsset RecyclingAudioPaletteConfig
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public RecyclingAudioPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GXJZCZDFVCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ContentLoadingAudioPaletteType LJJSNSKNMAF;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GXJZCZDFVCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool BYQPPJNEVJR(ContentLoadingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CKKPNCYLFCX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public RecyclingAudioPaletteType JPKUOYJYFGC;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CKKPNCYLFCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool YVQJHBZKWZY(RecyclingAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ACAFAPQXIVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ButtonAudioPaletteType ETZTZPBUEGS;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public ACAFAPQXIVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool DIDEDTTQTIM(ButtonAudioPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LWREDTRENBY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ScrollingAudioPaletteType BKHKKKETIDR;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public LWREDTRENBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool KUCBEVUNURX(ScrollingAudioPaletteItem a)
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
		[Cpp2IlInjected.Address(RVA = "0x8E004E0", Offset = "0x8DFEEE0", VA = "0x188E004E0")]
		public ButtonAudioPaletteAsset GetButtonAudioPalette(ButtonAudioPaletteType buttonAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E00780", Offset = "0x8DFF180", VA = "0x188E00780")]
		public ScrollingAudioPaletteAsset GetScrollingAudioPaletteConfig(ScrollingAudioPaletteType scrollingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E005C0", Offset = "0x8DFEFC0", VA = "0x188E005C0")]
		public ContentLoadingAudioPaletteAsset GetContentLoadingAudioPaletteConfig(ContentLoadingAudioPaletteType contentLoadingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E006A0", Offset = "0x8DFF0A0", VA = "0x188E006A0")]
		public RecyclingAudioPaletteAsset GetRecyclingAudioPaletteConfig(RecyclingAudioPaletteType recyclingAudioPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF0BD0", Offset = "0xBEF5D0", VA = "0x180BF0BD0")]
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
		public float IGPTTCCOMEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float LYDIZFHEDRT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E008E0", Offset = "0x8DFF2E0", VA = "0x188E008E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ColorBlock BackgroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8E00A00", Offset = "0x8DFF400", VA = "0x188E00A00")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GradientBlock BackgroundGradients
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x129B2A0", Offset = "0x1299CA0", VA = "0x18129B2A0")]
			get
			{
				return default(GradientBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1004520", Offset = "0x1002F20", VA = "0x181004520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ColorBlock ForegroundTints
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8E00A40", Offset = "0x8DFF440", VA = "0x188E00A40")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ShowBorder
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x154FCF0", Offset = "0x154E6F0", VA = "0x18154FCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBCE380", Offset = "0xBCCD80", VA = "0x180BCE380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ButtonAudioPaletteType AudioPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1FE0C20", Offset = "0x1FDF620", VA = "0x181FE0C20")]
			get
			{
				return default(ButtonAudioPaletteType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8E00900", Offset = "0x8DFF300", VA = "0x188E00900")]
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
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E03130", Offset = "0x8E01B30", VA = "0x188E03130")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color ForegroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xC02990", Offset = "0xC01390", VA = "0x180C02990")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color PlaceholderColor
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TextStylePalette TextPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E04790", Offset = "0x8E03190", VA = "0x188E04790")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E05610", Offset = "0x8E04010", VA = "0x188E05610")]
		public TogglePalette GGWQKPYICJZ(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8E055A0", Offset = "0x8E03FA0", VA = "0x188E055A0")]
		public ButtonPalette BSTPXITMLJN(Palette a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(RawImageColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAFCE80", Offset = "0xAFB880", VA = "0x180AFCE80")]
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

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public BackgroundColorPaletteType BackgroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(BackgroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Gradient Gradient
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8E00860", Offset = "0x8DFF260", VA = "0x188E00860")]
			public BackgroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class ForegroundColorPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[SerializeField]
			private ForegroundColorPaletteType foregroundColorPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[SerializeField]
			private Color color;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public ForegroundColorPaletteType ForegroundColorPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(ForegroundColorPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public Color Color
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
				get
				{
					return default(Color);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8E04120", Offset = "0x8E02B20", VA = "0x188E04120")]
			public ForegroundColorPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class TilerPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			private TilerPaletteType tilerPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			private TilerPalette tilerPalette;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public TilerPaletteType TilerPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(TilerPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public TilerPalette TilerPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TilerPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class TextStylePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			private TextStylePaletteType textStylePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[SerializeField]
			private TextStylePalette textStylePalette;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public TextStylePaletteType TextStylePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(TextStylePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public TextStylePalette TextStylePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TextStylePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class TextSizePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[SerializeField]
			private TextSizePaletteType textSizePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[SerializeField]
			private int size;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public TextSizePaletteType TextSizePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(TextSizePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public int Size
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1326B60", Offset = "0x1325560", VA = "0x181326B60")]
			public TextSizePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class ButtonPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[SerializeField]
			private ButtonPaletteType buttonPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[SerializeField]
			private ButtonPalette buttonPalette;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public ButtonPaletteType ButtonPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(ButtonPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public ButtonPalette ButtonPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public ButtonPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public class TogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[SerializeField]
			private TogglePaletteType togglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private TogglePalette togglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public TogglePaletteType TogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(TogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public TogglePalette TogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class MixedTogglePaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private MixedTogglePaletteType mixedTogglePaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[SerializeField]
			private MixedTogglePalette mixedTogglePalette;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public MixedTogglePaletteType MixedTogglePaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(MixedTogglePaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public MixedTogglePalette MixedTogglePalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public MixedTogglePaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class MakerPenToolPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			[SerializeField]
			private MakerPenToolPaletteType makerPenToolPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			[SerializeField]
			private MakerPenToolPalette makerPenToolPalette;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public MakerPenToolPaletteType MakerPenToolPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(MakerPenToolPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public MakerPenToolPalette MakerPenToolPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public MakerPenToolPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class InputFieldPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			[SerializeField]
			private InputFieldPaletteType inputFieldPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[SerializeField]
			private InputFieldPalette inputFieldPalette;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public InputFieldPaletteType InputFieldPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(InputFieldPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public InputFieldPalette InputFieldPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public InputFieldPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class DropdownPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			[SerializeField]
			private DropdownPaletteType dropdownPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[SerializeField]
			private DropdownPalette dropdownPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public DropdownPaletteType DropdownPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(DropdownPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public DropdownPalette DropdownPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public DropdownPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class SliderPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[SerializeField]
			private SliderPaletteType sliderPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			[SerializeField]
			private SliderPalette sliderPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public SliderPaletteType SliderPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(SliderPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public SliderPalette SliderPalette
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public SliderPaletteItem()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class DepthPaletteItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private DepthPaletteType depthPaletteType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			[SerializeField]
			private DepthPalette depthPalette;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public DepthPaletteType DepthPaletteType
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				get
				{
					return default(DepthPaletteType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public DepthPalette DepthPalette
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public DepthPaletteItem()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CKKPNCYLFCX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public TilerPaletteType PUQVJDXVEJZ;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CKKPNCYLFCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool UCCTUCZTBZS(TilerPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public TextStylePaletteType FJJNYXYGNLK;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool HYSJDUVKGXU(TextStylePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CAOYPSXYHLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TextSizePaletteType AINSCGWREAI;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CAOYPSXYHLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool CHLKHABLEQR(TextSizePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class PHEUSJQEBDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public ButtonPaletteType EUEZCFFWPJM;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PHEUSJQEBDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool CGNXSKZTXQY(ButtonPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class TXCIFAKKTSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public TogglePaletteType DBZFRMJPLPU;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TXCIFAKKTSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool USDPZINYLDW(TogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class XMGNVDOHJZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public MixedTogglePaletteType PSXJCGYSOYV;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public XMGNVDOHJZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool TMJUDUFQXGZ(MixedTogglePaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class EQQHSUUAGWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MakerPenToolPaletteType NKVWCXAYIYZ;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public EQQHSUUAGWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool IXTSBZONNOF(MakerPenToolPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public RawImageColorPaletteType CEDEUKWTQCF;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool HUCDXUFMXBZ(RawImageColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class HXGPKBFCMYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public InputFieldPaletteType SSVPVXIXZUO;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool QBTIXNHZGYM(InputFieldPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FXMBZCBAMQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public DropdownPaletteType TTZJPYTZBVH;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FXMBZCBAMQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool SSHNWTZJMYB(DropdownPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class IAPTRCSVUQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public SliderPaletteType ARNZPODMYWZ;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public IAPTRCSVUQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool IQWOOIRYADD(SliderPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class RGXLOBYXHLS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public DepthPaletteType ZTRXADGNTHJ;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public RGXLOBYXHLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool TQTTBGIFWBI(DepthPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class KITBCUMOFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public BackgroundColorPaletteType CEDEUKWTQCF;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool PMAUUJKGGQI(BackgroundColorPaletteItem a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class ACAFAPQXIVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public ForegroundColorPaletteType EAQTCXGBJTG;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public ACAFAPQXIVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xCBFE70", Offset = "0xCBE870", VA = "0x180CBFE70")]
			internal bool BIQCOYWXLCR(ForegroundColorPaletteItem a)
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
		public IEnumerable<DepthPaletteItem> QVNSQAIRZGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ButtonAnimationPalette GFFOYDXJMOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AudioPalette NNVBKXMJYBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4840", VA = "0x180AE5E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E08BA0", Offset = "0x8E075A0", VA = "0x188E08BA0")]
		public Color GetRawImageColor(RawImageColorPaletteType backgroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8E083F0", Offset = "0x8E06DF0", VA = "0x188E083F0")]
		public void GetBackgroundPaletteData(BackgroundColorPaletteType backgroundColorPaletteType, [Out] Color color, [Out] Gradient gradient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E08810", Offset = "0x8E07210", VA = "0x188E08810")]
		public Color GetForegroundColor(ForegroundColorPaletteType foregroundColorPaletteType)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8E08F30", Offset = "0x8E07930", VA = "0x188E08F30")]
		public TilerPalette GetTilerPalette(TilerPaletteType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8E08E50", Offset = "0x8E07850", VA = "0x188E08E50")]
		public TextStylePalette GetTextStylePalette(TextStylePaletteType textStylePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8E08D70", Offset = "0x8E07770", VA = "0x188E08D70")]
		public int GetTextSize(TextSizePaletteType textSizePaletteType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8E08530", Offset = "0x8E06F30", VA = "0x188E08530")]
		public ButtonPalette GetButtonPalette(ButtonPaletteType buttonPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8E09010", Offset = "0x8E07A10", VA = "0x188E09010")]
		public TogglePalette GetTogglePalette(TogglePaletteType togglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8E08AC0", Offset = "0x8E074C0", VA = "0x188E08AC0")]
		public MixedTogglePalette GetMixedTogglePalette(MixedTogglePaletteType mixedTogglePaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E089E0", Offset = "0x8E073E0", VA = "0x188E089E0")]
		public MakerPenToolPalette GetMakerPenToolPalette(MakerPenToolPaletteType makerPenToolPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E08900", Offset = "0x8E07300", VA = "0x188E08900")]
		public InputFieldPalette GetInputFieldPalette(InputFieldPaletteType inputFieldPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E08730", Offset = "0x8E07130", VA = "0x188E08730")]
		public DropdownPalette GetDropdownPalette(DropdownPaletteType dropdownPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E08C90", Offset = "0x8E07690", VA = "0x188E08C90")]
		public SliderPalette GetSliderPalette(SliderPaletteType sliderPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8E08610", Offset = "0x8E07010", VA = "0x188E08610")]
		public float? GetDepth(DepthPaletteType depthPaletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBF0BD0", Offset = "0xBEF5D0", VA = "0x180BF0BD0")]
		public Palette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SliderPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Color sliderColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Color fillColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private TextStylePalette textPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Color textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private ColorBlock colorBlock;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color SliderColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color FillColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xC02990", Offset = "0xC01390", VA = "0x180C02990")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color HandleColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public ColorBlock ColorBlock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8E0D470", Offset = "0x8E0BE70", VA = "0x188E0D470")]
			get
			{
				return default(ColorBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D3B0", Offset = "0x8E0BDB0", VA = "0x188E0D3B0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			LowerCase,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			UpperCase,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			SmallCaps
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private TMP_FontAsset font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Material fontOverrideMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private float kerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private float leading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private bool isBold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private Transformations transformation;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DE60", Offset = "0x8E0C860", VA = "0x188E0DE60")]
		public void Apply(TextMeshProUGUI textMeshProUGUI, bool isInputTextField = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TextStylePalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class TilerPalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private UITiler.AnimationType animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Color TintColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float Rows
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D00", Offset = "0xBC0700", VA = "0x180BC1D00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 Spacing
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E440", Offset = "0x8E0CE40", VA = "0x188E0E440")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB076B0", Offset = "0xB060B0", VA = "0x180B076B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xC37360", Offset = "0xC35D60", VA = "0x180C37360")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB05C30", Offset = "0xB04630", VA = "0x180B05C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public UITiler.AnimationType AnimationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			get
			{
				return default(UITiler.AnimationType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float PrimaryAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1004560", Offset = "0x1002F60", VA = "0x181004560")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float AltAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1004590", Offset = "0x1002F90", VA = "0x181004590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E3F0", Offset = "0x8E0CDF0", VA = "0x188E0E3F0")]
		public TilerPalette()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class TogglePalette
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private ButtonPalette inactiveButtonPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private ButtonPalette activeButtonPalette;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ButtonPalette InactiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ButtonPalette ActiveButtonPalette
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TogglePalette()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum BackgroundColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		PrimarySolid,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		SecondarySolid,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		HighlightSolid,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		HighlightGradient,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		BannerBG,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		InputField,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		LineColor,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CardImageBase,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		DarkGradient,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Shadow,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		NotiBase,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		BackgroundAccent,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		SideBarBG,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Modified,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		LoadingScreen,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LoadingBarGradient,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		HomeButtonBase,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		TitleRoot,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		HighlightedAccent,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		LoadingCard,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		ChipBase,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		LimitedEventCard,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		LimitedEventBgSolid,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		DateChip,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		WinterWonderlandBG,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		RuntimeAddedTag,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		RuntimeDeletedTag,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		MakerAI,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		TrickOrTreatCard,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		TrickOrTreatBG
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum RawImageColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		A
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ForegroundColorPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		MainPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		MainSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		InversePrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		NotUse,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		WhitePrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		WhiteSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		CardPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		CardSecondary,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Modified,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Orange
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum TilerPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		WatchBackground,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		HomePage,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		DialogPage,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Card,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		ProfileBG,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		WinterWonderlandHome,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		MerryMidway
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum TextStylePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		JostMedium,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		JostMediumCap,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		JostBoldCap,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		RobotoReg,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		RobotoBold,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		RobotoBoldOutlineDropshadow,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		RobotoBoldOutline,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		RobotoBoldOutlineDropshadowGradient,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		RobotoBoldOutlineGradient
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum TextSizePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		XXXS = -1,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		XXS = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		XS = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		S = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		M = 3,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		L = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		XL = 5,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		XXL = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		XXXL = 6,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		XXXXL = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public enum ButtonPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Primary,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Secondary,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		FlatPrimary,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		FlatButtonForWarningBanner,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Negative,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Chips,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		CarouselArrowDark,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		FlatWhite,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		MagicDoor,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Tertiary_DupeWith2NDHeader_NeedReplace,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		CarouselArrowLight,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		HomePageMainButton,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		DropDown,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		SecondaryHeaderSection,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		ChatButton,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		FeedButton,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		NameTag,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		RoomCurrency,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ChipsWhite,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		UGCBaseButton,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		UGCBaseButton_Subtle_NoDisabledState,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		RevenuePurchaseGreen,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		RecRoomPlus,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		SearchBar
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum TogglePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		FlatOrange,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		FlatWhite,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		InputToggle,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Chips,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		WhitePagingBlob,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		RSVPToggleHeaderSection,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		CardSelectableToggle,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		ChipsDark,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		MainNavToggle,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ListItem,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		NotiUnread,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		FlatPrimary,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		CharadePen,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ShareCam,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		CardSelectableToggleWithBacking,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		SecondaryHeaderSectionToggle,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PrimaryToSecondaryHeader,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NegativeToSecondaryHeader,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LimitedEventPrimary,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LimitedEventSecondary,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RoomCardWithLimitedEvent,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		MainNavVrDetach,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		HomeMainNav,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		FlatOrangeSecondary,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ChipsPurple,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ShareCamTab
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum MixedTogglePaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Checkbox
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum MakerPenToolPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Select,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Wire,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Configure,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Transform,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Move,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Rotate,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Scale,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		CloneFlip,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Recolor,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Freeze,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		MakeInvention,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Manipulate,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		SelectConnect,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ResetMakerAI,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		NewMove
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum InputFieldPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		LightFlat,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		DarkFlat,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Modified
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum DropdownPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		LightFlat,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		DarkFlat
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum SliderPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		MirroUIPopUp
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum DepthPaletteType
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Base,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Button,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Navigation,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Dialog,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Toast
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class ApproximationMaskDepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private RectTransform content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3? APWRQMKSQYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3? QHSHIDMABWC;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E003B0", Offset = "0x8DFEDB0", VA = "0x188E003B0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8E00000", Offset = "0x8DFEA00", VA = "0x188E00000", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8E00490", Offset = "0x8DFEE90", VA = "0x188E00490")]
		public ApproximationMaskDepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ButtonTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[Header("Button Visual")]
		[SerializeField]
		private ButtonPaletteType buttonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Header("Button Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette defined by the button's visual with a custom palette")]
		private bool overrideButtonAudioPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[ConditionalField("overrideButtonAudioPalette")]
		[Tooltip("Specify a custom config to use for button audio")]
		private ButtonAudioPaletteAsset customButtonAudioConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public ButtonPaletteType HDYUJMLOTPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x18F1F60", Offset = "0x18F0960", VA = "0x1818F1F60")]
			get
			{
				return default(ButtonPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8E023B0", Offset = "0x8E00DB0", VA = "0x188E023B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8E02150", Offset = "0x8E00B50", VA = "0x188E02150", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F94300", Offset = "0x1F92D00", VA = "0x181F94300")]
		public void SetAnimationEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E023A0", Offset = "0x8E00DA0", VA = "0x188E023A0")]
		public ButtonTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class ButtonThemeBase : SelectableThemeBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		protected class BVXWMBLAIAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public ButtonAudioPaletteAsset RSDQOSYWHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public RecRoomAudioClipPoolConfig CHUVFARVVRG;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public BVXWMBLAIAC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Header("Button Theme Base")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private MultiGraphicButton multiGraphicButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool controlSurfaceColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[ReadOnlyField]
		private List<Graphic> graphics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private bool useGraphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[ConditionalField("useGraphicsOverride")]
		private List<Graphic> graphicsOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[ConditionalFieldExcept("useGraphicsOverride", new object[] { })]
		private bool graphicsIgnoreTextFields;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private bool controlGraphicColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool useGradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		[ConditionalField("useGradientOverride")]
		private UIGradient gradientOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[AutofillOptional(AutofillType.Children, true, true, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private bool useTextMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		[ConditionalField("useTextMeshProUGUIOverride")]
		private TextMeshProUGUI textMeshProUGUIOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		protected Hideable borderHideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		protected bool isAnimationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[ConditionalField("isAnimationEnabled")]
		protected bool overrideAnimationTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		[ConditionalField("overrideAnimationTarget")]
		protected GameObject animationTargetOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private bool XMQUJFAMLSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Vector3 TUYGVHAYCZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Vector3 VIMGISPTQTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private NACNJAZEVXK RALXTLXPYAS;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Image BIRNECQMTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8E020F0", Offset = "0x8E00AF0", VA = "0x188E020F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public List<Graphic> LYVDUHTYYQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8E020D0", Offset = "0x8E00AD0", VA = "0x188E020D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public UIGradient WFTEMOHYFZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8E020B0", Offset = "0x8E00AB0", VA = "0x188E020B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public TextMeshProUGUI OUKHUDRTGUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8E02110", Offset = "0x8E00B10", VA = "0x188E02110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public TextSizePaletteType YXZGFXEOELK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x15FA7D0", Offset = "0x15F91D0", VA = "0x1815FA7D0")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8E02130", Offset = "0x8E00B30", VA = "0x188E02130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected Transform HFDWOMNHNFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8E01530", Offset = "0x8DFFF30", VA = "0x188E01530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Button JWWGZHCWKWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8E02030", Offset = "0x8E00A30", VA = "0x188E02030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E01640", Offset = "0x8E00040", VA = "0x188E01640")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E015A0", Offset = "0x8DFFFA0", VA = "0x188E015A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E01D90", Offset = "0x8E00790", VA = "0x188E01D90")]
		protected void ZFYBEOMFZPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E00A90", Offset = "0x8DFF490", VA = "0x188E00A90")]
		protected void DZPOWAMNXJS(ButtonPalette a, [Optional] BVXWMBLAIAC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E016E0", Offset = "0x8E000E0", VA = "0x188E016E0", Slot = "12")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E01A90", Offset = "0x8E00490", VA = "0x188E01A90", Slot = "13")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E016C0", Offset = "0x8E000C0", VA = "0x188E016C0", Slot = "14")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E01580", Offset = "0x8DFFF80", VA = "0x188E01580")]
		private Vector3 NDCKXTURBIB(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E01F50", Offset = "0x8E00950", VA = "0x188E01F50")]
		protected ButtonThemeBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x16B0DB0", Offset = "0x16AF7B0", VA = "0x1816B0DB0")]
		[CompilerGenerated]
		private void WLGKAMIYQWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x16B0DB0", Offset = "0x16AF7B0", VA = "0x1816B0DB0")]
		[CompilerGenerated]
		private void NGHRBKFETEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class DepthTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private DepthPaletteType depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private bool animateOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		[ConditionalField("animateOnEnable")]
		private float animationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Vector3? APWRQMKSQYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private Vector2 ROPWLZTCONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Vector2 GYGCEHMDIXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private Vector2 DGIBPVMQMBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Vector2 REVAEOUNGKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private Vector2 PFLILJESFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Vector2 ZWNPCBSIMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly bool? PADADCBQRDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private ZKDYFAZKJGC DXMQVMDVAKS;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private RectTransform GVJKZKYYQJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8E02AF0", Offset = "0x8E014F0", VA = "0x188E02AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public DepthPaletteType ZJOXTPPFCRR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			get
			{
				return default(DepthPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8E03110", Offset = "0x8E01B10", VA = "0x188E03110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private ZKDYFAZKJGC IRNFMWCSMUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8E02B50", Offset = "0x8E01550", VA = "0x188E02B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private bool OFETOTYYUKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8E028E0", Offset = "0x8E012E0", VA = "0x188E028E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E02A80", Offset = "0x8E01480", VA = "0x188E02A80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8E029D0", Offset = "0x8E013D0", VA = "0x188E029D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E023D0", Offset = "0x8E00DD0", VA = "0x188E023D0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E025C0", Offset = "0x8E00FC0", VA = "0x188E025C0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8E02BE0", Offset = "0x8E015E0", VA = "0x188E02BE0")]
		private Vector3 XYNGZXIEOMI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8E02F60", Offset = "0x8E01960", VA = "0x188E02F60")]
		public DepthTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class DropdownTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Dropdown dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, true, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private DropdownPaletteType dropdownType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Image BIRNECQMTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8E037A0", Offset = "0x8E021A0", VA = "0x188E037A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public DropdownPaletteType XMHROGMQWDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			get
			{
				return default(DropdownPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8E037B0", Offset = "0x8E021B0", VA = "0x188E037B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public TextSizePaletteType YXZGFXEOELK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8E037D0", Offset = "0x8E021D0", VA = "0x188E037D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E03150", Offset = "0x8E01B50", VA = "0x188E03150", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E03750", Offset = "0x8E02150", VA = "0x188E03750")]
		public DropdownTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class GraphicTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private bool useGraphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		[ConditionalField("useGraphicOverride")]
		private Graphic graphicOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private ForegroundColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Graphic VUBJCCFJUXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8E04760", Offset = "0x8E03160", VA = "0x188E04760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ForegroundColorPaletteType XHHQUHDCXEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			get
			{
				return default(ForegroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8E04770", Offset = "0x8E03170", VA = "0x188E04770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool ERHZAHJWPWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDD0", Offset = "0x16EE7D0", VA = "0x1816EFDD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDE0", Offset = "0x16EE7E0", VA = "0x1816EFDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Color? EJBWLJKGWXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8E04540", Offset = "0x8E02F40", VA = "0x188E04540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E042F0", Offset = "0x8E02CF0", VA = "0x188E042F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8E044F0", Offset = "0x8E02EF0", VA = "0x188E044F0")]
		public GraphicTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class InputFieldTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TMP_InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Image surface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private bool useSurfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[ConditionalField("useSurfaceOverride")]
		private Image surfaceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private InputFieldPaletteType inputFieldType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Image BIRNECQMTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8E037A0", Offset = "0x8E021A0", VA = "0x188E037A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public InputFieldPaletteType AQUJAXQKLWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			get
			{
				return default(InputFieldPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8E037B0", Offset = "0x8E021B0", VA = "0x188E037B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public TextSizePaletteType YXZGFXEOELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8E037D0", Offset = "0x8E021D0", VA = "0x188E037D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8E047C0", Offset = "0x8E031C0", VA = "0x188E047C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8E04C90", Offset = "0x8E03690", VA = "0x188E04C90")]
		public InputFieldTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class LabelTheme : GraphicTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private TextMeshProUGUI textMeshProUGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private TextStylePaletteType textType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private TextSizePaletteType textSize;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public TextStylePaletteType KQWQKWXCAHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			get
			{
				return default(TextStylePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8E050C0", Offset = "0x8E03AC0", VA = "0x188E050C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TextSizePaletteType YXZGFXEOELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			get
			{
				return default(TextSizePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8E050A0", Offset = "0x8E03AA0", VA = "0x188E050A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8E04D60", Offset = "0x8E03760", VA = "0x188E04D60", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8E05050", Offset = "0x8E03A50", VA = "0x188E05050")]
		public LabelTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MakerPenToolTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[Header("Maker Pen Tool")]
		[SerializeField]
		private MakerPenToolPaletteType makerPenToolPaletteType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		[Tooltip("A list of objects to show while the maker pen tool is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		protected bool FKIQDJEQXUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16A")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private bool QPQILGYESPL;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MakerPenToolPaletteType IHVSBRKEAMR
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x18F1F60", Offset = "0x18F0960", VA = "0x1818F1F60")]
			get
			{
				return default(MakerPenToolPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8E023B0", Offset = "0x8E00DB0", VA = "0x188E023B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1EEA6C0", Offset = "0x1EE90C0", VA = "0x181EEA6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8E05580", Offset = "0x8E03F80", VA = "0x188E05580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8E05540", Offset = "0x8E03F40", VA = "0x188E05540", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8E05160", Offset = "0x8E03B60", VA = "0x188E05160", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8E023A0", Offset = "0x8E00DA0", VA = "0x188E023A0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Mixed,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			Active
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private MixedTogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is inactive.")]
		private List<Hideable> hideWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is mixed.")]
		private List<Hideable> hideWhenMixed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[Tooltip("A list of objects to hide while the toggle is active")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private ToggleState editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private ToggleState QPQILGYESPL;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public ToggleState BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8E05C40", Offset = "0x8E04640", VA = "0x188E05C40")]
			get
			{
				return default(ToggleState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8E05C20", Offset = "0x8E04620", VA = "0x188E05C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E05BF0", Offset = "0x8E045F0", VA = "0x188E05BF0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E05C20", Offset = "0x8E04620", VA = "0x188E05C20")]
		public void Toggle(ToggleState isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E05640", Offset = "0x8E04040", VA = "0x188E05640", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8E023A0", Offset = "0x8E00DA0", VA = "0x188E023A0")]
		public MixedToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class PaletteTheme : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool usePaletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		[ConditionalField("usePaletteOverride")]
		private Palette paletteOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public MWKYWAOJZRV PaletteChangeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool useDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private const string HIWWBJBMWJN = "watch_layer";

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private const string CVEUZJUIQBR = "depth_multiplier";

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private const float SFOZQIJYRXX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private float? VABQQRLZBHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private float? DDEDFORBTDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private float? TAMFEDLADJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private float FRSNWQHFXHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private float VPSPYKBSDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private float JYLSVCOGBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private float CMOFWHLRQYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly ONVESPKROXV HQMABUPPOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private SFXAudioSource LVGCYMCEXSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private SFXAudioSource RMKEFVTCZPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private ContentLoadingAudioPaletteAsset EVKJSQJACWR;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private const float AJTGRXGPVQE = 0.001f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private QPCWAZBUNTV RZNTYPIPUMW;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Palette SWBRFFTLNPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8E08310", Offset = "0x8E06D10", VA = "0x188E08310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool HAKYPOYPEWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE2210", VA = "0x180AE3810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float FIUQJNURIFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8E080A0", Offset = "0x8E06AA0", VA = "0x188E080A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool HWCTWDJXXHU
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8E06F70", Offset = "0x8E05970", VA = "0x188E06F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool DBNCYZWZBGD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8E073A0", Offset = "0x8E05DA0", VA = "0x188E073A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8E06DD0", Offset = "0x8E057D0", VA = "0x188E06DD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8E079B0", Offset = "0x8E063B0", VA = "0x188E079B0")]
		private void SVDZMHUDWDX(OEXNRIBMWIU.ThemeOptions a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8E07590", Offset = "0x8E05F90", VA = "0x188E07590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8E07420", Offset = "0x8E05E20", VA = "0x188E07420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8E06FF0", Offset = "0x8E059F0", VA = "0x188E06FF0")]
		private void JBVZUAUFBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8E06CB0", Offset = "0x8E056B0", VA = "0x188E06CB0")]
		public void AddLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8E07890", Offset = "0x8E06290", VA = "0x188E07890")]
		public void RemoveLoadingSFXRequest(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8E07420", Offset = "0x8E05E20", VA = "0x188E07420")]
		private void NKSNOISMRNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8E071B0", Offset = "0x8E05BB0", VA = "0x188E071B0")]
		private void KHVAARXERER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8E07BC0", Offset = "0x8E065C0", VA = "0x188E07BC0")]
		private void XKYENRLMGQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8E06BC0", Offset = "0x8E055C0", VA = "0x188E06BC0")]
		private void AIDLSAZCYMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8E07D40", Offset = "0x8E06740", VA = "0x188E07D40")]
		private void YOFDQTIYXUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8E07AD0", Offset = "0x8E064D0", VA = "0x188E07AD0")]
		private void XHJISCMUALR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8E07D30", Offset = "0x8E06730", VA = "0x188E07D30")]
		private void XXVZFXSRSFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8E079E0", Offset = "0x8E063E0", VA = "0x188E079E0")]
		private void VHGYKXLJGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8E07FB0", Offset = "0x8E069B0", VA = "0x188E07FB0")]
		private void YVSWZQUDWUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E076B0", Offset = "0x8E060B0", VA = "0x188E076B0")]
		public void Play2DUIFlavorSFX(RecRoomAudioClip[] flavorSFXPool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8E07FF0", Offset = "0x8E069F0", VA = "0x188E07FF0")]
		public PaletteTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class PaletteThemeReference : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		protected static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private PaletteTheme paletteTheme;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected PaletteTheme ZGGXQHAQDRV
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected Palette SWBRFFTLNPY
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8E06A70", Offset = "0x8E05470", VA = "0x188E06A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected bool QOJFQIRDCYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8E06600", Offset = "0x8E05000", VA = "0x188E06600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected Transform BEMMAHTRHXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8E069F0", Offset = "0x8E053F0", VA = "0x188E069F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E06480", Offset = "0x8E04E80", VA = "0x188E06480", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E06840", Offset = "0x8E05240", VA = "0x188E06840", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Apply();

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8E06680", Offset = "0x8E05080", VA = "0x188E06680")]
		public Color? GetColorFromPalette(ForegroundColorPaletteType paletteType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8E06920", Offset = "0x8E05320", VA = "0x188E06920")]
		private void VDRVHJUPLBC(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		protected PaletteThemeReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class RangeSliderTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RangeSlider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private Image lowHandleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private Image highHandleImage;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public SliderPaletteType IGQSYDIPQSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8E09440", Offset = "0x8E07E40", VA = "0x188E09440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Image ZNEQYOKRWNV
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Image REKDRKEKBBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Image VPVPNYXMHDA
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Image ZBAUBNRUQKS
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool GISQAFARKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x7732700", Offset = "0x7731100", VA = "0x187732700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7732720", Offset = "0x7731120", VA = "0x187732720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8E090F0", Offset = "0x8E07AF0", VA = "0x188E090F0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8E093F0", Offset = "0x8E07DF0", VA = "0x188E093F0")]
		public RangeSliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class RawImageTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RawImage image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private RawImageColorPaletteType color;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public RawImageColorPaletteType YXVMYPCQUNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			get
			{
				return default(RawImageColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8E09440", Offset = "0x8E07E40", VA = "0x188E09440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8E09460", Offset = "0x8E07E60", VA = "0x188E09460", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8E09590", Offset = "0x8E07F90", VA = "0x188E09590")]
		public RawImageTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class RecyclingGridTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private YDUCWELXSJC recyclingGrid;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8E095E0", Offset = "0x8E07FE0", VA = "0x188E095E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8E09830", Offset = "0x8E08230", VA = "0x188E09830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8E097C0", Offset = "0x8E081C0", VA = "0x188E097C0")]
		private void DTBPMZTWVZC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8E09A10", Offset = "0x8E08410", VA = "0x188E09A10")]
		public RecyclingGridTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class RecyclingListTheme : RecyclingThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private YDUCWELXSJC recyclingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool QTYBNHMMXJZ;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8E09A60", Offset = "0x8E08460", VA = "0x188E09A60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8E09CF0", Offset = "0x8E086F0", VA = "0x188E09CF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8E09C80", Offset = "0x8E08680", VA = "0x188E09C80")]
		private void OZOYHMZSJGE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8E09A10", Offset = "0x8E08410", VA = "0x188E09A10")]
		public RecyclingListTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecyclingThemeBase : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[Header("Audio")]
		[SerializeField]
		private RecyclingAudioPaletteType recyclingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RecyclingAudioPaletteAsset YRXFJUFVNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollingAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ScrollingAudioPaletteAsset DQANOOPFKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private QPCWAZBUNTV BXKCPXXWMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private float XKNPWUZZZBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private float ZSIBTEMONGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private float YLZMDOXIXIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private float GLXUVLOQZMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private bool XPYJVDKEUNH;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private const float AMQYBFPZNYB = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private QPCWAZBUNTV RZNTYPIPUMW
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AD30", Offset = "0x8E09730", VA = "0x188E0AD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8E09ED0", Offset = "0x8E088D0", VA = "0x188E09ED0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A8E0", Offset = "0x8E092E0", VA = "0x188E0A8E0")]
		protected void PXLFMOHVXDN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A750", Offset = "0x8E09150", VA = "0x188E0A750")]
		protected void MXOXOMABBEV(GameObject a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8E0ABA0", Offset = "0x8E095A0", VA = "0x188E0ABA0")]
		protected void SWKLUUIGMCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A2A0", Offset = "0x8E08CA0", VA = "0x188E0A2A0")]
		protected void EYBMFXTLYAA(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A0B0", Offset = "0x8E08AB0", VA = "0x188E0A0B0")]
		private void ESSPRCYECSY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A610", Offset = "0x8E09010", VA = "0x188E0A610")]
		private void INUPRZAZFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8E09A10", Offset = "0x8E08410", VA = "0x188E09A10")]
		protected RecyclingThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ScrollBarTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[Header("Scroll Bar Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8E0ADC0", Offset = "0x8E097C0", VA = "0x188E0ADC0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AF00", Offset = "0x8E09900", VA = "0x188E0AF00")]
		public ScrollBarTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ScrollRectTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private const string XJFDKJPRXTV = "RRUI.PlayHittingEndsSFX";

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private const int TLADWFCKJGR = 5;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private const int CWQLTJZDJVR = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private DateTimeOffset DWWOQBMCKXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private int CJPWVLGVKDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private bool SOCFJFKQOZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private ScrollRect scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[Header("Audio")]
		[SerializeField]
		private ScrollingAudioPaletteType scrollAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ScrollingAudioPaletteAsset YRXFJUFVNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private QPCWAZBUNTV BXKCPXXWMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private MMTKFEAGWJH YDFRWRRIBQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private float ZSIBTEMONGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private float YLZMDOXIXIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private float GLXUVLOQZMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private bool XPYJVDKEUNH;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private const float AMQYBFPZNYB = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private QPCWAZBUNTV RZNTYPIPUMW
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C300", Offset = "0x8E0AD00", VA = "0x188E0C300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private MMTKFEAGWJH PCHTZAWTTDC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C270", Offset = "0x8E0AC70", VA = "0x188E0C270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AFF0", Offset = "0x8E099F0", VA = "0x188E0AFF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BD40", Offset = "0x8E0A740", VA = "0x188E0BD40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AF10", Offset = "0x8E09910", VA = "0x188E0AF10", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BE30", Offset = "0x8E0A830", VA = "0x188E0BE30")]
		private void UFPOUXEBYHM(Vector2 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B180", Offset = "0x8E09B80", VA = "0x188E0B180")]
		private void ESSPRCYECSY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B490", Offset = "0x8E09E90", VA = "0x188E0B490")]
		private void INUPRZAZFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B370", Offset = "0x8E09D70", VA = "0x188E0B370")]
		private static string HYZECZLWZHR(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C390", Offset = "0x8E0AD90", VA = "0x188E0C390")]
		public ScrollRectTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableThemeBase : PaletteThemeReference, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[Header("Selectable Theme Base")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[Header("Legacy Audio Override")]
		[SerializeField]
		[FormerlySerializedAs("overrideAudio")]
		[Tooltip("Override base selectable audio with a single SFX that plays only on click.")]
		protected bool overrideWithSingleAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[ConditionalField("overrideWithSingleAudio")]
		[Tooltip("The legacy override audio will be randomly picked from this pool")]
		protected RecRoomAudioClip[] randomAudioOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		protected bool IDIYWNMJNVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private ButtonAudioPaletteAsset YRXFJUFVNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private RecRoomAudioClipPoolConfig EOFHVAFELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private ONVESPKROXV KFGMYAJEYVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private ONVESPKROXV HQRKEJVDAVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private ONVESPKROXV JSYXYJAAUKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ONVESPKROXV ZDHOVJEUUBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private QPCWAZBUNTV BXKCPXXWMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private XCFBXCJGNRT UPKHCADWUCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private INGMKIEJMOM FYJKACHKKAG;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected Selectable QSCRJTBFJFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected virtual bool JCWVYLXKKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool GISQAFARKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x7732700", Offset = "0x7731100", VA = "0x187732700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7732720", Offset = "0x7731120", VA = "0x187732720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private QPCWAZBUNTV RZNTYPIPUMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8E0D210", Offset = "0x8E0BC10", VA = "0x188E0D210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected XCFBXCJGNRT QNLEFMTJTXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C420", Offset = "0x8E0AE20", VA = "0x188E0C420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private INGMKIEJMOM KWHVYMLOPUX
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C930", Offset = "0x8E0B330", VA = "0x188E0C930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CFD0", Offset = "0x8E0B9D0", VA = "0x188E0CFD0")]
		protected void QQKKIKSLETW(ButtonAudioPaletteAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
		protected void EQYNUQWMBZB(RecRoomAudioClipPoolConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CD40", Offset = "0x8E0B740", VA = "0x188E0CD40", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CEF0", Offset = "0x8E0B8F0", VA = "0x188E0CEF0", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C9D0", Offset = "0x8E0B3D0", VA = "0x188E0C9D0", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8E0CE20", Offset = "0x8E0B820", VA = "0x188E0CE20", Slot = "15")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D0D0", Offset = "0x8E0BAD0", VA = "0x188E0D0D0")]
		private void STPZQTLRDNF(RecRoomAudioClip[] a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C500", Offset = "0x8E0AF00", VA = "0x188E0C500")]
		private void GGWYFSWTXOT(RecRoomAudioClip a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D180", Offset = "0x8E0BB80", VA = "0x188E0D180")]
		public void SetOnPointerDownSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D1E0", Offset = "0x8E0BBE0", VA = "0x188E0D1E0")]
		public void SetOnPointerUpSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D150", Offset = "0x8E0BB50", VA = "0x188E0D150")]
		public void SetOnPointerClickSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D1B0", Offset = "0x8E0BBB0", VA = "0x188E0D1B0")]
		public void SetOnPointerEnterSoundEffectDisabled(object token, bool disabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C4C0", Offset = "0x8E0AEC0", VA = "0x188E0C4C0")]
		private void FIZEEHRDWNJ(ONVESPKROXV a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D2A0", Offset = "0x8E0BCA0", VA = "0x188E0D2A0")]
		protected SelectableThemeBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SliderTheme : SelectableThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[Header("Slider Visual")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Slider slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private SliderPaletteType sliderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Slider Audio")]
		[SerializeField]
		private ButtonAudioPaletteType buttonAudioType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Image sliderImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Image fillImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Image handleImage;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public SliderPaletteType IGQSYDIPQSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1360EB0", Offset = "0x135F8B0", VA = "0x181360EB0")]
			get
			{
				return default(SliderPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0D8A0", Offset = "0x8E0C2A0", VA = "0x188E0D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Image ZNEQYOKRWNV
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC4EB80", Offset = "0xC4D580", VA = "0x180C4EB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Image REKDRKEKBBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xC28940", Offset = "0xC27340", VA = "0x180C28940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Image YBFWYVLOKOW
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xC0E100", Offset = "0xC0CB00", VA = "0x180C0E100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D4B0", Offset = "0x8E0BEB0", VA = "0x188E0D4B0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D880", Offset = "0x8E0C280", VA = "0x188E0D880")]
		public SliderTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SurfaceTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private UIGradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private BackgroundColorPaletteType color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		[ConditionalField("gradient")]
		private bool ignoreGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private BackgroundColorPaletteType? USNTKJFYYTJ;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public BackgroundColorPaletteType BRFSSKZTKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DB70", Offset = "0x8E0C570", VA = "0x188E0DB70")]
			get
			{
				return default(BackgroundColorPaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DBD0", Offset = "0x8E0C5D0", VA = "0x188E0DBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D8C0", Offset = "0x8E0C2C0", VA = "0x188E0D8C0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DB00", Offset = "0x8E0C500", VA = "0x188E0DB00", Slot = "7")]
		public virtual void OverrideBackgroundColorPaletteAtRuntime(BackgroundColorPaletteType? backgroundPalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DB20", Offset = "0x8E0C520", VA = "0x188E0DB20")]
		public SurfaceTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SwitchTheme : ToggleTheme
	{
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private const float COBRBWKETXO = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[Header("Switch")]
		[SerializeField]
		private GameObject indicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject indicatorOffPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private GameObject indicatorOnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private NACNJAZEVXK RALXTLXPYAS;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DBF0", Offset = "0x8E0C5F0", VA = "0x188E0DBF0", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DE50", Offset = "0x8E0C850", VA = "0x188E0DE50")]
		public SwitchTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class TilerTheme : PaletteThemeReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private UITiler tiler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private TilerPaletteType type;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E460", Offset = "0x8E0CE60", VA = "0x188E0E460", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E6F0", Offset = "0x8E0D0F0", VA = "0x188E0E6F0")]
		public TilerTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class ToggleTheme : ButtonThemeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[Header("Toggle Visual")]
		[SerializeField]
		private TogglePaletteType toggleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is active.")]
		private List<Hideable> hideWhenNotActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		[Tooltip("A list of objects to show while the toggle is inactive")]
		private List<Hideable> hideWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private bool editorIsActiveOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[Header("Toggle Audio")]
		[SerializeField]
		[Tooltip("Override the audio palette when active defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenActive")]
		[Tooltip("Specify a custom config to use for toggle button audio when active")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		[Tooltip("Override the audio palette when inactive defined by the toggle's visual with a custom palette")]
		private bool overrideAudioPaletteWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		[ConditionalField("overrideAudioPaletteWhenInactive")]
		[Tooltip("Specify a custom config to use for toggle button audio when inactive")]
		private ButtonAudioPaletteAsset customButtonAudioConfigWhenInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[Tooltip("Layer a 2D SFX on top of base button sounds. Flavor SFX only plays when toggling from inactive to active")]
		private bool useFlavorSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		[ConditionalField("useFlavorSFX")]
		[Tooltip("Flavor SFX is picked randomly from this pool config")]
		private RecRoomAudioClipPoolConfig flavorSFXClipPoolConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		protected bool FKIQDJEQXUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private bool MKAWQABLJRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19A")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private bool QPQILGYESPL;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8E0EC00", Offset = "0x8E0D600", VA = "0x188E0EC00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8E0EC10", Offset = "0x8E0D610", VA = "0x188E0EC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public TogglePaletteType JKDPYOQBFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x18F1F60", Offset = "0x18F0960", VA = "0x1818F1F60")]
			get
			{
				return default(TogglePaletteType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8E023B0", Offset = "0x8E00DB0", VA = "0x188E023B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected override bool JCWVYLXKKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0EBF0", Offset = "0x8E0D5F0", VA = "0x188E0EBF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0EB30", Offset = "0x8E0D530", VA = "0x188E0EB30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0EBB0", Offset = "0x8E0D5B0", VA = "0x188E0EBB0")]
		public void Toggle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E0EB70", Offset = "0x8E0D570", VA = "0x188E0EB70")]
		public void Toggle(bool isActive, bool isInstant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E740", Offset = "0x8E0D140", VA = "0x188E0E740", Slot = "6")]
		public override void Apply()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DE50", Offset = "0x8E0C850", VA = "0x188E0DE50")]
		public ToggleTheme()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class ActiveEventThemeSwapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private string eventActiveGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private bool swapSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[ConditionalField("swapSprite")]
		[SerializeField]
		private Sprite targetSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private bool swapSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private SurfaceTheme targetSurfaceTheme;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[ConditionalField("swapSurfaceTheme")]
		[SerializeField]
		private BackgroundColorPaletteType targetPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private bool changeGradientDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient targetGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[ConditionalField("changeGradientDirection")]
		[SerializeField]
		private UIGradient.GradientType targetGradientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private VPWSVWWBFFU CQHIHMTPMYQ;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFE70", Offset = "0x8DFE870", VA = "0x188DFFE70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFDD0", Offset = "0x8DFE7D0", VA = "0x188DFFDD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFB80", Offset = "0x8DFE580", VA = "0x188DFFB80")]
		private void JUXTBSQITQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFA30", Offset = "0x8DFE430", VA = "0x188DFFA30")]
		private void AMXTWYDXNUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFFC0", Offset = "0x8DFE9C0", VA = "0x188DFFFC0")]
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
