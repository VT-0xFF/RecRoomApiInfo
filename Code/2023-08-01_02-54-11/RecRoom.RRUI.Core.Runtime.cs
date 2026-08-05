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
		public enum AOFILLJAMLI : byte
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
		private static readonly int JBPAFMOKHDE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<AOFILLJAMLI, string> DONLDKBONPE;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int NPGJDHNNLEH = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int LGJPBMCEGOI;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int OHKJMIFKAJB;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int EOILMLALMIK;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int IFCKIFAOJHM;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int NLEBKGDPFIE;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int BDEGJFHLFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool GNOCBPFPAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KEKDLPOPIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] BKIKGDGDBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private AOFILLJAMLI type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly AOFILLJAMLI[] DPDFOBJIOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[DFFLAPBPAEA("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly AOFILLJAMLI[] GGELGFANEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[DFFLAPBPAEA("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[DFFLAPBPAEA("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[DFFLAPBPAEA("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic KAOFHCDJOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MLNIEEDBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient JBAOLBIFGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x70B5270", Offset = "0x70B4270", VA = "0x1870B5270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AOFILLJAMLI FHOHNKIJHHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB9A5E0", Offset = "0xB995E0", VA = "0x180B9A5E0")]
			get
			{
				return default(AOFILLJAMLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x70B53F0", Offset = "0x70B43F0", VA = "0x1870B53F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool GPPABHHACPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x70B4CC0", Offset = "0x70B3CC0", VA = "0x1870B4CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 LCFMPDGOPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x70B51E0", Offset = "0x70B41E0", VA = "0x1870B51E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x70B5220", Offset = "0x70B4220", VA = "0x1870B5220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool IJJMOILDKHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x70B3F70", Offset = "0x70B2F70", VA = "0x1870B3F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 ABGNGMBGNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x70B5200", Offset = "0x70B4200", VA = "0x1870B5200")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x70B53A0", Offset = "0x70B43A0", VA = "0x1870B53A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float ICAPPAOJNKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1411B40", Offset = "0x1410B40", VA = "0x181411B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x19B4AE0", Offset = "0x19B3AE0", VA = "0x1819B4AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 JBICICNPDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x70B3FF0", Offset = "0x70B2FF0", VA = "0x1870B3FF0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 AHAPGGLLLLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x70B4040", Offset = "0x70B3040", VA = "0x1870B4040")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float PGBJIMFHNIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDE7B50", Offset = "0xDE6B50", VA = "0x180DE7B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x70B5400", Offset = "0x70B4400", VA = "0x1870B5400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70B4440", Offset = "0x70B3440", VA = "0x1870B4440", Slot = "12")]
		protected override void IDCPFFLHJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70B40B0", Offset = "0x70B30B0", VA = "0x1870B40B0")]
		private void IAGNBLOGBLA(Color[] PNMJBCODCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70B45C0", Offset = "0x70B35C0", VA = "0x1870B45C0", Slot = "13")]
		protected override void LPMECMABDJG(Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70B4220", Offset = "0x70B3220", VA = "0x1870B4220", Slot = "14")]
		protected override void IBJACDONLFK(Material AKEPBJIDOFF, bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70B5120", Offset = "0x70B4120", VA = "0x1870B5120")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData EKHAMFMFCKA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70B2BF0", Offset = "0x70B1BF0", VA = "0x1870B2BF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70B2AE0", Offset = "0x70B1AE0", VA = "0x1870B2AE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70B2A20", Offset = "0x70B1A20", VA = "0x1870B2A20")]
		private void MMKIKGKCIBB(GameObject BGGGGNJDFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70B2DE0", Offset = "0x70B1DE0", VA = "0x1870B2DE0")]
		public void SetOptionsWithNoDefault(List<string> JIBLOMPBADG, [Optional] string OKCNEKCOAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70B3020", Offset = "0x70B2020", VA = "0x1870B3020")]
		public void SetOptionsWithNoDefault(List<OptionData> AJCLOJJJGCM, [Optional] string OKCNEKCOAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70B2D00", Offset = "0x70B1D00", VA = "0x1870B2D00", Slot = "42")]
		public override void OnPointerClick(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84F100", Offset = "0x84E100", VA = "0x18084F100", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas LJJENLFOKEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70B3110", Offset = "0x70B2110", VA = "0x1870B3110")]
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
		public enum GBBJADIOBOP
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int DPCODPBACEI;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int OOBFPJOFHNJ;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int CKBJHLPIDON;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int OEAOBIJCCDD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int OCHOCGHNPNE;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int EPHMEEGAHMF;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int KENODHBHPMB;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int KOJBMEBNFIL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int OLNBAPNMKJP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int KPNMGCKKBGP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int BFLNDILKKKH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NIJJJLKJGLN;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PJEHDEKACOG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int DDHNMMEEELB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AFCHMFHHPAI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int PCKAOCAPHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
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
		private GBBJADIOBOP animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[DFFLAPBPAEA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[DFFLAPBPAEA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic KAOFHCDJOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool KFBCOLKBNEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite OFCLOFFPJEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x70B8E90", Offset = "0x70B7E90", VA = "0x1870B8E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x70B90A0", Offset = "0x70B80A0", VA = "0x1870B90A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color OBGLNAGHLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A6600", Offset = "0x9A5600", VA = "0x1809A6600")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70B9140", Offset = "0x70B8140", VA = "0x1870B9140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color BLLOEMHLEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x94AC40", Offset = "0x949C40", VA = "0x18094AC40")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x70B8F90", Offset = "0x70B7F90", VA = "0x1870B8F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float AMLMJLGOCPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xB86740", Offset = "0xB85740", VA = "0x180B86740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x70B9030", Offset = "0x70B8030", VA = "0x1870B9030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 LPPPHMONIMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF9FDF0", Offset = "0xF9EDF0", VA = "0x180F9FDF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x70B9050", Offset = "0x70B8050", VA = "0x1870B9050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JGOONMMKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1411BA0", Offset = "0x1410BA0", VA = "0x181411BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x70B8FF0", Offset = "0x70B7FF0", VA = "0x1870B8FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 BEJEGHEOCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x236D4D0", Offset = "0x236C4D0", VA = "0x18236D4D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x70B91A0", Offset = "0x70B81A0", VA = "0x1870B91A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DCPHELNNJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x14DD410", Offset = "0x14DC410", VA = "0x1814DD410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x70B8F60", Offset = "0x70B7F60", VA = "0x1870B8F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 OHJLDEPPAGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70B83E0", Offset = "0x70B73E0", VA = "0x1870B83E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GBBJADIOBOP BCGHFDDAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x99D290", Offset = "0x99C290", VA = "0x18099D290")]
			get
			{
				return default(GBBJADIOBOP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x70B8F80", Offset = "0x70B7F80", VA = "0x1870B8F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DAMGEMDLDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9CA820", Offset = "0x9C9820", VA = "0x1809CA820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x70B9010", Offset = "0x70B8010", VA = "0x1870B9010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float JGEBMFNKIEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF9FD90", Offset = "0xF9ED90", VA = "0x180F9FD90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x70B8F40", Offset = "0x70B7F40", VA = "0x1870B8F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70B8450", Offset = "0x70B7450", VA = "0x1870B8450", Slot = "13")]
		protected override void LPMECMABDJG(Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70B8110", Offset = "0x70B7110", VA = "0x1870B8110")]
		private void APOLGJPDEHP(Sprite KHDIDNLEFOP, out Vector2 ICMDNEDCGCL, out Vector2 DLKOHENACBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70B8390", Offset = "0x70B7390", VA = "0x1870B8390", Slot = "14")]
		protected override void IBJACDONLFK(Material AKEPBJIDOFF, bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70B8DF0", Offset = "0x70B7DF0", VA = "0x1870B8DF0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader MHAKMAEGAAG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader PLNDKHJEFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x70B9250", Offset = "0x70B8250", VA = "0x1870B9250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70B91F0", Offset = "0x70B81F0", VA = "0x1870B91F0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool EFINOMCGCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x979400", Offset = "0x978400", VA = "0x180979400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB674B0", Offset = "0xB664B0", VA = "0x180B674B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> HIJMNNOFDEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x70B3C30", Offset = "0x70B2C30", VA = "0x1870B3C30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x70B3D70", Offset = "0x70B2D70", VA = "0x1870B3D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OHEEEOHHLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x70B3CD0", Offset = "0x70B2CD0", VA = "0x1870B3CD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x70B3E10", Offset = "0x70B2E10", VA = "0x1870B3E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70B3B70", Offset = "0x70B2B70", VA = "0x1870B3B70", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x70B3BD0", Offset = "0x70B2BD0", VA = "0x1870B3BD0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x269A490", Offset = "0x2699490", VA = "0x18269A490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x269A490", Offset = "0x2699490", VA = "0x18269A490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ALLDMOLDJKE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LKAFECCEKJH
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const LKAFECCEKJH MFGHIABHBKO = LKAFECCEKJH.Light;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const string FJEMNKAMDGN = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static CDNJAGBMOFC NOOEENBIHFB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static CDNJAGBMOFC HFJJKELOOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70B1320", Offset = "0x70B0320", VA = "0x1870B1320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static LKAFECCEKJH KBPIAFGMHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70B10B0", Offset = "0x70B00B0", VA = "0x1870B10B0")]
		get
		{
			return default(LKAFECCEKJH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70B11C0", Offset = "0x70B01C0", VA = "0x1870B11C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<LKAFECCEKJH> APMIDGLHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70B13F0", Offset = "0x70B03F0", VA = "0x1870B13F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70B0FF0", Offset = "0x70AFFF0", VA = "0x1870B0FF0")]
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
		private sealed class BHCECGLHLEM : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public BHCECGLHLEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70B14B0", Offset = "0x70B04B0", VA = "0x1870B14B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x70B1A80", Offset = "0x70B0A80", VA = "0x1870B1A80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly OEMFJNEEEFM JLDAEENDOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool LJMLMEGEIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3? BHJJGIAGPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool? CABIBLDPHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool? LMLDEECLADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool EMLAHGGNGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool CGMALAPJKLA;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool NOBFNFHHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x70B3850", Offset = "0x70B2850", VA = "0x1870B3850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool POBPJNDOGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x70B3830", Offset = "0x70B2830", VA = "0x1870B3830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DFMPKGADENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1443620", Offset = "0x1442620", VA = "0x181443620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x70B3A40", Offset = "0x70B2A40", VA = "0x1870B3A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action NOKBFPANPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x70B3790", Offset = "0x70B2790", VA = "0x1870B3790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70B39A0", Offset = "0x70B29A0", VA = "0x1870B39A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x70B3180", Offset = "0x70B2180", VA = "0x1870B3180")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70B3510", Offset = "0x70B2510", VA = "0x1870B3510")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70B32D0", Offset = "0x70B22D0", VA = "0x1870B32D0")]
		public void Hide(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70B3660", Offset = "0x70B2660", VA = "0x1870B3660")]
		public void Show(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70B35B0", Offset = "0x70B25B0", VA = "0x1870B35B0")]
		public void Set(object DMHDKAFNNAC, bool LPKMOFEMPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70B3360", Offset = "0x70B2360", VA = "0x1870B3360")]
		private void NGIKLFMFGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70B3220", Offset = "0x70B2220", VA = "0x1870B3220")]
		[IteratorStateMachine(typeof(BHCECGLHLEM))]
		private IEnumerator<KNGCLBDEHMD> CCBPPHNOFMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70B3290", Offset = "0x70B2290", VA = "0x1870B3290", Slot = "5")]
		public virtual void DoHideOrShow(bool DPLKNKGNPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70B36F0", Offset = "0x70B26F0", VA = "0x1870B36F0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x168ED0", Offset = "0x1682D0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int PNANDAOKFGK;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int IKPHAFMNGIH;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly int NDAPBAIDNMO;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int CFGNODBCIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
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
		private Color[] BKIKGDGDBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private float[] IKBBBOPBODO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic KAOFHCDJOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool KFBCOLKBNEP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> FGLKJBIMNMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 LCFMPDGOPME
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4257710", Offset = "0x4256710", VA = "0x184257710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x70B80C0", Offset = "0x70B70C0", VA = "0x1870B80C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70B7DB0", Offset = "0x70B6DB0", VA = "0x1870B7DB0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> BDNAAPPBJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x70B7B70", Offset = "0x70B6B70", VA = "0x1870B7B70")]
		public bool SetRingLayerColor(int GKDLOONMDIA, Color OAIMCLIJEAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70B7C90", Offset = "0x70B6C90", VA = "0x1870B7C90")]
		public bool SetRingLayerSize(int GKDLOONMDIA, float GFFJJOEGODF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x70B7890", Offset = "0x70B6890", VA = "0x1870B7890", Slot = "12")]
		protected override void IDCPFFLHJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x70B79F0", Offset = "0x70B69F0", VA = "0x1870B79F0", Slot = "13")]
		protected override void LPMECMABDJG(Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x70B7840", Offset = "0x70B6840", VA = "0x1870B7840", Slot = "14")]
		protected override void IBJACDONLFK(Material AKEPBJIDOFF, bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70B7F00", Offset = "0x70B6F00", VA = "0x1870B7F00")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly DHDNINHNMPD LIOEAGAHFKF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static Sprite NCCHKCPFIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material NHCBNAGIKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Material HNCIJNEILNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool JKDKBBHINOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool LJMLMEGEIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool PFHCOPCDLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool CJLFOOKGDOO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic KAOFHCDJOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader PLNDKHJEFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool MLNIEEDBIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool KFBCOLKBNEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform IHPCEECHCPB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x70B6EA0", Offset = "0x70B5EA0", VA = "0x1870B6EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect FFIBCONFEID
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x70B6C10", Offset = "0x70B5C10", VA = "0x1870B6C10")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite EHLKOOOMHLD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x70B71C0", Offset = "0x70B61C0", VA = "0x1870B71C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x70B6760", Offset = "0x70B5760", VA = "0x1870B6760", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x70B7390", Offset = "0x70B6390", VA = "0x1870B7390", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x70B76C0", Offset = "0x70B66C0", VA = "0x1870B76C0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70B7540", Offset = "0x70B6540", VA = "0x1870B7540", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70B7040", Offset = "0x70B6040", VA = "0x1870B7040")]
		private void MGHCAEKHDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70B6D40", Offset = "0x70B5D40", VA = "0x1870B6D40")]
		private void JGHMEDBBBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x70B6730", Offset = "0x70B5730", VA = "0x1870B6730")]
		private void AMDIPDDHJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x70B6BC0", Offset = "0x70B5BC0", VA = "0x1870B6BC0")]
		private void BLFBILDKDNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x70B6950", Offset = "0x70B5950", VA = "0x1870B6950")]
		protected void BIKGHOOOFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70B6F00", Offset = "0x70B5F00", VA = "0x1870B6F00")]
		private void MDBHDEMPKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "12")]
		protected virtual void IDCPFFLHJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "13")]
		protected virtual void LPMECMABDJG(Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "14")]
		protected virtual void IBJACDONLFK(Material AKEPBJIDOFF, bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70B63A0", Offset = "0x70B53A0", VA = "0x1870B63A0")]
		private void ADANDLPIGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		[Conditional("RRUI_PROFILING")]
		protected void KHDEHINMKKP(string LJDDKLAKIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		[Conditional("RRUI_PROFILING")]
		protected void FCGFJFFLKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x966250", Offset = "0x965250", VA = "0x180966250")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OLHPBCHCIFK : BHBKHINOHCK, GIMJCOFNCKF, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EBFLMNLPKOJ<GameObject, int> DGNNDPGKPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IAEDOANCKIC<GameObject, int, bool> AHEPDKOIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OIDLICKKMBF<bool> PIPICDJJCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool JEPKEHOMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float HGEMFDEADNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OIDLICKKMBF<float> IHMFCKHALPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MONMJFCKPLO NAEHNNMGPIC
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
	void SpawnLoadingPlaceholders(GameObject CNMMOEIHJMA);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BFCCHDPGONK Spawn<T>(int KIOBMDNFABD, IReadOnlyList<T> HCKNMLENIIG, GameObject CNMMOEIHJMA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BFCCHDPGONK Spawn<T>(int KIOBMDNFABD, IReadOnlyList<T> HCKNMLENIIG, GameObject LNKHINBNHGB, ref Func<int, GameObject> CLBACCDINCC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DHDNINHNMPD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct CDFLADOFHBJ : IEquatable<CDFLADOFHBJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Component HBLIBBFCHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Action NCKPNNCFEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int JFCHELDOFDC;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component KCLBBEOMLHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x70B2040", Offset = "0x70B1040", VA = "0x1870B2040")]
		public CDFLADOFHBJ(Component HBLIBBFCHOD, Action NCKPNNCFEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x70B1F10", Offset = "0x70B0F10", VA = "0x1870B1F10")]
		public void DOKLPJBHLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x70B2020", Offset = "0x70B1020", VA = "0x1870B2020", Slot = "4")]
		public bool Equals(CDFLADOFHBJ JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x70B1F90", Offset = "0x70B0F90", VA = "0x1870B1F90", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BJEEEICAEGG : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DHDNINHNMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IOrderedEnumerable<CDFLADOFHBJ> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CDFLADOFHBJ <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public BJEEEICAEGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70B1AC0", Offset = "0x70B0AC0", VA = "0x1870B1AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70B1ED0", Offset = "0x70B0ED0", VA = "0x1870B1ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int PJEJEACCAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly int KKOHHKLGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Component, float> DIDEPPALJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Component, CDFLADOFHBJ> OCPOPCNOOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LinkedList<CDFLADOFHBJ> JEOOHLCKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<CDFLADOFHBJ> BNHMEBPAKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HLPOIIAFIGC INNBAHFGABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private BJIJOBOKPBN MKBJEIMOLAJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private BJIJOBOKPBN AJFAIIDLLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x70B2450", Offset = "0x70B1450", VA = "0x1870B2450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x70B28C0", Offset = "0x70B18C0", VA = "0x1870B28C0")]
	public DHDNINHNMPD(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, int PJEJEACCAFM = -1, int KKOHHKLGCOP = -1, [Optional] Func<Component, float> DIDEPPALJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70B2650", Offset = "0x70B1650", VA = "0x1870B2650")]
	public void OCEELJIMKMD(Component HBLIBBFCHOD, Action IBOEOPFBKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70B24C0", Offset = "0x70B14C0", VA = "0x1870B24C0")]
	public void MIFAOHJELPJ(Component HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x70B23F0", Offset = "0x70B13F0", VA = "0x1870B23F0")]
	public bool JBJIOGOPCPP(Component LMOLNJNIDGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x70B2160", Offset = "0x70B1160", VA = "0x1870B2160")]
	private void IEAPJJMACBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70B2380", Offset = "0x70B1380", VA = "0x1870B2380")]
	[IteratorStateMachine(typeof(BJEEEICAEGG))]
	private IEnumerator<KNGCLBDEHMD> IJNIBHLOECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xF541E0", Offset = "0xF531E0", VA = "0x180F541E0")]
	[CompilerGenerated]
	private void FODHPDDMIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70B20A0", Offset = "0x70B10A0", VA = "0x1870B20A0")]
	[CompilerGenerated]
	private float EKAFGAHJBIB(CDFLADOFHBJ IBOEOPFBKMK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DECLFMAJLFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ELCLBKEHMDC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JDBFMBECFKB GOJPOFMCGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CLDJCNIOIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OIDLICKKMBF<JDBFMBECFKB> APGOMGLPGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJBJDNPPHIA(JDBFMBECFKB MEKEDENLGAM, bool GMJANOKBDKI = false);
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
				[Cpp2IlInjected.Address(RVA = "0x70B6290", Offset = "0x70B5290", VA = "0x1870B6290")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x70B62F0", Offset = "0x70B52F0", VA = "0x1870B62F0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x70B6240", Offset = "0x70B5240", VA = "0x1870B6240")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x70B5FE0", Offset = "0x70B4FE0", VA = "0x1870B5FE0")]
			public void DMAOIAEOFDI(PointerEventData OCMIJFCAOMA, RectTransform IHPCEECHCPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x70B5DC0", Offset = "0x70B4DC0", VA = "0x1870B5DC0")]
			public void BDMOEMHFEAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x70B5EE0", Offset = "0x70B4EE0", VA = "0x1870B5EE0")]
			public void CNHPJGCEFIJ(PointerEventData OCMIJFCAOMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x70B61F0", Offset = "0x70B51F0", VA = "0x1870B61F0")]
			public void GDBNEIJOHJD(float NMDMGGDLKDE, RectTransform IHPCEECHCPB, Vector3 NEABPKFFKMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly OIDLICKKMBF<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly OIDLICKKMBF<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly OIDLICKKMBF<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly OIDLICKKMBF<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly OIDLICKKMBF<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly MONMJFCKPLO PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly UIHandleEventData CMPNPOMALKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool BDMFPKEJNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool DMDNBGKGOPB;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool HMEJEGNFHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBE8760", Offset = "0xBE7760", VA = "0x180BE8760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x70B5450", Offset = "0x70B4450", VA = "0x1870B5450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IOOBNPOGLLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xEF2110", Offset = "0xEF1110", VA = "0x180EF2110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x70B5420", Offset = "0x70B4420", VA = "0x1870B5420")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70B5B50", Offset = "0x70B4B50", VA = "0x1870B5B50")]
		private bool PCDOMDIMLDP(PointerEventData MLPMPPLPMHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70B5A30", Offset = "0x70B4A30", VA = "0x1870B5A30", Slot = "5")]
		public void OnPointerDown(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70B5AF0", Offset = "0x70B4AF0", VA = "0x1870B5AF0", Slot = "11")]
		public void OnPointerUp(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70B5790", Offset = "0x70B4790", VA = "0x1870B5790", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70B5480", Offset = "0x70B4480", VA = "0x1870B5480", Slot = "7")]
		public void OnBeginDrag(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70B55B0", Offset = "0x70B45B0", VA = "0x1870B55B0", Slot = "4")]
		public void OnDrag(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x70B56A0", Offset = "0x70B46A0", VA = "0x1870B56A0", Slot = "8")]
		public void OnEndDrag(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x70B5A90", Offset = "0x70B4A90", VA = "0x1870B5A90", Slot = "9")]
		public void OnPointerEnter(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70B5AC0", Offset = "0x70B4AC0", VA = "0x1870B5AC0", Slot = "10")]
		public void OnPointerExit(PointerEventData MLPMPPLPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70B5570", Offset = "0x70B4570", VA = "0x1870B5570")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70B5BE0", Offset = "0x70B4BE0", VA = "0x1870B5BE0")]
		public UIHandleDecorator()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
