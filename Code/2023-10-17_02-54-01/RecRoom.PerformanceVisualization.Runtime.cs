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
		private ProfilerMarker NBLJABHBOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ProfilerMarker PHEGIFKKHJD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int AOIFHMBOBDK = 8;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int AMHFNFIEEME = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Range(8f, 512f)]
		[Header("Buffer")]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OKEJNCGOCLG NMMOFADJJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool FIIMJNHDAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private float LEKPOLJFNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float OEAGAKANIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float PAILIFHCPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float GCGNAGHFOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float OFGLJCHOJPK;

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
		private GHKMCGNBOEC ENNCHOOHHBM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int JGKGPAODKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD650", Offset = "0x5EDBE50", VA = "0x185EDD650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int GPHALAFNCBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD3D0", Offset = "0x5EDBBD0", VA = "0x185EDD3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int HKDAICOADBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD180", Offset = "0x5EDB980", VA = "0x185EDD180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KKPFPOBCBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE810", Offset = "0x5EDD010", VA = "0x185EDE810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EJNICKKHFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE7E0", Offset = "0x5EDCFE0", VA = "0x185EDE7E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float DCPNNMDDKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE740", Offset = "0x5EDCF40", VA = "0x185EDE740")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float IEEHEDIFMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE780", Offset = "0x5EDCF80", VA = "0x185EDE780")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float DJHHCLHGHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE760", Offset = "0x5EDCF60", VA = "0x185EDE760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MEBNJIHLPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE7A0", Offset = "0x5EDCFA0", VA = "0x185EDE7A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float BHFNIJCPOHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE7C0", Offset = "0x5EDCFC0", VA = "0x185EDE7C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD130", Offset = "0x5EDB930", VA = "0x185EDD130")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE470", Offset = "0x5EDCC70", VA = "0x185EDE470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE050", Offset = "0x5EDC850", VA = "0x185EDE050")]
		public void PushSample(double AHFPLGPDLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD160", Offset = "0x5EDB960", VA = "0x185EDD160")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD3F0", Offset = "0x5EDBBF0", VA = "0x185EDD3F0")]
		private void MHGHPONMCON(bool AKFFELDLHDA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE130", Offset = "0x5EDC930", VA = "0x185EDE130")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD1E0", Offset = "0x5EDB9E0", VA = "0x185EDD1E0")]
		public void InitData(int GJJCKMIOJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD670", Offset = "0x5EDBE70", VA = "0x185EDD670")]
		private void PLPDOOODOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE4A0", Offset = "0x5EDCCA0", VA = "0x185EDE4A0")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class OKEJNCGOCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	protected float[] IIOKPPFDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	protected int PIACPCIIINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	protected int EHGKBCBKPCI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78AEA0", Offset = "0x7896A0", VA = "0x18078AEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KPFJFCCFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x15076E0", Offset = "0x1505EE0", VA = "0x1815076E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float PDKFHCMJPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EDEA10", Offset = "0x5EDD210", VA = "0x185EDEA10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float LADICBDLGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE940", Offset = "0x5EDD140", VA = "0x185EDE940")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9030", Offset = "0x5ED7830", VA = "0x185ED9030")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEAE0", Offset = "0x5EDD2E0", VA = "0x185EDEAE0")]
	public OKEJNCGOCLG(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEA50", Offset = "0x5EDD250", VA = "0x185EDEA50")]
	public void PGCCALFPFJC(int LLINBMPENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE950", Offset = "0x5EDD150", VA = "0x185EDE950")]
	public void KPGKLGIOIOM(float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4F10", Offset = "0x1FD3710", VA = "0x181FD4F10")]
	public void MDIFNPCNEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8F30", Offset = "0x5ED7730", VA = "0x185ED8F30")]
	public void BCKAGGCDANG(float[] KMJKCJJHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE830", Offset = "0x5EDD030", VA = "0x185EDE830")]
	public void BCKAGGCDANG(float[] KMJKCJJHEFM, int NNMNJCIAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEA20", Offset = "0x5EDD220", VA = "0x185EDEA20")]
	private int OCIHEMKPKIO(int LFEFGCGCIAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GHKMCGNBOEC
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int DJLJOCMEIKN = 512;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const int INKNGBDAENK = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int PHLALIGJHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float[] DIFFKHGGOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public RawImage GPFHIOAKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float PHOKJPLMKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float BLBLNLNCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float ALEFCCIAPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float MCCLCEIGAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float MLGKCANHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Color MMAEMPBJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Color JLMHCAOPFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public bool HPFJMIEGMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Color BJMAGMBHGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color CEOGPJAMJCA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly int NKECEDECDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly int BFHCIJLBLGD;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly int JJKIKKDAEOA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int AANFEKFDBKH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int DEMLLCIGJIL;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int FPPJFKMJPFD;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int BEKNDDOLCGD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int PKLDOBMJOBK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int AMCFFLAHKLK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int FMKJNLKEPOI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int GIANBMOODCG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int IOMLDLLJGHA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBC10", Offset = "0x5EDA410", VA = "0x185EDBC10")]
	public void FCHNCCOOPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBAD0", Offset = "0x5EDA2D0", VA = "0x185EDBAD0")]
	public void AIEAIKIJOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBB70", Offset = "0x5EDA370", VA = "0x185EDBB70")]
	public void DKIAALHEGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBFF0", Offset = "0x5EDA7F0", VA = "0x185EDBFF0")]
	public void PLNHNGFBBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBCD0", Offset = "0x5EDA4D0", VA = "0x185EDBCD0")]
	public void GBNJMPHLGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBE70", Offset = "0x5EDA670", VA = "0x185EDBE70")]
	public void JOFCFLPHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBF10", Offset = "0x5EDA710", VA = "0x185EDBF10")]
	public void NGIJDJIOHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC300", Offset = "0x5EDAB00", VA = "0x185EDC300")]
	public GHKMCGNBOEC()
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
		private MetricIdLookup KJPIHIMOFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IRawMetricsPipeline JHKIPLNPIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IMetricCollectionRegistry PPEJCBIOOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private MetricId CFEMEBMGNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int HHKDPIOCAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MetricAccumulateMode OGAIEJHPHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MetricCollectionToken KIAKEGJPMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MetricDescription MAAJIKCBNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GraphConfig EBEBJBMNKAM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE0A10", VA = "0x180AE2210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x768C80", Offset = "0x767480", VA = "0x180768C80", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAFA0", Offset = "0x5ED97A0", VA = "0x185EDAFA0")]
		private void ECKOJMLLEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAD30", Offset = "0x5ED9530", VA = "0x185EDAD30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB690", Offset = "0x5ED9E90", VA = "0x185EDB690", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB580", Offset = "0x5ED9D80", VA = "0x185EDB580")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB0F0", Offset = "0x5ED98F0", VA = "0x185EDB0F0")]
		public void Initialize(GraphConfig MKBMKNKPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAD90", Offset = "0x5ED9590", VA = "0x185EDAD90", Slot = "14")]
		protected override bool CJEHCLLLDOL(string IOHHPHCIMNC = "0.00", [Optional] string HEGALIFGLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAEA0", Offset = "0x5ED96A0", VA = "0x185EDAEA0")]
		public void HandleMetric([In] RawMetric DALINDHHNFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19D1BE0", Offset = "0x19D03E0", VA = "0x1819D1BE0", Slot = "4")]
		protected override NAFANMKLKDL OACPAENIAIO()
		{
			return default(NAFANMKLKDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB800", Offset = "0x5EDA000", VA = "0x185EDB800")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAEA0", Offset = "0x5ED96A0", VA = "0x185EDAEA0", Slot = "15")]
		private void DNFIPEKEOBP([In] RawMetric DALINDHHNFA)
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
		protected override int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x824360", Offset = "0x822B60", VA = "0x180824360", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xF45750", Offset = "0xF43F50", VA = "0x180F45750", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "4")]
		protected override NAFANMKLKDL OACPAENIAIO()
		{
			return default(NAFANMKLKDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB840", Offset = "0x5EDA040", VA = "0x185EDB840", Slot = "14")]
		protected override bool CJEHCLLLDOL(string IOHHPHCIMNC = "0.00", [Optional] string HEGALIFGLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB940", Offset = "0x5EDA140", VA = "0x185EDB940")]
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
		protected override int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x824360", Offset = "0x822B60", VA = "0x180824360", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF45750", Offset = "0xF43F50", VA = "0x180F45750", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "4")]
		protected override NAFANMKLKDL OACPAENIAIO()
		{
			return default(NAFANMKLKDL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB9C0", Offset = "0x5EDA1C0", VA = "0x185EDB9C0", Slot = "14")]
		protected override bool CJEHCLLLDOL(string IOHHPHCIMNC = "0.00", [Optional] string HEGALIFGLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAA0", Offset = "0x5EDA2A0", VA = "0x185EDBAA0")]
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
		private ProfilerRecorderHandle GAABCENONJB;

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
		private static bool PJNBGBJKFDH;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool DCIHMGNHCPH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF690", Offset = "0x5EDDE90", VA = "0x185EDF690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAE2200", Offset = "0xAE0A00", VA = "0x180AE2200", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE0A10", VA = "0x180AE2210", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "4")]
		protected override NAFANMKLKDL OACPAENIAIO()
		{
			return default(NAFANMKLKDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF4D0", Offset = "0x5EDDCD0", VA = "0x185EDF4D0", Slot = "14")]
		protected override bool CJEHCLLLDOL(string IOHHPHCIMNC = "0.00", [Optional] string HEGALIFGLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF5F0", Offset = "0x5EDDDF0", VA = "0x185EDF5F0")]
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
		protected override int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x824360", Offset = "0x822B60", VA = "0x180824360", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF45750", Offset = "0xF43F50", VA = "0x180F45750", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CE0", Offset = "0x7E24E0", VA = "0x1807E3CE0", Slot = "4")]
		protected override NAFANMKLKDL OACPAENIAIO()
		{
			return default(NAFANMKLKDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF6A0", Offset = "0x5EDDEA0", VA = "0x185EDF6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDC350", Offset = "0x5EDAB50", VA = "0x185EDC350")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC730", Offset = "0x5EDAF30", VA = "0x185EDC730")]
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
		private bool EDKMOANODIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool NBHENPMKCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool MBGMPNLMBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Data Text")]
		[SerializeField]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private bool EJKFFHBKKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool GHCNAIIGBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool HJJDHCBGAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool DHENKHDNIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool GGHAJKOLOME;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string NGIGPGHLPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCF10", Offset = "0x5EDB710", VA = "0x185EDCF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD0B0", Offset = "0x5EDB8B0", VA = "0x185EDD0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string PDJDBHOHOOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCEB0", Offset = "0x5EDB6B0", VA = "0x185EDCEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCF70", Offset = "0x5EDB770", VA = "0x185EDCF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string ANJEKJGGIEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCED0", Offset = "0x5EDB6D0", VA = "0x185EDCED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCFF0", Offset = "0x5EDB7F0", VA = "0x185EDCFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string NPCHPECIFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCF20", Offset = "0x5EDB720", VA = "0x185EDCF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD0F0", Offset = "0x5EDB8F0", VA = "0x185EDD0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string GMKIFBAHNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCEC0", Offset = "0x5EDB6C0", VA = "0x185EDCEC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCFB0", Offset = "0x5EDB7B0", VA = "0x185EDCFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string MOIPLNCFNAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCF00", Offset = "0x5EDB700", VA = "0x185EDCF00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD070", Offset = "0x5EDB870", VA = "0x185EDD070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string CJFBEBLLMIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCEE0", Offset = "0x5EDB6E0", VA = "0x185EDCEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD030", Offset = "0x5EDB830", VA = "0x185EDD030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string GAAKLEIMCME
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCE90", Offset = "0x5EDB690", VA = "0x185EDCE90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCF30", Offset = "0x5EDB730", VA = "0x185EDCF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCDB0", Offset = "0x5EDB5B0", VA = "0x185EDCDB0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCCF0", Offset = "0x5EDB4F0", VA = "0x185EDCCF0")]
		protected string HDOLLMOGNKH(bool GGFHJKLPMFC, TMP_Text KLIANGHAKAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCD70", Offset = "0x5EDB570", VA = "0x185EDCD70")]
		protected void OIIPGLJJPCN(bool GFMPMBBMNOM, TMP_Text KMJKCJJHEFM, string FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
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
		protected const string INCCKKNPPIC = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected double DIANNFLDBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected double BBKILLOBILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected double PILDNBGNHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected double BGJDFEAMKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected double CANKLNMMDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected int BKJNJICPHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected double GNEPCOBPHJE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int KCDAIPDLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode ECALCFLPFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected bool KPENOGKMCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC70", Offset = "0xA3C470", VA = "0x180A3DC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA3DF40", Offset = "0xA3C740", VA = "0x180A3DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract NAFANMKLKDL OACPAENIAIO();

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void HBINFGGJACP();

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEE6F10", Offset = "0xEE5710", VA = "0x180EE6F10", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xEE6F10", Offset = "0xEE5710", VA = "0x180EE6F10")]
		protected void OIHOMDLICEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCCB0", Offset = "0x5EDB4B0", VA = "0x185EDCCB0", Slot = "10")]
		protected virtual void PDFMONHLFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC960", Offset = "0x5EDB160", VA = "0x185EDC960", Slot = "11")]
		protected virtual void LCGBEBODPAE(double LHKFFEGLEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC800", Offset = "0x5EDB000", VA = "0x185EDC800", Slot = "12")]
		protected virtual double JJJDFHAMIPG(MetricAccumulateMode OGAIEJHPHFO)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCA20", Offset = "0x5EDB220", VA = "0x185EDCA20")]
		protected bool OAOKJCKPEEL(MetricGraph OKFJLNJMHFK, MetricAccumulateMode FDFIAAFCBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCB80", Offset = "0x5EDB380", VA = "0x185EDCB80", Slot = "13")]
		protected virtual string OFDIJPHFCAC(double FKKGMPDEPMA, string KDEPONGBNBL = "0.00", [Optional] string MNOKKIJBAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAA0", Offset = "0x5EDA2A0", VA = "0x185EDBAA0")]
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
		protected bool ECKCHHDBEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected bool JJMEMFIDJJC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFBE0", Offset = "0x5EDE3E0", VA = "0x185EDFBE0", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFA30", Offset = "0x5EDE230", VA = "0x185EDFA30", Slot = "5")]
		protected override void HBINFGGJACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF6E0", Offset = "0x5EDDEE0", VA = "0x185EDF6E0", Slot = "14")]
		protected virtual bool CJEHCLLLDOL(string IOHHPHCIMNC = "0.00", [Optional] string HEGALIFGLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAA0", Offset = "0x5EDA2A0", VA = "0x185EDBAA0")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEBBFIEAKAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool CFNCBLLJGFM
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
	RawMetricPayload CEKKCGDPMNO();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PEFMCDLJFJO : OEBBFIEAKAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static bool PJNBGBJKFDH;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> HDAPACJACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly MetricId CFEMEBMGNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly string OPFEBPDKAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly string OFCAACPJLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private ProfilerRecorder CDPKGBKBLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool BCFKAEIJGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool PNIAPPEKEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ProfilerRecorderDescription EKIHIAACMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private ProfilerRecorderHandle GAABCENONJB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89BFC0", Offset = "0x89A7C0", VA = "0x18089BFC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private MetricDescription OBMCOEDGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x54D7FB0", Offset = "0x54D67B0", VA = "0x1854D7FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF460", Offset = "0x5EDDC60", VA = "0x185EDF460")]
	public PEFMCDLJFJO(MetricId CFEMEBMGNPG, string OPFEBPDKAMP, string OFCAACPJLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEB50", Offset = "0x5EDD350", VA = "0x185EDEB50", Slot = "6")]
	public RawMetricPayload CEKKCGDPMNO()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF260", Offset = "0x5EDDA60", VA = "0x185EDF260")]
	private static ProfilerRecorderHandle PEDOMDILBBK(string OPFEBPDKAMP, string OFCAACPJLCD)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEF60", Offset = "0x5EDD760", VA = "0x185EDEF60")]
	private void NFMLAKBDFHB(bool AKFFELDLHDA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEC10", Offset = "0x5EDD410", VA = "0x185EDEC10")]
	private static MetricDescription EFFHHALJDPM(MetricId CFEMEBMGNPG, ProfilerRecorderDescription CAFIJLKNLNL)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEC90", Offset = "0x5EDD490", VA = "0x185EDEC90")]
	private static bool MHFCIIHANNN(bool AKFFELDLHDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEBF0", Offset = "0x5EDD3F0", VA = "0x185EDEBF0")]
	private void IFGDLMKAOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEBF0", Offset = "0x5EDD3F0", VA = "0x185EDEBF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AHIIAHMICMJ : OEBBFIEAKAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<double> GDFIIKHNEFC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x770F70", Offset = "0x76F770", VA = "0x180770F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDACE0", Offset = "0x5ED94E0", VA = "0x185EDACE0")]
	public AHIIAHMICMJ(Func<double> GDFIIKHNEFC, MetricDescription MAAJIKCBNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAC70", Offset = "0x5ED9470", VA = "0x185EDAC70", Slot = "6")]
	public RawMetricPayload CEKKCGDPMNO()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ADGNPLHALPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct DMLLODBGODA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly string ACFKLOBLPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly string PGEKIOFGCGN;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
		public DMLLODBGODA(string OPFEBPDKAMP, string OFCAACPJLCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AGGKBOKAEFL : IAsyncStateMachine
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
		public ADGNPLHALPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAA30", Offset = "0x5ED9230", VA = "0x185EDAA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAC10", Offset = "0x5ED9410", VA = "0x185EDAC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MetricIdLookup KJPIHIMOFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IRawMetricsPipeline JHKIPLNPIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IMetricCollectionRegistry PPEJCBIOOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Dictionary<MetricId, OEBBFIEAKAO> ELGLDOBEKFO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly DMLLODBGODA[] JCBFCEJLJDL;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9380", Offset = "0x5ED7B80", VA = "0x185ED9380")]
	[NJKKEFDLCAD(AFMDLPKJFNK.GameOnly)]
	private static void MCAIAAGMENI(LLKIHBKOOLA OBCMACCCGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA1E0", Offset = "0x5ED89E0", VA = "0x185EDA1E0")]
	[Preserve]
	public ADGNPLHALPN([KEKICHOEFEB(null)] MetricIdLookup KJPIHIMOFCG, [KEKICHOEFEB(null)] IRawMetricsPipeline JHKIPLNPIMM, [KEKICHOEFEB(null)] IMetricCollectionRegistry PPEJCBIOOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED92B0", Offset = "0x5ED7AB0", VA = "0x185ED92B0")]
	private void FOFNCINIPPF(string CNGLEEJHEDP, string OFCAACPJLCD, NAFANMKLKDL CJCDIGBFPMK, Func<double> GDFIIKHNEFC, [Out] MetricId CFEMEBMGNPG, [Out] OEBBFIEAKAO KLIANGHAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED91D0", Offset = "0x5ED79D0", VA = "0x185ED91D0")]
	private void BPIHLJDNCGG(MetricId CFEMEBMGNPG, bool PECLGAGICOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED90E0", Offset = "0x5ED78E0", VA = "0x185ED90E0")]
	[AsyncStateMachine(typeof(AGGKBOKAEFL))]
	private Task BMMAJPDKFBI(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9480", Offset = "0x5ED7C80", VA = "0x185ED9480")]
	public void MJPCCAPOEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9270", Offset = "0x5ED7A70", VA = "0x185ED9270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDC330", Offset = "0x5EDAB30", VA = "0x185EDC330")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
