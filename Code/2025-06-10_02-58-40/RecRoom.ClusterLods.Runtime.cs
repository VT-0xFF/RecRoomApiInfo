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
				[Cpp2IlInjected.Address(RVA = "0x7B6A9A0", Offset = "0x7B69BA0", VA = "0x187B6A9A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xDD1210", Offset = "0xDD0410", VA = "0x180DD1210")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A960", Offset = "0x7B69B60", VA = "0x187B6A960")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5C080", Offset = "0x7B5B280", VA = "0x187B5C080")]
		public LODSettings OPFLGHOGKEJ(JFHEFEBDPBL AEABCPDILIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BFC0", Offset = "0x7B5B1C0", VA = "0x187B5BFC0")]
		public int HMHJIGJFBPI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BFE0", Offset = "0x7B5B1E0", VA = "0x187B5BFE0")]
		public int MGBLJJPFFFG(bool ENOMPBMDMLO, Vector3 GEJHDKIINEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C090", Offset = "0x7B5B290", VA = "0x187B5C090")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DMGADPKJDGN
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
public interface JMKDBBNBJDD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCPEFEFFAJA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MIEOPCAMENN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FKEGMIJDHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<PENGHGJLNKN> KCABHCCKGDA
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
	void UpdateClusterDistances(Vector3 ICPEADDPOJA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(LHKGDGIKFCG JCAGDPHNPIB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PENGHGJLNKN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int OPDLCLPJPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int ELMFBGFOPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HLNBNEGAPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OKGODJNJNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte ONMOPHIIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IHLMKJGLLAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BICOEDHKJGJ
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
	private struct MNKLJJLJDBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IHLMKJGLLAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C620", Offset = "0x7B6B820", VA = "0x187B6C620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CDB0", Offset = "0x7B6BFB0", VA = "0x187B6CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IIKHKBILKKI : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IHLMKJGLLAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public IIKHKBILKKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B66FC0", Offset = "0x7B661C0", VA = "0x187B66FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B670F0", Offset = "0x7B662F0", VA = "0x187B670F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MHNLGMBGAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IHLMKJGLLAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BGHCJGPGCNF<string>.IPAINGKGFDM worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private BGHCJGPGCNF<string>.IPAINGKGFDM <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B6AD60", Offset = "0x7B69F60", VA = "0x187B6AD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C5C0", Offset = "0x7B6B7C0", VA = "0x187B6C5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KNNIFBGNJAE : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IHLMKJGLLAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public KNNIFBGNJAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B69570", Offset = "0x7B68770", VA = "0x187B69570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A260", Offset = "0x7B69460", VA = "0x187B6A260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int NDHDNMBNCAL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan KOFIJOIMNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer MEGDADJGEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter DMIJKJIKOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject AOBKFLAGBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CPAAODJMBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IBNMCDFEFDM PAFBDEOFPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<LHKGDGIKFCG> KILFJOBEMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<LHKGDGIKFCG> IAGGJLPBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<LHKGDGIKFCG> DIEPMPCBAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int IECEJJPKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BICOEDHKJGJ CPJLPGPKMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<MIEOPCAMENN>[] EMOJFPOKLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<PENGHGJLNKN>[] DNCOJGCCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource OKKGPMJBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool JKKJMJLILEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private AFABIGEDGFJ BHANKLMANBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AFABIGEDGFJ LKHPGEFHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int HEJBBJLEMDG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static IHLMKJGLLAD OMHJJKGOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JGINAFPCOLC FKOPIMPCAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JIJIALNGECN POMEBPPDOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour GKGBHOPBEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material FADIHEMJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> GNDFGALLHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material CIELEDMCPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> IDJEMMHEKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool IJPNJCEGLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<JMKDBBNBJDD> MBMDBEODHKI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig DGOIGJBIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 FFEBJPIHICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC1D0", Offset = "0x1EBB3D0", VA = "0x181EBC1D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC0F0", Offset = "0x1EBB2F0", VA = "0x181EBC0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BICOEDHKJGJ NLLEDCBKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF51900", Offset = "0xF50B00", VA = "0x180F51900")]
		get
		{
			return default(BICOEDHKJGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B65330", Offset = "0x7B64530", VA = "0x187B65330")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IHLMKJGLLAD AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B63500", Offset = "0x7B62700", VA = "0x187B63500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool HOCFGGANKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B63550", Offset = "0x7B62750", VA = "0x187B63550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool EHBODGIHHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B656C0", Offset = "0x7B648C0", VA = "0x187B656C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> MIILCNKNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B65550", Offset = "0x7B64750", VA = "0x187B65550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B65920", Offset = "0x7B64B20", VA = "0x187B65920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PKONPPOLMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B65DA0", Offset = "0x7B64FA0", VA = "0x187B65DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B65610", Offset = "0x7B64810", VA = "0x187B65610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B66840", Offset = "0x7B65A40", VA = "0x187B66840")]
	public IHLMKJGLLAD(JGINAFPCOLC FKOPIMPCAJN, JIJIALNGECN POMEBPPDOOI, ClusterLODConfig FECHBEMLFPL, MonoBehaviour GKGBHOPBEBI, Material CMHEPFDLBHA, ClusterMeshRenderer MEGDADJGEEG, MeshFilter DMIJKJIKOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B65C30", Offset = "0x7B64E30", VA = "0x187B65C30")]
	private void MJMIAFEGFDG(Material CMHEPFDLBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B663A0", Offset = "0x7B655A0", VA = "0x187B663A0")]
	public void PCAMPCMIANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B64060", Offset = "0x7B63260", VA = "0x187B64060")]
	public static OBIAGGAMNIO.EGOHCGPMAAB ELNJCPHCGFI(OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG)
	{
		return default(OBIAGGAMNIO.EGOHCGPMAAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B63C90", Offset = "0x7B62E90", VA = "0x187B63C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B65460", Offset = "0x7B64660", VA = "0x187B65460")]
	public static void ICMOKGCNJDO(Vector3 ONFEHGEGFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B66740", Offset = "0x7B65940", VA = "0x187B66740")]
	private void PPKCHIDPEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B650E0", Offset = "0x7B642E0", VA = "0x187B650E0")]
	private void GBCJGJNIHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B665F0", Offset = "0x7B657F0", VA = "0x187B665F0")]
	private void PNPJCEOGNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B64A90", Offset = "0x7B63C90", VA = "0x187B64A90")]
	public void FMHLECDPMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B65800", Offset = "0x7B64A00", VA = "0x187B65800")]
	[AsyncStateMachine(typeof(MNKLJJLJDBP))]
	public Task LBBDNGOAGDO(BGHCJGPGCNF<string>.IPAINGKGFDM DEPOJHOKJEM, CancellationToken CDMFGCJPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B659E0", Offset = "0x7B64BE0", VA = "0x187B659E0")]
	[IteratorStateMachine(typeof(IIKHKBILKKI))]
	private IEnumerator<NOFGPJFCPHG> LJDNOMHKGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B65A60", Offset = "0x7B64C60", VA = "0x187B65A60")]
	[AsyncStateMachine(typeof(MHNLGMBGAFL))]
	private Task LNPBNLLHIFA(BGHCJGPGCNF<string>.IPAINGKGFDM KPFMNIFOMLN, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B63680", Offset = "0x7B62880", VA = "0x187B63680")]
	public void CKNOJMBNBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B65780", Offset = "0x7B64980", VA = "0x187B65780")]
	public void KOHKCFBKNPJ(IEnumerable<MIEOPCAMENN> PGOMDAKDMEK, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B65E50", Offset = "0x7B65050", VA = "0x187B65E50")]
	public void NBJKPKDFNBO(IEnumerable<MIEOPCAMENN> PGOMDAKDMEK, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B64450", Offset = "0x7B63650", VA = "0x187B64450")]
	public List<ClusterMeshRenderer> FJGKLAPJCKB(List<LHKGDGIKFCG> OJKBBJPHBDK, DONKIJIPKJK OLEJNEHCCLF, DMGADPKJDGN BMDFOPHBMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B65B80", Offset = "0x7B64D80", VA = "0x187B65B80")]
	public void MCNHPEDLJKL(JMKDBBNBJDD HDLKGPOEBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B662B0", Offset = "0x7B654B0", VA = "0x187B662B0")]
	public bool NPHDHFBIEBL(JMKDBBNBJDD HDLKGPOEBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B63880", Offset = "0x7B62A80", VA = "0x187B63880")]
	public void CNBMEMGEBDP(LHKGDGIKFCG JOJIGAABDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B63B30", Offset = "0x7B62D30", VA = "0x187B63B30")]
	public void DGKDJIPMIMJ(PENGHGJLNKN ALLIBLOLGHD, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B64A10", Offset = "0x7B63C10", VA = "0x187B64A10")]
	public void FMHBPOENIDJ(PENGHGJLNKN ALLIBLOLGHD, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B651B0", Offset = "0x7B643B0", VA = "0x187B651B0")]
	private void GNDDGHFECEH(Vector3 ICPEADDPOJA, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B66150", Offset = "0x7B65350", VA = "0x187B66150")]
	private void NFPMAHAENAI(Vector3 ICPEADDPOJA, DMGADPKJDGN BMDFOPHBMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B63C10", Offset = "0x7B62E10", VA = "0x187B63C10")]
	[IteratorStateMachine(typeof(KNNIFBGNJAE))]
	private IEnumerator<NOFGPJFCPHG> DIABCLEKMHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B639C0", Offset = "0x7B62BC0", VA = "0x187B639C0")]
	private int DFJMFDNELNP(int CMDFFDAPDIB, int DJHBPEKICFK, List<PENGHGJLNKN> IDBENBMFIDC, byte AEABCPDILIB, int AOODCPOFOAG, float BIPCDANOKAJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B66440", Offset = "0x7B65640", VA = "0x187B66440")]
	public void PKCJOLGDFLO(LHKGDGIKFCG JCAGDPHNPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B63640", Offset = "0x7B62840", VA = "0x187B63640")]
	public bool CCPHFOHFMPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA90A30", Offset = "0xA8FC30", VA = "0x180A90A30")]
	public Material DCIOBLKFPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B63930", Offset = "0x7B62B30", VA = "0x187B63930")]
	public Material DCIOBLKFPGK(OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA071D0", Offset = "0xA063D0", VA = "0x180A071D0")]
	public Material OPHBPMHBMAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B66310", Offset = "0x7B65510", VA = "0x187B66310")]
	public Material OPHBPMHBMAA(OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B652F0", Offset = "0x7B644F0", VA = "0x187B652F0")]
	public int HMHJIGJFBPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B64080", Offset = "0x7B63280", VA = "0x187B64080")]
	public (long, int) FADOPJBLKBE()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HADBHPJMHPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> OFFILAFEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> DJAKFEGKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> CCJODAFAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> BJLGOJMOHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> BOCKDNCNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> HGNFNJKAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 FAFAONPDDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float LPMLPMIIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> PEINEECNDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> EEEFJHKJDDN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B62380", Offset = "0x7B61580", VA = "0x187B62380")]
	public HADBHPJMHPB(OBIAGGAMNIO CGGHHEJPJND, NativeList<float3> HGNFNJKAGOG, NativeParallelMultiHashMap<int, int> PEINEECNDBI, NativeArray<int> EEEFJHKJDDN, Vector3 FAFAONPDDMC, float LPMLPMIIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B62320", Offset = "0x7B61520", VA = "0x187B62320")]
	private int MICBKJOGLKK(float3 ICPEADDPOJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B61C80", Offset = "0x7B60E80", VA = "0x187B61C80")]
	private int EMPDIBNMDFK(int HPPAPFGKKNG, int MHDODBCCAJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B61EF0", Offset = "0x7B610F0", VA = "0x187B61EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JBBNCKEFLEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> PEINEECNDBI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> EEEFJHKJDDN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int JOPJGLOMMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> EOPMJHJKKCE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B67650", Offset = "0x7B66850", VA = "0x187B67650")]
	public void CDONPKCPGIP(int AEKPCFCEKPO, Allocator DPAKHKILCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B67840", Offset = "0x7B66A40", VA = "0x187B67840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JBBNCKEFLEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct FNJMLFLDDHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> CLCPLOBPEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> JHDADOPNDPJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B61BF0", Offset = "0x7B60DF0", VA = "0x187B61BF0")]
	public FNJMLFLDDHK(JBBNCKEFLEI CPNEBNEOHBH, OBIAGGAMNIO CGGHHEJPJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B61B40", Offset = "0x7B60D40", VA = "0x187B61B40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct NLBOOHDNGCH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> DGAKPOOIJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> OMMABLHAPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> GECGMPECIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> DCEJBHKNLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> OAICHPLGJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> EOPMJHJKKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> CLCPLOBPEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> JIOKCEOLCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> GHGOCLBMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> DEDDIAICPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> FBKHMKGPPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> LNBCHPNJCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> FICBNHFNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float HHEFAIKEOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float HBOIMFPAFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 NOCFMOGCNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float GIOFOOGFKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float DIILGCPJNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float ADBCFFBIBMG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EA90", Offset = "0x7B6DC90", VA = "0x187B6EA90")]
	public NLBOOHDNGCH(JBBNCKEFLEI DEMJBAPBMGJ, OBIAGGAMNIO CGGHHEJPJND, OBIAGGAMNIO IANILIEADNH, float DIILGCPJNEL, float ADBCFFBIBMG, Vector3 NOCFMOGCNOO, float GIOFOOGFKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E3D0", Offset = "0x7B6D5D0", VA = "0x187B6E3D0")]
	private float3 JHFLOFNCDMN(int HPPAPFGKKNG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E480", Offset = "0x7B6D680", VA = "0x187B6E480")]
	private void MEDFBFJDAEI(int HPPAPFGKKNG, [Out] float3 GFOMBPMLIMB, [Out] float3 MCNPKJKLNND, [Out] float4 ELHCHDPHNIH, [Out] float4 MENAFOOIOAL, [Out] float2 BHAKAOCEBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E660", Offset = "0x7B6D860", VA = "0x187B6E660")]
	private int OEBDKCPOOCP(int FMOJEMICKOG, int LPKILCFBBED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D510", Offset = "0x7B6C710", VA = "0x187B6D510")]
	private void BPNKLEICJGB(int FMOJEMICKOG, int LPKILCFBBED, int PKKECIAAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E940", Offset = "0x7B6DB40", VA = "0x187B6E940")]
	private bool OGLLPHIKCKL(int FMOJEMICKOG, int LPKILCFBBED, float NADLHAKEHEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D710", Offset = "0x7B6C910", VA = "0x187B6D710")]
	private bool DCDOIDBPNAB(int FMOJEMICKOG, int LPKILCFBBED, int PKKECIAAKOF, float NADLHAKEHEM, bool HMIHAKDGAFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D7D0", Offset = "0x7B6C9D0", VA = "0x187B6D7D0")]
	private bool DCOPCDAMEBK(int FMOJEMICKOG, int LPKILCFBBED, int PKKECIAAKOF, float NADLHAKEHEM, bool HMIHAKDGAFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E3B0", Offset = "0x7B6D5B0", VA = "0x187B6E3B0")]
	private void FDDPJKEBGJH(int FMOJEMICKOG, int LPKILCFBBED, int PKKECIAAKOF, [Out] int JEFDKGBGNAF, [Out] int PLJADOOEPBJ, [Out] int GAIMNFADEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DA30", Offset = "0x7B6CC30", VA = "0x187B6DA30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NLPHIOIDKGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JBMCPHJHLDF : IDisposable, PENGHGJLNKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds CMJBIEKALPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<LHKGDGIKFCG> OJKBBJPHBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 MPEJBEGHIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 JEPMBJJPEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int NOEKINHOAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public OBIAGGAMNIO AFEPAMDCHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long OPOFDAJGNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public JBBNCKEFLEI AFEDPNHNKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform OLEJNEHCCLF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int COJPFBBBHAD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B67D30", Offset = "0x7B66F30", VA = "0x187B67D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh NCOCMACKIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OBIAGGAMNIO.EGOHCGPMAAB JENDBLLNNBK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0")]
			[CompilerGenerated]
			get
			{
				return default(OBIAGGAMNIO.EGOHCGPMAAB);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xDC6AF0", Offset = "0xDC5CF0", VA = "0x180DC6AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh FHIMKNNIMAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public OBIAGGAMNIO.EGOHCGPMAAB KLIDKCEENMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xECFF00", Offset = "0xECF100", VA = "0x180ECFF00")]
			[CompilerGenerated]
			get
			{
				return default(OBIAGGAMNIO.EGOHCGPMAAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xECFF90", Offset = "0xECF190", VA = "0x180ECFF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HLNBNEGAPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1105650", Offset = "0x1104850", VA = "0x181105650", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1871790", Offset = "0x1870990", VA = "0x181871790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte ONMOPHIIAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1793A50", Offset = "0x1792C50", VA = "0x181793A50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1793E30", Offset = "0x1793030", VA = "0x181793E30", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OPDLCLPJPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA38270", Offset = "0xA37470", VA = "0x180A38270", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x13F18D0", Offset = "0x13F0AD0", VA = "0x1813F18D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ELMFBGFOPMH
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA29010", Offset = "0xA28210", VA = "0x180A29010", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x13F1F80", Offset = "0x13F1180", VA = "0x1813F1F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OKGODJNJNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7B68090", Offset = "0x7B67290", VA = "0x187B68090", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7B67E20", Offset = "0x7B67020", VA = "0x187B67E20")]
		public void OFBICAIDAHO(JFHEFEBDPBL AEABCPDILIB, [Out] int HIKIJPFMGFD, [Out] int BBBKLBHPKOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B67B60", Offset = "0x7B66D60", VA = "0x187B67B60")]
		public void FKIIKKCMDOD(JFHEFEBDPBL AEABCPDILIB, ABBAFNICANG MMLCEMNKICA, int POPPFCECMBF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7B67D70", Offset = "0x7B66F70", VA = "0x187B67D70")]
		public void LDNGMKJBOLN(Mesh CGGHHEJPJND, OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B67AD0", Offset = "0x7B66CD0", VA = "0x187B67AD0")]
		public void ELNBKAKLICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B67920", Offset = "0x7B66B20", VA = "0x187B67920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B680B0", Offset = "0x7B672B0", VA = "0x187B680B0")]
		public JBMCPHJHLDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds CMJBIEKALPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public OBIAGGAMNIO.EGOHCGPMAAB BLJGGKDMPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<JBMCPHJHLDF> EAHAKGDDGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FMFNKPHHKFL AAIJEAOELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer IMMAKBDNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int ELGLNCOGNNF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OBJAHFCONND
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AFDNNKKOGEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int FKEGMIJDHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B6EBD0", Offset = "0x7B6DDD0", VA = "0x187B6EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EDE0", Offset = "0x7B6DFE0", VA = "0x187B6EDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B70050", Offset = "0x7B6F250", VA = "0x187B70050")]
	public int NJNPEBDGINO(int MDKFBCBCOOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F7E0", Offset = "0x7B6E9E0", VA = "0x187B6F7E0")]
	public void IIDJEGEKDMA(PNEHIKNGPAD HLNLLMEAOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EF60", Offset = "0x7B6E160", VA = "0x187B6EF60")]
	public void FIPAEKEAJJP(Transform AMGEMGHCOFE, bool INCAPEDPOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EC20", Offset = "0x7B6DE20", VA = "0x187B6EC20")]
	public bool CEMKHPEKBGO(bool DPPOAOEGIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FA30", Offset = "0x7B6EC30", VA = "0x187B6FA30")]
	public void IJJJCJNEEKK(Transform OLEJNEHCCLF, bool INCAPEDPOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B70080", Offset = "0x7B6F280", VA = "0x187B70080")]
	public bool PKCJOLGDFLO(LHKGDGIKFCG JCAGDPHNPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B702F0", Offset = "0x7B6F4F0", VA = "0x187B702F0")]
	public NLPHIOIDKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IBNMCDFEFDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<NLPHIOIDKGE.JBMCPHJHLDF> BHJMCCGDPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private PCMALCKMBKN FOPKELLKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<NLPHIOIDKGE.JBMCPHJHLDF> MGNKEAKHPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int PJBKONCDKGJ;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B62630", Offset = "0x7B61830", VA = "0x187B62630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B62EF0", Offset = "0x7B620F0", VA = "0x187B62EF0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B62B10", Offset = "0x7B61D10", VA = "0x187B62B10")]
	public void LHOMNBOIMGH(NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP, Transform OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B630B0", Offset = "0x7B622B0", VA = "0x187B630B0")]
	public void PKCJOLGDFLO(NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B62F70", Offset = "0x7B62170", VA = "0x187B62F70")]
	private NLPHIOIDKGE.JBMCPHJHLDF PAMPECFMFIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B62710", Offset = "0x7B61910", VA = "0x187B62710")]
	private bool GLAIHMIEBEA(NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B62550", Offset = "0x7B61750", VA = "0x187B62550")]
	private void BFEAEGDOMCF(NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B62600", Offset = "0x7B61800", VA = "0x187B62600")]
	public bool DGKCBGMPPOI(NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B62820", Offset = "0x7B61A20", VA = "0x187B62820")]
	public bool KJFMNLEBHBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B627B0", Offset = "0x7B619B0", VA = "0x187B627B0")]
	private NLPHIOIDKGE.JBMCPHJHLDF HFEOFDIALAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B62BD0", Offset = "0x7B61DD0", VA = "0x187B62BD0")]
	public long NHDOBDJPCFL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B63290", Offset = "0x7B62490", VA = "0x187B63290")]
	public IBNMCDFEFDM()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class INKBNJDJIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int GBEDGCCHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int PIKCMABPEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float KGOHHDBEELF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<NLPHIOIDKGE> HFMFLLNLPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B67600", Offset = "0x7B66800", VA = "0x187B67600")]
	public INKBNJDJIJO(int GBEDGCCHKIO, int PIKCMABPEOI, float FKJECGIADOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B674B0", Offset = "0x7B666B0", VA = "0x187B674B0")]
	public void OFKLHJHOOFC(AIMGAMMCKGP PLBMBEGACCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B67140", Offset = "0x7B66340", VA = "0x187B67140")]
	private int KINOJEBEKMH(PNEHIKNGPAD HFACGLFOMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B671F0", Offset = "0x7B663F0", VA = "0x187B671F0")]
	private void OFKLHJHOOFC(PNEHIKNGPAD HFACGLFOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B67560", Offset = "0x7B66760", VA = "0x187B67560")]
	private void PAJGHCGNDEG(PNEHIKNGPAD HFACGLFOMBB, NLPHIOIDKGE EOMLDCDGGFM)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, MIEOPCAMENN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LCCOADAPGBL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
			[DebuggerHidden]
			public LCCOADAPGBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A750", Offset = "0x7B69950", VA = "0x187B6A750", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A910", Offset = "0x7B69B10", VA = "0x187B6A910", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A860", Offset = "0x7B69A60", VA = "0x187B6A860", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A860", Offset = "0x7B69A60", VA = "0x187B6A860", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int FKEGMIJDHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B5DBC0", Offset = "0x7B5CDC0", VA = "0x187B5DBC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<PENGHGJLNKN> KCABHCCKGDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7B5DBA0", Offset = "0x7B5CDA0", VA = "0x187B5DBA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> EAHAKGDDGCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NLPHIOIDKGE OBJAHFCONND
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public DMGADPKJDGN GCPHBIHLCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DMGADPKJDGN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA036C0", Offset = "0xA028C0", VA = "0x180A036C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ADOIHEMIPIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xCB7770", Offset = "0xCB6970", VA = "0x180CB7770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C0F0", Offset = "0x7B5B2F0", VA = "0x187B5C0F0")]
		public static ClusterMeshRenderer Create(NLPHIOIDKGE CGGHHEJPJND, ClusterMeshRenderer MEGDADJGEEG, MeshFilter DMIJKJIKOHP, DONKIJIPKJK OLEJNEHCCLF, DMGADPKJDGN BMDFOPHBMNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C370", Offset = "0x7B5B570", VA = "0x187B5C370", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CEE0", Offset = "0x7B5C0E0", VA = "0x187B5CEE0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(LHKGDGIKFCG JCAGDPHNPIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CC90", Offset = "0x7B5BE90", VA = "0x187B5CC90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C8B0", Offset = "0x7B5BAB0", VA = "0x187B5C8B0")]
		public void Init(NLPHIOIDKGE CGGHHEJPJND, MeshFilter DMIJKJIKOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C3D0", Offset = "0x7B5B5D0", VA = "0x187B5C3D0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CFA0", Offset = "0x7B5C1A0", VA = "0x187B5CFA0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 ICPEADDPOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D250", Offset = "0x7B5C450", VA = "0x187B5D250", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C830", Offset = "0x7B5BA30", VA = "0x187B5C830")]
		[IteratorStateMachine(typeof(LCCOADAPGBL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CD20", Offset = "0x7B5BF20", VA = "0x187B5CD20")]
		public void SetupTagAndLayer(string BGOPKLLOOIA, int BMDFOPHBMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CD00", Offset = "0x7B5BF00", VA = "0x187B5CD00")]
		public bool Remove(LHKGDGIKFCG JCAGDPHNPIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OBLCCJDKMKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int EHFCEKGDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KOKMPCAPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BBBKLBHPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int HIKIJPFMGFD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B703C0", Offset = "0x7B6F5C0", VA = "0x187B703C0")]
	public OBLCCJDKMKK(int KOKMPCAPCJD, int BBBKLBHPKOI, int EHFCEKGDPGE, int HIKIJPFMGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FMFNKPHHKFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> EOPMJHJKKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> BOCKDNCNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<OBLCCJDKMKK> KOKIHNIKEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> EENGLMGAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> BNOCONEPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> DOJMFHJNFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle KHHGIDEGAOE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GDGBNFIFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA31720", Offset = "0xA30920", VA = "0x180A31720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA30CD0", Offset = "0xA2FED0", VA = "0x180A30CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B60C40", Offset = "0x7B5FE40", VA = "0x187B60C40")]
	public void IJDFNMPLFGP(OBIAGGAMNIO HIIGGHNIFFE, NativeList<OBLCCJDKMKK> KOKIHNIKEMN, float GPOEDAABNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B60700", Offset = "0x7B5F900", VA = "0x187B60700")]
	public void BHHPJIHBCDG(Transform OLEJNEHCCLF, bool INCAPEDPOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B60990", Offset = "0x7B5FB90", VA = "0x187B60990")]
	public void CEMKHPEKBGO(NLPHIOIDKGE IMMAKBDNFNI, bool DPPOAOEGIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B60B30", Offset = "0x7B5FD30", VA = "0x187B60B30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B61B10", Offset = "0x7B60D10", VA = "0x187B61B10")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public FMFNKPHHKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct BMMGBBMBCAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> FDOENJHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> EOPMJHJKKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<OBLCCJDKMKK> MLMJCPLEOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> EENGLMGAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 NOCFMOGCNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> BNOCONEPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> DOJMFHJNFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool INCAPEDPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float JGMNKFEJBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float GHALDILIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float CLNPNIOFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> BOCKDNCNDFL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BEF0", Offset = "0x7B5B0F0", VA = "0x187B5BEF0")]
	public BMMGBBMBCAF(FMFNKPHHKFL CGEJCAFPDKJ, Vector3 NOCFMOGCNOO, bool INCAPEDPOLA, float JGMNKFEJBMC, float GHALDILIALG, float CLNPNIOFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B9F0", Offset = "0x7B5ABF0", VA = "0x187B5B9F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LHKGDGIKFCG : GAPLKABMPAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds HKKFFKOAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PNEHIKNGPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<LHKGDGIKFCG> OJKBBJPHBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public PNEHIKNGPAD FLKKOCNDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public PNEHIKNGPAD KMAJACIDOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public PNEHIKNGPAD GPFPMOBIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int HIKIJPFMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds CMJBIEKALPE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B71B70", Offset = "0x7B70D70", VA = "0x187B71B70")]
	public PNEHIKNGPAD(List<LHKGDGIKFCG> OJKBBJPHBDK, [Optional] PNEHIKNGPAD FLKKOCNDECC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AIMGAMMCKGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<PNEHIKNGPAD> CDGAIHBFGNC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PNEHIKNGPAD LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B8C0", Offset = "0x7B5AAC0", VA = "0x187B5B8C0")]
	public AIMGAMMCKGP(PNEHIKNGPAD OLEJNEHCCLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FBIFGHPFEJA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LANDEJAHDAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int BFINGHOOGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int FGLFDJJFPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DCPKGAEHAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int CPJABKOHGMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FNLMJCPNDJP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int PNAKBPBMKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float MCDIKJCLKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<LHKGDGIKFCG> OJKBBJPHBDK;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B61C20", Offset = "0x7B60E20", VA = "0x187B61C20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HNLOCGCMPNL
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
	private LANDEJAHDAP HKALEBINDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int GLGGOKPHLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int GBEDGCCHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int PIKCMABPEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float FKJECGIADOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float AMDMJECBEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<PNEHIKNGPAD> HBKBPOKDJJA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AIMGAMMCKGP PEDIEBONJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B606A0", Offset = "0x7B5F8A0", VA = "0x187B606A0")]
	public FBIFGHPFEJA(int GBEDGCCHKIO, int PIKCMABPEOI, float FKJECGIADOP, int GLGGOKPHLIP, float AMDMJECBEBO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B603A0", Offset = "0x7B5F5A0", VA = "0x187B603A0")]
	public void LPPDPEEOPPG(List<LHKGDGIKFCG> OJKBBJPHBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B605C0", Offset = "0x7B5F7C0", VA = "0x187B605C0")]
	public bool OMCDFCGEAGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B60650", Offset = "0x7B5F850", VA = "0x187B60650")]
	private float PIDHEMHFDKF(Vector3 FHHDCGHGHIP, Vector3 AFOBMPBBEDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B60630", Offset = "0x7B5F830", VA = "0x187B60630")]
	private float PIDHEMHFDKF(Vector3 GCFCAGDGDIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E890", Offset = "0x7B5DA90", VA = "0x187B5E890")]
	private bool HHCKENOKECH(PNEHIKNGPAD LFPNJLPLJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F350", Offset = "0x7B5E550", VA = "0x187B5F350")]
	private FNLMJCPNDJP KANGPHJPEOO(List<LHKGDGIKFCG> AOMKOJNAFEM, HNLOCGCMPNL EEEICBALCGN)
	{
		return default(FNLMJCPNDJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E4D0", Offset = "0x7B5D6D0", VA = "0x187B5E4D0")]
	private void ENHNJIHBJCC(List<LHKGDGIKFCG> OJKBBJPHBDK, NativeArray<Vector3> GADDDDMLHJF, NativeArray<Vector3> JPBOKOFCJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class MHNGKOKBFEB
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A9C0", Offset = "0x7B69BC0", VA = "0x187B6A9C0")]
	public static Bounds KOPFAKKNFEO(List<LHKGDGIKFCG> OJKBBJPHBDK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AB90", Offset = "0x7B69D90", VA = "0x187B6AB90")]
	public static int NBFOPEBCFOD(List<LHKGDGIKFCG> OJKBBJPHBDK, JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class NFFDJCBFNLI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool HDEIGBNKLDI(float4* BJLGOJMOHMO, int CLBDAFJFHFB);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class MNONLPHLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D1E0", Offset = "0x7B6C3E0", VA = "0x187B6D1E0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D090", Offset = "0x7B6C290", VA = "0x187B6D090")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CE10", Offset = "0x7B6C010", VA = "0x187B6CE10")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CEB0", Offset = "0x7B6C0B0", VA = "0x187B6CEB0")]
		public unsafe static bool CLNGLIDPKMF(float4* BJLGOJMOHMO, int CLBDAFJFHFB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D300", Offset = "0x7B6C500", VA = "0x187B6D300")]
	[BurstCompile]
	public unsafe static bool EABDMNCKOEK(float4* BJLGOJMOHMO, int CLBDAFJFHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B5E0", Offset = "0x7B5A7E0", VA = "0x187B5B5E0")]
	[BurstCompile]
	public unsafe static bool NCOIJGCJAFP(float4* BJLGOJMOHMO, int CLBDAFJFHFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct DCJBLGLJPDO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> LMHHBOPHABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> PIOFNOHANHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> LJNGMMFPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> BMLBAMFLPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> ODDDDLMECFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> CCJODAFAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> HIJPJAHPKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> CHOHIBPJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<OBIAGGAMNIO.EHBHNGLLMBC> DKILIBDNBAE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DED0", Offset = "0x7B5D0D0", VA = "0x187B5DED0")]
	public DCJBLGLJPDO(OBIAGGAMNIO KAJCHOJJMHK, NativeArray<bool> HIJPJAHPKGC, NativeList<ushort> CHOHIBPJBLL, NativeList<OBIAGGAMNIO.EHBHNGLLMBC> DKILIBDNBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DC20", Offset = "0x7B5CE20", VA = "0x187B5DC20", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct FAMINNLEJLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> LMHHBOPHABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> PIOFNOHANHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> LJNGMMFPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> BMLBAMFLPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> ODDDDLMECFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> CCJODAFAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> NJAKHNJIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> NBODLGNMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> LOCIOPLKJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> JFKFCMHCKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> FKBPGAJNBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> MEKHANMFDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> HIJPJAHPKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> CHOHIBPJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<OBIAGGAMNIO.EHBHNGLLMBC> DKILIBDNBAE;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E410", Offset = "0x7B5D610", VA = "0x187B5E410")]
	public FAMINNLEJLJ(OBIAGGAMNIO KAJCHOJJMHK, OBIAGGAMNIO NBCDCNIELOB, NativeArray<bool> HIJPJAHPKGC, NativeList<ushort> CHOHIBPJBLL, NativeList<OBIAGGAMNIO.EHBHNGLLMBC> DKILIBDNBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5DF40", Offset = "0x7B5D140", VA = "0x187B5DF40", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PCMALCKMBKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private OBIAGGAMNIO HFKBBDFMOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private OBIAGGAMNIO KAJCHOJJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> LBPDLNPKICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> CHOHIBPJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<OBIAGGAMNIO.EHBHNGLLMBC> DKILIBDNBAE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static OBIAGGAMNIO EMMDEDDEEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private PIBCHLIPNBK CBCOHLKBGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private ABBAFNICANG MMLCEMNKICA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle KHHGIDEGAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xD9D600", Offset = "0xD9C800", VA = "0x180D9D600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NLPHIOIDKGE.JBMCPHJHLDF LFPNJLPLJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PGGIBHMHCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x24DD4C0", Offset = "0x24DC6C0", VA = "0x1824DD4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7B71950", Offset = "0x7B70B50", VA = "0x187B71950")]
	[DHCHJGMMEBK(GCHHJKKLOFC.EnteredEditMode, 0)]
	private static void NHMJBNMBPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B70E30", Offset = "0x7B70030", VA = "0x187B70E30")]
	public void IJDFNMPLFGP(NLPHIOIDKGE.JBMCPHJHLDF MLMJCPLEOML, Transform LLHMDEDLAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7B70490", Offset = "0x7B6F690", VA = "0x187B70490")]
	public void BIMDIBJMFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B70D60", Offset = "0x7B6FF60", VA = "0x187B70D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B719C0", Offset = "0x7B70BC0", VA = "0x187B719C0")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B71A00", Offset = "0x7B70C00", VA = "0x187B71A00")]
	public PCMALCKMBKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JIJIALNGECN
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 IDHDFHNLPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JGINAFPCOLC
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(BGHCJGPGCNF<string>.IPAINGKGFDM KPFMNIFOMLN, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PHMAAGBCMMK
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PHMAAGBCMMK LNOOICANIDI(Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHMAAGBCMMK DLLIHDFHCED(Action CJLPDLONOLK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class KPIICJLIEJJ : PHMAAGBCMMK
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class AECHHBKKFGH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public KPIICJLIEJJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
				public AECHHBKKFGH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7B5B7D0", Offset = "0x7B5A9D0", VA = "0x187B5B7D0")]
				internal void GDKNONECNKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7B5B820", Offset = "0x7B5AA20", VA = "0x187B5B820")]
				internal void OPEDODCBKMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7B5B870", Offset = "0x7B5AA70", VA = "0x187B5B870")]
				internal void PIPNGHDDPIM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> BEHGPIGKLJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action EGBNIJLLMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action ONJBILPMMJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private NGDMHLHHJIC FEDOJCFIEJL;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action EHHBCKHLEPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action OMPFMAACGBA
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2823960", Offset = "0x2822B60", VA = "0x182823960", Slot = "4")]
			public PHMAAGBCMMK LNOOICANIDI(Action CJLPDLONOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x74F74D0", Offset = "0x74F66D0", VA = "0x1874F74D0", Slot = "5")]
			public PHMAAGBCMMK DLLIHDFHCED(Action CJLPDLONOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
			public KPIICJLIEJJ(Func<JobHandle> PMLJDHIDIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A2B0", Offset = "0x7B694B0", VA = "0x187B6A2B0")]
			public void JGHBEDNJLDN(Action DFJEFOBOLMB, Action LIJDDDPEDJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7B6A5C0", Offset = "0x7B697C0", VA = "0x187B6A5C0")]
			public void PKCJOLGDFLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class HMPONLNFJNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public PHMAAGBCMMK jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public HMPONLNFJNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7B62540", Offset = "0x7B61740", VA = "0x187B62540")]
			internal bool DBGEJKAIDLH(KPIICJLIEJJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class JBNPDGPJLBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public KPIICJLIEJJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public JBNPDGPJLBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7B681D0", Offset = "0x7B673D0", VA = "0x187B681D0")]
			internal void KOPEAAGGAEO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<KPIICJLIEJJ> JMBHLAFEDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<KPIICJLIEJJ> FMKLLHKMBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private AFABIGEDGFJ ACFOEMHELOK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public PGFLJOGDIEK KBEFPGAODMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B68230", Offset = "0x7B67430", VA = "0x187B68230")]
		public PHMAAGBCMMK Add(Func<JobHandle> PMLJDHIDIIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B68560", Offset = "0x7B67760", VA = "0x187B68560")]
		public void Remove(PHMAAGBCMMK KHHGIDEGAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7B68390", Offset = "0x7B67590", VA = "0x187B68390", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B68740", Offset = "0x7B67940", VA = "0x187B68740")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B689F0", Offset = "0x7B67BF0", VA = "0x187B689F0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B68380", Offset = "0x7B67580", VA = "0x187B68380")]
		[CompilerGenerated]
		private void DOAKJNIMAIE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NGDMHLHHJIC
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGDMHLHHJIC LNOOICANIDI(Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGDMHLHHJIC JIPJIGBGPGA(Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGDMHLHHJIC DLLIHDFHCED(Action CJLPDLONOLK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, DJNFGEJICJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class OPNMBHGNGMO : NGDMHLHHJIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle KNNEBJJIMGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action EGBNIJLLMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action JBDKCHKDIDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action OMPFMAACGBA;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool NIFOKHJINBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7B703E0", Offset = "0x7B6F5E0", VA = "0x187B703E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x72C4DF0", Offset = "0x72C3FF0", VA = "0x1872C4DF0", Slot = "4")]
			public NGDMHLHHJIC LNOOICANIDI(Action CJLPDLONOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x72C4F40", Offset = "0x72C4140", VA = "0x1872C4F40", Slot = "5")]
			public NGDMHLHHJIC JIPJIGBGPGA(Action CJLPDLONOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x74F74D0", Offset = "0x74F66D0", VA = "0x1874F74D0", Slot = "6")]
			public NGDMHLHHJIC DLLIHDFHCED(Action CJLPDLONOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xFAEF80", Offset = "0xFAE180", VA = "0x180FAEF80")]
			public OPNMBHGNGMO(JobHandle GHPPAFODLHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7B703F0", Offset = "0x7B6F5F0", VA = "0x187B703F0")]
			public void NMBGHNGELPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7B70440", Offset = "0x7B6F640", VA = "0x187B70440")]
			public void PKCJOLGDFLO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<OPNMBHGNGMO> MKBMEABCPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> KKABPKAEOKC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GNLOCEOGNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7B69030", Offset = "0x7B68230", VA = "0x187B69030")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1296B40", Offset = "0x1295D40", VA = "0x181296B40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B68AD0", Offset = "0x7B67CD0", VA = "0x187B68AD0")]
		public NGDMHLHHJIC Add(JobHandle GHPPAFODLHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B69390", Offset = "0x7B68590", VA = "0x187B69390")]
		public void Remove(NGDMHLHHJIC KHHGIDEGAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B68E50", Offset = "0x7B68050", VA = "0x187B68E50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B68CA0", Offset = "0x7B67EA0", VA = "0x187B68CA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B68BD0", Offset = "0x7B67DD0", VA = "0x187B68BD0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B69490", Offset = "0x7B68690", VA = "0x187B69490")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2D0E0", VA = "0x180A2DEE0", Slot = "6")]
		private bool DEFMALGKJBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7B71BF0", Offset = "0x7B70DF0", VA = "0x187B71BF0")]
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
