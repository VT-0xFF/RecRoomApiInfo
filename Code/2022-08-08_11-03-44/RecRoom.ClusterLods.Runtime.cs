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
				[Cpp2IlInjected.Address(RVA = "0x48CC510", Offset = "0x48CB510", VA = "0x1848CC510")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1103230", Offset = "0x1102230", VA = "0x181103230")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x48CC4D0", Offset = "0x48CB4D0", VA = "0x1848CC4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x48C1570", Offset = "0x48C0570", VA = "0x1848C1570")]
		public LODSettings BPADAPFGOHN(OKPEIMECIFD LFLCDEHCKMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x48C1580", Offset = "0x48C0580", VA = "0x1848C1580")]
		public int OGMGPMPNBMH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x48C15A0", Offset = "0x48C05A0", VA = "0x1848C15A0")]
		public int PNACLBJLIGI(bool CFIILILEBAI, Vector3 HHJPPGBJCGL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x48C16A0", Offset = "0x48C06A0", VA = "0x1848C16A0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LHILLGHCHCE
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
public interface OKFOBCOAGKB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHCNDKLNNFK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CAFPCJIKLPD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PPPIKBJDFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<HOGPMLNLBMN> ALCCMNCLOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LHILLGHCHCE JFGCMFFHFFB
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
	void UpdateClusterDistances(Vector3 FPJLIKGIMCG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(KPKDAGINBKI LIHCFPMBOOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HOGPMLNLBMN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int IGNEEDDMIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KIOEGHFEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FCKKNIFJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DFMIDEHNNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte LOAMDIKAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PINPNMLOHMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FCDAMGIEJFL
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
	private struct EAPKCLIGFEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PINPNMLOHMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MLACCLOKFHB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MLACCLOKFHB <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x48C5BC0", Offset = "0x48C4BC0", VA = "0x1848C5BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KMBPOAOIINB : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private NGOCCMDJJLC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PINPNMLOHMP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
		[DebuggerHidden]
		public KMBPOAOIINB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x48CB490", Offset = "0x48CA490", VA = "0x1848CB490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x48CB550", Offset = "0x48CA550", VA = "0x1848CB550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AFCDJBGICCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PINPNMLOHMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public MLACCLOKFHB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MLACCLOKFHB <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x48BEFF0", Offset = "0x48BDFF0", VA = "0x1848BEFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KMNOBHCHINC : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NGOCCMDJJLC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PINPNMLOHMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
		[DebuggerHidden]
		public KMNOBHCHINC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x48CB5A0", Offset = "0x48CA5A0", VA = "0x1848CB5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x48CC480", Offset = "0x48CB480", VA = "0x1848CC480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int JEFLHCLGIBP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan LEJFHLMOFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer MBHCGMCAELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter AJDBHHDOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject CKMOHMFFAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject DDKAEFJDBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public DPCDDFJFEMA HHDBICHDIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<KPKDAGINBKI> KDDBIKCCOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<KPKDAGINBKI> FLEANCAHCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<KPKDAGINBKI> POCAOBJEMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BOPOGCMCFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FCDAMGIEJFL NIKIAEPDFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CAFPCJIKLPD>[] HPNHHKBEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<HOGPMLNLBMN>[] KONEEKGOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource AHOOFMFKANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool OGLJBEAMLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private JLELHLFHMNH BJFDDLNKHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JLELHLFHMNH JGDKINEIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int MMEDLHJENBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int EIEBGNIIAOF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static PINPNMLOHMP GJOLDIFNPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BNLEPOCCCMA HOMOKPEFLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HAHBJMECKAE EEKKBFCJBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour OJJHJMLDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material GABAEBPCMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<OKFOBCOAGKB> OIHEBCHPKBI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig BBNIFMFHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 AIPAMAFDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1146070", Offset = "0x1145070", VA = "0x181146070")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1145FA0", Offset = "0x1144FA0", VA = "0x181145FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private FCDAMGIEJFL IOCNGEKNLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F8CD0", Offset = "0x5F7CD0", VA = "0x1805F8CD0")]
		get
		{
			return default(FCDAMGIEJFL);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x48D0C10", Offset = "0x48CFC10", VA = "0x1848D0C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PINPNMLOHMP CEPBJDBANMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x48CF4F0", Offset = "0x48CE4F0", VA = "0x1848CF4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HJFKHCBKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x48CFD90", Offset = "0x48CED90", VA = "0x1848CFD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OAIGGJCDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x48D0750", Offset = "0x48CF750", VA = "0x1848D0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> BEMILJJPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x48CE470", Offset = "0x48CD470", VA = "0x1848CE470")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x48CED40", Offset = "0x48CDD40", VA = "0x1848CED40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GGNHMCEMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48CFB50", Offset = "0x48CEB50", VA = "0x1848CFB50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x48CFAB0", Offset = "0x48CEAB0", VA = "0x1848CFAB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x48D0DA0", Offset = "0x48CFDA0", VA = "0x1848D0DA0")]
	public PINPNMLOHMP(BNLEPOCCCMA HOMOKPEFLJE, HAHBJMECKAE EEKKBFCJBMK, ClusterLODConfig PKJHKGOHMOK, MonoBehaviour OJJHJMLDHBI, Material GABAEBPCMIH, ClusterMeshRenderer MBHCGMCAELB, MeshFilter AJDBHHDOPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x48CF1C0", Offset = "0x48CE1C0", VA = "0x1848CF1C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x48D0630", Offset = "0x48CF630", VA = "0x1848D0630")]
	public static void KNFBDMPIEHN(Vector3 IMAHELCIBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48CE3E0", Offset = "0x48CD3E0", VA = "0x1848CE3E0")]
	private void BEBPCFMOMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x48CF3F0", Offset = "0x48CE3F0", VA = "0x1848CF3F0")]
	private void FGKKCLGIOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48D0000", Offset = "0x48CF000", VA = "0x1848D0000")]
	private void JOHIAENFINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48D0140", Offset = "0x48CF140", VA = "0x1848D0140")]
	public void KMNKHEPPBOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x48CFC50", Offset = "0x48CEC50", VA = "0x1848CFC50")]
	[AsyncStateMachine(typeof(EAPKCLIGFEH))]
	public Task IKNCOGHMKGH(MLACCLOKFHB HDALINEEMFB, CancellationToken GADEANLIDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48CFF90", Offset = "0x48CEF90", VA = "0x1848CFF90")]
	[IteratorStateMachine(typeof(KMBPOAOIINB))]
	private IEnumerator<NGOCCMDJJLC> JKPNHNMFCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48D0830", Offset = "0x48CF830", VA = "0x1848D0830")]
	[AsyncStateMachine(typeof(AFCDJBGICCJ))]
	private Task NEGGPBLNIIG(MLACCLOKFHB GIMKIGEELKB, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48CEDE0", Offset = "0x48CDDE0", VA = "0x1848CEDE0")]
	public void DECGIJADIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48CFEB0", Offset = "0x48CEEB0", VA = "0x1848CFEB0")]
	public void IPOMKBAKKPC(IEnumerable<CAFPCJIKLPD> ANIAIFGLMIA, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48CF630", Offset = "0x48CE630", VA = "0x1848CF630")]
	public void GIFFHFHECJN(IEnumerable<CAFPCJIKLPD> ANIAIFGLMIA, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48CE510", Offset = "0x48CD510", VA = "0x1848CE510")]
	public List<ClusterMeshRenderer> CHMDBGFJMCL(List<KPKDAGINBKI> GDAAIMGFJFP, OHJKLNPKNGO JJKPMHEEPII, LHILLGHCHCE EOGMHJEKNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x48CED00", Offset = "0x48CDD00", VA = "0x1848CED00")]
	public LHILLGHCHCE CJCDFKBIPHD(Vector3 BDDDGAJFHMG)
	{
		return default(LHILLGHCHCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48CFA50", Offset = "0x48CEA50", VA = "0x1848CFA50")]
	public void HCFLCJPEPAN(OKFOBCOAGKB KHCIBMFLIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48CFF30", Offset = "0x48CEF30", VA = "0x1848CFF30")]
	public bool JDNEADFEKPA(OKFOBCOAGKB KHCIBMFLIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48CFBF0", Offset = "0x48CEBF0", VA = "0x1848CFBF0")]
	public void HFKHKAHAMGP(KPKDAGINBKI JNBOHMMAIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48D0970", Offset = "0x48CF970", VA = "0x1848D0970")]
	public void NHBIFGFIHBF(HOGPMLNLBMN APJDICMKPPA, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48CF5B0", Offset = "0x48CE5B0", VA = "0x1848CF5B0")]
	public void GECAFNHHEOF(HOGPMLNLBMN APJDICMKPPA, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48CF2C0", Offset = "0x48CE2C0", VA = "0x1848CF2C0")]
	private void EMEJMDPEHHI(Vector3 FPJLIKGIMCG, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48D09F0", Offset = "0x48CF9F0", VA = "0x1848D09F0")]
	private void NOALJCNABMI(Vector3 FPJLIKGIMCG, LHILLGHCHCE EOGMHJEKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48D0BA0", Offset = "0x48CFBA0", VA = "0x1848D0BA0")]
	[IteratorStateMachine(typeof(KMNOBHCHINC))]
	private IEnumerator<NGOCCMDJJLC> PFALLPOCJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48CF8E0", Offset = "0x48CE8E0", VA = "0x1848CF8E0")]
	private int GOHBCHGBAAN(int IIHEDPBOLFE, int DCLLGKGHPLL, List<HOGPMLNLBMN> LOFKBMNHNAC, byte LFLCDEHCKMP, ref int LLIIMGCMGDG, float NOCHLLKFGLD = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48CEFF0", Offset = "0x48CDFF0", VA = "0x1848CEFF0")]
	public void DKCILJPFPEA(KPKDAGINBKI LIHCFPMBOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48CE3A0", Offset = "0x48CD3A0", VA = "0x1848CE3A0")]
	public bool AJLAFFGNEGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0")]
	public Material HIDCGIDBDIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x48D0B60", Offset = "0x48CFB60", VA = "0x1848D0B60")]
	public int OGMGPMPNBMH()
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
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct PIBCLCNHENG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> NCLGHMEPHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> CJMOJAOJAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> EFADHBEHFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> BLDMMDBCDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> ONFMGJEMECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> BKMGCALIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> CHGGGNJDGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 MFDBPNPBGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float LPKGBNJEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> CAHKGCCOINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> KIKLLENOFCC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x48CE2E0", Offset = "0x48CD2E0", VA = "0x1848CE2E0")]
	public PIBCLCNHENG(FIKOKBLMAKH OONJFFKJHPD, NativeList<float3> CHGGGNJDGLN, NativeMultiHashMap<int, int> CAHKGCCOINH, NativeArray<int> KIKLLENOFCC, Vector3 MFDBPNPBGPN, float LPKGBNJEHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x48CDBF0", Offset = "0x48CCBF0", VA = "0x1848CDBF0")]
	private int EDEFKLJGDMC(float3 FPJLIKGIMCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x48CE040", Offset = "0x48CD040", VA = "0x1848CE040")]
	private int PDJECEMCNMI(int BJNKEHJJEBP, int GGLJFLNJABJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48CDC50", Offset = "0x48CCC50", VA = "0x1848CDC50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NMEIKFJOBOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> CAHKGCCOINH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> KIKLLENOFCC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int DNJKKHNGGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> MNDKHHOPHGH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x48CD7E0", Offset = "0x48CC7E0", VA = "0x1848CD7E0")]
	public void GNANPNMPIMH(int BHNFLNKDPAP, Allocator LKNIKCJFBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x48CD730", Offset = "0x48CC730", VA = "0x1848CD730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NMEIKFJOBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct AHLNBANOCDC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> ILMKGDAICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> LNMEBJCDMDF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x48C03A0", Offset = "0x48BF3A0", VA = "0x1848C03A0")]
	public AHLNBANOCDC(NMEIKFJOBOM ACEAKIMOPGI, FIKOKBLMAKH OONJFFKJHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x48C0310", Offset = "0x48BF310", VA = "0x1848C0310", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct GHEIFLKNLDG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> MGPDNBOGKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> NEABGAIHEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> NLLLOIJIPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> IHEOJKBKANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> NDJHFDNHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> MNDKHHOPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> ILMKGDAICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> JJPENIEGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> JEJMHJOEOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> BBANBHDNGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> AMNENDIFOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> DDCFIENFMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> IEKMGPPIPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float AEPDHCFHJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float FEIKFFBOELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 EGADPMHMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float KKNGIPNNILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float JPCBMHBAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float KEOEBHPOCHG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48C81B0", Offset = "0x48C71B0", VA = "0x1848C81B0")]
	public GHEIFLKNLDG(NMEIKFJOBOM OENDMEANPOC, FIKOKBLMAKH OONJFFKJHPD, FIKOKBLMAKH GNNNFAPKEIH, float JPCBMHBAHFJ, float KEOEBHPOCHG, Vector3 EGADPMHMFJI, float KKNGIPNNILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x48C7E50", Offset = "0x48C6E50", VA = "0x1848C7E50")]
	private float3 KDFNJMKOLFN(int BJNKEHJJEBP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48C7AE0", Offset = "0x48C6AE0", VA = "0x1848C7AE0")]
	private void JAAMCJGDMMA(int BJNKEHJJEBP, out float3 GODGIOGMNDA, out float3 MDKIHIGDLNI, out float4 EPEKFEOHECP, out float4 FGNBNBBLFON, out float2 PKGHCGHGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x48C7790", Offset = "0x48C6790", VA = "0x1848C7790")]
	private int HAMBMKBPKGL(int KCPLCMHDMFC, int DCIIOEIHJKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x48C7FB0", Offset = "0x48C6FB0", VA = "0x1848C7FB0")]
	private void PAKBIKGFPON(int KCPLCMHDMFC, int DCIIOEIHJKB, int ADDCDMBLBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x48C7CC0", Offset = "0x48C6CC0", VA = "0x1848C7CC0")]
	private bool JNJIFFPALDI(int KCPLCMHDMFC, int DCIIOEIHJKB, float AMFOCNBLCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x48C7EF0", Offset = "0x48C6EF0", VA = "0x1848C7EF0")]
	private bool NCADKEGPGBM(int KCPLCMHDMFC, int DCIIOEIHJKB, int ADDCDMBLBON, float AMFOCNBLCCD, bool IDNEFECFEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x48C7530", Offset = "0x48C6530", VA = "0x1848C7530")]
	private bool FOJHECBHHAE(int KCPLCMHDMFC, int DCIIOEIHJKB, int ADDCDMBLBON, float AMFOCNBLCCD, bool IDNEFECFEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x48C7AC0", Offset = "0x48C6AC0", VA = "0x1848C7AC0")]
	private void ICMMABNBPJI(int KCPLCMHDMFC, int DCIIOEIHJKB, int ADDCDMBLBON, out int IFMLJDHJDCK, out int NOBJAMHHDJB, out int EMDMHJCEECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48C6BD0", Offset = "0x48C5BD0", VA = "0x1848C6BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DGAOLEHJHDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BDMMCHFPFNF : IDisposable, HOGPMLNLBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds CPMOCNNLOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<KPKDAGINBKI> GDAAIMGFJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 LHONLOPMELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 GGDCHGKIHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int OKIOKDNBPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FIKOKBLMAKH JFGPFNDNFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NMEIKFJOBOM KBCOIEPFLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform JJKPMHEEPII;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int GFGILGJLPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x48C06F0", Offset = "0x48BF6F0", VA = "0x1848C06F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh PFCJLPOCLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh FLGOLNOHCGD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FCKKNIFJPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x15E7660", Offset = "0x15E6660", VA = "0x1815E7660", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2090E50", Offset = "0x208FE50", VA = "0x182090E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte LOAMDIKAFKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x735870", Offset = "0x734870", VA = "0x180735870")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734A00", VA = "0x180735A00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IGNEEDDMIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x781800", Offset = "0x780800", VA = "0x180781800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x780E90", Offset = "0x77FE90", VA = "0x180780E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int KIOEGHFEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBB4EA0", Offset = "0xBB3EA0", VA = "0x180BB4EA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE38F50", Offset = "0xE37F50", VA = "0x180E38F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DFMIDEHNNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x48C0B60", Offset = "0x48BFB60", VA = "0x1848C0B60", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x48C04C0", Offset = "0x48BF4C0", VA = "0x1848C04C0")]
		public void AMPBLDEBPCJ(OKPEIMECIFD LFLCDEHCKMP, out int IOHDHKEAMHE, out int HACGPCFNHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x48C09C0", Offset = "0x48BF9C0", VA = "0x1848C09C0")]
		public void GAKEEANDEPH(OKPEIMECIFD LFLCDEHCKMP, MIHHEFJFMAI NKCMADMIDOF, int DCPOPAAKCDN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x48C0C20", Offset = "0x48BFC20", VA = "0x1848C0C20")]
		public void LLBGAEKHFLE(NativeList<MIDEBJGHMKH> AHLINOGBDLF, Transform MLABPENBJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x48C0B80", Offset = "0x48BFB80", VA = "0x1848C0B80")]
		public void LDCGDEKOLFG(Mesh OONJFFKJHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x48C0920", Offset = "0x48BF920", VA = "0x1848C0920")]
		public void FMDDLKPKHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x48C0730", Offset = "0x48BF730", VA = "0x1848C0730", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x48C0F40", Offset = "0x48BFF40", VA = "0x1848C0F40")]
		public BDMMCHFPFNF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds CPMOCNNLOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<BDMMCHFPFNF> JNGFPKMHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public DLCDENKMLPH FNEPGPJDLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer GPBPHMJHPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int OPBLBNKHIMB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh CPHENKIENNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KJHHLEHMCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E70", Offset = "0x7D5E70", VA = "0x1807D6E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EF0", Offset = "0x7D5EF0", VA = "0x1807D6EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PPPIKBJDFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x48C2EF0", Offset = "0x48C1EF0", VA = "0x1848C2EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x48C2D90", Offset = "0x48C1D90", VA = "0x1848C2D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x48C3E40", Offset = "0x48C2E40", VA = "0x1848C3E40")]
	public int NGNPJMIDMGG(int FEANNENGNAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x48C30F0", Offset = "0x48C20F0", VA = "0x1848C30F0")]
	public void INPGPKAONMI(HDILJPEDFNF FIJJELCHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x48C36E0", Offset = "0x48C26E0", VA = "0x1848C36E0")]
	public void LGJLMFNHOCC(Transform MLABPENBJAG, bool GNJOAPMFBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x48C2F40", Offset = "0x48C1F40", VA = "0x1848C2F40")]
	public bool HDLJAKEIIDO(bool HPNADNBKCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x48C3280", Offset = "0x48C2280", VA = "0x1848C3280")]
	public void LEPCHDCMCOG(Transform JJKPMHEEPII, bool GNJOAPMFBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x48C2B10", Offset = "0x48C1B10", VA = "0x1848C2B10")]
	public bool DKCILJPFPEA(KPKDAGINBKI LIHCFPMBOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x48C3E70", Offset = "0x48C2E70", VA = "0x1848C3E70")]
	public DGAOLEHJHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DPCDDFJFEMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<DGAOLEHJHDD.BDMMCHFPFNF> FLNNLJLPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NHOJHLFIEBF KHKDEECBKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<DGAOLEHJHDD.BDMMCHFPFNF> EFHKKCIPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CJDMKGABCIN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48C5500", Offset = "0x48C4500", VA = "0x1848C5500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48C5950", Offset = "0x48C4950", VA = "0x1848C5950")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48C59D0", Offset = "0x48C49D0", VA = "0x1848C59D0")]
	public void PPCBFHPPBHE(DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC, Transform JJKPMHEEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x48C5350", Offset = "0x48C4350", VA = "0x1848C5350")]
	public void DKCILJPFPEA(DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x48C51E0", Offset = "0x48C41E0", VA = "0x1848C51E0")]
	private DGAOLEHJHDD.BDMMCHFPFNF ACENGBJGMGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48C5570", Offset = "0x48C4570", VA = "0x1848C5570")]
	private bool EBFIJBCNEAC(DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x48C5660", Offset = "0x48C4660", VA = "0x1848C5660")]
	private void KDIJDAFFKFO(DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48C5310", Offset = "0x48C4310", VA = "0x1848C5310")]
	public bool AJCCIGNNAJH(DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48C56C0", Offset = "0x48C46C0", VA = "0x1848C56C0")]
	public bool LNGAPHKLFPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x48C5600", Offset = "0x48C4600", VA = "0x1848C5600")]
	private DGAOLEHJHDD.BDMMCHFPFNF IEJHMOMFCFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x48C5A80", Offset = "0x48C4A80", VA = "0x1848C5A80")]
	public DPCDDFJFEMA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JGKHOJMEMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HADDKLPJHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int KMJHOBCDFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float EHHMNFJFJGF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<DGAOLEHJHDD> HONIHGOMEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x48CA830", Offset = "0x48C9830", VA = "0x1848CA830")]
	public JGKHOJMEMLM(int HADDKLPJHPO, int KMJHOBCDFOF, float DFNAKJDCIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x48CA790", Offset = "0x48C9790", VA = "0x1848CA790")]
	public void HBFCIMKIHJD(ELBOJLFHNBK EOLDEKIHNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48CA2E0", Offset = "0x48C92E0", VA = "0x1848CA2E0")]
	private int AFFMOKHLICF(HDILJPEDFNF NNENOHEDIAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48CA560", Offset = "0x48C9560", VA = "0x1848CA560")]
	private void HBFCIMKIHJD(HDILJPEDFNF NNENOHEDIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48CA380", Offset = "0x48C9380", VA = "0x1848CA380")]
	private void CLEAFCCMNOI(HDILJPEDFNF NNENOHEDIAL, DGAOLEHJHDD LMHGODOLPGN)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CAFPCJIKLPD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OOKGGEMMHJP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
			[DebuggerHidden]
			public OOKGGEMMHJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x48CD980", Offset = "0x48CC980", VA = "0x1848CD980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x48CDB10", Offset = "0x48CCB10", VA = "0x1848CDB10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x48CDA70", Offset = "0x48CCA70", VA = "0x1848CDA70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x48CDA70", Offset = "0x48CCA70", VA = "0x1848CDA70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PPPIKBJDFCA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x48C2AB0", Offset = "0x48C1AB0", VA = "0x1848C2AB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<HOGPMLNLBMN> ALCCMNCLOJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x48C2A90", Offset = "0x48C1A90", VA = "0x1848C2A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> JNGFPKMHFIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DGAOLEHJHDD CPHENKIENNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LHILLGHCHCE JFGCMFFHFFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E6390", Offset = "0x5E5390", VA = "0x1805E6390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(LHILLGHCHCE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7EF880", Offset = "0x7EE880", VA = "0x1807EF880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool PLBPPLPJBOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x48C2AA0", Offset = "0x48C1AA0", VA = "0x1848C2AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x48C1700", Offset = "0x48C0700", VA = "0x1848C1700")]
		public static ClusterMeshRenderer Create(DGAOLEHJHDD OONJFFKJHPD, ClusterMeshRenderer MBHCGMCAELB, MeshFilter AJDBHHDOPEP, OHJKLNPKNGO JJKPMHEEPII, LHILLGHCHCE EOGMHJEKNKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x48C1880", Offset = "0x48C0880", VA = "0x1848C1880", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x48C2000", Offset = "0x48C1000", VA = "0x1848C2000", Slot = "10")]
		public bool TryRemoveClusterLODComponent(KPKDAGINBKI LIHCFPMBOOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x48C1DD0", Offset = "0x48C0DD0", VA = "0x1848C1DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x48C1AE0", Offset = "0x48C0AE0", VA = "0x1848C1AE0")]
		public void Init(DGAOLEHJHDD OONJFFKJHPD, MeshFilter AJDBHHDOPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x48C18E0", Offset = "0x48C08E0", VA = "0x1848C18E0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x48C2130", Offset = "0x48C1130", VA = "0x1848C2130", Slot = "8")]
		public void UpdateClusterDistances(Vector3 FPJLIKGIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x48C2370", Offset = "0x48C1370", VA = "0x1848C2370", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x48C1A70", Offset = "0x48C0A70", VA = "0x1848C1A70")]
		[IteratorStateMachine(typeof(OOKGGEMMHJP))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x48C1E50", Offset = "0x48C0E50", VA = "0x1848C1E50")]
		public void SetupTagAndLayer(string NAHJHBOGHCD, int EOGMHJEKNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x48C1E30", Offset = "0x48C0E30", VA = "0x1848C1E30")]
		public bool Remove(KPKDAGINBKI LIHCFPMBOOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NKKALJEOCCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int IMIGKDCIGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int KMEFLFMPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HACGPCFNHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int IOHDHKEAMHE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x48CD710", Offset = "0x48CC710", VA = "0x1848CD710")]
	public NKKALJEOCCD(int KMEFLFMPMFC, int HACGPCFNHFB, int IMIGKDCIGAG, int IOHDHKEAMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DLCDENKMLPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> NCLGHMEPHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> MNDKHHOPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> BKMGCALIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<NKKALJEOCCD> IACKKMEKEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> NNLLBNGNMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> JMEOHDBLOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> HDIDIKGKCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle IHEGNLMLNLI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NNDMLCCNIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x854530", Offset = "0x853530", VA = "0x180854530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x854550", Offset = "0x853550", VA = "0x180854550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x48C42A0", Offset = "0x48C32A0", VA = "0x1848C42A0")]
	public void GICBDFIFCOH(FIKOKBLMAKH PHANNDJGEOK, NativeList<NKKALJEOCCD> IACKKMEKEAC, float HNIGCGIKFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x48C3FE0", Offset = "0x48C2FE0", VA = "0x1848C3FE0")]
	public void FHCJJGOGFHB(Transform JJKPMHEEPII, bool GNJOAPMFBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x48C5020", Offset = "0x48C4020", VA = "0x1848C5020")]
	public void HDLJAKEIIDO(DGAOLEHJHDD GPBPHMJHPIL, bool HPNADNBKCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x48C3F10", Offset = "0x48C2F10", VA = "0x1848C3F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x48C51B0", Offset = "0x48C41B0", VA = "0x1848C51B0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DLCDENKMLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CHHPKCPLPKB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> NCLGHMEPHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> MNDKHHOPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<NKKALJEOCCD> JDGOBIEMAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> NNLLBNGNMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 EGADPMHMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> JMEOHDBLOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> HDIDIKGKCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool GNJOAPMFBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float POIDLNHOKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float ODFNFEEECDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float AEHFPLAKHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> BKMGCALIDIC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x48C14A0", Offset = "0x48C04A0", VA = "0x1848C14A0")]
	public CHHPKCPLPKB(DLCDENKMLPH COJAKLHGGGK, Vector3 EGADPMHMFJI, bool GNJOAPMFBKP, float POIDLNHOKFI, float ODFNFEEECDC, float AEHFPLAKHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x48C1000", Offset = "0x48C0000", VA = "0x1848C1000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KPKDAGINBKI : MGEOPACMCHB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds KONAEMACMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MIDEBJGHMKH GHIBPHDLOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HDILJPEDFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<KPKDAGINBKI> GDAAIMGFJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public HDILJPEDFNF ACNNFDIAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public HDILJPEDFNF BGLPEALHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public HDILJPEDFNF EMJAPDKFNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int IOHDHKEAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds CPMOCNNLOMN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x48C82F0", Offset = "0x48C72F0", VA = "0x1848C82F0")]
	public HDILJPEDFNF(List<KPKDAGINBKI> GDAAIMGFJFP, [Optional] HDILJPEDFNF ACNNFDIAAFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ELBOJLFHNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<HDILJPEDFNF> EAMMFGIPGHH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HDILJPEDFNF DFNBLBAHNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x48C6730", Offset = "0x48C5730", VA = "0x1848C6730")]
	public ELBOJLFHNBK(HDILJPEDFNF JJKPMHEEPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IHBNDHLEIMK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BDCAAPDKPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int IGBHBAFJJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int DHPHCMPNFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int LHJJAJIAKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int ADJAHBFGDLF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DBIMIEHLPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int GPKAGCKCCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float KDFEMCCGHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<KPKDAGINBKI> GDAAIMGFJFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NIBPLAFELAE
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
	private BDCAAPDKPGI BABEPLLMAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int GBAECBIGKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int HADDKLPJHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int KMJHOBCDFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float DFNAKJDCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float MBFNBGEEBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<HDILJPEDFNF> CEBJEPLFGFK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ELBOJLFHNBK CPDLGKPBIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x48CA280", Offset = "0x48C9280", VA = "0x1848CA280")]
	public IHBNDHLEIMK(int HADDKLPJHPO, int KMJHOBCDFOF, float DFNAKJDCIFI, int GBAECBIGKCO, float MBFNBGEEBPI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x48C9590", Offset = "0x48C8590", VA = "0x1848C9590")]
	public void FDLHIHHKNDC(List<KPKDAGINBKI> GDAAIMGFJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x48CA210", Offset = "0x48C9210", VA = "0x1848CA210")]
	public bool PBKGGDOGFBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x48CA060", Offset = "0x48C9060", VA = "0x1848CA060")]
	private float KAFMNKEBOFD(Vector3 PPBBNEGBIFF, Vector3 HGPCJMNKPMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x48CA170", Offset = "0x48C9170", VA = "0x1848CA170")]
	private float KAFMNKEBOFD(Vector3 CCDDIFMMPAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x48C9750", Offset = "0x48C8750", VA = "0x1848C9750")]
	private bool IIDKJNHCLHK(HDILJPEDFNF FMEAGFOOOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x48C8A40", Offset = "0x48C7A40", VA = "0x1848C8A40")]
	private DBIMIEHLPOI CIFAJCKFBDM(List<KPKDAGINBKI> KMMCJBIOPEN, NIBPLAFELAE MOABAMHHNNF)
	{
		return default(DBIMIEHLPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x48C86B0", Offset = "0x48C76B0", VA = "0x1848C86B0")]
	private void BMJOKBPMNKA(List<KPKDAGINBKI> GDAAIMGFJFP, Vector3[] FNPIKPCCPAP, Vector3[] BFNJIJHOOMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class HJJCMNCIALF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x48C8370", Offset = "0x48C7370", VA = "0x1848C8370")]
	public static Bounds IOOINEPEIJB(List<KPKDAGINBKI> GDAAIMGFJFP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x48C8520", Offset = "0x48C7520", VA = "0x1848C8520")]
	public static int MAPIDDEEPCF(List<KPKDAGINBKI> GDAAIMGFJFP, OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NHOJHLFIEBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FIKOKBLMAKH LLBHGJFCEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FIKOKBLMAKH DDCPFKDKHAH;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FIKOKBLMAKH MKKPOFDOKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private AFIIBKGEIEM HNFIACBONMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MIHHEFJFMAI NKCMADMIDOF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle IHEGNLMLNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A60", Offset = "0x8F5A60", VA = "0x1808F6A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DGAOLEHJHDD.BDMMCHFPFNF FMEAGFOOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BBOAIDNIFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C90", Offset = "0x7B3C90", VA = "0x1807B4C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x48CD5D0", Offset = "0x48CC5D0", VA = "0x1848CD5D0")]
	[NGEHENKPAPD(LHOOELNKCGI.ExitingPlayMode, 0)]
	private void JKKLNEDKOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x48CCBB0", Offset = "0x48CBBB0", VA = "0x1848CCBB0")]
	public void GICBDFIFCOH(DGAOLEHJHDD.BDMMCHFPFNF JDGOBIEMAKL, Transform FLOKABIHFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x48CC5A0", Offset = "0x48CB5A0", VA = "0x1848CC5A0")]
	public void GADAHENMHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x48CC530", Offset = "0x48CB530", VA = "0x1848CC530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x48CD640", Offset = "0x48CC640", VA = "0x1848CD640")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x48CD680", Offset = "0x48CC680", VA = "0x1848CD680")]
	public NHOJHLFIEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GAAGPDACHGI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PINPNMLOHMP CCMMBDFGJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HAHBJMECKAE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 JEGIEFOMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BNLEPOCCCMA
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(MLACCLOKFHB GIMKIGEELKB, CancellationToken JNDOKGNDNMO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MLLEDBOKCCB
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLLEDBOKCCB OCDHLBAOPCG(Action BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLLEDBOKCCB AEHJFKKPFDL(Action BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLLEDBOKCCB PAFCBKLCCOK(Action BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLLEDBOKCCB GCMJOJJLHOA(Action BBNMGAFNKKA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class GGKLFDBDKAF : MLLEDBOKCCB
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BDBNLIPCFEN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public GGKLFDBDKAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
				public BDBNLIPCFEN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x48C03E0", Offset = "0x48BF3E0", VA = "0x1848C03E0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x48C0430", Offset = "0x48BF430", VA = "0x1848C0430")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x48C0480", Offset = "0x48BF480", VA = "0x1848C0480")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> DGKJPOBNKFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action CEKCJHFFAKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action CHCMMDBMPJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private NAEAAFCDLHK INFBALGPOJM;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action OLJINALMNCF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action BOIDIOIDNNH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2178D90", Offset = "0x2177D90", VA = "0x182178D90", Slot = "4")]
			public MLLEDBOKCCB OCDHLBAOPCG(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x241B0F0", Offset = "0x241A0F0", VA = "0x18241B0F0", Slot = "5")]
			public MLLEDBOKCCB AEHJFKKPFDL(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x240F110", Offset = "0x240E110", VA = "0x18240F110", Slot = "6")]
			public MLLEDBOKCCB PAFCBKLCCOK(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x27CCAC0", Offset = "0x27CBAC0", VA = "0x1827CCAC0", Slot = "7")]
			public MLLEDBOKCCB GCMJOJJLHOA(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
			public GGKLFDBDKAF(Func<JobHandle> CCIHPEHDJMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x48C6840", Offset = "0x48C5840", VA = "0x1848C6840")]
			public void AEOMJAPKJGO(Action BGGPLFMLBHG, Action PDBPDNLNFDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x48C6A70", Offset = "0x48C5A70", VA = "0x1848C6A70")]
			public void DKCILJPFPEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class APOPJFLIBCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public MLLEDBOKCCB jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public APOPJFLIBCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x48C03D0", Offset = "0x48BF3D0", VA = "0x1848C03D0")]
			internal bool <Remove>b__0(GGKLFDBDKAF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class GEDBOOEMAPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public GGKLFDBDKAF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public GEDBOOEMAPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x48C67E0", Offset = "0x48C57E0", VA = "0x1848C67E0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<GGKLFDBDKAF> DPNKNLHCAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<GGKLFDBDKAF> IPMIMPEDACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private JLELHLFHMNH GOCDKEJINNC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public JNLMBMKFLDK DMLFMEDPCCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x48CA880", Offset = "0x48C9880", VA = "0x1848CA880")]
		public MLLEDBOKCCB Add(Func<JobHandle> CCIHPEHDJMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x48CAB20", Offset = "0x48C9B20", VA = "0x1848CAB20")]
		public void Remove(MLLEDBOKCCB IHEGNLMLNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x48CA9A0", Offset = "0x48C99A0", VA = "0x1848CA9A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x48CACA0", Offset = "0x48C9CA0", VA = "0x1848CACA0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x48CAE70", Offset = "0x48C9E70", VA = "0x1848CAE70")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x48CA990", Offset = "0x48C9990", VA = "0x1848CA990")]
		[CompilerGenerated]
		private void CLPLHBNHMGF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NAEAAFCDLHK
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAEAAFCDLHK OCDHLBAOPCG(Action BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAEAAFCDLHK CMKGGBKBDOI(Action BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAEAAFCDLHK GCMJOJJLHOA(Action BBNMGAFNKKA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PGGFDPNDMEK : NAEAAFCDLHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle FGHLLOPNLJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action CEKCJHFFAKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action DCFNICACCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action BOIDIOIDNNH;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool JKKKBJOODFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x48CDBA0", Offset = "0x48CCBA0", VA = "0x1848CDBA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x241B0F0", Offset = "0x241A0F0", VA = "0x18241B0F0", Slot = "4")]
			public NAEAAFCDLHK OCDHLBAOPCG(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x240F110", Offset = "0x240E110", VA = "0x18240F110", Slot = "5")]
			public NAEAAFCDLHK CMKGGBKBDOI(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x27CCAC0", Offset = "0x27CBAC0", VA = "0x1827CCAC0", Slot = "6")]
			public NAEAAFCDLHK GCMJOJJLHOA(Action BBNMGAFNKKA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
			public PGGFDPNDMEK(JobHandle HPEMENGINOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x48CDB60", Offset = "0x48CCB60", VA = "0x1848CDB60")]
			public void BNBCPKDPKEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x48CDBB0", Offset = "0x48CCBB0", VA = "0x1848CDBB0")]
			public void DKCILJPFPEA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<PGGFDPNDMEK> CHJBAFINHFJ;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x48CB2F0", Offset = "0x48CA2F0", VA = "0x1848CB2F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x48CAF30", Offset = "0x48C9F30", VA = "0x1848CAF30")]
		public NAEAAFCDLHK Add(JobHandle HPEMENGINOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x48CB200", Offset = "0x48CA200", VA = "0x1848CB200")]
		public void Remove(NAEAAFCDLHK IHEGNLMLNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x48CB0A0", Offset = "0x48CA0A0", VA = "0x1848CB0A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x48CAFC0", Offset = "0x48C9FC0", VA = "0x1848CAFC0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x48CB400", Offset = "0x48CA400", VA = "0x1848CB400")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x48C6140", Offset = "0x48C5140", VA = "0x1848C6140")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x48C6240", Offset = "0x48C5240", VA = "0x1848C6240")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
