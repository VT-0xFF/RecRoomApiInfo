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
				[Cpp2IlInjected.Address(RVA = "0x5F1FAB0", Offset = "0x5F1E4B0", VA = "0x185F1FAB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x13E2220", Offset = "0x13E0C20", VA = "0x1813E2220")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FA70", Offset = "0x5F1E470", VA = "0x185F1FA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F16B70", Offset = "0x5F15570", VA = "0x185F16B70")]
		public LODSettings PKAJKBPEOLH(LDMFHDIDKEI GGLFIAJMIFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F16AB0", Offset = "0x5F154B0", VA = "0x185F16AB0")]
		public int AONEJANFJEB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F16AD0", Offset = "0x5F154D0", VA = "0x185F16AD0")]
		public int GANFAMHGHEH(bool ONPGNHKLINP, Vector3 HCKBPLFMEOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F16B80", Offset = "0x5F15580", VA = "0x185F16B80")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MFANBCGCFMM
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
public interface OJHGMIIMGDG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMEJPLFCIDM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HAPEDBHEFEL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DLAACHHJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JAKKICBGNNI> NEOBHIDFCOC
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
	void UpdateClusterDistances(Vector3 AAMPHNBHBHG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(INOACAGDLJE EGDKIFALJBD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JAKKICBGNNI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EOJAAEJPGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JGPPCDPFJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NMEHNGLMFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OIGAPLBHOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte LEFLOAEABHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BOPAPIGPMKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FMIJHPNMNPF
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
	private struct ACEAPCMHFIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BOPAPIGPMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F0FD00", Offset = "0x5F0E700", VA = "0x185F0FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F10490", Offset = "0x5F0EE90", VA = "0x185F10490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KCKKMPAPAJG : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BOPAPIGPMKO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public KCKKMPAPAJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F1CA20", Offset = "0x5F1B420", VA = "0x185F1CA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F1CAA0", Offset = "0x5F1B4A0", VA = "0x185F1CAA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BKKNMHGIGJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BOPAPIGPMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5F11990", Offset = "0x5F10390", VA = "0x185F11990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5F131D0", Offset = "0x5F11BD0", VA = "0x185F131D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OBIJKIGENHB : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FLFEOAPLLLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public BOPAPIGPMKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public OBIJKIGENHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1FCE0", Offset = "0x5F1E6E0", VA = "0x185F1FCE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F209C0", Offset = "0x5F1F3C0", VA = "0x185F209C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FAKMKFMAJPM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NCJHPIPGOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer OJFCGGDOJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter HAMOCLINIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OBDFINHNOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject EJMPEEBHLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IHFIKAKKGLI MEKFCDAAPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<INOACAGDLJE> EDHKNPAGLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<INOACAGDLJE> MNCJPOAHPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<INOACAGDLJE> MNCKNIHKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KMADFMNLKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FMIJHPNMNPF BJLLHGIFFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<HAPEDBHEFEL>[] AMGBCLEKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<JAKKICBGNNI>[] BOIDEHGPECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource ACNBJGCIKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool JLOKHLHKPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private DHBMNMGGJAH FJHFPEOKLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DHBMNMGGJAH IGCOOIBOAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int LPDDOJKCIFI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BOPAPIGPMKO CELOHIPLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LHLIHOKGJBG JGEJKKNCFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CHOHOOHMEBJ CABCOCHBJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour FMAJICPOCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material LCEBFAPGNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<OJHGMIIMGDG> KFJLMCOPGJF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig JCHENDLLKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 NEIJOIHKEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B9260", Offset = "0x7B7C60", VA = "0x1807B9260")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EC0", Offset = "0x7B78C0", VA = "0x1807B8EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private FMIJHPNMNPF OOAPJCOHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA29FE0", Offset = "0xA289E0", VA = "0x180A29FE0")]
		get
		{
			return default(FMIJHPNMNPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F14130", Offset = "0x5F12B30", VA = "0x185F14130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BOPAPIGPMKO MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F13A80", Offset = "0x5F12480", VA = "0x185F13A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool HANKGAJOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F13980", Offset = "0x5F12380", VA = "0x185F13980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool DFBHMCGPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F137B0", Offset = "0x5F121B0", VA = "0x185F137B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> JFCLOGJCOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F14F50", Offset = "0x5F13950", VA = "0x185F14F50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F132E0", Offset = "0x5F11CE0", VA = "0x185F132E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DFOGLKCFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F13230", Offset = "0x5F11C30", VA = "0x185F13230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F14260", Offset = "0x5F12C60", VA = "0x185F14260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F15D10", Offset = "0x5F14710", VA = "0x185F15D10")]
	public BOPAPIGPMKO(LHLIHOKGJBG JGEJKKNCFLG, CHOHOOHMEBJ CABCOCHBJKJ, ClusterLODConfig HOLCBCJMIFE, MonoBehaviour FMAJICPOCHN, Material LCEBFAPGNGJ, ClusterMeshRenderer OJFCGGDOJJK, MeshFilter HAMOCLINIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F13870", Offset = "0x5F12270", VA = "0x185F13870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F14620", Offset = "0x5F13020", VA = "0x185F14620")]
	public static void IDAIGGNAHDL(Vector3 ICICGMICBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F13600", Offset = "0x5F12000", VA = "0x185F13600")]
	private void BOFDHOHKHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F15350", Offset = "0x5F13D50", VA = "0x185F15350")]
	private void PGOHHCLANGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F15200", Offset = "0x5F13C00", VA = "0x185F15200")]
	private void OLEJJHLBLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F13AD0", Offset = "0x5F124D0", VA = "0x185F13AD0")]
	public void ENLJLJPGENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F13690", Offset = "0x5F12090", VA = "0x185F13690")]
	[AsyncStateMachine(typeof(ACEAPCMHFIO))]
	public Task CIKCDEDFNEK(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F14AF0", Offset = "0x5F134F0", VA = "0x185F14AF0")]
	[IteratorStateMachine(typeof(KCKKMPAPAJG))]
	private IEnumerator<FLFEOAPLLLI> KLCDMJFJFEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F13460", Offset = "0x5F11E60", VA = "0x185F13460")]
	[AsyncStateMachine(typeof(BKKNMHGIGJE))]
	private Task BDPJPIPBJKJ(NKOLFLIKMKN<string>.JNCJJIKLGBC GPFIAGBMMMI, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F14890", Offset = "0x5F13290", VA = "0x185F14890")]
	public void JGBEHFPJPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F15420", Offset = "0x5F13E20", VA = "0x185F15420")]
	public void PMONNBLJJOB(IEnumerable<HAPEDBHEFEL> PAJFNBCHGME, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F14BD0", Offset = "0x5F135D0", VA = "0x185F14BD0")]
	public void MANNIOFBJOA(IEnumerable<HAPEDBHEFEL> PAJFNBCHGME, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F154A0", Offset = "0x5F13EA0", VA = "0x185F154A0")]
	public List<ClusterMeshRenderer> PPGJNNJJEKF(List<INOACAGDLJE> GBJCJNJDMGG, KELDHIPLCLM LMAHFBOHCNI, MFANBCGCFMM PKGEMGAKJLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F14A90", Offset = "0x5F13490", VA = "0x185F14A90")]
	public void KEBKODDABCM(OJHGMIIMGDG PECAFACIFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F14310", Offset = "0x5F12D10", VA = "0x185F14310")]
	public bool GPAOMIEHMBF(OJHGMIIMGDG PECAFACIFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F14B70", Offset = "0x5F13570", VA = "0x185F14B70")]
	public void LMJNPHPAFHA(INOACAGDLJE ADIBHNLIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F13580", Offset = "0x5F11F80", VA = "0x185F13580")]
	public void BHENFCHEIBB(JAKKICBGNNI CBJFHHJLIDF, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F14ED0", Offset = "0x5F138D0", VA = "0x185F14ED0")]
	public void MBGIGLJLFLC(JAKKICBGNNI CBJFHHJLIDF, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F144D0", Offset = "0x5F12ED0", VA = "0x185F144D0")]
	private void HLEOGOMPBHD(Vector3 AAMPHNBHBHG, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F14370", Offset = "0x5F12D70", VA = "0x185F14370")]
	private void HJDNNLBDGMH(Vector3 AAMPHNBHBHG, MFANBCGCFMM PKGEMGAKJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F133A0", Offset = "0x5F11DA0", VA = "0x185F133A0")]
	[IteratorStateMachine(typeof(OBIJKIGENHB))]
	private IEnumerator<FLFEOAPLLLI> AODLIPGAJMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F14720", Offset = "0x5F13120", VA = "0x185F14720")]
	private int IJEDOBCAFAI(int OJANCMLFDOJ, int FHIKENJBIKM, List<JAKKICBGNNI> PMBPFGHKCOC, byte GGLFIAJMIFD, int MMICDANNGLB, float DIDEJEMDJKC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F15010", Offset = "0x5F13A10", VA = "0x185F15010")]
	public void NJHEJNEGCKN(INOACAGDLJE EGDKIFALJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F151C0", Offset = "0x5F13BC0", VA = "0x185F151C0")]
	public bool NKLLLBHIBCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FC970", Offset = "0x7FB370", VA = "0x1807FC970")]
	public Material CBLLFMHMAIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F13420", Offset = "0x5F11E20", VA = "0x185F13420")]
	public int AONEJANFJEB()
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct INCMCNPPDON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> PAOJFKHEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> BHCGBLDJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> DLLOEOAAHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> NIBOJJINGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> KGHMEIOIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> ANAABAEHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 HCCLJJIJHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float FKNKPMMFFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> GDLKNOPNKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> HLLIPCKHOOG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AE50", Offset = "0x5F19850", VA = "0x185F1AE50")]
	public INCMCNPPDON(INDDBAPPCEM PCJADICJELP, NativeList<float3> ANAABAEHPHP, NativeParallelMultiHashMap<int, int> GDLKNOPNKCI, NativeArray<int> HLLIPCKHOOG, Vector3 HCCLJJIJHEN, float FKNKPMMFFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A750", Offset = "0x5F19150", VA = "0x185F1A750")]
	private int DLJICMKGJLG(float3 AAMPHNBHBHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F1ABE0", Offset = "0x5F195E0", VA = "0x185F1ABE0")]
	private int ICDBMNBNFIK(int CCNHOKJIGCD, int KCGLPAPOILB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A7B0", Offset = "0x5F191B0", VA = "0x185F1A7B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EFPKJNGFEAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> GDLKNOPNKCI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> HLLIPCKHOOG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int PNJDIDJFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> MOAFNMOIGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F18180", Offset = "0x5F16B80", VA = "0x185F18180")]
	public void EPGLAEIGFDP(int FIFBHKJHCEF, Allocator FNHHOCKOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F180A0", Offset = "0x5F16AA0", VA = "0x185F180A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public EFPKJNGFEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HNBLPEIJKKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> JMNLCKPLCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> FCDGJOJNCLP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F19BD0", Offset = "0x5F185D0", VA = "0x185F19BD0")]
	public HNBLPEIJKKL(EFPKJNGFEAN LHIJNIDMJLK, INDDBAPPCEM PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F19B20", Offset = "0x5F18520", VA = "0x185F19B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PMKFNMDLIKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> NDEMHJPHDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> BNIDFGHMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> PNKHOFOKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> FBGOODLOJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> ILBEPKLGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> MOAFNMOIGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> JMNLCKPLCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> EADCMKIPELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> LGLFIAEDMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> KOFPGOALMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> FLGGPPICBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> FCDKDGBCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> EFIHKPKEEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float EENBGIJHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float NLLABKKEDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 MELGODBDNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float EMFOBMJODDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float OKJBMMHNHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float KHEIIGEIBGI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F225B0", Offset = "0x5F20FB0", VA = "0x185F225B0")]
	public PMKFNMDLIKM(EFPKJNGFEAN JMOEEOKOBEE, INDDBAPPCEM PCJADICJELP, INDDBAPPCEM DNJHOANGOJI, float OKJBMMHNHHO, float KHEIIGEIBGI, Vector3 MELGODBDNNJ, float EMFOBMJODDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F21D10", Offset = "0x5F20710", VA = "0x185F21D10")]
	private float3 INEHEINLAKJ(int CCNHOKJIGCD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F223D0", Offset = "0x5F20DD0", VA = "0x185F223D0")]
	private void PHLIGFPHPMF(int CCNHOKJIGCD, [Out] float3 OGKMMFGGKMG, [Out] float3 FFKFIBMMJGD, [Out] float4 BJCOBGIHJJO, [Out] float4 EJHJLJMCPHE, [Out] float2 AGLNMILPDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F220E0", Offset = "0x5F20AE0", VA = "0x185F220E0")]
	private int ODOOIMNCAGE(int HHHALBBCNLG, int EKLGIIPJPPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F219C0", Offset = "0x5F203C0", VA = "0x185F219C0")]
	private void IIDDOAHJOMK(int HHHALBBCNLG, int EKLGIIPJPPN, int EGEDDIDLEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F21BC0", Offset = "0x5F205C0", VA = "0x185F21BC0")]
	private bool IINCLIIJPPC(int HHHALBBCNLG, int EKLGIIPJPPN, float NDIOBKBPJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F22020", Offset = "0x5F20A20", VA = "0x185F22020")]
	private bool MJCHLECDKPN(int HHHALBBCNLG, int EKLGIIPJPPN, int EGEDDIDLEMH, float NDIOBKBPJFO, bool EBJFJPNHGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F21DC0", Offset = "0x5F207C0", VA = "0x185F21DC0")]
	private bool KFFAFNMMECC(int HHHALBBCNLG, int EKLGIIPJPPN, int EGEDDIDLEMH, float NDIOBKBPJFO, bool EBJFJPNHGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F219A0", Offset = "0x5F203A0", VA = "0x185F219A0")]
	private void FHIGHIKCHPH(int HHHALBBCNLG, int EKLGIIPJPPN, int EGEDDIDLEMH, [Out] int OLHCMLFEIMG, [Out] int JICCONOHGAI, [Out] int NOFNMOJAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F21020", Offset = "0x5F1FA20", VA = "0x185F21020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GEKCPDPMOJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class INDCMMJCBFD : IDisposable, JAKKICBGNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds PJHMBCNPEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<INOACAGDLJE> GBJCJNJDMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 PPMGHCFENCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 AFFMMJGNPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int APGCCLAIDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public INDDBAPPCEM POFLBHHODKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EFPKJNGFEAN LAGMFDCCAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform LMAHFBOHCNI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int MBDKDCPDGND
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5F1AF30", Offset = "0x5F19930", VA = "0x185F1AF30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh HADAAGMPBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh LDDOKOPOIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A9430", Offset = "0x7A7E30", VA = "0x1807A9430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NMEHNGLMFGA
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1087250", Offset = "0x1085C50", VA = "0x181087250", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x55CF1E0", Offset = "0x55CDBE0", VA = "0x1855CF1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte LEFLOAEABHO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCFB610", Offset = "0xCFA010", VA = "0x180CFB610")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCF8870", Offset = "0xCF7270", VA = "0x180CF8870", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int EOJAAEJPGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9B30E0", Offset = "0x9B1AE0", VA = "0x1809B30E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C30", Offset = "0x9B1630", VA = "0x1809B2C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int JGPPCDPFJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCB87F0", Offset = "0xCB71F0", VA = "0x180CB87F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCB74B0", Offset = "0xCB5EB0", VA = "0x180CB74B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float OIGAPLBHOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5F1AF10", Offset = "0x5F19910", VA = "0x185F1AF10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B420", Offset = "0x5F19E20", VA = "0x185F1B420")]
		public void MBIBMNFJEEE(LDMFHDIDKEI GGLFIAJMIFD, [Out] int COOBDEHLEOH, [Out] int OMBMJGHHAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B000", Offset = "0x5F19A00", VA = "0x185F1B000")]
		public void DPBDHALBJNH(LDMFHDIDKEI GGLFIAJMIFD, MNPEKFKOHDI DCOGAPHOCJI, int IIDILGDJBJD = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B380", Offset = "0x5F19D80", VA = "0x185F1B380")]
		public void FIBLJDBJHJL(Mesh PCJADICJELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1AF70", Offset = "0x5F19970", VA = "0x185F1AF70")]
		public void DOKDKEHBADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B1D0", Offset = "0x5F19BD0", VA = "0x185F1B1D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B690", Offset = "0x5F1A090", VA = "0x185F1B690")]
		public INDCMMJCBFD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds PJHMBCNPEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<INDCMMJCBFD> LDIEGCIAPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public BAIDGHKAMBO FAPJEHNPKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer DALJKEMOJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int AGAGKGJOEPH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh FGEFIKKOOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IFKFICFFMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF40", Offset = "0x7FC940", VA = "0x1807FDF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA40", Offset = "0x7FC440", VA = "0x1807FDA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DLAACHHJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F19510", Offset = "0x5F17F10", VA = "0x185F19510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5F18B70", Offset = "0x5F17570", VA = "0x185F18B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F19320", Offset = "0x5F17D20", VA = "0x185F19320")]
	public int JBJFOOFBDAN(int BBAEMFNBLLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5F197D0", Offset = "0x5F181D0", VA = "0x185F197D0")]
	public void PCGAOFFIFHC(IIEDPHGODOG LLKCCJMLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F183E0", Offset = "0x5F16DE0", VA = "0x185F183E0")]
	public void CCEEGPEBLMH(Transform LIGDJMDPDAF, bool JNIELDBFPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F19350", Offset = "0x5F17D50", VA = "0x185F19350")]
	public bool KNNLNAFKIAD(bool ECLFIKIEOBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F18CF0", Offset = "0x5F176F0", VA = "0x185F18CF0")]
	public void FIHOCFENPDL(Transform LMAHFBOHCNI, bool JNIELDBFPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F19560", Offset = "0x5F17F60", VA = "0x185F19560")]
	public bool NJHEJNEGCKN(INOACAGDLJE EGDKIFALJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F199B0", Offset = "0x5F183B0", VA = "0x185F199B0")]
	public GEKCPDPMOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IHFIKAKKGLI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<GEKCPDPMOJF.INDCMMJCBFD> IILIOBCHCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LCMJOANHHPL ILCGDDJOKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<GEKCPDPMOJF.INDCMMJCBFD> MOGAGHFALGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int CCMJOLPMBDH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5F19DD0", Offset = "0x5F187D0", VA = "0x185F19DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A3D0", Offset = "0x5F18DD0", VA = "0x185F1A3D0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5F19E50", Offset = "0x5F18850", VA = "0x185F19E50")]
	public void FLOHBAGDPJC(GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO, Transform LMAHFBOHCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A1F0", Offset = "0x5F18BF0", VA = "0x185F1A1F0")]
	public void NJHEJNEGCKN(GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F19C20", Offset = "0x5F18620", VA = "0x185F19C20")]
	private GEKCPDPMOJF.INDCMMJCBFD BOJKMPJNECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A450", Offset = "0x5F18E50", VA = "0x185F1A450")]
	private bool ONHNNBAKCFI(GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F19F10", Offset = "0x5F18910", VA = "0x185F19F10")]
	private void GEDOKJIJHCA(GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A4F0", Offset = "0x5F18EF0", VA = "0x185F1A4F0")]
	public bool PKCFCOEDCOC(GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F19F70", Offset = "0x5F18970", VA = "0x185F19F70")]
	public bool JPBFJKJIHMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F19D60", Offset = "0x5F18760", VA = "0x185F19D60")]
	private GEKCPDPMOJF.INDCMMJCBFD DOEFJJLBIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A520", Offset = "0x5F18F20", VA = "0x185F1A520")]
	public IHFIKAKKGLI()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OCELEECJKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int EEILLFONCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int LGPFEKLIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float JBCAMNILPOC;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<GEKCPDPMOJF> BCPOBAHPCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F20FC0", Offset = "0x5F1F9C0", VA = "0x185F20FC0")]
	public OCELEECJKFD(int EEILLFONCNA, int LGPFEKLIPGD, float FGAOIKNGEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F20AC0", Offset = "0x5F1F4C0", VA = "0x185F20AC0")]
	public void JMFGEBHOKJB(BAKCCLDKPDO DPDOJGKJIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5F20A10", Offset = "0x5F1F410", VA = "0x185F20A10")]
	private int JGMFKHFBKLB(IIEDPHGODOG JACJPEOECBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F20B70", Offset = "0x5F1F570", VA = "0x185F20B70")]
	private void JMFGEBHOKJB(IIEDPHGODOG JACJPEOECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5F20D80", Offset = "0x5F1F780", VA = "0x185F20D80")]
	private void OPNLJJENNLI(IIEDPHGODOG JACJPEOECBN, GEKCPDPMOJF HNBAKGPAHAJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HAPEDBHEFEL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MGLMIHGGODN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x93FD90", Offset = "0x93E790", VA = "0x18093FD90")]
			[DebuggerHidden]
			public MGLMIHGGODN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FAD0", Offset = "0x5F1E4D0", VA = "0x185F1FAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FC90", Offset = "0x5F1E690", VA = "0x185F1FC90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FBE0", Offset = "0x5F1E5E0", VA = "0x185F1FBE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FBE0", Offset = "0x5F1E5E0", VA = "0x185F1FBE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int DLAACHHJFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5F18040", Offset = "0x5F16A40", VA = "0x185F18040", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<JAKKICBGNNI> NEOBHIDFCOC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5F18020", Offset = "0x5F16A20", VA = "0x185F18020", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> LDIEGCIAPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public GEKCPDPMOJF FGEFIKKOOCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MFANBCGCFMM PMIFDPHGHAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B1080", Offset = "0x7AFA80", VA = "0x1807B1080", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(MFANBCGCFMM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B0930", Offset = "0x7AF330", VA = "0x1807B0930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool DFOEJGMCGIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1839520", Offset = "0x1837F20", VA = "0x181839520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F16BE0", Offset = "0x5F155E0", VA = "0x185F16BE0")]
		public static ClusterMeshRenderer Create(GEKCPDPMOJF PCJADICJELP, ClusterMeshRenderer OJFCGGDOJJK, MeshFilter HAMOCLINIFI, KELDHIPLCLM LMAHFBOHCNI, MFANBCGCFMM PKGEMGAKJLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5F16D50", Offset = "0x5F15750", VA = "0x185F16D50", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5F175A0", Offset = "0x5F15FA0", VA = "0x185F175A0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(INOACAGDLJE EGDKIFALJBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5F17350", Offset = "0x5F15D50", VA = "0x185F17350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F16FC0", Offset = "0x5F159C0", VA = "0x185F16FC0")]
		public void Init(GEKCPDPMOJF PCJADICJELP, MeshFilter HAMOCLINIFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F16DB0", Offset = "0x5F157B0", VA = "0x185F16DB0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F17660", Offset = "0x5F16060", VA = "0x185F17660", Slot = "7")]
		public void UpdateClusterDistances(Vector3 AAMPHNBHBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F17910", Offset = "0x5F16310", VA = "0x185F17910", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F16F40", Offset = "0x5F15940", VA = "0x185F16F40")]
		[IteratorStateMachine(typeof(MGLMIHGGODN))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5F173E0", Offset = "0x5F15DE0", VA = "0x185F173E0")]
		public void SetupTagAndLayer(string OIDBKFFEAFB, int PKGEMGAKJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F173C0", Offset = "0x5F15DC0", VA = "0x185F173C0")]
		public bool Remove(INOACAGDLJE EGDKIFALJBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IGOLKEFPMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int DDEJPBHNFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int DAGOHCNFGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int OMBMJGHHAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int COOBDEHLEOH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F19C00", Offset = "0x5F18600", VA = "0x185F19C00")]
	public IGOLKEFPMEK(int DAGOHCNFGEF, int OMBMJGHHAON, int DDEJPBHNFII, int COOBDEHLEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BAIDGHKAMBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> MOAFNMOIGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> KGHMEIOIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<IGOLKEFPMEK> DMGBGHKPIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> BLPKMDILGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> BMFHPBIJPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> LNKIOAAGIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle HFPNAGFOPLB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MANBOABLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAB1900", Offset = "0xAB0300", VA = "0x180AB1900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC8BD40", Offset = "0xC8A740", VA = "0x180C8BD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F10A60", Offset = "0x5F0F460", VA = "0x185F10A60")]
	public void OHCMDEDMAIL(INDDBAPPCEM JGGMPFDFHKF, NativeList<IGOLKEFPMEK> DMGBGHKPIAN, float CMIJAKFGAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F104F0", Offset = "0x5F0EEF0", VA = "0x185F104F0")]
	public void ACJNHLJCCAK(Transform LMAHFBOHCNI, bool JNIELDBFPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F10890", Offset = "0x5F0F290", VA = "0x185F10890")]
	public void KNNLNAFKIAD(GEKCPDPMOJF DALJKEMOJLO, bool ECLFIKIEOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F10780", Offset = "0x5F0F180", VA = "0x185F10780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F10A30", Offset = "0x5F0F430", VA = "0x185F10A30")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public BAIDGHKAMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CCPMHGOBECF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> MOAFNMOIGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<IGOLKEFPMEK> EHIHGPIMGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> BLPKMDILGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 MELGODBDNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> BMFHPBIJPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> LNKIOAAGIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool JNIELDBFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float GKOAGKPMHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float AKJFLMELNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float PJAODIHKBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> KGHMEIOIKFD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F169E0", Offset = "0x5F153E0", VA = "0x185F169E0")]
	public CCPMHGOBECF(BAIDGHKAMBO EANPNLOIDNO, Vector3 MELGODBDNNJ, bool JNIELDBFPAD, float GKOAGKPMHBI, float AKJFLMELNGK, float PJAODIHKBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F164D0", Offset = "0x5F14ED0", VA = "0x185F164D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface INOACAGDLJE : ODBDAGKGKIO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds GNFLADPDPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIEDPHGODOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<INOACAGDLJE> GBJCJNJDMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public IIEDPHGODOG BBCCHMIJNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public IIEDPHGODOG HOKBKPHLHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public IIEDPHGODOG HHNIHCHKMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int COOBDEHLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds PJHMBCNPEAE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A6D0", Offset = "0x5F190D0", VA = "0x185F1A6D0")]
	public IIEDPHGODOG(List<INOACAGDLJE> GBJCJNJDMGG, [Optional] IIEDPHGODOG BBCCHMIJNJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BAKCCLDKPDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<IIEDPHGODOG> LLNGHMKIGJM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IIEDPHGODOG MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F118C0", Offset = "0x5F102C0", VA = "0x185F118C0")]
	public BAKCCLDKPDO(IIEDPHGODOG LMAHFBOHCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KLMPMIMGBPL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MDGNCHHBHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DHJCOAOPFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int PFKHHLIBMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LHGGIJJJFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JDHFCLNLEKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FOJFONLOAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int FJKFFPIPFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float NJOCBPDFBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<INOACAGDLJE> GBJCJNJDMGG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum EDEMGEBBNNL
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private MDGNCHHBHMA EFOFJAEKKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int LEAHJDEOODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int EEILLFONCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int LGPFEKLIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float FGAOIKNGEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float LNIKENFBKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<IIEDPHGODOG> CHONKMDIJCC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BAKCCLDKPDO EKPPAMDCHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E490", Offset = "0x5F1CE90", VA = "0x185F1E490")]
	public KLMPMIMGBPL(int EEILLFONCNA, int LGPFEKLIPGD, float FGAOIKNGEOL, int LEAHJDEOODC, float LNIKENFBKDE = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F1D680", Offset = "0x5F1C080", VA = "0x185F1D680")]
	public void CMAEPHFHLLH(List<INOACAGDLJE> GBJCJNJDMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F1D850", Offset = "0x5F1C250", VA = "0x185F1D850")]
	public bool FIFFMBAEAPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F1CB10", Offset = "0x5F1B510", VA = "0x185F1CB10")]
	private float AFIGMIIAKIE(Vector3 GKNDKBGCHOD, Vector3 OGPILMIPJDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5F1CAF0", Offset = "0x5F1B4F0", VA = "0x185F1CAF0")]
	private float AFIGMIIAKIE(Vector3 BFFGCOIILMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F1DCC0", Offset = "0x5F1C6C0", VA = "0x185F1DCC0")]
	private bool MLJCKDEDNCF(IIEDPHGODOG CFEOCCMMBCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F1CB60", Offset = "0x5F1B560", VA = "0x185F1CB60")]
	private FOJFONLOAOP CJGPAABEKGC(List<INOACAGDLJE> GJKEEAHBJHO, EDEMGEBBNNL CJHDBNANIHI)
	{
		return default(FOJFONLOAOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F1D8C0", Offset = "0x5F1C2C0", VA = "0x185F1D8C0")]
	private void HDEGAGCNOHA(List<INOACAGDLJE> GBJCJNJDMGG, Vector3[] BKJDBBFBJAP, Vector3[] MLBNALJEIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KNCDGKKCKLG
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E6C0", Offset = "0x5F1D0C0", VA = "0x185F1E6C0")]
	public static Bounds KABDCAKJGGO(List<INOACAGDLJE> GBJCJNJDMGG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E4F0", Offset = "0x5F1CEF0", VA = "0x185F1E4F0")]
	public static int BKLMJIMHPDK(List<INOACAGDLJE> GBJCJNJDMGG, LDMFHDIDKEI GGLFIAJMIFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LCMJOANHHPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private INDDBAPPCEM AKCFOINBIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private INDDBAPPCEM GEDDDFKDEEE;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static INDDBAPPCEM DEPEEOGACDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private DKGFHPPPJBM LNJFJMOALMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MNPEKFKOHDI DCOGAPHOCJI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle HFPNAGFOPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C094C0", Offset = "0x1C07EC0", VA = "0x181C094C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GEKCPDPMOJF.INDCMMJCBFD CFEOCCMMBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool ELLGMPAFDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x50E17B0", Offset = "0x50E01B0", VA = "0x1850E17B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E900", Offset = "0x5F1D300", VA = "0x185F1E900")]
	[LHNJPKEFJFF(KMDAJMKLPFP.ExitingPlayMode, 0)]
	private static void ICKGEEDBCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F030", Offset = "0x5F1DA30", VA = "0x185F1F030")]
	public void OHCMDEDMAIL(GEKCPDPMOJF.INDCMMJCBFD EHIHGPIMGBJ, Transform NHJDBOBDHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E980", Offset = "0x5F1D380", VA = "0x185F1E980")]
	public void LENHDJNMIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E890", Offset = "0x5F1D290", VA = "0x185F1E890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5F1EFF0", Offset = "0x5F1D9F0", VA = "0x185F1EFF0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F8D0", Offset = "0x5F1E2D0", VA = "0x185F1F8D0")]
	public LCMJOANHHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CHOHOOHMEBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 FLMKDLGIKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LHLIHOKGJBG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(NKOLFLIKMKN<string>.JNCJJIKLGBC GPFIAGBMMMI, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JCFKIFJLMOB
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCFKIFJLMOB LFOKNACBGIL(Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCFKIFJLMOB ILCNMKBPOFC(Action MCLCEMNNOFC);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class JNBHNJOFHPH : JCFKIFJLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class LKIBDMJAPIM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public JNBHNJOFHPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public LKIBDMJAPIM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5F1F9D0", Offset = "0x5F1E3D0", VA = "0x185F1F9D0")]
				internal void IAIOIPJGIFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5F1F980", Offset = "0x5F1E380", VA = "0x185F1F980")]
				internal void CCDECDFKAHP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x5F1FA20", Offset = "0x5F1E420", VA = "0x185F1FA20")]
				internal void KEEACDNMCHJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> LACINKOHGNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action NMGDJEMNDCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action GMIKBODLJKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private EMFGCEGBJAG KDBIHHMDKLD;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JOGBOAJFNGB
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action CBDCJEKLFNE
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x37344E0", Offset = "0x3732EE0", VA = "0x1837344E0", Slot = "4")]
			public JCFKIFJLMOB LFOKNACBGIL(Action MCLCEMNNOFC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x59F76E0", Offset = "0x59F60E0", VA = "0x1859F76E0", Slot = "5")]
			public JCFKIFJLMOB ILCNMKBPOFC(Action MCLCEMNNOFC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
			public JNBHNJOFHPH(Func<JobHandle> FCEPANDPBFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5F1B920", Offset = "0x5F1A320", VA = "0x185F1B920")]
			public void OLPPMELFJKG(Action HKLJFCJMAJP, Action ANBOGHAGFMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5F1B790", Offset = "0x5F1A190", VA = "0x185F1B790")]
			public void NJHEJNEGCKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class OEHCNFHCMIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public JCFKIFJLMOB jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public OEHCNFHCMIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5F21010", Offset = "0x5F1FA10", VA = "0x185F21010")]
			internal bool PIJLEHBIJDD(JNBHNJOFHPH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class ELJHNJGJNFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JNBHNJOFHPH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public ELJHNJGJNFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5F18380", Offset = "0x5F16D80", VA = "0x185F18380")]
			internal void OJHLLOEMOHE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<JNBHNJOFHPH> NAJNABBPANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<JNBHNJOFHPH> BCDDCAFCEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DHBMNMGGJAH EPHEHMCLCDO;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AMAKEDNGPIE EENMIHIANHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F1BBE0", Offset = "0x5F1A5E0", VA = "0x185F1BBE0")]
		public JCFKIFJLMOB Add(Func<JobHandle> FCEPANDPBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5F1BF10", Offset = "0x5F1A910", VA = "0x185F1BF10")]
		public void Remove(JCFKIFJLMOB HFPNAGFOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5F1BD40", Offset = "0x5F1A740", VA = "0x185F1BD40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C0E0", Offset = "0x5F1AAE0", VA = "0x185F1C0E0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C340", Offset = "0x5F1AD40", VA = "0x185F1C340")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5F1BD30", Offset = "0x5F1A730", VA = "0x185F1BD30")]
		[CompilerGenerated]
		private void FCLGAKGDLME()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EMFGCEGBJAG
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMFGCEGBJAG LFOKNACBGIL(Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMFGCEGBJAG GELLLPAMELL(Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMFGCEGBJAG ILCNMKBPOFC(Action MCLCEMNNOFC);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class HLEPGHMCMLM : EMFGCEGBJAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle IFBNGEMDNLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action NMGDJEMNDCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action EIPLBMBDDPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action CBDCJEKLFNE;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool MEINDBODKAL
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x5F19B10", Offset = "0x5F18510", VA = "0x185F19B10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x591B260", Offset = "0x5919C60", VA = "0x18591B260", Slot = "4")]
			public EMFGCEGBJAG LFOKNACBGIL(Action MCLCEMNNOFC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x591B280", Offset = "0x5919C80", VA = "0x18591B280", Slot = "5")]
			public EMFGCEGBJAG GELLLPAMELL(Action MCLCEMNNOFC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x59F76E0", Offset = "0x59F60E0", VA = "0x1859F76E0", Slot = "6")]
			public EMFGCEGBJAG ILCNMKBPOFC(Action MCLCEMNNOFC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1AA59F0", Offset = "0x1AA43F0", VA = "0x181AA59F0")]
			public HLEPGHMCMLM(JobHandle BDDOKFMOEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5F19A70", Offset = "0x5F18470", VA = "0x185F19A70")]
			public void LAAAOIHLIFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5F19AC0", Offset = "0x5F184C0", VA = "0x185F19AC0")]
			public void NJHEJNEGCKN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<HLEPGHMCMLM> NOIJLDKIIIM;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C840", Offset = "0x5F1B240", VA = "0x185F1C840")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C420", Offset = "0x5F1AE20", VA = "0x185F1C420")]
		public EMFGCEGBJAG Add(JobHandle BDDOKFMOEJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C740", Offset = "0x5F1B140", VA = "0x185F1C740")]
		public void Remove(EMFGCEGBJAG HFPNAGFOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C590", Offset = "0x5F1AF90", VA = "0x185F1C590", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C4C0", Offset = "0x5F1AEC0", VA = "0x185F1C4C0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C980", Offset = "0x5F1B380", VA = "0x185F1C980")]
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
