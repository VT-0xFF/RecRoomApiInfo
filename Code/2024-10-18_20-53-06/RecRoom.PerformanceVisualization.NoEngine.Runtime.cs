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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7076250", Offset = "0x7075650", VA = "0x187076250", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		private enum CGADOKNJCII
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			LayoutStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MetricStatesInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			AllStatesInit = 0xC,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			AllInit = 0xF
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly FLILHMOBPPM KGGFKPBFFAO;

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
		private int OFHFBLLLMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Space]
		public bool debugDraw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool printMeshTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool printMeshState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private CGADOKNJCII HGHNKBINKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CPFNHCKGBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline DPKCJBAKCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry GAAKEFOHNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken LIAPKPBHMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private IBKFBMGPJCG MGHJLFFJIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LPKFEHEKMNM LGOEMKGNKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private NNHAMMMJLJF NKBPIELEOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Material KFDLKMJDOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int PDLOPIPELBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LayoutRect GAEPILNMDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<MetricId> DNBHALMBMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<HPOFJJCJEFJ> BAGAFBHIJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<PCOOBKPNINL> JDCHCLOKBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<TextSegmentLayout> FPIBIHKIPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<EBPPFKDKDNN> HPOLKDCELAL;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static List<(string source, string metric)> EFCBCHIGDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int KCNDNLINPBD;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7078030", Offset = "0x7077430", VA = "0x187078030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7078130", Offset = "0x7077530", VA = "0x187078130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70780A0", Offset = "0x70774A0", VA = "0x1870780A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7077630", Offset = "0x7076A30", VA = "0x187077630")]
		private void KMLPBGAMFIB(bool DIPABKMBDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7077800", Offset = "0x7076C00", VA = "0x187077800")]
		private void LHDADLPOLMN(bool DIPABKMBDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7078160", Offset = "0x7077560", VA = "0x187078160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7076F90", Offset = "0x7076390", VA = "0x187076F90")]
		public void InitMetricsDependencies(MetricIdLookup CPFNHCKGBAN, IRawMetricsPipeline DPKCJBAKCFK, IMetricCollectionRegistry GAAKEFOHNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70767B0", Offset = "0x7075BB0", VA = "0x1870767B0")]
		private void HEHFIKDCBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70762E0", Offset = "0x70756E0", VA = "0x1870762E0")]
		private void ECAANEHNCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7077D90", Offset = "0x7077190", VA = "0x187077D90")]
		private void ONGLGKNLHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7077200", Offset = "0x7076600", VA = "0x187077200")]
		private bool JHHNOLDAHME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7077B70", Offset = "0x7076F70", VA = "0x187077B70")]
		private bool NJONLJNFKAA(bool JGJOKFEAOLJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70774B0", Offset = "0x70768B0", VA = "0x1870774B0")]
		private bool KDPDDFDJAML(COLLOIBBCEO GHEAAGKLGOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70766A0", Offset = "0x7075AA0", VA = "0x1870766A0")]
		private bool FGNLLKAOIBK(COLLOIBBCEO GHEAAGKLGOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7076CE0", Offset = "0x70760E0", VA = "0x187076CE0")]
		public void HandleMetric([In] RawMetric KMNLGFAJCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7076EA0", Offset = "0x70762A0", VA = "0x187076EA0")]
		private bool IHPPMNGNCAG(MetricId BKKMFJIOPPE, [Out] int BEJAMIEONLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7077D80", Offset = "0x7077180", VA = "0x187077D80")]
		private bool NLAODHDGGAG(CGADOKNJCII FPIEJIACJAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7076CC0", Offset = "0x70760C0", VA = "0x187076CC0")]
		private bool HOHEBKCMHHH(CGADOKNJCII LBOKJEAFALO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7078BF0", Offset = "0x7077FF0", VA = "0x187078BF0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7076CE0", Offset = "0x70760E0", VA = "0x187076CE0", Slot = "4")]
		private void KGCEIJALPHC([In] RawMetric KMNLGFAJCCN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PCOOBKPNINL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LPKFEHEKMNM MJKNIGKDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NNHAMMMJLJF LJAJBGIOAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int CFCKKCFPPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LayoutRect KEPMINLGJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public TextSegmentLayout EFMEABMHEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TextSegmentLayout JEDNPELMIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TextSegmentLayout JGAKENCAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public EBPPFKDKDNN JALFOEJMJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MEPMOJFOHMK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public PCOOBKPNINL(LPKFEHEKMNM MELNJLPNGKF, NNHAMMMJLJF IPBCPKNPPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7079040", Offset = "0x7078440", VA = "0x187079040")]
	public void IPNPHEKPPLJ(LayoutRect MEEBDNPEOAI, int NAJAIPFCAOE, float DNEOOCOLLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7078DD0", Offset = "0x70781D0", VA = "0x187078DD0")]
	public void GMGDKGEDGDG(float DNEOOCOLLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x70798C0", Offset = "0x7078CC0", VA = "0x1870798C0")]
	public void LAEMACFAEKC(float BKNICJKDNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7078EF0", Offset = "0x70782F0", VA = "0x187078EF0")]
	public void HBEHOJCOJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum ANDLCKJKJBF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PrefixDirty = 1,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ValueDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	SuffixDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	AllDirty = 7
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HPOFJJCJEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public OLDLONCLAIG EMBGFEPACHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public RawMetricPayload GLAPCPOHGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string AEALIPBMINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public ANDLCKJKJBF IIJDDNJCEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public char[] CEMNADHIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public char[] KDBDAKLGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public char[] CEBNLLGGGFJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7076150", Offset = "0x7075550", VA = "0x187076150")]
	public HPOFJJCJEFJ(OLDLONCLAIG HOPPGPPGLBE, string ELAGFCMMODJ, [Optional] string BHGNCFDIDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7075D40", Offset = "0x7075140", VA = "0x187075D40")]
	public bool KIPEDFHBMFB(RawMetricPayload ENFNBDNEJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x70760D0", Offset = "0x70754D0", VA = "0x1870760D0")]
	private static bool NGNCBCFCLLG(char[] JKMLNPBBJIG, char[] JDJGFJGMEAK)
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

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7075BB0", Offset = "0x7074FB0", VA = "0x187075BB0")]
			public bool EAGOEPPBNIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x35563F0", Offset = "0x35557F0", VA = "0x1835563F0")]
			private static bool EOMBBKGJBIL<T>(T KDGMCPCFIID, T EEPLCHCGAIN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7075CD0", Offset = "0x70750D0", VA = "0x187075CD0", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7075C50", Offset = "0x7075050", VA = "0x187075C50", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7079BA0", Offset = "0x7078FA0", VA = "0x187079BA0")]
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
