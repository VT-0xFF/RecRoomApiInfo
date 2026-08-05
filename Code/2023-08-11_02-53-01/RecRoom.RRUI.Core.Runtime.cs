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
		public enum CJJGGIGDCAG : byte
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
		private static readonly int DGOAEGHCMAJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<CJJGGIGDCAG, string> DFINNIAEHLO;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int MOODICNLHAI = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int NPJCEPEFCDC;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int HDBNHMELDJB;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int GNBKCKGCHKJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int JGLFAGPLPJB;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int KAFLHEJDILC;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int CIONHHKEADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool AECDFHCOMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool EGDFJEAMPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] AHMDHJKEAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private CJJGGIGDCAG type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly CJJGGIGDCAG[] FAEGMIPGMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[PJEFHHPNPOL("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly CJJGGIGDCAG[] EKNEEPMEMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[PJEFHHPNPOL("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[PJEFHHPNPOL("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[PJEFHHPNPOL("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic ONIHGIMDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LJPKKAEBNFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient DNINJLFAFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE6F0", Offset = "0x6CFCEF0", VA = "0x186CFE6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CJJGGIGDCAG ILFDEIBDFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x94E330", Offset = "0x94CB30", VA = "0x18094E330")]
			get
			{
				return default(CJJGGIGDCAG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE870", Offset = "0x6CFD070", VA = "0x186CFE870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool GFCIIAHFMHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6CFDE80", Offset = "0x6CFC680", VA = "0x186CFDE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 HOAMNAPFJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE660", Offset = "0x6CFCE60", VA = "0x186CFE660")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE6A0", Offset = "0x6CFCEA0", VA = "0x186CFE6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool CDCJJAACEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6CFDF00", Offset = "0x6CFC700", VA = "0x186CFDF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 IMMOCFIBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE680", Offset = "0x6CFCE80", VA = "0x186CFE680")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE820", Offset = "0x6CFD020", VA = "0x186CFE820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float NNEPLHKGBLO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1246650", Offset = "0x1244E50", VA = "0x181246650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1970870", Offset = "0x196F070", VA = "0x181970870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 DABIJBBMLAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE170", Offset = "0x6CFC970", VA = "0x186CFE170")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 DFFPEHEPJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE100", Offset = "0x6CFC900", VA = "0x186CFE100")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float JAAADGECAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD7F500", Offset = "0xD7DD00", VA = "0x180D7F500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE880", Offset = "0x6CFD080", VA = "0x186CFE880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6CFDF80", Offset = "0x6CFC780", VA = "0x186CFDF80", Slot = "12")]
		protected override void GBOCGGOKHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6CFD3F0", Offset = "0x6CFBBF0", VA = "0x186CFD3F0")]
		private void BNGPBBIGGPJ(Color[] IDPPMHHCIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6CFD560", Offset = "0x6CFBD60", VA = "0x186CFD560", Slot = "13")]
		protected override void CPGPIFLKEHP(Material KKNFKPKFEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6CFDC60", Offset = "0x6CFC460", VA = "0x186CFDC60", Slot = "14")]
		protected override void DDLOJBADDOM(Material KKNFKPKFEJH, bool HLEJICMEJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE5A0", Offset = "0x6CFCDA0", VA = "0x186CFE5A0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData JCNNALCCBDB;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CFAA90", Offset = "0x6CF9290", VA = "0x186CFAA90", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA980", Offset = "0x6CF9180", VA = "0x186CFA980", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA8C0", Offset = "0x6CF90C0", VA = "0x186CFA8C0")]
		private void BEABGNACKEI(GameObject MJKHPJGCFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6CFAC80", Offset = "0x6CF9480", VA = "0x186CFAC80")]
		public void SetOptionsWithNoDefault(List<string> ONNFNOJDECI, [Optional] string OACJCMKNOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6CFAEC0", Offset = "0x6CF96C0", VA = "0x186CFAEC0")]
		public void SetOptionsWithNoDefault(List<OptionData> LFCKIHDGDIE, [Optional] string OACJCMKNOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6CFABA0", Offset = "0x6CF93A0", VA = "0x186CFABA0", Slot = "42")]
		public override void OnPointerClick(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas NPOKNPLLDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CFAFB0", Offset = "0x6CF97B0", VA = "0x186CFAFB0")]
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
		public enum MMLJBFODOGD
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int CIGGAMCJKON;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int MBIFGBLMCNO;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int DLAIHMIJCCA;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int AHCDOOLIKMA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int ICODMABNKEB;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int ILOGAGFJHBM;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int PKHKJOCLAIA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int KCGMMEHNFLG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int JCCJGJKHDAM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int ADHDBKLDEBN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int HKMILCHEKHB;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int DDAAMLKEJLC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int DPIEIDOMNLD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int GAGNDOMHGAJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FCFMJMPHHCD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int GCDJDDBPLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
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
		private MMLJBFODOGD animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[PJEFHHPNPOL("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[PJEFHHPNPOL("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic ONIHGIMDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool OOHBPFGGLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite DDNNOGFNIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D02310", Offset = "0x6D00B10", VA = "0x186D02310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D02520", Offset = "0x6D00D20", VA = "0x186D02520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color ABFCMNPIDID
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x918DF0", Offset = "0x9175F0", VA = "0x180918DF0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D025C0", Offset = "0x6D00DC0", VA = "0x186D025C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color JFKHKNCKOLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBB0CB0", Offset = "0xBAF4B0", VA = "0x180BB0CB0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D02410", Offset = "0x6D00C10", VA = "0x186D02410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KOFAFGJDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xFB2650", Offset = "0xFB0E50", VA = "0x180FB2650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D024B0", Offset = "0x6D00CB0", VA = "0x186D024B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 CIEOGEIODAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD0B910", Offset = "0xD0A110", VA = "0x180D0B910")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D024D0", Offset = "0x6D00CD0", VA = "0x186D024D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DDDGGALLAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x12466B0", Offset = "0x1244EB0", VA = "0x1812466B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D02470", Offset = "0x6D00C70", VA = "0x186D02470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FKLMLIAFJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x23187B0", Offset = "0x2316FB0", VA = "0x1823187B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D02620", Offset = "0x6D00E20", VA = "0x186D02620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NOMOMDIBKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x13ABBC0", Offset = "0x13AA3C0", VA = "0x1813ABBC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D023E0", Offset = "0x6D00BE0", VA = "0x186D023E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 DLDHBBIIIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D01F20", Offset = "0x6D00720", VA = "0x186D01F20")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MMLJBFODOGD KPIDPEILIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x90F6A0", Offset = "0x90DEA0", VA = "0x18090F6A0")]
			get
			{
				return default(MMLJBFODOGD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D02400", Offset = "0x6D00C00", VA = "0x186D02400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float POFGKBBFFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1230630", Offset = "0x122EE30", VA = "0x181230630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D02490", Offset = "0x6D00C90", VA = "0x186D02490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CKBMODGNFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD0B8C0", Offset = "0xD0A0C0", VA = "0x180D0B8C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6D023C0", Offset = "0x6D00BC0", VA = "0x186D023C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D01590", Offset = "0x6CFFD90", VA = "0x186D01590", Slot = "13")]
		protected override void CPGPIFLKEHP(Material KKNFKPKFEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D01CA0", Offset = "0x6D004A0", VA = "0x186D01CA0")]
		private void FPLHLADMJMA(Sprite LLJLGHFAKIL, out Vector2 DEIGAIOCJGP, out Vector2 KPONGJIIGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D01C50", Offset = "0x6D00450", VA = "0x186D01C50", Slot = "14")]
		protected override void DDLOJBADDOM(Material KKNFKPKFEJH, bool HLEJICMEJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D02270", Offset = "0x6D00A70", VA = "0x186D02270")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader PEBBEABNOBC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader PHDKEDKJOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D026D0", Offset = "0x6D00ED0", VA = "0x186D026D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D02670", Offset = "0x6D00E70", VA = "0x186D02670")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool MNHCFDJMDDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3F030", Offset = "0xA3D830", VA = "0x180A3F030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> JDOKIHDAABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC5E0", Offset = "0x6CFADE0", VA = "0x186CFC5E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC720", Offset = "0x6CFAF20", VA = "0x186CFC720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> HFBOBEPMODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC680", Offset = "0x6CFAE80", VA = "0x186CFC680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC7C0", Offset = "0x6CFAFC0", VA = "0x186CFC7C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CFC520", Offset = "0x6CFAD20", VA = "0x186CFC520", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CFC580", Offset = "0x6CFAD80", VA = "0x186CFC580", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1B19DD0", Offset = "0x1B185D0", VA = "0x181B19DD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1B19DD0", Offset = "0x1B185D0", VA = "0x181B19DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NOJLFAKJDBE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum FDPOJNIEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static EPJPDLNCDIN HEKLPOHGDJD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static EPJPDLNCDIN NEADGAKFLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6CFCFF0", Offset = "0x6CFB7F0", VA = "0x186CFCFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static FDPOJNIEFBN KPEOJCIBPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CFD0C0", Offset = "0x6CFB8C0", VA = "0x186CFD0C0")]
		get
		{
			return default(FDPOJNIEFBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CFD1D0", Offset = "0x6CFB9D0", VA = "0x186CFD1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<FDPOJNIEFBN> GHELLMHEOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6CFCE70", Offset = "0x6CFB670", VA = "0x186CFCE70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6CFCF30", Offset = "0x6CFB730", VA = "0x186CFCF30")]
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
		private sealed class NIDOOIGJMJG : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public NIDOOIGJMJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC860", Offset = "0x6CFB060", VA = "0x186CFC860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6CFCE30", Offset = "0x6CFB630", VA = "0x186CFCE30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[AHENNPNFFLM(OBCONDONEKN.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly JCAEGCAOHJG GOEKDLMNHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool EMDPABBJGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? CCCHNFLJIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? NFCCKHEIIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool? DBCLAHMGGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool ADBLIPMFKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool JIEJJNNILFA;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool HLHDOACOCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC200", Offset = "0x6CFAA00", VA = "0x186CFC200", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EHIKFNIBBKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC1E0", Offset = "0x6CFA9E0", VA = "0x186CFC1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool FNPNACADOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x15DDB00", Offset = "0x15DC300", VA = "0x1815DDB00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC3F0", Offset = "0x6CFABF0", VA = "0x186CFC3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OBNKGHDPEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC140", Offset = "0x6CFA940", VA = "0x186CFC140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6CFC350", Offset = "0x6CFAB50", VA = "0x186CFC350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBB30", Offset = "0x6CFA330", VA = "0x186CFBB30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBEC0", Offset = "0x6CFA6C0", VA = "0x186CFBEC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBC80", Offset = "0x6CFA480", VA = "0x186CFBC80")]
		public void Hide(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6CFC010", Offset = "0x6CFA810", VA = "0x186CFC010")]
		public void Show(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBF60", Offset = "0x6CFA760", VA = "0x186CFBF60")]
		public void Set(object AMCDGOPKAOE, bool JPHDECOMNCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBD10", Offset = "0x6CFA510", VA = "0x186CFBD10")]
		private void KKHIFNINMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBC10", Offset = "0x6CFA410", VA = "0x186CFBC10")]
		[IteratorStateMachine(typeof(NIDOOIGJMJG))]
		private IEnumerator<EPHOKNIGMNK> GOHHPNBOMGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6CFBBD0", Offset = "0x6CFA3D0", VA = "0x186CFBBD0", Slot = "5")]
		public virtual void DoHideOrShow(bool ABFIPLFDEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6CFC0A0", Offset = "0x6CFA8A0", VA = "0x186CFC0A0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12EBA0", Offset = "0x12DFA0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int HICKJNKBDAC;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int PMFHEFIDFKE;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int EHFIEBMJNNF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int NJBEABLFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
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
		private Color[] AHMDHJKEAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float[] BCDHNCKIJAJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic ONIHGIMDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool OOHBPFGGLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> PLKBDNCFMKF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 HOAMNAPFJGL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4079050", Offset = "0x4077850", VA = "0x184079050")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D01540", Offset = "0x6CFFD40", VA = "0x186D01540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D01230", Offset = "0x6CFFA30", VA = "0x186D01230")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PGBGNBLGGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D00FF0", Offset = "0x6CFF7F0", VA = "0x186D00FF0")]
		public bool SetRingLayerColor(int IKPOFFPJLJD, Color JIINIIPALJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D01110", Offset = "0x6CFF910", VA = "0x186D01110")]
		public bool SetRingLayerSize(int IKPOFFPJLJD, float JIAHBEIKEJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D00E90", Offset = "0x6CFF690", VA = "0x186D00E90", Slot = "12")]
		protected override void GBOCGGOKHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D00CC0", Offset = "0x6CFF4C0", VA = "0x186D00CC0", Slot = "13")]
		protected override void CPGPIFLKEHP(Material KKNFKPKFEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D00E40", Offset = "0x6CFF640", VA = "0x186D00E40", Slot = "14")]
		protected override void DDLOJBADDOM(Material KKNFKPKFEJH, bool HLEJICMEJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D01380", Offset = "0x6CFFB80", VA = "0x186D01380")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly HJECCHOPLIL MEAOAHJHCMI;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Sprite BADHFMHKACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Material OPFONEPHHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Material NHNBMIJGKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool MDMBHLMFGBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool EMDPABBJGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool PFLDIEOMFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool PKCMGLPGMIE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic ONIHGIMDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader PHDKEDKJOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool LJPKKAEBNFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool OOHBPFGGLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform LHBJENPCFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6CFFB70", Offset = "0x6CFE370", VA = "0x186CFFB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect EHBHJNCBPJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6CFFD10", Offset = "0x6CFE510", VA = "0x186CFFD10")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite HDOIKODKEKB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6CFFE40", Offset = "0x6CFE640", VA = "0x186CFFE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF820", Offset = "0x6CFE020", VA = "0x186CFF820", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D00810", Offset = "0x6CFF010", VA = "0x186D00810", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D00B40", Offset = "0x6CFF340", VA = "0x186D00B40", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D009C0", Offset = "0x6CFF1C0", VA = "0x186D009C0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D00060", Offset = "0x6CFE860", VA = "0x186D00060")]
		private void MCENJFKDJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CFFA10", Offset = "0x6CFE210", VA = "0x186CFFA10")]
		private void BDHCHFIHPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D00570", Offset = "0x6CFED70", VA = "0x186D00570")]
		private void NCLJLLFFBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D00010", Offset = "0x6CFE810", VA = "0x186D00010")]
		private void KMFDDBMMBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D005A0", Offset = "0x6CFEDA0", VA = "0x186D005A0")]
		protected void OIAOELFMHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CFFBD0", Offset = "0x6CFE3D0", VA = "0x186CFFBD0")]
		private void FLFCGEOMHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "12")]
		protected virtual void GBOCGGOKHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
		protected virtual void CPGPIFLKEHP(Material KKNFKPKFEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "14")]
		protected virtual void DDLOJBADDOM(Material KKNFKPKFEJH, bool HLEJICMEJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D001E0", Offset = "0x6CFE9E0", VA = "0x186D001E0")]
		private void MJJNEHMCEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBOKLJFGNHD : GMCBCOFOLAM, DMPDPJGIKJB, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	APIEBAMEOKL<GameObject, int> AHKBPJFOKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BCGDODDOBPE<GameObject, int, bool> OECDCNBHBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BPPINFIIDCE<bool> IAAFBGEOMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool AOAJLGLIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float ILIKNGCHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BPPINFIIDCE<float> CNDJENLHLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NJDLJLDNKHA DGIJKBPFBGD
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
	void SpawnLoadingPlaceholders(GameObject ALNJPMNLFGF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KIPKMCKINOD Spawn<T>(int CFDNOGAIFPB, IReadOnlyList<T> NFBDMLCENEN, GameObject ALNJPMNLFGF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KIPKMCKINOD Spawn<T>(int CFDNOGAIFPB, IReadOnlyList<T> NFBDMLCENEN, GameObject DLAJIIAGODN, ref Func<int, GameObject> LNDJEHBLNIA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int AMOEKOMGDLG, float AHCGMNKEBKB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HJECCHOPLIL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct GNBCMOOOGIL : IEquatable<GNBCMOOOGIL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Component HNBDDLBIIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Action COADIPPJGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly int CEAILBCOMDG;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component EMNMIGHKENG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB150", Offset = "0x6CF9950", VA = "0x186CFB150")]
		public GNBCMOOOGIL(Component HNBDDLBIIOF, Action COADIPPJGNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB0D0", Offset = "0x6CF98D0", VA = "0x186CFB0D0")]
		public void LCEFAGCAIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB020", Offset = "0x6CF9820", VA = "0x186CFB020", Slot = "4")]
		public bool Equals(GNBCMOOOGIL OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB040", Offset = "0x6CF9840", VA = "0x186CFB040", Slot = "0")]
		public override bool Equals(object CEPDEAHBHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DPICBCAIFMB : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private EPHOKNIGMNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HJECCHOPLIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IOrderedEnumerable<GNBCMOOOGIL> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GNBCMOOOGIL <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public DPICBCAIFMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA470", Offset = "0x6CF8C70", VA = "0x186CFA470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA880", Offset = "0x6CF9080", VA = "0x186CFA880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int FCJFKJEILLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly int FGFADJMNDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<Component, float> ICMLGPOEMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<Component, GNBCMOOOGIL> EABOPJBHKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LinkedList<GNBCMOOOGIL> NKBOCMEFGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<GNBCMOOOGIL> IPJJGALCHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IIFKIJJEKEP INIJLGJPNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DBGKBJALDID OOHADMPPDLJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private DBGKBJALDID KILNBGHOCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CFB960", Offset = "0x6CFA160", VA = "0x186CFB960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB9D0", Offset = "0x6CFA1D0", VA = "0x186CFB9D0")]
	public HJECCHOPLIL(JFMPFLAGBEN.EOFNJJHKHLI JAKCALGDOKB, int FCJFKJEILLG = -1, int FGFADJMNDHO = -1, [Optional] Func<Component, float> ICMLGPOEMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB680", Offset = "0x6CF9E80", VA = "0x186CFB680")]
	public void KIIAOLOGICC(Component HNBDDLBIIOF, Action IKBOIGIEDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB3D0", Offset = "0x6CF9BD0", VA = "0x186CFB3D0")]
	public void CNPDEPBPNFF(Component HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB620", Offset = "0x6CF9E20", VA = "0x186CFB620")]
	public bool HMDIHBJMMEM(Component CAOCJIHJELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB1B0", Offset = "0x6CF99B0", VA = "0x186CFB1B0")]
	private void ACEOOBNLFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB8F0", Offset = "0x6CFA0F0", VA = "0x186CFB8F0")]
	[IteratorStateMachine(typeof(DPICBCAIFMB))]
	private IEnumerator<EPHOKNIGMNK> MACDNPFBAGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1382540", Offset = "0x1380D40", VA = "0x181382540")]
	[CompilerGenerated]
	private void KGCLNDLJOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CFB560", Offset = "0x6CF9D60", VA = "0x186CFB560")]
	[CompilerGenerated]
	private float FENBDMLMGLA(GNBCMOOOGIL IKBOIGIEDJD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KOINKCBECGL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MCFDINLIHPA JCDIPEHLIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EEGBIHBJICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BPPINFIIDCE<MCFDINLIHPA> NICEELPFEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHIMJIMBFGJ(MCFDINLIHPA OHLOPMKBCNL, bool KMBIALLCELK = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6CFF710", Offset = "0x6CFDF10", VA = "0x186CFF710")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6CFF770", Offset = "0x6CFDF70", VA = "0x186CFF770")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6CFF6C0", Offset = "0x6CFDEC0", VA = "0x186CFF6C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6CFF460", Offset = "0x6CFDC60", VA = "0x186CFF460")]
			public void LMGPFNLPMKN(PointerEventData HIGDEBFKLAP, RectTransform LHBJENPCFFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6CFF240", Offset = "0x6CFDA40", VA = "0x186CFF240")]
			public void GPBKIMCPMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6CFF360", Offset = "0x6CFDB60", VA = "0x186CFF360")]
			public void LMCPFLFGPLD(PointerEventData HIGDEBFKLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6CFF670", Offset = "0x6CFDE70", VA = "0x186CFF670")]
			public void PHLMCNBEGHH(float JEMKGOKMILH, RectTransform LHBJENPCFFK, Vector3 GGKJMICDBEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly BPPINFIIDCE<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly BPPINFIIDCE<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly BPPINFIIDCE<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly BPPINFIIDCE<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly BPPINFIIDCE<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly NJDLJLDNKHA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly UIHandleEventData LDHKCAFHPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool JHFPOBGLKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool JLHOAFAMBCM;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool GMJBLJNAFBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7EBC00", Offset = "0x7EA400", VA = "0x1807EBC00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6CFEFA0", Offset = "0x6CFD7A0", VA = "0x186CFEFA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool EOHBICPJOMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6CFE8A0", Offset = "0x6CFD0A0", VA = "0x186CFE8A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEFD0", Offset = "0x6CFD7D0", VA = "0x186CFEFD0")]
		private bool POIMPINPHPB(PointerEventData ANPGOOMAJOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEE80", Offset = "0x6CFD680", VA = "0x186CFEE80", Slot = "5")]
		public void OnPointerDown(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEF40", Offset = "0x6CFD740", VA = "0x186CFEF40", Slot = "11")]
		public void OnPointerUp(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEBE0", Offset = "0x6CFD3E0", VA = "0x186CFEBE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE8D0", Offset = "0x6CFD0D0", VA = "0x186CFE8D0", Slot = "7")]
		public void OnBeginDrag(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEA00", Offset = "0x6CFD200", VA = "0x186CFEA00", Slot = "4")]
		public void OnDrag(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEAF0", Offset = "0x6CFD2F0", VA = "0x186CFEAF0", Slot = "8")]
		public void OnEndDrag(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEEE0", Offset = "0x6CFD6E0", VA = "0x186CFEEE0", Slot = "9")]
		public void OnPointerEnter(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEF10", Offset = "0x6CFD710", VA = "0x186CFEF10", Slot = "10")]
		public void OnPointerExit(PointerEventData ANPGOOMAJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE9C0", Offset = "0x6CFD1C0", VA = "0x186CFE9C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF060", Offset = "0x6CFD860", VA = "0x186CFF060")]
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
