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
				[Cpp2IlInjected.Address(RVA = "0x5A3CB50", Offset = "0x5A3BF50", VA = "0x185A3CB50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x10DD080", Offset = "0x10DC480", VA = "0x1810DD080")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5A3CB10", Offset = "0x5A3BF10", VA = "0x185A3CB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A33B60", Offset = "0x5A32F60", VA = "0x185A33B60")]
		public LODSettings MHBBLODDDOF(DFHGDAFHKOH MLFDOFFDKGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A33B70", Offset = "0x5A32F70", VA = "0x185A33B70")]
		public int MKMKCHCLFIE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5A33A60", Offset = "0x5A32E60", VA = "0x185A33A60")]
		public int FHGHFJHIIDP(bool PMIEFGOODFP, Vector3 PJIEILELJLE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5A33B90", Offset = "0x5A32F90", VA = "0x185A33B90")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NHMCBFGCNMP
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
public interface ALHJIDNONPB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAHEOPGPOJM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BMAAACNOEDD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PNIODALJNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LDLBEPGAECI> DLIJBHFIBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NHMCBFGCNMP DJKDNGLONCP
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
	void UpdateClusterDistances(Vector3 CLGJADBGBKK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(HCMNPJPHOLG BGHFDNDJKMA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LDLBEPGAECI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int ACDOJIEAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LKEIBNMGCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KGKJLLKDAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float PFFPCKHAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte IHOLHLLNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ABFGOIKBHOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum HELECPGILEB
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
	private struct JEFLLFDGFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ABFGOIKBHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IBIDBCAPHMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IBIDBCAPHMG <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A260", Offset = "0x5A39660", VA = "0x185A3A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GBNJIGKAIOF : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ABFGOIKBHOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public GBNJIGKAIOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5A39260", Offset = "0x5A38660", VA = "0x185A39260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5A39320", Offset = "0x5A38720", VA = "0x185A39320", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AOFPEIMHPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public ABFGOIKBHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IBIDBCAPHMG worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IBIDBCAPHMG <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5A325D0", Offset = "0x5A319D0", VA = "0x185A325D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IPFIIHNOAIB : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public ABFGOIKBHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public IPFIIHNOAIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5A39370", Offset = "0x5A38770", VA = "0x185A39370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A220", Offset = "0x5A39620", VA = "0x185A3A220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int JHMPMNIBBKH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan OMBEBPPCLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer JLFFLDJPLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter BMGLPBAGHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject PLBEALLBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject LAFGFCGOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public KJAHGFCGBGO LGEABEAGHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<HCMNPJPHOLG> KODJPDKDPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<HCMNPJPHOLG> IIOKELDMHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<HCMNPJPHOLG> HPLDDOJGOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BHJNBOKOMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HELECPGILEB DDFIGLPLECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<BMAAACNOEDD>[] DLGBFEIHHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LDLBEPGAECI>[] CBCDHLPDPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource LMGPEKLECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NEPHHMKOHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EJCEALCEAGN HNAEFEDHPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EJCEALCEAGN PEHCCOMFMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int ANANBEMBAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PBACAMHIDHB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static ABFGOIKBHOJ LMKOBPEFBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly AKPPNCPJLFJ KNEOPICOIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ANGOBDDDJBO FKBJIDOGMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour EGCPDKCHOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material EMNNBOGCKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<ALHJIDNONPB> LNHPFPHKAFH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig AOELLJOFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 JEDPBILLILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x21DAEC0", Offset = "0x21DA2C0", VA = "0x1821DAEC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x21DADF0", Offset = "0x21DA1F0", VA = "0x1821DADF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private HELECPGILEB NNIBJIPALOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x811300", Offset = "0x810700", VA = "0x180811300")]
		get
		{
			return default(HELECPGILEB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CE10", Offset = "0x5A2C210", VA = "0x185A2CE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ABFGOIKBHOJ HNEIEBONIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E5D0", Offset = "0x5A2D9D0", VA = "0x185A2E5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KMIIFHKKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5A2DCB0", Offset = "0x5A2D0B0", VA = "0x185A2DCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool ONADOELEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5A2DE70", Offset = "0x5A2D270", VA = "0x185A2DE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> EKCKEDGPFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D0A0", Offset = "0x5A2C4A0", VA = "0x185A2D0A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5A2DDD0", Offset = "0x5A2D1D0", VA = "0x185A2DDD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DLCIMMEOJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CD70", Offset = "0x5A2C170", VA = "0x185A2CD70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E250", Offset = "0x5A2D650", VA = "0x185A2E250")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F1B0", Offset = "0x5A2E5B0", VA = "0x185A2F1B0")]
	public ABFGOIKBHOJ(AKPPNCPJLFJ KNEOPICOIPD, ANGOBDDDJBO FKBJIDOGMDG, ClusterLODConfig LEEAFJPFDIM, MonoBehaviour EGCPDKCHOJF, Material EMNNBOGCKAN, ClusterMeshRenderer JLFFLDJPLIA, MeshFilter BMGLPBAGHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CF40", Offset = "0x5A2C340", VA = "0x185A2CF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D140", Offset = "0x5A2C540", VA = "0x185A2D140")]
	public static void FGKDDGCBOEH(Vector3 HLFKILHDOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F040", Offset = "0x5A2E440", VA = "0x185A2F040")]
	private void PFGLHGPCIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DA70", Offset = "0x5A2CE70", VA = "0x185A2DA70")]
	private void HEIFKLDHCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D920", Offset = "0x5A2CD20", VA = "0x185A2D920")]
	private void GLLBOLCDBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EAE0", Offset = "0x5A2DEE0", VA = "0x185A2EAE0")]
	public void PAOAKEOLNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E630", Offset = "0x5A2DA30", VA = "0x185A2E630")]
	[AsyncStateMachine(typeof(JEFLLFDGFMG))]
	public Task KFGNFDPMJIL(IBIDBCAPHMG KIBJDNPFMAF, CancellationToken FFBLKMEPPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F0D0", Offset = "0x5A2E4D0", VA = "0x185A2F0D0")]
	[IteratorStateMachine(typeof(GBNJIGKAIOF))]
	private IEnumerator<MOELIBACAGH> PMMGHMJGLAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DB70", Offset = "0x5A2CF70", VA = "0x185A2DB70")]
	[AsyncStateMachine(typeof(AOFPEIMHPIG))]
	private Task HEJLALGELDJ(IBIDBCAPHMG KNACNIFMCDK, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CB00", Offset = "0x5A2BF00", VA = "0x185A2CB00")]
	public void BOGBKCBPOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E8D0", Offset = "0x5A2DCD0", VA = "0x185A2E8D0")]
	public void LMEBJBJBCOK(IEnumerable<BMAAACNOEDD> PBLCPBCHAAF, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DFD0", Offset = "0x5A2D3D0", VA = "0x185A2DFD0")]
	public void JJCMOBMJLOL(IEnumerable<BMAAACNOEDD> PBLCPBCHAAF, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D270", Offset = "0x5A2C670", VA = "0x185A2D270")]
	public List<ClusterMeshRenderer> GKONHIAMLPP(List<HCMNPJPHOLG> AOONNNAPHDO, CEIHGOGAJAB LBGMPPHBAAC, NHMCBFGCNMP ABCMMMCGCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C8A0", Offset = "0x5A2BCA0", VA = "0x185A2C8A0")]
	public NHMCBFGCNMP AFIJICMGNLB(Vector3 JPCHFHMKBFN)
	{
		return default(NHMCBFGCNMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CD10", Offset = "0x5A2C110", VA = "0x185A2CD10")]
	public void COOCBMGHJEN(ALHJIDNONPB FLKCAHNHOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EA10", Offset = "0x5A2DE10", VA = "0x185A2EA10")]
	public bool MLBEINOMMBH(ALHJIDNONPB FLKCAHNHOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D040", Offset = "0x5A2C440", VA = "0x185A2D040")]
	public void EHNGBEBKDMN(HCMNPJPHOLG JJAPHNDELJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E950", Offset = "0x5A2DD50", VA = "0x185A2E950")]
	public void MJFNLHNILOO(LDLBEPGAECI HHCANBNBHNP, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DF50", Offset = "0x5A2D350", VA = "0x185A2DF50")]
	public void JHDNJOACBMD(LDLBEPGAECI HHCANBNBHNP, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E2F0", Offset = "0x5A2D6F0", VA = "0x185A2E2F0")]
	private void JLGGFAMFPCA(Vector3 CLGJADBGBKK, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E770", Offset = "0x5A2DB70", VA = "0x185A2E770")]
	private void LKJIABMDIBP(Vector3 CLGJADBGBKK, NHMCBFGCNMP ABCMMMCGCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EA70", Offset = "0x5A2DE70", VA = "0x185A2EA70")]
	[IteratorStateMachine(typeof(IPFIIHNOAIB))]
	private IEnumerator<MOELIBACAGH> OOPPFGCACJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E450", Offset = "0x5A2D850", VA = "0x185A2E450")]
	private int JPDPMHEIBAP(int BELCAJFDAHD, int KDIHLGCMIJC, List<LDLBEPGAECI> COOHCPFEOFP, byte MLFDOFFDKGG, ref int KIAKICCJKHL, float OAOFBIAANMO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C920", Offset = "0x5A2BD20", VA = "0x185A2C920")]
	public void BCBAFCFKBLF(HCMNPJPHOLG BGHFDNDJKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C8E0", Offset = "0x5A2BCE0", VA = "0x185A2C8E0")]
	public bool AGFKNHLBIIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8E1270", Offset = "0x8E0670", VA = "0x1808E1270")]
	public Material CLPEJOKFMPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E9D0", Offset = "0x5A2DDD0", VA = "0x185A2E9D0")]
	public int MKMKCHCLFIE()
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
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KMEFLIBEELO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> ILEBKEIHOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> EOGMADOHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> DBMBCIPKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> PAKBLILEHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> PAMLKOLMBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> GGHFLGHFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> ECAINMFGDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 IBGFGADAOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float KKLCKFOHOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> GDHCGAFIICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> EILAJGHKMFB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C7E0", Offset = "0x5A3BBE0", VA = "0x185A3C7E0")]
	public KMEFLIBEELO(IKPIJFLHOMC NCKHOMLJJGL, NativeList<float3> ECAINMFGDCI, NativeMultiHashMap<int, int> GDHCGAFIICN, NativeArray<int> EILAJGHKMFB, Vector3 IBGFGADAOOB, float KKLCKFOHOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C550", Offset = "0x5A3B950", VA = "0x185A3C550")]
	private int GOGJAFAMJPA(float3 CLGJADBGBKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C580", Offset = "0x5A3B980", VA = "0x185A3C580")]
	private int OIAEEABLFHP(int BHOLCDOGKAG, int EBOEHIFNNLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C120", Offset = "0x5A3B520", VA = "0x185A3C120", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EIMFMMNOGMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> GDHCGAFIICN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> EILAJGHKMFB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int OFLNHNPKAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> IKPAOKLAJLO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5A38940", Offset = "0x5A37D40", VA = "0x185A38940")]
	public void MOMCOHNDGEO(int COOCAACDKON, Allocator OPBLDCCKGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5A38860", Offset = "0x5A37C60", VA = "0x185A38860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EIMFMMNOGMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct CDMEBACNGKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> GNLHIJAKGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> FNNOLDCMNEH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A33A30", Offset = "0x5A32E30", VA = "0x185A33A30")]
	public CDMEBACNGKP(EIMFMMNOGMK NHPJOGHAPCI, IKPIJFLHOMC NCKHOMLJJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5A33990", Offset = "0x5A32D90", VA = "0x185A33990", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct AFINMAMKFFK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> OJCKGBILOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> DBIFIPOLKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> BEBDBPAKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> OIDBIAJDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> DIDNMLAIEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> IKPAOKLAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> GNLHIJAKGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> HKGPKPGCNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> BOODOGLFEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LFELJIOMOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> PIMGKMJAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> OKNDAIBHGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> MFHHDGJMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float LPLFKPEDOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float FAJHKPOILBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 KEAOLNIPIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LAAGEPPFLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NBGJDPIBHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float KMAOMDJLDEN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5A30F90", Offset = "0x5A30390", VA = "0x185A30F90")]
	public AFINMAMKFFK(EIMFMMNOGMK CIGELLOHEHN, IKPIJFLHOMC NCKHOMLJJGL, IKPIJFLHOMC MKKNDELJCLD, float NBGJDPIBHNE, float KMAOMDJLDEN, Vector3 KEAOLNIPIMI, float LAAGEPPFLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FAA0", Offset = "0x5A2EEA0", VA = "0x185A2FAA0")]
	private float3 CNOLGDCBAHC(int BHOLCDOGKAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A30900", Offset = "0x5A2FD00", VA = "0x185A30900")]
	private void GOCECPEEOEG(int BHOLCDOGKAG, out float3 JDMMEIDNLGJ, out float3 PMIBNGDAFIP, out float4 OLEIIDPPIPJ, out float4 JBMFIMBBHCC, out float2 CCOMALPJAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FCE0", Offset = "0x5A2F0E0", VA = "0x185A2FCE0")]
	private int EMMFPOEPNJN(int MELIMHJPNDF, int DMBDBGICMFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A30AF0", Offset = "0x5A2FEF0", VA = "0x185A30AF0")]
	private void KDCODDDPOOO(int MELIMHJPNDF, int DMBDBGICMFP, int KFIGFLJOHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FB50", Offset = "0x5A2EF50", VA = "0x185A2FB50")]
	private bool EDMODIDODKB(int MELIMHJPNDF, int DMBDBGICMFP, float MMDLCBGFMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F9E0", Offset = "0x5A2EDE0", VA = "0x185A2F9E0")]
	private bool AILAFJHJEDO(int MELIMHJPNDF, int DMBDBGICMFP, int KFIGFLJOHIJ, float MMDLCBGFMBJ, bool GKBBEIMEIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5A30D00", Offset = "0x5A30100", VA = "0x185A30D00")]
	private bool MGKEGKAHIGO(int MELIMHJPNDF, int DMBDBGICMFP, int KFIGFLJOHIJ, float MMDLCBGFMBJ, bool GKBBEIMEIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5A30F70", Offset = "0x5A30370", VA = "0x185A30F70")]
	private void PLKOIEFGFIN(int MELIMHJPNDF, int DMBDBGICMFP, int KFIGFLJOHIJ, out int LAACNEONGIA, out int CDNNCMALLCA, out int GDIJNECFEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FFE0", Offset = "0x5A2F3E0", VA = "0x185A2FFE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EAPBMDJNFDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OJOPMMKJGOC : IDisposable, LDLBEPGAECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds LIJLBDEDOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<HCMNPJPHOLG> AOONNNAPHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 EEGKCHNLLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 AIBCFOBJGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int ENNKJEBFJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IKPIJFLHOMC ENMABLFDDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EIMFMMNOGMK NBLLDJPPDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform LBGMPPHBAAC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FOPJMCIEMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5A3F380", Offset = "0x5A3E780", VA = "0x185A3F380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh PAFDKLGJBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh GFEOBBFMHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float KGKJLLKDAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x705F00", Offset = "0x705300", VA = "0x180705F00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7062A0", Offset = "0x7056A0", VA = "0x1807062A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte IHOLHLLNGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7BE840", Offset = "0x7BDC40", VA = "0x1807BE840", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int ACDOJIEAAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA37490", Offset = "0xA36890", VA = "0x180A37490", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1127C60", Offset = "0x1127060", VA = "0x181127C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int LKEIBNMGCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA37480", Offset = "0xA36880", VA = "0x180A37480", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x965A60", Offset = "0x964E60", VA = "0x180965A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PFFPCKHAFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5A3F760", Offset = "0x5A3EB60", VA = "0x185A3F760", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5A3F150", Offset = "0x5A3E550", VA = "0x185A3F150")]
		public void IJALBHCFOND(DFHGDAFHKOH MLFDOFFDKGG, out int NKCEJIAEMLH, out int PPCGLDICDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5A3ED00", Offset = "0x5A3E100", VA = "0x185A3ED00")]
		public void CPJAILLECIC(DFHGDAFHKOH MLFDOFFDKGG, NJJOGHOKENA ACBJMIABIEE, int EBPBKJGOJOB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5A3F3C0", Offset = "0x5A3E7C0", VA = "0x185A3F3C0")]
		public void OCDEFDPKAME(NativeList<MAEFCOOCBLB> PLNPKBJIOCF, Transform NACJECHPLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5A3F0B0", Offset = "0x5A3E4B0", VA = "0x185A3F0B0")]
		public void EIABCCCIGLP(Mesh NCKHOMLJJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5A3EC60", Offset = "0x5A3E060", VA = "0x185A3EC60")]
		public void ALEFHCKJHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5A3EEB0", Offset = "0x5A3E2B0", VA = "0x185A3EEB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5A3F780", Offset = "0x5A3EB80", VA = "0x185A3F780")]
		public OJOPMMKJGOC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds LIJLBDEDOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<OJOPMMKJGOC> PDJCOPBDGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AMEHCMCLFAO FKDKMDFJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer JHMACGKJPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int AGICEKHHCOE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh BFCKHLMCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AJGFPFMDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C88F0", Offset = "0x9C7CF0", VA = "0x1809C88F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PNIODALJNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5A377A0", Offset = "0x5A36BA0", VA = "0x185A377A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5A37000", Offset = "0x5A36400", VA = "0x185A37000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5A37160", Offset = "0x5A36560", VA = "0x185A37160")]
	public int EKANKHNDCDN(int OEMNCMKDEDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5A375E0", Offset = "0x5A369E0", VA = "0x185A375E0")]
	public void JPPHNLFAPBB(LIMGAIOAAFB DNBKPKLMOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5A377F0", Offset = "0x5A36BF0", VA = "0x185A377F0")]
	public void MIPABNOOBDJ(Transform NACJECHPLOP, bool IHIFLEPMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5A37FC0", Offset = "0x5A373C0", VA = "0x185A37FC0")]
	public bool NDBNKJOGKEC(bool DOFIAMGBBBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5A37190", Offset = "0x5A36590", VA = "0x185A37190")]
	public void IEKONJDNALD(Transform LBGMPPHBAAC, bool IHIFLEPMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5A36D50", Offset = "0x5A36150", VA = "0x185A36D50")]
	public bool BCBAFCFKBLF(HCMNPJPHOLG BGHFDNDJKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5A38180", Offset = "0x5A37580", VA = "0x185A38180")]
	public EAPBMDJNFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KJAHGFCGBGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<EAPBMDJNFDD.OJOPMMKJGOC> EPINIDHMENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NIMDFIKKBPP CNDBNEJNLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<EAPBMDJNFDD.OJOPMMKJGOC> NGIFMGNKODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BFBNOBDFHMO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BAC0", Offset = "0x5A3AEC0", VA = "0x185A3BAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BBD0", Offset = "0x5A3AFD0", VA = "0x185A3BBD0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B6B0", Offset = "0x5A3AAB0", VA = "0x185A3B6B0")]
	public void AOHLLDNPMGN(EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN, Transform LBGMPPHBAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B770", Offset = "0x5A3AB70", VA = "0x185A3B770")]
	public void BCBAFCFKBLF(EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B990", Offset = "0x5A3AD90", VA = "0x185A3B990")]
	private EAPBMDJNFDD.OJOPMMKJGOC DPCMGEPIKAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BB30", Offset = "0x5A3AF30", VA = "0x185A3BB30")]
	private bool EHCNCCMECIG(EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BCB0", Offset = "0x5A3B0B0", VA = "0x185A3BCB0")]
	private void JINPBPOCIJJ(EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B960", Offset = "0x5A3AD60", VA = "0x185A3B960")]
	public bool DDEDJAPANPE(EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BD10", Offset = "0x5A3B110", VA = "0x185A3BD10")]
	public bool KJAIMLDDOOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BC50", Offset = "0x5A3B050", VA = "0x185A3BC50")]
	private EAPBMDJNFDD.OJOPMMKJGOC JCMFKGJBLAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BFA0", Offset = "0x5A3B3A0", VA = "0x185A3BFA0")]
	public KJAHGFCGBGO()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EJPDPGMFNIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int MMOFLIPJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HMCJBLKMEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float HIIPIAOEFIH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<EAPBMDJNFDD> AOJNNOJKEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5A39140", Offset = "0x5A38540", VA = "0x185A39140")]
	public EJPDPGMFNIF(int MMOFLIPJBGJ, int HMCJBLKMEIO, float PDLKEGHJBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5A38D70", Offset = "0x5A38170", VA = "0x185A38D70")]
	public void HFGLDMOBCJC(FILGNMJNEAC KCBDEAGBFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5A390A0", Offset = "0x5A384A0", VA = "0x185A390A0")]
	private int NGODBBFEJOL(LIMGAIOAAFB MCFKDIFOJAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5A38B30", Offset = "0x5A37F30", VA = "0x185A38B30")]
	private void HFGLDMOBCJC(LIMGAIOAAFB MCFKDIFOJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A38E90", Offset = "0x5A38290", VA = "0x185A38E90")]
	private void IJNDBFAJGJL(LIMGAIOAAFB MCFKDIFOJAH, EAPBMDJNFDD CPHIBPKCCFD)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, BMAAACNOEDD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LABHCLAALBF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public LABHCLAALBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C8A0", Offset = "0x5A3BCA0", VA = "0x185A3C8A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5A3CA50", Offset = "0x5A3BE50", VA = "0x185A3CA50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C9B0", Offset = "0x5A3BDB0", VA = "0x185A3C9B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C9B0", Offset = "0x5A3BDB0", VA = "0x185A3C9B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PNIODALJNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5A35030", Offset = "0x5A34430", VA = "0x185A35030", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<LDLBEPGAECI> DLIJBHFIBLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5A35010", Offset = "0x5A34410", VA = "0x185A35010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> PDJCOPBDGKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EAPBMDJNFDD BFCKHLMCFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NHMCBFGCNMP DJKDNGLONCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(NHMCBFGCNMP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6F0C30", Offset = "0x6F0030", VA = "0x1806F0C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MNFPNDBPEEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5A35020", Offset = "0x5A34420", VA = "0x185A35020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5A33BF0", Offset = "0x5A32FF0", VA = "0x185A33BF0")]
		public static ClusterMeshRenderer Create(EAPBMDJNFDD NCKHOMLJJGL, ClusterMeshRenderer JLFFLDJPLIA, MeshFilter BMGLPBAGHBE, CEIHGOGAJAB LBGMPPHBAAC, NHMCBFGCNMP ABCMMMCGCAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5A33D90", Offset = "0x5A33190", VA = "0x185A33D90", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5A34550", Offset = "0x5A33950", VA = "0x185A34550", Slot = "10")]
		public bool TryRemoveClusterLODComponent(HCMNPJPHOLG BGHFDNDJKMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5A34340", Offset = "0x5A33740", VA = "0x185A34340")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5A33FE0", Offset = "0x5A333E0", VA = "0x185A33FE0")]
		public void Init(EAPBMDJNFDD NCKHOMLJJGL, MeshFilter BMGLPBAGHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5A33DF0", Offset = "0x5A331F0", VA = "0x185A33DF0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5A34680", Offset = "0x5A33A80", VA = "0x185A34680", Slot = "8")]
		public void UpdateClusterDistances(Vector3 CLGJADBGBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A34890", Offset = "0x5A33C90", VA = "0x185A34890", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5A33F70", Offset = "0x5A33370", VA = "0x185A33F70")]
		[IteratorStateMachine(typeof(LABHCLAALBF))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5A343C0", Offset = "0x5A337C0", VA = "0x185A343C0")]
		public void SetupTagAndLayer(string MPPCHDNPEDD, int ABCMMMCGCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A343A0", Offset = "0x5A337A0", VA = "0x185A343A0")]
		public bool Remove(HCMNPJPHOLG BGHFDNDJKMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MGCBJFEMPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int AEBJAJLGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int IIEPBAFMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int PPCGLDICDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NKCEJIAEMLH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A3CB70", Offset = "0x5A3BF70", VA = "0x185A3CB70")]
	public MGCBJFEMPOJ(int IIEPBAFMLKK, int PPCGLDICDKH, int AEBJAJLGHLK, int NKCEJIAEMLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AMEHCMCLFAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> ILEBKEIHOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> IKPAOKLAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> GGHFLGHFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<MGCBJFEMPOJ> AJMEBMGKGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> BDMPGHPNAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> FNGGAGOAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> ILMHHDIJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle GNEAPAJLKDP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ALLLILMAHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC7CFD0", Offset = "0xC7C3D0", VA = "0x180C7CFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC7D000", Offset = "0xC7C400", VA = "0x180C7D000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5A31210", Offset = "0x5A30610", VA = "0x185A31210")]
	public void HBGEMGCKMHE(IKPIJFLHOMC NJKFHLKEDEH, NativeList<MGCBJFEMPOJ> AJMEBMGKGGC, float BDMGGOCELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A32130", Offset = "0x5A31530", VA = "0x185A32130")]
	public void KHFFKLKPAII(Transform LBGMPPHBAAC, bool IHIFLEPMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5A32420", Offset = "0x5A31820", VA = "0x185A32420")]
	public void NDBNKJOGKEC(EAPBMDJNFDD JHMACGKJPAP, bool DOFIAMGBBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5A310D0", Offset = "0x5A304D0", VA = "0x185A310D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A311E0", Offset = "0x5A305E0", VA = "0x185A311E0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AMEHCMCLFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct OCBKKIENPKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> ILEBKEIHOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> IKPAOKLAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<MGCBJFEMPOJ> LCJOOFGGFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> BDMPGHPNAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 KEAOLNIPIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> FNGGAGOAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> ILMHHDIJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool IHIFLEPMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float OOKLEAOEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float EIMOJFFEHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float DEIPJLGDIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> GGHFLGHFEMD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5A3EB90", Offset = "0x5A3DF90", VA = "0x185A3EB90")]
	public OCBKKIENPKE(AMEHCMCLFAO GFHPBIGFBGF, Vector3 KEAOLNIPIMI, bool IHIFLEPMPBB, float OOKLEAOEGCC, float EIMOJFFEHIJ, float DEIPJLGDIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A3E700", Offset = "0x5A3DB00", VA = "0x185A3E700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HCMNPJPHOLG : LDKGGMHGEOG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds NDOKJMIJGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MAEFCOOCBLB BKPGDEPAJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LIMGAIOAAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<HCMNPJPHOLG> AOONNNAPHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public LIMGAIOAAFB GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public LIMGAIOAAFB LEBCBLEMDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public LIMGAIOAAFB JINFLLMAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int NKCEJIAEMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds LIJLBDEDOGL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A3CA90", Offset = "0x5A3BE90", VA = "0x185A3CA90")]
	public LIMGAIOAAFB(List<HCMNPJPHOLG> AOONNNAPHDO, [Optional] LIMGAIOAAFB GPFONCECPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FILGNMJNEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<LIMGAIOAAFB> KFOCHBCJBFD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LIMGAIOAAFB MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A39190", Offset = "0x5A38590", VA = "0x185A39190")]
	public FILGNMJNEAC(LIMGAIOAAFB LBGMPPHBAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EAOHLLLAGBI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BHPPKJMEKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int GMNHCCDMGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int ODLADCICKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OFEJHHHEDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int OHCBIDBKCCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DMBLLOHPOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int GPMFAINCNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float FAMKELEAEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<HCMNPJPHOLG> AOONNNAPHDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PLMAJAOPCLF
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
	private BHPPKJMEKBI HKBCMJOMLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KKGEDBPLHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int MMOFLIPJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int HMCJBLKMEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float PDLKEGHJBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float IMIFIJHIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<LIMGAIOAAFB> MAKFAIODNLN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FILGNMJNEAC NKDGCBKGLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A36CF0", Offset = "0x5A360F0", VA = "0x185A36CF0")]
	public EAOHLLLAGBI(int MMOFLIPJBGJ, int HMCJBLKMEIO, float PDLKEGHJBBK, int KKGEDBPLHMD, float IMIFIJHIDLP = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5A35090", Offset = "0x5A34490", VA = "0x185A35090")]
	public void EAAKKGKBJLH(List<HCMNPJPHOLG> AOONNNAPHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5A36BB0", Offset = "0x5A35FB0", VA = "0x185A36BB0")]
	public bool NDNPPKBNKGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5A36C20", Offset = "0x5A36020", VA = "0x185A36C20")]
	private float PHANIAJEAMI(Vector3 LOOCNKEBNDJ, Vector3 KLDHGDMNHDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5A36CA0", Offset = "0x5A360A0", VA = "0x185A36CA0")]
	private float PHANIAJEAMI(Vector3 PCAHMJECHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A36320", Offset = "0x5A35720", VA = "0x185A36320")]
	private bool MGCNAHHBLLP(LIMGAIOAAFB DLGLIKFKFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A35290", Offset = "0x5A34690", VA = "0x185A35290")]
	private DMBLLOHPOAM EFAMKMKNNAA(List<HCMNPJPHOLG> EKKKMBIAIDO, PLMAJAOPCLF LEJMLOAILAP)
	{
		return default(DMBLLOHPOAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5A35EC0", Offset = "0x5A352C0", VA = "0x185A35EC0")]
	private void IGMBOCPJJDK(List<HCMNPJPHOLG> AOONNNAPHDO, Vector3[] CFGCHMCFJKO, Vector3[] JGIOIDALGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OBHBAODMNOL
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5A3E550", Offset = "0x5A3D950", VA = "0x185A3E550")]
	public static Bounds EAEJEOPOHDH(List<HCMNPJPHOLG> AOONNNAPHDO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5A3E3A0", Offset = "0x5A3D7A0", VA = "0x185A3E3A0")]
	public static int DGDPBGFKBEC(List<HCMNPJPHOLG> AOONNNAPHDO, DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NIMDFIKKBPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private IKPIJFLHOMC LMLNLCNHAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private IKPIJFLHOMC JMBKCOCBEME;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static IKPIJFLHOMC HBBGAHOIOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private HNMCHLFOIAA BKGLKBGABBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NJJOGHOKENA ACBJMIABIEE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle GNEAPAJLKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x727550", Offset = "0x726950", VA = "0x180727550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EAPBMDJNFDD.OJOPMMKJGOC DLGLIKFKFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool APKOIIDBGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A30A0", Offset = "0x8A24A0", VA = "0x1808A30A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D750", Offset = "0x5A3CB50", VA = "0x185A3D750")]
	[ODBBCFLHGDG(BHNMFCNEJDF.ExitingPlayMode, 0)]
	private static void FHFNJAPGGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D800", Offset = "0x5A3CC00", VA = "0x185A3D800")]
	public void HBGEMGCKMHE(EAPBMDJNFDD.OJOPMMKJGOC LCJOOFGGFCE, Transform NCHIMHCGEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A3CFF0", Offset = "0x5A3C3F0", VA = "0x185A3CFF0")]
	public void DDJDBIOPEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D6E0", Offset = "0x5A3CAE0", VA = "0x185A3D6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D7C0", Offset = "0x5A3CBC0", VA = "0x185A3D7C0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A3E300", Offset = "0x5A3D700", VA = "0x185A3E300")]
	public NIMDFIKKBPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JCLDFJIDKJE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	ABFGOIKBHOJ NJHNJIGEGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ANGOBDDDJBO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 FCAIBKAOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AKPPNCPJLFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(IBIDBCAPHMG KNACNIFMCDK, CancellationToken OLHHOODBFDC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OADAJOPEHKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OADAJOPEHKJ BFDOHAHGHNF(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OADAJOPEHKJ KGMPGLEAFGE(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OADAJOPEHKJ CACGHKAJMBJ(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OADAJOPEHKJ GMODENEKLBL(Action GPNJNMLGIEN);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MOIBGGDOIEK : OADAJOPEHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class ACAEFEMOKHP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public MOIBGGDOIEK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public ACAEFEMOKHP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5A2F900", Offset = "0x5A2ED00", VA = "0x185A2F900")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5A2F950", Offset = "0x5A2ED50", VA = "0x185A2F950")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5A2F9A0", Offset = "0x5A2EDA0", VA = "0x185A2F9A0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> FCOGOKKGPEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action LCFHHLOMDLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action EFHIBICDHEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private HKOJCIMIKMC OPMGAKGOFNN;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action MKGEKELENGM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action PMEFPKCCJKB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x74F160", Offset = "0x74E560", VA = "0x18074F160", Slot = "4")]
			public OADAJOPEHKJ BFDOHAHGHNF(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xC522D0", Offset = "0xC516D0", VA = "0x180C522D0", Slot = "5")]
			public OADAJOPEHKJ KGMPGLEAFGE(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3096410", Offset = "0x3095810", VA = "0x183096410", Slot = "6")]
			public OADAJOPEHKJ CACGHKAJMBJ(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3602680", Offset = "0x3601A80", VA = "0x183602680", Slot = "7")]
			public OADAJOPEHKJ GMODENEKLBL(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
			public MOIBGGDOIEK(Func<JobHandle> FNFNEOBLONB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5A3CD00", Offset = "0x5A3C100", VA = "0x185A3CD00")]
			public void BMPOKKCKKNK(Action ALDDHJGBLLG, Action GAAFEGGHLCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5A3CB90", Offset = "0x5A3BF90", VA = "0x185A3CB90")]
			public void BCBAFCFKBLF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HGIIAPGIJLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public OADAJOPEHKJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public HGIIAPGIJLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5A39360", Offset = "0x5A38760", VA = "0x185A39360")]
			internal bool <Remove>b__0(MOIBGGDOIEK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class NBNHAJMGJFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public MOIBGGDOIEK newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public NBNHAJMGJFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A3CF90", Offset = "0x5A3C390", VA = "0x185A3CF90")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<MOIBGGDOIEK> GNBGGOPFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<MOIBGGDOIEK> GEMNIINOGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private EJCEALCEAGN MOJFALCMLFH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public HGMFFLEGBKI JILNPJCKLOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A8D0", Offset = "0x5A39CD0", VA = "0x185A3A8D0")]
		public OADAJOPEHKJ Add(Func<JobHandle> FNFNEOBLONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5A3ABD0", Offset = "0x5A39FD0", VA = "0x185A3ABD0")]
		public void Remove(OADAJOPEHKJ GNEAPAJLKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AA30", Offset = "0x5A39E30", VA = "0x185A3AA30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A3ADA0", Offset = "0x5A3A1A0", VA = "0x185A3ADA0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AFF0", Offset = "0x5A3A3F0", VA = "0x185A3AFF0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AA20", Offset = "0x5A39E20", VA = "0x185A3AA20")]
		[CompilerGenerated]
		private void FANHMHONOKO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HKOJCIMIKMC
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKOJCIMIKMC BFDOHAHGHNF(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKOJCIMIKMC FPBMDDIECDH(Action GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKOJCIMIKMC GMODENEKLBL(Action GPNJNMLGIEN);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class JPLOKCNPKFI : HKOJCIMIKMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle GJJGLPKAKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action LCFHHLOMDLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action MDDBJCOLLEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action PMEFPKCCJKB;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool DGCFKLDJJEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5A3A8C0", Offset = "0x5A39CC0", VA = "0x185A3A8C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xC522D0", Offset = "0xC516D0", VA = "0x180C522D0", Slot = "4")]
			public HKOJCIMIKMC BFDOHAHGHNF(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3096410", Offset = "0x3095810", VA = "0x183096410", Slot = "5")]
			public HKOJCIMIKMC FPBMDDIECDH(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3602680", Offset = "0x3601A80", VA = "0x183602680", Slot = "6")]
			public HKOJCIMIKMC GMODENEKLBL(Action GPNJNMLGIEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
			public JPLOKCNPKFI(JobHandle PLJEPLODDHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5A3A880", Offset = "0x5A39C80", VA = "0x185A3A880")]
			public void HPPHODAOIFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5A3A840", Offset = "0x5A39C40", VA = "0x185A3A840")]
			public void BCBAFCFKBLF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<JPLOKCNPKFI> KDGPBPLMDAO;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B4D0", Offset = "0x5A3A8D0", VA = "0x185A3B4D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B0F0", Offset = "0x5A3A4F0", VA = "0x185A3B0F0")]
		public HKOJCIMIKMC Add(JobHandle PLJEPLODDHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B3E0", Offset = "0x5A3A7E0", VA = "0x185A3B3E0")]
		public void Remove(HKOJCIMIKMC GNEAPAJLKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B270", Offset = "0x5A3A670", VA = "0x185A3B270", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B180", Offset = "0x5A3A580", VA = "0x185A3B180")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B5F0", Offset = "0x5A3A9F0", VA = "0x185A3B5F0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5A38230", Offset = "0x5A37630", VA = "0x185A38230")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5A38340", Offset = "0x5A37740", VA = "0x185A38340")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
