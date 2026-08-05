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
				[Cpp2IlInjected.Address(RVA = "0x7BB0910", Offset = "0x7BAFB10", VA = "0x187BB0910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xD728B0", Offset = "0xD71AB0", VA = "0x180D728B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7BB08D0", Offset = "0x7BAFAD0", VA = "0x187BB08D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA36C0", Offset = "0x7BA28C0", VA = "0x187BA36C0")]
		public LODSettings NOOCDHJJJHB(NNNLBPFEJKG ANANLCFKCEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BA36A0", Offset = "0x7BA28A0", VA = "0x187BA36A0")]
		public int LNJLOBEJDOI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3600", Offset = "0x7BA2800", VA = "0x187BA3600")]
		public int HDAJLKNLJJB(bool FKGICPCGOPL, Vector3 AMBGNPLBPBL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BA36D0", Offset = "0x7BA28D0", VA = "0x187BA36D0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HGMDPBLMKDI
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
public interface LIEJNKNHCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOAJFIJGNMF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PFJGLCMGIGC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int AOBOKJDBLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KKGGLGBODNN> JEBGOFCJBGB
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
	void UpdateClusterDistances(Vector3 IOHMIDHCEGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(BOPELHGKDMF CBNJHLDNKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KKGGLGBODNN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int PLLPPFGHLIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FCNMKAEFJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HPJCJDBABHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KLNGNCOMCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte GCOLLFOKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ALAAFFLFJHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum MBOMELFDIII
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
	private struct PLOILJBOFDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ALAAFFLFJHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3EB0", Offset = "0x7BB30B0", VA = "0x187BB3EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4640", Offset = "0x7BB3840", VA = "0x187BB4640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LPONIDBPDBE : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ALAAFFLFJHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public LPONIDBPDBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0930", Offset = "0x7BAFB30", VA = "0x187BB0930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0A60", Offset = "0x7BAFC60", VA = "0x187BB0A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JOHLFNELMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ALAAFFLFJHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EAIPOBMEIGP<string>.MNKIBAEKPMC worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private EAIPOBMEIGP<string>.MNKIBAEKPMC <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC8A0", Offset = "0x7BABAA0", VA = "0x187BAC8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE100", Offset = "0x7BAD300", VA = "0x187BAE100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PMPNDONHFDO : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ALAAFFLFJHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public PMPNDONHFDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BB46A0", Offset = "0x7BB38A0", VA = "0x187BB46A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5390", Offset = "0x7BB4590", VA = "0x187BB5390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int BEOOLNHEPJE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan IJMDKGOCFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NINCLMGMHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter BLDACHFLHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject JCOMINIDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JOOPBGFKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OBPCGCGFOHC PDBEDMFDOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<BOPELHGKDMF> LIDNGCIOIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<BOPELHGKDMF> PGCKMONNNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<BOPELHGKDMF> ENCEINCBDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LOFAMOOGDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MBOMELFDIII LJAAGNGKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<PFJGLCMGIGC>[] GNFPGDLADFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KKGGLGBODNN>[] ECNBDELPHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource BIOOBPMGCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool BCDCJFAIPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private PEFNPNHCEAP APPMKCGADAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PEFNPNHCEAP IFPDPLJIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int AAPKNEKDABP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static ALAAFFLFJHB DGHGLEFLLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ADDCMFFAADD DGABEDJNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LKBFHDGOBMJ BDDNLLMPCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour KKEKCBNJFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material PDHHGNFFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> EHIAMNEBHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material MOGLLPKCOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> PPONJPHGLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool ICAMAHADNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<LIEJNKNHCHI> PFIOLELAEJC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig HLIEPEFDHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 JFDGEIGCMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2530", Offset = "0x1DE1730", VA = "0x181DE2530")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2460", Offset = "0x1DE1660", VA = "0x181DE2460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MBOMELFDIII GNPJFBLJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF524E0", Offset = "0xF516E0", VA = "0x180F524E0")]
		get
		{
			return default(MBOMELFDIII);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2520", Offset = "0x7BA1720", VA = "0x187BA2520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ALAAFFLFJHB NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0A40", Offset = "0x7B9FC40", VA = "0x187BA0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool GOKCGMJIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FB20", Offset = "0x7B9ED20", VA = "0x187B9FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool AOJMMFLIDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BA23E0", Offset = "0x7BA15E0", VA = "0x187BA23E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> INMIIOAGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1150", Offset = "0x7BA0350", VA = "0x187BA1150")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0E60", Offset = "0x7BA0060", VA = "0x187BA0E60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GMCNJCJKAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0120", Offset = "0x7B9F320", VA = "0x187BA0120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0450", Offset = "0x7B9F650", VA = "0x187BA0450")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E80", Offset = "0x7BA2080", VA = "0x187BA2E80")]
	public ALAAFFLFJHB(ADDCMFFAADD DGABEDJNEKO, LKBFHDGOBMJ BDDNLLMPCCP, ClusterLODConfig DIIKFDKBDAB, MonoBehaviour KKEKCBNJFLP, Material JNAICNGCKGK, ClusterMeshRenderer NINCLMGMHCH, MeshFilter BLDACHFLHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2270", Offset = "0x7BA1470", VA = "0x187BA2270")]
	private void NAIGBCHDCNC(Material JNAICNGCKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1070", Offset = "0x7BA0270", VA = "0x187BA1070")]
	public void ICCKMOAAINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1210", Offset = "0x7BA0410", VA = "0x187BA1210")]
	public static PBKMGPOLEJF.FPNIDPGNDKH JKHGMDPEPND(PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ)
	{
		return default(PBKMGPOLEJF.FPNIDPGNDKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BA05F0", Offset = "0x7B9F7F0", VA = "0x187BA05F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F80", Offset = "0x7BA0180", VA = "0x187BA0F80")]
	public static void HAEJIGCCKED(Vector3 KBPGILFBCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1CF0", Offset = "0x7BA0EF0", VA = "0x187BA1CF0")]
	private void LDBHHKLPGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0D90", Offset = "0x7B9FF90", VA = "0x187BA0D90")]
	private void GKOPOCOJJJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1BA0", Offset = "0x7BA0DA0", VA = "0x187BA1BA0")]
	private void LCJNMDDGCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA27C0", Offset = "0x7BA19C0", VA = "0x187BA27C0")]
	public void POOIFGKCOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2150", Offset = "0x7BA1350", VA = "0x187BA2150")]
	[AsyncStateMachine(typeof(PLOILJBOFDF))]
	public Task MLBAFMGJOPL(EAIPOBMEIGP<string>.MNKIBAEKPMC LLJAAOPICBK, CancellationToken DMKDGAIEPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA09C0", Offset = "0x7B9FBC0", VA = "0x187BA09C0")]
	[IteratorStateMachine(typeof(LPONIDBPDBE))]
	private IEnumerator<EAALCCOKLJL> EAEMFPNPJIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0C70", Offset = "0x7B9FE70", VA = "0x187BA0C70")]
	[AsyncStateMachine(typeof(JOHLFNELMMI))]
	private Task GGHOLBCGAGC(EAIPOBMEIGP<string>.MNKIBAEKPMC GDEJKJCICOO, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA01D0", Offset = "0x7B9F3D0", VA = "0x187BA01D0")]
	public void BDNJGDDNBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1B20", Offset = "0x7BA0D20", VA = "0x187BA1B20")]
	public void LBGIIIINJGK(IEnumerable<PFJGLCMGIGC> DIGIJADFLPB, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1DC0", Offset = "0x7BA0FC0", VA = "0x187BA1DC0")]
	public void MELEHMFGAGF(IEnumerable<PFJGLCMGIGC> DIGIJADFLPB, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1230", Offset = "0x7BA0430", VA = "0x187BA1230")]
	public List<ClusterMeshRenderer> JLJEECDCDPI(List<BOPELHGKDMF> FLPMJCCDHNM, AOECEAGCFFM FHPKLENNKKO, HGMDPBLMKDI LFADMJJFICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1AC0", Offset = "0x7BA0CC0", VA = "0x187BA1AC0")]
	public void LACLMKAJDJM(LIEJNKNHCHI CKLOJLKMKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F20", Offset = "0x7BA0120", VA = "0x187BA0F20")]
	public bool GODCBCFJALJ(LIEJNKNHCHI CKLOJLKMKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0500", Offset = "0x7B9F700", VA = "0x187BA0500")]
	public void DDGINHALBBL(BOPELHGKDMF MNBAECKBBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0BF0", Offset = "0x7B9FDF0", VA = "0x187BA0BF0")]
	public void FMMGGDLNBIP(KKGGLGBODNN HDDBABKJHIG, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BA03D0", Offset = "0x7B9F5D0", VA = "0x187BA03D0")]
	public void BLJLLKPHHBE(KKGGLGBODNN HDDBABKJHIG, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FC10", Offset = "0x7B9EE10", VA = "0x187B9FC10")]
	private void AEBAHLPELCC(Vector3 IOHMIDHCEGD, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0A90", Offset = "0x7B9FC90", VA = "0x187BA0A90")]
	private void FFFBFCCDOPM(Vector3 IOHMIDHCEGD, HGMDPBLMKDI LFADMJJFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BA24A0", Offset = "0x7BA16A0", VA = "0x187BA24A0")]
	[IteratorStateMachine(typeof(PMPNDONHFDO))]
	private IEnumerator<EAALCCOKLJL> PBNBFBEFEDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2650", Offset = "0x7BA1850", VA = "0x187BA2650")]
	private int PMGODCPBMDM(int NIBICIJAIGM, int PLHLEMPFDIO, List<KKGGLGBODNN> KNCOOOBPKDP, byte ANANLCFKCEG, int HGLCNDGCDBL, float CDENFDPLHGA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1910", Offset = "0x7BA0B10", VA = "0x187BA1910")]
	public void KKKHDEJPLIG(BOPELHGKDMF CBNJHLDNKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1110", Offset = "0x7BA0310", VA = "0x187BA1110")]
	public bool ICJKKKDODKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xCCA9E0", Offset = "0xCC9BE0", VA = "0x180CCA9E0")]
	public Material DIMGNLGJEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0560", Offset = "0x7B9F760", VA = "0x187BA0560")]
	public Material DIMGNLGJEGK(PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x9F8AC0", Offset = "0x9F7CC0", VA = "0x1809F8AC0")]
	public Material MHMHDKMDDDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BA20C0", Offset = "0x7BA12C0", VA = "0x187BA20C0")]
	public Material MHMHDKMDDDP(PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1D80", Offset = "0x7BA0F80", VA = "0x187BA1D80")]
	public int LNJLOBEJDOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FD50", Offset = "0x7B9EF50", VA = "0x187B9FD50")]
	public (long, int) AHNCOFJDLKK()
	{
		return default((long, int));
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct FCBNCENKLLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> BOPICDKMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> DEANHPLFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> LHKGABDCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> ONNOOKEAOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 NLKIGHIIINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float MKCGFHEEIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> FGLOEBDFGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> HMIBKINFOMG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BA74B0", Offset = "0x7BA66B0", VA = "0x187BA74B0")]
	public FCBNCENKLLG(PBKMGPOLEJF KHKMPBIDLPA, NativeList<float3> ONNOOKEAOAO, NativeParallelMultiHashMap<int, int> FGLOEBDFGIE, NativeArray<int> HMIBKINFOMG, Vector3 NLKIGHIIINP, float MKCGFHEEIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7450", Offset = "0x7BA6650", VA = "0x187BA7450")]
	private int FFGJMMFGJPH(float3 IOHMIDHCEGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6DB0", Offset = "0x7BA5FB0", VA = "0x187BA6DB0")]
	private int DEAIKICEDCK(int EOIAPGKFGAB, int AGBHGDFILGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7020", Offset = "0x7BA6220", VA = "0x187BA7020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EMPBHOIBJON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> FGLOEBDFGIE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> HMIBKINFOMG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int LFJNDKIABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> OCAEAMGFBPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6AC0", Offset = "0x7BA5CC0", VA = "0x187BA6AC0")]
	public void EPNMOGAJAEC(int HGFLJHNNBAG, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA69E0", Offset = "0x7BA5BE0", VA = "0x187BA69E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EMPBHOIBJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GPMBKONIBIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> HAGHMHCNPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> FJMAGMCBHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA340", Offset = "0x7BA9540", VA = "0x187BAA340")]
	public GPMBKONIBIO(EMPBHOIBJON CNDFJPHKDEO, PBKMGPOLEJF KHKMPBIDLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA290", Offset = "0x7BA9490", VA = "0x187BAA290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DAGFGGNLEFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> JFCONLOMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> DEDFHGIPCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> NFEAFDKFIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> IELKJLAKEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> DIPPFNLKAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> OCAEAMGFBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> HAGHMHCNPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> GNLGHKBBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> BDAHJAJMDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> KKEBGLAIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> OJGPPPEHBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> GLPJEKHDCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> CFGHODHJCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float IMBELGCKOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float CAEGPDGMFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 BLPJCJEDNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float GIBFLEEBGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float NOCLBADALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float BMKHJPOEOBG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BA67C0", Offset = "0x7BA59C0", VA = "0x187BA67C0")]
	public DAGFGGNLEFB(EMPBHOIBJON NKLMJHLMDCA, PBKMGPOLEJF KHKMPBIDLPA, PBKMGPOLEJF KBMMIHLGLBJ, float NOCLBADALBE, float BMKHJPOEOBG, Vector3 BLPJCJEDNFF, float GIBFLEEBGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6410", Offset = "0x7BA5610", VA = "0x187BA6410")]
	private float3 KKFLCGJNAHL(int EOIAPGKFGAB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6030", Offset = "0x7BA5230", VA = "0x187BA6030")]
	private void FEGEGNOHPCD(int EOIAPGKFGAB, [Out] float3 OLKOGNCOPJO, [Out] float3 JPKNMLDJMMC, [Out] float4 LFMPEENCCOI, [Out] float4 CFANIBINMGB, [Out] float2 EKOEPANKNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BA64E0", Offset = "0x7BA56E0", VA = "0x187BA64E0")]
	private int OLJCDHPBNKB(int KLGBJOGPONI, int CHEOOAKPFBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6210", Offset = "0x7BA5410", VA = "0x187BA6210")]
	private void IEOBEILHHKI(int KLGBJOGPONI, int CHEOOAKPFBC, int EEONCEOAOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5560", Offset = "0x7BA4760", VA = "0x187BA5560")]
	private bool ECJMJOKNLCB(int KLGBJOGPONI, int CHEOOAKPFBC, float OGDJGHPCLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BA54A0", Offset = "0x7BA46A0", VA = "0x187BA54A0")]
	private bool BDFJEHKGGFH(int KLGBJOGPONI, int CHEOOAKPFBC, int EEONCEOAOFF, float OGDJGHPCLMA, bool GJFJHJKDOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5240", Offset = "0x7BA4440", VA = "0x187BA5240")]
	private bool BBEBHFCADEJ(int KLGBJOGPONI, int CHEOOAKPFBC, int EEONCEOAOFF, float OGDJGHPCLMA, bool GJFJHJKDOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA64C0", Offset = "0x7BA56C0", VA = "0x187BA64C0")]
	private void MFOAOHIMGOM(int KLGBJOGPONI, int CHEOOAKPFBC, int EEONCEOAOFF, [Out] int DHDLJFPPKBD, [Out] int FOKMDBJEPMP, [Out] int OCMNLBHLGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA56B0", Offset = "0x7BA48B0", VA = "0x187BA56B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NPEHEOHNGCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OEKPPIFBHGH : IDisposable, KKGGLGBODNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds FNDKJDJMBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<BOPELHGKDMF> FLPMJCCDHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 DMNBOGHLLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 HPDOOAOHKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int KCDBDDGMJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public PBKMGPOLEJF PIMHJJNGCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long JKIEANHLCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EMPBHOIBJON LBDAGICPAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform FHPKLENNKKO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DEGFJDALCAC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB36E0", Offset = "0x7BB28E0", VA = "0x187BB36E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh NOHHBJMEJFO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PBKMGPOLEJF.FPNIDPGNDKH KFGGLJEGGKD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
			[CompilerGenerated]
			get
			{
				return default(PBKMGPOLEJF.FPNIDPGNDKH);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh EGGIDAMGNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PBKMGPOLEJF.FPNIDPGNDKH PLHFAMIJLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE755B0", Offset = "0xE747B0", VA = "0x180E755B0")]
			[CompilerGenerated]
			get
			{
				return default(PBKMGPOLEJF.FPNIDPGNDKH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE75BE0", Offset = "0xE74DE0", VA = "0x180E75BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float HPJCJDBABHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA60", Offset = "0x10CEC60", VA = "0x1810CFA60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x17604C0", Offset = "0x175F6C0", VA = "0x1817604C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte GCOLLFOKGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x16A8490", Offset = "0x16A7690", VA = "0x1816A8490")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x16A8470", Offset = "0x16A7670", VA = "0x1816A8470", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PLLPPFGHLIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA27C90", Offset = "0xA26E90", VA = "0x180A27C90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x132DD30", Offset = "0x132CF30", VA = "0x18132DD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int FCNMKAEFJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA17F30", Offset = "0xA17130", VA = "0x180A17F30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x132D4E0", Offset = "0x132C6E0", VA = "0x18132D4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KLNGNCOMCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB36C0", Offset = "0x7BB28C0", VA = "0x187BB36C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3AA0", Offset = "0x7BB2CA0", VA = "0x187BB3AA0")]
		public void LHDLGNOBHOL(NNNLBPFEJKG ANANLCFKCEG, [Out] int KLACLIDIDNP, [Out] int CPBAFNDHECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB38D0", Offset = "0x7BB2AD0", VA = "0x187BB38D0")]
		public void EBLNCBIFKJA(NNNLBPFEJKG ANANLCFKCEG, CCILIPHKBOG NACJJLCOMCL, int DIJAELCBEGJ = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3610", Offset = "0x7BB2810", VA = "0x187BB3610")]
		public void AKCOLJMJHOM(Mesh KHKMPBIDLPA, PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3D00", Offset = "0x7BB2F00", VA = "0x187BB3D00")]
		public void OAPFPHKGKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3720", Offset = "0x7BB2920", VA = "0x187BB3720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3D90", Offset = "0x7BB2F90", VA = "0x187BB3D90")]
		public OEKPPIFBHGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds FNDKJDJMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public PBKMGPOLEJF.FPNIDPGNDKH BCBLGHIDLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<OEKPPIFBHGH> LFMICNMJCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LACOPEPHGBN JBJCJJOKIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer FNEFIOJLPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int COKIDPIMKGK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GLJCMIIGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NBONFPFLPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AOBOKJDBLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BB11B0", Offset = "0x7BB03B0", VA = "0x187BB11B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1200", Offset = "0x7BB0400", VA = "0x187BB1200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BB21E0", Offset = "0x7BB13E0", VA = "0x187BB21E0")]
	public int INAGLMBCPOO(int OEFLCHOOIHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0FC0", Offset = "0x7BB01C0", VA = "0x187BB0FC0")]
	public void ALPCENHAOHO(DLJDADALJBP LGNPGAENCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1380", Offset = "0x7BB0580", VA = "0x187BB1380")]
	public void HBGEBEMKPDI(Transform CPKLBNLBGKC, bool LFGBCFEEBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2480", Offset = "0x7BB1680", VA = "0x187BB2480")]
	public bool ODPBACKDHMG(bool NJMNKDNMGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1BC0", Offset = "0x7BB0DC0", VA = "0x187BB1BC0")]
	public void IHBHAJMNKBK(Transform FHPKLENNKKO, bool LFGBCFEEBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2210", Offset = "0x7BB1410", VA = "0x187BB2210")]
	public bool KKKHDEJPLIG(BOPELHGKDMF CBNJHLDNKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2640", Offset = "0x7BB1840", VA = "0x187BB2640")]
	public NPEHEOHNGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OBPCGCGFOHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<NPEHEOHNGCG.OEKPPIFBHGH> FFNODEMKBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private FEFGABHGOBB NLBKDGEHGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<NPEHEOHNGCG.OEKPPIFBHGH> PGDHEGHBEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int NOCDNPHGDJP;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BB27B0", Offset = "0x7BB19B0", VA = "0x187BB27B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BB28C0", Offset = "0x7BB1AC0", VA = "0x187BB28C0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BB32E0", Offset = "0x7BB24E0", VA = "0x187BB32E0")]
	public void OOLDDNFEGEK(NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ, Transform FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2F50", Offset = "0x7BB2150", VA = "0x187BB2F50")]
	public void KKKHDEJPLIG(NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3130", Offset = "0x7BB2330", VA = "0x187BB3130")]
	private NPEHEOHNGCG.OEKPPIFBHGH OFCFEACNLPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2710", Offset = "0x7BB1910", VA = "0x187BB2710")]
	private bool AIEANNMOPBJ(NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2940", Offset = "0x7BB1B40", VA = "0x187BB2940")]
	private void HAEIIJBPHOD(NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2890", Offset = "0x7BB1A90", VA = "0x187BB2890")]
	public bool FFLOFBNNOFK(NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BB29A0", Offset = "0x7BB1BA0", VA = "0x187BB29A0")]
	public bool IOJFMKAPHLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3270", Offset = "0x7BB2470", VA = "0x187BB3270")]
	private NPEHEOHNGCG.OEKPPIFBHGH OJOMHNFEBOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2C30", Offset = "0x7BB1E30", VA = "0x187BB2C30")]
	public long JEAJMJFLJBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB33A0", Offset = "0x7BB25A0", VA = "0x187BB33A0")]
	public OBPCGCGFOHC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AJPONGDCNNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int ELFBGHJCDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int CDGJAFGCABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float FFOCPDJFCJL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<NPEHEOHNGCG> CBDPIDMACPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FAD0", Offset = "0x7B9ECD0", VA = "0x187B9FAD0")]
	public AJPONGDCNNJ(int ELFBGHJCDPO, int CDGJAFGCABB, float GENLBPPFFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F660", Offset = "0x7B9E860", VA = "0x187B9F660")]
	public void BMPFKJMHPMP(AJKLBBFPIGN BNMHCMMLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F980", Offset = "0x7B9EB80", VA = "0x187B9F980")]
	private int HNKFBGCNGJC(DLJDADALJBP GCEDHPINDAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F710", Offset = "0x7B9E910", VA = "0x187B9F710")]
	private void BMPFKJMHPMP(DLJDADALJBP GCEDHPINDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FA30", Offset = "0x7B9EC30", VA = "0x187B9FA30")]
	private void KGEIDFHFFMK(DLJDADALJBP GCEDHPINDAM, NPEHEOHNGCG HPOMCGGEJIJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PFJGLCMGIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JPIONGBFBBE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
			[DebuggerHidden]
			public JPIONGBFBBE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7BAE160", Offset = "0x7BAD360", VA = "0x187BAE160", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7BAE320", Offset = "0x7BAD520", VA = "0x187BAE320", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7BAE270", Offset = "0x7BAD470", VA = "0x187BAE270", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BAE270", Offset = "0x7BAD470", VA = "0x187BAE270", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AOBOKJDBLNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7BA51E0", Offset = "0x7BA43E0", VA = "0x187BA51E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<KKGGLGBODNN> JEBGOFCJBGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7BA51C0", Offset = "0x7BA43C0", VA = "0x187BA51C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> LFMICNMJCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NPEHEOHNGCG GLJCMIIGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public HGMDPBLMKDI KBIJKFLDIKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(HGMDPBLMKDI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool INCMDNMFFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC73FA0", Offset = "0xC731A0", VA = "0x180C73FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3730", Offset = "0x7BA2930", VA = "0x187BA3730")]
		public static ClusterMeshRenderer Create(NPEHEOHNGCG KHKMPBIDLPA, ClusterMeshRenderer NINCLMGMHCH, MeshFilter BLDACHFLHNI, AOECEAGCFFM FHPKLENNKKO, HGMDPBLMKDI LFADMJJFICC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA39A0", Offset = "0x7BA2BA0", VA = "0x187BA39A0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4490", Offset = "0x7BA3690", VA = "0x187BA4490", Slot = "9")]
		public bool TryRemoveClusterLODComponent(BOPELHGKDMF CBNJHLDNKAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4240", Offset = "0x7BA3440", VA = "0x187BA4240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3ED0", Offset = "0x7BA30D0", VA = "0x187BA3ED0")]
		public void Init(NPEHEOHNGCG KHKMPBIDLPA, MeshFilter BLDACHFLHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A00", Offset = "0x7BA2C00", VA = "0x187BA3A00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA45C0", Offset = "0x7BA37C0", VA = "0x187BA45C0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 IOHMIDHCEGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4870", Offset = "0x7BA3A70", VA = "0x187BA4870", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E50", Offset = "0x7BA3050", VA = "0x187BA3E50")]
		[IteratorStateMachine(typeof(JPIONGBFBBE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA42D0", Offset = "0x7BA34D0", VA = "0x187BA42D0")]
		public void SetupTagAndLayer(string LHAEPBBBCAO, int LFADMJJFICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA42B0", Offset = "0x7BA34B0", VA = "0x187BA42B0")]
		public bool Remove(BOPELHGKDMF CBNJHLDNKAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NHCHCEMOOEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int NFDDBAKDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int AIGLIPKHKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int CPBAFNDHECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int KLACLIDIDNP;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0FA0", Offset = "0x7BB01A0", VA = "0x187BB0FA0")]
	public NHCHCEMOOEL(int AIGLIPKHKOK, int CPBAFNDHECP, int NFDDBAKDFKM, int KLACLIDIDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LACOPEPHGBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> OCAEAMGFBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> LHKGABDCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<NHCHCEMOOEL> FOMGAHJFGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> CKOAPNHFCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> BOOOHLBDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> LJGIPHADPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle EOJDBKLNAOP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BFDEOBNNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA209E0", Offset = "0xA1FBE0", VA = "0x180A209E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1F890", Offset = "0xA1EA90", VA = "0x180A1F890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF890", Offset = "0x7BAEA90", VA = "0x187BAF890")]
	public void MNFKMEBPDCG(PBKMGPOLEJF NOGKABKBGPC, NativeList<NHCHCEMOOEL> FOMGAHJFGDP, float MMIJFAFPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF600", Offset = "0x7BAE800", VA = "0x187BAF600")]
	public void MMFHONMHABG(Transform FHPKLENNKKO, bool LFGBCFEEBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0730", Offset = "0x7BAF930", VA = "0x187BB0730")]
	public void ODPBACKDHMG(NPEHEOHNGCG FNEFIOJLPDJ, bool NJMNKDNMGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF4C0", Offset = "0x7BAE6C0", VA = "0x187BAF4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF5D0", Offset = "0x7BAE7D0", VA = "0x187BAF5D0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LACOPEPHGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GCLOPJFEJCJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> FGCDPHHICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> OCAEAMGFBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<NHCHCEMOOEL> LDGFHOLFMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> CKOAPNHFCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 BLPJCJEDNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> BOOOHLBDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> LJGIPHADPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool LFGBCFEEBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float JPBMEIDFPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float PGLKLEEDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float DPCGGAMCAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> LHKGABDCFKK;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9A70", Offset = "0x7BA8C70", VA = "0x187BA9A70")]
	public GCLOPJFEJCJ(LACOPEPHGBN BIMGLPHENFE, Vector3 BLPJCJEDNFF, bool LFGBCFEEBGO, float JPBMEIDFPLK, float PGLKLEEDNNO, float DPCGGAMCAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9570", Offset = "0x7BA8770", VA = "0x187BA9570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BOPELHGKDMF : IIGOFCLCLJP
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds DEOGGMHPFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DLJDADALJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<BOPELHGKDMF> FLPMJCCDHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public DLJDADALJBP NJHDJGHEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public DLJDADALJBP GBOFGGNLFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public DLJDADALJBP JEBHKGGJIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int KLACLIDIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds FNDKJDJMBAF;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6900", Offset = "0x7BA5B00", VA = "0x187BA6900")]
	public DLJDADALJBP(List<BOPELHGKDMF> FLPMJCCDHNM, [Optional] DLJDADALJBP NJHDJGHEICO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AJKLBBFPIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<DLJDADALJBP> NGEKJCOPDJE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public DLJDADALJBP ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F590", Offset = "0x7B9E790", VA = "0x187B9F590")]
	public AJKLBBFPIGN(DLJDADALJBP FHPKLENNKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ICENGIIIHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct DAEMGKFALEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int COBNFOKJMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int AAKIPKADPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DIHGNGEJEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int GOCGLJGABGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DLOMFGLHLDG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int BLOBFAOGAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float KCJFFLAHAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<BOPELHGKDMF> FLPMJCCDHNM;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6980", Offset = "0x7BA5B80", VA = "0x187BA6980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PPCPMNLJKAI
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
	private DAEMGKFALEB IIJNHNNCMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int MEABGCKDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int ELFBGHJCDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int CDGJAFGCABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float GENLBPPFFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float AGAEKANBLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<DLJDADALJBP> EIKNEJBKGJE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AJKLBBFPIGN GPNPBIHAIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC840", Offset = "0x7BABA40", VA = "0x187BAC840")]
	public ICENGIIIHGL(int ELFBGHJCDPO, int CDGJAFGCABB, float GENLBPPFFDC, int MEABGCKDDGD, float AGAEKANBLFB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC600", Offset = "0x7BAB800", VA = "0x187BAC600")]
	public void NKJDAEOMOME(List<BOPELHGKDMF> FLPMJCCDHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BABBB0", Offset = "0x7BAADB0", VA = "0x187BABBB0")]
	public bool HIJAMHJPGMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC7F0", Offset = "0x7BAB9F0", VA = "0x187BAC7F0")]
	private float OHHABIHLGPF(Vector3 BCBBNNPFNAH, Vector3 IMCPMFMKKOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC7D0", Offset = "0x7BAB9D0", VA = "0x187BAC7D0")]
	private float OHHABIHLGPF(Vector3 JAFKPMJIGFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BABC20", Offset = "0x7BAAE20", VA = "0x187BABC20")]
	private bool IEDGICNHGGJ(DLJDADALJBP APNJDCLCJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA7A0", Offset = "0x7BA99A0", VA = "0x187BAA7A0")]
	private DLOMFGLHLDG CNJCDOLILPL(List<BOPELHGKDMF> DEOINNPEIEH, PPCPMNLJKAI GEHLNCLEDDK)
	{
		return default(DLOMFGLHLDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB7F0", Offset = "0x7BAA9F0", VA = "0x187BAB7F0")]
	private void DBEJLCHOOGF(List<BOPELHGKDMF> FLPMJCCDHNM, NativeArray<Vector3> NIPONCPIFOH, NativeArray<Vector3> LICKKCIBHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class GAJEBLEMMPI
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BA93A0", Offset = "0x7BA85A0", VA = "0x187BA93A0")]
	public static Bounds OOGFAKBCFMK(List<BOPELHGKDMF> FLPMJCCDHNM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA91D0", Offset = "0x7BA83D0", VA = "0x187BA91D0")]
	public static int HGHKKLKFJHK(List<BOPELHGKDMF> FLPMJCCDHNM, NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class GIIGENKDHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool ENKCPACNKFA(float4* DEANHPLFMOD, int LMMGFKFHEJP);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class NBIOIMJOJHD
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr KLBOOEECNEF;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr FOCLLCPOMKI;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0D30", Offset = "0x7BAFF30", VA = "0x187BB0D30")]
		[BurstDiscard]
		private static void GHGACEPOOPK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0E50", Offset = "0x7BB0050", VA = "0x187BB0E50")]
		private static IntPtr NOBCIJFNGID()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0AB0", Offset = "0x7BAFCB0", VA = "0x187BB0AB0")]
		public static void BPAFLPIOOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0B50", Offset = "0x7BAFD50", VA = "0x187BB0B50")]
		public unsafe static bool ENEDPBAOBKF(float4* DEANHPLFMOD, int LMMGFKFHEJP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9C30", Offset = "0x7BA8E30", VA = "0x187BA9C30")]
	[BurstCompile]
	public unsafe static bool MFKJCGJAOLF(float4* DEANHPLFMOD, int LMMGFKFHEJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F3A0", Offset = "0x7B9E5A0", VA = "0x187B9F3A0")]
	[BurstCompile]
	public unsafe static bool OCKHDJBLGIG(float4* DEANHPLFMOD, int LMMGFKFHEJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct HGFOMPGLECO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> KDNNGOEBDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> BOCCADBEGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> FNEKBNJAKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> DDDDJPKFPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> HIJKLJKBGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> BOPICDKMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> MDOOMCLFPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> ALLHFLOIFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<PBKMGPOLEJF.OIHBPPIMBHM> AMOIJNCDGED;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA680", Offset = "0x7BA9880", VA = "0x187BAA680")]
	public HGFOMPGLECO(PBKMGPOLEJF JBKOPJBAFFH, NativeArray<bool> MDOOMCLFPJO, NativeList<ushort> ALLHFLOIFMP, NativeList<PBKMGPOLEJF.OIHBPPIMBHM> AMOIJNCDGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA3D0", Offset = "0x7BA95D0", VA = "0x187BAA3D0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct FMBBLEMBPFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> KDNNGOEBDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> BOCCADBEGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> FNEKBNJAKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> DDDDJPKFPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> HIJKLJKBGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> BOPICDKMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> OPPEDOMOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> HJIHMPIPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> GLHFACGAGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> PHHOGNLGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> ODGIIFMLOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> MLGHKAJBEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> MDOOMCLFPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> ALLHFLOIFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<PBKMGPOLEJF.OIHBPPIMBHM> AMOIJNCDGED;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9110", Offset = "0x7BA8310", VA = "0x187BA9110")]
	public FMBBLEMBPFE(PBKMGPOLEJF JBKOPJBAFFH, PBKMGPOLEJF MGGDOJOOPDC, NativeArray<bool> MDOOMCLFPJO, NativeList<ushort> ALLHFLOIFMP, NativeList<PBKMGPOLEJF.OIHBPPIMBHM> AMOIJNCDGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8C40", Offset = "0x7BA7E40", VA = "0x187BA8C40", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FEFGABHGOBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PBKMGPOLEJF BGDCNAIPEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PBKMGPOLEJF JBKOPJBAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> LMDLCCCKKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> ALLHFLOIFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<PBKMGPOLEJF.OIHBPPIMBHM> AMOIJNCDGED;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static PBKMGPOLEJF JOEDJCMMDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private OIMMFGPJGMB BKEAAGHBHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private CCILIPHKBOG NACJJLCOMCL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle EOJDBKLNAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NPEHEOHNGCG.OEKPPIFBHGH APNJDCLCJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BGILIBFABMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2396770", Offset = "0x2395970", VA = "0x182396770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7680", Offset = "0x7BA6880", VA = "0x187BA7680")]
	[MPFAIPJMBCK(GGMCIMEHBME.EnteredEditMode, 0)]
	private static void GLMGKHCOPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA76F0", Offset = "0x7BA68F0", VA = "0x187BA76F0")]
	public void MNFKMEBPDCG(NPEHEOHNGCG.OEKPPIFBHGH LDGFHOLFMEH, Transform OJJFGCPMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8210", Offset = "0x7BA7410", VA = "0x187BA8210")]
	public void OJNNPLIOABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7570", Offset = "0x7BA6770", VA = "0x187BA7570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7640", Offset = "0x7BA6840", VA = "0x187BA7640")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8AD0", Offset = "0x7BA7CD0", VA = "0x187BA8AD0")]
	public FEFGABHGOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LKBFHDGOBMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 PAENBGJONBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ADDCMFFAADD
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(EAIPOBMEIGP<string>.MNKIBAEKPMC GDEJKJCICOO, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ACONLAJOHMK
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACONLAJOHMK AMGFINKDDJD(Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACONLAJOHMK NEAJNLKCICO(Action HDKINMMJOHF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class GPIGONOCIOL : ACONLAJOHMK
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class GDOPOGLJAKE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public GPIGONOCIOL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
				public GDOPOGLJAKE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7BA9B40", Offset = "0x7BA8D40", VA = "0x187BA9B40")]
				internal void CHHFEKNNBAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7BA9BE0", Offset = "0x7BA8DE0", VA = "0x187BA9BE0")]
				internal void KNJJIMFDLDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7BA9B90", Offset = "0x7BA8D90", VA = "0x187BA9B90")]
				internal void DHAJJJFBJLL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> OEKGBEFMDPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action JDDMOJHNOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action PKOKJGHKBMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private AHDAONEOIHK ANEAMFBCMBJ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action CFCOBJHNELI
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action NIHBIFFFHFO
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x27570D0", Offset = "0x27562D0", VA = "0x1827570D0", Slot = "4")]
			public ACONLAJOHMK AMGFINKDDJD(Action HDKINMMJOHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7535DF0", Offset = "0x7534FF0", VA = "0x187535DF0", Slot = "5")]
			public ACONLAJOHMK NEAJNLKCICO(Action HDKINMMJOHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
			public GPIGONOCIOL(Func<JobHandle> BBBCBEDMMHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9FD0", Offset = "0x7BA91D0", VA = "0x187BA9FD0")]
			public void MENHHIHEOIL(Action DJNPODFFNLG, Action FHHEJJDKMNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9E40", Offset = "0x7BA9040", VA = "0x187BA9E40")]
			public void KKKHDEJPLIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class KFHCOOIOAHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public ACONLAJOHMK jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KFHCOOIOAHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF4B0", Offset = "0x7BAE6B0", VA = "0x187BAF4B0")]
			internal bool NBAOFJCAJLF(GPIGONOCIOL a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class HCIDGFFBLJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public GPIGONOCIOL newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HCIDGFFBLJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA370", Offset = "0x7BA9570", VA = "0x187BAA370")]
			internal void PJBEAAGGKDE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<GPIGONOCIOL> GJPKKOKOOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<GPIGONOCIOL> EFIIMBNJBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private PEFNPNHCEAP EOADNCFPKHK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public DJJGEDLEEFI HGBHBELBOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE370", Offset = "0x7BAD570", VA = "0x187BAE370")]
		public ACONLAJOHMK Add(Func<JobHandle> BBBCBEDMMHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE6A0", Offset = "0x7BAD8A0", VA = "0x187BAE6A0")]
		public void Remove(ACONLAJOHMK EOJDBKLNAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE4C0", Offset = "0x7BAD6C0", VA = "0x187BAE4C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE880", Offset = "0x7BADA80", VA = "0x187BAE880")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEAE0", Offset = "0x7BADCE0", VA = "0x187BAEAE0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE690", Offset = "0x7BAD890", VA = "0x187BAE690")]
		[CompilerGenerated]
		private void PEJAMKFGFLA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AHDAONEOIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHDAONEOIHK AMGFINKDDJD(Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AHDAONEOIHK PDKPFCLCHOM(Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AHDAONEOIHK NEAJNLKCICO(Action HDKINMMJOHF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, PFFMGCANADG
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class HIPEABKOKKK : AHDAONEOIHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle IJPBOHDHFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action JDDMOJHNOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action JAIOOHHLDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action NIHBIFFFHFO;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool INKNHIHBLEB
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7BAA740", Offset = "0x7BA9940", VA = "0x187BAA740")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7319740", Offset = "0x7318940", VA = "0x187319740", Slot = "4")]
			public AHDAONEOIHK AMGFINKDDJD(Action HDKINMMJOHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7318410", Offset = "0x7317610", VA = "0x187318410", Slot = "5")]
			public AHDAONEOIHK PDKPFCLCHOM(Action HDKINMMJOHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7535DF0", Offset = "0x7534FF0", VA = "0x187535DF0", Slot = "6")]
			public AHDAONEOIHK NEAJNLKCICO(Action HDKINMMJOHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xF98910", Offset = "0xF97B10", VA = "0x180F98910")]
			public HIPEABKOKKK(JobHandle CEJAIFHNGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA6F0", Offset = "0x7BA98F0", VA = "0x187BAA6F0")]
			public void BKELOGOOEBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA750", Offset = "0x7BA9950", VA = "0x187BAA750")]
			public void KKKHDEJPLIG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<HIPEABKOKKK> DFHDPJNLENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> DCJEBMJFGCC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HMKFKLBGGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF0C0", Offset = "0x7BAE2C0", VA = "0x187BAF0C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1412930", Offset = "0x1411B30", VA = "0x181412930")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEBC0", Offset = "0x7BADDC0", VA = "0x187BAEBC0")]
		public AHDAONEOIHK Add(JobHandle CEJAIFHNGDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF2D0", Offset = "0x7BAE4D0", VA = "0x187BAF2D0")]
		public void Remove(AHDAONEOIHK EOJDBKLNAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEEE0", Offset = "0x7BAE0E0", VA = "0x187BAEEE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7BAED30", Offset = "0x7BADF30", VA = "0x187BAED30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEC60", Offset = "0x7BADE60", VA = "0x187BAEC60")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF3D0", Offset = "0x7BAE5D0", VA = "0x187BAF3D0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDE0", Offset = "0xA1BFE0", VA = "0x180A1CDE0", Slot = "6")]
		private bool IPNNAEAJLGL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB53E0", Offset = "0x7BB45E0", VA = "0x187BB53E0")]
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
