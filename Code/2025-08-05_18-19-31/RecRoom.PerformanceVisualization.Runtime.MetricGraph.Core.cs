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
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KKHKLBBBBJN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x12DDF40", Offset = "0x12DD340", VA = "0x1812DDF40")]
	public static Color ECPBHHICBMN(this RRColor IFBOGFLAOGG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x866B450", Offset = "0x866A850", VA = "0x18866B450")]
	public static Color ECPBHHICBMN(this RRColor32 IFBOGFLAOGG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x866B420", Offset = "0x866A820", VA = "0x18866B420")]
	public static Color32 CABJBJDLJLO(this RRColor32 IFBOGFLAOGG)
	{
		return default(Color32);
	}
}
namespace RecRoom.Profiling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricGraph : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ProfilerMarker FANJMCPHMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker HPDMPEGMMCE;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int DDFNCMEEJGP = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int NHOEKFJEFIM = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private OLIAMAFHGOP GPMHDHIAICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool GLNOPGAPJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float DINPPPPONOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float NLCGABEDLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float BKCKKFHOAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float CBIKNJJCDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float PMNFHMAHMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Graph")]
		[SerializeField]
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
		[Header("Graph Visuals")]
		[SerializeField]
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
		[SerializeField]
		[Space]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private int cautionValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Color cautionValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private int criticalValueThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Color criticalValueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LCPMFEBFKKL MEJNICLGNHI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int AMMEPFLKCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x866CDE0", Offset = "0x866C1E0", VA = "0x18866CDE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int MBCCGEDMGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x866D060", Offset = "0x866C460", VA = "0x18866D060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int BCJHHAHOMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x866D230", Offset = "0x866C630", VA = "0x18866D230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MNNBMKJCDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x866D9C0", Offset = "0x866CDC0", VA = "0x18866D9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EBKJKFNNPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x866D990", Offset = "0x866CD90", VA = "0x18866D990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float CHECJJOAELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x866D8F0", Offset = "0x866CCF0", VA = "0x18866D8F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float MKPECDNIOPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x866D930", Offset = "0x866CD30", VA = "0x18866D930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float DFPEEKHDDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x866D910", Offset = "0x866CD10", VA = "0x18866D910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float IKPBELLGKKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x866D950", Offset = "0x866CD50", VA = "0x18866D950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float EDKILPBLDCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x866D970", Offset = "0x866CD70", VA = "0x18866D970")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x866C850", Offset = "0x866BC50", VA = "0x18866C850")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x866D290", Offset = "0x866C690", VA = "0x18866D290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x866D620", Offset = "0x866CA20", VA = "0x18866D620")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x866D2F0", Offset = "0x866C6F0", VA = "0x18866D2F0")]
		public void PushSample(double NFFHPGIIDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x866C880", Offset = "0x866BC80", VA = "0x18866C880")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x866CE00", Offset = "0x866C200", VA = "0x18866CE00")]
		private void FGOHJMLPAPJ(bool KBIBIFOFAKG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x866D320", Offset = "0x866C720", VA = "0x18866D320")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x866D080", Offset = "0x866C480", VA = "0x18866D080")]
		public void InitData(int EPPHNNEOMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x866C8B0", Offset = "0x866BCB0", VA = "0x18866C8B0")]
		private void DBCPAEONANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x866D650", Offset = "0x866CA50", VA = "0x18866D650")]
		public MetricGraph()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class MetricGraphGraphic : Graphic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LCPMFEBFKKL MEJNICLGNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OLIAMAFHGOP POEEENLEDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material BNCCHKNHMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool DOCDCNEPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x866C7E0", Offset = "0x866BBE0", VA = "0x18866C7E0")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x866BBC0", Offset = "0x866AFC0", VA = "0x18866BBC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x866BCA0", Offset = "0x866B0A0", VA = "0x18866BCA0")]
		private void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x866BBE0", Offset = "0x866AFE0", VA = "0x18866BBE0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x866C050", Offset = "0x866B450", VA = "0x18866C050")]
		public void UpdateData(double CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x866C200", Offset = "0x866B600", VA = "0x18866C200")]
		public void UpdateThreshold(double LKEGKPHLOKB, double LKKFLMFJFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x866C5D0", Offset = "0x866B9D0", VA = "0x18866C5D0")]
		public void UpdateThreshold(double LKEGKPHLOKB, double LKKFLMFJFDB, RRColor32 JCOIDDADMCN, RRColor32 HBPFJGCNBFG, RRColor32 MJDGBIPGNMO, RRColor32 ABEJNAMLOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x866C280", Offset = "0x866B680", VA = "0x18866C280")]
		public void UpdateThreshold(FCHKFFDPIJG FEEJNGIJPHG, double MJHAIBCGLLD = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x866BF20", Offset = "0x866B320", VA = "0x18866BF20")]
		public void ResetValues()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public class OLIAMAFHGOP : IEnumerable<float>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GGJKDFONCDP : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public OLIAMAFHGOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xE55900", Offset = "0xE54D00", VA = "0x180E55900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x866B3D0", Offset = "0x866A7D0", VA = "0x18866B3D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public GGJKDFONCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x866B2F0", Offset = "0x866A6F0", VA = "0x18866B2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x866B380", Offset = "0x866A780", VA = "0x18866B380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float[] IDHGNOPFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private float FELPICHHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private float IDCCLFDFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private float JMCGDEAELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int JFAEEHMDGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int PPNAGMANAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DMBGGHINDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D9E10", Offset = "0x28D9210", VA = "0x1828D9E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float KBFLBBDMAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x866DBD0", Offset = "0x866CFD0", VA = "0x18866DBD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float ALHFLMJKIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x866DAB0", Offset = "0x866CEB0", VA = "0x18866DAB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float HFPFHNPJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float HCFMKONMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float EKBHGPPFDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x866DA70", Offset = "0x866CE70", VA = "0x18866DA70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x866B140", Offset = "0x866A540", VA = "0x18866B140")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x866E080", Offset = "0x866D480", VA = "0x18866E080")]
	public OLIAMAFHGOP(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x866D9E0", Offset = "0x866CDE0", VA = "0x18866D9E0")]
	public void FODMAFOLDOE(int PKLJCGFDBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x866DBE0", Offset = "0x866CFE0", VA = "0x18866DBE0")]
	public void IICAHHIMAOL(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x866DA90", Offset = "0x866CE90", VA = "0x18866DA90")]
	public void GADNJPLNCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x866B1F0", Offset = "0x866A5F0", VA = "0x18866B1F0")]
	public void HOJPOGONHML(float[] NJJNDJLGDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x866DAC0", Offset = "0x866CEC0", VA = "0x18866DAC0")]
	public void HOJPOGONHML(float[] NJJNDJLGDNH, int FODHAFIPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x866DF30", Offset = "0x866D330", VA = "0x18866DF30")]
	private int NOEBADCJNIB(int NOEININIMIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x866DF60", Offset = "0x866D360", VA = "0x18866DF60", Slot = "4")]
	[IteratorStateMachine(typeof(GGJKDFONCDP))]
	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x866DFE0", Offset = "0x866D3E0", VA = "0x18866DFE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LCPMFEBFKKL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const int NFDHDKGKNBA = 512;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int CFPNIOCMCGA = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int EEAIEMAGOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] PMLFPHLHNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Material GMFBEMFEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float POKPBNBDBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float NDJPGPKHIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float IDMHFOKHEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float FHHOBODHJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float DCGHOEFEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color ALNLPDNNHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color JKJHEKBHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color AJDPNMPCICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Color EKFDIMLNGJD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int MDKBFPJOFIM;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int HJDFODDJHND;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int HGPKIEDFNBM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int FJFONLGCOGE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int KEFFLPEMHKN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int LCLBEBDOBMM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int HNHOIAMODLM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int AJODJFGIJLK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int KKFGEJGFMKD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int MCJMOOIKKAL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int DJJMFENCKNE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x866B7B0", Offset = "0x866ABB0", VA = "0x18866B7B0")]
	public void GPCDIIDMMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x866B8D0", Offset = "0x866ACD0", VA = "0x18866B8D0")]
	public void LPDDAGOFONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x866B730", Offset = "0x866AB30", VA = "0x18866B730")]
	public void GNONHDKLLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x866B4B0", Offset = "0x866A8B0", VA = "0x18866B4B0")]
	public void DICIPCDKEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x866B610", Offset = "0x866AA10", VA = "0x18866B610")]
	public void ENKJHHHNMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x866B850", Offset = "0x866AC50", VA = "0x18866B850")]
	public void KIKHBEOCENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x866B560", Offset = "0x866A960", VA = "0x18866B560")]
	public void EGPGFLHCOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x866BB70", Offset = "0x866AF70", VA = "0x18866BB70")]
	public LCPMFEBFKKL()
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
