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
				[Cpp2IlInjected.Address(RVA = "0x7FCD760", Offset = "0x7FCC560", VA = "0x187FCD760")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xE83030", Offset = "0xE81E30", VA = "0x180E83030")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD720", Offset = "0x7FCC520", VA = "0x187FCD720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FC2170", Offset = "0x7FC0F70", VA = "0x187FC2170")]
		public LODSettings GJNNJGECMFJ(HNMFKBFJGMN IAOFFAAOAHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2150", Offset = "0x7FC0F50", VA = "0x187FC2150")]
		public int AKECNFLCFPF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2180", Offset = "0x7FC0F80", VA = "0x187FC2180")]
		public int KNHFCGCDNJH(bool HGGAPBAPJJC, Vector3 MLOPLGMOOCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2220", Offset = "0x7FC1020", VA = "0x187FC2220")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NFLFCFIKNGP
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
public interface KCPKDJMFOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJPBMKMNNGP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CEHHIBGBEIP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int AOOLDJGOLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<CDOEEOGNIKC> HNDALHHAOCC
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
	void UpdateClusterDistances(Vector3 MLCPBGGGOAK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(EDFFAFGGICA LPAADBJGJNL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CDOEEOGNIKC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FENMNCOPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int DCHGONLKLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float FOEJDEPIAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NKMKFOBDLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte FOFIPBPPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MFOMADMBOJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NOLIJJJDGDC
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
	private struct DCKIHAEKCBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MFOMADMBOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public EHDFINDMEJI<string>.NGEIFBMECIG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3EB0", Offset = "0x7FC2CB0", VA = "0x187FC3EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4640", Offset = "0x7FC3440", VA = "0x187FC4640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NICOBMHEKDO : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public MFOMADMBOJE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public NICOBMHEKDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1470", Offset = "0x7FD0270", VA = "0x187FD1470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD15A0", Offset = "0x7FD03A0", VA = "0x187FD15A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BJCBAHDANAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MFOMADMBOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EHDFINDMEJI<string>.NGEIFBMECIG worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private EHDFINDMEJI<string>.NGEIFBMECIG <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FBDD60", Offset = "0x7FBCB60", VA = "0x187FBDD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7FBF5D0", Offset = "0x7FBE3D0", VA = "0x187FBF5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CDHNOHNGBJI : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MFOMADMBOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public CDHNOHNGBJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFA80", Offset = "0x7FBE880", VA = "0x187FBFA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0770", Offset = "0x7FBF570", VA = "0x187FC0770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int MKAGMJDPAMP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan FLMAEMCPKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer KLDDAFNBKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter OEEFABLKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DDFDMJANMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject EHNDEDINDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public KCCAICICBHB FPAFNIMCADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<EDFFAFGGICA> NPHAFOKJDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EDFFAFGGICA> ODENPACFCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<EDFFAFGGICA> KKCFHAINOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JFDJOEEALIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NOLIJJJDGDC KKFDMACFPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CEHHIBGBEIP>[] LBKOLAINDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<CDOEEOGNIKC>[] EJMKNCIMGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource CBPGCOPMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HBIPLODHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IHBKINGAIAD DJLCEBAMKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IHBKINGAIAD DDCDPBDEEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int HJHDPPIJDGC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static MFOMADMBOJE DIPJLOIABCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JLPGMKOMIHA LKMBCDPIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FOAEJOBGBPF FKOANBPJLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour IALELAPCEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material NLBGCEBJAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> DENJCNJEBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material DCNPIJJFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> BKNEFJPFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ANIKFJIJEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<KCPKDJMFOLP> CPLKKIHIECM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig ADDIDOJALPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 OEKJPFCGBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2003940", Offset = "0x2002740", VA = "0x182003940")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2003860", Offset = "0x2002660", VA = "0x182003860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NOLIJJJDGDC JMAPLMHJFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10268A0", Offset = "0x10256A0", VA = "0x1810268A0")]
		get
		{
			return default(NOLIJJJDGDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDF10", Offset = "0x7FCCD10", VA = "0x187FCDF10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MFOMADMBOJE ODAOEPEFKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF9D0", Offset = "0x7FCE7D0", VA = "0x187FCF9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool NJOPHIHIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF630", Offset = "0x7FCE430", VA = "0x187FCF630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NPICALNOHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDA40", Offset = "0x7FCC840", VA = "0x187FCDA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> HMKMNEGJKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD01E0", Offset = "0x7FCEFE0", VA = "0x187FD01E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD04B0", Offset = "0x7FCF2B0", VA = "0x187FD04B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IAOBFBFJCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF400", Offset = "0x7FCE200", VA = "0x187FCF400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF730", Offset = "0x7FCE530", VA = "0x187FCF730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0CE0", Offset = "0x7FCFAE0", VA = "0x187FD0CE0")]
	public MFOMADMBOJE(JLPGMKOMIHA LKMBCDPIKIC, FOAEJOBGBPF FKOANBPJLGL, ClusterLODConfig HGLCHBFDDPB, MonoBehaviour IALELAPCEGB, Material CJNDLDOMIGK, ClusterMeshRenderer KLDDAFNBKBA, MeshFilter OEEFABLKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDB40", Offset = "0x7FCC940", VA = "0x187FCDB40")]
	private void BGDONBEIMEN(Material CJNDLDOMIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0B40", Offset = "0x7FCF940", VA = "0x187FD0B40")]
	public void PFHODMGEPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF4B0", Offset = "0x7FCE2B0", VA = "0x187FCF4B0")]
	public static JDKBCJCKCFH.KMNDCOOFIPA HNCBBDABNDN(JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH)
	{
		return default(JDKBCJCKCFH.KMNDCOOFIPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE730", Offset = "0x7FCD530", VA = "0x187FCE730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD940", Offset = "0x7FCC740", VA = "0x187FCD940")]
	public static void AJKEMDCGPKN(Vector3 JMNBACAAGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE040", Offset = "0x7FCCE40", VA = "0x187FCE040")]
	private void DELMCGOGMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF7E0", Offset = "0x7FCE5E0", VA = "0x187FCF7E0")]
	private void KJGGBAKFNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDCB0", Offset = "0x7FCCAB0", VA = "0x187FCDCB0")]
	private void BIJACIHKCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE0D0", Offset = "0x7FCCED0", VA = "0x187FCE0D0")]
	public void DPDGFGOJCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF510", Offset = "0x7FCE310", VA = "0x187FCF510")]
	[AsyncStateMachine(typeof(DCKIHAEKCBG))]
	public Task HPIBEDIAMPN(EHDFINDMEJI<string>.NGEIFBMECIG FEALJFKMNJI, CancellationToken FOJIDEIIGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF190", Offset = "0x7FCDF90", VA = "0x187FCF190")]
	[IteratorStateMachine(typeof(NICOBMHEKDO))]
	private IEnumerator<DMCHEKCEBGH> HBGKKAOJGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF8B0", Offset = "0x7FCE6B0", VA = "0x187FCF8B0")]
	[AsyncStateMachine(typeof(BJCBAHDANAB))]
	private Task KOCBAGMFNOP(EHDFINDMEJI<string>.NGEIFBMECIG BMCEBFCKDFE, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0570", Offset = "0x7FCF370", VA = "0x187FD0570")]
	public void OKKJPINNNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEFB0", Offset = "0x7FCDDB0", VA = "0x187FCEFB0")]
	public void FAKHBGCMCIB(IEnumerable<CEHHIBGBEIP> OBAEJBFIHDF, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEB00", Offset = "0x7FCD900", VA = "0x187FCEB00")]
	public void EAKBFFONKMM(IEnumerable<CEHHIBGBEIP> OBAEJBFIHDF, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFB00", Offset = "0x7FCE900", VA = "0x187FCFB00")]
	public List<ClusterMeshRenderer> NDCFNLAKEHJ(List<EDFFAFGGICA> IDGINNJADGF, GKKGCGDMMHN EGPDFGOHLFM, NFLFCFIKNGP FEMFINBCNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FD02A0", Offset = "0x7FCF0A0", VA = "0x187FD02A0")]
	public void NPLAEGFCAHE(KCPKDJMFOLP LPLICPLPDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0300", Offset = "0x7FCF100", VA = "0x187FD0300")]
	public bool OCPNMKHJHMG(KCPKDJMFOLP LPLICPLPDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFA20", Offset = "0x7FCE820", VA = "0x187FCFA20")]
	public void LBEPGNHBAKK(EDFFAFGGICA JBIHJALEJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF210", Offset = "0x7FCE010", VA = "0x187FCF210")]
	public void HFOOBEBOPJI(CDOEEOGNIKC MDHOEKKPKHF, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDE00", Offset = "0x7FCCC00", VA = "0x187FCDE00")]
	public void CCBOMBMCNHG(CDOEEOGNIKC MDHOEKKPKHF, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0360", Offset = "0x7FCF160", VA = "0x187FD0360")]
	private void OEIAIGPOBPL(Vector3 MLCPBGGGOAK, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF030", Offset = "0x7FCDE30", VA = "0x187FCF030")]
	private void HAPBLHOGGAP(Vector3 MLCPBGGGOAK, NFLFCFIKNGP FEMFINBCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFA80", Offset = "0x7FCE880", VA = "0x187FCFA80")]
	[IteratorStateMachine(typeof(CDHNOHNGBJI))]
	private IEnumerator<DMCHEKCEBGH> NCIJOCEMMKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF290", Offset = "0x7FCE090", VA = "0x187FCF290")]
	private int HHMPJAHAFHL(int CKFKPOAGPKN, int LPMNCBJBMLK, List<CDOEEOGNIKC> NAHJPKDLHLG, byte IAOFFAAOAHE, int KDIAJGJFMBC, float GNNLGEFOELM = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEE00", Offset = "0x7FCDC00", VA = "0x187FCEE00")]
	public void EBNLHEFHMEO(EDFFAFGGICA LPAADBJGJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF4D0", Offset = "0x7FCE2D0", VA = "0x187FCF4D0")]
	public bool HOFKDOKNGBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0D260", VA = "0x180B0E460")]
	public Material POFJCMMBNDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0BE0", Offset = "0x7FCF9E0", VA = "0x187FD0BE0")]
	public Material POFJCMMBNDN(JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA65C40", Offset = "0xA64A40", VA = "0x180A65C40")]
	public Material CDLMJCLKNDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDE80", Offset = "0x7FCCC80", VA = "0x187FCDE80")]
	public Material CDLMJCLKNDC(JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDB00", Offset = "0x7FCC900", VA = "0x187FCDB00")]
	public int AKECNFLCFPF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0770", Offset = "0x7FCF570", VA = "0x187FD0770")]
	public (long, int) OMNFIHGAGDF()
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
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KOPEADILFAB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> MNCLBNBEOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> HCNCDBOMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> BDLHCPMEIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> LMONDNDJEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> FILDHJBCFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 JHLOHJFNABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float BDFAJOHKLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> BGGOKGNPFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> PAFMHEELNKC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC220", Offset = "0x7FCB020", VA = "0x187FCC220")]
	public KOPEADILFAB(JDKBCJCKCFH JLPONKINLEO, NativeList<float3> FILDHJBCFGC, NativeParallelMultiHashMap<int, int> BGGOKGNPFAA, NativeArray<int> PAFMHEELNKC, Vector3 JHLOHJFNABF, float BDFAJOHKLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBB20", Offset = "0x7FCA920", VA = "0x187FCBB20")]
	private int BBLCDEBCGCA(float3 MLCPBGGGOAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBFB0", Offset = "0x7FCADB0", VA = "0x187FCBFB0")]
	private int NHDHKHBDIMC(int BOECAAOIBHO, int MAHBBBBCDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBB80", Offset = "0x7FCA980", VA = "0x187FCBB80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IFHGMDHHMAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> BGGOKGNPFAA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> PAFMHEELNKC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int CNHMEMACEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> JEJOPFBOHAA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9480", Offset = "0x7FC8280", VA = "0x187FC9480")]
	public void JENODILHELO(int KEAPCBAFJDC, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC93A0", Offset = "0x7FC81A0", VA = "0x187FC93A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public IFHGMDHHMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KCCDNMHBCFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> LHGHKLFILDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> CCOIJPJGAFP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBA90", Offset = "0x7FCA890", VA = "0x187FCBA90")]
	public KCCDNMHBCFB(IFHGMDHHMAL MJKNEJABEEF, JDKBCJCKCFH JLPONKINLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB9E0", Offset = "0x7FCA7E0", VA = "0x187FCB9E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct FCCHKDLDAMM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> AMCOFPFBGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> EMPGFICGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> FPBNMFCOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> HBICOPMNLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> HAFGNOFIIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> JEJOPFBOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> LHGHKLFILDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> GMFHLLDJCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> PBKGJILPMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> OHIIGEMJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> LNBGNNLOLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> BALFFIJHIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> MOKMNAMPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float JGEFEPGJOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float OJELJOOAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 KIJFFLMIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float LLHFMALGLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float NPLJJMLKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float NGOCCMOBNDC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5CB0", Offset = "0x7FC4AB0", VA = "0x187FC5CB0")]
	public FCCHKDLDAMM(IFHGMDHHMAL KKEGOCHOAHB, JDKBCJCKCFH JLPONKINLEO, JDKBCJCKCFH BIJKMALIGOK, float NPLJJMLKJIC, float NGOCCMOBNDC, Vector3 KIJFFLMIFKF, float LLHFMALGLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FC57D0", Offset = "0x7FC45D0", VA = "0x187FC57D0")]
	private float3 LHKCPILKBKH(int BOECAAOIBHO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4730", Offset = "0x7FC3530", VA = "0x187FC4730")]
	private void BHCJJPGPBOC(int BOECAAOIBHO, [Out] float3 LBKFAKOGLJC, [Out] float3 FAHPJDLJHAP, [Out] float4 IDGFCCFLJEA, [Out] float4 JOFNHOCBIGH, [Out] float2 MKAPAFMMDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FC54F0", Offset = "0x7FC42F0", VA = "0x187FC54F0")]
	private int KICBENFOGAL(int HLEJBCILNHK, int BFMHLIFMJAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5940", Offset = "0x7FC4740", VA = "0x187FC5940")]
	private void NPNBJENEKDF(int HLEJBCILNHK, int BFMHLIFMJAI, int HECIGBCJNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5B60", Offset = "0x7FC4960", VA = "0x187FC5B60")]
	private bool PABININDEPD(int HLEJBCILNHK, int BFMHLIFMJAI, float BBABJEGEDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5880", Offset = "0x7FC4680", VA = "0x187FC5880")]
	private bool NBHIJECEJBO(int HLEJBCILNHK, int BFMHLIFMJAI, int HECIGBCJNLP, float BBABJEGEDLK, bool EBEMFBJCGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4910", Offset = "0x7FC3710", VA = "0x187FC4910")]
	private bool ECHOBFPDPMB(int HLEJBCILNHK, int BFMHLIFMJAI, int HECIGBCJNLP, float BBABJEGEDLK, bool EBEMFBJCGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5B40", Offset = "0x7FC4940", VA = "0x187FC5B40")]
	private void OJLBAFLDFMC(int HLEJBCILNHK, int BFMHLIFMJAI, int HECIGBCJNLP, [Out] int KHEJBAHMDKD, [Out] int PJEMJBFEBFJ, [Out] int LMDDGPFKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4B70", Offset = "0x7FC3970", VA = "0x187FC4B70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CMENIEEAKIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HBLCPLFKAJG : IDisposable, CDOEEOGNIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds NHFILKMEGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<EDFFAFGGICA> IDGINNJADGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 GJBFKDBODAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 PPBKDEEAOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int OLJEIOFBDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JDKBCJCKCFH MPNNGGOMCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long NJMPMKMJGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IFHGMDHHMAL FJAFMBBPAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform EGPDFGOHLFM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int MGNHFMBFCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC86B0", Offset = "0x7FC74B0", VA = "0x187FC86B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KHPJFHKBBMH
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JDKBCJCKCFH.KMNDCOOFIPA EHBNOPKEDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750")]
			[CompilerGenerated]
			get
			{
				return default(JDKBCJCKCFH.KMNDCOOFIPA);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE749F0", Offset = "0xE737F0", VA = "0x180E749F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh AEJPHLPLJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JDKBCJCKCFH.KMNDCOOFIPA HPIFHHGCLJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xACBC40", Offset = "0xACAA40", VA = "0x180ACBC40")]
			[CompilerGenerated]
			get
			{
				return default(JDKBCJCKCFH.KMNDCOOFIPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xF881E0", Offset = "0xF86FE0", VA = "0x180F881E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FOEJDEPIAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x11F3CB0", Offset = "0x11F2AB0", VA = "0x1811F3CB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x197E360", Offset = "0x197D160", VA = "0x18197E360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte FOFIPBPPEDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7870", Offset = "0x1DC6670", VA = "0x181DC7870")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x21B3990", Offset = "0x21B2790", VA = "0x1821B3990", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int FENMNCOPBPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA8F990", Offset = "0xA8E790", VA = "0x180A8F990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x150D980", Offset = "0x150C780", VA = "0x18150D980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int DCHGONLKLHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA7FE00", Offset = "0xA7EC00", VA = "0x180A7FE00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x150D960", Offset = "0x150C760", VA = "0x18150D960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NKMKFOBDLCN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC8960", Offset = "0x7FC7760", VA = "0x187FC8960", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7FC86F0", Offset = "0x7FC74F0", VA = "0x187FC86F0")]
		public void GLCCNBMCNJK(HNMFKBFJGMN IAOFFAAOAHE, [Out] int HEDKJAMMPBF, [Out] int HMNHJJLMHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8980", Offset = "0x7FC7780", VA = "0x187FC8980")]
		public void LEDPNKNACHC(HNMFKBFJGMN IAOFFAAOAHE, BPEFGPHLBBF CILAJCPACLF, int MGAJKFOGGML = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8BE0", Offset = "0x7FC79E0", VA = "0x187FC8BE0")]
		public void OGMAIGEMBML(Mesh JLPONKINLEO, JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8B50", Offset = "0x7FC7950", VA = "0x187FC8B50")]
		public void LHBCKOCAKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC84F0", Offset = "0x7FC72F0", VA = "0x187FC84F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8C90", Offset = "0x7FC7A90", VA = "0x187FC8C90")]
		public HBLCPLFKAJG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds NHFILKMEGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public JDKBCJCKCFH.KMNDCOOFIPA ABLPKODBGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<HBLCPLFKAJG> INJKPNKKLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LNLPGEKBHEH FJBBNPGJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer PBHKHJPMFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int OIMENBJOBHO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh PKCFGBJDDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AMJNNANFGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AOOLDJGOLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1A00", Offset = "0x7FC0800", VA = "0x187FC1A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FC15E0", Offset = "0x7FC03E0", VA = "0x187FC15E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FC19D0", Offset = "0x7FC07D0", VA = "0x187FC19D0")]
	public int MIKHIAMEPMA(int NHFPKFHMOMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FC13F0", Offset = "0x7FC01F0", VA = "0x187FC13F0")]
	public void BKLMIKDDAFJ(EJNPIMJAHEH DKPOFKKMLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0BA0", Offset = "0x7FBF9A0", VA = "0x187FC0BA0")]
	public void BBOLFNGBMMB(Transform AMHCNBHLEFK, bool NMNPEHAGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FC09E0", Offset = "0x7FBF7E0", VA = "0x187FC09E0")]
	public bool ADHIJLDACFO(bool JNNPCIGJFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1A50", Offset = "0x7FC0850", VA = "0x187FC1A50")]
	public void PHONLDGCIPG(Transform EGPDFGOHLFM, bool NMNPEHAGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1760", Offset = "0x7FC0560", VA = "0x187FC1760")]
	public bool EBNLHEFHMEO(EDFFAFGGICA LPAADBJGJNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2080", Offset = "0x7FC0E80", VA = "0x187FC2080")]
	public CMENIEEAKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KCCAICICBHB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<CMENIEEAKIL.HBLCPLFKAJG> CMJADPKGLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ACEKKDEIGOK JOIHLOONFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<CMENIEEAKIL.HBLCPLFKAJG> ONDFAFHPIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int OFNBGOABAHG;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAAE0", Offset = "0x7FC98E0", VA = "0x187FCAAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB630", Offset = "0x7FCA430", VA = "0x187FCB630")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB6B0", Offset = "0x7FCA4B0", VA = "0x187FCB6B0")]
	public void OLHPIGGMIDE(CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB, Transform EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7FCABC0", Offset = "0x7FC99C0", VA = "0x187FCABC0")]
	public void EBNLHEFHMEO(CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB090", Offset = "0x7FC9E90", VA = "0x187FCB090")]
	private CMENIEEAKIL.HBLCPLFKAJG HLMFNEGHFDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB270", Offset = "0x7FCA070", VA = "0x187FCB270")]
	private bool LJLFCKENALO(CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB030", Offset = "0x7FC9E30", VA = "0x187FCB030")]
	private void FNECKIMBJLE(CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB1D0", Offset = "0x7FC9FD0", VA = "0x187FCB1D0")]
	public bool KIFJELBIAEI(CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7FCADA0", Offset = "0x7FC9BA0", VA = "0x187FCADA0")]
	public bool FLCGEBIGNJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB200", Offset = "0x7FCA000", VA = "0x187FCB200")]
	private CMENIEEAKIL.HBLCPLFKAJG KMPNENKFBPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB310", Offset = "0x7FCA110", VA = "0x187FCB310")]
	public long LMFDJHIMJOP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB770", Offset = "0x7FCA570", VA = "0x187FCB770")]
	public KCCAICICBHB()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OALKIMNAHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int MEPAHDGOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int OGAMHPHNBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float CICHEFJFCKB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<CMENIEEAKIL> GMOBCDMKNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD21A0", Offset = "0x7FD0FA0", VA = "0x187FD21A0")]
	public OALKIMNAHNI(int MEPAHDGOJMH, int OGAMHPHNBPK, float EEPHMGCLFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1FA0", Offset = "0x7FD0DA0", VA = "0x187FD1FA0")]
	public void AFKEILBEDAJ(MCKICOHMOGD LANLCFJOPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD20F0", Offset = "0x7FD0EF0", VA = "0x187FD20F0")]
	private int IFLNKJGBLEG(EJNPIMJAHEH FNINGPDJHMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1D30", Offset = "0x7FD0B30", VA = "0x187FD1D30")]
	private void AFKEILBEDAJ(EJNPIMJAHEH FNINGPDJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2050", Offset = "0x7FD0E50", VA = "0x187FD2050")]
	private void BFAGICNHHDK(EJNPIMJAHEH FNINGPDJHMC, CMENIEEAKIL LCBCMGNKJBK)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CEHHIBGBEIP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NJMNOHGAMBF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
			[DebuggerHidden]
			public NJMNOHGAMBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7FD15F0", Offset = "0x7FD03F0", VA = "0x187FD15F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7FD17B0", Offset = "0x7FD05B0", VA = "0x187FD17B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7FD1700", Offset = "0x7FD0500", VA = "0x187FD1700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7FD1700", Offset = "0x7FD0500", VA = "0x187FD1700", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AOOLDJGOLBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3D50", Offset = "0x7FC2B50", VA = "0x187FC3D50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<CDOEEOGNIKC> HNDALHHAOCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3D30", Offset = "0x7FC2B30", VA = "0x187FC3D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> INJKPNKKLLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CMENIEEAKIL PKCFGBJDDLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NFLFCFIKNGP HEDHBHCKLFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(NFLFCFIKNGP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA5A470", Offset = "0xA59270", VA = "0x180A5A470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PLLPKJFMOCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD6A6F0", Offset = "0xD694F0", VA = "0x180D6A6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2280", Offset = "0x7FC1080", VA = "0x187FC2280")]
		public static ClusterMeshRenderer Create(CMENIEEAKIL JLPONKINLEO, ClusterMeshRenderer KLDDAFNBKBA, MeshFilter OEEFABLKGBM, GKKGCGDMMHN EGPDFGOHLFM, NFLFCFIKNGP FEMFINBCNMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2500", Offset = "0x7FC1300", VA = "0x187FC2500", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3000", Offset = "0x7FC1E00", VA = "0x187FC3000", Slot = "9")]
		public bool TryRemoveClusterLODComponent(EDFFAFGGICA LPAADBJGJNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2DB0", Offset = "0x7FC1BB0", VA = "0x187FC2DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2A40", Offset = "0x7FC1840", VA = "0x187FC2A40")]
		public void Init(CMENIEEAKIL JLPONKINLEO, MeshFilter OEEFABLKGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2560", Offset = "0x7FC1360", VA = "0x187FC2560")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3130", Offset = "0x7FC1F30", VA = "0x187FC3130", Slot = "7")]
		public void UpdateClusterDistances(Vector3 MLCPBGGGOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FC33E0", Offset = "0x7FC21E0", VA = "0x187FC33E0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FC29C0", Offset = "0x7FC17C0", VA = "0x187FC29C0")]
		[IteratorStateMachine(typeof(NJMNOHGAMBF))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2E40", Offset = "0x7FC1C40", VA = "0x187FC2E40")]
		public void SetupTagAndLayer(string PEGIKAFHCAA, int FEMFINBCNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2E20", Offset = "0x7FC1C20", VA = "0x187FC2E20")]
		public bool Remove(EDFFAFGGICA LPAADBJGJNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PAHIDBPFIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int HEDGHHHBODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int HBNCFIPENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HMNHJJLMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int HEDKJAMMPBF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD21F0", Offset = "0x7FD0FF0", VA = "0x187FD21F0")]
	public PAHIDBPFIMH(int HBNCFIPENFO, int HMNHJJLMHFP, int HEDGHHHBODE, int HEDKJAMMPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LNLPGEKBHEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> MNCLBNBEOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> JEJOPFBOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> LMONDNDJEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<PAHIDBPFIMH> CNBKENONGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> GFMBLLMGNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> NMOFOFCELEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> LMOIACFINMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle BNNGADNDJHP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CCKFJFKMOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA88940", Offset = "0xA87740", VA = "0x180A88940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA87FA0", Offset = "0xA86DA0", VA = "0x180A87FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC850", Offset = "0x7FCB650", VA = "0x187FCC850")]
	public void ONJHMMKMDOB(JDKBCJCKCFH PPIKGIMFFEB, NativeList<PAHIDBPFIMH> CNBKENONGNG, float AMJKMJIBGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC590", Offset = "0x7FCB390", VA = "0x187FCC590")]
	public void GPHOPCBPBBN(Transform EGPDFGOHLFM, bool NMNPEHAGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC2E0", Offset = "0x7FCB0E0", VA = "0x187FCC2E0")]
	public void ADHIJLDACFO(CMENIEEAKIL PBHKHJPMFCF, bool JNNPCIGJFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC480", Offset = "0x7FCB280", VA = "0x187FCC480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC820", Offset = "0x7FCB620", VA = "0x187FCC820")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LNLPGEKBHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HAPOMDDCDHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> MNCLBNBEOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> JEJOPFBOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<PAHIDBPFIMH> PKMCMEEHLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> GFMBLLMGNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 KIJFFLMIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> NMOFOFCELEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> LMOIACFINMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool NMNPEHAGJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float HPNNPMCDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float FAONOPDAPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float PLJPAJDNGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> LMONDNDJEIO;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FC8420", Offset = "0x7FC7220", VA = "0x187FC8420")]
	public HAPOMDDCDHE(LNLPGEKBHEH PBLHBAOCCMH, Vector3 KIJFFLMIFKF, bool NMNPEHAGJBP, float HPNNPMCDDGE, float FAONOPDAPIJ, float PLJPAJDNGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7F20", Offset = "0x7FC6D20", VA = "0x187FC7F20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EDFFAFGGICA : FLGADMIBPOE
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds DFMGIKNBIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJNPIMJAHEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<EDFFAFGGICA> IDGINNJADGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public EJNPIMJAHEH CMDMCJGFCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public EJNPIMJAHEH AIIBHOHMMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public EJNPIMJAHEH EOALPPIOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int HEDKJAMMPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds NHFILKMEGHL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FC46B0", Offset = "0x7FC34B0", VA = "0x187FC46B0")]
	public EJNPIMJAHEH(List<EDFFAFGGICA> IDGINNJADGF, [Optional] EJNPIMJAHEH CMDMCJGFCDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MCKICOHMOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<EJNPIMJAHEH> DIFOOBOMPNO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EJNPIMJAHEH KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD870", Offset = "0x7FCC670", VA = "0x187FCD870")]
	public MCKICOHMOGD(EJNPIMJAHEH EGPDFGOHLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FHOICACLDLC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct NPGBEKDDFPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int GDDIBMPBOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int JOGLBJIOMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int FEMLNBAEBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int LMJEIBKPHGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct HKAFNHGPLAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int HMDFGLAHAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float KCAJANEEEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<EDFFAFGGICA> IDGINNJADGF;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9340", Offset = "0x7FC8140", VA = "0x187FC9340", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum AALAGFEEEEK
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
	private NPGBEKDDFPE OFGMEKAGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int JDMPMGBEEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int MEPAHDGOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int OGAMHPHNBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float EEPHMGCLFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float CKFJAJPCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<EJNPIMJAHEH> OJJDPBKMAIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MCKICOHMOGD MEILNMOAEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7EC0", Offset = "0x7FC6CC0", VA = "0x187FC7EC0")]
	public FHOICACLDLC(int MEPAHDGOJMH, int OGAMHPHNBPK, float EEPHMGCLFMM, int JDMPMGBEEOF, float CKFJAJPCPJO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FC68B0", Offset = "0x7FC56B0", VA = "0x187FC68B0")]
	public void HKCEONPKAEM(List<EDFFAFGGICA> IDGINNJADGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6840", Offset = "0x7FC5640", VA = "0x187FC6840")]
	public bool HFLAJPJHGBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5DF0", Offset = "0x7FC4BF0", VA = "0x187FC5DF0")]
	private float CBLPBLPLIIN(Vector3 IIEOAHPEFEA, Vector3 PFNOCLOHBOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5E40", Offset = "0x7FC4C40", VA = "0x187FC5E40")]
	private float CBLPBLPLIIN(Vector3 DFCCCGNJINK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5E60", Offset = "0x7FC4C60", VA = "0x187FC5E60")]
	private bool DIIJCGPBOGG(EJNPIMJAHEH LLNAKMAADPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6A80", Offset = "0x7FC5880", VA = "0x187FC6A80")]
	private HKAFNHGPLAH JFCDINIOJNO(List<EDFFAFGGICA> HMHMHEMHBMN, AALAGFEEEEK EBJCOEMONFF)
	{
		return default(HKAFNHGPLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7B00", Offset = "0x7FC6900", VA = "0x187FC7B00")]
	private void PAMMHHILMGD(List<EDFFAFGGICA> IDGINNJADGF, NativeArray<Vector3> ICJNJINBDDN, NativeArray<Vector3> AFHKKFJILFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class PNGDDNGICCN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2210", Offset = "0x7FD1010", VA = "0x187FD2210")]
	public static Bounds GCPCOGMHIDM(List<EDFFAFGGICA> IDGINNJADGF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD23E0", Offset = "0x7FD11E0", VA = "0x187FD23E0")]
	public static int PAFCGKIFPFB(List<EDFFAFGGICA> IDGINNJADGF, HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class CEJKEFLAJPI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool DBKBJDLNCCA(float4* BDLHCPMEIFH, int IDFEOHMGIAF);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class NLEJCGBABIF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr DEKJCIHBLKN;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr NCKJPIGNJIF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD19F0", Offset = "0x7FD07F0", VA = "0x187FD19F0")]
		[BurstDiscard]
		private static void KNOJPCMNAPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1BD0", Offset = "0x7FD09D0", VA = "0x187FD1BD0")]
		private static IntPtr NHALIAMEHAB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1B20", Offset = "0x7FD0920", VA = "0x187FD1B20")]
		public static void LODCLJFHCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public static void DGPDNICIDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1800", Offset = "0x7FD0600", VA = "0x187FD1800")]
		public unsafe static bool BOBFGEKALDJ(float4* BDLHCPMEIFH, int IDFEOHMGIAF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FC07C0", Offset = "0x7FBF5C0", VA = "0x187FC07C0")]
	[BurstCompile]
	public unsafe static bool NJGHHMBGBBE(float4* BDLHCPMEIFH, int IDFEOHMGIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC3A0", Offset = "0x7FBB1A0", VA = "0x187FBC3A0")]
	[BurstCompile]
	public unsafe static bool OBNODHLMAJK(float4* BDLHCPMEIFH, int IDFEOHMGIAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct INCMMGELJIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> GMADDJJIBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> FBPCDPHDPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> JGEIJCGEMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> JPHJAFPMELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> MPMINEDGDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> HCNCDBOMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> GLEEDMLDJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> KOALCKLLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<JDKBCJCKCFH.GOCLBMHCDLI> IKMGICLLIBI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9930", Offset = "0x7FC8730", VA = "0x187FC9930")]
	public INCMMGELJIN(JDKBCJCKCFH NLEJBCDBLCH, NativeArray<bool> GLEEDMLDJNO, NativeList<ushort> KOALCKLLFDJ, NativeList<JDKBCJCKCFH.GOCLBMHCDLI> IKMGICLLIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9680", Offset = "0x7FC8480", VA = "0x187FC9680", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct HDMADDHOIJP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> GMADDJJIBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> FBPCDPHDPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> JGEIJCGEMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> JPHJAFPMELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> MPMINEDGDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> HCNCDBOMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> BNPOIHBOBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> CEPBEMGBONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> CKIOKBAANIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> MDEKHMGBCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> GLOBINHHPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> AENLFPBFLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> GLEEDMLDJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> KOALCKLLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<JDKBCJCKCFH.GOCLBMHCDLI> IKMGICLLIBI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9280", Offset = "0x7FC8080", VA = "0x187FC9280")]
	public HDMADDHOIJP(JDKBCJCKCFH NLEJBCDBLCH, JDKBCJCKCFH HOAOGPACOKA, NativeArray<bool> GLEEDMLDJNO, NativeList<ushort> KOALCKLLFDJ, NativeList<JDKBCJCKCFH.GOCLBMHCDLI> IKMGICLLIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FC8DB0", Offset = "0x7FC7BB0", VA = "0x187FC8DB0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ACEKKDEIGOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JDKBCJCKCFH BHIKOEPBLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private JDKBCJCKCFH NLEJBCDBLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> INKHFFJHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> KOALCKLLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<JDKBCJCKCFH.GOCLBMHCDLI> IKMGICLLIBI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static JDKBCJCKCFH IAAOGINIIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private LKKJKJNCDDE GFPDHNILPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private BPEFGPHLBBF CILAJCPACLF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BNNGADNDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDE0", Offset = "0xE4ABE0", VA = "0x180E4BDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CMENIEEAKIL.HBLCPLFKAJG LLNAKMAADPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KFMOJDABFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x262CF00", Offset = "0x262BD00", VA = "0x18262CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCF40", Offset = "0x7FBBD40", VA = "0x187FBCF40")]
	[KHKJFPPHBKK(IGGCGDAJNBL.EnteredEditMode, 0)]
	private static void MFLCGIGAIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD000", Offset = "0x7FBBE00", VA = "0x187FBD000")]
	public void ONJHMMKMDOB(CMENIEEAKIL.HBLCPLFKAJG PKMCMEEHLBN, Transform DFFDBOCBFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC660", Offset = "0x7FBB460", VA = "0x187FBC660")]
	public void JNJCJGMFOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC590", Offset = "0x7FBB390", VA = "0x187FBC590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCFC0", Offset = "0x7FBBDC0", VA = "0x187FBCFC0")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7FBDB40", Offset = "0x7FBC940", VA = "0x187FBDB40")]
	public ACEKKDEIGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FOAEJOBGBPF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 JHGLOFPBOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JLPGMKOMIHA
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(EHDFINDMEJI<string>.NGEIFBMECIG BMCEBFCKDFE, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JJMODHFNJLA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJMODHFNJLA IEJOGGLLKCD(Action LJIGAFKJJAI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJMODHFNJLA AIKEOAKBJEE(Action LJIGAFKJJAI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BLKFGLLGONE : JJMODHFNJLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class LPGLAOLLNMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public BLKFGLLGONE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				public LPGLAOLLNMA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7FCD780", Offset = "0x7FCC580", VA = "0x187FCD780")]
				internal void BAAFBPDGDAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7FCD820", Offset = "0x7FCC620", VA = "0x187FCD820")]
				internal void LHIMEDJNOAC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7FCD7D0", Offset = "0x7FCC5D0", VA = "0x187FCD7D0")]
				internal void DLEPLAICDBA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> ENCAFPNPBEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action KJHBIJOHGKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action KBFBHNFEIBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private BFBMFIDCDEF FAMCMOFLCLA;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action OJEOCFGNEDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action GLPKDEOJIJF
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2955E70", Offset = "0x2954C70", VA = "0x182955E70", Slot = "4")]
			public JJMODHFNJLA IEJOGGLLKCD(Action LJIGAFKJJAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x79379C0", Offset = "0x79367C0", VA = "0x1879379C0", Slot = "5")]
			public JJMODHFNJLA AIKEOAKBJEE(Action LJIGAFKJJAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
			public BLKFGLLGONE(Func<JobHandle> ICIFNHNCBJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF630", Offset = "0x7FBE430", VA = "0x187FBF630")]
			public void DIEFFEOBOIO(Action CLJIPKEJNCC, Action OKBHBFFNOPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF8F0", Offset = "0x7FBE6F0", VA = "0x187FBF8F0")]
			public void EBNLHEFHMEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class EFJFGCDOEMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public JJMODHFNJLA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public EFJFGCDOEMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7FC46A0", Offset = "0x7FC34A0", VA = "0x187FC46A0")]
			internal bool JJIDLFCKGDN(BLKFGLLGONE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class KNCNPALOMBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public BLKFGLLGONE newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public KNCNPALOMBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7FCBAC0", Offset = "0x7FCA8C0", VA = "0x187FCBAC0")]
			internal void BMBPEFBCDHL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<BLKFGLLGONE> AFFPGOIIAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<BLKFGLLGONE> HODIBNHAKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IHBKINGAIAD JONGHIPEDHM;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public PCEKLNPMKHD DLDPKPCGMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7FC99A0", Offset = "0x7FC87A0", VA = "0x187FC99A0")]
		public JJMODHFNJLA Add(Func<JobHandle> ICIFNHNCBJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9CD0", Offset = "0x7FC8AD0", VA = "0x187FC9CD0")]
		public void Remove(JJMODHFNJLA BNNGADNDJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9B00", Offset = "0x7FC8900", VA = "0x187FC9B00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9EB0", Offset = "0x7FC8CB0", VA = "0x187FC9EB0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA110", Offset = "0x7FC8F10", VA = "0x187FCA110")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9AF0", Offset = "0x7FC88F0", VA = "0x187FC9AF0")]
		[CompilerGenerated]
		private void CEGNDEOFJMO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BFBMFIDCDEF
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFBMFIDCDEF IEJOGGLLKCD(Action LJIGAFKJJAI);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFBMFIDCDEF BNHOFPDBJCH(Action LJIGAFKJJAI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFBMFIDCDEF AIKEOAKBJEE(Action LJIGAFKJJAI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, OAGHPAJECPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class BIADPHLNOFI : BFBMFIDCDEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle BJKGCGDJLEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action KJHBIJOHGKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action ENGONDNAIJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action GLPKDEOJIJF;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool ABLLAPEADEI
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7FBDD50", Offset = "0x7FBCB50", VA = "0x187FBDD50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x770BF30", Offset = "0x770AD30", VA = "0x18770BF30", Slot = "4")]
			public BFBMFIDCDEF IEJOGGLLKCD(Action LJIGAFKJJAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x770C0B0", Offset = "0x770AEB0", VA = "0x18770C0B0", Slot = "5")]
			public BFBMFIDCDEF BNHOFPDBJCH(Action LJIGAFKJJAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x79379C0", Offset = "0x79367C0", VA = "0x1879379C0", Slot = "6")]
			public BFBMFIDCDEF AIKEOAKBJEE(Action LJIGAFKJJAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1088200", Offset = "0x1087000", VA = "0x181088200")]
			public BIADPHLNOFI(JobHandle OBCAJMIGILL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDCB0", Offset = "0x7FBCAB0", VA = "0x187FBDCB0")]
			public void AOLFNABIKLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDD00", Offset = "0x7FBCB00", VA = "0x187FBDD00")]
			public void EBNLHEFHMEO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<BIADPHLNOFI> EBKKGGBEGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> MFOAAPLEAHI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MFHPJONMPOL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA6F0", Offset = "0x7FC94F0", VA = "0x187FCA6F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x160BB30", Offset = "0x160A930", VA = "0x18160BB30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA1F0", Offset = "0x7FC8FF0", VA = "0x187FCA1F0")]
		public BFBMFIDCDEF Add(JobHandle OBCAJMIGILL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA900", Offset = "0x7FC9700", VA = "0x187FCA900")]
		public void Remove(BFBMFIDCDEF BNNGADNDJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA510", Offset = "0x7FC9310", VA = "0x187FCA510")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA360", Offset = "0x7FC9160", VA = "0x187FCA360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA290", Offset = "0x7FC9090", VA = "0x187FCA290")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAA00", Offset = "0x7FC9800", VA = "0x187FCAA00")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "6")]
		private bool JGCGIJJFOGK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD25B0", Offset = "0x7FD13B0", VA = "0x187FD25B0")]
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
