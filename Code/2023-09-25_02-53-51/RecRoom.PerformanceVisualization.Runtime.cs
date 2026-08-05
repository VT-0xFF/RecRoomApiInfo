using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Metrics.Pipeline;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.Profiling.Configs;
using RecRoom.Profiling.Core;
using TMPro;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Profiling
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum MetricAccumulateMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Average,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		AveragePerSecond,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Max,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Min,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		First,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Sum
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ProfilerMarker DCIGCELIBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ProfilerMarker IGFLFJLMOOB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int OIIFABNBJCA = 8;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int LHHEHJDLKAO = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private AAIHJNECFPF OOMOAKKFKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool JALACNMEMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private float AANCKGGLFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float EBGIOHOOJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float MIMDHIBOHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float ELKNOHINNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float ANLOFBOHJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[FormerlySerializedAs("graphImageShaderFull")]
		[SerializeField]
		[Space]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Header("Graph Visuals")]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Space]
		[SerializeField]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Space]
		[SerializeField]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private bool higherValueIsBetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JLKOCGHLIDE GFGJOADFOOH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int ECICEOMBKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC8F0", Offset = "0x5EDBCF0", VA = "0x185EDC8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int LDMIENPKOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC910", Offset = "0x5EDBD10", VA = "0x185EDC910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int GKHMBMHNKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD760", Offset = "0x5EDCB60", VA = "0x185EDD760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OEAEIABGONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDF80", Offset = "0x5EDD380", VA = "0x185EDDF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int NNDHLLAFJHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDF50", Offset = "0x5EDD350", VA = "0x185EDDF50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float DFOBEMNBNPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDEB0", Offset = "0x5EDD2B0", VA = "0x185EDDEB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float IKHOGKMLLCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDEF0", Offset = "0x5EDD2F0", VA = "0x185EDDEF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float ADPDFLJIGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDED0", Offset = "0x5EDD2D0", VA = "0x185EDDED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PIKBEAFLJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDF10", Offset = "0x5EDD310", VA = "0x185EDDF10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float MKJOAAJCIAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDF30", Offset = "0x5EDD330", VA = "0x185EDDF30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC8A0", Offset = "0x5EDBCA0", VA = "0x185EDC8A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDBE0", Offset = "0x5EDCFE0", VA = "0x185EDDBE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD7C0", Offset = "0x5EDCBC0", VA = "0x185EDD7C0")]
		public void PushSample(double NILHKJJMGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC8D0", Offset = "0x5EDBCD0", VA = "0x185EDC8D0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC930", Offset = "0x5EDBD30", VA = "0x185EDC930")]
		private void GDCBBGDLPPA(bool EAJNNLJOPDA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD8A0", Offset = "0x5EDCCA0", VA = "0x185EDD8A0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD570", Offset = "0x5EDC970", VA = "0x185EDD570")]
		public void InitData(int ACGADGPCGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB90", Offset = "0x5EDBF90", VA = "0x185EDCB90")]
		private void IAPPCOAIHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDC10", Offset = "0x5EDD010", VA = "0x185EDDC10")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class AAIHJNECFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	protected float[] DNKOOLIMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	protected int BFDBLANOPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	protected int CHEGLPEPHED;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78B850", Offset = "0x78AC50", VA = "0x18078B850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MEONMMKPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x14DA1F0", Offset = "0x14D95F0", VA = "0x1814DA1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float KDNIBFGAFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9890", Offset = "0x5ED8C90", VA = "0x185ED9890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float MDLALHHDOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED98A0", Offset = "0x5ED8CA0", VA = "0x185ED98A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9510", Offset = "0x5ED8910", VA = "0x185ED9510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ED99F0", Offset = "0x5ED8DF0", VA = "0x185ED99F0")]
	public AAIHJNECFPF(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9740", Offset = "0x5ED8B40", VA = "0x185ED9740")]
	public void CLEDEOCKOAI(int LCICNLLOKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED97D0", Offset = "0x5ED8BD0", VA = "0x185ED97D0")]
	public void HGHPGEIICGN(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD330", Offset = "0x1FAC730", VA = "0x181FAD330")]
	public void GDDCOBAOCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED95C0", Offset = "0x5ED89C0", VA = "0x185ED95C0")]
	public void MCGEFOOIDKA(float[] ADOGMMPMLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED98B0", Offset = "0x5ED8CB0", VA = "0x185ED98B0")]
	public void MCGEFOOIDKA(float[] ADOGMMPMLJB, int FAMCEIOGKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED99C0", Offset = "0x5ED8DC0", VA = "0x185ED99C0")]
	private int PDLODJBFPKI(int JPEMHHILGGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JLKOCGHLIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int CJOIALACNIB = 512;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const int GHIFDOAMIOA = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int ANIEPEKEBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float[] NAGKCDLKNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public RawImage LMACONIFMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float ACOOCBDOBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float CAKMCHBDMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float KLEBDOJBFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float ALHJJHCENFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float DEDJKENGHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Color KHDHHDKHGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Color PIIGIJIHKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public bool FKLAIDLBLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Color JJHAPIAINEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color LNGECHDCEIB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly int PJJMAGEMNAL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly int AMGGBOHOCJG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly int IGCDLKLPGFG;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int GGDOEOFHECB;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int NPLBEDMHBEA;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int LMJHHEIKGBK;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int AEOMEFPJHLC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int GFFNPDPNODO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int LNAFBAIEGAD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int APAJNKNECKP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int OGCGEOEFMHI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int NPFHJJMILNB;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB1A0", Offset = "0x5EDA5A0", VA = "0x185EDB1A0")]
	public void AIBGGPEJMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB4C0", Offset = "0x5EDA8C0", VA = "0x185EDB4C0")]
	public void MKJABHFJFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB260", Offset = "0x5EDA660", VA = "0x185EDB260")]
	public void CGNPLGPBHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB3E0", Offset = "0x5EDA7E0", VA = "0x185EDB3E0")]
	public void MFJGEONIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB600", Offset = "0x5EDAA00", VA = "0x185EDB600")]
	public void PFNLMKLAFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB560", Offset = "0x5EDA960", VA = "0x185EDB560")]
	public void ONHKHPOHJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB300", Offset = "0x5EDA700", VA = "0x185EDB300")]
	public void LJAFCBOPOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB9D0", Offset = "0x5EDADD0", VA = "0x185EDB9D0")]
	public JLKOCGHLIDE()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private MetricIdLookup NCMLOBDKJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IRawMetricsPipeline OJIFBPPHAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IMetricCollectionRegistry CFGPPFKNKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricId CPJKDEFEENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int PFAFAMBJJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MetricAccumulateMode BIDONEANIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MetricCollectionToken IBLOMPOENGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MetricDescription OENKDLGLEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GraphConfig DMDGJPKFGJD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAD7460", Offset = "0xAD6860", VA = "0x180AD7460", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764850", VA = "0x180765450", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA160", Offset = "0x5ED9560", VA = "0x185EDA160")]
		private void OOHEFNNEBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9A60", Offset = "0x5ED8E60", VA = "0x185ED9A60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA3C0", Offset = "0x5ED97C0", VA = "0x185EDA3C0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA2B0", Offset = "0x5ED96B0", VA = "0x185EDA2B0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9BC0", Offset = "0x5ED8FC0", VA = "0x185ED9BC0")]
		public void Initialize(GraphConfig LPFAMNOFBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA050", Offset = "0x5ED9450", VA = "0x185EDA050", Slot = "14")]
		protected override bool OKOHJFNNLNK(string FJFAOGLKNJK = "0.00", [Optional] string FJELPDNODDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9AC0", Offset = "0x5ED8EC0", VA = "0x185ED9AC0")]
		public void HandleMetric([In] RawMetric GFKPNIJICPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19C5D60", Offset = "0x19C5160", VA = "0x1819C5D60", Slot = "4")]
		protected override MPGOPBPIKON MILFBMLHEEP()
		{
			return default(MPGOPBPIKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA530", Offset = "0x5ED9930", VA = "0x185EDA530")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9AC0", Offset = "0x5ED8EC0", VA = "0x185ED9AC0", Slot = "15")]
		private void JCKGEMJBBKN([In] RawMetric GFKPNIJICPE)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x809190", Offset = "0x808590", VA = "0x180809190", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xF45340", Offset = "0xF44740", VA = "0x180F45340", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "4")]
		protected override MPGOPBPIKON MILFBMLHEEP()
		{
			return default(MPGOPBPIKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAEF0", Offset = "0x5EDA2F0", VA = "0x185EDAEF0", Slot = "14")]
		protected override bool OKOHJFNNLNK(string FJFAOGLKNJK = "0.00", [Optional] string FJELPDNODDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAFF0", Offset = "0x5EDA3F0", VA = "0x185EDAFF0")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x809190", Offset = "0x808590", VA = "0x180809190", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF45340", Offset = "0xF44740", VA = "0x180F45340", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "4")]
		protected override MPGOPBPIKON MILFBMLHEEP()
		{
			return default(MPGOPBPIKON);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB070", Offset = "0x5EDA470", VA = "0x185EDB070", Slot = "14")]
		protected override bool OKOHJFNNLNK(string FJFAOGLKNJK = "0.00", [Optional] string FJELPDNODDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB150", Offset = "0x5EDA550", VA = "0x185EDB150")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Profiling Metric")]
		[SerializeField]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private ProfilerRecorderHandle OMKBODGAPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static bool KMFBHEHFJAM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool FKIFFJEPEPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDFCF0", Offset = "0x5EDF0F0", VA = "0x185EDFCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAD7450", Offset = "0xAD6850", VA = "0x180AD7450", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAD7460", Offset = "0xAD6860", VA = "0x180AD7460", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "4")]
		protected override MPGOPBPIKON MILFBMLHEEP()
		{
			return default(MPGOPBPIKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFB30", Offset = "0x5EDEF30", VA = "0x185EDFB30", Slot = "14")]
		protected override bool OKOHJFNNLNK(string FJFAOGLKNJK = "0.00", [Optional] string FJELPDNODDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFC50", Offset = "0x5EDF050", VA = "0x185EDFC50")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Random Range")]
		[Range(0f, 99f)]
		[SerializeField]
		private float randomMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[Range(1f, 100f)]
		private float randomMax;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x809190", Offset = "0x808590", VA = "0x180809190", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF45340", Offset = "0xF44740", VA = "0x180F45340", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81B9C0", Offset = "0x81ADC0", VA = "0x18081B9C0", Slot = "4")]
		protected override MPGOPBPIKON MILFBMLHEEP()
		{
			return default(MPGOPBPIKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFD00", Offset = "0x5EDF100", VA = "0x185EDFD00")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAC0", Offset = "0x5EDAEC0", VA = "0x185EDBAC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBEA0", Offset = "0x5EDB2A0", VA = "0x185EDBEA0")]
		public MetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Metric Text")]
		[SerializeField]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool GFJDGABBBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool JAMOGKIBAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool GHPBIGNHBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private bool FMNIHGLELKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool EDBJEOCOKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool DNIGDANFMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool GPFDNHNIIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool PPGJGHIEMGB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string GACOIOMJIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC680", Offset = "0x5EDBA80", VA = "0x185EDC680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC820", Offset = "0x5EDBC20", VA = "0x185EDC820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string LOMEPOBJDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC620", Offset = "0x5EDBA20", VA = "0x185EDC620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC6E0", Offset = "0x5EDBAE0", VA = "0x185EDC6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string KEFDJLABHBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC640", Offset = "0x5EDBA40", VA = "0x185EDC640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC760", Offset = "0x5EDBB60", VA = "0x185EDC760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string IMPIBHFCAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC690", Offset = "0x5EDBA90", VA = "0x185EDC690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC860", Offset = "0x5EDBC60", VA = "0x185EDC860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string EANCLBMEGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC630", Offset = "0x5EDBA30", VA = "0x185EDC630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC720", Offset = "0x5EDBB20", VA = "0x185EDC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string GHMEJFKPIHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC670", Offset = "0x5EDBA70", VA = "0x185EDC670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC7E0", Offset = "0x5EDBBE0", VA = "0x185EDC7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string DFHPNHINNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC650", Offset = "0x5EDBA50", VA = "0x185EDC650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC7A0", Offset = "0x5EDBBA0", VA = "0x185EDC7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string PHOBNIMPFDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC600", Offset = "0x5EDBA00", VA = "0x185EDC600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC6A0", Offset = "0x5EDBAA0", VA = "0x185EDC6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC520", Offset = "0x5EDB920", VA = "0x185EDC520", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC4A0", Offset = "0x5EDB8A0", VA = "0x185EDC4A0")]
		protected string KGPNGONGKEK(bool LCBCCCEAOJH, TMP_Text OFAFLOECBGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC460", Offset = "0x5EDB860", VA = "0x185EDC460")]
		protected void DGJMFIDOJCN(bool GIGKDDJAEEB, TMP_Text ADOGMMPMLJB, string LPCGJALKADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected const string DAOEKJKFAEL = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected double ANIDILMPHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected double JKGAKBGLFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected double EFBFPDPGDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected double GEEHHGEBAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected double GNNLDLCCDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected int EHDICJKNFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double MPLAECIFBKC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int GLBOJBGACDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode OLNOOPLFGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool HOLELADMOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA1F5E0", Offset = "0xA1E9E0", VA = "0x180A1F5E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA1F8B0", Offset = "0xA1ECB0", VA = "0x180A1F8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MPGOPBPIKON MILFBMLHEEP();

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void IEMKFHBMNPL();

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEE1210", Offset = "0xEE0610", VA = "0x180EE1210", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xEE1210", Offset = "0xEE0610", VA = "0x180EE1210")]
		protected void OKNJDHDMOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC2C0", Offset = "0x5EDB6C0", VA = "0x185EDC2C0", Slot = "10")]
		protected virtual void MMHLFDMKPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBF70", Offset = "0x5EDB370", VA = "0x185EDBF70", Slot = "11")]
		protected virtual void AODIHBDEOOF(double MOLPJCFALPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC300", Offset = "0x5EDB700", VA = "0x185EDC300", Slot = "12")]
		protected virtual double OHLOBEAHMHH(MetricAccumulateMode BIDONEANIHI)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC030", Offset = "0x5EDB430", VA = "0x185EDC030")]
		protected bool GNHENEHDMON(MetricGraph APALEIGJBCD, MetricAccumulateMode OHCLHGENEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC190", Offset = "0x5EDB590", VA = "0x185EDC190", Slot = "13")]
		protected virtual string JMGCEBNODDD(double LPCGJALKADL, string AFHDKJPDCMJ = "0.00", [Optional] string LLBPJOEKBIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB150", Offset = "0x5EDA550", VA = "0x185EDB150")]
		protected MetricGraphDriverBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[FormerlySerializedAs("targetGraph")]
		[Header("Graph and Text")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected bool FFMFHFCLCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected bool BCNPINGGIJE;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0240", Offset = "0x5EDF640", VA = "0x185EE0240", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFD40", Offset = "0x5EDF140", VA = "0x185EDFD40", Slot = "5")]
		protected override void IEMKFHBMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFEF0", Offset = "0x5EDF2F0", VA = "0x185EDFEF0", Slot = "14")]
		protected virtual bool OKOHJFNNLNK(string FJFAOGLKNJK = "0.00", [Optional] string FJELPDNODDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB150", Offset = "0x5EDA550", VA = "0x185EDB150")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JHLBCJLKNHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	RawMetricPayload IHINEMEMCIK();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ECALBAAOGBN : JHLBCJLKNHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static bool KMFBHEHFJAM;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> LOHHHKLMINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly MetricId CPJKDEFEENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly string DICOOKAELGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly string PMJAPNJHNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private ProfilerRecorder AOAPNFKNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool DPBNGKGGPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool HAOPAIGBFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ProfilerRecorderDescription KBLCHPPEBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorderHandle OMKBODGAPHO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x889760", Offset = "0x888B60", VA = "0x180889760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription INEHLHAMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x54FBE60", Offset = "0x54FB260", VA = "0x1854FBE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAE80", Offset = "0x5EDA280", VA = "0x185EDAE80")]
	public ECALBAAOGBN(MetricId CPJKDEFEENN, string DICOOKAELGA, string PMJAPNJHNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA760", Offset = "0x5ED9B60", VA = "0x185EDA760", Slot = "6")]
	public RawMetricPayload IHINEMEMCIK()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA570", Offset = "0x5ED9970", VA = "0x185EDA570")]
	private static ProfilerRecorderHandle BFPADDGNOOJ(string DICOOKAELGA, string PMJAPNJHNHG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAAD0", Offset = "0x5ED9ED0", VA = "0x185EDAAD0")]
	private void PPJLEKDJCLE(bool EAJNNLJOPDA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA6E0", Offset = "0x5ED9AE0", VA = "0x185EDA6E0")]
	private static MetricDescription FHBHCKJGHON(MetricId CPJKDEFEENN, ProfilerRecorderDescription HMKPEHEPGLK)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA800", Offset = "0x5ED9C00", VA = "0x185EDA800")]
	private static bool OFNAEFGLNFM(bool EAJNNLJOPDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA6C0", Offset = "0x5ED9AC0", VA = "0x185EDA6C0")]
	private void BOEDFPLHEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA6C0", Offset = "0x5ED9AC0", VA = "0x185EDA6C0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LNJLBNJMKEG : JHLBCJLKNHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<double> OFCDBCHNGJM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x764440", Offset = "0x763840", VA = "0x180764440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBA70", Offset = "0x5EDAE70", VA = "0x185EDBA70")]
	public LNJLBNJMKEG(Func<double> OFCDBCHNGJM, MetricDescription OENKDLGLEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBA00", Offset = "0x5EDAE00", VA = "0x185EDBA00", Slot = "6")]
	public RawMetricPayload IHINEMEMCIK()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NFKCKNBPCGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct ODGKHOOPMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string FAJJKIPJNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly string MOGFFCPGFAB;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
		public ODGKHOOPMLM(string DICOOKAELGA, string PMJAPNJHNHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OGBCGNDPHGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NFKCKNBPCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF8F0", Offset = "0x5EDECF0", VA = "0x185EDF8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFAD0", Offset = "0x5EDEED0", VA = "0x185EDFAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MetricIdLookup NCMLOBDKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IRawMetricsPipeline OJIFBPPHAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IMetricCollectionRegistry CFGPPFKNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Dictionary<MetricId, JHLBCJLKNHN> HFLGBBEBNIC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly ODGKHOOPMLM[] DHMOOCIHFFI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE410", Offset = "0x5EDD810", VA = "0x185EDE410")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.GameOnly)]
	private static void OFBGMIAKKFE(BFGBHKPNKEI AFJFOILCBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF0A0", Offset = "0x5EDE4A0", VA = "0x185EDF0A0")]
	[Preserve]
	public NFKCKNBPCGG([LMAFJMDCBJO(null)] MetricIdLookup NCMLOBDKJPI, [LMAFJMDCBJO(null)] IRawMetricsPipeline OJIFBPPHAMH, [LMAFJMDCBJO(null)] IMetricCollectionRegistry CFGPPFKNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE510", Offset = "0x5EDD910", VA = "0x185EDE510")]
	private void PIMFHDIACDD(string NELFJOLDENA, string PMJAPNJHNHG, MPGOPBPIKON HCMGFHEKMJP, Func<double> OFCDBCHNGJM, [Out] MetricId CPJKDEFEENN, [Out] JHLBCJLKNHN OFAFLOECBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE0D0", Offset = "0x5EDD4D0", VA = "0x185EDE0D0")]
	private void KFABFFGDAEO(MetricId CPJKDEFEENN, bool FMCODCPHLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDFA0", Offset = "0x5EDD3A0", VA = "0x185EDDFA0")]
	[AsyncStateMachine(typeof(OGBCGNDPHGI))]
	private Task CHAIECJIDEA(CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE170", Offset = "0x5EDD570", VA = "0x185EDE170")]
	public void LFFBFCDONHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE090", Offset = "0x5EDD490", VA = "0x185EDE090", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Profiling.Configs
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GraphConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB180", Offset = "0x5EDA580", VA = "0x185EDB180")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
		public GraphConfigAsset()
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
