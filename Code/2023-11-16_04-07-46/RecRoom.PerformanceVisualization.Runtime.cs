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
		[Cpp2IlInjected.Address(RVA = "0x6012F60", Offset = "0x6011F60", VA = "0x186012F60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6013340", Offset = "0x6012340", VA = "0x186013340")]
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
		private ProfilerMarker AFLKDFDDGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ProfilerMarker BDMJMCNOKLO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int FCIJOODMBPD = 8;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int DGKFDMKHPHC = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Range(8f, 512f)]
		[Header("Buffer")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CICLAGPNDDG LKEOHDOLFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool JDCHEKAOEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float ABFOOABNNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float OJNEENMPLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float KNKKENLHOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float LAGILEIJOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float ALIKAKDIDNK;

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
		private CEHKNCNGMEH ANLDLLHOOCA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int EJBPAKADEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6018170", Offset = "0x6017170", VA = "0x186018170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int DPENODFLHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6018D60", Offset = "0x6017D60", VA = "0x186018D60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int PGOAMAKKACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6018FE0", Offset = "0x6017FE0", VA = "0x186018FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KOKNEBCJOAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6019800", Offset = "0x6018800", VA = "0x186019800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int CEKFBIAGALD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x60197D0", Offset = "0x60187D0", VA = "0x1860197D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float KBBJEFDMDAE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6019730", Offset = "0x6018730", VA = "0x186019730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float OCBOLBDMEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6019770", Offset = "0x6018770", VA = "0x186019770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float KPEEAMIMNFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6019750", Offset = "0x6018750", VA = "0x186019750")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float LLOKKEHNKNK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6019790", Offset = "0x6018790", VA = "0x186019790")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float NLDBNAKNLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x60197B0", Offset = "0x60187B0", VA = "0x1860197B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6018120", Offset = "0x6017120", VA = "0x186018120")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6019460", Offset = "0x6018460", VA = "0x186019460")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6019040", Offset = "0x6018040", VA = "0x186019040")]
		public void PushSample(double KEAGHDHJOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6018150", Offset = "0x6017150", VA = "0x186018150")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6018D80", Offset = "0x6017D80", VA = "0x186018D80")]
		private void MNOKBIFAMIJ(bool OFOIDDLLFEI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6019120", Offset = "0x6018120", VA = "0x186019120")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6018B70", Offset = "0x6017B70", VA = "0x186018B70")]
		public void InitData(int NONLCLPNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6018190", Offset = "0x6017190", VA = "0x186018190")]
		private void GBIHBAGPKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6019490", Offset = "0x6018490", VA = "0x186019490")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class CICLAGPNDDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected float[] MNCCKEICKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected int ILPBPGDHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected int AGLAJIDEGHD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x798730", Offset = "0x797730", VA = "0x180798730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IMIICCEIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15A0270", Offset = "0x159F270", VA = "0x1815A0270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float FPLCLJBCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6013F10", Offset = "0x6012F10", VA = "0x186013F10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float KDFOCLICMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6013D60", Offset = "0x6012D60", VA = "0x186013D60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6012D30", Offset = "0x6011D30", VA = "0x186012D30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6013F20", Offset = "0x6012F20", VA = "0x186013F20")]
	public CICLAGPNDDG(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6013E80", Offset = "0x6012E80", VA = "0x186013E80")]
	public void LAMCCMJDAAN(int GJIOEFAFGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6013CA0", Offset = "0x6012CA0", VA = "0x186013CA0")]
	public void JFEMJGAKKHL(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20A4220", Offset = "0x20A3220", VA = "0x1820A4220")]
	public void GDIPNDKIBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6012DE0", Offset = "0x6011DE0", VA = "0x186012DE0")]
	public void JJBOJIGHHJE(float[] MNNJBJHGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6013D70", Offset = "0x6012D70", VA = "0x186013D70")]
	public void JJBOJIGHHJE(float[] MNNJBJHGADP, int KBOKJIMJFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6013C70", Offset = "0x6012C70", VA = "0x186013C70")]
	private int CFLICHNCNBO(int NFJIPMHILEL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CEHKNCNGMEH
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int BGNJMKFGEAF = 512;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const int NBEABKNJCPB = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int GNKBIPJJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float[] PHKECCFGMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public RawImage JKCICABKCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float GKAKOEFMAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float OJDDFEFJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float DFJPLGLENMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float HDLHEIGKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float GDLFOLOBPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color CKLOLFBMHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color PAOGJBHDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool KJGNMFNILPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color MBFACFFHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color BDFOLLGINHO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int DBMIOMCNNBJ;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int DHCMBOMEAJO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int KDJIMFFKDJK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int PMFIGDFNBII;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int ONLDLOJHHPD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int EFIJECJMGHP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int BIAKNAFDOGL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int IKBKNPMFKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int LAOFPKCPAKH;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int IFBMHFCFOLG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int NGFDLLKFPLB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int ACBPGIBKDEA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6013950", Offset = "0x6012950", VA = "0x186013950")]
	public void NCJHDOCGJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60135B0", Offset = "0x60125B0", VA = "0x1860135B0")]
	public void IIMCGLCNKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60138B0", Offset = "0x60128B0", VA = "0x1860138B0")]
	public void MCMOFEGNFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60136F0", Offset = "0x60126F0", VA = "0x1860136F0")]
	public void JPMMCIHIDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6013410", Offset = "0x6012410", VA = "0x186013410")]
	public void GDCBJMDHGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6013650", Offset = "0x6012650", VA = "0x186013650")]
	public void JICAAFAFFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60137D0", Offset = "0x60127D0", VA = "0x1860137D0")]
	public void KFPIDCDEMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6013C40", Offset = "0x6012C40", VA = "0x186013C40")]
	public CEHKNCNGMEH()
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
		private MetricIdLookup ACMCBBFHPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IRawMetricsPipeline NGJDJLCCDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IMetricCollectionRegistry OGGPBGNGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricId AMMBAFKPLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int IOIFGFOIMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MetricAccumulateMode CGIBNPHLGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricCollectionToken PDIBILKHEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MetricDescription CJIODBCIBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GraphConfig PIFLFHOJNEA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB64780", Offset = "0xB63780", VA = "0x180B64780", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x775F00", Offset = "0x774F00", VA = "0x180775F00", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6014580", Offset = "0x6013580", VA = "0x186014580")]
		private void LDOJJGMJGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6013F90", Offset = "0x6012F90", VA = "0x186013F90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60147E0", Offset = "0x60137E0", VA = "0x1860147E0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60146D0", Offset = "0x60136D0", VA = "0x1860146D0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60140F0", Offset = "0x60130F0", VA = "0x1860140F0")]
		public void Initialize(GraphConfig DFPCLDBDKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6014950", Offset = "0x6013950", VA = "0x186014950", Slot = "14")]
		protected override bool PHPPPFEACDC(string JLHMAGIOEGE = "0.00", [Optional] string EBCDDFDPLDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x6012FF0", VA = "0x186013FF0")]
		public void HandleMetric([In] RawMetric BEBOPMHDGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1A9D710", Offset = "0x1A9C710", VA = "0x181A9D710", Slot = "4")]
		protected override IHIMFGDKHCJ OBCAAINCILB()
		{
			return default(IHIMFGDKHCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6014A60", Offset = "0x6013A60", VA = "0x186014A60")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x6012FF0", VA = "0x186013FF0", Slot = "15")]
		private void OEEJOILIEEI([In] RawMetric BEBOPMHDGOF)
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
		protected override int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x878F50", Offset = "0x877F50", VA = "0x180878F50", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xFB4940", Offset = "0xFB3940", VA = "0x180FB4940", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "4")]
		protected override IHIMFGDKHCJ OBCAAINCILB()
		{
			return default(IHIMFGDKHCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6014B60", Offset = "0x6013B60", VA = "0x186014B60", Slot = "14")]
		protected override bool PHPPPFEACDC(string JLHMAGIOEGE = "0.00", [Optional] string EBCDDFDPLDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6014C60", Offset = "0x6013C60", VA = "0x186014C60")]
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
		protected override int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x878F50", Offset = "0x877F50", VA = "0x180878F50", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xFB4940", Offset = "0xFB3940", VA = "0x180FB4940", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x834600", Offset = "0x833600", VA = "0x180834600", Slot = "4")]
		protected override IHIMFGDKHCJ OBCAAINCILB()
		{
			return default(IHIMFGDKHCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6014CE0", Offset = "0x6013CE0", VA = "0x186014CE0", Slot = "14")]
		protected override bool PHPPPFEACDC(string JLHMAGIOEGE = "0.00", [Optional] string EBCDDFDPLDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6014DC0", Offset = "0x6013DC0", VA = "0x186014DC0")]
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
		private ProfilerRecorderHandle FLNKDKLCNCD;

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
		private static bool HFLLGLBDGFG;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool MEEPMFDBAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x60199E0", Offset = "0x60189E0", VA = "0x1860199E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB64770", Offset = "0xB63770", VA = "0x180B64770", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB64780", Offset = "0xB63780", VA = "0x180B64780", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x834600", Offset = "0x833600", VA = "0x180834600", Slot = "4")]
		protected override IHIMFGDKHCJ OBCAAINCILB()
		{
			return default(IHIMFGDKHCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6019820", Offset = "0x6018820", VA = "0x186019820", Slot = "14")]
		protected override bool PHPPPFEACDC(string JLHMAGIOEGE = "0.00", [Optional] string EBCDDFDPLDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6019940", Offset = "0x6018940", VA = "0x186019940")]
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
		protected override int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x878F50", Offset = "0x877F50", VA = "0x180878F50", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xFB4940", Offset = "0xFB3940", VA = "0x180FB4940", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83AD30", Offset = "0x839D30", VA = "0x18083AD30", Slot = "4")]
		protected override IHIMFGDKHCJ OBCAAINCILB()
		{
			return default(IHIMFGDKHCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60199F0", Offset = "0x60189F0", VA = "0x1860199F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6017340", Offset = "0x6016340", VA = "0x186017340")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6017720", Offset = "0x6016720", VA = "0x186017720")]
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
		private bool MIJCKAICLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool GFANKAIOHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool NMPFBFPCMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool DHAALOKAMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool BELFNLNOGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private bool JKJCDKJHHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private bool CBHJNHAPEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool DNMPDNNMKOJ;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string FMKHIKJPGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6017F00", Offset = "0x6016F00", VA = "0x186017F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x60180A0", Offset = "0x60170A0", VA = "0x1860180A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string PNCIMBBOLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6017EA0", Offset = "0x6016EA0", VA = "0x186017EA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6017F60", Offset = "0x6016F60", VA = "0x186017F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string MONEALNLPIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6017EC0", Offset = "0x6016EC0", VA = "0x186017EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6017FE0", Offset = "0x6016FE0", VA = "0x186017FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string JNFMKPBCHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6017F10", Offset = "0x6016F10", VA = "0x186017F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60180E0", Offset = "0x60170E0", VA = "0x1860180E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string IKDDODJMGON
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6017EB0", Offset = "0x6016EB0", VA = "0x186017EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6017FA0", Offset = "0x6016FA0", VA = "0x186017FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string JLMHPMLMEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6017EF0", Offset = "0x6016EF0", VA = "0x186017EF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6018060", Offset = "0x6017060", VA = "0x186018060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string FOGDBDAEKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6017ED0", Offset = "0x6016ED0", VA = "0x186017ED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6018020", Offset = "0x6017020", VA = "0x186018020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string COOKEIHPKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6017E80", Offset = "0x6016E80", VA = "0x186017E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6017F20", Offset = "0x6016F20", VA = "0x186017F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6017DA0", Offset = "0x6016DA0", VA = "0x186017DA0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6017CE0", Offset = "0x6016CE0", VA = "0x186017CE0")]
		protected string CNDHKIJKCFL(bool AKMPBBNMGAB, TMP_Text ONDDMEPBDDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6017D60", Offset = "0x6016D60", VA = "0x186017D60")]
		protected void GMHEDIMEFHA(bool DNFENGEHCJI, TMP_Text MNNJBJHGADP, string APPJEOKOGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
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
		protected const string BIJFDNFNDOG = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double CHMPDJPHDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double CMHLNADLIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected double OCGDDGFGPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double COBEDEKOINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double IAAIHKLHDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected int HIBCILGCKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double GPEICDAAKGJ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int FOFMDOEMPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode BBEJCPPFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool MFAPPIEGGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xABB420", Offset = "0xABA420", VA = "0x180ABB420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xABB700", Offset = "0xABA700", VA = "0x180ABB700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract IHIMFGDKHCJ OBCAAINCILB();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void NBGNFJPOKFH();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF69370", Offset = "0xF68370", VA = "0x180F69370", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xF69370", Offset = "0xF68370", VA = "0x180F69370")]
		protected void JCABBFHIDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6017CA0", Offset = "0x6016CA0", VA = "0x186017CA0", Slot = "10")]
		protected virtual void NPOOOOHCLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60177F0", Offset = "0x60167F0", VA = "0x1860177F0", Slot = "11")]
		protected virtual void CPGKAHOHMCO(double DPICLLHLLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6017B40", Offset = "0x6016B40", VA = "0x186017B40", Slot = "12")]
		protected virtual double LLOJMJANNLG(MetricAccumulateMode CGIBNPHLGFI)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60178B0", Offset = "0x60168B0", VA = "0x1860178B0")]
		protected bool DJNCCOFNFAM(MetricGraph AEKBFOOKJCC, MetricAccumulateMode PMFIIBOFEAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6017A10", Offset = "0x6016A10", VA = "0x186017A10", Slot = "13")]
		protected virtual string EOBGKKOOBDC(double APPJEOKOGAK, string DBCIFBLNDEG = "0.00", [Optional] string LPAIKHAHLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6014DC0", Offset = "0x6013DC0", VA = "0x186014DC0")]
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
		protected bool DAAPAMPANHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected bool KAMCGNGHBFB;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6019BE0", Offset = "0x6018BE0", VA = "0x186019BE0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6019A30", Offset = "0x6018A30", VA = "0x186019A30", Slot = "5")]
		protected override void NBGNFJPOKFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6019C60", Offset = "0x6018C60", VA = "0x186019C60", Slot = "14")]
		protected virtual bool PHPPPFEACDC(string JLHMAGIOEGE = "0.00", [Optional] string EBCDDFDPLDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6014DC0", Offset = "0x6013DC0", VA = "0x186014DC0")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IPFNPKLMJLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool LODDGFKFEOG
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
	RawMetricPayload IAPDEJHGELL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GBBAGCDNJBJ : IPFNPKLMJLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool HFLLGLBDGFG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> AEEAFLPDGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MetricId AMMBAFKPLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly string CLFLNDDPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string IKHHACMOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private ProfilerRecorder LPDPMBJFEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool NNFDEKJFAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool PAJMKFDFGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorderDescription NALINPACHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private ProfilerRecorderHandle FLNKDKLCNCD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F2680", Offset = "0x8F1680", VA = "0x1808F2680", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription ALLDNDPKNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x55E01B0", Offset = "0x55DF1B0", VA = "0x1855E01B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6015700", Offset = "0x6014700", VA = "0x186015700")]
	public GBBAGCDNJBJ(MetricId AMMBAFKPLLD, string CLFLNDDPOFC, string IKHHACMOKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6014E10", Offset = "0x6013E10", VA = "0x186014E10", Slot = "6")]
	public RawMetricPayload IAPDEJHGELL()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6015200", Offset = "0x6014200", VA = "0x186015200")]
	private static ProfilerRecorderHandle LAMNMLHHJOJ(string CLFLNDDPOFC, string IKHHACMOKCE)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6015350", Offset = "0x6014350", VA = "0x186015350")]
	private void PPNNJOPCBAF(bool OFOIDDLLFEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6014EB0", Offset = "0x6013EB0", VA = "0x186014EB0")]
	private static MetricDescription IFBDHIKOPML(MetricId AMMBAFKPLLD, ProfilerRecorderDescription BIOOGGHNKKB)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6014F30", Offset = "0x6013F30", VA = "0x186014F30")]
	private static bool KOGIELJAOGM(bool OFOIDDLLFEI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6014DF0", Offset = "0x6013DF0", VA = "0x186014DF0")]
	private void OGGIAMONGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6014DF0", Offset = "0x6013DF0", VA = "0x186014DF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EHBHIBBPKMM : IPFNPKLMJLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<double> BJEJFOKGPIC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7775F0", Offset = "0x7765F0", VA = "0x1807775F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6014B10", Offset = "0x6013B10", VA = "0x186014B10")]
	public EHBHIBBPKMM(Func<double> BJEJFOKGPIC, MetricDescription CJIODBCIBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6014AA0", Offset = "0x6013AA0", VA = "0x186014AA0", Slot = "6")]
	public RawMetricPayload IAPDEJHGELL()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MFHJCLFBEED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct DGBEPICOPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string CGGGCIOAOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly string FFFHPEJKCBD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
		public DGBEPICOPGF(string CLFLNDDPOFC, string IKHHACMOKCE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LAPNHGLLPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public MFHJCLFBEED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6015790", Offset = "0x6014790", VA = "0x186015790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6015970", Offset = "0x6014970", VA = "0x186015970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MetricIdLookup ACMCBBFHPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IRawMetricsPipeline NGJDJLCCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IMetricCollectionRegistry OGGPBGNGLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Dictionary<MetricId, IPFNPKLMJLI> DHIBIMEPCBO;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly DGBEPICOPGF[] IFBAPFHMABH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6015C70", Offset = "0x6014C70", VA = "0x186015C70")]
	[PKDJMILODMH(OMIAJJHDDGO.GameOnly)]
	private static void MANCEHNPLLH(EIABFOFJCDK ENBCIOEOBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6016AD0", Offset = "0x6015AD0", VA = "0x186016AD0")]
	[Preserve]
	public MFHJCLFBEED([KHIPNIHHNOH(null)] MetricIdLookup ACMCBBFHPLA, [KHIPNIHHNOH(null)] IRawMetricsPipeline NGJDJLCCDFD, [KHIPNIHHNOH(null)] IMetricCollectionRegistry OGGPBGNGLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60159D0", Offset = "0x60149D0", VA = "0x1860159D0")]
	private void CEEELCOOIMF(string NDOECNLHKGD, string IKHHACMOKCE, IHIMFGDKHCJ LEPOLNFCGPE, Func<double> BJEJFOKGPIC, [Out] MetricId AMMBAFKPLLD, [Out] IPFNPKLMJLI ONDDMEPBDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6015BD0", Offset = "0x6014BD0", VA = "0x186015BD0")]
	private void IKGKPCKKILE(MetricId AMMBAFKPLLD, bool PFFIMDOEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6015AE0", Offset = "0x6014AE0", VA = "0x186015AE0")]
	[AsyncStateMachine(typeof(LAPNHGLLPOI))]
	private Task FKCMJPOCNDO(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6015D70", Offset = "0x6014D70", VA = "0x186015D70")]
	public void OCGDPPCMBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6015AA0", Offset = "0x6014AA0", VA = "0x186015AA0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6015770", Offset = "0x6014770", VA = "0x186015770")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x802230", Offset = "0x801230", VA = "0x180802230")]
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
