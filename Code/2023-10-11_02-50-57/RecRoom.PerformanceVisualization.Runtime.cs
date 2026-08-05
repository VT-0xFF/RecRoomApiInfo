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
		private ProfilerMarker MCKFHCBNPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ProfilerMarker MNALJJIPAIK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int GEEODMAJBLO = 8;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int LPFCLJPBEPH = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LEHHFBIDHHC ADDCFBJKAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool INKJDPGKCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private float FEFCOHHGMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float MENLIPDGJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float JAJEDIPFNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float HKLNIMMDFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float OCANFFLFBMH;

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
		private AEKHKFGNMHO ICBHNKKBOCH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int IALOOOFNKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5EDDA00", Offset = "0x5EDC800", VA = "0x185EDDA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int NPLBEOJBCCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE450", Offset = "0x5EDD250", VA = "0x185EDE450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int CLPECOICFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD9A0", Offset = "0x5EDC7A0", VA = "0x185EDD9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BLPBCFGFFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF080", Offset = "0x5EDDE80", VA = "0x185EDF080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GFJFECFHNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF050", Offset = "0x5EDDE50", VA = "0x185EDF050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float OLMGJJFJIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEFB0", Offset = "0x5EDDDB0", VA = "0x185EDEFB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float KAGMONMALEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEFF0", Offset = "0x5EDDDF0", VA = "0x185EDEFF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float OBFCACAMMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEFD0", Offset = "0x5EDDDD0", VA = "0x185EDEFD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float HCAHPMKNCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF010", Offset = "0x5EDDE10", VA = "0x185EDF010")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float AKIKPDJEKPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF030", Offset = "0x5EDDE30", VA = "0x185EDF030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDA20", Offset = "0x5EDC820", VA = "0x185EDDA20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDECE0", Offset = "0x5EDDAE0", VA = "0x185EDECE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE8C0", Offset = "0x5EDD6C0", VA = "0x185EDE8C0")]
		public void PushSample(double POCCBPMKMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE430", Offset = "0x5EDD230", VA = "0x185EDE430")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE470", Offset = "0x5EDD270", VA = "0x185EDE470")]
		private void IMKCLPJCBJI(bool PJCPHDDKADF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE9A0", Offset = "0x5EDD7A0", VA = "0x185EDE9A0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE6D0", Offset = "0x5EDD4D0", VA = "0x185EDE6D0")]
		public void InitData(int CCCEEMEMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDA50", Offset = "0x5EDC850", VA = "0x185EDDA50")]
		private void CCNKJDNKEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EDED10", Offset = "0x5EDDB10", VA = "0x185EDED10")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class LEHHFBIDHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	protected float[] NNFMECCPMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	protected int LFONLOHEHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	protected int HLFCMANHPKF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78A780", Offset = "0x789580", VA = "0x18078A780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LIILMDHCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1506270", Offset = "0x1505070", VA = "0x181506270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float CNAHHDADDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAD10", Offset = "0x5ED9B10", VA = "0x185EDAD10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float FNEDGJBJPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EDADE0", Offset = "0x5ED9BE0", VA = "0x185EDADE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8B40", Offset = "0x5ED7940", VA = "0x185ED8B40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAFC0", Offset = "0x5ED9DC0", VA = "0x185EDAFC0")]
	public LEHHFBIDHHC(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDADF0", Offset = "0x5ED9BF0", VA = "0x185EDADF0")]
	public void PCDNNLIKAEM(int OIHGCLDMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAD20", Offset = "0x5ED9B20", VA = "0x185EDAD20")]
	public void ELHGEDIPCCF(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE24B0", Offset = "0x1FE12B0", VA = "0x181FE24B0")]
	public void AGAHNBPEPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8BF0", Offset = "0x5ED79F0", VA = "0x185ED8BF0")]
	public void PKFMDBFPDNE(float[] CJKEIGLKDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAEB0", Offset = "0x5ED9CB0", VA = "0x185EDAEB0")]
	public void PKFMDBFPDNE(float[] CJKEIGLKDDB, int EOHNOKBBAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAE80", Offset = "0x5ED9C80", VA = "0x185EDAE80")]
	private int PIEHHKCHBPB(int DOJILIOCHKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AEKHKFGNMHO
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int FDILHJPCFNL = 512;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const int DHOLAEBBPGO = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JBOEPIIFBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float[] PPAPOHCJPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public RawImage BCIFDDNKKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float MNMGJOLIKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float PBFOHNKGGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float IJPPNMFLCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float EFOHOCGCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float CAPBLOPPCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Color MMFELGKAMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Color FPLENDEPAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public bool LHKFPEPDGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Color NJOGGGANBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color GBNGADJHHOB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly int JHDDOELAAEH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly int JMHNLHEBIND;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly int OGBKDJMBOBL;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int EHPHOFMFKBE;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int HJBFOHODAAK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int BLKGCDODHLP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int PCJGOOFAAJA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int GDHCBDBHCAI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int NBPICIPIGMN;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int EFACLNCLINO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int BMKGIAFEFMC;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int IHKNCFMMKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9210", Offset = "0x5ED8010", VA = "0x185ED9210")]
	public void MKPIEPBLAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8F10", Offset = "0x5ED7D10", VA = "0x185ED8F10")]
	public void BJCFALPBFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9170", Offset = "0x5ED7F70", VA = "0x185ED9170")]
	public void JFFFOBKEMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9090", Offset = "0x5ED7E90", VA = "0x185ED9090")]
	public void JDEMLJAOKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8D70", Offset = "0x5ED7B70", VA = "0x185ED8D70")]
	public void AMKAOPOOBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ED92D0", Offset = "0x5ED80D0", VA = "0x185ED92D0")]
	public void PAACBNALDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8FB0", Offset = "0x5ED7DB0", VA = "0x185ED8FB0")]
	public void CMADEOILEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ED95A0", Offset = "0x5ED83A0", VA = "0x185ED95A0")]
	public AEKHKFGNMHO()
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
		private MetricIdLookup ONNJNFNLIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IRawMetricsPipeline KJGKFKAFAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IMetricCollectionRegistry MGGLIKGHBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricId JHPFNDICFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int JKLHNEEFLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MetricAccumulateMode LHCNIDMKFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MetricCollectionToken PFKLELGAJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MetricDescription JGKNGMHBFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GraphConfig IACNNJBDPBH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1010", VA = "0x180AE2210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76FBB0", Offset = "0x76E9B0", VA = "0x18076FBB0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9CD0", Offset = "0x5ED8AD0", VA = "0x185ED9CD0")]
		private void KNGKDFEAAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED96E0", Offset = "0x5ED84E0", VA = "0x185ED96E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9F30", Offset = "0x5ED8D30", VA = "0x185ED9F30", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9E20", Offset = "0x5ED8C20", VA = "0x185ED9E20")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9840", Offset = "0x5ED8640", VA = "0x185ED9840")]
		public void Initialize(GraphConfig GPPDHNOIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5ED95D0", Offset = "0x5ED83D0", VA = "0x185ED95D0", Slot = "14")]
		protected override bool ADNBIHAMKEJ(string FHMAGHALDLP = "0.00", [Optional] string HBLDBHCPKND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9740", Offset = "0x5ED8540", VA = "0x185ED9740")]
		public void HandleMetric([In] RawMetric FIHJKFKJHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19DB520", Offset = "0x19DA320", VA = "0x1819DB520", Slot = "4")]
		protected override OLCLDNEHAMM NILEPHKKFND()
		{
			return default(OLCLDNEHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA0A0", Offset = "0x5ED8EA0", VA = "0x185EDA0A0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9740", Offset = "0x5ED8540", VA = "0x185ED9740", Slot = "15")]
		private void KJFBAKNNNHF([In] RawMetric FIHJKFKJHIC)
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
		protected override int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8246A0", Offset = "0x8234A0", VA = "0x1808246A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xF450A0", Offset = "0xF43EA0", VA = "0x180F450A0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "4")]
		protected override OLCLDNEHAMM NILEPHKKFND()
		{
			return default(OLCLDNEHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA0E0", Offset = "0x5ED8EE0", VA = "0x185EDA0E0", Slot = "14")]
		protected override bool ADNBIHAMKEJ(string FHMAGHALDLP = "0.00", [Optional] string HBLDBHCPKND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA1E0", Offset = "0x5ED8FE0", VA = "0x185EDA1E0")]
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
		protected override int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8246A0", Offset = "0x8234A0", VA = "0x1808246A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF450A0", Offset = "0xF43EA0", VA = "0x180F450A0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "4")]
		protected override OLCLDNEHAMM NILEPHKKFND()
		{
			return default(OLCLDNEHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA260", Offset = "0x5ED9060", VA = "0x185EDA260", Slot = "14")]
		protected override bool ADNBIHAMKEJ(string FHMAGHALDLP = "0.00", [Optional] string HBLDBHCPKND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA340", Offset = "0x5ED9140", VA = "0x185EDA340")]
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
		private ProfilerRecorderHandle GGNMCBKLGDE;

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
		private static bool NFHCNLLDMGP;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EFPNHMMBKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF320", Offset = "0x5EDE120", VA = "0x185EDF320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAE2200", Offset = "0xAE1000", VA = "0x180AE2200", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE1010", VA = "0x180AE2210", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "4")]
		protected override OLCLDNEHAMM NILEPHKKFND()
		{
			return default(OLCLDNEHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF160", Offset = "0x5EDDF60", VA = "0x185EDF160", Slot = "14")]
		protected override bool ADNBIHAMKEJ(string FHMAGHALDLP = "0.00", [Optional] string HBLDBHCPKND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF280", Offset = "0x5EDE080", VA = "0x185EDF280")]
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
		protected override int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8246A0", Offset = "0x8234A0", VA = "0x1808246A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF450A0", Offset = "0xF43EA0", VA = "0x180F450A0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CE0", Offset = "0x7E2AE0", VA = "0x1807E3CE0", Slot = "4")]
		protected override OLCLDNEHAMM NILEPHKKFND()
		{
			return default(OLCLDNEHAMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF330", Offset = "0x5EDE130", VA = "0x185EDF330")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDCBC0", Offset = "0x5EDB9C0", VA = "0x185EDCBC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCFA0", Offset = "0x5EDBDA0", VA = "0x185EDCFA0")]
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
		private bool GPPIGLDFKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool EOHGOEOBMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool BAJMJDFNPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private bool MDBBPBIGKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool GAIJMNKIJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool OPBOKDMOEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool NBHDHBPCHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool HOPDLMDPOHG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string NBDOFBAEEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD780", Offset = "0x5EDC580", VA = "0x185EDD780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD920", Offset = "0x5EDC720", VA = "0x185EDD920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string MDHAAALAIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD720", Offset = "0x5EDC520", VA = "0x185EDD720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD7E0", Offset = "0x5EDC5E0", VA = "0x185EDD7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string PPFNMFCEHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD740", Offset = "0x5EDC540", VA = "0x185EDD740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD860", Offset = "0x5EDC660", VA = "0x185EDD860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string OLLDMENPOAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD790", Offset = "0x5EDC590", VA = "0x185EDD790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD960", Offset = "0x5EDC760", VA = "0x185EDD960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string EIIDNIFEBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD730", Offset = "0x5EDC530", VA = "0x185EDD730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD820", Offset = "0x5EDC620", VA = "0x185EDD820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string FJIAHOKALFO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD770", Offset = "0x5EDC570", VA = "0x185EDD770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD8E0", Offset = "0x5EDC6E0", VA = "0x185EDD8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string MEDKOOFCJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD750", Offset = "0x5EDC550", VA = "0x185EDD750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD8A0", Offset = "0x5EDC6A0", VA = "0x185EDD8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string PPALCKEBOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD700", Offset = "0x5EDC500", VA = "0x185EDD700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD7A0", Offset = "0x5EDC5A0", VA = "0x185EDD7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD620", Offset = "0x5EDC420", VA = "0x185EDD620", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD5A0", Offset = "0x5EDC3A0", VA = "0x185EDD5A0")]
		protected string JPJHLGBGHIG(bool BDHJGJNCDOK, TMP_Text JIHPAFENIMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD560", Offset = "0x5EDC360", VA = "0x185EDD560")]
		protected void FEBFGGMNPLO(bool DPFCIOINALF, TMP_Text CJKEIGLKDDB, string GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
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
		protected const string CGNLCKBCKJO = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected double FJLHFIHKIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected double PJCFGKLHEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected double GJHDHDOBKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected double CKADPNKKJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected double GMFAEIAEHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected int HDJINOJPPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double GLKABBGOFGK;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int HBIJFDKAHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode EMAMLECIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool PBBBNOBKABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7C0", Offset = "0xA3A5C0", VA = "0x180A3B7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA3BA90", Offset = "0xA3A890", VA = "0x180A3BA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract OLCLDNEHAMM NILEPHKKFND();

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void EDCIGCBGJJJ();

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEEE720", Offset = "0xEED520", VA = "0x180EEE720", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xEEE720", Offset = "0xEED520", VA = "0x180EEE720")]
		protected void LPMLLIGJGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD070", Offset = "0x5EDBE70", VA = "0x185EDD070", Slot = "10")]
		protected virtual void BALOPCFLPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD210", Offset = "0x5EDC010", VA = "0x185EDD210", Slot = "11")]
		protected virtual void FDMMAAJDOIG(double ENBAPMCALEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD400", Offset = "0x5EDC200", VA = "0x185EDD400", Slot = "12")]
		protected virtual double HDBHACGANNB(MetricAccumulateMode LHCNIDMKFDJ)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD0B0", Offset = "0x5EDBEB0", VA = "0x185EDD0B0")]
		protected bool EBBEKPGOOEK(MetricGraph OIHCLNELMAC, MetricAccumulateMode CPGOEPLHNCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD2D0", Offset = "0x5EDC0D0", VA = "0x185EDD2D0", Slot = "13")]
		protected virtual string GONHDNPOFPA(double GNLEHBFFNFG, string KFLIIANGBGC = "0.00", [Optional] string DCHECODEEHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA340", Offset = "0x5ED9140", VA = "0x185EDA340")]
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
		protected bool JAKLFKJKKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected bool GEPCKBLIEDF;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF870", Offset = "0x5EDE670", VA = "0x185EDF870", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF6C0", Offset = "0x5EDE4C0", VA = "0x185EDF6C0", Slot = "5")]
		protected override void EDCIGCBGJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF370", Offset = "0x5EDE170", VA = "0x185EDF370", Slot = "14")]
		protected virtual bool ADNBIHAMKEJ(string FHMAGHALDLP = "0.00", [Optional] string HBLDBHCPKND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA340", Offset = "0x5ED9140", VA = "0x185EDA340")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DPEPOGOJOEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool NBMNKGOJOAB
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
	RawMetricPayload PACFCGJPELP();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JLNDCJIDDBA : DPEPOGOJOEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static bool NFHCNLLDMGP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> KAGBLPBIHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly MetricId JHPFNDICFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly string ABOEDKHAHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly string HHICHFFJKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private ProfilerRecorder FMODIGHMBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool NIAIJAPAHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool BFGIGCEJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ProfilerRecorderDescription CLBCCDLDINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorderHandle GGNMCBKLGDE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2300", VA = "0x1808A3500", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription GKCMJIJKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x54D7A20", Offset = "0x54D6820", VA = "0x1854D7A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDACA0", Offset = "0x5ED9AA0", VA = "0x185EDACA0")]
	public JLNDCJIDDBA(MetricId JHPFNDICFLL, string ABOEDKHAHLK, string HHICHFFJKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAAD0", Offset = "0x5ED98D0", VA = "0x185EDAAD0", Slot = "6")]
	public RawMetricPayload PACFCGJPELP()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA3B0", Offset = "0x5ED91B0", VA = "0x185EDA3B0")]
	private static ProfilerRecorderHandle FCEJDKIDKHJ(string ABOEDKHAHLK, string HHICHFFJKIF)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA500", Offset = "0x5ED9300", VA = "0x185EDA500")]
	private void HMAMEMPFLIG(bool PJCPHDDKADF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAB70", Offset = "0x5ED9970", VA = "0x185EDAB70")]
	private static MetricDescription PHCNJBIPLHJ(MetricId JHPFNDICFLL, ProfilerRecorderDescription MIOJCOEOPHE)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA800", Offset = "0x5ED9600", VA = "0x185EDA800")]
	private static bool IOMLMNJJKDL(bool PJCPHDDKADF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA390", Offset = "0x5ED9190", VA = "0x185EDA390")]
	private void MOJAKILHAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA390", Offset = "0x5ED9190", VA = "0x185EDA390", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NFGDHHLNMOM : DPEPOGOJOEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<double> HANLFIHMFJG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x764430", Offset = "0x763230", VA = "0x180764430", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF110", Offset = "0x5EDDF10", VA = "0x185EDF110")]
	public NFGDHHLNMOM(Func<double> HANLFIHMFJG, MetricDescription JGKNGMHBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF0A0", Offset = "0x5EDDEA0", VA = "0x185EDF0A0", Slot = "6")]
	public RawMetricPayload PACFCGJPELP()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MKHAOIFDBDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct HJLNFBBLGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string CMDHHEOJBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly string OAFBGCKJDMI;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
		public HJLNFBBLGFD(string ABOEDKHAHLK, string HHICHFFJKIF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MGIDOGAPLJI : IAsyncStateMachine
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
		public MKHAOIFDBDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB030", Offset = "0x5ED9E30", VA = "0x185EDB030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB210", Offset = "0x5EDA010", VA = "0x185EDB210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MetricIdLookup ONNJNFNLIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IRawMetricsPipeline KJGKFKAFAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IMetricCollectionRegistry MGGLIKGHBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Dictionary<MetricId, DPEPOGOJOEC> OHFJHHHFAFK;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly HJLNFBBLGFD[] ONKLIOILLBG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB550", Offset = "0x5EDA350", VA = "0x185EDB550")]
	[GAPOPKHLLNB(OGJCEJIMIKL.GameOnly)]
	private static void GOLHEJOKLGP(OILPPPCALMB IDMCGGBGLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC370", Offset = "0x5EDB170", VA = "0x185EDC370")]
	[Preserve]
	public MKHAOIFDBDI([NMBHAKGIBHG(null)] MetricIdLookup ONNJNFNLIOM, [NMBHAKGIBHG(null)] IRawMetricsPipeline KJGKFKAFAPK, [NMBHAKGIBHG(null)] IMetricCollectionRegistry MGGLIKGHBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB650", Offset = "0x5EDA450", VA = "0x185EDB650")]
	private void KLLHLINEJCO(string MHFNOLECDBM, string HHICHFFJKIF, OLCLDNEHAMM MPDODKLFOGP, Func<double> HANLFIHMFJG, [Out] MetricId JHPFNDICFLL, [Out] DPEPOGOJOEC JIHPAFENIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB720", Offset = "0x5EDA520", VA = "0x185EDB720")]
	private void LECJBLOFDLP(MetricId JHPFNDICFLL, bool JNGLFHJKFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB7C0", Offset = "0x5EDA5C0", VA = "0x185EDB7C0")]
	[AsyncStateMachine(typeof(MGIDOGAPLJI))]
	private Task MGAHJNJKLKD(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB2B0", Offset = "0x5EDA0B0", VA = "0x185EDB2B0")]
	public void FABEIFMIJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB270", Offset = "0x5EDA070", VA = "0x185EDB270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDA370", Offset = "0x5ED9170", VA = "0x185EDA370")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C4F0", VA = "0x18084D6F0")]
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
