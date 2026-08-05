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
				[Cpp2IlInjected.Address(RVA = "0x60876D0", Offset = "0x60868D0", VA = "0x1860876D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x148ED50", Offset = "0x148DF50", VA = "0x18148ED50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6087690", Offset = "0x6086890", VA = "0x186087690")]
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
		[Cpp2IlInjected.Address(RVA = "0x607AAA0", Offset = "0x6079CA0", VA = "0x18607AAA0")]
		public LODSettings IAKKDLABKFD(LJPLHCMPBCM MCCIEIKDMFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x607AAB0", Offset = "0x6079CB0", VA = "0x18607AAB0")]
		public int OHKPHBDDHHF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x607AA00", Offset = "0x6079C00", VA = "0x18607AA00")]
		public int BCPPDKCLOEI(bool HDEGFIMEBOM, Vector3 LIIDJBEJCIH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x607AAD0", Offset = "0x6079CD0", VA = "0x18607AAD0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OCCIHLIKKGC
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
public interface LDBLLJMEEFH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLEBCABFAOL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ILGDFMBBIMG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BJCFMJHBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LFNFGIAMGLH> OFHFFJPLGEG
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
	void UpdateClusterDistances(Vector3 CCDONDNKELE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(DHGKCDLLHHI KECFIHOGMCI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LFNFGIAMGLH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int OHPHHEFLCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int LMHFJLNOPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PFCFFKKNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CHMJBKNGACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte MKEACGKNPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HBODAMFOBPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NFKJPHAEEKB
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
	private struct PNAADNOJOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HBODAMFOBPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FMDPIFHBCJG<string>.BBMCKKPJOID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x608AE50", Offset = "0x608A050", VA = "0x18608AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x608B5E0", Offset = "0x608A7E0", VA = "0x18608B5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KDMMBNKHFDB : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HBODAMFOBPG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public KDMMBNKHFDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6083A10", Offset = "0x6082C10", VA = "0x186083A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6083B10", Offset = "0x6082D10", VA = "0x186083B10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMCCFLFCDCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HBODAMFOBPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FMDPIFHBCJG<string>.BBMCKKPJOID worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private FMDPIFHBCJG<string>.BBMCKKPJOID <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6083F00", Offset = "0x6083100", VA = "0x186083F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6085740", Offset = "0x6084940", VA = "0x186085740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MLBMADFAKMI : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private AHKNJJJKEOF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public HBODAMFOBPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public MLBMADFAKMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60876F0", Offset = "0x60868F0", VA = "0x1860876F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60883D0", Offset = "0x60875D0", VA = "0x1860883D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int NCGECNFHEPI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan AIDGNDBGNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ACCLJCPGLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter HMGFGANDJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject IPJKEJPKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject GHEEPCFHNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public PGILJLOMIDD KECBEGLFJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DHGKCDLLHHI> DLBLJKEMIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DHGKCDLLHHI> GGNKPHMBHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<DHGKCDLLHHI> NBMGOEBFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int GLHGKCHBGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NFKJPHAEEKB FFIMKCIPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<ILGDFMBBIMG>[] EPFPOHCKAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LFNFGIAMGLH>[] AAHNFPAKCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource PCCDDBKDLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool ONNJCJAFLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private CHAGHAGMDBI BBOFFDICGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CHAGHAGMDBI FLHJFKAJKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int MCMEJJGJFGP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static HBODAMFOBPG AELOLLCLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MAHKAEAODEJ NNGBHAMMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GIOLCFABFDF CPJNJOBIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour BKACFCNDFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material ALHBGJLPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<LDBLLJMEEFH> LADCEEHGKBI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig GKLEIGOELOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 FIDEABFGFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C6460", Offset = "0x7C5660", VA = "0x1807C6460")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FD0", Offset = "0x7C51D0", VA = "0x1807C5FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private NFKJPHAEEKB OONHABIHEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87F720", Offset = "0x87E920", VA = "0x18087F720")]
		get
		{
			return default(NFKJPHAEEKB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6081B20", Offset = "0x6080D20", VA = "0x186081B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static HBODAMFOBPG EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6081A10", Offset = "0x6080C10", VA = "0x186081A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool CDEDIIBAHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6080080", Offset = "0x607F280", VA = "0x186080080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CBGJLDPEHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6081A60", Offset = "0x6080C60", VA = "0x186081A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> DCAHDMLEFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6081C50", Offset = "0x6080E50", VA = "0x186081C50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6081060", Offset = "0x6080260", VA = "0x186081060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OCCDDNNILGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6080C30", Offset = "0x607FE30", VA = "0x186080C30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6081580", Offset = "0x6080780", VA = "0x186081580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6082240", Offset = "0x6081440", VA = "0x186082240")]
	public HBODAMFOBPG(MAHKAEAODEJ NNGBHAMMEEF, GIOLCFABFDF CPJNJOBIICO, ClusterLODConfig KGIEEBBCAFL, MonoBehaviour BKACFCNDFCE, Material ALHBGJLPACA, ClusterMeshRenderer ACCLJCPGLEH, MeshFilter HMGFGANDJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6080170", Offset = "0x607F370", VA = "0x186080170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x607F650", Offset = "0x607E850", VA = "0x18607F650")]
	public static void BIMBGHFOMHK(Vector3 EEFKGMIAJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x607F9A0", Offset = "0x607EBA0", VA = "0x18607F9A0")]
	private void CPEKFKPBJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60814B0", Offset = "0x60806B0", VA = "0x1860814B0")]
	private void KFPOBBIGGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6081120", Offset = "0x6080320", VA = "0x186081120")]
	private void IFPPAGAAPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x607FA30", Offset = "0x607EC30", VA = "0x18607FA30")]
	public void DEBDOCAGHJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x607F880", Offset = "0x607EA80", VA = "0x18607F880")]
	[AsyncStateMachine(typeof(PNAADNOJOLE))]
	public Task CLBPJGPHGLA(FMDPIFHBCJG<string>.BBMCKKPJOID NKAOGPCKJHO, CancellationToken ALPALKHHHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6080FE0", Offset = "0x60801E0", VA = "0x186080FE0")]
	[IteratorStateMachine(typeof(KDMMBNKHFDB))]
	private IEnumerator<AHKNJJJKEOF> HCBPEDDCFLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6081810", Offset = "0x6080A10", VA = "0x186081810")]
	[AsyncStateMachine(typeof(KMCCFLFCDCI))]
	private Task LFIBAIMPOIP(FMDPIFHBCJG<string>.BBMCKKPJOID GCOIPFEKNMF, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6081270", Offset = "0x6080470", VA = "0x186081270")]
	public void IPLFLCLPJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x607F4F0", Offset = "0x607E6F0", VA = "0x18607F4F0")]
	public void ANKFBMAKDOM(IEnumerable<ILGDFMBBIMG> LDKOPPOHFLF, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6080CE0", Offset = "0x607FEE0", VA = "0x186080CE0")]
	public void HAGGJOPLMEO(IEnumerable<ILGDFMBBIMG> LDKOPPOHFLF, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6080580", Offset = "0x607F780", VA = "0x186080580")]
	public List<ClusterMeshRenderer> FKEMDKGLPDD(List<DHGKCDLLHHI> POMHLADJAEJ, AFMLJEGJNBJ MFIBAFBMCBA, OCCIHLIKKGC OCLMGFCPPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6080270", Offset = "0x607F470", VA = "0x186080270")]
	public void FALMBHGEDDI(LDBLLJMEEFH MEFCDIANIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x607F5F0", Offset = "0x607E7F0", VA = "0x18607F5F0")]
	public bool BIALAHPDIEK(LDBLLJMEEFH MEFCDIANIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60804D0", Offset = "0x607F6D0", VA = "0x1860804D0")]
	public void FIDBOCKADMN(DHGKCDLLHHI NMGHABEOEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6081930", Offset = "0x6080B30", VA = "0x186081930")]
	public void LMOOOOFLGLE(LFNFGIAMGLH JCFIBHGAALP, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6081790", Offset = "0x6080990", VA = "0x186081790")]
	public void LEGFGIDJCHE(LFNFGIAMGLH JCFIBHGAALP, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x607F740", Offset = "0x607E940", VA = "0x18607F740")]
	private void BMNMCODNJGC(Vector3 CCDONDNKELE, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6081630", Offset = "0x6080830", VA = "0x186081630")]
	private void KMFEMOJPMAF(Vector3 CCDONDNKELE, OCCIHLIKKGC OCLMGFCPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x607F570", Offset = "0x607E770", VA = "0x18607F570")]
	[IteratorStateMachine(typeof(MLBMADFAKMI))]
	private IEnumerator<AHKNJJJKEOF> APICCLAKLLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6081D50", Offset = "0x6080F50", VA = "0x186081D50")]
	private int OJPPAAEBHFN(int MBGANDEDPDN, int IJBCBBJGKPA, List<LFNFGIAMGLH> LHNFNOMPPIH, byte MCCIEIKDMFF, int INPLPHLLMDJ, float PFKODLIDIBH = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6080320", Offset = "0x607F520", VA = "0x186080320")]
	public void FBCLMIGJMFH(DHGKCDLLHHI KECFIHOGMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6081470", Offset = "0x6080670", VA = "0x186081470")]
	public bool KFBFGLJNKGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4910", Offset = "0x8D3B10", VA = "0x1808D4910")]
	public Material DCOBDKCGCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6081D10", Offset = "0x6080F10", VA = "0x186081D10")]
	public int OHKPHBDDHHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6081EC0", Offset = "0x60810C0", VA = "0x186081EC0")]
	public long PPMAKNFEGIM()
	{
		return default(long);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct LJFEHICCBGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> NOBIMAGCFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> PINPIGPKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> LAPGLOFCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> NOMFPHPFOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> BNKNLGCDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> GMPEFAHGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 GHBLMFCEJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float KINOEDPAIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> LGMLCHAJPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> OGLCFINCOKA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x60875D0", Offset = "0x60867D0", VA = "0x1860875D0")]
	public LJFEHICCBGA(FEEDCIOJNFD PLFOEDLJILP, NativeList<float3> GMPEFAHGMHO, NativeParallelMultiHashMap<int, int> LGMLCHAJPLP, NativeArray<int> OGLCFINCOKA, Vector3 GHBLMFCEJLG, float KINOEDPAIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6087570", Offset = "0x6086770", VA = "0x186087570")]
	private int JDOBFGAJKJA(float3 CCDONDNKELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6086ED0", Offset = "0x60860D0", VA = "0x186086ED0")]
	private int ECLPMBPBJPL(int IBNKLDKLAGI, int GHBNLDGJPCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6087140", Offset = "0x6086340", VA = "0x186087140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CBCNBBIKHKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> LGMLCHAJPLP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> OGLCFINCOKA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int OLNKPBMJOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> IOEOMIHFJDM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x607A760", Offset = "0x6079960", VA = "0x18607A760")]
	public void FMLFPKNNCMC(int JAPDIMAHDHK, Allocator HOJMCOLANAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x607A680", Offset = "0x6079880", VA = "0x18607A680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public CBCNBBIKHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct PIGAHOONHKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> EHMCGHMHBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> KELNCDDCMPP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x608AE20", Offset = "0x608A020", VA = "0x18608AE20")]
	public PIGAHOONHKE(CBCNBBIKHKC BILAEBOJICI, FEEDCIOJNFD PLFOEDLJILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x608AD70", Offset = "0x6089F70", VA = "0x18608AD70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LENGEPLMJKD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> NOKFLPCBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> LCINJFKKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> KEMJKFPBMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> KGPOIHICALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> DJCIIGMJMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> IOEOMIHFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> EHMCGHMHBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> AEEKFGHGBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> FFOPDCJBIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> HMFPCMIPHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> CHHKOBANIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> JMJIMOMLDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> DNJCHIMHJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float CPNKNDCHMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float IMGINJCOPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 FHMICDCPNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float GIOMFHMBANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float CAEGGHLGHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float NHMHEGFGMMF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6086D90", Offset = "0x6085F90", VA = "0x186086D90")]
	public LENGEPLMJKD(CBCNBBIKHKC FIKCMJKHDCH, FEEDCIOJNFD PLFOEDLJILP, FEEDCIOJNFD JMNBIBMCCDN, float CAEGGHLGHOE, float NHMHEGFGMMF, Vector3 FHMICDCPNGF, float GIOMFHMBANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60865C0", Offset = "0x60857C0", VA = "0x1860865C0")]
	private float3 FPFDHCKDEFG(int IBNKLDKLAGI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6086AF0", Offset = "0x6085CF0", VA = "0x186086AF0")]
	private void OBNGMHNFKNH(int IBNKLDKLAGI, [Out] float3 BPLEAAPKGDA, [Out] float3 EEDNIBBONPH, [Out] float4 LEEAHEIILME, [Out] float4 HGMBPBGBNII, [Out] float2 EMLAOKDBLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6085950", Offset = "0x6084B50", VA = "0x186085950")]
	private int DKCCPCICJDI(int ELGELCLDGHA, int DPEPDDHBCBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6086690", Offset = "0x6085890", VA = "0x186086690")]
	private void KHEDIHFCOBN(int ELGELCLDGHA, int DPEPDDHBCBK, int BADPNFKPJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6085800", Offset = "0x6084A00", VA = "0x186085800")]
	private bool AHPDIAMFHMD(int ELGELCLDGHA, int DPEPDDHBCBK, float FIAMBAONDAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6086CD0", Offset = "0x6085ED0", VA = "0x186086CD0")]
	private bool OCFCCDKPLMI(int ELGELCLDGHA, int DPEPDDHBCBK, int BADPNFKPJLM, float FIAMBAONDAI, bool FOINGNOBDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6086890", Offset = "0x6085A90", VA = "0x186086890")]
	private bool LEAGIEBLMHA(int ELGELCLDGHA, int DPEPDDHBCBK, int BADPNFKPJLM, float FIAMBAONDAI, bool FOINGNOBDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6086670", Offset = "0x6085870", VA = "0x186086670")]
	private void JEEBEILMEPH(int ELGELCLDGHA, int DPEPDDHBCBK, int BADPNFKPJLM, [Out] int AOIHOALAIEC, [Out] int EBLOIBKCKIA, [Out] int FFOLHBFBHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6085C40", Offset = "0x6084E40", VA = "0x186085C40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DOJHJFJNOOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OHFOIACNLJF : IDisposable, LFNFGIAMGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds HEHPMCCLDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<DHGKCDLLHHI> POMHLADJAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 MOBKLOIGGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 CJJPGKKGLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int BCIKOIIKEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FEEDCIOJNFD PDANCGELDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long LEFOGFNHHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CBCNBBIKHKC DBGMPLDCHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform MFIBAFBMCBA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int EJINNEPMGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x60895C0", Offset = "0x60887C0", VA = "0x1860895C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh PGIFODGONJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh OIFOCNFMDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PFCFFKKNDBF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x111EF10", Offset = "0x111E110", VA = "0x18111EF10", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x57351E0", Offset = "0x57343E0", VA = "0x1857351E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte MKEACGKNPBP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1094540", Offset = "0x1093740", VA = "0x181094540")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x135DAF0", Offset = "0x135CCF0", VA = "0x18135DAF0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int OHPHHEFLCKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA46730", Offset = "0xA45930", VA = "0x180A46730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA45CF0", Offset = "0xA44EF0", VA = "0x180A45CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LMHFJLNOPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD20B80", Offset = "0xD1FD80", VA = "0x180D20B80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD1F850", Offset = "0xD1EA50", VA = "0x180D1F850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CHMJBKNGACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6089D20", Offset = "0x6088F20", VA = "0x186089D20", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6089A10", Offset = "0x6088C10", VA = "0x186089A10")]
		public void GHPEHCLHDBO(LJPLHCMPBCM MCCIEIKDMFF, [Out] int INONAEKBBIE, [Out] int AFGBMDOGPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6089600", Offset = "0x6088800", VA = "0x186089600")]
		public void CABLHPEMLMA(LJPLHCMPBCM MCCIEIKDMFF, NGABOLFNHJB BAAPAGBCKHO, int FFEAEKCELAG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6089C80", Offset = "0x6088E80", VA = "0x186089C80")]
		public void PAJHMKNDPBP(Mesh PLFOEDLJILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60897D0", Offset = "0x60889D0", VA = "0x1860897D0")]
		public void DGHFFNEAKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6089860", Offset = "0x6088A60", VA = "0x186089860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6089D40", Offset = "0x6088F40", VA = "0x186089D40")]
		public OHFOIACNLJF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds HEHPMCCLDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<OHFOIACNLJF> CKGHGMMJACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public PPMNBFABMLC PCGKCHHFLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer PDJKKMEADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int AGMNKBCODAO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh ADAAJOKAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PBHNDCAHBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x880780", Offset = "0x87F980", VA = "0x180880780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95CAF0", VA = "0x18095D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BJCFMJHBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x607EED0", Offset = "0x607E0D0", VA = "0x18607EED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x607E4C0", Offset = "0x607D6C0", VA = "0x18607E4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x607EF20", Offset = "0x607E120", VA = "0x18607EF20")]
	public int KLBDHBKECMF(int EGHLKNBOIHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x607EF50", Offset = "0x607E150", VA = "0x18607EF50")]
	public void LKOPJGJCIFF(ONMAPGGLDAN PKBMKPIIJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x607DCF0", Offset = "0x607CEF0", VA = "0x18607DCF0")]
	public void CPHDFNMIMPH(Transform NLGNBPIPJMP, bool FBFEDEMIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x607F180", Offset = "0x607E380", VA = "0x18607F180")]
	public bool OHBPHOABJEA(bool LJKPMKLIIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x607E640", Offset = "0x607D840", VA = "0x18607E640")]
	public void ECIFMDBJCNE(Transform MFIBAFBMCBA, bool FBFEDEMIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x607EC60", Offset = "0x607DE60", VA = "0x18607EC60")]
	public bool FBCLMIGJMFH(DHGKCDLLHHI KECFIHOGMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x607F340", Offset = "0x607E540", VA = "0x18607F340")]
	public DOJHJFJNOOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PGILJLOMIDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<DOJHJFJNOOM.OHFOIACNLJF> HGAKCNDCEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AACEIDAFINP DBPKKMODNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<DOJHJFJNOOM.OHFOIACNLJF> ADMNPFFGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JGNECNDENAM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x608A140", Offset = "0x6089340", VA = "0x18608A140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x608A0C0", Offset = "0x60892C0", VA = "0x18608A0C0")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x608A450", Offset = "0x6089650", VA = "0x18608A450")]
	public void GHBEENLPKLN(DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG, Transform MFIBAFBMCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x608A270", Offset = "0x6089470", VA = "0x18608A270")]
	public void FBCLMIGJMFH(DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6089F80", Offset = "0x6089180", VA = "0x186089F80")]
	private DOJHJFJNOOM.OHFOIACNLJF CPIKMALDFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x608A7F0", Offset = "0x60899F0", VA = "0x18608A7F0")]
	private bool OOHGPGGECPO(DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x608A1C0", Offset = "0x60893C0", VA = "0x18608A1C0")]
	private void EFEGEJPIMCA(DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6089F50", Offset = "0x6089150", VA = "0x186089F50")]
	public bool BHMCLGKGBKI(DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x608A510", Offset = "0x6089710", VA = "0x18608A510")]
	public bool MOLHGBBEJOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6089EE0", Offset = "0x60890E0", VA = "0x186089EE0")]
	private DOJHJFJNOOM.OHFOIACNLJF AAAJBNDFIJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x608A890", Offset = "0x6089A90", VA = "0x18608A890")]
	public long PPMAKNFEGIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x608ABC0", Offset = "0x6089DC0", VA = "0x18608ABC0")]
	public PGILJLOMIDD()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MLDIBPGLPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int FBGAOCOMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MLCCGFFPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float DCJCCMKOJKD;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<DOJHJFJNOOM> CJPAIMAJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60888E0", Offset = "0x6087AE0", VA = "0x1860888E0")]
	public MLDIBPGLPEL(int FBGAOCOMJHJ, int MLCCGFFPKDD, float DIELNJHCALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6088570", Offset = "0x6087770", VA = "0x186088570")]
	public void NAFLNONOCCP(JAMLAMDPILE JGILMBIGFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60884C0", Offset = "0x60876C0", VA = "0x1860884C0")]
	private int MMDKHFMOLEN(ONMAPGGLDAN JCCACJKHFKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6088620", Offset = "0x6087820", VA = "0x186088620")]
	private void NAFLNONOCCP(ONMAPGGLDAN JCCACJKHFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6088420", Offset = "0x6087620", VA = "0x186088420")]
	private void JPGLKMGIKAN(ONMAPGGLDAN JCCACJKHFKB, DOJHJFJNOOM JHJDCOBKHID)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ILGDFMBBIMG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NPNPEEPLNEG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
			[DebuggerHidden]
			public NPNPEEPLNEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6088F10", Offset = "0x6088110", VA = "0x186088F10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x60890D0", Offset = "0x60882D0", VA = "0x1860890D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6089020", Offset = "0x6088220", VA = "0x186089020", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6089020", Offset = "0x6088220", VA = "0x186089020", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int BJCFMJHBCCG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x607C080", Offset = "0x607B280", VA = "0x18607C080", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<LFNFGIAMGLH> OFHFFJPLGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x607C060", Offset = "0x607B260", VA = "0x18607C060", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> CKGHGMMJACA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DOJHJFJNOOM ADAAJOKAAFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public OCCIHLIKKGC KHMCFGLCOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(OCCIHLIKKGC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8860", VA = "0x1807B9660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool HHFPBGOCCPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1912460", Offset = "0x1911660", VA = "0x181912460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x607AB30", Offset = "0x6079D30", VA = "0x18607AB30")]
		public static ClusterMeshRenderer Create(DOJHJFJNOOM PLFOEDLJILP, ClusterMeshRenderer ACCLJCPGLEH, MeshFilter HMGFGANDJKC, AFMLJEGJNBJ MFIBAFBMCBA, OCCIHLIKKGC OCLMGFCPPDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x607ACA0", Offset = "0x6079EA0", VA = "0x18607ACA0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x607B560", Offset = "0x607A760", VA = "0x18607B560", Slot = "9")]
		public bool TryRemoveClusterLODComponent(DHGKCDLLHHI KECFIHOGMCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x607B310", Offset = "0x607A510", VA = "0x18607B310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x607AF10", Offset = "0x607A110", VA = "0x18607AF10")]
		public void Init(DOJHJFJNOOM PLFOEDLJILP, MeshFilter HMGFGANDJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x607AD00", Offset = "0x6079F00", VA = "0x18607AD00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x607B690", Offset = "0x607A890", VA = "0x18607B690", Slot = "7")]
		public void UpdateClusterDistances(Vector3 CCDONDNKELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x607B940", Offset = "0x607AB40", VA = "0x18607B940", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x607AE90", Offset = "0x607A090", VA = "0x18607AE90")]
		[IteratorStateMachine(typeof(NPNPEEPLNEG))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x607B3A0", Offset = "0x607A5A0", VA = "0x18607B3A0")]
		public void SetupTagAndLayer(string KLOCHNOKOMB, int OCLMGFCPPDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x607B380", Offset = "0x607A580", VA = "0x18607B380")]
		public bool Remove(DHGKCDLLHHI KECFIHOGMCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OMOGNALHLOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int HNPBIHKGNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int BHOMKDDOKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int AFGBMDOGPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int INONAEKBBIE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6089E40", Offset = "0x6089040", VA = "0x186089E40")]
	public OMOGNALHLOF(int BHOMKDDOKFH, int AFGBMDOGPBF, int HNPBIHKGNNF, int INONAEKBBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PPMNBFABMLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> IOEOMIHFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> BNKNLGCDENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<OMOGNALHLOF> KPDNAKDPLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> GIEOBFNANKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> NIFKJDJCMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> HPKJBJMLAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle IFPDAOGJICE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MOOOKMKIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xEDEA00", Offset = "0xEDDC00", VA = "0x180EDEA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA40", Offset = "0xCE9C40", VA = "0x180CEAA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x608BA10", Offset = "0x608AC10", VA = "0x18608BA10")]
	public void GNCDFEHEFDJ(FEEDCIOJNFD DJBPOLBPBGO, NativeList<OMOGNALHLOF> KPDNAKDPLNI, float OFBFBKPELML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x608B640", Offset = "0x608A840", VA = "0x18608B640")]
	public void AEAKJCHKNCO(Transform MFIBAFBMCBA, bool FBFEDEMIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x608C870", Offset = "0x608BA70", VA = "0x18608C870")]
	public void OHBPHOABJEA(DOJHJFJNOOM PDJKKMEADLE, bool LJKPMKLIIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x608B900", Offset = "0x608AB00", VA = "0x18608B900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x608B8D0", Offset = "0x608AAD0", VA = "0x18608B8D0")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public PPMNBFABMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct MMMCJDBAFCO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> DAGKFGFLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> IOEOMIHFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<OMOGNALHLOF> PDLJJNIDOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> GIEOBFNANKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 FHMICDCPNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> NIFKJDJCMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> HPKJBJMLAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool FBFEDEMIGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float DKDBGCAIJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float DCDLBLBFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float POFJEGAHBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> BNKNLGCDENF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6088E40", Offset = "0x6088040", VA = "0x186088E40")]
	public MMMCJDBAFCO(PPMNBFABMLC EEHHIGBHOME, Vector3 FHMICDCPNGF, bool FBFEDEMIGNJ, float DKDBGCAIJMC, float DCDLBLBFMBC, float POFJEGAHBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6088930", Offset = "0x6087B30", VA = "0x186088930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DHGKCDLLHHI : MKMNAFELPND
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds OHOAFKHBALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ONMAPGGLDAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<DHGKCDLLHHI> POMHLADJAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public ONMAPGGLDAN DLAKBCKOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public ONMAPGGLDAN CKOBDCBCBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public ONMAPGGLDAN GKLNJLBIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int INONAEKBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds HEHPMCCLDKL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6089E60", Offset = "0x6089060", VA = "0x186089E60")]
	public ONMAPGGLDAN(List<DHGKCDLLHHI> POMHLADJAEJ, [Optional] ONMAPGGLDAN DLAKBCKOLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JAMLAMDPILE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<ONMAPGGLDAN> CHJDFBEOCGD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ONMAPGGLDAN NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60829F0", Offset = "0x6081BF0", VA = "0x1860829F0")]
	public JAMLAMDPILE(ONMAPGGLDAN MFIBAFBMCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDEEJGOHABP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct HMNHPIDGCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int NAIOLNFHMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int NMNBIAMIPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int GGCGMNHGGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int AEJBHAIDFLD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OHHJNMCPNMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OMBKANGPOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float HMKCGAKADLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<DHGKCDLLHHI> POMHLADJAEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum IHHDLFKIFHG
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
	private HMNHPIDGCMA NGLHIENBJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int EFEKNKDDLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int FBGAOCOMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int MLCCGFFPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float DIELNJHCALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float BEFJFGPKAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<ONMAPGGLDAN> PJDANNPAIEL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JAMLAMDPILE KOBMAPHLBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x607DC90", Offset = "0x607CE90", VA = "0x18607DC90")]
	public DDEEJGOHABP(int FBGAOCOMJHJ, int MLCCGFFPKDD, float DIELNJHCALM, int EFEKNKDDLPM, float BEFJFGPKAMG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x607D030", Offset = "0x607C230", VA = "0x18607D030")]
	public void LGDIOKEDPAA(List<DHGKCDLLHHI> POMHLADJAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x607CFC0", Offset = "0x607C1C0", VA = "0x18607CFC0")]
	public bool IFMBPJEKPHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x607DC20", Offset = "0x607CE20", VA = "0x18607DC20")]
	private float MJBCPLEDAAA(Vector3 HBDGBCALKKA, Vector3 JDDCNPMIKLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x607DC70", Offset = "0x607CE70", VA = "0x18607DC70")]
	private float MJBCPLEDAAA(Vector3 ANCJPCFOHBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x607D250", Offset = "0x607C450", VA = "0x18607D250")]
	private bool MIFIPNEIHPB(ONMAPGGLDAN JFNAIONFHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x607C0E0", Offset = "0x607B2E0", VA = "0x18607C0E0")]
	private OHHJNMCPNMB FIPDLLKHJBK(List<DHGKCDLLHHI> NFFECBPLJHK, IHHDLFKIFHG AALLFFOPPMB)
	{
		return default(OHHJNMCPNMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x607CBC0", Offset = "0x607BDC0", VA = "0x18607CBC0")]
	private void GIEKGNIBGNJ(List<DHGKCDLLHHI> POMHLADJAEJ, Vector3[] HOBFPLLDLMG, Vector3[] MJDPFLLPKLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KKCILAKDEED
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6083D30", Offset = "0x6082F30", VA = "0x186083D30")]
	public static Bounds OFBGMJFAPAF(List<DHGKCDLLHHI> POMHLADJAEJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6083B60", Offset = "0x6082D60", VA = "0x186083B60")]
	public static int OCJCNDLHDAF(List<DHGKCDLLHHI> POMHLADJAEJ, LJPLHCMPBCM MCCIEIKDMFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AACEIDAFINP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FEEDCIOJNFD EBIMEKMDNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FEEDCIOJNFD IBAMPPBINMP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FEEDCIOJNFD FAIMNBFFIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private COOHIMBGANP AENCEGPBOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NGABOLFNHJB BAAPAGBCKHO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle IFPDAOGJICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x854310", Offset = "0x853510", VA = "0x180854310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DOJHJFJNOOM.OHFOIACNLJF JFNAIONFHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BGJBHBKLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x522E9D0", Offset = "0x522DBD0", VA = "0x18522E9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6079590", Offset = "0x6078790", VA = "0x186079590")]
	[LOEDIHPHLOK(JJHPCOMEMKL.ExitingPlayMode, 0)]
	private static void CGHNBPLOMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60796B0", Offset = "0x60788B0", VA = "0x1860796B0")]
	public void GNCDFEHEFDJ(DOJHJFJNOOM.OHFOIACNLJF PDLJJNIDOPK, Transform NIBEEPEELNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6079F40", Offset = "0x6079140", VA = "0x186079F40")]
	public void OPBEJLNIIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6079640", Offset = "0x6078840", VA = "0x186079640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6079600", Offset = "0x6078800", VA = "0x186079600")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x607A5C0", Offset = "0x60797C0", VA = "0x18607A5C0")]
	public AACEIDAFINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GIOLCFABFDF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 KHECAFAGNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MAHKAEAODEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(FMDPIFHBCJG<string>.BBMCKKPJOID GCOIPFEKNMF, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MIJMPOGKIMM
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIJMPOGKIMM PLBEBPAHJHF(Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MIJMPOGKIMM OJFJCPAHEDB(Action OFOIHENMFDE);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class OFILGBAGNIA : MIJMPOGKIMM
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class FCDENABIKGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public OFILGBAGNIA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public FCDENABIKGM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x607F4A0", Offset = "0x607E6A0", VA = "0x18607F4A0")]
				internal void PMHIBMKNIOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x607F450", Offset = "0x607E650", VA = "0x18607F450")]
				internal void GJCHDLNJOHO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x607F400", Offset = "0x607E600", VA = "0x18607F400")]
				internal void CEHADEOHHKN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> JCHMLIMFJEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action MLOJOCOCKHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action JDBGGBJDDFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private JCOCEFJFFEF INJBANFEPHP;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JLLKABGPHCG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action AHADJEPHCDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3F26C70", Offset = "0x3F25E70", VA = "0x183F26C70", Slot = "4")]
			public MIJMPOGKIMM PLBEBPAHJHF(Action OFOIHENMFDE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5B6D090", Offset = "0x5B6C290", VA = "0x185B6D090", Slot = "5")]
			public MIJMPOGKIMM OJFJCPAHEDB(Action OFOIHENMFDE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
			public OFILGBAGNIA(Func<JobHandle> HDJDDBDDGAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x60892B0", Offset = "0x60884B0", VA = "0x1860892B0")]
			public void OFGPKDDGEPG(Action BKHPIFGJPPB, Action KLFAJBDFEJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6089120", Offset = "0x6088320", VA = "0x186089120")]
			public void FBCLMIGJMFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class APBDNFHKECA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public MIJMPOGKIMM jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public APBDNFHKECA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x607A670", Offset = "0x6079870", VA = "0x18607A670")]
			internal bool PHBIBLEANDH(OFILGBAGNIA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class KMDJHHLBKCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public OFILGBAGNIA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public KMDJHHLBKCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x60857A0", Offset = "0x60849A0", VA = "0x1860857A0")]
			internal void GKGFIAGPILE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<OFILGBAGNIA> NFNKMPNFEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<OFILGBAGNIA> AHGEIMIIEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private CHAGHAGMDBI DAGJIBJBOOP;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BMKPLECPHMP OCOJDGNJBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6082B30", Offset = "0x6081D30", VA = "0x186082B30")]
		public MIJMPOGKIMM Add(Func<JobHandle> HDJDDBDDGAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6082E50", Offset = "0x6082050", VA = "0x186082E50")]
		public void Remove(MIJMPOGKIMM IFPDAOGJICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6082C80", Offset = "0x6081E80", VA = "0x186082C80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6083020", Offset = "0x6082220", VA = "0x186083020")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60832D0", Offset = "0x60824D0", VA = "0x1860832D0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6082B20", Offset = "0x6081D20", VA = "0x186082B20")]
		[CompilerGenerated]
		private void AMGOOJHNKIM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JCOCEFJFFEF
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCOCEFJFFEF PLBEBPAHJHF(Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCOCEFJFFEF NIGPNFBIBOC(Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCOCEFJFFEF OJFJCPAHEDB(Action OFOIHENMFDE);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class CDNPIKOHPAL : JCOCEFJFFEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle LIHPOIKCMCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action MLOJOCOCKHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action FMMCGINNFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action AHADJEPHCDJ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool ANGKECGLEDJ
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x607A9A0", Offset = "0x6079BA0", VA = "0x18607A9A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5A80B40", Offset = "0x5A7FD40", VA = "0x185A80B40", Slot = "4")]
			public JCOCEFJFFEF PLBEBPAHJHF(Action OFOIHENMFDE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5A80B60", Offset = "0x5A7FD60", VA = "0x185A80B60", Slot = "5")]
			public JCOCEFJFFEF NIGPNFBIBOC(Action OFOIHENMFDE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5B6D090", Offset = "0x5B6C290", VA = "0x185B6D090", Slot = "6")]
			public JCOCEFJFFEF OJFJCPAHEDB(Action OFOIHENMFDE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1B9FB50", Offset = "0x1B9ED50", VA = "0x181B9FB50")]
			public CDNPIKOHPAL(JobHandle INJCMNACCFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x607A9B0", Offset = "0x6079BB0", VA = "0x18607A9B0")]
			public void MHOCMODHEJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x607A950", Offset = "0x6079B50", VA = "0x18607A950")]
			public void FBCLMIGJMFH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<CDNPIKOHPAL> FLIEECNCGFD;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6083830", Offset = "0x6082A30", VA = "0x186083830")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60833B0", Offset = "0x60825B0", VA = "0x1860833B0")]
		public JCOCEFJFFEF Add(JobHandle INJCMNACCFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6083730", Offset = "0x6082930", VA = "0x186083730")]
		public void Remove(JCOCEFJFFEF IFPDAOGJICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6083580", Offset = "0x6082780", VA = "0x186083580", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60834B0", Offset = "0x60826B0", VA = "0x1860834B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6083970", Offset = "0x6082B70", VA = "0x186083970")]
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
