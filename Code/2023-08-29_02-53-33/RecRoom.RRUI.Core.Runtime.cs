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
		public enum PEPIMKPDCGJ : byte
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
		private static readonly int PJOGOIENIKN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<PEPIMKPDCGJ, string> KPBBKMDPOFL;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int FEEIIGKIIEK = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int MNJNFLFHEHB;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int JGABNKPKAFH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int IAMDKEFOPEC;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int OFFMJHNFIPJ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int CFLJPIABCGG;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int ODBGDFMFNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OKLBJMNNAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HEEMHDPGMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] LDCGEDKKCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private PEPIMKPDCGJ type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly PEPIMKPDCGJ[] OHPIBFKHCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[MOONDAGFBDO("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly PEPIMKPDCGJ[] NOMDGPNBEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[MOONDAGFBDO("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[MOONDAGFBDO("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[MOONDAGFBDO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic CCHKBHGBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MDNPBLOJFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient BMFLMOHGEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A0F0", Offset = "0x6D894F0", VA = "0x186D8A0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public PEPIMKPDCGJ JJGFPAEGNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x948C80", Offset = "0x948080", VA = "0x180948C80")]
			get
			{
				return default(PEPIMKPDCGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A270", Offset = "0x6D89670", VA = "0x186D8A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool FPLJPLBOICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6D88DF0", Offset = "0x6D881F0", VA = "0x186D88DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 IOMMPDGKHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A060", Offset = "0x6D89460", VA = "0x186D8A060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A0A0", Offset = "0x6D894A0", VA = "0x186D8A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool BBIFDKBPADH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D89210", Offset = "0x6D88610", VA = "0x186D89210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 CJIDOIOBCHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A080", Offset = "0x6D89480", VA = "0x186D8A080")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A220", Offset = "0x6D89620", VA = "0x186D8A220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float KIPMJDMCOAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1380E90", Offset = "0x1380290", VA = "0x181380E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1989AB0", Offset = "0x1988EB0", VA = "0x181989AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 APMPAANKFGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D89990", Offset = "0x6D88D90", VA = "0x186D89990")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 BHANFEBKIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6D89B50", Offset = "0x6D88F50", VA = "0x186D89B50")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float BEFMHOKOIBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDD1650", Offset = "0xDD0A50", VA = "0x180DD1650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A280", Offset = "0x6D89680", VA = "0x186D8A280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D88E70", Offset = "0x6D88270", VA = "0x186D88E70", Slot = "12")]
		protected override void EAOAANIEGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D899E0", Offset = "0x6D88DE0", VA = "0x186D899E0")]
		private void LBLNOFDNKJP(Color[] GFJMHEIEINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D89290", Offset = "0x6D88690", VA = "0x186D89290", Slot = "13")]
		protected override void JIPEKMPKNMG(Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D88FF0", Offset = "0x6D883F0", VA = "0x186D88FF0", Slot = "14")]
		protected override void EPLHAIAFGOA(Material JMOIMJGFABM, bool GDHKPCGLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D89FA0", Offset = "0x6D893A0", VA = "0x186D89FA0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData PCBEDBKBPKB;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D87160", Offset = "0x6D86560", VA = "0x186D87160", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D87050", Offset = "0x6D86450", VA = "0x186D87050", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86F90", Offset = "0x6D86390", VA = "0x186D86F90")]
		private void OGIOLFGFONN(GameObject GNJGOEGKOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D87350", Offset = "0x6D86750", VA = "0x186D87350")]
		public void SetOptionsWithNoDefault(List<string> FHJNGFFBLOE, [Optional] string LONHDCFLJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D87590", Offset = "0x6D86990", VA = "0x186D87590")]
		public void SetOptionsWithNoDefault(List<OptionData> CPIBKOBEODB, [Optional] string LONHDCFLJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D87270", Offset = "0x6D86670", VA = "0x186D87270", Slot = "42")]
		public override void OnPointerClick(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas FPOECMOGOAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D87680", Offset = "0x6D86A80", VA = "0x186D87680")]
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
		public enum LGEIFGEFIJE
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int OCFENLKMHIL;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int PNJBIBEOMLM;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int PLHKHMACELF;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int NOCNPPCFINF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int BKEIINNCHOG;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int IDCANGLIEKD;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int FFGEIPKHNKO;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int JBKPGMLOFMC;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int AEIKIENHPMM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int CGJFLKKMMFF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int ODIBEKNCOEA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int COOKOLGFBEP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int FLJJPEPKJEE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BJHODLANGBP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int IDDFECBGLFL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HKEFHNFMJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
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
		private LGEIFGEFIJE animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[MOONDAGFBDO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[MOONDAGFBDO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic CCHKBHGBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool FBEBOAIONDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite FEEEBCHAMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DD10", Offset = "0x6D8D110", VA = "0x186D8DD10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DF20", Offset = "0x6D8D320", VA = "0x186D8DF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color JOECPOIAHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9CDA90", Offset = "0x9CCE90", VA = "0x1809CDA90")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DFC0", Offset = "0x6D8D3C0", VA = "0x186D8DFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color EPAIDFDHDMF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x17433E0", Offset = "0x17427E0", VA = "0x1817433E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DE10", Offset = "0x6D8D210", VA = "0x186D8DE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float DLDAHLBNIBC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xB90640", Offset = "0xB8FA40", VA = "0x180B90640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DEB0", Offset = "0x6D8D2B0", VA = "0x186D8DEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 FHJDPGDHEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCF9CE0", Offset = "0xCF90E0", VA = "0x180CF9CE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DED0", Offset = "0x6D8D2D0", VA = "0x186D8DED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JLBPIHHCKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1380EF0", Offset = "0x13802F0", VA = "0x181380EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DE70", Offset = "0x6D8D270", VA = "0x186D8DE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 IEFOLNHCPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2195130", Offset = "0x2194530", VA = "0x182195130")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E020", Offset = "0x6D8D420", VA = "0x186D8E020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OCMBBDMADKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15E8450", Offset = "0x15E7850", VA = "0x1815E8450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DDE0", Offset = "0x6D8D1E0", VA = "0x186D8DDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 EAJMDJGCDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D920", Offset = "0x6D8CD20", VA = "0x186D8D920")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LGEIFGEFIJE CFIEHFNPDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9C4360", Offset = "0x9C3760", VA = "0x1809C4360")]
			get
			{
				return default(LGEIFGEFIJE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DE00", Offset = "0x6D8D200", VA = "0x186D8DE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DBNINCDMBPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8C2FC0", Offset = "0x8C23C0", VA = "0x1808C2FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DE90", Offset = "0x6D8D290", VA = "0x186D8DE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NPAKGJLMPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3120", Offset = "0x8C2520", VA = "0x1808C3120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DDC0", Offset = "0x6D8D1C0", VA = "0x186D8DDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D260", Offset = "0x6D8C660", VA = "0x186D8D260", Slot = "13")]
		protected override void JIPEKMPKNMG(Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CF90", Offset = "0x6D8C390", VA = "0x186D8CF90")]
		private void AOGBPDNOIEC(Sprite PLOHDOPBCDF, out Vector2 CHDDJAPLMFE, out Vector2 CNOMAGNIBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D210", Offset = "0x6D8C610", VA = "0x186D8D210", Slot = "14")]
		protected override void EPLHAIAFGOA(Material JMOIMJGFABM, bool GDHKPCGLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D8DC70", Offset = "0x6D8D070", VA = "0x186D8DC70")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader BIMBMFFONDM;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader MLDALHBFICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E0D0", Offset = "0x6D8D4D0", VA = "0x186D8E0D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E070", Offset = "0x6D8D470", VA = "0x186D8E070")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool DKHGIEOAIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x992D00", Offset = "0x992100", VA = "0x180992D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> MKDGGBGLNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D88AB0", Offset = "0x6D87EB0", VA = "0x186D88AB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D88BF0", Offset = "0x6D87FF0", VA = "0x186D88BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> BLOGDNICJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D88B50", Offset = "0x6D87F50", VA = "0x186D88B50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D88C90", Offset = "0x6D88090", VA = "0x186D88C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D889F0", Offset = "0x6D87DF0", VA = "0x186D889F0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D88A50", Offset = "0x6D87E50", VA = "0x186D88A50", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1782140", Offset = "0x1781540", VA = "0x181782140")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1782140", Offset = "0x1781540", VA = "0x181782140")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GGIMLDAMKJM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NLGLLCCKDDG
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static HNFFDGDJOBC OKOOGLAJHAM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static HNFFDGDJOBC NOOJCKCEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D87980", Offset = "0x6D86D80", VA = "0x186D87980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static NLGLLCCKDDG LENBBHMOBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D876F0", Offset = "0x6D86AF0", VA = "0x186D876F0")]
		get
		{
			return default(NLGLLCCKDDG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D87A50", Offset = "0x6D86E50", VA = "0x186D87A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<NLGLLCCKDDG> GFNHLEDBEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D878C0", Offset = "0x6D86CC0", VA = "0x186D878C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D87800", Offset = "0x6D86C00", VA = "0x186D87800")]
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
		private sealed class BPKKFJLFNFP : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private LJHFBCJIPCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public BPKKFJLFNFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D86810", Offset = "0x6D85C10", VA = "0x186D86810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6D86DC0", Offset = "0x6D861C0", VA = "0x186D86DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[DKFFELGGOBP(NKLEIIOOMFD.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly LMDJEEFCDOJ LHGBDLCMFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool BIPJLCMJDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Vector3? OIBJFGBOCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool? EIJHEHHOHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool? CBABGHKFHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool PGOMLFIBFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool HFDEKDONKOE;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KIPALHHKJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D886D0", Offset = "0x6D87AD0", VA = "0x186D886D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool KDAIIKKGCCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D886B0", Offset = "0x6D87AB0", VA = "0x186D886B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool LCAPOHFIOHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x16A95F0", Offset = "0x16A89F0", VA = "0x1816A95F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6D888C0", Offset = "0x6D87CC0", VA = "0x186D888C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action PHCMHCBLPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6D88610", Offset = "0x6D87A10", VA = "0x186D88610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6D88820", Offset = "0x6D87C20", VA = "0x186D88820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D88000", Offset = "0x6D87400", VA = "0x186D88000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D88390", Offset = "0x6D87790", VA = "0x186D88390")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D88150", Offset = "0x6D87550", VA = "0x186D88150")]
		public void Hide(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D884E0", Offset = "0x6D878E0", VA = "0x186D884E0")]
		public void Show(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D88430", Offset = "0x6D87830", VA = "0x186D88430")]
		public void Set(object GAOLOMEJCOK, bool LCIIFEAHBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D881E0", Offset = "0x6D875E0", VA = "0x186D881E0")]
		private void LLKDCGNGCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D880A0", Offset = "0x6D874A0", VA = "0x186D880A0")]
		[IteratorStateMachine(typeof(BPKKFJLFNFP))]
		private IEnumerator<LJHFBCJIPCN> BGKHEAEDNEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D88110", Offset = "0x6D87510", VA = "0x186D88110", Slot = "5")]
		public virtual void DoHideOrShow(bool MAGFPELOLAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D88570", Offset = "0x6D87970", VA = "0x186D88570")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12A210", Offset = "0x129610")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int NCLACFIEHCP;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int ODBEFBKDMFE;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int ONOJPFILMMI;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int CICEMCINAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
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
		private Color[] LDCGEDKKCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private float[] PEJMEKIBGBC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic CCHKBHGBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool FBEBOAIONDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> CNNNOBANAFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 IOMMPDGKHKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x406B3F0", Offset = "0x406A7F0", VA = "0x18406B3F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D8CF40", Offset = "0x6D8C340", VA = "0x186D8CF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CC30", Offset = "0x6D8C030", VA = "0x186D8CC30")]
		public void SetRingLayers(IReadOnlyList<RingLayer> GLKGLOCCEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C9F0", Offset = "0x6D8BDF0", VA = "0x186D8C9F0")]
		public bool SetRingLayerColor(int AJPOMNKHCNB, Color FJGGIOBFKGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CB10", Offset = "0x6D8BF10", VA = "0x186D8CB10")]
		public bool SetRingLayerSize(int AJPOMNKHCNB, float JECAINLJFKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C6C0", Offset = "0x6D8BAC0", VA = "0x186D8C6C0", Slot = "12")]
		protected override void EAOAANIEGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C870", Offset = "0x6D8BC70", VA = "0x186D8C870", Slot = "13")]
		protected override void JIPEKMPKNMG(Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C820", Offset = "0x6D8BC20", VA = "0x186D8C820", Slot = "14")]
		protected override void EPLHAIAFGOA(Material JMOIMJGFABM, bool GDHKPCGLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D8CD80", Offset = "0x6D8C180", VA = "0x186D8CD80")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly BICHJJEBBAN EBBJLPFELMC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Sprite POGJNLPDMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Material FIPCCPDGFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Material MNAAHNPCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool BIIEFBAGJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool BIPJLCMJDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool DJMEDFLBAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool DILCLCGFIGI;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic CCHKBHGBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader MLDALHBFICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool MDNPBLOJFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool FBEBOAIONDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform LBPHGIBOBCE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6D8C4F0", Offset = "0x6D8B8F0", VA = "0x186D8C4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect HICOINLJEPH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B8A0", Offset = "0x6D8ACA0", VA = "0x186D8B8A0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite MGLCAICHGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B6D0", Offset = "0x6D8AAD0", VA = "0x186D8B6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B220", Offset = "0x6D8A620", VA = "0x186D8B220", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C1B0", Offset = "0x6D8B5B0", VA = "0x186D8C1B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C4E0", Offset = "0x6D8B8E0", VA = "0x186D8C4E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C360", Offset = "0x6D8B760", VA = "0x186D8C360", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B9D0", Offset = "0x6D8ADD0", VA = "0x186D8B9D0")]
		private void IAPBNCICFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C050", Offset = "0x6D8B450", VA = "0x186D8C050")]
		private void KKFPANDDAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BC90", Offset = "0x6D8B090", VA = "0x186D8BC90")]
		private void KGHNGGNMDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B680", Offset = "0x6D8AA80", VA = "0x186D8B680")]
		private void EGIHIDGJCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D8B410", Offset = "0x6D8A810", VA = "0x186D8B410")]
		protected void BGFLFBAHELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BB50", Offset = "0x6D8AF50", VA = "0x186D8BB50")]
		private void IMNNPEGEBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "12")]
		protected virtual void EAOAANIEGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
		protected virtual void JIPEKMPKNMG(Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "14")]
		protected virtual void EPLHAIAFGOA(Material JMOIMJGFABM, bool GDHKPCGLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BCC0", Offset = "0x6D8B0C0", VA = "0x186D8BCC0")]
		private void KIBAINGABAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KDLEEKEHKOP : HPNEEOLCHHI, HFPBPHLJLIP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CNIAKPFLJLG<GameObject, int> PMHKKLEMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NNPHLAIKNOD<GameObject, int, bool> ACIJIEMJOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AIFAKKEFFHF<bool> KJJMBDHFMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NGPLOGOPKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float PIECDNECGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AIFAKKEFFHF<float> CIPCJCMDNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LNCHJMFHBFC MJICEDNOOKG
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
	void SpawnLoadingPlaceholders(GameObject OCCJOMPABPO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HPLBPNIMMDC Spawn<T>(int GFGCJHIPGPL, IReadOnlyList<T> KJFNAECAHBA, GameObject OCCJOMPABPO);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HPLBPNIMMDC Spawn<T>(int GFGCJHIPGPL, IReadOnlyList<T> KJFNAECAHBA, GameObject PIOGBMDHPGJ, ref Func<int, GameObject> MANLJPDECMK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int NANJAGEOPJI, float FINBBEMBFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BICHJJEBBAN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct BPOEDPMMCOG : IEquatable<BPOEDPMMCOG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Component JNNDIHFHMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Action LJMIAOKCAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly int NHNBHBJOPNF;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component CEBEIACLMHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D86F30", Offset = "0x6D86330", VA = "0x186D86F30")]
		public BPOEDPMMCOG(Component JNNDIHFHMHC, Action LJMIAOKCAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D86EB0", Offset = "0x6D862B0", VA = "0x186D86EB0")]
		public void GFPNCFCIMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D86E90", Offset = "0x6D86290", VA = "0x186D86E90", Slot = "4")]
		public bool Equals(BPOEDPMMCOG LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D86E00", Offset = "0x6D86200", VA = "0x186D86E00", Slot = "0")]
		public override bool Equals(object ICNDEPGFBMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HHDDAGMDDFB : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private LJHFBCJIPCN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BICHJJEBBAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IOrderedEnumerable<BPOEDPMMCOG> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private BPOEDPMMCOG <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public HHDDAGMDDFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D87BB0", Offset = "0x6D86FB0", VA = "0x186D87BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D87FC0", Offset = "0x6D873C0", VA = "0x186D87FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly EAPEBDPHEEL ABMCMJHNAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int IIBLAMAOANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly int KFLBLPDKBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<Component, float> BFCABHEGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<Component, BPOEDPMMCOG> PIMNNJAOOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LinkedList<BPOEDPMMCOG> KIHIBEFEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<BPOEDPMMCOG> PIMMHJIOKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private ODDHCGCOHBO MIEDJLIHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private OHGFADEOGNH GNKNPIAPFJF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private OHGFADEOGNH KBIEGPDLDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D86640", Offset = "0x6D85A40", VA = "0x186D86640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D866B0", Offset = "0x6D85AB0", VA = "0x186D866B0")]
	public BICHJJEBBAN(EAPEBDPHEEL ABMCMJHNAEG, int IIBLAMAOANB = -1, int KFLBLPDKBJB = -1, [Optional] Func<Component, float> BFCABHEGIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D863D0", Offset = "0x6D857D0", VA = "0x186D863D0")]
	public void NFMKJIFLOAC(Component JNNDIHFHMHC, Action NMAOCBMPAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D86120", Offset = "0x6D85520", VA = "0x186D86120")]
	public void CNLGPONPCDB(Component JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D86370", Offset = "0x6D85770", VA = "0x186D86370")]
	public bool EJNFLCFHLCP(Component DDPBEGBOLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D85E90", Offset = "0x6D85290", VA = "0x186D85E90")]
	private void CHCMGKHFNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D860B0", Offset = "0x6D854B0", VA = "0x186D860B0")]
	[IteratorStateMachine(typeof(HHDDAGMDDFB))]
	private IEnumerator<LJHFBCJIPCN> CKBDALDIIKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x125F6C0", Offset = "0x125EAC0", VA = "0x18125F6C0")]
	[CompilerGenerated]
	private void KFLIBLHNAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D862B0", Offset = "0x6D856B0", VA = "0x186D862B0")]
	[CompilerGenerated]
	private float DAEIKNJHLPC(BPOEDPMMCOG NMAOCBMPAGO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MCEDNDPBIBP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DGJMEIDKAHA GPJOIHIAJII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BPNAJIOEPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AIFAKKEFFHF<DGJMEIDKAHA> HINDAGLJGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEPHAGGHDLH(DGJMEIDKAHA JGCGCCILPKG, bool JLBMHCPBCLD = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6D8B110", Offset = "0x6D8A510", VA = "0x186D8B110")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6D8B170", Offset = "0x6D8A570", VA = "0x186D8B170")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6D8B0C0", Offset = "0x6D8A4C0", VA = "0x186D8B0C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D8AEB0", Offset = "0x6D8A2B0", VA = "0x186D8AEB0")]
			public void JCLHBBKBOKK(PointerEventData KELKAFEFDGJ, RectTransform LBPHGIBOBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D8AC40", Offset = "0x6D8A040", VA = "0x186D8AC40")]
			public void FMNKNCAKMKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D8AD60", Offset = "0x6D8A160", VA = "0x186D8AD60")]
			public void GIFDFDKDPJO(PointerEventData KELKAFEFDGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D8AE60", Offset = "0x6D8A260", VA = "0x186D8AE60")]
			public void GIIGLFKEMCK(float PLMHEINACII, RectTransform LBPHGIBOBCE, Vector3 KLNBLJCMMCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly AIFAKKEFFHF<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly AIFAKKEFFHF<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly AIFAKKEFFHF<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly AIFAKKEFFHF<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly AIFAKKEFFHF<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly LNCHJMFHBFC PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly UIHandleEventData ALKMJBNKHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool CJJBLINMNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool LNKJLCFLOOI;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool PLJNKFKNKMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xC7DAE0", Offset = "0xC7CEE0", VA = "0x180C7DAE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A330", Offset = "0x6D89730", VA = "0x186D8A330")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool KKDPHIDHGGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD35DE0", Offset = "0xD351E0", VA = "0x180D35DE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A360", Offset = "0x6D89760", VA = "0x186D8A360")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A2A0", Offset = "0x6D896A0", VA = "0x186D8A2A0")]
		private bool CKEELCLFNFJ(PointerEventData AOEFPPFHJJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A940", Offset = "0x6D89D40", VA = "0x186D8A940", Slot = "5")]
		public void OnPointerDown(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AA00", Offset = "0x6D89E00", VA = "0x186D8AA00", Slot = "11")]
		public void OnPointerUp(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A6A0", Offset = "0x6D89AA0", VA = "0x186D8A6A0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A390", Offset = "0x6D89790", VA = "0x186D8A390", Slot = "7")]
		public void OnBeginDrag(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A4C0", Offset = "0x6D898C0", VA = "0x186D8A4C0", Slot = "4")]
		public void OnDrag(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A5B0", Offset = "0x6D899B0", VA = "0x186D8A5B0", Slot = "8")]
		public void OnEndDrag(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A9A0", Offset = "0x6D89DA0", VA = "0x186D8A9A0", Slot = "9")]
		public void OnPointerEnter(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A9D0", Offset = "0x6D89DD0", VA = "0x186D8A9D0", Slot = "10")]
		public void OnPointerExit(PointerEventData AOEFPPFHJJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A480", Offset = "0x6D89880", VA = "0x186D8A480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AA60", Offset = "0x6D89E60", VA = "0x186D8AA60")]
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
