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
		[Cpp2IlInjected.Address(RVA = "0x9D928C0", Offset = "0x9D918C0", VA = "0x189D928C0")]
		public static Color MAITATSLSYC(this RRColor32 a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D92920", Offset = "0x9D91920", VA = "0x189D92920")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D93E00", Offset = "0x9D92E00", VA = "0x189D93E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int FNKGSGHDJUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9D94580", Offset = "0x9D93580", VA = "0x189D94580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int ERMAWOTASKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D94490", Offset = "0x9D93490", VA = "0x189D94490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MANJDKRQLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9D94EE0", Offset = "0x9D93EE0", VA = "0x189D94EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int XWILFZJHFHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9D94EB0", Offset = "0x9D93EB0", VA = "0x189D94EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float NYNGTBLMQIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E10", Offset = "0x9D93E10", VA = "0x189D94E10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HGJUPINNTKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E50", Offset = "0x9D93E50", VA = "0x189D94E50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float IYLYDEOZSNU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E30", Offset = "0x9D93E30", VA = "0x189D94E30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float YTVXKJPNNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E70", Offset = "0x9D93E70", VA = "0x189D94E70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float PTPBNOYAPDV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9D94E90", Offset = "0x9D93E90", VA = "0x189D94E90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D93DA0", Offset = "0x9D92DA0", VA = "0x189D93DA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D944F0", Offset = "0x9D934F0", VA = "0x189D944F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D94B40", Offset = "0x9D93B40", VA = "0x189D94B40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D94550", Offset = "0x9D93550", VA = "0x189D94550")]
		public void PushSample(double sampleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D93DD0", Offset = "0x9D92DD0", VA = "0x189D93DD0")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D945A0", Offset = "0x9D935A0", VA = "0x189D945A0")]
		private void TPGCQKIGEWI(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D94870", Offset = "0x9D93870", VA = "0x189D94870")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D94310", Offset = "0x9D93310", VA = "0x189D94310")]
		public void InitData(int newBufferCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D93E20", Offset = "0x9D92E20", VA = "0x189D93E20")]
		private void HJSUXKSZOEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D94B70", Offset = "0x9D93B70", VA = "0x189D94B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D93D30", Offset = "0x9D92D30", VA = "0x189D93D30")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D93130", Offset = "0x9D92130", VA = "0x189D93130", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D93150", Offset = "0x9D92150", VA = "0x189D93150")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D933B0", Offset = "0x9D923B0", VA = "0x189D933B0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D935A0", Offset = "0x9D925A0", VA = "0x189D935A0")]
		public void UpdateData(double value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D93750", Offset = "0x9D92750", VA = "0x189D93750")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D93B20", Offset = "0x9D92B20", VA = "0x189D93B20")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold, RRColor32 baseColor, RRColor32 averageColor, RRColor32 cautionColor, RRColor32 criticalColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D937D0", Offset = "0x9D927D0", VA = "0x189D937D0")]
		public void UpdateThreshold(UUBFTJVSZWF threshold, double scale = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D93470", Offset = "0x9D92470", VA = "0x189D93470")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D92950", Offset = "0x9D91950", VA = "0x189D92950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9D929E0", Offset = "0x9D919E0", VA = "0x189D929E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D95570", Offset = "0x9D94570", VA = "0x189D95570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float MGEQZLMVINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9D95460", Offset = "0x9D94460", VA = "0x189D95460")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D95040", Offset = "0x9D94040", VA = "0x189D95040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9D92820", Offset = "0x9D91820", VA = "0x189D92820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D95620", Offset = "0x9D94620", VA = "0x189D95620")]
		public RRCUAEIDBNE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D95080", Offset = "0x9D94080", VA = "0x189D95080")]
		public void NPSJGUTWWJY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D95110", Offset = "0x9D94110", VA = "0x189D95110")]
		public void QSVCBTGGVTC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D95060", Offset = "0x9D94060", VA = "0x189D95060")]
		public void MXCIKFXAMSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D92720", Offset = "0x9D91720", VA = "0x189D92720")]
		public void KOOCTEZCZGU(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D94F30", Offset = "0x9D93F30", VA = "0x189D94F30")]
		public void KOOCTEZCZGU(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D94F00", Offset = "0x9D93F00", VA = "0x189D94F00")]
		private int IBHYLENTVGV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9D95500", Offset = "0x9D94500", VA = "0x189D95500", Slot = "4")]
		[IteratorStateMachine(typeof(ITOEEJCQEVX))]
		private IEnumerator<float> RHBYQVVHTQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D95580", Offset = "0x9D94580", VA = "0x189D95580", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D92DA0", Offset = "0x9D91DA0", VA = "0x189D92DA0")]
		public void VWHZZDMMGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9D92E40", Offset = "0x9D91E40", VA = "0x189D92E40")]
		public void VWPJLGPLIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9D92A20", Offset = "0x9D91A20", VA = "0x189D92A20")]
		public void AIGSVJPLCHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9D92CF0", Offset = "0x9D91CF0", VA = "0x189D92CF0")]
		public void VSWZGBIIWED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9D92AA0", Offset = "0x9D91AA0", VA = "0x189D92AA0")]
		public void ESXNMWMCFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D92C70", Offset = "0x9D91C70", VA = "0x189D92C70")]
		public void NOMPDGZFBER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9D92BC0", Offset = "0x9D91BC0", VA = "0x189D92BC0")]
		public void LKAUQIFXBBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9D930E0", Offset = "0x9D920E0", VA = "0x189D930E0")]
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
