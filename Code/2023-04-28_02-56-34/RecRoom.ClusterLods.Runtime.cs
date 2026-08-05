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
				[Cpp2IlInjected.Address(RVA = "0x5DED1B0", Offset = "0x5DEBBB0", VA = "0x185DED1B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x143CBE0", Offset = "0x143B5E0", VA = "0x18143CBE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5DED170", Offset = "0x5DEBB70", VA = "0x185DED170")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DDEF20", Offset = "0x5DDD920", VA = "0x185DDEF20")]
		public LODSettings IKIHPEIEJDA(NIIJMGJLALG IFODHNBBPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEF00", Offset = "0x5DDD900", VA = "0x185DDEF00")]
		public int FFOKOACLBDB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEF30", Offset = "0x5DDD930", VA = "0x185DDEF30")]
		public int LGKDGNOHGJC(bool CGEPIHNOPOL, Vector3 CDICJPFABOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF030", Offset = "0x5DDDA30", VA = "0x185DDF030")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OOHKLABBNFN
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
public interface AGGMBKONOLH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGFKJBEONBG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OPKBEOLBICG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DEPEFAKKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<FMKPGDCPHBD> ILGBNINELAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OOHKLABBNFN ECPOLHDPCCK
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
	void UpdateClusterDistances(Vector3 KEFMKLAOCPG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(JCGKODJEJOH AFCHMEJMNBE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FMKPGDCPHBD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int PCABMEIIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GEHGMGBLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float PDBNHMDMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float IMDFICDNBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte GEMCPCOINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GLBDMIHGAPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JPIEEMNABKB
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GPOCDEFECMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLBDMIHGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HKNIJBILNIP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HKNIJBILNIP <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7680", Offset = "0x5DE6080", VA = "0x185DE7680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFPNEHPMMCC : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GLBDMIHGAPP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public DFPNEHPMMCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0A90", Offset = "0x5DDF490", VA = "0x185DE0A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0B50", Offset = "0x5DDF550", VA = "0x185DE0B50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PEKJMOFPLLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GLBDMIHGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HKNIJBILNIP worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HKNIJBILNIP <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DEDF80", Offset = "0x5DEC980", VA = "0x185DEDF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GCIFEGHIEMF : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public GLBDMIHGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public GCIFEGHIEMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2B30", Offset = "0x5DE1530", VA = "0x185DE2B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DE39E0", Offset = "0x5DE23E0", VA = "0x185DE39E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int JHOEMCNAICJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan GEIADABPIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer AOFGPKBDGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter BCKJNLCJLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject ADHMNEIJBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject LEDLKELPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public JKMKJGAHCFM NNPFKGDMJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JCGKODJEJOH> MOMEBKEKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JCGKODJEJOH> LHALDONNACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JCGKODJEJOH> KKJONPMNGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BCGHNAGHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JPIEEMNABKB GNKFBMNLEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<OPKBEOLBICG>[] NKFJPKDBLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<FMKPGDCPHBD>[] MPIFJJJOGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource JHDDPBJINLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool LONEFEPPNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GNGMNANCADP EJLOIONKGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GNGMNANCADP AKDFIBNLIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int DOALMPOJEMG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static GLBDMIHGAPP OIMLLCLGDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DELDCLOPALI OIBNLOJAANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CNFPCJCCHDP JBEGGALFFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour LIBNPPOOCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material HHONJAHEKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<AGGMBKONOLH> COHKDDOPPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig LIOMPKHHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DEKEGHFCNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14BA1A0", Offset = "0x14B8BA0", VA = "0x1814BA1A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14BA0A0", Offset = "0x14B8AA0", VA = "0x1814BA0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JPIEEMNABKB AEMDGMBAEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x850160", Offset = "0x84EB60", VA = "0x180850160")]
		get
		{
			return default(JPIEEMNABKB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6010", Offset = "0x5DE4A10", VA = "0x185DE6010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static GLBDMIHGAPP AGBLMGNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4700", Offset = "0x5DE3100", VA = "0x185DE4700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool AGHICMADJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4A30", Offset = "0x5DE3430", VA = "0x185DE4A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EIBOHENKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5300", Offset = "0x5DE3D00", VA = "0x185DE5300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> MIGLOFLBKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5530", Offset = "0x5DE3F30", VA = "0x185DE5530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4990", Offset = "0x5DE3390", VA = "0x185DE4990")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MHOGDMBLGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4620", Offset = "0x5DE3020", VA = "0x185DE4620")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6320", Offset = "0x5DE4D20", VA = "0x185DE6320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6F30", Offset = "0x5DE5930", VA = "0x185DE6F30")]
	public GLBDMIHGAPP(DELDCLOPALI OIBNLOJAANL, CNFPCJCCHDP JBEGGALFFNO, ClusterLODConfig PHFNCJMEDLM, MonoBehaviour LIBNPPOOCCG, Material HHONJAHEKND, ClusterMeshRenderer AOFGPKBDGMM, MeshFilter BCKJNLCJLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B50", Offset = "0x5DE3550", VA = "0x185DE4B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DE63C0", Offset = "0x5DE4DC0", VA = "0x185DE63C0")]
	public static void LLJJLNOJODA(Vector3 MMJOLIGBJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5E20", Offset = "0x5DE4820", VA = "0x185DE5E20")]
	private void KJFOLMMPGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DE61A0", Offset = "0x5DE4BA0", VA = "0x185DE61A0")]
	private void LEBCOAELLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6B90", Offset = "0x5DE5590", VA = "0x185DE6B90")]
	private void NHCIFJHEFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6630", Offset = "0x5DE5030", VA = "0x185DE6630")]
	public void NFJJCILJOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DE64F0", Offset = "0x5DE4EF0", VA = "0x185DE64F0")]
	[AsyncStateMachine(typeof(GPOCDEFECMA))]
	public Task NFFLJPKJEEB(HKNIJBILNIP BDBJGJIIKDE, CancellationToken OMMIOIOKBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5460", Offset = "0x5DE3E60", VA = "0x185DE5460")]
	[IteratorStateMachine(typeof(DFPNEHPMMCC))]
	private IEnumerator<MEOADLJIECK> HKJMOLONGDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5C80", Offset = "0x5DE4680", VA = "0x185DE5C80")]
	[AsyncStateMachine(typeof(PEKJMOFPLLB))]
	private Task JHCFMJHJKEO(HKNIJBILNIP EMCPCBBDEGD, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C50", Offset = "0x5DE3650", VA = "0x185DE4C50")]
	public void ENCMHDDOJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE53E0", Offset = "0x5DE3DE0", VA = "0x185DE53E0")]
	public void GMOJNGJEEFK(IEnumerable<OPKBEOLBICG> NPGAJDHDMOF, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E60", Offset = "0x5DE3860", VA = "0x185DE4E60")]
	public void FACFEHMHDCP(IEnumerable<OPKBEOLBICG> NPGAJDHDMOF, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE55D0", Offset = "0x5DE3FD0", VA = "0x185DE55D0")]
	public List<ClusterMeshRenderer> JBMLECDHNAE(List<JCGKODJEJOH> MCGONHKIMDB, MCFKMCFIHNF EAGPPNPHOBG, OOHKLABBNFN MHMKDHJAPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DE46C0", Offset = "0x5DE30C0", VA = "0x185DE46C0")]
	public OOHKLABBNFN AEEDKAALLKB(Vector3 CFJJOIPECCO)
	{
		return default(OOHKLABBNFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DE54D0", Offset = "0x5DE3ED0", VA = "0x185DE54D0")]
	public void HPMLHGDLKIG(AGGMBKONOLH DAAKKMLKNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5DC0", Offset = "0x5DE47C0", VA = "0x185DE5DC0")]
	public bool JNAOFEAGLEE(AGGMBKONOLH DAAKKMLKNJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6140", Offset = "0x5DE4B40", VA = "0x185DE6140")]
	public void LDNBCEFFHKC(JCGKODJEJOH KMIMFCDFEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DE62A0", Offset = "0x5DE4CA0", VA = "0x185DE62A0")]
	public void LEFHAGENMNP(FMKPGDCPHBD FDDJEMNDCNJ, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6E40", Offset = "0x5DE5840", VA = "0x185DE6E40")]
	public void POHOJJOCEED(FMKPGDCPHBD FDDJEMNDCNJ, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6CE0", Offset = "0x5DE56E0", VA = "0x185DE6CE0")]
	private void PMBPLLIEIHJ(Vector3 KEFMKLAOCPG, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5EB0", Offset = "0x5DE48B0", VA = "0x185DE5EB0")]
	private void KNHPNKDIHEJ(Vector3 KEFMKLAOCPG, OOHKLABBNFN MHMKDHJAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DE47A0", Offset = "0x5DE31A0", VA = "0x185DE47A0")]
	[IteratorStateMachine(typeof(GCIFEGHIEMF))]
	private IEnumerator<MEOADLJIECK> AMKEPLNGLIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4810", Offset = "0x5DE3210", VA = "0x185DE4810")]
	private int CEDMIFBEKOB(int EGNHJGKABLC, int LGBNFHJKJPH, List<FMKPGDCPHBD> AJKEMKIOFLB, byte IFODHNBBPCL, ref int IJIOMLDHIMD, float JKLLPFODBKG = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5120", Offset = "0x5DE3B20", VA = "0x185DE5120")]
	public void FJEBMLODAAK(JCGKODJEJOH AFCHMEJMNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4760", Offset = "0x5DE3160", VA = "0x185DE4760")]
	public bool AKIJMBNKCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9480", Offset = "0x7C7E80", VA = "0x1807C9480")]
	public Material LPGIEIKEHND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE50E0", Offset = "0x5DE3AE0", VA = "0x185DE50E0")]
	public int FFOKOACLBDB()
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
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct ODNGLPFFFBI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> POEIKFFPAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> IOOOBPEPCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> PMFHPCMANJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> KELHFGLACNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> BPNGDCCICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> JDFBPHJNCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> FEIFLGOGFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 HAGEIEMPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float ADFLNMBNDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeMultiHashMap<int, int> MBCOIOFJDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> ODIBNKPPMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDE30", Offset = "0x5DEC830", VA = "0x185DEDE30")]
	public ODNGLPFFFBI(NPEGMPBOOAE JPGFKCEECPG, NativeList<float3> FEIFLGOGFKO, NativeMultiHashMap<int, int> MBCOIOFJDFG, NativeArray<int> ODIBNKPPMKJ, Vector3 HAGEIEMPOKF, float ADFLNMBNDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDBA0", Offset = "0x5DEC5A0", VA = "0x185DEDBA0")]
	private int HAGDDONLLKH(float3 KEFMKLAOCPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDBD0", Offset = "0x5DEC5D0", VA = "0x185DEDBD0")]
	private int JEDLEEBJMDE(int FMPGMDDDGFN, int OGFDNCPKECB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DED770", Offset = "0x5DEC170", VA = "0x185DED770", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EGCKPPFOJHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeMultiHashMap<int, int> MBCOIOFJDFG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> ODIBNKPPMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int GGDEDGONGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> AOIPPHBPEAO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0C80", Offset = "0x5DDF680", VA = "0x185DE0C80")]
	public void MECFGIMMMDG(int FPCPBCCDOKI, Allocator FKHAEPDPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0BA0", Offset = "0x5DDF5A0", VA = "0x185DE0BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public EGCKPPFOJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NOCJDNFKCNI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> DPGNDEKCMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> EHOFADIHDAP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DED740", Offset = "0x5DEC140", VA = "0x185DED740")]
	public NOCJDNFKCNI(EGCKPPFOJHA DCEBJKLCBDH, NPEGMPBOOAE JPGFKCEECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DED6A0", Offset = "0x5DEC0A0", VA = "0x185DED6A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PIPBCOFLALK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> HNGPDHPGKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> BHIICCFEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> GKALCAIFCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> KKGIBHHNIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> EKLKBCBLJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> AOIPPHBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> DPGNDEKCMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> KBOHECLEJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> PMEECPAGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> BBLHFMMGFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> IGECFECCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> LNBCNPOIDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> KMOBDDMBAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float MOBICMOECOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float GODLJKMEFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 OPJJJNDLBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float DNBCPKHPDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float GKHHHOHKBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float CBFODBDKBEK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0700", Offset = "0x5DEF100", VA = "0x185DF0700")]
	public PIPBCOFLALK(EGCKPPFOJHA PEECHKDLFLO, NPEGMPBOOAE JPGFKCEECPG, NPEGMPBOOAE CEDCJGGGNGJ, float GKHHHOHKBOP, float CBFODBDKBEK, Vector3 OPJJJNDLBLO, float DNBCPKHPDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0650", Offset = "0x5DEF050", VA = "0x185DF0650")]
	private float3 LOCOABJIOOC(int FMPGMDDDGFN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF2E0", Offset = "0x5DEDCE0", VA = "0x185DEF2E0")]
	private void BPIACJFKNFE(int FMPGMDDDGFN, out float3 IKOOAKJJCMO, out float3 NBKDCJLDNDG, out float4 JFADGHDLLGI, out float4 HPCOKDNOEMN, out float2 OBELEIDEFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DF00C0", Offset = "0x5DEEAC0", VA = "0x185DF00C0")]
	private int IDOFGJPGMCA(int LNGNKANNIOD, int BHOHJMEIEOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFEB0", Offset = "0x5DEE8B0", VA = "0x185DEFEB0")]
	private void FLNBAHKKELD(int LNGNKANNIOD, int BHOHJMEIEOE, int OHIDPCJEFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF150", Offset = "0x5DEDB50", VA = "0x185DEF150")]
	private bool APKDGKGOLFG(int LNGNKANNIOD, int BHOHJMEIEOE, float JKPGFIGANMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF4D0", Offset = "0x5DEDED0", VA = "0x185DEF4D0")]
	private bool EFLMIHDBAIK(int LNGNKANNIOD, int BHOHJMEIEOE, int OHIDPCJEFME, float JKPGFIGANMA, bool FLGNKDDLJNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DF03C0", Offset = "0x5DEEDC0", VA = "0x185DF03C0")]
	private bool JPABFCMKGCD(int LNGNKANNIOD, int BHOHJMEIEOE, int OHIDPCJEFME, float JKPGFIGANMA, bool FLGNKDDLJNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0630", Offset = "0x5DEF030", VA = "0x185DF0630")]
	private void LBDEIEMBIHJ(int LNGNKANNIOD, int BHOHJMEIEOE, int OHIDPCJEFME, out int MDPCHKGFODL, out int DDDAKBBFJMJ, out int EHJEMHMGCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF590", Offset = "0x5DEDF90", VA = "0x185DEF590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IGJHBJANNIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class GIDGDBCHLAF : IDisposable, FMKPGDCPHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds ABPIDODICDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<JCGKODJEJOH> MCGONHKIMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 IPFLLDJFMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 DGAFNLMCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int ONCJLAMNCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NPEGMPBOOAE FKOOJPONKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EGCKPPFOJHA DDKDEMEGKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform EAGPPNPHOBG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int LBHMNAIPINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3A20", Offset = "0x5DE2420", VA = "0x185DE3A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh OMMCOFBEOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh NDECPKNKLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PDBNHMDMNBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1459F60", Offset = "0x1458960", VA = "0x181459F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3065AC0", Offset = "0x30644C0", VA = "0x183065AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte GEMCPCOINGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x13FB6E0", Offset = "0x13FA0E0", VA = "0x1813FB6E0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x13FBC70", Offset = "0x13FA670", VA = "0x1813FBC70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int PCABMEIIGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA41530", Offset = "0xA3FF30", VA = "0x180A41530", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA41540", Offset = "0xA3FF40", VA = "0x180A41540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int GEHGMGBLPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBF8080", Offset = "0xBF6A80", VA = "0x180BF8080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE371E0", Offset = "0xE35BE0", VA = "0x180E371E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IMDFICDNBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3E10", Offset = "0x5DE2810", VA = "0x185DE3E10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3E30", Offset = "0x5DE2830", VA = "0x185DE3E30")]
		public void IKKIFFEGKCC(NIIJMGJLALG IFODHNBBPCL, out int IKOJODOAPPN, out int CMGHGEJKFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3A60", Offset = "0x5DE2460", VA = "0x185DE3A60")]
		public void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4060", Offset = "0x5DE2A60", VA = "0x185DE4060")]
		public void NDLBLGMGGMK(NativeList<BKKPIEMNJEM> FKPDCAIGEEM, Transform OIDCDAJDFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4400", Offset = "0x5DE2E00", VA = "0x185DE4400")]
		public void OCNNJFLEKOE(Mesh JPGFKCEECPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE44A0", Offset = "0x5DE2EA0", VA = "0x185DE44A0")]
		public void PDMIANJJEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3C10", Offset = "0x5DE2610", VA = "0x185DE3C10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4540", Offset = "0x5DE2F40", VA = "0x185DE4540")]
		public GIDGDBCHLAF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds ABPIDODICDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<GIDGDBCHLAF> PCMBJANFKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public HDLPJDOGEBL HALLHGMBLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer HCAPMBLBEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int HMMOAKGFJMA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh ENLEMOCKIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IJGLNLPABLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC10", Offset = "0xA4C610", VA = "0x180A4DC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DEPEFAKKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB000", Offset = "0x5DE9A00", VA = "0x185DEB000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA3F0", Offset = "0x5DE8DF0", VA = "0x185DEA3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC50", Offset = "0x5DE9650", VA = "0x185DEAC50")]
	public int JKEILOBBOEA(int CFDPABNFBPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC80", Offset = "0x5DE9680", VA = "0x185DEAC80")]
	public void LDFABMLOHEP(AFHJHJOJBPF PLDDEJHGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9C20", Offset = "0x5DE8620", VA = "0x185DE9C20")]
	public void DNMHGHAHAKF(Transform OIDCDAJDFJD, bool CLIMEPPHJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAE40", Offset = "0x5DE9840", VA = "0x185DEAE40")]
	public bool LMCBIKNOHJL(bool GIKAMHDAJFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA550", Offset = "0x5DE8F50", VA = "0x185DEA550")]
	public void EGPFMCOAENC(Transform EAGPPNPHOBG, bool CLIMEPPHJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA9A0", Offset = "0x5DE93A0", VA = "0x185DEA9A0")]
	public bool FJEBMLODAAK(JCGKODJEJOH AFCHMEJMNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB050", Offset = "0x5DE9A50", VA = "0x185DEB050")]
	public IGJHBJANNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKMKJGAHCFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<IGJHBJANNIK.GIDGDBCHLAF> GGBAPMOBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private BNFKCKPAFBN PPJIJKFEFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<IGJHBJANNIK.GIDGDBCHLAF> OIDIMAALLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JJDFEMFCMCM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB240", Offset = "0x5DE9C40", VA = "0x185DEB240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB1C0", Offset = "0x5DE9BC0", VA = "0x185DEB1C0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB100", Offset = "0x5DE9B00", VA = "0x185DEB100")]
	public void AGMLDLCGDGN(IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB, Transform EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB340", Offset = "0x5DE9D40", VA = "0x185DEB340")]
	public void FJEBMLODAAK(IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8C0", Offset = "0x5DEA2C0", VA = "0x185DEB8C0")]
	private IGJHBJANNIK.GIDGDBCHLAF MEBKGHAGLLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB530", Offset = "0x5DE9F30", VA = "0x185DEB530")]
	private bool FPKFOJHOAKP(IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB2B0", Offset = "0x5DE9CB0", VA = "0x185DEB2B0")]
	private void EDIMOGMPIMM(IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB310", Offset = "0x5DE9D10", VA = "0x185DEB310")]
	public bool FBHFNCKEIPC(IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5D0", Offset = "0x5DE9FD0", VA = "0x185DEB5D0")]
	public bool HGAJENLLFEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB860", Offset = "0x5DEA260", VA = "0x185DEB860")]
	private IGJHBJANNIK.GIDGDBCHLAF JKOEMJAEOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9F0", Offset = "0x5DEA3F0", VA = "0x185DEB9F0")]
	public JKMKJGAHCFM()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HLPHDABOOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JBIIAJLKMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int KJLKMCHFDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float HADNEJIPAOE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<IGJHBJANNIK> AEAPIGIKMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9850", Offset = "0x5DE8250", VA = "0x185DE9850")]
	public HLPHDABOOIA(int JBIIAJLKMHK, int KJLKMCHFDAG, float GKIGFJKCDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9690", Offset = "0x5DE8090", VA = "0x185DE9690")]
	public void GAEGDGELCMB(NIODMIDFIGK OPGIDGKCDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5DE97B0", Offset = "0x5DE81B0", VA = "0x185DE97B0")]
	private int JDJGMLHHCCD(AFHJHJOJBPF PPCJAOBHBIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9450", Offset = "0x5DE7E50", VA = "0x185DE9450")]
	private void GAEGDGELCMB(AFHJHJOJBPF PPCJAOBHBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9240", Offset = "0x5DE7C40", VA = "0x185DE9240")]
	private void AIHLHJAIICD(AFHJHJOJBPF PPCJAOBHBIP, IGJHBJANNIK ANKIFNEPAPK)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, OPKBEOLBICG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KLHOMBLDPMB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
			[DebuggerHidden]
			public KLHOMBLDPMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5DECF80", Offset = "0x5DEB980", VA = "0x185DECF80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5DED130", Offset = "0x5DEBB30", VA = "0x185DED130", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5DED090", Offset = "0x5DEBA90", VA = "0x185DED090", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5DED090", Offset = "0x5DEBA90", VA = "0x185DED090", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DEPEFAKKNNP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5DE04D0", Offset = "0x5DDEED0", VA = "0x185DE04D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<FMKPGDCPHBD> ILGBNINELAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5DE04B0", Offset = "0x5DDEEB0", VA = "0x185DE04B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> PCMBJANFKNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IGJHBJANNIK ENLEMOCKIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OOHKLABBNFN ECPOLHDPCCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x732B90", Offset = "0x731590", VA = "0x180732B90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(OOHKLABBNFN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x998CF0", Offset = "0x9976F0", VA = "0x180998CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool JAEACMAEJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5DE04C0", Offset = "0x5DDEEC0", VA = "0x185DE04C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF090", Offset = "0x5DDDA90", VA = "0x185DDF090")]
		public static ClusterMeshRenderer Create(IGJHBJANNIK JPGFKCEECPG, ClusterMeshRenderer AOFGPKBDGMM, MeshFilter BCKJNLCJLBO, MCFKMCFIHNF EAGPPNPHOBG, OOHKLABBNFN MHMKDHJAPNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF230", Offset = "0x5DDDC30", VA = "0x185DDF230", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF9F0", Offset = "0x5DDE3F0", VA = "0x185DDF9F0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JCGKODJEJOH AFCHMEJMNBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF7E0", Offset = "0x5DDE1E0", VA = "0x185DDF7E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF480", Offset = "0x5DDDE80", VA = "0x185DDF480")]
		public void Init(IGJHBJANNIK JPGFKCEECPG, MeshFilter BCKJNLCJLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF290", Offset = "0x5DDDC90", VA = "0x185DDF290")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB20", Offset = "0x5DDE520", VA = "0x185DDFB20", Slot = "8")]
		public void UpdateClusterDistances(Vector3 KEFMKLAOCPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFD30", Offset = "0x5DDE730", VA = "0x185DDFD30", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF410", Offset = "0x5DDDE10", VA = "0x185DDF410")]
		[IteratorStateMachine(typeof(KLHOMBLDPMB))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF860", Offset = "0x5DDE260", VA = "0x185DDF860")]
		public void SetupTagAndLayer(string JDKEMCFCFIL, int MHMKDHJAPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF840", Offset = "0x5DDE240", VA = "0x185DDF840")]
		public bool Remove(JCGKODJEJOH AFCHMEJMNBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HNCJPALOGAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int KHPCFKBFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int OKIEINKEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CMGHGEJKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IKOJODOAPPN;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE98A0", Offset = "0x5DE82A0", VA = "0x185DE98A0")]
	public HNCJPALOGAL(int OKIEINKEHAF, int CMGHGEJKFNI, int KHPCFKBFNFJ, int IKOJODOAPPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HDLPJDOGEBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> POEIKFFPAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> AOIPPHBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> JDFBPHJNCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<HNCJPALOGAL> OCNEBCDHANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> DPBKJBDOAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> KHOIMBFLDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> LNFGGGGIEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle DNPFDFHMBNH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ADOEMHIFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBCC700", Offset = "0xBCB100", VA = "0x180BCC700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xBCCCA0", Offset = "0xBCB6A0", VA = "0x180BCCCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8170", Offset = "0x5DE6B70", VA = "0x185DE8170")]
	public void GJPLHHGHDFM(NPEGMPBOOAE DFDNHBOOAIG, NativeList<HNCJPALOGAL> OCNEBCDHANP, float AFPPFOOOELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7E80", Offset = "0x5DE6880", VA = "0x185DE7E80")]
	public void EMABMCGFMEN(Transform EAGPPNPHOBG, bool CLIMEPPHJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9090", Offset = "0x5DE7A90", VA = "0x185DE9090")]
	public void LMCBIKNOHJL(IGJHBJANNIK HCAPMBLBEEA, bool GIKAMHDAJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7D70", Offset = "0x5DE6770", VA = "0x185DE7D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7D40", Offset = "0x5DE6740", VA = "0x185DE7D40")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public HDLPJDOGEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct DADKLBBEDMM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> POEIKFFPAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> AOIPPHBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<HNCJPALOGAL> JCOHOBJKOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> DPBKJBDOAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 OPJJJNDLBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> KHOIMBFLDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> LNFGGGGIEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool CLIMEPPHJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float NCJBDFMPJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float PBGCDHNFAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float PPKCBHGCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> JDFBPHJNCCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE09C0", Offset = "0x5DDF3C0", VA = "0x185DE09C0")]
	public DADKLBBEDMM(HDLPJDOGEBL AIFJMENHIAF, Vector3 OPJJJNDLBLO, bool CLIMEPPHJLA, float NCJBDFMPJGE, float PBGCDHNFAKO, float PPKCBHGCGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0530", Offset = "0x5DDEF30", VA = "0x185DE0530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JCGKODJEJOH : DMLNGPJLIAD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds AJBBFIKONDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BKKPIEMNJEM GNHBBJOLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AFHJHJOJBPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<JCGKODJEJOH> MCGONHKIMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public AFHJHJOJBPF GGEKFPEBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public AFHJHJOJBPF DNGGGAHOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public AFHJHJOJBPF PLNIAODIIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int IKOJODOAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds ABPIDODICDO;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDA70", Offset = "0x5DDC470", VA = "0x185DDDA70")]
	public AFHJHJOJBPF(List<JCGKODJEJOH> MCGONHKIMDB, [Optional] AFHJHJOJBPF GGEKFPEBLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NIODMIDFIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<AFHJHJOJBPF> PIPGHOFJLJB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AFHJHJOJBPF CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DED5D0", Offset = "0x5DEBFD0", VA = "0x185DED5D0")]
	public NIODMIDFIGK(AFHJHJOJBPF EAGPPNPHOBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FJNAAOKEKNK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct ABPAPIBJJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int OGCCEBIHEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int OKENOLBLLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int JMLEMPGEKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int BNNAIDJGLNI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct NMNINAKCKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int FDMAFBBLGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float FLLLEHMHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<JCGKODJEJOH> MCGONHKIMDB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum DGGEMDLJEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ABPAPIBJJHK ANJOGNLOLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int ILCHEMBJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int JBIIAJLKMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int KJLKMCHFDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float GKIGFJKCDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GPOCCLDOLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<AFHJHJOJBPF> BPPIPDBIIML;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NIODMIDFIGK MPDFOCKEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2AD0", Offset = "0x5DE14D0", VA = "0x185DE2AD0")]
	public FJNAAOKEKNK(int JBIIAJLKMHK, int KJLKMCHFDAG, float GKIGFJKCDJL, int ILCHEMBJBBD, float GPOCCLDOLBF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE12D0", Offset = "0x5DDFCD0", VA = "0x185DE12D0")]
	public void CHDLJJGOMJA(List<JCGKODJEJOH> MCGONHKIMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE14D0", Offset = "0x5DDFED0", VA = "0x185DE14D0")]
	public bool EHGAPIOPCPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2170", Offset = "0x5DE0B70", VA = "0x185DE2170")]
	private float MIEIFJAFAIO(Vector3 ONLKOJHBEOC, Vector3 JKHCMKCHKPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE21F0", Offset = "0x5DE0BF0", VA = "0x185DE21F0")]
	private float MIEIFJAFAIO(Vector3 GBNBGNMHGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2240", Offset = "0x5DE0C40", VA = "0x185DE2240")]
	private bool MNJOGHAFIHB(AFHJHJOJBPF HAGIPEFPNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1540", Offset = "0x5DDFF40", VA = "0x185DE1540")]
	private NMNINAKCKNG KDAHBBLKKNF(List<JCGKODJEJOH> AKKOKDMJFBH, DGGEMDLJEAJ LCBNDNBHKHI)
	{
		return default(NMNINAKCKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0E70", Offset = "0x5DDF870", VA = "0x185DE0E70")]
	private void AGIFLNNOHCL(List<JCGKODJEJOH> MCGONHKIMDB, Vector3[] MIKHGMMBIFP, Vector3[] MFNKOEHMJAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IDIMJOJAMBB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE98C0", Offset = "0x5DE82C0", VA = "0x185DE98C0")]
	public static Bounds FDMNGDAALMC(List<JCGKODJEJOH> MCGONHKIMDB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A70", Offset = "0x5DE8470", VA = "0x185DE9A70")]
	public static int JIBHMIACFCL(List<JCGKODJEJOH> MCGONHKIMDB, NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BNFKCKPAFBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NPEGMPBOOAE NIKJMDPGAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NPEGMPBOOAE GJEFGAFGFIC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static NPEGMPBOOAE CDNFGNAACKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NHMEFFBNEKI MPFGFBHGIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BMEGHCJFONA BAGHMHPLLPP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle DNPFDFHMBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCB3A00", Offset = "0xCB2400", VA = "0x180CB3A00")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCC0850", Offset = "0xCBF250", VA = "0x180CC0850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IGJHBJANNIK.GIDGDBCHLAF HAGIPEFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CAKLJLJHENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A90D0", Offset = "0x7A7AD0", VA = "0x1807A90D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE700", Offset = "0x5DDD100", VA = "0x185DDE700")]
	[PAECCEJEKMD(KFMLDOLCGMJ.ExitingPlayMode, 0)]
	private static void HKMLLEBMFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDC00", Offset = "0x5DDC600", VA = "0x185DDDC00")]
	public void GJPLHHGHDFM(IGJHBJANNIK.GIDGDBCHLAF JCOHOBJKOIC, Transform EOIBKAPDBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE770", Offset = "0x5DDD170", VA = "0x185DDE770")]
	public void PAFFKPNBANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB90", Offset = "0x5DDC590", VA = "0x185DDDB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB50", Offset = "0x5DDC550", VA = "0x185DDDB50")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEE60", Offset = "0x5DDD860", VA = "0x185DDEE60")]
	public BNFKCKPAFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KNDKMBDLBPB
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GLBDMIHGAPP EFPBIHBKADN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CNFPCJCCHDP
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 KHCHOGKFJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DELDCLOPALI
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(HKNIJBILNIP EMCPCBBDEGD, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface EBAHHPDFIDA
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBAHHPDFIDA OAEIFNAHIFE(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBAHHPDFIDA LEEAEMIMKJK(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBAHHPDFIDA CNIBDBEGGCL(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EBAHHPDFIDA JOGAHFPAJHM(Action DAAMKALKLMO);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MHJLFHLCNGA : EBAHHPDFIDA
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class HDAGLJGDFAH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public MHJLFHLCNGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
				public HDAGLJGDFAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5DE7C60", Offset = "0x5DE6660", VA = "0x185DE7C60")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5DE7CB0", Offset = "0x5DE66B0", VA = "0x185DE7CB0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5DE7D00", Offset = "0x5DE6700", VA = "0x185DE7D00")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> LGGNGMFPDLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action OMADNHBLPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action LOOFCGMAFBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private GDPIGLACGCA LPACPPNGNLI;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AMALIGPHLEC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action IDFDNKBLGFJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2871810", Offset = "0x2870210", VA = "0x182871810", Slot = "4")]
			public EBAHHPDFIDA OAEIFNAHIFE(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2622D00", Offset = "0x2621700", VA = "0x182622D00", Slot = "5")]
			public EBAHHPDFIDA LEEAEMIMKJK(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2622D20", Offset = "0x2621720", VA = "0x182622D20", Slot = "6")]
			public EBAHHPDFIDA CNIBDBEGGCL(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3CDB860", Offset = "0x3CDA260", VA = "0x183CDB860", Slot = "7")]
			public EBAHHPDFIDA JOGAHFPAJHM(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
			public MHJLFHLCNGA(Func<JobHandle> MENCKBBHPGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5DED340", Offset = "0x5DEBD40", VA = "0x185DED340")]
			public void KJENKEOBMBM(Action CHCCHIHLEFJ, Action FBGICBDLPDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5DED1D0", Offset = "0x5DEBBD0", VA = "0x185DED1D0")]
			public void FJEBMLODAAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class DJKEGOPNCPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public EBAHHPDFIDA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public DJKEGOPNCPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0B90", Offset = "0x5DDF590", VA = "0x185DE0B90")]
			internal bool <Remove>b__0(MHJLFHLCNGA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BGFGOPGEAML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public MHJLFHLCNGA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public BGFGOPGEAML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDAF0", Offset = "0x5DDC4F0", VA = "0x185DDDAF0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<MHJLFHLCNGA> GFMJLFJCIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<MHJLFHLCNGA> BGFEHKIHPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GNGMNANCADP BMCJFKKILPC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public BGOKCNKGIMF NKCMAMPBIML
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBB80", Offset = "0x5DEA580", VA = "0x185DEBB80")]
		public EBAHHPDFIDA Add(Func<JobHandle> MENCKBBHPGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBE70", Offset = "0x5DEA870", VA = "0x185DEBE70")]
		public void Remove(EBAHHPDFIDA DNPFDFHMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBCD0", Offset = "0x5DEA6D0", VA = "0x185DEBCD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC040", Offset = "0x5DEAA40", VA = "0x185DEC040")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC290", Offset = "0x5DEAC90", VA = "0x185DEC290")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBB70", Offset = "0x5DEA570", VA = "0x185DEBB70")]
		[CompilerGenerated]
		private void AKBCBGJAAED()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GDPIGLACGCA
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDPIGLACGCA OAEIFNAHIFE(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDPIGLACGCA FJCKMCJLHJA(Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GDPIGLACGCA JOGAHFPAJHM(Action DAAMKALKLMO);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class OHGAKMJGGCK : GDPIGLACGCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle JOGFOAGJNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action OMADNHBLPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action MBEGLEKHBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action IDFDNKBLGFJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool FOBJJPHHEOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5DEDEF0", Offset = "0x5DEC8F0", VA = "0x185DEDEF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2622D00", Offset = "0x2621700", VA = "0x182622D00", Slot = "4")]
			public GDPIGLACGCA OAEIFNAHIFE(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2622D20", Offset = "0x2621720", VA = "0x182622D20", Slot = "5")]
			public GDPIGLACGCA FJCKMCJLHJA(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3CDB860", Offset = "0x3CDA260", VA = "0x183CDB860", Slot = "6")]
			public GDPIGLACGCA JOGAHFPAJHM(Action DAAMKALKLMO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCB93D0", Offset = "0xCB7DD0", VA = "0x180CB93D0")]
			public OHGAKMJGGCK(JobHandle NEKDMAACJDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5DEDF40", Offset = "0x5DEC940", VA = "0x185DEDF40")]
			public void JHOFICMAMCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5DEDF00", Offset = "0x5DEC900", VA = "0x185DEDF00")]
			public void FJEBMLODAAK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<OHGAKMJGGCK> ELGHICAOJKO;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC770", Offset = "0x5DEB170", VA = "0x185DEC770")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC390", Offset = "0x5DEAD90", VA = "0x185DEC390")]
		public GDPIGLACGCA Add(JobHandle NEKDMAACJDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC680", Offset = "0x5DEB080", VA = "0x185DEC680")]
		public void Remove(GDPIGLACGCA DNPFDFHMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC510", Offset = "0x5DEAF10", VA = "0x185DEC510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC420", Offset = "0x5DEAE20", VA = "0x185DEC420")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC890", Offset = "0x5DEB290", VA = "0x185DEC890")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DECCA0", Offset = "0x5DEB6A0", VA = "0x185DECCA0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC950", Offset = "0x5DEB350", VA = "0x185DEC950")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
