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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77D1D50", Offset = "0x77D0950", VA = "0x1877D1D50", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		private enum CCLDHOPBKJG
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
		private static readonly NDNFAPMFFIF MJLCFJHEKHP;

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
		private int EPGGIIBFLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private CCLDHOPBKJG OJNCLPOICBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MetricIdLookup IIMDBBNNOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private IRawMetricsPipeline ANBCKJMIDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IMetricCollectionRegistry OLKOFGPMCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricCollectionToken EKFLPKBJGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NLOFMOGCLHG BIAHKKKLGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MEGNCIGFIBN INAFLCLGBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CAHOPPIGHGE AMNOCCNFALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material NIJDMLIFLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int KGDFHAALKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LayoutRect CPBJAGBFEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int MEHKGHONDHO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int IBHIFIIJCJN = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<MetricId> DAOJJOCEJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<AFGGNPCKOEF> OKOPBACFDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<MNEAMCNLDDD> MHJBHODENDN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static List<(string source, string metric)> HHLHHEONOFJ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77D44F0", Offset = "0x77D30F0", VA = "0x1877D44F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77D45F0", Offset = "0x77D31F0", VA = "0x1877D45F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77D4560", Offset = "0x77D3160", VA = "0x1877D4560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77D3050", Offset = "0x77D1C50", VA = "0x1877D3050")]
		private void FPAMPDANIJG(bool MNCEFEPALIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77D3220", Offset = "0x77D1E20", VA = "0x1877D3220")]
		private void HILEAHGJHPB(bool MNCEFEPALIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77D4A30", Offset = "0x77D3630", VA = "0x1877D4A30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77D37E0", Offset = "0x77D23E0", VA = "0x1877D37E0")]
		public void InitMetricsDependencies(MetricIdLookup IIMDBBNNOIH, IRawMetricsPipeline ANBCKJMIDNN, IMetricCollectionRegistry OLKOFGPMCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77D3E10", Offset = "0x77D2A10", VA = "0x1877D3E10")]
		private void KEEMMJPDNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77D4620", Offset = "0x77D3220", VA = "0x1877D4620")]
		private void PIDLGAPCGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77D3A70", Offset = "0x77D2670", VA = "0x1877D3A70")]
		private void JBECNMPOKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77D43B0", Offset = "0x77D2FB0", VA = "0x1877D43B0")]
		private bool LAFGHGCHBDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77D3C00", Offset = "0x77D2800", VA = "0x1877D3C00")]
		private bool JNOBEBNMAJE(bool FGNGFOJCGAK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77D2EC0", Offset = "0x77D1AC0", VA = "0x1877D2EC0")]
		private bool CHKFLFHEMMN(DMLEJMKBAGP BIKFHOMEEFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77D42A0", Offset = "0x77D2EA0", VA = "0x1877D42A0")]
		private bool KHJDLLFLMHK(DMLEJMKBAGP BIKFHOMEEFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77D3580", Offset = "0x77D2180", VA = "0x1877D3580")]
		public void HandleMetric([In] RawMetric ABHJMHHDEHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77D2DD0", Offset = "0x77D19D0", VA = "0x1877D2DD0")]
		private bool BKDEHLJMDMI(MetricId KNAFCIOAPAD, [Out] int FHDFNCOBNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77D3040", Offset = "0x77D1C40", VA = "0x1877D3040")]
		private bool EMGEHKCDDLC(CCLDHOPBKJG FHBOGDMJPBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77D3A50", Offset = "0x77D2650", VA = "0x1877D3A50")]
		private bool JABLGPCHADA(CCLDHOPBKJG KKIMIGFBDNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77D55D0", Offset = "0x77D41D0", VA = "0x1877D55D0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77D4A20", Offset = "0x77D3620", VA = "0x1877D4A20", Slot = "4")]
		private void PNLEHIJAGOE([In] RawMetric ABHJMHHDEHJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNEAMCNLDDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MEGNCIGFIBN NMCNLNCJNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CAHOPPIGHGE PIPKIPKCDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int KBCGGHAJDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LayoutRect GFNOAAHNLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private TextSegmentLayout KILHJHDFKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private TextSegmentLayout NLMLCOOOHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private TextSegmentLayout ILLNNHFPFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NPBINNAFLIH CHBMPPFLIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool HMKANHABODA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public MNEAMCNLDDD(MEGNCIGFIBN ONHCKABGOKG, CAHOPPIGHGE HMLKLAIFLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77D1F70", Offset = "0x77D0B70", VA = "0x1877D1F70")]
	public void HGFFJCPBDPD(LayoutRect JJIMIOPJDGB, int ANDHLPPBGFD, float ECMLLKFOIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77D1E50", Offset = "0x77D0A50", VA = "0x1877D1E50")]
	public void HFNNDDNJBHI(float ECMLLKFOIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77D2940", Offset = "0x77D1540", VA = "0x1877D2940")]
	public void LLENPIEOEPO(char[] JIHBPODLGBD, char[] FCNIHCFACIG, char[] BOOCALLDNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77D2AF0", Offset = "0x77D16F0", VA = "0x1877D2AF0")]
	public void PJHINPOPCLC(float LFEPNJCECAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77D1DE0", Offset = "0x77D09E0", VA = "0x1877D1DE0")]
	public void EGHFBBKCDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77D1E30", Offset = "0x77D0A30", VA = "0x1877D1E30")]
	public void FJLJDJDNHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77D27F0", Offset = "0x77D13F0", VA = "0x1877D27F0")]
	public void LKJKNINAOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum NODENCJANEE
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
public class AFGGNPCKOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DJGOCJOLKLD GEPKDDKPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string EPAPDJAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NODENCJANEE LAGKKKLGFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public char[] IPJAPGJHLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public char[] IOIDEIMFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public char[] AAMBCCKDAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private RawMetricPayload BFDCDDMLJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EWMA NOJEDDIAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double GGDPODJDIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int DGMOKDNACDE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77D1A30", Offset = "0x77D0630", VA = "0x1877D1A30")]
	public AFGGNPCKOEF(DJGOCJOLKLD LKHIDGFCANJ, string DGJAAFKDAFL, [Optional] string LNIOKJEHIHB, bool PDDJGNIPLBE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77D1930", Offset = "0x77D0530", VA = "0x1877D1930")]
	public void PBIBKFCLHJC(RawMetricPayload LOPMJFJJKPK, bool IIPDPGDFJCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77D1430", Offset = "0x77D0030", VA = "0x1877D1430")]
	public bool CNDPDLOCLBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77D1860", Offset = "0x77D0460", VA = "0x1877D1860")]
	private static int EEBGHFOJDCL(DJGOCJOLKLD NFPJBPLFGDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77D18B0", Offset = "0x77D04B0", VA = "0x1877D18B0")]
	private static bool HOOIGIKFLPI(char[] IFMENDFGFGN, char[] DPEOCFNLADP)
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
			[Cpp2IlInjected.Address(RVA = "0x77D1BC0", Offset = "0x77D07C0", VA = "0x1877D1BC0")]
			public bool IPHELBGPAMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3A75150", Offset = "0x3A73D50", VA = "0x183A75150")]
			private static bool CODGPEAPCAE<T>(T EJGAMJDEIEL, T MPDLOLIOGJL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x77D1CE0", Offset = "0x77D08E0", VA = "0x1877D1CE0", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x77D1C60", Offset = "0x77D0860", VA = "0x1877D1C60", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77D5710", Offset = "0x77D4310", VA = "0x1877D5710")]
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
