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
				[Cpp2IlInjected.Address(RVA = "0x5FF59E0", Offset = "0x5FF4DE0", VA = "0x185FF59E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x13C80E0", Offset = "0x13C74E0", VA = "0x1813C80E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5FF59A0", Offset = "0x5FF4DA0", VA = "0x185FF59A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FECF10", Offset = "0x5FEC310", VA = "0x185FECF10")]
		public LODSettings NBGIHAMKFKD(ECCMJPDPIEF DBHMHAHLCPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FECF20", Offset = "0x5FEC320", VA = "0x185FECF20")]
		public int NFKCKKNADOJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FECE70", Offset = "0x5FEC270", VA = "0x185FECE70")]
		public int BAGDEMECHKE(bool BECEGMLHIDH, Vector3 IGIJJMEBLJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FECF40", Offset = "0x5FEC340", VA = "0x185FECF40")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GFMOACHGEKD
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
public interface ECCPCGEPLFM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAFCMLOHACH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NNPIHAFFGAO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FHACKJKIHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<ANMBKNFOENA> NLOACFLEBAB
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
	void UpdateClusterDistances(Vector3 KGGMKBFJBJC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(IOBPIOAJGIN LHKDOCKFFOG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANMBKNFOENA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int MPECGNGBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int AKFBHHKGLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DBLNGHLDPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ACFFHAIMAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte IGGCAEFAFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OFDIBONHCOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IKMHBHHMEDH
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MHKMLECEPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OFDIBONHCOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PHNJPJKEIOH<string>.DNICKHEMCOE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5A00", Offset = "0x5FF4E00", VA = "0x185FF5A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6190", Offset = "0x5FF5590", VA = "0x185FF6190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AAACDONDDEN : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OFDIBONHCOE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public AAACDONDDEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9510", Offset = "0x5FE8910", VA = "0x185FE9510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9590", Offset = "0x5FE8990", VA = "0x185FE9590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CNAEKNLIHKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OFDIBONHCOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PHNJPJKEIOH<string>.DNICKHEMCOE worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PHNJPJKEIOH<string>.DNICKHEMCOE <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB5D0", Offset = "0x5FEA9D0", VA = "0x185FEB5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FECE10", Offset = "0x5FEC210", VA = "0x185FECE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EKBMIMFKHOO : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OFDIBONHCOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public EKBMIMFKHOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5FEE560", Offset = "0x5FED960", VA = "0x185FEE560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF240", Offset = "0x5FEE640", VA = "0x185FEF240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int DGDPJOBBBCE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan DMNDIGPOIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer EAPDFKCMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter POPPDDGDDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject GDCHJFLDBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject LIPCAAEFBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public HGPDCHHKFLF ECFJBLGEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IOBPIOAJGIN> HCKAFGPGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IOBPIOAJGIN> NHJPJCIDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<IOBPIOAJGIN> JOBCNMELNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HEKGOGEOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IKMHBHHMEDH DGDBIEOMNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<NNPIHAFFGAO>[] BHMHEPBHDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<ANMBKNFOENA>[] EBKCLKGGBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource PCKBFNPMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool OJAJDBGDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ICANAFEODIJ MIKKACHCLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ICANAFEODIJ EIJBPPNFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NCOLOFNNEGH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static OFDIBONHCOE GHPBOHCOJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IPIOJFJJAFB KGNBIIOJEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PIBBJDPINAM MFIEJELCHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour ADIHCPCDKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material CDCBBNKOIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<ECCPCGEPLFM> KHMOIIDHEOK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig BKAAPAFDKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 MPNLKJBKGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B1230", Offset = "0x7B0630", VA = "0x1807B1230")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E30", Offset = "0x7B0230", VA = "0x1807B0E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private IKMHBHHMEDH HPCAJAPJEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1FBD0", Offset = "0xA1EFD0", VA = "0x180A1FBD0")]
		get
		{
			return default(IKMHBHHMEDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FF8B60", Offset = "0x5FF7F60", VA = "0x185FF8B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static OFDIBONHCOE GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF84D0", Offset = "0x5FF78D0", VA = "0x185FF84D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool NNCLDILDHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FF7690", Offset = "0x5FF6A90", VA = "0x185FF7690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OHJDAFLGFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FF8410", Offset = "0x5FF7810", VA = "0x185FF8410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> GEOPIACNNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF70C0", Offset = "0x5FF64C0", VA = "0x185FF70C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF8A20", Offset = "0x5FF7E20", VA = "0x185FF8A20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PBIMJPOLKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9830", Offset = "0x5FF8C30", VA = "0x185FF9830")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6F90", Offset = "0x5FF6390", VA = "0x185FF6F90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9A70", Offset = "0x5FF8E70", VA = "0x185FF9A70")]
	public OFDIBONHCOE(IPIOJFJJAFB KGNBIIOJEDA, PIBBJDPINAM MFIEJELCHNN, ClusterLODConfig DAAAFDPJPHK, MonoBehaviour ADIHCPCDKEF, Material CDCBBNKOIND, ClusterMeshRenderer EAPDFKCMHOA, MeshFilter POPPDDGDDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7500", Offset = "0x5FF6900", VA = "0x185FF7500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8520", Offset = "0x5FF7920", VA = "0x185FF8520")]
	public static void IHFGNMLDFHK(Vector3 CPKILJBKIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9760", Offset = "0x5FF8B60", VA = "0x185FF9760")]
	private void MPDHCJOHEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8950", Offset = "0x5FF7D50", VA = "0x185FF8950")]
	private void KFLADIIHIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7FF0", Offset = "0x5FF73F0", VA = "0x185FF7FF0")]
	private void GIIKHJNNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7990", Offset = "0x5FF6D90", VA = "0x185FF7990")]
	public void GHDBPJCMFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8620", Offset = "0x5FF7A20", VA = "0x185FF8620")]
	[AsyncStateMachine(typeof(MHKMLECEPOO))]
	public Task IPGGMPLEKMA(PHNJPJKEIOH<string>.DNICKHEMCOE LJJPIIKFGCC, CancellationToken AIPMLFMOPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9980", Offset = "0x5FF8D80", VA = "0x185FF9980")]
	[IteratorStateMachine(typeof(AAACDONDDEN))]
	private IEnumerator<ALCMBHLDKFG> PIEIBOKNELB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8140", Offset = "0x5FF7540", VA = "0x185FF8140")]
	[AsyncStateMachine(typeof(CNAEKNLIHKE))]
	private Task HBNANMPMIKK(PHNJPJKEIOH<string>.DNICKHEMCOE PJAJAHAHDKE, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7790", Offset = "0x5FF6B90", VA = "0x185FF7790")]
	public void FNDNADILHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8AE0", Offset = "0x5FF7EE0", VA = "0x185FF8AE0")]
	public void LBHMMKLMADO(IEnumerable<NNPIHAFFGAO> CMOPGPNKGGI, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7180", Offset = "0x5FF6580", VA = "0x185FF7180")]
	public void CLAENNGLECO(IEnumerable<NNPIHAFFGAO> CMOPGPNKGGI, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8E00", Offset = "0x5FF8200", VA = "0x185FF8E00")]
	public List<ClusterMeshRenderer> MJLAOGHHPNB(List<IOBPIOAJGIN> JAMOKHHOAMF, NKGPPJOONDJ DHHBNGOGOPD, GFMOACHGEKD EDCBCPMMAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8260", Offset = "0x5FF7660", VA = "0x185FF8260")]
	public void HDDENDMALNM(ECCPCGEPLFM PFPGBLBDBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FF98E0", Offset = "0x5FF8CE0", VA = "0x185FF98E0")]
	public bool OEGFCCOIHAE(ECCPCGEPLFM PFPGBLBDBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8740", Offset = "0x5FF7B40", VA = "0x185FF8740")]
	public void JCMANJCCJEG(IOBPIOAJGIN ANOCJHGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7610", Offset = "0x5FF6A10", VA = "0x185FF7610")]
	public void EBBLKBOIBKF(ANMBKNFOENA NDGLIPKKMHI, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7040", Offset = "0x5FF6440", VA = "0x185FF7040")]
	public void BNKGHJLLDNI(ANMBKNFOENA NDGLIPKKMHI, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FF82C0", Offset = "0x5FF76C0", VA = "0x185FF82C0")]
	private void HHMENICDKKD(Vector3 KGGMKBFJBJC, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9600", Offset = "0x5FF8A00", VA = "0x185FF9600")]
	private void MKGJOCPBLJH(Vector3 KGGMKBFJBJC, GFMOACHGEKD EDCBCPMMAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7480", Offset = "0x5FF6880", VA = "0x185FF7480")]
	[IteratorStateMachine(typeof(EKBMIMFKHOO))]
	private IEnumerator<ALCMBHLDKFG> DIGFIGMJMOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8C90", Offset = "0x5FF8090", VA = "0x185FF8C90")]
	private int LNJMGGCAFFJ(int AHDNEIKOMIB, int DECMKHADGLD, List<ANMBKNFOENA> KJJAIBELEJB, byte DBHMHAHLCPM, int GAJHMAEIGLL, float ENGBNOAFPBE = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FF87A0", Offset = "0x5FF7BA0", VA = "0x185FF87A0")]
	public void JJHPGEAJNEC(IOBPIOAJGIN LHKDOCKFFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9940", Offset = "0x5FF8D40", VA = "0x185FF9940")]
	public bool PEAGBHPADDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A60", Offset = "0x7F4E60", VA = "0x1807F5A60")]
	public Material AJGEDOIMFPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF97F0", Offset = "0x5FF8BF0", VA = "0x185FF97F0")]
	public int NFKCKKNADOJ()
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct NFHFBLJJNPD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> HDAGLFHKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> OPIIKILHMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> CEEMEFDHFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> IMDJLPEHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> BFNLJKMKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> BGEBJBDEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> BOAKOEMCEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 MGHLFEFNFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float MCGDCDKOFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> NPKEHNMOFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> AILKPKJPEJC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6ED0", Offset = "0x5FF62D0", VA = "0x185FF6ED0")]
	public NFHFBLJJNPD(IIBGMLIJNCJ FEBNKEJJFPJ, NativeList<float3> BOAKOEMCEAN, NativeParallelMultiHashMap<int, int> NPKEHNMOFEI, NativeArray<int> AILKPKJPEJC, Vector3 MGHLFEFNFGM, float MCGDCDKOFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6C00", Offset = "0x5FF6000", VA = "0x185FF6C00")]
	private int KLFCMPHOCOM(float3 KGGMKBFJBJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6C60", Offset = "0x5FF6060", VA = "0x185FF6C60")]
	private int LOAPJOGFOIG(int FPJGJJLGENP, int GPGELODKPOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FF67D0", Offset = "0x5FF5BD0", VA = "0x185FF67D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MJPCBPOFHDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> NPKEHNMOFEI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> AILKPKJPEJC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int OPGFPCMFNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> ECBAIJNGBKI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FF62D0", Offset = "0x5FF56D0", VA = "0x185FF62D0")]
	public void GKILOBOBKLP(int DIEKCCMMDCD, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FF61F0", Offset = "0x5FF55F0", VA = "0x185FF61F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public MJPCBPOFHDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct DCCLKKOOBCG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> LABEJGGLFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> HDDMBNKBJFD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE510", Offset = "0x5FED910", VA = "0x185FEE510")]
	public DCCLKKOOBCG(MJPCBPOFHDO OLKJJPDGGGM, IIBGMLIJNCJ FEBNKEJJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE460", Offset = "0x5FED860", VA = "0x185FEE460", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PINAOODJNBK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> NGOJEOLECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> PGCCLCFMPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> EJPLKLAFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> CPJGDDJBBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> KABFNOBMKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> ECBAIJNGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> LABEJGGLFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> ACKEFJGLDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> AGPIMMBGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> OOGHAGFKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> NONKDMMHOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> BBCMIPDNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> FAJBAFJGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float PMLPLKEIMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float IJNMGKILDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 BMNCOMBKEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float CANJHPDIOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float MGNCKBCCOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float FIOIECEGGAH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFBDC0", Offset = "0x5FFB1C0", VA = "0x185FFBDC0")]
	public PINAOODJNBK(MJPCBPOFHDO PFMMDDDMHAB, IIBGMLIJNCJ FEBNKEJJFPJ, IIBGMLIJNCJ INJMEBGDELL, float MGNCKBCCOGO, float FIOIECEGGAH, Vector3 BMNCOMBKEBN, float CANJHPDIOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB7F0", Offset = "0x5FFABF0", VA = "0x185FFB7F0")]
	private float3 IPBHHIKIFEM(int FPJGJJLGENP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA830", Offset = "0x5FF9C30", VA = "0x185FFA830")]
	private void CHLPJBFGJEL(int FPJGJJLGENP, [Out] float3 HPOMOMHCALJ, [Out] float3 MMEMLNKIBOF, [Out] float4 ELMNDFOODHN, [Out] float4 ECFPFOJAHEH, [Out] float2 GEDENAEKCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB9F0", Offset = "0x5FFADF0", VA = "0x185FFB9F0")]
	private int LBFIDDECEOE(int GNGAKMOKFLI, int HKNFLBOFOOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFAA10", Offset = "0x5FF9E10", VA = "0x185FFAA10")]
	private void CPNAGOJKHLA(int GNGAKMOKFLI, int HKNFLBOFOOO, int AJNPHGDNHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB8A0", Offset = "0x5FFACA0", VA = "0x185FFB8A0")]
	private bool JFPMAONNMOF(int GNGAKMOKFLI, int HKNFLBOFOOO, float KELLCEEODLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FFBCE0", Offset = "0x5FFB0E0", VA = "0x185FFBCE0")]
	private bool NMLCAGPKEAD(int GNGAKMOKFLI, int HKNFLBOFOOO, int AJNPHGDNHDL, float KELLCEEODLF, bool MDGDNPEKAAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB590", Offset = "0x5FFA990", VA = "0x185FFB590")]
	private bool FLFGMOIIGDE(int GNGAKMOKFLI, int HKNFLBOFOOO, int AJNPHGDNHDL, float KELLCEEODLF, bool MDGDNPEKAAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FFBDA0", Offset = "0x5FFB1A0", VA = "0x185FFBDA0")]
	private void OJPNEFLIDNE(int GNGAKMOKFLI, int HKNFLBOFOOO, int AJNPHGDNHDL, [Out] int PNFKIDIBFNP, [Out] int NFLOGHPEDBJ, [Out] int HNBOOIKBMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FFAC10", Offset = "0x5FFA010", VA = "0x185FFAC10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LAADHDMIDBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FIOFNGNLMOL : IDisposable, ANMBKNFOENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds FEBMGBNBBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<IOBPIOAJGIN> JAMOKHHOAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 OKEKLOGAMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 NPKGGBAGAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int JGPLFDNBCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IIBGMLIJNCJ DJDOFHOPFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MJPCBPOFHDO JCGMDKBBDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform DHHBNGOGOPD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int LCDMLGIOMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5FEF5A0", Offset = "0x5FEE9A0", VA = "0x185FEF5A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh CBBFPGFPBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MPIAIOHDHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float DBLNGHLDPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1072920", Offset = "0x1071D20", VA = "0x181072920", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x56AFBD0", Offset = "0x56AEFD0", VA = "0x1856AFBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte IGGCAEFAFBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3950", Offset = "0xCD2D50", VA = "0x180CD3950")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCD0180", Offset = "0xCCF580", VA = "0x180CD0180", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MPECGNGBHIF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9ADCC0", Offset = "0x9AD0C0", VA = "0x1809ADCC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9AC700", Offset = "0x9ABB00", VA = "0x1809AC700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int AKFBHHKGLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCAECF0", Offset = "0xCAE0F0", VA = "0x180CAECF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCAE660", Offset = "0xCADA60", VA = "0x180CAE660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ACFFHAIMAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5FEF790", Offset = "0x5FEEB90", VA = "0x185FEF790", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF290", Offset = "0x5FEE690", VA = "0x185FEF290")]
		public void CBCJJMMHADM(ECCMJPDPIEF DBHMHAHLCPM, [Out] int LCIPOMAKBKD, [Out] int EDDFJNNBDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF840", Offset = "0x5FEEC40", VA = "0x185FEF840")]
		public void MEMHJIINJJC(ECCMJPDPIEF DBHMHAHLCPM, KILMAMMLMFP POCCMIKDLPB, int DHOIJHBLAFE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF500", Offset = "0x5FEE900", VA = "0x185FEF500")]
		public void CGDAPINONJI(Mesh FEBNKEJJFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF7B0", Offset = "0x5FEEBB0", VA = "0x185FEF7B0")]
		public void FFMOCAKIOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF5E0", Offset = "0x5FEE9E0", VA = "0x185FEF5E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFA10", Offset = "0x5FEEE10", VA = "0x185FEFA10")]
		public FIOFNGNLMOL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds FEBMGBNBBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<FIOFNGNLMOL> MJIFNKFELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LFALFICEEEM MIFMDBIJGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer EOKDDHDHEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int MGCAPNELAOI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh FGOOIBKPIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A26A0", Offset = "0x7A1AA0", VA = "0x1807A26A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EFKOJIBGPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7EC380", Offset = "0x7EB780", VA = "0x1807EC380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7EC910", Offset = "0x7EBD10", VA = "0x1807EC910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int FHACKJKIHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3A30", Offset = "0x5FF2E30", VA = "0x185FF3A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF38B0", Offset = "0x5FF2CB0", VA = "0x185FF38B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3A80", Offset = "0x5FF2E80", VA = "0x185FF3A80")]
	public int IIONFAIIAAH(int KNEOFLIFCDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF36D0", Offset = "0x5FF2AD0", VA = "0x185FF36D0")]
	public void BNNEIJFPMEN(GDCDBIGPHMH MBCPHKJALCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2F40", Offset = "0x5FF2340", VA = "0x185FF2F40")]
	public void BLLIPKJCMJA(Transform EAIDDIJMLKJ, bool DNDMLOFFIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4350", Offset = "0x5FF3750", VA = "0x185FF4350")]
	public bool PNGCEHHFPII(bool ALBCGMPKDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3D20", Offset = "0x5FF3120", VA = "0x185FF3D20")]
	public void PICDOHIIGPF(Transform DHHBNGOGOPD, bool DNDMLOFFIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3AB0", Offset = "0x5FF2EB0", VA = "0x185FF3AB0")]
	public bool JJHPGEAJNEC(IOBPIOAJGIN LHKDOCKFFOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4510", Offset = "0x5FF3910", VA = "0x185FF4510")]
	public LAADHDMIDBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HGPDCHHKFLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<LAADHDMIDBM.FIOFNGNLMOL> IEEMGEBBIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private CIFADHHHKKO GHIELEEJIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<LAADHDMIDBM.FIOFNGNLMOL> OBGKAABDIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int MHHHLHBIALB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFDD0", Offset = "0x5FEF1D0", VA = "0x185FEFDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFC50", Offset = "0x5FEF050", VA = "0x185FEFC50")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFB90", Offset = "0x5FEEF90", VA = "0x185FEFB90")]
	public void AFPNFDHLNMK(LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC, Transform DHHBNGOGOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFE50", Offset = "0x5FEF250", VA = "0x185FEFE50")]
	public void JJHPGEAJNEC(LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0030", Offset = "0x5FEF430", VA = "0x185FF0030")]
	private LAADHDMIDBM.FIOFNGNLMOL LLODDOOLECM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF03F0", Offset = "0x5FEF7F0", VA = "0x185FF03F0")]
	private bool PCDFPMKLLCO(LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFD40", Offset = "0x5FEF140", VA = "0x185FEFD40")]
	private void DFNAEHEIMOH(LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFDA0", Offset = "0x5FEF1A0", VA = "0x185FEFDA0")]
	public bool DGPJAJDEBJD(LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0170", Offset = "0x5FEF570", VA = "0x185FF0170")]
	public bool NEPLKJNDANP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFCD0", Offset = "0x5FEF0D0", VA = "0x185FEFCD0")]
	private LAADHDMIDBM.FIOFNGNLMOL DFBOIIJMFLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0490", Offset = "0x5FEF890", VA = "0x185FF0490")]
	public HGPDCHHKFLF()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PFMABKNFIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int AJPBFLADKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int AOLNEFAPNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float GKAHNKAHFMO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<LAADHDMIDBM> GAIECOFAFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA7E0", Offset = "0x5FF9BE0", VA = "0x185FFA7E0")]
	public PFMABKNFIIL(int AJPBFLADKGN, int AOLNEFAPNCM, float BAICEPIHGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA440", Offset = "0x5FF9840", VA = "0x185FFA440")]
	public void AJKACIFJFNH(ACFJGPIAPHK DMEFOJGGGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA4F0", Offset = "0x5FF98F0", VA = "0x185FFA4F0")]
	private int BKGKMNKDFIH(GDCDBIGPHMH DKBEBHEBAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA230", Offset = "0x5FF9630", VA = "0x185FFA230")]
	private void AJKACIFJFNH(GDCDBIGPHMH DKBEBHEBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA5A0", Offset = "0x5FF99A0", VA = "0x185FFA5A0")]
	private void HGIDJFMGEKC(GDCDBIGPHMH DKBEBHEBAJO, LAADHDMIDBM PCNIECDKJJH)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, NNPIHAFFGAO
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NAEDPCBLPLA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
			[DebuggerHidden]
			public NAEDPCBLPLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5FF64D0", Offset = "0x5FF58D0", VA = "0x185FF64D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5FF6690", Offset = "0x5FF5A90", VA = "0x185FF6690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5FF65E0", Offset = "0x5FF59E0", VA = "0x185FF65E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5FF65E0", Offset = "0x5FF59E0", VA = "0x185FF65E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int FHACKJKIHAK
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5FEE400", Offset = "0x5FED800", VA = "0x185FEE400", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<ANMBKNFOENA> NLOACFLEBAB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5FEE3E0", Offset = "0x5FED7E0", VA = "0x185FEE3E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> MJIFNKFELMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public LAADHDMIDBM FGOOIBKPIIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GFMOACHGEKD HIPKOEGMIKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(GFMOACHGEKD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7A9510", Offset = "0x7A8910", VA = "0x1807A9510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool LINAPDPLANH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x18050D0", Offset = "0x18044D0", VA = "0x1818050D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FECFA0", Offset = "0x5FEC3A0", VA = "0x185FECFA0")]
		public static ClusterMeshRenderer Create(LAADHDMIDBM FEBNKEJJFPJ, ClusterMeshRenderer EAPDFKCMHOA, MeshFilter POPPDDGDDNM, NKGPPJOONDJ DHHBNGOGOPD, GFMOACHGEKD EDCBCPMMAFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FED110", Offset = "0x5FEC510", VA = "0x185FED110", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FED960", Offset = "0x5FECD60", VA = "0x185FED960", Slot = "9")]
		public bool TryRemoveClusterLODComponent(IOBPIOAJGIN LHKDOCKFFOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FED710", Offset = "0x5FECB10", VA = "0x185FED710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FED380", Offset = "0x5FEC780", VA = "0x185FED380")]
		public void Init(LAADHDMIDBM FEBNKEJJFPJ, MeshFilter POPPDDGDDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FED170", Offset = "0x5FEC570", VA = "0x185FED170")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FEDA20", Offset = "0x5FECE20", VA = "0x185FEDA20", Slot = "7")]
		public void UpdateClusterDistances(Vector3 KGGMKBFJBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FEDCD0", Offset = "0x5FED0D0", VA = "0x185FEDCD0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FED300", Offset = "0x5FEC700", VA = "0x185FED300")]
		[IteratorStateMachine(typeof(NAEDPCBLPLA))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FED7A0", Offset = "0x5FECBA0", VA = "0x185FED7A0")]
		public void SetupTagAndLayer(string LALDDLOBIGN, int EDCBCPMMAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FED780", Offset = "0x5FECB80", VA = "0x185FED780")]
		public bool Remove(IOBPIOAJGIN LHKDOCKFFOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DCNHGBILNII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FMPGEDJHDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int ACGCEBPHGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int EDDFJNNBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LCIPOMAKBKD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE540", Offset = "0x5FED940", VA = "0x185FEE540")]
	public DCNHGBILNII(int ACGCEBPHGCG, int EDDFJNNBDBG, int FMPGEDJHDKB, int LCIPOMAKBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LFALFICEEEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> HDAGLFHKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> ECBAIJNGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> BGEBJBDEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<DCNHGBILNII> ALIGIPGJKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> IFJDJMNOHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> FHJKCFAFLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> MIOHFHPMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle POBBNOHNBCI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OOIEMCANFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA73A0", Offset = "0xAA67A0", VA = "0x180AA73A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC70E90", Offset = "0xC70290", VA = "0x180C70E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4600", Offset = "0x5FF3A00", VA = "0x185FF4600")]
	public void DLFOKGLGICG(IIBGMLIJNCJ HHNJGLLPNAL, NativeList<DCNHGBILNII> ALIGIPGJKPA, float LFBOEHOBPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5570", Offset = "0x5FF4970", VA = "0x185FF5570")]
	public void JAKCAEPFIGF(Transform DHHBNGOGOPD, bool DNDMLOFFIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5800", Offset = "0x5FF4C00", VA = "0x185FF5800")]
	public void PNGCEHHFPII(LAADHDMIDBM EOKDDHDHEIH, bool ALBCGMPKDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5460", Offset = "0x5FF4860", VA = "0x185FF5460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FF45D0", Offset = "0x5FF39D0", VA = "0x185FF45D0")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public LFALFICEEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct AEGGJNLFMBA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> HDAGLFHKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> ECBAIJNGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<DCNHGBILNII> CMINEOCKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> IFJDJMNOHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 BMNCOMBKEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> FHJKCFAFLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> MIOHFHPMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool DNDMLOFFIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float OEEGKJCPFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float KKAMJHKPGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float KBILDKHEIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> BGEBJBDEGJI;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9BC0", Offset = "0x5FE8FC0", VA = "0x185FE9BC0")]
	public AEGGJNLFMBA(LFALFICEEEM DNHHCALGBBO, Vector3 BMNCOMBKEBN, bool DNDMLOFFIIH, float OEEGKJCPFMK, float KKAMJHKPGFC, float KBILDKHEIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5FE96B0", Offset = "0x5FE8AB0", VA = "0x185FE96B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IOBPIOAJGIN : KEHANMPPLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds HFHKKCNCDOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GDCDBIGPHMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<IOBPIOAJGIN> JAMOKHHOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public GDCDBIGPHMH EMDODFFCGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public GDCDBIGPHMH IHGLNGAEJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public GDCDBIGPHMH LINLOOPKBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int LCIPOMAKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds FEBMGBNBBPI;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFB10", Offset = "0x5FEEF10", VA = "0x185FEFB10")]
	public GDCDBIGPHMH(List<IOBPIOAJGIN> JAMOKHHOAMF, [Optional] GDCDBIGPHMH EMDODFFCGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ACFJGPIAPHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<GDCDBIGPHMH> ACNGPLEIHKK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GDCDBIGPHMH OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE95E0", Offset = "0x5FE89E0", VA = "0x185FE95E0")]
	public ACFJGPIAPHK(GDCDBIGPHMH DHHBNGOGOPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JAOGKKGNDLO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct KKLKHNFILGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int BPKPFFNGBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int GFLNOGIDLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int PGPCLOOJDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JMCEOMLPBDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct ODHHACMFLLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int MBDHDOKIEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float GJFBALIJKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<IOBPIOAJGIN> JAMOKHHOAMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum OPAFMAPDCKD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private KKLKHNFILGG LMKDLJDCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int IILHBICPNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int AJPBFLADKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int AOLNEFAPNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float BAICEPIHGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float OCPEMAGJIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<GDCDBIGPHMH> HPGDOEFMGCM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public ACFJGPIAPHK AHBCMDNCAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FF20A0", Offset = "0x5FF14A0", VA = "0x185FF20A0")]
	public JAOGKKGNDLO(int AJPBFLADKGN, int AOLNEFAPNCM, float BAICEPIHGID, int IILHBICPNLK, float OCPEMAGJIEP = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0BE0", Offset = "0x5FEFFE0", VA = "0x185FF0BE0")]
	public void KKHGMBAMHCF(List<IOBPIOAJGIN> JAMOKHHOAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0700", Offset = "0x5FEFB00", VA = "0x185FF0700")]
	public bool CBDCOMIHKGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0B70", Offset = "0x5FEFF70", VA = "0x185FF0B70")]
	private float DHKMBPJNJFC(Vector3 MOPJGAAPLNL, Vector3 MFCGJJICHPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0BC0", Offset = "0x5FEFFC0", VA = "0x185FF0BC0")]
	private float DHKMBPJNJFC(Vector3 HFPFBPPBALK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FF18D0", Offset = "0x5FF0CD0", VA = "0x185FF18D0")]
	private bool MMEPPALCMEA(GDCDBIGPHMH OJEMOHKNAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0DB0", Offset = "0x5FF01B0", VA = "0x185FF0DB0")]
	private ODHHACMFLLI MMEJGFMCAFP(List<IOBPIOAJGIN> DPJCONJMAPL, OPAFMAPDCKD DDHKKPPIILC)
	{
		return default(ODHHACMFLLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0770", Offset = "0x5FEFB70", VA = "0x185FF0770")]
	private void DFKHPBIECAN(List<IOBPIOAJGIN> JAMOKHHOAMF, Vector3[] ANCENJMKBFC, Vector3[] DBCKHNFEEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ANPINKJKFJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9EC0", Offset = "0x5FE92C0", VA = "0x185FE9EC0")]
	public static Bounds PIDEHJCBHGB(List<IOBPIOAJGIN> JAMOKHHOAMF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9CF0", Offset = "0x5FE90F0", VA = "0x185FE9CF0")]
	public static int JJMFNCOHHKE(List<IOBPIOAJGIN> JAMOKHHOAMF, ECCMJPDPIEF DBHMHAHLCPM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CIFADHHHKKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private IIBGMLIJNCJ JEPHDMBHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private IIBGMLIJNCJ NMEBHKKBDHB;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static IIBGMLIJNCJ MDDFJOLGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private AICJNBLGCFE ICHPLEOLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private KILMAMMLMFP POCCMIKDLPB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle POBBNOHNBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBFB0", Offset = "0x1BCB3B0", VA = "0x181BCBFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LAADHDMIDBM.FIOFNGNLMOL OJEMOHKNAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FEGPKIHPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x51CEA90", Offset = "0x51CDE90", VA = "0x1851CEA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAE30", Offset = "0x5FEA230", VA = "0x185FEAE30")]
	[AFMMEBJJOHC(EHBEGHACGPO.ExitingPlayMode, 0)]
	private static void EICEEFNGLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA520", Offset = "0x5FE9920", VA = "0x185FEA520")]
	public void DLFOKGLGICG(LAADHDMIDBM.FIOFNGNLMOL CMINEOCKEPI, Transform DHAFPLIFLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAEB0", Offset = "0x5FEA2B0", VA = "0x185FEAEB0")]
	public void JLNODDBABAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FEADC0", Offset = "0x5FEA1C0", VA = "0x185FEADC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA4E0", Offset = "0x5FE98E0", VA = "0x185FEA4E0")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB520", Offset = "0x5FEA920", VA = "0x185FEB520")]
	public CIFADHHHKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PIBBJDPINAM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 NIENPLILDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface IPIOJFJJAFB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(PHNJPJKEIOH<string>.DNICKHEMCOE PJAJAHAHDKE, CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BKOCPAPMJEF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKOCPAPMJEF CHGECEDIHDI(Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKOCPAPMJEF EGHFKDDMBCF(Action HKJBPIINLDG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class AOEOEFOKJJK : BKOCPAPMJEF
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class NAPGEIHGJLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public AOEOEFOKJJK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
				public NAPGEIHGJLI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5FF66E0", Offset = "0x5FF5AE0", VA = "0x185FF66E0")]
				internal void CPAALACKLCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5FF6780", Offset = "0x5FF5B80", VA = "0x185FF6780")]
				internal void OGKCIBLHPCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x5FF6730", Offset = "0x5FF5B30", VA = "0x185FF6730")]
				internal void FDOEPEAAMIM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> CKNLMMOIGGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action KKLGJBEKPDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action GADBLBEGENJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private GDHGEGIJCJA MOHPAKDHMNB;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JFINGDMKIEG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action CPCCAGEEKCG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3B65080", Offset = "0x3B64480", VA = "0x183B65080", Slot = "4")]
			public BKOCPAPMJEF CHGECEDIHDI(Action HKJBPIINLDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5AD47A0", Offset = "0x5AD3BA0", VA = "0x185AD47A0", Slot = "5")]
			public BKOCPAPMJEF EGHFKDDMBCF(Action HKJBPIINLDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
			public AOEOEFOKJJK(Func<JobHandle> JBEDGDOJELG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5FEA090", Offset = "0x5FE9490", VA = "0x185FEA090")]
			public void BAFODOIJADE(Action BKCNJDIJNKC, Action GPAKJPOAKNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5FEA350", Offset = "0x5FE9750", VA = "0x185FEA350")]
			public void JJHPGEAJNEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IAHEOHCDJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public BKOCPAPMJEF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public IAHEOHCDJBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5FF06F0", Offset = "0x5FEFAF0", VA = "0x185FF06F0")]
			internal bool DHLJIANKGHL(AOEOEFOKJJK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class AILKOLPDCJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public AOEOEFOKJJK newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public AILKOLPDCJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5FE9C90", Offset = "0x5FE9090", VA = "0x185FE9C90")]
			internal void JFPMNFJOPGB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<AOEOEFOKJJK> PFBDFONPDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<AOEOEFOKJJK> MCOLGPLKLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private ICANAFEODIJ NMGMENIDABH;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DMDLDELABKH HAEHIDDIBJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2100", Offset = "0x5FF1500", VA = "0x185FF2100")]
		public BKOCPAPMJEF Add(Func<JobHandle> JBEDGDOJELG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2430", Offset = "0x5FF1830", VA = "0x185FF2430")]
		public void Remove(BKOCPAPMJEF POBBNOHNBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2260", Offset = "0x5FF1660", VA = "0x185FF2260", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2600", Offset = "0x5FF1A00", VA = "0x185FF2600")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2860", Offset = "0x5FF1C60", VA = "0x185FF2860")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2250", Offset = "0x5FF1650", VA = "0x185FF2250")]
		[CompilerGenerated]
		private void BCJAFJKFNCH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GDHGEGIJCJA
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDHGEGIJCJA CHGECEDIHDI(Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDHGEGIJCJA CNNCFPBIGHH(Action HKJBPIINLDG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GDHGEGIJCJA EGHFKDDMBCF(Action HKJBPIINLDG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class HJKLLJHDKMM : GDHGEGIJCJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle JFAHAJAPBFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action KKLGJBEKPDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action HFGGMONADEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action CPCCAGEEKCG;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool EKIHIOAGCOD
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x5FF06E0", Offset = "0x5FEFAE0", VA = "0x185FF06E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x59F8330", Offset = "0x59F7730", VA = "0x1859F8330", Slot = "4")]
			public GDHGEGIJCJA CHGECEDIHDI(Action HKJBPIINLDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x59F8350", Offset = "0x59F7750", VA = "0x1859F8350", Slot = "5")]
			public GDHGEGIJCJA CNNCFPBIGHH(Action HKJBPIINLDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5AD47A0", Offset = "0x5AD3BA0", VA = "0x185AD47A0", Slot = "6")]
			public GDHGEGIJCJA EGHFKDDMBCF(Action HKJBPIINLDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1A81360", Offset = "0x1A80760", VA = "0x181A81360")]
			public HJKLLJHDKMM(JobHandle IJLCDJPKLFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5FF0640", Offset = "0x5FEFA40", VA = "0x185FF0640")]
			public void DMBFJJDECOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5FF0690", Offset = "0x5FEFA90", VA = "0x185FF0690")]
			public void JJHPGEAJNEC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<HJKLLJHDKMM> POFPHAGNEMC;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2D60", Offset = "0x5FF2160", VA = "0x185FF2D60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2940", Offset = "0x5FF1D40", VA = "0x185FF2940")]
		public GDHGEGIJCJA Add(JobHandle IJLCDJPKLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2C60", Offset = "0x5FF2060", VA = "0x185FF2C60")]
		public void Remove(GDHGEGIJCJA POBBNOHNBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2AB0", Offset = "0x5FF1EB0", VA = "0x185FF2AB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5FF29E0", Offset = "0x5FF1DE0", VA = "0x185FF29E0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2EA0", Offset = "0x5FF22A0", VA = "0x185FF2EA0")]
		public JobTracker()
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
