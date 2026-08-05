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
				[Cpp2IlInjected.Address(RVA = "0x54A28D0", Offset = "0x54A16D0", VA = "0x1854A28D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xDAF540", Offset = "0xDAE340", VA = "0x180DAF540")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x54A2890", Offset = "0x54A1690", VA = "0x1854A2890")]
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
		[Cpp2IlInjected.Address(RVA = "0x5495890", Offset = "0x5494690", VA = "0x185495890")]
		public LODSettings BPNMKGHCJEE(BBIMGAEJAFH LDPMEOOMILD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x54958A0", Offset = "0x54946A0", VA = "0x1854958A0")]
		public int EKPOMKJGDIN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x54958C0", Offset = "0x54946C0", VA = "0x1854958C0")]
		public int MAGIHNMELLE(bool GNKDCADHFKH, Vector3 LGKCJKDBEEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x54959C0", Offset = "0x54947C0", VA = "0x1854959C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x549C840", Offset = "0x549B640", VA = "0x18549C840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public CENDNOGDAFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x54935F0", Offset = "0x54923F0", VA = "0x1854935F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x54936B0", Offset = "0x54924B0", VA = "0x1854936B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5493D50", Offset = "0x5492B50", VA = "0x185493D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public BGFJIOKMFOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5492620", Offset = "0x5491420", VA = "0x185492620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x54934D0", Offset = "0x54922D0", VA = "0x1854934D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 MIPKOAEADFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x173BE60", Offset = "0x173AC60", VA = "0x18173BE60")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x173BD80", Offset = "0x173AB80", VA = "0x18173BD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JANEBGLCBEN PNFPKHKPMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77FC20", Offset = "0x77EA20", VA = "0x18077FC20")]
		get
		{
			return default(JANEBGLCBEN);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x549A050", Offset = "0x5498E50", VA = "0x18549A050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static FAPAHEEPDPA EBMHMHOHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54992E0", Offset = "0x54980E0", VA = "0x1854992E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JIFAKLHEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x54986B0", Offset = "0x54974B0", VA = "0x1854986B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool AFILJBLDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5499780", Offset = "0x5498580", VA = "0x185499780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LKCLDMDGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x54991D0", Offset = "0x5497FD0", VA = "0x1854991D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x54996E0", Offset = "0x54984E0", VA = "0x1854996E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FHDGGOHOMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5499640", Offset = "0x5498440", VA = "0x185499640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5498960", Offset = "0x5497760", VA = "0x185498960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x549A430", Offset = "0x5499230", VA = "0x18549A430")]
	public FAPAHEEPDPA(BJGFKEHIKGF GECJAMOEJIF, EDKJPBKBAPH BGCGOAGJJGA, ClusterLODConfig APEENHAPIHC, MonoBehaviour IKNELLIJLDL, Material IIBEHOBFGBE, ClusterMeshRenderer HKGHCFODFME, MeshFilter JEKMICAKECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x54985B0", Offset = "0x54973B0", VA = "0x1854985B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5498EB0", Offset = "0x5497CB0", VA = "0x185498EB0")]
	public static void HNMGJGDFPOH(Vector3 LOEKIAHOMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5498FE0", Offset = "0x5497DE0", VA = "0x185498FE0")]
	private void IJFLMMEKJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5499460", Offset = "0x5498260", VA = "0x185499460")]
	private void MNECPNDJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x54987D0", Offset = "0x54975D0", VA = "0x1854987D0")]
	private void EKMGIHJLGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5497E70", Offset = "0x5496C70", VA = "0x185497E70")]
	public void DFIPOGKLIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5498A00", Offset = "0x5497800", VA = "0x185498A00")]
	[AsyncStateMachine(typeof(FEEDPCMDPGG))]
	public Task GCKMDFDDBAE(CEJMOEANPLC PDHDLCNGDKN, CancellationToken LAKDHEPMDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5497B20", Offset = "0x5496920", VA = "0x185497B20")]
	[IteratorStateMachine(typeof(CENDNOGDAFF))]
	private IEnumerator<LGOBDJKCLEL> BEFAHODPHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5499860", Offset = "0x5498660", VA = "0x185499860")]
	[AsyncStateMachine(typeof(CNJNBKELNPF))]
	private Task OCJHNOKBMBM(CEJMOEANPLC MONJKDDCILH, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5498B40", Offset = "0x5497940", VA = "0x185498B40")]
	public void GELDHCBMDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x549A340", Offset = "0x5499140", VA = "0x18549A340")]
	public void PNELFKMOHIN(IEnumerable<HIALMMKAOEC> GIOEPADOBIM, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5497B90", Offset = "0x5496990", VA = "0x185497B90")]
	public void BEPFJIOILIC(IEnumerable<HIALMMKAOEC> GIOEPADOBIM, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54999A0", Offset = "0x54987A0", VA = "0x1854999A0")]
	public List<ClusterMeshRenderer> OIOBDLBNNLM(List<JIJHDMJKEEF> ECOKHAGGAGC, HIHDGKIDBHE MHPJOFNEKOG, HNFBDONLIFA FALJPHMEHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5499420", Offset = "0x5498220", VA = "0x185499420")]
	public HNFBDONLIFA MHNJKJFDENM(Vector3 BJOLPFLAOOG)
	{
		return default(HNFBDONLIFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5497E10", Offset = "0x5496C10", VA = "0x185497E10")]
	public void DBJFGCNPBEI(FCDLGAIDMKC OAKILALMLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5499340", Offset = "0x5498140", VA = "0x185499340")]
	public bool KPEJHDNBIHJ(FCDLGAIDMKC OAKILALMLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5499560", Offset = "0x5498360", VA = "0x185499560")]
	public void MOACOMIGCBK(JIJHDMJKEEF GMAELPCKHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x54993A0", Offset = "0x54981A0", VA = "0x1854993A0")]
	public void LHPDMBMCEBN(KMJKLEFLOJJ DHBOJIINPOH, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x54995C0", Offset = "0x54983C0", VA = "0x1854995C0")]
	public void MOLBPGHHCGD(KMJKLEFLOJJ DHBOJIINPOH, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5499070", Offset = "0x5497E70", VA = "0x185499070")]
	private void IKDOLPKOKMP(Vector3 ICNDOIOFCLN, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5498D50", Offset = "0x5497B50", VA = "0x185498D50")]
	private void HNCOEJOPDFJ(Vector3 ICNDOIOFCLN, HNFBDONLIFA FALJPHMEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5499270", Offset = "0x5498070", VA = "0x185499270")]
	[IteratorStateMachine(typeof(BGFJIOKMFOL))]
	private IEnumerator<LGOBDJKCLEL> JMHJNOEAMAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x549A180", Offset = "0x5498F80", VA = "0x18549A180")]
	private int PCGLKJDNCAO(int BNNEENLPEFO, int NPJCHCBJABM, List<KMJKLEFLOJJ> NPOAMAEFAJF, byte LDPMEOOMILD, ref int HHKMOMIMKNA, float HBEKOKCHIKH = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x54983D0", Offset = "0x54971D0", VA = "0x1854983D0")]
	public void DOHHNJJEEIG(JIJHDMJKEEF NMNKGKHKMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x549A300", Offset = "0x5499100", VA = "0x18549A300")]
	public bool PEPPNPHPJOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x90D2C0", Offset = "0x90C0C0", VA = "0x18090D2C0")]
	public Material FBIKEOGCIEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5498920", Offset = "0x5497720", VA = "0x185498920")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x54957D0", Offset = "0x54945D0", VA = "0x1854957D0")]
	public CPDKPHIFOHD(NFHFGCGPPAN KIGAICGDOPA, NativeList<float3> FMMBKMLJEGH, NativeMultiHashMap<int, int> BOPOMBBFJKP, NativeArray<int> EEHJEOFNCDA, Vector3 CIEJPFHBIGC, float MIMNILBCKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5495370", Offset = "0x5494170", VA = "0x185495370")]
	private int EDLMDKNCCNP(float3 ICNDOIOFCLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5495110", Offset = "0x5493F10", VA = "0x185495110")]
	private int EBPPDAGHIJG(int OJFFKHAMPMJ, int BIMCDHOFDCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54953A0", Offset = "0x54941A0", VA = "0x1854953A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54A2680", Offset = "0x54A1480", VA = "0x1854A2680")]
	public void KJIGMDGOJDE(int JDOAPHIBGNO, Allocator PBEDBDBGIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54A25A0", Offset = "0x54A13A0", VA = "0x1854A25A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x549CEC0", Offset = "0x549BCC0", VA = "0x18549CEC0")]
	public GKFIEDEAAII(KNPDFCFKJCH JNBGMEFFPPM, NFHFGCGPPAN KIGAICGDOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x549CE20", Offset = "0x549BC20", VA = "0x18549CE20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54924E0", Offset = "0x54912E0", VA = "0x1854924E0")]
	public ANLGFJHOBPC(KNPDFCFKJCH AMNHGMDFAKB, NFHFGCGPPAN KIGAICGDOPA, NFHFGCGPPAN APEJJGGKKOO, float BGMJHCGFPDF, float BNDBJFDKNPP, Vector3 MPDELAEIHHG, float BEELPDKDFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5490FF0", Offset = "0x548FDF0", VA = "0x185490FF0")]
	private float3 DJKPIICJHKK(int OJFFKHAMPMJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5491F30", Offset = "0x5490D30", VA = "0x185491F30")]
	private void LOIHIBNLFBB(int OJFFKHAMPMJ, out float3 ANBMFJNMPCN, out float3 JBDCFLNIANO, out float4 EMHMKFJJOJN, out float4 NCKNIGNNFIB, out float2 IJLMDOLPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x54910A0", Offset = "0x548FEA0", VA = "0x1854910A0")]
	private int EJLNCMHCNDP(int KOEOKKMPNGE, int OKJFAHCDPGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5492120", Offset = "0x5490F20", VA = "0x185492120")]
	private void LPKIPJKMKGG(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5492350", Offset = "0x5491150", VA = "0x185492350")]
	private bool MJLBMKHJNMO(int KOEOKKMPNGE, int OKJFAHCDPGF, float HFPEBAMGNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5490F30", Offset = "0x548FD30", VA = "0x185490F30")]
	private bool BOLIDEEJLMO(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, float HFPEBAMGNJH, bool JENEOMCAPBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5491CC0", Offset = "0x5490AC0", VA = "0x185491CC0")]
	private bool LGLGGFCDAGO(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, float HFPEBAMGNJH, bool JENEOMCAPBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5492330", Offset = "0x5491130", VA = "0x185492330")]
	private void MJDCCDEACOA(int KOEOKKMPNGE, int OKJFAHCDPGF, int EKPDMDHJDOI, out int GLCINECBPJC, out int OPCJLCONIKP, out int LFJLMOGGGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x54913A0", Offset = "0x54901A0", VA = "0x1854913A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x549DF30", Offset = "0x549CD30", VA = "0x18549DF30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh APNGDKNNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh CJDNLBCGAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GLEBHCDMLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6747F0", Offset = "0x6735F0", VA = "0x1806747F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x674B90", Offset = "0x673990", VA = "0x180674B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte DFPFCOOGKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x72D150", Offset = "0x72BF50", VA = "0x18072D150")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x72D160", Offset = "0x72BF60", VA = "0x18072D160", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int HAMADIJDDEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD50", Offset = "0x9A9B50", VA = "0x1809AAD50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xDDDB90", Offset = "0xDDC990", VA = "0x180DDDB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ONLCOFMCGBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD40", Offset = "0x9A9B40", VA = "0x1809AAD40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x14259E0", Offset = "0x14247E0", VA = "0x1814259E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DEFEOLMKKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x549D6A0", Offset = "0x549C4A0", VA = "0x18549D6A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x549D8C0", Offset = "0x549C6C0", VA = "0x18549D8C0")]
		public void EDOEBDDIOJI(BBIMGAEJAFH LDPMEOOMILD, out int HEJCNEIPLFH, out int NPEKFKPGEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x549D4F0", Offset = "0x549C2F0", VA = "0x18549D4F0")]
		public void APMGONIGJJF(BBIMGAEJAFH LDPMEOOMILD, OHBJADHEDAF AMJMNCKBDPB, int LEABJDADMHB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x549DB90", Offset = "0x549C990", VA = "0x18549DB90")]
		public void MJLLBJBOLFM(NativeList<CNLNAAJIOJC> PLBPIHNHHHH, Transform ICFDLHANCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x549DAF0", Offset = "0x549C8F0", VA = "0x18549DAF0")]
		public void FCHFKIOJHPF(Mesh KIGAICGDOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x549D450", Offset = "0x549C250", VA = "0x18549D450")]
		public void AGGFNLOKDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x549D6C0", Offset = "0x549C4C0", VA = "0x18549D6C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x549DF70", Offset = "0x549CD70", VA = "0x18549DF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DABHMEMDMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE20", Offset = "0x6ECC20", VA = "0x1806EDE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x895130", Offset = "0x893F30", VA = "0x180895130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JPGDAFDKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x54A3D70", Offset = "0x54A2B70", VA = "0x1854A3D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54A3790", Offset = "0x54A2590", VA = "0x1854A3790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54A38F0", Offset = "0x54A26F0", VA = "0x1854A38F0")]
	public int GKFBOADDEJP(int IBEJJPAHPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54A2990", Offset = "0x54A1790", VA = "0x1854A2990")]
	public void BDPMMMIGKID(ADDMOFMMLMJ KFKCBDLHFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x54A2D10", Offset = "0x54A1B10", VA = "0x1854A2D10")]
	public void DAJJIFBHNGJ(Transform ICFDLHANCHH, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x54A2B50", Offset = "0x54A1950", VA = "0x1854A2B50")]
	public bool CCLABGKGKML(bool MGJMOPDPEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54A3920", Offset = "0x54A2720", VA = "0x1854A3920")]
	public void ICCKNHJHMCJ(Transform MHPJOFNEKOG, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54A34E0", Offset = "0x54A22E0", VA = "0x1854A34E0")]
	public bool DOHHNJJEEIG(JIJHDMJKEEF NMNKGKHKMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x54A3DC0", Offset = "0x54A2BC0", VA = "0x1854A3DC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5497340", Offset = "0x5496140", VA = "0x185497340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54974D0", Offset = "0x54962D0", VA = "0x1854974D0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54973B0", Offset = "0x54961B0", VA = "0x1854973B0")]
	public void ELGBPIMHCCH(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO, Transform MHPJOFNEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5497150", Offset = "0x5495F50", VA = "0x185497150")]
	public void DOHHNJJEEIG(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5497550", Offset = "0x5496350", VA = "0x185497550")]
	private PMEDGNPLPBG.HEFJHLCCNNO HFDPHDMCDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x54970B0", Offset = "0x5495EB0", VA = "0x1854970B0")]
	private bool AHJJDGILMCH(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5497680", Offset = "0x5496480", VA = "0x185497680")]
	private void JAGEBOCDBCD(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5497970", Offset = "0x5496770", VA = "0x185497970")]
	public bool NHLOBNFEHGN(PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x54976E0", Offset = "0x54964E0", VA = "0x1854976E0")]
	public bool LPIFGEKCIOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5497470", Offset = "0x5496270", VA = "0x185497470")]
	private PMEDGNPLPBG.HEFJHLCCNNO GANBEODICPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x54979A0", Offset = "0x54967A0", VA = "0x1854979A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5493D00", Offset = "0x5492B00", VA = "0x185493D00")]
	public CFJBIMFPFKB(int MNHAGCEIBHD, int AIABELCACMB, float MANILLFBOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5493790", Offset = "0x5492590", VA = "0x185493790")]
	public void IBGLCMIHDHC(IHEFOKFJOIN MKNLKKNPKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54936F0", Offset = "0x54924F0", VA = "0x1854936F0")]
	private int AMCKMHPFPIO(ADDMOFMMLMJ BAIMHJNEKGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x54938B0", Offset = "0x54926B0", VA = "0x1854938B0")]
	private void IBGLCMIHDHC(ADDMOFMMLMJ BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5493AF0", Offset = "0x54928F0", VA = "0x185493AF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
			[DebuggerHidden]
			public EFGDBLNKKFI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5496EC0", Offset = "0x5495CC0", VA = "0x185496EC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5497070", Offset = "0x5495E70", VA = "0x185497070", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5496FD0", Offset = "0x5495DD0", VA = "0x185496FD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5496FD0", Offset = "0x5495DD0", VA = "0x185496FD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5496E60", Offset = "0x5495C60", VA = "0x185496E60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<KMJKLEFLOJJ> LCNEJGIDMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5496E40", Offset = "0x5495C40", VA = "0x185496E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> ODFIIGPONAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PMEDGNPLPBG JBGPNHNENMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HNFBDONLIFA EENLANIAFHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x65F390", Offset = "0x65E190", VA = "0x18065F390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(HNFBDONLIFA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x65F4F0", Offset = "0x65E2F0", VA = "0x18065F4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IGLDONGFBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5496E50", Offset = "0x5495C50", VA = "0x185496E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5495A20", Offset = "0x5494820", VA = "0x185495A20")]
		public static ClusterMeshRenderer Create(PMEDGNPLPBG KIGAICGDOPA, ClusterMeshRenderer HKGHCFODFME, MeshFilter JEKMICAKECA, HIHDGKIDBHE MHPJOFNEKOG, HNFBDONLIFA FALJPHMEHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5495BC0", Offset = "0x54949C0", VA = "0x185495BC0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5496380", Offset = "0x5495180", VA = "0x185496380", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JIJHDMJKEEF NMNKGKHKMCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5496170", Offset = "0x5494F70", VA = "0x185496170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5495E10", Offset = "0x5494C10", VA = "0x185495E10")]
		public void Init(PMEDGNPLPBG KIGAICGDOPA, MeshFilter JEKMICAKECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5495C20", Offset = "0x5494A20", VA = "0x185495C20")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x54964B0", Offset = "0x54952B0", VA = "0x1854964B0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 ICNDOIOFCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x54966C0", Offset = "0x54954C0", VA = "0x1854966C0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5495DA0", Offset = "0x5494BA0", VA = "0x185495DA0")]
		[IteratorStateMachine(typeof(EFGDBLNKKFI))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x54961F0", Offset = "0x5494FF0", VA = "0x1854961F0")]
		public void SetupTagAndLayer(string OKDNGJDIOCM, int FALJPHMEHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x54961D0", Offset = "0x5494FD0", VA = "0x1854961D0")]
		public bool Remove(JIJHDMJKEEF NMNKGKHKMCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x54A2870", Offset = "0x54A1670", VA = "0x1854A2870")]
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
		[Cpp2IlInjected.Address(RVA = "0xA79480", Offset = "0xA78280", VA = "0x180A79480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA794B0", Offset = "0xA782B0", VA = "0x180A794B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x549E120", Offset = "0x549CF20", VA = "0x18549E120")]
	public void BLNLPEOGOOG(NFHFGCGPPAN EEBNCHEHFGH, NativeList<LDLANLLLFED> MEOBJDMPABM, float OLIFDPKHJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x549F330", Offset = "0x549E130", VA = "0x18549F330")]
	public void KHOGKPNLIBO(Transform MHPJOFNEKOG, bool KEDNJGFDDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x549F040", Offset = "0x549DE40", VA = "0x18549F040")]
	public void CCLABGKGKML(PMEDGNPLPBG GHGAIHKFDCM, bool MGJMOPDPEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x549F1F0", Offset = "0x549DFF0", VA = "0x18549F1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x549F300", Offset = "0x549E100", VA = "0x18549F300")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x549D380", Offset = "0x549C180", VA = "0x18549D380")]
	public HCKMMFHDHIN(JAFPLEGCKIN MOGAJEFFDEG, Vector3 MPDELAEIHHG, bool KEDNJGFDDJM, float JEHABBOLDKG, float AHNKLGCDBIM, float JJNLGHHLPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x549CEF0", Offset = "0x549BCF0", VA = "0x18549CEF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5490EB0", Offset = "0x548FCB0", VA = "0x185490EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x549E050", Offset = "0x549CE50", VA = "0x18549E050")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x549C7E0", Offset = "0x549B5E0", VA = "0x18549C7E0")]
	public FDEOKJDICHE(int MNHAGCEIBHD, int AIABELCACMB, float MANILLFBOKO, int AEHIMDAHOHG, float JBHOIGMMDKI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x549C110", Offset = "0x549AF10", VA = "0x18549C110")]
	public void GPEDLAFOKFE(List<JIJHDMJKEEF> ECOKHAGGAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x549C310", Offset = "0x549B110", VA = "0x18549C310")]
	public bool KJFIFLPGIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x549C040", Offset = "0x549AE40", VA = "0x18549C040")]
	private float EJMDLDPIAHK(Vector3 HKPINKIDAGP, Vector3 MFHJKPMAGKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x549C0C0", Offset = "0x549AEC0", VA = "0x18549C0C0")]
	private float EJMDLDPIAHK(Vector3 LBLAPKMJFKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x549B7B0", Offset = "0x549A5B0", VA = "0x18549B7B0")]
	private bool DLGELJLBFBG(ADDMOFMMLMJ DHCGGEHBBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x549AB80", Offset = "0x5499980", VA = "0x18549AB80")]
	private COBFOIODPNA ALEEOEMGHIJ(List<JIJHDMJKEEF> KAJMGGJHKBP, EHMJCCGJEGC KAOGMJBGHOD)
	{
		return default(COBFOIODPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x549C380", Offset = "0x549B180", VA = "0x18549C380")]
	private void MDMEGNKDBLN(List<JIJHDMJKEEF> ECOKHAGGAGC, Vector3[] ACDLGEOKBFJ, Vector3[] NPENFJNJICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JNKKBMNGGJB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x54A0E30", Offset = "0x549FC30", VA = "0x1854A0E30")]
	public static Bounds NFINENKJDGO(List<JIJHDMJKEEF> ECOKHAGGAGC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x54A0FE0", Offset = "0x549FDE0", VA = "0x1854A0FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694580", Offset = "0x693380", VA = "0x180694580")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694C40", VA = "0x180695E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PMEDGNPLPBG.HEFJHLCCNNO DHCGGEHBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JFIGGJOJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x833DF0", Offset = "0x832BF0", VA = "0x180833DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x549FA80", Offset = "0x549E880", VA = "0x18549FA80")]
	[ECPMKACBNFP(JMKOAIIKPBP.ExitingPlayMode, 0)]
	private void AMCMKDDOKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x549FAF0", Offset = "0x549E8F0", VA = "0x18549FAF0")]
	public void BLNLPEOGOOG(PMEDGNPLPBG.HEFJHLCCNNO KIBEMDDBAJO, Transform KKCKBHHGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x54A0660", Offset = "0x549F460", VA = "0x1854A0660")]
	public void EFLMFGPCNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x54A05F0", Offset = "0x549F3F0", VA = "0x1854A05F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x54A0D50", Offset = "0x549FB50", VA = "0x1854A0D50")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x54A0D90", Offset = "0x549FB90", VA = "0x1854A0D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
				public BLHGMEJDHAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5493510", Offset = "0x5492310", VA = "0x185493510")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5493560", Offset = "0x5492360", VA = "0x185493560")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x54935B0", Offset = "0x54923B0", VA = "0x1854935B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action NNFFPHGAEFB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6BDA50", Offset = "0x6BC850", VA = "0x1806BDA50", Slot = "4")]
			public CICJIOMPGJM EOEPEPPLMFJ(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2941C60", Offset = "0x2940A60", VA = "0x182941C60", Slot = "5")]
			public CICJIOMPGJM IADLIEJIABG(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2941C80", Offset = "0x2940A80", VA = "0x182941C80", Slot = "6")]
			public CICJIOMPGJM NALHKMLDLLH(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B9EB20", Offset = "0x3B9D920", VA = "0x183B9EB20", Slot = "7")]
			public CICJIOMPGJM OHECJANHBEC(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
			public JKNAICJEECJ(Func<JobHandle> BNJNMHPEKLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x549F680", Offset = "0x549E480", VA = "0x18549F680")]
			public void BLFPKNOMADF(Action GJCDKEEDPEF, Action HGKDPBBKEJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x549F910", Offset = "0x549E710", VA = "0x18549F910")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public PFMIOLMKKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x54A2980", Offset = "0x54A1780", VA = "0x1854A2980")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public JHFANEEMJMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x549F620", Offset = "0x549E420", VA = "0x18549F620")]
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
			[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x54A1190", Offset = "0x549FF90", VA = "0x1854A1190")]
		public CICJIOMPGJM Add(Func<JobHandle> BNJNMHPEKLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x54A1490", Offset = "0x54A0290", VA = "0x1854A1490")]
		public void Remove(CICJIOMPGJM BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x54A12F0", Offset = "0x54A00F0", VA = "0x1854A12F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x54A1660", Offset = "0x54A0460", VA = "0x1854A1660")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x54A18B0", Offset = "0x54A06B0", VA = "0x1854A18B0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x54A12E0", Offset = "0x54A00E0", VA = "0x1854A12E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x54A2970", Offset = "0x54A1770", VA = "0x1854A2970")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2941C60", Offset = "0x2940A60", VA = "0x182941C60", Slot = "4")]
			public IGCEONLLKAC EOEPEPPLMFJ(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2941C80", Offset = "0x2940A80", VA = "0x182941C80", Slot = "5")]
			public IGCEONLLKAC DLLKGOLEMLM(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3B9EB20", Offset = "0x3B9D920", VA = "0x183B9EB20", Slot = "6")]
			public IGCEONLLKAC OHECJANHBEC(Action KDJGJCHCIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
			public OGDJMLBMGPN(JobHandle MNHBLNJHMBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x54A28F0", Offset = "0x54A16F0", VA = "0x1854A28F0")]
			public void DNAKJMIBDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x54A2930", Offset = "0x54A1730", VA = "0x1854A2930")]
			public void DOHHNJJEEIG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<OGDJMLBMGPN> JLCGGCHLJJI;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x54A1D90", Offset = "0x54A0B90", VA = "0x1854A1D90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x54A19B0", Offset = "0x54A07B0", VA = "0x1854A19B0")]
		public IGCEONLLKAC Add(JobHandle MNHBLNJHMBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x54A1CA0", Offset = "0x54A0AA0", VA = "0x1854A1CA0")]
		public void Remove(IGCEONLLKAC BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x54A1B30", Offset = "0x54A0930", VA = "0x1854A1B30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x54A1A40", Offset = "0x54A0840", VA = "0x1854A1A40")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x54A1EB0", Offset = "0x54A0CB0", VA = "0x1854A1EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x54A1F70", Offset = "0x54A0D70", VA = "0x1854A1F70")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x54A2080", Offset = "0x54A0E80", VA = "0x1854A2080")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
