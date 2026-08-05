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
		public enum LKHBKEDLLBN : byte
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
		private static readonly int COGNPHAEFHO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<LKHBKEDLLBN, string> DEHCDMAAAJI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int LKAGPOKNPHG = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int FHCEPMOBGNO;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int FABHJBJIJKF;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int PKKKCJHNHKN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int MMLBIBDEHHO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int IANDGDCKEBM;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int GJIPMMJGHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool GKOLLFFPGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KHNIAEINEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] CHIMGHNEJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private LKHBKEDLLBN type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly LKHBKEDLLBN[] IJMOBGIDNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[HFEBOLHCHJD("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LKHBKEDLLBN[] BAFKEBNCJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[HFEBOLHCHJD("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[HFEBOLHCHJD("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[HFEBOLHCHJD("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic JDMLIEPMLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool KJCMDDPNDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient ACCENKAGFPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C830", Offset = "0x6D5BA30", VA = "0x186D5C830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LKHBKEDLLBN GLGPHBABLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x90C1D0", Offset = "0x90B3D0", VA = "0x18090C1D0")]
			get
			{
				return default(LKHBKEDLLBN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C9B0", Offset = "0x6D5BBB0", VA = "0x186D5C9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool CMMHAJAFNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6D5BB10", Offset = "0x6D5AD10", VA = "0x186D5BB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 EMOFIOFINKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C7A0", Offset = "0x6D5B9A0", VA = "0x186D5C7A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C7E0", Offset = "0x6D5B9E0", VA = "0x186D5C7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool IDDHNNDFGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D5B750", Offset = "0x6D5A950", VA = "0x186D5B750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 KJDNNIPOMLM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C7C0", Offset = "0x6D5B9C0", VA = "0x186D5C7C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C960", Offset = "0x6D5BB60", VA = "0x186D5C960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float FMGEGGBKKGP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x11B95A0", Offset = "0x11B87A0", VA = "0x1811B95A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1956920", Offset = "0x1955B20", VA = "0x181956920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 MLJEKKMFGIK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D5BAC0", Offset = "0x6D5ACC0", VA = "0x186D5BAC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 KIAPKLAPHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C290", Offset = "0x6D5B490", VA = "0x186D5C290")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float JMMOGGGCHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD264D0", Offset = "0xD256D0", VA = "0x180D264D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C9C0", Offset = "0x6D5BBC0", VA = "0x186D5C9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B940", Offset = "0x6D5AB40", VA = "0x186D5B940", Slot = "12")]
		protected override void GKCPKLBONGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B7D0", Offset = "0x6D5A9D0", VA = "0x186D5B7D0")]
		private void EPACKMFLNBI(Color[] GCJFGMOGEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D5BB90", Offset = "0x6D5AD90", VA = "0x186D5BB90", Slot = "13")]
		protected override void NJBJOLEEFDJ(Material GMJJKHGKCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B530", Offset = "0x6D5A730", VA = "0x186D5B530", Slot = "14")]
		protected override void BAEFJDCNAOF(Material GMJJKHGKCAP, bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C6E0", Offset = "0x6D5B8E0", VA = "0x186D5C6E0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData DIKBFIBFGMF;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D587A0", Offset = "0x6D579A0", VA = "0x186D587A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D58690", Offset = "0x6D57890", VA = "0x186D58690", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D585D0", Offset = "0x6D577D0", VA = "0x186D585D0")]
		private void OPJMHHGIGKB(GameObject DHFJGBHEJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D58990", Offset = "0x6D57B90", VA = "0x186D58990")]
		public void SetOptionsWithNoDefault(List<string> DGPLNKPEMNF, [Optional] string JILJDHLLGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D58BD0", Offset = "0x6D57DD0", VA = "0x186D58BD0")]
		public void SetOptionsWithNoDefault(List<OptionData> CPPBBBCKIMF, [Optional] string JILJDHLLGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D588B0", Offset = "0x6D57AB0", VA = "0x186D588B0", Slot = "42")]
		public override void OnPointerClick(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas BOMEDNFGODG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D58CC0", Offset = "0x6D57EC0", VA = "0x186D58CC0")]
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
		public enum KGPOJOBIEPC
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int NCEBEOIEAIF;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int AGJIJMHONEE;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int AGIEOLCDNHI;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int LCFPCDLJLDG;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int NAIGLKENPLL;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int OFIBJIGMMNB;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int KCFPKBAKCDK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int NOAKBINPAGA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int MGENKGEEMGG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int INIPMKGNOMA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int NJCMHEBNFKP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int KJCCINPOMHL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int OFEFJJELFAN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int IMFBDLDMEOC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FDAMFIHOEJG;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int OGJLHPBOEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
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
		private KGPOJOBIEPC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[HFEBOLHCHJD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[HFEBOLHCHJD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic JDMLIEPMLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool LCPFPONKLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite JKKBKOFAAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D60450", Offset = "0x6D5F650", VA = "0x186D60450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D60660", Offset = "0x6D5F860", VA = "0x186D60660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color DPKLGGENFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99B880", Offset = "0x99AA80", VA = "0x18099B880")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D60700", Offset = "0x6D5F900", VA = "0x186D60700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color GLEOMLDIMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB0A220", Offset = "0xB09420", VA = "0x180B0A220")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D60550", Offset = "0x6D5F750", VA = "0x186D60550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float FGFOFIKHMFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x156D160", Offset = "0x156C360", VA = "0x18156D160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D605F0", Offset = "0x6D5F7F0", VA = "0x186D605F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 KHCNECCKGJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xC9B6C0", Offset = "0xC9A8C0", VA = "0x180C9B6C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D60610", Offset = "0x6D5F810", VA = "0x186D60610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float HPFFKDDEMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x11B9600", Offset = "0x11B8800", VA = "0x1811B9600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D605B0", Offset = "0x6D5F7B0", VA = "0x186D605B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FLPKDFAJNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x22FA490", Offset = "0x22F9690", VA = "0x1822FA490")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D60760", Offset = "0x6D5F960", VA = "0x186D60760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NMBONFOGELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x13BE0F0", Offset = "0x13BD2F0", VA = "0x1813BE0F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D60520", Offset = "0x6D5F720", VA = "0x186D60520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 MCAIOPKCMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D60060", Offset = "0x6D5F260", VA = "0x186D60060")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KGPOJOBIEPC JFDNHENKMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x992120", Offset = "0x991320", VA = "0x180992120")]
			get
			{
				return default(KGPOJOBIEPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D60540", Offset = "0x6D5F740", VA = "0x186D60540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float HJDOOHLALHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7ED7E0", Offset = "0x7EC9E0", VA = "0x1807ED7E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D605D0", Offset = "0x6D5F7D0", VA = "0x186D605D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ODGMKJGGCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xC9B680", Offset = "0xC9A880", VA = "0x180C9B680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6D60500", Offset = "0x6D5F700", VA = "0x186D60500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F9A0", Offset = "0x6D5EBA0", VA = "0x186D5F9A0", Slot = "13")]
		protected override void NJBJOLEEFDJ(Material GMJJKHGKCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F6D0", Offset = "0x6D5E8D0", VA = "0x186D5F6D0")]
		private void ALGIIOPMECA(Sprite LENPLAKIJHF, out Vector2 IDFODLJEDEO, out Vector2 GLGFMMJLJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F950", Offset = "0x6D5EB50", VA = "0x186D5F950", Slot = "14")]
		protected override void BAEFJDCNAOF(Material GMJJKHGKCAP, bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D603B0", Offset = "0x6D5F5B0", VA = "0x186D603B0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader GLBPHPNODEA;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader BIBMJBHEOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D60810", Offset = "0x6D5FA10", VA = "0x186D60810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D607B0", Offset = "0x6D5F9B0", VA = "0x186D607B0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool CJMNAENLMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x94D9A0", Offset = "0x94CBA0", VA = "0x18094D9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> MPACDECIKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D59970", Offset = "0x6D58B70", VA = "0x186D59970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D59AB0", Offset = "0x6D58CB0", VA = "0x186D59AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> NCJFJLBKBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D59A10", Offset = "0x6D58C10", VA = "0x186D59A10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D59B50", Offset = "0x6D58D50", VA = "0x186D59B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D598B0", Offset = "0x6D58AB0", VA = "0x186D598B0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D59910", Offset = "0x6D58B10", VA = "0x186D59910", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1B47930", Offset = "0x1B46B30", VA = "0x181B47930")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1B47930", Offset = "0x1B46B30", VA = "0x181B47930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MICFDMMPBAE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum IEJCGIEHODM
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static GLPGJNOOMAG BHPOFAENJAP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static GLPGJNOOMAG AHNDCIFAJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AC20", Offset = "0x6D59E20", VA = "0x186D5AC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static IEJCGIEHODM ADEFLJKPMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D5ADB0", Offset = "0x6D59FB0", VA = "0x186D5ADB0")]
		get
		{
			return default(IEJCGIEHODM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AEC0", Offset = "0x6D5A0C0", VA = "0x186D5AEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<IEJCGIEHODM> GMGIPKJGKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AB60", Offset = "0x6D59D60", VA = "0x186D5AB60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D5ACF0", Offset = "0x6D59EF0", VA = "0x186D5ACF0")]
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
		private sealed class IHEMMJDLGPG : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private MPEFECEHMLJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
			[DebuggerHidden]
			public IHEMMJDLGPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D59BF0", Offset = "0x6D58DF0", VA = "0x186D59BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6D5A1A0", Offset = "0x6D593A0", VA = "0x186D5A1A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[GADDJAGEFDD(PFIMANMCDOB.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly PDJBEHKNNCI CBHDGELPFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool HBAPPKEONLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? DFFLDIAHKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? AODNAKLCGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool? IECLHJGFOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool KMBGPEIPOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool LIEIHFDNCKC;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool APCMEFIMOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D59590", Offset = "0x6D58790", VA = "0x186D59590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool BOMFABKPOFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D59570", Offset = "0x6D58770", VA = "0x186D59570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool LGDAFEFBPDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x14E8A00", Offset = "0x14E7C00", VA = "0x1814E8A00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6D59780", Offset = "0x6D58980", VA = "0x186D59780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OGACFCNDOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6D594D0", Offset = "0x6D586D0", VA = "0x186D594D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6D596E0", Offset = "0x6D588E0", VA = "0x186D596E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D58EC0", Offset = "0x6D580C0", VA = "0x186D58EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D59250", Offset = "0x6D58450", VA = "0x186D59250")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D58FA0", Offset = "0x6D581A0", VA = "0x186D58FA0")]
		public void Hide(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D593A0", Offset = "0x6D585A0", VA = "0x186D593A0")]
		public void Show(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D592F0", Offset = "0x6D584F0", VA = "0x186D592F0")]
		public void Set(object FDCOCHLAHJD, bool DHIEJPIKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D590A0", Offset = "0x6D582A0", VA = "0x186D590A0")]
		private void OAFEHDBIGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D59030", Offset = "0x6D58230", VA = "0x186D59030")]
		[IteratorStateMachine(typeof(IHEMMJDLGPG))]
		private IEnumerator<MPEFECEHMLJ> JPJLLHKHHMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D58F60", Offset = "0x6D58160", VA = "0x186D58F60", Slot = "5")]
		public virtual void DoHideOrShow(bool IGBDNNHGNOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D59430", Offset = "0x6D58630", VA = "0x186D59430")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12DB50", Offset = "0x12CF50")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int MBPNLEPFCNH;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int ALPEKPKPIOF;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int MPJLDCPDELP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int DAKGCMDKMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
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
		private Color[] CHIMGHNEJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float[] FNIKKCKIFEC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic JDMLIEPMLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool LCPFPONKLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> ONEELINMDFC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 EMOFIOFINKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3F8FE10", Offset = "0x3F8F010", VA = "0x183F8FE10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D5F680", Offset = "0x6D5E880", VA = "0x186D5F680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F370", Offset = "0x6D5E570", VA = "0x186D5F370")]
		public void SetRingLayers(IReadOnlyList<RingLayer> GNIPNDAHLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F130", Offset = "0x6D5E330", VA = "0x186D5F130")]
		public bool SetRingLayerColor(int FNEMOPIFGII, Color GGJPGIMIKJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F250", Offset = "0x6D5E450", VA = "0x186D5F250")]
		public bool SetRingLayerSize(int FNEMOPIFGII, float JPJMMBFGIEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EE50", Offset = "0x6D5E050", VA = "0x186D5EE50", Slot = "12")]
		protected override void GKCPKLBONGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EFB0", Offset = "0x6D5E1B0", VA = "0x186D5EFB0", Slot = "13")]
		protected override void NJBJOLEEFDJ(Material GMJJKHGKCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EE00", Offset = "0x6D5E000", VA = "0x186D5EE00", Slot = "14")]
		protected override void BAEFJDCNAOF(Material GMJJKHGKCAP, bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F4C0", Offset = "0x6D5E6C0", VA = "0x186D5F4C0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly KFJCBMPCHNJ AECLENBFMLD;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Sprite FKLMKIBEOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Material CHANAAAEHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Material BHMPFLKOHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool AJHBJOLPIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool HBAPPKEONLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool JHKPAGAJHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool MNLGDHBKAJO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic JDMLIEPMLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader BIBMJBHEOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool KJCMDDPNDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool LCPFPONKLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform BKNHAILMCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6D5E720", Offset = "0x6D5D920", VA = "0x186D5E720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect KEAINOKHODJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6D5E350", Offset = "0x6D5D550", VA = "0x186D5E350")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite IBFKFMJPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6D5E780", Offset = "0x6D5D980", VA = "0x186D5E780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D960", Offset = "0x6D5CB60", VA = "0x186D5D960", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E950", Offset = "0x6D5DB50", VA = "0x186D5E950", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EC80", Offset = "0x6D5DE80", VA = "0x186D5EC80", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EB00", Offset = "0x6D5DD00", VA = "0x186D5EB00", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E070", Offset = "0x6D5D270", VA = "0x186D5E070")]
		private void GCINMKJGONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E1F0", Offset = "0x6D5D3F0", VA = "0x186D5E1F0")]
		private void HCIOPLHOAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E480", Offset = "0x6D5D680", VA = "0x186D5E480")]
		private void IHGPHELMIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D5DEE0", Offset = "0x6D5D0E0", VA = "0x186D5DEE0")]
		private void DMPFMGIBPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E4B0", Offset = "0x6D5D6B0", VA = "0x186D5E4B0")]
		protected void MHDPKANNIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D5DF30", Offset = "0x6D5D130", VA = "0x186D5DF30")]
		private void FMEBBDKOKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
		protected virtual void GKCPKLBONGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
		protected virtual void NJBJOLEEFDJ(Material GMJJKHGKCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "14")]
		protected virtual void BAEFJDCNAOF(Material GMJJKHGKCAP, bool EECCCGAOPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5DB50", Offset = "0x6D5CD50", VA = "0x186D5DB50")]
		private void COFAHFLGBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PPENANNMPFH : FKHGBMNAEPN, LDJHBEFHLPP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JNEFBENJBGD<GameObject, int> LKCLCCJEABP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OLNNONJGCMF<GameObject, int, bool> CDMHMHOJFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CHBPAJLHAAD<bool> EMPFEMPJPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool IMAGGAMCAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float BFNCIIAKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CHBPAJLHAAD<float> NADPAKHIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HFMPGNIBJKD FIPAPDBLMLL
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
	void SpawnLoadingPlaceholders(GameObject NJPHBJKHIEL);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CICCNDFLPHA Spawn<T>(int NDFFOIEEKLO, IReadOnlyList<T> JFGIPFOFKHL, GameObject NJPHBJKHIEL);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CICCNDFLPHA Spawn<T>(int NDFFOIEEKLO, IReadOnlyList<T> JFGIPFOFKHL, GameObject FHLHHJECJKA, ref Func<int, GameObject> GKDDNIJOEDM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int NNAODBDJDNJ, float COEPGNLMGBP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KFJCBMPCHNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct GKJFPDGKBDM : IEquatable<GKJFPDGKBDM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Component JDFBABENAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Action IPJNDNFCBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly int GCKIJKCGGDI;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component LKKDABBDHBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D58E60", Offset = "0x6D58060", VA = "0x186D58E60")]
		public GKJFPDGKBDM(Component JDFBABENAGD, Action IPJNDNFCBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D58DE0", Offset = "0x6D57FE0", VA = "0x186D58DE0")]
		public void HJLCKJBAGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D58D30", Offset = "0x6D57F30", VA = "0x186D58D30", Slot = "4")]
		public bool Equals(GKJFPDGKBDM JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D58D50", Offset = "0x6D57F50", VA = "0x186D58D50", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PFLDDMNLEBC : IEnumerator<MPEFECEHMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private MPEFECEHMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KFJCBMPCHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IOrderedEnumerable<GKJFPDGKBDM> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GKJFPDGKBDM <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private MPEFECEHMLJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public PFLDDMNLEBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B020", Offset = "0x6D5A220", VA = "0x186D5B020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B430", Offset = "0x6D5A630", VA = "0x186D5B430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly KMDHDDICNKI DJDNICKNLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int JMNPHPKMKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly int LGAJKPIAGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<Component, float> AGLOIAOPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<Component, GKJFPDGKBDM> MKGIBACBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LinkedList<GKJFPDGKBDM> PMKNGLKKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<GKJFPDGKBDM> ENDCLMCMJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NHIOCEAPLGE PGHMNGNINAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LPLMADMBKIA DINLPKMAENI;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private LPLMADMBKIA LGIHHIHDJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A250", Offset = "0x6D59450", VA = "0x186D5A250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AA00", Offset = "0x6D59C00", VA = "0x186D5AA00")]
	public KFJCBMPCHNJ(KMDHDDICNKI DJDNICKNLDN, int JMNPHPKMKLG = -1, int LGAJKPIAGML = -1, [Optional] Func<Component, float> AGLOIAOPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A3E0", Offset = "0x6D595E0", VA = "0x186D5A3E0")]
	public void OAIKFDHDDNO(Component JDFBABENAGD, Action BGHGOMFIAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A870", Offset = "0x6D59A70", VA = "0x186D5A870")]
	public void PNHLDLBIOMB(Component JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A380", Offset = "0x6D59580", VA = "0x186D5A380")]
	public bool NIIHKFOFPPC(Component HPFFEAJFMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A650", Offset = "0x6D59850", VA = "0x186D5A650")]
	private void PNEJDKEPECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A1E0", Offset = "0x6D593E0", VA = "0x186D5A1E0")]
	[IteratorStateMachine(typeof(PFLDDMNLEBC))]
	private IEnumerator<MPEFECEHMLJ> HLIBPAOODFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1012E70", Offset = "0x1012070", VA = "0x181012E70")]
	[CompilerGenerated]
	private void HPMAIDEGOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A2C0", Offset = "0x6D594C0", VA = "0x186D5A2C0")]
	[CompilerGenerated]
	private float KPGCFGHBNDO(GKJFPDGKBDM BGHGOMFIAIP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CPCECCIHEBL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IBFPILCAPAN FHKLINFMJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool DJBOHAGPFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CHBPAJLHAAD<IBFPILCAPAN> FHKLOAFOOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHNMFPGJEJC(IBFPILCAPAN IOPEHKIFFNP, bool NDGCBBMEJJL = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6D5D850", Offset = "0x6D5CA50", VA = "0x186D5D850")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6D5D8B0", Offset = "0x6D5CAB0", VA = "0x186D5D8B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6D5D800", Offset = "0x6D5CA00", VA = "0x186D5D800")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D380", Offset = "0x6D5C580", VA = "0x186D5D380")]
			public void CBMJDIJJMNF(PointerEventData JCONOGFEOOG, RectTransform BKNHAILMCKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D590", Offset = "0x6D5C790", VA = "0x186D5D590")]
			public void CHJMOONGPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D6B0", Offset = "0x6D5C8B0", VA = "0x186D5D6B0")]
			public void EDGEBJCGOGN(PointerEventData JCONOGFEOOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D7B0", Offset = "0x6D5C9B0", VA = "0x186D5D7B0")]
			public void IFCEHFCCCHM(float CEGFNMOEKPJ, RectTransform BKNHAILMCKB, Vector3 DGDMDKFMBBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly CHBPAJLHAAD<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly CHBPAJLHAAD<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly CHBPAJLHAAD<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly CHBPAJLHAAD<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly CHBPAJLHAAD<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly HFMPGNIBJKD PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly UIHandleEventData GDKJJNNIKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool FGLHGJCHPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool KEEKOELIHEG;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool EMBJHPBJJHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x97BA80", Offset = "0x97AC80", VA = "0x18097BA80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CA10", Offset = "0x6D5BC10", VA = "0x186D5CA10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool CHJJGEPLHLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDE29F0", Offset = "0xDE1BF0", VA = "0x180DE29F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C9E0", Offset = "0x6D5BBE0", VA = "0x186D5C9E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CA40", Offset = "0x6D5BC40", VA = "0x186D5CA40")]
		private bool JMAHHLMDJGC(PointerEventData BABPGEEPJFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D080", Offset = "0x6D5C280", VA = "0x186D5D080", Slot = "5")]
		public void OnPointerDown(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D140", Offset = "0x6D5C340", VA = "0x186D5D140", Slot = "11")]
		public void OnPointerUp(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CDE0", Offset = "0x6D5BFE0", VA = "0x186D5CDE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CAD0", Offset = "0x6D5BCD0", VA = "0x186D5CAD0", Slot = "7")]
		public void OnBeginDrag(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CC00", Offset = "0x6D5BE00", VA = "0x186D5CC00", Slot = "4")]
		public void OnDrag(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CCF0", Offset = "0x6D5BEF0", VA = "0x186D5CCF0", Slot = "8")]
		public void OnEndDrag(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D0E0", Offset = "0x6D5C2E0", VA = "0x186D5D0E0", Slot = "9")]
		public void OnPointerEnter(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D110", Offset = "0x6D5C310", VA = "0x186D5D110", Slot = "10")]
		public void OnPointerExit(PointerEventData BABPGEEPJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CBC0", Offset = "0x6D5BDC0", VA = "0x186D5CBC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D1A0", Offset = "0x6D5C3A0", VA = "0x186D5D1A0")]
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
