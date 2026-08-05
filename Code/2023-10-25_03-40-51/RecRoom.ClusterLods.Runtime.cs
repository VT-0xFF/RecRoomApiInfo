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
				[Cpp2IlInjected.Address(RVA = "0x5BF6000", Offset = "0x5BF4E00", VA = "0x185BF6000")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x130AD80", Offset = "0x1309B80", VA = "0x18130AD80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5FC0", Offset = "0x5BF4DC0", VA = "0x185BF5FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEC110", Offset = "0x5BEAF10", VA = "0x185BEC110")]
		public LODSettings CELIDBNNAMO(FJDBGHECAMO NHLPANAJLNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC0F0", Offset = "0x5BEAEF0", VA = "0x185BEC0F0")]
		public int AGGDMGIHCMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC120", Offset = "0x5BEAF20", VA = "0x185BEC120")]
		public int JKCCMGAMNOK(bool FCKJAOINCMC, Vector3 MJNOEOENEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC1C0", Offset = "0x5BEAFC0", VA = "0x185BEC1C0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GCHBNEPDHGI
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
public interface GOBIIEHCCNL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECDLPBEBEEN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AAEIFFBPICE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ICIMAOPFDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LNDJDPFGJNJ> NIFPKPOMBAF
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
	void UpdateClusterDistances(Vector3 GMNHMHBGHKM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(GIMGJIHMDOE KDELPFFKINA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LNDJDPFGJNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int PIEIDDGAEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int AEPFENKMHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PFGDPACGIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float DJBHDBKKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte GMOKKNHCIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KOKJFHALGKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NJFOFJJFCFN
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
	private struct ADBMPIDGPNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KOKJFHALGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8370", Offset = "0x5BE7170", VA = "0x185BE8370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8B00", Offset = "0x5BE7900", VA = "0x185BE8B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FNOCCIOGHIA : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KOKJFHALGKP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public FNOCCIOGHIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BEDD90", Offset = "0x5BECB90", VA = "0x185BEDD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5BEDE10", Offset = "0x5BECC10", VA = "0x185BEDE10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BNPGOBDNCAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KOKJFHALGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA5E0", Offset = "0x5BE93E0", VA = "0x185BEA5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBE20", Offset = "0x5BEAC20", VA = "0x185BEBE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PDAOPILGIDH : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KOKJFHALGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public PDAOPILGIDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF82D0", Offset = "0x5BF70D0", VA = "0x185BF82D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8FB0", Offset = "0x5BF7DB0", VA = "0x185BF8FB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EGCGEJHOOOE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan MJNAFFHDBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer BIIGEPPCENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter NBNLLOEIENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject CFCEKBLAMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject OEMFDFKHPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public PKALDAPPIFH CEKFCJGLLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<GIMGJIHMDOE> OPBJFLDPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<GIMGJIHMDOE> GMMAACCGODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<GIMGJIHMDOE> JFMOKPIDEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int MFHAPOALEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NJFOFJJFCFN GDDEAJDPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<AAEIFFBPICE>[] BJOMFBMKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LNDJDPFGJNJ>[] CLCBPGJLNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource OIGANGAHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool LJJDEAPDFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private KFKJPENGGJI ICEIOJEJICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KFKJPENGGJI PDCNPCOFCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int IBGACEPFGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static KOKJFHALGKP FLNFHFFEHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FHJFIHFLOIE AHPENFJACNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HGLMHMKICHA DBPJIKOKPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour IKCKOGMCPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material IHDGOOMADKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<GOBIIEHCCNL> JJGFMDIJNBH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig FDMCPHNBFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 CALFOIBKEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x770440", Offset = "0x76F240", VA = "0x180770440")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76FE90", Offset = "0x76EC90", VA = "0x18076FE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private NJFOFJJFCFN AHLCIKCBGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x95F270", Offset = "0x95E070", VA = "0x18095F270")]
		get
		{
			return default(NJFOFJJFCFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BF43B0", Offset = "0x5BF31B0", VA = "0x185BF43B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KOKJFHALGKP IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3440", Offset = "0x5BF2240", VA = "0x185BF3440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool COCFBBLOMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3F00", Offset = "0x5BF2D00", VA = "0x185BF3F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MOPLEFPHFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4CC0", Offset = "0x5BF3AC0", VA = "0x185BF4CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IPFBCDFDFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF56D0", Offset = "0x5BF44D0", VA = "0x185BF56D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF49F0", Offset = "0x5BF37F0", VA = "0x185BF49F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GNHPFBGGPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4790", Offset = "0x5BF3590", VA = "0x185BF4790")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2D20", Offset = "0x5BF1B20", VA = "0x185BF2D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5800", Offset = "0x5BF4600", VA = "0x185BF5800")]
	public KOKJFHALGKP(FHJFIHFLOIE AHPENFJACNA, HGLMHMKICHA DBPJIKOKPLP, ClusterLODConfig CDMBBDBGNHK, MonoBehaviour IKCKOGMCPOK, Material IHDGOOMADKL, ClusterMeshRenderer BIIGEPPCENG, MeshFilter NBNLLOEIENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3490", Offset = "0x5BF2290", VA = "0x185BF3490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4570", Offset = "0x5BF3370", VA = "0x185BF4570")]
	public static void ILKHPDBDBMM(Vector3 NDDGADPOCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BF44E0", Offset = "0x5BF32E0", VA = "0x185BF44E0")]
	private void IGGDBACHNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5600", Offset = "0x5BF4400", VA = "0x185BF5600")]
	private void ONKEIDCIFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4200", Offset = "0x5BF3000", VA = "0x185BF4200")]
	private void HLBEEFNPOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4EA0", Offset = "0x5BF3CA0", VA = "0x185BF4EA0")]
	public void OKJPLLIFGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4670", Offset = "0x5BF3470", VA = "0x185BF4670")]
	[AsyncStateMachine(typeof(ADBMPIDGPNN))]
	public Task JEJCKJGIELB(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO, CancellationToken FJDIBEBBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BF30D0", Offset = "0x5BF1ED0", VA = "0x185BF30D0")]
	[IteratorStateMachine(typeof(FNOCCIOGHIA))]
	private IEnumerator<JHKLHFOKPOC> AEABDJLNIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4D80", Offset = "0x5BF3B80", VA = "0x185BF4D80")]
	[AsyncStateMachine(typeof(BNPGOBDNCAH))]
	private Task NEIJJJNPIGA(AEMIIEBAFHL<string>.GMENFEPMDPA HKGNFBBEDBI, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4000", Offset = "0x5BF2E00", VA = "0x185BF4000")]
	public void HIKLLFAHNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF33C0", Offset = "0x5BF21C0", VA = "0x185BF33C0")]
	public void DJHLPFGPHEG(IEnumerable<AAEIFFBPICE> APJFCGJCNJP, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2DD0", Offset = "0x5BF1BD0", VA = "0x185BF2DD0")]
	public void ACDPHJMGIKA(IEnumerable<AAEIFFBPICE> APJFCGJCNJP, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF35A0", Offset = "0x5BF23A0", VA = "0x185BF35A0")]
	public List<ClusterMeshRenderer> GCDPBEBPPHN(List<GIMGJIHMDOE> NDFBKPCIBAL, ELBMECNNJAN PHNFANHCONA, GCHBNEPDHGI EBJJLHAJJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3360", Offset = "0x5BF2160", VA = "0x185BF3360")]
	public void CPOGDDJJFAG(GOBIIEHCCNL NDNGEJIENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4350", Offset = "0x5BF3150", VA = "0x185BF4350")]
	public bool HPDFHALGHLE(GOBIIEHCCNL NDNGEJIENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4AB0", Offset = "0x5BF38B0", VA = "0x185BF4AB0")]
	public void LKELJLCNHHF(GIMGJIHMDOE GKCEBMELFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5580", Offset = "0x5BF4380", VA = "0x185BF5580")]
	public void OLFOKIEJCAG(LNDJDPFGJNJ NIKGGMJCPGD, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5500", Offset = "0x5BF4300", VA = "0x185BF5500")]
	public void OKKHODIJAMJ(LNDJDPFGJNJ NIKGGMJCPGD, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3190", Offset = "0x5BF1F90", VA = "0x185BF3190")]
	private void AKCAGCOIBHI(Vector3 GMNHMHBGHKM, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3DA0", Offset = "0x5BF2BA0", VA = "0x185BF3DA0")]
	private void GFIDBAHLPDJ(Vector3 GMNHMHBGHKM, GCHBNEPDHGI EBJJLHAJJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5BF32E0", Offset = "0x5BF20E0", VA = "0x185BF32E0")]
	[IteratorStateMachine(typeof(PDAOPILGIDH))]
	private IEnumerator<JHKLHFOKPOC> CCJNFDMFFNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4B10", Offset = "0x5BF3910", VA = "0x185BF4B10")]
	private int MOHBBBPDIBI(int OCMJNDDMDAL, int DMCLKLFHGEN, List<LNDJDPFGJNJ> CECJNHFEBMO, byte NHLPANAJLNK, int JNANPFBNFGH, float OAMDILPBICM = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4840", Offset = "0x5BF3640", VA = "0x185BF4840")]
	public void KCJHGNBNEJA(GIMGJIHMDOE KDELPFFKINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4C80", Offset = "0x5BF3A80", VA = "0x185BF4C80")]
	public bool NACODOIKJDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8111D0", Offset = "0x80FFD0", VA = "0x1808111D0")]
	public Material CMDGCHBDCAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3150", Offset = "0x5BF1F50", VA = "0x185BF3150")]
	public int AGGDMGIHCMI()
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
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct PBEJJBACHNN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> IFIFAFNFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> KLDDNBDONNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> AJFBFIKBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> KHBLKPGIINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> FMDCGMEOMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> FEIMIFBBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> PNCCIEJBGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 AFCDJKFIGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float LCGHDPDICMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> JGGHEPFEABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> DACIHKPAPEA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5BF8210", Offset = "0x5BF7010", VA = "0x185BF8210")]
	public PBEJJBACHNN(LADLLAMMHKG GIOOFAEFEGJ, NativeList<float3> PNCCIEJBGKK, NativeParallelMultiHashMap<int, int> JGGHEPFEABP, NativeArray<int> DACIHKPAPEA, Vector3 AFCDJKFIGIP, float LCGHDPDICMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5BF81B0", Offset = "0x5BF6FB0", VA = "0x185BF81B0")]
	private int KKIBOIGECBE(float3 GMNHMHBGHKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5BF7F40", Offset = "0x5BF6D40", VA = "0x185BF7F40")]
	private int JEINHCJIDHB(int NAKKFLBPDCC, int GMOPMNAPKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5BF7B10", Offset = "0x5BF6910", VA = "0x185BF7B10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KDJIJKCPODE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> JGGHEPFEABP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> DACIHKPAPEA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int GKOPDOCGKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> BDPCLKOAFLN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2A40", Offset = "0x5BF1840", VA = "0x185BF2A40")]
	public void DAFBIINNNHF(int DAEFPILNIAA, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2C40", Offset = "0x5BF1A40", VA = "0x185BF2C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KDJIJKCPODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IGMMKHHIIFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> DBFNAOEGDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> IOMGNKANCLC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5BEFF00", Offset = "0x5BEED00", VA = "0x185BEFF00")]
	public IGMMKHHIIFE(KDJIJKCPODE OFBJDNICGBI, LADLLAMMHKG GIOOFAEFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BEFE50", Offset = "0x5BEEC50", VA = "0x185BEFE50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct JFNJDGKBKHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> BAIHDDLNJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> NDLJDOELNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> CLJLJJIBKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> AJMLCLMBAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> HNFAFDKFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> BDPCLKOAFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> DBFNAOEGDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> AECDJEHFCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> GICMOFGNLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> DNKMLDEMAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> CFBDPLFNNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> LKBILBIOJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> LBLCPKKJGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float ONJFBKIJKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float FPLNNCHNECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 JLBEJHCHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float NECEBCKLEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LEOFIMLAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float HGECKMNELOA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF14C0", Offset = "0x5BF02C0", VA = "0x185BF14C0")]
	public JFNJDGKBKHN(KDJIJKCPODE MIKNLFOCAEN, LADLLAMMHKG GIOOFAEFEGJ, LADLLAMMHKG DOIMCLNBBCC, float LEOFIMLAIFO, float HGECKMNELOA, Vector3 JLBEJHCHIKF, float NECEBCKLEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0F40", Offset = "0x5BEFD40", VA = "0x185BF0F40")]
	private float3 NNEAGMAHGHA(int NAKKFLBPDCC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF12E0", Offset = "0x5BF00E0", VA = "0x185BF12E0")]
	private void PLEKOEGDMOB(int NAKKFLBPDCC, [Out] float3 PAGABLJBKKJ, [Out] float3 GALKEBDCPFJ, [Out] float4 JGBGMHKDMJL, [Out] float4 ENJBNPFGIDB, [Out] float2 BGAOLKJKOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0FF0", Offset = "0x5BEFDF0", VA = "0x185BF0FF0")]
	private int ODCOPMHHECH(int CJDFMKPCBBL, int CLDGHACEFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEFF30", Offset = "0x5BEED30", VA = "0x185BEFF30")]
	private void BAMOMDPBLIA(int CJDFMKPCBBL, int CLDGHACEFHC, int AMPDLHAEAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0DD0", Offset = "0x5BEFBD0", VA = "0x185BF0DD0")]
	private bool JEALHLIODPM(int CJDFMKPCBBL, int CLDGHACEFHC, float DGJOGPDPBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0130", Offset = "0x5BEEF30", VA = "0x185BF0130")]
	private bool CCDANNJLIFC(int CJDFMKPCBBL, int CLDGHACEFHC, int AMPDLHAEAND, float DGJOGPDPBGG, bool FIIBHBPFLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0B70", Offset = "0x5BEF970", VA = "0x185BF0B70")]
	private bool IJHGKJCIOKH(int CJDFMKPCBBL, int CLDGHACEFHC, int AMPDLHAEAND, float DGJOGPDPBGG, bool FIIBHBPFLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0F20", Offset = "0x5BEFD20", VA = "0x185BF0F20")]
	private void KKGEHJFBNCP(int CJDFMKPCBBL, int CLDGHACEFHC, int AMPDLHAEAND, [Out] int MNLAHCOBCKE, [Out] int AGMFIHHCLAP, [Out] int CLHCLFEPABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5BF01F0", Offset = "0x5BEEFF0", VA = "0x185BF01F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MKOOFFMGCGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IEFIHKAMHMG : IDisposable, LNDJDPFGJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds FIHPOMHFCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<GIMGJIHMDOE> NDFBKPCIBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 ANOGKEPNGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 NEANGAEBNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int ECEAMPHLIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LADLLAMMHKG GDBLCNKCFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KDJIJKCPODE FIEKMCLBHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform PHNFANHCONA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int GMMOICEMMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5BEFD10", Offset = "0x5BEEB10", VA = "0x185BEFD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KDENALNCKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh BBILNIDIFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PFGDPACGIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF7F110", Offset = "0xF7DF10", VA = "0x180F7F110", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x53293A0", Offset = "0x53281A0", VA = "0x1853293A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte GMOKKNHCIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA45C90", Offset = "0xA44A90", VA = "0x180A45C90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA45F70", Offset = "0xA44D70", VA = "0x180A45F70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int PIEIDDGAEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8C3CE0", Offset = "0x8C2AE0", VA = "0x1808C3CE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8C3140", Offset = "0x8C1F40", VA = "0x1808C3140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int AEPFENKMHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBF1010", Offset = "0xBEFE10", VA = "0x180BF1010", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xBEFD20", Offset = "0xBEEB20", VA = "0x180BEFD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float DJBHDBKKMOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5BEF5D0", Offset = "0x5BEE3D0", VA = "0x185BEF5D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5BEFAA0", Offset = "0x5BEE8A0", VA = "0x185BEFAA0")]
		public void NOFCKFIHPBA(FJDBGHECAMO NHLPANAJLNK, [Out] int KMIEJOGGBHG, [Out] int GPJPFNCPHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF8D0", Offset = "0x5BEE6D0", VA = "0x185BEF8D0")]
		public void MDLLBJHOECC(FJDBGHECAMO NHLPANAJLNK, FFDCHNKCGLC IPADJPEKANK, int JMCHNDOFGAC = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF7A0", Offset = "0x5BEE5A0", VA = "0x185BEF7A0")]
		public void KBMMALNJEAK(Mesh GIOOFAEFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF840", Offset = "0x5BEE640", VA = "0x185BEF840")]
		public void LCHLEKLNCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF5F0", Offset = "0x5BEE3F0", VA = "0x185BEF5F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5BEFD50", Offset = "0x5BEEB50", VA = "0x185BEFD50")]
		public IEFIHKAMHMG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds FIHPOMHFCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<IEFIHKAMHMG> EHMJPCKJDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GJGIFMIHLLG KBHKIOEEAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer IGCDHDJEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int MPAIDLLNEEO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh FMEEDFPOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KFFFAGLLPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CF0", Offset = "0x7B1AF0", VA = "0x1807B2CF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D00", Offset = "0x7B1B00", VA = "0x1807B2D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ICIMAOPFDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6B10", Offset = "0x5BF5910", VA = "0x185BF6B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6990", Offset = "0x5BF5790", VA = "0x185BF6990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6DD0", Offset = "0x5BF5BD0", VA = "0x185BF6DD0")]
	public int NFADEEDHDON(int ALBDOIKNDMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF67B0", Offset = "0x5BF55B0", VA = "0x185BF67B0")]
	public void DAINBCLJOPB(BHNBEBJLNPC LCENAOKPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6020", Offset = "0x5BF4E20", VA = "0x185BF6020")]
	public void AKIPNJPCPNK(Transform JKKGDAMPLLP, bool GBPBBGNGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6E00", Offset = "0x5BF5C00", VA = "0x185BF6E00")]
	public bool NLGJNDCINJB(bool FCPKPIPJLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6FC0", Offset = "0x5BF5DC0", VA = "0x185BF6FC0")]
	public void PHJNIFEPKPD(Transform PHNFANHCONA, bool GBPBBGNGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6B60", Offset = "0x5BF5960", VA = "0x185BF6B60")]
	public bool KCJHGNBNEJA(GIMGJIHMDOE KDELPFFKINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5BF75F0", Offset = "0x5BF63F0", VA = "0x185BF75F0")]
	public MKOOFFMGCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PKALDAPPIFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<MKOOFFMGCGM.IEFIHKAMHMG> EFNJBBMANEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private ACEMIAIIKKD DMHGOJFPMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<MKOOFFMGCGM.IEFIHKAMHMG> OIBCPGGGGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int DELGOBIHPBN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9210", Offset = "0x5BF8010", VA = "0x185BF9210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9590", Offset = "0x5BF8390", VA = "0x185BF9590")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9290", Offset = "0x5BF8090", VA = "0x185BF9290")]
	public void EJEJBLJEAIN(MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP, Transform PHNFANHCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5BF93B0", Offset = "0x5BF81B0", VA = "0x185BF93B0")]
	public void KCJHGNBNEJA(MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF90A0", Offset = "0x5BF7EA0", VA = "0x185BF90A0")]
	private MKOOFFMGCGM.IEFIHKAMHMG CBFLBMOPBLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9000", Offset = "0x5BF7E00", VA = "0x185BF9000")]
	private bool CBCFDGKAGDA(MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9350", Offset = "0x5BF8150", VA = "0x185BF9350")]
	private void KBGMMGPJNMH(MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF91E0", Offset = "0x5BF7FE0", VA = "0x185BF91E0")]
	public bool DHFPDKJMLMJ(MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9680", Offset = "0x5BF8480", VA = "0x185BF9680")]
	public bool NCDLFODJGAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9610", Offset = "0x5BF8410", VA = "0x185BF9610")]
	private MKOOFFMGCGM.IEFIHKAMHMG MPNCFOFBLCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9900", Offset = "0x5BF8700", VA = "0x185BF9900")]
	public PKALDAPPIFH()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JJCAFKJFICJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int FDPDEHOPCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int AOBBHLGFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float NDKHFLLACMA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<MKOOFFMGCGM> IFAGHLPPGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1BB0", Offset = "0x5BF09B0", VA = "0x185BF1BB0")]
	public JJCAFKJFICJ(int FDPDEHOPCON, int AOBBHLGFOBC, float HMHMNHIPHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1600", Offset = "0x5BF0400", VA = "0x185BF1600")]
	public void CDPGBADPCDL(PKPIPCFLBMN OFPNACBACLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5BF18C0", Offset = "0x5BF06C0", VA = "0x185BF18C0")]
	private int JFEAGBKEBPB(BHNBEBJLNPC AHGGOPDAOCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5BF16B0", Offset = "0x5BF04B0", VA = "0x185BF16B0")]
	private void CDPGBADPCDL(BHNBEBJLNPC AHGGOPDAOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1970", Offset = "0x5BF0770", VA = "0x185BF1970")]
	private void PJMDIHNDMFH(BHNBEBJLNPC AHGGOPDAOCA, MKOOFFMGCGM POHPJGBJGGA)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, AAEIFFBPICE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BOKKHIIFFPD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
			[DebuggerHidden]
			public BOKKHIIFFPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBE80", Offset = "0x5BEAC80", VA = "0x185BEBE80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC040", Offset = "0x5BEAE40", VA = "0x185BEC040", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBF90", Offset = "0x5BEAD90", VA = "0x185BEBF90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBF90", Offset = "0x5BEAD90", VA = "0x185BEBF90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ICIMAOPFDNP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5BED680", Offset = "0x5BEC480", VA = "0x185BED680", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<LNDJDPFGJNJ> NIFPKPOMBAF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5BED660", Offset = "0x5BEC460", VA = "0x185BED660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> EHMJPCKJDBC
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MKOOFFMGCGM FMEEDFPOPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GCHBNEPDHGI DLPEJKDMADN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x763850", Offset = "0x762650", VA = "0x180763850", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(GCHBNEPDHGI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7638B0", Offset = "0x7626B0", VA = "0x1807638B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool AGPGOMLMMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16D56D0", Offset = "0x16D44D0", VA = "0x1816D56D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC220", Offset = "0x5BEB020", VA = "0x185BEC220")]
		public static ClusterMeshRenderer Create(MKOOFFMGCGM GIOOFAEFEGJ, ClusterMeshRenderer BIIGEPPCENG, MeshFilter NBNLLOEIENH, ELBMECNNJAN PHNFANHCONA, GCHBNEPDHGI EBJJLHAJJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC390", Offset = "0x5BEB190", VA = "0x185BEC390", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BECBE0", Offset = "0x5BEB9E0", VA = "0x185BECBE0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(GIMGJIHMDOE KDELPFFKINA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC990", Offset = "0x5BEB790", VA = "0x185BEC990")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC600", Offset = "0x5BEB400", VA = "0x185BEC600")]
		public void Init(MKOOFFMGCGM GIOOFAEFEGJ, MeshFilter NBNLLOEIENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC3F0", Offset = "0x5BEB1F0", VA = "0x185BEC3F0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5BECCA0", Offset = "0x5BEBAA0", VA = "0x185BECCA0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 GMNHMHBGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5BECF50", Offset = "0x5BEBD50", VA = "0x185BECF50", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC580", Offset = "0x5BEB380", VA = "0x185BEC580")]
		[IteratorStateMachine(typeof(BOKKHIIFFPD))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5BECA20", Offset = "0x5BEB820", VA = "0x185BECA20")]
		public void SetupTagAndLayer(string MJKABCAIEKE, int EBJJLHAJJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5BECA00", Offset = "0x5BEB800", VA = "0x185BECA00")]
		public bool Remove(GIMGJIHMDOE KDELPFFKINA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EDBJIHHMCPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int DNKDAGAHJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int IJBCLDGENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int GPJPFNCPHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KMIEJOGGBHG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BED6E0", Offset = "0x5BEC4E0", VA = "0x185BED6E0")]
	public EDBJIHHMCPB(int IJBCLDGENAJ, int GPJPFNCPHIK, int DNKDAGAHJHM, int KMIEJOGGBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GJGIFMIHLLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> IFIFAFNFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> BDPCLKOAFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> FEIMIFBBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<EDBJIHHMCPB> EANGOGNHDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> EBCBPBPPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> FLOIDJHAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> NDFJKAHDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle GIFCONDMHLL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LPNKMMHJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6B480", Offset = "0xA6A280", VA = "0x180A6B480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB6FDB0", Offset = "0xB6EBB0", VA = "0x180B6FDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE5D0", Offset = "0x5BED3D0", VA = "0x185BEE5D0")]
	public void LKOIJBFKMJL(LADLLAMMHKG IIAKLMPJNFG, NativeList<EDBJIHHMCPB> EANGOGNHDFA, float KLPLLOPDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE310", Offset = "0x5BED110", VA = "0x185BEE310")]
	public void EDJPILLGGAA(Transform PHNFANHCONA, bool GBPBBGNGMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF430", Offset = "0x5BEE230", VA = "0x185BEF430")]
	public void NLGJNDCINJB(MKOOFFMGCGM IGCDHDJEOJJ, bool FCPKPIPJLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE200", Offset = "0x5BED000", VA = "0x185BEE200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE5A0", Offset = "0x5BED3A0", VA = "0x185BEE5A0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GJGIFMIHLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EICDIMDJFOI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> IFIFAFNFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> BDPCLKOAFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<EDBJIHHMCPB> BKIAFHOBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> EBCBPBPPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 JLBEJHCHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> FLOIDJHAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> NDFJKAHDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool GBPBBGNGMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float FOHFJMOIAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float IKHDMHIHMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float JCLDBKOLIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> FEIMIFBBIKL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDCC0", Offset = "0x5BECAC0", VA = "0x185BEDCC0")]
	public EICDIMDJFOI(GJGIFMIHLLG GAJFOOHOLOD, Vector3 JLBEJHCHIKF, bool GBPBBGNGMOC, float FOHFJMOIAPF, float IKHDMHIHMJD, float JCLDBKOLIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5BED7B0", Offset = "0x5BEC5B0", VA = "0x185BED7B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GIMGJIHMDOE : GNDIBBLLDJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds NOMODFOGKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BHNBEBJLNPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<GIMGJIHMDOE> NDFBKPCIBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public BHNBEBJLNPC LPDGANJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public BHNBEBJLNPC NALLAEDDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public BHNBEBJLNPC IGICLGGGNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int KMIEJOGGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds FIHPOMHFCOF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA560", Offset = "0x5BE9360", VA = "0x185BEA560")]
	public BHNBEBJLNPC(List<GIMGJIHMDOE> NDFBKPCIBAL, [Optional] BHNBEBJLNPC LPDGANJNOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PKPIPCFLBMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<BHNBEBJLNPC> NCIIKBMHIFI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BHNBEBJLNPC CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5BF9AB0", Offset = "0x5BF88B0", VA = "0x185BF9AB0")]
	public PKPIPCFLBMN(BHNBEBJLNPC PHNFANHCONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ALLMFAGNCMF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct CFGNELAKACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int LLHPNJBDHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int KACLAMFGGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LOHKPNNEEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int KFPLFPBOGOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KPPCAMBIJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int JFOKBIAIMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float AELEFDGAFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<GIMGJIHMDOE> NDFBKPCIBAL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PCALAIHOECJ
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
	private CFGNELAKACC EABMPFHOIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int IEKEGHEMFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int FDPDEHOPCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int AOBBHLGFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float HMHMNHIPHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float HPPIFEEECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<BHNBEBJLNPC> DKMBJMLNJJA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public PKPIPCFLBMN LAIHOGMLBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA500", Offset = "0x5BE9300", VA = "0x185BEA500")]
	public ALLMFAGNCMF(int FDPDEHOPCON, int AOBBHLGFOBC, float HMHMNHIPHPL, int IEKEGHEMFKN, float HPPIFEEECDJ = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9760", Offset = "0x5BE8560", VA = "0x185BE9760")]
	public void KDKMDDNNKOO(List<GIMGJIHMDOE> NDFBKPCIBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8B60", Offset = "0x5BE7960", VA = "0x185BE8B60")]
	public bool HGLDKCGJOKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8BF0", Offset = "0x5BE79F0", VA = "0x185BE8BF0")]
	private float HOCGKFMOHEL(Vector3 OAPEGBFADLJ, Vector3 PDNOBEJABKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8BD0", Offset = "0x5BE79D0", VA = "0x185BE8BD0")]
	private float HOCGKFMOHEL(Vector3 GINFBCJKIJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9930", Offset = "0x5BE8730", VA = "0x185BE9930")]
	private bool LFFLBMIKBDP(BHNBEBJLNPC OBKHODMKJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8C40", Offset = "0x5BE7A40", VA = "0x185BE8C40")]
	private KPPCAMBIJGB IAJELJJFBBF(List<GIMGJIHMDOE> FHOOPFFNDIE, PCALAIHOECJ IPBCEEIEEBJ)
	{
		return default(KPPCAMBIJGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA100", Offset = "0x5BE8F00", VA = "0x185BEA100")]
	private void MBDFLDGLFFB(List<GIMGJIHMDOE> NDFBKPCIBAL, Vector3[] JMFFAFCAOMM, Vector3[] AKKGOOKFCOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class GABPKIIBBCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDE60", Offset = "0x5BECC60", VA = "0x185BEDE60")]
	public static Bounds CFLGFGCGHKP(List<GIMGJIHMDOE> NDFBKPCIBAL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE030", Offset = "0x5BECE30", VA = "0x185BEE030")]
	public static int NJMGKPBEOLP(List<GIMGJIHMDOE> NDFBKPCIBAL, FJDBGHECAMO NHLPANAJLNK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ACEMIAIIKKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LADLLAMMHKG KBELPKONBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private LADLLAMMHKG JDMAHKINPEH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static LADLLAMMHKG HCBGLIANFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GCMHEKNJGFN MHFJEOABGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FFDCHNKCGLC IPADJPEKANK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle GIFCONDMHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1AA45A0", Offset = "0x1AA33A0", VA = "0x181AA45A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MKOOFFMGCGM.IEFIHKAMHMG OBKHODMKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CLEHCLMJDKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E43F50", Offset = "0x4E42D50", VA = "0x184E43F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7960", Offset = "0x5BE6760", VA = "0x185BE7960")]
	[NAMFIDBGMDI(HHHGCGKDFJI.ExitingPlayMode, 0)]
	private static void FKEMFPAFCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7A20", Offset = "0x5BE6820", VA = "0x185BE7A20")]
	public void LKOIJBFKMJL(MKOOFFMGCGM.IEFIHKAMHMG BKIAFHOBHIN, Transform OLELEOBEBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7280", Offset = "0x5BE6080", VA = "0x185BE7280")]
	public void CJECHNDHLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE78F0", Offset = "0x5BE66F0", VA = "0x185BE78F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5BE79E0", Offset = "0x5BE67E0", VA = "0x185BE79E0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5BE82C0", Offset = "0x5BE70C0", VA = "0x185BE82C0")]
	public ACEMIAIIKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HGLMHMKICHA
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 EIGLPDJFEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FHJFIHFLOIE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(AEMIIEBAFHL<string>.GMENFEPMDPA HKGNFBBEDBI, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FLIBHEPMIOF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FLIBHEPMIOF OLMIFNDGINB(Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FLIBHEPMIOF IKIEHAMBAND(Action IPGJPNDBCJD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class ODKLNDKJCJM : FLIBHEPMIOF
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class ABBGAFJGLKI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public ODKLNDKJCJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public ABBGAFJGLKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5BE7190", Offset = "0x5BE5F90", VA = "0x185BE7190")]
				internal void CKPLOJLPFMP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5BE7230", Offset = "0x5BE6030", VA = "0x185BE7230")]
				internal void NOENIAHBEBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x5BE71E0", Offset = "0x5BE5FE0", VA = "0x185BE71E0")]
				internal void KDJIFKEPDAD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> CCOKPBNNAHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action HOBCPDOPIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action CAMHIECCPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private FEFAFLNEHAH IFGBKPDIBAD;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action DDEDJDHGAMF
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action ELCEDEHDMID
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3BD0870", Offset = "0x3BCF670", VA = "0x183BD0870", Slot = "4")]
			public FLIBHEPMIOF OLMIFNDGINB(Action IPGJPNDBCJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x571FE30", Offset = "0x571EC30", VA = "0x18571FE30", Slot = "5")]
			public FLIBHEPMIOF IKIEHAMBAND(Action IPGJPNDBCJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
			public ODKLNDKJCJM(Func<JobHandle> KAACFKCIJGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5BF76C0", Offset = "0x5BF64C0", VA = "0x185BF76C0")]
			public void INEHGKEHGLC(Action EMGAENBNAKD, Action DHDGAEMAMIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5BF7980", Offset = "0x5BF6780", VA = "0x185BF7980")]
			public void KCJHGNBNEJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class NDLLOFIKALB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public FLIBHEPMIOF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public NDLLOFIKALB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5BF76B0", Offset = "0x5BF64B0", VA = "0x185BF76B0")]
			internal bool LKILGFIDGDI(ODKLNDKJCJM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CEBODLPLOIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public ODKLNDKJCJM newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public CEBODLPLOIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC090", Offset = "0x5BEAE90", VA = "0x185BEC090")]
			internal void FBKPCHDNLDM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<ODKLNDKJCJM> LDPKGNMOKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<ODKLNDKJCJM> DCAENDNNFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KFKJPENGGJI JPEFEFMDCFL;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AJJGOFDIMHP CBLNFMFEAJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1C00", Offset = "0x5BF0A00", VA = "0x185BF1C00")]
		public FLIBHEPMIOF Add(Func<JobHandle> KAACFKCIJGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1F30", Offset = "0x5BF0D30", VA = "0x185BF1F30")]
		public void Remove(FLIBHEPMIOF GIFCONDMHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1D60", Offset = "0x5BF0B60", VA = "0x185BF1D60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2100", Offset = "0x5BF0F00", VA = "0x185BF2100")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2360", Offset = "0x5BF1160", VA = "0x185BF2360")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1D50", Offset = "0x5BF0B50", VA = "0x185BF1D50")]
		[CompilerGenerated]
		private void HGPHHHCAMGK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FEFAFLNEHAH
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FEFAFLNEHAH OLMIFNDGINB(Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEFAFLNEHAH LMKHPEDANFE(Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FEFAFLNEHAH IKIEHAMBAND(Action IPGJPNDBCJD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class EHACOOLOOLM : FEFAFLNEHAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle JEFIMJMNHGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action HOBCPDOPIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action CACDPIIBPFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action ELCEDEHDMID;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool LEICACPBEDD
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x5BED700", Offset = "0x5BEC500", VA = "0x185BED700")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5643AA0", Offset = "0x56428A0", VA = "0x185643AA0", Slot = "4")]
			public FEFAFLNEHAH OLMIFNDGINB(Action IPGJPNDBCJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5643AC0", Offset = "0x56428C0", VA = "0x185643AC0", Slot = "5")]
			public FEFAFLNEHAH LMKHPEDANFE(Action IPGJPNDBCJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x571FE30", Offset = "0x571EC30", VA = "0x18571FE30", Slot = "6")]
			public FEFAFLNEHAH IKIEHAMBAND(Action IPGJPNDBCJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1C3DCF0", Offset = "0x1C3CAF0", VA = "0x181C3DCF0")]
			public EHACOOLOOLM(JobHandle IGDCJKDNEGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5BED760", Offset = "0x5BEC560", VA = "0x185BED760")]
			public void MLCJINNMNAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5BED710", Offset = "0x5BEC510", VA = "0x185BED710")]
			public void KCJHGNBNEJA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<EHACOOLOOLM> NIFPKNLJIKF;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2860", Offset = "0x5BF1660", VA = "0x185BF2860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2440", Offset = "0x5BF1240", VA = "0x185BF2440")]
		public FEFAFLNEHAH Add(JobHandle IGDCJKDNEGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2760", Offset = "0x5BF1560", VA = "0x185BF2760")]
		public void Remove(FEFAFLNEHAH GIFCONDMHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BF25B0", Offset = "0x5BF13B0", VA = "0x185BF25B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5BF24E0", Offset = "0x5BF12E0", VA = "0x185BF24E0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BF29A0", Offset = "0x5BF17A0", VA = "0x185BF29A0")]
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
