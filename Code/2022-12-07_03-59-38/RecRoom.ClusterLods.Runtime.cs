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
				[Cpp2IlInjected.Address(RVA = "0x5692520", Offset = "0x5691120", VA = "0x185692520")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xEDF200", Offset = "0xEDDE00", VA = "0x180EDF200")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x56924E0", Offset = "0x56910E0", VA = "0x1856924E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5682E70", Offset = "0x5681A70", VA = "0x185682E70")]
		public LODSettings KEKENFLNDOG(GDKHEHMFMDH GDADPCNKOEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5682E80", Offset = "0x5681A80", VA = "0x185682E80")]
		public int KGDKGLDJGCG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5682D70", Offset = "0x5681970", VA = "0x185682D70")]
		public int BJABKGKMAJO(bool AAHPDNHEDLM, Vector3 GJPJNEEKAPO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5682EA0", Offset = "0x5681AA0", VA = "0x185682EA0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BPMGFIAKIJD
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
public interface FOOFENKGEBC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJMEFOKCJNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface APLOMLGDHAO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LIHEPKADHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JIGEJGIHOPK> AFAMNKKHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BPMGFIAKIJD GFBIABOLAFE
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
	void UpdateClusterDistances(Vector3 ENDJGEOLLFP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(CMCNBMINKIM CNBPNBOALAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JIGEJGIHOPK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int PCJFGODIKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LEPDNCNOPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NHCCHGLLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DNJABCILHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte GJEAOBDHMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FOCKCKKFJOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KPOPCHOIOHE
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
	private struct AOGMJAPNABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FOCKCKKFJOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IFANLHMJJPA <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x56826B0", Offset = "0x56812B0", VA = "0x1856826B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DHONPBLGBFO : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FOCKCKKFJOG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public DHONPBLGBFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5684E10", Offset = "0x5683A10", VA = "0x185684E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5684ED0", Offset = "0x5683AD0", VA = "0x185684ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMAPMHHCNFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FOCKCKKFJOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IFANLHMJJPA worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IFANLHMJJPA <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x568F270", Offset = "0x568DE70", VA = "0x18568F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EOEDELJMODL : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FOCKCKKFJOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public EOEDELJMODL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5684FA0", Offset = "0x5683BA0", VA = "0x185684FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5685E50", Offset = "0x5684A50", VA = "0x185685E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FLOEIJLOFLI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan EBFKHFCNMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ADNIOOABGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter CFOHMKJKLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OENLLKMNPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject DPBNDLMPCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public DFHIKAOBHKG AHDBGGHKPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<CMCNBMINKIM> DKIIKBLCHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<CMCNBMINKIM> CGJPDCPMDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<CMCNBMINKIM> BBMGFDKHLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int OCNCGBBIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KPOPCHOIOHE BOJBDGFHODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<APLOMLGDHAO>[] GHOBNHBKFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<JIGEJGIHOPK>[] BOPGEFOGFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource HJMLGGPCFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool MBEIJAECOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GMBEEMHKFHH NHFNIIDPPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GMBEEMHKFHH JOHKHNCCHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int FAMJGONDOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int FBJCPBDIPFF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static FOCKCKKFJOG OBHHJPCPMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FHKMKPJFFLK ELONJLGMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OLNCNGNGOOK AJPKBHBIFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour LFHNCONMDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material DGCDKNBFOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<FOOFENKGEBC> FGHICGPIIKC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JAHJINALINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 BIKJJGDCNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B4C710", Offset = "0x1B4B310", VA = "0x181B4C710")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B4C630", Offset = "0x1B4B230", VA = "0x181B4C630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KPOPCHOIOHE MEHPFLKCKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C5300", Offset = "0x7C3F00", VA = "0x1807C5300")]
		get
		{
			return default(KPOPCHOIOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5687380", Offset = "0x5685F80", VA = "0x185687380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static FOCKCKKFJOG OHEGMANNBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5687D40", Offset = "0x5686940", VA = "0x185687D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HACBHBAFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5687260", Offset = "0x5685E60", VA = "0x185687260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool BGIAJCHLDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x56876A0", Offset = "0x56862A0", VA = "0x1856876A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IAOJLBFCPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5685E90", Offset = "0x5684A90", VA = "0x185685E90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5687E70", Offset = "0x5686A70", VA = "0x185687E70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NGLAOKDPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5687780", Offset = "0x5686380", VA = "0x185687780")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5686300", Offset = "0x5684F00", VA = "0x185686300")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x56887A0", Offset = "0x56873A0", VA = "0x1856887A0")]
	public FOCKCKKFJOG(FHKMKPJFFLK ELONJLGMJIM, OLNCNGNGOOK AJPKBHBIFMC, ClusterLODConfig IOCGLNLBDAG, MonoBehaviour LFHNCONMDEM, Material DGCDKNBFOBF, ClusterMeshRenderer ADNIOOABGGF, MeshFilter CFOHMKJKLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56864E0", Offset = "0x56850E0", VA = "0x1856864E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56878A0", Offset = "0x56864A0", VA = "0x1856878A0")]
	public static void KBNOGNLFBGN(Vector3 HDIJDDGPICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5686E70", Offset = "0x5685A70", VA = "0x185686E70")]
	private void FFMFBADFBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5687F90", Offset = "0x5686B90", VA = "0x185687F90")]
	private void PDBGLBFIPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5687BF0", Offset = "0x56867F0", VA = "0x185687BF0")]
	private void LBEJCANGIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5688090", Offset = "0x5686C90", VA = "0x185688090")]
	public void PFCDNDPBLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56885F0", Offset = "0x56871F0", VA = "0x1856885F0")]
	[AsyncStateMachine(typeof(AOGMJAPNABI))]
	public Task PGMENDAKFGC(IFANLHMJJPA DHJIFBEMLMJ, CancellationToken CLLGBCLOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56874B0", Offset = "0x56860B0", VA = "0x1856874B0")]
	[IteratorStateMachine(typeof(DHONPBLGBFO))]
	private IEnumerator<FEPBFCLHFNJ> HAIFHPHDFPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x56863A0", Offset = "0x5684FA0", VA = "0x1856863A0")]
	[AsyncStateMachine(typeof(KMAPMHHCNFP))]
	private Task DPEFNNANFPG(IFANLHMJJPA ABMHJJFBKGF, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5685F30", Offset = "0x5684B30", VA = "0x185685F30")]
	public void BIAMNAEPKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5687F10", Offset = "0x5686B10", VA = "0x185687F10")]
	public void OHOPICELKAG(IEnumerable<APLOMLGDHAO> JBOFLBAFHHN, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5686F00", Offset = "0x5685B00", VA = "0x185686F00")]
	public void FIMCCHDOMMN(IEnumerable<APLOMLGDHAO> JBOFLBAFHHN, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5686740", Offset = "0x5685340", VA = "0x185686740")]
	public List<ClusterMeshRenderer> EGECOCACFNC(List<CMCNBMINKIM> MFLNELLNMCD, BALPOLLGHCC KAHCIEGOGHO, BPMGFIAKIJD BIGEMEHMIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5687220", Offset = "0x5685E20", VA = "0x185687220")]
	public BPMGFIAKIJD GBHMOMLEDKK(Vector3 NPKELLKKCLO)
	{
		return default(BPMGFIAKIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5687E10", Offset = "0x5686A10", VA = "0x185687E10")]
	public void LIBKNHMDOLJ(FOOFENKGEBC EPKOFLDHLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5687180", Offset = "0x5685D80", VA = "0x185687180")]
	public bool FNIABFHBJLD(FOOFENKGEBC EPKOFLDHLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x56862A0", Offset = "0x5684EA0", VA = "0x1856862A0")]
	public void CCJNEMOMDPH(CMCNBMINKIM NCOPIOCCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5687820", Offset = "0x5686420", VA = "0x185687820")]
	public void JIBECECHJLK(JIGEJGIHOPK EAAHIFALAJC, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5686DF0", Offset = "0x56859F0", VA = "0x185686DF0")]
	public void ENGONIHNAGG(JIGEJGIHOPK EAAHIFALAJC, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5686140", Offset = "0x5684D40", VA = "0x185686140")]
	private void BJOJPHOIFJM(Vector3 ENDJGEOLLFP, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x56865E0", Offset = "0x56851E0", VA = "0x1856865E0")]
	private void ECFBOBDKJLI(Vector3 ENDJGEOLLFP, BPMGFIAKIJD BIGEMEHMIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5687DA0", Offset = "0x56869A0", VA = "0x185687DA0")]
	[IteratorStateMachine(typeof(EOEDELJMODL))]
	private IEnumerator<FEPBFCLHFNJ> LIAGDLMCLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5687520", Offset = "0x5686120", VA = "0x185687520")]
	private int HCGCHJCHGNG(int KLEGICPDLIF, int ODLCPAMOLIJ, List<JIGEJGIHOPK> ILAEKDGHJGC, byte GDADPCNKOEN, ref int MJLJOLMFMNI, float ODAONAMNABA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56879D0", Offset = "0x56865D0", VA = "0x1856879D0")]
	public void KFPKFODPJHB(CMCNBMINKIM CNBPNBOALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56871E0", Offset = "0x5685DE0", VA = "0x1856871E0")]
	public bool FPKBMGDAAEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86A4D0", Offset = "0x8690D0", VA = "0x18086A4D0")]
	public Material OKLKLIHMDFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5687BB0", Offset = "0x56867B0", VA = "0x185687BB0")]
	public int KGDKGLDJGCG()
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
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GEHGNDNHOCJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> OJFIELGCCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> CNLGPBFGLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> NLEHHAGNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> GCOIOGEAIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> EGFMAPGNMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> MALHNKJOHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> BJMBIMAFAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 NMFABAHDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float KNKLDAJFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> OCOMJONAHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> BFJCKBACMBN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x56895B0", Offset = "0x56881B0", VA = "0x1856895B0")]
	public GEHGNDNHOCJ(FFBGKCAFEKO DNIOKNPDAGH, NativeList<float3> BJMBIMAFAHK, NativeMultiHashMap<int, int> OCOMJONAHCA, NativeArray<int> BFJCKBACMBN, Vector3 NMFABAHDKHP, float KNKLDAJFJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5689580", Offset = "0x5688180", VA = "0x185689580")]
	private int MNDPMLNONCF(float3 ENDJGEOLLFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5689320", Offset = "0x5687F20", VA = "0x185689320")]
	private int LJKIODEFENO(int NFLKAEEEFMF, int NANBEBOOGPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5688EF0", Offset = "0x5687AF0", VA = "0x185688EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JNLPHPOAKAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> OCOMJONAHCA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> BFJCKBACMBN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int NNLLMAJMAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> LOHJDPBKJDP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x568C890", Offset = "0x568B490", VA = "0x18568C890")]
	public void IHCLHEMMHCM(int KKEGFEFDCPN, Allocator JMMNDPMBMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x568C7B0", Offset = "0x568B3B0", VA = "0x18568C7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JNLPHPOAKAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IHCNJJPOJGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> FFCJEJHGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> JDKLJJLLJAF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x568C0F0", Offset = "0x568ACF0", VA = "0x18568C0F0")]
	public IHCNJJPOJGK(JNLPHPOAKAD IMPPJFAIHLE, FFBGKCAFEKO DNIOKNPDAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x568C050", Offset = "0x568AC50", VA = "0x18568C050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct AILIIFCOCHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> IBFJLHNDDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> COPONGAPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> GODNNCAONPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> POHHLINGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> GOLFOBONGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> LOHJDPBKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> FFCJEJHGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> NFMCFGCDBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> CCCIILGKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LCKOBPMHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> PGEBPKABOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> GLMADDLBGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> JGKCNFJDOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float LNIEDIHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float LGHPLLJDHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 HOIBGFPEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float HNDFCDMECFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float KIEIKBGOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float IEGEAIOEFAA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5682550", Offset = "0x5681150", VA = "0x185682550")]
	public AILIIFCOCHK(JNLPHPOAKAD KDCHNODFIFF, FFBGKCAFEKO DNIOKNPDAGH, FFBGKCAFEKO BNGAFJFKLFD, float KIEIKBGOLNN, float IEGEAIOEFAA, Vector3 HOIBGFPEDJG, float HNDFCDMECFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5682040", Offset = "0x5680C40", VA = "0x185682040")]
	private float3 GGJLJOAMIJC(int NFLKAEEEFMF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56820F0", Offset = "0x5680CF0", VA = "0x1856820F0")]
	private void HDFOMNDHGOG(int NFLKAEEEFMF, out float3 CEPNCJBOCEH, out float3 JEGODBLMDBC, out float4 JNILACKDGMB, out float4 ELBPLLDIGKN, out float2 NNKNAENECND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5680FA0", Offset = "0x567FBA0", VA = "0x185680FA0")]
	private int AGGJNOCINLG(int DHOFIJCLKEE, int KDKACDDCLFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56812A0", Offset = "0x567FEA0", VA = "0x1856812A0")]
	private void EDGLNNECJEO(int DHOFIJCLKEE, int KDKACDDCLFM, int FAHBMNPPHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56823A0", Offset = "0x5680FA0", VA = "0x1856823A0")]
	private bool HIELGIOHFDG(int DHOFIJCLKEE, int KDKACDDCLFM, float JKECEGPMCOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x56822E0", Offset = "0x5680EE0", VA = "0x1856822E0")]
	private bool HIADEJIPKDI(int DHOFIJCLKEE, int KDKACDDCLFM, int FAHBMNPPHPO, float JKECEGPMCOP, bool LFNDIANHBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5681DD0", Offset = "0x56809D0", VA = "0x185681DD0")]
	private bool FLOANBHHABG(int DHOFIJCLKEE, int KDKACDDCLFM, int FAHBMNPPHPO, float JKECEGPMCOP, bool LFNDIANHBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5682530", Offset = "0x5681130", VA = "0x185682530")]
	private void LDOOLOKDJLL(int DHOFIJCLKEE, int KDKACDDCLFM, int FAHBMNPPHPO, out int GADCKHKJHKG, out int BLEOFAIJMCD, out int HCLJADIGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56814B0", Offset = "0x56800B0", VA = "0x1856814B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GODNGFCLLCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MJNCKAELPGO : IDisposable, JIGEJGIHOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds ACMFNPPAOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<CMCNBMINKIM> MFLNELLNMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 ADBOFKKGJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 CCKENEMHHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int OFPIFALJIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FFBGKCAFEKO HLNLKCMFAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JNLPHPOAKAD FDAFFGFDAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform KAHCIEGOGHO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int MKLEMOGNEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5692F80", Offset = "0x5691B80", VA = "0x185692F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh IAMFADGAGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh JAOCJHLJDJA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NHCCHGLLPMG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6B9F00", Offset = "0x6B8B00", VA = "0x1806B9F00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6BA2A0", Offset = "0x6B8EA0", VA = "0x1806BA2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte GJEAOBDHMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x772830", Offset = "0x771430", VA = "0x180772830")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x772840", Offset = "0x771440", VA = "0x180772840", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int PCJFGODIKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA7EF80", Offset = "0xA7DB80", VA = "0x180A7EF80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF0D830", Offset = "0xF0C430", VA = "0x180F0D830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int LEPDNCNOPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA7EF70", Offset = "0xA7DB70", VA = "0x180A7EF70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1591F60", Offset = "0x1590B60", VA = "0x181591F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DNJABCILHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5692D30", Offset = "0x5691930", VA = "0x185692D30", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5692D50", Offset = "0x5691950", VA = "0x185692D50")]
		public void KIFAEHBFCNB(GDKHEHMFMDH GDADPCNKOEN, out int OIFKLKLLKIC, out int JFFDENCNMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5692AE0", Offset = "0x56916E0", VA = "0x185692AE0")]
		public void FBCLEIMPELF(GDKHEHMFMDH GDADPCNKOEN, FNMEMNNHHCA LKKFFCFGPLH, int KHGOFDHLFBO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5692540", Offset = "0x5691140", VA = "0x185692540")]
		public void CIHIJDIOIIK(NativeList<FNLEILIENLM> IGJHBBNHMHG, Transform ABGDMLGFOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5692FC0", Offset = "0x5691BC0", VA = "0x185692FC0")]
		public void OPELBEIFCHK(Mesh DNIOKNPDAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5692C90", Offset = "0x5691890", VA = "0x185692C90")]
		public void HFONPLCMKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x56928E0", Offset = "0x56914E0", VA = "0x1856928E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5693060", Offset = "0x5691C60", VA = "0x185693060")]
		public MJNCKAELPGO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds ACMFNPPAOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<MJNCKAELPGO> ECCFOGKAIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public HKKDMNCGKMP HIBPCGJOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer DGIABMCLHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int FDEFACBJOCG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh NEOACDBPILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JHCGODOMOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x733530", Offset = "0x732130", VA = "0x180733530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x92F060", Offset = "0x92DC60", VA = "0x18092F060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LIHEPKADHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x568AA50", Offset = "0x5689650", VA = "0x18568AA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5689C80", Offset = "0x5688880", VA = "0x185689C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5689DE0", Offset = "0x56889E0", VA = "0x185689DE0")]
	public int GBLEDBPKEOH(int ICKLIDLJHAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x568A890", Offset = "0x5689490", VA = "0x18568A890")]
	public void OHKBOFPDEAG(PNKEBPAAKDI GGOFOEENPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x568A0C0", Offset = "0x5688CC0", VA = "0x18568A0C0")]
	public void MIKFCAGEOGF(Transform ABGDMLGFOEG, bool FNFLJPLBMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5689670", Offset = "0x5688270", VA = "0x185689670")]
	public bool DLPMKLMANLD(bool KCDIBCLPHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5689830", Offset = "0x5688430", VA = "0x185689830")]
	public void DPACJIBIIHP(Transform KAHCIEGOGHO, bool FNFLJPLBMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5689E10", Offset = "0x5688A10", VA = "0x185689E10")]
	public bool KFPKFODPJHB(CMCNBMINKIM CNBPNBOALAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x568AAA0", Offset = "0x56896A0", VA = "0x18568AAA0")]
	public GODNGFCLLCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DFHIKAOBHKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<GODNGFCLLCA.MJNCKAELPGO> KHPJNDBNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private KKGGJGMGODH PAJILFIGOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<GODNGFCLLCA.MJNCKAELPGO> GCDHFDEJNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int AAMHDODNJGE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x56845C0", Offset = "0x56831C0", VA = "0x1856845C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5684630", Offset = "0x5683230", VA = "0x185684630")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x56843A0", Offset = "0x5682FA0", VA = "0x1856843A0")]
	public void AABPNGPFBPJ(GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE, Transform KAHCIEGOGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x56846B0", Offset = "0x56832B0", VA = "0x1856846B0")]
	public void KFPKFODPJHB(GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5684460", Offset = "0x5683060", VA = "0x185684460")]
	private GODNGFCLLCA.MJNCKAELPGO BHBLNKKDNMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5684B90", Offset = "0x5683790", VA = "0x185684B90")]
	private bool MIBEABOHFEJ(GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5684C30", Offset = "0x5683830", VA = "0x185684C30")]
	private void NNILPLEDLDC(GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5684590", Offset = "0x5683190", VA = "0x185684590")]
	public bool CDMAMONLAGN(GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x56848A0", Offset = "0x56834A0", VA = "0x1856848A0")]
	public bool KLLCLICJMAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5684B30", Offset = "0x5683730", VA = "0x185684B30")]
	private GODNGFCLLCA.MJNCKAELPGO KNFCAGGNPEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5684C90", Offset = "0x5683890", VA = "0x185684C90")]
	public DFHIKAOBHKG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KAPJBJJDMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JJFPHJAMFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DMELGJBIPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float GOIMGFBEGMO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<GODNGFCLLCA> MEDHDBLMCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x568DE70", Offset = "0x568CA70", VA = "0x18568DE70")]
	public KAPJBJJDMEK(int JJFPHJAMFMO, int DMELGJBIPDA, float FGPBECAEANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x568D860", Offset = "0x568C460", VA = "0x18568D860")]
	public void FAIHBHOMJDD(COHDFPJLBKN EPAKDJENNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x568DBC0", Offset = "0x568C7C0", VA = "0x18568DBC0")]
	private int LMKJONEABGB(PNKEBPAAKDI PABNHBKHCNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x568D980", Offset = "0x568C580", VA = "0x18568D980")]
	private void FAIHBHOMJDD(PNKEBPAAKDI PABNHBKHCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x568DC60", Offset = "0x568C860", VA = "0x18568DC60")]
	private void OOLGJCDPHMJ(PNKEBPAAKDI PABNHBKHCNM, GODNGFCLLCA LCGDPILEPIL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, APLOMLGDHAO
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LCCMPIOAKKO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x712DA0", Offset = "0x7119A0", VA = "0x180712DA0")]
			[DebuggerHidden]
			public LCCMPIOAKKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5690630", Offset = "0x568F230", VA = "0x185690630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x56907E0", Offset = "0x568F3E0", VA = "0x1856907E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5690740", Offset = "0x568F340", VA = "0x185690740", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5690740", Offset = "0x568F340", VA = "0x185690740", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int LIHEPKADHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5684340", Offset = "0x5682F40", VA = "0x185684340", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<JIGEJGIHOPK> AFAMNKKHMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5684320", Offset = "0x5682F20", VA = "0x185684320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> ECCFOGKAIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GODNGFCLLCA NEOACDBPILJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BPMGFIAKIJD GFBIABOLAFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6A4AD0", Offset = "0x6A36D0", VA = "0x1806A4AD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(BPMGFIAKIJD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6A4C30", Offset = "0x6A3830", VA = "0x1806A4C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool KIDFDICGIMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5684330", Offset = "0x5682F30", VA = "0x185684330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5682F00", Offset = "0x5681B00", VA = "0x185682F00")]
		public static ClusterMeshRenderer Create(GODNGFCLLCA DNIOKNPDAGH, ClusterMeshRenderer ADNIOOABGGF, MeshFilter CFOHMKJKLGD, BALPOLLGHCC KAHCIEGOGHO, BPMGFIAKIJD BIGEMEHMIIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x56830A0", Offset = "0x5681CA0", VA = "0x1856830A0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5683860", Offset = "0x5682460", VA = "0x185683860", Slot = "10")]
		public bool TryRemoveClusterLODComponent(CMCNBMINKIM CNBPNBOALAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5683650", Offset = "0x5682250", VA = "0x185683650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x56832F0", Offset = "0x5681EF0", VA = "0x1856832F0")]
		public void Init(GODNGFCLLCA DNIOKNPDAGH, MeshFilter CFOHMKJKLGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5683100", Offset = "0x5681D00", VA = "0x185683100")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5683990", Offset = "0x5682590", VA = "0x185683990", Slot = "8")]
		public void UpdateClusterDistances(Vector3 ENDJGEOLLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5683BA0", Offset = "0x56827A0", VA = "0x185683BA0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5683280", Offset = "0x5681E80", VA = "0x185683280")]
		[IteratorStateMachine(typeof(LCCMPIOAKKO))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x56836D0", Offset = "0x56822D0", VA = "0x1856836D0")]
		public void SetupTagAndLayer(string BGECKNDEKMC, int BIGEMEHMIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56836B0", Offset = "0x56822B0", VA = "0x1856836B0")]
		public bool Remove(CMCNBMINKIM CNBPNBOALAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AMGOLIKFFNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int PNIMCHMCJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int DOEIFPENHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JFFDENCNMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int OIFKLKLLKIC;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5682690", Offset = "0x5681290", VA = "0x185682690")]
	public AMGOLIKFFNH(int DOEIFPENHPA, int JFFDENCNMDG, int PNIMCHMCJOD, int OIFKLKLLKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HKKDMNCGKMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> OJFIELGCCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> LOHJDPBKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> MALHNKJOHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<AMGOLIKFFNH> LONACBPNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> DFGPDDMKIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> EAJKFHDJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> GCMKBGNLJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle HJBACIKDILJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OACPAKOIBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB70230", Offset = "0xB6EE30", VA = "0x180B70230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB70260", Offset = "0xB6EE60", VA = "0x180B70260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x568B130", Offset = "0x5689D30", VA = "0x18568B130")]
	public void OEKJIJPBJKA(FFBGKCAFEKO FFHLKCOGIMC, NativeList<AMGOLIKFFNH> LONACBPNEFB, float CGDLHLIKGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x568AE40", Offset = "0x5689A40", VA = "0x18568AE40")]
	public void HAJNGDFAGIB(Transform KAHCIEGOGHO, bool FNFLJPLBMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x568AB50", Offset = "0x5689750", VA = "0x18568AB50")]
	public void DLPMKLMANLD(GODNGFCLLCA DGIABMCLHLD, bool KCDIBCLPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x568AD00", Offset = "0x5689900", VA = "0x18568AD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x568AE10", Offset = "0x5689A10", VA = "0x18568AE10")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public HKKDMNCGKMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct NMACIFJONGC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> OJFIELGCCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> LOHJDPBKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<AMGOLIKFFNH> AOIDMPJFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> DFGPDDMKIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 HOIBGFPEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> EAJKFHDJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> GCMKBGNLJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool FNFLJPLBMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float DGLOHPLGOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float KGMFHLFJCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float CKKANNPNGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> MALHNKJOHLB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x56935D0", Offset = "0x56921D0", VA = "0x1856935D0")]
	public NMACIFJONGC(HKKDMNCGKMP AKDGMOCNLFL, Vector3 HOIBGFPEDJG, bool FNFLJPLBMCD, float DGLOHPLGOJO, float KGMFHLFJCBO, float CKKANNPNGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5693140", Offset = "0x5691D40", VA = "0x185693140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CMCNBMINKIM : MCJGGHAHMBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds KLNBNDDPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FNLEILIENLM JGDOOODLJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PNKEBPAAKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<CMCNBMINKIM> MFLNELLNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public PNKEBPAAKDI NIGFDFKEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public PNKEBPAAKDI IBONELBIONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public PNKEBPAAKDI LNIAHIIGFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int OIFKLKLLKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds ACMFNPPAOND;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5693E00", Offset = "0x5692A00", VA = "0x185693E00")]
	public PNKEBPAAKDI(List<CMCNBMINKIM> MFLNELLNMCD, [Optional] PNKEBPAAKDI NIGFDFKEKGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class COHDFPJLBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<PNKEBPAAKDI> MEFIHDJLJIE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PNKEBPAAKDI MNGIEAKGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5682CA0", Offset = "0x56818A0", VA = "0x185682CA0")]
	public COHDFPJLBKN(PNKEBPAAKDI KAHCIEGOGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LLLEOLHPAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct EDMJOKENBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int BCDDHABJDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int OFJDKNFBFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OLLGJCAFONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int NFOBEGGIFBN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BFFGCBPCDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int IBGHDFPABKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float LKDPJOHMOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<CMCNBMINKIM> MFLNELLNMCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum FNLEHNKMIML
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
	private EDMJOKENBEI FIGIKEIALBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KHBAPCKJOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JJFPHJAMFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int DMELGJBIPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float FGPBECAEANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float NBPKGFGDJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<PNKEBPAAKDI> NDDNIPKGINF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public COHDFPJLBKN BMBFEMJKMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5692480", Offset = "0x5691080", VA = "0x185692480")]
	public LLLEOLHPAGG(int JJFPHJAMFMO, int DMELGJBIPDA, float FGPBECAEANI, int KHBAPCKJOOI, float NBPKGFGDJPC = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5691E20", Offset = "0x5690A20", VA = "0x185691E20")]
	public void OKAHLOPAGEI(List<CMCNBMINKIM> MFLNELLNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5691520", Offset = "0x5690120", VA = "0x185691520")]
	public bool HEFMNOHMOJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x56914A0", Offset = "0x56900A0", VA = "0x1856914A0")]
	private float GIBMNPKLBMA(Vector3 OMNMFNNFBDJ, Vector3 CCAKNLFDCEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5691450", Offset = "0x5690050", VA = "0x185691450")]
	private float GIBMNPKLBMA(Vector3 PJGFFECCBBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5691590", Offset = "0x5690190", VA = "0x185691590")]
	private bool MEAJKEHMEBL(PNKEBPAAKDI MMMHFPPOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5690820", Offset = "0x568F420", VA = "0x185690820")]
	private BFFGCBPCDMP AEOFPLFOBOL(List<CMCNBMINKIM> KKPIGEBCMLN, FNLEHNKMIML HFEDEIMKMAI)
	{
		return default(BFFGCBPCDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5692020", Offset = "0x5690C20", VA = "0x185692020")]
	private void OLFFPHGNMPP(List<CMCNBMINKIM> MFLNELLNMCD, Vector3[] IGJKKEGDAAD, Vector3[] FLJEIMFNEEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OCLIBCONGAC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5693AA0", Offset = "0x56926A0", VA = "0x185693AA0")]
	public static Bounds ABGHEBKOCNI(List<CMCNBMINKIM> MFLNELLNMCD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5693C50", Offset = "0x5692850", VA = "0x185693C50")]
	public static int HGECHLADHFP(List<CMCNBMINKIM> MFLNELLNMCD, GDKHEHMFMDH GDADPCNKOEN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KKGGJGMGODH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FFBGKCAFEKO JIIIBHJOMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FFBGKCAFEKO CENEKIPABNI;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FFBGKCAFEKO OPGIIAOBAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FAANKJIJKPL MFNPPDJKKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private FNMEMNNHHCA LKKFFCFGPLH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle HJBACIKDILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C90", Offset = "0x6D8890", VA = "0x1806D9C90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6DB550", Offset = "0x6DA150", VA = "0x1806DB550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GODNGFCLLCA.MJNCKAELPGO MMMHFPPOMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BDCNMNMMNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD40", Offset = "0x8CC940", VA = "0x1808CDD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x568DF30", Offset = "0x568CB30", VA = "0x18568DF30")]
	[AKLMCCEMLAH(OAKCDKKFGKB.ExitingPlayMode, 0)]
	private void FACGKCLBPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x568E6D0", Offset = "0x568D2D0", VA = "0x18568E6D0")]
	public void OEKJIJPBJKA(GODNGFCLLCA.MJNCKAELPGO AOIDMPJFJHM, Transform KBGBHNENLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x568DFE0", Offset = "0x568CBE0", VA = "0x18568DFE0")]
	public void LFNLOFFPDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x568DEC0", Offset = "0x568CAC0", VA = "0x18568DEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x568DFA0", Offset = "0x568CBA0", VA = "0x18568DFA0")]
	public void GGNFLDPHLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x568F1D0", Offset = "0x568DDD0", VA = "0x18568F1D0")]
	public KKGGJGMGODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EFBIOLNCONF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FOCKCKKFJOG BPDDCLLCHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OLNCNGNGOOK
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 KKNDLNEJIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FHKMKPJFFLK
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(IFANLHMJJPA ABMHJJFBKGF, CancellationToken OKPCBPJCBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JPPFCFOBGMO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPPFCFOBGMO OJBKMGNJIKN(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPPFCFOBGMO HEJMFGHDIPH(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPPFCFOBGMO CCBOJDBONJI(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPPFCFOBGMO KIDMHBCKCNL(Action MNJNLIAKBME);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class NMEKJGCACJB : JPPFCFOBGMO
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class POMOAKHHOND
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public NMEKJGCACJB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
				public POMOAKHHOND()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5693E80", Offset = "0x5692A80", VA = "0x185693E80")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5693ED0", Offset = "0x5692AD0", VA = "0x185693ED0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5693F20", Offset = "0x5692B20", VA = "0x185693F20")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> AGMFDPHOMAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action DKAMBCJPBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action GBGIAALGPEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private FGNCNPHECFE BAFMPDHPFDP;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action EBBMMAKAHHI
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x766940", Offset = "0x765540", VA = "0x180766940")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action KIAKDCGHHKM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x703160", Offset = "0x701D60", VA = "0x180703160", Slot = "4")]
			public JPPFCFOBGMO OJBKMGNJIKN(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2CD1930", Offset = "0x2CD0530", VA = "0x182CD1930", Slot = "5")]
			public JPPFCFOBGMO HEJMFGHDIPH(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6620", Offset = "0x2DE5220", VA = "0x182DE6620", Slot = "6")]
			public JPPFCFOBGMO CCBOJDBONJI(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B25EB0", Offset = "0x3B24AB0", VA = "0x183B25EB0", Slot = "7")]
			public JPPFCFOBGMO KIDMHBCKCNL(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
			public NMEKJGCACJB(Func<JobHandle> MADIKGBGPDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5693810", Offset = "0x5692410", VA = "0x185693810")]
			public void LDJEMKIKHJD(Action JPKEFPBMOAP, Action HHODKOIPJAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x56936A0", Offset = "0x56922A0", VA = "0x1856936A0")]
			public void KFPKFODPJHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BJHOEMAEDBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JPPFCFOBGMO jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public BJHOEMAEDBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5682C90", Offset = "0x5681890", VA = "0x185682C90")]
			internal bool <Remove>b__0(NMEKJGCACJB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JGFKHHHDOIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public NMEKJGCACJB newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public JGFKHHHDOIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x568C120", Offset = "0x568AD20", VA = "0x18568C120")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<NMEKJGCACJB> LPCGFCBODCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<NMEKJGCACJB> KCDKAKCJELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GMBEEMHKFHH MDGJKOPHKPB;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public LOHLGGGNNDN MBOGPCPHHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B6560", Offset = "0x6B5160", VA = "0x1806B6560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7070C0", Offset = "0x705CC0", VA = "0x1807070C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x568CA80", Offset = "0x568B680", VA = "0x18568CA80")]
		public JPPFCFOBGMO Add(Func<JobHandle> MADIKGBGPDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x568CD80", Offset = "0x568B980", VA = "0x18568CD80")]
		public void Remove(JPPFCFOBGMO HJBACIKDILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x568CBE0", Offset = "0x568B7E0", VA = "0x18568CBE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x568CF50", Offset = "0x568BB50", VA = "0x18568CF50")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x568D1A0", Offset = "0x568BDA0", VA = "0x18568D1A0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x568CBD0", Offset = "0x568B7D0", VA = "0x18568CBD0")]
		[CompilerGenerated]
		private void BLPMJIPBMHN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FGNCNPHECFE
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGNCNPHECFE OJBKMGNJIKN(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGNCNPHECFE FBGOHIPAAJG(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGNCNPHECFE KIDMHBCKCNL(Action MNJNLIAKBME);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class DOJHDDFADLJ : FGNCNPHECFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle JKIJGPJCOOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action DKAMBCJPBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action CBJJMOEEGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action KIAKDCGHHKM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool IGNLNPOLLFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5684F10", Offset = "0x5683B10", VA = "0x185684F10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2CD1930", Offset = "0x2CD0530", VA = "0x182CD1930", Slot = "4")]
			public FGNCNPHECFE OJBKMGNJIKN(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2DE6620", Offset = "0x2DE5220", VA = "0x182DE6620", Slot = "5")]
			public FGNCNPHECFE FBGOHIPAAJG(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3B25EB0", Offset = "0x3B24AB0", VA = "0x183B25EB0", Slot = "6")]
			public FGNCNPHECFE KIDMHBCKCNL(Action MNJNLIAKBME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1362210", Offset = "0x1360E10", VA = "0x181362210")]
			public DOJHDDFADLJ(JobHandle EPBLMBFOJLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5684F60", Offset = "0x5683B60", VA = "0x185684F60")]
			public void OAIJALNIHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5684F20", Offset = "0x5683B20", VA = "0x185684F20")]
			public void KFPKFODPJHB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<DOJHDDFADLJ> OJPDMHDBJKL;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x568D680", Offset = "0x568C280", VA = "0x18568D680")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x568D2A0", Offset = "0x568BEA0", VA = "0x18568D2A0")]
		public FGNCNPHECFE Add(JobHandle EPBLMBFOJLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x568D590", Offset = "0x568C190", VA = "0x18568D590")]
		public void Remove(FGNCNPHECFE HJBACIKDILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x568D420", Offset = "0x568C020", VA = "0x18568D420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x568D330", Offset = "0x568BF30", VA = "0x18568D330")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x568D7A0", Offset = "0x568C3A0", VA = "0x18568D7A0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x568C180", Offset = "0x568AD80", VA = "0x18568C180")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x568C290", Offset = "0x568AE90", VA = "0x18568C290")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
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
