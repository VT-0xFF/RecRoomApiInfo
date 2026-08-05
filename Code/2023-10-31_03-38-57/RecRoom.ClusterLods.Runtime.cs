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
				[Cpp2IlInjected.Address(RVA = "0x5BF5FF0", Offset = "0x5BF53F0", VA = "0x185BF5FF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1309990", Offset = "0x1308D90", VA = "0x181309990")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5FB0", Offset = "0x5BF53B0", VA = "0x185BF5FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BE9930", Offset = "0x5BE8D30", VA = "0x185BE9930")]
		public LODSettings BLGFBDHAIJJ(GBBHIBKCDKO FJPBEGOLMMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9940", Offset = "0x5BE8D40", VA = "0x185BE9940")]
		public int GFCMBOFNLPJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9960", Offset = "0x5BE8D60", VA = "0x185BE9960")]
		public int NENEBGIBPOB(bool HNPFMGJAENJ, Vector3 HBANNCAILBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9A00", Offset = "0x5BE8E00", VA = "0x185BE9A00")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PPKPGNLDNNO
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
public interface GLJAMDMPDGK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLCFADMEJBA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JMKFFDMGMEM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JEMOGJHMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LFPJGNOCLFF> CPMIMEIFNAC
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
	void UpdateClusterDistances(Vector3 HLENKEBAKND);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(JOHCMBNKGPN NCKHGGMLODI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LFPJGNOCLFF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int BNBIDEGDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HDBJFBANEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GCFOEJEKHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float EKGDOMGAAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte ALPGPEMHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GHNOKPJHCCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum HLFEMCPJDAC
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
	private struct POABLPGDOBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GHNOKPJHCCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CBIPFMDCEHJ<string>.OLALGCKMEOA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CBIPFMDCEHJ<string>.OLALGCKMEOA <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7830", Offset = "0x5BF6C30", VA = "0x185BF7830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7FC0", Offset = "0x5BF73C0", VA = "0x185BF7FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LCCNNHMEGHI : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private KALNLPJNFEA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GHNOKPJHCCB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
		[DebuggerHidden]
		public LCCNNHMEGHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5210", Offset = "0x5BF4610", VA = "0x185BF5210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5290", Offset = "0x5BF4690", VA = "0x185BF5290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CPLADFBKNHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GHNOKPJHCCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CBIPFMDCEHJ<string>.OLALGCKMEOA worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CBIPFMDCEHJ<string>.OLALGCKMEOA <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8090", Offset = "0x5BE7490", VA = "0x185BE8090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE98D0", Offset = "0x5BE8CD0", VA = "0x185BE98D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EIKCLEKLOIC : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KALNLPJNFEA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public GHNOKPJHCCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
		[DebuggerHidden]
		public EIKCLEKLOIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF680", Offset = "0x5BEEA80", VA = "0x185BEF680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF0360", Offset = "0x5BEF760", VA = "0x185BF0360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int BAFNDLLPGHM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan PBLGDPKBABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer HPLFKFNKFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter GIKIIMNGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject GNGOECFKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JOCFCCNFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FPCHLFFHLJK JPNLHLIGOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JOHCMBNKGPN> DALPKELPNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JOHCMBNKGPN> DNJMKJEIFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JOHCMBNKGPN> OOEDBCMEFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JLLICDEBGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HLFEMCPJDAC FIFMDIMJAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<JMKFFDMGMEM>[] LPCBCGNCOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<LFPJGNOCLFF>[] OHBABIACACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource CPJIIFOEIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool GCDNOONKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MICMLGMLJFD AFLGKOPNGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MICMLGMLJFD CCBHDDGJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int ADMFKPEOOPB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static GHNOKPJHCCB MDEGMHMCNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NGMHPLNFDLF MCDBFNMIABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BCAOLAHHHBP CKFECIHPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour PANJKJEPPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material JLBBKIDHEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<GLJAMDMPDGK> POMDOJDIJPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MFKANNIBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 JEIFKCHBBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76F720", Offset = "0x76EB20", VA = "0x18076F720")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E5F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private HLFEMCPJDAC ELAACPGIMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x95E360", Offset = "0x95D760", VA = "0x18095E360")]
		get
		{
			return default(HLFEMCPJDAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3510", Offset = "0x5BF2910", VA = "0x185BF3510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GHNOKPJHCCB PFONNHJIIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2930", Offset = "0x5BF1D30", VA = "0x185BF2930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool HLABIBKLBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BF23D0", Offset = "0x5BF17D0", VA = "0x185BF23D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PKOGDMNNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3640", Offset = "0x5BF2A40", VA = "0x185BF3640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NPDCBIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1D60", Offset = "0x5BF1160", VA = "0x185BF1D60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2870", Offset = "0x5BF1C70", VA = "0x185BF2870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FDMIJALNHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3460", Offset = "0x5BF2860", VA = "0x185BF3460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF24D0", Offset = "0x5BF18D0", VA = "0x185BF24D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF39D0", Offset = "0x5BF2DD0", VA = "0x185BF39D0")]
	public GHNOKPJHCCB(NGMHPLNFDLF MCDBFNMIABM, BCAOLAHHHBP CKFECIHPDJE, ClusterLODConfig PEJMNPABNNG, MonoBehaviour PANJKJEPPKO, Material JLBBKIDHEIK, ClusterMeshRenderer HPLFKFNKFJB, MeshFilter GIKIIMNGNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1BD0", Offset = "0x5BF0FD0", VA = "0x185BF1BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2980", Offset = "0x5BF1D80", VA = "0x185BF2980")]
	public static void LHADJLHFMCI(Vector3 FLNKNKHBMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1B40", Offset = "0x5BF0F40", VA = "0x185BF1B40")]
	private void DKFJODJBDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0EF0", Offset = "0x5BF02F0", VA = "0x185BF0EF0")]
	private void BFEKIACIAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0FC0", Offset = "0x5BF03C0", VA = "0x185BF0FC0")]
	private void BKOINOIADBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2A80", Offset = "0x5BF1E80", VA = "0x185BF2A80")]
	public void LHKPDDJNMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BF25E0", Offset = "0x5BF19E0", VA = "0x185BF25E0")]
	[AsyncStateMachine(typeof(POABLPGDOBF))]
	public Task JEJMFGEPGME(CBIPFMDCEHJ<string>.OLALGCKMEOA OFIEDCJPEMM, CancellationToken CLGPMABAGGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BF30E0", Offset = "0x5BF24E0", VA = "0x185BF30E0")]
	[IteratorStateMachine(typeof(LCCNNHMEGHI))]
	private IEnumerator<KALNLPJNFEA> LKOCCFFPHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1E20", Offset = "0x5BF1220", VA = "0x185BF1E20")]
	[AsyncStateMachine(typeof(CPLADFBKNHJ))]
	private Task FNPJBHNNAPE(CBIPFMDCEHJ<string>.OLALGCKMEOA DENFPPLDPJF, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2080", Offset = "0x5BF1480", VA = "0x185BF2080")]
	public void GMJJCJBIEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF12C0", Offset = "0x5BF06C0", VA = "0x185BF12C0")]
	public void BONCJBOENLK(IEnumerable<JMKFFDMGMEM> MOOCFIOLOFE, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3160", Offset = "0x5BF2560", VA = "0x185BF3160")]
	public void MFJLMEMPOOI(IEnumerable<JMKFFDMGMEM> MOOCFIOLOFE, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1340", Offset = "0x5BF0740", VA = "0x185BF1340")]
	public List<ClusterMeshRenderer> CCHBEOHMLKB(List<JOHCMBNKGPN> MGFLEBFIMPH, FJPDIMNMGMC OGEFIHKILIO, PPKPGNLDNNO ALDHADGKGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2580", Offset = "0x5BF1980", VA = "0x185BF2580")]
	public void JDGOPPLOBDH(GLJAMDMPDGK JBPPMDKPDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BF38A0", Offset = "0x5BF2CA0", VA = "0x185BF38A0")]
	public bool OPEFOOKGJFP(GLJAMDMPDGK JBPPMDKPDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3900", Offset = "0x5BF2D00", VA = "0x185BF3900")]
	public void PKNJGGFCPLM(JOHCMBNKGPN NAIGANMBNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1F40", Offset = "0x5BF1340", VA = "0x185BF1F40")]
	public void GBFOILEBKLO(LFPJGNOCLFF BCOICEBLMNF, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1CE0", Offset = "0x5BF10E0", VA = "0x185BF1CE0")]
	public void EIKECBMFLPD(LFPJGNOCLFF BCOICEBLMNF, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2280", Offset = "0x5BF1680", VA = "0x185BF2280")]
	private void HHOAOJLHKJP(Vector3 HLENKEBAKND, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3740", Offset = "0x5BF2B40", VA = "0x185BF3740")]
	private void OIBBBGLONBD(Vector3 HLENKEBAKND, PPKPGNLDNNO ALDHADGKGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1FC0", Offset = "0x5BF13C0", VA = "0x185BF1FC0")]
	[IteratorStateMachine(typeof(EIKCLEKLOIC))]
	private IEnumerator<KALNLPJNFEA> GDLAOAIACAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2700", Offset = "0x5BF1B00", VA = "0x185BF2700")]
	private int JILGLIHHMMK(int APOENOPNHBG, int GEBNJHIBODG, List<LFPJGNOCLFF> HHJDJDAFFLP, byte FJPBEGOLMMB, int DHLNMLAPFKM, float LMFFHGPPCLD = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1110", Offset = "0x5BF0510", VA = "0x185BF1110")]
	public void BLFHNKIOGCM(JOHCMBNKGPN NCKHGGMLODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3700", Offset = "0x5BF2B00", VA = "0x185BF3700")]
	public bool NIJNNAIHCNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8111F0", Offset = "0x8105F0", VA = "0x1808111F0")]
	public Material PFBILMDDOJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2040", Offset = "0x5BF1440", VA = "0x185BF2040")]
	public int GFCMBOFNLPJ()
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
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct DFFLGIDEMEN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> LLGHLOCGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> ONEEJLLNOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> DEIIIKFJMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> GDDOHHJGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> BMJAEALDEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> PIHPAKAJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> CFGPDJMCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 FLNLMJBEKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float JNEFLCNOOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> ENKPJELEOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> DCMFDIDFCAG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB620", Offset = "0x5BEAA20", VA = "0x185BEB620")]
	public DFFLGIDEMEN(EMENJBKKDBD PACIGNFPLIB, NativeList<float3> CFGPDJMCDCM, NativeParallelMultiHashMap<int, int> ENKPJELEOEG, NativeArray<int> DCMFDIDFCAG, Vector3 FLNLMJBEKLC, float JNEFLCNOOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAF20", Offset = "0x5BEA320", VA = "0x185BEAF20")]
	private int BFONNHGHGIJ(float3 HLENKEBAKND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAF80", Offset = "0x5BEA380", VA = "0x185BEAF80")]
	private int DDEJPDEJDGD(int KEFLNPGBJEJ, int DGCJCBHPPBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB1F0", Offset = "0x5BEA5F0", VA = "0x185BEB1F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BDBIMEHBJDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> ENKPJELEOEG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> DCMFDIDFCAG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int KELJLCFLADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> GMGCFAJGBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5710", Offset = "0x5BE4B10", VA = "0x185BE5710")]
	public void MJJNKIBPEID(int KMMCBOJJKJH, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5630", Offset = "0x5BE4A30", VA = "0x185BE5630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BDBIMEHBJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EFFEHOMCPMF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> DHJBLKIBFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> KAJDJDNOCNF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5BED650", Offset = "0x5BECA50", VA = "0x185BED650")]
	public EFFEHOMCPMF(BDBIMEHBJDG BJEDIPEMBAB, EMENJBKKDBD PACIGNFPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5BED5A0", Offset = "0x5BEC9A0", VA = "0x185BED5A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DLEHPKHDALJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> KJEJDPJDBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> CBOEMHPOAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> AGICFFGONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> NIPOHBPFKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> KMFHFIJJFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> GMGCFAJGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> DHJBLKIBFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> NOFAFOPPFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> IKNJCMMCLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> HABICJAIFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> OFJLLNLGLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> HJJCGANFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> IAHJBJKDFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float IECLDAGJHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float GFCFDBCPFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 JIPAMPODJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float LCPIFCKEECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float PCPPBDOBEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float EJKOOCGEPCD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5BECC70", Offset = "0x5BEC070", VA = "0x185BECC70")]
	public DLEHPKHDALJ(BDBIMEHBJDG GDJACAHGNJK, EMENJBKKDBD PACIGNFPLIB, EMENJBKKDBD OBOEACKKFHN, float PCPPBDOBEOJ, float EJKOOCGEPCD, Vector3 JIPAMPODJLG, float LCPIFCKEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB8E0", Offset = "0x5BEACE0", VA = "0x185BEB8E0")]
	private float3 BELCOHGMLHJ(int KEFLNPGBJEJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5BECA90", Offset = "0x5BEBE90", VA = "0x185BECA90")]
	private void PEEMAFALNBM(int KEFLNPGBJEJ, [Out] float3 OEMNBDCLCNM, [Out] float3 NKCIAKGIOEH, [Out] float4 OFDJKMGAKKF, [Out] float4 DCIHMPLHGDE, [Out] float2 NEKFMNAOOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB9B0", Offset = "0x5BEADB0", VA = "0x185BEB9B0")]
	private int ELFHPOMPNGN(int OCDODEKJFHL, int JKCLKJHLJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB6E0", Offset = "0x5BEAAE0", VA = "0x185BEB6E0")]
	private void AGABCDADDBL(int OCDODEKJFHL, int JKCLKJHLJJM, int GFKFNODIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC940", Offset = "0x5BEBD40", VA = "0x185BEC940")]
	private bool MKLODHHNKPG(int OCDODEKJFHL, int JKCLKJHLJJM, float GENCHLNJMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC880", Offset = "0x5BEBC80", VA = "0x185BEC880")]
	private bool LBAOPBMOMLD(int OCDODEKJFHL, int JKCLKJHLJJM, int GFKFNODIEAL, float GENCHLNJMDE, bool IMKHCDLBFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC620", Offset = "0x5BEBA20", VA = "0x185BEC620")]
	private bool IKKMGHKLNAC(int OCDODEKJFHL, int JKCLKJHLJJM, int GFKFNODIEAL, float GENCHLNJMDE, bool IMKHCDLBFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB990", Offset = "0x5BEAD90", VA = "0x185BEB990")]
	private void BKNGIDNHPPO(int OCDODEKJFHL, int JKCLKJHLJJM, int GFKFNODIEAL, [Out] int OILKGMFFGJE, [Out] int KFBCMNFPBMI, [Out] int MMJNJEOEGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5BEBCA0", Offset = "0x5BEB0A0", VA = "0x185BEBCA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BJPNKDOIKDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LEPFGEIGFPA : IDisposable, LFPJGNOCLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds OFKFPFOEFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<JOHCMBNKGPN> MGFLEBFIMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 FNMBMHNJCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 GPJKCNBBGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int ECJOFHPBJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EMENJBKKDBD HAAFCMHGMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BDBIMEHBJDG NPNFFCJDBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform OGEFIHKILIO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CEGGAOJIAIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5BF52E0", Offset = "0x5BF46E0", VA = "0x185BF52E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KFMCKFAGIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh HHCNMBNPKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float GCFOEJEKHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF7D560", Offset = "0xF7C960", VA = "0x180F7D560", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5327510", Offset = "0x5326910", VA = "0x185327510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte ALPGPEMHGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA45B90", Offset = "0xA44F90", VA = "0x180A45B90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA45E70", Offset = "0xA45270", VA = "0x180A45E70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BNBIDEGDKGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5610", Offset = "0x8C4A10", VA = "0x1808C5610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8C4250", Offset = "0x8C3650", VA = "0x1808C4250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HDBJFBANEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBF03E0", Offset = "0xBEF7E0", VA = "0x180BF03E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xBEE350", Offset = "0xBED750", VA = "0x180BEE350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EKGDOMGAAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5BF57D0", Offset = "0x5BF4BD0", VA = "0x185BF57D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5BF57F0", Offset = "0x5BF4BF0", VA = "0x185BF57F0")]
		public void NNACIBFGIGH(GBBHIBKCDKO FJPBEGOLMMB, [Out] int FKEMHPOHBOG, [Out] int IIACCFFIKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5320", Offset = "0x5BF4720", VA = "0x185BF5320")]
		public void BMFGJAIAMNM(GBBHIBKCDKO FJPBEGOLMMB, EODACAPOJNC FBJEAONNLEB, int CLCLDKHEDEI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5BF54F0", Offset = "0x5BF48F0", VA = "0x185BF54F0")]
		public void BOOKDNIINJE(Mesh PACIGNFPLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5740", Offset = "0x5BF4B40", VA = "0x185BF5740")]
		public void FLPAEABHABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5590", Offset = "0x5BF4990", VA = "0x185BF5590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5A60", Offset = "0x5BF4E60", VA = "0x185BF5A60")]
		public LEPFGEIGFPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds OFKFPFOEFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<LEPFGEIGFPA> PACEAKJCOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public OMINGEFNBPC CEGKGCMKEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer FODBLBFAJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int KJFLAKJAJON;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh LIOODODBCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DDAIJJCHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C80", Offset = "0x7B1080", VA = "0x1807B1C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B10B0", VA = "0x1807B1CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JEMOGJHMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5AD0", Offset = "0x5BE4ED0", VA = "0x185BE5AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5F70", Offset = "0x5BE5370", VA = "0x185BE5F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6EB0", Offset = "0x5BE62B0", VA = "0x185BE6EB0")]
	public int PBHIBPLOGMF(int CCIMEEEKLHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5D90", Offset = "0x5BE5190", VA = "0x185BE5D90")]
	public void DDMGMFAKBDA(EPMENANLGDC IDEFHKKNIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5BE60F0", Offset = "0x5BE54F0", VA = "0x185BE60F0")]
	public void GLBKBOPLLCK(Transform BDIPMCHFJLP, bool DHNOJGBMIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5910", Offset = "0x5BE4D10", VA = "0x185BE5910")]
	public bool AAFMEBKDNJA(bool MLEALFAPONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6880", Offset = "0x5BE5C80", VA = "0x185BE6880")]
	public void HAMHKIMOENC(Transform OGEFIHKILIO, bool DHNOJGBMIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5B20", Offset = "0x5BE4F20", VA = "0x185BE5B20")]
	public bool BLFHNKIOGCM(JOHCMBNKGPN NCKHGGMLODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6EE0", Offset = "0x5BE62E0", VA = "0x185BE6EE0")]
	public BJPNKDOIKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FPCHLFFHLJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<BJPNKDOIKDK.LEPFGEIGFPA> BBKOPIFCPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private BNJEDIOCBJK PCPGFODMEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<BJPNKDOIKDK.LEPFGEIGFPA> CMDGFOKILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int MCEFAPDGIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5BF06C0", Offset = "0x5BEFAC0", VA = "0x185BF06C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0640", Offset = "0x5BEFA40", VA = "0x185BF0640")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0B60", Offset = "0x5BEFF60", VA = "0x185BF0B60")]
	public void INMJBKGEACO(BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC, Transform OGEFIHKILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0460", Offset = "0x5BEF860", VA = "0x185BF0460")]
	public void BLFHNKIOGCM(BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0A20", Offset = "0x5BEFE20", VA = "0x185BF0A20")]
	private BJPNKDOIKDK.LEPFGEIGFPA IDEFKPBEALO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0C90", Offset = "0x5BF0090", VA = "0x185BF0C90")]
	private bool LDNHEJPHBGL(BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF09C0", Offset = "0x5BEFDC0", VA = "0x185BF09C0")]
	private void GMLFGDLLKOG(BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0430", Offset = "0x5BEF830", VA = "0x185BF0430")]
	public bool BBBIKJKAKKE(BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0740", Offset = "0x5BEFB40", VA = "0x185BF0740")]
	public bool GFEAHGHFDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0C20", Offset = "0x5BF0020", VA = "0x185BF0C20")]
	private BJPNKDOIKDK.LEPFGEIGFPA JGFLLKLKEMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0D30", Offset = "0x5BF0130", VA = "0x185BF0D30")]
	public FPCHLFFHLJK()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EIFCJLOMAKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int HDAIBJCAJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HAKIHGAEILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float HLEKHOINMID;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<BJPNKDOIKDK> CCJDNPAEPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF630", Offset = "0x5BEEA30", VA = "0x185BEF630")]
	public EIFCJLOMAKH(int HDAIBJCAJEM, int HAKIHGAEILK, float CFLJOOHNOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF290", Offset = "0x5BEE690", VA = "0x185BEF290")]
	public void BJKOEOEPFHF(IIBJANHBMJI LJAABAFMPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF340", Offset = "0x5BEE740", VA = "0x185BEF340")]
	private int BNJAFNEBNDN(EPMENANLGDC OMFNHGCDBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF080", Offset = "0x5BEE480", VA = "0x185BEF080")]
	private void BJKOEOEPFHF(EPMENANLGDC OMFNHGCDBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF3F0", Offset = "0x5BEE7F0", VA = "0x185BEF3F0")]
	private void LLOHGNMBKKL(EPMENANLGDC OMFNHGCDBFM, BJPNKDOIKDK LPPANOCKHLI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, JMKFFDMGMEM
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EEOPOFCLCEO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
			[DebuggerHidden]
			public EEOPOFCLCEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5BECDB0", Offset = "0x5BEC1B0", VA = "0x185BECDB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5BECF70", Offset = "0x5BEC370", VA = "0x185BECF70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5BECEC0", Offset = "0x5BEC2C0", VA = "0x185BECEC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5BECEC0", Offset = "0x5BEC2C0", VA = "0x185BECEC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int JEMOGJHMIMF
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5BEAEC0", Offset = "0x5BEA2C0", VA = "0x185BEAEC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<LFPJGNOCLFF> CPMIMEIFNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5BEAEA0", Offset = "0x5BEA2A0", VA = "0x185BEAEA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> PACEAKJCOLI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public BJPNKDOIKDK LIOODODBCOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PPKPGNLDNNO ENLGDFLKEDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x766ED0", Offset = "0x7662D0", VA = "0x180766ED0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PPKPGNLDNNO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x766EB0", Offset = "0x7662B0", VA = "0x180766EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GHLJBPMPGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16D1700", Offset = "0x16D0B00", VA = "0x1816D1700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9A60", Offset = "0x5BE8E60", VA = "0x185BE9A60")]
		public static ClusterMeshRenderer Create(BJPNKDOIKDK PACIGNFPLIB, ClusterMeshRenderer HPLFKFNKFJB, MeshFilter GIKIIMNGNCN, FJPDIMNMGMC OGEFIHKILIO, PPKPGNLDNNO ALDHADGKGIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9BD0", Offset = "0x5BE8FD0", VA = "0x185BE9BD0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA420", Offset = "0x5BE9820", VA = "0x185BEA420", Slot = "9")]
		public bool TryRemoveClusterLODComponent(JOHCMBNKGPN NCKHGGMLODI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA1D0", Offset = "0x5BE95D0", VA = "0x185BEA1D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9E40", Offset = "0x5BE9240", VA = "0x185BE9E40")]
		public void Init(BJPNKDOIKDK PACIGNFPLIB, MeshFilter GIKIIMNGNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9C30", Offset = "0x5BE9030", VA = "0x185BE9C30")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA4E0", Offset = "0x5BE98E0", VA = "0x185BEA4E0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 HLENKEBAKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA790", Offset = "0x5BE9B90", VA = "0x185BEA790", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9DC0", Offset = "0x5BE91C0", VA = "0x185BE9DC0")]
		[IteratorStateMachine(typeof(EEOPOFCLCEO))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA260", Offset = "0x5BE9660", VA = "0x185BEA260")]
		public void SetupTagAndLayer(string EIDCNFCDMOH, int ALDHADGKGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA240", Offset = "0x5BE9640", VA = "0x185BEA240")]
		public bool Remove(JOHCMBNKGPN NCKHGGMLODI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GNDLLNOKPJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int EFMBDPDEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int IDGHKCPGHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int IIACCFFIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int FKEMHPOHBOG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4190", Offset = "0x5BF3590", VA = "0x185BF4190")]
	public GNDLLNOKPJC(int IDGHKCPGHHK, int IIACCFFIKCA, int EFMBDPDEGHH, int FKEMHPOHBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OMINGEFNBPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> LLGHLOCGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> GMGCFAJGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> PIHPAKAJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<GNDLLNOKPJC> KLLMNJMAMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> NBHDIDPOONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> GBIBOCAECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> EKICIHMDKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle IJAGDFPAFEE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ENMLFMOLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A480", Offset = "0xA69880", VA = "0x180A6A480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB70DA0", VA = "0x180B719A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BF69D0", Offset = "0x5BF5DD0", VA = "0x185BF69D0")]
	public void PICNJLOMOKL(EMENJBKKDBD HBPPCELAHJF, NativeList<GNDLLNOKPJC> KLLMNJMAMGG, float NMGPAHAPPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6740", Offset = "0x5BF5B40", VA = "0x185BF6740")]
	public void NGLEOCJGOPH(Transform OGEFIHKILIO, bool DHNOJGBMIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6460", Offset = "0x5BF5860", VA = "0x185BF6460")]
	public void AAFMEBKDNJA(BJPNKDOIKDK FODBLBFAJPJ, bool MLEALFAPONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6630", Offset = "0x5BF5A30", VA = "0x185BF6630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6600", Offset = "0x5BF5A00", VA = "0x185BF6600")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OMINGEFNBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EFDBPBIOOBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> LLGHLOCGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> GMGCFAJGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<GNDLLNOKPJC> BJBEAMPCDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> NBHDIDPOONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 JIPAMPODJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> GBIBOCAECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> EKICIHMDKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool DHNOJGBMIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float FIFILKFFPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float ENHCMOHGFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float BNCMIEBFCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> PIHPAKAJMHN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5BED4D0", Offset = "0x5BEC8D0", VA = "0x185BED4D0")]
	public EFDBPBIOOBP(OMINGEFNBPC DABHPDFAJBG, Vector3 JIPAMPODJLG, bool DHNOJGBMIAD, float FIFILKFFPFO, float ENHCMOHGFPF, float BNCMIEBFCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5BECFC0", Offset = "0x5BEC3C0", VA = "0x185BECFC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JOHCMBNKGPN : PPACOLCALOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds EJFOMPAFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EPMENANLGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<JOHCMBNKGPN> MGFLEBFIMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public EPMENANLGDC EBFCMPBKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public EPMENANLGDC MJJGPJFFPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public EPMENANLGDC ICMIOBIOKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int FKEMHPOHBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds OFKFPFOEFJA;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5BF03B0", Offset = "0x5BEF7B0", VA = "0x185BF03B0")]
	public EPMENANLGDC(List<JOHCMBNKGPN> MGFLEBFIMPH, [Optional] EPMENANLGDC EBFCMPBKGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IIBJANHBMJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<EPMENANLGDC> JDALAJMMEFM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EPMENANLGDC DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5BF42A0", Offset = "0x5BF36A0", VA = "0x185BF42A0")]
	public IIBJANHBMJI(EPMENANLGDC OGEFIHKILIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EGIACMOAIKP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MEPGEDGGMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NMNBKAFCAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int CLJHMLBCOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EFGIKDGEEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int OIDHHGOEBOM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct IJDDIGEAMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int LDBMNKMGBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float CGAOKDPEGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<JOHCMBNKGPN> MGFLEBFIMPH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum LAJKHFEDEFG
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
	private MEPGEDGGMPM LIONGBAMKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int AEJDPIBDMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int HDAIBJCAJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int HAKIHGAEILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float CFLJOOHNOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float BMEAIGEHLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<EPMENANLGDC> LAKMNIBFCKA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IIBJANHBMJI PBPHDNLBMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF020", Offset = "0x5BEE420", VA = "0x185BEF020")]
	public EGIACMOAIKP(int HDAIBJCAJEM, int HAKIHGAEILK, float CFLJOOHNOOA, int AEJDPIBDMMM, float BMEAIGEHLPA = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDA80", Offset = "0x5BECE80", VA = "0x185BEDA80")]
	public void EJHJKCBKCJH(List<JOHCMBNKGPN> MGFLEBFIMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDC50", Offset = "0x5BED050", VA = "0x185BEDC50")]
	public bool GGBPAOHGJFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEFD0", Offset = "0x5BEE3D0", VA = "0x185BEEFD0")]
	private float NCMEBGKJOHP(Vector3 HMHBFKEMPJM, Vector3 NJNDGGPGGKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEFB0", Offset = "0x5BEE3B0", VA = "0x185BEEFB0")]
	private float NCMEBGKJOHP(Vector3 DAIAAPJIJOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDCC0", Offset = "0x5BED0C0", VA = "0x185BEDCC0")]
	private bool LAMOICLKLFH(EPMENANLGDC KDKJPMLHDFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE490", Offset = "0x5BED890", VA = "0x185BEE490")]
	private IJDDIGEAMBO LCCBEPMEBAE(List<JOHCMBNKGPN> MGIJKEGOIJM, LAJKHFEDEFG ELCBGFEFFOK)
	{
		return default(IJDDIGEAMBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5BED680", Offset = "0x5BECA80", VA = "0x185BED680")]
	private void CIAABALELGP(List<JOHCMBNKGPN> MGFLEBFIMPH, Vector3[] LPBPBHJCEFN, Vector3[] HEJDCNELHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class NAGCIGKCDOK
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6010", Offset = "0x5BF5410", VA = "0x185BF6010")]
	public static Bounds BDLLHJFLJHJ(List<JOHCMBNKGPN> MGFLEBFIMPH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BF61E0", Offset = "0x5BF55E0", VA = "0x185BF61E0")]
	public static int OECBLBHDECI(List<JOHCMBNKGPN> MGFLEBFIMPH, GBBHIBKCDKO FJPBEGOLMMB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BNJEDIOCBJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private EMENJBKKDBD CBHDCPLBPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EMENJBKKDBD JBHAPIFIIBL;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static EMENJBKKDBD PEIEIJDJIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private BIJPKAJFOFK NJJFBBFPMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private EODACAPOJNC FBJEAONNLEB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle IJAGDFPAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A94150", Offset = "0x1A93550", VA = "0x181A94150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BJPNKDOIKDK.LEPFGEIGFPA KDKJPMLHDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FDKIDCFGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E423F0", Offset = "0x4E417F0", VA = "0x184E423F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7050", Offset = "0x5BE6450", VA = "0x185BE7050")]
	[FPIKEPPKLPM(FAEBFOMIFBA.ExitingPlayMode, 0)]
	private static void KBLCDLFGBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7740", Offset = "0x5BE6B40", VA = "0x185BE7740")]
	public void PICNJLOMOKL(BJPNKDOIKDK.LEPFGEIGFPA BJBEAMPCDGH, Transform MFHLEHPCPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5BE70D0", Offset = "0x5BE64D0", VA = "0x185BE70D0")]
	public void NGGMCKIGKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6FE0", Offset = "0x5BE63E0", VA = "0x185BE6FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6FA0", Offset = "0x5BE63A0", VA = "0x185BE6FA0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7FE0", Offset = "0x5BE73E0", VA = "0x185BE7FE0")]
	public BNJEDIOCBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BCAOLAHHHBP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 PHBCMENFIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NGMHPLNFDLF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(CBIPFMDCEHJ<string>.OLALGCKMEOA DENFPPLDPJF, CancellationToken ELGJALILGJE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GEPJDCEFGPA
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEPJDCEFGPA FGIPIBJJAEM(Action GMCEKENFDDF);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GEPJDCEFGPA MDBCCLPIBIF(Action GMCEKENFDDF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class LLGPIJNBIKK : GEPJDCEFGPA
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class IAMBBGJBFBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public LLGPIJNBIKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public IAMBBGJBFBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5BF4250", Offset = "0x5BF3650", VA = "0x185BF4250")]
				internal void JHEHPBGEEJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x5BF41B0", Offset = "0x5BF35B0", VA = "0x185BF41B0")]
				internal void EPPMCIMJOFN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x5BF4200", Offset = "0x5BF3600", VA = "0x185BF4200")]
				internal void FAFNLDFJLFC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> ICGNDGPEJNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action CHHIMBGDMBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action JFFNACJIFCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private PDNEHKEKMMK HCAPKELALNE;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JFFHBFMACIG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action ELMMPIGJENP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4D30", Offset = "0x3DB4130", VA = "0x183DB4D30", Slot = "4")]
			public GEPJDCEFGPA FGIPIBJJAEM(Action GMCEKENFDDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x571E2D0", Offset = "0x571D6D0", VA = "0x18571E2D0", Slot = "5")]
			public GEPJDCEFGPA MDBCCLPIBIF(Action GMCEKENFDDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
			public LLGPIJNBIKK(Func<JobHandle> LACDHIPALEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5B60", Offset = "0x5BF4F60", VA = "0x185BF5B60")]
			public void AEPLBNHKDFP(Action MBCGMJDPCHI, Action PBOCIKDJPKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5E20", Offset = "0x5BF5220", VA = "0x185BF5E20")]
			public void BLFHNKIOGCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class GFGAGFJLBPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public GEPJDCEFGPA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public GFGAGFJLBPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5BF0EE0", Offset = "0x5BF02E0", VA = "0x185BF0EE0")]
			internal bool OIKFBJNKLKI(LLGPIJNBIKK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class KNLECJJIJLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public LLGPIJNBIKK newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public KNLECJJIJLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5BF51B0", Offset = "0x5BF45B0", VA = "0x185BF51B0")]
			internal void DGFEFPCNENP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<LLGPIJNBIKK> OCECCPFILPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<LLGPIJNBIKK> JBPGFLJPADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private MICMLGMLJFD IABGGCEAKCA;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public FEHBNOJFICP FIEEGDCIPIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4370", Offset = "0x5BF3770", VA = "0x185BF4370")]
		public GEPJDCEFGPA Add(Func<JobHandle> LACDHIPALEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5BF46A0", Offset = "0x5BF3AA0", VA = "0x185BF46A0")]
		public void Remove(GEPJDCEFGPA IJAGDFPAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BF44D0", Offset = "0x5BF38D0", VA = "0x185BF44D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4870", Offset = "0x5BF3C70", VA = "0x185BF4870")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4AD0", Offset = "0x5BF3ED0", VA = "0x185BF4AD0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5BF44C0", Offset = "0x5BF38C0", VA = "0x185BF44C0")]
		[CompilerGenerated]
		private void IPJNHDOKIFD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface PDNEHKEKMMK
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDNEHKEKMMK FGIPIBJJAEM(Action GMCEKENFDDF);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDNEHKEKMMK GPBNHMDGOEH(Action GMCEKENFDDF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDNEHKEKMMK MDBCCLPIBIF(Action GMCEKENFDDF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class NMOCBFPEBJI : PDNEHKEKMMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle IOJPJDGOOCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action CHHIMBGDMBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action MGCDFLJGGEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action ELMMPIGJENP;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool PEJMFNBLKBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x5BF6450", Offset = "0x5BF5850", VA = "0x185BF6450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5641F40", Offset = "0x5641340", VA = "0x185641F40", Slot = "4")]
			public PDNEHKEKMMK FGIPIBJJAEM(Action GMCEKENFDDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5641F60", Offset = "0x5641360", VA = "0x185641F60", Slot = "5")]
			public PDNEHKEKMMK GPBNHMDGOEH(Action GMCEKENFDDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x571E2D0", Offset = "0x571D6D0", VA = "0x18571E2D0", Slot = "6")]
			public PDNEHKEKMMK MDBCCLPIBIF(Action GMCEKENFDDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1C3CD80", Offset = "0x1C3C180", VA = "0x181C3CD80")]
			public NMOCBFPEBJI(JobHandle BEDPJEEAOGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6400", Offset = "0x5BF5800", VA = "0x185BF6400")]
			public void GPDBOMJNGBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5BF63B0", Offset = "0x5BF57B0", VA = "0x185BF63B0")]
			public void BLFHNKIOGCM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<NMOCBFPEBJI> JFKJAKOACCA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4FD0", Offset = "0x5BF43D0", VA = "0x185BF4FD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4BB0", Offset = "0x5BF3FB0", VA = "0x185BF4BB0")]
		public PDNEHKEKMMK Add(JobHandle BEDPJEEAOGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4ED0", Offset = "0x5BF42D0", VA = "0x185BF4ED0")]
		public void Remove(PDNEHKEKMMK IJAGDFPAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4D20", Offset = "0x5BF4120", VA = "0x185BF4D20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4C50", Offset = "0x5BF4050", VA = "0x185BF4C50")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5110", Offset = "0x5BF4510", VA = "0x185BF5110")]
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
