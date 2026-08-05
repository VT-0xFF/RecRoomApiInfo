using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum LICNFEDPKIO : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly int BELFMJFMIFG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<LICNFEDPKIO, string> OBDOLBAFEBJ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int ACNMJFFKOOH = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int OJAFPOPFLJD;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int ACHJJMILNAH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int NPBGMMONLPO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int FLNFLLEILBF;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int BHFFABDGCGM;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int PIKBLPGLMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool AIMNOMNGMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool MHNOKJLEMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] CJAHLHDCJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private LICNFEDPKIO type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly LICNFEDPKIO[] KBMJJIOHCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[FDKNKMFDEBB("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LICNFEDPKIO[] MPKGABIBOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[FDKNKMFDEBB("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[FDKNKMFDEBB("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[FDKNKMFDEBB("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic KAPELOPCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IPAMIBOEBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient FPCJPCHLCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6C90", Offset = "0x6FF5E90", VA = "0x186FF6C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LICNFEDPKIO PDFLIGHJGJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x98D6F0", Offset = "0x98C8F0", VA = "0x18098D6F0")]
			get
			{
				return default(LICNFEDPKIO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6E10", Offset = "0x6FF6010", VA = "0x186FF6E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool GPAEKAHNIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6FF5CA0", Offset = "0x6FF4EA0", VA = "0x186FF5CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 HLEPPDKPGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6C20", Offset = "0x6FF5E20", VA = "0x186FF6C20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6C40", Offset = "0x6FF5E40", VA = "0x186FF6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool DDFLHIPIMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF59B0", Offset = "0x6FF4BB0", VA = "0x186FF59B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 OBDPABMOAJF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6CF8580", Offset = "0x6CF7780", VA = "0x186CF8580")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6DC0", Offset = "0x6FF5FC0", VA = "0x186FF6DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float DLAFBCFAPMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1B10420", Offset = "0x1B0F620", VA = "0x181B10420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2B53FA0", Offset = "0x2B531A0", VA = "0x182B53FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 CIEIMFHMEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FF5C50", Offset = "0x6FF4E50", VA = "0x186FF5C50")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 PEKCJAHIDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6710", Offset = "0x6FF5910", VA = "0x186FF6710")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float OBAMOJEHOAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1B025B0", Offset = "0x1B017B0", VA = "0x181B025B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6E20", Offset = "0x6FF6020", VA = "0x186FF6E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5E90", Offset = "0x6FF5090", VA = "0x186FF5E90", Slot = "12")]
		protected override void LIDHLBIDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5D20", Offset = "0x6FF4F20", VA = "0x186FF5D20")]
		private void JIJJODNFLKB(Color[] KOLMLPOBEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6010", Offset = "0x6FF5210", VA = "0x186FF6010", Slot = "13")]
		protected override void PBLBLFJDHAN(Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5A30", Offset = "0x6FF4C30", VA = "0x186FF5A30", Slot = "14")]
		protected override void DBLGPKDPGKN(Material LGBCNNOGHMI, bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6B60", Offset = "0x6FF5D60", VA = "0x186FF6B60")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData PAKMDLPJCPA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3250", Offset = "0x6FF2450", VA = "0x186FF3250", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3140", Offset = "0x6FF2340", VA = "0x186FF3140", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3080", Offset = "0x6FF2280", VA = "0x186FF3080")]
		private void GJOADOBKAPN(GameObject GNMGJIBIOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3440", Offset = "0x6FF2640", VA = "0x186FF3440")]
		public void SetOptionsWithNoDefault(List<string> DNDGJFJKDEB, [Optional] string BMAGEIBIHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3680", Offset = "0x6FF2880", VA = "0x186FF3680")]
		public void SetOptionsWithNoDefault(List<OptionData> HIMIFCBAJPG, [Optional] string BMAGEIBIHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3360", Offset = "0x6FF2560", VA = "0x186FF3360", Slot = "42")]
		public override void OnPointerClick(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86F940", Offset = "0x86EB40", VA = "0x18086F940", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas OMHHPIMOBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3770", Offset = "0x6FF2970", VA = "0x186FF3770")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum LKHHHKCKCBH
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int IHPAEHHDNMN;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int OJHCCIEAIFJ;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int OEEMFJOOMPC;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int GKNDOFFANGJ;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int JAMJIJLOEKL;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int DOHLHPGKHHH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int MGEKJBAODJK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int DHKDMENBCFM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int FNGJJCKPCAG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int MCIMBLJIGJL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int BGIDPJKKHNI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NCMMGAOGEJH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PCBIFHNLGKE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BBFDANCHDKC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int EIAILGNKPLI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int KCGPBMJNGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[Tooltip("The offset applied to each alternating row or column.")]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private LKHHHKCKCBH animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[FDKNKMFDEBB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[FDKNKMFDEBB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic KAPELOPCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool AKHLCJKPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite BCCGIEAMCKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FFA8B0", Offset = "0x6FF9AB0", VA = "0x186FFA8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAAC0", Offset = "0x6FF9CC0", VA = "0x186FFAAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color IHGAIDHOCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x945080", Offset = "0x944280", VA = "0x180945080")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAB60", Offset = "0x6FF9D60", VA = "0x186FFAB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color EIIPFBIOPPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC2FA60", Offset = "0xC2EC60", VA = "0x180C2FA60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FFA9B0", Offset = "0x6FF9BB0", VA = "0x186FFA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float CJIBLMPPHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xC89590", Offset = "0xC88790", VA = "0x180C89590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAA50", Offset = "0x6FF9C50", VA = "0x186FFAA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 KEKHNCDJFHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1CAC320", Offset = "0x1CAB520", VA = "0x181CAC320")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAA70", Offset = "0x6FF9C70", VA = "0x186FFAA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OAELCJGKCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9E8150", Offset = "0x9E7350", VA = "0x1809E8150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAA10", Offset = "0x6FF9C10", VA = "0x186FFAA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 ECDHJDBNPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1229C70", Offset = "0x1228E70", VA = "0x181229C70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FFABC0", Offset = "0x6FF9DC0", VA = "0x186FFABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ALCAGPIMNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5F50", Offset = "0x1BA5150", VA = "0x181BA5F50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FFA980", Offset = "0x6FF9B80", VA = "0x186FFA980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 NANGJMCGPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FF9E00", Offset = "0x6FF9000", VA = "0x186FF9E00")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LKHHHKCKCBH EJCEGJBANEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCEB3B0", Offset = "0xCEA5B0", VA = "0x180CEB3B0")]
			get
			{
				return default(LKHHHKCKCBH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FFA9A0", Offset = "0x6FF9BA0", VA = "0x186FFA9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DDELGAMPAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x107CD30", Offset = "0x107BF30", VA = "0x18107CD30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAA30", Offset = "0x6FF9C30", VA = "0x186FFAA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float DLIDCJHDNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x19204C0", Offset = "0x191F6C0", VA = "0x1819204C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FFA960", Offset = "0x6FF9B60", VA = "0x186FFA960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9E70", Offset = "0x6FF9070", VA = "0x186FF9E70", Slot = "13")]
		protected override void PBLBLFJDHAN(Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9B80", Offset = "0x6FF8D80", VA = "0x186FF9B80")]
		private void JAELJHALADD(Sprite HGKPDKDHOJN, out Vector2 AFLJONBGJEF, out Vector2 APLPBMIFHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9B30", Offset = "0x6FF8D30", VA = "0x186FF9B30", Slot = "14")]
		protected override void DBLGPKDPGKN(Material LGBCNNOGHMI, bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA810", Offset = "0x6FF9A10", VA = "0x186FFA810")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader BLOJICJDFIL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader DGFGKDIBFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAC70", Offset = "0x6FF9E70", VA = "0x186FFAC70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAC10", Offset = "0x6FF9E10", VA = "0x186FFAC10")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool FLPPJOMFIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x911DB0", Offset = "0x910FB0", VA = "0x180911DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> PBHGCAHDCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FF48A0", Offset = "0x6FF3AA0", VA = "0x186FF48A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FF49E0", Offset = "0x6FF3BE0", VA = "0x186FF49E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> DLBIKGEHCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4940", Offset = "0x6FF3B40", VA = "0x186FF4940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4A80", Offset = "0x6FF3C80", VA = "0x186FF4A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF47E0", Offset = "0x6FF39E0", VA = "0x186FF47E0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4840", Offset = "0x6FF3A40", VA = "0x186FF4840", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x334D610", Offset = "0x334C810", VA = "0x18334D610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x334D610", Offset = "0x334C810", VA = "0x18334D610")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CKPMDBIBJAB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DAJGHIMBLNE
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const DAJGHIMBLNE KHPAIIDIGDF = DAJGHIMBLNE.Light;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const string JNOEBAGGCMM = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static NMEPAPEIDNF LOKPOCGODFG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static NMEPAPEIDNF OCMLDNMAHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2FB0", Offset = "0x6FF21B0", VA = "0x186FF2FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static DAJGHIMBLNE JGKJFOOJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2DE0", Offset = "0x6FF1FE0", VA = "0x186FF2DE0")]
		get
		{
			return default(DAJGHIMBLNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2C80", Offset = "0x6FF1E80", VA = "0x186FF2C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<DAJGHIMBLNE> ECFGOCMDFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2EF0", Offset = "0x6FF20F0", VA = "0x186FF2EF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2BC0", Offset = "0x6FF1DC0", VA = "0x186FF2BC0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EPEHDGPIODC : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public EPEHDGPIODC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FF37E0", Offset = "0x6FF29E0", VA = "0x186FF37E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3DB0", Offset = "0x6FF2FB0", VA = "0x186FF3DB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly COJCOIOHKKE BPMDANKKJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool MBEFHNHMCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3? KFNCKFIHNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool? CHMGKEEFJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool? MDKPOHMPGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool FIIFJELFIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool MKOFDCDNMCG;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool EKLBDNIJFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FF44C0", Offset = "0x6FF36C0", VA = "0x186FF44C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GOCKGKGBDOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6FF44A0", Offset = "0x6FF36A0", VA = "0x186FF44A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool INDHMAJACOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1D05330", Offset = "0x1D04530", VA = "0x181D05330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6FF46B0", Offset = "0x6FF38B0", VA = "0x186FF46B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action INJGCPNCNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4400", Offset = "0x6FF3600", VA = "0x186FF4400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4610", Offset = "0x6FF3810", VA = "0x186FF4610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3DF0", Offset = "0x6FF2FF0", VA = "0x186FF3DF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4180", Offset = "0x6FF3380", VA = "0x186FF4180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF40F0", Offset = "0x6FF32F0", VA = "0x186FF40F0")]
		public void Hide(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF42D0", Offset = "0x6FF34D0", VA = "0x186FF42D0")]
		public void Show(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4220", Offset = "0x6FF3420", VA = "0x186FF4220")]
		public void Set(object IBIKCCMDMHA, bool NKBCOODPGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3F40", Offset = "0x6FF3140", VA = "0x186FF3F40")]
		private void HKNNCKBJNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3E90", Offset = "0x6FF3090", VA = "0x186FF3E90")]
		[IteratorStateMachine(typeof(EPEHDGPIODC))]
		private IEnumerator<HGAIOCFFOOA> BJHNLKNKBBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3F00", Offset = "0x6FF3100", VA = "0x186FF3F00", Slot = "5")]
		public virtual void DoHideOrShow(bool KPLKCFHPJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4360", Offset = "0x6FF3560", VA = "0x186FF4360")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[SerializeField]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xADD50", Offset = "0xAD150")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int ANBBNCAGEBC;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int HPAHFGJKEGJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly int HEFFODABCKM;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int LGAMCIENMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private Color[] CJAHLHDCJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private float[] KKOABEKFCDC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic KAPELOPCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool AKHLCJKPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> AEICGLMOADG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 HLEPPDKPGOD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xC895D0", Offset = "0xC887D0", VA = "0x180C895D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6FF9AE0", Offset = "0x6FF8CE0", VA = "0x186FF9AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF97D0", Offset = "0x6FF89D0", VA = "0x186FF97D0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> NGGLODOKMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9590", Offset = "0x6FF8790", VA = "0x186FF9590")]
		public bool SetRingLayerColor(int DFIMFAKAJAB, Color MBOFNGAOJFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FF96B0", Offset = "0x6FF88B0", VA = "0x186FF96B0")]
		public bool SetRingLayerSize(int DFIMFAKAJAB, float KOIBEABAMCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FF92B0", Offset = "0x6FF84B0", VA = "0x186FF92B0", Slot = "12")]
		protected override void LIDHLBIDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9410", Offset = "0x6FF8610", VA = "0x186FF9410", Slot = "13")]
		protected override void PBLBLFJDHAN(Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9260", Offset = "0x6FF8460", VA = "0x186FF9260", Slot = "14")]
		protected override void DBLGPKDPGKN(Material LGBCNNOGHMI, bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9920", Offset = "0x6FF8B20", VA = "0x186FF9920")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly NCPGIKHGGLN MMAJFADCJBL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static Sprite JNADMMOEANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material MHHFKGACDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Material HPHEMJCDBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool BNAINGOMOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool MBEFHNHMCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool CBFEOLHMIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool BGBEMFDFBIH;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic KAPELOPCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader DGFGKDIBFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool IPAMIBOEBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool AKHLCJKPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform LLBMEIHDGAP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF8A60", Offset = "0x6FF7C60", VA = "0x186FF8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect ENAGBCDJFNG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF87B0", Offset = "0x6FF79B0", VA = "0x186FF87B0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite GMNBIONJKDC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7FB0", Offset = "0x6FF71B0", VA = "0x186FF7FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7DC0", Offset = "0x6FF6FC0", VA = "0x186FF7DC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8DB0", Offset = "0x6FF7FB0", VA = "0x186FF8DB0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF90E0", Offset = "0x6FF82E0", VA = "0x186FF90E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8F60", Offset = "0x6FF8160", VA = "0x186FF8F60", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FF88E0", Offset = "0x6FF7AE0", VA = "0x186FF88E0")]
		private void HDNDLMBCBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8510", Offset = "0x6FF7710", VA = "0x186FF8510")]
		private void GPJFOOJFFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8D80", Offset = "0x6FF7F80", VA = "0x186FF8D80")]
		private void OBJMDNHIPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8D30", Offset = "0x6FF7F30", VA = "0x186FF8D30")]
		private void LOFIJKLEDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8AC0", Offset = "0x6FF7CC0", VA = "0x186FF8AC0")]
		protected void KEADIKDKEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8670", Offset = "0x6FF7870", VA = "0x186FF8670")]
		private void HANNMJCLJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "12")]
		protected virtual void LIDHLBIDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "13")]
		protected virtual void PBLBLFJDHAN(Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "14")]
		protected virtual void DBLGPKDPGKN(Material LGBCNNOGHMI, bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8180", Offset = "0x6FF7380", VA = "0x186FF8180")]
		private void EAPKGHFPJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		[Conditional("RRUI_PROFILING")]
		protected void BPMCKDIHFIE(string ABEFDBJEOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		[Conditional("RRUI_PROFILING")]
		protected void BJHENNODMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ELEEDNKGOKL : LOJPLEBBNAH, DGNIBCBPLLE, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PDLBGMFECHE<GameObject, int> HFFAHNEGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CBFDCKFJGDP<GameObject, int, bool> EJBJLLJKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	KODDBGBLBCG<bool> LCCNKHOAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GMDKGEGCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float PENHCPIEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	KODDBGBLBCG<float> DFGHKMOAGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CJPPGPOGFKM NMIEDNIDIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject AHDDCNOKJEA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMEJLKMBIHL Spawn<T>(int PAMDNNHIEEA, IReadOnlyList<T> JCEJEOAKGOJ, GameObject AHDDCNOKJEA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MMEJLKMBIHL Spawn<T>(int PAMDNNHIEEA, IReadOnlyList<T> JCEJEOAKGOJ, GameObject PDMFOEDKCNO, ref Func<int, GameObject> GGPNBANJELD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NCPGIKHGGLN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct BCJOPGNKEGI : IEquatable<BCJOPGNKEGI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Component APPLJOFCBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Action LLKOIPHHMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int EECCGPEGPPH;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component LPJLFJOGNIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2B60", Offset = "0x6FF1D60", VA = "0x186FF2B60")]
		public BCJOPGNKEGI(Component APPLJOFCBIB, Action LLKOIPHHMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2A30", Offset = "0x6FF1C30", VA = "0x186FF2A30")]
		public void AGDCFCDLKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2AB0", Offset = "0x6FF1CB0", VA = "0x186FF2AB0", Slot = "4")]
		public bool Equals(BCJOPGNKEGI HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2AD0", Offset = "0x6FF1CD0", VA = "0x186FF2AD0", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KCDPLHLOIMM : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NCPGIKHGGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IOrderedEnumerable<BCJOPGNKEGI> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private BCJOPGNKEGI <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public KCDPLHLOIMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4B20", Offset = "0x6FF3D20", VA = "0x186FF4B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4F30", Offset = "0x6FF4130", VA = "0x186FF4F30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int MDFLGLBFJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly int JDGGPCNFEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Component, float> PFELJOOIMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Component, BCJOPGNKEGI> MHMFDFNPHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LinkedList<BCJOPGNKEGI> IJOABPPJONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<BCJOPGNKEGI> PBBLMNCLPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HDFNBFCGAOH IOBKBNILENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private JGCJPDMMFLO MDDKAJHBOJF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private JGCJPDMMFLO ILMBBLJNGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5090", Offset = "0x6FF4290", VA = "0x186FF5090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5790", Offset = "0x6FF4990", VA = "0x186FF5790")]
	public NCPGIKHGGLN(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, int MDFLGLBFJIC = -1, int JDGGPCNFEHI = -1, [Optional] Func<Component, float> PFELJOOIMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5100", Offset = "0x6FF4300", VA = "0x186FF5100")]
	public void KCDHKFJLKEL(Component APPLJOFCBIB, Action IAFPJLJBHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5370", Offset = "0x6FF4570", VA = "0x186FF5370")]
	public void LPEIHJOIAKN(Component APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5030", Offset = "0x6FF4230", VA = "0x186FF5030")]
	public bool FCBOMGKGLMA(Component FEFGGGJBLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5570", Offset = "0x6FF4770", VA = "0x186FF5570")]
	private void PLAKPPJGINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5500", Offset = "0x6FF4700", VA = "0x186FF5500")]
	[IteratorStateMachine(typeof(KCDPLHLOIMM))]
	private IEnumerator<HGAIOCFFOOA> ODMEPFKPNPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23B7820", Offset = "0x23B6A20", VA = "0x1823B7820")]
	[CompilerGenerated]
	private void GPJBMLENPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4F70", Offset = "0x6FF4170", VA = "0x186FF4F70")]
	[CompilerGenerated]
	private float EFLBFJIHCKO(BCJOPGNKEGI IAFPJLJBHFI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IGMBDHNAGOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DOBDPJBPOMH
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LMOJCMEKPLF ACKIJAKCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool DPGNEEJGEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KODDBGBLBCG<LMOJCMEKPLF> KECEFPJABKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LODPKPAIMHA(LMOJCMEKPLF LFLCEPKJEEN, bool BDCAGGLLDDA = false);
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class UIHandleDecorator : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class UIHandleEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Vector2 cachedScreenPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float cachedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Vector3 targetForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public Vector3 previousTargetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public RectTransform cachedRectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public Vector3 pressLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Quaternion pressRotationOffset;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public Vector3 RemappedWorldPressPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6FF7CB0", Offset = "0x6FF6EB0", VA = "0x186FF7CB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6FF7D10", Offset = "0x6FF6F10", VA = "0x186FF7D10")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6FF7C60", Offset = "0x6FF6E60", VA = "0x186FF7C60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7950", Offset = "0x6FF6B50", VA = "0x186FF7950")]
			public void GGPBHLOJBEH(PointerEventData NHONDIIJFBF, RectTransform LLBMEIHDGAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7830", Offset = "0x6FF6A30", VA = "0x186FF7830")]
			public void DNFLKENHJOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7B60", Offset = "0x6FF6D60", VA = "0x186FF7B60")]
			public void INLFICEFLKA(PointerEventData NHONDIIJFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6FF77E0", Offset = "0x6FF69E0", VA = "0x186FF77E0")]
			public void CDDEAMBLLHK(float GGHCLJBBDML, RectTransform LLBMEIHDGAP, Vector3 PMKBAJECIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly KODDBGBLBCG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly KODDBGBLBCG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly KODDBGBLBCG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly KODDBGBLBCG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly KODDBGBLBCG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly CJPPGPOGFKM PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly UIHandleEventData LAGALGJNNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool JCOEHPNDPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool PCABCHCNCLG;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool NHNJFJBJMDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xABAB30", Offset = "0xAB9D30", VA = "0x180ABAB30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6E40", Offset = "0x6FF6040", VA = "0x186FF6E40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool GPFCHOKJLDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABABD0", Offset = "0xAB9DD0", VA = "0x180ABABD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6F00", Offset = "0x6FF6100", VA = "0x186FF6F00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6E70", Offset = "0x6FF6070", VA = "0x186FF6E70")]
		private bool ELEGICKCCAG(PointerEventData NHCCLIMEPFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF74E0", Offset = "0x6FF66E0", VA = "0x186FF74E0", Slot = "5")]
		public void OnPointerDown(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF75A0", Offset = "0x6FF67A0", VA = "0x186FF75A0", Slot = "11")]
		public void OnPointerUp(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7240", Offset = "0x6FF6440", VA = "0x186FF7240", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6F30", Offset = "0x6FF6130", VA = "0x186FF6F30", Slot = "7")]
		public void OnBeginDrag(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7060", Offset = "0x6FF6260", VA = "0x186FF7060", Slot = "4")]
		public void OnDrag(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7150", Offset = "0x6FF6350", VA = "0x186FF7150", Slot = "8")]
		public void OnEndDrag(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7540", Offset = "0x6FF6740", VA = "0x186FF7540", Slot = "9")]
		public void OnPointerEnter(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7570", Offset = "0x6FF6770", VA = "0x186FF7570", Slot = "10")]
		public void OnPointerExit(PointerEventData NHCCLIMEPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7020", Offset = "0x6FF6220", VA = "0x186FF7020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7600", Offset = "0x6FF6800", VA = "0x186FF7600")]
		public UIHandleDecorator()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
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
