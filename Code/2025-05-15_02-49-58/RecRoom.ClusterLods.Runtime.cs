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
				[Cpp2IlInjected.Address(RVA = "0x7B49310", Offset = "0x7B47910", VA = "0x187B49310")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xD6A000", Offset = "0xD68600", VA = "0x180D6A000")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7B492D0", Offset = "0x7B478D0", VA = "0x187B492D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B3DE30", Offset = "0x7B3C430", VA = "0x187B3DE30")]
		public LODSettings KONJMPOGADM(OEDNPOAFIDC GKGMDAMJCNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DE10", Offset = "0x7B3C410", VA = "0x187B3DE10")]
		public int GKKACPGAMFO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DD70", Offset = "0x7B3C370", VA = "0x187B3DD70")]
		public int GIIKKLLOIII(bool FCDPHFEDDIM, Vector3 PJHHBAKEOKM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DE40", Offset = "0x7B3C440", VA = "0x187B3DE40")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JJAGBJFEEGG
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
public interface DCJLPKNHAKK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LODKFBECFEI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FENFNPEPKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int POGAGMINKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<DKKEIIEJNPK> EEJCBGEEIAB
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
	void UpdateClusterDistances(Vector3 HNHGJPFCFDL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(KCALEPNMMPK HABFEKNHDFB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DKKEIIEJNPK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int OBBFBAJIIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int LNJGAKGJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float EBNNJCOJCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JBJNBMCEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte ADEMLIENNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AHMBCDCKHJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PHAHBKGNIBC
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
	private struct MEAJDHIHNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AHMBCDCKHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A740", Offset = "0x7B48D40", VA = "0x187B4A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AED0", Offset = "0x7B494D0", VA = "0x187B4AED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LIOPMOPOHFI : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AHMBCDCKHJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public LIOPMOPOHFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B47A80", Offset = "0x7B46080", VA = "0x187B47A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B47BB0", Offset = "0x7B461B0", VA = "0x187B47BB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PJFLHEFAAMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AHMBCDCKHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LDCGKGNFMMI<string>.CKHHEKIPJDF worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private LDCGKGNFMMI<string>.CKHHEKIPJDF <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C150", Offset = "0x7B4A750", VA = "0x187B4C150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D9B0", Offset = "0x7B4BFB0", VA = "0x187B4D9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MIFHBLKAACC : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AHMBCDCKHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public MIFHBLKAACC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AF30", Offset = "0x7B49530", VA = "0x187B4AF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BC20", Offset = "0x7B4A220", VA = "0x187B4BC20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int IJOLJMFAMOM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan JNEABMHDFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer BNGPNAHFDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter IBPDICACCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject IBBLJOAMFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject GDEHEOMFEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LFNFLIHNPEA DGOELIBCMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<KCALEPNMMPK> OKMJFCPFHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<KCALEPNMMPK> MMMBKFHMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<KCALEPNMMPK> DHODFOAHPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DEHGOLACCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private PHAHBKGNIBC NIMFAHKJLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<FENFNPEPKPP>[] CCOCFKLIHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<DKKEIIEJNPK>[] ILPFHICOJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource KBKHNENALFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool BGELLMEKFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OLILOOIADED BJMJHPNCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OLILOOIADED JMJKJOGGJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int DGPLPNBFGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static AHMBCDCKHJC KCIKNNAECHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ICGMFMAMKPO HDKGIBBLLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LGDAJFEPOPI GHFMEEDMKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour BFGOHCOLCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material MDBHNIKFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> CPANPPJDDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material EJHBDIPILKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> GEEPLFIFKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool HMCOHOJKELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<DCJLPKNHAKK> EKJGMGBELNL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig FMEEPCKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 IIDBBJGOGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2430", Offset = "0x1DC0A30", VA = "0x181DC2430")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2340", Offset = "0x1DC0940", VA = "0x181DC2340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PHAHBKGNIBC FINEDPMJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF476A0", Offset = "0xF45CA0", VA = "0x180F476A0")]
		get
		{
			return default(PHAHBKGNIBC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B280", Offset = "0x7B39880", VA = "0x187B3B280")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AHMBCDCKHJC MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B39240", Offset = "0x7B37840", VA = "0x187B39240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool LEGBMJHBBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B38860", Offset = "0x7B36E60", VA = "0x187B38860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MFICCFNMLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A390", Offset = "0x7B38990", VA = "0x187B3A390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> JHJGDHMGHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B39DD0", Offset = "0x7B383D0", VA = "0x187B39DD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B38510", Offset = "0x7B36B10", VA = "0x187B38510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OBODIEBHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A450", Offset = "0x7B38A50", VA = "0x187B3A450")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B38F10", Offset = "0x7B37510", VA = "0x187B38F10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B420", Offset = "0x7B39A20", VA = "0x187B3B420")]
	public AHMBCDCKHJC(ICGMFMAMKPO HDKGIBBLLFE, LGDAJFEPOPI GHFMEEDMKPK, ClusterLODConfig ILLKGCHFGII, MonoBehaviour BFGOHCOLCGD, Material FGCDNLMOLPC, ClusterMeshRenderer BNGPNAHFDMJ, MeshFilter IBPDICACCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B385D0", Offset = "0x7B36BD0", VA = "0x187B385D0")]
	private void DAJCKPAEHDN(Material FGCDNLMOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A500", Offset = "0x7B38B00", VA = "0x187B3A500")]
	public void NFCFLLEGCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B390C0", Offset = "0x7B376C0", VA = "0x187B390C0")]
	public static OFNFOCEBPOF.LEBCKMKDBPC FHBDEABMCGM(OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
	{
		return default(OFNFOCEBPOF.LEBCKMKDBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B38B00", Offset = "0x7B37100", VA = "0x187B38B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B39EF0", Offset = "0x7B384F0", VA = "0x187B39EF0")]
	public static void KBHPHNDHLDK(Vector3 ACMDNPFOIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A300", Offset = "0x7B38900", VA = "0x187B3A300")]
	private void LHLMLBOJEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B39D00", Offset = "0x7B38300", VA = "0x187B39D00")]
	private void IOJJHADLNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B389B0", Offset = "0x7B36FB0", VA = "0x187B389B0")]
	private void DNKEAFFLKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A8B0", Offset = "0x7B38EB0", VA = "0x187B3A8B0")]
	public void PCGHEFJGOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A1E0", Offset = "0x7B387E0", VA = "0x187B3A1E0")]
	[AsyncStateMachine(typeof(MEAJDHIHNOG))]
	public Task LEBBAFCOKHB(LDCGKGNFMMI<string>.CKHHEKIPJDF ACALEJNPDEL, CancellationToken EBOFCHGLLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AF00", Offset = "0x7B39500", VA = "0x187B3AF00")]
	[IteratorStateMachine(typeof(LIOPMOPOHFI))]
	private IEnumerator<NFNODNEANBN> PDCABNGHADN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B38740", Offset = "0x7B36D40", VA = "0x187B38740")]
	[AsyncStateMachine(typeof(PJFLHEFAAMK))]
	private Task DBCALKLONLH(LDCGKGNFMMI<string>.CKHHEKIPJDF NIOHNIFLCJC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A630", Offset = "0x7B38C30", VA = "0x187B3A630")]
	public void OHFFEGKMNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B38FC0", Offset = "0x7B375C0", VA = "0x187B38FC0")]
	public void FCHCKIPIDAF(IEnumerable<FENFNPEPKPP> EBNNMKDIBGF, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AF80", Offset = "0x7B39580", VA = "0x187B3AF80")]
	public void PMOFOLFLBCO(IEnumerable<FENFNPEPKPP> EBNNMKDIBGF, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B39480", Offset = "0x7B37A80", VA = "0x187B39480")]
	public List<ClusterMeshRenderer> HDBLCJLDKOB(List<KCALEPNMMPK> JLLEALKGJHH, CIPJGNAKHIH KNNDNAPJIDP, JJAGBJFEEGG JGGBDGJFMCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B39CA0", Offset = "0x7B382A0", VA = "0x187B39CA0")]
	public void IIHOGLPNNCP(DCJLPKNHAKK GNDPKHNHGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B38950", Offset = "0x7B36F50", VA = "0x187B38950")]
	public bool DIPGMEPPHMF(DCJLPKNHAKK GNDPKHNHGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B39E90", Offset = "0x7B38490", VA = "0x187B39E90")]
	public void KAPFENMABJM(KCALEPNMMPK IPBOKACAHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B380C0", Offset = "0x7B366C0", VA = "0x187B380C0")]
	public void BMDCOLIIMBN(DKKEIIEJNPK LBGDJDBPBBD, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B39040", Offset = "0x7B37640", VA = "0x187B39040")]
	public void FDFMOJHGFCM(DKKEIIEJNPK LBGDJDBPBBD, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B39B60", Offset = "0x7B38160", VA = "0x187B39B60")]
	private void HDDDMBAPOMP(Vector3 HNHGJPFCFDL, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B390E0", Offset = "0x7B376E0", VA = "0x187B390E0")]
	private void FIEONLLKOHM(Vector3 HNHGJPFCFDL, JJAGBJFEEGG JGGBDGJFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A830", Offset = "0x7B38E30", VA = "0x187B3A830")]
	[IteratorStateMachine(typeof(MIFHBLKAACC))]
	private IEnumerator<NFNODNEANBN> OMANKPGILJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A070", Offset = "0x7B38670", VA = "0x187B3A070")]
	private int LABBJDBBHJO(int OHHMJGCBCKD, int EHEMJJIGCEJ, List<DKKEIIEJNPK> BBNJGMJMDKL, byte GKGMDAMJCNF, int MKBKKNIHMFP, float HKKMLGJLPBC = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B392D0", Offset = "0x7B378D0", VA = "0x187B392D0")]
	public void GNAALOCCJEL(KCALEPNMMPK HABFEKNHDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B38ED0", Offset = "0x7B374D0", VA = "0x187B38ED0")]
	public bool EGKGDCKHKAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xCC11E0", Offset = "0xCBF7E0", VA = "0x180CC11E0")]
	public Material KFCBNIPPDCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B39FE0", Offset = "0x7B385E0", VA = "0x187B39FE0")]
	public Material KFCBNIPPDCB(OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x9F64B0", Offset = "0x9F4AB0", VA = "0x1809F64B0")]
	public Material NGKDBMFOJLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A5A0", Offset = "0x7B38BA0", VA = "0x187B3A5A0")]
	public Material NGKDBMFOJLI(OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B39290", Offset = "0x7B37890", VA = "0x187B39290")]
	public int GKKACPGAMFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B38140", Offset = "0x7B36740", VA = "0x187B38140")]
	public (long, int) CKCICKDAKDC()
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
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GLMJJLOPEMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> COEAFKGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> IABDNJIKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> GNBJGLIKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> LGPLODMABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> HKHJDBHLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> IFBAGJEGFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 FKMIKFFIDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float PHLMBDOACDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> AOFIPJLEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> LELAMLENGEH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B429C0", Offset = "0x7B40FC0", VA = "0x187B429C0")]
	public GLMJJLOPEMO(OFNFOCEBPOF PEPFHNJFNIL, NativeList<float3> IFBAGJEGFNB, NativeParallelMultiHashMap<int, int> AOFIPJLEGOK, NativeArray<int> LELAMLENGEH, Vector3 FKMIKFFIDPJ, float PHLMBDOACDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B426F0", Offset = "0x7B40CF0", VA = "0x187B426F0")]
	private int IGBCDELIGDK(float3 HNHGJPFCFDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B42750", Offset = "0x7B40D50", VA = "0x187B42750")]
	private int IHELGOJDOCE(int DEBKJNNAPAB, int OEHHKNIGGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B422C0", Offset = "0x7B408C0", VA = "0x187B422C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PBGOLHHIIMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> AOFIPJLEGOK;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> LELAMLENGEH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int ICBCBEKDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> DEAFNFBMAKN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BF60", Offset = "0x7B4A560", VA = "0x187B4BF60")]
	public void KIBJNNMKGPB(int FNBPJBGCLCH, Allocator NDFENJBGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BE80", Offset = "0x7B4A480", VA = "0x187B4BE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PBGOLHHIIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct FOHHGGPIKDB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> LPLJFEEALKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> DFBBAPNMLCD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B42290", Offset = "0x7B40890", VA = "0x187B42290")]
	public FOHHGGPIKDB(PBGOLHHIIMM LNGCABBPOHI, OFNFOCEBPOF PEPFHNJFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B421E0", Offset = "0x7B407E0", VA = "0x187B421E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct IJOJEEEEBLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> HEIDAKDKJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> LAEKEEAOFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> PMKPBIIHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> DHFAOJAKFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> EEOILEIGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> DEAFNFBMAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> LPLJFEEALKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> EFGPMMFFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> HBBKAPCHPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> ENKJJFBLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> AILMOMKMFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> NBHDHKGAMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> GJNIFHIHHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float LJHBOFIJLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float BOFNOPNGKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 KIBNLFAIDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float DNINFCHAJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float BOMOPKEAMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float JPGIFEODCKP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B44D10", Offset = "0x7B43310", VA = "0x187B44D10")]
	public IJOJEEEEBLM(PBGOLHHIIMM EDOFFAMPJCN, OFNFOCEBPOF PEPFHNJFNIL, OFNFOCEBPOF GAJMCBIEMIL, float BOMOPKEAMKK, float JPGIFEODCKP, Vector3 KIBNLFAIDNK, float DNINFCHAJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B43790", Offset = "0x7B41D90", VA = "0x187B43790")]
	private float3 BKPEEOBNDAA(int DEBKJNNAPAB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B44850", Offset = "0x7B42E50", VA = "0x187B44850")]
	private void FMPEMCBGLAO(int DEBKJNNAPAB, [Out] float3 HDGKBLEEFBG, [Out] float3 LPBCOCJJOCN, [Out] float4 MOJJDGBIPAN, [Out] float4 KOAMGPBGFOK, [Out] float2 KIDBONDBGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B44A30", Offset = "0x7B43030", VA = "0x187B44A30")]
	private int JMCGPDILLEI(int ILPJJHLCFBO, int JKKBDCFBJEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B44650", Offset = "0x7B42C50", VA = "0x187B44650")]
	private void FBCGGBFCBDM(int ILPJJHLCFBO, int JKKBDCFBJEF, int PFLPIBLLFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B43900", Offset = "0x7B41F00", VA = "0x187B43900")]
	private bool CJHLENODLMN(int ILPJJHLCFBO, int JKKBDCFBJEF, float NDKAOKMAHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B43840", Offset = "0x7B41E40", VA = "0x187B43840")]
	private bool CFAJNCIALIP(int ILPJJHLCFBO, int JKKBDCFBJEF, int PFLPIBLLFOK, float NDKAOKMAHHC, bool IACNMMIJLOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B43A50", Offset = "0x7B42050", VA = "0x187B43A50")]
	private bool DAGLNADJLCO(int ILPJJHLCFBO, int JKKBDCFBJEF, int PFLPIBLLFOK, float NDKAOKMAHHC, bool IACNMMIJLOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B43CB0", Offset = "0x7B422B0", VA = "0x187B43CB0")]
	private void DDCPMBBNAAM(int ILPJJHLCFBO, int JKKBDCFBJEF, int PFLPIBLLFOK, [Out] int EIGDPOAJDFL, [Out] int JNBNEOCHBOO, [Out] int JOCPBHGMOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B43CD0", Offset = "0x7B422D0", VA = "0x187B43CD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CGHMNNMMKJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JBBHHKALGGG : IDisposable, DKKEIIEJNPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds HJOECMEGBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<KCALEPNMMPK> JLLEALKGJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 IHNFPCMCCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 BBHBKNENCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int PCFEKJPEAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public OFNFOCEBPOF FPLCOEMPHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long MDMKIAKBJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PBGOLHHIIMM KMMNGPCBEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform KNNDNAPJIDP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int EIBCDHIEFKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B45020", Offset = "0x7B43620", VA = "0x187B45020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh NDOGDAOEMPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OFNFOCEBPOF.LEBCKMKDBPC KPJPGPOCNON
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
			[CompilerGenerated]
			get
			{
				return default(OFNFOCEBPOF.LEBCKMKDBPC);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh PIMHEGMBBCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public OFNFOCEBPOF.LEBCKMKDBPC DLJBELIOBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE58DB0", Offset = "0xE573B0", VA = "0x180E58DB0")]
			[CompilerGenerated]
			get
			{
				return default(OFNFOCEBPOF.LEBCKMKDBPC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE6D7B0", Offset = "0xE6BDB0", VA = "0x180E6D7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float EBNNJCOJCIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCE0", Offset = "0x10BE2E0", VA = "0x1810BFCE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x17465B0", Offset = "0x1744BB0", VA = "0x1817465B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte ADEMLIENNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1692CF0", Offset = "0x16912F0", VA = "0x181692CF0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1692230", Offset = "0x1690830", VA = "0x181692230", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OBBFBAJIIKN
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F3D0", VA = "0x180A20DD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x131BEC0", Offset = "0x131A4C0", VA = "0x18131BEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LNJGAKGJBDB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float JBJNBMCEJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7B45000", Offset = "0x7B43600", VA = "0x187B45000", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7B45370", Offset = "0x7B43970", VA = "0x187B45370")]
		public void PLCIFIKGNDC(OEDNPOAFIDC GKGMDAMJCNF, [Out] int NPGNODKKKAD, [Out] int PCGPKCCHANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B450F0", Offset = "0x7B436F0", VA = "0x187B450F0")]
		public void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7B452C0", Offset = "0x7B438C0", VA = "0x187B452C0")]
		public void NNICCDGOJPJ(Mesh PEPFHNJFNIL, OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B45060", Offset = "0x7B43660", VA = "0x187B45060")]
		public void NCHJHEONDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B44E50", Offset = "0x7B43450", VA = "0x187B44E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B455D0", Offset = "0x7B43BD0", VA = "0x187B455D0")]
		public JBBHHKALGGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds HJOECMEGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public OFNFOCEBPOF.LEBCKMKDBPC EJKMFHAKFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<JBBHHKALGGG> ILOIBODNNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public MALGELKKBEJ KLDFPLCGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer AMICCGMJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int DNJKPGHNPOL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LAHKHJIPNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int POGAGMINKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C690", Offset = "0x7B3AC90", VA = "0x187B3C690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C510", Offset = "0x7B3AB10", VA = "0x187B3C510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B3CF70", Offset = "0x7B3B570", VA = "0x187B3CF70")]
	public int NPBABNMFEPO(int CBMFLKOADOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C320", Offset = "0x7B3A920", VA = "0x187B3C320")]
	public void BOCMNNMNCOC(IDADFCMMNPJ KJFKLHJABAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B3CFA0", Offset = "0x7B3B5A0", VA = "0x187B3CFA0")]
	public void OCMGDIHBHGJ(Transform HGJDCEPMKCC, bool OPGLEEDHEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C160", Offset = "0x7B3A760", VA = "0x187B3C160")]
	public bool BNPAEAKFDFM(bool CCNGFFPBOLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C950", Offset = "0x7B3AF50", VA = "0x187B3C950")]
	public void HJBLGKMKGPD(Transform KNNDNAPJIDP, bool OPGLEEDHEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C6E0", Offset = "0x7B3ACE0", VA = "0x187B3C6E0")]
	public bool GNAALOCCJEL(KCALEPNMMPK HABFEKNHDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D7E0", Offset = "0x7B3BDE0", VA = "0x187B3D7E0")]
	public CGHMNNMMKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LFNFLIHNPEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<CGHMNNMMKJM.JBBHHKALGGG> ENPJNEIPCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private LOCAFLJJDLL FNAKICDELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<CGHMNNMMKJM.JBBHHKALGGG> EPAONLHDKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int NDDHFEDKNLB;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B46B80", Offset = "0x7B45180", VA = "0x187B46B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B47260", Offset = "0x7B45860", VA = "0x187B47260")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B471A0", Offset = "0x7B457A0", VA = "0x187B471A0")]
	public void IIGLPCDPOEE(CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC, Transform KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B46CD0", Offset = "0x7B452D0", VA = "0x187B46CD0")]
	public void GNAALOCCJEL(CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B47630", Offset = "0x7B45C30", VA = "0x187B47630")]
	private CGHMNNMMKJM.JBBHHKALGGG PHFPBOEOCPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B47770", Offset = "0x7B45D70", VA = "0x187B47770")]
	private bool PKFLEJHOCID(CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B46EB0", Offset = "0x7B454B0", VA = "0x187B46EB0")]
	private void HALENHCGLCG(CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B47600", Offset = "0x7B45C00", VA = "0x187B47600")]
	public bool OPOHLPCCOMG(CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B46F10", Offset = "0x7B45510", VA = "0x187B46F10")]
	public bool IEKHBJGOAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B46C60", Offset = "0x7B45260", VA = "0x187B46C60")]
	private CGHMNNMMKJM.JBBHHKALGGG EGDKKMDHKNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B472E0", Offset = "0x7B458E0", VA = "0x187B472E0")]
	public long NPEMHLFIEJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B47810", Offset = "0x7B45E10", VA = "0x187B47810")]
	public LFNFLIHNPEA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class COKLLEJGFAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int FLMIHNMEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int KBEMJHAGCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float CFLCLKLMFDN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<CGHMNNMMKJM> EAOONDCHAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3DD20", Offset = "0x7B3C320", VA = "0x187B3DD20")]
	public COKLLEJGFAH(int FLMIHNMEAKI, int KBEMJHAGCNI, float JPKNMNELMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B3DA00", Offset = "0x7B3C000", VA = "0x187B3DA00")]
	public void OIOHJLCEKFC(AOLILNOPIPB HIDONCGNMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D8B0", Offset = "0x7B3BEB0", VA = "0x187B3D8B0")]
	private int CMMFDBPOBNB(IDADFCMMNPJ GOJJJBGJPAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B3DAB0", Offset = "0x7B3C0B0", VA = "0x187B3DAB0")]
	private void OIOHJLCEKFC(IDADFCMMNPJ GOJJJBGJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D960", Offset = "0x7B3BF60", VA = "0x187B3D960")]
	private void MFKBDLFIKHL(IDADFCMMNPJ GOJJJBGJPAM, CGHMNNMMKJM GJCHKFHDACN)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, FENFNPEPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HFGOIGEAHJH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
			[DebuggerHidden]
			public HFGOIGEAHJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7B42AE0", Offset = "0x7B410E0", VA = "0x187B42AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7B42CA0", Offset = "0x7B412A0", VA = "0x187B42CA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B42BF0", Offset = "0x7B411F0", VA = "0x187B42BF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7B42BF0", Offset = "0x7B411F0", VA = "0x187B42BF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int POGAGMINKMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F950", Offset = "0x7B3DF50", VA = "0x187B3F950", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<DKKEIIEJNPK> EEJCBGEEIAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F930", Offset = "0x7B3DF30", VA = "0x187B3F930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> ILOIBODNNJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CGHMNNMMKJM LNGKDJGKDLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public JJAGBJFEEGG JGLBOEIFLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(JJAGBJFEEGG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool MHOIDCBPOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC642D0", Offset = "0xC628D0", VA = "0x180C642D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DEA0", Offset = "0x7B3C4A0", VA = "0x187B3DEA0")]
		public static ClusterMeshRenderer Create(CGHMNNMMKJM PEPFHNJFNIL, ClusterMeshRenderer BNGPNAHFDMJ, MeshFilter IBPDICACCOC, CIPJGNAKHIH KNNDNAPJIDP, JJAGBJFEEGG JGGBDGJFMCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E110", Offset = "0x7B3C710", VA = "0x187B3E110", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EC00", Offset = "0x7B3D200", VA = "0x187B3EC00", Slot = "9")]
		public bool TryRemoveClusterLODComponent(KCALEPNMMPK HABFEKNHDFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E9B0", Offset = "0x7B3CFB0", VA = "0x187B3E9B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E640", Offset = "0x7B3CC40", VA = "0x187B3E640")]
		public void Init(CGHMNNMMKJM PEPFHNJFNIL, MeshFilter IBPDICACCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E170", Offset = "0x7B3C770", VA = "0x187B3E170")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B3ED30", Offset = "0x7B3D330", VA = "0x187B3ED30", Slot = "7")]
		public void UpdateClusterDistances(Vector3 HNHGJPFCFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EFE0", Offset = "0x7B3D5E0", VA = "0x187B3EFE0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E5C0", Offset = "0x7B3CBC0", VA = "0x187B3E5C0")]
		[IteratorStateMachine(typeof(HFGOIGEAHJH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EA40", Offset = "0x7B3D040", VA = "0x187B3EA40")]
		public void SetupTagAndLayer(string ALDJJJCLNOI, int JGGBDGJFMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EA20", Offset = "0x7B3D020", VA = "0x187B3EA20")]
		public bool Remove(KCALEPNMMPK HABFEKNHDFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JGIBELFIDMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int PDEKGNANDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NGFMNKONPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PCGPKCCHANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int NPGNODKKKAD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B45A20", Offset = "0x7B44020", VA = "0x187B45A20")]
	public JGIBELFIDMH(int NGFMNKONPKM, int PCGPKCCHANN, int PDEKGNANDEB, int NPGNODKKKAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MALGELKKBEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> DEAFNFBMAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> HKHJDBHLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<JGIBELFIDMH> EKLMIMLFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> GDOGDLMLAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> JKJJJIMAMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> OOFJKFNFHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle GMNPCPDAADC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DJLLMFIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1A310", Offset = "0xA18910", VA = "0x180A1A310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA19510", Offset = "0xA17B10", VA = "0x180A19510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B49870", Offset = "0x7B47E70", VA = "0x187B49870")]
	public void EEBICEODLFH(OFNFOCEBPOF EACPFMONOCK, NativeList<JGIBELFIDMH> EKLMIMLFFCO, float HDLKNIPAJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B494D0", Offset = "0x7B47AD0", VA = "0x187B494D0")]
	public void DIBJGONGBNI(Transform KNNDNAPJIDP, bool OPGLEEDHEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B49330", Offset = "0x7B47930", VA = "0x187B49330")]
	public void BNPAEAKFDFM(CGHMNNMMKJM AMICCGMJHBK, bool CCNGFFPBOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B49760", Offset = "0x7B47D60", VA = "0x187B49760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B4A710", Offset = "0x7B48D10", VA = "0x187B4A710")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MALGELKKBEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EBJKFGJALIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> JKHPLKICGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> DEAFNFBMAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<JGIBELFIDMH> DOCMCMDGHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> GDOGDLMLAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 KIBNLFAIDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> JKJJJIMAMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> OOFJKFNFHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool OPGLEEDHEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float LPACIGHBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float OBDILMKHBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float HAOAFHPEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> HKHJDBHLOPP;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B3FEB0", Offset = "0x7B3E4B0", VA = "0x187B3FEB0")]
	public EBJKFGJALIC(MALGELKKBEJ JNKEAKNDOMN, Vector3 KIBNLFAIDNK, bool OPGLEEDHEDA, float LPACIGHBNNH, float OBDILMKHBEH, float HAOAFHPEFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F9B0", Offset = "0x7B3DFB0", VA = "0x187B3F9B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KCALEPNMMPK : NGPLIHHOGDL
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds NIEGJEKJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IDADFCMMNPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<KCALEPNMMPK> JLLEALKGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public IDADFCMMNPJ JHDAOHEONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public IDADFCMMNPJ NDCJGCJLHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public IDADFCMMNPJ IPBDIMJEFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int NPGNODKKKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds HJOECMEGBKL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B42CF0", Offset = "0x7B412F0", VA = "0x187B42CF0")]
	public IDADFCMMNPJ(List<KCALEPNMMPK> JLLEALKGJHH, [Optional] IDADFCMMNPJ JHDAOHEONAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AOLILNOPIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<IDADFCMMNPJ> NENAGJIONNO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IDADFCMMNPJ FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B3BBA0", Offset = "0x7B3A1A0", VA = "0x187B3BBA0")]
	public AOLILNOPIPB(IDADFCMMNPJ KNNDNAPJIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FCGNEEHFINJ
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct ONPEPFBCECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int OIIMMKAMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int LKIKMENMDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DHAICGOFOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int OKDMDGDLKMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GNHACIDEAOK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int OIPEMNHFDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float KIIJPMFDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<KCALEPNMMPK> JLLEALKGJHH;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B42A80", Offset = "0x7B41080", VA = "0x187B42A80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MFICCNEFHGD
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
	private ONPEPFBCECM GKICDPOEBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int HDBBDDJGDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int FLMIHNMEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int KBEMJHAGCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float JPKNMNELMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float GGENAKJKBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<IDADFCMMNPJ> IALEKJEJHIA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AOLILNOPIPB ALIEIPGJECN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B42180", Offset = "0x7B40780", VA = "0x187B42180")]
	public FCGNEEHFINJ(int FLMIHNMEAKI, int KBEMJHAGCNI, float JPKNMNELMAJ, int HDBBDDJGDGO, float GGENAKJKBFF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B404A0", Offset = "0x7B3EAA0", VA = "0x187B404A0")]
	public void EODMKDHNCIG(List<KCALEPNMMPK> JLLEALKGJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B40670", Offset = "0x7B3EC70", VA = "0x187B40670")]
	public bool FBECDMPFFDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B410C0", Offset = "0x7B3F6C0", VA = "0x187B410C0")]
	private float LHMCAHMBPBM(Vector3 COJGDIKBGKB, Vector3 JNIBMOMFMLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B41110", Offset = "0x7B3F710", VA = "0x187B41110")]
	private float LHMCAHMBPBM(Vector3 CFNMLMNHCMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B406E0", Offset = "0x7B3ECE0", VA = "0x187B406E0")]
	private bool FGFPCPEELBP(IDADFCMMNPJ OJHHPGEKOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B41130", Offset = "0x7B3F730", VA = "0x187B41130")]
	private GNHACIDEAOK MFDBAGEJKBO(List<KCALEPNMMPK> EDKKAIMFGIH, MFICCNEFHGD FIFJOOIEEIG)
	{
		return default(GNHACIDEAOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B400E0", Offset = "0x7B3E6E0", VA = "0x187B400E0")]
	private void CMMKFHPOJJF(List<KCALEPNMMPK> JLLEALKGJHH, NativeArray<Vector3> IEGIKGHPJDL, NativeArray<Vector3> FBDBEJCEKGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IEOMCMLJELK
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B42D70", Offset = "0x7B41370", VA = "0x187B42D70")]
	public static Bounds CFHOBPPLJFO(List<KCALEPNMMPK> JLLEALKGJHH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B42F40", Offset = "0x7B41540", VA = "0x187B42F40")]
	public static int LPKLAPIICAF(List<KCALEPNMMPK> JLLEALKGJHH, OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class MIFJPGMIIDA
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool EPJOELPAJED(float4* LGPLODMABGM, int DDGBDMFPMAI);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class BGPJNKMKKKE
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr CCNGCCIKPEH;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr LLOMPIOHPNP;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BEF0", Offset = "0x7B3A4F0", VA = "0x187B3BEF0")]
		[BurstDiscard]
		private static void KMJNLDJAHMC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C010", Offset = "0x7B3A610", VA = "0x187B3C010")]
		private static IntPtr LBCDMPBNDKP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BE50", Offset = "0x7B3A450", VA = "0x187B3BE50")]
		public static void JDBOBDBNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BC70", Offset = "0x7B3A270", VA = "0x187B3BC70")]
		public unsafe static bool CIBKKMOJDEC(float4* LGPLODMABGM, int DDGBDMFPMAI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BC70", Offset = "0x7B4A270", VA = "0x187B4BC70")]
	[BurstCompile]
	public unsafe static bool IPGGHFHAAHG(float4* LGPLODMABGM, int DDGBDMFPMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B37E20", Offset = "0x7B36420", VA = "0x187B37E20")]
	[BurstCompile]
	public unsafe static bool COGJFFHHGIP(float4* LGPLODMABGM, int DDGBDMFPMAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct JBBLHCAEFGI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> JHJMFPLBLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> HOBJGDJLFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> ADHEBJIOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> LHMIDMPAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> IDEFIPDMGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> GNBJGLIKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> CAHHKJPELBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> GAKGLFDFMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<OFNFOCEBPOF.FBAFEBCICFD> PDIDMHJKDPO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B459A0", Offset = "0x7B43FA0", VA = "0x187B459A0")]
	public JBBLHCAEFGI(OFNFOCEBPOF JEMPAODLPBM, NativeArray<bool> CAHHKJPELBC, NativeList<ushort> GAKGLFDFMPF, NativeList<OFNFOCEBPOF.FBAFEBCICFD> PDIDMHJKDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7B456F0", Offset = "0x7B43CF0", VA = "0x187B456F0", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct IFABNDGNBAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> JHJMFPLBLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> HOBJGDJLFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> ADHEBJIOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> LHMIDMPAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> IDEFIPDMGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> GNBJGLIKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> CCPIANLDNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> FCFOPNIGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> AFHMNMHIEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> JINDAAKHEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> LLGPAKMEPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> JICLJHOANED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> CAHHKJPELBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> GAKGLFDFMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<OFNFOCEBPOF.FBAFEBCICFD> PDIDMHJKDPO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7B435E0", Offset = "0x7B41BE0", VA = "0x187B435E0")]
	public IFABNDGNBAE(OFNFOCEBPOF JEMPAODLPBM, OFNFOCEBPOF EFEAMMBJOKF, NativeArray<bool> CAHHKJPELBC, NativeList<ushort> GAKGLFDFMPF, NativeList<OFNFOCEBPOF.FBAFEBCICFD> PDIDMHJKDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B43110", Offset = "0x7B41710", VA = "0x187B43110", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LOCAFLJJDLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private OFNFOCEBPOF IFMOCJIAEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private OFNFOCEBPOF JEMPAODLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> PJNODFDFIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> GAKGLFDFMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<OFNFOCEBPOF.FBAFEBCICFD> PDIDMHJKDPO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static OFNFOCEBPOF JEFOJLGLHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private KCFHOMPPIJH JJJNFMILJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private OGPFNIIHPFO KEIICMNLBCF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle GMNPCPDAADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CGHMNNMMKJM.JBBHHKALGGG OJHHPGEKOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HFIGNODBLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x236AB60", Offset = "0x2369160", VA = "0x18236AB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7B490F0", Offset = "0x7B476F0", VA = "0x187B490F0")]
	[FELFDMPPKKE(MGEKOJDDIFB.EnteredEditMode, 0)]
	private static void MJIOLCGKPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B47CD0", Offset = "0x7B462D0", VA = "0x187B47CD0")]
	public void EEBICEODLFH(CGHMNNMMKJM.JBBHHKALGGG DOCMCMDGHKO, Transform DKBHBJAHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7B487F0", Offset = "0x7B46DF0", VA = "0x187B487F0")]
	public void IDAIEDDNLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B47C00", Offset = "0x7B46200", VA = "0x187B47C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B490B0", Offset = "0x7B476B0", VA = "0x187B490B0")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B49160", Offset = "0x7B47760", VA = "0x187B49160")]
	public LOCAFLJJDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LGDAJFEPOPI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 ALECKHJDOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ICGMFMAMKPO
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(LDCGKGNFMMI<string>.CKHHEKIPJDF NIOHNIFLCJC, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface BDJODDJALBB
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BDJODDJALBB BJEKMHEDPFL(Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BDJODDJALBB NJCJIMLGFCF(Action BDCLNIJAFBF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class POENKNJBEGL : BDJODDJALBB
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class IFAIDMGIMNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public POENKNJBEGL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
				public IFAIDMGIMNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7B43740", Offset = "0x7B41D40", VA = "0x187B43740")]
				internal void OKNAKMDFPMF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x7B436F0", Offset = "0x7B41CF0", VA = "0x187B436F0")]
				internal void DFBECEDJHLP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x7B436A0", Offset = "0x7B41CA0", VA = "0x187B436A0")]
				internal void APPLAPKLJIO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> LADNJNFKOHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action LFJCIJAAOOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action ADBBJLOCANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private PGDONJPOFPG OAEPMCMMFJO;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action NHDOCDHAADD
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action OAOPAAMENCG
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x27275D0", Offset = "0x2725BD0", VA = "0x1827275D0", Slot = "4")]
			public BDJODDJALBB BJEKMHEDPFL(Action BDCLNIJAFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x74D3250", Offset = "0x74D1850", VA = "0x1874D3250", Slot = "5")]
			public BDJODDJALBB NJCJIMLGFCF(Action BDCLNIJAFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
			public POENKNJBEGL(Func<JobHandle> LJFEHDIPKLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DA10", Offset = "0x7B4C010", VA = "0x187B4DA10")]
			public void GDMALPFODEM(Action CKBPCGEAECK, Action AIAFJFGBKGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DCD0", Offset = "0x7B4C2D0", VA = "0x187B4DCD0")]
			public void GNAALOCCJEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class JDAJMOALHHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public BDJODDJALBB jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JDAJMOALHHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7B45A10", Offset = "0x7B44010", VA = "0x187B45A10")]
			internal bool CPDLCIPOCLJ(POENKNJBEGL a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class EDLFDIGLJDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public POENKNJBEGL newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EDLFDIGLJDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7B3FF80", Offset = "0x7B3E580", VA = "0x187B3FF80")]
			internal void DAAJJJMHFDJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<POENKNJBEGL> GIHHKCEFDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<POENKNJBEGL> JFFFDKEKCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private OLILOOIADED OHNGLEMEDOK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public CAPDDJBOHGK FOMOMFPOJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B45A40", Offset = "0x7B44040", VA = "0x187B45A40")]
		public BDJODDJALBB Add(Func<JobHandle> LJFEHDIPKLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D70", Offset = "0x7B44370", VA = "0x187B45D70")]
		public void Remove(BDJODDJALBB GMNPCPDAADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7B45BA0", Offset = "0x7B441A0", VA = "0x187B45BA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F50", Offset = "0x7B44550", VA = "0x187B45F50")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B461B0", Offset = "0x7B447B0", VA = "0x187B461B0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B45B90", Offset = "0x7B44190", VA = "0x187B45B90")]
		[CompilerGenerated]
		private void ILMAFLFEOKC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PGDONJPOFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGDONJPOFPG BJEKMHEDPFL(Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGDONJPOFPG AGCBPOCIKLA(Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PGDONJPOFPG NJCJIMLGFCF(Action BDCLNIJAFBF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, FHBMACKKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class ACIGPGFNPIP : PGDONJPOFPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle GNOIAPNACAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action LFJCIJAAOOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action AJBEMMOIIJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action OAOPAAMENCG;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MFDNMEOBGFE
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7B38060", Offset = "0x7B36660", VA = "0x187B38060")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x72D5350", Offset = "0x72D3950", VA = "0x1872D5350", Slot = "4")]
			public PGDONJPOFPG BJEKMHEDPFL(Action BDCLNIJAFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x72D5330", Offset = "0x72D3930", VA = "0x1872D5330", Slot = "5")]
			public PGDONJPOFPG AGCBPOCIKLA(Action BDCLNIJAFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x74D3250", Offset = "0x74D1850", VA = "0x1874D3250", Slot = "6")]
			public PGDONJPOFPG NJCJIMLGFCF(Action BDCLNIJAFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xF6A3B0", Offset = "0xF689B0", VA = "0x180F6A3B0")]
			public ACIGPGFNPIP(JobHandle GNOIMFPCCBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7B38070", Offset = "0x7B36670", VA = "0x187B38070")]
			public void MCMIEJOHGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7B38010", Offset = "0x7B36610", VA = "0x187B38010")]
			public void GNAALOCCJEL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<ACIGPGFNPIP> INPJKEJDPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> BDGKGAHIFFC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7B46790", Offset = "0x7B44D90", VA = "0x187B46790")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x13FD3E0", Offset = "0x13FB9E0", VA = "0x1813FD3E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B46290", Offset = "0x7B44890", VA = "0x187B46290")]
		public PGDONJPOFPG Add(JobHandle GNOIMFPCCBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B469A0", Offset = "0x7B44FA0", VA = "0x187B469A0")]
		public void Remove(PGDONJPOFPG GMNPCPDAADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B465B0", Offset = "0x7B44BB0", VA = "0x187B465B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B46400", Offset = "0x7B44A00", VA = "0x187B46400", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B46330", Offset = "0x7B44930", VA = "0x187B46330")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B46AA0", Offset = "0x7B450A0", VA = "0x187B46AA0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA17AF0", Offset = "0xA160F0", VA = "0x180A17AF0", Slot = "6")]
		private bool OAGFDLFCCPO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7B4DE60", Offset = "0x7B4C460", VA = "0x187B4DE60")]
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
