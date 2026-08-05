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
				[Cpp2IlInjected.Address(RVA = "0x7CB1A50", Offset = "0x7CB0850", VA = "0x187CB1A50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xD9C140", Offset = "0xD9AF40", VA = "0x180D9C140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7CB1A10", Offset = "0x7CB0810", VA = "0x187CB1A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA4080", Offset = "0x7CA2E80", VA = "0x187CA4080")]
		public LODSettings CHLPPHCLCIA(PBEPDBDEIBA JGJKFDFMJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4130", Offset = "0x7CA2F30", VA = "0x187CA4130")]
		public int KHFALFKFMIB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4090", Offset = "0x7CA2E90", VA = "0x187CA4090")]
		public int JIJBMNCEANH(bool NHGJLDBEFNM, Vector3 MOBIHDFEDIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4150", Offset = "0x7CA2F50", VA = "0x187CA4150")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PFHJFINDEAE
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
public interface EIOFPFHCGMG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMPBGAACMOE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PMMIHMLMHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int AHGPHFNPLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<EKFOOOGMAAF> HPOMOHFKPDN
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
	void UpdateClusterDistances(Vector3 HAMOKFILEGG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(GCACBHBPDKI OFNOAHMACNB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKFOOOGMAAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EKEPKJACPME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int LMPLHJDEPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CBNPDCCJAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CEBIFFNCNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte BLEEACNOKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NOFJLINAOOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OPDIPMHDNOM
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
	private struct IAAHAEMKHGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NOFJLINAOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CAAD80", Offset = "0x7CA9B80", VA = "0x187CAAD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB510", Offset = "0x7CAA310", VA = "0x187CAB510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ELKEFFAOPBG : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NOFJLINAOOJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public ELKEFFAOPBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7CA7680", Offset = "0x7CA6480", VA = "0x187CA7680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA77B0", Offset = "0x7CA65B0", VA = "0x187CA77B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LLHHJKOOODH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NOFJLINAOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CAED10", Offset = "0x7CADB10", VA = "0x187CAED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0580", Offset = "0x7CAF380", VA = "0x187CB0580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CKDOIILCGAH : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NOFJLINAOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public CKDOIILCGAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2870", Offset = "0x7CA1670", VA = "0x187CA2870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3560", Offset = "0x7CA2360", VA = "0x187CA3560", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int LENPPLLGGHH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan IOPEHBLENOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer INKCIPJMDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter HFCFOPDENHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject BLKANENOPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CKKAFKHIDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FDKBPPJHHMD DEBEBKNBGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<GCACBHBPDKI> LKNMOLLLDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<GCACBHBPDKI> GOAJMOJFMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<GCACBHBPDKI> IPMCNHJEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KAHBGAMIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OPDIPMHDNOM DJMBHOAGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<PMMIHMLMHLN>[] OMCBHBPBLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<EKFOOOGMAAF>[] BBAMPJBDAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource IGFKIBKFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool DAJCDKEABLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private BGLABEGMMJM JLKBMFDNPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BGLABEGMMJM PAHGDJPBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int ACJGJMJPMKO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static NOFJLINAOOJ JKKCDKLCOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly APNCNBFAKAL GJGIBAFJCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LCGEMANJFNH HOHJHEBJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour MEFHNGPPFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material KNCGHKPDMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> ALCCFHAACLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material DGIACABKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> MAFGGNGDLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool DIAKFCLFHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<EIOFPFHCGMG> AHMMFODFJMG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig NLEDFONIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 PMBCGCGDIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E30110", Offset = "0x1E2EF10", VA = "0x181E30110")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E30040", Offset = "0x1E2EE40", VA = "0x181E30040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OPDIPMHDNOM KOOFKPHGDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF873E0", Offset = "0xF861E0", VA = "0x180F873E0")]
		get
		{
			return default(OPDIPMHDNOM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CB63D0", Offset = "0x7CB51D0", VA = "0x187CB63D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NOFJLINAOOJ ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB37F0", Offset = "0x7CB25F0", VA = "0x187CB37F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool JHPEOFCDCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5AC0", Offset = "0x7CB48C0", VA = "0x187CB5AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KECNHBLEIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5940", Offset = "0x7CB4740", VA = "0x187CB5940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> ENACBEOJIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5D10", Offset = "0x7CB4B10", VA = "0x187CB5D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4890", Offset = "0x7CB3690", VA = "0x187CB4890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KAMHGAPGBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3EC0", Offset = "0x7CB2CC0", VA = "0x187CB3EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6960", Offset = "0x7CB5760", VA = "0x187CB6960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6B90", Offset = "0x7CB5990", VA = "0x187CB6B90")]
	public NOFJLINAOOJ(APNCNBFAKAL GJGIBAFJCBP, LCGEMANJFNH HOHJHEBJDAN, ClusterLODConfig OLLMNLMJBOK, MonoBehaviour MEFHNGPPFDG, Material OBPCAECOOCO, ClusterMeshRenderer INKCIPJMDHB, MeshFilter HFCFOPDENHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6500", Offset = "0x7CB5300", VA = "0x187CB6500")]
	private void LHHDFLLEMFN(Material OBPCAECOOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5DD0", Offset = "0x7CB4BD0", VA = "0x187CB5DD0")]
	public void IDEBDMAIMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6670", Offset = "0x7CB5470", VA = "0x187CB6670")]
	public static NONOJJJJOHD.KCBJFHLHBFC LIEFOKOLDHL(NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE)
	{
		return default(NONOJJJJOHD.KCBJFHLHBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4340", Offset = "0x7CB3140", VA = "0x187CB4340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6690", Offset = "0x7CB5490", VA = "0x187CB6690")]
	public static void LJDBGGNALGL(Vector3 CDHJMKIKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3930", Offset = "0x7CB2730", VA = "0x187CB3930")]
	private void BLOJCBAJOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6300", Offset = "0x7CB5100", VA = "0x187CB6300")]
	private void KOOJEMDOMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5BC0", Offset = "0x7CB49C0", VA = "0x187CB5BC0")]
	private void HKDGAPINOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB50B0", Offset = "0x7CB3EB0", VA = "0x187CB50B0")]
	public void FJOFKEICJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4220", Offset = "0x7CB3020", VA = "0x187CB4220")]
	[AsyncStateMachine(typeof(IAAHAEMKHGF))]
	public Task DMFNBPBGJPA(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6AA0", Offset = "0x7CB58A0", VA = "0x187CB6AA0")]
	[IteratorStateMachine(typeof(ELKEFFAOPBG))]
	private IEnumerator<GCOFLMDGPIM> OMCDOECGCEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4710", Offset = "0x7CB3510", VA = "0x187CB4710")]
	[AsyncStateMachine(typeof(LLHHJKOOODH))]
	private Task EFBNFGKOIDC(HBCKFDINPOH<string>.DLKHFLDLCIN FGAPFDCPKFH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3CC0", Offset = "0x7CB2AC0", VA = "0x187CB3CC0")]
	public void CDBEOIONKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB58C0", Offset = "0x7CB46C0", VA = "0x187CB58C0")]
	public void FKFJMJLEFAH(IEnumerable<PMMIHMLMHLN> EIHONOHBMMH, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CB39C0", Offset = "0x7CB27C0", VA = "0x187CB39C0")]
	public void CAMEONEMHNA(IEnumerable<PMMIHMLMHLN> EIHONOHBMMH, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CB49D0", Offset = "0x7CB37D0", VA = "0x187CB49D0")]
	public List<ClusterMeshRenderer> FDPNBIBFENI(List<GCACBHBPDKI> LHDKCCFLGEF, GNLCMFNGHKL IPCOMOHMNHK, PFHJFINDEAE PBGGPJCBAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6900", Offset = "0x7CB5700", VA = "0x187CB6900")]
	public void NJCGBBIGNPK(EIOFPFHCGMG PENMIGAGHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3840", Offset = "0x7CB2640", VA = "0x187CB3840")]
	public bool ADJOMNGMGAK(EIOFPFHCGMG PENMIGAGHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4830", Offset = "0x7CB3630", VA = "0x187CB4830")]
	public void EGKNGFKCNMN(GCACBHBPDKI GBBHINFKCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5A40", Offset = "0x7CB4840", VA = "0x187CB5A40")]
	public void HACACPOPNAL(EKFOOOGMAAF DOKMLDLFBEF, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4950", Offset = "0x7CB3750", VA = "0x187CB4950")]
	public void FBKAMIOAEIM(EKFOOOGMAAF DOKMLDLFBEF, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CB40D0", Offset = "0x7CB2ED0", VA = "0x187CB40D0")]
	private void DHJNMODONNB(Vector3 HAMOKFILEGG, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3F70", Offset = "0x7CB2D70", VA = "0x187CB3F70")]
	private void COPINIEHHCM(Vector3 HAMOKFILEGG, PFHJFINDEAE PBGGPJCBAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6280", Offset = "0x7CB5080", VA = "0x187CB6280")]
	[IteratorStateMachine(typeof(CKDOIILCGAH))]
	private IEnumerator<GCOFLMDGPIM> KKINEMGBDFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6790", Offset = "0x7CB5590", VA = "0x187CB6790")]
	private int NCCENKEHBAA(int GLAOLHCPLLG, int HEJBHJHIKKH, List<EKFOOOGMAAF> NKLHPJKLBAK, byte JGJKFDFMJDO, int AMPCAIMMMFL, float GBADOILFCOA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5710", Offset = "0x7CB4510", VA = "0x187CB5710")]
	public void FKCGDELNEED(GCACBHBPDKI OFNOAHMACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5A00", Offset = "0x7CB4800", VA = "0x187CB5A00")]
	public bool GJDFDKMDKMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xCE6EA0", Offset = "0xCE5CA0", VA = "0x180CE6EA0")]
	public Material NPNGFGCKEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A10", Offset = "0x7CB5810", VA = "0x187CB6A10")]
	public Material NPNGFGCKEPH(NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xA0BBF0", Offset = "0xA0A9F0", VA = "0x180A0BBF0")]
	public Material BHLBDHEHDBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CB38A0", Offset = "0x7CB26A0", VA = "0x187CB38A0")]
	public Material BHLBDHEHDBF(NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6240", Offset = "0x7CB5040", VA = "0x187CB6240")]
	public int KHFALFKFMIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5E70", Offset = "0x7CB4C70", VA = "0x187CB5E70")]
	public (long, int) JLMMOMKCACI()
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
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct IFEELKIHAMH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> FKFBMOPPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> EKNIDIEOBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> PJNIHDBBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> FDALPPCBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> PECKHJOFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> BEIJEEMOHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 BBMDLNFDLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float EBAEABAGIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> NJDALMHGDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> IOAJPPDGAAG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CABC90", Offset = "0x7CAAA90", VA = "0x187CABC90")]
	public IFEELKIHAMH(NONOJJJJOHD JIEGCDEFFGO, NativeList<float3> BEIJEEMOHOK, NativeParallelMultiHashMap<int, int> NJDALMHGDJF, NativeArray<int> IOAJPPDGAAG, Vector3 BBMDLNFDLLE, float EBAEABAGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CABC30", Offset = "0x7CAAA30", VA = "0x187CABC30")]
	private int IKCPDFLCFPN(float3 HAMOKFILEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB590", Offset = "0x7CAA390", VA = "0x187CAB590")]
	private int BGBGDDHDKAP(int CPKBMDHHFLH, int MAKJJJECHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB800", Offset = "0x7CAA600", VA = "0x187CAB800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BNHNAAFEEKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> NJDALMHGDJF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> IOAJPPDGAAG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int OHHGBIJLNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> NLKOGNJNFJC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2000", Offset = "0x7CA0E00", VA = "0x187CA2000")]
	public void DFOACHHADOO(int JNCGHNJOHFD, Allocator LNMGNHHGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2200", Offset = "0x7CA1000", VA = "0x187CA2200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BNHNAAFEEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct LHFODLFINPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> OLFABNIEEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> EHMPJMLFEML;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE7B0", Offset = "0x7CAD5B0", VA = "0x187CAE7B0")]
	public LHFODLFINPI(BNHNAAFEEKG DKJMNMFMDCL, NONOJJJJOHD JIEGCDEFFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE700", Offset = "0x7CAD500", VA = "0x187CAE700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct MAFEINKPCCP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> ODOJKNKEJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> DIGBONDOCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> IEFOHCAIJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> KIPFFCALHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> EKAHOHMNGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> NLKOGNJNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> OLFABNIEEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> LJABNIGNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> FBONAJBPDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> EOBEOGBGILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> FCGOEKMFPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> MINEHENLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> EPFMBJPBCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float EDCHFFOEKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float DMPJPEHGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 PNAGGHNILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float LAJJKFNGLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float DANKJJJOFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float HBKDKLDLCIL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3390", Offset = "0x7CB2190", VA = "0x187CB3390")]
	public MAFEINKPCCP(BNHNAAFEEKG JOCOBADPJJK, NONOJJJJOHD JIEGCDEFFGO, NONOJJJJOHD LDGPAOJKGNK, float DANKJJJOFOM, float HBKDKLDLCIL, Vector3 PNAGGHNILKD, float LAJJKFNGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2070", Offset = "0x7CB0E70", VA = "0x187CB2070")]
	private float3 CNMDIDDPFEO(int CPKBMDHHFLH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CB31B0", Offset = "0x7CB1FB0", VA = "0x187CB31B0")]
	private void PBCBKFMPONL(int CPKBMDHHFLH, [Out] float3 GIHLPKONIIC, [Out] float3 HJEEHMNIIEF, [Out] float4 KDCDPEPDHHI, [Out] float4 IBIFFBKELFD, [Out] float2 NICMMJGAHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2CA0", Offset = "0x7CB1AA0", VA = "0x187CB2CA0")]
	private int HACAMHFMLHM(int OMELBEGKNDE, int KEDKEHHPCBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2120", Offset = "0x7CB0F20", VA = "0x187CB2120")]
	private void EHPFKDJMLND(int OMELBEGKNDE, int KEDKEHHPCBI, int BPCOLPHBDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2F80", Offset = "0x7CB1D80", VA = "0x187CB2F80")]
	private bool JCLIHENNJLN(int OMELBEGKNDE, int KEDKEHHPCBI, float MNEDHGBKMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CB30D0", Offset = "0x7CB1ED0", VA = "0x187CB30D0")]
	private bool LLMCDIFBLPE(int OMELBEGKNDE, int KEDKEHHPCBI, int BPCOLPHBDFK, float MNEDHGBKMIL, bool KAGEILGNLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1E10", Offset = "0x7CB0C10", VA = "0x187CB1E10")]
	private bool CKCMCBADEPM(int OMELBEGKNDE, int KEDKEHHPCBI, int BPCOLPHBDFK, float MNEDHGBKMIL, bool KAGEILGNLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3190", Offset = "0x7CB1F90", VA = "0x187CB3190")]
	private void NNLJGLMDCLK(int OMELBEGKNDE, int KEDKEHHPCBI, int BPCOLPHBDFK, [Out] int GLHMFECFKFG, [Out] int IHKAFNNJOJA, [Out] int DCLGNMBCOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2320", Offset = "0x7CB1120", VA = "0x187CB2320", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBHEHOMMGPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CPNJFOGKPOD : IDisposable, EKFOOOGMAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds ECBLDOPKHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<GCACBHBPDKI> LHDKCCFLGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 CCEOFNICPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 BEIOJGKCIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int HOGOGAEBOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NONOJJJJOHD FENHOBLEBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long KBJFLFMFDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BNHNAAFEEKG CALPKHCAIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform IPCOMOHMNHK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int OODBDLJBIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7CA3F00", Offset = "0x7CA2D00", VA = "0x187CA3F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh BPBPFHDBJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NONOJJJJOHD.KCBJFHLHBFC JBHJDOBEHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
			[CompilerGenerated]
			get
			{
				return default(NONOJJJJOHD.KCBJFHLHBFC);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD88FB0", Offset = "0xD87DB0", VA = "0x180D88FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh ENPFEBFPGFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NONOJJJJOHD.KCBJFHLHBFC NCDDOGCCAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE8BBB0", Offset = "0xE8A9B0", VA = "0x180E8BBB0")]
			[CompilerGenerated]
			get
			{
				return default(NONOJJJJOHD.KCBJFHLHBFC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE95C10", Offset = "0xE94A10", VA = "0x180E95C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float CBNPDCCJAJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1111400", Offset = "0x1110200", VA = "0x181111400", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x17AE490", Offset = "0x17AD290", VA = "0x1817AE490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte BLEEACNOKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x16FEA00", Offset = "0x16FD800", VA = "0x1816FEA00")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x16FD040", Offset = "0x16FBE40", VA = "0x1816FD040", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EKEPKJACPME
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA40980", Offset = "0xA3F780", VA = "0x180A40980", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1355A90", Offset = "0x1354890", VA = "0x181355A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LMPLHJDEPPF
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA30D50", Offset = "0xA2FB50", VA = "0x180A30D50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1355A80", Offset = "0x1354880", VA = "0x181355A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CEBIFFNCNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7CA3F40", Offset = "0x7CA2D40", VA = "0x187CA3F40", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7CA37C0", Offset = "0x7CA25C0", VA = "0x187CA37C0")]
		public void AKCBFEKKMGA(PBEPDBDEIBA JGJKFDFMJDO, [Out] int GFBHKKJANIO, [Out] int MCCEBKGMOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A30", Offset = "0x7CA2830", VA = "0x187CA3A30")]
		public void DIPBAGDCPJE(PBEPDBDEIBA JGJKFDFMJDO, AOEBHBIJBCB JFAEDAJNLMJ, int FMHBCCCILMO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3E50", Offset = "0x7CA2C50", VA = "0x187CA3E50")]
		public void JFIEGKIEKCB(Mesh JIEGCDEFFGO, NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3DC0", Offset = "0x7CA2BC0", VA = "0x187CA3DC0")]
		public void IICKEDGNPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3C00", Offset = "0x7CA2A00", VA = "0x187CA3C00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3F60", Offset = "0x7CA2D60", VA = "0x187CA3F60")]
		public CPNJFOGKPOD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds ECBLDOPKHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NONOJJJJOHD.KCBJFHLHBFC JAHPLPCMNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<CPNJFOGKPOD> OHFHJMEJNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LMCFJIHNEBL MNOCMIMFKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer EALBMDJEHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int HAMCMFJNIFD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NCJJOMJEBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GMHEABGOJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AHGPHFNPLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6D10", Offset = "0x7CA5B10", VA = "0x187CA6D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6760", Offset = "0x7CA5560", VA = "0x187CA6760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7580", Offset = "0x7CA6380", VA = "0x187CA7580")]
	public int NOPEKEHONJD(int KMJLBAHBAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7390", Offset = "0x7CA6190", VA = "0x187CA7390")]
	public void MBLNPCBDALH(DBIHMJGCHCL ACBECOPNCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5F10", Offset = "0x7CA4D10", VA = "0x187CA5F10")]
	public void DGFFLOBDABF(Transform MGHHALJBECP, bool MLDJEOADALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CA68E0", Offset = "0x7CA56E0", VA = "0x187CA68E0")]
	public bool EMKGNLPLLEI(bool NMHHCODEIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6D60", Offset = "0x7CA5B60", VA = "0x187CA6D60")]
	public void LEMJODKHCMB(Transform IPCOMOHMNHK, bool MLDJEOADALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6AA0", Offset = "0x7CA58A0", VA = "0x187CA6AA0")]
	public bool FKCGDELNEED(GCACBHBPDKI OFNOAHMACNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CA75B0", Offset = "0x7CA63B0", VA = "0x187CA75B0")]
	public EBHEHOMMGPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FDKBPPJHHMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<EBHEHOMMGPJ.CPNJFOGKPOD> KHKLNJODEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private IKFNKCNBIHN IDNCBDMIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<EBHEHOMMGPJ.CPNJFOGKPOD> DELAAFLNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int IBAAHJLHFGH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7940", Offset = "0x7CA6740", VA = "0x187CA7940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CA78C0", Offset = "0x7CA66C0", VA = "0x187CA78C0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7800", Offset = "0x7CA6600", VA = "0x187CA7800")]
	public void AIKICPLLADB(EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG, Transform IPCOMOHMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7C00", Offset = "0x7CA6A00", VA = "0x187CA7C00")]
	public void FKCGDELNEED(EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7A20", Offset = "0x7CA6820", VA = "0x187CA7A20")]
	private EBHEHOMMGPJ.CPNJFOGKPOD EFDLMKEKCGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7B60", Offset = "0x7CA6960", VA = "0x187CA7B60")]
	private bool EMFNJMMKHLC(EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8430", Offset = "0x7CA7230", VA = "0x187CA8430")]
	private void KHAAEKAIOGJ(EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7DE0", Offset = "0x7CA6BE0", VA = "0x187CA7DE0")]
	public bool GMHBCMLKHID(EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8130", Offset = "0x7CA6F30", VA = "0x187CA8130")]
	public bool JPEBABACHJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA83C0", Offset = "0x7CA71C0", VA = "0x187CA83C0")]
	private EBHEHOMMGPJ.CPNJFOGKPOD JPNNCFPPLAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7E10", Offset = "0x7CA6C10", VA = "0x187CA7E10")]
	public long IFANCOAKHEO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8490", Offset = "0x7CA7290", VA = "0x187CA8490")]
	public FDKBPPJHHMD()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GMPMNOJBMAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int JCNOFFPELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int NAGKHFNDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float AKAOHHLLIAF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<EBHEHOMMGPJ> FNDJPFOICHB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8C20", Offset = "0x7CA7A20", VA = "0x187CA8C20")]
	public GMPMNOJBMAN(int JCNOFFPELBO, int NAGKHFNDDIN, float ONCNACCDLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8900", Offset = "0x7CA7700", VA = "0x187CA8900")]
	public void MDECAMOOCMF(OJPNONOGDPI OLHOPCBPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8850", Offset = "0x7CA7650", VA = "0x187CA8850")]
	private int KODLFDJDJOJ(DBIHMJGCHCL BINEDJHADMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA89B0", Offset = "0x7CA77B0", VA = "0x187CA89B0")]
	private void MDECAMOOCMF(DBIHMJGCHCL BINEDJHADMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA87B0", Offset = "0x7CA75B0", VA = "0x187CA87B0")]
	private void GEGIPLFFIBH(DBIHMJGCHCL BINEDJHADMC, EBHEHOMMGPJ FHFACKFELJP)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PMMIHMLMHLN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CMDOBIBHKMP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
			[DebuggerHidden]
			public CMDOBIBHKMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7CA35B0", Offset = "0x7CA23B0", VA = "0x187CA35B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7CA3770", Offset = "0x7CA2570", VA = "0x187CA3770", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7CA36C0", Offset = "0x7CA24C0", VA = "0x187CA36C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7CA36C0", Offset = "0x7CA24C0", VA = "0x187CA36C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AHGPHFNPLGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7CA5C10", Offset = "0x7CA4A10", VA = "0x187CA5C10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<EKFOOOGMAAF> HPOMOHFKPDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7CA5BF0", Offset = "0x7CA49F0", VA = "0x187CA5BF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> OHFHJMEJNGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EBHEHOMMGPJ NCJJOMJEBPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PFHJFINDEAE HIFCHEKELPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PFHJFINDEAE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA11390", Offset = "0xA10190", VA = "0x180A11390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BFGFMLEPIPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC911E0", Offset = "0xC8FFE0", VA = "0x180C911E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CA41B0", Offset = "0x7CA2FB0", VA = "0x187CA41B0")]
		public static ClusterMeshRenderer Create(EBHEHOMMGPJ JIEGCDEFFGO, ClusterMeshRenderer INKCIPJMDHB, MeshFilter HFCFOPDENHC, GNLCMFNGHKL IPCOMOHMNHK, PFHJFINDEAE PBGGPJCBAMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4430", Offset = "0x7CA3230", VA = "0x187CA4430", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4F30", Offset = "0x7CA3D30", VA = "0x187CA4F30", Slot = "9")]
		public bool TryRemoveClusterLODComponent(GCACBHBPDKI OFNOAHMACNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4CE0", Offset = "0x7CA3AE0", VA = "0x187CA4CE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4970", Offset = "0x7CA3770", VA = "0x187CA4970")]
		public void Init(EBHEHOMMGPJ JIEGCDEFFGO, MeshFilter HFCFOPDENHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4490", Offset = "0x7CA3290", VA = "0x187CA4490")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4FF0", Offset = "0x7CA3DF0", VA = "0x187CA4FF0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 HAMOKFILEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CA52A0", Offset = "0x7CA40A0", VA = "0x187CA52A0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA48F0", Offset = "0x7CA36F0", VA = "0x187CA48F0")]
		[IteratorStateMachine(typeof(CMDOBIBHKMP))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4D70", Offset = "0x7CA3B70", VA = "0x187CA4D70")]
		public void SetupTagAndLayer(string EHKJLJIDDFP, int PBGGPJCBAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4D50", Offset = "0x7CA3B50", VA = "0x187CA4D50")]
		public bool Remove(GCACBHBPDKI OFNOAHMACNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IBOACBDFDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int DPOHMFFEBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int AJOJFAFFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int MCCEBKGMOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int GFBHKKJANIO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB570", Offset = "0x7CAA370", VA = "0x187CAB570")]
	public IBOACBDFDGH(int AJOJFAFFHHF, int MCCEBKGMOBA, int DPOHMFFEBBI, int GFBHKKJANIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LMCFJIHNEBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> NLKOGNJNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> PECKHJOFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<IBOACBDFDGH> GJGHHGIMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> PHLKCCBJHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> GKNIHCEOGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> FJLFAPHAMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle JAAMMEMKHCH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JOMBMMHEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA397E0", Offset = "0xA385E0", VA = "0x180A397E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA392E0", Offset = "0xA380E0", VA = "0x180A392E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB08D0", Offset = "0x7CAF6D0", VA = "0x187CB08D0")]
	public void HLJFBNEKAGO(NONOJJJJOHD DHCNCDEFBIL, NativeList<IBOACBDFDGH> GJGHHGIMOAO, float JCGDFDLNFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1780", Offset = "0x7CB0580", VA = "0x187CB1780")]
	public void POCFNCPAKBM(Transform IPCOMOHMNHK, bool MLDJEOADALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0730", Offset = "0x7CAF530", VA = "0x187CB0730")]
	public void EMKGNLPLLEI(EBHEHOMMGPJ EALBMDJEHIA, bool NMHHCODEIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0620", Offset = "0x7CAF420", VA = "0x187CB0620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CB05F0", Offset = "0x7CAF3F0", VA = "0x187CB05F0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LMCFJIHNEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct PNEJJLPGKIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> PBHBGPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> NLKOGNJNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<IBOACBDFDGH> PNJEHHPFEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> PHLKCCBJHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 PNAGGHNILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> GKNIHCEOGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> FJLFAPHAMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool MLDJEOADALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float IOPGJJCCPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float GNHOPOPPJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float PNKOGMABBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> PECKHJOFPCH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7E30", Offset = "0x7CB6C30", VA = "0x187CB7E30")]
	public PNEJJLPGKIC(LMCFJIHNEBL AAOGOGNMIPH, Vector3 PNAGGHNILKD, bool MLDJEOADALO, float IOPGJJCCPPB, float GNHOPOPPJFF, float PNKOGMABBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7930", Offset = "0x7CB6730", VA = "0x187CB7930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GCACBHBPDKI : GAHBFAGALGI
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds GOGCLEPDBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DBIHMJGCHCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<GCACBHBPDKI> LHDKCCFLGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public DBIHMJGCHCL BOGJJGPKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public DBIHMJGCHCL LLAMAIFBDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public DBIHMJGCHCL AFAMBLGNOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int GFBHKKJANIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds ECBLDOPKHPL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5E90", Offset = "0x7CA4C90", VA = "0x187CA5E90")]
	public DBIHMJGCHCL(List<GCACBHBPDKI> LHDKCCFLGEF, [Optional] DBIHMJGCHCL BOGJJGPKPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OJPNONOGDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<DBIHMJGCHCL> MDKDGJBDAID;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public DBIHMJGCHCL NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7860", Offset = "0x7CB6660", VA = "0x187CB7860")]
	public OJPNONOGDPI(DBIHMJGCHCL IPCOMOHMNHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HOGLFIANMAI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GJGIGEAMKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int GGMEEGFJBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int BGGABNEDKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int BALGLDEFDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int NMDDHMFMNII;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct HGGPAABDFLH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int DPILIMADOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float FIABOGKEGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<GCACBHBPDKI> LHDKCCFLGEF;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8C70", Offset = "0x7CA7A70", VA = "0x187CA8C70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum LJMDAOLKHFH
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
	private GJGIGEAMKGC BKIFMDJFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int FBNGIADDHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int JCNOFFPELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int NAGKHFNDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float ONCNACCDLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float OGIBEFCMMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<DBIHMJGCHCL> JJKNPJAFEAE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OJPNONOGDPI KOMJLILGLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAD20", Offset = "0x7CA9B20", VA = "0x187CAAD20")]
	public HOGLFIANMAI(int JCNOFFPELBO, int NAGKHFNDDIN, float ONCNACCDLLL, int FBNGIADDHBB, float OGIBEFCMMHF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAB50", Offset = "0x7CA9950", VA = "0x187CAAB50")]
	public void NGAMNBOIGPD(List<GCACBHBPDKI> LHDKCCFLGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAAE0", Offset = "0x7CA98E0", VA = "0x187CAAAE0")]
	public bool MOPCNOMLJNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA70", Offset = "0x7CA9870", VA = "0x187CAAA70")]
	private float JNLNEHMANHC(Vector3 JJLOIPCKCEC, Vector3 CEDDBAAAIGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAAC0", Offset = "0x7CA98C0", VA = "0x187CAAAC0")]
	private float JNLNEHMANHC(Vector3 ACINDEOBNPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA110", Offset = "0x7CA8F10", VA = "0x187CAA110")]
	private bool FEONOIKMBPA(DBIHMJGCHCL BBBOFBKCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9090", Offset = "0x7CA7E90", VA = "0x187CA9090")]
	private HGGPAABDFLH BHCOFOCMMNE(List<GCACBHBPDKI> BFPHCDLDEPH, LJMDAOLKHFH AFBNIALGAIO)
	{
		return default(HGGPAABDFLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8CD0", Offset = "0x7CA7AD0", VA = "0x187CA8CD0")]
	private void AMMOGEDEFOL(List<GCACBHBPDKI> LHDKCCFLGEF, NativeArray<Vector3> BFDEOIECIFE, NativeArray<Vector3> KBBMJCNCNGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class MABAINHFLJM
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1A70", Offset = "0x7CB0870", VA = "0x187CB1A70")]
	public static Bounds ABACLDKLDBM(List<GCACBHBPDKI> LHDKCCFLGEF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1C40", Offset = "0x7CB0A40", VA = "0x187CB1C40")]
	public static int MDLEDDPPGDF(List<GCACBHBPDKI> LHDKCCFLGEF, PBEPDBDEIBA JGJKFDFMJDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class DBFHHKHEMND
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool LHFJEDDBLLM(float4* FDALPPCBFML, int NPCJGIOCILE);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class LHIHEHEIAML
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr OHPFHGJAFMM;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr NJGNKOODJED;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE940", Offset = "0x7CAD740", VA = "0x187CAE940")]
		[BurstDiscard]
		private static void AGEPNJKBDJM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE7E0", Offset = "0x7CAD5E0", VA = "0x187CAE7E0")]
		private static IntPtr ABOEOOEIMPP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEC60", Offset = "0x7CADA60", VA = "0x187CAEC60")]
		public static void KONJBFOGBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		public static void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEA70", Offset = "0x7CAD870", VA = "0x187CAEA70")]
		public unsafe static bool HDKOJPGLKCE(float4* FDALPPCBFML, int NPCJGIOCILE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5C70", Offset = "0x7CA4A70", VA = "0x187CA5C70")]
	[BurstCompile]
	public unsafe static bool HICCEHJHBPM(float4* FDALPPCBFML, int NPCJGIOCILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1E10", Offset = "0x7CA0C10", VA = "0x187CA1E10")]
	[BurstCompile]
	public unsafe static bool IEGMBAMDMMJ(float4* FDALPPCBFML, int NPCJGIOCILE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct NJLBNPHKDJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> EOGOOIEPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> GFKNFMMCGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> PJBBHJCMOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> BEIEKBIGJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> KMGGHGJHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> PJNIHDBBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> PFFPJHHIGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> ICJPNCDIBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<NONOJJJJOHD.JDPBBHAIPDI> CKCOPBEKLGA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3780", Offset = "0x7CB2580", VA = "0x187CB3780")]
	public NJLBNPHKDJE(NONOJJJJOHD JLNHEJOJDCD, NativeArray<bool> PFFPJHHIGFN, NativeList<ushort> ICJPNCDIBBL, NativeList<NONOJJJJOHD.JDPBBHAIPDI> CKCOPBEKLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CB34D0", Offset = "0x7CB22D0", VA = "0x187CB34D0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct BNJNFGAIDDA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> EOGOOIEPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> GFKNFMMCGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> PJBBHJCMOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> BEIEKBIGJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> KMGGHGJHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> PJNIHDBBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> KJEACKIIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> POOMCHLLJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> EGPLFEPIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> OPJNCFKOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> NAIIDLHLAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> IDBCBMCCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> PFFPJHHIGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> ICJPNCDIBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<NONOJJJJOHD.JDPBBHAIPDI> CKCOPBEKLGA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA27B0", Offset = "0x7CA15B0", VA = "0x187CA27B0")]
	public BNJNFGAIDDA(NONOJJJJOHD JLNHEJOJDCD, NONOJJJJOHD EDILAIOBHPG, NativeArray<bool> PFFPJHHIGFN, NativeList<ushort> ICJPNCDIBBL, NativeList<NONOJJJJOHD.JDPBBHAIPDI> CKCOPBEKLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA22E0", Offset = "0x7CA10E0", VA = "0x187CA22E0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class IKFNKCNBIHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NONOJJJJOHD KPPJBOIEEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private NONOJJJJOHD JLNHEJOJDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> EPAKEJGLNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> ICJPNCDIBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<NONOJJJJOHD.JDPBBHAIPDI> CKCOPBEKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static NONOJJJJOHD FPLAHDEFCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private HNPDPDLCLDJ HGPPEIKEKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private AOEBHBIJBCB JFAEDAJNLMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle JAAMMEMKHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EBHEHOMMGPJ.CPNJFOGKPOD BBBOFBKCAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CKEONEGIDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x23DEAB0", Offset = "0x23DD8B0", VA = "0x1823DEAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7CABD50", Offset = "0x7CAAB50", VA = "0x187CABD50")]
	[OHEKCAPHOOO(LHBMPOBGEAI.EnteredEditMode, 0)]
	private static void ANANODBJPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CABEE0", Offset = "0x7CAACE0", VA = "0x187CABEE0")]
	public void HLJFBNEKAGO(EBHEHOMMGPJ.CPNJFOGKPOD PNJEHHPFEIK, Transform CMBMFMJFHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CACA20", Offset = "0x7CAB820", VA = "0x187CACA20")]
	public void IDOEIFLILAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CABE10", Offset = "0x7CAAC10", VA = "0x187CABE10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CABDD0", Offset = "0x7CAABD0", VA = "0x187CABDD0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD2F0", Offset = "0x7CAC0F0", VA = "0x187CAD2F0")]
	public IKFNKCNBIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LCGEMANJFNH
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 DOPIJPABJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface APNCNBFAKAL
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(HBCKFDINPOH<string>.DLKHFLDLCIN FGAPFDCPKFH, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DJOPIJGIHAP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DJOPIJGIHAP AHFDFAJOKAF(Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DJOPIJGIHAP DKLFEBEMHNI(Action CFDGGKIIHOI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class NPKNAFOBIFJ : DJOPIJGIHAP
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class OAOFJPEAGBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public NPKNAFOBIFJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
				public OAOFJPEAGBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7CB77C0", Offset = "0x7CB65C0", VA = "0x187CB77C0")]
				internal void JIHMAACALPG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7CB7810", Offset = "0x7CB6610", VA = "0x187CB7810")]
				internal void NHOEJDEPBGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7CB7770", Offset = "0x7CB6570", VA = "0x187CB7770")]
				internal void CGDICPEJFOL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> KLJNNEECNBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action FDBDJCPNLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action AECGBELILMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private CKCFHIENLNL FOHLECIOINM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GIKFJBGBKHP
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AFMDIFFECNK
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x27ACA40", Offset = "0x27AB840", VA = "0x1827ACA40", Slot = "4")]
			public DJOPIJGIHAP AHFDFAJOKAF(Action CFDGGKIIHOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x76500D0", Offset = "0x764EED0", VA = "0x1876500D0", Slot = "5")]
			public DJOPIJGIHAP DKLFEBEMHNI(Action CFDGGKIIHOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
			public NPKNAFOBIFJ(Func<JobHandle> EDPFFEJEEFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7CB74B0", Offset = "0x7CB62B0", VA = "0x187CB74B0")]
			public void LECHDFIDIED(Action KEHIOGJGNMP, Action PDPMLIKJJOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7CB7320", Offset = "0x7CB6120", VA = "0x187CB7320")]
			public void FKCGDELNEED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LLMNJNJMHIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public DJOPIJGIHAP jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public LLMNJNJMHIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7CB05E0", Offset = "0x7CAF3E0", VA = "0x187CB05E0")]
			internal bool BKCINCEKNHN(NPKNAFOBIFJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class JBPLCLHKCEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public NPKNAFOBIFJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JBPLCLHKCEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7CAD460", Offset = "0x7CAC260", VA = "0x187CAD460")]
			internal void IEPDOLDCAAP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<NPKNAFOBIFJ> MCIBCBCJOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<NPKNAFOBIFJ> LCNKFGBLPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private BGLABEGMMJM JBEPGNHCKEK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public LHPAHOPGKOM ICHGLNGNGCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD4C0", Offset = "0x7CAC2C0", VA = "0x187CAD4C0")]
		public DJOPIJGIHAP Add(Func<JobHandle> EDPFFEJEEFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD7F0", Offset = "0x7CAC5F0", VA = "0x187CAD7F0")]
		public void Remove(DJOPIJGIHAP JAAMMEMKHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD620", Offset = "0x7CAC420", VA = "0x187CAD620", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD9D0", Offset = "0x7CAC7D0", VA = "0x187CAD9D0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CADC30", Offset = "0x7CACA30", VA = "0x187CADC30")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD610", Offset = "0x7CAC410", VA = "0x187CAD610")]
		[CompilerGenerated]
		private void HHFDGACKBIB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CKCFHIENLNL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKCFHIENLNL AHFDFAJOKAF(Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CKCFHIENLNL GGPGKJCGAOL(Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKCFHIENLNL DKLFEBEMHNI(Action CFDGGKIIHOI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, GCNHNEMJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class GHABFKDKKMI : CKCFHIENLNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle ICKEEKHEPGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action FDBDJCPNLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action NAMLOPMJFJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action AFMDIFFECNK;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool IGGJDLMDHKL
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7CA87A0", Offset = "0x7CA75A0", VA = "0x187CA87A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x74347F0", Offset = "0x74335F0", VA = "0x1874347F0", Slot = "4")]
			public CKCFHIENLNL AHFDFAJOKAF(Action CFDGGKIIHOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7433C50", Offset = "0x7432A50", VA = "0x187433C50", Slot = "5")]
			public CKCFHIENLNL GGPGKJCGAOL(Action CFDGGKIIHOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x76500D0", Offset = "0x764EED0", VA = "0x1876500D0", Slot = "6")]
			public CKCFHIENLNL DKLFEBEMHNI(Action CFDGGKIIHOI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xFE3E80", Offset = "0xFE2C80", VA = "0x180FE3E80")]
			public GHABFKDKKMI(JobHandle HBILFMBHLHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7CA8750", Offset = "0x7CA7550", VA = "0x187CA8750")]
			public void LJHGHGHDHHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7CA8700", Offset = "0x7CA7500", VA = "0x187CA8700")]
			public void FKCGDELNEED()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<GHABFKDKKMI> PMJEBNLBPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> EPNMOPKOEEC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BHAGMIIGHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE210", Offset = "0x7CAD010", VA = "0x187CAE210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x146C2B0", Offset = "0x146B0B0", VA = "0x18146C2B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD10", Offset = "0x7CACB10", VA = "0x187CADD10")]
		public CKCFHIENLNL Add(JobHandle HBILFMBHLHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE420", Offset = "0x7CAD220", VA = "0x187CAE420")]
		public void Remove(CKCFHIENLNL JAAMMEMKHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE030", Offset = "0x7CACE30", VA = "0x187CAE030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7CADE80", Offset = "0x7CACC80", VA = "0x187CADE80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7CADDB0", Offset = "0x7CACBB0", VA = "0x187CADDB0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE520", Offset = "0x7CAD320", VA = "0x187CAE520")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA36800", Offset = "0xA35600", VA = "0x180A36800", Slot = "6")]
		private bool IICCIPPFFJD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7F00", Offset = "0x7CB6D00", VA = "0x187CB7F00")]
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
