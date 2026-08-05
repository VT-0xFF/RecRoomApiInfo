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
				[Cpp2IlInjected.Address(RVA = "0x55DBED0", Offset = "0x55DAAD0", VA = "0x1855DBED0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x24ACFE0", Offset = "0x24ABBE0", VA = "0x1824ACFE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x55DBE90", Offset = "0x55DAA90", VA = "0x1855DBE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x55CEE90", Offset = "0x55CDA90", VA = "0x1855CEE90")]
		public LODSettings BPNMKGHCJEE(BBIMGAEJAFH LDPMEOOMILD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x55CEEA0", Offset = "0x55CDAA0", VA = "0x1855CEEA0")]
		public int EKPOMKJGDIN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x55CEEC0", Offset = "0x55CDAC0", VA = "0x1855CEEC0")]
		public int MAGIHNMELLE(bool GNKDCADHFKH, Vector3 LGKCJKDBEEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55CEFC0", Offset = "0x55CDBC0", VA = "0x1855CEFC0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HNFBDONLIFA
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
public interface FCDLGAIDMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MABHDCCBPHO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HIALMMKAOEC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JPGDAFDKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KMJKLEFLOJJ> LCNEJGIDMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HNFBDONLIFA EENLANIAFHH
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
	void UpdateClusterDistances(Vector3 ICNDOIOFCLN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(JIJHDMJKEEF NMNKGKHKMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KMJKLEFLOJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HAMADIJDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int ONLCOFMCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GLEBHCDMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DEFEOLMKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte DFPFCOOGKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FAPAHEEPDPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JANEBGLCBEN
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
	private struct FEEDPCMDPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FAPAHEEPDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private CEJMOEANPLC <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x55D5E40", Offset = "0x55D4A40", VA = "0x1855D5E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CENDNOGDAFF : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FAPAHEEPDPA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public CENDNOGDAFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55CCBF0", Offset = "0x55CB7F0", VA = "0x1855CCBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x55CCCB0", Offset = "0x55CB8B0", VA = "0x1855CCCB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CNJNBKELNPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FAPAHEEPDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CEJMOEANPLC worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private CEJMOEANPLC <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x55CD350", Offset = "0x55CBF50", VA = "0x1855CD350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BGFJIOKMFOL : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FAPAHEEPDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public BGFJIOKMFOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x55CBC20", Offset = "0x55CA820", VA = "0x1855CBC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x55CCAD0", Offset = "0x55CB6D0", VA = "0x1855CCAD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CGOIOOLEOFP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan PFAOKMECHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer HKGHCFODFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter JEKMICAKECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OCPBNBNOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject MNKBENGOMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public ENGCIHFMGLE BBKDMOEIFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JIJHDMJKEEF> IMJGFFJHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JIJHDMJKEEF> KEPNBFJMFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<JIJHDMJKEEF> KAJMCJLCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DAOMBJGHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JANEBGLCBEN HMIPKGJPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<HIALMMKAOEC>[] CNOKMPDKKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KMJKLEFLOJJ>[] OEAKKMINBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource DCBJEMJCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool HONONBAGMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LOGJIJEEBDN MOMDPKICCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LOGJIJEEBDN PGDGNKOGGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int CHFMJIPEGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int FCFGBBFEKPP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static FAPAHEEPDPA MKGILPJGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BJGFKEHIKGF GECJAMOEJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EDKJPBKBAPH BGCGOAGJJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour IKNELLIJLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material IIBEHOBFGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<FCDLGAIDMKC> GMFILHFKKPA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JNEBJPNPAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 MIPKOAEADFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x119C870", Offset = "0x119B470", VA = "0x18119C870")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x119C790", Offset = "0x119B390", VA = "0x18119C790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JANEBGLCBEN PNFPKHKPMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA40", Offset = "0x7CB640", VA = "0x1807CCA40")]
		get
		{
			return default(JANEBGLCBEN);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55D3650", Offset = "0x55D2250", VA = "0x1855D3650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static FAPAHEEPDPA EBMHMHOHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55D28E0", Offset = "0x55D14E0", VA = "0x1855D28E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JIFAKLHEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x55D1CB0", Offset = "0x55D08B0", VA = "0x1855D1CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool AFILJBLDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x55D2D80", Offset = "0x55D1980", VA = "0x1855D2D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LKCLDMDGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55D27D0", Offset = "0x55D13D0", VA = "0x1855D27D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55D2CE0", Offset = "0x55D18E0", VA = "0x1855D2CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FHDGGOHOMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x55D2C40", Offset = "0x55D1840", VA = "0x1855D2C40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x55D1F60", Offset = "0x55D0B60", VA = "0x1855D1F60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55D3A30", Offset = "0x55D2630", VA = "0x1855D3A30")]
	public FAPAHEEPDPA(BJGFKEHIKGF GECJAMOEJIF, EDKJPBKBAPH BGCGOAGJJGA, ClusterLODConfig APEENHAPIHC, MonoBehaviour IKNELLIJLDL, Material IIBEHOBFGBE, ClusterMeshRenderer HKGHCFODFME, MeshFilter JEKMICAKECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55D1BB0", Offset = "0x55D07B0", VA = "0x1855D1BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x55D24B0", Offset = "0x55D10B0", VA = "0x1855D24B0")]
	public static void HNMGJGDFPOH(Vector3 LOEKIAHOMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x55D25E0", Offset = "0x55D11E0", VA = "0x1855D25E0")]
	private void IJFLMMEKJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55D2A60", Offset = "0x55D1660", VA = "0x1855D2A60")]
	private void MNECPNDJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55D1DD0", Offset = "0x55D09D0", VA = "0x1855D1DD0")]
	private void EKMGIHJLGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55D1470", Offset = "0x55D0070", VA = "0x1855D1470")]
	public void DFIPOGKLIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55D2000", Offset = "0x55D0C00", VA = "0x1855D2000")]
	[AsyncStateMachine(typeof(FEEDPCMDPGG))]
	public Task GCKMDFDDBAE(CEJMOEANPLC PDHDLCNGDKN, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55D1120", Offset = "0x55CFD20", VA = "0x1855D1120")]
	[IteratorStateMachine(typeof(CENDNOGDAFF))]
	private IEnumerator<LGOBDJKCLEL> BEFAHODPHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x55D2E60", Offset = "0x55D1A60", VA = "0x1855D2E60")]
	[AsyncStateMachine(typeof(CNJNBKELNPF))]
	private Task OCJHNOKBMBM(CEJMOEANPLC MONJKDDCILH, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55D2140", Offset = "0x55D0D40", VA = "0x1855D2140")]
	public void GELDHCBMDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55D3940", Offset = "0x55D2540", VA = "0x1855D3940")]
	public void PNELFKMOHIN(IEnumerable<HIALMMKAOEC> GIOEPADOBIM, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x55D1190", Offset = "0x55CFD90", VA = "0x1855D1190")]
	public void BEPFJIOILIC(IEnumerable<HIALMMKAOEC> GIOEPADOBIM, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55D2FA0", Offset = "0x55D1BA0", VA = "0x1855D2FA0")]
	public List<ClusterMeshRenderer> OIOBDLBNNLM(List<JIJHDMJKEEF> ECOKHAGGAGC, HIHDGKIDBHE MHPJOFNEKOG, HNFBDONLIFA FALJPHMEHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55D2A20", Offset = "0x55D1620", VA = "0x1855D2A20")]
	public HNFBDONLIFA MHNJKJFDENM(Vector3 BJOLPFLAOOG)
	{
		return default(HNFBDONLIFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55D1410", Offset = "0x55D0010", VA = "0x1855D1410")]
	public void DBJFGCNPBEI(FCDLGAIDMKC OAKILALMLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x55D2940", Offset = "0x55D1540", VA = "0x1855D2940")]
	public bool KPEJHDNBIHJ(FCDLGAIDMKC OAKILALMLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x55D2B60", Offset = "0x55D1760", VA = "0x1855D2B60")]
	public void MOACOMIGCBK(JIJHDMJKEEF GMAELPCKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55D29A0", Offset = "0x55D15A0", VA = "0x1855D29A0")]
	public void LHPDMBMCEBN(KMJKLEFLOJJ DHBOJIINPOH, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55D2BC0", Offset = "0x55D17C0", VA = "0x1855D2BC0")]
	public void MOLBPGHHCGD(KMJKLEFLOJJ DHBOJIINPOH, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55D2670", Offset = "0x55D1270", VA = "0x1855D2670")]
	private void IKDOLPKOKMP(Vector3 ICNDOIOFCLN, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55D2350", Offset = "0x55D0F50", VA = "0x1855D2350")]
	private void HNCOEJOPDFJ(Vector3 ICNDOIOFCLN, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55D2870", Offset = "0x55D1470", VA = "0x1855D2870")]
	[IteratorStateMachine(typeof(BGFJIOKMFOL))]
	private IEnumerator<LGOBDJKCLEL> JMHJNOEAMAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55D3780", Offset = "0x55D2380", VA = "0x1855D3780")]
	private int PCGLKJDNCAO(int BNNEENLPEFO, int NPJCHCBJABM, List<KMJKLEFLOJJ> NPOAMAEFAJF, byte LDPMEOOMILD, ref int HHKMOMIMKNA, float HBEKOKCHIKH = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55D19D0", Offset = "0x55D05D0", VA = "0x1855D19D0")]
	public void DOHHNJJEEIG(JIJHDMJKEEF NMNKGKHKMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55D3900", Offset = "0x55D2500", VA = "0x1855D3900")]
	public bool PEPPNPHPJOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72F7A0", Offset = "0x72E3A0", VA = "0x18072F7A0")]
	public Material FBIKEOGCIEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55D1F20", Offset = "0x55D0B20", VA = "0x1855D1F20")]
	public int EKPOMKJGDIN()
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
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct CPDKPHIFOHD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> GMKECJHJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> GCLOPOKNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> JDAKJDOLKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> BDGIHLGJMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> JPGIEFCGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> EMLNAJJBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> FMMBKMLJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 CIEJPFHBIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float MIMNILBCKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> BOPOMBBFJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> EEHJEOFNCDA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55CEDD0", Offset = "0x55CD9D0", VA = "0x1855CEDD0")]
	public CPDKPHIFOHD(NFHFGCGPPAN KIGAICGDOPA, NativeList<float3> FMMBKMLJEGH, NativeMultiHashMap<int, int> BOPOMBBFJKP, NativeArray<int> EEHJEOFNCDA, Vector3 CIEJPFHBIGC, float MIMNILBCKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55CE970", Offset = "0x55CD570", VA = "0x1855CE970")]
	private int EDLMDKNCCNP(float3 ICNDOIOFCLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55CE710", Offset = "0x55CD310", VA = "0x1855CE710")]
	private int EBPPDAGHIJG(int OJFFKHAMPMJ, int BIMCDHOFDCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55CE9A0", Offset = "0x55CD5A0", VA = "0x1855CE9A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KNPDFCFKJCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> BOPOMBBFJKP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> EEHJEOFNCDA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int PJDMFPAJDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> HOEODCEKOAI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55DBC80", Offset = "0x55DA880", VA = "0x1855DBC80")]
	public void KJIGMDGOJDE(int JDOAPHIBGNO, Allocator PBEDBDBGIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55DBBA0", Offset = "0x55DA7A0", VA = "0x1855DBBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KNPDFCFKJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GKFIEDEAAII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> GBBLEKCOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> DHPGDDEMHPL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55D64C0", Offset = "0x55D50C0", VA = "0x1855D64C0")]
	public GKFIEDEAAII(KNPDFCFKJCH JNBGMEFFPPM, NFHFGCGPPAN KIGAICGDOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55D6420", Offset = "0x55D5020", VA = "0x1855D6420", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ANLGFJHOBPC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> BMCGANEAGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> PAMLDPJHMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> MGKLGJMPNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> NIBOJEGIMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> IDFJBIGLFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> HOEODCEKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> GBBLEKCOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> HPOJMCDCIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> BMJGJMNAHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> NDLAPLBNDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> FLEPFKNBIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> OOGNGJFFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> FNJEHAIBDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float OJNJGKGJLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float MOOOPAPNDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 MPDELAEIHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float BEELPDKDFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float BGMJHCGFPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float BNDBJFDKNPP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55CBAE0", Offset = "0x55CA6E0", VA = "0x1855CBAE0")]
	public ANLGFJHOBPC(KNPDFCFKJCH AMNHGMDFAKB, NFHFGCGPPAN KIGAICGDOPA, NFHFGCGPPAN APEJJGGKKOO, float BGMJHCGFPDF, float BNDBJFDKNPP, Vector3 MPDELAEIHHG, float BEELPDKDFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55CA5F0", Offset = "0x55C91F0", VA = "0x1855CA5F0")]
	private float3 DJKPIICJHKK(int OJFFKHAMPMJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55CB530", Offset = "0x55CA130", VA = "0x1855CB530")]
	private void LOIHIBNLFBB(int OJFFKHAMPMJ, out float3 ANBMFJNMPCN, out float3 JBDCFLNIANO, out float4 EMHMKFJJOJN, out float4 NCKNIGNNFIB, out float2 IJLMDOLPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55CA6A0", Offset = "0x55C92A0", VA = "0x1855CA6A0")]
	private int EJLNCMHCNDP(int KOEOKKMPNGE, int OKJFAHCDPGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55CB720", Offset = "0x55CA320", VA = "0x1855CB720")]
	private void LPKIPJKMKGG(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55CB950", Offset = "0x55CA550", VA = "0x1855CB950")]
	private bool MJLBMKHJNMO(int KOEOKKMPNGE, int OKJFAHCDPGF, float HFPEBAMGNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x55CA530", Offset = "0x55C9130", VA = "0x1855CA530")]
	private bool BOLIDEEJLMO(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, float HFPEBAMGNJH, bool JENEOMCAPBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55CB2C0", Offset = "0x55C9EC0", VA = "0x1855CB2C0")]
	private bool LGLGGFCDAGO(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, float HFPEBAMGNJH, bool JENEOMCAPBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55CB930", Offset = "0x55CA530", VA = "0x1855CB930")]
	private void MJDCCDEACOA(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, out int GLCINECBPJC, out int OPCJLCONIKP, out int LFJLMOGGGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55CA9A0", Offset = "0x55C95A0", VA = "0x1855CA9A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PMEDGNPLPBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HEFJHLCCNNO : IDisposable, KMJKLEFLOJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds BDLOKEMJJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<JIJHDMJKEEF> ECOKHAGGAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 BOFGCONPJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 IOMBPCHKKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int MDKMEICAFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NFHFGCGPPAN MICPBEOIFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KNPDFCFKJCH ANNKHMIIFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform MHPJOFNEKOG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int HMHGEOCAMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x55D7530", Offset = "0x55D6130", VA = "0x1855D7530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh APNGDKNNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CJDNLBCGAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GLEBHCDMLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x13D6350", Offset = "0x13D4F50", VA = "0x1813D6350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2CEE9D0", Offset = "0x2CED5D0", VA = "0x182CEE9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte DFPFCOOGKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6740", VA = "0x1809F7B40")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F7CE0", Offset = "0x9F68E0", VA = "0x1809F7CE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HAMADIJDDEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EC60", VA = "0x180A90060", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA90070", Offset = "0xA8EC70", VA = "0x180A90070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ONLCOFMCGBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xCCCF40", Offset = "0xCCBB40", VA = "0x180CCCF40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xF06E50", Offset = "0xF05A50", VA = "0x180F06E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DEFEOLMKKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x55D6CA0", Offset = "0x55D58A0", VA = "0x1855D6CA0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x55D6EC0", Offset = "0x55D5AC0", VA = "0x1855D6EC0")]
		public void EDOEBDDIOJI(BBIMGAEJAFH LDPMEOOMILD, out int HEJCNEIPLFH, out int NPEKFKPGEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x55D6AF0", Offset = "0x55D56F0", VA = "0x1855D6AF0")]
		public void APMGONIGJJF(BBIMGAEJAFH LDPMEOOMILD, OHBJADHEDAF AMJMNCKBDPB, int LEABJDADMHB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x55D7190", Offset = "0x55D5D90", VA = "0x1855D7190")]
		public void MJLLBJBOLFM(NativeList<CNLNAAJIOJC> PLBPIHNHHHH, Transform ICFDLHANCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x55D70F0", Offset = "0x55D5CF0", VA = "0x1855D70F0")]
		public void FCHFKIOJHPF(Mesh KIGAICGDOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x55D6A50", Offset = "0x55D5650", VA = "0x1855D6A50")]
		public void AGGFNLOKDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x55D6CC0", Offset = "0x55D58C0", VA = "0x1855D6CC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x55D7570", Offset = "0x55D6170", VA = "0x1855D7570")]
		public HEFJHLCCNNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds BDLOKEMJJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<HEFJHLCCNNO> ODFIIGPONAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public JAFPLEGCKIN NAABHJBFKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer GHGAIHKFDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int ACBNAOBAAOE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh JBGPNHNENMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DABHMEMDMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811320", VA = "0x180812720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JPGDAFDKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x55DD370", Offset = "0x55DBF70", VA = "0x1855DD370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55DCD90", Offset = "0x55DB990", VA = "0x1855DCD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
	public int GKFBOADDEJP(int IBEJJPAHPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55DBF90", Offset = "0x55DAB90", VA = "0x1855DBF90")]
	public void BDPMMMIGKID(ADDMOFMMLMJ KFKCBDLHFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55DC310", Offset = "0x55DAF10", VA = "0x1855DC310")]
	public void DAJJIFBHNGJ(Transform ICFDLHANCHH, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55DC150", Offset = "0x55DAD50", VA = "0x1855DC150")]
	public bool CCLABGKGKML(bool MGJMOPDPEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55DCF20", Offset = "0x55DBB20", VA = "0x1855DCF20")]
	public void ICCKNHJHMCJ(Transform MHPJOFNEKOG, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55DCAE0", Offset = "0x55DB6E0", VA = "0x1855DCAE0")]
	public bool DOHHNJJEEIG(JIJHDMJKEEF NMNKGKHKMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55DD3C0", Offset = "0x55DBFC0", VA = "0x1855DD3C0")]
	public PMEDGNPLPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ENGCIHFMGLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<PMEDGNPLPBG.HEFJHLCCNNO> POCPEMDIMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JLKCBDBEJGI FMABIKFMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<PMEDGNPLPBG.HEFJHLCCNNO> IOAEFFMPPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BAPFAJGHABF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55D0940", Offset = "0x55CF540", VA = "0x1855D0940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55D0AD0", Offset = "0x55CF6D0", VA = "0x1855D0AD0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55D09B0", Offset = "0x55CF5B0", VA = "0x1855D09B0")]
	public void ELGBPIMHCCH(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO, Transform MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x55D0750", Offset = "0x55CF350", VA = "0x1855D0750")]
	public void DOHHNJJEEIG(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55D0B50", Offset = "0x55CF750", VA = "0x1855D0B50")]
	private PMEDGNPLPBG.HEFJHLCCNNO HFDPHDMCDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x55D06B0", Offset = "0x55CF2B0", VA = "0x1855D06B0")]
	private bool AHJJDGILMCH(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55D0C80", Offset = "0x55CF880", VA = "0x1855D0C80")]
	private void JAGEBOCDBCD(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55D0F70", Offset = "0x55CFB70", VA = "0x1855D0F70")]
	public bool NHLOBNFEHGN(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55D0CE0", Offset = "0x55CF8E0", VA = "0x1855D0CE0")]
	public bool LPIFGEKCIOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55D0A70", Offset = "0x55CF670", VA = "0x1855D0A70")]
	private PMEDGNPLPBG.HEFJHLCCNNO GANBEODICPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55D0FA0", Offset = "0x55CFBA0", VA = "0x1855D0FA0")]
	public ENGCIHFMGLE()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CFJBIMFPFKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int MNHAGCEIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int AIABELCACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float IHEJLPDAOBK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<PMEDGNPLPBG> GGABLKMEIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
	public CFJBIMFPFKB(int MNHAGCEIBHD, int AIABELCACMB, float MANILLFBOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55CCD90", Offset = "0x55CB990", VA = "0x1855CCD90")]
	public void IBGLCMIHDHC(IHEFOKFJOIN MKNLKKNPKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55CCCF0", Offset = "0x55CB8F0", VA = "0x1855CCCF0")]
	private int AMCKMHPFPIO(ADDMOFMMLMJ BAIMHJNEKGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x55CCEB0", Offset = "0x55CBAB0", VA = "0x1855CCEB0")]
	private void IBGLCMIHDHC(ADDMOFMMLMJ BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55CD0F0", Offset = "0x55CBCF0", VA = "0x1855CD0F0")]
	private void JAGOIIHHCHJ(ADDMOFMMLMJ BAIMHJNEKGI, PMEDGNPLPBG MCNABFEFHHB)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HIALMMKAOEC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EFGDBLNKKFI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public EFGDBLNKKFI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x55D04C0", Offset = "0x55CF0C0", VA = "0x1855D04C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x55D0670", Offset = "0x55CF270", VA = "0x1855D0670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x55D05D0", Offset = "0x55CF1D0", VA = "0x1855D05D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x55D05D0", Offset = "0x55CF1D0", VA = "0x1855D05D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JPGDAFDKAHC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x55D0460", Offset = "0x55CF060", VA = "0x1855D0460", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<KMJKLEFLOJJ> LCNEJGIDMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x55D0440", Offset = "0x55CF040", VA = "0x1855D0440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> ODFIIGPONAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PMEDGNPLPBG JBGPNHNENMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HNFBDONLIFA EENLANIAFHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6991B0", Offset = "0x697DB0", VA = "0x1806991B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(HNFBDONLIFA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x82CDE0", Offset = "0x82B9E0", VA = "0x18082CDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IGLDONGFBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x55D0450", Offset = "0x55CF050", VA = "0x1855D0450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x55CF020", Offset = "0x55CDC20", VA = "0x1855CF020")]
		public static ClusterMeshRenderer Create(PMEDGNPLPBG KIGAICGDOPA, ClusterMeshRenderer HKGHCFODFME, MeshFilter JEKMICAKECA, HIHDGKIDBHE MHPJOFNEKOG, HNFBDONLIFA FALJPHMEHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x55CF1C0", Offset = "0x55CDDC0", VA = "0x1855CF1C0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55CF980", Offset = "0x55CE580", VA = "0x1855CF980", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JIJHDMJKEEF NMNKGKHKMCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55CF770", Offset = "0x55CE370", VA = "0x1855CF770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55CF410", Offset = "0x55CE010", VA = "0x1855CF410")]
		public void Init(PMEDGNPLPBG KIGAICGDOPA, MeshFilter JEKMICAKECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x55CF220", Offset = "0x55CDE20", VA = "0x1855CF220")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55CFAB0", Offset = "0x55CE6B0", VA = "0x1855CFAB0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 ICNDOIOFCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55CFCC0", Offset = "0x55CE8C0", VA = "0x1855CFCC0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55CF3A0", Offset = "0x55CDFA0", VA = "0x1855CF3A0")]
		[IteratorStateMachine(typeof(EFGDBLNKKFI))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55CF7F0", Offset = "0x55CE3F0", VA = "0x1855CF7F0")]
		public void SetupTagAndLayer(string OKDNGJDIOCM, int FALJPHMEHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55CF7D0", Offset = "0x55CE3D0", VA = "0x1855CF7D0")]
		public bool Remove(JIJHDMJKEEF NMNKGKHKMCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LDLANLLLFED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int MAMHOIPHMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int IOGAMBOBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NPEKFKPGEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HEJCNEIPLFH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55DBE70", Offset = "0x55DAA70", VA = "0x1855DBE70")]
	public LDLANLLLFED(int IOGAMBOBGAL, int NPEKFKPGEFC, int MAMHOIPHMCO, int HEJCNEIPLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JAFPLEGCKIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> GMKECJHJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> HOEODCEKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> EMLNAJJBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<LDLANLLLFED> MEOBJDMPABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> LDDHLBPMDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> DJEKLCCMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> MOLDKPNJJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle BLJNDDIDOIN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DNEMJMCMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC689A0", Offset = "0xC675A0", VA = "0x180C689A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC68F40", Offset = "0xC67B40", VA = "0x180C68F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x55D7720", Offset = "0x55D6320", VA = "0x1855D7720")]
	public void BLNLPEOGOOG(NFHFGCGPPAN EEBNCHEHFGH, NativeList<LDLANLLLFED> MEOBJDMPABM, float OLIFDPKHJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x55D8930", Offset = "0x55D7530", VA = "0x1855D8930")]
	public void KHOGKPNLIBO(Transform MHPJOFNEKOG, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x55D8640", Offset = "0x55D7240", VA = "0x1855D8640")]
	public void CCLABGKGKML(PMEDGNPLPBG GHGAIHKFDCM, bool MGJMOPDPEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x55D87F0", Offset = "0x55D73F0", VA = "0x1855D87F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x55D8900", Offset = "0x55D7500", VA = "0x1855D8900")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JAFPLEGCKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HCKMMFHDHIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> GMKECJHJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> HOEODCEKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<LDLANLLLFED> KIBEMDDBAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> LDDHLBPMDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 MPDELAEIHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> DJEKLCCMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> MOLDKPNJJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool KEDNJGFDDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float JEHABBOLDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float AHNKLGCDBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float JJNLGHHLPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> EMLNAJJBPOG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55D6980", Offset = "0x55D5580", VA = "0x1855D6980")]
	public HCKMMFHDHIN(JAFPLEGCKIN MOGAJEFFDEG, Vector3 MPDELAEIHHG, bool KEDNJGFDDJM, float JEHABBOLDKG, float AHNKLGCDBIM, float JJNLGHHLPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55D64F0", Offset = "0x55D50F0", VA = "0x1855D64F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JIJHDMJKEEF : IMMGCKBFCDB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds BOCKBBIHPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CNLNAAJIOJC BJOPCFJAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ADDMOFMMLMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<JIJHDMJKEEF> ECOKHAGGAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public ADDMOFMMLMJ GEOFAMNLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public ADDMOFMMLMJ PNDGAOPCPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public ADDMOFMMLMJ CIAMEAABKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int HEJCNEIPLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds BDLOKEMJJMM;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55CA4B0", Offset = "0x55C90B0", VA = "0x1855CA4B0")]
	public ADDMOFMMLMJ(List<JIJHDMJKEEF> ECOKHAGGAGC, [Optional] ADDMOFMMLMJ GEOFAMNLJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IHEFOKFJOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<ADDMOFMMLMJ> GNFPCOAHHNM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ADDMOFMMLMJ AJIGMJGLFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55D7650", Offset = "0x55D6250", VA = "0x1855D7650")]
	public IHEFOKFJOIN(ADDMOFMMLMJ MHPJOFNEKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDEOKJDICHE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GINDGNCCNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int LKGJLHEMAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LEGBEODNFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int JCJADCIFKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int HEGDPGMJDGA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct COBFOIODPNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int FBHMBLEMOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float MADIEOEGGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<JIJHDMJKEEF> ECOKHAGGAGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum EHMJCCGJEGC
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
	private GINDGNCCNNM AEEFPLCJJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int AEHIMDAHOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int MNHAGCEIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int AIABELCACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float MANILLFBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float JBHOIGMMDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<ADDMOFMMLMJ> KIDDDHFODEI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IHEFOKFJOIN LMOMFEELKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55D5DE0", Offset = "0x55D49E0", VA = "0x1855D5DE0")]
	public FDEOKJDICHE(int MNHAGCEIBHD, int AIABELCACMB, float MANILLFBOKO, int AEHIMDAHOHG, float JBHOIGMMDKI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55D5710", Offset = "0x55D4310", VA = "0x1855D5710")]
	public void GPEDLAFOKFE(List<JIJHDMJKEEF> ECOKHAGGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55D5910", Offset = "0x55D4510", VA = "0x1855D5910")]
	public bool KJFIFLPGIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55D5640", Offset = "0x55D4240", VA = "0x1855D5640")]
	private float EJMDLDPIAHK(Vector3 HKPINKIDAGP, Vector3 MFHJKPMAGKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55D56C0", Offset = "0x55D42C0", VA = "0x1855D56C0")]
	private float EJMDLDPIAHK(Vector3 LBLAPKMJFKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55D4DB0", Offset = "0x55D39B0", VA = "0x1855D4DB0")]
	private bool DLGELJLBFBG(ADDMOFMMLMJ DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55D4180", Offset = "0x55D2D80", VA = "0x1855D4180")]
	private COBFOIODPNA ALEEOEMGHIJ(List<JIJHDMJKEEF> KAJMGGJHKBP, EHMJCCGJEGC KAOGMJBGHOD)
	{
		return default(COBFOIODPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55D5980", Offset = "0x55D4580", VA = "0x1855D5980")]
	private void MDMEGNKDBLN(List<JIJHDMJKEEF> ECOKHAGGAGC, Vector3[] ACDLGEOKBFJ, Vector3[] NPENFJNJICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JNKKBMNGGJB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55DA430", Offset = "0x55D9030", VA = "0x1855DA430")]
	public static Bounds NFINENKJDGO(List<JIJHDMJKEEF> ECOKHAGGAGC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55DA5E0", Offset = "0x55D91E0", VA = "0x1855DA5E0")]
	public static int OJDKGBIAAHM(List<JIJHDMJKEEF> ECOKHAGGAGC, BBIMGAEJAFH LDPMEOOMILD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JLKCBDBEJGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NFHFGCGPPAN PBGPAOGJOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private NFHFGCGPPAN GAEGDANNOGN;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static NFHFGCGPPAN DNFJGKFPEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BIECOJNFKHJ AECBGOGHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private OHBJADHEDAF AMJMNCKBDPB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle BLJNDDIDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xDB1B30", Offset = "0xDB0730", VA = "0x180DB1B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JFIGGJOJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70F580", Offset = "0x70E180", VA = "0x18070F580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x55D9080", Offset = "0x55D7C80", VA = "0x1855D9080")]
	[ECPMKACBNFP(JMKOAIIKPBP.ExitingPlayMode, 0)]
	private void AMCMKDDOKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x55D90F0", Offset = "0x55D7CF0", VA = "0x1855D90F0")]
	public void BLNLPEOGOOG(PMEDGNPLPBG.HEFJHLCCNNO KIBEMDDBAJO, Transform KKCKBHHGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x55D9C60", Offset = "0x55D8860", VA = "0x1855D9C60")]
	public void EFLMFGPCNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55D9BF0", Offset = "0x55D87F0", VA = "0x1855D9BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x55DA350", Offset = "0x55D8F50", VA = "0x1855DA350")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x55DA390", Offset = "0x55D8F90", VA = "0x1855DA390")]
	public JLKCBDBEJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EMLNHPMPKHE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FAPAHEEPDPA PLHNLKFPONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EDKJPBKBAPH
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 KJHNMEGGHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BJGFKEHIKGF
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(CEJMOEANPLC MONJKDDCILH, CancellationToken ADCKNELPFOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CICJIOMPGJM
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CICJIOMPGJM EOEPEPPLMFJ(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CICJIOMPGJM IADLIEJIABG(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CICJIOMPGJM NALHKMLDLLH(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CICJIOMPGJM OHECJANHBEC(Action KDJGJCHCIKK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class JKNAICJEECJ : CICJIOMPGJM
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BLHGMEJDHAI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public JKNAICJEECJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public BLHGMEJDHAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x55CCB10", Offset = "0x55CB710", VA = "0x1855CCB10")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x55CCB60", Offset = "0x55CB760", VA = "0x1855CCB60")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x55CCBB0", Offset = "0x55CB7B0", VA = "0x1855CCBB0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> IMDCFNMILNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action BALOCLDMGLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action AAKKPGNODGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private IGCEONLLKAC NCGENLELELG;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action EFKCHMFIIIE
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NNFFPHGAEFB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x301CF80", Offset = "0x301BB80", VA = "0x18301CF80", Slot = "4")]
			public CICJIOMPGJM EOEPEPPLMFJ(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2408230", Offset = "0x2406E30", VA = "0x182408230", Slot = "5")]
			public CICJIOMPGJM IADLIEJIABG(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2408250", Offset = "0x2406E50", VA = "0x182408250", Slot = "6")]
			public CICJIOMPGJM NALHKMLDLLH(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3986830", Offset = "0x3985430", VA = "0x183986830", Slot = "7")]
			public CICJIOMPGJM OHECJANHBEC(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
			public JKNAICJEECJ(Func<JobHandle> BNJNMHPEKLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x55D8C80", Offset = "0x55D7880", VA = "0x1855D8C80")]
			public void BLFPKNOMADF(Action GJCDKEEDPEF, Action HGKDPBBKEJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x55D8F10", Offset = "0x55D7B10", VA = "0x1855D8F10")]
			public void DOHHNJJEEIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class PFMIOLMKKOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public CICJIOMPGJM jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public PFMIOLMKKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x55DBF80", Offset = "0x55DAB80", VA = "0x1855DBF80")]
			internal bool <Remove>b__0(JKNAICJEECJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JHFANEEMJMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JKNAICJEECJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public JHFANEEMJMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x55D8C20", Offset = "0x55D7820", VA = "0x1855D8C20")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<JKNAICJEECJ> FFKJHGFMPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<JKNAICJEECJ> PNFPDEJFNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private LOGJIJEEBDN BEIKPEIHDPP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public JOKPBGLAHBN NCMHPMNIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55DA790", Offset = "0x55D9390", VA = "0x1855DA790")]
		public CICJIOMPGJM Add(Func<JobHandle> BNJNMHPEKLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x55DAA90", Offset = "0x55D9690", VA = "0x1855DAA90")]
		public void Remove(CICJIOMPGJM BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x55DA8F0", Offset = "0x55D94F0", VA = "0x1855DA8F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x55DAC60", Offset = "0x55D9860", VA = "0x1855DAC60")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x55DAEB0", Offset = "0x55D9AB0", VA = "0x1855DAEB0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x55DA8E0", Offset = "0x55D94E0", VA = "0x1855DA8E0")]
		[CompilerGenerated]
		private void CGIEAGGDFIK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IGCEONLLKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGCEONLLKAC EOEPEPPLMFJ(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGCEONLLKAC DLLKGOLEMLM(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IGCEONLLKAC OHECJANHBEC(Action KDJGJCHCIKK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class OGDJMLBMGPN : IGCEONLLKAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle IAGNALHCEKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action BALOCLDMGLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action FPOKHGDMJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action NNFFPHGAEFB;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool LBEMKJJMHEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x55DBF70", Offset = "0x55DAB70", VA = "0x1855DBF70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2408230", Offset = "0x2406E30", VA = "0x182408230", Slot = "4")]
			public IGCEONLLKAC EOEPEPPLMFJ(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2408250", Offset = "0x2406E50", VA = "0x182408250", Slot = "5")]
			public IGCEONLLKAC DLLKGOLEMLM(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3986830", Offset = "0x3985430", VA = "0x183986830", Slot = "6")]
			public IGCEONLLKAC OHECJANHBEC(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
			public OGDJMLBMGPN(JobHandle MNHBLNJHMBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x55DBEF0", Offset = "0x55DAAF0", VA = "0x1855DBEF0")]
			public void DNAKJMIBDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x55DBF30", Offset = "0x55DAB30", VA = "0x1855DBF30")]
			public void DOHHNJJEEIG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<OGDJMLBMGPN> JLCGGCHLJJI;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x55DB390", Offset = "0x55D9F90", VA = "0x1855DB390")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x55DAFB0", Offset = "0x55D9BB0", VA = "0x1855DAFB0")]
		public IGCEONLLKAC Add(JobHandle MNHBLNJHMBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x55DB2A0", Offset = "0x55D9EA0", VA = "0x1855DB2A0")]
		public void Remove(IGCEONLLKAC BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x55DB130", Offset = "0x55D9D30", VA = "0x1855DB130", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x55DB040", Offset = "0x55D9C40", VA = "0x1855DB040")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x55DB4B0", Offset = "0x55DA0B0", VA = "0x1855DB4B0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55DB570", Offset = "0x55DA170", VA = "0x1855DB570")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55DB680", Offset = "0x55DA280", VA = "0x1855DB680")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
