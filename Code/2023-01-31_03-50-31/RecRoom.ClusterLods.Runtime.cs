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
				[Cpp2IlInjected.Address(RVA = "0x5ACCA70", Offset = "0x5ACB870", VA = "0x185ACCA70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF2BB60", Offset = "0xF2A960", VA = "0x180F2BB60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5ACCA30", Offset = "0x5ACB830", VA = "0x185ACCA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AC29B0", Offset = "0x5AC17B0", VA = "0x185AC29B0")]
		public LODSettings KBEPFCDCIOJ(EMIGCLLBDMK ODPKNMDNFOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2890", Offset = "0x5AC1690", VA = "0x185AC2890")]
		public int DGEAIIMCJHF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5AC28B0", Offset = "0x5AC16B0", VA = "0x185AC28B0")]
		public int JPNMOAFECNA(bool KLLCEJIFOAK, Vector3 GCAABALMEGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AC29C0", Offset = "0x5AC17C0", VA = "0x185AC29C0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LDMKMAEKNKE
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
public interface LIELAELGJMI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBHLEMLNGCO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LPHDEMMIAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ICDCKPOPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KEAODLAOGFB> AANIEIAIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LDMKMAEKNKE KPCMIFAHJNG
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
	void UpdateClusterDistances(Vector3 NJAOOECBFPE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(CPMCFLLKKGE KMJCJNGOPHM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KEAODLAOGFB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int MJFLJCIEDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int OECNMEFLDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GCOMHMEACPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float HJMOFEINKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte DIEAJHAAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GBADNJNIKJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FGLJICEMGOF
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
	private struct BNOJPKHEBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GBADNJNIKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NILMFDECOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NILMFDECOMH <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5ABFB40", Offset = "0x5ABE940", VA = "0x185ABFB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CIFAEOAPDIL : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GBADNJNIKJG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public CIFAEOAPDIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5AC10A0", Offset = "0x5ABFEA0", VA = "0x185AC10A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1160", Offset = "0x5ABFF60", VA = "0x185AC1160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BGDLBHNGNNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GBADNJNIKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NILMFDECOMH worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NILMFDECOMH <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD9B0", Offset = "0x5ABC7B0", VA = "0x185ABD9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CDMEIHJELCB : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private ELOHAHHPMGF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public GBADNJNIKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public CDMEIHJELCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC0120", Offset = "0x5ABEF20", VA = "0x185AC0120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5AC0FD0", Offset = "0x5ABFDD0", VA = "0x185AC0FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int MHMELADKIME = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan JAKAIANEPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ALGCJIEOHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter JJOCPKBNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject AJABHIICCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject AAEIMDBKLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public BNKFOGLEHDG KGGCJFBJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<CPMCFLLKKGE> HCGJJKCACHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<CPMCFLLKKGE> IMDHGFMADLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<CPMCFLLKKGE> MNIFDAPKLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int ECNEMGJMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FGLJICEMGOF PIHMLEBJNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<LPHDEMMIAPC>[] MCMCJOLFCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KEAODLAOGFB>[] CNBKJFCEGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource OPLKFCLHIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool IAIDCIFDEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MANCEBNIGPM BPKKGDIECPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MANCEBNIGPM KGHPMFLJPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int GFGKCNBHGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int NODPOCNHLJH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static GBADNJNIKJG IIEIPCDDNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KLJEFIHMPGE EGPDFCNCOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GILLJOGDKKM ECKFBPGHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour HBIBGLJJLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material IBAOIAMCDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<LIELAELGJMI> OIKAJAMGMKE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig ADKONLGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 GEMJFEOEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x34ABD10", Offset = "0x34AAB10", VA = "0x1834ABD10")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34ABC30", Offset = "0x34AAA30", VA = "0x1834ABC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private FGLJICEMGOF ENJIGMFGHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB767E0", Offset = "0xB755E0", VA = "0x180B767E0")]
		get
		{
			return default(FGLJICEMGOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5AC5FB0", Offset = "0x5AC4DB0", VA = "0x185AC5FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static GBADNJNIKJG JKCIDAEDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5AC45B0", Offset = "0x5AC33B0", VA = "0x185AC45B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MLOLIJOOHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5AC4E80", Offset = "0x5AC3C80", VA = "0x185AC4E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool AHJECAOKAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6A50", Offset = "0x5AC5850", VA = "0x185AC6A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> AGMEBJOMAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5AC4870", Offset = "0x5AC3670", VA = "0x185AC4870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC4DE0", Offset = "0x5AC3BE0", VA = "0x185AC4DE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DENPIMJPOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6BD0", Offset = "0x5AC59D0", VA = "0x185AC6BD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6B30", Offset = "0x5AC5930", VA = "0x185AC6B30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6D60", Offset = "0x5AC5B60", VA = "0x185AC6D60")]
	public GBADNJNIKJG(KLJEFIHMPGE EGPDFCNCOMJ, GILLJOGDKKM ECKFBPGHKBE, ClusterLODConfig EAOKJCDDDDA, MonoBehaviour HBIBGLJJLNF, Material IBAOIAMCDBO, ClusterMeshRenderer ALGCJIEOHFC, MeshFilter JJOCPKBNLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4AD0", Offset = "0x5AC38D0", VA = "0x185AC4AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5AC49A0", Offset = "0x5AC37A0", VA = "0x185AC49A0")]
	public static void DNPJKDECPED(Vector3 HNGGOANGMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4910", Offset = "0x5AC3710", VA = "0x185AC4910")]
	private void DLEABEJLPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4730", Offset = "0x5AC3530", VA = "0x185AC4730")]
	private void DEPHCBAIPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5270", Offset = "0x5AC4070", VA = "0x185AC5270")]
	private void HBCFHMDAIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5920", Offset = "0x5AC4720", VA = "0x185AC5920")]
	public void HOBPDNFNPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AC68D0", Offset = "0x5AC56D0", VA = "0x185AC68D0")]
	[AsyncStateMachine(typeof(BNOJPKHEBKC))]
	public Task LDHKBPCNMDN(NILMFDECOMH OIJDGGDGOKN, CancellationToken OGPKLEECEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5200", Offset = "0x5AC4000", VA = "0x185AC5200")]
	[IteratorStateMachine(typeof(CIFAEOAPDIL))]
	private IEnumerator<ELOHAHHPMGF> GMHFHDHIEJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6790", Offset = "0x5AC5590", VA = "0x185AC6790")]
	[AsyncStateMachine(typeof(BGDLBHNGNNN))]
	private Task KJPLCADOIGP(NILMFDECOMH NHCBAOHOHPE, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4BD0", Offset = "0x5AC39D0", VA = "0x185AC4BD0")]
	public void EANJCLKCMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC46B0", Offset = "0x5AC34B0", VA = "0x185AC46B0")]
	public void CHPEANNKOAE(IEnumerable<LPHDEMMIAPC> FJPMGBCOPJC, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5AC56A0", Offset = "0x5AC44A0", VA = "0x185AC56A0")]
	public void HIGECPOINFD(IEnumerable<LPHDEMMIAPC> FJPMGBCOPJC, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5AC60E0", Offset = "0x5AC4EE0", VA = "0x185AC60E0")]
	public List<ClusterMeshRenderer> JPHIJIHOJCF(List<CPMCFLLKKGE> IHFNCPHANDK, BPHMPHDMJMJ JMLKLPJONJN, LDMKMAEKNKE CHFKHFKHJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6A10", Offset = "0x5AC5810", VA = "0x185AC6A10")]
	public LDMKMAEKNKE LDILGCGAKGD(Vector3 EDCNNIKABED)
	{
		return default(LDMKMAEKNKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5F50", Offset = "0x5AC4D50", VA = "0x185AC5F50")]
	public void JCNKFKOEGOO(LIELAELGJMI EEPOJPHIAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4610", Offset = "0x5AC3410", VA = "0x185AC4610")]
	public bool BMNPFHKLLHN(LIELAELGJMI EEPOJPHIAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5EF0", Offset = "0x5AC4CF0", VA = "0x185AC5EF0")]
	public void JCIDMJCFHMF(CPMCFLLKKGE MMCFJMJGJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5180", Offset = "0x5AC3F80", VA = "0x185AC5180")]
	public void GGFPDPDPGEI(KEAODLAOGFB FEPBBMGBAMP, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6C70", Offset = "0x5AC5A70", VA = "0x185AC6C70")]
	public void PLKDFDMPGPJ(KEAODLAOGFB FEPBBMGBAMP, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4450", Offset = "0x5AC3250", VA = "0x185AC4450")]
	private void ANDCNBDDIAG(Vector3 NJAOOECBFPE, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5AC53C0", Offset = "0x5AC41C0", VA = "0x185AC53C0")]
	private void HCJBIIPLJJC(Vector3 NJAOOECBFPE, LDMKMAEKNKE CHFKHFKHJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5E80", Offset = "0x5AC4C80", VA = "0x185AC5E80")]
	[IteratorStateMachine(typeof(CDMEIHJELCB))]
	private IEnumerator<ELOHAHHPMGF> ILKOKAJHBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5520", Offset = "0x5AC4320", VA = "0x185AC5520")]
	private int HGMJOOIIDJF(int NPDGHPHAKDK, int BJKLBMLFFPF, List<KEAODLAOGFB> DDMFIKKHIKD, byte ODPKNMDNFOK, ref int CAIPPDKNICP, float BBNBJIDANHF = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4FA0", Offset = "0x5AC3DA0", VA = "0x185AC4FA0")]
	public void FAHLDBEBGON(CPMCFLLKKGE KMJCJNGOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4670", Offset = "0x5AC3470", VA = "0x185AC4670")]
	public bool CBGGHDOLEKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83D830", Offset = "0x83C630", VA = "0x18083D830")]
	public Material HPONAOIJEPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4830", Offset = "0x5AC3630", VA = "0x185AC4830")]
	public int DGEAIIMCJHF()
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
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HLBILCMHACC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> CDEHPFCPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> DAIEDIBIABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> BHJBPBDACMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> CGDDLLMEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> JELJGKFEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> JOOBOILFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> KGEBNMHPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 IKGLBGDCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float AGNOGFNMOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> GDMHLHJHKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> GFMFHHJPKPG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA8B0", Offset = "0x5AC96B0", VA = "0x185ACA8B0")]
	public HLBILCMHACC(MOEGNMBENPD BACPNBLOLFL, NativeList<float3> KGEBNMHPAMM, NativeMultiHashMap<int, int> GDMHLHJHKBC, NativeArray<int> GFMFHHJPKPG, Vector3 IKGLBGDCGLJ, float AGNOGFNMOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA880", Offset = "0x5AC9680", VA = "0x185ACA880")]
	private int KEFKNOPDKEL(float3 NJAOOECBFPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA1F0", Offset = "0x5AC8FF0", VA = "0x185ACA1F0")]
	private int DLEBNDBNMPM(int MNBBHFLLBID, int PIIJMEAKDGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA450", Offset = "0x5AC9250", VA = "0x185ACA450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EKFMDOEJCIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> GDMHLHJHKBC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> GFMFHHJPKPG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int PKMCOLDKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> NIEBJPGCJGF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4190", Offset = "0x5AC2F90", VA = "0x185AC4190")]
	public void FAMGIJNBKPN(int DOANMKOGMNO, Allocator AEPJLHDIHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5AC40B0", Offset = "0x5AC2EB0", VA = "0x185AC40B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public EKFMDOEJCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct APLODMNDOAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> JLHABDOEAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> AAMGMGEDECJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC4A0", Offset = "0x5ABB2A0", VA = "0x185ABC4A0")]
	public APLODMNDOAE(EKFMDOEJCIG COJHMHDOMNA, MOEGNMBENPD BACPNBLOLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC400", Offset = "0x5ABB200", VA = "0x185ABC400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct CNCJOLJMCKB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> ALDIOANNJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> MHMPFELPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> HADLGONONFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> GKMFFLPDIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> DCICJKAPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> NIEBJPGCJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> JLHABDOEAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> CJAKDPHDONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> PEDGEINOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> FDJEIAHDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> MLLBNGIAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> KAGEGEPOJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> FECACJIKLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float MFBGPOKAEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float MBGOINFPFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 JKNLCGKMCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float EOPOFFFFOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NKAHPOJLEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float JFMOIJLKEGH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC2750", Offset = "0x5AC1550", VA = "0x185AC2750")]
	public CNCJOLJMCKB(EKFMDOEJCIG DCFKDBODPND, MOEGNMBENPD BACPNBLOLFL, MOEGNMBENPD OHEIPNANEDD, float NKAHPOJLEOC, float JFMOIJLKEGH, Vector3 JKNLCGKMCGF, float EOPOFFFFOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5AC23D0", Offset = "0x5AC11D0", VA = "0x185AC23D0")]
	private float3 FNBJGDILAAL(int MNBBHFLLBID)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5AC24A0", Offset = "0x5AC12A0", VA = "0x185AC24A0")]
	private void JCGIDNBIBAG(int MNBBHFLLBID, out float3 GKDAFCKCPAB, out float3 GHNAHCKGFAC, out float4 EAKJBFFGGMP, out float4 MHGEINMKNLO, out float2 NEKCHMNJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5AC1620", Offset = "0x5AC0420", VA = "0x185AC1620")]
	private int CJBILFIGPHM(int ELJIKHGABBK, int GHOMHEGIEPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5AC11A0", Offset = "0x5ABFFA0", VA = "0x185AC11A0")]
	private void BAEPPJOMMFJ(int ELJIKHGABBK, int GHOMHEGIEPM, int NPPFALODNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5AC1920", Offset = "0x5AC0720", VA = "0x185AC1920")]
	private bool DICOIAMPHJO(int ELJIKHGABBK, int GHOMHEGIEPM, float LOOJFABBBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5AC2690", Offset = "0x5AC1490", VA = "0x185AC2690")]
	private bool ONDKAGBDANE(int ELJIKHGABBK, int GHOMHEGIEPM, int NPPFALODNKM, float LOOJFABBBEB, bool PNNDDOKIOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5AC13B0", Offset = "0x5AC01B0", VA = "0x185AC13B0")]
	private bool BPPDEHKPGLP(int ELJIKHGABBK, int GHOMHEGIEPM, int NPPFALODNKM, float LOOJFABBBEB, bool PNNDDOKIOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5AC2480", Offset = "0x5AC1280", VA = "0x185AC2480")]
	private void FNCPHKACNNG(int ELJIKHGABBK, int GHOMHEGIEPM, int NPPFALODNKM, out int BCFMFEFMIJD, out int JGFFMPGAIMA, out int OBDGNLANKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5AC1AB0", Offset = "0x5AC08B0", VA = "0x185AC1AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BDKNEHJEEGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HINFPFMHOFM : IDisposable, KEAODLAOGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds HJIDIDOFHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<CPMCFLLKKGE> IHFNCPHANDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 EOFBFLOBDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 JIOOCHKAKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int MNAOCPELKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MOEGNMBENPD AGKCCJHJGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EKFMDOEJCIG HEHBCPCPPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform JMLKLPJONJN;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int HKLMDMCJJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5AC95F0", Offset = "0x5AC83F0", VA = "0x185AC95F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CJIINBBOOCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh ANEPOPHHGNF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736700", VA = "0x180737900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GCOMHMEACPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8FDAC0", Offset = "0x8FC8C0", VA = "0x1808FDAC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8FDE50", Offset = "0x8FCC50", VA = "0x1808FDE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte DIEAJHAAPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x87D090", Offset = "0x87BE90", VA = "0x18087D090")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x851430", Offset = "0x850230", VA = "0x180851430", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MJFLJCIEDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x83CC90", Offset = "0x83BA90", VA = "0x18083CC90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83CCA0", Offset = "0x83BAA0", VA = "0x18083CCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OECNMEFLDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xE6E9C0", Offset = "0xE6D7C0", VA = "0x180E6E9C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x866AF0", Offset = "0x8658F0", VA = "0x180866AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float HJMOFEINKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5AC9E20", Offset = "0x5AC8C20", VA = "0x185AC9E20", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9EE0", Offset = "0x5AC8CE0", VA = "0x185AC9EE0")]
		public void OIBLAPPKOJK(EMIGCLLBDMK ODPKNMDNFOK, out int ENFNKBNKPMO, out int IOBOENFGJHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9C70", Offset = "0x5AC8A70", VA = "0x185AC9C70")]
		public void MPJAGFEFCFK(EMIGCLLBDMK ODPKNMDNFOK, IMOFINHDIEB PHIPMIDBJBP, int MEPFPFOOANO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5AC98D0", Offset = "0x5AC86D0", VA = "0x185AC98D0")]
		public void HLEGHNJNJKA(NativeList<IABEBNPMKFK> AGKDAMGEOFK, Transform DDGBAKGLHDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9E40", Offset = "0x5AC8C40", VA = "0x185AC9E40")]
		public void OEHEPIPNJFB(Mesh BACPNBLOLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9630", Offset = "0x5AC8430", VA = "0x185AC9630")]
		public void CNPBFANGIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5AC96D0", Offset = "0x5AC84D0", VA = "0x185AC96D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA110", Offset = "0x5AC8F10", VA = "0x185ACA110")]
		public HINFPFMHOFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds HJIDIDOFHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<HINFPFMHOFM> LOPLOKCMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NHLNIPIBAMF NAHPMBADGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer KKBMLPHFFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int OLNKOFAOIJB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh PNOIAMAKCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PADMNODDCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ICDCKPOPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD0B0", Offset = "0x5ABBEB0", VA = "0x185ABD0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC4D0", Offset = "0x5ABB2D0", VA = "0x185ABC4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD710", Offset = "0x5ABC510", VA = "0x185ABD710")]
	public int KKPPFGIGMAG(int DKKLMCOILNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD550", Offset = "0x5ABC350", VA = "0x185ABD550")]
	public void HLNNJOEJMCH(GOCHEPBIJCC PDECBNHDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC8E0", Offset = "0x5ABB6E0", VA = "0x185ABC8E0")]
	public void FCKBMBBIFNE(Transform DDGBAKGLHDK, bool JOBCHJENHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD740", Offset = "0x5ABC540", VA = "0x185ABD740")]
	public bool OMBGFLFHKGI(bool EFPHAACEEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD100", Offset = "0x5ABBF00", VA = "0x185ABD100")]
	public void GKEJPIEGHOE(Transform JMLKLPJONJN, bool JOBCHJENHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC630", Offset = "0x5ABB430", VA = "0x185ABC630")]
	public bool FAHLDBEBGON(CPMCFLLKKGE KMJCJNGOPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD900", Offset = "0x5ABC700", VA = "0x185ABD900")]
	public BDKNEHJEEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BNKFOGLEHDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<BDKNEHJEEGJ.HINFPFMHOFM> EGAFBOEHAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private OEIKKLEADOO MMDAGGHPGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<BDKNEHJEEGJ.HINFPFMHOFM> EODAGIAPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int LHNDGFGOJDL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF130", Offset = "0x5ABDF30", VA = "0x185ABF130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF1A0", Offset = "0x5ABDFA0", VA = "0x185ABF1A0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF540", Offset = "0x5ABE340", VA = "0x185ABF540")]
	public void HMNAIPBHJIK(BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF, Transform JMLKLPJONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF220", Offset = "0x5ABE020", VA = "0x185ABF220")]
	public void FAHLDBEBGON(BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF410", Offset = "0x5ABE210", VA = "0x185ABF410")]
	private BDKNEHJEEGJ.HINFPFMHOFM HIOIKALCNBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF600", Offset = "0x5ABE400", VA = "0x185ABF600")]
	private bool OEOLHKALKAC(BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF0D0", Offset = "0x5ABDED0", VA = "0x185ABF0D0")]
	private void BHJIIJGHNGE(BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF6A0", Offset = "0x5ABE4A0", VA = "0x185ABF6A0")]
	public bool OIEFHNOAENM(BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF730", Offset = "0x5ABE530", VA = "0x185ABF730")]
	public bool PGLCEDHDGGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF6D0", Offset = "0x5ABE4D0", VA = "0x185ABF6D0")]
	private BDKNEHJEEGJ.HINFPFMHOFM OKKLMOKFGFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5ABF9C0", Offset = "0x5ABE7C0", VA = "0x185ABF9C0")]
	public BNKFOGLEHDG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KPPMKHNNNAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int LHDIAFPKDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HGJLDAPIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float OICAGGANGPD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<BDKNEHJEEGJ> HHJMHKGDHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC480", Offset = "0x5ACB280", VA = "0x185ACC480")]
	public KPPMKHNNNAH(int LHDIAFPKDAE, int HGJLDAPIFJO, float IEGNKMBBEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC120", Offset = "0x5ACAF20", VA = "0x185ACC120")]
	public void NFAMGDCKMJF(EOHNACLAKCH KHFLAJPPCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC080", Offset = "0x5ACAE80", VA = "0x185ACC080")]
	private int LIPHCLPBLBA(GOCHEPBIJCC ABKPGPJAFGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC240", Offset = "0x5ACB040", VA = "0x185ACC240")]
	private void NFAMGDCKMJF(GOCHEPBIJCC ABKPGPJAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBE70", Offset = "0x5ACAC70", VA = "0x185ACBE70")]
	private void KKNMENKHHEL(GOCHEPBIJCC ABKPGPJAFGM, BDKNEHJEEGJ LIPCBAMNBEN)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LPHDEMMIAPC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ECPLJAEHNDA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public ECPLJAEHNDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3EC0", Offset = "0x5AC2CC0", VA = "0x185AC3EC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5AC4070", Offset = "0x5AC2E70", VA = "0x185AC4070", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3FD0", Offset = "0x5AC2DD0", VA = "0x185AC3FD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3FD0", Offset = "0x5AC2DD0", VA = "0x185AC3FD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int ICDCKPOPFLH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3E60", Offset = "0x5AC2C60", VA = "0x185AC3E60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<KEAODLAOGFB> AANIEIAIBJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3E40", Offset = "0x5AC2C40", VA = "0x185AC3E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> LOPLOKCMOGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BDKNEHJEEGJ PNOIAMAKCNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LDMKMAEKNKE KPCMIFAHJNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73BBB0", Offset = "0x73A9B0", VA = "0x18073BBB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(LDMKMAEKNKE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x73C390", Offset = "0x73B190", VA = "0x18073C390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OICIEGCLGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5AC3E50", Offset = "0x5AC2C50", VA = "0x185AC3E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2A20", Offset = "0x5AC1820", VA = "0x185AC2A20")]
		public static ClusterMeshRenderer Create(BDKNEHJEEGJ BACPNBLOLFL, ClusterMeshRenderer ALGCJIEOHFC, MeshFilter JJOCPKBNLAL, BPHMPHDMJMJ JMLKLPJONJN, LDMKMAEKNKE CHFKHFKHJGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2BC0", Offset = "0x5AC19C0", VA = "0x185AC2BC0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3380", Offset = "0x5AC2180", VA = "0x185AC3380", Slot = "10")]
		public bool TryRemoveClusterLODComponent(CPMCFLLKKGE KMJCJNGOPHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3170", Offset = "0x5AC1F70", VA = "0x185AC3170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2E10", Offset = "0x5AC1C10", VA = "0x185AC2E10")]
		public void Init(BDKNEHJEEGJ BACPNBLOLFL, MeshFilter JJOCPKBNLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2C20", Offset = "0x5AC1A20", VA = "0x185AC2C20")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AC34B0", Offset = "0x5AC22B0", VA = "0x185AC34B0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 NJAOOECBFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AC36C0", Offset = "0x5AC24C0", VA = "0x185AC36C0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2DA0", Offset = "0x5AC1BA0", VA = "0x185AC2DA0")]
		[IteratorStateMachine(typeof(ECPLJAEHNDA))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AC31F0", Offset = "0x5AC1FF0", VA = "0x185AC31F0")]
		public void SetupTagAndLayer(string IPNLFJPKKOM, int CHFKHFKHJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AC31D0", Offset = "0x5AC1FD0", VA = "0x185AC31D0")]
		public bool Remove(CPMCFLLKKGE KMJCJNGOPHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ABMJKHJAPEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int AMHGPOLMOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int JHOHOEJNFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IOBOENFGJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int ENFNKBNKPMO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC380", Offset = "0x5ABB180", VA = "0x185ABC380")]
	public ABMJKHJAPEO(int JHOHOEJNFBB, int IOBOENFGJHO, int AMHGPOLMOBK, int ENFNKBNKPMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NHLNIPIBAMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> CDEHPFCPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> NIEBJPGCJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> JOOBOILFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<ABMJKHJAPEO> ECGOBGEIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> NGAAIODPMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> MCJEAELOGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> KLEEAOGCDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle CPPLLJNMFIG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NJGPOAGJMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x11316E0", Offset = "0x11304E0", VA = "0x1811316E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xDF3EE0", Offset = "0xDF2CE0", VA = "0x180DF3EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCEC0", Offset = "0x5ACBCC0", VA = "0x185ACCEC0")]
	public void JGMOEBJPLEH(MOEGNMBENPD MABHPLGBJLE, NativeList<ABMJKHJAPEO> ECGOBGEIPCF, float LAKBNONGKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCBD0", Offset = "0x5ACB9D0", VA = "0x185ACCBD0")]
	public void JAKNHMKNNHG(Transform JMLKLPJONJN, bool JOBCHJENHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDDE0", Offset = "0x5ACCBE0", VA = "0x185ACDDE0")]
	public void OMBGFLFHKGI(BDKNEHJEEGJ KKBMLPHFFPJ, bool EFPHAACEEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCA90", Offset = "0x5ACB890", VA = "0x185ACCA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCBA0", Offset = "0x5ACB9A0", VA = "0x185ACCBA0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NHLNIPIBAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct LBEHBGPIDDH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> CDEHPFCPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> NIEBJPGCJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<ABMJKHJAPEO> IBADIODDELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> NGAAIODPMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 JKNLCGKMCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> MCJEAELOGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> KLEEAOGCDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool JOBCHJENHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float MNPLFLHKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float KKIPBMBIAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float KHDBOPAGKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> JOOBOILFNKM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC960", Offset = "0x5ACB760", VA = "0x185ACC960")]
	public LBEHBGPIDDH(NHLNIPIBAMF KNMBBNJMGMG, Vector3 JKNLCGKMCGF, bool JOBCHJENHPH, float MNPLFLHKPKG, float KKIPBMBIAAL, float KHDBOPAGKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC4D0", Offset = "0x5ACB2D0", VA = "0x185ACC4D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CPMCFLLKKGE : DBEHKDPLJGC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds JKJNHAOHNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IABEBNPMKFK GAIFLNPEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GOCHEPBIJCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<CPMCFLLKKGE> IHFNCPHANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public GOCHEPBIJCC ICMEPOIJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public GOCHEPBIJCC HMLLJBGBFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public GOCHEPBIJCC NNOLFOIMCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int ENFNKBNKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds HJIDIDOFHFK;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9570", Offset = "0x5AC8370", VA = "0x185AC9570")]
	public GOCHEPBIJCC(List<CPMCFLLKKGE> IHFNCPHANDK, [Optional] GOCHEPBIJCC ICMEPOIJCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EOHNACLAKCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<GOCHEPBIJCC> JKMNDMKDPNL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public GOCHEPBIJCC GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4380", Offset = "0x5AC3180", VA = "0x185AC4380")]
	public EOHNACLAKCH(GOCHEPBIJCC JMLKLPJONJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GKPPJLMJLFI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PCKGIJMEMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int LCNEELJPCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int GFMJJONFMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int IPGMENLBAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int JIBBJMPANLC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct EKDABEINEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int IMKMDFEIGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float BIJIJNHNMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<CPMCFLLKKGE> IHFNCPHANDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MKLJIJCCKCF
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
	private PCKGIJMEMMK OKEJFEHJBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DNHDBEGPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int LHDIAFPKDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int HGJLDAPIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float IEGNKMBBEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float GDLPFGMOAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<GOCHEPBIJCC> AFGBNDEHENI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EOHNACLAKCH BJLIJECDEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9110", Offset = "0x5AC7F10", VA = "0x185AC9110")]
	public GKPPJLMJLFI(int LHDIAFPKDAE, int HGJLDAPIFJO, float IEGNKMBBEMB, int DNHDBEGPBGO, float GDLPFGMOAHA = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC79E0", Offset = "0x5AC67E0", VA = "0x185AC79E0")]
	public void CFPNDHONFAP(List<CPMCFLLKKGE> IHFNCPHANDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8810", Offset = "0x5AC7610", VA = "0x185AC8810")]
	public bool ILBJJBKHIOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5AC74B0", Offset = "0x5AC62B0", VA = "0x185AC74B0")]
	private float ANHOBHHGFBH(Vector3 AJMPIJJCLNC, Vector3 JFFGPOOCEHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7530", Offset = "0x5AC6330", VA = "0x185AC7530")]
	private float ANHOBHHGFBH(Vector3 BDHBBDMMOKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8880", Offset = "0x5AC7680", VA = "0x185AC8880")]
	private bool MPPNEGFOGFG(GOCHEPBIJCC AMGGPIBKKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7BE0", Offset = "0x5AC69E0", VA = "0x185AC7BE0")]
	private EKDABEINEJA IKPADLHHHBC(List<CPMCFLLKKGE> FKILGCCBEND, MKLJIJCCKCF HPEEAIOGEAA)
	{
		return default(EKDABEINEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7580", Offset = "0x5AC6380", VA = "0x185AC7580")]
	private void BBIDKDBALLJ(List<CPMCFLLKKGE> IHFNCPHANDK, Vector3[] MBMFEOGIFOM, Vector3[] OLJNLGJFBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class BJBJOFJIHCE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ABED70", Offset = "0x5ABDB70", VA = "0x185ABED70")]
	public static Bounds CKJEPMECHGE(List<CPMCFLLKKGE> IHFNCPHANDK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ABEF20", Offset = "0x5ABDD20", VA = "0x185ABEF20")]
	public static int MLLFDCEFGKP(List<CPMCFLLKKGE> IHFNCPHANDK, EMIGCLLBDMK ODPKNMDNFOK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OEIKKLEADOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MOEGNMBENPD JKBEPKHOCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private MOEGNMBENPD NBMBIJDMKFB;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static MOEGNMBENPD IILODDLILGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BIGPPGHPIML EDAGAGDBOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private IMOFINHDIEB PHIPMIDBJBP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle CPPLLJNMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x88BA20", Offset = "0x88A820", VA = "0x18088BA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BDKNEHJEEGJ.HINFPFMHOFM AMGGPIBKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BPIDMMMEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x795AE0", Offset = "0x7948E0", VA = "0x180795AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE730", Offset = "0x5ACD530", VA = "0x185ACE730")]
	[CIBCLNKDGPH(MOOMEKEKHGD.ExitingPlayMode, 0)]
	private static void IIOAGGPJMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE7A0", Offset = "0x5ACD5A0", VA = "0x185ACE7A0")]
	public void JGMOEBJPLEH(BDKNEHJEEGJ.HINFPFMHOFM IBADIODDELN, Transform OEOEPJKOKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE040", Offset = "0x5ACCE40", VA = "0x185ACE040")]
	public void HNIMCIBNIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDF90", Offset = "0x5ACCD90", VA = "0x185ACDF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE000", Offset = "0x5ACCE00", VA = "0x185ACE000")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF2A0", Offset = "0x5ACE0A0", VA = "0x185ACF2A0")]
	public OEIKKLEADOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JIKCLMJHCFM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GBADNJNIKJG AEDPJDFCDIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GILLJOGDKKM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 PMNBCLOLJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KLJEFIHMPGE
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(NILMFDECOMH NHCBAOHOHPE, CancellationToken NIEOBBGKEFJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DPCPBJAKAFE
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPCPBJAKAFE HHLEJPGJPEL(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPCPBJAKAFE PNGLMHPFCCL(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPCPBJAKAFE GADNFDMBNFC(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPCPBJAKAFE PPMJMEBIIAO(Action KNOLDLABLMF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class GMFDPEIBDLG : DPCPBJAKAFE
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class JGBBOEPECMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public GMFDPEIBDLG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public JGBBOEPECMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5ACA980", Offset = "0x5AC9780", VA = "0x185ACA980")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5ACA9D0", Offset = "0x5AC97D0", VA = "0x185ACA9D0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5ACAA20", Offset = "0x5AC9820", VA = "0x185ACAA20")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> KKLLAKCKDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action BHGJIJCFLOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action PAKDEJDOHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private MNAEMKFNCJL ADENFBFNNLO;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action LECCLJJHEHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action JLBAPFJGPNP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9EB490", Offset = "0x9EA290", VA = "0x1809EB490", Slot = "4")]
			public DPCPBJAKAFE HHLEJPGJPEL(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD63CE0", Offset = "0xD62AE0", VA = "0x180D63CE0", Slot = "5")]
			public DPCPBJAKAFE PNGLMHPFCCL(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xE48D20", Offset = "0xE47B20", VA = "0x180E48D20", Slot = "6")]
			public DPCPBJAKAFE GADNFDMBNFC(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xE48D40", Offset = "0xE47B40", VA = "0x180E48D40", Slot = "7")]
			public DPCPBJAKAFE PPMJMEBIIAO(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
			public GMFDPEIBDLG(Func<JobHandle> PHKHGNJHHOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5AC9170", Offset = "0x5AC7F70", VA = "0x185AC9170")]
			public void CAIEIEJFFKG(Action OHLHBPPGGPF, Action CDOIEODIGFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5AC9400", Offset = "0x5AC8200", VA = "0x185AC9400")]
			public void FAHLDBEBGON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JFAADPDAFAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public DPCPBJAKAFE jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public JFAADPDAFAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5ACA970", Offset = "0x5AC9770", VA = "0x185ACA970")]
			internal bool <Remove>b__0(GMFDPEIBDLG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class AKKFAAHHBNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public GMFDPEIBDLG newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public AKKFAAHHBNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5ABC3A0", Offset = "0x5ABB1A0", VA = "0x185ABC3A0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<GMFDPEIBDLG> OCMIEHGGPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<GMFDPEIBDLG> GPNHAFAPAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private MANCEBNIGPM NGCLFJCGODC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MFCNKDCECLK ACMHBPOEIBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAA60", Offset = "0x5AC9860", VA = "0x185ACAA60")]
		public DPCPBJAKAFE Add(Func<JobHandle> PHKHGNJHHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAD60", Offset = "0x5AC9B60", VA = "0x185ACAD60")]
		public void Remove(DPCPBJAKAFE CPPLLJNMFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACABC0", Offset = "0x5AC99C0", VA = "0x185ACABC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAF30", Offset = "0x5AC9D30", VA = "0x185ACAF30")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB180", Offset = "0x5AC9F80", VA = "0x185ACB180")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5ACABB0", Offset = "0x5AC99B0", VA = "0x185ACABB0")]
		[CompilerGenerated]
		private void DGNGPHOCEBF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MNAEMKFNCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNAEMKFNCJL HHLEJPGJPEL(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MNAEMKFNCJL EBCGKAINAGH(Action KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNAEMKFNCJL PPMJMEBIIAO(Action KNOLDLABLMF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class CIEDFDAOBEI : MNAEMKFNCJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle PBBCDOCBEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action BHGJIJCFLOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action GHDICMHAJOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action JLBAPFJGPNP;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MIHBCEKGEFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5AC1090", Offset = "0x5ABFE90", VA = "0x185AC1090")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xD63CE0", Offset = "0xD62AE0", VA = "0x180D63CE0", Slot = "4")]
			public MNAEMKFNCJL HHLEJPGJPEL(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xE48D20", Offset = "0xE47B20", VA = "0x180E48D20", Slot = "5")]
			public MNAEMKFNCJL EBCGKAINAGH(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xE48D40", Offset = "0xE47B40", VA = "0x180E48D40", Slot = "6")]
			public MNAEMKFNCJL PPMJMEBIIAO(Action KNOLDLABLMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
			public CIEDFDAOBEI(JobHandle CDICIBOMMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5AC1050", Offset = "0x5ABFE50", VA = "0x185AC1050")]
			public void NNHOADFEBDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5AC1010", Offset = "0x5ABFE10", VA = "0x185AC1010")]
			public void FAHLDBEBGON()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<CIEDFDAOBEI> HOBMCECAFEA;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB660", Offset = "0x5ACA460", VA = "0x185ACB660")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB280", Offset = "0x5ACA080", VA = "0x185ACB280")]
		public MNAEMKFNCJL Add(JobHandle CDICIBOMMJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB570", Offset = "0x5ACA370", VA = "0x185ACB570")]
		public void Remove(MNAEMKFNCJL CPPLLJNMFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB400", Offset = "0x5ACA200", VA = "0x185ACB400", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB310", Offset = "0x5ACA110", VA = "0x185ACB310")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB780", Offset = "0x5ACA580", VA = "0x185ACB780")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBB90", Offset = "0x5ACA990", VA = "0x185ACBB90")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB840", Offset = "0x5ACA640", VA = "0x185ACB840")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
