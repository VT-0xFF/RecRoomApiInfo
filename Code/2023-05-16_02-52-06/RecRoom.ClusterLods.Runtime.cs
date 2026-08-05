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
				[Cpp2IlInjected.Address(RVA = "0x5ECF690", Offset = "0x5ECE490", VA = "0x185ECF690")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1B06580", Offset = "0x1B05380", VA = "0x181B06580")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF650", Offset = "0x5ECE450", VA = "0x185ECF650")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EC2CC0", Offset = "0x5EC1AC0", VA = "0x185EC2CC0")]
		public LODSettings EFEDNOAEDGN(FBDEGFCGHEA LFNOJPBABGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2CA0", Offset = "0x5EC1AA0", VA = "0x185EC2CA0")]
		public int DMIBLBFHLDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2CD0", Offset = "0x5EC1AD0", VA = "0x185EC2CD0")]
		public int HBCNGJGLDAO(bool BEGDBIFOIJI, Vector3 JLAKLODJHAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2DD0", Offset = "0x5EC1BD0", VA = "0x185EC2DD0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KOPIFCMEHOF
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
public interface NEPOJPIIHBK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KANAHMFJHFK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DFCPANFHFLM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OJOJCODOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BEPBLMNNOKM> FLOFPNELLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KOPIFCMEHOF LHEJALNDAOD
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
	void UpdateClusterDistances(Vector3 HPHJDIDOKFI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(PPEDNMAOPJC KHJAOGDHEIM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BEPBLMNNOKM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int OMCBIJKDAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int EGPGJBMEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FFKGAKPIIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JBLAAHGECMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte CDOLJCKIPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AIHHJGDLGFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KPELKEONFJJ
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
	private struct GJIALMLIJIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AIHHJGDLGFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public EHEFPJIJJBB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EHEFPJIJJBB <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9610", Offset = "0x5EC8410", VA = "0x185EC9610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OPGENGBNAHL : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AIHHJGDLGFP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public OPGENGBNAHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFC10", Offset = "0x5ECEA10", VA = "0x185ECFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFCD0", Offset = "0x5ECEAD0", VA = "0x185ECFCD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LBKEKNGMOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AIHHJGDLGFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EHEFPJIJJBB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private EHEFPJIJJBB <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE480", Offset = "0x5ECD280", VA = "0x185ECE480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BIDFJLIKCEF : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AIHHJGDLGFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public BIDFJLIKCEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC00F0", Offset = "0x5EBEEF0", VA = "0x185EC00F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0FA0", Offset = "0x5EBFDA0", VA = "0x185EC0FA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HHJNGHEIJEN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan IEECPCLGMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NODINIEONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter OFODLDHJMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject GCHPICNLBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject MJDKGKLKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public JIHJGDPPPGO OEFNIPJABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<PPEDNMAOPJC> BFNHNJMLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<PPEDNMAOPJC> LJGIMIJEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<PPEDNMAOPJC> JMIBFBEBCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int FBGKCBPHCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KPELKEONFJJ IECAKKFKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<DFCPANFHFLM>[] IKIAFGOBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BEPBLMNNOKM>[] GDGDAHHJEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource DBKMNBAIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool MPHLDCPNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LGJHLMJKIJM OOKJGGKJNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LGJHLMJKIJM GCBAEFIHHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int LDGAAKLNNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static AIHHJGDLGFP MMFPAPBHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HBIAIIHIJHK ELDPJICHPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly ENDJDBGFPFO NAMAPEHBPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour AGDLEOJOIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material HKHHACENGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<NEPOJPIIHBK> FIDINLMJJNH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig NGIPAFAFHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DFLKJCODELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x139BBE0", Offset = "0x139A9E0", VA = "0x18139BBE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x139BB10", Offset = "0x139A910", VA = "0x18139BB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KPELKEONFJJ HGFNIOCCHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x897710", Offset = "0x896510", VA = "0x180897710")]
		get
		{
			return default(KPELKEONFJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF5F0", Offset = "0x5EBE3F0", VA = "0x185EBF5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static AIHHJGDLGFP NHLDGJJELOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF420", Offset = "0x5EBE220", VA = "0x185EBF420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BJPNBJDPFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF100", Offset = "0x5EBDF00", VA = "0x185EBF100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool BEIILPPGOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EBD650", Offset = "0x5EBC450", VA = "0x185EBD650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> FBHEMBPEFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EBD360", Offset = "0x5EBC160", VA = "0x185EBD360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF060", Offset = "0x5EBDE60", VA = "0x185EBF060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EGHIDGGDONB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDF90", Offset = "0x5EBCD90", VA = "0x185EBDF90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EBD240", Offset = "0x5EBC040", VA = "0x185EBD240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF8D0", Offset = "0x5EBE6D0", VA = "0x185EBF8D0")]
	public AIHHJGDLGFP(HBIAIIHIJHK ELDPJICHPIH, ENDJDBGFPFO NAMAPEHBPNN, ClusterLODConfig NHNABFCLGHA, MonoBehaviour AGDLEOJOIBO, Material HKHHACENGFG, ClusterMeshRenderer NODINIEONLL, MeshFilter OFODLDHJMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDE20", Offset = "0x5EBCC20", VA = "0x185EBDE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF480", Offset = "0x5EBE280", VA = "0x185EBF480")]
	public static void OOEELKLCPJJ(Vector3 CFAJPHPNACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EBECF0", Offset = "0x5EBDAF0", VA = "0x185EBECF0")]
	private void IOCPLIGMOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE610", Offset = "0x5EBD410", VA = "0x185EBE610")]
	private void ICDMENMCPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE230", Offset = "0x5EBD030", VA = "0x185EBE230")]
	private void FLNJBNADDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE710", Offset = "0x5EBD510", VA = "0x185EBE710")]
	public void ICFIJCLNHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE030", Offset = "0x5EBCE30", VA = "0x185EBE030")]
	[AsyncStateMachine(typeof(GJIALMLIJIH))]
	public Task FFMBNAGECOP(EHEFPJIJJBB LKDPBPGJFDJ, CancellationToken GHKIFNBJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDF20", Offset = "0x5EBCD20", VA = "0x185EBDF20")]
	[IteratorStateMachine(typeof(OPGENGBNAHL))]
	private IEnumerator<OLKFKAFMJCO> EBNGIMLBABM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF720", Offset = "0x5EBE520", VA = "0x185EBF720")]
	[AsyncStateMachine(typeof(LBKEKNGMOLE))]
	private Task PPNDNGINNFK(EHEFPJIJJBB BFIFJAAHAMI, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE400", Offset = "0x5EBD200", VA = "0x185EBE400")]
	public void GJJFIHKEKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEC70", Offset = "0x5EBDA70", VA = "0x185EBEC70")]
	public void IKOGDMMIMAJ(IEnumerable<DFCPANFHFLM> APJLJMCEBPI, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCFC0", Offset = "0x5EBBDC0", VA = "0x185EBCFC0")]
	public void ACEONIEEDDP(IEnumerable<DFCPANFHFLM> APJLJMCEBPI, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD730", Offset = "0x5EBC530", VA = "0x185EBD730")]
	public List<ClusterMeshRenderer> DGLNGOBBOGJ(List<PPEDNMAOPJC> NACFHNCPJCH, CGKNHINOJKA LFLMFMLCFKL, KOPIFCMEHOF KGICKJHBDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF220", Offset = "0x5EBE020", VA = "0x185EBF220")]
	public KOPIFCMEHOF MBIMGJCHKPD(Vector3 AILANMFHODJ)
	{
		return default(KOPIFCMEHOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE170", Offset = "0x5EBCF70", VA = "0x185EBE170")]
	public void FJJOKLPNHOM(NEPOJPIIHBK KCEMFBELNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE1D0", Offset = "0x5EBCFD0", VA = "0x185EBE1D0")]
	public bool FKPJMJPAMIN(NEPOJPIIHBK KCEMFBELNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF260", Offset = "0x5EBE060", VA = "0x185EBF260")]
	public void MLOGDJPIHEP(PPEDNMAOPJC DBJJNCKFEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD2E0", Offset = "0x5EBC0E0", VA = "0x185EBD2E0")]
	public void BLPDKBKEHCM(BEPBLMNNOKM PFBGGFHJPLL, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE380", Offset = "0x5EBD180", VA = "0x185EBE380")]
	public void FPOAEOLDLIP(BEPBLMNNOKM PFBGGFHJPLL, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF2C0", Offset = "0x5EBE0C0", VA = "0x185EBF2C0")]
	private void MONAPLNKFHD(Vector3 HPHJDIDOKFI, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEF00", Offset = "0x5EBDD00", VA = "0x185EBEF00")]
	private void JMPKJMPMCBI(Vector3 HPHJDIDOKFI, KOPIFCMEHOF KGICKJHBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD400", Offset = "0x5EBC200", VA = "0x185EBD400")]
	[IteratorStateMachine(typeof(BIDFJLIKCEF))]
	private IEnumerator<OLKFKAFMJCO> CJCMNADGBOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EBED80", Offset = "0x5EBDB80", VA = "0x185EBED80")]
	private int JKPJOEHAOMP(int NNHNOIMLALG, int AOHOOEHACNE, List<BEPBLMNNOKM> EBELFCGJEFL, byte LFNOJPBABGG, ref int BEFPDELLKCC, float MFCDDEAAPPH = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD470", Offset = "0x5EBC270", VA = "0x185EBD470")]
	public void CJGLMEKHGBL(PPEDNMAOPJC KHJAOGDHEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF5B0", Offset = "0x5EBE3B0", VA = "0x185EBF5B0")]
	public bool OPEHNAMIPEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x810E90", Offset = "0x80FC90", VA = "0x180810E90")]
	public Material GFABMFPKBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDDE0", Offset = "0x5EBCBE0", VA = "0x185EBDDE0")]
	public int DMIBLBFHLDE()
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
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HPEFKMCGGFJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> GOJMLCBDIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> BDPCDEODHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> BLMDNMKMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> HEMDNBAEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> IMCLABKHOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> MBDEKLPMDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> ANCPOEAJPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 CACEHOGPNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float IMJHKPCOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeMultiHashMap<int, int> OBHKBECONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> DKCIOJFJLOM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA6F0", Offset = "0x5EC94F0", VA = "0x185ECA6F0")]
	public HPEFKMCGGFJ(ELJAEBELGHC MGJAECMCOFA, NativeList<float3> ANCPOEAJPAD, NativeMultiHashMap<int, int> OBHKBECONNN, NativeArray<int> DKCIOJFJLOM, Vector3 CACEHOGPNJG, float IMJHKPCOBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA030", Offset = "0x5EC8E30", VA = "0x185ECA030")]
	private int ECNDPBFDCOL(float3 HPHJDIDOKFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA490", Offset = "0x5EC9290", VA = "0x185ECA490")]
	private int LJBMEJFKJKG(int FCPPLBLBJIC, int JHANOPJHOLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA060", Offset = "0x5EC8E60", VA = "0x185ECA060", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IECFNHJPLMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeMultiHashMap<int, int> OBHKBECONNN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> DKCIOJFJLOM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int BKPDOOCLHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> GIIHNLNKGKO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA7B0", Offset = "0x5EC95B0", VA = "0x185ECA7B0")]
	public void CDLMGDHNDPA(int JPAJBEGCJAI, Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA9A0", Offset = "0x5EC97A0", VA = "0x185ECA9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IECFNHJPLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct BDDMHBOONNE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> HDMGFPPPPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> FOMCKOIIPJL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC00C0", Offset = "0x5EBEEC0", VA = "0x185EC00C0")]
	public BDDMHBOONNE(IECFNHJPLMC KMOFMMBIFOO, ELJAEBELGHC MGJAECMCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0020", Offset = "0x5EBEE20", VA = "0x185EC0020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct KBAIGGMDCCE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> CPGNLNLCOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> NMOOFNFNNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> OGCLOIPFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> JKEMLOEBMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> FCEDGPIMAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> GIIHNLNKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> HDMGFPPPPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> EKLCBBGPGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> DJPGIOIMLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> JEPPADEOOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> ALCKBDCFJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> AIJOFPGBFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> HGOJDHBLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float JMJHIBFFNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float MINGIFKHJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 ONIGCKNCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float LEAFMBAMAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float AKCNBOAPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float JOJDHMIFOPA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC80", Offset = "0x5ECCA80", VA = "0x185ECDC80")]
	public KBAIGGMDCCE(IECFNHJPLMC MCHIDJHNFKG, ELJAEBELGHC MGJAECMCOFA, ELJAEBELGHC CHJOACBKHCB, float AKCNBOAPABB, float JOJDHMIFOPA, Vector3 ONIGCKNCKAM, float LEAFMBAMAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD8B0", Offset = "0x5ECC6B0", VA = "0x185ECD8B0")]
	private float3 MHPBNNPEMOF(int FCPPLBLBJIC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD530", Offset = "0x5ECC330", VA = "0x185ECD530")]
	private void HFDKPBJKIKA(int FCPPLBLBJIC, out float3 JJDJAAFKPNA, out float3 NACFDJCHCDF, out float4 FCHGGJIFGJP, out float4 MBBKFIGMCNG, out float2 AKHKOPNNOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD980", Offset = "0x5ECC780", VA = "0x185ECD980")]
	private int PIJOOKEMIKB(int HJLPMOOMHOC, int ILCIOPEJNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC6D0", Offset = "0x5ECB4D0", VA = "0x185ECC6D0")]
	private void ABFMNNFNJGF(int HJLPMOOMHOC, int ILCIOPEJNKA, int EPIEMCDDLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD720", Offset = "0x5ECC520", VA = "0x185ECD720")]
	private bool HJKBMMFKGMP(int HJLPMOOMHOC, int ILCIOPEJNKA, float GJAGHEPABCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD470", Offset = "0x5ECC270", VA = "0x185ECD470")]
	private bool FJCDIJELNMA(int HJLPMOOMHOC, int ILCIOPEJNKA, int EPIEMCDDLAN, float GJAGHEPABCG, bool EGFKLMIDJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC8E0", Offset = "0x5ECB6E0", VA = "0x185ECC8E0")]
	private bool DDMJKKABHIK(int HJLPMOOMHOC, int ILCIOPEJNKA, int EPIEMCDDLAN, float GJAGHEPABCG, bool EGFKLMIDJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD960", Offset = "0x5ECC760", VA = "0x185ECD960")]
	private void NBHEALGMABC(int HJLPMOOMHOC, int ILCIOPEJNKA, int EPIEMCDDLAN, out int BIGFMBBDCNL, out int FMCIIIELAAH, out int CDMFOHIHOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCB50", Offset = "0x5ECB950", VA = "0x185ECCB50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DMCPAFDFFPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FACCPBCOMFB : IDisposable, BEPBLMNNOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds HGOGEJKCLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<PPEDNMAOPJC> NACFHNCPJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 GABMHELIONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 HEIAKOFJJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int OICANDMLEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public ELJAEBELGHC OBFMHBOEIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IECFNHJPLMC PIGFIEJABIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform LFLMFMLCFKL;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int JPLIFCJIPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8820", Offset = "0x5EC7620", VA = "0x185EC8820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh HCEOHDNLOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh MCDFMDFHBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FFKGAKPIIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x171C770", Offset = "0x171B570", VA = "0x18171C770", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x31E78E0", Offset = "0x31E66E0", VA = "0x1831E78E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte CDOLJCKIPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF4C0", VA = "0x1812C06C0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x12C06E0", Offset = "0x12BF4E0", VA = "0x1812C06E0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int OMCBIJKDAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA88810", Offset = "0xA87610", VA = "0x180A88810", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA88820", Offset = "0xA87620", VA = "0x180A88820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EGPGJBMEIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC8FF50", Offset = "0xC8ED50", VA = "0x180C8FF50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE73EA0", Offset = "0xE72CA0", VA = "0x180E73EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JBLAAHGECMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8380", Offset = "0x5EC7180", VA = "0x185EC8380", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8440", Offset = "0x5EC7240", VA = "0x185EC8440")]
		public void JJPNCGMAAFL(FBDEGFCGHEA LFNOJPBABGG, out int KJPJGBKDCAN, out int CNHEKJEIFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8670", Offset = "0x5EC7470", VA = "0x185EC8670")]
		public void KNHELFBADFB(FBDEGFCGHEA LFNOJPBABGG, CKAKFNCIKOJ ODGCJDCFKAM, int CJHIIHBIGBC = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8860", Offset = "0x5EC7660", VA = "0x185EC8860")]
		public void OHKLDNDHPLJ(NativeList<DCIDKOJNBDI> MEJPHJOEPNO, Transform BICKPKDCFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC80E0", Offset = "0x5EC6EE0", VA = "0x185EC80E0")]
		public void CCBGJIHFHHC(Mesh MGJAECMCOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC83A0", Offset = "0x5EC71A0", VA = "0x185EC83A0")]
		public void GJFJJFLBJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8180", Offset = "0x5EC6F80", VA = "0x185EC8180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C00", Offset = "0x5EC7A00", VA = "0x185EC8C00")]
		public FACCPBCOMFB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds HGOGEJKCLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<FACCPBCOMFB> MBGINGIEHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public EDOOEKDIPEE DCOCANFIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer CHMGCHLLEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int KBBHJEADDIC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh FAFECHJMIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool COMEPOJDNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA94EC0", Offset = "0xA93CC0", VA = "0x180A94EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OJOJCODOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5EE0", Offset = "0x5EC4CE0", VA = "0x185EC5EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5D80", Offset = "0x5EC4B80", VA = "0x185EC5D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6A80", Offset = "0x5EC5880", VA = "0x185EC6A80")]
	public int JCJCCCOLIGF(int KDFPOEGOMJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC68C0", Offset = "0x5EC56C0", VA = "0x185EC68C0")]
	public void IFDPADOCELN(EKLBOGGCAEM DDAFDDPNAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC60F0", Offset = "0x5EC4EF0", VA = "0x185EC60F0")]
	public void HPAJNCOIENG(Transform BICKPKDCFNO, bool FNJHBOBEBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5F30", Offset = "0x5EC4D30", VA = "0x185EC5F30")]
	public bool GAFIMIIBGOM(bool DJBPNAOACGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5680", Offset = "0x5EC4480", VA = "0x185EC5680")]
	public void BOBPAGHDHAC(Transform LFLMFMLCFKL, bool FNJHBOBEBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5AD0", Offset = "0x5EC48D0", VA = "0x185EC5AD0")]
	public bool CJGLMEKHGBL(PPEDNMAOPJC KHJAOGDHEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6AB0", Offset = "0x5EC58B0", VA = "0x185EC6AB0")]
	public DMCPAFDFFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JIHJGDPPPGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<DMCPAFDFFPL.FACCPBCOMFB> DLCEHCBHNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private DKEPKFBAPFI HNCMDLBKDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<DMCPAFDFFPL.FACCPBCOMFB> BIJLPJNHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JEFBKHLCHJI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAD10", Offset = "0x5EC9B10", VA = "0x185ECAD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB1D0", Offset = "0x5EC9FD0", VA = "0x185ECB1D0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB250", Offset = "0x5ECA050", VA = "0x185ECB250")]
	public void OEECIDDHIAM(DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM, Transform LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAA80", Offset = "0x5EC9880", VA = "0x185ECAA80")]
	public void CJGLMEKHGBL(DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB010", Offset = "0x5EC9E10", VA = "0x185ECB010")]
	private DMCPAFDFFPL.FACCPBCOMFB IBPCIHHNBAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAC70", Offset = "0x5EC9A70", VA = "0x185ECAC70")]
	private bool DABFPFOPJEI(DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB140", Offset = "0x5EC9F40", VA = "0x185ECB140")]
	private void JNABEBCBLDJ(DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB1A0", Offset = "0x5EC9FA0", VA = "0x185ECB1A0")]
	public bool NIHGFCOBIDD(DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAD80", Offset = "0x5EC9B80", VA = "0x185ECAD80")]
	public bool FPKIEKJDLAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB310", Offset = "0x5ECA110", VA = "0x185ECB310")]
	private DMCPAFDFFPL.FACCPBCOMFB PDDJIDABBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB370", Offset = "0x5ECA170", VA = "0x185ECB370")]
	public JIHJGDPPPGO()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FOKEHLFPOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CBHOBFBCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int CBDCODLNEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float ELOPFKJCGNO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<DMCPAFDFFPL> NOOCCIHKLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EC93D0", Offset = "0x5EC81D0", VA = "0x185EC93D0")]
	public FOKEHLFPOBD(int CBHOBFBCIEN, int CBDCODLNEDC, float ILFIIELGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9000", Offset = "0x5EC7E00", VA = "0x185EC9000")]
	public void DKLMMIDNFBO(GMPKFBJAMJD PPLLCCKACCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9330", Offset = "0x5EC8130", VA = "0x185EC9330")]
	private int PLMFPGNLLGP(EKLBOGGCAEM IEAGANOGPLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8DC0", Offset = "0x5EC7BC0", VA = "0x185EC8DC0")]
	private void DKLMMIDNFBO(EKLBOGGCAEM IEAGANOGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9120", Offset = "0x5EC7F20", VA = "0x185EC9120")]
	private void JKCCGGNCMCI(EKLBOGGCAEM IEAGANOGPLL, DMCPAFDFFPL KOJBCKMIGNM)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, DFCPANFHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GEGIHAOOAKI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public GEGIHAOOAKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9420", Offset = "0x5EC8220", VA = "0x185EC9420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5EC95D0", Offset = "0x5EC83D0", VA = "0x185EC95D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9530", Offset = "0x5EC8330", VA = "0x185EC9530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9530", Offset = "0x5EC8330", VA = "0x185EC9530", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int OJOJCODOGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4270", Offset = "0x5EC3070", VA = "0x185EC4270", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<BEPBLMNNOKM> FLOFPNELLDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4250", Offset = "0x5EC3050", VA = "0x185EC4250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> MBGINGIEHMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DMCPAFDFFPL FAFECHJMIDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KOPIFCMEHOF LHEJALNDAOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762140", VA = "0x180763340", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(KOPIFCMEHOF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9DFFF0", Offset = "0x9DEDF0", VA = "0x1809DFFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool JOALEIOAMEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4260", Offset = "0x5EC3060", VA = "0x185EC4260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2E30", Offset = "0x5EC1C30", VA = "0x185EC2E30")]
		public static ClusterMeshRenderer Create(DMCPAFDFFPL MGJAECMCOFA, ClusterMeshRenderer NODINIEONLL, MeshFilter OFODLDHJMNE, CGKNHINOJKA LFLMFMLCFKL, KOPIFCMEHOF KGICKJHBDLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2FD0", Offset = "0x5EC1DD0", VA = "0x185EC2FD0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3790", Offset = "0x5EC2590", VA = "0x185EC3790", Slot = "10")]
		public bool TryRemoveClusterLODComponent(PPEDNMAOPJC KHJAOGDHEIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3580", Offset = "0x5EC2380", VA = "0x185EC3580")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3220", Offset = "0x5EC2020", VA = "0x185EC3220")]
		public void Init(DMCPAFDFFPL MGJAECMCOFA, MeshFilter OFODLDHJMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3030", Offset = "0x5EC1E30", VA = "0x185EC3030")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EC38C0", Offset = "0x5EC26C0", VA = "0x185EC38C0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 HPHJDIDOKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3AD0", Offset = "0x5EC28D0", VA = "0x185EC3AD0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC31B0", Offset = "0x5EC1FB0", VA = "0x185EC31B0")]
		[IteratorStateMachine(typeof(GEGIHAOOAKI))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3600", Offset = "0x5EC2400", VA = "0x185EC3600")]
		public void SetupTagAndLayer(string IHDKMDIGBKC, int KGICKJHBDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC35E0", Offset = "0x5EC23E0", VA = "0x185EC35E0")]
		public bool Remove(PPEDNMAOPJC KHJAOGDHEIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PIIDGCDIEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HPKGJCPOCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int IAONMKKMAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CNHEKJEIFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KJPJGBKDCAN;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD10", Offset = "0x5ECEB10", VA = "0x185ECFD10")]
	public PIIDGCDIEMF(int IAONMKKMAEN, int CNHEKJEIFEC, int HPKGJCPOCCA, int KJPJGBKDCAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EDOOEKDIPEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> GOJMLCBDIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> GIIHNLNKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> MBDEKLPMDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<PIIDGCDIEMF> NIAAPKAOANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> MFIFAFADFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> JDCHGOMGHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> MEPBHIDDGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle BACBCMPFGHN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MFIKILBBBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC4B210", Offset = "0xC4A010", VA = "0x180C4B210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC4B7B0", Offset = "0xC4A5B0", VA = "0x180C4B7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7140", Offset = "0x5EC5F40", VA = "0x185EC7140")]
	public void OLEPBNNLDDG(ELJAEBELGHC GCACCHCAOEA, NativeList<PIIDGCDIEMF> NIAAPKAOANJ, float LFJHMANOJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E20", Offset = "0x5EC5C20", VA = "0x185EC6E20")]
	public void LPKEICALPBC(Transform LFLMFMLCFKL, bool FNJHBOBEBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6C70", Offset = "0x5EC5A70", VA = "0x185EC6C70")]
	public void GAFIMIIBGOM(DMCPAFDFFPL CHMGCHLLEJC, bool DJBPNAOACGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6B60", Offset = "0x5EC5960", VA = "0x185EC6B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7110", Offset = "0x5EC5F10", VA = "0x185EC7110")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EDOOEKDIPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct ONLENMPBALB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> GOJMLCBDIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> GIIHNLNKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<PIIDGCDIEMF> KGOMGFEFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> MFIFAFADFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 ONIGCKNCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> JDCHGOMGHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> MEPBHIDDGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool FNJHBOBEBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float LLLJCPBKPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float CHDDOLOFOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float NMOLICGDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> MBDEKLPMDOP;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFB40", Offset = "0x5ECE940", VA = "0x185ECFB40")]
	public ONLENMPBALB(EDOOEKDIPEE HHAGMJBBFIP, Vector3 ONIGCKNCKAM, bool FNJHBOBEBNA, float LLLJCPBKPJN, float CHDDOLOFOIE, float NMOLICGDJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF6B0", Offset = "0x5ECE4B0", VA = "0x185ECF6B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PPEDNMAOPJC : PJCNHMOEBLB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds MPMONFEKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DCIDKOJNBDI FMKMMIICMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EKLBOGGCAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<PPEDNMAOPJC> NACFHNCPJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public EKLBOGGCAEM GANAMHNGMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public EKLBOGGCAEM HJHDJGLMPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public EKLBOGGCAEM NGDCNNKKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int KJPJGBKDCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds HGOGEJKCLKP;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8060", Offset = "0x5EC6E60", VA = "0x185EC8060")]
	public EKLBOGGCAEM(List<PPEDNMAOPJC> NACFHNCPJCH, [Optional] EKLBOGGCAEM GANAMHNGMGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GMPKFBJAMJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<EKLBOGGCAEM> GHIKJALFFNN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EKLBOGGCAEM GLGKEOALGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9BF0", Offset = "0x5EC89F0", VA = "0x185EC9BF0")]
	public GMPKFBJAMJD(EKLBOGGCAEM LFLMFMLCFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CGFBDLGNGMF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct NAPDHHFNHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NDLHIBHFLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int HMABEDMNDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int ILDANKHPMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int KBIHDPNIHCG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KNBHAHDMIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int GAEAKIOCHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float PCCFFKMONDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<PPEDNMAOPJC> NACFHNCPJCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HBAFMMCEMJM
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
	private NAPDHHFNHHF NDJBAEFNLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int GPAGELIOFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CBHOBFBCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int CBDCODLNEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float ILFIIELGAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GAFDJGKDKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<EKLBOGGCAEM> HDLDPJCOCCH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GMPKFBJAMJD DKPEGPHBLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2C40", Offset = "0x5EC1A40", VA = "0x185EC2C40")]
	public CGFBDLGNGMF(int CBHOBFBCIEN, int CBDCODLNEDC, float ILFIIELGAJO, int GPAGELIOFNC, float GAFDJGKDKIL = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2970", Offset = "0x5EC1770", VA = "0x185EC2970")]
	public void DPMMMCKPIJD(List<PPEDNMAOPJC> NACFHNCPJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC24A0", Offset = "0x5EC12A0", VA = "0x185EC24A0")]
	public bool CBIHNACCDDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2B70", Offset = "0x5EC1970", VA = "0x185EC2B70")]
	private float KKLPGJBJADM(Vector3 NFEDIMPGFAA, Vector3 JEAHNGLGEAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2BF0", Offset = "0x5EC19F0", VA = "0x185EC2BF0")]
	private float KKLPGJBJADM(Vector3 MKGODNJCKOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0FE0", Offset = "0x5EBFDE0", VA = "0x185EC0FE0")]
	private bool BAFBIFOGMFO(EKLBOGGCAEM AIEJJGGJMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1870", Offset = "0x5EC0670", VA = "0x185EC1870")]
	private KNBHAHDMIND BCCENCBFFLC(List<PPEDNMAOPJC> MJCNGEPALDG, HBAFMMCEMJM DHGIBBFMNIO)
	{
		return default(KNBHAHDMIND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2510", Offset = "0x5EC1310", VA = "0x185EC2510")]
	private void CHCIAOIKDIN(List<PPEDNMAOPJC> NACFHNCPJCH, Vector3[] EDGNIECOGNN, Vector3[] EIBDKPPNFJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class HMIBOPMFHLH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E80", Offset = "0x5EC8C80", VA = "0x185EC9E80")]
	public static Bounds PBMGKOAELKM(List<PPEDNMAOPJC> NACFHNCPJCH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9CD0", Offset = "0x5EC8AD0", VA = "0x185EC9CD0")]
	public static int DDPIPBFFANF(List<PPEDNMAOPJC> NACFHNCPJCH, FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DKEPKFBAPFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private ELJAEBELGHC PNHKEOODJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private ELJAEBELGHC DGOFFDIHGJH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static ELJAEBELGHC EFPNBACEKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PIPJMJCGBBB NCHJMDJKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private CKAKFNCIKOJ ODGCJDCFKAM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BACBCMPFGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xD677B0", Offset = "0xD665B0", VA = "0x180D677B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DMCPAFDFFPL.FACCPBCOMFB AIEJJGGJMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FMKIFAJGFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EFA80", VA = "0x1807F0C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4A30", Offset = "0x5EC3830", VA = "0x185EC4A30")]
	[GLIGIBNDNJI(BCKENDBGOOK.ExitingPlayMode, 0)]
	private static void MELCJJDMOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4AE0", Offset = "0x5EC38E0", VA = "0x185EC4AE0")]
	public void OLEPBNNLDDG(DMCPAFDFFPL.FACCPBCOMFB KGOMGFEFBNJ, Transform LOCMJJNJNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4340", Offset = "0x5EC3140", VA = "0x185EC4340")]
	public void FBPKOCKOKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC42D0", Offset = "0x5EC30D0", VA = "0x185EC42D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4AA0", Offset = "0x5EC38A0", VA = "0x185EC4AA0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC55E0", Offset = "0x5EC43E0", VA = "0x185EC55E0")]
	public DKEPKFBAPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FFOCDEDDLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AIHHJGDLGFP JMMBNHNJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ENDJDBGFPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 FFACPIMGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HBIAIIHIJHK
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(EHEFPJIJJBB BFIFJAAHAMI, CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LBJCOJNPJAC
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBJCOJNPJAC GOMPHHNHDBF(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBJCOJNPJAC BMMLJDGJEJE(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBJCOJNPJAC BOPDIPKMHAJ(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LBJCOJNPJAC HMPIKBNDAAJ(Action JBJAGOLOBKN);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class JKBLCJJLDEF : LBJCOJNPJAC
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class FJENBAFCECK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public JKBLCJJLDEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public FJENBAFCECK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5EC8CE0", Offset = "0x5EC7AE0", VA = "0x185EC8CE0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5EC8D30", Offset = "0x5EC7B30", VA = "0x185EC8D30")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5EC8D80", Offset = "0x5EC7B80", VA = "0x185EC8D80")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> BKJOANEFEML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action HDBAOPCLCFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action CPILOHFKPJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private ONKOENCCNJH GEBDICKMKAK;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action GLDPACHDNPF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action CDMNKGENAPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x32DB920", Offset = "0x32DA720", VA = "0x1832DB920", Slot = "4")]
			public LBJCOJNPJAC GOMPHHNHDBF(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2A85DA0", Offset = "0x2A84BA0", VA = "0x182A85DA0", Slot = "5")]
			public LBJCOJNPJAC BMMLJDGJEJE(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2A85DC0", Offset = "0x2A84BC0", VA = "0x182A85DC0", Slot = "6")]
			public LBJCOJNPJAC BOPDIPKMHAJ(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3915530", Offset = "0x3914330", VA = "0x183915530", Slot = "7")]
			public LBJCOJNPJAC HMPIKBNDAAJ(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
			public JKBLCJJLDEF(Func<JobHandle> PILFJAJEOKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5ECB660", Offset = "0x5ECA460", VA = "0x185ECB660")]
			public void ECBHNDAKKOH(Action EIPFHKEIGAK, Action KCEMKMGHEDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5ECB4F0", Offset = "0x5ECA2F0", VA = "0x185ECB4F0")]
			public void CJGLMEKHGBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HGILDDMELJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public LBJCOJNPJAC jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public HGILDDMELJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9CC0", Offset = "0x5EC8AC0", VA = "0x185EC9CC0")]
			internal bool <Remove>b__0(JKBLCJJLDEF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PJEGLHJMDOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JKBLCJJLDEF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public PJEGLHJMDOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5ECFD30", Offset = "0x5ECEB30", VA = "0x185ECFD30")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<JKBLCJJLDEF> LPKBKDGOFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<JKBLCJJLDEF> IGALNJCHAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private LGJHLMJKIJM GGGLBEFOAFJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NMIEPFKKGEM FHKJPADBEBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB8F0", Offset = "0x5ECA6F0", VA = "0x185ECB8F0")]
		public LBJCOJNPJAC Add(Func<JobHandle> PILFJAJEOKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBBF0", Offset = "0x5ECA9F0", VA = "0x185ECBBF0")]
		public void Remove(LBJCOJNPJAC BACBCMPFGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBA50", Offset = "0x5ECA850", VA = "0x185ECBA50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBDC0", Offset = "0x5ECABC0", VA = "0x185ECBDC0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC010", Offset = "0x5ECAE10", VA = "0x185ECC010")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBA40", Offset = "0x5ECA840", VA = "0x185ECBA40")]
		[CompilerGenerated]
		private void GHOEPOGFNJN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface ONKOENCCNJH
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONKOENCCNJH GOMPHHNHDBF(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONKOENCCNJH INEBBCLIDCN(Action JBJAGOLOBKN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONKOENCCNJH HMPIKBNDAAJ(Action JBJAGOLOBKN);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class KJFCIBBGFAJ : ONKOENCCNJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle OEHINLEMGDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action HDBAOPCLCFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action BFGOMKCBEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action CDMNKGENAPJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MEPDPOKDAFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5ECE470", Offset = "0x5ECD270", VA = "0x185ECE470")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2A85DA0", Offset = "0x2A84BA0", VA = "0x182A85DA0", Slot = "4")]
			public ONKOENCCNJH GOMPHHNHDBF(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2A85DC0", Offset = "0x2A84BC0", VA = "0x182A85DC0", Slot = "5")]
			public ONKOENCCNJH INEBBCLIDCN(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3915530", Offset = "0x3914330", VA = "0x183915530", Slot = "6")]
			public ONKOENCCNJH HMPIKBNDAAJ(Action JBJAGOLOBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
			public KJFCIBBGFAJ(JobHandle JMHKBIKKDJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE430", Offset = "0x5ECD230", VA = "0x185ECE430")]
			public void IFBNIOMHDFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE3F0", Offset = "0x5ECD1F0", VA = "0x185ECE3F0")]
			public void CJGLMEKHGBL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<KJFCIBBGFAJ> INABKECDBJF;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC4F0", Offset = "0x5ECB2F0", VA = "0x185ECC4F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC110", Offset = "0x5ECAF10", VA = "0x185ECC110")]
		public ONKOENCCNJH Add(JobHandle JMHKBIKKDJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC400", Offset = "0x5ECB200", VA = "0x185ECC400")]
		public void Remove(ONKOENCCNJH BACBCMPFGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC290", Offset = "0x5ECB090", VA = "0x185ECC290", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC1A0", Offset = "0x5ECAFA0", VA = "0x185ECC1A0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC610", Offset = "0x5ECB410", VA = "0x185ECC610")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE110", Offset = "0x5ECCF10", VA = "0x185ECE110")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDDC0", Offset = "0x5ECCBC0", VA = "0x185ECDDC0")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
