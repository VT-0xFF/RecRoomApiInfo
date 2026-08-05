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
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AudioMetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B7A9D0", Offset = "0x6B79DD0", VA = "0x186B7A9D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B7ADB0", Offset = "0x6B7A1B0", VA = "0x186B7ADB0")]
		public AudioMetricDashboard()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum MetricAccumulateMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Average,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		AveragePerSecond,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Max,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Min,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		First,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Sum
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ProfilerMarker GAHJCIMFNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ProfilerMarker MHDPCDKHDFI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int DOEKBPMMFPO = 8;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int IGKPDAEDMFK = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Range(8f, 512f)]
		[Header("Buffer")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HPPOFJNALFH MNMMKGLEFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool MHBPBPBCGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float EOCIKKACBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float EIJOCHFKBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float JDLHLAGFDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float FCGHLGDPPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float LCADKHIMDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[FormerlySerializedAs("graphImageShaderFull")]
		[SerializeField]
		[Space]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[FormerlySerializedAs("graphImageShaderLight")]
		[SerializeField]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Graph Visuals")]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Range(1f, 10f)]
		[SerializeField]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Space]
		[SerializeField]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Space]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private bool higherValueIsBetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private BLBDAKEJHBA HJAGPMDBCJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int FFFHFKBIIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6B80140", Offset = "0x6B7F540", VA = "0x186B80140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int NJJCLGHBKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6B80190", Offset = "0x6B7F590", VA = "0x186B80190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int EHLBCEPEIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6B801B0", Offset = "0x6B7F5B0", VA = "0x186B801B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GBHBJLCNHGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B81820", Offset = "0x6B80C20", VA = "0x186B81820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int KBDMIAJOKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B817F0", Offset = "0x6B80BF0", VA = "0x186B817F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float NJLBOKOOOHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6B81750", Offset = "0x6B80B50", VA = "0x186B81750")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HOHFBFADLHC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B81790", Offset = "0x6B80B90", VA = "0x186B81790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float JONDNMCPEEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B81770", Offset = "0x6B80B70", VA = "0x186B81770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float ALKCNCFFAIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6B817B0", Offset = "0x6B80BB0", VA = "0x186B817B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float MNPCKAGFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6B817D0", Offset = "0x6B80BD0", VA = "0x186B817D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B80160", Offset = "0x6B7F560", VA = "0x186B80160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B81480", Offset = "0x6B80880", VA = "0x186B81480")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B81060", Offset = "0x6B80460", VA = "0x186B81060")]
		public void PushSample(double KMKLFJJOOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B80210", Offset = "0x6B7F610", VA = "0x186B80210")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B80E00", Offset = "0x6B80200", VA = "0x186B80E00")]
		private void LLFBOFPBBKN(bool MCCPONPGBFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B81140", Offset = "0x6B80540", VA = "0x186B81140")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B80C10", Offset = "0x6B80010", VA = "0x186B80C10")]
		public void InitData(int BIMOAMAFACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B80230", Offset = "0x6B7F630", VA = "0x186B80230")]
		private void DFDFJGAKJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B814B0", Offset = "0x6B808B0", VA = "0x186B814B0")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class HPPOFJNALFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected float[] HGFLGDFLNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected int EFMFAAPOPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected int MLMABEGDEJH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x873980", Offset = "0x872D80", VA = "0x180873980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KCFIBABDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A15200", Offset = "0x1A14600", VA = "0x181A15200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float OOCDDEJMPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E6D0", Offset = "0x6B7DAD0", VA = "0x186B7E6D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float DOBCAOKBDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E770", Offset = "0x6B7DB70", VA = "0x186B7E770")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B7A7A0", Offset = "0x6B79BA0", VA = "0x186B7A7A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E980", Offset = "0x6B7DD80", VA = "0x186B7E980")]
	public HPPOFJNALFH(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E6E0", Offset = "0x6B7DAE0", VA = "0x186B7E6E0")]
	public void DJBFGDLPLNJ(int MNHIAKOFNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E7B0", Offset = "0x6B7DBB0", VA = "0x186B7E7B0")]
	public void LFEDLCGBFEL(float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25B2D70", Offset = "0x25B2170", VA = "0x1825B2D70")]
	public void NOFOGIMCBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A850", Offset = "0x6B79C50", VA = "0x186B7A850")]
	public void PALBNIDAIGP(float[] KMCPIOGEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E870", Offset = "0x6B7DC70", VA = "0x186B7E870")]
	public void PALBNIDAIGP(float[] KMCPIOGEAKL, int FBADGOCIFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E780", Offset = "0x6B7DB80", VA = "0x186B7E780")]
	private int KIBFLCEPGCJ(int AGAGKNBDCIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BLBDAKEJHBA
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int GPBPGBDEJAK = 512;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const int FHGIMMIOEME = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int PEHHPMFPKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float[] FBJAOPNIANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public RawImage FNDNJIFOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float KLBCOGINHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float MGJJGPBBIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float AFOIMGDHFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float MCIEKMJJGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float JKCEHFJOAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color OAMBMCKBFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color JNCBCOBOLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JECMHHCJINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color JKNCAIFLBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color AIDHPOBCCNM;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int OMEFEDGDHBH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int IACMJDDCKDF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int DINHKDILNKP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int AOOCFLICDFH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int AGOJCKEMOKO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int GFFKDNMJIDE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int HDOFMCDOCAL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int NGKMMIANLIB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int GLCEMNOCCIL;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int ALLMEKIEBOA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int GCNIEJLNPBF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int IGECFNAPJGF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B1A0", Offset = "0x6B7A5A0", VA = "0x186B7B1A0")]
	public void JCIGEJOGIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B3E0", Offset = "0x6B7A7E0", VA = "0x186B7B3E0")]
	public void OAHNIEKAPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B620", Offset = "0x6B7AA20", VA = "0x186B7B620")]
	public void PFMGOEKEKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B300", Offset = "0x6B7A700", VA = "0x186B7B300")]
	public void MBBLEOMJPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B480", Offset = "0x6B7A880", VA = "0x186B7B480")]
	public void PEBGAHIFLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B260", Offset = "0x6B7A660", VA = "0x186B7B260")]
	public void KJBDHBHIPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B0C0", Offset = "0x6B7A4C0", VA = "0x186B7B0C0")]
	public void FEAMCEOLPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B8F0", Offset = "0x6B7ACF0", VA = "0x186B7B8F0")]
	public BLBDAKEJHBA()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MetricIdLookup PHDPBMBCCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IRawMetricsPipeline KMBEOBBCFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IMetricCollectionRegistry NBLDJBHMCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricId CEGHEDHPBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int EBNKIKJLNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MetricAccumulateMode BGFOCCOBBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricCollectionToken IAIFDAAIBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MetricDescription HANCOMPGDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GraphConfig IKHILGPNJAB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xEB96D0", Offset = "0xEB8AD0", VA = "0x180EB96D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x856040", Offset = "0x855440", VA = "0x180856040", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B7BA90", Offset = "0x6B7AE90", VA = "0x186B7BA90")]
		private void GMLBCOAAJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B920", Offset = "0x6B7AD20", VA = "0x186B7B920", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C290", Offset = "0x6B7B690", VA = "0x186B7C290", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C180", Offset = "0x6B7B580", VA = "0x186B7C180")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B7BCE0", Offset = "0x6B7B0E0", VA = "0x186B7BCE0")]
		public void Initialize(GraphConfig MGFNPCFNKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B980", Offset = "0x6B7AD80", VA = "0x186B7B980", Slot = "14")]
		protected override bool BDHALHDOICL(string JDEHENJFOIG = "0.00", [Optional] string DABCGBFMDGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6B7BBE0", Offset = "0x6B7AFE0", VA = "0x186B7BBE0")]
		public void HandleMetric([In] RawMetric EHJPOBLCMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E27480", Offset = "0x5E26880", VA = "0x185E27480", Slot = "4")]
		protected override MNLGAFOGCBK GLPDKODHIJD()
		{
			return default(MNLGAFOGCBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C400", Offset = "0x6B7B800", VA = "0x186B7C400")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B7BBE0", Offset = "0x6B7AFE0", VA = "0x186B7BBE0", Slot = "15")]
		private void JLLJPIPAANK([In] RawMetric EHJPOBLCMDJ)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xBD4420", Offset = "0xBD3820", VA = "0x180BD4420", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1393D10", Offset = "0x1393110", VA = "0x181393D10", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "4")]
		protected override MNLGAFOGCBK GLPDKODHIJD()
		{
			return default(MNLGAFOGCBK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E420", Offset = "0x6B7D820", VA = "0x186B7E420", Slot = "14")]
		protected override bool BDHALHDOICL(string JDEHENJFOIG = "0.00", [Optional] string DABCGBFMDGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E520", Offset = "0x6B7D920", VA = "0x186B7E520")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xBD4420", Offset = "0xBD3820", VA = "0x180BD4420", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1393D10", Offset = "0x1393110", VA = "0x181393D10", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B640", Offset = "0x5D9AA40", VA = "0x185D9B640", Slot = "4")]
		protected override MNLGAFOGCBK GLPDKODHIJD()
		{
			return default(MNLGAFOGCBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E5A0", Offset = "0x6B7D9A0", VA = "0x186B7E5A0", Slot = "14")]
		protected override bool BDHALHDOICL(string JDEHENJFOIG = "0.00", [Optional] string DABCGBFMDGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E680", Offset = "0x6B7DA80", VA = "0x186B7E680")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[Header("Profiling Metric")]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ProfilerRecorderHandle GANIBOPMADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Accumulation")]
		[SerializeField]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static bool OEFBBEHKIGC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HLHGABAFHLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6B81A00", Offset = "0x6B80E00", VA = "0x186B81A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xEB96C0", Offset = "0xEB8AC0", VA = "0x180EB96C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xEB96D0", Offset = "0xEB8AD0", VA = "0x180EB96D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B640", Offset = "0x5D9AA40", VA = "0x185D9B640", Slot = "4")]
		protected override MNLGAFOGCBK GLPDKODHIJD()
		{
			return default(MNLGAFOGCBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B81840", Offset = "0x6B80C40", VA = "0x186B81840", Slot = "14")]
		protected override bool BDHALHDOICL(string JDEHENJFOIG = "0.00", [Optional] string DABCGBFMDGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B81960", Offset = "0x6B80D60", VA = "0x186B81960")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Header("Random Range")]
		[SerializeField]
		[Range(0f, 99f)]
		private float randomMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[Range(1f, 100f)]
		private float randomMax;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xBD4420", Offset = "0xBD3820", VA = "0x180BD4420", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1393D10", Offset = "0x1393110", VA = "0x181393D10", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD11460", Offset = "0xD10860", VA = "0x180D11460", Slot = "4")]
		protected override MNLGAFOGCBK GLPDKODHIJD()
		{
			return default(MNLGAFOGCBK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B81A10", Offset = "0x6B80E10", VA = "0x186B81A10")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F360", Offset = "0x6B7E760", VA = "0x186B7F360")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F740", Offset = "0x6B7EB40", VA = "0x186B7F740")]
		public MetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Metric Text")]
		[SerializeField]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool KAMLFNBGLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool DMGJFGDHLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool ANCPJDDPCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool CMAPFJEAMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool JMLFJNJOGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private bool KCEOKPNCBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private bool PLPIPGNEPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool CJLHKGIFFPD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string HJOEKOFHHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FF20", Offset = "0x6B7F320", VA = "0x186B7FF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B800C0", Offset = "0x6B7F4C0", VA = "0x186B800C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string IAKIPNKHFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FEC0", Offset = "0x6B7F2C0", VA = "0x186B7FEC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FF80", Offset = "0x6B7F380", VA = "0x186B7FF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string AAALOCPENIL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FEE0", Offset = "0x6B7F2E0", VA = "0x186B7FEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6B80000", Offset = "0x6B7F400", VA = "0x186B80000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string NNEKEJBGFNE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FF30", Offset = "0x6B7F330", VA = "0x186B7FF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6B80100", Offset = "0x6B7F500", VA = "0x186B80100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string FJHICJIDJEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FED0", Offset = "0x6B7F2D0", VA = "0x186B7FED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FFC0", Offset = "0x6B7F3C0", VA = "0x186B7FFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string NFHAFGNCCBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FF10", Offset = "0x6B7F310", VA = "0x186B7FF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6B80080", Offset = "0x6B7F480", VA = "0x186B80080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string AMBADBKMGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FEF0", Offset = "0x6B7F2F0", VA = "0x186B7FEF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6B80040", Offset = "0x6B7F440", VA = "0x186B80040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string HPOPOBEHOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FEA0", Offset = "0x6B7F2A0", VA = "0x186B7FEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6B7FF40", Offset = "0x6B7F340", VA = "0x186B7FF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FDC0", Offset = "0x6B7F1C0", VA = "0x186B7FDC0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FD00", Offset = "0x6B7F100", VA = "0x186B7FD00")]
		protected string DJDLGGAHOOC(bool EPPDEELCHOO, TMP_Text LMADGEINEAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FD80", Offset = "0x6B7F180", VA = "0x186B7FD80")]
		protected void GMKMKGEELFG(bool FGBMBNDFBDM, TMP_Text KMCPIOGEAKL, string OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected const string LDCDEGGBBPE = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double HNBFOACCGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double ODKLKHNGPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected double ELGMELOAPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double FAAMFCNGBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double NDAODNMFBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected int NDDNFCLEEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double IBEJOHGBMLC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int GDOJKPFOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode PELKAGPKMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool EMPGDGGEECB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2C80", Offset = "0x9F2080", VA = "0x1809F2C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAEEFE0", Offset = "0xAEE3E0", VA = "0x180AEEFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract MNLGAFOGCBK GLPDKODHIJD();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void KFDCPJFJMLA();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1321F40", Offset = "0x1321340", VA = "0x181321F40", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1321F40", Offset = "0x1321340", VA = "0x181321F40")]
		protected void JEGMGBLDBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FA00", Offset = "0x6B7EE00", VA = "0x186B7FA00", Slot = "10")]
		protected virtual void GLLALDHNEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F940", Offset = "0x6B7ED40", VA = "0x186B7F940", Slot = "11")]
		protected virtual void DPJIGAICLPE(double NEKPPFLKMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FBA0", Offset = "0x6B7EFA0", VA = "0x186B7FBA0", Slot = "12")]
		protected virtual double PDDJPIADAGG(MetricAccumulateMode BGFOCCOBBKK)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B7FA40", Offset = "0x6B7EE40", VA = "0x186B7FA40")]
		protected bool IBKGNMNEFKD(MetricGraph KHHCBCFNIBN, MetricAccumulateMode KBNNEODEGCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F810", Offset = "0x6B7EC10", VA = "0x186B7F810", Slot = "13")]
		protected virtual string ACOHAJAEIEA(double OBEEJPGJPFD, string DNDIAOIJGOO = "0.00", [Optional] string NCNLCAJFEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E680", Offset = "0x6B7DA80", VA = "0x186B7E680")]
		protected MetricGraphDriverBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[Header("Graph and Text")]
		[FormerlySerializedAs("targetGraph")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		protected bool IBLIEIFHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected bool CFMDADKEHPO;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6B81F50", Offset = "0x6B81350", VA = "0x186B81F50", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6B81DA0", Offset = "0x6B811A0", VA = "0x186B81DA0", Slot = "5")]
		protected override void KFDCPJFJMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B81A50", Offset = "0x6B80E50", VA = "0x186B81A50", Slot = "14")]
		protected virtual bool BDHALHDOICL(string JDEHENJFOIG = "0.00", [Optional] string DABCGBFMDGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E680", Offset = "0x6B7DA80", VA = "0x186B7E680")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NHKOHIMAMGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BABCNDCHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	RawMetricPayload JFMHHLDGBLO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LPBEINILMAN : NHKOHIMAMGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool OEFBBEHKIGC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> KHODEFGDCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly string FDAGCBCAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly string DJCGFPAOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorder ABLNMOONJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool BPDHBAGIFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool GPDEMJCPNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ProfilerRecorderDescription OACCMIHPBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorderHandle GANIBOPMADD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BABCNDCHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89D6E0", Offset = "0x89CAE0", VA = "0x18089D6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA9F640", Offset = "0xA9EA40", VA = "0x180A9F640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription KJFHDADBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B7EAD0", Offset = "0x6B7DED0", VA = "0x186B7EAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F2E0", Offset = "0x6B7E6E0", VA = "0x186B7F2E0")]
	public LPBEINILMAN(MetricDescription HANCOMPGDGK, string FDAGCBCAJON, string DJCGFPAOCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EAF0", Offset = "0x6B7DEF0", VA = "0x186B7EAF0", Slot = "6")]
	public RawMetricPayload JFMHHLDGBLO()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F0E0", Offset = "0x6B7E4E0", VA = "0x186B7F0E0")]
	private static ProfilerRecorderHandle MLJIGOIABPA(string FDAGCBCAJON, string DJCGFPAOCPN)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EB90", Offset = "0x6B7DF90", VA = "0x186B7EB90")]
	private void LJGILJIDLOB(bool MCCPONPGBFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EE10", Offset = "0x6B7E210", VA = "0x186B7EE10")]
	private static bool MBHJNFEPHNK(bool MCCPONPGBFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EAB0", Offset = "0x6B7DEB0", VA = "0x186B7EAB0")]
	private void HPDGBCGHAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EAB0", Offset = "0x6B7DEB0", VA = "0x186B7EAB0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KFNAIGJGDJE : NHKOHIMAMGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<double> MGONEOHGHPM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BABCNDCHPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EA60", Offset = "0x6B7DE60", VA = "0x186B7EA60")]
	public KFNAIGJGDJE(Func<double> MGONEOHGHPM, MetricDescription HANCOMPGDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E9F0", Offset = "0x6B7DDF0", VA = "0x186B7E9F0", Slot = "6")]
	public RawMetricPayload JFMHHLDGBLO()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPBEJHDMKJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct BLGJALDMBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly string FKEDMONPGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string PDLOAHJAIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly MNLGAFOGCBK DKPBJPCJFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly string PJBDAJFKNKM;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x25B8330", Offset = "0x25B7730", VA = "0x1825B8330")]
		public BLGJALDMBEC(string FDAGCBCAJON, string DJCGFPAOCPN, MNLGAFOGCBK IFLPHDMMGHM = MNLGAFOGCBK.TimeNanoseconds, [Optional] string FPOMPHAMBIN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BHMHPGCFJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public DPBEJHDMKJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7AE80", Offset = "0x6B7A280", VA = "0x186B7AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B060", Offset = "0x6B7A460", VA = "0x186B7B060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MetricIdLookup PHDPBMBCCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IRawMetricsPipeline KMBEOBBCFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IMetricCollectionRegistry NBLDJBHMCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CancellationTokenSource CJDNALLBGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<MetricId, NHKOHIMAMGO> JEPNMABCFBE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly BLGJALDMBEC[] CDFKLCMDLAO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C590", Offset = "0x6B7B990", VA = "0x186B7C590")]
	[EAMANMFIEOM(NBICBCAKHEI.GameOnly)]
	private static void GEKCJCOEJCI(NFLAEHJHNPL KPKAOJGGAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DB10", Offset = "0x6B7CF10", VA = "0x186B7DB10")]
	[Preserve]
	public DPBEJHDMKJN([NCPIDBJOPHL(null)] MetricIdLookup PHDPBMBCCME, [NCPIDBJOPHL(null)] IRawMetricsPipeline KMBEOBBCFFB, [NCPIDBJOPHL(null)] IMetricCollectionRegistry NBLDJBHMCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C440", Offset = "0x6B7B840", VA = "0x186B7C440")]
	private void AOBLNHFNKJI(string COHNCDHCPFN, string DJCGFPAOCPN, MNLGAFOGCBK KDPMDKJMOFO, Func<double> MGONEOHGHPM, [Out] MetricId CEGHEDHPBJK, [Out] NHKOHIMAMGO LMADGEINEAF, [Optional] string FPOMPHAMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CA20", Offset = "0x6B7BE20", VA = "0x186B7CA20")]
	private void PAIHKGHGKEM(MetricId CEGHEDHPBJK, bool ACMDMHBHKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C690", Offset = "0x6B7BA90", VA = "0x186B7C690")]
	[AsyncStateMachine(typeof(BHMHPGCFJPL))]
	private Task HJAOCHPHIBC(CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C780", Offset = "0x6B7BB80", VA = "0x186B7C780")]
	public void LBFLPPAAKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C550", Offset = "0x6B7B950", VA = "0x186B7C550", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Profiling.Configs
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class GraphConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E6B0", Offset = "0x6B7DAB0", VA = "0x186B7E6B0")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x931280", Offset = "0x930680", VA = "0x180931280")]
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
