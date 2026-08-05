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
				[Cpp2IlInjected.Address(RVA = "0x47F6CF0", Offset = "0x47F58F0", VA = "0x1847F6CF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x10DC790", Offset = "0x10DB390", VA = "0x1810DC790")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x47F6CB0", Offset = "0x47F58B0", VA = "0x1847F6CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x47EC9C0", Offset = "0x47EB5C0", VA = "0x1847EC9C0")]
		public LODSettings DLHOKHDADGO(NADLMEPLBLH HCCNHCAJIKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x47ECAD0", Offset = "0x47EB6D0", VA = "0x1847ECAD0")]
		public int PGMMKKFIMDC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x47EC9D0", Offset = "0x47EB5D0", VA = "0x1847EC9D0")]
		public int DPAPPKEECPA(bool OANBHNONIOC, Vector3 HPNEGHAOCAJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x47ECAF0", Offset = "0x47EB6F0", VA = "0x1847ECAF0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HJLMDGNECII
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
public interface EGDDKOFJHME
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIKNGNMBDBB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IGIPHBLDMAA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FPMJOAPPCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LJODKMHJJIF> GEBKBHPFIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HJLMDGNECII JPCCBBDLJLG
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
	void UpdateClusterDistances(Vector3 NHJNMDPPLMP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(BEOIEFPIHPF GPCFBGLDMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LJODKMHJJIF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int INHEOBDHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LOCLBPDNOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FPHOBJEANEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EKDOFFGBNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte EGPBKIHIEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LPBPOBMEHEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GFPOHLBCNDO
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
	private struct PHLNDHKKOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LPBPOBMEHEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JPHACOIJIFD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private JPHACOIJIFD <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x47FB330", Offset = "0x47F9F30", VA = "0x1847FB330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NOHHJCBMLDG : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LPBPOBMEHEO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public NOHHJCBMLDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47FB110", Offset = "0x47F9D10", VA = "0x1847FB110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x47FB1D0", Offset = "0x47F9DD0", VA = "0x1847FB1D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KNEEAHCPEJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LPBPOBMEHEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JPHACOIJIFD worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JPHACOIJIFD <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x47F5990", Offset = "0x47F4590", VA = "0x1847F5990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FBHFCLHHHJG : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LPBPOBMEHEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public FBHFCLHHHJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x47F0BE0", Offset = "0x47EF7E0", VA = "0x1847F0BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47F1AC0", Offset = "0x47F06C0", VA = "0x1847F1AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int AKHMGIHBFLA = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan CCOIDECCAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer IJKOCHGPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter IBIMDGDEMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LGKLNJPJGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject NJNFCAODLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NEALFFONAGD AHPNPNGLLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<BEOIEFPIHPF> OHDPLJAPHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<BEOIEFPIHPF> DOGELMJMMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<BEOIEFPIHPF> CDLFANKNDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KGJIMDBJAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GFPOHLBCNDO BMJMPHGALMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<IGIPHBLDMAA>[] IHPIDMDLONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LJODKMHJJIF>[] IKJJCBOMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource BCJAMKGCFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool MHPGAFMBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ILEKNFOCKKN NMBMDOEDACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ILEKNFOCKKN AJKMNPACLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int PDMHPIPOPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int BPGEKEDLMKP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static LPBPOBMEHEO NKJOPPHMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LNFHHANGIBM AMMGEMPDJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JHJAAACIFPA FIHMEBIBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour GFLGJDBFLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material EGAAPFADHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<EGDDKOFJHME> DJPJOMMHJKB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig FECJJLHPMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 PNHOCAENKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x126D260", Offset = "0x126BE60", VA = "0x18126D260")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x126D180", Offset = "0x126BD80", VA = "0x18126D180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private GFPOHLBCNDO CDJDPAIKLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F7CD0", Offset = "0x5F68D0", VA = "0x1805F7CD0")]
		get
		{
			return default(GFPOHLBCNDO);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x47F8580", Offset = "0x47F7180", VA = "0x1847F8580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LPBPOBMEHEO PPLIIACIKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x47F81D0", Offset = "0x47F6DD0", VA = "0x1847F81D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool DIAICKDAMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x47F80B0", Offset = "0x47F6CB0", VA = "0x1847F80B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool JFFGDJOPHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x47F82F0", Offset = "0x47F6EF0", VA = "0x1847F82F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> BEGPOAKDIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x47F8010", Offset = "0x47F6C10", VA = "0x1847F8010")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x47F9600", Offset = "0x47F8200", VA = "0x1847F9600")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IPCJHPJMFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x47F9030", Offset = "0x47F7C30", VA = "0x1847F9030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x47F94A0", Offset = "0x47F80A0", VA = "0x1847F94A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x47F9710", Offset = "0x47F8310", VA = "0x1847F9710")]
	public LPBPOBMEHEO(LNFHHANGIBM AMMGEMPDJDA, JHJAAACIFPA FIHMEBIBEOA, ClusterLODConfig LJEGGCLLNNB, MonoBehaviour GFLGJDBFLLO, Material EGAAPFADHBN, ClusterMeshRenderer IJKOCHGPIID, MeshFilter IBIMDGDEMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x47F7F10", Offset = "0x47F6B10", VA = "0x1847F7F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47F8910", Offset = "0x47F7510", VA = "0x1847F8910")]
	public static void JJGMBGPCLBB(Vector3 FJOKLIIGEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47F8710", Offset = "0x47F7310", VA = "0x1847F8710")]
	private void IJGNCJHJAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47F8D60", Offset = "0x47F7960", VA = "0x1847F8D60")]
	private void LDCCMPMHPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47F8440", Offset = "0x47F7040", VA = "0x1847F8440")]
	private void HCEMGJPNJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x47F7890", Offset = "0x47F6490", VA = "0x1847F7890")]
	public void DEPGCDIILNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47F90D0", Offset = "0x47F7CD0", VA = "0x1847F90D0")]
	[AsyncStateMachine(typeof(PHLNDHKKOCL))]
	public Task MLNCJFPGOEO(JPHACOIJIFD NJKJPCGAGLF, CancellationToken EAMPAKHINCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47F86A0", Offset = "0x47F72A0", VA = "0x1847F86A0")]
	[IteratorStateMachine(typeof(NOHHJCBMLDG))]
	private IEnumerator<GGCFHHNCLAL> IJDCPMCAOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47F6D10", Offset = "0x47F5910", VA = "0x1847F6D10")]
	[AsyncStateMachine(typeof(KNEEAHCPEJA))]
	private Task APLOHKGEAOG(JPHACOIJIFD BFLGJEJNJLD, CancellationToken NKLNCNDPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47F9290", Offset = "0x47F7E90", VA = "0x1847F9290")]
	public void OHOPMKDPMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47F9540", Offset = "0x47F8140", VA = "0x1847F9540")]
	public void PDOCCBFNLCN(IEnumerable<IGIPHBLDMAA> NPMOIMHEFED, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47F8AB0", Offset = "0x47F76B0", VA = "0x1847F8AB0")]
	public void KOLAIAFDJHL(IEnumerable<IGIPHBLDMAA> NPMOIMHEFED, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47F70A0", Offset = "0x47F5CA0", VA = "0x1847F70A0")]
	public List<ClusterMeshRenderer> DEDJKKFFAMI(List<BEOIEFPIHPF> COEEIMIEFEF, LMMBNFLDKGF FEKJACABLNO, HJLMDGNECII CBLNIAEEDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47F6E90", Offset = "0x47F5A90", VA = "0x1847F6E90")]
	public HJLMDGNECII BPPOCKNGJCO(Vector3 ODELOKJHKGD)
	{
		return default(HJLMDGNECII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47F7D80", Offset = "0x47F6980", VA = "0x1847F7D80")]
	public void DHGGABFMCAB(EGDDKOFJHME NLNLMCJGMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47F8290", Offset = "0x47F6E90", VA = "0x1847F8290")]
	public bool FKMELGKOLEE(EGDDKOFJHME NLNLMCJGMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47F7040", Offset = "0x47F5C40", VA = "0x1847F7040")]
	public void DCNEPCOMABE(BEOIEFPIHPF BKJCPJHLIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x47F9210", Offset = "0x47F7E10", VA = "0x1847F9210")]
	public void NHGPKKFBBJJ(LJODKMHJJIF DGFLPFMPLJK, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47F8A30", Offset = "0x47F7630", VA = "0x1847F8A30")]
	public void KECEEHLBEPN(LJODKMHJJIF DGFLPFMPLJK, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47F7DE0", Offset = "0x47F69E0", VA = "0x1847F7DE0")]
	private void DKNMCKBMLDH(Vector3 NHJNMDPPLMP, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47F6ED0", Offset = "0x47F5AD0", VA = "0x1847F6ED0")]
	private void CABIKPFJPHP(Vector3 NHJNMDPPLMP, HJLMDGNECII CBLNIAEEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47F83D0", Offset = "0x47F6FD0", VA = "0x1847F83D0")]
	[IteratorStateMachine(typeof(FBHFCLHHHJG))]
	private IEnumerator<GGCFHHNCLAL> GJHANIJDLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47F87A0", Offset = "0x47F73A0", VA = "0x1847F87A0")]
	private int ILAJOOINCJD(int BAOHKIGDOBF, int MPCHBNJCEFB, List<LJODKMHJJIF> EKMMIPCMANO, byte HCCNHCAJIKB, ref int IEKENCABEKG, float JGGEGPHACGL = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x47F8E60", Offset = "0x47F7A60", VA = "0x1847F8E60")]
	public void MAHLOMNJIKK(BEOIEFPIHPF GPCFBGLDMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47F6E50", Offset = "0x47F5A50", VA = "0x1847F6E50")]
	public bool BKGOCMMLLLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66FAA0", Offset = "0x66E6A0", VA = "0x18066FAA0")]
	public Material IIDDCNFHNPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x47F95C0", Offset = "0x47F81C0", VA = "0x1847F95C0")]
	public int PGMMKKFIMDC()
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
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EHLNJBPDHHD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> GMNMDCGKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> MNPPOGGIPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> FAILEHLNPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> JHLNPLCBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> HGFHCMKOOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> CFGAMGPMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> CADDKEABECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 JDOBPBOLADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float IDPKGIGAOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> LOKJMAFJDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> HHOGNMDNNAO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x47F0B00", Offset = "0x47EF700", VA = "0x1847F0B00")]
	public EHLNJBPDHHD(JOMACKCFBMO GIJGPGKFDMC, NativeList<float3> CADDKEABECJ, NativeMultiHashMap<int, int> LOKJMAFJDHM, NativeArray<int> HHOGNMDNNAO, Vector3 JDOBPBOLADO, float IDPKGIGAOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x47F0AA0", Offset = "0x47EF6A0", VA = "0x1847F0AA0")]
	private int KIHBEFBIKBC(float3 NHJNMDPPLMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x47F0800", Offset = "0x47EF400", VA = "0x1847F0800")]
	private int HCKKLOEHLMH(int ACJHPBCLINB, int IHPCMBAPNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47F0410", Offset = "0x47EF010", VA = "0x1847F0410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MNCKJEIENLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> LOKJMAFJDHM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> HHOGNMDNNAO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int GEKKFOKPAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> ADDOCAFIKME;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47FA3B0", Offset = "0x47F8FB0", VA = "0x1847FA3B0")]
	public void HFMJJJPJLFD(int EKGKKDAMCKN, Allocator KIPGDNHHBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47FA300", Offset = "0x47F8F00", VA = "0x1847FA300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public MNCKJEIENLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct CJMIPHJALGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> PNAIBGNFDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> HODNADDMOCN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47EC990", Offset = "0x47EB590", VA = "0x1847EC990")]
	public CJMIPHJALGK(MNCKJEIENLC LEJKHGKCDBD, JOMACKCFBMO GIJGPGKFDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47EC900", Offset = "0x47EB500", VA = "0x1847EC900", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct KGMCFCIFLFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> ICCLAIMEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> LJENLDJHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> PFKFJKGJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> ECGAEOBADGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> HIICMKJKJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> ADDOCAFIKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> PNAIBGNFDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> HNKHADGCIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> CFAGBPMODHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> EJJMMPNKOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> EKMCOMNAMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> COGLNDCMKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> GODBLBDLLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float NHPIIIAOMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float OBFMBNBIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 CFJDFEALBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FKCICJOGJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float IAMIMPEONBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float FLANGJLOLNC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47F4D10", Offset = "0x47F3910", VA = "0x1847F4D10")]
	public KGMCFCIFLFM(MNCKJEIENLC HHNPHDLBOMI, JOMACKCFBMO GIJGPGKFDMC, JOMACKCFBMO CFECKCFFLDG, float IAMIMPEONBM, float FLANGJLOLNC, Vector3 CFJDFEALBEN, float FKCICJOGJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x47F49B0", Offset = "0x47F35B0", VA = "0x1847F49B0")]
	private float3 JPMJIHLLLNI(int ACJHPBCLINB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x47F4240", Offset = "0x47F2E40", VA = "0x1847F4240")]
	private void GMMKKBMAGCP(int ACJHPBCLINB, out float3 MLGOBHDJILM, out float3 NKFFBDOCHJI, out float4 OOIHKDKHBPB, out float4 KLLDJJOCPGL, out float2 AIEPJFJCDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x47F4420", Offset = "0x47F3020", VA = "0x1847F4420")]
	private int HFNFHGACIOC(int FCNCEHCOIAD, int CHFOKFPEEJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x47F4B10", Offset = "0x47F3710", VA = "0x1847F4B10")]
	private void OCMMMJCPCNA(int FCNCEHCOIAD, int CHFOKFPEEJB, int FOCAEKNEKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x47F3730", Offset = "0x47F2330", VA = "0x1847F3730")]
	private bool ABPJKJNANNF(int FCNCEHCOIAD, int CHFOKFPEEJB, float MMODGBOGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x47F4A50", Offset = "0x47F3650", VA = "0x1847F4A50")]
	private bool NGCNHAJIPLO(int FCNCEHCOIAD, int CHFOKFPEEJB, int FOCAEKNEKPP, float MMODGBOGAJO, bool LDBKOKEFOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47F4750", Offset = "0x47F3350", VA = "0x1847F4750")]
	private bool JMKOLDHBDIE(int FCNCEHCOIAD, int CHFOKFPEEJB, int FOCAEKNEKPP, float MMODGBOGAJO, bool LDBKOKEFOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47F38C0", Offset = "0x47F24C0", VA = "0x1847F38C0")]
	private void EAKDELLFLMN(int FCNCEHCOIAD, int CHFOKFPEEJB, int FOCAEKNEKPP, out int IHJDONMFJFL, out int ILCHBOMKMNJ, out int JCCGGMBBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47F38E0", Offset = "0x47F24E0", VA = "0x1847F38E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CCDHHFJPHMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KLDAGCANHNA : IDisposable, LJODKMHJJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds IPEPCLOOLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<BEOIEFPIHPF> COEEIMIEFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 PAGOKMHLKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 HKNOECOAJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int CMKIDMKDMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JOMACKCFBMO FGJMOABKPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MNCKJEIENLC FMGPPJBHLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform FEKJACABLNO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int PJLCGEJNMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x47F4E50", Offset = "0x47F3A50", VA = "0x1847F4E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh BOOOFAJKEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CJHCDOGOKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FPHOBJEANEL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1A07400", Offset = "0x1A06000", VA = "0x181A07400", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1F3E500", Offset = "0x1F3D100", VA = "0x181F3E500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte EGPBKIHIEPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x734870", Offset = "0x733470", VA = "0x180734870")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x734A00", Offset = "0x733600", VA = "0x180734A00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int INHEOBDHKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x780800", Offset = "0x77F400", VA = "0x180780800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x77FE90", Offset = "0x77EA90", VA = "0x18077FE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int LOCLBPDNOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBB3EA0", Offset = "0xBB2AA0", VA = "0x180BB3EA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE37F50", Offset = "0xE36B50", VA = "0x180E37F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EKDOFFGBNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x47F4F30", Offset = "0x47F3B30", VA = "0x1847F4F30", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x47F56A0", Offset = "0x47F42A0", VA = "0x1847F56A0")]
		public void MCNGKOBDFBL(NADLMEPLBLH HCCNHCAJIKB, out int LHIGPGMKLNB, out int HCAOHNJMLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x47F5500", Offset = "0x47F4100", VA = "0x1847F5500")]
		public void LNMNJEAKCOI(NADLMEPLBLH HCCNHCAJIKB, NONPADBMJOO MOJPAKJHKFI, int GFKEGBDLGNM = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x47F5140", Offset = "0x47F3D40", VA = "0x1847F5140")]
		public void GENOBLANLDF(NativeList<LKJAONLPEHC> OPEPJGMNNNP, Transform FKNIPIPDEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47F4E90", Offset = "0x47F3A90", VA = "0x1847F4E90")]
		public void BNLBJNIHIJJ(Mesh GIJGPGKFDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47F5460", Offset = "0x47F4060", VA = "0x1847F5460")]
		public void JJCKCNJLOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x47F4F50", Offset = "0x47F3B50", VA = "0x1847F4F50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x47F58D0", Offset = "0x47F44D0", VA = "0x1847F58D0")]
		public KLDAGCANHNA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds IPEPCLOOLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<KLDAGCANHNA> GJOFNNNMFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public EFOLFLPNBIO LBIAJIEMCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer BOLCPAJJPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int BCMMEHPINEJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh HKMJNJLAEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EGKEBPAFENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E70", Offset = "0x7D4A70", VA = "0x1807D5E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EF0", Offset = "0x7D4AF0", VA = "0x1807D5EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FPMJOAPPCED
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x47EB500", Offset = "0x47EA100", VA = "0x1847EB500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47EB550", Offset = "0x47EA150", VA = "0x1847EB550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47EB6B0", Offset = "0x47EA2B0", VA = "0x1847EB6B0")]
	public int GDKPPEEPCIJ(int COGFKCMKLPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x47EB6E0", Offset = "0x47EA2E0", VA = "0x1847EB6E0")]
	public void JJEHKPBKPMN(PDHINPCEFOA IHIDMBMIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x47EC100", Offset = "0x47EAD00", VA = "0x1847EC100")]
	public void ONGJMLCDONI(Transform FKNIPIPDEDF, bool IBKCFAKDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47EB870", Offset = "0x47EA470", VA = "0x1847EB870")]
	public bool JNFELENIHKK(bool KFMOPHBIFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47EBCA0", Offset = "0x47EA8A0", VA = "0x1847EBCA0")]
	public void OFDPEKHNIMB(Transform FEKJACABLNO, bool IBKCFAKDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x47EBA20", Offset = "0x47EA620", VA = "0x1847EBA20")]
	public bool MAHLOMNJIKK(BEOIEFPIHPF GPCFBGLDMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x47EC860", Offset = "0x47EB460", VA = "0x1847EC860")]
	public CCDHHFJPHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NEALFFONAGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<CCDHHFJPHMC.KLDAGCANHNA> DNJGEDOJGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private DFGMDBOCCNE IPEJNCBJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<CCDHHFJPHMC.KLDAGCANHNA> CFKGMCNEDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EJMEKEOEHMD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47FA7E0", Offset = "0x47F93E0", VA = "0x1847FA7E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x47FAD70", Offset = "0x47F9970", VA = "0x1847FAD70")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x47FA980", Offset = "0x47F9580", VA = "0x1847FA980")]
	public void JNIPLPDFDNO(CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME, Transform FEKJACABLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x47FABC0", Offset = "0x47F97C0", VA = "0x1847FABC0")]
	public void MAHLOMNJIKK(CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x47FAA90", Offset = "0x47F9690", VA = "0x1847FAA90")]
	private CCDHHFJPHMC.KLDAGCANHNA LACHEPEGLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47FA8F0", Offset = "0x47F94F0", VA = "0x1847FA8F0")]
	private bool IHLLJEGIOPP(CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x47FA850", Offset = "0x47F9450", VA = "0x1847FA850")]
	private void EAJHOBHGGLJ(CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47FA8B0", Offset = "0x47F94B0", VA = "0x1847FA8B0")]
	public bool FFBHHKABMHA(CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47FA550", Offset = "0x47F9150", VA = "0x1847FA550")]
	public bool ADGIMOCDCAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47FAA30", Offset = "0x47F9630", VA = "0x1847FAA30")]
	private CCDHHFJPHMC.KLDAGCANHNA KHHEDICPAFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47FADF0", Offset = "0x47F99F0", VA = "0x1847FADF0")]
	public NEALFFONAGD()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MKAIKEDKBBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HENOOAIFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int BECFHHKJLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float EDAJHCAKGGI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<CCDHHFJPHMC> BCBNNCIJMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47FA2B0", Offset = "0x47F8EB0", VA = "0x1847FA2B0")]
	public MKAIKEDKBBH(int HENOOAIFIOM, int BECFHHKJLNM, float GNBMLKIAKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x47FA170", Offset = "0x47F8D70", VA = "0x1847FA170")]
	public void MDCBEPMLABM(IAHDIKHJJKP DMKILOMAIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47FA210", Offset = "0x47F8E10", VA = "0x1847FA210")]
	private int PEOPPANJLGK(PDHINPCEFOA KCNEPLILALO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47F9F40", Offset = "0x47F8B40", VA = "0x1847F9F40")]
	private void MDCBEPMLABM(PDHINPCEFOA KCNEPLILALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47F9D60", Offset = "0x47F8960", VA = "0x1847F9D60")]
	private void DOEICINGLAD(PDHINPCEFOA KCNEPLILALO, CCDHHFJPHMC GMIEOOFNLJB)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, IGIPHBLDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NIICGHPDBHL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
			[DebuggerHidden]
			public NIICGHPDBHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x47FAF30", Offset = "0x47F9B30", VA = "0x1847FAF30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x47FB0C0", Offset = "0x47F9CC0", VA = "0x1847FB0C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x47FB020", Offset = "0x47F9C20", VA = "0x1847FB020", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x47FB020", Offset = "0x47F9C20", VA = "0x1847FB020", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FPMJOAPPCED
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x47EDF00", Offset = "0x47ECB00", VA = "0x1847EDF00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<LJODKMHJJIF> GEBKBHPFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x47EDEE0", Offset = "0x47ECAE0", VA = "0x1847EDEE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> GJOFNNNMFGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CCDHHFJPHMC HKMJNJLAEFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HJLMDGNECII JPCCBBDLJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E5390", Offset = "0x5E3F90", VA = "0x1805E5390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(HJLMDGNECII);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7EE880", Offset = "0x7ED480", VA = "0x1807EE880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MJBOLOFDPNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x47EDEF0", Offset = "0x47ECAF0", VA = "0x1847EDEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x47ECB50", Offset = "0x47EB750", VA = "0x1847ECB50")]
		public static ClusterMeshRenderer Create(CCDHHFJPHMC GIJGPGKFDMC, ClusterMeshRenderer IJKOCHGPIID, MeshFilter IBIMDGDEMAJ, LMMBNFLDKGF FEKJACABLNO, HJLMDGNECII CBLNIAEEDJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x47ECCD0", Offset = "0x47EB8D0", VA = "0x1847ECCD0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x47ED450", Offset = "0x47EC050", VA = "0x1847ED450", Slot = "10")]
		public bool TryRemoveClusterLODComponent(BEOIEFPIHPF GPCFBGLDMBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x47ED220", Offset = "0x47EBE20", VA = "0x1847ED220")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x47ECF30", Offset = "0x47EBB30", VA = "0x1847ECF30")]
		public void Init(CCDHHFJPHMC GIJGPGKFDMC, MeshFilter IBIMDGDEMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x47ECD30", Offset = "0x47EB930", VA = "0x1847ECD30")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x47ED580", Offset = "0x47EC180", VA = "0x1847ED580", Slot = "8")]
		public void UpdateClusterDistances(Vector3 NHJNMDPPLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x47ED7C0", Offset = "0x47EC3C0", VA = "0x1847ED7C0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x47ECEC0", Offset = "0x47EBAC0", VA = "0x1847ECEC0")]
		[IteratorStateMachine(typeof(NIICGHPDBHL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x47ED2A0", Offset = "0x47EBEA0", VA = "0x1847ED2A0")]
		public void SetupTagAndLayer(string LCPIALPGKLG, int CBLNIAEEDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x47ED280", Offset = "0x47EBE80", VA = "0x1847ED280")]
		public bool Remove(BEOIEFPIHPF GPCFBGLDMBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EIIDMEGLPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int OGLFCIOLLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int OEHNDNCNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HCAOHNJMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LHIGPGMKLNB;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47F0BC0", Offset = "0x47EF7C0", VA = "0x1847F0BC0")]
	public EIIDMEGLPML(int OEHNDNCNDKL, int HCAOHNJMLAB, int OGLFCIOLLOF, int LHIGPGMKLNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EFOLFLPNBIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> GMNMDCGKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> ADDOCAFIKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> CFGAMGPMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<EIIDMEGLPML> CMCJHIBMAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> GODMBKFBDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> EPALCLPDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> OOHFGFDHDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle NHBMKIBCLOB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DIKPGGBGHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x853530", Offset = "0x852130", VA = "0x180853530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x853550", Offset = "0x852150", VA = "0x180853550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x47EF660", Offset = "0x47EE260", VA = "0x1847EF660")]
	public void MMDAHEHGHKH(JOMACKCFBMO BCGOJIFMNMN, NativeList<EIIDMEGLPML> CMCJHIBMAKJ, float AEDGLIBFDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x47EF210", Offset = "0x47EDE10", VA = "0x1847EF210")]
	public void EAPIGJNMAGE(Transform FEKJACABLNO, bool IBKCFAKDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x47EF4D0", Offset = "0x47EE0D0", VA = "0x1847EF4D0")]
	public void JNFELENIHKK(CCDHHFJPHMC BOLCPAJJPIN, bool KFMOPHBIFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x47EF140", Offset = "0x47EDD40", VA = "0x1847EF140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x47F03E0", Offset = "0x47EEFE0", VA = "0x1847F03E0")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EFOLFLPNBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct JGCPGMAIDGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> GMNMDCGKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> ADDOCAFIKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<EIIDMEGLPML> DGENBMKEINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> GODMBKFBDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 CFJDFEALBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> EPALCLPDHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> OOHFGFDHDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool IBKCFAKDGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float NIHGMKNLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float IACKCIAGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float LJDICKAKGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> CFGAMGPMLDE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x47F2A40", Offset = "0x47F1640", VA = "0x1847F2A40")]
	public JGCPGMAIDGA(EFOLFLPNBIO FCDKMBBNEOA, Vector3 CFJDFEALBEN, bool IBKCFAKDGHM, float NIHGMKNLKJB, float IACKCIAGKOK, float LJDICKAKGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47F25A0", Offset = "0x47F11A0", VA = "0x1847F25A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BEOIEFPIHPF : IJAEOFCEPOA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds EEFMBIGMEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LKJAONLPEHC CHCMIBHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PDHINPCEFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<BEOIEFPIHPF> COEEIMIEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public PDHINPCEFOA PPHLLODMENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public PDHINPCEFOA CKHJNOFOJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public PDHINPCEFOA IEMIKHCCKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int LHIGPGMKLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds IPEPCLOOLAD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x47FB2B0", Offset = "0x47F9EB0", VA = "0x1847FB2B0")]
	public PDHINPCEFOA(List<BEOIEFPIHPF> COEEIMIEFEF, [Optional] PDHINPCEFOA PPHLLODMENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IAHDIKHJJKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<PDHINPCEFOA> PFLNNLDHILO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PDHINPCEFOA KBKNGMOBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47F2160", Offset = "0x47F0D60", VA = "0x1847F2160")]
	public IAHDIKHJJKP(PDHINPCEFOA FEKJACABLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BDNNEICMMIC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct APPIGDNICDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int EMGEKNHGHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int AIFEAMJPPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int KIFEKDNHKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int GHIBNFLIAOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OPFBNMHKKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int LFAODLOBDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float OIBFKINKPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<BEOIEFPIHPF> COEEIMIEFEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum BIJDOGMGLJN
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
	private APPIGDNICDC NNOGIDNFKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DMPFNIOJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int HENOOAIFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int BECFHHKJLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GNBMLKIAKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float LADGNNEFDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<PDHINPCEFOA> PPNCLBOMOMB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IAHDIKHJJKP AFPFPPHKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47EB160", Offset = "0x47E9D60", VA = "0x1847EB160")]
	public BDNNEICMMIC(int HENOOAIFIOM, int BECFHHKJLNM, float GNBMLKIAKBC, int DMPFNIOJFJH, float LADGNNEFDIK = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x47E9990", Offset = "0x47E8590", VA = "0x1847E9990")]
	public void LHKGBFLFKLB(List<BEOIEFPIHPF> COEEIMIEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x47E9920", Offset = "0x47E8520", VA = "0x1847E9920")]
	public bool GFHOFOCNILK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x47EAFB0", Offset = "0x47E9BB0", VA = "0x1847EAFB0")]
	private float PHEFFFGMJCF(Vector3 LAKDIHOJGNM, Vector3 COIOJNIHJPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x47EB0C0", Offset = "0x47E9CC0", VA = "0x1847EB0C0")]
	private float PHEFFFGMJCF(Vector3 AABEJHHLOHL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x47E9B50", Offset = "0x47E8750", VA = "0x1847E9B50")]
	private bool NIGJFLOPGGB(PDHINPCEFOA EKDMHMCPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47EA460", Offset = "0x47E9060", VA = "0x1847EA460")]
	private OPFBNMHKKMA NJBCMKHIHKF(List<BEOIEFPIHPF> LOKNIKGIOLB, BIJDOGMGLJN PILIGFLBLAJ)
	{
		return default(OPFBNMHKKMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x47E9590", Offset = "0x47E8190", VA = "0x1847E9590")]
	private void FNJEKJEHMEI(List<BEOIEFPIHPF> COEEIMIEFEF, Vector3[] NCFAGNKLGNG, Vector3[] HINHKAIAHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CAMKOEFKIOE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x47EB1C0", Offset = "0x47E9DC0", VA = "0x1847EB1C0")]
	public static Bounds FENOBFBCIKO(List<BEOIEFPIHPF> COEEIMIEFEF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x47EB370", Offset = "0x47E9F70", VA = "0x1847EB370")]
	public static int FKLOHFOBCBN(List<BEOIEFPIHPF> COEEIMIEFEF, NADLMEPLBLH HCCNHCAJIKB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DFGMDBOCCNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private JOMACKCFBMO GHAKODIHEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JOMACKCFBMO EAKMDIKFINI;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static JOMACKCFBMO KPPMHJJAOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private INEBHMJAMGL HPDAFKJMKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NONPADBMJOO MOJPAKJHKFI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle NHBMKIBCLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A40", Offset = "0x8F4640", VA = "0x1808F5A40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A60", Offset = "0x8F4660", VA = "0x1808F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CCDHHFJPHMC.KLDAGCANHNA EKDMHMCPOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EEEHCGBFEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C90", Offset = "0x7B2890", VA = "0x1807B3C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x47EDFD0", Offset = "0x47ECBD0", VA = "0x1847EDFD0")]
	[MLLBDNCHPEI(LJIBMCNOLHI.ExitingPlayMode, 0)]
	private void FFNIPJBLKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x47EE040", Offset = "0x47ECC40", VA = "0x1847EE040")]
	public void MMDAHEHGHKH(CCDHHFJPHMC.KLDAGCANHNA DGENBMKEINM, Transform AFJLPAFJGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47EEAA0", Offset = "0x47ED6A0", VA = "0x1847EEAA0")]
	public void PKLGGOJEOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47EDF60", Offset = "0x47ECB60", VA = "0x1847EDF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x47EEA60", Offset = "0x47ED660", VA = "0x1847EEA60")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47EF0B0", Offset = "0x47EDCB0", VA = "0x1847EF0B0")]
	public DFGMDBOCCNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OKGEDHMLDPC
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LPBPOBMEHEO EJBLHPLEINI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JHJAAACIFPA
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 DFMPJHPEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LNFHHANGIBM
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(JPHACOIJIFD BFLGJEJNJLD, CancellationToken NKLNCNDPFGD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DOPIMEHNIEO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOPIMEHNIEO FBGIHMOAFHD(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DOPIMEHNIEO CHIEBDAKCOM(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOPIMEHNIEO AKDLJLGGEMM(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOPIMEHNIEO LFJDFECOHFB(Action FHCMCNABNIM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class JBJDDKHFCJP : DOPIMEHNIEO
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class AIIEBDAEFKB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public JBJDDKHFCJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
				public AIIEBDAEFKB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x47E94B0", Offset = "0x47E80B0", VA = "0x1847E94B0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x47E9500", Offset = "0x47E8100", VA = "0x1847E9500")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x47E9550", Offset = "0x47E8150", VA = "0x1847E9550")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> NADPKHPMMOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action LNACBFLIPIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action EAMJPKNBHEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private LJJIPNJPNOC EDBBLFNFILJ;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action OJKHHBPLNAP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action AKAJINOIKCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x27EB250", Offset = "0x27E9E50", VA = "0x1827EB250", Slot = "4")]
			public DOPIMEHNIEO FBGIHMOAFHD(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6A00", Offset = "0x2CA5600", VA = "0x182CA6A00", Slot = "5")]
			public DOPIMEHNIEO CHIEBDAKCOM(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x24BDEB0", Offset = "0x24BCAB0", VA = "0x1824BDEB0", Slot = "6")]
			public DOPIMEHNIEO AKDLJLGGEMM(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2481AC0", Offset = "0x24806C0", VA = "0x182481AC0", Slot = "7")]
			public DOPIMEHNIEO LFJDFECOHFB(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
			public JBJDDKHFCJP(Func<JobHandle> HMNKFAEBJOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x47F2210", Offset = "0x47F0E10", VA = "0x1847F2210")]
			public void LOAMCCKKBNA(Action JMPGGAJOCOE, Action AHDKMCIPKHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x47F2440", Offset = "0x47F1040", VA = "0x1847F2440")]
			public void MAHLOMNJIKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JNAMHGPFNGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public DOPIMEHNIEO jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public JNAMHGPFNGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x47F2B10", Offset = "0x47F1710", VA = "0x1847F2B10")]
			internal bool <Remove>b__0(JBJDDKHFCJP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class FNBILKOAGLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JBJDDKHFCJP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public FNBILKOAGLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x47F2100", Offset = "0x47F0D00", VA = "0x1847F2100")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<JBJDDKHFCJP> JIDCLFGOKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<JBJDDKHFCJP> OPEGFOKJAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private ILEKNFOCKKN EKNOEKMAODC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PADPKJECKPP DNAFLKANKOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x47F2B20", Offset = "0x47F1720", VA = "0x1847F2B20")]
		public DOPIMEHNIEO Add(Func<JobHandle> HMNKFAEBJOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x47F2DC0", Offset = "0x47F19C0", VA = "0x1847F2DC0")]
		public void Remove(DOPIMEHNIEO NHBMKIBCLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x47F2C40", Offset = "0x47F1840", VA = "0x1847F2C40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x47F2F40", Offset = "0x47F1B40", VA = "0x1847F2F40")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x47F3110", Offset = "0x47F1D10", VA = "0x1847F3110")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x47F2C30", Offset = "0x47F1830", VA = "0x1847F2C30")]
		[CompilerGenerated]
		private void IBOKAHBEDJB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LJJIPNJPNOC
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LJJIPNJPNOC FBGIHMOAFHD(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LJJIPNJPNOC HAAEAOCMAGJ(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJJIPNJPNOC LFJDFECOHFB(Action FHCMCNABNIM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class OMJPPBPOGIO : LJJIPNJPNOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle MENNMPHNDCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action LNACBFLIPIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action EJJNMPNNOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action AKAJINOIKCO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MJFAJBLIEMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x47FB220", Offset = "0x47F9E20", VA = "0x1847FB220")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6A00", Offset = "0x2CA5600", VA = "0x182CA6A00", Slot = "4")]
			public LJJIPNJPNOC FBGIHMOAFHD(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x24BDEB0", Offset = "0x24BCAB0", VA = "0x1824BDEB0", Slot = "5")]
			public LJJIPNJPNOC HAAEAOCMAGJ(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2481AC0", Offset = "0x24806C0", VA = "0x182481AC0", Slot = "6")]
			public LJJIPNJPNOC LFJDFECOHFB(Action FHCMCNABNIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
			public OMJPPBPOGIO(JobHandle ENPHEKBFOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x47FB230", Offset = "0x47F9E30", VA = "0x1847FB230")]
			public void HLHCNOFHMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x47FB270", Offset = "0x47F9E70", VA = "0x1847FB270")]
			public void MAHLOMNJIKK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<OMJPPBPOGIO> AIBMGIHOINH;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47F3590", Offset = "0x47F2190", VA = "0x1847F3590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x47F31D0", Offset = "0x47F1DD0", VA = "0x1847F31D0")]
		public LJJIPNJPNOC Add(JobHandle ENPHEKBFOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x47F34A0", Offset = "0x47F20A0", VA = "0x1847F34A0")]
		public void Remove(LJJIPNJPNOC NHBMKIBCLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47F3340", Offset = "0x47F1F40", VA = "0x1847F3340", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x47F3260", Offset = "0x47F1E60", VA = "0x1847F3260")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x47F36A0", Offset = "0x47F22A0", VA = "0x1847F36A0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47F1E40", Offset = "0x47F0A40", VA = "0x1847F1E40")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47F1B10", Offset = "0x47F0710", VA = "0x1847F1B10")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
