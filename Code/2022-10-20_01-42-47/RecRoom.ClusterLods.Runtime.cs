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
				[Cpp2IlInjected.Address(RVA = "0x53B2EB0", Offset = "0x53B1CB0", VA = "0x1853B2EB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x26890A0", Offset = "0x2687EA0", VA = "0x1826890A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x53B2E70", Offset = "0x53B1C70", VA = "0x1853B2E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A8240", Offset = "0x53A7040", VA = "0x1853A8240")]
		public LODSettings ONCCJPMGDFI(CGGDHFKEBKC DGNFKMOFJKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x53A8120", Offset = "0x53A6F20", VA = "0x1853A8120")]
		public int CBOPLEADMOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53A8140", Offset = "0x53A6F40", VA = "0x1853A8140")]
		public int COELFJICIKO(bool AEHJFDGCOKF, Vector3 KPEBLIKEBJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53A8250", Offset = "0x53A7050", VA = "0x1853A8250")]
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
		[Cpp2IlInjected.Address(RVA = "0x53B12C0", Offset = "0x53B00C0", VA = "0x1853B12C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
		[DebuggerHidden]
		public DFAOALHHFDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x53AA640", Offset = "0x53A9440", VA = "0x1853AA640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x53AA700", Offset = "0x53A9500", VA = "0x1853AA700", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x53A4410", Offset = "0x53A3210", VA = "0x1853A4410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
		[DebuggerHidden]
		public DFAICJPGNOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x53A9750", Offset = "0x53A8550", VA = "0x1853A9750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53AA600", Offset = "0x53A9400", VA = "0x1853AA600", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HIAEMPNFLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF41B60", Offset = "0xF40960", VA = "0x180F41B60")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF41A90", Offset = "0xF40890", VA = "0x180F41A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IOGDDEDCCMJ NIFNHEDGACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B80", Offset = "0x7AF980", VA = "0x1807B0B80")]
		get
		{
			return default(IOGDDEDCCMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53B56A0", Offset = "0x53B44A0", VA = "0x1853B56A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PPMPNDINBGL JNHMLOILMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53B46B0", Offset = "0x53B34B0", VA = "0x1853B46B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KKECDAMHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x53B5F80", Offset = "0x53B4D80", VA = "0x1853B5F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OPGIMIDFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x53B4E00", Offset = "0x53B3C00", VA = "0x1853B4E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IFIHAIHIMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53B4510", Offset = "0x53B3310", VA = "0x1853B4510")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53B4AE0", Offset = "0x53B38E0", VA = "0x1853B4AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AEDEMAFPENF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x53B40A0", Offset = "0x53B2EA0", VA = "0x1853B40A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x53B4140", Offset = "0x53B2F40", VA = "0x1853B4140")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53B6650", Offset = "0x53B5450", VA = "0x1853B6650")]
	public PPMPNDINBGL(BLMMCDNAABO CKIOHIIIABP, HLNJDIMPPAN GLEMLNFFILJ, ClusterLODConfig GCHMJLBIADO, MonoBehaviour GCOHCEPGNMC, Material MOOAOAKPGCG, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53B45B0", Offset = "0x53B33B0", VA = "0x1853B45B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x53B4380", Offset = "0x53B3180", VA = "0x1853B4380")]
	public static void CFCNOFJDCFB(Vector3 BGDAGCBCEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53B4F60", Offset = "0x53B3D60", VA = "0x1853B4F60")]
	private void GIFLPEPGKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53B4860", Offset = "0x53B3660", VA = "0x1853B4860")]
	private void FGLJAKKFDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53B6490", Offset = "0x53B5290", VA = "0x1853B6490")]
	private void PLAMDGNIGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53B5880", Offset = "0x53B4680", VA = "0x1853B5880")]
	public void LJBGENFHGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53B5DE0", Offset = "0x53B4BE0", VA = "0x1853B5DE0")]
	[AsyncStateMachine(typeof(JOEJNCNIJBE))]
	public Task LPGBBBMJCDC(GEKJCIHAMFL DIOPAPPIBBL, CancellationToken OAFNKBHDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x53B47F0", Offset = "0x53B35F0", VA = "0x1853B47F0")]
	[IteratorStateMachine(typeof(DFAOALHHFDL))]
	private IEnumerator<BAGIJDLGAMA> FGKJLEBLAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53B3F20", Offset = "0x53B2D20", VA = "0x1853B3F20")]
	[AsyncStateMachine(typeof(AOLDHCIFPJE))]
	private Task APMDJANFFKE(GEKJCIHAMFL JJCKJNKLCDF, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x53B60A0", Offset = "0x53B4EA0", VA = "0x1853B60A0")]
	public void MPFKIAFLJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53B4710", Offset = "0x53B3510", VA = "0x1853B4710")]
	public void EPCJCCEMCAO(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53B4B80", Offset = "0x53B3980", VA = "0x1853B4B80")]
	public void GADJKILMDDL(IEnumerable<ENPPEGBNGFC> NFCICJIEHJE, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53B4FF0", Offset = "0x53B3DF0", VA = "0x1853B4FF0")]
	public List<ClusterMeshRenderer> IDEMEFJOCCN(List<JFMBPJDJAFM> CGPLPFBCOHF, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x53B57D0", Offset = "0x53B45D0", VA = "0x1853B57D0")]
	public MNLDIFCEPOD JLPIEOHGHJP(Vector3 CFBKBGDCIDC)
	{
		return default(MNLDIFCEPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53B44B0", Offset = "0x53B32B0", VA = "0x1853B44B0")]
	public void CNMNPPJAPMI(ONOJJMODHGP MLPIPNJOOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53B4790", Offset = "0x53B3590", VA = "0x1853B4790")]
	public bool FEOPJLGKLJI(ONOJJMODHGP MLPIPNJOOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x53B5F20", Offset = "0x53B4D20", VA = "0x1853B5F20")]
	public void MGMBJJFHGOO(JFMBPJDJAFM OLBGDPICDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x53B62B0", Offset = "0x53B50B0", VA = "0x1853B62B0")]
	public void OEHBIIIMNPL(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53B4EE0", Offset = "0x53B3CE0", VA = "0x1853B4EE0")]
	public void GIFFBNAFKGA(NIBOGNHEKFO JENKMGOKHPL, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53B6330", Offset = "0x53B5130", VA = "0x1853B6330")]
	private void PILMOAJPMEM(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53B4220", Offset = "0x53B3020", VA = "0x1853B4220")]
	private void CEIBJMHEGLC(Vector3 IIICLIMCKNI, MNLDIFCEPOD BPACBAKLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53B5810", Offset = "0x53B4610", VA = "0x1853B5810")]
	[IteratorStateMachine(typeof(DFAICJPGNOH))]
	private IEnumerator<BAGIJDLGAMA> KICLFMKCLOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53B4960", Offset = "0x53B3760", VA = "0x1853B4960")]
	private int FLHEMFEHOBJ(int AIPHGHFENPJ, int ONOCCOAMFKO, List<NIBOGNHEKFO> CEJCAHHAFHP, byte DGNFKMOFJKN, ref int KKKMAGCLIPP, float KDBDFGHPFJB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53B3D40", Offset = "0x53B2B40", VA = "0x1853B3D40")]
	public void AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53B4060", Offset = "0x53B2E60", VA = "0x1853B4060")]
	public bool BJOKBEFEBOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70F7A0", Offset = "0x70E5A0", VA = "0x18070F7A0")]
	public Material AJPGIBPKJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53B41E0", Offset = "0x53B2FE0", VA = "0x1853B41E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x53AFD80", Offset = "0x53AEB80", VA = "0x1853AFD80")]
	public IOIJHPDKJKI(FGBHHFNILHF CNMNFNJMBFD, NativeList<float3> KDKPCJLGNBL, NativeMultiHashMap<int, int> NNOGLEDMIBH, NativeArray<int> MOPFOKHFBHJ, Vector3 FNLBICJDFML, float PGMHGDGHIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53AFAF0", Offset = "0x53AE8F0", VA = "0x1853AFAF0")]
	private int JNJPEGIJBON(float3 IIICLIMCKNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53AFB20", Offset = "0x53AE920", VA = "0x1853AFB20")]
	private int KEIIDFEKHLL(int HLAPKJLCEDC, int CCJNKBLKLDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53AF6C0", Offset = "0x53AE4C0", VA = "0x1853AF6C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53AA740", Offset = "0x53A9540", VA = "0x1853AA740")]
	public void DMMGPPBKIAO(int FKLMDLIDEAH, Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x53AA930", Offset = "0x53A9730", VA = "0x1853AA930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x53B3C30", Offset = "0x53B2A30", VA = "0x1853B3C30")]
	public OIADKKHLPHB(DLKNINADEHI CCEOBMFDMFH, FGBHHFNILHF CNMNFNJMBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x53B3B90", Offset = "0x53B2990", VA = "0x1853B3B90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53ABFC0", Offset = "0x53AADC0", VA = "0x1853ABFC0")]
	public EECDGBECFPI(DLKNINADEHI HMCICNELNAM, FGBHHFNILHF CNMNFNJMBFD, FGBHHFNILHF HJLHJNHHBNA, float CEFMLLHODCP, float JEIPODGPOFH, Vector3 AFNNDEBMLKF, float EEEOBGDBMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x53AAA10", Offset = "0x53A9810", VA = "0x1853AAA10")]
	private float3 AEHMEHEKDMC(int HLAPKJLCEDC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x53AB730", Offset = "0x53AA530", VA = "0x1853AB730")]
	private void JMGCMPCDGNO(int HLAPKJLCEDC, out float3 GKJKMOCOPFE, out float3 KPCDPOHPDFE, out float4 FPKHNCCKGID, out float4 EFEHKAEGEEH, out float2 GPBHALELLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x53AB920", Offset = "0x53AA720", VA = "0x1853AB920")]
	private int LCDHGKOOBPK(int APPCCKBGOII, int LHLGBGAHAKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x53ABDB0", Offset = "0x53AABB0", VA = "0x1853ABDB0")]
	private void OJCCCALBIKK(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x53ABC20", Offset = "0x53AAA20", VA = "0x1853ABC20")]
	private bool LDHAAHBPKEM(int APPCCKBGOII, int LHLGBGAHAKE, float FHLEEHEDPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x53AAAE0", Offset = "0x53A98E0", VA = "0x1853AAAE0")]
	private bool BMLHPMBIDEM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53AB4C0", Offset = "0x53AA2C0", VA = "0x1853AB4C0")]
	private bool HIPPNHGJAOM(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, float FHLEEHEDPCL, bool BCEJPCNJJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53AAAC0", Offset = "0x53A98C0", VA = "0x1853AAAC0")]
	private void BALFJGMOAOL(int APPCCKBGOII, int LHLGBGAHAKE, int EEBDGFMIPPK, out int NJMJEIHLCLB, out int DCDOLBCKJLC, out int ABFLGOLLPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53AABA0", Offset = "0x53A99A0", VA = "0x1853AABA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x53A57D0", Offset = "0x53A45D0", VA = "0x1853A57D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MLPDFDKPDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh KBGHCPOECPM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D390", VA = "0x18065E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MEAKBEOKHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xF9F0C0", Offset = "0xF9DEC0", VA = "0x180F9F0C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC41B0", Offset = "0x2AC2FB0", VA = "0x182AC41B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte NOMAIOFLGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x95ACF0", Offset = "0x959AF0", VA = "0x18095ACF0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x95AE90", Offset = "0x959C90", VA = "0x18095AE90", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int KPIHMDMCLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9B5E90", Offset = "0x9B4C90", VA = "0x1809B5E90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9B5EA0", Offset = "0x9B4CA0", VA = "0x1809B5EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HNFGFOMDMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB69450", Offset = "0xB68250", VA = "0x180B69450", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD643F0", Offset = "0xD631F0", VA = "0x180D643F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FJFIPKPHDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x53A5AE0", Offset = "0x53A48E0", VA = "0x1853A5AE0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53A58B0", Offset = "0x53A46B0", VA = "0x1853A58B0")]
		public void CLDLFPLFAHM(CGGDHFKEBKC DGNFKMOFJKN, out int CFACGPLLKDB, out int GGNOLAIGBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x53A6140", Offset = "0x53A4F40", VA = "0x1853A6140")]
		public void MBNGCEHNOLO(CGGDHFKEBKC DGNFKMOFJKN, LPHIFDNBAIG FINKDHKFDHL, int FMPHCAKJFLG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x53A5DA0", Offset = "0x53A4BA0", VA = "0x1853A5DA0")]
		public void IIHMEABPEHE(NativeList<MLCJACEFBLD> NDCEJJOGNFL, Transform NDBKEODDPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53A5D00", Offset = "0x53A4B00", VA = "0x1853A5D00")]
		public void GNOJCFCOIJI(Mesh CNMNFNJMBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53A5810", Offset = "0x53A4610", VA = "0x1853A5810")]
		public void AJAHKDEJBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53A5B00", Offset = "0x53A4900", VA = "0x1853A5B00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53A62F0", Offset = "0x53A50F0", VA = "0x1853A62F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KEHAJFJKABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6830", Offset = "0x7F5630", VA = "0x1807F6830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JFOJKMINJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x53ACB70", Offset = "0x53AB970", VA = "0x1853ACB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53AC820", Offset = "0x53AB620", VA = "0x1853AC820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53AC980", Offset = "0x53AB780", VA = "0x1853AC980")]
	public int ELAFGBAHCHA(int EFLIDGHBHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53AD390", Offset = "0x53AC190", VA = "0x1853AD390")]
	public void PBFKLMNICPH(KNNLAILFLCP GKAOPIFDKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x53ACBC0", Offset = "0x53AB9C0", VA = "0x1853ACBC0")]
	public void KAEHGBKBFGC(Transform NDBKEODDPAJ, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x53AC9B0", Offset = "0x53AB7B0", VA = "0x1853AC9B0")]
	public bool EOMGMBAOBOC(bool KHJDMAGGLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x53AC3D0", Offset = "0x53AB1D0", VA = "0x1853AC3D0")]
	public void CDANDPBOAKH(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x53AC120", Offset = "0x53AAF20", VA = "0x1853AC120")]
	public bool AKJLIPOIGHF(JFMBPJDJAFM AFOPPLDIMJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x53AD550", Offset = "0x53AC350", VA = "0x1853AD550")]
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
	[Cpp2IlInjected.Address(RVA = "0x53B30C0", Offset = "0x53B1EC0", VA = "0x1853B30C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53B32F0", Offset = "0x53B20F0", VA = "0x1853B32F0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53B3230", Offset = "0x53B2030", VA = "0x1853B3230")]
	public void HEFJCCLOLGO(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI, Transform KOJLKBNIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53B2ED0", Offset = "0x53B1CD0", VA = "0x1853B2ED0")]
	public void AKJLIPOIGHF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53B3690", Offset = "0x53B2490", VA = "0x1853B3690")]
	private FNEBCJPGPMH.BLGBIPNKHEJ NBLDEDPIFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x53B3190", Offset = "0x53B1F90", VA = "0x1853B3190")]
	private bool GCELBBBNPCP(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53B3130", Offset = "0x53B1F30", VA = "0x1853B3130")]
	private void FJLNKCGLBMH(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53B3660", Offset = "0x53B2460", VA = "0x1853B3660")]
	public bool MAKGMJGMKPF(FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53B3370", Offset = "0x53B2170", VA = "0x1853B3370")]
	public bool JBCFLHJDAGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53B3600", Offset = "0x53B2400", VA = "0x1853B3600")]
	private FNEBCJPGPMH.BLGBIPNKHEJ JFCMIFMOANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53B37C0", Offset = "0x53B25C0", VA = "0x1853B37C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53AF110", Offset = "0x53ADF10", VA = "0x1853AF110")]
	public HAGCNGENHMK(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53AED10", Offset = "0x53ADB10", VA = "0x1853AED10")]
	public void ICLLJOENCKL(JCNKMAEMAOG HDKPGLAOJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53AF070", Offset = "0x53ADE70", VA = "0x1853AF070")]
	private int INFBIJMJHDB(KNNLAILFLCP MKLEFAMNJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53AEE30", Offset = "0x53ADC30", VA = "0x1853AEE30")]
	private void ICLLJOENCKL(KNNLAILFLCP MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53AEB00", Offset = "0x53AD900", VA = "0x1853AEB00")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
			[DebuggerHidden]
			public NPMFDKGDGLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x53B3940", Offset = "0x53B2740", VA = "0x1853B3940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x53B3AF0", Offset = "0x53B28F0", VA = "0x1853B3AF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x53B3A50", Offset = "0x53B2850", VA = "0x1853B3A50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x53B3A50", Offset = "0x53B2850", VA = "0x1853B3A50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x53A96F0", Offset = "0x53A84F0", VA = "0x1853A96F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<NIBOGNHEKFO> AHOLBIIMNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x53A96D0", Offset = "0x53A84D0", VA = "0x1853A96D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> FEHOHOKDMBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FNEBCJPGPMH IHNGPENLHJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MNLDIFCEPOD OCDBLLAGPKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6791B0", Offset = "0x677FB0", VA = "0x1806791B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MNLDIFCEPOD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1BCF0", Offset = "0xB1AAF0", VA = "0x180B1BCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GEHCEJHHGCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x53A96E0", Offset = "0x53A84E0", VA = "0x1853A96E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53A82B0", Offset = "0x53A70B0", VA = "0x1853A82B0")]
		public static ClusterMeshRenderer Create(FNEBCJPGPMH CNMNFNJMBFD, ClusterMeshRenderer GMNEIGBEPOF, MeshFilter LHAOKPNPAJK, NECAAJONGCL KOJLKBNIDFO, MNLDIFCEPOD BPACBAKLDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x53A8450", Offset = "0x53A7250", VA = "0x1853A8450", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x53A8C10", Offset = "0x53A7A10", VA = "0x1853A8C10", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x53A8A00", Offset = "0x53A7800", VA = "0x1853A8A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53A86A0", Offset = "0x53A74A0", VA = "0x1853A86A0")]
		public void Init(FNEBCJPGPMH CNMNFNJMBFD, MeshFilter LHAOKPNPAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53A84B0", Offset = "0x53A72B0", VA = "0x1853A84B0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53A8D40", Offset = "0x53A7B40", VA = "0x1853A8D40", Slot = "8")]
		public void UpdateClusterDistances(Vector3 IIICLIMCKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x53A8F50", Offset = "0x53A7D50", VA = "0x1853A8F50", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53A8630", Offset = "0x53A7430", VA = "0x1853A8630")]
		[IteratorStateMachine(typeof(NPMFDKGDGLH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53A8A80", Offset = "0x53A7880", VA = "0x1853A8A80")]
		public void SetupTagAndLayer(string BGDAFDMFHHK, int BPACBAKLDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53A8A60", Offset = "0x53A7860", VA = "0x1853A8A60")]
		public bool Remove(JFMBPJDJAFM AFOPPLDIMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x53AC100", Offset = "0x53AAF00", VA = "0x1853AC100")]
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
		[Cpp2IlInjected.Address(RVA = "0xB24C70", Offset = "0xB23A70", VA = "0x180B24C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB25210", Offset = "0xB24010", VA = "0x180B25210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x53AD710", Offset = "0x53AC510", VA = "0x1853AD710")]
	public void ENJHCNHMIBP(FGBHHFNILHF OCMDDHDAFCO, NativeList<FMHJHMGOGCB> OHDDMIOPOFC, float AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x53AE810", Offset = "0x53AD610", VA = "0x1853AE810")]
	public void NEGHPKDPNDJ(Transform KOJLKBNIDFO, bool EHHGKBMMEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53AE630", Offset = "0x53AD430", VA = "0x1853AE630")]
	public void EOMGMBAOBOC(FNEBCJPGPMH CJJNIEGEMMA, bool KHJDMAGGLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53AD600", Offset = "0x53AC400", VA = "0x1853AD600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53AE7E0", Offset = "0x53AD5E0", VA = "0x1853AE7E0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x53AF5F0", Offset = "0x53AE3F0", VA = "0x1853AF5F0")]
	public HGIDGIHFPOK(GKJKAAOLDLO LPGHNKKMKEB, Vector3 AFNNDEBMLKF, bool EHHGKBMMEII, float OAODHMADCFM, float PIBFPOEDNHF, float OADCCHBMLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x53AF160", Offset = "0x53ADF60", VA = "0x1853AF160", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x53B2690", Offset = "0x53B1490", VA = "0x1853B2690")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53AFE40", Offset = "0x53AEC40", VA = "0x1853AFE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x53A80C0", Offset = "0x53A6EC0", VA = "0x1853A80C0")]
	public CCPGCDPEANE(int ILBKEOIDGDF, int LGNAOBEIPLN, float JDHBIIJBDIJ, int HFLIKIFLLNK, float PCPAPMPBGEH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x53A6530", Offset = "0x53A5330", VA = "0x1853A6530")]
	public void FNDFGCKGBNC(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x53A6730", Offset = "0x53A5530", VA = "0x1853A6730")]
	public bool IKJFIIAMCPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x53A6460", Offset = "0x53A5260", VA = "0x1853A6460")]
	private float BOAMHLOODOF(Vector3 OCIAEJCLHLN, Vector3 GEOHKIDILGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x53A64E0", Offset = "0x53A52E0", VA = "0x1853A64E0")]
	private float BOAMHLOODOF(Vector3 MNKEEJPGFOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x53A7830", Offset = "0x53A6630", VA = "0x1853A7830")]
	private bool PMCDPKPFOAK(KNNLAILFLCP LMOHGPONMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x53A67A0", Offset = "0x53A55A0", VA = "0x1853A67A0")]
	private AGHHFJMDKDL KDNANFFAHAJ(List<JFMBPJDJAFM> KKPMAABHOAI, ONGALEILGHJ HJNJLJOJBPP)
	{
		return default(AGHHFJMDKDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x53A73D0", Offset = "0x53A61D0", VA = "0x1853A73D0")]
	private void KGLNHFKOCGL(List<JFMBPJDJAFM> CGPLPFBCOHF, Vector3[] JLHJPBEGJFM, Vector3[] HKPLKDEHPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class LODAEEMPCPF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53B2B10", Offset = "0x53B1910", VA = "0x1853B2B10")]
	public static Bounds IEFIBHHGJDK(List<JFMBPJDJAFM> CGPLPFBCOHF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53B2CC0", Offset = "0x53B1AC0", VA = "0x1853B2CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xE11E80", Offset = "0xE10C80", VA = "0x180E11E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FNEBCJPGPMH.BLGBIPNKHEJ LMOHGPONMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GHLPPBBPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EF580", Offset = "0x6EE380", VA = "0x1806EF580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53B1170", Offset = "0x53AFF70", VA = "0x1853B1170")]
	[CCHBFIAMMOL(HBPLHMNGKEN.ExitingPlayMode, 0)]
	private void HJAMABMPGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53B0670", Offset = "0x53AF470", VA = "0x1853B0670")]
	public void ENJHCNHMIBP(FNEBCJPGPMH.BLGBIPNKHEJ COIDFMJFENC, Transform HPNHPIKEOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x53AFF10", Offset = "0x53AED10", VA = "0x1853AFF10")]
	public void BLICBNHGCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x53B0600", Offset = "0x53AF400", VA = "0x1853B0600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x53B11E0", Offset = "0x53AFFE0", VA = "0x1853B11E0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53B1220", Offset = "0x53B0020", VA = "0x1853B1220")]
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
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
				public PMJBNIICBOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x53B3C60", Offset = "0x53B2A60", VA = "0x1853B3C60")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x53B3CB0", Offset = "0x53B2AB0", VA = "0x1853B3CB0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x53B3D00", Offset = "0x53B2B00", VA = "0x1853B3D00")]
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
				[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NBBFNJAIIDK
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x227F5F0", Offset = "0x227E3F0", VA = "0x18227F5F0", Slot = "4")]
			public BCFLAMMDJKJ BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x223CC80", Offset = "0x223BA80", VA = "0x18223CC80", Slot = "5")]
			public BCFLAMMDJKJ APBNFNNEFDH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x223CCA0", Offset = "0x223BAA0", VA = "0x18223CCA0", Slot = "6")]
			public BCFLAMMDJKJ NKMOFLPAHKE(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3649AD0", Offset = "0x36488D0", VA = "0x183649AD0", Slot = "7")]
			public BCFLAMMDJKJ LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
			public LMMKPGCDAGL(Func<JobHandle> DMNBCEFJPHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x53B2880", Offset = "0x53B1680", VA = "0x1853B2880")]
			public void LCBCKFDJBHE(Action APMKJOOLPLF, Action KOMLGNFIAAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x53B2710", Offset = "0x53B1510", VA = "0x1853B2710")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public JPMABLCBMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x53B18A0", Offset = "0x53B06A0", VA = "0x1853B18A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public OBNHJGEPNKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x53B3B30", Offset = "0x53B2930", VA = "0x1853B3B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x53B18B0", Offset = "0x53B06B0", VA = "0x1853B18B0")]
		public BCFLAMMDJKJ Add(Func<JobHandle> DMNBCEFJPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x53B1BB0", Offset = "0x53B09B0", VA = "0x1853B1BB0")]
		public void Remove(BCFLAMMDJKJ AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x53B1A10", Offset = "0x53B0810", VA = "0x1853B1A10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x53B1D80", Offset = "0x53B0B80", VA = "0x1853B1D80")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53B1FD0", Offset = "0x53B0DD0", VA = "0x1853B1FD0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53B1A00", Offset = "0x53B0800", VA = "0x1853B1A00")]
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
				[Cpp2IlInjected.Address(RVA = "0x53A6450", Offset = "0x53A5250", VA = "0x1853A6450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x223CC80", Offset = "0x223BA80", VA = "0x18223CC80", Slot = "4")]
			public AICNMMJCFDP BMODNLGJOBH(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x223CCA0", Offset = "0x223BAA0", VA = "0x18223CCA0", Slot = "5")]
			public AICNMMJCFDP LNCBNLCAPGF(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3649AD0", Offset = "0x36488D0", VA = "0x183649AD0", Slot = "6")]
			public AICNMMJCFDP LANCIGKNPBK(Action CGKOOFFNHKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
			public BPEBFGCKOHK(JobHandle HGFNJFOEEBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x53A6410", Offset = "0x53A5210", VA = "0x1853A6410")]
			public void NBKICENBLEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x53A63D0", Offset = "0x53A51D0", VA = "0x1853A63D0")]
			public void AKJLIPOIGHF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BPEBFGCKOHK> KIHPHCBPKIO;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53B24B0", Offset = "0x53B12B0", VA = "0x1853B24B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53B20D0", Offset = "0x53B0ED0", VA = "0x1853B20D0")]
		public AICNMMJCFDP Add(JobHandle HGFNJFOEEBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53B23C0", Offset = "0x53B11C0", VA = "0x1853B23C0")]
		public void Remove(AICNMMJCFDP AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x53B2250", Offset = "0x53B1050", VA = "0x1853B2250", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x53B2160", Offset = "0x53B0F60", VA = "0x1853B2160")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53B25D0", Offset = "0x53B13D0", VA = "0x1853B25D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53A3DE0", Offset = "0x53A2BE0", VA = "0x1853A3DE0")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x53A3EF0", Offset = "0x53A2CF0", VA = "0x1853A3EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
