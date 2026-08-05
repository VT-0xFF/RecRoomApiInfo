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
				[Cpp2IlInjected.Address(RVA = "0x8405C40", Offset = "0x8404240", VA = "0x188405C40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF3F9E0", Offset = "0xF3DFE0", VA = "0x180F3F9E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8405C00", Offset = "0x8404200", VA = "0x188405C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x83FA130", Offset = "0x83F8730", VA = "0x1883FA130")]
		public LODSettings JJIGEHNLNOB(PEADBPGCBOF OCNFNIGMAEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83FA110", Offset = "0x83F8710", VA = "0x1883FA110")]
		public int BDENLCOIGHP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83FA140", Offset = "0x83F8740", VA = "0x1883FA140")]
		public int MGPCJIJNCPE(bool PPBALDIPCIC, Vector3 EMFJHLPLJGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83FA1E0", Offset = "0x83F87E0", VA = "0x1883FA1E0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MHBNBFPBHLH
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
public interface PNBHLCAGLCB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIGKCKAEPKF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HPLDGKJGOLB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HOCNDCPNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JAJIKLMOMOC> MMFHHFODEKJ
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
	void UpdateClusterDistances(Vector3 ALFMKPLFANJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(IAKBODPFBIM IDFKPPKNONO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JAJIKLMOMOC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int IICIEJAAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NGNMALHLIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float LCEHPEFNBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ELHONMKEDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte EOLCKLIAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ADLPDAFFLBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum MJILMNAEOJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DHIAHJGKBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ADLPDAFFLBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LLMBEMAOGHJ<string>.LBCCFMIMELL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private LLMBEMAOGHJ<string>.LBCCFMIMELL <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83FBD00", Offset = "0x83FA300", VA = "0x1883FBD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83FC490", Offset = "0x83FAA90", VA = "0x1883FC490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FJHGEFIGHIF : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ADLPDAFFLBD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public FJHGEFIGHIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83FCDD0", Offset = "0x83FB3D0", VA = "0x1883FCDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83FD050", Offset = "0x83FB650", VA = "0x1883FD050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LHNHPCBCKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public ADLPDAFFLBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LLMBEMAOGHJ<string>.LBCCFMIMELL worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LLMBEMAOGHJ<string>.LBCCFMIMELL <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8404280", Offset = "0x8402880", VA = "0x188404280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8405BA0", Offset = "0x84041A0", VA = "0x188405BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AABPMBMCBLA : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ADLPDAFFLBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public AABPMBMCBLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83F19E0", Offset = "0x83EFFE0", VA = "0x1883F19E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83F2700", Offset = "0x83F0D00", VA = "0x1883F2700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int NLACPHEAGDD = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan GLFKNBECFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer LDMDNHCFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter FDFCNEHHDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject NOEAIHEFDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject KGHHNKBEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IDCKGCMCLMG IBKEJCHKLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IAKBODPFBIM> EKCCBHMGODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IAKBODPFBIM> HGHCPKPAJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<IAKBODPFBIM> DOBBPKNHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CCBAOHNMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double KDPHCPECJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long BONKPGFACGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private long JEEMFCHJHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long MGDIELEJAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long NMJNADIJKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MJILMNAEOJC HPOKKDAPFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<HPLDGKJGOLB>[] KADMAINBHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<JAJIKLMOMOC>[] ABEPPDBJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CancellationTokenSource DFHJMPKGNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool OPDMDHGHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FAKIPBKLGEB HCKEAMPMPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private FAKIPBKLGEB CBJGEJOMMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int DLCMIKMAJKK;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static ADLPDAFFLBD BICCGKMJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HIMFGJJFHOG MGOCNBDBBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NJPLFELLPOM CJJJNMEGNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MonoBehaviour PEOLIPHDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material KGPHALPLNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private List<Material> NPKAPHKGKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Material DMPFGEPONJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<Material> FEFJLFJCBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool LOJALDDADJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly List<PNBHLCAGLCB> GMAFNLFHACF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MPGPNKPCHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 PEPHEILOIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x817FC30", Offset = "0x817E230", VA = "0x18817FC30")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x817F910", Offset = "0x817DF10", VA = "0x18817F910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MJILMNAEOJC NMAKPPFGFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3019BD0", Offset = "0x30181D0", VA = "0x183019BD0")]
		get
		{
			return default(MJILMNAEOJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83F5640", Offset = "0x83F3C40", VA = "0x1883F5640")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ADLPDAFFLBD EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83F4080", Offset = "0x83F2680", VA = "0x1883F4080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool DAIBONKBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83F3ED0", Offset = "0x83F24D0", VA = "0x1883F3ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JNEHBIKBMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83F5780", Offset = "0x83F3D80", VA = "0x1883F5780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OBCNKFGAEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83F5960", Offset = "0x83F3F60", VA = "0x1883F5960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83F30B0", Offset = "0x83F16B0", VA = "0x1883F30B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HPKGDJPJNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83F3FD0", Offset = "0x83F25D0", VA = "0x1883F3FD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83F42A0", Offset = "0x83F28A0", VA = "0x1883F42A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83F5D60", Offset = "0x83F4360", VA = "0x1883F5D60")]
	public ADLPDAFFLBD(HIMFGJJFHOG MGOCNBDBBNN, NJPLFELLPOM CJJJNMEGNFI, ClusterLODConfig FLACNKGBCNO, MonoBehaviour PEOLIPHDGDC, Material NKLBECOCBNC, ClusterMeshRenderer LDMDNHCFDLO, MeshFilter FDFCNEHHDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83F4A50", Offset = "0x83F3050", VA = "0x1883F4A50")]
	private void JHLMDNPEJAC(Material NKLBECOCBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83F4BC0", Offset = "0x83F31C0", VA = "0x1883F4BC0")]
	public void JLAOJGICPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83F4DA0", Offset = "0x83F33A0", VA = "0x1883F4DA0")]
	public void KGLNJMAIHHC(Action<Material> JFHDLAFFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83F3090", Offset = "0x83F1690", VA = "0x1883F3090")]
	public static GKMCCFCPGAH.DJLMDIAEFCE AFFIFBGBKJM(GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK)
	{
		return default(GKMCCFCPGAH.DJLMDIAEFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83F39B0", Offset = "0x83F1FB0", VA = "0x1883F39B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83F5BF0", Offset = "0x83F41F0", VA = "0x1883F5BF0")]
	public static void PHJPDHOAFHG(Vector3 BHJEGMBJMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83F5A60", Offset = "0x83F4060", VA = "0x1883F5A60")]
	private void NPJLNFKBCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83F3170", Offset = "0x83F1770", VA = "0x1883F3170")]
	private void AMGNKHINNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83F3280", Offset = "0x83F1880", VA = "0x1883F3280")]
	private void BNEGBGEFGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83F28B0", Offset = "0x83F0EB0", VA = "0x1883F28B0")]
	public void ADKMINAOKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83F5840", Offset = "0x83F3E40", VA = "0x1883F5840")]
	[AsyncStateMachine(typeof(DHIAHJGKBCI))]
	public Task MJNBHIKGBFI(LLMBEMAOGHJ<string>.LBCCFMIMELL CKHNMAPCDOP, CancellationToken FMFKCOIOLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83F5AF0", Offset = "0x83F40F0", VA = "0x1883F5AF0")]
	[IteratorStateMachine(typeof(FJHGEFIGHIF))]
	private IEnumerator<KAIBAKBEOHB> OKPAJBGJDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83F3590", Offset = "0x83F1B90", VA = "0x1883F3590")]
	[AsyncStateMachine(typeof(LHNHPCBCKIL))]
	private Task CMAADMGAJDB(LLMBEMAOGHJ<string>.LBCCFMIMELL GIGFHIDOHFF, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83F47B0", Offset = "0x83F2DB0", VA = "0x1883F47B0")]
	public void IJJGMPHNKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83F4C60", Offset = "0x83F3260", VA = "0x1883F4C60")]
	public void JNEALLCIGLE(IEnumerable<HPLDGKJGOLB> NNFKPPKFOEE, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83F36B0", Offset = "0x83F1CB0", VA = "0x1883F36B0")]
	public void DOLBGHFMOLI(IEnumerable<HPLDGKJGOLB> NNFKPPKFOEE, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83F4F60", Offset = "0x83F3560", VA = "0x1883F4F60")]
	public List<ClusterMeshRenderer> LJJDHAOIAFG(List<IAKBODPFBIM> HNFLDAHJIFG, ACLDACCHLEI BOCNDANOLJJ, MHBNBFPBHLH MBOGBFPKKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83F40D0", Offset = "0x83F26D0", VA = "0x1883F40D0")]
	public void GKJJFECLLNF(PNBHLCAGLCB EAOIDCODLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83F4CE0", Offset = "0x83F32E0", VA = "0x1883F4CE0")]
	public bool KCBIODPEOOG(PNBHLCAGLCB EAOIDCODLGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83F4D40", Offset = "0x83F3340", VA = "0x1883F4D40")]
	public void KEONKNJCLDD(IAKBODPFBIM ECEHDCIFOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83F4350", Offset = "0x83F2950", VA = "0x1883F4350")]
	public void IEKPKDMEGDC(JAJIKLMOMOC PCLIBIJEFPO, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83F5B70", Offset = "0x83F4170", VA = "0x1883F5B70")]
	public void PCLGDJGJLFJ(JAJIKLMOMOC PCLIBIJEFPO, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83F3D80", Offset = "0x83F2380", VA = "0x1883F3D80")]
	private void FAGOIKEGKPB(Vector3 ALFMKPLFANJ, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83F2F20", Offset = "0x83F1520", VA = "0x1883F2F20")]
	private void AFCDCKBNMLL(Vector3 ALFMKPLFANJ, MHBNBFPBHLH MBOGBFPKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83F2830", Offset = "0x83F0E30", VA = "0x1883F2830")]
	[IteratorStateMachine(typeof(AABPMBMCBLA))]
	private IEnumerator<KAIBAKBEOHB> ADGCFDFDBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83F4130", Offset = "0x83F2730", VA = "0x1883F4130")]
	private int HDIBKEHCPGD(int PMIGBJGNLLP, int PGKFBBFBKMF, List<JAJIKLMOMOC> FHFGJKPDIAP, byte OCNFNIGMAEF, int HAOLFGKHNMM, float NGBINDKKEBJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83F33D0", Offset = "0x83F19D0", VA = "0x1883F33D0")]
	public void CBELOMAGFLH(IAKBODPFBIM IDFKPPKNONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83F5A20", Offset = "0x83F4020", VA = "0x1883F5A20")]
	public bool NFELDKHGGGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB34C40", Offset = "0xB33240", VA = "0x180B34C40")]
	public Material KNNDAKEPMHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83F4ED0", Offset = "0x83F34D0", VA = "0x1883F4ED0")]
	public Material KNNDAKEPMHA(GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB363D0", Offset = "0xB349D0", VA = "0x180B363D0")]
	public Material IPLAACMFMDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83F49C0", Offset = "0x83F2FC0", VA = "0x1883F49C0")]
	public Material IPLAACMFMDJ(GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83F3240", Offset = "0x83F1840", VA = "0x1883F3240")]
	public int BDENLCOIGHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83F43D0", Offset = "0x83F29D0", VA = "0x1883F43D0")]
	public (long, int) IHPNDJGNOCI()
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
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct FNEPIFNDPGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<float3> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float3> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<float4> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<float2> KHDHFKNOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<float4> HLFENNFMLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<int> OBIBBENNFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeList<float3> GFCODDFHCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private float3 NIBJNDOIMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private float OCIPENLABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeParallelMultiHashMap<int, int> IBHMOPCCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> HCOFIEIGDML;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83FDCD0", Offset = "0x83FC2D0", VA = "0x1883FDCD0")]
	public FNEPIFNDPGK(GKMCCFCPGAH KNHPHEPPGOL, NativeList<float3> GFCODDFHCID, NativeParallelMultiHashMap<int, int> IBHMOPCCGPM, NativeArray<int> HCOFIEIGDML, Vector3 NIBJNDOIMKG, float OCIPENLABEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83FDA00", Offset = "0x83FC000", VA = "0x1883FDA00")]
	private int FGFMLKHOEMD(float3 ALFMKPLFANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83FDA60", Offset = "0x83FC060", VA = "0x1883FDA60")]
	private int HLFEEBFMEJK(int ENCGNPAFEED, int HAELBKGFDIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83FD5D0", Offset = "0x83FBBD0", VA = "0x1883FD5D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JCHDAABNPJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static NativeParallelMultiHashMap<int, int> IBHMOPCCGPM;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static NativeArray<int> HCOFIEIGDML;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int BCEJCBDEINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeList<int> CGILCPAIILC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8401B60", Offset = "0x8400160", VA = "0x188401B60")]
	public void KEBIFLKGLKF(int PAHLOFNIDEF, Allocator EEDCBHBBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8401A80", Offset = "0x8400080", VA = "0x188401A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JCHDAABNPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct INKNMNNHKAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	public NativeList<int> PNALODEIKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<int> NBMHGKCCHHB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8401A50", Offset = "0x8400050", VA = "0x188401A50")]
	public INKNMNNHKAF(JCHDAABNPJE PCJLEEFGEBB, GKMCCFCPGAH KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84019A0", Offset = "0x83FFFA0", VA = "0x1884019A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HIJJANJAMNP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeList<float3> BAAFMIKAAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float3> NFLGDOPNNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private NativeArray<float4> OLDBECCMFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private NativeArray<float2> GCLJDJHBBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private NativeArray<float4> KHMICDECFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<int> CGILCPAIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<int> PNALODEIKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<float3> MLLHGLGDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float3> NIFKBBHLIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeArray<float4> OOGCEBOPPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<float4> HONKHHBCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float2> BFCIMLPOAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeList<int> BAOODHICLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float MIGLNGLAKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	public float OCJMJJGBNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private float3 IAJPGBLEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private float DPBIMCECJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private float MDGNIEMPGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	public float AHKHODDOFPB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83FF530", Offset = "0x83FDB30", VA = "0x1883FF530")]
	public HIJJANJAMNP(JCHDAABNPJE NCBNBHMHADD, GKMCCFCPGAH KNHPHEPPGOL, GKMCCFCPGAH OKFKCGAJIKI, float MDGNIEMPGLL, float AHKHODDOFPB, Vector3 IAJPGBLEAMI, float DPBIMCECJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83FF270", Offset = "0x83FD870", VA = "0x1883FF270")]
	private float3 IMOOKJIPDLN(int ENCGNPAFEED)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83FDFB0", Offset = "0x83FC5B0", VA = "0x1883FDFB0")]
	private void AFBICCJPOJO(int ENCGNPAFEED, [Out] float3 CJECDADIJJA, [Out] float3 MJHGPIAJLPG, [Out] float4 FOIHMCAHLGK, [Out] float4 MFAPKANAIBG, [Out] float2 KCACGGKBCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83FEF90", Offset = "0x83FD590", VA = "0x1883FEF90")]
	private int IHDBNACANEP(int CDBJJKPGCCJ, int FJFDFNHELBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83FE1B0", Offset = "0x83FC7B0", VA = "0x1883FE1B0")]
	private void DJOKAEHIAPO(int CDBJJKPGCCJ, int FJFDFNHELBB, int PMKBIKLJJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83FF320", Offset = "0x83FD920", VA = "0x1883FF320")]
	private bool JLEOKCPBFDE(int CDBJJKPGCCJ, int FJFDFNHELBB, float HBNHIPCMGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x83FF470", Offset = "0x83FDA70", VA = "0x1883FF470")]
	private bool MENIPGDGEBA(int CDBJJKPGCCJ, int FJFDFNHELBB, int PMKBIKLJJFA, float HBNHIPCMGHM, bool CEGAJOFFANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83FED30", Offset = "0x83FD330", VA = "0x1883FED30")]
	private bool HBKKIEJJOII(int CDBJJKPGCCJ, int FJFDFNHELBB, int PMKBIKLJJFA, float HBNHIPCMGHM, bool CEGAJOFFANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83FE190", Offset = "0x83FC790", VA = "0x1883FE190")]
	private void AOKHNADJAKD(int CDBJJKPGCCJ, int FJFDFNHELBB, int PMKBIKLJJFA, [Out] int KJDNDFFMNDJ, [Out] int OKKCCPOJKKI, [Out] int LNOCBFNLAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83FE3B0", Offset = "0x83FC9B0", VA = "0x1883FE3B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CFDJKJFEDJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class EPGONFGOGCN : IDisposable, JAJIKLMOMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Bounds KMJIOHGPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public List<IAKBODPFBIM> HNFLDAHJIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Vector3 PDHMCPKFMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Vector3 AOLGEEIGBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int KCLJNDAHBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GKMCCFCPGAH NKBNCINEHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long ANEPIGPDBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public JCHDAABNPJE AJENOELOBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Transform BOCNDANOLJJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CHNCFLEEOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x83FC510", Offset = "0x83FAB10", VA = "0x1883FC510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh MNAIHHHONID
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GKMCCFCPGAH.DJLMDIAEFCE NHEOCEBLEMF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
			[CompilerGenerated]
			get
			{
				return default(GKMCCFCPGAH.DJLMDIAEFCE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xEF6820", Offset = "0xEF4E20", VA = "0x180EF6820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh JPPKPPHIHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public GKMCCFCPGAH.DJLMDIAEFCE DHDPHGCCOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCC0", Offset = "0xB2C2C0", VA = "0x180B2DCC0")]
			[CompilerGenerated]
			get
			{
				return default(GKMCCFCPGAH.DJLMDIAEFCE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1002BE0", Offset = "0x10011E0", VA = "0x181002BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float LCEHPEFNBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FE0", Offset = "0x12C85E0", VA = "0x1812C9FE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1AB5DE0", Offset = "0x1AB43E0", VA = "0x181AB5DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte EOLCKLIAHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1F192F0", Offset = "0x1F178F0", VA = "0x181F192F0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x18D1E70", Offset = "0x18D0470", VA = "0x1818D1E70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int IICIEJAAKBE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xADD7D0", Offset = "0xADBDD0", VA = "0x180ADD7D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1614130", Offset = "0x1612730", VA = "0x181614130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int NGNMALHLIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xACE6A0", Offset = "0xACCCA0", VA = "0x180ACE6A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1613980", Offset = "0x1611F80", VA = "0x181613980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float ELHONMKEDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83FC850", Offset = "0x83FAE50", VA = "0x1883FC850", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83FC870", Offset = "0x83FAE70", VA = "0x1883FC870")]
		public void ODBPDFPDGHN(PEADBPGCBOF OCNFNIGMAEF, [Out] int MENDNKMGKGP, [Out] int EFENLDGOGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83FCAE0", Offset = "0x83FB0E0", VA = "0x1883FCAE0")]
		public void OKGFILLIHDI(PEADBPGCBOF OCNFNIGMAEF, LDDJPFHOBHE ICOFCHPJMOA, int AACEFHAGPHE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83FC7A0", Offset = "0x83FADA0", VA = "0x1883FC7A0")]
		public void KLKEBDILBCM(Mesh KNHPHEPPGOL, GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83FC710", Offset = "0x83FAD10", VA = "0x1883FC710")]
		public void IBKEIJEFONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83FC550", Offset = "0x83FAB50", VA = "0x1883FC550", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83FCCB0", Offset = "0x83FB2B0", VA = "0x1883FCCB0")]
		public EPGONFGOGCN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Bounds KMJIOHGPLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public GKMCCFCPGAH.DJLMDIAEFCE CGKEBJAAGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public List<EPGONFGOGCN> EOMCIOHNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public HJCEJKHIBOJ FAOGFACLHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public ClusterMeshRenderer PCLFJGMAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int NOPKBIBODNH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh PHFGECIDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CIIIAPMIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HOCNDCPNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83F9DD0", Offset = "0x83F83D0", VA = "0x1883F9DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83F9460", Offset = "0x83F7A60", VA = "0x1883F9460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83F9E20", Offset = "0x83F8420", VA = "0x1883F9E20")]
	public int JBAELLEGNGB(int KCOKJEILDIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83F9E50", Offset = "0x83F8450", VA = "0x1883F9E50")]
	public void OJNPBLHAOBN(ADLNKPEGPEB OIPGNGNGKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83F89A0", Offset = "0x83F6FA0", VA = "0x1883F89A0")]
	public void BDPAKLLCCBO(Transform IKBFOCBMIAL, bool ANOICCJAMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83F9C10", Offset = "0x83F8210", VA = "0x1883F9C10")]
	public bool FLKMNFNBCEM(bool OOAOENFILNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83F95E0", Offset = "0x83F7BE0", VA = "0x1883F95E0")]
	public void EDANLKBJJHC(Transform BOCNDANOLJJ, bool ANOICCJAMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83F91F0", Offset = "0x83F77F0", VA = "0x1883F91F0")]
	public bool CBELOMAGFLH(IAKBODPFBIM IDFKPPKNONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x83FA040", Offset = "0x83F8640", VA = "0x1883FA040")]
	public CFDJKJFEDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IDCKGCMCLMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Queue<CFDJKJFEDJP.EPGONFGOGCN> MOPGBBJEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private NPCHLFHCOJD HFHDABIGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<CFDJKJFEDJP.EPGONFGOGCN> AFEGLODJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int BGIPLLNJPJK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8401030", Offset = "0x83FF630", VA = "0x188401030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x84011B0", Offset = "0x83FF7B0", VA = "0x1884011B0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8401530", Offset = "0x83FFB30", VA = "0x188401530")]
	public void MEFAAGOGBHI(CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL, Transform BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8400E50", Offset = "0x83FF450", VA = "0x188400E50")]
	public void CBELOMAGFLH(CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x84015F0", Offset = "0x83FFBF0", VA = "0x1884015F0")]
	private CFDJKJFEDJP.EPGONFGOGCN NBLJDKBLBME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8401110", Offset = "0x83FF710", VA = "0x188401110")]
	private bool EDKJGGAAGNC(CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8400DF0", Offset = "0x83FF3F0", VA = "0x188400DF0")]
	private void BHGGNDANPHE(CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8400DC0", Offset = "0x83FF3C0", VA = "0x188400DC0")]
	public bool AMHKKEFJLKC(CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8401230", Offset = "0x83FF830", VA = "0x188401230")]
	public bool FPGILMIKMIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84014C0", Offset = "0x83FFAC0", VA = "0x1884014C0")]
	private CFDJKJFEDJP.EPGONFGOGCN KPEOLFLDCBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8400AA0", Offset = "0x83FF0A0", VA = "0x188400AA0")]
	public long AKNBMIDNFMD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8401730", Offset = "0x83FFD30", VA = "0x188401730")]
	public IDCKGCMCLMG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JFDAPCJBFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int DIMEBICFBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int ABEIHALANNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float MMFMJIHMAMB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<CFDJKJFEDJP> PACMFJBGIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84021D0", Offset = "0x84007D0", VA = "0x1884021D0")]
	public JFDAPCJBFPD(int DIMEBICFBBB, int ABEIHALANNJ, float NPPNGEOBICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8401EB0", Offset = "0x84004B0", VA = "0x188401EB0")]
	public void MCBEOIAJGAG(AFMEPHHEFOE KFFCIMAOEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8401D60", Offset = "0x8400360", VA = "0x188401D60")]
	private int CGHKINLGCIM(ADLNKPEGPEB EMOGDLPNEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8401F60", Offset = "0x8400560", VA = "0x188401F60")]
	private void MCBEOIAJGAG(ADLNKPEGPEB EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8401E10", Offset = "0x8400410", VA = "0x188401E10")]
	private void LPGANFEHMKP(ADLNKPEGPEB EMOGDLPNEGA, CFDJKJFEDJP BDBICHHFDGA)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HPLDGKJGOLB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NGGCONKJIJM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
			[DebuggerHidden]
			public NGGCONKJIJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8405CC0", Offset = "0x84042C0", VA = "0x188405CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8405E80", Offset = "0x8404480", VA = "0x188405E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8405DD0", Offset = "0x84043D0", VA = "0x188405DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8405DD0", Offset = "0x84043D0", VA = "0x188405DD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HOCNDCPNFPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x83FBCA0", Offset = "0x83FA2A0", VA = "0x1883FBCA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<JAJIKLMOMOC> MMFHHFODEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83FBC80", Offset = "0x83FA280", VA = "0x1883FBC80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> EOMCIOHNNOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CFDJKJFEDJP PHFGECIDFPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public MHBNBFPBHLH LKOOMACEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(MHBNBFPBHLH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAA70B0", Offset = "0xAA56B0", VA = "0x180AA70B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KOKEGMBJHHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xE15D10", Offset = "0xE14310", VA = "0x180E15D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83FA240", Offset = "0x83F8840", VA = "0x1883FA240")]
		public static ClusterMeshRenderer Create(CFDJKJFEDJP KNHPHEPPGOL, ClusterMeshRenderer LDMDNHCFDLO, MeshFilter FDFCNEHHDDM, ACLDACCHLEI BOCNDANOLJJ, MHBNBFPBHLH MBOGBFPKKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83FA4C0", Offset = "0x83F8AC0", VA = "0x1883FA4C0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83FAFC0", Offset = "0x83F95C0", VA = "0x1883FAFC0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(IAKBODPFBIM IDFKPPKNONO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83FAD70", Offset = "0x83F9370", VA = "0x1883FAD70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83FAA00", Offset = "0x83F9000", VA = "0x1883FAA00")]
		public void Init(CFDJKJFEDJP KNHPHEPPGOL, MeshFilter FDFCNEHHDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83FA520", Offset = "0x83F8B20", VA = "0x1883FA520")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83FB080", Offset = "0x83F9680", VA = "0x1883FB080", Slot = "7")]
		public void UpdateClusterDistances(Vector3 ALFMKPLFANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83FB330", Offset = "0x83F9930", VA = "0x1883FB330", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83FA980", Offset = "0x83F8F80", VA = "0x1883FA980")]
		[IteratorStateMachine(typeof(NGGCONKJIJM))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83FAE00", Offset = "0x83F9400", VA = "0x1883FAE00")]
		public void SetupTagAndLayer(string PEIEJMGOHLN, int MBOGBFPKKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83FADE0", Offset = "0x83F93E0", VA = "0x1883FADE0")]
		public bool Remove(IAKBODPFBIM IDFKPPKNONO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ELKGIADGAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int OLFODKHFGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int NDMFOILAFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public int EFENLDGOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int MENDNKMGKGP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83FC4F0", Offset = "0x83FAAF0", VA = "0x1883FC4F0")]
	public ELKGIADGAHK(int NDMFOILAFKD, int EFENLDGOGPK, int OLFODKHFGLI, int MENDNKMGKGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HJCEJKHIBOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeList<float3> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeList<int> CGILCPAIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public NativeList<int> OBIBBENNFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public NativeList<ELKGIADGAHK> HINOFKEMIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public NativeArray<int> AOHJDOHBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NativeArray<float3> LMKMFNODACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public NativeArray<float> JELLGGNANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public JobHandle BJFLKGBEEDK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DIBGFNJPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAD6FD0", Offset = "0xAD55D0", VA = "0x180AD6FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAD6AD0", Offset = "0xAD50D0", VA = "0x180AD6AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83FFBF0", Offset = "0x83FE1F0", VA = "0x1883FFBF0")]
	public void HAKAIDJFGEI(GKMCCFCPGAH OMNGABOEDEJ, NativeList<ELKGIADGAHK> HINOFKEMIJJ, float EAHAEIJNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x83FF670", Offset = "0x83FDC70", VA = "0x1883FF670")]
	public void CAEKFGNGJKI(Transform BOCNDANOLJJ, bool ANOICCJAMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x83FFA50", Offset = "0x83FE050", VA = "0x1883FFA50")]
	public void FLKMNFNBCEM(CFDJKJFEDJP PCLFJGMAHBI, bool OOAOENFILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83FF910", Offset = "0x83FDF10", VA = "0x1883FF910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83FFA20", Offset = "0x83FE020", VA = "0x1883FFA20")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HJCEJKHIBOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct AAAEBFJCEFA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeList<float3> LMLKICDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	public NativeList<int> CGILCPAIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private NativeList<ELKGIADGAHK> OGJCKLJJEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private NativeArray<int> AOHJDOHBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float3 IAJPGBLEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private NativeArray<float3> LMKMFNODACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeArray<float> JELLGGNANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private bool ANOICCJAMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private float HBPIHICJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[ReadOnly]
	private float JCJKPOBBICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private float GKNIDFMMGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeList<int> OBIBBENNFHJ;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83F1910", Offset = "0x83EFF10", VA = "0x1883F1910")]
	public AAAEBFJCEFA(HJCEJKHIBOJ EEOEMAGCELI, Vector3 IAJPGBLEAMI, bool ANOICCJAMPG, float HBPIHICJBNG, float JCJKPOBBICF, float GKNIDFMMGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83F1410", Offset = "0x83EFA10", VA = "0x1883F1410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IAKBODPFBIM : ECMILFBCNGB
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds JMPMAGCGBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ADLNKPEGPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<IAKBODPFBIM> HNFLDAHJIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public ADLNKPEGPEB BEBONNCPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public ADLNKPEGPEB LKDNLPCPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public ADLNKPEGPEB JAGHJEFPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MENDNKMGKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Bounds KMJIOHGPLNH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83F27B0", Offset = "0x83F0DB0", VA = "0x1883F27B0")]
	public ADLNKPEGPEB(List<IAKBODPFBIM> HNFLDAHJIFG, [Optional] ADLNKPEGPEB BEBONNCPGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AFMEPHHEFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public List<ADLNKPEGPEB> BBPFNGEOLBG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ADLNKPEGPEB HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x83F6500", Offset = "0x83F4B00", VA = "0x1883F6500")]
	public AFMEPHHEFOE(ADLNKPEGPEB BOCNDANOLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BHHPPADNNDO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct HHBOKHBGNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int HLOHJKGAIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int PKOOPNILMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int COFNCBKDPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int CKEIMEJDHJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct MDONCBKJKNF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int PDLFKJAOHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public float NOENANOAPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<IAKBODPFBIM> HNFLDAHJIFG;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8405C60", Offset = "0x8404260", VA = "0x188405C60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum KGOKBNPLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private HHBOKHBGNIH MJOOCADPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int CBLNMPAJOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int DIMEBICFBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int ABEIHALANNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float NPPNGEOBICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float EAOLPNFIPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Stack<ADLNKPEGPEB> CMMJIMANNJD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AFMEPHHEFOE LLILOKPIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x83F8940", Offset = "0x83F6F40", VA = "0x1883F8940")]
	public BHHPPADNNDO(int DIMEBICFBBB, int ABEIHALANNJ, float NPPNGEOBICN, int CBLNMPAJOOM, float EAOLPNFIPHH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83F6D20", Offset = "0x83F5320", VA = "0x1883F6D20")]
	public void IJMENLDDICI(List<IAKBODPFBIM> HNFLDAHJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83F88D0", Offset = "0x83F6ED0", VA = "0x1883F88D0")]
	public bool LMMEBDIBIFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83F68F0", Offset = "0x83F4EF0", VA = "0x1883F68F0")]
	private float AABCLDNCGAB(Vector3 KECGAHAPFAB, Vector3 GAEHKCHAJDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83F6940", Offset = "0x83F4F40", VA = "0x1883F6940")]
	private float AABCLDNCGAB(Vector3 KCJLCGFEBMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x83F7F70", Offset = "0x83F6570", VA = "0x1883F7F70")]
	private bool JNLKHJOIIJB(ADLNKPEGPEB AGEKNKOLGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x83F6EF0", Offset = "0x83F54F0", VA = "0x1883F6EF0")]
	private MDONCBKJKNF JCGEMFMPFKP(List<IAKBODPFBIM> PBFLLCPLOLB, KGOKBNPLGKF EKLPAHMOAJJ)
	{
		return default(MDONCBKJKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x83F6960", Offset = "0x83F4F60", VA = "0x1883F6960")]
	private void AJLECICNDGJ(List<IAKBODPFBIM> HNFLDAHJIFG, NativeArray<Vector3> NPIADELHEED, NativeArray<Vector3> LHDKJHDKJHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JNPIFNFKALB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8402670", Offset = "0x8400C70", VA = "0x188402670")]
	public static Bounds BNENPMMBDFP(List<IAKBODPFBIM> HNFLDAHJIFG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8402840", Offset = "0x8400E40", VA = "0x188402840")]
	public static int NMDDEKKCCME(List<IAKBODPFBIM> HNFLDAHJIFG, PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class HALHECLPHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool OGDJPFGJAAB(float4* HLFENNFMLBE, int NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class FNECGABPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83FD0A0", Offset = "0x83FB6A0", VA = "0x1883FD0A0")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83FD470", Offset = "0x83FBA70", VA = "0x1883FD470")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83FD3C0", Offset = "0x83FB9C0", VA = "0x1883FD3C0")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83FD1D0", Offset = "0x83FB7D0", VA = "0x1883FD1D0")]
		public unsafe static bool MJPLNPACNDN(float4* HLFENNFMLBE, int NODGHDHCBPE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x83FDD90", Offset = "0x83FC390", VA = "0x1883FDD90")]
	[BurstCompile]
	public unsafe static bool FHBLKLOAFML(float4* HLFENNFMLBE, int NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x83F1220", Offset = "0x83EF820", VA = "0x1883F1220")]
	[BurstCompile]
	public unsafe static bool LKGFFEHMEFF(float4* HLFENNFMLBE, int NODGHDHCBPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct BAKLOLGLOJI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[ReadOnly]
	private NativeList<int> PJOANHLJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeList<float3> LLDLECJOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<float3> ECNCFIBLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<float4> OGIBBOIMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private NativeArray<float4> MBDHILMIKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeArray<float2> KHDHFKNOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<bool> PHBDGAOGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public NativeList<ushort> NLBPEBCKJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public NativeList<GKMCCFCPGAH.COEMOBKEIIG> JMKEHKDMKGK;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83F6880", Offset = "0x83F4E80", VA = "0x1883F6880")]
	public BAKLOLGLOJI(GKMCCFCPGAH DFNGLBJCNMF, NativeArray<bool> PHBDGAOGJDO, NativeList<ushort> NLBPEBCKJCD, NativeList<GKMCCFCPGAH.COEMOBKEIIG> JMKEHKDMKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x83F65D0", Offset = "0x83F4BD0", VA = "0x1883F65D0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct KMBKCIJHHFK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[ReadOnly]
	private NativeList<int> PJOANHLJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<float3> LLDLECJOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float3> ECNCFIBLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> OGIBBOIMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> MBDHILMIKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float2> KHDHFKNOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeList<int> LLJINIDNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeList<float3> AOJAIGGIGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeArray<float3> AHLNBIECGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<float4> ICIJHMDHOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeArray<float4> OIMODKCOHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<float2> NEBHAKNMCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[WriteOnly]
	public NativeArray<bool> PHBDGAOGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public NativeList<ushort> NLBPEBCKJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public NativeList<GKMCCFCPGAH.COEMOBKEIIG> JMKEHKDMKGK;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84041C0", Offset = "0x84027C0", VA = "0x1884041C0")]
	public KMBKCIJHHFK(GKMCCFCPGAH DFNGLBJCNMF, GKMCCFCPGAH KHIMLPELLCD, NativeArray<bool> PHBDGAOGJDO, NativeList<ushort> NLBPEBCKJCD, NativeList<GKMCCFCPGAH.COEMOBKEIIG> JMKEHKDMKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8403CF0", Offset = "0x84022F0", VA = "0x188403CF0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NPCHLFHCOJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private GKMCCFCPGAH EEPDLGGKEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private GKMCCFCPGAH DFNGLBJCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<bool> EAONBNLBECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeList<ushort> NLBPEBCKJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private NativeList<GKMCCFCPGAH.COEMOBKEIIG> JMKEHKDMKGK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static GKMCCFCPGAH MPKJGFEFKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private DDCEMAKIKNP JLEFCJKIJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private LDDJPFHOBHE ICOFCHPJMOA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BJFLKGBEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xECC1C0", Offset = "0xECA7C0", VA = "0x180ECC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CFDJKJFEDJP.EPGONFGOGCN AGEKNKOLGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IJMJBKKCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2786A20", Offset = "0x2785020", VA = "0x182786A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84067A0", Offset = "0x8404DA0", VA = "0x1884067A0")]
	[FEIBEOENFMF(CMFDNLPEHHP.EnteredEditMode, 0)]
	private static void BMKHBEOHBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8406930", Offset = "0x8404F30", VA = "0x188406930")]
	public void HAKAIDJFGEI(CFDJKJFEDJP.EPGONFGOGCN OGJCKLJJEGD, Transform BBPCNGMPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8405ED0", Offset = "0x84044D0", VA = "0x188405ED0")]
	public void AMOAMGMGECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8406820", Offset = "0x8404E20", VA = "0x188406820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x84068F0", Offset = "0x8404EF0", VA = "0x1884068F0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8407480", Offset = "0x8405A80", VA = "0x188407480")]
	public NPCHLFHCOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NJPLFELLPOM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 AJJJIDENCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HIMFGJJFHOG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(LLMBEMAOGHJ<string>.LBCCFMIMELL GIGFHIDOHFF, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JIOGOAEGDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIOGOAEGDCC GIKLGNAKIGJ(Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JIOGOAEGDCC JDAOBDLLGJA(Action PMBBLAOPHON);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class JMHAOEEEGPC : JIOGOAEGDCC
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class KCFHJMHJOMJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public JMHAOEEEGPC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public KCFHJMHJOMJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x8403C00", Offset = "0x8402200", VA = "0x188403C00")]
				internal void HCBAGBGKCOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x8403CA0", Offset = "0x84022A0", VA = "0x188403CA0")]
				internal void OOIPANOOMPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x8403C50", Offset = "0x8402250", VA = "0x188403C50")]
				internal void NMBJBLHCLLO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Func<JobHandle> OAJIMDNNCAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action OOMFDDGKEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private Action GFPKIIGBKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private NFLMIJLKEIE IHBEDHKKDDK;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action BBDKECKOJEP
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action AGOMKPCAFGH
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2ADEFE0", Offset = "0x2ADD5E0", VA = "0x182ADEFE0", Slot = "4")]
			public JIOGOAEGDCC GIKLGNAKIGJ(Action PMBBLAOPHON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7D339B0", Offset = "0x7D31FB0", VA = "0x187D339B0", Slot = "5")]
			public JIOGOAEGDCC JDAOBDLLGJA(Action PMBBLAOPHON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
			public JMHAOEEEGPC(Func<JobHandle> LFGKOFPEJEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x84023B0", Offset = "0x84009B0", VA = "0x1884023B0")]
			public void CKKIIFJHCHE(Action PPBEDICKMCJ, Action KNNCLNDHMGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8402220", Offset = "0x8400820", VA = "0x188402220")]
			public void CBELOMAGFLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class PJOODHLIFME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JIOGOAEGDCC jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public PJOODHLIFME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x84076F0", Offset = "0x8405CF0", VA = "0x1884076F0")]
			internal bool INDBNPGGJJP(JMHAOEEEGPC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ACGCDFPLJHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public JMHAOEEEGPC newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ACGCDFPLJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x83F2750", Offset = "0x83F0D50", VA = "0x1883F2750")]
			internal void OKOBDJCHDPL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Queue<JMHAOEEEGPC> KACJLHPBLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<JMHAOEEEGPC> CACDDGFJDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private FAKIPBKLGEB FCPGNJBEACN;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public PADNGANMCPO CHCFBODKNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8402AC0", Offset = "0x84010C0", VA = "0x188402AC0")]
		public JIOGOAEGDCC Add(Func<JobHandle> LFGKOFPEJEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8402DF0", Offset = "0x84013F0", VA = "0x188402DF0")]
		public void Remove(JIOGOAEGDCC BJFLKGBEEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8402C20", Offset = "0x8401220", VA = "0x188402C20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8402FD0", Offset = "0x84015D0", VA = "0x188402FD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8403230", Offset = "0x8401830", VA = "0x188403230")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8402C10", Offset = "0x8401210", VA = "0x188402C10")]
		[CompilerGenerated]
		private void GAKPFGOJBPM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NFLMIJLKEIE
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFLMIJLKEIE GIKLGNAKIGJ(Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFLMIJLKEIE INJNCBBPKIA(Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NFLMIJLKEIE JDAOBDLLGJA(Action PMBBLAOPHON);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, AKDIJPFDGAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class JPDGNHADCLK : NFLMIJLKEIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private JobHandle OPFFDBFJJBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action OOMFDDGKEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action AAGFNFPNDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private Action AGOMKPCAFGH;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool INFFINLHJFI
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8402A60", Offset = "0x8401060", VA = "0x188402A60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7C47230", Offset = "0x7C45830", VA = "0x187C47230", Slot = "4")]
			public NFLMIJLKEIE GIKLGNAKIGJ(Action PMBBLAOPHON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7C47250", Offset = "0x7C45850", VA = "0x187C47250", Slot = "5")]
			public NFLMIJLKEIE INJNCBBPKIA(Action PMBBLAOPHON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7D339B0", Offset = "0x7D31FB0", VA = "0x187D339B0", Slot = "6")]
			public NFLMIJLKEIE JDAOBDLLGJA(Action PMBBLAOPHON)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1100830", Offset = "0x10FEE30", VA = "0x181100830")]
			public JPDGNHADCLK(JobHandle AJLJIADENBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8402A70", Offset = "0x8401070", VA = "0x188402A70")]
			public void PNGLJDLMHCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8402A10", Offset = "0x8401010", VA = "0x188402A10")]
			public void CBELOMAGFLH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private List<JPDGNHADCLK> CKAHJFAKNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly List<IDisposable> KGLGNBHAPLG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MEGELOEHMPG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8403810", Offset = "0x8401E10", VA = "0x188403810")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1725830", Offset = "0x1723E30", VA = "0x181725830")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8403310", Offset = "0x8401910", VA = "0x188403310")]
		public NFLMIJLKEIE Add(JobHandle AJLJIADENBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8403A20", Offset = "0x8402020", VA = "0x188403A20")]
		public void Remove(NFLMIJLKEIE BJFLKGBEEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8403630", Offset = "0x8401C30", VA = "0x188403630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8403480", Offset = "0x8401A80", VA = "0x188403480", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x84033B0", Offset = "0x84019B0", VA = "0x1884033B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8403B20", Offset = "0x8402120", VA = "0x188403B20")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAD3D60", Offset = "0xAD2360", VA = "0x180AD3D60", Slot = "6")]
		private bool IPGDOMHPEAO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8407700", Offset = "0x8405D00", VA = "0x188407700")]
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
