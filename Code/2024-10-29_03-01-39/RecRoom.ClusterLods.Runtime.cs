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
				[Cpp2IlInjected.Address(RVA = "0x6DCF320", Offset = "0x6DCE320", VA = "0x186DCF320")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x9D11C0", Offset = "0x9D01C0", VA = "0x1809D11C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6DCF2E0", Offset = "0x6DCE2E0", VA = "0x186DCF2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DC75D0", Offset = "0x6DC65D0", VA = "0x186DC75D0")]
		public LODSettings EPODHFJOHDE(DGDJKJOFHLA ADNNLIGBFLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DC75E0", Offset = "0x6DC65E0", VA = "0x186DC75E0")]
		public int NLMDPGJJKBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7530", Offset = "0x6DC6530", VA = "0x186DC7530")]
		public int ELBGDGKNJPL(bool NNPJCBHNBJC, Vector3 JLIODFHPCAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7600", Offset = "0x6DC6600", VA = "0x186DC7600")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EFJNKACCOBM
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
public interface ABIPBEAHGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDDLBKFGJDA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ODALGLDABHG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KEHOAPPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JLFHOJNMAAN> FMMCANHBNHI
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
	void UpdateClusterDistances(Vector3 JADOFHDDGIG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(COADCDMDIIO GEICOLLOJJK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JLFHOJNMAAN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FLPDLGGJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int DGIGNANCJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float AIIAGBOCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float IBLEAMGKMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte KNBLAKJMAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AMMMBGOEFFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum HLBIJJLGKIF
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
	private struct AGCOKDGAKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AMMMBGOEFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1820", Offset = "0x6DC0820", VA = "0x186DC1820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1FB0", Offset = "0x6DC0FB0", VA = "0x186DC1FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BEGCGHKAHFE : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AMMMBGOEFFO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public BEGCGHKAHFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6B60", Offset = "0x6DC5B60", VA = "0x186DC6B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6C70", Offset = "0x6DC5C70", VA = "0x186DC6C70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ADAFLIBOPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AMMMBGOEFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFF60", Offset = "0x6DBEF60", VA = "0x186DBFF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC17C0", Offset = "0x6DC07C0", VA = "0x186DC17C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GFDJHBJGNAK : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AMMMBGOEFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public GFDJHBJGNAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9BC0", Offset = "0x6DC8BC0", VA = "0x186DC9BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA8B0", Offset = "0x6DC98B0", VA = "0x186DCA8B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int AOGHOIEHDOJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NOAHEBDDBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer PNEEEHJHHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter JKEMPLELKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject ENEECGDKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject LLBDIIELOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MLJBBLEOAFC PJGCOGMMAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<COADCDMDIIO> IILHKCGFILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<COADCDMDIIO> PBEFMLAOAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<COADCDMDIIO> AJCDPNIKIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int AOLFDPGJBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HLBIJJLGKIF CDEKGAJPFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<ODALGLDABHG>[] OPOIKBNJGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<JLFHOJNMAAN>[] LLNHACBDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource AKDHCGMIJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HBAMPKNECNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private DDGDFMBPLHP BEKJMJIPLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DDGDFMBPLHP AHGHLNBIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NNNPJNMHKOC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static AMMMBGOEFFO IOOACGMIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LNODOLFJJBD LNOMEFKCAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NNFKIFPALDC AEOLHDBMKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour JOLFIMDDKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material FFFFEJBJEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Material DPCNKCCBFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<ABIPBEAHGJO> ECMFCHBNCPP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig AIIPGOFCKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 EAOLCMHDIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C7300", Offset = "0x8C6300", VA = "0x1808C7300")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C6F60", Offset = "0x8C5F60", VA = "0x1808C6F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private HLBIJJLGKIF FJDIDJOIHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB46860", Offset = "0xB45860", VA = "0x180B46860")]
		get
		{
			return default(HLBIJJLGKIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2DA0", Offset = "0x6DC1DA0", VA = "0x186DC2DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AMMMBGOEFFO LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2860", Offset = "0x6DC1860", VA = "0x186DC2860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BANPBPMDGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3B50", Offset = "0x6DC2B50", VA = "0x186DC3B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NHNJBFEAPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DC39D0", Offset = "0x6DC29D0", VA = "0x186DC39D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> PLHBIAGNHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC31D0", Offset = "0x6DC21D0", VA = "0x186DC31D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4B70", Offset = "0x6DC3B70", VA = "0x186DC4B70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OELHPFGJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC28B0", Offset = "0x6DC18B0", VA = "0x186DC28B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2010", Offset = "0x6DC1010", VA = "0x186DC2010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4E50", Offset = "0x6DC3E50", VA = "0x186DC4E50")]
	public AMMMBGOEFFO(LNODOLFJJBD LNOMEFKCAFI, NNFKIFPALDC AEOLHDBMKOF, ClusterLODConfig KLHOJMEEEBK, MonoBehaviour JOLFIMDDKDN, Material IBJFEHFPAPL, ClusterMeshRenderer PNEEEHJHHIO, MeshFilter JKEMPLELKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2B10", Offset = "0x6DC1B10", VA = "0x186DC2B10")]
	private void CCMBIDJLLBC(Material IBJFEHFPAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DC30D0", Offset = "0x6DC20D0", VA = "0x186DC30D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4910", Offset = "0x6DC3910", VA = "0x186DC4910")]
	public static void MGAJAKGBGJG(Vector3 BOLKDBMFPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4C70", Offset = "0x6DC3C70", VA = "0x186DC4C70")]
	private void NNHLGIICCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DC20C0", Offset = "0x6DC10C0", VA = "0x186DC20C0")]
	private void AHBLNLLHKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DC47C0", Offset = "0x6DC37C0", VA = "0x186DC47C0")]
	private void LNCLIPIPDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2210", Offset = "0x6DC1210", VA = "0x186DC2210")]
	public void BANIPKJGAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4620", Offset = "0x6DC3620", VA = "0x186DC4620")]
	[AsyncStateMachine(typeof(AGCOKDGAKDA))]
	public Task LFABEKGFPBK(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2190", Offset = "0x6DC1190", VA = "0x186DC2190")]
	[IteratorStateMachine(typeof(BEGCGHKAHFE))]
	private IEnumerator<MIAEKAOKMEH> ALEAHABODFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2C80", Offset = "0x6DC1C80", VA = "0x186DC2C80")]
	[AsyncStateMachine(typeof(ADAFLIBOPBG))]
	private Task CMNLFILJCAH(NPOAFBCOAIB<string>.HFMLKGGDOCE KADLCMJLHCH, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2ED0", Offset = "0x6DC1ED0", VA = "0x186DC2ED0")]
	public void DIEMOCCOBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC45A0", Offset = "0x6DC35A0", VA = "0x186DC45A0")]
	public void KJPICMBEJPM(IEnumerable<ODALGLDABHG> MAJIIAMFOFD, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3DA0", Offset = "0x6DC2DA0", VA = "0x186DC3DA0")]
	public void JCIMFNGJECK(IEnumerable<ODALGLDABHG> MAJIIAMFOFD, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3290", Offset = "0x6DC2290", VA = "0x186DC3290")]
	public List<ClusterMeshRenderer> GOKPDCNBNCC(List<COADCDMDIIO> PPMCBPEDFHJ, LBKJBKIAMOO BAOAKGNNKEP, EFJNKACCOBM BKMADAFHHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DC40A0", Offset = "0x6DC30A0", VA = "0x186DC40A0")]
	public void JPNLMKKJOOC(ABIPBEAHGJO OJPJLLAOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4D80", Offset = "0x6DC3D80", VA = "0x186DC4D80")]
	public bool OLHFCIBHNCD(ABIPBEAHGJO OJPJLLAOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3970", Offset = "0x6DC2970", VA = "0x186DC3970")]
	public void HLOBFCNJGIG(COADCDMDIIO IEIJOIJALCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4D00", Offset = "0x6DC3D00", VA = "0x186DC4D00")]
	public void OKGHBJOAAAB(JLFHOJNMAAN GDCFNEAPALI, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3A90", Offset = "0x6DC2A90", VA = "0x186DC3A90")]
	public void IMMJAABOPCI(JLFHOJNMAAN GDCFNEAPALI, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4460", Offset = "0x6DC3460", VA = "0x186DC4460")]
	private void KJIEEJDKKOH(Vector3 JADOFHDDGIG, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3C40", Offset = "0x6DC2C40", VA = "0x186DC3C40")]
	private void JBMNJDMGKCG(Vector3 JADOFHDDGIG, EFJNKACCOBM BKMADAFHHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4740", Offset = "0x6DC3740", VA = "0x186DC4740")]
	[IteratorStateMachine(typeof(GFDJHBJGNAK))]
	private IEnumerator<MIAEKAOKMEH> LMFOPAMGIJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4A00", Offset = "0x6DC3A00", VA = "0x186DC4A00")]
	private int NDFALAKMHOB(int KHAIDMGPIED, int EKBBNEKFIGO, List<JLFHOJNMAAN> EBCNCDCMLDL, byte ADNNLIGBFLK, int BNBICJIFJLI, float NECLJCABDGJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2960", Offset = "0x6DC1960", VA = "0x186DC2960")]
	public void CAKBCGBONLK(COADCDMDIIO GEICOLLOJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3B10", Offset = "0x6DC2B10", VA = "0x186DC3B10")]
	public bool INKFOOIHJIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x93E360", Offset = "0x93D360", VA = "0x18093E360")]
	public Material PKCEIAOPDEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA16F90", Offset = "0xA15F90", VA = "0x180A16F90")]
	public Material MJNIBPDIOGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4C30", Offset = "0x6DC3C30", VA = "0x186DC4C30")]
	public int NLMDPGJJKBN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4100", Offset = "0x6DC3100", VA = "0x186DC4100")]
	public long KFMBBFBHENF()
	{
		return default(long);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BEONBKLDFJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> KPBBNHCKHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> BGMCNPGNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> PKEHEAPGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> MFOPOMGNCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 PHBEGGPBMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float KIOJKBAFLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeParallelMultiHashMap<int, int> LKDNBKOMPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> PKMDPECJABE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DC73C0", Offset = "0x6DC63C0", VA = "0x186DC73C0")]
	public BEONBKLDFJO(CBBOFCDCFKM BKGAJHNMIBN, NativeList<float3> MFOPOMGNCJN, NativeParallelMultiHashMap<int, int> LKDNBKOMPPN, NativeArray<int> PKMDPECJABE, Vector3 PHBEGGPBMFK, float KIOJKBAFLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7360", Offset = "0x6DC6360", VA = "0x186DC7360")]
	private int JDMHNJPICBP(float3 JADOFHDDGIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6CC0", Offset = "0x6DC5CC0", VA = "0x186DC6CC0")]
	private int ABFOIJAINBC(int MEJGJHNGKCJ, int MLAECOMLIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6F30", Offset = "0x6DC5F30", VA = "0x186DC6F30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KEGJLNGIJPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeParallelMultiHashMap<int, int> LKDNBKOMPPN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> PKMDPECJABE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int EBPLJIHGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> LCMBPODCOBP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD940", Offset = "0x6DCC940", VA = "0x186DCD940")]
	public void MHPNOLCFFPN(int EAANJJKLLEP, Allocator HHJAFJNPHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD860", Offset = "0x6DCC860", VA = "0x186DCD860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public KEGJLNGIJPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct JLHBBLHFABD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> BFNHMBMNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> MPGHIIIJOGI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB8E0", Offset = "0x6DCA8E0", VA = "0x186DCB8E0")]
	public JLHBBLHFABD(KEGJLNGIJPC JNCLMFFJMKL, CBBOFCDCFKM BKGAJHNMIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB830", Offset = "0x6DCA830", VA = "0x186DCB830", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct KFINHGBIKAD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> CODOCLDAHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> DOMEJMNJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> CNMLJIHBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> BMIOIHPCHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> LNGCLGMCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> LCMBPODCOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> BFNHMBMNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> PDDDJMKBBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> HCGKCBDNBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> JEJAKOAKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> OOAIICFNFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> HBKJIKCODDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> NEOGBNMBBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float LBOLHKFDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float CGGEKGPCEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 BJHBJBGMPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float APDKPHIMOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float CAJIBOOOION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float OCANAPGPKID;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF0B0", Offset = "0x6DCE0B0", VA = "0x186DCF0B0")]
	public KFINHGBIKAD(KEGJLNGIJPC FGIACKKIILI, CBBOFCDCFKM BKGAJHNMIBN, CBBOFCDCFKM KALLCPCACME, float CAJIBOOOION, float OCANAPGPKID, Vector3 BJHBJBGMPGL, float APDKPHIMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEB90", Offset = "0x6DCDB90", VA = "0x186DCEB90")]
	private float3 HFCFJJCMMGD(int MEJGJHNGKCJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE030", Offset = "0x6DCD030", VA = "0x186DCE030")]
	private void EAMKJPAEFIP(int MEJGJHNGKCJ, [Out] float3 HKDEANDGGCE, [Out] float3 DOGMIGHAMGD, [Out] float4 MOEOGHJCGIK, [Out] float4 CPCBHGHEKPH, [Out] float2 KOPPHALHJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDD50", Offset = "0x6DCCD50", VA = "0x186DCDD50")]
	private int DJJLFGCGOBO(int FHLCBNIPMKL, int FHKPBEPEDKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDB30", Offset = "0x6DCCB30", VA = "0x186DCDB30")]
	private void BMNBDLFHJOA(int FHLCBNIPMKL, int FHKPBEPEDKH, int JCOFOCAJCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEF60", Offset = "0x6DCDF60", VA = "0x186DCEF60")]
	private bool PGHLIODOBKH(int FHLCBNIPMKL, int FHKPBEPEDKH, float GKHJKCIIPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEEA0", Offset = "0x6DCDEA0", VA = "0x186DCEEA0")]
	private bool OKBCNIEBKDD(int FHLCBNIPMKL, int FHKPBEPEDKH, int JCOFOCAJCDJ, float GKHJKCIIPIC, bool LLDBAILDCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEC40", Offset = "0x6DCDC40", VA = "0x186DCEC40")]
	private bool IDMGAOIDNGK(int FHLCBNIPMKL, int FHKPBEPEDKH, int JCOFOCAJCDJ, float GKHJKCIIPIC, bool LLDBAILDCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDD30", Offset = "0x6DCCD30", VA = "0x186DCDD30")]
	private void CCDBBKOPDFD(int FHLCBNIPMKL, int FHKPBEPEDKH, int JCOFOCAJCDJ, [Out] int BLNCNGPGLFP, [Out] int JLDCFPLOJME, [Out] int CDAELAEKHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE210", Offset = "0x6DCD210", VA = "0x186DCE210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NDPAJDKHEFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class EBLDDOOONLJ : IDisposable, JLFHOJNMAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds JOEJONILJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<COADCDMDIIO> PPMCBPEDFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 KGNLOBOLBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 MLJIOOONDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int AJJAGGNELFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CBBOFCDCFKM GIDAELMFKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public long MLMNGEJIAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KEGJLNGIJPC PMAMMBILJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Transform BAOAKGNNKEP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int GICFLNDMPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6DC9150", Offset = "0x6DC8150", VA = "0x186DC9150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KGELFOGKOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh JBBHLAHFAJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B9ED0", Offset = "0x8B8ED0", VA = "0x1808B9ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float AIIAGBOCOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xC5F190", Offset = "0xC5E190", VA = "0x180C5F190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE8E3F0", Offset = "0xE8D3F0", VA = "0x180E8E3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte KNBLAKJMAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB19BA0", Offset = "0xB18BA0", VA = "0x180B19BA0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xB19CE0", Offset = "0xB18CE0", VA = "0x180B19CE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FLPDLGGJCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9D9260", Offset = "0x9D8260", VA = "0x1809D9260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9D91E0", Offset = "0x9D81E0", VA = "0x1809D91E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int DGIGNANCJIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xADB8D0", Offset = "0xADA8D0", VA = "0x180ADB8D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x12AFE90", Offset = "0x12AEE90", VA = "0x1812AFE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float IBLEAMGKMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6DC9130", Offset = "0x6DC8130", VA = "0x186DC9130", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8ED0", Offset = "0x6DC7ED0", VA = "0x186DC8ED0")]
		public void FEHIDBLOBAP(DGDJKJOFHLA ADNNLIGBFLK, [Out] int JEFGJPLLPLK, [Out] int BGPCLMCBMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9220", Offset = "0x6DC8220", VA = "0x186DC9220")]
		public void OPOEMGOKBCI(DGDJKJOFHLA ADNNLIGBFLK, FEBLINHAPNG POCEOANFAHJ, int GPCNCPNJMHG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8C80", Offset = "0x6DC7C80", VA = "0x186DC8C80")]
		public void AMCLAAHIEOA(Mesh BKGAJHNMIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9190", Offset = "0x6DC8190", VA = "0x186DC9190")]
		public void OFGBHAFPAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8D20", Offset = "0x6DC7D20", VA = "0x186DC8D20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6DC93F0", Offset = "0x6DC83F0", VA = "0x186DC93F0")]
		public EBLDDOOONLJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds JOEJONILJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<EBLDDOOONLJ> JHLEEOLGEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public BBBFOLFECKN LFDODCDJAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer MPFENKGEFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int DLDKAPIFKMD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HGCBFKPEGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PKBFIDJIJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x93B330", Offset = "0x93A330", VA = "0x18093B330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x93A590", Offset = "0x939590", VA = "0x18093A590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KEHOAPPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD0B20", Offset = "0x6DCFB20", VA = "0x186DD0B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0B70", Offset = "0x6DCFB70", VA = "0x186DD0B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD16B0", Offset = "0x6DD06B0", VA = "0x186DD16B0")]
	public int MKCNFNNPLDE(int CIPGEFCOGOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1310", Offset = "0x6DD0310", VA = "0x186DD1310")]
	public void KCDJPHEKPPG(FGBFHFMOPCE BNLNMOKGBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0120", Offset = "0x6DCF120", VA = "0x186DD0120")]
	public void BNKNNFECLHC(Transform KNPJEDGMHIK, bool HDHBCHHPGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6DD14F0", Offset = "0x6DD04F0", VA = "0x186DD14F0")]
	public bool MFCPFCOHPDH(bool FMNPEIOBNLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0CF0", Offset = "0x6DCFCF0", VA = "0x186DD0CF0")]
	public void FCOGPEFLNGH(Transform BAOAKGNNKEP, bool HDHBCHHPGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6DD08B0", Offset = "0x6DCF8B0", VA = "0x186DD08B0")]
	public bool CAKBCGBONLK(COADCDMDIIO GEICOLLOJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DD16E0", Offset = "0x6DD06E0", VA = "0x186DD16E0")]
	public NDPAJDKHEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MLJBBLEOAFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Queue<NDPAJDKHEFP.EBLDDOOONLJ> CDNBHHLOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private JPKJHMEEKAO IMJODNILILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NDPAJDKHEFP.EBLDDOOONLJ> IGNGFHIJEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int AIFBMPINOLL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF520", Offset = "0x6DCE520", VA = "0x186DCF520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF830", Offset = "0x6DCE830", VA = "0x186DCF830")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFEB0", Offset = "0x6DCEEB0", VA = "0x186DCFEB0")]
	public void OPFOFHIGBEE(NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD, Transform BAOAKGNNKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF340", Offset = "0x6DCE340", VA = "0x186DCF340")]
	public void CAKBCGBONLK(NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF9B0", Offset = "0x6DCE9B0", VA = "0x186DCF9B0")]
	private NDPAJDKHEFP.EBLDDOOONLJ ICHLKAHBJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF8B0", Offset = "0x6DCE8B0", VA = "0x186DCF8B0")]
	private bool GDJHGPCPGCL(NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF950", Offset = "0x6DCE950", VA = "0x186DCF950")]
	private void HGEHCMCHIGP(NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFAF0", Offset = "0x6DCEAF0", VA = "0x186DCFAF0")]
	public bool INOGCMCNPEO(NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF5A0", Offset = "0x6DCE5A0", VA = "0x186DCF5A0")]
	public bool ECKIEDCBBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFB20", Offset = "0x6DCEB20", VA = "0x186DCFB20")]
	private NDPAJDKHEFP.EBLDDOOONLJ JMIOCCCIGDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFB90", Offset = "0x6DCEB90", VA = "0x186DCFB90")]
	public long KFMBBFBHENF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF70", Offset = "0x6DCEF70", VA = "0x186DCFF70")]
	public MLJBBLEOAFC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GPNDMNIKHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FHLFDNCNLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int GDLMJAHNGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private float ECDOEJPNOBO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<NDPAJDKHEFP> DBCAAEAGJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6DCAEB0", Offset = "0x6DC9EB0", VA = "0x186DCAEB0")]
	public GPNDMNIKHIJ(int FHLFDNCNLOJ, int GDLMJAHNGDM, float FEMPJIEGNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6DCABC0", Offset = "0x6DC9BC0", VA = "0x186DCABC0")]
	public void LIIINIGLFOL(IMKEIELIMOL BAAAMGHHPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA900", Offset = "0x6DC9900", VA = "0x186DCA900")]
	private int EBBGKBLLJEC(FGBFHFMOPCE CHMIAHGMJKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA9B0", Offset = "0x6DC99B0", VA = "0x186DCA9B0")]
	private void LIIINIGLFOL(FGBFHFMOPCE CHMIAHGMJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCAC70", Offset = "0x6DC9C70", VA = "0x186DCAC70")]
	private void PIOJCOMEEGF(FGBFHFMOPCE CHMIAHGMJKI, NDPAJDKHEFP BLKDPLHFKIP)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ODALGLDABHG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NKMOKICGEFJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
			[DebuggerHidden]
			public NKMOKICGEFJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6DD17A0", Offset = "0x6DD07A0", VA = "0x186DD17A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6DD1960", Offset = "0x6DD0960", VA = "0x186DD1960", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6DD18B0", Offset = "0x6DD08B0", VA = "0x186DD18B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6DD18B0", Offset = "0x6DD08B0", VA = "0x186DD18B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int KEHOAPPIJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6DC8C20", Offset = "0x6DC7C20", VA = "0x186DC8C20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<JLFHOJNMAAN> FMMCANHBNHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6DC8C00", Offset = "0x6DC7C00", VA = "0x186DC8C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> JHLEEOLGEHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public NDPAJDKHEFP HGCBFKPEGGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EFJNKACCOBM ANGGGGIMDEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(EFJNKACCOBM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B6680", Offset = "0x8B5680", VA = "0x1808B6680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool NCFFGIMEPPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x21B2FB0", Offset = "0x21B1FB0", VA = "0x1821B2FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7660", Offset = "0x6DC6660", VA = "0x186DC7660")]
		public static ClusterMeshRenderer Create(NDPAJDKHEFP BKGAJHNMIBN, ClusterMeshRenderer PNEEEHJHHIO, MeshFilter JKEMPLELKMP, LBKJBKIAMOO BAOAKGNNKEP, EFJNKACCOBM BKMADAFHHHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC78D0", Offset = "0x6DC68D0", VA = "0x186DC78D0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8100", Offset = "0x6DC7100", VA = "0x186DC8100", Slot = "9")]
		public bool TryRemoveClusterLODComponent(COADCDMDIIO GEICOLLOJJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7EB0", Offset = "0x6DC6EB0", VA = "0x186DC7EB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7B40", Offset = "0x6DC6B40", VA = "0x186DC7B40")]
		public void Init(NDPAJDKHEFP BKGAJHNMIBN, MeshFilter JKEMPLELKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7930", Offset = "0x6DC6930", VA = "0x186DC7930")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8230", Offset = "0x6DC7230", VA = "0x186DC8230", Slot = "7")]
		public void UpdateClusterDistances(Vector3 JADOFHDDGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC84E0", Offset = "0x6DC74E0", VA = "0x186DC84E0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7AC0", Offset = "0x6DC6AC0", VA = "0x186DC7AC0")]
		[IteratorStateMachine(typeof(NKMOKICGEFJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7F40", Offset = "0x6DC6F40", VA = "0x186DC7F40")]
		public void SetupTagAndLayer(string DDOEMKPCPHL, int BKMADAFHHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7F20", Offset = "0x6DC6F20", VA = "0x186DC7F20")]
		public bool Remove(COADCDMDIIO GEICOLLOJJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GDCOJLGLALK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int IBJAHLOAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KECPKLHBJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BGPCLMCBMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int JEFGJPLLPLK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DC95D0", Offset = "0x6DC85D0", VA = "0x186DC95D0")]
	public GDCOJLGLALK(int KECPKLHBJEB, int BGPCLMCBMPG, int IBJAHLOAIIM, int JEFGJPLLPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BBBFOLFECKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<float3> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> LCMBPODCOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> PKEHEAPGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<GDCOJLGLALK> HINFPMFBDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<int> MGPFMDKGACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float3> EPMPFAEAHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float> PMPPGCPMMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public JobHandle CGOCMLLNHDP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DPEGCPBDAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x969D50", Offset = "0x968D50", VA = "0x180969D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9686F0", Offset = "0x9676F0", VA = "0x1809686F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5750", Offset = "0x6DC4750", VA = "0x186DC5750")]
	public void BCCFFCEEHAG(CBBOFCDCFKM GKDGHFCGIBF, NativeList<GDCOJLGLALK> HINFPMFBDFK, float KBGFEDJHNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DC68D0", Offset = "0x6DC58D0", VA = "0x186DC68D0")]
	public void PIJPMNPPACP(Transform BAOAKGNNKEP, bool HDHBCHHPGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6730", Offset = "0x6DC5730", VA = "0x186DC6730")]
	public void MFCPFCOHPDH(NDPAJDKHEFP MPFENKGEFEA, bool FMNPEIOBNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DC65F0", Offset = "0x6DC55F0", VA = "0x186DC65F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6700", Offset = "0x6DC5700", VA = "0x186DC6700")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public BBBFOLFECKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GEGEGDFIHFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<float3> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeList<int> LCMBPODCOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeList<GDCOJLGLALK> HGFOEGPBECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<int> MGPFMDKGACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float3 BJHBJBGMPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float3> EPMPFAEAHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeArray<float> PMPPGCPMMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private bool HDHBCHHPGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float LOCAJAEIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float NHAHHAPEGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private float FGDJIMCMHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private NativeList<int> PKEHEAPGHMP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9AF0", Offset = "0x6DC8AF0", VA = "0x186DC9AF0")]
	public GEGEGDFIHFH(BBBFOLFECKN BDBNNIABFHH, Vector3 BJHBJBGMPGL, bool HDHBCHHPGOH, float LOCAJAEIAEG, float NHAHHAPEGHP, float FGDJIMCMHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6DC95F0", Offset = "0x6DC85F0", VA = "0x186DC95F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface COADCDMDIIO : OMIMDAIBEJM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds KGJLGAENJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FGBFHFMOPCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public List<COADCDMDIIO> PPMCBPEDFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public FGBFHFMOPCE JNLBEALAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public FGBFHFMOPCE PENNANABDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public FGBFHFMOPCE HPHPDFEDPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int JEFGJPLLPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Bounds JOEJONILJIO;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9550", Offset = "0x6DC8550", VA = "0x186DC9550")]
	public FGBFHFMOPCE(List<COADCDMDIIO> PPMCBPEDFHJ, [Optional] FGBFHFMOPCE JNLBEALAMNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IMKEIELIMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<FGBFHFMOPCE> OFMIMOHBICO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FGBFHFMOPCE ALCFFKKOPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB3C0", Offset = "0x6DCA3C0", VA = "0x186DCB3C0")]
	public IMKEIELIMOL(FGBFHFMOPCE BAOAKGNNKEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBJBDLBBJKB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct KPIBMPAOMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EEHNDGBHNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OCGHINMLKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int ANFMIDCGEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OLOCBNKFBIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct HBAOJNGILGK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int CFNOPBHEMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float BNFGMOOOFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public List<COADCDMDIIO> PPMCBPEDFHJ;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAF00", Offset = "0x6DC9F00", VA = "0x186DCAF00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum LLEIIBKLABJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private KPIBMPAOMDH KHDHKAMAACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JPPHIMLJNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int FHLFDNCNLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int GDLMJAHNGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float FEMPJIEGNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float HHKOHMCDOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Stack<FGBFHFMOPCE> BEHMNIMOKFF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IMKEIELIMOL HJELBDJABOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3BA0", Offset = "0x6DD2BA0", VA = "0x186DD3BA0")]
	public OBJBDLBBJKB(int FHLFDNCNLOJ, int GDLMJAHNGDM, float FEMPJIEGNFH, int JPPHIMLJNPM, float HHKOHMCDOGP = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1E00", Offset = "0x6DD0E00", VA = "0x186DD1E00")]
	public void FBKEIEEJKCF(List<COADCDMDIIO> PPMCBPEDFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1D90", Offset = "0x6DD0D90", VA = "0x186DD1D90")]
	public bool BGDBHBNHDHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3B50", Offset = "0x6DD2B50", VA = "0x186DD3B50")]
	private float MEPAEICNHFD(Vector3 JCGGLMFLBCP, Vector3 PLFLOPDIPGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3B30", Offset = "0x6DD2B30", VA = "0x186DD3B30")]
	private float MEPAEICNHFD(Vector3 MLDINGBBEHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3150", Offset = "0x6DD2150", VA = "0x186DD3150")]
	private bool IAIMGPEEOJE(FGBFHFMOPCE ANJGONFOCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1FD0", Offset = "0x6DD0FD0", VA = "0x186DD1FD0")]
	private HBAOJNGILGK GPNEIPBIDAI(List<COADCDMDIIO> OKJHEACKPIG, LLEIIBKLABJ DKFKOGKJNKG)
	{
		return default(HBAOJNGILGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DD19B0", Offset = "0x6DD09B0", VA = "0x186DD19B0")]
	private void AKCCDCKHOEA(List<COADCDMDIIO> PPMCBPEDFHJ, Span<Vector3> GILLLJFIPAG, Span<Vector3> FNEMNGMJNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JBBGJFIDABO
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB490", Offset = "0x6DCA490", VA = "0x186DCB490")]
	public static Bounds AANJNOENOEJ(List<COADCDMDIIO> PPMCBPEDFHJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB660", Offset = "0x6DCA660", VA = "0x186DCB660")]
	public static int JDKLENPIPKF(List<COADCDMDIIO> PPMCBPEDFHJ, DGDJKJOFHLA ADNNLIGBFLK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JPKJHMEEKAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private CBBOFCDCFKM HHENIMFILFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private CBBOFCDCFKM OICDNKICILD;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static CBBOFCDCFKM BKKOLMLDPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private OIKFHLHECEP KPDDBKCMCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private FEBLINHAPNG POCEOANFAHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle CGOCMLLNHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xB885D0", Offset = "0xB875D0", VA = "0x180B885D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NDPAJDKHEFP.EBLDDOOONLJ ANJGONFOCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JNMGPGMAHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BDC0", Offset = "0x1D1ADC0", VA = "0x181D1BDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC250", Offset = "0x6DCB250", VA = "0x186DCC250")]
	[OJEDBLJEHPG(DODBMCGLPPE.ExitingPlayMode, 0)]
	private static void EJFAGHLAELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB910", Offset = "0x6DCA910", VA = "0x186DCB910")]
	public void BCCFFCEEHAG(NDPAJDKHEFP.EBLDDOOONLJ HGFOEGPBECM, Transform DPNBFAOMBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC2C0", Offset = "0x6DCB2C0", VA = "0x186DCC2C0")]
	public void PKJOMGJIIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC1A0", Offset = "0x6DCB1A0", VA = "0x186DCC1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC210", Offset = "0x6DCB210", VA = "0x186DCC210")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC960", Offset = "0x6DCB960", VA = "0x186DCC960")]
	public JPKJHMEEKAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NNFKIFPALDC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 IMJGOFHNDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LNODOLFJJBD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(NPOAFBCOAIB<string>.HFMLKGGDOCE KADLCMJLHCH, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KNHNLPACFDM
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNHNLPACFDM MOHMDCKOFJF(Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNHNLPACFDM FDKOHECIBHL(Action NDLMGANFCBJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class IIOKDKDDKAG : KNHNLPACFDM
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class LBKCIFCHIDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public IIOKDKDDKAG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public LBKCIFCHIDE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x6DCF290", Offset = "0x6DCE290", VA = "0x186DCF290")]
				internal void PCNIMFPLGBA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6DCF1F0", Offset = "0x6DCE1F0", VA = "0x186DCF1F0")]
				internal void ABIILFPPCJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6DCF240", Offset = "0x6DCE240", VA = "0x186DCF240")]
				internal void NIAJDHHGDBI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Func<JobHandle> CGALOACKDBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action PBJHFJLLHHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private Action LHIILPLMEOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private DDOJLIGABJD DAFAOPOMPNB;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JMHPPGBLLPD
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action EAJMMJGECBG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4161770", Offset = "0x4160770", VA = "0x184161770", Slot = "4")]
			public KNHNLPACFDM MOHMDCKOFJF(Action NDLMGANFCBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x687A140", Offset = "0x6879140", VA = "0x18687A140", Slot = "5")]
			public KNHNLPACFDM FDKOHECIBHL(Action NDLMGANFCBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
			public IIOKDKDDKAG(Func<JobHandle> IEAJFKIMBMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6DCB100", Offset = "0x6DCA100", VA = "0x186DCB100")]
			public void LAHPNPBPBKK(Action FNBKIAKBJOM, Action OCEFKJJCHLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6DCAF70", Offset = "0x6DC9F70", VA = "0x186DCAF70")]
			public void CAKBCGBONLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class HCKCFPBBAGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public KNHNLPACFDM jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HCKCFPBBAGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6DCAF60", Offset = "0x6DC9F60", VA = "0x186DCAF60")]
			internal bool HGHADBHBLKM(IIOKDKDDKAG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FFAIIILDPLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public IIOKDKDDKAG newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FFAIIILDPLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6DC94F0", Offset = "0x6DC84F0", VA = "0x186DC94F0")]
			internal void EDLFOGGNFPM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Queue<IIOKDKDDKAG> PNMJEPLCLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<IIOKDKDDKAG> GKJBHENOMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private DDGDFMBPLHP GNIJKMIDIOC;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEMAJKDJLDM OJJCLCEKAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCA10", Offset = "0x6DCBA10", VA = "0x186DCCA10")]
		public KNHNLPACFDM Add(Func<JobHandle> IEAJFKIMBMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCD40", Offset = "0x6DCBD40", VA = "0x186DCCD40")]
		public void Remove(KNHNLPACFDM CGOCMLLNHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCB70", Offset = "0x6DCBB70", VA = "0x186DCCB70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCF20", Offset = "0x6DCBF20", VA = "0x186DCCF20")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD180", Offset = "0x6DCC180", VA = "0x186DCD180")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCB60", Offset = "0x6DCBB60", VA = "0x186DCCB60")]
		[CompilerGenerated]
		private void JOEOEHFEOID()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DDOJLIGABJD
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDOJLIGABJD MOHMDCKOFJF(Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DDOJLIGABJD BDJDKPBHFOL(Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDOJLIGABJD FDKOHECIBHL(Action NDLMGANFCBJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class BMFJHJNCGNC : DDOJLIGABJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private JobHandle MNOABEJJKEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action PBJHFJLLHHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action AONMDCGGMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private Action EAJMMJGECBG;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool HICNMIFIMDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x6DC7520", Offset = "0x6DC6520", VA = "0x186DC7520")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x67A0EB0", Offset = "0x679FEB0", VA = "0x1867A0EB0", Slot = "4")]
			public DDOJLIGABJD MOHMDCKOFJF(Action NDLMGANFCBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x67A0ED0", Offset = "0x679FED0", VA = "0x1867A0ED0", Slot = "5")]
			public DDOJLIGABJD BDJDKPBHFOL(Action NDLMGANFCBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x687A140", Offset = "0x6879140", VA = "0x18687A140", Slot = "6")]
			public DDOJLIGABJD FDKOHECIBHL(Action NDLMGANFCBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xB885F0", Offset = "0xB875F0", VA = "0x180B885F0")]
			public BMFJHJNCGNC(JobHandle KAAPHMHDMLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6DC7480", Offset = "0x6DC6480", VA = "0x186DC7480")]
			public void AMDEFDIILDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6DC74D0", Offset = "0x6DC64D0", VA = "0x186DC74D0")]
			public void CAKBCGBONLK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private List<BMFJHJNCGNC> AFDJMPDPKDE;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD680", Offset = "0x6DCC680", VA = "0x186DCD680")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD260", Offset = "0x6DCC260", VA = "0x186DCD260")]
		public DDOJLIGABJD Add(JobHandle KAAPHMHDMLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD580", Offset = "0x6DCC580", VA = "0x186DCD580")]
		public void Remove(DDOJLIGABJD CGOCMLLNHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD3D0", Offset = "0x6DCC3D0", VA = "0x186DCD3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD300", Offset = "0x6DCC300", VA = "0x186DCD300")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD7C0", Offset = "0x6DCC7C0", VA = "0x186DCD7C0")]
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
