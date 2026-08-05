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
				[Cpp2IlInjected.Address(RVA = "0x82933D0", Offset = "0x82921D0", VA = "0x1882933D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF17B70", Offset = "0xF16970", VA = "0x180F17B70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8293390", Offset = "0x8292190", VA = "0x188293390")]
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
		[Cpp2IlInjected.Address(RVA = "0x8283000", Offset = "0x8281E00", VA = "0x188283000")]
		public LODSettings POMAJOFFPPA(GJNDJKNGBFN GOLHBMLDEPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8282FE0", Offset = "0x8281DE0", VA = "0x188282FE0")]
		public int NHDEBHACHCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8282F40", Offset = "0x8281D40", VA = "0x188282F40")]
		public int AIANEPCPCHP(bool HDBOBEJPMJK, Vector3 PEGONFHICLE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8283010", Offset = "0x8281E10", VA = "0x188283010")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LIILGEJCGAD
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
public interface GKBNJAPIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGOIFPONFFP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMBGBENDIGL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HAADIFLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IHDLDGPOFHF> KDIOPMPGABP
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
	void UpdateClusterDistances(Vector3 EEIHHMMODIJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(MHIIGIDBEIK PGJHFGMMOON);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IHDLDGPOFHF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int PAHFCADBEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HNAMCMGCIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float EALJFAMGJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float AEBIHGDLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte AKAMGECAIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KAFIMFFHLPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GBHAPNKBEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FNBDHJOBOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KAFIMFFHLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82889E0", Offset = "0x82877E0", VA = "0x1882889E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8289170", Offset = "0x8287F70", VA = "0x188289170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GBFFCKBNPHC : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public KAFIMFFHLPM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public GBFFCKBNPHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82897A0", Offset = "0x82885A0", VA = "0x1882897A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8289A10", Offset = "0x8288810", VA = "0x188289A10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GDEBMLDDPKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KAFIMFFHLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8289A60", Offset = "0x8288860", VA = "0x188289A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x828B370", Offset = "0x828A170", VA = "0x18828B370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HEIPJGGMNIB : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KAFIMFFHLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public HEIPJGGMNIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x828B4D0", Offset = "0x828A2D0", VA = "0x18828B4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x828C1F0", Offset = "0x828AFF0", VA = "0x18828C1F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int LINOIKCHDKC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan GFNBGIJACHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer PDJENLHKLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter DIGOIGMODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject MHOCMPCAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject FFPIEEKEJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NPGCAHLDBEA NDMHPHIIEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<MHIIGIDBEIK> CBDIBELEBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<MHIIGIDBEIK> MFMPOFIHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<MHIIGIDBEIK> FLMICOHGLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int AKMJFFCLEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double POAOICHMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long BFKOPLFMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private long MAHDLGCGNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long LJAJMEJECKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long BAPMIHPJKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GBHAPNKBEGJ HIOLNIBEABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<MMBGBENDIGL>[] FCPMPBHPKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<IHDLDGPOFHF>[] PKHPOOAHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CancellationTokenSource FEHHENDLMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool EPONCGAGNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private GMJHELKMAKL OJPMDGLMINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GMJHELKMAKL ELHMPMJIDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int GCMFCCENMGD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static KAFIMFFHLPM IBKIAAFDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DDKGICJFACC PFGJLGGGLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KLOJBPDFHLM EMKOFOFPDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MonoBehaviour HOIGNIDNGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material AODLMFBHEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private List<Material> HMMLAPDLCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Material KPDHAMKFOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<Material> CDFLNKNBGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool HEHHELMBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly List<GKBNJAPIBHJ> NEDNLJHJHED;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig NCGJILFJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 NLPOHFNALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8013150", Offset = "0x8011F50", VA = "0x188013150")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8013250", Offset = "0x8012050", VA = "0x188013250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GBHAPNKBEGJ IIGHLFPPPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2F79FD0", Offset = "0x2F78DD0", VA = "0x182F79FD0")]
		get
		{
			return default(GBHAPNKBEGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8290ED0", Offset = "0x828FCD0", VA = "0x188290ED0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KAFIMFFHLPM MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8290E80", Offset = "0x828FC80", VA = "0x188290E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BPLMJKFMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x828E7A0", Offset = "0x828D5A0", VA = "0x18828E7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KJMNKKGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x828F820", Offset = "0x828E620", VA = "0x18828F820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> CIBIKHBGHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x828E080", Offset = "0x828CE80", VA = "0x18828E080")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x828F8E0", Offset = "0x828E6E0", VA = "0x18828F8E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IMCMBODBGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8290380", Offset = "0x828F180", VA = "0x188290380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x828EE20", Offset = "0x828DC20", VA = "0x18828EE20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8291080", Offset = "0x828FE80", VA = "0x188291080")]
	public KAFIMFFHLPM(DDKGICJFACC PFGJLGGGLAF, KLOJBPDFHLM EMKOFOFPDMJ, ClusterLODConfig FKLIOIBLCMG, MonoBehaviour HOIGNIDNGLL, Material LJCOHGOGAKJ, ClusterMeshRenderer PDJENLHKLEN, MeshFilter DIGOIGMODPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x828EBF0", Offset = "0x828D9F0", VA = "0x18828EBF0")]
	private void FCIPBKCGNJM(Material LJCOHGOGAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x828F9A0", Offset = "0x828E7A0", VA = "0x18828F9A0")]
	public void HJHPDJELPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8290750", Offset = "0x828F550", VA = "0x188290750")]
	public void LJJFLOIJANC(Action<Material> GACEKADOLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x828EED0", Offset = "0x828DCD0", VA = "0x18828EED0")]
	public static PGFPLDMFONK.JIAIGLHGEAK FJCGFDCMNPI(PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF)
	{
		return default(PGFPLDMFONK.JIAIGLHGEAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x828E260", Offset = "0x828D060", VA = "0x18828E260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x828EEF0", Offset = "0x828DCF0", VA = "0x18828EEF0")]
	public static void FKDBPCPPPFM(Vector3 BHAIJDDPNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8290B90", Offset = "0x828F990", VA = "0x188290B90")]
	private void MMIFJGBNJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8290880", Offset = "0x828F680", VA = "0x188290880")]
	private void LLMADKDLKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x828FAD0", Offset = "0x828E8D0", VA = "0x18828FAD0")]
	private void HLFIMOPGPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x828EFF0", Offset = "0x828DDF0", VA = "0x18828EFF0")]
	public void FLMLHMFBCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x828DB80", Offset = "0x828C980", VA = "0x18828DB80")]
	[AsyncStateMachine(typeof(FNBDHJOBOBC))]
	public Task BNCFPLMIMFM(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8290950", Offset = "0x828F750", VA = "0x188290950")]
	[IteratorStateMachine(typeof(GBFFCKBNPHC))]
	private IEnumerator<PHFDFIIIMCE> LMPEODNDANA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x828E140", Offset = "0x828CF40", VA = "0x18828E140")]
	[AsyncStateMachine(typeof(GDEBMLDDPKI))]
	private Task DLFKGJLINJB(GMHMEBHNAOE<string>.HGELJMPBEBF BOHPCGDPMOD, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82904C0", Offset = "0x828F2C0", VA = "0x1882904C0")]
	public void KOOLHEKMMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82906D0", Offset = "0x828F4D0", VA = "0x1882906D0")]
	public void LIIJAJEGDPP(IEnumerable<MMBGBENDIGL> IBFNHPKBOAM, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x828E8F0", Offset = "0x828D6F0", VA = "0x18828E8F0")]
	public void FADOOMBAPAB(IEnumerable<MMBGBENDIGL> IBFNHPKBOAM, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x828FC20", Offset = "0x828EA20", VA = "0x18828FC20")]
	public List<ClusterMeshRenderer> IBFPMKBAPND(List<MHIIGIDBEIK> MLDOKIPONMG, FHLDPOMNGOB MMENCBNBOBJ, LIILGEJCGAD OGEICBNAJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x828E890", Offset = "0x828D690", VA = "0x18828E890")]
	public void EPLOCHAIMCA(GKBNJAPIBHJ FOOOLEHKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x828F7C0", Offset = "0x828E5C0", VA = "0x18828F7C0")]
	public bool GIDHFJCJOKI(GKBNJAPIBHJ FOOOLEHKOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8290C20", Offset = "0x828FA20", VA = "0x188290C20")]
	public void NECPDBJIIMA(MHIIGIDBEIK CCPPBPANHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x828ED60", Offset = "0x828DB60", VA = "0x18828ED60")]
	public void FCPIEFKEEED(IHDLDGPOFHF NLCAIENELJM, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8290300", Offset = "0x828F100", VA = "0x188290300")]
	public void IEKNHBFKKCO(IHDLDGPOFHF NLCAIENELJM, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8290D40", Offset = "0x828FB40", VA = "0x188290D40")]
	private void OHOMCGLOHEI(Vector3 EEIHHMMODIJ, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x828E630", Offset = "0x828D430", VA = "0x18828E630")]
	private void EBGNFHGCCPF(Vector3 EEIHHMMODIJ, LIILGEJCGAD OGEICBNAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8290CC0", Offset = "0x828FAC0", VA = "0x188290CC0")]
	[IteratorStateMachine(typeof(HEIPJGGMNIB))]
	private IEnumerator<PHFDFIIIMCE> ODEBLFGJFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x828F650", Offset = "0x828E450", VA = "0x18828F650")]
	private int GGMNOEMJBDI(int JJJJBEGKNIN, int IOEIIDAIPLD, List<IHDLDGPOFHF> JFDIAOGLMHH, byte GOLHBMLDEPN, int MBBJBJHKEAC, float OMGAJGPNHAC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82909D0", Offset = "0x828F7D0", VA = "0x1882909D0")]
	public void MDNHCHGJFLC(MHIIGIDBEIK PGJHFGMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x828EDE0", Offset = "0x828DBE0", VA = "0x18828EDE0")]
	public bool FFLKFEFPOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x180B21D60")]
	public Material HJIMJAHAJPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x828FA40", Offset = "0x828E840", VA = "0x18828FA40")]
	public Material HJIMJAHAJPD(PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x180B23880")]
	public Material KHOFBJJNOBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8290430", Offset = "0x828F230", VA = "0x188290430")]
	public Material KHOFBJJNOBP(PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8290C80", Offset = "0x828FA80", VA = "0x188290C80")]
	public int NHDEBHACHCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x828DCA0", Offset = "0x828CAA0", VA = "0x18828DCA0")]
	public (long, int) CIDIHIFJPAL()
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
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BDLPLFAKDKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<float3> HLIMDLBHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float3> CAAODMLAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<float4> OLJEKNPJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<float2> ACDIGENOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<float4> ONKOAOCBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<int> NCGAAPLMBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeList<float3> MJOCNIAGKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private float3 IEOGKKOBCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private float KJHDMKNJKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeParallelMultiHashMap<int, int> PLCOBOBJDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> BKJADAAGDHL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82815A0", Offset = "0x82803A0", VA = "0x1882815A0")]
	public BDLPLFAKDKM(PGFPLDMFONK PKBJPDPONKJ, NativeList<float3> MJOCNIAGKIH, NativeParallelMultiHashMap<int, int> PLCOBOBJDND, NativeArray<int> BKJADAAGDHL, Vector3 IEOGKKOBCGG, float KJHDMKNJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8280EA0", Offset = "0x827FCA0", VA = "0x188280EA0")]
	private int EBPOMAFACFJ(float3 EEIHHMMODIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8281330", Offset = "0x8280130", VA = "0x188281330")]
	private int MCCOAOMCLAP(int IEHMHPMCGJK, int OPGJHIOADCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8280F00", Offset = "0x827FD00", VA = "0x188280F00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IENGGNJDCPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static NativeParallelMultiHashMap<int, int> PLCOBOBJDND;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static NativeArray<int> BKJADAAGDHL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int MODNKLDFCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeList<int> EIPNGCJDFJD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x828C770", Offset = "0x828B570", VA = "0x18828C770")]
	public void MMCGKMBKHCM(int BHCDFJNJKKN, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x828C690", Offset = "0x828B490", VA = "0x18828C690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IENGGNJDCPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EDHNLBBMGJP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeList<int> KGGHOLPMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<int> OHNNECIEOKA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8285FE0", Offset = "0x8284DE0", VA = "0x188285FE0")]
	public EDHNLBBMGJP(IENGGNJDCPN IIJJIBJLMKE, PGFPLDMFONK PKBJPDPONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8285F30", Offset = "0x8284D30", VA = "0x188285F30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LFPHGMIEFJF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeList<float3> FAGHPFMNPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float3> FMDEKAMKOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private NativeArray<float4> HCJMHJKJOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private NativeArray<float2> JMIADPEIMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private NativeArray<float4> LOMJCOAFLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<int> EIPNGCJDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<int> KGGHOLPMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<float3> NPOLIIAOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float3> HCLOGKIGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeArray<float4> LGNIJGGFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<float4> BOFKGHJIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float2> MHJFNBGFNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeList<int> LMJGIMOHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float BJPJKKDLJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	public float JNHDBPCBCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private float3 ONBPAFAGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private float LPOJCKPLOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private float CFFNMDJMGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	public float AGKOFMHMOAG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8293160", Offset = "0x8291F60", VA = "0x188293160")]
	public LFPHGMIEFJF(IENGGNJDCPN LDIDDADGEFC, PGFPLDMFONK PKBJPDPONKJ, PGFPLDMFONK DEJJMJKMCON, float CFFNMDJMGHG, float AGKOFMHMOAG, Vector3 ONBPAFAGNCF, float LPOJCKPLOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82930B0", Offset = "0x8291EB0", VA = "0x1882930B0")]
	private float3 PHMBCJONJDB(int IEHMHPMCGJK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8292DF0", Offset = "0x8291BF0", VA = "0x188292DF0")]
	private void IINMDGPJFIF(int IEHMHPMCGJK, [Out] float3 NFGINCEPFKJ, [Out] float3 AHFAGJDFMIH, [Out] float4 DBLPPAIFPBJ, [Out] float4 JNMGKBIGAPB, [Out] float2 AKNNGKFMIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8291DE0", Offset = "0x8290BE0", VA = "0x188291DE0")]
	private int DABBEKNAOAC(int FAKDKOKMIHP, int NKDOHPJBMEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8291BE0", Offset = "0x82909E0", VA = "0x188291BE0")]
	private void BBFEJNCMJLF(int FAKDKOKMIHP, int NKDOHPJBMEC, int JDJCFAKEBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8292A40", Offset = "0x8291840", VA = "0x188292A40")]
	private bool FIIDDGNCOPK(int FAKDKOKMIHP, int NKDOHPJBMEC, float NLFJGEDBNLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8292FD0", Offset = "0x8291DD0", VA = "0x188292FD0")]
	private bool LCNCPIDDNNG(int FAKDKOKMIHP, int NKDOHPJBMEC, int JDJCFAKEBBE, float NLFJGEDBNLH, bool PDEOPHAEKEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8292B90", Offset = "0x8291990", VA = "0x188292B90")]
	private bool HAKOIGEGKOO(int FAKDKOKMIHP, int NKDOHPJBMEC, int JDJCFAKEBBE, float NLFJGEDBNLH, bool PDEOPHAEKEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8293090", Offset = "0x8291E90", VA = "0x188293090")]
	private void NPIDHEGOPMA(int FAKDKOKMIHP, int NKDOHPJBMEC, int JDJCFAKEBBE, [Out] int KDDEGPMPFPN, [Out] int FDPMIKGFGHP, [Out] int DIPMDFHFBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82920C0", Offset = "0x8290EC0", VA = "0x1882920C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MMCFODBOLON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NGBMJPIPJHG : IDisposable, IHDLDGPOFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Bounds LGMOAABAAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public List<MHIIGIDBEIK> MLDOKIPONMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Vector3 JBADDLAIEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Vector3 FJLHADGKNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int DNGOMJBAFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public PGFPLDMFONK OLIDIMELHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long OEIDEEFBAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IENGGNJDCPN GOCAKFGOKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Transform MMENCBNBOBJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CFFEBCONIBD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8295A00", Offset = "0x8294800", VA = "0x188295A00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh LMMOIGBJKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PGFPLDMFONK.JIAIGLHGEAK IBGDOACJIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
			[CompilerGenerated]
			get
			{
				return default(PGFPLDMFONK.JIAIGLHGEAK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CPMELELFMDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PGFPLDMFONK.JIAIGLHGEAK JECBHBGDPAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB1E560", Offset = "0xB1D360", VA = "0x180B1E560")]
			[CompilerGenerated]
			get
			{
				return default(PGFPLDMFONK.JIAIGLHGEAK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xFD59D0", Offset = "0xFD47D0", VA = "0x180FD59D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float EALJFAMGJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1284C70", Offset = "0x1283A70", VA = "0x181284C70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1A49CD0", Offset = "0x1A48AD0", VA = "0x181A49CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte AKAMGECAIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1060E60", Offset = "0x105FC60", VA = "0x181060E60")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x105E950", Offset = "0x105D750", VA = "0x18105E950", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PAHFCADBEAH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xACBD80", Offset = "0xACAB80", VA = "0x180ACBD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x15BB370", Offset = "0x15BA170", VA = "0x1815BB370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HNAMCMGCIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xABC1F0", Offset = "0xABAFF0", VA = "0x180ABC1F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x15BB3B0", Offset = "0x15BA1B0", VA = "0x1815BB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AEBIHGDLEDL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8295480", Offset = "0x8294280", VA = "0x188295480", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82954A0", Offset = "0x82942A0", VA = "0x1882954A0")]
		public void DJAMKHCCLCC(GJNDJKNGBFN GOLHBMLDEPN, [Out] int MFMOEPOBJKN, [Out] int PCAFCCDIJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82952B0", Offset = "0x82940B0", VA = "0x1882952B0")]
		public void AAMDGBMFMCJ(GJNDJKNGBFN GOLHBMLDEPN, MCIGJBLBCLF AMBOHHPAFBM, int PCCNFLKIFNO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82958C0", Offset = "0x82946C0", VA = "0x1882958C0")]
		public void FALNMFHIHJO(Mesh PKBJPDPONKJ, PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8295970", Offset = "0x8294770", VA = "0x188295970")]
		public void HGIFMGHAHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8295710", Offset = "0x8294510", VA = "0x188295710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8295A40", Offset = "0x8294840", VA = "0x188295A40")]
		public NGBMJPIPJHG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Bounds LGMOAABAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public PGFPLDMFONK.JIAIGLHGEAK DCCIDFKPCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public List<NGBMJPIPJHG> OMEOHBDOIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public DLALLKKHAJL PLMEGOBAPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public ClusterMeshRenderer KINIEEOGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int DMCPLHNHIBG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh PGMEGDLHIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JHFFOGBBMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HAADIFLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8294F80", Offset = "0x8293D80", VA = "0x188294F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8293FA0", Offset = "0x8292DA0", VA = "0x188293FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8293F70", Offset = "0x8292D70", VA = "0x188293F70")]
	public int CMNJFJEJLMD(int DLNFMJGNGKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82942E0", Offset = "0x82930E0", VA = "0x1882942E0")]
	public void EPHICBBFFHA(IGAANGKFCBA LODIIMLFPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82944D0", Offset = "0x82932D0", VA = "0x1882944D0")]
	public void JPDFMEMMHDJ(Transform EBMIKMPNPCO, bool MJOJGFNLAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8294120", Offset = "0x8292F20", VA = "0x188294120")]
	public bool EGNGHGOBFEE(bool JPBFCDKFCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8293940", Offset = "0x8292740", VA = "0x188293940")]
	public void CJIAOCEEHCE(Transform MMENCBNBOBJ, bool MJOJGFNLAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8294D10", Offset = "0x8293B10", VA = "0x188294D10")]
	public bool MDNHCHGJFLC(MHIIGIDBEIK PGJHFGMMOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8294FD0", Offset = "0x8293DD0", VA = "0x188294FD0")]
	public MMCFODBOLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NPGCAHLDBEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Queue<MMCFODBOLON.NGBMJPIPJHG> DFAIGLKMDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private BILANAHFPLH NCEHPLICMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<MMCFODBOLON.NGBMJPIPJHG> EHPPALHEAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int KHEEGIEKLMP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8295F50", Offset = "0x8294D50", VA = "0x188295F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x82960D0", Offset = "0x8294ED0", VA = "0x1882960D0")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8295E90", Offset = "0x8294C90", VA = "0x188295E90")]
	public void DPHJBDIDPOG(MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL, Transform MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8296620", Offset = "0x8295420", VA = "0x188296620")]
	public void MDNHCHGJFLC(MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82964E0", Offset = "0x82952E0", VA = "0x1882964E0")]
	private MMCFODBOLON.NGBMJPIPJHG LMDELFHDPMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8296030", Offset = "0x8294E30", VA = "0x188296030")]
	private bool FIBCDBGHACN(MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8295E30", Offset = "0x8294C30", VA = "0x188295E30")]
	private void DLBHFDHCNEG(MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8295E00", Offset = "0x8294C00", VA = "0x188295E00")]
	public bool CCNMKFKBCHL(MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8295B70", Offset = "0x8294970", VA = "0x188295B70")]
	public bool AFCEEABIEMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8296470", Offset = "0x8295270", VA = "0x188296470")]
	private MMCFODBOLON.NGBMJPIPJHG LDIOOICKPMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8296150", Offset = "0x8294F50", VA = "0x188296150")]
	public long GKEIBNGDFIC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8296800", Offset = "0x8295600", VA = "0x188296800")]
	public NPGCAHLDBEA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EKKHHAHKNBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int MCHCJPPEMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int CCIBHHDJODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float DJNIIOFCAEL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<MMCFODBOLON> FPPHEOFFNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8288500", Offset = "0x8287300", VA = "0x188288500")]
	public EKKHHAHKNBM(int MCHCJPPEMHE, int CCIBHHDJODL, float EIKGADLFEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8288130", Offset = "0x8286F30", VA = "0x188288130")]
	public void JJDGLFBPEFD(FKGOOFLHMOD CEKOLHMAFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8288450", Offset = "0x8287250", VA = "0x188288450")]
	private int LNJBNEPCIIA(IGAANGKFCBA DFHOHFFNCIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82881E0", Offset = "0x8286FE0", VA = "0x1882881E0")]
	private void JJDGLFBPEFD(IGAANGKFCBA DFHOHFFNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8288090", Offset = "0x8286E90", VA = "0x188288090")]
	private void BBGHODHAAFK(IGAANGKFCBA DFHOHFFNCIJ, MMCFODBOLON DPFNFCBNLBG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, MMBGBENDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CNHOMBJOCLO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
			[DebuggerHidden]
			public CNHOMBJOCLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8282D30", Offset = "0x8281B30", VA = "0x188282D30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8282EF0", Offset = "0x8281CF0", VA = "0x188282EF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8282E40", Offset = "0x8281C40", VA = "0x188282E40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8282E40", Offset = "0x8281C40", VA = "0x188282E40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HAADIFLKEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8284AB0", Offset = "0x82838B0", VA = "0x188284AB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<IHDLDGPOFHF> KDIOPMPGABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8284A90", Offset = "0x8283890", VA = "0x188284A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> OMEOHBDOIPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MMCFODBOLON PGMEGDLHIMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public LIILGEJCGAD GHFKFKMALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(LIILGEJCGAD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA94B60", Offset = "0xA93960", VA = "0x180A94B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CIMJONNCGJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDF6610", Offset = "0xDF5410", VA = "0x180DF6610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8283070", Offset = "0x8281E70", VA = "0x188283070")]
		public static ClusterMeshRenderer Create(MMCFODBOLON PKBJPDPONKJ, ClusterMeshRenderer PDJENLHKLEN, MeshFilter DIGOIGMODPP, FHLDPOMNGOB MMENCBNBOBJ, LIILGEJCGAD OGEICBNAJLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82832E0", Offset = "0x82820E0", VA = "0x1882832E0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8283DD0", Offset = "0x8282BD0", VA = "0x188283DD0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(MHIIGIDBEIK PGJHFGMMOON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8283B80", Offset = "0x8282980", VA = "0x188283B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8283810", Offset = "0x8282610", VA = "0x188283810")]
		public void Init(MMCFODBOLON PKBJPDPONKJ, MeshFilter DIGOIGMODPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8283340", Offset = "0x8282140", VA = "0x188283340")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8283E90", Offset = "0x8282C90", VA = "0x188283E90", Slot = "7")]
		public void UpdateClusterDistances(Vector3 EEIHHMMODIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8284140", Offset = "0x8282F40", VA = "0x188284140", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8283790", Offset = "0x8282590", VA = "0x188283790")]
		[IteratorStateMachine(typeof(CNHOMBJOCLO))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8283C10", Offset = "0x8282A10", VA = "0x188283C10")]
		public void SetupTagAndLayer(string MIBLFIHKNOI, int OGEICBNAJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8283BF0", Offset = "0x82829F0", VA = "0x188283BF0")]
		public bool Remove(MHIIGIDBEIK PGJHFGMMOON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EMFDPPBONGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int OLFNGJOHCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int DOCKBMMINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int PCAFCCDIJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int MFMOEPOBJKN;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8288550", Offset = "0x8287350", VA = "0x188288550")]
	public EMFDPPBONGM(int DOCKBMMINED, int PCAFCCDIJAD, int OLFNGJOHCPI, int MFMOEPOBJKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DLALLKKHAJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeList<float3> HLIMDLBHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeList<int> EIPNGCJDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public NativeList<int> NCGAAPLMBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public NativeList<EMFDPPBONGM> OBBKFMPBGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public NativeArray<int> ECJNNAFKAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NativeArray<float3> POMJNBDICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public NativeArray<float> POBAOHHNPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public JobHandle CNIEIMLLGJC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IKLOPDIDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4F70", Offset = "0xAC3D70", VA = "0x180AC4F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAC3E20", Offset = "0xAC2C20", VA = "0x180AC3E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8285080", Offset = "0x8283E80", VA = "0x188285080")]
	public void MHDKBDCHLCM(PGFPLDMFONK KLIDHANJOLG, NativeList<EMFDPPBONGM> OBBKFMPBGKI, float KBAEKIALOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8284B10", Offset = "0x8283910", VA = "0x188284B10")]
	public void BFBFNADMCDL(Transform MMENCBNBOBJ, bool MJOJGFNLAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8284EB0", Offset = "0x8283CB0", VA = "0x188284EB0")]
	public void EGNGHGOBFEE(MMCFODBOLON KINIEEOGPPI, bool JPBFCDKFCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8284DA0", Offset = "0x8283BA0", VA = "0x188284DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8285050", Offset = "0x8283E50", VA = "0x188285050")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DLALLKKHAJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct FNMNIICADLL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeList<float3> HLIMDLBHPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	public NativeList<int> EIPNGCJDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private NativeList<EMFDPPBONGM> CJHGBPNLGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private NativeArray<int> ECJNNAFKAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float3 ONBPAFAGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private NativeArray<float3> POMJNBDICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeArray<float> POBAOHHNPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private bool MJOJGFNLAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private float HPJLMLDFPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[ReadOnly]
	private float NDOEGCLHJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private float BEMAPCGLILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeList<int> NCGAAPLMBDI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82896D0", Offset = "0x82884D0", VA = "0x1882896D0")]
	public FNMNIICADLL(DLALLKKHAJL ABJLPICBAEO, Vector3 ONBPAFAGNCF, bool MJOJGFNLAJB, float HPJLMLDFPFC, float NDOEGCLHJDD, float BEMAPCGLILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x82891D0", Offset = "0x8287FD0", VA = "0x1882891D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MHIIGIDBEIK : BKEEBOFODIO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds HNPFEDMHHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IGAANGKFCBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<MHIIGIDBEIK> MLDOKIPONMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public IGAANGKFCBA PJGOIMBEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public IGAANGKFCBA LALHJMOPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public IGAANGKFCBA LAOANIHJANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MFMOEPOBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Bounds LGMOAABAAAM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x828C960", Offset = "0x828B760", VA = "0x18828C960")]
	public IGAANGKFCBA(List<MHIIGIDBEIK> MLDOKIPONMG, [Optional] IGAANGKFCBA PJGOIMBEKPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FKGOOFLHMOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public List<IGAANGKFCBA> MCPHFOFKCLO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IGAANGKFCBA CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8288910", Offset = "0x8287710", VA = "0x188288910")]
	public FKGOOFLHMOD(IGAANGKFCBA MMENCBNBOBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EDNMBDGJOBH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PJFDAAFOLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int GONOFOPBIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int NOLPACGMLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int AJECAJHLMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int CJCFEBKAOFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LPEIMABNIGF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int PJIDDNPEIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public float EDGJHGNBJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<MHIIGIDBEIK> MLDOKIPONMG;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x82933F0", Offset = "0x82921F0", VA = "0x1882933F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NHOMLKLECAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PJFDAAFOLKM BAEPGHPHNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int NFDGOHOLGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int MCHCJPPEMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int CCIBHHDJODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float EIKGADLFEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float KMMDEPHGIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Stack<IGAANGKFCBA> PBKLICJKNHP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FKGOOFLHMOD CLHLDHBOCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8288030", Offset = "0x8286E30", VA = "0x188288030")]
	public EDNMBDGJOBH(int MCHCJPPEMHE, int CCIBHHDJODL, float EIKGADLFEDM, int NFDGOHOLGCD, float KMMDEPHGIJB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8286010", Offset = "0x8284E10", VA = "0x188286010")]
	public void AMAGBBMCNAA(List<MHIIGIDBEIK> MLDOKIPONMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8286250", Offset = "0x8285050", VA = "0x188286250")]
	public bool FALLBFNJOBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8286200", Offset = "0x8285000", VA = "0x188286200")]
	private float DHBENLHDCNE(Vector3 OLBFNPPONEB, Vector3 ANDCPDPHMGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x82861E0", Offset = "0x8284FE0", VA = "0x1882861E0")]
	private float DHBENLHDCNE(Vector3 BCMFMCHGEKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8286680", Offset = "0x8285480", VA = "0x188286680")]
	private bool KEFNHFCNEPE(IGAANGKFCBA GKEOABOCBJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8286FE0", Offset = "0x8285DE0", VA = "0x188286FE0")]
	private LPEIMABNIGF OGNHPPLKKGD(List<MHIIGIDBEIK> OGIBCIPLOEJ, NHOMLKLECAN IDJKANPKDAN)
	{
		return default(LPEIMABNIGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x82862C0", Offset = "0x82850C0", VA = "0x1882862C0")]
	private void IJHFEDIFHOM(List<MHIIGIDBEIK> MLDOKIPONMG, NativeArray<Vector3> LEPOMPHBEEL, NativeArray<Vector3> LFKEPIGLOEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class EOFKPHFNLFH
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8288570", Offset = "0x8287370", VA = "0x188288570")]
	public static Bounds EOANFJMNICH(List<MHIIGIDBEIK> MLDOKIPONMG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8288740", Offset = "0x8287540", VA = "0x188288740")]
	public static int FJCJGGGAANL(List<MHIIGIDBEIK> MLDOKIPONMG, GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class NBKJIMHJMMG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool GGOCPANINKH(float4* ONKOAOCBJJH, int MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class MHPEEEBCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private static IntPtr INALKLMHNGC;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static IntPtr GOBILIGGBPO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x82936D0", Offset = "0x82924D0", VA = "0x1882936D0")]
		[BurstDiscard]
		private static void DEHFDKPNFGH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x82937F0", Offset = "0x82925F0", VA = "0x1882937F0")]
		private static IntPtr FIOOAGFKCGJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8293630", Offset = "0x8292430", VA = "0x188293630")]
		public static void AKAIBFLBHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public static void IEHCJBEIMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8293450", Offset = "0x8292250", VA = "0x188293450")]
		public unsafe static bool AHMKNKCPDKI(float4* ONKOAOCBJJH, int MCJGICKIGFF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82950A0", Offset = "0x8293EA0", VA = "0x1882950A0")]
	[BurstCompile]
	public unsafe static bool PADALJDMPAB(float4* ONKOAOCBJJH, int MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8280CB0", Offset = "0x827FAB0", VA = "0x188280CB0")]
	[BurstCompile]
	public unsafe static bool DKOONJCIJAN(float4* ONKOAOCBJJH, int MCJGICKIGFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct KCNNMMHOMMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ReadOnly]
	private NativeList<int> OGGADOMBNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeList<float3> JDLNELDHIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<float3> PGLKGIFNJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<float4> KDHPAIKDEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private NativeArray<float4> MBPAFIIHOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeArray<float2> ACDIGENOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<bool> CDOGMFCAOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public NativeList<ushort> CIAANINKNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public NativeList<PGFPLDMFONK.BNJDLIKBCAF> EEPPDEDKBHH;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8291AC0", Offset = "0x82908C0", VA = "0x188291AC0")]
	public KCNNMMHOMMC(PGFPLDMFONK EDBBOBGNBLG, NativeArray<bool> CDOGMFCAOMD, NativeList<ushort> CIAANINKNHB, NativeList<PGFPLDMFONK.BNJDLIKBCAF> EEPPDEDKBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8291810", Offset = "0x8290610", VA = "0x188291810", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct PMMNFNLLMKC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[ReadOnly]
	private NativeList<int> OGGADOMBNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<float3> JDLNELDHIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float3> PGLKGIFNJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> KDHPAIKDEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> MBPAFIIHOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float2> ACDIGENOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeList<int> ABOEJDIMHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeList<float3> GKFDAIHKHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeArray<float3> AJOHKLHPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<float4> PFIFJGCJBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeArray<float4> FJOCICBPKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<float2> ACOMFEOMBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[WriteOnly]
	public NativeArray<bool> CDOGMFCAOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public NativeList<ushort> CIAANINKNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public NativeList<PGFPLDMFONK.BNJDLIKBCAF> EEPPDEDKBHH;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8296F40", Offset = "0x8295D40", VA = "0x188296F40")]
	public PMMNFNLLMKC(PGFPLDMFONK EDBBOBGNBLG, PGFPLDMFONK INDBOKIKHEI, NativeArray<bool> CDOGMFCAOMD, NativeList<ushort> CIAANINKNHB, NativeList<PGFPLDMFONK.BNJDLIKBCAF> EEPPDEDKBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8296A70", Offset = "0x8295870", VA = "0x188296A70", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BILANAHFPLH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private PGFPLDMFONK NAAIAABICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private PGFPLDMFONK EDBBOBGNBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<bool> DPOLFMLEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeList<ushort> CIAANINKNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private NativeList<PGFPLDMFONK.BNJDLIKBCAF> EEPPDEDKBHH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static PGFPLDMFONK NOGCGIIGLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private IOHMAPGIDEF NMMIIAMEJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private MCIGJBLBCLF AMBOHHPAFBM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle CNIEIMLLGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MMCFODBOLON.NGBMJPIPJHG GKEOABOCBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GLPHIMNGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2705C70", Offset = "0x2704A70", VA = "0x182705C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8281770", Offset = "0x8280570", VA = "0x188281770")]
	[NPBBODEJCMJ(NJGOLKIDIIP.EnteredEditMode, 0)]
	private static void FOLOHMHMEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x82820A0", Offset = "0x8280EA0", VA = "0x1882820A0")]
	public void MHDKBDCHLCM(MMCFODBOLON.NGBMJPIPJHG CJHGBPNLGPN, Transform BJLCFJMDDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x82817E0", Offset = "0x82805E0", VA = "0x1882817E0")]
	public void GPPFPOPDPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8281660", Offset = "0x8280460", VA = "0x188281660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8281730", Offset = "0x8280530", VA = "0x188281730")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8282BC0", Offset = "0x82819C0", VA = "0x188282BC0")]
	public BILANAHFPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KLOJBPDFHLM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 AJFFPELKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DDKGICJFACC
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GMHMEBHNAOE<string>.HGELJMPBEBF BOHPCGDPMOD, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JDHPOFCIKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDHPOFCIKGP IFAIPDIDNKD(Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDHPOFCIKGP MBENNMJMEMI(Action IJBAPONMLAP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class HJBCIHFNKED : JDHPOFCIKGP
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class LKGEPDMAJDG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public HJBCIHFNKED <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public LKGEPDMAJDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x8293340", Offset = "0x8292140", VA = "0x188293340")]
				internal void BJBCAMHHABL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x82932F0", Offset = "0x82920F0", VA = "0x1882932F0")]
				internal void BBHNEHBFLOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x82932A0", Offset = "0x82920A0", VA = "0x1882932A0")]
				internal void AHJIOJFDNCN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Func<JobHandle> OPMKBAMIJHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action GEAJOGPGFNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private Action MGLEBGFADEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private FMCKOBDDGEK KACKBMJOHHI;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action FNHANEPEOBI
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action FLEEBOKPDDO
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2A52E50", Offset = "0x2A51C50", VA = "0x182A52E50", Slot = "4")]
			public JDHPOFCIKGP IFAIPDIDNKD(Action IJBAPONMLAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDED20", Offset = "0x7BDDB20", VA = "0x187BDED20", Slot = "5")]
			public JDHPOFCIKGP MBENNMJMEMI(Action IJBAPONMLAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
			public HJBCIHFNKED(Func<JobHandle> CBHOENPDKPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x828C3D0", Offset = "0x828B1D0", VA = "0x18828C3D0")]
			public void PLBGJCCDHGP(Action PBEJNCOPKKC, Action JBJFPKKJOON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x828C240", Offset = "0x828B040", VA = "0x18828C240")]
			public void MDNHCHGJFLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class NHIJHPHLBIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JDHPOFCIKGP jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public NHIJHPHLBIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8295B60", Offset = "0x8294960", VA = "0x188295B60")]
			internal bool MHHMHEAKDHG(HJBCIHFNKED a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class JMLKJAHECAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HJBCIHFNKED newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public JMLKJAHECAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x828C9E0", Offset = "0x828B7E0", VA = "0x18828C9E0")]
			internal void PHLDPFCFDKD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Queue<HJBCIHFNKED> EDACFADJLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<HJBCIHFNKED> JHKHECJJLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private GMJHELKMAKL JJPBIMFENKB;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public KABKNNJBDJC EBGOMCODFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x828CA40", Offset = "0x828B840", VA = "0x18828CA40")]
		public JDHPOFCIKGP Add(Func<JobHandle> CBHOENPDKPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x828CD70", Offset = "0x828BB70", VA = "0x18828CD70")]
		public void Remove(JDHPOFCIKGP CNIEIMLLGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x828CBA0", Offset = "0x828B9A0", VA = "0x18828CBA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x828CF50", Offset = "0x828BD50", VA = "0x18828CF50")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x828D1B0", Offset = "0x828BFB0", VA = "0x18828D1B0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x828CB90", Offset = "0x828B990", VA = "0x18828CB90")]
		[CompilerGenerated]
		private void MEFHPOGKIPC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FMCKOBDDGEK
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMCKOBDDGEK IFAIPDIDNKD(Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FMCKOBDDGEK ENKOPHFPGKI(Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FMCKOBDDGEK MBENNMJMEMI(Action IJBAPONMLAP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, HNBEDMLJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class LDDEGLHIHKE : FMCKOBDDGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private JobHandle KGOKOAFABCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action GEAJOGPGFNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action LHLCDJMBDAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private Action FLEEBOKPDDO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool FCMNOCKJCIK
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8291B30", Offset = "0x8290930", VA = "0x188291B30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7B04E80", Offset = "0x7B03C80", VA = "0x187B04E80", Slot = "4")]
			public FMCKOBDDGEK IFAIPDIDNKD(Action IJBAPONMLAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7B04EA0", Offset = "0x7B03CA0", VA = "0x187B04EA0", Slot = "5")]
			public FMCKOBDDGEK ENKOPHFPGKI(Action IJBAPONMLAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDED20", Offset = "0x7BDDB20", VA = "0x187BDED20", Slot = "6")]
			public FMCKOBDDGEK MBENNMJMEMI(Action IJBAPONMLAP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x10F61A0", Offset = "0x10F4FA0", VA = "0x1810F61A0")]
			public LDDEGLHIHKE(JobHandle MPAPHPDMDJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8291B40", Offset = "0x8290940", VA = "0x188291B40")]
			public void HNMLKBBINMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8291B90", Offset = "0x8290990", VA = "0x188291B90")]
			public void MDNHCHGJFLC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private List<LDDEGLHIHKE> KLIJAKLNCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly List<IDisposable> ICJMCGENFIH;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GFIKDCHCPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x828D790", Offset = "0x828C590", VA = "0x18828D790")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x16CD2A0", Offset = "0x16CC0A0", VA = "0x1816CD2A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x828D290", Offset = "0x828C090", VA = "0x18828D290")]
		public FMCKOBDDGEK Add(JobHandle MPAPHPDMDJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x828D9A0", Offset = "0x828C7A0", VA = "0x18828D9A0")]
		public void Remove(FMCKOBDDGEK CNIEIMLLGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x828D5B0", Offset = "0x828C3B0", VA = "0x18828D5B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x828D400", Offset = "0x828C200", VA = "0x18828D400", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x828D330", Offset = "0x828C130", VA = "0x18828D330")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x828DAA0", Offset = "0x828C8A0", VA = "0x18828DAA0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "6")]
		private bool DOPDOPHOHMN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8297000", Offset = "0x8295E00", VA = "0x188297000")]
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
