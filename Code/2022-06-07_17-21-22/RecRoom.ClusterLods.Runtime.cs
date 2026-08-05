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
				[Cpp2IlInjected.Address(RVA = "0x4291110", Offset = "0x428F910", VA = "0x184291110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1812460", Offset = "0x1810C60", VA = "0x181812460")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x42910D0", Offset = "0x428F8D0", VA = "0x1842910D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4284040", Offset = "0x4282840", VA = "0x184284040")]
		public LODSettings LDEAFBJEJOE(GMFMCAOCJOB FJMMOCNCCBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4284020", Offset = "0x4282820", VA = "0x184284020")]
		public int JFLJPNLGNHP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4283F20", Offset = "0x4282720", VA = "0x184283F20")]
		public int CCBAPMMBPOD(bool ILGDDNPDKNM, Vector3 HNLGFMAOCAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4284050", Offset = "0x4282850", VA = "0x184284050")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KEINEHKFDKL
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
public interface NMEAKKDPDIG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNOHBPNCEAI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ODFCOPMILHB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FGDCHAGDKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LHCHHDLHEJF> HEELNHKEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KEINEHKFDKL ADPGKJEOLMK
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
	void UpdateClusterDistances(Vector3 PLCNPPEEDPM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(OOELDOIPJKM DHLJMKBEJFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LHCHHDLHEJF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int GFPNILNEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KACGGCOMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float DBGDBJACMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CHINNIMMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte PJADPOLFFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IOKFKIINCPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LONOENGFJNA
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
	private struct HBEHLGEIEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JHEDKPNEPKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private BEOFHLBNHHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x42892C0", Offset = "0x4287AC0", VA = "0x1842892C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LCINCHKLHHJ : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6727D0", Offset = "0x670FD0", VA = "0x1806727D0")]
		[DebuggerHidden]
		public LCINCHKLHHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4290FC0", Offset = "0x428F7C0", VA = "0x184290FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4291080", Offset = "0x428F880", VA = "0x184291080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GCOMAFGFIIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JHEDKPNEPKB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private BEOFHLBNHHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4286480", Offset = "0x4284C80", VA = "0x184286480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AONNKCNHPLI : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6727D0", Offset = "0x670FD0", VA = "0x1806727D0")]
		[DebuggerHidden]
		public AONNKCNHPLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x42810C0", Offset = "0x427F8C0", VA = "0x1842810C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4281FB0", Offset = "0x42807B0", VA = "0x184281FB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int OPOPNFMEKDN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan CDMOHIEMJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NOKBHLFADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter INLIOGPAFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject HMNEEJAAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject FFKMJACICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EFEHPJFIJAP AJFILELOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<OOELDOIPJKM> OKDEGGAALKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<OOELDOIPJKM> MCFDJLMNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<OOELDOIPJKM> HBLCCPEENED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int IKCHOJNDFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LONOENGFJNA HDLJKHPNBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<ODFCOPMILHB>[] BDJHCPKNOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LHCHHDLHEJF>[] EPEJCEGGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource JPKCJNCOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NKCKLFMMDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NGEEMJOOCBL BGCICJIMPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NGEEMJOOCBL LGCMPPKKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int FHJGGLEBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int KELMEILIEPE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static IOKFKIINCPC JJIFKCBGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CGKJMKKLGDJ MFCCEMLPMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HJIKPJJPHPI GABFCGGMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour BNDKEKIIMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material LILGPBFAHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<NMEAKKDPDIG> INIOFHMFNDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig LKHGJDHHFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 NNPCFPHKKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCC5BC0", Offset = "0xCC43C0", VA = "0x180CC5BC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCC5AD0", Offset = "0xCC42D0", VA = "0x180CC5AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LONOENGFJNA PKOGHNALJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x574CD0", Offset = "0x5734D0", VA = "0x180574CD0")]
		get
		{
			return default(LONOENGFJNA);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x428B090", Offset = "0x4289890", VA = "0x18428B090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IOKFKIINCPC GBAAOFDIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x428AFD0", Offset = "0x42897D0", VA = "0x18428AFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CINHOMBKDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x428D470", Offset = "0x428BC70", VA = "0x18428D470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool PPHKAIEBCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x428D060", Offset = "0x428B860", VA = "0x18428D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LAFKNIDOKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x428BAC0", Offset = "0x428A2C0", VA = "0x18428BAC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x428B860", Offset = "0x428A060", VA = "0x18428B860")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PDHJCMABPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x428B9B0", Offset = "0x428A1B0", VA = "0x18428B9B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x428C7F0", Offset = "0x428AFF0", VA = "0x18428C7F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x428D900", Offset = "0x428C100", VA = "0x18428D900")]
	public IOKFKIINCPC(CGKJMKKLGDJ MFCCEMLPMFN, HJIKPJJPHPI GABFCGGMAAJ, ClusterLODConfig GBAOEHOEOMP, MonoBehaviour BNDKEKIIMGB, Material LILGPBFAHAB, ClusterMeshRenderer NOKBHLFADHM, MeshFilter INLIOGPAFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x428B590", Offset = "0x4289D90", VA = "0x18428B590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x428BD40", Offset = "0x428A540", VA = "0x18428BD40")]
	public static void JGHGGNPHEOL(Vector3 EAJFNAIKEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x428D6C0", Offset = "0x428BEC0", VA = "0x18428D6C0")]
	private void PGBGCJDNEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x428BBA0", Offset = "0x428A3A0", VA = "0x18428BBA0")]
	private void IKEALBNNLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x428D750", Offset = "0x428BF50", VA = "0x18428D750")]
	private void PLCEKDFPHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x428C910", Offset = "0x428B110", VA = "0x18428C910")]
	public void LGNICPEIFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x428CF30", Offset = "0x428B730", VA = "0x18428CF30")]
	[AsyncStateMachine(typeof(HBEHLGEIEKD))]
	public Task MBFMPELPPPI(JHEDKPNEPKB LALNBGELDPD, CancellationToken IFJFPECIHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x428B900", Offset = "0x428A100", VA = "0x18428B900")]
	[IteratorStateMachine(typeof(LCINCHKLHHJ))]
	private IEnumerator<FBNJPIMJMDI> HAJGPNJJNKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x428D590", Offset = "0x428BD90", VA = "0x18428D590")]
	[AsyncStateMachine(typeof(GCOMAFGFIIL))]
	private Task OLDJENBGGKJ(JHEDKPNEPKB IJDBBAFHGMB, CancellationToken LFOGICEEHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x428B380", Offset = "0x4289B80", VA = "0x18428B380")]
	public void DGAKGPDAHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x428AF50", Offset = "0x4289750", VA = "0x18428AF50")]
	public void ANGODEPCELI(IEnumerable<ODFCOPMILHB> JNLNIJCHKHN, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x428D1C0", Offset = "0x428B9C0", VA = "0x18428D1C0")]
	public void OJMICHNHOBG(IEnumerable<ODFCOPMILHB> JNLNIJCHKHN, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x428BE60", Offset = "0x428A660", VA = "0x18428BE60")]
	public List<ClusterMeshRenderer> JMAKGMOANAF(List<OOELDOIPJKM> PJBBGDLBNHO, Transform FFGCFPCOLFD, KEINEHKFDKL PEANCNOGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x428B970", Offset = "0x428A170", VA = "0x18428B970")]
	public KEINEHKFDKL HKMGABCOBEG(Vector3 LCELPDLNIFH)
	{
		return default(KEINEHKFDKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x428B320", Offset = "0x4289B20", VA = "0x18428B320")]
	public void DDJBIDKOFCD(NMEAKKDPDIG EHEGKJAGKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x428BCA0", Offset = "0x428A4A0", VA = "0x18428BCA0")]
	public bool JAIBAKJIIAI(NMEAKKDPDIG EHEGKJAGKBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x428B690", Offset = "0x4289E90", VA = "0x18428B690")]
	public void EFOJAEMEAHD(OOELDOIPJKM CJAPAINALDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x428C890", Offset = "0x428B090", VA = "0x18428C890")]
	public void KFHNHDABPGB(LHCHHDLHEJF KEKKEELMMKA, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x428D140", Offset = "0x428B940", VA = "0x18428D140")]
	public void MNJHMGEDFEP(LHCHHDLHEJF KEKKEELMMKA, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x428CE00", Offset = "0x428B600", VA = "0x18428CE00")]
	private void LKJOPAMBBAD(Vector3 PLCNPPEEDPM, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x428B1B0", Offset = "0x42899B0", VA = "0x18428B1B0")]
	private void DCPFFNGAPLH(Vector3 PLCNPPEEDPM, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x428BA50", Offset = "0x428A250", VA = "0x18428BA50")]
	[IteratorStateMachine(typeof(AONNKCNHPLI))]
	private IEnumerator<FBNJPIMJMDI> IFIAPIEENFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x428B6F0", Offset = "0x4289EF0", VA = "0x18428B6F0")]
	private int FNLBDELNLBE(int CFANIPEBCPB, int NIDFLPMLOBC, List<LHCHHDLHEJF> JAOPBCKMKNJ, byte FJMMOCNCCBH, ref int NMLHGGCLNCH, float NNLKMGMFLPP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x428C620", Offset = "0x428AE20", VA = "0x18428C620")]
	public void JPAMCOIJOBL(OOELDOIPJKM DHLJMKBEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x428BB60", Offset = "0x428A360", VA = "0x18428BB60")]
	public bool IGAFNAKNAFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAA0", Offset = "0x5EB2A0", VA = "0x1805ECAA0")]
	public Material NGBHNFDDJDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x428BD00", Offset = "0x428A500", VA = "0x18428BD00")]
	public int JFLJPNLGNHP()
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
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OHANJOKHJME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> AEPOFLKAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> FBKIDAKIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> GKAILPPINDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> JHCEOMGGPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> MGFOHLCCBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 HCPANBNFHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float ENJBHDJNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> OBIANBOMJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> GJACGOKLKND;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x42918A0", Offset = "0x42900A0", VA = "0x1842918A0")]
	public OHANJOKHJME(HEHFIMBCOJI ACEMLDCDLCF, NativeList<float3> MGFOHLCCBBI, NativeMultiHashMap<int, int> OBIANBOMJBJ, NativeArray<int> GJACGOKLKND, Vector3 HCPANBNFHJA, float ENJBHDJNLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4291840", Offset = "0x4290040", VA = "0x184291840")]
	private int LLDNKODBJFL(float3 PLCNPPEEDPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x42915A0", Offset = "0x428FDA0", VA = "0x1842915A0")]
	private int JABMGHNKCKJ(int APEAIJJLBLJ, int BJKKIOODGOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x42911B0", Offset = "0x428F9B0", VA = "0x1842911B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PAJBEJIMLCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> OBIANBOMJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> GJACGOKLKND;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int NINJJDNBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4291AC0", Offset = "0x42902C0", VA = "0x184291AC0")]
	public void IDPBFOLPBJK(int IOLKGOCEIDO, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4291A10", Offset = "0x4290210", VA = "0x184291A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public PAJBEJIMLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KDOCJCMELDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> HJHBFBGBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> FBLFGIKMGIE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x42908C0", Offset = "0x428F0C0", VA = "0x1842908C0")]
	public KDOCJCMELDD(PAJBEJIMLCP NAGJIEGOAKC, HEHFIMBCOJI ACEMLDCDLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4290830", Offset = "0x428F030", VA = "0x184290830", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PJEIPCAIBLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> CEIMKPFIEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> BPPJNFKMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> BKGLDDGNPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> MCKKKFGLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> BLMANHFEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> HJHBFBGBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> NLMBHMKPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> DKINLOMLLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> HPPIIGMNAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> KHJDMECFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> FOBFIPECCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> DMLBBHBBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float FFAMIOPEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float HPEPIKHBLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 GOLLHPLLPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float OAEFJMBMHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float ABMCBCLDOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float GNKOKACBJGG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4293240", Offset = "0x4291A40", VA = "0x184293240")]
	public PJEIPCAIBLG(PAJBEJIMLCP MEGLDLNNMEG, HEHFIMBCOJI ACEMLDCDLCF, HEHFIMBCOJI CGIIENMHLIC, float ABMCBCLDOFH, float GNKOKACBJGG, Vector3 GOLLHPLLPKH, float OAEFJMBMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4291C60", Offset = "0x4290460", VA = "0x184291C60")]
	private float3 AFHJMFKBGKO(int APEAIJJLBLJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4292030", Offset = "0x4290830", VA = "0x184292030")]
	private void EGFMELHCFCN(int APEAIJJLBLJ, out float3 BCBLJPOHOJN, out float3 NGFHHMHANFD, out float4 IBELJANNJGH, out float4 OFMGKHEJGOK, out float2 PCKAMMNKKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4291D00", Offset = "0x4290500", VA = "0x184291D00")]
	private int BNELKMNBLFG(int ICIFGCOGHNJ, int JMDMDMGHCIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4293040", Offset = "0x4291840", VA = "0x184293040")]
	private void OLFIEMKEFHF(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4292E90", Offset = "0x4291690", VA = "0x184292E90")]
	private bool GKIPKEKIJHM(int ICIFGCOGHNJ, int JMDMDMGHCIL, float COKGMODPCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4292DD0", Offset = "0x42915D0", VA = "0x184292DD0")]
	private bool GEEJGFCEHBD(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, float COKGMODPCAA, bool MOBHKALHPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4292B70", Offset = "0x4291370", VA = "0x184292B70")]
	private bool FCHABDPJLEM(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, float COKGMODPCAA, bool MOBHKALHPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4293020", Offset = "0x4291820", VA = "0x184293020")]
	private void KEKIDMLMIAM(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, out int NLFLEMPONBD, out int PHCGNPLCDCC, out int NGKNIOCOGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4292210", Offset = "0x4290A10", VA = "0x184292210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJMINPIFBFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CBCHFCCFFLK : IDisposable, LHCHHDLHEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds IMMOIOCNOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<OOELDOIPJKM> PJBBGDLBNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 IJGMGGAOBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 CPEBMAEALLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int MHOLIINCBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HEHFIMBCOJI NJHIHJJMMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PAJBEJIMLCP HOMIEHMKKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform FFGCFPCOLFD;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int NHMFOEELNDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4283860", Offset = "0x4282060", VA = "0x184283860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh BLNMCFPJKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh JHKHKAKKFPI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x562010", Offset = "0x560810", VA = "0x180562010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x562020", Offset = "0x560820", VA = "0x180562020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DBGDBJACMPL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x139DAB0", Offset = "0x139C2B0", VA = "0x18139DAB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1D02F10", Offset = "0x1D01710", VA = "0x181D02F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte PJADPOLFFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BB190", Offset = "0x6B9990", VA = "0x1806BB190")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6BB320", Offset = "0x6B9B20", VA = "0x1806BB320", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int GFPNILNEEIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x74ED90", Offset = "0x74D590", VA = "0x18074ED90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x74EDA0", Offset = "0x74D5A0", VA = "0x18074EDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int KACGGCOMFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA118C0", Offset = "0xA100C0", VA = "0x180A118C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC524C0", Offset = "0xC50CC0", VA = "0x180C524C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CHINNIMMFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x42836A0", Offset = "0x4281EA0", VA = "0x1842836A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x42831E0", Offset = "0x42819E0", VA = "0x1842831E0")]
		public void AOFGDBBDGHG(GMFMCAOCJOB FJMMOCNCCBH, out int OGEIIPHGPPF, out int GMNEOPJLKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x42836C0", Offset = "0x4281EC0", VA = "0x1842836C0")]
		public void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4283940", Offset = "0x4282140", VA = "0x184283940")]
		public void NBGAHDIBNJH(NativeList<CEHABHFAEKI> CEFGLJKFEGN, Transform OOKCBIBCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x42838A0", Offset = "0x42820A0", VA = "0x1842838A0")]
		public void MPBMPEBJEPI(Mesh ACEMLDCDLCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4283410", Offset = "0x4281C10", VA = "0x184283410")]
		public void BLJEEFDDFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42834B0", Offset = "0x4281CB0", VA = "0x1842834B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4283C60", Offset = "0x4282460", VA = "0x184283C60")]
		public CBCHFCCFFLK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds IMMOIOCNOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<CBCHFCCFFLK> PIGJPBIKDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GNOBKHKEJDB CLIPPKGHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer OHIDPFBACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int KDCPKJECNDA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh FLOCMKDBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x674F20", Offset = "0x673720", VA = "0x180674F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DEHIKNPBBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75A9A0", Offset = "0x7591A0", VA = "0x18075A9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75AA20", Offset = "0x759220", VA = "0x18075AA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FGDCHAGDKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x428AE60", Offset = "0x4289660", VA = "0x18428AE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4289CE0", Offset = "0x42884E0", VA = "0x184289CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x428A750", Offset = "0x4288F50", VA = "0x18428A750")]
	public int IHABBCPBIDB(int KKEMAPFBKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4289B50", Offset = "0x4288350", VA = "0x184289B50")]
	public void BCJNCGAHHOO(LPHJGHFKKLH JGOKBKDGPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4289E40", Offset = "0x4288640", VA = "0x184289E40")]
	public void GFAFNGDIGCI(Transform OOKCBIBCJCI, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x428A5A0", Offset = "0x4288DA0", VA = "0x18428A5A0")]
	public bool ICLHEODHGJA(bool FOPBILLNNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x428A780", Offset = "0x4288F80", VA = "0x18428A780")]
	public void JIEINEKHIKJ(Transform FFGCFPCOLFD, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x428ABE0", Offset = "0x42893E0", VA = "0x18428ABE0")]
	public bool JPAMCOIJOBL(OOELDOIPJKM DHLJMKBEJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x428AEB0", Offset = "0x42896B0", VA = "0x18428AEB0")]
	public HJMINPIFBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EFEHPJFIJAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<HJMINPIFBFP.CBCHFCCFFLK> IOKECFFPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private BCGPEPNKDPL LEBBCHPOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<HJMINPIFBFP.CBCHFCCFFLK> DBOBLGLJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int GAFFCHFLDJD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4285940", Offset = "0x4284140", VA = "0x184285940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4285730", Offset = "0x4283F30", VA = "0x184285730")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42859F0", Offset = "0x42841F0", VA = "0x1842859F0")]
	public void IONNJMGFDPB(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI, Transform FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4285AA0", Offset = "0x42842A0", VA = "0x184285AA0")]
	public void JPAMCOIJOBL(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x42857B0", Offset = "0x4283FB0", VA = "0x1842857B0")]
	private HJMINPIFBFP.CBCHFCCFFLK CAPFEAIBPGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4285CB0", Offset = "0x42844B0", VA = "0x184285CB0")]
	private bool NJLNBAADCJG(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4285C50", Offset = "0x4284450", VA = "0x184285C50")]
	private void MLGFBNINKCA(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42859B0", Offset = "0x42841B0", VA = "0x1842859B0")]
	public bool HDAGBCHPGJP(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42854A0", Offset = "0x4283CA0", VA = "0x1842854A0")]
	public bool ADBHOPCDBIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42858E0", Offset = "0x42840E0", VA = "0x1842858E0")]
	private HJMINPIFBFP.CBCHFCCFFLK CDOCEJENIOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4285D40", Offset = "0x4284540", VA = "0x184285D40")]
	public EFEHPJFIJAP()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EJCEDFHAJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int FPFINHCMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int AEECOPCAPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float OACLOJPCPBA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<HJMINPIFBFP> EPCKAPIDGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4286430", Offset = "0x4284C30", VA = "0x184286430")]
	public EJCEDFHAJNE(int FPFINHCMNKL, int AEECOPCAPOC, float GDBFDJNBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4286110", Offset = "0x4284910", VA = "0x184286110")]
	public void BDIOELHPFME(OOOOEBEMICC MPDHFFFKLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42861B0", Offset = "0x42849B0", VA = "0x1842861B0")]
	private int CCGJICLKHHN(LPHJGHFKKLH HCLJNIDPDDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4285EE0", Offset = "0x42846E0", VA = "0x184285EE0")]
	private void BDIOELHPFME(LPHJGHFKKLH HCLJNIDPDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4286250", Offset = "0x4284A50", VA = "0x184286250")]
	private void HKCKPHKNMMG(LPHJGHFKKLH HCLJNIDPDDK, HJMINPIFBFP CDPCKEOMHOA)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ODFCOPMILHB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CHDFPINOAHG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6723E0", Offset = "0x670BE0", VA = "0x1806723E0")]
			[DebuggerHidden]
			public CHDFPINOAHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4283D20", Offset = "0x4282520", VA = "0x184283D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4283EB0", Offset = "0x42826B0", VA = "0x184283EB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x4283E10", Offset = "0x4282610", VA = "0x184283E10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x4283E10", Offset = "0x4282610", VA = "0x184283E10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FGDCHAGDKNA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4285440", Offset = "0x4283C40", VA = "0x184285440", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<LHCHHDLHEJF> HEELNHKEKNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x4285420", Offset = "0x4283C20", VA = "0x184285420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> PIGJPBIKDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x55FCA0", VA = "0x1805614A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public HJMINPIFBFP FLOCMKDBCLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KEINEHKFDKL ADPGKJEOLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x562390", Offset = "0x560B90", VA = "0x180562390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(KEINEHKFDKL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6803C0", Offset = "0x67EBC0", VA = "0x1806803C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MHGPMFFKHDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4285430", Offset = "0x4283C30", VA = "0x184285430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x42840B0", Offset = "0x42828B0", VA = "0x1842840B0")]
		public static ClusterMeshRenderer Create(HJMINPIFBFP ACEMLDCDLCF, ClusterMeshRenderer NOKBHLFADHM, MeshFilter INLIOGPAFLO, Transform FFGCFPCOLFD, KEINEHKFDKL PEANCNOGNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4284210", Offset = "0x4282A10", VA = "0x184284210", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4284990", Offset = "0x4283190", VA = "0x184284990", Slot = "10")]
		public bool TryRemoveClusterLODComponent(OOELDOIPJKM DHLJMKBEJFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4284760", Offset = "0x4282F60", VA = "0x184284760")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4284470", Offset = "0x4282C70", VA = "0x184284470")]
		public void Init(HJMINPIFBFP ACEMLDCDLCF, MeshFilter INLIOGPAFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4284270", Offset = "0x4282A70", VA = "0x184284270")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4284AC0", Offset = "0x42832C0", VA = "0x184284AC0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 PLCNPPEEDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4284D00", Offset = "0x4283500", VA = "0x184284D00", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4284400", Offset = "0x4282C00", VA = "0x184284400")]
		[IteratorStateMachine(typeof(CHDFPINOAHG))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x42847E0", Offset = "0x4282FE0", VA = "0x1842847E0")]
		public void SetupTagAndLayer(string AFNLFJKEJHJ, int PEANCNOGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x42847C0", Offset = "0x4282FC0", VA = "0x1842847C0")]
		public bool Remove(OOELDOIPJKM DHLJMKBEJFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct COCBCMBDAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KAFEOIBCEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int HKONJCKHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GMNEOPJLKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int OGEIIPHGPPF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4283F00", Offset = "0x4282700", VA = "0x184283F00")]
	public COCBCMBDAFI(int HKONJCKHNHA, int GMNEOPJLKEJ, int KAFEOIBCEGC, int OGEIIPHGPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GNOBKHKEJDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<COCBCMBDAFI> AIDCGDDGMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> ONLOEFEDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> BLHLHPBDEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> NOKNCIJCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle KLACIAPNOBO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EJBIELGFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70B380", Offset = "0x709B80", VA = "0x18070B380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70B3A0", Offset = "0x709BA0", VA = "0x18070B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4287980", Offset = "0x4286180", VA = "0x184287980")]
	public void MLLKPFPDJFM(HEHFIMBCOJI HHFJEJINKCD, NativeList<COCBCMBDAFI> AIDCGDDGMJP, float FMODKECMJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4288700", Offset = "0x4286F00", VA = "0x184288700")]
	public void PFNKOGCIAGO(Transform FFGCFPCOLFD, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x42877F0", Offset = "0x4285FF0", VA = "0x1842877F0")]
	public void ICLHEODHGJA(HJMINPIFBFP OHIDPFBACFG, bool FOPBILLNNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4287720", Offset = "0x4285F20", VA = "0x184287720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x42876F0", Offset = "0x4285EF0", VA = "0x1842876F0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public GNOBKHKEJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HBCLKJOCPCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<COCBCMBDAFI> GPNKDEOOKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> ONLOEFEDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 GOLLHPLLPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> BLHLHPBDEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> NOKNCIJCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool ACPDHMBNBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float MCNIKEDPOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float MOONBGFALAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float KJDKEIIEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x42891F0", Offset = "0x42879F0", VA = "0x1842891F0")]
	public HBCLKJOCPCF(GNOBKHKEJDB OMLMACKKNLD, Vector3 GOLLHPLLPKH, bool ACPDHMBNBPG, float MCNIKEDPOGD, float MOONBGFALAB, float KJDKEIIEAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4288D50", Offset = "0x4287550", VA = "0x184288D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OOELDOIPJKM : PABLPJMAJCM
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds MOGOMPMIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LPHJGHFKKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<OOELDOIPJKM> PJBBGDLBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public LPHJGHFKKLH HNINKJAJDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public LPHJGHFKKLH PINIGDGGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public LPHJGHFKKLH EAPKCACPDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int OGEIIPHGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds IMMOIOCNOME;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4291130", Offset = "0x428F930", VA = "0x184291130")]
	public LPHJGHFKKLH(List<OOELDOIPJKM> PJBBGDLBNHO, [Optional] LPHJGHFKKLH HNINKJAJDDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OOOOEBEMICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<LPHJGHFKKLH> CKHOAODDLJL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LPHJGHFKKLH APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x561490", Offset = "0x55FC90", VA = "0x180561490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4291960", Offset = "0x4290160", VA = "0x184291960")]
	public OOOOEBEMICC(LPHJGHFKKLH FFGCFPCOLFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JJPIIHKKOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PBOFKJFOGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int CKBHFPLLPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int MHBDJBKCFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OAILFJGCMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int OBIABCHIGKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GOEGLMFFILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int FAKFABHICGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float AKLBEFKPAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<OOELDOIPJKM> PJBBGDLBNHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PGKPKKEENMH
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
	private PBOFKJFOGOO HGBLFMCHBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int EPCILDPJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int FPFINHCMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int AEECOPCAPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GDBFDJNBHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float DACDFFEBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<LPHJGHFKKLH> IHAJAGLHDHG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OOOOEBEMICC EPHDDINLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x428FBC0", Offset = "0x428E3C0", VA = "0x18428FBC0")]
	public JJPIIHKKOJN(int FPFINHCMNKL, int AEECOPCAPOC, float GDBFDJNBHHB, int EPCILDPJFNG, float DACDFFEBHAI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x428FA00", Offset = "0x428E200", VA = "0x18428FA00")]
	public void IHCOKIBELBM(List<OOELDOIPJKM> PJBBGDLBNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x428E530", Offset = "0x428CD30", VA = "0x18428E530")]
	public bool FAGNJDALDNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x428DFF0", Offset = "0x428C7F0", VA = "0x18428DFF0")]
	private float CJBDFHJPNCB(Vector3 OBJPCHOBPAB, Vector3 JDMPDBLFGGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x428E100", Offset = "0x428C900", VA = "0x18428E100")]
	private float CJBDFHJPNCB(Vector3 DDMFGCPNLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x428F0F0", Offset = "0x428D8F0", VA = "0x18428F0F0")]
	private bool HKPDLCMBLCH(LPHJGHFKKLH FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x428E5A0", Offset = "0x428CDA0", VA = "0x18428E5A0")]
	private GOEGLMFFILF HEJOPANLMDC(List<OOELDOIPJKM> AIBIHPCGOIK, PGKPKKEENMH KPLGBEPCDBO)
	{
		return default(GOEGLMFFILF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x428E1A0", Offset = "0x428C9A0", VA = "0x18428E1A0")]
	private void CLAMLEGHAGK(List<OOELDOIPJKM> PJBBGDLBNHO, Vector3[] IHEDEABJLPD, Vector3[] AOAJOEAJCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class HHCEAAPNOMI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4289810", Offset = "0x4288010", VA = "0x184289810")]
	public static Bounds GJIFBDGAHFK(List<OOELDOIPJKM> PJBBGDLBNHO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x42899C0", Offset = "0x42881C0", VA = "0x1842899C0")]
	public static int JFMFJCOGOHB(List<OOELDOIPJKM> PJBBGDLBNHO, GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BCGPEPNKDPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HEHFIMBCOJI DKIGOABCBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HEHFIMBCOJI BDOLPPHDAKO;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static HEHFIMBCOJI MGNNPOANPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BJJDECDFOKP ELDNDJLGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private HEEPHPELEBO LEHANDPMPPM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle KLACIAPNOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE80", Offset = "0x7FD680", VA = "0x1807FEE80")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEA0", Offset = "0x7FD6A0", VA = "0x1807FEEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HCDIOCGLABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x69F1E0", Offset = "0x69D9E0", VA = "0x18069F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x42826C0", Offset = "0x4280EC0", VA = "0x1842826C0")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private void EJDHMECJAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4282730", Offset = "0x4280F30", VA = "0x184282730")]
	public void MLLKPFPDJFM(HJMINPIFBFP.CBCHFCCFFLK GPNKDEOOKBJ, Transform NGPLIOECNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4282040", Offset = "0x4280840", VA = "0x184282040")]
	public void BPBALMFJPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4282650", Offset = "0x4280E50", VA = "0x184282650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4282000", Offset = "0x4280800", VA = "0x184282000")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4283150", Offset = "0x4281950", VA = "0x184283150")]
	public BCGPEPNKDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LKHLDPLBOIC
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IOKFKIINCPC KCIGLGBKDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HJIKPJJPHPI
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 AIIJOMGJNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CGKJMKKLGDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(JHEDKPNEPKB IJDBBAFHGMB, CancellationToken LFOGICEEHBE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LECOGMKDAFL
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LECOGMKDAFL HMHEIODENOA(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LECOGMKDAFL FPBNMDALFPO(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LECOGMKDAFL HCEPMODPGFG(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LECOGMKDAFL CEJNOCJEFBG(Action DJBODGKMGGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class GPCMHBBGLGC : LECOGMKDAFL
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KOAONOOFINK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public GPCMHBBGLGC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
				public KOAONOOFINK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x42908F0", Offset = "0x428F0F0", VA = "0x1842908F0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x4290940", Offset = "0x428F140", VA = "0x184290940")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x4290990", Offset = "0x428F190", VA = "0x184290990")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> MGPLNPFAEKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action INIPOLAPKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action EEAJAKDNPIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private LNBPFPKJCLA CEHLLAAFCLG;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action LKAEOPBFBHP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x674F20", Offset = "0x673720", VA = "0x180674F20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action BMDDJPBFPMD
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x243D160", Offset = "0x243B960", VA = "0x18243D160", Slot = "4")]
			public LECOGMKDAFL HMHEIODENOA(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x20D9E20", Offset = "0x20D8620", VA = "0x1820D9E20", Slot = "5")]
			public LECOGMKDAFL FPBNMDALFPO(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21A5AE0", Offset = "0x21A42E0", VA = "0x1821A5AE0", Slot = "6")]
			public LECOGMKDAFL HCEPMODPGFG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x23A4530", Offset = "0x23A2D30", VA = "0x1823A4530", Slot = "7")]
			public LECOGMKDAFL CEJNOCJEFBG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x69FFB0", Offset = "0x69E7B0", VA = "0x18069FFB0")]
			public GPCMHBBGLGC(Func<JobHandle> OHMIJAHECFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x42889C0", Offset = "0x42871C0", VA = "0x1842889C0")]
			public void IOHEKBDABGH(Action EAIBKKJMIEL, Action IJEFNINLBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4288BF0", Offset = "0x42873F0", VA = "0x184288BF0")]
			public void JPAMCOIJOBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JJMPOAODFFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public LECOGMKDAFL jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public JJMPOAODFFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x428DFE0", Offset = "0x428C7E0", VA = "0x18428DFE0")]
			internal bool <Remove>b__0(GPCMHBBGLGC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class EGJIMNFNMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public GPCMHBBGLGC newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public EGJIMNFNMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4285E80", Offset = "0x4284680", VA = "0x184285E80")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<GPCMHBBGLGC> DCFDNAMONII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<GPCMHBBGLGC> FGDFHADDNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private NGEEMJOOCBL GILEANECDAO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public CHJKBOBFOHJ GMNMMEOMJHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x589A30", Offset = "0x588230", VA = "0x180589A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6828D0", Offset = "0x6810D0", VA = "0x1806828D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x428FC20", Offset = "0x428E420", VA = "0x18428FC20")]
		public LECOGMKDAFL Add(Func<JobHandle> OHMIJAHECFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x428FEC0", Offset = "0x428E6C0", VA = "0x18428FEC0")]
		public void Remove(LECOGMKDAFL KLACIAPNOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x428FD40", Offset = "0x428E540", VA = "0x18428FD40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4290040", Offset = "0x428E840", VA = "0x184290040")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4290210", Offset = "0x428EA10", VA = "0x184290210")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x428FD30", Offset = "0x428E530", VA = "0x18428FD30")]
		[CompilerGenerated]
		private void KCNGLAJDOOP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LNBPFPKJCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNBPFPKJCLA HMHEIODENOA(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNBPFPKJCLA CKLFPJADKEO(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNBPFPKJCLA CEJNOCJEFBG(Action DJBODGKMGGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class JDDBFICACJC : LNBPFPKJCLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle ADFMGBFGCAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action INIPOLAPKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action BEHPCIKIELE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action BMDDJPBFPMD;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool OPGCJKPKIOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x428DF50", Offset = "0x428C750", VA = "0x18428DF50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x20D9E20", Offset = "0x20D8620", VA = "0x1820D9E20", Slot = "4")]
			public LNBPFPKJCLA HMHEIODENOA(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x21A5AE0", Offset = "0x21A42E0", VA = "0x1821A5AE0", Slot = "5")]
			public LNBPFPKJCLA CKLFPJADKEO(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x23A4530", Offset = "0x23A2D30", VA = "0x1823A4530", Slot = "6")]
			public LNBPFPKJCLA CEJNOCJEFBG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xB904D0", Offset = "0xB8ECD0", VA = "0x180B904D0")]
			public JDDBFICACJC(JobHandle BDGBAEHKENH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x428DF60", Offset = "0x428C760", VA = "0x18428DF60")]
			public void GLIJLNLELKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x428DFA0", Offset = "0x428C7A0", VA = "0x18428DFA0")]
			public void JPAMCOIJOBL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<JDDBFICACJC> IMCGNFKDGHD;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4290690", Offset = "0x428EE90", VA = "0x184290690")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x42902D0", Offset = "0x428EAD0", VA = "0x1842902D0")]
		public LNBPFPKJCLA Add(JobHandle BDGBAEHKENH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x42905A0", Offset = "0x428EDA0", VA = "0x1842905A0")]
		public void Remove(LNBPFPKJCLA KLACIAPNOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4290440", Offset = "0x428EC40", VA = "0x184290440", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4290360", Offset = "0x428EB60", VA = "0x184290360")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x42907A0", Offset = "0x428EFA0", VA = "0x1842907A0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x42909D0", Offset = "0x428F1D0", VA = "0x1842909D0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4290AD0", Offset = "0x428F2D0", VA = "0x184290AD0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
