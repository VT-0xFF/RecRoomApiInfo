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
		public enum MHFCDDNLCMO : byte
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
		private static readonly int NJPIJBKPIAD;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<MHFCDDNLCMO, string> MKNCODBKEOJ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int LJPCFCFKIHP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int AEFHLBFFLMG;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int MNMJEGMKLBJ;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int PBGDIANINHP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int MFJNNFPIFLP;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int OLBGELMAHDC;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int JPHHFMDPMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool FEGAHMBACIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KLLLLICJDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] IJHBJEMGNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private MHFCDDNLCMO type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly MHFCDDNLCMO[] JJBCDNNMJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[ECENODKCJDH("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly MHFCDDNLCMO[] EFEKHFJOIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[ECENODKCJDH("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[ECENODKCJDH("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[ECENODKCJDH("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic NMHKJDCJBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool BEIDBAIPPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient PGJNBJBOFGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7054E90", Offset = "0x7053490", VA = "0x187054E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MHFCDDNLCMO KBBBDODNMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9440C0", Offset = "0x9426C0", VA = "0x1809440C0")]
			get
			{
				return default(MHFCDDNLCMO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7055010", Offset = "0x7053610", VA = "0x187055010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool BCKPGDIILOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7053F30", Offset = "0x7052530", VA = "0x187053F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 NAHDNNJKKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7054E00", Offset = "0x7053400", VA = "0x187054E00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7054E40", Offset = "0x7053440", VA = "0x187054E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool EGMEPCLFCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7054000", Offset = "0x7052600", VA = "0x187054000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 JGDGLINFJAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7054E20", Offset = "0x7053420", VA = "0x187054E20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7054FC0", Offset = "0x70535C0", VA = "0x187054FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float NDJHKAGFDOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xE1B010", Offset = "0xE19610", VA = "0x180E1B010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF00D0", Offset = "0x1CEE6D0", VA = "0x181CF00D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 ONOOHKJPNNF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7053FB0", Offset = "0x70525B0", VA = "0x187053FB0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 DEHDFHHBJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7054780", Offset = "0x7052D80", VA = "0x187054780")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float HFAPNJIOGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE0D100", Offset = "0xE0B700", VA = "0x180E0D100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7055020", Offset = "0x7053620", VA = "0x187055020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7053DB0", Offset = "0x70523B0", VA = "0x187053DB0", Slot = "12")]
		protected override void CGCNNPJPCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70547F0", Offset = "0x7052DF0", VA = "0x1870547F0")]
		private void NBPDLBLDIEN(Color[] ACJJEGCCOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7054080", Offset = "0x7052680", VA = "0x187054080", Slot = "13")]
		protected override void MOBAFJJIBHB(Material GMIIJPABJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7053B90", Offset = "0x7052190", VA = "0x187053B90", Slot = "14")]
		protected override void AABJNPAFMEL(Material GMIIJPABJKD, bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7054D40", Offset = "0x7053340", VA = "0x187054D40")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData GEBHMOMLBNB;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7051760", Offset = "0x704FD60", VA = "0x187051760", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7051650", Offset = "0x704FC50", VA = "0x187051650", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7051590", Offset = "0x704FB90", VA = "0x187051590")]
		private void GPDDOIALMOP(GameObject JDMGLMDDIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7051950", Offset = "0x704FF50", VA = "0x187051950")]
		public void SetOptionsWithNoDefault(List<string> BCDJFNKOFCL, [Optional] string KJCCHNEBCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7051B90", Offset = "0x7050190", VA = "0x187051B90")]
		public void SetOptionsWithNoDefault(List<OptionData> FAJHLKMLAGA, [Optional] string KJCCHNEBCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7051870", Offset = "0x704FE70", VA = "0x187051870", Slot = "42")]
		public override void OnPointerClick(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x921950", Offset = "0x91FF50", VA = "0x180921950", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas GECPDANBHOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7051C80", Offset = "0x7050280", VA = "0x187051C80")]
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
		public enum JOIFOFKIEJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int MICKPBGJABG;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int LCGINBFIGGL;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int INCEIPKBMEI;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int NNKLALFJLOO;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int LCJBCNOPDPK;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int AIEBCCCOKHB;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int OLPKFIEFKEO;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int BECMHGPGNGF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int ECBENAMHIFK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int KAJJKGFCIIF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int JBJMEMCDHOJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int AIMOMJCDFHO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int KANFCNFOADN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int FFONKGJANNC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int KPBLHMGAHAE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int EOLMNHDAPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
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
		private JOIFOFKIEJD animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ECENODKCJDH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ECENODKCJDH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic NMHKJDCJBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool MBLDKMFFANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite OCPGEOLNEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7058AB0", Offset = "0x70570B0", VA = "0x187058AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7058CC0", Offset = "0x70572C0", VA = "0x187058CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color GANDIMMDBMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A4710", Offset = "0x9A2D10", VA = "0x1809A4710")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7058D60", Offset = "0x7057360", VA = "0x187058D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color JGHCIIGKNAN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1038FC0", Offset = "0x10375C0", VA = "0x181038FC0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7058BB0", Offset = "0x70571B0", VA = "0x187058BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float BBDNEMOFIIF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD33410", Offset = "0xD31A10", VA = "0x180D33410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7058C50", Offset = "0x7057250", VA = "0x187058C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 OJPAJNPJOEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD777D0", Offset = "0xD75DD0", VA = "0x180D777D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7058C70", Offset = "0x7057270", VA = "0x187058C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float EAPFBGNMJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xE1B070", Offset = "0xE19670", VA = "0x180E1B070")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7058C10", Offset = "0x7057210", VA = "0x187058C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 MAFOLIAEPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x22F21B0", Offset = "0x22F07B0", VA = "0x1822F21B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7058DC0", Offset = "0x70573C0", VA = "0x187058DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DOKLBAKNBLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1328B10", Offset = "0x1327110", VA = "0x181328B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7058B80", Offset = "0x7057180", VA = "0x187058B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 OOLJLLBBLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70586C0", Offset = "0x7056CC0", VA = "0x1870586C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JOIFOFKIEJD KILLBFKPCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x99B680", Offset = "0x999C80", VA = "0x18099B680")]
			get
			{
				return default(JOIFOFKIEJD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7058BA0", Offset = "0x70571A0", VA = "0x187058BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float OJIFNCPDGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D6910", VA = "0x1813D8310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7058C30", Offset = "0x7057230", VA = "0x187058C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float HALEGAMNBDK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD77760", Offset = "0xD75D60", VA = "0x180D77760")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7058B60", Offset = "0x7057160", VA = "0x187058B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7058000", Offset = "0x7056600", VA = "0x187058000", Slot = "13")]
		protected override void MOBAFJJIBHB(Material GMIIJPABJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7057D80", Offset = "0x7056380", VA = "0x187057D80")]
		private void JFIIAFEAOCG(Sprite DCCBHABPLCA, out Vector2 IMOHHJCGDEE, out Vector2 PMLMGDANCGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7057D30", Offset = "0x7056330", VA = "0x187057D30", Slot = "14")]
		protected override void AABJNPAFMEL(Material GMIIJPABJKD, bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7058A10", Offset = "0x7057010", VA = "0x187058A10")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader LHOONKGKEBE;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader JBOPOFHFGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7058E70", Offset = "0x7057470", VA = "0x187058E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7058E10", Offset = "0x7057410", VA = "0x187058E10")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool FHNEFGAGPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x954BA0", Offset = "0x9531A0", VA = "0x180954BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> MGLGGOCJPLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7052C60", Offset = "0x7051260", VA = "0x187052C60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7052DA0", Offset = "0x70513A0", VA = "0x187052DA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KEFDBCHCEPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7052D00", Offset = "0x7051300", VA = "0x187052D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7052E40", Offset = "0x7051440", VA = "0x187052E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7052BA0", Offset = "0x70511A0", VA = "0x187052BA0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7052C00", Offset = "0x7051200", VA = "0x187052C00", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x170FF10", Offset = "0x170E510", VA = "0x18170FF10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x170FF10", Offset = "0x170E510", VA = "0x18170FF10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FCOHIKNEOJB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DLBAFLLHKHA
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const DLBAFLLHKHA DDFMNBIHHEN = DLBAFLLHKHA.Light;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const string OHNJHLNKCGM = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static LCECFIIKLCN CFODCIKGFIP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static LCECFIIKLCN OHDJGKMMBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7051CF0", Offset = "0x70502F0", VA = "0x187051CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static DLBAFLLHKHA KCEIAMCDMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7051F20", Offset = "0x7050520", VA = "0x187051F20")]
		get
		{
			return default(DLBAFLLHKHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7051DC0", Offset = "0x70503C0", VA = "0x187051DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<DLBAFLLHKHA> GDEGLKBNIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70520F0", Offset = "0x70506F0", VA = "0x1870520F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7052030", Offset = "0x7050630", VA = "0x187052030")]
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
		private sealed class IKOAMGIMILH : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private NGCINEPJDAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public IKOAMGIMILH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7053330", Offset = "0x7051930", VA = "0x187053330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7053900", Offset = "0x7051F00", VA = "0x187053900", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[HHJACFLANNE(ODACEGFBLCL.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly HMOFDMCMMHE CDEIHCEPNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KADALHLCFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3? ANNMLLDDDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool? FHKNOFFIJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool? DPIKAFMEPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool MMPNPDCMMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool LNHCKLILFIL;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool PINLHFOFEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7052880", Offset = "0x7050E80", VA = "0x187052880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool MEDBCKCPOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7052860", Offset = "0x7050E60", VA = "0x187052860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool LBCEEMPGKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x14F64C0", Offset = "0x14F4AC0", VA = "0x1814F64C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7052A70", Offset = "0x7051070", VA = "0x187052A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DGDLJOAHKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x70527C0", Offset = "0x7050DC0", VA = "0x1870527C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70529D0", Offset = "0x7050FD0", VA = "0x1870529D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x70521B0", Offset = "0x70507B0", VA = "0x1870521B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7052540", Offset = "0x7050B40", VA = "0x187052540")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7052440", Offset = "0x7050A40", VA = "0x187052440")]
		public void Hide(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7052690", Offset = "0x7050C90", VA = "0x187052690")]
		public void Show(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70525E0", Offset = "0x7050BE0", VA = "0x1870525E0")]
		public void Set(object LODBJLOKBLP, bool FJNOJBGPCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7052290", Offset = "0x7050890", VA = "0x187052290")]
		private void HAKAOAFEAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70524D0", Offset = "0x7050AD0", VA = "0x1870524D0")]
		[IteratorStateMachine(typeof(IKOAMGIMILH))]
		private IEnumerator<NGCINEPJDAB> MBOHDJHHKDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7052250", Offset = "0x7050850", VA = "0x187052250", Slot = "5")]
		public virtual void DoHideOrShow(bool DAHKGEJGJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7052720", Offset = "0x7050D20", VA = "0x187052720")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x135170", Offset = "0x134570")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int OAPNMGCFFJC;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int CLIMCIADIID;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly int JPEHBHBHLEK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int MDEFHEJCGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
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
		private Color[] IJHBJEMGNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private float[] LLDJDLALMKA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic NMHKJDCJBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool MBLDKMFFANE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> MNGOIMFNKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 NAHDNNJKKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4224560", Offset = "0x4222B60", VA = "0x184224560")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7057CE0", Offset = "0x70562E0", VA = "0x187057CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70579D0", Offset = "0x7055FD0", VA = "0x1870579D0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> EAGHDILLMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7057790", Offset = "0x7055D90", VA = "0x187057790")]
		public bool SetRingLayerColor(int FKOBHPAJHOO, Color OOJLGEBJDPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70578B0", Offset = "0x7055EB0", VA = "0x1870578B0")]
		public bool SetRingLayerSize(int FKOBHPAJHOO, float BMEHIBKNEIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x70574B0", Offset = "0x7055AB0", VA = "0x1870574B0", Slot = "12")]
		protected override void CGCNNPJPCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7057610", Offset = "0x7055C10", VA = "0x187057610", Slot = "13")]
		protected override void MOBAFJJIBHB(Material GMIIJPABJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7057460", Offset = "0x7055A60", VA = "0x187057460", Slot = "14")]
		protected override void AABJNPAFMEL(Material GMIIJPABJKD, bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7057B20", Offset = "0x7056120", VA = "0x187057B20")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly DCLAFCLHCHF MMOMCHDAKCH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static Sprite BBMCLJFBKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material ACBBNANNCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Material LBNLJCMDIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool FJLKEDHGJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool KADALHLCFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool EHHEBOOMEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool JNMEMAICILE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic NMHKJDCJBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader JBOPOFHFGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool BEIDBAIPPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool MBLDKMFFANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform MPCDLOMLODD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7056F00", Offset = "0x7055500", VA = "0x187056F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect NPCCCNHNJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7056B30", Offset = "0x7055130", VA = "0x187056B30")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite MAHHIGPJDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7056960", Offset = "0x7054F60", VA = "0x187056960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7055FC0", Offset = "0x70545C0", VA = "0x187055FC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7056F60", Offset = "0x7055560", VA = "0x187056F60", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7057290", Offset = "0x7055890", VA = "0x187057290", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7057110", Offset = "0x7055710", VA = "0x187057110", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7056540", Offset = "0x7054B40", VA = "0x187056540")]
		private void DFNGEFEGIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7056C60", Offset = "0x7055260", VA = "0x187056C60")]
		private void JAHLIPIFLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x70566C0", Offset = "0x7054CC0", VA = "0x1870566C0")]
		private void EBFABIIAPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x70572A0", Offset = "0x70558A0", VA = "0x1870572A0")]
		private void PFCBHHFECJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x70566F0", Offset = "0x7054CF0", VA = "0x1870566F0")]
		protected void FONLCEHNJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7056DC0", Offset = "0x70553C0", VA = "0x187056DC0")]
		private void JHJMJMMOGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "12")]
		protected virtual void CGCNNPJPCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "13")]
		protected virtual void MOBAFJJIBHB(Material GMIIJPABJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "14")]
		protected virtual void AABJNPAFMEL(Material GMIIJPABJKD, bool OGJCOIOGMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70561B0", Offset = "0x70547B0", VA = "0x1870561B0")]
		private void BBIBKDHEKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		[Conditional("RRUI_PROFILING")]
		protected void KFLAKLEIIPG(string PLKIEMDKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		[Conditional("RRUI_PROFILING")]
		protected void FKJIPMKHEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FNPHGGIIDBJ : MJOIDDNMKKB, ANMOOBNJIJN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MKGJAENGAJB<GameObject, int> GBDEOLFHNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LJCNJFONIBP<GameObject, int, bool> LMDOMMJNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NGNHBGJPOEA<bool> GLHEKEFCFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CDKPCDCNCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float FJMJJDCECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NGNHBGJPOEA<float> MNECJNKPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BOBAGNNLEHP DLBBPCMJFNG
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
	void SpawnLoadingPlaceholders(GameObject NBHNBEHBBFP);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LABEIOOIHEC Spawn<T>(int MPIEMAAEBBL, IReadOnlyList<T> GOMDNNCBLHP, GameObject NBHNBEHBBFP);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LABEIOOIHEC Spawn<T>(int MPIEMAAEBBL, IReadOnlyList<T> GOMDNNCBLHP, GameObject BAHLOJLMKBK, ref Func<int, GameObject> EGDNONJEBBL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DCLAFCLHCHF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct PDILKOIEFMG : IEquatable<PDILKOIEFMG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Component JHAKINLMMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Action LPPLMBODDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int MNHFPAHJMID;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component EOBKJJPNIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7053A70", Offset = "0x7052070", VA = "0x187053A70")]
		public PDILKOIEFMG(Component JHAKINLMMJL, Action LPPLMBODDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x70539F0", Offset = "0x7051FF0", VA = "0x1870539F0")]
		public void INMPCLDOECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x70539D0", Offset = "0x7051FD0", VA = "0x1870539D0", Slot = "4")]
		public bool Equals(PDILKOIEFMG EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7053940", Offset = "0x7051F40", VA = "0x187053940", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class ICDKPCCKFBK : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DCLAFCLHCHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IOrderedEnumerable<PDILKOIEFMG> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private PDILKOIEFMG <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public ICDKPCCKFBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7052EE0", Offset = "0x70514E0", VA = "0x187052EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70532F0", Offset = "0x70518F0", VA = "0x1870532F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int HKJKNIJHEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly int MEGPKOLOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Component, float> FBOGPHKMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Component, PDILKOIEFMG> ANKLHICLEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LinkedList<PDILKOIEFMG> ENDEIDJGLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<PDILKOIEFMG> CFFHCIADFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CJLKEKBECCD LPEBNGDMKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NKGHOAEKEOE JBNPBFENIDK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private NKGHOAEKEOE MNLLGPABNBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7050C70", Offset = "0x704F270", VA = "0x187050C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7051430", Offset = "0x704FA30", VA = "0x187051430")]
	public DCLAFCLHCHF(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, int HKJKNIJHEOC = -1, int MEGPKOLOIBJ = -1, [Optional] Func<Component, float> FBOGPHKMLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7050D50", Offset = "0x704F350", VA = "0x187050D50")]
	public void FALJLCJJGGN(Component JHAKINLMMJL, Action IDHOKMNCGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7050FC0", Offset = "0x704F5C0", VA = "0x187050FC0")]
	public void GKKIDKBHFOG(Component JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7050C10", Offset = "0x704F210", VA = "0x187050C10")]
	public bool BJHFNOCMJKA(Component AEKHFLGBLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7051150", Offset = "0x704F750", VA = "0x187051150")]
	private void JCJNAKOIIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7050CE0", Offset = "0x704F2E0", VA = "0x187050CE0")]
	[IteratorStateMachine(typeof(ICDKPCCKFBK))]
	private IEnumerator<NGCINEPJDAB> DKCAHAFEOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x18F6AD0", Offset = "0x18F50D0", VA = "0x1818F6AD0")]
	[CompilerGenerated]
	private void IBKGBJIGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7051370", Offset = "0x704F970", VA = "0x187051370")]
	[CompilerGenerated]
	private float KCMGPGFBHGA(PDILKOIEFMG IDHOKMNCGAF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KHODKGLGEFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GIIHJLDIIFP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OMBINGKHBBD KMLFEAHPLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KCLPKOPANIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NGNHBGJPOEA<OMBINGKHBBD> JDNMLIOHEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IODJJEKDNOO(OMBINGKHBBD LICMFPPEGMC, bool MGIDABHNPKF = false);
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
				[Cpp2IlInjected.Address(RVA = "0x7055EB0", Offset = "0x70544B0", VA = "0x187055EB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x7055F10", Offset = "0x7054510", VA = "0x187055F10")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x7055E60", Offset = "0x7054460", VA = "0x187055E60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7055C50", Offset = "0x7054250", VA = "0x187055C50")]
			public void KNBIKAGCECA(PointerEventData BBDJOHGLIDD, RectTransform MPCDLOMLODD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x70559E0", Offset = "0x7053FE0", VA = "0x1870559E0")]
			public void FNJNLPDBDBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7055B50", Offset = "0x7054150", VA = "0x187055B50")]
			public void IPOBJOPPFAE(PointerEventData BBDJOHGLIDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7055B00", Offset = "0x7054100", VA = "0x187055B00")]
			public void HAPGPPFDDBJ(float GLLIJJBACBI, RectTransform MPCDLOMLODD, Vector3 FFBPBBJMKKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly NGNHBGJPOEA<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly NGNHBGJPOEA<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly NGNHBGJPOEA<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly NGNHBGJPOEA<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly NGNHBGJPOEA<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly BOBAGNNLEHP PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly UIHandleEventData NJCBMCEMGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool LDNIBLFOMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool OABPDOBJKBM;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool EHOLAHPNJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA09E70", Offset = "0xA08470", VA = "0x180A09E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7055040", Offset = "0x7053640", VA = "0x187055040")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BGJMMHIEPHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xE57590", Offset = "0xE55B90", VA = "0x180E57590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7055100", Offset = "0x7053700", VA = "0x187055100")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7055070", Offset = "0x7053670", VA = "0x187055070")]
		private bool MNABKGEDBAK(PointerEventData OHLDPOJHAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70556E0", Offset = "0x7053CE0", VA = "0x1870556E0", Slot = "5")]
		public void OnPointerDown(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70557A0", Offset = "0x7053DA0", VA = "0x1870557A0", Slot = "11")]
		public void OnPointerUp(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7055440", Offset = "0x7053A40", VA = "0x187055440", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7055130", Offset = "0x7053730", VA = "0x187055130", Slot = "7")]
		public void OnBeginDrag(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7055260", Offset = "0x7053860", VA = "0x187055260", Slot = "4")]
		public void OnDrag(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7055350", Offset = "0x7053950", VA = "0x187055350", Slot = "8")]
		public void OnEndDrag(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7055740", Offset = "0x7053D40", VA = "0x187055740", Slot = "9")]
		public void OnPointerEnter(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7055770", Offset = "0x7053D70", VA = "0x187055770", Slot = "10")]
		public void OnPointerExit(PointerEventData OHLDPOJHAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7055220", Offset = "0x7053820", VA = "0x187055220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7055800", Offset = "0x7053E00", VA = "0x187055800")]
		public UIHandleDecorator()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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
