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
public static class DJNDEIHBPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1193850", Offset = "0x1192650", VA = "0x181193850")]
	public static Color EBCLEHKADAB(this RRColor DEJLIDMJHPI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x813E8B0", Offset = "0x813D6B0", VA = "0x18813E8B0")]
	public static Color EBCLEHKADAB(this RRColor32 DEJLIDMJHPI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x813E910", Offset = "0x813D710", VA = "0x18813E910")]
	public static Color32 IDOANHPBCPC(this RRColor32 DEJLIDMJHPI)
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
		private ProfilerMarker LOJOLIOHKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker PDGLFLMIMHM;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int IMMDHHEFGFI = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int BHCEBGGPGDJ = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AAGJINCLDHN MPEFDDHOCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool CHGBOMPADNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float ENOGMCELMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float FFHLACOLDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float HHNPNEKBDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float DFIKFCFIEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float OKDFLDINBMO;

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
		private ECPABGKANBI PAGOJAFNBHI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int ENJANJMJADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x81405B0", Offset = "0x813F3B0", VA = "0x1881405B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int CCIOHPJPLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x81405D0", Offset = "0x813F3D0", VA = "0x1881405D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int DMMLHEJNMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8140550", Offset = "0x813F350", VA = "0x188140550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FHNBHAJPHCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8140F80", Offset = "0x813FD80", VA = "0x188140F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int JOJGMFCDDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8140F50", Offset = "0x813FD50", VA = "0x188140F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float PMHJGPPAENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8140EB0", Offset = "0x813FCB0", VA = "0x188140EB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HIKPEMGOALA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8140EF0", Offset = "0x813FCF0", VA = "0x188140EF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float LHPABIBOGEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8140ED0", Offset = "0x813FCD0", VA = "0x188140ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float PFEBJDPGMHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8140F10", Offset = "0x813FD10", VA = "0x188140F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float JEKJGJININI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8140F30", Offset = "0x813FD30", VA = "0x188140F30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x813FE10", Offset = "0x813EC10", VA = "0x18813FE10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8140850", Offset = "0x813F650", VA = "0x188140850")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8140BE0", Offset = "0x813F9E0", VA = "0x188140BE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81408B0", Offset = "0x813F6B0", VA = "0x1881408B0")]
		public void PushSample(double HAMFBGLIEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x813FE40", Offset = "0x813EC40", VA = "0x18813FE40")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81405F0", Offset = "0x813F3F0", VA = "0x1881405F0")]
		private void MJAAENAIHPI(bool PGBCKJJIOAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81408E0", Offset = "0x813F6E0", VA = "0x1881408E0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81403A0", Offset = "0x813F1A0", VA = "0x1881403A0")]
		public void InitData(int OCODIHHHBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x813FE70", Offset = "0x813EC70", VA = "0x18813FE70")]
		private void HAPDKMFBODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8140C10", Offset = "0x813FA10", VA = "0x188140C10")]
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
		private ECPABGKANBI PAGOJAFNBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AAGJINCLDHN IKOLIOOKKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material DKEDPFHKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool CECPDLCJHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x813FDA0", Offset = "0x813EBA0", VA = "0x18813FDA0")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x813F180", Offset = "0x813DF80", VA = "0x18813F180", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x813F1A0", Offset = "0x813DFA0", VA = "0x18813F1A0")]
		private void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x813F420", Offset = "0x813E220", VA = "0x18813F420", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x813F610", Offset = "0x813E410", VA = "0x18813F610")]
		public void UpdateData(double OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x813F7C0", Offset = "0x813E5C0", VA = "0x18813F7C0")]
		public void UpdateThreshold(double KGHBCOFPNAL, double JAIJMBHICAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x813FB90", Offset = "0x813E990", VA = "0x18813FB90")]
		public void UpdateThreshold(double KGHBCOFPNAL, double JAIJMBHICAH, RRColor32 DDFLDEGIBML, RRColor32 KMNIIGAKJMA, RRColor32 KHLBIMLDCPO, RRColor32 JAOHBCFBEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x813F840", Offset = "0x813E640", VA = "0x18813F840")]
		public void UpdateThreshold(KFIPPEBIAJL NKALBDLCLFI, double JCGDFDLNFJA = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x813F4E0", Offset = "0x813E2E0", VA = "0x18813F4E0")]
		public void ResetValues()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public class AAGJINCLDHN : IEnumerable<float>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MLIICKCIBFG : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AAGJINCLDHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD49CC0", Offset = "0xD48AC0", VA = "0x180D49CC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x813F130", Offset = "0x813DF30", VA = "0x18813F130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public MLIICKCIBFG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x813F050", Offset = "0x813DE50", VA = "0x18813F050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x813F0E0", Offset = "0x813DEE0", VA = "0x18813F0E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float[] KJIPGHKINFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private float JJLOIPCKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private float CEDDBAAAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private float ABFINJINKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int DNEDDLPBION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int ALFGNAHPKIG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HFLLAFNJABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x260ABF0", Offset = "0x26099F0", VA = "0x18260ABF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float KGADOMFEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x813E290", Offset = "0x813D090", VA = "0x18813E290")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float PHBOPLPIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x813E6F0", Offset = "0x813D4F0", VA = "0x18813E6F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float IDAODPLJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF09910", Offset = "0xF08710", VA = "0x180F09910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float OIDHBCMABHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD6DF10", Offset = "0xD6CD10", VA = "0x180D6DF10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float HIKMDELONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x813E380", Offset = "0x813D180", VA = "0x18813E380")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x813E0D0", Offset = "0x813CED0", VA = "0x18813E0D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x813E830", Offset = "0x813D630", VA = "0x18813E830")]
	public AAGJINCLDHN(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x813E2C0", Offset = "0x813D0C0", VA = "0x18813E2C0")]
	public void FIHNGCJPOKN(int MGDEAMEOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x813E3A0", Offset = "0x813D1A0", VA = "0x18813E3A0")]
	public void KMEIHOJOCLA(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x813E2A0", Offset = "0x813D0A0", VA = "0x18813E2A0")]
	public void FBHJOPEMJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x813DFD0", Offset = "0x813CDD0", VA = "0x18813DFD0")]
	public void CCFLADCNGFE(float[] GDCDKMJLKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x813E180", Offset = "0x813CF80", VA = "0x18813E180")]
	public void CCFLADCNGFE(float[] GDCDKMJLKDH, int IHNGPLMNIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x813E350", Offset = "0x813D150", VA = "0x18813E350")]
	private int FPANDAHFFJG(int GLAOLHCPLLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x813E700", Offset = "0x813D500", VA = "0x18813E700", Slot = "4")]
	[IteratorStateMachine(typeof(MLIICKCIBFG))]
	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x813E780", Offset = "0x813D580", VA = "0x18813E780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ECPABGKANBI
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const int IMEGBCELOLC = 512;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int FPCCIFLJCOE = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int OGPACAGBNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] JHJBJOAOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Material EFCBJICGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float CINKHOBELLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float ANAKELFKMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float LMONHJFEBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float LHKMAIAFNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float KFAGFLFCOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color CCDEKCMHKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color EMIOOPCFIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color OJOIPEODIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Color LPCNPNLMINL;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int MIJAOIKNPIG;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int GNEBLBJKGKE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int OKIKJJBIAGE;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int MLJHIBLJPMC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int JBIGBBONFCJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int OJHNBEAPICI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int PGKJGONFECH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int CFDBLLNKHIN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int EJHDAHKOBLD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int OGHCGFCOJIP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int LBLIGPDHGMC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material HCJHJANFJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x813ECD0", Offset = "0x813DAD0", VA = "0x18813ECD0")]
	public void MCJNFGDAINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x813EC40", Offset = "0x813DA40", VA = "0x18813EC40")]
	public void LCGECMGLGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x813ED70", Offset = "0x813DB70", VA = "0x18813ED70")]
	public void NLPAGJAPFFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x813EA60", Offset = "0x813D860", VA = "0x18813EA60")]
	public void CCFNAGJIIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x813E940", Offset = "0x813D740", VA = "0x18813E940")]
	public void BGNDLABCCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x813EBC0", Offset = "0x813D9C0", VA = "0x18813EBC0")]
	public void KAPFIMNCOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x813EB10", Offset = "0x813D910", VA = "0x18813EB10")]
	public void IHPILPHKEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x813F000", Offset = "0x813DE00", VA = "0x18813F000")]
	public ECPABGKANBI()
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
