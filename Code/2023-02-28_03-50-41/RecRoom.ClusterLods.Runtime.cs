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
				[Cpp2IlInjected.Address(RVA = "0x5941450", Offset = "0x593FE50", VA = "0x185941450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1F7E880", Offset = "0x1F7D280", VA = "0x181F7E880")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5941410", Offset = "0x593FE10", VA = "0x185941410")]
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
		[Cpp2IlInjected.Address(RVA = "0x5939360", Offset = "0x5937D60", VA = "0x185939360")]
		public LODSettings LGEANNPAMDE(NLKDANNNGOD KGLBJJDFAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5939340", Offset = "0x5937D40", VA = "0x185939340")]
		public int CECPPJDLGHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5939370", Offset = "0x5937D70", VA = "0x185939370")]
		public int LMJDHKPAFBM(bool EJPCMJDFFCB, Vector3 LIMPIHDAEGE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5939470", Offset = "0x5937E70", VA = "0x185939470")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OLKLOPDINEP
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
public interface GMAIFHOGFCG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJJNCBJPLFF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CAEDLJBDAFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FDCDPKLOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BHAINBDOJGO> DAGLPDAJCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OLKLOPDINEP PCFMIHKPMMO
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
	void UpdateClusterDistances(Vector3 LGGBCCHKBJD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(FGBFMJCGKFM DCIOCIFFEAC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BHAINBDOJGO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HHBAIOEJPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int AFDMHCFBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NKNFODJGFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MMDBPHAEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte BNAAGNAJNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CGIICPNPJDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ICCEJJOJOMI
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
	private struct ODIAHFPPGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CGIICPNPJDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PPKCEHBLCJE <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5942C30", Offset = "0x5941630", VA = "0x185942C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EJEKLLJIMEK : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CGIICPNPJDA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public EJEKLLJIMEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x593B640", Offset = "0x593A040", VA = "0x18593B640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x593B700", Offset = "0x593A100", VA = "0x18593B700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HKOJGLDBGLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CGIICPNPJDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PPKCEHBLCJE worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private PPKCEHBLCJE <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x593CE30", Offset = "0x593B830", VA = "0x18593CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MHEEIEIFGEF : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CGIICPNPJDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public MHEEIEIFGEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5941680", Offset = "0x5940080", VA = "0x185941680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5942530", Offset = "0x5940F30", VA = "0x185942530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int JBNMPLJNBPC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan HBEOBAFIBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer IOHKIEPPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LGECILHBFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject EKNBAAFOFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CGNAPOCJJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public ABHIDFBKJGO DBKBANOLFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<FGBFMJCGKFM> BDGCKJPEKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<FGBFMJCGKFM> EEKHJEELDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<FGBFMJCGKFM> LPGFNAHEBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int AMLCNOHDFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ICCEJJOJOMI DKAAJJHGMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CAEDLJBDAFJ>[] BEAGGGHKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BHAINBDOJGO>[] BBLNDJNFOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource DEEMKMNKOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool FPIIABJKMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private KLOMPNKHCCP OEKINDOKAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KLOMPNKHCCP HJPDAJJIGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int PPKGJPHBGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PAIGJKHCPGP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static CGIICPNPJDA KGKJDNBEODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BNFHJPIENMG DIPFLJEOEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NIGOGMNEFOM BFHFEMMLHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour LEPDFJDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material OIBPNBEEPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<GMAIFHOGFCG> NNPGINMIAKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig LECEEKMMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DMLAAHNPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1924B50", Offset = "0x1923550", VA = "0x181924B50")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1924A80", Offset = "0x1923480", VA = "0x181924A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private ICCEJJOJOMI MECMMGDBFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x816660", Offset = "0x815060", VA = "0x180816660")]
		get
		{
			return default(ICCEJJOJOMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5936650", Offset = "0x5935050", VA = "0x185936650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CGIICPNPJDA FMAHKEPPCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x59365F0", Offset = "0x5934FF0", VA = "0x1859365F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool EONCIFPNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x59372B0", Offset = "0x5935CB0", VA = "0x1859372B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CEBCIJBHEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5935310", Offset = "0x5933D10", VA = "0x185935310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> DPNIKBGJCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5935990", Offset = "0x5934390", VA = "0x185935990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5936780", Offset = "0x5935180", VA = "0x185936780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AOJBMKHENMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5934F60", Offset = "0x5933960", VA = "0x185934F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5934DE0", Offset = "0x59337E0", VA = "0x185934DE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x59376F0", Offset = "0x59360F0", VA = "0x1859376F0")]
	public CGIICPNPJDA(BNFHJPIENMG DIPFLJEOEBO, NIGOGMNEFOM BFHFEMMLHPC, ClusterLODConfig HIHBGAHCKJG, MonoBehaviour LEPDFJDNFPF, Material OIBPNBEEPEI, ClusterMeshRenderer IOHKIEPPJJJ, MeshFilter LGECILHBFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5935210", Offset = "0x5933C10", VA = "0x185935210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5935CD0", Offset = "0x59346D0", VA = "0x185935CD0")]
	public static void GLEHOLLDNAH(Vector3 CNEBCPLBJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5935E40", Offset = "0x5934840", VA = "0x185935E40")]
	private void HKLDOCKPJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5935B70", Offset = "0x5934570", VA = "0x185935B70")]
	private void FMCODEPEFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x59364A0", Offset = "0x5934EA0", VA = "0x1859364A0")]
	private void IIBFPMDFHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x59353F0", Offset = "0x5933DF0", VA = "0x1859353F0")]
	public void FAFMHNIIBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5935A30", Offset = "0x5934430", VA = "0x185935A30")]
	[AsyncStateMachine(typeof(ODIAHFPPGLI))]
	public Task FFIBHMHJBMC(PPKCEHBLCJE IFNGEGAGDGH, CancellationToken HLIGFMLOMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x59351A0", Offset = "0x5933BA0", VA = "0x1859351A0")]
	[IteratorStateMachine(typeof(EJEKLLJIMEK))]
	private IEnumerator<MJOGGKCIPED> DPOKIDFNCKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5936360", Offset = "0x5934D60", VA = "0x185936360")]
	[AsyncStateMachine(typeof(HKOJGLDBGLP))]
	private Task IHMEHFAGOHA(PPKCEHBLCJE BPLJLOPHEKL, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5935ED0", Offset = "0x59348D0", VA = "0x185935ED0")]
	public void HMCGIICBKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x59369A0", Offset = "0x59353A0", VA = "0x1859369A0")]
	public void KNOFNMPDHNL(IEnumerable<CAEDLJBDAFJ> LJOMHIJJJDN, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59360E0", Offset = "0x5934AE0", VA = "0x1859360E0")]
	public void HPDEKKMFCDK(IEnumerable<CAEDLJBDAFJ> LJOMHIJJJDN, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5936C00", Offset = "0x5935600", VA = "0x185936C00")]
	public List<ClusterMeshRenderer> MOLFHHNEPKP(List<FGBFMJCGKFM> LODPHDEIJJI, CKMHCCNBJAM OFMDHDILEHM, OLKLOPDINEP ICKIKFECOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5935E00", Offset = "0x5934800", VA = "0x185935E00")]
	public OLKLOPDINEP HIMONDFJDJP(Vector3 LDCCAAMDKJE)
	{
		return default(OLKLOPDINEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x59373D0", Offset = "0x5935DD0", VA = "0x1859373D0")]
	public void NKKPGKHLKND(GMAIFHOGFCG IKJMLLCFFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5934E80", Offset = "0x5933880", VA = "0x185934E80")]
	public bool BEEHDMOHDHI(GMAIFHOGFCG IKJMLLCFFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5935C70", Offset = "0x5934670", VA = "0x185935C70")]
	public void FNAIDLKGOIM(FGBFMJCGKFM KCJLAEDOBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5934EE0", Offset = "0x59338E0", VA = "0x185934EE0")]
	public void BFBIKICHKJP(BHAINBDOJGO BKNGKBHJGHC, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5936B80", Offset = "0x5935580", VA = "0x185936B80")]
	public void LGHPABNJFJD(BHAINBDOJGO BKNGKBHJGHC, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5936A20", Offset = "0x5935420", VA = "0x185936A20")]
	private void LEKNHDDODEA(Vector3 LGGBCCHKBJD, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5935040", Offset = "0x5933A40", VA = "0x185935040")]
	private void DNCENKBNNHG(Vector3 LGGBCCHKBJD, OLKLOPDINEP ICKIKFECOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5937610", Offset = "0x5936010", VA = "0x185937610")]
	[IteratorStateMachine(typeof(MHEEIEIFGEF))]
	private IEnumerator<MJOGGKCIPED> PFKOOGEINKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5936820", Offset = "0x5935220", VA = "0x185936820")]
	private int KMPCIJMJDLF(int GFDMFLGCBKB, int GMLPPMOAFKE, List<BHAINBDOJGO> NDKMJLHEGOH, byte KGLBJJDFAOB, ref int KIBDIDNFLIP, float LDHKGEDBLGP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5937430", Offset = "0x5935E30", VA = "0x185937430")]
	public void OLCIACFECIH(FGBFMJCGKFM DCIOCIFFEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5935950", Offset = "0x5934350", VA = "0x185935950")]
	public bool FDDHHLODGLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7797A0", Offset = "0x7781A0", VA = "0x1807797A0")]
	public Material PNMDMCGBOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5935000", Offset = "0x5933A00", VA = "0x185935000")]
	public int CECPPJDLGHI()
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
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KGAJNOEEKFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> JIMAKJHANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> IJAIPNPBKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> HMCJIPFGLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> LGHADMPAGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> BDLIMNBOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> IMCOAJBLBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> IBGOPFIJFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 DKPKGDPJPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float GGCGMJKKFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> JGEFNIPHGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> JIHILDFIDKP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5941080", Offset = "0x593FA80", VA = "0x185941080")]
	public KGAJNOEEKFM(APEFKKOHFNF ADOLPJCBALB, NativeList<float3> IBGOPFIJFOG, NativeMultiHashMap<int, int> JGEFNIPHGKG, NativeArray<int> JIHILDFIDKP, Vector3 DKPKGDPJPGG, float GGCGMJKKFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5941050", Offset = "0x593FA50", VA = "0x185941050")]
	private int GCILKJDKKMD(float3 LGGBCCHKBJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x59409C0", Offset = "0x593F3C0", VA = "0x1859409C0")]
	private int BDEFMMLFJIN(int ALJNHCKDPKB, int AJPNMLHDHNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5940C20", Offset = "0x593F620", VA = "0x185940C20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LKNFEJAFGLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> JGEFNIPHGKG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> JIHILDFIDKP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int NMKDCBFHJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> HFHLHPKKLFK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5941140", Offset = "0x593FB40", VA = "0x185941140")]
	public void BJCIHBOCACE(int DCFFGHBFECJ, Allocator GGPAKDMJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5941330", Offset = "0x593FD30", VA = "0x185941330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LKNFEJAFGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct OKCCMOGKCAM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> LCEAGBCCDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> LOAHJCDGFPC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x59432B0", Offset = "0x5941CB0", VA = "0x1859432B0")]
	public OKCCMOGKCAM(LKNFEJAFGLK FECECGBIDEH, APEFKKOHFNF ADOLPJCBALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5943210", Offset = "0x5941C10", VA = "0x185943210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EKIDKPCKHLF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> FAPKLPCGNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> GAIOBALAJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> AEABJEMAOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> KFNIACCDJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> OIGMCIBPBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> HFHLHPKKLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> LCEAGBCCDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> CIICNFEMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> IIEMFEFDLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> JJIAJGMKPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> NLKKBGEBGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> JJGMGHEIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> MAOBEIPNCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float GNCILFBKOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float GIECJCOEFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 NFFAGBMOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float BPDLLCKBGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float LCPKPHFOIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float OEPBPFIFMKK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x593CCF0", Offset = "0x593B6F0", VA = "0x18593CCF0")]
	public EKIDKPCKHLF(LKNFEJAFGLK FBPPGNLICOF, APEFKKOHFNF ADOLPJCBALB, APEFKKOHFNF DMJCCPAHLIL, float LCPKPHFOIEF, float OEPBPFIFMKK, Vector3 NFFAGBMOFIK, float BPDLLCKBGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x593B950", Offset = "0x593A350", VA = "0x18593B950")]
	private float3 DPLCNJEPKMK(int ALJNHCKDPKB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x593BA00", Offset = "0x593A400", VA = "0x18593BA00")]
	private void ENADHFOFOBD(int ALJNHCKDPKB, out float3 AILGMFCGBKB, out float3 KDOAAKPEPJE, out float4 GMKBIEIDMCF, out float4 ODGFNBIGBCD, out float2 IAFBHMDNHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x593C510", Offset = "0x593AF10", VA = "0x18593C510")]
	private int LKBODGNAJKA(int BNGDPCIIMMO, int MCKOIDODABB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x593B740", Offset = "0x593A140", VA = "0x18593B740")]
	private void AFOGDENIMEI(int BNGDPCIIMMO, int MCKOIDODABB, int PCJKDCCMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x593CAA0", Offset = "0x593B4A0", VA = "0x18593CAA0")]
	private bool PBOMIEJJEHO(int BNGDPCIIMMO, int MCKOIDODABB, float IJCCIHKMFKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x593CC30", Offset = "0x593B630", VA = "0x18593CC30")]
	private bool PGBPOFGAGCC(int BNGDPCIIMMO, int MCKOIDODABB, int PCJKDCCMBMJ, float IJCCIHKMFKO, bool ACDKGJLCOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x593C830", Offset = "0x593B230", VA = "0x18593C830")]
	private bool NPJBPJLJMGD(int BNGDPCIIMMO, int MCKOIDODABB, int PCJKDCCMBMJ, float IJCCIHKMFKO, bool ACDKGJLCOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x593C810", Offset = "0x593B210", VA = "0x18593C810")]
	private void MEMCJMJNPIP(int BNGDPCIIMMO, int MCKOIDODABB, int PCJKDCCMBMJ, out int CJNKANOAGHF, out int BGPNGMAHILC, out int AAMGHKCCALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x593BBF0", Offset = "0x593A5F0", VA = "0x18593BBF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ALEOPBPFCAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class EEBDGHEPCCI : IDisposable, BHAINBDOJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds NFOBGIKPBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<FGBFMJCGKFM> LODPHDEIJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 FJMMOELDLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 LKCLKGPEAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int GJBINFFFOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public APEFKKOHFNF PMAGFBMAICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public LKNFEJAFGLK CPKLNHJNEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform OFMDHDILEHM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int JGPHGPOLHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x593B450", Offset = "0x5939E50", VA = "0x18593B450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh DACIGMDOOCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh MMENNEGJAAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NKNFODJGFAN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x11DE620", Offset = "0x11DD020", VA = "0x1811DE620", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2ED1200", Offset = "0x2ECFC00", VA = "0x182ED1200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte BNAAGNAJNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x12E7210", Offset = "0x12E5C10", VA = "0x1812E7210", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HHBAIOEJPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA1F1C0", Offset = "0xA1DBC0", VA = "0x180A1F1C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1F1D0", Offset = "0xA1DBD0", VA = "0x180A1F1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int AFDMHCFBEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBEEA60", Offset = "0xBED460", VA = "0x180BEEA60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE22320", Offset = "0xE20D20", VA = "0x180E22320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MMDBPHAEMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x593A970", Offset = "0x5939370", VA = "0x18593A970", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x593AB90", Offset = "0x5939590", VA = "0x18593AB90")]
		public void ECGOGPMEOIN(NLKDANNNGOD KGLBJJDFAOB, out int HIHEAFOKHPJ, out int NGIBKGCAEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x593AE60", Offset = "0x5939860", VA = "0x18593AE60")]
		public void FDMPLBAHBGA(NLKDANNNGOD KGLBJJDFAOB, IAENMLENEKB FEAHDOMPHEC, int NDODMOLMECN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x593B010", Offset = "0x5939A10", VA = "0x18593B010")]
		public void MEGFOGJEAEE(NativeList<LDNMMNGAIFL> PLOPJMDHLFH, Transform JEODGDOLBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x593ADC0", Offset = "0x59397C0", VA = "0x18593ADC0")]
		public void EHCPLAPHLMG(Mesh ADOLPJCBALB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x593B3B0", Offset = "0x5939DB0", VA = "0x18593B3B0")]
		public void OHBNHLOOAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x593A990", Offset = "0x5939390", VA = "0x18593A990", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x593B490", Offset = "0x5939E90", VA = "0x18593B490")]
		public EEBDGHEPCCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds NFOBGIKPBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<EEBDGHEPCCI> FHNHHCDMJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public CJIJFJFDHPN HFFMNLBDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer IGMAFPJOAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int OAHPGCJGAMD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh BGNHMDFBFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IEDDDDNHMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B870", Offset = "0xA2A270", VA = "0x180A2B870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FDCDPKLOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x59321F0", Offset = "0x5930BF0", VA = "0x1859321F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5932430", Offset = "0x5930E30", VA = "0x185932430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5932240", Offset = "0x5930C40", VA = "0x185932240")]
	public int CMEEFFDLJOO(int FBFALGLPFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5932270", Offset = "0x5930C70", VA = "0x185932270")]
	public void DACNEIELNFN(BKMBKNMJAIL IMNLEEDDJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5931A20", Offset = "0x5930420", VA = "0x185931A20")]
	public void BKOANLADMBE(Transform JEODGDOLBOD, bool GOOJNDAHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5932590", Offset = "0x5930F90", VA = "0x185932590")]
	public bool JEOACNCJAAP(bool PCFJKCPAFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x59315D0", Offset = "0x592FFD0", VA = "0x1859315D0")]
	public void BBPEAEGJGBO(Transform OFMDHDILEHM, bool GOOJNDAHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5932750", Offset = "0x5931150", VA = "0x185932750")]
	public bool OLCIACFECIH(FGBFMJCGKFM DCIOCIFFEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5932A00", Offset = "0x5931400", VA = "0x185932A00")]
	public ALEOPBPFCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ABHIDFBKJGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<ALEOPBPFCAO.EEBDGHEPCCI> EJAAFPLHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private KFJCCMICHIO KEHHLEOHFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<ALEOPBPFCAO.EEBDGHEPCCI> ABABCGMOJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JJJDHMDCMLI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5930DD0", Offset = "0x592F7D0", VA = "0x185930DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5931100", Offset = "0x592FB00", VA = "0x185931100")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5930D10", Offset = "0x592F710", VA = "0x185930D10")]
	public void CPLOAHMOJFD(ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL, Transform OFMDHDILEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5931180", Offset = "0x592FB80", VA = "0x185931180")]
	public void OLCIACFECIH(ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5930EA0", Offset = "0x592F8A0", VA = "0x185930EA0")]
	private ALEOPBPFCAO.EEBDGHEPCCI HBGLPPDGLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5930FD0", Offset = "0x592F9D0", VA = "0x185930FD0")]
	private bool JJIDIHFMFKD(ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x59310A0", Offset = "0x592FAA0", VA = "0x1859310A0")]
	private void MLDENMDPEFG(ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5931070", Offset = "0x592FA70", VA = "0x185931070")]
	public bool LHKNKJOECFA(ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5930A80", Offset = "0x592F480", VA = "0x185930A80")]
	public bool BBFMMOJDOFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5930E40", Offset = "0x592F840", VA = "0x185930E40")]
	private ALEOPBPFCAO.EEBDGHEPCCI FDDAOCONGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5931370", Offset = "0x592FD70", VA = "0x185931370")]
	public ABHIDFBKJGO()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NGPGFDKFKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int GHPNJLBEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int HBPLJDCEJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float EFOBOLCFGHL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<ALEOPBPFCAO> BOKNJAGLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5942BE0", Offset = "0x59415E0", VA = "0x185942BE0")]
	public NGPGFDKFKLA(int GHPNJLBEBME, int HBPLJDCEJGK, float GJCPCCGDHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5942670", Offset = "0x5941070", VA = "0x185942670")]
	public void LMNMPEGBPIL(EGODCNFBMCM JAJHPFNDCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x59425D0", Offset = "0x5940FD0", VA = "0x1859425D0")]
	private int BNCOIMMHHKE(BKMBKNMJAIL MMAGBLNBOEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5942790", Offset = "0x5941190", VA = "0x185942790")]
	private void LMNMPEGBPIL(BKMBKNMJAIL MMAGBLNBOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x59429D0", Offset = "0x59413D0", VA = "0x1859429D0")]
	private void LOAOMPHJBII(BKMBKNMJAIL MMAGBLNBOEG, ALEOPBPFCAO JEDDMJAGCLG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CAEDLJBDAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MGNIMOHKFAK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public MGNIMOHKFAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5941490", Offset = "0x593FE90", VA = "0x185941490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5941640", Offset = "0x5940040", VA = "0x185941640", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x59415A0", Offset = "0x593FFA0", VA = "0x1859415A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x59415A0", Offset = "0x593FFA0", VA = "0x1859415A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FDCDPKLOKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x593A910", Offset = "0x5939310", VA = "0x18593A910", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<BHAINBDOJGO> DAGLPDAJCKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x593A8F0", Offset = "0x59392F0", VA = "0x18593A8F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> FHNHHCDMJCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ALEOPBPFCAO BGNHMDFBFCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OLKLOPDINEP PCFMIHKPMMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6E31B0", Offset = "0x6E1BB0", VA = "0x1806E31B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(OLKLOPDINEP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA04B40", Offset = "0xA03540", VA = "0x180A04B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BGDEBNDMNBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x593A900", Offset = "0x5939300", VA = "0x18593A900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x59394D0", Offset = "0x5937ED0", VA = "0x1859394D0")]
		public static ClusterMeshRenderer Create(ALEOPBPFCAO ADOLPJCBALB, ClusterMeshRenderer IOHKIEPPJJJ, MeshFilter LGECILHBFFE, CKMHCCNBJAM OFMDHDILEHM, OLKLOPDINEP ICKIKFECOGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5939670", Offset = "0x5938070", VA = "0x185939670", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5939E30", Offset = "0x5938830", VA = "0x185939E30", Slot = "10")]
		public bool TryRemoveClusterLODComponent(FGBFMJCGKFM DCIOCIFFEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5939C20", Offset = "0x5938620", VA = "0x185939C20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x59398C0", Offset = "0x59382C0", VA = "0x1859398C0")]
		public void Init(ALEOPBPFCAO ADOLPJCBALB, MeshFilter LGECILHBFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x59396D0", Offset = "0x59380D0", VA = "0x1859396D0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5939F60", Offset = "0x5938960", VA = "0x185939F60", Slot = "8")]
		public void UpdateClusterDistances(Vector3 LGGBCCHKBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x593A170", Offset = "0x5938B70", VA = "0x18593A170", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5939850", Offset = "0x5938250", VA = "0x185939850")]
		[IteratorStateMachine(typeof(MGNIMOHKFAK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5939CA0", Offset = "0x59386A0", VA = "0x185939CA0")]
		public void SetupTagAndLayer(string EKEDPKMICKJ, int ICKIKFECOGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5939C80", Offset = "0x5938680", VA = "0x185939C80")]
		public bool Remove(FGBFMJCGKFM DCIOCIFFEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LOEOFIMCELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int IEKGCKOJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int FHINICACAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NGIBKGCAEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HIHEAFOKHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5941470", Offset = "0x593FE70", VA = "0x185941470")]
	public LOEOFIMCELL(int FHINICACAAN, int NGIBKGCAEKI, int IEKGCKOJIML, int HIHEAFOKHPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CJIJFJFDHPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> JIMAKJHANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> HFHLHPKKLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> IMCOAJBLBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<LOEOFIMCELL> KHEIMOEOLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> JIOFDOOHJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> NOEFAMDBCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> DINPANBKMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle NNGFCFNIJKL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MDKBHHJGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBAA280", Offset = "0xBA8C80", VA = "0x180BAA280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xBAA820", Offset = "0xBA9220", VA = "0x180BAA820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5937F50", Offset = "0x5936950", VA = "0x185937F50")]
	public void HAKOKLHEDIO(APEFKKOHFNF DMNONNMDNDI, NativeList<LOEOFIMCELL> KHEIMOEOLED, float HKGHFAPJIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5939020", Offset = "0x5937A20", VA = "0x185939020")]
	public void MMBFPAMNHNG(Transform OFMDHDILEHM, bool GOOJNDAHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5938E70", Offset = "0x5937870", VA = "0x185938E70")]
	public void JEOACNCJAAP(ALEOPBPFCAO IGMAFPJOAIE, bool PCFJKCPAFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5937E40", Offset = "0x5936840", VA = "0x185937E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5939310", Offset = "0x5937D10", VA = "0x185939310")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public CJIJFJFDHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CDAAABFILDA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> JIMAKJHANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> HFHLHPKKLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<LOEOFIMCELL> DPONIPCOJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> JIOFDOOHJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 NFFAGBMOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> NOEFAMDBCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> DINPANBKMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool GOOJNDAHODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float LLHNEFCCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float ALJKBKFDJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float LNBKHEEKLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> IMCOAJBLBJG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5934D10", Offset = "0x5933710", VA = "0x185934D10")]
	public CDAAABFILDA(CJIJFJFDHPN MAKNNDOILNI, Vector3 NFFAGBMOFIK, bool GOOJNDAHODC, float LLHNEFCCIJN, float ALJKBKFDJCL, float LNBKHEEKLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5934880", Offset = "0x5933280", VA = "0x185934880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FGBFMJCGKFM : DLKKBAOBHIN
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds DAMGLCDOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LDNMMNGAIFL OJIDDGMGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BKMBKNMJAIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<FGBFMJCGKFM> LODPHDEIJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public BKMBKNMJAIL ELGBIOMPEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public BKMBKNMJAIL LMJLMHJLGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public BKMBKNMJAIL PFKAPEEAKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HIHEAFOKHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds NFOBGIKPBLF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5932AB0", Offset = "0x59314B0", VA = "0x185932AB0")]
	public BKMBKNMJAIL(List<FGBFMJCGKFM> LODPHDEIJJI, [Optional] BKMBKNMJAIL ELGBIOMPEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EGODCNFBMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<BKMBKNMJAIL> FGPNNGIMDGG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public BKMBKNMJAIL PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x593B570", Offset = "0x5939F70", VA = "0x18593B570")]
	public EGODCNFBMCM(BKMBKNMJAIL OFMDHDILEHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BNNOFJHKEKP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct HBHIDLGPKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int KLFIFLAOBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int DKHGHHIALOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int FKGAIDFOJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int LPAKCGCKBPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct IFMGLEOAAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OGBOMOENKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float EJMANFGOECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<FGBFMJCGKFM> LODPHDEIJJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum BBFLKGMACID
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
	private HBHIDLGPKEM JLHBFMDFGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DJEADAJFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int GHPNJLBEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int HBPLJDCEJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GJCPCCGDHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float GGGFLKKFKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<BKMBKNMJAIL> HPFFFBLHEOL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EGODCNFBMCM EMGKPKHDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5934820", Offset = "0x5933220", VA = "0x185934820")]
	public BNNOFJHKEKP(int GHPNJLBEBME, int HBPLJDCEJGK, float GJCPCCGDHAG, int DJEADAJFEGI, float GGGFLKKFKIM = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5934620", Offset = "0x5933020", VA = "0x185934620")]
	public void PKGDDFHDDHN(List<FGBFMJCGKFM> LODPHDEIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x59337F0", Offset = "0x59321F0", VA = "0x1859337F0")]
	public bool EACIOFOBJMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5934140", Offset = "0x5932B40", VA = "0x185934140")]
	private float NEKFDNJDILO(Vector3 MMCAICBMAII, Vector3 OPOPHNBOOKJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x59340F0", Offset = "0x5932AF0", VA = "0x1859340F0")]
	private float NEKFDNJDILO(Vector3 HGBOOPNCHBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5933860", Offset = "0x5932260", VA = "0x185933860")]
	private bool JOEJPBHHNBD(BKMBKNMJAIL FGPCCEGNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5932BC0", Offset = "0x59315C0", VA = "0x185932BC0")]
	private IFMGLEOAAMC CKBPBOKGNKH(List<FGBFMJCGKFM> NENEHMHCLJK, BBFLKGMACID ODEGNMLFMJC)
	{
		return default(IFMGLEOAAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x59341C0", Offset = "0x5932BC0", VA = "0x1859341C0")]
	private void OOBJFFNDHLB(List<FGBFMJCGKFM> LODPHDEIJJI, Vector3[] JPKAPNNIGGC, Vector3[] JDMJMGKMDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class PLLCMFGEKHO
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x59436E0", Offset = "0x59420E0", VA = "0x1859436E0")]
	public static Bounds ADOIOMGOBIN(List<FGBFMJCGKFM> LODPHDEIJJI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5943890", Offset = "0x5942290", VA = "0x185943890")]
	public static int HMFDDKEPLBE(List<FGBFMJCGKFM> LODPHDEIJJI, NLKDANNNGOD KGLBJJDFAOB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KFJCCMICHIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private APEFKKOHFNF GNFLOKJCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private APEFKKOHFNF PCFOBDCHJNP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static APEFKKOHFNF IJODJKCMPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private EINDOMHPEOO BNHAFCBKGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private IAENMLENEKB FEAHDOMPHEC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle NNGFCFNIJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCD4250", Offset = "0xCD2C50", VA = "0x180CD4250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ALEOPBPFCAO.EEBDGHEPCCI FGPCCEGNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KDENEONFIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x759580", Offset = "0x757F80", VA = "0x180759580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x593FD00", Offset = "0x593E700", VA = "0x18593FD00")]
	[KCBPKDKAKIN(AJCDLBPHHHC.ExitingPlayMode, 0)]
	private static void AJJFHGPOHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x593FDE0", Offset = "0x593E7E0", VA = "0x18593FDE0")]
	public void HAKOKLHEDIO(ALEOPBPFCAO.EEBDGHEPCCI DPONIPCOJBP, Transform FMJFMKBDFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x593F610", Offset = "0x593E010", VA = "0x18593F610")]
	public void AGFJCNBJAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x593FD70", Offset = "0x593E770", VA = "0x18593FD70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x59408E0", Offset = "0x593F2E0", VA = "0x1859408E0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5940920", Offset = "0x593F320", VA = "0x185940920")]
	public KFJCCMICHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BHNPPGCAIKD
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CGIICPNPJDA NJDBJBAMADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NIGOGMNEFOM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 LBHNABMDDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BNFHJPIENMG
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(PPKCEHBLCJE BPLJLOPHEKL, CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ICHAPIOFHKI
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICHAPIOFHKI BDLGCODGGCF(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICHAPIOFHKI GGDPLPCOGAE(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICHAPIOFHKI OGCJDHAFAPL(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ICHAPIOFHKI LIFPGMCKFON(Action CKAPOBIDCEI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class PLAPFONIBEA : ICHAPIOFHKI
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class ABIIGDNOJCG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public PLAPFONIBEA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public ABIIGDNOJCG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x59314F0", Offset = "0x592FEF0", VA = "0x1859314F0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5931540", Offset = "0x592FF40", VA = "0x185931540")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5931590", Offset = "0x592FF90", VA = "0x185931590")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> OAKMNCEIGGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action MAJKAECDKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action CDELLEDIJJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private BMMBIDKDLLE ANAKCFEGFBB;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action GLPMIGDOLJF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action FIKLMNPLGLM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x313A1E0", Offset = "0x3138BE0", VA = "0x18313A1E0", Slot = "4")]
			public ICHAPIOFHKI BDLGCODGGCF(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x26828E0", Offset = "0x26812E0", VA = "0x1826828E0", Slot = "5")]
			public ICHAPIOFHKI GGDPLPCOGAE(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2682900", Offset = "0x2681300", VA = "0x182682900", Slot = "6")]
			public ICHAPIOFHKI OGCJDHAFAPL(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3888D30", Offset = "0x3887730", VA = "0x183888D30", Slot = "7")]
			public ICHAPIOFHKI LIFPGMCKFON(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
			public PLAPFONIBEA(Func<JobHandle> LICCMJPMLIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x59432E0", Offset = "0x5941CE0", VA = "0x1859432E0")]
			public void HHNJFAHFJBP(Action FGFMNAJNLDC, Action IGPDIGEJAMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5943570", Offset = "0x5941F70", VA = "0x185943570")]
			public void OLCIACFECIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class IGPLOGJAPAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public ICHAPIOFHKI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public IGPLOGJAPAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x593E1F0", Offset = "0x593CBF0", VA = "0x18593E1F0")]
			internal bool <Remove>b__0(PLAPFONIBEA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class NFBDBMBOOOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public PLAPFONIBEA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public NFBDBMBOOOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5942570", Offset = "0x5940F70", VA = "0x185942570")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<PLAPFONIBEA> EAKHHCCAINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<PLAPFONIBEA> OILGMMFGPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private KLOMPNKHCCP GGEBALPHFEO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AGPBJHJFDJC OOMNLKGJAHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x593E200", Offset = "0x593CC00", VA = "0x18593E200")]
		public ICHAPIOFHKI Add(Func<JobHandle> LICCMJPMLIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x593E500", Offset = "0x593CF00", VA = "0x18593E500")]
		public void Remove(ICHAPIOFHKI NNGFCFNIJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x593E360", Offset = "0x593CD60", VA = "0x18593E360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x593E6D0", Offset = "0x593D0D0", VA = "0x18593E6D0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x593E920", Offset = "0x593D320", VA = "0x18593E920")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x593E350", Offset = "0x593CD50", VA = "0x18593E350")]
		[CompilerGenerated]
		private void KDMJDMBMIGM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BMMBIDKDLLE
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMMBIDKDLLE BDLGCODGGCF(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMMBIDKDLLE DEFEGHNFLDE(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMMBIDKDLLE LIFPGMCKFON(Action CKAPOBIDCEI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BNBIACLHDGK : BMMBIDKDLLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle DNCMHENLGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action MAJKAECDKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action HGKMGJFEADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action FIKLMNPLGLM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool BHHMGBOFKCK
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5932B30", Offset = "0x5931530", VA = "0x185932B30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x26828E0", Offset = "0x26812E0", VA = "0x1826828E0", Slot = "4")]
			public BMMBIDKDLLE BDLGCODGGCF(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2682900", Offset = "0x2681300", VA = "0x182682900", Slot = "5")]
			public BMMBIDKDLLE DEFEGHNFLDE(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3888D30", Offset = "0x3887730", VA = "0x183888D30", Slot = "6")]
			public BMMBIDKDLLE LIFPGMCKFON(Action CKAPOBIDCEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
			public BNBIACLHDGK(JobHandle PAPECLFKBKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5932B40", Offset = "0x5931540", VA = "0x185932B40")]
			public void MILDGAMNMFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5932B80", Offset = "0x5931580", VA = "0x185932B80")]
			public void OLCIACFECIH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BNBIACLHDGK> PAEOHIEKFFK;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x593EE00", Offset = "0x593D800", VA = "0x18593EE00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x593EA20", Offset = "0x593D420", VA = "0x18593EA20")]
		public BMMBIDKDLLE Add(JobHandle PAPECLFKBKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x593ED10", Offset = "0x593D710", VA = "0x18593ED10")]
		public void Remove(BMMBIDKDLLE NNGFCFNIJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x593EBA0", Offset = "0x593D5A0", VA = "0x18593EBA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x593EAB0", Offset = "0x593D4B0", VA = "0x18593EAB0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x593EF20", Offset = "0x593D920", VA = "0x18593EF20")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x593F330", Offset = "0x593DD30", VA = "0x18593F330")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x593EFE0", Offset = "0x593D9E0", VA = "0x18593EFE0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
