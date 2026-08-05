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
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9C80", Offset = "0x6FF9080", VA = "0x186FF9C80", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		private enum FHEPMABPBNO
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
		private static readonly LDGDBHIGNCI KCGJFCENNJN;

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
		private int DIPNFPFLDOI;

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
		private FHEPMABPBNO HLOLIKEMNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup DGOMFBGCMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline LMAFOOEMKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry JIINONPGNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken JBJIJGOCNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private LALFALEIMHN BEOOAIKKMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GEIIMOHGFPH MCOGENNACEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IMCPMIOKINE PBHPACKODGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Material AAJJJLEIEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int MJBMKOGOBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LayoutRect FIGNIPKOLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<MetricId> JJENPGEBMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<IKLFMMCOKFE> LGNKNNBEFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<MEFIICJNAFJ> DMOCIFOEPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<TextSegmentLayout> AGGACMCJNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<KKPCOEJAMJD> HJJNNNNOOFE;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static List<(string source, string metric)> LFLBFJPPHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int FPPFHBNLLOI;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC840", Offset = "0x6FFBC40", VA = "0x186FFC840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC940", Offset = "0x6FFBD40", VA = "0x186FFC940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC8B0", Offset = "0x6FFBCB0", VA = "0x186FFC8B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBE90", Offset = "0x6FFB290", VA = "0x186FFBE90")]
		private void NANLOIMNDPP(bool PAPBJEBHJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB2E0", Offset = "0x6FFA6E0", VA = "0x186FFB2E0")]
		private void IIIJFAFNEEL(bool PAPBJEBHJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC970", Offset = "0x6FFBD70", VA = "0x186FFC970")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB650", Offset = "0x6FFAA50", VA = "0x186FFB650")]
		public void InitMetricsDependencies(MetricIdLookup DGOMFBGCMOH, IRawMetricsPipeline LMAFOOEMKGA, IMetricCollectionRegistry JIINONPGNJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC060", Offset = "0x6FFB460", VA = "0x186FFC060")]
		private void NIGKEMJDLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB8D0", Offset = "0x6FFACD0", VA = "0x186FFB8D0")]
		private void KAKFJOJGGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAAE0", Offset = "0x6FF9EE0", VA = "0x186FFAAE0")]
		private void CLFLBANOMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC590", Offset = "0x6FFB990", VA = "0x186FFC590")]
		private bool OFMOLIILLDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAD80", Offset = "0x6FFA180", VA = "0x186FFAD80")]
		private bool DGMEBDDDAAJ(bool BGJEDIPGEJM = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAF90", Offset = "0x6FFA390", VA = "0x186FFAF90")]
		private bool DLFHMOALPII(BGAGFHIJMOD LHOBDGJGOHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBC90", Offset = "0x6FFB090", VA = "0x186FFBC90")]
		private bool KEPDEBOFMJB(BGAGFHIJMOD LHOBDGJGOHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB110", Offset = "0x6FFA510", VA = "0x186FFB110")]
		public void HandleMetric([In] RawMetric DPCFNPJNAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBDA0", Offset = "0x6FFB1A0", VA = "0x186FFBDA0")]
		private bool LHNJEAMPHMK(MetricId ODAEGBKDIMC, [Out] int NCMIPJLKGID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB2D0", Offset = "0x6FFA6D0", VA = "0x186FFB2D0")]
		private bool HHBBGKCMCIB(FHEPMABPBNO LDFLCGAHNHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC570", Offset = "0x6FFB970", VA = "0x186FFC570")]
		private bool OAJADLFAKEE(FHEPMABPBNO LEEJPPKCOPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD3F0", Offset = "0x6FFC7F0", VA = "0x186FFD3F0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB110", Offset = "0x6FFA510", VA = "0x186FFB110", Slot = "4")]
		private void FHFEEPPHIHP([In] RawMetric DPCFNPJNAEL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MEFIICJNAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GEIIMOHGFPH OEJPJKFEDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IMCPMIOKINE OLCCNKOGNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int JOPCCIJFDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LayoutRect EFCHFAKKHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public TextSegmentLayout JLMFLIHGKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TextSegmentLayout GAKIEOKCDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TextSegmentLayout DLMDGOAFEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public KKPCOEJAMJD KGAJINFCKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BBODFKMBMPK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8AA360", Offset = "0x8A9760", VA = "0x1808AA360")]
	public MEFIICJNAFJ(GEIIMOHGFPH GBKDIHAJEMI, IMCPMIOKINE CJAOJOGHPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA260", Offset = "0x6FF9660", VA = "0x186FFA260")]
	public void MABFCCPGADF(LayoutRect LKPGBMMBEDG, int BAHOKBEDJKP, float LNKDOIMPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9D10", Offset = "0x6FF9110", VA = "0x186FF9D10")]
	public void HBBGONFNJKD(float LNKDOIMPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9F80", Offset = "0x6FF9380", VA = "0x186FF9F80")]
	public void LLIENHCJKDC(float AEDBJJIGBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9E30", Offset = "0x6FF9230", VA = "0x186FF9E30")]
	public void KKHABALCONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum DGIEHJGHKPA
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
public class IKLFMMCOKFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public CKOLOFCBEII HJHNONFNFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public RawMetricPayload KJMMHDHBJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string OFAPPLMOBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DGIEHJGHKPA MBOMLFMEOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public char[] NHHKPOMFNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public char[] ECKFPCOAGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public char[] JHMPFLJMGIO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9B80", Offset = "0x6FF8F80", VA = "0x186FF9B80")]
	public IKLFMMCOKFE(CKOLOFCBEII ABNCBEAMLGN, string ANGDLCGEOFA, [Optional] string AAEJHGKGBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF97F0", Offset = "0x6FF8BF0", VA = "0x186FF97F0")]
	public bool PEIBIICCPEG(RawMetricPayload BGCLCACDNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9770", Offset = "0x6FF8B70", VA = "0x186FF9770")]
	private static bool HIMMEAALKHE(char[] MMHCOKHACHF, char[] DEOGINMLLDP)
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
			[Cpp2IlInjected.Address(RVA = "0x6FF95E0", Offset = "0x6FF89E0", VA = "0x186FF95E0")]
			public bool KHPJJEPBLNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3598B50", Offset = "0x3597F50", VA = "0x183598B50")]
			private static bool DABHHGLIMGO<T>(T KLACLBHAHNL, T PFKKDHPJFEH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6FF9700", Offset = "0x6FF8B00", VA = "0x186FF9700", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FF9680", Offset = "0x6FF8A80", VA = "0x186FF9680", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD5D0", Offset = "0x6FFC9D0", VA = "0x186FFD5D0")]
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
