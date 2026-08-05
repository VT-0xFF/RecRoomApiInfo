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
				[Cpp2IlInjected.Address(RVA = "0x55CFA40", Offset = "0x55CE440", VA = "0x1855CFA40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1E55BC0", Offset = "0x1E545C0", VA = "0x181E55BC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x55CFA00", Offset = "0x55CE400", VA = "0x1855CFA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x55C37D0", Offset = "0x55C21D0", VA = "0x1855C37D0")]
		public LODSettings BEGHOGEEPLG(AJNEPMAAFBC IGNANJPOBFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x55C37E0", Offset = "0x55C21E0", VA = "0x1855C37E0")]
		public int NKDBOLMLIBJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x55C3800", Offset = "0x55C2200", VA = "0x1855C3800")]
		public int OPPKOIAEPGI(bool EFJMEKJMMEE, Vector3 APCOHALFJAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55C3900", Offset = "0x55C2300", VA = "0x1855C3900")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BLNPICKOAAM
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
public interface JNNAADKIGND
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMDNAEADOHD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHCPAHHCLEP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OBMGKBMKCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KELFHHFIOKJ> IEIMIFEMHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BLNPICKOAAM NCFEHLPEOCH
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
	void UpdateClusterDistances(Vector3 EOJNMKIFHNO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(NHFPGMKJPDG AALANACCLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KELFHHFIOKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int DHPKFHLGMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int OJJKJKEPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JBANAOOBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float PIAGAJCHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte BAHKENMIBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DJFJHDPMIOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CJIPAPKABOF
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
	private struct KDIMGMJLBOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DJFJHDPMIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GPNAMOIINIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GPNAMOIINIG <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x55CC310", Offset = "0x55CAD10", VA = "0x1855CC310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ENIGCEIFCBK : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DJFJHDPMIOB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public ENIGCEIFCBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55C7F30", Offset = "0x55C6930", VA = "0x1855C7F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x55C7FF0", Offset = "0x55C69F0", VA = "0x1855C7FF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LJAGMKBFMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DJFJHDPMIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GPNAMOIINIG worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GPNAMOIINIG <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x55CC8F0", Offset = "0x55CB2F0", VA = "0x1855CC8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BGNIFNMCBNJ : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private PBBBHKGHFDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DJFJHDPMIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public BGNIFNMCBNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x55C19B0", Offset = "0x55C03B0", VA = "0x1855C19B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x55C2860", Offset = "0x55C1260", VA = "0x1855C2860", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FNMCLDLAMOO = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan OIJHIAKIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NLCJABKJHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter GBJLACJAOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject IAGDEBFKGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject DFGKFLACIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NMCHONOACKC KLIFOIDNFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NHFPGMKJPDG> OCLNHODKJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NHFPGMKJPDG> DGPFOKMMOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<NHFPGMKJPDG> OCCILLPEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int FBLIACDKLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private CJIPAPKABOF EJJKBNKGFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<HHCPAHHCLEP>[] JJNFNLNMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KELFHHFIOKJ>[] ECILBKGCJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource CLKPAMOELNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool MINMBFODOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private PFHLOLIKNNP DLKAEOAAAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PFHLOLIKNNP IKFOIDLKHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int DPDBKNANODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PLCJMIEKPCK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static DJFJHDPMIOB DDFBEPONIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BPEPKDLLKJE JMFEDCFPOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DEEOFLPMFCM KFMJAFMPEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour EPIIGHMDACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material PKJOGGMBIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<JNNAADKIGND> JGLOGMPMCKL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig PAPBJDDAHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HHCMJIENJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1C6A510", Offset = "0x1C68F10", VA = "0x181C6A510")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1C6A440", Offset = "0x1C68E40", VA = "0x181C6A440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CJIPAPKABOF JOBJCACJAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA40", Offset = "0x7CB440", VA = "0x1807CCA40")]
		get
		{
			return default(CJIPAPKABOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55C58E0", Offset = "0x55C42E0", VA = "0x1855C58E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DJFJHDPMIOB LOGBPMLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55C51A0", Offset = "0x55C3BA0", VA = "0x1855C51A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool GCNBELOIIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x55C4F00", Offset = "0x55C3900", VA = "0x1855C4F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool GIEICKNPFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x55C6F10", Offset = "0x55C5910", VA = "0x1855C6F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> ANOBCBKHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55C6BF0", Offset = "0x55C55F0", VA = "0x1855C6BF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55C6B50", Offset = "0x55C5550", VA = "0x1855C6B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HOJKCJABPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x55C5640", Offset = "0x55C4040", VA = "0x1855C5640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x55C4E00", Offset = "0x55C3800", VA = "0x1855C4E00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55C7710", Offset = "0x55C6110", VA = "0x1855C7710")]
	public DJFJHDPMIOB(BPEPKDLLKJE JMFEDCFPOON, DEEOFLPMFCM KFMJAFMPEAA, ClusterLODConfig CCKKCLBKKCL, MonoBehaviour EPIIGHMDACG, Material PKJOGGMBIJO, ClusterMeshRenderer NLCJABKJHAN, MeshFilter GBJLACJAOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55C57E0", Offset = "0x55C41E0", VA = "0x1855C57E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x55C6A20", Offset = "0x55C5420", VA = "0x1855C6A20")]
	public static void JLLJEPAFBLB(Vector3 LMNMBGFGGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x55C6990", Offset = "0x55C5390", VA = "0x1855C6990")]
	private void JJOBDIGIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55C56E0", Offset = "0x55C40E0", VA = "0x1855C56E0")]
	private void DODOBIFBPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55C6DC0", Offset = "0x55C57C0", VA = "0x1855C6DC0")]
	private void OPCLOADEMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55C5A10", Offset = "0x55C4410", VA = "0x1855C5A10")]
	public void EDEPJPBBOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55C63A0", Offset = "0x55C4DA0", VA = "0x1855C63A0")]
	[AsyncStateMachine(typeof(KDIMGMJLBOL))]
	public Task GBKDDOPKMDB(GPNAMOIINIG AEKLGCBMNDP, CancellationToken CGNPIKGMLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55C67C0", Offset = "0x55C51C0", VA = "0x1855C67C0")]
	[IteratorStateMachine(typeof(ENIGCEIFCBK))]
	private IEnumerator<PBBBHKGHFDI> IJHBJMGHNHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x55C5500", Offset = "0x55C3F00", VA = "0x1855C5500")]
	[AsyncStateMachine(typeof(LJAGMKBFMIN))]
	private Task CFIGMIECFAJ(GPNAMOIINIG MNJLNMNLALB, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55C5FB0", Offset = "0x55C49B0", VA = "0x1855C5FB0")]
	public void EINPOCKJAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55C5480", Offset = "0x55C3E80", VA = "0x1855C5480")]
	public void CCPNIFIAINE(IEnumerable<HHCPAHHCLEP> OBFODIEILIL, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x55C5200", Offset = "0x55C3C00", VA = "0x1855C5200")]
	public void BNDDJEIJALD(IEnumerable<HHCPAHHCLEP> OBFODIEILIL, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55C6FF0", Offset = "0x55C59F0", VA = "0x1855C6FF0")]
	public List<ClusterMeshRenderer> PIHMDBCCCJM(List<NHFPGMKJPDG> NEOKJGOPJJM, IJAKDKFOKND COMPFMNMPEI, BLNPICKOAAM DIDFDIHLLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55C5F70", Offset = "0x55C4970", VA = "0x1855C5F70")]
	public BLNPICKOAAM EEEDCGJFLAE(Vector3 HFLGKKEOHDJ)
	{
		return default(BLNPICKOAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55C6640", Offset = "0x55C5040", VA = "0x1855C6640")]
	public void HJDDHKLJMAB(JNNAADKIGND DHJAJFKNFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x55C6760", Offset = "0x55C5160", VA = "0x1855C6760")]
	public bool IBGEKBDDMGD(JNNAADKIGND DHJAJFKNFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x55C4EA0", Offset = "0x55C38A0", VA = "0x1855C4EA0")]
	public void ALPECBIHDOG(NHFPGMKJPDG FJHMMIBLFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55C66A0", Offset = "0x55C50A0", VA = "0x1855C66A0")]
	public void HNJHHHEFCGJ(KELFHHFIOKJ LLEGACMOBNC, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55C6D40", Offset = "0x55C5740", VA = "0x1855C6D40")]
	public void OCEIJBKDAAB(KELFHHFIOKJ LLEGACMOBNC, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55C6830", Offset = "0x55C5230", VA = "0x1855C6830")]
	private void JCCIBMEGMHL(Vector3 EOJNMKIFHNO, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55C64E0", Offset = "0x55C4EE0", VA = "0x1855C64E0")]
	private void GHGLPMPHODJ(Vector3 EOJNMKIFHNO, BLNPICKOAAM DIDFDIHLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55C6C90", Offset = "0x55C5690", VA = "0x1855C6C90")]
	[IteratorStateMachine(typeof(BGNIFNMCBNJ))]
	private IEnumerator<PBBBHKGHFDI> MHBIGLBMDKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55C5020", Offset = "0x55C3A20", VA = "0x1855C5020")]
	private int BDKAGKOLEKC(int EBBLFLFCHFB, int MAGNBMNHGOB, List<KELFHHFIOKJ> BODCNONFDJB, byte IGNANJPOBFO, ref int NLKIFMLMPEI, float PAGPFPAIFAN = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55C61C0", Offset = "0x55C4BC0", VA = "0x1855C61C0")]
	public void EMIFMEAGDDE(NHFPGMKJPDG AALANACCLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55C6720", Offset = "0x55C5120", VA = "0x1855C6720")]
	public bool HPJIGCLJBOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72F7A0", Offset = "0x72E1A0", VA = "0x18072F7A0")]
	public Material GPDPLONDFFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55C6D00", Offset = "0x55C5700", VA = "0x1855C6D00")]
	public int NKDBOLMLIBJ()
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
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct CCLMOMDNFKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> CIPAMKALBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> MGMMAAGFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> HGDKGAGPFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> KDBLDBALJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> JBPMNELKJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> BGLJHEFMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> PONGDIIPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 JHCCBAJBNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float HCOLEHDACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> MLAMHAOECNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> PLFJGELPKBA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55C3430", Offset = "0x55C1E30", VA = "0x1855C3430")]
	public CCLMOMDNFKJ(KDHJDHBAIJA LGOCCDPBILM, NativeList<float3> PONGDIIPIKK, NativeMultiHashMap<int, int> MLAMHAOECNC, NativeArray<int> PLFJGELPKBA, Vector3 JHCCBAJBNIE, float HCOLEHDACND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55C3400", Offset = "0x55C1E00", VA = "0x1855C3400")]
	private int KBGKIEMJNDD(float3 EOJNMKIFHNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55C31A0", Offset = "0x55C1BA0", VA = "0x1855C31A0")]
	private int FBELPMFLMAM(int LJOFAPCHBHE, int AIGAKEKDKHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55C2D70", Offset = "0x55C1770", VA = "0x1855C2D70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GNOPDLDBJNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> MLAMHAOECNC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> PLFJGELPKBA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int APKEMHEPIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> IOKGECDNCGK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55C9B70", Offset = "0x55C8570", VA = "0x1855C9B70")]
	public void NPIHEBKPJJC(int KANFMGAIAME, Allocator GGLOKAHPEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55C9A90", Offset = "0x55C8490", VA = "0x1855C9A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GNOPDLDBJNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct BJGNAOANLFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> EINNMGCDDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> KGAGIIHBGFB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55C2940", Offset = "0x55C1340", VA = "0x1855C2940")]
	public BJGNAOANLFO(GNOPDLDBJNK ICFEFIBHMEG, KDHJDHBAIJA LGOCCDPBILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55C28A0", Offset = "0x55C12A0", VA = "0x1855C28A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HDIPPPJAGDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> BIBOCOJEBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> KGMNGNOOGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> LJLFKPKDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> HPBINPOFMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> PJHNHBBILAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> IOKGECDNCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> EINNMGCDDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> HLBIOOHDECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> FMIBPKKLILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> IIFJKPPEMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> NECINAOKAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> PJHNMBGPGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> GPJJEOHJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float GOFLAPLAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float HDNIIMGMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 LPOAIGHPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float CHKNNDKBDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float PAIEJFLANMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float IDHCBHDHMCK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55CB310", Offset = "0x55C9D10", VA = "0x1855CB310")]
	public HDIPPPJAGDN(GNOPDLDBJNK OBIGHFIGDME, KDHJDHBAIJA LGOCCDPBILM, KDHJDHBAIJA JKIPONLFNMF, float PAIEJFLANMA, float IDHCBHDHMCK, Vector3 LPOAIGHPCFD, float CHKNNDKBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55CAC70", Offset = "0x55C9670", VA = "0x1855CAC70")]
	private float3 KFHCMPDKIJO(int LJOFAPCHBHE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55CB120", Offset = "0x55C9B20", VA = "0x1855CB120")]
	private void PNDADPCKLAI(int LJOFAPCHBHE, out float3 NAOOOPMMBPC, out float3 CMAKGKJHJFM, out float4 KKNIPJICPAH, out float4 HAHLCHFBCAP, out float2 IKCJEEJMMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55C9D60", Offset = "0x55C8760", VA = "0x1855C9D60")]
	private int CFLOLJAIIBK(int ANBNPOEMALA, int LJKPLEAOOHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55CA060", Offset = "0x55C8A60", VA = "0x1855CA060")]
	private void EBOLPCICKBE(int ANBNPOEMALA, int LJKPLEAOOHC, int PBEAOAPBNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55CAF90", Offset = "0x55C9990", VA = "0x1855CAF90")]
	private bool PLBFDHJMIFD(int ANBNPOEMALA, int LJKPLEAOOHC, float PBCDHLOFEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x55CABB0", Offset = "0x55C95B0", VA = "0x1855CABB0")]
	private bool FGHPKPMIOCF(int ANBNPOEMALA, int LJKPLEAOOHC, int PBEAOAPBNEG, float PBCDHLOFEID, bool BPJPGLJIBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55CAD20", Offset = "0x55C9720", VA = "0x1855CAD20")]
	private bool KJKGGDHOGKJ(int ANBNPOEMALA, int LJKPLEAOOHC, int PBEAOAPBNEG, float PBCDHLOFEID, bool BPJPGLJIBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55CAB90", Offset = "0x55C9590", VA = "0x1855CAB90")]
	private void FBNOGKGPHOM(int ANBNPOEMALA, int LJKPLEAOOHC, int PBEAOAPBNEG, out int BAEPIMNBECI, out int IMNOPECIJCE, out int IBPBMAADMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55CA270", Offset = "0x55C8C70", VA = "0x1855CA270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MIHKKBMFMGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PDJLODFHNLJ : IDisposable, KELFHHFIOKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds KLBNFOIEKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<NHFPGMKJPDG> NEOKJGOPJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 OAHLIFBFPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 NJHBFAHEJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int DAMCNEEJJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KDHJDHBAIJA NGDICGNELLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GNOPDLDBJNK GHMJPMMKFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform COMPFMNMPEI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int NHIBMIOJNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x55D2AE0", Offset = "0x55D14E0", VA = "0x1855D2AE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh LHIAHADFAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh GIJIMAIEOLE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float JBANAOOBFMB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x137B350", Offset = "0x1379D50", VA = "0x18137B350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2CEA820", Offset = "0x2CE9220", VA = "0x182CEA820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte BAHKENMIBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6540", VA = "0x1809F7B40")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F7CE0", Offset = "0x9F66E0", VA = "0x1809F7CE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int DHPKFHLGMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA80", Offset = "0xA6E480", VA = "0x180A6FA80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA90", Offset = "0xA6E490", VA = "0x180A6FA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OJJKJKEPHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC92E30", Offset = "0xC91830", VA = "0x180C92E30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xECCDD0", Offset = "0xECB7D0", VA = "0x180ECCDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PIAGAJCHCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x55D20A0", Offset = "0x55D0AA0", VA = "0x1855D20A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x55D2700", Offset = "0x55D1100", VA = "0x1855D2700")]
		public void IIBLEMBJNGB(AJNEPMAAFBC IGNANJPOBFO, out int HNKKIBBEIMD, out int JNECPHFKCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x55D2930", Offset = "0x55D1330", VA = "0x1855D2930")]
		public void KEOLOEGHBGO(AJNEPMAAFBC IGNANJPOBFO, KLMKFNMBJPM GHGHKLCEDDA, int BNHOMNFNKAB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x55D22C0", Offset = "0x55D0CC0", VA = "0x1855D22C0")]
		public void EGAJDAHOHIJ(NativeList<MAJBIGGANLB> EKLELJPMLOH, Transform AKJOHFKAIKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x55D2660", Offset = "0x55D1060", VA = "0x1855D2660")]
		public void GLJLFMOCBOK(Mesh LGOCCDPBILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x55D2000", Offset = "0x55D0A00", VA = "0x1855D2000")]
		public void BOOHNHOKPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x55D20C0", Offset = "0x55D0AC0", VA = "0x1855D20C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x55D2B20", Offset = "0x55D1520", VA = "0x1855D2B20")]
		public PDJLODFHNLJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds KLBNFOIEKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<PDJLODFHNLJ> AEIOKBIHNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GLCCMJLLDOI ALGOAHNONOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer BMNJCJDHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int CCLLIKOFIBP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh NNOGDCHBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NAAOMAKIINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811120", VA = "0x180812720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OBMGKBMKCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x55D1470", Offset = "0x55CFE70", VA = "0x1855D1470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55D0090", Offset = "0x55CEA90", VA = "0x1855D0090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55D0C70", Offset = "0x55CF670", VA = "0x1855D0C70")]
	public int GDICFNKBLHG(int OCABJMLOBJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55D0CA0", Offset = "0x55CF6A0", VA = "0x1855D0CA0")]
	public void NIPPIEOCFJB(IFBAEHLGIML PCNGFLIMICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55D04A0", Offset = "0x55CEEA0", VA = "0x1855D04A0")]
	public void FGBPKJBDAJH(Transform AKJOHFKAIKM, bool BJAECECDOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55D0E60", Offset = "0x55CF860", VA = "0x1855D0E60")]
	public bool NKGCLNKLIBI(bool AKFDMPCPPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55D1020", Offset = "0x55CFA20", VA = "0x1855D1020")]
	public void NPLDFPGBJJK(Transform COMPFMNMPEI, bool BJAECECDOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55D01F0", Offset = "0x55CEBF0", VA = "0x1855D01F0")]
	public bool EMIFMEAGDDE(NHFPGMKJPDG AALANACCLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55D14C0", Offset = "0x55CFEC0", VA = "0x1855D14C0")]
	public MIHKKBMFMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NMCHONOACKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<MIHKKBMFMGF.PDJLODFHNLJ> MFCOOPGAFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private PKKDCJLMOKH CLNDKCGFJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<MIHKKBMFMGF.PDJLODFHNLJ> NLCCBGPCFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CCGNLHBJCIL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55D1570", Offset = "0x55CFF70", VA = "0x1855D1570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55D1DE0", Offset = "0x55D07E0", VA = "0x1855D1DE0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55D1B90", Offset = "0x55D0590", VA = "0x1855D1B90")]
	public void MFMCNFFMIAP(MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK, Transform COMPFMNMPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x55D15E0", Offset = "0x55CFFE0", VA = "0x1855D15E0")]
	public void EMIFMEAGDDE(MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55D1C50", Offset = "0x55D0650", VA = "0x1855D1C50")]
	private MIHKKBMFMGF.PDJLODFHNLJ MGBKMBHJNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x55D1860", Offset = "0x55D0260", VA = "0x1855D1860")]
	private bool KAFBDKODMCA(MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55D17D0", Offset = "0x55D01D0", VA = "0x1855D17D0")]
	private void HLNENEJCIAC(MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55D1830", Offset = "0x55D0230", VA = "0x1855D1830")]
	public bool JHOJLMIFLNI(MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55D1900", Offset = "0x55D0300", VA = "0x1855D1900")]
	public bool LJKNPIDDPEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55D1D80", Offset = "0x55D0780", VA = "0x1855D1D80")]
	private MIHKKBMFMGF.PDJLODFHNLJ NIKDHDIEGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55D1E60", Offset = "0x55D0860", VA = "0x1855D1E60")]
	public NMCHONOACKC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AICCMOMDNAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JJHAIIKIPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HHNDGGILJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float LOAIFJKAJFF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<MIHKKBMFMGF> NKPEHLALPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55C1960", Offset = "0x55C0360", VA = "0x1855C1960")]
	public AICCMOMDNAE(int JJHAIIKIPJG, int HHNDGGILJHH, float IPKCKMLEGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55C1600", Offset = "0x55C0000", VA = "0x1855C1600")]
	public void HJKHNPEAPKG(EDMGJEHODNC CFEGHDBMPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55C1350", Offset = "0x55BFD50", VA = "0x1855C1350")]
	private int BOMKHDBGJNJ(IFBAEHLGIML ELOCLFMIMAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x55C1720", Offset = "0x55C0120", VA = "0x1855C1720")]
	private void HJKHNPEAPKG(IFBAEHLGIML ELOCLFMIMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55C13F0", Offset = "0x55BFDF0", VA = "0x1855C13F0")]
	private void GHJMBMFMDGH(IFBAEHLGIML ELOCLFMIMAL, MIHKKBMFMGF JEBBBFAAPNH)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HHCPAHHCLEP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CFLFEBPPGBH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public CFLFEBPPGBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x55C34F0", Offset = "0x55C1EF0", VA = "0x1855C34F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x55C36A0", Offset = "0x55C20A0", VA = "0x1855C36A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x55C3600", Offset = "0x55C2000", VA = "0x1855C3600", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x55C3600", Offset = "0x55C2000", VA = "0x1855C3600", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int OBMGKBMKCFH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x55C4DA0", Offset = "0x55C37A0", VA = "0x1855C4DA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<KELFHHFIOKJ> IEIMIFEMHOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x55C4D80", Offset = "0x55C3780", VA = "0x1855C4D80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> AEIOKBIHNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MIHKKBMFMGF NNOGDCHBAHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BLNPICKOAAM NCFEHLPEOCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6991B0", Offset = "0x697BB0", VA = "0x1806991B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(BLNPICKOAAM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x82CDE0", Offset = "0x82B7E0", VA = "0x18082CDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BCGEECIJLBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x55C4D90", Offset = "0x55C3790", VA = "0x1855C4D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x55C3960", Offset = "0x55C2360", VA = "0x1855C3960")]
		public static ClusterMeshRenderer Create(MIHKKBMFMGF LGOCCDPBILM, ClusterMeshRenderer NLCJABKJHAN, MeshFilter GBJLACJAOAA, IJAKDKFOKND COMPFMNMPEI, BLNPICKOAAM DIDFDIHLLIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x55C3B00", Offset = "0x55C2500", VA = "0x1855C3B00", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55C42C0", Offset = "0x55C2CC0", VA = "0x1855C42C0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(NHFPGMKJPDG AALANACCLGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55C40B0", Offset = "0x55C2AB0", VA = "0x1855C40B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55C3D50", Offset = "0x55C2750", VA = "0x1855C3D50")]
		public void Init(MIHKKBMFMGF LGOCCDPBILM, MeshFilter GBJLACJAOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x55C3B60", Offset = "0x55C2560", VA = "0x1855C3B60")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55C43F0", Offset = "0x55C2DF0", VA = "0x1855C43F0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 EOJNMKIFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55C4600", Offset = "0x55C3000", VA = "0x1855C4600", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55C3CE0", Offset = "0x55C26E0", VA = "0x1855C3CE0")]
		[IteratorStateMachine(typeof(CFLFEBPPGBH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55C4130", Offset = "0x55C2B30", VA = "0x1855C4130")]
		public void SetupTagAndLayer(string FCMEFMFMNGP, int DIDFDIHLLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55C4110", Offset = "0x55C2B10", VA = "0x1855C4110")]
		public bool Remove(NHFPGMKJPDG AALANACCLGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PCFODNMJJOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KDIMDOGKPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int LGAFDCAKAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JNECPHFKCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HNKKIBBEIMD;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55D1FE0", Offset = "0x55D09E0", VA = "0x1855D1FE0")]
	public PCFODNMJJOB(int LGAFDCAKAMG, int JNECPHFKCNN, int KDIMDOGKPMA, int HNKKIBBEIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GLCCMJLLDOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> CIPAMKALBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> IOKGECDNCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> BGLJHEFMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<PCFODNMJJOB> PAGFKHPKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> BCJONBDBBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> MJHPKIACAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> MNMFFIGPHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle AHIGBHNJKNN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IAIALDMGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC2E890", Offset = "0xC2D290", VA = "0x180C2E890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC2EE30", Offset = "0xC2D830", VA = "0x180C2EE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x55C86A0", Offset = "0x55C70A0", VA = "0x1855C86A0")]
	public void IFEPEMKMGAF(KDHJDHBAIJA HKPLDBHJMDF, NativeList<PCFODNMJJOB> PAGFKHPKKBH, float IIOOEIFOODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x55C95C0", Offset = "0x55C7FC0", VA = "0x1855C95C0")]
	public void KBFGFPHMLGA(Transform COMPFMNMPEI, bool BJAECECDOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x55C98B0", Offset = "0x55C82B0", VA = "0x1855C98B0")]
	public void NKGCLNKLIBI(MIHKKBMFMGF BMNJCJDHIKF, bool AKFDMPCPPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x55C8590", Offset = "0x55C6F90", VA = "0x1855C8590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x55C9A60", Offset = "0x55C8460", VA = "0x1855C9A60")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GLCCMJLLDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct FHKMJCNLJCB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> CIPAMKALBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> IOKGECDNCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<PCFODNMJJOB> FNBPEFPKJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> BCJONBDBBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 LPOAIGHPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> MJHPKIACAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> MNMFFIGPHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool BJAECECDOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float KDKAKKJLEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float EHGINIIBJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float AOOMHOABKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> BGLJHEFMNHL;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55C84C0", Offset = "0x55C6EC0", VA = "0x1855C84C0")]
	public FHKMJCNLJCB(GLCCMJLLDOI PFMEHCPKCFJ, Vector3 LPOAIGHPCFD, bool BJAECECDOCB, float KDKAKKJLEBA, float EHGINIIBJIH, float AOOMHOABKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55C8030", Offset = "0x55C6A30", VA = "0x1855C8030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NHFPGMKJPDG : ECHJHMPELIO
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds CDNPPLDCDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MAJBIGGANLB MOPPKMLOIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IFBAEHLGIML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<NHFPGMKJPDG> NEOKJGOPJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public IFBAEHLGIML LFAIGCEGCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public IFBAEHLGIML HANJAKHCPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public IFBAEHLGIML HDIINOAAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HNKKIBBEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds KLBNFOIEKGN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55CB450", Offset = "0x55C9E50", VA = "0x1855CB450")]
	public IFBAEHLGIML(List<NHFPGMKJPDG> NEOKJGOPJJM, [Optional] IFBAEHLGIML LFAIGCEGCPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EDMGJEHODNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<IFBAEHLGIML> AJFGHFKEPPB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IFBAEHLGIML AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55C7E60", Offset = "0x55C6860", VA = "0x1855C7E60")]
	public EDMGJEHODNC(IFBAEHLGIML COMPFMNMPEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LJIADEGPPGK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct ACMIOALGGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int BJCINPHDIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int OLDFPOEBHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int FKDIHBHEDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int LOMEEPPDJAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KOFFPMDCLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OJAJBFNIOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float LACHBOBHMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<NHFPGMKJPDG> NEOKJGOPJJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum CPECMKCJDGG
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
	private ACMIOALGGKK PILPIGFCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int OEKLMMIMACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JJHAIIKIPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int HHNDGGILJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float IPKCKMLEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float BHDIMJKICPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<IFBAEHLGIML> NEJKAOCGNLF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EDMGJEHODNC AIPLHDOIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55CF910", Offset = "0x55CE310", VA = "0x1855CF910")]
	public LJIADEGPPGK(int JJHAIIKIPJG, int HHNDGGILJHH, float IPKCKMLEGHF, int OEKLMMIMACD, float BHDIMJKICPL = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55CDD20", Offset = "0x55CC720", VA = "0x1855CDD20")]
	public void FFILAMFNJLJ(List<NHFPGMKJPDG> NEOKJGOPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55CDCB0", Offset = "0x55CC6B0", VA = "0x1855CDCB0")]
	public bool AHHDHLAKKBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55CDF20", Offset = "0x55CC920", VA = "0x1855CDF20")]
	private float FPGDKHCNKDK(Vector3 MJBMGGEOKEA, Vector3 CGFBNEMNBGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55CDFA0", Offset = "0x55CC9A0", VA = "0x1855CDFA0")]
	private float FPGDKHCNKDK(Vector3 JLMAIAGOBFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC20", Offset = "0x55CD620", VA = "0x1855CEC20")]
	private bool IFLGOOCCAOA(IFBAEHLGIML FKCMGNOAPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55CDFF0", Offset = "0x55CC9F0", VA = "0x1855CDFF0")]
	private KOFFPMDCLIB HAPNICGFGEB(List<NHFPGMKJPDG> FIMJGKIBFPA, CPECMKCJDGG GBKPLGJJIEN)
	{
		return default(KOFFPMDCLIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55CF4B0", Offset = "0x55CDEB0", VA = "0x1855CF4B0")]
	private void IJPDLMCMNGN(List<NHFPGMKJPDG> NEOKJGOPJJM, Vector3[] PBNEHHAFHNL, Vector3[] PKGNBNANHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class AELLNFANGGP
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55C11A0", Offset = "0x55BFBA0", VA = "0x1855C11A0")]
	public static Bounds KILIBKGMAFN(List<NHFPGMKJPDG> NEOKJGOPJJM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55C0FF0", Offset = "0x55BF9F0", VA = "0x1855C0FF0")]
	public static int GBAIGLCLLJJ(List<NHFPGMKJPDG> NEOKJGOPJJM, AJNEPMAAFBC IGNANJPOBFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PKKDCJLMOKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KDHJDHBAIJA FFOMBFAFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private KDHJDHBAIJA GBLLBMGIPFE;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static KDHJDHBAIJA CKHIAAJBKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LDOLHDMMHIA FPKGAMKLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private KLMKFNMBJPM GHGHKLCEDDA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle AHIGBHNJKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76470", VA = "0x180D77A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MIHKKBMFMGF.PDJLODFHNLJ FKCMGNOAPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CDMCKOMPEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70F580", Offset = "0x70DF80", VA = "0x18070F580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x55D3E60", Offset = "0x55D2860", VA = "0x1855D3E60")]
	[IIADNJEBFGG(NKLKDILCDDO.ExitingPlayMode, 0)]
	private void JBODDBAMILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x55D3360", Offset = "0x55D1D60", VA = "0x1855D3360")]
	public void IFEPEMKMGAF(MIHKKBMFMGF.PDJLODFHNLJ FNBPEFPKJAC, Transform CNNALHNMONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x55D2C70", Offset = "0x55D1670", VA = "0x1855D2C70")]
	public void EOIPIKNEKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55D2C00", Offset = "0x55D1600", VA = "0x1855D2C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x55D3ED0", Offset = "0x55D28D0", VA = "0x1855D3ED0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x55D3F10", Offset = "0x55D2910", VA = "0x1855D3F10")]
	public PKKDCJLMOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PCOEHKNEHOA
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DJFJHDPMIOB FAHIPIGJNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DEEOFLPMFCM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 GHEIFFINCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BPEPKDLLKJE
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GPNAMOIINIG MNJLNMNLALB, CancellationToken JLIEBAENBAG);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LCPHIGAOKJA
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCPHIGAOKJA PBDBPPOMADB(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LCPHIGAOKJA OBJOEMNNPIE(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LCPHIGAOKJA LMCHBMALIHC(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCPHIGAOKJA MKNBCJJJBCH(Action PBOHOIMMGFG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class BJHLMFHCDLG : LCPHIGAOKJA
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class CPEKCAMMNGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public BJHLMFHCDLG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public CPEKCAMMNGM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x55C36F0", Offset = "0x55C20F0", VA = "0x1855C36F0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x55C3740", Offset = "0x55C2140", VA = "0x1855C3740")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x55C3790", Offset = "0x55C2190", VA = "0x1855C3790")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> IEKDIGFDLBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action EMLMCJCKAPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action FGNJPKLGIOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private BCACMLNKBLK KCDPBAAOIGM;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action CIGMEODCIOG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action BGFELMODGOJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2697880", Offset = "0x2696280", VA = "0x182697880", Slot = "4")]
			public LCPHIGAOKJA PBDBPPOMADB(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2449750", Offset = "0x2448150", VA = "0x182449750", Slot = "5")]
			public LCPHIGAOKJA OBJOEMNNPIE(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2621B20", Offset = "0x2620520", VA = "0x182621B20", Slot = "6")]
			public LCPHIGAOKJA LMCHBMALIHC(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2F8BC00", Offset = "0x2F8A600", VA = "0x182F8BC00", Slot = "7")]
			public LCPHIGAOKJA MKNBCJJJBCH(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
			public BJHLMFHCDLG(Func<JobHandle> LKEAHLOGGPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x55C2970", Offset = "0x55C1370", VA = "0x1855C2970")]
			public void BABMLJMPJCC(Action INCHENMGLCM, Action KCHKLMJHPPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x55C2C00", Offset = "0x55C1600", VA = "0x1855C2C00")]
			public void EMIFMEAGDDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CMDMDGAGLBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public LCPHIGAOKJA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public CMDMDGAGLBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x55C36E0", Offset = "0x55C20E0", VA = "0x1855C36E0")]
			internal bool <Remove>b__0(BJHLMFHCDLG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JGNMNHKKKHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public BJHLMFHCDLG newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public JGNMNHKKKHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x55CB4D0", Offset = "0x55C9ED0", VA = "0x1855CB4D0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<BJHLMFHCDLG> EEFFGMIDOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<BJHLMFHCDLG> FCGCCJAAICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private PFHLOLIKNNP IANJLNJKFKP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IDEODOAOOHA BLKPCMGEEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55CB530", Offset = "0x55C9F30", VA = "0x1855CB530")]
		public LCPHIGAOKJA Add(Func<JobHandle> LKEAHLOGGPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x55CB830", Offset = "0x55CA230", VA = "0x1855CB830")]
		public void Remove(LCPHIGAOKJA AHIGBHNJKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x55CB690", Offset = "0x55CA090", VA = "0x1855CB690", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x55CBA00", Offset = "0x55CA400", VA = "0x1855CBA00")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55CBC50", Offset = "0x55CA650", VA = "0x1855CBC50")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x55CB680", Offset = "0x55CA080", VA = "0x1855CB680")]
		[CompilerGenerated]
		private void IOJCNHKGPNF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BCACMLNKBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCACMLNKBLK PBDBPPOMADB(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BCACMLNKBLK MLBFIOHJGFL(Action PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BCACMLNKBLK MKNBCJJJBCH(Action PBOHOIMMGFG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LKJMABJEJOC : BCACMLNKBLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle CODFJALCKPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action EMLMCJCKAPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action KFONKFCCOOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action BGFELMODGOJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool DIIJOOGAEKD
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x55CF9F0", Offset = "0x55CE3F0", VA = "0x1855CF9F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2449750", Offset = "0x2448150", VA = "0x182449750", Slot = "4")]
			public BCACMLNKBLK PBDBPPOMADB(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2621B20", Offset = "0x2620520", VA = "0x182621B20", Slot = "5")]
			public BCACMLNKBLK MLBFIOHJGFL(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2F8BC00", Offset = "0x2F8A600", VA = "0x182F8BC00", Slot = "6")]
			public BCACMLNKBLK MKNBCJJJBCH(Action PBOHOIMMGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
			public LKJMABJEJOC(JobHandle OJPHDFDEEHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x55CF970", Offset = "0x55CE370", VA = "0x1855CF970")]
			public void ADFDICGOODJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x55CF9B0", Offset = "0x55CE3B0", VA = "0x1855CF9B0")]
			public void EMIFMEAGDDE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<LKJMABJEJOC> KPGGANCDDKE;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x55CC130", Offset = "0x55CAB30", VA = "0x1855CC130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x55CBD50", Offset = "0x55CA750", VA = "0x1855CBD50")]
		public BCACMLNKBLK Add(JobHandle OJPHDFDEEHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x55CC040", Offset = "0x55CAA40", VA = "0x1855CC040")]
		public void Remove(BCACMLNKBLK AHIGBHNJKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x55CBED0", Offset = "0x55CA8D0", VA = "0x1855CBED0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x55CBDE0", Offset = "0x55CA7E0", VA = "0x1855CBDE0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x55CC250", Offset = "0x55CAC50", VA = "0x1855CC250")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55CFDB0", Offset = "0x55CE7B0", VA = "0x1855CFDB0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55CFA60", Offset = "0x55CE460", VA = "0x1855CFA60")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
