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
				[Cpp2IlInjected.Address(RVA = "0x554CD80", Offset = "0x554C180", VA = "0x18554CD80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x2633920", Offset = "0x2632D20", VA = "0x182633920")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x554CD40", Offset = "0x554C140", VA = "0x18554CD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x553D5E0", Offset = "0x553C9E0", VA = "0x18553D5E0")]
		public LODSettings GLFFPOBMPFB(CFCICPKONAK HJPMNNIECBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x553D5C0", Offset = "0x553C9C0", VA = "0x18553D5C0")]
		public int BECGGPKEBGD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x553D5F0", Offset = "0x553C9F0", VA = "0x18553D5F0")]
		public int NNFKIOODLPH(bool FBFNKBCGCJC, Vector3 AFEFLEJODEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x553D6F0", Offset = "0x553CAF0", VA = "0x18553D6F0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GDAFCFMNOKN
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
public interface MEMLBCJBJNC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGOLPCEHPGA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CCLPIHFCJIB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int EHIGHLKFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IGJOHABGBAO> MJHBOIAFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GDAFCFMNOKN EMNKIDMPNBO
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
	void UpdateClusterDistances(Vector3 DDPAJGCOAKM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(NDBABMLBGLI NDJEINDKPBB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IGJOHABGBAO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int MFBPNMHPKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int ENPOFDHAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float IIKEIKNEADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EOIGEGHMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte LFJMHICOCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HDAACHKOBJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BNNEOLHDKGM
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
	private struct JIEIEAPHILF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HDAACHKOBJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LHKKDNHCKDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LHKKDNHCKDD <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5548260", Offset = "0x5547660", VA = "0x185548260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NPPDEDIDADN : IEnumerator<OJLOAAGJFIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private OJLOAAGJFIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HDAACHKOBJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OJLOAAGJFIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
		[DebuggerHidden]
		public NPPDEDIDADN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x554CF10", Offset = "0x554C310", VA = "0x18554CF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x554CFD0", Offset = "0x554C3D0", VA = "0x18554CFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HFGDDMGCPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HDAACHKOBJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LHKKDNHCKDD worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LHKKDNHCKDD <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5545100", Offset = "0x5544500", VA = "0x185545100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GOCBJPMMIAN : IEnumerator<OJLOAAGJFIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OJLOAAGJFIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public HDAACHKOBJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OJLOAAGJFIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x671200", Offset = "0x670600", VA = "0x180671200")]
		[DebuggerHidden]
		public GOCBJPMMIAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x55410E0", Offset = "0x55404E0", VA = "0x1855410E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5541F90", Offset = "0x5541390", VA = "0x185541F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HDPNGGEOBOI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan FCLPAAECKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer CNLPMMHOHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter BFEJBJJIEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject HLOPNADEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject GHHKOFJBKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LFLBLLCCKGP AFDEMPIONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NDBABMLBGLI> JFGIFKPLKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NDBABMLBGLI> FEMLDLEBHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<NDBABMLBGLI> DLEPIJMAPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JBDDJHGFDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BNNEOLHDKGM JODOMMPMLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CCLPIHFCJIB>[] MJMDDCAAKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<IGJOHABGBAO>[] DBMGIDHNACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource GMAPPFHHEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool EMLLDIEDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OILBMJAJEOH EMDCABMOHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OILBMJAJEOH AMNKNFMEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int KMCFFMHDIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MKBFEPMIIID;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static HDAACHKOBJC BLGBDLKAPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EBFNBIPHJLI JCLFMFIAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GEEMAGBBANB LEGKNIDJALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour CMGIIKDOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material FPOLKPABDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<MEMLBCJBJNC> CJDOKPPMDBD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig OEOLBMDEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 FIEBOOIDAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1921BE0", Offset = "0x1920FE0", VA = "0x181921BE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1921B00", Offset = "0x1920F00", VA = "0x181921B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private BNNEOLHDKGM JNNMDMEANFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A40", Offset = "0x7C1E40", VA = "0x1807C2A40")]
		get
		{
			return default(BNNEOLHDKGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5543B40", Offset = "0x5542F40", VA = "0x185543B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static HDAACHKOBJC PNBICMAKACI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5543C70", Offset = "0x5543070", VA = "0x185543C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HNBMICICNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5543180", Offset = "0x5542580", VA = "0x185543180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool GMGCIFJHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5542F90", Offset = "0x5542390", VA = "0x185542F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> KOODLCMPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55447D0", Offset = "0x5543BD0", VA = "0x1855447D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5544730", Offset = "0x5543B30", VA = "0x185544730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BBFFACKAPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5543960", Offset = "0x5542D60", VA = "0x185543960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x55430E0", Offset = "0x55424E0", VA = "0x1855430E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55448E0", Offset = "0x5543CE0", VA = "0x1855448E0")]
	public HDAACHKOBJC(EBFNBIPHJLI JCLFMFIAINK, GEEMAGBBANB LEGKNIDJALD, ClusterLODConfig IPNBEAEFDMB, MonoBehaviour CMGIIKDOCFL, Material FPOLKPABDLN, ClusterMeshRenderer CNLPMMHOHLG, MeshFilter BFEJBJJIEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55429D0", Offset = "0x5541DD0", VA = "0x1855429D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5543CD0", Offset = "0x55430D0", VA = "0x185543CD0")]
	public static void ODBMJKBLGGI(Vector3 GEFOPCHADDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5542330", Offset = "0x5541730", VA = "0x185542330")]
	private void BFNIDCJKKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5544630", Offset = "0x5543A30", VA = "0x185544630")]
	private void OHNAFMEDMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5542800", Offset = "0x5541C00", VA = "0x185542800")]
	private void DBHMJBEAOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55432A0", Offset = "0x55426A0", VA = "0x1855432A0")]
	public void JEEDEFABNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5543A00", Offset = "0x5542E00", VA = "0x185543A00")]
	[AsyncStateMachine(typeof(JIEIEAPHILF))]
	public Task KPJLNCFHMDN(LHKKDNHCKDD DIECPHHHGGG, CancellationToken DAOHELLFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5543070", Offset = "0x5542470", VA = "0x185543070")]
	[IteratorStateMachine(typeof(NPPDEDIDADN))]
	private IEnumerator<OJLOAAGJFIF> IIMAEIEBANI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5542E50", Offset = "0x5542250", VA = "0x185542E50")]
	[AsyncStateMachine(typeof(HFGDDMGCPBI))]
	private Task HKMJGBMDCPP(LHKKDNHCKDD NJLCNJIDKGB, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5542590", Offset = "0x5541990", VA = "0x185542590")]
	public void CMDBPEOMIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5542DD0", Offset = "0x55421D0", VA = "0x185542DD0")]
	public void HDKMFPKDMEP(IEnumerable<CCLPIHFCJIB> KBJGCOIAAPO, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5542030", Offset = "0x5541430", VA = "0x185542030")]
	public void AOOOLNMLNNB(IEnumerable<CCLPIHFCJIB> KBJGCOIAAPO, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5543E00", Offset = "0x5543200", VA = "0x185543E00")]
	public List<ClusterMeshRenderer> ODKHPDCMGFD(List<NDBABMLBGLI> ICJBAHODFKP, JACNJHHOBDA JAFNHFEOMPI, GDAFCFMNOKN IPGMADJADMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55422B0", Offset = "0x55416B0", VA = "0x1855422B0")]
	public GDAFCFMNOKN BABBHMDDEKD(Vector3 MLMNDKDHLOI)
	{
		return default(GDAFCFMNOKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55427A0", Offset = "0x5541BA0", VA = "0x1855427A0")]
	public void COFJNOCAAFF(MEMLBCJBJNC ACBFMBJDIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5541FD0", Offset = "0x55413D0", VA = "0x185541FD0")]
	public bool AMFMLONLAFB(MEMLBCJBJNC ACBFMBJDIEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5542B90", Offset = "0x5541F90", VA = "0x185542B90")]
	public void GGFIJBHKMKP(NDBABMLBGLI NICJDJIBJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5542950", Offset = "0x5541D50", VA = "0x185542950")]
	public void DOJMFFMABHP(IGJOHABGBAO OJDJPBHEIMB, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5542B10", Offset = "0x5541F10", VA = "0x185542B10")]
	public void GBKPCPBHCOO(IGJOHABGBAO OJDJPBHEIMB, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5543800", Offset = "0x5542C00", VA = "0x185543800")]
	private void JEPMHNCEFHD(Vector3 DDPAJGCOAKM, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55423C0", Offset = "0x55417C0", VA = "0x1855423C0")]
	private void BIDKFPHOFHF(Vector3 DDPAJGCOAKM, GDAFCFMNOKN IPGMADJADMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5542520", Offset = "0x5541920", VA = "0x185542520")]
	[IteratorStateMachine(typeof(GOCBJPMMIAN))]
	private IEnumerator<OJLOAAGJFIF> CHPIIDBMHDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55444B0", Offset = "0x55438B0", VA = "0x1855444B0")]
	private int ODPOPEMJNGI(int PGFOAHEHPOH, int MILLIOCCCBF, List<IGJOHABGBAO> FBGICECMKMA, byte HJPMNNIECBA, ref int HFHAOHGOILC, float CMEAKBHCPKK = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5542BF0", Offset = "0x5541FF0", VA = "0x185542BF0")]
	public void GMLJNDAKNDK(NDBABMLBGLI NDJEINDKPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5542AD0", Offset = "0x5541ED0", VA = "0x185542AD0")]
	public bool FAKDJAEHBAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7257A0", Offset = "0x724BA0", VA = "0x1807257A0")]
	public Material BOCHLPDNKDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55422F0", Offset = "0x55416F0", VA = "0x1855422F0")]
	public int BECGGPKEBGD()
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
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BPPPHFJLCCP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> GLAEFEMGIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> BGMMGCLAMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> CJBGDLHENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> LLDGEBAJKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> LCIEBLDBAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> LBCJAENOALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> ACGOEJJOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 FKJLGIBDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float PKGCEHIILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> AOCDGEGFOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> KLFGOHPANAI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x553D2A0", Offset = "0x553C6A0", VA = "0x18553D2A0")]
	public BPPPHFJLCCP(NCEJEJIHIMC DKKFAMCHLJC, NativeList<float3> ACGOEJJOFNK, NativeMultiHashMap<int, int> AOCDGEGFOJK, NativeArray<int> KLFGOHPANAI, Vector3 FKJLGIBDGPI, float PKGCEHIILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x553D270", Offset = "0x553C670", VA = "0x18553D270")]
	private int JJMIBCEGOFD(float3 DDPAJGCOAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x553D010", Offset = "0x553C410", VA = "0x18553D010")]
	private int HOAGBPJHIGP(int BBOINFMIBOM, int MPIADBGKNBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x553CBE0", Offset = "0x553BFE0", VA = "0x18553CBE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LMHENCDJOBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> AOCDGEGFOJK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> KLFGOHPANAI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int JEMJABAILMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> AOCFJKBNCBG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x554CB50", Offset = "0x554BF50", VA = "0x18554CB50")]
	public void MACOGFHEOOD(int DPFMNMLFNHH, Allocator NHNCCHNPCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x554CA70", Offset = "0x554BE70", VA = "0x18554CA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LMHENCDJOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HFEJPOOALFN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> FELAFBKPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> PHENLGNEAGH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55450D0", Offset = "0x55444D0", VA = "0x1855450D0")]
	public HFEJPOOALFN(LMHENCDJOBB FLGKBHHEKNH, NCEJEJIHIMC DKKFAMCHLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5545030", Offset = "0x5544430", VA = "0x185545030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct IBLOBHADGAH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> FOKBFILKLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> HPBCBDFEDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> DOGKAFICKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> OFKAJDKDBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> LMMIGNOCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> AOCFJKBNCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> FELAFBKPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> OBGBFFODCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> BOEIFDCAEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LOEHCKJKKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> BAEDMOJIFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> APIPLGOGNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> CJFBEMDPAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float IGFGBGBFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float MHMPKKEBDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 FFBJJILBDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LBELFDHAPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float IKBHIBDFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float PAKNAMCBNFF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5547A70", Offset = "0x5546E70", VA = "0x185547A70")]
	public IBLOBHADGAH(LMHENCDJOBB EDCMCDDBOCP, NCEJEJIHIMC DKKFAMCHLJC, NCEJEJIHIMC ELLEDPDBIIF, float IKBHIBDFIPF, float PAKNAMCBNFF, Vector3 FFBJJILBDAJ, float LBELFDHAPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55479C0", Offset = "0x5546DC0", VA = "0x1855479C0")]
	private float3 PJGPHNEKAEE(int BBOINFMIBOM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55470D0", Offset = "0x55464D0", VA = "0x1855470D0")]
	private void IPFBIMGOILL(int BBOINFMIBOM, out float3 AIDALEDEDEA, out float3 NCEMDFBDDJD, out float4 DEKNBBPCLNJ, out float4 OFDPPLAGONI, out float2 CFHHCKOOCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55472C0", Offset = "0x55466C0", VA = "0x1855472C0")]
	private int JBLHGHCBKAB(int EBOGECNNIBH, int NNJOOCEBBDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5546EC0", Offset = "0x55462C0", VA = "0x185546EC0")]
	private void GEDKAJGFHMB(int EBOGECNNIBH, int NNJOOCEBBDL, int LAHCGMCMKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5547830", Offset = "0x5546C30", VA = "0x185547830")]
	private bool NLMNBGJDLPN(int EBOGECNNIBH, int NNJOOCEBBDL, float OLDGDOFCGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x55464C0", Offset = "0x55458C0", VA = "0x1855464C0")]
	private bool ACNJLKLIMIM(int EBOGECNNIBH, int NNJOOCEBBDL, int LAHCGMCMKCF, float OLDGDOFCGJD, bool CGCJGCFFJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55475C0", Offset = "0x55469C0", VA = "0x1855475C0")]
	private bool KOFFDGAEHKK(int EBOGECNNIBH, int NNJOOCEBBDL, int LAHCGMCMKCF, float OLDGDOFCGJD, bool CGCJGCFFJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5546580", Offset = "0x5545980", VA = "0x185546580")]
	private void CIOIKJBGPGF(int EBOGECNNIBH, int NNJOOCEBBDL, int LAHCGMCMKCF, out int MEJMGDIHMLH, out int EEEHJMKLKLH, out int BHLBEIFGPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55465A0", Offset = "0x55459A0", VA = "0x1855465A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LDFABGLADCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PDCEIEHOMFE : IDisposable, IGJOHABGBAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds JJOGFAELGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<NDBABMLBGLI> ICJBAHODFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 JEDJNFMLCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 HMFPGBCHMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int PGIFNMJMKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NCEJEJIHIMC ONHIFHNLPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public LMHENCDJOBB IAHAGMDBFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform JAFNHFEOMPI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int NALEJFGGANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x554DB10", Offset = "0x554CF10", VA = "0x18554DB10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh DLKEEAOPJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh KNCMNKFLOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float IIKEIKNEADK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x113CD50", Offset = "0x113C150", VA = "0x18113CD50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2C4B6E0", Offset = "0x2C4AAE0", VA = "0x182C4B6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte LFJMHICOCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9EDCE0", Offset = "0x9ED0E0", VA = "0x1809EDCE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MFBPNMHPKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA86060", Offset = "0xA85460", VA = "0x180A86060", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA86070", Offset = "0xA85470", VA = "0x180A86070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ENPOFDHAPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCC2F40", Offset = "0xCC2340", VA = "0x180CC2F40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xF3FF90", Offset = "0xF3F390", VA = "0x180F3FF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EOIGEGHMEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x554D030", Offset = "0x554C430", VA = "0x18554D030", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x554D540", Offset = "0x554C940", VA = "0x18554D540")]
		public void IMJHBHKOLDF(CFCICPKONAK HJPMNNIECBA, out int NBLPLJKHIBJ, out int JBBLOONAOFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x554D390", Offset = "0x554C790", VA = "0x18554D390")]
		public void HKNKLNBLCHG(CFCICPKONAK HJPMNNIECBA, CJGCOAKKICH GILJFEALDKC, int IDNLGJGNGGH = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x554D770", Offset = "0x554CB70", VA = "0x18554D770")]
		public void KKCADLAAGFD(NativeList<FHODJMIMKCJ> HOCMGBAHAON, Transform CKOEJNAMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x554D050", Offset = "0x554C450", VA = "0x18554D050")]
		public void CFCNPNGHKEH(Mesh DKKFAMCHLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x554D2F0", Offset = "0x554C6F0", VA = "0x18554D2F0")]
		public void EMCGAENNNNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x554D0F0", Offset = "0x554C4F0", VA = "0x18554D0F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x554DB50", Offset = "0x554CF50", VA = "0x18554DB50")]
		public PDCEIEHOMFE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds JJOGFAELGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<PDCEIEHOMFE> PIAKMJJEABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public JKKDJOPGAIB JHNJHHLMKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer GKBALKCFPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int CCKGKHBCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh NPCIGKNAGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AMPOEJDDEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x808720", Offset = "0x807B20", VA = "0x180808720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EHIGHLKFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x554BF00", Offset = "0x554B300", VA = "0x18554BF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x554ACE0", Offset = "0x554A0E0", VA = "0x18554ACE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x554B8C0", Offset = "0x554ACC0", VA = "0x18554B8C0")]
	public int JLDHPDCGOEF(int ABEHHJGHAGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x554B8F0", Offset = "0x554ACF0", VA = "0x18554B8F0")]
	public void MMJFCJJBAOF(IIMGDDIHJKH EOOMBGOFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x554B0F0", Offset = "0x554A4F0", VA = "0x18554B0F0")]
	public void HNFEDMGHCAH(Transform CKOEJNAMAGP, bool CIHJNEMFHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x554AB20", Offset = "0x5549F20", VA = "0x18554AB20")]
	public bool BDBNLGLCJCF(bool LALINBJIGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x554BAB0", Offset = "0x554AEB0", VA = "0x18554BAB0")]
	public void MNGOOILGHOA(Transform JAFNHFEOMPI, bool CIHJNEMFHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x554AE40", Offset = "0x554A240", VA = "0x18554AE40")]
	public bool GMLJNDAKNDK(NDBABMLBGLI NDJEINDKPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x554BF50", Offset = "0x554B350", VA = "0x18554BF50")]
	public LDFABGLADCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LFLBLLCCKGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<LDFABGLADCD.PDCEIEHOMFE> DBFLPONIBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AFBPKPFGCLB IMFLBKEMKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<LDFABGLADCD.PDCEIEHOMFE> KLKEAGGEDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int MEAAGLIBLBO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x554C330", Offset = "0x554B730", VA = "0x18554C330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x554C6E0", Offset = "0x554BAE0", VA = "0x18554C6E0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x554C400", Offset = "0x554B800", VA = "0x18554C400")]
	public void EIPAABBBFMM(LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD, Transform JAFNHFEOMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x554C4F0", Offset = "0x554B8F0", VA = "0x18554C4F0")]
	public void GMLJNDAKNDK(LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x554C7C0", Offset = "0x554BBC0", VA = "0x18554C7C0")]
	private LDFABGLADCD.PDCEIEHOMFE OHFCEFOBNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x554C290", Offset = "0x554B690", VA = "0x18554C290")]
	private bool DHECLBEBHGH(LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x554C760", Offset = "0x554BB60", VA = "0x18554C760")]
	private void LJHHMDLBNPP(LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x554C4C0", Offset = "0x554B8C0", VA = "0x18554C4C0")]
	public bool GHGELJELEPL(LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x554C000", Offset = "0x554B400", VA = "0x18554C000")]
	public bool ADDBGNGPEPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x554C3A0", Offset = "0x554B7A0", VA = "0x18554C3A0")]
	private LDFABGLADCD.PDCEIEHOMFE ECBOMBFBGNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x554C8F0", Offset = "0x554BCF0", VA = "0x18554C8F0")]
	public LFLBLLCCKGP()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PMDLLINKMNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int IFLKOIANCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int EHGCNGNOHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float HGBDIMBHDLG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<LDFABGLADCD> JGGCGDPMCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x554E240", Offset = "0x554D640", VA = "0x18554E240")]
	public PMDLLINKMNF(int IFLKOIANCEN, int EHGCNGNOHHI, float JJMNGLMDLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x554DE40", Offset = "0x554D240", VA = "0x18554DE40")]
	public void JFFMGPKDDLN(GLCENGLGJCH KMFAAOMKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x554E1A0", Offset = "0x554D5A0", VA = "0x18554E1A0")]
	private int MOHMPCDGNIE(IIMGDDIHJKH GIGDHNFIFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x554DF60", Offset = "0x554D360", VA = "0x18554DF60")]
	private void JFFMGPKDDLN(IIMGDDIHJKH GIGDHNFIFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x554DC30", Offset = "0x554D030", VA = "0x18554DC30")]
	private void EAIIOGJKJNH(IIMGDDIHJKH GIGDHNFIFBE, LDFABGLADCD OPLMGPEOLII)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CCLPIHFCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CBMCCCLAHCN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public CBMCCCLAHCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x553D360", Offset = "0x553C760", VA = "0x18553D360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x553D510", Offset = "0x553C910", VA = "0x18553D510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x553D470", Offset = "0x553C870", VA = "0x18553D470", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x553D470", Offset = "0x553C870", VA = "0x18553D470", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int EHIGHLKFOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x553EB90", Offset = "0x553DF90", VA = "0x18553EB90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<IGJOHABGBAO> MJHBOIAFHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x553EB70", Offset = "0x553DF70", VA = "0x18553EB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> PIAKMJJEABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public LDFABGLADCD NPCIGKNAGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GDAFCFMNOKN EMNKIDMPNBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x68F1B0", Offset = "0x68E5B0", VA = "0x18068F1B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(GDAFCFMNOKN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x822DE0", Offset = "0x8221E0", VA = "0x180822DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OLOIJIDHGDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x553EB80", Offset = "0x553DF80", VA = "0x18553EB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x553D750", Offset = "0x553CB50", VA = "0x18553D750")]
		public static ClusterMeshRenderer Create(LDFABGLADCD DKKFAMCHLJC, ClusterMeshRenderer CNLPMMHOHLG, MeshFilter BFEJBJJIEAB, JACNJHHOBDA JAFNHFEOMPI, GDAFCFMNOKN IPGMADJADMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x553D8F0", Offset = "0x553CCF0", VA = "0x18553D8F0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x553E0B0", Offset = "0x553D4B0", VA = "0x18553E0B0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(NDBABMLBGLI NDJEINDKPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x553DEA0", Offset = "0x553D2A0", VA = "0x18553DEA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x553DB40", Offset = "0x553CF40", VA = "0x18553DB40")]
		public void Init(LDFABGLADCD DKKFAMCHLJC, MeshFilter BFEJBJJIEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x553D950", Offset = "0x553CD50", VA = "0x18553D950")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x553E1E0", Offset = "0x553D5E0", VA = "0x18553E1E0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 DDPAJGCOAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x553E3F0", Offset = "0x553D7F0", VA = "0x18553E3F0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x553DAD0", Offset = "0x553CED0", VA = "0x18553DAD0")]
		[IteratorStateMachine(typeof(CBMCCCLAHCN))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x553DF20", Offset = "0x553D320", VA = "0x18553DF20")]
		public void SetupTagAndLayer(string LMFEBLFMKNE, int IPGMADJADMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x553DF00", Offset = "0x553D300", VA = "0x18553DF00")]
		public bool Remove(NDBABMLBGLI NDJEINDKPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OLIABJIFAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int FNGPMDGLPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CBFHONBGCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JBBLOONAOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NBLPLJKHIBJ;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x554D010", Offset = "0x554C410", VA = "0x18554D010")]
	public OLIABJIFAFJ(int CBFHONBGCKO, int JBBLOONAOFG, int FNGPMDGLPOI, int NBLPLJKHIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JKKDJOPGAIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> GLAEFEMGIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> AOCFJKBNCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> LBCJAENOALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<OLIABJIFAFJ> GLIPIAPKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> ODPPNPMLBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> GDHFPHLCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> MKKHCOEDDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle KNAKGAMMCOC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IGFDOADKIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC5E9A0", Offset = "0xC5DDA0", VA = "0x180C5E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC5EF40", Offset = "0xC5E340", VA = "0x180C5EF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5548E20", Offset = "0x5548220", VA = "0x185548E20")]
	public void NGKBIODLKGD(NCEJEJIHIMC DBDCDADENGO, NativeList<OLIABJIFAFJ> GLIPIAPKOKG, float PDDMGAHIAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x55489F0", Offset = "0x5547DF0", VA = "0x1855489F0")]
	public void CBNKHGOHGAM(Transform JAFNHFEOMPI, bool CIHJNEMFHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5548840", Offset = "0x5547C40", VA = "0x185548840")]
	public void BDBNLGLCJCF(LDFABGLADCD GKBALKCFPMJ, bool LALINBJIGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5548CE0", Offset = "0x55480E0", VA = "0x185548CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5548DF0", Offset = "0x55481F0", VA = "0x185548DF0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JKKDJOPGAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct BBOFGDECBAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> GLAEFEMGIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> AOCFJKBNCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<OLIABJIFAFJ> DJKGILJALBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> ODPPNPMLBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 FFBJJILBDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> GDHFPHLCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> MKKHCOEDDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool CIHJNEMFHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float BABJFNACJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float MMNDGADAMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float CNCDGDFJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> LBCJAENOALC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x553CB10", Offset = "0x553BF10", VA = "0x18553CB10")]
	public BBOFGDECBAP(JKKDJOPGAIB IJJLHLHPAFL, Vector3 FFBJJILBDAJ, bool CIHJNEMFHNF, float BABJFNACJPC, float MMNDGADAMNC, float CNCDGDFJIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x553C680", Offset = "0x553BA80", VA = "0x18553C680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NDBABMLBGLI : OOILBGJIPAL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds JBGBMFJILID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FHODJMIMKCJ LOOBJEPIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIMGDDIHJKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<NDBABMLBGLI> ICJBAHODFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public IIMGDDIHJKH BLENCGKHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public IIMGDDIHJKH NIDMGILHFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public IIMGDDIHJKH FGCEFFIDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int NBLPLJKHIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds JJOGFAELGAA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5547BB0", Offset = "0x5546FB0", VA = "0x185547BB0")]
	public IIMGDDIHJKH(List<NDBABMLBGLI> ICJBAHODFKP, [Optional] IIMGDDIHJKH BLENCGKHIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GLCENGLGJCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<IIMGDDIHJKH> DLJCDJFJKFE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IIMGDDIHJKH HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5541010", Offset = "0x5540410", VA = "0x185541010")]
	public GLCENGLGJCH(IIMGDDIHJKH JAFNHFEOMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GBEEMCFCOBM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct JKIBFLJMKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int HKALFACKBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int BCAJMIPCLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JNHMECIMKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int HJKIEHOBMEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct CJEEJBJBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int HODKKEPLOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float JHPDCFPDDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<NDBABMLBGLI> ICJBAHODFKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HLNLCIGBJLP
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
	private JKIBFLJMKBL JNGDDKEOJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KMJCAIEAEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int IFLKOIANCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int EHGCNGNOHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float JJMNGLMDLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float JJJKKDHLCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<IIMGDDIHJKH> BCAICICINFF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GLCENGLGJCH PNEHFACEGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5540FB0", Offset = "0x55403B0", VA = "0x185540FB0")]
	public GBEEMCFCOBM(int IFLKOIANCEN, int EHGCNGNOHHI, float JJMNGLMDLHF, int KMJCAIEAEEN, float JJJKKDHLCDA = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x553F420", Offset = "0x553E820", VA = "0x18553F420")]
	public void KFDNADHIGDA(List<NDBABMLBGLI> ICJBAHODFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5540250", Offset = "0x553F650", VA = "0x185540250")]
	public bool LLBCBGCOMJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x553F350", Offset = "0x553E750", VA = "0x18553F350")]
	private float JLOBGOONMMO(Vector3 KCAMANKDPPD, Vector3 PCCFFNKLAEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x553F3D0", Offset = "0x553E7D0", VA = "0x18553F3D0")]
	private float JLOBGOONMMO(Vector3 FOADGJOOFID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5540720", Offset = "0x553FB20", VA = "0x185540720")]
	private bool NPKJFKBFNLA(IIMGDDIHJKH PALBKJCHBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x553F620", Offset = "0x553EA20", VA = "0x18553F620")]
	private CJEEJBJBILM KGOBDEAKIKK(List<NDBABMLBGLI> GAEIKELGFNC, HLNLCIGBJLP HEFEPHMBIGK)
	{
		return default(CJEEJBJBILM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55402C0", Offset = "0x553F6C0", VA = "0x1855402C0")]
	private void NCIOLCHPLKI(List<NDBABMLBGLI> ICJBAHODFKP, Vector3[] CIJKMBOMNML, Vector3[] MJHAOEOAEPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class EKNAMAPNBHB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x553EFF0", Offset = "0x553E3F0", VA = "0x18553EFF0")]
	public static Bounds HPKPMENEHHH(List<NDBABMLBGLI> ICJBAHODFKP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x553F1A0", Offset = "0x553E5A0", VA = "0x18553F1A0")]
	public static int IJKBFBAAAPJ(List<NDBABMLBGLI> ICJBAHODFKP, CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AFBPKPFGCLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NCEJEJIHIMC JLFMBJPLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private NCEJEJIHIMC BOFCMNFEIGE;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static NCEJEJIHIMC APGAKFAPBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PBNHEHJNFPF FAKENDAHFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private CJGCOAKKICH GILJFEALDKC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle KNAKGAMMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xDA7B30", Offset = "0xDA6F30", VA = "0x180DA7B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LDFABGLADCD.PDCEIEHOMFE PALBKJCHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ALPPMNJMELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x705580", Offset = "0x704980", VA = "0x180705580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x553BA70", Offset = "0x553AE70", VA = "0x18553BA70")]
	[OPBFEDEIAPM(HPHNAPCJKPB.ExitingPlayMode, 0)]
	private void LOPKAMADHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x553BAE0", Offset = "0x553AEE0", VA = "0x18553BAE0")]
	public void NGKBIODLKGD(LDFABGLADCD.PDCEIEHOMFE DJKGILJALBH, Transform HGBFADCANJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x553B2D0", Offset = "0x553A6D0", VA = "0x18553B2D0")]
	public void BIAGBKAGBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x553B9C0", Offset = "0x553ADC0", VA = "0x18553B9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x553BA30", Offset = "0x553AE30", VA = "0x18553BA30")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x553C5E0", Offset = "0x553B9E0", VA = "0x18553C5E0")]
	public AFBPKPFGCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KNCJEJMNIHP
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HDAACHKOBJC BJLDGIMAEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GEEMAGBBANB
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 MNMEACNINAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EBFNBIPHJLI
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(LHKKDNHCKDD NJLCNJIDKGB, CancellationToken BJBDGBAHFDE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FKCEBMEEINE
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKCEBMEEINE JNOENEFEBAE(Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKCEBMEEINE DKMNEFCLELD(Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKCEBMEEINE OAMMKPNOODN(Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKCEBMEEINE GJGELMKBJIF(Action PADKGNIPPLI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class DIILDPOBGEH : FKCEBMEEINE
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class NJGAPMKPNNH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public DIILDPOBGEH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
				public NJGAPMKPNNH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x554CE30", Offset = "0x554C230", VA = "0x18554CE30")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x554CE80", Offset = "0x554C280", VA = "0x18554CE80")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x554CED0", Offset = "0x554C2D0", VA = "0x18554CED0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> OCEOHPBBAKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action MNFAKAMHENP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action NOGGEMODCKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private CDAFDGELMOF NHHJDCIPHNN;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action DCKHADPKDCF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action DAGLFFEMHNC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x275F340", Offset = "0x275E740", VA = "0x18275F340", Slot = "4")]
			public FKCEBMEEINE JNOENEFEBAE(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2647400", Offset = "0x2646800", VA = "0x182647400", Slot = "5")]
			public FKCEBMEEINE DKMNEFCLELD(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2647420", Offset = "0x2646820", VA = "0x182647420", Slot = "6")]
			public FKCEBMEEINE OAMMKPNOODN(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3847E30", Offset = "0x3847230", VA = "0x183847E30", Slot = "7")]
			public FKCEBMEEINE GJGELMKBJIF(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
			public DIILDPOBGEH(Func<JobHandle> IGOODCHJCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x553ED60", Offset = "0x553E160", VA = "0x18553ED60")]
			public void PAOKGAPHMII(Action JGANILGIFAE, Action OPGOJPHBEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x553EBF0", Offset = "0x553DFF0", VA = "0x18553EBF0")]
			public void GMLJNDAKNDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CPDEDBBIONB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FKCEBMEEINE jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public CPDEDBBIONB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x553D5B0", Offset = "0x553C9B0", VA = "0x18553D5B0")]
			internal bool <Remove>b__0(DIILDPOBGEH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CIMODPEJJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public DIILDPOBGEH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public CIMODPEJJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x553D550", Offset = "0x553C950", VA = "0x18553D550")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<DIILDPOBGEH> MMJDDNCGEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<DIILDPOBGEH> OCOOILINPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private OILBMJAJEOH IPKAELKDLFP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FLGALCPDFNA GBHBOKBFIOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5549D40", Offset = "0x5549140", VA = "0x185549D40")]
		public FKCEBMEEINE Add(Func<JobHandle> IGOODCHJCBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x554A040", Offset = "0x5549440", VA = "0x18554A040")]
		public void Remove(FKCEBMEEINE KNAKGAMMCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5549EA0", Offset = "0x55492A0", VA = "0x185549EA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x554A210", Offset = "0x5549610", VA = "0x18554A210")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x554A460", Offset = "0x5549860", VA = "0x18554A460")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5549E90", Offset = "0x5549290", VA = "0x185549E90")]
		[CompilerGenerated]
		private void EJCMAMOCLPL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CDAFDGELMOF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDAFDGELMOF JNOENEFEBAE(Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDAFDGELMOF AJMKJKLONGP(Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CDAFDGELMOF GJGELMKBJIF(Action PADKGNIPPLI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class MIMHEEEEMIE : CDAFDGELMOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle LFLIKBIJPAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action MNFAKAMHENP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action HCKKLCMCLHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action DAGLFFEMHNC;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool ENFHMMFAACB
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x554CDA0", Offset = "0x554C1A0", VA = "0x18554CDA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2647400", Offset = "0x2646800", VA = "0x182647400", Slot = "4")]
			public CDAFDGELMOF JNOENEFEBAE(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2647420", Offset = "0x2646820", VA = "0x182647420", Slot = "5")]
			public CDAFDGELMOF AJMKJKLONGP(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3847E30", Offset = "0x3847230", VA = "0x183847E30", Slot = "6")]
			public CDAFDGELMOF GJGELMKBJIF(Action PADKGNIPPLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xDA06B0", Offset = "0xD9FAB0", VA = "0x180DA06B0")]
			public MIMHEEEEMIE(JobHandle PCLAACGDLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x554CDB0", Offset = "0x554C1B0", VA = "0x18554CDB0")]
			public void DACLICHPPJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x554CDF0", Offset = "0x554C1F0", VA = "0x18554CDF0")]
			public void GMLJNDAKNDK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<MIMHEEEEMIE> KBNAAGIINDN;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x554A940", Offset = "0x5549D40", VA = "0x18554A940")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x554A560", Offset = "0x5549960", VA = "0x18554A560")]
		public CDAFDGELMOF Add(JobHandle PCLAACGDLEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x554A850", Offset = "0x5549C50", VA = "0x18554A850")]
		public void Remove(CDAFDGELMOF KNAKGAMMCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x554A6E0", Offset = "0x5549AE0", VA = "0x18554A6E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x554A5F0", Offset = "0x55499F0", VA = "0x18554A5F0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x554AA60", Offset = "0x5549E60", VA = "0x18554AA60")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5547F80", Offset = "0x5547380", VA = "0x185547F80")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5547C30", Offset = "0x5547030", VA = "0x185547C30")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
