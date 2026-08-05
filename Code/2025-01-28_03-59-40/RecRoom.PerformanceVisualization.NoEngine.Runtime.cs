using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using RecRoom.FastText.Layout;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_NoEngine_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75080C0", Offset = "0x75072C0", VA = "0x1875080C0", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricHudDisplay : MonoBehaviour, IRawMetricsSubscriber, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		private enum MKEBBHMIGCB
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			LayoutStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			MetricStatesInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			AllStatesInit = 0xC,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			AllInit = 0xF
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly KJMCEDJMPPA OPFOMAHKGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MeshBufferRenderer MeshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public RectTransform RenderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Material Mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Min(4f)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int BIKLJIGCEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private MKEBBHMIGCB FCEBHLLGGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricIdLookup BJIEFEBGCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private IRawMetricsPipeline GCDIFIJKKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IMetricCollectionRegistry FAKEHEHMOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken MNIMFCAPOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BHODPMLBBNM FFLAJCEKCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DKIEIDEMIME KHELDMMKPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NOHDHIIGDEH JAFKGLHGBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material GPFKKLJPKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int PBJHAIFBALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LayoutRect PLCAEKFOEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int JBGDKJNAMFK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int FOEAMKHPFEA = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MetricId> EKOFFMMODLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<IJJHKNBMNCM> CCKLFELPNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<INPOIDOBBIK> MPHDDDCBBCB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static List<(string source, string metric)> EDEOIFFNGPE;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7509C90", Offset = "0x7508E90", VA = "0x187509C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7509D90", Offset = "0x7508F90", VA = "0x187509D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7509D00", Offset = "0x7508F00", VA = "0x187509D00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7508170", Offset = "0x7507370", VA = "0x187508170")]
		private void DLECNCNMGCO(bool OINJAKJLDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7508340", Offset = "0x7507540", VA = "0x187508340")]
		private void FINLOILEGKM(bool OINJAKJLDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7509DC0", Offset = "0x7508FC0", VA = "0x187509DC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7509670", Offset = "0x7508870", VA = "0x187509670")]
		public void InitMetricsDependencies(MetricIdLookup BJIEFEBGCCB, IRawMetricsPipeline GCDIFIJKKMI, IMetricCollectionRegistry FAKEHEHMOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75087F0", Offset = "0x75079F0", VA = "0x1875087F0")]
		private void GFHMFKPLLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7509180", Offset = "0x7508380", VA = "0x187509180")]
		private void ICIJLOEPBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7508D90", Offset = "0x7507F90", VA = "0x187508D90")]
		private void HNKJPCBFECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75086B0", Offset = "0x75078B0", VA = "0x1875086B0")]
		private bool GBKKINEGPIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7509A80", Offset = "0x7508C80", VA = "0x187509A80")]
		private bool OGMGBJEGMIH(bool NIEHNLOFAGF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7509900", Offset = "0x7508B00", VA = "0x187509900")]
		private bool MEKBILCODKN(GMCIEAGOLMI PDEGCFKDOBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7508C80", Offset = "0x7507E80", VA = "0x187508C80")]
		private bool GOJNIEDDAJO(GMCIEAGOLMI PDEGCFKDOBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7508F20", Offset = "0x7508120", VA = "0x187508F20")]
		public void HandleMetric([In] RawMetric NBJADCLOGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7509580", Offset = "0x7508780", VA = "0x187509580")]
		private bool IHOHMJBLFHE(MetricId BMMJPCHDKHA, [Out] int FPENEGOPMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75086A0", Offset = "0x75078A0", VA = "0x1875086A0")]
		private bool FKJLJMIOHLE(MKEBBHMIGCB IJBFGNKJLLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7508150", Offset = "0x7507350", VA = "0x187508150")]
		private bool DHMIJOCJJOM(MKEBBHMIGCB LPHJJJJKKAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x750A950", Offset = "0x7509B50", VA = "0x18750A950")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75098F0", Offset = "0x7508AF0", VA = "0x1875098F0", Slot = "4")]
		private void JOCAOEEBHFN([In] RawMetric NBJADCLOGHA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INPOIDOBBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DKIEIDEMIME JCEPAKELEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NOHDHIIGDEH PMAHHINPEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int HBHHLPCDONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LayoutRect MIKADDEJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private TextSegmentLayout EOHFFINKINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private TextSegmentLayout KLKCGECKMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private TextSegmentLayout EGFEDIFNBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EABLOJBDHOA CJBBANJPENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool INBDCPCEGKC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public INPOIDOBBIK(DKIEIDEMIME GPEKOJGOADB, NOHDHIIGDEH HEGEMEFKGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7507820", Offset = "0x7506A20", VA = "0x187507820")]
	public void MDPAGNEJHAM(LayoutRect DOAPDCBJHGH, int NPKAHKAGKCH, float CKIHIFFKFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7507420", Offset = "0x7506620", VA = "0x187507420")]
	public void IMGGFPFJHFA(float CKIHIFFKFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7507270", Offset = "0x7506470", VA = "0x187507270")]
	public void FMCONNMBFHJ(char[] KNJOPIBPHGA, char[] INMOIEKJAKE, char[] MIKHAMPPKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7507540", Offset = "0x7506740", VA = "0x187507540")]
	public void KLIAIFMOMIF(float GPBPLDBCIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7507220", Offset = "0x7506420", VA = "0x187507220")]
	public void DKLHCCEAJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75080A0", Offset = "0x75072A0", VA = "0x1875080A0")]
	public void OJDIFOOKJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75070D0", Offset = "0x75062D0", VA = "0x1875070D0")]
	public void BOFJLDDGHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum IBDIPNKNNEG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MetricDirty = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PrefixDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ValueDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	SuffixDirty = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	AllDirty = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IJJHKNBMNCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public PADIBGFLFMK GBEFNCPNIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string LIDGNFMGBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IBDIPNKNNEG PEFKFBOEJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public char[] BHLADDCFDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public char[] IFHPCLMKKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public char[] KPOOGIFFNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private RawMetricPayload OCPJHHIMKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EWMA OKBBLPDAMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double EPDMGCIPECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LKKNBNEOJOD;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7506F40", Offset = "0x7506140", VA = "0x187506F40")]
	public IJJHKNBMNCM(PADIBGFLFMK FALLKOMDOBN, string JJDGHGFHPLI, [Optional] string ELPJHCCLNPD, bool ODNKOCHBHEM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7506A10", Offset = "0x7505C10", VA = "0x187506A10")]
	public void HMHHEDGAFOH(RawMetricPayload DKNCPJDOFAO, bool GBAKPJDDBNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7506B10", Offset = "0x7505D10", VA = "0x187506B10")]
	public bool JNENIIJFLEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75069C0", Offset = "0x7505BC0", VA = "0x1875069C0")]
	private static int EGDGGDNLEOB(PADIBGFLFMK IFPPILNPODL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7506940", Offset = "0x7505B40", VA = "0x187506940")]
	private static bool EDDCNKALEOD(char[] FBCBJPMNPEK, char[] HHDMEFHBCOI)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TestMetricProvider : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class DemoValueSource : ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			[SerializeField]
			[HideInInspector]
			public bool isInit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public string prefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public float value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public string suffix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private string _lastPrefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private float _lastValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private string _lastSuffix;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x75067B0", Offset = "0x75059B0", VA = "0x1875067B0")]
			public bool BMOAJMMFAHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3996FB0", Offset = "0x39961B0", VA = "0x183996FB0")]
			private static bool JCEAPBAFHGD<T>(T MKMPLOHPJDC, T OMEFCJCOLII)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x75068D0", Offset = "0x7505AD0", VA = "0x1875068D0", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7506850", Offset = "0x7505A50", VA = "0x187506850", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x750AA90", Offset = "0x7509C90", VA = "0x18750AA90")]
		public TestMetricProvider()
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
