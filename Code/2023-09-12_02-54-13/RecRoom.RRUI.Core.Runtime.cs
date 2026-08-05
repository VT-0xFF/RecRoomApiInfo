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
		public enum NCAOHDHFKKJ : byte
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
		private static readonly int EFDOOIPFJPN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<NCAOHDHFKKJ, string> KLFBLOEICDL;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int NLFNAIBJLLF = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int NHHCFDMAHIK;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int JCNGPBMJENL;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int FNHIMPCEION;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int DDFDJMDKCDI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int PEDLOHCBHAF;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int BIDDANKLACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool CDIECOIGOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ALCLFOKIGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] NBAAFFIFBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private NCAOHDHFKKJ type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly NCAOHDHFKKJ[] ECLELFDAFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[NJBIPLMLOIA("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly NCAOHDHFKKJ[] ILJLFGICEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[NJBIPLMLOIA("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[NJBIPLMLOIA("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[NJBIPLMLOIA("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic ECIIFKEGNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool HECGMENKLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient DGFJGHJFKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3330", Offset = "0x6FF2730", VA = "0x186FF3330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NCAOHDHFKKJ OILIJCDIDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA7EA10", Offset = "0xA7DE10", VA = "0x180A7EA10")]
			get
			{
				return default(NCAOHDHFKKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6FF34B0", Offset = "0x6FF28B0", VA = "0x186FF34B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool FEJBFMOHIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6FF22C0", Offset = "0x6FF16C0", VA = "0x186FF22C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 DDMOOCEJBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6FF32A0", Offset = "0x6FF26A0", VA = "0x186FF32A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FF32E0", Offset = "0x6FF26E0", VA = "0x186FF32E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool GKKFGOHCPMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF2BC0", Offset = "0x6FF1FC0", VA = "0x186FF2BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 CFPFGEHPDPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF32C0", Offset = "0x6FF26C0", VA = "0x186FF32C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3460", Offset = "0x6FF2860", VA = "0x186FF3460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float CECHBEAOCCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x110C090", Offset = "0x110B490", VA = "0x18110C090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1A906C0", Offset = "0x1A8FAC0", VA = "0x181A906C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 FEJOHPAHLCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FF2DB0", Offset = "0x6FF21B0", VA = "0x186FF2DB0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 HEOIEDEFIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FF2030", Offset = "0x6FF1430", VA = "0x186FF2030")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float GLBLJKAKHPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD9CAC0", Offset = "0xD9BEC0", VA = "0x180D9CAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FF34C0", Offset = "0x6FF28C0", VA = "0x186FF34C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2340", Offset = "0x6FF1740", VA = "0x186FF2340", Slot = "12")]
		protected override void FIBMONGIMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2C40", Offset = "0x6FF2040", VA = "0x186FF2C40")]
		private void LHKIEOFDIDG(Color[] IIHFJPIIPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FF24C0", Offset = "0x6FF18C0", VA = "0x186FF24C0", Slot = "13")]
		protected override void JDKFCNAHODD(Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FF20A0", Offset = "0x6FF14A0", VA = "0x186FF20A0", Slot = "14")]
		protected override void CHLMCCEPDHF(Material NKAMKIHOODJ, bool OMIGIJBCKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FF31E0", Offset = "0x6FF25E0", VA = "0x186FF31E0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData FENONHBBLFJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFDB0", Offset = "0x6FEF1B0", VA = "0x186FEFDB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFCA0", Offset = "0x6FEF0A0", VA = "0x186FEFCA0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFBE0", Offset = "0x6FEEFE0", VA = "0x186FEFBE0")]
		private void CKHCKHNIMGM(GameObject KHMMPIEHJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFFA0", Offset = "0x6FEF3A0", VA = "0x186FEFFA0")]
		public void SetOptionsWithNoDefault(List<string> IKBLLODDBLI, [Optional] string MKDDCAPFLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF01E0", Offset = "0x6FEF5E0", VA = "0x186FF01E0")]
		public void SetOptionsWithNoDefault(List<OptionData> PPHPNENEJCI, [Optional] string MKDDCAPFLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFEC0", Offset = "0x6FEF2C0", VA = "0x186FEFEC0", Slot = "42")]
		public override void OnPointerClick(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas EPBMEJGHGCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FF02D0", Offset = "0x6FEF6D0", VA = "0x186FF02D0")]
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
		public enum MIBMGCJPGPK
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int PIJNCEKAMIE;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int FFFMBAGHDIN;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int DBEMLKOAJEN;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int BJFLALIPCHF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int FFHIOBIKAPP;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int COFMLLIIJIG;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int IPKLAFJJBLN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int FOPPKENBPAE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int CAIOBMHNCIF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int CMCCNPAKBBB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int EEEBPCNFKOP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int GGMGLNKADPE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int MAFJIBHEALA;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int GECGIFFDCGA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int CNOAJCLLHAJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int GMFPCFCDJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
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
		private MIBMGCJPGPK animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[NJBIPLMLOIA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[NJBIPLMLOIA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic ECIIFKEGNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool HLGLMDAOKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite OGOPDDNDLAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6F50", Offset = "0x6FF6350", VA = "0x186FF6F50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7160", Offset = "0x6FF6560", VA = "0x186FF7160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color EPOHAFLIGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x985800", Offset = "0x984C00", VA = "0x180985800")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7200", Offset = "0x6FF6600", VA = "0x186FF7200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color DHKNLOMNBCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x16BEE30", Offset = "0x16BE230", VA = "0x1816BEE30")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7050", Offset = "0x6FF6450", VA = "0x186FF7050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float HKMDANEDCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xE84260", Offset = "0xE83660", VA = "0x180E84260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FF70F0", Offset = "0x6FF64F0", VA = "0x186FF70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 LHHELHKJHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xC2F710", Offset = "0xC2EB10", VA = "0x180C2F710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7110", Offset = "0x6FF6510", VA = "0x186FF7110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ENIJHDDIJJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x110C0F0", Offset = "0x110B4F0", VA = "0x18110C0F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FF70B0", Offset = "0x6FF64B0", VA = "0x186FF70B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FBDOMBJACLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x22E1FA0", Offset = "0x22E13A0", VA = "0x1822E1FA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7260", Offset = "0x6FF6660", VA = "0x186FF7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float INJIFPNJOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x113BBF0", Offset = "0x113AFF0", VA = "0x18113BBF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7020", Offset = "0x6FF6420", VA = "0x186FF7020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 CEGDLOHOEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6220", Offset = "0x6FF5620", VA = "0x186FF6220")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MIBMGCJPGPK GHNLMIDKACH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x97BD70", Offset = "0x97B170", VA = "0x18097BD70")]
			get
			{
				return default(MIBMGCJPGPK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7040", Offset = "0x6FF6440", VA = "0x186FF7040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float BBNNGFCGDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x173CAA0", Offset = "0x173BEA0", VA = "0x18173CAA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF70D0", Offset = "0x6FF64D0", VA = "0x186FF70D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float BCOPHDEEHPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xC2F6D0", Offset = "0xC2EAD0", VA = "0x180C2F6D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7000", Offset = "0x6FF6400", VA = "0x186FF7000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6510", Offset = "0x6FF5910", VA = "0x186FF6510", Slot = "13")]
		protected override void JDKFCNAHODD(Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6290", Offset = "0x6FF5690", VA = "0x186FF6290")]
		private void HIKHENHJCKG(Sprite KBDOOBFPCNA, out Vector2 PKANNEEOONA, out Vector2 NLIDLHECBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF61D0", Offset = "0x6FF55D0", VA = "0x186FF61D0", Slot = "14")]
		protected override void CHLMCCEPDHF(Material NKAMKIHOODJ, bool OMIGIJBCKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6EB0", Offset = "0x6FF62B0", VA = "0x186FF6EB0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader MPOMGOCENII;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader NPNFHBPPJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7310", Offset = "0x6FF6710", VA = "0x186FF7310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FF72B0", Offset = "0x6FF66B0", VA = "0x186FF72B0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool BOOLEKFLJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> DHBICOOJCCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FF13E0", Offset = "0x6FF07E0", VA = "0x186FF13E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1520", Offset = "0x6FF0920", VA = "0x186FF1520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> DGNKDBABLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1480", Offset = "0x6FF0880", VA = "0x186FF1480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6FF15C0", Offset = "0x6FF09C0", VA = "0x186FF15C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1320", Offset = "0x6FF0720", VA = "0x186FF1320", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1380", Offset = "0x6FF0780", VA = "0x186FF1380", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x15F79C0", Offset = "0x15F6DC0", VA = "0x1815F79C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x15F79C0", Offset = "0x15F6DC0", VA = "0x1815F79C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PJHLDDCIIPL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum HGODCAAFEBH
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static IAJGLGCJAOD JPABHOJDALN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static IAJGLGCJAOD FMOLIMNJIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AB0", Offset = "0x6FF0EB0", VA = "0x186FF1AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static HGODCAAFEBH PDEFKFOIOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1D00", Offset = "0x6FF1100", VA = "0x186FF1D00")]
		get
		{
			return default(HGODCAAFEBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1E10", Offset = "0x6FF1210", VA = "0x186FF1E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<HGODCAAFEBH> OPKPBJPMMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1C40", Offset = "0x6FF1040", VA = "0x186FF1C40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1B80", Offset = "0x6FF0F80", VA = "0x186FF1B80")]
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
		private sealed class FJDIOHHIKGB : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private PHFLFKPMCCG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public FJDIOHHIKGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0340", Offset = "0x6FEF740", VA = "0x186FF0340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6FF08F0", Offset = "0x6FEFCF0", VA = "0x186FF08F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[ODLEDLFOPDE(BLGBJPBFLHB.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly GLMKJHJBJDA EIIJPMDLPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool HHJGKEGMKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? MMEHIBCHPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? BAJFABOCDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool? FMEBDEIILNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool INCOJPCMBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool OCEFHCGPEMO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool DKGHEOBPOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1000", Offset = "0x6FF0400", VA = "0x186FF1000", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool KCMMKNGDCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0FE0", Offset = "0x6FF03E0", VA = "0x186FF0FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JKEJMCPFLAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x160C600", Offset = "0x160BA00", VA = "0x18160C600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6FF11F0", Offset = "0x6FF05F0", VA = "0x186FF11F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MFCGBBPHLCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0F40", Offset = "0x6FF0340", VA = "0x186FF0F40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1150", Offset = "0x6FF0550", VA = "0x186FF1150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0930", Offset = "0x6FEFD30", VA = "0x186FF0930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0CC0", Offset = "0x6FF00C0", VA = "0x186FF0CC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0A10", Offset = "0x6FEFE10", VA = "0x186FF0A10")]
		public void Hide(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0E10", Offset = "0x6FF0210", VA = "0x186FF0E10")]
		public void Show(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0D60", Offset = "0x6FF0160", VA = "0x186FF0D60")]
		public void Set(object AEMEEHLIDCM, bool KKBOECFHCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0B10", Offset = "0x6FEFF10", VA = "0x186FF0B10")]
		private void NGAIDAIJEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0AA0", Offset = "0x6FEFEA0", VA = "0x186FF0AA0")]
		[IteratorStateMachine(typeof(FJDIOHHIKGB))]
		private IEnumerator<PHFLFKPMCCG> KFNLCEANPNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6FF09D0", Offset = "0x6FEFDD0", VA = "0x186FF09D0", Slot = "5")]
		public virtual void DoHideOrShow(bool DPBEPPJKLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0EA0", Offset = "0x6FF02A0", VA = "0x186FF0EA0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x133060", Offset = "0x132460")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int GMNIMCFKKEL;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int BHKNNMOHJDP;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int AKFLHLHGOHH;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int JOLHEPCBEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
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
		private Color[] NBAAFFIFBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float[] CHDJEEIEAJO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic ECIIFKEGNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool HLGLMDAOKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> ACKDAMLOGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 DDMOOCEJBIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x41BF650", Offset = "0x41BEA50", VA = "0x1841BF650")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6180", Offset = "0x6FF5580", VA = "0x186FF6180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5E70", Offset = "0x6FF5270", VA = "0x186FF5E70")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PEEEAPGEMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5C30", Offset = "0x6FF5030", VA = "0x186FF5C30")]
		public bool SetRingLayerColor(int CJBPODGOGEE, Color DEJOCIOKOBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5D50", Offset = "0x6FF5150", VA = "0x186FF5D50")]
		public bool SetRingLayerSize(int CJBPODGOGEE, float AJCINIIEJAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5950", Offset = "0x6FF4D50", VA = "0x186FF5950", Slot = "12")]
		protected override void FIBMONGIMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5AB0", Offset = "0x6FF4EB0", VA = "0x186FF5AB0", Slot = "13")]
		protected override void JDKFCNAHODD(Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5900", Offset = "0x6FF4D00", VA = "0x186FF5900", Slot = "14")]
		protected override void CHLMCCEPDHF(Material NKAMKIHOODJ, bool OMIGIJBCKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5FC0", Offset = "0x6FF53C0", VA = "0x186FF5FC0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly APKFOGHLOHE AEDLGABHHBL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Sprite LFJKMPBCJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Material OLLNDFAMGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Material HHDCPKHMKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool FCCCEDBJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool HHJGKEGMKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool GAAAEMLGJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool LPCAPHIBGML;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic ECIIFKEGNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader NPNFHBPPJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool HECGMENKLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool HLGLMDAOKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform KCNMHLHIGND
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4E90", Offset = "0x6FF4290", VA = "0x186FF4E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect BHFCBNCIDOB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4BE0", Offset = "0x6FF3FE0", VA = "0x186FF4BE0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite BBEPMJCJHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4EF0", Offset = "0x6FF42F0", VA = "0x186FF4EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4460", Offset = "0x6FF3860", VA = "0x186FF4460", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF50C0", Offset = "0x6FF44C0", VA = "0x186FF50C0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF53F0", Offset = "0x6FF47F0", VA = "0x186FF53F0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5270", Offset = "0x6FF4670", VA = "0x186FF5270", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4D10", Offset = "0x6FF4110", VA = "0x186FF4D10")]
		private void MLMBGMFIIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4650", Offset = "0x6FF3A50", VA = "0x186FF4650")]
		private void COHLCIMGDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4BB0", Offset = "0x6FF3FB0", VA = "0x186FF4BB0")]
		private void KIEPICFDKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FF48F0", Offset = "0x6FF3CF0", VA = "0x186FF48F0")]
		private void IBGILPOHAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4940", Offset = "0x6FF3D40", VA = "0x186FF4940")]
		protected void KGKHKABKEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FF47B0", Offset = "0x6FF3BB0", VA = "0x186FF47B0")]
		private void GCPNLGNHMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
		protected virtual void FIBMONGIMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
		protected virtual void JDKFCNAHODD(Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "14")]
		protected virtual void CHLMCCEPDHF(Material NKAMKIHOODJ, bool OMIGIJBCKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5400", Offset = "0x6FF4800", VA = "0x186FF5400")]
		private void PGMMNDABJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PPPJDNCJLOK : ELHONIELACG, DENJLBEHCLK, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CEFLAGENLCN<GameObject, int> LMENNIPJJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MAPBMMJPPEG<GameObject, int, bool> CPIMGLENBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PJFJKKKIAHI<bool> HDHNNNFHHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool AJJIABHLLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float BGJJLGJHIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PJFJKKKIAHI<float> PBABCKIJFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MLPFDGHACOI JGJLAKGKDIP
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
	void SpawnLoadingPlaceholders(GameObject OGOBDKNMJKA);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PMFPAFFNEKC Spawn<T>(int LHGJJCODHPP, IReadOnlyList<T> CLCAIFLMLCJ, GameObject OGOBDKNMJKA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PMFPAFFNEKC Spawn<T>(int LHGJJCODHPP, IReadOnlyList<T> CLCAIFLMLCJ, GameObject LMIEPNCAHDH, ref Func<int, GameObject> AOFKONPJIAJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int BNOAGGNAMKG, float LPPDLFDPPDN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class APKFOGHLOHE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct CHFJBGDCNGJ : IEquatable<CHFJBGDCNGJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Component AKPCLGIGABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Action BFDAIIJJIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly int GOFKJNEEJGB;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component IKLENBPEBKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFB80", Offset = "0x6FEEF80", VA = "0x186FEFB80")]
		public CHFJBGDCNGJ(Component AKPCLGIGABA, Action BFDAIIJJIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFB00", Offset = "0x6FEEF00", VA = "0x186FEFB00")]
		public void NBOCHEIPFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFAE0", Offset = "0x6FEEEE0", VA = "0x186FEFAE0", Slot = "4")]
		public bool Equals(CHFJBGDCNGJ ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFA50", Offset = "0x6FEEE50", VA = "0x186FEFA50", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JKHDNEHHNEA : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public APKFOGHLOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IOrderedEnumerable<CHFJBGDCNGJ> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CHFJBGDCNGJ <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public JKHDNEHHNEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1660", Offset = "0x6FF0A60", VA = "0x186FF1660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1A70", Offset = "0x6FF0E70", VA = "0x186FF1A70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int ANGJPAEDLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly int IBFDHBCGIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<Component, float> AEMOJBFKBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<Component, CHFJBGDCNGJ> LILABAIOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LinkedList<CHFJBGDCNGJ> HKPEAPLCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<CHFJBGDCNGJ> BHKHAINHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IMJDOMFMBGH OLGJDLGNBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LCOFBOLIOHO AOJODOCHEOF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private LCOFBOLIOHO MJCOGJBIJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF0D0", Offset = "0x6FEE4D0", VA = "0x186FEF0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF8F0", Offset = "0x6FEECF0", VA = "0x186FEF8F0")]
	public APKFOGHLOHE(FKCMFGAFJFA PGPJEOCIBPN, int ANGJPAEDLIF = -1, int IBFDHBCGIDD = -1, [Optional] Func<Component, float> AEMOJBFKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF4F0", Offset = "0x6FEE8F0", VA = "0x186FEF4F0")]
	public void LKIOHILIPGI(Component AKPCLGIGABA, Action CMBFEPDDNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF760", Offset = "0x6FEEB60", VA = "0x186FEF760")]
	public void MDOCJHDDIHK(Component AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF140", Offset = "0x6FEE540", VA = "0x186FEF140")]
	public bool ANIJKICBBMC(Component EGEAFOFCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF1A0", Offset = "0x6FEE5A0", VA = "0x186FEF1A0")]
	private void ELBNEKFJBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF3C0", Offset = "0x6FEE7C0", VA = "0x186FEF3C0")]
	[IteratorStateMachine(typeof(JKHDNEHHNEA))]
	private IEnumerator<PHFLFKPMCCG> HFEEHDCEJIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xF214D0", Offset = "0xF208D0", VA = "0x180F214D0")]
	[CompilerGenerated]
	private void KIBCCCEJNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF430", Offset = "0x6FEE830", VA = "0x186FEF430")]
	[CompilerGenerated]
	private float KPODKCJKLKF(CHFJBGDCNGJ CMBFEPDDNLN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EMFNOJCBDFC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BPKCBEFEDKB CGBHIDGCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CKDFPMJKMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PJFJKKKIAHI<BPKCBEFEDKB> COHOEFHHKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJNAJDCMJMM(BPKCBEFEDKB FBJMFPBIPBE, bool EKGCIJOPPEP = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6FF4350", Offset = "0x6FF3750", VA = "0x186FF4350")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6FF43B0", Offset = "0x6FF37B0", VA = "0x186FF43B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6FF4300", Offset = "0x6FF3700", VA = "0x186FF4300")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3E80", Offset = "0x6FF3280", VA = "0x186FF3E80")]
			public void DOLOEOAAIBP(PointerEventData CLJJKPMBNNI, RectTransform KCNMHLHIGND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6FF4090", Offset = "0x6FF3490", VA = "0x186FF4090")]
			public void KCJCDAPEHLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6FF41B0", Offset = "0x6FF35B0", VA = "0x186FF41B0")]
			public void KEAKIGOCCLA(PointerEventData CLJJKPMBNNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6FF42B0", Offset = "0x6FF36B0", VA = "0x186FF42B0")]
			public void LOPJNCLIIGA(float GLDLMMMOIAL, RectTransform KCNMHLHIGND, Vector3 IEGBDEAOAGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly PJFJKKKIAHI<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly PJFJKKKIAHI<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly PJFJKKKIAHI<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly PJFJKKKIAHI<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly PJFJKKKIAHI<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly MLPFDGHACOI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly UIHandleEventData MKBEIBLPMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool IGJCHOFHFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool NANMIPPPBAN;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool GABMFJFGEMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDBD7E0", Offset = "0xDBCBE0", VA = "0x180DBD7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6FF35A0", Offset = "0x6FF29A0", VA = "0x186FF35A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool HOHHOJPHPEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xDBD7D0", Offset = "0xDBCBD0", VA = "0x180DBD7D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3570", Offset = "0x6FF2970", VA = "0x186FF3570")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF34E0", Offset = "0x6FF28E0", VA = "0x186FF34E0")]
		private bool CNCLOIPMHDM(PointerEventData FIOCENBHCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3B80", Offset = "0x6FF2F80", VA = "0x186FF3B80", Slot = "5")]
		public void OnPointerDown(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3C40", Offset = "0x6FF3040", VA = "0x186FF3C40", Slot = "11")]
		public void OnPointerUp(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF38E0", Offset = "0x6FF2CE0", VA = "0x186FF38E0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF35D0", Offset = "0x6FF29D0", VA = "0x186FF35D0", Slot = "7")]
		public void OnBeginDrag(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3700", Offset = "0x6FF2B00", VA = "0x186FF3700", Slot = "4")]
		public void OnDrag(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF37F0", Offset = "0x6FF2BF0", VA = "0x186FF37F0", Slot = "8")]
		public void OnEndDrag(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3BE0", Offset = "0x6FF2FE0", VA = "0x186FF3BE0", Slot = "9")]
		public void OnPointerEnter(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3C10", Offset = "0x6FF3010", VA = "0x186FF3C10", Slot = "10")]
		public void OnPointerExit(PointerEventData FIOCENBHCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF36C0", Offset = "0x6FF2AC0", VA = "0x186FF36C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3CA0", Offset = "0x6FF30A0", VA = "0x186FF3CA0")]
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
