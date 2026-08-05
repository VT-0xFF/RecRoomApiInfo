using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.DataStructures;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class FHMGFWKVTJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1371B00", Offset = "0x1370700", VA = "0x181371B00")]
		public static Color MZAYMLYMKLG(this RRColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9C356B0", Offset = "0x9C342B0", VA = "0x189C356B0")]
		public static Color MZAYMLYMKLG(this RRColor32 a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9C35710", Offset = "0x9C34310", VA = "0x189C35710")]
		public static Color32 NTOYBBEJELX(this RRColor32 a)
		{
			return default(Color32);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker PFOEZADXLYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker KRSVMSWCVDI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int ZPMPGPJGFKJ = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int HVFZZXKNIVR = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EPZPSUYODBO KPZJCUQXMNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool NQYOZTWYCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float PKLKHCEKQRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float TQNUFWDTCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float KSKMJWGMFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float OZQVWLTYLCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float UVXJNNHJLPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Graph")]
		[SerializeField]
		private RawImage graphImageTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Space]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderFull")]
		private Shader shaderFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[FormerlySerializedAs("graphImageShaderLight")]
		private Shader shaderLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private bool useLightShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Header("Graph Visuals")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[Range(1f, 10f)]
		private float resolutionScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Color baseValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Space]
		[SerializeField]
		private bool showAverageBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Color averageBarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Space]
		[SerializeField]
		private bool showThresholdBars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JZNNWTOMIMR CUZZTCBVXWF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int CQIDNKTREJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9C37550", Offset = "0x9C36150", VA = "0x189C37550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int VEWHRVQQFJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C37570", Offset = "0x9C36170", VA = "0x189C37570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int TBMSDSMZZEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C36DF0", Offset = "0x9C359F0", VA = "0x189C36DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int EYRSRZBVPYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9C37C00", Offset = "0x9C36800", VA = "0x189C37C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int FUBXEGAEKKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9C37BD0", Offset = "0x9C367D0", VA = "0x189C37BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float OVGQVYMGBKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C37B30", Offset = "0x9C36730", VA = "0x189C37B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float JNYHBMJAHAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C37B70", Offset = "0x9C36770", VA = "0x189C37B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float FUKDIYGIMRO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9C37B50", Offset = "0x9C36750", VA = "0x189C37B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float RLOYGBKUFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9C37B90", Offset = "0x9C36790", VA = "0x189C37B90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float UZXECSYKSDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9C37BB0", Offset = "0x9C367B0", VA = "0x189C37BB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C36AC0", Offset = "0x9C356C0", VA = "0x189C36AC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C374C0", Offset = "0x9C360C0", VA = "0x189C374C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C37860", Offset = "0x9C36460", VA = "0x189C37860")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C37520", Offset = "0x9C36120", VA = "0x189C37520")]
		public void PushSample(double sampleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C36DC0", Offset = "0x9C359C0", VA = "0x189C36DC0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C36AF0", Offset = "0x9C356F0", VA = "0x189C36AF0")]
		private void CHQDULFTHAO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C37590", Offset = "0x9C36190", VA = "0x189C37590")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C36E50", Offset = "0x9C35A50", VA = "0x189C36E50")]
		public void InitData(int newBufferCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C36FD0", Offset = "0x9C35BD0", VA = "0x189C36FD0")]
		private void NAXBJNYPKES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C37890", Offset = "0x9C36490", VA = "0x189C37890")]
		public MetricGraph()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class MetricGraphGraphic : Graphic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private JZNNWTOMIMR CUZZTCBVXWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EPZPSUYODBO CMLXPYOSCMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material XFOZFPYTZQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool CXGKRNUTEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C36A50", Offset = "0x9C35650", VA = "0x189C36A50")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C35E50", Offset = "0x9C34A50", VA = "0x189C35E50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C35E70", Offset = "0x9C34A70", VA = "0x189C35E70")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C360D0", Offset = "0x9C34CD0", VA = "0x189C360D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C362C0", Offset = "0x9C34EC0", VA = "0x189C362C0")]
		public void UpdateData(double value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C36470", Offset = "0x9C35070", VA = "0x189C36470")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C364F0", Offset = "0x9C350F0", VA = "0x189C364F0")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold, RRColor32 baseColor, RRColor32 averageColor, RRColor32 cautionColor, RRColor32 criticalColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C36700", Offset = "0x9C35300", VA = "0x189C36700")]
		public void UpdateThreshold(SWHUNXSFEUX threshold, double scale = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C36190", Offset = "0x9C34D90", VA = "0x189C36190")]
		public void ResetValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class EPZPSUYODBO : IEnumerable<float>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class RKTJLKXCEIL : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private float PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public EPZPSUYODBO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private float SISWFYNCMUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xEBBD20", Offset = "0xEBA920", VA = "0x180EBBD20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2083700", Offset = "0x2082300", VA = "0x182083700", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public RKTJLKXCEIL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9C37C60", Offset = "0x9C36860", VA = "0x189C37C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9C37C20", Offset = "0x9C36820", VA = "0x189C37C20", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float[] KHTRAPERTXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private float VEKCGCAQCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float TFAKMWKVCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float RFINXMTTFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int OVGQWTCFUZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int YGGWGOVCADB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int IYQTFMJRTNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2838540", Offset = "0x2837140", VA = "0x182838540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float QUCFFPRKWYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9C34F10", Offset = "0x9C33B10", VA = "0x189C34F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float PYDHGUAEWWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9C354B0", Offset = "0x9C340B0", VA = "0x189C354B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float LCEUZYBEGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46B00", VA = "0x180D47F00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float JCVDGSLJFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD47E80", Offset = "0xD46A80", VA = "0x180D47E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float HFKQHVGGAGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9C355F0", Offset = "0x9C341F0", VA = "0x189C355F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9C34E70", Offset = "0x9C33A70", VA = "0x189C34E70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C35630", Offset = "0x9C34230", VA = "0x189C35630")]
		public EPZPSUYODBO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C35420", Offset = "0x9C34020", VA = "0x189C35420")]
		public void TBGVRSWGIOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C350D0", Offset = "0x9C33CD0", VA = "0x189C350D0")]
		public void JNVOJKXNKRU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C35610", Offset = "0x9C34210", VA = "0x189C35610")]
		public void YFYNRDWZWTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C34D70", Offset = "0x9C33970", VA = "0x189C34D70")]
		public void HVKQZODQCMO(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C34F20", Offset = "0x9C33B20", VA = "0x189C34F20")]
		public void HVKQZODQCMO(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C355C0", Offset = "0x9C341C0", VA = "0x189C355C0")]
		private int WAWUBWJQFMP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C35550", Offset = "0x9C34150", VA = "0x189C35550", Slot = "4")]
		[IteratorStateMachine(typeof(RKTJLKXCEIL))]
		private IEnumerator<float> UJZBNELAWPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C35030", Offset = "0x9C33C30", VA = "0x189C35030", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JZNNWTOMIMR
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int SNOJCELHMPX = 512;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const int LBWOGBPLORK = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int GECSMCBPLRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float[] NALIEVNUJQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Material XGHPAODSBAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float VZFAUIPPTTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float DJIHENSHNAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float FDANWLWYJQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float JTUZMEWQWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float HXWTQCCXOTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Color ZAJCLWYELZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Color SXHCDEWTBPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Color LLXSNJSXNEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Color TBUMZDFGCGA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly int LBHYWTWZDTJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly int ZKAMIYKKVCP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly int YRLCVZUBGIN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly int SKTZYHUUHMU;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly int FSQCEVRFLJS;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly int QDBHOLMBIPG;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly int DQLGUNCBWBU;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly int DGTAXMXFSAI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly int KKIWWEWYJJC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly int WMUSKNBCYQS;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly int GTAHUNFZYGC;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C35AD0", Offset = "0x9C346D0", VA = "0x189C35AD0")]
		public void YCQWTXDXFVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C35860", Offset = "0x9C34460", VA = "0x189C35860")]
		public void PVIFVZNKDRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C359A0", Offset = "0x9C345A0", VA = "0x189C359A0")]
		public void RGVPRERXCRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C35A20", Offset = "0x9C34620", VA = "0x189C35A20")]
		public void UQCSEPWFCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C35740", Offset = "0x9C34340", VA = "0x189C35740")]
		public void MMLETAOGPQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C35B70", Offset = "0x9C34770", VA = "0x189C35B70")]
		public void YVVBYPNZMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C358F0", Offset = "0x9C344F0", VA = "0x189C358F0")]
		public void QTTYUCQYUAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9C35E00", Offset = "0x9C34A00", VA = "0x189C35E00")]
		public JZNNWTOMIMR()
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
