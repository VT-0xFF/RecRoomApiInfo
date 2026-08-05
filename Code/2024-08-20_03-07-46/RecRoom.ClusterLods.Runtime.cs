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
				[Cpp2IlInjected.Address(RVA = "0x68AACA0", Offset = "0x68A9CA0", VA = "0x1868AACA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x16F51E0", Offset = "0x16F41E0", VA = "0x1816F51E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x68AAC60", Offset = "0x68A9C60", VA = "0x1868AAC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A27C0", Offset = "0x68A17C0", VA = "0x1868A27C0")]
		public LODSettings OBONMNHPNJN(MOICOBIJLEG HCJLPFCODLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68A27A0", Offset = "0x68A17A0", VA = "0x1868A27A0")]
		public int FBNJAGPOCJN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68A2700", Offset = "0x68A1700", VA = "0x1868A2700")]
		public int CFCIONMGAIL(bool GOJCDLANAEL, Vector3 MOALNAMAFBH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68A27D0", Offset = "0x68A17D0", VA = "0x1868A27D0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NDFLDGLPDLP
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
public interface OFODBFLNINB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAEGOLIAKLD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DIABBEDKJFH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DPPOICNCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BPPOGFEKBAF> AADHKPDBLNM
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
	void UpdateClusterDistances(Vector3 NPKPBDEJFNH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(CEBCBAJEENF EMPBMFAFICE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BPPOGFEKBAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FDCFEKJLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int OAPPGDBFCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HGLAJECHONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ALOFDAHONLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte JDEMKNDMAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FLJKEDFFAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Control,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LowQualityShadow
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BBOBMHOAOGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CBFCEOIOACC
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
	private struct EOAHBLINFNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BBOBMHOAOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68A6500", Offset = "0x68A5500", VA = "0x1868A6500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68A6C90", Offset = "0x68A5C90", VA = "0x1868A6C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IKHPFGGPCPE : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BBOBMHOAOGD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public IKHPFGGPCPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68A8890", Offset = "0x68A7890", VA = "0x1868A8890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68A89A0", Offset = "0x68A79A0", VA = "0x1868A89A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MFJDGLDGOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BBOBMHOAOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KLCBNGOGDPF<string>.BPJNBAPCFPO worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private KLCBNGOGDPF<string>.BPJNBAPCFPO <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68AB490", Offset = "0x68AA490", VA = "0x1868AB490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACCD0", Offset = "0x68ABCD0", VA = "0x1868ACCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HBENCENHHDG : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private FAKEPIEMOLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BBOBMHOAOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public HBENCENHHDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68A75D0", Offset = "0x68A65D0", VA = "0x1868A75D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68A82B0", Offset = "0x68A72B0", VA = "0x1868A82B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const int MDFJBAFDCED = 3;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly TimeSpan JILMLKAIJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ClusterMeshRenderer MLMMCKNCNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MeshFilter NNAOICEHFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GameObject FJHJIFHOBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject BMNKPAMCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AHEJJKNGBFN ILDGNCPFBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<CEBCBAJEENF> AOOMPAGDCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<CEBCBAJEENF> GECIEIKDPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<CEBCBAJEENF> JHFMPDAAPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int NBIAIANKLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CBFCEOIOACC LPJCMNGOEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public List<DIABBEDKJFH>[] JKEAEPBPGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private List<BPPOGFEKBAF>[] GJLCGADJGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CancellationTokenSource CJIAJKOABNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool JAPEICGDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HDBNHMIPDLF EMIKDCKEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HDBNHMIPDLF PJANLDIGFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int NDAKCDPPFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static BBOBMHOAOGD NCOIAAJPKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KMPEKCIMDCE IOHMDIPLAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NBBPEMKGING HPKFKLGGJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MonoBehaviour HPIHCFHINEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Material OFLPBJOGNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Material OAFMCKJGCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material OLIPCHAFBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public FLJKEDFFAEL OCGLBDOJLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<OFODBFLNINB> PKDBOALMKPG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig GEBPIDKMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 JMAELKBBJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8637E0", Offset = "0x8627E0", VA = "0x1808637E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x863230", Offset = "0x862230", VA = "0x180863230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CBFCEOIOACC FIEEHEAODHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99B590", Offset = "0x99A590", VA = "0x18099B590")]
		get
		{
			return default(CBFCEOIOACC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x689F330", Offset = "0x689E330", VA = "0x18689F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BBOBMHOAOGD PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x689DE30", Offset = "0x689CE30", VA = "0x18689DE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool OPEFJKGKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68A0220", Offset = "0x689F220", VA = "0x1868A0220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MBGBNNEEKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x689E9C0", Offset = "0x689D9C0", VA = "0x18689E9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LEJAIIKIAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x689F270", Offset = "0x689E270", VA = "0x18689F270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x689E710", Offset = "0x689D710", VA = "0x18689E710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BPFBADIHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x689D4E0", Offset = "0x689C4E0", VA = "0x18689D4E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x689D590", Offset = "0x689C590", VA = "0x18689D590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68A0390", Offset = "0x689F390", VA = "0x1868A0390")]
	public BBOBMHOAOGD(KMPEKCIMDCE IOHMDIPLAMN, NBBPEMKGING HPKFKLGGJBA, ClusterLODConfig OIOABFIENOM, MonoBehaviour HPIHCFHINEF, Material OFLPBJOGNID, ClusterMeshRenderer MLMMCKNCNDB, MeshFilter NNAOICEHFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x689E160", Offset = "0x689D160", VA = "0x18689E160")]
	public void EHICCNPOKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x689DF00", Offset = "0x689CF00", VA = "0x18689DF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x689D640", Offset = "0x689C640", VA = "0x18689D640")]
	public static void BBMLGJLNLME(Vector3 OOOIIADAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x689EFE0", Offset = "0x689DFE0", VA = "0x18689EFE0")]
	private void MKCFMMGCNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x689E3B0", Offset = "0x689D3B0", VA = "0x18689E3B0")]
	private void FDPGEOAJMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x689E010", Offset = "0x689D010", VA = "0x18689E010")]
	private void EBMFAJKEEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x689FBC0", Offset = "0x689EBC0", VA = "0x18689FBC0")]
	public void PMPNPMJMGFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x689EB60", Offset = "0x689DB60", VA = "0x18689EB60")]
	[AsyncStateMachine(typeof(EOAHBLINFNM))]
	public Task INNINGPPHGF(KLCBNGOGDPF<string>.BPJNBAPCFPO FFKLKHEFHIG, CancellationToken CKFCHGJKDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x689E330", Offset = "0x689D330", VA = "0x18689E330")]
	[IteratorStateMachine(typeof(IKHPFGGPCPE))]
	private IEnumerator<FAKEPIEMOLB> FCCKKMFLOHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x689DD10", Offset = "0x689CD10", VA = "0x18689DD10")]
	[AsyncStateMachine(typeof(MFJDGLDGOMD))]
	private Task CLPJDEIKEGH(KLCBNGOGDPF<string>.BPJNBAPCFPO JOCDMCGIKHK, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x689F070", Offset = "0x689E070", VA = "0x18689F070")]
	public void NANGKGCMLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x689FB40", Offset = "0x689EB40", VA = "0x18689FB40")]
	public void PJGDCCINIMG(IEnumerable<DIABBEDKJFH> LMPFBFPPDDD, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x689D8A0", Offset = "0x689C8A0", VA = "0x18689D8A0")]
	public void BEIOCHJBPPA(IEnumerable<DIABBEDKJFH> LMPFBFPPDDD, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x689F460", Offset = "0x689E460", VA = "0x18689F460")]
	public List<ClusterMeshRenderer> PCPIKNIEJLK(List<CEBCBAJEENF> JGBLGHNJFIG, GBHEIPHNIPH JMCFDCHCIPI, NDFLDGLPDLP HGBAHFEDPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x689E480", Offset = "0x689D480", VA = "0x18689E480")]
	public void FEIJGLJEKIG(OFODBFLNINB GNLBOJFINGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x689EA80", Offset = "0x689DA80", VA = "0x18689EA80")]
	public bool HOIBCLDOHMD(OFODBFLNINB GNLBOJFINGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x689E920", Offset = "0x689D920", VA = "0x18689E920")]
	public void GNEEIKDLJBB(CEBCBAJEENF FJBFPJKMGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x689E690", Offset = "0x689D690", VA = "0x18689E690")]
	public void FINAACAPKBO(BPPOGFEKBAF CEIDENCIKBF, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x689DE80", Offset = "0x689CE80", VA = "0x18689DE80")]
	public void DONDDBNNCPA(BPPOGFEKBAF CEIDENCIKBF, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x689E7D0", Offset = "0x689D7D0", VA = "0x18689E7D0")]
	private void GKKGPBLMDBD(Vector3 NPKPBDEJFNH, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x689D740", Offset = "0x689C740", VA = "0x18689D740")]
	private void BDNAKMPNGOL(Vector3 NPKPBDEJFNH, NDFLDGLPDLP HGBAHFEDPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x689EAE0", Offset = "0x689DAE0", VA = "0x18689EAE0")]
	[IteratorStateMachine(typeof(HBENCENHHDG))]
	private IEnumerator<FAKEPIEMOLB> IBBPHJKDDHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x689DBA0", Offset = "0x689CBA0", VA = "0x18689DBA0")]
	private int CKKECEFBJCN(int HCALFJOJKJO, int MALACOIHPOP, List<BPPOGFEKBAF> ANFOJKHIECD, byte HCJLPFCODLH, int IFHHOPMABNH, float BBBCEBKOLBN = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x689E4E0", Offset = "0x689D4E0", VA = "0x18689E4E0")]
	public void FFDBNDOHLIO(CEBCBAJEENF EMPBMFAFICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x689E980", Offset = "0x689D980", VA = "0x18689E980")]
	public bool GNMOOKFCBOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x998240", Offset = "0x997240", VA = "0x180998240")]
	public Material EHKGICFHPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x98F4A0", Offset = "0x98E4A0", VA = "0x18098F4A0")]
	public Material AHEHNJGKCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85D2E0", Offset = "0x85C2E0", VA = "0x18085D2E0")]
	public Material EPAGGDIOOPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x689E2F0", Offset = "0x689D2F0", VA = "0x18689E2F0")]
	public int FBNJAGPOCJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x689EC80", Offset = "0x689DC80", VA = "0x18689EC80")]
	public long JDCBFHLMJJG()
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
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct MALCFBCCCEO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<float3> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float3> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeArray<float2> AMLJIHKJAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float4> CJFJMKOLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeList<int> FIEKLFJCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<float3> PLOLAMLDDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private float3 IEBHFAKGCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private float CIEGACAGNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeParallelMultiHashMap<int, int> BHCCAGMIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AFFKBDBOKBF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68AB3C0", Offset = "0x68AA3C0", VA = "0x1868AB3C0")]
	public MALCFBCCCEO(CMNEIJMNCCM EIOKGMMIDKC, NativeList<float3> PLOLAMLDDBD, NativeParallelMultiHashMap<int, int> BHCCAGMIDOP, NativeArray<int> AFFKBDBOKBF, Vector3 IEBHFAKGCGM, float CIEGACAGNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68AB360", Offset = "0x68AA360", VA = "0x1868AB360")]
	private int HMFLBFKCPBJ(float3 NPKPBDEJFNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68AACC0", Offset = "0x68A9CC0", VA = "0x1868AACC0")]
	private int CGCDECPHAEB(int GGJGGMKAJPM, int GMFCIHEFPPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68AAF30", Offset = "0x68A9F30", VA = "0x1868AAF30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FMDDHLMDMPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NativeParallelMultiHashMap<int, int> BHCCAGMIDOP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static NativeArray<int> AFFKBDBOKBF;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int OLGLGOMOALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> HBFHODKEDDH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68A72F0", Offset = "0x68A62F0", VA = "0x1868A72F0")]
	public void BDBFLFOLMOK(int DKOMKGMJOOP, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68A74F0", Offset = "0x68A64F0", VA = "0x1868A74F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FMDDHLMDMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HIDKGPFKPNP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeList<int> FLHNFMOECFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<int> FACGPEGJEHM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68A83B0", Offset = "0x68A73B0", VA = "0x1868A83B0")]
	public HIDKGPFKPNP(FMDDHLMDMPM AKOOGGNHEPM, CMNEIJMNCCM EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68A8300", Offset = "0x68A7300", VA = "0x1868A8300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct BHIMDDCPCBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeList<float3> AFGCMDDMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float3> FNHHJCBMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> ILBCHPCDBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeArray<float2> HNLIKHPCBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float4> AIDMFEAADPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<int> HBFHODKEDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> FLHNFMOECFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<float3> HINKJPFFKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float3> PICFFHIOCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float4> MBHCKLLGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeArray<float4> PPEAFFJINGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float2> CDJGCKIBMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<int> PCMOMKBMAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float IEMANHKOCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	public float KPBFHHPLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float3 KPANDCOEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float HOJHCJIOPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private float GDOBEDEAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	public float BIJEBEJFKBC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68A20F0", Offset = "0x68A10F0", VA = "0x1868A20F0")]
	public BHIMDDCPCBJ(FMDDHLMDMPM FKJNJNJPKKK, CMNEIJMNCCM EIOKGMMIDKC, CMNEIJMNCCM FFPGCFCLJNN, float GDOBEDEAJNI, float BIJEBEJFKBC, Vector3 KPANDCOEHHI, float HOJHCJIOPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68A0DC0", Offset = "0x689FDC0", VA = "0x1868A0DC0")]
	private float3 CNKNFEKNLJE(int GGJGGMKAJPM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68A1F10", Offset = "0x68A0F10", VA = "0x1868A1F10")]
	private void PHBHNEGOIJM(int GGJGGMKAJPM, [Out] float3 DGPOAMGNDBI, [Out] float3 ANAFDINJFFJ, [Out] float4 GOLNKGIKIEG, [Out] float4 BLBJBCHDEFI, [Out] float2 DHELFIDJHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68A1AD0", Offset = "0x68A0AD0", VA = "0x1868A1AD0")]
	private int MFMAGLMCHOL(int LANNOLHKKEG, int LAGPAIIEOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68A0E70", Offset = "0x689FE70", VA = "0x1868A0E70")]
	private void DKNFCIOJFCC(int LANNOLHKKEG, int LAGPAIIEOLB, int NHLNENAGILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68A1DC0", Offset = "0x68A0DC0", VA = "0x1868A1DC0")]
	private bool OFOMIDOCLDN(int LANNOLHKKEG, int LAGPAIIEOLB, float HIEFAFOEHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68A1070", Offset = "0x68A0070", VA = "0x1868A1070")]
	private bool EHLAPHKLNPB(int LANNOLHKKEG, int LAGPAIIEOLB, int NHLNENAGILI, float HIEFAFOEHJG, bool AALHIEIHJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68A0B60", Offset = "0x689FB60", VA = "0x1868A0B60")]
	private bool CELNGIJALKP(int LANNOLHKKEG, int LAGPAIIEOLB, int NHLNENAGILI, float HIEFAFOEHJG, bool AALHIEIHJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68A1130", Offset = "0x68A0130", VA = "0x1868A1130")]
	private void ELKNJFLPILA(int LANNOLHKKEG, int LAGPAIIEOLB, int NHLNENAGILI, [Out] int HIMMDDACKGB, [Out] int FOPDAIFILMC, [Out] int LKLKKCMEMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68A1150", Offset = "0x68A0150", VA = "0x1868A1150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DEHJNEBBEHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DAGEEPFGHCA : IDisposable, BPPOGFEKBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Bounds ODKJMCLECPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public List<CEBCBAJEENF> JGBLGHNJFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3 HFOBBBPNOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Vector3 DFIEIIFPBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int FPEIIMIDAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CMNEIJMNCCM NDGEAJNBIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long CACNKBJFIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FMDDHLMDMPM IOKALHKDNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Transform JMCFDCHCIPI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int BDGCGGNFMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x68A4750", Offset = "0x68A3750", VA = "0x1868A4750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh LDBGLPOMFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CKJKKGJPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850620", VA = "0x180851620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float HGLAJECHONK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x95D8B0", Offset = "0x95C8B0", VA = "0x18095D8B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5EF60B0", Offset = "0x5EF50B0", VA = "0x185EF60B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte JDEMKNDMAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F1E90", Offset = "0x9F0E90", VA = "0x1809F1E90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xADE5A0", Offset = "0xADD5A0", VA = "0x180ADE5A0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FDCFEKJLDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xBCF530", Offset = "0xBCE530", VA = "0x180BCF530", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBCD8C0", Offset = "0xBCC8C0", VA = "0x180BCD8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int OAPPGDBFCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xFA6830", Offset = "0xFA5830", VA = "0x180FA6830", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xFA5B20", Offset = "0xFA4B20", VA = "0x180FA5B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ALOFDAHONLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x68A4560", Offset = "0x68A3560", VA = "0x1868A4560", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68A4300", Offset = "0x68A3300", VA = "0x1868A4300")]
		public void IBMNCGJMBGC(MOICOBIJLEG HCJLPFCODLH, [Out] int LLEMLEJAAAD, [Out] int DKMKGMBDOFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68A4580", Offset = "0x68A3580", VA = "0x1868A4580")]
		public void LMCPCEBEJKN(MOICOBIJLEG HCJLPFCODLH, OKBKOLMLABP PPIFNKIDFOO, int DEEGLJPAHEF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68A4260", Offset = "0x68A3260", VA = "0x1868A4260")]
		public void GINHOBAAFJA(Mesh EIOKGMMIDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68A41D0", Offset = "0x68A31D0", VA = "0x1868A41D0")]
		public void FINAAKKDKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68A4010", Offset = "0x68A3010", VA = "0x1868A4010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x68A4790", Offset = "0x68A3790", VA = "0x1868A4790")]
		public DAGEEPFGHCA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Bounds ODKJMCLECPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<DAGEEPFGHCA> HAHLNOHJMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public PEIKPIHMPAG JHGMGIMBMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ClusterMeshRenderer HMLGIEBFMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int HEAKHPJAKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HKLIHKIIEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LJKBPAEJBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA68730", Offset = "0xA67730", VA = "0x180A68730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA68570", Offset = "0xA67570", VA = "0x180A68570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DPPOICNCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68A5E10", Offset = "0x68A4E10", VA = "0x1868A5E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68A50D0", Offset = "0x68A40D0", VA = "0x1868A50D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68A50A0", Offset = "0x68A40A0", VA = "0x1868A50A0")]
	public int DGCJMKBNFJK(int HCECGDLLDGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68A4EC0", Offset = "0x68A3EC0", VA = "0x1868A4EC0")]
	public void AMBGBIPJJIJ(COPPAOMFBKE JKKBKMPMEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68A54C0", Offset = "0x68A44C0", VA = "0x1868A54C0")]
	public void GMNGGEBNAHP(Transform JJHJHNBEMKM, bool IENJKGHNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68A5C50", Offset = "0x68A4C50", VA = "0x1868A5C50")]
	public bool MCEMDLBKNOI(bool DKOHGEJGFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68A4890", Offset = "0x68A3890", VA = "0x1868A4890")]
	public void ACOGBHFPPCM(Transform JMCFDCHCIPI, bool IENJKGHNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68A5250", Offset = "0x68A4250", VA = "0x1868A5250")]
	public bool FFDBNDOHLIO(CEBCBAJEENF EMPBMFAFICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68A5E60", Offset = "0x68A4E60", VA = "0x1868A5E60")]
	public DEHJNEBBEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AHEJJKNGBFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Queue<DEHJNEBBEHO.DAGEEPFGHCA> IMMHFAOIMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private KOJLJGHKPCI KOFNFJPMBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<DEHJNEBBEHO.DAGEEPFGHCA> IKKDJEONBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int CENBPMMOLKA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x689C910", Offset = "0x689B910", VA = "0x18689C910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x689D2B0", Offset = "0x689C2B0", VA = "0x18689D2B0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x689CE00", Offset = "0x689BE00", VA = "0x18689CE00")]
	public void GKAGDNHKNII(DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH, Transform JMCFDCHCIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x689C990", Offset = "0x689B990", VA = "0x18689C990")]
	public void FFDBNDOHLIO(DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x689C7A0", Offset = "0x689B7A0", VA = "0x18689C7A0")]
	private DEHJNEBBEHO.DAGEEPFGHCA DDDMLGBEENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x689C700", Offset = "0x689B700", VA = "0x18689C700")]
	private bool BJHJEEMPNLG(DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x689D250", Offset = "0x689C250", VA = "0x18689D250")]
	private void JFNEGPDGBAN(DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x689C8E0", Offset = "0x689B8E0", VA = "0x18689C8E0")]
	public bool DELHLLEHDBO(DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x689CB70", Offset = "0x689BB70", VA = "0x18689CB70")]
	public bool GACAEOGENLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x689CEC0", Offset = "0x689BEC0", VA = "0x18689CEC0")]
	private DEHJNEBBEHO.DAGEEPFGHCA HCHBBPMNJDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x689CF30", Offset = "0x689BF30", VA = "0x18689CF30")]
	public long JDCBFHLMJJG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x689D330", Offset = "0x689C330", VA = "0x18689D330")]
	public AHEJJKNGBFN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FHAKNEMOEDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int ONKPEDDPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int AOLMDCKDJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float MOANFIPOCKE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<DEHJNEBBEHO> GBFMDJJBFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x68A72A0", Offset = "0x68A62A0", VA = "0x1868A72A0")]
	public FHAKNEMOEDP(int ONKPEDDPANC, int AOLMDCKDJFF, float IGACCGOBFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x68A6FB0", Offset = "0x68A5FB0", VA = "0x1868A6FB0")]
	public void KBMBLKMMFEC(OJFILFCGGOA HDBIJCHIGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x68A6CF0", Offset = "0x68A5CF0", VA = "0x1868A6CF0")]
	private int HAHKCMKMDDE(COPPAOMFBKE OHDOOCGHDGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68A6DA0", Offset = "0x68A5DA0", VA = "0x1868A6DA0")]
	private void KBMBLKMMFEC(COPPAOMFBKE OHDOOCGHDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68A7060", Offset = "0x68A6060", VA = "0x1868A7060")]
	private void OEHCCNNBCAJ(COPPAOMFBKE OHDOOCGHDGN, DEHJNEBBEHO MPBLHJAHDEI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ClusterMeshRenderer : MonoBehaviour, DIABBEDKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KLPKKPHKBPK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
			[DebuggerHidden]
			public KLPKKPHKBPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68A9830", Offset = "0x68A8830", VA = "0x1868A9830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x68A99F0", Offset = "0x68A89F0", VA = "0x1868A99F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x68A9940", Offset = "0x68A8940", VA = "0x1868A9940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x68A9940", Offset = "0x68A8940", VA = "0x1868A9940", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int DPPOICNCDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x68A3FB0", Offset = "0x68A2FB0", VA = "0x1868A3FB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<BPPOGFEKBAF> AADHKPDBLNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x68A3F90", Offset = "0x68A2F90", VA = "0x1868A3F90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> HAHLNOHJMPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DEHJNEBBEHO HKLIHKIIEDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NDFLDGLPDLP GGDFOMEONLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(NDFLDGLPDLP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x854680", Offset = "0x853680", VA = "0x180854680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool KJMNBBPCIML
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1C1F0F0", Offset = "0x1C1E0F0", VA = "0x181C1F0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68A2830", Offset = "0x68A1830", VA = "0x1868A2830")]
		public static ClusterMeshRenderer Create(DEHJNEBBEHO EIOKGMMIDKC, ClusterMeshRenderer MLMMCKNCNDB, MeshFilter NNAOICEHFJI, GBHEIPHNIPH JMCFDCHCIPI, NDFLDGLPDLP HGBAHFEDPPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68A2BA0", Offset = "0x68A1BA0", VA = "0x1868A2BA0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x68A3490", Offset = "0x68A2490", VA = "0x1868A3490", Slot = "9")]
		public bool TryRemoveClusterLODComponent(CEBCBAJEENF EMPBMFAFICE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68A3240", Offset = "0x68A2240", VA = "0x1868A3240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68A2E10", Offset = "0x68A1E10", VA = "0x1868A2E10")]
		public void Init(DEHJNEBBEHO EIOKGMMIDKC, MeshFilter NNAOICEHFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68A2C00", Offset = "0x68A1C00", VA = "0x1868A2C00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68A35C0", Offset = "0x68A25C0", VA = "0x1868A35C0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 NPKPBDEJFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68A3870", Offset = "0x68A2870", VA = "0x1868A3870", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68A2D90", Offset = "0x68A1D90", VA = "0x1868A2D90")]
		[IteratorStateMachine(typeof(KLPKKPHKBPK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68A32D0", Offset = "0x68A22D0", VA = "0x1868A32D0")]
		public void SetupTagAndLayer(string EEMOJGOOGIP, int HGBAHFEDPPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68A32B0", Offset = "0x68A22B0", VA = "0x1868A32B0")]
		public bool Remove(CEBCBAJEENF EMPBMFAFICE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NPMAHOIGOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int JHNKCEHHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int EFHNBALPFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int DKMKGMBDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LLEMLEJAAAD;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD90", Offset = "0x68ABD90", VA = "0x1868ACD90")]
	public NPMAHOIGOBC(int EFHNBALPFBO, int DKMKGMBDOFG, int JHNKCEHHENO, int LLEMLEJAAAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PEIKPIHMPAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<float3> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<int> HBFHODKEDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<int> FIEKLFJCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<NPMAHOIGOBC> FOFOIBEMIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<int> EDPDMAACOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float3> HNDPEJOMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<float> JOLFKOAGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public JobHandle JKLBGOBBIDA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LEDIDDIHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1EC60", Offset = "0xA1DC60", VA = "0x180A1EC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA15710", Offset = "0xA14710", VA = "0x180A15710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x68ACE80", Offset = "0x68ABE80", VA = "0x1868ACE80")]
	public void BEDHOPCKIAC(CMNEIJMNCCM AMCHGCPCCKA, NativeList<NPMAHOIGOBC> FOFOIBEMIKC, float FHBDGLOPEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x68ADE20", Offset = "0x68ACE20", VA = "0x1868ADE20")]
	public void HOJGPADBGMA(Transform JMCFDCHCIPI, bool IENJKGHNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x68AE0B0", Offset = "0x68AD0B0", VA = "0x1868AE0B0")]
	public void MCEMDLBKNOI(DEHJNEBBEHO HMLGIEBFMDJ, bool DKOHGEJGFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x68ADD10", Offset = "0x68ACD10", VA = "0x1868ADD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68AE250", Offset = "0x68AD250", VA = "0x1868AE250")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public PEIKPIHMPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
public struct DMCCICACHKA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	public NativeList<int> HBFHODKEDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<NPMAHOIGOBC> AIOHJPCLEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeArray<int> EDPDMAACOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float3 KPANDCOEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<float3> HNDPEJOMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private NativeArray<float> JOLFKOAGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private bool IENJKGHNAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float NBKCMJCOIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float PNNAAJFABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float FKBGMNCNLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeList<int> FIEKLFJCNCA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x68A6430", Offset = "0x68A5430", VA = "0x1868A6430")]
	public DMCCICACHKA(PEIKPIHMPAG NLNDLAFJNGL, Vector3 KPANDCOEHHI, bool IENJKGHNAFL, float NBKCMJCOIEK, float PNNAAJFABFI, float FKBGMNCNLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68A5F20", Offset = "0x68A4F20", VA = "0x1868A5F20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CEBCBAJEENF : FOONFJIICKF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds PPCJNEGADBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class COPPAOMFBKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<CEBCBAJEENF> JGBLGHNJFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public COPPAOMFBKE EMOKCJBMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public COPPAOMFBKE NLPDKECJFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public COPPAOMFBKE GCHGFDKJOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public int LLEMLEJAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Bounds ODKJMCLECPD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68A2680", Offset = "0x68A1680", VA = "0x1868A2680")]
	public COPPAOMFBKE(List<CEBCBAJEENF> JGBLGHNJFIG, [Optional] COPPAOMFBKE EMOKCJBMKOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OJFILFCGGOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<COPPAOMFBKE> MMDKOJHJHGH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public COPPAOMFBKE KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68ACDB0", Offset = "0x68ABDB0", VA = "0x1868ACDB0")]
	public OJFILFCGGOA(COPPAOMFBKE JMCFDCHCIPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PLADEDBMDBB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KAHDDMOHMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int GPCEINFNKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int CNOPCPOBNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int AJGECHABALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int DBEJBOLKEKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct IJEFBIAJHPC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int AOIHEAOGOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float DLDHGMMHHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<CEBCBAJEENF> JGBLGHNJFIG;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68A8830", Offset = "0x68A7830", VA = "0x1868A8830", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum FMBOBFCGKBF
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
	private KAHDDMOHMIM PHAJKEECIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int EAPDLAHGGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int ONKPEDDPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int AOLMDCKDJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float IGACCGOBFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float MIGMHEIAMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Stack<COPPAOMFBKE> ECEGNAPJGEE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public OJFILFCGGOA HBPEKDCBMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68B04A0", Offset = "0x68AF4A0", VA = "0x1868B04A0")]
	public PLADEDBMDBB(int ONKPEDDPANC, int AOLMDCKDJFF, float IGACCGOBFMA, int EAPDLAHGGCJ, float MIGMHEIAMGB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68AE280", Offset = "0x68AD280", VA = "0x1868AE280")]
	public void BMHFGBLOOEK(List<CEBCBAJEENF> JGBLGHNJFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68AF210", Offset = "0x68AE210", VA = "0x1868AF210")]
	public bool GNKANBGBCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68B0450", Offset = "0x68AF450", VA = "0x1868B0450")]
	private float MIOANKKAKIF(Vector3 EGMGMOAFAED, Vector3 LJPDMCKLOMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68B0430", Offset = "0x68AF430", VA = "0x1868B0430")]
	private float MIOANKKAKIF(Vector3 GHACOABIHDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68AE450", Offset = "0x68AD450", VA = "0x1868AE450")]
	private bool DGFHFMJBKHI(COPPAOMFBKE HIOBFHENICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68AF280", Offset = "0x68AE280", VA = "0x1868AF280")]
	private IJEFBIAJHPC KGAKMBKFKGC(List<CEBCBAJEENF> NBMPLHJPNIM, FMBOBFCGKBF LGHBAPMPPGG)
	{
		return default(IJEFBIAJHPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68AEE30", Offset = "0x68ADE30", VA = "0x1868AEE30")]
	private void EJJMEHKJKMD(List<CEBCBAJEENF> JGBLGHNJFIG, Span<Vector3> DNNFODPPMFP, Span<Vector3> OCFCJIDDCNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class IEIPGMKKNMO
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68A8490", Offset = "0x68A7490", VA = "0x1868A8490")]
	public static Bounds AEACOHGOIFP(List<CEBCBAJEENF> JGBLGHNJFIG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68A8660", Offset = "0x68A7660", VA = "0x1868A8660")]
	public static int GNAEAJDILIG(List<CEBCBAJEENF> JGBLGHNJFIG, MOICOBIJLEG HCJLPFCODLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KOJLJGHKPCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CMNEIJMNCCM EFPPHKHFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private CMNEIJMNCCM DACIDGEJGEC;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static CMNEIJMNCCM MBHJABIHAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private JCGKLBNACIG AFGOGLLKHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private OKBKOLMLABP PPIFNKIDFOO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle JKLBGOBBIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA892A0", Offset = "0xA882A0", VA = "0x180A892A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DEHJNEBBEHO.DAGEEPFGHCA HIOBFHENICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OBPBBNAHOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x184E8B0", Offset = "0x184D8B0", VA = "0x18184E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68AA2F0", Offset = "0x68A92F0", VA = "0x1868AA2F0")]
	[HMFADHOHJJA(NHNHBJDDABK.ExitingPlayMode, 0)]
	private static void CHLPMLCEMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A40", Offset = "0x68A8A40", VA = "0x1868A9A40")]
	public void BEDHOPCKIAC(DEHJNEBBEHO.DAGEEPFGHCA AIOHJPCLEJK, Transform FANBCPCFFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68AA3E0", Offset = "0x68A93E0", VA = "0x1868AA3E0")]
	public void GLODAFHCDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68AA370", Offset = "0x68A9370", VA = "0x1868AA370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x68AAA80", Offset = "0x68A9A80", VA = "0x1868AAA80")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x68AAAC0", Offset = "0x68A9AC0", VA = "0x1868AAAC0")]
	public KOJLJGHKPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NBBPEMKGING
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 FJKBGPLNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KMPEKCIMDCE
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(KLCBNGOGDPF<string>.BPJNBAPCFPO JOCDMCGIKHK, CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface EKEOKMDEODL
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKEOKMDEODL DJMDAHDDOEA(Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EKEOKMDEODL JBABDNCODDB(Action JFOAFIPDIOA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class CFHNMKLEHKK : EKEOKMDEODL
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KPPIBPMIOMG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public CFHNMKLEHKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
				public KPPIBPMIOMG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x68AAB70", Offset = "0x68A9B70", VA = "0x1868AAB70")]
				internal void EKLLFNHIHHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x68AABC0", Offset = "0x68A9BC0", VA = "0x1868AABC0")]
				internal void HGANEPJBJBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x68AAC10", Offset = "0x68A9C10", VA = "0x1868AAC10")]
				internal void KEEHOLFNPHA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private Func<JobHandle> IIEGEFABILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private Action NLFJPJDGJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action COCBGJALNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private HOAJJJDECNE HOCLAGILLFD;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action LMIDBCMOMIB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action DEGHAFFLBMH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x46E8340", Offset = "0x46E7340", VA = "0x1846E8340", Slot = "4")]
			public EKEOKMDEODL DJMDAHDDOEA(Action JFOAFIPDIOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6364910", Offset = "0x6363910", VA = "0x186364910", Slot = "5")]
			public EKEOKMDEODL JBABDNCODDB(Action JFOAFIPDIOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
			public CFHNMKLEHKK(Func<JobHandle> LBBMKIGAHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x68A23C0", Offset = "0x68A13C0", VA = "0x1868A23C0")]
			public void PCBFBKDIPKL(Action GJFADFCMIEK, Action HCMJFPHFGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x68A2230", Offset = "0x68A1230", VA = "0x1868A2230")]
			public void FFDBNDOHLIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class MFIFNHLBHGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public EKEOKMDEODL jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public MFIFNHLBHGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x68AB480", Offset = "0x68AA480", VA = "0x1868AB480")]
			internal bool BCEGGKNLONM(CFHNMKLEHKK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class MIPCNEODFHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public CFHNMKLEHKK newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public MIPCNEODFHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD30", Offset = "0x68ABD30", VA = "0x1868ACD30")]
			internal void DGEPNFIHACD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Queue<CFHNMKLEHKK> FCNMCFEBJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<CFHNMKLEHKK> NGEJPINGKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HDBNHMIPDLF AGKALMBNHFG;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DDHIPEHKBEM JPEHFDEBMCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68A89F0", Offset = "0x68A79F0", VA = "0x1868A89F0")]
		public EKEOKMDEODL Add(Func<JobHandle> LBBMKIGAHBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x68A8D20", Offset = "0x68A7D20", VA = "0x1868A8D20")]
		public void Remove(EKEOKMDEODL JKLBGOBBIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68A8B50", Offset = "0x68A7B50", VA = "0x1868A8B50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x68A8EF0", Offset = "0x68A7EF0", VA = "0x1868A8EF0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x68A9150", Offset = "0x68A8150", VA = "0x1868A9150")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x68A8B40", Offset = "0x68A7B40", VA = "0x1868A8B40")]
		[CompilerGenerated]
		private void IHEMPOACLFO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HOAJJJDECNE
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOAJJJDECNE DJMDAHDDOEA(Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOAJJJDECNE FEPGMCOJCIG(Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOAJJJDECNE JBABDNCODDB(Action JFOAFIPDIOA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class IBGHFEAJCCD : HOAJJJDECNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private JobHandle KNNBHFIGBIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Action NLFJPJDGJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Action GIENKCLOHGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private Action DEGHAFFLBMH;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool DCLFDPKOLMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x68A8480", Offset = "0x68A7480", VA = "0x1868A8480")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6276F60", Offset = "0x6275F60", VA = "0x186276F60", Slot = "4")]
			public HOAJJJDECNE DJMDAHDDOEA(Action JFOAFIPDIOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6276F80", Offset = "0x6275F80", VA = "0x186276F80", Slot = "5")]
			public HOAJJJDECNE FEPGMCOJCIG(Action JFOAFIPDIOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6364910", Offset = "0x6363910", VA = "0x186364910", Slot = "6")]
			public HOAJJJDECNE JBABDNCODDB(Action JFOAFIPDIOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1EBA5F0", Offset = "0x1EB95F0", VA = "0x181EBA5F0")]
			public IBGHFEAJCCD(JobHandle ILCMKFDHAJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x68A83E0", Offset = "0x68A73E0", VA = "0x1868A83E0")]
			public void DLAELEJPAOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x68A8430", Offset = "0x68A7430", VA = "0x1868A8430")]
			public void FFDBNDOHLIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<IBGHFEAJCCD> AHDHHAOELBB;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68A9650", Offset = "0x68A8650", VA = "0x1868A9650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x68A9230", Offset = "0x68A8230", VA = "0x1868A9230")]
		public HOAJJJDECNE Add(JobHandle ILCMKFDHAJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68A9550", Offset = "0x68A8550", VA = "0x1868A9550")]
		public void Remove(HOAJJJDECNE JKLBGOBBIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68A93A0", Offset = "0x68A83A0", VA = "0x1868A93A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68A92D0", Offset = "0x68A82D0", VA = "0x1868A92D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68A9790", Offset = "0x68A8790", VA = "0x1868A9790")]
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
