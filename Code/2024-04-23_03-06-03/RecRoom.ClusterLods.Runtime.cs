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
				[Cpp2IlInjected.Address(RVA = "0x6200C20", Offset = "0x61FFC20", VA = "0x186200C20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x14B05F0", Offset = "0x14AF5F0", VA = "0x1814B05F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6200BE0", Offset = "0x61FFBE0", VA = "0x186200BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x61F6610", Offset = "0x61F5610", VA = "0x1861F6610")]
		public LODSettings LENNNLJFMGL(MCIGCFAGBDP ODIANCNJLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61F65F0", Offset = "0x61F55F0", VA = "0x1861F65F0")]
		public int HJDKEEGGEBC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61F6550", Offset = "0x61F5550", VA = "0x1861F6550")]
		public int ECCGBFBAEFC(bool CAMAHLPDJGE, Vector3 IGABIOKDNFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61F6620", Offset = "0x61F5620", VA = "0x1861F6620")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GOJGKBADHKM
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
public interface DNHBOAAKDCL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBELLEKPDFL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CCEKGEFHPMF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int EMNACGNPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<HBMEBLMCKEM> DLLAMABDJNP
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
	void UpdateClusterDistances(Vector3 PDJLKPJAKEO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(ODPMFFJGIMG MPHIHJDJBKC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBMEBLMCKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int DEOMEBAMPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NMJMMMHDKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float EKJGOGIGNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FNHEONEKCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte ICBHOFHHAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NCIGGMJDEBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ALHNAJFFHDP
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
	private struct CAJKCBHPBNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NCIGGMJDEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61F56D0", Offset = "0x61F46D0", VA = "0x1861F56D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61F5E60", Offset = "0x61F4E60", VA = "0x1861F5E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JJKIMEABKMC : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NCIGGMJDEBP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public JJKIMEABKMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61FF770", Offset = "0x61FE770", VA = "0x1861FF770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61FF880", Offset = "0x61FE880", VA = "0x1861FF880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GGIGMFJLPKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NCIGGMJDEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61FAC20", Offset = "0x61F9C20", VA = "0x1861FAC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61FC460", Offset = "0x61FB460", VA = "0x1861FC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PJFCODMMKAM : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NCIGGMJDEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public PJFCODMMKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6207B10", Offset = "0x6206B10", VA = "0x186207B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62087F0", Offset = "0x62077F0", VA = "0x1862087F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int PPGMGIFMPEJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan EDIFJPBMOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer FLHEMLPMCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter ONMLJMGBCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject KNLCMLFCHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject BIDBDENDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public GEAPLGEOOPK IHIAFIONHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<ODPMFFJGIMG> NOEDOBEFHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<ODPMFFJGIMG> IFMJJINJPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<ODPMFFJGIMG> GPMANOJFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CEBDLGILOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ALHNAJFFHDP EKNNPGGMLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CCEKGEFHPMF>[] AEMHMBHPIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<HBMEBLMCKEM>[] OCIOBEPNPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource PAKAAHONBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool JOFCNOIIMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EOCGEKKEBMP HHBPCOLMAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EOCGEKKEBMP DMDHBCEGHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int IIIDLFBGAOH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static NCIGGMJDEBP HLLAOLEIIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EKCDKKDKDHN DGPFGGEABDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HMMKJLJIOHA MAGKFGFKKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour MEMLPNGJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material PIPGIADHMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<DNHBOAAKDCL> OPHEHJPPEHE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig JDNCEJKECOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 OALLKCHMDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D2510", Offset = "0x7D1510", VA = "0x1807D2510")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F60", Offset = "0x7D0F60", VA = "0x1807D1F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private ALHNAJFFHDP DEMLOIMCINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B10", Offset = "0xAE5B10", VA = "0x180AE6B10")]
		get
		{
			return default(ALHNAJFFHDP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6204B10", Offset = "0x6203B10", VA = "0x186204B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NCIGGMJDEBP AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6203CB0", Offset = "0x6202CB0", VA = "0x186203CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool ECLELKGOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6204D90", Offset = "0x6203D90", VA = "0x186204D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CFIPIBECFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62055E0", Offset = "0x62045E0", VA = "0x1862055E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OIIKAPNANNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6202920", Offset = "0x6201920", VA = "0x186202920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6204670", Offset = "0x6203670", VA = "0x186204670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DIMPIAJHLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62049E0", Offset = "0x62039E0", VA = "0x1862049E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6205090", Offset = "0x6204090", VA = "0x186205090")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6205710", Offset = "0x6204710", VA = "0x186205710")]
	public NCIGGMJDEBP(EKCDKKDKDHN DGPFGGEABDA, HMMKJLJIOHA MAGKFGFKKNI, ClusterLODConfig LFKFOMNGFPH, MonoBehaviour MEMLPNGJPMJ, Material PIPGIADHMHP, ClusterMeshRenderer FLHEMLPMCJN, MeshFilter ONMLJMGBCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6203D80", Offset = "0x6202D80", VA = "0x186203D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6204F90", Offset = "0x6203F90", VA = "0x186204F90")]
	public static void KOGMALEBBJP(Vector3 KEBIKJKDFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6204480", Offset = "0x6203480", VA = "0x186204480")]
	private void GJDDFANIBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62038A0", Offset = "0x62028A0", VA = "0x1862038A0")]
	private void CFOCLMKCMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6204C40", Offset = "0x6203C40", VA = "0x186204C40")]
	private void IMJJEAELPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62029E0", Offset = "0x62019E0", VA = "0x1862029E0")]
	public void BELBDJKNIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6205140", Offset = "0x6204140", VA = "0x186205140")]
	[AsyncStateMachine(typeof(CAJKCBHPBNO))]
	public Task NABMMNDDMNL(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6204A90", Offset = "0x6203A90", VA = "0x186204A90")]
	[IteratorStateMachine(typeof(JJKIMEABKMC))]
	private IEnumerator<JHIBCIKJMBL> IJLHHAABGPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6204730", Offset = "0x6203730", VA = "0x186204730")]
	[AsyncStateMachine(typeof(GGIGMFJLPKL))]
	private Task HGOEDMADKMG(NENCAGLHEIB<string>.OGJMFKKDMDA EAODOJLHGMO, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6203F70", Offset = "0x6202F70", VA = "0x186203F70")]
	public void EKPAAGEBEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6204E90", Offset = "0x6203E90", VA = "0x186204E90")]
	public void KDJLEADGOPM(IEnumerable<CCEKGEFHPMF> LAACIAPJCJM, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6203970", Offset = "0x6202970", VA = "0x186203970")]
	public void CHHIAEMOMEO(IEnumerable<CCEKGEFHPMF> LAACIAPJCJM, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62030A0", Offset = "0x62020A0", VA = "0x1862030A0")]
	public List<ClusterMeshRenderer> BPCBEOLJNPD(List<ODPMFFJGIMG> AFCABONIINP, PPOBKJNJKIH OPFDMIOAEHD, GOJGKBADHKM AHMOKAPAGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6205580", Offset = "0x6204580", VA = "0x186205580")]
	public void PFOOLHLIKJF(DNHBOAAKDCL HBKCEJDNMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6203040", Offset = "0x6202040", VA = "0x186203040")]
	public bool BPANMNJJDKJ(DNHBOAAKDCL HBKCEJDNMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6203F10", Offset = "0x6202F10", VA = "0x186203F10")]
	public void EENCKOCKGGJ(ODPMFFJGIMG OMGGNNPOEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6203D00", Offset = "0x6202D00", VA = "0x186203D00")]
	public void DMFLLNLLJJH(HBMEBLMCKEM LHAGOFJLFBG, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6204F10", Offset = "0x6203F10", VA = "0x186204F10")]
	public void KKPCDENAMIC(HBMEBLMCKEM LHAGOFJLFBG, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6204850", Offset = "0x6203850", VA = "0x186204850")]
	private void HIFMIBJIENO(Vector3 PDJLKPJAKEO, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6204510", Offset = "0x6203510", VA = "0x186204510")]
	private void HCFCBEBCFEM(Vector3 PDJLKPJAKEO, GOJGKBADHKM AHMOKAPAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6203E90", Offset = "0x6202E90", VA = "0x186203E90")]
	[IteratorStateMachine(typeof(PJFCODMMKAM))]
	private IEnumerator<JHIBCIKJMBL> EDKJGCJMFLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6205410", Offset = "0x6204410", VA = "0x186205410")]
	private int OHHHOGILJFE(int GPEHCABDGEJ, int NFLPFHMMAHI, List<HBMEBLMCKEM> IHAINEMGEKH, byte ODIANCNJLNI, int OBDIOICKAGC, float OBDKBCDBLAF = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6205260", Offset = "0x6204260", VA = "0x186205260")]
	public void NCLCGNJGAKA(ODPMFFJGIMG MPHIHJDJBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6203C70", Offset = "0x6202C70", VA = "0x186203C70")]
	public bool DCMHIIHOIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8DF280", Offset = "0x8DE280", VA = "0x1808DF280")]
	public Material DMCLKHPAIAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62049A0", Offset = "0x62039A0", VA = "0x1862049A0")]
	public int HJDKEEGGEBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6204170", Offset = "0x6203170", VA = "0x186204170")]
	public long GDMFKHOEJDG()
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
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HNCNOPDLNMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> KAAGLCNLAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> IAAJPIGMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> IAJKHAFODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> PEBFDLJLDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 LFGBKONONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float IBMMBCCCNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeParallelMultiHashMap<int, int> ICDNGMNEMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> ECGNOIFKNIH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61FE580", Offset = "0x61FD580", VA = "0x1861FE580")]
	public HNCNOPDLNMC(DGFJOPHFDKD GCFMCPMBPPI, NativeList<float3> PEBFDLJLDKI, NativeParallelMultiHashMap<int, int> ICDNGMNEMBF, NativeArray<int> ECGNOIFKNIH, Vector3 LFGBKONONLM, float IBMMBCCCNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61FE2B0", Offset = "0x61FD2B0", VA = "0x1861FE2B0")]
	private int IHNAOHBECDO(float3 PDJLKPJAKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61FE310", Offset = "0x61FD310", VA = "0x1861FE310")]
	private int JPEEGFEGFAH(int AFFJDCKHCJD, int OHNEPKBBADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61FDE80", Offset = "0x61FCE80", VA = "0x1861FDE80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MBALOBMLAEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeParallelMultiHashMap<int, int> ICDNGMNEMBF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> ECGNOIFKNIH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int FABJPMIGABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> JGNCBAMBOAN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6200D20", Offset = "0x61FFD20", VA = "0x186200D20")]
	public void ECGMOLAFJIH(int AALFLLNNAPO, Allocator NFBFCGHLHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6200C40", Offset = "0x61FFC40", VA = "0x186200C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public MBALOBMLAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HHGFMJMGEDC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> JECIIFGGLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> GFHBBNJLGMI;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61FDE50", Offset = "0x61FCE50", VA = "0x1861FDE50")]
	public HHGFMJMGEDC(MBALOBMLAEJ KFIBDIGGCNK, DGFJOPHFDKD GCFMCPMBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61FDDA0", Offset = "0x61FCDA0", VA = "0x1861FDDA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct GJCDMIJBAHG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> IKHDBECAPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> IEPGMPENFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> CCCGLOAKIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> BPOJMFODFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> BGCENDIDOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> JGNCBAMBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> JECIIFGGLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> MPLLJANGEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> GNGEBDAPOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> IGDCKNDJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LFFMMECEEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> DAAHGBACNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> BCJEPDNEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float OMHNFIMACJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float DGEAFOPDCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 BFLCAIPEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float HPECDJFKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FMAJPANIONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float MPDLEMGFFNF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61FDA50", Offset = "0x61FCA50", VA = "0x1861FDA50")]
	public GJCDMIJBAHG(MBALOBMLAEJ CONAPPPBAEE, DGFJOPHFDKD GCFMCPMBPPI, DGFJOPHFDKD EMIGMNGBNJG, float FMAJPANIONE, float MPDLEMGFFNF, Vector3 BFLCAIPEFLM, float HPECDJFKJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61FD3F0", Offset = "0x61FC3F0", VA = "0x1861FD3F0")]
	private float3 GBHDIAKMNPC(int AFFJDCKHCJD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61FD610", Offset = "0x61FC610", VA = "0x1861FD610")]
	private void MDOMBELMIHK(int AFFJDCKHCJD, [Out] float3 DIJJFLIPOFB, [Out] float3 BKLEDJJPAMH, [Out] float4 JKKLJGIEIHF, [Out] float4 EDJBNDINDCD, [Out] float2 CFHPBFDCCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61FC4C0", Offset = "0x61FB4C0", VA = "0x1861FC4C0")]
	private int AGJIGIIOIGM(int PBDOPGNIGKJ, int ANDADCJJEAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61FD1F0", Offset = "0x61FC1F0", VA = "0x1861FD1F0")]
	private void FJLEKCCKIHP(int PBDOPGNIGKJ, int ANDADCJJEAI, int OJBKMGGBDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x61FD4A0", Offset = "0x61FC4A0", VA = "0x1861FD4A0")]
	private bool HEGOOMCOJHP(int PBDOPGNIGKJ, int ANDADCJJEAI, float BNAEDIGGCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61FC7B0", Offset = "0x61FB7B0", VA = "0x1861FC7B0")]
	private bool CLNAPNECKIL(int PBDOPGNIGKJ, int ANDADCJJEAI, int OJBKMGGBDBK, float BNAEDIGGCKO, bool PMCPAMKHPAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61FD7F0", Offset = "0x61FC7F0", VA = "0x1861FD7F0")]
	private bool NMMCLJHFAIL(int PBDOPGNIGKJ, int ANDADCJJEAI, int OJBKMGGBDBK, float BNAEDIGGCKO, bool PMCPAMKHPAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61FD5F0", Offset = "0x61FC5F0", VA = "0x1861FD5F0")]
	private void KDCPHOEIAOA(int PBDOPGNIGKJ, int ANDADCJJEAI, int OJBKMGGBDBK, [Out] int JNOCMJDNLPA, [Out] int LCMBNIEIOKH, [Out] int JNAMGAIHELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61FC870", Offset = "0x61FB870", VA = "0x1861FC870", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHOOJMKGAFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FLLGIBKFOBD : IDisposable, HBMEBLMCKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds CKGHEKIAJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<ODPMFFJGIMG> AFCABONIINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 ENHAACNCONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 LLLMBANKNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int NDPIFFENJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DGFJOPHFDKD PAOCJILHCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long FMJJMEALPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MBALOBMLAEJ FCOIEPOEBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform OPFDMIOAEHD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int FBMPKBJFLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x61F9800", Offset = "0x61F8800", VA = "0x1861F9800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh OCMIPCFFABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh OEFACHGEGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EKJGOGIGNFF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1138880", Offset = "0x1137880", VA = "0x181138880", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5898CB0", Offset = "0x5897CB0", VA = "0x185898CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte ICBHOFHHAID
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1099780", Offset = "0x1098780", VA = "0x181099780")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x136EC10", Offset = "0x136DC10", VA = "0x18136EC10", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int DEOMEBAMPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA539C0", Offset = "0xA529C0", VA = "0x180A539C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA52D50", Offset = "0xA51D50", VA = "0x180A52D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NMJMMMHDKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD34350", Offset = "0xD33350", VA = "0x180D34350", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD33C70", Offset = "0xD32C70", VA = "0x180D33C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FNHEONEKCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x61F9A10", Offset = "0x61F8A10", VA = "0x1861F9A10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61F9AC0", Offset = "0x61F8AC0", VA = "0x1861F9AC0")]
		public void KDDBLOIIPPL(MCIGCFAGBDP ODIANCNJLNI, [Out] int HCEIPJNIFCF, [Out] int GCMPHABKKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61F9840", Offset = "0x61F8840", VA = "0x1861F9840")]
		public void ILFKHDFMLLB(MCIGCFAGBDP ODIANCNJLNI, BHBGCKFONGN LKAHBEGEPCB, int KJCEELACJMM = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61F95A0", Offset = "0x61F85A0", VA = "0x1861F95A0")]
		public void BBGJLCOBMBJ(Mesh GCFMCPMBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61F9A30", Offset = "0x61F8A30", VA = "0x1861F9A30")]
		public void JIAFNEKDALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61F9640", Offset = "0x61F8640", VA = "0x1861F9640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61F9D30", Offset = "0x61F8D30", VA = "0x1861F9D30")]
		public FLLGIBKFOBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds CKGHEKIAJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<FLLGIBKFOBD> MALPMCLMPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public OKHJGHPMGLN ADGLDKLGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer MMCALBDPLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int PJKKMAHGGDF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GFCDINIDGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DHANGGPBBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88AC60", Offset = "0x889C60", VA = "0x18088AC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x96ECD0", Offset = "0x96DCD0", VA = "0x18096ECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EMNACGNPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x61F8E30", Offset = "0x61F7E30", VA = "0x1861F8E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61F7D30", Offset = "0x61F6D30", VA = "0x1861F7D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61F90F0", Offset = "0x61F80F0", VA = "0x1861F90F0")]
	public int PLDICHGMNJG(int DGPJEPPCLBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61F7B50", Offset = "0x61F6B50", VA = "0x1861F7B50")]
	public void DKFONGDJMHI(KLCHICDKINL JOAAGHKBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61F86A0", Offset = "0x61F76A0", VA = "0x1861F86A0")]
	public void IBJPGDGJIDI(Transform OCKHJMEPNID, bool AOPADHMDHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61F7EB0", Offset = "0x61F6EB0", VA = "0x1861F7EB0")]
	public bool ENAGLBBOPHD(bool KPPFANCJEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61F8070", Offset = "0x61F7070", VA = "0x1861F8070")]
	public void FLDNPCAMNNK(Transform OPFDMIOAEHD, bool AOPADHMDHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61F8E80", Offset = "0x61F7E80", VA = "0x1861F8E80")]
	public bool NCLCGNJGAKA(ODPMFFJGIMG MPHIHJDJBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61F9120", Offset = "0x61F8120", VA = "0x1861F9120")]
	public DHOOJMKGAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GEAPLGEOOPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<DHOOJMKGAFG.FLLGIBKFOBD> DAGPHJBPIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JGNCKMJLDJG FIPFNPGCMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<DHOOJMKGAFG.FLLGIBKFOBD> DCDAGCLDILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CGIPMBBGEGM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61FA2C0", Offset = "0x61F92C0", VA = "0x1861FA2C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61FA710", Offset = "0x61F9710", VA = "0x1861FA710")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61FA0C0", Offset = "0x61F90C0", VA = "0x1861FA0C0")]
	public void BGLDHBEBEIE(DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI, Transform OPFDMIOAEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61FA860", Offset = "0x61F9860", VA = "0x1861FA860")]
	public void NCLCGNJGAKA(DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61FA180", Offset = "0x61F9180", VA = "0x1861FA180")]
	private DHOOJMKGAFG.FLLGIBKFOBD BLPHILLIPCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61FA670", Offset = "0x61F9670", VA = "0x1861FA670")]
	private bool HAFGFJHPMOO(DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61FA790", Offset = "0x61F9790", VA = "0x1861FA790")]
	private void IFBKJCBNHFF(DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61FAA40", Offset = "0x61F9A40", VA = "0x1861FAA40")]
	public bool OEHPKJCMOEA(DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61F9E30", Offset = "0x61F8E30", VA = "0x1861F9E30")]
	public bool ACILEHIEJCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61FA7F0", Offset = "0x61F97F0", VA = "0x1861FA7F0")]
	private DHOOJMKGAFG.FLLGIBKFOBD NBDKAJKOHPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61FA340", Offset = "0x61F9340", VA = "0x1861FA340")]
	public long GDMFKHOEJDG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61FAA70", Offset = "0x61F9A70", VA = "0x1861FAA70")]
	public GEAPLGEOOPK()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OGBHMABBBCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int JOFDHLCGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int AMEHKNCCIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float FAJOCLAMFGD;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<DHOOJMKGAFG> EGCMFIMGCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62066B0", Offset = "0x62056B0", VA = "0x1862066B0")]
	public OGBHMABBBCF(int JOFDHLCGHEI, int AMEHKNCCIOC, float DEHJJGCKKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6206550", Offset = "0x6205550", VA = "0x186206550")]
	public void MFGEFDMMIBM(NONGCLDDBIL KHEPLDEPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6206600", Offset = "0x6205600", VA = "0x186206600")]
	private int PMJPDCCPDKA(KLCHICDKINL CDMAFKOHEPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6206340", Offset = "0x6205340", VA = "0x186206340")]
	private void MFGEFDMMIBM(KLCHICDKINL CDMAFKOHEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6206100", Offset = "0x6205100", VA = "0x186206100")]
	private void HGAEOONJBFK(KLCHICDKINL CDMAFKOHEPF, DHOOJMKGAFG AENENINPIIJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CCEKGEFHPMF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GJMJOLKNJNE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
			[DebuggerHidden]
			public GJMJOLKNJNE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x61FDB90", Offset = "0x61FCB90", VA = "0x1861FDB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x61FDD50", Offset = "0x61FCD50", VA = "0x1861FDD50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x61FDCA0", Offset = "0x61FCCA0", VA = "0x1861FDCA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x61FDCA0", Offset = "0x61FCCA0", VA = "0x1861FDCA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int EMNACGNPEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x61F7AF0", Offset = "0x61F6AF0", VA = "0x1861F7AF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<HBMEBLMCKEM> DLLAMABDJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x61F7AD0", Offset = "0x61F6AD0", VA = "0x1861F7AD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> MALPMCLMPJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DHOOJMKGAFG GFCDINIDGLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GOJGKBADHKM LBGDAHKADCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(GOJGKBADHKM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D70", Offset = "0x7C1D70", VA = "0x1807C2D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool NNCNLAAOMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x193DE00", Offset = "0x193CE00", VA = "0x18193DE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61F6680", Offset = "0x61F5680", VA = "0x1861F6680")]
		public static ClusterMeshRenderer Create(DHOOJMKGAFG GCFMCPMBPPI, ClusterMeshRenderer FLHEMLPMCJN, MeshFilter ONMLJMGBCBH, PPOBKJNJKIH OPFDMIOAEHD, GOJGKBADHKM AHMOKAPAGAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61F67F0", Offset = "0x61F57F0", VA = "0x1861F67F0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61F7040", Offset = "0x61F6040", VA = "0x1861F7040", Slot = "9")]
		public bool TryRemoveClusterLODComponent(ODPMFFJGIMG MPHIHJDJBKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61F6DF0", Offset = "0x61F5DF0", VA = "0x1861F6DF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61F6A60", Offset = "0x61F5A60", VA = "0x1861F6A60")]
		public void Init(DHOOJMKGAFG GCFMCPMBPPI, MeshFilter ONMLJMGBCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61F6850", Offset = "0x61F5850", VA = "0x1861F6850")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x61F7100", Offset = "0x61F6100", VA = "0x1861F7100", Slot = "7")]
		public void UpdateClusterDistances(Vector3 PDJLKPJAKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61F73B0", Offset = "0x61F63B0", VA = "0x1861F73B0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61F69E0", Offset = "0x61F59E0", VA = "0x1861F69E0")]
		[IteratorStateMachine(typeof(GJMJOLKNJNE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61F6E80", Offset = "0x61F5E80", VA = "0x1861F6E80")]
		public void SetupTagAndLayer(string KHOLDKJFPPN, int AHMOKAPAGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61F6E60", Offset = "0x61F5E60", VA = "0x1861F6E60")]
		public bool Remove(ODPMFFJGIMG MPHIHJDJBKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DPDMNPCDIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KBDCBNIENPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int GOABEOHPNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GCMPHABKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HCEIPJNIFCF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61F9580", Offset = "0x61F8580", VA = "0x1861F9580")]
	public DPDMNPCDIMG(int GOABEOHPNBP, int GCMPHABKKFN, int KBDCBNIENPE, int HCEIPJNIFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OKHJGHPMGLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> JGNCBAMBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> IAJKHAFODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<DPDMNPCDIMG> IOMODPCBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> JEKAHLAMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> OFPHNMMNCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> DAOABJMOPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle NFHOJLAMIPA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ODMLOOGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xEF01B0", Offset = "0xEEF1B0", VA = "0x180EF01B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xEF0450", Offset = "0xEEF450", VA = "0x180EF0450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6206710", Offset = "0x6205710", VA = "0x186206710")]
	public void CPHLHCOPMDI(DGFJOPHFDKD NDAEGKCECGF, NativeList<DPDMNPCDIMG> IOMODPCBACM, float GJBNAOHDFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6207850", Offset = "0x6206850", VA = "0x186207850")]
	public void GKLOMHKBLOI(Transform OPFDMIOAEHD, bool AOPADHMDHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x62076B0", Offset = "0x62066B0", VA = "0x1862076B0")]
	public void ENAGLBBOPHD(DHOOJMKGAFG MMCALBDPLAH, bool KPPFANCJEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x62075A0", Offset = "0x62065A0", VA = "0x1862075A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6207AE0", Offset = "0x6206AE0", VA = "0x186207AE0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public OKHJGHPMGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CMGGFFEJHGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> BFLKELODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> JGNCBAMBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<DPDMNPCDIMG> GMHGLCOABOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> JEKAHLAMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 BFLCAIPEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> OFPHNMMNCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> DAOABJMOPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool AOPADHMDHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float MGINACAKGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float EDHPPIIDKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float KBOMKFOHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> IAJKHAFODFG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x61F63D0", Offset = "0x61F53D0", VA = "0x1861F63D0")]
	public CMGGFFEJHGM(OKHJGHPMGLN PMGFIFFMGHE, Vector3 BFLCAIPEFLM, bool AOPADHMDHNG, float MGINACAKGDC, float EDHPPIIDKLP, float KBOMKFOHIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x61F5EC0", Offset = "0x61F4EC0", VA = "0x1861F5EC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ODPMFFJGIMG : FAFAOJKPOLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds JLEBNKAGCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KLCHICDKINL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<ODPMFFJGIMG> AFCABONIINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public KLCHICDKINL NNHBJFPLAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public KLCHICDKINL DIEAGGACAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public KLCHICDKINL OENKJHOFNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HCEIPJNIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds CKGHEKIAJNJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6200B60", Offset = "0x61FFB60", VA = "0x186200B60")]
	public KLCHICDKINL(List<ODPMFFJGIMG> AFCABONIINP, [Optional] KLCHICDKINL NNHBJFPLAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NONGCLDDBIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<KLCHICDKINL> MKCEAHKHICN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KLCHICDKINL NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6205EE0", Offset = "0x6204EE0", VA = "0x186205EE0")]
	public NONGCLDDBIL(KLCHICDKINL OPFDMIOAEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MJJHNJHFIKO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OOBDHHJKNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int DMHPJKFBCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int MGLPIMLOPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int FFCCPPIIDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int EAPFCGCFFAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GFCIJKENAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int JGCIJKHHDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float OGGBBCDOLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<ODPMFFJGIMG> AFCABONIINP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum DPLMMMDNKHG
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
	private OOBDHHJKNFK CJNKKLMKLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int LPHANAKBLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int JOFDHLCGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int AMEHKNCCIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float DEHJJGCKKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float JJBLDKPBEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<KLCHICDKINL> HGCFDMFDOOK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NONGCLDDBIL CFKJDDFHBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62028C0", Offset = "0x62018C0", VA = "0x1862028C0")]
	public MJJHNJHFIKO(int JOFDHLCGHEI, int AMEHKNCCIOC, float DEHJJGCKKEO, int LPHANAKBLFB, float JJBLDKPBEMJ = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62026F0", Offset = "0x62016F0", VA = "0x1862026F0")]
	public void MAIMHFEEFFC(List<ODPMFFJGIMG> AFCABONIINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6201A40", Offset = "0x6200A40", VA = "0x186201A40")]
	public bool BDJDJHFHACH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6202280", Offset = "0x6201280", VA = "0x186202280")]
	private float JKKFKMFBKGP(Vector3 HBOEBLPEGBN, Vector3 ILNGOKDLDJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62022D0", Offset = "0x62012D0", VA = "0x1862022D0")]
	private float JKKFKMFBKGP(Vector3 GFFAGBDKDAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6201AB0", Offset = "0x6200AB0", VA = "0x186201AB0")]
	private bool EJEHHPCHFGC(KLCHICDKINL NJIAKLOGGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6200F20", Offset = "0x61FFF20", VA = "0x186200F20")]
	private GFCIJKENAPC AFIADLOLCBK(List<ODPMFFJGIMG> NJLEEPGEMHP, DPLMMMDNKHG NLDGLLBFPKI)
	{
		return default(GFCIJKENAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62022F0", Offset = "0x62012F0", VA = "0x1862022F0")]
	private void KNFDKDLJELF(List<ODPMFFJGIMG> AFCABONIINP, Vector3[] DEMEGHDJCEO, Vector3[] FOEFPDBFIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DJPOKNIDKCD
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61F91E0", Offset = "0x61F81E0", VA = "0x1861F91E0")]
	public static Bounds AAGKPFFGJII(List<ODPMFFJGIMG> AFCABONIINP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61F93B0", Offset = "0x61F83B0", VA = "0x1861F93B0")]
	public static int PMCAHLHIGFI(List<ODPMFFJGIMG> AFCABONIINP, MCIGCFAGBDP ODIANCNJLNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JGNCKMJLDJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DGFJOPHFDKD LIENOEDAAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DGFJOPHFDKD ENKBIKDHLHF;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static DGFJOPHFDKD DDJNKOBAFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MMHMMEEICPE OJJOCHIHNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private BHBGCKFONGN LKAHBEGEPCB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle NFHOJLAMIPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85AF30", Offset = "0x859F30", VA = "0x18085AF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DHOOJMKGAFG.FLLGIBKFOBD NJIAKLOGGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KGKCINEICFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x538C890", Offset = "0x538B890", VA = "0x18538C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61FEF60", Offset = "0x61FDF60", VA = "0x1861FEF60")]
	[LDBHLFMBBNG(EOOOIHNINMG.ExitingPlayMode, 0)]
	private static void GFANBDGDPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61FE640", Offset = "0x61FD640", VA = "0x1861FE640")]
	public void CPHLHCOPMDI(DHOOJMKGAFG.FLLGIBKFOBD GMHGLCOABOA, Transform NBPIECLAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x61FF020", Offset = "0x61FE020", VA = "0x1861FF020")]
	public void KAKEJDGHHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x61FEEF0", Offset = "0x61FDEF0", VA = "0x1861FEEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x61FEFE0", Offset = "0x61FDFE0", VA = "0x1861FEFE0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x61FF6C0", Offset = "0x61FE6C0", VA = "0x1861FF6C0")]
	public JGNCKMJLDJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HMMKJLJIOHA
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 MCOIELHPANN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EKCDKKDKDHN
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(NENCAGLHEIB<string>.OGJMFKKDMDA EAODOJLHGMO, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ALGMNOCBLNC
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALGMNOCBLNC CEDDFLIGGOF(Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALGMNOCBLNC NGNOKNNAPDO(Action LNMJHEPMAAO);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class KECEKPKLNIA : ALGMNOCBLNC
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			[CompilerGenerated]
			private sealed class ODDNIDLEPKD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public KECEKPKLNIA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
				public ODDNIDLEPKD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x6206050", Offset = "0x6205050", VA = "0x186206050")]
				internal void PCEOGGHBFFD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x6205FB0", Offset = "0x6204FB0", VA = "0x186205FB0")]
				internal void FKMMHOCIGKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x6206000", Offset = "0x6205000", VA = "0x186206000")]
				internal void JDJDFNGNLHD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> IAKPNHNLFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action GDIJBAIAJOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action NIHDPBKHBKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private AOFCCJFKLBL EBKPEAJJGBF;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action MECHPFDEFKA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action CIGKMPBFBHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x41E5700", Offset = "0x41E4700", VA = "0x1841E5700", Slot = "4")]
			public ALGMNOCBLNC CEDDFLIGGOF(Action LNMJHEPMAAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5CD9B00", Offset = "0x5CD8B00", VA = "0x185CD9B00", Slot = "5")]
			public ALGMNOCBLNC NGNOKNNAPDO(Action LNMJHEPMAAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
			public KECEKPKLNIA(Func<JobHandle> FADECELPJDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6200710", Offset = "0x61FF710", VA = "0x186200710")]
			public void AOFLBJDIDMG(Action GDDLOMCFNKP, Action INJHOPACLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x62009D0", Offset = "0x61FF9D0", VA = "0x1862009D0")]
			public void NCLCGNJGAKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class OHMDEPOEFGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public ALGMNOCBLNC jobHandle;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public OHMDEPOEFGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6206700", Offset = "0x6205700", VA = "0x186206700")]
			internal bool NCOIPPJJPEH(KECEKPKLNIA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OEKBAELHEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public KECEKPKLNIA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public OEKBAELHEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x62060A0", Offset = "0x62050A0", VA = "0x1862060A0")]
			internal void HMGJFGOOFPH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<KECEKPKLNIA> FMFKIJNLHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<KECEKPKLNIA> LCAFHANOAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private EOCGEKKEBMP EMNLEMEFDJE;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HDDBLMAHLGE PLFICDHANCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61FF8D0", Offset = "0x61FE8D0", VA = "0x1861FF8D0")]
		public ALGMNOCBLNC Add(Func<JobHandle> FADECELPJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61FFC00", Offset = "0x61FEC00", VA = "0x1861FFC00")]
		public void Remove(ALGMNOCBLNC NFHOJLAMIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61FFA30", Offset = "0x61FEA30", VA = "0x1861FFA30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61FFDD0", Offset = "0x61FEDD0", VA = "0x1861FFDD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6200030", Offset = "0x61FF030", VA = "0x186200030")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61FFA20", Offset = "0x61FEA20", VA = "0x1861FFA20")]
		[CompilerGenerated]
		private void HDEFMMHOKJN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AOFCCJFKLBL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOFCCJFKLBL CEDDFLIGGOF(Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AOFCCJFKLBL LODOKNBCJKM(Action LNMJHEPMAAO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOFCCJFKLBL NGNOKNNAPDO(Action LNMJHEPMAAO);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private class CPCCDEPODPI : AOFCCJFKLBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle LOMDIIOKBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action GDIJBAIAJOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action BNNDPAIMEHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action CIGKMPBFBHC;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool IJLLMBECAKB
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x61F64F0", Offset = "0x61F54F0", VA = "0x1861F64F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC220", Offset = "0x5BEB220", VA = "0x185BEC220", Slot = "4")]
			public AOFCCJFKLBL CEDDFLIGGOF(Action LNMJHEPMAAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC240", Offset = "0x5BEB240", VA = "0x185BEC240", Slot = "5")]
			public AOFCCJFKLBL LODOKNBCJKM(Action LNMJHEPMAAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5CD9B00", Offset = "0x5CD8B00", VA = "0x185CD9B00", Slot = "6")]
			public AOFCCJFKLBL NGNOKNNAPDO(Action LNMJHEPMAAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1BE9E40", Offset = "0x1BE8E40", VA = "0x181BE9E40")]
			public CPCCDEPODPI(JobHandle FKGMIMECEBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x61F64A0", Offset = "0x61F54A0", VA = "0x1861F64A0")]
			public void DDOGPGPMMPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x61F6500", Offset = "0x61F5500", VA = "0x1861F6500")]
			public void NCLCGNJGAKA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<CPCCDEPODPI> CKMDLEBCNBP;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6200530", Offset = "0x61FF530", VA = "0x186200530")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6200110", Offset = "0x61FF110", VA = "0x186200110")]
		public AOFCCJFKLBL Add(JobHandle FKGMIMECEBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6200430", Offset = "0x61FF430", VA = "0x186200430")]
		public void Remove(AOFCCJFKLBL NFHOJLAMIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6200280", Offset = "0x61FF280", VA = "0x186200280", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62001B0", Offset = "0x61FF1B0", VA = "0x1862001B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6200670", Offset = "0x61FF670", VA = "0x186200670")]
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
