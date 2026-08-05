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
				[Cpp2IlInjected.Address(RVA = "0x447A9F0", Offset = "0x44799F0", VA = "0x18447A9F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x10A0C40", Offset = "0x109FC40", VA = "0x1810A0C40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x447A9B0", Offset = "0x44799B0", VA = "0x18447A9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x446D9F0", Offset = "0x446C9F0", VA = "0x18446D9F0")]
		public LODSettings NGDCKDOOPBJ(BENKDIMFFKF FLHLJFAEENP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x446D8D0", Offset = "0x446C8D0", VA = "0x18446D8D0")]
		public int EEKDFFGNLEL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x446D8F0", Offset = "0x446C8F0", VA = "0x18446D8F0")]
		public int ILLBALCHMPJ(bool HNLGLLEIPOM, Vector3 JNACGFLCPAJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x446DA00", Offset = "0x446CA00", VA = "0x18446DA00")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AMDCEADOAAJ
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
public interface HCFBEKINFHN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMJGLJLMPAK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JODCBCAFFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OEBPOFOGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<OBGNDBPLBFB> PEOENIKPELL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AMDCEADOAAJ MKKLCMLPKOL
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
	void UpdateClusterDistances(Vector3 KJHJJGHKJOC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(IBDGAHOKAMA IMENKKCALAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OBGNDBPLBFB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int OIFPMDJALMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int BPENOCFDANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LEEGGNFLEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CELBOCEOABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte NKNCFOHMHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DCKIBDJOFCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NEBILGEEIBE
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
	private struct HLHPEIABJJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DCKIBDJOFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public ECKKNIKHLKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private ECKKNIKHLKB <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4474820", Offset = "0x4473820", VA = "0x184474820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NKFFADPENCK : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DCKIBDJOFCL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public NKFFADPENCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x447C390", Offset = "0x447B390", VA = "0x18447C390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x447C450", Offset = "0x447B450", VA = "0x18447C450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PHONEMCHONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DCKIBDJOFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public ECKKNIKHLKB worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private ECKKNIKHLKB <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x447E330", Offset = "0x447D330", VA = "0x18447E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KCLAEIBNBJM : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DCKIBDJOFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public KCLAEIBNBJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x44782D0", Offset = "0x44772D0", VA = "0x1844782D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x44791B0", Offset = "0x44781B0", VA = "0x1844791B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FKBFMGEOJGC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan KBOAFFBEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer FECPNPIFNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter EFAPFLCNPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DBNJBFEDIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject MMGBOAJDKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EFCOGLDHJPM LFPMFKOJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IBDGAHOKAMA> FJFFLHLKIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IBDGAHOKAMA> NNCIBHMNBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<IBDGAHOKAMA> FNFPPGILEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int ACDEONPNEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NEBILGEEIBE OBEFDINALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<JODCBCAFFLF>[] CGKDHAMEKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<OBGNDBPLBFB>[] CLJDDAFKBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource JFFBMBNLPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool OHLDNDKCJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private DMIEKLLPPEA LLLAPHODMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DMIEKLLPPEA MADKNAEDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int OJODMOIPOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int LAOCNJKFIME;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static DCKIBDJOFCL AOOGANDJKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MFMAAOIMBIP NDGLPHLKFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EEPMPAEONBD ENCNNBCPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MonoBehaviour CMFDNFAMJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Material GIGEHLCFPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<HCFBEKINFHN> DAMLMJILOOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig MKCPEALNAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 FOBMDGDFJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xFBA120", Offset = "0xFB9120", VA = "0x180FBA120")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFBA040", Offset = "0xFB9040", VA = "0x180FBA040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private NEBILGEEIBE ILCKKILBPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59FCD0", Offset = "0x59ECD0", VA = "0x18059FCD0")]
		get
		{
			return default(NEBILGEEIBE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x446F540", Offset = "0x446E540", VA = "0x18446F540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DCKIBDJOFCL LOBJDNDFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x44710D0", Offset = "0x44700D0", VA = "0x1844710D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HPCBIMDMPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4471440", Offset = "0x4470440", VA = "0x184471440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool PMBHOKBOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x446EF10", Offset = "0x446DF10", VA = "0x18446EF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NFBCPNLMHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x446F8F0", Offset = "0x446E8F0", VA = "0x18446F8F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44716A0", Offset = "0x44706A0", VA = "0x1844716A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BELCHIMOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x446FD10", Offset = "0x446ED10", VA = "0x18446FD10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4470EF0", Offset = "0x446FEF0", VA = "0x184470EF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4471820", Offset = "0x4470820", VA = "0x184471820")]
	public DCKIBDJOFCL(MFMAAOIMBIP NDGLPHLKFPF, EEPMPAEONBD ENCNNBCPPHI, ClusterLODConfig IBHHGNEPLHK, MonoBehaviour CMFDNFAMJOG, Material GIGEHLCFPOA, ClusterMeshRenderer FECPNPIFNCO, MeshFilter EFAPFLCNPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x446FB80", Offset = "0x446EB80", VA = "0x18446FB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4470760", Offset = "0x446F760", VA = "0x184470760")]
	public static void IGFACIMHLLP(Vector3 CJOACAAFFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x446FC80", Offset = "0x446EC80", VA = "0x18446FC80")]
	private void EAMLAGDAEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4470A50", Offset = "0x446FA50", VA = "0x184470A50")]
	private void JEPGIPDJFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4471560", Offset = "0x4470560", VA = "0x184471560")]
	private void PDBGEOOEDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x446F050", Offset = "0x446E050", VA = "0x18446F050")]
	public void BBGPIGALPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x446FA40", Offset = "0x446EA40", VA = "0x18446FA40")]
	[AsyncStateMachine(typeof(HLHPEIABJJJ))]
	public Task DOPKENHJLKC(ECKKNIKHLKB JEKLJDDCDKJ, CancellationToken PJNALPBJAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x446F9D0", Offset = "0x446E9D0", VA = "0x18446F9D0")]
	[IteratorStateMachine(typeof(NKFFADPENCK))]
	private IEnumerator<CNHILGIAPIF> DNGHPGGOENF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4470F90", Offset = "0x446FF90", VA = "0x184470F90")]
	[AsyncStateMachine(typeof(PHONEMCHONA))]
	private Task NBDLJAIHDPD(ECKKNIKHLKB HPEGEBJKIBG, CancellationToken DBKPHPKFAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x446F660", Offset = "0x446E660", VA = "0x18446F660")]
	public void CHCLBHDFPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4470E70", Offset = "0x446FE70", VA = "0x184470E70")]
	public void LAKIGODPENL(IEnumerable<JODCBCAFFLF> CNOMPILIJND, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4471190", Offset = "0x4470190", VA = "0x184471190")]
	public void OOFOFEAKOMF(IEnumerable<JODCBCAFFLF> CNOMPILIJND, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x446FDF0", Offset = "0x446EDF0", VA = "0x18446FDF0")]
	public List<ClusterMeshRenderer> GNAGBEHKGHM(List<IBDGAHOKAMA> GMMAGLNOFNP, Transform EIIIPMJKAPH, AMDCEADOAAJ MPIANHPEDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4470720", Offset = "0x446F720", VA = "0x184470720")]
	public AMDCEADOAAJ ICJANOIOCHH(Vector3 AJIMHAIJJOG)
	{
		return default(AMDCEADOAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x446EFF0", Offset = "0x446DFF0", VA = "0x18446EFF0")]
	public void APMEOLECEHD(HCFBEKINFHN BMMLNHAHIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x446EE50", Offset = "0x446DE50", VA = "0x18446EE50")]
	public bool ACEBBOFNANL(HCFBEKINFHN BMMLNHAHIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x446EEB0", Offset = "0x446DEB0", VA = "0x18446EEB0")]
	public void ADOICMOKAHL(IBDGAHOKAMA BKCJDNDJBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x446F870", Offset = "0x446E870", VA = "0x18446F870")]
	public void CMFMKJDEHAA(OBGNDBPLBFB JIFANPJIKMK, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4470C80", Offset = "0x446FC80", VA = "0x184470C80")]
	public void KENHJIMCDAP(OBGNDBPLBFB JIFANPJIKMK, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4470B50", Offset = "0x446FB50", VA = "0x184470B50")]
	private void KAKCHAIECDN(Vector3 KJHJJGHKJOC, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4470D00", Offset = "0x446FD00", VA = "0x184470D00")]
	private void KKLNNFDAGEK(Vector3 KJHJJGHKJOC, AMDCEADOAAJ MPIANHPEDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4471740", Offset = "0x4470740", VA = "0x184471740")]
	[IteratorStateMachine(typeof(KCLAEIBNBJM))]
	private IEnumerator<CNHILGIAPIF> POGKKCDBLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x44705B0", Offset = "0x446F5B0", VA = "0x1844705B0")]
	private int GOMMLHMLDON(int FBOCJCCNMND, int FPEIGMFKAMH, List<OBGNDBPLBFB> FCFDLGOCNAP, byte FLHLJFAEENP, ref int CDOAMPMEHKP, float KEMCDFDFNMJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4470880", Offset = "0x446F880", VA = "0x184470880")]
	public void INAIIIEHGLD(IBDGAHOKAMA IMENKKCALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x446F990", Offset = "0x446E990", VA = "0x18446F990")]
	public bool DFLILBEBIDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x617AA0", Offset = "0x616AA0", VA = "0x180617AA0")]
	public Material EPAAPCCHDEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x446FDB0", Offset = "0x446EDB0", VA = "0x18446FDB0")]
	public int EEKDFFGNLEL()
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
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct LEMGKEDDDID : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<float3> DAHEFMNOPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float3> FAPAOIFMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> OFIHNFFDILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float2> KLHNNEOOGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float4> IGAOKGCAMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<int> MNLAPJOECFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeList<float3> IJNHNPOFCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float3 HNPOCOEOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private float IKPGCBDOBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeMultiHashMap<int, int> IEBBODJILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeArray<int> PPLNCNFIMCG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x447A840", Offset = "0x4479840", VA = "0x18447A840")]
	public LEMGKEDDDID(DPOMDMFCDCE OJDMKGILEJO, NativeList<float3> IJNHNPOFCPL, NativeMultiHashMap<int, int> IEBBODJILBF, NativeArray<int> PPLNCNFIMCG, Vector3 HNPOCOEOLKI, float IKPGCBDOBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x447A540", Offset = "0x4479540", VA = "0x18447A540")]
	private int GDOMPPPACJA(float3 KJHJJGHKJOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x447A5A0", Offset = "0x44795A0", VA = "0x18447A5A0")]
	private int LOICOLMDLIM(int BHFIJCEBIFE, int DDFHJDPPNBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x447A150", Offset = "0x4479150", VA = "0x18447A150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NNGIDAHKCLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeMultiHashMap<int, int> IEBBODJILBF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static NativeArray<int> PPLNCNFIMCG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static int OFHGOLBPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeList<int> NPGEGAJCGEJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x447C4A0", Offset = "0x447B4A0", VA = "0x18447C4A0")]
	public void DDPMALFBLDF(int KONJKMFAHHE, Allocator JLCPCAMJPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x447C640", Offset = "0x447B640", VA = "0x18447C640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public NNGIDAHKCLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EKJPPJKEMIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	public NativeList<int> DCHDLAJLBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeList<int> PDOPCPKEHDM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4473C90", Offset = "0x4472C90", VA = "0x184473C90")]
	public EKJPPJKEMIG(NNGIDAHKCLD JFPIJDDEFMH, DPOMDMFCDCE OJDMKGILEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4473C00", Offset = "0x4472C00", VA = "0x184473C00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct NHMGHOABDIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeList<float3> JMBAAPOMCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float3> GGEMDPHKMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float4> EDNAHGDOEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float2> LPOKBHPNEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float4> PDEABCLJPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> NPGEGAJCGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<int> DCHDLAJLBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<float3> MADPPGBNPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float3> PIJGMPIJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> KDFEHHFNNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float4> NLHCNKMDGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float2> IDNEDIIAOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<int> EAJNLFCLDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	private float FIHFFKCGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public float PJJCEGMLDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float3 ACBFBODHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float NNMJKGNGIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	private float NEGNGOIOJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	public float LOOKJPAHDNB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x447C1F0", Offset = "0x447B1F0", VA = "0x18447C1F0")]
	public NHMGHOABDIN(NNGIDAHKCLD BKOLJGIMJLM, DPOMDMFCDCE OJDMKGILEJO, DPOMDMFCDCE LMBLOPOCBND, float NEGNGOIOJKG, float LOOKJPAHDNB, Vector3 ACBFBODHLCB, float NNMJKGNGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x447BF70", Offset = "0x447AF70", VA = "0x18447BF70")]
	private float3 KCFMLOFBHJF(int BHFIJCEBIFE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x447C010", Offset = "0x447B010", VA = "0x18447C010")]
	private void PEIPOEADKGL(int BHFIJCEBIFE, out float3 KEGHMONJAMO, out float3 NLAODMJKJED, out float4 FOKBAGMEKMJ, out float4 FEKKGEGAMOG, out float2 LFCFHBJLBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x447AC10", Offset = "0x4479C10", VA = "0x18447AC10")]
	private int BJBDKONHHOO(int LJPNOACIBEN, int EOGPFCPEJJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x447BD70", Offset = "0x447AD70", VA = "0x18447BD70")]
	private void FPPNHNLEBND(int LJPNOACIBEN, int EOGPFCPEJJH, int JPDCIAAFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x447B1C0", Offset = "0x447A1C0", VA = "0x18447B1C0")]
	private bool EAGMDOIEKAH(int LJPNOACIBEN, int EOGPFCPEJJH, float CAHOPAKGCIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x447BCB0", Offset = "0x447ACB0", VA = "0x18447BCB0")]
	private bool FHJADILMCOK(int LJPNOACIBEN, int EOGPFCPEJJH, int JPDCIAAFCNM, float CAHOPAKGCIM, bool KBHCFMJEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x447AF60", Offset = "0x4479F60", VA = "0x18447AF60")]
	private bool CLEFGCEBLAJ(int LJPNOACIBEN, int EOGPFCPEJJH, int JPDCIAAFCNM, float CAHOPAKGCIM, bool KBHCFMJEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x447AF40", Offset = "0x4479F40", VA = "0x18447AF40")]
	private void CEKLLLBDFMN(int LJPNOACIBEN, int EOGPFCPEJJH, int JPDCIAAFCNM, out int JCIILPKFLGM, out int LCNPOLJPEBB, out int OGIPMFMMDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x447B350", Offset = "0x447A350", VA = "0x18447B350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HMPIIHDIIKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KFBEEFKHHON : IDisposable, OBGNDBPLBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Bounds KIAFMKMBMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public List<IBDGAHOKAMA> GMMAGLNOFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 PPCJMNJJMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Vector3 CMOHAAHMCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int INOKLINCDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DPOMDMFCDCE JOLFPOGMJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NNGIDAHKCLD MOPJAPANNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Transform EIIIPMJKAPH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int LJKOPEIGOKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4479490", Offset = "0x4478490", VA = "0x184479490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh BHHDFPNOHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh DAPJPOMFFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x58D010", Offset = "0x58C010", VA = "0x18058D010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x58D020", Offset = "0x58C020", VA = "0x18058D020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LEEGGNFLEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x11E7A90", Offset = "0x11E6A90", VA = "0x1811E7A90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1F73F70", Offset = "0x1F72F70", VA = "0x181F73F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte NKNCFOHMHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DB570", VA = "0x1806DC570")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6DC700", Offset = "0x6DB700", VA = "0x1806DC700", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int OIFPMDJALMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x728500", Offset = "0x727500", VA = "0x180728500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x727B90", Offset = "0x726B90", VA = "0x180727B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int BPENOCFDANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB5BBA0", Offset = "0xB5ABA0", VA = "0x180B5BBA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xDBE170", Offset = "0xDBD170", VA = "0x180DBE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CELBOCEOABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x44794D0", Offset = "0x44784D0", VA = "0x1844794D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4479A50", Offset = "0x4478A50", VA = "0x184479A50")]
		public void PKLJPODFHAG(BENKDIMFFKF FLHLJFAEENP, out int JBMIDFOHIGH, out int ANHHMCFHLEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x44794F0", Offset = "0x44784F0", VA = "0x1844794F0")]
		public void GJEDJMDFOBN(BENKDIMFFKF FLHLJFAEENP, NFEOGOPBIPA FDGGMGFCKOF, int DILDOENLFPF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4479690", Offset = "0x4478690", VA = "0x184479690")]
		public void JPPMECJJLME(NativeList<IMNKKMKDAOC> GKCEDFKEIGL, Transform NJKPGNPGHAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x44799B0", Offset = "0x44789B0", VA = "0x1844799B0")]
		public void NGAFPJOFCCC(Mesh OJDMKGILEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4479200", Offset = "0x4478200", VA = "0x184479200")]
		public void AICHKAKGGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x44792A0", Offset = "0x44782A0", VA = "0x1844792A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4479C80", Offset = "0x4478C80", VA = "0x184479C80")]
		public KFBEEFKHHON()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Bounds KIAFMKMBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public List<KFBEEFKHHON> CLEBEOLBHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public EFKMFLCOFOB ECGEPGILMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ClusterMeshRenderer ANOBCBEPEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int MMDCPFBLLPP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh NMJCKGDOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCC0", Offset = "0x6AECC0", VA = "0x1806AFCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LJEBNLAGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77DB70", Offset = "0x77CB70", VA = "0x18077DB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x77DBF0", Offset = "0x77CBF0", VA = "0x18077DBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OEBPOFOGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4475F00", Offset = "0x4474F00", VA = "0x184475F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4475390", Offset = "0x4474390", VA = "0x184475390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44754F0", Offset = "0x44744F0", VA = "0x1844754F0")]
	public int IHAHPADAIMD(int HCMLPMEBLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4474DA0", Offset = "0x4473DA0", VA = "0x184474DA0")]
	public void AAHCEDKFJGH(KNDIMNIFNGJ HMNKLEHPGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44757A0", Offset = "0x44747A0", VA = "0x1844757A0")]
	public void KHIHJGOHEKH(Transform NJKPGNPGHAF, bool DFFKPOKFCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4475F50", Offset = "0x4474F50", VA = "0x184475F50")]
	public bool OAFMGKJOADA(bool NLNNGDKPBNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4474F30", Offset = "0x4473F30", VA = "0x184474F30")]
	public void COJCAAFOIFD(Transform EIIIPMJKAPH, bool DFFKPOKFCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4475520", Offset = "0x4474520", VA = "0x184475520")]
	public bool INAIIIEHGLD(IBDGAHOKAMA IMENKKCALAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4476100", Offset = "0x4475100", VA = "0x184476100")]
	public HMPIIHDIIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EFCOGLDHJPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Queue<HMPIIHDIIKP.KFBEEFKHHON> GALELODAEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IJEABBNEGIE DIHEKOGHAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<HMPIIHDIIKP.KFBEEFKHHON> JOKFCAIKGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int KDMNPIGJPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4471F50", Offset = "0x4470F50", VA = "0x184471F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4471E70", Offset = "0x4470E70", VA = "0x184471E70")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4472660", Offset = "0x4471660", VA = "0x184472660")]
	public void NJFAMEHLCGO(HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC, Transform EIIIPMJKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4472470", Offset = "0x4471470", VA = "0x184472470")]
	public void INAIIIEHGLD(HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4472340", Offset = "0x4471340", VA = "0x184472340")]
	private HMPIIHDIIKP.KFBEEFKHHON IGAPOCCBEBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4472250", Offset = "0x4471250", VA = "0x184472250")]
	private bool HIINPHOKPCL(HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x44722E0", Offset = "0x44712E0", VA = "0x1844722E0")]
	private void ICLBHKPBPKB(HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4472620", Offset = "0x4471620", VA = "0x184472620")]
	public bool JKHIJENLKKF(HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4471FC0", Offset = "0x4470FC0", VA = "0x184471FC0")]
	public bool FCLLPBMAPJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4471EF0", Offset = "0x4470EF0", VA = "0x184471EF0")]
	private HMPIIHDIIKP.KFBEEFKHHON DAICJAODFII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4472710", Offset = "0x4471710", VA = "0x184472710")]
	public EFCOGLDHJPM()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BNGFGONDBLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int GNLOANOJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MMDOGGMAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float IIOBHIDCNNJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<HMPIIHDIIKP> OJDHLIJPJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x446D880", Offset = "0x446C880", VA = "0x18446D880")]
	public BNGFGONDBLM(int GNLOANOJKCM, int MMDOGGMAMBK, float OPFKADEELIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x446D740", Offset = "0x446C740", VA = "0x18446D740")]
	public void MOLDBGGGBMC(LMDBOANJBPC JAKLOCPJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x446D7E0", Offset = "0x446C7E0", VA = "0x18446D7E0")]
	private int NFJPHLMMCBC(KNDIMNIFNGJ GHPMKAJMKGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x446D510", Offset = "0x446C510", VA = "0x18446D510")]
	private void MOLDBGGGBMC(KNDIMNIFNGJ GHPMKAJMKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x446D330", Offset = "0x446C330", VA = "0x18446D330")]
	private void HGFABNNEHCF(KNDIMNIFNGJ GHPMKAJMKGM, HMPIIHDIIKP JBAMHAAFFII)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, JODCBCAFFLF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NAHADGICGMB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x69D3E0", Offset = "0x69C3E0", VA = "0x18069D3E0")]
			[DebuggerHidden]
			public NAHADGICGMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x447AA10", Offset = "0x4479A10", VA = "0x18447AA10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x447ABA0", Offset = "0x4479BA0", VA = "0x18447ABA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x447AB00", Offset = "0x4479B00", VA = "0x18447AB00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x447AB00", Offset = "0x4479B00", VA = "0x18447AB00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int OEBPOFOGHDP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x446EDF0", Offset = "0x446DDF0", VA = "0x18446EDF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<OBGNDBPLBFB> PEOENIKPELL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x446EDD0", Offset = "0x446DDD0", VA = "0x18446EDD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> CLEBEOLBHPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public HMPIIHDIIKP NMJCKGDOCLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public AMDCEADOAAJ MKKLCMLPKOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x58D390", Offset = "0x58C390", VA = "0x18058D390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(AMDCEADOAAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x796580", Offset = "0x795580", VA = "0x180796580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool JJDFLAMHNBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x446EDE0", Offset = "0x446DDE0", VA = "0x18446EDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x446DA60", Offset = "0x446CA60", VA = "0x18446DA60")]
		public static ClusterMeshRenderer Create(HMPIIHDIIKP OJDMKGILEJO, ClusterMeshRenderer FECPNPIFNCO, MeshFilter EFAPFLCNPJE, Transform EIIIPMJKAPH, AMDCEADOAAJ MPIANHPEDHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x446DBC0", Offset = "0x446CBC0", VA = "0x18446DBC0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x446E340", Offset = "0x446D340", VA = "0x18446E340", Slot = "10")]
		public bool TryRemoveClusterLODComponent(IBDGAHOKAMA IMENKKCALAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x446E110", Offset = "0x446D110", VA = "0x18446E110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x446DE20", Offset = "0x446CE20", VA = "0x18446DE20")]
		public void Init(HMPIIHDIIKP OJDMKGILEJO, MeshFilter EFAPFLCNPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x446DC20", Offset = "0x446CC20", VA = "0x18446DC20")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x446E470", Offset = "0x446D470", VA = "0x18446E470", Slot = "8")]
		public void UpdateClusterDistances(Vector3 KJHJJGHKJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x446E6B0", Offset = "0x446D6B0", VA = "0x18446E6B0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x446DDB0", Offset = "0x446CDB0", VA = "0x18446DDB0")]
		[IteratorStateMachine(typeof(NAHADGICGMB))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x446E190", Offset = "0x446D190", VA = "0x18446E190")]
		public void SetupTagAndLayer(string CHHLLODEAHG, int MPIANHPEDHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x446E170", Offset = "0x446D170", VA = "0x18446E170")]
		public bool Remove(IBDGAHOKAMA IMENKKCALAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NGCJDECJPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KLLIMGEENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int LPLEHFIAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int ANHHMCFHLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int JBMIDFOHIGH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x447ABF0", Offset = "0x4479BF0", VA = "0x18447ABF0")]
	public NGCJDECJPKB(int LPLEHFIAKIB, int ANHHMCFHLEH, int KLLIMGEENAE, int JBMIDFOHIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EFKMFLCOFOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<float3> DAHEFMNOPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> NPGEGAJCGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<int> MNLAPJOECFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<NGCJDECJPKB> ELNKOOKPPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<int> NJDIALKOLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> GINGDAEPDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<float> GHLHPEDFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public JobHandle JFFHPOFBDEH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HOMAEAECIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB230", Offset = "0x7FA230", VA = "0x1807FB230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB250", Offset = "0x7FA250", VA = "0x1807FB250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4472960", Offset = "0x4471960", VA = "0x184472960")]
	public void CPCCCGHKLLE(DPOMDMFCDCE EPBNBILDBED, NativeList<NGCJDECJPKB> ELNKOOKPPDJ, float OAEPCIBBLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x44737B0", Offset = "0x44727B0", VA = "0x1844737B0")]
	public void IMPFOJFCCDO(Transform EIIIPMJKAPH, bool DFFKPOKFCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4473A70", Offset = "0x4472A70", VA = "0x184473A70")]
	public void OAFMGKJOADA(HMPIIHDIIKP ANOBCBEPEBH, bool NLNNGDKPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x44736E0", Offset = "0x44726E0", VA = "0x1844736E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4472930", Offset = "0x4471930", VA = "0x184472930")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public EFKMFLCOFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct FKOOPEAOOMH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeList<float3> DAHEFMNOPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeList<int> NPGEGAJCGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeList<NGCJDECJPKB> FDPCECGHEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<int> NJDIALKOLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float3 ACBFBODHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float3> GINGDAEPDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeArray<float> GHLHPEDFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private bool DFFKPOKFCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float AJIAKMPKMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float ALGBLNLBGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float LPHPMELEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeList<int> MNLAPJOECFC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4474750", Offset = "0x4473750", VA = "0x184474750")]
	public FKOOPEAOOMH(EFKMFLCOFOB KMFPIDMGGEI, Vector3 ACBFBODHLCB, bool DFFKPOKFCIO, float AJIAKMPKMBF, float ALGBLNLBGHA, float LPHPMELEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x44742B0", Offset = "0x44732B0", VA = "0x1844742B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IBDGAHOKAMA : NAGGIEMENAF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds HEPIOBHJNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IMNKKMKDAOC LKICCFINEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNDIMNIFNGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public List<IBDGAHOKAMA> GMMAGLNOFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public KNDIMNIFNGJ ACJKMIDAEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public KNDIMNIFNGJ NCCDJNPEGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public KNDIMNIFNGJ HPLLCHMGDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int JBMIDFOHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Bounds KIAFMKMBMLD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x447A0D0", Offset = "0x44790D0", VA = "0x18447A0D0")]
	public KNDIMNIFNGJ(List<IBDGAHOKAMA> GMMAGLNOFNP, [Optional] KNDIMNIFNGJ ACJKMIDAEJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LMDBOANJBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<KNDIMNIFNGJ> HBPBIGKNGLL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KNDIMNIFNGJ CEOKDDJOCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x447A900", Offset = "0x4479900", VA = "0x18447A900")]
	public LMDBOANJBPC(KNDIMNIFNGJ EIIIPMJKAPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPHENCMIMLI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct HINLHMLCECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int IFAHNNBMIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LIKKPALMKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int GJFKPJEKNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int EJDLEPEEDGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JHKJMGBFMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int PFIPDCIAMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float GEMIHPOOAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<IBDGAHOKAMA> GMMAGLNOFNP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum KAKDBAAODLD
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
	private HINLHMLCECM LEGGBABHCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int BLJAFLKIDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int GNLOANOJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int MMDOGGMAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float OPFKADEELIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float EHOLDIGELID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Stack<KNDIMNIFNGJ> MEJKEHHGMDF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LMDBOANJBPC FHEGLOGEAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x447E2D0", Offset = "0x447D2D0", VA = "0x18447E2D0")]
	public OPHENCMIMLI(int GNLOANOJKCM, int MMDOGGMAMBK, float OPFKADEELIJ, int BLJAFLKIDKF, float EHOLDIGELID = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x447C700", Offset = "0x447B700", VA = "0x18447C700")]
	public void EFMEABOODKF(List<IBDGAHOKAMA> GMMAGLNOFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x447D7A0", Offset = "0x447C7A0", VA = "0x18447D7A0")]
	public bool JHJFKADFHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x447E1C0", Offset = "0x447D1C0", VA = "0x18447E1C0")]
	private float MAHBPLFMHAK(Vector3 JIPMMAPKNJI, Vector3 KJMOBOIFGBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x447E120", Offset = "0x447D120", VA = "0x18447E120")]
	private float MAHBPLFMHAK(Vector3 MAAFLBOPOCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x447D810", Offset = "0x447C810", VA = "0x18447D810")]
	private bool KHPPHPFJGAM(KNDIMNIFNGJ LHNAIFLJCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x447CC50", Offset = "0x447BC50", VA = "0x18447CC50")]
	private JHKJMGBFMAA HIFLKACJBML(List<IBDGAHOKAMA> DMAOHMGHHKN, KAKDBAAODLD BEGFACCCNAP)
	{
		return default(JHKJMGBFMAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x447C8C0", Offset = "0x447B8C0", VA = "0x18447C8C0")]
	private void GOJCAOMOEMH(List<IBDGAHOKAMA> GMMAGLNOFNP, Vector3[] MJEPPKCFNEM, Vector3[] JLPFLJBHIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IGCMMOIMGJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4476330", Offset = "0x4475330", VA = "0x184476330")]
	public static Bounds NJMMANCKPKO(List<IBDGAHOKAMA> GMMAGLNOFNP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x44761A0", Offset = "0x44751A0", VA = "0x1844761A0")]
	public static int HELDKOFHCJG(List<IBDGAHOKAMA> GMMAGLNOFNP, BENKDIMFFKF FLHLJFAEENP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IJEABBNEGIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DPOMDMFCDCE FOPMOLMIJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DPOMDMFCDCE PODHJBKAIDL;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static DPOMDMFCDCE GFPADKPHEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private DCKOGNNFLGE FNLKMEKNBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NFEOGOPBIPA FDGGMGFCKOF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle JFFHPOFBDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x89D740", Offset = "0x89C740", VA = "0x18089D740")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x89D760", Offset = "0x89C760", VA = "0x18089D760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HMPIIHDIIKP.KFBEEFKHHON LHNAIFLJCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EMNHLOKGKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75B990", Offset = "0x75A990", VA = "0x18075B990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4476FB0", Offset = "0x4475FB0", VA = "0x184476FB0")]
	[KMMCCHGHBPI(MCCKPBHNINP.ExitingPlayMode, 0)]
	private void EJLFFODIDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4476520", Offset = "0x4475520", VA = "0x184476520")]
	public void CPCCCGHKLLE(HMPIIHDIIKP.KFBEEFKHHON FDPCECGHEOD, Transform MPBFKPONKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4477020", Offset = "0x4476020", VA = "0x184477020")]
	public void OPOECLHMPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4476F40", Offset = "0x4475F40", VA = "0x184476F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x44764E0", Offset = "0x44754E0", VA = "0x1844764E0")]
	public void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4477630", Offset = "0x4476630", VA = "0x184477630")]
	public IJEABBNEGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AHCJMADDGFK
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DCKIBDJOFCL ADFAJJONMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EEPMPAEONBD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 MGNEPDIOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MFMAAOIMBIP
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(ECKKNIKHLKB HPEGEBJKIBG, CancellationToken DBKPHPKFAOL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JCFNIECFLCO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCFNIECFLCO MHMCNKINMHJ(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCFNIECFLCO OCFMPFIJMIK(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCFNIECFLCO KDHCABPCBDL(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCFNIECFLCO DHHBJAEGAIF(Action KAIJPPOLHDF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class KFLEOMEGFDJ : JCFNIECFLCO
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class EFKDCILGMLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public KFLEOMEGFDJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
				public EFKDCILGMLL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x4472850", Offset = "0x4471850", VA = "0x184472850")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x44728A0", Offset = "0x44718A0", VA = "0x1844728A0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x44728F0", Offset = "0x44718F0", VA = "0x1844728F0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Func<JobHandle> OJPLCMPILLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action GEJEMNFLBLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Action NPLHNPFCGHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private HAFAFEDOFJD GJDKKHOODLJ;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action LJAJOOCHMAE
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6AFCC0", Offset = "0x6AECC0", VA = "0x1806AFCC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action GLIFEOHIGBP
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2699DE0", Offset = "0x2698DE0", VA = "0x182699DE0", Slot = "4")]
			public JCFNIECFLCO MHMCNKINMHJ(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2BD0", Offset = "0x2AF1BD0", VA = "0x182AF2BD0", Slot = "5")]
			public JCFNIECFLCO OCFMPFIJMIK(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x238EED0", Offset = "0x238DED0", VA = "0x18238EED0", Slot = "6")]
			public JCFNIECFLCO KDHCABPCBDL(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2822C60", Offset = "0x2821C60", VA = "0x182822C60", Slot = "7")]
			public JCFNIECFLCO DHHBJAEGAIF(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
			public KFLEOMEGFDJ(Func<JobHandle> OPNOMLPCCDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4479EA0", Offset = "0x4478EA0", VA = "0x184479EA0")]
			public void MOONNOKDBKF(Action GOFAACELLJM, Action KFLDLOLLLFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4479D40", Offset = "0x4478D40", VA = "0x184479D40")]
			public void INAIIIEHGLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OBJFBBNHMBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public JCFNIECFLCO jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public OBJFBBNHMBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x447C6F0", Offset = "0x447B6F0", VA = "0x18447C6F0")]
			internal bool <Remove>b__0(KFLEOMEGFDJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class NICFKLAFOJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public KFLEOMEGFDJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public NICFKLAFOJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x447C330", Offset = "0x447B330", VA = "0x18447C330")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Queue<KFLEOMEGFDJ> FIFJHMPLEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<KFLEOMEGFDJ> NBLNOKBAJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private DMIEKLLPPEA FCAPCJBGFJO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public INHIHAKOIMB LMPPCABPMEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x44776C0", Offset = "0x44766C0", VA = "0x1844776C0")]
		public JCFNIECFLCO Add(Func<JobHandle> OPNOMLPCCDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4477960", Offset = "0x4476960", VA = "0x184477960")]
		public void Remove(JCFNIECFLCO JFFHPOFBDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x44777E0", Offset = "0x44767E0", VA = "0x1844777E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4477AE0", Offset = "0x4476AE0", VA = "0x184477AE0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4477CB0", Offset = "0x4476CB0", VA = "0x184477CB0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x44777D0", Offset = "0x44767D0", VA = "0x1844777D0")]
		[CompilerGenerated]
		private void OLBFBDIAPBM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HAFAFEDOFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAFAFEDOFJD MHMCNKINMHJ(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAFAFEDOFJD NCAHHACLCJM(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAFAFEDOFJD DHHBJAEGAIF(Action KAIJPPOLHDF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BDHINPPACML : HAFAFEDOFJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private JobHandle OLKBFNBPFEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action GEJEMNFLBLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action BPNOFEIHBBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Action GLIFEOHIGBP;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool LHGMFEODBEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x446D2E0", Offset = "0x446C2E0", VA = "0x18446D2E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2BD0", Offset = "0x2AF1BD0", VA = "0x182AF2BD0", Slot = "4")]
			public HAFAFEDOFJD MHMCNKINMHJ(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x238EED0", Offset = "0x238DED0", VA = "0x18238EED0", Slot = "5")]
			public HAFAFEDOFJD NCAHHACLCJM(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2822C60", Offset = "0x2821C60", VA = "0x182822C60", Slot = "6")]
			public HAFAFEDOFJD DHHBJAEGAIF(Action KAIJPPOLHDF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCEA370", Offset = "0xCE9370", VA = "0x180CEA370")]
			public BDHINPPACML(JobHandle AMOHGMDBKEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x446D2F0", Offset = "0x446C2F0", VA = "0x18446D2F0")]
			public void NAFAAPPDJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x446D2A0", Offset = "0x446C2A0", VA = "0x18446D2A0")]
			public void INAIIIEHGLD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private List<BDHINPPACML> LPBOFHIPFMM;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4478130", Offset = "0x4477130", VA = "0x184478130")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4477D70", Offset = "0x4476D70", VA = "0x184477D70")]
		public HAFAFEDOFJD Add(JobHandle AMOHGMDBKEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4478040", Offset = "0x4477040", VA = "0x184478040")]
		public void Remove(HAFAFEDOFJD JFFHPOFBDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4477EE0", Offset = "0x4476EE0", VA = "0x184477EE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4477E00", Offset = "0x4476E00", VA = "0x184477E00")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4478240", Offset = "0x4477240", VA = "0x184478240")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4473CC0", Offset = "0x4472CC0", VA = "0x184473CC0")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4473DC0", Offset = "0x4472DC0", VA = "0x184473DC0")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
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
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
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
