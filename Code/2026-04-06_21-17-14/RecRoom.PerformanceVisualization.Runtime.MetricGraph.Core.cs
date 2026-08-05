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
	public static class DSDIVSZSMRJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x137A3B0", Offset = "0x13793B0", VA = "0x18137A3B0")]
		public static Color MAITATSLSYC(this RRColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D92920", Offset = "0x9D91920", VA = "0x189D92920")]
		public static Color MAITATSLSYC(this RRColor32 a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D92980", Offset = "0x9D91980", VA = "0x189D92980")]
		public static Color32 VFPHFSRKUWH(this RRColor32 a)
		{
			return default(Color32);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker XODCFFYSMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker CVFGGXUBEOY;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int JJVMDCBSDYD = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int SLRIRPKKMZT = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private RRCUAEIDBNE BYSCEACQHXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool SKNYBSSORTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float KZUFNABEJDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float ALBJRLFIBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float KJZLVQFHCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float HXFWEAQXRAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float HBCLVQODWFK;

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
		private MMELQOXIFNV VCOYBPHVRNR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int IQVYNWTRVNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9D93E60", Offset = "0x9D92E60", VA = "0x189D93E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int FNKGSGHDJUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9D945E0", Offset = "0x9D935E0", VA = "0x189D945E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int ERMAWOTASKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D944F0", Offset = "0x9D934F0", VA = "0x189D944F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MANJDKRQLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9D94F40", Offset = "0x9D93F40", VA = "0x189D94F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int XWILFZJHFHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9D94F10", Offset = "0x9D93F10", VA = "0x189D94F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float NYNGTBLMQIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E70", Offset = "0x9D93E70", VA = "0x189D94E70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HGJUPINNTKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9D94EB0", Offset = "0x9D93EB0", VA = "0x189D94EB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IYLYDEOZSNU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E90", Offset = "0x9D93E90", VA = "0x189D94E90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float YTVXKJPNNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9D94ED0", Offset = "0x9D93ED0", VA = "0x189D94ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float PTPBNOYAPDV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9D94EF0", Offset = "0x9D93EF0", VA = "0x189D94EF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D93E00", Offset = "0x9D92E00", VA = "0x189D93E00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D94550", Offset = "0x9D93550", VA = "0x189D94550")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D94BA0", Offset = "0x9D93BA0", VA = "0x189D94BA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D945B0", Offset = "0x9D935B0", VA = "0x189D945B0")]
		public void PushSample(double sampleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D93E30", Offset = "0x9D92E30", VA = "0x189D93E30")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D94600", Offset = "0x9D93600", VA = "0x189D94600")]
		private void TPGCQKIGEWI(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D948D0", Offset = "0x9D938D0", VA = "0x189D948D0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D94370", Offset = "0x9D93370", VA = "0x189D94370")]
		public void InitData(int newBufferCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D93E80", Offset = "0x9D92E80", VA = "0x189D93E80")]
		private void HJSUXKSZOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D94BD0", Offset = "0x9D93BD0", VA = "0x189D94BD0")]
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
		private MMELQOXIFNV VCOYBPHVRNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private RRCUAEIDBNE MDXFAVUNUZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material NLVPOBSQSTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool FXVOVLZMGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D93D90", Offset = "0x9D92D90", VA = "0x189D93D90")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D93190", Offset = "0x9D92190", VA = "0x189D93190", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D931B0", Offset = "0x9D921B0", VA = "0x189D931B0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D93410", Offset = "0x9D92410", VA = "0x189D93410", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D93600", Offset = "0x9D92600", VA = "0x189D93600")]
		public void UpdateData(double value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D937B0", Offset = "0x9D927B0", VA = "0x189D937B0")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D93B80", Offset = "0x9D92B80", VA = "0x189D93B80")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold, RRColor32 baseColor, RRColor32 averageColor, RRColor32 cautionColor, RRColor32 criticalColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D93830", Offset = "0x9D92830", VA = "0x189D93830")]
		public void UpdateThreshold(UUBFTJVSZWF threshold, double scale = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D934D0", Offset = "0x9D924D0", VA = "0x189D934D0")]
		public void ResetValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RRCUAEIDBNE : IEnumerable<float>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ITOEEJCQEVX : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private float NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public RRCUAEIDBNE NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int AVRZTXKIQLK;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private float ACWSKLGPFMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xED46A0", Offset = "0xED36A0", VA = "0x180ED46A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2087290", Offset = "0x2086290", VA = "0x182087290", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public ITOEEJCQEVX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9D929B0", Offset = "0x9D919B0", VA = "0x189D929B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9D92A40", Offset = "0x9D91A40", VA = "0x189D92A40", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float[] FUTTHRMMIYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private float UHSMUENSCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float XYVLTPLPOBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float GWBRDAAJXKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int TDPIBVATIPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int UQAYGHULZQR;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int KHHULVTWNWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28396E0", Offset = "0x28386E0", VA = "0x1828396E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float QDTVBVFZSCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9D955D0", Offset = "0x9D945D0", VA = "0x189D955D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float MGEQZLMVINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9D954C0", Offset = "0x9D944C0", VA = "0x189D954C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float GJTRAYLEXAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD463B0", Offset = "0xD453B0", VA = "0x180D463B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float IBASZTLBKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD45FE0", Offset = "0xD44FE0", VA = "0x180D45FE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float ONIZMHTUSRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9D950A0", Offset = "0x9D940A0", VA = "0x189D950A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9D92880", Offset = "0x9D91880", VA = "0x189D92880")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D95680", Offset = "0x9D94680", VA = "0x189D95680")]
		public RRCUAEIDBNE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D950E0", Offset = "0x9D940E0", VA = "0x189D950E0")]
		public void NPSJGUTWWJY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D95170", Offset = "0x9D94170", VA = "0x189D95170")]
		public void QSVCBTGGVTC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D950C0", Offset = "0x9D940C0", VA = "0x189D950C0")]
		public void MXCIKFXAMSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D92780", Offset = "0x9D91780", VA = "0x189D92780")]
		public void KOOCTEZCZGU(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D94F90", Offset = "0x9D93F90", VA = "0x189D94F90")]
		public void KOOCTEZCZGU(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D94F60", Offset = "0x9D93F60", VA = "0x189D94F60")]
		private int IBHYLENTVGV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9D95560", Offset = "0x9D94560", VA = "0x189D95560", Slot = "4")]
		[IteratorStateMachine(typeof(ITOEEJCQEVX))]
		private IEnumerator<float> RHBYQVVHTQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D955E0", Offset = "0x9D945E0", VA = "0x189D955E0", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MMELQOXIFNV
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int PNTWRWEAXDV = 512;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const int IWQRKQEVWHE = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int TYXCXUSHLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float[] WNZAGAOZJDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Material TTNXTZFTOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float LGRGLAOFXXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float UMPLTMBJZQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float QURLFABXCUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float ZXWYBAQNFFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float EWBQHJEVUDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Color DIDCMJRKEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Color PSZYIHITSXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Color UZYYEUHRTTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Color VRNMGGSXPYW;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly int PGRMWRAPQXH;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly int YMXLGEBLEUJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly int KKTVXKZKJTZ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly int OPMBUDKXAWW;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly int RXQJSZRCKKC;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly int HMHUIPWUXQO;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly int MLPJLGWCAWI;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly int EWWIGYRNUGK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly int SVRKQMNZUSG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly int YMHPJSQMAKE;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly int HQKNQSIRMAU;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material PPDPXHUEIBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9D92E00", Offset = "0x9D91E00", VA = "0x189D92E00")]
		public void VWHZZDMMGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9D92EA0", Offset = "0x9D91EA0", VA = "0x189D92EA0")]
		public void VWPJLGPLIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9D92A80", Offset = "0x9D91A80", VA = "0x189D92A80")]
		public void AIGSVJPLCHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9D92D50", Offset = "0x9D91D50", VA = "0x189D92D50")]
		public void VSWZGBIIWED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9D92B00", Offset = "0x9D91B00", VA = "0x189D92B00")]
		public void ESXNMWMCFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D92CD0", Offset = "0x9D91CD0", VA = "0x189D92CD0")]
		public void NOMPDGZFBER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9D92C20", Offset = "0x9D91C20", VA = "0x189D92C20")]
		public void LKAUQIFXBBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9D93140", Offset = "0x9D92140", VA = "0x189D93140")]
		public MMELQOXIFNV()
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
