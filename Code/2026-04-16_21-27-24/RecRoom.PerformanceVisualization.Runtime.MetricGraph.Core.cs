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
	public static class VJEDWWAJVWC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1353C10", Offset = "0x1352A10", VA = "0x181353C10")]
		public static Color BSROBYKLWQP(this RRColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DCD0", Offset = "0x9C1CAD0", VA = "0x189C1DCD0")]
		public static Color BSROBYKLWQP(this RRColor32 a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DD30", Offset = "0x9C1CB30", VA = "0x189C1DD30")]
		public static Color32 TWALJKMGSFI(this RRColor32 a)
		{
			return default(Color32);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker PAXNQZEJMBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker JELAVVSNOVN;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int XQIMSEJYLEO = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int JGLUIVSWRKM = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private YAHHXRRARNN NAPBHKCNJMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool SUXGRHLHYTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float ZAYLIZWURRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float AIMZANFVJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float TRXUUHXXVWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float PYRXRDWZDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float WHADKHZKUIR;

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
		private WRHYBJHFNOS WOSJVZYKLBA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int WRBQQGCQWHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9C1D920", Offset = "0x9C1C720", VA = "0x189C1D920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int OLENUSKXGYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C1D570", Offset = "0x9C1C370", VA = "0x189C1D570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int KYCQIWJHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C1CBA0", Offset = "0x9C1B9A0", VA = "0x189C1CBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NYTALHBMXKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DCB0", Offset = "0x9C1CAB0", VA = "0x189C1DCB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int DWQYLGSKXKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DC80", Offset = "0x9C1CA80", VA = "0x189C1DC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float UUKBZIMGRDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DBE0", Offset = "0x9C1C9E0", VA = "0x189C1DBE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float GRWGMSQZHLN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DC20", Offset = "0x9C1CA20", VA = "0x189C1DC20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float ESMOTNBEGPT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DC00", Offset = "0x9C1CA00", VA = "0x189C1DC00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float FPRXDGHHPMX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DC40", Offset = "0x9C1CA40", VA = "0x189C1DC40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float FWAVQXZGLXE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9C1DC60", Offset = "0x9C1CA60", VA = "0x189C1DC60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C1CB70", Offset = "0x9C1B970", VA = "0x189C1CB70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D590", Offset = "0x9C1C390", VA = "0x189C1D590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D8F0", Offset = "0x9C1C6F0", VA = "0x189C1D8F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D5F0", Offset = "0x9C1C3F0", VA = "0x189C1D5F0")]
		public void PushSample(double sampleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C1CC00", Offset = "0x9C1BA00", VA = "0x189C1CC00")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C1CC30", Offset = "0x9C1BA30", VA = "0x189C1CC30")]
		private void GZZDNWQGHRH(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D620", Offset = "0x9C1C420", VA = "0x189C1D620")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D3F0", Offset = "0x9C1C1F0", VA = "0x189C1D3F0")]
		public void InitData(int newBufferCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C1CF00", Offset = "0x9C1BD00", VA = "0x189C1CF00")]
		private void ILETKEGPYDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D940", Offset = "0x9C1C740", VA = "0x189C1D940")]
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
		private WRHYBJHFNOS WOSJVZYKLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private YAHHXRRARNN CNHAOKPVFAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material GVJSISAPXWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool YVROBGPGTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C1CB00", Offset = "0x9C1B900", VA = "0x189C1CB00")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C1BF00", Offset = "0x9C1AD00", VA = "0x189C1BF00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C1BF20", Offset = "0x9C1AD20", VA = "0x189C1BF20")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C180", Offset = "0x9C1AF80", VA = "0x189C1C180", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C370", Offset = "0x9C1B170", VA = "0x189C1C370")]
		public void UpdateData(double value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C520", Offset = "0x9C1B320", VA = "0x189C1C520")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C8F0", Offset = "0x9C1B6F0", VA = "0x189C1C8F0")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold, RRColor32 baseColor, RRColor32 averageColor, RRColor32 cautionColor, RRColor32 criticalColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C5A0", Offset = "0x9C1B3A0", VA = "0x189C1C5A0")]
		public void UpdateThreshold(GLCJMGHQAZW threshold, double scale = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C240", Offset = "0x9C1B040", VA = "0x189C1C240")]
		public void ResetValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class YAHHXRRARNN : IEnumerable<float>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MOPOHKKFTYG : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private float OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public YAHHXRRARNN XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int GQKQQFHGMTL;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private float KRLLHBJIPNF
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xEB8BD0", Offset = "0xEB79D0", VA = "0x180EB8BD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x2079480", Offset = "0x2078280", VA = "0x182079480", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public MOPOHKKFTYG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9C1BE30", Offset = "0x9C1AC30", VA = "0x189C1BE30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9C1BEC0", Offset = "0x9C1ACC0", VA = "0x189C1BEC0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float[] SGJGKVUDGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private float CGHFBALPLUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float EGLYJHCZYKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float KMMFCQKJXAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int OGISPEOMNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int ZWFILALYVRC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int QKUWXCNEPPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x282F4B0", Offset = "0x282E2B0", VA = "0x18282F4B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float CPYOIOCJGQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9C1E980", Offset = "0x9C1D780", VA = "0x189C1E980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float FPSSRLNQMRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9C1EAF0", Offset = "0x9C1D8F0", VA = "0x189C1EAF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float SEBXUWMDPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5B0", Offset = "0xD4C3B0", VA = "0x180D4D5B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float UEGRDDDOCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD4D630", Offset = "0xD4C430", VA = "0x180D4D630")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float QDLDKXJKBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9C1E960", Offset = "0x9C1D760", VA = "0x189C1E960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9C1BD90", Offset = "0x9C1AB90", VA = "0x189C1BD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C1EB90", Offset = "0x9C1D990", VA = "0x189C1EB90")]
		public YAHHXRRARNN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C1EA60", Offset = "0x9C1D860", VA = "0x189C1EA60")]
		public void VGJAOXESARR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E580", Offset = "0x9C1D380", VA = "0x189C1E580")]
		public void CVDYFKEWWYL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E940", Offset = "0x9C1D740", VA = "0x189C1E940")]
		public void FEJBWZSDOCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C1BC90", Offset = "0x9C1AA90", VA = "0x189C1BC90")]
		public void AGNRDKLWHLB(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E470", Offset = "0x9C1D270", VA = "0x189C1E470")]
		public void AGNRDKLWHLB(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E990", Offset = "0x9C1D790", VA = "0x189C1E990")]
		private int TNKFDILUOJM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E8D0", Offset = "0x9C1D6D0", VA = "0x189C1E8D0", Slot = "4")]
		[IteratorStateMachine(typeof(MOPOHKKFTYG))]
		private IEnumerator<float> ESRJLOPYUSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E9C0", Offset = "0x9C1D7C0", VA = "0x189C1E9C0", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class WRHYBJHFNOS
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int CAKVAUBAGOA = 512;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const int QAHUBEBEMFF = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int IZNASIXBYNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float[] BMNPFSDMRRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Material HHMSNTNERSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float FORYYXHAOGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float VNJYTSFAHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float XMTQMXUVHXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float MFUWLWGYIWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float JFPJVPFYCVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Color UVHRLBAMABR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Color NEIHZXJGDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Color HSDCCWWEDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Color JYKMDUATTRV;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly int EYUEYPUHMUQ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly int RHVHWDRIOWS;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly int SNLKFAYLHGI;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly int MMEZKQBGVPD;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly int NNAWZGMIWMT;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly int FTERGIYJHIL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly int EUWYCUHNAEP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly int FAWETAFRMVL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly int XSYOLXAPHGH;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly int EFIFBSXXPRD;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly int KHGCQGZHTUN;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material KOSKITVPIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DE10", Offset = "0x9C1CC10", VA = "0x189C1DE10")]
		public void HEPQBFIOMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E050", Offset = "0x9C1CE50", VA = "0x189C1E050")]
		public void NPWXIKJREYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DFD0", Offset = "0x9C1CDD0", VA = "0x189C1DFD0")]
		public void JTAMPOPUYBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E160", Offset = "0x9C1CF60", VA = "0x189C1E160")]
		public void XNWRBTCUBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DEB0", Offset = "0x9C1CCB0", VA = "0x189C1DEB0")]
		public void JIGKWACJPPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E0E0", Offset = "0x9C1CEE0", VA = "0x189C1E0E0")]
		public void RWPIQOTUYAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DD60", Offset = "0x9C1CB60", VA = "0x189C1DD60")]
		public void FOCAECHIHUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9C1E420", Offset = "0x9C1D220", VA = "0x189C1E420")]
		public WRHYBJHFNOS()
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
