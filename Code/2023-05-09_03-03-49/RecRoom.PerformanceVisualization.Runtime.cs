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
		private ProfilerMarker AOCENOHIPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ProfilerMarker NKJFPKCLALN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int EOIEMNMPGFK = 8;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int POFEELDJOPD = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PEEPPDDGOHG JKBNMLNLEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool KHEKGCNHOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private float GPCGDPHEHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float IODDEMPFPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float OAPIJKFBDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float LLBLHBAMAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float LLAJFMKFONJ;

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
		private JEMGKPHFHKA FIBKHJGFOHL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int GDOJBMAFAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x1C488A0", Offset = "0x1C472A0", VA = "0x181C488A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int LGGPKHJNCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1C47B20", Offset = "0x1C46520", VA = "0x181C47B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int PMNFKILNBNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1C47B40", Offset = "0x1C46540", VA = "0x181C47B40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HEOLEEEIOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1C48FA0", Offset = "0x1C479A0", VA = "0x181C48FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int NMBOLBBJCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1C48F70", Offset = "0x1C47970", VA = "0x181C48F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float PLCHJIKBKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1C48ED0", Offset = "0x1C478D0", VA = "0x181C48ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float DIHJKLPPODH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1C48F10", Offset = "0x1C47910", VA = "0x181C48F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IBEKECFADHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1C48EF0", Offset = "0x1C478F0", VA = "0x181C48EF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float KFNBKKNCJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1C48F30", Offset = "0x1C47930", VA = "0x181C48F30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float KHBOJFJAEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1C48F50", Offset = "0x1C47950", VA = "0x181C48F50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C47AF0", Offset = "0x1C464F0", VA = "0x181C47AF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1C48CB0", Offset = "0x1C476B0", VA = "0x181C48CB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1C488C0", Offset = "0x1C472C0", VA = "0x181C488C0")]
		public void PushSample(double EMHPFMJEEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1C484D0", Offset = "0x1C46ED0", VA = "0x181C484D0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1C48680", Offset = "0x1C47080", VA = "0x181C48680")]
		private void KAACKGBFBEP(bool BFIMHHIKINE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1C489B0", Offset = "0x1C473B0", VA = "0x181C489B0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1C484F0", Offset = "0x1C46EF0", VA = "0x181C484F0")]
		public void InitData(int HJNEBDEMJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1C47BB0", Offset = "0x1C465B0", VA = "0x181C47BB0")]
		private void BMGBKAMIGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1C48CE0", Offset = "0x1C476E0", VA = "0x181C48CE0")]
		public MetricGraph()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class PEEPPDDGOHG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OOMKMPJKIHP : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
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
		public PEEPPDDGOHG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xD02F50", Offset = "0xD01950", VA = "0x180D02F50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C497C0", Offset = "0x1C481C0", VA = "0x181C497C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12F1130", Offset = "0x12EFB30", VA = "0x1812F1130")]
		[DebuggerHidden]
		public OOMKMPJKIHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C495F0", Offset = "0x1C47FF0", VA = "0x181C495F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C49780", Offset = "0x1C48180", VA = "0x181C49780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C496D0", Offset = "0x1C480D0", VA = "0x181C496D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1C496D0", Offset = "0x1C480D0", VA = "0x181C496D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	protected float[] IHOOMKNCBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	protected int DOGNBADHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	protected int HGMGPFAJPJI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E5640", Offset = "0x7E4040", VA = "0x1807E5640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA7B980", Offset = "0xA7A380", VA = "0x180A7B980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float DHPCEFMANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1C49B90", Offset = "0x1C48590", VA = "0x181C49B90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float AADKKOEBPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1C49920", Offset = "0x1C48320", VA = "0x181C49920")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1C42D60", Offset = "0x1C41760", VA = "0x181C42D60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1C49BD0", Offset = "0x1C485D0", VA = "0x181C49BD0")]
	public PEEPPDDGOHG(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C49930", Offset = "0x1C48330", VA = "0x181C49930")]
	public void FLAMKIOJLIC(int KJKIEHNJIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1C499C0", Offset = "0x1C483C0", VA = "0x181C499C0")]
	public void HHDPMFAIBBF(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x145FB40", Offset = "0x145E540", VA = "0x18145FB40")]
	public void HPGOACEMALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1C49B10", Offset = "0x1C48510", VA = "0x181C49B10")]
	public IEnumerable<float> NKKMJDHFAAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1C49A90", Offset = "0x1C48490", VA = "0x181C49A90")]
	[IteratorStateMachine(typeof(OOMKMPJKIHP))]
	public IEnumerable<float> NKKMJDHFAAI(int PIJIAPGDCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1C42C60", Offset = "0x1C41660", VA = "0x181C42C60")]
	public void AKEAHLGGBBP(float[] BJCKADBMKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1C49810", Offset = "0x1C48210", VA = "0x181C49810")]
	public void AKEAHLGGBBP(float[] BJCKADBMKDM, int GMOLBAPNIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C49BA0", Offset = "0x1C485A0", VA = "0x181C49BA0")]
	private int OHPLJNLFGOM(int ALJOMNDNEBM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JEMGKPHFHKA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const int JIIPBLFADNB = 512;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const int PKGHBCMMHEP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int EEMPEMEFELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float[] PEIIFGOCIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public RawImage HKENMPGGJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float PCDCCPNIMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float COCJJNCIDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float CBAJOBINGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float GOFCOBAOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float BMADELONIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Color DIIDGOCGMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color GGPBEBCCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool DEHKNJMFAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Color MEONGCCFNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Color IDJGADABFCA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int MLGLCBOANMI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int GBALOLEKFEO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int OFAPMLDHEHK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int EPJNBKPJNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int HBNJJIDCCOG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int CFBIGCMAEGF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly int GPADLDCKPAA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly int LLPPFAJCKNH;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly int NFKCKBJNGIE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly int LDGCAHFLBMI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly int LAFJLJBAGNN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly int IOAINIBNPML;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1C46300", Offset = "0x1C44D00", VA = "0x181C46300")]
	public void LEAOPONNAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1C45F30", Offset = "0x1C44930", VA = "0x181C45F30")]
	public void DHGBPNMJBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1C45E90", Offset = "0x1C44890", VA = "0x181C45E90")]
	public void CNEOMBCOPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1C463C0", Offset = "0x1C44DC0", VA = "0x181C463C0")]
	public void LMOPJOHKMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1C46080", Offset = "0x1C44A80", VA = "0x181C46080")]
	public void KHAEMAFHLID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1C45FE0", Offset = "0x1C449E0", VA = "0x181C45FE0")]
	public void GINAJOCFHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1C46220", Offset = "0x1C44C20", VA = "0x181C46220")]
	public void KNKPEMCKKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1C466D0", Offset = "0x1C450D0", VA = "0x181C466D0")]
	public JEMGKPHFHKA()
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
		private MetricIdLookup JPFJHFLNALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IRawMetricsPipeline HOBAFFBLHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IMetricCollectionRegistry NPJPCDNIENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MetricId OKFEMPDBBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int EKNBNFEJDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MetricAccumulateMode HHGKDNNCCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MetricCollectionToken HMAOAMDKNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MetricDescription NJNMKPOEPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private GraphConfig FJNAICANFMG;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x94C210", Offset = "0x94AC10", VA = "0x18094C210", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x91F220", Offset = "0x91DC20", VA = "0x18091F220", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C449E0", Offset = "0x1C433E0", VA = "0x181C449E0")]
		private void BNMHBDCPNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1C44980", Offset = "0x1C43380", VA = "0x181C44980", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1C45060", Offset = "0x1C43A60", VA = "0x181C45060", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1C44FD0", Offset = "0x1C439D0", VA = "0x181C44FD0")]
		protected void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C44C40", Offset = "0x1C43640", VA = "0x181C44C40")]
		public void Initialize(GraphConfig DJPOFPPFNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1C44880", Offset = "0x1C43280", VA = "0x181C44880", Slot = "14")]
		protected override bool ANPEEDNLFFO(string CGMCHCJDAHL = "0.00", [Optional] string BFJDBOKKNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1C44B40", Offset = "0x1C43540", VA = "0x181C44B40")]
		public void HandleMetric(in RawMetric CKJPBFGODBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDE3190", Offset = "0xDE1B90", VA = "0x180DE3190", Slot = "4")]
		protected override JODMMMNPKLK MINCICPGBOI()
		{
			return default(JODMMMNPKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1C451E0", Offset = "0x1C43BE0", VA = "0x181C451E0")]
		public ConfigurablePipelineGraphDriver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1C44B40", Offset = "0x1C43540", VA = "0x181C44B40", Slot = "15")]
		private void IPMCKFLFDII(in RawMetric CKJPBFGODBC)
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
		protected override int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA8A930", Offset = "0xA89330", VA = "0x180A8A930", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected override MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x12C03D0", Offset = "0x12BEDD0", VA = "0x1812C03D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "4")]
		protected override JODMMMNPKLK MINCICPGBOI()
		{
			return default(JODMMMNPKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1C45220", Offset = "0x1C43C20", VA = "0x181C45220", Slot = "14")]
		protected override bool ANPEEDNLFFO(string CGMCHCJDAHL = "0.00", [Optional] string BFJDBOKKNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1C45320", Offset = "0x1C43D20", VA = "0x181C45320")]
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
		protected override int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA8A930", Offset = "0xA89330", VA = "0x180A8A930", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected override MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x12C03D0", Offset = "0x12BEDD0", VA = "0x1812C03D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "4")]
		protected override JODMMMNPKLK MINCICPGBOI()
		{
			return default(JODMMMNPKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1C45390", Offset = "0x1C43D90", VA = "0x181C45390", Slot = "14")]
		protected override bool ANPEEDNLFFO(string CGMCHCJDAHL = "0.00", [Optional] string BFJDBOKKNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1C45470", Offset = "0x1C43E70", VA = "0x181C45470")]
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
		private ProfilerRecorderHandle DOJIAEJILGP;

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
		private static bool NDDCGLJGKIE;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool NEMNHOMAODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1C49DE0", Offset = "0x1C487E0", VA = "0x181C49DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected override int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x94C250", Offset = "0x94AC50", VA = "0x18094C250", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x94C210", Offset = "0x94AC10", VA = "0x18094C210", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "4")]
		protected override JODMMMNPKLK MINCICPGBOI()
		{
			return default(JODMMMNPKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1C49C40", Offset = "0x1C48640", VA = "0x181C49C40", Slot = "14")]
		protected override bool ANPEEDNLFFO(string CGMCHCJDAHL = "0.00", [Optional] string BFJDBOKKNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1C49D60", Offset = "0x1C48760", VA = "0x181C49D60")]
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
		protected override int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA8A930", Offset = "0xA89330", VA = "0x180A8A930", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected override MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x12C03D0", Offset = "0x12BEDD0", VA = "0x1812C03D0", Slot = "7")]
			get
			{
				return default(MetricAccumulateMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA24EF0", Offset = "0xA238F0", VA = "0x180A24EF0", Slot = "4")]
		protected override JODMMMNPKLK MINCICPGBOI()
		{
			return default(JODMMMNPKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1C49DF0", Offset = "0x1C487F0", VA = "0x181C49DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C46970", Offset = "0x1C45370", VA = "0x181C46970")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C46D70", Offset = "0x1C45770", VA = "0x181C46D70")]
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
		private bool OCNEFKPIADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TMP_Text categoryText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool EDECKEOOCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private TMP_Text descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool BJLGCKGDMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		[Header("Data Text")]
		private TMP_Text samplesText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool PFEOOKODPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private TMP_Text curText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private bool POGFOALLMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private TMP_Text minText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private bool HBPOKIMJMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private TMP_Text maxText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool IDGEPIEPMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private TMP_Text avgText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool JHDAHBJFOHC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string MGBJEEMPJBA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1C477F0", Offset = "0x1C461F0", VA = "0x181C477F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1C47A70", Offset = "0x1C46470", VA = "0x181C47A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string FEDAAEAOAPG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1C47570", Offset = "0x1C45F70", VA = "0x181C47570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1C47930", Offset = "0x1C46330", VA = "0x181C47930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string CBALLBGOJCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1C47670", Offset = "0x1C46070", VA = "0x181C47670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1C479B0", Offset = "0x1C463B0", VA = "0x181C479B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string LAFOCKGKGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1C47870", Offset = "0x1C46270", VA = "0x181C47870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1C47AB0", Offset = "0x1C464B0", VA = "0x181C47AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string EHJEHNGNELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1C475F0", Offset = "0x1C45FF0", VA = "0x181C475F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1C47970", Offset = "0x1C46370", VA = "0x181C47970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string OABOOHLKCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1C47770", Offset = "0x1C46170", VA = "0x181C47770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1C47A30", Offset = "0x1C46430", VA = "0x181C47A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string PCPIDKDHLFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1C476F0", Offset = "0x1C460F0", VA = "0x181C476F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1C479F0", Offset = "0x1C463F0", VA = "0x181C479F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string JNDNPNCEMPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1C474F0", Offset = "0x1C45EF0", VA = "0x181C474F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1C478F0", Offset = "0x1C462F0", VA = "0x181C478F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C47400", Offset = "0x1C45E00", VA = "0x181C47400", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1C47340", Offset = "0x1C45D40", VA = "0x181C47340")]
		protected string EFMFMJFGIHC(bool CADLMCOIBLD, ref TMP_Text BMKGEKNDEIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1C473C0", Offset = "0x1C45DC0", VA = "0x181C473C0")]
		protected void OGLIMIMKBIL(bool COJBMNHHJLL, ref TMP_Text BJCKADBMKDM, string MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
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
		protected const string AICEDDNICED = "0.00";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		protected double NKKMAKIELDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		protected double JLHPGEGJBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		protected double AAAACHIACBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		protected double DGODIPBFEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		protected double OCEOFIOOJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		protected int GHIHFDECAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		protected double DBCPCJJCHLG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected abstract int LNLNNIOAEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected abstract MetricAccumulateMode GIFOEOHPFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected bool KKMGNMKLDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8F20E0", Offset = "0x8F0AE0", VA = "0x1808F20E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F20F0", Offset = "0x8F0AF0", VA = "0x1808F20F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract JODMMMNPKLK MINCICPGBOI();

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void LBENCMAEKJA();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x14E3DE0", Offset = "0x14E27E0", VA = "0x1814E3DE0", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x14E3DE0", Offset = "0x14E27E0", VA = "0x1814E3DE0")]
		protected void CKFBPJADMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C47300", Offset = "0x1C45D00", VA = "0x181C47300", Slot = "10")]
		protected virtual void ICJLPECPADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1C46F80", Offset = "0x1C45980", VA = "0x181C46F80", Slot = "11")]
		protected virtual void DHLMFHDPLBP(double NGKEFJNDKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1C46E30", Offset = "0x1C45830", VA = "0x181C46E30", Slot = "12")]
		protected virtual double AKBLPOICHFP(MetricAccumulateMode HHGKDNNCCLC)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1C47180", Offset = "0x1C45B80", VA = "0x181C47180")]
		protected bool GMBECPDHKNI(MetricGraph POGLEAIHAIK, MetricAccumulateMode DPFIFMCONAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1C47060", Offset = "0x1C45A60", VA = "0x181C47060", Slot = "13")]
		protected virtual string FHOEMGGJMIM(double MFBGAMJDOKA, string MPHFMCGDKAK = "0.00", [Optional] string LDCJALNENBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1C45470", Offset = "0x1C43E70", VA = "0x181C45470")]
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
		protected bool LHCLMKCOCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected MetricGraphTextDisplay textDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected bool APEOBCDGAJM;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A330", Offset = "0x1C48D30", VA = "0x181C4A330", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A170", Offset = "0x1C48B70", VA = "0x181C4A170", Slot = "5")]
		protected override void LBENCMAEKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1C49E30", Offset = "0x1C48830", VA = "0x181C49E30", Slot = "14")]
		protected virtual bool ANPEEDNLFFO(string CGMCHCJDAHL = "0.00", [Optional] string BFJDBOKKNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C45470", Offset = "0x1C43E70", VA = "0x181C45470")]
		protected SingleMetricGraphDriver()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MEAAGENAMOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	MetricDescription ABIBMLCDFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "3")]
	RawMetricPayload AMAFFPHPCBM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HHBKBPLMMAO : MEAAGENAMOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static bool NDDCGLJGKIE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static Dictionary<(ushort category, string name), ProfilerRecorderHandle> FKPGKKALNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MetricId OKFEMPDBBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly string GOAOPIJIFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string ELPBCKOEOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ProfilerRecorder PJAJACEGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool FKONDCBDHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool GGGMGPHDEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ProfilerRecorderDescription GJJEGBEKCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private ProfilerRecorderHandle DOJIAEJILGP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E6AC0", Offset = "0x7E54C0", VA = "0x1807E6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MetricDescription ABIBMLCDFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1C45710", Offset = "0x1C44110", VA = "0x181C45710", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C45700", Offset = "0x1C44100", VA = "0x181C45700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NEMNHOMAODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C454C0", Offset = "0x1C43EC0", VA = "0x181C454C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1C45E30", Offset = "0x1C44830", VA = "0x181C45E30")]
	public HHBKBPLMMAO(MetricId OKFEMPDBBJL, string GOAOPIJIFJG, string ELPBCKOEOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1C454D0", Offset = "0x1C43ED0", VA = "0x181C454D0", Slot = "7")]
	public RawMetricPayload AMAFFPHPCBM()
	{
		return default(RawMetricPayload);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1C455A0", Offset = "0x1C43FA0", VA = "0x181C455A0")]
	private static ProfilerRecorderHandle DHNNMLNHLPI(string GOAOPIJIFJG, string ELPBCKOEOHO)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1C457A0", Offset = "0x1C441A0", VA = "0x181C457A0")]
	private void NPLAHIEDCBA(bool BFIMHHIKINE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1C45720", Offset = "0x1C44120", VA = "0x181C45720")]
	private static MetricDescription JIJLOHNKOIH(MetricId OKFEMPDBBJL, ProfilerRecorderDescription EDNFJCLLLKJ)
	{
		return default(MetricDescription);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1C45AD0", Offset = "0x1C444D0", VA = "0x181C45AD0")]
	private static bool PNHMODDMCLE(bool BFIMHHIKINE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1C45580", Offset = "0x1C43F80", VA = "0x181C45580")]
	private void DFHOLKFCING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1C45580", Offset = "0x1C43F80", VA = "0x181C45580", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KJJBNGELCOA : MEAAGENAMOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<double> POFDGCMCLBO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MetricDescription ABIBMLCDFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x882980", Offset = "0x881380", VA = "0x180882980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MetricDescription);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1C467E0", Offset = "0x1C451E0", VA = "0x181C467E0")]
	public KJJBNGELCOA(Func<double> POFDGCMCLBO, MetricDescription NJNMKPOEPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C46750", Offset = "0x1C45150", VA = "0x181C46750", Slot = "7")]
	public RawMetricPayload AMAFFPHPCBM()
	{
		return default(RawMetricPayload);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AMPAILIMKHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private readonly struct DGLLMKLANAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly string LNAIIKAFIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string KAKGLEDMCGA;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
		public DGLLMKLANAL(string GOAOPIJIFJG, string ELPBCKOEOHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LDNLDDODFGB : IAsyncStateMachine
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
		public AMPAILIMKHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C46830", Offset = "0x1C45230", VA = "0x181C46830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MetricIdLookup JPFJHFLNALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IRawMetricsPipeline HOBAFFBLHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IMetricCollectionRegistry NPJPCDNIENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CancellationTokenSource PHAHKIOMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<MetricId, MEAAGENAMOE> HCGEHFJIHCA;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly DGLLMKLANAL[] CGKGJABMJJN;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C43190", Offset = "0x1C41B90", VA = "0x181C43190")]
	[MBJLKJLIAAH(JDACKNHLALI.GameOnly)]
	private static void FKMBOKDLDNI(DPALDOJEBJE KKCEAAFKCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C44040", Offset = "0x1C42A40", VA = "0x181C44040")]
	[Preserve]
	public AMPAILIMKHB([PDHOKDIGCJO(null)] MetricIdLookup JPFJHFLNALL, [PDHOKDIGCJO(null)] IRawMetricsPipeline HOBAFFBLHFC, [PDHOKDIGCJO(null)] IMetricCollectionRegistry NPJPCDNIENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1C42E10", Offset = "0x1C41810", VA = "0x181C42E10")]
	private void AJBBEGFOBGO(string JJNEFBBFGKF, string ELPBCKOEOHO, JODMMMNPKLK CFGFGAMPCCH, Func<double> POFDGCMCLBO, out MetricId OKFEMPDBBJL, out MEAAGENAMOE BMKGEKNDEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1C43280", Offset = "0x1C41C80", VA = "0x181C43280")]
	private void JNELBBEKAJM(MetricId OKFEMPDBBJL, bool EAJBHKFGDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1C43320", Offset = "0x1C41D20", VA = "0x181C43320")]
	[AsyncStateMachine(typeof(LDNLDDODFGB))]
	private Task KEBKPBIHBHC(CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1C42ED0", Offset = "0x1C418D0", VA = "0x181C42ED0")]
	public void CPLOHEMGBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1C43150", Offset = "0x1C41B50", VA = "0x181C43150", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C454A0", Offset = "0x1C43EA0", VA = "0x181C454A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x95FF20", VA = "0x180961520")]
		public GraphConfigAsset()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1C48FC0", Offset = "0x1C479C0", VA = "0x181C48FC0")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C490D0", Offset = "0x1C47AD0", VA = "0x181C490D0")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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
