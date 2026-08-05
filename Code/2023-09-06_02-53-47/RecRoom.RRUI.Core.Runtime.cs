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
		public enum PFKOHKMABIM : byte
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
		private static readonly int CLIKMIDFLON;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<PFKOHKMABIM, string> HGDKBIJMKMG;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int KAPNHAECKFJ = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int BPNCOMHANPK;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int DNMJMONHPJC;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int DEDMNKLMKFJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int KJCGIJEJHJI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int KKPGNDCOAHO;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int INPAKFONOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KBAPEDHMNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool BMOOEFAAGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] DGIOJGDLKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private PFKOHKMABIM type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly PFKOHKMABIM[] ICAODBJGDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[JMHBNGAJCDE("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly PFKOHKMABIM[] NEGIMMKIFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[JMHBNGAJCDE("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[JMHBNGAJCDE("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[JMHBNGAJCDE("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic AJPPNLCLGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool FEGAKMABMFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient EPCHKABNCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6B80", Offset = "0x6DD5180", VA = "0x186DD6B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public PFKOHKMABIM BJFLOLKBEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xBAC820", Offset = "0xBAAE20", VA = "0x180BAC820")]
			get
			{
				return default(PFKOHKMABIM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6D00", Offset = "0x6DD5300", VA = "0x186DD6D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool OCIMMOHJKAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5880", Offset = "0x6DD3E80", VA = "0x186DD5880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 IJGLGPDDMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6AF0", Offset = "0x6DD50F0", VA = "0x186DD6AF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6B30", Offset = "0x6DD5130", VA = "0x186DD6B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool BHOBJFKPNHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5ED0", Offset = "0x6DD44D0", VA = "0x186DD5ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 BPHEINFHLPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6B10", Offset = "0x6DD5110", VA = "0x186DD6B10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6CB0", Offset = "0x6DD52B0", VA = "0x186DD6CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float DHAJHOJPMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x12D7DB0", Offset = "0x12D63B0", VA = "0x1812D7DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1956740", Offset = "0x1954D40", VA = "0x181956740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 BMKELELEBBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5D10", Offset = "0x6DD4310", VA = "0x186DD5D10")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 ILPAJCFKPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5900", Offset = "0x6DD3F00", VA = "0x186DD5900")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float MIJBGJLEOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD35EC0", Offset = "0xD344C0", VA = "0x180D35EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6D10", Offset = "0x6DD5310", VA = "0x186DD6D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5970", Offset = "0x6DD3F70", VA = "0x186DD5970", Slot = "12")]
		protected override void DLBIOBCDMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5D60", Offset = "0x6DD4360", VA = "0x186DD5D60")]
		private void MHLNOPOPJMH(Color[] LGFGAMGPOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5F50", Offset = "0x6DD4550", VA = "0x186DD5F50", Slot = "13")]
		protected override void PGNEHOPLOIH(Material FMBPBGHJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5AF0", Offset = "0x6DD40F0", VA = "0x186DD5AF0", Slot = "14")]
		protected override void GAEKPPOEKBA(Material FMBPBGHJJDD, bool LHEAMNILFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6A30", Offset = "0x6DD5030", VA = "0x186DD6A30")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData BKAINJGKAIM;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2F40", Offset = "0x6DD1540", VA = "0x186DD2F40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2E30", Offset = "0x6DD1430", VA = "0x186DD2E30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2D70", Offset = "0x6DD1370", VA = "0x186DD2D70")]
		private void IJLNDELNPGN(GameObject HBANPIDHAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3130", Offset = "0x6DD1730", VA = "0x186DD3130")]
		public void SetOptionsWithNoDefault(List<string> AEEDPBOFDFB, [Optional] string LHPGNGACPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3370", Offset = "0x6DD1970", VA = "0x186DD3370")]
		public void SetOptionsWithNoDefault(List<OptionData> IGLCGHPCAIJ, [Optional] string LHPGNGACPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3050", Offset = "0x6DD1650", VA = "0x186DD3050", Slot = "42")]
		public override void OnPointerClick(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas AGADPOFFJHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3460", Offset = "0x6DD1A60", VA = "0x186DD3460")]
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
		public enum KNDKBNFLEBD
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int KLJKILHAGGF;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int JPOLGPAKLCN;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int FGMOGMBPCPB;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int CLKJEJHECDI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int AEIEEGFADLI;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int EABNKNMMKLA;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int FMLPPJLEOGK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int FPILBALKMFF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int JOKGFJMOHGN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int CLGCBHCKMBH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int GDKHKLHMELJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int LFFNKOEGDJC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CPDAIPPALKM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int NGCFICDCEHD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int HIJPNILHNGJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int DBHOEOMFNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
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
		private KNDKBNFLEBD animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[JMHBNGAJCDE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[JMHBNGAJCDE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic AJPPNLCLGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool INGNLDPCIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite ANLDFMHCHFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA7A0", Offset = "0x6DD8DA0", VA = "0x186DDA7A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA9B0", Offset = "0x6DD8FB0", VA = "0x186DDA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color FAIFCOFNENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9358F0", Offset = "0x933EF0", VA = "0x1809358F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6DDAA50", Offset = "0x6DD9050", VA = "0x186DDAA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color HLHMPKHNFJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE3A070", Offset = "0xE38670", VA = "0x180E3A070")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA8A0", Offset = "0x6DD8EA0", VA = "0x186DDA8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float IHCOAEHEHMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x13DF1D0", Offset = "0x13DD7D0", VA = "0x1813DF1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA940", Offset = "0x6DD8F40", VA = "0x186DDA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 MGFPNJFJOCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEDBE40", Offset = "0xEDA440", VA = "0x180EDBE40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA960", Offset = "0x6DD8F60", VA = "0x186DDA960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ENMONBGIHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x12D7E10", Offset = "0x12D6410", VA = "0x1812D7E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA900", Offset = "0x6DD8F00", VA = "0x186DDA900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KCFMDAHFMOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2236DB0", Offset = "0x22353B0", VA = "0x182236DB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6DDAAB0", Offset = "0x6DD90B0", VA = "0x186DDAAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FOALBMECACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1556FE0", Offset = "0x15555E0", VA = "0x181556FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA870", Offset = "0x6DD8E70", VA = "0x186DDA870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 PFGCPHPIGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6DD9A70", Offset = "0x6DD8070", VA = "0x186DD9A70")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KNDKBNFLEBD CNICMFHKMCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x92C1B0", Offset = "0x92A7B0", VA = "0x18092C1B0")]
			get
			{
				return default(KNDKBNFLEBD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA890", Offset = "0x6DD8E90", VA = "0x186DDA890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float NBINONCIMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1225440", Offset = "0x1223A40", VA = "0x181225440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA920", Offset = "0x6DD8F20", VA = "0x186DDA920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float MFALHMCOBPP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xEDBDE0", Offset = "0xEDA3E0", VA = "0x180EDBDE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6DDA850", Offset = "0x6DD8E50", VA = "0x186DDA850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9D60", Offset = "0x6DD8360", VA = "0x186DD9D60", Slot = "13")]
		protected override void PGNEHOPLOIH(Material FMBPBGHJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9AE0", Offset = "0x6DD80E0", VA = "0x186DD9AE0")]
		private void MKDDOFNOPAK(Sprite DBDPNJFLAFK, out Vector2 CPOMDJOHMGH, out Vector2 MMCFHEIKMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9A20", Offset = "0x6DD8020", VA = "0x186DD9A20", Slot = "14")]
		protected override void GAEKPPOEKBA(Material FMBPBGHJJDD, bool LHEAMNILFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA700", Offset = "0x6DD8D00", VA = "0x186DDA700")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader CIHNFMICPDI;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader NFGDLCOPCBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6DDAB60", Offset = "0x6DD9160", VA = "0x186DDAB60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DDAB00", Offset = "0x6DD9100", VA = "0x186DDAB00")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool ONBPLINMHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xC00670", Offset = "0xBFEC70", VA = "0x180C00670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> CDLMDOAGPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4900", Offset = "0x6DD2F00", VA = "0x186DD4900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4A40", Offset = "0x6DD3040", VA = "0x186DD4A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> MDGGOPHCMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DD49A0", Offset = "0x6DD2FA0", VA = "0x186DD49A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4AE0", Offset = "0x6DD30E0", VA = "0x186DD4AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4840", Offset = "0x6DD2E40", VA = "0x186DD4840", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD48A0", Offset = "0x6DD2EA0", VA = "0x186DD48A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x165D7B0", Offset = "0x165BDB0", VA = "0x18165D7B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x165D7B0", Offset = "0x165BDB0", VA = "0x18165D7B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LKGNEGILJJK
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum BLEAMJBOEBE
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static OEDCEGNGFJP BELMDGBOJMA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static OEDCEGNGFJP MCAOMKACLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4F80", Offset = "0x6DD3580", VA = "0x186DD4F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static BLEAMJBOEBE OJADMMJGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E70", Offset = "0x6DD3470", VA = "0x186DD4E70")]
		get
		{
			return default(BLEAMJBOEBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4D10", Offset = "0x6DD3310", VA = "0x186DD4D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<BLEAMJBOEBE> KAJBKAFHBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5110", Offset = "0x6DD3710", VA = "0x186DD5110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5050", Offset = "0x6DD3650", VA = "0x186DD5050")]
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
		private sealed class MGOGOJPIDMM : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private FOLOHDFBANO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public MGOGOJPIDMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6DD51D0", Offset = "0x6DD37D0", VA = "0x186DD51D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6DD5780", Offset = "0x6DD3D80", VA = "0x186DD5780", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[JFIDOIKGENA(JHNBNMNOADF.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DMMBJKBEDJE KHBPKPEPPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool ADFIJHJNAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? LLBKLPMELAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? COHOFNFENLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool? NDKONHNPONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool PCGIIIDHLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool LAJKGCIPHKN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool EEOGOIEMGNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4520", Offset = "0x6DD2B20", VA = "0x186DD4520", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GKGBCDIKMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4500", Offset = "0x6DD2B00", VA = "0x186DD4500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CNJICICILCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x15F86D0", Offset = "0x15F6CD0", VA = "0x1815F86D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4710", Offset = "0x6DD2D10", VA = "0x186DD4710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GJIPAPOHIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4460", Offset = "0x6DD2A60", VA = "0x186DD4460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4670", Offset = "0x6DD2C70", VA = "0x186DD4670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3E50", Offset = "0x6DD2450", VA = "0x186DD3E50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD41E0", Offset = "0x6DD27E0", VA = "0x186DD41E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD40E0", Offset = "0x6DD26E0", VA = "0x186DD40E0")]
		public void Hide(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4330", Offset = "0x6DD2930", VA = "0x186DD4330")]
		public void Show(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4280", Offset = "0x6DD2880", VA = "0x186DD4280")]
		public void Set(object DCEGGIJLHGI, bool OKJMLDNOHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3F30", Offset = "0x6DD2530", VA = "0x186DD3F30")]
		private void GHFIPOFHFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4170", Offset = "0x6DD2770", VA = "0x186DD4170")]
		[IteratorStateMachine(typeof(MGOGOJPIDMM))]
		private IEnumerator<FOLOHDFBANO> KDFKEHFKFIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3EF0", Offset = "0x6DD24F0", VA = "0x186DD3EF0", Slot = "5")]
		public virtual void DoHideOrShow(bool BJGLDAFNDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DD43C0", Offset = "0x6DD29C0", VA = "0x186DD43C0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[SerializeField]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12B000", Offset = "0x12A400")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int DHNJJAKGAPL;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int MDIPHCCGBAN;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int CLMLMHNEOMP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int GDGGAIAONDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Color[] DGIOJGDLKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float[] IAKDIDNJCCM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic AJPPNLCLGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool INGNLDPCIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> HOJNBLNEOPA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 IJGLGPDDMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4084F00", Offset = "0x4083500", VA = "0x184084F00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6DD99D0", Offset = "0x6DD7FD0", VA = "0x186DD99D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD96C0", Offset = "0x6DD7CC0", VA = "0x186DD96C0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> ONILJLFOOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9480", Offset = "0x6DD7A80", VA = "0x186DD9480")]
		public bool SetRingLayerColor(int BLKIFNMOPNO, Color CMDNLIJPJJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6DD95A0", Offset = "0x6DD7BA0", VA = "0x186DD95A0")]
		public bool SetRingLayerSize(int BLKIFNMOPNO, float OCMPILAHMAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9150", Offset = "0x6DD7750", VA = "0x186DD9150", Slot = "12")]
		protected override void DLBIOBCDMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9300", Offset = "0x6DD7900", VA = "0x186DD9300", Slot = "13")]
		protected override void PGNEHOPLOIH(Material FMBPBGHJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6DD92B0", Offset = "0x6DD78B0", VA = "0x186DD92B0", Slot = "14")]
		protected override void GAEKPPOEKBA(Material FMBPBGHJJDD, bool LHEAMNILFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9810", Offset = "0x6DD7E10", VA = "0x186DD9810")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly HDBCOENEHOL CDKLMEBGHOO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Sprite AIBMEDOPGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Material PHOBLGLNHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Material OPMAAFCJMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool BAAOACJFLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool ADFIJHJNAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool FEIIFFBDAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool KJFAAKHOEGK;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic AJPPNLCLGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader NFGDLCOPCBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool FEGAKMABMFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool INGNLDPCIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform PNDLDNNINND
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8820", Offset = "0x6DD6E20", VA = "0x186DD8820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect PFBHNGMNLEI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7EF0", Offset = "0x6DD64F0", VA = "0x186DD7EF0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite OIBHOHBIMLA
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6DD8020", Offset = "0x6DD6620", VA = "0x186DD8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7D00", Offset = "0x6DD6300", VA = "0x186DD7D00", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8B20", Offset = "0x6DD7120", VA = "0x186DD8B20", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8E50", Offset = "0x6DD7450", VA = "0x186DD8E50", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8CD0", Offset = "0x6DD72D0", VA = "0x186DD8CD0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8E60", Offset = "0x6DD7460", VA = "0x186DD8E60")]
		private void PKKHGKGJOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8580", Offset = "0x6DD6B80", VA = "0x186DD8580")]
		private void ENFLFFNNBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8880", Offset = "0x6DD6E80", VA = "0x186DD8880")]
		private void LECGAIANHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7CB0", Offset = "0x6DD62B0", VA = "0x186DD7CB0")]
		private void AJPOHLCMNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6DD88B0", Offset = "0x6DD6EB0", VA = "0x186DD88B0")]
		protected void LMLIDABNHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6DD86E0", Offset = "0x6DD6CE0", VA = "0x186DD86E0")]
		private void FBMPDEOKODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "12")]
		protected virtual void DLBIOBCDMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
		protected virtual void PGNEHOPLOIH(Material FMBPBGHJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "14")]
		protected virtual void GAEKPPOEKBA(Material FMBPBGHJJDD, bool LHEAMNILFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD81F0", Offset = "0x6DD67F0", VA = "0x186DD81F0")]
		private void DKCNJHGIPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JEMFJJDENGK : MCIHOOFFKJG, OAEFFLFJCIK, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MAOADMCMPGC<GameObject, int> JLBNMKLOAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BMDPADGKOAA<GameObject, int, bool> CPGFBBMIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AFANAFKFEIG<bool> IECJDNAPLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool GKIMOCENNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float LKLDJIALIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AFANAFKFEIG<float> MFONOPFEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IOAJAPLOKEP PFFJNBCHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject LMLNLGDAFGM);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLPKALPBBAA Spawn<T>(int KKOPBBDINKC, IReadOnlyList<T> JAIGDBINGHO, GameObject LMLNLGDAFGM);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HLPKALPBBAA Spawn<T>(int KKOPBBDINKC, IReadOnlyList<T> JAIGDBINGHO, GameObject MACPLJAMCJA, ref Func<int, GameObject> GIALELJDEKM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int OLGOBCPPPBB, float NLPLEGFAPNE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDBCOENEHOL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct JGHBBMFOOEK : IEquatable<JGHBBMFOOEK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Component MFPELEJLJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Action KDPLLHOFMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly int MOGFDMKDMCM;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component NDDINENAOMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4CB0", Offset = "0x6DD32B0", VA = "0x186DD4CB0")]
		public JGHBBMFOOEK(Component MFPELEJLJLD, Action KDPLLHOFMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4B80", Offset = "0x6DD3180", VA = "0x186DD4B80")]
		public void DMAOLGACNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4C90", Offset = "0x6DD3290", VA = "0x186DD4C90", Slot = "4")]
		public bool Equals(JGHBBMFOOEK FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4C00", Offset = "0x6DD3200", VA = "0x186DD4C00", Slot = "0")]
		public override bool Equals(object NKFOPKJGBEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BFKFAOCOJIG : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HDBCOENEHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IOrderedEnumerable<JGHBBMFOOEK> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private JGHBBMFOOEK <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public BFKFAOCOJIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2920", Offset = "0x6DD0F20", VA = "0x186DD2920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2D30", Offset = "0x6DD1330", VA = "0x186DD2D30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly EEJKPJOEJFO MJFHIMIBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int PDJLBPCDGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly int HBCFNOEELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<Component, float> GALADMJDFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<Component, JGHBBMFOOEK> NAGOJGDBHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LinkedList<JGHBBMFOOEK> INGMNIHALDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<JGHBBMFOOEK> LLAEGABPIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private BDPNFFCBKDC LEPAPACBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private KCLDNOPPPHO KHJEEINBHJF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private KCLDNOPPPHO PEGCKOKOPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6DD39A0", Offset = "0x6DD1FA0", VA = "0x186DD39A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3CF0", Offset = "0x6DD22F0", VA = "0x186DD3CF0")]
	public HDBCOENEHOL(EEJKPJOEJFO MJFHIMIBLCJ, int PDJLBPCDGEK = -1, int HBCFNOEELMJ = -1, [Optional] Func<Component, float> GALADMJDFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD34D0", Offset = "0x6DD1AD0", VA = "0x186DD34D0")]
	public void CMEBPLKANGG(Component MFPELEJLJLD, Action KMPBAECDEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3810", Offset = "0x6DD1E10", VA = "0x186DD3810")]
	public void KENNMBAPGJM(Component MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD37B0", Offset = "0x6DD1DB0", VA = "0x186DD37B0")]
	public bool HKJCAFENFPN(Component JPNJMHFMKKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3AD0", Offset = "0x6DD20D0", VA = "0x186DD3AD0")]
	private void OKLFFBLBOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3740", Offset = "0x6DD1D40", VA = "0x186DD3740")]
	[IteratorStateMachine(typeof(BFKFAOCOJIG))]
	private IEnumerator<FOLOHDFBANO> DBBDMAKOIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x113F570", Offset = "0x113DB70", VA = "0x18113F570")]
	[CompilerGenerated]
	private void BIDFJFIECIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3A10", Offset = "0x6DD2010", VA = "0x186DD3A10")]
	[CompilerGenerated]
	private float OIMIPMMAMOG(JGHBBMFOOEK KMPBAECDEGL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FCAJKCLENHE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NKKANIHCHEN MOCKFEHPLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PCLHJMECJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AFANAFKFEIG<NKKANIHCHEN> APEIDNDJCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHNBODCKMHP(NKKANIHCHEN BNAGFJMIEOG, bool IJCICBKMOEF = false);
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class UIHandleDecorator : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class UIHandleEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Vector2 cachedScreenPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float cachedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public Vector3 targetForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public Vector3 previousTargetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public RectTransform cachedRectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public Vector3 pressLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public Quaternion pressRotationOffset;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public Vector3 RemappedWorldPressPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0x6DD7BA0", Offset = "0x6DD61A0", VA = "0x186DD7BA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6DD7C00", Offset = "0x6DD6200", VA = "0x186DD7C00")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6DD7B50", Offset = "0x6DD6150", VA = "0x186DD7B50")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7820", Offset = "0x6DD5E20", VA = "0x186DD7820")]
			public void ONMBIDHNAAD(PointerEventData MNNLILHGFGH, RectTransform PNDLDNNINND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6DD7A30", Offset = "0x6DD6030", VA = "0x186DD7A30")]
			public void PINHMMGCHAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6DD76D0", Offset = "0x6DD5CD0", VA = "0x186DD76D0")]
			public void DNPDABMDCLN(PointerEventData MNNLILHGFGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6DD77D0", Offset = "0x6DD5DD0", VA = "0x186DD77D0")]
			public void GFIBEIBNDLG(float EGPHAOEAMNG, RectTransform PNDLDNNINND, Vector3 IPKLBGKEJKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[GBPFONMOEMB(JHNBNMNOADF.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly AFANAFKFEIG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly AFANAFKFEIG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly AFANAFKFEIG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly AFANAFKFEIG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly AFANAFKFEIG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly IOAJAPLOKEP PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly UIHandleEventData FDFHOKKFENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool ABPAJHJKJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool CAIOFLOADNF;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool CKEMEJEHEFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FD690", VA = "0x1807FF090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6DC0", Offset = "0x6DD53C0", VA = "0x186DD6DC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool DFGIAGOCNJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDFE5A0", Offset = "0xDFCBA0", VA = "0x180DFE5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6DF0", Offset = "0x6DD53F0", VA = "0x186DD6DF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6D30", Offset = "0x6DD5330", VA = "0x186DD6D30")]
		private bool CCCCIACGKDD(PointerEventData FJJCHOOHLJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6DD73D0", Offset = "0x6DD59D0", VA = "0x186DD73D0", Slot = "5")]
		public void OnPointerDown(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7490", Offset = "0x6DD5A90", VA = "0x186DD7490", Slot = "11")]
		public void OnPointerUp(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7130", Offset = "0x6DD5730", VA = "0x186DD7130", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6E20", Offset = "0x6DD5420", VA = "0x186DD6E20", Slot = "7")]
		public void OnBeginDrag(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F50", Offset = "0x6DD5550", VA = "0x186DD6F50", Slot = "4")]
		public void OnDrag(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7040", Offset = "0x6DD5640", VA = "0x186DD7040", Slot = "8")]
		public void OnEndDrag(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7430", Offset = "0x6DD5A30", VA = "0x186DD7430", Slot = "9")]
		public void OnPointerEnter(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7460", Offset = "0x6DD5A60", VA = "0x186DD7460", Slot = "10")]
		public void OnPointerExit(PointerEventData FJJCHOOHLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F10", Offset = "0x6DD5510", VA = "0x186DD6F10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6DD74F0", Offset = "0x6DD5AF0", VA = "0x186DD74F0")]
		public UIHandleDecorator()
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
