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
	[CreateAssetMenu]
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
				[Cpp2IlInjected.Address(RVA = "0x43313E0", Offset = "0x43305E0", VA = "0x1843313E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1304AA0", Offset = "0x1303CA0", VA = "0x181304AA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x43313A0", Offset = "0x43305A0", VA = "0x1843313A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4324EB0", Offset = "0x43240B0", VA = "0x184324EB0")]
		public LODSettings NPIAHPPOEPN(PBGEDNJMKOF KJBOHPEHFAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4324EC0", Offset = "0x43240C0", VA = "0x184324EC0")]
		public int OCFKEBCKCJM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4324DB0", Offset = "0x4323FB0", VA = "0x184324DB0")]
		public int IKNHPMFMGLI(bool NNCMFELJFHP, Vector3 ALDNJFIFEGL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4324EE0", Offset = "0x43240E0", VA = "0x184324EE0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OGDJGJKGFAI
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
public interface HOILCCGKDGH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGHPECFEEJG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PLNLPFEJHNN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BJAPFDLBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BFLJBPEICKM> KIJABPCHKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OGDJGJKGFAI HMNGOOJJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool UpdateVisibility();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdateClusterDistances(Vector3 IBDMLEDBMFF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(HCHPPGAPEGB FHHNJKNMCDB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFLJBPEICKM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int MEKLDCAFPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int DBENGIAFECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float AKLHJLJLHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LPBFLKGCMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte CJMEAKGALID
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BNPJAHHOAHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum HCPGEJEKNEL
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LLLGPFHGBHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BNPJAHHOAHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FGDOGDEIJDO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private FGDOGDEIJDO <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x432FC40", Offset = "0x432EE40", VA = "0x18432FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NKJJKMFPEBH : IEnumerator<MFHKIJODCKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MFHKIJODCKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BNPJAHHOAHM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MFHKIJODCKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x604130", Offset = "0x603330", VA = "0x180604130")]
		[DebuggerHidden]
		public NKJJKMFPEBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x43314B0", Offset = "0x43306B0", VA = "0x1843314B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4331570", Offset = "0x4330770", VA = "0x184331570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DPMPLFLFEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BNPJAHHOAHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FGDOGDEIJDO worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private FGDOGDEIJDO <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4326510", Offset = "0x4325710", VA = "0x184326510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OFBOFIPHKHB : IEnumerator<MFHKIJODCKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MFHKIJODCKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BNPJAHHOAHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MFHKIJODCKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x604130", Offset = "0x603330", VA = "0x180604130")]
		[DebuggerHidden]
		public OFBOFIPHKHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4331D80", Offset = "0x4330F80", VA = "0x184331D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4332C60", Offset = "0x4331E60", VA = "0x184332C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int MJOKCNOKPHM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NBHABAENNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer HPFCGGCLMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LCFJCGNNPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject NAFEOFOFGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject FMHCPODPIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OODFCNAOMPC LIJMJLFHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<HCHPPGAPEGB> AKAHHPGHGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<HCHPPGAPEGB> OOPFFIBNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<HCHPPGAPEGB> OOBHBNPHBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int FGIFKKNFKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HCPGEJEKNEL PAPPPOGJBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<PLNLPFEJHNN>[] CKMEHOHPPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BFLJBPEICKM>[] HEDOCJMGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource EMHMPNKBJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HGCHGDKDJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IIPPEJEOHNP GGNLIDGCFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IIPPEJEOHNP GKDMELFHHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int ACFEKJKDIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MKOEOJOKAEH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static BNPJAHHOAHM OMADOFJEDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NMDFCEGFEFB EJLAKINPDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KHFEMDDPLBO KGBADMNAMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour BEBDJPLBKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material AHNJBNAFOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<HOILCCGKDGH> MNFHNAHNDFE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig HCKJAIMLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 OLKDBGKMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12AA680", Offset = "0x12A9880", VA = "0x1812AA680")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12AA5A0", Offset = "0x12A97A0", VA = "0x1812AA5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private HCPGEJEKNEL EOGFBFMMFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61ABB0", Offset = "0x619DB0", VA = "0x18061ABB0")]
		get
		{
			return default(HCPGEJEKNEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4323370", Offset = "0x4322570", VA = "0x184323370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BNPJAHHOAHM JACNMOBBDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4323600", Offset = "0x4322800", VA = "0x184323600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MCPONBMLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4321A60", Offset = "0x4320C60", VA = "0x184321A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CMBEOPNNBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4323BE0", Offset = "0x4322DE0", VA = "0x184323BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> FCCHENDAFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43232D0", Offset = "0x43224D0", VA = "0x1843232D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43236C0", Offset = "0x43228C0", VA = "0x1843236C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LPNLPFOEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43227E0", Offset = "0x43219E0", VA = "0x1843227E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4323E00", Offset = "0x4323000", VA = "0x184323E00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43241C0", Offset = "0x43233C0", VA = "0x1843241C0")]
	public BNPJAHHOAHM(NMDFCEGFEFB EJLAKINPDDE, KHFEMDDPLBO KGBADMNAMPD, ClusterLODConfig IFPHHMPLCAI, MonoBehaviour BEBDJPLBKMJ, Material AHNJBNAFOEH, ClusterMeshRenderer HPFCGGCLMNJ, MeshFilter LCFJCGNNPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4321B80", Offset = "0x4320D80", VA = "0x184321B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4321C80", Offset = "0x4320E80", VA = "0x184321C80")]
	public static void EGOLLDGLMJJ(Vector3 GMMPHCGADLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4322880", Offset = "0x4321A80", VA = "0x184322880")]
	private void IABNKPHBODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4321850", Offset = "0x4320A50", VA = "0x184321850")]
	private void BHPGAMNPEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4323060", Offset = "0x4322260", VA = "0x184323060")]
	private void KBLOHMFJMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4322B70", Offset = "0x4321D70", VA = "0x184322B70")]
	public void JMMHAOODHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4322910", Offset = "0x4321B10", VA = "0x184322910")]
	[AsyncStateMachine(typeof(LLLGPFHGBHJ))]
	public Task IAGLNMGKOGN(FGDOGDEIJDO LILIKHLPHEJ, CancellationToken NDAAKCECFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43219B0", Offset = "0x4320BB0", VA = "0x1843219B0")]
	[IteratorStateMachine(typeof(NKJJKMFPEBH))]
	private IEnumerator<MFHKIJODCKI> CLOKEGDPOGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4323CC0", Offset = "0x4322EC0", VA = "0x184323CC0")]
	[AsyncStateMachine(typeof(DPMPLFLFEBO))]
	private Task NJOHGOFCMGD(FGDOGDEIJDO DGGEFKANDEO, CancellationToken MNPKHBAPNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4321DA0", Offset = "0x4320FA0", VA = "0x184321DA0")]
	public void ELIIIJOCOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4323EE0", Offset = "0x43230E0", VA = "0x184323EE0")]
	public void PCNNGGNOBCH(IEnumerable<PLNLPFEJHNN> IPNFOJGAAIG, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4323760", Offset = "0x4322960", VA = "0x184323760")]
	public void MFCLIDKKOPE(IEnumerable<PLNLPFEJHNN> IPNFOJGAAIG, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4321FB0", Offset = "0x43211B0", VA = "0x184321FB0")]
	public List<ClusterMeshRenderer> EMHJKINGEBC(List<HCHPPGAPEGB> LMBDAHOBFDD, Transform ANEBBMNIFPH, OGDJGJKGFAI EOONLPODBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4322AB0", Offset = "0x4321CB0", VA = "0x184322AB0")]
	public OGDJGJKGFAI JGNCFCBMHKH(Vector3 MBGBNPNCNBF)
	{
		return default(OGDJGJKGFAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4321950", Offset = "0x4320B50", VA = "0x184321950")]
	public void CCJMAFMDOFO(HOILCCGKDGH CEJDFNJDJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x43217F0", Offset = "0x43209F0", VA = "0x1843217F0")]
	public bool AABNALMNKHP(HOILCCGKDGH CEJDFNJDJFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4322A50", Offset = "0x4321C50", VA = "0x184322A50")]
	public void JCDMILPBCCB(HCHPPGAPEGB BFKOJAFKBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4323F60", Offset = "0x4323160", VA = "0x184323F60")]
	public void PGDBONOACGH(BFLJBPEICKM LNOAGBDNLLD, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4322AF0", Offset = "0x4321CF0", VA = "0x184322AF0")]
	public void JKLAKOBGFPB(BFLJBPEICKM LNOAGBDNLLD, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43231A0", Offset = "0x43223A0", VA = "0x1843231A0")]
	private void KEICBFOILED(Vector3 IBDMLEDBMFF, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4323490", Offset = "0x4322690", VA = "0x184323490")]
	private void LIOMLJGJJAL(Vector3 IBDMLEDBMFF, OGDJGJKGFAI EOONLPODBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4322770", Offset = "0x4321970", VA = "0x184322770")]
	[IteratorStateMachine(typeof(OFBOFIPHKHB))]
	private IEnumerator<MFHKIJODCKI> ENMAEEHKNJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4323FE0", Offset = "0x43231E0", VA = "0x184323FE0")]
	private int PLMIPHHAOLM(int PPMIPKENDBN, int IIJPFEONJBC, List<BFLJBPEICKM> CNJHPJABHHI, byte KJBOHPEHFAO, ref int ELCEABGMLKH, float APHHPELIAKJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4323A10", Offset = "0x4322C10", VA = "0x184323A10")]
	public void MNIDDOJOCKH(HCHPPGAPEGB FHHNJKNMCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4321A20", Offset = "0x4320C20", VA = "0x184321A20")]
	public bool DJHHPCCGNMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61F280", Offset = "0x61E480", VA = "0x18061F280")]
	public Material OHEPPNMMHED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4323EA0", Offset = "0x43230A0", VA = "0x184323EA0")]
	public int OCFKEBCKCJM()
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GDKHFEMEBIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> CJLJFKEHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> KEJEAPHCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> EDJFGJAAEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> KDJNFHAJAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> PGEGGPMLALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> APBJAMJPCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> LCKLIHJDLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 NHNEAENLGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float JLJNOMBKDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> BBABOBJICNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> FCCPANMKIJH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43284E0", Offset = "0x43276E0", VA = "0x1843284E0")]
	public GDKHFEMEBIK(JIJPNLMKAPO KEEALIHEENC, NativeList<float3> LCKLIHJDLAL, NativeMultiHashMap<int, int> BBABOBJICNB, NativeArray<int> FCCPANMKIJH, Vector3 NHNEAENLGKJ, float JLJNOMBKDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4327DF0", Offset = "0x4326FF0", VA = "0x184327DF0")]
	private int APABIHJLKCK(float3 IBDMLEDBMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4327E50", Offset = "0x4327050", VA = "0x184327E50")]
	private int BDIJGJPKEJM(int PNNJEJIELDM, int DHDAEDILENC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43280F0", Offset = "0x43272F0", VA = "0x1843280F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NMHKBDJAPFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> BBABOBJICNB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> FCCPANMKIJH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int EPCAGCOFNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> EGHJHGFNFAE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x43315C0", Offset = "0x43307C0", VA = "0x1843315C0")]
	public void DDMDDHBIFIG(int BCCLIJKOJGL, Allocator KLHFPJKGFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4331760", Offset = "0x4330960", VA = "0x184331760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NMHKBDJAPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct ONJBLPJKPJH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> EOOOOFGNPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> OAPCONHBPJB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4332D40", Offset = "0x4331F40", VA = "0x184332D40")]
	public ONJBLPJKPJH(NMHKBDJAPFE EFGELHDPOJF, JIJPNLMKAPO KEEALIHEENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4332CB0", Offset = "0x4331EB0", VA = "0x184332CB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HKGNKAJJOLD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> GNOODBBCAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> LFEPBIGFOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> AHCMGNCDNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> CIBBODFILLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> HLIFDBCBOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> EGHJHGFNFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> EOOOOFGNPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> DJLGFFFECPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> CIKBPHGFFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> OEHJHCCMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> AANOHIKEFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> OGJHBCBONJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> BEJDNGKCHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float MEIGJGFHNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float AONBJCBLFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 BMDENEMNDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LNJIINKKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NMGBIKGCEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float MJFBFKMPHAF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x432AE50", Offset = "0x432A050", VA = "0x18432AE50")]
	public HKGNKAJJOLD(NMHKBDJAPFE AAHIBAGMLEL, JIJPNLMKAPO KEEALIHEENC, JIJPNLMKAPO JHDAFNOOIHG, float NMGBIKGCEFA, float MJFBFKMPHAF, Vector3 BMDENEMNDKH, float LNJIINKKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x432A8A0", Offset = "0x4329AA0", VA = "0x18432A8A0")]
	private float3 IDKJOIEEBNI(int PNNJEJIELDM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x432A940", Offset = "0x4329B40", VA = "0x18432A940")]
	private void IKKAJPACBCP(int PNNJEJIELDM, out float3 MKBGHKNILPM, out float3 MPNCJPBFHDJ, out float4 KKKONPJGELE, out float4 IOHPLBJEAML, out float2 LGIJDKECMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x432AB20", Offset = "0x4329D20", VA = "0x18432AB20")]
	private int KAJHJIDFLPL(int LJKCHBGFCAG, int MCBBCAKOLAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4329AC0", Offset = "0x4328CC0", VA = "0x184329AC0")]
	private void CPJNOGMNMJH(int LJKCHBGFCAG, int MCBBCAKOLAA, int BELKIEODPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4329930", Offset = "0x4328B30", VA = "0x184329930")]
	private bool BMICJJECNOM(int LJKCHBGFCAG, int MCBBCAKOLAA, float FLHPGMHKOML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4329870", Offset = "0x4328A70", VA = "0x184329870")]
	private bool BMCGIGKHEOO(int LJKCHBGFCAG, int MCBBCAKOLAA, int BELKIEODPOC, float FLHPGMHKOML, bool OKKDINBIBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x432A640", Offset = "0x4329840", VA = "0x18432A640")]
	private bool HEOKKEPLPKC(int LJKCHBGFCAG, int MCBBCAKOLAA, int BELKIEODPOC, float FLHPGMHKOML, bool OKKDINBIBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x432A620", Offset = "0x4329820", VA = "0x18432A620")]
	private void GLMEGKNDKIN(int LJKCHBGFCAG, int MCBBCAKOLAA, int BELKIEODPOC, out int KAAENIAOKGE, out int PPNHPKBCFHA, out int AGLAOJGILMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4329CC0", Offset = "0x4328EC0", VA = "0x184329CC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IOPJLPBFCHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ILNOKKENAAG : IDisposable, BFLJBPEICKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds BCLEKFJCDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<HCHPPGAPEGB> LMBDAHOBFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 JJAFBAIMNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 GCMDBBHEBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int BMBNKPJPLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JIJPNLMKAPO OJBELKIAHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NMHKBDJAPFE JAPDJBFEMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform ANEBBMNIFPH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int NAEKDJPMLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x432D320", Offset = "0x432C520", VA = "0x18432D320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh EHOBELJFNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh LLCFIIGODBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5730E0", VA = "0x180573EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5CC180", Offset = "0x5CB380", VA = "0x1805CC180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float AKLHJLJLHFP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9006E0", Offset = "0x8FF8E0", VA = "0x1809006E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1996740", Offset = "0x1995940", VA = "0x181996740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte CJMEAKGALID
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F7290", Offset = "0x9F6490", VA = "0x1809F7290")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAB0710", Offset = "0xAAF910", VA = "0x180AB0710", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MEKLDCAFPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x620250", Offset = "0x61F450", VA = "0x180620250", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x620260", Offset = "0x61F460", VA = "0x180620260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int DBENGIAFECH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x943670", Offset = "0x942870", VA = "0x180943670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8A7AC0", Offset = "0x8A6CC0", VA = "0x1808A7AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LPBFLKGCMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x432D300", Offset = "0x432C500", VA = "0x18432D300", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x432D0D0", Offset = "0x432C2D0", VA = "0x18432D0D0")]
		public void EHODNOIFJAP(PBGEDNJMKOF KJBOHPEHFAO, out int FMMFPMJDILD, out int DNPNOADIHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x432D360", Offset = "0x432C560", VA = "0x18432D360")]
		public void LHBGPAFHPCB(PBGEDNJMKOF KJBOHPEHFAO, EPNNHLNNDFC PGKCJGMOFLI, int BLNCMLJMMFI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x432CBC0", Offset = "0x432BDC0", VA = "0x18432CBC0")]
		public void BMAHGAIKCFD(NativeList<CHELLBJHOJL> BKGELAEALIK, Transform HFKKGEEKCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x432D5A0", Offset = "0x432C7A0", VA = "0x18432D5A0")]
		public void PMIMOPLKEML(Mesh KEEALIHEENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x432D500", Offset = "0x432C700", VA = "0x18432D500")]
		public void LPLKGGPFKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x432CEE0", Offset = "0x432C0E0", VA = "0x18432CEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x432D640", Offset = "0x432C840", VA = "0x18432D640")]
		public ILNOKKENAAG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds BCLEKFJCDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<ILNOKKENAAG> MGDJHAGCHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public HBNMINJJHCC EGEJNIFOFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer LJMJEKEAKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int BPGMAMHJLOK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh PJBDPMFFIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1E0", Offset = "0x5CB3E0", VA = "0x1805CC1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DHPHKBIMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62BE80", Offset = "0x62B080", VA = "0x18062BE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62BF00", Offset = "0x62B100", VA = "0x18062BF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BJAPFDLBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x432E2C0", Offset = "0x432D4C0", VA = "0x18432E2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x432E310", Offset = "0x432D510", VA = "0x18432E310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x432E620", Offset = "0x432D820", VA = "0x18432E620")]
	public int HGDBAGJDAED(int NCAIFCNKGDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x432E650", Offset = "0x432D850", VA = "0x18432E650")]
	public void INHKBPNLDNJ(OPIOJGNDBKM NCELGHFCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x432D700", Offset = "0x432C900", VA = "0x18432D700")]
	public void CEAHCOAKEGB(Transform HFKKGEEKCDL, bool OCCOGIIKIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x432E470", Offset = "0x432D670", VA = "0x18432E470")]
	public bool GLGHEKFCING(bool NNLGICFFOJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x432DE60", Offset = "0x432D060", VA = "0x18432DE60")]
	public void CGIBBEPIOLP(Transform ANEBBMNIFPH, bool OCCOGIIKIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x432E7E0", Offset = "0x432D9E0", VA = "0x18432E7E0")]
	public bool MNIDDOJOCKH(HCHPPGAPEGB FHHNJKNMCDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x432EA60", Offset = "0x432DC60", VA = "0x18432EA60")]
	public IOPJLPBFCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OODFCNAOMPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<IOPJLPBFCHB.ILNOKKENAAG> GNMABGCGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private LLOBINIEKEE EMKICNIEONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<IOPJLPBFCHB.ILNOKKENAAG> JJIEJGCLDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int GHLMDFKFOGO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4333080", Offset = "0x4332280", VA = "0x184333080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4333000", Offset = "0x4332200", VA = "0x184333000")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4333150", Offset = "0x4332350", VA = "0x184333150")]
	public void INLOBDHPAIC(IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP, Transform ANEBBMNIFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4333330", Offset = "0x4332530", VA = "0x184333330")]
	public void MNIDDOJOCKH(IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x43334E0", Offset = "0x43326E0", VA = "0x1843334E0")]
	private IOPJLPBFCHB.ILNOKKENAAG ONCGDBAFMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x43332A0", Offset = "0x43324A0", VA = "0x1843332A0")]
	private bool MKMFDHIHGIK(IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x43330F0", Offset = "0x43322F0", VA = "0x1843330F0")]
	private void EFDMEGENJBD(IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4333260", Offset = "0x4332460", VA = "0x184333260")]
	public bool MKHHJCBNODB(IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4332D70", Offset = "0x4331F70", VA = "0x184332D70")]
	public bool BOOBIECFMHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4333200", Offset = "0x4332400", VA = "0x184333200")]
	private IOPJLPBFCHB.ILNOKKENAAG JAMIENAHDHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4333610", Offset = "0x4332810", VA = "0x184333610")]
	public OODFCNAOMPC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CLPBJKNMPMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int BPEHKAGAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HEHDGAGJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float KEECAOFPIIP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<IOPJLPBFCHB> JOEDCCOOHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4324D60", Offset = "0x4323F60", VA = "0x184324D60")]
	public CLPBJKNMPMO(int BPEHKAGAKAM, int HEHDGAGJNGF, float GCJHPFLAPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4324810", Offset = "0x4323A10", VA = "0x184324810")]
	public void HKEDJEIOEIA(IPNAIMACHKC BKLMOMHLNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4324CC0", Offset = "0x4323EC0", VA = "0x184324CC0")]
	private int MEBCHLEOBML(OPIOJGNDBKM MBNJFBIGPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x43248B0", Offset = "0x4323AB0", VA = "0x1843248B0")]
	private void HKEDJEIOEIA(OPIOJGNDBKM MBNJFBIGPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4324AE0", Offset = "0x4323CE0", VA = "0x184324AE0")]
	private void KHHJEFJEIPM(OPIOJGNDBKM MBNJFBIGPPP, IOPJLPBFCHB CPLCAHKHDCI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PLNLPFEJHNN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DLLKJIJOLHK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
			[DebuggerHidden]
			public DLLKJIJOLHK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4326330", Offset = "0x4325530", VA = "0x184326330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x43264C0", Offset = "0x43256C0", VA = "0x1843264C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x4326420", Offset = "0x4325620", VA = "0x184326420", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x4326420", Offset = "0x4325620", VA = "0x184326420", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BJAPFDLBDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x43262D0", Offset = "0x43254D0", VA = "0x1843262D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<BFLJBPEICKM> KIJABPCHKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x43262B0", Offset = "0x43254B0", VA = "0x1843262B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> MGDJHAGCHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IOPJLPBFCHB PJBDPMFFIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OGDJGJKGFAI HMNGOOJJGGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5771F0", Offset = "0x5763F0", VA = "0x1805771F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(OGDJGJKGFAI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x67B390", Offset = "0x67A590", VA = "0x18067B390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BEPNJCJGCKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x43262C0", Offset = "0x43254C0", VA = "0x1843262C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4324F40", Offset = "0x4324140", VA = "0x184324F40")]
		public static ClusterMeshRenderer Create(IOPJLPBFCHB KEEALIHEENC, ClusterMeshRenderer HPFCGGCLMNJ, MeshFilter LCFJCGNNPOB, Transform ANEBBMNIFPH, OGDJGJKGFAI EOONLPODBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x43250A0", Offset = "0x43242A0", VA = "0x1843250A0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4325820", Offset = "0x4324A20", VA = "0x184325820", Slot = "10")]
		public bool TryRemoveClusterLODComponent(HCHPPGAPEGB FHHNJKNMCDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x43255F0", Offset = "0x43247F0", VA = "0x1843255F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4325300", Offset = "0x4324500", VA = "0x184325300")]
		public void Init(IOPJLPBFCHB KEEALIHEENC, MeshFilter LCFJCGNNPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4325100", Offset = "0x4324300", VA = "0x184325100")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4325950", Offset = "0x4324B50", VA = "0x184325950", Slot = "8")]
		public void UpdateClusterDistances(Vector3 IBDMLEDBMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4325B90", Offset = "0x4324D90", VA = "0x184325B90", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4325290", Offset = "0x4324490", VA = "0x184325290")]
		[IteratorStateMachine(typeof(DLLKJIJOLHK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4325670", Offset = "0x4324870", VA = "0x184325670")]
		public void SetupTagAndLayer(string DLGIKKGKEIM, int EOONLPODBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4325650", Offset = "0x4324850", VA = "0x184325650")]
		public bool Remove(HCHPPGAPEGB FHHNJKNMCDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NCECPPIGJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int JALFBAPPKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int IMDJFDAAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int DNPNOADIHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FMMFPMJDILD;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4331490", Offset = "0x4330690", VA = "0x184331490")]
	public NCECPPIGJBG(int IMDJFDAAEMG, int DNPNOADIHNI, int JALFBAPPKMI, int FMMFPMJDILD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HBNMINJJHCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> CJLJFKEHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> EGHJHGFNFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> APBJAMJPCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<NCECPPIGJBG> JPPOGLLGJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> HEILEEJAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> HNGFGEOFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> LOMGFPEHEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle LBNFEJMHBJC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ENMDGIKBJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x612470", Offset = "0x611670", VA = "0x180612470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x612490", Offset = "0x611690", VA = "0x180612490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4328AF0", Offset = "0x4327CF0", VA = "0x184328AF0")]
	public void INFCCIABEPI(JIJPNLMKAPO DDFHNGJFDND, NativeList<NCECPPIGJBG> JPPOGLLGJBL, float LHOCEIFAEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x43285A0", Offset = "0x43277A0", VA = "0x1843285A0")]
	public void CDNPGNKBFMD(Transform ANEBBMNIFPH, bool OCCOGIIKIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4328960", Offset = "0x4327B60", VA = "0x184328960")]
	public void GLGHEKFCING(IOPJLPBFCHB LJMJEKEAKDO, bool NNLGICFFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4328890", Offset = "0x4327A90", VA = "0x184328890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4328860", Offset = "0x4327A60", VA = "0x184328860")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HBNMINJJHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct NMOGAMILIIB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> CJLJFKEHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> EGHJHGFNFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<NCECPPIGJBG> IOCIDCMAAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> HEILEEJAKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 BMDENEMNDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> HNGFGEOFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> LOMGFPEHEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool OCCOGIIKIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float PCKMDEGKIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float DKHBFFFBGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float OJBMACDAHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> APBJAMJPCKC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4331CB0", Offset = "0x4330EB0", VA = "0x184331CB0")]
	public NMOGAMILIIB(HBNMINJJHCC FOAHNDHLODH, Vector3 BMDENEMNDKH, bool OCCOGIIKIGL, float PCKMDEGKIDO, float DKHBFFFBGOJ, float OJBMACDAHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4331810", Offset = "0x4330A10", VA = "0x184331810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HCHPPGAPEGB : BHABHNKEKAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds CMJMPMLHNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CHELLBJHOJL HLNKLJLIFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OPIOJGNDBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<HCHPPGAPEGB> LMBDAHOBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public OPIOJGNDBKM KJHHLEFOCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public OPIOJGNDBKM ODGOGAAPPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public OPIOJGNDBKM KNHCNMHOFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int FMMFPMJDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds BCLEKFJCDOH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4333750", Offset = "0x4332950", VA = "0x184333750")]
	public OPIOJGNDBKM(List<HCHPPGAPEGB> LMBDAHOBFDD, [Optional] OPIOJGNDBKM KJHHLEFOCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IPNAIMACHKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<OPIOJGNDBKM> MCCEBHFODHO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OPIOJGNDBKM GHEDAMOCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x432EB00", Offset = "0x432DD00", VA = "0x18432EB00")]
	public IPNAIMACHKC(OPIOJGNDBKM ANEBBMNIFPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IFOGCGNICLL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PEKGOOHPKBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int JCPMFPAIMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int CNBJDNHMMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JNPPPGAKGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int DPPBPBBKKCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct CIIJCHOKHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OPHAFGODFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float FJFHKPECBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<HCHPPGAPEGB> LMBDAHOBFDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum FKEGGHBPMOF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PEKGOOHPKBO MLEKNIFPLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int MIKFJCBBDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int BPEHKAGAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int HEHDGAGJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GCJHPFLAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float NKEFEAHCJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<OPIOJGNDBKM> FFJMINNNFJF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IPNAIMACHKC BFIBLCFFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x432CB60", Offset = "0x432BD60", VA = "0x18432CB60")]
	public IFOGCGNICLL(int BPEHKAGAKAM, int HEHDGAGJNGF, float GCJHPFLAPLG, int MIKFJCBBDMJ, float NKEFEAHCJDC = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x432B320", Offset = "0x432A520", VA = "0x18432B320")]
	public void FJCAAGBKIHI(List<HCHPPGAPEGB> LMBDAHOBFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x432C940", Offset = "0x432BB40", VA = "0x18432C940")]
	public bool JIDBPAIMOOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x432C9B0", Offset = "0x432BBB0", VA = "0x18432C9B0")]
	private float PHFBANBNMPP(Vector3 JICFKFFBMOO, Vector3 KDCMKKCANAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x432CAC0", Offset = "0x432BCC0", VA = "0x18432CAC0")]
	private float PHFBANBNMPP(Vector3 GKFHLIDAILA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x432B4E0", Offset = "0x432A6E0", VA = "0x18432B4E0")]
	private bool GBPDOHEGBKN(OPIOJGNDBKM CLFFPFAGINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x432BDF0", Offset = "0x432AFF0", VA = "0x18432BDF0")]
	private CIIJCHOKHDJ IFJCFNOEEEC(List<HCHPPGAPEGB> PLJBCBGDLFK, FKEGGHBPMOF JIGBOKACLPF)
	{
		return default(CIIJCHOKHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x432AF90", Offset = "0x432A190", VA = "0x18432AF90")]
	private void ECAGFDFNNMH(List<HCHPPGAPEGB> LMBDAHOBFDD, Vector3[] BHABBCBMAPJ, Vector3[] IKABMCGLHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JHLPFDKEPCM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x432EC10", Offset = "0x432DE10", VA = "0x18432EC10")]
	public static Bounds BAAKBJMAPAJ(List<HCHPPGAPEGB> LMBDAHOBFDD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x432EDC0", Offset = "0x432DFC0", VA = "0x18432EDC0")]
	public static int EMMEHAOIPHD(List<HCHPPGAPEGB> LMBDAHOBFDD, PBGEDNJMKOF KJBOHPEHFAO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LLOBINIEKEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private JIJPNLMKAPO HCMNBFKNLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JIJPNLMKAPO FDAILFFIOLA;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static JIJPNLMKAPO FPNLBLGHEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MOAIHFLEJOJ IPELGPNEJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private EPNNHLNNDFC PGKCJGMOFLI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle LBNFEJMHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6457F0", Offset = "0x6449F0", VA = "0x1806457F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x645810", Offset = "0x644A10", VA = "0x180645810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IOPJLPBFCHB.ILNOKKENAAG CLFFPFAGINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NOABHLCPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x15F9E40", Offset = "0x15F9040", VA = "0x1815F9E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x43312A0", Offset = "0x43304A0", VA = "0x1843312A0")]
	[BBOEJKMFFAE(MBFFABDPJEM.ExitingPlayMode, 0)]
	private void PDMFAGIDEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4330270", Offset = "0x432F470", VA = "0x184330270")]
	public void INFCCIABEPI(IOPJLPBFCHB.ILNOKKENAAG IOCIDCMAAHD, Transform BIGFKPHCEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4330C90", Offset = "0x432FE90", VA = "0x184330C90")]
	public void KHCGEFLIOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4330200", Offset = "0x432F400", VA = "0x184330200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x43301C0", Offset = "0x432F3C0", VA = "0x1843301C0")]
	public void DHEPINIAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4331310", Offset = "0x4330510", VA = "0x184331310")]
	public LLOBINIEKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CFPOGBIOILG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BNPJAHHOAHM PJIJJCOCLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KHFEMDDPLBO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 NDAEKCLLPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NMDFCEGFEFB
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(FGDOGDEIJDO DGGEFKANDEO, CancellationToken MNPKHBAPNDC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HFAGHFKNPOC
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HFAGHFKNPOC AEJKELDNFGH(Action DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HFAGHFKNPOC PIGMLKNNDIJ(Action DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HFAGHFKNPOC LLPIGJHJFJB(Action DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HFAGHFKNPOC PHKCCBFJNAP(Action DINDBGHHKFD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class PIMDBMHCGGJ : HFAGHFKNPOC
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KIDCOBEMPGC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public PIMDBMHCGGJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
				public KIDCOBEMPGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x432FB60", Offset = "0x432ED60", VA = "0x18432FB60")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x432FBB0", Offset = "0x432EDB0", VA = "0x18432FBB0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x432FC00", Offset = "0x432EE00", VA = "0x18432FC00")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> MDBKAPKOFGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action DGBJPAOKLHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action MPCAKLMHJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private IELMKEAOKAJ DJAOIHPPOGN;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AGMBEPIPICC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x5CC1E0", Offset = "0x5CB3E0", VA = "0x1805CC1E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NHKDEPMLCFL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2279750", Offset = "0x2278950", VA = "0x182279750", Slot = "4")]
			public HFAGHFKNPOC AEJKELDNFGH(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1A08B40", Offset = "0x1A07D40", VA = "0x181A08B40", Slot = "5")]
			public HFAGHFKNPOC PIGMLKNNDIJ(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1DE8AD0", Offset = "0x1DE7CD0", VA = "0x181DE8AD0", Slot = "6")]
			public HFAGHFKNPOC LLPIGJHJFJB(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x23E4C80", Offset = "0x23E3E80", VA = "0x1823E4C80", Slot = "7")]
			public HFAGHFKNPOC PHKCCBFJNAP(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5D4B50", Offset = "0x5D3D50", VA = "0x1805D4B50")]
			public PIMDBMHCGGJ(Func<JobHandle> POEIFJJKODM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x43337D0", Offset = "0x43329D0", VA = "0x1843337D0")]
			public void KIALENPBJIJ(Action ODPDMMLIOHJ, Action PDFANPIANBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4333A00", Offset = "0x4332C00", VA = "0x184333A00")]
			public void MNIDDOJOCKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FPJHFJDHMBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public HFAGHFKNPOC jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public FPJHFJDHMBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4327DE0", Offset = "0x4326FE0", VA = "0x184327DE0")]
			internal bool <Remove>b__0(PIMDBMHCGGJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JAMIBIHCIIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public PIMDBMHCGGJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public JAMIBIHCIIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x432EBB0", Offset = "0x432DDB0", VA = "0x18432EBB0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<PIMDBMHCGGJ> HHOHBIPPDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<PIMDBMHCGGJ> KKOLCGAPGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private IIPPEJEOHNP BEAPLCGGHON;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public LCNPDFNFBJA LMHHEENHINO
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x432EF50", Offset = "0x432E150", VA = "0x18432EF50")]
		public HFAGHFKNPOC Add(Func<JobHandle> POEIFJJKODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x432F1F0", Offset = "0x432E3F0", VA = "0x18432F1F0")]
		public void Remove(HFAGHFKNPOC LBNFEJMHBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x432F070", Offset = "0x432E270", VA = "0x18432F070", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x432F370", Offset = "0x432E570", VA = "0x18432F370")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x432F540", Offset = "0x432E740", VA = "0x18432F540")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x432F060", Offset = "0x432E260", VA = "0x18432F060")]
		[CompilerGenerated]
		private void HGHJEPDAMBO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IELMKEAOKAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IELMKEAOKAJ AEJKELDNFGH(Action DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IELMKEAOKAJ CLKHNKOMEEF(Action DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IELMKEAOKAJ PHKCCBFJNAP(Action DINDBGHHKFD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LPBLHLAGELP : IELMKEAOKAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle LKJPCFCMBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action DGBJPAOKLHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action HBKBKMGHFBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action NHKDEPMLCFL;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool KKJDEHIOIKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x4331400", Offset = "0x4330600", VA = "0x184331400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1A08B40", Offset = "0x1A07D40", VA = "0x181A08B40", Slot = "4")]
			public IELMKEAOKAJ AEJKELDNFGH(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1DE8AD0", Offset = "0x1DE7CD0", VA = "0x181DE8AD0", Slot = "5")]
			public IELMKEAOKAJ CLKHNKOMEEF(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x23E4C80", Offset = "0x23E3E80", VA = "0x1823E4C80", Slot = "6")]
			public IELMKEAOKAJ PHKCCBFJNAP(Action DINDBGHHKFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x81C220", Offset = "0x81B420", VA = "0x18081C220")]
			public LPBLHLAGELP(JobHandle BALDDMHFJMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4331410", Offset = "0x4330610", VA = "0x184331410")]
			public void BPHKGBFPAIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4331450", Offset = "0x4330650", VA = "0x184331450")]
			public void MNIDDOJOCKH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<LPBLHLAGELP> CJDDJHFHNKC;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x432F9C0", Offset = "0x432EBC0", VA = "0x18432F9C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x432F600", Offset = "0x432E800", VA = "0x18432F600")]
		public IELMKEAOKAJ Add(JobHandle BALDDMHFJMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x432F8D0", Offset = "0x432EAD0", VA = "0x18432F8D0")]
		public void Remove(IELMKEAOKAJ LBNFEJMHBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x432F770", Offset = "0x432E970", VA = "0x18432F770", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x432F690", Offset = "0x432E890", VA = "0x18432F690")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x432FAD0", Offset = "0x432ECD0", VA = "0x18432FAD0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x43277F0", Offset = "0x43269F0", VA = "0x1843277F0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x43278F0", Offset = "0x4326AF0", VA = "0x1843278F0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
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
