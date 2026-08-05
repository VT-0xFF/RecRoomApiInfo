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
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LBNPCFOBKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient AHEHGFNIAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5110", Offset = "0x6EA3D10", VA = "0x186EA5110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public FIMEGLKJKFC JFINBJKLHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1201930", Offset = "0x1200530", VA = "0x181201930")]
			get
			{
				return default(FIMEGLKJKFC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5290", Offset = "0x6EA3E90", VA = "0x186EA5290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool DDDELONNEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6EA4B80", Offset = "0x6EA3780", VA = "0x186EA4B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 PNELKCHEAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6EA50A0", Offset = "0x6EA3CA0", VA = "0x186EA50A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6EA50C0", Offset = "0x6EA3CC0", VA = "0x186EA50C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OGCNIEAOPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EA4910", Offset = "0x6EA3510", VA = "0x186EA4910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 BOIJDEBEJHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BAD950", Offset = "0x6BAC550", VA = "0x186BAD950")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5240", Offset = "0x6EA3E40", VA = "0x186EA5240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PAOEPEGLNHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x17F4220", Offset = "0x17F2E20", VA = "0x1817F4220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1E19590", Offset = "0x1E18190", VA = "0x181E19590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 LBMFNAOEMBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3E10", Offset = "0x6EA2A10", VA = "0x186EA3E10")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 KCODPOCGNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EA4B00", Offset = "0x6EA3700", VA = "0x186EA4B00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float OIEABKGHNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x17E7040", Offset = "0x17E5C40", VA = "0x1817E7040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6EA52A0", Offset = "0x6EA3EA0", VA = "0x186EA52A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4080", Offset = "0x6EA2C80", VA = "0x186EA4080", Slot = "12")]
		protected override void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4990", Offset = "0x6EA3590", VA = "0x186EA4990")]
		private void HBGFOIFAJFP(Color[] DEKIMEPACBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4200", Offset = "0x6EA2E00", VA = "0x186EA4200", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3E60", Offset = "0x6EA2A60", VA = "0x186EA3E60", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4FE0", Offset = "0x6EA3BE0", VA = "0x186EA4FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA2040", Offset = "0x6EA0C40", VA = "0x186EA2040", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1F30", Offset = "0x6EA0B30", VA = "0x186EA1F30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1E70", Offset = "0x6EA0A70", VA = "0x186EA1E70")]
		private void ADFAELNIAMM(GameObject FKPECMJOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2230", Offset = "0x6EA0E30", VA = "0x186EA2230")]
		public void SetOptionsWithNoDefault(List<string> EFLCMDHDGNO, [Optional] string AGLGABHNKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2470", Offset = "0x6EA1070", VA = "0x186EA2470")]
		public void SetOptionsWithNoDefault(List<OptionData> GEAIFDNFEOL, [Optional] string AGLGABHNKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2150", Offset = "0x6EA0D50", VA = "0x186EA2150", Slot = "42")]
		public override void OnPointerClick(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81DEB0", Offset = "0x81CAB0", VA = "0x18081DEB0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas ACBLJJMKNPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2560", Offset = "0x6EA1160", VA = "0x186EA2560")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite NPGOLPIPPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8D20", Offset = "0x6EA7920", VA = "0x186EA8D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8F30", Offset = "0x6EA7B30", VA = "0x186EA8F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color BMFLHIOICAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8A6470", Offset = "0x8A5070", VA = "0x1808A6470")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8FD0", Offset = "0x6EA7BD0", VA = "0x186EA8FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color OONOPBLHAHA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABD960", VA = "0x180ABED60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8E20", Offset = "0x6EA7A20", VA = "0x186EA8E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float AJHABMMPGJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1672DB0", Offset = "0x16719B0", VA = "0x181672DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8EC0", Offset = "0x6EA7AC0", VA = "0x186EA8EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 DJLCIICLKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x184C4D0", Offset = "0x184B0D0", VA = "0x18184C4D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8EE0", Offset = "0x6EA7AE0", VA = "0x186EA8EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OIABMDMAMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x91CD30", Offset = "0x91B930", VA = "0x18091CD30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8E80", Offset = "0x6EA7A80", VA = "0x186EA8E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FGHNELDODFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1052860", Offset = "0x1051460", VA = "0x181052860")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9030", Offset = "0x6EA7C30", VA = "0x186EA9030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MEEJNLHEINM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x18E3840", Offset = "0x18E2440", VA = "0x1818E3840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8DF0", Offset = "0x6EA79F0", VA = "0x186EA8DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 NHDFCNLABMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8930", Offset = "0x6EA7530", VA = "0x186EA8930")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NNJMPEJKFOG JEBHICAMEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB641B0", Offset = "0xB62DB0", VA = "0x180B641B0")]
			get
			{
				return default(NNJMPEJKFOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8E10", Offset = "0x6EA7A10", VA = "0x186EA8E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DNIKGLPHKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xF09000", Offset = "0xF07C00", VA = "0x180F09000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8EA0", Offset = "0x6EA7AA0", VA = "0x186EA8EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PNEBAGDBINK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x184C4A0", Offset = "0x184B0A0", VA = "0x18184C4A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8DD0", Offset = "0x6EA79D0", VA = "0x186EA8DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7FF0", Offset = "0x6EA6BF0", VA = "0x186EA7FF0", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA86B0", Offset = "0x6EA72B0", VA = "0x186EA86B0")]
		private void KGBOAGGHHNM(Sprite POCNICPLMKL, out Vector2 HPONDHAIAHO, out Vector2 FDFMFILCNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7FA0", Offset = "0x6EA6BA0", VA = "0x186EA7FA0", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8C80", Offset = "0x6EA7880", VA = "0x186EA8C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EA90E0", Offset = "0x6EA7CE0", VA = "0x186EA90E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9080", Offset = "0x6EA7C80", VA = "0x186EA9080")]
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
			[Cpp2IlInjected.Address(RVA = "0x851940", Offset = "0x850540", VA = "0x180851940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x872FF0", Offset = "0x871BF0", VA = "0x180872FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> LNMBLOODOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3680", Offset = "0x6EA2280", VA = "0x186EA3680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6EA37C0", Offset = "0x6EA23C0", VA = "0x186EA37C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KMLPOGNHFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3720", Offset = "0x6EA2320", VA = "0x186EA3720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3860", Offset = "0x6EA2460", VA = "0x186EA3860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA35C0", Offset = "0x6EA21C0", VA = "0x186EA35C0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3620", Offset = "0x6EA2220", VA = "0x186EA3620", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x260ECA0", Offset = "0x260D8A0", VA = "0x18260ECA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x260ECA0", Offset = "0x260D8A0", VA = "0x18260ECA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA1170", Offset = "0x6E9FD70", VA = "0x186EA1170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static JJEDDHNNHCG BKMEGLNMJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1240", Offset = "0x6E9FE40", VA = "0x186EA1240")]
		get
		{
			return default(JJEDDHNNHCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1000", Offset = "0x6E9FC00", VA = "0x186EA1000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<JJEDDHNNHCG> HGLIDIPKPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1360", Offset = "0x6E9FF60", VA = "0x186EA1360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1420", Offset = "0x6EA0020", VA = "0x186EA1420")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public EHNFJCDJHKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6EA25D0", Offset = "0x6EA11D0", VA = "0x186EA25D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6EA2BB0", Offset = "0x6EA17B0", VA = "0x186EA2BB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EA32A0", Offset = "0x6EA1EA0", VA = "0x186EA32A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EFDENHNDGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3280", Offset = "0x6EA1E80", VA = "0x186EA3280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NGEHPHDGFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2302D80", Offset = "0x2301980", VA = "0x182302D80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6EA3490", Offset = "0x6EA2090", VA = "0x186EA3490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EJBPKONGLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6EA31E0", Offset = "0x6EA1DE0", VA = "0x186EA31E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6EA33F0", Offset = "0x6EA1FF0", VA = "0x186EA33F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2DB0", Offset = "0x6EA19B0", VA = "0x186EA2DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2F80", Offset = "0x6EA1B80", VA = "0x186EA2F80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2F00", Offset = "0x6EA1B00", VA = "0x186EA2F00")]
		public void Hide(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA30C0", Offset = "0x6EA1CC0", VA = "0x186EA30C0")]
		public void Show(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3020", Offset = "0x6EA1C20", VA = "0x186EA3020")]
		public void Set(object FLDJLPKNKKO, bool MBBEDGFKIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2BF0", Offset = "0x6EA17F0", VA = "0x186EA2BF0")]
		private void ANPJJMKPGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2E90", Offset = "0x6EA1A90", VA = "0x186EA2E90")]
		[IteratorStateMachine(typeof(EHNFJCDJHKL))]
		private IEnumerator<EDDHBDCNFKM> GGNEGJOANDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2E50", Offset = "0x6EA1A50", VA = "0x186EA2E50", Slot = "5")]
		public virtual void DoHideOrShow(bool JOPMCLFEBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3140", Offset = "0x6EA1D40", VA = "0x186EA3140")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x96FB0", Offset = "0x963B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> FHIHAFLCFDA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 PNELKCHEAFC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4891660", Offset = "0x4890260", VA = "0x184891660")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7F50", Offset = "0x6EA6B50", VA = "0x186EA7F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7C50", Offset = "0x6EA6850", VA = "0x186EA7C50")]
		public void SetRingLayers(IReadOnlyList<RingLayer> FDPDHOBKAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7A30", Offset = "0x6EA6630", VA = "0x186EA7A30")]
		public bool SetRingLayerColor(int DOBMDPHLPNO, Color OPOEPBAFNOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7B40", Offset = "0x6EA6740", VA = "0x186EA7B40")]
		public bool SetRingLayerSize(int DOBMDPHLPNO, float GEFPLPIBMGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7740", Offset = "0x6EA6340", VA = "0x186EA7740", Slot = "12")]
		protected override void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EA78B0", Offset = "0x6EA64B0", VA = "0x186EA78B0", Slot = "13")]
		protected override void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EA76F0", Offset = "0x6EA62F0", VA = "0x186EA76F0", Slot = "14")]
		protected override void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7DA0", Offset = "0x6EA69A0", VA = "0x186EA7DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool PFAJJIJPPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform OBIKEGIECJA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EA6A40", Offset = "0x6EA5640", VA = "0x186EA6A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect KMMJIEPHHKB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6EA6E30", Offset = "0x6EA5A30", VA = "0x186EA6E30")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite MIGPCBFEGGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6EA63A0", Offset = "0x6EA4FA0", VA = "0x186EA63A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6570", Offset = "0x6EA5170", VA = "0x186EA6570", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7250", Offset = "0x6EA5E50", VA = "0x186EA7250", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7570", Offset = "0x6EA6170", VA = "0x186EA7570", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7400", Offset = "0x6EA6000", VA = "0x186EA7400", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6760", Offset = "0x6EA5360", VA = "0x186EA6760")]
		private void CKBFFFEAFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EA68E0", Offset = "0x6EA54E0", VA = "0x186EA68E0")]
		private void HFICOMFPFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6F60", Offset = "0x6EA5B60", VA = "0x186EA6F60")]
		private void LGLIAJPGGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7200", Offset = "0x6EA5E00", VA = "0x186EA7200")]
		private void NHOEOHDAEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6F90", Offset = "0x6EA5B90", VA = "0x186EA6F90")]
		protected void NAKMNKANBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6260", Offset = "0x6EA4E60", VA = "0x186EA6260")]
		private void ACJDKMDEOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "12")]
		protected virtual void CEDIJJNIFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "13")]
		protected virtual void DBFGGOFBPKL(Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "14")]
		protected virtual void ADIKDNFIPFL(Material IJIKACDMPFI, bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6AA0", Offset = "0x6EA56A0", VA = "0x186EA6AA0")]
		private void JODJKLPFHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		[Conditional("RRUI_PROFILING")]
		protected void KFMHCHNODJN(string FMCIPDNGKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		[Conditional("RRUI_PROFILING")]
		protected void BIDAGHFJDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
			[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0FA0", Offset = "0x6E9FBA0", VA = "0x186EA0FA0")]
		public AMGKCKALKHO(Component JFDMKPDIBDL, Action DALKMBOLLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0E70", Offset = "0x6E9FA70", VA = "0x186EA0E70")]
		public void BNHDLCIOKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0F80", Offset = "0x6E9FB80", VA = "0x186EA0F80", Slot = "4")]
		public bool Equals(AMGKCKALKHO MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EA0EF0", Offset = "0x6E9FAF0", VA = "0x186EA0EF0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
		[DebuggerHidden]
		public KIDDCLABAGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3900", Offset = "0x6EA2500", VA = "0x186EA3900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3D10", Offset = "0x6EA2910", VA = "0x186EA3D10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA15B0", Offset = "0x6EA01B0", VA = "0x186EA15B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1D10", Offset = "0x6EA0910", VA = "0x186EA1D10")]
	public CAGIFMBMKAP(FAJLDPIGHEC.OCHFIJDOJPB JBGLADHOELN, int EOBNIBIDBLG = -1, int OJIGADINHJI = -1, [Optional] Func<Component, float> LDECIACHKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1620", Offset = "0x6EA0220", VA = "0x186EA1620")]
	public void HKACIPCJEND(Component JFDMKPDIBDL, Action CDJHLNAAHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1AC0", Offset = "0x6EA06C0", VA = "0x186EA1AC0")]
	public void NKDCPFHOOLG(Component JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1550", Offset = "0x6EA0150", VA = "0x186EA1550")]
	public bool EDOAJBIOAFN(Component DPLEBJGMEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1890", Offset = "0x6EA0490", VA = "0x186EA1890")]
	private void JGMEKIAAKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA14E0", Offset = "0x6EA00E0", VA = "0x186EA14E0")]
	[IteratorStateMachine(typeof(KIDDCLABAGL))]
	private IEnumerator<EDDHBDCNFKM> AGBLFLPFOIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C7A860", Offset = "0x1C79460", VA = "0x181C7A860")]
	[CompilerGenerated]
	private void KKNBAIBGKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1C50", Offset = "0x6EA0850", VA = "0x186EA1C50")]
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
				[Cpp2IlInjected.Address(RVA = "0x6EA6150", Offset = "0x6EA4D50", VA = "0x186EA6150")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6EA61B0", Offset = "0x6EA4DB0", VA = "0x186EA61B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6EA60D0", Offset = "0x6EA4CD0", VA = "0x186EA60D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5DD0", Offset = "0x6EA49D0", VA = "0x186EA5DD0")]
			public void JPFNLPMNEPA(PointerEventData JAAHBLLAPKL, RectTransform OBIKEGIECJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5C60", Offset = "0x6EA4860", VA = "0x186EA5C60")]
			public void BGKGDMNCEGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5FE0", Offset = "0x6EA4BE0", VA = "0x186EA5FE0")]
			public void PFKMINLPPPJ(PointerEventData JAAHBLLAPKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5D80", Offset = "0x6EA4980", VA = "0x186EA5D80")]
			public void HBHDFGELAOB(float OAGIIBPPFPO, RectTransform OBIKEGIECJA, Vector3 CLLBFIHFGKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xACF0F0", Offset = "0xACDCF0", VA = "0x180ACF0F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5350", Offset = "0x6EA3F50", VA = "0x186EA5350")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool MBACFNKEJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACF170", Offset = "0xACDD70", VA = "0x180ACF170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6EA5A50", Offset = "0x6EA4650", VA = "0x186EA5A50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EA52C0", Offset = "0x6EA3EC0", VA = "0x186EA52C0")]
		private bool APLNBAFKDDC(PointerEventData CBLNAPKAJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5930", Offset = "0x6EA4530", VA = "0x186EA5930", Slot = "5")]
		public void OnPointerDown(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EA59F0", Offset = "0x6EA45F0", VA = "0x186EA59F0", Slot = "11")]
		public void OnPointerUp(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5690", Offset = "0x6EA4290", VA = "0x186EA5690", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5380", Offset = "0x6EA3F80", VA = "0x186EA5380", Slot = "7")]
		public void OnBeginDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EA54B0", Offset = "0x6EA40B0", VA = "0x186EA54B0", Slot = "4")]
		public void OnDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EA55A0", Offset = "0x6EA41A0", VA = "0x186EA55A0", Slot = "8")]
		public void OnEndDrag(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5990", Offset = "0x6EA4590", VA = "0x186EA5990", Slot = "9")]
		public void OnPointerEnter(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EA59C0", Offset = "0x6EA45C0", VA = "0x186EA59C0", Slot = "10")]
		public void OnPointerExit(PointerEventData CBLNAPKAJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5470", Offset = "0x6EA4070", VA = "0x186EA5470")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5A80", Offset = "0x6EA4680", VA = "0x186EA5A80")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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
