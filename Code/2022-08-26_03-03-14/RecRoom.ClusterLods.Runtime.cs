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
				[Cpp2IlInjected.Address(RVA = "0x47E0BC0", Offset = "0x47DF7C0", VA = "0x1847E0BC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1B16FD0", Offset = "0x1B15BD0", VA = "0x181B16FD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x47E0B80", Offset = "0x47DF780", VA = "0x1847E0B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x47D8E40", Offset = "0x47D7A40", VA = "0x1847D8E40")]
		public LODSettings HEHCEFDGMLB(KACMKOBLJNJ PEMDPBOGJEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x47D8E50", Offset = "0x47D7A50", VA = "0x1847D8E50")]
		public int INNCKDLAHNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x47D8D40", Offset = "0x47D7940", VA = "0x1847D8D40")]
		public int FLKGLFGMBFB(bool MAIHBNCGDHE, Vector3 BPLOMNPBBMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x47D8E70", Offset = "0x47D7A70", VA = "0x1847D8E70")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ACKGPOJPFDE
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
public interface MKKBPNFBIAG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CINHNPNOCND();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CAFKJHDCKEN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CGFMEGBABMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<NHGABLPLPCK> GBMICNOFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ACKGPOJPFDE IEJFBLHDMFK
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
	void UpdateClusterDistances(Vector3 AJAFCGMELAL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(DHNPMPADHKD DGHFPMGLNEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHGABLPLPCK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int MENMOFFBKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int JNMCBFHFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LCKHHEHFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JAECNNCHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte IEFKAGFCBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NDCPDKHLMJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum EKJOAPMNDII
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
	private struct DKKICJFLPAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NDCPDKHLMJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JBHAGEIOKBE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private JBHAGEIOKBE <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x47DBA00", Offset = "0x47DA600", VA = "0x1847DBA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GOMDPNJFAMM : IEnumerator<OGCDMMFGIGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private OGCDMMFGIGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NDCPDKHLMJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OGCDMMFGIGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
		[DebuggerHidden]
		public GOMDPNJFAMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47DE0A0", Offset = "0x47DCCA0", VA = "0x1847DE0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x47DE160", Offset = "0x47DCD60", VA = "0x1847DE160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FFCOBFIFGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NDCPDKHLMJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JBHAGEIOKBE worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JBHAGEIOKBE <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x47DC790", Offset = "0x47DB390", VA = "0x1847DC790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NFHBILHDALF : IEnumerator<OGCDMMFGIGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OGCDMMFGIGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NDCPDKHLMJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OGCDMMFGIGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
		[DebuggerHidden]
		public NFHBILHDALF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x47E4EB0", Offset = "0x47E3AB0", VA = "0x1847E4EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47E5D90", Offset = "0x47E4990", VA = "0x1847E5D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int MLDAPNFFCBD = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan DONIEAEBEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer JKLEPCIGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter KNIOHLBNEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject JACLOLJCIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject MJGLDAFAOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OABDGJLEFFG MNPBNEHFJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DHNPMPADHKD> FCNMFFFBCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DHNPMPADHKD> NNAAEOHCJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<DHNPMPADHKD> NPEPGEPIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int KMPPBNGDEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EKJOAPMNDII NOFKIGGIPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CAFKJHDCKEN>[] MKBICDPBEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<NHGABLPLPCK>[] PJNCGAHEMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource IDJHKNHCIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool KACIMIPJKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private GECAAOLGCPI DJAIPPJEIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GECAAOLGCPI GLHKNHPGMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int FMLABBEHDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int OLCIPGFGDFP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static NDCPDKHLMJO OBPEBAMLBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MGJDFNIJDHL GNCGKLNKJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CDLAGICBBCK JDPKDEJDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour CBCNHGGLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material DJOMJHJOKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<MKKBPNFBIAG> IPBCGIDLDFM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig IPANDPMEEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 NPGINCKKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF88270", Offset = "0xF86E70", VA = "0x180F88270")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF88180", Offset = "0xF86D80", VA = "0x180F88180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private EKJOAPMNDII DJLOJIMGBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FFCD0", Offset = "0x5FE8D0", VA = "0x1805FFCD0")]
		get
		{
			return default(EKJOAPMNDII);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x47E37A0", Offset = "0x47E23A0", VA = "0x1847E37A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NDCPDKHLMJO DBFNMCLAAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x47E4310", Offset = "0x47E2F10", VA = "0x1847E4310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BLMPKLKEHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x47E3D80", Offset = "0x47E2980", VA = "0x1847E3D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool NNCOPCOLOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x47E4460", Offset = "0x47E3060", VA = "0x1847E4460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> ENCEBNONKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x47E3480", Offset = "0x47E2080", VA = "0x1847E3480")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x47E4060", Offset = "0x47E2C60", VA = "0x1847E4060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MENCKGOGODE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x47E4270", Offset = "0x47E2E70", VA = "0x1847E4270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x47E3520", Offset = "0x47E2120", VA = "0x1847E3520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x47E4860", Offset = "0x47E3460", VA = "0x1847E4860")]
	public NDCPDKHLMJO(MGJDFNIJDHL GNCGKLNKJBI, CDLAGICBBCK JDPKDEJDHNL, ClusterLODConfig FKGLACPKHLD, MonoBehaviour CBCNHGGLNMD, Material DJOMJHJOKMA, ClusterMeshRenderer JKLEPCIGCGA, MeshFilter KNIOHLBNEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x47E31C0", Offset = "0x47E1DC0", VA = "0x1847E31C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47E3680", Offset = "0x47E2280", VA = "0x1847E3680")]
	public static void JDPBGFNKEHD(Vector3 FHFHNHPCPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47E43D0", Offset = "0x47E2FD0", VA = "0x1847E43D0")]
	private void PGJHIIJJFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47E2CE0", Offset = "0x47E18E0", VA = "0x1847E2CE0")]
	private void CMKPGPMJPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47E4540", Offset = "0x47E3140", VA = "0x1847E4540")]
	private void PMDIHLLFMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x47E27F0", Offset = "0x47E13F0", VA = "0x1847E27F0")]
	public void BONFMFNGLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47E3F20", Offset = "0x47E2B20", VA = "0x1847E3F20")]
	[AsyncStateMachine(typeof(DKKICJFLPAO))]
	public Task NPLKCNOBJFI(JBHAGEIOKBE JDIFJAIAPMA, CancellationToken EOJPFFNCEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47E3090", Offset = "0x47E1C90", VA = "0x1847E3090")]
	[IteratorStateMachine(typeof(GOMDPNJFAMM))]
	private IEnumerator<OGCDMMFGIGL> DCJBAPAIACM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47E3340", Offset = "0x47E1F40", VA = "0x1847E3340")]
	[AsyncStateMachine(typeof(FFCOBFIFGHH))]
	private Task EMJGAAPHMPB(JBHAGEIOKBE HPKJBNLMNNG, CancellationToken DHCIMDILIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47E3B10", Offset = "0x47E2710", VA = "0x1847E3B10")]
	public void LFFPEIMMCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47E3A90", Offset = "0x47E2690", VA = "0x1847E3A90")]
	public void JNOHAAIBIOL(IEnumerable<CAFKJHDCKEN> AOLGJBBJIEK, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47E2DE0", Offset = "0x47E19E0", VA = "0x1847E2DE0")]
	public void DBMJDPILLJG(IEnumerable<CAFKJHDCKEN> AOLGJBBJIEK, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47E1E60", Offset = "0x47E0A60", VA = "0x1847E1E60")]
	public List<ClusterMeshRenderer> BACIDGFDJKO(List<DHNPMPADHKD> PDBANHEHPOA, CLEFBGOBOPM IFKKFCHLHMM, ACKGPOJPFDE IDOKADFGGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47E35C0", Offset = "0x47E21C0", VA = "0x1847E35C0")]
	public ACKGPOJPFDE GCBJLMGFLLH(Vector3 KEHJINKIIJM)
	{
		return default(ACKGPOJPFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47E3D20", Offset = "0x47E2920", VA = "0x1847E3D20")]
	public void LGNEOLFNAKN(MKKBPNFBIAG LILNPECFKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47E3160", Offset = "0x47E1D60", VA = "0x1847E3160")]
	public bool DNNJABLCFMJ(MKKBPNFBIAG LILNPECFKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47E3100", Offset = "0x47E1D00", VA = "0x1847E3100")]
	public void DKFJJAPIFLM(DHNPMPADHKD KMPCCJIEKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x47E3EA0", Offset = "0x47E2AA0", VA = "0x1847E3EA0")]
	public void NDNIHFLKODI(NHGABLPLPCK EKFEHKNGPAJ, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47E32C0", Offset = "0x47E1EC0", VA = "0x1847E32C0")]
	public void EAMCOCILIAM(NHGABLPLPCK EKFEHKNGPAJ, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47E2650", Offset = "0x47E1250", VA = "0x1847E2650")]
	private void BGKKPCHDICI(Vector3 AJAFCGMELAL, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47E4680", Offset = "0x47E3280", VA = "0x1847E4680")]
	private void PNNFJHDLJKG(Vector3 AJAFCGMELAL, ACKGPOJPFDE IDOKADFGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47E2780", Offset = "0x47E1380", VA = "0x1847E2780")]
	[IteratorStateMachine(typeof(NFHBILHDALF))]
	private IEnumerator<OGCDMMFGIGL> BMFJLGPONMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47E4100", Offset = "0x47E2D00", VA = "0x1847E4100")]
	private int OLAJKNAFLNI(int HIANDEDCLIF, int IMNMHFHIENN, List<NHGABLPLPCK> CLJBCMPNBDL, byte PEMDPBOGJEA, ref int HHGEDPHGJPM, float NOFJJMLGCIB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x47E38C0", Offset = "0x47E24C0", VA = "0x1847E38C0")]
	public void JNIHJKFEBJI(DHNPMPADHKD DGHFPMGLNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47E3600", Offset = "0x47E2200", VA = "0x1847E3600")]
	public bool GDBJKPHOHIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x677AA0", Offset = "0x6766A0", VA = "0x180677AA0")]
	public Material AJDGGEBNBNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x47E3640", Offset = "0x47E2240", VA = "0x1847E3640")]
	public int INNCKDLAHNE()
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
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct ELBCCADIMJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> PDOHLCLMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> FBGMCPJMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> GPNKKIGOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> ENGMEGKJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> EIAOFBNOMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> KDDCEBHGJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> PMILIDFGIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 EDHICPLODKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float ALPKNAJNOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> JLGCDMBIIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> PDLDKNIPADB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x47DC6D0", Offset = "0x47DB2D0", VA = "0x1847DC6D0")]
	public ELBCCADIMJC(BNNFCKHAFIM NIFBJJIIANL, NativeList<float3> PMILIDFGIKA, NativeMultiHashMap<int, int> JLGCDMBIIGL, NativeArray<int> PDLDKNIPADB, Vector3 EDHICPLODKL, float ALPKNAJNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x47DC670", Offset = "0x47DB270", VA = "0x1847DC670")]
	private int HIGMJIPNJHK(float3 AJAFCGMELAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x47DBFE0", Offset = "0x47DABE0", VA = "0x1847DBFE0")]
	private int EGDDCCKKGNB(int JNJLPHNJHIN, int KKDEFIFHPNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47DC280", Offset = "0x47DAE80", VA = "0x1847DC280", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OKJLGEFHJDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> JLGCDMBIIGL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> PDLDKNIPADB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int HEAFNFCDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> AMCCJFFINOH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47E9350", Offset = "0x47E7F50", VA = "0x1847E9350")]
	public void ACDDNGAAFBH(int NJPKIMOEFFL, Allocator HGKGLCNFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47E94F0", Offset = "0x47E80F0", VA = "0x1847E94F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public OKJLGEFHJDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct MPHNAOCDHMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> ICADNCDJFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> BDHLENGAPNH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47E1E30", Offset = "0x47E0A30", VA = "0x1847E1E30")]
	public MPHNAOCDHMO(OKJLGEFHJDJ JFEKGHIGDGF, BNNFCKHAFIM NIFBJJIIANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47E1DA0", Offset = "0x47E09A0", VA = "0x1847E1DA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DIIHPLMCFEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> IFOPMNHEBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> GNGADFAKNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> OFFFFGGIGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> IPDJHEMIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> BBCIILIKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> AMCCJFFINOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> ICADNCDJFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> MPJPNPOKNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> CKFPDACDMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> LBMNAJMNDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> DAOONAAIKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> CEDHMAJEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> IKJAOKJGOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float ODGENELLKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float FONONKJDMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 FGDCKGKNMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float IKNFLBCADPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NBFNINOPPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float EIJHLGKIBNG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47DB8C0", Offset = "0x47DA4C0", VA = "0x1847DB8C0")]
	public DIIHPLMCFEE(OKJLGEFHJDJ LBPHJDPFMNE, BNNFCKHAFIM NIFBJJIIANL, BNNFCKHAFIM LPAMFOCIOIN, float NBFNINOPPCL, float EIJHLGKIBNG, Vector3 FGDCKGKNMMI, float IKNFLBCADPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x47DB4F0", Offset = "0x47DA0F0", VA = "0x1847DB4F0")]
	private float3 MOEGHHDDJJO(int JNJLPHNJHIN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x47DB310", Offset = "0x47D9F10", VA = "0x1847DB310")]
	private void LKBODBGDMPE(int JNJLPHNJHIN, out float3 EGAJBAKKPIP, out float3 CLJBOAPKJIC, out float4 DNACNDGBKPF, out float4 PNKLECBOCEM, out float2 LJJCOMLENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x47DB590", Offset = "0x47DA190", VA = "0x1847DB590")]
	private int NJHNEOMKCMP(int BDJIFCDGDLE, int LDLLLMFNKCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x47DA790", Offset = "0x47D9390", VA = "0x1847DA790")]
	private void DHLKBHICKGG(int BDJIFCDGDLE, int LDLLLMFNKCH, int EOLBAHPMJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x47DA2E0", Offset = "0x47D8EE0", VA = "0x1847DA2E0")]
	private bool BICLCBEGOCF(int BDJIFCDGDLE, int LDLLLMFNKCH, float FOPJEMPEPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x47DA470", Offset = "0x47D9070", VA = "0x1847DA470")]
	private bool CACNFAAPHNA(int BDJIFCDGDLE, int LDLLLMFNKCH, int EOLBAHPMJIL, float FOPJEMPEPIP, bool AINMGNPBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47DA530", Offset = "0x47D9130", VA = "0x1847DA530")]
	private bool CKHLLBOIENO(int BDJIFCDGDLE, int LDLLLMFNKCH, int EOLBAHPMJIL, float FOPJEMPEPIP, bool AINMGNPBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47DB2F0", Offset = "0x47D9EF0", VA = "0x1847DB2F0")]
	private void LECKBHOLGNJ(int BDJIFCDGDLE, int LDLLLMFNKCH, int EOLBAHPMJIL, out int NBKKMCEGNLN, out int AKNFHGCKFHD, out int NANDFOBPFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47DA990", Offset = "0x47D9590", VA = "0x1847DA990", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KNKAPIEOCFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NPJPEGNNILK : IDisposable, NHGABLPLPCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds FLJOMBKKJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<DHNPMPADHKD> PDBANHEHPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 LNNAEAJDDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 BKDAAFHEOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int OGBCIJGKCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BNNFCKHAFIM PGHDCBJDOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OKJLGEFHJDJ BAJPDMLMKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform IFKKFCHLHMM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int BMKJBHAEJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x47E6330", Offset = "0x47E4F30", VA = "0x1847E6330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh DCMBBJCDNIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh MIJJPIPPFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LCKHHEHFDMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x10A05E0", Offset = "0x109F1E0", VA = "0x1810A05E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x20A1930", Offset = "0x20A0530", VA = "0x1820A1930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte IEFKAGFCBGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x73C870", Offset = "0x73B470", VA = "0x18073C870")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x73CA00", Offset = "0x73B600", VA = "0x18073CA00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int MENMOFFBKEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x788800", Offset = "0x787400", VA = "0x180788800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x787E90", Offset = "0x786A90", VA = "0x180787E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JNMCBFHFPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBBBEA0", Offset = "0xBBAAA0", VA = "0x180BBBEA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE3FF50", Offset = "0xE3EB50", VA = "0x180E3FF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JAECNNCHAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x47E6560", Offset = "0x47E5160", VA = "0x1847E6560", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x47E5F60", Offset = "0x47E4B60", VA = "0x1847E5F60")]
		public void DBLKNIFHLBB(KACMKOBLJNJ PEMDPBOGJEA, out int CFKCNOPLEOK, out int HEPEBCEKAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x47E6190", Offset = "0x47E4D90", VA = "0x1847E6190")]
		public void DEKAJJECCFP(KACMKOBLJNJ PEMDPBOGJEA, OMMMHMLCNLM EPJIANIGJCO, int LGEJCLOBPJJ = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x47E6580", Offset = "0x47E5180", VA = "0x1847E6580")]
		public void KFJOENPIPDP(NativeList<FPIFJIGGBEI> CKPGHPGDMFI, Transform MFKJFJOEHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47E68A0", Offset = "0x47E54A0", VA = "0x1847E68A0")]
		public void ONNGNHOCHCL(Mesh NIFBJJIIANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47E5EC0", Offset = "0x47E4AC0", VA = "0x1847E5EC0")]
		public void APLNDGNCJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x47E6370", Offset = "0x47E4F70", VA = "0x1847E6370", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x47E6940", Offset = "0x47E5540", VA = "0x1847E6940")]
		public NPJPEGNNILK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds FLJOMBKKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<NPJPEGNNILK> MEDGGOMKCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public CIHLNDDHFOI GJIPANNAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer PIKMLOGMBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int NHBPIBAMIJH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh OAAANAPFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LOEDABJEMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE70", Offset = "0x7DCA70", VA = "0x1807DDE70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEF0", Offset = "0x7DCAF0", VA = "0x1807DDEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int CGFMEGBABMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x47E0A60", Offset = "0x47DF660", VA = "0x1847E0A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47DF8E0", Offset = "0x47DE4E0", VA = "0x1847DF8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47E0A30", Offset = "0x47DF630", VA = "0x1847E0A30")]
	public int MALMFCOKABH(int LFPNCBEHEGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x47DF750", Offset = "0x47DE350", VA = "0x1847DF750")]
	public void AHDGGGCHBBD(AGKKNAJILID CFGGBPINAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x47DFEA0", Offset = "0x47DEAA0", VA = "0x1847DFEA0")]
	public void JCOGIGGNFEM(Transform MFKJFJOEHLD, bool INLJGLHMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47E0880", Offset = "0x47DF480", VA = "0x1847E0880")]
	public bool KAADGOMFHHG(bool IGMGJDJEHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47DFA40", Offset = "0x47DE640", VA = "0x1847DFA40")]
	public void GAOBDMAIPKH(Transform IFKKFCHLHMM, bool INLJGLHMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x47E0600", Offset = "0x47DF200", VA = "0x1847E0600")]
	public bool JNIHJKFEBJI(DHNPMPADHKD DGHFPMGLNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x47E0AB0", Offset = "0x47DF6B0", VA = "0x1847E0AB0")]
	public KNKAPIEOCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OABDGJLEFFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<KNKAPIEOCFE.NPJPEGNNILK> EMFGOKJNJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MIJCCLLMOIH BMMGFNFPOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<KNKAPIEOCFE.NPJPEGNNILK> DBBBMABDLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int DNLFIPPLELD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47E6A60", Offset = "0x47E5660", VA = "0x1847E6A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x47E7130", Offset = "0x47E5D30", VA = "0x1847E7130")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x47E7080", Offset = "0x47E5C80", VA = "0x1847E7080")]
	public void LFMPFEAFMAL(KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF, Transform IFKKFCHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x47E6C00", Offset = "0x47E5800", VA = "0x1847E6C00")]
	public void JNIHJKFEBJI(KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x47E6AD0", Offset = "0x47E56D0", VA = "0x1847E6AD0")]
	private KNKAPIEOCFE.NPJPEGNNILK JDOGKCECJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47E71B0", Offset = "0x47E5DB0", VA = "0x1847E71B0")]
	private bool MBAINJEIHDA(KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x47E6A00", Offset = "0x47E5600", VA = "0x1847E6A00")]
	private void DDNKKAOGCHG(KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47E7040", Offset = "0x47E5C40", VA = "0x1847E7040")]
	public bool KOAGDCOKHBK(KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47E6DB0", Offset = "0x47E59B0", VA = "0x1847E6DB0")]
	public bool KLCBFOGAMFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47E7240", Offset = "0x47E5E40", VA = "0x1847E7240")]
	private KNKAPIEOCFE.NPJPEGNNILK OFDDKFALBNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47E72A0", Offset = "0x47E5EA0", VA = "0x1847E72A0")]
	public OABDGJLEFFG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AAKKFAMJEEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int NLNIPGBGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FMAOJCJAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float HNFKMMOKFAG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<KNKAPIEOCFE> HIAPDAKLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47D77A0", Offset = "0x47D63A0", VA = "0x1847D77A0")]
	public AAKKFAMJEEM(int NLNIPGBGDAI, int FMAOJCJAKIM, float GPIOJBCAMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x47D72F0", Offset = "0x47D5EF0", VA = "0x1847D72F0")]
	public void NGGLGFICNGF(BCJFLEKNLCE FONLFENDBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47D7250", Offset = "0x47D5E50", VA = "0x1847D7250")]
	private int EIJEBMGAOFM(AGKKNAJILID PKMOGGONLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x47D7390", Offset = "0x47D5F90", VA = "0x1847D7390")]
	private void NGGLGFICNGF(AGKKNAJILID PKMOGGONLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x47D75C0", Offset = "0x47D61C0", VA = "0x1847D75C0")]
	private void OLBKAFHKMJG(AGKKNAJILID PKMOGGONLGF, KNKAPIEOCFE KMOMOLHHEFE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CAFKJHDCKEN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BBHPPBPODPM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
			[DebuggerHidden]
			public BBHPPBPODPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x47D7870", Offset = "0x47D6470", VA = "0x1847D7870", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x47D7A00", Offset = "0x47D6600", VA = "0x1847D7A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x47D7960", Offset = "0x47D6560", VA = "0x1847D7960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x47D7960", Offset = "0x47D6560", VA = "0x1847D7960", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CGFMEGBABMO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x47DA280", Offset = "0x47D8E80", VA = "0x1847DA280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<NHGABLPLPCK> GBMICNOFCHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x47DA260", Offset = "0x47D8E60", VA = "0x1847DA260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> MEDGGOMKCCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KNKAPIEOCFE OAAANAPFFBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ACKGPOJPFDE IEJFBLHDMFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5ED390", Offset = "0x5EBF90", VA = "0x1805ED390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(ACKGPOJPFDE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7F6880", Offset = "0x7F5480", VA = "0x1807F6880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BMMCGHFFFGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x47DA270", Offset = "0x47D8E70", VA = "0x1847DA270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x47D8ED0", Offset = "0x47D7AD0", VA = "0x1847D8ED0")]
		public static ClusterMeshRenderer Create(KNKAPIEOCFE NIFBJJIIANL, ClusterMeshRenderer JKLEPCIGCGA, MeshFilter KNIOHLBNEBE, CLEFBGOBOPM IFKKFCHLHMM, ACKGPOJPFDE IDOKADFGGOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x47D9050", Offset = "0x47D7C50", VA = "0x1847D9050", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x47D97D0", Offset = "0x47D83D0", VA = "0x1847D97D0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(DHNPMPADHKD DGHFPMGLNEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x47D95A0", Offset = "0x47D81A0", VA = "0x1847D95A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x47D92B0", Offset = "0x47D7EB0", VA = "0x1847D92B0")]
		public void Init(KNKAPIEOCFE NIFBJJIIANL, MeshFilter KNIOHLBNEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x47D90B0", Offset = "0x47D7CB0", VA = "0x1847D90B0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x47D9900", Offset = "0x47D8500", VA = "0x1847D9900", Slot = "8")]
		public void UpdateClusterDistances(Vector3 AJAFCGMELAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x47D9B40", Offset = "0x47D8740", VA = "0x1847D9B40", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x47D9240", Offset = "0x47D7E40", VA = "0x1847D9240")]
		[IteratorStateMachine(typeof(BBHPPBPODPM))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x47D9620", Offset = "0x47D8220", VA = "0x1847D9620")]
		public void SetupTagAndLayer(string PLJOLAMNPFD, int IDOKADFGGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x47D9600", Offset = "0x47D8200", VA = "0x1847D9600")]
		public bool Remove(DHNPMPADHKD DGHFPMGLNEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LJAGPJGOACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int HDJDJCMHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int KAENBJHHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HEPEBCEKAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CFKCNOPLEOK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47E0B50", Offset = "0x47DF750", VA = "0x1847E0B50")]
	public LJAGPJGOACB(int KAENBJHHHIL, int HEPEBCEKAKM, int HDJDJCMHCFC, int CFKCNOPLEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CIHLNDDHFOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> PDOHLCLMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> AMCCJFFINOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> KDDCEBHGJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<LJAGPJGOACB> GMPDMIJGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> KAOAJCHPLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> AHKCPKKGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> AAOEKBNPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle NKBLFABEMGA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BEBDHJPDNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85B530", Offset = "0x85A130", VA = "0x18085B530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85B550", Offset = "0x85A150", VA = "0x18085B550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x47D7E90", Offset = "0x47D6A90", VA = "0x1847D7E90")]
	public void HILHGJFFAMN(BNNFCKHAFIM IBDOFJAAKOG, NativeList<LJAGPJGOACB> GMPDMIJGEHC, float LIDNCELIAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x47D7B00", Offset = "0x47D6700", VA = "0x1847D7B00")]
	public void CNBBHFJBJGF(Transform IFKKFCHLHMM, bool INLJGLHMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x47D8B80", Offset = "0x47D7780", VA = "0x1847D8B80")]
	public void KAADGOMFHHG(KNKAPIEOCFE PIKMLOGMBBA, bool IGMGJDJEHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x47D7DC0", Offset = "0x47D69C0", VA = "0x1847D7DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x47D8D10", Offset = "0x47D7910", VA = "0x1847D8D10")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public CIHLNDDHFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HOFCEEEHGMI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> PDOHLCLMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> AMCCJFFINOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<LJAGPJGOACB> NAIFIKIDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> KAOAJCHPLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 FGDCKGKNMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> AHKCPKKGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> AAOEKBNPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool INLJGLHMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float JPIIJOEOLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float COLBHDKHIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float CBGKDKGFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> KDDCEBHGJHK;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x47DE9E0", Offset = "0x47DD5E0", VA = "0x1847DE9E0")]
	public HOFCEEEHGMI(CIHLNDDHFOI PFDJCNBMCPN, Vector3 FGDCKGKNMMI, bool INLJGLHMNKB, float JPIIJOEOLFC, float COLBHDKHIAC, float CBGKDKGFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47DE540", Offset = "0x47DD140", VA = "0x1847DE540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DHNPMPADHKD : OLDLEEMDEGF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds MEPGCKGDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FPIFJIGGBEI EBMEJHHKHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AGKKNAJILID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<DHNPMPADHKD> PDBANHEHPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public AGKKNAJILID MKOLBPGKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public AGKKNAJILID OHCOFDEBLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public AGKKNAJILID OHGDFIFKGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int CFKCNOPLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds FLJOMBKKJJA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x47D77F0", Offset = "0x47D63F0", VA = "0x1847D77F0")]
	public AGKKNAJILID(List<DHNPMPADHKD> PDBANHEHPOA, [Optional] AGKKNAJILID MKOLBPGKLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BCJFLEKNLCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<AGKKNAJILID> EKJLBLEIAML;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AGKKNAJILID JOENHKCCFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47D7A50", Offset = "0x47D6650", VA = "0x1847D7A50")]
	public BCJFLEKNLCE(AGKKNAJILID IFKKFCHLHMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OJCFBDEMKOM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct IKEAAGGAIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int HNOEJOAHPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int KKMFNPHJKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int ILGAFLJOGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int NONKOACCGGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AGPICGKMALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int NPJBIPGPOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float KHNCANJEALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<DHNPMPADHKD> PDBANHEHPOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PPLFJCKOCMN
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
	private IKEAAGGAIKG BFBDKCDBKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CAANFMGFNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int NLNIPGBGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int FMAOJCJAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GPIOJBCAMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float JGBNNAJCHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<AGKKNAJILID> OJNJPGEPBPO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BCJFLEKNLCE MGGBJEEDOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x47E92F0", Offset = "0x47E7EF0", VA = "0x1847E92F0")]
	public OJCFBDEMKOM(int NLNIPGBGDAI, int FMAOJCJAKIM, float GPIOJBCAMEN, int CAANFMGFNKH, float JGBNNAJCHGJ = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x47E9130", Offset = "0x47E7D30", VA = "0x1847E9130")]
	public void PFCEPCHOPPI(List<DHNPMPADHKD> PDBANHEHPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x47E8B80", Offset = "0x47E7780", VA = "0x1847E8B80")]
	public bool HNHKODJPKMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x47E9020", Offset = "0x47E7C20", VA = "0x1847E9020")]
	private float MBCAHDCGNLM(Vector3 BBPNPMFNJED, Vector3 PFDMIIOLPIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x47E8F80", Offset = "0x47E7B80", VA = "0x1847E8F80")]
	private float MBCAHDCGNLM(Vector3 OEBMILJLIAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x47E7720", Offset = "0x47E6320", VA = "0x1847E7720")]
	private bool COAJAPOKPBA(AGKKNAJILID LFFMFCPJMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47E8030", Offset = "0x47E6C30", VA = "0x1847E8030")]
	private AGPICGKMALJ EABBIFFCDCC(List<DHNPMPADHKD> OLECGIIDBDA, PPLFJCKOCMN PPAJJHLLPAG)
	{
		return default(AGPICGKMALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x47E8BF0", Offset = "0x47E77F0", VA = "0x1847E8BF0")]
	private void JDGDJNDEDOE(List<DHNPMPADHKD> PDBANHEHPOA, Vector3[] HNJBCPJDIGF, Vector3[] FKIJOBFMGAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OFKOBALBFIH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x47E7570", Offset = "0x47E6170", VA = "0x1847E7570")]
	public static Bounds GHGNJAMCBME(List<DHNPMPADHKD> PDBANHEHPOA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x47E73E0", Offset = "0x47E5FE0", VA = "0x1847E73E0")]
	public static int BCJKBDFBBAI(List<DHNPMPADHKD> PDBANHEHPOA, KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MIJCCLLMOIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private BNNFCKHAFIM ECBLLNHPOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BNNFCKHAFIM CNNBEEGPGIN;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static BNNFCKHAFIM BALJPNKLKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PJPFILBCJIH PPLBDEDPBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private OMMMHMLCNLM EPJIANIGJCO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle NKBLFABEMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA60", Offset = "0x8FC660", VA = "0x1808FDA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KNKAPIEOCFE.NPJPEGNNILK LFFMFCPJMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IPEMKIKAENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BA890", VA = "0x1807BBC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x47E0C50", Offset = "0x47DF850", VA = "0x1847E0C50")]
	[HMEMFDNPCPH(LFKBPELDMLK.ExitingPlayMode, 0)]
	private void FBINEEIFIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x47E0CC0", Offset = "0x47DF8C0", VA = "0x1847E0CC0")]
	public void HILHGJFFAMN(KNKAPIEOCFE.NPJPEGNNILK NAIFIKIDJAO, Transform PAFFPLOLNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47E1720", Offset = "0x47E0320", VA = "0x1847E1720")]
	public void OONBNCJFPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47E0BE0", Offset = "0x47DF7E0", VA = "0x1847E0BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x47E16E0", Offset = "0x47E02E0", VA = "0x1847E16E0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47E1D10", Offset = "0x47E0910", VA = "0x1847E1D10")]
	public MIJCCLLMOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HHJEFHKOPOK
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NDCPDKHLMJO MHNHPEKOAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CDLAGICBBCK
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 COKBFEJFLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MGJDFNIJDHL
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(JBHAGEIOKBE HPKJBNLMNNG, CancellationToken DHCIMDILIGO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GEDCDBJODCK
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEDCDBJODCK FBAKEHINKOM(Action KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GEDCDBJODCK IOMGLHLOKIH(Action KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GEDCDBJODCK CMDIFDENFHK(Action KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEDCDBJODCK IGKFACHGGBI(Action KINCGCMCJLI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class HNOCKKBKFDN : GEDCDBJODCK
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class NNNLLNHJPDF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public HNOCKKBKFDN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
				public NNNLLNHJPDF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x47E5DE0", Offset = "0x47E49E0", VA = "0x1847E5DE0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x47E5E30", Offset = "0x47E4A30", VA = "0x1847E5E30")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x47E5E80", Offset = "0x47E4A80", VA = "0x1847E5E80")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> DDLCHCKNDHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action PHCPHJMMICH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action CNMPJJJDNCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private GABMMHOOOCH LFADDHEFDEM;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action ACAIBPBNIBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NMEAFFDEECG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28C46C0", Offset = "0x28C32C0", VA = "0x1828C46C0", Slot = "4")]
			public GEDCDBJODCK FBAKEHINKOM(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2307AA0", Offset = "0x23066A0", VA = "0x182307AA0", Slot = "5")]
			public GEDCDBJODCK IOMGLHLOKIH(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x256A3D0", Offset = "0x2568FD0", VA = "0x18256A3D0", Slot = "6")]
			public GEDCDBJODCK CMDIFDENFHK(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x22352F0", Offset = "0x2233EF0", VA = "0x1822352F0", Slot = "7")]
			public GEDCDBJODCK IGKFACHGGBI(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
			public HNOCKKBKFDN(Func<JobHandle> EKIPDOFMMHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x47DE1B0", Offset = "0x47DCDB0", VA = "0x1847DE1B0")]
			public void GGEBMKLJJKB(Action KIMIJNNKONC, Action GIHDFAGBDFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x47DE3E0", Offset = "0x47DCFE0", VA = "0x1847DE3E0")]
			public void JNIHJKFEBJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class LKFMFENOFAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public GEDCDBJODCK jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public LKFMFENOFAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x47E0B70", Offset = "0x47DF770", VA = "0x1847E0B70")]
			internal bool <Remove>b__0(HNOCKKBKFDN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class DONMIDEHADG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public HNOCKKBKFDN newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public DONMIDEHADG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x47DBF80", Offset = "0x47DAB80", VA = "0x1847DBF80")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<HNOCKKBKFDN> JHGJMHJCOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<HNOCKKBKFDN> KBLMIGAAEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private GECAAOLGCPI CAOKBJMLFIN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public CJIJENOMABL BDGFIKJALFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x47DEB40", Offset = "0x47DD740", VA = "0x1847DEB40")]
		public GEDCDBJODCK Add(Func<JobHandle> EKIPDOFMMHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x47DEDE0", Offset = "0x47DD9E0", VA = "0x1847DEDE0")]
		public void Remove(GEDCDBJODCK NKBLFABEMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x47DEC60", Offset = "0x47DD860", VA = "0x1847DEC60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x47DEF60", Offset = "0x47DDB60", VA = "0x1847DEF60")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x47DF130", Offset = "0x47DDD30", VA = "0x1847DF130")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x47DEC50", Offset = "0x47DD850", VA = "0x1847DEC50")]
		[CompilerGenerated]
		private void BLMMENIDCAA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GABMMHOOOCH
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GABMMHOOOCH FBAKEHINKOM(Action KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GABMMHOOOCH CLIPFONGGDI(Action KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GABMMHOOOCH IGKFACHGGBI(Action KINCGCMCJLI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class IJPAHAKEADF : GABMMHOOOCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle COAHOCPJNMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action PHCPHJMMICH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action AFPFGMKMCPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action NMEAFFDEECG;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool HBFALBKBGEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x47DEAB0", Offset = "0x47DD6B0", VA = "0x1847DEAB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2307AA0", Offset = "0x23066A0", VA = "0x182307AA0", Slot = "4")]
			public GABMMHOOOCH FBAKEHINKOM(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x256A3D0", Offset = "0x2568FD0", VA = "0x18256A3D0", Slot = "5")]
			public GABMMHOOOCH CLIPFONGGDI(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x22352F0", Offset = "0x2233EF0", VA = "0x1822352F0", Slot = "6")]
			public GABMMHOOOCH IGKFACHGGBI(Action KINCGCMCJLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
			public IJPAHAKEADF(JobHandle KDCIEKNBDGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x47DEB00", Offset = "0x47DD700", VA = "0x1847DEB00")]
			public void KBJMPKKPODE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x47DEAC0", Offset = "0x47DD6C0", VA = "0x1847DEAC0")]
			public void JNIHJKFEBJI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<IJPAHAKEADF> PFEGAKPBBII;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47DF5B0", Offset = "0x47DE1B0", VA = "0x1847DF5B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x47DF1F0", Offset = "0x47DDDF0", VA = "0x1847DF1F0")]
		public GABMMHOOOCH Add(JobHandle KDCIEKNBDGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x47DF4C0", Offset = "0x47DE0C0", VA = "0x1847DF4C0")]
		public void Remove(GABMMHOOOCH NKBLFABEMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x47DF360", Offset = "0x47DDF60", VA = "0x1847DF360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x47DF280", Offset = "0x47DDE80", VA = "0x1847DF280")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x47DF6C0", Offset = "0x47DE2C0", VA = "0x1847DF6C0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47DDDE0", Offset = "0x47DC9E0", VA = "0x1847DDDE0")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47DDAB0", Offset = "0x47DC6B0", VA = "0x1847DDAB0")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
