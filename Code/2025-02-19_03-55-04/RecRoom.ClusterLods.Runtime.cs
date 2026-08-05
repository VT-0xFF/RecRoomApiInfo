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
				[Cpp2IlInjected.Address(RVA = "0x73D1FA0", Offset = "0x73D0BA0", VA = "0x1873D1FA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xC08BD0", Offset = "0xC077D0", VA = "0x180C08BD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x73D1F60", Offset = "0x73D0B60", VA = "0x1873D1F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C3CA0", Offset = "0x73C28A0", VA = "0x1873C3CA0")]
		public LODSettings POCNKEFOGJD(MGDBPAMBEJB IMJJMIHFOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73C3BE0", Offset = "0x73C27E0", VA = "0x1873C3BE0")]
		public int BCNJDLIDEIF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73C3C00", Offset = "0x73C2800", VA = "0x1873C3C00")]
		public int COEOAKMLIFF(bool MOHJADGNBAB, Vector3 MJIHIKEBKLA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73C3CB0", Offset = "0x73C28B0", VA = "0x1873C3CB0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PLKIADLPDAD
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
public interface LJJHIIGOFKI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDHBKAMKMJH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HEELKJEEMNE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FNAFJIIIDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<FLLBBDCAKFK> NLGOLGFCIKP
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
	void UpdateClusterDistances(Vector3 CHHMDBOKADH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(IEBLKOFFNGF AKHNIBOPJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FLLBBDCAKFK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int JMIFPKJCMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NHCELMKAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float IJLLCDMLONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MAJNOKONBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte CMGKHMCCAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BFPOKOLMNLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JIAANMKAPNP
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
	private struct FMINEKGDBJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public BFPOKOLMNLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x73C8150", Offset = "0x73C6D50", VA = "0x1873C8150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73C88E0", Offset = "0x73C74E0", VA = "0x1873C88E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GAEECDAAMCI : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BFPOKOLMNLA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public GAEECDAAMCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73C91E0", Offset = "0x73C7DE0", VA = "0x1873C91E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73C9310", Offset = "0x73C7F10", VA = "0x1873C9310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NNKCNJEKBFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public BFPOKOLMNLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FNEANCIAOBI<string>.IDKBCAKILKJ worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FNEANCIAOBI<string>.IDKBCAKILKJ <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x73D2720", Offset = "0x73D1320", VA = "0x1873D2720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73D3F80", Offset = "0x73D2B80", VA = "0x1873D3F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JFEGEGLGEMH : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BFPOKOLMNLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public JFEGEGLGEMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC50", Offset = "0x73CC850", VA = "0x1873CDC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73CE940", Offset = "0x73CD540", VA = "0x1873CE940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int GIMOIDHHNCM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NBNBCHMECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ELGICNFFHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter LKMDKHEJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject EHLJOAOHMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject HJIEJBPBLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public HDIPGHNPGFC OKCFKMOKGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IEBLKOFFNGF> JLHMOKIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IEBLKOFFNGF> MBKKIAOGNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<IEBLKOFFNGF> BNNIIPHGMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HKDKOMCBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JIAANMKAPNP LNGBCKOEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<HEELKJEEMNE>[] LKMFPIECPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<FLLBBDCAKFK>[] IMJJIBMDGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource OHCJAHMOKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool LHEKNLGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NAEMDCMJKFJ LFKLMBLGNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NAEMDCMJKFJ MKIOGBJPLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int IJIMBKJCNOM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BFPOKOLMNLA JHOMDMKMMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CMHAKOLFOMN BMIHHLGCECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FCDEHBFAKPP BHMBJDGJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour LAEHJEPEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material AOJMJLIEGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> NMDPEJMKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material OBMNFBEOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> EAPCNEJBNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool GBNOBGOOMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<LJJHIIGOFKI> KHFHOGCDHFK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig PKJJMPLJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 JCOJBLGHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B65F40", Offset = "0x1B64B40", VA = "0x181B65F40")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B65E70", Offset = "0x1B64A70", VA = "0x181B65E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private JIAANMKAPNP IDKICPMAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD75340", Offset = "0xD73F40", VA = "0x180D75340")]
		get
		{
			return default(JIAANMKAPNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x73C10C0", Offset = "0x73BFCC0", VA = "0x1873C10C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BFPOKOLMNLA FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73C2D50", Offset = "0x73C1950", VA = "0x1873C2D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool ILLGCPLNMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73C2410", Offset = "0x73C1010", VA = "0x1873C2410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HPNLJGIDFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x73C28C0", Offset = "0x73C14C0", VA = "0x1873C28C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> EDGLKMIHOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73C2020", Offset = "0x73C0C20", VA = "0x1873C2020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73C1E90", Offset = "0x73C0A90", VA = "0x1873C1E90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OKKIBOPLDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x73C2DA0", Offset = "0x73C19A0", VA = "0x1873C2DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x73C1960", Offset = "0x73C0560", VA = "0x1873C1960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73C3010", Offset = "0x73C1C10", VA = "0x1873C3010")]
	public BFPOKOLMNLA(CMHAKOLFOMN BMIHHLGCECC, FCDEHBFAKPP BHMBJDGJLCC, ClusterLODConfig FHNNAGHIAIG, MonoBehaviour LAEHJEPEMJB, Material IBDJKNGHICG, ClusterMeshRenderer ELGICNFFHGE, MeshFilter LKMDKHEJOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73C09C0", Offset = "0x73BF5C0", VA = "0x1873C09C0")]
	private void DDMBKPHGKHD(Material IBDJKNGHICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73C2200", Offset = "0x73C0E00", VA = "0x1873C2200")]
	public void JIKNCPLNNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73BFCB0", Offset = "0x73BE8B0", VA = "0x1873BFCB0")]
	public static IKFMJHEMOMC.HNHCDJDDKOE AAJNNAHEBNA(IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH)
	{
		return default(IKFMJHEMOMC.HNHCDJDDKOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x73C0CF0", Offset = "0x73BF8F0", VA = "0x1873C0CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x73C2EB0", Offset = "0x73C1AB0", VA = "0x1873C2EB0")]
	public static void OFOGIJAAABC(Vector3 BJBNPDGKDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73C18D0", Offset = "0x73C04D0", VA = "0x1873C18D0")]
	private void ENCEODHEFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73C1F50", Offset = "0x73C0B50", VA = "0x1873C1F50")]
	private void GDPFCBOGHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73C26E0", Offset = "0x73C12E0", VA = "0x1873C26E0")]
	private void MKKIKEPHEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73C0020", Offset = "0x73BEC20", VA = "0x1873C0020")]
	public void CEHPODHMOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73C20E0", Offset = "0x73C0CE0", VA = "0x1873C20E0")]
	[AsyncStateMachine(typeof(FMINEKGDBJB))]
	public Task JBLPACEPIPB(FNEANCIAOBI<string>.IDKBCAKILKJ AIJLLEIFBHM, CancellationToken MJJLMJBFHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73C1D90", Offset = "0x73C0990", VA = "0x1873C1D90")]
	[IteratorStateMachine(typeof(GAEECDAAMCI))]
	private IEnumerator<LNKBBFODFEI> FIGPLOHKFNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73C2560", Offset = "0x73C1160", VA = "0x1873C2560")]
	[AsyncStateMachine(typeof(NNKCNJEKBFC))]
	private Task MELNCJNJANH(FNEANCIAOBI<string>.IDKBCAKILKJ GBODMMFMNGH, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73C06B0", Offset = "0x73BF2B0", VA = "0x1873C06B0")]
	public void COMKMFHEONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73C0940", Offset = "0x73BF540", VA = "0x1873C0940")]
	public void DBHFADLIINI(IEnumerable<HEELKJEEMNE> NLMOAOBPJJP, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x73C1A90", Offset = "0x73C0690", VA = "0x1873C1A90")]
	public void FFFFDPHIOIG(IEnumerable<HEELKJEEMNE> NLMOAOBPJJP, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73C11F0", Offset = "0x73BFDF0", VA = "0x1873C11F0")]
	public List<ClusterMeshRenderer> EKGFGHCKKJC(List<IEBLKOFFNGF> KOMDPPACKBC, MLDOPOKHGBO EBMDCHEPJIM, PLKIADLPDAD ONGOOIJKOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73C2500", Offset = "0x73C1100", VA = "0x1873C2500")]
	public void LBFKGNIJLNO(LJJHIIGOFKI BHAMBEIAEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73C2680", Offset = "0x73C1280", VA = "0x1873C2680")]
	public bool MFEFEJMBGCA(LJJHIIGOFKI BHAMBEIAEDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73C2E50", Offset = "0x73C1A50", VA = "0x1873C2E50")]
	public void OENCMDCPKEG(IEBLKOFFNGF DNCPFDPMEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x73C0C70", Offset = "0x73BF870", VA = "0x1873C0C70")]
	public void DIJHLIMGBNE(FLLBBDCAKFK FCIAFOBBBBA, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x73C1E10", Offset = "0x73C0A10", VA = "0x1873C1E10")]
	public void FIONAODGAKH(FLLBBDCAKFK FCIAFOBBBBA, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B30", Offset = "0x73BF730", VA = "0x1873C0B30")]
	private void DEEIGPKICMJ(Vector3 CHHMDBOKADH, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73BFEC0", Offset = "0x73BEAC0", VA = "0x1873BFEC0")]
	private void CDPOFJPHAII(Vector3 CHHMDBOKADH, PLKIADLPDAD ONGOOIJKOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73C1A10", Offset = "0x73C0610", VA = "0x1873C1A10")]
	[IteratorStateMachine(typeof(JFEGEGLGEMH))]
	private IEnumerator<LNKBBFODFEI> EOKFJALOLNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73C22A0", Offset = "0x73C0EA0", VA = "0x1873C22A0")]
	private int JOABOBLAEEM(int BIEEMEKMINN, int CEFLLNOGKLN, List<FLLBBDCAKFK> CILCJBFBJDE, byte IMJJMIHFOFD, int FPLFHKFOKHN, float ALILPHGABJA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73BFD10", Offset = "0x73BE910", VA = "0x1873BFD10")]
	public void BLAPNJAELFA(IEBLKOFFNGF AKHNIBOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x73C0670", Offset = "0x73BF270", VA = "0x1873C0670")]
	public bool CMOKFECIFII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79C30", VA = "0x180B7B030")]
	public Material MLHMOHJMLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73C2830", Offset = "0x73C1430", VA = "0x1873C2830")]
	public Material MLHMOHJMLPM(IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x95A5D0", Offset = "0x9591D0", VA = "0x18095A5D0")]
	public Material DAPNLEMGMOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x73C08B0", Offset = "0x73BF4B0", VA = "0x1873C08B0")]
	public Material DAPNLEMGMOD(IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73BFCD0", Offset = "0x73BE8D0", VA = "0x1873BFCD0")]
	public int BCNJDLIDEIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x73C2980", Offset = "0x73C1580", VA = "0x1873C2980")]
	public (long, int) NAOFGKCIFNH()
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
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct IAIDOOLBJJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> IGNAGLFMHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> JFHHEEHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> AEJHMBMGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> MEADJLEFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> LGMIMGGGPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> LDOJKNAIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> JDOCOCGLGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 OFFFLCPBBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float LLBBKOFKFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> HJKMABGICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> BKHNCKBIBPC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73CD9A0", Offset = "0x73CC5A0", VA = "0x1873CD9A0")]
	public IAIDOOLBJJD(IKFMJHEMOMC LDLKDBPEDDB, NativeList<float3> JDOCOCGLGKM, NativeParallelMultiHashMap<int, int> HJKMABGICFC, NativeArray<int> BKHNCKBIBPC, Vector3 OFFFLCPBBBB, float LLBBKOFKFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x73CD940", Offset = "0x73CC540", VA = "0x1873CD940")]
	private int MABMHDBEAGB(float3 CHHMDBOKADH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x73CD2A0", Offset = "0x73CBEA0", VA = "0x1873CD2A0")]
	private int CGBDJHHHAFK(int GFMJIHODIPC, int NKANGPLHEGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73CD510", Offset = "0x73CC110", VA = "0x1873CD510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NBABICJLLKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> HJKMABGICFC;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> BKHNCKBIBPC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int IGLMNELFHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> EBMJDLCJIPG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73D2190", Offset = "0x73D0D90", VA = "0x1873D2190")]
	public void ILALBFNALEM(int EIEMIDPEPMN, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x73D20B0", Offset = "0x73D0CB0", VA = "0x1873D20B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NBABICJLLKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IBGDFHGNFKK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> PDNFJFFPDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> HBLELDPOMPN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73CDB10", Offset = "0x73CC710", VA = "0x1873CDB10")]
	public IBGDFHGNFKK(NBABICJLLKH NOHDDJHDBLL, IKFMJHEMOMC LDLKDBPEDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x73CDA60", Offset = "0x73CC660", VA = "0x1873CDA60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PMNKEEMINNN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> FBGCNOFNMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> MFGLDJCAABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> HDCMGBMNAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> BFGFACNNMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> KDBBKDGMKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> EBMJDLCJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> PDNFJFFPDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> OKKFPNECNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> MBLHDNJPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> MNGDHDGGFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> LJJHIDIIJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> NDFPPLIHJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> BEJINMPKEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float AGFGHNDPHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float OHFJGGIEAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 OEHBGCCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float AEHPJKPFNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float FCMHOGAHCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float JOBEKHJDCMI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73D5A20", Offset = "0x73D4620", VA = "0x1873D5A20")]
	public PMNKEEMINNN(NBABICJLLKH CNDNMIJIMEB, IKFMJHEMOMC LDLKDBPEDDB, IKFMJHEMOMC JKNMBKHMPFO, float FCMHOGAHCFE, float JOBEKHJDCMI, Vector3 OEHBGCCAEMF, float AEHPJKPFNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73D5230", Offset = "0x73D3E30", VA = "0x1873D5230")]
	private float3 IPLDMGDBILL(int GFMJIHODIPC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73D4580", Offset = "0x73D3180", VA = "0x1873D4580")]
	private void EGDBJCPCGAB(int GFMJIHODIPC, [Out] float3 HKLCGFAONPN, [Out] float3 GFKKJOOCAEN, [Out] float4 CKKKIJMNACC, [Out] float4 CHHMIBPNGPI, [Out] float2 OGFKPOONKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x73D54E0", Offset = "0x73D40E0", VA = "0x1873D54E0")]
	private int MNDNMLBOPLK(int JAGOBFFNKPJ, int MKJNPAGDFFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73D52E0", Offset = "0x73D3EE0", VA = "0x1873D52E0")]
	private void JPNOOJEGAMD(int JAGOBFFNKPJ, int MKJNPAGDFFN, int IPHJJPPMMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73D50E0", Offset = "0x73D3CE0", VA = "0x1873D50E0")]
	private bool HPPGKFFJAGL(int JAGOBFFNKPJ, int MKJNPAGDFFN, float AINKNGKJCDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73D44C0", Offset = "0x73D30C0", VA = "0x1873D44C0")]
	private bool ALLHDCBKDPA(int JAGOBFFNKPJ, int MKJNPAGDFFN, int IPHJJPPMMKA, float AINKNGKJCDJ, bool ALABEMIMADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73D57C0", Offset = "0x73D43C0", VA = "0x1873D57C0")]
	private bool NABDHCJILKM(int JAGOBFFNKPJ, int MKJNPAGDFFN, int IPHJJPPMMKA, float AINKNGKJCDJ, bool ALABEMIMADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73D44A0", Offset = "0x73D30A0", VA = "0x1873D44A0")]
	private void AGBDHADHPIK(int JAGOBFFNKPJ, int MKJNPAGDFFN, int IPHJJPPMMKA, [Out] int MBPIMFLJGBJ, [Out] int HNOPJGKBJAH, [Out] int MOFMKFHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x73D4760", Offset = "0x73D3360", VA = "0x1873D4760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FLHJOPJPMHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FOCFKOAIGBB : IDisposable, FLLBBDCAKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds OLFOCEILLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<IEBLKOFFNGF> KOMDPPACKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 AEMIGKKKDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 MBOJIDOLFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int ABCHFOFPNCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public IKFMJHEMOMC HHPKNBPHPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long FAJCIMPBMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NBABICJLLKH NNJOGAMOCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform EBMDCHEPJIM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int EGPJCIMAKML
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x73C8BA0", Offset = "0x73C77A0", VA = "0x1873C8BA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh COANPCBDNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IKFMJHEMOMC.HNHCDJDDKOE MHBPMIBNLIE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9752D0", VA = "0x1809766D0")]
			[CompilerGenerated]
			get
			{
				return default(IKFMJHEMOMC.HNHCDJDDKOE);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC01130", Offset = "0xBFFD30", VA = "0x180C01130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CBGBNMKOMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x95D100", Offset = "0x95BD00", VA = "0x18095D100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IKFMJHEMOMC.HNHCDJDDKOE HJECPLMBPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCED400", Offset = "0xCEC000", VA = "0x180CED400")]
			[CompilerGenerated]
			get
			{
				return default(IKFMJHEMOMC.HNHCDJDDKOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xCED410", Offset = "0xCEC010", VA = "0x180CED410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float IJLLCDMLONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xEDD030", Offset = "0xEDBC30", VA = "0x180EDD030", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x15263C0", Offset = "0x1524FC0", VA = "0x1815263C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte CMGKHMCCAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x14699B0", Offset = "0x14685B0", VA = "0x1814699B0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x146DC10", Offset = "0x146C810", VA = "0x18146DC10", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JMIFPKJCMOE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x98F7C0", Offset = "0x98E3C0", VA = "0x18098F7C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x110CF70", Offset = "0x110BB70", VA = "0x18110CF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int NHCELMKAOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x97FE30", Offset = "0x97EA30", VA = "0x18097FE30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x110CF80", Offset = "0x110BB80", VA = "0x18110CF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MAJNOKONBPA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x73C8FF0", Offset = "0x73C7BF0", VA = "0x1873C8FF0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73C8940", Offset = "0x73C7540", VA = "0x1873C8940")]
		public void DAFNCENOIAA(MGDBPAMBEJB IMJJMIHFOFD, [Out] int FMJGJMIJBHM, [Out] int EOBBLLBGIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x73C8D90", Offset = "0x73C7990", VA = "0x1873C8D90")]
		public void EGKHEFNLBPF(MGDBPAMBEJB IMJJMIHFOFD, DHJACBEOCJB CBDENEFPCEB, int KANFLGEMNAD = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x73C9010", Offset = "0x73C7C10", VA = "0x1873C9010")]
		public void IHJIHBCMIAA(Mesh LDLKDBPEDDB, IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73C8F60", Offset = "0x73C7B60", VA = "0x1873C8F60")]
		public void FLAANDDFMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73C8BE0", Offset = "0x73C77E0", VA = "0x1873C8BE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73C90C0", Offset = "0x73C7CC0", VA = "0x1873C90C0")]
		public FOCFKOAIGBB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds OLFOCEILLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public IKFMJHEMOMC.HNHCDJDDKOE OMPLJIAAJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<FOCFKOAIGBB> OOPHPNLAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public HHAKLLEBCHF AECEKEMFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer MGIILDCJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int MOGOCFEEAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh JDDPHIBIJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GIANMBKLHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x986300", Offset = "0x984F00", VA = "0x180986300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x986080", Offset = "0x984C80", VA = "0x180986080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int FNAFJIIIDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73C8000", Offset = "0x73C6C00", VA = "0x1873C8000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73C7020", Offset = "0x73C5C20", VA = "0x1873C7020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x73C8050", Offset = "0x73C6C50", VA = "0x1873C8050")]
	public int LGOEOGIIHDB(int LIDJNDMDOKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73C6E30", Offset = "0x73C5A30", VA = "0x1873C6E30")]
	public void CJHPALAHNFM(LNPHFDHNGOL NPMNEEKELLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73C71A0", Offset = "0x73C5DA0", VA = "0x1873C71A0")]
	public void EHOPMKIMIKI(Transform GKCIGODLLEC, bool MOEKJCJGHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x73C6A00", Offset = "0x73C5600", VA = "0x1873C6A00")]
	public bool BFOOPLEPKBO(bool CPLFECKGJMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73C79E0", Offset = "0x73C65E0", VA = "0x1873C79E0")]
	public void HFDLPCHIJNI(Transform EBMDCHEPJIM, bool MOEKJCJGHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73C6BC0", Offset = "0x73C57C0", VA = "0x1873C6BC0")]
	public bool BLAPNJAELFA(IEBLKOFFNGF AKHNIBOPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73C8080", Offset = "0x73C6C80", VA = "0x1873C8080")]
	public FLHJOPJPMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDIPGHNPGFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<FLHJOPJPMHO.FOCFKOAIGBB> AGLCKAFJCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HEIPJOHOILA KGFPNACOMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<FLHJOPJPMHO.FOCFKOAIGBB> GGFDOLKIJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int DMDLAGBBLKB;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x73C9A60", Offset = "0x73C8660", VA = "0x1873C9A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73CA490", Offset = "0x73C9090", VA = "0x1873CA490")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73C9C80", Offset = "0x73C8880", VA = "0x1873C9C80")]
	public void GFCJDEIJPEO(FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF, Transform EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x73C9880", Offset = "0x73C8480", VA = "0x1873C9880")]
	public void BLAPNJAELFA(FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73C9B40", Offset = "0x73C8740", VA = "0x1873C9B40")]
	private FLHJOPJPMHO.FOCFKOAIGBB FNFFCMNEPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73CA350", Offset = "0x73C8F50", VA = "0x1873CA350")]
	private bool LONHHABCDJN(FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73C9D40", Offset = "0x73C8940", VA = "0x1873C9D40")]
	private void HDDKLFAJAAH(FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73CA460", Offset = "0x73C9060", VA = "0x1873CA460")]
	public bool NAOEJPACPDA(FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x73CA0C0", Offset = "0x73C8CC0", VA = "0x1873CA0C0")]
	public bool KAFGFLAKMPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x73CA3F0", Offset = "0x73C8FF0", VA = "0x1873CA3F0")]
	private FLHJOPJPMHO.FOCFKOAIGBB MOBHOBPFFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73C9DA0", Offset = "0x73C89A0", VA = "0x1873C9DA0")]
	public long JEFMFLEJDDH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x73CA510", Offset = "0x73C9110", VA = "0x1873CA510")]
	public HDIPGHNPGFC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OOONFFKPEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int BEEFFHFOHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int MBFDJGNNOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float MOBMBIOKELF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<FLHJOPJPMHO> PNBLKPAFJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x73D4450", Offset = "0x73D3050", VA = "0x1873D4450")]
	public OOONFFKPEBF(int BEEFFHFOHGF, int MBFDJGNNOMF, float MFDMALPLEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x73D43A0", Offset = "0x73D2FA0", VA = "0x1873D43A0")]
	public void PHCDHGPOJGP(BLHKDEMBHMF OIBCOJFFFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x73D3FE0", Offset = "0x73D2BE0", VA = "0x1873D3FE0")]
	private int FDPIHLNIIKG(LNPHFDHNGOL PCMPEACCDMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x73D4130", Offset = "0x73D2D30", VA = "0x1873D4130")]
	private void PHCDHGPOJGP(LNPHFDHNGOL PCMPEACCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x73D4090", Offset = "0x73D2C90", VA = "0x1873D4090")]
	private void NLOLJEICMJG(LNPHFDHNGOL PCMPEACCDMA, FLHJOPJPMHO DMFJCDIBBMJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HEELKJEEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DCNAPEPIAIL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
			[DebuggerHidden]
			public DCNAPEPIAIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x73C5840", Offset = "0x73C4440", VA = "0x1873C5840", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x73C5A00", Offset = "0x73C4600", VA = "0x1873C5A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x73C5950", Offset = "0x73C4550", VA = "0x1873C5950", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x73C5950", Offset = "0x73C4550", VA = "0x1873C5950", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int FNAFJIIIDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x73C57E0", Offset = "0x73C43E0", VA = "0x1873C57E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<FLLBBDCAKFK> NLGOLGFCIKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x73C57C0", Offset = "0x73C43C0", VA = "0x1873C57C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> OOPHPNLAODD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FLHJOPJPMHO JDDPHIBIJCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PLKIADLPDAD OONOPMHHOLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PLKIADLPDAD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x95B850", Offset = "0x95A450", VA = "0x18095B850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool INNNFBBCDEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB0EAF0", Offset = "0xB0D6F0", VA = "0x180B0EAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73C3D10", Offset = "0x73C2910", VA = "0x1873C3D10")]
		public static ClusterMeshRenderer Create(FLHJOPJPMHO LDLKDBPEDDB, ClusterMeshRenderer ELGICNFFHGE, MeshFilter LKMDKHEJOCG, MLDOPOKHGBO EBMDCHEPJIM, PLKIADLPDAD ONGOOIJKOLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73C3F90", Offset = "0x73C2B90", VA = "0x1873C3F90", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73C4A90", Offset = "0x73C3690", VA = "0x1873C4A90", Slot = "9")]
		public bool TryRemoveClusterLODComponent(IEBLKOFFNGF AKHNIBOPJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x73C4840", Offset = "0x73C3440", VA = "0x1873C4840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73C44D0", Offset = "0x73C30D0", VA = "0x1873C44D0")]
		public void Init(FLHJOPJPMHO LDLKDBPEDDB, MeshFilter LKMDKHEJOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x73C3FF0", Offset = "0x73C2BF0", VA = "0x1873C3FF0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x73C4BC0", Offset = "0x73C37C0", VA = "0x1873C4BC0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 CHHMDBOKADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x73C4E70", Offset = "0x73C3A70", VA = "0x1873C4E70", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x73C4450", Offset = "0x73C3050", VA = "0x1873C4450")]
		[IteratorStateMachine(typeof(DCNAPEPIAIL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73C48D0", Offset = "0x73C34D0", VA = "0x1873C48D0")]
		public void SetupTagAndLayer(string PPIKKIDENAN, int ONGOOIJKOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73C48B0", Offset = "0x73C34B0", VA = "0x1873C48B0")]
		public bool Remove(IEBLKOFFNGF AKHNIBOPJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDAMHPIKEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int JIKBGFMEPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PKAJCFBDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int EOBBLLBGIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int FMJGJMIJBHM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x73C9860", Offset = "0x73C8460", VA = "0x1873C9860")]
	public HDAMHPIKEAC(int PKAJCFBDMNB, int EOBBLLBGIJG, int JIKBGFMEPPJ, int FMJGJMIJBHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HHAKLLEBCHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> IGNAGLFMHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> EBMJDLCJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> LDOJKNAIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<HDAMHPIKEAC> HPIBIPHMHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> EBACCFKEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> JHOCGEHILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> NKOPOIKLPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle IEMHNEHKIEH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ALCMCMGHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9885B0", Offset = "0x9871B0", VA = "0x1809885B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x987E20", Offset = "0x986A20", VA = "0x180987E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x73CC110", Offset = "0x73CAD10", VA = "0x1873CC110")]
	public void HGFFJCPBDPD(IKFMJHEMOMC CODMLFICIEF, NativeList<HDAMHPIKEAC> HPIBIPHMHKB, float PCNANBOKIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x73CCFE0", Offset = "0x73CBBE0", VA = "0x1873CCFE0")]
	public void LCEEDMGPHLJ(Transform EBMDCHEPJIM, bool MOEKJCJGHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x73CBE60", Offset = "0x73CAA60", VA = "0x1873CBE60")]
	public void BFOOPLEPKBO(FLHJOPJPMHO MGIILDCJJIC, bool CPLFECKGJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73CC000", Offset = "0x73CAC00", VA = "0x1873CC000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x73CD270", Offset = "0x73CBE70", VA = "0x1873CD270")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HHAKLLEBCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EBJJMEGGOFL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> IGNAGLFMHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> EBMJDLCJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<HDAMHPIKEAC> HENDPBHMBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> EBACCFKEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 OEHBGCCAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> JHOCGEHILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> NKOPOIKLPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool MOEKJCJGHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float HIIECIPAHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float EMPOFLMEBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float ILHLMDNILCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> LDOJKNAIJDP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73C64E0", Offset = "0x73C50E0", VA = "0x1873C64E0")]
	public EBJJMEGGOFL(HHAKLLEBCHF KFMEGCPILKG, Vector3 OEHBGCCAEMF, bool MOEKJCJGHGH, float HIIECIPAHNH, float EMPOFLMEBOH, float ILHLMDNILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73C5FE0", Offset = "0x73C4BE0", VA = "0x1873C5FE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IEBLKOFFNGF : LAAACBDNNIL
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds IAPNGBBNEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LNPHFDHNGOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<IEBLKOFFNGF> KOMDPPACKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public LNPHFDHNGOL KOIBCEOILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public LNPHFDHNGOL ECBENNHJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public LNPHFDHNGOL HGIOIHDLJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int FMJGJMIJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds OLFOCEILLOE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73D1DE0", Offset = "0x73D09E0", VA = "0x1873D1DE0")]
	public LNPHFDHNGOL(List<IEBLKOFFNGF> KOMDPPACKBC, [Optional] LNPHFDHNGOL KOIBCEOILEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BLHKDEMBHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<LNPHFDHNGOL> GNJEOJDJPIF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LNPHFDHNGOL JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73C37F0", Offset = "0x73C23F0", VA = "0x1873C37F0")]
	public BLHKDEMBHMF(LNPHFDHNGOL EBMDCHEPJIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JNDOAKLMCLM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GPIBOIHLONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int IGELAIHCIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int MGJJJCDPFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int AAIMJLIMACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int EONOEKGNAKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BJFMLKKFMIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int BIEDDNMFNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float MFCGONHELFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<IEBLKOFFNGF> KOMDPPACKBC;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x73C3790", Offset = "0x73C2390", VA = "0x1873C3790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NOAANELHIFH
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
	private GPIBOIHLONN NOJEDDIAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int INPGBGOGGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int BEEFFHFOHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int MBFDJGNNOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float MFDMALPLEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float EHJAMKEMCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<LNPHFDHNGOL> FFCHBMCPJLH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BLHKDEMBHMF GAAICOMLGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73D0A30", Offset = "0x73CF630", VA = "0x1873D0A30")]
	public JNDOAKLMCLM(int BEEFFHFOHGF, int MBFDJGNNOMF, float MFDMALPLEFI, int INPGBGOGGID, float EHJAMKEMCAE = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73CF810", Offset = "0x73CE410", VA = "0x1873CF810")]
	public void ILLHMCOJEEF(List<IEBLKOFFNGF> KOMDPPACKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73CE990", Offset = "0x73CD590", VA = "0x1873CE990")]
	public bool BJNLDOPBKCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73CF7A0", Offset = "0x73CE3A0", VA = "0x1873CF7A0")]
	private float ICOMIGKEIFP(Vector3 DMOKGKPBDAL, Vector3 IBGGHDAOBFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73CF7F0", Offset = "0x73CE3F0", VA = "0x1873CF7F0")]
	private float ICOMIGKEIFP(Vector3 FJJGAGKDECJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73CEDC0", Offset = "0x73CD9C0", VA = "0x1873CEDC0")]
	private bool GNJNLPIOGDB(LNPHFDHNGOL HGNPAKLMCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73CF9E0", Offset = "0x73CE5E0", VA = "0x1873CF9E0")]
	private BJFMLKKFMIE MPJEIGGNCLK(List<IEBLKOFFNGF> COHOGHPFDLA, NOAANELHIFH KOPBHHBKLAA)
	{
		return default(BJFMLKKFMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73CEA00", Offset = "0x73CD600", VA = "0x1873CEA00")]
	private void FBAMODNOKNO(List<IEBLKOFFNGF> KOMDPPACKBC, NativeArray<Vector3> FKAFGHILOGI, NativeArray<Vector3> EMBNEELKNLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class NKNLKEIFDOG
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x73D2550", Offset = "0x73D1150", VA = "0x1873D2550")]
	public static Bounds KPGCJINAGGA(List<IEBLKOFFNGF> KOMDPPACKBC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x73D2380", Offset = "0x73D0F80", VA = "0x1873D2380")]
	public static int BONDIKJEMKP(List<IEBLKOFFNGF> KOMDPPACKBC, MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class KAHMOHGAJEO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool LOAKDHEJILD(float4* LGMIMGGGPIJ, int OKLDJMDCMFC);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class GCLEOMNCECC
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr ICCCMGDKIPA;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr APHDEAJPJBH;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x73C9690", Offset = "0x73C8290", VA = "0x1873C9690")]
		[BurstDiscard]
		private static void KCLBMBELPOO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x73C9540", Offset = "0x73C8140", VA = "0x1873C9540")]
		private static IntPtr FGMIEGBABNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x73C97B0", Offset = "0x73C83B0", VA = "0x1873C97B0")]
		public static void NLJOLFNAAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public static void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x73C9360", Offset = "0x73C7F60", VA = "0x1873C9360")]
		public unsafe static bool AOKANKCOAFH(float4* LGMIMGGGPIJ, int OKLDJMDCMFC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x73D1BD0", Offset = "0x73D07D0", VA = "0x1873D1BD0")]
	[BurstCompile]
	public unsafe static bool AEFFGLHHAML(float4* LGMIMGGGPIJ, int OKLDJMDCMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x73BFAC0", Offset = "0x73BE6C0", VA = "0x1873BFAC0")]
	[BurstCompile]
	public unsafe static bool JKKNJMLBNKO(float4* LGMIMGGGPIJ, int OKLDJMDCMFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct CMIKLNLAEGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> GICMADNDFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> HCHODHGENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> DAPKFJJJPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> DJBMFJHIAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> FFFBIHJMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> MEADJLEFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> OPNNMJINACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> NMEKEJDNICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<IKFMJHEMOMC.HEKMGFFGGOH> DBIDIOHIDAI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x73C3B70", Offset = "0x73C2770", VA = "0x1873C3B70")]
	public CMIKLNLAEGO(IKFMJHEMOMC APKKBGFLCJE, NativeArray<bool> OPNNMJINACF, NativeList<ushort> NMEKEJDNICG, NativeList<IKFMJHEMOMC.HEKMGFFGGOH> DBIDIOHIDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x73C38C0", Offset = "0x73C24C0", VA = "0x1873C38C0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct DDKHPBEIEAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> GICMADNDFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> HCHODHGENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> DAPKFJJJPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> DJBMFJHIAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> FFFBIHJMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> MEADJLEFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> GEPHNMBAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> DJCLDNCCJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> BNHJKKENMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> JKFIIABBICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> HBICOIDHHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> KMMNENFIMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> OPNNMJINACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> NMEKEJDNICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<IKFMJHEMOMC.HEKMGFFGGOH> DBIDIOHIDAI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x73C5F20", Offset = "0x73C4B20", VA = "0x1873C5F20")]
	public DDKHPBEIEAK(IKFMJHEMOMC APKKBGFLCJE, IKFMJHEMOMC JIDMMILKPBE, NativeArray<bool> OPNNMJINACF, NativeList<ushort> NMEKEJDNICG, NativeList<IKFMJHEMOMC.HEKMGFFGGOH> DBIDIOHIDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x73C5A50", Offset = "0x73C4650", VA = "0x1873C5A50", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HEIPJOHOILA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private IKFMJHEMOMC GLIEHKAHLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private IKFMJHEMOMC APKKBGFLCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> NECGFHDNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> NMEKEJDNICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<IKFMJHEMOMC.HEKMGFFGGOH> DBIDIOHIDAI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static IKFMJHEMOMC OGGIJJLHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private GJKNGJPODAG PPDEFMDHBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DHJACBEOCJB CBDENEFPCEB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle IEMHNEHKIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAD8DD0", Offset = "0xAD79D0", VA = "0x180AD8DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FLHJOPJPMHO.FOCFKOAIGBB HGNPAKLMCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KIHGPJLOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x20B90A0", Offset = "0x20B7CA0", VA = "0x1820B90A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x73CB370", Offset = "0x73C9F70", VA = "0x1873CB370")]
	[CBLJHIHADGM(HEJIADEAGNL.EnteredEditMode, 0)]
	private static void MBMKFIBKKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x73CA850", Offset = "0x73C9450", VA = "0x1873CA850")]
	public void HGFFJCPBDPD(FLHJOPJPMHO.FOCFKOAIGBB HENDPBHMBOM, Transform AHALLELGDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x73CB420", Offset = "0x73CA020", VA = "0x1873CB420")]
	public void NKJLMHHJBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x73CA780", Offset = "0x73C9380", VA = "0x1873CA780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x73CB3E0", Offset = "0x73C9FE0", VA = "0x1873CB3E0")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x73CBCF0", Offset = "0x73CA8F0", VA = "0x1873CBCF0")]
	public HEIPJOHOILA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FCDEHBFAKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 PEJHKDJJKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CMHAKOLFOMN
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(FNEANCIAOBI<string>.IDKBCAKILKJ GBODMMFMNGH, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KJKNPLLHMPI
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJKNPLLHMPI DOEEJBDNOGH(Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJKNPLLHMPI HIFIILJAGEN(Action OAGMINHECCA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class EMMNLHIJKBP : KJKNPLLHMPI
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class MDOMOIJIGPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public EMMNLHIJKBP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
				public MDOMOIJIGPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x73D1FC0", Offset = "0x73D0BC0", VA = "0x1873D1FC0")]
				internal void GGOAAMEPGMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x73D2010", Offset = "0x73D0C10", VA = "0x1873D2010")]
				internal void JFKFPNBDAGF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x73D2060", Offset = "0x73D0C60", VA = "0x1873D2060")]
				internal void MEOLKGFJKMJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> AEOAEAOOGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action GEFBMJEBAOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action OLMEMKIBCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private AIJEKECJAPH HODPLAEONFF;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action AGAFCAOPKDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action NJADEMMDKIA
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4A193F0", Offset = "0x4A17FF0", VA = "0x184A193F0", Slot = "4")]
			public KJKNPLLHMPI DOEEJBDNOGH(Action OAGMINHECCA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6E19E00", Offset = "0x6E18A00", VA = "0x186E19E00", Slot = "5")]
			public KJKNPLLHMPI HIFIILJAGEN(Action OAGMINHECCA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
			public EMMNLHIJKBP(Func<JobHandle> OAOIFMAFFCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x73C65B0", Offset = "0x73C51B0", VA = "0x1873C65B0")]
			public void BDNCCGGPJGH(Action EDFEHJFJEJG, Action JMMNJJILOGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x73C6870", Offset = "0x73C5470", VA = "0x1873C6870")]
			public void BLAPNJAELFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class GCLHJGLBPAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public KJKNPLLHMPI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public GCLHJGLBPAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x73C9850", Offset = "0x73C8450", VA = "0x1873C9850")]
			internal bool PMNJANCBNJH(EMMNLHIJKBP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class IKFGGJFKNLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public EMMNLHIJKBP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IKFGGJFKNLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x73CDBF0", Offset = "0x73CC7F0", VA = "0x1873CDBF0")]
			internal void AAILENALNKP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<EMMNLHIJKBP> HDMLPPCHFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<EMMNLHIJKBP> OIFNLNLCOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private NAEMDCMJKFJ CAFHEMOMNMK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IDDMHCEEKLJ AEKNPHJKKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x73D0A90", Offset = "0x73CF690", VA = "0x1873D0A90")]
		public KJKNPLLHMPI Add(Func<JobHandle> OAOIFMAFFCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x73D0DC0", Offset = "0x73CF9C0", VA = "0x1873D0DC0")]
		public void Remove(KJKNPLLHMPI IEMHNEHKIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x73D0BF0", Offset = "0x73CF7F0", VA = "0x1873D0BF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x73D0FA0", Offset = "0x73CFBA0", VA = "0x1873D0FA0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x73D1200", Offset = "0x73CFE00", VA = "0x1873D1200")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73D0BE0", Offset = "0x73CF7E0", VA = "0x1873D0BE0")]
		[CompilerGenerated]
		private void NPIEOODFDPE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AIJEKECJAPH
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIJEKECJAPH DOEEJBDNOGH(Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIJEKECJAPH MEKMKLOHHML(Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIJEKECJAPH HIFIILJAGEN(Action OAGMINHECCA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, PMHAEKLGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class IJJEHJHPMGA : AIJEKECJAPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle GAAHJLHLIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action GEFBMJEBAOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action JBOOMNDADPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action NJADEMMDKIA;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MCDJDPMKNFM
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x73CDBE0", Offset = "0x73CC7E0", VA = "0x1873CDBE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6D407A0", Offset = "0x6D3F3A0", VA = "0x186D407A0", Slot = "4")]
			public AIJEKECJAPH DOEEJBDNOGH(Action OAGMINHECCA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6D407C0", Offset = "0x6D3F3C0", VA = "0x186D407C0", Slot = "5")]
			public AIJEKECJAPH MEKMKLOHHML(Action OAGMINHECCA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6E19E00", Offset = "0x6E18A00", VA = "0x186E19E00", Slot = "6")]
			public AIJEKECJAPH HIFIILJAGEN(Action OAGMINHECCA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xDB7430", Offset = "0xDB6030", VA = "0x180DB7430")]
			public IJJEHJHPMGA(JobHandle AIANMJKMLCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x73CDB40", Offset = "0x73CC740", VA = "0x1873CDB40")]
			public void BAHMIJKKLIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x73CDB90", Offset = "0x73CC790", VA = "0x1873CDB90")]
			public void BLAPNJAELFA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<IJJEHJHPMGA> CNAOJHHKCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> BHNOEIIBAPL;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OHHMMIABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x73D17E0", Offset = "0x73D03E0", VA = "0x1873D17E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x11C7720", Offset = "0x11C6320", VA = "0x1811C7720")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x73D12E0", Offset = "0x73CFEE0", VA = "0x1873D12E0")]
		public AIJEKECJAPH Add(JobHandle AIANMJKMLCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x73D19F0", Offset = "0x73D05F0", VA = "0x1873D19F0")]
		public void Remove(AIJEKECJAPH IEMHNEHKIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x73D1600", Offset = "0x73D0200", VA = "0x1873D1600")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x73D1450", Offset = "0x73D0050", VA = "0x1873D1450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x73D1380", Offset = "0x73CFF80", VA = "0x1873D1380")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x73D1AF0", Offset = "0x73D06F0", VA = "0x1873D1AF0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "6")]
		private bool DGIDCMLKFAK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x73D5B60", Offset = "0x73D4760", VA = "0x1873D5B60")]
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
