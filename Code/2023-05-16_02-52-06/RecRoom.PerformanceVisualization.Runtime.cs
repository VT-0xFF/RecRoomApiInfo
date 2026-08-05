using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
		private ProfilerMarker IEKFFDNNELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ProfilerMarker OFLOBAJFDEE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int LGOCCCGHOBD = 8;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int AEEIDBOIAEF = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KKBJPOBFEAJ PBJFNPPHMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool CPALODDMOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private float LBBFNNJFOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float JMJHNEFCCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float DEEILHDDOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float DHHLFFLIODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float JCPHKDJJBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Header("Graph")]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
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
		private GFIPAOHMNNL MJIKFKFEENG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int LEPOEFHNBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x67A50A0", Offset = "0x67A3EA0", VA = "0x1867A50A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int LKPEKGPHIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x67A5080", Offset = "0x67A3E80", VA = "0x1867A5080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int EOAPKOJDMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x67A5250", Offset = "0x67A4050", VA = "0x1867A5250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GGKJBJIFEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x67A5BC0", Offset = "0x67A49C0", VA = "0x1867A5BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EHFLOBLPPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x67A5B90", Offset = "0x67A4990", VA = "0x1867A5B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float FKICBHOEPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67A5AF0", Offset = "0x67A48F0", VA = "0x1867A5AF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HEJFCMPKGOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67A5B30", Offset = "0x67A4930", VA = "0x1867A5B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float PMFIKKIEGHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67A5B10", Offset = "0x67A4910", VA = "0x1867A5B10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float GKLIIEECBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67A5B50", Offset = "0x67A4950", VA = "0x1867A5B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float PGNIKOCMHPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x67A5B70", Offset = "0x67A4970", VA = "0x1867A5B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67A4710", Offset = "0x67A3510", VA = "0x1867A4710")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67A58D0", Offset = "0x67A46D0", VA = "0x1867A58D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67A54E0", Offset = "0x67A42E0", VA = "0x1867A54E0")]
		public void PushSample(double JNNHIFGDGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67A5060", Offset = "0x67A3E60", VA = "0x1867A5060")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67A52C0", Offset = "0x67A40C0", VA = "0x1867A52C0")]
		private void PNMPNFIIDMA(bool ONFDAKCOPIF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x67A55D0", Offset = "0x67A43D0", VA = "0x1867A55D0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x67A50C0", Offset = "0x67A3EC0", VA = "0x1867A50C0")]
		public void InitData(int IFGHFDNINMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67A4740", Offset = "0x67A3540", VA = "0x1867A4740")]
		private void BFIMEKKBNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67A5900", Offset = "0x67A4700", VA = "0x1867A5900")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class KKBJPOBFEAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IOCHMNIGCKC : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>3__maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KKBJPOBFEAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <startIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x125CA80", Offset = "0x125B880", VA = "0x18125CA80", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67A1070", Offset = "0x679FE70", VA = "0x1867A1070", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D0790", Offset = "0x9CF590", VA = "0x1809D0790")]
		[DebuggerHidden]
		public IOCHMNIGCKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67A0EA0", Offset = "0x679FCA0", VA = "0x1867A0EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67A1030", Offset = "0x679FE30", VA = "0x1867A1030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67A0F80", Offset = "0x679FD80", VA = "0x1867A0F80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67A0F80", Offset = "0x679FD80", VA = "0x1867A0F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	protected float[] IFGLHAJNAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	protected int FOHHAFPJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	protected int MNBBKKLFBKD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75BC20", VA = "0x18075CE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x916280", Offset = "0x915080", VA = "0x180916280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float JBGEEBBIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67A3190", Offset = "0x67A1F90", VA = "0x1867A3190")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float GJPDLABKKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67A33B0", Offset = "0x67A21B0", VA = "0x1867A33B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x679F7B0", Offset = "0x679E5B0", VA = "0x18679F7B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67A3520", Offset = "0x67A2320", VA = "0x1867A3520")]
	public KKBJPOBFEAJ(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67A3490", Offset = "0x67A2290", VA = "0x1867A3490")]
	public void NKDEFIKDPCD(int GJPPBHMGBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67A33C0", Offset = "0x67A21C0", VA = "0x1867A33C0")]
	public void HMGFIBBPBED(float MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42A9A90", Offset = "0x42A8890", VA = "0x1842A9A90")]
	public void MPBAGGPHKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x67A3220", Offset = "0x67A2020", VA = "0x1867A3220")]
	public IEnumerable<float> GCNHOOLFCAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67A31A0", Offset = "0x67A1FA0", VA = "0x1867A31A0")]
	[IteratorStateMachine(typeof(IOCHMNIGCKC))]
	public IEnumerable<float> GCNHOOLFCAM(int LHODAPEMIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x679F6B0", Offset = "0x679E4B0", VA = "0x18679F6B0")]
	public void GFIGCBFKEBD(float[] ONDHOAIGIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67A32A0", Offset = "0x67A20A0", VA = "0x1867A32A0")]
	public void GFIGCBFKEBD(float[] ONDHOAIGIEB, int JMLJEEEFEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67A3160", Offset = "0x67A1F60", VA = "0x1867A3160")]
	private int COLCMKIJBOI(int NNHNOIMLALG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GFIPAOHMNNL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const int IHGHPLOAPOH = 512;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const int NIMDKBFGKKN = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int PCPNDOAAGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float[] AOKHPEFDNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public RawImage BNOBDIIHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float BODKFEMGEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float HBPKLHDHONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float GAECGEJFAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float PGNEJCBPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float PNJNGILFJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color GIGGGPKBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color NIJFELACPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool LHMFEFPGMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Color ICFPCMMAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Color KNNDEPPPCND;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int MMAHJJLBMNL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int OAHPHILPHDM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int JFNEPNLONBL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int NCCMFMJCBAL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int GHHEFMHENFP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int HKJFJAMBFID;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int IHCIBDKGOAN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int ONAPKCBNIBL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int EIAJHPBGPFH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly int LBAFKCEEPCK;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly int AADGEDPIEOI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly int FMIFIFNHNBB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67A05C0", Offset = "0x679F3C0", VA = "0x1867A05C0")]
	public void FPNKJMFDOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67A0800", Offset = "0x679F600", VA = "0x1867A0800")]
	public void MGDKCNLIDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67A0760", Offset = "0x679F560", VA = "0x1867A0760")]
	public void LBNGCGIGDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67A0680", Offset = "0x679F480", VA = "0x1867A0680")]
	public void JHCAHHNNJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67A08B0", Offset = "0x679F6B0", VA = "0x1867A08B0")]
	public void MOBBKNJEJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67A0B30", Offset = "0x679F930", VA = "0x1867A0B30")]
	public void OHMLOOCLBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67A0A50", Offset = "0x679F850", VA = "0x1867A0A50")]
	public void OCEBCPEAOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67A0E00", Offset = "0x679FC00", VA = "0x1867A0E00")]
	public GFIPAOHMNNL()
	{
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ConfigurablePipelineGraphDriver : SingleMetricGraphDriver, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MetricIdLookup ALHDIHJEHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IRawMetricsPipeline DIFDDMBDHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IMetricCollectionRegistry NNDHMCJMMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricId NINDMEEEKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int IPNGLMFIMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MetricAccumulateMode OIOPLPMFOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MetricCollectionToken AMBDKIOJFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MetricDescription NCHMBMDLPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private GraphConfig IOMMALPDBFC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA2B4E0", Offset = "0xA2A2E0", VA = "0x180A2B4E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA887D0", Offset = "0xA875D0", VA = "0x180A887D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x679FE50", Offset = "0x679EC50", VA = "0x18679FE50")]
		private void OHMPFDPOLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x679F860", Offset = "0x679E660", VA = "0x18679F860", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67A0040", Offset = "0x679EE40", VA = "0x1867A0040", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x679FFB0", Offset = "0x679EDB0", VA = "0x18679FFB0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x679FAC0", Offset = "0x679E8C0", VA = "0x18679FAC0")]
		public void Initialize(GraphConfig MOINNJBAKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x679F8C0", Offset = "0x679E6C0", VA = "0x18679F8C0", Slot = "14")]
		protected override bool ENALFHECGFD(string FEACJBADEHO = "0.00", [Optional] string HGPHLMMDECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x679F9C0", Offset = "0x679E7C0", VA = "0x18679F9C0")]
		public void HandleMetric(in RawMetric BDNMHBIOGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDE05A0", Offset = "0xDDF3A0", VA = "0x180DE05A0", Slot = "4")]
		protected override OGFFBLBPKKJ LNHJLMICMDO()
		{
			return default(OGFFBLBPKKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67A01C0", Offset = "0x679EFC0", VA = "0x1867A01C0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x679F9C0", Offset = "0x679E7C0", VA = "0x18679F9C0", Slot = "15")]
		private void HBHHHGBKJII(in RawMetric BDNMHBIOGAE)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FPSMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private string DisplayFormat;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x77D840", Offset = "0x77C640", VA = "0x18077D840", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA87570", Offset = "0xA86370", VA = "0x180A87570", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "4")]
		protected override OGFFBLBPKKJ LNHJLMICMDO()
		{
			return default(OGFFBLBPKKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67A0340", Offset = "0x679F140", VA = "0x1867A0340", Slot = "14")]
		protected override bool ENALFHECGFD(string FEACJBADEHO = "0.00", [Optional] string HGPHLMMDECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67A0440", Offset = "0x679F240", VA = "0x1867A0440")]
		public FPSMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class FrameTimeMetricGraphDriver : SingleMetricGraphDriver
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

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected override int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x77D840", Offset = "0x77C640", VA = "0x18077D840", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA87570", Offset = "0xA86370", VA = "0x180A87570", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "4")]
		protected override OGFFBLBPKKJ LNHJLMICMDO()
		{
			return default(OGFFBLBPKKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67A04B0", Offset = "0x679F2B0", VA = "0x1867A04B0", Slot = "14")]
		protected override bool ENALFHECGFD(string FEACJBADEHO = "0.00", [Optional] string HGPHLMMDECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67A0590", Offset = "0x679F390", VA = "0x1867A0590")]
		public FrameTimeMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ProfilingMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[Header("Profiling Metric")]
		public string metricCategoryName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		public string metricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private ProfilerRecorderHandle MIGKGCFAMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static bool HBIGCNEIHNK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool CBNFMAIHPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67A6810", Offset = "0x67A5610", VA = "0x1867A6810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B4D0", Offset = "0xA2A2D0", VA = "0x180A2B4D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B4E0", Offset = "0xA2A2E0", VA = "0x180A2B4E0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "4")]
		protected override OGFFBLBPKKJ LNHJLMICMDO()
		{
			return default(OGFFBLBPKKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6670", Offset = "0x67A5470", VA = "0x1867A6670", Slot = "14")]
		protected override bool ENALFHECGFD(string FEACJBADEHO = "0.00", [Optional] string HGPHLMMDECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67A6790", Offset = "0x67A5590", VA = "0x1867A6790")]
		public ProfilingMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RandomMetricGraphDriver : SingleMetricGraphDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[Header("Accumulation")]
		[Min(0f)]
		private int framesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private MetricAccumulateMode accumulateModeToUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[Header("Random Range")]
		[Range(0f, 99f)]
		private float randomMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[Range(1f, 100f)]
		private float randomMax;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected override int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x77D840", Offset = "0x77C640", VA = "0x18077D840", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected override MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA87570", Offset = "0xA86370", VA = "0x180A87570", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75C420", Offset = "0x75B220", VA = "0x18075C420", Slot = "4")]
		protected override OGFFBLBPKKJ LNHJLMICMDO()
		{
			return default(OGFFBLBPKKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67A6820", Offset = "0x67A5620", VA = "0x1867A6820")]
		public RandomMetricGraphDriver()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MetricDashboard : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private List<ConfigurablePipelineGraphDriver> metricGraphDriverBases;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private List<GraphConfigAsset> startingMetrics;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x67A3590", Offset = "0x67A2390", VA = "0x1867A3590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67A3990", Offset = "0x67A2790", VA = "0x1867A3990")]
		public MetricDashboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MetricGraphTextDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[Header("Metric Text")]
		private TMP_Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool MFBDAOBLOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool PNLNDBFAHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool AFDFLIJKEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool MFBMCPKJOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private bool COADCNOGAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private bool CLAGEFNODMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool KEGPLKFIGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool JOLIBHKHBEB;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string MFKFIMJKDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x67A4410", Offset = "0x67A3210", VA = "0x1867A4410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x67A4690", Offset = "0x67A3490", VA = "0x1867A4690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string HFHGNJPJMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67A4190", Offset = "0x67A2F90", VA = "0x1867A4190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x67A4550", Offset = "0x67A3350", VA = "0x1867A4550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string DMFMIEIADBP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x67A4290", Offset = "0x67A3090", VA = "0x1867A4290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67A45D0", Offset = "0x67A33D0", VA = "0x1867A45D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string CJGGCDPMLON
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x67A4490", Offset = "0x67A3290", VA = "0x1867A4490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x67A46D0", Offset = "0x67A34D0", VA = "0x1867A46D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string CAIGKGPPKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67A4210", Offset = "0x67A3010", VA = "0x1867A4210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67A4590", Offset = "0x67A3390", VA = "0x1867A4590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string AINGAIKBDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67A4390", Offset = "0x67A3190", VA = "0x1867A4390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67A4650", Offset = "0x67A3450", VA = "0x1867A4650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string PJMPDNFOGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67A4310", Offset = "0x67A3110", VA = "0x1867A4310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x67A4610", Offset = "0x67A3410", VA = "0x1867A4610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string JBNAGONECPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x67A4110", Offset = "0x67A2F10", VA = "0x1867A4110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x67A4510", Offset = "0x67A3310", VA = "0x1867A4510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67A3FE0", Offset = "0x67A2DE0", VA = "0x1867A3FE0", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67A3F60", Offset = "0x67A2D60", VA = "0x1867A3F60")]
		protected string NHCNPIBEOEB(bool DMPPMCGONKF, ref TMP_Text NFJHHMHDKEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67A40D0", Offset = "0x67A2ED0", VA = "0x1867A40D0")]
		protected void PKENPPDIAND(bool DFCAKFCEHBF, ref TMP_Text ONDHOAIGIEB, string MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public MetricGraphTextDisplay()
		{
		}
	}
}
namespace RecRoom.Profiling.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class MetricGraphDriverBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected const string PMCHFAKIKMH = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double HHNEKMDNGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double KNFENEEBKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected double AIHKKBFLAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double FBMGPLBJNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected double CPLIBJFAFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected int PGLBLKPFEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double NBJMDOHCEBM;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected abstract int NNGHKMENAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected abstract MetricAccumulateMode CIDGPBNKKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected bool EGPBAADHJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF4C0", VA = "0x1812C06C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x12C06E0", Offset = "0x12BF4E0", VA = "0x1812C06E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract OGFFBLBPKKJ LNHJLMICMDO();

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void JNAADEBGBJJ();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x17B7880", Offset = "0x17B6680", VA = "0x1817B7880", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x17B7880", Offset = "0x17B6680", VA = "0x1817B7880")]
		protected void MODOCFCDLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67A3C80", Offset = "0x67A2A80", VA = "0x1867A3C80", Slot = "10")]
		protected virtual void EJNMDDGIMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67A3BA0", Offset = "0x67A29A0", VA = "0x1867A3BA0", Slot = "11")]
		protected virtual void CNBFMFFFNHD(double ALAONNPHELJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67A3A50", Offset = "0x67A2850", VA = "0x1867A3A50", Slot = "12")]
		protected virtual double CBBEOFCKNPI(MetricAccumulateMode OIOPLPMFOPE)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67A3DE0", Offset = "0x67A2BE0", VA = "0x1867A3DE0")]
		protected bool NENGNHEFNGL(MetricGraph JPPDDPGBNJJ, MetricAccumulateMode LHDFDDPEACL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67A3CC0", Offset = "0x67A2AC0", VA = "0x1867A3CC0", Slot = "13")]
		protected virtual string GJNKCIEGCHM(double MGFMONLLLPD, string BHFJONCFCNH = "0.00", [Optional] string BAGALFAHEGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67A0590", Offset = "0x679F390", VA = "0x1867A0590")]
		protected MetricGraphDriverBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class SingleMetricGraphDriver : MetricGraphDriverBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected string debugDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Graph and Text")]
		[FormerlySerializedAs("targetGraph")]
		protected MetricGraph graphDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		protected bool KLONPCAGAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected bool DDMIOBLAAEI;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6D60", Offset = "0x67A5B60", VA = "0x1867A6D60", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67A6BA0", Offset = "0x67A59A0", VA = "0x1867A6BA0", Slot = "5")]
		protected override void JNAADEBGBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67A6860", Offset = "0x67A5660", VA = "0x1867A6860", Slot = "14")]
		protected virtual bool ENALFHECGFD(string FEACJBADEHO = "0.00", [Optional] string HGPHLMMDECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x67A0590", Offset = "0x679F390", VA = "0x1867A0590")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPNOAMHKFCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	MetricDescription PAFBGNJADJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RawMetricPayload NAKOJGBICNC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NGKHNAFBFKM : KPNOAMHKFCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static bool HBIGCNEIHNK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> GBEJFEABLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MetricId NINDMEEEKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly string DNDLAEFJCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string OHDBBMLPLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorder HFIAIJAMFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool DDBDMNDCHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool ECBKGIEMNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ProfilerRecorderDescription NKHCEPKFDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private ProfilerRecorderHandle MIGKGCFAMKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7458A0", Offset = "0x7446A0", VA = "0x1807458A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MetricDescription PAFBGNJADJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2355F70", Offset = "0x2354D70", VA = "0x182355F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28640D0", Offset = "0x2862ED0", VA = "0x1828640D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CBNFMAIHPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67A6570", Offset = "0x67A5370", VA = "0x1867A6570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x67A6610", Offset = "0x67A5410", VA = "0x1867A6610")]
	public NGKHNAFBFKM(MetricId NINDMEEEKCC, string DNDLAEFJCPD, string OHDBBMLPLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x67A6090", Offset = "0x67A4E90", VA = "0x1867A6090", Slot = "7")]
	public RawMetricPayload NAKOJGBICNC()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x67A6410", Offset = "0x67A5210", VA = "0x1867A6410")]
	private static ProfilerRecorderHandle OCONHLJBOOK(string DNDLAEFJCPD, string OHDBBMLPLFJ)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67A5D40", Offset = "0x67A4B40", VA = "0x1867A5D40")]
	private void BKOPHHFGDHN(bool ONFDAKCOPIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67A5CC0", Offset = "0x67A4AC0", VA = "0x1867A5CC0")]
	private static MetricDescription AJAIDOLMLCF(MetricId NINDMEEEKCC, ProfilerRecorderDescription PPPOKPIMNEI)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67A6140", Offset = "0x67A4F40", VA = "0x1867A6140")]
	private static bool OBIAPAOJFGA(bool ONFDAKCOPIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67A6070", Offset = "0x67A4E70", VA = "0x1867A6070")]
	private void NLAKOKAAALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67A6070", Offset = "0x67A4E70", VA = "0x1867A6070", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NDBHPMPGPMD : KPNOAMHKFCF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<double> FDCKFODBFDC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MetricDescription PAFBGNJADJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28640F0", Offset = "0x2862EF0", VA = "0x1828640F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67A5C70", Offset = "0x67A4A70", VA = "0x1867A5C70")]
	public NDBHPMPGPMD(Func<double> FDCKFODBFDC, MetricDescription NCHMBMDLPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67A5BE0", Offset = "0x67A49E0", VA = "0x1867A5BE0", Slot = "7")]
	public RawMetricPayload NAKOJGBICNC()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JHMDBEJMCGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private readonly struct HNJKMEAKCJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly string MPDEJCFBGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string DCAPFKDGAPI;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
		public HNJKMEAKCJP(string DNDLAEFJCPD, string OHDBBMLPLFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EAHPOFPPNJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JHMDBEJMCGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67A0200", Offset = "0x679F000", VA = "0x1867A0200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MetricIdLookup ALHDIHJEHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IRawMetricsPipeline DIFDDMBDHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IMetricCollectionRegistry NNDHMCJMMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CancellationTokenSource BCHDMIKMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<MetricId, KPNOAMHKFCF> BMDLBMFNPNL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly HNJKMEAKCJP[] IDCPIFDJIJM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67A1560", Offset = "0x67A0360", VA = "0x1867A1560")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void KLALIAONMAF(GMLHNNIDAIC LNJPAOGJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67A22F0", Offset = "0x67A10F0", VA = "0x1867A22F0")]
	[Preserve]
	public JHMDBEJMCGP([HDMGOABMPFL(null)] MetricIdLookup ALHDIHJEHOB, [HDMGOABMPFL(null)] IRawMetricsPipeline DIFDDMBDHFK, [HDMGOABMPFL(null)] IMetricCollectionRegistry NNDHMCJMMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67A10C0", Offset = "0x679FEC0", VA = "0x1867A10C0")]
	private void BEDIJFEFEPL(string IDBAMLEILIP, string OHDBBMLPLFJ, OGFFBLBPKKJ HDBNINLJNFO, Func<double> FDCKFODBFDC, out MetricId NINDMEEEKCC, out KPNOAMHKFCF NFJHHMHDKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67A1650", Offset = "0x67A0450", VA = "0x1867A1650")]
	private void OAHPFFLEPJN(MetricId NINDMEEEKCC, bool DDKKJBKNEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67A1440", Offset = "0x67A0240", VA = "0x1867A1440")]
	[AsyncStateMachine(typeof(EAHPOFPPNJD))]
	private Task JHKJMPLFMDN(CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67A11C0", Offset = "0x679FFC0", VA = "0x1867A11C0")]
	public void EHBFLCLNJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67A1180", Offset = "0x679FF80", VA = "0x1867A1180", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Profiling.Configs
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class GraphConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string FriendlyDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string MetricSourceName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public string MetricName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int FramesToAccumulate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int BufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public MetricAccumulateMode MetricAccumulateMode;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x67A0E80", Offset = "0x679FC80", VA = "0x1867A0E80")]
		public GraphConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class GraphConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private GraphConfig graphConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public GraphConfig GraphConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
		public GraphConfigAsset()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x67A2E80", Offset = "0x67A1C80", VA = "0x1867A2E80")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67A2B30", Offset = "0x67A1930", VA = "0x1867A2B30")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
