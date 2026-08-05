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
				[Cpp2IlInjected.Address(RVA = "0x836AA70", Offset = "0x8369070", VA = "0x18836AA70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF18D00", Offset = "0xF17300", VA = "0x180F18D00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x836AA30", Offset = "0x8369030", VA = "0x18836AA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8357AB0", Offset = "0x83560B0", VA = "0x188357AB0")]
		public LODSettings HIICDPNDEHO(ICFDOFGDKLP EEPEOPEEIMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8357AC0", Offset = "0x83560C0", VA = "0x188357AC0")]
		public int JILAJIOFPMC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8357AE0", Offset = "0x83560E0", VA = "0x188357AE0")]
		public int PGLIFIFHBLD(bool DHPJDMHDDGJ, Vector3 JDDFGNGBEEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8357B80", Offset = "0x8356180", VA = "0x188357B80")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ODLBKHIBJNE
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
public interface MOCGLBDJAJN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOHLBIAFPDM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AGAHEMGIEFP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ILGIFMNBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<PECDBKHLDGL> EJJHHNKGKBL
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
	void UpdateClusterDistances(Vector3 DPLNHDFCMOI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(JMOFFHJENDF OFJDOOOKCLI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PECDBKHLDGL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FKOJGIBHHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int BBGPLHBGNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float OCMHPBMOBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CKEENBEELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte COCJJPHHPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JJMPHEBPAHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PBOCOINBFPE
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
	private struct IOGHEFJFNGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JJMPHEBPAHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EPDEFLOOMAM<string>.GONHOPCHFID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EPDEFLOOMAM<string>.GONHOPCHFID <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8362330", Offset = "0x8360930", VA = "0x188362330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8362AC0", Offset = "0x83610C0", VA = "0x188362AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LGEHGLKDIGD : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public JJMPHEBPAHD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public LGEHGLKDIGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x836A550", Offset = "0x8368B50", VA = "0x18836A550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x836A7D0", Offset = "0x8368DD0", VA = "0x18836A7D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IEALDCBKHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JJMPHEBPAHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public EPDEFLOOMAM<string>.GONHOPCHFID worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private EPDEFLOOMAM<string>.GONHOPCHFID <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83605D0", Offset = "0x835EBD0", VA = "0x1883605D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8361EF0", Offset = "0x83604F0", VA = "0x188361EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FHPFKOMNMML : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public JJMPHEBPAHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public FHPFKOMNMML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x835C4F0", Offset = "0x835AAF0", VA = "0x18835C4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x835D210", Offset = "0x835B810", VA = "0x18835D210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HPNNLBPKEDB = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan DFLALGGLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ABEICJMKOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter ICKPGDHJPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject KNGBNENPCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject LAMFCPJAOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public GNOKGIKIJON EAECINOBCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JMOFFHJENDF> EJEACALAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JMOFFHJENDF> JPEGCICCFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JMOFFHJENDF> JIDFLCFPHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int EOCCDPEEJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double MABPNHCPGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long JDOPCACHBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private long KBFJCKJHLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long OPJLFFAEBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long BGOGEJKAIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private PBOCOINBFPE NFJKBBMCEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<AGAHEMGIEFP>[] KMMMKLMIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<PECDBKHLDGL>[] EPJJPCJBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CancellationTokenSource HABADHAIKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool OKBFGMHAKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private APLPOCKIJEJ PNENJHIHFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private APLPOCKIJEJ CFAGKDABPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int FOLOOFOFPIO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static JJMPHEBPAHD MDCEPNGNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NPOHGJHLFIE LPIEFCEKCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GLOBGEOMMHK DJDBAIKBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MonoBehaviour DPJKCMPNAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material GIBOJDGDOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private List<Material> MLBBIPLECLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Material PNJEGHMACCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<Material> GLJCDCONFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool JJPKIEDGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly List<MOCGLBDJAJN> KOOKAABECDO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MJOLOMDFKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 BNFFCHKDEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80EBB70", Offset = "0x80EA170", VA = "0x1880EBB70")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80EBBB0", Offset = "0x80EA1B0", VA = "0x1880EBBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PBOCOINBFPE AHOMICEDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2FAA2B0", Offset = "0x2FA88B0", VA = "0x182FAA2B0")]
		get
		{
			return default(PBOCOINBFPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8365AC0", Offset = "0x83640C0", VA = "0x188365AC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static JJMPHEBPAHD DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8367320", Offset = "0x8365920", VA = "0x188367320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool OEKEMCLKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8367F30", Offset = "0x8366530", VA = "0x188367F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PBDLHGLHNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8367610", Offset = "0x8365C10", VA = "0x188367610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NCOJLILILLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83673F0", Offset = "0x83659F0", VA = "0x1883673F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8365910", Offset = "0x8363F10", VA = "0x188365910")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KAJBPMABGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8366430", Offset = "0x8364A30", VA = "0x188366430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83684A0", Offset = "0x8366AA0", VA = "0x1883684A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8368C10", Offset = "0x8367210", VA = "0x188368C10")]
	public JJMPHEBPAHD(NPOHGJHLFIE LPIEFCEKCLG, GLOBGEOMMHK DJDBAIKBNPD, ClusterLODConfig MAHIEGAIONB, MonoBehaviour DPJKCMPNAIL, Material JMOIEOJJPKD, ClusterMeshRenderer ABEICJMKOFB, MeshFilter ICKPGDHJPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8365C00", Offset = "0x8364200", VA = "0x188365C00")]
	private void DFGGDFKNNPD(Material JMOIEOJJPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8368950", Offset = "0x8366F50", VA = "0x188368950")]
	public void OGKMGIDLLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83664E0", Offset = "0x8364AE0", VA = "0x1883664E0")]
	public void FAHJJIOIGGF(Action<Material> CPPMGJEJBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8365AA0", Offset = "0x83640A0", VA = "0x188365AA0")]
	public static KGBENKDOKKC.GHJDECIPEEC CENPIKMAEJP(KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK)
	{
		return default(KGBENKDOKKC.GHJDECIPEEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8365E30", Offset = "0x8364430", VA = "0x188365E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8368850", Offset = "0x8366E50", VA = "0x188368850")]
	public static void OECPAFGILKH(Vector3 GIINJNCJPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8368030", Offset = "0x8366630", VA = "0x188368030")]
	private void MHCFAMOPPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83659D0", Offset = "0x8363FD0", VA = "0x1883659D0")]
	private void BOMLFOPANBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8366A70", Offset = "0x8365070", VA = "0x188366A70")]
	private void HLMLBGBFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83676D0", Offset = "0x8365CD0", VA = "0x1883676D0")]
	public void JOOEBGDDGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83674F0", Offset = "0x8365AF0", VA = "0x1883674F0")]
	[AsyncStateMachine(typeof(IOGHEFJFNGM))]
	public Task JLGOFONPEPD(EPDEFLOOMAM<string>.GONHOPCHFID EDNGDMIOGNB, CancellationToken MMLPHNDIFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8367370", Offset = "0x8365970", VA = "0x188367370")]
	[IteratorStateMachine(typeof(LGEHGLKDIGD))]
	private IEnumerator<BJJPNELKDDJ> IJEKOGLJNKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83689F0", Offset = "0x8366FF0", VA = "0x1883689F0")]
	[AsyncStateMachine(typeof(IEALDCBKHJF))]
	private Task PDEPONCKLNH(EPDEFLOOMAM<string>.GONHOPCHFID KCJJADKMFHE, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8366610", Offset = "0x8364C10", VA = "0x188366610")]
	public void GIMEOCJNBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8365DB0", Offset = "0x83643B0", VA = "0x188365DB0")]
	public void DOAHAEODDEG(IEnumerable<AGAHEMGIEFP> BAHDDLKLLKO, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8368550", Offset = "0x8366B50", VA = "0x188368550")]
	public void NFJDAKDCLPO(IEnumerable<AGAHEMGIEFP> BAHDDLKLLKO, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8366C40", Offset = "0x8365240", VA = "0x188366C40")]
	public List<ClusterMeshRenderer> IHAMINKGDDI(List<JMOFFHJENDF> AJHJMINJGFD, HGOECGDMDII PPOKNBNEDHM, ODLBKHIBJNE CGCOAIEEKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83663D0", Offset = "0x83649D0", VA = "0x1883663D0")]
	public void EMJPLPJAOAM(MOCGLBDJAJN KPEMOLEDBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83656E0", Offset = "0x8363CE0", VA = "0x1883656E0")]
	public bool BAAJIOALCHN(MOCGLBDJAJN KPEMOLEDBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8365740", Offset = "0x8363D40", VA = "0x188365740")]
	public void BHIOOGOPIFM(JMOFFHJENDF EHKBMBHCBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8367EB0", Offset = "0x83664B0", VA = "0x188367EB0")]
	public void MDPNJOFBCJF(PECDBKHLDGL AFDLHEFMFJN, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8366350", Offset = "0x8364950", VA = "0x188366350")]
	public void EJAPBIKECCH(PECDBKHLDGL AFDLHEFMFJN, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8366200", Offset = "0x8364800", VA = "0x188366200")]
	private void EBBPBDKBACM(Vector3 DPLNHDFCMOI, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8367D40", Offset = "0x8366340", VA = "0x188367D40")]
	private void LLNCKKMAFDN(Vector3 DPLNHDFCMOI, ODLBKHIBJNE CGCOAIEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8366BC0", Offset = "0x83651C0", VA = "0x188366BC0")]
	[IteratorStateMachine(typeof(FHPFKOMNMML))]
	private IEnumerator<BJJPNELKDDJ> IGJLBLICGFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83657A0", Offset = "0x8363DA0", VA = "0x1883657A0")]
	private int BHNOJPIPNPO(int LEPAEEGOBDO, int LBACIAEDIHD, List<PECDBKHLDGL> GOOJONDPLDK, byte EEPEOPEEIMF, int LDLMJOEEFAI, float KIGLLCHEIDD = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83668B0", Offset = "0x8364EB0", VA = "0x1883668B0")]
	public void HCDNAOEAAEJ(JMOFFHJENDF OFJDOOOKCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8365D70", Offset = "0x8364370", VA = "0x188365D70")]
	public bool DIAIHOLMKID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB229F0", Offset = "0xB20FF0", VA = "0x180B229F0")]
	public Material GNABFIKMNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8366820", Offset = "0x8364E20", VA = "0x188366820")]
	public Material GNABFIKMNOL(KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB24920", Offset = "0xB22F20", VA = "0x180B24920")]
	public Material PMILMEGPFCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8368B10", Offset = "0x8367110", VA = "0x188368B10")]
	public Material PMILMEGPFCN(KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83674B0", Offset = "0x8365AB0", VA = "0x1883674B0")]
	public int JILAJIOFPMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83680C0", Offset = "0x83666C0", VA = "0x1883680C0")]
	public (long, int) MJPJEPDDLIL()
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
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GJIEGBPJHKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<float3> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float3> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<float4> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<float2> BBBDHIHCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<float4> GCAMDFBELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<int> IFAGBCNDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeList<float3> DBGPHIMGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private float3 OBEADFHAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private float PFKKMBDJOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeParallelMultiHashMap<int, int> KLHGPKNAMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> IEELNKFOBIE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x835D9C0", Offset = "0x835BFC0", VA = "0x18835D9C0")]
	public GJIEGBPJHKJ(KGBENKDOKKC LJNJDNJBNIE, NativeList<float3> DBGPHIMGLEP, NativeParallelMultiHashMap<int, int> KLHGPKNAMBJ, NativeArray<int> IEELNKFOBIE, Vector3 OBEADFHAKAL, float PFKKMBDJOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x835D2C0", Offset = "0x835B8C0", VA = "0x18835D2C0")]
	private int ECAFFPFGAAA(float3 DPLNHDFCMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x835D750", Offset = "0x835BD50", VA = "0x18835D750")]
	private int FEELBBHLEBK(int JFOIDEBHAAF, int HFLDIIIPBCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x835D320", Offset = "0x835B920", VA = "0x18835D320", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IKHGNIPJJNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static NativeParallelMultiHashMap<int, int> KLHGPKNAMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static NativeArray<int> IEELNKFOBIE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int AEPMKAKNIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeList<int> GKFOOCGAJOI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8362130", Offset = "0x8360730", VA = "0x188362130")]
	public void LKNCAMJABCH(int MCHFPDKIKIK, Allocator EKNOCGFFMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8362050", Offset = "0x8360650", VA = "0x188362050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IKHGNIPJJNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct BMBONOOHJJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeList<int> FOEDMAPFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<int> MAEFJLLEJAD;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83573F0", Offset = "0x83559F0", VA = "0x1883573F0")]
	public BMBONOOHJJA(IKHGNIPJJNK JIDNCHPBOIP, KGBENKDOKKC LJNJDNJBNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8357340", Offset = "0x8355940", VA = "0x188357340", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HDFEPCMCKLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeList<float3> JHPGCKNNIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float3> BKLOAGCOPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private NativeArray<float4> CCIKKGCGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private NativeArray<float2> PJPKDAPLGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private NativeArray<float4> NDMPNNJCMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<int> GKFOOCGAJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<int> FOEDMAPFMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<float3> ALAEOFBMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float3> HDLGCANJBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeArray<float4> CHKPCIHACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<float4> DPKNKJALHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float2> AMNGNCFJLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeList<int> DJHIMJOMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float EEJCBDPMIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	public float PCDOACOIFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private float3 IAOFCONEAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private float PCCIMNKKALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private float JDHFDFNACOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	public float LHLABDNDDPG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x835FF00", Offset = "0x835E500", VA = "0x18835FF00")]
	public HDFEPCMCKLO(IKHGNIPJJNK BJOOODFLOFJ, KGBENKDOKKC LJNJDNJBNIE, KGBENKDOKKC GEEKJCLDNFB, float JDHFDFNACOC, float LHLABDNDDPG, Vector3 IAOFCONEAAE, float PCCIMNKKALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x835F730", Offset = "0x835DD30", VA = "0x18835F730")]
	private float3 KGGLFJKPOFC(int JFOIDEBHAAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x835F800", Offset = "0x835DE00", VA = "0x18835F800")]
	private void LGGHMCMCEJN(int JFOIDEBHAAF, [Out] float3 HFELLLCMOCC, [Out] float3 BBNKNGFHPEJ, [Out] float4 CPGGPFLJBNI, [Out] float4 KECONCPJLJP, [Out] float2 FKFDMABDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x835F450", Offset = "0x835DA50", VA = "0x18835F450")]
	private int IAFLMEEJGON(int AALGJILABPG, int CCKEBAKGKKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x835FAA0", Offset = "0x835E0A0", VA = "0x18835FAA0")]
	private void LIHNCOJHAAC(int AALGJILABPG, int CCKEBAKGKKN, int BAODCNDEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x835F300", Offset = "0x835D900", VA = "0x18835F300")]
	private bool FBEAPNKMJPL(int AALGJILABPG, int CCKEBAKGKKN, float AICICBLNDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x835F9E0", Offset = "0x835DFE0", VA = "0x18835F9E0")]
	private bool LGMPJEMLHBG(int AALGJILABPG, int CCKEBAKGKKN, int BAODCNDEMPC, float AICICBLNDNP, bool PJMKHEIJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x835FCA0", Offset = "0x835E2A0", VA = "0x18835FCA0")]
	private bool OALHKLDEIPI(int AALGJILABPG, int CCKEBAKGKKN, int BAODCNDEMPC, float AICICBLNDNP, bool PJMKHEIJJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x835F7E0", Offset = "0x835DDE0", VA = "0x18835F7E0")]
	private void KIENEGEEANO(int AALGJILABPG, int CCKEBAKGKKN, int BAODCNDEMPC, [Out] int BEMPBKMNMFD, [Out] int KEPFGNANNBL, [Out] int CMJKJOGGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x835E980", Offset = "0x835CF80", VA = "0x18835E980", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JHBBMBFNBJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PKICJLMHNKL : IDisposable, PECDBKHLDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Bounds FBDMHHADOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public List<JMOFFHJENDF> AJHJMINJGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Vector3 MKPCEALDCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Vector3 EEBLIDHPBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int GFMNJAJCEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public KGBENKDOKKC BIEPLCJMKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long OEPJJKCFAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IKHGNIPJJNK INDEBICELPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Transform PPOKNBNEDHM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CFFIPMPNHNH
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x836C820", Offset = "0x836AE20", VA = "0x18836C820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KCHNACINIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public KGBENKDOKKC.GHJDECIPEEC EKMIILCFOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
			[CompilerGenerated]
			get
			{
				return default(KGBENKDOKKC.GHJDECIPEEC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh GHEOGOBLJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA935A0", VA = "0x180A94FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public KGBENKDOKKC.GHJDECIPEEC DMENEJPBLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB19E90", Offset = "0xB18490", VA = "0x180B19E90")]
			[CompilerGenerated]
			get
			{
				return default(KGBENKDOKKC.GHJDECIPEEC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xFD8610", Offset = "0xFD6C10", VA = "0x180FD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float OCMHPBMOBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x128CC90", Offset = "0x128B290", VA = "0x18128CC90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1A5AFC0", Offset = "0x1A595C0", VA = "0x181A5AFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte COCJJPHHPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1068160", Offset = "0x1066760", VA = "0x181068160")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1065430", Offset = "0x1063A30", VA = "0x181065430", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int FKOJGIBHHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACAE50", VA = "0x180ACC850", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x15C6150", Offset = "0x15C4750", VA = "0x1815C6150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int BBGPLHBGNOI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xABCF40", Offset = "0xABB540", VA = "0x180ABCF40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x15C6170", Offset = "0x15C4770", VA = "0x1815C6170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CKEENBEELKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x836CB60", Offset = "0x836B160", VA = "0x18836CB60", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x836C8F0", Offset = "0x836AEF0", VA = "0x18836C8F0")]
		public void IHIKFIDCPLB(ICFDOFGDKLP EEPEOPEEIMF, [Out] int GAELDOPGMHO, [Out] int JLMPMKKMHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x836C490", Offset = "0x836AA90", VA = "0x18836C490")]
		public void DCKEJCDHPAA(ICFDOFGDKLP EEPEOPEEIMF, NFHBMFGADGC LHLGMDKHPPH, int FFODKKIHDLN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x836C3E0", Offset = "0x836A9E0", VA = "0x18836C3E0")]
		public void CDBBDFCKBHL(Mesh LJNJDNJBNIE, KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x836C860", Offset = "0x836AE60", VA = "0x18836C860")]
		public void GDAPAPAKGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x836C660", Offset = "0x836AC60", VA = "0x18836C660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x836CB80", Offset = "0x836B180", VA = "0x18836CB80")]
		public PKICJLMHNKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Bounds FBDMHHADOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public KGBENKDOKKC.GHJDECIPEEC GOGAJJAABDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public List<PKICJLMHNKL> GGFANAFLLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public JABHNDNLHMI GKGHKJOHAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public ClusterMeshRenderer DBPGJLKPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int EIAGOHOBBIM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh AMIAAEAIPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HAHBGIEOKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ILGIFMNBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8365400", Offset = "0x8363A00", VA = "0x188365400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8363F70", Offset = "0x8362570", VA = "0x188363F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8364910", Offset = "0x8362F10", VA = "0x188364910")]
	public int FFEHBIMOPHG(int BMNMODBIBOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83640F0", Offset = "0x83626F0", VA = "0x1883640F0")]
	public void EBKGINOADEN(COHIIBDIPAI GCBJHILBCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8364BB0", Offset = "0x83631B0", VA = "0x188364BB0")]
	public void IFKADLOIBBC(Transform EPBCOOIGAEM, bool PCBPMMFLAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8365450", Offset = "0x8363A50", VA = "0x188365450")]
	public bool NCLGJFJNMNE(bool DEDAIEBJJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83642E0", Offset = "0x83628E0", VA = "0x1883642E0")]
	public void EFODNEKBIKL(Transform PPOKNBNEDHM, bool PCBPMMFLAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8364940", Offset = "0x8362F40", VA = "0x188364940")]
	public bool HCDNAOEAAEJ(JMOFFHJENDF OFJDOOOKCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8365610", Offset = "0x8363C10", VA = "0x188365610")]
	public JHBBMBFNBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GNOKGIKIJON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Queue<JHBBMBFNBJI.PKICJLMHNKL> KEHDMEOCADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MGIGAILCCKP DBINHIKMDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<JHBBMBFNBJI.PKICJLMHNKL> FFKHPKGBOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int INBCKAPJGOM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x835DCD0", Offset = "0x835C2D0", VA = "0x18835DCD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x835E690", Offset = "0x835CC90", VA = "0x18835E690")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x835E540", Offset = "0x835CB40", VA = "0x18835E540")]
	public void KMLBEHGKDFG(JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF, Transform PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x835E040", Offset = "0x835C640", VA = "0x18835E040")]
	public void HCDNAOEAAEJ(JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x835DA80", Offset = "0x835C080", VA = "0x18835DA80")]
	private JHBBMBFNBJI.PKICJLMHNKL AHJEIDLGJPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x835DC30", Offset = "0x835C230", VA = "0x18835DC30")]
	private bool CBKILGLNCEG(JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x835E630", Offset = "0x835CC30", VA = "0x18835E630")]
	private void NMFJKJHGDJL(JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x835E600", Offset = "0x835CC00", VA = "0x18835E600")]
	public bool MFNDDKJGEBP(JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x835DDB0", Offset = "0x835C3B0", VA = "0x18835DDB0")]
	public bool FLHPFKIPOFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x835DBC0", Offset = "0x835C1C0", VA = "0x18835DBC0")]
	private JHBBMBFNBJI.PKICJLMHNKL APIHEHFOGLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x835E220", Offset = "0x835C820", VA = "0x18835E220")]
	public long IMCBJMFCFHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x835E710", Offset = "0x835CD10", VA = "0x18835E710")]
	public GNOKGIKIJON()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AENKGKLEEHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int AJFCEOEBBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int DPFNNJEDNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float ADDGBKOAMJO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<JHBBMBFNBJI> JJMNNGPLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83572E0", Offset = "0x83558E0", VA = "0x1883572E0")]
	public AENKGKLEEHL(int AJFCEOEBBAM, int DPFNNJEDNFP, float INCHEJKAIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8356E70", Offset = "0x8355470", VA = "0x188356E70")]
	public void COAOGFGLEAN(BMGGIPDIKDO MAJNKHCJCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8357190", Offset = "0x8355790", VA = "0x188357190")]
	private int HOIHJDKNBBD(COHIIBDIPAI CFHHNIJODJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8356F20", Offset = "0x8355520", VA = "0x188356F20")]
	private void COAOGFGLEAN(COHIIBDIPAI CFHHNIJODJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8357240", Offset = "0x8355840", VA = "0x188357240")]
	private void KNNBAJPLLLI(COHIIBDIPAI CFHHNIJODJI, JHBBMBFNBJI HFEDGAPLDAG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, AGAHEMGIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LGLJCOLBFKE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
			[DebuggerHidden]
			public LGLJCOLBFKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x836A820", Offset = "0x8368E20", VA = "0x18836A820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x836A9E0", Offset = "0x8368FE0", VA = "0x18836A9E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x836A930", Offset = "0x8368F30", VA = "0x18836A930", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x836A930", Offset = "0x8368F30", VA = "0x18836A930", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int ILGIFMNBEAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x83596B0", Offset = "0x8357CB0", VA = "0x1883596B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<PECDBKHLDGL> EJJHHNKGKBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8359690", Offset = "0x8357C90", VA = "0x188359690", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> GGFANAFLLKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JHBBMBFNBJI AMIAAEAIPMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ODLBKHIBJNE OBOKEONOIOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(ODLBKHIBJNE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IJAKAFJMLGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDF2150", Offset = "0xDF0750", VA = "0x180DF2150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8357BE0", Offset = "0x83561E0", VA = "0x188357BE0")]
		public static ClusterMeshRenderer Create(JHBBMBFNBJI LJNJDNJBNIE, ClusterMeshRenderer ABEICJMKOFB, MeshFilter ICKPGDHJPEN, HGOECGDMDII PPOKNBNEDHM, ODLBKHIBJNE CGCOAIEEKKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8357E60", Offset = "0x8356460", VA = "0x188357E60", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8358960", Offset = "0x8356F60", VA = "0x188358960", Slot = "9")]
		public bool TryRemoveClusterLODComponent(JMOFFHJENDF OFJDOOOKCLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8358710", Offset = "0x8356D10", VA = "0x188358710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83583A0", Offset = "0x83569A0", VA = "0x1883583A0")]
		public void Init(JHBBMBFNBJI LJNJDNJBNIE, MeshFilter ICKPGDHJPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8357EC0", Offset = "0x83564C0", VA = "0x188357EC0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8358A90", Offset = "0x8357090", VA = "0x188358A90", Slot = "7")]
		public void UpdateClusterDistances(Vector3 DPLNHDFCMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8358D40", Offset = "0x8357340", VA = "0x188358D40", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8358320", Offset = "0x8356920", VA = "0x188358320")]
		[IteratorStateMachine(typeof(LGLJCOLBFKE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83587A0", Offset = "0x8356DA0", VA = "0x1883587A0")]
		public void SetupTagAndLayer(string BBLDJOHEJKC, int CGCOAIEEKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8358780", Offset = "0x8356D80", VA = "0x188358780")]
		public bool Remove(JMOFFHJENDF OFJDOOOKCLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DHIKKLFNLLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int KMFFPOLILIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int JNIDLJHCIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int JLMPMKKMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int GAELDOPGMHO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8359710", Offset = "0x8357D10", VA = "0x188359710")]
	public DHIKKLFNLLN(int JNIDLJHCIED, int JLMPMKKMHPL, int KMFFPOLILIP, int GAELDOPGMHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JABHNDNLHMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeList<float3> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeList<int> GKFOOCGAJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public NativeList<int> IFAGBCNDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public NativeList<DHIKKLFNLLN> JANCGLKFPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public NativeArray<int> FPPIFFJGMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NativeArray<float3> APADPDHLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public NativeArray<float> NPEMBKILGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public JobHandle ELCAJJNPFBB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAC5EB0", Offset = "0xAC44B0", VA = "0x180AC5EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAC54E0", Offset = "0xAC3AE0", VA = "0x180AC54E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83630A0", Offset = "0x83616A0", VA = "0x1883630A0")]
	public void PNHKIAJGEDI(KGBENKDOKKC IOADIOBFAEM, NativeList<DHIKKLFNLLN> JANCGLKFPLJ, float ILFCOODFNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8362C30", Offset = "0x8361230", VA = "0x188362C30")]
	public void HAJILCICCFG(Transform PPOKNBNEDHM, bool PCBPMMFLAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8362ED0", Offset = "0x83614D0", VA = "0x188362ED0")]
	public void NCLGJFJNMNE(JHBBMBFNBJI DBPGJLKPCJJ, bool DEDAIEBJJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8362B20", Offset = "0x8361120", VA = "0x188362B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8363070", Offset = "0x8361670", VA = "0x188363070")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JABHNDNLHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EDMGAJFNNLD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeList<float3> MNNAHDCEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	public NativeList<int> GKFOOCGAJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private NativeList<DHIKKLFNLLN> ELDMKADHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private NativeArray<int> FPPIFFJGMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float3 IAOFCONEAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private NativeArray<float3> APADPDHLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeArray<float> NPEMBKILGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private bool PCBPMMFLAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private float FPFJMIMHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[ReadOnly]
	private float ODGBOGFGFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private float GKHNFHBCDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeList<int> IFAGBCNDJLL;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8359FD0", Offset = "0x83585D0", VA = "0x188359FD0")]
	public EDMGAJFNNLD(JABHNDNLHMI IAIFDHNBEEB, Vector3 IAOFCONEAAE, bool PCBPMMFLAIJ, float FPFJMIMHAHK, float ODGBOGFGFIN, float GKHNFHBCDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8359AD0", Offset = "0x83580D0", VA = "0x188359AD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JMOFFHJENDF : EFJMOLMIFDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds IBOBLEPGBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class COHIIBDIPAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<JMOFFHJENDF> AJHJMINJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public COHIIBDIPAI IGDHFGFJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public COHIIBDIPAI LFFJGJMPKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public COHIIBDIPAI ONPNMADFNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GAELDOPGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Bounds FBDMHHADOPD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8357A30", Offset = "0x8356030", VA = "0x188357A30")]
	public COHIIBDIPAI(List<JMOFFHJENDF> AJHJMINJGFD, [Optional] COHIIBDIPAI IGDHFGFJBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BMGGIPDIKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public List<COHIIBDIPAI> DPJLEMECPMG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public COHIIBDIPAI KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8357420", Offset = "0x8355A20", VA = "0x188357420")]
	public BMGGIPDIKDO(COHIIBDIPAI PPOKNBNEDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FFEPAPCDLGN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OEBMCCJKPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int LPNMLFLOMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int HFBPGDKCMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int EONAGGCCFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int IKACNHFJEMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GEIDABFKHJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int OGKEAAMFEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public float DAJCGEFJFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<JMOFFHJENDF> AJHJMINJGFD;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x835D260", Offset = "0x835B860", VA = "0x18835D260", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum AHKNAALMMPC
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
	private OEBMCCJKPBE OJFHCLMFMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int DEPAMJHGECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int AJFCEOEBBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int DPFNNJEDNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float INCHEJKAIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float HKCIIIEKCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Stack<COHIIBDIPAI> MEIKOOKFINB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BMGGIPDIKDO NNAHHKCKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x835C490", Offset = "0x835AA90", VA = "0x18835C490")]
	public FFEPAPCDLGN(int AJFCEOEBBAM, int DPFNNJEDNFP, float INCHEJKAIPP, int DEPAMJHGECJ, float HKCIIIEKCIH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x835B240", Offset = "0x8359840", VA = "0x18835B240")]
	public void JNHMMOGHCJL(List<JMOFFHJENDF> AJHJMINJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x835AE10", Offset = "0x8359410", VA = "0x18835AE10")]
	public bool GJIMDIBONDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x835A3E0", Offset = "0x83589E0", VA = "0x18835A3E0")]
	private float DGDPNIIHFAH(Vector3 AJNNFOKDGKA, Vector3 BHCLOJJFNGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x835A3C0", Offset = "0x83589C0", VA = "0x18835A3C0")]
	private float DGDPNIIHFAH(Vector3 MLMBLBFOLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x835A430", Offset = "0x8358A30", VA = "0x18835A430")]
	private bool FFCMJKFIAGD(COHIIBDIPAI NBPBFLEMLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x835B410", Offset = "0x8359A10", VA = "0x18835B410")]
	private GEIDABFKHJN MDJGDNPMEIA(List<JMOFFHJENDF> JLJJKNIHFNF, AHKNAALMMPC CLDNMPAEIGK)
	{
		return default(GEIDABFKHJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x835AE80", Offset = "0x8359480", VA = "0x18835AE80")]
	private void IHNFAIBJEJP(List<JMOFFHJENDF> AJHJMINJGFD, NativeArray<Vector3> OMKJAPMPMFB, NativeArray<Vector3> MACFMAHADDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ECCPIINBLAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8359900", Offset = "0x8357F00", VA = "0x188359900")]
	public static Bounds MBHBPMNFDBD(List<JMOFFHJENDF> AJHJMINJGFD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8359730", Offset = "0x8357D30", VA = "0x188359730")]
	public static int CJGPHCCPIEA(List<JMOFFHJENDF> AJHJMINJGFD, ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class MDDBNLGMONG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool IFIPLHEDJEA(float4* GCAMDFBELJG, int FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class PPHODLCOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x836D150", Offset = "0x836B750", VA = "0x18836D150")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x836CD50", Offset = "0x836B350", VA = "0x18836CD50")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x836D0A0", Offset = "0x836B6A0", VA = "0x18836D0A0")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x836CEB0", Offset = "0x836B4B0", VA = "0x18836CEB0")]
		public unsafe static bool JKGEGDFKKNG(float4* GCAMDFBELJG, int FODNOPLPBPI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x836AA90", Offset = "0x8369090", VA = "0x18836AA90")]
	[BurstCompile]
	public unsafe static bool NJJCOAEDPNB(float4* GCAMDFBELJG, int FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8356C80", Offset = "0x8355280", VA = "0x188356C80")]
	[BurstCompile]
	public unsafe static bool BCNEELMILMD(float4* GCAMDFBELJG, int FODNOPLPBPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct EODLNLEAKMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ReadOnly]
	private NativeList<int> JEAGFLJKHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeList<float3> KMOFPFFJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<float3> MICGNOBMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<float4> PKHILEILDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private NativeArray<float4> NKKLIONHANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeArray<float2> BBBDHIHCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<bool> NIAENOEPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public NativeList<ushort> GMBAPAGOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public NativeList<KGBENKDOKKC.KCGIACMKGFH> ODNMFDDOBLP;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x835A350", Offset = "0x8358950", VA = "0x18835A350")]
	public EODLNLEAKMN(KGBENKDOKKC LHFLNNODMFN, NativeArray<bool> NIAENOEPLCC, NativeList<ushort> GMBAPAGOKJI, NativeList<KGBENKDOKKC.KCGIACMKGFH> ODNMFDDOBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x835A0A0", Offset = "0x83586A0", VA = "0x18835A0A0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct HFMGGLNNNPM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[ReadOnly]
	private NativeList<int> JEAGFLJKHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<float3> KMOFPFFJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float3> MICGNOBMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> PKHILEILDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> NKKLIONHANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float2> BBBDHIHCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeList<int> MKODBBGCOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeList<float3> OHDAEBGCEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeArray<float3> JKNIFICDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<float4> CBLJIJGDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeArray<float4> PMNJLHFKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<float2> BCOAOAEJBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[WriteOnly]
	public NativeArray<bool> NIAENOEPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public NativeList<ushort> GMBAPAGOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public NativeList<KGBENKDOKKC.KCGIACMKGFH> ODNMFDDOBLP;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8360510", Offset = "0x835EB10", VA = "0x188360510")]
	public HFMGGLNNNPM(KGBENKDOKKC LHFLNNODMFN, KGBENKDOKKC IEFFGFFJPBM, NativeArray<bool> NIAENOEPLCC, NativeList<ushort> GMBAPAGOKJI, NativeList<KGBENKDOKKC.KCGIACMKGFH> ODNMFDDOBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8360040", Offset = "0x835E640", VA = "0x188360040", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MGIGAILCCKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private KGBENKDOKKC JNNKOABMEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private KGBENKDOKKC LHFLNNODMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<bool> FDJPMJGAIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeList<ushort> GMBAPAGOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private NativeList<KGBENKDOKKC.KCGIACMKGFH> ODNMFDDOBLP;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static KGBENKDOKKC IHIHHHCDGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private LFLKEFBIKOE FLIGBOGNEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NFHBMFGADGC LHLGMDKHPPH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle ELCAJJNPFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JHBBMBFNBJI.PKICJLMHNKL NBPBFLEMLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KAFKIPNEGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x27379A0", Offset = "0x2735FA0", VA = "0x1827379A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x836B660", Offset = "0x8369C60", VA = "0x18836B660")]
	[FGLGCOAFHPJ(DAODBNEOINB.EnteredEditMode, 0)]
	private static void LCMADPCLAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x836B720", Offset = "0x8369D20", VA = "0x18836B720")]
	public void PNHKIAJGEDI(JHBBMBFNBJI.PKICJLMHNKL ELDMKADHNLC, Transform DOFHALCPMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x836AD80", Offset = "0x8369380", VA = "0x18836AD80")]
	public void HNCHMPLDKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x836ACB0", Offset = "0x83692B0", VA = "0x18836ACB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x836B6E0", Offset = "0x8369CE0", VA = "0x18836B6E0")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x836C270", Offset = "0x836A870", VA = "0x18836C270")]
	public MGIGAILCCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GLOBGEOMMHK
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 IDKPKNBGBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NPOHGJHLFIE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(EPDEFLOOMAM<string>.GONHOPCHFID KCJJADKMFHE, CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JPJHHOMMBKM
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPJHHOMMBKM CKLBIKKJLEL(Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPJHHOMMBKM NBBHCELOIID(Action CBDPHPPPDFI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BNHIHJGHFBO : JPJHHOMMBKM
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class CLLHPICIHIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public BNHIHJGHFBO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				public CLLHPICIHIA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x8357990", Offset = "0x8355F90", VA = "0x188357990")]
				internal void GPKCPADIEMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x8357940", Offset = "0x8355F40", VA = "0x188357940")]
				internal void CLNIMLPCPMP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x83579E0", Offset = "0x8355FE0", VA = "0x1883579E0")]
				internal void ICANKKGKFEJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Func<JobHandle> GNDEMDONDLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action CLEKCKGHDAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private Action JKCHLCHMPKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private AIPHDIOGHDH PELMPHBEINJ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GIBIGBFNNJM
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action KKFBAFALIPI
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2A69850", Offset = "0x2A67E50", VA = "0x182A69850", Slot = "4")]
			public JPJHHOMMBKM CKLBIKKJLEL(Action CBDPHPPPDFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7CA3D30", Offset = "0x7CA2330", VA = "0x187CA3D30", Slot = "5")]
			public JPJHHOMMBKM NBBHCELOIID(Action CBDPHPPPDFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
			public BNHIHJGHFBO(Func<JobHandle> EAANLCDBJBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x83574F0", Offset = "0x8355AF0", VA = "0x1883574F0")]
			public void FIJDFIALNIE(Action CHCEOBFDPEF, Action LGPPJCJGHIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x83577B0", Offset = "0x8355DB0", VA = "0x1883577B0")]
			public void HCDNAOEAAEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class BJJPJIGIOIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JPJHHOMMBKM jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public BJJPJIGIOIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8357330", Offset = "0x8355930", VA = "0x188357330")]
			internal bool LCOFMPHMCEJ(BNHIHJGHFBO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class KDGMDMPHHJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public BNHIHJGHFBO newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public KDGMDMPHHJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x836A4F0", Offset = "0x8368AF0", VA = "0x18836A4F0")]
			internal void NFECKKJIEKD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Queue<BNHIHJGHFBO> EDCJMKKABCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<BNHIHJGHFBO> PIBPCOKDPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private APLPOCKIJEJ BDOMFMDHIDN;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IHPPNLKDBCM ADNHCGJILGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83693B0", Offset = "0x83679B0", VA = "0x1883693B0")]
		public JPJHHOMMBKM Add(Func<JobHandle> EAANLCDBJBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x83696E0", Offset = "0x8367CE0", VA = "0x1883696E0")]
		public void Remove(JPJHHOMMBKM ELCAJJNPFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8369500", Offset = "0x8367B00", VA = "0x188369500", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83698C0", Offset = "0x8367EC0", VA = "0x1883698C0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8369B20", Offset = "0x8368120", VA = "0x188369B20")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83696D0", Offset = "0x8367CD0", VA = "0x1883696D0")]
		[CompilerGenerated]
		private void PPGGOMKEELG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AIPHDIOGHDH
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIPHDIOGHDH CKLBIKKJLEL(Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIPHDIOGHDH OENNDFIMKJB(Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIPHDIOGHDH NBBHCELOIID(Action CBDPHPPPDFI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, AAJMNAIDLEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class PLMMKPKFKHH : AIPHDIOGHDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private JobHandle BJFDAFBPEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action CLEKCKGHDAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action DDLHELKDEIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private Action KKFBAFALIPI;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool ALMJMEFJFAC
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x836CCA0", Offset = "0x836B2A0", VA = "0x18836CCA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7BC8850", Offset = "0x7BC6E50", VA = "0x187BC8850", Slot = "4")]
			public AIPHDIOGHDH CKLBIKKJLEL(Action CBDPHPPPDFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7BC8870", Offset = "0x7BC6E70", VA = "0x187BC8870", Slot = "5")]
			public AIPHDIOGHDH OENNDFIMKJB(Action CBDPHPPPDFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7CA3D30", Offset = "0x7CA2330", VA = "0x187CA3D30", Slot = "6")]
			public AIPHDIOGHDH NBBHCELOIID(Action CBDPHPPPDFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x10D6DD0", Offset = "0x10D53D0", VA = "0x1810D6DD0")]
			public PLMMKPKFKHH(JobHandle EKICNHDPEJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x836CD00", Offset = "0x836B300", VA = "0x18836CD00")]
			public void IMDIPNPDNOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x836CCB0", Offset = "0x836B2B0", VA = "0x18836CCB0")]
			public void HCDNAOEAAEJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private List<PLMMKPKFKHH> NLBIGAFPNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly List<IDisposable> DEOJMIOCPGO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MLKJKKPIIAH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x836A100", Offset = "0x8368700", VA = "0x18836A100")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x16DC8F0", Offset = "0x16DAEF0", VA = "0x1816DC8F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8369C00", Offset = "0x8368200", VA = "0x188369C00")]
		public AIPHDIOGHDH Add(JobHandle EKICNHDPEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x836A310", Offset = "0x8368910", VA = "0x18836A310")]
		public void Remove(AIPHDIOGHDH ELCAJJNPFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8369F20", Offset = "0x8368520", VA = "0x188369F20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8369D70", Offset = "0x8368370", VA = "0x188369D70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8369CA0", Offset = "0x83682A0", VA = "0x188369CA0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x836A410", Offset = "0x8368A10", VA = "0x18836A410")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAC1BD0", Offset = "0xAC01D0", VA = "0x180AC1BD0", Slot = "6")]
		private bool AOHMGIEGEBD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x836D280", Offset = "0x836B880", VA = "0x18836D280")]
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
