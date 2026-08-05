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
				[Cpp2IlInjected.Address(RVA = "0x41D6B40", Offset = "0x41D5140", VA = "0x1841D6B40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1861E60", Offset = "0x1860460", VA = "0x181861E60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41D6B00", Offset = "0x41D5100", VA = "0x1841D6B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x41CD190", Offset = "0x41CB790", VA = "0x1841CD190")]
		public LODSettings HFDPHOMNEJF(POMHGFHEEKJ AILOIIHNAGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x41CD170", Offset = "0x41CB770", VA = "0x1841CD170")]
		public int DCJGPEFAJFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41CD1A0", Offset = "0x41CB7A0", VA = "0x1841CD1A0")]
		public int LCEEPHPFHOB(bool MCIEMGCPDAC, Vector3 JHAAGIJNPGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x41CD2A0", Offset = "0x41CB8A0", VA = "0x1841CD2A0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FDEFJGAIGLI
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
public interface JMNHOLDFBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBLAHAODIBL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EOEOCCMILJH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KMDNPNBGJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<CPIKDOKDLIP> LALHLHGAGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FDEFJGAIGLI IHNJGHAOBNH
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
	void UpdateClusterDistances(Vector3 BLAFHLFJGAO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(LBKOJFHLGEN LPKJELLIJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPIKDOKDLIP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FHAKFKCCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int PLFDHIHAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LJPKGLLODMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MIDHLNAJEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte JHBFPHJOBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KPGBNLPOLND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DJAMNHCEBDP
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
	private struct OODCLCBLIPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41D9F90", Offset = "0x41D8590", VA = "0x1841D9F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FLEDPFBKIKP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public FLEDPFBKIKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41D10E0", Offset = "0x41CF6E0", VA = "0x1841D10E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41D11A0", Offset = "0x41CF7A0", VA = "0x1841D11A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BJCMOKJPOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BJHOOGFBDGF worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x41CB8D0", Offset = "0x41C9ED0", VA = "0x1841CB8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DAFAEDPAJCP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public DAFAEDPAJCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41CE6F0", Offset = "0x41CCCF0", VA = "0x1841CE6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x41CF5E0", Offset = "0x41CDBE0", VA = "0x1841CF5E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EAGOECCIHEI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan KGFPNFPFKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer KBIDCABBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter MOCJEBLHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DPNCNCBPGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JHHOMMGLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MKKJNKDCMFB IMPAEBPJOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<LBKOJFHLGEN> AJLKGEIAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<LBKOJFHLGEN> ABDAOBKMIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<LBKOJFHLGEN> CFLLEMPHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JDBONGNAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DJAMNHCEBDP MFNOKCKMAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<EOEOCCMILJH>[] DHEOMOLIPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<CPIKDOKDLIP>[] KHHKANLFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource IAKIGNJHLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool JPNFKJEJGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private JPGLPKCHKEM HALCLFNOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JPGLPKCHKEM CCFICBMBPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int KPMDDKOMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int AJPNOACBDLK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static KPGBNLPOLND KOIDPFHNKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GNANNLFBEEB NLLAAABFKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FAENLNEJNFO ADIGMPGONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour IDIODGAKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material ILLBDIKBEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<JMNHOLDFBHG> JFECPPFHHPF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JNGBEHOBDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DDIBCEAPCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1053D00", Offset = "0x1052300", VA = "0x181053D00")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1053C10", Offset = "0x1052210", VA = "0x181053C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private DJAMNHCEBDP KHPHPHHNJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x573CD0", Offset = "0x5722D0", VA = "0x180573CD0")]
		get
		{
			return default(DJAMNHCEBDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41D5480", Offset = "0x41D3A80", VA = "0x1841D5480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KPGBNLPOLND NNHENCBEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41D5750", Offset = "0x41D3D50", VA = "0x1841D5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BNCJJGAENOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x41D4560", Offset = "0x41D2B60", VA = "0x1841D4560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HILCAJBCOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41D47C0", Offset = "0x41D2DC0", VA = "0x1841D47C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NFFDAFLDOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41D3A80", Offset = "0x41D2080", VA = "0x1841D3A80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41D2FB0", Offset = "0x41D15B0", VA = "0x1841D2FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FOBLGBHFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41D4A50", Offset = "0x41D3050", VA = "0x1841D4A50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41D5850", Offset = "0x41D3E50", VA = "0x1841D5850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41D5960", Offset = "0x41D3F60", VA = "0x1841D5960")]
	public KPGBNLPOLND(GNANNLFBEEB NLLAAABFKDL, FAENLNEJNFO ADIGMPGONIN, ClusterLODConfig NJAPJMBPPCB, MonoBehaviour IDIODGAKJEN, Material ILLBDIKBEHI, ClusterMeshRenderer KBIDCABBFLH, MeshFilter MOCJEBLHKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x41D3980", Offset = "0x41D1F80", VA = "0x1841D3980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41D4010", Offset = "0x41D2610", VA = "0x1841D4010")]
	public static void HFCGKKEEPFE(Vector3 LFBABJAEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x41D3050", Offset = "0x41D1650", VA = "0x1841D3050")]
	private void AMGGPDNPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41D4460", Offset = "0x41D2A60", VA = "0x1841D4460")]
	private void JPMCBCABMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41D4680", Offset = "0x41D2C80", VA = "0x1841D4680")]
	private void LCPKDMGFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41D3490", Offset = "0x41D1A90", VA = "0x1841D3490")]
	public void DIIAJFIGNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41D5620", Offset = "0x41D3C20", VA = "0x1841D5620")]
	[AsyncStateMachine(typeof(OODCLCBLIPB))]
	public Task OKJNAFIOJLH(BJHOOGFBDGF OADNBMGMCGO, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41D3FA0", Offset = "0x41D25A0", VA = "0x1841D3FA0")]
	[IteratorStateMachine(typeof(FLEDPFBKIKP))]
	private IEnumerator<MCOOOHEMEPE> GABLENPOHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41D3E70", Offset = "0x41D2470", VA = "0x1841D3E70")]
	[AsyncStateMachine(typeof(BJCMOKJPOLE))]
	private Task FPDAACFJADF(BJHOOGFBDGF HPDDLEBBPDJ, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41D3B20", Offset = "0x41D2120", VA = "0x1841D3B20")]
	public void ELMFKCALKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41D3DF0", Offset = "0x41D23F0", VA = "0x1841D3DF0")]
	public void FMGNBBMKPPA(IEnumerable<EOEOCCMILJH> DAFKGGCFHKE, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x41D41B0", Offset = "0x41D27B0", VA = "0x1841D41B0")]
	public void JEBNLGMCFHF(IEnumerable<EOEOCCMILJH> DAFKGGCFHKE, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41D4CC0", Offset = "0x41D32C0", VA = "0x1841D4CC0")]
	public List<ClusterMeshRenderer> NGDDPKPKLGE(List<LBKOJFHLGEN> HHCAAMAPGPK, Transform PFOHKHPLBFI, FDEFJGAIGLI MHDHIIHJHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41D5810", Offset = "0x41D3E10", VA = "0x1841D5810")]
	public FDEFJGAIGLI PKLJLOOLGBH(Vector3 ENHAFCAMOMK)
	{
		return default(FDEFJGAIGLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41D32C0", Offset = "0x41D18C0", VA = "0x1841D32C0")]
	public void CNAINGNDLHL(JMNHOLDFBHG EEILLLKBOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x41D3D30", Offset = "0x41D2330", VA = "0x1841D3D30")]
	public bool EPMEHOJOFAI(JMNHOLDFBHG EEILLLKBOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x41D3D90", Offset = "0x41D2390", VA = "0x1841D3D90")]
	public void FCJBMPKNPHJ(LBKOJFHLGEN FDLDOMOMGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x41D4130", Offset = "0x41D2730", VA = "0x1841D4130")]
	public void IBGONDOADNP(CPIKDOKDLIP OONMAFOODBN, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x41D55A0", Offset = "0x41D3BA0", VA = "0x1841D55A0")]
	public void OBACFOPIABH(CPIKDOKDLIP OONMAFOODBN, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x41D3360", Offset = "0x41D1960", VA = "0x1841D3360")]
	private void DFCDHGGIIPD(Vector3 BLAFHLFJGAO, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41D30E0", Offset = "0x41D16E0", VA = "0x1841D30E0")]
	private void CIALPNLBBPK(Vector3 BLAFHLFJGAO, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41D3250", Offset = "0x41D1850", VA = "0x1841D3250")]
	[IteratorStateMachine(typeof(DAFAEDPAJCP))]
	private IEnumerator<MCOOOHEMEPE> CLABFFFBGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41D48E0", Offset = "0x41D2EE0", VA = "0x1841D48E0")]
	private int MGAGKAPBCLL(int HOOANEAGKNH, int PDBJJDLABLI, List<CPIKDOKDLIP> BKMBJKPOCBF, byte AILOIIHNAGP, ref int HNFHLNHGINM, float LOPKGDOPGIA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41D4AF0", Offset = "0x41D30F0", VA = "0x1841D4AF0")]
	public void MNHCGCIEOKP(LBKOJFHLGEN LPKJELLIJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41D48A0", Offset = "0x41D2EA0", VA = "0x1841D48A0")]
	public bool LKMGMNKOEAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAA0", Offset = "0x5EA0A0", VA = "0x1805EBAA0")]
	public Material PPGAJKPMKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41D3320", Offset = "0x41D1920", VA = "0x1841D3320")]
	public int DCJGPEFAJFF()
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
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GOHDMFMOCJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> MEEJMFMKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> ECEGHMLEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> DPOLBOMBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> MGCOIIFNAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> HCGDLOECDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 BKIOFCECEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float HEDLEIOCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> BFMGPAEPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> CIPLJEJIPBM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41D1AC0", Offset = "0x41D00C0", VA = "0x1841D1AC0")]
	public GOHDMFMOCJO(GMPJPDMCHBE FCHIEFHJLOJ, NativeList<float3> HCGDLOECDMO, NativeMultiHashMap<int, int> BFMGPAEPLGE, NativeArray<int> CIPLJEJIPBM, Vector3 BKIOFCECEJF, float HEDLEIOCNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x41D1670", Offset = "0x41CFC70", VA = "0x1841D1670")]
	private int DIJOMKJBIGJ(float3 BLAFHLFJGAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41D13D0", Offset = "0x41CF9D0", VA = "0x1841D13D0")]
	private int AHPMHHCNIDI(int CKOCCIDDCLA, int MKDJIBNCKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41D16D0", Offset = "0x41CFCD0", VA = "0x1841D16D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CAFAIOBMGPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> BFMGPAEPLGE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> CIPLJEJIPBM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int BDOKFKNNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41CCBF0", Offset = "0x41CB1F0", VA = "0x1841CCBF0")]
	public void IJFCHAHKPJL(int DDDKIEOJEJK, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x41CCB40", Offset = "0x41CB140", VA = "0x1841CCB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public CAFAIOBMGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KHAKDPEBAPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> LPAFEMKKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> NIKCDEBFLHL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x41D2EA0", Offset = "0x41D14A0", VA = "0x1841D2EA0")]
	public KHAKDPEBAPB(CAFAIOBMGPE KMIPPFPIMPG, GMPJPDMCHBE FCHIEFHJLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41D2E10", Offset = "0x41D1410", VA = "0x1841D2E10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ENFLPOGLAKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> FDGKCBIDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> OBCFOPACBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> PINKDDDNFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> HIAHLHAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> HPNFFEPAHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> LPAFEMKKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> FBKGGDAMOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> GHCPDCNCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> IPPKHKMMOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> DMLKLAFPCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> LBIJGPKFJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> FNFEJOAONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float JOBCMOCLCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float NOCBPDKHMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 EFIAJFLJHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float HKEBGKGPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float HAPELBHHFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float NFELGDCJCGA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x41D0FA0", Offset = "0x41CF5A0", VA = "0x1841D0FA0")]
	public ENFLPOGLAKF(CAFAIOBMGPE HPKMOIPICJA, GMPJPDMCHBE FCHIEFHJLOJ, GMPJPDMCHBE FNHDENHGNKP, float HAPELBHHFPE, float NFELGDCJCGA, Vector3 EFIAJFLJHPD, float HKEBGKGPCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41D0AA0", Offset = "0x41CF0A0", VA = "0x1841D0AA0")]
	private float3 KNPODPMLDBL(int CKOCCIDDCLA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x41D0710", Offset = "0x41CED10", VA = "0x1841D0710")]
	private void GGDPNLKDCOL(int CKOCCIDDCLA, out float3 BAFPOHIKDIC, out float3 EKJFBCGJGCF, out float4 BGOLOJBCGAM, out float4 LAPCKCNHANN, out float2 EMKNBOPKKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41CF9C0", Offset = "0x41CDFC0", VA = "0x1841CF9C0")]
	private int ADKFCGCPBKK(int IGNMKIOPNBJ, int POLHDOKGPMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41D0DA0", Offset = "0x41CF3A0", VA = "0x1841D0DA0")]
	private void OFGIACLHEBI(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41D0910", Offset = "0x41CEF10", VA = "0x1841D0910")]
	private bool JNOKHPIOHJE(int IGNMKIOPNBJ, int POLHDOKGPMF, float KAIJDJCEGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x41CFCF0", Offset = "0x41CE2F0", VA = "0x1841CFCF0")]
	private bool CPHFDFLKHOD(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, float KAIJDJCEGJC, bool AIIGBOPGMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x41D0B40", Offset = "0x41CF140", VA = "0x1841D0B40")]
	private bool MPKMPGFJHPL(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, float KAIJDJCEGJC, bool AIIGBOPGMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x41D08F0", Offset = "0x41CEEF0", VA = "0x1841D08F0")]
	private void IKHAGCGOOKE(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, out int OPGDEKLLEIF, out int MJDGHCPPIKG, out int CIOHGOFCBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41CFDB0", Offset = "0x41CE3B0", VA = "0x1841CFDB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PFFNEOFKMIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LDFNAGEIOID : IDisposable, CPIKDOKDLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds LKAHHEMJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<LBKOJFHLGEN> HHCAAMAPGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 HEPJHADPLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 GPAPBDIJIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int LOKOGEKFABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GMPJPDMCHBE GFDOJBLDHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CAFAIOBMGPE ECAAEMIMPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform PFOHKHPLBFI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int BHBCKMOAJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x41D6510", Offset = "0x41D4B10", VA = "0x1841D6510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CDIMFHEHOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh LCHKJABKPLN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x561010", Offset = "0x55F610", VA = "0x180561010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x561020", Offset = "0x55F620", VA = "0x180561020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LJPKGLLODMA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xF80E80", Offset = "0xF7F480", VA = "0x180F80E80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1D53370", Offset = "0x1D51970", VA = "0x181D53370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte JHBFPHJOBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BA190", Offset = "0x6B8790", VA = "0x1806BA190")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6BA320", Offset = "0x6B8920", VA = "0x1806BA320", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FHAKFKCCDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x721A00", Offset = "0x720000", VA = "0x180721A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x721090", Offset = "0x71F690", VA = "0x180721090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PLFDHIHAMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA84290", Offset = "0xA82890", VA = "0x180A84290", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xCC4B30", Offset = "0xCC3130", VA = "0x180CC4B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MIDHLNAJEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x41D6880", Offset = "0x41D4E80", VA = "0x1841D6880", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x41D62E0", Offset = "0x41D48E0", VA = "0x1841D62E0")]
		public void BDELPLCMBMK(POMHGFHEEKJ AILOIIHNAGP, out int MHDCFAJEMPJ, out int ENLELCDJLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x41D68A0", Offset = "0x41D4EA0", VA = "0x1841D68A0")]
		public void NJDCCNCOOHC(POMHGFHEEKJ AILOIIHNAGP, MINNFNFMJEB PPCPOJNGOMJ, int PEPKJOMFLHN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x41D5FC0", Offset = "0x41D45C0", VA = "0x1841D5FC0")]
		public void AGJLCDICPEF(NativeList<DHPPIAAJBJB> OOJAMBILCHN, Transform OIJAJOJNFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x41D6740", Offset = "0x41D4D40", VA = "0x1841D6740")]
		public void HMFMECDMMHC(Mesh FCHIEFHJLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x41D67E0", Offset = "0x41D4DE0", VA = "0x1841D67E0")]
		public void LDMLKODGGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x41D6550", Offset = "0x41D4B50", VA = "0x1841D6550", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x41D6A40", Offset = "0x41D5040", VA = "0x1841D6A40")]
		public LDFNAGEIOID()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds LKAHHEMJOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<LDFNAGEIOID> DFNMDEJPPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NPCPNMFEDNL KFOBDBKNPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer OGIOFICPCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int LEKKNALFCOB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh PDKMCKDACHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x673F20", Offset = "0x672520", VA = "0x180673F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BAOMOAFIJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x795C20", Offset = "0x794220", VA = "0x180795C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x795CA0", Offset = "0x7942A0", VA = "0x180795CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KMDNPNBGJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x41DB290", Offset = "0x41D9890", VA = "0x1841DB290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41DACD0", Offset = "0x41D92D0", VA = "0x1841DACD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41DA540", Offset = "0x41D8B40", VA = "0x1841DA540")]
	public int CCHDIDECNBK(int MEIEGGCKEGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x41DB2E0", Offset = "0x41D98E0", VA = "0x1841DB2E0")]
	public void LPBDEFLIJNM(CBDDFBINNBH BLHINANEKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x41DA570", Offset = "0x41D8B70", VA = "0x1841DA570")]
	public void DNCMOAGDELK(Transform OIJAJOJNFJD, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x41DB6F0", Offset = "0x41D9CF0", VA = "0x1841DB6F0")]
	public bool OLIIMNGMEME(bool KOPNNMKHPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x41DAE30", Offset = "0x41D9430", VA = "0x1841DAE30")]
	public void GILCDBFNOIH(Transform PFOHKHPLBFI, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x41DB470", Offset = "0x41D9A70", VA = "0x1841DB470")]
	public bool MNHCGCIEOKP(LBKOJFHLGEN LPKJELLIJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x41DB8A0", Offset = "0x41D9EA0", VA = "0x1841DB8A0")]
	public PFFNEOFKMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MKKJNKDCMFB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<PFFNEOFKMIJ.LDFNAGEIOID> OCIACKNLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NJDAKPMJAJM FLAHGBOJFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<PFFNEOFKMIJ.LDFNAGEIOID> BHCHLICKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JDCDINJGGJF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41D6DD0", Offset = "0x41D53D0", VA = "0x1841D6DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x41D6D50", Offset = "0x41D5350", VA = "0x1841D6D50")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41D7310", Offset = "0x41D5910", VA = "0x1841D7310")]
	public void NENJMCKJAJO(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ, Transform PFOHKHPLBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x41D7160", Offset = "0x41D5760", VA = "0x1841D7160")]
	public void MNHCGCIEOKP(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x41D6B60", Offset = "0x41D5160", VA = "0x1841D6B60")]
	private PFFNEOFKMIJ.LDFNAGEIOID AIMBCAKNIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x41D6E40", Offset = "0x41D5440", VA = "0x1841D6E40")]
	private bool GBMGADGGPJA(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x41D6CF0", Offset = "0x41D52F0", VA = "0x1841D6CF0")]
	private void CGDFAODKIIK(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x41D73C0", Offset = "0x41D59C0", VA = "0x1841D73C0")]
	public bool OFBHFIGDMKC(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x41D6ED0", Offset = "0x41D54D0", VA = "0x1841D6ED0")]
	public bool IFFNNMKLCCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x41D6C90", Offset = "0x41D5290", VA = "0x1841D6C90")]
	private PFFNEOFKMIJ.LDFNAGEIOID BCENAJOFKOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41D7400", Offset = "0x41D5A00", VA = "0x1841D7400")]
	public MKKJNKDCMFB()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MNEMCHIGFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int NKDMBMAIGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int CPKJECPONJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float CGOMCFKJMLD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<PFFNEOFKMIJ> OHEHMKAEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x41D7A90", Offset = "0x41D6090", VA = "0x1841D7A90")]
	public MNEMCHIGFHN(int NKDMBMAIGPH, int CPKJECPONJE, float CNKLEJPEOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x41D79F0", Offset = "0x41D5FF0", VA = "0x1841D79F0")]
	public void LICCBMBMGDI(ALMPPELKLDK CBMJLFGKDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x41D7720", Offset = "0x41D5D20", VA = "0x1841D7720")]
	private int HDGGEIIBJEN(CBDDFBINNBH BOKLJENJLOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41D77C0", Offset = "0x41D5DC0", VA = "0x1841D77C0")]
	private void LICCBMBMGDI(CBDDFBINNBH BOKLJENJLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x41D7540", Offset = "0x41D5B40", VA = "0x1841D7540")]
	private void EPCGNDALNLE(CBDDFBINNBH BOKLJENJLOP, PFFNEOFKMIJ EDKICBHOIAC)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, EOEOCCMILJH
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GEPDBPJFPCN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
			[DebuggerHidden]
			public GEPDBPJFPCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x41D11F0", Offset = "0x41CF7F0", VA = "0x1841D11F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x41D1380", Offset = "0x41CF980", VA = "0x1841D1380", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x41D12E0", Offset = "0x41CF8E0", VA = "0x1841D12E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x41D12E0", Offset = "0x41CF8E0", VA = "0x1841D12E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int KMDNPNBGJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x41CE690", Offset = "0x41CCC90", VA = "0x1841CE690", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<CPIKDOKDLIP> LALHLHGAGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x41CE670", Offset = "0x41CCC70", VA = "0x1841CE670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> DFNMDEJPPCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PFFNEOFKMIJ PDKMCKDACHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FDEFJGAIGLI IHNJGHAOBNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x561390", Offset = "0x55F990", VA = "0x180561390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(FDEFJGAIGLI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x67F3C0", Offset = "0x67D9C0", VA = "0x18067F3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HIEEIFBKMJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x41CE680", Offset = "0x41CCC80", VA = "0x1841CE680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x41CD300", Offset = "0x41CB900", VA = "0x1841CD300")]
		public static ClusterMeshRenderer Create(PFFNEOFKMIJ FCHIEFHJLOJ, ClusterMeshRenderer KBIDCABBFLH, MeshFilter MOCJEBLHKIJ, Transform PFOHKHPLBFI, FDEFJGAIGLI MHDHIIHJHAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x41CD460", Offset = "0x41CBA60", VA = "0x1841CD460", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x41CDBE0", Offset = "0x41CC1E0", VA = "0x1841CDBE0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(LBKOJFHLGEN LPKJELLIJFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x41CD9B0", Offset = "0x41CBFB0", VA = "0x1841CD9B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x41CD6C0", Offset = "0x41CBCC0", VA = "0x1841CD6C0")]
		public void Init(PFFNEOFKMIJ FCHIEFHJLOJ, MeshFilter MOCJEBLHKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x41CD4C0", Offset = "0x41CBAC0", VA = "0x1841CD4C0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x41CDD10", Offset = "0x41CC310", VA = "0x1841CDD10", Slot = "8")]
		public void UpdateClusterDistances(Vector3 BLAFHLFJGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x41CDF50", Offset = "0x41CC550", VA = "0x1841CDF50", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x41CD650", Offset = "0x41CBC50", VA = "0x1841CD650")]
		[IteratorStateMachine(typeof(GEPDBPJFPCN))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x41CDA30", Offset = "0x41CC030", VA = "0x1841CDA30")]
		public void SetupTagAndLayer(string FJLIOINDIMA, int MHDHIIHJHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x41CDA10", Offset = "0x41CC010", VA = "0x1841CDA10")]
		public bool Remove(LBKOJFHLGEN LPKJELLIJFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CJMPPCLJLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int JJLDEEEMFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int AHNBCGDLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int ENLELCDJLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int MHDCFAJEMPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x41CCE10", Offset = "0x41CB410", VA = "0x1841CCE10")]
	public CJMPPCLJLPE(int AHNBCGDLBJF, int ENLELCDJLGN, int JJLDEEEMFEA, int MHDCFAJEMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NPCPNMFEDNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<CJMPPCLJLPE> ACDGKKJEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> BAFPCHPGMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> HEJMBEMECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> AIBMNFOFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle BJOELKKLLNF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ELPPJMJNBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70A380", Offset = "0x708980", VA = "0x18070A380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70A3A0", Offset = "0x7089A0", VA = "0x18070A3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x41D8DC0", Offset = "0x41D73C0", VA = "0x1841D8DC0")]
	public void GELLHDINKCG(GMPJPDMCHBE ENICKBJPBHG, NativeList<CJMPPCLJLPE> ACDGKKJEIHJ, float FJJOIFJEGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x41D9B40", Offset = "0x41D8140", VA = "0x1841D9B40")]
	public void HMJCLPNGLNC(Transform PFOHKHPLBFI, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x41D9E00", Offset = "0x41D8400", VA = "0x1841D9E00")]
	public void OLIIMNGMEME(PFFNEOFKMIJ OGIOFICPCOK, bool KOPNNMKHPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x41D8CF0", Offset = "0x41D72F0", VA = "0x1841D8CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41D8CC0", Offset = "0x41D72C0", VA = "0x1841D8CC0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NPCPNMFEDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct AADIOKMKGMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<CJMPPCLJLPE> BKOFDJGFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> BAFPCHPGMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 EFIAJFLJHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> HEJMBEMECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> AIBMNFOFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool GPEDFAEJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float LBNOBIOAFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float NMPOGJLAOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float ICNAPOOIPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41C9B20", Offset = "0x41C8120", VA = "0x1841C9B20")]
	public AADIOKMKGMO(NPCPNMFEDNL OBKJCGHFNGC, Vector3 EFIAJFLJHPD, bool GPEDFAEJAAE, float LBNOBIOAFDN, float NMPOGJLAOGO, float ICNAPOOIPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x41C9680", Offset = "0x41C7C80", VA = "0x1841C9680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LBKOJFHLGEN : EHLGKNDONGG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds GODKIDCOFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DHPPIAAJBJB ACOBFGEFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CBDDFBINNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<LBKOJFHLGEN> HHCAAMAPGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public CBDDFBINNBH COLFLONKFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public CBDDFBINNBH OJKNAGPFBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public CBDDFBINNBH APKBBKCKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int MHDCFAJEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds LKAHHEMJOBH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x41CCD90", Offset = "0x41CB390", VA = "0x1841CCD90")]
	public CBDDFBINNBH(List<LBKOJFHLGEN> HHCAAMAPGPK, [Optional] CBDDFBINNBH COLFLONKFJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ALMPPELKLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<CBDDFBINNBH> GOGBGMMFNFA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public CBDDFBINNBH MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41CB820", Offset = "0x41C9E20", VA = "0x1841CB820")]
	public ALMPPELKLDK(CBDDFBINNBH PFOHKHPLBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AGDMDJOHJEI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BNPLNEIIMEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int EEKOODIKLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int JKPMDBCJAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int KPELOEFBHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int KAKLMGCGFDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FAOBACGMMHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int ACJIDOOCDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float AJKDHJOJNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<LBKOJFHLGEN> HHCAAMAPGPK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JLOFKMOOGDF
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
	private BNPLNEIIMEO FCDHBHNDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int GKMFAJALHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int NKDMBMAIGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int CPKJECPONJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float CNKLEJPEOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float JCAEGJGOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<CBDDFBINNBH> LICPPKLDIDA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ALMPPELKLDK GCFLOOHKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x41CB7C0", Offset = "0x41C9DC0", VA = "0x1841CB7C0")]
	public AGDMDJOHJEI(int NKDMBMAIGPH, int CPKJECPONJE, float CNKLEJPEOPJ, int GKMFAJALHIG, float JCAEGJGOAAF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x41C9BF0", Offset = "0x41C81F0", VA = "0x1841C9BF0")]
	public void FHLCAJJCLBJ(List<LBKOJFHLGEN> HHCAAMAPGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x41CA6C0", Offset = "0x41C8CC0", VA = "0x1841CA6C0")]
	public bool LKNPDJHDKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x41CA730", Offset = "0x41C8D30", VA = "0x1841CA730")]
	private float MNFIEDIMNLJ(Vector3 EEIGLGPCDBO, Vector3 GPKLECHELAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41CA840", Offset = "0x41C8E40", VA = "0x1841CA840")]
	private float MNFIEDIMNLJ(Vector3 KMCJMFPOINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x41C9DB0", Offset = "0x41C83B0", VA = "0x1841C9DB0")]
	private bool KFIMCJCJCIH(CBDDFBINNBH DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x41CA8E0", Offset = "0x41C8EE0", VA = "0x1841CA8E0")]
	private FAOBACGMMHG NOKCJAJDPBC(List<LBKOJFHLGEN> PFHAAIKHHJH, JLOFKMOOGDF PNLMCDIBOLC)
	{
		return default(FAOBACGMMHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x41CB430", Offset = "0x41C9A30", VA = "0x1841CB430")]
	private void PMCGHJMLKPL(List<LBKOJFHLGEN> HHCAAMAPGPK, Vector3[] MJJFGBIJOHP, Vector3[] IHBNPPMEEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CMEDGEBGEBG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41CCE30", Offset = "0x41CB430", VA = "0x1841CCE30")]
	public static Bounds EKCPCNGHLIP(List<LBKOJFHLGEN> HHCAAMAPGPK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41CCFE0", Offset = "0x41CB5E0", VA = "0x1841CCFE0")]
	public static int LGDNDEGFFDD(List<LBKOJFHLGEN> HHCAAMAPGPK, POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NJDAKPMJAJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private GMPJPDMCHBE IPAEFCKILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private GMPJPDMCHBE IHEMEOBEOJC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static GMPJPDMCHBE HKJLBDMDAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FPCNMIJJHDP LOBBMILCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MINNFNFMJEB PPCPOJNGOMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BJOELKKLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83A090", Offset = "0x838690", VA = "0x18083A090")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83A0B0", Offset = "0x8386B0", VA = "0x18083A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HENGMGJFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x69E1E0", Offset = "0x69C7E0", VA = "0x18069E1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x41D8BC0", Offset = "0x41D71C0", VA = "0x1841D8BC0")]
	[NAOLMNKNAMK(DKCHBDLNPEE.ExitingPlayMode, 0)]
	private void KOJKAJHDHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x41D7B90", Offset = "0x41D6190", VA = "0x1841D7B90")]
	public void GELLHDINKCG(PFFNEOFKMIJ.LDFNAGEIOID BKOFDJGFENC, Transform FOMIJDEBKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x41D85B0", Offset = "0x41D6BB0", VA = "0x1841D85B0")]
	public void JKKEFOAMGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x41D7B20", Offset = "0x41D6120", VA = "0x1841D7B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x41D7AE0", Offset = "0x41D60E0", VA = "0x1841D7AE0")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x41D8C30", Offset = "0x41D7230", VA = "0x1841D8C30")]
	public NJDAKPMJAJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KAJAGDGENKE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	KPGBNLPOLND GHPIIIMPJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FAENLNEJNFO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 BPLGKLMHCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GNANNLFBEEB
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(BJHOOGFBDGF HPDDLEBBPDJ, CancellationToken CMOIBOJIACL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FKMPEFALPCD
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKMPEFALPCD LAHALOJBENP(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKMPEFALPCD HLNPNBAOBBN(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKMPEFALPCD LBAPBAGNNHI(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKMPEFALPCD JMOJJNENGBL(Action BKCLKIJOKLP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class EKHDBGLFICN : FKMPEFALPCD
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KNKILFMJHHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public EKHDBGLFICN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
				public KNKILFMJHHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x41D2ED0", Offset = "0x41D14D0", VA = "0x1841D2ED0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x41D2F20", Offset = "0x41D1520", VA = "0x1841D2F20")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x41D2F70", Offset = "0x41D1570", VA = "0x1841D2F70")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> KDCNBPADJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action FKAHPDKCMML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action KPJMOKCIIPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private LICOPOJIKBN KNPFNLMMMNC;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action BPLHCAEFDDL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x673F20", Offset = "0x672520", VA = "0x180673F20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action DGNHHFNLFEI
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x24E7F80", Offset = "0x24E6580", VA = "0x1824E7F80", Slot = "4")]
			public FKMPEFALPCD LAHALOJBENP(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2025F90", Offset = "0x2024590", VA = "0x182025F90", Slot = "5")]
			public FKMPEFALPCD HLNPNBAOBBN(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x20C7FE0", Offset = "0x20C65E0", VA = "0x1820C7FE0", Slot = "6")]
			public FKMPEFALPCD LBAPBAGNNHI(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x27BD660", Offset = "0x27BBC60", VA = "0x1827BD660", Slot = "7")]
			public FKMPEFALPCD JMOJJNENGBL(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
			public EKHDBGLFICN(Func<JobHandle> BHFKDHGKMLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x41CF790", Offset = "0x41CDD90", VA = "0x1841CF790")]
			public void OBHHENOOAOJ(Action BAIEKHIKCGG, Action FHPKEGMMJHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x41CF630", Offset = "0x41CDC30", VA = "0x1841CF630")]
			public void MNHCGCIEOKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class LAHLLBNHING
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FKMPEFALPCD jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public LAHLLBNHING()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x41D5FB0", Offset = "0x41D45B0", VA = "0x1841D5FB0")]
			internal bool <Remove>b__0(EKHDBGLFICN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PCENLBAHBDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public EKHDBGLFICN newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public PCENLBAHBDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x41DA4E0", Offset = "0x41D8AE0", VA = "0x1841DA4E0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<EKHDBGLFICN> DJCJEADNBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<EKHDBGLFICN> PKAPBDDLJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private JPGLPKCHKEM HBAPDMHJLAB;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MBHNFDOCNFI JFAFFCMDOIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41D2200", Offset = "0x41D0800", VA = "0x1841D2200")]
		public FKMPEFALPCD Add(Func<JobHandle> BHFKDHGKMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x41D24A0", Offset = "0x41D0AA0", VA = "0x1841D24A0")]
		public void Remove(FKMPEFALPCD BJOELKKLLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x41D2320", Offset = "0x41D0920", VA = "0x1841D2320", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x41D2620", Offset = "0x41D0C20", VA = "0x1841D2620")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x41D27F0", Offset = "0x41D0DF0", VA = "0x1841D27F0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x41D2310", Offset = "0x41D0910", VA = "0x1841D2310")]
		[CompilerGenerated]
		private void KHELHPBPDFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LICOPOJIKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LICOPOJIKBN LAHALOJBENP(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LICOPOJIKBN NENIJEOINOO(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LICOPOJIKBN JMOJJNENGBL(Action BKCLKIJOKLP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class HKBCGJLKECG : LICOPOJIKBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle GIMMFIDPNIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action FKAHPDKCMML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action LBGNGCAAOHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action DGNHHFNLFEI;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool EHMINPKKADE
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x41D21B0", Offset = "0x41D07B0", VA = "0x1841D21B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2025F90", Offset = "0x2024590", VA = "0x182025F90", Slot = "4")]
			public LICOPOJIKBN LAHALOJBENP(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x20C7FE0", Offset = "0x20C65E0", VA = "0x1820C7FE0", Slot = "5")]
			public LICOPOJIKBN NENIJEOINOO(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x27BD660", Offset = "0x27BBC60", VA = "0x1827BD660", Slot = "6")]
			public LICOPOJIKBN JMOJJNENGBL(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC013E0", VA = "0x180C02DE0")]
			public HKBCGJLKECG(JobHandle CMJNCGOCEKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x41D2170", Offset = "0x41D0770", VA = "0x1841D2170")]
			public void AKPIIOLAJBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x41D21C0", Offset = "0x41D07C0", VA = "0x1841D21C0")]
			public void MNHCGCIEOKP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<HKBCGJLKECG> OJKNKAOKOAK;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x41D2C70", Offset = "0x41D1270", VA = "0x1841D2C70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x41D28B0", Offset = "0x41D0EB0", VA = "0x1841D28B0")]
		public LICOPOJIKBN Add(JobHandle CMJNCGOCEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x41D2B80", Offset = "0x41D1180", VA = "0x1841D2B80")]
		public void Remove(LICOPOJIKBN BJOELKKLLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x41D2A20", Offset = "0x41D1020", VA = "0x1841D2A20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x41D2940", Offset = "0x41D0F40", VA = "0x1841D2940")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x41D2D80", Offset = "0x41D1380", VA = "0x1841D2D80")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x41D1B80", Offset = "0x41D0180", VA = "0x1841D1B80")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x41D1C80", Offset = "0x41D0280", VA = "0x1841D1C80")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
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
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
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
