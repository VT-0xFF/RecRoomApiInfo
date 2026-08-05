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
				[Cpp2IlInjected.Address(RVA = "0x31E9790", Offset = "0x31E7F90", VA = "0x1831E9790")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1DE4070", Offset = "0x1DE2870", VA = "0x181DE4070")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x31E9750", Offset = "0x31E7F50", VA = "0x1831E9750")]
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
		[Cpp2IlInjected.Address(RVA = "0x31E16A0", Offset = "0x31DFEA0", VA = "0x1831E16A0")]
		public LODSettings PJHANJCDOMB(HNKOBDJPCKI NELKFHKGKDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x31E1680", Offset = "0x31DFE80", VA = "0x1831E1680")]
		public int PCKGCGCEJNK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x31E1580", Offset = "0x31DFD80", VA = "0x1831E1580")]
		public int IAFPHEKLBCA(bool JDPJDFOLGII, Vector3 BGKCNDEOEOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x31E16B0", Offset = "0x31DFEB0", VA = "0x1831E16B0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BFFNGMENACL
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
public interface DFPCHAAPCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILLEJEMGBKM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CDCIJCKMOOF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JCGBCFIFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<OADNLLMNKKA> MDMJBOHBHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BFFNGMENACL IKGNKHMPPGL
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
	void UpdateClusterDistances(Vector3 INKEIBHHMOK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(BKMLOGCMLGK CFCFGDKOLFC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OADNLLMNKKA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NIJEEBNCCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int NLCLFHGBEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BLKIOFMDDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DAODOECDLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte MKFIDJMKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BOLFKNOIBPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CEOCFEGGDDP
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
	private struct NDAAOIHKLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BOLFKNOIBPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GBCJCBAKIDH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GBCJCBAKIDH <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x31EAF90", Offset = "0x31E9790", VA = "0x1831EAF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AMBBOLEMFCG : IEnumerator<AADBNPIPHNH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private AADBNPIPHNH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BOLFKNOIBPE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private AADBNPIPHNH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
		[DebuggerHidden]
		public AMBBOLEMFCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x31DE300", Offset = "0x31DCB00", VA = "0x1831DE300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x31DE3C0", Offset = "0x31DCBC0", VA = "0x1831DE3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KOHGFBPKLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BOLFKNOIBPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GBCJCBAKIDH worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GBCJCBAKIDH <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x31E6D10", Offset = "0x31E5510", VA = "0x1831E6D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PODKJBBGOAK : IEnumerator<AADBNPIPHNH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private AADBNPIPHNH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BOLFKNOIBPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private AADBNPIPHNH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
		[DebuggerHidden]
		public PODKJBBGOAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x31EE800", Offset = "0x31ED000", VA = "0x1831EE800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x31EF6E0", Offset = "0x31EDEE0", VA = "0x1831EF6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int NOAMAGGAACN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan NDEHOMKGGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NFPHCNEKNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter GAGBELFELMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OLFMPCKCDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject KMOPHINCIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public AHHPICDCCHG JHBOOOBHOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<BKMLOGCMLGK> LOPBFKNMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<BKMLOGCMLGK> PJGEHAHICCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<BKMLOGCMLGK> BAJHJJJFHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int FDMGEJMOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private CEOCFEGGDDP NAAEGNPELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CDCIJCKMOOF>[] FOOPCLHCNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<OADNLLMNKKA>[] OLGHHKFBMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource HDOAOBEGNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NMBNHPDPFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EMIHBMNJEOE NMEBICIMHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EMIHBMNJEOE CBNCFAIHFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int PGDBGJGCCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int JKOCHOGOHAH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static BOLFKNOIBPE MNDJBFKKLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BBCPGEAIDJE IBDANHLOLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LILKAGJNJIG MFEJJHANPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour FDMFMEFGGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material IFKEOBFNPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<DFPCHAAPCIO> OKKBKEIPCFK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig DMDMDFLJFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 KEDPGHJLNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x31DE4A0", Offset = "0x31DCCA0", VA = "0x1831DE4A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x31DF610", Offset = "0x31DDE10", VA = "0x1831DF610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CEOCFEGGDDP LHKGMOGABGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x847080", Offset = "0x845880", VA = "0x180847080")]
		get
		{
			return default(CEOCFEGGDDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x31DE970", Offset = "0x31DD170", VA = "0x1831DE970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BOLFKNOIBPE AAMGPJBHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x31DF3E0", Offset = "0x31DDBE0", VA = "0x1831DF3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool ACLBGJJEEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x31DF180", Offset = "0x31DD980", VA = "0x1831DF180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KJCDMIMFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x31DEDE0", Offset = "0x31DD5E0", VA = "0x1831DEDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> KMHMCPFDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x31DEBD0", Offset = "0x31DD3D0", VA = "0x1831DEBD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x31DFE20", Offset = "0x31DE620", VA = "0x1831DFE20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NHHLKMPKKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x31DF0E0", Offset = "0x31DD8E0", VA = "0x1831DF0E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x31DE500", Offset = "0x31DCD00", VA = "0x1831DE500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x31E0ED0", Offset = "0x31DF6D0", VA = "0x1831E0ED0")]
	public BOLFKNOIBPE(BBCPGEAIDJE IBDANHLOLGP, LILKAGJNJIG MFEJJHANPGL, ClusterLODConfig MADGLJNEBGK, MonoBehaviour FDMFMEFGGAK, Material IFKEOBFNPAE, ClusterMeshRenderer NFPHCNEKNCI, MeshFilter GAGBELFELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x31DECE0", Offset = "0x31DD4E0", VA = "0x1831DECE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x31DE850", Offset = "0x31DD050", VA = "0x1831DE850")]
	public static void CKCFNEEGAJC(Vector3 PPKMGAHHGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31E0BA0", Offset = "0x31DF3A0", VA = "0x1831E0BA0")]
	private void NLJDBDIHBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31DF830", Offset = "0x31DE030", VA = "0x1831DF830")]
	private void KFKEMFFKGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x31DEFA0", Offset = "0x31DD7A0", VA = "0x1831DEFA0")]
	private void GFLBDJNFJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31DF930", Offset = "0x31DE130", VA = "0x1831DF930")]
	public void KLOMIKEDJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31DF2A0", Offset = "0x31DDAA0", VA = "0x1831DF2A0")]
	[AsyncStateMachine(typeof(NDAAOIHKLAO))]
	public Task HLLILLIEJFK(GBCJCBAKIDH LEEHDEOADOO, CancellationToken LAOFPANACHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31DEC70", Offset = "0x31DD470", VA = "0x1831DEC70")]
	[IteratorStateMachine(typeof(AMBBOLEMFCG))]
	private IEnumerator<AADBNPIPHNH> DPCAJNPBELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31DEA90", Offset = "0x31DD290", VA = "0x1831DEA90")]
	[AsyncStateMachine(typeof(KOHGFBPKLBI))]
	private Task CNOHKCBCOAL(GBCJCBAKIDH FJKLBKJEPHC, CancellationToken NFKHAKHIBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x31DF620", Offset = "0x31DDE20", VA = "0x1831DF620")]
	public void KEDPIPKFBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31E0C90", Offset = "0x31DF490", VA = "0x1831E0C90")]
	public void NPDAOEIPCHF(IEnumerable<CDCIJCKMOOF> MKGIHIIBNFL, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x31DE5A0", Offset = "0x31DCDA0", VA = "0x1831DE5A0")]
	public void CGBAIPLHPMG(IEnumerable<CDCIJCKMOOF> MKGIHIIBNFL, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x31DFEC0", Offset = "0x31DE6C0", VA = "0x1831DFEC0")]
	public List<ClusterMeshRenderer> LKAEFJPBHDJ(List<BKMLOGCMLGK> COMKKLEOPMA, KAKBADJGMGN JLGIFIFDIOJ, BFFNGMENACL HNFKGKKHMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31DE4C0", Offset = "0x31DCCC0", VA = "0x1831DE4C0")]
	public BFFNGMENACL BBFICAOCEKP(Vector3 NBDPKOOFBJF)
	{
		return default(BFFNGMENACL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x31E0C30", Offset = "0x31DF430", VA = "0x1831E0C30")]
	public void NNFKFCAHPON(DFPCHAAPCIO BBEMNPEBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31DEF40", Offset = "0x31DD740", VA = "0x1831DEF40")]
	public bool ENPFCFPIHFK(DFPCHAAPCIO BBEMNPEBHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x31E0D10", Offset = "0x31DF510", VA = "0x1831E0D10")]
	public void OEPHKKOIACM(BKMLOGCMLGK FDGFJHNGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31DEEC0", Offset = "0x31DD6C0", VA = "0x1831DEEC0")]
	public void EKIHLGDMMPF(OADNLLMNKKA FPMMADBNIOC, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31E06B0", Offset = "0x31DEEB0", VA = "0x1831E06B0")]
	public void LLLBOAOKLAG(OADNLLMNKKA FPMMADBNIOC, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31E08A0", Offset = "0x31DF0A0", VA = "0x1831E08A0")]
	private void MMDBNBGCDKF(Vector3 INKEIBHHMOK, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31DF4A0", Offset = "0x31DDCA0", VA = "0x1831DF4A0")]
	private void ICPKAFBENLD(Vector3 INKEIBHHMOK, BFFNGMENACL HNFKGKKHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31E0DF0", Offset = "0x31DF5F0", VA = "0x1831E0DF0")]
	[IteratorStateMachine(typeof(PODKJBBGOAK))]
	private IEnumerator<AADBNPIPHNH> PLOKDENBLPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31E0730", Offset = "0x31DEF30", VA = "0x1831E0730")]
	private int LMMHIMOEEKL(int AKLHCIJHJKB, int DNJOLJKKHMJ, List<OADNLLMNKKA> GFFKCNOPFIO, byte NELKFHKGKDN, ref int AKEBEPCIHAG, float GABAJHLENPE = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31E09D0", Offset = "0x31DF1D0", VA = "0x1831E09D0")]
	public void NHIAFFMKOAF(BKMLOGCMLGK CFCFGDKOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x31E0D70", Offset = "0x31DF570", VA = "0x1831E0D70")]
	public bool OOEBBEBEBME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68E530", Offset = "0x68CD30", VA = "0x18068E530")]
	public Material EBNGEGAHMFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x31E0DB0", Offset = "0x31DF5B0", VA = "0x1831E0DB0")]
	public int PCKGCGCEJNK()
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
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct DHFKFLLDLAA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> MAIOKOBKMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> KHNPJKABMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> OIAMLHIOFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> BINAKMAFBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> DKPDPPLOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> DPDGILOHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> AMOGNGLLBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 MGGKOBMOBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float AABDHBBPGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> CDGBKKJCHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> LNILOHMPADJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31E32F0", Offset = "0x31E1AF0", VA = "0x1831E32F0")]
	public DHFKFLLDLAA(DKINPLPBHJG IPHBKPGNMFN, NativeList<float3> AMOGNGLLBDO, NativeMultiHashMap<int, int> CDGBKKJCHAK, NativeArray<int> LNILOHMPADJ, Vector3 MGGKOBMOBBK, float AABDHBBPGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x31E2FF0", Offset = "0x31E17F0", VA = "0x1831E2FF0")]
	private int HLNDJLJOJHJ(float3 INKEIBHHMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x31E3050", Offset = "0x31E1850", VA = "0x1831E3050")]
	private int JCAFNDBFJHE(int GDBELOJNNFN, int BAGMDNPKAJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x31E2C00", Offset = "0x31E1400", VA = "0x1831E2C00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NGMFBBIMLJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> CDGBKKJCHAK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> LNILOHMPADJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int PBJMAOGOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> BFHJILMCLOH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x31EB510", Offset = "0x31E9D10", VA = "0x1831EB510")]
	public void ANHIAECMLOC(int LENNFGJPOJD, Allocator DDJPHGFEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x31EB6B0", Offset = "0x31E9EB0", VA = "0x1831EB6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NGMFBBIMLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KDJNPLLFNHB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> EFJFDHCDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> HPLJJHLLPJG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x31E6CD0", Offset = "0x31E54D0", VA = "0x1831E6CD0")]
	public KDJNPLLFNHB(NGMFBBIMLJD DOCCFCAJMKG, DKINPLPBHJG IPHBKPGNMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31E6C40", Offset = "0x31E5440", VA = "0x1831E6C40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LIOPNBIOBMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> JBIHNBKMCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> IAHILGBNBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> OJPDABMBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> LDHDLLKOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> CCJCBLJCDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> BFHJILMCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> EFJFDHCDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> EOEKIAALPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> CCIOFHBJOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> CGKPPNNGEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> MLKFEMPEFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> BKOHNNIHOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> ILLHFECNJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float LGAPFBOIMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float GHLFLGGDIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 CGKCDCOICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float PANAMNBHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NKPHMJDKPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float OHGAJDFAGIK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x31E9610", Offset = "0x31E7E10", VA = "0x1831E9610")]
	public LIOPNBIOBMC(NGMFBBIMLJD CIDAHPFLHGH, DKINPLPBHJG IPHBKPGNMFN, DKINPLPBHJG NJADPMGJGJL, float NKPHMJDKPHP, float OHGAJDFAGIK, Vector3 CGKCDCOICMK, float PANAMNBHAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31E90B0", Offset = "0x31E78B0", VA = "0x1831E90B0")]
	private float3 HLHJKKDKPJF(int GDBELOJNNFN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31E9150", Offset = "0x31E7950", VA = "0x1831E9150")]
	private void KBBJCLCDMIP(int GDBELOJNNFN, out float3 PGLMNDIIANH, out float3 GANICOJAJLI, out float4 MACLDAGJLEM, out float4 ELCJAJLLLOD, out float2 EDFLGMGOKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31E8030", Offset = "0x31E6830", VA = "0x1831E8030")]
	private int AJGAPDCLHDJ(int DPDHACEJCLC, int CMGKMPALIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x31E93F0", Offset = "0x31E7BF0", VA = "0x1831E93F0")]
	private void NBGGJKPAPMB(int DPDHACEJCLC, int CMGKMPALIBP, int DFLPKJGDMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x31E85C0", Offset = "0x31E6DC0", VA = "0x1831E85C0")]
	private bool BONCHCDGHIL(int DPDHACEJCLC, int CMGKMPALIBP, float HOFOMKONFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x31E9330", Offset = "0x31E7B30", VA = "0x1831E9330")]
	private bool LGBDHGCHEHA(int DPDHACEJCLC, int CMGKMPALIBP, int DFLPKJGDMAF, float HOFOMKONFIN, bool NIONGONALEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31E8360", Offset = "0x31E6B60", VA = "0x1831E8360")]
	private bool BJBMFNOEIEB(int DPDHACEJCLC, int CMGKMPALIBP, int DFLPKJGDMAF, float HOFOMKONFIN, bool NIONGONALEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31E95F0", Offset = "0x31E7DF0", VA = "0x1831E95F0")]
	private void PFMOEDLKKJJ(int DPDHACEJCLC, int CMGKMPALIBP, int DFLPKJGDMAF, out int LFHHLOJLEIB, out int DFFDCFLOLIO, out int CMAGEGKFGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x31E8750", Offset = "0x31E6F50", VA = "0x1831E8750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EAKCJDFKINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OCNOMKNIJCJ : IDisposable, OADNLLMNKKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds ENJDOAHDOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<BKMLOGCMLGK> COMKKLEOPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 POFFLDHAMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 PPANDJEGDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int FLLFGBAAOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DKINPLPBHJG NMIHLJLCGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NGMFBBIMLJD JHDFJEDKCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform JLGIFIFDIOJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int IFAFBGIFJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x31EDA00", Offset = "0x31EC200", VA = "0x1831EDA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh GAAHJHJHIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh OPCGCDECFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float BLKIOFMDDIA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x921A90", Offset = "0x920290", VA = "0x180921A90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A10", Offset = "0xAB1210", VA = "0x180AB2A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte MKFIDJMKDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5F8B20", Offset = "0x5F7320", VA = "0x1805F8B20")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x82F130", Offset = "0x82D930", VA = "0x18082F130", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NIJEEBNCCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x631150", Offset = "0x62F950", VA = "0x180631150", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6F8B80", Offset = "0x6F7380", VA = "0x1806F8B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NLCLFHGBEBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EC0", Offset = "0x6F76C0", VA = "0x1806F8EC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F8B90", Offset = "0x6F7390", VA = "0x1806F8B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DAODOECDLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x31EDA40", Offset = "0x31EC240", VA = "0x1831EDA40", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x31EDA60", Offset = "0x31EC260", VA = "0x1831EDA60")]
		public void NFEKPINIHIB(HNKOBDJPCKI NELKFHKGKDN, out int LJMHIOMPMGE, out int PAPJPAAIOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x31EDC90", Offset = "0x31EC490", VA = "0x1831EDC90")]
		public void OHKHCAHJJLJ(HNKOBDJPCKI NELKFHKGKDN, AEKAKDEBMEA CGHDGNPAENF, int PHBINMHOLHI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x31EDE30", Offset = "0x31EC630", VA = "0x1831EDE30")]
		public void PDJCKGOFDKG(NativeList<BDOFOPAKEHF> KEADONKMGCG, Transform OCMOMFNCOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x31ED960", Offset = "0x31EC160", VA = "0x1831ED960")]
		public void EPHNPCHIPPD(Mesh IPHBKPGNMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x31ED6D0", Offset = "0x31EBED0", VA = "0x1831ED6D0")]
		public void CKNEGENEDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x31ED770", Offset = "0x31EBF70", VA = "0x1831ED770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x31EE150", Offset = "0x31EC950", VA = "0x1831EE150")]
		public OCNOMKNIJCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds ENJDOAHDOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<OCNOMKNIJCJ> NAICGDJGCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NAJONNEKADF CIBJMEHFBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer MHMHPHOEJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int CFOCGHPKHOG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh LCLNLFIBKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CFGFKEMOJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFC0", Offset = "0x6AA7C0", VA = "0x1806ABFC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFB0", Offset = "0x6AA7B0", VA = "0x1806ABFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JCGBCFIFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x31E3FE0", Offset = "0x31E27E0", VA = "0x1831E3FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x31E3CF0", Offset = "0x31E24F0", VA = "0x1831E3CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x31E3B10", Offset = "0x31E2310", VA = "0x1831E3B10")]
	public int BOKJMLGNCMJ(int BHPELLBNANO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x31E3E50", Offset = "0x31E2650", VA = "0x1831E3E50")]
	public void GAGGMOIEIMF(HNOEOOMEKNG DGANLPFOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x31E33B0", Offset = "0x31E1BB0", VA = "0x1831E33B0")]
	public void BKEBAILDMLP(Transform OCMOMFNCOEL, bool IBOPGGPBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x31E3B40", Offset = "0x31E2340", VA = "0x1831E3B40")]
	public bool DKENFEEDCCC(bool BILGAGFFKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x31E4030", Offset = "0x31E2830", VA = "0x1831E4030")]
	public void KKJAHOJCKPP(Transform JLGIFIFDIOJ, bool IBOPGGPBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31E4490", Offset = "0x31E2C90", VA = "0x1831E4490")]
	public bool NHIAFFMKOAF(BKMLOGCMLGK CFCFGDKOLFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x31E4710", Offset = "0x31E2F10", VA = "0x1831E4710")]
	public EAKCJDFKINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AHHPICDCCHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<EAKCJDFKINJ.OCNOMKNIJCJ> IAADBBEDMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private HDKCDOLFPJN JJBAMJABPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<EAKCJDFKINJ.OCNOMKNIJCJ> ACEJGMOFBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int ILJHOPLPIGN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x31DDBB0", Offset = "0x31DC3B0", VA = "0x1831DDBB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x31DDDF0", Offset = "0x31DC5F0", VA = "0x1831DDDF0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x31DE110", Offset = "0x31DC910", VA = "0x1831DE110")]
	public void NLKJJINIDJF(EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN, Transform JLGIFIFDIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x31DDF60", Offset = "0x31DC760", VA = "0x1831DDF60")]
	public void NHIAFFMKOAF(EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x31DDC20", Offset = "0x31DC420", VA = "0x1831DDC20")]
	private EAKCJDFKINJ.OCNOMKNIJCJ EIHAGKCDDBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x31DDED0", Offset = "0x31DC6D0", VA = "0x1831DDED0")]
	private bool NACMHILLOGJ(EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x31DDE70", Offset = "0x31DC670", VA = "0x1831DDE70")]
	private void KECIJFPKKCD(EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x31DDD50", Offset = "0x31DC550", VA = "0x1831DDD50")]
	public bool GHEFLPFMKEG(EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x31DD920", Offset = "0x31DC120", VA = "0x1831DD920")]
	public bool APPMGKEFBBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x31DDD90", Offset = "0x31DC590", VA = "0x1831DDD90")]
	private EAKCJDFKINJ.OCNOMKNIJCJ GOJHFOOLGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x31DE1C0", Offset = "0x31DC9C0", VA = "0x1831DE1C0")]
	public AHHPICDCCHG()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MBIIIAPOMMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int NAINFBIOACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int OKJEAMIAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float KJNJBOJKJND;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<EAKCJDFKINJ> LAJIOJEPEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31E9D00", Offset = "0x31E8500", VA = "0x1831E9D00")]
	public MBIIIAPOMMN(int NAINFBIOACP, int OKJEAMIAMDK, float BEEPIPHJIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31E9A30", Offset = "0x31E8230", VA = "0x1831E9A30")]
	public void OPMNGPKAFGA(IEJNAKKLCFL MHPBGABPAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31E97B0", Offset = "0x31E7FB0", VA = "0x1831E97B0")]
	private int LACGIJDCDMN(HNOEOOMEKNG MHNJKLLCLHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31E9AD0", Offset = "0x31E82D0", VA = "0x1831E9AD0")]
	private void OPMNGPKAFGA(HNOEOOMEKNG MHNJKLLCLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31E9850", Offset = "0x31E8050", VA = "0x1831E9850")]
	private void MLKILPPBEJL(HNOEOOMEKNG MHNJKLLCLHP, EAKCJDFKINJ PHNMOFHACIP)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CDCIJCKMOOF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FDANMNJANCC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
			[DebuggerHidden]
			public FDANMNJANCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x31E47B0", Offset = "0x31E2FB0", VA = "0x1831E47B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x31E4940", Offset = "0x31E3140", VA = "0x1831E4940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x31E48A0", Offset = "0x31E30A0", VA = "0x1831E48A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x31E48A0", Offset = "0x31E30A0", VA = "0x1831E48A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JCGBCFIFPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x31E2AC0", Offset = "0x31E12C0", VA = "0x1831E2AC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<OADNLLMNKKA> MDMJBOHBHJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x31E2AA0", Offset = "0x31E12A0", VA = "0x1831E2AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> NAICGDJGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EAKCJDFKINJ LCLNLFIBKOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BFFNGMENACL IKGNKHMPPGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x630C00", Offset = "0x62F400", VA = "0x180630C00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(BFFNGMENACL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6F6220", Offset = "0x6F4A20", VA = "0x1806F6220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HOAJMFDEMBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x31E2AB0", Offset = "0x31E12B0", VA = "0x1831E2AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x31E1710", Offset = "0x31DFF10", VA = "0x1831E1710")]
		public static ClusterMeshRenderer Create(EAKCJDFKINJ IPHBKPGNMFN, ClusterMeshRenderer NFPHCNEKNCI, MeshFilter GAGBELFELMN, KAKBADJGMGN JLGIFIFDIOJ, BFFNGMENACL HNFKGKKHMIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x31E1890", Offset = "0x31E0090", VA = "0x1831E1890", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x31E2010", Offset = "0x31E0810", VA = "0x1831E2010", Slot = "10")]
		public bool TryRemoveClusterLODComponent(BKMLOGCMLGK CFCFGDKOLFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x31E1DE0", Offset = "0x31E05E0", VA = "0x1831E1DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x31E1AF0", Offset = "0x31E02F0", VA = "0x1831E1AF0")]
		public void Init(EAKCJDFKINJ IPHBKPGNMFN, MeshFilter GAGBELFELMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x31E18F0", Offset = "0x31E00F0", VA = "0x1831E18F0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x31E2140", Offset = "0x31E0940", VA = "0x1831E2140", Slot = "8")]
		public void UpdateClusterDistances(Vector3 INKEIBHHMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x31E2380", Offset = "0x31E0B80", VA = "0x1831E2380", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x31E1A80", Offset = "0x31E0280", VA = "0x1831E1A80")]
		[IteratorStateMachine(typeof(FDANMNJANCC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x31E1E60", Offset = "0x31E0660", VA = "0x1831E1E60")]
		public void SetupTagAndLayer(string ANBEHLDDGLC, int HNFKGKKHMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x31E1E40", Offset = "0x31E0640", VA = "0x1831E1E40")]
		public bool Remove(BKMLOGCMLGK CFCFGDKOLFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ILEDCBDGALB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int MDPAIBFKCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int DABGAKHOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int PAPJPAAIOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LJMHIOMPMGE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x31E6010", Offset = "0x31E4810", VA = "0x1831E6010")]
	public ILEDCBDGALB(int DABGAKHOBBF, int PAPJPAAIOCC, int MDPAIBFKCDD, int LJMHIOMPMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NAJONNEKADF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> MAIOKOBKMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> BFHJILMCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> DPDGILOHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<ILEDCBDGALB> BDLMKGGHAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> FNFGLLMKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> FEMFNEICFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> LAPMBAMNPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle LHICIKNDDJI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OMLOBFJEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x785770", Offset = "0x783F70", VA = "0x180785770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x783F70", Offset = "0x782770", VA = "0x180783F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x31EA2A0", Offset = "0x31E8AA0", VA = "0x1831EA2A0")]
	public void NNHCHCFNJFN(DKINPLPBHJG PLGEMIPIAKF, NativeList<ILEDCBDGALB> BDLMKGGHAEG, float MJDIJCCGCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31E9FB0", Offset = "0x31E87B0", VA = "0x1831E9FB0")]
	public void HFCCGNAIENF(Transform JLGIFIFDIOJ, bool IBOPGGPBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x31E9D50", Offset = "0x31E8550", VA = "0x1831E9D50")]
	public void DKENFEEDCCC(EAKCJDFKINJ MHMHPHOEJMA, bool BILGAGFFKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x31E9EE0", Offset = "0x31E86E0", VA = "0x1831E9EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x31EA270", Offset = "0x31E8A70", VA = "0x1831EA270")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NAJONNEKADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct PPCAINCFBKA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> MAIOKOBKMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> BFHJILMCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<ILEDCBDGALB> AAHKOMGAHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> FNFGLLMKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 CGKCDCOICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> FEMFNEICFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> LAPMBAMNPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool IBOPGGPBKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float AHOHILCGHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float DGPLLFOHDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float DFMBLGADNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> DPDGILOHPLD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31EFBD0", Offset = "0x31EE3D0", VA = "0x1831EFBD0")]
	public PPCAINCFBKA(NAJONNEKADF OFPFIAGIKFE, Vector3 CGKCDCOICMK, bool IBOPGGPBKDH, float AHOHILCGHCM, float DGPLLFOHDNA, float DFMBLGADNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x31EF730", Offset = "0x31EDF30", VA = "0x1831EF730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BKMLOGCMLGK : ECCCEBCEPGB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds KIDOCIHJLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BDOFOPAKEHF ONBFABJMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HNOEOOMEKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<BKMLOGCMLGK> COMKKLEOPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public HNOEOOMEKNG CELKNCFBAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public HNOEOOMEKNG LADFDEJFFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public HNOEOOMEKNG BHPPHENENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int LJMHIOMPMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds ENJDOAHDOJE;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31E5EE0", Offset = "0x31E46E0", VA = "0x1831E5EE0")]
	public HNOEOOMEKNG(List<BKMLOGCMLGK> COMKKLEOPMA, [Optional] HNOEOOMEKNG CELKNCFBAOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IEJNAKKLCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<HNOEOOMEKNG> HANHMGPNJMB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HNOEOOMEKNG FMFDBHIKOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31E5F60", Offset = "0x31E4760", VA = "0x1831E5F60")]
	public IEJNAKKLCFL(HNOEOOMEKNG JLGIFIFDIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NIHDOEFCMPL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GEEEBLLKNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int CMACBBGMPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EDHEGFKKGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int DNMPNEFIGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int DBMJOKHDIBA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct MBKMBANHDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int AGHDHCHDCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float OAHDNPNFLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<BKMLOGCMLGK> COMKKLEOPMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum DFMNDKIKNMN
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
	private GEEEBLLKNLK GBECIAMJFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int GKGDFAHDHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int NAINFBIOACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int OKJEAMIAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float BEEPIPHJIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float OCADKCHLACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<HNOEOOMEKNG> INLGIHHLHND;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IEJNAKKLCFL GANGHFNAPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31ED330", Offset = "0x31EBB30", VA = "0x1831ED330")]
	public NIHDOEFCMPL(int NAINFBIOACP, int OKJEAMIAMDK, float BEEPIPHJIHL, int GKGDFAHDHCE, float OCADKCHLACI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31ED170", Offset = "0x31EB970", VA = "0x1831ED170")]
	public void PEJIAJBHGAK(List<BKMLOGCMLGK> COMKKLEOPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31ED100", Offset = "0x31EB900", VA = "0x1831ED100")]
	public bool NJGAACNGIJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31EB760", Offset = "0x31E9F60", VA = "0x1831EB760")]
	private float IFFCMIFPHNK(Vector3 NFMJKCMCOPK, Vector3 AHIONLKAMCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31EB870", Offset = "0x31EA070", VA = "0x1831EB870")]
	private float IFFCMIFPHNK(Vector3 OCAKIKBDFGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x31EC7F0", Offset = "0x31EAFF0", VA = "0x1831EC7F0")]
	private bool JOLIJLIBIGP(HNOEOOMEKNG HHPNIHJLAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31EB910", Offset = "0x31EA110", VA = "0x1831EB910")]
	private MBKMBANHDGH IMBBKDFGEGG(List<BKMLOGCMLGK> NPKDOIFKAPB, DFMNDKIKNMN JHLBNLMIDJM)
	{
		return default(MBKMBANHDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31EC460", Offset = "0x31EAC60", VA = "0x1831EC460")]
	private void JMFFIEHHKGM(List<BKMLOGCMLGK> COMKKLEOPMA, Vector3[] AKCECBKCHHI, Vector3[] MOMDJBDMEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class NLNIJLLGOCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x31ED390", Offset = "0x31EBB90", VA = "0x1831ED390")]
	public static Bounds DPJHKDMIJJD(List<BKMLOGCMLGK> COMKKLEOPMA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x31ED540", Offset = "0x31EBD40", VA = "0x1831ED540")]
	public static int JMDEOFIIOAJ(List<BKMLOGCMLGK> COMKKLEOPMA, HNKOBDJPCKI NELKFHKGKDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HDKCDOLFPJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DKINPLPBHJG FMENHDFABLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DKINPLPBHJG HOLKGLPNFGK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static DKINPLPBHJG LPNCONGHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FHMEHADHBOE KBFMEHFCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private AEKAKDEBMEA CGHDGNPAENF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle LHICIKNDDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x122D8E0", Offset = "0x122C0E0", VA = "0x18122D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EAKCJDFKINJ.OCNOMKNIJCJ HHPNIHJLAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MNLJFDIGNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2D0", Offset = "0x7DCAD0", VA = "0x1807DE2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x31E4DD0", Offset = "0x31E35D0", VA = "0x1831E4DD0")]
	[ENAJMPNKNEO(BGCJOGMHLOH.ExitingPlayMode, 0)]
	private void NGLFGAPDLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x31E4E40", Offset = "0x31E3640", VA = "0x1831E4E40")]
	public void NNHCHCFNJFN(EAKCJDFKINJ.OCNOMKNIJCJ AAHKOMGAHGE, Transform CELEFPDHPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x31E5860", Offset = "0x31E4060", VA = "0x1831E5860")]
	public void PJIMAHGFMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x31E4D20", Offset = "0x31E3520", VA = "0x1831E4D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x31E4D90", Offset = "0x31E3590", VA = "0x1831E4D90")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x31E5E50", Offset = "0x31E4650", VA = "0x1831E5E50")]
	public HDKCDOLFPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface IOEJONDEGEI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BOLFKNOIBPE OFPFIAHOEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LILKAGJNJIG
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 JBAFMJIOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BBCPGEAIDJE
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(GBCJCBAKIDH FJKLBKJEPHC, CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CCDBKJCBFMN
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCDBKJCBFMN MFHJEOHMMHA(Action MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCDBKJCBFMN HFCAJOGCNKM(Action MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCDBKJCBFMN FGJJMDIJEMG(Action MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCDBKJCBFMN GGFIPACNPEG(Action MJHIGMCCOPA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class GGMJFBDKGKJ : CCDBKJCBFMN
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class DCFANEPHAJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public GGMJFBDKGKJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
				public DCFANEPHAJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x31E2B20", Offset = "0x31E1320", VA = "0x1831E2B20")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x31E2B70", Offset = "0x31E1370", VA = "0x1831E2B70")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x31E2BC0", Offset = "0x31E13C0", VA = "0x1831E2BC0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> HEHCNNCEECB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action FLFAMANBCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action EHIJHJFFPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private GMJCAPMHOCH CIMBMPHEIGG;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action MKKMPFLDOPG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action GHDFNONILKD
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1139490", Offset = "0x1137C90", VA = "0x181139490", Slot = "4")]
			public CCDBKJCBFMN MFHJEOHMMHA(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD1CF50", Offset = "0xD1B750", VA = "0x180D1CF50", Slot = "5")]
			public CCDBKJCBFMN HFCAJOGCNKM(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xD1BEC0", Offset = "0xD1A6C0", VA = "0x180D1BEC0", Slot = "6")]
			public CCDBKJCBFMN FGJJMDIJEMG(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xFF9440", Offset = "0xFF7C40", VA = "0x180FF9440", Slot = "7")]
			public CCDBKJCBFMN GGFIPACNPEG(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
			public GGMJFBDKGKJ(Func<JobHandle> NJGFDDBFEMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x31E4990", Offset = "0x31E3190", VA = "0x1831E4990")]
			public void EOHNKNEAELI(Action DEAHCHHLNKE, Action ELEFBEAMIKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x31E4BC0", Offset = "0x31E33C0", VA = "0x1831E4BC0")]
			public void NHIAFFMKOAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class KLCMCCHMCOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public CCDBKJCBFMN jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public KLCMCCHMCOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x31E6D00", Offset = "0x31E5500", VA = "0x1831E6D00")]
			internal bool <Remove>b__0(GGMJFBDKGKJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CNMAFHMKDHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public GGMJFBDKGKJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public CNMAFHMKDHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x31E1520", Offset = "0x31DFD20", VA = "0x1831E1520")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<GGMJFBDKGKJ> CIDNKGBBOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<GGMJFBDKGKJ> LDDEGMEENOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private EMIHBMNJEOE HJJDMLJBFGO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public GJCEMNMONMK EODDADKMGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x31E6030", Offset = "0x31E4830", VA = "0x1831E6030")]
		public CCDBKJCBFMN Add(Func<JobHandle> NJGFDDBFEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x31E62D0", Offset = "0x31E4AD0", VA = "0x1831E62D0")]
		public void Remove(CCDBKJCBFMN LHICIKNDDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x31E6150", Offset = "0x31E4950", VA = "0x1831E6150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x31E6450", Offset = "0x31E4C50", VA = "0x1831E6450")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x31E6620", Offset = "0x31E4E20", VA = "0x1831E6620")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x31E6140", Offset = "0x31E4940", VA = "0x1831E6140")]
		[CompilerGenerated]
		private void MNIILMKEFJO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GMJCAPMHOCH
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GMJCAPMHOCH MFHJEOHMMHA(Action MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GMJCAPMHOCH MIBOMPAHJHA(Action MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GMJCAPMHOCH GGFIPACNPEG(Action MJHIGMCCOPA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BAJAPIIDNPN : GMJCAPMHOCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle EEAIJGBFOFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action FLFAMANBCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action PFJLBPMKLIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action GHDFNONILKD;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool NAEFKJMGHME
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x31DE410", Offset = "0x31DCC10", VA = "0x1831DE410")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xD1CF50", Offset = "0xD1B750", VA = "0x180D1CF50", Slot = "4")]
			public GMJCAPMHOCH MFHJEOHMMHA(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xD1BEC0", Offset = "0xD1A6C0", VA = "0x180D1BEC0", Slot = "5")]
			public GMJCAPMHOCH MIBOMPAHJHA(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xFF9440", Offset = "0xFF7C40", VA = "0x180FF9440", Slot = "6")]
			public GMJCAPMHOCH GGFIPACNPEG(Action MJHIGMCCOPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
			public BAJAPIIDNPN(JobHandle KGFINCEOBGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x31DE420", Offset = "0x31DCC20", VA = "0x1831DE420")]
			public void DOLHECDOMGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x31DE460", Offset = "0x31DCC60", VA = "0x1831DE460")]
			public void NHIAFFMKOAF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BAJAPIIDNPN> OFBLIKBEAMC;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x31E6AA0", Offset = "0x31E52A0", VA = "0x1831E6AA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x31E66E0", Offset = "0x31E4EE0", VA = "0x1831E66E0")]
		public GMJCAPMHOCH Add(JobHandle KGFINCEOBGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x31E69B0", Offset = "0x31E51B0", VA = "0x1831E69B0")]
		public void Remove(GMJCAPMHOCH LHICIKNDDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x31E6850", Offset = "0x31E5050", VA = "0x1831E6850", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x31E6770", Offset = "0x31E4F70", VA = "0x1831E6770")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x31E6BB0", Offset = "0x31E53B0", VA = "0x1831E6BB0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x31EE210", Offset = "0x31ECA10", VA = "0x1831EE210")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x31EE310", Offset = "0x31ECB10", VA = "0x1831EE310")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
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
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
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
