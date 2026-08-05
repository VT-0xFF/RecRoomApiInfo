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
				[Cpp2IlInjected.Address(RVA = "0x5C34640", Offset = "0x5C32E40", VA = "0x185C34640")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x12EA490", Offset = "0x12E8C90", VA = "0x1812EA490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5C34600", Offset = "0x5C32E00", VA = "0x185C34600")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C2B2B0", Offset = "0x5C29AB0", VA = "0x185C2B2B0")]
		public LODSettings KFAOOADIKJJ(JNDHJMNFEHO OLLEBMKIFPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B1F0", Offset = "0x5C299F0", VA = "0x185C2B1F0")]
		public int GFIGPDCACJD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B210", Offset = "0x5C29A10", VA = "0x185C2B210")]
		public int GNJDJLCAKBA(bool NLGIJLAGMHG, Vector3 INAOCMIBCEJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B2C0", Offset = "0x5C29AC0", VA = "0x185C2B2C0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ANICBBHDKJJ
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
public interface ONDOKBJAAPK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPOMIBPANFD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MHNPJIOGHDF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JPNAJJMKCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JJAAKEFKIGP> MJIHIMLICGI
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
	void UpdateClusterDistances(Vector3 LHFDFHNAOOD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(FCNHNEPKNEN ENFAJMDKEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JJAAKEFKIGP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FDHHGOOKNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int GIIDIEBDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CBGLIFKNBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JNBPGFLPOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte FJHJGJFNMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ABPOCNEBOBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DPNKINADIEF
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
	private struct JOGJEEODLIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ABPOCNEBOBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5C32F50", Offset = "0x5C31750", VA = "0x185C32F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5C336E0", Offset = "0x5C31EE0", VA = "0x185C336E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CHJMPCKPLIK : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ABPOCNEBOBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public CHJMPCKPLIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B120", Offset = "0x5C29920", VA = "0x185C2B120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B1A0", Offset = "0x5C299A0", VA = "0x185C2B1A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JOANCEOEJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ABPOCNEBOBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5C316B0", Offset = "0x5C2FEB0", VA = "0x185C316B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5C32EF0", Offset = "0x5C316F0", VA = "0x185C32EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NLKFHJLEKEK : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ABPOCNEBOBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public NLKFHJLEKEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5C36390", Offset = "0x5C34B90", VA = "0x185C36390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5C37070", Offset = "0x5C35870", VA = "0x185C37070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EEIKAOHBFHM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan CEKNKJPMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer EPAMNMBGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter MMGKFKGCDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OJCEOECLLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject GLGNOCDBMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EMGLMDFPPDF MBDIGMEKKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<FCNHNEPKNEN> POLMCMKIDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<FCNHNEPKNEN> PIDJHADCEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<FCNHNEPKNEN> IFJGGLHFGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int NHPBKJPIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DPNKINADIEF BLNKJPHEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<MHNPJIOGHDF>[] HADENNBEENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<JJAAKEFKIGP>[] GBPPHDPDFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource FPAOPFIABCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool GNEMMEFNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private CEKHBJPKCPE EDAHDPEMBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CEKHBJPKCPE PJCBBGGPIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int AHDBMKEGJBC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static ABPOCNEBOBN CKEFBCOPKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LLDKNAOMIPO NNCNHEGPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CLOHMEIOJKO AIKBEIGKMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour HGPFIBAPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material IENHFACKLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<ONDOKBJAAPK> JDMMBKHNFMN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig CFDHEPDPNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 FCBKCOCHADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771BD0", VA = "0x1807733D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x773040", Offset = "0x771840", VA = "0x180773040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private DPNKINADIEF CMFLCIJAGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x954C50", Offset = "0x953450", VA = "0x180954C50")]
		get
		{
			return default(DPNKINADIEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C283C0", Offset = "0x5C26BC0", VA = "0x185C283C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ABPOCNEBOBN LNAOMADBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5C284F0", Offset = "0x5C26CF0", VA = "0x185C284F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool OAPNBLFLIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5C26FB0", Offset = "0x5C257B0", VA = "0x185C26FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BHCOIOPBKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E70", Offset = "0x5C25670", VA = "0x185C26E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LOOBBAFOBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5C28300", Offset = "0x5C26B00", VA = "0x185C28300")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28DB0", Offset = "0x5C275B0", VA = "0x185C28DB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CNACANCNDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5C27F90", Offset = "0x5C26790", VA = "0x185C27F90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C90", Offset = "0x5C26490", VA = "0x185C27C90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C29090", Offset = "0x5C27890", VA = "0x185C29090")]
	public ABPOCNEBOBN(LLDKNAOMIPO NNCNHEGPIBK, CLOHMEIOJKO AIKBEIGKMNA, ClusterLODConfig HGHDEDHNDMJ, MonoBehaviour HGPFIBAPDOC, Material IENHFACKLKJ, ClusterMeshRenderer EPAMNMBGEPC, MeshFilter MMGKFKGCDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C27AF0", Offset = "0x5C262F0", VA = "0x185C27AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C27E90", Offset = "0x5C26690", VA = "0x185C27E90")]
	public static void EJCHALHLJBM(Vector3 CMDGGBKAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C27C00", Offset = "0x5C26400", VA = "0x185C27C00")]
	private void ECILIOHILAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C27710", Offset = "0x5C25F10", VA = "0x185C27710")]
	private void CIGBJHDNKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C27D40", Offset = "0x5C26540", VA = "0x185C27D40")]
	private void EGHIOGPHIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C270B0", Offset = "0x5C258B0", VA = "0x185C270B0")]
	public void CGNEOPNFPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C280C0", Offset = "0x5C268C0", VA = "0x185C280C0")]
	[AsyncStateMachine(typeof(JOGJEEODLIL))]
	public Task FLEBFBKGLOA(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH, CancellationToken MHKFOCFJDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C28040", Offset = "0x5C26840", VA = "0x185C28040")]
	[IteratorStateMachine(typeof(CHJMPCKPLIK))]
	private IEnumerator<JCNDEIPBHJP> FHJEHMKAFCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C28AA0", Offset = "0x5C272A0", VA = "0x185C28AA0")]
	[AsyncStateMachine(typeof(JOANCEOEJLN))]
	private Task MHEDFHHBONA(GJGBNJADGMM<string>.NJLLNAPFMFK HIHIBJFCODK, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C28840", Offset = "0x5C27040", VA = "0x185C28840")]
	public void KKLCHKJAHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C26F30", Offset = "0x5C25730", VA = "0x185C26F30")]
	public void CFGAKPGKNNG(IEnumerable<MHNPJIOGHDF> MHECAAFJFHN, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C28540", Offset = "0x5C26D40", VA = "0x185C28540")]
	public void JGPAKMFHOEL(IEnumerable<MHNPJIOGHDF> MHECAAFJFHN, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C26670", Offset = "0x5C24E70", VA = "0x185C26670")]
	public List<ClusterMeshRenderer> BBJABOGCGMH(List<FCNHNEPKNEN> DGNAIPANHEG, FEDLPIHABFD KLOAHFNCDKG, ANICBBHDKJJ HAGBNKDONGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C277E0", Offset = "0x5C25FE0", VA = "0x185C277E0")]
	public void DEAEAEOCDJK(ONDOKBJAAPK GHKIPLHEJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C28A40", Offset = "0x5C27240", VA = "0x185C28A40")]
	public bool MDECEFOPGMM(ONDOKBJAAPK GHKIPLHEJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C28220", Offset = "0x5C26A20", VA = "0x185C28220")]
	public void GIEHNGFMPFK(FCNHNEPKNEN CNHOCLHJDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C265B0", Offset = "0x5C24DB0", VA = "0x185C265B0")]
	public void AHNMFBKALKA(JJAAKEFKIGP GCCCOPFGNBA, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C28280", Offset = "0x5C26A80", VA = "0x185C28280")]
	public void GPAPBIPNPNN(JJAAKEFKIGP GCCCOPFGNBA, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C279A0", Offset = "0x5C261A0", VA = "0x185C279A0")]
	private void DLCAHEHAING(Vector3 LHFDFHNAOOD, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5C27840", Offset = "0x5C26040", VA = "0x185C27840")]
	private void DJHPPKLFPGM(Vector3 LHFDFHNAOOD, ANICBBHDKJJ HAGBNKDONGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C28BC0", Offset = "0x5C273C0", VA = "0x185C28BC0")]
	[IteratorStateMachine(typeof(NLKFHJLEKEK))]
	private IEnumerator<JCNDEIPBHJP> MMFDBIJIAEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C28C40", Offset = "0x5C27440", VA = "0x185C28C40")]
	private int MNOBDECKELO(int ADMJKDLHPCI, int CFHHKMEMFAI, List<JJAAKEFKIGP> OMCLPAKEOEM, byte OLLEBMKIFPO, int ACBFFGCMFKL, float PEDBKGLCMIL = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C28E70", Offset = "0x5C27670", VA = "0x185C28E70")]
	public void OICBJJIPNIH(FCNHNEPKNEN ENFAJMDKEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C26630", Offset = "0x5C24E30", VA = "0x185C26630")]
	public bool APPMOAGDPGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x816EB0", Offset = "0x8156B0", VA = "0x180816EB0")]
	public Material IDAEPBEHGEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C281E0", Offset = "0x5C269E0", VA = "0x185C281E0")]
	public int GFIGPDCACJD()
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
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GMEJPBNFNIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> POANJPHPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> NEGDEAKCFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> BNAIGHFFEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> FHCHLLMEJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> MKHFJLJKPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> MBBDMHFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> FMLNKKCLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 NDAMAICENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float LPOGDMEJDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> MJKOEDJLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> OKDIADGFMME;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F970", Offset = "0x5C2E170", VA = "0x185C2F970")]
	public GMEJPBNFNIC(ANLJNALAKBD MPLECHMLAIA, NativeList<float3> FMLNKKCLGNH, NativeParallelMultiHashMap<int, int> MJKOEDJLLOA, NativeArray<int> OKDIADGFMME, Vector3 NDAMAICENBK, float LPOGDMEJDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F910", Offset = "0x5C2E110", VA = "0x185C2F910")]
	private int NMELILOOFJM(float3 LHFDFHNAOOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F270", Offset = "0x5C2DA70", VA = "0x185C2F270")]
	private int ECKIJELPGBF(int PBGHCEIGALN, int EBICOEDOGKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F4E0", Offset = "0x5C2DCE0", VA = "0x185C2F4E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PLGJNOIEKJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> MJKOEDJLLOA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> OKDIADGFMME;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int MDHPMNGBKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> EMANJDGEOLD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C38DB0", Offset = "0x5C375B0", VA = "0x185C38DB0")]
	public void LBMECFKLJDE(int NFBMPHODCPI, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C38CD0", Offset = "0x5C374D0", VA = "0x185C38CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PLGJNOIEKJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NNELNCFOLBB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> MKJEKBFOLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> ONHKFNKHHEO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C37260", Offset = "0x5C35A60", VA = "0x185C37260")]
	public NNELNCFOLBB(PLGJNOIEKJL GOBBBMOKEEF, ANLJNALAKBD MPLECHMLAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5C371B0", Offset = "0x5C359B0", VA = "0x185C371B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct NAJNBAPIPJJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> HBCMJEJEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> PPNFFGLBBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> COAIDHDIGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> APLEKHNNJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> NMDFLHECMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> EMANJDGEOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> MKJEKBFOLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> EBGKKPJGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> LPICCHOECBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> NDFDGDPJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> MNINLAFMEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> KIOPHAMAHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> CKENBJMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float KFGHKHJFDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float AECEOGMNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 GPKKMPBLJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float CIABFDDBOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FNKIDIFHPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float NCCGMAJNKDF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C36250", Offset = "0x5C34A50", VA = "0x185C36250")]
	public NAJNBAPIPJJ(PLGJNOIEKJL HGFDNNLFDKE, ANLJNALAKBD MPLECHMLAIA, ANLJNALAKBD DDLPKJAGBLL, float FNKIDIFHPEO, float NCCGMAJNKDF, Vector3 GPKKMPBLJNB, float CIABFDDBOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C361A0", Offset = "0x5C349A0", VA = "0x185C361A0")]
	private float3 PKNGLKPHCEJ(int PBGHCEIGALN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C35E70", Offset = "0x5C34670", VA = "0x185C35E70")]
	private void LHCGGBKBEKJ(int PBGHCEIGALN, [Out] float3 NODLLCHNJAH, [Out] float3 LNEEHAPBKNM, [Out] float4 PICAAAJPNMO, [Out] float4 PHCMNFFEPDJ, [Out] float2 BIHHBIHHLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C34EC0", Offset = "0x5C336C0", VA = "0x185C34EC0")]
	private int CINNMPJHHOP(int AFDBDOJGPCO, int MDFAADELEEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C34CC0", Offset = "0x5C334C0", VA = "0x185C34CC0")]
	private void CCIOBAKIOIC(int AFDBDOJGPCO, int MDFAADELEEE, int HKMDMCPOHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C36050", Offset = "0x5C34850", VA = "0x185C36050")]
	private bool OPJKOOABAMH(int AFDBDOJGPCO, int MDFAADELEEE, float GDBFKOKNDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C351B0", Offset = "0x5C339B0", VA = "0x185C351B0")]
	private bool EBMANFKEPBD(int AFDBDOJGPCO, int MDFAADELEEE, int HKMDMCPOHHH, float GDBFKOKNDAI, bool CGGGJFJAGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C35C10", Offset = "0x5C34410", VA = "0x185C35C10")]
	private bool JHALILOBMHA(int AFDBDOJGPCO, int MDFAADELEEE, int HKMDMCPOHHH, float GDBFKOKNDAI, bool CGGGJFJAGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C35BF0", Offset = "0x5C343F0", VA = "0x185C35BF0")]
	private void FEPKGJBKGIC(int AFDBDOJGPCO, int MDFAADELEEE, int HKMDMCPOHHH, [Out] int CNDEEDGAMGP, [Out] int JHGKGLFLFLM, [Out] int JCGFGLMHKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5C35270", Offset = "0x5C33A70", VA = "0x185C35270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ILFGPEDDHOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OIALEFIKEAK : IDisposable, JJAAKEFKIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds DPMIOBOIGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<FCNHNEPKNEN> DGNAIPANHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 NGHMBPJBMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 IILOPHPCNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int LPELELEMMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ANLJNALAKBD GBNKAOGJKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PLGJNOIEKJL FEEKCNNKAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform KLOAHFNCDKG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int KLNOILGPFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5C37910", Offset = "0x5C36110", VA = "0x185C37910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh MHKKOPIGFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh KFKPOJOFJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CBGLIFKNBMG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF604B0", Offset = "0xF5ECB0", VA = "0x180F604B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x53768C0", Offset = "0x53750C0", VA = "0x1853768C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte FJHJGJFNMGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA39CD0", Offset = "0xA384D0", VA = "0x180A39CD0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA39FA0", Offset = "0xA387A0", VA = "0x180A39FA0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FDHHGOOKNKC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8BE0D0", Offset = "0x8BC8D0", VA = "0x1808BE0D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8BC750", Offset = "0x8BAF50", VA = "0x1808BC750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int GIIDIEBDAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xB9D610", Offset = "0xB9BE10", VA = "0x180B9D610", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xB9CF90", Offset = "0xB9B790", VA = "0x180B9CF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float JNBPGFLPOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5C379F0", Offset = "0x5C361F0", VA = "0x185C379F0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5C376A0", Offset = "0x5C35EA0", VA = "0x185C376A0")]
		public void JJDNFIFJNOJ(JNDHJMNFEHO OLLEBMKIFPO, [Out] int HDFGJAGJOEO, [Out] int PBLGJLMCPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5C374D0", Offset = "0x5C35CD0", VA = "0x185C374D0")]
		public void GPLJANHAPJI(JNDHJMNFEHO OLLEBMKIFPO, LLAEMFOHIND OECGCCLJNEK, int KFBJIKKGIHF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C37950", Offset = "0x5C36150", VA = "0x185C37950")]
		public void KILKAFLHJAK(Mesh MPLECHMLAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C37440", Offset = "0x5C35C40", VA = "0x185C37440")]
		public void EDPMHCGOODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5C37290", Offset = "0x5C35A90", VA = "0x185C37290", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5C37A10", Offset = "0x5C36210", VA = "0x185C37A10")]
		public OIALEFIKEAK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds DPMIOBOIGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<OIALEFIKEAK> BPGICOILLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AHDPJIABKOI FGBHAOKIIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer HAOAMPANBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int MLNKPBGJFBG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh CEMCJDNFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7640E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NLJBJGIAEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B6890", Offset = "0x7B5090", VA = "0x1807B6890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JPNAJJMKCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5C31330", Offset = "0x5C2FB30", VA = "0x185C31330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C303F0", Offset = "0x5C2EBF0", VA = "0x185C303F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C303C0", Offset = "0x5C2EBC0", VA = "0x185C303C0")]
	public int AJLFMHEDMOB(int PPPJDMACDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5C30020", Offset = "0x5C2E820", VA = "0x185C30020")]
	public void AENHGAKIBFF(JOJEMDKFHLA FAILPEDPBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C30BA0", Offset = "0x5C2F3A0", VA = "0x185C30BA0")]
	public void JHOENKGGCGI(Transform FANIIFELNPL, bool FAEAPOGEECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C30200", Offset = "0x5C2EA00", VA = "0x185C30200")]
	public bool AIHCFBKBPAD(bool AHDAAFBFOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C30570", Offset = "0x5C2ED70", VA = "0x185C30570")]
	public void HCFNMEIDKFK(Transform KLOAHFNCDKG, bool FAEAPOGEECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C31380", Offset = "0x5C2FB80", VA = "0x185C31380")]
	public bool OICBJJIPNIH(FCNHNEPKNEN ENFAJMDKEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C315F0", Offset = "0x5C2FDF0", VA = "0x185C315F0")]
	public ILFGPEDDHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EMGLMDFPPDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<ILFGPEDDHOB.OIALEFIKEAK> GMGNGLIEDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private PDHMFALLJCF GEBDFEFKBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<ILFGPEDDHOB.OIALEFIKEAK> DEIAFPEMOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int PODCOAFCFON;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CA20", Offset = "0x5C2B220", VA = "0x185C2CA20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D2A0", Offset = "0x5C2BAA0", VA = "0x185C2D2A0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CAD0", Offset = "0x5C2B2D0", VA = "0x185C2CAD0")]
	public void EIGFNHEIDIC(ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB, Transform KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D020", Offset = "0x5C2B820", VA = "0x185C2D020")]
	public void OICBJJIPNIH(ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CE80", Offset = "0x5C2B680", VA = "0x185C2CE80")]
	private ILFGPEDDHOB.OIALEFIKEAK JJGAMKBHEED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D200", Offset = "0x5C2BA00", VA = "0x185C2D200")]
	private bool OJBAJNNBFLP(ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CFC0", Offset = "0x5C2B7C0", VA = "0x185C2CFC0")]
	private void MHDHLNHHABF(ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CAA0", Offset = "0x5C2B2A0", VA = "0x185C2CAA0")]
	public bool ECHBKFNAHIM(ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CB90", Offset = "0x5C2B390", VA = "0x185C2CB90")]
	public bool HFBGFFHILGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CE10", Offset = "0x5C2B610", VA = "0x185C2CE10")]
	private ILFGPEDDHOB.OIALEFIKEAK ILJOGDMAADP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D320", Offset = "0x5C2BB20", VA = "0x185C2D320")]
	public EMGLMDFPPDF()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MGKNHCAAHAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NPNJJEIDCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int CAHPIHJMIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float KDFADBDLLGG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<ILFGPEDDHOB> NPDNEGILKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5C34C10", Offset = "0x5C33410", VA = "0x185C34C10")]
	public MGKNHCAAHAG(int NPNJJEIDCLD, int CAHPIHJMIFE, float JCLPOBKDFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5C34660", Offset = "0x5C32E60", VA = "0x185C34660")]
	public void CAKFPAJLPNH(PHPFFMKHJDE HPAAEDEMGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5C34920", Offset = "0x5C33120", VA = "0x185C34920")]
	private int DIJFCFBIOFA(JOJEMDKFHLA LBKDEGBJKJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C34710", Offset = "0x5C32F10", VA = "0x185C34710")]
	private void CAKFPAJLPNH(JOJEMDKFHLA LBKDEGBJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C349D0", Offset = "0x5C331D0", VA = "0x185C349D0")]
	private void JJPKEKNNPLD(JOJEMDKFHLA LBKDEGBJKJF, ILFGPEDDHOB IHJDJFNKOON)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, MHNPJIOGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DFPLMEKIDAJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
			[DebuggerHidden]
			public DFPLMEKIDAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C7F0", Offset = "0x5C2AFF0", VA = "0x185C2C7F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C9B0", Offset = "0x5C2B1B0", VA = "0x185C2C9B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C900", Offset = "0x5C2B100", VA = "0x185C2C900", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C900", Offset = "0x5C2B100", VA = "0x185C2C900", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int JPNAJJMKCGK
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C790", Offset = "0x5C2AF90", VA = "0x185C2C790", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<JJAAKEFKIGP> MJIHIMLICGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C760", Offset = "0x5C2AF60", VA = "0x185C2C760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> BPGICOILLHD
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ILFGPEDDHOB CEMCJDNFFAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ANICBBHDKJJ CNDBPOCEHEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(ANICBBHDKJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76A390", Offset = "0x768B90", VA = "0x18076A390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool FJMKCECCBHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C780", Offset = "0x5C2AF80", VA = "0x185C2C780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B320", Offset = "0x5C29B20", VA = "0x185C2B320")]
		public static ClusterMeshRenderer Create(ILFGPEDDHOB MPLECHMLAIA, ClusterMeshRenderer EPAMNMBGEPC, MeshFilter MMGKFKGCDFN, FEDLPIHABFD KLOAHFNCDKG, ANICBBHDKJJ HAGBNKDONGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B490", Offset = "0x5C29C90", VA = "0x185C2B490", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5C2BCE0", Offset = "0x5C2A4E0", VA = "0x185C2BCE0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(FCNHNEPKNEN ENFAJMDKEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5C2BA90", Offset = "0x5C2A290", VA = "0x185C2BA90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B700", Offset = "0x5C29F00", VA = "0x185C2B700")]
		public void Init(ILFGPEDDHOB MPLECHMLAIA, MeshFilter MMGKFKGCDFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B4F0", Offset = "0x5C29CF0", VA = "0x185C2B4F0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5C2BDA0", Offset = "0x5C2A5A0", VA = "0x185C2BDA0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 LHFDFHNAOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C2C050", Offset = "0x5C2A850", VA = "0x185C2C050", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B680", Offset = "0x5C29E80", VA = "0x185C2B680")]
		[IteratorStateMachine(typeof(DFPLMEKIDAJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C2BB20", Offset = "0x5C2A320", VA = "0x185C2BB20")]
		public void SetupTagAndLayer(string FIIHJAHELBB, int HAGBNKDONGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C2BB00", Offset = "0x5C2A300", VA = "0x185C2BB00")]
		public bool Remove(FCNHNEPKNEN ENFAJMDKEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EBFPKONBGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int EBEHBAMHALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int GELOOBNLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int PBLGJLMCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HDFGJAGJOEO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C2CA00", Offset = "0x5C2B200", VA = "0x185C2CA00")]
	public EBFPKONBGFC(int GELOOBNLCJF, int PBLGJLMCPLD, int EBEHBAMHALI, int HDFGJAGJOEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AHDPJIABKOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> POANJPHPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> EMANJDGEOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> MBBDMHFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<EBFPKONBGFC> POCHBOIHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> APMKEFOEMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> DNDDKAAPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> CAHBBPJLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle LOGMOOGMKPB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84DC20", Offset = "0x84C420", VA = "0x18084DC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB5E910", Offset = "0xB5D110", VA = "0x180B5E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5C29D90", Offset = "0x5C28590", VA = "0x185C29D90")]
	public void LIDOAMKDODG(ANLJNALAKBD LLMHGLFJIID, NativeList<EBFPKONBGFC> POCHBOIHANL, float CDLIHEJMBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5C299F0", Offset = "0x5C281F0", VA = "0x185C299F0")]
	public void DAKGLFMAMNH(Transform KLOAHFNCDKG, bool FAEAPOGEECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5C29850", Offset = "0x5C28050", VA = "0x185C29850")]
	public void AIHCFBKBPAD(ILFGPEDDHOB HAOAMPANBIL, bool AHDAAFBFOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5C29C80", Offset = "0x5C28480", VA = "0x185C29C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5C2ABF0", Offset = "0x5C293F0", VA = "0x185C2ABF0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AHDPJIABKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct ICCDPMMOFFI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> POANJPHPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> EMANJDGEOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<EBFPKONBGFC> AOEHKIHALJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> APMKEFOEMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 GPKKMPBLJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> DNDDKAAPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> CAHBBPJLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool FAEAPOGEECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float NLHFAGODDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float OCMIANFOJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float BGAKLELMBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> MBBDMHFOIDN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5C2FF40", Offset = "0x5C2E740", VA = "0x185C2FF40")]
	public ICCDPMMOFFI(AHDPJIABKOI COAKKBKKDOP, Vector3 GPKKMPBLJNB, bool FAEAPOGEECF, float NLHFAGODDFM, float OCMIANFOJOG, float BGAKLELMBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5C2FA30", Offset = "0x5C2E230", VA = "0x185C2FA30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FCNHNEPKNEN : HJOLPJMNPAD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds OFPOCAKKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JOJEMDKFHLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<FCNHNEPKNEN> DGNAIPANHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public JOJEMDKFHLA KLGMOMIJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public JOJEMDKFHLA ACPOMPIOMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public JOJEMDKFHLA AJNGNOCKODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int HDFGJAGJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds DPMIOBOIGFA;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5C33740", Offset = "0x5C31F40", VA = "0x185C33740")]
	public JOJEMDKFHLA(List<FCNHNEPKNEN> DGNAIPANHEG, [Optional] JOJEMDKFHLA KLGMOMIJPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PHPFFMKHJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<JOJEMDKFHLA> MLJMIKLLHDL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JOJEMDKFHLA AAPMKHJIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5C38C00", Offset = "0x5C37400", VA = "0x185C38C00")]
	public PHPFFMKHJDE(JOJEMDKFHLA KLOAHFNCDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GLKDEKEDMKH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct FIAAEFPDKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NCNBMLNDHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int OKNMOMNFECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int PKKIJAFHAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int HGDPMPNNGCK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LGLBIOMMFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int CGPOFBDKPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float AINFFFGGKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<FCNHNEPKNEN> DGNAIPANHEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NMNOEJPODAO
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
	private FIAAEFPDKDA AECEKJMKGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int NDDGKDEHBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int NPNJJEIDCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int CAHPIHJMIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float JCLPOBKDFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float BGFPMBJELPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<JOJEMDKFHLA> IHAAMJNPMGD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public PHPFFMKHJDE GFPJFMNECHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F210", Offset = "0x5C2DA10", VA = "0x185C2F210")]
	public GLKDEKEDMKH(int NPNJJEIDCLD, int CAHPIHJMIFE, float JCLPOBKDFNC, int NDDGKDEHBPC, float BGFPMBJELPB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D870", Offset = "0x5C2C070", VA = "0x185C2D870")]
	public void DLJGHCNDAPI(List<FCNHNEPKNEN> DGNAIPANHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5C2E960", Offset = "0x5C2D160", VA = "0x185C2E960")]
	public bool MJDLPIBFGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F1A0", Offset = "0x5C2D9A0", VA = "0x185C2F1A0")]
	private float NOHAJDMPILB(Vector3 OIBFHHMDNOK, Vector3 PFCKGDLJEGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5C2F1F0", Offset = "0x5C2D9F0", VA = "0x185C2F1F0")]
	private float NOHAJDMPILB(Vector3 NBNELMONDLK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C2E9D0", Offset = "0x5C2D1D0", VA = "0x185C2E9D0")]
	private bool NAECGABDBIP(JOJEMDKFHLA BAINPGFIJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5C2DA40", Offset = "0x5C2C240", VA = "0x185C2DA40")]
	private LGLBIOMMFID HBEGKJAFMOJ(List<FCNHNEPKNEN> DBOAAIAFOBN, NMNOEJPODAO OHDBDANJEFP)
	{
		return default(LGLBIOMMFID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C2E560", Offset = "0x5C2CD60", VA = "0x185C2E560")]
	private void IOLEPEANFFG(List<FCNHNEPKNEN> DGNAIPANHEG, Vector3[] FHLLBJFOEDF, Vector3[] DMBEMHJNHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class GLCBACFADOK
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D6A0", Offset = "0x5C2BEA0", VA = "0x185C2D6A0")]
	public static Bounds HDJIJLIELIO(List<FCNHNEPKNEN> DGNAIPANHEG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C2D4D0", Offset = "0x5C2BCD0", VA = "0x185C2D4D0")]
	public static int EECNLCJIOKC(List<FCNHNEPKNEN> DGNAIPANHEG, JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PDHMFALLJCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private ANLJNALAKBD GHDAPCOIIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private ANLJNALAKBD FFHAGDKKJLA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static ANLJNALAKBD KNLBELMKBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private JBHAINBNLGA PGNIPBBGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LLAEMFOHIND OECGCCLJNEK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle LOGMOOGMKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EFC0", Offset = "0x1A5D7C0", VA = "0x181A5EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ILFGPEDDHOB.OIALEFIKEAK BAINPGFIJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CJFAJBKNJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E944A0", Offset = "0x4E92CA0", VA = "0x184E944A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5C37B80", Offset = "0x5C36380", VA = "0x185C37B80")]
	[EODBIJHEOFL(IPEKLHHMMFE.ExitingPlayMode, 0)]
	private static void IKDKALIILAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5C37C00", Offset = "0x5C36400", VA = "0x185C37C00")]
	public void LIDOAMKDODG(ILFGPEDDHOB.OIALEFIKEAK AOEHKIHALJA, Transform GMBAPHOJBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5C384A0", Offset = "0x5C36CA0", VA = "0x185C384A0")]
	public void NJOAPNJOAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5C37B10", Offset = "0x5C36310", VA = "0x185C37B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5C38B10", Offset = "0x5C37310", VA = "0x185C38B10")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5C38B50", Offset = "0x5C37350", VA = "0x185C38B50")]
	public PDHMFALLJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CLOHMEIOJKO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 EANPEGJGHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LLDKNAOMIPO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GJGBNJADGMM<string>.NJLLNAPFMFK HIHIBJFCODK, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OAOFHOMKICG
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAOFHOMKICG PGONPJPMIMH(Action POMIBLHGGHJ);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OAOFHOMKICG ABDGDEHOHPA(Action POMIBLHGGHJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class BIMAFLGAOPH : OAOFHOMKICG
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class NMOOGMMHIMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public BIMAFLGAOPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
				public NMOOGMMHIMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5C370C0", Offset = "0x5C358C0", VA = "0x185C370C0")]
				internal void AHBGMLKAFDE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5C37160", Offset = "0x5C35960", VA = "0x185C37160")]
				internal void DJFBBHIPNBB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x5C37110", Offset = "0x5C35910", VA = "0x185C37110")]
				internal void BJFPADOKLPD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> EDOENJKADCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action FMKIJBHCLPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action LGPFNLOJBIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private FHGHDINMMBO NKPHKEDJHCG;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action CKLKGFJBKEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action FAKIOEPHNJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x49762F0", Offset = "0x4974AF0", VA = "0x1849762F0", Slot = "4")]
			public OAOFHOMKICG PGONPJPMIMH(Action POMIBLHGGHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5756DA0", Offset = "0x57555A0", VA = "0x185756DA0", Slot = "5")]
			public OAOFHOMKICG ABDGDEHOHPA(Action POMIBLHGGHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
			public BIMAFLGAOPH(Func<JobHandle> JPPELKKKJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2ACD0", Offset = "0x5C294D0", VA = "0x185C2ACD0")]
			public void GFKLAMKNNLG(Action GJNGCFMEGKF, Action HHEMAMJJHPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2AF90", Offset = "0x5C29790", VA = "0x185C2AF90")]
			public void OICBJJIPNIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IFKNLEBMCNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public OAOFHOMKICG jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public IFKNLEBMCNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5C30010", Offset = "0x5C2E810", VA = "0x185C30010")]
			internal bool AHFANENMPNG(BIMAFLGAOPH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MKJCLGLAJDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public BIMAFLGAOPH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MKJCLGLAJDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5C34C60", Offset = "0x5C33460", VA = "0x185C34C60")]
			internal void AJADHGGMMMD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<BIMAFLGAOPH> OMOCPAJNAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<BIMAFLGAOPH> NNJGGLDKLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private CEKHBJPKCPE PCHEFNEDFCJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AINGGPPDAPC JIDOLKEAMEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C337C0", Offset = "0x5C31FC0", VA = "0x185C337C0")]
		public OAOFHOMKICG Add(Func<JobHandle> JPPELKKKJON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C33AF0", Offset = "0x5C322F0", VA = "0x185C33AF0")]
		public void Remove(OAOFHOMKICG LOGMOOGMKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C33920", Offset = "0x5C32120", VA = "0x185C33920", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C33CC0", Offset = "0x5C324C0", VA = "0x185C33CC0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C33F20", Offset = "0x5C32720", VA = "0x185C33F20")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C33910", Offset = "0x5C32110", VA = "0x185C33910")]
		[CompilerGenerated]
		private void LLHNJKHHCEL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FHGHDINMMBO
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHGHDINMMBO PGONPJPMIMH(Action POMIBLHGGHJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHGHDINMMBO LCEKFNJNNFE(Action POMIBLHGGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHGHDINMMBO ABDGDEHOHPA(Action POMIBLHGGHJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class ANLHOKLFOBA : FHGHDINMMBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle BOIGBNOJBFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action FMKIJBHCLPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action HMCBCBCMDHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action FAKIOEPHNJM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool KOHLFPFEHGK
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x5C2AC20", Offset = "0x5C29420", VA = "0x185C2AC20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x567AA80", Offset = "0x5679280", VA = "0x18567AA80", Slot = "4")]
			public FHGHDINMMBO PGONPJPMIMH(Action POMIBLHGGHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x567AAA0", Offset = "0x56792A0", VA = "0x18567AAA0", Slot = "5")]
			public FHGHDINMMBO LCEKFNJNNFE(Action POMIBLHGGHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5756DA0", Offset = "0x57555A0", VA = "0x185756DA0", Slot = "6")]
			public FHGHDINMMBO ABDGDEHOHPA(Action POMIBLHGGHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1C0FAE0", Offset = "0x1C0E2E0", VA = "0x181C0FAE0")]
			public ANLHOKLFOBA(JobHandle JFCMNDCONOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2AC30", Offset = "0x5C29430", VA = "0x185C2AC30")]
			public void LEICLPMPLAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2AC80", Offset = "0x5C29480", VA = "0x185C2AC80")]
			public void OICBJJIPNIH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<ANLHOKLFOBA> IAMHMOEKNGN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5C34420", Offset = "0x5C32C20", VA = "0x185C34420")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C34000", Offset = "0x5C32800", VA = "0x185C34000")]
		public FHGHDINMMBO Add(JobHandle JFCMNDCONOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5C34320", Offset = "0x5C32B20", VA = "0x185C34320")]
		public void Remove(FHGHDINMMBO LOGMOOGMKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5C34170", Offset = "0x5C32970", VA = "0x185C34170", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5C340A0", Offset = "0x5C328A0", VA = "0x185C340A0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5C34560", Offset = "0x5C32D60", VA = "0x185C34560")]
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
