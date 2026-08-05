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
public static class KABKBBIEFKK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x11A5480", Offset = "0x11A3C80", VA = "0x1811A5480")]
	public static Color MBDNLEBMABK(this RRColor BIKIHAKPCIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x833E990", Offset = "0x833D190", VA = "0x18833E990")]
	public static Color MBDNLEBMABK(this RRColor32 BIKIHAKPCIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x833E960", Offset = "0x833D160", VA = "0x18833E960")]
	public static Color32 AINMCIHGPCE(this RRColor32 BIKIHAKPCIG)
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
		private ProfilerMarker KFGFIGEIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ProfilerMarker DOEOLMMHHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const int KCGCBPMLBBC = 8;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int DNDMALDNNJJ = 512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Header("Buffer")]
		[Range(8f, 512f)]
		private int bufferCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private PFMDOMEJDME OOPCEMJOJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool HEONABJJIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float OJDOJMEGEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float CNLNFNFMKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float DCCFELOHILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private float OKJKLMOFBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float DAGHFBAFAFN;

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
		private AIHPJNJLOIG HHEKGDENAGP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private int EKMANJAGABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x833F680", Offset = "0x833DE80", VA = "0x18833F680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int AFEKJGIKMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83401F0", Offset = "0x833E9F0", VA = "0x1883401F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private int NOIGGLBJIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x833FC70", Offset = "0x833E470", VA = "0x18833FC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IBGCHJBEBHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8340980", Offset = "0x833F180", VA = "0x188340980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ACOFNFHEDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8340950", Offset = "0x833F150", VA = "0x188340950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float NNFKAPGMJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83408B0", Offset = "0x833F0B0", VA = "0x1883408B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public float HKOBGAODKKC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83408F0", Offset = "0x833F0F0", VA = "0x1883408F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float BPBGPCIBDBO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83408D0", Offset = "0x833F0D0", VA = "0x1883408D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float CKLJEEKLEEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8340910", Offset = "0x833F110", VA = "0x188340910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float PDKCAKDKFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8340930", Offset = "0x833F130", VA = "0x188340930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x833F6A0", Offset = "0x833DEA0", VA = "0x18833F6A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8340210", Offset = "0x833EA10", VA = "0x188340210")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83405E0", Offset = "0x833EDE0", VA = "0x1883405E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8340270", Offset = "0x833EA70", VA = "0x188340270")]
		public void PushSample(double NPOPJBNMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x833FC40", Offset = "0x833E440", VA = "0x18833FC40")]
		public void ClearSamples()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x833FCD0", Offset = "0x833E4D0", VA = "0x18833FCD0")]
		private void IEHICKOJLCH(bool IBCIAMDAPFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83402A0", Offset = "0x833EAA0", VA = "0x1883402A0")]
		public void UpdateShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8340000", Offset = "0x833E800", VA = "0x188340000")]
		public void InitData(int PKGPPKAHLBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x833F6D0", Offset = "0x833DED0", VA = "0x18833F6D0")]
		private void BCNOMPOHCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8340610", Offset = "0x833EE10", VA = "0x188340610")]
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
		private AIHPJNJLOIG HHEKGDENAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private PFMDOMEJDME MDKEMLBKDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Material GEGEJLBNDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool KICCELHDOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private bool isZeroBased;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x833F610", Offset = "0x833DE10", VA = "0x18833F610")]
		protected MetricGraphGraphic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x833E9F0", Offset = "0x833D1F0", VA = "0x18833E9F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x833EA10", Offset = "0x833D210", VA = "0x18833EA10")]
		private void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x833EC90", Offset = "0x833D490", VA = "0x18833EC90", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x833EE80", Offset = "0x833D680", VA = "0x18833EE80")]
		public void UpdateData(double MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x833F030", Offset = "0x833D830", VA = "0x18833F030")]
		public void UpdateThreshold(double LLIBIHHENOP, double LCIGEGNAEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x833F400", Offset = "0x833DC00", VA = "0x18833F400")]
		public void UpdateThreshold(double LLIBIHHENOP, double LCIGEGNAEKP, RRColor32 GHACELNNKIA, RRColor32 BJOCHDBKFKO, RRColor32 DBJDKKFMGIJ, RRColor32 OEMNNHDJLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x833F0B0", Offset = "0x833D8B0", VA = "0x18833F0B0")]
		public void UpdateThreshold(AGGICKCJJAM IILNEBJHNFN, double DKMKOJPHLDD = 1.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x833ED50", Offset = "0x833D550", VA = "0x18833ED50")]
		public void ResetValues()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DefaultMember("Item")]
public class PFMDOMEJDME : IEnumerable<float>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class AMDHAPCOCDB : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PFMDOMEJDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		float IEnumerator<float>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD9E9F0", Offset = "0xD9D1F0", VA = "0x180D9E9F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x833E910", Offset = "0x833D110", VA = "0x18833E910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public AMDHAPCOCDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x833E830", Offset = "0x833D030", VA = "0x18833E830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x833E8C0", Offset = "0x833D0C0", VA = "0x18833E8C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float[] PFJNGBMMPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private float EDBIKCGPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private float PIMEBNLNKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private float BFHGHFNMGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int DPGDGCCCHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int FMGALNGIOGC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26AF170", Offset = "0x26AD970", VA = "0x1826AF170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float PPBMKCELGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8340F10", Offset = "0x833F710", VA = "0x188340F10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float KJCMLDCCHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8340EE0", Offset = "0x833F6E0", VA = "0x188340EE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float PGCPFGLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float DENPJAMHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xDD27A0", Offset = "0xDD0FA0", VA = "0x180DD27A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GKGMLNECCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8340EF0", Offset = "0x833F6F0", VA = "0x188340EF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x833E0D0", Offset = "0x833C8D0", VA = "0x18833E0D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8341040", Offset = "0x833F840", VA = "0x188341040")]
	public PFMDOMEJDME(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8340E50", Offset = "0x833F650", VA = "0x188340E50")]
	public void KNDNBBLJEIO(int GJNLFMAEJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83409D0", Offset = "0x833F1D0", VA = "0x1883409D0")]
	public void DNMKJDBNEHD(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8340E30", Offset = "0x833F630", VA = "0x188340E30")]
	public void IPDEKEDDMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x833DFD0", Offset = "0x833C7D0", VA = "0x18833DFD0")]
	public void GEINGGKGDBD(float[] OLBBKGLINIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8340D20", Offset = "0x833F520", VA = "0x188340D20")]
	public void GEINGGKGDBD(float[] OLBBKGLINIK, int DEPGPAAGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83409A0", Offset = "0x833F1A0", VA = "0x1883409A0")]
	private int AMMEBOFCEIP(int PNJCJGEIDHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8340F20", Offset = "0x833F720", VA = "0x188340F20", Slot = "4")]
	[IteratorStateMachine(typeof(AMDHAPCOCDB))]
	IEnumerator<float> IEnumerable<float>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8340FA0", Offset = "0x833F7A0", VA = "0x188340FA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AIHPJNJLOIG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const int NNJDMBIEONG = 512;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const int BAIDCJILGLP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int NBEFKKKJLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] JJHHGCCJPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Material IPKNLMFNGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float EJIJCEFMNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float LOGFPAGEFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float BCIFPDMCJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float IEAJNKCNMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float EAHNHIINEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Color PJCFKKDIIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color JLMJKJENHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color HHADBEHJMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Color HIEHBNIAJIJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly int GFJHIIBOEOH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly int BHCEOLPFGLJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly int IEJCFELPLHA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly int JNKAMHAEFOK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly int DCDLMCGGLKA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly int NNGCKOBFKLP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly int OBOLIOGDKCP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly int CEILDNEGLIE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly int CDCODFGHFNH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly int IDELCANODME;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly int EOLBIPFKEHC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material CCOKKNAJIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x833E220", Offset = "0x833CA20", VA = "0x18833E220")]
	public void CMECNGMJLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x833E3E0", Offset = "0x833CBE0", VA = "0x18833E3E0")]
	public void JANICODEOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x833E460", Offset = "0x833CC60", VA = "0x18833E460")]
	public void MINPEIKGPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x833E340", Offset = "0x833CB40", VA = "0x18833E340")]
	public void ICOOPLCEBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x833E4E0", Offset = "0x833CCE0", VA = "0x18833E4E0")]
	public void OABOAEODOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x833E2C0", Offset = "0x833CAC0", VA = "0x18833E2C0")]
	public void DBENGFABGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x833E180", Offset = "0x833C980", VA = "0x18833E180")]
	public void BIFBHGAKJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x833E7E0", Offset = "0x833CFE0", VA = "0x18833E7E0")]
	public AIHPJNJLOIG()
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
