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
				[Cpp2IlInjected.Address(RVA = "0x4356910", Offset = "0x4355310", VA = "0x184356910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xDB68D0", Offset = "0xDB52D0", VA = "0x180DB68D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x43568D0", Offset = "0x43552D0", VA = "0x1843568D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x434E210", Offset = "0x434CC10", VA = "0x18434E210")]
		public LODSettings AIACNHGPKMF(FNAOJINHLPB OPAANEOCAHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x434E220", Offset = "0x434CC20", VA = "0x18434E220")]
		public int MCFJIBGJCLE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x434E240", Offset = "0x434CC40", VA = "0x18434E240")]
		public int MOLCDNEMGBA(bool GAHJMKPGLLP, Vector3 EGJGGHOJDGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x434E340", Offset = "0x434CD40", VA = "0x18434E340")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KOFDKIKGCEJ
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
public interface NKMGCNOGOGF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGDNFCPCDAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LKDIOJCMHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LIMKAOENHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<EKJHEBEFBCE> GLJOLBMFGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KOFDKIKGCEJ PFKCFIIDCHE
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
	void UpdateClusterDistances(Vector3 JFCDBGEGOGI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(EAEJMALDCGI ENHKEICGIAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKJHEBEFBCE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NBPHIALCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int EGJLEHJBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LOBCJBGCMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OAKBJFBPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte FPEGECKFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OJHCLKMGAMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FPGLAPKPGMA
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
	private struct FOILOIINJLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4351BD0", Offset = "0x43505D0", VA = "0x184351BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KEELKEKADCP : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public KEELKEKADCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4355FF0", Offset = "0x43549F0", VA = "0x184355FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43560B0", Offset = "0x4354AB0", VA = "0x1843560B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OCPCKAOOKLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BDMELKPFPFB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x43595A0", Offset = "0x4357FA0", VA = "0x1843595A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ANFEOBEGJML : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public ANFEOBEGJML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x434CF90", Offset = "0x434B990", VA = "0x18434CF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x434DE80", Offset = "0x434C880", VA = "0x18434DE80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CGJFOOFIDNH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan ACLBHKCHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer OLDHCMHFELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter IFODMDNACEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject PBHJFBEEDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject FOOONPPABIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OBCALNNIEEN GPOGKALCCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<EAEJMALDCGI> DJFFBMCLCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EAEJMALDCGI> CHGGAAHKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<EAEJMALDCGI> LAEBNHENLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LMGLHFFMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FPGLAPKPGMA CIKCHMDPHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<LKDIOJCMHLE>[] PKPICCHIGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<EKJHEBEFBCE>[] EGFLKOJPGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource IKCBHDOAMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool MCDFAGFCKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LMANBCGFHOA MPCEOEDMBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LMANBCGFHOA PDOELFEIHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int EHAAOCADLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int EGJEAKCGHJK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static OJHCLKMGAMM OHFIIBJBHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly AEBMEDJCFPO KCAOLFOHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HHBKIKIGDAP DEJCNJPDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour IOIICOIBEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material DLNHBJFMBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<NKMGCNOGOGF> MKOJEPNIEGE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig AIKEFJHMOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 INNOGBCFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B4C290", Offset = "0x1B4AC90", VA = "0x181B4C290")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B4C1A0", Offset = "0x1B4ABA0", VA = "0x181B4C1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private FPGLAPKPGMA PEFCKDMJIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59B950", Offset = "0x59A350", VA = "0x18059B950")]
		get
		{
			return default(FPGLAPKPGMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x435CF90", Offset = "0x435B990", VA = "0x18435CF90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OJHCLKMGAMM JMMDLCEKNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x435C810", Offset = "0x435B210", VA = "0x18435C810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool LLKDDADOJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x435DD60", Offset = "0x435C760", VA = "0x18435DD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CGIMKJHHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x435E090", Offset = "0x435CA90", VA = "0x18435E090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OBPOHIBCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x435DFF0", Offset = "0x435C9F0", VA = "0x18435DFF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x435CCC0", Offset = "0x435B6C0", VA = "0x18435CCC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JKBDOMEHONN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x435CAF0", Offset = "0x435B4F0", VA = "0x18435CAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x435CD60", Offset = "0x435B760", VA = "0x18435CD60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x435E490", Offset = "0x435CE90", VA = "0x18435E490")]
	public OJHCLKMGAMM(AEBMEDJCFPO KCAOLFOHFIN, HHBKIKIGDAP DEJCNJPDBPF, ClusterLODConfig BFKAALILDNB, MonoBehaviour IOIICOIBEMM, Material DLNHBJFMBNL, ClusterMeshRenderer OLDHCMHFELL, MeshFilter IFODMDNACEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x435C8D0", Offset = "0x435B2D0", VA = "0x18435C8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x435BC20", Offset = "0x435A620", VA = "0x18435BC20")]
	public static void BIICPMJKHIC(Vector3 HKOMFOGOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x435C230", Offset = "0x435AC30", VA = "0x18435C230")]
	private void CCALFEBFGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x435DB30", Offset = "0x435C530", VA = "0x18435DB30")]
	private void NENKDIHPAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x435BAE0", Offset = "0x435A4E0", VA = "0x18435BAE0")]
	private void BGCKMJLNGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x435BD40", Offset = "0x435A740", VA = "0x18435BD40")]
	public void BJODFFLMPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x435DA00", Offset = "0x435C400", VA = "0x18435DA00")]
	[AsyncStateMachine(typeof(FOILOIINJLL))]
	public Task NBCOENACCHH(BDMELKPFPFB BCIAJNNCADP, CancellationToken ADDHBCOAOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x435D930", Offset = "0x435C330", VA = "0x18435D930")]
	[IteratorStateMachine(typeof(KEELKEKADCP))]
	private IEnumerator<CBGPFCCMDJP> MCNIBDICEJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x435CE00", Offset = "0x435B800", VA = "0x18435CE00")]
	[AsyncStateMachine(typeof(OCPCKAOOKLH))]
	private Task KKGPOINNAEK(BDMELKPFPFB BNHHCEGJNOI, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x435C2C0", Offset = "0x435ACC0", VA = "0x18435C2C0")]
	public void DCNEBEJLHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x435C9D0", Offset = "0x435B3D0", VA = "0x18435C9D0")]
	public void EEMIBEJOAAB(IEnumerable<LKDIOJCMHLE> APJFLNNKPNH, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x435E170", Offset = "0x435CB70", VA = "0x18435E170")]
	public void POJNGMIJPPG(IEnumerable<LKDIOJCMHLE> APJFLNNKPNH, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x435D130", Offset = "0x435BB30", VA = "0x18435D130")]
	public List<ClusterMeshRenderer> LHPHKEFGCBA(List<EAEJMALDCGI> HBILPAFBEMD, Transform DDLLFFEEEME, KOFDKIKGCEJ PJKOCALJJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x435CB90", Offset = "0x435B590", VA = "0x18435CB90")]
	public KOFDKIKGCEJ HGNCFNEMOPK(Vector3 MAGMMCBKBLI)
	{
		return default(KOFDKIKGCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x435CF30", Offset = "0x435B930", VA = "0x18435CF30")]
	public void KLGEKHEMBAC(NKMGCNOGOGF MOACHMCGBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x435D9A0", Offset = "0x435C3A0", VA = "0x18435D9A0")]
	public bool MJOLFKNCBHI(NKMGCNOGOGF MOACHMCGBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x435CA50", Offset = "0x435B450", VA = "0x18435CA50")]
	public void GBLCAJJKBEL(EAEJMALDCGI MINIDPOJPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x435CBD0", Offset = "0x435B5D0", VA = "0x18435CBD0")]
	public void HKGHJCANJED(EKJHEBEFBCE EEHCANMAMAN, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x435D0B0", Offset = "0x435BAB0", VA = "0x18435D0B0")]
	public void LHHPEGJCFPJ(EKJHEBEFBCE EEHCANMAMAN, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x435DC30", Offset = "0x435C630", VA = "0x18435DC30")]
	private void NHMOJMJPDGN(Vector3 JFCDBGEGOGI, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x435C4D0", Offset = "0x435AED0", VA = "0x18435C4D0")]
	private void DELAHGMIJJE(Vector3 JFCDBGEGOGI, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x435CC50", Offset = "0x435B650", VA = "0x18435CC50")]
	[IteratorStateMachine(typeof(ANFEOBEGJML))]
	private IEnumerator<CBGPFCCMDJP> IFGLPDBKFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x435DE80", Offset = "0x435C880", VA = "0x18435DE80")]
	private int OIFHBFJANJP(int LGBFGOJBLFK, int BAHCGFOAKGO, List<EKJHEBEFBCE> KDIOEBIIJBE, byte OPAANEOCAHH, ref int JNGPIMDPHCA, float MNLOJPLLAKA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x435C640", Offset = "0x435B040", VA = "0x18435C640")]
	public void DFDJPGANONL(EAEJMALDCGI ENHKEICGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x435CAB0", Offset = "0x435B4B0", VA = "0x18435CAB0")]
	public bool GHCMPHNIINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1500", Offset = "0x69FF00", VA = "0x1806A1500")]
	public Material LBGHMEHPHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x435D8F0", Offset = "0x435C2F0", VA = "0x18435D8F0")]
	public int MCFJIBGJCLE()
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
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EABCNJJHCNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> AEJIBMMHGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> KIKIJAKBNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> CIACFHAPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> LPBEMELBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> FPFDDPDMOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 BFBEHIFJNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float MLJOICPGJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> PNEFKENCLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> JHDAECBFOMA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x434FE80", Offset = "0x434E880", VA = "0x18434FE80")]
	public EABCNJJHCNM(FDNGLNHKOBP EALEDNNEEBC, NativeList<float3> FPFDDPDMOKJ, NativeMultiHashMap<int, int> PNEFKENCLLC, NativeArray<int> JHDAECBFOMA, Vector3 BFBEHIFJNON, float MLJOICPGJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x434FB80", Offset = "0x434E580", VA = "0x18434FB80")]
	private int HEMMELPLJED(float3 JFCDBGEGOGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x434FBE0", Offset = "0x434E5E0", VA = "0x18434FBE0")]
	private int OFHOJPHHHNN(int PFAINNECIEO, int IPKOPOLJGIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x434F790", Offset = "0x434E190", VA = "0x18434F790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFFKNKMCENK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> PNEFKENCLLC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> JHDAECBFOMA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int PJKGFEEOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4358560", Offset = "0x4356F60", VA = "0x184358560")]
	public void COLIIHLGNOH(int JJDBOJDNNBD, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4358700", Offset = "0x4357100", VA = "0x184358700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public NFFKNKMCENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IJFNECCBCNH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> AKIOJOAFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> KFHPEADNNEP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x43552F0", Offset = "0x4353CF0", VA = "0x1843552F0")]
	public IJFNECCBCNH(NFFKNKMCENK JFBKHGFMMAJ, FDNGLNHKOBP EALEDNNEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4355260", Offset = "0x4353C60", VA = "0x184355260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EKINMNFPICA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> GCMEDGBLOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> KEOCEFDICKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> LNNHKGOJONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> NOOEJLPLHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> LCNMLLANIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> AKIOJOAFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> AKPNHHMJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> EAJLANLCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> JNJBFJOMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> CMCHHENIPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> KMBNAEGBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> LOEGOAFELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float AOBMANEPLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float BMJBDCALIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 NPFGBLLKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float GCNEAIBPHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float CMAMLOLKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float JJPDDGGNEBJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4351520", Offset = "0x434FF20", VA = "0x184351520")]
	public EKINMNFPICA(NFFKNKMCENK GANJDACMIDO, FDNGLNHKOBP EALEDNNEEBC, FDNGLNHKOBP GPBFGAALIFF, float CMAMLOLKGLC, float JJPDDGGNEBJ, Vector3 NPFGBLLKMKP, float GCNEAIBPHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43511E0", Offset = "0x434FBE0", VA = "0x1843511E0")]
	private float3 MGKKGCGEILP(int PFAINNECIEO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4351340", Offset = "0x434FD40", VA = "0x184351340")]
	private void PHFFEHDDJOA(int PFAINNECIEO, out float3 NEKFECMMHJC, out float3 ILENLIGBFMB, out float4 OKMJKFFEMGG, out float4 OCFNHBIHLHM, out float2 DLPLIGMENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4350CB0", Offset = "0x434F6B0", VA = "0x184350CB0")]
	private int JEBFNKJMDCJ(int BEOMFMOJIBH, int APNBFONMINB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4350FE0", Offset = "0x434F9E0", VA = "0x184350FE0")]
	private void LHDMGJJBOKB(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4350B20", Offset = "0x434F520", VA = "0x184350B20")]
	private bool IOEHDLNLPAB(int BEOMFMOJIBH, int APNBFONMINB, float NLFNEACDHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4351280", Offset = "0x434FC80", VA = "0x184351280")]
	private bool ONEINGIKIHF(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, float NLFNEACDHPF, bool NBBOIPEBOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x43508C0", Offset = "0x434F2C0", VA = "0x1843508C0")]
	private bool HLMKJAANMLI(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, float NLFNEACDHPF, bool NBBOIPEBOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x43508A0", Offset = "0x434F2A0", VA = "0x1843508A0")]
	private void GLCAOJPFIJN(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, out int KKDFBKHBFJL, out int GEHBNJHJJOP, out int HPDDAHPLLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x434FF40", Offset = "0x434E940", VA = "0x18434FF40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GDFHEJFHPNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HCLGAICCBEB : IDisposable, EKJHEBEFBCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds MJKIPNFICIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<EAEJMALDCGI> HBILPAFBEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 MCOPODNHBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 FOEAPOKCGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int BMHCHIPGKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FDNGLNHKOBP JMFJEJAJBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NFFKNKMCENK NAEKDHBEGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform DDLLFFEEEME;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int JELIKHAFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4354B70", Offset = "0x4353570", VA = "0x184354B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh ENLOMPLCLJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh MGBDNGEMKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5644A0", Offset = "0x562EA0", VA = "0x1805644A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x588CD0", Offset = "0x5876D0", VA = "0x180588CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LOBCJBGCMBL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x567190", Offset = "0x565B90", VA = "0x180567190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x567530", Offset = "0x565F30", VA = "0x180567530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte FPEGECKFKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x61EFB0", Offset = "0x61D9B0", VA = "0x18061EFB0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x80E440", Offset = "0x80CE40", VA = "0x18080E440", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NBPHIALCGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8D89B0", Offset = "0x8D73B0", VA = "0x1808D89B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x972C50", Offset = "0x971650", VA = "0x180972C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EGJLEHJBLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB129E0", Offset = "0xB113E0", VA = "0x180B129E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1372060", Offset = "0x1370A60", VA = "0x181372060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OAKBJFBPNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4354B50", Offset = "0x4353550", VA = "0x184354B50", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4354BB0", Offset = "0x43535B0", VA = "0x184354BB0")]
		public void NPCPEJPDAED(FNAOJINHLPB OPAANEOCAHH, out int HIFFGNNDLLF, out int NFHCBCLHELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x43549B0", Offset = "0x43533B0", VA = "0x1843549B0")]
		public void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4354DE0", Offset = "0x43537E0", VA = "0x184354DE0")]
		public void PGIOEJFHBIM(NativeList<EOKOJNFCPLK> FMFGIFCHDBI, Transform NPJNJHOFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4355100", Offset = "0x4353B00", VA = "0x184355100")]
		public void PKAGLAEHODD(Mesh EALEDNNEEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4354910", Offset = "0x4353310", VA = "0x184354910")]
		public void EIBBCHCMGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4354720", Offset = "0x4353120", VA = "0x184354720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x43551A0", Offset = "0x4353BA0", VA = "0x1843551A0")]
		public HCLGAICCBEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds MJKIPNFICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<HCLGAICCBEB> JPIMDNHDKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ODEKPKOGJNI JPJHPHFMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer DADDDHJHLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IFGPCJHBPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh BMGOPFBLNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x751CA0", Offset = "0x7506A0", VA = "0x180751CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GCOPBGFICIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7739A0", Offset = "0x7723A0", VA = "0x1807739A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x7724C0", VA = "0x180773AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LIMKAOENHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4352B10", Offset = "0x4351510", VA = "0x184352B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4352550", Offset = "0x4350F50", VA = "0x184352550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4352B60", Offset = "0x4351560", VA = "0x184352B60")]
	public int LIAIKBDJJPF(int PGJBANBCOAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x43532F0", Offset = "0x4351CF0", VA = "0x1843532F0")]
	public void NHBOEGMLJLN(NPIFNLMNIEG KDADPJPLDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4352B90", Offset = "0x4351590", VA = "0x184352B90")]
	public void MKPBJEBGLME(Transform NPJNJHOFJCH, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4352120", Offset = "0x4350B20", VA = "0x184352120")]
	public bool AAEMPGLDAGC(bool MCPMFKOAOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x43526B0", Offset = "0x43510B0", VA = "0x1843526B0")]
	public void IFBBOAFPOAK(Transform DDLLFFEEEME, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x43522D0", Offset = "0x4350CD0", VA = "0x1843522D0")]
	public bool DFDJPGANONL(EAEJMALDCGI ENHKEICGIAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4353480", Offset = "0x4351E80", VA = "0x184353480")]
	public GDFHEJFHPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OBCALNNIEEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<GDFHEJFHPNM.HCLGAICCBEB> JNKHJPHFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GPMMGDLBMIA HBIINJCFNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<GDFHEJFHPNM.HCLGAICCBEB> ELFLEFIPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int KCPICMNIAKE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4358A90", Offset = "0x4357490", VA = "0x184358A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4359050", Offset = "0x4357A50", VA = "0x184359050")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4358830", Offset = "0x4357230", VA = "0x184358830")]
	public void CEGAKGBDODP(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM, Transform DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43588E0", Offset = "0x43572E0", VA = "0x1843588E0")]
	public void DFDJPGANONL(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4358F20", Offset = "0x4357920", VA = "0x184358F20")]
	private GDFHEJFHPNM.HCLGAICCBEB KGMEMIIFLBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4358DF0", Offset = "0x43577F0", VA = "0x184358DF0")]
	private bool JNNOAIJPDNJ(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4358B00", Offset = "0x4357500", VA = "0x184358B00")]
	private void EBNDDOOKMFN(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4358E80", Offset = "0x4357880", VA = "0x184358E80")]
	public bool KFEKPLMKJFI(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4358B60", Offset = "0x4357560", VA = "0x184358B60")]
	public bool JCPEDGKMAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4358EC0", Offset = "0x43578C0", VA = "0x184358EC0")]
	private GDFHEJFHPNM.HCLGAICCBEB KFHNCHFIJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43590D0", Offset = "0x4357AD0", VA = "0x1843590D0")]
	public OBCALNNIEEN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ADACILJPECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HOFMJIHFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int BMHMCKFPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float GDCICMPJJOF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<GDFHEJFHPNM> JAPCFAIGMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x434CF40", Offset = "0x434B940", VA = "0x18434CF40")]
	public ADACILJPECD(int HOFMJIHFPCG, int BMHMCKFPIDM, float CDNEHLAFBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x434CC70", Offset = "0x434B670", VA = "0x18434CC70")]
	public void MBFCHLFDCLE(JDJCFBCJGDF KPBIKGIKDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x434C9F0", Offset = "0x434B3F0", VA = "0x18434C9F0")]
	private int BAANGJCCABJ(NPIFNLMNIEG DAMODCEKDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x434CD10", Offset = "0x434B710", VA = "0x18434CD10")]
	private void MBFCHLFDCLE(NPIFNLMNIEG DAMODCEKDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x434CA90", Offset = "0x434B490", VA = "0x18434CA90")]
	private void BDLJOJBJKEL(NPIFNLMNIEG DAMODCEKDNG, GDFHEJFHPNM KIBHDAFDKHE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LKDIOJCMHLE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KNKJANHBKOM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6F9380", Offset = "0x6F7D80", VA = "0x1806F9380")]
			[DebuggerHidden]
			public KNKJANHBKOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4356100", Offset = "0x4354B00", VA = "0x184356100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4356290", Offset = "0x4354C90", VA = "0x184356290", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x43561F0", Offset = "0x4354BF0", VA = "0x1843561F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x43561F0", Offset = "0x4354BF0", VA = "0x1843561F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int LIMKAOENHPP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x434F730", Offset = "0x434E130", VA = "0x18434F730", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<EKJHEBEFBCE> GLJOLBMFGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x434F710", Offset = "0x434E110", VA = "0x18434F710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> JPIMDNHDKFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GDFHEJFHPNM BMGOPFBLNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KOFDKIKGCEJ PFKCFIIDCHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x589040", Offset = "0x587A40", VA = "0x180589040", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(KOFDKIKGCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6D5110", Offset = "0x6D3B10", VA = "0x1806D5110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ECEEJCKAEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x434F720", Offset = "0x434E120", VA = "0x18434F720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x434E3A0", Offset = "0x434CDA0", VA = "0x18434E3A0")]
		public static ClusterMeshRenderer Create(GDFHEJFHPNM EALEDNNEEBC, ClusterMeshRenderer OLDHCMHFELL, MeshFilter IFODMDNACEG, Transform DDLLFFEEEME, KOFDKIKGCEJ PJKOCALJJDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x434E500", Offset = "0x434CF00", VA = "0x18434E500", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x434EC80", Offset = "0x434D680", VA = "0x18434EC80", Slot = "10")]
		public bool TryRemoveClusterLODComponent(EAEJMALDCGI ENHKEICGIAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x434EA50", Offset = "0x434D450", VA = "0x18434EA50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x434E760", Offset = "0x434D160", VA = "0x18434E760")]
		public void Init(GDFHEJFHPNM EALEDNNEEBC, MeshFilter IFODMDNACEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x434E560", Offset = "0x434CF60", VA = "0x18434E560")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x434EDB0", Offset = "0x434D7B0", VA = "0x18434EDB0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 JFCDBGEGOGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x434EFF0", Offset = "0x434D9F0", VA = "0x18434EFF0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x434E6F0", Offset = "0x434D0F0", VA = "0x18434E6F0")]
		[IteratorStateMachine(typeof(KNKJANHBKOM))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x434EAD0", Offset = "0x434D4D0", VA = "0x18434EAD0")]
		public void SetupTagAndLayer(string FGHLLAMJFFM, int PJKOCALJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x434EAB0", Offset = "0x434D4B0", VA = "0x18434EAB0")]
		public bool Remove(EAEJMALDCGI ENHKEICGIAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GILPAGICMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int OFPEMKLONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int KLJIMEJKFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NFHCBCLHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HIFFGNNDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4353520", Offset = "0x4351F20", VA = "0x184353520")]
	public GILPAGICMAJ(int KLJIMEJKFHH, int NFHCBCLHELA, int OFPEMKLONFL, int HIFFGNNDLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ODEKPKOGJNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<GILPAGICMAJ> FOEHHGHJJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> HPDODGMOMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> LGMEEKFDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> KCKNCHCDJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle JCKNIOCFKBC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x651F90", Offset = "0x650990", VA = "0x180651F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x94AC60", Offset = "0x949660", VA = "0x18094AC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x435AD60", Offset = "0x4359760", VA = "0x18435AD60")]
	public void OAIFMBNPDMM(FDNGLNHKOBP MKNABPNMBBF, NativeList<GILPAGICMAJ> FOEHHGHJJNO, float APOENGOBFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x435AAA0", Offset = "0x43594A0", VA = "0x18435AAA0")]
	public void KOFKHDDEJGL(Transform DDLLFFEEEME, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x435A810", Offset = "0x4359210", VA = "0x18435A810")]
	public void AAEMPGLDAGC(GDFHEJFHPNM DADDDHJHLLC, bool MCPMFKOAOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x435A9A0", Offset = "0x43593A0", VA = "0x18435A9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x435AA70", Offset = "0x4359470", VA = "0x18435AA70")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public ODEKPKOGJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct ELJKMKKDAIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<GILPAGICMAJ> DAEPCBDLGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> HPDODGMOMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 NPFGBLLKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> LGMEEKFDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> KCKNCHCDJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool JFJAAKFLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float DPLIMIIKIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float LOBPFPPFNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float CMBEBJPHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4351B00", Offset = "0x4350500", VA = "0x184351B00")]
	public ELJKMKKDAIO(ODEKPKOGJNI LFLNAFNFFMD, Vector3 NPFGBLLKMKP, bool JFJAAKFLIHG, float DPLIMIIKIHF, float LOBPFPPFNEI, float CMBEBJPHGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4351660", Offset = "0x4350060", VA = "0x184351660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EAEJMALDCGI : FKIIHBDDFPH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds JKDFLENDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NPIFNLMNIEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<EAEJMALDCGI> HBILPAFBEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public NPIFNLMNIEG MMEAACHMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public NPIFNLMNIEG ILIDAILMKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public NPIFNLMNIEG DMDFDBBLFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HIFFGNNDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds MJKIPNFICIA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x43587B0", Offset = "0x43571B0", VA = "0x1843587B0")]
	public NPIFNLMNIEG(List<EAEJMALDCGI> HBILPAFBEMD, [Optional] NPIFNLMNIEG MMEAACHMALE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JDJCFBCJGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<NPIFNLMNIEG> EOPLCFGOOPO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public NPIFNLMNIEG OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4355330", Offset = "0x4353D30", VA = "0x184355330")]
	public JDJCFBCJGDF(NPIFNLMNIEG DDLLFFEEEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MNHEIIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MMNAJGJFGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int GDKFODFBHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int HLKLGJCNGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JOCCLAIPLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int LGILIBEIHME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AKHIBBLBGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int AIHKHDHHFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float EJDELIMGNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<EAEJMALDCGI> HBILPAFBEMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PEDDODEMLBC
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
	private MMNAJGJFGHB AMNFDEJLGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DHCBAKKLIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int HOFMJIHFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int BMHMCKFPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float CDNEHLAFBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float OGJBDCEPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<NPIFNLMNIEG> BEPFEAMGOOF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JDJCFBCJGDF BPAFEPBDAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4358500", Offset = "0x4356F00", VA = "0x184358500")]
	public MNHEIIKJNAH(int HOFMJIHFPCG, int BMHMCKFPIDM, float CDNEHLAFBHF, int DHCBAKKLIGB, float OGJBDCEPBIN = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4358340", Offset = "0x4356D40", VA = "0x184358340")]
	public void ODMEPIDONMK(List<EAEJMALDCGI> HBILPAFBEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4358120", Offset = "0x4356B20", VA = "0x184358120")]
	public bool MBCOOAGPIML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4358230", Offset = "0x4356C30", VA = "0x184358230")]
	private float NMJCPDEGBDP(Vector3 CJILIEPCADK, Vector3 AOLLHLFGLAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4358190", Offset = "0x4356B90", VA = "0x184358190")]
	private float NMJCPDEGBDP(Vector3 OCEBHFCGEGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4357810", Offset = "0x4356210", VA = "0x184357810")]
	private bool JGKKCLOKCAH(NPIFNLMNIEG JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4356930", Offset = "0x4355330", VA = "0x184356930")]
	private AKHIBBLBGKC CANGEIHGHOE(List<EAEJMALDCGI> CCNBHOGMLHC, PEDDODEMLBC JELKBKBBOAA)
	{
		return default(AKHIBBLBGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4357480", Offset = "0x4355E80", VA = "0x184357480")]
	private void HFGFPGGBICA(List<EAEJMALDCGI> HBILPAFBEMD, Vector3[] FJMBJJAGEEM, Vector3[] DMFEFCEOEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class BGHCPJAOHAI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x434E060", Offset = "0x434CA60", VA = "0x18434E060")]
	public static Bounds NHHHMEPGPBD(List<EAEJMALDCGI> HBILPAFBEMD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x434DED0", Offset = "0x434C8D0", VA = "0x18434DED0")]
	public static int AMDABMDFAGE(List<EAEJMALDCGI> HBILPAFBEMD, FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GPMMGDLBMIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FDNGLNHKOBP GFPDHNLOAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FDNGLNHKOBP OJBCEBOOLBE;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FDNGLNHKOBP BJFOEKILKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IOMMINGJLHB FLHJJMCFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private DDNJIGMIAPI FLCPIGBNHNH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle JCKNIOCFKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6311E0", Offset = "0x62FBE0", VA = "0x1806311E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB2E650", Offset = "0xB2D050", VA = "0x180B2E650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EMNDGGHFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8420A0", VA = "0x1808436A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x43535B0", Offset = "0x4351FB0", VA = "0x1843535B0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private void EIMDHMCFDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4353C70", Offset = "0x4352670", VA = "0x184353C70")]
	public void OAIFMBNPDMM(GDFHEJFHPNM.HCLGAICCBEB DAEPCBDLGAK, Transform BEDJIMAHPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4353660", Offset = "0x4352060", VA = "0x184353660")]
	public void LCPPGPMOOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4353540", Offset = "0x4351F40", VA = "0x184353540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4353620", Offset = "0x4352020", VA = "0x184353620")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4354690", Offset = "0x4353090", VA = "0x184354690")]
	public GPMMGDLBMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EIHKLLHAFGL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OJHCLKMGAMM HACJFNOPBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HHBKIKIGDAP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 AJJBMKIFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AEBMEDJCFPO
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(BDMELKPFPFB BNHHCEGJNOI, CancellationToken PKFOPLIPJOL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PMDPHBDMHMF
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMDPHBDMHMF FBAAIPPFAMK(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMDPHBDMHMF LILECGPJGLN(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMDPHBDMHMF JKHKOCHNLOC(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMDPHBDMHMF OJLPBNJJKDI(Action APBFEHIGAIL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class OBLGHEHKMNF : PMDPHBDMHMF
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PAJNOFPCIAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public OBLGHEHKMNF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
				public PAJNOFPCIAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x435EAE0", Offset = "0x435D4E0", VA = "0x18435EAE0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x435EB30", Offset = "0x435D530", VA = "0x18435EB30")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x435EB80", Offset = "0x435D580", VA = "0x18435EB80")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> NNMPHDINGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action EFIJHMIPCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action OFLAMKMGIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private FJNPIDOKNHN IFDCJCIOOBK;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action BCCPDMCKGPG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x751CA0", Offset = "0x7506A0", VA = "0x180751CA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action MFNKEHCFOHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD6080", VA = "0x180AD7680", Slot = "4")]
			public PMDPHBDMHMF FBAAIPPFAMK(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xA35600", Offset = "0xA34000", VA = "0x180A35600", Slot = "5")]
			public PMDPHBDMHMF LILECGPJGLN(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAD76A0", Offset = "0xAD60A0", VA = "0x180AD76A0", Slot = "6")]
			public PMDPHBDMHMF JKHKOCHNLOC(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAD7770", Offset = "0xAD6170", VA = "0x180AD7770", Slot = "7")]
			public PMDPHBDMHMF OJLPBNJJKDI(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
			public OBLGHEHKMNF(Func<JobHandle> GKHPIBLJDAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4359210", Offset = "0x4357C10", VA = "0x184359210")]
			public void ADLAMHIBLDH(Action ACPJCBCGDBJ, Action NKJDMKAGMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4359440", Offset = "0x4357E40", VA = "0x184359440")]
			public void DFDJPGANONL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JCFDNFMNIOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public PMDPHBDMHMF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public JCFDNFMNIOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4355320", Offset = "0x4353D20", VA = "0x184355320")]
			internal bool <Remove>b__0(OBLGHEHKMNF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PHGDBGIAAJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public OBLGHEHKMNF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public PHGDBGIAAJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x435EC50", Offset = "0x435D650", VA = "0x18435EC50")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<OBLGHEHKMNF> JMMHCJCICGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<OBLGHEHKMNF> DPGDALCEADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private LMANBCGFHOA JICFBJJIJOO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public OMKIBIOOPMK OKEBNHKPMJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x43553E0", Offset = "0x4353DE0", VA = "0x1843553E0")]
		public PMDPHBDMHMF Add(Func<JobHandle> GKHPIBLJDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4355680", Offset = "0x4354080", VA = "0x184355680")]
		public void Remove(PMDPHBDMHMF JCKNIOCFKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4355800", Offset = "0x4354200", VA = "0x184355800")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x43559D0", Offset = "0x43543D0", VA = "0x1843559D0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43554F0", Offset = "0x4353EF0", VA = "0x1843554F0")]
		[CompilerGenerated]
		private void KJHABLLJJAM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FJNPIDOKNHN
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJNPIDOKNHN FBAAIPPFAMK(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJNPIDOKNHN EHGPGIPJKPF(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJNPIDOKNHN OJLPBNJJKDI(Action APBFEHIGAIL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PDIMEIAIBEO : FJNPIDOKNHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle LDENLMPPLEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action EFIJHMIPCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action LFAHLKOHKGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action MFNKEHCFOHC;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool LBBAFOKHDHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x435EBC0", Offset = "0x435D5C0", VA = "0x18435EBC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA35600", Offset = "0xA34000", VA = "0x180A35600", Slot = "4")]
			public FJNPIDOKNHN FBAAIPPFAMK(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xAD76A0", Offset = "0xAD60A0", VA = "0x180AD76A0", Slot = "5")]
			public FJNPIDOKNHN EHGPGIPJKPF(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAD7770", Offset = "0xAD6170", VA = "0x180AD7770", Slot = "6")]
			public FJNPIDOKNHN OJLPBNJJKDI(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1603FF0", Offset = "0x16029F0", VA = "0x181603FF0")]
			public PDIMEIAIBEO(JobHandle ABJPODFEJGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x435EBD0", Offset = "0x435D5D0", VA = "0x18435EBD0")]
			public void DCGILHLCDMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x435EC10", Offset = "0x435D610", VA = "0x18435EC10")]
			public void DFDJPGANONL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<PDIMEIAIBEO> ELELGFHHLNB;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4355E50", Offset = "0x4354850", VA = "0x184355E50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4355A90", Offset = "0x4354490", VA = "0x184355A90")]
		public FJNPIDOKNHN Add(JobHandle ABJPODFEJGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4355D60", Offset = "0x4354760", VA = "0x184355D60")]
		public void Remove(FJNPIDOKNHN JCKNIOCFKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4355C00", Offset = "0x4354600", VA = "0x184355C00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4355B20", Offset = "0x4354520", VA = "0x184355B20")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4355F60", Offset = "0x4354960", VA = "0x184355F60")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4356610", Offset = "0x4355010", VA = "0x184356610")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x43562E0", Offset = "0x4354CE0", VA = "0x1843562E0")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
