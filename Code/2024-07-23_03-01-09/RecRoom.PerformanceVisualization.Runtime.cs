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
		[Cpp2IlInjected.Address(RVA = "0x6B76D00", Offset = "0x6B75F00", VA = "0x186B76D00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B770E0", Offset = "0x6B762E0", VA = "0x186B770E0")]
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
		private ProfilerMarker KMHJHKHHILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ProfilerMarker OJODLKBEAAG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int EGNPJEKDNJE = 8;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int DEODFPIHAEP = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Range(8f, 512f)]
		[Header("Buffer")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NOHFIGIIPBB GOMPLAEFPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool IBDAJNJPJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float CEELBANLPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float GJCDHHAHMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float GLLKKNFKFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float JBCPMNOONMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float CEKENCGFPIN;

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
		private PJOALANFCJO LCFEKLIPNAK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int FJJGBEIBPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B920", Offset = "0x6B7AB20", VA = "0x186B7B920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int LIHGIOCCGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6B7C790", Offset = "0x6B7B990", VA = "0x186B7C790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int PMGBEJBCMID
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6B7C7B0", Offset = "0x6B7B9B0", VA = "0x186B7C7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GDOJOEPEGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CFD0", Offset = "0x6B7C1D0", VA = "0x186B7CFD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GMIDCIJIMKG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CFA0", Offset = "0x6B7C1A0", VA = "0x186B7CFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float PONPGKNOOHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CF00", Offset = "0x6B7C100", VA = "0x186B7CF00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float JDIDDAEDMJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CF40", Offset = "0x6B7C140", VA = "0x186B7CF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float FBODFANPLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CF20", Offset = "0x6B7C120", VA = "0x186B7CF20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float HPFLOOGPNNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CF60", Offset = "0x6B7C160", VA = "0x186B7CF60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float IPINMLHLDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6B7CF80", Offset = "0x6B7C180", VA = "0x186B7CF80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B8F0", Offset = "0x6B7AAF0", VA = "0x186B7B8F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B7CC30", Offset = "0x6B7BE30", VA = "0x186B7CC30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C810", Offset = "0x6B7BA10", VA = "0x186B7C810")]
		public void PushSample(double KJHDJIMFHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B940", Offset = "0x6B7AB40", VA = "0x186B7B940")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C530", Offset = "0x6B7B730", VA = "0x186B7C530")]
		private void JIADLIHJLCA(bool AMNFMCIBNPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C8F0", Offset = "0x6B7BAF0", VA = "0x186B7C8F0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C340", Offset = "0x6B7B540", VA = "0x186B7C340")]
		public void InitData(int PIPICNEGECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B960", Offset = "0x6B7AB60", VA = "0x186B7B960")]
		private void DIOHFBACOFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B7CC60", Offset = "0x6B7BE60", VA = "0x186B7CC60")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class NOHFIGIIPBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected float[] LFOOMPFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected int EOANNBEBFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected int IHGHLPOONHD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87A900", Offset = "0x879B00", VA = "0x18087A900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1926130", Offset = "0x1925330", VA = "0x181926130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float NGKDBLOBPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7CFF0", Offset = "0x6B7C1F0", VA = "0x186B7CFF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float CJPGILKGNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7D0C0", Offset = "0x6B7C2C0", VA = "0x186B7D0C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B76C50", Offset = "0x6B75E50", VA = "0x186B76C50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D2A0", Offset = "0x6B7C4A0", VA = "0x186B7D2A0")]
	public NOHFIGIIPBB(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D030", Offset = "0x6B7C230", VA = "0x186B7D030")]
	public void GPIHBHOCHBE(int FABKOFGFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D0D0", Offset = "0x6B7C2D0", VA = "0x186B7D0D0")]
	public void HKHOFFKGMAP(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x258D120", Offset = "0x258C320", VA = "0x18258D120")]
	public void PGNDLJMGKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B76B50", Offset = "0x6B75D50", VA = "0x186B76B50")]
	public void IEIAMLECCAD(float[] CGKANMHMCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D190", Offset = "0x6B7C390", VA = "0x186B7D190")]
	public void IEIAMLECCAD(float[] CGKANMHMCOJ, int PCJPFPDGKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D000", Offset = "0x6B7C200", VA = "0x186B7D000")]
	private int CMAKMIOBDBD(int DHNLEFJCEAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PJOALANFCJO
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int BHBFKEDLFLA = 512;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const int DCMIMMNJGPG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int HFLJKACKFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float[] CIBAOJPMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public RawImage MNCAJHNJOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float IAEKGHBJGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float HNJNDOFOAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float ADELBAKDJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float AMIKBLODBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float FDHOKOPIFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color KBDEIEGPEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color FGDMPJKOIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool FPFCPJHEODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color GCLFADCMCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color ECCJMGPFOAC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int LHKBLHOJKGF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int BJOBLNPMMOL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int ALANDNHONPF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int EGEHALCOODP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int HLGAAIKBMNN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int DFMNPJPOHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int IBAGHBNLJNI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int HPFJLPDPFMO;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int DHDFJGLGDAE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int FIKMIGENKJH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int NFBHDFPAILL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int NACNKOMABLJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D310", Offset = "0x6B7C510", VA = "0x186B7D310")]
	public void ABOGFEKGIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D6F0", Offset = "0x6B7C8F0", VA = "0x186B7D6F0")]
	public void IHLNBBOENKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D4B0", Offset = "0x6B7C6B0", VA = "0x186B7D4B0")]
	public void ADPBBCEGCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D790", Offset = "0x6B7C990", VA = "0x186B7D790")]
	public void MGNAJFCNLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D550", Offset = "0x6B7C750", VA = "0x186B7D550")]
	public void BDKHHJBKFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D870", Offset = "0x6B7CA70", VA = "0x186B7D870")]
	public void PHDOKICDDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D3D0", Offset = "0x6B7C5D0", VA = "0x186B7D3D0")]
	public void ADABJPINOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DB40", Offset = "0x6B7CD40", VA = "0x186B7DB40")]
	public PJOALANFCJO()
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
		private MetricIdLookup GPPGMAGNJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IRawMetricsPipeline FMLICOGIHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IMetricCollectionRegistry IDFDIFFIMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricId CHODAIFIAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int PHNHMBGFOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MetricAccumulateMode DHAAFPMFNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricCollectionToken EOCJCEFCOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MetricDescription LDEMGPCPFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GraphConfig DDFILPNDKEC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA70590", Offset = "0xA6F790", VA = "0x180A70590", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85FD20", Offset = "0x85EF20", VA = "0x18085FD20", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B771B0", Offset = "0x6B763B0", VA = "0x186B771B0")]
		private void AJMPMOLOIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B77300", Offset = "0x6B76500", VA = "0x186B77300", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B77B20", Offset = "0x6B76D20", VA = "0x186B77B20", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B77A10", Offset = "0x6B76C10", VA = "0x186B77A10")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B77460", Offset = "0x6B76660", VA = "0x186B77460")]
		public void Initialize(GraphConfig BKHKEEEPEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B77900", Offset = "0x6B76B00", VA = "0x186B77900", Slot = "14")]
		protected override bool JHCFHIACJOM(string PPKMMOMEAMK = "0.00", [Optional] string FDFHOMJKBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6B77360", Offset = "0x6B76560", VA = "0x186B77360")]
		public void HandleMetric([In] RawMetric AGLJFAHNDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E27090", Offset = "0x5E26290", VA = "0x185E27090", Slot = "4")]
		protected override NCOPENOGEKP NDGFELHHNED()
		{
			return default(NCOPENOGEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B77C90", Offset = "0x6B76E90", VA = "0x186B77C90")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B77360", Offset = "0x6B76560", VA = "0x186B77360", Slot = "15")]
		private void OCIBDJBJEDL([In] RawMetric AGLJFAHNDPD)
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
		protected override int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAE2790", Offset = "0xAE1990", VA = "0x180AE2790", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9EF180", Offset = "0x9EE380", VA = "0x1809EF180", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "4")]
		protected override NCOPENOGEKP NDGFELHHNED()
		{
			return default(NCOPENOGEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B77FD0", Offset = "0x6B771D0", VA = "0x186B77FD0", Slot = "14")]
		protected override bool JHCFHIACJOM(string PPKMMOMEAMK = "0.00", [Optional] string FDFHOMJKBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B780D0", Offset = "0x6B772D0", VA = "0x186B780D0")]
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
		protected override int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAE2790", Offset = "0xAE1990", VA = "0x180AE2790", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9EF180", Offset = "0x9EE380", VA = "0x1809EF180", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B8E0", Offset = "0x5D9AAE0", VA = "0x185D9B8E0", Slot = "4")]
		protected override NCOPENOGEKP NDGFELHHNED()
		{
			return default(NCOPENOGEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B78150", Offset = "0x6B77350", VA = "0x186B78150", Slot = "14")]
		protected override bool JHCFHIACJOM(string PPKMMOMEAMK = "0.00", [Optional] string FDFHOMJKBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B78230", Offset = "0x6B77430", VA = "0x186B78230")]
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
		private ProfilerRecorderHandle AEHCJAIAPGC;

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
		private static bool PCEFKJOHDOB;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KICKPCEEDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6B7DD30", Offset = "0x6B7CF30", VA = "0x186B7DD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xDB93F0", Offset = "0xDB85F0", VA = "0x180DB93F0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA70590", Offset = "0xA6F790", VA = "0x180A70590", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B8E0", Offset = "0x5D9AAE0", VA = "0x185D9B8E0", Slot = "4")]
		protected override NCOPENOGEKP NDGFELHHNED()
		{
			return default(NCOPENOGEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DB70", Offset = "0x6B7CD70", VA = "0x186B7DB70", Slot = "14")]
		protected override bool JHCFHIACJOM(string PPKMMOMEAMK = "0.00", [Optional] string FDFHOMJKBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DC90", Offset = "0x6B7CE90", VA = "0x186B7DC90")]
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
		protected override int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAE2790", Offset = "0xAE1990", VA = "0x180AE2790", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9EF180", Offset = "0x9EE380", VA = "0x1809EF180", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xCAF740", Offset = "0xCAE940", VA = "0x180CAF740", Slot = "4")]
		protected override NCOPENOGEKP NDGFELHHNED()
		{
			return default(NCOPENOGEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DD40", Offset = "0x6B7CF40", VA = "0x186B7DD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B7AB10", Offset = "0x6B79D10", VA = "0x186B7AB10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B7AEF0", Offset = "0x6B7A0F0", VA = "0x186B7AEF0")]
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
		private bool NJAJCLIGHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool EHMOIPBDIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool NDAOENDCOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool ELJDBEINJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool CHHHGLKJPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private bool JMFDDFAGDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private bool PFCNPIHHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool DIOPNAIEFHK;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string INKNPAHKHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B6D0", Offset = "0x6B7A8D0", VA = "0x186B7B6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B870", Offset = "0x6B7AA70", VA = "0x186B7B870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string OEDOKAJCOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B670", Offset = "0x6B7A870", VA = "0x186B7B670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B730", Offset = "0x6B7A930", VA = "0x186B7B730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string LNOIPHDHJKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B690", Offset = "0x6B7A890", VA = "0x186B7B690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B7B0", Offset = "0x6B7A9B0", VA = "0x186B7B7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string CHNLEJLDNNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B6E0", Offset = "0x6B7A8E0", VA = "0x186B7B6E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B8B0", Offset = "0x6B7AAB0", VA = "0x186B7B8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string FLFFLGPGLEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B680", Offset = "0x6B7A880", VA = "0x186B7B680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B770", Offset = "0x6B7A970", VA = "0x186B7B770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string IGEOIMBCFOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B6C0", Offset = "0x6B7A8C0", VA = "0x186B7B6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B830", Offset = "0x6B7AA30", VA = "0x186B7B830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string MAPGNBFPDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B6A0", Offset = "0x6B7A8A0", VA = "0x186B7B6A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B7F0", Offset = "0x6B7A9F0", VA = "0x186B7B7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string LAHLKLFHMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B650", Offset = "0x6B7A850", VA = "0x186B7B650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6B7B6F0", Offset = "0x6B7A8F0", VA = "0x186B7B6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B570", Offset = "0x6B7A770", VA = "0x186B7B570", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B4F0", Offset = "0x6B7A6F0", VA = "0x186B7B4F0")]
		protected string OHPIABOPCKN(bool MJGIDAJDKND, TMP_Text LDPKCIGIIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B4B0", Offset = "0x6B7A6B0", VA = "0x186B7B4B0")]
		protected void NKJOOPOLCFO(bool PEKGJEMAKOP, TMP_Text CGKANMHMCOJ, string JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
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
		protected const string HHABNJKLBHC = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected double ODKGKDCMPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double MONHLBKDNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected double AOCCPJAKOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double LOONMGDOCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double BACCGIEHNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected int AJIMGKHCAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double IMEDJACIKNC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int OBAAEHJFCID
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode GFPKLFIFABM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool PGCAAOINBKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x91FF70", Offset = "0x91F170", VA = "0x18091FF70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9F7EE0", Offset = "0x9F70E0", VA = "0x1809F7EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract NCOPENOGEKP NDGFELHHNED();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void HKIEJLHAFHD();

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1224410", Offset = "0x1223610", VA = "0x181224410", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1224410", Offset = "0x1223610", VA = "0x181224410")]
		protected void JMHBJAFPOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B470", Offset = "0x6B7A670", VA = "0x186B7B470", Slot = "10")]
		protected virtual void GACDBBCFABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B3B0", Offset = "0x6B7A5B0", VA = "0x186B7B3B0", Slot = "11")]
		protected virtual void FFBDCHGPHPF(double NFDMFLKPLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B7AFC0", Offset = "0x6B7A1C0", VA = "0x186B7AFC0", Slot = "12")]
		protected virtual double CJGDBDMCCKL(MetricAccumulateMode DHAAFPMFNOK)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B120", Offset = "0x6B7A320", VA = "0x186B7B120")]
		protected bool EDFBDMAOBOD(MetricGraph HEFMBNKPLCC, MetricAccumulateMode DNCAOAEPAKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B280", Offset = "0x6B7A480", VA = "0x186B7B280", Slot = "13")]
		protected virtual string ELHEDEBDKEP(double JMDCGOKJIDA, string BGOCEECJDJL = "0.00", [Optional] string BNKEAOIAABD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B78230", Offset = "0x6B77430", VA = "0x186B78230")]
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
		protected bool DJCJEILGKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected bool MMPHCDAKCMK;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E280", Offset = "0x6B7D480", VA = "0x186B7E280", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DD80", Offset = "0x6B7CF80", VA = "0x186B7DD80", Slot = "5")]
		protected override void HKIEJLHAFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DF30", Offset = "0x6B7D130", VA = "0x186B7DF30", Slot = "14")]
		protected virtual bool JHCFHIACJOM(string PPKMMOMEAMK = "0.00", [Optional] string FDFHOMJKBJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6B78230", Offset = "0x6B77430", VA = "0x186B78230")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OPKJNKLHIEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool INMPDDDBHHD
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
	RawMetricPayload LBMDIIFFOPK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HCBCBPCLJLE : OPKJNKLHIEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool PCEFKJOHDOB;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> MKGBMELGDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly string AIBOCOHPMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly string OMACAKCFGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorder DGBFMDDMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool NICLDIMGIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool PMNFNODAFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ProfilerRecorderDescription PPLIOADNJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorderHandle AEHCJAIAPGC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A6350", Offset = "0x8A5550", VA = "0x1808A6350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9AE710", Offset = "0x9AD910", VA = "0x1809AE710", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription DANGGLOAFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B787F0", Offset = "0x6B779F0", VA = "0x186B787F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B78AB0", Offset = "0x6B77CB0", VA = "0x186B78AB0")]
	public HCBCBPCLJLE(MetricDescription LDEMGPCPFJN, string AIBOCOHPMND, string OMACAKCFGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B78960", Offset = "0x6B77B60", VA = "0x186B78960", Slot = "6")]
	public RawMetricPayload LBMDIIFFOPK()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B78810", Offset = "0x6B77A10", VA = "0x186B78810")]
	private static ProfilerRecorderHandle KMPJDHOCEAL(string AIBOCOHPMND, string OMACAKCFGGI)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B78570", Offset = "0x6B77770", VA = "0x186B78570")]
	private void HDJDMMKGABF(bool AMNFMCIBNPO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B782A0", Offset = "0x6B774A0", VA = "0x186B782A0")]
	private static bool EKDJACNJMHD(bool AMNFMCIBNPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B78280", Offset = "0x6B77480", VA = "0x186B78280")]
	private void LOCGCOHBAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B78280", Offset = "0x6B77480", VA = "0x186B78280", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DCNALCNLNPJ : OPKJNKLHIEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<double> IPFEJDOJICI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x853EE0", VA = "0x180854CE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B77D40", Offset = "0x6B76F40", VA = "0x186B77D40")]
	public DCNALCNLNPJ(Func<double> IPFEJDOJICI, MetricDescription LDEMGPCPFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B77CD0", Offset = "0x6B76ED0", VA = "0x186B77CD0", Slot = "6")]
	public RawMetricPayload LBMDIIFFOPK()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLHDFONIDEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private readonly struct AMBOFBEBOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly string KOAEJNOPMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string PPLNDCEHNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly NCOPENOGEKP EHCKGKCDAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly string FOIGBDFIMIM;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x25850A0", Offset = "0x25842A0", VA = "0x1825850A0")]
		public AMBOFBEBOHG(string AIBOCOHPMND, string OMACAKCFGGI, NCOPENOGEKP LMLFACCGALC = NCOPENOGEKP.TimeNanoseconds, [Optional] string LGONLNLFDJA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EOPGOODEEOI : IAsyncStateMachine
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
		public LLHDFONIDEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B77D90", Offset = "0x6B76F90", VA = "0x186B77D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B77F70", Offset = "0x6B77170", VA = "0x186B77F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MetricIdLookup GPPGMAGNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IRawMetricsPipeline FMLICOGIHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IMetricCollectionRegistry IDFDIFFIMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<MetricId, OPKJNKLHIEK> GPDLNPHLFGH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly AMBOFBEBOHG[] AKMCIKJNDCK;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B790B0", Offset = "0x6B782B0", VA = "0x186B790B0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void JNAGAGBOGMF(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B7A200", Offset = "0x6B79400", VA = "0x186B7A200")]
	[Preserve]
	public LLHDFONIDEO([OMAPKKAGFIL(null)] MetricIdLookup GPPGMAGNJPP, [OMAPKKAGFIL(null)] IRawMetricsPipeline FMLICOGIHIB, [OMAPKKAGFIL(null)] IMetricCollectionRegistry IDFDIFFIMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B78D00", Offset = "0x6B77F00", VA = "0x186B78D00")]
	private void HEGNAMPEFIF(string CBLFPILADFB, string OMACAKCFGGI, NCOPENOGEKP JFINJGOBHJH, Func<double> IPFEJDOJICI, [Out] MetricId CHODAIFIAPD, [Out] OPKJNKLHIEK LDPKCIGIIMG, [Optional] string LGONLNLFDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B78B70", Offset = "0x6B77D70", VA = "0x186B78B70")]
	private void EGFFBJFILAF(MetricId CHODAIFIAPD, bool PDHLHPOBKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B78C10", Offset = "0x6B77E10", VA = "0x186B78C10")]
	[AsyncStateMachine(typeof(EOPGOODEEOI))]
	private Task EMDHBLNAAKI(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B78E10", Offset = "0x6B78010", VA = "0x186B78E10")]
	public void JMNENHNPPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B78B30", Offset = "0x6B77D30", VA = "0x186B78B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B78260", Offset = "0x6B77460", VA = "0x186B78260")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BDB20", VA = "0x1808BE920")]
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
