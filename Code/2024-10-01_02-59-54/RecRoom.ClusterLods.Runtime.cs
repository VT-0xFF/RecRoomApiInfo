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
				[Cpp2IlInjected.Address(RVA = "0x6D0EA50", Offset = "0x6D0DE50", VA = "0x186D0EA50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x920FF0", Offset = "0x9203F0", VA = "0x180920FF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6D0EA10", Offset = "0x6D0DE10", VA = "0x186D0EA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CFEAB0", Offset = "0x6CFDEB0", VA = "0x186CFEAB0")]
		public LODSettings MNDIADMGAOC(HOEGHAPJAGH KFELJFNOKBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEA90", Offset = "0x6CFDE90", VA = "0x186CFEA90")]
		public int LKDJCEJHGAE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE9F0", Offset = "0x6CFDDF0", VA = "0x186CFE9F0")]
		public int FAHDCNCHEDC(bool AEAOLAAIFOL, Vector3 FNADINHKOJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEAC0", Offset = "0x6CFDEC0", VA = "0x186CFEAC0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JGOKIBOEOGA
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
public interface PCGNDIJDFIF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNCOLLGDHLE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OKKGJGFIPKI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int AABLPFIEBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JFJBECMINEM> PGOHMHBABMG
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
	void UpdateClusterDistances(Vector3 JMOAHJJIPDJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(AGFDCDIOIJM FCNHHPDOLNN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JFJBECMINEM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EMMIMKJEDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JCOBCDAKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PODEDHCIHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NNJKAJNMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte GPHHDJPKDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KMCNPIAALMC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Control,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LowQualityShadow
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GGNCGGGOICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FJAKGOGCKCP
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
	private struct GNEKANALKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GGNCGGGOICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PMKGFNIFFEC<string>.INNANANOCLO <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AE20", Offset = "0x6D0A220", VA = "0x186D0AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B5B0", Offset = "0x6D0A9B0", VA = "0x186D0B5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KDJOOFIJCBP : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GGNCGGGOICP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public KDJOOFIJCBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E2B0", Offset = "0x6D0D6B0", VA = "0x186D0E2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E3C0", Offset = "0x6D0D7C0", VA = "0x186D0E3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FGPEGMNKFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GGNCGGGOICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PMKGFNIFFEC<string>.INNANANOCLO worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private PMKGFNIFFEC<string>.INNANANOCLO <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D047B0", Offset = "0x6D03BB0", VA = "0x186D047B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D06010", Offset = "0x6D05410", VA = "0x186D06010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FKAJADOPGHJ : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GGNCGGGOICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public FKAJADOPGHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D06070", Offset = "0x6D05470", VA = "0x186D06070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D06D60", Offset = "0x6D06160", VA = "0x186D06D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const int MMFOBLPKGEF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly TimeSpan ECOBOHLIJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ClusterMeshRenderer NLIHGEGMLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MeshFilter JGJNOMGHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GameObject HIMDGOLFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject PJPGMLHHJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public OMPKEENDBEL FNNKKBGMLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<AGFDCDIOIJM> DMKAKKEICHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<AGFDCDIOIJM> ANIMAADPGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<AGFDCDIOIJM> EGKCOLHAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int LABKDKLKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private FJAKGOGCKCP OLMLNACFEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public List<OKKGJGFIPKI>[] EPEACLMANDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private List<JFJBECMINEM>[] PANCGKNIMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CancellationTokenSource PMGLLMKFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool AFAIJIAFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GJOIDBBGEPO HHKJHACLEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private GJOIDBBGEPO DGIJAEGEOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int GPHCLBDKMAL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static GGNCGGGOICP KCGMLPDHDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PHCDFPAPJOP KINDEJBMDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CMFIICLLEHG CDJNHLJGLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MonoBehaviour OBMFGNAOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Material GEDENCFCGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Material CEHGJILEPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material EMKHLEKAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public KMCNPIAALMC OLMGCHFOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<PCGNDIJDFIF> AKCKKIICMCL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig CMKIEOBFAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 MFGEOACBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BC690", Offset = "0x8BBA90", VA = "0x1808BC690")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8BC200", Offset = "0x8BB600", VA = "0x1808BC200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private FJAKGOGCKCP GIDHAIDFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA8C7B0", Offset = "0xA8BBB0", VA = "0x180A8C7B0")]
		get
		{
			return default(FJAKGOGCKCP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D07A50", Offset = "0x6D06E50", VA = "0x186D07A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GGNCGGGOICP FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D089C0", Offset = "0x6D07DC0", VA = "0x186D089C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool PMGAMOFKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D08B80", Offset = "0x6D07F80", VA = "0x186D08B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MABLOBIJIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D07990", Offset = "0x6D06D90", VA = "0x186D07990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> MEBKAAHNILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D08500", Offset = "0x6D07900", VA = "0x186D08500")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A530", Offset = "0x6D09930", VA = "0x186D0A530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BKNLFBBFIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D09D50", Offset = "0x6D09150", VA = "0x186D09D50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D077F0", Offset = "0x6D06BF0", VA = "0x186D077F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A660", Offset = "0x6D09A60", VA = "0x186D0A660")]
	public GGNCGGGOICP(PHCDFPAPJOP KINDEJBMDFD, CMFIICLLEHG CDJNHLJGLDC, ClusterLODConfig PDMHGEAEDGL, MonoBehaviour OBMFGNAOIHO, Material GEDENCFCGGJ, ClusterMeshRenderer NLIHGEGMLLG, MeshFilter JGJNOMGHCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D09910", Offset = "0x6D08D10", VA = "0x186D09910")]
	public void LAILJJCCNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D085C0", Offset = "0x6D079C0", VA = "0x186D085C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D08260", Offset = "0x6D07660", VA = "0x186D08260")]
	public static void BPHDNOINIOO(Vector3 CBKGHPBCKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D07900", Offset = "0x6D06D00", VA = "0x186D07900")]
	private void AJOOGOOLAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D08C70", Offset = "0x6D08070", VA = "0x186D08C70")]
	private void HPKILPOPENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D08350", Offset = "0x6D07750", VA = "0x186D08350")]
	private void CEPIOEKNPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D08D40", Offset = "0x6D08140", VA = "0x186D08D40")]
	public void IINMGGNFPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D09E00", Offset = "0x6D09200", VA = "0x186D09E00")]
	[AsyncStateMachine(typeof(GNEKANALKHB))]
	public Task MEMHGKFFOLI(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D09AA0", Offset = "0x6D08EA0", VA = "0x186D09AA0")]
	[IteratorStateMachine(typeof(KDJOOFIJCBP))]
	private IEnumerator<BGFGBHFIDBJ> LJJHNEOCBNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D086C0", Offset = "0x6D07AC0", VA = "0x186D086C0")]
	[AsyncStateMachine(typeof(FGPEGMNKFMC))]
	private Task EDFMAKKCMNH(PMKGFNIFFEC<string>.INNANANOCLO PGMPGDGKDEI, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D09410", Offset = "0x6D08810", VA = "0x186D09410")]
	public void JKIMBCLBBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D087E0", Offset = "0x6D07BE0", VA = "0x186D087E0")]
	public void EINFKJLGLFE(IEnumerable<OKKGJGFIPKI> CIHADOJJIGJ, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D09610", Offset = "0x6D08A10", VA = "0x186D09610")]
	public void JNANEEEAFPF(IEnumerable<OKKGJGFIPKI> CIHADOJJIGJ, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D07B80", Offset = "0x6D06F80", VA = "0x186D07B80")]
	public List<ClusterMeshRenderer> BNNFIJALLGP(List<AGFDCDIOIJM> FMCKLIHFMCG, FHDOGMIMPJP FINELPFBLOK, JGOKIBOEOGA NHDCAJADCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A4D0", Offset = "0x6D098D0", VA = "0x186D0A4D0")]
	public void PHPMJFKDEAN(PCGNDIJDFIF IDFMLNHONHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D084A0", Offset = "0x6D078A0", VA = "0x186D084A0")]
	public bool DBJCHGBHAGE(PCGNDIJDFIF IDFMLNHONHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D078A0", Offset = "0x6D06CA0", VA = "0x186D078A0")]
	public void AGFJPAFKEAK(AGFDCDIOIJM GOFLNPKOHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A450", Offset = "0x6D09850", VA = "0x186D0A450")]
	public void OMPKKIDEICA(JFJBECMINEM PGKLFBGNCLC, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A060", Offset = "0x6D09460", VA = "0x186D0A060")]
	public void NBBLFOLFLDJ(JFJBECMINEM PGKLFBGNCLC, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D09F20", Offset = "0x6D09320", VA = "0x186D09F20")]
	private void MJEIPHPKEHA(Vector3 JMOAHJJIPDJ, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D08860", Offset = "0x6D07C60", VA = "0x186D08860")]
	private void FDKJPELPPJE(Vector3 JMOAHJJIPDJ, JGOKIBOEOGA NHDCAJADCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D09390", Offset = "0x6D08790", VA = "0x186D09390")]
	[IteratorStateMachine(typeof(FKAJADOPGHJ))]
	private IEnumerator<BGFGBHFIDBJ> JFMBMDLEMNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D08A10", Offset = "0x6D07E10", VA = "0x186D08A10")]
	private int GGLDHIDFKEE(int AEAHMAMPNLO, int LEBIAGAAGBG, List<JFJBECMINEM> NNJBONLEJKI, byte KFELJFNOKBH, int JMABBLOOBBN, float AOEECJLKPAG = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D09BA0", Offset = "0x6D08FA0", VA = "0x186D09BA0")]
	public void MAHJHHAHNPL(AGFDCDIOIJM FCNHHPDOLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B60", Offset = "0x6D08F60", VA = "0x186D09B60")]
	public bool LOCIJJGFMDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x908230", Offset = "0x907630", VA = "0x180908230")]
	public Material BBKGAMNCMHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x95E710", Offset = "0x95DB10", VA = "0x18095E710")]
	public Material JNLECMBEGIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4BA0", Offset = "0x8B3FA0", VA = "0x1808B4BA0")]
	public Material JMACJABCLNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B20", Offset = "0x6D08F20", VA = "0x186D09B20")]
	public int LKDJCEJHGAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A0E0", Offset = "0x6D094E0", VA = "0x186D0A0E0")]
	public long NPEAGLDIKGO()
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
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct CMGCMPGPBIE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<float3> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeArray<float2> KOBOIFIKHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float4> AAILBGHDKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeList<int> FPDKGNJGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<float3> LEHIJDPHOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private float3 JBBPAGLIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private float NJBCJJBFFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeParallelMultiHashMap<int, int> HGGEDEOOOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> MIOEKNHJBON;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE930", Offset = "0x6CFDD30", VA = "0x186CFE930")]
	public CMGCMPGPBIE(JHEIAOJDPDC JIPKNCLPFGJ, NativeList<float3> LEHIJDPHOJP, NativeParallelMultiHashMap<int, int> HGGEDEOOOBE, NativeArray<int> MIOEKNHJBON, Vector3 JBBPAGLIFEI, float NJBCJJBFFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE230", Offset = "0x6CFD630", VA = "0x186CFE230")]
	private int BPLMBHHJAAI(float3 JMOAHJJIPDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE6C0", Offset = "0x6CFDAC0", VA = "0x186CFE6C0")]
	private int GFMKOHKCJFL(int INBIGDGMENB, int GMJINMLEEAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE290", Offset = "0x6CFD690", VA = "0x186CFE290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HLDAHBFGECP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NativeParallelMultiHashMap<int, int> HGGEDEOOOBE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static NativeArray<int> MIOEKNHJBON;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int GOAINKDNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> HEBMEOPGMAF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B610", Offset = "0x6D0AA10", VA = "0x186D0B610")]
	public void ANPNPPGAEBN(int IHOGEOAGCLG, Allocator MGFIHPDNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B800", Offset = "0x6D0AC00", VA = "0x186D0B800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public HLDAHBFGECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct GFPMGJLKPKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeList<int> ABBOFLBDEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<int> BEDMNBODGCE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D077C0", Offset = "0x6D06BC0", VA = "0x186D077C0")]
	public GFPMGJLKPKP(HLDAHBFGECP KMJJCJBANPC, JHEIAOJDPDC JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D07710", Offset = "0x6D06B10", VA = "0x186D07710", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct FBALNOMKNLK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeList<float3> ADDNBBIKMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float3> ODKKGMPBJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> BEDPOOLGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeArray<float2> PLODBJAKOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float4> MKCAELLEOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<int> HEBMEOPGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> ABBOFLBDEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<float3> MMCAHDPIMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float3> GHJHIOMALKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float4> HOGIJJBHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeArray<float4> NNOHNLANJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float2> KCILGECAIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<int> JFLDNONFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float OJBMPDIPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	public float GIFPCFBLHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float3 OPCIBHCGCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float APCICELMCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private float DMONCOHFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	public float MALFDDNHAMM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D04670", Offset = "0x6D03A70", VA = "0x186D04670")]
	public FBALNOMKNLK(HLDAHBFGECP DGNMHOHHADI, JHEIAOJDPDC JIPKNCLPFGJ, JHEIAOJDPDC CEJICKOMFFD, float DMONCOHFCNL, float MALFDDNHAMM, Vector3 OPCIBHCGCFF, float APCICELMCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D032D0", Offset = "0x6D026D0", VA = "0x186D032D0")]
	private float3 DHBKBLJLJOH(int INBIGDGMENB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D030F0", Offset = "0x6D024F0", VA = "0x186D030F0")]
	private void AIOGGHEDJJL(int INBIGDGMENB, [Out] float3 JGKDLEOFEKO, [Out] float3 PLHLFAABFMO, [Out] float4 PBCKACDFHFA, [Out] float4 KHNKAFFOKCB, [Out] float2 HEHJNMGMKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D04070", Offset = "0x6D03470", VA = "0x186D04070")]
	private int KELHAHCHPAC(int LHKPJGHMDDN, int FJCHBPIGGBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D03380", Offset = "0x6D02780", VA = "0x186D03380")]
	private void EGEJOBLPKKO(int LHKPJGHMDDN, int FJCHBPIGGBJ, int HAEEDCMNINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D03F20", Offset = "0x6D03320", VA = "0x186D03F20")]
	private bool GABEMAGOHGB(int LHKPJGHMDDN, int FJCHBPIGGBJ, float IDCJKPOLOEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D04350", Offset = "0x6D03750", VA = "0x186D04350")]
	private bool ODCGGBGMBEL(int LHKPJGHMDDN, int FJCHBPIGGBJ, int HAEEDCMNINH, float IDCJKPOLOEP, bool JCJJPFGABMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D04410", Offset = "0x6D03810", VA = "0x186D04410")]
	private bool OFPCMLOBMKC(int LHKPJGHMDDN, int FJCHBPIGGBJ, int HAEEDCMNINH, float IDCJKPOLOEP, bool JCJJPFGABMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D03F00", Offset = "0x6D03300", VA = "0x186D03F00")]
	private void FBANFOKLDJH(int LHKPJGHMDDN, int FJCHBPIGGBJ, int HAEEDCMNINH, [Out] int CFHOLCJLOLE, [Out] int NMACKANAKLD, [Out] int MLFHKNNMGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D03580", Offset = "0x6D02980", VA = "0x186D03580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ECKCJGFJPPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class FPBMDPNCBOK : IDisposable, JFJBECMINEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Bounds DGIPNPAPPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public List<AGFDCDIOIJM> FMCKLIHFMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3 CBGEANBNEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Vector3 LDCBIHFHKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int MNMEBGIJODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JHEIAOJDPDC MHIMCACEIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long NBJCIGKIFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public HLDAHBFGECP BJBOHLEPCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Transform FINELPFBLOK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int CKPDMBNBDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6D074E0", Offset = "0x6D068E0", VA = "0x186D074E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh KHEMIOFNHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh CGKMAOLBHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PODEDHCIHCB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB81DB0", Offset = "0xB811B0", VA = "0x180B81DB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6348100", Offset = "0x6347500", VA = "0x186348100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte GPHHDJPKDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA4C600", Offset = "0xA4BA00", VA = "0x180A4C600")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA4C640", Offset = "0xA4BA40", VA = "0x180A4C640", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int EMMIMKJEDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x914870", Offset = "0x913C70", VA = "0x180914870", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x914860", Offset = "0x913C60", VA = "0x180914860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int JCOBCDAKFKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5F0", Offset = "0x9F99F0", VA = "0x1809FA5F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x11E5930", Offset = "0x11E4D30", VA = "0x1811E5930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float NNJKAJNMKEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6D071E0", Offset = "0x6D065E0", VA = "0x186D071E0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D06DB0", Offset = "0x6D061B0", VA = "0x186D06DB0")]
		public void APLDHMECPFF(HOEGHAPJAGH KFELJFNOKBH, [Out] int FOKPONIAEFG, [Out] int DBMNEEKDOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D07010", Offset = "0x6D06410", VA = "0x186D07010")]
		public void BPPKBJBKJNK(HOEGHAPJAGH KFELJFNOKBH, IGMDHOIMGAD NFMPKGPMOHC, int BICFOPHJEGF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D07440", Offset = "0x6D06840", VA = "0x186D07440")]
		public void LEPNOJEBDHO(Mesh JIPKNCLPFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D073B0", Offset = "0x6D067B0", VA = "0x186D073B0")]
		public void KNMLPCDEAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D07200", Offset = "0x6D06600", VA = "0x186D07200", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D07520", Offset = "0x6D06920", VA = "0x186D07520")]
		public FPBMDPNCBOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Bounds DGIPNPAPPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<FPBMDPNCBOK> KPLMCJOHFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public JEMANMEFHLP OKEBGLIGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ClusterMeshRenderer IMHKEPBHMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int GELKBNAIALB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh ADBEBIMNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F60", Offset = "0x8A9360", VA = "0x1808A9F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GHAIAKBIFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AABLPFIEBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D00DD0", Offset = "0x6D001D0", VA = "0x186D00DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D00C50", Offset = "0x6D00050", VA = "0x186D00C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D00E20", Offset = "0x6D00220", VA = "0x186D00E20")]
	public int EGOIPIIDMAL(int AOFBJCCLNJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D00A70", Offset = "0x6CFFE70", VA = "0x186D00A70")]
	public void CGJJHEOBHAC(AAHMHPBNHFB FLNJDACGDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D01470", Offset = "0x6D00870", VA = "0x186D01470")]
	public void JPAPHDONOBH(Transform LHMGKIHIEIJ, bool EJJOBIMMIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D008B0", Offset = "0x6CFFCB0", VA = "0x186D008B0")]
	public bool BNACBGHDHLI(bool GCPFJHHCGFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D00E50", Offset = "0x6D00250", VA = "0x186D00E50")]
	public void HNOALPHOEMN(Transform FINELPFBLOK, bool EJJOBIMMIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D01C00", Offset = "0x6D01000", VA = "0x186D01C00")]
	public bool MAHJHHAHNPL(AGFDCDIOIJM FCNHHPDOLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D01E70", Offset = "0x6D01270", VA = "0x186D01E70")]
	public ECKCJGFJPPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OMPKEENDBEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Queue<ECKCJGFJPPK.FPBMDPNCBOK> FGCOAKGPBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ECOBLCCHKLG EHJACOCENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<ECKCJGFJPPK.FPBMDPNCBOK> BEGKEIHBBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int BLPFJEALNJM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EE30", Offset = "0x6D0E230", VA = "0x186D0EE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F020", Offset = "0x6D0E420", VA = "0x186D0F020")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F600", Offset = "0x6D0EA00", VA = "0x186D0F600")]
	public void PJLPMKJIOFF(ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH, Transform FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F0A0", Offset = "0x6D0E4A0", VA = "0x186D0F0A0")]
	public void MAHJHHAHNPL(ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EEE0", Offset = "0x6D0E2E0", VA = "0x186D0EEE0")]
	private ECKCJGFJPPK.FPBMDPNCBOK FLCEBGJJDHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EA90", Offset = "0x6D0DE90", VA = "0x186D0EA90")]
	private bool BLAFGNNKJAA(ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F5A0", Offset = "0x6D0E9A0", VA = "0x186D0F5A0")]
	private void OEHMEFAEDIJ(ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EEB0", Offset = "0x6D0E2B0", VA = "0x186D0EEB0")]
	public bool EMDGCODJDMP(ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EB30", Offset = "0x6D0DF30", VA = "0x186D0EB30")]
	public bool BNOGHBKOPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EDC0", Offset = "0x6D0E1C0", VA = "0x186D0EDC0")]
	private ECKCJGFJPPK.FPBMDPNCBOK COBHHDIBHOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F280", Offset = "0x6D0E680", VA = "0x186D0F280")]
	public long NPEAGLDIKGO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F6C0", Offset = "0x6D0EAC0", VA = "0x186D0F6C0")]
	public OMPKEENDBEL()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LGGEIKEBCIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int OEEKNIGNOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int GIDOLFCKPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float AJPDFBJGPBM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<ECKCJGFJPPK> HOOMOCMHEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E9C0", Offset = "0x6D0DDC0", VA = "0x186D0E9C0")]
	public LGGEIKEBCIJ(int OEEKNIGNOBL, int GIDOLFCKPBI, float PLNHMPKODKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E910", Offset = "0x6D0DD10", VA = "0x186D0E910")]
	public void LPCLBAAHFIJ(IEPDMKKMNPF HBNAOADOGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E650", Offset = "0x6D0DA50", VA = "0x186D0E650")]
	private int HBCPANDPBGA(AAHMHPBNHFB ABBPLCKDHFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E700", Offset = "0x6D0DB00", VA = "0x186D0E700")]
	private void LPCLBAAHFIJ(AAHMHPBNHFB ABBPLCKDHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E410", Offset = "0x6D0D810", VA = "0x186D0E410")]
	private void DMCDDGMCALA(AAHMHPBNHFB ABBPLCKDHFH, ECKCJGFJPPK FCNIGEHAAKI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ClusterMeshRenderer : MonoBehaviour, OKKGJGFIPKI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HNNNJDJNGJH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
			[DebuggerHidden]
			public HNNNJDJNGJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B8E0", Offset = "0x6D0ACE0", VA = "0x186D0B8E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BAA0", Offset = "0x6D0AEA0", VA = "0x186D0BAA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B9F0", Offset = "0x6D0ADF0", VA = "0x186D0B9F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B9F0", Offset = "0x6D0ADF0", VA = "0x186D0B9F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int AABLPFIEBDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D00280", Offset = "0x6CFF680", VA = "0x186D00280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<JFJBECMINEM> PGOHMHBABMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D00260", Offset = "0x6CFF660", VA = "0x186D00260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> KPLMCJOHFJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ECKCJGFJPPK ADBEBIMNGOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public JGOKIBOEOGA CFGEOHAEHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(JGOKIBOEOGA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC70", Offset = "0x8AE070", VA = "0x1808AEC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool HHDFNBHNMHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2023DB0", Offset = "0x20231B0", VA = "0x182023DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEB20", Offset = "0x6CFDF20", VA = "0x186CFEB20")]
		public static ClusterMeshRenderer Create(ECKCJGFJPPK JIPKNCLPFGJ, ClusterMeshRenderer NLIHGEGMLLG, MeshFilter JGJNOMGHCFC, FHDOGMIMPJP FINELPFBLOK, JGOKIBOEOGA NHDCAJADCDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEE80", Offset = "0x6CFE280", VA = "0x186CFEE80", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF760", Offset = "0x6CFEB60", VA = "0x186CFF760", Slot = "9")]
		public bool TryRemoveClusterLODComponent(AGFDCDIOIJM FCNHHPDOLNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF510", Offset = "0x6CFE910", VA = "0x186CFF510")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF0F0", Offset = "0x6CFE4F0", VA = "0x186CFF0F0")]
		public void Init(ECKCJGFJPPK JIPKNCLPFGJ, MeshFilter JGJNOMGHCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEEE0", Offset = "0x6CFE2E0", VA = "0x186CFEEE0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF890", Offset = "0x6CFEC90", VA = "0x186CFF890", Slot = "7")]
		public void UpdateClusterDistances(Vector3 JMOAHJJIPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CFFB40", Offset = "0x6CFEF40", VA = "0x186CFFB40", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF070", Offset = "0x6CFE470", VA = "0x186CFF070")]
		[IteratorStateMachine(typeof(HNNNJDJNGJH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF5A0", Offset = "0x6CFE9A0", VA = "0x186CFF5A0")]
		public void SetupTagAndLayer(string KOHHCGEDHKD, int NHDCAJADCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CFF580", Offset = "0x6CFE980", VA = "0x186CFF580")]
		public bool Remove(AGFDCDIOIJM FCNHHPDOLNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MJPOIFNLBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int DCEHMIPCKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int IHLILPEDKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int DBMNEEKDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FOKPONIAEFG;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EA70", Offset = "0x6D0DE70", VA = "0x186D0EA70")]
	public MJPOIFNLBPJ(int IHLILPEDKCL, int DBMNEEKDOAB, int DCEHMIPCKJH, int FOKPONIAEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JEMANMEFHLP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<float3> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<int> HEBMEOPGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<int> FPDKGNJGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<MJPOIFNLBPJ> CADDKCJEDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<int> PILPKDKOAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float3> BDAIMOAGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<float> GJJPODBDDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public JobHandle LGCKIPFOBAH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CPCHKPINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB7150", Offset = "0xAB6550", VA = "0x180AB7150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB8510", Offset = "0xAB7910", VA = "0x180AB8510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C580", Offset = "0x6D0B980", VA = "0x186D0C580")]
	public void LHMGAKDCLGK(JHEIAOJDPDC KLGIKHJFFBM, NativeList<MJPOIFNLBPJ> CADDKCJEDAP, float BJGGPAGHNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C2F0", Offset = "0x6D0B6F0", VA = "0x186D0C2F0")]
	public void LAMINKHBBDA(Transform FINELPFBLOK, bool EJJOBIMMIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C010", Offset = "0x6D0B410", VA = "0x186D0C010")]
	public void BNACBGHDHLI(ECKCJGFJPPK IMHKEPBHMIM, bool GCPFJHHCGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C1B0", Offset = "0x6D0B5B0", VA = "0x186D0C1B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C2C0", Offset = "0x6D0B6C0", VA = "0x186D0C2C0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public JEMANMEFHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
public struct DHIBCGCLHIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	public NativeList<int> HEBMEOPGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<MJPOIFNLBPJ> KJDEGJLBPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeArray<int> PILPKDKOAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float3 OPCIBHCGCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<float3> BDAIMOAGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private NativeArray<float> GJJPODBDDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private bool EJJOBIMMIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float DPOOKBDINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float GGHCEDFGNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float KDCGIBPKEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeList<int> FPDKGNJGAIL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D007E0", Offset = "0x6CFFBE0", VA = "0x186D007E0")]
	public DHIBCGCLHIC(JEMANMEFHLP ANGGNPPIDDE, Vector3 OPCIBHCGCFF, bool EJJOBIMMIME, float DPOOKBDINGP, float GGHCEDFGNDM, float KDCGIBPKEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D002E0", Offset = "0x6CFF6E0", VA = "0x186D002E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AGFDCDIOIJM : OFBHAEBDFJC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds DDNHIHIDADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AAHMHPBNHFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<AGFDCDIOIJM> FMCKLIHFMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public AAHMHPBNHFB IIOPLDELPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public AAHMHPBNHFB KBABLIFLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public AAHMHPBNHFB HGBKPOCNLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public int FOKPONIAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Bounds DGIPNPAPPIP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CFBF60", Offset = "0x6CFB360", VA = "0x186CFBF60")]
	public AAHMHPBNHFB(List<AGFDCDIOIJM> FMCKLIHFMCG, [Optional] AAHMHPBNHFB IIOPLDELPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IEPDMKKMNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<AAHMHPBNHFB> JDJJOLEJLBP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AAHMHPBNHFB FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BAF0", Offset = "0x6D0AEF0", VA = "0x186D0BAF0")]
	public IEPDMKKMNPF(AAHMHPBNHFB FINELPFBLOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CCKJCIAKCPO
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BMCDCAGNKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int PKPIBHGLGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int FNDLJIDCCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int LFPGFJDMDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int AOJNBAOBILE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct PJAJBJPDAFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int LMOFFFDDJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float HFIBGLOMOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<AGFDCDIOIJM> FMCKLIHFMCG;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FC70", Offset = "0x6D0F070", VA = "0x186D0FC70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum LMEPPJPBMKA
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
	private BMCDCAGNKFK CIFHLEGLEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int JMDMHENFANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int OEEKNIGNOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int GIDOLFCKPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float PLNHMPKODKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float NEKBOMMGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Stack<AAHMHPBNHFB> NKCBOFIGPJL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IEPDMKKMNPF IKODJACMJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE1D0", Offset = "0x6CFD5D0", VA = "0x186CFE1D0")]
	public CCKJCIAKCPO(int OEEKNIGNOBL, int GIDOLFCKPBI, float PLNHMPKODKO, int JMDMHENFANJ, float NEKBOMMGBDC = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CFBFE0", Offset = "0x6CFB3E0", VA = "0x186CFBFE0")]
	public void AFOIDBDFKDO(List<AGFDCDIOIJM> FMCKLIHFMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC1B0", Offset = "0x6CFB5B0", VA = "0x186CFC1B0")]
	public bool CPACHBJEDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDDA0", Offset = "0x6CFD1A0", VA = "0x186CFDDA0")]
	private float HAMFAOLIFHG(Vector3 GOCGGGCOOLH, Vector3 GGBNJANNJDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDD80", Offset = "0x6CFD180", VA = "0x186CFDD80")]
	private float HAMFAOLIFHG(Vector3 MFKKELONDCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC220", Offset = "0x6CFB620", VA = "0x186CFC220")]
	private bool FBKNNMIDBCE(AAHMHPBNHFB IBHCHONIICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CFCC00", Offset = "0x6CFC000", VA = "0x186CFCC00")]
	private PJAJBJPDAFK FKDLIBJKGAC(List<AGFDCDIOIJM> MIPCOBIIAFH, LMEPPJPBMKA HOADLKPPEMG)
	{
		return default(PJAJBJPDAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDDF0", Offset = "0x6CFD1F0", VA = "0x186CFDDF0")]
	private void KAIBDAMIONI(List<AGFDCDIOIJM> FMCKLIHFMCG, Span<Vector3> BIHDOOAEMMB, Span<Vector3> MFKLOHKODGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class OODHGOKDDIP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FAA0", Offset = "0x6D0EEA0", VA = "0x186D0FAA0")]
	public static Bounds MJJHGJNNHPJ(List<AGFDCDIOIJM> FMCKLIHFMCG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F8D0", Offset = "0x6D0ECD0", VA = "0x186D0F8D0")]
	public static int MBFIPOJCFMC(List<AGFDCDIOIJM> FMCKLIHFMCG, HOEGHAPJAGH KFELJFNOKBH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ECOBLCCHKLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private JHEIAOJDPDC DCJBKMPPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JHEIAOJDPDC GMINEDOGBGC;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static JHEIAOJDPDC GCKAFFGPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private AJMMIHNBKJG ONIPMGKKBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IGMDHOIMGAD NFMPKGPMOHC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle LGCKIPFOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xACF2A0", Offset = "0xACE6A0", VA = "0x180ACF2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ECKCJGFJPPK.FPBMDPNCBOK IBHCHONIICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NGPJIOPGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1C3F480", Offset = "0x1C3E880", VA = "0x181C3F480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D01F30", Offset = "0x6D01330", VA = "0x186D01F30")]
	[PNBDIHKPGLO(BDADFFMLEGJ.ExitingPlayMode, 0)]
	private static void COLHEMOGMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D02050", Offset = "0x6D01450", VA = "0x186D02050")]
	public void LHMGAKDCLGK(ECKCJGFJPPK.FPBMDPNCBOK KJDEGJLBPFA, Transform CIHCBOPMENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D028E0", Offset = "0x6D01CE0", VA = "0x186D028E0")]
	public void NPHDLPPFEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D01FA0", Offset = "0x6D013A0", VA = "0x186D01FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D02010", Offset = "0x6D01410", VA = "0x186D02010")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D02F90", Offset = "0x6D02390", VA = "0x186D02F90")]
	public ECOBLCCHKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CMFIICLLEHG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 JIGEKEAEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PHCDFPAPJOP
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(PMKGFNIFFEC<string>.INNANANOCLO PGMPGDGKDEI, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LAGEJLMMAHI
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LAGEJLMMAHI DNDGECMLPNG(Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LAGEJLMMAHI FINPCGJDOCK(Action MDOOJHKFGMP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class IMKGNAPNKOA : LAGEJLMMAHI
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class FPFKKKEDNDO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public IMKGNAPNKOA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
				public FPFKKKEDNDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6D076C0", Offset = "0x6D06AC0", VA = "0x186D076C0")]
				internal void JCBJACEEBIP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6D07670", Offset = "0x6D06A70", VA = "0x186D07670")]
				internal void GFKFEBMJGHN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x6D07620", Offset = "0x6D06A20", VA = "0x186D07620")]
				internal void ACGELIPLCCG()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private Func<JobHandle> EGPDMBODCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private Action ABAKAOMJDJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action PBAFOLCODOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private NCDIBIOFPJA DCFEDBPLOBH;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action JMNBGHDKAAJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action FHIAIPAGPLD
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2C630", Offset = "0x5C2BA30", VA = "0x185C2C630", Slot = "4")]
			public LAGEJLMMAHI DNDGECMLPNG(Action MDOOJHKFGMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x67B3ED0", Offset = "0x67B32D0", VA = "0x1867B3ED0", Slot = "5")]
			public LAGEJLMMAHI FINPCGJDOCK(Action MDOOJHKFGMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
			public IMKGNAPNKOA(Func<JobHandle> KEMLHKJGOFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BBC0", Offset = "0x6D0AFC0", VA = "0x186D0BBC0")]
			public void EHNFAJDFHCN(Action CIDCMCMFNAJ, Action JMIGKFMGIEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BE80", Offset = "0x6D0B280", VA = "0x186D0BE80")]
			public void MAHJHHAHNPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JIEMNOGDOHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public LAGEJLMMAHI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public JIEMNOGDOHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D450", Offset = "0x6D0C850", VA = "0x186D0D450")]
			internal bool DBCMFHHBOPF(IMKGNAPNKOA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class ONPIFFOEAOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public IMKGNAPNKOA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ONPIFFOEAOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6D0F870", Offset = "0x6D0EC70", VA = "0x186D0F870")]
			internal void OCGNMAFCMCP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Queue<IMKGNAPNKOA> CBAHELBAJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<IMKGNAPNKOA> FKEIHBMFADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private GJOIDBBGEPO ABBLINBKGFP;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IHGHAHPCPLP MOBNEMCJHEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D460", Offset = "0x6D0C860", VA = "0x186D0D460")]
		public LAGEJLMMAHI Add(Func<JobHandle> KEMLHKJGOFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D790", Offset = "0x6D0CB90", VA = "0x186D0D790")]
		public void Remove(LAGEJLMMAHI LGCKIPFOBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D5C0", Offset = "0x6D0C9C0", VA = "0x186D0D5C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D970", Offset = "0x6D0CD70", VA = "0x186D0D970")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DBD0", Offset = "0x6D0CFD0", VA = "0x186D0DBD0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D5B0", Offset = "0x6D0C9B0", VA = "0x186D0D5B0")]
		[CompilerGenerated]
		private void ILLAGABLECM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NCDIBIOFPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCDIBIOFPJA DNDGECMLPNG(Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCDIBIOFPJA IKDKINGGEKB(Action MDOOJHKFGMP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCDIBIOFPJA FINPCGJDOCK(Action MDOOJHKFGMP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class EPNCPBKHDIP : NCDIBIOFPJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private JobHandle LHMJMMFBPLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Action ABAKAOMJDJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Action NHJKFKEOLHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private Action FHIAIPAGPLD;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool EAOCHOMFNBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x6D03040", Offset = "0x6D02440", VA = "0x186D03040")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x66DA0A0", Offset = "0x66D94A0", VA = "0x1866DA0A0", Slot = "4")]
			public NCDIBIOFPJA DNDGECMLPNG(Action MDOOJHKFGMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x66DA0C0", Offset = "0x66D94C0", VA = "0x1866DA0C0", Slot = "5")]
			public NCDIBIOFPJA IKDKINGGEKB(Action MDOOJHKFGMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x67B3ED0", Offset = "0x67B32D0", VA = "0x1867B3ED0", Slot = "6")]
			public NCDIBIOFPJA FINPCGJDOCK(Action MDOOJHKFGMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE8D0", VA = "0x180ACF4D0")]
			public EPNCPBKHDIP(JobHandle LHCCHENLPNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6D030A0", Offset = "0x6D024A0", VA = "0x186D030A0")]
			public void ONAFBBOMACN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6D03050", Offset = "0x6D02450", VA = "0x186D03050")]
			public void MAHJHHAHNPL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<EPNCPBKHDIP> NFDPOGNMLDN;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E0D0", Offset = "0x6D0D4D0", VA = "0x186D0E0D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DCB0", Offset = "0x6D0D0B0", VA = "0x186D0DCB0")]
		public NCDIBIOFPJA Add(JobHandle LHCCHENLPNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DFD0", Offset = "0x6D0D3D0", VA = "0x186D0DFD0")]
		public void Remove(NCDIBIOFPJA LGCKIPFOBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DE20", Offset = "0x6D0D220", VA = "0x186D0DE20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DD50", Offset = "0x6D0D150", VA = "0x186D0DD50")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0E210", Offset = "0x6D0D610", VA = "0x186D0E210")]
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
