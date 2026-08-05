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
				[Cpp2IlInjected.Address(RVA = "0x60A9850", Offset = "0x60A8A50", VA = "0x1860A9850")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x146D190", Offset = "0x146C390", VA = "0x18146D190")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x60A9810", Offset = "0x60A8A10", VA = "0x1860A9810")]
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
		[Cpp2IlInjected.Address(RVA = "0x609C870", Offset = "0x609BA70", VA = "0x18609C870")]
		public LODSettings COHMEDOMLFM(MOFGHOIADPN BKOOOMNKCNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x609C880", Offset = "0x609BA80", VA = "0x18609C880")]
		public int GAAKBGPHCBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x609C8A0", Offset = "0x609BAA0", VA = "0x18609C8A0")]
		public int OMHJEPAJKMB(bool IENOJKHNNFE, Vector3 JDAFAKPIBGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x609C940", Offset = "0x609BB40", VA = "0x18609C940")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JKAPDFOAKHK
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
public interface PPDKACEEBAA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFNMJEMBIKN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPMKMBKGJEI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int IIEFIMGPPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<HFBPLGJDOMN> OGNPBDBFACO
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
	void UpdateClusterDistances(Vector3 MFLOBHGAOMJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(NNNDJADDHHN OLMPJIPAILL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HFBPLGJDOMN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int ENHACMOPCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int LGMPALBCGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MJHEIFNKAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float AFMOFKFNAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte OBBBMBOBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IHLBOICPHCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LODPCDIPOHD
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
	private struct HCDDMMGJJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IHLBOICPHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HLMFHAJGJKJ<string>.PDHMENHMAFO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HLMFHAJGJKJ<string>.PDHMENHMAFO <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x609F0F0", Offset = "0x609E2F0", VA = "0x18609F0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x609F880", Offset = "0x609EA80", VA = "0x18609F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JMJPJICONOO : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DHJAFLNNJKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IHLBOICPHCF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public JMJPJICONOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60A7260", Offset = "0x60A6460", VA = "0x1860A7260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60A72E0", Offset = "0x60A64E0", VA = "0x1860A72E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AEEAOHKIKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IHLBOICPHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HLMFHAJGJKJ<string>.PDHMENHMAFO worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HLMFHAJGJKJ<string>.PDHMENHMAFO <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6099600", Offset = "0x6098800", VA = "0x186099600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x609AE40", Offset = "0x609A040", VA = "0x18609AE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GGADDPOKPLP : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DHJAFLNNJKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IHLBOICPHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public GGADDPOKPLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x609E310", Offset = "0x609D510", VA = "0x18609E310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x609EFF0", Offset = "0x609E1F0", VA = "0x18609EFF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int ABFIPLEILCF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan FDKFCIADIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer PNOIABKAKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter GIOGHMMLDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DGJEOIBJAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CGLPBLMACDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public JFBANOOCGHN DBOGGKONCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NNNDJADDHHN> ENBIEMEFKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NNNDJADDHHN> LKMEHMMOLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<NNNDJADDHHN> NDFOICPEEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int OOONMPJDCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LODPCDIPOHD GMAMFOEGNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<PPMKMBKGJEI>[] JILANOEMHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<HFBPLGJDOMN>[] ENJCKNCJEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource FLBGFKONLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NAOJGICCKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EKIPFMKCMNP IBHGFMKBDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EKIPFMKCMNP FFLLJKBGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int MNIBJEDKKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static IHLBOICPHCF FPAAHEBGKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JLILOKDFDHB LJJDLKCCEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HDNAHACKJNG DMIKLMBPENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour HLICPLJEABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material HKADMCNPOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<PPDKACEEBAA> PDJEDNJDDCM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig EMFLLBIBGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 FFCFPBHJPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CD430", Offset = "0x7CC630", VA = "0x1807CD430")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF00", Offset = "0x7CC100", VA = "0x1807CCF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private LODPCDIPOHD GDBIBAPNDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8849D0", Offset = "0x883BD0", VA = "0x1808849D0")]
		get
		{
			return default(LODPCDIPOHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60A1810", Offset = "0x60A0A10", VA = "0x1860A1810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IHLBOICPHCF MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60A1580", Offset = "0x60A0780", VA = "0x1860A1580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool PDFKKDEGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60A2800", Offset = "0x60A1A00", VA = "0x1860A2800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool LLHHPLLANNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60A2630", Offset = "0x60A1830", VA = "0x1860A2630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> ILDECBJKCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60A2570", Offset = "0x60A1770", VA = "0x1860A2570")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60A1940", Offset = "0x60A0B40", VA = "0x1860A1940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FLEKCJPBFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60A26F0", Offset = "0x60A18F0", VA = "0x1860A26F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60A3240", Offset = "0x60A2440", VA = "0x1860A3240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60A3DC0", Offset = "0x60A2FC0", VA = "0x1860A3DC0")]
	public IHLBOICPHCF(JLILOKDFDHB LJJDLKCCEJC, HDNAHACKJNG DMIKLMBPENH, ClusterLODConfig GMFINHCEKNH, MonoBehaviour HLICPLJEABK, Material HKADMCNPOAE, ClusterMeshRenderer PNOIABKAKMG, MeshFilter GIOGHMMLDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60A1470", Offset = "0x60A0670", VA = "0x1860A1470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60A2470", Offset = "0x60A1670", VA = "0x1860A2470")]
	public static void IFLEDMOHJCM(Vector3 GPIGOFDPDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60A2900", Offset = "0x60A1B00", VA = "0x1860A2900")]
	private void JNFPNGDPAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60A1360", Offset = "0x60A0560", VA = "0x1860A1360")]
	private void BDBDBIOCBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60A2320", Offset = "0x60A1520", VA = "0x1860A2320")]
	private void HELPMMCDLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60A2BE0", Offset = "0x60A1DE0", VA = "0x1860A2BE0")]
	public void MJBBINBAFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60A15D0", Offset = "0x60A07D0", VA = "0x1860A15D0")]
	[AsyncStateMachine(typeof(HCDDMMGJJNC))]
	public Task FIGAPGAFAFD(HLMFHAJGJKJ<string>.PDHMENHMAFO CJMFPBIKFLD, CancellationToken EINMEJNIPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60A2990", Offset = "0x60A1B90", VA = "0x1860A2990")]
	[IteratorStateMachine(typeof(JMJPJICONOO))]
	private IEnumerator<DHJAFLNNJKE> KPILHGJHLMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60A2200", Offset = "0x60A1400", VA = "0x1860A2200")]
	[AsyncStateMachine(typeof(AEEAOHKIKPI))]
	private Task GOJDPGHJBLE(HLMFHAJGJKJ<string>.PDHMENHMAFO FGACLKOGGFA, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60A37B0", Offset = "0x60A29B0", VA = "0x1860A37B0")]
	public void NDGNAJDFGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60A16F0", Offset = "0x60A08F0", VA = "0x1860A16F0")]
	public void FIMLOKNBFGP(IEnumerable<PPMKMBKGJEI> LEJKKAEOICF, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60A3450", Offset = "0x60A2650", VA = "0x1860A3450")]
	public void NCEKGIHJFBL(IEnumerable<PPMKMBKGJEI> LEJKKAEOICF, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60A1A00", Offset = "0x60A0C00", VA = "0x1860A1A00")]
	public List<ClusterMeshRenderer> GKNJEHAICDL(List<NNNDJADDHHN> DMIPIDGOOKM, DGBIAMHNHAH EAMCHADGEIB, JKAPDFOAKHK OFPJHGLBOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60A27A0", Offset = "0x60A19A0", VA = "0x1860A27A0")]
	public void JJPGAFPCBFN(PPDKACEEBAA DKOFIIKGCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60A1770", Offset = "0x60A0970", VA = "0x1860A1770")]
	public bool FKDPNCLIFCO(PPDKACEEBAA DKOFIIKGCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60A3750", Offset = "0x60A2950", VA = "0x1860A3750")]
	public void NDGLGPMPDBH(NNNDJADDHHN GJDMOGAOGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60A2B60", Offset = "0x60A1D60", VA = "0x1860A2B60")]
	public void LMKOHECOIAC(HFBPLGJDOMN IJNNDBCGBAH, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60A12E0", Offset = "0x60A04E0", VA = "0x1860A12E0")]
	public void BBJPNFMPILB(HFBPLGJDOMN IJNNDBCGBAH, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60A2A10", Offset = "0x60A1C10", VA = "0x1860A2A10")]
	private void LCGPAFCPNIK(Vector3 MFLOBHGAOMJ, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60A32F0", Offset = "0x60A24F0", VA = "0x1860A32F0")]
	private void NBNFGNJCCKO(Vector3 MFLOBHGAOMJ, JKAPDFOAKHK OFPJHGLBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60A3CD0", Offset = "0x60A2ED0", VA = "0x1860A3CD0")]
	[IteratorStateMachine(typeof(GGADDPOKPLP))]
	private IEnumerator<DHJAFLNNJKE> PMHCOKLJDED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60A39B0", Offset = "0x60A2BB0", VA = "0x1860A39B0")]
	private int NDLMOGNGAAO(int ILNNGHKJMBD, int GODMNAOLMMM, List<HFBPLGJDOMN> NCOBPPICKEB, byte BKOOOMNKCNJ, int CIIFMHINKKF, float ADMCMHCDFFG = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B20", Offset = "0x60A2D20", VA = "0x1860A3B20")]
	public void PADFOOPDKDB(NNNDJADDHHN OLMPJIPAILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60A1430", Offset = "0x60A0630", VA = "0x1860A1430")]
	public bool BKNCBEMHPNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8FD650", Offset = "0x8FC850", VA = "0x1808FD650")]
	public Material PIEIBFFPAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60A17D0", Offset = "0x60A09D0", VA = "0x1860A17D0")]
	public int GAAKBGPHCBN()
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
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct IIMBFEHGNII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> AENHDJNAMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> JOJOHLNLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> GMLINIGJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> BDAPEBCPKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 PIINLMGFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float HHJGIPIDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> FLDBNIHGKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> INOGLJFCNIC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x60A4C80", Offset = "0x60A3E80", VA = "0x1860A4C80")]
	public IIMBFEHGNII(DLNHLGCKNMF JLFPINMNNGM, NativeList<float3> BDAPEBCPKIC, NativeParallelMultiHashMap<int, int> FLDBNIHGKKD, NativeArray<int> INOGLJFCNIC, Vector3 PIINLMGFNDG, float HHJGIPIDPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x60A4C20", Offset = "0x60A3E20", VA = "0x1860A4C20")]
	private int GDPAFDOOKDH(float3 MFLOBHGAOMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x60A4580", Offset = "0x60A3780", VA = "0x1860A4580")]
	private int COALDJJPMCP(int ABHDANNAKPK, int HKNPGHOCJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60A47F0", Offset = "0x60A39F0", VA = "0x1860A47F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BHGKCCJAEMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> FLDBNIHGKKD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> INOGLJFCNIC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int EECAMICDCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> EOMOCOHPNNF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x609B070", Offset = "0x609A270", VA = "0x18609B070")]
	public void MFAMJJBKICE(int NFPPLLIAOCG, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x609AF90", Offset = "0x609A190", VA = "0x18609AF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public BHGKCCJAEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NMDOKDJCHIH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> EIHCNJKFHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> FJAGEKJCFOC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60AAD80", Offset = "0x60A9F80", VA = "0x1860AAD80")]
	public NMDOKDJCHIH(BHGKCCJAEMK DAHACCHALLC, DLNHLGCKNMF JLFPINMNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60AACD0", Offset = "0x60A9ED0", VA = "0x1860AACD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ILGLFBEFEGJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> IOMKOEKENJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> KKPOMLPAKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> PANGPJLCHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> CELLEDBCNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> EHIIOGBEPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> EOMOCOHPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> EIHCNJKFHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> IOPNLCLCKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> HNFOIFHJMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> KAPKDKGFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> FLGFOOOLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> NAFJBKPLCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> MCBKPDOHEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float BABINFEMDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float EJHJLAACACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 ENCNBDGIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float HAHEPLHKKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float NBKMLNPHEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float IIGADGFPKHC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60A62D0", Offset = "0x60A54D0", VA = "0x1860A62D0")]
	public ILGLFBEFEGJ(BHGKCCJAEMK HGAEONJEEPA, DLNHLGCKNMF JLFPINMNNGM, DLNHLGCKNMF BCLFMNBIOIE, float NBKMLNPHEGG, float IIGADGFPKHC, Vector3 ENCNBDGIMHH, float HAHEPLHKKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60A5AF0", Offset = "0x60A4CF0", VA = "0x1860A5AF0")]
	private float3 JOBHODKHBDF(int ABHDANNAKPK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60A60F0", Offset = "0x60A52F0", VA = "0x1860A60F0")]
	private void NPJNKCLPIBN(int ABHDANNAKPK, [Out] float3 OAGCHCIAEIC, [Out] float3 KMMNEDKICBN, [Out] float4 NOHADFAGKHA, [Out] float4 FOIOFBLBBNC, [Out] float2 KCOIHHFKPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60A5E00", Offset = "0x60A5000", VA = "0x1860A5E00")]
	private int MIADDHFMLGN(int CINAKMCGDIH, int MIBKAFKLBKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60A58D0", Offset = "0x60A4AD0", VA = "0x1860A58D0")]
	private void HGGFOGDBNCK(int CINAKMCGDIH, int MIBKAFKLBKO, int KDDPFANFBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60A5780", Offset = "0x60A4980", VA = "0x1860A5780")]
	private bool HDLIHDKAFKI(int CINAKMCGDIH, int MIBKAFKLBKO, float MDPPGADOECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60A56C0", Offset = "0x60A48C0", VA = "0x1860A56C0")]
	private bool HCMLKHDGNAN(int CINAKMCGDIH, int MIBKAFKLBKO, int KDDPFANFBHO, float MDPPGADOECF, bool MFLFPCHFABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60A5BA0", Offset = "0x60A4DA0", VA = "0x1860A5BA0")]
	private bool KBLCDEEBHCJ(int CINAKMCGDIH, int MIBKAFKLBKO, int KDDPFANFBHO, float MDPPGADOECF, bool MFLFPCHFABL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60A5AD0", Offset = "0x60A4CD0", VA = "0x1860A5AD0")]
	private void JFALPCDCBGH(int CINAKMCGDIH, int MIBKAFKLBKO, int KDDPFANFBHO, [Out] int BBHFNIINKIG, [Out] int AFKFBLAKCGN, [Out] int EGEHCOMFOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60A4D40", Offset = "0x60A3F40", VA = "0x1860A4D40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LGNEEDPPOAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MDBFEPJDNPP : IDisposable, HFBPLGJDOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds HMIPENEOJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<NNNDJADDHHN> DMIPIDGOOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 GCCJHCNICEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 NBJCFBNPMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int JFLADOOCIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DLNHLGCKNMF DCNMGALPBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BHGKCCJAEMK KKJIGPAOBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform EAMCHADGEIB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int FHEJPDLHBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x60AA590", Offset = "0x60A9790", VA = "0x1860AA590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh ONHALGMJLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MALBJEDMHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7C1D70", Offset = "0x7C0F70", VA = "0x1807C1D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float MJHEIFNKAGG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x110B250", Offset = "0x110A450", VA = "0x18110B250", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x574BCF0", Offset = "0x574AEF0", VA = "0x18574BCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte OBBBMBOBPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD6E220", Offset = "0xD6D420", VA = "0x180D6E220")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD6C6F0", Offset = "0xD6B8F0", VA = "0x180D6C6F0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ENHACMOPCIM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA30B20", Offset = "0xA2FD20", VA = "0x180A30B20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA2FD90", Offset = "0xA2EF90", VA = "0x180A2FD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LGMPALBCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD28840", Offset = "0xD27A40", VA = "0x180D28840", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD279F0", Offset = "0xD26BF0", VA = "0x180D279F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float AFMOFKFNAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x60A9E50", Offset = "0x60A9050", VA = "0x1860A9E50", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60A9F00", Offset = "0x60A9100", VA = "0x1860A9F00")]
		public void CKKDHPCJNNO(MOFGHOIADPN BKOOOMNKCNJ, [Out] int JEOBOGLNJJI, [Out] int OPAJBDGDAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60AA320", Offset = "0x60A9520", VA = "0x1860AA320")]
		public void IINAGHLLDJL(MOFGHOIADPN BKOOOMNKCNJ, CDLFNPIGGEJ BMBGDCGNPCO, int FNOPHMCINKE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60AA4F0", Offset = "0x60A96F0", VA = "0x1860AA4F0")]
		public void MCBHLAABCFB(Mesh JLFPINMNNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60A9E70", Offset = "0x60A9070", VA = "0x1860A9E70")]
		public void CFHCGAGMJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60AA170", Offset = "0x60A9370", VA = "0x1860AA170", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60AA5D0", Offset = "0x60A97D0", VA = "0x1860AA5D0")]
		public MDBFEPJDNPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds HMIPENEOJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<MDBFEPJDNPP> BJLNCIDCOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public CIAKFDPEHFJ CINDEBEKPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer JLPGFNMEAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int GFDFHFBJKOC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OKEOGJBMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3F0", Offset = "0x7B95F0", VA = "0x1807BA3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AFFCDNFBNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x885A60", Offset = "0x884C60", VA = "0x180885A60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x969E00", Offset = "0x969000", VA = "0x180969E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int IIEFIMGPPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60A9490", Offset = "0x60A8690", VA = "0x1860A9490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60A9120", Offset = "0x60A8320", VA = "0x1860A9120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60A9460", Offset = "0x60A8660", VA = "0x1860A9460")]
	public int FMHCKOKLNJI(int NFDPPHABPBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60A8F40", Offset = "0x60A8140", VA = "0x1860A8F40")]
	public void BKLFBPEMBNN(OLENFMFPOJB NDOBEIJNOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60A8180", Offset = "0x60A7380", VA = "0x1860A8180")]
	public void AFNLANNLBDM(Transform EELPEPBCIDH, bool HDFKCCGCAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60A92A0", Offset = "0x60A84A0", VA = "0x1860A92A0")]
	public bool FACJEGIIJJM(bool IDOCINELLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60A8910", Offset = "0x60A7B10", VA = "0x1860A8910")]
	public void APLANIJPFAF(Transform EAMCHADGEIB, bool HDFKCCGCAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60A94E0", Offset = "0x60A86E0", VA = "0x1860A94E0")]
	public bool PADFOOPDKDB(NNNDJADDHHN OLMPJIPAILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60A9750", Offset = "0x60A8950", VA = "0x1860A9750")]
	public LGNEEDPPOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JFBANOOCGHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<LGNEEDPPOAG.MDBFEPJDNPP> FHMNDLJAELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private PGDDDCDDPMK IPFDEFEHHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<LGNEEDPPOAG.MDBFEPJDNPP> LOBLHOJCHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GOBLCAMOILE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60A67B0", Offset = "0x60A59B0", VA = "0x1860A67B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60A6B10", Offset = "0x60A5D10", VA = "0x1860A6B10")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60A6CD0", Offset = "0x60A5ED0", VA = "0x1860A6CD0")]
	public void OJOKKDMOJFN(LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE, Transform EAMCHADGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60A6D90", Offset = "0x60A5F90", VA = "0x1860A6D90")]
	public void PADFOOPDKDB(LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60A6F70", Offset = "0x60A6170", VA = "0x1860A6F70")]
	private LGNEEDPPOAG.MDBFEPJDNPP PEIAABPAMDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60A6C30", Offset = "0x60A5E30", VA = "0x1860A6C30")]
	private bool LEAMNCCIKDD(LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60A6830", Offset = "0x60A5A30", VA = "0x1860A6830")]
	private void FDANPDCCBFD(LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60A6C00", Offset = "0x60A5E00", VA = "0x1860A6C00")]
	public bool KOBAHFFGJPG(LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60A6890", Offset = "0x60A5A90", VA = "0x1860A6890")]
	public bool HIJKAFNAKDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60A6B90", Offset = "0x60A5D90", VA = "0x1860A6B90")]
	private LGNEEDPPOAG.MDBFEPJDNPP KBGMCNHMCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60A70B0", Offset = "0x60A62B0", VA = "0x1860A70B0")]
	public JFBANOOCGHN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MMFNDJENKOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HGGPKJGOPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int OGPPOIDMGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float OENDBNOKEJL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<LGNEEDPPOAG> BADIIENBNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60AAC80", Offset = "0x60A9E80", VA = "0x1860AAC80")]
	public MMFNDJENKOC(int HGGPKJGOPEE, int OGPPOIDMGKB, float LAKCGNKDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60AABD0", Offset = "0x60A9DD0", VA = "0x1860AABD0")]
	public void LHBNCHPNMEC(ONNFCLDJLAB ONHGCJAEGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60AA910", Offset = "0x60A9B10", VA = "0x1860AA910")]
	private int KJAMMPDCHDB(OLENFMFPOJB DEBAEMIFHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60AA9C0", Offset = "0x60A9BC0", VA = "0x1860AA9C0")]
	private void LHBNCHPNMEC(OLENFMFPOJB DEBAEMIFHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60AA6D0", Offset = "0x60A98D0", VA = "0x1860AA6D0")]
	private void JGEOAPJMNGG(OLENFMFPOJB DEBAEMIFHOC, LGNEEDPPOAG MDGGAMCEDJI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PPMKMBKGJEI
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CFGHKPKEMOH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x807710", Offset = "0x806910", VA = "0x180807710")]
			[DebuggerHidden]
			public CFGHKPKEMOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x609B270", Offset = "0x609A470", VA = "0x18609B270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x609B430", Offset = "0x609A630", VA = "0x18609B430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x609B380", Offset = "0x609A580", VA = "0x18609B380", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x609B380", Offset = "0x609A580", VA = "0x18609B380", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int IIEFIMGPPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x609DE00", Offset = "0x609D000", VA = "0x18609DE00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<HFBPLGJDOMN> OGNPBDBFACO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x609DDE0", Offset = "0x609CFE0", VA = "0x18609DDE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> BJLNCIDCOON
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public LGNEEDPPOAG OKEOGJBMPPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public JKAPDFOAKHK KOMKIJCKPNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7BF5B0", Offset = "0x7BE7B0", VA = "0x1807BF5B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(JKAPDFOAKHK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7BF610", Offset = "0x7BE810", VA = "0x1807BF610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OEOFMAAEMJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x18E9910", Offset = "0x18E8B10", VA = "0x1818E9910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x609C9A0", Offset = "0x609BBA0", VA = "0x18609C9A0")]
		public static ClusterMeshRenderer Create(LGNEEDPPOAG JLFPINMNNGM, ClusterMeshRenderer PNOIABKAKMG, MeshFilter GIOGHMMLDFP, DGBIAMHNHAH EAMCHADGEIB, JKAPDFOAKHK OFPJHGLBOBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x609CB10", Offset = "0x609BD10", VA = "0x18609CB10", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x609D360", Offset = "0x609C560", VA = "0x18609D360", Slot = "9")]
		public bool TryRemoveClusterLODComponent(NNNDJADDHHN OLMPJIPAILL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x609D110", Offset = "0x609C310", VA = "0x18609D110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x609CD80", Offset = "0x609BF80", VA = "0x18609CD80")]
		public void Init(LGNEEDPPOAG JLFPINMNNGM, MeshFilter GIOGHMMLDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x609CB70", Offset = "0x609BD70", VA = "0x18609CB70")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x609D420", Offset = "0x609C620", VA = "0x18609D420", Slot = "7")]
		public void UpdateClusterDistances(Vector3 MFLOBHGAOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x609D6D0", Offset = "0x609C8D0", VA = "0x18609D6D0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x609CD00", Offset = "0x609BF00", VA = "0x18609CD00")]
		[IteratorStateMachine(typeof(CFGHKPKEMOH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x609D1A0", Offset = "0x609C3A0", VA = "0x18609D1A0")]
		public void SetupTagAndLayer(string PJHNNIPHPHM, int OFPJHGLBOBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x609D180", Offset = "0x609C380", VA = "0x18609D180")]
		public bool Remove(NNNDJADDHHN OLMPJIPAILL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CKLNBBELOHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int CJGEDHCJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int CMAABPPFEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int OPAJBDGDAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JEOBOGLNJJI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x609C850", Offset = "0x609BA50", VA = "0x18609C850")]
	public CKLNBBELOHA(int CMAABPPFEEC, int OPAJBDGDAJK, int CJGEDHCJHOB, int JEOBOGLNJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CIAKFDPEHFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> EOMOCOHPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> GMLINIGJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<CKLNBBELOHA> FOEPCFMDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> NAMPJNAJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> KBDJMBHGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> EEKLLAMFOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle EIMNPGHHIJH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CCDJCEAFEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC250E0", Offset = "0xC242E0", VA = "0x180C250E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCF5E60", Offset = "0xCF5060", VA = "0x180CF5E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x609B9F0", Offset = "0x609ABF0", VA = "0x18609B9F0")]
	public void PIODBADEDMB(DLNHLGCKNMF LEKHIMFKFBB, NativeList<CKLNBBELOHA> FOEPCFMDBPF, float LNFDMKEIMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x609B480", Offset = "0x609A680", VA = "0x18609B480")]
	public void DJEAAIENJAJ(Transform EAMCHADGEIB, bool HDFKCCGCAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x609B820", Offset = "0x609AA20", VA = "0x18609B820")]
	public void FACJEGIIJJM(LGNEEDPPOAG JLPGFNMEAJC, bool IDOCINELLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x609B710", Offset = "0x609A910", VA = "0x18609B710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x609B9C0", Offset = "0x609ABC0", VA = "0x18609B9C0")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CIAKFDPEHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct MBEDGENMPDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> EOMOCOHPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<CKLNBBELOHA> JPEMMNLPEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> NAMPJNAJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 ENCNBDGIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> KBDJMBHGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> EEKLLAMFOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool HDFKCCGCAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float FDKOIHPLOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float CPOEOENHKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float APNDEIFHBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> GMLINIGJIKL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60A9D80", Offset = "0x60A8F80", VA = "0x1860A9D80")]
	public MBEDGENMPDD(CIAKFDPEHFJ GJEMHBHJPAG, Vector3 ENCNBDGIMHH, bool HDFKCCGCAIL, float FDKOIHPLOCJ, float CPOEOENHKIK, float APNDEIFHBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60A9870", Offset = "0x60A8A70", VA = "0x1860A9870", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NNNDJADDHHN : MCEDACABFLO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds GDEIEOJBOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OLENFMFPOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<NNNDJADDHHN> DMIPIDGOOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public OLENFMFPOJB DMKJLMNBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public OLENFMFPOJB CFMMPGKCOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public OLENFMFPOJB JKGPPKKCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int JEOBOGLNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds HMIPENEOJNP;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x60AADB0", Offset = "0x60A9FB0", VA = "0x1860AADB0")]
	public OLENFMFPOJB(List<NNNDJADDHHN> DMIPIDGOOKM, [Optional] OLENFMFPOJB DMKJLMNBOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ONNFCLDJLAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<OLENFMFPOJB> FKKDNGFKKNE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OLENFMFPOJB EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60AAE30", Offset = "0x60AA030", VA = "0x1860AAE30")]
	public ONNFCLDJLAB(OLENFMFPOJB EAMCHADGEIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ICMOFACJNLK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct KBPOAJKMHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int GKODEICKNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int FNDHADHEPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LDGHMIIMJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int MOFOFHFJOEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct PDFFAGJEGFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int IOGJEGMOLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float HOFGOPHOAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<NNNDJADDHHN> DMIPIDGOOKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MNNJNOANBOB
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
	private KBPOAJKMHJB JCDMJJEOCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int CHIJHOEOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int HGGPKJGOPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int OGPPOIDMGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float LAKCGNKDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float EPMLKALMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<OLENFMFPOJB> DJHPIPECOAB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public ONNFCLDJLAB HPAIHEBDHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60A1280", Offset = "0x60A0480", VA = "0x1860A1280")]
	public ICMOFACJNLK(int HGGPKJGOPEE, int OGPPOIDMGKB, float LAKCGNKDHEJ, int CHIJHOEOIPE, float EPMLKALMJCL = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60A10B0", Offset = "0x60A02B0", VA = "0x1860A10B0")]
	public void PFINMGDIJON(List<NNNDJADDHHN> DMIPIDGOOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60A0520", Offset = "0x609F720", VA = "0x1860A0520")]
	public bool KCBIGBNFBIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60A04B0", Offset = "0x609F6B0", VA = "0x1860A04B0")]
	private float JLNHILABMBB(Vector3 MOGFCJFCPAL, Vector3 IGCFIMIIJDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x60A0500", Offset = "0x609F700", VA = "0x1860A0500")]
	private float JLNHILABMBB(Vector3 DKMFLNHKFDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x609FCE0", Offset = "0x609EEE0", VA = "0x18609FCE0")]
	private bool IANBHKECGBL(OLENFMFPOJB DPDMNCIOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60A0590", Offset = "0x609F790", VA = "0x1860A0590")]
	private PDFFAGJEGFL LHPODHOHCBH(List<NNNDJADDHHN> LDILGPJOBMG, MNNJNOANBOB AHPMPFMNAEC)
	{
		return default(PDFFAGJEGFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x609F8E0", Offset = "0x609EAE0", VA = "0x18609F8E0")]
	private void ECOHKMDMGNF(List<NNNDJADDHHN> DMIPIDGOOKM, Vector3[] ECFDEBBGOOB, Vector3[] LNEINOFPMPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JBENLIDGLAF
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x60A6410", Offset = "0x60A5610", VA = "0x1860A6410")]
	public static Bounds APLHKLGIOAK(List<NNNDJADDHHN> DMIPIDGOOKM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60A65E0", Offset = "0x60A57E0", VA = "0x1860A65E0")]
	public static int KHEDOIGIICK(List<NNNDJADDHHN> DMIPIDGOOKM, MOFGHOIADPN BKOOOMNKCNJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PGDDDCDDPMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private DLNHLGCKNMF PDBBOJFGMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DLNHLGCKNMF OFIJDLLFJAM;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static DLNHLGCKNMF BMECPDHCKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NNNGHDLACJL GDEGGFCOCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private CDLFNPIGGEJ BMBGDCGNPCO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle EIMNPGHHIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x850870", Offset = "0x84FA70", VA = "0x180850870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LGNEEDPPOAG.MDBFEPJDNPP DPDMNCIOEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JKDICAIPLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x524BF20", Offset = "0x524B120", VA = "0x18524BF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60AAF70", Offset = "0x60AA170", VA = "0x1860AAF70")]
	[KACMNEJNDEG(CCJCNNIFOEN.ExitingPlayMode, 0)]
	private static void FFNKFCCMNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60AB6A0", Offset = "0x60AA8A0", VA = "0x1860AB6A0")]
	public void PIODBADEDMB(LGNEEDPPOAG.MDBFEPJDNPP JPEMMNLPEDN, Transform FCIGMKKBJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60AB030", Offset = "0x60AA230", VA = "0x1860AB030")]
	public void MIENJHDENBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60AAF00", Offset = "0x60AA100", VA = "0x1860AAF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60AAFF0", Offset = "0x60AA1F0", VA = "0x1860AAFF0")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x60ABF40", Offset = "0x60AB140", VA = "0x1860ABF40")]
	public PGDDDCDDPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HDNAHACKJNG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 AMLLDIFNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JLILOKDFDHB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(HLMFHAJGJKJ<string>.PDHMENHMAFO FGACLKOGGFA, CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FLIIJHKNJKH
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FLIIJHKNJKH HPLCBEDLJFJ(Action CEBHNDLCHED);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FLIIJHKNJKH LBFPIEODLAC(Action CEBHNDLCHED);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class FBJMEKJBADJ : FLIIJHKNJKH
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class AMLNKMIOMHI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public FBJMEKJBADJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
				public AMLNKMIOMHI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x609AEA0", Offset = "0x609A0A0", VA = "0x18609AEA0")]
				internal void GOFAENJGFPH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x609AF40", Offset = "0x609A140", VA = "0x18609AF40")]
				internal void MIANBMGJNGL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x609AEF0", Offset = "0x609A0F0", VA = "0x18609AEF0")]
				internal void HPHENMEALMA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> DIIDIMCCGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action ODCCOPPKLAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action EDPFICMGFCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private GKEBHINIPHH CKNDAFFDAGK;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action CNEPBELDENI
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action DKODELLLLBA
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3E6BED0", Offset = "0x3E6B0D0", VA = "0x183E6BED0", Slot = "4")]
			public FLIIJHKNJKH HPLCBEDLJFJ(Action CEBHNDLCHED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5B85240", Offset = "0x5B84440", VA = "0x185B85240", Slot = "5")]
			public FLIIJHKNJKH LBFPIEODLAC(Action CEBHNDLCHED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
			public FBJMEKJBADJ(Func<JobHandle> EKNPOJPJKFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x609DFF0", Offset = "0x609D1F0", VA = "0x18609DFF0")]
			public void PNGLLFMNHOL(Action IKEOJKEFEDC, Action DPNBMDJOBBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x609DE60", Offset = "0x609D060", VA = "0x18609DE60")]
			public void PADFOOPDKDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class KLDGODPNIIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public FLIIJHKNJKH jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public KLDGODPNIIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x60A8170", Offset = "0x60A7370", VA = "0x1860A8170")]
			internal bool DBMALFCJDHF(FBJMEKJBADJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FDKGBDNEBPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FBJMEKJBADJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public FDKGBDNEBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x609E2B0", Offset = "0x609D4B0", VA = "0x18609E2B0")]
			internal void AHINFHJMBJB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<FBJMEKJBADJ> AJPLDLNBLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<FBJMEKJBADJ> ONDDNMINIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private EKIPFMKCMNP BNNMMMMOLFC;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public LMPNOKBNPPJ PEGCDGMPMOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60A7330", Offset = "0x60A6530", VA = "0x1860A7330")]
		public FLIIJHKNJKH Add(Func<JobHandle> EKNPOJPJKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60A7660", Offset = "0x60A6860", VA = "0x1860A7660")]
		public void Remove(FLIIJHKNJKH EIMNPGHHIJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60A7490", Offset = "0x60A6690", VA = "0x1860A7490", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60A7830", Offset = "0x60A6A30", VA = "0x1860A7830")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60A7A90", Offset = "0x60A6C90", VA = "0x1860A7A90")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60A7480", Offset = "0x60A6680", VA = "0x1860A7480")]
		[CompilerGenerated]
		private void MAPONJALABO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GKEBHINIPHH
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKEBHINIPHH HPLCBEDLJFJ(Action CEBHNDLCHED);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKEBHINIPHH MEDFINJFCFJ(Action CEBHNDLCHED);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKEBHINIPHH LBFPIEODLAC(Action CEBHNDLCHED);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class GMMDCLNMHCA : GKEBHINIPHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle DDHHPLKHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action ODCCOPPKLAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action IGCGLICPOPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action DKODELLLLBA;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool MJPGAACCKIN
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x609F040", Offset = "0x609E240", VA = "0x18609F040")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5A97A40", Offset = "0x5A96C40", VA = "0x185A97A40", Slot = "4")]
			public GKEBHINIPHH HPLCBEDLJFJ(Action CEBHNDLCHED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A97A60", Offset = "0x5A96C60", VA = "0x185A97A60", Slot = "5")]
			public GKEBHINIPHH MEDFINJFCFJ(Action CEBHNDLCHED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B85240", Offset = "0x5B84440", VA = "0x185B85240", Slot = "6")]
			public GKEBHINIPHH LBFPIEODLAC(Action CEBHNDLCHED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1B6F2C0", Offset = "0x1B6E4C0", VA = "0x181B6F2C0")]
			public GMMDCLNMHCA(JobHandle MBKCHHJGFOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x609F050", Offset = "0x609E250", VA = "0x18609F050")]
			public void FJHKOCLFIIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x609F0A0", Offset = "0x609E2A0", VA = "0x18609F0A0")]
			public void PADFOOPDKDB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<GMMDCLNMHCA> OABMJMFMCHA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60A7F90", Offset = "0x60A7190", VA = "0x1860A7F90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60A7B70", Offset = "0x60A6D70", VA = "0x1860A7B70")]
		public GKEBHINIPHH Add(JobHandle MBKCHHJGFOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60A7E90", Offset = "0x60A7090", VA = "0x1860A7E90")]
		public void Remove(GKEBHINIPHH EIMNPGHHIJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60A7CE0", Offset = "0x60A6EE0", VA = "0x1860A7CE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60A7C10", Offset = "0x60A6E10", VA = "0x1860A7C10")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60A80D0", Offset = "0x60A72D0", VA = "0x1860A80D0")]
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
