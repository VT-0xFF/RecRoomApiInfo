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
using Mono.Math;
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
	[CreateAssetMenu]
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
				[Cpp2IlInjected.Address(RVA = "0x53EC1D0", Offset = "0x53EABD0", VA = "0x1853EC1D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1C81140", Offset = "0x1C7FB40", VA = "0x181C81140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x53EC190", Offset = "0x53EAB90", VA = "0x1853EC190")]
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
		[Cpp2IlInjected.Address(RVA = "0x53DDBD0", Offset = "0x53DC5D0", VA = "0x1853DDBD0")]
		public LODSettings MJKBBLLCHDL(ELDADGLNPNI HGNNAGKFJJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x53DDAB0", Offset = "0x53DC4B0", VA = "0x1853DDAB0")]
		public int BJPJIBCAFOD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53DDAD0", Offset = "0x53DC4D0", VA = "0x1853DDAD0")]
		public int IELDDLGCPFC(bool NNGAKCJIAAD, Vector3 JEAIFEEIBNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53DDBE0", Offset = "0x53DC5E0", VA = "0x1853DDBE0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DLJJHEIAHAB
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
public interface JPBLLJNBKGK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJOMNGHIOMP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JHJJKCOPGJK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GENJENJDPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KPICLELKMBE> FMAFGMBPEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DLJJHEIAHAB JIICLFALONL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool UpdateVisibility();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdateClusterDistances(Vector3 DEFMLJAJEKI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(ANNJHAHACOM PAHLILOLPHD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KPICLELKMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int AMOAIOLBDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int CBHLINEHCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MMGPEKNIPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DHLDEEEEGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte OAFAMDDBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IKJECKMEANK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JMGNGAHGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AJHPDKFEDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IKJECKMEANK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LCHNHFGOJFL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LCHNHFGOJFL <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x53DB960", Offset = "0x53DA360", VA = "0x1853DB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ENPMPHHHKDD : IEnumerator<OMEPBDNLACD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private OMEPBDNLACD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IKJECKMEANK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OMEPBDNLACD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78C940", Offset = "0x78B340", VA = "0x18078C940")]
		[DebuggerHidden]
		public ENPMPHHHKDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x53E2D50", Offset = "0x53E1750", VA = "0x1853E2D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x53E2E10", Offset = "0x53E1810", VA = "0x1853E2E10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DMNHOOJFIDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IKJECKMEANK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LCHNHFGOJFL worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LCHNHFGOJFL <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x53E05E0", Offset = "0x53DEFE0", VA = "0x1853E05E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ONLLMBGKFPB : IEnumerator<OMEPBDNLACD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OMEPBDNLACD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public IKJECKMEANK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OMEPBDNLACD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x78C940", Offset = "0x78B340", VA = "0x18078C940")]
		[DebuggerHidden]
		public ONLLMBGKFPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x53ECB60", Offset = "0x53EB560", VA = "0x1853ECB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53EDA10", Offset = "0x53EC410", VA = "0x1853EDA10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int BIBLOPEGDNG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan GBMMOGBKDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer ICIBPGOOGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter NFLPFJMBMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject MBIMBPJEBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject NNKCCNPIIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FLMGFKOFJEN LIFOAPMLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<ANNJHAHACOM> NOGLOBKLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<ANNJHAHACOM> GKJBLKPKGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<ANNJHAHACOM> DPLAEKMFMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DNEPKDLCLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JMGNGAHGLJE HKEDLHALFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<JHJJKCOPGJK>[] NMFDIGLNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KPICLELKMBE>[] BHFBKABLGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource KNELKNNMKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PNLJMIBGEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GJINICPNEFL ELLMKICJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GJINICPNEFL KMMDMPFGKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NEOJEFIPPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int KHIFKFLPCMN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static IKJECKMEANK FKKNFFLNGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LAHHPLFLGCB JNGNOIGFKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GFIBFDAADIE PJDOAGHDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour DDPNHBDOMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material AJMMHIPLFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<JPBLLJNBKGK> CEJKMEADFIF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig KLCLGHKHKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 ECDFPKPCGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x115C8E0", Offset = "0x115B2E0", VA = "0x18115C8E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x115C7F0", Offset = "0x115B1F0", VA = "0x18115C7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JMGNGAHGLJE NMKHOPKFEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9E7300", Offset = "0x9E5D00", VA = "0x1809E7300")]
		get
		{
			return default(JMGNGAHGLJE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53E6600", Offset = "0x53E5000", VA = "0x1853E6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IKJECKMEANK BLPHKNHCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53E6130", Offset = "0x53E4B30", VA = "0x1853E6130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MKBIMADKJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x53E8130", Offset = "0x53E6B30", VA = "0x1853E8130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KNILMHKLNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x53E6370", Offset = "0x53E4D70", VA = "0x1853E6370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> HHCPAEPDFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53E6730", Offset = "0x53E5130", VA = "0x1853E6730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53E6BC0", Offset = "0x53E55C0", VA = "0x1853E6BC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IGGKNOJGJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x53E7F90", Offset = "0x53E6990", VA = "0x1853E7F90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x53E6520", Offset = "0x53E4F20", VA = "0x1853E6520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53E84A0", Offset = "0x53E6EA0", VA = "0x1853E84A0")]
	public IKJECKMEANK(LAHHPLFLGCB JNGNOIGFKAL, GFIBFDAADIE PJDOAGHDAEK, ClusterLODConfig DIFIOGOPFHH, MonoBehaviour DDPNHBDOMJP, Material AJMMHIPLFIJ, ClusterMeshRenderer ICIBPGOOGEC, MeshFilter NFLPFJMBMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53E61F0", Offset = "0x53E4BF0", VA = "0x1853E61F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x53E7A20", Offset = "0x53E6420", VA = "0x1853E7A20")]
	public static void LNOKOCDFAME(Vector3 CFEOEOLDJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53E7600", Offset = "0x53E6000", VA = "0x1853E7600")]
	private void KPAJMHIOEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53E8030", Offset = "0x53E6A30", VA = "0x1853E8030")]
	private void OGFIJJLGJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53E6930", Offset = "0x53E5330", VA = "0x1853E6930")]
	private void GFCEPGKMMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53E5B90", Offset = "0x53E4590", VA = "0x1853E5B90")]
	public void BFOCOEBMMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53E7E50", Offset = "0x53E6850", VA = "0x1853E7E50")]
	[AsyncStateMachine(typeof(AJHPDKFEDJD))]
	public Task MOFMCPPAKDD(LCHNHFGOJFL BJJDGLNBFKI, CancellationToken NNCKLKMJCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x53E64B0", Offset = "0x53E4EB0", VA = "0x1853E64B0")]
	[IteratorStateMachine(typeof(ENPMPHHHKDD))]
	private IEnumerator<OMEPBDNLACD> FEEOACOKLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53E6A80", Offset = "0x53E5480", VA = "0x1853E6A80")]
	[AsyncStateMachine(typeof(DMNHOOJFIDD))]
	private Task GOHFDJFMEOI(LCHNHFGOJFL OOIPBGOGJFJ, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x53E7690", Offset = "0x53E6090", VA = "0x1853E7690")]
	public void LBBBICKILCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53E62F0", Offset = "0x53E4CF0", VA = "0x1853E62F0")]
	public void EHEEPMGEBLE(IEnumerable<JHJJKCOPGJK> KPEOMAAGHFN, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53E7BD0", Offset = "0x53E65D0", VA = "0x1853E7BD0")]
	public void MMDNPONHDOK(IEnumerable<JHJJKCOPGJK> KPEOMAAGHFN, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53E6CE0", Offset = "0x53E56E0", VA = "0x1853E6CE0")]
	public List<ClusterMeshRenderer> JIALCMAJAMG(List<ANNJHAHACOM> LMCKNIENCJA, BKOCAKKCKCA JBBMOMLGMKJ, DLJJHEIAHAB MHMBEONMNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x53E75C0", Offset = "0x53E5FC0", VA = "0x1853E75C0")]
	public DLJJHEIAHAB KKMCLACIAIK(Vector3 BKPJODHLAFI)
	{
		return default(DLJJHEIAHAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53E6450", Offset = "0x53E4E50", VA = "0x1853E6450")]
	public void FEAHKALEAEJ(JPBLLJNBKGK HAPBAIJFDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53E7390", Offset = "0x53E5D90", VA = "0x1853E7390")]
	public bool JIOKDBAJLOD(JPBLLJNBKGK HAPBAIJFDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x53E6190", Offset = "0x53E4B90", VA = "0x1853E6190")]
	public void DNNBELNPCJM(ANNJHAHACOM NBLLJCBBKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x53E7B50", Offset = "0x53E6550", VA = "0x1853E7B50")]
	public void MAFNMHEMLMH(KPICLELKMBE JLPGFAAHOGM, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53E6C60", Offset = "0x53E5660", VA = "0x1853E6C60")]
	public void JHAFLFIHNIH(KPICLELKMBE JLPGFAAHOGM, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53E67D0", Offset = "0x53E51D0", VA = "0x1853E67D0")]
	private void GCGNLNKANFJ(Vector3 DEFMLJAJEKI, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53E73F0", Offset = "0x53E5DF0", VA = "0x1853E73F0")]
	private void JMCNCJIDNDN(Vector3 DEFMLJAJEKI, DLJJHEIAHAB MHMBEONMNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53E7550", Offset = "0x53E5F50", VA = "0x1853E7550")]
	[IteratorStateMachine(typeof(ONLLMBGKFPB))]
	private IEnumerator<OMEPBDNLACD> JMKGMLMBNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53E78A0", Offset = "0x53E62A0", VA = "0x1853E78A0")]
	private int LLEEMJDCHKL(int NENMOOINMCH, int MKOBMFJKKCI, List<KPICLELKMBE> GAFJPPEGMLO, byte HGNNAGKFJJB, ref int LBCAOHMEBFM, float FPLPJJGLJDO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53E8250", Offset = "0x53E6C50", VA = "0x1853E8250")]
	public void OMBMHDCIFDM(ANNJHAHACOM PAHLILOLPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53E65C0", Offset = "0x53E4FC0", VA = "0x1853E65C0")]
	public bool FJBIIJOJCGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74B7C0", Offset = "0x74A1C0", VA = "0x18074B7C0")]
	public Material LDCHGCLBBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53E60F0", Offset = "0x53E4AF0", VA = "0x1853E60F0")]
	public int BJPJIBCAFOD()
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct NDNJJLFCHFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> GJBICNEKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> GAKGOOPLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> KBMIAKEDKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> DPBEALDMJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> PDKINGGIKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> BBEAMCNAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> HHCHDMKHIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 IOMIJNOPILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float NFKACFCAHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> CKOHMLEPHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> IMHMEDHMIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x53ECAA0", Offset = "0x53EB4A0", VA = "0x1853ECAA0")]
	public NDNJJLFCHFO(HEIPKPPCIGL LJOHGOPFNGB, NativeList<float3> HHCHDMKHIFK, NativeMultiHashMap<int, int> CKOHMLEPHGL, NativeArray<int> IMHMEDHMIOJ, Vector3 IOMIJNOPILO, float NFKACFCAHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53ECA70", Offset = "0x53EB470", VA = "0x1853ECA70")]
	private int OBGHALEPIAD(float3 DEFMLJAJEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53EC810", Offset = "0x53EB210", VA = "0x1853EC810")]
	private int GOGKELCOFAG(int JEBAMNOFEGN, int KFEMFMGCJPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53EC3E0", Offset = "0x53EADE0", VA = "0x1853EC3E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AHJJEGALHIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> CKOHMLEPHGL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> IMHMEDHMIOJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int EPEPOCOKFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> AKCJDEMLGHE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x53DAA90", Offset = "0x53D9490", VA = "0x1853DAA90")]
	public void ACIBIDFPINP(int HONMPKOIELP, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x53DAC80", Offset = "0x53D9680", VA = "0x1853DAC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public AHJJEGALHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GAECBJLEPFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> KAOEFDMPIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> FFALLFKAHBP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x53E40A0", Offset = "0x53E2AA0", VA = "0x1853E40A0")]
	public GAECBJLEPFB(AHJJEGALHIA CPJIGHNLPIP, HEIPKPPCIGL LJOHGOPFNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x53E4000", Offset = "0x53E2A00", VA = "0x1853E4000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct CKMGBMAFNEL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> BDFKMHPBIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> MKFJFCKFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> MFDDOPIHFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> AKPLJAGGAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> NDIAIHLLKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> AKCJDEMLGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> KAOEFDMPIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> HHJODOPLEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> FBJJACFKAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LCGGINJKABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> CHAFHBAADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> PENFMOPHBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> FCNIMMHGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float KPBBAIIEDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float ALLGDINMJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 DENDMCAONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float CMJHNHBLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float MPKKEBKILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float DDIDJKAFDDK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x53DD900", Offset = "0x53DC300", VA = "0x1853DD900")]
	public CKMGBMAFNEL(AHJJEGALHIA BLBIIBNPMAG, HEIPKPPCIGL LJOHGOPFNGB, HEIPKPPCIGL JGIKCFDAPPL, float MPKKEBKILGB, float DDIDJKAFDDK, Vector3 DENDMCAONEK, float CMJHNHBLIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x53DD790", Offset = "0x53DC190", VA = "0x1853DD790")]
	private float3 ODJPPGOOCBP(int JEBAMNOFEGN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x53DD120", Offset = "0x53DBB20", VA = "0x1853DD120")]
	private void IJDNGOHOGJP(int JEBAMNOFEGN, out float3 EFBGMJACAJC, out float3 MNKJJIMGCGF, out float4 CLGCEICPNMF, out float4 EIALMCAIOAK, out float2 DKMGOCMDCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x53DC350", Offset = "0x53DAD50", VA = "0x1853DC350")]
	private int EBKJGNOAIPK(int KCHMFHNDMON, int MKGOMNIHOMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x53DD310", Offset = "0x53DBD10", VA = "0x1853DD310")]
	private void NLBIKCNEDND(int KCHMFHNDMON, int MKGOMNIHOMK, int JFDPCKCAGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x53DCF90", Offset = "0x53DB990", VA = "0x1853DCF90")]
	private bool HJEHCDLMHNO(int KCHMFHNDMON, int MKGOMNIHOMK, float NEDNEJKCOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x53DD840", Offset = "0x53DC240", VA = "0x1853DD840")]
	private bool OFNJMOADOGE(int KCHMFHNDMON, int MKGOMNIHOMK, int JFDPCKCAGHE, float NEDNEJKCOOI, bool BEFOBPJPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53DD520", Offset = "0x53DBF20", VA = "0x1853DD520")]
	private bool NPDIEMGPBGJ(int KCHMFHNDMON, int MKGOMNIHOMK, int JFDPCKCAGHE, float NEDNEJKCOOI, bool BEFOBPJPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53DCF70", Offset = "0x53DB970", VA = "0x1853DCF70")]
	private void FGIIBDKHJED(int KCHMFHNDMON, int MKGOMNIHOMK, int JFDPCKCAGHE, out int NBPOEPINOEH, out int MACPNKCJANI, out int OOCJCNLBDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53DC650", Offset = "0x53DB050", VA = "0x1853DC650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GBEKAECFIEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AILMHBCPECG : IDisposable, KPICLELKMBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds DKDHAMFEDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<ANNJHAHACOM> LMCKNIENCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 BJFOKKDLFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 BDLELIAHKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int DNKKCLFECHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HEIPKPPCIGL FMFJJDEGIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AHJJEGALHIA LAMFOPIKPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform JBBMOMLGMKJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int EPNBNHBPAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x53DB3E0", Offset = "0x53D9DE0", VA = "0x1853DB3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh MGDCEJDCGAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CNKNFHBOHJB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8588D0", Offset = "0x8572D0", VA = "0x1808588D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MMGPEKNIPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABBDB0", Offset = "0xABA7B0", VA = "0x180ABBDB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x247FF20", Offset = "0x247E920", VA = "0x18247FF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte OAFAMDDBHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F80", Offset = "0x6E1980", VA = "0x1806E2F80")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xC72690", Offset = "0xC71090", VA = "0x180C72690", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int AMOAIOLBDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA1B390", Offset = "0xA19D90", VA = "0x180A1B390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3A0", Offset = "0xA19DA0", VA = "0x180A1B3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int CBHLINEHCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x99B470", Offset = "0x999E70", VA = "0x18099B470", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1584440", Offset = "0x1582E40", VA = "0x181584440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DHLDEEEEGKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x53DB420", Offset = "0x53D9E20", VA = "0x1853DB420", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53DB1B0", Offset = "0x53D9BB0", VA = "0x1853DB1B0")]
		public void KMDLNHPLECJ(ELDADGLNPNI HGNNAGKFJJB, out int HHMBNMHFBDG, out int IMLKDBLMHBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x53DAD60", Offset = "0x53D9760", VA = "0x1853DAD60")]
		public void DMANKFKOBDE(ELDADGLNPNI HGNNAGKFJJB, MBCMOPENIMM NNCEECFDAPH, int BLAFPBEKIKE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x53DB4E0", Offset = "0x53D9EE0", VA = "0x1853DB4E0")]
		public void PMDOEBPMKMI(NativeList<AEBNNJHBPKD> DLIOICHJNPC, Transform LMNCNCMINKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53DB110", Offset = "0x53D9B10", VA = "0x1853DB110")]
		public void HGKCGAJLFAP(Mesh LJOHGOPFNGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53DB440", Offset = "0x53D9E40", VA = "0x1853DB440")]
		public void NKNMLKFKDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53DAF10", Offset = "0x53D9910", VA = "0x1853DAF10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53DB880", Offset = "0x53DA280", VA = "0x1853DB880")]
		public AILMHBCPECG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds DKDHAMFEDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<AILMHBCPECG> FEHLPDMJOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public DGEKIDMBFMM CINBFHCHBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer IBIJJOHHONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int KOMCFBBEAKI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh KHJELOJGAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81F1C0", Offset = "0x81DBC0", VA = "0x18081F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KNPKOOOPPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69FF10", Offset = "0x69E910", VA = "0x18069FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GENJENJDPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x53E51D0", Offset = "0x53E3BD0", VA = "0x1853E51D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53E4290", Offset = "0x53E2C90", VA = "0x1853E4290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53E5220", Offset = "0x53E3C20", VA = "0x1853E5220")]
	public int MBDMMEOHFML(int HOBNKBLEIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53E40D0", Offset = "0x53E2AD0", VA = "0x1853E40D0")]
	public void CGBMHBICEAB(HABEOGJEMPB JJAMMMEBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x53E43F0", Offset = "0x53E2DF0", VA = "0x1853E43F0")]
	public void EFEAFLDGKHA(Transform LMNCNCMINKD, bool NACAPFMHDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x53E5010", Offset = "0x53E3A10", VA = "0x1853E5010")]
	public bool IMLFJDOJBJE(bool EKELFEJEAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x53E4BC0", Offset = "0x53E35C0", VA = "0x1853E4BC0")]
	public void GNPJGAGFBLI(Transform JBBMOMLGMKJ, bool NACAPFMHDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x53E5250", Offset = "0x53E3C50", VA = "0x1853E5250")]
	public bool OMBMHDCIFDM(ANNJHAHACOM PAHLILOLPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x53E5500", Offset = "0x53E3F00", VA = "0x1853E5500")]
	public GBEKAECFIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FLMGFKOFJEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<GBEKAECFIEG.AILMHBCPECG> PNGKHBMHIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EDJMHKGOMAA PKGOJIPMAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<GBEKAECFIEG.AILMHBCPECG> JHPHCLMBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CKMCLJDBAFE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53E2FC0", Offset = "0x53E19C0", VA = "0x1853E2FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53E31C0", Offset = "0x53E1BC0", VA = "0x1853E31C0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53E3240", Offset = "0x53E1C40", VA = "0x1853E3240")]
	public void MJIKPLNABDE(GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL, Transform JBBMOMLGMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53E3300", Offset = "0x53E1D00", VA = "0x1853E3300")]
	public void OMBMHDCIFDM(GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53E3030", Offset = "0x53E1A30", VA = "0x1853E3030")]
	private GBEKAECFIEG.AILMHBCPECG GMLEFKLLBML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x53E3780", Offset = "0x53E2180", VA = "0x1853E3780")]
	private bool PCHHEIOKJBM(GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53E3160", Offset = "0x53E1B60", VA = "0x1853E3160")]
	private void IHOGFCBCIGF(GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53E2F90", Offset = "0x53E1990", VA = "0x1853E2F90")]
	public bool BPLGNKEKMDE(GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53E34F0", Offset = "0x53E1EF0", VA = "0x1853E34F0")]
	public bool OPDLCGHKCDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53E2F30", Offset = "0x53E1930", VA = "0x1853E2F30")]
	private GBEKAECFIEG.AILMHBCPECG AGIHCDMLCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53E3820", Offset = "0x53E2220", VA = "0x1853E3820")]
	public FLMGFKOFJEN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FPAJAOBFNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int OJCFFFCPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int PEOGPJMMPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float DJEMLCLHGKG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<GBEKAECFIEG> HCDAMMNLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53E3FB0", Offset = "0x53E29B0", VA = "0x1853E3FB0")]
	public FPAJAOBFNFK(int OJCFFFCPGJM, int PEOGPJMMPHD, float MPEPONBKFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53E3C50", Offset = "0x53E2650", VA = "0x1853E3C50")]
	public void HAFBBOKLFKP(JNBPKEBMDCG IJDDGFILILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53E39A0", Offset = "0x53E23A0", VA = "0x1853E39A0")]
	private int EOKOICBDGEH(HABEOGJEMPB CPEGANFPGPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53E3D70", Offset = "0x53E2770", VA = "0x1853E3D70")]
	private void HAFBBOKLFKP(HABEOGJEMPB CPEGANFPGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53E3A40", Offset = "0x53E2440", VA = "0x1853E3A40")]
	private void GHODJFHNHBO(HABEOGJEMPB CPEGANFPGPI, GBEKAECFIEG NGANLEAEMOC)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, JHJJKCOPGJK
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MHGDJGPJNEB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public MHGDJGPJNEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x53EC1F0", Offset = "0x53EABF0", VA = "0x1853EC1F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x53EC3A0", Offset = "0x53EADA0", VA = "0x1853EC3A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x53EC300", Offset = "0x53EAD00", VA = "0x1853EC300", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x53EC300", Offset = "0x53EAD00", VA = "0x1853EC300", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GENJENJDPNA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x53DF080", Offset = "0x53DDA80", VA = "0x1853DF080", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<KPICLELKMBE> FMAFGMBPEBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x53DF060", Offset = "0x53DDA60", VA = "0x1853DF060", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> FEHLPDMJOGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GBEKAECFIEG KHJELOJGAHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public DLJJHEIAHAB JIICLFALONL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6E1520", Offset = "0x6DFF20", VA = "0x1806E1520", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(DLJJHEIAHAB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB81BC0", Offset = "0xB805C0", VA = "0x180B81BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BLCNPDOGBOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x53DF070", Offset = "0x53DDA70", VA = "0x1853DF070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53DDC40", Offset = "0x53DC640", VA = "0x1853DDC40")]
		public static ClusterMeshRenderer Create(GBEKAECFIEG LJOHGOPFNGB, ClusterMeshRenderer ICIBPGOOGEC, MeshFilter NFLPFJMBMJG, BKOCAKKCKCA JBBMOMLGMKJ, DLJJHEIAHAB MHMBEONMNLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x53DDDE0", Offset = "0x53DC7E0", VA = "0x1853DDDE0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x53DE5A0", Offset = "0x53DCFA0", VA = "0x1853DE5A0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(ANNJHAHACOM PAHLILOLPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x53DE390", Offset = "0x53DCD90", VA = "0x1853DE390")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53DE030", Offset = "0x53DCA30", VA = "0x1853DE030")]
		public void Init(GBEKAECFIEG LJOHGOPFNGB, MeshFilter NFLPFJMBMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53DDE40", Offset = "0x53DC840", VA = "0x1853DDE40")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53DE6D0", Offset = "0x53DD0D0", VA = "0x1853DE6D0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 DEFMLJAJEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x53DE8E0", Offset = "0x53DD2E0", VA = "0x1853DE8E0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53DDFC0", Offset = "0x53DC9C0", VA = "0x1853DDFC0")]
		[IteratorStateMachine(typeof(MHGDJGPJNEB))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53DE410", Offset = "0x53DCE10", VA = "0x1853DE410")]
		public void SetupTagAndLayer(string AGLFMMDCNDH, int MHMBEONMNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53DE3F0", Offset = "0x53DCDF0", VA = "0x1853DE3F0")]
		public bool Remove(ANNJHAHACOM PAHLILOLPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BOKLEJGPABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int LLJNMAKDMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int DAKLCPMDBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IMLKDBLMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HHMBNMHFBDG;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x53DC2A0", Offset = "0x53DACA0", VA = "0x1853DC2A0")]
	public BOKLEJGPABI(int DAKLCPMDBMG, int IMLKDBLMHBF, int LLJNMAKDMLJ, int HHMBNMHFBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DGEKIDMBFMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> GJBICNEKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> AKCJDEMLGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> BBEAMCNAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<BOKLEJGPABI> GCLPPECGGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> NNGCNDLJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> MFPIKJCCGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> MOLFCACGLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle MDLEMMPHNCE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LGLKKPLHDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x90AB00", Offset = "0x909500", VA = "0x18090AB00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E88B0", Offset = "0x6E72B0", VA = "0x1806E88B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x53DF3D0", Offset = "0x53DDDD0", VA = "0x1853DF3D0")]
	public void LCHEDBCCHIE(HEIPKPPCIGL EHGKGHLALBE, NativeList<BOKLEJGPABI> GCLPPECGGNL, float MMFEMDOMCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x53E02F0", Offset = "0x53DECF0", VA = "0x1853E02F0")]
	public void LIEFJDFHJAM(Transform JBBMOMLGMKJ, bool NACAPFMHDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53DF1F0", Offset = "0x53DDBF0", VA = "0x1853DF1F0")]
	public void IMLFJDOJBJE(GBEKAECFIEG IBIJJOHHONN, bool EKELFEJEAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53DF0E0", Offset = "0x53DDAE0", VA = "0x1853DF0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53DF3A0", Offset = "0x53DDDA0", VA = "0x1853DF3A0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public DGEKIDMBFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GPOLBNBFEJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> GJBICNEKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> AKCJDEMLGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<BOKLEJGPABI> OCGJHEEFMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> NNGCNDLJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 DENDMCAONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> MFPIKJCCGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> MOLFCACGLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool NACAPFMHDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float FNNOFKIEIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float NGMKIJBHGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float GDFLCPOACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> BBEAMCNAAON;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x53E5A40", Offset = "0x53E4440", VA = "0x1853E5A40")]
	public GPOLBNBFEJG(DGEKIDMBFMM EBLJDNAFJJC, Vector3 DENDMCAONEK, bool NACAPFMHDFF, float FNNOFKIEIHO, float NGMKIJBHGPF, float GDFLCPOACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x53E55B0", Offset = "0x53E3FB0", VA = "0x1853E55B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ANNJHAHACOM : EPCJPPBNGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds DEGLIGPGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AEBNNJHBPKD GOFMIHOIIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HABEOGJEMPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<ANNJHAHACOM> LMCKNIENCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public HABEOGJEMPB EGNCPOLPGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public HABEOGJEMPB CNHHHMILLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public HABEOGJEMPB AICOHEADCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HHMBNMHFBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds DKDHAMFEDAG;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53E5B10", Offset = "0x53E4510", VA = "0x1853E5B10")]
	public HABEOGJEMPB(List<ANNJHAHACOM> LMCKNIENCJA, [Optional] HABEOGJEMPB EGNCPOLPGCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JNBPKEBMDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<HABEOGJEMPB> FPHLFLHGHHD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HABEOGJEMPB OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53E8BF0", Offset = "0x53E75F0", VA = "0x1853E8BF0")]
	public JNBPKEBMDCG(HABEOGJEMPB JBBMOMLGMKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LJALMMCGAFK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PLPPPOCCDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int DMDHBFOEGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int PMNADPOBLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int BDBFCCEADAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int OLKFLFIBPPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct NGLAAPMPNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int NPPAEOEMOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float EKMEJPINEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<ANNJHAHACOM> LMCKNIENCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum EOGPBDDEFEA
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
	private PLPPPOCCDDB GBIOLPOPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int OPJMLFDDFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int OJCFFFCPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int PEOGPJMMPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float MPEPONBKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float KJKMFDAFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<HABEOGJEMPB> PCGFGHOHBNE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JNBPKEBMDCG NCPLEJCCENN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x53EC130", Offset = "0x53EAB30", VA = "0x1853EC130")]
	public LJALMMCGAFK(int OJCFFFCPGJM, int PEOGPJMMPHD, float MPEPONBKFBK, int OPJMLFDDFPK, float KJKMFDAFPJG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x53EAEA0", Offset = "0x53E98A0", VA = "0x1853EAEA0")]
	public void JONNIEOCCOP(List<ANNJHAHACOM> LMCKNIENCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x53EA4D0", Offset = "0x53E8ED0", VA = "0x1853EA4D0")]
	public bool EHHLOCPBBJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x53EA540", Offset = "0x53E8F40", VA = "0x1853EA540")]
	private float GBOMDLCMDOP(Vector3 IGJJHEFOMKI, Vector3 FMFHKMBBDJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x53EA5C0", Offset = "0x53E8FC0", VA = "0x1853EA5C0")]
	private float GBOMDLCMDOP(Vector3 GCDOPBGGNDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x53EA610", Offset = "0x53E9010", VA = "0x1853EA610")]
	private bool HAODCCFOEON(HABEOGJEMPB FBPIFIOAKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x53EB0A0", Offset = "0x53E9AA0", VA = "0x1853EB0A0")]
	private NGLAAPMPNHL KOMDFCHCPMN(List<ANNJHAHACOM> IJLEFPPNKJA, EOGPBDDEFEA DACDCLMGBNJ)
	{
		return default(NGLAAPMPNHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x53EBCD0", Offset = "0x53EA6D0", VA = "0x1853EBCD0")]
	private void PLHMDMCBGAB(List<ANNJHAHACOM> LMCKNIENCJA, Vector3[] NAJEFKHONKD, Vector3[] KNLAJBIIOEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class APFOFJCMDJD
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53DC0F0", Offset = "0x53DAAF0", VA = "0x1853DC0F0")]
	public static Bounds CLBPJJJHFDG(List<ANNJHAHACOM> LMCKNIENCJA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53DBF40", Offset = "0x53DA940", VA = "0x1853DBF40")]
	public static int CFCOMADFHOB(List<ANNJHAHACOM> LMCKNIENCJA, ELDADGLNPNI HGNNAGKFJJB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EDJMHKGOMAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HEIPKPPCIGL NDBCLPHJPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HEIPKPPCIGL OGLCNNGDCLP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static HEIPKPPCIGL DPAPOONMAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LFMNPMLBPNI CNMJLHBELAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MBCMOPENIMM NNCEECFDAPH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle MDLEMMPHNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xBFF390", Offset = "0xBFDD90", VA = "0x180BFF390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GBEKAECFIEG.AILMHBCPECG FBPIFIOAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ECKPEENBIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E6270", Offset = "0x6E4C70", VA = "0x1806E6270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53E19A0", Offset = "0x53E03A0", VA = "0x1853E19A0")]
	[DDIKHCMIJDB(CAOPMCLNOKH.ExitingPlayMode, 0)]
	private void DFGCEOKOLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53E1AC0", Offset = "0x53E04C0", VA = "0x1853E1AC0")]
	public void LCHEDBCCHIE(GBEKAECFIEG.AILMHBCPECG OCGJHEEFMPE, Transform OAINEHDIEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x53E25C0", Offset = "0x53E0FC0", VA = "0x1853E25C0")]
	public void PMDPJDFBECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x53E1A10", Offset = "0x53E0410", VA = "0x1853E1A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x53E1A80", Offset = "0x53E0480", VA = "0x1853E1A80")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53E2CB0", Offset = "0x53E16B0", VA = "0x1853E2CB0")]
	public EDJMHKGOMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NBPCDMNEMAO
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IKJECKMEANK HNJCFFLENDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GFIBFDAADIE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 ELBDNJCJDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LAHHPLFLGCB
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(LCHNHFGOJFL OOIPBGOGJFJ, CancellationToken OGOJJPCADFI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KLJLCOJBAJF
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLJLCOJBAJF BEILIBNBJJK(Action LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLJLCOJBAJF JGMOOOBACNF(Action LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KLJLCOJBAJF JACPKLOOKOE(Action LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KLJLCOJBAJF DIPOMOLCFEA(Action LBPAPOGAAHD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class KAMIONGNEJH : KLJLCOJBAJF
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class EPCLHBIKCGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public KAMIONGNEJH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
				public EPCLHBIKCGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x53E2E50", Offset = "0x53E1850", VA = "0x1853E2E50")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x53E2EA0", Offset = "0x53E18A0", VA = "0x1853E2EA0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x53E2EF0", Offset = "0x53E18F0", VA = "0x1853E2EF0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> AHCPKOHGCMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action OFLMCANFLMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action MBBANHFOFDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private FJBGGOHJIHF JJBKOOFFCPH;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action NMGBIFCPLKA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x81F1C0", Offset = "0x81DBC0", VA = "0x18081F1C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action KIMGHMEBJKN
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2523280", Offset = "0x2521C80", VA = "0x182523280", Slot = "4")]
			public KLJLCOJBAJF BEILIBNBJJK(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E4BCB0", Offset = "0x1E4A6B0", VA = "0x181E4BCB0", Slot = "5")]
			public KLJLCOJBAJF JGMOOOBACNF(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1EBCEC0", Offset = "0x1EBB8C0", VA = "0x181EBCEC0", Slot = "6")]
			public KLJLCOJBAJF JACPKLOOKOE(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x25232C0", Offset = "0x2521CC0", VA = "0x1825232C0", Slot = "7")]
			public KLJLCOJBAJF DIPOMOLCFEA(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
			public KAMIONGNEJH(Func<JobHandle> OFFOEFAJOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x53E9AA0", Offset = "0x53E84A0", VA = "0x1853E9AA0")]
			public void EFIAGIGKKIM(Action FEIPFMLCKJN, Action AHMNLALNNJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x53E9D30", Offset = "0x53E8730", VA = "0x1853E9D30")]
			public void OMBMHDCIFDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CMAJECFCHKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public KLJLCOJBAJF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public CMAJECFCHKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x53DDA40", Offset = "0x53DC440", VA = "0x1853DDA40")]
			internal bool <Remove>b__0(KAMIONGNEJH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class COJDFIAINEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public KAMIONGNEJH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public COJDFIAINEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x53DDA50", Offset = "0x53DC450", VA = "0x1853DDA50")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<KAMIONGNEJH> EHKKHJLJMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<KAMIONGNEJH> MPGKANHIIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GJINICPNEFL BCFIJECFAHC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FMHCENAKJBC AGDNICMIDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7939F0", Offset = "0x7923F0", VA = "0x1807939F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x53E8CC0", Offset = "0x53E76C0", VA = "0x1853E8CC0")]
		public KLJLCOJBAJF Add(Func<JobHandle> OFFOEFAJOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x53E8FC0", Offset = "0x53E79C0", VA = "0x1853E8FC0")]
		public void Remove(KLJLCOJBAJF MDLEMMPHNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x53E8E20", Offset = "0x53E7820", VA = "0x1853E8E20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x53E9190", Offset = "0x53E7B90", VA = "0x1853E9190")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53E93E0", Offset = "0x53E7DE0", VA = "0x1853E93E0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53E8E10", Offset = "0x53E7810", VA = "0x1853E8E10")]
		[CompilerGenerated]
		private void BKPKPOJPEOL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FJBGGOHJIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJBGGOHJIHF BEILIBNBJJK(Action LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJBGGOHJIHF MNMCGLNHCHK(Action LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJBGGOHJIHF DIPOMOLCFEA(Action LBPAPOGAAHD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class CIDEIPAGMOL : FJBGGOHJIHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle CONBLOOFGBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action OFLMCANFLMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action NKCKENOCBCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action KIMGHMEBJKN;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool DGLBIIJHPBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x53DC2C0", Offset = "0x53DACC0", VA = "0x1853DC2C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1E4BCB0", Offset = "0x1E4A6B0", VA = "0x181E4BCB0", Slot = "4")]
			public FJBGGOHJIHF BEILIBNBJJK(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1EBCEC0", Offset = "0x1EBB8C0", VA = "0x181EBCEC0", Slot = "5")]
			public FJBGGOHJIHF MNMCGLNHCHK(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x25232C0", Offset = "0x2521CC0", VA = "0x1825232C0", Slot = "6")]
			public FJBGGOHJIHF DIPOMOLCFEA(Action LBPAPOGAAHD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
			public CIDEIPAGMOL(JobHandle LJCGOBJJHCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x53DC2D0", Offset = "0x53DACD0", VA = "0x1853DC2D0")]
			public void MHGOHAICKEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x53DC310", Offset = "0x53DAD10", VA = "0x1853DC310")]
			public void OMBMHDCIFDM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<CIDEIPAGMOL> CBBJAKPOIEH;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53E98C0", Offset = "0x53E82C0", VA = "0x1853E98C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53E94E0", Offset = "0x53E7EE0", VA = "0x1853E94E0")]
		public FJBGGOHJIHF Add(JobHandle LJCGOBJJHCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53E97D0", Offset = "0x53E81D0", VA = "0x1853E97D0")]
		public void Remove(FJBGGOHJIHF MDLEMMPHNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x53E9660", Offset = "0x53E8060", VA = "0x1853E9660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x53E9570", Offset = "0x53E7F70", VA = "0x1853E9570")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53E99E0", Offset = "0x53E83E0", VA = "0x1853E99E0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53E9EA0", Offset = "0x53E88A0", VA = "0x1853E9EA0")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x53E9FB0", Offset = "0x53E89B0", VA = "0x1853E9FB0")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
