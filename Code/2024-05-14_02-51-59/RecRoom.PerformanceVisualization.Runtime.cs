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
		[Cpp2IlInjected.Address(RVA = "0x6555B40", Offset = "0x6554540", VA = "0x186555B40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6555F20", Offset = "0x6554920", VA = "0x186555F20")]
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
		private ProfilerMarker OMHLFIMMNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ProfilerMarker OAAALBLMIMN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int EEFIGMPJOCB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int DLHFNBOLBLG = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Range(8f, 512f)]
		[Header("Buffer")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JFNKJJEMLDL JKNHNDHICCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool IGOFLBDBAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float JAHMLIGAMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float JPIOCBBHJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float NGPOHEOCNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float MLBLKJHMKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float ANOHEAGLGNN;

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
		private DGOFLECKOEE ODKDNOGJNEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int OPDPHJCFPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x655B380", Offset = "0x6559D80", VA = "0x18655B380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int CBOOKBMAGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x655B2B0", Offset = "0x6559CB0", VA = "0x18655B2B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int HFAKPAMNCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x655B320", Offset = "0x6559D20", VA = "0x18655B320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KGAOIGFDOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x655C990", Offset = "0x655B390", VA = "0x18655C990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BACAPPFKFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x655C960", Offset = "0x655B360", VA = "0x18655C960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float GCOHOEAEALL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x655C8C0", Offset = "0x655B2C0", VA = "0x18655C8C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float ADLBILGODDA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x655C900", Offset = "0x655B300", VA = "0x18655C900")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float ICBNLGBABCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x655C8E0", Offset = "0x655B2E0", VA = "0x18655C8E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float IGPBLMNAADL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x655C920", Offset = "0x655B320", VA = "0x18655C920")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float ADMMFFPEPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x655C940", Offset = "0x655B340", VA = "0x18655C940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x655B2D0", Offset = "0x6559CD0", VA = "0x18655B2D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x655C5F0", Offset = "0x655AFF0", VA = "0x18655C5F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x655C1D0", Offset = "0x655ABD0", VA = "0x18655C1D0")]
		public void PushSample(double NCDAHBFCDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x655B300", Offset = "0x6559D00", VA = "0x18655B300")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x655BD80", Offset = "0x655A780", VA = "0x18655BD80")]
		private void IOKPLLOBNDE(bool AHPBABJEPBH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x655C2B0", Offset = "0x655ACB0", VA = "0x18655C2B0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x655BFE0", Offset = "0x655A9E0", VA = "0x18655BFE0")]
		public void InitData(int NFMAPGJLBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x655B3A0", Offset = "0x6559DA0", VA = "0x18655B3A0")]
		private void GDCFMKGJOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x655C620", Offset = "0x655B020", VA = "0x18655C620")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class JFNKJJEMLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected float[] JMIDPHADHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected int MECGBKBMIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected int GBACAOOHJGH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB70", Offset = "0x7E9570", VA = "0x1807EAB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KPMMKHLLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1769E50", Offset = "0x1768850", VA = "0x181769E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float OKENJECKFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6559AE0", Offset = "0x65584E0", VA = "0x186559AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float BFDCBEFDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6559AD0", Offset = "0x65584D0", VA = "0x186559AD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6555A10", Offset = "0x6554410", VA = "0x186555A10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6559AF0", Offset = "0x65584F0", VA = "0x186559AF0")]
	public JFNKJJEMLDL(int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6559980", Offset = "0x6558380", VA = "0x186559980")]
	public void LHDLLDBEMIG(int KBOOIBMNJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6559A10", Offset = "0x6558410", VA = "0x186559A10")]
	public void MFHHOLLDFHB(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23ECBB0", Offset = "0x23EB5B0", VA = "0x1823ECBB0")]
	public void GGJHLLGLHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6555910", Offset = "0x6554310", VA = "0x186555910")]
	public void CJPEGEMMMGG(float[] PJDANIPAHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6559840", Offset = "0x6558240", VA = "0x186559840")]
	public void CJPEGEMMMGG(float[] PJDANIPAHEH, int IAGIIFNNIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6559950", Offset = "0x6558350", VA = "0x186559950")]
	private int DPPEIACEJOB(int ABBNIPHGMGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DGOFLECKOEE
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int JPGKDMLBBEA = 512;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const int AIFHOFFPALD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int GNEMFEGNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float[] NLEDEAHNKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public RawImage CNNPMFAEJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float IAKOPIBNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float LMHBAOFLAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float BHDPLEOFHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float JHNLLAAIEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float OJPBOJPKCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color DPAPKMGPNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color COFMBIJNBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool EFMBKPAABMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color AONGGIIHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color DHOLHOPEJHC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int GKGDKDMCFHM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int MIDPHBFDJLB;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int CJEFKIPKOPB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int JGCPHGJIJBH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int KGDPLKIOICN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int LMNHPHJDJCD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int CAOEBMKMFIA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int GHKJBNLEKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int BGLIOAGOHNA;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int KIDLEALFEBH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int KNHPEOBEIPB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int ADPMJFILDEI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65570F0", Offset = "0x6555AF0", VA = "0x1865570F0")]
	public void OAOHFCGKCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6556DF0", Offset = "0x65557F0", VA = "0x186556DF0")]
	public void JCKPAKDFFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6556D50", Offset = "0x6555750", VA = "0x186556D50")]
	public void CBPMBDJKFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6557010", Offset = "0x6555A10", VA = "0x186557010")]
	public void MLAOOGCAJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65571B0", Offset = "0x6555BB0", VA = "0x1865571B0")]
	public void OLKDNBADJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6556E90", Offset = "0x6555890", VA = "0x186556E90")]
	public void JELHONOABFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6556F30", Offset = "0x6555930", VA = "0x186556F30")]
	public void LKCPLILOAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6557580", Offset = "0x6555F80", VA = "0x186557580")]
	public DGOFLECKOEE()
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
		private MetricIdLookup EOMPFDCJICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IRawMetricsPipeline HIOFFOCEJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IMetricCollectionRegistry HPCPDDBINLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricId NALFAMJFMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int CBELOHCILHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MetricAccumulateMode JFEMFNPLAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricCollectionToken AIDIDMJCFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MetricDescription EDOFDOHMLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GraphConfig DINLCDHGPPD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC90500", Offset = "0xC8EF00", VA = "0x180C90500", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA50", Offset = "0x7CE450", VA = "0x1807CFA50", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6556940", Offset = "0x6555340", VA = "0x186556940")]
		private void ODEDFMIHONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6556230", Offset = "0x6554C30", VA = "0x186556230", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6556BA0", Offset = "0x65555A0", VA = "0x186556BA0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6556A90", Offset = "0x6555490", VA = "0x186556A90")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65564A0", Offset = "0x6554EA0", VA = "0x1865564A0")]
		public void Initialize(GraphConfig APFNPKBNNPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6556290", Offset = "0x6554C90", VA = "0x186556290", Slot = "14")]
		protected override bool BCIDCDGHGIA(string DCNCEPOAMLP = "0.00", [Optional] string MGENLOOOHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x65563A0", Offset = "0x6554DA0", VA = "0x1865563A0")]
		public void HandleMetric([In] RawMetric DOALELEIFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x58BEB10", Offset = "0x58BD510", VA = "0x1858BEB10", Slot = "4")]
		protected override DHPOKPFAEHE MGEFCKIIEAN()
		{
			return default(DHPOKPFAEHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6556D10", Offset = "0x6555710", VA = "0x186556D10")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x65563A0", Offset = "0x6554DA0", VA = "0x1865563A0", Slot = "15")]
		private void LDODNMOLOFH([In] RawMetric DOALELEIFHF)
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
		protected override int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x884340", Offset = "0x882D40", VA = "0x180884340", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x115B140", Offset = "0x1159B40", VA = "0x18115B140", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "4")]
		protected override DHPOKPFAEHE MGEFCKIIEAN()
		{
			return default(DHPOKPFAEHE);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x65575B0", Offset = "0x6555FB0", VA = "0x1865575B0", Slot = "14")]
		protected override bool BCIDCDGHGIA(string DCNCEPOAMLP = "0.00", [Optional] string MGENLOOOHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65576B0", Offset = "0x65560B0", VA = "0x1865576B0")]
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
		protected override int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x884340", Offset = "0x882D40", VA = "0x180884340", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x115B140", Offset = "0x1159B40", VA = "0x18115B140", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5832A30", Offset = "0x5831430", VA = "0x185832A30", Slot = "4")]
		protected override DHPOKPFAEHE MGEFCKIIEAN()
		{
			return default(DHPOKPFAEHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6557730", Offset = "0x6556130", VA = "0x186557730", Slot = "14")]
		protected override bool BCIDCDGHGIA(string DCNCEPOAMLP = "0.00", [Optional] string MGENLOOOHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6557810", Offset = "0x6556210", VA = "0x186557810")]
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
		private ProfilerRecorderHandle AKNHCHBPKNK;

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
		private static bool AJBKBECHPAF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ICFAIBBLHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x655CB70", Offset = "0x655B570", VA = "0x18655CB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xC904F0", Offset = "0xC8EEF0", VA = "0x180C904F0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC90500", Offset = "0xC8EF00", VA = "0x180C90500", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5832A30", Offset = "0x5831430", VA = "0x185832A30", Slot = "4")]
		protected override DHPOKPFAEHE MGEFCKIIEAN()
		{
			return default(DHPOKPFAEHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x655C9B0", Offset = "0x655B3B0", VA = "0x18655C9B0", Slot = "14")]
		protected override bool BCIDCDGHGIA(string DCNCEPOAMLP = "0.00", [Optional] string MGENLOOOHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x655CAD0", Offset = "0x655B4D0", VA = "0x18655CAD0")]
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
		protected override int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x884340", Offset = "0x882D40", VA = "0x180884340", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x115B140", Offset = "0x1159B40", VA = "0x18115B140", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC130D0", Offset = "0xC11AD0", VA = "0x180C130D0", Slot = "4")]
		protected override DHPOKPFAEHE MGEFCKIIEAN()
		{
			return default(DHPOKPFAEHE);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x655CB80", Offset = "0x655B580", VA = "0x18655CB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x655A4D0", Offset = "0x6558ED0", VA = "0x18655A4D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x655A8B0", Offset = "0x65592B0", VA = "0x18655A8B0")]
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
		private bool HLMIBLGMBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool LBOGPABNBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool DBDHIALKNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool AJNAICNMMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool BICNAHCJINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private bool KDFHDHBBGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private bool COHCGCGGAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool OPPJICBOBAM;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string HGHLIPDLCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x655B090", Offset = "0x6559A90", VA = "0x18655B090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x655B230", Offset = "0x6559C30", VA = "0x18655B230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string HEOIBNNCFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x655B030", Offset = "0x6559A30", VA = "0x18655B030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x655B0F0", Offset = "0x6559AF0", VA = "0x18655B0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string IOANBFMBGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x655B050", Offset = "0x6559A50", VA = "0x18655B050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x655B170", Offset = "0x6559B70", VA = "0x18655B170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string GPLHBOKNKMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x655B0A0", Offset = "0x6559AA0", VA = "0x18655B0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x655B270", Offset = "0x6559C70", VA = "0x18655B270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string HNJLOFNILBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x655B040", Offset = "0x6559A40", VA = "0x18655B040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x655B130", Offset = "0x6559B30", VA = "0x18655B130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string JKAOEGFFGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x655B080", Offset = "0x6559A80", VA = "0x18655B080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x655B1F0", Offset = "0x6559BF0", VA = "0x18655B1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string JNBLDHFPOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x655B060", Offset = "0x6559A60", VA = "0x18655B060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x655B1B0", Offset = "0x6559BB0", VA = "0x18655B1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string NBGJPGMJLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x655B010", Offset = "0x6559A10", VA = "0x18655B010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x655B0B0", Offset = "0x6559AB0", VA = "0x18655B0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x655AF30", Offset = "0x6559930", VA = "0x18655AF30", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x655AE70", Offset = "0x6559870", VA = "0x18655AE70")]
		protected string FMDJNAICOLK(bool MANMPEIFOHK, TMP_Text HIHHIJKIJFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x655AEF0", Offset = "0x65598F0", VA = "0x18655AEF0")]
		protected void IBNDHGMGPHJ(bool CBBPPHPJCDO, TMP_Text PJDANIPAHEH, string AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
		protected const string IDJJHEIBMNN = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double HACEIGGPGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double HFGOBKEBLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected double NHJALANGCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double ACHGMNDLIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double HGNGAEKNHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected int HBOOGMMONON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double OEFGMOGHNJP;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int AKMGBJCCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode COKDMJKHCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool HLICGLDOHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x10C16A0", Offset = "0x10C00A0", VA = "0x1810C16A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x13A19B0", Offset = "0x13A03B0", VA = "0x1813A19B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract DHPOKPFAEHE MGEFCKIIEAN();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void CMMPFHBOHHF();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10FAF10", Offset = "0x10F9910", VA = "0x1810FAF10", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x10FAF10", Offset = "0x10F9910", VA = "0x1810FAF10")]
		protected void NPBOLHLDINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x655AC10", Offset = "0x6559610", VA = "0x18655AC10", Slot = "10")]
		protected virtual void INMEKJBJAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x655ADB0", Offset = "0x65597B0", VA = "0x18655ADB0", Slot = "11")]
		protected virtual void KGOKCFDAEAO(double JKAGJGMCFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x655AC50", Offset = "0x6559650", VA = "0x18655AC50", Slot = "12")]
		protected virtual double KDDMHLDJHCF(MetricAccumulateMode JFEMFNPLAKC)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x655A980", Offset = "0x6559380", VA = "0x18655A980")]
		protected bool CKHFGEEBMFC(MetricGraph HFKIFEHLALP, MetricAccumulateMode MMMGCOBDJOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x655AAE0", Offset = "0x65594E0", VA = "0x18655AAE0", Slot = "13")]
		protected virtual string FKBDKOBBJIA(double AEJBOLFACJC, string OPPPAIJEHEA = "0.00", [Optional] string AHGGAHJAIGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6557810", Offset = "0x6556210", VA = "0x186557810")]
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
		protected bool IMHMNCIENBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected bool MFJOHIIBALM;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x655D0C0", Offset = "0x655BAC0", VA = "0x18655D0C0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x655CF10", Offset = "0x655B910", VA = "0x18655CF10", Slot = "5")]
		protected override void CMMPFHBOHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x655CBC0", Offset = "0x655B5C0", VA = "0x18655CBC0", Slot = "14")]
		protected virtual bool BCIDCDGHGIA(string DCNCEPOAMLP = "0.00", [Optional] string MGENLOOOHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6557810", Offset = "0x6556210", VA = "0x186557810")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GHFCBPLBKJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool NKDNPGBEGOP
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
	RawMetricPayload PNKNPONNLMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KIPHFOKGDMG : GHFCBPLBKJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool AJBKBECHPAF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> JLCHIAOFLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly string AHODGMNLNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly string EJNGHPNENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorder ABBLPPKEFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool LAJNCOEKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool BLCCFFLMKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ProfilerRecorderDescription EPPCMIODDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorderHandle AKNHCHBPKNK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NKDNPGBEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x838CD0", Offset = "0x8376D0", VA = "0x180838CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AA620", Offset = "0x8A9020", VA = "0x1808AA620", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription NKOIFLIKPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6559C40", Offset = "0x6558640", VA = "0x186559C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x655A450", Offset = "0x6558E50", VA = "0x18655A450")]
	public KIPHFOKGDMG(MetricDescription EDOFDOHMLDD, string AHODGMNLNAD, string EJNGHPNENEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x655A300", Offset = "0x6558D00", VA = "0x18655A300", Slot = "6")]
	public RawMetricPayload PNKNPONNLMJ()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6559C60", Offset = "0x6558660", VA = "0x186559C60")]
	private static ProfilerRecorderHandle LEFMGFNDFIH(string AHODGMNLNAD, string EJNGHPNENEP)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6559DB0", Offset = "0x65587B0", VA = "0x186559DB0")]
	private void LOPDPNEAOFN(bool AHPBABJEPBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x655A030", Offset = "0x6558A30", VA = "0x18655A030")]
	private static bool OPKKDCGBBFE(bool AHPBABJEPBH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6559C20", Offset = "0x6558620", VA = "0x186559C20")]
	private void BPLGCEHNFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6559C20", Offset = "0x6558620", VA = "0x186559C20", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JPKJOBCALLL : GHFCBPLBKJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<double> HHHNMDHEGBF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NKDNPGBEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D40", Offset = "0x7C3740", VA = "0x1807C4D40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6559BD0", Offset = "0x65585D0", VA = "0x186559BD0")]
	public JPKJOBCALLL(Func<double> HHHNMDHEGBF, MetricDescription EDOFDOHMLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6559B60", Offset = "0x6558560", VA = "0x186559B60", Slot = "6")]
	public RawMetricPayload PNKNPONNLMJ()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class INKGMCJHCCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct FFELKCOCNAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly string PBOOHIEOFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string BMMLAJOOKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly DHPOKPFAEHE KBAEKEEOKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly string JBAMKNFGDDN;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x23EF060", Offset = "0x23EDA60", VA = "0x1823EF060")]
		public FFELKCOCNAI(string AHODGMNLNAD, string EJNGHPNENEP, DHPOKPFAEHE MKKLHFELEHI = DHPOKPFAEHE.TimeNanoseconds, [Optional] string PKMELKPANBB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BHKFBKIOEFP : IAsyncStateMachine
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
		public INKGMCJHCCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6555FF0", Offset = "0x65549F0", VA = "0x186555FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65561D0", Offset = "0x6554BD0", VA = "0x1865561D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MetricIdLookup EOMPFDCJICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IRawMetricsPipeline HIOFFOCEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IMetricCollectionRegistry HPCPDDBINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<MetricId, GHFCBPLBKJF> CBDOFBAANHP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly FFELKCOCNAI[] CPCEEGIDIMI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6557DE0", Offset = "0x65567E0", VA = "0x186557DE0")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	private static void PPNLMJNBNPK(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6558F30", Offset = "0x6557930", VA = "0x186558F30")]
	[Preserve]
	public INKGMCJHCCA([JDJLHBHAJCP(null)] MetricIdLookup EOMPFDCJICN, [JDJLHBHAJCP(null)] IRawMetricsPipeline HIOFFOCEJHK, [JDJLHBHAJCP(null)] IMetricCollectionRegistry HPCPDDBINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6557860", Offset = "0x6556260", VA = "0x186557860")]
	private void CGAFJBDCOME(string ICNPDJIMFPO, string EJNGHPNENEP, DHPOKPFAEHE APGNJOCMEDL, Func<double> HHHNMDHEGBF, [Out] MetricId NALFAMJFMNO, [Out] GHFCBPLBKJF HIHHIJKIJFM, [Optional] string PKMELKPANBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6557AA0", Offset = "0x65564A0", VA = "0x186557AA0")]
	private void JBCDOIMOFGH(MetricId NALFAMJFMNO, bool CDFLIIGHFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65579B0", Offset = "0x65563B0", VA = "0x1865579B0")]
	[AsyncStateMachine(typeof(BHKFBKIOEFP))]
	private Task GANHBADHMJH(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6557B40", Offset = "0x6556540", VA = "0x186557B40")]
	public void NDDMFOKBLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6557970", Offset = "0x6556370", VA = "0x186557970", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6557840", Offset = "0x6556240", VA = "0x186557840")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60")]
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
