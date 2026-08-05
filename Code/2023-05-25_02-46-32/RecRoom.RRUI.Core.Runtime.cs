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
		public enum FIMEGLKJKFC : byte
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
		private static readonly int DLHMFICKPCN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<FIMEGLKJKFC, string> HJNMGCOBBCC;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int HALODGLKPEF = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int NOMAAGIKHJK;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int HJABGAIMCDM;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int OMNLODLINLF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int GJFEGDNKGDO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int NPIPBGJIHPG;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int FFFFPKMNHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool HNDHPNJBLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool LCDLEPCLMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] CFKLPOFPFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private FIMEGLKJKFC type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly FIMEGLKJKFC[] NKFOBOPHLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[LEKNNDJMFFO("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly FIMEGLKJKFC[] BOFKJILCKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[LEKNNDJMFFO("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[LEKNNDJMFFO("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[LEKNNDJMFFO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic EJHADEGAOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LBNPCFOBKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient AHEHGFNIAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5660", Offset = "0x6EF3E60", VA = "0x186EF5660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public FIMEGLKJKFC JFINBJKLHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x12770B0", Offset = "0x12758B0", VA = "0x1812770B0")]
			get
			{
				return default(FIMEGLKJKFC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6EF57E0", Offset = "0x6EF3FE0", VA = "0x186EF57E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool DDDELONNEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6EF50D0", Offset = "0x6EF38D0", VA = "0x186EF50D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 PNELKCHEAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6EF55F0", Offset = "0x6EF3DF0", VA = "0x186EF55F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5610", Offset = "0x6EF3E10", VA = "0x186EF5610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OGCNIEAOPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4E60", Offset = "0x6EF3660", VA = "0x186EF4E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 BOIJDEBEJHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C213E0", Offset = "0x6C1FBE0", VA = "0x186C213E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5790", Offset = "0x6EF3F90", VA = "0x186EF5790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PAOEPEGLNHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1AD07E0", Offset = "0x1ACEFE0", VA = "0x181AD07E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x20EF360", Offset = "0x20EDB60", VA = "0x1820EF360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 LBMFNAOEMBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4360", Offset = "0x6EF2B60", VA = "0x186EF4360")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 KCODPOCGNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5050", Offset = "0x6EF3850", VA = "0x186EF5050")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float OIEABKGHNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1AC3630", Offset = "0x1AC1E30", VA = "0x181AC3630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6EF57F0", Offset = "0x6EF3FF0", VA = "0x186EF57F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EF45D0", Offset = "0x6EF2DD0", VA = "0x186EF45D0", Slot = "12")]
		protected override void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4EE0", Offset = "0x6EF36E0", VA = "0x186EF4EE0")]
		private void HBGFOIFAJFP(Color[] DEKIMEPACBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4750", Offset = "0x6EF2F50", VA = "0x186EF4750", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EF43B0", Offset = "0x6EF2BB0", VA = "0x186EF43B0", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5530", Offset = "0x6EF3D30", VA = "0x186EF5530")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData CKFIEEPLPNG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2590", Offset = "0x6EF0D90", VA = "0x186EF2590", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2480", Offset = "0x6EF0C80", VA = "0x186EF2480", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF23C0", Offset = "0x6EF0BC0", VA = "0x186EF23C0")]
		private void ADFAELNIAMM(GameObject FKPECMJOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2780", Offset = "0x6EF0F80", VA = "0x186EF2780")]
		public void SetOptionsWithNoDefault(List<string> EFLCMDHDGNO, [Optional] string AGLGABHNKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF29C0", Offset = "0x6EF11C0", VA = "0x186EF29C0")]
		public void SetOptionsWithNoDefault(List<OptionData> GEAIFDNFEOL, [Optional] string AGLGABHNKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF26A0", Offset = "0x6EF0EA0", VA = "0x186EF26A0", Slot = "42")]
		public override void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C8F0", Offset = "0x83B0F0", VA = "0x18083C8F0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas ACBLJJMKNPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EF2AB0", Offset = "0x6EF12B0", VA = "0x186EF2AB0")]
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
		public enum NNJMPEJKFOG
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int AGOGAONMFFN;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int PJCPEHBGJNK;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int HPMDBLDKLMJ;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int FDLFIAILJPK;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int FKAPCKLHEMM;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int HCHDIEPGBPH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int JDJFDEGGNKJ;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int PGKEJPNFKIL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int AOBAEJJJILI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int HMPMIGCFINN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int POBBCHKCLFM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int GNILFJADGOD;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int HALJKCGOKCK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CCIMNAEINGH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AJPKKFEGAJJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int LEDOFLHMOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
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
		private NNJMPEJKFOG animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[LEKNNDJMFFO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[LEKNNDJMFFO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic EJHADEGAOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite NPGOLPIPPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9270", Offset = "0x6EF7A70", VA = "0x186EF9270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9480", Offset = "0x6EF7C80", VA = "0x186EF9480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BMFLHIOICAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x91BFE0", Offset = "0x91A7E0", VA = "0x18091BFE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9520", Offset = "0x6EF7D20", VA = "0x186EF9520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color OONOPBLHAHA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB5CD30", Offset = "0xB5B530", VA = "0x180B5CD30")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9370", Offset = "0x6EF7B70", VA = "0x186EF9370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float AJHABMMPGJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xBCB020", Offset = "0xBC9820", VA = "0x180BCB020")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9410", Offset = "0x6EF7C10", VA = "0x186EF9410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 DJLCIICLKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1B28A10", Offset = "0x1B27210", VA = "0x181B28A10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9430", Offset = "0x6EF7C30", VA = "0x186EF9430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OIABMDMAMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9928A0", Offset = "0x9910A0", VA = "0x1809928A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EF93D0", Offset = "0x6EF7BD0", VA = "0x186EF93D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FGHNELDODFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1237C40", Offset = "0x1236440", VA = "0x181237C40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9580", Offset = "0x6EF7D80", VA = "0x186EF9580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MEEJNLHEINM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1BCB9D0", Offset = "0x1BCA1D0", VA = "0x181BCB9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9340", Offset = "0x6EF7B40", VA = "0x186EF9340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 NHDFCNLABMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E80", Offset = "0x6EF7680", VA = "0x186EF8E80")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NNJMPEJKFOG JEBHICAMEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC12B40", Offset = "0xC11340", VA = "0x180C12B40")]
			get
			{
				return default(NNJMPEJKFOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9360", Offset = "0x6EF7B60", VA = "0x186EF9360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DNIKGLPHKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x10392E0", Offset = "0x1037AE0", VA = "0x1810392E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF93F0", Offset = "0x6EF7BF0", VA = "0x186EF93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PNEBAGDBINK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1B289F0", Offset = "0x1B271F0", VA = "0x181B289F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9320", Offset = "0x6EF7B20", VA = "0x186EF9320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8540", Offset = "0x6EF6D40", VA = "0x186EF8540", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8C00", Offset = "0x6EF7400", VA = "0x186EF8C00")]
		private void KGBOAGGHHNM(Sprite POCNICPLMKL, out Vector2 HPONDHAIAHO, out Vector2 FDFMFILCNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF84F0", Offset = "0x6EF6CF0", VA = "0x186EF84F0", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EF91D0", Offset = "0x6EF79D0", VA = "0x186EF91D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader GAJMNDHJDMD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader PLOPEBOBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9630", Offset = "0x6EF7E30", VA = "0x186EF9630", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EF95D0", Offset = "0x6EF7DD0", VA = "0x186EF95D0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool KLNKOMHGCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C7730", Offset = "0x8C5F30", VA = "0x1808C7730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> LNMBLOODOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3BD0", Offset = "0x6EF23D0", VA = "0x186EF3BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3D10", Offset = "0x6EF2510", VA = "0x186EF3D10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KMLPOGNHFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3C70", Offset = "0x6EF2470", VA = "0x186EF3C70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3DB0", Offset = "0x6EF25B0", VA = "0x186EF3DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3B10", Offset = "0x6EF2310", VA = "0x186EF3B10", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3B70", Offset = "0x6EF2370", VA = "0x186EF3B70", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x294FCA0", Offset = "0x294E4A0", VA = "0x18294FCA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x294FCA0", Offset = "0x294E4A0", VA = "0x18294FCA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BGPGGIJIJPN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum JJEDDHNNHCG
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const JJEDDHNNHCG IMOBCMEKOJG = JJEDDHNNHCG.Light;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const string CJBLGDNKFEO = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static IIDHLOGLACP ELGHOFDICML;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static IIDHLOGLACP KGBPPAOJNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EF16C0", Offset = "0x6EEFEC0", VA = "0x186EF16C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static JJEDDHNNHCG BKMEGLNMJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1790", Offset = "0x6EEFF90", VA = "0x186EF1790")]
		get
		{
			return default(JJEDDHNNHCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1550", Offset = "0x6EEFD50", VA = "0x186EF1550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<JJEDDHNNHCG> HGLIDIPKPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF18B0", Offset = "0x6EF00B0", VA = "0x186EF18B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1970", Offset = "0x6EF0170", VA = "0x186EF1970")]
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
		private sealed class EHNFJCDJHKL : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
			[DebuggerHidden]
			public EHNFJCDJHKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2B20", Offset = "0x6EF1320", VA = "0x186EF2B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3100", Offset = "0x6EF1900", VA = "0x186EF3100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly FMDOKKBAPOM KCFJIINAHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JHLMCKNAJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3? KEFGHLAFIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool? MFLKLKNMLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool? LPCGENNAEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool LJMLPBEIJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool NJDKILMKEJE;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool DEIFCIEPAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6EF37F0", Offset = "0x6EF1FF0", VA = "0x186EF37F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EFDENHNDGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6EF37D0", Offset = "0x6EF1FD0", VA = "0x186EF37D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NGEHPHDGFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2620D40", Offset = "0x261F540", VA = "0x182620D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6EF39E0", Offset = "0x6EF21E0", VA = "0x186EF39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EJBPKONGLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3730", Offset = "0x6EF1F30", VA = "0x186EF3730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3940", Offset = "0x6EF2140", VA = "0x186EF3940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3300", Offset = "0x6EF1B00", VA = "0x186EF3300")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF34D0", Offset = "0x6EF1CD0", VA = "0x186EF34D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3450", Offset = "0x6EF1C50", VA = "0x186EF3450")]
		public void Hide(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3610", Offset = "0x6EF1E10", VA = "0x186EF3610")]
		public void Show(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3570", Offset = "0x6EF1D70", VA = "0x186EF3570")]
		public void Set(object FLDJLPKNKKO, bool MBBEDGFKIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3140", Offset = "0x6EF1940", VA = "0x186EF3140")]
		private void ANPJJMKPGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EF33E0", Offset = "0x6EF1BE0", VA = "0x186EF33E0")]
		[IteratorStateMachine(typeof(EHNFJCDJHKL))]
		private IEnumerator<EDDHBDCNFKM> GGNEGJOANDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EF33A0", Offset = "0x6EF1BA0", VA = "0x186EF33A0", Slot = "5")]
		public virtual void DoHideOrShow(bool JOPMCLFEBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3690", Offset = "0x6EF1E90", VA = "0x186EF3690")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xAA110", Offset = "0xA9510")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int GIOOBPHLHKE;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int IBDONIHBFMJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly int JKGKEBJGHAI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int LJEPDNPPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
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
		private Color[] CFKLPOFPFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private float[] IHIPABPMJCH;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic EJHADEGAOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> FHIHAFLCFDA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 PNELKCHEAFC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBCB060", Offset = "0xBC9860", VA = "0x180BCB060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6EF84A0", Offset = "0x6EF6CA0", VA = "0x186EF84A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF81A0", Offset = "0x6EF69A0", VA = "0x186EF81A0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> FDPDHOBKAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7F80", Offset = "0x6EF6780", VA = "0x186EF7F80")]
		public bool SetRingLayerColor(int DOBMDPHLPNO, Color OPOEPBAFNOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8090", Offset = "0x6EF6890", VA = "0x186EF8090")]
		public bool SetRingLayerSize(int DOBMDPHLPNO, float GEFPLPIBMGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7C90", Offset = "0x6EF6490", VA = "0x186EF7C90", Slot = "12")]
		protected override void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7E00", Offset = "0x6EF6600", VA = "0x186EF7E00", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7C40", Offset = "0x6EF6440", VA = "0x186EF7C40", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EF82F0", Offset = "0x6EF6AF0", VA = "0x186EF82F0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly CAGIFMBMKAP LHHHPDINDPP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static Sprite OAMKCHHNEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material OEBAIMNOLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Material LOMBKLMPELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool IPPEKLLBILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool JHLMCKNAJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool CGFKFBDIGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool EAIOEAMOFCE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic EJHADEGAOID
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader PLOPEBOBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool LBNPCFOBKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform OBIKEGIECJA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6F90", Offset = "0x6EF5790", VA = "0x186EF6F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect KMMJIEPHHKB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF7380", Offset = "0x6EF5B80", VA = "0x186EF7380")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite MIGPCBFEGGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF68F0", Offset = "0x6EF50F0", VA = "0x186EF68F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6AC0", Offset = "0x6EF52C0", VA = "0x186EF6AC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF77A0", Offset = "0x6EF5FA0", VA = "0x186EF77A0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7AC0", Offset = "0x6EF62C0", VA = "0x186EF7AC0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7950", Offset = "0x6EF6150", VA = "0x186EF7950", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6CB0", Offset = "0x6EF54B0", VA = "0x186EF6CB0")]
		private void CKBFFFEAFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6E30", Offset = "0x6EF5630", VA = "0x186EF6E30")]
		private void HFICOMFPFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EF74B0", Offset = "0x6EF5CB0", VA = "0x186EF74B0")]
		private void LGLIAJPGGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7750", Offset = "0x6EF5F50", VA = "0x186EF7750")]
		private void NHOEOHDAEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EF74E0", Offset = "0x6EF5CE0", VA = "0x186EF74E0")]
		protected void NAKMNKANBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EF67B0", Offset = "0x6EF4FB0", VA = "0x186EF67B0")]
		private void ACJDKMDEOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "12")]
		protected virtual void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "13")]
		protected virtual void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "14")]
		protected virtual void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6FF0", Offset = "0x6EF57F0", VA = "0x186EF6FF0")]
		private void JODJKLPFHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		[Conditional("RRUI_PROFILING")]
		protected void KFMHCHNODJN(string FMCIPDNGKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		[Conditional("RRUI_PROFILING")]
		protected void BIDAGHFJDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JJGNLLDMFCL : PDHBGNBCHNK, LEADLPFANBC, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	global::HJMCHKIHGED<GameObject, int> NJLDABNCOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	global::KJIOPDDOALH<GameObject, int, bool> KBMOPINOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	global::NAOGJOJMPFD<bool> MGGDJLDLIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool ALELMNNBNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float APGAOLMJAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	global::NAOGJOJMPFD<float> GCNBFEGNPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KBJOPGEOOCH HEHBILFMCHN
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
	void SpawnLoadingPlaceholders(GameObject OGIDMIHPCNI);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OHBOPDKGAGN Spawn<T>(int AELDBEODOHC, IReadOnlyList<T> PHBHEFAPHDL, GameObject OGIDMIHPCNI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OHBOPDKGAGN Spawn<T>(int AELDBEODOHC, IReadOnlyList<T> PHBHEFAPHDL, GameObject AEOEGLLOIJH, ref Func<int, GameObject> PGHJLHEGELB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CAGIFMBMKAP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct AMGKCKALKHO : IEquatable<AMGKCKALKHO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Component JFDMKPDIBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Action DALKMBOLLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int HPGDENIBDML;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component DGIIIIEGDEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF14F0", Offset = "0x6EEFCF0", VA = "0x186EF14F0")]
		public AMGKCKALKHO(Component JFDMKPDIBDL, Action DALKMBOLLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF13C0", Offset = "0x6EEFBC0", VA = "0x186EF13C0")]
		public void BNHDLCIOKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF14D0", Offset = "0x6EEFCD0", VA = "0x186EF14D0", Slot = "4")]
		public bool Equals(AMGKCKALKHO MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1440", Offset = "0x6EEFC40", VA = "0x186EF1440", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KIDDCLABAGL : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private EDDHBDCNFKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CAGIFMBMKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IOrderedEnumerable<AMGKCKALKHO> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private AMGKCKALKHO <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
		[DebuggerHidden]
		public KIDDCLABAGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3E50", Offset = "0x6EF2650", VA = "0x186EF3E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4260", Offset = "0x6EF2A60", VA = "0x186EF4260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int EOBNIBIDBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly int OJIGADINHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Component, float> LDECIACHKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Component, AMGKCKALKHO> HKDBEAFAONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LinkedList<AMGKCKALKHO> CCNDGOENPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<AMGKCKALKHO> PGAJJHNKPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CMHJCDCDCHH KHGHIEPPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private BBDNFHGFMBE JHPLPGAICLK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private BBDNFHGFMBE NELMIKFANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF1B00", Offset = "0x6EF0300", VA = "0x186EF1B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2260", Offset = "0x6EF0A60", VA = "0x186EF2260")]
	public CAGIFMBMKAP(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, int EOBNIBIDBLG = -1, int OJIGADINHJI = -1, [Optional] Func<Component, float> LDECIACHKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1B70", Offset = "0x6EF0370", VA = "0x186EF1B70")]
	public void HKACIPCJEND(Component JFDMKPDIBDL, Action CDJHLNAAHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2010", Offset = "0x6EF0810", VA = "0x186EF2010")]
	public void NKDCPFHOOLG(Component JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1AA0", Offset = "0x6EF02A0", VA = "0x186EF1AA0")]
	public bool EDOAJBIOAFN(Component DPLEBJGMEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1DE0", Offset = "0x6EF05E0", VA = "0x186EF1DE0")]
	private void JGMEKIAAKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF1A30", Offset = "0x6EF0230", VA = "0x186EF1A30")]
	[IteratorStateMachine(typeof(KIDDCLABAGL))]
	private IEnumerator<EDDHBDCNFKM> AGBLFLPFOIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F507E0", Offset = "0x1F4EFE0", VA = "0x181F507E0")]
	[CompilerGenerated]
	private void KKNBAIBGKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF21A0", Offset = "0x6EF09A0", VA = "0x186EF21A0")]
	[CompilerGenerated]
	private float PGAFCEBDCNE(AMGKCKALKHO CDJHLNAAHGK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EBJDFPJEGJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GGPFPLDGNNB
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DBCICEJFIGD GOIMDICMEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FBLMBKJEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	global::NAOGJOJMPFD<DBCICEJFIGD> NGPAHIJNLME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJNLHCKPENF(DBCICEJFIGD CEELCIEEKGH, bool BMBKFCBEIJF = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6EF66A0", Offset = "0x6EF4EA0", VA = "0x186EF66A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6700", Offset = "0x6EF4F00", VA = "0x186EF6700")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6620", Offset = "0x6EF4E20", VA = "0x186EF6620")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6320", Offset = "0x6EF4B20", VA = "0x186EF6320")]
			public void JPFNLPMNEPA(PointerEventData JAAHBLLAPKL, RectTransform OBIKEGIECJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6EF61B0", Offset = "0x6EF49B0", VA = "0x186EF61B0")]
			public void BGKGDMNCEGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6530", Offset = "0x6EF4D30", VA = "0x186EF6530")]
			public void PFKMINLPPPJ(PointerEventData JAAHBLLAPKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6EF62D0", Offset = "0x6EF4AD0", VA = "0x186EF62D0")]
			public void HBHDFGELAOB(float OAGIIBPPFPO, RectTransform OBIKEGIECJA, Vector3 CLLBFIHFGKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly global::NAOGJOJMPFD<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly global::NAOGJOJMPFD<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly global::NAOGJOJMPFD<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly global::NAOGJOJMPFD<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly global::NAOGJOJMPFD<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly KBJOPGEOOCH PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly UIHandleEventData NLFDKGNDCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool OBGKJIKDPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool OKCBMLCEJCM;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool DGBDLPKGOPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB6D0A0", Offset = "0xB6B8A0", VA = "0x180B6D0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EF58A0", Offset = "0x6EF40A0", VA = "0x186EF58A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool MBACFNKEJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB6D120", Offset = "0xB6B920", VA = "0x180B6D120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6EF5FA0", Offset = "0x6EF47A0", VA = "0x186EF5FA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5810", Offset = "0x6EF4010", VA = "0x186EF5810")]
		private bool APLNBAFKDDC(PointerEventData CBLNAPKAJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5E80", Offset = "0x6EF4680", VA = "0x186EF5E80", Slot = "5")]
		public void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5F40", Offset = "0x6EF4740", VA = "0x186EF5F40", Slot = "11")]
		public void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5BE0", Offset = "0x6EF43E0", VA = "0x186EF5BE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF58D0", Offset = "0x6EF40D0", VA = "0x186EF58D0", Slot = "7")]
		public void OnBeginDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5A00", Offset = "0x6EF4200", VA = "0x186EF5A00", Slot = "4")]
		public void OnDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5AF0", Offset = "0x6EF42F0", VA = "0x186EF5AF0", Slot = "8")]
		public void OnEndDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5EE0", Offset = "0x6EF46E0", VA = "0x186EF5EE0", Slot = "9")]
		public void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5F10", Offset = "0x6EF4710", VA = "0x186EF5F10", Slot = "10")]
		public void OnPointerExit(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF59C0", Offset = "0x6EF41C0", VA = "0x186EF59C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5FD0", Offset = "0x6EF47D0", VA = "0x186EF5FD0")]
		public UIHandleDecorator()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
