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
				[Cpp2IlInjected.Address(RVA = "0x5ABA4F0", Offset = "0x5AB92F0", VA = "0x185ABA4F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xDD3CF0", Offset = "0xDD2AF0", VA = "0x180DD3CF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5ABA4B0", Offset = "0x5AB92B0", VA = "0x185ABA4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AAB840", Offset = "0x5AAA640", VA = "0x185AAB840")]
		public LODSettings BKKLGMOJLCF(NNCAOIFLNAP NJPOLOKEGLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB850", Offset = "0x5AAA650", VA = "0x185AAB850")]
		public int EMBBMKNONCN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB740", Offset = "0x5AAA540", VA = "0x185AAB740")]
		public int AEJPJHEIFFC(bool NEJNJJIONDK, Vector3 OJDIJJJAALP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB870", Offset = "0x5AAA670", VA = "0x185AAB870")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GMGGJMPGPGK
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
public interface EHJLDPDJAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAGEHGKKBOA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPHDMJCJBKF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MOBPEKJCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IHCPNPJBNNO> FCMCBHADABA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GMGGJMPGPGK GNKOJHBBBCN
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
	void UpdateClusterDistances(Vector3 OOJIJOLPAGI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(MHPDBOENDNG BJCJNGNNING);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IHCPNPJBNNO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int IHHFNEMHOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GOGAGNOLANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OLJIAFAILMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float HBMHCGBEAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte BAEPJIAOPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LFGLNLDAEKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OLHDNOHNJJP
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
	private struct LLMFDFLJFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LFGLNLDAEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KHFLMDIKDOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KHFLMDIKDOP <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9E40", Offset = "0x5AB8C40", VA = "0x185AB9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OKJPHJLHPLB : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LFGLNLDAEKB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public OKJPHJLHPLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ABCA90", Offset = "0x5ABB890", VA = "0x185ABCA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ABCB50", Offset = "0x5ABB950", VA = "0x185ABCB50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FFPOOEOHCLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LFGLNLDAEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KHFLMDIKDOP worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private KHFLMDIKDOP <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE740", Offset = "0x5AAD540", VA = "0x185AAE740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FGHJHICODBC : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FFIMBIIMMMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public LFGLNLDAEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
		[DebuggerHidden]
		public FGHJHICODBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF910", Offset = "0x5AAE710", VA = "0x185AAF910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5AB07C0", Offset = "0x5AAF5C0", VA = "0x185AB07C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FLFDAJHDAJN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan HCJGBJNKCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NAFFPODNEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter IJAHLNMKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LDGOCFNKMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject EHGNNHLBDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LJDGIPCJKNC GPCDMEEEPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<MHPDBOENDNG> DFCDCJHFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<MHPDBOENDNG> KNCFLILNKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<MHPDBOENDNG> BAJFHKGDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LCINNIPJBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OLHDNOHNJJP HAIIOGGDNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<PPHDMJCJBKF>[] JCOHLFDDMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<IHCPNPJBNNO>[] HJPMIPAHAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource NNCCMPDOMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool JKKLDOJALIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OMJDCAMIDEI JDBMOKLNCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OMJDCAMIDEI IODPGNJCFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int KPLGFHKLMGI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static LFGLNLDAEKB EAMNAMGAHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GJJDAPMAAKE MMFDDNJNBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MCOEJLDOACG MKGCLGPPALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour LMNOMAMNDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material DAGGOAFIDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<EHJLDPDJAEP> LHLGCIDFKAG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig GBLCLGKOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 GMCFGNNKONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x13B46E0", Offset = "0x13B34E0", VA = "0x1813B46E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13B4610", Offset = "0x13B3410", VA = "0x1813B4610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private OLHDNOHNJJP FDGINCMGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82E600", Offset = "0x82D400", VA = "0x18082E600")]
		get
		{
			return default(OLHDNOHNJJP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB73B0", Offset = "0x5AB61B0", VA = "0x185AB73B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LFGLNLDAEKB PDNDNIMAPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6510", Offset = "0x5AB5310", VA = "0x185AB6510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NDKPBHOKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7D70", Offset = "0x5AB6B70", VA = "0x185AB7D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CANPPIINMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5AB6B90", Offset = "0x5AB5990", VA = "0x185AB6B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> CAHEFKHCDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7130", Offset = "0x5AB5F30", VA = "0x185AB7130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB87B0", Offset = "0x5AB75B0", VA = "0x185AB87B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PPPMDJLLJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8AF0", Offset = "0x5AB78F0", VA = "0x185AB8AF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7E90", Offset = "0x5AB6C90", VA = "0x185AB7E90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8C80", Offset = "0x5AB7A80", VA = "0x185AB8C80")]
	public LFGLNLDAEKB(GJJDAPMAAKE MMFDDNJNBAA, MCOEJLDOACG MKGCLGPPALG, ClusterLODConfig IBIIBKEPBMM, MonoBehaviour LMNOMAMNDGE, Material DAGGOAFIDMI, ClusterMeshRenderer NAFFPODNEPG, MeshFilter IJAHLNMKLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AB69E0", Offset = "0x5AB57E0", VA = "0x185AB69E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8850", Offset = "0x5AB7650", VA = "0x185AB8850")]
	public static void OJIDNFHFNEL(Vector3 EONOBJFMKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AB89E0", Offset = "0x5AB77E0", VA = "0x185AB89E0")]
	private void PDKMIOIJDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6EF0", Offset = "0x5AB5CF0", VA = "0x185AB6EF0")]
	private void GEOKGNHPBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8660", Offset = "0x5AB7460", VA = "0x185AB8660")]
	private void OIEPGANKFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7F30", Offset = "0x5AB6D30", VA = "0x185AB7F30")]
	public void LBMIEDAKCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6610", Offset = "0x5AB5410", VA = "0x185AB6610")]
	[AsyncStateMachine(typeof(LLMFDFLJFID))]
	public Task BOOLKGBBFOO(KHFLMDIKDOP BFCGDDALELD, CancellationToken CKPPPLECLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8490", Offset = "0x5AB7290", VA = "0x185AB8490")]
	[IteratorStateMachine(typeof(OKJPHJLHPLB))]
	private IEnumerator<FFIMBIIMMMD> MEEBBFECJAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6FF0", Offset = "0x5AB5DF0", VA = "0x185AB6FF0")]
	[AsyncStateMachine(typeof(FFPOOEOHCLL))]
	private Task GKCPJEDNPAB(KHFLMDIKDOP NOGGCKIKFDF, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB67D0", Offset = "0x5AB55D0", VA = "0x185AB67D0")]
	public void CPKPNLLNHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8A70", Offset = "0x5AB7870", VA = "0x185AB8A70")]
	public void PHOJLDIHLNC(IEnumerable<PPHDMJCJBKF> MIBGKICPDLH, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6C70", Offset = "0x5AB5A70", VA = "0x185AB6C70")]
	public void FGBBAHJMGBJ(IEnumerable<PPHDMJCJBKF> MIBGKICPDLH, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB74E0", Offset = "0x5AB62E0", VA = "0x185AB74E0")]
	public List<ClusterMeshRenderer> IENKMCINPMD(List<MHPDBOENDNG> ELCPBBOBCBJ, MCIOIOFPDFL DCJJENKGKJB, GMGGJMPGPGK OMGDGKEEKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5AB65D0", Offset = "0x5AB53D0", VA = "0x185AB65D0")]
	public GMGGJMPGPGK BLNADOFJPAJ(Vector3 KJDKAAGIEIB)
	{
		return default(GMGGJMPGPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8980", Offset = "0x5AB7780", VA = "0x185AB8980")]
	public void PAAIFPHMEBM(EHJLDPDJAEP HDALPOAHCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6570", Offset = "0x5AB5370", VA = "0x185AB6570")]
	public bool BHLILJMADOE(EHJLDPDJAEP HDALPOAHCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5AB71D0", Offset = "0x5AB5FD0", VA = "0x185AB71D0")]
	public void GLOLIGEJDOC(MHPDBOENDNG IEJMLJHPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8B90", Offset = "0x5AB7990", VA = "0x185AB8B90")]
	public void PMGGIAMGJDG(IHCPNPJBNNO DNOEJKEOKKF, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6750", Offset = "0x5AB5550", VA = "0x185AB6750")]
	public void CBJMPADMMBK(IHCPNPJBNNO DNOEJKEOKKF, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8500", Offset = "0x5AB7300", VA = "0x185AB8500")]
	private void NDKENIOHKBL(Vector3 OOJIJOLPAGI, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6370", Offset = "0x5AB5170", VA = "0x185AB6370")]
	private void AMDLAINBPDF(Vector3 OOJIJOLPAGI, GMGGJMPGPGK OMGDGKEEKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6AE0", Offset = "0x5AB58E0", VA = "0x185AB6AE0")]
	[IteratorStateMachine(typeof(FGHJHICODBC))]
	private IEnumerator<FFIMBIIMMMD> EIKJPEMKLDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7230", Offset = "0x5AB6030", VA = "0x185AB7230")]
	private int GOBOEMDNMBE(int CPOAAGLEIPE, int EBDACIOCHBJ, List<IHCPNPJBNNO> GGBFDJPEBAA, byte NJPOLOKEGLO, ref int JAIONFDALCF, float BKBNJGMHFKF = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7B90", Offset = "0x5AB6990", VA = "0x185AB7B90")]
	public void IHKCCNMHHEB(MHPDBOENDNG BJCJNGNNING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB64D0", Offset = "0x5AB52D0", VA = "0x185AB64D0")]
	public bool BAILAOONJDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E20", Offset = "0x8B5C20", VA = "0x1808B6E20")]
	public Material CLJOBNBHLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6B50", Offset = "0x5AB5950", VA = "0x185AB6B50")]
	public int EMBBMKNONCN()
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
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KJHLBAOLFKO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> NIFBEPAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> MFHGCKECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> DILKKCDDHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> FBOCPEJGHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> OIHKBKCBINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> AJGFBNHKPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> GAMKIJGHJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 MKDNOKKGLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float CGOKAFPCMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeMultiHashMap<int, int> MEKOKHJFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> HOCPDJJPAOO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5AB55A0", Offset = "0x5AB43A0", VA = "0x185AB55A0")]
	public KJHLBAOLFKO(GHDHHNDLKIN DPOJLBHHPEO, NativeList<float3> GAMKIJGHJKI, NativeMultiHashMap<int, int> MEKOKHJFLKB, NativeArray<int> HOCPDJJPAOO, Vector3 MKDNOKKGLHF, float CGOKAFPCMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5310", Offset = "0x5AB4110", VA = "0x185AB5310")]
	private int MADODNHCNKH(float3 OOJIJOLPAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5340", Offset = "0x5AB4140", VA = "0x185AB5340")]
	private int PPFIPIBFOEM(int MHNCIMAMLJL, int ANFHHLAHMJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5AB4EE0", Offset = "0x5AB3CE0", VA = "0x185AB4EE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AGGBMCBIMAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeMultiHashMap<int, int> MEKOKHJFLKB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> HOCPDJJPAOO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int KIJLHGGOBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> MJNDGCAPGBF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9F70", Offset = "0x5AA8D70", VA = "0x185AA9F70")]
	public void FHDDGMGDOHG(int MGPDNCMNPFL, Allocator HIEJKCFDMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9E90", Offset = "0x5AA8C90", VA = "0x185AA9E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public AGGBMCBIMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct FHBADFDLLLP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> MNEHCJEJGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> OPHFLOFBLEI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB08A0", Offset = "0x5AAF6A0", VA = "0x185AB08A0")]
	public FHBADFDLLLP(AGGBMCBIMAF AEKDCPFIOGC, GHDHHNDLKIN DPOJLBHHPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB0800", Offset = "0x5AAF600", VA = "0x185AB0800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct GKBOAKCKNNA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> NMMBCOIIDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> LBBFFAGCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> HJICKEKIMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> JEIAJGAFKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> HGIFOOCOBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> MJNDGCAPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> MNEHCJEJGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> PHCEJBKPCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> EDODDCICGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> CJKCFCPBHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> AHBNLEALAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> HNIBGIIDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> KPMEGCDNKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float GBPKMFPIAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float FPLMOGNDNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 HAODALHLFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float DAOBDAGEMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float KMMBGOFNLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float EMEIKNNEGHK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3F60", Offset = "0x5AB2D60", VA = "0x185AB3F60")]
	public GKBOAKCKNNA(AGGBMCBIMAF DECKFNMDMPH, GHDHHNDLKIN DPOJLBHHPEO, GHDHHNDLKIN GELDEOFIGOK, float KMMBGOFNLGF, float EMEIKNNEGHK, Vector3 HAODALHLFCI, float DAOBDAGEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB29B0", Offset = "0x5AB17B0", VA = "0x185AB29B0")]
	private float3 DGFCPIKPACL(int MHNCIMAMLJL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2A60", Offset = "0x5AB1860", VA = "0x185AB2A60")]
	private void DMLHANLPIGK(int MHNCIMAMLJL, out float3 MCGFFBFKLOC, out float3 DPLNJOKJFNJ, out float4 PLPGHHGEGBC, out float4 PODINEFKGBA, out float2 OPFMAJKGAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5AB39F0", Offset = "0x5AB27F0", VA = "0x185AB39F0")]
	private int KNJBNKOPCPD(int JNFNPKBEKMN, int DJOIELCGBLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2C50", Offset = "0x5AB1A50", VA = "0x185AB2C50")]
	private void EGEKNNIFAJP(int JNFNPKBEKMN, int DJOIELCGBLB, int OHIPBDBMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3840", Offset = "0x5AB2640", VA = "0x185AB3840")]
	private bool FPHPENCJNEF(int JNFNPKBEKMN, int DJOIELCGBLB, float GNFJCDNFCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3780", Offset = "0x5AB2580", VA = "0x185AB3780")]
	private bool FPEKKOIMEBK(int JNFNPKBEKMN, int DJOIELCGBLB, int OHIPBDBMNGF, float GNFJCDNFCLE, bool MPHPCFPIGKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3CF0", Offset = "0x5AB2AF0", VA = "0x185AB3CF0")]
	private bool PKOHPDELJGC(int JNFNPKBEKMN, int DJOIELCGBLB, int OHIPBDBMNGF, float GNFJCDNFCLE, bool MPHPCFPIGKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5AB39D0", Offset = "0x5AB27D0", VA = "0x185AB39D0")]
	private void GCDONJMBIFF(int JNFNPKBEKMN, int DJOIELCGBLB, int OHIPBDBMNGF, out int PNBPIMDIFFG, out int JINKHCPDGMM, out int JFHPBHOAFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2E60", Offset = "0x5AB1C60", VA = "0x185AB2E60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FOAFCDJCFCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FHJJKJIKAJI : IDisposable, IHCPNPJBNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds KHDGHDAJIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<MHPDBOENDNG> ELCPBBOBCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 CIOPHLIOIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 MFKKLNEANHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int LIMIPIFINBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GHDHHNDLKIN DFAOLINHHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AGGBMCBIMAF LEOLBFDHOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform DCJJENKGKJB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int PABALEACAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1390", Offset = "0x5AB0190", VA = "0x185AB1390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CJDJGBLBLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh NBNEFNKHFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OLJIAFAILMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x71BF00", Offset = "0x71AD00", VA = "0x18071BF00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x71C2A0", Offset = "0x71B0A0", VA = "0x18071C2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte BAEPJIAOPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7716B0", Offset = "0x7704B0", VA = "0x1807716B0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7716C0", Offset = "0x7704C0", VA = "0x1807716C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IHHFNEMHOGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9935C0", Offset = "0x9923C0", VA = "0x1809935C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xDE5620", Offset = "0xDE4420", VA = "0x180DE5620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int GOGAGNOLANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9B3D90", Offset = "0x9B2B90", VA = "0x1809B3D90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1221220", Offset = "0x1220020", VA = "0x181221220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float HBMHCGBEAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5AB13D0", Offset = "0x5AB01D0", VA = "0x185AB13D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0D20", Offset = "0x5AAFB20", VA = "0x185AB0D20")]
		public void IGENJGJDNMG(NNCAOIFLNAP NJPOLOKEGLO, out int EKPCEBDDKAC, out int LGEEIEEFHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0B70", Offset = "0x5AAF970", VA = "0x185AB0B70")]
		public void EDNGPAEMOMJ(NNCAOIFLNAP NJPOLOKEGLO, HJIHHAKMHAF AFHHJDDLHFP, int EPONHLONMOH = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0FF0", Offset = "0x5AAFDF0", VA = "0x185AB0FF0")]
		public void LFBJMNEEAKB(NativeList<MPLDDCIADOK> PAFOCKGLABG, Transform PDOKGEDOHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0F50", Offset = "0x5AAFD50", VA = "0x185AB0F50")]
		public void JEHDDHNEADC(Mesh DPOJLBHHPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB08D0", Offset = "0x5AAF6D0", VA = "0x185AB08D0")]
		public void CMFIMNABDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0970", Offset = "0x5AAF770", VA = "0x185AB0970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5AB13F0", Offset = "0x5AB01F0", VA = "0x185AB13F0")]
		public FHJJKJIKAJI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds KHDGHDAJIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<FHJJKJIKAJI> OIBAJOBEIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public BAGEPFAABNC IPJMCHOJJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer JANOPLPFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int INKMHMMANMA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh CHIKAFEPNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IEOOHBBNAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x944F40", Offset = "0x943D40", VA = "0x180944F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MOBPEKJCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB28B0", Offset = "0x5AB16B0", VA = "0x185AB28B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2120", Offset = "0x5AB0F20", VA = "0x185AB2120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB14D0", Offset = "0x5AB02D0", VA = "0x185AB14D0")]
	public int ACCJBIOGJPP(int ECGBDMLGKBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB26F0", Offset = "0x5AB14F0", VA = "0x185AB26F0")]
	public void LDKHPCCOEFA(LFFMGICFEBB ECNFLEOENMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB1950", Offset = "0x5AB0750", VA = "0x185AB1950")]
	public void CNLNAICJJKP(Transform PDOKGEDOHHO, bool BADKKHKHBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2280", Offset = "0x5AB1080", VA = "0x185AB2280")]
	public bool GNODDILIADP(bool ADCFEMKAGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5AB1500", Offset = "0x5AB0300", VA = "0x185AB1500")]
	public void BADBPKKDNBC(Transform DCJJENKGKJB, bool BADKKHKHBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2440", Offset = "0x5AB1240", VA = "0x185AB2440")]
	public bool IHKCCNMHHEB(MHPDBOENDNG BJCJNGNNING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5AB2900", Offset = "0x5AB1700", VA = "0x185AB2900")]
	public FOAFCDJCFCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LJDGIPCJKNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<FOAFCDJCFCE.FHJJKJIKAJI> NKBELBMKJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EABPBJLKLKE EEBNOEEIHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<FOAFCDJCFCE.FHJJKJIKAJI> DNIJBHBOFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int HJCCGGLKIJB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9780", Offset = "0x5AB8580", VA = "0x185AB9780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB97F0", Offset = "0x5AB85F0", VA = "0x185AB97F0")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB93D0", Offset = "0x5AB81D0", VA = "0x185AB93D0")]
	public void AHKNMMEAEHA(FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ, Transform DCJJENKGKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9870", Offset = "0x5AB8670", VA = "0x185AB9870")]
	public void IHKCCNMHHEB(FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9B30", Offset = "0x5AB8930", VA = "0x185AB9B30")]
	private FOAFCDJCFCE.FHJJKJIKAJI MAKGJNOLJPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9A90", Offset = "0x5AB8890", VA = "0x185AB9A90")]
	private bool LDKECHIOPKE(FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9C60", Offset = "0x5AB8A60", VA = "0x185AB9C60")]
	private void NEPNKEMMFJP(FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9A60", Offset = "0x5AB8860", VA = "0x185AB9A60")]
	public bool JCDHAKCFECJ(FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9490", Offset = "0x5AB8290", VA = "0x185AB9490")]
	public bool CAMMFFCGHBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9720", Offset = "0x5AB8520", VA = "0x185AB9720")]
	private FOAFCDJCFCE.FHJJKJIKAJI CODOHKLHIGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9CC0", Offset = "0x5AB8AC0", VA = "0x185AB9CC0")]
	public LJDGIPCJKNC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KJOPOIKFBIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BNOBHCOBGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int GPHHCDNKOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float IMJKALBJBHK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<FOAFCDJCFCE> JGJIGHFCAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5C70", Offset = "0x5AB4A70", VA = "0x185AB5C70")]
	public KJOPOIKFBIH(int BNOBHCOBGCC, int GPHHCDNKOLA, float AOKPNCPHFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5AB58A0", Offset = "0x5AB46A0", VA = "0x185AB58A0")]
	public void DIMGJCPMGAB(PLOFOKCPPIB KJFPGKBHOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5AB59C0", Offset = "0x5AB47C0", VA = "0x185AB59C0")]
	private int EIBDIHELGBF(LFFMGICFEBB CKNHANKHIBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5660", Offset = "0x5AB4460", VA = "0x185AB5660")]
	private void DIMGJCPMGAB(LFFMGICFEBB CKNHANKHIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5A60", Offset = "0x5AB4860", VA = "0x185AB5A60")]
	private void PLEPDDMIDAE(LFFMGICFEBB CKNHANKHIBG, FOAFCDJCFCE GJKKJKAPOLB)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PPHDMJCJBKF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EGLBCHHNKFL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public EGLBCHHNKFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE120", Offset = "0x5AACF20", VA = "0x185AAE120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE2D0", Offset = "0x5AAD0D0", VA = "0x185AAE2D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE230", Offset = "0x5AAD030", VA = "0x185AAE230", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE230", Offset = "0x5AAD030", VA = "0x185AAE230", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int MOBPEKJCEFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5AACD10", Offset = "0x5AABB10", VA = "0x185AACD10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<IHCPNPJBNNO> FCMCBHADABA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5AACCF0", Offset = "0x5AABAF0", VA = "0x185AACCF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> OIBAJOBEIPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FOAFCDJCFCE CHIKAFEPNIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GMGGJMPGPGK GNKOJHBBBCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x706AD0", Offset = "0x7058D0", VA = "0x180706AD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(GMGGJMPGPGK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x706C30", Offset = "0x705A30", VA = "0x180706C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GDPDOMKBMHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5AACD00", Offset = "0x5AABB00", VA = "0x185AACD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB8D0", Offset = "0x5AAA6D0", VA = "0x185AAB8D0")]
		public static ClusterMeshRenderer Create(FOAFCDJCFCE DPOJLBHHPEO, ClusterMeshRenderer NAFFPODNEPG, MeshFilter IJAHLNMKLMH, MCIOIOFPDFL DCJJENKGKJB, GMGGJMPGPGK OMGDGKEEKOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5AABA70", Offset = "0x5AAA870", VA = "0x185AABA70", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC230", Offset = "0x5AAB030", VA = "0x185AAC230", Slot = "10")]
		public bool TryRemoveClusterLODComponent(MHPDBOENDNG BJCJNGNNING)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC020", Offset = "0x5AAAE20", VA = "0x185AAC020")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AABCC0", Offset = "0x5AAAAC0", VA = "0x185AABCC0")]
		public void Init(FOAFCDJCFCE DPOJLBHHPEO, MeshFilter IJAHLNMKLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AABAD0", Offset = "0x5AAA8D0", VA = "0x185AABAD0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC360", Offset = "0x5AAB160", VA = "0x185AAC360", Slot = "8")]
		public void UpdateClusterDistances(Vector3 OOJIJOLPAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC570", Offset = "0x5AAB370", VA = "0x185AAC570", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5AABC50", Offset = "0x5AAAA50", VA = "0x185AABC50")]
		[IteratorStateMachine(typeof(EGLBCHHNKFL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC0A0", Offset = "0x5AAAEA0", VA = "0x185AAC0A0")]
		public void SetupTagAndLayer(string OLELIGEEOMM, int OMGDGKEEKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC080", Offset = "0x5AAAE80", VA = "0x185AAC080")]
		public bool Remove(MHPDBOENDNG BJCJNGNNING)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FFDIDPKJFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FBAPKIHJCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int PGFGHPKFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int LGEEIEEFHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int EKPCEBDDKAC;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE720", Offset = "0x5AAD520", VA = "0x185AAE720")]
	public FFDIDPKJFOJ(int PGFGHPKFPLO, int LGEEIEEFHKK, int FBAPKIHJCEG, int EKPCEBDDKAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BAGEPFAABNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> NIFBEPAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> MJNDGCAPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> AJGFBNHKPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<FFDIDPKJFOJ> NCJAMNCMCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> NDDIDEDOBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> NJDNPJKPPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> AMJGIHPHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle FMCMEMBCJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LELALLAJPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB6C7D0", Offset = "0xB6B5D0", VA = "0x180B6C7D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB6C810", Offset = "0xB6B610", VA = "0x180B6C810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA450", Offset = "0x5AA9250", VA = "0x185AAA450")]
	public void KKLPLLLGLNM(GHDHHNDLKIN NDEOLBOGKIO, NativeList<FFDIDPKJFOJ> NCJAMNCMCDH, float CPAOPLMBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5AAB370", Offset = "0x5AAA170", VA = "0x185AAB370")]
	public void PHEIBFBGKJD(Transform DCJJENKGKJB, bool BADKKHKHBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA2A0", Offset = "0x5AA90A0", VA = "0x185AAA2A0")]
	public void GNODDILIADP(FOAFCDJCFCE JANOPLPFDEP, bool ADCFEMKAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA160", Offset = "0x5AA8F60", VA = "0x185AAA160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5AAA270", Offset = "0x5AA9070", VA = "0x185AAA270")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public BAGEPFAABNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct LPGBGAHMHJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> NIFBEPAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> MJNDGCAPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<FFDIDPKJFOJ> IPBGCICFPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> NDDIDEDOBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 HAODALHLFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> NJDNPJKPPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> AMJGIHPHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool BADKKHKHBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float IMMKHMKJCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float DNHAIFBIBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float PIBCFENKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> AJGFBNHKPHM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ABA9A0", Offset = "0x5AB97A0", VA = "0x185ABA9A0")]
	public LPGBGAHMHJL(BAGEPFAABNC JBBJDJGADDD, Vector3 HAODALHLFCI, bool BADKKHKHBID, float IMMKHMKJCMP, float DNHAIFBIBDP, float PIBCFENKOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ABA510", Offset = "0x5AB9310", VA = "0x185ABA510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MHPDBOENDNG : PHHKHDHCLGL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds MOHJHGJIALD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MPLDDCIADOK NJJPGGJPFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LFFMGICFEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<MHPDBOENDNG> ELCPBBOBCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public LFFMGICFEBB AABHIBJPKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public LFFMGICFEBB FBHGKMIJOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public LFFMGICFEBB JMFMJIAJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int EKPCEBDDKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds KHDGHDAJIBK;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AB62F0", Offset = "0x5AB50F0", VA = "0x185AB62F0")]
	public LFFMGICFEBB(List<MHPDBOENDNG> ELCPBBOBCBJ, [Optional] LFFMGICFEBB AABHIBJPKOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PLOFOKCPPIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<LFFMGICFEBB> HJNLHCIGFAJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LFFMGICFEBB CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCB90", Offset = "0x5ABB990", VA = "0x185ABCB90")]
	public PLOFOKCPPIB(LFFMGICFEBB DCJJENKGKJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OJDEPKKEDHB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OEELFACPOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int COKHIADMGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int DCNINLKLCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EDEFCAAIJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int IJCLAPHNFIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FDMOIFNLLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int PLLONFKMICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float MOAGEMFDNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<MHPDBOENDNG> ELCPBBOBCBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HPHOBIFFJBE
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
	private OEELFACPOPO JDICBNPOINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int HKABOKPKEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int BNOBHCOBGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int GPHHCDNKOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float AOKPNCPHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float OEGFDCHEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<LFFMGICFEBB> PNCHHIMNNJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PLOFOKCPPIB FLFEPKCIAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCA30", Offset = "0x5ABB830", VA = "0x185ABCA30")]
	public OJDEPKKEDHB(int BNOBHCOBGCC, int GPHHCDNKOLA, float AOKPNCPHFMI, int HKABOKPKEKA, float OEGFDCHEJPG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBAD0", Offset = "0x5ABA8D0", VA = "0x185ABBAD0")]
	public void OCJBKODNGFE(List<MHPDBOENDNG> ELCPBBOBCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC130", Offset = "0x5ABAF30", VA = "0x185ABC130")]
	public bool PPEJFKONPLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5ABADD0", Offset = "0x5AB9BD0", VA = "0x185ABADD0")]
	private float KABAINAKEEN(Vector3 FEFPPFDPNGK, Vector3 PEEJGOJECJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAE50", Offset = "0x5AB9C50", VA = "0x185ABAE50")]
	private float KABAINAKEEN(Vector3 MBCLCCPKDLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5ABC1A0", Offset = "0x5ABAFA0", VA = "0x185ABC1A0")]
	private bool PPOADHCJOAH(LFFMGICFEBB JBGGEBGNIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9CA0", VA = "0x185ABAEA0")]
	private FDMOIFNLLEO MPFGGCJEFNA(List<MHPDBOENDNG> PLFNNOFILGG, HPHOBIFFJBE HKLBBCGEHKE)
	{
		return default(FDMOIFNLLEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5ABBCD0", Offset = "0x5ABAAD0", VA = "0x185ABBCD0")]
	private void PHALJLEJBPB(List<MHPDBOENDNG> ELCPBBOBCBJ, Vector3[] OBHJGFDIFNP, Vector3[] FIHFNNEBOJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OBEEOJHBCOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAC20", Offset = "0x5AB9A20", VA = "0x185ABAC20")]
	public static Bounds OCGPMHPEFHP(List<MHPDBOENDNG> ELCPBBOBCBJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAA70", Offset = "0x5AB9870", VA = "0x185ABAA70")]
	public static int ANHOKDNAKKK(List<MHPDBOENDNG> ELCPBBOBCBJ, NNCAOIFLNAP NJPOLOKEGLO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EABPBJLKLKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private GHDHHNDLKIN KDJMMPIKOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private GHDHHNDLKIN DOODPICNECA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static GHDHHNDLKIN EGONJHOPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private HMOKJIGBJJG PKOGCFFAINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private HJIHHAKMHAF AFHHJDDLHFP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle FMCMEMBCJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x73D550", Offset = "0x73C350", VA = "0x18073D550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FOAFCDJCFCE.FHJJKJIKAJI JBGGEBGNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KNDDGFFGMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x91A770", Offset = "0x919570", VA = "0x18091A770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AACD70", Offset = "0x5AABB70", VA = "0x185AACD70")]
	[PONPKGMPDGG(ELCDPILLABI.ExitingPlayMode, 0)]
	private static void ACDLOGHIDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5AACE90", Offset = "0x5AABC90", VA = "0x185AACE90")]
	public void KKLPLLLGLNM(FOAFCDJCFCE.FHJJKJIKAJI IPBGCICFPFH, Transform ANLLMACALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AAD990", Offset = "0x5AAC790", VA = "0x185AAD990")]
	public void MCAGGGKJBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AACDE0", Offset = "0x5AABBE0", VA = "0x185AACDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AACE50", Offset = "0x5AABC50", VA = "0x185AACE50")]
	public void FDAOBHPPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AAE080", Offset = "0x5AACE80", VA = "0x185AAE080")]
	public EABPBJLKLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OBMHJEHIAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LFGLNLDAEKB GCAKCBLIAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MCOEJLDOACG
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 KIIKOEFCLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GJJDAPMAAKE
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(KHFLMDIKDOP NOGGCKIKFDF, CancellationToken ONFKFAAPNBK);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ACMIDHDFHFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACMIDHDFHFJ HAACJCPELIJ(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACMIDHDFHFJ HMOKFAFIBPB(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ACMIDHDFHFJ DKLKADDFKEE(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ACMIDHDFHFJ ACLJEMGGPGL(Action KKJDJCJOLIF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class FDCHDNFJBNN : ACMIDHDFHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BEDCFEOMDCF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public FDCHDNFJBNN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public BEDCFEOMDCF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5AAB660", Offset = "0x5AAA460", VA = "0x185AAB660")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5AAB6B0", Offset = "0x5AAA4B0", VA = "0x185AAB6B0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5AAB700", Offset = "0x5AAA500", VA = "0x185AAB700")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> GBKBDHGDMIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action JECINMNEPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action FJOHCPICAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private ODOLJALHJFC AONMHPJOFCM;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AIMMNNAJPKE
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action OEPPFHMAGBC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x783820", Offset = "0x782620", VA = "0x180783820", Slot = "4")]
			public ACMIDHDFHFJ HAACJCPELIJ(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x29ED440", Offset = "0x29EC240", VA = "0x1829ED440", Slot = "5")]
			public ACMIDHDFHFJ HMOKFAFIBPB(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x29ED460", Offset = "0x29EC260", VA = "0x1829ED460", Slot = "6")]
			public ACMIDHDFHFJ DKLKADDFKEE(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3935440", Offset = "0x3934240", VA = "0x183935440", Slot = "7")]
			public ACMIDHDFHFJ ACLJEMGGPGL(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
			public FDCHDNFJBNN(Func<JobHandle> HACFAOEBPFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE310", Offset = "0x5AAD110", VA = "0x185AAE310")]
			public void BEHKAEOBGKH(Action FKNENKKDMPN, Action OBDAFOFNEIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE5A0", Offset = "0x5AAD3A0", VA = "0x185AAE5A0")]
			public void IHKCCNMHHEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FELFFHHKOHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public ACMIDHDFHFJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public FELFFHHKOHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5AAE710", Offset = "0x5AAD510", VA = "0x185AAE710")]
			internal bool <Remove>b__0(FDCHDNFJBNN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KHCJMHBLGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FDCHDNFJBNN newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public KHCJMHBLGCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5AB4E80", Offset = "0x5AB3C80", VA = "0x185AB4E80")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<FDCHDNFJBNN> NFMFCNIMHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<FDCHDNFJBNN> OCAGJOFCMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private OMJDCAMIDEI GGACJDDAMNA;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AFHBFJENEOD IAEEPFPICBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB40A0", Offset = "0x5AB2EA0", VA = "0x185AB40A0")]
		public ACMIDHDFHFJ Add(Func<JobHandle> HACFAOEBPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AB43A0", Offset = "0x5AB31A0", VA = "0x185AB43A0")]
		public void Remove(ACMIDHDFHFJ FMCMEMBCJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4200", Offset = "0x5AB3000", VA = "0x185AB4200", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4570", Offset = "0x5AB3370", VA = "0x185AB4570")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AB47C0", Offset = "0x5AB35C0", VA = "0x185AB47C0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AB41F0", Offset = "0x5AB2FF0", VA = "0x185AB41F0")]
		[CompilerGenerated]
		private void JIFHICDCNLJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface ODOLJALHJFC
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODOLJALHJFC HAACJCPELIJ(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODOLJALHJFC GMNLIEMAHGN(Action KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODOLJALHJFC ACLJEMGGPGL(Action KKJDJCJOLIF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LNPHHJKKICG : ODOLJALHJFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle EHLJCAAEBGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action JECINMNEPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action LBFBKGJJPAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action OEPPFHMAGBC;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool BOOHAEHGJAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5ABA420", Offset = "0x5AB9220", VA = "0x185ABA420")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x29ED440", Offset = "0x29EC240", VA = "0x1829ED440", Slot = "4")]
			public ODOLJALHJFC HAACJCPELIJ(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x29ED460", Offset = "0x29EC260", VA = "0x1829ED460", Slot = "5")]
			public ODOLJALHJFC GMNLIEMAHGN(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3935440", Offset = "0x3934240", VA = "0x183935440", Slot = "6")]
			public ODOLJALHJFC ACLJEMGGPGL(Action KKJDJCJOLIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x10CD220", Offset = "0x10CC020", VA = "0x1810CD220")]
			public LNPHHJKKICG(JobHandle KAGFFFJIJNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5ABA430", Offset = "0x5AB9230", VA = "0x185ABA430")]
			public void EMMGNHCOPMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5ABA470", Offset = "0x5AB9270", VA = "0x185ABA470")]
			public void IHKCCNMHHEB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<LNPHHJKKICG> LOFIKPGLMNF;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4CA0", Offset = "0x5AB3AA0", VA = "0x185AB4CA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB48C0", Offset = "0x5AB36C0", VA = "0x185AB48C0")]
		public ODOLJALHJFC Add(JobHandle KAGFFFJIJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4BB0", Offset = "0x5AB39B0", VA = "0x185AB4BB0")]
		public void Remove(ODOLJALHJFC FMCMEMBCJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4A40", Offset = "0x5AB3840", VA = "0x185AB4A40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4950", Offset = "0x5AB3750", VA = "0x185AB4950")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4DC0", Offset = "0x5AB3BC0", VA = "0x185AB4DC0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5CC0", Offset = "0x5AB4AC0", VA = "0x185AB5CC0")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5DD0", Offset = "0x5AB4BD0", VA = "0x185AB5DD0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
