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
				[Cpp2IlInjected.Address(RVA = "0x5AED120", Offset = "0x5AEC120", VA = "0x185AED120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1718820", Offset = "0x1717820", VA = "0x181718820")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5AED0E0", Offset = "0x5AEC0E0", VA = "0x185AED0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AE2050", Offset = "0x5AE1050", VA = "0x185AE2050")]
		public LODSettings OFAAKCOGADE(DLGNEFKOMDA LBEEDONFEAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2030", Offset = "0x5AE1030", VA = "0x185AE2030")]
		public int LHOJHILJCEN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1F30", Offset = "0x5AE0F30", VA = "0x185AE1F30")]
		public int KLHFCHKHEEH(bool PEFLGFCBNHL, Vector3 CAFKOGEEDMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2060", Offset = "0x5AE1060", VA = "0x185AE2060")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EDKIOJFEFHB
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
public interface POMJANPEGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAMGEILKFGK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DDKMLLAHDMD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BOMMKHPLLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<OLGMJOKIAJL> IGNEPKJLCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EDKIOJFEFHB KIAGLAJLHEF
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
	void UpdateClusterDistances(Vector3 GACKECGDAKI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(EMOILPCBOLJ NANIPOPDLDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OLGMJOKIAJL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int ACNBCNJOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KLCNGCDNFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GIPNMBGGGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BBAJPOPMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte KOLEACKMKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LPIPOMDIPHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CJIPKGPPCEH
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Running
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KLPCCKPMLME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LPIPOMDIPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OEPFOLMCINK <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA060", Offset = "0x5AE9060", VA = "0x185AEA060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FMHMGCBGOEG : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LPIPOMDIPHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public FMHMGCBGOEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4AE0", Offset = "0x5AE3AE0", VA = "0x185AE4AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4BA0", Offset = "0x5AE3BA0", VA = "0x185AE4BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EJJFJPJODAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LPIPOMDIPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OEPFOLMCINK worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OEPFOLMCINK <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE3830", Offset = "0x5AE2830", VA = "0x185AE3830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IOHJJFDNKKG : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public LPIPOMDIPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public IOHJJFDNKKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE79F0", Offset = "0x5AE69F0", VA = "0x185AE79F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5AE88A0", Offset = "0x5AE78A0", VA = "0x185AE88A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FBPFFDFMADH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan EDKDPHMDEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer EDJBELMFJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter BEKBEONKOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject IPINMIIEIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject BLMPCKNBIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IMNOJOHMMCK MFFOCKIAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<EMOILPCBOLJ> MELPMFDICIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EMOILPCBOLJ> DBNBADACPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<EMOILPCBOLJ> DELMHICPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JBOFCCKMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private CJIPKGPPCEH EFPMMIMFHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<DDKMLLAHDMD>[] OBNJPJHILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<OLGMJOKIAJL>[] DGMMOGNMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource LFHBMLIKEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool FJFDJIDFHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ALMNDBMKBBN PBBBJPGMNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ALMNDBMKBBN BOEAEAMFFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NAGLALEHBII;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static LPIPOMDIPHC LNJMJOBCJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BMIECOEDHCL JEPGEJEEFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly AHBJNFPKOMC EPGKDKPDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour GBCCHLKDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Material LPGLKFKFFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<POMJANPEGHD> LFPMJPHLFBG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig GFLIPHGONBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 CBPFGPLLALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14A3EB0", Offset = "0x14A2EB0", VA = "0x1814A3EB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DD0", Offset = "0x14A2DD0", VA = "0x1814A3DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CJIPKGPPCEH OMJKJEFJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x834620", Offset = "0x833620", VA = "0x180834620")]
		get
		{
			return default(CJIPKGPPCEH);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5AEEEE0", Offset = "0x5AEDEE0", VA = "0x185AEEEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LPIPOMDIPHC FDNKALDKIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0F90", Offset = "0x5AEFF90", VA = "0x185AF0F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KJNKODPECBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5AEFB00", Offset = "0x5AEEB00", VA = "0x185AEFB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool MCFBOLFACJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5AEEE00", Offset = "0x5AEDE00", VA = "0x185AEEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> FHPMMOPBOON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5AEF190", Offset = "0x5AEE190", VA = "0x185AEF190")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0580", Offset = "0x5AEF580", VA = "0x185AF0580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FPBECNEPPED
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AEF080", Offset = "0x5AEE080", VA = "0x185AEF080")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0050", Offset = "0x5AEF050", VA = "0x185AF0050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1710", Offset = "0x5AF0710", VA = "0x185AF1710")]
	public LPIPOMDIPHC(BMIECOEDHCL JEPGEJEEFHG, AHBJNFPKOMC EPGKDKPDOBO, ClusterLODConfig FMNFFGONIJI, MonoBehaviour GBCCHLKDBMM, Material LPGLKFKFFNA, ClusterMeshRenderer EDJBELMFJPG, MeshFilter BEKBEONKOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF230", Offset = "0x5AEE230", VA = "0x185AEF230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFC20", Offset = "0x5AEEC20", VA = "0x185AEFC20")]
	public static void GFMKMJAEICO(Vector3 JLNHPICJMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF4B0", Offset = "0x5AEE4B0", VA = "0x185AEF4B0")]
	private void ENHCHEODLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF3B0", Offset = "0x5AEE3B0", VA = "0x185AEF3B0")]
	private void EFHFBKEGNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0250", Offset = "0x5AEF250", VA = "0x185AF0250")]
	private void INNBMFDLAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF5A0", Offset = "0x5AEE5A0", VA = "0x185AEF5A0")]
	public void FFEJFGOPLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1240", Offset = "0x5AF0240", VA = "0x185AF1240")]
	[AsyncStateMachine(typeof(KLPCCKPMLME))]
	public Task NENJMADBDDN(OEPFOLMCINK OKOAEEBPCIH, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF010", Offset = "0x5AEE010", VA = "0x185AEF010")]
	[IteratorStateMachine(typeof(FMHMGCBGOEG))]
	private IEnumerator<FEEMOJCDGJP> BKCHEIIAOHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1380", Offset = "0x5AF0380", VA = "0x185AF1380")]
	[AsyncStateMachine(typeof(EJJFJPJODAO))]
	private Task PJGBCLIFLAC(OEPFOLMCINK HKAJOLEFBAJ, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1030", Offset = "0x5AF0030", VA = "0x185AF1030")]
	public void NCEHIAHNKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFD50", Offset = "0x5AEED50", VA = "0x185AEFD50")]
	public void HDOAALBFNON(IEnumerable<DDKMLLAHDMD> LJJGBFIGIBO, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFDD0", Offset = "0x5AEEDD0", VA = "0x185AEFDD0")]
	public void HFCCKGCFKAL(IEnumerable<DDKMLLAHDMD> LJJGBFIGIBO, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5AF08E0", Offset = "0x5AEF8E0", VA = "0x185AF08E0")]
	public List<ClusterMeshRenderer> LNALNNPKAPC(List<EMOILPCBOLJ> MDPFJMFBAOK, HLKOGFFGFGN IGJDJDNFANI, EDKIOJFEFHB EEBBPKANDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0FF0", Offset = "0x5AEFFF0", VA = "0x185AF0FF0")]
	public EDKIOJFEFHB MNKCOCPJPBK(Vector3 KPPIAMGIHEI)
	{
		return default(EDKIOJFEFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0520", Offset = "0x5AEF520", VA = "0x185AF0520")]
	public void KBGFOMBKJHG(POMJANPEGHD JFMFHHPEOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0840", Offset = "0x5AEF840", VA = "0x185AF0840")]
	public bool LJPLFDAMGNG(POMJANPEGHD JFMFHHPEOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF540", Offset = "0x5AEE540", VA = "0x185AEF540")]
	public void FDKPAOPMJGM(EMOILPCBOLJ PAMAAMGGCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF330", Offset = "0x5AEE330", VA = "0x185AEF330")]
	public void EAINBEIBAKL(OLGMJOKIAJL OEMDKJEIDHC, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0620", Offset = "0x5AEF620", VA = "0x185AF0620")]
	public void KCGAPHOBMNF(OLGMJOKIAJL OEMDKJEIDHC, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5AF00F0", Offset = "0x5AEF0F0", VA = "0x185AF00F0")]
	private void HKMJHBFBMFM(Vector3 GACKECGDAKI, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5AF06A0", Offset = "0x5AEF6A0", VA = "0x185AF06A0")]
	private void KECAHEJMHIF(Vector3 GACKECGDAKI, EDKIOJFEFHB EEBBPKANDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF120", Offset = "0x5AEE120", VA = "0x185AEF120")]
	[IteratorStateMachine(typeof(IOHJJFDNKKG))]
	private IEnumerator<FEEMOJCDGJP> CMOJLBOLMEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5AF03A0", Offset = "0x5AEF3A0", VA = "0x185AF03A0")]
	private int JDPLIGNDILJ(int EGBCAPEEJBF, int LJECBODOGGC, List<OLGMJOKIAJL> KGHOMFANGNF, byte LBEEDONFEAE, ref int EPHFLINEPAI, float MEMMAEIBOAB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5AF14C0", Offset = "0x5AF04C0", VA = "0x185AF14C0")]
	public void PMMODKPOELK(EMOILPCBOLJ NANIPOPDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5AF08A0", Offset = "0x5AEF8A0", VA = "0x185AF08A0")]
	public bool LLNCBKOBMMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7977C0", Offset = "0x7967C0", VA = "0x1807977C0")]
	public Material NEILFGACFMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0800", Offset = "0x5AEF800", VA = "0x185AF0800")]
	public int LHOJHILJCEN()
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
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BLHLIIJHGGH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeList<float3> LOOPGEPFCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float3> GCMLBDKABIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4> PKCKABLLMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float2> IAPHJBNHIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> MFBHJOIBNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeList<int> CAHDBKNLLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeList<float3> LLCFDPHEBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private float3 IIHBDPFPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private float PPMMPDEBBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeMultiHashMap<int, int> ADAOLCNPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<int> IEHEMAFGPGC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1E70", Offset = "0x5AE0E70", VA = "0x185AE1E70")]
	public BLHLIIJHGGH(LBEENDJFEOI DJAAGGDMNFL, NativeList<float3> LLCFDPHEBLA, NativeMultiHashMap<int, int> ADAOLCNPCII, NativeArray<int> IEHEMAFGPGC, Vector3 IIHBDPFPKCK, float PPMMPDEBBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1BE0", Offset = "0x5AE0BE0", VA = "0x185AE1BE0")]
	private int LKLMHAFABKJ(float3 GACKECGDAKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1C10", Offset = "0x5AE0C10", VA = "0x185AE1C10")]
	private int NLFBCCCGMFN(int BDAADCOCKII, int EBOIOCBODNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5AE17B0", Offset = "0x5AE07B0", VA = "0x185AE17B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DPIBODOLBHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static NativeMultiHashMap<int, int> ADAOLCNPCII;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static NativeArray<int> IEHEMAFGPGC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static int GJLHBIEJIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeList<int> PIMDJDEKBAD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5AE3640", Offset = "0x5AE2640", VA = "0x185AE3640")]
	public void NNKGJCBLLOC(int HBPAJCFBAKB, Allocator GOLNHBOGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5AE3560", Offset = "0x5AE2560", VA = "0x185AE3560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public DPIBODOLBHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct NIFIMPLOHHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	public NativeList<int> LCBPBAGAHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeList<int> EDCJIFPMHBO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3540", Offset = "0x5AF2540", VA = "0x185AF3540")]
	public NIFIMPLOHHN(DPIBODOLBHG ECBMFMIPAPF, LBEENDJFEOI DJAAGGDMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF34A0", Offset = "0x5AF24A0", VA = "0x185AF34A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct HPDFGAADOOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeList<float3> EPPFNLABAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<float3> PFOFLJDACCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeArray<float4> PAJMONAOAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeArray<float2> HDDEMAJBCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<float4> BHKDBDKKAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeList<int> PIMDJDEKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeList<int> LCBPBAGAHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeList<float3> AELHCNPADLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeArray<float3> FGLIJDHJDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<float4> FKPHOBFENFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<float4> NJKPMAACMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<float2> AJGDAAKGIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> KGDFHLLEAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float JGHNLLALBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float ENJOKDHIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	private float3 OOBDECIHNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[ReadOnly]
	private float JDOPJKAHIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float DGKFBKCDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float FNIJMIADAMA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6E40", Offset = "0x5AE5E40", VA = "0x185AE6E40")]
	public HPDFGAADOOA(DPIBODOLBHG FAHDDAANCAN, LBEENDJFEOI DJAAGGDMNFL, LBEENDJFEOI OMCHAMOOFKP, float DGKFBKCDHMI, float FNIJMIADAMA, Vector3 OOBDECIHNNA, float JDOPJKAHIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6D90", Offset = "0x5AE5D90", VA = "0x185AE6D90")]
	private float3 OIMMLJNHGBH(int BDAADCOCKII)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6570", Offset = "0x5AE5570", VA = "0x185AE6570")]
	private void FKAENGJDNEF(int BDAADCOCKII, out float3 IDOAJLABEGL, out float3 FILEINJJOJA, out float4 AGBJCOJKNAO, out float4 KGKOABBFKKF, out float2 JKEJPMDBFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5890", Offset = "0x5AE4890", VA = "0x185AE5890")]
	private int CHPPKBOJOHJ(int DONECLIAHKM, int GJDKAJPLOKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5AE69D0", Offset = "0x5AE59D0", VA = "0x185AE69D0")]
	private void KPDPNOFKEDE(int DONECLIAHKM, int GJDKAJPLOKM, int HKJJNBPJCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6BE0", Offset = "0x5AE5BE0", VA = "0x185AE6BE0")]
	private bool MGIECJCJPAJ(int DONECLIAHKM, int GJDKAJPLOKM, float EIIBFGMKOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5B90", Offset = "0x5AE4B90", VA = "0x185AE5B90")]
	private bool DJNNJGFAJGF(int DONECLIAHKM, int GJDKAJPLOKM, int HKJJNBPJCFN, float EIIBFGMKOBG, bool BPIFFIIDDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6760", Offset = "0x5AE5760", VA = "0x185AE6760")]
	private bool FLIAOKNCJEH(int DONECLIAHKM, int GJDKAJPLOKM, int HKJJNBPJCFN, float EIIBFGMKOBG, bool BPIFFIIDDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6D70", Offset = "0x5AE5D70", VA = "0x185AE6D70")]
	private void OEEJOLAFGDH(int DONECLIAHKM, int GJDKAJPLOKM, int HKJJNBPJCFN, out int FOGNKCGGANI, out int LOJNINHMLEI, out int LKJBJNHINGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5C50", Offset = "0x5AE4C50", VA = "0x185AE5C50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NEFHGODOLDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AAIODICCBLB : IDisposable, OLGMJOKIAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Bounds BNIHLJDPCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<EMOILPCBOLJ> MDPFJMFBAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 EPFGHALBBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Vector3 JCJHEKODBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int IAFDKAEACPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LBEENDJFEOI ECLLNGKLKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DPIBODOLBHG BKOEFIPOJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Transform IGJDJDNFANI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int HDHPPAOHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1430", Offset = "0x5AE0430", VA = "0x185AE1430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh LPPMIAJHOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh KAGJDMANLMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GIPNMBGGGKP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8C0", Offset = "0x15EC8C0", VA = "0x1815ED8C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2F34180", Offset = "0x2F33180", VA = "0x182F34180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public byte KOLEACKMKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xF10FD0", Offset = "0xF0FFD0", VA = "0x180F10FD0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x12FD060", Offset = "0x12FC060", VA = "0x1812FD060", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int ACNBCNJOLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA3D180", Offset = "0xA3C180", VA = "0x180A3D180", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA3D190", Offset = "0xA3C190", VA = "0x180A3D190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int KLCNGCDNFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC0CA20", Offset = "0xC0BA20", VA = "0x180C0CA20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE0C940", Offset = "0xE0B940", VA = "0x180E0C940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BBAJPOPMJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1470", Offset = "0x5AE0470", VA = "0x185AE1470", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1490", Offset = "0x5AE0490", VA = "0x185AE1490")]
		public void KLJPNLEOMOB(DLGNEFKOMDA LBEEDONFEAE, out int FHANGIDKMHI, out int CEBIAKCJPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0F40", Offset = "0x5ADFF40", VA = "0x185AE0F40")]
		public void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0BA0", Offset = "0x5ADFBA0", VA = "0x185AE0BA0")]
		public void CBNBBGGALBK(NativeList<JNGHICNLFNC> HDPHNFEGAFE, Transform OFGIGKJMOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE10F0", Offset = "0x5AE00F0", VA = "0x185AE10F0")]
		public void DMDOHPCECGB(Mesh DJAAGGDMNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1390", Offset = "0x5AE0390", VA = "0x185AE1390")]
		public void FNNPDPFIANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1190", Offset = "0x5AE0190", VA = "0x185AE1190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5AE16C0", Offset = "0x5AE06C0", VA = "0x185AE16C0")]
		public AAIODICCBLB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Bounds BNIHLJDPCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public List<AAIODICCBLB> IPPPFADIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LDHOGHPIOAI CFPFKDDHMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ClusterMeshRenderer PMIFMNEAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int JAIJADHEHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh PJGCALFHALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LJEFOALIBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA49830", Offset = "0xA48830", VA = "0x180A49830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BOMMKHPLLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2AE0", Offset = "0x5AF1AE0", VA = "0x185AF2AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF21B0", Offset = "0x5AF11B0", VA = "0x185AF21B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1FC0", Offset = "0x5AF0FC0", VA = "0x185AF1FC0")]
	public int AJBDIDCOLFK(int IICLPBOIFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1FF0", Offset = "0x5AF0FF0", VA = "0x185AF1FF0")]
	public void DPANEHDABIC(JAEHIDCDGMJ KDFEMIPLMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2310", Offset = "0x5AF1310", VA = "0x185AF2310")]
	public void EICGOEDKHBO(Transform OFGIGKJMOGJ, bool EFHFIKBCEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2F80", Offset = "0x5AF1F80", VA = "0x185AF2F80")]
	public bool OHDPGIKEBIK(bool ILDPDCJFECL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2B30", Offset = "0x5AF1B30", VA = "0x185AF2B30")]
	public void OAIPHCLNCOE(Transform IGJDJDNFANI, bool EFHFIKBCEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3140", Offset = "0x5AF2140", VA = "0x185AF3140")]
	public bool PMMODKPOELK(EMOILPCBOLJ NANIPOPDLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5AF33F0", Offset = "0x5AF23F0", VA = "0x185AF33F0")]
	public NEFHGODOLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IMNOJOHMMCK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Queue<NEFHGODOLDI.AAIODICCBLB> OMCECIBICKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LNPEIFBEAPC CBBEFACPKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NEFHGODOLDI.AAIODICCBLB> GKFJKMPKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GLBJOHMFLEE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7180", Offset = "0x5AE6180", VA = "0x185AE7180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE71F0", Offset = "0x5AE61F0", VA = "0x185AE71F0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE72D0", Offset = "0x5AE62D0", VA = "0x185AE72D0")]
	public void GBJBCHALJOG(NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA, Transform IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7680", Offset = "0x5AE6680", VA = "0x185AE7680")]
	public void PMMODKPOELK(NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7020", Offset = "0x5AE6020", VA = "0x185AE7020")]
	private NEFHGODOLDI.AAIODICCBLB CJAIELMNBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6F80", Offset = "0x5AE5F80", VA = "0x185AE6F80")]
	private bool ADNFEBCDEDA(NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7270", Offset = "0x5AE6270", VA = "0x185AE7270")]
	private void GBICJGBHNNA(NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7150", Offset = "0x5AE6150", VA = "0x185AE7150")]
	public bool DGPLNMBBFCD(NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7390", Offset = "0x5AE6390", VA = "0x185AE7390")]
	public bool HMNCABBCMFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7620", Offset = "0x5AE6620", VA = "0x185AE7620")]
	private NEFHGODOLDI.AAIODICCBLB MHMCKKHOHHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7870", Offset = "0x5AE6870", VA = "0x185AE7870")]
	public IMNOJOHMMCK()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HKNILGFFNNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NAJHPOCGABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int DCNICKMCPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float DAHJCNAIPPP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public List<NEFHGODOLDI> GPDIEBIOKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5840", Offset = "0x5AE4840", VA = "0x185AE5840")]
	public HKNILGFFNNL(int NAJHPOCGABE, int DCNICKMCPDD, float EABDKFFAMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5AE54E0", Offset = "0x5AE44E0", VA = "0x185AE54E0")]
	public void POEPKHHIADC(NCMGCGMAHCN HPDOCKLFKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5230", Offset = "0x5AE4230", VA = "0x185AE5230")]
	private int ADNEFAOHJNA(JAEHIDCDGMJ BBGMDMKKHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5600", Offset = "0x5AE4600", VA = "0x185AE5600")]
	private void POEPKHHIADC(JAEHIDCDGMJ BBGMDMKKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE52D0", Offset = "0x5AE42D0", VA = "0x185AE52D0")]
	private void MKODNLNLDFE(JAEHIDCDGMJ BBGMDMKKHON, NEFHGODOLDI KMNLHPOGBPH)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, DDKMLLAHDMD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LDEIMOBFLIE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public LDEIMOBFLIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5AEA640", Offset = "0x5AE9640", VA = "0x185AEA640", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5AEA7F0", Offset = "0x5AE97F0", VA = "0x185AEA7F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5AEA750", Offset = "0x5AE9750", VA = "0x185AEA750", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5AEA750", Offset = "0x5AE9750", VA = "0x185AEA750", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BOMMKHPLLDF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5AE3500", Offset = "0x5AE2500", VA = "0x185AE3500", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IEnumerable<OLGMJOKIAJL> IGNEPKJLCEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5AE34E0", Offset = "0x5AE24E0", VA = "0x185AE34E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<MeshFilter> IPPPFADIFNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NEFHGODOLDI PJGCALFHALF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EDKIOJFEFHB KIAGLAJLHEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7011B0", Offset = "0x7001B0", VA = "0x1807011B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(EDKIOJFEFHB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA22B00", Offset = "0xA21B00", VA = "0x180A22B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool CDMDOAFMOFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5AE34F0", Offset = "0x5AE24F0", VA = "0x185AE34F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE20C0", Offset = "0x5AE10C0", VA = "0x185AE20C0")]
		public static ClusterMeshRenderer Create(NEFHGODOLDI DJAAGGDMNFL, ClusterMeshRenderer EDJBELMFJPG, MeshFilter BEKBEONKOPC, HLKOGFFGFGN IGJDJDNFANI, EDKIOJFEFHB EEBBPKANDKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2260", Offset = "0x5AE1260", VA = "0x185AE2260", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2A20", Offset = "0x5AE1A20", VA = "0x185AE2A20", Slot = "10")]
		public bool TryRemoveClusterLODComponent(EMOILPCBOLJ NANIPOPDLDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2810", Offset = "0x5AE1810", VA = "0x185AE2810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AE24B0", Offset = "0x5AE14B0", VA = "0x185AE24B0")]
		public void Init(NEFHGODOLDI DJAAGGDMNFL, MeshFilter BEKBEONKOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AE22C0", Offset = "0x5AE12C0", VA = "0x185AE22C0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2B50", Offset = "0x5AE1B50", VA = "0x185AE2B50", Slot = "8")]
		public void UpdateClusterDistances(Vector3 GACKECGDAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2D60", Offset = "0x5AE1D60", VA = "0x185AE2D60", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2440", Offset = "0x5AE1440", VA = "0x185AE2440")]
		[IteratorStateMachine(typeof(LDEIMOBFLIE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2890", Offset = "0x5AE1890", VA = "0x185AE2890")]
		public void SetupTagAndLayer(string IJHBCFMOMGF, int EEBBPKANDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2870", Offset = "0x5AE1870", VA = "0x185AE2870")]
		public bool Remove(EMOILPCBOLJ NANIPOPDLDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HCNMLKFGBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int KHECBHNHACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int GJPBLFPOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CEBIAKCJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int FHANGIDKMHI;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4BE0", Offset = "0x5AE3BE0", VA = "0x185AE4BE0")]
	public HCNMLKFGBJC(int GJPBLFPOONO, int CEBIAKCJPCP, int KHECBHNHACL, int FHANGIDKMHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LDHOGHPIOAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeList<float3> LOOPGEPFCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeList<int> PIMDJDEKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeList<int> CAHDBKNLLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<HCNMLKFGBJC> JJPMEEGFFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeArray<int> EPAIJEKBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeArray<float3> NEOOJBHGEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float> INOIIEMCCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JobHandle DGGOEPGELHE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool APJNBIELNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBC8240", Offset = "0xBC7240", VA = "0x180BC8240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xBC87E0", Offset = "0xBC77E0", VA = "0x180BC87E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA970", Offset = "0x5AE9970", VA = "0x185AEA970")]
	public void MGAGAAKAIAK(LBEENDJFEOI HICKLNCCFPP, NativeList<HCNMLKFGBJC> JJPMEEGFFGM, float NHAEEIBBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBA40", Offset = "0x5AEAA40", VA = "0x185AEBA40")]
	public void PLBPPKLOMFN(Transform IGJDJDNFANI, bool EFHFIKBCEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB890", Offset = "0x5AEA890", VA = "0x185AEB890")]
	public void OHDPGIKEBIK(NEFHGODOLDI PMIFMNEAFNB, bool ILDPDCJFECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA830", Offset = "0x5AE9830", VA = "0x185AEA830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA940", Offset = "0x5AE9940", VA = "0x185AEA940")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LDHOGHPIOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct JJBAJCLBOHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> LOOPGEPFCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	public NativeList<int> PIMDJDEKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<HCNMLKFGBJC> CACEHPIBBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> EPAIJEKBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 OOBDECIHNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float3> NEOOJBHGEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float> INOIIEMCCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private bool EFHFIKBCEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private float LMKGLLKIGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private float COBKPGLBKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private float FMIBNKJCNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeList<int> CAHDBKNLLCN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5AE8DF0", Offset = "0x5AE7DF0", VA = "0x185AE8DF0")]
	public JJBAJCLBOHK(LDHOGHPIOAI FKODLFAPDGN, Vector3 OOBDECIHNNA, bool EFHFIKBCEJL, float LMKGLLKIGDK, float COBKPGLBKFA, float FMIBNKJCNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5AE8960", Offset = "0x5AE7960", VA = "0x185AE8960", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EMOILPCBOLJ : IJAJBOLFHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Bounds ACKNLHMLPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JNGHICNLFNC GNPABEFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAEHIDCDGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<EMOILPCBOLJ> MDPFJMFBAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public JAEHIDCDGMJ OKMBLMILFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public JAEHIDCDGMJ CIONHHPGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public JAEHIDCDGMJ AIKFPBFEOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int FHANGIDKMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Bounds BNIHLJDPCCG;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AE88E0", Offset = "0x5AE78E0", VA = "0x185AE88E0")]
	public JAEHIDCDGMJ(List<EMOILPCBOLJ> MDPFJMFBAOK, [Optional] JAEHIDCDGMJ OKMBLMILFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCMGCGMAHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<JAEHIDCDGMJ> JKIGDALFILC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JAEHIDCDGMJ IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1EF0", Offset = "0x5AF0EF0", VA = "0x185AF1EF0")]
	public NCMGCGMAHCN(JAEHIDCDGMJ IGJDJDNFANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LOOOACPFIOC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct NIPHPPLECGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int JOKEEJCAEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int OEOLNCMKBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int KLPLNEKFMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int HKAAJMNEJNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BNFPEOOELDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int MPOGIHPDBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float BAFBLDGCOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<EMOILPCBOLJ> MDPFJMFBAOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum OCAOOOODNJG
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NIPHPPLECGB BKJHDGMAJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int KMEPNHDHJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int NAJHPOCGABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int DCNICKMCPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float EABDKFFAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GHGCNODHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Stack<JAEHIDCDGMJ> DHNKDEJGHJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NCMGCGMAHCN NKECDLHMBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEDA0", Offset = "0x5AEDDA0", VA = "0x185AEEDA0")]
	public LOOOACPFIOC(int NAJHPOCGABE, int DCNICKMCPDD, float EABDKFFAMMD, int KMEPNHDHJAH, float GHGCNODHODB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AED9D0", Offset = "0x5AEC9D0", VA = "0x185AED9D0")]
	public void FBKDAMICNNA(List<EMOILPCBOLJ> MDPFJMFBAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDBD0", Offset = "0x5AECBD0", VA = "0x185AEDBD0")]
	public bool HPLDBNONHIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE8C0", Offset = "0x5AED8C0", VA = "0x185AEE8C0")]
	private float MBALCOMLAFE(Vector3 EKDCKLAKFJN, Vector3 IBFPNBPAEOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE870", Offset = "0x5AED870", VA = "0x185AEE870")]
	private float MBALCOMLAFE(Vector3 MKMGHJFMNMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5AED140", Offset = "0x5AEC140", VA = "0x185AED140")]
	private bool AIPKMDEMEFD(JAEHIDCDGMJ JGINIKIJCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDC40", Offset = "0x5AECC40", VA = "0x185AEDC40")]
	private BNFPEOOELDM JOMCDIMIJNO(List<EMOILPCBOLJ> GMAOBDMLIJH, OCAOOOODNJG DCMJJMAAAKD)
	{
		return default(BNFPEOOELDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE940", Offset = "0x5AED940", VA = "0x185AEE940")]
	private void NHKCDAOGPHO(List<EMOILPCBOLJ> MDPFJMFBAOK, Vector3[] NJBHMLFIIBO, Vector3[] EAENKGGNMON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KDFFIDBIKFE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9EB0", Offset = "0x5AE8EB0", VA = "0x185AE9EB0")]
	public static Bounds IOIEOLNEEPO(List<EMOILPCBOLJ> MDPFJMFBAOK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9D00", Offset = "0x5AE8D00", VA = "0x185AE9D00")]
	public static int GNPNCFJLACI(List<EMOILPCBOLJ> MDPFJMFBAOK, DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LNPEIFBEAPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LBEENDJFEOI CJKDECEHBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private LBEENDJFEOI IFLNMIMEALM;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static LBEENDJFEOI JHFOLEDNKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private ODBKDJJKMMJ IGKAALKCMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GACEEINPOIK HLLJMPAPIAH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle DGGOEPGELHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF2210", Offset = "0xCF1210", VA = "0x180CF2210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NEFHGODOLDI.AAIODICCBLB JGINIKIJCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LFKMBHHHCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7775A0", Offset = "0x7765A0", VA = "0x1807775A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC4D0", Offset = "0x5AEB4D0", VA = "0x185AEC4D0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.ExitingPlayMode, 0)]
	private static void KAEPEONAHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC540", Offset = "0x5AEB540", VA = "0x185AEC540")]
	public void MGAGAAKAIAK(NEFHGODOLDI.AAIODICCBLB CACEHPIBBBP, Transform PEJCHLIKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBD30", Offset = "0x5AEAD30", VA = "0x185AEBD30")]
	public void BLNHGOKGEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC420", Offset = "0x5AEB420", VA = "0x185AEC420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC490", Offset = "0x5AEB490", VA = "0x185AEC490")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AED040", Offset = "0x5AEC040", VA = "0x185AED040")]
	public LNPEIFBEAPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GIAMDNCCDOF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LPIPOMDIPHC JPFDDKCLADN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AHBJNFPKOMC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Vector3 CFEBGHIKHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BMIECOEDHCL
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(OEPFOLMCINK HKAJOLEFBAJ, CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KIKDJHEGGOO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIKDJHEGGOO OOIHBPAEKPF(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KIKDJHEGGOO MFGIABLJLNJ(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KIKDJHEGGOO PHBIJLBHKKL(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIKDJHEGGOO EGFGIKAKLAP(Action FFBLFKDINEA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class PKDPAOHCJCH : KIKDJHEGGOO
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class EPLBMLJFLOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public PKDPAOHCJCH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
				public EPLBMLJFLOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5AE4A00", Offset = "0x5AE3A00", VA = "0x185AE4A00")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5AE4A50", Offset = "0x5AE3A50", VA = "0x185AE4A50")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5AE4AA0", Offset = "0x5AE3AA0", VA = "0x185AE4AA0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private Func<JobHandle> CENHGLACFGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private Action OLKMEPPLCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private Action DJMFCEGEHFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private BNOPDDOIKMJ JGGDGLHEEBL;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action INCHMLHFFOH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Action DCMDHEHLLHI
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2C17590", Offset = "0x2C16590", VA = "0x182C17590", Slot = "4")]
			public KIKDJHEGGOO OOIHBPAEKPF(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x25729D0", Offset = "0x25719D0", VA = "0x1825729D0", Slot = "5")]
			public KIKDJHEGGOO MFGIABLJLNJ(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x25729F0", Offset = "0x25719F0", VA = "0x1825729F0", Slot = "6")]
			public KIKDJHEGGOO PHBIJLBHKKL(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2C175D0", Offset = "0x2C165D0", VA = "0x182C175D0", Slot = "7")]
			public KIKDJHEGGOO EGFGIKAKLAP(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
			public PKDPAOHCJCH(Func<JobHandle> FCAHMANEEOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5AF3570", Offset = "0x5AF2570", VA = "0x185AF3570")]
			public void LDGDMJHFFKN(Action FBKJIFMOFIF, Action CJAHKOCLIPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5AF3800", Offset = "0x5AF2800", VA = "0x185AF3800")]
			public void PMMODKPOELK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class AMFIIMFGPCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public KIKDJHEGGOO jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public AMFIIMFGPCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5AE17A0", Offset = "0x5AE07A0", VA = "0x185AE17A0")]
			internal bool <Remove>b__0(PKDPAOHCJCH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KABILKGOAAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public PKDPAOHCJCH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public KABILKGOAAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5AE9CA0", Offset = "0x5AE8CA0", VA = "0x185AE9CA0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Queue<PKDPAOHCJCH> ONEMMCMCLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private List<PKDPAOHCJCH> HKNGPPDJKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private ALMNDBMKBBN BKFCHAMICPJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PAIMOIHBPMD LLNJJMBIKGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8EC0", Offset = "0x5AE7EC0", VA = "0x185AE8EC0")]
		public KIKDJHEGGOO Add(Func<JobHandle> FCAHMANEEOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AE91C0", Offset = "0x5AE81C0", VA = "0x185AE91C0")]
		public void Remove(KIKDJHEGGOO DGGOEPGELHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9020", Offset = "0x5AE8020", VA = "0x185AE9020", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9390", Offset = "0x5AE8390", VA = "0x185AE9390")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AE95E0", Offset = "0x5AE85E0", VA = "0x185AE95E0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9010", Offset = "0x5AE8010", VA = "0x185AE9010")]
		[CompilerGenerated]
		private void CHPMFOCFMOM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BNOPDDOIKMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BNOPDDOIKMJ OOIHBPAEKPF(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNOPDDOIKMJ BAMKBKHEDKK(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BNOPDDOIKMJ EGFGIKAKLAP(Action FFBLFKDINEA);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class MBGANKILCMJ : BNOPDDOIKMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JobHandle DMDHKOEFPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private Action OLKMEPPLCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private Action KCIOCOEEAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private Action DCMDHEHLLHI;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool FFBFJBAACDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x5AF1E60", Offset = "0x5AF0E60", VA = "0x185AF1E60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x25729D0", Offset = "0x25719D0", VA = "0x1825729D0", Slot = "4")]
			public BNOPDDOIKMJ OOIHBPAEKPF(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x25729F0", Offset = "0x25719F0", VA = "0x1825729F0", Slot = "5")]
			public BNOPDDOIKMJ BAMKBKHEDKK(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2C175D0", Offset = "0x2C165D0", VA = "0x182C175D0", Slot = "6")]
			public BNOPDDOIKMJ EGFGIKAKLAP(Action FFBLFKDINEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
			public MBGANKILCMJ(JobHandle PIPNFOBKJAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5AF1E70", Offset = "0x5AF0E70", VA = "0x185AF1E70")]
			public void OIEKBFPKDBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5AF1EB0", Offset = "0x5AF0EB0", VA = "0x185AF1EB0")]
			public void PMMODKPOELK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<MBGANKILCMJ> CAIKKLNNMIB;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9AC0", Offset = "0x5AE8AC0", VA = "0x185AE9AC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE96E0", Offset = "0x5AE86E0", VA = "0x185AE96E0")]
		public BNOPDDOIKMJ Add(JobHandle PIPNFOBKJAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE99D0", Offset = "0x5AE89D0", VA = "0x185AE99D0")]
		public void Remove(BNOPDDOIKMJ DGGOEPGELHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9860", Offset = "0x5AE8860", VA = "0x185AE9860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9770", Offset = "0x5AE8770", VA = "0x185AE9770")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9BE0", Offset = "0x5AE8BE0", VA = "0x185AE9BE0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4C00", Offset = "0x5AE3C00", VA = "0x185AE4C00")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4D10", Offset = "0x5AE3D10", VA = "0x185AE4D10")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
