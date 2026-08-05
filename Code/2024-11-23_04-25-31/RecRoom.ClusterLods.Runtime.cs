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
				[Cpp2IlInjected.Address(RVA = "0x6D1A700", Offset = "0x6D19100", VA = "0x186D1A700")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x933010", Offset = "0x931A10", VA = "0x180933010")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6D1A6C0", Offset = "0x6D190C0", VA = "0x186D1A6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D0E6C0", Offset = "0x6D0D0C0", VA = "0x186D0E6C0")]
		public LODSettings MHNBFPFMKCA(JMOMLIAKNIG CDLBFFAEOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E600", Offset = "0x6D0D000", VA = "0x186D0E600")]
		public int ACCHKPJJFJK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E620", Offset = "0x6D0D020", VA = "0x186D0E620")]
		public int CNAJIHEHOIG(bool DLPDCNJMODK, Vector3 LECDOHNJIHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E6D0", Offset = "0x6D0D0D0", VA = "0x186D0E6D0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KKPOMKCHABI
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
public interface OKEJDOFNJIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECMIDIMNLGD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HLEMMNCDCME
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MIIDNDCKCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LCEOEFEEDBM> INJJNHFELGO
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
	void UpdateClusterDistances(Vector3 BODEELBOMLJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(OIHACEDCJKJ LHCHHCODKCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LCEOEFEEDBM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int IECBLCEEJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int CDCDMOALFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float JELEONLDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OGBILDCCBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte NLPGLGEJJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BJECBOMICMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JJCNKDEEPPK
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
	private struct NPINHEGFAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public BJECBOMICMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E020", Offset = "0x6D1CA20", VA = "0x186D1E020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E7B0", Offset = "0x6D1D1B0", VA = "0x186D1E7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FDNFCFGHCPC : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BJECBOMICMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public FDNFCFGHCPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D10A60", Offset = "0x6D0F460", VA = "0x186D10A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D10B60", Offset = "0x6D0F560", VA = "0x186D10B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NGFIIMMELPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public BJECBOMICMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B010", Offset = "0x6D19A10", VA = "0x186D1B010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C870", Offset = "0x6D1B270", VA = "0x186D1C870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JLKKBOJGMNB : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BJECBOMICMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public JLKKBOJGMNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D180E0", Offset = "0x6D16AE0", VA = "0x186D180E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D18DD0", Offset = "0x6D177D0", VA = "0x186D18DD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int PCONIIEIINC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan OHLPNCPIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NFIFBOILHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter NNKMILFCOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject BDGLFJLCDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject PBLMOPDNLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public PFEHBCABIHA MMHPPBCNABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<OIHACEDCJKJ> IAKPIJCDPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<OIHACEDCJKJ> CLAOALFDMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<OIHACEDCJKJ> NIKDFMJLKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KCOEPOOPIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JJCNKDEEPPK AHGJEPMNFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<HLEMMNCDCME>[] PPCHDHKNNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LCEOEFEEDBM>[] KBIGHGDANNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource FCKFNLAJJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NKLDBDDBHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OIMBFIPCENK DMANDGLPJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OIMBFIPCENK KCGGHKFOJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int DNEMFEOGFDH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BJECBOMICMA OKPLPFFAGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ENDOMDKEHNI PKGJBBHFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HOHNPKODOIM EPIDFDALHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour CBCKBAMNAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material GJFENELJEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> EKAAIADCFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material IHLOPPOHGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> LFLDMDMIIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool DBJOGLNCDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<OKEJDOFNJIJ> JFNELCFLOLA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig JCHFCBHCKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 CALBFIAGHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BE230", Offset = "0x8BCC30", VA = "0x1808BE230")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8BDC00", Offset = "0x8BC600", VA = "0x1808BDC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private JJCNKDEEPPK NCBIOKDJLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAB740", Offset = "0xAAA140", VA = "0x180AAB740")]
		get
		{
			return default(JJCNKDEEPPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CAB0", Offset = "0x6D0B4B0", VA = "0x186D0CAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BJECBOMICMA JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AFD0", Offset = "0x6D099D0", VA = "0x186D0AFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool GMPLDKFMDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B740", Offset = "0x6D0A140", VA = "0x186D0B740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NNLDJBNKLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CE40", Offset = "0x6D0B840", VA = "0x186D0CE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> EEICGBLLJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B680", Offset = "0x6D0A080", VA = "0x186D0B680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BF50", Offset = "0x6D0A950", VA = "0x186D0BF50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NIJBBCGMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D5A0", Offset = "0x6D0BFA0", VA = "0x186D0D5A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C980", Offset = "0x6D0B380", VA = "0x186D0C980")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D6C0", Offset = "0x6D0C0C0", VA = "0x186D0D6C0")]
	public BJECBOMICMA(ENDOMDKEHNI PKGJBBHFDGJ, HOHNPKODOIM EPIDFDALHAP, ClusterLODConfig NKDCCNOOBAE, MonoBehaviour CBCKBAMNAEJ, Material IFIEMFKIBHC, ClusterMeshRenderer NFIFBOILHAI, MeshFilter NNKMILFCOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B020", Offset = "0x6D09A20", VA = "0x186D0B020")]
	private void DHPFOGFMCFA(Material IFIEMFKIBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C010", Offset = "0x6D0AA10", VA = "0x186D0C010")]
	public void KCOOMDECHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BF30", Offset = "0x6D0A930", VA = "0x186D0BF30")]
	public static PNGDONJJIBJ.IBOBCIHJHIH JDIFNKDKAFM(PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP)
	{
		return default(PNGDONJJIBJ.IBOBCIHJHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B250", Offset = "0x6D09C50", VA = "0x186D0B250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C890", Offset = "0x6D0B290", VA = "0x186D0C890")]
	public static void MDADONAHHEK(Vector3 EKHIMPIOHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CBE0", Offset = "0x6D0B5E0", VA = "0x186D0CBE0")]
	private void NDPMPHPPFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D320", Offset = "0x6D0BD20", VA = "0x186D0D320")]
	private void ONIEHNCPIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BA00", Offset = "0x6D0A400", VA = "0x186D0BA00")]
	private void GLGDIGDEPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A4A0", Offset = "0x6D08EA0", VA = "0x186D0A4A0")]
	public void BEBKCGGNKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CF00", Offset = "0x6D0B900", VA = "0x186D0CF00")]
	[AsyncStateMachine(typeof(NPINHEGFAHL))]
	public Task OJFBMHGLPCC(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CA30", Offset = "0x6D0B430", VA = "0x186D0CA30")]
	[IteratorStateMachine(typeof(FDNFCFGHCPC))]
	private IEnumerator<BGFOJNANPKN> MPDGNJFNEJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AAF0", Offset = "0x6D094F0", VA = "0x186D0AAF0")]
	[AsyncStateMachine(typeof(NGFIIMMELPG))]
	private Task BNHIEMBGJAO(FILMNPNNHPJ<string>.EEFAEMIIABD NHEMMLNKJHP, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BBD0", Offset = "0x6D0A5D0", VA = "0x186D0BBD0")]
	public void HDELLLCGMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C790", Offset = "0x6D0B190", VA = "0x186D0C790")]
	public void LEJLBPLEBOL(IEnumerable<HLEMMNCDCME> JFODFANGGFI, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D020", Offset = "0x6D0BA20", VA = "0x186D0D020")]
	public void OLCKPAKAKON(IEnumerable<HLEMMNCDCME> JFODFANGGFI, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C0B0", Offset = "0x6D0AAB0", VA = "0x186D0C0B0")]
	public List<ClusterMeshRenderer> KEPAOCCHPGB(List<OIHACEDCJKJ> GMNMIKLPCOG, EFEILIAEILL ELFANOAFHKM, KKPOMKCHABI FLMAECPLNCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B620", Offset = "0x6D0A020", VA = "0x186D0B620")]
	public void EGHJLBHEINJ(OKEJDOFNJIJ LFDHHMNAECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AF70", Offset = "0x6D09970", VA = "0x186D0AF70")]
	public bool CJNODCHFMGI(OKEJDOFNJIJ LFDHHMNAECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CDE0", Offset = "0x6D0B7E0", VA = "0x186D0CDE0")]
	public void OGLLDANAJMP(OIHACEDCJKJ JLNDKBJKIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B1D0", Offset = "0x6D09BD0", VA = "0x186D0B1D0")]
	public void DPFJFNPIJMF(LCEOEFEEDBM NMAECNIBAJC, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BB50", Offset = "0x6D0A550", VA = "0x186D0BB50")]
	public void HBHCFINFKFC(LCEOEFEEDBM NMAECNIBAJC, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B830", Offset = "0x6D0A230", VA = "0x186D0B830")]
	private void FJEDMJLLGMA(Vector3 BODEELBOMLJ, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BDD0", Offset = "0x6D0A7D0", VA = "0x186D0BDD0")]
	private void HLDBJHPOOMC(Vector3 BODEELBOMLJ, KKPOMKCHABI FLMAECPLNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C810", Offset = "0x6D0B210", VA = "0x186D0C810")]
	[IteratorStateMachine(typeof(JLKKBOJGMNB))]
	private IEnumerator<BGFOJNANPKN> LFIFPNIHLHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CC70", Offset = "0x6D0B670", VA = "0x186D0CC70")]
	private int NOKABOFLIHC(int GCBONJOGHCD, int NMOPNMIJOIA, List<LCEOEFEEDBM> DOKBKICOIFD, byte CDLBFFAEOBG, int JECLAAHEMNO, float KDNNOAHOGEB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D3F0", Offset = "0x6D0BDF0", VA = "0x186D0D3F0")]
	public void PJOABDGMIKH(OIHACEDCJKJ LHCHHCODKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B190", Offset = "0x6D09B90", VA = "0x186D0B190")]
	public bool DICMBILPMKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x97E8C0", Offset = "0x97D2C0", VA = "0x18097E8C0")]
	public Material AIBEOJIOGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A410", Offset = "0x6D08E10", VA = "0x186D0A410")]
	public Material AIBEOJIOGJL(PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5370", VA = "0x1808B6970")]
	public Material GJOHEFGGDEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B970", Offset = "0x6D0A370", VA = "0x186D0B970")]
	public Material GJOHEFGGDEH(PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A3D0", Offset = "0x6D08DD0", VA = "0x186D0A3D0")]
	public int ACCHKPJJFJK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AC10", Offset = "0x6D09610", VA = "0x186D0AC10")]
	public long CFHIJKLBANJ()
	{
		return default(long);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BMONGMDOMEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> LCOCBHMDPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> ABAKPHCCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> FLNPIGMBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> CKGEHNBPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> BIKINIDKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> HAKNLBHIDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> NJCGPMGHHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 IBLDDCKGBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float FJMGDIGABIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> OLAHKGPBAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> GIAMAONAOBH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E540", Offset = "0x6D0CF40", VA = "0x186D0E540")]
	public BMONGMDOMEJ(PNGDONJJIBJ JMPEEMGIIHN, NativeList<float3> NJCGPMGHHJP, NativeParallelMultiHashMap<int, int> OLAHKGPBAFO, NativeArray<int> GIAMAONAOBH, Vector3 IBLDDCKGBKA, float FJMGDIGABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DE40", Offset = "0x6D0C840", VA = "0x186D0DE40")]
	private int CPOCMHJGBEE(float3 BODEELBOMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E2D0", Offset = "0x6D0CCD0", VA = "0x186D0E2D0")]
	private int OFGAAOLBNDB(int FNLONGIJDLD, int PNABAFEIDND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DEA0", Offset = "0x6D0C8A0", VA = "0x186D0DEA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EPCKHPHIDGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> OLAHKGPBAFO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> GIAMAONAOBH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int HGKFMKIEEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> CLCCLKJJKEF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D10790", Offset = "0x6D0F190", VA = "0x186D10790")]
	public void BCHOONBBNLA(int LGDPPAPEBMO, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D10980", Offset = "0x6D0F380", VA = "0x186D10980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public EPCKHPHIDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct LKHGKNLIOLE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> KNDENODGNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> AINHJLADCHK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A690", Offset = "0x6D19090", VA = "0x186D1A690")]
	public LKHGKNLIOLE(EPCKHPHIDGO EECBMNMGOKL, PNGDONJJIBJ JMPEEMGIIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A5E0", Offset = "0x6D18FE0", VA = "0x186D1A5E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct FFKAJMICMIM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> EGBGDHIHDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> PDACCGCEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> AJOGMPOEFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> HDEBGCOPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> CJNPPIHLOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> CLCCLKJJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> KNDENODGNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> BCPLBCDOIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> OEEFLIPFILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> PPELCOCCFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> PJNEFCKNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> INOIDOHKGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> FNOMJMFJOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FBJMDAAHPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float MMICKHEPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 HGNPDGKBMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float JAFCBKIFFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float HAJMMMKIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float FHNFOJHGAMK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D12340", Offset = "0x6D10D40", VA = "0x186D12340")]
	public FFKAJMICMIM(EPCKHPHIDGO EOLLKDODLHB, PNGDONJJIBJ JMPEEMGIIHN, PNGDONJJIBJ GHGHPNCHAPL, float HAJMMMKIEAP, float FHNFOJHGAMK, Vector3 HGNPDGKBMDD, float JAFCBKIFFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D12270", Offset = "0x6D10C70", VA = "0x186D12270")]
	private float3 ILICKDAKEJE(int FNLONGIJDLD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D11DB0", Offset = "0x6D107B0", VA = "0x186D11DB0")]
	private void HLGCBDDADBM(int FNLONGIJDLD, [Out] float3 IFPPDCKMOOL, [Out] float3 KGGJGPPGKHG, [Out] float4 CLIJHGKBPEE, [Out] float4 DIOJBIJMFFG, [Out] float2 DIOJFFPIKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D11F90", Offset = "0x6D10990", VA = "0x186D11F90")]
	private int IDCGIBOHFBM(int DPBMOCHBJNB, int MKIDPPJLHJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D11BB0", Offset = "0x6D105B0", VA = "0x186D11BB0")]
	private void GLOHHAGAHDG(int DPBMOCHBJNB, int MKIDPPJLHJE, int DGDCGOHDNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D11A60", Offset = "0x6D10460", VA = "0x186D11A60")]
	private bool FOLEMCIPCHK(int DPBMOCHBJNB, int MKIDPPJLHJE, float ANAFDKLJFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D10DC0", Offset = "0x6D0F7C0", VA = "0x186D10DC0")]
	private bool DGACOLOPLJA(int DPBMOCHBJNB, int MKIDPPJLHJE, int DGDCGOHDNEN, float ANAFDKLJFIN, bool ODLEPFPLFIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D10E80", Offset = "0x6D0F880", VA = "0x186D10E80")]
	private bool DMMDAGNINGP(int DPBMOCHBJNB, int MKIDPPJLHJE, int DGDCGOHDNEN, float ANAFDKLJFIN, bool ODLEPFPLFIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D12320", Offset = "0x6D10D20", VA = "0x186D12320")]
	private void MOHDIBPICBE(int DPBMOCHBJNB, int MKIDPPJLHJE, int DGDCGOHDNEN, [Out] int KLJMOIMMMKD, [Out] int MLLLABEMNLB, [Out] int NCLAOOJLBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D110E0", Offset = "0x6D0FAE0", VA = "0x186D110E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NOLHNIEMBFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IAFALFIMNIB : IDisposable, LCEOEFEEDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds BFFLGPOAEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<OIHACEDCJKJ> GMNMIKLPCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 LOEKMOJBDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 PLOMCLBIIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int CAFAMIMGLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public PNGDONJJIBJ APFFAKHDJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long ELABPBPKAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EPCKHPHIDGO KDAAAFGEEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform ELFANOAFHKM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int AIKGDKFGDKK
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6D141B0", Offset = "0x6D12BB0", VA = "0x186D141B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh DOEIAFIDKHL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PNGDONJJIBJ.IBOBCIHJHIH APMHDDJNMBP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA8A0", Offset = "0x8C92A0", VA = "0x1808CA8A0")]
			[CompilerGenerated]
			get
			{
				return default(PNGDONJJIBJ.IBOBCIHJHIH);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9294C0", Offset = "0x927EC0", VA = "0x1809294C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh FNHLHCEEBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8AD550", Offset = "0x8ABF50", VA = "0x1808AD550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PNGDONJJIBJ.IBOBCIHJHIH HNEHGDFAPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9E5040", Offset = "0x9E3A40", VA = "0x1809E5040")]
			[CompilerGenerated]
			get
			{
				return default(PNGDONJJIBJ.IBOBCIHJHIH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9E53B0", Offset = "0x9E3DB0", VA = "0x1809E53B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float JELEONLDMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xBF08B0", Offset = "0xBEF2B0", VA = "0x180BF08B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x11DB1E0", Offset = "0x11D9BE0", VA = "0x1811DB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte NLPGLGEJJKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x113EC60", Offset = "0x113D660", VA = "0x18113EC60")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x11406A0", Offset = "0x113F0A0", VA = "0x1811406A0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int IECBLCEEJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8E32A0", Offset = "0x8E1CA0", VA = "0x1808E32A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE00400", Offset = "0xDFEE00", VA = "0x180E00400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int CDCDMOALFCL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8D3FC0", Offset = "0x8D29C0", VA = "0x1808D3FC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xE003F0", Offset = "0xDFEDF0", VA = "0x180E003F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OGBILDCCBNM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6D144E0", Offset = "0x6D12EE0", VA = "0x186D144E0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6D14500", Offset = "0x6D12F00", VA = "0x186D14500")]
		public void KHDFOHJEGEH(JMOMLIAKNIG CDLBFFAEOBG, [Out] int GACOPDJBCOH, [Out] int PIGMEJDKNKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D14770", Offset = "0x6D13170", VA = "0x186D14770")]
		public void LACAPFDFODD(JMOMLIAKNIG CDLBFFAEOBG, GJOHKPHJKBE PEKBIFNLJPI, int DEGEPGIHNKN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D14430", Offset = "0x6D12E30", VA = "0x186D14430")]
		public void HDIPLFNKPAH(Mesh JMPEEMGIIHN, PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D141F0", Offset = "0x6D12BF0", VA = "0x186D141F0")]
		public void CMHNOBJAHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D14280", Offset = "0x6D12C80", VA = "0x186D14280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D14940", Offset = "0x6D13340", VA = "0x186D14940")]
		public IAFALFIMNIB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds BFFLGPOAEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public PNGDONJJIBJ.IBOBCIHJHIH NFGNEFNKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<IAFALFIMNIB> PJHJODPFLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public IEMJPHIJFAG FNJEPNIHHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer MIPAHIFMGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int NMBHLKGHGIH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh IANNELJHPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB30", Offset = "0x8AC530", VA = "0x1808ADB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LEAPNJKHIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x964220", Offset = "0x962C20", VA = "0x180964220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9630A0", Offset = "0x961AA0", VA = "0x1809630A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int MIIDNDCKCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D4B0", Offset = "0x6D1BEB0", VA = "0x186D1D4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CAC0", Offset = "0x6D1B4C0", VA = "0x186D1CAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CC40", Offset = "0x6D1B640", VA = "0x186D1CC40")]
	public int FMHBMGIBMPF(int EPENEONCIHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C8D0", Offset = "0x6D1B2D0", VA = "0x186D1C8D0")]
	public void CJLMPDFDMHK(JLEFEAOFDEC MHCDFMPENIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CC70", Offset = "0x6D1B670", VA = "0x186D1CC70")]
	public void GLKHLLNFOHA(Transform GBKILFLBDLB, bool JHJNOJNGAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DD90", Offset = "0x6D1C790", VA = "0x186D1DD90")]
	public bool PNPPGLFOGFO(bool EBFLEEGCMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D500", Offset = "0x6D1BF00", VA = "0x186D1D500")]
	public void PIOFAFBPMOE(Transform ELFANOAFHKM, bool JHJNOJNGAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DB20", Offset = "0x6D1C520", VA = "0x186D1DB20")]
	public bool PJOABDGMIKH(OIHACEDCJKJ LHCHHCODKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DF50", Offset = "0x6D1C950", VA = "0x186D1DF50")]
	public NOLHNIEMBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PFEHBCABIHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<NOLHNIEMBFE.IAFALFIMNIB> GNAPPMOKFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HNFNNCICLLD LBLHDIJKDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<NOLHNIEMBFE.IAFALFIMNIB> LOJGHHACGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int LHBLDMMNNNE;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EC80", Offset = "0x6D1D680", VA = "0x186D1EC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E840", Offset = "0x6D1D240", VA = "0x186D1E840")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F1D0", Offset = "0x6D1DBD0", VA = "0x186D1F1D0")]
	public void NOEGDDICEDP(NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM, Transform ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F2F0", Offset = "0x6D1DCF0", VA = "0x186D1F2F0")]
	public void PJOABDGMIKH(NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F060", Offset = "0x6D1DA60", VA = "0x186D1F060")]
	private NOLHNIEMBFE.IAFALFIMNIB IHNJCNOAEBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EBE0", Offset = "0x6D1D5E0", VA = "0x186D1EBE0")]
	private bool CJMALIIOBPF(NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F290", Offset = "0x6D1DC90", VA = "0x186D1F290")]
	private void OFBLOOAEEMB(NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F1A0", Offset = "0x6D1DBA0", VA = "0x186D1F1A0")]
	public bool MDMJKGJEIEG(NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ED60", Offset = "0x6D1D760", VA = "0x186D1ED60")]
	public bool HIEHKMNLIKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EFF0", Offset = "0x6D1D9F0", VA = "0x186D1EFF0")]
	private NOLHNIEMBFE.IAFALFIMNIB IHDJIFCFAGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E8C0", Offset = "0x6D1D2C0", VA = "0x186D1E8C0")]
	public long CFHIJKLBANJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F4D0", Offset = "0x6D1DED0", VA = "0x186D1F4D0")]
	public PFEHBCABIHA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GKPBCPLMPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int DODFNFMGIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int OBCPODAKCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float NCIDADLBLPM;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<NOLHNIEMBFE> PPHAFHHILMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D12A90", Offset = "0x6D11490", VA = "0x186D12A90")]
	public GKPBCPLMPDF(int DODFNFMGIDO, int OBCPODAKCPN, float JNJCAHFAFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D129E0", Offset = "0x6D113E0", VA = "0x186D129E0")]
	public void PDECDGGKKCD(DIHKHHEEMOJ LPMKEAECOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D126C0", Offset = "0x6D110C0", VA = "0x186D126C0")]
	private int GNGPDHEPDKE(JLEFEAOFDEC OFGAFPGJIKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D12770", Offset = "0x6D11170", VA = "0x186D12770")]
	private void PDECDGGKKCD(JLEFEAOFDEC OFGAFPGJIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D12620", Offset = "0x6D11020", VA = "0x186D12620")]
	private void CMAMPEOEBGL(JLEFEAOFDEC OFGAFPGJIKO, NOLHNIEMBFE AMOCEPOIHBE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HLEMMNCDCME
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FEGENGGPAGE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
			[DebuggerHidden]
			public FEGENGGPAGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D10BB0", Offset = "0x6D0F5B0", VA = "0x186D10BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D10D70", Offset = "0x6D0F770", VA = "0x186D10D70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6D10CC0", Offset = "0x6D0F6C0", VA = "0x186D10CC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D10CC0", Offset = "0x6D0F6C0", VA = "0x186D10CC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MIIDNDCKCLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6D10170", Offset = "0x6D0EB70", VA = "0x186D10170", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<LCEOEFEEDBM> INJJNHFELGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6D10150", Offset = "0x6D0EB50", VA = "0x186D10150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> PJHJODPFLEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NOLHNIEMBFE IANNELJHPEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KKPOMKCHABI JCIMNDBKFFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(KKPOMKCHABI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7A0", Offset = "0x8AE1A0", VA = "0x1808AF7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool OBCFHPEJLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x20B2280", Offset = "0x20B0C80", VA = "0x1820B2280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E730", Offset = "0x6D0D130", VA = "0x186D0E730")]
		public static ClusterMeshRenderer Create(NOLHNIEMBFE JMPEEMGIIHN, ClusterMeshRenderer NFIFBOILHAI, MeshFilter NNKMILFCOOL, EFEILIAEILL ELFANOAFHKM, KKPOMKCHABI FLMAECPLNCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E9A0", Offset = "0x6D0D3A0", VA = "0x186D0E9A0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F490", Offset = "0x6D0DE90", VA = "0x186D0F490", Slot = "9")]
		public bool TryRemoveClusterLODComponent(OIHACEDCJKJ LHCHHCODKCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F240", Offset = "0x6D0DC40", VA = "0x186D0F240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EED0", Offset = "0x6D0D8D0", VA = "0x186D0EED0")]
		public void Init(NOLHNIEMBFE JMPEEMGIIHN, MeshFilter NNKMILFCOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EA00", Offset = "0x6D0D400", VA = "0x186D0EA00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F550", Offset = "0x6D0DF50", VA = "0x186D0F550", Slot = "7")]
		public void UpdateClusterDistances(Vector3 BODEELBOMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F800", Offset = "0x6D0E200", VA = "0x186D0F800", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EE50", Offset = "0x6D0D850", VA = "0x186D0EE50")]
		[IteratorStateMachine(typeof(FEGENGGPAGE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F2D0", Offset = "0x6D0DCD0", VA = "0x186D0F2D0")]
		public void SetupTagAndLayer(string KLBPNCLBHIJ, int FLMAECPLNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F2B0", Offset = "0x6D0DCB0", VA = "0x186D0F2B0")]
		public bool Remove(OIHACEDCJKJ LHCHHCODKCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OEEBIEPNPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int LAGNOPFMLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FMCLGEDFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PIGMEJDKNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int GACOPDJBCOH;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E810", Offset = "0x6D1D210", VA = "0x186D1E810")]
	public OEEBIEPNPAD(int FMCLGEDFPEP, int PIGMEJDKNKC, int LAGNOPFMLKO, int GACOPDJBCOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IEMJPHIJFAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> LCOCBHMDPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> CLCCLKJJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> HAKNLBHIDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<OEEBIEPNPAD> ADGLDAPGBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> JHBHNDCIJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> GEMGEABHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> ADECPOKOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle FGPOBPGGBEF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HBBOBABEAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xAD57D0", Offset = "0xAD41D0", VA = "0x180AD57D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAD6BD0", Offset = "0xAD55D0", VA = "0x180AD6BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D16D80", Offset = "0x6D15780", VA = "0x186D16D80")]
	public void IGMCENCOPJL(PNGDONJJIBJ FPKBPJFFLLG, NativeList<OEEBIEPNPAD> ADGLDAPGBFO, float ECGPBBOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D17C30", Offset = "0x6D16630", VA = "0x186D17C30")]
	public void NBAGEJJIELG(Transform ELFANOAFHKM, bool JHJNOJNGAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D17EC0", Offset = "0x6D168C0", VA = "0x186D17EC0")]
	public void PNPPGLFOGFO(NOLHNIEMBFE MIPAHIFMGBN, bool EBFLEEGCMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C70", Offset = "0x6D15670", VA = "0x186D16C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C40", Offset = "0x6D15640", VA = "0x186D16C40")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IEMJPHIJFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct PMHKHMJJDLL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> LCOCBHMDPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> CLCCLKJJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<OEEBIEPNPAD> HBNCODICJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> JHBHNDCIJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 HGNPDGKBMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> GEMGEABHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> ADECPOKOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool JHJNOJNGAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float JKBBLHMKLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float COBDLEMEJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float JBIBAGMCLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> HAKNLBHIDBB;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FE50", Offset = "0x6D1E850", VA = "0x186D1FE50")]
	public PMHKHMJJDLL(IEMJPHIJFAG BLICDAMPFAD, Vector3 HGNPDGKBMDD, bool JHJNOJNGAEE, float JKBBLHMKLJC, float COBDLEMEJHF, float JBIBAGMCLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F950", Offset = "0x6D1E350", VA = "0x186D1F950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OIHACEDCJKJ : HKEHBNJPOEG
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds LBDPICGCDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JLEFEAOFDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<OIHACEDCJKJ> GMNMIKLPCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public JLEFEAOFDEC NNFBEGDDJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public JLEFEAOFDEC HADOAAGFMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public JLEFEAOFDEC BBGJNHJMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int GACOPDJBCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds BFFLGPOAEBD;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D18060", Offset = "0x6D16A60", VA = "0x186D18060")]
	public JLEFEAOFDEC(List<OIHACEDCJKJ> GMNMIKLPCOG, [Optional] JLEFEAOFDEC NNFBEGDDJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DIHKHHEEMOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<JLEFEAOFDEC> BKFPELLEBBP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JLEFEAOFDEC BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D106C0", Offset = "0x6D0F0C0", VA = "0x186D106C0")]
	public DIHKHHEEMOJ(JLEFEAOFDEC ELFANOAFHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IDNJOJKBPAL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GGIEFMPNEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int EHAFMDCAPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int HAPBJGBFNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DEFDAHFHCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int EILBJNBFCDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KADBOCMCHGB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int MMHJJCGHAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float BHBLJCHIDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<OIHACEDCJKJ> GMNMIKLPCOG;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A580", Offset = "0x6D18F80", VA = "0x186D1A580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum OOMJCAGJCEO
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
	private GGIEFMPNEEO PBECKPCIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int BKGBNJIKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int DODFNFMGIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int OBCPODAKCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float JNJCAHFAFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float EPKGKGFJIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<JLEFEAOFDEC> MJAIEOOMIKC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DIHKHHEEMOJ IIGADDBIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D16BE0", Offset = "0x6D155E0", VA = "0x186D16BE0")]
	public IDNJOJKBPAL(int DODFNFMGIDO, int OBCPODAKCPN, float JNJCAHFAFNA, int BKGBNJIKGJO, float EPKGKGFJIJJ = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D14AD0", Offset = "0x6D134D0", VA = "0x186D14AD0")]
	public void COMFMKKNCJK(List<OIHACEDCJKJ> GMNMIKLPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D14CA0", Offset = "0x6D136A0", VA = "0x186D14CA0")]
	public bool JHOAGLJGOMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D14A80", Offset = "0x6D13480", VA = "0x186D14A80")]
	private float CJEEAENIGNB(Vector3 LAJFHIPPBIH, Vector3 APMEFBMNAML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D14A60", Offset = "0x6D13460", VA = "0x186D14A60")]
	private float CJEEAENIGNB(Vector3 LEGDMNLNDAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D14D10", Offset = "0x6D13710", VA = "0x186D14D10")]
	private bool LLFJJAHKMCL(JLEFEAOFDEC FDNBCKEOOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D15670", Offset = "0x6D14070", VA = "0x186D15670")]
	private KADBOCMCHGB MPNKNNPMLHE(List<OIHACEDCJKJ> NCIIIJEIIEJ, OOMJCAGJCEO EIDHFHHEGPC)
	{
		return default(KADBOCMCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D16800", Offset = "0x6D15200", VA = "0x186D16800")]
	private void PHPBGLBBLBL(List<OIHACEDCJKJ> GMNMIKLPCOG, Span<Vector3> ACFEFCKNDDI, Span<Vector3> MOEPEEFINPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class MHJLLCDBCBI
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A820", Offset = "0x6D19220", VA = "0x186D1A820")]
	public static Bounds BGHEFEJHIAE(List<OIHACEDCJKJ> GMNMIKLPCOG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A9F0", Offset = "0x6D193F0", VA = "0x186D1A9F0")]
	public static int LIEFELFHCFC(List<OIHACEDCJKJ> GMNMIKLPCOG, JMOMLIAKNIG CDLBFFAEOBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class PGKCPJHFOLI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool MBPKMDAOKLC(float4* BIKINIDKOMC, int JGKAMGBGMHI);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class DBKEMMAIAPK
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr AKIGLNJDJIN;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr ANBPBHJGJFO;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D10500", Offset = "0x6D0EF00", VA = "0x186D10500")]
		[BurstDiscard]
		private static void KEHGOLEFHHC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D101D0", Offset = "0x6D0EBD0", VA = "0x186D101D0")]
		private static IntPtr BAMLOHECMNL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D10620", Offset = "0x6D0F020", VA = "0x186D10620")]
		public static void NMGGIIPGNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
		public static void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D10320", Offset = "0x6D0ED20", VA = "0x186D10320")]
		public unsafe static bool GHJBKJMLHEK(float4* BIKINIDKOMC, int JGKAMGBGMHI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F740", Offset = "0x6D1E140", VA = "0x186D1F740")]
	[BurstCompile]
	public unsafe static bool AHGGAELGIHK(float4* BIKINIDKOMC, int JGKAMGBGMHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A1E0", Offset = "0x6D08BE0", VA = "0x186D0A1E0")]
	[BurstCompile]
	public unsafe static bool FBGGBADFLHJ(float4* BIKINIDKOMC, int JGKAMGBGMHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct JNMKBJEKNBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> DDCBJBGNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> JJDJEJOPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> FDFFGNKJAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> OHFBDNOBJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> IFDNGGFFPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> CKGEHNBPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> FMKJBGBAOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> LJIJKEDHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<PNGDONJJIBJ.HLIHKGNGLCP> LNBCLEJLBJN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D19660", Offset = "0x6D18060", VA = "0x186D19660")]
	public JNMKBJEKNBP(PNGDONJJIBJ IBOMPOHKALF, NativeArray<bool> FMKJBGBAOGA, NativeList<ushort> LJIJKEDHCLM, NativeList<PNGDONJJIBJ.HLIHKGNGLCP> LNBCLEJLBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D193B0", Offset = "0x6D17DB0", VA = "0x186D193B0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct JMHEJDJPIBH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> DDCBJBGNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> JJDJEJOPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> FDFFGNKJAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> OHFBDNOBJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> IFDNGGFFPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> CKGEHNBPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> DMIDGHKFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> IAOAEHPHBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> KOLHNLJAJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> NJFLLJEHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> DMAGLGONCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> JJNLICFELME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> FMKJBGBAOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> LJIJKEDHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<PNGDONJJIBJ.HLIHKGNGLCP> LNBCLEJLBJN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D192F0", Offset = "0x6D17CF0", VA = "0x186D192F0")]
	public JMHEJDJPIBH(PNGDONJJIBJ IBOMPOHKALF, PNGDONJJIBJ FBMDNADKLED, NativeArray<bool> FMKJBGBAOGA, NativeList<ushort> LJIJKEDHCLM, NativeList<PNGDONJJIBJ.HLIHKGNGLCP> LNBCLEJLBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D18E20", Offset = "0x6D17820", VA = "0x186D18E20", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HNFNNCICLLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PNGDONJJIBJ OMPBLGALOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PNGDONJJIBJ IBOMPOHKALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> MLGGFFAINDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> LJIJKEDHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<PNGDONJJIBJ.HLIHKGNGLCP> LNBCLEJLBJN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static PNGDONJJIBJ AKOPCEOEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private INIFEPOOGKJ IJNLKAKJHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private GJOHKPHJKBE PEKBIFNLJPI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle FGPOBPGGBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB20", Offset = "0xAE9520", VA = "0x180AEAB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NOLHNIEMBFE.IAFALFIMNIB FDNBCKEOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FEAOFECGOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1C0CFA0", Offset = "0x1C0B9A0", VA = "0x181C0CFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D12AE0", Offset = "0x6D114E0", VA = "0x186D12AE0")]
	[MDNJIPDCAGH(CHEIGNPGAPJ.EnteredEditMode, 0)]
	private static void BPNPFFCGOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D12C60", Offset = "0x6D11660", VA = "0x186D12C60")]
	public void IGMCENCOPJL(NOLHNIEMBFE.IAFALFIMNIB HBNCODICJLB, Transform ABPLLJJAHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D13780", Offset = "0x6D12180", VA = "0x186D13780")]
	public void NBENOBHEJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B90", Offset = "0x6D11590", VA = "0x186D12B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B50", Offset = "0x6D11550", VA = "0x186D12B50")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D14040", Offset = "0x6D12A40", VA = "0x186D14040")]
	public HNFNNCICLLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HOHNPKODOIM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 CGJAACOEEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ENDOMDKEHNI
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(FILMNPNNHPJ<string>.EEFAEMIIABD NHEMMLNKJHP, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CNBDOENGMLA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNBDOENGMLA PFGBAPCHGNM(Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNBDOENGMLA IKLOJDANPNJ(Action EFFBNJEBEKP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class NDNMFCFCKLG : CNBDOENGMLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class GCIMBCNEMNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public NDNMFCFCKLG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
				public GCIMBCNEMNG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x6D124D0", Offset = "0x6D10ED0", VA = "0x186D124D0")]
				internal void KNIMIHCKACM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x6D12520", Offset = "0x6D10F20", VA = "0x186D12520")]
				internal void LGPBIOHLDJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x6D12480", Offset = "0x6D10E80", VA = "0x186D12480")]
				internal void HIBJBNENAIO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> PEMGKCBBKJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action GMMFHFGOKDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action AGKLCFHDMLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private ONFGNIMICIM DNOFDCNBKOH;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GPBAKCNJPNC
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action JHIOCNMCKFN
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4248370", Offset = "0x4246D70", VA = "0x184248370", Slot = "4")]
			public CNBDOENGMLA PFGBAPCHGNM(Action EFFBNJEBEKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x679B840", Offset = "0x679A240", VA = "0x18679B840", Slot = "5")]
			public CNBDOENGMLA IKLOJDANPNJ(Action EFFBNJEBEKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
			public NDNMFCFCKLG(Func<JobHandle> HKKIJHGLNMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6D1ABC0", Offset = "0x6D195C0", VA = "0x186D1ABC0")]
			public void LDLLGDHEPIB(Action IFGDOAGCGLL, Action PPKAPOOEKJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6D1AE80", Offset = "0x6D19880", VA = "0x186D1AE80")]
			public void PJOABDGMIKH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class OFGLNMANIPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public CNBDOENGMLA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OFGLNMANIPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6D1E830", Offset = "0x6D1D230", VA = "0x186D1E830")]
			internal bool ILBGLEHAAFB(NDNMFCFCKLG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class KABGHMBHOJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public NDNMFCFCKLG newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public KABGHMBHOJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6D1A520", Offset = "0x6D18F20", VA = "0x186D1A520")]
			internal void LBFCCEEECBG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<NDNMFCFCKLG> PPEOEIAFBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<NDNMFCFCKLG> AOAKFPCPDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private OIMBFIPCENK AFJEIEEOCHJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public JKLIJPIEKIF IBLIDFDOBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D196D0", Offset = "0x6D180D0", VA = "0x186D196D0")]
		public CNBDOENGMLA Add(Func<JobHandle> HKKIJHGLNMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D19A00", Offset = "0x6D18400", VA = "0x186D19A00")]
		public void Remove(CNBDOENGMLA FGPOBPGGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D19830", Offset = "0x6D18230", VA = "0x186D19830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D19BE0", Offset = "0x6D185E0", VA = "0x186D19BE0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D19E40", Offset = "0x6D18840", VA = "0x186D19E40")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D19820", Offset = "0x6D18220", VA = "0x186D19820")]
		[CompilerGenerated]
		private void IJLCPIEILEC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ONFGNIMICIM
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONFGNIMICIM PFGBAPCHGNM(Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONFGNIMICIM INIBLHIGCHO(Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONFGNIMICIM IKLOJDANPNJ(Action EFFBNJEBEKP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class GGONECIPGEC : ONFGNIMICIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private JobHandle KDOIBBBEPDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private Action GMMFHFGOKDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private Action OIBEKBFKJPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action JHIOCNMCKFN;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public bool OEMBJOBGAJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x6D125C0", Offset = "0x6D10FC0", VA = "0x186D125C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x66C2570", Offset = "0x66C0F70", VA = "0x1866C2570", Slot = "4")]
			public ONFGNIMICIM PFGBAPCHGNM(Action EFFBNJEBEKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x66C2590", Offset = "0x66C0F90", VA = "0x1866C2590", Slot = "5")]
			public ONFGNIMICIM INIBLHIGCHO(Action EFFBNJEBEKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x679B840", Offset = "0x679A240", VA = "0x18679B840", Slot = "6")]
			public ONFGNIMICIM IKLOJDANPNJ(Action EFFBNJEBEKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xACC4C0", Offset = "0xACAEC0", VA = "0x180ACC4C0")]
			public GGONECIPGEC(JobHandle NLJONNAIHOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6D12570", Offset = "0x6D10F70", VA = "0x186D12570")]
			public void BFPGNFDAILF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6D125D0", Offset = "0x6D10FD0", VA = "0x186D125D0")]
			public void PJOABDGMIKH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<GGONECIPGEC> INPLKLAPHPM;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A340", Offset = "0x6D18D40", VA = "0x186D1A340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D19F20", Offset = "0x6D18920", VA = "0x186D19F20")]
		public ONFGNIMICIM Add(JobHandle NLJONNAIHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A240", Offset = "0x6D18C40", VA = "0x186D1A240")]
		public void Remove(ONFGNIMICIM FGPOBPGGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A090", Offset = "0x6D18A90", VA = "0x186D1A090", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6D19FC0", Offset = "0x6D189C0", VA = "0x186D19FC0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A480", Offset = "0x6D18E80", VA = "0x186D1A480")]
		public JobTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FF20", Offset = "0x6D1E920", VA = "0x186D1FF20")]
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
