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
using RecRoom.ClusterLODs;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ClusterLODConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class LODSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public float maxRadiusOfCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int minNumVertsInCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public int maxNumVertsInCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public float useLowestDetailAtSmallerRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float useHighestDetailAtGreaterRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public float maxVertSnapDist;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public float vertexNormalCombineThresh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public float maxSubDivideEdgeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float maxSubDivideDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public bool cullEncapsulated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public bool useMaterials;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool ShouldSubDivide
			{
				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x807A9E0", Offset = "0x80799E0", VA = "0x18807A9E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xEB3860", Offset = "0xEB2860", VA = "0x180EB3860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x807A9A0", Offset = "0x80799A0", VA = "0x18807A9A0")]
			public LODSettings()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Header("Layer Settings")]
		public float maxRadiusForDetailObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int maxWorldLODVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int maxWorldNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int maxDetailNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int maxDetailFarVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int maxDynamicNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int maxDynamicFarVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Creation Settings")]
		public int minNumObjectPerCluster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float distributeVSminimize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Header("Near Settings")]
		public LODSettings near;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Header("Far Settings")]
		public LODSettings far;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float backfaceCullingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float triangleCullingDistFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float LOD0VertCacheFrac;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x806A700", Offset = "0x8069700", VA = "0x18806A700")]
		public LODSettings FFKODONNNHL(DKDGLPMAAFJ AOHLAGDAFAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x806A710", Offset = "0x8069710", VA = "0x18806A710")]
		public int OCPAICPLNLN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x806A660", Offset = "0x8069660", VA = "0x18806A660")]
		public int BCPGKDFANIC(bool JDAPHOJLKIK, Vector3 LABAHDKDJDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x806A730", Offset = "0x8069730", VA = "0x18806A730")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JDBPMBDCCCC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Detail,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NumLayers
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDGJFAGENIL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOHECJKJAKD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FBADAJMIEPD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HPDPCCDNHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<AHKIDBJNFLD> PFPEANCJMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool UpdateVisibility();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateClusterDistances(Vector3 GGHGIDAMNEE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(FIPGENGPGLO LDEFIHHDIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AHKIDBJNFLD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int JAGJONLANJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FPEOFIKEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GFIOAGOCMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MIOLICMFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte IBJDDDGBPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PBNLKNMCPEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LKPNBNIBEAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PFEAKDIELPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PBNLKNMCPEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CNPHBADCGMN<string>.FNGDFCAOPOO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private CNPHBADCGMN<string>.FNGDFCAOPOO <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x807F530", Offset = "0x807E530", VA = "0x18807F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x807FCC0", Offset = "0x807ECC0", VA = "0x18807FCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BCPJJAEIDLO : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PBNLKNMCPEH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public BCPJJAEIDLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80695D0", Offset = "0x80685D0", VA = "0x1880695D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8069700", Offset = "0x8068700", VA = "0x188069700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKPMJNEJLDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PBNLKNMCPEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CNPHBADCGMN<string>.FNGDFCAOPOO worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private CNPHBADCGMN<string>.FNGDFCAOPOO <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80790E0", Offset = "0x80780E0", VA = "0x1880790E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x807A940", Offset = "0x8079940", VA = "0x18807A940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EBAPBCCPGLA : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PBNLKNMCPEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public EBAPBCCPGLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x806D2E0", Offset = "0x806C2E0", VA = "0x18806D2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x806DFD0", Offset = "0x806CFD0", VA = "0x18806DFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int NHIAJEOLGHM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NJKEJJPMGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer BCIHPJDOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter HJPNFGOHBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject HLAJCDBKJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject ADNPHFNHPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public DEDKADADAEG LCMACAIMBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<FIPGENGPGLO> AOKHDLGHJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<FIPGENGPGLO> MCOMADICALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<FIPGENGPGLO> EJPKBGFDKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CDLLBFAMDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LKPNBNIBEAC NIFPHOGLAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<FBADAJMIEPD>[] IOGFPJPCAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<AHKIDBJNFLD>[] PKEOHNBJIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource DECGNANIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool EMLLNGGBCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HHGNPNNJJPG MMHKLPKCBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HHGNPNNJJPG JPKLDOGOLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int AEJEMFJBFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static PBNLKNMCPEH CDKAGGBGIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LHAOGKNJIDI EIDBELIODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FEGIGJBFOOL NELDICMIJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour PPLEOJGMPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material BGEHGCHJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> AMPMJHLOAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material EKMAJCOKOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> PDKBHLBMNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool FCCJCGGCAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<DDGJFAGENIL> FCDOHNMJNLB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig FCJNCLGCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 CAGHKPBLIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x20568E0", Offset = "0x20558E0", VA = "0x1820568E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2056810", Offset = "0x2055810", VA = "0x182056810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LKPNBNIBEAC BAGKECAPGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1041860", Offset = "0x1040860", VA = "0x181041860")]
		get
		{
			return default(LKPNBNIBEAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x807DD30", Offset = "0x807CD30", VA = "0x18807DD30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static PBNLKNMCPEH KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x807C9F0", Offset = "0x807B9F0", VA = "0x18807C9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BFKNDCDGHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x807DFD0", Offset = "0x807CFD0", VA = "0x18807DFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool IEANEIDHOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x807E4A0", Offset = "0x807D4A0", VA = "0x18807E4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LABIMOKCIML
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x807BFB0", Offset = "0x807AFB0", VA = "0x18807BFB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x807D3F0", Offset = "0x807C3F0", VA = "0x18807D3F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KOCODMLLIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x807DF20", Offset = "0x807CF20", VA = "0x18807DF20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x807CBB0", Offset = "0x807BBB0", VA = "0x18807CBB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x807EDA0", Offset = "0x807DDA0", VA = "0x18807EDA0")]
	public PBNLKNMCPEH(LHAOGKNJIDI EIDBELIODGB, FEGIGJBFOOL NELDICMIJCH, ClusterLODConfig ONBOBOFLFEJ, MonoBehaviour PPLEOJGMPGC, Material PJHBINCPIDD, ClusterMeshRenderer BCIHPJDOOEP, MeshFilter HJPNFGOHBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x807C320", Offset = "0x807B320", VA = "0x18807C320")]
	private void DBOEAGKPJOI(Material PJHBINCPIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x807DC90", Offset = "0x807CC90", VA = "0x18807DC90")]
	public void MGHFHJAPLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x807EC00", Offset = "0x807DC00", VA = "0x18807EC00")]
	public void OGJMFKMKONI(Action<Material> OMKBGIBJLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x807C300", Offset = "0x807B300", VA = "0x18807C300")]
	public static LHCLBAAEINB.DGMMBDKGOGD DBEDEEOEDND(LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG)
	{
		return default(LHCLBAAEINB.DGMMBDKGOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x807C4F0", Offset = "0x807B4F0", VA = "0x18807C4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x807BEB0", Offset = "0x807AEB0", VA = "0x18807BEB0")]
	public static void BDLGAEOPOLA(Vector3 BCEMNAELJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x807D790", Offset = "0x807C790", VA = "0x18807D790")]
	private void KLNBNLHGBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x807D6C0", Offset = "0x807C6C0", VA = "0x18807D6C0")]
	private void KGLOEOPGAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x807CF20", Offset = "0x807BF20", VA = "0x18807CF20")]
	private void HIPJBNABPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x807E560", Offset = "0x807D560", VA = "0x18807E560")]
	public void OBEKGBFEHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x807CCE0", Offset = "0x807BCE0", VA = "0x18807CCE0")]
	[AsyncStateMachine(typeof(PFEAKDIELPG))]
	public Task HABFDDLINDG(CNPHBADCGMN<string>.FNGDFCAOPOO ODHAKILKPOM, CancellationToken JDJIJJCCKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x807D070", Offset = "0x807C070", VA = "0x18807D070")]
	[IteratorStateMachine(typeof(BCPJJAEIDLO))]
	private IEnumerator<CMMCHACHDBH> HPELFECNGGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x807CE00", Offset = "0x807BE00", VA = "0x18807CE00")]
	[AsyncStateMachine(typeof(LKPMJNEJLDF))]
	private Task HGHBNJOLJIL(CNPHBADCGMN<string>.FNGDFCAOPOO HHEIAJHNACC, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x807C070", Offset = "0x807B070", VA = "0x18807C070")]
	public void BNKLNONPEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x807DEA0", Offset = "0x807CEA0", VA = "0x18807DEA0")]
	public void MPNLJCDMHLH(IEnumerable<FBADAJMIEPD> GAHPDLMKINI, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x807D0F0", Offset = "0x807C0F0", VA = "0x18807D0F0")]
	public void HPGPBEBHOME(IEnumerable<FBADAJMIEPD> GAHPDLMKINI, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x807B8F0", Offset = "0x807A8F0", VA = "0x18807B8F0")]
	public List<ClusterMeshRenderer> BCCFEDLEAOO(List<FIPGENGPGLO> DJEGBEIIOJJ, MHHODEBGAFD NKBKNNLLHKF, JDBPMBDCCCC CHOCDIANLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x807D4B0", Offset = "0x807C4B0", VA = "0x18807D4B0")]
	public void IJOAJHLFKAH(DDGJFAGENIL LKHNLAIGKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x807C490", Offset = "0x807B490", VA = "0x18807C490")]
	public bool DKJANMFEAOO(DDGJFAGENIL LKHNLAIGKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x807C940", Offset = "0x807B940", VA = "0x18807C940")]
	public void EPBCGLBFAJF(FIPGENGPGLO EDGLKBNMIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x807CAD0", Offset = "0x807BAD0", VA = "0x18807CAD0")]
	public void FFIKNDJBDJD(AHKIDBJNFLD OGECODCBMEN, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x807C8C0", Offset = "0x807B8C0", VA = "0x18807C8C0")]
	public void EMHGDPPHFHB(AHKIDBJNFLD OGECODCBMEN, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x807DB40", Offset = "0x807CB40", VA = "0x18807DB40")]
	private void MFOJNLNCMOF(Vector3 GGHGIDAMNEE, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x807D560", Offset = "0x807C560", VA = "0x18807D560")]
	private void KBADIMNLKAG(Vector3 GGHGIDAMNEE, JDBPMBDCCCC CHOCDIANLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x807CC60", Offset = "0x807BC60", VA = "0x18807CC60")]
	[IteratorStateMachine(typeof(EBAPBCCPGLA))]
	private IEnumerator<CMMCHACHDBH> GBDFKMHDDOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x807D9D0", Offset = "0x807C9D0", VA = "0x18807D9D0")]
	private int LPHJLMKBIFP(int HLGKMAPOEBE, int JKIBLONNFAN, List<AHKIDBJNFLD> DHBPNDHGKEP, byte AOHLAGDAFAF, int LKMGBFDFDNA, float HCPLNNJOMLC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x807D820", Offset = "0x807C820", VA = "0x18807D820")]
	public void LKIPLGLLFFP(FIPGENGPGLO LDEFIHHDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x807DE60", Offset = "0x807CE60", VA = "0x18807DE60")]
	public bool MNJDJJBCKEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB12240", Offset = "0xB11240", VA = "0x180B12240")]
	public Material FCADDJNDLOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x807CA40", Offset = "0x807BA40", VA = "0x18807CA40")]
	public Material FCADDJNDLOF(LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xA62870", Offset = "0xA61870", VA = "0x180A62870")]
	public Material CGILLAAJGJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x807C270", Offset = "0x807B270", VA = "0x18807C270")]
	public Material CGILLAAJGJD(LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x807EBC0", Offset = "0x807DBC0", VA = "0x18807EBC0")]
	public int OCPAICPLNLN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x807E0D0", Offset = "0x807D0D0", VA = "0x18807E0D0")]
	public (long, int) NOBAAKADEOH()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct LPGDPJHMDIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> HHABOHOHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> FNDOEAKANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> ELFPDJAIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> LMDBPDJJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> FCMMMKFGJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> GLJEAKCGGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> PGJOKEBCOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 IHLGBGIJJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float IOJFFBEBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> FDBICENGIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> GHKOONCADFF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x807B100", Offset = "0x807A100", VA = "0x18807B100")]
	public LPGDPJHMDIJ(LHCLBAAEINB BFBFJIKLAEJ, NativeList<float3> PGJOKEBCOBB, NativeParallelMultiHashMap<int, int> FDBICENGIEN, NativeArray<int> GHKOONCADFF, Vector3 IHLGBGIJJDP, float IOJFFBEBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x807B0A0", Offset = "0x807A0A0", VA = "0x18807B0A0")]
	private int OBNPDDAHINE(float3 GGHGIDAMNEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x807AE30", Offset = "0x8079E30", VA = "0x18807AE30")]
	private int GFAFGJHJNNF(int GGLNBEGGDDO, int DAKIIEIEKNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x807AA00", Offset = "0x8079A00", VA = "0x18807AA00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HDJMDNLEGIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> FDBICENGIEN;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> GHKOONCADFF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int CCHLINPJMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> AKFJAMNGAAA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x806F2C0", Offset = "0x806E2C0", VA = "0x18806F2C0")]
	public void ADDKOBIFHCH(int EEIFKOCDMLP, Allocator FKPBEKMFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x806F4C0", Offset = "0x806E4C0", VA = "0x18806F4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HDJMDNLEGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct CNJHBEACDHI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> BJKKPDDBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> EDDBBBAGIGO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x806A5D0", Offset = "0x80695D0", VA = "0x18806A5D0")]
	public CNJHBEACDHI(HDJMDNLEGIG PNLEPEDJMCC, LHCLBAAEINB BFBFJIKLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x806A520", Offset = "0x8069520", VA = "0x18806A520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct JBPDPGJACMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> OIFLKDEFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> HPCHIHEBOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> BLLMDDFGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> HHJOABDBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> PDJFEDBNKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> AKFJAMNGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> BJKKPDDBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> CIEIADDHMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> ECBNHBKJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> NBLHFIAKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> CECAGKBABGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> AAKFAIMLABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> HOEPNDFDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float OGBLLOJDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float IEKCPEHJFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 POLMDHLPNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float BBNFDFMLIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float DNDJCDNFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float OAGBEPAKAEK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8074600", Offset = "0x8073600", VA = "0x188074600")]
	public JBPDPGJACMA(HDJMDNLEGIG FICJDAJGGED, LHCLBAAEINB BFBFJIKLAEJ, LHCLBAAEINB GNNKPGAHBIE, float DNDJCDNFEBG, float OAGBEPAKAEK, Vector3 POLMDHLPNEH, float BBNFDFMLIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8073F90", Offset = "0x8072F90", VA = "0x188073F90")]
	private float3 FAJNHFNMBKM(int GGLNBEGGDDO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8073430", Offset = "0x8072430", VA = "0x188073430")]
	private void CDMMKHKCPBO(int GGLNBEGGDDO, [Out] float3 PPEPCNOJCMC, [Out] float3 JPACCAEMEBE, [Out] float4 JAOCBEFBOJM, [Out] float4 DKNDIAPCDNI, [Out] float2 NHCBIKDNHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8074260", Offset = "0x8073260", VA = "0x188074260")]
	private int IFDPJANCDEO(int OIJFMJAHFAM, int ANEHMHIPJCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8074040", Offset = "0x8073040", VA = "0x188074040")]
	private void FKMFILEFNDE(int OIJFMJAHFAM, int ANEHMHIPJCF, int OECOMGMFFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80732E0", Offset = "0x80722E0", VA = "0x1880732E0")]
	private bool BBEJOICFNIK(int OIJFMJAHFAM, int ANEHMHIPJCF, float FNPHCNDCHKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8074540", Offset = "0x8073540", VA = "0x188074540")]
	private bool KEPPBLCLBKO(int OIJFMJAHFAM, int ANEHMHIPJCF, int OECOMGMFFCI, float FNPHCNDCHKI, bool POLKOABIPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8073080", Offset = "0x8072080", VA = "0x188073080")]
	private bool AFDEKPKEEBN(int OIJFMJAHFAM, int ANEHMHIPJCF, int OECOMGMFFCI, float FNPHCNDCHKI, bool POLKOABIPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8074240", Offset = "0x8073240", VA = "0x188074240")]
	private void HIMAAPGDHJB(int OIJFMJAHFAM, int ANEHMHIPJCF, int OECOMGMFFCI, [Out] int EFIHAEEACCL, [Out] int CGIALPAPKFD, [Out] int JFNGGFMBFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8073610", Offset = "0x8072610", VA = "0x188073610", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IGEPHIMFKPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CJOLMHPILOK : IDisposable, AHKIDBJNFLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds JCENBMMMLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<FIPGENGPGLO> DJEGBEIIOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 FJCMCDPCMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 PKCAHCEOFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int BHIBNECIDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LHCLBAAEINB ONMIIJBIGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long NJJFHFMDEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HDJMDNLEGIG DKCCHKHMFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform NKBKNNLLHKF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int MFFNCGJJHCE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8069FB0", Offset = "0x8068FB0", VA = "0x188069FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh ACCOHDLPBAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LHCLBAAEINB.DGMMBDKGOGD BHMMKCOEAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
			[CompilerGenerated]
			get
			{
				return default(LHCLBAAEINB.DGMMBDKGOGD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh OBIAEJPPAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public LHCLBAAEINB.DGMMBDKGOGD FKHJLPPAJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD3230", Offset = "0xAD2230", VA = "0x180AD3230")]
			[CompilerGenerated]
			get
			{
				return default(LHCLBAAEINB.DGMMBDKGOGD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xF81D10", Offset = "0xF80D10", VA = "0x180F81D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float GFIOAGOCMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x122F470", Offset = "0x122E470", VA = "0x18122F470", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x19AE1B0", Offset = "0x19AD1B0", VA = "0x1819AE1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte IBJDDDGBPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E23910", Offset = "0x1E22910", VA = "0x181E23910")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2207490", Offset = "0x2206490", VA = "0x182207490", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JAGJONLANJE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA97270", Offset = "0xA96270", VA = "0x180A97270", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x153D6F0", Offset = "0x153C6F0", VA = "0x18153D6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int FPEOFIKEIBM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA87C90", Offset = "0xA86C90", VA = "0x180A87C90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x153CEB0", Offset = "0x153BEB0", VA = "0x18153CEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MIOLICMFAPL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8069D30", Offset = "0x8068D30", VA = "0x188069D30", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8069D50", Offset = "0x8068D50", VA = "0x188069D50")]
		public void COKONPPHPKG(DKDGLPMAAFJ AOHLAGDAFAF, [Out] int MGIGPABOOPI, [Out] int NIBHHMNJPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x806A1B0", Offset = "0x80691B0", VA = "0x18806A1B0")]
		public void OABKNBHDDKD(DKDGLPMAAFJ AOHLAGDAFAF, HDCHBBNKGGO ICGGDIEOBMK, int KKLILJLKIJH = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8069BF0", Offset = "0x8068BF0", VA = "0x188069BF0")]
		public void ADBCHOLNCNC(Mesh BFBFJIKLAEJ, LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8069CA0", Offset = "0x8068CA0", VA = "0x188069CA0")]
		public void AOAHBJIIOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8069FF0", Offset = "0x8068FF0", VA = "0x188069FF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x806A380", Offset = "0x8069380", VA = "0x18806A380")]
		public CJOLMHPILOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds JCENBMMMLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public LHCLBAAEINB.DGMMBDKGOGD DCOLGGBJFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<CJOLMHPILOK> BCHIKIEKFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public KBGMKLLBFHG OFBNGLKLGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer FICFFHNKAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int HCGEHMCFCDI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh FKGCABGKIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OCLBLJBOGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HPDPCCDNHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x80726C0", Offset = "0x80716C0", VA = "0x1880726C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80722F0", Offset = "0x80712F0", VA = "0x1880722F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80722C0", Offset = "0x80712C0", VA = "0x1880722C0")]
	public int CCDKOCGPMBI(int KCOJNHOFGPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8072470", Offset = "0x8071470", VA = "0x188072470")]
	public void EFFOHEHGKNE(CLMJNOLIBKH JFFGCPEJCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8071870", Offset = "0x8070870", VA = "0x188071870")]
	public void AGHCPDBBGPI(Transform EPDEIHIPDLK, bool IAFNELLJNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8072100", Offset = "0x8071100", VA = "0x188072100")]
	public bool BGEMPLPNNML(bool CJJHJBBOOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8072980", Offset = "0x8071980", VA = "0x188072980")]
	public void MNLCJAGPHDB(Transform NKBKNNLLHKF, bool IAFNELLJNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8072710", Offset = "0x8071710", VA = "0x188072710")]
	public bool LKIPLGLLFFP(FIPGENGPGLO LDEFIHHDIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8072FB0", Offset = "0x8071FB0", VA = "0x188072FB0")]
	public IGEPHIMFKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DEDKADADAEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<IGEPHIMFKPA.CJOLMHPILOK> KCCAMBODIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private LBGOLCJACIC FMFFOOPPEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<IGEPHIMFKPA.CJOLMHPILOK> AMCKKPCBEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int IAAKIKCDNJH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x806C3F0", Offset = "0x806B3F0", VA = "0x18806C3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x806C890", Offset = "0x806B890", VA = "0x18806C890")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x806C330", Offset = "0x806B330", VA = "0x18806C330")]
	public void DOPEKGIEJEC(IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI, Transform NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x806C9B0", Offset = "0x806B9B0", VA = "0x18806C9B0")]
	public void LKIPLGLLFFP(IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x806CF30", Offset = "0x806BF30", VA = "0x18806CF30")]
	private IGEPHIMFKPA.CJOLMHPILOK PPMCELELAAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x806C910", Offset = "0x806B910", VA = "0x18806C910")]
	private bool LBNHMHGCJDD(IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x806CB90", Offset = "0x806BB90", VA = "0x18806CB90")]
	private void MFCIJCOAEKP(IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x806C7F0", Offset = "0x806B7F0", VA = "0x18806C7F0")]
	public bool JHICBLJFPKG(IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x806CC40", Offset = "0x806BC40", VA = "0x18806CC40")]
	public bool PHBANHJIEKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x806C820", Offset = "0x806B820", VA = "0x18806C820")]
	private IGEPHIMFKPA.CJOLMHPILOK JHMAAIEGNLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x806C4D0", Offset = "0x806B4D0", VA = "0x18806C4D0")]
	public long HNPPHHCLEPB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x806D070", Offset = "0x806C070", VA = "0x18806D070")]
	public DEDKADADAEG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FNEPOEGCFDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int DDEGCKIHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int AOIJBOOJANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float MFGCGJOFEDN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<IGEPHIMFKPA> GACCKHNMGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x806EBA0", Offset = "0x806DBA0", VA = "0x18806EBA0")]
	public FNEPOEGCFDP(int DDEGCKIHGCG, int AOIJBOOJANL, float LFOODEMNPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x806EAF0", Offset = "0x806DAF0", VA = "0x18806EAF0")]
	public void ONMDBHFPOHE(JDCNGFMMCII CPAGMCDHBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x806E6E0", Offset = "0x806D6E0", VA = "0x18806E6E0")]
	private int LNBMEKFAIFE(CLMJNOLIBKH ABOLKPCCJOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x806E830", Offset = "0x806D830", VA = "0x18806E830")]
	private void ONMDBHFPOHE(CLMJNOLIBKH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x806E790", Offset = "0x806D790", VA = "0x18806E790")]
	private void NCNPHMLPFLE(CLMJNOLIBKH ABOLKPCCJOL, IGEPHIMFKPA IOKCECMBLPL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, FBADAJMIEPD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KCBBAKDBFMJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
			[DebuggerHidden]
			public KCBBAKDBFMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8077050", Offset = "0x8076050", VA = "0x188077050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8077210", Offset = "0x8076210", VA = "0x188077210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8077160", Offset = "0x8076160", VA = "0x188077160", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8077160", Offset = "0x8076160", VA = "0x188077160", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HPDPCCDNHKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x806C2D0", Offset = "0x806B2D0", VA = "0x18806C2D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<AHKIDBJNFLD> PFPEANCJMFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x806C2B0", Offset = "0x806B2B0", VA = "0x18806C2B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> BCHIKIEKFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IGEPHIMFKPA FKGCABGKIOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public JDBPMBDCCCC DOHNPMHIIJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(JDBPMBDCCCC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool MDFPMMJJFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDAD060", Offset = "0xDAC060", VA = "0x180DAD060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x806A790", Offset = "0x8069790", VA = "0x18806A790")]
		public static ClusterMeshRenderer Create(IGEPHIMFKPA BFBFJIKLAEJ, ClusterMeshRenderer BCIHPJDOOEP, MeshFilter HJPNFGOHBCP, MHHODEBGAFD NKBKNNLLHKF, JDBPMBDCCCC CHOCDIANLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x806AA10", Offset = "0x8069A10", VA = "0x18806AA10", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x806B580", Offset = "0x806A580", VA = "0x18806B580", Slot = "9")]
		public bool TryRemoveClusterLODComponent(FIPGENGPGLO LDEFIHHDIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x806B330", Offset = "0x806A330", VA = "0x18806B330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x806AF50", Offset = "0x8069F50", VA = "0x18806AF50")]
		public void Init(IGEPHIMFKPA BFBFJIKLAEJ, MeshFilter HJPNFGOHBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x806AA70", Offset = "0x8069A70", VA = "0x18806AA70")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x806B6B0", Offset = "0x806A6B0", VA = "0x18806B6B0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 GGHGIDAMNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x806B960", Offset = "0x806A960", VA = "0x18806B960", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x806AED0", Offset = "0x8069ED0", VA = "0x18806AED0")]
		[IteratorStateMachine(typeof(KCBBAKDBFMJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x806B3C0", Offset = "0x806A3C0", VA = "0x18806B3C0")]
		public void SetupTagAndLayer(string MIMAHBNFICG, int CHOCDIANLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x806B3A0", Offset = "0x806A3A0", VA = "0x18806B3A0")]
		public bool Remove(FIPGENGPGLO LDEFIHHDIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AJHIBHFKJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int PNCAFJPODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int OBJODNIPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NIBHHMNJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int MGIGPABOOPI;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80695B0", Offset = "0x80685B0", VA = "0x1880695B0")]
	public AJHIBHFKJAE(int OBJODNIPNPB, int NIBHHMNJPCH, int PNCAFJPODGB, int MGIGPABOOPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KBGMKLLBFHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> HHABOHOHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> AKFJAMNGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> GLJEAKCGGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<AJHIBHFKJAE> EPEHPECOJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> GLOMFECPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> IDLPCNIJKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> ACNPLDFOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle BPLCOHHKDGG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BCOFOAOJDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA905D0", Offset = "0xA8F5D0", VA = "0x180A905D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA8FC30", Offset = "0xA8EC30", VA = "0x180A8FC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8076180", Offset = "0x8075180", VA = "0x188076180")]
	public void LMCEEELLBNF(LHCLBAAEINB EKJCIOFNGDE, NativeList<AJHIBHFKJAE> EPEHPECOJOF, float AJNABLFIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8075EC0", Offset = "0x8074EC0", VA = "0x188075EC0")]
	public void FOLLFCIMLPJ(Transform NKBKNNLLHKF, bool IAFNELLJNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8075C10", Offset = "0x8074C10", VA = "0x188075C10")]
	public void BGEMPLPNNML(IGEPHIMFKPA FICFFHNKAMC, bool CJJHJBBOOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8075DB0", Offset = "0x8074DB0", VA = "0x188075DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8076150", Offset = "0x8075150", VA = "0x188076150")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KBGMKLLBFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GLOJDPAEIAN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> HHABOHOHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> AKFJAMNGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<AJHIBHFKJAE> IBPLEHHPMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> GLOMFECPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 POLMDHLPNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> IDLPCNIJKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> ACNPLDFOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool IAFNELLJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float CMCNICHLHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float JCNFPFJFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float JNOEKBKGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> GLJEAKCGGDG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x806F0F0", Offset = "0x806E0F0", VA = "0x18806F0F0")]
	public GLOJDPAEIAN(KBGMKLLBFHG IPLGOPMOFJC, Vector3 POLMDHLPNEH, bool IAFNELLJNML, float CMCNICHLHOP, float JCNFPFJFIDM, float JNOEKBKGCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x806EBF0", Offset = "0x806DBF0", VA = "0x18806EBF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FIPGENGPGLO : OLBDICAPCOC
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds BFEGFMDIKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CLMJNOLIBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<FIPGENGPGLO> DJEGBEIIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public CLMJNOLIBKH EBJBKAEFOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public CLMJNOLIBKH KLDGLJHEIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public CLMJNOLIBKH OACKLCAIBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int MGIGPABOOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds JCENBMMMLDD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x806A4A0", Offset = "0x80694A0", VA = "0x18806A4A0")]
	public CLMJNOLIBKH(List<FIPGENGPGLO> DJEGBEIIOJJ, [Optional] CLMJNOLIBKH EBJBKAEFOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JDCNGFMMCII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<CLMJNOLIBKH> DDAOAAJNAAH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public CLMJNOLIBKH AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8074740", Offset = "0x8073740", VA = "0x188074740")]
	public JDCNGFMMCII(CLMJNOLIBKH NKBKNNLLHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IFHMKGGAAHC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LFENBFFLBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int KBMBIBPMHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int CODMDFLGMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int MBAHPJBCDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int IFGGGDHDKFD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JLPPKBKOCBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int EHAPKLBAJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float DFBBMDNIMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<FIPGENGPGLO> DJEGBEIIOJJ;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8074870", Offset = "0x8073870", VA = "0x188074870", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum CHNBCGIDMLP
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private LFENBFFLBAP HFIOKADHDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int OMHHBBLBAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int DDEGCKIHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int AOIJBOOJANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LFOODEMNPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float ELOFPKFKKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<CLMJNOLIBKH> OKJKAKIFFMK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JDCNGFMMCII OKEGCAKMIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8071810", Offset = "0x8070810", VA = "0x188071810")]
	public IFHMKGGAAHC(int DDEGCKIHGCG, int AOIJBOOJANL, float LFOODEMNPOB, int OMHHBBLBAJO, float ELOFPKFKKFK = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x806F5A0", Offset = "0x806E5A0", VA = "0x18806F5A0")]
	public void BLDMKFOPIIE(List<FIPGENGPGLO> DJEGBEIIOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8070840", Offset = "0x806F840", VA = "0x188070840")]
	public bool DGFFLMAJIDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80717C0", Offset = "0x80707C0", VA = "0x1880717C0")]
	private float IOEJJFLNNIC(Vector3 IEGNAFDKBMI, Vector3 EOMGFLMBKFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x80717A0", Offset = "0x80707A0", VA = "0x1880717A0")]
	private float IOEJJFLNNIC(Vector3 BKLOHAHJLKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8070C70", Offset = "0x806FC70", VA = "0x188070C70")]
	private bool HOCEPINHIFH(CLMJNOLIBKH CMNACPLIDNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x806F7C0", Offset = "0x806E7C0", VA = "0x18806F7C0")]
	private JLPPKBKOCBM CJIHJPDJBDG(List<FIPGENGPGLO> CADKCJICJMI, CHNBCGIDMLP GPAJKDIAEBF)
	{
		return default(JLPPKBKOCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x80708B0", Offset = "0x806F8B0", VA = "0x1880708B0")]
	private void FFJHOLPDJAD(List<FIPGENGPGLO> DJEGBEIIOJJ, NativeArray<Vector3> FCCCCMLIMCK, NativeArray<Vector3> KPJPMLEIDIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class FBMFKHGFHON
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x806E340", Offset = "0x806D340", VA = "0x18806E340")]
	public static Bounds NMADFGEOEEF(List<FIPGENGPGLO> DJEGBEIIOJJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x806E510", Offset = "0x806D510", VA = "0x18806E510")]
	public static int NMILLJNILGJ(List<FIPGENGPGLO> DJEGBEIIOJJ, DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class KJIFINGLCGM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool GNPBPCLKEFA(float4* FCMMMKFGJDB, int FCCMJLNEMIB);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class LBMEILDDFPL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr FCMGCDBJKKE;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr ECLLHLMKGPH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8078EF0", Offset = "0x8077EF0", VA = "0x188078EF0")]
		[BurstDiscard]
		private static void KKANJPNIGKL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8078D90", Offset = "0x8077D90", VA = "0x188078D90")]
		private static IntPtr GJEGJCGINDM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8079020", Offset = "0x8078020", VA = "0x188079020")]
		public static void NMGGAOODKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public static void OCOPJMCPGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8078BA0", Offset = "0x8077BA0", VA = "0x188078BA0")]
		public unsafe static bool BAHFCECOEJD(float4* FCMMMKFGJDB, int FCCMJLNEMIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8077260", Offset = "0x8076260", VA = "0x188077260")]
	[BurstCompile]
	public unsafe static bool JABNNDOKKEN(float4* FCMMMKFGJDB, int FCCMJLNEMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80693C0", Offset = "0x80683C0", VA = "0x1880693C0")]
	[BurstCompile]
	public unsafe static bool BFMFILCBNGK(float4* FCMMMKFGJDB, int FCCMJLNEMIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct EJMBPMMCBCG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> IFPKAHGOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> CPILMACDPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> KNIDFIKFGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> BIMKLIAPIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> NCHLDFHIMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> LMDBPDJJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> AGMGFENCHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> JAOBNBKGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<LHCLBAAEINB.ENDLPDPHNOD> LEPPCADFJEO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x806E2D0", Offset = "0x806D2D0", VA = "0x18806E2D0")]
	public EJMBPMMCBCG(LHCLBAAEINB JFAKCHDNBBH, NativeArray<bool> AGMGFENCHGN, NativeList<ushort> JAOBNBKGHLE, NativeList<LHCLBAAEINB.ENDLPDPHNOD> LEPPCADFJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x806E020", Offset = "0x806D020", VA = "0x18806E020", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct PAOJAKHPNPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> IFPKAHGOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> CPILMACDPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> KNIDFIKFGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> BIMKLIAPIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> NCHLDFHIMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> LMDBPDJJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> JBNMMFBBOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> MKHGLILLCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> BJKGFJJEFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> IFPMBJMPKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> LAPDMIHBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> PFAJDILOANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> AGMGFENCHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> JAOBNBKGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<LHCLBAAEINB.ENDLPDPHNOD> LEPPCADFJEO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x807B830", Offset = "0x807A830", VA = "0x18807B830")]
	public PAOJAKHPNPH(LHCLBAAEINB JFAKCHDNBBH, LHCLBAAEINB MKBMEKFKNJI, NativeArray<bool> AGMGFENCHGN, NativeList<ushort> JAOBNBKGHLE, NativeList<LHCLBAAEINB.ENDLPDPHNOD> LEPPCADFJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x807B360", Offset = "0x807A360", VA = "0x18807B360", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LBGOLCJACIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private LHCLBAAEINB DMPOEPDEDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private LHCLBAAEINB JFAKCHDNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> IOOGEGFNLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> JAOBNBKGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<LHCLBAAEINB.ENDLPDPHNOD> LEPPCADFJEO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static LHCLBAAEINB CGNOJDOAEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private GLBKEMIDCBD GAHDNNFMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private HDCHBBNKGGO ICGGDIEOBMK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BPLCOHHKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IGEPHIMFKPA.CJOLMHPILOK CMNACPLIDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BFFEADGFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26967B0", Offset = "0x26957B0", VA = "0x1826967B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8077480", Offset = "0x8076480", VA = "0x188077480")]
	[BEFBDNPMJDK(ACIAPGFBLAK.EnteredEditMode, 0)]
	private static void BIEAEGCMDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8077EF0", Offset = "0x8076EF0", VA = "0x188077EF0")]
	public void LMCEEELLBNF(IGEPHIMFKPA.CJOLMHPILOK IBPLEHHPMAD, Transform MMDLAMOCPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8077500", Offset = "0x8076500", VA = "0x188077500")]
	public void DJIHIMKFDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8077DE0", Offset = "0x8076DE0", VA = "0x188077DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8077EB0", Offset = "0x8076EB0", VA = "0x188077EB0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8078A30", Offset = "0x8077A30", VA = "0x188078A30")]
	public LBGOLCJACIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FEGIGJBFOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 LJGJIBHPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LHAOGKNJIDI
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(CNPHBADCGMN<string>.FNGDFCAOPOO HHEIAJHNACC, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DKBKNGOOJOH
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKBKNGOOJOH KPEKGMOCBGN(Action DMHPHEGJKMB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DKBKNGOOJOH JEBKIFGDPJK(Action DMHPHEGJKMB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class CBLLMPMPFAK : DKBKNGOOJOH
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class NGKAEFKAGCA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public CBLLMPMPFAK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
				public NGKAEFKAGCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x807B2C0", Offset = "0x807A2C0", VA = "0x18807B2C0")]
				internal void EBKMECALFJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x807B310", Offset = "0x807A310", VA = "0x18807B310")]
				internal void GMPDPMPAPME()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x807B270", Offset = "0x807A270", VA = "0x18807B270")]
				internal void CABFEEAAPHP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> ANFGCHDMBLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action MJGAKBNHCEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action GLEIMHHELOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private DKLJLBNJGOH LCFLANPAHAM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GNFINPBDCCI
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action JAGBBMOHHAM
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x29C1FD0", Offset = "0x29C0FD0", VA = "0x1829C1FD0", Slot = "4")]
			public DKBKNGOOJOH KPEKGMOCBGN(Action DMHPHEGJKMB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x79D9D10", Offset = "0x79D8D10", VA = "0x1879D9D10", Slot = "5")]
			public DKBKNGOOJOH JEBKIFGDPJK(Action DMHPHEGJKMB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
			public CBLLMPMPFAK(Func<JobHandle> DFMDKBHLJLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x80698E0", Offset = "0x80688E0", VA = "0x1880698E0")]
			public void POCKFEEEFFK(Action BGMBGJCBHKD, Action NMGNDFJEFBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8069750", Offset = "0x8068750", VA = "0x188069750")]
			public void LKIPLGLLFFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LDMLFPHKALG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public DKBKNGOOJOH jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public LDMLFPHKALG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x80790D0", Offset = "0x80780D0", VA = "0x1880790D0")]
			internal bool BDMJANCCMFL(CBLLMPMPFAK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class CPHHFFKDCHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public CBLLMPMPFAK newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public CPHHFFKDCHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x806A600", Offset = "0x8069600", VA = "0x18806A600")]
			internal void PDLOMCEIGMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<CBLLMPMPFAK> CFKBJMGEFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<CBLLMPMPFAK> APLFBEBJJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HHGNPNNJJPG MBJKOBGLBNP;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NAPPAGBLGAD HBGJKKBCKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80748D0", Offset = "0x80738D0", VA = "0x1880748D0")]
		public DKBKNGOOJOH Add(Func<JobHandle> DFMDKBHLJLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8074C00", Offset = "0x8073C00", VA = "0x188074C00")]
		public void Remove(DKBKNGOOJOH BPLCOHHKDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8074A20", Offset = "0x8073A20", VA = "0x188074A20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8074DE0", Offset = "0x8073DE0", VA = "0x188074DE0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8075090", Offset = "0x8074090", VA = "0x188075090")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8074BF0", Offset = "0x8073BF0", VA = "0x188074BF0")]
		[CompilerGenerated]
		private void PBCPGNKMMHM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DKLJLBNJGOH
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKLJLBNJGOH KPEKGMOCBGN(Action DMHPHEGJKMB);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DKLJLBNJGOH EMDLCLAPDLB(Action DMHPHEGJKMB);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKLJLBNJGOH JEBKIFGDPJK(Action DMHPHEGJKMB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, BDBAOHOAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class NEDCNLDBOOM : DKLJLBNJGOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle LMOJBIHMGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action MJGAKBNHCEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action KMIOHKFDJPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action JAGBBMOHHAM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool ICOLIBANBIB
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x807B210", Offset = "0x807A210", VA = "0x18807B210")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x78EDD70", Offset = "0x78ECD70", VA = "0x1878EDD70", Slot = "4")]
			public DKLJLBNJGOH KPEKGMOCBGN(Action DMHPHEGJKMB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x78EDD90", Offset = "0x78ECD90", VA = "0x1878EDD90", Slot = "5")]
			public DKLJLBNJGOH EMDLCLAPDLB(Action DMHPHEGJKMB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x79D9D10", Offset = "0x79D8D10", VA = "0x1879D9D10", Slot = "6")]
			public DKLJLBNJGOH JEBKIFGDPJK(Action DMHPHEGJKMB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x10A13E0", Offset = "0x10A03E0", VA = "0x1810A13E0")]
			public NEDCNLDBOOM(JobHandle PGJIAGDLNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x807B1C0", Offset = "0x807A1C0", VA = "0x18807B1C0")]
			public void ECHEACKALCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x807B220", Offset = "0x807A220", VA = "0x18807B220")]
			public void LKIPLGLLFFP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<NEDCNLDBOOM> ACLJNPBDIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> IGFBOPAEDFB;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LIBBMOMCAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x80756D0", Offset = "0x80746D0", VA = "0x1880756D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x164D6E0", Offset = "0x164C6E0", VA = "0x18164D6E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8075170", Offset = "0x8074170", VA = "0x188075170")]
		public DKLJLBNJGOH Add(JobHandle PGJIAGDLNKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8075A30", Offset = "0x8074A30", VA = "0x188075A30")]
		public void Remove(DKLJLBNJGOH BPLCOHHKDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80754F0", Offset = "0x80744F0", VA = "0x1880754F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8075340", Offset = "0x8074340", VA = "0x188075340", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8075270", Offset = "0x8074270", VA = "0x188075270")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8075B30", Offset = "0x8074B30", VA = "0x188075B30")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCB0", Offset = "0xA8CCB0", VA = "0x180A8DCB0", Slot = "6")]
		private bool NGEOPDNHGCK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x807FD20", Offset = "0x807ED20", VA = "0x18807FD20")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
