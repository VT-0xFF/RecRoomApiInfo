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
				[Cpp2IlInjected.Address(RVA = "0x83FBFA0", Offset = "0x83FA9A0", VA = "0x1883FBFA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF46590", Offset = "0xF44F90", VA = "0x180F46590")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x83FBF60", Offset = "0x83FA960", VA = "0x1883FBF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EDA10", Offset = "0x83EC410", VA = "0x1883EDA10")]
		public LODSettings NNFLJFKMFKJ(OHKEILMIKJL ODNGOEPLNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83ED9F0", Offset = "0x83EC3F0", VA = "0x1883ED9F0")]
		public int DEGAHMDDLCI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83EDA20", Offset = "0x83EC420", VA = "0x1883EDA20")]
		public int PMCJDAKLOOB(bool BEJELLJHJNI, Vector3 GMKNEMCPCEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83EDAC0", Offset = "0x83EC4C0", VA = "0x1883EDAC0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GFKHAOFCFOC
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
public interface HKHKFNBJJMM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPKKEKBGPAF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NPAGJNPBKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PKPEMLPMBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<GLNOAJCIDHL> CJMMBAIGBIM
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
	void UpdateClusterDistances(Vector3 FNPMGHGMCGE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(IOEDLKGKACJ ADKKEOFFDMM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GLNOAJCIDHL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int BLNPGNJLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FLNKNOJBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CCLOHMEFLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FCGHPLJLJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte BJNDHIBFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class APIHPFHAAPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OMJPOMPHAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PEPEECNPNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public APIHPFHAAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83FC750", Offset = "0x83FB150", VA = "0x1883FC750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83FCEE0", Offset = "0x83FB8E0", VA = "0x1883FCEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NCNOBOIKCCD : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public APIHPFHAAPI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public NCNOBOIKCCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83FC420", Offset = "0x83FAE20", VA = "0x1883FC420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83FC6A0", Offset = "0x83FB0A0", VA = "0x1883FC6A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LGPGCHABPJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public APIHPFHAAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83F8F20", Offset = "0x83F7920", VA = "0x1883F8F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83FA840", Offset = "0x83F9240", VA = "0x1883FA840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BIGFJDLODFA : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public APIHPFHAAPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public BIGFJDLODFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83EB860", Offset = "0x83EA260", VA = "0x1883EB860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83EC580", Offset = "0x83EAF80", VA = "0x1883EC580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CFDLOKHHLFM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NINGBPKAABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer DGDEIIIAKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LIEEOALHJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject BEKNLFIKFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JANOJIBLLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public KELHPJDJJBN JPCDAECGDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IOEDLKGKACJ> JMEGPJNOLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IOEDLKGKACJ> HAKEOMBNLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<IOEDLKGKACJ> KDLFJEEBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int AEOMFDBPADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double JOICKKEALAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long HJGKHDKAGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private long IOCGGMHHILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long JJKLKDCCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long FMEBFGFGIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OMJPOMPHAHE PCKDFFLINFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<NPAGJNPBKLB>[] KKMMLCBIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<GLNOAJCIDHL>[] HNAPMBOMLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CancellationTokenSource LCJDEKCJOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool DBLOICEDEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private LCOHCCBKPLJ GKGCLAOAJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private LCOHCCBKPLJ HNCFDPOBEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int BGGBNGAGJBJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static APIHPFHAAPI GHBNEILHBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HKEHMOPJNCE GCICFOAOBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MGPPMICHDAJ KPMDKOCCDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MonoBehaviour KFDIBIKFAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material DFBHGFCGHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private List<Material> DJGLFKAINJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Material MFPIIIBGAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<Material> ECDLAPOCCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool BEIOCHLCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly List<HKHKFNBJJMM> BLGIAJAIJHL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig CBOIHOPEAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 EHOIKODKLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81764F0", Offset = "0x8174EF0", VA = "0x1881764F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8176410", Offset = "0x8174E10", VA = "0x188176410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OMJPOMPHAHE NHCHDPONGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3012430", Offset = "0x3010E30", VA = "0x183012430")]
		get
		{
			return default(OMJPOMPHAHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83EA5E0", Offset = "0x83E8FE0", VA = "0x1883EA5E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static APIHPFHAAPI FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83EA590", Offset = "0x83E8F90", VA = "0x1883EA590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BHOAGFDFMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83EA7B0", Offset = "0x83E91B0", VA = "0x1883EA7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool DFKOLNGIAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83E9F90", Offset = "0x83E8990", VA = "0x1883E9F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> JKIKFOHINCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83E9BF0", Offset = "0x83E85F0", VA = "0x1883E9BF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83E84A0", Offset = "0x83E6EA0", VA = "0x1883E84A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LEBEHJMELCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83E9CB0", Offset = "0x83E86B0", VA = "0x1883E9CB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83E7F40", Offset = "0x83E6940", VA = "0x1883E7F40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83EAC00", Offset = "0x83E9600", VA = "0x1883EAC00")]
	public APIHPFHAAPI(HKEHMOPJNCE GCICFOAOBKB, MGPPMICHDAJ KPMDKOCCDBB, ClusterLODConfig CDCADDOOOAM, MonoBehaviour KFDIBIKFAEJ, Material INCBGJMOKLN, ClusterMeshRenderer DGDEIIIAKAI, MeshFilter LIEEOALHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83EA940", Offset = "0x83E9340", VA = "0x1883EA940")]
	private void OJAMPNBPOFK(Material INCBGJMOKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83E8030", Offset = "0x83E6A30", VA = "0x1883E8030")]
	public void DFEMPGHAJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83E9AA0", Offset = "0x83E84A0", VA = "0x1883E9AA0")]
	public void IFADJJMBMLD(Action<Material> CFFEJAMPCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83E9BD0", Offset = "0x83E85D0", VA = "0x1883E9BD0")]
	public static CIJLFCMKEEG.CKEAPDDDGNJ IIKLJJLPDMH(CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG)
	{
		return default(CIJLFCMKEEG.CKEAPDDDGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83E80D0", Offset = "0x83E6AD0", VA = "0x1883E80D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83E76D0", Offset = "0x83E60D0", VA = "0x1883E76D0")]
	public static void AEPCLNGECOG(Vector3 MEEBPLINFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83EA8B0", Offset = "0x83E92B0", VA = "0x1883EA8B0")]
	private void OGEMOIPONJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83E9970", Offset = "0x83E8370", VA = "0x1883E9970")]
	private void HPBKMMKOIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83E78F0", Offset = "0x83E62F0", VA = "0x1883E78F0")]
	private void CFBBCBGOBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83E8F80", Offset = "0x83E7980", VA = "0x1883E8F80")]
	public void GOEACFEKGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83E77D0", Offset = "0x83E61D0", VA = "0x1883E77D0")]
	[AsyncStateMachine(typeof(PEPEECNPNDD))]
	public Task AKHOPMEIHEH(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83E9E80", Offset = "0x83E8880", VA = "0x1883E9E80")]
	[IteratorStateMachine(typeof(NCNOBOIKCCD))]
	private IEnumerator<JFFMJDIOLAN> KNCHHOFNEDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83E7E20", Offset = "0x83E6820", VA = "0x1883E7E20")]
	[AsyncStateMachine(typeof(LGPGCHABPJH))]
	private Task CPDBAHBEOEF(OEEGBKAOPAE<string>.BANCHJBJHFK GDGINFACOAJ, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83E95F0", Offset = "0x83E7FF0", VA = "0x1883E95F0")]
	public void HNCDNOLMJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83E9E00", Offset = "0x83E8800", VA = "0x1883E9E00")]
	public void KIFCOMHNKBA(IEnumerable<NPAGJNPBKLB> FEOLBFLCLBK, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83EA0D0", Offset = "0x83E8AD0", VA = "0x1883EA0D0")]
	public void LGNBFODJKCI(IEnumerable<NPAGJNPBKLB> FEOLBFLCLBK, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83E88A0", Offset = "0x83E72A0", VA = "0x1883E88A0")]
	public List<ClusterMeshRenderer> GHAKCDLNCBD(List<IOEDLKGKACJ> NNHHCNELFDD, ALEFPCAPAGF FAIGKPPBFHA, GFKHAOFCFOC LBOHPGJILDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83E9A40", Offset = "0x83E8440", VA = "0x1883E9A40")]
	public void IDJLFEMKNEP(HKHKFNBJJMM PMNODGGNIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83EAAB0", Offset = "0x83E94B0", VA = "0x1883EAAB0")]
	public bool PJHACCICJAF(HKHKFNBJJMM PMNODGGNIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83E9D60", Offset = "0x83E8760", VA = "0x1883E9D60")]
	public void IONJEHINFNG(IOEDLKGKACJ BPHAKIMDIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83EA050", Offset = "0x83E8A50", VA = "0x1883EA050")]
	public void LDJEFEGMPIB(GLNOAJCIDHL IMPJJOAFALF, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83E8560", Offset = "0x83E6F60", VA = "0x1883E8560")]
	public void EIIDIOJAONI(GLNOAJCIDHL IMPJJOAFALF, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83E8750", Offset = "0x83E7150", VA = "0x1883E8750")]
	private void FNEMAEGPJBF(Vector3 FNPMGHGMCGE, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83E9800", Offset = "0x83E8200", VA = "0x1883E9800")]
	private void HOLJEFLKCLO(Vector3 FNPMGHGMCGE, GFKHAOFCFOC LBOHPGJILDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB10", Offset = "0x83E9510", VA = "0x1883EAB10")]
	[IteratorStateMachine(typeof(BIGFJDLODFA))]
	private IEnumerator<JFFMJDIOLAN> PMMLPPHNMEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83E85E0", Offset = "0x83E6FE0", VA = "0x1883E85E0")]
	private int ENADKKOKBLJ(int KABGMIEBEFC, int NHOMJJACLIP, List<GLNOAJCIDHL> MGMJCKGAFIE, byte ODNGOEPLNNM, int NPCGOLNNFKP, float EDINPKFDGCO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83EA3D0", Offset = "0x83E8DD0", VA = "0x1883EA3D0")]
	public void MCKODPOBNPM(IOEDLKGKACJ ADKKEOFFDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83E9DC0", Offset = "0x83E87C0", VA = "0x1883E9DC0")]
	public bool KDMMFLLGILF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB3BA70", Offset = "0xB3A470", VA = "0x180B3BA70")]
	public Material KNPBKNFPHCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83E9F00", Offset = "0x83E8900", VA = "0x1883E9F00")]
	public Material KNPBKNFPHCM(CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB3D0B0", Offset = "0xB3BAB0", VA = "0x180B3D0B0")]
	public Material OAPCEGNJCCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83EA720", Offset = "0x83E9120", VA = "0x1883EA720")]
	public Material OAPCEGNJCCC(CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83E7FF0", Offset = "0x83E69F0", VA = "0x1883E7FF0")]
	public int DEGAHMDDLCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83E7A40", Offset = "0x83E6440", VA = "0x1883E7A40")]
	public (long, int) CJOOPNHMOPK()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GHPEKEAPPEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<float3> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<float4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<float2> LBGFAIHDOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<float4> PMKFPPMHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<int> KOOPKPLDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeList<float3> OCEHBFMFNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private float3 MLGIGNNDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private float PGKIHJANJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeParallelMultiHashMap<int, int> PBOHKGNPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> JGGHACBDGJK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83F2A60", Offset = "0x83F1460", VA = "0x1883F2A60")]
	public GHPEKEAPPEB(CIJLFCMKEEG KGGOMLADPBD, NativeList<float3> OCEHBFMFNKE, NativeParallelMultiHashMap<int, int> PBOHKGNPOAJ, NativeArray<int> JGGHACBDGJK, Vector3 MLGIGNNDPBM, float PGKIHJANJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83F25D0", Offset = "0x83F0FD0", VA = "0x1883F25D0")]
	private int AOFMFJEGEEJ(float3 FNPMGHGMCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83F2360", Offset = "0x83F0D60", VA = "0x1883F2360")]
	private int ADDMGCHOKNJ(int JEDFFCJGKHB, int HPFHOBCPNEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83F2630", Offset = "0x83F1030", VA = "0x1883F2630", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KCFLJLPOBOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static NativeParallelMultiHashMap<int, int> PBOHKGNPOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static NativeArray<int> JGGHACBDGJK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int JLEJHJMODPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeList<int> MPIKGAOGHCP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83F7E20", Offset = "0x83F6820", VA = "0x1883F7E20")]
	public void LKKFJNNBNBF(int MIOAPJGCBLG, Allocator EIOOMONCLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83F7D40", Offset = "0x83F6740", VA = "0x1883F7D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KCFLJLPOBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct INJFHNKEBBN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeList<int> NADIIOMGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<int> EMFMIFJMLKK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83F5190", Offset = "0x83F3B90", VA = "0x1883F5190")]
	public INJFHNKEBBN(KCFLJLPOBOC DOBOECIJBCC, CIJLFCMKEEG KGGOMLADPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83F50E0", Offset = "0x83F3AE0", VA = "0x1883F50E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LILLGLHNDDP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeList<float3> BJDOKIDGHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float3> CLFFINNCAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private NativeArray<float4> NMIDMGAENAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private NativeArray<float2> FCHDPLFIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private NativeArray<float4> NJEAGEBFPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<int> MPIKGAOGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<int> NADIIOMGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<float3> LKFCGBHNCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float3> DFPCCKKFDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeArray<float4> KFENOODDDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<float4> EMCKDFPCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float2> KOKBCBPKPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeList<int> NOMNBPJEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float BCKIHDCBECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	public float JJINHCJIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private float3 BLJMDNLILHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private float PGAJHCPLHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private float AAHDNLIMIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	public float EFLCGLGNONM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83FBE20", Offset = "0x83FA820", VA = "0x1883FBE20")]
	public LILLGLHNDDP(KCFLJLPOBOC ACMKPKJKMNF, CIJLFCMKEEG KGGOMLADPBD, CIJLFCMKEEG FOLEDLNNBDO, float AAHDNLIMIJP, float EFLCGLGNONM, Vector3 BLJMDNLILHJ, float PGAJHCPLHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83FBD70", Offset = "0x83FA770", VA = "0x1883FBD70")]
	private float3 NKOOECKDCHB(int JEDFFCJGKHB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83FBB90", Offset = "0x83FA590", VA = "0x1883FBB90")]
	private void NCNGIDBLEMO(int JEDFFCJGKHB, [Out] float3 DDIGKBBMCJN, [Out] float3 ICIEMNFLFOB, [Out] float4 ALMCCJIFPMA, [Out] float4 FKHGPCMDBHP, [Out] float2 KPPIKKEDEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83FA9F0", Offset = "0x83F93F0", VA = "0x1883FA9F0")]
	private int EDOGPNBFPKB(int DGGIOBCJCGM, int OGDHGHGOOKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83FACF0", Offset = "0x83F96F0", VA = "0x1883FACF0")]
	private void EMHFLNEIJAC(int DGGIOBCJCGM, int OGDHGHGOOKH, int CMCLILHNAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83FA8A0", Offset = "0x83F92A0", VA = "0x1883FA8A0")]
	private bool BHHNBAFOFAH(int DGGIOBCJCGM, int OGDHGHGOOKH, float CNHKLIBPFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x83FBAD0", Offset = "0x83FA4D0", VA = "0x1883FBAD0")]
	private bool KIJPCPDNFIG(int DGGIOBCJCGM, int OGDHGHGOOKH, int CMCLILHNAPP, float CNHKLIBPFHI, bool PFCGDNMIACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83FB870", Offset = "0x83FA270", VA = "0x1883FB870")]
	private bool IAHBBJNGFAM(int DGGIOBCJCGM, int OGDHGHGOOKH, int CMCLILHNAPP, float CNHKLIBPFHI, bool PFCGDNMIACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83FACD0", Offset = "0x83F96D0", VA = "0x1883FACD0")]
	private void EGIEJHGJLIN(int DGGIOBCJCGM, int OGDHGHGOOKH, int CMCLILHNAPP, [Out] int ILPDENJCAFM, [Out] int HAFGIOGLJII, [Out] int BGDKHOEKMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83FAEF0", Offset = "0x83F98F0", VA = "0x1883FAEF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IBGEIBMBIKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ILJDJNCPODE : IDisposable, GLNOAJCIDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Bounds KAKALMLAPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public List<IOEDLKGKACJ> NNHHCNELFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Vector3 PNGJKCLBPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Vector3 JPLMADNMLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int IOAILMGOFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CIJLFCMKEEG FBGHJGMIHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long GHLFMNCAKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KCFLJLPOBOC PMHFFKKLOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Transform FAIGKPPBFHA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int EGEIKMAOELM
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x83F4790", Offset = "0x83F3190", VA = "0x1883F4790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh JNKPHOBMCDM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CIJLFCMKEEG.CKEAPDDDGNJ NLIABNEFIJA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
			[CompilerGenerated]
			get
			{
				return default(CIJLFCMKEEG.CKEAPDDDGNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh AEMDNNPPJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CIJLFCMKEEG.CKEAPDDDGNJ HOCIDLADJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB2F870", Offset = "0xB2E270", VA = "0x180B2F870")]
			[CompilerGenerated]
			get
			{
				return default(CIJLFCMKEEG.CKEAPDDDGNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1004F20", Offset = "0x1003920", VA = "0x181004F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float CCLOHMEFLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x12CD690", Offset = "0x12CC090", VA = "0x1812CD690", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1ABA130", Offset = "0x1AB8B30", VA = "0x181ABA130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte BJNDHIBFHPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1F1ECE0", Offset = "0x1F1D6E0", VA = "0x181F1ECE0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x18D8440", Offset = "0x18D6E40", VA = "0x1818D8440", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int BLNPGNJLDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAE4550", Offset = "0xAE2F50", VA = "0x180AE4550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1619010", Offset = "0x1617A10", VA = "0x181619010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int FLNKNOJBGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1618FE0", Offset = "0x16179E0", VA = "0x181618FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FCGHPLJLJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83F46C0", Offset = "0x83F30C0", VA = "0x1883F46C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83F4290", Offset = "0x83F2C90", VA = "0x1883F4290")]
		public void CFDIPOEKAOB(OHKEILMIKJL ODNGOEPLNNM, [Out] int FIFGJMDPIIE, [Out] int DCDHCGLFMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83F47D0", Offset = "0x83F31D0", VA = "0x1883F47D0")]
		public void NCCHLLHIJGC(OHKEILMIKJL ODNGOEPLNNM, CAKHJMCNAJB HKAFIKHDBOI, int CPMOIFGEIFJ = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83F46E0", Offset = "0x83F30E0", VA = "0x1883F46E0")]
		public void ELJBIEHPLFJ(Mesh KGGOMLADPBD, CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83F49A0", Offset = "0x83F33A0", VA = "0x1883F49A0")]
		public void PJOHKFPFMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83F4500", Offset = "0x83F2F00", VA = "0x1883F4500", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83F4A30", Offset = "0x83F3430", VA = "0x1883F4A30")]
		public ILJDJNCPODE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Bounds KAKALMLAPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public CIJLFCMKEEG.CKEAPDDDGNJ OANLGIJMPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public List<ILJDJNCPODE> CFJONOPJBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public CIKDAPLOMKG NBDFAHLICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public ClusterMeshRenderer HJCIABFMGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int BMJCDHBPOLF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OLDNMECOABP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LNKAFBPGLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int PKPEMLPMBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83F3CE0", Offset = "0x83F26E0", VA = "0x1883F3CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83F3530", Offset = "0x83F1F30", VA = "0x1883F3530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83F3FA0", Offset = "0x83F29A0", VA = "0x1883F3FA0")]
	public int MKHCEAFJCEF(int KJNBALOMOKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83F3FD0", Offset = "0x83F29D0", VA = "0x1883F3FD0")]
	public void PMPKDDEJDEE(AFBDKAJDEEA OCHAFGHIDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83F2B20", Offset = "0x83F1520", VA = "0x1883F2B20")]
	public void BBKOJLBLLEA(Transform HODJCPBCHBO, bool EFJHHOMPAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83F3370", Offset = "0x83F1D70", VA = "0x1883F3370")]
	public bool DPMIOLNLHAK(bool HABCLOBCFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83F36B0", Offset = "0x83F20B0", VA = "0x1883F36B0")]
	public void LAHIDDPJKFM(Transform FAIGKPPBFHA, bool EFJHHOMPAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83F3D30", Offset = "0x83F2730", VA = "0x1883F3D30")]
	public bool MCKODPOBNPM(IOEDLKGKACJ ADKKEOFFDMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x83F41C0", Offset = "0x83F2BC0", VA = "0x1883F41C0")]
	public IBGEIBMBIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KELHPJDJJBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Queue<IBGEIBMBIKE.ILJDJNCPODE> OKPDGOCOBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private IPHCMOGEMFK MGJDOACBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<IBGEIBMBIKE.ILJDJNCPODE> CEIBCDOMKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int NMNEOADDFOL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x83F82B0", Offset = "0x83F6CB0", VA = "0x1883F82B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x83F8390", Offset = "0x83F6D90", VA = "0x1883F8390")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x83F8410", Offset = "0x83F6E10", VA = "0x1883F8410")]
	public void HMDNMGBNKIA(IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH, Transform FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x83F8640", Offset = "0x83F7040", VA = "0x1883F8640")]
	public void MCKODPOBNPM(IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x83F8820", Offset = "0x83F7220", VA = "0x1883F8820")]
	private IBGEIBMBIKE.ILJDJNCPODE MMGMCBOBOIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x83F8530", Offset = "0x83F6F30", VA = "0x1883F8530")]
	private bool KDLMNANNHCJ(IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x83F84D0", Offset = "0x83F6ED0", VA = "0x1883F84D0")]
	private void KAODJIOLGBN(IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x83F8960", Offset = "0x83F7360", VA = "0x1883F8960")]
	public bool NJGOJLEMFJB(IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x83F8020", Offset = "0x83F6A20", VA = "0x1883F8020")]
	public bool DBIPLKHEHMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x83F85D0", Offset = "0x83F6FD0", VA = "0x1883F85D0")]
	private IBGEIBMBIKE.ILJDJNCPODE LDNPBMAIGGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83F8990", Offset = "0x83F7390", VA = "0x1883F8990")]
	public long ODALLOANGPH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x83F8CB0", Offset = "0x83F76B0", VA = "0x1883F8CB0")]
	public KELHPJDJJBN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BICLNFLBEEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int OBPJDEOIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int JNOCDFIEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float NBACCBNOCOF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<IBGEIBMBIKE> KMNEGBLBDED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83EB810", Offset = "0x83EA210", VA = "0x1883EB810")]
	public BICLNFLBEEK(int OBPJDEOIPJI, int JNOCDFIEGBM, float FPHNGOBCHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83EB6B0", Offset = "0x83EA0B0", VA = "0x1883EB6B0")]
	public void BABDFCNPPGM(FCPLKNBBLMC MLLLJACJHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x83EB760", Offset = "0x83EA160", VA = "0x1883EB760")]
	private int DKHPLOPANNN(AFBDKAJDEEA MNHKIMAOFNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x83EB440", Offset = "0x83E9E40", VA = "0x1883EB440")]
	private void BABDFCNPPGM(AFBDKAJDEEA MNHKIMAOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83EB3A0", Offset = "0x83E9DA0", VA = "0x1883EB3A0")]
	private void APLLPJGAGFJ(AFBDKAJDEEA MNHKIMAOFNO, IBGEIBMBIKE LPAEGMEJMEH)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, NPAGJNPBKLB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class POMLFOAGJFA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
			[DebuggerHidden]
			public POMLFOAGJFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x83FD470", Offset = "0x83FBE70", VA = "0x1883FD470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x83FD630", Offset = "0x83FC030", VA = "0x1883FD630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x83FD580", Offset = "0x83FBF80", VA = "0x1883FD580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x83FD580", Offset = "0x83FBF80", VA = "0x1883FD580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PKPEMLPMBLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x83EF5F0", Offset = "0x83EDFF0", VA = "0x1883EF5F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<GLNOAJCIDHL> CJMMBAIGBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83EF5D0", Offset = "0x83EDFD0", VA = "0x1883EF5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> CFJONOPJBMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IBGEIBMBIKE OLDNMECOABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GFKHAOFCFOC JCBBLKMHADD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(GFKHAOFCFOC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ENFEBBNOGAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xE174B0", Offset = "0xE15EB0", VA = "0x180E174B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83EDB20", Offset = "0x83EC520", VA = "0x1883EDB20")]
		public static ClusterMeshRenderer Create(IBGEIBMBIKE KGGOMLADPBD, ClusterMeshRenderer DGDEIIIAKAI, MeshFilter LIEEOALHJNN, ALEFPCAPAGF FAIGKPPBFHA, GFKHAOFCFOC LBOHPGJILDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83EDDA0", Offset = "0x83EC7A0", VA = "0x1883EDDA0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83EE8A0", Offset = "0x83ED2A0", VA = "0x1883EE8A0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(IOEDLKGKACJ ADKKEOFFDMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83EE650", Offset = "0x83ED050", VA = "0x1883EE650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83EE2E0", Offset = "0x83ECCE0", VA = "0x1883EE2E0")]
		public void Init(IBGEIBMBIKE KGGOMLADPBD, MeshFilter LIEEOALHJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83EDE00", Offset = "0x83EC800", VA = "0x1883EDE00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83EE9D0", Offset = "0x83ED3D0", VA = "0x1883EE9D0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 FNPMGHGMCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83EEC80", Offset = "0x83ED680", VA = "0x1883EEC80", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83EE260", Offset = "0x83ECC60", VA = "0x1883EE260")]
		[IteratorStateMachine(typeof(POMLFOAGJFA))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83EE6E0", Offset = "0x83ED0E0", VA = "0x1883EE6E0")]
		public void SetupTagAndLayer(string CKJPANLJIKJ, int LBOHPGJILDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83EE6C0", Offset = "0x83ED0C0", VA = "0x1883EE6C0")]
		public bool Remove(IOEDLKGKACJ ADKKEOFFDMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GBKEBBENLLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int BOFCDOAAHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int MHADOGLMBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int DCDHCGLFMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int FIFGJMDPIIE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83F2340", Offset = "0x83F0D40", VA = "0x1883F2340")]
	public GBKEBBENLLC(int MHADOGLMBLF, int DCDHCGLFMIN, int BOFCDOAAHNM, int FIFGJMDPIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CIKDAPLOMKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeList<float3> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeList<int> MPIKGAOGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public NativeList<int> KOOPKPLDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public NativeList<GBKEBBENLLC> LJFJOPPKGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public NativeArray<int> KKCDCIGOOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NativeArray<float3> MIDHNFPNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public NativeArray<float> IDKOECFIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public JobHandle EDFFJEFOFGN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HEAIIMNKJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xADCA60", Offset = "0xADB460", VA = "0x180ADCA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83ECB50", Offset = "0x83EB550", VA = "0x1883ECB50")]
	public void LHEJPJMHOBO(CIJLFCMKEEG AHLDCAEEGJK, NativeList<GBKEBBENLLC> LJFJOPPKGPM, float NIAMAMNMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x83EC8B0", Offset = "0x83EB2B0", VA = "0x1883EC8B0")]
	public void GNNADJCNLNM(Transform FAIGKPPBFHA, bool EFJHHOMPAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x83EC5D0", Offset = "0x83EAFD0", VA = "0x1883EC5D0")]
	public void DPMIOLNLHAK(IBGEIBMBIKE HJCIABFMGKM, bool HABCLOBCFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83EC770", Offset = "0x83EB170", VA = "0x1883EC770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83EC880", Offset = "0x83EB280", VA = "0x1883EC880")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CIKDAPLOMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct FFCDNBDLMLH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeList<float3> JOHBJJKGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	public NativeList<int> MPIKGAOGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private NativeList<GBKEBBENLLC> MDJAICFOBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private NativeArray<int> KKCDCIGOOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float3 BLJMDNLILHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private NativeArray<float3> MIDHNFPNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeArray<float> IDKOECFIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private bool EFJHHOMPAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private float NEIDLHILJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[ReadOnly]
	private float PHBGFCFNECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private float IIFPFINMJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeList<int> KOOPKPLDCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83F20D0", Offset = "0x83F0AD0", VA = "0x1883F20D0")]
	public FFCDNBDLMLH(CIKDAPLOMKG BNJDBLANMDK, Vector3 BLJMDNLILHJ, bool EFJHHOMPAFN, float NEIDLHILJBP, float PHBGFCFNECD, float IIFPFINMJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83F1BD0", Offset = "0x83F05D0", VA = "0x1883F1BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IOEDLKGKACJ : EGGKHJMOLHG
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds BDGMNCLMGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AFBDKAJDEEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<IOEDLKGKACJ> NNHHCNELFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public AFBDKAJDEEA AEMEEJKFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public AFBDKAJDEEA BLBLDKPDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public AFBDKAJDEEA GOCAEGHNCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int FIFGJMDPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Bounds KAKALMLAPHO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83E72B0", Offset = "0x83E5CB0", VA = "0x1883E72B0")]
	public AFBDKAJDEEA(List<IOEDLKGKACJ> NNHHCNELFDD, [Optional] AFBDKAJDEEA AEMEEJKFKNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FCPLKNBBLMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public List<AFBDKAJDEEA> HLDGPDFBJFB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AFBDKAJDEEA GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x83F1AA0", Offset = "0x83F04A0", VA = "0x1883F1AA0")]
	public FCPLKNBBLMC(AFBDKAJDEEA FAIGKPPBFHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EENLEFNMPCM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LMHICOIPPLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int HJHAPOEBMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int PGMGOFHJAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int IPBKNBGOFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int JFCLJBGJCEN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OCPEIGKOEBI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int DKKOFIPJAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public float KNMNLPMHBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<IOEDLKGKACJ> NNHHCNELFDD;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83FC6F0", Offset = "0x83FB0F0", VA = "0x1883FC6F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum LBALAAGFJBB
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private LMHICOIPPLK LGJMEMIEEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int LAAJLHBHPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int OBPJDEOIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int JNOCDFIEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float FPHNGOBCHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float EGGIANNFPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Stack<AFBDKAJDEEA> JGBGDEEPLFE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FCPLKNBBLMC KINKNJBCIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x83F1940", Offset = "0x83F0340", VA = "0x1883F1940")]
	public EENLEFNMPCM(int OBPJDEOIPJI, int JNOCDFIEGBM, float FPHNGOBCHOC, int LAAJLHBHPGA, float EGGIANNFPGO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83EFC30", Offset = "0x83EE630", VA = "0x1883EFC30")]
	public void ANDOJBBGPGE(List<IOEDLKGKACJ> NNHHCNELFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83F18D0", Offset = "0x83F02D0", VA = "0x1883F18D0")]
	public bool GHHFEHIPNPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83F1880", Offset = "0x83F0280", VA = "0x1883F1880")]
	private float FAMDHLNBGPE(Vector3 EPMJNJEPCMJ, Vector3 JOEBEKPOHKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83F1860", Offset = "0x83F0260", VA = "0x1883F1860")]
	private float FAMDHLNBGPE(Vector3 BCAJFCGHDKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x83EFE00", Offset = "0x83EE800", VA = "0x1883EFE00")]
	private bool BFBEKCPICEP(AFBDKAJDEEA IHFFOFIIONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x83F07E0", Offset = "0x83EF1E0", VA = "0x1883F07E0")]
	private OCPEIGKOEBI EKGGHCEJNMC(List<IOEDLKGKACJ> JMEEMLHLCPE, LBALAAGFJBB EHNLDKOFPFA)
	{
		return default(OCPEIGKOEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x83EF870", Offset = "0x83EE270", VA = "0x1883EF870")]
	private void AJDINGCMEPH(List<IOEDLKGKACJ> NNHHCNELFDD, NativeArray<Vector3> KHNACPHEAAD, NativeArray<Vector3> INPGFPLPIFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class APHCJNLPJKO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x83E7330", Offset = "0x83E5D30", VA = "0x1883E7330")]
	public static Bounds GEJFNIKJPEM(List<IOEDLKGKACJ> NNHHCNELFDD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x83E7500", Offset = "0x83E5F00", VA = "0x1883E7500")]
	public static int GFNMLHOEIGJ(List<IOEDLKGKACJ> NNHHCNELFDD, OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class DAAGDLABJIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool EJAOIBHMMFJ(float4* PMKFPPMHFPK, int AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class POKOCLELFAM
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83FD1E0", Offset = "0x83FBBE0", VA = "0x1883FD1E0")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83FD310", Offset = "0x83FBD10", VA = "0x1883FD310")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83FCF40", Offset = "0x83FB940", VA = "0x1883FCF40")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83FCFF0", Offset = "0x83FB9F0", VA = "0x1883FCFF0")]
		public unsafe static bool KDMGDDCNHFD(float4* PMKFPPMHFPK, int AJDEGEPLAEO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x83EF650", Offset = "0x83EE050", VA = "0x1883EF650")]
	[BurstCompile]
	public unsafe static bool AKAAOGGCBKE(float4* PMKFPPMHFPK, int AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x83E70C0", Offset = "0x83E5AC0", VA = "0x1883E70C0")]
	[BurstCompile]
	public unsafe static bool NNEDIHKHEAP(float4* PMKFPPMHFPK, int AJDEGEPLAEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct JMCPIGPCILI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ReadOnly]
	private NativeList<int> JCLKFHPHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeList<float3> HABMNAPGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<float3> EEDIBMCHMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<float4> KIKJBIMBGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private NativeArray<float4> FGAMINHINPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeArray<float2> LBGFAIHDOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<bool> PPPONAIBDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public NativeList<ushort> GKMCHDIFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public NativeList<CIJLFCMKEEG.NJPIALKCOMO> JMNILAILGCI;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83F6B90", Offset = "0x83F5590", VA = "0x1883F6B90")]
	public JMCPIGPCILI(CIJLFCMKEEG OACKBBELHDO, NativeArray<bool> PPPONAIBDMB, NativeList<ushort> GKMCHDIFIDM, NativeList<CIJLFCMKEEG.NJPIALKCOMO> JMNILAILGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x83F68E0", Offset = "0x83F52E0", VA = "0x1883F68E0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct INBIMIGNHNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[ReadOnly]
	private NativeList<int> JCLKFHPHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<float3> HABMNAPGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float3> EEDIBMCHMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> KIKJBIMBGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> FGAMINHINPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float2> LBGFAIHDOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeList<int> DMEBFJHOKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeList<float3> CCDDJNDBAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeArray<float3> OIIJHBAFHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<float4> CKCLNLAACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeArray<float4> ELDEOKAGGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<float2> ADMMELFHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[WriteOnly]
	public NativeArray<bool> PPPONAIBDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public NativeList<ushort> GKMCHDIFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public NativeList<CIJLFCMKEEG.NJPIALKCOMO> JMNILAILGCI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x83F5020", Offset = "0x83F3A20", VA = "0x1883F5020")]
	public INBIMIGNHNK(CIJLFCMKEEG OACKBBELHDO, CIJLFCMKEEG FDMFPGHNNBA, NativeArray<bool> PPPONAIBDMB, NativeList<ushort> GKMCHDIFIDM, NativeList<CIJLFCMKEEG.NJPIALKCOMO> JMNILAILGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x83F4B50", Offset = "0x83F3550", VA = "0x1883F4B50", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IPHCMOGEMFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private CIJLFCMKEEG BGFJGHFLDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private CIJLFCMKEEG OACKBBELHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<bool> PCHKEDCAKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeList<ushort> GKMCHDIFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private NativeList<CIJLFCMKEEG.NJPIALKCOMO> JMNILAILGCI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static CIJLFCMKEEG GKGGOIFIECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private LNEAKODNBNC LABLDKBHFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private CAKHJMCNAJB HKAFIKHDBOI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle EDFFJEFOFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IBGEIBMBIKE.ILJDJNCPODE IHFFOFIIONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LJFGEGMDHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2781C50", Offset = "0x2780650", VA = "0x182781C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x83F5BA0", Offset = "0x83F45A0", VA = "0x1883F5BA0")]
	[JHMKPHPKHPJ(NPKHJKBGLFH.EnteredEditMode, 0)]
	private static void JLMNFBBOHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x83F5C20", Offset = "0x83F4620", VA = "0x1883F5C20")]
	public void LHEJPJMHOBO(IBGEIBMBIKE.ILJDJNCPODE MDJAICFOBBN, Transform NBKGBELGGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x83F52D0", Offset = "0x83F3CD0", VA = "0x1883F52D0")]
	public void JCCKJKNBGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x83F51C0", Offset = "0x83F3BC0", VA = "0x1883F51C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x83F5290", Offset = "0x83F3C90", VA = "0x1883F5290")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x83F6770", Offset = "0x83F5170", VA = "0x1883F6770")]
	public IPHCMOGEMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MGPPMICHDAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 MKKAOFFNPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HKEHMOPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(OEEGBKAOPAE<string>.BANCHJBJHFK GDGINFACOAJ, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MCDHBODNOIF
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCDHBODNOIF HPBMAGKMPKO(Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCDHBODNOIF JJBKHDOOEBD(Action FCCCPABHDPG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class NCAKDKAPMBP : MCDHBODNOIF
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class GAGFJIJALKM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public NCAKDKAPMBP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				public GAGFJIJALKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x83F22A0", Offset = "0x83F0CA0", VA = "0x1883F22A0")]
				internal void LJBDCCDHADC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x83F22F0", Offset = "0x83F0CF0", VA = "0x1883F22F0")]
				internal void OCBLADONBLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x83F2250", Offset = "0x83F0C50", VA = "0x1883F2250")]
				internal void BHBKBCOCJCK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Func<JobHandle> OHPGPCNPBKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action ECJCGPNKBFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private Action FKPDOLBJICF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private FDFDBHJLKLK IAGJHKJDDOP;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action KNBNNCGMMJM
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AAGMJAGMKDH
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2AE4A40", Offset = "0x2AE3440", VA = "0x182AE4A40", Slot = "4")]
			public MCDHBODNOIF HPBMAGKMPKO(Action FCCCPABHDPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7D2CAE0", Offset = "0x7D2B4E0", VA = "0x187D2CAE0", Slot = "5")]
			public MCDHBODNOIF JJBKHDOOEBD(Action FCCCPABHDPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
			public NCAKDKAPMBP(Func<JobHandle> AAKADBNJAII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x83FBFD0", Offset = "0x83FA9D0", VA = "0x1883FBFD0")]
			public void AEOBHGFBIDI(Action LPONEBADAOF, Action PMDACOFFFEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x83FC290", Offset = "0x83FAC90", VA = "0x1883FC290")]
			public void MCKODPOBNPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MJECKOJBGAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MCDHBODNOIF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public MJECKOJBGAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x83FBFC0", Offset = "0x83FA9C0", VA = "0x1883FBFC0")]
			internal bool LLNJAMFAIEN(NCAKDKAPMBP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class FDLFDDFECPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public NCAKDKAPMBP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public FDLFDDFECPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x83F1B70", Offset = "0x83F0570", VA = "0x1883F1B70")]
			internal void OEKLLABHDGJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Queue<NCAKDKAPMBP> FDKDLFAJBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<NCAKDKAPMBP> OGLGELLPKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private LCOHCCBKPLJ MOMGCGEDOJL;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public CENNABPMIGI FPEOBPIKGPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83F6C00", Offset = "0x83F5600", VA = "0x1883F6C00")]
		public MCDHBODNOIF Add(Func<JobHandle> AAKADBNJAII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x83F6F30", Offset = "0x83F5930", VA = "0x1883F6F30")]
		public void Remove(MCDHBODNOIF EDFFJEFOFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x83F6D60", Offset = "0x83F5760", VA = "0x1883F6D60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83F7110", Offset = "0x83F5B10", VA = "0x1883F7110")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83F7370", Offset = "0x83F5D70", VA = "0x1883F7370")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83F6D50", Offset = "0x83F5750", VA = "0x1883F6D50")]
		[CompilerGenerated]
		private void BLAODMMEPCL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FDFDBHJLKLK
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDFDBHJLKLK HPBMAGKMPKO(Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FDFDBHJLKLK EAAFGCOEGNG(Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FDFDBHJLKLK JJBKHDOOEBD(Action FCCCPABHDPG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, GBAIPNMDKIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class FNOHDPHGCPC : FDFDBHJLKLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private JobHandle EAHMCKLIEDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action ECJCGPNKBFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action BNIBENIEOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private Action AAGMJAGMKDH;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool FICMBNIAFOO
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x83F2240", Offset = "0x83F0C40", VA = "0x1883F2240")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7C40B20", Offset = "0x7C3F520", VA = "0x187C40B20", Slot = "4")]
			public FDFDBHJLKLK HPBMAGKMPKO(Action FCCCPABHDPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7C40B40", Offset = "0x7C3F540", VA = "0x187C40B40", Slot = "5")]
			public FDFDBHJLKLK EAAFGCOEGNG(Action FCCCPABHDPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7D2CAE0", Offset = "0x7D2B4E0", VA = "0x187D2CAE0", Slot = "6")]
			public FDFDBHJLKLK JJBKHDOOEBD(Action FCCCPABHDPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x112C200", Offset = "0x112AC00", VA = "0x18112C200")]
			public FNOHDPHGCPC(JobHandle PJCODJEGDAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x83F21A0", Offset = "0x83F0BA0", VA = "0x1883F21A0")]
			public void IBGIFICHJPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83F21F0", Offset = "0x83F0BF0", VA = "0x1883F21F0")]
			public void MCKODPOBNPM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private List<FNOHDPHGCPC> MABEDOHHDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly List<IDisposable> EMFIAKDOMPE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GKHDDIPMIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83F7950", Offset = "0x83F6350", VA = "0x1883F7950")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x172A7E0", Offset = "0x17291E0", VA = "0x18172A7E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83F7450", Offset = "0x83F5E50", VA = "0x1883F7450")]
		public FDFDBHJLKLK Add(JobHandle PJCODJEGDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83F7B60", Offset = "0x83F6560", VA = "0x1883F7B60")]
		public void Remove(FDFDBHJLKLK EDFFJEFOFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83F7770", Offset = "0x83F6170", VA = "0x1883F7770")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83F75C0", Offset = "0x83F5FC0", VA = "0x1883F75C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x83F74F0", Offset = "0x83F5EF0", VA = "0x1883F74F0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x83F7C60", Offset = "0x83F6660", VA = "0x1883F7C60")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xADAB70", Offset = "0xAD9570", VA = "0x180ADAB70", Slot = "6")]
		private bool NNIBCAIEOLK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x83FD680", Offset = "0x83FC080", VA = "0x1883FD680")]
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
