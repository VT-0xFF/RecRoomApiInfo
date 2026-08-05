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
				[Cpp2IlInjected.Address(RVA = "0x7EB84F0", Offset = "0x7EB6AF0", VA = "0x187EB84F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xE34150", Offset = "0xE32750", VA = "0x180E34150")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7EB84B0", Offset = "0x7EB6AB0", VA = "0x187EB84B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EADC00", Offset = "0x7EAC200", VA = "0x187EADC00")]
		public LODSettings BGJAHEICAJB(PNMMMGBOHFL CLFLCICHDCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EADCB0", Offset = "0x7EAC2B0", VA = "0x187EADCB0")]
		public int GNLHKBKAIDI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EADC10", Offset = "0x7EAC210", VA = "0x187EADC10")]
		public int BHOFCOBCDIB(bool MIKMLHPHIBH, Vector3 DBDNLKEGEDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EADCD0", Offset = "0x7EAC2D0", VA = "0x187EADCD0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OFMOKANBMEK
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
public interface PMOIGKCOEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPJAGPJLLDA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GKNJCECECON
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DLPOGNPIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BNNOANOOJCE> JDBGOHBBBLM
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
	void UpdateClusterDistances(Vector3 JPAIMFCOEEF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(HLBJOGMMCCI DNCHHBPCLHH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BNNOANOOJCE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int ADDJLGEIHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HGMIJMOFHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GLLEGIIFOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OFAGIIODHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte AEEAPAHCIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PIHMKMIBDPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BJPLDFEALDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KEDNLGDDDLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PIHMKMIBDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7C20", Offset = "0x7EB6220", VA = "0x187EB7C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EB83B0", Offset = "0x7EB69B0", VA = "0x187EB83B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NGLLNIKHPMN : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PIHMKMIBDPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public NGLLNIKHPMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7EBA3C0", Offset = "0x7EB89C0", VA = "0x187EBA3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EBA4F0", Offset = "0x7EB8AF0", VA = "0x187EBA4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MKLIDAGPOIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PIHMKMIBDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EHMNEFALKGP<string>.OJMJGFAOFAB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private EHMNEFALKGP<string>.OJMJGFAOFAB <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8AF0", Offset = "0x7EB70F0", VA = "0x187EB8AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7EBA360", Offset = "0x7EB8960", VA = "0x187EBA360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DKDEPOPDKHB : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PIHMKMIBDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public DKDEPOPDKHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EB06F0", Offset = "0x7EAECF0", VA = "0x187EB06F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7EB13E0", Offset = "0x7EAF9E0", VA = "0x187EB13E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int ALBJLHFCBKL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan FCNILPLDAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer JIKMAFCFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LBOHLMGCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject CPPBOBBKLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject OHPJPPGHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public JOOAOGJAKHG INLMHBDPIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<HLBJOGMMCCI> BICMIAGKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<HLBJOGMMCCI> AAHFPCGEMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<HLBJOGMMCCI> OLFMGMJIEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KCBBHFAMJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BJPLDFEALDK BCNCLEEFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<GKNJCECECON>[] BOFFOMLDLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BNNOANOOJCE>[] KGDAHAHNJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource FLKBJKEGHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HDBHHAKFGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LLKKGNCPLNM DJIANDGFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LLKKGNCPLNM GNGDNBOIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int GGPBAKLEMIP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static PIHMKMIBDPD CNPKAEPPLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BMBKJHGPKCP HHLKHAMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KKCDEAKHPGM GNGKENBOJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour GDPIMOOHCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material LLPCPOLFDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> CPDFGOCKLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material AFDMMHGPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> HNOIKFDABPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LDHEMPMNDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<PMOIGKCOEBM> OMMGALLIHNH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig HIHDKLNGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 EELCJEKEFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F88720", Offset = "0x1F86D20", VA = "0x181F88720")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F88640", Offset = "0x1F86C40", VA = "0x181F88640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BJPLDFEALDK ALMAINLLNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFCE110", Offset = "0xFCC710", VA = "0x180FCE110")]
		get
		{
			return default(BJPLDFEALDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFA50", Offset = "0x7EBE050", VA = "0x187EBFA50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static PIHMKMIBDPD FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0D10", Offset = "0x7EBF310", VA = "0x187EC0D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool KBAEHPIEFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0650", Offset = "0x7EBEC50", VA = "0x187EC0650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KPHEPKKLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0750", Offset = "0x7EBED50", VA = "0x187EC0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> FCNEHHBIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC04F0", Offset = "0x7EBEAF0", VA = "0x187EC04F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1090", Offset = "0x7EBF690", VA = "0x187EC1090")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IAPOEFOFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC0ED0", Offset = "0x7EBF4D0", VA = "0x187EC0ED0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBEA30", Offset = "0x7EBD030", VA = "0x187EBEA30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC11C0", Offset = "0x7EBF7C0", VA = "0x187EC11C0")]
	public PIHMKMIBDPD(BMBKJHGPKCP HHLKHAMPOAL, KKCDEAKHPGM GNGKENBOJCK, ClusterLODConfig IAOCKFIFFEP, MonoBehaviour GDPIMOOHCHJ, Material BOHNLBBKGMK, ClusterMeshRenderer JIKMAFCFLOL, MeshFilter LBOHLMGCNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDE20", Offset = "0x7EBC420", VA = "0x187EBDE20")]
	private void AJELMKLBOJP(Material BOHNLBBKGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0D60", Offset = "0x7EBF360", VA = "0x187EC0D60")]
	public void NECJNILBJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0630", Offset = "0x7EBEC30", VA = "0x187EC0630")]
	public static JOHNDGNODKM.DLPLPJGMGAK LLHDCGDOBCA(JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ)
	{
		return default(JOHNDGNODKM.DLPLPJGMGAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEFA0", Offset = "0x7EBD5A0", VA = "0x187EBEFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEEA0", Offset = "0x7EBD4A0", VA = "0x187EBEEA0")]
	public static void DLEDAKEHBOE(Vector3 CHOMOOEAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFC00", Offset = "0x7EBE200", VA = "0x187EBFC00")]
	private void JHNECEPKJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0E00", Offset = "0x7EBF400", VA = "0x187EC0E00")]
	private void NINHIFFKJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0A50", Offset = "0x7EBF050", VA = "0x187EC0A50")]
	private void MMEHHOGAJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFE90", Offset = "0x7EBE490", VA = "0x187EBFE90")]
	public void KIAJCGEKLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF740", Offset = "0x7EBDD40", VA = "0x187EBF740")]
	[AsyncStateMachine(typeof(KEDNLGDDDLF))]
	public Task FCHNEFBABGF(EHMNEFALKGP<string>.OJMJGFAOFAB FDKDKPFOFCH, CancellationToken BACOGCKOPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0810", Offset = "0x7EBEE10", VA = "0x187EC0810")]
	[IteratorStateMachine(typeof(NGLLNIKHPMN))]
	private IEnumerator<HPILNDONOCO> MDCHBNADCFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE910", Offset = "0x7EBCF10", VA = "0x187EBE910")]
	[AsyncStateMachine(typeof(MKLIDAGPOIO))]
	private Task CENNHJBDBHI(EHMNEFALKGP<string>.OJMJGFAOFAB HAFNBOGKIMA, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFC90", Offset = "0x7EBE290", VA = "0x187EBFC90")]
	public void KEBGOJPGMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1010", Offset = "0x7EBF610", VA = "0x187EC1010")]
	public void PNMFHBHMOME(IEnumerable<GKNJCECECON> MLHHPNKIGNC, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEBA0", Offset = "0x7EBD1A0", VA = "0x187EBEBA0")]
	public void DGAOCLIAJEG(IEnumerable<GKNJCECECON> MLHHPNKIGNC, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE230", Offset = "0x7EBC830", VA = "0x187EBE230")]
	public List<ClusterMeshRenderer> CCCOCLGEILM(List<HLBJOGMMCCI> NADKNNLCLLH, MBBBIPMPPEE CMAFOEIBEKN, OFMOKANBMEK GMLCBPDDIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDF90", Offset = "0x7EBC590", VA = "0x187EBDF90")]
	public void AKHFELDHGNA(PMOIGKCOEBM DGCGKPKDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7EC09F0", Offset = "0x7EBEFF0", VA = "0x187EC09F0")]
	public bool MLPCCKPCANH(PMOIGKCOEBM DGCGKPKDMHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF860", Offset = "0x7EBDE60", VA = "0x187EBF860")]
	public void FNOEAFCAKGO(HLBJOGMMCCI HHADEGDPPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFB80", Offset = "0x7EBE180", VA = "0x187EBFB80")]
	public void ICKNHLABILJ(BNNOANOOJCE FGCEFPKBOEH, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEAE0", Offset = "0x7EBD0E0", VA = "0x187EBEAE0")]
	public void CJHIGJNFCMM(BNNOANOOJCE FGCEFPKBOEH, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF8C0", Offset = "0x7EBDEC0", VA = "0x187EBF8C0")]
	private void GMAKLICHFJN(Vector3 JPAIMFCOEEF, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0890", Offset = "0x7EBEE90", VA = "0x187EC0890")]
	private void MGDNEPCJAPA(Vector3 JPAIMFCOEEF, OFMOKANBMEK GMLCBPDDIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7EC05B0", Offset = "0x7EBEBB0", VA = "0x187EC05B0")]
	[IteratorStateMachine(typeof(DKDEPOPDKHB))]
	private IEnumerator<HPILNDONOCO> LIOMLKNPHKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0BA0", Offset = "0x7EBF1A0", VA = "0x187EC0BA0")]
	private int MNFNABBOIKM(int KHMHPNKMLMD, int OEAIKDHABFM, List<BNNOANOOJCE> GJGCEJMJMMN, byte CLFLCICHDCN, int LEGMIDGOEOC, float KKCCKPMKNGB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDFF0", Offset = "0x7EBC5F0", VA = "0x187EBDFF0")]
	public void BAFGFGCDOJB(HLBJOGMMCCI DNCHHBPCLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEB60", Offset = "0x7EBD160", VA = "0x187EBEB60")]
	public bool DEFEGBFADKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xAD80D0", Offset = "0xAD66D0", VA = "0x180AD80D0")]
	public Material BJOFNFPLCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE1A0", Offset = "0x7EBC7A0", VA = "0x187EBE1A0")]
	public Material BJOFNFPLCCI(JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA51ED0", Offset = "0xA504D0", VA = "0x180A51ED0")]
	public Material PAAFFKNBHEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0F80", Offset = "0x7EBF580", VA = "0x187EC0F80")]
	public Material PAAFFKNBHEK(JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7EBFA10", Offset = "0x7EBE010", VA = "0x187EBFA10")]
	public int GNLHKBKAIDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF370", Offset = "0x7EBD970", VA = "0x187EBF370")]
	public (long, int) EJFHOCFFJKI()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct COFMEMFOAAO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> NJFMDNHHIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> DIGJAIJPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> CAMKOJIMJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> PEKKOAHHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> MKHHILLHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> FNHPBHIDMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 BAMBCIEOKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float DCEPMGHPDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> KPNDCDJLDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> NFFJDMCOOGI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EADB40", Offset = "0x7EAC140", VA = "0x187EADB40")]
	public COFMEMFOAAO(JOHNDGNODKM IDMOPPBKAAO, NativeList<float3> FNHPBHIDMJN, NativeParallelMultiHashMap<int, int> KPNDCDJLDEH, NativeArray<int> NFFJDMCOOGI, Vector3 BAMBCIEOKBD, float DCEPMGHPDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD870", Offset = "0x7EABE70", VA = "0x187EAD870")]
	private int IJKFFEHCKIH(float3 JPAIMFCOEEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD8D0", Offset = "0x7EABED0", VA = "0x187EAD8D0")]
	private int KFIGBHLPLMA(int LGMBEINIKOB, int BLIBAMJKLIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD440", Offset = "0x7EABA40", VA = "0x187EAD440", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HIINOKFIJFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> KPNDCDJLDEH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> NFFJDMCOOGI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int GDBPOLBGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> LGEKAEFEPLH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3180", Offset = "0x7EB1780", VA = "0x187EB3180")]
	public void CMAKEHGLHJI(int IGENIDBBLGE, Allocator HOHBLCPFIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3380", Offset = "0x7EB1980", VA = "0x187EB3380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HIINOKFIJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct ENOAECNOPMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> AHNPHKDIDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> ALFAJCCHHNI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1650", Offset = "0x7EAFC50", VA = "0x187EB1650")]
	public ENOAECNOPMN(HIINOKFIJFM CKKBMHLJFNC, JOHNDGNODKM IDMOPPBKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EB15A0", Offset = "0x7EAFBA0", VA = "0x187EB15A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct OLMFFIAELGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> JHECMPLADOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> KMIGOFHCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> EFJNOEEPHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> PDJILIHBLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> PMAICPIHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> LGEKAEFEPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> AHNPHKDIDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> DNAAILGCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> IAACBBJGKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> KMMACDLJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> DCOCFBHHOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> BEKEECJKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> OJADIHBFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float PBDCAJADFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float JBOFBHNBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 KMCDOJDOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float DBJFDKLGDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float DBHOJLFECML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float AMEHFMMOAMH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBBB0", Offset = "0x7EBA1B0", VA = "0x187EBBBB0")]
	public OLMFFIAELGO(HIINOKFIJFM ABAJPJIPIFF, JOHNDGNODKM IDMOPPBKAAO, JOHNDGNODKM KDJECFCHKGI, float DBHOJLFECML, float AMEHFMMOAMH, Vector3 KMCDOJDOLDC, float DBJFDKLGDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB720", Offset = "0x7EB9D20", VA = "0x187EBB720")]
	private float3 JNOPJJDKMGE(int LGMBEINIKOB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB9D0", Offset = "0x7EB9FD0", VA = "0x187EBB9D0")]
	private void OFEHBIKLLBP(int LGMBEINIKOB, [Out] float3 GGKNBBMADPA, [Out] float3 GKGFPJJHCFP, [Out] float4 KGMJHJMKEAI, [Out] float4 HMDIHHFDINF, [Out] float2 IAJLFDNNEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA9E0", Offset = "0x7EB8FE0", VA = "0x187EBA9E0")]
	private int ACHEHHFIOLI(int GIBGOCAFKOJ, int CAEJNMMAKDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB7D0", Offset = "0x7EB9DD0", VA = "0x187EBB7D0")]
	private void LMILEIFPEJM(int GIBGOCAFKOJ, int CAEJNMMAKDP, int KCNKBJHAMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA630", Offset = "0x7EB8C30", VA = "0x187EBA630")]
	private bool ABKOGLLEFGA(int GIBGOCAFKOJ, int CAEJNMMAKDP, float HAPBBPJOKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EBACC0", Offset = "0x7EB92C0", VA = "0x187EBACC0")]
	private bool BFCPBCHBDLK(int GIBGOCAFKOJ, int CAEJNMMAKDP, int KCNKBJHAMMB, float HAPBBPJOKBG, bool BEFDCCBHHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA780", Offset = "0x7EB8D80", VA = "0x187EBA780")]
	private bool ACBIAPEMBGA(int GIBGOCAFKOJ, int CAEJNMMAKDP, int KCNKBJHAMMB, float HAPBBPJOKBG, bool BEFDCCBHHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBAD80", Offset = "0x7EB9380", VA = "0x187EBAD80")]
	private void EBHMOBIBGIJ(int GIBGOCAFKOJ, int CAEJNMMAKDP, int KCNKBJHAMMB, [Out] int NHIGOAFFHNK, [Out] int NLONBAHDPMI, [Out] int GCOGBDMBNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBADA0", Offset = "0x7EB93A0", VA = "0x187EBADA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JKBODPDPHEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class DAKEBOBKCON : IDisposable, BNNOANOOJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds ACMLBEHJCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<HLBJOGMMCCI> NADKNNLCLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 PMHNHKCMDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 JDOIGHKHNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int KBIHCOBOKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JOHNDGNODKM MIAFLIFPFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long FOALABEPAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HIINOKFIJFM IGGIFAHFEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform CMAFOEIBEKN;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int OBOGCOFDDCF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7EAFAD0", Offset = "0x7EAE0D0", VA = "0x187EAFAD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh EBDELIJEBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JOHNDGNODKM.DLPLPJGMGAK ICCMHMFLFBP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
			[CompilerGenerated]
			get
			{
				return default(JOHNDGNODKM.DLPLPJGMGAK);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh GMDLJMAKJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JOHNDGNODKM.DLPLPJGMGAK DNIMJOJGLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF2CD40", Offset = "0xF2B340", VA = "0x180F2CD40")]
			[CompilerGenerated]
			get
			{
				return default(JOHNDGNODKM.DLPLPJGMGAK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF2E900", Offset = "0xF2CF00", VA = "0x180F2E900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float GLLEGIIFOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x118A830", Offset = "0x1188E30", VA = "0x18118A830", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x191D580", Offset = "0x191BB80", VA = "0x18191D580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte AEEAPAHCIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1D70800", Offset = "0x1D6EE00", VA = "0x181D70800")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2131D30", Offset = "0x2130330", VA = "0x182131D30", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ADDJLGEIHGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA7C680", Offset = "0xA7AC80", VA = "0x180A7C680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x14964E0", Offset = "0x1494AE0", VA = "0x1814964E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HGMIJMOFHPO
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA6CC40", Offset = "0xA6B240", VA = "0x180A6CC40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x14964F0", Offset = "0x1494AF0", VA = "0x1814964F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OFAGIIODHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7EAFAB0", Offset = "0x7EAE0B0", VA = "0x187EAFAB0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFCE0", Offset = "0x7EAE2E0", VA = "0x187EAFCE0")]
		public void JDFEFIGELJO(PNMMMGBOHFL CLFLCICHDCN, [Out] int KABGKOBDGEB, [Out] int AIHHKEFNBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFB10", Offset = "0x7EAE110", VA = "0x187EAFB10")]
		public void HPIODMKADEO(PNMMMGBOHFL CLFLCICHDCN, AKEMDMPFBPH HPJLKKGBLCO, int ELMBLIGGLCN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFF50", Offset = "0x7EAE550", VA = "0x187EAFF50")]
		public void OMPCBACJAPA(Mesh IDMOPPBKAAO, JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF860", Offset = "0x7EADE60", VA = "0x187EAF860")]
		public void DMCDNPBACOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF8F0", Offset = "0x7EADEF0", VA = "0x187EAF8F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0000", Offset = "0x7EAE600", VA = "0x187EB0000")]
		public DAKEBOBKCON()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds ACMLBEHJCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public JOHNDGNODKM.DLPLPJGMGAK MJLNGFFONGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<DAKEBOBKCON> OOEFJPHMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public BPDLGEFFHCL NNJPCPPPMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer FMBOIKGHIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int MDNGGJJCKOB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GAMNJOHBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OKMBIAGFLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DLPOGNPIBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4220", Offset = "0x7EB2820", VA = "0x187EB4220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7EB48A0", Offset = "0x7EB2EA0", VA = "0x187EB48A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5270", Offset = "0x7EB3870", VA = "0x187EB5270")]
	public int EOFDHKHMMBE(int HGPEJGNPIHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5460", Offset = "0x7EB3A60", VA = "0x187EB5460")]
	public void JMOJDAMIOFE(LELEJNDNFML PLAEKNOKDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4A20", Offset = "0x7EB3020", VA = "0x187EB4A20")]
	public void EAGJLDNMIIC(Transform ICPKNMBNNIA, bool KHABCHOEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7EB52A0", Offset = "0x7EB38A0", VA = "0x187EB52A0")]
	public bool IJKJJMHNFHC(bool DOCDGODEOHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4270", Offset = "0x7EB2870", VA = "0x187EB4270")]
	public void CLMNKEJHHIB(Transform CMAFOEIBEKN, bool KHABCHOEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3FB0", Offset = "0x7EB25B0", VA = "0x187EB3FB0")]
	public bool BAFGFGCDOJB(HLBJOGMMCCI DNCHHBPCLHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5650", Offset = "0x7EB3C50", VA = "0x187EB5650")]
	public JKBODPDPHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JOOAOGJAKHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<JKBODPDPHEP.DAKEBOBKCON> CGBPOJEELCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HALOMBDLCHF PGMOGNJOLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<JKBODPDPHEP.DAKEBOBKCON> IOJDIGJMAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int CPNBFCEPMPM;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5E20", Offset = "0x7EB4420", VA = "0x187EB5E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5F00", Offset = "0x7EB4500", VA = "0x187EB5F00")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6210", Offset = "0x7EB4810", VA = "0x187EB6210")]
	public void JDPCENHCAFL(JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK, Transform CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5BE0", Offset = "0x7EB41E0", VA = "0x187EB5BE0")]
	public void BAFGFGCDOJB(JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6410", Offset = "0x7EB4A10", VA = "0x187EB6410")]
	private JKBODPDPHEP.DAKEBOBKCON NPEJELDJAOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6370", Offset = "0x7EB4970", VA = "0x187EB6370")]
	private bool NLLGGPKNBIH(JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5DC0", Offset = "0x7EB43C0", VA = "0x187EB5DC0")]
	private void BFHDEBAPIEM(JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6340", Offset = "0x7EB4940", VA = "0x187EB6340")]
	public bool NIFMDJFAFBG(JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5F80", Offset = "0x7EB4580", VA = "0x187EB5F80")]
	public bool IEMAIHNOLMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB62D0", Offset = "0x7EB48D0", VA = "0x187EB62D0")]
	private JKBODPDPHEP.DAKEBOBKCON KJOAKAIOOPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6550", Offset = "0x7EB4B50", VA = "0x187EB6550")]
	public long OAFPEGJFCPE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6870", Offset = "0x7EB4E70", VA = "0x187EB6870")]
	public JOOAOGJAKHG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JKFKEMKPLMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int INLKMIBJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int MHNHAONLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float GJAHHANMKPO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<JKBODPDPHEP> NIINABAJOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5B90", Offset = "0x7EB4190", VA = "0x187EB5B90")]
	public JKFKEMKPLMI(int INLKMIBJCCO, int MHNHAONLIPO, float HNMGDBJAPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5870", Offset = "0x7EB3E70", VA = "0x187EB5870")]
	public void OKMLMPKKPHF(GDEOEJFAFIL LEIODFINLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5720", Offset = "0x7EB3D20", VA = "0x187EB5720")]
	private int CKLMACCEHCN(LELEJNDNFML ADFICJOCHFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5920", Offset = "0x7EB3F20", VA = "0x187EB5920")]
	private void OKMLMPKKPHF(LELEJNDNFML ADFICJOCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB57D0", Offset = "0x7EB3DD0", VA = "0x187EB57D0")]
	private void FLKAGBJOBEE(LELEJNDNFML ADFICJOCHFA, JKBODPDPHEP ELMMNKCBNKM)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, GKNJCECECON
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class APKPJIHANJE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
			[DebuggerHidden]
			public APKPJIHANJE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7EAB970", Offset = "0x7EA9F70", VA = "0x187EAB970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7EABB30", Offset = "0x7EAA130", VA = "0x187EABB30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7EABA80", Offset = "0x7EAA080", VA = "0x187EABA80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7EABA80", Offset = "0x7EAA080", VA = "0x187EABA80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int DLPOGNPIBEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7EAF800", Offset = "0x7EADE00", VA = "0x187EAF800", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<BNNOANOOJCE> JDBGOHBBBLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7EAF7E0", Offset = "0x7EADDE0", VA = "0x187EAF7E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> OOEFJPHMCLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JKBODPDPHEP GAMNJOHBFFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public OFMOKANBMEK GLOLADLBAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(OFMOKANBMEK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool FAIPFDLAEPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD1F3D0", Offset = "0xD1D9D0", VA = "0x180D1F3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EADD30", Offset = "0x7EAC330", VA = "0x187EADD30")]
		public static ClusterMeshRenderer Create(JKBODPDPHEP IDMOPPBKAAO, ClusterMeshRenderer JIKMAFCFLOL, MeshFilter LBOHLMGCNCE, MBBBIPMPPEE CMAFOEIBEKN, OFMOKANBMEK GMLCBPDDIOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EADFB0", Offset = "0x7EAC5B0", VA = "0x187EADFB0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEAB0", Offset = "0x7EAD0B0", VA = "0x187EAEAB0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(HLBJOGMMCCI DNCHHBPCLHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE860", Offset = "0x7EACE60", VA = "0x187EAE860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE4F0", Offset = "0x7EACAF0", VA = "0x187EAE4F0")]
		public void Init(JKBODPDPHEP IDMOPPBKAAO, MeshFilter LBOHLMGCNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE010", Offset = "0x7EAC610", VA = "0x187EAE010")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEBE0", Offset = "0x7EAD1E0", VA = "0x187EAEBE0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 JPAIMFCOEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EAEE90", Offset = "0x7EAD490", VA = "0x187EAEE90", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE470", Offset = "0x7EACA70", VA = "0x187EAE470")]
		[IteratorStateMachine(typeof(APKPJIHANJE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE8F0", Offset = "0x7EACEF0", VA = "0x187EAE8F0")]
		public void SetupTagAndLayer(string MFGALGGOPCB, int GMLCBPDDIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE8D0", Offset = "0x7EACED0", VA = "0x187EAE8D0")]
		public bool Remove(HLBJOGMMCCI DNCHHBPCLHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LEAFMHDPKAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int LMPFLOABKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int IGHNHCKLCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int AIHHKEFNBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int KABGKOBDGEB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8410", Offset = "0x7EB6A10", VA = "0x187EB8410")]
	public LEAFMHDPKAM(int IGHNHCKLCCN, int AIHHKEFNBIM, int LMPFLOABKAH, int KABGKOBDGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BPDLGEFFHCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> LGEKAEFEPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> MKHHILLHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<LEAFMHDPKAM> MDAIJKBFHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> MNGKCNOPAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> MDBMLJNLNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> HFPMPIHANMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle JNHDFACBLOI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JNHKEEAMOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA75E80", Offset = "0xA74480", VA = "0x180A75E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA75550", Offset = "0xA73B50", VA = "0x180A75550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC540", Offset = "0x7EAAB40", VA = "0x187EAC540")]
	public void PNLBMDNIIGG(JOHNDGNODKM KIIBBHFNDKL, NativeList<LEAFMHDPKAM> MDAIJKBFHJP, float HKINPNLCPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC2B0", Offset = "0x7EAA8B0", VA = "0x187EAC2B0")]
	public void KEOJDOLNPIA(Transform CMAFOEIBEKN, bool KHABCHOEAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC110", Offset = "0x7EAA710", VA = "0x187EAC110")]
	public void IJKJJMHNFHC(JKBODPDPHEP FMBOIKGHIFL, bool DOCDGODEOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EABFD0", Offset = "0x7EAA5D0", VA = "0x187EABFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC0E0", Offset = "0x7EAA6E0", VA = "0x187EAC0E0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BPDLGEFFHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct DKCKFNDOMDF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> OAFFCDPLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> LGEKAEFEPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<LEAFMHDPKAM> FFKKLILNJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> MNGKCNOPAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 KMCDOJDOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> MDBMLJNLNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> HFPMPIHANMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool KHABCHOEAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float HEFBJLFFJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float MEDPBMNGMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float FJAGKJJNGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> MKHHILLHEAP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0620", Offset = "0x7EAEC20", VA = "0x187EB0620")]
	public DKCKFNDOMDF(BPDLGEFFHCL IEJENGCONND, Vector3 KMCDOJDOLDC, bool KHABCHOEAOC, float HEFBJLFFJPB, float MEDPBMNGMFE, float FJAGKJJNGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0120", Offset = "0x7EAE720", VA = "0x187EB0120", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HLBJOGMMCCI : BBFFBKDDGCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds NKCKKAMBGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LELEJNDNFML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<HLBJOGMMCCI> NADKNNLCLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public LELEJNDNFML NBIJLPJHNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public LELEJNDNFML IOJIFNENHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public LELEJNDNFML JKDPAFHMCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int KABGKOBDGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds ACMLBEHJCNK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8430", Offset = "0x7EB6A30", VA = "0x187EB8430")]
	public LELEJNDNFML(List<HLBJOGMMCCI> NADKNNLCLLH, [Optional] LELEJNDNFML NBIJLPJHNNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GDEOEJFAFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<LELEJNDNFML> EONGKDNIGOD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LELEJNDNFML JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB19A0", Offset = "0x7EAFFA0", VA = "0x187EB19A0")]
	public GDEOEJFAFIL(LELEJNDNFML CMAFOEIBEKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PAADPIJEMDG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct IIBCNEJDGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int FAALDGLNCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int PDNKGNICDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int PLMMIIFMHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int IPMGLAIKAEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct CEBHMGPDIDA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int BHOCDHDGEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float POICDBBNAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<HLBJOGMMCCI> NADKNNLCLLH;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD3E0", Offset = "0x7EAB9E0", VA = "0x187EAD3E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum AOJLONJANKM
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private IIBCNEJDGIK KOHKEIHJPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int NGCHABMHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int INLKMIBJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int MHNHAONLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float HNMGDBJAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float JCPOIEOHDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<LELEJNDNFML> GAECKJNPMDG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GDEOEJFAFIL MEBLGOKCFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDDC0", Offset = "0x7EBC3C0", VA = "0x187EBDDC0")]
	public PAADPIJEMDG(int INLKMIBJCCO, int MHNHAONLIPO, float HNMGDBJAPCJ, int NGCHABMHLHD, float JCPOIEOHDKO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDBF0", Offset = "0x7EBC1F0", VA = "0x187EBDBF0")]
	public void PEJDLPNKIFJ(List<HLBJOGMMCCI> NADKNNLCLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBD60", Offset = "0x7EBA360", VA = "0x187EBBD60")]
	public bool JAMLCAJOLOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBCF0", Offset = "0x7EBA2F0", VA = "0x187EBBCF0")]
	private float HGBJODCJMDL(Vector3 LPAMMAPPJAO, Vector3 CMGDLKAFPEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBD40", Offset = "0x7EBA340", VA = "0x187EBBD40")]
	private float HGBJODCJMDL(Vector3 GPNBMIDFKMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD210", Offset = "0x7EBB810", VA = "0x187EBD210")]
	private bool OLHBLPFKMPB(LELEJNDNFML LEOKNJGGMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBDD0", Offset = "0x7EBA3D0", VA = "0x187EBBDD0")]
	private CEBHMGPDIDA JFEGDLGEKPM(List<HLBJOGMMCCI> IPNLAHDONAG, AOJLONJANKM HCMLNKCPEIM)
	{
		return default(CEBHMGPDIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EBCE50", Offset = "0x7EBB450", VA = "0x187EBCE50")]
	private void LNNJHBJCDEF(List<HLBJOGMMCCI> NADKNNLCLLH, NativeArray<Vector3> NGKHFJPLAKE, NativeArray<Vector3> FCKMFEGOFHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IDAPIDJPDNA
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3680", Offset = "0x7EB1C80", VA = "0x187EB3680")]
	public static Bounds AOMADOFKHDP(List<HLBJOGMMCCI> NADKNNLCLLH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3850", Offset = "0x7EB1E50", VA = "0x187EB3850")]
	public static int DGFCOHNBGDJ(List<HLBJOGMMCCI> NADKNNLCLLH, PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class HOKANBHBNPE
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool EHHLDIIEAGN(float4* PEKKOAHHCKB, int PHABMFMJBEC);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class MINKGLEHHJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EB89C0", Offset = "0x7EB6FC0", VA = "0x187EB89C0")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8860", Offset = "0x7EB6E60", VA = "0x187EB8860")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB87B0", Offset = "0x7EB6DB0", VA = "0x187EB87B0")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EB85C0", Offset = "0x7EB6BC0", VA = "0x187EB85C0")]
		public unsafe static bool GHDKDALNEMC(float4* PEKKOAHHCKB, int PHABMFMJBEC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3460", Offset = "0x7EB1A60", VA = "0x187EB3460")]
	[BurstCompile]
	public unsafe static bool GFCALDFGJEA(float4* PEKKOAHHCKB, int PHABMFMJBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB780", Offset = "0x7EA9D80", VA = "0x187EAB780")]
	[BurstCompile]
	public unsafe static bool NLGNJKBEMCB(float4* PEKKOAHHCKB, int PHABMFMJBEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct FBOKFLMAEEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> GDBIONGPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> OJJKAOLLJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> CEECJMPCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> OKNPPMHAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> JHAJLJLMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> CAMKOJIMJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> HJJGMNHGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> MDOOGKCLNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<JOHNDGNODKM.MHHLOPGOHBK> AONOGIBIGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1930", Offset = "0x7EAFF30", VA = "0x187EB1930")]
	public FBOKFLMAEEJ(JOHNDGNODKM FLCAHEKAAMB, NativeArray<bool> HJJGMNHGAEJ, NativeList<ushort> MDOOGKCLNDJ, NativeList<JOHNDGNODKM.MHHLOPGOHBK> AONOGIBIGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1680", Offset = "0x7EAFC80", VA = "0x187EB1680", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct JFMOAKAGBJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> GDBIONGPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> OJJKAOLLJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> CEECJMPCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> OKNPPMHAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> JHAJLJLMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> CAMKOJIMJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> LAPGIODHIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> HNECFHLMGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> EOOJJGNNOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> OAHIBPPDMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> ILDOGFILGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> CEMJMBDOOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> HJJGMNHGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> MDOOGKCLNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<JOHNDGNODKM.MHHLOPGOHBK> AONOGIBIGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3EF0", Offset = "0x7EB24F0", VA = "0x187EB3EF0")]
	public JFMOAKAGBJO(JOHNDGNODKM FLCAHEKAAMB, JOHNDGNODKM KLAJPDAIDCJ, NativeArray<bool> HJJGMNHGAEJ, NativeList<ushort> MDOOGKCLNDJ, NativeList<JOHNDGNODKM.MHHLOPGOHBK> AONOGIBIGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3A20", Offset = "0x7EB2020", VA = "0x187EB3A20", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HALOMBDLCHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JOHNDGNODKM HFGILPEFCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private JOHNDGNODKM FLCAHEKAAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> PMCKIOEOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> MDOOGKCLNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<JOHNDGNODKM.MHHLOPGOHBK> AONOGIBIGAJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static JOHNDGNODKM EPEHEIOEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private JDIPKNPCLDJ PJABPPGEPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private AKEMDMPFBPH HPJLKKGBLCO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle JNHDFACBLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JKBODPDPHEP.DAKEBOBKCON LEOKNJGGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HAKPIDDCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x25A1280", Offset = "0x259F880", VA = "0x1825A1280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1B40", Offset = "0x7EB0140", VA = "0x187EB1B40")]
	[IEDOGDIKGGL(DEKJCOCACDG.EnteredEditMode, 0)]
	private static void EMLAKCIAJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB24D0", Offset = "0x7EB0AD0", VA = "0x187EB24D0")]
	public void PNLBMDNIIGG(JKBODPDPHEP.DAKEBOBKCON FFKKLILNJOB, Transform JGLAPHEABJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1C00", Offset = "0x7EB0200", VA = "0x187EB1C00")]
	public void KOHFKMODLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1A70", Offset = "0x7EB0070", VA = "0x187EB1A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1BC0", Offset = "0x7EB01C0", VA = "0x187EB1BC0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3010", Offset = "0x7EB1610", VA = "0x187EB3010")]
	public HALOMBDLCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KKCDEAKHPGM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 CPOCCCJJBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BMBKJHGPKCP
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(EHMNEFALKGP<string>.OJMJGFAOFAB HAFNBOGKIMA, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EGGLDELOPFF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGGLDELOPFF FBEHJKFLHBA(Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGGLDELOPFF AJPDGMPCCOD(Action CJDOILFHDJI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BOPCDKOFDKJ : EGGLDELOPFF
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class OCIOCEIBBGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public BOPCDKOFDKJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
				public OCIOCEIBBGO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7EBA540", Offset = "0x7EB8B40", VA = "0x187EBA540")]
				internal void IDAGNLGNDFK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7EBA590", Offset = "0x7EB8B90", VA = "0x187EBA590")]
				internal void NFANINKJMBG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7EBA5E0", Offset = "0x7EB8BE0", VA = "0x187EBA5E0")]
				internal void NHLLCFCGDKJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> KGGKDIEGGEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action DPIHBLNNBKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action LBFLODCGGFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private KHKECDJOKAL ADHDKJBHPPM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action BMFNBGOCAGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action EJDAJFBPIFP
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x290CCB0", Offset = "0x290B2B0", VA = "0x18290CCB0", Slot = "4")]
			public EGGLDELOPFF FBEHJKFLHBA(Action CJDOILFHDJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x782CE10", Offset = "0x782B410", VA = "0x18782CE10", Slot = "5")]
			public EGGLDELOPFF AJPDGMPCCOD(Action CJDOILFHDJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
			public BOPCDKOFDKJ(Func<JobHandle> HCMNKMDMEPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7EABD10", Offset = "0x7EAA310", VA = "0x187EABD10")]
			public void JNJJALJCEOA(Action NFMHOLEDHLG, Action KBDEEKGLHII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7EABB80", Offset = "0x7EAA180", VA = "0x187EABB80")]
			public void BAFGFGCDOJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class EIOHJEOHHKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public EGGLDELOPFF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public EIOHJEOHHKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7EB1590", Offset = "0x7EAFB90", VA = "0x187EB1590")]
			internal bool MANAECAPOII(BOPCDKOFDKJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ECKAIOCAOPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public BOPCDKOFDKJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public ECKAIOCAOPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7EB1430", Offset = "0x7EAFA30", VA = "0x187EB1430")]
			internal void KKDBJIJKKJI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<BOPCDKOFDKJ> OOLLDDKFAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<BOPCDKOFDKJ> BHOBNLECENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private LLKKGNCPLNM LJEPLPJAHNJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public PGOHBFGDPOP HNDGOIHIKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6AE0", Offset = "0x7EB50E0", VA = "0x187EB6AE0")]
		public EGGLDELOPFF Add(Func<JobHandle> HCMNKMDMEPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6E10", Offset = "0x7EB5410", VA = "0x187EB6E10")]
		public void Remove(EGGLDELOPFF JNHDFACBLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6C40", Offset = "0x7EB5240", VA = "0x187EB6C40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6FF0", Offset = "0x7EB55F0", VA = "0x187EB6FF0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7250", Offset = "0x7EB5850", VA = "0x187EB7250")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7EB6C30", Offset = "0x7EB5230", VA = "0x187EB6C30")]
		[CompilerGenerated]
		private void IONLMDOGHFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KHKECDJOKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHKECDJOKAL FBEHJKFLHBA(Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHKECDJOKAL MOAJHDBDDEH(Action CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KHKECDJOKAL AJPDGMPCCOD(Action CJDOILFHDJI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, ODGGGLKDEEB
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class MHBFGBIDHHG : KHKECDJOKAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle MDHNPCJLOOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action DPIHBLNNBKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action KIBPLDEABEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action EJDAJFBPIFP;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool LKLEAPMLHCO
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7EB85B0", Offset = "0x7EB6BB0", VA = "0x187EB85B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x75FDA30", Offset = "0x75FC030", VA = "0x1875FDA30", Slot = "4")]
			public KHKECDJOKAL FBEHJKFLHBA(Action CJDOILFHDJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x75FEAD0", Offset = "0x75FD0D0", VA = "0x1875FEAD0", Slot = "5")]
			public KHKECDJOKAL MOAJHDBDDEH(Action CJDOILFHDJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x782CE10", Offset = "0x782B410", VA = "0x18782CE10", Slot = "6")]
			public KHKECDJOKAL AJPDGMPCCOD(Action CJDOILFHDJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1017A90", Offset = "0x1016090", VA = "0x181017A90")]
			public MHBFGBIDHHG(JobHandle KAMDFDCHIIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7EB8560", Offset = "0x7EB6B60", VA = "0x187EB8560")]
			public void EMDPKKLLFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7EB8510", Offset = "0x7EB6B10", VA = "0x187EB8510")]
			public void BAFGFGCDOJB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<MHBFGBIDHHG> PIGPAFHBEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> OOCDPGNCEDN;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OJHFDJNPBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7830", Offset = "0x7EB5E30", VA = "0x187EB7830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x15A8250", Offset = "0x15A6850", VA = "0x1815A8250")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7330", Offset = "0x7EB5930", VA = "0x187EB7330")]
		public KHKECDJOKAL Add(JobHandle KAMDFDCHIIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7A40", Offset = "0x7EB6040", VA = "0x187EB7A40")]
		public void Remove(KHKECDJOKAL JNHDFACBLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7650", Offset = "0x7EB5C50", VA = "0x187EB7650")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7EB74A0", Offset = "0x7EB5AA0", VA = "0x187EB74A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7EB73D0", Offset = "0x7EB59D0", VA = "0x187EB73D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7EB7B40", Offset = "0x7EB6140", VA = "0x187EB7B40")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA71DD0", Offset = "0xA703D0", VA = "0x180A71DD0", Slot = "6")]
		private bool HIIIPJGJLMB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1950", Offset = "0x7EBFF50", VA = "0x187EC1950")]
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
