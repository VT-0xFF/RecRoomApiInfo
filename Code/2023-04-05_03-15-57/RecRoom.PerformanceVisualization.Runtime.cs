using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Profiling.Core;
using TMPro;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker JGOIFGJPKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker NBHGFIAEKHK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int BLGEKPHKPMA = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int APGNEHCANMJ = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ILPPGIIJEDI OCHBJBIOPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool FEPHIFGADBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float MFIFIPPCLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float ICGONNECKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float JPIBDJJEHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float FPNGGHNLIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float HFLDMOPIGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[Header("Graph Visuals")]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Space]
		[SerializeField]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Space]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private bool higherValueIsBetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EGBLOGFBMGI PCAFLFHFNFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int HECMCOHFBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x65A4290", Offset = "0x65A3290", VA = "0x1865A4290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int FOOELGKFMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x65A4FB0", Offset = "0x65A3FB0", VA = "0x1865A4FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int FHKEOMHDOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x65A4FD0", Offset = "0x65A3FD0", VA = "0x1865A4FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FGKIJCPKCNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x65A5720", Offset = "0x65A4720", VA = "0x1865A5720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GGCPLPBFMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x65A56F0", Offset = "0x65A46F0", VA = "0x1865A56F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float PFIMFDBAPPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x65A5650", Offset = "0x65A4650", VA = "0x1865A5650")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float IFIOIECJBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x65A5690", Offset = "0x65A4690", VA = "0x1865A5690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float HIFDKLPGPFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x65A5670", Offset = "0x65A4670", VA = "0x1865A5670")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PGNCDPEGKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x65A56B0", Offset = "0x65A46B0", VA = "0x1865A56B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float COFLGBGKCCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x65A56D0", Offset = "0x65A46D0", VA = "0x1865A56D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65A42B0", Offset = "0x65A32B0", VA = "0x1865A42B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65A5430", Offset = "0x65A4430", VA = "0x1865A5430")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65A5040", Offset = "0x65A4040", VA = "0x1865A5040")]
		public void PushSample(double LODAGNBBEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65A42D0", Offset = "0x65A32D0", VA = "0x1865A42D0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65A4470", Offset = "0x65A3470", VA = "0x1865A4470")]
		private void IFJBPFEGGPB(bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65A5130", Offset = "0x65A4130", VA = "0x1865A5130")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x65A42F0", Offset = "0x65A32F0", VA = "0x1865A42F0")]
		private void HPLLEBLEKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65A4690", Offset = "0x65A3690", VA = "0x1865A4690")]
		private void JKEDBNPMAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65A5460", Offset = "0x65A4460", VA = "0x1865A5460")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class ILPPGIIJEDI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LJLBNNCBKLB : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>3__maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ILPPGIIJEDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <startIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x10614A0", Offset = "0x10604A0", VA = "0x1810614A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x65A34F0", Offset = "0x65A24F0", VA = "0x1865A34F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x987020", Offset = "0x986020", VA = "0x180987020")]
		[DebuggerHidden]
		public LJLBNNCBKLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x65A3320", Offset = "0x65A2320", VA = "0x1865A3320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x65A34B0", Offset = "0x65A24B0", VA = "0x1865A34B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x65A3400", Offset = "0x65A2400", VA = "0x1865A3400", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65A3400", Offset = "0x65A2400", VA = "0x1865A3400", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected float[] JHPDLICKDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected int DHKAHJCBEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	protected int KJAHKKMJHHG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC90", Offset = "0x6F9C90", VA = "0x1806FAC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B31B0", Offset = "0x8B21B0", VA = "0x1808B31B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float DEPCPABAEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65A2FB0", Offset = "0x65A1FB0", VA = "0x1865A2FB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float GLDAKBOLAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65A2FC0", Offset = "0x65A1FC0", VA = "0x1865A2FC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65A1B70", Offset = "0x65A0B70", VA = "0x1865A1B70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65A32B0", Offset = "0x65A22B0", VA = "0x1865A32B0")]
	public ILPPGIIJEDI(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65A30E0", Offset = "0x65A20E0", VA = "0x1865A30E0")]
	public void MMGHCEPKACF(int DHPEOIEBOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65A2EE0", Offset = "0x65A1EE0", VA = "0x1865A2EE0")]
	public void AMFOCGCLIFJ(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x65A2FD0", Offset = "0x65A1FD0", VA = "0x1865A2FD0")]
	public void EGIHPFCJCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65A2FE0", Offset = "0x65A1FE0", VA = "0x1865A2FE0")]
	public IEnumerable<float> FNMBIENDFGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65A3060", Offset = "0x65A2060", VA = "0x1865A3060")]
	[IteratorStateMachine(typeof(LJLBNNCBKLB))]
	public IEnumerable<float> FNMBIENDFGF(int NPFPHMBDNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65A1C20", Offset = "0x65A0C20", VA = "0x1865A1C20")]
	public void NAEGOODHAMO(float[] NMAMPMADCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65A31A0", Offset = "0x65A21A0", VA = "0x1865A31A0")]
	public void NAEGOODHAMO(float[] NMAMPMADCBK, int CONCAODKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65A3170", Offset = "0x65A2170", VA = "0x1865A3170")]
	private int MNNLHKEIIDM(int EGBCAPEEJBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EGBLOGFBMGI
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int FBIEADNPNLP = 512;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const int HFEHJNBCKPD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int FEPDGMKOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float[] CONKOLOOBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public RawImage HFAFDKPBHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float BMHEECDBKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float PHNGHOLBIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float NNECDJLGOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float FNHIDFJNKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float IBEALHBHGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Color AMEHAJMOGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Color BMDAHCMEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public bool EDBDDALIJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Color OMPLLOHGBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color EOEBCJLHCIK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly int CMONIPGDFKI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly int HKCKFLCJLJK;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly int LJIGEEDJFFB;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int FIPNBEMKDMP;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int INBFAKFFHPB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int BHMJGEIICPL;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int EEPFJLDIHEE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int BHMHLCDFHKI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int PLAIDJCOPJK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int DCMMEPGGFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int HEJPMBGMCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int AKOPGEFCPKH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65A1F50", Offset = "0x65A0F50", VA = "0x1865A1F50")]
	public void HCLPKEDCPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65A1EA0", Offset = "0x65A0EA0", VA = "0x1865A1EA0")]
	public void FOFGAEKKAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65A1D20", Offset = "0x65A0D20", VA = "0x1865A1D20")]
	public void ADGIMNHBAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65A2010", Offset = "0x65A1010", VA = "0x1865A2010")]
	public void JMGPDAPHOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65A2190", Offset = "0x65A1190", VA = "0x1865A2190")]
	public void PCDMMMHENCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65A20F0", Offset = "0x65A10F0", VA = "0x1865A20F0")]
	public void NEFBOOIKBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65A1DC0", Offset = "0x65A0DC0", VA = "0x1865A1DC0")]
	public void AMBLDEPJCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65A2560", Offset = "0x65A1560", VA = "0x1865A2560")]
	public EGBLOGFBMGI()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override int HEIJMLBAKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71B6B0", Offset = "0x71A6B0", VA = "0x18071B6B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode OMIKBCKAILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA3BEE0", Offset = "0xA3AEE0", VA = "0x180A3BEE0", Slot = "8")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65A26E0", Offset = "0x65A16E0", VA = "0x1865A26E0", Slot = "4")]
		protected override double MIKLPFBEPCD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "5")]
		protected override ProfilerMarkerDataUnit LHDEBIBLBNI()
		{
			return default(ProfilerMarkerDataUnit);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x65A25E0", Offset = "0x65A15E0", VA = "0x1865A25E0", Slot = "15")]
		protected override bool FMEFGEAHPFL(string IDJFGIDAFGE = "0.00", [Optional] string MEAMOIDPEMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x65A2710", Offset = "0x65A1710", VA = "0x1865A2710")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override int HEIJMLBAKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x71B6B0", Offset = "0x71A6B0", VA = "0x18071B6B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode OMIKBCKAILF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA3BEE0", Offset = "0xA3AEE0", VA = "0x180A3BEE0", Slot = "8")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x65A2860", Offset = "0x65A1860", VA = "0x1865A2860", Slot = "4")]
		protected override double MIKLPFBEPCD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "5")]
		protected override ProfilerMarkerDataUnit LHDEBIBLBNI()
		{
			return default(ProfilerMarkerDataUnit);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65A2780", Offset = "0x65A1780", VA = "0x1865A2780", Slot = "15")]
		protected override bool FMEFGEAHPFL(string IDJFGIDAFGE = "0.00", [Optional] string MEAMOIDPEMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x65A2880", Offset = "0x65A1880", VA = "0x1865A2880")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[Header("Profiling Metric")]
		private string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ProfilerRecorderHandle KJHMKHAOFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private ProfilerRecorder EEHKIBKNMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool LJBNOCGAGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool EECOLLOFIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private ProfilerRecorderDescription BJAIPLMNIJA;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static bool MJNLODNLAAN;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> KOHGAJCCEBP;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BOFLMBPAIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x65A61C0", Offset = "0x65A51C0", VA = "0x1865A61C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override int HEIJMLBAKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9C3750", Offset = "0x9C2750", VA = "0x1809C3750", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected override MetricAccumulateMode OMIKBCKAILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9C3760", Offset = "0x9C2760", VA = "0x1809C3760", Slot = "8")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65A5CC0", Offset = "0x65A4CC0", VA = "0x1865A5CC0", Slot = "4")]
		protected override double MIKLPFBEPCD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E55F20", Offset = "0x1E54F20", VA = "0x181E55F20", Slot = "5")]
		protected override ProfilerMarkerDataUnit LHDEBIBLBNI()
		{
			return default(ProfilerMarkerDataUnit);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x65A59F0", Offset = "0x65A49F0", VA = "0x1865A59F0", Slot = "15")]
		protected override bool FMEFGEAHPFL(string IDJFGIDAFGE = "0.00", [Optional] string MEAMOIDPEMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x65A5FD0", Offset = "0x65A4FD0", VA = "0x1865A5FD0", Slot = "10")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x65A5B40", Offset = "0x65A4B40", VA = "0x1865A5B40")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65A5740", Offset = "0x65A4740", VA = "0x1865A5740")]
		private void BBPKEBIAJEI(bool AKNNPOEHKML = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65A5B40", Offset = "0x65A4B40", VA = "0x1865A5B40")]
		private void GDAIPDMMGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65A5B60", Offset = "0x65A4B60", VA = "0x1865A5B60")]
		private static ProfilerRecorderHandle KIDOJHOOPGI(string ECCPAGEJGED, string PGJHCEENHAP)
		{
			return default(ProfilerRecorderHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65A5D00", Offset = "0x65A4D00", VA = "0x1865A5D00")]
		private static bool OJOMEEGBPNI(bool AKNNPOEHKML = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65A6130", Offset = "0x65A5130", VA = "0x1865A6130")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[Min(0f)]
		[Header("Accumulation")]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[Header("Random Range")]
		[Range(0f, 99f)]
		private float randomMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[Range(1f, 100f)]
		private float randomMax;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override int HEIJMLBAKDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x71B6B0", Offset = "0x71A6B0", VA = "0x18071B6B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode OMIKBCKAILF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA3BEE0", Offset = "0xA3AEE0", VA = "0x180A3BEE0", Slot = "8")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x65A61D0", Offset = "0x65A51D0", VA = "0x1865A61D0", Slot = "4")]
		protected override double MIKLPFBEPCD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x799040", Offset = "0x798040", VA = "0x180799040", Slot = "5")]
		protected override ProfilerMarkerDataUnit LHDEBIBLBNI()
		{
			return default(ProfilerMarkerDataUnit);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x65A6200", Offset = "0x65A5200", VA = "0x1865A6200")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[Header("Metric Text")]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool JMMGKLGHMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool AHONIHKJHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool CJOCIKPNCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private bool DBBBPGHJNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool NLABLJBPEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool KNMHCJLKJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool JEBEFJAOPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool GDKBPILMPIM;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string JNMBBNBMKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x65A3F90", Offset = "0x65A2F90", VA = "0x1865A3F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x65A4210", Offset = "0x65A3210", VA = "0x1865A4210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string POGHEDJBKAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x65A3D10", Offset = "0x65A2D10", VA = "0x1865A3D10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x65A40D0", Offset = "0x65A30D0", VA = "0x1865A40D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string HECPOGCDCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x65A3E10", Offset = "0x65A2E10", VA = "0x1865A3E10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x65A4150", Offset = "0x65A3150", VA = "0x1865A4150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string JEDENLCFOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x65A4010", Offset = "0x65A3010", VA = "0x1865A4010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x65A4250", Offset = "0x65A3250", VA = "0x1865A4250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string MBILOHNICHC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x65A3D90", Offset = "0x65A2D90", VA = "0x1865A3D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x65A4110", Offset = "0x65A3110", VA = "0x1865A4110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string PDDHONENGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x65A3F10", Offset = "0x65A2F10", VA = "0x1865A3F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x65A41D0", Offset = "0x65A31D0", VA = "0x1865A41D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string HNFGFDFKAJN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x65A3E90", Offset = "0x65A2E90", VA = "0x1865A3E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x65A4190", Offset = "0x65A3190", VA = "0x1865A4190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string EEFIKCFEGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x65A3C90", Offset = "0x65A2C90", VA = "0x1865A3C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x65A4090", Offset = "0x65A3090", VA = "0x1865A4090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x65A3BA0", Offset = "0x65A2BA0", VA = "0x1865A3BA0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x65A3B20", Offset = "0x65A2B20", VA = "0x1865A3B20")]
		protected string OMBJILEHBML(bool GHPJGHFBNEE, ref TMP_Text EHNCKNECPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65A3AE0", Offset = "0x65A2AE0", VA = "0x1865A3AE0")]
		protected void HLPHAGHEDJB(bool GDKAEDBJFNO, ref TMP_Text NMAMPMADCBK, string KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		protected enum MetricAccumulateMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Average,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			AveragePerSecond,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Max,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Min,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			First,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Last,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Sum
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected const string FEFLMADGEPI = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected double MMBPCOCMHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected double EHEDAKPPDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected double LHAMPGCOIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected double CDMIFMAGMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		protected double DOCIHHEAOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected int MNBBFNEDFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected double ALGHGIBHBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool NDENNDHIIHG;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected abstract int HEIJMLBAKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected abstract MetricAccumulateMode OMIKBCKAILF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract double MIKLPFBEPCD();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract ProfilerMarkerDataUnit LHDEBIBLBNI();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FHDFCGNFCLK();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x15449C0", Offset = "0x15439C0", VA = "0x1815449C0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65A3A60", Offset = "0x65A2A60", VA = "0x1865A3A60", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x65A3920", Offset = "0x65A2920", VA = "0x1865A3920", Slot = "11")]
		protected virtual void JBBHMIDOPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x65A3990", Offset = "0x65A2990", VA = "0x1865A3990", Slot = "12")]
		protected virtual void KMHDKGNBPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65A37E0", Offset = "0x65A27E0", VA = "0x1865A37E0", Slot = "13")]
		protected virtual double FDCBFGFACBC(MetricAccumulateMode NCAKOGHCIEP)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65A3540", Offset = "0x65A2540", VA = "0x1865A3540")]
		protected bool BJJDECCJKIA(MetricGraph FIOLNGJADNH, MetricAccumulateMode COAEGBJAHMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65A36C0", Offset = "0x65A26C0", VA = "0x1865A36C0", Slot = "14")]
		protected virtual string DEBNEGHICJJ(double KPPLMEOMNGF, string GNDANPNHEDO = "0.00", [Optional] string KLILFMJJFDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65A2880", Offset = "0x65A1880", VA = "0x1865A2880")]
		protected MetricGraphDriverBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[FormerlySerializedAs("targetGraph")]
		[Header("Graph and Text")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected bool JMBBCOFBDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected bool BCBKKCOEODB;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65A6740", Offset = "0x65A5740", VA = "0x1865A6740", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65A6240", Offset = "0x65A5240", VA = "0x1865A6240", Slot = "6")]
		protected override void FHDFCGNFCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65A6400", Offset = "0x65A5400", VA = "0x1865A6400", Slot = "15")]
		protected virtual bool FMEFGEAHPFL(string IDJFGIDAFGE = "0.00", [Optional] string MEAMOIDPEMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65A2880", Offset = "0x65A1880", VA = "0x1865A2880")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65A28B0", Offset = "0x65A18B0", VA = "0x1865A28B0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x65A29C0", Offset = "0x65A19C0", VA = "0x1865A29C0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
