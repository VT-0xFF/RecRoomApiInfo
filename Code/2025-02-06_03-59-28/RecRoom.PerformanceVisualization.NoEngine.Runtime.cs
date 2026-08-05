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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75677B0", Offset = "0x75665B0", VA = "0x1875677B0", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		private enum JNIOKDCJEGL
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
		private static readonly IMOCAMGHNDM GNFFDDPIJIL;

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
		private int FPKAAEODHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private JNIOKDCJEGL LNFEAFIABKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricIdLookup EJBEEFLPOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private IRawMetricsPipeline BOLHOEFMIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IMetricCollectionRegistry BFKFLANGKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken PDMHDKDMMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FIABBFOOJIP ICEOPLKCMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FKOCNIPMAEG HMAHLAKPOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IMEEFGKPPKE LIGJIMGONJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material KIPDLLPOFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int OLCBKCHKEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LayoutRect JAADJKEKMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int PNGJMCODDLJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int HPPGMOEEBJF = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MetricId> LEKGNGJFCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<DMKMFKALGCD> PKGDDNHDPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<BPKNNJOIHAP> APPPNELCAOK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static List<(string source, string metric)> AKIBIJHHGCM;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7569170", Offset = "0x7567F70", VA = "0x187569170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7569270", Offset = "0x7568070", VA = "0x187569270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75691E0", Offset = "0x7567FE0", VA = "0x1875691E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7567F30", Offset = "0x7566D30", VA = "0x187567F30")]
		private void GLKAJAOLFJO(bool EFABJFPBMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7568700", Offset = "0x7567500", VA = "0x187568700")]
		private void LIGHCPIDFLO(bool EFABJFPBMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75694B0", Offset = "0x75682B0", VA = "0x1875694B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7568360", Offset = "0x7567160", VA = "0x187568360")]
		public void InitMetricsDependencies(MetricIdLookup EJBEEFLPOFN, IRawMetricsPipeline BOLHOEFMIDN, IMetricCollectionRegistry BFKFLANGKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7567850", Offset = "0x7566650", VA = "0x187567850")]
		private void ECKDHFEICKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7568A60", Offset = "0x7567860", VA = "0x187568A60")]
		private void NLECLBNNLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7568E60", Offset = "0x7567C60", VA = "0x187568E60")]
		private void ODBJGMKALBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7567CE0", Offset = "0x7566AE0", VA = "0x187567CE0")]
		private bool FHKOEFBFODD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75692A0", Offset = "0x75680A0", VA = "0x1875692A0")]
		private bool PFOFGFIMMDH(bool KGNMHCJFJMN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7568FF0", Offset = "0x7567DF0", VA = "0x187568FF0")]
		private bool OMKLJJNEDGC(OKLBKOCAMKG EDLHCINOAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7567E20", Offset = "0x7566C20", VA = "0x187567E20")]
		private bool GHLJJPFDBAB(OKLBKOCAMKG EDLHCINOAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7568100", Offset = "0x7566F00", VA = "0x187568100")]
		public void HandleMetric([In] RawMetric MGFEOFDPFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7568610", Offset = "0x7567410", VA = "0x187568610")]
		private bool JOOLBPIPINK(MetricId CMMEJENJLCL, [Out] int NJKJGDPJFND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7567840", Offset = "0x7566640", VA = "0x187567840")]
		private bool AMDFBCEMPCC(JNIOKDCJEGL CLBLFGHLMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75685E0", Offset = "0x75673E0", VA = "0x1875685E0")]
		private bool JCDGILGFKJG(JNIOKDCJEGL KEHMBFAADDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x756A040", Offset = "0x7568E40", VA = "0x18756A040")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7568600", Offset = "0x7567400", VA = "0x187568600", Slot = "4")]
		private void JKHJLHKLDAG([In] RawMetric MGFEOFDPFJD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BPKNNJOIHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FKOCNIPMAEG HGHJABBBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IMEEFGKPPKE DPAOJCFDEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int HMEGGELDEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LayoutRect IFEMMKNGLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private TextSegmentLayout KOPGCGIGOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private TextSegmentLayout HGIKALLHNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private TextSegmentLayout FAELANOKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OMINKFLJGFI HMEIFCEHADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool GGPHPDCPOCH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public BPKNNJOIHAP(FKOCNIPMAEG HMGBJPHMBEK, IMEEFGKPPKE BAIOBIDPIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7565EA0", Offset = "0x7564CA0", VA = "0x187565EA0")]
	public void EODJIAICOIO(LayoutRect AHLBIIJHCDD, int PPNFMFPJPPO, float OFJJEIFLHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75668C0", Offset = "0x75656C0", VA = "0x1875668C0")]
	public void LHCBDNGOBFG(float OFJJEIFLHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75669E0", Offset = "0x75657E0", VA = "0x1875669E0")]
	public void NKCJKAHEGCN(char[] KOBPGDPKDLK, char[] HHHANNKNBBC, char[] DFJELAKBIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7566B90", Offset = "0x7565990", VA = "0x187566B90")]
	public void NMJECJLPMIO(float AFDELCHOCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7566870", Offset = "0x7565670", VA = "0x187566870")]
	public void JJGCEFBMECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7566E70", Offset = "0x7565C70", VA = "0x187566E70")]
	public void OGJAPPOHOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7566720", Offset = "0x7565520", VA = "0x187566720")]
	public void IJPACGLADPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum MIMJHFNPINM
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
public class DMKMFKALGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public BKGHGLPOOJE LCKFLCDBLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string FFJJGCAKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public MIMJHFNPINM HCOIIDHKKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public char[] BJGJJMJADOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public char[] EGBMIIJNEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public char[] JENCFJAKBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private RawMetricPayload KGDIEBJBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EWMA KJKNLHOENJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double BDNNAPFEOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int JLJIJDBJDFM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7567490", Offset = "0x7566290", VA = "0x187567490")]
	public DMKMFKALGCD(BKGHGLPOOJE HMMCNHPDOBC, string LCKALKOAHEH, [Optional] string GOBCGDLDMLP, bool CLHMPECNKKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7566E90", Offset = "0x7565C90", VA = "0x187566E90")]
	public void AADNOKDOGNL(RawMetricPayload KACAFOCAICC, bool EEFCDDJADCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7566F90", Offset = "0x7565D90", VA = "0x187566F90")]
	public bool GCPFGFGGBJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7567440", Offset = "0x7566240", VA = "0x187567440")]
	private static int OCBJLOIMECA(BKGHGLPOOJE KHBADAIOLNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75673C0", Offset = "0x75661C0", VA = "0x1875673C0")]
	private static bool MOOHPMLLEMK(char[] NMOPBJNEFKL, char[] KCJDGOIFCIF)
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
			[Cpp2IlInjected.Address(RVA = "0x7567620", Offset = "0x7566420", VA = "0x187567620")]
			public bool ILOABMPMHCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x39D7E20", Offset = "0x39D6C20", VA = "0x1839D7E20")]
			private static bool GIANOLIIBDC<T>(T OBIPBFFAILK, T IPHILEOFJLB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7567740", Offset = "0x7566540", VA = "0x187567740", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x75676C0", Offset = "0x75664C0", VA = "0x1875676C0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x756A180", Offset = "0x7568F80", VA = "0x18756A180")]
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
