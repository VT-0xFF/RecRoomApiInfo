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
		[Cpp2IlInjected.Address(RVA = "0x6205AA0", Offset = "0x62048A0", VA = "0x186205AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6205E80", Offset = "0x6204C80", VA = "0x186205E80")]
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
		private ProfilerMarker BPCEPECBDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ProfilerMarker LKOBCELPHCI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int FOIMMNFPENB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int OMABMADHACH = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Range(8f, 512f)]
		[Header("Buffer")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GLILCLJKFPF LEKFGEBLLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool INIAHFPAIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float DPKHJCHDBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float JGJMLFCLMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float HNNPEGNLBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float AHAOPFNJFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float MMENAJBCFFC;

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
		private AAOPEOOJAOP IABINCDNALH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int NEOILGGNEIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x620A1F0", Offset = "0x6208FF0", VA = "0x18620A1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int GHKOMGPCFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x620B0C0", Offset = "0x6209EC0", VA = "0x18620B0C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int MFPFMNPLAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x620B060", Offset = "0x6209E60", VA = "0x18620B060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LLLNMOIFOLB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x620B8A0", Offset = "0x620A6A0", VA = "0x18620B8A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int PBPLGKFIBBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x620B870", Offset = "0x620A670", VA = "0x18620B870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float HGPHGGLBNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x620B7D0", Offset = "0x620A5D0", VA = "0x18620B7D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HCNNFPCBHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x620B810", Offset = "0x620A610", VA = "0x18620B810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float KALKPOANJIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x620B7F0", Offset = "0x620A5F0", VA = "0x18620B7F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PMLIJJJEPGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x620B830", Offset = "0x620A630", VA = "0x18620B830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float DEBLKOHIFBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x620B850", Offset = "0x620A650", VA = "0x18620B850")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x620A1C0", Offset = "0x6208FC0", VA = "0x18620A1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x620B500", Offset = "0x620A300", VA = "0x18620B500")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x620B0E0", Offset = "0x6209EE0", VA = "0x18620B0E0")]
		public void PushSample(double FHEGFAFBNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x620A210", Offset = "0x6209010", VA = "0x18620A210")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x620AC10", Offset = "0x6209A10", VA = "0x18620AC10")]
		private void GJLOLAAJJNO(bool OEPPFJFNIGI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x620B1C0", Offset = "0x6209FC0", VA = "0x18620B1C0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x620AE70", Offset = "0x6209C70", VA = "0x18620AE70")]
		public void InitData(int KLJBCFCDLHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x620A230", Offset = "0x6209030", VA = "0x18620A230")]
		private void FMIPGMJJMFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x620B530", Offset = "0x620A330", VA = "0x18620B530")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class GLILCLJKFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected float[] FEOLAGHNDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected int ALCOPICMIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected int KGLOPMIHJGF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6700", Offset = "0x7B5500", VA = "0x1807B6700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ELBHIJPAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1629050", Offset = "0x1627E50", VA = "0x181629050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float EDEFEBKOKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6206DB0", Offset = "0x6205BB0", VA = "0x186206DB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float EHHMAMEHEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6206F10", Offset = "0x6205D10", VA = "0x186206F10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6205010", Offset = "0x6203E10", VA = "0x186205010")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6207060", Offset = "0x6205E60", VA = "0x186207060")]
	public GLILCLJKFPF(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6206E80", Offset = "0x6205C80", VA = "0x186206E80")]
	public void HLCJFHHJGDP(int KBCLCFPDNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6206DC0", Offset = "0x6205BC0", VA = "0x186206DC0")]
	public void CACLDNHCJCB(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x216DE10", Offset = "0x216CC10", VA = "0x18216DE10")]
	public void ODEJDKNIBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62050C0", Offset = "0x6203EC0", VA = "0x1862050C0")]
	public void OALJHONLEEI(float[] KEENMLGJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6206F50", Offset = "0x6205D50", VA = "0x186206F50")]
	public void OALJHONLEEI(float[] KEENMLGJEKM, int LCHKAKFJKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6206F20", Offset = "0x6205D20", VA = "0x186206F20")]
	private int JGMGLPPKEMP(int HPLKFBKKIBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AAOPEOOJAOP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int CGEHDEKEAPL = 512;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const int OJHMALAFMGE = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int ICJONLLHNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float[] ANDPBLKLGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public RawImage OBDPPFKDGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float EJIEPIBALNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float LEPGHINEANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float GKKPECHIGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float HGBEBOKAOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float FALEHAKPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color BKFAJLEOCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color PODBOPEGCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool CEEAJOPFKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color PIBJDKJJOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color LNABONGFJPO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int KHOOMNPBLLH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int CACCDGFIOBK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int DCAPHCKIKCJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int JMECMDBDNNG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int GDFEEFDCKCH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int NDFBABMMKPN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int IHPJIEIEJMB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int IMGNICMDGAE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int JOHKGMMIAPG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int DDAHHHPJOGE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int KFKKDNIIGLM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int BIAAJCLIBJP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6205640", Offset = "0x6204440", VA = "0x186205640")]
	public void IFOEEDLANKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62055A0", Offset = "0x62043A0", VA = "0x1862055A0")]
	public void FLPHODCLMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62057A0", Offset = "0x62045A0", VA = "0x1862057A0")]
	public void OOALFALACHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6205240", Offset = "0x6204040", VA = "0x186205240")]
	public void ANIIKNALCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6205400", Offset = "0x6204200", VA = "0x186205400")]
	public void FFCMKNDBHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6205700", Offset = "0x6204500", VA = "0x186205700")]
	public void OLCMHIGIKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6205320", Offset = "0x6204120", VA = "0x186205320")]
	public void DOKLIAFLGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6205A70", Offset = "0x6204870", VA = "0x186205A70")]
	public AAOPEOOJAOP()
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
		private MetricIdLookup IKNBNMFFDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IRawMetricsPipeline JCCIBLMBOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IMetricCollectionRegistry PIMFIDPKEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricId KGAOIELJNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int PLJMBEGJBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MetricAccumulateMode DHMOHAAMMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricCollectionToken CGFEMNMBCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MetricDescription ANGHLLMCDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GraphConfig KECKMCAOIPE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xBA33B0", Offset = "0xBA21B0", VA = "0x180BA33B0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x798EE0", Offset = "0x797CE0", VA = "0x180798EE0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6205FB0", Offset = "0x6204DB0", VA = "0x186205FB0")]
		private void DMBAMMNAEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6205F50", Offset = "0x6204D50", VA = "0x186205F50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62068B0", Offset = "0x62056B0", VA = "0x1862068B0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62067A0", Offset = "0x62055A0", VA = "0x1862067A0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6206200", Offset = "0x6205000", VA = "0x186206200")]
		public void Initialize(GraphConfig HKCFCDHGNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6206690", Offset = "0x6205490", VA = "0x186206690", Slot = "14")]
		protected override bool MPIKCBEMGKA(string EEIMKJFODKA = "0.00", [Optional] string HPINNCDMDBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6206100", Offset = "0x6204F00", VA = "0x186206100")]
		public void HandleMetric([In] RawMetric BJFAGIHCLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1A4A570", Offset = "0x1A49370", VA = "0x181A4A570", Slot = "4")]
		protected override GIPPJIMFFCI KFCOOPCACJL()
		{
			return default(GIPPJIMFFCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6206A20", Offset = "0x6205820", VA = "0x186206A20")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6206100", Offset = "0x6204F00", VA = "0x186206100", Slot = "15")]
		private void NDEGOMGNADF([In] RawMetric BJFAGIHCLEL)
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
		protected override int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD40", Offset = "0x8DBB40", VA = "0x1808DCD40", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1048010", Offset = "0x1046E10", VA = "0x181048010", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "4")]
		protected override GIPPJIMFFCI KFCOOPCACJL()
		{
			return default(GIPPJIMFFCI);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6206B20", Offset = "0x6205920", VA = "0x186206B20", Slot = "14")]
		protected override bool MPIKCBEMGKA(string EEIMKJFODKA = "0.00", [Optional] string HPINNCDMDBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6206C20", Offset = "0x6205A20", VA = "0x186206C20")]
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
		protected override int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD40", Offset = "0x8DBB40", VA = "0x1808DCD40", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1048010", Offset = "0x1046E10", VA = "0x181048010", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8935B0", Offset = "0x8923B0", VA = "0x1808935B0", Slot = "4")]
		protected override GIPPJIMFFCI KFCOOPCACJL()
		{
			return default(GIPPJIMFFCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6206CA0", Offset = "0x6205AA0", VA = "0x186206CA0", Slot = "14")]
		protected override bool MPIKCBEMGKA(string EEIMKJFODKA = "0.00", [Optional] string HPINNCDMDBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6206D80", Offset = "0x6205B80", VA = "0x186206D80")]
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
		private ProfilerRecorderHandle OKPNFDBCNNN;

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
		private static bool AOLAGPLIFLE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IGJMGDCIFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x620BCC0", Offset = "0x620AAC0", VA = "0x18620BCC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xBA33A0", Offset = "0xBA21A0", VA = "0x180BA33A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xBA33B0", Offset = "0xBA21B0", VA = "0x180BA33B0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8935B0", Offset = "0x8923B0", VA = "0x1808935B0", Slot = "4")]
		protected override GIPPJIMFFCI KFCOOPCACJL()
		{
			return default(GIPPJIMFFCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x620BB00", Offset = "0x620A900", VA = "0x18620BB00", Slot = "14")]
		protected override bool MPIKCBEMGKA(string EEIMKJFODKA = "0.00", [Optional] string HPINNCDMDBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x620BC20", Offset = "0x620AA20", VA = "0x18620BC20")]
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
		protected override int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD40", Offset = "0x8DBB40", VA = "0x1808DCD40", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1048010", Offset = "0x1046E10", VA = "0x181048010", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89C1E0", Offset = "0x89AFE0", VA = "0x18089C1E0", Slot = "4")]
		protected override GIPPJIMFFCI KFCOOPCACJL()
		{
			return default(GIPPJIMFFCI);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x620BCD0", Offset = "0x620AAD0", VA = "0x18620BCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x62093E0", Offset = "0x62081E0", VA = "0x1862093E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62097C0", Offset = "0x62085C0", VA = "0x1862097C0")]
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
		private bool NAFGMCLHKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool JJIHKCMOPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool LEEDEEDPPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool DKKMLGALLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool NDKLIHLEIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private bool PNBAPPKHNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private bool JDMJDFJHHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool ECBNOFDDODD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string CKDLKOLNOHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6209FA0", Offset = "0x6208DA0", VA = "0x186209FA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x620A140", Offset = "0x6208F40", VA = "0x18620A140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string AMOGAEHEMAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6209F40", Offset = "0x6208D40", VA = "0x186209F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x620A000", Offset = "0x6208E00", VA = "0x18620A000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string BELIFFPNMKM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6209F60", Offset = "0x6208D60", VA = "0x186209F60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x620A080", Offset = "0x6208E80", VA = "0x18620A080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string DCEBNEINCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6209FB0", Offset = "0x6208DB0", VA = "0x186209FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x620A180", Offset = "0x6208F80", VA = "0x18620A180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string LPPBLJFJDCO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6209F50", Offset = "0x6208D50", VA = "0x186209F50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x620A040", Offset = "0x6208E40", VA = "0x18620A040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string JCCEIEIPICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6209F90", Offset = "0x6208D90", VA = "0x186209F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x620A100", Offset = "0x6208F00", VA = "0x18620A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string FJGGFKGLPNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6209F70", Offset = "0x6208D70", VA = "0x186209F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x620A0C0", Offset = "0x6208EC0", VA = "0x18620A0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string BJOOGICLKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6209F20", Offset = "0x6208D20", VA = "0x186209F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6209FC0", Offset = "0x6208DC0", VA = "0x186209FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6209E40", Offset = "0x6208C40", VA = "0x186209E40", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6209DC0", Offset = "0x6208BC0", VA = "0x186209DC0")]
		protected string GMKMFIIIOKI(bool PGFICPDEBCH, TMP_Text LGDFGELLOEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6209D80", Offset = "0x6208B80", VA = "0x186209D80")]
		protected void FCBGNDGGAEE(bool DAMAANINIOK, TMP_Text KEENMLGJEKM, string MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
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
		protected const string FGOIDBFBPNP = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double CIGFIIDLMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double IPHDPODNKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected double INAJMEJJKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double OKDBEICIBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double EGIANDKBDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected int JHNAHPLBDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double IOKEKDEFMBA;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int ONGMKEKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode EGDJIPHGKIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool EHDIJHABJKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCBF9B0", Offset = "0xCBE7B0", VA = "0x180CBF9B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCBE5D0", Offset = "0xCBD3D0", VA = "0x180CBE5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract GIPPJIMFFCI KFCOOPCACJL();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void JANHCOICLLB();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xFE0D30", Offset = "0xFDFB30", VA = "0x180FE0D30", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xFE0D30", Offset = "0xFDFB30", VA = "0x180FE0D30")]
		protected void NBCPLDKFAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6209D40", Offset = "0x6208B40", VA = "0x186209D40", Slot = "10")]
		protected virtual void MKGDDDJHAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6209890", Offset = "0x6208690", VA = "0x186209890", Slot = "11")]
		protected virtual void AAPDDEMODML(double AJCKGIEMPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6209BE0", Offset = "0x62089E0", VA = "0x186209BE0", Slot = "12")]
		protected virtual double MBLDGHDJAGL(MetricAccumulateMode DHMOHAAMMCB)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6209950", Offset = "0x6208750", VA = "0x186209950")]
		protected bool AOEOLONDAAO(MetricGraph CGBNOINFMAG, MetricAccumulateMode HFILCPIGNLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6209AB0", Offset = "0x62088B0", VA = "0x186209AB0", Slot = "13")]
		protected virtual string LPEHOFEJCPH(double MBDKMNBCLGF, string OIAIKKGGJAI = "0.00", [Optional] string BNIFPLEAFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6206D80", Offset = "0x6205B80", VA = "0x186206D80")]
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
		protected bool FNMCLPGKMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected bool CMIKENBKOFF;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x620C210", Offset = "0x620B010", VA = "0x18620C210", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x620BD10", Offset = "0x620AB10", VA = "0x18620BD10", Slot = "5")]
		protected override void JANHCOICLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x620BEC0", Offset = "0x620ACC0", VA = "0x18620BEC0", Slot = "14")]
		protected virtual bool MPIKCBEMGKA(string EEIMKJFODKA = "0.00", [Optional] string HPINNCDMDBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6206D80", Offset = "0x6205B80", VA = "0x186206D80")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CGBJNBBPHAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool CPKLFKPMELH
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
	RawMetricPayload EMMDIIAANPM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KOMOLEPHOGA : CGBJNBBPHAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool AOLAGPLIFLE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> OMFHOFACFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MetricId KGAOIELJNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly string MHLHMKOGNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string HGAIALFHBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private ProfilerRecorder EGCJHBLPLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool MEBLGGFOPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool DAOOFKBLDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorderDescription OHEAKGDDCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private ProfilerRecorderHandle OKPNFDBCNNN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CPKLFKPMELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEC0", Offset = "0x7DECC0", VA = "0x1807DFEC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97E210", Offset = "0x97D010", VA = "0x18097E210", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription HELGNMPLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x575A840", Offset = "0x5759640", VA = "0x18575A840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6209370", Offset = "0x6208170", VA = "0x186209370")]
	public KOMOLEPHOGA(MetricId KGAOIELJNNL, string MHLHMKOGNMD, string HGAIALFHBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6208DD0", Offset = "0x6207BD0", VA = "0x186208DD0", Slot = "6")]
	public RawMetricPayload EMMDIIAANPM()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6208E70", Offset = "0x6207C70", VA = "0x186208E70")]
	private static ProfilerRecorderHandle KMDGMBEFNID(string MHLHMKOGNMD, string HGAIALFHBHD)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6208FC0", Offset = "0x6207DC0", VA = "0x186208FC0")]
	private void OIFNNABOAEG(bool OEPPFJFNIGI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6208D30", Offset = "0x6207B30", VA = "0x186208D30")]
	private static MetricDescription DNODAGHCDEK(MetricId KGAOIELJNNL, ProfilerRecorderDescription LBGOGHLCIDE)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6208A60", Offset = "0x6207860", VA = "0x186208A60")]
	private static bool BIPECKIKMCA(bool OEPPFJFNIGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6208DB0", Offset = "0x6207BB0", VA = "0x186208DB0")]
	private void IDGKJAINKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6208DB0", Offset = "0x6207BB0", VA = "0x186208DB0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHHFKMLFCNK : CGBJNBBPHAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<double> GOOOICJLJBI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CPKLFKPMELH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x796F10", Offset = "0x795D10", VA = "0x180796F10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6206AD0", Offset = "0x62058D0", VA = "0x186206AD0")]
	public DHHFKMLFCNK(Func<double> GOOOICJLJBI, MetricDescription ANGHLLMCDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6206A60", Offset = "0x6205860", VA = "0x186206A60", Slot = "6")]
	public RawMetricPayload EMMDIIAANPM()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IOLHFPPJJFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct GLNIFJALOCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string CGBMPMIAPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly string DMCDJMPFKNM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
		public GLNIFJALOCG(string MHLHMKOGNMD, string HGAIALFHBHD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PGGFKNODCLD : IAsyncStateMachine
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
		public IOLHFPPJJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x620B8C0", Offset = "0x620A6C0", VA = "0x18620B8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x620BAA0", Offset = "0x620A8A0", VA = "0x18620BAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MetricIdLookup IKNBNMFFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IRawMetricsPipeline JCCIBLMBOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IMetricCollectionRegistry PIMFIDPKEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource ELAGOJJKAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Dictionary<MetricId, CGBJNBBPHAF> JHCCAHOIKOA;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly GLNIFJALOCG[] NOJDCIHOCGM;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62070F0", Offset = "0x6205EF0", VA = "0x1862070F0")]
	[OKINHFAHPEJ(FNGNILODNLI.GameOnly)]
	private static void ANEDGJPLFNN(LPFNGCMIAEC KNABOHCCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62081F0", Offset = "0x6206FF0", VA = "0x1862081F0")]
	[Preserve]
	public IOLHFPPJJFF([MCCEMKLKAEE(null)] MetricIdLookup IKNBNMFFDMI, [MCCEMKLKAEE(null)] IRawMetricsPipeline JCCIBLMBOCB, [MCCEMKLKAEE(null)] IMetricCollectionRegistry PIMFIDPKEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6207380", Offset = "0x6206180", VA = "0x186207380")]
	private void COJBEEACDOB(string PFEPONLGPBE, string HGAIALFHBHD, GIPPJIMFFCI CKNNMJJNBKK, Func<double> GOOOICJLJBI, [Out] MetricId KGAOIELJNNL, [Out] CGBJNBBPHAF LGDFGELLOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62072E0", Offset = "0x62060E0", VA = "0x1862072E0")]
	private void CHMNHNNOOPH(MetricId KGAOIELJNNL, bool NEPIHMONBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x62071F0", Offset = "0x6205FF0", VA = "0x1862071F0")]
	[AsyncStateMachine(typeof(PGGFKNODCLD))]
	private Task CEGGOBMPPAP(CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6207490", Offset = "0x6206290", VA = "0x186207490")]
	public void IINGBGHMNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6207450", Offset = "0x6206250", VA = "0x186207450", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x62070D0", Offset = "0x6205ED0", VA = "0x1862070D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81B4D0", Offset = "0x81A2D0", VA = "0x18081B4D0")]
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
