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
				[Cpp2IlInjected.Address(RVA = "0x81B3970", Offset = "0x81B2D70", VA = "0x1881B3970")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED1CF0", VA = "0x180ED28F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x81B3930", Offset = "0x81B2D30", VA = "0x1881B3930")]
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
		[Cpp2IlInjected.Address(RVA = "0x81A20D0", Offset = "0x81A14D0", VA = "0x1881A20D0")]
		public LODSettings FJHCDCHECEI(FOBJPMBJJIL BFGBMBMPPGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81A20B0", Offset = "0x81A14B0", VA = "0x1881A20B0")]
		public int EKDADGKPINK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81A20E0", Offset = "0x81A14E0", VA = "0x1881A20E0")]
		public int PELAIOKKMAN(bool PHICEDFMDFI, Vector3 NIPIIBLKLCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81A2180", Offset = "0x81A1580", VA = "0x1881A2180")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FAEGHMOOKJI
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
public interface PHAPANCEJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHFOGHENOKG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FMHBEADHGGO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KDKLHLGBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IOKJJACLCJF> ELKGNKJLHDJ
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
	void UpdateClusterDistances(Vector3 DPIFCOHCFGC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(DNJFHCEBNPA FCIHIIPNCLK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IOKJJACLCJF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int CDHOHDLKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JDIDCOLFMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BINNDNBPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float DAFHHCOKGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte PJNGKADPOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GDHGJELLPIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum EKOFNLNMHKL
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
	private struct JOFGGOJHNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GDHGJELLPIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81AD340", Offset = "0x81AC740", VA = "0x1881AD340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81ADAD0", Offset = "0x81ACED0", VA = "0x1881ADAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BIBHKLHLAED : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GDHGJELLPIA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public BIBHKLHLAED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81A19A0", Offset = "0x81A0DA0", VA = "0x1881A19A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81A1AD0", Offset = "0x81A0ED0", VA = "0x1881A1AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LHLMPMODFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GDHGJELLPIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81AFC00", Offset = "0x81AF000", VA = "0x1881AFC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81B1460", Offset = "0x81B0860", VA = "0x1881B1460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LLOOGNPDAHH : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GDHGJELLPIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public LLOOGNPDAHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81B14C0", Offset = "0x81B08C0", VA = "0x1881B14C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81B21B0", Offset = "0x81B15B0", VA = "0x1881B21B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int MKEANFPKGBO = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan KGIDMAMOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer DAHAODFEIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter POCAJHJNLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject JAOBDHNNNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject DLFJEKIEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FNEMKCLFFKP GOGNCEJLIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DNJFHCEBNPA> PBEBECDFDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DNJFHCEBNPA> GEKHIBJJOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<DNJFHCEBNPA> GJBENAFIIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int GLOGNDPBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EKOFNLNMHKL BAFDMLFDEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<FMHBEADHGGO>[] PDMPADABFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<IOKJJACLCJF>[] BAKAPBAOKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource KJGOGDNDIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PKFGDIIFLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LDBPABGAEKE IEBAPPJIKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LDBPABGAEKE DNCDPODKDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int GCNEFENOEPI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static GDHGJELLPIA OMAABCNJOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LEKANGPDDCG HIKJKMHJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PIMMLGOLAGG MPHDNFANAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour JDKIFGKDMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material DMCKDLGMACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> KNCCCDBPKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material IGMNBJOOABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> KILKDAAAGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool AGBBMHELOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<PHAPANCEJFN> LIADFLCCKEA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig GLDKAJEHDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 FLEJKJGKGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2092D30", Offset = "0x2092130", VA = "0x182092D30")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2092C50", Offset = "0x2092050", VA = "0x182092C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EKOFNLNMHKL CPBBDJEILMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1072D30", Offset = "0x1072130", VA = "0x181072D30")]
		get
		{
			return default(EKOFNLNMHKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81AB160", Offset = "0x81AA560", VA = "0x1881AB160")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GDHGJELLPIA NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81A94F0", Offset = "0x81A88F0", VA = "0x1881A94F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool LKKDLJBGPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81AAF60", Offset = "0x81AA360", VA = "0x1881AAF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CCLDHJOKDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81AAC00", Offset = "0x81AA000", VA = "0x1881AAC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> EAEMPFDOCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81AB290", Offset = "0x81AA690", VA = "0x1881AB290")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81AAEA0", Offset = "0x81AA2A0", VA = "0x1881AAEA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EANEKAEEOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81AB9D0", Offset = "0x81AADD0", VA = "0x1881AB9D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81AB920", Offset = "0x81AAD20", VA = "0x1881AB920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81ABC60", Offset = "0x81AB060", VA = "0x1881ABC60")]
	public GDHGJELLPIA(LEKANGPDDCG HIKJKMHJOAO, PIMMLGOLAGG MPHDNFANAJG, ClusterLODConfig HGPDHKEMPNJ, MonoBehaviour JDKIFGKDMFH, Material ONBPNPJPDNM, ClusterMeshRenderer DAHAODFEIPP, MeshFilter POCAJHJNLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81AB570", Offset = "0x81AA970", VA = "0x1881AB570")]
	private void NGEBMCPBACL(Material ONBPNPJPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81AA730", Offset = "0x81A9B30", VA = "0x1881AA730")]
	public void HCLCMNHIHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81AAD50", Offset = "0x81AA150", VA = "0x1881AAD50")]
	public void JMIAMBGBAEP(Action<Material> DBGKPIKFMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81AAE80", Offset = "0x81AA280", VA = "0x1881AAE80")]
	public static CGCDLCFCEHB.EDHPDAAIBDC KDAOIKHNOHH(CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC)
	{
		return default(CGCDLCFCEHB.EDHPDAAIBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81A95F0", Offset = "0x81A89F0", VA = "0x1881A95F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81AB060", Offset = "0x81AA460", VA = "0x1881AB060")]
	public static void LOPCJOPGKBB(Vector3 EGEPHHMLMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81AB800", Offset = "0x81AAC00", VA = "0x1881AB800")]
	private void OBMPCCABGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81A91F0", Offset = "0x81A85F0", VA = "0x1881A91F0")]
	private void BMBNHPPFNMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81AA9D0", Offset = "0x81A9DD0", VA = "0x1881AA9D0")]
	private void IEGFMGAIFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81A8AB0", Offset = "0x81A7EB0", VA = "0x1881A8AB0")]
	public void BALPDGJGEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81AB6E0", Offset = "0x81AAAE0", VA = "0x1881AB6E0")]
	[AsyncStateMachine(typeof(JOFGGOJHNAN))]
	public Task NIEFNJKMGJL(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81A9110", Offset = "0x81A8510", VA = "0x1881A9110")]
	[IteratorStateMachine(typeof(BIBHKLHLAED))]
	private IEnumerator<KHJLACPAINM> BHEOHLMPNHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81AA4C0", Offset = "0x81A98C0", VA = "0x1881AA4C0")]
	[AsyncStateMachine(typeof(LHLMPMODFCC))]
	private Task FLBNFOACOCP(CIIMOEPMPCG<string>.MOMGGNPHIKH PILFBAOJCKP, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81AA7D0", Offset = "0x81A9BD0", VA = "0x1881AA7D0")]
	public void HJGAGCAFKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81AB4B0", Offset = "0x81AA8B0", VA = "0x1881AB4B0")]
	public void NDAEGPHADPP(IEnumerable<FMHBEADHGGO> OCKLLBFLKAB, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81A87B0", Offset = "0x81A7BB0", VA = "0x1881A87B0")]
	public void AKEKIEONKNJ(IEnumerable<FMHBEADHGGO> OCKLLBFLKAB, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81A99C0", Offset = "0x81A8DC0", VA = "0x1881A99C0")]
	public List<ClusterMeshRenderer> EFHKNKIAOLL(List<DNJFHCEBNPA> PEFHILPJDIP, GIJLHKFOFFB LDEPDDDHLLO, FAEGHMOOKJI DANOPCAPJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81A9F80", Offset = "0x81A9380", VA = "0x1881A9F80")]
	public void EFOAIOGIDPJ(PHAPANCEJFN NOALAADJPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81A9190", Offset = "0x81A8590", VA = "0x1881A9190")]
	public bool BKPJGBIAFLB(PHAPANCEJFN NOALAADJPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81A9540", Offset = "0x81A8940", VA = "0x1881A9540")]
	public void DBEMFLMLLDC(DNJFHCEBNPA LOFJBHIKFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81AAB20", Offset = "0x81A9F20", VA = "0x1881AAB20")]
	public void INAPMPKMDCK(IOKJJACLCJF LFDKNECEJEF, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81AA440", Offset = "0x81A9840", VA = "0x1881AA440")]
	public void FCEKCALACNM(IOKJJACLCJF LFDKNECEJEF, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81AA5E0", Offset = "0x81A99E0", VA = "0x1881AA5E0")]
	private void GHKBGDHHADM(Vector3 DPIFCOHCFGC, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81AB350", Offset = "0x81AA750", VA = "0x1881AB350")]
	private void MIHPIPCLJMI(Vector3 DPIFCOHCFGC, FAEGHMOOKJI DANOPCAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81A92C0", Offset = "0x81A86C0", VA = "0x1881A92C0")]
	[IteratorStateMachine(typeof(LLOOGNPDAHH))]
	private IEnumerator<KHJLACPAINM> BPGGDHIBIJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81ABA80", Offset = "0x81AAE80", VA = "0x1881ABA80")]
	private int PMBIDPFFFPF(int NOEININIMIL, int BIJPOLONEML, List<IOKJJACLCJF> NKEPLHPJENI, byte BFGBMBMPPGG, int OFLFKPDPJJK, float CHDLLGOLADC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81A9340", Offset = "0x81A8740", VA = "0x1881A9340")]
	public void CBDHBFLGDII(DNJFHCEBNPA FCIHIIPNCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81AB530", Offset = "0x81AA930", VA = "0x1881AB530")]
	public bool NEPFOLFHBCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB1ED20", Offset = "0xB1E120", VA = "0x180B1ED20")]
	public Material OKNHMABBMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81AB890", Offset = "0x81AAC90", VA = "0x1881AB890")]
	public Material OKNHMABBMNH(CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xA76C20", Offset = "0xA76020", VA = "0x180A76C20")]
	public Material JBFDLIOMMPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81AACC0", Offset = "0x81AA0C0", VA = "0x1881AACC0")]
	public Material JBFDLIOMMPO(CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x81AA400", Offset = "0x81A9800", VA = "0x1881AA400")]
	public int EKDADGKPINK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81AA030", Offset = "0x81A9430", VA = "0x1881AA030")]
	public (long, int) EJFHNFPGICL()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KJKDPLJDEKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> FPBLMJNFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> BAAJHGLBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> ENHKABHMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> FBOGEDHOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> PCCEEKOEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> LFENBOEIDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 LDOIMEDOFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float FJKNHIMEBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> NBAOGJAHIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> IKJNOGEBNJP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81AF900", Offset = "0x81AED00", VA = "0x1881AF900")]
	public KJKDPLJDEKJ(CGCDLCFCEHB NIKBNBLEJEO, NativeList<float3> LFENBOEIDOD, NativeParallelMultiHashMap<int, int> NBAOGJAHIJM, NativeArray<int> IKJNOGEBNJP, Vector3 LDOIMEDOFHA, float FJKNHIMEBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81AF200", Offset = "0x81AE600", VA = "0x1881AF200")]
	private int AKGHNOHJKPH(float3 DPIFCOHCFGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81AF260", Offset = "0x81AE660", VA = "0x1881AF260")]
	private int CFLPCPALIHF(int LBMGGFIIAAK, int PEENICAIFOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81AF4D0", Offset = "0x81AE8D0", VA = "0x1881AF4D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AJPHLPHEFMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> NBAOGJAHIJM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> IKJNOGEBNJP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int EMPMJHBMDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> CPNINAGOMKB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81A16C0", Offset = "0x81A0AC0", VA = "0x1881A16C0")]
	public void AMHAEEMOGAM(int PFPBLIFJJFD, Allocator KCEIEKBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x81A18C0", Offset = "0x81A0CC0", VA = "0x1881A18C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AJPHLPHEFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct PHDCBNHHAAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> PGEJCEOMNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> DNDKPMDAMJK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x81B7790", Offset = "0x81B6B90", VA = "0x1881B7790")]
	public PHDCBNHHAAE(AJPHLPHEFMK LIBMJFIGAOC, CGCDLCFCEHB NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81B76E0", Offset = "0x81B6AE0", VA = "0x1881B76E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct MFEHFBMLMGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> KOPMJDJDNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> FHJFAFBKNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> HMLOAGCEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> KOIHBDOLKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> AGOCLPINAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> CPNINAGOMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> PGEJCEOMNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> NMJFHGOENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> GOGBMGCMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> LAHDPDNNIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> HMHFGILAJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> BENLHDPPPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> GMLHAPNODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LPMPNJPGHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float LNOEKGIHPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 ALEAEKJGEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float CKICOIAHFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float AEHHMOEPDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float ICEDCEOLBDI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81B5440", Offset = "0x81B4840", VA = "0x1881B5440")]
	public MFEHFBMLMGK(AJPHLPHEFMK KLLBGHEKODD, CGCDLCFCEHB NIKBNBLEJEO, CGCDLCFCEHB NGHMKIMLEHN, float AEHHMOEPDFM, float ICEDCEOLBDI, Vector3 ALEAEKJGEAE, float CKICOIAHFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81B42F0", Offset = "0x81B36F0", VA = "0x1881B42F0")]
	private float3 CCHLHHOJLJF(int LBMGGFIIAAK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81B4FE0", Offset = "0x81B43E0", VA = "0x1881B4FE0")]
	private void LKFGDIABCJA(int LBMGGFIIAAK, [Out] float3 KLMCIAKGBNJ, [Out] float3 NKHDJBAPMOP, [Out] float4 LCFDGGLCKDG, [Out] float4 EEODLLEKGON, [Out] float2 IEFANBFBIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81B3EC0", Offset = "0x81B32C0", VA = "0x1881B3EC0")]
	private int AFJCCCLMELP(int CHBGLJEIKKM, int BJKHFEJOFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81B4DE0", Offset = "0x81B41E0", VA = "0x1881B4DE0")]
	private void KGIHKEEFNCM(int CHBGLJEIKKM, int BJKHFEJOFOM, int KLAPKDEENIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81B41A0", Offset = "0x81B35A0", VA = "0x1881B41A0")]
	private bool AGHIIDGJKLJ(int CHBGLJEIKKM, int BJKHFEJOFOM, float FOMOJMIOILH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81B4D20", Offset = "0x81B4120", VA = "0x1881B4D20")]
	private bool GOHCFLKLLJE(int CHBGLJEIKKM, int BJKHFEJOFOM, int KLAPKDEENIJ, float FOMOJMIOILH, bool OPIILBHPEHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x81B51C0", Offset = "0x81B45C0", VA = "0x1881B51C0")]
	private bool MDOIMJHKMJG(int CHBGLJEIKKM, int BJKHFEJOFOM, int KLAPKDEENIJ, float FOMOJMIOILH, bool OPIILBHPEHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81B5420", Offset = "0x81B4820", VA = "0x1881B5420")]
	private void PPHIHGLAICM(int CHBGLJEIKKM, int BJKHFEJOFOM, int KLAPKDEENIJ, [Out] int AGALOEDCGIB, [Out] int IBHFBGIJLMA, [Out] int ACJBOLEGEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x81B43A0", Offset = "0x81B37A0", VA = "0x1881B43A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OJAFKHKCAFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HBNFIDKOPHO : IDisposable, IOKJJACLCJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds EFDPEDFEFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<DNJFHCEBNPA> PEFHILPJDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 ALKNEENEIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 KLJAJKKCGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int EMPDGDMCHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CGCDLCFCEHB IGCDEJFLLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long OENPBHIEEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AJPHLPHEFMK HLMBCKNAOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform LDEPDDDHLLO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int JNKDDBGCDJL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x81AC900", Offset = "0x81ABD00", VA = "0x1881AC900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh AEIPFKLALHD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CGCDLCFCEHB.EDHPDAAIBDC GJFPALIKJLI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
			[CompilerGenerated]
			get
			{
				return default(CGCDLCFCEHB.EDHPDAAIBDC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh GGIDBPGMNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CGCDLCFCEHB.EDHPDAAIBDC AKKABFAJHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD90A0", Offset = "0xAD84A0", VA = "0x180AD90A0")]
			[CompilerGenerated]
			get
			{
				return default(CGCDLCFCEHB.EDHPDAAIBDC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xF92FE0", Offset = "0xF923E0", VA = "0x180F92FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float BINNDNBPCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245C40", VA = "0x181246840", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x19ED750", Offset = "0x19ECB50", VA = "0x1819ED750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte PJNGKADPOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1023DE0", Offset = "0x10231E0", VA = "0x181023DE0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1022460", Offset = "0x1021860", VA = "0x181022460", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int CDHOHDLKMMO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA53F0", Offset = "0xAA47F0", VA = "0x180AA53F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1581650", Offset = "0x1580A50", VA = "0x181581650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int JDIDCOLFMOK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA96380", Offset = "0xA95780", VA = "0x180A96380", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1580E90", Offset = "0x1580290", VA = "0x181580E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DAFHHCOKGMK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x81ACCD0", Offset = "0x81AC0D0", VA = "0x1881ACCD0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81ACD80", Offset = "0x81AC180", VA = "0x1881ACD80")]
		public void MMDJFMEAFAO(FOBJPMBJJIL BFGBMBMPPGG, [Out] int JIHFJOICEPE, [Out] int MFOAPNHFCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81ACB00", Offset = "0x81ABF00", VA = "0x1881ACB00")]
		public void FBFKBOPNCGO(FOBJPMBJJIL BFGBMBMPPGG, GCHCCBCGNIE DCHKOPDBDFH, int INMODPJCNEO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81ACFE0", Offset = "0x81AC3E0", VA = "0x1881ACFE0")]
		public void OGCFHMMJGBI(Mesh NIKBNBLEJEO, CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81ACCF0", Offset = "0x81AC0F0", VA = "0x1881ACCF0")]
		public void LCHCIKIJICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81AC940", Offset = "0x81ABD40", VA = "0x1881AC940", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x81AD090", Offset = "0x81AC490", VA = "0x1881AD090")]
		public HBNFIDKOPHO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds EFDPEDFEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public CGCDLCFCEHB.EDHPDAAIBDC NKKJBACDLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<HBNFIDKOPHO> KPBEFOBIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public DBGOOGANNJJ NNGEOHDMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer CCGANJILKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int LIDJJKKCIOH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GEGAOALOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HDHNINJAAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KDKLHLGBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81B5ED0", Offset = "0x81B52D0", VA = "0x1881B5ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81B6A20", Offset = "0x81B5E20", VA = "0x1881B6A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x81B7420", Offset = "0x81B6820", VA = "0x1881B7420")]
	public int LFFIHENMIPD(int KFBLGOKPLJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81B71D0", Offset = "0x81B65D0", VA = "0x1881B71D0")]
	public void IMHHPFJCOBP(DEHCCEHBLKN PCFHGFPDCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81B6190", Offset = "0x81B5590", VA = "0x1881B6190")]
	public void CJBPEEKHAII(Transform MKODIMHMJAA, bool NEKIOFJBOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81B7450", Offset = "0x81B6850", VA = "0x1881B7450")]
	public bool MEGAKMBKEHL(bool HIHHGNFEAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81B6BA0", Offset = "0x81B5FA0", VA = "0x1881B6BA0")]
	public void FAKJEEPJFGI(Transform LDEPDDDHLLO, bool NEKIOFJBOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81B5F20", Offset = "0x81B5320", VA = "0x1881B5F20")]
	public bool CBDHBFLGDII(DNJFHCEBNPA FCIHIIPNCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81B7610", Offset = "0x81B6A10", VA = "0x1881B7610")]
	public OJAFKHKCAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FNEMKCLFFKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<OJAFKHKCAFF.HBNFIDKOPHO> BLIJEFICOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private LNOBDDIOIHE EPEFAFKMOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<OJAFKHKCAFF.HBNFIDKOPHO> BELLOLHMILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int DKBPPICMALA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81A7E40", Offset = "0x81A7240", VA = "0x1881A7E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x81A7F20", Offset = "0x81A7320", VA = "0x1881A7F20")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x81A8010", Offset = "0x81A7410", VA = "0x1881A8010")]
	public void KOBMLIBBKBO(OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA, Transform LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x81A7B20", Offset = "0x81A6F20", VA = "0x1881A7B20")]
	public void CBDHBFLGDII(OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x81A7D00", Offset = "0x81A7100", VA = "0x1881A7D00")]
	private OJAFKHKCAFF.HBNFIDKOPHO DGKFLJHKLGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81A80D0", Offset = "0x81A74D0", VA = "0x1881A80D0")]
	private bool LHMFDPLJOKB(OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x81A8490", Offset = "0x81A7890", VA = "0x1881A8490")]
	private void PLHNGJLJGMN(OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x81A8170", Offset = "0x81A7570", VA = "0x1881A8170")]
	public bool NAAINKLOCME(OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81A81A0", Offset = "0x81A75A0", VA = "0x1881A81A0")]
	public bool OGELNPLKAMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x81A7FA0", Offset = "0x81A73A0", VA = "0x1881A7FA0")]
	private OJAFKHKCAFF.HBNFIDKOPHO IPNHKDOFIHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x81A7800", Offset = "0x81A6C00", VA = "0x1881A7800")]
	public long ALJILLHLPNB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81A8540", Offset = "0x81A7940", VA = "0x1881A8540")]
	public FNEMKCLFFKP()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GIBOJEEDEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int COEBOHLKAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int MPFLKPFHHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float CMLFKDPONHD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<OJAFKHKCAFF> LEIKIMGMDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81AC8B0", Offset = "0x81ABCB0", VA = "0x1881AC8B0")]
	public GIBOJEEDEIF(int COEBOHLKAAM, int MPFLKPFHHBL, float LGNPNJKAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x81AC750", Offset = "0x81ABB50", VA = "0x1881AC750")]
	public void LFHEDPPMEHB(IBDGCMEDOBP JBPANIFOJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x81AC800", Offset = "0x81ABC00", VA = "0x1881AC800")]
	private int MKOEHEJGCBC(DEHCCEHBLKN BLJBPFHLMML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x81AC490", Offset = "0x81AB890", VA = "0x1881AC490")]
	private void LFHEDPPMEHB(DEHCCEHBLKN BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x81AC3F0", Offset = "0x81AB7F0", VA = "0x1881AC3F0")]
	private void DKFHFOCPMJF(DEHCCEHBLKN BLJBPFHLMML, OJAFKHKCAFF PGCFODIBDCL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, FMHBEADHGGO
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DMFBFFOJPCC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
			[DebuggerHidden]
			public DMFBFFOJPCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x81A5230", Offset = "0x81A4630", VA = "0x1881A5230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x81A53F0", Offset = "0x81A47F0", VA = "0x1881A53F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x81A5340", Offset = "0x81A4740", VA = "0x1881A5340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x81A5340", Offset = "0x81A4740", VA = "0x1881A5340", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int KDKLHLGBBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x81A3D20", Offset = "0x81A3120", VA = "0x1881A3D20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<IOKJJACLCJF> ELKGNKJLHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x81A3D00", Offset = "0x81A3100", VA = "0x1881A3D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> KPBEFOBIFMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OJAFKHKCAFF GEGAOALOAKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public FAEGHMOOKJI LEGJKNBIMKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(FAEGHMOOKJI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D170", Offset = "0xA6C570", VA = "0x180A6D170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HKPECGNIAHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDC3EC0", Offset = "0xDC32C0", VA = "0x180DC3EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81A21E0", Offset = "0x81A15E0", VA = "0x1881A21E0")]
		public static ClusterMeshRenderer Create(OJAFKHKCAFF NIKBNBLEJEO, ClusterMeshRenderer DAHAODFEIPP, MeshFilter POCAJHJNLFK, GIJLHKFOFFB LDEPDDDHLLO, FAEGHMOOKJI DANOPCAPJEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81A2460", Offset = "0x81A1860", VA = "0x1881A2460", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x81A2FD0", Offset = "0x81A23D0", VA = "0x1881A2FD0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(DNJFHCEBNPA FCIHIIPNCLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81A2D80", Offset = "0x81A2180", VA = "0x1881A2D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81A29A0", Offset = "0x81A1DA0", VA = "0x1881A29A0")]
		public void Init(OJAFKHKCAFF NIKBNBLEJEO, MeshFilter POCAJHJNLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81A24C0", Offset = "0x81A18C0", VA = "0x1881A24C0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81A3100", Offset = "0x81A2500", VA = "0x1881A3100", Slot = "7")]
		public void UpdateClusterDistances(Vector3 DPIFCOHCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x81A33B0", Offset = "0x81A27B0", VA = "0x1881A33B0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x81A2920", Offset = "0x81A1D20", VA = "0x1881A2920")]
		[IteratorStateMachine(typeof(DMFBFFOJPCC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x81A2E10", Offset = "0x81A2210", VA = "0x1881A2E10")]
		public void SetupTagAndLayer(string HHKLKJCBFCE, int DANOPCAPJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81A2DF0", Offset = "0x81A21F0", VA = "0x1881A2DF0")]
		public bool Remove(DNJFHCEBNPA FCIHIIPNCLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KMOFMMBHAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int EMAFKACLAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FDIBAFEDFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int MFOAPNHFCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int JIHFJOICEPE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81AF9C0", Offset = "0x81AEDC0", VA = "0x1881AF9C0")]
	public KMOFMMBHAML(int FDIBAFEDFOG, int MFOAPNHFCLN, int EMAFKACLAEJ, int JIHFJOICEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DBGOOGANNJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> CPNINAGOMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> PCCEEKOEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<KMOFMMBHAML> BMIEJBIEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> EPFPKHAHGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> PDBMKALPFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> PMMNKKICLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle EDPKGAKIIHD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IABJMOAGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9EC40", Offset = "0xA9E040", VA = "0x180A9EC40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA9D970", Offset = "0xA9CD70", VA = "0x180A9D970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81A3EC0", Offset = "0x81A32C0", VA = "0x1881A3EC0")]
	public void IPJPKJAMFMN(CGCDLCFCEHB EGECIHHCNJB, NativeList<KMOFMMBHAML> BMIEJBIEHPH, float MJHAIBCGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x81A4F20", Offset = "0x81A4320", VA = "0x1881A4F20")]
	public void OLFKEDPPLKB(Transform LDEPDDDHLLO, bool NEKIOFJBOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x81A4D80", Offset = "0x81A4180", VA = "0x1881A4D80")]
	public void MEGAKMBKEHL(OJAFKHKCAFF CCGANJILKHA, bool HIHHGNFEAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x81A3D80", Offset = "0x81A3180", VA = "0x1881A3D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x81A3E90", Offset = "0x81A3290", VA = "0x1881A3E90")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DBGOOGANNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct MLBPHCJCIBN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> COEMHJPINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> CPNINAGOMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<KMOFMMBHAML> CGJPCAMPLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> EPFPKHAHGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 ALEAEKJGEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> PDBMKALPFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> PMMNKKICLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool NEKIOFJBOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float FOFJFFKEJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float FPPNJNMLKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float BNCPLEOFHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> PCCEEKOEHBF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81B5A80", Offset = "0x81B4E80", VA = "0x1881B5A80")]
	public MLBPHCJCIBN(DBGOOGANNJJ KMHLHDDIHNG, Vector3 ALEAEKJGEAE, bool NEKIOFJBOBE, float FOFJFFKEJLB, float FPPNJNMLKBH, float BNCPLEOFHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x81B5580", Offset = "0x81B4980", VA = "0x1881B5580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DNJFHCEBNPA : AHNPBENMMNA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds AIIPLAGEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DEHCCEHBLKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<DNJFHCEBNPA> PEFHILPJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public DEHCCEHBLKN JIECBJMGMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public DEHCCEHBLKN JJNGHGKJAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public DEHCCEHBLKN CFOOBBPFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int JIHFJOICEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds EFDPEDFEFJK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x81A51B0", Offset = "0x81A45B0", VA = "0x1881A51B0")]
	public DEHCCEHBLKN(List<DNJFHCEBNPA> PEFHILPJDIP, [Optional] DEHCCEHBLKN JIECBJMGMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IBDGCMEDOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<DEHCCEHBLKN> KKHENOIMDOG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public DEHCCEHBLKN NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81AD1B0", Offset = "0x81AC5B0", VA = "0x1881AD1B0")]
	public IBDGCMEDOBP(DEHCCEHBLKN LDEPDDDHLLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FIKEDLHIFLK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LAJCAADLPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int JIPAFNBONEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int LBNIIGFALHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int CKPFBBEOFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int CABFDAMIFLC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct NEIHGJDJPNJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int FJKGINIHFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float LFMNDELJNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<DNJFHCEBNPA> PEFHILPJDIP;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x81B5E70", Offset = "0x81B5270", VA = "0x1881B5E70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum HGKKHAKOIKL
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
	private LAJCAADLPDP JHGMJLHKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int KBKMFOCPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int COEBOHLKAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int MPFLKPFHHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LGNPNJKAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float FJGCANKMBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<DEHCCEHBLKN> KCLJJKGLBDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IBDGCMEDOBP NBEDIGCHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x81A77A0", Offset = "0x81A6BA0", VA = "0x1881A77A0")]
	public FIKEDLHIFLK(int COEBOHLKAAM, int MPFLKPFHHBL, float LGNPNJKAHIG, int KBKMFOCPBJE, float FJGCANKMBCP = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x81A5540", Offset = "0x81A4940", VA = "0x1881A5540")]
	public void BPMMCBMMPGO(List<DNJFHCEBNPA> PEFHILPJDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81A7730", Offset = "0x81A6B30", VA = "0x1881A7730")]
	public bool POMOIMBOGLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x81A6B90", Offset = "0x81A5F90", VA = "0x1881A6B90")]
	private float KCHLDBKPEAN(Vector3 FELPICHHHLC, Vector3 IDCCLFDFCEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x81A6BE0", Offset = "0x81A5FE0", VA = "0x1881A6BE0")]
	private float KCHLDBKPEAN(Vector3 MPDDFCCPIOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x81A6C00", Offset = "0x81A6000", VA = "0x1881A6C00")]
	private bool PDNCOKAJINN(DEHCCEHBLKN KJFGFKFKPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x81A5B20", Offset = "0x81A4F20", VA = "0x1881A5B20")]
	private NEIHGJDJPNJ HJPOAACNIKP(List<DNJFHCEBNPA> AGLCGNDGLFA, HGKKHAKOIKL OKIMNNOOLBB)
	{
		return default(NEIHGJDJPNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x81A5760", Offset = "0x81A4B60", VA = "0x1881A5760")]
	private void CEMAHJPNPFJ(List<DNJFHCEBNPA> PEFHILPJDIP, NativeArray<Vector3> MJMCFIFIEAH, NativeArray<Vector3> NGPECDANDBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KBLOLIAIHBF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x81AF030", Offset = "0x81AE430", VA = "0x1881AF030")]
	public static Bounds MEGELLOBJND(List<DNJFHCEBNPA> PEFHILPJDIP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81AEE60", Offset = "0x81AE260", VA = "0x1881AEE60")]
	public static int JIKCBGILJOG(List<DNJFHCEBNPA> PEFHILPJDIP, FOBJPMBJJIL BFGBMBMPPGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class LFGIFBNEGBN
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool EGPJPMNBFPM(float4* FBOGEDHOCIA, int COONBEDHJNN);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class MDJNFENOIFB
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x81B3B80", Offset = "0x81B2F80", VA = "0x1881B3B80")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x81B3CB0", Offset = "0x81B30B0", VA = "0x1881B3CB0")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x81B3E10", Offset = "0x81B3210", VA = "0x1881B3E10")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81B3990", Offset = "0x81B2D90", VA = "0x1881B3990")]
		public unsafe static bool COEOEEINBLF(float4* FBOGEDHOCIA, int COONBEDHJNN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81AF9E0", Offset = "0x81AEDE0", VA = "0x1881AF9E0")]
	[BurstCompile]
	public unsafe static bool GLIKIPNDNBI(float4* FBOGEDHOCIA, int COONBEDHJNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x81A1420", Offset = "0x81A0820", VA = "0x1881A1420")]
	[BurstCompile]
	public unsafe static bool PGOCIOHPDIO(float4* FBOGEDHOCIA, int COONBEDHJNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct MPBCBKDMNNC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> DBPEDIFKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> AFGJFLOMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> GGJILDJKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> BPCJMPHJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> FFHKMANAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> ENHKABHMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> BEGNMNCHNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> LMKABGDNEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<CGCDLCFCEHB.KMKHIHCKCPI> AJCGGJDMBGG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x81B5E00", Offset = "0x81B5200", VA = "0x1881B5E00")]
	public MPBCBKDMNNC(CGCDLCFCEHB IHFEOFOINFC, NativeArray<bool> BEGNMNCHNND, NativeList<ushort> LMKABGDNEGL, NativeList<CGCDLCFCEHB.KMKHIHCKCPI> AJCGGJDMBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x81B5B50", Offset = "0x81B4F50", VA = "0x1881B5B50", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct BIJBFOCKIOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> DBPEDIFKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> AFGJFLOMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> GGJILDJKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> BPCJMPHJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> FFHKMANAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> ENHKABHMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> JPNMEHEMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> HNEJILIJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> ODHBNDLPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> ANCKIDCAPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> GIINECOAFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> HJGKDIBKCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> BEGNMNCHNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> LMKABGDNEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<CGCDLCFCEHB.KMKHIHCKCPI> AJCGGJDMBGG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x81A1FF0", Offset = "0x81A13F0", VA = "0x1881A1FF0")]
	public BIJBFOCKIOA(CGCDLCFCEHB IHFEOFOINFC, CGCDLCFCEHB AFKHEINIDPH, NativeArray<bool> BEGNMNCHNND, NativeList<ushort> LMKABGDNEGL, NativeList<CGCDLCFCEHB.KMKHIHCKCPI> AJCGGJDMBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x81A1B20", Offset = "0x81A0F20", VA = "0x1881A1B20", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LNOBDDIOIHE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private CGCDLCFCEHB PDHKEAAAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private CGCDLCFCEHB IHFEOFOINFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> FFMCBDDLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> LMKABGDNEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<CGCDLCFCEHB.KMKHIHCKCPI> AJCGGJDMBGG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static CGCDLCFCEHB MJDPOBLHPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private BGBHELJOJCI HIEBDEGGHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private GCHCCBCGNIE DCHKOPDBDFH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle EDPKGAKIIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OJAFKHKCAFF.HBNFIDKOPHO KJFGFKFKPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ECPCFKLJIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26C2E20", Offset = "0x26C2220", VA = "0x1826C2E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x81B2210", Offset = "0x81B1610", VA = "0x1881B2210")]
	[DIELKDJGIPF(LDIDCMPDDMG.EnteredEditMode, 0)]
	private static void ACKEHIKBCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x81B2C80", Offset = "0x81B2080", VA = "0x1881B2C80")]
	public void IPJPKJAMFMN(OJAFKHKCAFF.HBNFIDKOPHO CGJPCAMPLNA, Transform ADOIDFCCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x81B2360", Offset = "0x81B1760", VA = "0x1881B2360")]
	public void FDNLLHDPGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x81B2290", Offset = "0x81B1690", VA = "0x1881B2290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x81B2C40", Offset = "0x81B2040", VA = "0x1881B2C40")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x81B37C0", Offset = "0x81B2BC0", VA = "0x1881B37C0")]
	public LNOBDDIOIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PIMMLGOLAGG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 IOHFGFBDOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LEKANGPDDCG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(CIIMOEPMPCG<string>.MOMGGNPHIKH PILFBAOJCKP, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MMHIHICILKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMHIHICILKJ DBAOGOADHBE(Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMHIHICILKJ PNMNPFEHEIF(Action ENDEKEOKCCM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class PHIOONECFEO : MMHIHICILKJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class PIIBKCMKDDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public PHIOONECFEO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public PIIBKCMKDDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x81B7C60", Offset = "0x81B7060", VA = "0x1881B7C60")]
				internal void AOLCBBCGOLI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x81B7D00", Offset = "0x81B7100", VA = "0x1881B7D00")]
				internal void ICGFNMIHOKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x81B7CB0", Offset = "0x81B70B0", VA = "0x1881B7CB0")]
				internal void COLIJIGIKCP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> PNFDMAFEHJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action AEKACPKLELC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action FFPGLGCJLKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private ONOFIKDKCLJ IANLDMDLMFN;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action PNMGPDJCFOG
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action JLFFPJANGPM
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x29FCB10", Offset = "0x29FBF10", VA = "0x1829FCB10", Slot = "4")]
			public MMHIHICILKJ DBAOGOADHBE(Action ENDEKEOKCCM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6EF0", Offset = "0x7AF62F0", VA = "0x187AF6EF0", Slot = "5")]
			public MMHIHICILKJ PNMNPFEHEIF(Action ENDEKEOKCCM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
			public PHIOONECFEO(Func<JobHandle> BMMCIAGJIJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81B7950", Offset = "0x81B6D50", VA = "0x1881B7950")]
			public void COBMPGJIBLC(Action JINIBJKELAB, Action EMFDOKDPOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x81B77C0", Offset = "0x81B6BC0", VA = "0x1881B77C0")]
			public void CBDHBFLGDII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LNBMPHIGCKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public MMHIHICILKJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LNBMPHIGCKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x81B2200", Offset = "0x81B1600", VA = "0x1881B2200")]
			internal bool IGNLHHPACID(PHIOONECFEO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class IBLEDCKNIKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public PHIOONECFEO newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public IBLEDCKNIKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x81AD2E0", Offset = "0x81AC6E0", VA = "0x1881AD2E0")]
			internal void CGKOPFEOBGA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<PHIOONECFEO> ADCLPBCGGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<PHIOONECFEO> PLNPNPLGBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private LDBPABGAEKE BFCJDKKPFDO;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public JJFMAJDMOPF DHIJFFCPKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81ADB30", Offset = "0x81ACF30", VA = "0x1881ADB30")]
		public MMHIHICILKJ Add(Func<JobHandle> BMMCIAGJIJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81ADE60", Offset = "0x81AD260", VA = "0x1881ADE60")]
		public void Remove(MMHIHICILKJ EDPKGAKIIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81ADC90", Offset = "0x81AD090", VA = "0x1881ADC90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x81AE040", Offset = "0x81AD440", VA = "0x1881AE040")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81AE2F0", Offset = "0x81AD6F0", VA = "0x1881AE2F0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81ADC80", Offset = "0x81AD080", VA = "0x1881ADC80")]
		[CompilerGenerated]
		private void COMDFLHFFKG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ONOFIKDKCLJ
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONOFIKDKCLJ DBAOGOADHBE(Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONOFIKDKCLJ MFKJGKHHBLJ(Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONOFIKDKCLJ PNMNPFEHEIF(Action ENDEKEOKCCM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, FBNDMBMKCOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class ACJDPKGMBNP : ONOFIKDKCLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle HLFDHLANPMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action AEKACPKLELC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action KKEPNAPJBDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action JLFFPJANGPM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool HBLLBEFBBKP
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x81A16B0", Offset = "0x81A0AB0", VA = "0x1881A16B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7A1BAA0", Offset = "0x7A1AEA0", VA = "0x187A1BAA0", Slot = "4")]
			public ONOFIKDKCLJ DBAOGOADHBE(Action ENDEKEOKCCM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7A1BAC0", Offset = "0x7A1AEC0", VA = "0x187A1BAC0", Slot = "5")]
			public ONOFIKDKCLJ MFKJGKHHBLJ(Action ENDEKEOKCCM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6EF0", Offset = "0x7AF62F0", VA = "0x187AF6EF0", Slot = "6")]
			public ONOFIKDKCLJ PNMNPFEHEIF(Action ENDEKEOKCCM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x10B98B0", Offset = "0x10B8CB0", VA = "0x1810B98B0")]
			public ACJDPKGMBNP(JobHandle MEBDILJNFPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x81A1660", Offset = "0x81A0A60", VA = "0x1881A1660")]
			public void CEOCICHNPFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81A1610", Offset = "0x81A0A10", VA = "0x1881A1610")]
			public void CBDHBFLGDII()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<ACJDPKGMBNP> CPGLHJHOMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> KBBOGCBLIOI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MDHGNPMONEF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x81AE920", Offset = "0x81ADD20", VA = "0x1881AE920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x168C580", Offset = "0x168B980", VA = "0x18168C580")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x81AE3D0", Offset = "0x81AD7D0", VA = "0x1881AE3D0")]
		public ONOFIKDKCLJ Add(JobHandle MEBDILJNFPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x81AEC80", Offset = "0x81AE080", VA = "0x1881AEC80")]
		public void Remove(ONOFIKDKCLJ EDPKGAKIIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x81AE750", Offset = "0x81ADB50", VA = "0x1881AE750")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x81AE5A0", Offset = "0x81AD9A0", VA = "0x1881AE5A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x81AE4D0", Offset = "0x81AD8D0", VA = "0x1881AE4D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x81AED80", Offset = "0x81AE180", VA = "0x1881AED80")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA9B060", Offset = "0xA9A460", VA = "0x180A9B060", Slot = "6")]
		private bool CPFAEMKBANH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x81B7D50", Offset = "0x81B7150", VA = "0x1881B7D50")]
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
