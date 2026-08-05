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
				[Cpp2IlInjected.Address(RVA = "0x607A460", Offset = "0x6079060", VA = "0x18607A460")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1488190", Offset = "0x1486D90", VA = "0x181488190")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x607A420", Offset = "0x6079020", VA = "0x18607A420")]
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
		[Cpp2IlInjected.Address(RVA = "0x6072BD0", Offset = "0x60717D0", VA = "0x186072BD0")]
		public LODSettings FCNMFFIHFLG(KFDHMOGJMKH BFGFFBDCNOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6072BE0", Offset = "0x60717E0", VA = "0x186072BE0")]
		public int GIALFPAPDEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6072C00", Offset = "0x6071800", VA = "0x186072C00")]
		public int HDFAGJFHJJC(bool MHGEFMFBJDA, Vector3 JFNLLFGGDPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6072CA0", Offset = "0x60718A0", VA = "0x186072CA0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OOPAIFIGPEA
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
public interface OAEJEBKNBPD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHGAPECPEIE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IICDOCEFDDP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ALOLDCLHBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<GLMMEOLIICI> HLBOHFOMIJE
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
	void UpdateClusterDistances(Vector3 IMBPOLOMLBB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(JMBDACBPMHA AHNMMBDFHCD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GLMMEOLIICI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int IHHMCBLHJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int GMNKFHGPKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PLBLFPGODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float HNLOMKFODKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte COBLLHCHPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ONMMOANONDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OPFIFPFKLLD
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
	private struct MMCNLKCBPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ONMMOANONDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x607A4A0", Offset = "0x60790A0", VA = "0x18607A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x607AC30", Offset = "0x6079830", VA = "0x18607AC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JMLMNGACKKO : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ONMMOANONDD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public JMLMNGACKKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6077430", Offset = "0x6076030", VA = "0x186077430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60774B0", Offset = "0x60760B0", VA = "0x1860774B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BHLJMGENGGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ONMMOANONDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x606EE70", Offset = "0x606DA70", VA = "0x18606EE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60706B0", Offset = "0x606F2B0", VA = "0x1860706B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OCACIMOKCDP : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private BILDDJDOJHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ONMMOANONDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
		[DebuggerHidden]
		public OCACIMOKCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x607B740", Offset = "0x607A340", VA = "0x18607B740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x607C420", Offset = "0x607B020", VA = "0x18607C420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int KKLFINBFPPF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan OGAHHBNGIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer MLPILIKGEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter ANNNLFBMGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DFNGLDBEKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JMCPECOGNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NKBGNJINPFH NILONENGNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JMBDACBPMHA> PBPDGHMIEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JMBDACBPMHA> ACMKNDIAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JMBDACBPMHA> GHENKAKGHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BDEIHLHNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OPFIFPFKLLD CIPFLJPFKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<IICDOCEFDDP>[] GPMENGEFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<GLMMEOLIICI>[] HHDJDHAGACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource IODGDBBGCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool DFAKDBBNBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private DIJEKGOINOG EGOEAFMKLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DIJEKGOINOG NHIDPMKPGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int OKCJDHAPPDK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static ONMMOANONDD PLDFAIHMAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FAKDPBAMGGD GIGFDIEPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FMGHKHKLHLN LNEEDCPLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour AAMPGHMJHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material OAAIAFMHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<OAEJEBKNBPD> HAJHFOGEGNP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig IPFAONGAAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 CFDDBJOGFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C2230", Offset = "0x7C0E30", VA = "0x1807C2230")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C10", Offset = "0x7C0810", VA = "0x1807C1C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private OPFIFPFKLLD LJPNKOHBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8785B0", Offset = "0x8771B0", VA = "0x1808785B0")]
		get
		{
			return default(OPFIFPFKLLD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x607E2E0", Offset = "0x607CEE0", VA = "0x18607E2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ONMMOANONDD EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x607E7C0", Offset = "0x607D3C0", VA = "0x18607E7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool AHPHGCGBPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x607EBC0", Offset = "0x607D7C0", VA = "0x18607EBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool EKHFCCGDDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x607D080", Offset = "0x607BC80", VA = "0x18607D080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> PEAOPJLGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x607CFC0", Offset = "0x607BBC0", VA = "0x18607CFC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x607DB30", Offset = "0x607C730", VA = "0x18607DB30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EBKBGFGJONB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x607F6E0", Offset = "0x607E2E0", VA = "0x18607F6E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x607E710", Offset = "0x607D310", VA = "0x18607E710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x607F920", Offset = "0x607E520", VA = "0x18607F920")]
	public ONMMOANONDD(FAKDPBAMGGD GIGFDIEPNNG, FMGHKHKLHLN LNEEDCPLPBM, ClusterLODConfig FEJGNLAAJBA, MonoBehaviour AAMPGHMJHKH, Material OAAIAFMHOBA, ClusterMeshRenderer MLPILIKGEDF, MeshFilter ANNNLFBMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x607D690", Offset = "0x607C290", VA = "0x18607D690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x607CEC0", Offset = "0x607BAC0", VA = "0x18607CEC0")]
	public static void AANEPMDBONB(Vector3 PMPIGEFGEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x607DBF0", Offset = "0x607C7F0", VA = "0x18607DBF0")]
	private void JCAJAECMCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x607DA60", Offset = "0x607C660", VA = "0x18607DA60")]
	private void HEANKBPAEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x607D140", Offset = "0x607BD40", VA = "0x18607D140")]
	private void BOMLICKJKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x607DC80", Offset = "0x607C880", VA = "0x18607DC80")]
	public void JCMDLOLFFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x607EDC0", Offset = "0x607D9C0", VA = "0x18607EDC0")]
	[AsyncStateMachine(typeof(MMCNLKCBPMK))]
	public Task OKJJGJBNJAN(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x607CE40", Offset = "0x607BA40", VA = "0x18607CE40")]
	[IteratorStateMachine(typeof(JMLMNGACKKO))]
	private IEnumerator<BILDDJDOJHA> AAEAHKFPAMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x607F790", Offset = "0x607E390", VA = "0x18607F790")]
	[AsyncStateMachine(typeof(BHLJMGENGGI))]
	private Task PKMABCHHOEO(DBCLHGHLEMD<string>.OGCCDEKKEPE GCFBLCACBAH, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x607E810", Offset = "0x607D410", VA = "0x18607E810")]
	public void LJOGIOPANAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x607D7A0", Offset = "0x607C3A0", VA = "0x18607D7A0")]
	public void EIADLLFBIHJ(IEnumerable<IICDOCEFDDP> NDNFCNFKMEI, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x607E410", Offset = "0x607D010", VA = "0x18607E410")]
	public void JMNNLGHPMCI(IEnumerable<IICDOCEFDDP> NDNFCNFKMEI, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x607EEE0", Offset = "0x607DAE0", VA = "0x18607EEE0")]
	public List<ClusterMeshRenderer> OODBPCBKIDB(List<JMBDACBPMHA> DGEPINPHMEG, CMLIHGNKANO EBCHPMPLBLG, OOPAIFIGPEA LCLEPNJJEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x607EA10", Offset = "0x607D610", VA = "0x18607EA10")]
	public void MACDMJPEAGI(OAEJEBKNBPD EPICJHKIEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x607DA00", Offset = "0x607C600", VA = "0x18607DA00")]
	public bool HBEDGLKPOKD(OAEJEBKNBPD EPICJHKIEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x607D400", Offset = "0x607C000", VA = "0x18607D400")]
	public void DILLNLLHKEF(JMBDACBPMHA KEFCEHBBDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x607ECC0", Offset = "0x607D8C0", VA = "0x18607ECC0")]
	public void NJOPJBAFLFA(GLMMEOLIICI KIGGBMJEDEA, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x607D610", Offset = "0x607C210", VA = "0x18607D610")]
	public void DOAGLLIEPAO(GLMMEOLIICI KIGGBMJEDEA, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x607EA70", Offset = "0x607D670", VA = "0x18607EA70")]
	private void MCDJHOCDAIP(Vector3 IMBPOLOMLBB, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x607D820", Offset = "0x607C420", VA = "0x18607D820")]
	private void EILNAGFOFHE(Vector3 IMBPOLOMLBB, OOPAIFIGPEA LCLEPNJJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x607ED40", Offset = "0x607D940", VA = "0x18607ED40")]
	[IteratorStateMachine(typeof(OCACIMOKCDP))]
	private IEnumerator<BILDDJDOJHA> OCHFCGKKAJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x607D290", Offset = "0x607BE90", VA = "0x18607D290")]
	private int CMLGMFAGKCO(int PMIDLPOCCEE, int EPJBGDNGKLH, List<GLMMEOLIICI> JODECGCGHPF, byte BFGFFBDCNOA, int ANPFKAIFILI, float CMJBCAGLJOL = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x607D460", Offset = "0x607C060", VA = "0x18607D460")]
	public void DMBJGENFJDP(JMBDACBPMHA AHNMMBDFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x607D9C0", Offset = "0x607C5C0", VA = "0x18607D9C0")]
	public bool GPNIBIFOJGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8F41D0", Offset = "0x8F2DD0", VA = "0x1808F41D0")]
	public Material FLNBDJLMDFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x607D980", Offset = "0x607C580", VA = "0x18607D980")]
	public int GIALFPAPDEO()
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OLPJMOMMDIL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> JBPCJGMBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> LFBCKMHJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> CLLAABHAJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> LKBFJJNEFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> BCDMFKFOCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> NNJMGJKBKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 IAFINPAJDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float NJAKLMFEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> EKIGJNDAANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> JFBFDJJKFII;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x607CD80", Offset = "0x607B980", VA = "0x18607CD80")]
	public OLPJMOMMDIL(KGMILHEBHMD PLPNPKIPEIA, NativeList<float3> NNJMGJKBKAB, NativeParallelMultiHashMap<int, int> EKIGJNDAANL, NativeArray<int> JFBFDJJKFII, Vector3 IAFINPAJDJK, float NJAKLMFEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x607C680", Offset = "0x607B280", VA = "0x18607C680")]
	private int CJAAECIILLI(float3 IMBPOLOMLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x607CB10", Offset = "0x607B710", VA = "0x18607CB10")]
	private int IMCJGOPGGMF(int CFPNJHJGBGM, int CGGNJKGENIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x607C6E0", Offset = "0x607B2E0", VA = "0x18607C6E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IAGGDDPHEOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> EKIGJNDAANL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> JFBFDJJKFII;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int MCIHGGKJFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> DHKILOCJCMC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6076BD0", Offset = "0x60757D0", VA = "0x186076BD0")]
	public void FEFGOMAJBOH(int AIBNJIIJOPG, Allocator AIHLFFHGGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6076AF0", Offset = "0x60756F0", VA = "0x186076AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IAGGDDPHEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct LCGFPNDBMGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> GIJJBEHFOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> HKHDENNFIEK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6079B70", Offset = "0x6078770", VA = "0x186079B70")]
	public LCGFPNDBMGM(IAGGDDPHEOO BFHKILAIGNA, KGMILHEBHMD PLPNPKIPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6079AC0", Offset = "0x60786C0", VA = "0x186079AC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PDKLAPCHBHJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> DECMBOBGAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> CJEDPHCFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> MCCMOMILKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> LJBCNNMEPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> HCJNANIGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> DHKILOCJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> GIJJBEHFOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> PEBFGKFEDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> FGEILNNALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> LELOMNJLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> FNFDODOBKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> MPGGFLGJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> AMMDFKIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float JOEBOONGMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float EIPHJMJKKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 JDCJFPPHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float FIBFMLDENNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float NHNIIDBOIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float BFEIMLNJNAB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6081670", Offset = "0x6080270", VA = "0x186081670")]
	public PDKLAPCHBHJ(IAGGDDPHEOO LCEOLPEDPJH, KGMILHEBHMD PLPNPKIPEIA, KGMILHEBHMD DDBDMCLGEEE, float NHNIIDBOIKK, float BFEIMLNJNAB, Vector3 JDCJFPPHFFA, float FIBFMLDENNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6080F80", Offset = "0x607FB80", VA = "0x186080F80")]
	private float3 HELGICAOJHN(int CFPNJHJGBGM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6080340", Offset = "0x607EF40", VA = "0x186080340")]
	private void COCLDFLLIJM(int CFPNJHJGBGM, [Out] float3 FAJEBFKJCFN, [Out] float3 GNBNLJJJNFD, [Out] float4 LIMIGHCDDOP, [Out] float4 NOPCMECFBBC, [Out] float2 GENIAPNAPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6081030", Offset = "0x607FC30", VA = "0x186081030")]
	private int HLLGJOBKOBC(int FDADFCDDFOD, int CLBHBEJACIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6081320", Offset = "0x607FF20", VA = "0x186081320")]
	private void NEJKEOECGPP(int FDADFCDDFOD, int CLBHBEJACIE, int FLCJHFDOIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6081520", Offset = "0x6080120", VA = "0x186081520")]
	private bool NMBECHEALJI(int FDADFCDDFOD, int CLBHBEJACIE, float MLOAILNHBGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6080EC0", Offset = "0x607FAC0", VA = "0x186080EC0")]
	private bool GOPAEJBNDHO(int FDADFCDDFOD, int CLBHBEJACIE, int FLCJHFDOIFJ, float MLOAILNHBGA, bool GPCLMHGNHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60800E0", Offset = "0x607ECE0", VA = "0x1860800E0")]
	private bool CAAMGMIPOBE(int FDADFCDDFOD, int CLBHBEJACIE, int FLCJHFDOIFJ, float MLOAILNHBGA, bool GPCLMHGNHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6080520", Offset = "0x607F120", VA = "0x186080520")]
	private void DCOFBFPMBEA(int FDADFCDDFOD, int CLBHBEJACIE, int FLCJHFDOIFJ, [Out] int PBKLLGACCCG, [Out] int BFAIFJDMMKA, [Out] int KBFNBMHLMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6080540", Offset = "0x607F140", VA = "0x186080540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JNNGEKPFAEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LFGOBDEPIGN : IDisposable, GLMMEOLIICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds PPDCGDMECJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<JMBDACBPMHA> DGEPINPHMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 KHMCLHGCMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 LJEFIIIAJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int OOMPAFHIHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KGMILHEBHMD FGNDIOMFPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IAGGDDPHEOO EEACDNIOOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform EBCHPMPLBLG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int LFCGNNEPGHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x607A2E0", Offset = "0x6078EE0", VA = "0x18607A2E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh FHNDOAGMCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh LMHJGAKEMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PLBLFPGODEA
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x111BDB0", Offset = "0x111A9B0", VA = "0x18111BDB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x571BF40", Offset = "0x571AB40", VA = "0x18571BF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte COBLLHCHPGB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1069480", Offset = "0x1068080", VA = "0x181069480")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1357DD0", Offset = "0x13569D0", VA = "0x181357DD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int IHHMCBLHJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7B0", Offset = "0xA4B3B0", VA = "0x180A4C7B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA4A470", Offset = "0xA49070", VA = "0x180A4A470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int GMNKFHGPKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD2BA30", Offset = "0xD2A630", VA = "0x180D2BA30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD2B5B0", Offset = "0xD2A1B0", VA = "0x180D2B5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float HNLOMKFODKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6079E80", Offset = "0x6078A80", VA = "0x186079E80", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6079EA0", Offset = "0x6078AA0", VA = "0x186079EA0")]
		public void HGHAKOFIMDN(KFDHMOGJMKH BFGFFBDCNOA, [Out] int NFCHPGGEIFI, [Out] int KKHAJNPICKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x607A110", Offset = "0x6078D10", VA = "0x18607A110")]
		public void IHNKOFHEKGB(KFDHMOGJMKH BFGFFBDCNOA, IGNFHCBPGKH BKHBJBAPFGN, int LADCOOJLAFA = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6079DE0", Offset = "0x60789E0", VA = "0x186079DE0")]
		public void GPKAJHPGCPF(Mesh PLPNPKIPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6079D50", Offset = "0x6078950", VA = "0x186079D50")]
		public void FFLBNGJMINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6079BA0", Offset = "0x60787A0", VA = "0x186079BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x607A320", Offset = "0x6078F20", VA = "0x18607A320")]
		public LFGOBDEPIGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds PPDCGDMECJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<LFGOBDEPIGN> NDEEJBEEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public CEJCDFGIEAH KNGFIBKGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer EGGCNLDBDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int BPJDNDNAAMN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NNHGEGDJDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FAFKFOPHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x879630", Offset = "0x878230", VA = "0x180879630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x961730", Offset = "0x960330", VA = "0x180961730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ALOLDCLHBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6078270", Offset = "0x6076E70", VA = "0x186078270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6077F30", Offset = "0x6076B30", VA = "0x186077F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6077F00", Offset = "0x6076B00", VA = "0x186077F00")]
	public int DOKHEMOLAGI(int HOEJHLMGOAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60788F0", Offset = "0x60774F0", VA = "0x1860788F0")]
	public void NHLKFKACJPO(GDGLICANJMK PGPOAIFNJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6077500", Offset = "0x6076100", VA = "0x186077500")]
	public void AJGGFKAAACM(Transform KPJEKNECPLO, bool CKLNKPFBNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60780B0", Offset = "0x6076CB0", VA = "0x1860780B0")]
	public bool JEFJCPBKJEH(bool JDGNCGIBGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60782C0", Offset = "0x6076EC0", VA = "0x1860782C0")]
	public void JGDMJFBAMOI(Transform EBCHPMPLBLG, bool CKLNKPFBNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6077C90", Offset = "0x6076890", VA = "0x186077C90")]
	public bool DMBJGENFJDP(JMBDACBPMHA AHNMMBDFHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6078AD0", Offset = "0x60776D0", VA = "0x186078AD0")]
	public JNNGEKPFAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NKBGNJINPFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<JNNGEKPFAEJ.LFGOBDEPIGN> AJKKOPOFDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private CPOGIGFLJGM ENACHLGIEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<JNNGEKPFAEJ.LFGOBDEPIGN> JOCCHDIIGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int DHKIDAIBGGD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x607B2E0", Offset = "0x6079EE0", VA = "0x18607B2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x607B360", Offset = "0x6079F60", VA = "0x18607B360")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x607AFE0", Offset = "0x6079BE0", VA = "0x18607AFE0")]
	public void BGJHDHHBMPP(JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO, Transform EBCHPMPLBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x607B100", Offset = "0x6079D00", VA = "0x18607B100")]
	public void DMBJGENFJDP(JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x607B3E0", Offset = "0x6079FE0", VA = "0x18607B3E0")]
	private JNNGEKPFAEJ.LFGOBDEPIGN MJDBBCOACIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x607AC90", Offset = "0x6079890", VA = "0x18607AC90")]
	private bool AAEDPJMEGMF(JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x607B0A0", Offset = "0x6079CA0", VA = "0x18607B0A0")]
	private void CCEFGGGPKPG(JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x607AD30", Offset = "0x6079930", VA = "0x18607AD30")]
	public bool AAOLFFBLFMI(JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x607AD60", Offset = "0x6079960", VA = "0x18607AD60")]
	public bool BBEBOIIGBMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x607B520", Offset = "0x607A120", VA = "0x18607B520")]
	private JNNGEKPFAEJ.LFGOBDEPIGN NCENFEAPPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x607B590", Offset = "0x607A190", VA = "0x18607B590")]
	public NKBGNJINPFH()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JAGCCDIGONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BFDHAPAINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int GPMPPJEILCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float ILJNCNIMBOI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<JNNGEKPFAEJ> OBPFGBBEFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60773E0", Offset = "0x6075FE0", VA = "0x1860773E0")]
	public JAGCCDIGONI(int BFDHAPAINCM, int GPMPPJEILCF, float DKGAAAMAMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6077040", Offset = "0x6075C40", VA = "0x186077040")]
	public void BJEHIBBPIGM(HAOIKENOKEM JKGINNPCHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6077330", Offset = "0x6075F30", VA = "0x186077330")]
	private int IOAPHKAMJMI(GDGLICANJMK FJKJNIMGBPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6076E30", Offset = "0x6075A30", VA = "0x186076E30")]
	private void BJEHIBBPIGM(GDGLICANJMK FJKJNIMGBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60770F0", Offset = "0x6075CF0", VA = "0x1860770F0")]
	private void EJDBGPFNCPM(GDGLICANJMK FJKJNIMGBPD, JNNGEKPFAEJ HHMMPDOGJHF)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, IICDOCEFDDP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OGJHCIGIAOD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
			[DebuggerHidden]
			public OGJHCIGIAOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x607C470", Offset = "0x607B070", VA = "0x18607C470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x607C630", Offset = "0x607B230", VA = "0x18607C630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x607C580", Offset = "0x607B180", VA = "0x18607C580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x607C580", Offset = "0x607B180", VA = "0x18607C580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ALOLDCLHBNA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6074160", Offset = "0x6072D60", VA = "0x186074160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<GLMMEOLIICI> HLBOHFOMIJE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6074140", Offset = "0x6072D40", VA = "0x186074140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> NDEEJBEEGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public JNNGEKPFAEJ NNHGEGDJDED
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public OOPAIFIGPEA NJGBENENGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(OOPAIFIGPEA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B6570", Offset = "0x7B5170", VA = "0x1807B6570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool JODAFHCOAFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x190A7B0", Offset = "0x19093B0", VA = "0x18190A7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6072D00", Offset = "0x6071900", VA = "0x186072D00")]
		public static ClusterMeshRenderer Create(JNNGEKPFAEJ PLPNPKIPEIA, ClusterMeshRenderer MLPILIKGEDF, MeshFilter ANNNLFBMGEC, CMLIHGNKANO EBCHPMPLBLG, OOPAIFIGPEA LCLEPNJJEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6072E70", Offset = "0x6071A70", VA = "0x186072E70", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60736C0", Offset = "0x60722C0", VA = "0x1860736C0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(JMBDACBPMHA AHNMMBDFHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6073470", Offset = "0x6072070", VA = "0x186073470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60730E0", Offset = "0x6071CE0", VA = "0x1860730E0")]
		public void Init(JNNGEKPFAEJ PLPNPKIPEIA, MeshFilter ANNNLFBMGEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6072ED0", Offset = "0x6071AD0", VA = "0x186072ED0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6073780", Offset = "0x6072380", VA = "0x186073780", Slot = "7")]
		public void UpdateClusterDistances(Vector3 IMBPOLOMLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6073A30", Offset = "0x6072630", VA = "0x186073A30", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6073060", Offset = "0x6071C60", VA = "0x186073060")]
		[IteratorStateMachine(typeof(OGJHCIGIAOD))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6073500", Offset = "0x6072100", VA = "0x186073500")]
		public void SetupTagAndLayer(string JBHAKCLHNCB, int LCLEPNJJEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x60734E0", Offset = "0x60720E0", VA = "0x1860734E0")]
		public bool Remove(JMBDACBPMHA AHNMMBDFHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MEEOMDFGDLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ADANBEHKCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int FAFMJOHFKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int KKHAJNPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NFCHPGGEIFI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x607A480", Offset = "0x6079080", VA = "0x18607A480")]
	public MEEOMDFGDLE(int FAFMJOHFKBE, int KKHAJNPICKG, int ADANBEHKCNG, int NFCHPGGEIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CEJCDFGIEAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> DHKILOCJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> BCDMFKFOCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<MEEOMDFGDLE> BOPFJINEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> JONEIJFCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> NMBFFFPGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> GHHPGIELFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle JAJDCBMGAHG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool INFBEJKIOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEF19A0", Offset = "0xEF05A0", VA = "0x180EF19A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCEDAE0", Offset = "0xCEC6E0", VA = "0x180CEDAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6070AE0", Offset = "0x606F6E0", VA = "0x186070AE0")]
	public void IKHOBAFCBDI(KGMILHEBHMD ILBOIIIFLHF, NativeList<MEEOMDFGDLE> BOPFJINEBOI, float LFFGFMIPECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6070710", Offset = "0x606F310", VA = "0x186070710")]
	public void AGAFDCAKIAI(Transform EBCHPMPLBLG, bool CKLNKPFBNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6071940", Offset = "0x6070540", VA = "0x186071940")]
	public void JEFJCPBKJEH(JNNGEKPFAEJ EGGCNLDBDMK, bool JDGNCGIBGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x60709A0", Offset = "0x606F5A0", VA = "0x1860709A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6070AB0", Offset = "0x606F6B0", VA = "0x186070AB0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CEJCDFGIEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct DOAIJADMLKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> LONJONBONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> DHKILOCJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<MEEOMDFGDLE> HIJGJCMOOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> JONEIJFCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 JDCJFPPHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> NMBFFFPGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> GHHPGIELFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool CKLNKPFBNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float PNCOJJHCLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float BIPBKNIFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float HBILBAHJLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> BCDMFKFOCMN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60746E0", Offset = "0x60732E0", VA = "0x1860746E0")]
	public DOAIJADMLKP(CEJCDFGIEAH PFKMBMOAOKN, Vector3 JDCJFPPHFFA, bool CKLNKPFBNJG, float PNCOJJHCLBN, float BIPBKNIFJGB, float HBILBAHJLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60741D0", Offset = "0x6072DD0", VA = "0x1860741D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JMBDACBPMHA : BALMBPFCHAP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds GLNACOLHHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GDGLICANJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<JMBDACBPMHA> DGEPINPHMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public GDGLICANJMK MJOMMKLGFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public GDGLICANJMK HAJMFDIDEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public GDGLICANJMK HMDHBPHAGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int NFCHPGGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds PPDCGDMECJO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6076550", Offset = "0x6075150", VA = "0x186076550")]
	public GDGLICANJMK(List<JMBDACBPMHA> DGEPINPHMEG, [Optional] GDGLICANJMK MJOMMKLGFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HAOIKENOKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<GDGLICANJMK> GHEPCHGMBDF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GDGLICANJMK IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6076A20", Offset = "0x6075620", VA = "0x186076A20")]
	public HAOIKENOKEM(GDGLICANJMK EBCHPMPLBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FEPKEPGNBPB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GIBGDKDJANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NHHOJOOODNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int MCFLMKFLOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int FNDDDIIFFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OFGJJEPIEMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct PFFIAMMIDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int EJINEMCFACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float IOJODNAGMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<JMBDACBPMHA> DGEPINPHMEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JEFBAOCOMPE
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
	private GIBGDKDJANG LPBPNELBFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int HPMOIHMNMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int BFDHAPAINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int GPMPPJEILCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float DKGAAAMAMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float MBEDAKOHLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<GDGLICANJMK> EFBOLNEOIBO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HAOIKENOKEM BIGKKLHHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6076150", Offset = "0x6074D50", VA = "0x186076150")]
	public FEPKEPGNBPB(int BFDHAPAINCM, int GPMPPJEILCF, float DKGAAAMAMJB, int HPMOIHMNMEA, float MBEDAKOHLAK = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60747B0", Offset = "0x60733B0", VA = "0x1860747B0")]
	public void ELEPGEDCNCE(List<JMBDACBPMHA> DGEPINPHMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60760E0", Offset = "0x6074CE0", VA = "0x1860760E0")]
	public bool ONHDJNMJFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6074D80", Offset = "0x6073980", VA = "0x186074D80")]
	private float LOHLPFOFFCH(Vector3 FJELBKILIHM, Vector3 HBEDOPKLFLD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6074DD0", Offset = "0x60739D0", VA = "0x186074DD0")]
	private float LOHLPFOFFCH(Vector3 JKNAAACFMKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6075910", Offset = "0x6074510", VA = "0x186075910")]
	private bool NJHCNLCFJAI(GDGLICANJMK EAFEDIMCOKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6074DF0", Offset = "0x60739F0", VA = "0x186074DF0")]
	private PFFIAMMIDJB MKIAFGDIACG(List<JMBDACBPMHA> GMOEJPFGLFB, JEFBAOCOMPE EEICHFIGMLH)
	{
		return default(PFFIAMMIDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6074980", Offset = "0x6073580", VA = "0x186074980")]
	private void FKNLBFPFKLL(List<JMBDACBPMHA> DGEPINPHMEG, Vector3[] LJLFFGBPDJF, Vector3[] IJLOKOMDDED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class FJCHDICBPHC
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6076380", Offset = "0x6074F80", VA = "0x186076380")]
	public static Bounds EKBIGGDOOFG(List<JMBDACBPMHA> DGEPINPHMEG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60761B0", Offset = "0x6074DB0", VA = "0x1860761B0")]
	public static int CALHMJGFNGI(List<JMBDACBPMHA> DGEPINPHMEG, KFDHMOGJMKH BFGFFBDCNOA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CPOGIGFLJGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private KGMILHEBHMD OLMMLGFCMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KGMILHEBHMD LLEKECKHEBJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static KGMILHEBHMD DJGJMINOLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private BAAKBJMPNGG BOCPECLDIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IGNFHCBPGKH BKHBJBAPFGN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle JAJDCBMGAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84C930", VA = "0x18084DD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JNNGEKPFAEJ.LFGOBDEPIGN EAFEDIMCOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IKCPMOAENPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5210DA0", Offset = "0x520F9A0", VA = "0x185210DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6072AA0", Offset = "0x60716A0", VA = "0x186072AA0")]
	[EMFKCIBAEDI(ENEGNGGCDCE.ExitingPlayMode, 0)]
	private static void MLIOMJIDBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6072200", Offset = "0x6070E00", VA = "0x186072200")]
	public void IKHOBAFCBDI(JNNGEKPFAEJ.LFGOBDEPIGN HIJGJCMOOAG, Transform BFFNPNFFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6071AE0", Offset = "0x60706E0", VA = "0x186071AE0")]
	public void DPEPINENLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6072150", Offset = "0x6070D50", VA = "0x186072150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60721C0", Offset = "0x6070DC0", VA = "0x1860721C0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6072B20", Offset = "0x6071720", VA = "0x186072B20")]
	public CPOGIGFLJGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FMGHKHKLHLN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 IGKHPMILAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FAKDPBAMGGD
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(DBCLHGHLEMD<string>.OGCCDEKKEPE GCFBLCACBAH, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EGFNGEPKMMH
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGFNGEPKMMH FPIFLMCMIHP(Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGFNGEPKMMH OHIJLILCNJF(Action ODKDNEPMNIA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class GIHCJDLAEDP : EGFNGEPKMMH
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class KFMPJKAPPDG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public GIHCJDLAEDP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public KFMPJKAPPDG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6079A20", Offset = "0x6078620", VA = "0x186079A20")]
				internal void JKNIEOJDCJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6079A70", Offset = "0x6078670", VA = "0x186079A70")]
				internal void NHJOAGGGLCF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x60799D0", Offset = "0x60785D0", VA = "0x1860799D0")]
				internal void IJKKOOJHIPD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> KLONKEPMDAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action BBFNGPJOKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action IFJBMKEIGGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private LNEIJGKNJEI PANHLDOICHL;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action CMHJJMJKANA
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action JBFEALHJEFL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3736DB0", Offset = "0x37359B0", VA = "0x183736DB0", Slot = "4")]
			public EGFNGEPKMMH FPIFLMCMIHP(Action ODKDNEPMNIA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5B57600", Offset = "0x5B56200", VA = "0x185B57600", Slot = "5")]
			public EGFNGEPKMMH OHIJLILCNJF(Action ODKDNEPMNIA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
			public GIHCJDLAEDP(Func<JobHandle> ELIGHKGGBAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6076760", Offset = "0x6075360", VA = "0x186076760")]
			public void EDEDADACBKL(Action CFMGCIEFLHL, Action IBMELDDDDLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x60765D0", Offset = "0x60751D0", VA = "0x1860765D0")]
			public void DMBJGENFJDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class DEMGAHJJPOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public EGFNGEPKMMH jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public DEMGAHJJPOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x60741C0", Offset = "0x6072DC0", VA = "0x1860741C0")]
			internal bool IPPGPKOEDOL(GIHCJDLAEDP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class IMEGBOJKLEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public GIHCJDLAEDP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public IMEGBOJKLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6076DD0", Offset = "0x60759D0", VA = "0x186076DD0")]
			internal void KIGGHJOFAEK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<GIHCJDLAEDP> AAPPEJHKMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<GIHCJDLAEDP> NADJKFDDBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DIJEKGOINOG LBEADAAIMAN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public PFBIGNIPMCM OONDHHBCBIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6078BA0", Offset = "0x60777A0", VA = "0x186078BA0")]
		public EGFNGEPKMMH Add(Func<JobHandle> ELIGHKGGBAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6078EC0", Offset = "0x6077AC0", VA = "0x186078EC0")]
		public void Remove(EGFNGEPKMMH JAJDCBMGAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6078CF0", Offset = "0x60778F0", VA = "0x186078CF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6079090", Offset = "0x6077C90", VA = "0x186079090")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60792F0", Offset = "0x6077EF0", VA = "0x1860792F0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6078B90", Offset = "0x6077790", VA = "0x186078B90")]
		[CompilerGenerated]
		private void AKHCAGPOGLJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LNEIJGKNJEI
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNEIJGKNJEI FPIFLMCMIHP(Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNEIJGKNJEI EFGDIPOCKHI(Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNEIJGKNJEI OHIJLILCNJF(Action ODKDNEPMNIA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class POJMGKKKLMF : LNEIJGKNJEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle LILBPDIOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action BBFNGPJOKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action GDGBJFJNNGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action JBFEALHJEFL;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool LPKDIEFPNFP
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x6081800", Offset = "0x6080400", VA = "0x186081800")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A69E00", Offset = "0x5A68A00", VA = "0x185A69E00", Slot = "4")]
			public LNEIJGKNJEI FPIFLMCMIHP(Action ODKDNEPMNIA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A69E20", Offset = "0x5A68A20", VA = "0x185A69E20", Slot = "5")]
			public LNEIJGKNJEI EFGDIPOCKHI(Action ODKDNEPMNIA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B57600", Offset = "0x5B56200", VA = "0x185B57600", Slot = "6")]
			public LNEIJGKNJEI OHIJLILCNJF(Action ODKDNEPMNIA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1B8CC30", Offset = "0x1B8B830", VA = "0x181B8CC30")]
			public POJMGKKKLMF(JobHandle PLKDBIIGPBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6081810", Offset = "0x6080410", VA = "0x186081810")]
			public void OJKNFCBJGIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x60817B0", Offset = "0x60803B0", VA = "0x1860817B0")]
			public void DMBJGENFJDP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<POJMGKKKLMF> KMHHMDGFKBA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60797F0", Offset = "0x60783F0", VA = "0x1860797F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60793D0", Offset = "0x6077FD0", VA = "0x1860793D0")]
		public LNEIJGKNJEI Add(JobHandle PLKDBIIGPBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60796F0", Offset = "0x60782F0", VA = "0x1860796F0")]
		public void Remove(LNEIJGKNJEI JAJDCBMGAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6079540", Offset = "0x6078140", VA = "0x186079540", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6079470", Offset = "0x6078070", VA = "0x186079470")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6079930", Offset = "0x6078530", VA = "0x186079930")]
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
