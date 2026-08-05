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
				[Cpp2IlInjected.Address(RVA = "0x82100F0", Offset = "0x820EAF0", VA = "0x1882100F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xEF2420", Offset = "0xEF0E20", VA = "0x180EF2420")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x82100B0", Offset = "0x820EAB0", VA = "0x1882100B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81FBEC0", Offset = "0x81FA8C0", VA = "0x1881FBEC0")]
		public LODSettings NKKPIMEPIND(EIHDKHJAFNC JLNNLJBBHIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81FBEA0", Offset = "0x81FA8A0", VA = "0x1881FBEA0")]
		public int LKEMJCIOLJB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81FBE00", Offset = "0x81FA800", VA = "0x1881FBE00")]
		public int KMCCMOOMJNJ(bool LKFCNDKEPEK, Vector3 POBHLNNBGDG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81FBED0", Offset = "0x81FA8D0", VA = "0x1881FBED0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CAMOOHLIHDO
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
public interface MPODEJOJOCE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJNCIDGCKKP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IELLNPABAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PNKJKLAEDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<DMMMHJLIOBO> JHCLODNKEBB
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
	void UpdateClusterDistances(Vector3 FBHMIIMHGKJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(HGJMBBNIBNL BIMLKJFNDFP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DMMMHJLIOBO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int JDIDICNNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int ABKAKIGBDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HGFIBGEPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GICLEIBPGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte OFFDMJOKLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FPFLBGGGAOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum MMPCHBDPHMN
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
	private struct BHHMGHAEFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FPFLBGGGAOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81FB390", Offset = "0x81F9D90", VA = "0x1881FB390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81FBB20", Offset = "0x81FA520", VA = "0x1881FBB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EMDDHCMEONL : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FPFLBGGGAOH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public EMDDHCMEONL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81FF010", Offset = "0x81FDA10", VA = "0x1881FF010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81FF140", Offset = "0x81FDB40", VA = "0x1881FF140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HNNKNPJHPLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public FPFLBGGGAOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OGMJCPNEHOO<string>.LOEEEDILNMC worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OGMJCPNEHOO<string>.LOEEEDILNMC <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8208170", Offset = "0x8206B70", VA = "0x188208170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82099D0", Offset = "0x82083D0", VA = "0x1882099D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GNHIILJHKFE : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FPFLBGGGAOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public GNHIILJHKFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8205CA0", Offset = "0x82046A0", VA = "0x188205CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8206990", Offset = "0x8205390", VA = "0x188206990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EFPICDNMGDD = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan CDNBKMMAMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer IBGPHNAEBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter PELELCONDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject PMOMOEFLHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject NDNBHHFMDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FNBOADEEKHE JDKJHFPPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<HGJMBBNIBNL> CHGCPJBEMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<HGJMBBNIBNL> NNHOKOMJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<HGJMBBNIBNL> DIANEFKAHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DCHGFOMNPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MMPCHBDPHMN CBJGEFIFDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<IELLNPABAAP>[] LIJOKCLGDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<DMMMHJLIOBO>[] KHMHHNKOAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource OHKGCMDOCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool PLBNDFKMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NNFEFJFFOPD BLBHMPBPECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NNFEFJFFOPD DCJLHDCDPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int AINHJEHENCK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static FPFLBGGGAOH PJHDALLIBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GOKHCIKBGOF AGPBMNLIJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DHCNCAMKDID MPCEMCFFGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour FIOFKDDPOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material NPPANOEMJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> JGCNNAOCGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material ICCLFOPOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> DGPAHCKEJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ALLHBMCGADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<MPODEJOJOCE> OGLDJEKEFFB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MHEGDPPAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 MIDFKEFIDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x208A260", Offset = "0x2088C60", VA = "0x18208A260")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x208A180", Offset = "0x2088B80", VA = "0x18208A180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MMPCHBDPHMN OAEHBIFLJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x108BC20", Offset = "0x108A620", VA = "0x18108BC20")]
		get
		{
			return default(MMPCHBDPHMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8204030", Offset = "0x8202A30", VA = "0x188204030")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static FPFLBGGGAOH NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8203C70", Offset = "0x8202670", VA = "0x188203C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool NMOFEMIFMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8203A00", Offset = "0x8202400", VA = "0x188203A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JAAOGFGCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8203DB0", Offset = "0x82027B0", VA = "0x188203DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> PBJGLJBKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8203BB0", Offset = "0x82025B0", VA = "0x188203BB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8204900", Offset = "0x8203300", VA = "0x188204900")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CLBKNFKCGON
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8203B00", Offset = "0x8202500", VA = "0x188203B00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8202730", Offset = "0x8201130", VA = "0x188202730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8205510", Offset = "0x8203F10", VA = "0x188205510")]
	public FPFLBGGGAOH(GOKHCIKBGOF AGPBMNLIJPE, DHCNCAMKDID MPCEMCFFGMF, ClusterLODConfig MFJHCJFCKNH, MonoBehaviour FIOFKDDPOKI, Material JDGGDIGBCFP, ClusterMeshRenderer IBGPHNAEBJI, MeshFilter PELELCONDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82045F0", Offset = "0x8202FF0", VA = "0x1882045F0")]
	private void OAGOOKLGIGH(Material JDGGDIGBCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8202DF0", Offset = "0x82017F0", VA = "0x188202DF0")]
	public void CIBJOELGNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82044C0", Offset = "0x8202EC0", VA = "0x1882044C0")]
	public void NPOGDJCJGAO(Action<Material> BNAMHOIPKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82042D0", Offset = "0x8202CD0", VA = "0x1882042D0")]
	public static NPBFOENPDFA.JHAMEPAAMGC NGBCDNPDEPE(NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL)
	{
		return default(NPBFOENPDFA.JHAMEPAAMGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8203210", Offset = "0x8201C10", VA = "0x188203210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82049C0", Offset = "0x82033C0", VA = "0x1882049C0")]
	public static void PELBNAODKGO(Vector3 FOMBPADOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8203D20", Offset = "0x8202720", VA = "0x188203D20")]
	private void JJCBOLHAGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82053D0", Offset = "0x8203DD0", VA = "0x1882053D0")]
	private void POLDIHFIPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8204AC0", Offset = "0x82034C0", VA = "0x188204AC0")]
	private void PFHOAIACABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82020D0", Offset = "0x8200AD0", VA = "0x1882020D0")]
	public void ABDBNHJBLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8203EB0", Offset = "0x82028B0", VA = "0x188203EB0")]
	[AsyncStateMachine(typeof(BHHMGHAEFNK))]
	public Task MAOGOJFGFHB(OGMJCPNEHOO<string>.LOEEEDILNMC NICICOCDKBF, CancellationToken BOJKDJLCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8203980", Offset = "0x8202380", VA = "0x188203980")]
	[IteratorStateMachine(typeof(EMDDHCMEONL))]
	private IEnumerator<BHOPOIJKEJE> GGOMPBEGEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8204760", Offset = "0x8203160", VA = "0x188204760")]
	[AsyncStateMachine(typeof(HNNKNPJHPLO))]
	private Task OEJHAFIMFLL(OGMJCPNEHOO<string>.LOEEEDILNMC DDBOEKHHDFG, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8203740", Offset = "0x8202140", VA = "0x188203740")]
	public void EJGFOOMJIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8204440", Offset = "0x8202E40", VA = "0x188204440")]
	public void NOKGFBINIMI(IEnumerable<IELLNPABAAP> OMDOGPFOKAM, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8202F10", Offset = "0x8201910", VA = "0x188202F10")]
	public void DLIKEDHDGMA(IEnumerable<IELLNPABAAP> OMDOGPFOKAM, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8204C10", Offset = "0x8203610", VA = "0x188204C10")]
	public List<ClusterMeshRenderer> PIDDMPIKDIP(List<HGJMBBNIBNL> KDBFHMKODIK, JFHFHCDHJDD PJFDNMGHMBL, CAMOOHLIHDO FJOENFKFEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8205370", Offset = "0x8203D70", VA = "0x188205370")]
	public void POFNAAOLJCN(MPODEJOJOCE JENJBPGLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8203CC0", Offset = "0x82026C0", VA = "0x188203CC0")]
	public bool JHMLNEHANNA(MPODEJOJOCE JENJBPGLIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8203FD0", Offset = "0x82029D0", VA = "0x188203FD0")]
	public void MJEECFGANIH(HGJMBBNIBNL EEMIFKEIJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82052F0", Offset = "0x8203CF0", VA = "0x1882052F0")]
	public void PNMMOAEFECF(DMMMHJLIOBO LJOFOOFMAON, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8202E90", Offset = "0x8201890", VA = "0x188202E90")]
	public void DBJOIHABDHF(DMMMHJLIOBO LJOFOOFMAON, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82042F0", Offset = "0x8202CF0", VA = "0x1882042F0")]
	private void NHOBNPDBBPL(Vector3 FBHMIIMHGKJ, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82035E0", Offset = "0x8201FE0", VA = "0x1882035E0")]
	private void EHCBCMLODBJ(Vector3 FBHMIIMHGKJ, CAMOOHLIHDO FJOENFKFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8204880", Offset = "0x8203280", VA = "0x188204880")]
	[IteratorStateMachine(typeof(GNHIILJHKFE))]
	private IEnumerator<BHOPOIJKEJE> OHFNCEOINEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8204160", Offset = "0x8202B60", VA = "0x188204160")]
	private int MOOOJPOONNJ(int FILGHJLFKAL, int CBNBDCKDAJA, List<DMMMHJLIOBO> IECKDCOJFAG, byte JLNNLJBBHIC, int MLDPACGAKBK, float PAELFNEABCJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82027E0", Offset = "0x82011E0", VA = "0x1882027E0")]
	public void BBOPECIHIDA(HGJMBBNIBNL BIMLKJFNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8203940", Offset = "0x8202340", VA = "0x188203940")]
	public bool FLBGAOEGEOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xB40660", Offset = "0xB3F060", VA = "0x180B40660")]
	public Material AAMIELIIIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8202040", Offset = "0x8200A40", VA = "0x188202040")]
	public Material AAMIELIIIBC(NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xA89E90", Offset = "0xA88890", VA = "0x180A89E90")]
	public Material BGCCCGLCHPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8202D60", Offset = "0x8201760", VA = "0x188202D60")]
	public Material BGCCCGLCHPG(NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8203E70", Offset = "0x8202870", VA = "0x188203E70")]
	public int LKEMJCIOLJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8202990", Offset = "0x8201390", VA = "0x188202990")]
	public (long, int) BDJMBNHEEBG()
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
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct FGOOOPMHJAN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> LOJLNAOLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> DOHGNCCONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> FKOFOBNBDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> JCBKGPNEICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> MNAPONIFNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> BBBILFDJOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> CFOLACPNLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 BIGLLMAAHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float AGEFMHPEIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> GHPFNBFFHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> KLGKOHGLKJD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8200FA0", Offset = "0x81FF9A0", VA = "0x188200FA0")]
	public FGOOOPMHJAN(NPBFOENPDFA HFCMFMCGELA, NativeList<float3> CFOLACPNLIB, NativeParallelMultiHashMap<int, int> GHPFNBFFHHG, NativeArray<int> KLGKOHGLKJD, Vector3 BIGLLMAAHLK, float AGEFMHPEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8200CD0", Offset = "0x81FF6D0", VA = "0x188200CD0")]
	private int KMDPDJJCAIP(float3 FBHMIIMHGKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8200D30", Offset = "0x81FF730", VA = "0x188200D30")]
	private int NENNCPHPDJL(int BAMENPFPKND, int LNBCHJPEENA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82008A0", Offset = "0x81FF2A0", VA = "0x1882008A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGIBDIKAHJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> GHPFNBFFHHG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> KLGKOHGLKJD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int HKIPHPAOJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> HDCDEFPGGPP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x820E9B0", Offset = "0x820D3B0", VA = "0x18820E9B0")]
	public void CHPFNMIPGIB(int FAGHJGOAPIK, Allocator POJKLAFAMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x820EBB0", Offset = "0x820D5B0", VA = "0x18820EBB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LGIBDIKAHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct FLEFKGODLHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> CKFEPHNEPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> IOCEEAPJIGG;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8201110", Offset = "0x81FFB10", VA = "0x188201110")]
	public FLEFKGODLHK(LGIBDIKAHJE LLPJEINNICF, NPBFOENPDFA HFCMFMCGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8201060", Offset = "0x81FFA60", VA = "0x188201060", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct IDHGNIOOHMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> DCMFPIBFIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> IKLKGBNHMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> PMIGEBFMAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> NKKCMLEMAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> BJKKCDJLPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> HDCDEFPGGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> CKFEPHNEPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> EEIKCCFNKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> GDMBDKCCHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> EFFNPHALNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> OIPDMLOAGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> FDJHKJFEFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> NHFPIEFKKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float GPPBDGGKFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float BHMHEMPNMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 ACDENENFBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float FBBMFMPPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float JPMCCCNPKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float JFEGIFCHDHH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x820AFB0", Offset = "0x82099B0", VA = "0x18820AFB0")]
	public IDHGNIOOHMA(LGIBDIKAHJE AEHOKPHBKMJ, NPBFOENPDFA HFCMFMCGELA, NPBFOENPDFA ODLBALDPHCI, float JPMCCCNPKMG, float JFEGIFCHDHH, Vector3 ACDENENFBLL, float FBBMFMPPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x820AB60", Offset = "0x8209560", VA = "0x18820AB60")]
	private float3 IPFPOGONHHO(int BAMENPFPKND)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8209E00", Offset = "0x8208800", VA = "0x188209E00")]
	private void EAKAPPNICHJ(int BAMENPFPKND, [Out] float3 OLGKOJCGNJF, [Out] float3 FIJECOGCABP, [Out] float4 FFBBKCLNGAH, [Out] float4 PCPLGJLKLBL, [Out] float2 OMBEBIDOPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x820ACD0", Offset = "0x82096D0", VA = "0x18820ACD0")]
	private int PJNDJHHJJKH(int IFAEIMCDABG, int CFGAMPGGIID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x820A960", Offset = "0x8209360", VA = "0x18820A960")]
	private void IDPJGGAAOPL(int IFAEIMCDABG, int CFGAMPGGIID, int PNFBAFMKKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8209A30", Offset = "0x8208430", VA = "0x188209A30")]
	private bool AOIOCAJOBOJ(int IFAEIMCDABG, int CFGAMPGGIID, float FHCFPLPPOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x820AC10", Offset = "0x8209610", VA = "0x18820AC10")]
	private bool PEMFAPGBIKE(int IFAEIMCDABG, int CFGAMPGGIID, int PNFBAFMKKMF, float FHCFPLPPOEH, bool OKGDFAKMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8209B80", Offset = "0x8208580", VA = "0x188209B80")]
	private bool CKBCKDAAJKN(int IFAEIMCDABG, int CFGAMPGGIID, int PNFBAFMKKMF, float FHCFPLPPOEH, bool OKGDFAKMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8209DE0", Offset = "0x82087E0", VA = "0x188209DE0")]
	private void DBDCEDPBDLC(int IFAEIMCDABG, int CFGAMPGGIID, int PNFBAFMKKMF, [Out] int PCHJFEOMHKO, [Out] int HPNEEFBEDMJ, [Out] int LFFIGDIOKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8209FE0", Offset = "0x82089E0", VA = "0x188209FE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HAOMLLKHMJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class POJPBDMBBHA : IDisposable, DMMMHJLIOBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds CFBABAKNBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<HGJMBBNIBNL> KDBFHMKODIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 MGDFOIAEPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 CDHNIJFBNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int EFNLBPLIJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NPBFOENPDFA JFILJAMKHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long LMCILHMLMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LGIBDIKAHJE EBNMOLJDIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform PJFDNMGHMBL;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int AABDLKBLKKL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8210DA0", Offset = "0x820F7A0", VA = "0x188210DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh ECNJEFJOLHP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NPBFOENPDFA.JHAMEPAAMGC AIBFALLHJGE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
			[CompilerGenerated]
			get
			{
				return default(NPBFOENPDFA.JHAMEPAAMGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh OCHPDCAHFDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NPBFOENPDFA.JHAMEPAAMGC PBLPAJCNJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAF41F0", Offset = "0xAF2BF0", VA = "0x180AF41F0")]
			[CompilerGenerated]
			get
			{
				return default(NPBFOENPDFA.JHAMEPAAMGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xFA8070", Offset = "0xFA6A70", VA = "0x180FA8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HGFIBGEPCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x125C1E0", Offset = "0x125ABE0", VA = "0x18125C1E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x19E5E90", Offset = "0x19E4890", VA = "0x1819E5E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte OFFDMJOKLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E78480", Offset = "0x1E76E80", VA = "0x181E78480")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x223A850", Offset = "0x2239250", VA = "0x18223A850", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int JDIDICNNOPP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABCD50", Offset = "0xABB750", VA = "0x180ABCD50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1578540", Offset = "0x1576F40", VA = "0x181578540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ABKAKIGBDFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD1D0", Offset = "0xAABBD0", VA = "0x180AAD1D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1577D80", Offset = "0x1576780", VA = "0x181577D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GICLEIBPGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8210940", Offset = "0x820F340", VA = "0x188210940", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82106E0", Offset = "0x820F0E0", VA = "0x1882106E0")]
		public void CKNBDAAEGLP(EIHDKHJAFNC JLNNLJBBHIC, [Out] int PIPOKLJAJMO, [Out] int GICCKFBGFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8210B20", Offset = "0x820F520", VA = "0x188210B20")]
		public void GCMONHLHILI(EIHDKHJAFNC JLNNLJBBHIC, PHBEGBLLIGG IEJPPIMPMNP, int DAPCCMEPEKO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8210CF0", Offset = "0x820F6F0", VA = "0x188210CF0")]
		public void HACLDAMGMCJ(Mesh HFCMFMCGELA, NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8210650", Offset = "0x820F050", VA = "0x188210650")]
		public void BDEHAFGDMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8210960", Offset = "0x820F360", VA = "0x188210960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8210DE0", Offset = "0x820F7E0", VA = "0x188210DE0")]
		public POJPBDMBBHA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds CFBABAKNBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NPBFOENPDFA.JHAMEPAAMGC JFAIHHPNBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<POJPBDMBBHA> NCEMHHICJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LJHFHCONOFC MJMJFJGIIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer ICBGFNPAHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int JEGBDHJCEHO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OHLAJAADLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EJJKFCACIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int PNKJKLAEDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8206E40", Offset = "0x8205840", VA = "0x188206E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8207680", Offset = "0x8206080", VA = "0x188207680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8207800", Offset = "0x8206200", VA = "0x188207800")]
	public int GNPCPEJFGBC(int FIHMOHDEHAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82069E0", Offset = "0x82053E0", VA = "0x1882069E0")]
	public void AEGJOGFJBMP(JJBAHNJEKLO IKNCGJJGGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8207830", Offset = "0x8206230", VA = "0x188207830")]
	public void LKCGMNGGEPH(Transform IPNJOMDCJKL, bool PCIKEAIFDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82074C0", Offset = "0x8205EC0", VA = "0x1882074C0")]
	public bool DOLHAOCFHPP(bool HCODENJHDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8206E90", Offset = "0x8205890", VA = "0x188206E90")]
	public void DOIOCJGBHIL(Transform PJFDNMGHMBL, bool PCIKEAIFDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8206BD0", Offset = "0x82055D0", VA = "0x188206BD0")]
	public bool BBOPECIHIDA(HGJMBBNIBNL BIMLKJFNDFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8208080", Offset = "0x8206A80", VA = "0x188208080")]
	public HAOMLLKHMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FNBOADEEKHE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<HAOMLLKHMJH.POJPBDMBBHA> MDBNCMKALHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private FGJBGGEKJIP OKJNMOAJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<HAOMLLKHMJH.POJPBDMBBHA> MACJAJEPEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int PNOCNAHLKFM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82017E0", Offset = "0x82001E0", VA = "0x1882017E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8201620", Offset = "0x8200020", VA = "0x188201620")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82019C0", Offset = "0x82003C0", VA = "0x1882019C0")]
	public void MJGPLOFFIKO(HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE, Transform PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82013D0", Offset = "0x81FFDD0", VA = "0x1882013D0")]
	public void BBOPECIHIDA(HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82016A0", Offset = "0x82000A0", VA = "0x1882016A0")]
	private HAOMLLKHMJH.POJPBDMBBHA DEIEKMMGPJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x82018C0", Offset = "0x82002C0", VA = "0x1882018C0")]
	private bool FKLIHBJPJGH(HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8201960", Offset = "0x8200360", VA = "0x188201960")]
	private void LDIBPJKGPPH(HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8201A80", Offset = "0x8200480", VA = "0x188201A80")]
	public bool OELLJAAOJJE(HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8201140", Offset = "0x81FFB40", VA = "0x188201140")]
	public bool AIICKBIOPNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82015B0", Offset = "0x81FFFB0", VA = "0x1882015B0")]
	private HAOMLLKHMJH.POJPBDMBBHA BOKOMOIDALD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8201AB0", Offset = "0x82004B0", VA = "0x188201AB0")]
	public long PELIDPAAAML()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8201DD0", Offset = "0x82007D0", VA = "0x188201DD0")]
	public FNBOADEEKHE()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DPDEMDFBEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int DLCEGJHNJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int EBMNHDOCFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float FOCLLLGFIMN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<HAOMLLKHMJH> OFPIKDNNPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81FEB30", Offset = "0x81FD530", VA = "0x1881FEB30")]
	public DPDEMDFBEPD(int DLCEGJHNJKL, int EBMNHDOCFOC, float NPJBDOGGEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x81FE9E0", Offset = "0x81FD3E0", VA = "0x1881FE9E0")]
	public void DHKFNIPHPKF(CBKCKEONGMK INNBKIAIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x81FE6C0", Offset = "0x81FD0C0", VA = "0x1881FE6C0")]
	private int BPJOBCHDKLK(JJBAHNJEKLO AAPGFEFGBOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x81FE770", Offset = "0x81FD170", VA = "0x1881FE770")]
	private void DHKFNIPHPKF(JJBAHNJEKLO AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x81FEA90", Offset = "0x81FD490", VA = "0x1881FEA90")]
	private void HMCFILDOILK(JJBAHNJEKLO AAPGFEFGBOK, HAOMLLKHMJH HEKDJGDIDCL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, IELLNPABAAP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MPGCPIKAMGG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
			[DebuggerHidden]
			public MPGCPIKAMGG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8210110", Offset = "0x820EB10", VA = "0x188210110", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x82102D0", Offset = "0x820ECD0", VA = "0x1882102D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8210220", Offset = "0x820EC20", VA = "0x188210220", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8210220", Offset = "0x820EC20", VA = "0x188210220", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PNKJKLAEDCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x81FDA00", Offset = "0x81FC400", VA = "0x1881FDA00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<DMMMHJLIOBO> JHCLODNKEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x81FD9E0", Offset = "0x81FC3E0", VA = "0x1881FD9E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> NCEMHHICJDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HAOMLLKHMJH OHLAJAADLAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CAMOOHLIHDO JAOFMDLAIFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(CAMOOHLIHDO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5E0", Offset = "0xA8CFE0", VA = "0x180A8E5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EEHMGPHOAII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xDDD950", Offset = "0xDDC350", VA = "0x180DDD950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81FBF30", Offset = "0x81FA930", VA = "0x1881FBF30")]
		public static ClusterMeshRenderer Create(HAOMLLKHMJH HFCMFMCGELA, ClusterMeshRenderer IBGPHNAEBJI, MeshFilter PELELCONDEP, JFHFHCDHJDD PJFDNMGHMBL, CAMOOHLIHDO FJOENFKFEOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81FC1B0", Offset = "0x81FABB0", VA = "0x1881FC1B0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x81FCCB0", Offset = "0x81FB6B0", VA = "0x1881FCCB0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(HGJMBBNIBNL BIMLKJFNDFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81FCA60", Offset = "0x81FB460", VA = "0x1881FCA60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81FC6F0", Offset = "0x81FB0F0", VA = "0x1881FC6F0")]
		public void Init(HAOMLLKHMJH HFCMFMCGELA, MeshFilter PELELCONDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81FC210", Offset = "0x81FAC10", VA = "0x1881FC210")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81FCDE0", Offset = "0x81FB7E0", VA = "0x1881FCDE0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 FBHMIIMHGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x81FD090", Offset = "0x81FBA90", VA = "0x1881FD090", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x81FC670", Offset = "0x81FB070", VA = "0x1881FC670")]
		[IteratorStateMachine(typeof(MPGCPIKAMGG))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x81FCAF0", Offset = "0x81FB4F0", VA = "0x1881FCAF0")]
		public void SetupTagAndLayer(string FLFLJCMPPBA, int FJOENFKFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81FCAD0", Offset = "0x81FB4D0", VA = "0x1881FCAD0")]
		public bool Remove(HGJMBBNIBNL BIMLKJFNDFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HJHEEGOFJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int JNMPFOOLGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EMMDOKDGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GICCKFBGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int PIPOKLJAJMO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8208150", Offset = "0x8206B50", VA = "0x188208150")]
	public HJHEEGOFJCG(int EMMDOKDGNJD, int GICCKFBGFDH, int JNMPFOOLGPN, int PIPOKLJAJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LJHFHCONOFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> LOJLNAOLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> HDCDEFPGGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> BBBILFDJOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<HJHEEGOFJCG> GKBKJCDONBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> HPCBHLECFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> CIPAJPHDDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> AKFIPMMDAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle HADFHMENAPG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IMDHOEHLBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAB5D90", Offset = "0xAB4790", VA = "0x180AB5D90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5330", Offset = "0xAB3D30", VA = "0x180AB5330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x820EC90", Offset = "0x820D690", VA = "0x18820EC90")]
	public void CEKLAJMLNPO(NPBFOENPDFA HEPOFMHLACL, NativeList<HJHEEGOFJCG> GKBKJCDONBI, float DILGPPEHCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x820FE20", Offset = "0x820E820", VA = "0x18820FE20")]
	public void ELDKDBBFCLE(Transform PJFDNMGHMBL, bool PCIKEAIFDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x820FB70", Offset = "0x820E570", VA = "0x18820FB70")]
	public void DOLHAOCFHPP(HAOMLLKHMJH ICBGFNPAHKN, bool HCODENJHDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x820FD10", Offset = "0x820E710", VA = "0x18820FD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x820FB40", Offset = "0x820E540", VA = "0x18820FB40")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LJHFHCONOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct KFONKBFOCEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> LOJLNAOLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> HDCDEFPGGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<HJHEEGOFJCG> CPJDGEEHKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> HPCBHLECFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 ACDENENFBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> CIPAJPHDDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> AKFIPMMDAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool PCIKEAIFDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float DPPOKBHPCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float NMMCBAPLAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float IBHEHGDDFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> BBBILFDJOKE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x820E8E0", Offset = "0x820D2E0", VA = "0x18820E8E0")]
	public KFONKBFOCEB(LJHFHCONOFC FPPOMGCHMGP, Vector3 ACDENENFBLL, bool PCIKEAIFDMD, float DPPOKBHPCEP, float NMMCBAPLAJA, float IBHEHGDDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x820E3E0", Offset = "0x820CDE0", VA = "0x18820E3E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HGJMBBNIBNL : LDKLHGLOLBH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds CMGNLEPOLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JJBAHNJEKLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<HGJMBBNIBNL> KDBFHMKODIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public JJBAHNJEKLO DFKFFPKHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public JJBAHNJEKLO EEBGLIAMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public JJBAHNJEKLO FGEFMMCKJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int PIPOKLJAJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds CFBABAKNBDK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x820B0F0", Offset = "0x8209AF0", VA = "0x18820B0F0")]
	public JJBAHNJEKLO(List<HGJMBBNIBNL> KDBFHMKODIK, [Optional] JJBAHNJEKLO DFKFFPKHNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CBKCKEONGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<JJBAHNJEKLO> JPEAAEADKEK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JJBAHNJEKLO BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81FBC80", Offset = "0x81FA680", VA = "0x1881FBC80")]
	public CBKCKEONGMK(JJBAHNJEKLO PJFDNMGHMBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JOHKKLCPDKF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BPLPGAIJAON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int EBGPJHGGENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int EIHHOBHCJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int MFNHJLKOODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int EMECCIBJADM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AEGCJEJGDFI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int OODNPPJIBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float DJPNGAFEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<HGJMBBNIBNL> KDBFHMKODIK;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x81FAE00", Offset = "0x81F9800", VA = "0x1881FAE00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum AOPBJIBPLDG
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
	private BPLPGAIJAON OMNGIMCKFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int NIHFOPBJLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int DLCEGJHNJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int EBMNHDOCFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float NPJBDOGGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float BDEBIIFFHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<JJBAHNJEKLO> FLIODNCLAEL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CBKCKEONGMK KKEOBJNIAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x820D240", Offset = "0x820BC40", VA = "0x18820D240")]
	public JOHKKLCPDKF(int DLCEGJHNJKL, int EBMNHDOCFOC, float NPJBDOGGEJH, int NIHFOPBJLGK, float BDEBIIFFHLP = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x820B170", Offset = "0x8209B70", VA = "0x18820B170")]
	public void ACHNAECEJJE(List<HGJMBBNIBNL> KDBFHMKODIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x820C0E0", Offset = "0x820AAE0", VA = "0x18820C0E0")]
	public bool JLNLFFPKHNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x820C150", Offset = "0x820AB50", VA = "0x18820C150")]
	private float NOGJNCDNBJI(Vector3 OIMFMPLNJEN, Vector3 HJDOALAIPGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x820C1A0", Offset = "0x820ABA0", VA = "0x18820C1A0")]
	private float NOGJNCDNBJI(Vector3 CGAAPEOHPIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x820B340", Offset = "0x8209D40", VA = "0x18820B340")]
	private bool FICFLJOFHIO(JJBAHNJEKLO CJPEAIDKFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x820C1C0", Offset = "0x820ABC0", VA = "0x18820C1C0")]
	private AEGCJEJGDFI OACMNBPKJGD(List<HGJMBBNIBNL> KCBHGGNIHGM, AOPBJIBPLDG AOKMIKOCBIG)
	{
		return default(AEGCJEJGDFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x820BD20", Offset = "0x820A720", VA = "0x18820BD20")]
	private void HMFKNHLLEFH(List<HGJMBBNIBNL> KDBFHMKODIK, NativeArray<Vector3> NLOJFGIOJAJ, NativeArray<Vector3> EDNEHKBBJCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class EAKEBHKLOBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x81FEB80", Offset = "0x81FD580", VA = "0x1881FEB80")]
	public static Bounds CJLLNDFMLPE(List<HGJMBBNIBNL> KDBFHMKODIK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81FED50", Offset = "0x81FD750", VA = "0x1881FED50")]
	public static int GMFJDEHBKAM(List<HGJMBBNIBNL> KDBFHMKODIK, EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class DCHCEOBJPOC
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool CACJLHFKANC(float4* MNAPONIFNJI, int KLLLBPFLPCD);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class AOOBIMOBEAO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr HMKMBDMMICF;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr ICCGCFACKOO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x81FAE60", Offset = "0x81F9860", VA = "0x1881FAE60")]
		[BurstDiscard]
		private static void BLECKPHCPCM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x81FB180", Offset = "0x81F9B80", VA = "0x1881FB180")]
		private static IntPtr KLOKGCHDPLA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x81FB2E0", Offset = "0x81F9CE0", VA = "0x1881FB2E0")]
		public static void PJJGOPHONDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public static void ICNIAFDKEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81FAF90", Offset = "0x81F9990", VA = "0x1881FAF90")]
		public unsafe static bool ELEPNCJAFML(float4* MNAPONIFNJI, int KLLLBPFLPCD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81FDAC0", Offset = "0x81FC4C0", VA = "0x1881FDAC0")]
	[BurstCompile]
	public unsafe static bool HMLKJIMDJCM(float4* MNAPONIFNJI, int KLLLBPFLPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x81FAC10", Offset = "0x81F9610", VA = "0x1881FAC10")]
	[BurstCompile]
	public unsafe static bool MFAIBNMOBBO(float4* MNAPONIFNJI, int KLLLBPFLPCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct OBLAODLBPOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> GHKDGJKMPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> FNIPEFPJPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> BIEPCGNFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> DMCNPNFGKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> FCFMIHIFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> JCBKGPNEICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> PBGBMBGHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> KONPFPPFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<NPBFOENPDFA.PGKICOPGBLM> FPHCHOGAJNO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x82105E0", Offset = "0x820EFE0", VA = "0x1882105E0")]
	public OBLAODLBPOL(NPBFOENPDFA HJEABEODHLD, NativeArray<bool> PBGBMBGHEKL, NativeList<ushort> KONPFPPFJJN, NativeList<NPBFOENPDFA.PGKICOPGBLM> FPHCHOGAJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8210330", Offset = "0x820ED30", VA = "0x188210330", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct DGPCOACNJDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> GHKDGJKMPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> FNIPEFPJPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> BIEPCGNFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> DMCNPNFGKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> FCFMIHIFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> JCBKGPNEICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> KGMHOOOJFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> GDCPKJIHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> DAJAEBJECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> PCMCNJHNKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> FAKMKHFIGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> CONPCODNIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> PBGBMBGHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> KONPFPPFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<NPBFOENPDFA.PGKICOPGBLM> FPHCHOGAJNO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x81FE1B0", Offset = "0x81FCBB0", VA = "0x1881FE1B0")]
	public DGPCOACNJDN(NPBFOENPDFA HJEABEODHLD, NPBFOENPDFA INGNFONLFBG, NativeArray<bool> PBGBMBGHEKL, NativeList<ushort> KONPFPPFJJN, NativeList<NPBFOENPDFA.PGKICOPGBLM> FPHCHOGAJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x81FDCE0", Offset = "0x81FC6E0", VA = "0x1881FDCE0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FGJBGGEKJIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NPBFOENPDFA CKJPCDNICOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private NPBFOENPDFA HJEABEODHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> CBAIHKNINPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> KONPFPPFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<NPBFOENPDFA.PGKICOPGBLM> FPHCHOGAJNO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static NPBFOENPDFA MJLGFDNADGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private ICPHAHIKIHB JGECIMNGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PHBEGBLLIGG IEJPPIMPMNP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle HADFHMENAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xE823E0", Offset = "0xE80DE0", VA = "0x180E823E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HAOMLLKHMJH.POJPBDMBBHA CJPEAIDKFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OIPONDOIONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x26ADD20", Offset = "0x26AC720", VA = "0x1826ADD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x81FFA60", Offset = "0x81FE460", VA = "0x1881FFA60")]
	[GGDENAMAEIG(DEFFNBOPPKN.EnteredEditMode, 0)]
	private static void BOGNJJBKCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x81FFAE0", Offset = "0x81FE4E0", VA = "0x1881FFAE0")]
	public void CEKLAJMLNPO(HAOMLLKHMJH.POJPBDMBBHA CPJDGEEHKKI, Transform LPJLACFNLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x81FF190", Offset = "0x81FDB90", VA = "0x1881FF190")]
	public void AIAPIIKHLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8200660", Offset = "0x81FF060", VA = "0x188200660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8200620", Offset = "0x81FF020", VA = "0x188200620")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8200730", Offset = "0x81FF130", VA = "0x188200730")]
	public FGJBGGEKJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DHCNCAMKDID
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 IBMEAELNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GOKHCIKBGOF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(OGMJCPNEHOO<string>.LOEEEDILNMC DDBOEKHHDFG, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DBHJBANDBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBHJBANDBMG LOBMDPFJENI(Action FOAIPBIEILM);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBHJBANDBMG JADELNKANCO(Action FOAIPBIEILM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class DLMDDLEJNCN : DBHJBANDBMG
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class EFINLEDPANL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public DLMDDLEJNCN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public EFINLEDPANL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x81FEFC0", Offset = "0x81FD9C0", VA = "0x1881FEFC0")]
				internal void OPGPNJCKIBD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x81FEF20", Offset = "0x81FD920", VA = "0x1881FEF20")]
				internal void AMMDGKEAFDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x81FEF70", Offset = "0x81FD970", VA = "0x1881FEF70")]
				internal void IBMBGJCIJKH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> HGJLNEAMMGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action NEENHJLDFOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action OGJJABHGNNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private OELKGKNAAJI LHFJPJPCEJM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GMFPEDFDLDC
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action DAKBFIOPAHO
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x29EDAD0", Offset = "0x29EC4D0", VA = "0x1829EDAD0", Slot = "4")]
			public DBHJBANDBMG LOBMDPFJENI(Action FOAIPBIEILM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5D030", Offset = "0x7B5BA30", VA = "0x187B5D030", Slot = "5")]
			public DBHJBANDBMG JADELNKANCO(Action FOAIPBIEILM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
			public DLMDDLEJNCN(Func<JobHandle> HKBHIJNCJOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81FE400", Offset = "0x81FCE00", VA = "0x1881FE400")]
			public void JCNNIFHFEKH(Action DNIAOCPOJNE, Action FBFDEIJMDKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x81FE270", Offset = "0x81FCC70", VA = "0x1881FE270")]
			public void BBOPECIHIDA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class NHMDBDLBOEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public DBHJBANDBMG jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public NHMDBDLBOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8210320", Offset = "0x820ED20", VA = "0x188210320")]
			internal bool HELDJGKOGBA(DLMDDLEJNCN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class DCFDLHMOAFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public DLMDDLEJNCN newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public DCFDLHMOAFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x81FDA60", Offset = "0x81FC460", VA = "0x1881FDA60")]
			internal void NDLKCLALMFB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<DLMDDLEJNCN> KLJKONINEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<DLMDDLEJNCN> GOIHEJKDIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private NNFEFJFFOPD AFBHEOICJHJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public CDPPJFDCBBP JMBOBCDDHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x820D2A0", Offset = "0x820BCA0", VA = "0x18820D2A0")]
		public DBHJBANDBMG Add(Func<JobHandle> HKBHIJNCJOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x820D5D0", Offset = "0x820BFD0", VA = "0x18820D5D0")]
		public void Remove(DBHJBANDBMG HADFHMENAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x820D400", Offset = "0x820BE00", VA = "0x18820D400", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x820D7B0", Offset = "0x820C1B0", VA = "0x18820D7B0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x820DA10", Offset = "0x820C410", VA = "0x18820DA10")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x820D3F0", Offset = "0x820BDF0", VA = "0x18820D3F0")]
		[CompilerGenerated]
		private void LAIJPICDIIJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OELKGKNAAJI
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OELKGKNAAJI LOBMDPFJENI(Action FOAIPBIEILM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OELKGKNAAJI HLAJHGNLMKD(Action FOAIPBIEILM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OELKGKNAAJI JADELNKANCO(Action FOAIPBIEILM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, DFEHPODJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class CNLBPGJKHIC : OELKGKNAAJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle DDALCMCKLOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action NEENHJLDFOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action BGCAFDFCBMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action DAKBFIOPAHO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool CCPIHKOJBEH
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x81FBDF0", Offset = "0x81FA7F0", VA = "0x1881FBDF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7A82010", Offset = "0x7A80A10", VA = "0x187A82010", Slot = "4")]
			public OELKGKNAAJI LOBMDPFJENI(Action FOAIPBIEILM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7A82030", Offset = "0x7A80A30", VA = "0x187A82030", Slot = "5")]
			public OELKGKNAAJI HLAJHGNLMKD(Action FOAIPBIEILM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7B5D030", Offset = "0x7B5BA30", VA = "0x187B5D030", Slot = "6")]
			public OELKGKNAAJI JADELNKANCO(Action FOAIPBIEILM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x10D2170", Offset = "0x10D0B70", VA = "0x1810D2170")]
			public CNLBPGJKHIC(JobHandle JAOIBMAODIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x81FBDA0", Offset = "0x81FA7A0", VA = "0x1881FBDA0")]
			public void BEPFEFDFKFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81FBD50", Offset = "0x81FA750", VA = "0x1881FBD50")]
			public void BBOPECIHIDA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<CNLBPGJKHIC> LNNOFMONOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> IMAHFCHCNIF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HAAHJMNIMKO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x820DFF0", Offset = "0x820C9F0", VA = "0x18820DFF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x16866F0", Offset = "0x16850F0", VA = "0x1816866F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x820DAF0", Offset = "0x820C4F0", VA = "0x18820DAF0")]
		public OELKGKNAAJI Add(JobHandle JAOIBMAODIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x820E200", Offset = "0x820CC00", VA = "0x18820E200")]
		public void Remove(OELKGKNAAJI HADFHMENAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x820DE10", Offset = "0x820C810", VA = "0x18820DE10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x820DC60", Offset = "0x820C660", VA = "0x18820DC60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x820DB90", Offset = "0x820C590", VA = "0x18820DB90")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x820E300", Offset = "0x820CD00", VA = "0x18820E300")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "6")]
		private bool OELMCBECINB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8210F00", Offset = "0x820F900", VA = "0x188210F00")]
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
