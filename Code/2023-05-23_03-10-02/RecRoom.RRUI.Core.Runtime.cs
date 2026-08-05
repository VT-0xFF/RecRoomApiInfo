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
		public enum KONLFPLCDNF : byte
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
		private static readonly int CNONBHLMCCL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Dictionary<KONLFPLCDNF, string> APNJPFMJHND;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int HNAPMPGFCAO = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly int JNPHODGDPBK;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int MCCEEIOBMEF;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly int JNIPFMJFMDO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int CMCHEKAICGN;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly int GNFGBEPGPMN;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly int OHBPBCLCODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PEBEIBFJIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GOJAOMILGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Color[] EPPKLFHOABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private KONLFPLCDNF type;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly KONLFPLCDNF[] JMPCBBLMOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[MJNEDKHJIPG("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly KONLFPLCDNF[] EFGKCICHKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[MJNEDKHJIPG("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[MJNEDKHJIPG("type", (byte)4)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[MJNEDKHJIPG("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Graphic AGBKOLEIFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EOLNIPGHOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Gradient CIGBJOOBOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x809410", Offset = "0x808810", VA = "0x180809410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5C40", Offset = "0x6EE5040", VA = "0x186EE5C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KONLFPLCDNF KEFHMMCGAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xF30160", Offset = "0xF2F560", VA = "0x180F30160")]
			get
			{
				return default(KONLFPLCDNF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5DC0", Offset = "0x6EE51C0", VA = "0x186EE5DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool DCBFGCLOHHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6EE49C0", Offset = "0x6EE3DC0", VA = "0x186EE49C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Vector2 KIIINGNLDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5BD0", Offset = "0x6EE4FD0", VA = "0x186EE5BD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5BF0", Offset = "0x6EE4FF0", VA = "0x186EE5BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool FHMNMLIJMJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE52D0", Offset = "0x6EE46D0", VA = "0x186EE52D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Vector2 EKLADAGPJGF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BD7E60", Offset = "0x6BD7260", VA = "0x186BD7E60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5D70", Offset = "0x6EE5170", VA = "0x186EE5D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float GBKFEPFAPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A280", Offset = "0x1C29680", VA = "0x181C2A280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2214230", Offset = "0x2213630", VA = "0x182214230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Vector2 NBDMBIMAOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE56E0", Offset = "0x6EE4AE0", VA = "0x186EE56E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Vector2 NGIFDOLKPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4940", Offset = "0x6EE3D40", VA = "0x186EE4940")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float CNLIFEMBNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1C1D0A0", Offset = "0x1C1C4A0", VA = "0x181C1D0A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5DD0", Offset = "0x6EE51D0", VA = "0x186EE5DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A40", Offset = "0x6EE3E40", VA = "0x186EE4A40", Slot = "12")]
		protected override void JAHPFCEAGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5570", Offset = "0x6EE4970", VA = "0x186EE5570")]
		private void ODCALCMBPJF(Color[] JLLDOIIEOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4BC0", Offset = "0x6EE3FC0", VA = "0x186EE4BC0", Slot = "13")]
		protected override void KNMBKNMHHNN(Material MCCMDDPOEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5350", Offset = "0x6EE4750", VA = "0x186EE5350", Slot = "14")]
		protected override void NECPPNDDFHI(Material MCCMDDPOEBN, bool BAFIBBBAHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5B10", Offset = "0x6EE4F10", VA = "0x186EE5B10")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OptionData ACFPKGJDEJG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2FC0", Offset = "0x6EE23C0", VA = "0x186EE2FC0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2EB0", Offset = "0x6EE22B0", VA = "0x186EE2EB0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2DF0", Offset = "0x6EE21F0", VA = "0x186EE2DF0")]
		private void BJPCDGLNMHO(GameObject EMLFLPBKKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE31B0", Offset = "0x6EE25B0", VA = "0x186EE31B0")]
		public void SetOptionsWithNoDefault(List<string> ICOGIPBOJIN, [Optional] string DJBGIKKAEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE33F0", Offset = "0x6EE27F0", VA = "0x186EE33F0")]
		public void SetOptionsWithNoDefault(List<OptionData> HIHLCMINDAB, [Optional] string DJBGIKKAEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE30D0", Offset = "0x6EE24D0", VA = "0x186EE30D0", Slot = "42")]
		public override void OnPointerClick(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C8E0", Offset = "0x83BCE0", VA = "0x18083C8E0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas APDDPINMMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EE34E0", Offset = "0x6EE28E0", VA = "0x186EE34E0")]
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
		public enum ILOIHPAOGOK
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int MNMOFJAOPEH;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int ABHLGNILOCG;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int NOKPNBMALMB;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int KKIJMOFGNCI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly int CBCCEJFOJIN;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly int OGINFCAKDHL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly int FLMNNGICAKI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int AGENOGKPPEI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int ADIKMKFJPFJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly int PIDMGHGELIA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int ODGDBPDJCKI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int ODGICFNEJAF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int HHNKKKLIJIO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CFLNCIFIKPE;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AEINIOEBFNA;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int AGOGEAHNGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
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
		private ILOIHPAOGOK animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[MJNEDKHJIPG("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[MJNEDKHJIPG("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Graphic AGBKOLEIFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override bool KIPDFDBIGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Sprite FHPEBCLIECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9850", Offset = "0x6EE8C50", VA = "0x186EE9850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9A60", Offset = "0x6EE8E60", VA = "0x186EE9A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Color GOPECMGIIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x962160", Offset = "0x961560", VA = "0x180962160")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9B00", Offset = "0x6EE8F00", VA = "0x186EE9B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color IIPDNJHPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB5B2F0", Offset = "0xB5A6F0", VA = "0x180B5B2F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9950", Offset = "0x6EE8D50", VA = "0x186EE9950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float MFGPDDEPOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xBC9560", Offset = "0xBC8960", VA = "0x180BC9560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE99F0", Offset = "0x6EE8DF0", VA = "0x186EE99F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 NFCBGLDKNAH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1D926E0", Offset = "0x1D91AE0", VA = "0x181D926E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9A10", Offset = "0x6EE8E10", VA = "0x186EE9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float KOJCAHIFAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9D8950", Offset = "0x9D7D50", VA = "0x1809D8950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EE99B0", Offset = "0x6EE8DB0", VA = "0x186EE99B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 GEJMNGHIMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1262770", Offset = "0x1261B70", VA = "0x181262770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9B60", Offset = "0x6EE8F60", VA = "0x186EE9B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LJLPKJDNAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1CBE9A0", Offset = "0x1CBDDA0", VA = "0x181CBE9A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9920", Offset = "0x6EE8D20", VA = "0x186EE9920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Matrix4x4 NMBANDEBEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8AD0", Offset = "0x6EE7ED0", VA = "0x186EE8AD0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ILOIHPAOGOK FNPOECPBNFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xC11080", Offset = "0xC10480", VA = "0x180C11080")]
			get
			{
				return default(ILOIHPAOGOK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9940", Offset = "0x6EE8D40", VA = "0x186EE9940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float OCCJLDNJFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x103D4E0", Offset = "0x103C8E0", VA = "0x18103D4E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE99D0", Offset = "0x6EE8DD0", VA = "0x186EE99D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float OPKNDKNLCBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1D926A0", Offset = "0x1D91AA0", VA = "0x181D926A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9900", Offset = "0x6EE8D00", VA = "0x186EE9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8B40", Offset = "0x6EE7F40", VA = "0x186EE8B40", Slot = "13")]
		protected override void KNMBKNMHHNN(Material MCCMDDPOEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9250", Offset = "0x6EE8650", VA = "0x186EE9250")]
		private void ONBJEIFOAIE(Sprite MPIFPENFEEA, out Vector2 JINLOILAMPJ, out Vector2 CFJFFDHCFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9200", Offset = "0x6EE8600", VA = "0x186EE9200", Slot = "14")]
		protected override void NECPPNDDFHI(Material MCCMDDPOEBN, bool BAFIBBBAHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EE97B0", Offset = "0x6EE8BB0", VA = "0x186EE97B0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static Shader AJPDJPDBJIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public sealed override Shader JKOMPHBGHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6EE9C10", Offset = "0x6EE9010", VA = "0x186EE9C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9BB0", Offset = "0x6EE8FB0", VA = "0x186EE9BB0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool MPBBKFPBKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x90D9A0", Offset = "0x90CDA0", VA = "0x18090D9A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x92ED50", Offset = "0x92E150", VA = "0x18092ED50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PointerEventData> ENDIIJIIKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3FE0", Offset = "0x6EE33E0", VA = "0x186EE3FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4120", Offset = "0x6EE3520", VA = "0x186EE4120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> MOKAKNLJDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4080", Offset = "0x6EE3480", VA = "0x186EE4080")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6EE41C0", Offset = "0x6EE35C0", VA = "0x186EE41C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3F20", Offset = "0x6EE3320", VA = "0x186EE3F20", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3F80", Offset = "0x6EE3380", VA = "0x186EE3F80", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x352CAC0", Offset = "0x352BEC0", VA = "0x18352CAC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x352CAC0", Offset = "0x352BEC0", VA = "0x18352CAC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CAJPKFFOIBN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DMMMEPIPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const DMMMEPIPNEI KFECNBBNCNI = DMMMEPIPNEI.Light;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const string CJCDCJNPJFC = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static ODGLAHCCHJO MMPEAEMMMJD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static ODGLAHCCHJO GEIDDMDIMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2020", Offset = "0x6EE1420", VA = "0x186EE2020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static DMMMEPIPNEI KPPEEINFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EE21B0", Offset = "0x6EE15B0", VA = "0x186EE21B0")]
		get
		{
			return default(DMMMEPIPNEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1DF0", Offset = "0x6EE11F0", VA = "0x186EE1DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event Action<DMMMEPIPNEI> KPHFADKOBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1F60", Offset = "0x6EE1360", VA = "0x186EE1F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EE20F0", Offset = "0x6EE14F0", VA = "0x186EE20F0")]
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
		private sealed class PHHHDDELLDF : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private IPNFOPMMOKI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public PHHHDDELLDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4260", Offset = "0x6EE3660", VA = "0x186EE4260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4840", Offset = "0x6EE3C40", VA = "0x186EE4840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[JADFEINJJEN(BGDDCFKMKBJ.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly KBENAKLNOBE JPCAFPMLECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OPMCAHDHBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3? FOFMIEPKFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool? FDDKFDDAFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool? BCJHKGJOLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool CGPHOCOGLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool GBEALCHPFOP;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GJFHLBGBFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3C00", Offset = "0x6EE3000", VA = "0x186EE3C00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool MDOPJLLMKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3BE0", Offset = "0x6EE2FE0", VA = "0x186EE3BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BPCOCFOHJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x26C7030", Offset = "0x26C6430", VA = "0x1826C7030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3DF0", Offset = "0x6EE31F0", VA = "0x186EE3DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JBDFAIHJIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3B40", Offset = "0x6EE2F40", VA = "0x186EE3B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3D50", Offset = "0x6EE3150", VA = "0x186EE3D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3550", Offset = "0x6EE2950", VA = "0x186EE3550")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE38E0", Offset = "0x6EE2CE0", VA = "0x186EE38E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE36A0", Offset = "0x6EE2AA0", VA = "0x186EE36A0")]
		public void Hide(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3A20", Offset = "0x6EE2E20", VA = "0x186EE3A20")]
		public void Show(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3980", Offset = "0x6EE2D80", VA = "0x186EE3980")]
		public void Set(object IJNLJGNNJFA, bool GOHAJIHPEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3720", Offset = "0x6EE2B20", VA = "0x186EE3720")]
		private void OEIJINLFDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EE35F0", Offset = "0x6EE29F0", VA = "0x186EE35F0")]
		[IteratorStateMachine(typeof(PHHHDDELLDF))]
		private IEnumerator<IPNFOPMMOKI> CBLEHILFCHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3660", Offset = "0x6EE2A60", VA = "0x186EE3660", Slot = "5")]
		public virtual void DoHideOrShow(bool HELBFJEGECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3AA0", Offset = "0x6EE2EA0", VA = "0x186EE3AA0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xAA1F0", Offset = "0xA95F0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly int FLDMCFGGEMK;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly int OOHCCGOLBPA;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly int JOIMDFDABJD;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int ENBFDPCNCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
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
		private Color[] EPPKLFHOABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private float[] EMMKOEHNHHK;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override Graphic AGBKOLEIFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected override bool KIPDFDBIGMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyList<RingLayer> OHHDGELHMJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 KIIINGNLDBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBC95A0", Offset = "0xBC89A0", VA = "0x180BC95A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8A80", Offset = "0x6EE7E80", VA = "0x186EE8A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8780", Offset = "0x6EE7B80", VA = "0x186EE8780")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PECBEKHBFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8560", Offset = "0x6EE7960", VA = "0x186EE8560")]
		public bool SetRingLayerColor(int LOOKJAGKAIG, Color OGGMNJPGMJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8670", Offset = "0x6EE7A70", VA = "0x186EE8670")]
		public bool SetRingLayerSize(int LOOKJAGKAIG, float ABBKELIMEIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8220", Offset = "0x6EE7620", VA = "0x186EE8220", Slot = "12")]
		protected override void JAHPFCEAGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8390", Offset = "0x6EE7790", VA = "0x186EE8390", Slot = "13")]
		protected override void KNMBKNMHHNN(Material MCCMDDPOEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8510", Offset = "0x6EE7910", VA = "0x186EE8510", Slot = "14")]
		protected override void NECPPNDDFHI(Material MCCMDDPOEBN, bool BAFIBBBAHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EE88D0", Offset = "0x6EE7CD0", VA = "0x186EE88D0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly DMJEFGFFCMN IEDFOHFGNNE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static Sprite PCJBLPCKFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material IGBLCODACHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Material MNFJPMPLBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool AAGMHPJNPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool OPMCAHDHBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool NLJPIFKGBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool GEAIKEEKCCF;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract Graphic AGBKOLEIFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public abstract Shader JKOMPHBGHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool EOLNIPGHOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected virtual bool KIPDFDBIGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected RectTransform HCFHKJIKHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE78D0", Offset = "0x6EE6CD0", VA = "0x186EE78D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected Rect JCFMADLHABD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7C00", Offset = "0x6EE7000", VA = "0x186EE7C00")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected static Sprite GDDHKBMBKEP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE7700", Offset = "0x6EE6B00", VA = "0x186EE7700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D90", Offset = "0x6EE6190", VA = "0x186EE6D90", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D30", Offset = "0x6EE7130", VA = "0x186EE7D30", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8050", Offset = "0x6EE7450", VA = "0x186EE8050", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7EE0", Offset = "0x6EE72E0", VA = "0x186EE7EE0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EE71F0", Offset = "0x6EE65F0", VA = "0x186EE71F0")]
		private void CNJHLMLEGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7960", Offset = "0x6EE6D60", VA = "0x186EE7960")]
		private void KLNAAMBPNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7930", Offset = "0x6EE6D30", VA = "0x186EE7930")]
		private void JMCDDGDAMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8060", Offset = "0x6EE7460", VA = "0x186EE8060")]
		private void PHCOADGLNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6F80", Offset = "0x6EE6380", VA = "0x186EE6F80")]
		protected void BHOALAKOFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7AC0", Offset = "0x6EE6EC0", VA = "0x186EE7AC0")]
		private void KPBLFJFBBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
		protected virtual void JAHPFCEAGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "13")]
		protected virtual void KNMBKNMHHNN(Material MCCMDDPOEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "14")]
		protected virtual void NECPPNDDFHI(Material MCCMDDPOEBN, bool BAFIBBBAHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7370", Offset = "0x6EE6770", VA = "0x186EE7370")]
		private void COEOHGDICOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		[Conditional("RRUI_PROFILING")]
		protected void JCFLHLALFGM(string GCMKPCAFBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		[Conditional("RRUI_PROFILING")]
		protected void IGADKOENMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		protected UIMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AEBNABMLPNF : OHALECIMFPH, BBFFELLNEIA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	global::BHKLKEHGEFA<GameObject, int> KBFAELGLDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	global::FADFJBGFMFG<GameObject, int, bool> HOGONLLLELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	global::KDDMDDMMGFF<bool> PDIEAIAFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool EFDAGLHGBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float HEHHHNNAGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	global::KDDMDDMMGFF<float> EFIPJHBICGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PBANGFKDEGA JICOFJKHCOM
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
	void SpawnLoadingPlaceholders(GameObject BLJDINJOMCN);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DAPNFHHMCEG Spawn<T>(int KFGBOBMFFDG, IReadOnlyList<T> KOCKBILIHNN, GameObject BLJDINJOMCN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DAPNFHHMCEG Spawn<T>(int KFGBOBMFFDG, IReadOnlyList<T> KOCKBILIHNN, GameObject MGCECMIAICG, ref Func<int, GameObject> OGDIHLLDLHK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DMJEFGFFCMN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct DDHBLKDEMJD : IEquatable<DDHBLKDEMJD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Component GEKPLLKAIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Action DLGECHLJJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int BLIKIKOACAH;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Component GKPPKBNFFJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2400", Offset = "0x6EE1800", VA = "0x186EE2400")]
		public DDHBLKDEMJD(Component GEKPLLKAIKG, Action DLGECHLJJEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2380", Offset = "0x6EE1780", VA = "0x186EE2380")]
		public void NIJHMMDNNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2360", Offset = "0x6EE1760", VA = "0x186EE2360", Slot = "4")]
		public bool Equals(DDHBLKDEMJD CCJMBGJFGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE22D0", Offset = "0x6EE16D0", VA = "0x186EE22D0", Slot = "0")]
		public override bool Equals(object GHHNOPFOGCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AGGJCEABIPL : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private IPNFOPMMOKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DMJEFGFFCMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <countToProcess>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IOrderedEnumerable<DDHBLKDEMJD> <ordered>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <index>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private DDHBLKDEMJD <queuedOperation>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
		[DebuggerHidden]
		public AGGJCEABIPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE19A0", Offset = "0x6EE0DA0", VA = "0x186EE19A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE1DB0", Offset = "0x6EE11B0", VA = "0x186EE1DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DAIHBNICBGG.FJMGNALFAEJ GNMLJOIGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int BOJLNLDMEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly int ACLPDMCEJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Component, float> GGBEPLPEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Component, DDHBLKDEMJD> CMDEBMPKNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LinkedList<DDHBLKDEMJD> FIAPJPFKIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<DDHBLKDEMJD> LKAFAFHJIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private LMKHJNMJFLJ MJBBEALHEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private KIPNFJFNJGE FNIJFPELJNH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private KIPNFJFNJGE DAKAJFDIHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2BC0", Offset = "0x6EE1FC0", VA = "0x186EE2BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2C90", Offset = "0x6EE2090", VA = "0x186EE2C90")]
	public DMJEFGFFCMN(DAIHBNICBGG.FJMGNALFAEJ GNMLJOIGOAF, int BOJLNLDMEEC = -1, int ACLPDMCEJMO = -1, [Optional] Func<Component, float> GGBEPLPEAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2460", Offset = "0x6EE1860", VA = "0x186EE2460")]
	public void AIHPOLLAPGA(Component GEKPLLKAIKG, Action EDHKDBDKIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE26D0", Offset = "0x6EE1AD0", VA = "0x186EE26D0")]
	public void BOBGFJFLFOK(Component GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2C30", Offset = "0x6EE2030", VA = "0x186EE2C30")]
	public bool ONCAFPNEANI(Component COGHLJDPMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2990", Offset = "0x6EE1D90", VA = "0x186EE2990")]
	private void KJAKHONJDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2920", Offset = "0x6EE1D20", VA = "0x186EE2920")]
	[IteratorStateMachine(typeof(AGGJCEABIPL))]
	private IEnumerator<IPNFOPMMOKI> IFFCEBFEBDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x208FDD0", Offset = "0x208F1D0", VA = "0x18208FDD0")]
	[CompilerGenerated]
	private void HEAMCPPNFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2860", Offset = "0x6EE1C60", VA = "0x186EE2860")]
	[CompilerGenerated]
	private float CAGLHJKLHGO(DDHBLKDEMJD EDHKDBDKIPB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HGANPJEEIAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DKPIJHNOMDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BMIMDDHDMKE KPBLMBKJEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PHKBPIPLKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	global::KDDMDDMMGFF<BMIMDDHDMKE> LHLIMANFKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIBHAHGKPDG(BMIMDDHDMKE CIKPMFNOLCN, bool OFLBAAGPPDK = false);
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
				[Cpp2IlInjected.Address(RVA = "0x6EE6C80", Offset = "0x6EE6080", VA = "0x186EE6C80")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6EE6CE0", Offset = "0x6EE60E0", VA = "0x186EE6CE0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6EE6C00", Offset = "0x6EE6000", VA = "0x186EE6C00")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6790", Offset = "0x6EE5B90", VA = "0x186EE6790")]
			public void AJNELOKJGEC(PointerEventData LJINIAGPEMF, RectTransform HCFHKJIKHOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6EE69A0", Offset = "0x6EE5DA0", VA = "0x186EE69A0")]
			public void GGDCGFFOGOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6B10", Offset = "0x6EE5F10", VA = "0x186EE6B10")]
			public void PBOPMMJOCGH(PointerEventData LJINIAGPEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6AC0", Offset = "0x6EE5EC0", VA = "0x186EE6AC0")]
			public void GJEGMOKLNEN(float GHPNIFEDLMD, RectTransform HCFHKJIKHOJ, Vector3 NADLKJKLONK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly global::KDDMDDMMGFF<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly global::KDDMDDMMGFF<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly global::KDDMDDMMGFF<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly global::KDDMDDMMGFF<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly global::KDDMDDMMGFF<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly PBANGFKDEGA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly UIHandleEventData LJDNAMOJOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool LFJFOMCCLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool HCIMJCMHPJC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool LJLODHOACJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB6B650", Offset = "0xB6AA50", VA = "0x180B6B650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5DF0", Offset = "0x6EE51F0", VA = "0x186EE5DF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool AEMOPCHIKJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB6B6D0", Offset = "0xB6AAD0", VA = "0x180B6B6D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5EB0", Offset = "0x6EE52B0", VA = "0x186EE5EB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E20", Offset = "0x6EE5220", VA = "0x186EE5E20")]
		private bool IHJLOOKKLCL(PointerEventData PMHAGNPJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6490", Offset = "0x6EE5890", VA = "0x186EE6490", Slot = "5")]
		public void OnPointerDown(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6550", Offset = "0x6EE5950", VA = "0x186EE6550", Slot = "11")]
		public void OnPointerUp(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE61F0", Offset = "0x6EE55F0", VA = "0x186EE61F0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5EE0", Offset = "0x6EE52E0", VA = "0x186EE5EE0", Slot = "7")]
		public void OnBeginDrag(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6010", Offset = "0x6EE5410", VA = "0x186EE6010", Slot = "4")]
		public void OnDrag(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6100", Offset = "0x6EE5500", VA = "0x186EE6100", Slot = "8")]
		public void OnEndDrag(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE64F0", Offset = "0x6EE58F0", VA = "0x186EE64F0", Slot = "9")]
		public void OnPointerEnter(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6520", Offset = "0x6EE5920", VA = "0x186EE6520", Slot = "10")]
		public void OnPointerExit(PointerEventData PMHAGNPJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5FD0", Offset = "0x6EE53D0", VA = "0x186EE5FD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE65B0", Offset = "0x6EE59B0", VA = "0x186EE65B0")]
		public UIHandleDecorator()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
