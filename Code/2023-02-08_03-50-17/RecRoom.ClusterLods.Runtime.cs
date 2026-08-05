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
				[Cpp2IlInjected.Address(RVA = "0x1CF4610", Offset = "0x1CF3410", VA = "0x181CF4610")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x15F1CE0", Offset = "0x15F0AE0", VA = "0x1815F1CE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1CF45D0", Offset = "0x1CF33D0", VA = "0x181CF45D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CEB680", Offset = "0x1CEA480", VA = "0x181CEB680")]
		public LODSettings NFGCBICLLLG(MHLJBECPMPN EFELDHJGAJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB690", Offset = "0x1CEA490", VA = "0x181CEB690")]
		public int OKNGHHNEMAF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB580", Offset = "0x1CEA380", VA = "0x181CEB580")]
		public int FPOHBCKKGOE(bool DMBPBGMAIHL, Vector3 CDILOBFKDGL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB6B0", Offset = "0x1CEA4B0", VA = "0x181CEB6B0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GJNEDEOMLHJ
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
public interface OJHGLMMOJBI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNJIKEMPMPL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AFFACHHGIAN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int NCLDHHHKCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JAGLBOEJJFD> CPAJIGCFJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GJNEDEOMLHJ MKEJCBKFHPI
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
	void UpdateClusterDistances(Vector3 HDBKKDGKJKN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(MPDNMBEGDAL BFKBHAILEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JAGLBOEJJFD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int KMLCCMNFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int HJLCBCAPDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GNCEKKFIJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NDMMNDNEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte BPEFFIKIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BFIEBAADALM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LBIPELLBDOG
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
	private struct KOKJMPFFHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BFIEBAADALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LDNBHEGFOMH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LDNBHEGFOMH <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF22A0", Offset = "0x1CF10A0", VA = "0x181CF22A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFPIDGODHKE : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BFIEBAADALM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public DFPIDGODHKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1CECBB0", Offset = "0x1CEB9B0", VA = "0x181CECBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1CECC70", Offset = "0x1CEBA70", VA = "0x181CECC70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PKHAHAFNOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BFIEBAADALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LDNBHEGFOMH worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LDNBHEGFOMH <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6650", Offset = "0x1CF5450", VA = "0x181CF6650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JIAEIPJBMEG : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private KDNIAKIKLPJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BFIEBAADALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
		[DebuggerHidden]
		public JIAEIPJBMEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1CEE910", Offset = "0x1CED710", VA = "0x181CEE910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1CEF7C0", Offset = "0x1CEE5C0", VA = "0x181CEF7C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int ENDGHFKJHKD = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan GKFIAHBMFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer FADOHPMJJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter KKOCBHPLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject ANOCMMFCCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CMKKIKFOOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EECILACPJOA CLBIBJPGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<MPDNMBEGDAL> MCFGDKKCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<MPDNMBEGDAL> CDNEKPPPMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<MPDNMBEGDAL> BGLIIEJGINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int FCLMFCNMBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LBIPELLBDOG CNEACNPCNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<AFFACHHGIAN>[] COPPPNBNFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<JAGLBOEJJFD>[] OPOLLCHPKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource HBEGILELLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool GDFKMLJFKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HDOELFFLJBF ONEFKKMKKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HDOELFFLJBF MDDGFPOKJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int LOLCEBKAAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int FMBLAOCGFHI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static BFIEBAADALM NIAKJKIAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EABIDDONALM NHOOOEDNMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BMHOKKNGNEL BBPPFKBIEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour HNPPANGFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material MNCBHDLGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<OJHGLMMOJBI> EFFJHDCEPKK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig MKGHNDGBDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DADJIPABJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1CE82F0", Offset = "0x1CE70F0", VA = "0x181CE82F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7700", Offset = "0x1CE6500", VA = "0x181CE7700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LBIPELLBDOG IBGCDHANIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB184E0", Offset = "0xB172E0", VA = "0x180B184E0")]
		get
		{
			return default(LBIPELLBDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE83B0", Offset = "0x1CE71B0", VA = "0x181CE83B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BFIEBAADALM GEHLGJGIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE76A0", Offset = "0x1CE64A0", VA = "0x181CE76A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OKFBABIGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7E30", Offset = "0x1CE6C30", VA = "0x181CE7E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool FFJONKOAPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7D50", Offset = "0x1CE6B50", VA = "0x181CE7D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> GBCOBPMAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE84E0", Offset = "0x1CE72E0", VA = "0x181CE84E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE9890", Offset = "0x1CE8690", VA = "0x181CE9890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HIBMFGPDOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE8150", Offset = "0x1CE6F50", VA = "0x181CE8150")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE80B0", Offset = "0x1CE6EB0", VA = "0x181CE80B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1CE99A0", Offset = "0x1CE87A0", VA = "0x181CE99A0")]
	public BFIEBAADALM(EABIDDONALM NHOOOEDNMNL, BMHOKKNGNEL BBPPFKBIEHK, ClusterLODConfig HOHGPAPLMEA, MonoBehaviour HNPPANGFOCL, Material MNCBHDLGMOF, ClusterMeshRenderer FADOHPMJJOL, MeshFilter KKOCBHPLPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7B40", Offset = "0x1CE6940", VA = "0x181CE7B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9520", Offset = "0x1CE8320", VA = "0x181CE9520")]
	public static void PLEHBDGCGHJ(Vector3 BCGHHNIKINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7CC0", Offset = "0x1CE6AC0", VA = "0x181CE7CC0")]
	private void FGJDDDKJODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1CE81F0", Offset = "0x1CE6FF0", VA = "0x181CE81F0")]
	private void KCNLINADJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7550", Offset = "0x1CE6350", VA = "0x181CE7550")]
	private void CIAPNOLJCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8580", Offset = "0x1CE7380", VA = "0x181CE8580")]
	public void MLCIAKOPECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7710", Offset = "0x1CE6510", VA = "0x181CE7710")]
	[AsyncStateMachine(typeof(KOKJMPFFHPK))]
	public Task DDCKPKDCHLO(LDNBHEGFOMH FONHNFMDGGB, CancellationToken IKGDIFFPDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7850", Offset = "0x1CE6650", VA = "0x181CE7850")]
	[IteratorStateMachine(typeof(DFPIDGODHKE))]
	private IEnumerator<KDNIAKIKLPJ> DODLLCDFELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8AE0", Offset = "0x1CE78E0", VA = "0x181CE8AE0")]
	[AsyncStateMachine(typeof(PKHAHAFNOBD))]
	private Task MONFLFGHNLN(LDNBHEGFOMH FNKMPAOPGDF, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7060", Offset = "0x1CE5E60", VA = "0x181CE7060")]
	public void AAODCNBFPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7C40", Offset = "0x1CE6A40", VA = "0x181CE7C40")]
	public void FAEDIJFPHDA(IEnumerable<AFFACHHGIAN> DKOHGLGNGLC, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE78C0", Offset = "0x1CE66C0", VA = "0x181CE78C0")]
	public void DOMOPPPIKDH(IEnumerable<AFFACHHGIAN> DKOHGLGNGLC, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8D10", Offset = "0x1CE7B10", VA = "0x181CE8D10")]
	public List<ClusterMeshRenderer> PHNAGGOJGCP(List<MPDNMBEGDAL> IJKOIMBOKCL, IBPFMLOPCID OJIIPOMCHKP, GJNEDEOMLHJ AHKNLNAGBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8CD0", Offset = "0x1CE7AD0", VA = "0x181CE8CD0")]
	public GJNEDEOMLHJ OPAINKBCDAN(Vector3 JOBPLHDEMJH)
	{
		return default(GJNEDEOMLHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9650", Offset = "0x1CE8450", VA = "0x181CE9650")]
	public void PMGMHPALBAP(OJHGLMMOJBI CAOJKIPGPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7FD0", Offset = "0x1CE6DD0", VA = "0x181CE7FD0")]
	public bool ICADAKKNAJG(OJHGLMMOJBI CAOJKIPGPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8310", Offset = "0x1CE7110", VA = "0x181CE8310")]
	public void KKLLDBHAGDI(MPDNMBEGDAL DGELPPACGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7F50", Offset = "0x1CE6D50", VA = "0x181CE7F50")]
	public void IBPDFPNDAMC(JAGLBOEJJFD MNBGKMFFCML, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8030", Offset = "0x1CE6E30", VA = "0x181CE8030")]
	public void IEEIBLGDECG(JAGLBOEJJFD MNBGKMFFCML, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CE73F0", Offset = "0x1CE61F0", VA = "0x181CE73F0")]
	private void BKNKEFDNEBH(Vector3 HDBKKDGKJKN, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1CE93C0", Offset = "0x1CE81C0", VA = "0x181CE93C0")]
	private void PJCPADEAEDD(Vector3 HDBKKDGKJKN, GJNEDEOMLHJ AHKNLNAGBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8C20", Offset = "0x1CE7A20", VA = "0x181CE8C20")]
	[IteratorStateMachine(typeof(JIAEIPJBMEG))]
	private IEnumerator<KDNIAKIKLPJ> NNEKMMAMIOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7270", Offset = "0x1CE6070", VA = "0x181CE7270")]
	private int BKCBGFKKOGD(int DJIEOHJNDEK, int FGJODFDPLMI, List<JAGLBOEJJFD> PJGKNPOGJDD, byte EFELDHJGAJI, ref int NIEKNOIOGJL, float MDGOACBEIIP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE96B0", Offset = "0x1CE84B0", VA = "0x181CE96B0")]
	public void PPEAGPDBOCM(MPDNMBEGDAL BFKBHAILEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8370", Offset = "0x1CE7170", VA = "0x181CE8370")]
	public bool KOHBEDCAFHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82A080", Offset = "0x828E80", VA = "0x18082A080")]
	public Material KPBGKKGKOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8C90", Offset = "0x1CE7A90", VA = "0x181CE8C90")]
	public int OKNGHHNEMAF()
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
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct FIGKBBKKMJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> JMECHPNJPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> HMNGPIIPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> HJBFDDCOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> CPJOMIANFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> CKDAOFHFBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> BCPNDHEOJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> MJODGLOKDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 MHPOEMMEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float HCOAMANDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> INHHCCLCFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> JHDKLGPIIDP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE050", Offset = "0x1CECE50", VA = "0x181CEE050")]
	public FIGKBBKKMJG(IDNKHAOLAID KMIFLOHLDEH, NativeList<float3> MJODGLOKDHE, NativeMultiHashMap<int, int> INHHCCLCFAO, NativeArray<int> JHDKLGPIIDP, Vector3 MHPOEMMEJAE, float HCOAMANDEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE020", Offset = "0x1CECE20", VA = "0x181CEE020")]
	private int FLLCKMNABHN(float3 HDBKKDGKJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CED990", Offset = "0x1CEC790", VA = "0x181CED990")]
	private int EKCABBDKDPO(int LFDIJNFJPLK, int CKMEBFKEHMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1CEDBF0", Offset = "0x1CEC9F0", VA = "0x181CEDBF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HANNOJDGJGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> INHHCCLCFAO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> JHDKLGPIIDP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int NDFDHEHPAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> MOKFBAMKEGL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE4D0", Offset = "0x1CED2D0", VA = "0x181CEE4D0")]
	public void CGDEEAMGDDK(int IAGJOCBDLGC, Allocator CMCENMLGNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE6C0", Offset = "0x1CED4C0", VA = "0x181CEE6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public HANNOJDGJGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IBLIDDLBHEI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> FNCIFLOLDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> AJEGBIFCPAN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE840", Offset = "0x1CED640", VA = "0x181CEE840")]
	public IBLIDDLBHEI(HANNOJDGJGF BHGGMPAHABC, IDNKHAOLAID KMIFLOHLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE7A0", Offset = "0x1CED5A0", VA = "0x181CEE7A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LLAOGHFAMGP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> NECHFLOCBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> IPGDKPIGMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> NAAKHNGMCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> NOKLDNFIBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> GCLIHHPMPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> MOKFBAMKEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> FNCIFLOLDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> FKHGMNLDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> MDLMIFDNBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> GBBNCAAEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> OIOEMKNCOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> PGELKAADLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> CDIEBNHPDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float GKDKHHPNNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float CBGKGPDCELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 PGFPOLGNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FPPPLFDBBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float AEDCENCIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float LEEANLGODCO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3E30", Offset = "0x1CF2C30", VA = "0x181CF3E30")]
	public LLAOGHFAMGP(HANNOJDGJGF JBCCNOIJFNC, IDNKHAOLAID KMIFLOHLDEH, IDNKHAOLAID LLKPMMKBBEP, float AEDCENCIMNP, float LEEANLGODCO, Vector3 PGFPOLGNKAI, float FPPPLFDBBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3A60", Offset = "0x1CF2860", VA = "0x181CF3A60")]
	private float3 JOEHAFGOEJA(int LFDIJNFJPLK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3870", Offset = "0x1CF2670", VA = "0x181CF3870")]
	private void JJLOMAMDDPF(int LFDIJNFJPLK, out float3 LGHEFLKBJNB, out float3 MCCLHNPJHDH, out float4 GEEPCFONEFE, out float4 FCBBHDKOIEF, out float2 KPKAMFIMBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3B10", Offset = "0x1CF2910", VA = "0x181CF3B10")]
	private int JOOADDNODCA(int ANOEKCEFAOO, int PEHNNGIGFHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2BB0", Offset = "0x1CF19B0", VA = "0x181CF2BB0")]
	private void DGDPCOPKKBI(int ANOEKCEFAOO, int PEHNNGIGFHG, int ODFHPAOHEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1CF36E0", Offset = "0x1CF24E0", VA = "0x181CF36E0")]
	private bool JCIJEONKPIH(int ANOEKCEFAOO, int PEHNNGIGFHG, float PNLKJMCEIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2AF0", Offset = "0x1CF18F0", VA = "0x181CF2AF0")]
	private bool CCEBPFAJIHA(int ANOEKCEFAOO, int PEHNNGIGFHG, int ODFHPAOHEPH, float PNLKJMCEIDA, bool OMGOLDJPFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2880", Offset = "0x1CF1680", VA = "0x181CF2880")]
	private bool AELONCCGNEI(int ANOEKCEFAOO, int PEHNNGIGFHG, int ODFHPAOHEPH, float PNLKJMCEIDA, bool OMGOLDJPFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3E10", Offset = "0x1CF2C10", VA = "0x181CF3E10")]
	private void LJICGPLFPJB(int ANOEKCEFAOO, int PEHNNGIGFHG, int ODFHPAOHEPH, out int EENCBGEHADN, out int LOECFACFJHL, out int IKOMGIEMHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2DC0", Offset = "0x1CF1BC0", VA = "0x181CF2DC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BDDPNCJFJNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BBBAAHDLCAK : IDisposable, JAGLBOEJJFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds EIJJIFHMJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<MPDNMBEGDAL> IJKOIMBOKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 IENPENGFCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 FOGPCJCHKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int FHLIHECJPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IDNKHAOLAID FNMMKOFALAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HANNOJDGJGF FCIHEMLNOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform OJIIPOMCHKP;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int EPEILPKKIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1CE5830", Offset = "0x1CE4630", VA = "0x181CE5830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh NONKFBPOIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh EBAFEICDCCF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6D4470", Offset = "0x6D3270", VA = "0x1806D4470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GNCEKKFIJNF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9A78B0", Offset = "0x9A66B0", VA = "0x1809A78B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9A7C30", Offset = "0x9A6A30", VA = "0x1809A7C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte BPEFFIKIFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9098E0", Offset = "0x9086E0", VA = "0x1809098E0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAC5CD0", Offset = "0xAC4AD0", VA = "0x180AC5CD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int KMLCCMNFHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD330C0", Offset = "0xD31EC0", VA = "0x180D330C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x165B660", Offset = "0x165A460", VA = "0x18165B660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HJLCBCAPDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD537E0", Offset = "0xD525E0", VA = "0x180D537E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xC899E0", Offset = "0xC887E0", VA = "0x180C899E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NDMMNDNEIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1CE55C0", Offset = "0x1CE43C0", VA = "0x181CE55C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5870", Offset = "0x1CE4670", VA = "0x181CE5870")]
		public void NKEELCPKLDG(MHLJBECPMPN EFELDHJGAJI, out int LOLHCFJHLFN, out int MHEHNGBIOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5680", Offset = "0x1CE4480", VA = "0x181CE5680")]
		public void KDJPMBCHDIP(MHLJBECPMPN EFELDHJGAJI, FFPHKBAPEFF LCAIFILALOH, int BMJIKBCENDE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1CE4F80", Offset = "0x1CE3D80", VA = "0x181CE4F80")]
		public void BFKAFGJADND(NativeList<FIDFOPFECGN> OHLEFKFFBLH, Transform FPIDEAGFKEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE55E0", Offset = "0x1CE43E0", VA = "0x181CE55E0")]
		public void FLFODKMMOLL(Mesh KMIFLOHLDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5320", Offset = "0x1CE4120", VA = "0x181CE5320")]
		public void DIJHAMBMLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1CE53C0", Offset = "0x1CE41C0", VA = "0x181CE53C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5AA0", Offset = "0x1CE48A0", VA = "0x181CE5AA0")]
		public BBBAAHDLCAK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds EIJJIFHMJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<BBBAAHDLCAK> HEDCIJKGMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public PJKLMDENKON BMEKMDBECNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer AFAIENJNNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int JOHPNLHAIBP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh CDCLNBIOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BE0", Offset = "0x6CF9E0", VA = "0x1806D0BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GGKPJJHOJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98D710", Offset = "0x98C510", VA = "0x18098D710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98D4F0", Offset = "0x98C2F0", VA = "0x18098D4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NCLDHHHKCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5D10", Offset = "0x1CE4B10", VA = "0x181CE5D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5B80", Offset = "0x1CE4980", VA = "0x181CE5B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5CE0", Offset = "0x1CE4AE0", VA = "0x181CE5CE0")]
	public int JDJOLNBJKEB(int CHLBOKEAMHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5D60", Offset = "0x1CE4B60", VA = "0x181CE5D60")]
	public void OCOGBEBHFPF(EMJGOJPKCEB PBIMLAFPAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6530", Offset = "0x1CE5330", VA = "0x181CE6530")]
	public void PGBLEBIEAGE(Transform FPIDEAGFKEM, bool JAMHCIHKIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5F20", Offset = "0x1CE4D20", VA = "0x181CE5F20")]
	public bool OGFNEMOIGGO(bool PGPEFEJFLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1CE60E0", Offset = "0x1CE4EE0", VA = "0x181CE60E0")]
	public void OHLKELOGCHL(Transform OJIIPOMCHKP, bool JAMHCIHKIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6D00", Offset = "0x1CE5B00", VA = "0x181CE6D00")]
	public bool PPEAGPDBOCM(MPDNMBEGDAL BFKBHAILEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6FB0", Offset = "0x1CE5DB0", VA = "0x181CE6FB0")]
	public BDDPNCJFJNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EECILACPJOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<BDDPNCJFJNP.BBBAAHDLCAK> OPLOFEGGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private CABHBDACEFD PCAPMOFAHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<BDDPNCJFJNP.BBBAAHDLCAK> NBLPDKCAMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NEGKODGHACE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1CECFA0", Offset = "0x1CEBDA0", VA = "0x181CECFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1CED100", Offset = "0x1CEBF00", VA = "0x181CED100")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1CED010", Offset = "0x1CEBE10", VA = "0x181CED010")]
	public void EKGLGHAFJEH(BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA, Transform OJIIPOMCHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1CED5A0", Offset = "0x1CEC3A0", VA = "0x181CED5A0")]
	public void PPEAGPDBOCM(BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1CED410", Offset = "0x1CEC210", VA = "0x181CED410")]
	private BDDPNCJFJNP.BBBAAHDLCAK LCDHJNAIKDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1CECEA0", Offset = "0x1CEBCA0", VA = "0x181CECEA0")]
	private bool COEKNOPKMLO(BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1CED540", Offset = "0x1CEC340", VA = "0x181CED540")]
	private void MKPCKCIJCFA(BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1CED0D0", Offset = "0x1CEBED0", VA = "0x181CED0D0")]
	public bool HGDPOEBHOLO(BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1CED180", Offset = "0x1CEBF80", VA = "0x181CED180")]
	public bool KMEGEMCDFBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1CECF40", Offset = "0x1CEBD40", VA = "0x181CECF40")]
	private BDDPNCJFJNP.BBBAAHDLCAK DMBDNGNEBMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1CED790", Offset = "0x1CEC590", VA = "0x181CED790")]
	public EECILACPJOA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LLKMDCEAMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int HGLMANAEGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int JKOLIKNDOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float BCFGOBPJFOM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<BDDPNCJFJNP> HDBCDJODAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4580", Offset = "0x1CF3380", VA = "0x181CF4580")]
	public LLKMDCEAMNB(int HGLMANAEGCI, int JKOLIKNDOAO, float AJBEENLMEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4220", Offset = "0x1CF3020", VA = "0x181CF4220")]
	public void PPPADGKFOPF(PDLGAAAIDDD FLHNGKKCIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4180", Offset = "0x1CF2F80", VA = "0x181CF4180")]
	private int MFGIBHLDDID(EMJGOJPKCEB EGEEDBJEODH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4340", Offset = "0x1CF3140", VA = "0x181CF4340")]
	private void PPPADGKFOPF(EMJGOJPKCEB EGEEDBJEODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3F70", Offset = "0x1CF2D70", VA = "0x181CF3F70")]
	private void IHKANJJADBA(EMJGOJPKCEB EGEEDBJEODH, BDDPNCJFJNP AKPGODMJKDE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, AFFACHHGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EAOKENDECGJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC10", Offset = "0x8EEA10", VA = "0x1808EFC10")]
			[DebuggerHidden]
			public EAOKENDECGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1CECCB0", Offset = "0x1CEBAB0", VA = "0x181CECCB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1CECE60", Offset = "0x1CEBC60", VA = "0x181CECE60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1CECDC0", Offset = "0x1CEBBC0", VA = "0x181CECDC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1CECDC0", Offset = "0x1CEBBC0", VA = "0x181CECDC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int NCLDHHHKCPA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1CECB50", Offset = "0x1CEB950", VA = "0x181CECB50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<JAGLBOEJJFD> CPAJIGCFJDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1CECB30", Offset = "0x1CEB930", VA = "0x181CECB30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> HEDCIJKGMKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BDDPNCJFJNP CDCLNBIOOFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GJNEDEOMLHJ MKEJCBKFHPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CE0", Offset = "0x6C4AE0", VA = "0x1806C5CE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(GJNEDEOMLHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6DBF60", Offset = "0x6DAD60", VA = "0x1806DBF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AHFKIPGDIHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1CECB40", Offset = "0x1CEB940", VA = "0x181CECB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB710", Offset = "0x1CEA510", VA = "0x181CEB710")]
		public static ClusterMeshRenderer Create(BDDPNCJFJNP KMIFLOHLDEH, ClusterMeshRenderer FADOHPMJJOL, MeshFilter KKOCBHPLPBM, IBPFMLOPCID OJIIPOMCHKP, GJNEDEOMLHJ AHKNLNAGBKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB8B0", Offset = "0x1CEA6B0", VA = "0x181CEB8B0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC070", Offset = "0x1CEAE70", VA = "0x181CEC070", Slot = "10")]
		public bool TryRemoveClusterLODComponent(MPDNMBEGDAL BFKBHAILEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBE60", Offset = "0x1CEAC60", VA = "0x181CEBE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBB00", Offset = "0x1CEA900", VA = "0x181CEBB00")]
		public void Init(BDDPNCJFJNP KMIFLOHLDEH, MeshFilter KKOCBHPLPBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB910", Offset = "0x1CEA710", VA = "0x181CEB910")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC1A0", Offset = "0x1CEAFA0", VA = "0x181CEC1A0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 HDBKKDGKJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC3B0", Offset = "0x1CEB1B0", VA = "0x181CEC3B0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBA90", Offset = "0x1CEA890", VA = "0x181CEBA90")]
		[IteratorStateMachine(typeof(EAOKENDECGJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBEE0", Offset = "0x1CEACE0", VA = "0x181CEBEE0")]
		public void SetupTagAndLayer(string ANJMFOLHICF, int AHKNLNAGBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBEC0", Offset = "0x1CEACC0", VA = "0x181CEBEC0")]
		public bool Remove(MPDNMBEGDAL BFKBHAILEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MFEACPOLBKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int APDODGCFMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int NHDKCAPAOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int MHEHNGBIOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LOLHCFJHLFN;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4630", Offset = "0x1CF3430", VA = "0x181CF4630")]
	public MFEACPOLBKG(int NHDKCAPAOGD, int MHEHNGBIOAK, int APDODGCFMJL, int LOLHCFJHLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PJKLMDENKON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> JMECHPNJPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> MOKFBAMKEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> BCPNDHEOJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<MFEACPOLBKG> BBOKJAJJLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> MMNADJKCKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> AJAFNIELPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> PGFKJDMDGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle HPPHIENCKNF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HDPFLLBOJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x88B050", Offset = "0x889E50", VA = "0x18088B050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x88B040", Offset = "0x889E40", VA = "0x18088B040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5580", Offset = "0x1CF4380", VA = "0x181CF5580")]
	public void NEOFEBEOAIM(IDNKHAOLAID DPLJHIPBOJA, NativeList<MFEACPOLBKG> BBOKJAJJLIM, float FMNLLENGGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5150", Offset = "0x1CF3F50", VA = "0x181CF5150")]
	public void CDNBHDBIKAN(Transform OJIIPOMCHKP, bool JAMHCIHKIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF64A0", Offset = "0x1CF52A0", VA = "0x181CF64A0")]
	public void OGFNEMOIGGO(BDDPNCJFJNP AFAIENJNNPO, bool PGPEFEJFLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5440", Offset = "0x1CF4240", VA = "0x181CF5440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5550", Offset = "0x1CF4350", VA = "0x181CF5550")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public PJKLMDENKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct AKJPFDOHPJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> JMECHPNJPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> MOKFBAMKEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<MFEACPOLBKG> KGKOPHCNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> MMNADJKCKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 PGFPOLGNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> AJAFNIELPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> PGFKJDMDGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool JAMHCIHKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float JEENJEMKKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float PNFCKKHOEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float KPMHIFONMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> BCPNDHEOJLP;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4EB0", Offset = "0x1CE3CB0", VA = "0x181CE4EB0")]
	public AKJPFDOHPJC(PJKLMDENKON HJGAGHPDBHB, Vector3 PGFPOLGNKAI, bool JAMHCIHKIEO, float JEENJEMKKII, float PNFCKKHOEEC, float KPMHIFONMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4A20", Offset = "0x1CE3820", VA = "0x181CE4A20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MPDNMBEGDAL : IDDBHMGDLJB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds DJBIMNIELFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FIDFOPFECGN OKGOANNPGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EMJGOJPKCEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<MPDNMBEGDAL> IJKOIMBOKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public EMJGOJPKCEB KICGHGEEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public EMJGOJPKCEB CJDBHKNDAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public EMJGOJPKCEB HOJONGKGLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int LOLHCFJHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds EIJJIFHMJFI;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1CED910", Offset = "0x1CEC710", VA = "0x181CED910")]
	public EMJGOJPKCEB(List<MPDNMBEGDAL> IJKOIMBOKCL, [Optional] EMJGOJPKCEB KICGHGEEADG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PDLGAAAIDDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<EMJGOJPKCEB> KJHBLGCLKDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EMJGOJPKCEB FPNNOFOGMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5080", Offset = "0x1CF3E80", VA = "0x181CF5080")]
	public PDLGAAAIDDD(EMJGOJPKCEB OJIIPOMCHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KBLHGFALECO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct CINFJEOEENM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int AIIGHOIDDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EMIDMFMEFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int DJKKEKLNGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int KNBALLIHIEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AOBOAAMDEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int OLJAMCKOKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float DCEMHJDCMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<MPDNMBEGDAL> IJKOIMBOKCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum FGDHJJBHDDE
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
	private CINFJEOEENM DOHDMDIHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CKLHNAFNJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int HGLMANAEGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int JKOLIKNDOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float AJBEENLMEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float CDFPGHCHOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<EMJGOJPKCEB> KIGDOKLNPIK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PDLGAAAIDDD PAANONNODNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2240", Offset = "0x1CF1040", VA = "0x181CF2240")]
	public KBLHGFALECO(int HGLMANAEGCI, int JKOLIKNDOAO, float AJBEENLMEMP, int CKLHNAFNJNF, float CDFPGHCHOKG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1210", Offset = "0x1CF0010", VA = "0x181CF1210")]
	public void FNAAPMFLNDJ(List<MPDNMBEGDAL> IJKOIMBOKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2100", Offset = "0x1CF0F00", VA = "0x181CF2100")]
	public bool ILEOHMGAKAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF21C0", Offset = "0x1CF0FC0", VA = "0x181CF21C0")]
	private float JEFALIHPOCI(Vector3 CDJGLGILJHJ, Vector3 KIDJEKPKJJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2170", Offset = "0x1CF0F70", VA = "0x181CF2170")]
	private float JEFALIHPOCI(Vector3 LCJMNMLOPCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1410", Offset = "0x1CF0210", VA = "0x181CF1410")]
	private bool FPLGIMLCGLA(EMJGOJPKCEB CKEBNEHKNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF05E0", Offset = "0x1CEF3E0", VA = "0x181CF05E0")]
	private AOBOAAMDEAF FMKEMGLDHCA(List<MPDNMBEGDAL> FKPOAJGBNOG, FGDHJJBHDDE LMGGADHANGF)
	{
		return default(AOBOAAMDEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1CA0", Offset = "0x1CF0AA0", VA = "0x181CF1CA0")]
	private void ILDLEPMBGAE(List<MPDNMBEGDAL> IJKOIMBOKCL, Vector3[] DILJBOJLDFJ, Vector3[] NLNJFJCLBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class GCKNJFDMLCF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE2C0", Offset = "0x1CED0C0", VA = "0x181CEE2C0")]
	public static Bounds OHDAIDIHGLP(List<MPDNMBEGDAL> IJKOIMBOKCL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1CEE110", Offset = "0x1CECF10", VA = "0x181CEE110")]
	public static int AGMFOKIDCFO(List<MPDNMBEGDAL> IJKOIMBOKCL, MHLJBECPMPN EFELDHJGAJI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CABHBDACEFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private IDNKHAOLAID PGPLHBNINHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private IDNKHAOLAID MANIJOPHJPB;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static IDNKHAOLAID DFGLGHNOEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private JHMPBPJBJLL JHBFJAFBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private FFPHKBAPEFF LCAIFILALOH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle HPPHIENCKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x909CA0", Offset = "0x908AA0", VA = "0x180909CA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F4980", Offset = "0x9F3780", VA = "0x1809F4980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BDDPNCJFJNP.BBBAAHDLCAK CKEBNEHKNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MOFMEGDKKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85D4A0", Offset = "0x85C2A0", VA = "0x18085D4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA240", Offset = "0x1CE9040", VA = "0x181CEA240")]
	[PHHAPANKJKM(AJLNLJAJGIO.ExitingPlayMode, 0)]
	private static void EPEGBKIJMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA9E0", Offset = "0x1CE97E0", VA = "0x181CEA9E0")]
	public void NEOFEBEOAIM(BDDPNCJFJNP.BBBAAHDLCAK KGKOPHCNNKE, Transform PJBKAAGKDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA2B0", Offset = "0x1CE90B0", VA = "0x181CEA2B0")]
	public void FCGEKNNNACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA1D0", Offset = "0x1CE8FD0", VA = "0x181CEA1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA9A0", Offset = "0x1CE97A0", VA = "0x181CEA9A0")]
	public void KJHAHNAAJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB4E0", Offset = "0x1CEA2E0", VA = "0x181CEB4E0")]
	public CABHBDACEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EJAGAAODPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BFIEBAADALM PKOIKOPHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BMHOKKNGNEL
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 JJAGCEDHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EABIDDONALM
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(LDNBHEGFOMH FNKMPAOPGDF, CancellationToken ONKANLKLEAL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NFABICILGEG
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFABICILGEG CKJFBMJMMOC(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFABICILGEG KDKGGALNALF(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NFABICILGEG PGPFKDDJAKK(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFABICILGEG PECDMBBALMA(Action CIAILAMJPDB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class NEPHHFHJNDE : NFABICILGEG
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BFLBCDHOKMG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public NEPHHFHJNDE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public BFLBCDHOKMG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x1CEA0F0", Offset = "0x1CE8EF0", VA = "0x181CEA0F0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x1CEA140", Offset = "0x1CE8F40", VA = "0x181CEA140")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x1CEA190", Offset = "0x1CE8F90", VA = "0x181CEA190")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> LCFHBFEMJFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action OPKCCLIHHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action ACBPGFPHEJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private EJEBIABOAGO NFCFFPGIIFN;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action DFICHOIMLJA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BE0", Offset = "0x6CF9E0", VA = "0x1806D0BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action PABDFILMLPG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA3BAA0", Offset = "0xA3A8A0", VA = "0x180A3BAA0", Slot = "4")]
			public NFABICILGEG CKJFBMJMMOC(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x105D600", Offset = "0x105C400", VA = "0x18105D600", Slot = "5")]
			public NFABICILGEG KDKGGALNALF(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x12C3390", Offset = "0x12C2190", VA = "0x1812C3390", Slot = "6")]
			public NFABICILGEG PGPFKDDJAKK(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x12C33B0", Offset = "0x12C21B0", VA = "0x1812C33B0", Slot = "7")]
			public NFABICILGEG PECDMBBALMA(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
			public NEPHHFHJNDE(Func<JobHandle> NIDGCEMLNKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1CF4C80", Offset = "0x1CF3A80", VA = "0x181CF4C80")]
			public void ADBECLOOPNC(Action JNFMBIMHDMI, Action LDGPDGIBDCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1CF4F10", Offset = "0x1CF3D10", VA = "0x181CF4F10")]
			public void PPEAGPDBOCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class ILODLMAKGMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public NFABICILGEG jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public ILODLMAKGMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE900", Offset = "0x1CED700", VA = "0x181CEE900")]
			internal bool <Remove>b__0(NEPHHFHJNDE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class GDCFPMMCKFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public NEPHHFHJNDE newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public GDCFPMMCKFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE470", Offset = "0x1CED270", VA = "0x181CEE470")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<NEPHHFHJNDE> FGFCKEGJMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<NEPHHFHJNDE> NMOMPMHCKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private HDOELFFLJBF IHOOJOMNEOK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public HLNDFADLIMG IOGAFCKCLED
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1CEF800", Offset = "0x1CEE600", VA = "0x181CEF800")]
		public NFABICILGEG Add(Func<JobHandle> NIDGCEMLNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1CEFB00", Offset = "0x1CEE900", VA = "0x181CEFB00")]
		public void Remove(NFABICILGEG HPPHIENCKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1CEF960", Offset = "0x1CEE760", VA = "0x181CEF960", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1CEFCD0", Offset = "0x1CEEAD0", VA = "0x181CEFCD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1CEFF20", Offset = "0x1CEED20", VA = "0x181CEFF20")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1CEF950", Offset = "0x1CEE750", VA = "0x181CEF950")]
		[CompilerGenerated]
		private void ICJANELEIGN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EJEBIABOAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJEBIABOAGO CKJFBMJMMOC(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJEBIABOAGO IAMMLIKEIMM(Action CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJEBIABOAGO PECDMBBALMA(Action CIAILAMJPDB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class IHDBHFGIGNP : EJEBIABOAGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle GBBKMNLFBAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action OPKCCLIHHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action PFKKENKIGNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action PABDFILMLPG;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool OKLOEDGBEMC
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x1CEE870", Offset = "0x1CED670", VA = "0x181CEE870")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x105D600", Offset = "0x105C400", VA = "0x18105D600", Slot = "4")]
			public EJEBIABOAGO CKJFBMJMMOC(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x12C3390", Offset = "0x12C2190", VA = "0x1812C3390", Slot = "5")]
			public EJEBIABOAGO IAMMLIKEIMM(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x12C33B0", Offset = "0x12C21B0", VA = "0x1812C33B0", Slot = "6")]
			public EJEBIABOAGO PECDMBBALMA(Action CIAILAMJPDB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8A97D0", Offset = "0x8A85D0", VA = "0x1808A97D0")]
			public IHDBHFGIGNP(JobHandle NCBAJHJOHAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE880", Offset = "0x1CED680", VA = "0x181CEE880")]
			public void LAJHMBEEEDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE8C0", Offset = "0x1CED6C0", VA = "0x181CEE8C0")]
			public void PPEAGPDBOCM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<IHDBHFGIGNP> IPGJEEJHPNL;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0400", Offset = "0x1CEF200", VA = "0x181CF0400")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0020", Offset = "0x1CEEE20", VA = "0x181CF0020")]
		public EJEBIABOAGO Add(JobHandle NCBAJHJOHAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0310", Offset = "0x1CEF110", VA = "0x181CF0310")]
		public void Remove(EJEBIABOAGO HPPHIENCKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF01A0", Offset = "0x1CEEFA0", VA = "0x181CF01A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF00B0", Offset = "0x1CEEEB0", VA = "0x181CF00B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0520", Offset = "0x1CEF320", VA = "0x181CF0520")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF49A0", Offset = "0x1CF37A0", VA = "0x181CF49A0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4650", Offset = "0x1CF3450", VA = "0x181CF4650")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
