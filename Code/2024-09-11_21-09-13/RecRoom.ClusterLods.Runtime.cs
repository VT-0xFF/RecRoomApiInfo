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
				[Cpp2IlInjected.Address(RVA = "0x6A9C140", Offset = "0x6A9A740", VA = "0x186A9C140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x17A85D0", Offset = "0x17A6BD0", VA = "0x1817A85D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6A9C100", Offset = "0x6A9A700", VA = "0x186A9C100")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8FC60", Offset = "0x6A8E260", VA = "0x186A8FC60")]
		public LODSettings OFMDADFGOCH(FDCBHIELGDB CLOHFODGPFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FC70", Offset = "0x6A8E270", VA = "0x186A8FC70")]
		public int PCKCIBPGMIP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FBC0", Offset = "0x6A8E1C0", VA = "0x186A8FBC0")]
		public int LNPGBNPDCLD(bool FDEKJDCAJPF, Vector3 MLOGMFJAHGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FC90", Offset = "0x6A8E290", VA = "0x186A8FC90")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MPAPHBONHFP
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
public interface COHIMFBCGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACLMOFJBHFB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MJLJDHGGJAI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MHONKMFMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<MOAMBMMBALK> HEDCGCFNOGK
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
	void UpdateClusterDistances(Vector3 NJELOECLOIL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(EKCACEEIPAG INEJDODHNGG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MOAMBMMBALK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int KCIKJBNFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JOKMOKEKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float EAHNBEMDIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CGHEOIKNBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte FNFDEGAGMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BIKPBGEGDJK
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Control,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LowQualityShadow
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FLBLMOOLNHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DLJHPBIFOKO
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
	private struct MIAGJPJLFGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FLBLMOOLNHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public APPPBJLIGLH<string>.LANPOEPHMID stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private APPPBJLIGLH<string>.LANPOEPHMID <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CF40", Offset = "0x6A9B540", VA = "0x186A9CF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D6D0", Offset = "0x6A9BCD0", VA = "0x186A9D6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GLMIMNDMELF : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FLBLMOOLNHI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public GLMIMNDMELF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A94B80", Offset = "0x6A93180", VA = "0x186A94B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A94C90", Offset = "0x6A93290", VA = "0x186A94C90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KJJBAHGACBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FLBLMOOLNHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public APPPBJLIGLH<string>.LANPOEPHMID worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private APPPBJLIGLH<string>.LANPOEPHMID <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A99B10", Offset = "0x6A98110", VA = "0x186A99B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B350", Offset = "0x6A99950", VA = "0x186A9B350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LJHPLBFIBPF : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FLBLMOOLNHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public LJHPLBFIBPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B3D0", Offset = "0x6A999D0", VA = "0x186A9B3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C0B0", Offset = "0x6A9A6B0", VA = "0x186A9C0B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const int LCMCPMPDGKM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly TimeSpan OCKAKIKFCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ClusterMeshRenderer PJGAFFINCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MeshFilter IIAHGDJPIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GameObject DAGJFAGLFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject LNLNODGKGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public MFFOBMJGBLI FDHCICJJGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<EKCACEEIPAG> GHNKIBEEODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<EKCACEEIPAG> PAMKLEJBHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<EKCACEEIPAG> NMBPODBHOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int MNBGKMOCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DLJHPBIFOKO JDNPCCMBMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public List<MJLJDHGGJAI>[] KJHCJGALMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private List<MOAMBMMBALK>[] DEKOIFNKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CancellationTokenSource LFIBMEEKLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool BEKEDFBHMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EPGCCCKMEBG FENBPFMINME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EPGCCCKMEBG JJJAJFDEHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int FLMCDGPJMLN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static FLBLMOOLNHI MBANBAPHHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HPGKDDIOICK KLADNMMKCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OAGOHDDBALM MBJPNELOPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MonoBehaviour ADCHINCLMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Material DPBNJPEKAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Material KJKAFDIGCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material MALANHBHMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public BIKPBGEGDJK MMGMDAIALAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<COHIMFBCGOO> GPJKPFMHBHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig HNBIEIKEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 OGDOHEJENPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x897540", Offset = "0x895B40", VA = "0x180897540")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8971A0", Offset = "0x8957A0", VA = "0x1808971A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private DLJHPBIFOKO ACNJIHOGKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92CD40", Offset = "0x92B340", VA = "0x18092CD40")]
		get
		{
			return default(DLJHPBIFOKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A93330", Offset = "0x6A91930", VA = "0x186A93330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static FLBLMOOLNHI DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A932E0", Offset = "0x6A918E0", VA = "0x186A932E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool LPMNAAGEMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A934A0", Offset = "0x6A91AA0", VA = "0x186A934A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PPAEHNPHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A93D10", Offset = "0x6A92310", VA = "0x186A93D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> ACHEFBDCGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A91570", Offset = "0x6A8FB70", VA = "0x186A91570")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A93940", Offset = "0x6A91F40", VA = "0x186A93940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JEPMAIAGEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A91C60", Offset = "0x6A90260", VA = "0x186A91C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A928D0", Offset = "0x6A90ED0", VA = "0x186A928D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A943D0", Offset = "0x6A929D0", VA = "0x186A943D0")]
	public FLBLMOOLNHI(HPGKDDIOICK KLADNMMKCHI, OAGOHDDBALM MBJPNELOPKH, ClusterLODConfig PDIEOLLJNLO, MonoBehaviour ADCHINCLMPK, Material DPBNJPEKAFH, ClusterMeshRenderer PJGAFFINCPF, MeshFilter IIAHGDJPIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A941D0", Offset = "0x6A927D0", VA = "0x186A941D0")]
	public void PDLHGHPCLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A91F80", Offset = "0x6A90580", VA = "0x186A91F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A92750", Offset = "0x6A90D50", VA = "0x186A92750")]
	public static void EPAJFBLBNAC(Vector3 KOIOFHPANBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A92840", Offset = "0x6A90E40", VA = "0x186A92840")]
	private void FBGLDGGGFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B20", Offset = "0x6A92120", VA = "0x186A93B20")]
	private void OBNGNKIOIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A91A90", Offset = "0x6A90090", VA = "0x186A91A90")]
	private void DEMCPIOLKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A92080", Offset = "0x6A90680", VA = "0x186A92080")]
	public void EAOAOBMCEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A93A00", Offset = "0x6A92000", VA = "0x186A93A00")]
	[AsyncStateMachine(typeof(MIAGJPJLFGD))]
	public Task NLHGBIFMGOM(APPPBJLIGLH<string>.LANPOEPHMID JLBGGNEPFDG, CancellationToken LBFDJGLPAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A91F00", Offset = "0x6A90500", VA = "0x186A91F00")]
	[IteratorStateMachine(typeof(GLMIMNDMELF))]
	private IEnumerator<GJDHNIMFMOA> DIKEENKEEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A93BF0", Offset = "0x6A921F0", VA = "0x186A93BF0")]
	[AsyncStateMachine(typeof(KJJBAHGACBL))]
	private Task OOEMNBMHNEN(APPPBJLIGLH<string>.LANPOEPHMID EFBHENCJNCE, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A93740", Offset = "0x6A91D40", VA = "0x186A93740")]
	public void MDOGPOLEOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A93260", Offset = "0x6A91860", VA = "0x186A93260")]
	public void HPNEMJBKGHB(IEnumerable<MJLJDHGGJAI> LPBFLKDJELG, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A91630", Offset = "0x6A8FC30", VA = "0x186A91630")]
	public void CFHLKJJOICM(IEnumerable<MJLJDHGGJAI> LPBFLKDJELG, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A92B80", Offset = "0x6A91180", VA = "0x186A92B80")]
	public List<ClusterMeshRenderer> HOMEPMDEJFD(List<EKCACEEIPAG> OFALIHPNIGC, OLHIMCMANHM JPBBEMPIGCM, MPAPHBONHFP CEEMGDGDBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A92B20", Offset = "0x6A91120", VA = "0x186A92B20")]
	public void HHOGKNGIMDD(COHIMFBCGOO GLEJBHBGBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A93DD0", Offset = "0x6A923D0", VA = "0x186A93DD0")]
	public bool OPOKHDAADMI(COHIMFBCGOO GLEJBHBGBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A92AC0", Offset = "0x6A910C0", VA = "0x186A92AC0")]
	public void HAJICHPMDAL(EKCACEEIPAG JNFACBDDCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A91E80", Offset = "0x6A90480", VA = "0x186A91E80")]
	public void DIKABLCAOMI(MOAMBMMBALK ONLDJBALHME, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A91BE0", Offset = "0x6A901E0", VA = "0x186A91BE0")]
	public void DFHAHFNJOHC(MOAMBMMBALK ONLDJBALHME, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A92980", Offset = "0x6A90F80", VA = "0x186A92980")]
	private void GOMGPJIFDCO(Vector3 NJELOECLOIL, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A91930", Offset = "0x6A8FF30", VA = "0x186A91930")]
	private void COFIGOBJOKK(Vector3 NJELOECLOIL, MPAPHBONHFP CEEMGDGDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A926D0", Offset = "0x6A90CD0", VA = "0x186A926D0")]
	[IteratorStateMachine(typeof(LJHPLBFIBPF))]
	private IEnumerator<GJDHNIMFMOA> EEJHJNHPCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A91D10", Offset = "0x6A90310", VA = "0x186A91D10")]
	private int DIBBLNFAOEH(int HGFDMIDEFHN, int EHKEACIMIHH, List<MOAMBMMBALK> PJFPNDNPDMD, byte CLOHFODGPFM, int OKOJLFFGHLF, float DEHIJAFBIHO = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A93590", Offset = "0x6A91B90", VA = "0x186A93590")]
	public void MBEEDABKNGP(EKCACEEIPAG INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A93460", Offset = "0x6A91A60", VA = "0x186A93460")]
	public bool JPLKEAGDEDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x93DC90", Offset = "0x93C290", VA = "0x18093DC90")]
	public Material HIDONMILJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8D6560", Offset = "0x8D4B60", VA = "0x1808D6560")]
	public Material JCKABGGKHPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x885E50", Offset = "0x884450", VA = "0x180885E50")]
	public Material GIHIBHILHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A94190", Offset = "0x6A92790", VA = "0x186A94190")]
	public int PCKCIBPGMIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E30", Offset = "0x6A92430", VA = "0x186A93E30")]
	public long PBJLEACBJBO()
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
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct PMLOPMACDEN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<float3> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeArray<float2> KBMEGIBEECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float4> NMFFJMEBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeList<int> HCMMOHLNFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<float3> IFNLCGDOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private float3 KPGAPMLGEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private float GPHILJJMBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeParallelMultiHashMap<int, int> DBFCFMKPFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> GGDDJFJJGDN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1890", Offset = "0x6A9FE90", VA = "0x186AA1890")]
	public PMLOPMACDEN(JOIDBGKONGK CBNKKMIFMKD, NativeList<float3> IFNLCGDOONO, NativeParallelMultiHashMap<int, int> DBFCFMKPFMG, NativeArray<int> GGDDJFJJGDN, Vector3 KPGAPMLGEHB, float GPHILJJMBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1190", Offset = "0x6A9F790", VA = "0x186AA1190")]
	private int DLODGINKFKB(float3 NJELOECLOIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1620", Offset = "0x6A9FC20", VA = "0x186AA1620")]
	private int JAENMCEEKHA(int DMIMFDDIIBO, int LFOBGDLOPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AA11F0", Offset = "0x6A9F7F0", VA = "0x186AA11F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CIKPEOJCAOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NativeParallelMultiHashMap<int, int> DBFCFMKPFMG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static NativeArray<int> GGDDJFJJGDN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int GHKLMABMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> JFADPDGJBAH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F3F0", Offset = "0x6A8D9F0", VA = "0x186A8F3F0")]
	public void HOKPIHKGMOB(int DCLJAMBNIMH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F310", Offset = "0x6A8D910", VA = "0x186A8F310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public CIKPEOJCAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct JNAPNOCAFIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeList<int> PONGLDBFKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<int> BEKCHPEKJBD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A98CA0", Offset = "0x6A972A0", VA = "0x186A98CA0")]
	public JNAPNOCAFIN(CIKPEOJCAOK KPHNIIHGEGP, JOIDBGKONGK CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A98BF0", Offset = "0x6A971F0", VA = "0x186A98BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct OFCIPBKCDOB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeList<float3> MPCMCCFINGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float3> JMALHMJAHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> ONIEKFIGDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeArray<float2> PPLHDGNCJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float4> DLHFCHEPLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<int> JFADPDGJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> PONGLDBFKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<float3> AODFDACNGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float3> AFKNDHKAKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float4> PEHODDIPAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeArray<float4> KLCHHOLHDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float2> IKJDAEAAKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<int> PFBKJPHHMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float FNMGPMNKFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	public float IGGFIJHOLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float3 PNPNJFAEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float AKPMEKOKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private float PDOGKNDKOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	public float KEEIEBHGPIH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA01D0", Offset = "0x6A9E7D0", VA = "0x186AA01D0")]
	public OFCIPBKCDOB(CIKPEOJCAOK FAHLMAAEEHE, JOIDBGKONGK CBNKKMIFMKD, JOIDBGKONGK DMPDFDFIJMN, float PDOGKNDKOIH, float KEEIEBHGPIH, Vector3 PNPNJFAEELC, float AKPMEKOKALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FDE0", Offset = "0x6A9E3E0", VA = "0x186A9FDE0")]
	private float3 IOBHEAOIJAP(int DMIMFDDIIBO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FC00", Offset = "0x6A9E200", VA = "0x186A9FC00")]
	private void GMMLMCHIEKJ(int DMIMFDDIIBO, [Out] float3 PBEFGEBNBEM, [Out] float3 JEFEPPPALCK, [Out] float4 OEAOHELPAOC, [Out] float4 LEHHBOAHKKE, [Out] float2 HEFAGEDBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EC40", Offset = "0x6A9D240", VA = "0x186A9EC40")]
	private int BHHCGHIGALK(int GIJEDBJIMPO, int PBANHLBNFKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EF30", Offset = "0x6A9D530", VA = "0x186A9EF30")]
	private void CBAMAAOMMEP(int GIJEDBJIMPO, int PBANHLBNFKJ, int OFMNIBOFEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F130", Offset = "0x6A9D730", VA = "0x186A9F130")]
	private bool CGLNBIBCEIM(int GIJEDBJIMPO, int PBANHLBNFKJ, float JKHNDBBKGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0110", Offset = "0x6A9E710", VA = "0x186AA0110")]
	private bool PDDLGFGCBEJ(int GIJEDBJIMPO, int PBANHLBNFKJ, int OFMNIBOFEDG, float JKHNDBBKGBP, bool GJCOLEMMKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FE90", Offset = "0x6A9E490", VA = "0x186A9FE90")]
	private bool LAIKBIAHLKP(int GIJEDBJIMPO, int PBANHLBNFKJ, int OFMNIBOFEDG, float JKHNDBBKGBP, bool GJCOLEMMKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AA00F0", Offset = "0x6A9E6F0", VA = "0x186AA00F0")]
	private void MOKBBGFILOA(int GIJEDBJIMPO, int PBANHLBNFKJ, int OFMNIBOFEDG, [Out] int GMPGIEIDJGK, [Out] int EBBACGDFKMJ, [Out] int PIABEFEICKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F280", Offset = "0x6A9D880", VA = "0x186A9F280", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HJMOEJMKLEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PMLGAHMGNJJ : IDisposable, MOAMBMMBALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Bounds NPJFCGGHGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public List<EKCACEEIPAG> OFALIHPNIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3 LHMKPPMDGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Vector3 DKOOOHMLEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int HKPGACDOALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JOIDBGKONGK FJPCMKGPIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long JJDHEJEGOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CIKPEOJCAOK DLJODLLKEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Transform JPBBEMPIGCM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int ILIBKOFLCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6AA0B70", Offset = "0x6A9F170", VA = "0x186AA0B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh DKLBGEEBHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh ABBHHDGNGOH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EAHNBEMDIFI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2C90", Offset = "0x9F1290", VA = "0x1809F2C90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x60F3C60", Offset = "0x60F2260", VA = "0x1860F3C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte FNFDEGAGMKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FA9E0", VA = "0x1808FC3E0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3A0", Offset = "0x8FA9A0", VA = "0x1808FC3A0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KCIKJBNFDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9099E0", Offset = "0x907FE0", VA = "0x1809099E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9089E0", Offset = "0x906FE0", VA = "0x1809089E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int JOKMOKEKAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x105E7F0", Offset = "0x105CDF0", VA = "0x18105E7F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x105DA00", Offset = "0x105C000", VA = "0x18105DA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CGHEOIKNBJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6AA0BB0", Offset = "0x6A9F1B0", VA = "0x186AA0BB0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0D80", Offset = "0x6A9F380", VA = "0x186AA0D80")]
		public void EDOOAKGCPDA(FDCBHIELGDB CLOHFODGPFM, [Out] int KNHJBDAHGAE, [Out] int EHANMNGLAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0910", Offset = "0x6A9EF10", VA = "0x186AA0910")]
		public void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0FF0", Offset = "0x6A9F5F0", VA = "0x186AA0FF0")]
		public void HGJBCALAFIH(Mesh CBNKKMIFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0AE0", Offset = "0x6A9F0E0", VA = "0x186AA0AE0")]
		public void BPODFFLEGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0BD0", Offset = "0x6A9F1D0", VA = "0x186AA0BD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1090", Offset = "0x6A9F690", VA = "0x186AA1090")]
		public PMLGAHMGNJJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Bounds NPJFCGGHGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<PMLGAHMGNJJ> BMNFLPICOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public BJNJBNJEEDP EKFJADCFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ClusterMeshRenderer KOIICEKKKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int KLBKKHJCCJH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PEHFBBMHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB77770", Offset = "0xB75D70", VA = "0x180B77770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF80", Offset = "0xC69580", VA = "0x180C6AF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int MHONKMFMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A97530", Offset = "0x6A95B30", VA = "0x186A97530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A97580", Offset = "0x6A95B80", VA = "0x186A97580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A97700", Offset = "0x6A95D00", VA = "0x186A97700")]
	public int JBALEOHNBLP(int IFIKEPDNMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A979A0", Offset = "0x6A95FA0", VA = "0x186A979A0")]
	public void MEKINDHDCLM(ENNKIPDEGAB JCCIIOPJHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A97B80", Offset = "0x6A96180", VA = "0x186A97B80")]
	public void MGHDFAMKABM(Transform FBHNHMNFBHE, bool MKCNDIPOMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A97370", Offset = "0x6A95970", VA = "0x186A97370")]
	public bool BKILDAHBHFL(bool FLAEALAKHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A98300", Offset = "0x6A96900", VA = "0x186A98300")]
	public void PFJNCGJGFMC(Transform JPBBEMPIGCM, bool MKCNDIPOMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A97730", Offset = "0x6A95D30", VA = "0x186A97730")]
	public bool MBEEDABKNGP(EKCACEEIPAG INEJDODHNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A98920", Offset = "0x6A96F20", VA = "0x186A98920")]
	public HJMOEJMKLEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MFFOBMJGBLI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Queue<HJMOEJMKLEA.PMLGAHMGNJJ> MBLMNNONLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private NMLCLNEIFKO IMJEIKHEEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<HJMOEJMKLEA.PMLGAHMGNJJ> NFCMPELMBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int AKCBGPKJMOB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C340", Offset = "0x6A9A940", VA = "0x186A9C340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C990", Offset = "0x6A9AF90", VA = "0x186A9C990")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C3F0", Offset = "0x6A9A9F0", VA = "0x186A9C3F0")]
	public void FABNFHGMHGJ(HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC, Transform JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C7B0", Offset = "0x6A9ADB0", VA = "0x186A9C7B0")]
	public void MBEEDABKNGP(HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C200", Offset = "0x6A9A800", VA = "0x186A9C200")]
	private HJMOEJMKLEA.PMLGAHMGNJJ BHDMMCENEMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C160", Offset = "0x6A9A760", VA = "0x186A9C160")]
	private bool BGHFDJMPNLM(HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA10", Offset = "0x6A9B010", VA = "0x186A9CA10")]
	private void ODMPPAFENIL(HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C3C0", Offset = "0x6A9A9C0", VA = "0x186A9C3C0")]
	public bool EMDCIEBBHDL(HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C520", Offset = "0x6A9AB20", VA = "0x186A9C520")]
	public bool KOLHFLEMELG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C4B0", Offset = "0x6A9AAB0", VA = "0x186A9C4B0")]
	private HJMOEJMKLEA.PMLGAHMGNJJ FLOIBAEPJPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA70", Offset = "0x6A9B070", VA = "0x186A9CA70")]
	public long PBJLEACBJBO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CD90", Offset = "0x6A9B390", VA = "0x186A9CD90")]
	public MFFOBMJGBLI()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OKJDONDFHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int HBPMHLJPKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int IDGEBOHMHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float ENPKGFNGPAM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<HJMOEJMKLEA> NFLIAGPEEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AA08C0", Offset = "0x6A9EEC0", VA = "0x186AA08C0")]
	public OKJDONDFHAE(int HBPMHLJPKLP, int IDGEBOHMHGA, float OOKFGAILOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0310", Offset = "0x6A9E910", VA = "0x186AA0310")]
	public void AGFBCENMADJ(BNOPDIODHLG JCDJJBKFFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0810", Offset = "0x6A9EE10", VA = "0x186AA0810")]
	private int NLPJFDINIGH(ENNKIPDEGAB KOHLOCENPAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA03C0", Offset = "0x6A9E9C0", VA = "0x186AA03C0")]
	private void AGFBCENMADJ(ENNKIPDEGAB KOHLOCENPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA05D0", Offset = "0x6A9EBD0", VA = "0x186AA05D0")]
	private void CDKJCJINBEJ(ENNKIPDEGAB KOHLOCENPAH, HJMOEJMKLEA IOHAJGEDABJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ClusterMeshRenderer : MonoBehaviour, MJLJDHGGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HPJNOCFMMCE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
			[DebuggerHidden]
			public HPJNOCFMMCE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6A989E0", Offset = "0x6A96FE0", VA = "0x186A989E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6A98BA0", Offset = "0x6A971A0", VA = "0x186A98BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A98AF0", Offset = "0x6A970F0", VA = "0x186A98AF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6A98AF0", Offset = "0x6A970F0", VA = "0x186A98AF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int MHONKMFMOCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6A913E0", Offset = "0x6A8F9E0", VA = "0x186A913E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<MOAMBMMBALK> HEDCGCFNOGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6A913C0", Offset = "0x6A8F9C0", VA = "0x186A913C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> BMNFLPICOBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public HJMOEJMKLEA JPMOJDIJBBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MPAPHBONHFP NEKLLBJDKJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(MPAPHBONHFP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x887000", Offset = "0x885600", VA = "0x180887000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool CCFAAOJNFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1D62970", Offset = "0x1D60F70", VA = "0x181D62970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FCF0", Offset = "0x6A8E2F0", VA = "0x186A8FCF0")]
		public static ClusterMeshRenderer Create(HJMOEJMKLEA CBNKKMIFMKD, ClusterMeshRenderer PJGAFFINCPF, MeshFilter IIAHGDJPIGB, OLHIMCMANHM JPBBEMPIGCM, MPAPHBONHFP CEEMGDGDBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A90050", Offset = "0x6A8E650", VA = "0x186A90050", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A90930", Offset = "0x6A8EF30", VA = "0x186A90930", Slot = "9")]
		public bool TryRemoveClusterLODComponent(EKCACEEIPAG INEJDODHNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A906E0", Offset = "0x6A8ECE0", VA = "0x186A906E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A902C0", Offset = "0x6A8E8C0", VA = "0x186A902C0")]
		public void Init(HJMOEJMKLEA CBNKKMIFMKD, MeshFilter IIAHGDJPIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A900B0", Offset = "0x6A8E6B0", VA = "0x186A900B0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A909F0", Offset = "0x6A8EFF0", VA = "0x186A909F0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 NJELOECLOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A90CA0", Offset = "0x6A8F2A0", VA = "0x186A90CA0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A90240", Offset = "0x6A8E840", VA = "0x186A90240")]
		[IteratorStateMachine(typeof(HPJNOCFMMCE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A90770", Offset = "0x6A8ED70", VA = "0x186A90770")]
		public void SetupTagAndLayer(string BAKDDABGCNF, int CEEMGDGDBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A90750", Offset = "0x6A8ED50", VA = "0x186A90750")]
		public bool Remove(EKCACEEIPAG INEJDODHNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KKJEFIIOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int JFHFKBGBPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int NBPJLJIBBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int EHANMNGLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KNHJBDAHGAE;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B3B0", Offset = "0x6A999B0", VA = "0x186A9B3B0")]
	public KKJEFIIOKKE(int NBPJLJIBBHP, int EHANMNGLAMC, int JFHFKBGBPFN, int KNHJBDAHGAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BJNJBNJEEDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<float3> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<int> JFADPDGJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<int> HCMMOHLNFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<KKJEFIIOKKE> MFNANIJJIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<int> FFJPGJNJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float3> LGCJGLJJCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<float> ICBPFOMGEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public JobHandle GDNIAPJJBPI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x93D130", Offset = "0x93B730", VA = "0x18093D130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x93E560", Offset = "0x93CB60", VA = "0x18093E560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DE40", Offset = "0x6A8C440", VA = "0x186A8DE40")]
	public void AMLGEKNOMHA(JOIDBGKONGK LIKPPJOMCFI, NativeList<KKJEFIIOKKE> MFNANIJJIHP, float DKEHAFKGJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EFB0", Offset = "0x6A8D5B0", VA = "0x186A8EFB0")]
	public void OIAOLAMGFOI(Transform JPBBEMPIGCM, bool MKCNDIPOMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ECD0", Offset = "0x6A8D2D0", VA = "0x186A8ECD0")]
	public void BKILDAHBHFL(HJMOEJMKLEA KOIICEKKKHA, bool FLAEALAKHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EE70", Offset = "0x6A8D470", VA = "0x186A8EE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EF80", Offset = "0x6A8D580", VA = "0x186A8EF80")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public BJNJBNJEEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
public struct CMHFMLCGIKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	public NativeList<int> JFADPDGJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<KKJEFIIOKKE> PMKJDIEHDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeArray<int> FFJPGJNJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float3 PNPNJFAEELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<float3> LGCJGLJJCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private NativeArray<float> ICBPFOMGEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private bool MKCNDIPOMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float IBMIJGNLFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float KDFLJILPGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float EMADEEJOKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeList<int> HCMMOHLNFNH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FAF0", Offset = "0x6A8E0F0", VA = "0x186A8FAF0")]
	public CMHFMLCGIKN(BJNJBNJEEDP NDDHDNJFKFA, Vector3 PNPNJFAEELC, bool MKCNDIPOMMG, float IBMIJGNLFND, float KDFLJILPGPC, float EMADEEJOKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F5E0", Offset = "0x6A8DBE0", VA = "0x186A8F5E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EKCACEEIPAG : AGHAKNFLOIH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds JFPFHENAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ENNKIPDEGAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<EKCACEEIPAG> OFALIHPNIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public ENNKIPDEGAB LDJCBIBELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public ENNKIPDEGAB GIHCBFKHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public ENNKIPDEGAB FPNIEKLPPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public int KNHJBDAHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Bounds NPJFCGGHGEI;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A914F0", Offset = "0x6A8FAF0", VA = "0x186A914F0")]
	public ENNKIPDEGAB(List<EKCACEEIPAG> OFALIHPNIGC, [Optional] ENNKIPDEGAB LDJCBIBELIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BNOPDIODHLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<ENNKIPDEGAB> FOMMDHONEKB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ENNKIPDEGAB GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F240", Offset = "0x6A8D840", VA = "0x186A8F240")]
	public BNOPDIODHLG(ENNKIPDEGAB JPBBEMPIGCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HFOFOAHHCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct ANCOGKEFEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int ILIGDEEHPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int LEHAPDLFMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int FLOPNMPICPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int GKFOONGBDPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct NABPMGAHHPM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DHBLKDLCGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float NIDJFIIDFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<EKCACEEIPAG> OFALIHPNIGC;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A9DAD0", Offset = "0x6A9C0D0", VA = "0x186A9DAD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum KENIMBANHAC
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
	private ANCOGKEFEMJ CCFBJFIBAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int DAHBJMNECHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int HBPMHLJPKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int IDGEBOHMHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float OOKFGAILOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float EEEOCIAHBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Stack<ENNKIPDEGAB> ILEMIAJPDKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BNOPDIODHLG DKPOFJGADEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A97310", Offset = "0x6A95910", VA = "0x186A97310")]
	public HFOFOAHHCBB(int HBPMHLJPKLP, int IDGEBOHMHGA, float OOKFGAILOOM, int DAHBJMNECHO, float EEEOCIAHBKB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A96700", Offset = "0x6A94D00", VA = "0x186A96700")]
	public void DJKGNPNJPIB(List<EKCACEEIPAG> OFALIHPNIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A968D0", Offset = "0x6A94ED0", VA = "0x186A968D0")]
	public bool EIJCBKIGONC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A972A0", Offset = "0x6A958A0", VA = "0x186A972A0")]
	private float NGFCLMJGMDB(Vector3 GDAPDOPOOAD, Vector3 EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A972F0", Offset = "0x6A958F0", VA = "0x186A972F0")]
	private float NGFCLMJGMDB(Vector3 BHEAFIOEIAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A96940", Offset = "0x6A94F40", VA = "0x186A96940")]
	private bool JBIDNOEAPCO(ENNKIPDEGAB CHCBODAEMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A95190", Offset = "0x6A93790", VA = "0x186A95190")]
	private NABPMGAHHPM ALPENAJCGEL(List<EKCACEEIPAG> DHAEPFMPNBC, KENIMBANHAC ONLKOIGBDGH)
	{
		return default(NABPMGAHHPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A96320", Offset = "0x6A94920", VA = "0x186A96320")]
	private void COJMAFICPGC(List<EKCACEEIPAG> OFALIHPNIGC, Span<Vector3> MEJLDLMFEIG, Span<Vector3> DNAMBBLGMND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class MKPHDKLFAFH
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D730", Offset = "0x6A9BD30", VA = "0x186A9D730")]
	public static Bounds DOKFPAELOEI(List<EKCACEEIPAG> OFALIHPNIGC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D900", Offset = "0x6A9BF00", VA = "0x186A9D900")]
	public static int GAFHMPPANPN(List<EKCACEEIPAG> OFALIHPNIGC, FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NMLCLNEIFKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private JOIDBGKONGK FBGDPEGBOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JOIDBGKONGK MGCCKCHFCNB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static JOIDBGKONGK BKENMJOHCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FJFLFEFKGGD FCAPBHNHPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private HKJIDIEMGKL MLDLLLNAJIB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle GDNIAPJJBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x96B660", Offset = "0x969C60", VA = "0x18096B660")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x96B4B0", Offset = "0x969AB0", VA = "0x18096B4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HJMOEJMKLEA.PMLGAHMGNJJ CHCBODAEMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MMMCCHPALMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x19842E0", Offset = "0x19828E0", VA = "0x1819842E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E440", Offset = "0x6A9CA40", VA = "0x186A9E440")]
	[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
	private static void GPBIOEBJOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DB40", Offset = "0x6A9C140", VA = "0x186A9DB40")]
	public void AMLGEKNOMHA(HJMOEJMKLEA.PMLGAHMGNJJ PMKJDIEHDGF, Transform PBAMPJCEODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E4B0", Offset = "0x6A9CAB0", VA = "0x186A9E4B0")]
	public void LEEEKJGFELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E3D0", Offset = "0x6A9C9D0", VA = "0x186A9E3D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EB50", Offset = "0x6A9D150", VA = "0x186A9EB50")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EB90", Offset = "0x6A9D190", VA = "0x186A9EB90")]
	public NMLCLNEIFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OAGOHDDBALM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 EGAOBHELOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HPGKDDIOICK
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(APPPBJLIGLH<string>.LANPOEPHMID EFBHENCJNCE, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OCGODPNCCPB
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCGODPNCCPB FMEKFCHBPDC(Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OCGODPNCCPB EJKILIEPOEH(Action PMCMEAHOBEF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class HCCGOKBLGLP : OCGODPNCCPB
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BCJAEAGEPGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public HCCGOKBLGLP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
				public BCJAEAGEPGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6A8DDF0", Offset = "0x6A8C3F0", VA = "0x186A8DDF0")]
				internal void LDAAEPAGNNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6A8DD50", Offset = "0x6A8C350", VA = "0x186A8DD50")]
				internal void HHABCBDKBOA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x6A8DDA0", Offset = "0x6A8C3A0", VA = "0x186A8DDA0")]
				internal void JKDNKOGJBMC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private Func<JobHandle> PJJGNKNLBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private Action IEDHMPHMFPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action LAKCNNALJEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private GGNPEEHPPDM JACOJLPEOGP;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action LPBMIMKINOE
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action PDDCCOAGEII
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3D85990", Offset = "0x3D83F90", VA = "0x183D85990", Slot = "4")]
			public OCGODPNCCPB FMEKFCHBPDC(Action PMCMEAHOBEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x655CE00", Offset = "0x655B400", VA = "0x18655CE00", Slot = "5")]
			public OCGODPNCCPB EJKILIEPOEH(Action PMCMEAHOBEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
			public HCCGOKBLGLP(Func<JobHandle> HNABKDPGPHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6A94D40", Offset = "0x6A93340", VA = "0x186A94D40")]
			public void CKOMBPKHALD(Action LPMDGGJANDF, Action LFKCPCOLLEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6A95000", Offset = "0x6A93600", VA = "0x186A95000")]
			public void MBEEDABKNGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class NMCNPHCKPDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public OCGODPNCCPB jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NMCNPHCKPDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DB30", Offset = "0x6A9C130", VA = "0x186A9DB30")]
			internal bool KJBJOJFFKPM(HCCGOKBLGLP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class GPDGNPOINKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public HCCGOKBLGLP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GPDGNPOINKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6A94CE0", Offset = "0x6A932E0", VA = "0x186A94CE0")]
			internal void COHNFGBCJPP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Queue<HCCGOKBLGLP> EMEPMGJHDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<HCCGOKBLGLP> PADEOLHBOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private EPGCCCKMEBG POOCBJJGPCD;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BLNALHAOEHI KJCKHPOEFBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A98CD0", Offset = "0x6A972D0", VA = "0x186A98CD0")]
		public OCGODPNCCPB Add(Func<JobHandle> HNABKDPGPHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A99000", Offset = "0x6A97600", VA = "0x186A99000")]
		public void Remove(OCGODPNCCPB GDNIAPJJBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A98E30", Offset = "0x6A97430", VA = "0x186A98E30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A991D0", Offset = "0x6A977D0", VA = "0x186A991D0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A99430", Offset = "0x6A97A30", VA = "0x186A99430")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A98E20", Offset = "0x6A97420", VA = "0x186A98E20")]
		[CompilerGenerated]
		private void IDFKMKHNNCL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GGNPEEHPPDM
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGNPEEHPPDM FMEKFCHBPDC(Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGNPEEHPPDM HOPLCOHMNEL(Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GGNPEEHPPDM EJKILIEPOEH(Action PMCMEAHOBEF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class DIPIDMAFNNI : GGNPEEHPPDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private JobHandle GJPAGFHICLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Action IEDHMPHMFPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Action IAPLAOKPJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private Action PDDCCOAGEII;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool EPAOBLINODJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x6A91490", Offset = "0x6A8FA90", VA = "0x186A91490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x646F2E0", Offset = "0x646D8E0", VA = "0x18646F2E0", Slot = "4")]
			public GGNPEEHPPDM FMEKFCHBPDC(Action PMCMEAHOBEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x646F300", Offset = "0x646D900", VA = "0x18646F300", Slot = "5")]
			public GGNPEEHPPDM HOPLCOHMNEL(Action PMCMEAHOBEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x655CE00", Offset = "0x655B400", VA = "0x18655CE00", Slot = "6")]
			public GGNPEEHPPDM EJKILIEPOEH(Action PMCMEAHOBEF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x9669E0", Offset = "0x964FE0", VA = "0x1809669E0")]
			public DIPIDMAFNNI(JobHandle LNAMAEIHJIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6A91440", Offset = "0x6A8FA40", VA = "0x186A91440")]
			public void IKFNBHIKIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6A914A0", Offset = "0x6A8FAA0", VA = "0x186A914A0")]
			public void MBEEDABKNGP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<DIPIDMAFNNI> GBIBCDFOCLJ;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A99930", Offset = "0x6A97F30", VA = "0x186A99930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A99510", Offset = "0x6A97B10", VA = "0x186A99510")]
		public GGNPEEHPPDM Add(JobHandle LNAMAEIHJIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A99830", Offset = "0x6A97E30", VA = "0x186A99830")]
		public void Remove(GGNPEEHPPDM GDNIAPJJBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A99680", Offset = "0x6A97C80", VA = "0x186A99680", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A995B0", Offset = "0x6A97BB0", VA = "0x186A995B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A99A70", Offset = "0x6A98070", VA = "0x186A99A70")]
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
