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
				[Cpp2IlInjected.Address(RVA = "0x538BDE0", Offset = "0x538ABE0", VA = "0x18538BDE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x2547CD0", Offset = "0x2546AD0", VA = "0x182547CD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x538BDA0", Offset = "0x538ABA0", VA = "0x18538BDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5381170", Offset = "0x537FF70", VA = "0x185381170")]
		public LODSettings ONCCJPMGDFI(CGGDHFKEBKC DGNFKMOFJKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5381050", Offset = "0x537FE50", VA = "0x185381050")]
		public int CBOPLEADMOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5381070", Offset = "0x537FE70", VA = "0x185381070")]
		public int COELFJICIKO(bool AEHJFDGCOKF, Vector3 KPEBLIKEBJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5381180", Offset = "0x537FF80", VA = "0x185381180")]
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
		[Cpp2IlInjected.Address(RVA = "0x538A1F0", Offset = "0x5388FF0", VA = "0x18538A1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
		[DebuggerHidden]
		public DFAOALHHFDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5383570", Offset = "0x5382370", VA = "0x185383570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5383630", Offset = "0x5382430", VA = "0x185383630", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x537D340", Offset = "0x537C140", VA = "0x18537D340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
		[DebuggerHidden]
		public DFAICJPGNOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5382680", Offset = "0x5381480", VA = "0x185382680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5383530", Offset = "0x5382330", VA = "0x185383530", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HIAEMPNFLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDFFE90", Offset = "0xDFEC90", VA = "0x180DFFE90")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDFFDC0", Offset = "0xDFEBC0", VA = "0x180DFFDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IOGDDEDCCMJ NIFNHEDGACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E7720", Offset = "0x6E6520", VA = "0x1806E7720")]
		get
		{
			return default(IOGDDEDCCMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x538E5D0", Offset = "0x538D3D0", VA = "0x18538E5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PPMPNDINBGL JNHMLOILMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x538D5E0", Offset = "0x538C3E0", VA = "0x18538D5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KKECDAMHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x538EEB0", Offset = "0x538DCB0", VA = "0x18538EEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OPGIMIDFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x538DD30", Offset = "0x538CB30", VA = "0x18538DD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IFIHAIHIMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x538D440", Offset = "0x538C240", VA = "0x18538D440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x538DA10", Offset = "0x538C810", VA = "0x18538DA10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AEDEMAFPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x538CFD0", Offset = "0x538BDD0", VA = "0x18538CFD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x538D070", Offset = "0x538BE70", VA = "0x18538D070")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x538F580", Offset = "0x538E380", VA = "0x18538F580")]
	public PPMPNDINBGL(BLMMCDNAABO CKIOHIIIABP, HLNJDIMPPAN GLEMLNFFILJ, ClusterLODConfig GCHMJLBIADO, MonoBehaviour GCOHCEPGNMC, Material MOOAOAKPGCG, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x538D4E0", Offset = "0x538C2E0", VA = "0x18538D4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x538D2B0", Offset = "0x538C0B0", VA = "0x18538D2B0")]
	public static void CFCNOFJDCFB(Vector3 BGDAGCBCEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x538DE90", Offset = "0x538CC90", VA = "0x18538DE90")]
	private void GIFLPEPGKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x538D790", Offset = "0x538C590", VA = "0x18538D790")]
	private void FGLJAKKFDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x538F3C0", Offset = "0x538E1C0", VA = "0x18538F3C0")]
	private void PLAMDGNIGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x538E7B0", Offset = "0x538D5B0", VA = "0x18538E7B0")]
	public void LJBGENFHGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x538ED10", Offset = "0x538DB10", VA = "0x18538ED10")]
	[AsyncStateMachine(typeof(JOEJNCNIJBE))]
	public Task LPGBBBMJCDC(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x538D720", Offset = "0x538C520", VA = "0x18538D720")]
	[IteratorStateMachine(typeof(DFAOALHHFDL))]
	private IEnumerator<BAGIJDLGAMA> FGKJLEBLAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x538CE50", Offset = "0x538BC50", VA = "0x18538CE50")]
	[AsyncStateMachine(typeof(AOLDHCIFPJE))]
	private Task APMDJANFFKE(GEKJCIHAMFL JJCKJNKLCDF, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x538EFD0", Offset = "0x538DDD0", VA = "0x18538EFD0")]
	public void MPFKIAFLJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x538D640", Offset = "0x538C440", VA = "0x18538D640")]
	public void EPCJCCEMCAO(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x538DAB0", Offset = "0x538C8B0", VA = "0x18538DAB0")]
	public void GADJKILMDDL(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x538DF20", Offset = "0x538CD20", VA = "0x18538DF20")]
	public List<ClusterMeshRenderer> IDEMEFJOCCN(List<JFMBPJDJAFM> CGPLPFBCOHF, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x538E700", Offset = "0x538D500", VA = "0x18538E700")]
	public MNLDIFCEPOD JLPIEOHGHJP(Vector3 CFBKBGDCIDC)
	{
		return default(MNLDIFCEPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x538D3E0", Offset = "0x538C1E0", VA = "0x18538D3E0")]
	public void CNMNPPJAPMI(ONOJJMODHGP MLPIPNJOOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x538D6C0", Offset = "0x538C4C0", VA = "0x18538D6C0")]
	public bool FEOPJLGKLJI(ONOJJMODHGP MLPIPNJOOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x538EE50", Offset = "0x538DC50", VA = "0x18538EE50")]
	public void MGMBJJFHGOO(JFMBPJDJAFM OLBGDPICDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x538F1E0", Offset = "0x538DFE0", VA = "0x18538F1E0")]
	public void OEHBIIIMNPL(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x538DE10", Offset = "0x538CC10", VA = "0x18538DE10")]
	public void GIFFBNAFKGA(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x538F260", Offset = "0x538E060", VA = "0x18538F260")]
	private void PILMOAJPMEM(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x538D150", Offset = "0x538BF50", VA = "0x18538D150")]
	private void CEIBJMHEGLC(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x538E740", Offset = "0x538D540", VA = "0x18538E740")]
	[IteratorStateMachine(typeof(DFAICJPGNOH))]
	private IEnumerator<BAGIJDLGAMA> KICLFMKCLOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x538D890", Offset = "0x538C690", VA = "0x18538D890")]
	private int FLHEMFEHOBJ(int AIPHGHFENPJ, int ONOCCOAMFKO, List<NIBOGNHEKFO> CEJCAHHAFHP, byte DGNFKMOFJKN, ref int KKKMAGCLIPP, float KDBDFGHPFJB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x538CC70", Offset = "0x538BA70", VA = "0x18538CC70")]
	public void AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x538CF90", Offset = "0x538BD90", VA = "0x18538CF90")]
	public bool BJOKBEFEBOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69EC00", Offset = "0x69DA00", VA = "0x18069EC00")]
	public Material AJPGIBPKJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x538D110", Offset = "0x538BF10", VA = "0x18538D110")]
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
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x5388CB0", Offset = "0x5387AB0", VA = "0x185388CB0")]
	public IOIJHPDKJKI(FGBHHFNILHF CNMNFNJMBFD, NativeList<float3> KDKPCJLGNBL, NativeMultiHashMap<int, int> NNOGLEDMIBH, NativeArray<int> MOPFOKHFBHJ, Vector3 FNLBICJDFML, float PGMHGDGHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5388A20", Offset = "0x5387820", VA = "0x185388A20")]
	private int JNJPEGIJBON(float3 IIICLIMCKNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5388A50", Offset = "0x5387850", VA = "0x185388A50")]
	private int KEIIDFEKHLL(int HLAPKJLCEDC, int CCJNKBLKLDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53885F0", Offset = "0x53873F0", VA = "0x1853885F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5383670", Offset = "0x5382470", VA = "0x185383670")]
	public void DMMGPPBKIAO(int FKLMDLIDEAH, Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5383860", Offset = "0x5382660", VA = "0x185383860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x538CB60", Offset = "0x538B960", VA = "0x18538CB60")]
	public OIADKKHLPHB(DLKNINADEHI CCEOBMFDMFH, FGBHHFNILHF CNMNFNJMBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x538CAC0", Offset = "0x538B8C0", VA = "0x18538CAC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5384EF0", Offset = "0x5383CF0", VA = "0x185384EF0")]
	public EECDGBECFPI(DLKNINADEHI HMCICNELNAM, FGBHHFNILHF CNMNFNJMBFD, FGBHHFNILHF HJLHJNHHBNA, float CEFMLLHODCP, float JEIPODGPOFH, Vector3 AFNNDEBMLKF, float EEEOBGDBMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5383940", Offset = "0x5382740", VA = "0x185383940")]
	private float3 AEHMEHEKDMC(int HLAPKJLCEDC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5384660", Offset = "0x5383460", VA = "0x185384660")]
	private void JMGCMPCDGNO(int HLAPKJLCEDC, out float3 GKJKMOCOPFE, out float3 KPCDPOHPDFE, out float4 FPKHNCCKGID, out float4 EFEHKAEGEEH, out float2 GPBHALELLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5384850", Offset = "0x5383650", VA = "0x185384850")]
	private int LCDHGKOOBPK(int APPCCKBGOII, int LHLGBGAHAKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5384CE0", Offset = "0x5383AE0", VA = "0x185384CE0")]
	private void OJCCCALBIKK(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5384B50", Offset = "0x5383950", VA = "0x185384B50")]
	private bool LDHAAHBPKEM(int APPCCKBGOII, int LHLGBGAHAKE, float FHLEEHEDPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5383A10", Offset = "0x5382810", VA = "0x185383A10")]
	private bool BMLHPMBIDEM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53843F0", Offset = "0x53831F0", VA = "0x1853843F0")]
	private bool HIPPNHGJAOM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53839F0", Offset = "0x53827F0", VA = "0x1853839F0")]
	private void BALFJGMOAOL(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, out int NJMJEIHLCLB, out int DCDOLBCKJLC, out int ABFLGOLLPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5383AD0", Offset = "0x53828D0", VA = "0x185383AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x537E700", Offset = "0x537D500", VA = "0x18537E700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MLPDFDKPDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh KBGHCPOECPM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x661A10", Offset = "0x660810", VA = "0x180661A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x661A20", Offset = "0x660820", VA = "0x180661A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MEAKBEOKHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xE5D430", Offset = "0xE5C230", VA = "0x180E5D430", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x29826B0", Offset = "0x29814B0", VA = "0x1829826B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte NOMAIOFLGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x80B7C0", Offset = "0x80A5C0", VA = "0x18080B7C0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x80B970", Offset = "0x80A770", VA = "0x18080B970", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int KPIHMDMCLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x88B650", Offset = "0x88A450", VA = "0x18088B650", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x88B660", Offset = "0x88A460", VA = "0x18088B660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HNFGFOMDMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA4D360", Offset = "0xA4C160", VA = "0x180A4D360", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC4CB30", Offset = "0xC4B930", VA = "0x180C4CB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FJFIPKPHDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x537EA10", Offset = "0x537D810", VA = "0x18537EA10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x537E7E0", Offset = "0x537D5E0", VA = "0x18537E7E0")]
		public void CLDLFPLFAHM(CGGDHFKEBKC DGNFKMOFJKN, out int CFACGPLLKDB, out int GGNOLAIGBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x537F070", Offset = "0x537DE70", VA = "0x18537F070")]
		public void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x537ECD0", Offset = "0x537DAD0", VA = "0x18537ECD0")]
		public void IIHMEABPEHE(NativeList<MLCJACEFBLD> NDCEJJOGNFL, Transform NDBKEODDPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x537EC30", Offset = "0x537DA30", VA = "0x18537EC30")]
		public void GNOJCFCOIJI(Mesh CNMNFNJMBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x537E740", Offset = "0x537D540", VA = "0x18537E740")]
		public void AJAHKDEJBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x537EA30", Offset = "0x537D830", VA = "0x18537EA30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x537F220", Offset = "0x537E020", VA = "0x18537F220")]
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
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KEHAJFJKABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84A9A0", Offset = "0x8497A0", VA = "0x18084A9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x897D00", Offset = "0x896B00", VA = "0x180897D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JFOJKMINJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5385AA0", Offset = "0x53848A0", VA = "0x185385AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5385750", Offset = "0x5384550", VA = "0x185385750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53858B0", Offset = "0x53846B0", VA = "0x1853858B0")]
	public int ELAFGBAHCHA(int EFLIDGHBHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53862C0", Offset = "0x53850C0", VA = "0x1853862C0")]
	public void PBFKLMNICPH(KNNLAILFLCP GKAOPIFDKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5385AF0", Offset = "0x53848F0", VA = "0x185385AF0")]
	public void KAEHGBKBFGC(Transform NDBKEODDPAJ, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x53858E0", Offset = "0x53846E0", VA = "0x1853858E0")]
	public bool EOMGMBAOBOC(bool KHJDMAGGLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5385300", Offset = "0x5384100", VA = "0x185385300")]
	public void CDANDPBOAKH(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5385050", Offset = "0x5383E50", VA = "0x185385050")]
	public bool AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5386480", Offset = "0x5385280", VA = "0x185386480")]
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
	[Cpp2IlInjected.Address(RVA = "0x538BFF0", Offset = "0x538ADF0", VA = "0x18538BFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x538C220", Offset = "0x538B020", VA = "0x18538C220")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x538C160", Offset = "0x538AF60", VA = "0x18538C160")]
	public void HEFJCCLOLGO(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI, Transform KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x538BE00", Offset = "0x538AC00", VA = "0x18538BE00")]
	public void AKJLIPOIGHF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x538C5C0", Offset = "0x538B3C0", VA = "0x18538C5C0")]
	private FNEBCJPGPMH.BLGBIPNKHEJ NBLDEDPIFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x538C0C0", Offset = "0x538AEC0", VA = "0x18538C0C0")]
	private bool GCELBBBNPCP(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x538C060", Offset = "0x538AE60", VA = "0x18538C060")]
	private void FJLNKCGLBMH(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x538C590", Offset = "0x538B390", VA = "0x18538C590")]
	public bool MAKGMJGMKPF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x538C2A0", Offset = "0x538B0A0", VA = "0x18538C2A0")]
	public bool JBCFLHJDAGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x538C530", Offset = "0x538B330", VA = "0x18538C530")]
	private FNEBCJPGPMH.BLGBIPNKHEJ JFCMIFMOANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x538C6F0", Offset = "0x538B4F0", VA = "0x18538C6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5388040", Offset = "0x5386E40", VA = "0x185388040")]
	public HAGCNGENHMK(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5387C40", Offset = "0x5386A40", VA = "0x185387C40")]
	public void ICLLJOENCKL(JCNKMAEMAOG HDKPGLAOJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5387FA0", Offset = "0x5386DA0", VA = "0x185387FA0")]
	private int INFBIJMJHDB(KNNLAILFLCP MKLEFAMNJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5387D60", Offset = "0x5386B60", VA = "0x185387D60")]
	private void ICLLJOENCKL(KNNLAILFLCP MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5387A30", Offset = "0x5386830", VA = "0x185387A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x754F90", Offset = "0x753D90", VA = "0x180754F90")]
			[DebuggerHidden]
			public NPMFDKGDGLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x538C870", Offset = "0x538B670", VA = "0x18538C870", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x538CA20", Offset = "0x538B820", VA = "0x18538CA20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x538C980", Offset = "0x538B780", VA = "0x18538C980", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x538C980", Offset = "0x538B780", VA = "0x18538C980", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5382620", Offset = "0x5381420", VA = "0x185382620", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<NIBOGNHEKFO> AHOLBIIMNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5382600", Offset = "0x5381400", VA = "0x185382600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> FEHOHOKDMBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FNEBCJPGPMH IHNGPENLHJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MNLDIFCEPOD OCDBLLAGPKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x662B90", Offset = "0x661990", VA = "0x180662B90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MNLDIFCEPOD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x870F80", Offset = "0x86FD80", VA = "0x180870F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GEHCEJHHGCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5382610", Offset = "0x5381410", VA = "0x185382610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53811E0", Offset = "0x537FFE0", VA = "0x1853811E0")]
		public static ClusterMeshRenderer Create(FNEBCJPGPMH CNMNFNJMBFD, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5381380", Offset = "0x5380180", VA = "0x185381380", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5381B40", Offset = "0x5380940", VA = "0x185381B40", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5381930", Offset = "0x5380730", VA = "0x185381930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53815D0", Offset = "0x53803D0", VA = "0x1853815D0")]
		public void Init(FNEBCJPGPMH CNMNFNJMBFD, MeshFilter LHAOKPNPAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53813E0", Offset = "0x53801E0", VA = "0x1853813E0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5381C70", Offset = "0x5380A70", VA = "0x185381C70", Slot = "8")]
		public void UpdateClusterDistances(Vector3 IIICLIMCKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5381E80", Offset = "0x5380C80", VA = "0x185381E80", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5381560", Offset = "0x5380360", VA = "0x185381560")]
		[IteratorStateMachine(typeof(NPMFDKGDGLH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53819B0", Offset = "0x53807B0", VA = "0x1853819B0")]
		public void SetupTagAndLayer(string BGDAFDMFHHK, int BPACBAKLDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5381990", Offset = "0x5380790", VA = "0x185381990")]
		public bool Remove(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x5385030", Offset = "0x5383E30", VA = "0x185385030")]
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
		[Cpp2IlInjected.Address(RVA = "0xA01BE0", Offset = "0xA009E0", VA = "0x180A01BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA02180", Offset = "0xA00F80", VA = "0x180A02180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5386640", Offset = "0x5385440", VA = "0x185386640")]
	public void ENJHCNHMIBP(FGBHHFNILHF OCMDDHDAFCO, NativeList<FMHJHMGOGCB> OHDDMIOPOFC, float AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5387740", Offset = "0x5386540", VA = "0x185387740")]
	public void NEGHPKDPNDJ(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5387560", Offset = "0x5386360", VA = "0x185387560")]
	public void EOMGMBAOBOC(FNEBCJPGPMH CJJNIEGEMMA, bool KHJDMAGGLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5386530", Offset = "0x5385330", VA = "0x185386530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5387710", Offset = "0x5386510", VA = "0x185387710")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x5388520", Offset = "0x5387320", VA = "0x185388520")]
	public HGIDGIHFPOK(GKJKAAOLDLO LPGHNKKMKEB, Vector3 AFNNDEBMLKF, bool EHHGKBMMEII, float OAODHMADCFM, float PIBFPOEDNHF, float OADCCHBMLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5388090", Offset = "0x5386E90", VA = "0x185388090", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x538B5C0", Offset = "0x538A3C0", VA = "0x18538B5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5388D70", Offset = "0x5387B70", VA = "0x185388D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5380FF0", Offset = "0x537FDF0", VA = "0x185380FF0")]
	public CCPGCDPEANE(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ, int HFLIKIFLLNK, float PCPAPMPBGEH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x537F460", Offset = "0x537E260", VA = "0x18537F460")]
	public void FNDFGCKGBNC(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x537F660", Offset = "0x537E460", VA = "0x18537F660")]
	public bool IKJFIIAMCPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x537F390", Offset = "0x537E190", VA = "0x18537F390")]
	private float BOAMHLOODOF(Vector3 OCIAEJCLHLN, Vector3 GEOHKIDILGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x537F410", Offset = "0x537E210", VA = "0x18537F410")]
	private float BOAMHLOODOF(Vector3 MNKEEJPGFOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5380760", Offset = "0x537F560", VA = "0x185380760")]
	private bool PMCDPKPFOAK(KNNLAILFLCP LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x537F6D0", Offset = "0x537E4D0", VA = "0x18537F6D0")]
	private AGHHFJMDKDL KDNANFFAHAJ(List<JFMBPJDJAFM> KKPMAABHOAI, ONGALEILGHJ HJNJLJOJBPP)
	{
		return default(AGHHFJMDKDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5380300", Offset = "0x537F100", VA = "0x185380300")]
	private void KGLNHFKOCGL(List<JFMBPJDJAFM> CGPLPFBCOHF, Vector3[] JLHJPBEGJFM, Vector3[] HKPLKDEHPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class LODAEEMPCPF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x538BA40", Offset = "0x538A840", VA = "0x18538BA40")]
	public static Bounds IEFIBHHGJDK(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x538BBF0", Offset = "0x538A9F0", VA = "0x18538BBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xACDF40", Offset = "0xACCD40", VA = "0x180ACDF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GHLPPBBPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A80", Offset = "0x6D0880", VA = "0x1806D1A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x538A0A0", Offset = "0x5388EA0", VA = "0x18538A0A0")]
	[CCHBFIAMMOL(HBPLHMNGKEN.ExitingPlayMode, 0)]
	private void HJAMABMPGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53895A0", Offset = "0x53883A0", VA = "0x1853895A0")]
	public void ENJHCNHMIBP(FNEBCJPGPMH.BLGBIPNKHEJ COIDFMJFENC, Transform HPNHPIKEOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5388E40", Offset = "0x5387C40", VA = "0x185388E40")]
	public void BLICBNHGCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5389530", Offset = "0x5388330", VA = "0x185389530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x538A110", Offset = "0x5388F10", VA = "0x18538A110")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x538A150", Offset = "0x5388F50", VA = "0x18538A150")]
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
				[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
				public PMJBNIICBOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x538CB90", Offset = "0x538B990", VA = "0x18538CB90")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x538CBE0", Offset = "0x538B9E0", VA = "0x18538CBE0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x538CC30", Offset = "0x538BA30", VA = "0x18538CC30")]
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
				[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NBBFNJAIIDK
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x213E880", Offset = "0x213D680", VA = "0x18213E880", Slot = "4")]
			public BCFLAMMDJKJ BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x20FBEB0", Offset = "0x20FACB0", VA = "0x1820FBEB0", Slot = "5")]
			public BCFLAMMDJKJ APBNFNNEFDH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x20FBED0", Offset = "0x20FACD0", VA = "0x1820FBED0", Slot = "6")]
			public BCFLAMMDJKJ NKMOFLPAHKE(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3563080", Offset = "0x3561E80", VA = "0x183563080", Slot = "7")]
			public BCFLAMMDJKJ LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
			public LMMKPGCDAGL(Func<JobHandle> DMNBCEFJPHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x538B7B0", Offset = "0x538A5B0", VA = "0x18538B7B0")]
			public void LCBCKFDJBHE(Action APMKJOOLPLF, Action KOMLGNFIAAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x538B640", Offset = "0x538A440", VA = "0x18538B640")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public JPMABLCBMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x538A7D0", Offset = "0x53895D0", VA = "0x18538A7D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public OBNHJGEPNKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x538CA60", Offset = "0x538B860", VA = "0x18538CA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x538A7E0", Offset = "0x53895E0", VA = "0x18538A7E0")]
		public BCFLAMMDJKJ Add(Func<JobHandle> DMNBCEFJPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x538AAE0", Offset = "0x53898E0", VA = "0x18538AAE0")]
		public void Remove(BCFLAMMDJKJ AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x538A940", Offset = "0x5389740", VA = "0x18538A940", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x538ACB0", Offset = "0x5389AB0", VA = "0x18538ACB0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x538AF00", Offset = "0x5389D00", VA = "0x18538AF00")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x538A930", Offset = "0x5389730", VA = "0x18538A930")]
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
				[Cpp2IlInjected.Address(RVA = "0x537F380", Offset = "0x537E180", VA = "0x18537F380")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x20FBEB0", Offset = "0x20FACB0", VA = "0x1820FBEB0", Slot = "4")]
			public AICNMMJCFDP BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x20FBED0", Offset = "0x20FACD0", VA = "0x1820FBED0", Slot = "5")]
			public AICNMMJCFDP LNCBNLCAPGF(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3563080", Offset = "0x3561E80", VA = "0x183563080", Slot = "6")]
			public AICNMMJCFDP LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAC6AC0", Offset = "0xAC58C0", VA = "0x180AC6AC0")]
			public BPEBFGCKOHK(JobHandle HGFNJFOEEBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x537F340", Offset = "0x537E140", VA = "0x18537F340")]
			public void NBKICENBLEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x537F300", Offset = "0x537E100", VA = "0x18537F300")]
			public void AKJLIPOIGHF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BPEBFGCKOHK> KIHPHCBPKIO;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x538B3E0", Offset = "0x538A1E0", VA = "0x18538B3E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x538B000", Offset = "0x5389E00", VA = "0x18538B000")]
		public AICNMMJCFDP Add(JobHandle HGFNJFOEEBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x538B2F0", Offset = "0x538A0F0", VA = "0x18538B2F0")]
		public void Remove(AICNMMJCFDP AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x538B180", Offset = "0x5389F80", VA = "0x18538B180", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x538B090", Offset = "0x5389E90", VA = "0x18538B090")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x538B500", Offset = "0x538A300", VA = "0x18538B500")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x537CD10", Offset = "0x537BB10", VA = "0x18537CD10")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x537CE20", Offset = "0x537BC20", VA = "0x18537CE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
