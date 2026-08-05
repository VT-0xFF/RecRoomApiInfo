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
				[Cpp2IlInjected.Address(RVA = "0x53E2FE0", Offset = "0x53E1FE0", VA = "0x1853E2FE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x285F980", Offset = "0x285E980", VA = "0x18285F980")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x53E2FA0", Offset = "0x53E1FA0", VA = "0x1853E2FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53D8370", Offset = "0x53D7370", VA = "0x1853D8370")]
		public LODSettings ONCCJPMGDFI(CGGDHFKEBKC DGNFKMOFJKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x53D8250", Offset = "0x53D7250", VA = "0x1853D8250")]
		public int CBOPLEADMOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53D8270", Offset = "0x53D7270", VA = "0x1853D8270")]
		public int COELFJICIKO(bool AEHJFDGCOKF, Vector3 KPEBLIKEBJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53D8380", Offset = "0x53D7380", VA = "0x1853D8380")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MNLDIFCEPOD
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
public interface ONOJJMODHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIMLPJMNKJC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ENPPEGBNGFC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JFOJKMINJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<NIBOGNHEKFO> AHOLBIIMNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MNLDIFCEPOD OCDBLLAGPKO
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
	void UpdateClusterDistances(Vector3 IIICLIMCKNI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(JFMBPJDJAFM AFOPPLDIMJL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NIBOGNHEKFO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int KPIHMDMCLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int HNFGFOMDMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MEAKBEOKHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FJFIPKPHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte NOMAIOFLGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PPMPNDINBGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IOGDDEDCCMJ
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
	private struct JOEJNCNIJBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PPMPNDINBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GEKJCIHAMFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GEKJCIHAMFL <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x53E13F0", Offset = "0x53E03F0", VA = "0x1853E13F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFAOALHHFDL : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private BAGIJDLGAMA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PPMPNDINBGL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A200", VA = "0x18065B200")]
		[DebuggerHidden]
		public DFAOALHHFDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x53DA770", Offset = "0x53D9770", VA = "0x1853DA770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x53DA830", Offset = "0x53D9830", VA = "0x1853DA830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AOLDHCIFPJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PPMPNDINBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GEKJCIHAMFL worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GEKJCIHAMFL <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x53D4540", Offset = "0x53D3540", VA = "0x1853D4540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DFAICJPGNOH : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BAGIJDLGAMA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PPMPNDINBGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A200", VA = "0x18065B200")]
		[DebuggerHidden]
		public DFAICJPGNOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x53D9880", Offset = "0x53D8880", VA = "0x1853D9880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53DA730", Offset = "0x53D9730", VA = "0x1853DA730", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int KELNJAIJINL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan AEOENMALAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer GMNEIGBEPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LHAOKPNPAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject JMHOOJEBHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject MHPHDPODHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NBMPDKCFPKI BPGIFBJEGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JFMBPJDJAFM> EHHHGKMNGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JFMBPJDJAFM> GKJNADLEEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JFMBPJDJAFM> DGKNGPPNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KEEBGJDGDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IOGDDEDCCMJ MOLIKEJBOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<ENPPEGBNGFC>[] JNCABKGDCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<NIBOGNHEKFO>[] GECMFMHOJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource GOMHDICLLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool EKBMBLPABCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private FCEDOONPEIE HHHOAJACJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private FCEDOONPEIE AFEDMOEDNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NFMKCEFJBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MGJGINJPKHG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static PPMPNDINBGL BMDIGDOKCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BLMMCDNAABO CKIOHIIIABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HLNJDIMPPAN GLEMLNFFILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour GCOHCEPGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material MOOAOAKPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<ONOJJMODHGP> PDOBMLFOJLL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig HHFLGHDJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HIAEMPNFLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x111AF10", Offset = "0x1119F10", VA = "0x18111AF10")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x111AE40", Offset = "0x1119E40", VA = "0x18111AE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IOGDDEDCCMJ NIFNHEDGACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C7580", Offset = "0x7C6580", VA = "0x1807C7580")]
		get
		{
			return default(IOGDDEDCCMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53E57D0", Offset = "0x53E47D0", VA = "0x1853E57D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PPMPNDINBGL JNHMLOILMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53E47E0", Offset = "0x53E37E0", VA = "0x1853E47E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KKECDAMHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x53E60B0", Offset = "0x53E50B0", VA = "0x1853E60B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OPGIMIDFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x53E4F30", Offset = "0x53E3F30", VA = "0x1853E4F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IFIHAIHIMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53E4640", Offset = "0x53E3640", VA = "0x1853E4640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53E4C10", Offset = "0x53E3C10", VA = "0x1853E4C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AEDEMAFPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x53E41D0", Offset = "0x53E31D0", VA = "0x1853E41D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x53E4270", Offset = "0x53E3270", VA = "0x1853E4270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53E6780", Offset = "0x53E5780", VA = "0x1853E6780")]
	public PPMPNDINBGL(BLMMCDNAABO CKIOHIIIABP, HLNJDIMPPAN GLEMLNFFILJ, ClusterLODConfig GCHMJLBIADO, MonoBehaviour GCOHCEPGNMC, Material MOOAOAKPGCG, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53E46E0", Offset = "0x53E36E0", VA = "0x1853E46E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x53E44B0", Offset = "0x53E34B0", VA = "0x1853E44B0")]
	public static void CFCNOFJDCFB(Vector3 BGDAGCBCEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53E5090", Offset = "0x53E4090", VA = "0x1853E5090")]
	private void GIFLPEPGKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53E4990", Offset = "0x53E3990", VA = "0x1853E4990")]
	private void FGLJAKKFDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53E65C0", Offset = "0x53E55C0", VA = "0x1853E65C0")]
	private void PLAMDGNIGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53E59B0", Offset = "0x53E49B0", VA = "0x1853E59B0")]
	public void LJBGENFHGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53E5F10", Offset = "0x53E4F10", VA = "0x1853E5F10")]
	[AsyncStateMachine(typeof(JOEJNCNIJBE))]
	public Task LPGBBBMJCDC(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x53E4920", Offset = "0x53E3920", VA = "0x1853E4920")]
	[IteratorStateMachine(typeof(DFAOALHHFDL))]
	private IEnumerator<BAGIJDLGAMA> FGKJLEBLAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53E4050", Offset = "0x53E3050", VA = "0x1853E4050")]
	[AsyncStateMachine(typeof(AOLDHCIFPJE))]
	private Task APMDJANFFKE(GEKJCIHAMFL JJCKJNKLCDF, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x53E61D0", Offset = "0x53E51D0", VA = "0x1853E61D0")]
	public void MPFKIAFLJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53E4840", Offset = "0x53E3840", VA = "0x1853E4840")]
	public void EPCJCCEMCAO(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53E4CB0", Offset = "0x53E3CB0", VA = "0x1853E4CB0")]
	public void GADJKILMDDL(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53E5120", Offset = "0x53E4120", VA = "0x1853E5120")]
	public List<ClusterMeshRenderer> IDEMEFJOCCN(List<JFMBPJDJAFM> CGPLPFBCOHF, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x53E5900", Offset = "0x53E4900", VA = "0x1853E5900")]
	public MNLDIFCEPOD JLPIEOHGHJP(Vector3 CFBKBGDCIDC)
	{
		return default(MNLDIFCEPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53E45E0", Offset = "0x53E35E0", VA = "0x1853E45E0")]
	public void CNMNPPJAPMI(ONOJJMODHGP MLPIPNJOOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53E48C0", Offset = "0x53E38C0", VA = "0x1853E48C0")]
	public bool FEOPJLGKLJI(ONOJJMODHGP MLPIPNJOOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x53E6050", Offset = "0x53E5050", VA = "0x1853E6050")]
	public void MGMBJJFHGOO(JFMBPJDJAFM OLBGDPICDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x53E63E0", Offset = "0x53E53E0", VA = "0x1853E63E0")]
	public void OEHBIIIMNPL(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53E5010", Offset = "0x53E4010", VA = "0x1853E5010")]
	public void GIFFBNAFKGA(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53E6460", Offset = "0x53E5460", VA = "0x1853E6460")]
	private void PILMOAJPMEM(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53E4350", Offset = "0x53E3350", VA = "0x1853E4350")]
	private void CEIBJMHEGLC(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53E5940", Offset = "0x53E4940", VA = "0x1853E5940")]
	[IteratorStateMachine(typeof(DFAICJPGNOH))]
	private IEnumerator<BAGIJDLGAMA> KICLFMKCLOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53E4A90", Offset = "0x53E3A90", VA = "0x1853E4A90")]
	private int FLHEMFEHOBJ(int AIPHGHFENPJ, int ONOCCOAMFKO, List<NIBOGNHEKFO> CEJCAHHAFHP, byte DGNFKMOFJKN, ref int KKKMAGCLIPP, float KDBDFGHPFJB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53E3E70", Offset = "0x53E2E70", VA = "0x1853E3E70")]
	public void AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53E4190", Offset = "0x53E3190", VA = "0x1853E4190")]
	public bool BJOKBEFEBOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70F7A0", Offset = "0x70E7A0", VA = "0x18070F7A0")]
	public Material AJPGIBPKJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53E4310", Offset = "0x53E3310", VA = "0x1853E4310")]
	public int CBOPLEADMOF()
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
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct IOIJHPDKJKI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> DECFNMEHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> CEPDKBDJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> LNIEPIKFBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> JNPEGOCJNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> PDIGEELCHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> LGLGGCHFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> KDKPCJLGNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 FNLBICJDFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float PGMHGDGHIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> NNOGLEDMIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> MOPFOKHFBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x53DFEB0", Offset = "0x53DEEB0", VA = "0x1853DFEB0")]
	public IOIJHPDKJKI(FGBHHFNILHF CNMNFNJMBFD, NativeList<float3> KDKPCJLGNBL, NativeMultiHashMap<int, int> NNOGLEDMIBH, NativeArray<int> MOPFOKHFBHJ, Vector3 FNLBICJDFML, float PGMHGDGHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53DFC20", Offset = "0x53DEC20", VA = "0x1853DFC20")]
	private int JNJPEGIJBON(float3 IIICLIMCKNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53DFC50", Offset = "0x53DEC50", VA = "0x1853DFC50")]
	private int KEIIDFEKHLL(int HLAPKJLCEDC, int CCJNKBLKLDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53DF7F0", Offset = "0x53DE7F0", VA = "0x1853DF7F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DLKNINADEHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> NNOGLEDMIBH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> MOPFOKHFBHJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int LEEIGIEEJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> BCJAGLHBKAK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x53DA870", Offset = "0x53D9870", VA = "0x1853DA870")]
	public void DMMGPPBKIAO(int FKLMDLIDEAH, Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x53DAA60", Offset = "0x53D9A60", VA = "0x1853DAA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public DLKNINADEHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct OIADKKHLPHB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> HHDCDKOHPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> CBOLKBNHHCD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x53E3D60", Offset = "0x53E2D60", VA = "0x1853E3D60")]
	public OIADKKHLPHB(DLKNINADEHI CCEOBMFDMFH, FGBHHFNILHF CNMNFNJMBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x53E3CC0", Offset = "0x53E2CC0", VA = "0x1853E3CC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EECDGBECFPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> LLNGCFCJNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> DPGHOFEJMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> NNIJMHHHFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> MBEGLICLJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> OOBBLBGABIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> BCJAGLHBKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> HHDCDKOHPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> OLFKLNGLPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> GBHANPFHDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> KFCOJCNDLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> MGCFHEKCEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> GDHAAFBPMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> HNNOEGOMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float GPLCMCDDBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float IFJMLFJJCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 AFNNDEBMLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float EEEOBGDBMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float CEFMLLHODCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float JEIPODGPOFH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x53DC0F0", Offset = "0x53DB0F0", VA = "0x1853DC0F0")]
	public EECDGBECFPI(DLKNINADEHI HMCICNELNAM, FGBHHFNILHF CNMNFNJMBFD, FGBHHFNILHF HJLHJNHHBNA, float CEFMLLHODCP, float JEIPODGPOFH, Vector3 AFNNDEBMLKF, float EEEOBGDBMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x53DAB40", Offset = "0x53D9B40", VA = "0x1853DAB40")]
	private float3 AEHMEHEKDMC(int HLAPKJLCEDC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x53DB860", Offset = "0x53DA860", VA = "0x1853DB860")]
	private void JMGCMPCDGNO(int HLAPKJLCEDC, out float3 GKJKMOCOPFE, out float3 KPCDPOHPDFE, out float4 FPKHNCCKGID, out float4 EFEHKAEGEEH, out float2 GPBHALELLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x53DBA50", Offset = "0x53DAA50", VA = "0x1853DBA50")]
	private int LCDHGKOOBPK(int APPCCKBGOII, int LHLGBGAHAKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x53DBEE0", Offset = "0x53DAEE0", VA = "0x1853DBEE0")]
	private void OJCCCALBIKK(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x53DBD50", Offset = "0x53DAD50", VA = "0x1853DBD50")]
	private bool LDHAAHBPKEM(int APPCCKBGOII, int LHLGBGAHAKE, float FHLEEHEDPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x53DAC10", Offset = "0x53D9C10", VA = "0x1853DAC10")]
	private bool BMLHPMBIDEM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53DB5F0", Offset = "0x53DA5F0", VA = "0x1853DB5F0")]
	private bool HIPPNHGJAOM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53DABF0", Offset = "0x53D9BF0", VA = "0x1853DABF0")]
	private void BALFJGMOAOL(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, out int NJMJEIHLCLB, out int DCDOLBCKJLC, out int ABFLGOLLPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53DACD0", Offset = "0x53D9CD0", VA = "0x1853DACD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FNEBCJPGPMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BLGBIPNKHEJ : IDisposable, NIBOGNHEKFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds HEICMLFEKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<JFMBPJDJAFM> CGPLPFBCOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 PBBKLJFIGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 NGIKLNFMBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int KJCEDFPPJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FGBHHFNILHF GEKEEGCFHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DLKNINADEHI KLBEMFCJJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform KOJLKBNIDFO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int CAJGLCBKCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x53D5900", Offset = "0x53D4900", VA = "0x1853D5900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MLPDFDKPDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh KBGHCPOECPM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MEAKBEOKHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1178410", Offset = "0x1177410", VA = "0x181178410", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2C9A1D0", Offset = "0x2C991D0", VA = "0x182C9A1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte NOMAIOFLGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F2540", Offset = "0x9F1540", VA = "0x1809F2540")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F26E0", Offset = "0x9F16E0", VA = "0x1809F26E0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int KPIHMDMCLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA8AA40", Offset = "0xA89A40", VA = "0x180A8AA40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA8AA50", Offset = "0xA89A50", VA = "0x180A8AA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HNFGFOMDMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCADDC0", Offset = "0xCACDC0", VA = "0x180CADDC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xF3DC80", Offset = "0xF3CC80", VA = "0x180F3DC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FJFIPKPHDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x53D5C10", Offset = "0x53D4C10", VA = "0x1853D5C10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53D59E0", Offset = "0x53D49E0", VA = "0x1853D59E0")]
		public void CLDLFPLFAHM(CGGDHFKEBKC DGNFKMOFJKN, out int CFACGPLLKDB, out int GGNOLAIGBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x53D6270", Offset = "0x53D5270", VA = "0x1853D6270")]
		public void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x53D5ED0", Offset = "0x53D4ED0", VA = "0x1853D5ED0")]
		public void IIHMEABPEHE(NativeList<MLCJACEFBLD> NDCEJJOGNFL, Transform NDBKEODDPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53D5E30", Offset = "0x53D4E30", VA = "0x1853D5E30")]
		public void GNOJCFCOIJI(Mesh CNMNFNJMBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53D5940", Offset = "0x53D4940", VA = "0x1853D5940")]
		public void AJAHKDEJBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53D5C30", Offset = "0x53D4C30", VA = "0x1853D5C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53D6420", Offset = "0x53D5420", VA = "0x1853D6420")]
		public BLGBIPNKHEJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds HEICMLFEKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<BLGBIPNKHEJ> FEHOHOKDMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GKJKAAOLDLO BDJFFCJPFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer CJJNIEGEMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int NEGNJCJNJOL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh IHNGPENLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KEHAJFJKABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x656030", VA = "0x180657030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80D230", Offset = "0x80C230", VA = "0x18080D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JFOJKMINJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x53DCCA0", Offset = "0x53DBCA0", VA = "0x1853DCCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53DC950", Offset = "0x53DB950", VA = "0x1853DC950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53DCAB0", Offset = "0x53DBAB0", VA = "0x1853DCAB0")]
	public int ELAFGBAHCHA(int EFLIDGHBHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53DD4C0", Offset = "0x53DC4C0", VA = "0x1853DD4C0")]
	public void PBFKLMNICPH(KNNLAILFLCP GKAOPIFDKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x53DCCF0", Offset = "0x53DBCF0", VA = "0x1853DCCF0")]
	public void KAEHGBKBFGC(Transform NDBKEODDPAJ, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x53DCAE0", Offset = "0x53DBAE0", VA = "0x1853DCAE0")]
	public bool EOMGMBAOBOC(bool KHJDMAGGLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x53DC500", Offset = "0x53DB500", VA = "0x1853DC500")]
	public void CDANDPBOAKH(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x53DC250", Offset = "0x53DB250", VA = "0x1853DC250")]
	public bool AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x53DD680", Offset = "0x53DC680", VA = "0x1853DD680")]
	public FNEBCJPGPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NBMPDKCFPKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<FNEBCJPGPMH.BLGBIPNKHEJ> EEJDAGHEMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JDHIKPJLGJD IJAKDICGHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<FNEBCJPGPMH.BLGBIPNKHEJ> JAIAOFGJIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int IHGCEPJHEMA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53E31F0", Offset = "0x53E21F0", VA = "0x1853E31F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53E3420", Offset = "0x53E2420", VA = "0x1853E3420")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53E3360", Offset = "0x53E2360", VA = "0x1853E3360")]
	public void HEFJCCLOLGO(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI, Transform KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53E3000", Offset = "0x53E2000", VA = "0x1853E3000")]
	public void AKJLIPOIGHF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53E37C0", Offset = "0x53E27C0", VA = "0x1853E37C0")]
	private FNEBCJPGPMH.BLGBIPNKHEJ NBLDEDPIFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x53E32C0", Offset = "0x53E22C0", VA = "0x1853E32C0")]
	private bool GCELBBBNPCP(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53E3260", Offset = "0x53E2260", VA = "0x1853E3260")]
	private void FJLNKCGLBMH(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53E3790", Offset = "0x53E2790", VA = "0x1853E3790")]
	public bool MAKGMJGMKPF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53E34A0", Offset = "0x53E24A0", VA = "0x1853E34A0")]
	public bool JBCFLHJDAGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53E3730", Offset = "0x53E2730", VA = "0x1853E3730")]
	private FNEBCJPGPMH.BLGBIPNKHEJ JFCMIFMOANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53E38F0", Offset = "0x53E28F0", VA = "0x1853E38F0")]
	public NBMPDKCFPKI()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HAGCNGENHMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int ILBKEOIDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int LGNAOBEIPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float GMKOJGMDMFG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<FNEBCJPGPMH> LAOEHKFGOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53DF240", Offset = "0x53DE240", VA = "0x1853DF240")]
	public HAGCNGENHMK(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53DEE40", Offset = "0x53DDE40", VA = "0x1853DEE40")]
	public void ICLLJOENCKL(JCNKMAEMAOG HDKPGLAOJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53DF1A0", Offset = "0x53DE1A0", VA = "0x1853DF1A0")]
	private int INFBIJMJHDB(KNNLAILFLCP MKLEFAMNJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53DEF60", Offset = "0x53DDF60", VA = "0x1853DEF60")]
	private void ICLLJOENCKL(KNNLAILFLCP MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53DEC30", Offset = "0x53DDC30", VA = "0x1853DEC30")]
	private void GJHPIDMGBFC(KNNLAILFLCP MKLEFAMNJAC, FNEBCJPGPMH OKLBECNKPPD)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ENPPEGBNGFC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NPMFDKGDGLH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
			[DebuggerHidden]
			public NPMFDKGDGLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x53E3A70", Offset = "0x53E2A70", VA = "0x1853E3A70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x53E3C20", Offset = "0x53E2C20", VA = "0x1853E3C20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x53E3B80", Offset = "0x53E2B80", VA = "0x1853E3B80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x53E3B80", Offset = "0x53E2B80", VA = "0x1853E3B80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JFOJKMINJDP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x53D9820", Offset = "0x53D8820", VA = "0x1853D9820", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<NIBOGNHEKFO> AHOLBIIMNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x53D9800", Offset = "0x53D8800", VA = "0x1853D9800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> FEHOHOKDMBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FNEBCJPGPMH IHNGPENLHJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MNLDIFCEPOD OCDBLLAGPKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6791B0", Offset = "0x6781B0", VA = "0x1806791B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MNLDIFCEPOD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8278B0", Offset = "0x8268B0", VA = "0x1808278B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GEHCEJHHGCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x53D9810", Offset = "0x53D8810", VA = "0x1853D9810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53D83E0", Offset = "0x53D73E0", VA = "0x1853D83E0")]
		public static ClusterMeshRenderer Create(FNEBCJPGPMH CNMNFNJMBFD, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x53D8580", Offset = "0x53D7580", VA = "0x1853D8580", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x53D8D40", Offset = "0x53D7D40", VA = "0x1853D8D40", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x53D8B30", Offset = "0x53D7B30", VA = "0x1853D8B30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53D87D0", Offset = "0x53D77D0", VA = "0x1853D87D0")]
		public void Init(FNEBCJPGPMH CNMNFNJMBFD, MeshFilter LHAOKPNPAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53D85E0", Offset = "0x53D75E0", VA = "0x1853D85E0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53D8E70", Offset = "0x53D7E70", VA = "0x1853D8E70", Slot = "8")]
		public void UpdateClusterDistances(Vector3 IIICLIMCKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x53D9080", Offset = "0x53D8080", VA = "0x1853D9080", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53D8760", Offset = "0x53D7760", VA = "0x1853D8760")]
		[IteratorStateMachine(typeof(NPMFDKGDGLH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53D8BB0", Offset = "0x53D7BB0", VA = "0x1853D8BB0")]
		public void SetupTagAndLayer(string BGDAFDMFHHK, int BPACBAKLDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53D8B90", Offset = "0x53D7B90", VA = "0x1853D8B90")]
		public bool Remove(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FMHJHMGOGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int CLFJNDDNFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int HMJFOJBNOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GGNOLAIGBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CFACGPLLKDB;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x53DC230", Offset = "0x53DB230", VA = "0x1853DC230")]
	public FMHJHMGOGCB(int HMJFOJBNOAJ, int GGNOLAIGBCC, int CLFJNDDNFLF, int CFACGPLLKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GKJKAAOLDLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> DECFNMEHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> BCJAGLHBKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> LGLGGCHFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<FMHJHMGOGCB> OHDDMIOPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> EKOCFGLPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> GDOMBHGCMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> DIOONOKOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle AADBABLKHJM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KCEMFBBKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC49820", Offset = "0xC48820", VA = "0x180C49820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC49DC0", Offset = "0xC48DC0", VA = "0x180C49DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x53DD840", Offset = "0x53DC840", VA = "0x1853DD840")]
	public void ENJHCNHMIBP(FGBHHFNILHF OCMDDHDAFCO, NativeList<FMHJHMGOGCB> OHDDMIOPOFC, float AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x53DE940", Offset = "0x53DD940", VA = "0x1853DE940")]
	public void NEGHPKDPNDJ(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53DE760", Offset = "0x53DD760", VA = "0x1853DE760")]
	public void EOMGMBAOBOC(FNEBCJPGPMH CJJNIEGEMMA, bool KHJDMAGGLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53DD730", Offset = "0x53DC730", VA = "0x1853DD730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53DE910", Offset = "0x53DD910", VA = "0x1853DE910")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public GKJKAAOLDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HGIDGIHFPOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> DECFNMEHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> BCJAGLHBKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<FMHJHMGOGCB> COIDFMJFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> EKOCFGLPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 AFNNDEBMLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> GDOMBHGCMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> DIOONOKOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool EHHGKBMMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float OAODHMADCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float PIBFPOEDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float OADCCHBMLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> LGLGGCHFNDI;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x53DF720", Offset = "0x53DE720", VA = "0x1853DF720")]
	public HGIDGIHFPOK(GKJKAAOLDLO LPGHNKKMKEB, Vector3 AFNNDEBMLKF, bool EHHGKBMMEII, float OAODHMADCFM, float PIBFPOEDNHF, float OADCCHBMLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x53DF290", Offset = "0x53DE290", VA = "0x1853DF290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JFMBPJDJAFM : ACBOCPDLAKE
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds KNBIEKJPLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MLCJACEFBLD CPFBDCCLABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNNLAILFLCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<JFMBPJDJAFM> CGPLPFBCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public KNNLAILFLCP ADECAOLBLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public KNNLAILFLCP EPPMELOKDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public KNNLAILFLCP CEKCNHNIAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int CFACGPLLKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds HEICMLFEKLH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53E27C0", Offset = "0x53E17C0", VA = "0x1853E27C0")]
	public KNNLAILFLCP(List<JFMBPJDJAFM> CGPLPFBCOHF, [Optional] KNNLAILFLCP ADECAOLBLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JCNKMAEMAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<KNNLAILFLCP> ABAKABKGNHK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KNNLAILFLCP BPBHOPDAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53DFF70", Offset = "0x53DEF70", VA = "0x1853DFF70")]
	public JCNKMAEMAOG(KNNLAILFLCP KOJLKBNIDFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CCPGCDPEANE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MHELBLBNBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int OKGFMHEEMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int JFHKIFKEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int GOGOEKOLGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int FIMICJBBFMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AGHHFJMDKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int HEDLEMMNFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float CPGHOFAOOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<JFMBPJDJAFM> CGPLPFBCOHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum ONGALEILGHJ
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
	private MHELBLBNBCP BBHPLJENOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int HFLIKIFLLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int ILBKEOIDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int LGNAOBEIPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float JDHBIIJBDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float PCPAPMPBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<KNNLAILFLCP> FPBGOPHIPFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JCNKMAEMAOG LIAPEOMCPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x53D81F0", Offset = "0x53D71F0", VA = "0x1853D81F0")]
	public CCPGCDPEANE(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ, int HFLIKIFLLNK, float PCPAPMPBGEH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x53D6660", Offset = "0x53D5660", VA = "0x1853D6660")]
	public void FNDFGCKGBNC(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x53D6860", Offset = "0x53D5860", VA = "0x1853D6860")]
	public bool IKJFIIAMCPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x53D6590", Offset = "0x53D5590", VA = "0x1853D6590")]
	private float BOAMHLOODOF(Vector3 OCIAEJCLHLN, Vector3 GEOHKIDILGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x53D6610", Offset = "0x53D5610", VA = "0x1853D6610")]
	private float BOAMHLOODOF(Vector3 MNKEEJPGFOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x53D7960", Offset = "0x53D6960", VA = "0x1853D7960")]
	private bool PMCDPKPFOAK(KNNLAILFLCP LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x53D68D0", Offset = "0x53D58D0", VA = "0x1853D68D0")]
	private AGHHFJMDKDL KDNANFFAHAJ(List<JFMBPJDJAFM> KKPMAABHOAI, ONGALEILGHJ HJNJLJOJBPP)
	{
		return default(AGHHFJMDKDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x53D7500", Offset = "0x53D6500", VA = "0x1853D7500")]
	private void KGLNHFKOCGL(List<JFMBPJDJAFM> CGPLPFBCOHF, Vector3[] JLHJPBEGJFM, Vector3[] HKPLKDEHPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class LODAEEMPCPF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53E2C40", Offset = "0x53E1C40", VA = "0x1853E2C40")]
	public static Bounds IEFIBHHGJDK(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53E2DF0", Offset = "0x53E1DF0", VA = "0x1853E2DF0")]
	public static int PFCGMANFCAA(List<JFMBPJDJAFM> CGPLPFBCOHF, CGGDHFKEBKC DGNFKMOFJKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JDHIKPJLGJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FGBHHFNILHF OEFKNEJMKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FGBHHFNILHF GAJFPFIGAFG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FGBHHFNILHF BFMEPECGGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MLMPDAMNLAG IGBCGCLOAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LPHIFDNBAIG FINKDHKFDHL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle AADBABLKHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xD92910", Offset = "0xD91910", VA = "0x180D92910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GHLPPBBPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF580", Offset = "0x6EE580", VA = "0x1806EF580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53E12A0", Offset = "0x53E02A0", VA = "0x1853E12A0")]
	[CCHBFIAMMOL(HBPLHMNGKEN.ExitingPlayMode, 0)]
	private void HJAMABMPGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53E07A0", Offset = "0x53DF7A0", VA = "0x1853E07A0")]
	public void ENJHCNHMIBP(FNEBCJPGPMH.BLGBIPNKHEJ COIDFMJFENC, Transform HPNHPIKEOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x53E0040", Offset = "0x53DF040", VA = "0x1853E0040")]
	public void BLICBNHGCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x53E0730", Offset = "0x53DF730", VA = "0x1853E0730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x53E1310", Offset = "0x53E0310", VA = "0x1853E1310")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53E1350", Offset = "0x53E0350", VA = "0x1853E1350")]
	public JDHIKPJLGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AEDKNBDOGKM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PPMPNDINBGL CBEBHMGBCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HLNJDIMPPAN
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 DGCGPPDGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BLMMCDNAABO
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GEKJCIHAMFL JJCKJNKLCDF, CancellationToken GPNLCIOKAPO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BCFLAMMDJKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCFLAMMDJKJ BMODNLGJOBH(Action CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BCFLAMMDJKJ APBNFNNEFDH(Action CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BCFLAMMDJKJ NKMOFLPAHKE(Action CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCFLAMMDJKJ LANCIGKNPBK(Action CGKOOFFNHKL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class LMMKPGCDAGL : BCFLAMMDJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PMJBNIICBOE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public LMMKPGCDAGL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
				public PMJBNIICBOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x53E3D90", Offset = "0x53E2D90", VA = "0x1853E3D90")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x53E3DE0", Offset = "0x53E2DE0", VA = "0x1853E3DE0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x53E3E30", Offset = "0x53E2E30", VA = "0x1853E3E30")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> GEHEDDCGMEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action GGIONMOPAKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action OFPCOCKLGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private AICNMMJCFDP EOKJFJEMEMA;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action LONFADEPCJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NBBFNJAIIDK
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2456B00", Offset = "0x2455B00", VA = "0x182456B00", Slot = "4")]
			public BCFLAMMDJKJ BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2414190", Offset = "0x2413190", VA = "0x182414190", Slot = "5")]
			public BCFLAMMDJKJ APBNFNNEFDH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x24141B0", Offset = "0x24131B0", VA = "0x1824141B0", Slot = "6")]
			public BCFLAMMDJKJ NKMOFLPAHKE(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x381E630", Offset = "0x381D630", VA = "0x18381E630", Slot = "7")]
			public BCFLAMMDJKJ LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
			public LMMKPGCDAGL(Func<JobHandle> DMNBCEFJPHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x53E29B0", Offset = "0x53E19B0", VA = "0x1853E29B0")]
			public void LCBCKFDJBHE(Action APMKJOOLPLF, Action KOMLGNFIAAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x53E2840", Offset = "0x53E1840", VA = "0x1853E2840")]
			public void AKJLIPOIGHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JPMABLCBMIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public BCFLAMMDJKJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public JPMABLCBMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x53E19D0", Offset = "0x53E09D0", VA = "0x1853E19D0")]
			internal bool <Remove>b__0(LMMKPGCDAGL a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class OBNHJGEPNKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public LMMKPGCDAGL newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public OBNHJGEPNKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x53E3C60", Offset = "0x53E2C60", VA = "0x1853E3C60")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<LMMKPGCDAGL> IIFIPBEDGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<LMMKPGCDAGL> NJLGPPMILEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private FCEDOONPEIE HJPAJFPPCCP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public BLGHKDJHNPF GACHEHPMOGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x53E19E0", Offset = "0x53E09E0", VA = "0x1853E19E0")]
		public BCFLAMMDJKJ Add(Func<JobHandle> DMNBCEFJPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x53E1CE0", Offset = "0x53E0CE0", VA = "0x1853E1CE0")]
		public void Remove(BCFLAMMDJKJ AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x53E1B40", Offset = "0x53E0B40", VA = "0x1853E1B40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x53E1EB0", Offset = "0x53E0EB0", VA = "0x1853E1EB0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53E2100", Offset = "0x53E1100", VA = "0x1853E2100")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53E1B30", Offset = "0x53E0B30", VA = "0x1853E1B30")]
		[CompilerGenerated]
		private void CECNKJDLNCO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AICNMMJCFDP
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AICNMMJCFDP BMODNLGJOBH(Action CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AICNMMJCFDP LNCBNLCAPGF(Action CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AICNMMJCFDP LANCIGKNPBK(Action CGKOOFFNHKL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BPEBFGCKOHK : AICNMMJCFDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle DCOHPMBNAOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action GGIONMOPAKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action EGMBCEFPMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action NBBFNJAIIDK;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MAFLJCDFJLF
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x53D6580", Offset = "0x53D5580", VA = "0x1853D6580")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2414190", Offset = "0x2413190", VA = "0x182414190", Slot = "4")]
			public AICNMMJCFDP BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x24141B0", Offset = "0x24131B0", VA = "0x1824141B0", Slot = "5")]
			public AICNMMJCFDP LNCBNLCAPGF(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x381E630", Offset = "0x381D630", VA = "0x18381E630", Slot = "6")]
			public AICNMMJCFDP LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
			public BPEBFGCKOHK(JobHandle HGFNJFOEEBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x53D6540", Offset = "0x53D5540", VA = "0x1853D6540")]
			public void NBKICENBLEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x53D6500", Offset = "0x53D5500", VA = "0x1853D6500")]
			public void AKJLIPOIGHF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BPEBFGCKOHK> KIHPHCBPKIO;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53E25E0", Offset = "0x53E15E0", VA = "0x1853E25E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53E2200", Offset = "0x53E1200", VA = "0x1853E2200")]
		public AICNMMJCFDP Add(JobHandle HGFNJFOEEBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53E24F0", Offset = "0x53E14F0", VA = "0x1853E24F0")]
		public void Remove(AICNMMJCFDP AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x53E2380", Offset = "0x53E1380", VA = "0x1853E2380", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x53E2290", Offset = "0x53E1290", VA = "0x1853E2290")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53E2700", Offset = "0x53E1700", VA = "0x1853E2700")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53D3F10", Offset = "0x53D2F10", VA = "0x1853D3F10")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x53D4020", Offset = "0x53D3020", VA = "0x1853D4020")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
