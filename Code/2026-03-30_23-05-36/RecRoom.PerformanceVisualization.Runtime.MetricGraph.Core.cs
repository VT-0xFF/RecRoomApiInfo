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
	public static class NFTKHKRPRVX
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1145D20", Offset = "0x1144B20", VA = "0x181145D20")]
		public static Color YHPVPDKNTBW(this RRColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88FBD20", Offset = "0x88FAB20", VA = "0x1888FBD20")]
		public static Color YHPVPDKNTBW(this RRColor32 a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88FBCF0", Offset = "0x88FAAF0", VA = "0x1888FBCF0")]
		public static Color32 FFASWRCNOKB(this RRColor32 a)
		{
			return default(Color32);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker EEUYDNBQZTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker DSIWWEALWTU;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int FNXEGOWDOPT = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int WYRTUBTXVVV = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NCMAFEAMWGY DUNBMBLCLRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool WUERVWUERUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float RHNIXDBQEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float NJSOQCXNIXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float OBUPDTSVDFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float TMSUYGTHWQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float HXWMXNBYGLQ;

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
		private WWDNPQCAZRD AZWSETYCOOZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int EIAHQOXOVCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x88FA470", Offset = "0x88F9270", VA = "0x1888FA470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int CTGKXQQGTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88FA450", Offset = "0x88F9250", VA = "0x1888FA450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int SELRXLYJHJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88FAB90", Offset = "0x88F9990", VA = "0x1888FAB90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ETSFLXBVZDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x88FB530", Offset = "0x88FA330", VA = "0x1888FB530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int NHNGAAVHHIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x88FB500", Offset = "0x88FA300", VA = "0x1888FB500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float RYPRGNHSLNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88FB460", Offset = "0x88FA260", VA = "0x1888FB460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float FAXMTJYWCKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x88FB4A0", Offset = "0x88FA2A0", VA = "0x1888FB4A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float GYRBINLMFTO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x88FB480", Offset = "0x88FA280", VA = "0x1888FB480")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float TWDFZRAEWYA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x88FB4C0", Offset = "0x88FA2C0", VA = "0x1888FB4C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float MEBCEELGVSF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x88FB4E0", Offset = "0x88FA2E0", VA = "0x1888FB4E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88FA3F0", Offset = "0x88F91F0", VA = "0x1888FA3F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88FAB00", Offset = "0x88F9900", VA = "0x1888FAB00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88FAEC0", Offset = "0x88F9CC0", VA = "0x1888FAEC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88FAB60", Offset = "0x88F9960", VA = "0x1888FAB60")]
		public void PushSample(double sampleValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88FA420", Offset = "0x88F9220", VA = "0x1888FA420")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88FAEF0", Offset = "0x88F9CF0", VA = "0x1888FAEF0")]
		private void YBCJNSQTFRU(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88FABF0", Offset = "0x88F99F0", VA = "0x1888FABF0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88FA980", Offset = "0x88F9780", VA = "0x1888FA980")]
		public void InitData(int newBufferCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88FA490", Offset = "0x88F9290", VA = "0x1888FA490")]
		private void ISUBOBETPYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88FB1C0", Offset = "0x88F9FC0", VA = "0x1888FB1C0")]
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
		private WWDNPQCAZRD AZWSETYCOOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private NCMAFEAMWGY LPZUCAXLPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material YAGBSLBPOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool PZDNXTBXSNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88FA380", Offset = "0x88F9180", VA = "0x1888FA380")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88F9780", Offset = "0x88F8580", VA = "0x1888F9780", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88F97A0", Offset = "0x88F85A0", VA = "0x1888F97A0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88F9A00", Offset = "0x88F8800", VA = "0x1888F9A00", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88F9BF0", Offset = "0x88F89F0", VA = "0x1888F9BF0")]
		public void UpdateData(double value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88F9DA0", Offset = "0x88F8BA0", VA = "0x1888F9DA0")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88F9E20", Offset = "0x88F8C20", VA = "0x1888F9E20")]
		public void UpdateThreshold(double cautionThreshold, double criticalThreshold, RRColor32 baseColor, RRColor32 averageColor, RRColor32 cautionColor, RRColor32 criticalColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88FA030", Offset = "0x88F8E30", VA = "0x1888FA030")]
		public void UpdateThreshold(ZISOJWSFYGL threshold, double scale = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88F9AC0", Offset = "0x88F88C0", VA = "0x1888F9AC0")]
		public void ResetValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class NCMAFEAMWGY : IEnumerable<float>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class TEWLDCROHDJ : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private float LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public NCMAFEAMWGY FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int QZMPRZMGFLM;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private float BQCYDGKYOUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xCA8380", Offset = "0xCA7180", VA = "0x180CA8380", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x1E569D0", Offset = "0x1E557D0", VA = "0x181E569D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public TEWLDCROHDJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88FBD80", Offset = "0x88FAB80", VA = "0x1888FBD80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88FBE10", Offset = "0x88FAC10", VA = "0x1888FBE10", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float[] UWYCHKBDEIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private float FTWAVRKMIDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float HSKQZVYRXGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float WLFRNLMRFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int GUFCCAAPDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int VQDVFZSZBDN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GREWHVQIKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int JYLETXYPMLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x25F6910", Offset = "0x25F5710", VA = "0x1825F6910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float NEIKKFQKGFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x88FBC40", Offset = "0x88FAA40", VA = "0x1888FBC40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float PBQGFEEZLRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88FB9B0", Offset = "0x88FA7B0", VA = "0x1888FB9B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float VRQTPNLALVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB1F7E0", Offset = "0xB1E5E0", VA = "0x180B1F7E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float XQFJTRZGAXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB1F7D0", Offset = "0xB1E5D0", VA = "0x180B1F7D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float TBMDXOQWNQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x88FBC50", Offset = "0x88FAA50", VA = "0x1888FBC50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x88F96E0", Offset = "0x88F84E0", VA = "0x1888F96E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88FBC70", Offset = "0x88FAA70", VA = "0x1888FBC70")]
		public NCMAFEAMWGY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88FBAF0", Offset = "0x88FA8F0", VA = "0x1888FBAF0")]
		public void KKQGNMDFBIA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88FB660", Offset = "0x88FA460", VA = "0x1888FB660")]
		public void ELMCPZAFVMS(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88FBBB0", Offset = "0x88FA9B0", VA = "0x1888FBBB0")]
		public void WSKJJKQXZKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88F95E0", Offset = "0x88F83E0", VA = "0x1888F95E0")]
		public void DRRYBSMGXOO(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88FB550", Offset = "0x88FA350", VA = "0x1888FB550")]
		public void DRRYBSMGXOO(float[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88FBB80", Offset = "0x88FA980", VA = "0x1888FBB80")]
		private int LDLHJMLQDQH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88FBBD0", Offset = "0x88FA9D0", VA = "0x1888FBBD0", Slot = "4")]
		[IteratorStateMachine(typeof(TEWLDCROHDJ))]
		private IEnumerator<float> WZWUXXDKWXN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88FBA50", Offset = "0x88FA850", VA = "0x1888FBA50", Slot = "5")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class WWDNPQCAZRD
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int FYYUANUQOLX = 512;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const int GGDFMBTHHEQ = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int JTOIIHJQASE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float[] YKHVUPPPSDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Material EYCCBUUZXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HCBMQCFSTFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float OIOPFPZVDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float MRHNGUZYQBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float ICLUNIEOUDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float RZSJMFTBNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Color FNWYHEWTGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Color HPUSIJSNTZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Color ENFITKILYZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Color LVKVJUDLGWA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly int CAVGHGPBEED;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly int KMXTERGBHHF;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly int GOOUYJTNEXH;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly int CIYFVAASPRK;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly int UCNLNBOQQZO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly int DTJAGULMEVK;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly int UUOWMJPGRBY;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly int MPQYFKGRWBG;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly int UWKTSFZBLLW;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly int UNHKVBEDTZM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly int MDSXHJNWPDE;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material IFHTWVDKOER
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88FC130", Offset = "0x88FAF30", VA = "0x1888FC130")]
		public void QNCXUJSTVJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88FC0A0", Offset = "0x88FAEA0", VA = "0x1888FC0A0")]
		public void PJKEAWCVGFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88FC1D0", Offset = "0x88FAFD0", VA = "0x1888FC1D0")]
		public void TCQDCYJEMYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88FBF70", Offset = "0x88FAD70", VA = "0x1888FBF70")]
		public void HMXXZZXREVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88FBE50", Offset = "0x88FAC50", VA = "0x1888FBE50")]
		public void HLVFQGQXVXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88FC020", Offset = "0x88FAE20", VA = "0x1888FC020")]
		public void OGDZEEGCWWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88FC250", Offset = "0x88FB050", VA = "0x1888FC250")]
		public void YPWFAGNCLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88FC510", Offset = "0x88FB310", VA = "0x1888FC510")]
		public WWDNPQCAZRD()
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
