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
				[Cpp2IlInjected.Address(RVA = "0x6806580", Offset = "0x6805180", VA = "0x186806580")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x15E4700", Offset = "0x15E3300", VA = "0x1815E4700")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6806540", Offset = "0x6805140", VA = "0x186806540")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FA720", Offset = "0x67F9320", VA = "0x1867FA720")]
		public LODSettings HDAFPMEKHGB(KGJGBLBKEFH ICDAEIIIEFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67FA730", Offset = "0x67F9330", VA = "0x1867FA730")]
		public int LHFGFHBDBDJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67FA680", Offset = "0x67F9280", VA = "0x1867FA680")]
		public int DKNDEBDFKBH(bool BDDLIJMJJJF, Vector3 IMMKBKJJLJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67FA750", Offset = "0x67F9350", VA = "0x1867FA750")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KJMFOGIJBNF
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
public interface ACLICHPPEAE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCCDKNGGHGE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KAAKBJDKPAK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HJIDJJLNFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BFALCOKFLLM> IEFCPCHFKLP
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
	void UpdateClusterDistances(Vector3 CILJGBPKAKN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(DADLJCHCGEG KDODEFMCLKH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFALCOKFLLM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EMFHJCOFAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NMALFAHOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KHGPCBDGBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NNMOGMAPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte GIDPDEFLNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ANFGHBAPMEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BAKFDPJLMMD
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
	private struct MBMJEODDFPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ANFGHBAPMEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68065A0", Offset = "0x68051A0", VA = "0x1868065A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6806D30", Offset = "0x6805930", VA = "0x186806D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PMGOCNHEJIE : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ANFGHBAPMEP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public PMGOCNHEJIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6808F70", Offset = "0x6807B70", VA = "0x186808F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6809080", Offset = "0x6807C80", VA = "0x186809080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EIDOIPKGMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ANFGHBAPMEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67FF0B0", Offset = "0x67FDCB0", VA = "0x1867FF0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68008F0", Offset = "0x67FF4F0", VA = "0x1868008F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KDPDJHMBCMF : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ANFGHBAPMEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public KDPDJHMBCMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6804DC0", Offset = "0x68039C0", VA = "0x186804DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6805AA0", Offset = "0x68046A0", VA = "0x186805AA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FFHKNADIDDM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan ECLMPAKEDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer KOFAHFJDIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter AKEJFDFOBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LOHMAAFMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject OKCPJBPPPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NGFBBDPCNEJ EJPHAIJMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DADLJCHCGEG> PCKHBBMEDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DADLJCHCGEG> BBBNMAOAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<DADLJCHCGEG> PHBFFIDBMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int MGHPMJHNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BAKFDPJLMMD BCEKBNCBKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<KAAKBJDKPAK>[] ONFGLFOCGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BFALCOKFLLM>[] ICFEBLMCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource MFJIMHIMBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HHEMNADACFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GNHKJFLENJL FMFJEEEBJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GNHKJFLENJL KGJMBKJGHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int FHACCEMILNI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static ANFGHBAPMEP FDDFAMKEKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MCKJCLOCDGJ HBCNNCENOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly AFCIPFIKJJB OFLPFFKIANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour NGIMIJBCCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material DKGEFGMIBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<ACLICHPPEAE> ILINNFMIPPO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MLPCAPIFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 NOHJDMBOFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8555B0", Offset = "0x8541B0", VA = "0x1808555B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x854FA0", Offset = "0x853BA0", VA = "0x180854FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private BAKFDPJLMMD ACNAEKKHGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B3970", Offset = "0x8B2570", VA = "0x1808B3970")]
		get
		{
			return default(BAKFDPJLMMD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67F8AA0", Offset = "0x67F76A0", VA = "0x1867F8AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ANFGHBAPMEP GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67F83D0", Offset = "0x67F6FD0", VA = "0x1867F83D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool MLPDOLGNCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67F9870", Offset = "0x67F8470", VA = "0x1867F9870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool IPJEFPPNAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67F89E0", Offset = "0x67F75E0", VA = "0x1867F89E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> FBCLFNIFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67F9400", Offset = "0x67F8000", VA = "0x1867F9400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67F9D70", Offset = "0x67F8970", VA = "0x1867F9D70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NNJMMDJBOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67F9A40", Offset = "0x67F8640", VA = "0x1867F9A40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67F97C0", Offset = "0x67F83C0", VA = "0x1867F97C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67F9EA0", Offset = "0x67F8AA0", VA = "0x1867F9EA0")]
	public ANFGHBAPMEP(MCKJCLOCDGJ HBCNNCENOPI, AFCIPFIKJJB OFLPFFKIANF, ClusterLODConfig EFKECPEFKDO, MonoBehaviour NGIMIJBCCBN, Material DKGEFGMIBCI, ClusterMeshRenderer KOFAHFJDIMN, MeshFilter AKEJFDFOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67F88D0", Offset = "0x67F74D0", VA = "0x1867F88D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67F8110", Offset = "0x67F6D10", VA = "0x1867F8110")]
	public static void BFGEKFLGHKB(Vector3 MPBDALIJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67F90A0", Offset = "0x67F7CA0", VA = "0x1867F90A0")]
	private void IAGCEJLECKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67F9970", Offset = "0x67F8570", VA = "0x1867F9970")]
	private void OKBGIFMBHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67F8480", Offset = "0x67F7080", VA = "0x1867F8480")]
	private void DKPGGPKKDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67F79B0", Offset = "0x67F65B0", VA = "0x1867F79B0")]
	public void AHHNFBHHAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67F95C0", Offset = "0x67F81C0", VA = "0x1867F95C0")]
	[AsyncStateMachine(typeof(MBMJEODDFPI))]
	public Task MDJGGLNPDMG(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67F8010", Offset = "0x67F6C10", VA = "0x1867F8010")]
	[IteratorStateMachine(typeof(PMGOCNHEJIE))]
	private IEnumerator<OGKGDFEHPGC> BDMOLDKKLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67F92E0", Offset = "0x67F7EE0", VA = "0x1867F92E0")]
	[AsyncStateMachine(typeof(EIDOIPKGMHE))]
	private Task JPKHOFGLGJJ(GDCBCFBEPNI<string>.LHHFCPKIPMG FNKGNGHOCOA, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67F9B70", Offset = "0x67F8770", VA = "0x1867F9B70")]
	public void PGJAHEGKLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67F9AF0", Offset = "0x67F86F0", VA = "0x1867F9AF0")]
	public void PCBFINAEKID(IEnumerable<KAAKBJDKPAK> KDDHNBNLPOC, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67F85D0", Offset = "0x67F71D0", VA = "0x1867F85D0")]
	public void DNILBPIDOFJ(IEnumerable<KAAKBJDKPAK> KDDHNBNLPOC, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67F7060", Offset = "0x67F5C60", VA = "0x1867F7060")]
	public List<ClusterMeshRenderer> AEBPDMLGNIO(List<DADLJCHCGEG> ENOOBFCNELB, CPCCGGOJAEN BLPDMPJLPPJ, KJMFOGIJBNF IGOCEJPANBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67F8210", Offset = "0x67F6E10", VA = "0x1867F8210")]
	public void BPPMALOBCPB(ACLICHPPEAE EODAOJKHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67F9760", Offset = "0x67F8360", VA = "0x1867F9760")]
	public bool MIJGOAHDEEH(ACLICHPPEAE EODAOJKHFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67F8420", Offset = "0x67F7020", VA = "0x1867F8420")]
	public void CHILLNJHDCN(DADLJCHCGEG FKOEFPKKLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67F8090", Offset = "0x67F6C90", VA = "0x1867F8090")]
	public void BFDHEIOEDFM(BFALCOKFLLM KONMDJKGHML, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67F96E0", Offset = "0x67F82E0", VA = "0x1867F96E0")]
	public void MFBLHFHABBE(BFALCOKFLLM KONMDJKGHML, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67F7860", Offset = "0x67F6460", VA = "0x1867F7860")]
	private void AGALNOOCHLN(Vector3 CILJGBPKAKN, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67F8270", Offset = "0x67F6E70", VA = "0x1867F8270")]
	private void CFNADJCEIDI(Vector3 CILJGBPKAKN, KJMFOGIJBNF IGOCEJPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67F9540", Offset = "0x67F8140", VA = "0x1867F9540")]
	[IteratorStateMachine(typeof(KDPDJHMBCMF))]
	private IEnumerator<OGKGDFEHPGC> MCNPJHEJDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67F8F30", Offset = "0x67F7B30", VA = "0x1867F8F30")]
	private int HIFLOLLPCAN(int OPDMGNJCACB, int NBDILHLKICP, List<BFALCOKFLLM> DKMNHEFMAJN, byte ICDAEIIIEFB, int JFJMAHPGHED, float FHEOKLFDIHO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67F9130", Offset = "0x67F7D30", VA = "0x1867F9130")]
	public void IFPALOLJLCH(DADLJCHCGEG KDODEFMCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67F94C0", Offset = "0x67F80C0", VA = "0x1867F94C0")]
	public bool LHBLPKLKFNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B0A40", Offset = "0x8AF640", VA = "0x1808B0A40")]
	public Material JCNEDOOGCBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67F9500", Offset = "0x67F8100", VA = "0x1867F9500")]
	public int LHFGFHBDBDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67F8BD0", Offset = "0x67F77D0", VA = "0x1867F8BD0")]
	public long FNGLHBNKKEK()
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
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct JHOGBAKJKFK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> CBMBFDLJKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> JMGMPJKEBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> IOIEKIBENAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> GHAMOOBJEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 BJKBGIKAGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float NGAJBJOJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> NNCNOLNIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> PALLNHDIEKG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6803640", Offset = "0x6802240", VA = "0x186803640")]
	public JHOGBAKJKFK(LMMNEJCMKMI AIKMKIOPGIF, NativeList<float3> GHAMOOBJEMJ, NativeParallelMultiHashMap<int, int> NNCNOLNIBOP, NativeArray<int> PALLNHDIEKG, Vector3 BJKBGIKAGJA, float NGAJBJOJBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6802F40", Offset = "0x6801B40", VA = "0x186802F40")]
	private int BLCDCJGGEMJ(float3 CILJGBPKAKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68033D0", Offset = "0x6801FD0", VA = "0x1868033D0")]
	private int MOCEDCGHGIF(int EKELKKECGGF, int DPHIOKCFMFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6802FA0", Offset = "0x6801BA0", VA = "0x186802FA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DLMCPCEBOHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> NNCNOLNIBOP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> PALLNHDIEKG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int ONJKDAFPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> ANMNENCPNMG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67FEEB0", Offset = "0x67FDAB0", VA = "0x1867FEEB0")]
	public void GCJMNEGAMAM(int OGGCPDDOCHP, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67FEDD0", Offset = "0x67FD9D0", VA = "0x1867FEDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DLMCPCEBOHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct JEKAKECBELF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> OJMIIKABODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> CGNNDIIFDBK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6802F10", Offset = "0x6801B10", VA = "0x186802F10")]
	public JEKAKECBELF(DLMCPCEBOHE MJMDJNPBGHG, LMMNEJCMKMI AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6802E60", Offset = "0x6801A60", VA = "0x186802E60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DJIBGILFCGN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> FIJEENPFFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> CGGPJEKDELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> EIPOLOCODAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> KGLPMGDBLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> NMFPDKPAMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> ANMNENCPNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> OJMIIKABODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> CNHEGFDEPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> JPHJPNAKLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> FFALKOKOCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> EACMOKGFIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> IKEJENFFAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> ADMBMMNFKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float MMNPAAMBCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float OCJCEHEHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 NOPBGNDNPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float BLEFOJOEJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float JLEJKNBMOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float CEGICKHHGEL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67FEC90", Offset = "0x67FD890", VA = "0x1867FEC90")]
	public DJIBGILFCGN(DLMCPCEBOHE FHKJMDLGNBJ, LMMNEJCMKMI AIKMKIOPGIF, LMMNEJCMKMI FBPMIAKBDID, float JLEJKNBMOOI, float CEGICKHHGEL, Vector3 NOPBGNDNPEO, float BLEFOJOEJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67FE830", Offset = "0x67FD430", VA = "0x1867FE830")]
	private float3 HFHGHHOCPNH(int EKELKKECGGF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67FE650", Offset = "0x67FD250", VA = "0x1867FE650")]
	private void GBJPLILMKLM(int EKELKKECGGF, [Out] float3 LOMLDELGDMP, [Out] float3 AAHJNKJEEKJ, [Out] float4 MOHLKJIAGDJ, [Out] float4 AGDIPEKKOHL, [Out] float2 GCGLAINAAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67FE9A0", Offset = "0x67FD5A0", VA = "0x1867FE9A0")]
	private int PMCOBBDBDCP(int KBFHDEMMFEK, int ACFMPMLDNJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67FD850", Offset = "0x67FC450", VA = "0x1867FD850")]
	private void BOLHCEJACEO(int KBFHDEMMFEK, int ACFMPMLDNJN, int LFDCDOKGNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67FD700", Offset = "0x67FC300", VA = "0x1867FD700")]
	private bool BCDKPDHBJBC(int KBFHDEMMFEK, int ACFMPMLDNJN, float LPPLCONFAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67FE8E0", Offset = "0x67FD4E0", VA = "0x1867FE8E0")]
	private bool OKLNCECGEKL(int KBFHDEMMFEK, int ACFMPMLDNJN, int LFDCDOKGNPA, float LPPLCONFAPH, bool IEFNJBJCDKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67FDA50", Offset = "0x67FC650", VA = "0x1867FDA50")]
	private bool CGEAOHAPKKI(int KBFHDEMMFEK, int ACFMPMLDNJN, int LFDCDOKGNPA, float LPPLCONFAPH, bool IEFNJBJCDKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67FDCB0", Offset = "0x67FC8B0", VA = "0x1867FDCB0")]
	private void CICCCHIAFJH(int KBFHDEMMFEK, int ACFMPMLDNJN, int LFDCDOKGNPA, [Out] int HLDECPKHNLN, [Out] int JKCEODPODPP, [Out] int EINGGHGKFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67FDCD0", Offset = "0x67FC8D0", VA = "0x1867FDCD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DGGKFKBIOGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JKHDGEAIDGN : IDisposable, BFALCOKFLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds AKMEOKEDLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<DADLJCHCGEG> ENOOBFCNELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 GKGPCPPCECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 KDFDNLLCINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int KCJPLEAMHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LMMNEJCMKMI HOFHHGLCDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long OECEGLPBLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DLMCPCEBOHE BNNKBNODLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform BLPDMPJLPPJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int PGHFGHHMFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6803DA0", Offset = "0x68029A0", VA = "0x186803DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh PDKBIMIMKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CJOOICEEADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float KHGPCBDGBLC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B39B0", Offset = "0x8B25B0", VA = "0x1808B39B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5E8FE10", Offset = "0x5E8EA10", VA = "0x185E8FE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte GIDPDEFLNOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x90B370", Offset = "0x909F70", VA = "0x18090B370")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9EDD70", Offset = "0x9EC970", VA = "0x1809EDD70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int EMFHJCOFAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xBAAFF0", Offset = "0xBA9BF0", VA = "0x180BAAFF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBAA2D0", Offset = "0xBA8ED0", VA = "0x180BAA2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NMALFAHOJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE99840", Offset = "0xE98440", VA = "0x180E99840", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE987D0", Offset = "0xE973D0", VA = "0x180E987D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float NNMOGMAPBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6803700", Offset = "0x6802300", VA = "0x186803700", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6803B40", Offset = "0x6802740", VA = "0x186803B40")]
		public void HLOOBDJEBAP(KGJGBLBKEFH ICDAEIIIEFB, [Out] int DEKBEBJEJFH, [Out] int ONAEOHMBPHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6803720", Offset = "0x6802320", VA = "0x186803720")]
		public void CLIKAKHCLNI(KGJGBLBKEFH ICDAEIIIEFB, MIFCIJEACKE FFMLDGLBBOI, int PFMHMDAIDDB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6803DE0", Offset = "0x68029E0", VA = "0x186803DE0")]
		public void OFDNNJAGFDM(Mesh AIKMKIOPGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6803AB0", Offset = "0x68026B0", VA = "0x186803AB0")]
		public void FLLKOGCPICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68038F0", Offset = "0x68024F0", VA = "0x1868038F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6803E80", Offset = "0x6802A80", VA = "0x186803E80")]
		public JKHDGEAIDGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds AKMEOKEDLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<JKHDGEAIDGN> KHMEBPDOIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public OMEGIEMJDJH KLPNLLNDJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer ONIAHHAAJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int EONFJHGEOAM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OEOBLGFMCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PIMFAOFHHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E90", Offset = "0x9B0A90", VA = "0x1809B1E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA07C40", Offset = "0xA06840", VA = "0x180A07C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HJIDJJLNFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67FCDE0", Offset = "0x67FB9E0", VA = "0x1867FCDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67FC1D0", Offset = "0x67FADD0", VA = "0x1867FC1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67FC350", Offset = "0x67FAF50", VA = "0x1867FC350")]
	public int FBBDDLGHANE(int EHDDPLOHBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x67FBFF0", Offset = "0x67FABF0", VA = "0x1867FBFF0")]
	public void CNBJENLBNKB(DIKGMIIIAID HBANIKHBPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67FCE30", Offset = "0x67FBA30", VA = "0x1867FCE30")]
	public void JMMENLHHMFF(Transform AENEBDOMFOD, bool DAFDILOPPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67FC9B0", Offset = "0x67FB5B0", VA = "0x1867FC9B0")]
	public bool GMJFIFIJALF(bool JFOMOANFKPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x67FC380", Offset = "0x67FAF80", VA = "0x1867FC380")]
	public void GKFJIPLBOKE(Transform BLPDMPJLPPJ, bool DAFDILOPPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x67FCB70", Offset = "0x67FB770", VA = "0x1867FCB70")]
	public bool IFPALOLJLCH(DADLJCHCGEG KDODEFMCLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67FD5C0", Offset = "0x67FC1C0", VA = "0x1867FD5C0")]
	public DGGKFKBIOGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NGFBBDPCNEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<DGGKFKBIOGC.JKHDGEAIDGN> CDLHOFFEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ABIANNJEFHF BFOLDPBDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<DGGKFKBIOGC.JKHDGEAIDGN> LBCAFEFFKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CJAGCHGBFGH;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6806EC0", Offset = "0x6805AC0", VA = "0x186806EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6807940", Offset = "0x6806540", VA = "0x186807940")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68075F0", Offset = "0x68061F0", VA = "0x1868075F0")]
	public void MPFJKDGCCNN(DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM, Transform BLPDMPJLPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68073A0", Offset = "0x6805FA0", VA = "0x1868073A0")]
	public void IFPALOLJLCH(DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6807260", Offset = "0x6805E60", VA = "0x186807260")]
	private DGGKFKBIOGC.JKHDGEAIDGN HCHAPAAKCFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6806E20", Offset = "0x6805A20", VA = "0x186806E20")]
	private bool DIDLEPIKBHB(DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6806D90", Offset = "0x6805990", VA = "0x186806D90")]
	private void AGJDAODILOP(DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6806DF0", Offset = "0x68059F0", VA = "0x186806DF0")]
	public bool ANLBAMCFNBM(DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x68076B0", Offset = "0x68062B0", VA = "0x1868076B0")]
	public bool NBJEMGDMOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6807580", Offset = "0x6806180", VA = "0x186807580")]
	private DGGKFKBIOGC.JKHDGEAIDGN MGDMNGBJHAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6806F40", Offset = "0x6805B40", VA = "0x186806F40")]
	public long FNGLHBNKKEK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68079C0", Offset = "0x68065C0", VA = "0x1868079C0")]
	public NGFBBDPCNEJ()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LLILDOEAPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JDODADCHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int KJKIGJEBNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float CDJPDPHMHJJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<DGGKFKBIOGC> DDCDLFKDFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68064F0", Offset = "0x68050F0", VA = "0x1868064F0")]
	public LLILDOEAPJB(int JDODADCHICP, int KJKIGJEBNJP, float JDGBHECBHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6806390", Offset = "0x6804F90", VA = "0x186806390")]
	public void IICALFABOAL(ACBIHBKNCAJ DEHFPEPIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6806440", Offset = "0x6805040", VA = "0x186806440")]
	private int MGMLGLOJLCF(DIKGMIIIAID LNFMEAPGAAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6806180", Offset = "0x6804D80", VA = "0x186806180")]
	private void IICALFABOAL(DIKGMIIIAID LNFMEAPGAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6805F40", Offset = "0x6804B40", VA = "0x186805F40")]
	private void BHIACNBBDPJ(DIKGMIIIAID LNFMEAPGAAK, DGGKFKBIOGC ONOJDEELJNC)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, KAAKBJDKPAK
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DAICOPAOJPP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
			[DebuggerHidden]
			public DAICOPAOJPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x67FBCF0", Offset = "0x67FA8F0", VA = "0x1867FBCF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x67FBEB0", Offset = "0x67FAAB0", VA = "0x1867FBEB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x67FBE00", Offset = "0x67FAA00", VA = "0x1867FBE00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67FBE00", Offset = "0x67FAA00", VA = "0x1867FBE00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int HJIDJJLNFFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x67FBC90", Offset = "0x67FA890", VA = "0x1867FBC90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<BFALCOKFLLM> IEFCPCHFKLP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x67FBC70", Offset = "0x67FA870", VA = "0x1867FBC70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> KHMEBPDOIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DGGKFKBIOGC OEOBLGFMCME
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KJMFOGIJBNF EMBDIOKNAEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(KJMFOGIJBNF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x844550", Offset = "0x843150", VA = "0x180844550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool OIEJOFACLBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1AEE530", Offset = "0x1AED130", VA = "0x181AEE530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67FA7B0", Offset = "0x67F93B0", VA = "0x1867FA7B0")]
		public static ClusterMeshRenderer Create(DGGKFKBIOGC AIKMKIOPGIF, ClusterMeshRenderer KOFAHFJDIMN, MeshFilter AKEJFDFOBFC, CPCCGGOJAEN BLPDMPJLPPJ, KJMFOGIJBNF IGOCEJPANBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67FA920", Offset = "0x67F9520", VA = "0x1867FA920", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x67FB170", Offset = "0x67F9D70", VA = "0x1867FB170", Slot = "9")]
		public bool TryRemoveClusterLODComponent(DADLJCHCGEG KDODEFMCLKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x67FAF20", Offset = "0x67F9B20", VA = "0x1867FAF20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x67FAB90", Offset = "0x67F9790", VA = "0x1867FAB90")]
		public void Init(DGGKFKBIOGC AIKMKIOPGIF, MeshFilter AKEJFDFOBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67FA980", Offset = "0x67F9580", VA = "0x1867FA980")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67FB2A0", Offset = "0x67F9EA0", VA = "0x1867FB2A0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 CILJGBPKAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB550", Offset = "0x67FA150", VA = "0x1867FB550", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67FAB10", Offset = "0x67F9710", VA = "0x1867FAB10")]
		[IteratorStateMachine(typeof(DAICOPAOJPP))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67FAFB0", Offset = "0x67F9BB0", VA = "0x1867FAFB0")]
		public void SetupTagAndLayer(string HGIJFHOADFN, int IGOCEJPANBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67FAF90", Offset = "0x67F9B90", VA = "0x1867FAF90")]
		public bool Remove(DADLJCHCGEG KDODEFMCLKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IPKNAKFCDEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KDFNMOINNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int PAGNMFPMINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int ONAEOHMBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DEKBEBJEJFH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6802E40", Offset = "0x6801A40", VA = "0x186802E40")]
	public IPKNAKFCDEI(int PAGNMFPMINA, int ONAEOHMBPHC, int KDFNMOINNLI, int DEKBEBJEJFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OMEGIEMJDJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> ANMNENCPNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> IOIEKIBENAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<IPKNAKFCDEI> MAOOCHMNPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> JHENAABMBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> ACKKMFOHKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> OLLNCKNOMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle CAEABJCEFAI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KLEOOCIKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1021520", Offset = "0x1020120", VA = "0x181021520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1020FD0", Offset = "0x101FBD0", VA = "0x181020FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6807E20", Offset = "0x6806A20", VA = "0x186807E20")]
	public void JOJMDOFEJMG(LMMNEJCMKMI BFNFDCLDNFB, NativeList<IPKNAKFCDEI> MAOOCHMNPOH, float IADPMFLONGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6808CB0", Offset = "0x68078B0", VA = "0x186808CB0")]
	public void OCGBBCAHIJE(Transform BLPDMPJLPPJ, bool DAFDILOPPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6807C80", Offset = "0x6806880", VA = "0x186807C80")]
	public void GMJFIFIJALF(DGGKFKBIOGC ONIAHHAAJEH, bool JFOMOANFKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6807B70", Offset = "0x6806770", VA = "0x186807B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6808F40", Offset = "0x6807B40", VA = "0x186808F40")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OMEGIEMJDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GDNMBJFIPLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> ANMNENCPNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<IPKNAKFCDEI> PNPGDPHEOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> JHENAABMBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 NOPBGNDNPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> ACKKMFOHKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> OLLNCKNOMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool DAFDILOPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float DAIDGPJNMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float IGKELGBHGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float DHPDODEGAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> IOIEKIBENAB;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6802920", Offset = "0x6801520", VA = "0x186802920")]
	public GDNMBJFIPLM(OMEGIEMJDJH ILGBALCJADO, Vector3 NOPBGNDNPEO, bool DAFDILOPPPI, float DAIDGPJNMHO, float IGKELGBHGMA, float DHPDODEGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6802410", Offset = "0x6801010", VA = "0x186802410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DADLJCHCGEG : DDMJJMAFFKD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds GFHJFDFEGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DIKGMIIIAID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<DADLJCHCGEG> ENOOBFCNELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public DIKGMIIIAID GPMGJNAOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public DIKGMIIIAID NAPJOJBNBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public DIKGMIIIAID BGCMHGMPOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int DEKBEBJEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds AKMEOKEDLJG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x67FD680", Offset = "0x67FC280", VA = "0x1867FD680")]
	public DIKGMIIIAID(List<DADLJCHCGEG> ENOOBFCNELB, [Optional] DIKGMIIIAID GPMGJNAOOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ACBIHBKNCAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<DIKGMIIIAID> DCJNLEIAKMO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DIKGMIIIAID MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67F6F90", Offset = "0x67F5B90", VA = "0x1867F6F90")]
	public ACBIHBKNCAJ(DIKGMIIIAID BLPDMPJLPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FEPFFHLFEKG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct FGGNJKBAIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int IEIGKDMGKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int NFIHHMBJOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int AAFIPDPFHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int INBHJOPNNGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OLGFBOFJAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int BLBNOCBAMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float GLMKOKGJJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<DADLJCHCGEG> ENOOBFCNELB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NLHPAAPCPEG
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
	private FGGNJKBAIPJ ELNGEFHIEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KPGMECIJHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JDODADCHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int KJKIGJEBNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float JDGBHECBHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float OPNKNJNKHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<DIKGMIIIAID> HNOLHFIGGBM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public ACBIHBKNCAJ JFFAAPGIAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68023B0", Offset = "0x6800FB0", VA = "0x1868023B0")]
	public FEPFFHLFEKG(int JDODADCHICP, int KJKIGJEBNJP, float JDGBHECBHJG, int KPGMECIJHCB, float OPNKNJNKHNM = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68021E0", Offset = "0x6800DE0", VA = "0x1868021E0")]
	public void PJFHIIJGFFF(List<DADLJCHCGEG> ENOOBFCNELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6802170", Offset = "0x6800D70", VA = "0x186802170")]
	public bool OGOJKEOJKKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6802120", Offset = "0x6800D20", VA = "0x186802120")]
	private float MALOJJGADKB(Vector3 KFFFFOIIONO, Vector3 EJBCANAPLDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6802100", Offset = "0x6800D00", VA = "0x186802100")]
	private float MALOJJGADKB(Vector3 AEOJMEBJNPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68018C0", Offset = "0x68004C0", VA = "0x1868018C0")]
	private bool JADBNOCBABD(DIKGMIIIAID EJGLNJIHLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6800DB0", Offset = "0x67FF9B0", VA = "0x186800DB0")]
	private OLGFBOFJAPP ICAILACHBCL(List<DADLJCHCGEG> GMNNKOPHJAH, NLHPAAPCPEG JPHHLDCLJPJ)
	{
		return default(OLGFBOFJAPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68009B0", Offset = "0x67FF5B0", VA = "0x1868009B0")]
	private void HNPCDIDECDL(List<DADLJCHCGEG> ENOOBFCNELB, Vector3[] DKCGPBCLFBJ, Vector3[] EKKOLLMODNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KPBKOGNJFLN
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6805CC0", Offset = "0x68048C0", VA = "0x186805CC0")]
	public static Bounds JDNEIALGHDC(List<DADLJCHCGEG> ENOOBFCNELB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6805AF0", Offset = "0x68046F0", VA = "0x186805AF0")]
	public static int CBNCALLEGGB(List<DADLJCHCGEG> ENOOBFCNELB, KGJGBLBKEFH ICDAEIIIEFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ABIANNJEFHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private LMMNEJCMKMI LBPNKEECINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LMMNEJCMKMI PEMHNCKDIAK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static LMMNEJCMKMI ABMNBJJBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FFNAJOLLOGD FIPNINMIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MIFCIJEACKE FFMLDGLBBOI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle CAEABJCEFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977790", VA = "0x180978B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DGGKFKBIOGC.JKHDGEAIDGN EJGLNJIHLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LCLOHLCIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x23BC560", Offset = "0x23BB160", VA = "0x1823BC560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67F5ED0", Offset = "0x67F4AD0", VA = "0x1867F5ED0")]
	[LOAPKAJPCGD(OBAOEJFCFBL.ExitingPlayMode, 0)]
	private static void FDKHHMPINBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67F5F50", Offset = "0x67F4B50", VA = "0x1867F5F50")]
	public void JOJMDOFEJMG(DGGKFKBIOGC.JKHDGEAIDGN PNPGDPHEOOM, Transform LAPGAEAOBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67F6840", Offset = "0x67F5440", VA = "0x1867F6840")]
	public void PIOFFMCAJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67F5E60", Offset = "0x67F4A60", VA = "0x1867F5E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67F6800", Offset = "0x67F5400", VA = "0x1867F6800")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x67F6EE0", Offset = "0x67F5AE0", VA = "0x1867F6EE0")]
	public ABIANNJEFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AFCIPFIKJJB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 JLBODKKMGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MCKJCLOCDGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GDCBCFBEPNI<string>.LHHFCPKIPMG FNKGNGHOCOA, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JKOCGADJEPE
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKOCGADJEPE OPOGNEIJIEE(Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKOCGADJEPE OOKMGMGDIPC(Action FIPNCHEIGMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class IAEEBGFJBLD : JKOCGADJEPE
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class DEEFKLKIEOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public IAEEBGFJBLD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
				public DEEFKLKIEOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x67FBF50", Offset = "0x67FAB50", VA = "0x1867FBF50")]
				internal void ECPHKJMPGII()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x67FBFA0", Offset = "0x67FABA0", VA = "0x1867FBFA0")]
				internal void FJELHGFEJFF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x67FBF00", Offset = "0x67FAB00", VA = "0x1867FBF00")]
				internal void CJANDEFJDHN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> FMHGICHLCAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action EKOOBBAOEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action BDAMLBKOHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private CMPMDOPPKJD IGCKKJNNNCI;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action MCCNMBJBJLL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action KPHOLOPLJHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4E52730", Offset = "0x4E51330", VA = "0x184E52730", Slot = "4")]
			public JKOCGADJEPE OPOGNEIJIEE(Action FIPNCHEIGMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x62CC6D0", Offset = "0x62CB2D0", VA = "0x1862CC6D0", Slot = "5")]
			public JKOCGADJEPE OOKMGMGDIPC(Action FIPNCHEIGMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
			public IAEEBGFJBLD(Func<JobHandle> BOEEKDGODMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6802B80", Offset = "0x6801780", VA = "0x186802B80")]
			public void JHMLCEABGGF(Action EHCOBDODNHB, Action GHJACPAGGFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x68029F0", Offset = "0x68015F0", VA = "0x1868029F0")]
			public void IFPALOLJLCH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BHDPNCGIJHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JKOCGADJEPE jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BHDPNCGIJHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x67FA670", Offset = "0x67F9270", VA = "0x1867FA670")]
			internal bool KILPMDCHJEC(IAEEBGFJBLD a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EIINEHPAEHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public IAEEBGFJBLD newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public EIINEHPAEHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6800950", Offset = "0x67FF550", VA = "0x186800950")]
			internal void FJFEGAAPDNE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<IAEEBGFJBLD> JEAHHNEENKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<IAEEBGFJBLD> KJIKFJGBDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GNHKJFLENJL MDINIPCEGPG;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HBLJGINEBFO OAFOLNBDFLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6803F80", Offset = "0x6802B80", VA = "0x186803F80")]
		public JKOCGADJEPE Add(Func<JobHandle> BOEEKDGODMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68042B0", Offset = "0x6802EB0", VA = "0x1868042B0")]
		public void Remove(JKOCGADJEPE CAEABJCEFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68040E0", Offset = "0x6802CE0", VA = "0x1868040E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6804480", Offset = "0x6803080", VA = "0x186804480")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68046E0", Offset = "0x68032E0", VA = "0x1868046E0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x68040D0", Offset = "0x6802CD0", VA = "0x1868040D0")]
		[CompilerGenerated]
		private void NNLGDCFLHGI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CMPMDOPPKJD
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMPMDOPPKJD OPOGNEIJIEE(Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMPMDOPPKJD HBHHHANODBF(Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMPMDOPPKJD OOKMGMGDIPC(Action FIPNCHEIGMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class LDHOKCHGDGC : CMPMDOPPKJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle JKCKPIMPHKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action EKOOBBAOEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action LOEICABGIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action KPHOLOPLJHC;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool BGOANOOCCPN
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x6805E90", Offset = "0x6804A90", VA = "0x186805E90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x61DEE50", Offset = "0x61DDA50", VA = "0x1861DEE50", Slot = "4")]
			public CMPMDOPPKJD OPOGNEIJIEE(Action FIPNCHEIGMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x61DEE70", Offset = "0x61DDA70", VA = "0x1861DEE70", Slot = "5")]
			public CMPMDOPPKJD HBHHHANODBF(Action FIPNCHEIGMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x62CC6D0", Offset = "0x62CB2D0", VA = "0x1862CC6D0", Slot = "6")]
			public CMPMDOPPKJD OOKMGMGDIPC(Action FIPNCHEIGMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1D78310", Offset = "0x1D76F10", VA = "0x181D78310")]
			public LDHOKCHGDGC(JobHandle LCPBFFFPEDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6805EF0", Offset = "0x6804AF0", VA = "0x186805EF0")]
			public void IKNIENNEJLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6805EA0", Offset = "0x6804AA0", VA = "0x186805EA0")]
			public void IFPALOLJLCH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<LDHOKCHGDGC> DEFEKLNACMD;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6804BE0", Offset = "0x68037E0", VA = "0x186804BE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68047C0", Offset = "0x68033C0", VA = "0x1868047C0")]
		public CMPMDOPPKJD Add(JobHandle LCPBFFFPEDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6804AE0", Offset = "0x68036E0", VA = "0x186804AE0")]
		public void Remove(CMPMDOPPKJD CAEABJCEFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6804930", Offset = "0x6803530", VA = "0x186804930", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6804860", Offset = "0x6803460", VA = "0x186804860")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6804D20", Offset = "0x6803920", VA = "0x186804D20")]
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
