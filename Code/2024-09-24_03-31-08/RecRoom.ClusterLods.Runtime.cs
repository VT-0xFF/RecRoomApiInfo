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
				[Cpp2IlInjected.Address(RVA = "0x6AC9690", Offset = "0x6AC8090", VA = "0x186AC9690")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x183B120", Offset = "0x1839B20", VA = "0x18183B120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9650", Offset = "0x6AC8050", VA = "0x186AC9650")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ABB120", Offset = "0x6AB9B20", VA = "0x186ABB120")]
		public LODSettings KOFNJOCFPPK(BMENCFGGDHJ PDJBKOAOLLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB060", Offset = "0x6AB9A60", VA = "0x186ABB060")]
		public int BNDECCPFKCO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB080", Offset = "0x6AB9A80", VA = "0x186ABB080")]
		public int IHCNJONHALK(bool IBNLAGFCKKM, Vector3 DHJEIIDICAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB130", Offset = "0x6AB9B30", VA = "0x186ABB130")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CGCFKGNKCNB
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
public interface GFIJFEOJDDC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNJBAHAGIIC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LFMBBNNBPGC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OMEIDMDMPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JHBBLHAJILM> DIOGMGKBJMF
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
	void UpdateClusterDistances(Vector3 BJFHPDFPFFI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(AGFEKKBFFCK ANHGADCFANN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JHBBLHAJILM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int MHAJFLPIEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int ABGAOOMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NGAABAANDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CFKJGANPPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte BGNFDILHNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OMOCMPHJCLK
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Control,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LowQualityShadow
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JFMLCAHMCBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum EAIPCFIKADI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BIFBJKJDPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public JFMLCAHMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA860", Offset = "0x6AB9260", VA = "0x186ABA860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAFF0", Offset = "0x6AB99F0", VA = "0x186ABAFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FLJPOFLLDLH : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JFMLCAHMCBC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public FLJPOFLLDLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFEE0", Offset = "0x6ABE8E0", VA = "0x186ABFEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFFF0", Offset = "0x6ABE9F0", VA = "0x186ABFFF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AIILPOCENAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JFMLCAHMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7580", Offset = "0x6AB5F80", VA = "0x186AB7580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8DE0", Offset = "0x6AB77E0", VA = "0x186AB8DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LFKPOJKNAEO : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JFMLCAHMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public LFKPOJKNAEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8910", Offset = "0x6AC7310", VA = "0x186AC8910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9600", Offset = "0x6AC8000", VA = "0x186AC9600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const int GAGHAHBEJKN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly TimeSpan OOOKLDAMPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ClusterMeshRenderer CHBLJEJOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MeshFilter EOELDPPAIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GameObject FOLOKNHGOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject MEOKFAPIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public MPMAKMDGABH FCHOIAOAFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<AGFEKKBFFCK> MDBKPFGBDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<AGFEKKBFFCK> OMMGFDCGLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<AGFEKKBFFCK> EFADGCNJPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int GGOHDJBGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private EAIPCFIKADI GHEKENMGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public List<LFMBBNNBPGC>[] BHNLCJGPNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private List<JHBBLHAJILM>[] BEOMNMJPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CancellationTokenSource IICPMHNLIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool IONOOCKDGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CHBCKIOGPHP LOODMLCDFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private CHBCKIOGPHP GCOFFBGFOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int OMODMEJJINJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static JFMLCAHMCBC KHNFDPNFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly FELLCCMJNFP JHNFABEIHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AFBKJPPAJLG DDNMNOAAMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MonoBehaviour CPHLIIPMGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Material LDOBPCDDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Material LPBJIEFBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material OHNLDIINGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public OMOCMPHJCLK AJLBMDBCBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<GFIJFEOJDDC> IEOLLCJKGAG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig OCJIOBLIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 PLMMMDLKDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x895C90", Offset = "0x894690", VA = "0x180895C90")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x895890", Offset = "0x894290", VA = "0x180895890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EAIPCFIKADI DKPENOGODJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BB850", Offset = "0x9BA250", VA = "0x1809BB850")]
		get
		{
			return default(EAIPCFIKADI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7170", Offset = "0x6AC5B70", VA = "0x186AC7170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static JFMLCAHMCBC GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6970", Offset = "0x6AC5370", VA = "0x186AC6970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool JJLBGBINPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6B90", Offset = "0x6AC5590", VA = "0x186AC6B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PPOOOPODGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5200", Offset = "0x6AC3C00", VA = "0x186AC5200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IPPLIIJBNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6FF0", Offset = "0x6AC59F0", VA = "0x186AC6FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC70B0", Offset = "0x6AC5AB0", VA = "0x186AC70B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PCANGJANIFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5960", Offset = "0x6AC4360", VA = "0x186AC5960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6DC0", Offset = "0x6AC57C0", VA = "0x186AC6DC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7310", Offset = "0x6AC5D10", VA = "0x186AC7310")]
	public JFMLCAHMCBC(FELLCCMJNFP JHNFABEIHAO, AFBKJPPAJLG DDNMNOAAMIA, ClusterLODConfig LBPCKHLKGGL, MonoBehaviour CPHLIIPMGMJ, Material LDOBPCDDKIO, ClusterMeshRenderer CHBLJEJOJIN, MeshFilter EOELDPPAIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5470", Offset = "0x6AC3E70", VA = "0x186AC5470")]
	public void GEHABMAHHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4ED0", Offset = "0x6AC38D0", VA = "0x186AC4ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5AA0", Offset = "0x6AC44A0", VA = "0x186AC5AA0")]
	public static void HNFBNAADCBB(Vector3 EHAHIHEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5A10", Offset = "0x6AC4410", VA = "0x186AC5A10")]
	private void HMLKOLBMJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AC69C0", Offset = "0x6AC53C0", VA = "0x186AC69C0")]
	private void KHIJLPKADKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5F40", Offset = "0x6AC4940", VA = "0x186AC5F40")]
	private void IFKKLBJPPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4600", Offset = "0x6AC3000", VA = "0x186AC4600")]
	public void CBPHBALLBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4C50", Offset = "0x6AC3650", VA = "0x186AC4C50")]
	[AsyncStateMachine(typeof(BIFBJKJDPEP))]
	public Task CPEHOLEPHKB(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6EF0", Offset = "0x6AC58F0", VA = "0x186AC6EF0")]
	[IteratorStateMachine(typeof(FLJPOFLLDLH))]
	private IEnumerator<DKMFPOPNNKA> NKAIHHMPLPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC44A0", Offset = "0x6AC2EA0", VA = "0x186AC44A0")]
	[AsyncStateMachine(typeof(AIILPOCENAK))]
	private Task BCDGFHNBCMJ(GOLFJDFFGLD<string>.EFMHMOBJFGI KCOINANJLGM, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6770", Offset = "0x6AC5170", VA = "0x186AC6770")]
	public void JEFGMNAAPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6B10", Offset = "0x6AC5510", VA = "0x186AC6B10")]
	public void LKCCHHIKFAC(IEnumerable<LFMBBNNBPGC> NEECDGPKLFP, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5600", Offset = "0x6AC4000", VA = "0x186AC5600")]
	public void GKEHLDEOMPC(IEnumerable<LFMBBNNBPGC> NEECDGPKLFP, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6090", Offset = "0x6AC4A90", VA = "0x186AC6090")]
	public List<ClusterMeshRenderer> IOHDMIGCGMB(List<AGFEKKBFFCK> JAPGCHNAGBM, FGHMMAJOCCM BAFHJDFHJHD, CGCFKGNKCNB KPHOHHILDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5900", Offset = "0x6AC4300", VA = "0x186AC5900")]
	public void HDCNGPJAAMJ(GFIJFEOJDDC MOGEEHKENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AC51A0", Offset = "0x6AC3BA0", VA = "0x186AC51A0")]
	public bool FDIJLJIFFON(GFIJFEOJDDC MOGEEHKENMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5140", Offset = "0x6AC3B40", VA = "0x186AC5140")]
	public void EOENAJIMPJK(AGFEKKBFFCK OCKJOFKILLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6A90", Offset = "0x6AC5490", VA = "0x186AC6A90")]
	public void LHIGGKNICCB(JHBBLHAJILM FCCHPKGBOPA, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6E70", Offset = "0x6AC5870", VA = "0x186AC6E70")]
	public void NBAMFJBPBPC(JHBBLHAJILM FCCHPKGBOPA, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6C80", Offset = "0x6AC5680", VA = "0x186AC6C80")]
	private void MMICJCOBJOJ(Vector3 BJFHPDFPFFI, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4D70", Offset = "0x6AC3770", VA = "0x186AC4D70")]
	private void DJPDFJINGJD(Vector3 BJFHPDFPFFI, CGCFKGNKCNB KPHOHHILDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6F70", Offset = "0x6AC5970", VA = "0x186AC6F70")]
	[IteratorStateMachine(typeof(LFKPOJKNAEO))]
	private IEnumerator<DKMFPOPNNKA> NKLOBJFEMNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4FD0", Offset = "0x6AC39D0", VA = "0x186AC4FD0")]
	private int EKINIJHPEPO(int ENMILGHAHOM, int FOPJELNKACJ, List<JHBBLHAJILM> DMAFOEKNNOC, byte PDJBKOAOLLN, int HMLJIHHKHHA, float APAEPFOOLLB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AC52C0", Offset = "0x6AC3CC0", VA = "0x186AC52C0")]
	public void GDFNAHCIADO(AGFEKKBFFCK ANHGADCFANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5B90", Offset = "0x6AC4590", VA = "0x186AC5B90")]
	public bool IBJEMLKKLNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9CE9E0", Offset = "0x9CD3E0", VA = "0x1809CE9E0")]
	public Material FBOPJJCIMFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9585E0", Offset = "0x956FE0", VA = "0x1809585E0")]
	public Material NNJFBNAKCAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88EC10", Offset = "0x88D610", VA = "0x18088EC10")]
	public Material HNLAHINDMGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC45C0", Offset = "0x6AC2FC0", VA = "0x186AC45C0")]
	public int BNDECCPFKCO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5BD0", Offset = "0x6AC45D0", VA = "0x186AC5BD0")]
	public long IDIFDICNIMF()
	{
		return default(long);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct HBMGCDIAHLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<float3> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeArray<float2> MPDFFHGOHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float4> POALGEAPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeList<int> MBDNPINLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<float3> BGEAMBEIMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private float3 LBOLEHHJECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private float LGGFDBEPJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeParallelMultiHashMap<int, int> HPHGOPOBMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> LGIJGHGBAON;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0A10", Offset = "0x6ABF410", VA = "0x186AC0A10")]
	public HBMGCDIAHLG(CCDNCOACIDM LDNHICGPCIN, NativeList<float3> BGEAMBEIMGA, NativeParallelMultiHashMap<int, int> HPHGOPOBMCE, NativeArray<int> LGIJGHGBAON, Vector3 LBOLEHHJECI, float LGGFDBEPJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AC09B0", Offset = "0x6ABF3B0", VA = "0x186AC09B0")]
	private int LHOKELGFFPH(float3 BJFHPDFPFFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0740", Offset = "0x6ABF140", VA = "0x186AC0740")]
	private int FPMLALBHGOG(int ELMEOKPKOPN, int COMNIKKFEEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0310", Offset = "0x6ABED10", VA = "0x186AC0310", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GHHCOIPIBGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NativeParallelMultiHashMap<int, int> HPHGOPOBMCE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static NativeArray<int> LGIJGHGBAON;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int MDNDNCGPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> HMPEEINEELN;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0120", Offset = "0x6ABEB20", VA = "0x186AC0120")]
	public void MKPLHMCKEFN(int AJEDNCMAFDC, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0040", Offset = "0x6ABEA40", VA = "0x186AC0040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GHHCOIPIBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct OCFGHCDPOMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeList<int> JKIHIHHFIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<int> LBCIGMJDCDA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB060", Offset = "0x6AC9A60", VA = "0x186ACB060")]
	public OCFGHCDPOMG(GHHCOIPIBGB ODPCMPNDJHH, CCDNCOACIDM LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAFB0", Offset = "0x6AC99B0", VA = "0x186ACAFB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct FEKGCNFPFLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeList<float3> OKOIFGKONJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float3> FDCLGABBMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> MMGNMNCMPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeArray<float2> GKEGMHKEAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float4> DIMHEKCFDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<int> HMPEEINEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> JKIHIHHFIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<float3> PIOKNIMNEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float3> HDMIPGMKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float4> IGIMNMEDEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeArray<float4> BNHGOALFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float2> FMCJMPEDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<int> IHFMLEDDGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float ANDKAIGALHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	public float BJNPPEJNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float3 DFMBNKCOHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float DGFLHGGMMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private float CEGMAKGKGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	public float PEAKDEKJAOG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFDA0", Offset = "0x6ABE7A0", VA = "0x186ABFDA0")]
	public FEKGCNFPFLM(GHHCOIPIBGB HIGJGDHGPPC, CCDNCOACIDM LDNHICGPCIN, CCDNCOACIDM EELMJEFFAJG, float CEGMAKGKGJM, float PEAKDEKJAOG, Vector3 DFMBNKCOHOK, float DGFLHGGMMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEAC0", Offset = "0x6ABD4C0", VA = "0x186ABEAC0")]
	private float3 BAHGPJAAKLI(int ELMEOKPKOPN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE820", Offset = "0x6ABD220", VA = "0x186ABE820")]
	private void ABDJFCBOIKB(int ELMEOKPKOPN, [Out] float3 JHJNDONIHFK, [Out] float3 GPKIGKDHFDA, [Out] float4 EAOKLHBBIJP, [Out] float4 PPIJIEPFEII, [Out] float2 FEDJLCKDNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF660", Offset = "0x6ABE060", VA = "0x186ABF660")]
	private int IHGKGGLMHNP(int FMJCNFMMHMI, int CBJBGKIIBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF940", Offset = "0x6ABE340", VA = "0x186ABF940")]
	private void LDLBALLEEGA(int FMJCNFMMHMI, int CBJBGKIIBNP, int HJKIHFAPPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEB70", Offset = "0x6ABD570", VA = "0x186ABEB70")]
	private bool CBEDHAHPCLC(int FMJCNFMMHMI, int CBJBGKIIBNP, float EBACKPIBMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEA00", Offset = "0x6ABD400", VA = "0x186ABEA00")]
	private bool AFODAIDAKON(int FMJCNFMMHMI, int CBJBGKIIBNP, int HJKIHFAPPBI, float EBACKPIBMPE, bool MKNDKEKPHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFB40", Offset = "0x6ABE540", VA = "0x186ABFB40")]
	private bool OKCCFNDCDNH(int FMJCNFMMHMI, int CBJBGKIIBNP, int HJKIHFAPPBI, float EBACKPIBMPE, bool MKNDKEKPHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF640", Offset = "0x6ABE040", VA = "0x186ABF640")]
	private void FHMJDFNJNAN(int FMJCNFMMHMI, int CBJBGKIIBNP, int HJKIHFAPPBI, [Out] int NKJOMFLBAEP, [Out] int PHFIPKNCFME, [Out] int HIIOBECNKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6ABECC0", Offset = "0x6ABD6C0", VA = "0x186ABECC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BFPDGNKFFDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DKBOCOOKNKO : IDisposable, JHBBLHAJILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Bounds OBOMBLGEGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public List<AGFEKKBFFCK> JAPGCHNAGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3 DKJGBHAAHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Vector3 DDEDJBDICNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int ONIOGPDLBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CCDNCOACIDM CNJJENBJDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long IOGJDPBILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GHHCOIPIBGB GHMBLACPNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Transform BAFHJDFHJHD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int JCJFAAJOHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6ABE3C0", Offset = "0x6ABCDC0", VA = "0x186ABE3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh PHKFBCGFBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh NNECCHBPOFL
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NGAABAANDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC020", Offset = "0xAAAA20", VA = "0x180AAC020", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6115540", Offset = "0x6113F40", VA = "0x186115540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte BGNFDILHNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x98B5F0", Offset = "0x989FF0", VA = "0x18098B5F0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x98B490", Offset = "0x989E90", VA = "0x18098B490", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MHAJFLPIEKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9363B0", Offset = "0x934DB0", VA = "0x1809363B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x996A80", Offset = "0x995480", VA = "0x180996A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int ABGAOOMDMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x934D90", VA = "0x180936390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x11010B0", Offset = "0x10FFAB0", VA = "0x1811010B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CFKJGANPPLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6ABE140", Offset = "0x6ABCB40", VA = "0x186ABE140", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE160", Offset = "0x6ABCB60", VA = "0x186ABE160")]
		public void IDJFLPDLHOD(BMENCFGGDHJ PDJBKOAOLLN, [Out] int NHPNPOOIEDN, [Out] int OCJJKCEPHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDDC0", Offset = "0x6ABC7C0", VA = "0x186ABDDC0")]
		public void DANDGDJPKDJ(BMENCFGGDHJ PDJBKOAOLLN, ENAKOAFNLIC MPPLAHJJFFO, int JJCECAFOBMP = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE490", Offset = "0x6ABCE90", VA = "0x186ABE490")]
		public void MJMAFHADNDB(Mesh LDNHICGPCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE400", Offset = "0x6ABCE00", VA = "0x186ABE400")]
		public void LMKGEHPIJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDF90", Offset = "0x6ABC990", VA = "0x186ABDF90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE530", Offset = "0x6ABCF30", VA = "0x186ABE530")]
		public DKBOCOOKNKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Bounds OBOMBLGEGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<DKBOCOOKNKO> EDIHJBFNEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public DCLLEDOGEMD EMEBGBBKFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ClusterMeshRenderer LKDGGBDDBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int HGNAEIPIDNP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HPOAHBCFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BJONKGIJJED
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int OMEIDMDMPID
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB91E0", Offset = "0x6AB7BE0", VA = "0x186AB91E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9B80", Offset = "0x6AB8580", VA = "0x186AB9B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA770", Offset = "0x6AB9170", VA = "0x186ABA770")]
	public int PMHLPGNCFMO(int MKMNFINDCNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D00", Offset = "0x6AB8700", VA = "0x186AB9D00")]
	public void FECHPMGHDFK(DKGBNMAFJLK CNMLHCHMKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9230", Offset = "0x6AB7C30", VA = "0x186AB9230")]
	public void BJOBINFHPFO(Transform PAJBIGFDMMI, bool IDPGDLNBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6AB99C0", Offset = "0x6AB83C0", VA = "0x186AB99C0")]
	public bool DGBDOIOAPAN(bool ANAKIDCNELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA150", Offset = "0x6AB8B50", VA = "0x186ABA150")]
	public void IDMLCOFOFCB(Transform BAFHJDFHJHD, bool IDPGDLNBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9EE0", Offset = "0x6AB88E0", VA = "0x186AB9EE0")]
	public bool GDFNAHCIADO(AGFEKKBFFCK ANHGADCFANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA7A0", Offset = "0x6AB91A0", VA = "0x186ABA7A0")]
	public BFPDGNKFFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MPMAKMDGABH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Queue<BFPDGNKFFDK.DKBOCOOKNKO> FLNNBJGAGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private HNFCFGLEFBG GLDLNANIMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<BFPDGNKFFDK.DKBOCOOKNKO> AMBBCFFKGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int IPJGMIBGEDF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9C40", Offset = "0x6AC8640", VA = "0x186AC9C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA6B0", Offset = "0x6AC90B0", VA = "0x186ACA6B0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA5F0", Offset = "0x6AC8FF0", VA = "0x186ACA5F0")]
	public void KDCHLCHLBCK(BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC, Transform BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9F50", Offset = "0x6AC8950", VA = "0x186AC9F50")]
	public void GDFNAHCIADO(BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA190", Offset = "0x6AC8B90", VA = "0x186ACA190")]
	private BFPDGNKFFDK.DKBOCOOKNKO ICBEEHFMAMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9BA0", Offset = "0x6AC85A0", VA = "0x186AC9BA0")]
	private bool DMHGGIGNDNC(BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA130", Offset = "0x6AC8B30", VA = "0x186ACA130")]
	private void GGHFPKDDBNM(BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9B70", Offset = "0x6AC8570", VA = "0x186AC9B70")]
	public bool CDCGKOCIAEP(BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9CC0", Offset = "0x6AC86C0", VA = "0x186AC9CC0")]
	public bool EOBPLEKHDDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9B00", Offset = "0x6AC8500", VA = "0x186AC9B00")]
	private BFPDGNKFFDK.DKBOCOOKNKO AIPJJKMBLJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA2D0", Offset = "0x6AC8CD0", VA = "0x186ACA2D0")]
	public long IDIFDICNIMF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA730", Offset = "0x6AC9130", VA = "0x186ACA730")]
	public MPMAKMDGABH()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NBCHCBKGELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int MFLIIPHNPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int NIDBMPIONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float LDNPEIJGPEG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<BFPDGNKFFDK> PJJJHMLIBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAE90", Offset = "0x6AC9890", VA = "0x186ACAE90")]
	public NBCHCBKGELB(int MFLIIPHNPNF, int NIDBMPIONDO, float EGIBAHMALIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA8E0", Offset = "0x6AC92E0", VA = "0x186ACA8E0")]
	public void BNGEIAKHILP(NDGCECCDLLE MMONLNNNPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACABA0", Offset = "0x6AC95A0", VA = "0x186ACABA0")]
	private int OFHGPIEHAJE(DKGBNMAFJLK AOOGCKADIHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA990", Offset = "0x6AC9390", VA = "0x186ACA990")]
	private void BNGEIAKHILP(DKGBNMAFJLK AOOGCKADIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAC50", Offset = "0x6AC9650", VA = "0x186ACAC50")]
	private void OKBODCAMOBJ(DKGBNMAFJLK AOOGCKADIHP, BFPDGNKFFDK PBPJOLGFEBI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ClusterMeshRenderer : MonoBehaviour, LFMBBNNBPGC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OJLIKHEDGIJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
			[DebuggerHidden]
			public OJLIKHEDGIJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB090", Offset = "0x6AC9A90", VA = "0x186ACB090", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB250", Offset = "0x6AC9C50", VA = "0x186ACB250", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB1A0", Offset = "0x6AC9BA0", VA = "0x186ACB1A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB1A0", Offset = "0x6AC9BA0", VA = "0x186ACB1A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int OMEIDMDMPID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6ABC8F0", Offset = "0x6ABB2F0", VA = "0x186ABC8F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<JHBBLHAJILM> DIOGMGKBJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ABC8D0", Offset = "0x6ABB2D0", VA = "0x186ABC8D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> EDIHJBFNEJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public BFPDGNKFFDK HPOAHBCFCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CGCFKGNKCNB HHELDDDCLID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(CGCFKGNKCNB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x885650", Offset = "0x884050", VA = "0x180885650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool DKMBCMINLCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1E8F820", Offset = "0x1E8E220", VA = "0x181E8F820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB190", Offset = "0x6AB9B90", VA = "0x186ABB190")]
		public static ClusterMeshRenderer Create(BFPDGNKFFDK LDNHICGPCIN, ClusterMeshRenderer CHBLJEJOJIN, MeshFilter EOELDPPAIAP, FGHMMAJOCCM BAFHJDFHJHD, CGCFKGNKCNB KPHOHHILDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB4F0", Offset = "0x6AB9EF0", VA = "0x186ABB4F0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBDD0", Offset = "0x6ABA7D0", VA = "0x186ABBDD0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(AGFEKKBFFCK ANHGADCFANN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBB80", Offset = "0x6ABA580", VA = "0x186ABBB80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB760", Offset = "0x6ABA160", VA = "0x186ABB760")]
		public void Init(BFPDGNKFFDK LDNHICGPCIN, MeshFilter EOELDPPAIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB550", Offset = "0x6AB9F50", VA = "0x186ABB550")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBF00", Offset = "0x6ABA900", VA = "0x186ABBF00", Slot = "7")]
		public void UpdateClusterDistances(Vector3 BJFHPDFPFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC1B0", Offset = "0x6ABABB0", VA = "0x186ABC1B0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB6E0", Offset = "0x6ABA0E0", VA = "0x186ABB6E0")]
		[IteratorStateMachine(typeof(OJLIKHEDGIJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBC10", Offset = "0x6ABA610", VA = "0x186ABBC10")]
		public void SetupTagAndLayer(string EEIDNNLIIHD, int KPHOHHILDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBBF0", Offset = "0x6ABA5F0", VA = "0x186ABBBF0")]
		public bool Remove(AGFEKKBFFCK ANHGADCFANN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EPPNCNCMJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int PLBIEMLINNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int BHLKMIGNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int OCJJKCEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NHPNPOOIEDN;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE800", Offset = "0x6ABD200", VA = "0x186ABE800")]
	public EPPNCNCMJEE(int BHLKMIGNPBH, int OCJJKCEPHKD, int PLBIEMLINNE, int NHPNPOOIEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DCLLEDOGEMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<float3> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<int> HMPEEINEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<int> MBDNPINLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<EPPNCNCMJEE> MBEINPEIKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<int> BLAHDIDGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float3> NHEAKLCMLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<float> IGIHFPFBMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public JobHandle AJLOAOCOAJH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9CDE80", Offset = "0x9CC880", VA = "0x1809CDE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9CF240", Offset = "0x9CDC40", VA = "0x1809CF240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCBE0", Offset = "0x6ABB5E0", VA = "0x186ABCBE0")]
	public void BDNFIJHBNDG(CCDNCOACIDM KLNLLDDABME, NativeList<EPPNCNCMJEE> MBEINPEIKCG, float FCFDEHNOPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC950", Offset = "0x6ABB350", VA = "0x186ABC950")]
	public void BDCBODBMMIO(Transform BAFHJDFHJHD, bool IDPGDLNBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDA80", Offset = "0x6ABC480", VA = "0x186ABDA80")]
	public void DGBDOIOAPAN(BFPDGNKFFDK LKDGGBDDBJM, bool ANAKIDCNELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDC20", Offset = "0x6ABC620", VA = "0x186ABDC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDD30", Offset = "0x6ABC730", VA = "0x186ABDD30")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DCLLEDOGEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
public struct HPEMEJLJLAD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	public NativeList<int> HMPEEINEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<EPPNCNCMJEE> GEAIOBNNHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeArray<int> BLAHDIDGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float3 DFMBNKCOHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<float3> NHEAKLCMLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private NativeArray<float> IGIHFPFBMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private bool IDPGDLNBIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float GDHMCOBBMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float IMOBLOBBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float NKOFAFDAANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeList<int> MBDNPINLOGK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC20D0", Offset = "0x6AC0AD0", VA = "0x186AC20D0")]
	public HPEMEJLJLAD(DCLLEDOGEMD CKBMBJIJHKI, Vector3 DFMBNKCOHOK, bool IDPGDLNBIKD, float GDHMCOBBMAD, float IMOBLOBBFFL, float NKOFAFDAANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1BD0", Offset = "0x6AC05D0", VA = "0x186AC1BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AGFEKKBFFCK : LFILPOBKFEH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds CMLGOLDEFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DKGBNMAFJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<AGFEKKBFFCK> JAPGCHNAGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public DKGBNMAFJLK KMAENCDMJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public DKGBNMAFJLK EPMGDAGMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public DKGBNMAFJLK EIKOAHBELBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public int NHPNPOOIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Bounds OBOMBLGEGIE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE630", Offset = "0x6ABD030", VA = "0x186ABE630")]
	public DKGBNMAFJLK(List<AGFEKKBFFCK> JAPGCHNAGBM, [Optional] DKGBNMAFJLK KMAENCDMJDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NDGCECCDLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<DKGBNMAFJLK> APOKAAPJGGC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DKGBNMAFJLK CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAEE0", Offset = "0x6AC98E0", VA = "0x186ACAEE0")]
	public NDGCECCDLLE(DKGBNMAFJLK BAFHJDFHJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IEGKGFFBAGH
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct NFFPKBKGIOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int GLBPMIAIMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int MPGOKAFBDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int FEDKBEAHBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int FABAFOHNNPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct DHBMMMLJCCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int GDIOKKAKKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float FODEICGGEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<AGFEKKBFFCK> JAPGCHNAGBM;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDD60", Offset = "0x6ABC760", VA = "0x186ABDD60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum IPMONFOJLNN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NFFPKBKGIOC OGEEKNFECEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int KMMHNGFAKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int MFLIIPHNPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int NIDBMPIONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float EGIBAHMALIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float JIAOADPFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Stack<DKGBNMAFJLK> CCBGFEGODDA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NDGCECCDLLE JPLAJCIAMFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4440", Offset = "0x6AC2E40", VA = "0x186AC4440")]
	public IEGKGFFBAGH(int MFLIIPHNPNF, int NIDBMPIONDO, float EGIBAHMALIC, int KMMHNGFAKBP, float JIAOADPFJOK = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC26A0", Offset = "0x6AC10A0", VA = "0x186AC26A0")]
	public void GHMNLLNBJCK(List<AGFEKKBFFCK> JAPGCHNAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC39F0", Offset = "0x6AC23F0", VA = "0x186AC39F0")]
	public bool KPGOPBLCLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2630", Offset = "0x6AC1030", VA = "0x186AC2630")]
	private float BOEFMAKHFJO(Vector3 INMICDHDKLG, Vector3 LACIJCNPAEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2680", Offset = "0x6AC1080", VA = "0x186AC2680")]
	private float BOEFMAKHFJO(Vector3 ECFPAOHDFEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3A60", Offset = "0x6AC2460", VA = "0x186AC3A60")]
	private bool MHDFCLOPHHP(DKGBNMAFJLK POMPGCAKIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2870", Offset = "0x6AC1270", VA = "0x186AC2870")]
	private DHBMMMLJCCE KOPPEGJLEJA(List<AGFEKKBFFCK> KDMDHHKBCKN, IPMONFOJLNN LBDMGJNBLIA)
	{
		return default(DHBMMMLJCCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2250", Offset = "0x6AC0C50", VA = "0x186AC2250")]
	private void BIIHDHELGDN(List<AGFEKKBFFCK> JAPGCHNAGBM, Span<Vector3> GADIEMLEMML, Span<Vector3> BLAIJNNBHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class BCKDCEPKIBL
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8E40", Offset = "0x6AB7840", VA = "0x186AB8E40")]
	public static Bounds EILCFLGDLKL(List<AGFEKKBFFCK> JAPGCHNAGBM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9010", Offset = "0x6AB7A10", VA = "0x186AB9010")]
	public static int LLPGLDJILPJ(List<AGFEKKBFFCK> JAPGCHNAGBM, BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HNFCFGLEFBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CCDNCOACIDM NBMBBFGKGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private CCDNCOACIDM BHALOANNKKB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static CCDNCOACIDM AAFIIMGIMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FCKFJPINFJG CABEFGAIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private ENAKOAFNLIC MPPLAHJJFFO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle AJLOAOCOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9FB630", Offset = "0x9FA030", VA = "0x1809FB630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BFPDGNKFFDK.DKBOCOOKNKO POMPGCAKIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JEIPMMKMIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A92750", Offset = "0x1A91150", VA = "0x181A92750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1A70", Offset = "0x6AC0470", VA = "0x186AC1A70")]
	[IPMEGJEKNFO(DBODMODMHMH.ExitingPlayMode, 0)]
	private static void JBJFGMODAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0AD0", Offset = "0x6ABF4D0", VA = "0x186AC0AD0")]
	public void BDNFIJHBNDG(BFPDGNKFFDK.DKBOCOOKNKO GEAIOBNNHAH, Transform GNNCBAHMEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC13D0", Offset = "0x6ABFDD0", VA = "0x186AC13D0")]
	public void IMHIKNIEDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1360", Offset = "0x6ABFD60", VA = "0x186AC1360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1AE0", Offset = "0x6AC04E0", VA = "0x186AC1AE0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1B20", Offset = "0x6AC0520", VA = "0x186AC1B20")]
	public HNFCFGLEFBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AFBKJPPAJLG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 KPHDIDPODPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FELLCCMJNFP
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GOLFJDFFGLD<string>.EFMHMOBJFGI KCOINANJLGM, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MCKIGKLAMJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCKIGKLAMJJ HCNGELHHJGA(Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCKIGKLAMJJ MIKGDMECAEE(Action GGEEGOKOMKJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MJBAMBEHBLM : MCKIGKLAMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class ECLENOGKFOD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public MJBAMBEHBLM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
				public ECLENOGKFOD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6ABE7B0", Offset = "0x6ABD1B0", VA = "0x186ABE7B0")]
				internal void POEJGOIMCGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6ABE710", Offset = "0x6ABD110", VA = "0x186ABE710")]
				internal void CAFKBEOIEOK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x6ABE760", Offset = "0x6ABD160", VA = "0x186ABE760")]
				internal void IHLKIEFNNLA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private Func<JobHandle> IGHKCAKJOGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private Action CAPPNNBCBCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action GDHIKKDCPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private CCJCJBKPIIO GHOFOKGNLCJ;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action HCALCGCHDJC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action HHLEHDHCNNP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x47EA620", Offset = "0x47E9020", VA = "0x1847EA620", Slot = "4")]
			public MCKIGKLAMJJ HCNGELHHJGA(Action GGEEGOKOMKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6580E00", Offset = "0x657F800", VA = "0x186580E00", Slot = "5")]
			public MCKIGKLAMJJ MIKGDMECAEE(Action GGEEGOKOMKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
			public MJBAMBEHBLM(Func<JobHandle> NLHHGEKENKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9840", Offset = "0x6AC8240", VA = "0x186AC9840")]
			public void KELODGGKPBN(Action GACCLAJPALK, Action JABBFFIPCPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6AC96B0", Offset = "0x6AC80B0", VA = "0x186AC96B0")]
			public void GDFNAHCIADO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CJEEPGGOCHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public MCKIGKLAMJJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public CJEEPGGOCHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB050", Offset = "0x6AB9A50", VA = "0x186ABB050")]
			internal bool MCAAFLKEFPN(MJBAMBEHBLM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class DKJEINLMJBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public MJBAMBEHBLM newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DKJEINLMJBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6ABE6B0", Offset = "0x6ABD0B0", VA = "0x186ABE6B0")]
			internal void NLLCOIOMGOC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Queue<MJBAMBEHBLM> GBKCJMGOMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<MJBAMBEHBLM> ABEPPOKDMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CHBCKIOGPHP HKDOBPDFKNC;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IDOJILLDPKE HIPGNEJHAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7AC0", Offset = "0x6AC64C0", VA = "0x186AC7AC0")]
		public MCKIGKLAMJJ Add(Func<JobHandle> NLHHGEKENKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7DF0", Offset = "0x6AC67F0", VA = "0x186AC7DF0")]
		public void Remove(MCKIGKLAMJJ AJLOAOCOAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7C20", Offset = "0x6AC6620", VA = "0x186AC7C20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7FD0", Offset = "0x6AC69D0", VA = "0x186AC7FD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8230", Offset = "0x6AC6C30", VA = "0x186AC8230")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7C10", Offset = "0x6AC6610", VA = "0x186AC7C10")]
		[CompilerGenerated]
		private void LKLCOMIFKGD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CCJCJBKPIIO
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCJCJBKPIIO HCNGELHHJGA(Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCJCJBKPIIO HGEMNJKFDCL(Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCJCJBKPIIO MIKGDMECAEE(Action GGEEGOKOMKJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class IDPNPEIIDDH : CCJCJBKPIIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private JobHandle BMEEJCOJFEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Action CAPPNNBCBCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Action LIHKFIBGFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private Action HHLEHDHCNNP;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool JNBOLGGGPMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x6AC2240", Offset = "0x6AC0C40", VA = "0x186AC2240")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6492A60", Offset = "0x6491460", VA = "0x186492A60", Slot = "4")]
			public CCJCJBKPIIO HCNGELHHJGA(Action GGEEGOKOMKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6492A80", Offset = "0x6491480", VA = "0x186492A80", Slot = "5")]
			public CCJCJBKPIIO HGEMNJKFDCL(Action GGEEGOKOMKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6580E00", Offset = "0x657F800", VA = "0x186580E00", Slot = "6")]
			public CCJCJBKPIIO MIKGDMECAEE(Action GGEEGOKOMKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x9FB640", Offset = "0x9FA040", VA = "0x1809FB640")]
			public IDPNPEIIDDH(JobHandle LIEHAIDGKNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6AC21A0", Offset = "0x6AC0BA0", VA = "0x186AC21A0")]
			public void EKAOOMEJNOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6AC21F0", Offset = "0x6AC0BF0", VA = "0x186AC21F0")]
			public void GDFNAHCIADO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<IDPNPEIIDDH> KBAGABBFLNN;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8730", Offset = "0x6AC7130", VA = "0x186AC8730")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8310", Offset = "0x6AC6D10", VA = "0x186AC8310")]
		public CCJCJBKPIIO Add(JobHandle LIEHAIDGKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8630", Offset = "0x6AC7030", VA = "0x186AC8630")]
		public void Remove(CCJCJBKPIIO AJLOAOCOAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8480", Offset = "0x6AC6E80", VA = "0x186AC8480", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC83B0", Offset = "0x6AC6DB0", VA = "0x186AC83B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8870", Offset = "0x6AC7270", VA = "0x186AC8870")]
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
