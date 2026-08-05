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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7227250", Offset = "0x7225A50", VA = "0x187227250", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		private enum LLMLIIHNLLN
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
		private static readonly FICDJCDJOAA DIDMLJIOHBJ;

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
		private int FBKHAHPHHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private LLMLIIHNLLN EKFKJKKDGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricIdLookup CMMKIIAAFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private IRawMetricsPipeline ELIDCPFPHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IMetricCollectionRegistry AHPPHMIKANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken DPMBDNDODFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NDEKLFKFBLK CNNMDHIFODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PMAPFGKHBBP MFLBAHACEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GNMDELHJGHP IPIIJGNDJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material NPKAIGOPOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int PLBEIIFBECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LayoutRect GCNMIDCKJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int ILOKPCCJJGI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int IDMKHEGPGPN = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MetricId> MBNPNAIJPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<JIHOPNHNEKN> NCDPDFIGHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<LAPGJEEBOIF> BEKEGEKIDFN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static List<(string source, string metric)> HDCIGCIFNEH;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7228E20", Offset = "0x7227620", VA = "0x187228E20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7228F20", Offset = "0x7227720", VA = "0x187228F20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7228E90", Offset = "0x7227690", VA = "0x187228E90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72272E0", Offset = "0x7225AE0", VA = "0x1872272E0")]
		private void AEJPAFDENBJ(bool MDKHOHFGOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72274B0", Offset = "0x7225CB0", VA = "0x1872274B0")]
		private void AJNLKCNEHII(bool MDKHOHFGOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7228F50", Offset = "0x7227750", VA = "0x187228F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7228270", Offset = "0x7226A70", VA = "0x187228270")]
		public void InitMetricsDependencies(MetricIdLookup CMMKIIAAFLF, IRawMetricsPipeline ELIDCPFPHBD, IMetricCollectionRegistry AHPPHMIKANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7228800", Offset = "0x7227000", VA = "0x187228800")]
		private void OBGEFMDPEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7227E70", Offset = "0x7226670", VA = "0x187227E70")]
		private void IELJHHADCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7228C90", Offset = "0x7227490", VA = "0x187228C90")]
		private void OOICLCFILAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7227950", Offset = "0x7226150", VA = "0x187227950")]
		private bool DNFJMJCBDBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72285F0", Offset = "0x7226DF0", VA = "0x1872285F0")]
		private bool NKAEDFIMFLM(bool NCPDACPPHOF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7227CF0", Offset = "0x72264F0", VA = "0x187227CF0")]
		private bool IBNGEILPHEO(EBHJNILHBLH IHDNMHOODCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7227840", Offset = "0x7226040", VA = "0x187227840")]
		private bool DFKCPFOHBDP(EBHJNILHBLH IHDNMHOODCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7227A90", Offset = "0x7226290", VA = "0x187227A90")]
		public void HandleMetric([In] RawMetric IADMGNEMNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7228500", Offset = "0x7226D00", VA = "0x187228500")]
		private bool NIJILGFKCCB(MetricId DMJLMNPMPFJ, [Out] int CNJHIMKFKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72284F0", Offset = "0x7226CF0", VA = "0x1872284F0")]
		private bool LJAOPMBJEPI(LLMLIIHNLLN BBGBNMPLEPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7227810", Offset = "0x7226010", VA = "0x187227810")]
		private bool ANKMEGPDFKJ(LLMLIIHNLLN ILFNBEKDFDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7229AE0", Offset = "0x72282E0", VA = "0x187229AE0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7227830", Offset = "0x7226030", VA = "0x187227830", Slot = "4")]
		private void COCGEOKPICL([In] RawMetric IADMGNEMNND)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LAPGJEEBOIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PMAPFGKHBBP NFBDJCBBHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GNMDELHJGHP LAIGOCLGBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int ENEPMJMCHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LayoutRect PBEELOHLMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private TextSegmentLayout IFJDKLDEMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private TextSegmentLayout DACBLBEAMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private TextSegmentLayout FAFLFAKGJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FMAIIFELFMP BCEOPJILMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool DIDJKDKLDFO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public LAPGJEEBOIF(PMAPFGKHBBP NKLHEDKDALJ, GNMDELHJGHP ENAACCIKMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72268B0", Offset = "0x72250B0", VA = "0x1872268B0")]
	public void LDJJIOLOFEI(LayoutRect LKGPAHDHOFE, int MOIABHHPILK, float GPGMANJHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7227130", Offset = "0x7225930", VA = "0x187227130")]
	public void NLOHJCKBJAC(float GPGMANJHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7226700", Offset = "0x7224F00", VA = "0x187226700")]
	public void KNCOHJAECNC(char[] MGCFKMAJPIG, char[] GKHDCOFCIEF, char[] OPHJCPNECOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72262B0", Offset = "0x7224AB0", VA = "0x1872262B0")]
	public void CAINNLMAECA(float DFBOCHGPNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7226260", Offset = "0x7224A60", VA = "0x187226260")]
	public void AOOEHMFIJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7226590", Offset = "0x7224D90", VA = "0x187226590")]
	public void FKDGMNCEIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72265B0", Offset = "0x7224DB0", VA = "0x1872265B0")]
	public void KHANLFIJLDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum NCFEFMENIBE
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
public class JIHOPNHNEKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public BAMKPBAKIBA DBCLCIMEJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string OGGMPDNCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NCFEFMENIBE GFIJIFKHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public char[] BBPCDHPBOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public char[] CDCBJCBAMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public char[] AGNPPEAKPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private RawMetricPayload OANAMCHLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EWMA OKJJCIHELKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double IKJKFEANBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IJHPKLBPODD;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72260D0", Offset = "0x72248D0", VA = "0x1872260D0")]
	public JIHOPNHNEKN(BAMKPBAKIBA BBLIOLNPAJP, string FLCBDBJFLGG, [Optional] string EAFLLIIIPNP, bool NAPEJIBMKGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7225F50", Offset = "0x7224750", VA = "0x187225F50")]
	public void MLDHOPCAGFK(RawMetricPayload GNCFEMKBAGO, bool GJLPAPOPINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7225AD0", Offset = "0x72242D0", VA = "0x187225AD0")]
	public bool FBJIODANEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7225F00", Offset = "0x7224700", VA = "0x187225F00")]
	private static int HJEEEIHEOEA(BAMKPBAKIBA CFLPAAADPFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7226050", Offset = "0x7224850", VA = "0x187226050")]
	private static bool PFHJMNCMOFG(char[] GJAJAHIEACP, char[] MCEIDNFODED)
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
			[Cpp2IlInjected.Address(RVA = "0x7225940", Offset = "0x7224140", VA = "0x187225940")]
			public bool MGOAPNFHPME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3709EA0", Offset = "0x37086A0", VA = "0x183709EA0")]
			private static bool DBGEPGIGIKN<T>(T BIINCLMPDMO, T INDENPJBLHO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7225A60", Offset = "0x7224260", VA = "0x187225A60", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72259E0", Offset = "0x72241E0", VA = "0x1872259E0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7229C20", Offset = "0x7228420", VA = "0x187229C20")]
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
