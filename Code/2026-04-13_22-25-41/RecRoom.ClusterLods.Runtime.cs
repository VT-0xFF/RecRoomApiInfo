using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.Core;
using RecRoom.Core.Creation;
using RecRoom.DataStructures.Times;
using RecRoom.Foundation.Transforms;
using RecRoom.Initialization;
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
				[Cpp2IlInjected.Address(RVA = "0x974B850", Offset = "0x974A250", VA = "0x18974B850")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF214A0", Offset = "0xF1FEA0", VA = "0x180F214A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x974B810", Offset = "0x974A210", VA = "0x18974B810")]
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
		[Cpp2IlInjected.Address(RVA = "0x9743C00", Offset = "0x9742600", VA = "0x189743C00")]
		public LODSettings GetSettings(SystemLOD lod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9743BE0", Offset = "0x97425E0", VA = "0x189743BE0")]
		public int GetMaxNumActiveLOD0Verts()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9743B40", Offset = "0x9742540", VA = "0x189743B40")]
		public int GetDetailFromHalfSize(bool isNear, Vector3 halfSize)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9743C10", Offset = "0x9742610", VA = "0x189743C10")]
		public ClusterLODConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum RenderLayer
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
	public interface TSXNYQWGTLR
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetupClusterLOD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JSNKKZQNAPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int DXHYVLUZUUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IEnumerable<ZUGNFDBZRJY> JBFHUYOARFK
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
		void UpdateClusterDistances(Vector3 pos);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DestroyObject();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool TryRemoveClusterLODComponent(WRXGGXWBTEJ component);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ZUGNFDBZRJY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int PKKQGYCYNXR
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int TYISMKNPJSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float KAMMGLOXQPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float QSNFVHPQQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		byte GUMMAZSWVPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QSCJUPVBMYY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Invalid = -1,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Waiting,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			Collecting,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Generating,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Running
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class XJLZEEIYNEA : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public QSCJUPVBMYY DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int FGTGVDUICUB;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public XJLZEEIYNEA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9759330", Offset = "0x9757D30", VA = "0x189759330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x97592F0", Offset = "0x9757CF0", VA = "0x1897592F0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <CreateWorld>d__80 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public QSCJUPVBMYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public StackTimer<string>.PAADRJAOOOL worldStackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private StackTimer<string>.PAADRJAOOOL <waitForShapesTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9756810", Offset = "0x9755210", VA = "0x189756810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9758100", Offset = "0x9756B00", VA = "0x189758100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DWEMPTFFVMR : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public QSCJUPVBMYY DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public DWEMPTFFVMR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9748A70", Offset = "0x9747470", VA = "0x189748A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9748A30", Offset = "0x9747430", VA = "0x189748A30", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <StartCreateWorld>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public QSCJUPVBMYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public StackTimer<string>.PAADRJAOOOL stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private StackTimer<string>.PAADRJAOOOL <createWorldTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9758160", Offset = "0x9756B60", VA = "0x189758160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x97588F0", Offset = "0x97572F0", VA = "0x1897588F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int QXMSQNOIXTG = 3;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly TimeSpan IMDPIIYNHOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ClusterMeshRenderer AMNRJBEEJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MeshFilter KWWPHYEAMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject BYCWOIUTHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject UBPYVZIUTGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KRMHCZZLRUZ KRMHCZZLRUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<WRXGGXWBTEJ> UXWGKWQAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<WRXGGXWBTEJ> YZFYCSGMHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<WRXGGXWBTEJ> YIXFFCMFALT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int FSALXYUPDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private double PDVIGANHSPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long BILPXPODEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private long TGEIVHFMLYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private long ZZCKXPYMGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private long WDVTADDKJOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private State JJZVCVFNAMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<JSNKKZQNAPV>[] QIVOYIRFBJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<ZUGNFDBZRJY>[] DIZOVTCREMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CancellationTokenSource JTCQTPWQMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool ADIFAYIZOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private YDHSMJLFZLP EPNTHBGVHRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private YDHSMJLFZLP LFIPLRYGUQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int PMXCAQZWSGL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static QSCJUPVBMYY CUYIASSGSRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LOOJDVXPPDW LHQXDTZNNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly ZFYGOROBVQZ NEDWUSRDKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly MonoBehaviour WELLNSOJUSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Material SYXBJYCWDVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<Material> PUZSKXCSLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Material EUUDWDPLYMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<Material> GIAOYBDJKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[CompilerGenerated]
		private Action DUPYNLGBYQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool NZNTMXYTJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<TSXNYQWGTLR> GSMBLSERSDH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ClusterLODConfig FLRQZHWTRZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector3 HEQQODQGAXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1F174A0", Offset = "0x1F15EA0", VA = "0x181F174A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x95652C0", Offset = "0x9563CC0", VA = "0x1895652C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public State TTJHNYOEMCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18A7200", Offset = "0x18A5C00", VA = "0x1818A7200")]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x974EC60", Offset = "0x974D660", VA = "0x18974EC60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static QSCJUPVBMYY UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x974F4F0", Offset = "0x974DEF0", VA = "0x18974F4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static bool IMVEAZZOYNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x974DA60", Offset = "0x974C460", VA = "0x18974DA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool ZIFWBCBDKXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9750010", Offset = "0x974EA10", VA = "0x189750010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Vector3> MUQUXUOUGNS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x974FDB0", Offset = "0x974E7B0", VA = "0x18974FDB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x974D8F0", Offset = "0x974C2F0", VA = "0x18974D8F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9750BF0", Offset = "0x974F5F0", VA = "0x189750BF0")]
		public QSCJUPVBMYY(LOOJDVXPPDW a, ZFYGOROBVQZ b, ClusterLODConfig c, MonoBehaviour d, Material e, ClusterMeshRenderer f, MeshFilter g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x974DB60", Offset = "0x974C560", VA = "0x18974DB60")]
		private void BQORPSVAPMZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x974F6A0", Offset = "0x974E0A0", VA = "0x18974F6A0")]
		public void QWPDEWKNJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x974FE70", Offset = "0x974E870", VA = "0x18974FE70")]
		public void UpdateMaterials(Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x974E9F0", Offset = "0x974D3F0", VA = "0x18974E9F0")]
		public static NativeMesh.UnityMeshFormat EGAPGQRXLNX(NativeMesh.UnityMeshFormat a)
		{
			return default(NativeMesh.UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x974E620", Offset = "0x974D020", VA = "0x18974E620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x974F7C0", Offset = "0x974E1C0", VA = "0x18974F7C0")]
		public static void RIWMVOOVGCI(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x974F460", Offset = "0x974DE60", VA = "0x18974F460")]
		private void MLBBSYSGVQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x974EA80", Offset = "0x974D480", VA = "0x18974EA80")]
		private void EPVMUQLYFES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x974F320", Offset = "0x974DD20", VA = "0x18974F320")]
		private void MCZDQTOKFSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x974DFD0", Offset = "0x974C9D0", VA = "0x18974DFD0")]
		public void DAYYJSSVCDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x974EE20", Offset = "0x974D820", VA = "0x18974EE20")]
		[AsyncStateMachine(typeof(<StartCreateWorld>d__78))]
		public Task ITPVOBQBKKI(StackTimer<string>.PAADRJAOOOL a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x974EA10", Offset = "0x974D410", VA = "0x18974EA10")]
		[IteratorStateMachine(typeof(DWEMPTFFVMR))]
		private IEnumerator<NVIJVYVFXPY> ELVJMGVGPAV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x974FC90", Offset = "0x974E690", VA = "0x18974FC90")]
		[AsyncStateMachine(typeof(<CreateWorld>d__80))]
		private Task SHNDTFSLKWE(StackTimer<string>.PAADRJAOOOL a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x974F8C0", Offset = "0x974E2C0", VA = "0x18974F8C0")]
		public void RWKJCSRICIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x974F740", Offset = "0x974E140", VA = "0x18974F740")]
		public void RAFUSHLVFKS(IEnumerable<JSNKKZQNAPV> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9750710", Offset = "0x974F110", VA = "0x189750710")]
		public void XZBHKAIQPPL(IEnumerable<JSNKKZQNAPV> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97500D0", Offset = "0x974EAD0", VA = "0x1897500D0")]
		public List<ClusterMeshRenderer> XELVPWOEYXA(List<WRXGGXWBTEJ> a, RRTransform b, RenderLayer c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9750660", Offset = "0x974F060", VA = "0x189750660")]
		public void XWWQVONOSIZ(TSXNYQWGTLR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x974DCC0", Offset = "0x974C6C0", VA = "0x18974DCC0")]
		public bool CFPGUOVETKP(TSXNYQWGTLR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x974D9B0", Offset = "0x974C3B0", VA = "0x18974D9B0")]
		public void BEYQQXGLQJC(WRXGGXWBTEJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x974F540", Offset = "0x974DF40", VA = "0x18974F540")]
		public void OIACIDCODDM(ZUGNFDBZRJY a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x974EBE0", Offset = "0x974D5E0", VA = "0x18974EBE0")]
		public void GSCYHKTMABB(ZUGNFDBZRJY a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x974DD20", Offset = "0x974C720", VA = "0x18974DD20")]
		private void CMMDDYYPKZK(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x974DE60", Offset = "0x974C860", VA = "0x18974DE60")]
		private void CZKGEBNOAVV(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x974FFA0", Offset = "0x974E9A0", VA = "0x18974FFA0")]
		[IteratorStateMachine(typeof(XJLZEEIYNEA))]
		private IEnumerator<NVIJVYVFXPY> VPQXDNKJWXP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9750A10", Offset = "0x974F410", VA = "0x189750A10")]
		private int YRRZQTVOXGF(int a, int b, List<ZUGNFDBZRJY> c, byte d, int e, float f = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x974FAD0", Offset = "0x974E4D0", VA = "0x18974FAD0")]
		public void Remove(WRXGGXWBTEJ component)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x974F660", Offset = "0x974E060", VA = "0x18974F660")]
		public bool QUKYJFKLHLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xF6C380", Offset = "0xF6AD80", VA = "0x180F6C380")]
		public Material GYWTBPEKKMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x974ED90", Offset = "0x974D790", VA = "0x18974ED90")]
		public Material GYWTBPEKKMK(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xEFC480", Offset = "0xEFAE80", VA = "0x180EFC480")]
		public Material EWNXRZUOJUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x974EB50", Offset = "0x974D550", VA = "0x18974EB50")]
		public Material EWNXRZUOJUF(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x974F620", Offset = "0x974E020", VA = "0x18974F620")]
		public int PONGFHPCZYT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x974EF40", Offset = "0x974D940", VA = "0x18974EF40")]
		public (long, int) LNENOQQMYXH()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct ClusterLODMergeVertsJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private NativeArray<float3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private NativeArray<float4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private NativeArray<float4> materialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[ReadOnly]
		private NativeList<float3> origVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private float3 centerPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private float resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private NativeParallelMultiHashMap<int, int> vertexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private NativeArray<int> indexRemap;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97444C0", Offset = "0x9742EC0", VA = "0x1897444C0")]
		public ClusterLODMergeVertsJob(NativeMesh mesh, NativeList<float3> origVerts, NativeParallelMultiHashMap<int, int> vertexMap, NativeArray<int> indexRemap, Vector3 centerPos, float resolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9744460", Offset = "0x9742E60", VA = "0x189744460")]
		private int ZISYBYPKSTV(float3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9743C70", Offset = "0x9742670", VA = "0x189743C70")]
		private int DQDXUYAYSGB(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9743F60", Offset = "0x9742960", VA = "0x189743F60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DZDENMYJCWG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static NativeParallelMultiHashMap<int, int> OUSHVQNZYYA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NativeArray<int> NKAQNNIUYEB;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int QVXYLYWXFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NativeList<int> XLMGGTPJQVE;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9748CF0", Offset = "0x97476F0", VA = "0x189748CF0")]
		public void AOWWAEAXUCR(int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9748EF0", Offset = "0x97478F0", VA = "0x189748EF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public DZDENMYJCWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct InitSubdivideMeshData : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[ReadOnly]
		public NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NativeList<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x97490B0", Offset = "0x9747AB0", VA = "0x1897490B0")]
		public InitSubdivideMeshData(DZDENMYJCWG subdivideData, NativeMesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9748FC0", Offset = "0x97479C0", VA = "0x189748FC0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	public struct SubdivideMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[ReadOnly]
		private NativeList<float3> srcVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[ReadOnly]
		private NativeArray<float3> srcNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[ReadOnly]
		private NativeArray<float4> srcTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[ReadOnly]
		private NativeArray<float2> srcUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[ReadOnly]
		private NativeArray<float4> srcMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private NativeList<int> origIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NativeList<float3> newVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NativeArray<float3> newNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NativeArray<float4> newTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private NativeArray<float4> newMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NativeArray<float2> newUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private NativeList<int> newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[ReadOnly]
		private float maxEdgeSizeSq;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[ReadOnly]
		public float maxDistanceSq;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[ReadOnly]
		private float3 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[ReadOnly]
		private float maxEdgeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[ReadOnly]
		public float maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9752BC0", Offset = "0x97515C0", VA = "0x189752BC0")]
		public SubdivideMeshJob(DZDENMYJCWG subdiveData, NativeMesh mesh, NativeMesh additionalMesh, float maxEdgeSize, float maxDistance, Vector3 eyePos, float rootScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9752690", Offset = "0x9751090", VA = "0x189752690")]
		private float3 QMPDGNPVYPJ(int a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9751480", Offset = "0x974FE80", VA = "0x189751480")]
		private void CDSUHZAIKMC(int a, [Out] float3 b, [Out] float3 c, [Out] float4 d, [Out] float4 e, [Out] float2 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97516B0", Offset = "0x97500B0", VA = "0x1897516B0")]
		private int EGXUATQGUGT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97527B0", Offset = "0x97511B0", VA = "0x1897527B0")]
		private void RVAQRAVGWDZ(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9752A70", Offset = "0x9751470", VA = "0x189752A70")]
		private bool UFLJVFYVJAF(int a, int b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97529B0", Offset = "0x97513B0", VA = "0x1897529B0")]
		private bool TUOHSTIBNQQ(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9752410", Offset = "0x9750E10", VA = "0x189752410")]
		private bool OLTUKQCJDJR(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9752670", Offset = "0x9751070", VA = "0x189752670")]
		private void PKUVEQVFGGZ(int a, int b, int c, [Out] int d, [Out] int e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x97519B0", Offset = "0x97503B0", VA = "0x1897519B0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class TINOHVOICRJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class APVLPHXVARI : IDisposable, ZUGNFDBZRJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Bounds QVATAPWSADD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public List<WRXGGXWBTEJ> YPNUAKCNHVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Vector3 WFZRVYDVPPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Vector3 CVWPAKPMSXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int GKMGAVQCSDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public NativeMesh HNQTCSVPDQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public long CZIVNSWIAJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public DZDENMYJCWG JQVYYTUALQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeMesh.UnityMeshFormat COKSTRUFEZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Transform CNBVPAWZDFC;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int IQPWGRJJCSC
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9743110", Offset = "0x9741B10", VA = "0x189743110")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Mesh OPMBKKMPATH
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public NativeMesh.UnityMeshFormat FUOKNKZSDVM
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1D990", VA = "0x180D1EF90")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8280", VA = "0x180DE9880")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Mesh KFVDBIVQBLB
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2D70", VA = "0x180CF4370")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public NativeMesh.UnityMeshFormat VDBAITBDNSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD659C0", VA = "0x180D66FC0")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xD68130", Offset = "0xD66B30", VA = "0x180D68130")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float KAMMGLOXQPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x12B84C0", Offset = "0x12B6EC0", VA = "0x1812B84C0", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x14A8D00", Offset = "0x14A7700", VA = "0x1814A8D00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public byte GUMMAZSWVPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xD883C0", Offset = "0xD86DC0", VA = "0x180D883C0")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xD88420", Offset = "0xD86E20", VA = "0x180D88420", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public int PKKQGYCYNXR
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xED3CB0", Offset = "0xED26B0", VA = "0x180ED3CB0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2AB0370", Offset = "0x2AAED70", VA = "0x182AB0370")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public int TYISMKNPJSC
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x1290B00", Offset = "0x128F500", VA = "0x181290B00", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x18368B0", Offset = "0x18352B0", VA = "0x1818368B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public float QSNFVHPQQTX
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9743620", Offset = "0x9742020", VA = "0x189743620", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9743640", Offset = "0x9742040", VA = "0x189743640")]
			public void STXIVMQZIZD(SystemLOD a, [Out] int b, [Out] int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9743310", Offset = "0x9741D10", VA = "0x189743310")]
			public void EBYIWZCZFDL(SystemLOD a, GBYOZJZBVMA b, int c = -1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9743570", Offset = "0x9741F70", VA = "0x189743570")]
			public void LNESXIZXKVS(Mesh a, NativeMesh.UnityMeshFormat b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x97434E0", Offset = "0x9741EE0", VA = "0x1897434E0")]
			public void KLLWTIGDTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9743150", Offset = "0x9741B50", VA = "0x189743150", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x97438A0", Offset = "0x97422A0", VA = "0x1897438A0")]
			public APVLPHXVARI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Bounds QVATAPWSADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeMesh.UnityMeshFormat COKSTRUFEZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<APVLPHXVARI> HHYDTKFBKTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MJAJUQGJLZP WAVQKYCKHQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ClusterMeshRenderer VZNWCMOFUPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int LKEUAKHLEBE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Mesh PQHFGASYITH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool YNPBKVFFJRK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DAD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int DXHYVLUZUUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9752F60", Offset = "0x9751960", VA = "0x189752F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9752DB0", Offset = "0x97517B0", VA = "0x189752DB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9752F30", Offset = "0x9751930", VA = "0x189752F30")]
		public int ELTXQSPBHUP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9753A80", Offset = "0x9752480", VA = "0x189753A80")]
		public void OJWMBQPTWBR(QIXGKVLNYLI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9752FC0", Offset = "0x97519C0", VA = "0x189752FC0")]
		public void KPVJPAFFOFZ(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x97538E0", Offset = "0x97522E0", VA = "0x1897538E0")]
		public bool MTGLFHHRJQH(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9753F10", Offset = "0x9752910", VA = "0x189753F10")]
		public void VEXHFRUYGGE(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9753CA0", Offset = "0x97526A0", VA = "0x189753CA0")]
		public bool Remove(WRXGGXWBTEJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9754530", Offset = "0x9752F30", VA = "0x189754530")]
		public TINOHVOICRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class KRMHCZZLRUZ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Queue<TINOHVOICRJ.APVLPHXVARI> TVZHGCQLTRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private DQTVXIQRGHS CYMVPCISXUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly List<TINOHVOICRJ.APVLPHXVARI> YCJLCVAIJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int EIREJMEDYTM;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x974A9C0", Offset = "0x97493C0", VA = "0x18974A9C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x974A940", Offset = "0x9749340", VA = "0x18974A940")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x974A880", Offset = "0x9749280", VA = "0x18974A880")]
		public void Add(TINOHVOICRJ.APVLPHXVARI cluster, Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x974B050", Offset = "0x9749A50", VA = "0x18974B050")]
		public void Remove(TINOHVOICRJ.APVLPHXVARI cluster)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x974AAA0", Offset = "0x97494A0", VA = "0x18974AAA0")]
		private TINOHVOICRJ.APVLPHXVARI GBXRWWBGVQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x974B240", Offset = "0x9749C40", VA = "0x18974B240")]
		private bool SXGBUVFKQXO(TINOHVOICRJ.APVLPHXVARI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x974AF00", Offset = "0x9749900", VA = "0x18974AF00")]
		private void OZSNVHKUFHL(TINOHVOICRJ.APVLPHXVARI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x974B020", Offset = "0x9749A20", VA = "0x18974B020")]
		public bool RRYPLUESHQP(TINOHVOICRJ.APVLPHXVARI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x974B2E0", Offset = "0x9749CE0", VA = "0x18974B2E0")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x974AFB0", Offset = "0x97499B0", VA = "0x18974AFB0")]
		private TINOHVOICRJ.APVLPHXVARI QIJTPNQEIUT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x974ABE0", Offset = "0x97495E0", VA = "0x18974ABE0")]
		public long JZLEWEFCMMY()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x974B5D0", Offset = "0x9749FD0", VA = "0x18974B5D0")]
		public KRMHCZZLRUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class KAICEHTUPUM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int FXPHWJQIUVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int WOJNKSYDXVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float BACYBEQTQVP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<TINOHVOICRJ> XPCQJUHYANX
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x974A830", Offset = "0x9749230", VA = "0x18974A830")]
		public KAICEHTUPUM(int a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x974A780", Offset = "0x9749180", VA = "0x18974A780")]
		public void VCAPHOPQTHT(UHSGERKNWTQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x974A380", Offset = "0x9748D80", VA = "0x18974A380")]
		private int CWLNKVREESO(QIXGKVLNYLI a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x974A4D0", Offset = "0x9748ED0", VA = "0x18974A4D0")]
		private void VCAPHOPQTHT(QIXGKVLNYLI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x974A430", Offset = "0x9748E30", VA = "0x18974A430")]
		private void QTWSMDJAOMG(QIXGKVLNYLI a, TINOHVOICRJ b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, JSNKKZQNAPV
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MDNGYVBFTNA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private Renderer WMPZMAPHXNF
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public MDNGYVBFTNA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x974BF10", Offset = "0x974A910", VA = "0x18974BF10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x974BED0", Offset = "0x974A8D0", VA = "0x18974BED0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x974BE30", Offset = "0x974A830", VA = "0x18974BE30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> RTYKTYGTFUU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x974BE30", Offset = "0x974A830", VA = "0x18974BE30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int DXHYVLUZUUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9746170", Offset = "0x9744B70", VA = "0x189746170", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<ZUGNFDBZRJY> JBFHUYOARFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9746140", Offset = "0x9744B40", VA = "0x189746140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> HHYDTKFBKTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TINOHVOICRJ PQHFGASYITH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RenderLayer ODJRKSSMDQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCFAD50", Offset = "0xCF9750", VA = "0x180CFAD50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(RenderLayer);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCFAF30", Offset = "0xCF9930", VA = "0x180CFAF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool XXTGXUSCDTX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9746160", Offset = "0x9744B60", VA = "0x189746160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9744570", Offset = "0x9742F70", VA = "0x189744570")]
		public static ClusterMeshRenderer Create(TINOHVOICRJ mesh, ClusterMeshRenderer clusterMeshRendererPrefab, MeshFilter clusterPrefab, RRTransform root, RenderLayer layer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x97447F0", Offset = "0x97431F0", VA = "0x1897447F0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9745350", Offset = "0x9743D50", VA = "0x189745350", Slot = "9")]
		public bool TryRemoveClusterLODComponent(WRXGGXWBTEJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9745100", Offset = "0x9743B00", VA = "0x189745100")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9744D30", Offset = "0x9743730", VA = "0x189744D30")]
		public void Init(TINOHVOICRJ mesh, MeshFilter clusterPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9744850", Offset = "0x9743250", VA = "0x189744850")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9745540", Offset = "0x9743F40", VA = "0x189745540", Slot = "7")]
		public void UpdateClusterDistances(Vector3 pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x97457F0", Offset = "0x97441F0", VA = "0x1897457F0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9744CB0", Offset = "0x97436B0", VA = "0x189744CB0")]
		[IteratorStateMachine(typeof(MDNGYVBFTNA))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9745190", Offset = "0x9743B90", VA = "0x189745190")]
		public void SetupTagAndLayer(string tag, int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9745170", Offset = "0x9743B70", VA = "0x189745170")]
		public bool Remove(WRXGGXWBTEJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public ClusterMeshRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct MeshComponentInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int startVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int vertexCount;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x974D4B0", Offset = "0x974BEB0", VA = "0x18974D4B0")]
		public MeshComponentInfo(int startIndex, int indexCount, int startVertex, int vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MJAJUQGJLZP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeList<float3> GGIGNPEQYNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeList<int> XLMGGTPJQVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NativeList<int> KRZTVONMCWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NativeList<MeshComponentInfo> RBPJVNAUVXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NativeArray<int> EATSIRQCXYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NativeArray<float3> OGYOMYVUDGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NativeArray<float> RSWPQBWWVKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JobHandle GFDVTJYDVMR;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool CZNZYGZCSPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD71310", Offset = "0xD6FD10", VA = "0x180D71310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD70440", Offset = "0xD6EE40", VA = "0x180D70440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x974C550", Offset = "0x974AF50", VA = "0x18974C550")]
		public void WNCQWZWPKZY(NativeMesh a, NativeList<MeshComponentInfo> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x974C140", Offset = "0x974AB40", VA = "0x18974C140")]
		public void EVXEKHPSUJC(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x974C3C0", Offset = "0x974ADC0", VA = "0x18974C3C0")]
		public void MTGLFHHRJQH(TINOHVOICRJ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x974C040", Offset = "0x974AA40", VA = "0x18974C040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x974C020", Offset = "0x974AA20", VA = "0x18974C020")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public MJAJUQGJLZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[BurstCompile]
	public struct ClusterMeshUpdateJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[ReadOnly]
		public NativeList<int> origIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[ReadOnly]
		private NativeList<MeshComponentInfo> clusterInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[ReadOnly]
		private NativeArray<int> componentLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[ReadOnly]
		private float3 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[ReadOnly]
		private NativeArray<float3> triNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[ReadOnly]
		private NativeArray<float> triSizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[ReadOnly]
		private bool dynamicCluster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[ReadOnly]
		private float faceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[ReadOnly]
		private float meshScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[ReadOnly]
		private float distFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private NativeList<int> indices;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9746720", Offset = "0x9745120", VA = "0x189746720")]
		public ClusterMeshUpdateJob(MJAJUQGJLZP jobData, Vector3 eyePos, bool dynamicCluster, float faceFactor, float meshScale, float distFactor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x97461E0", Offset = "0x9744BE0", VA = "0x1897461E0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface WRXGGXWBTEJ : AWLHRHFUKFQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Bounds SMWNORVEFTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QIXGKVLNYLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public List<WRXGGXWBTEJ> YPNUAKCNHVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public QIXGKVLNYLI PMPLOCZDTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public QIXGKVLNYLI CCQDEDXRWQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public QIXGKVLNYLI CCAIMJPZUIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int VDNGNIFWGAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Bounds QVATAPWSADD;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x974D870", Offset = "0x974C270", VA = "0x18974D870")]
		public QIXGKVLNYLI(List<WRXGGXWBTEJ> a, [Optional] QIXGKVLNYLI b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UHSGERKNWTQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<QIXGKVLNYLI> LTAPXDGGCIF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public QIXGKVLNYLI OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9759160", Offset = "0x9757B60", VA = "0x189759160")]
		public UHSGERKNWTQ(QIXGKVLNYLI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class TRKMFKNOVRV
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct Stats
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int numOverSized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public int xSplits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public int ySplits;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public int zSplits;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct SplitResult : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int bestIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float bestVolume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public List<WRXGGXWBTEJ> components;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x9751420", Offset = "0x974FE20", VA = "0x189751420", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private enum Axis
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			X_AXIS,
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			Y_AXIS,
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Z_AXIS
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Stats OCPEPCCYERJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int GCQWZXIECUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int FXPHWJQIUVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int WOJNKSYDXVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private float YIDJDBSRCGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private float XQKSYOKRCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Stack<QIXGKVLNYLI> MBYQUINPUEO;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public UHSGERKNWTQ UXPFQQSVXBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9756770", Offset = "0x9755170", VA = "0x189756770")]
		public TRKMFKNOVRV(int a, int b, float c, int d, float e = 0.5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x97545F0", Offset = "0x9752FF0", VA = "0x1897545F0")]
		public void LNGSDVOOGKS(List<WRXGGXWBTEJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x97547F0", Offset = "0x97531F0", VA = "0x1897547F0")]
		public bool PENOPUXZZXJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9754880", Offset = "0x9753280", VA = "0x189754880")]
		private float PXCIZNZZNIC(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9754860", Offset = "0x9753260", VA = "0x189754860")]
		private float PXCIZNZZNIC(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9755810", Offset = "0x9754210", VA = "0x189755810")]
		private bool RMVTDBCVBIG(QIXGKVLNYLI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x97548D0", Offset = "0x97532D0", VA = "0x1897548D0")]
		private SplitResult RIHQYNIRPCF(List<WRXGGXWBTEJ> a, Axis b)
		{
			return default(SplitResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x97563D0", Offset = "0x9754DD0", VA = "0x1897563D0")]
		private void VOJEIGCDNUW(List<WRXGGXWBTEJ> a, NativeArray<Vector3> b, NativeArray<Vector3> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class NOCOBJPBKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x974D4D0", Offset = "0x974BED0", VA = "0x18974D4D0")]
		public static Bounds LRATSUGSHGF(List<WRXGGXWBTEJ> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x974D6A0", Offset = "0x974C0A0", VA = "0x18974D6A0")]
		public static int ULPBHGNXMON(List<WRXGGXWBTEJ> a, SystemLOD b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal class RYJRMDCBIBS
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate bool SupportsVertexCompression_000000F0$PostfixBurstDelegate(float4* materialIndices, int length);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal static class LSLWCETJXIQ
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private static IntPtr NZKQIURKCYJ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x974BB20", Offset = "0x974A520", VA = "0x18974BB20")]
			[BurstDiscard]
			private static void QGYXNOMWBVT(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x974BCB0", Offset = "0x974A6B0", VA = "0x18974BCB0")]
			private static IntPtr RVXPUZINCSJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x974B870", Offset = "0x974A270", VA = "0x18974B870")]
			public unsafe static bool Invoke(float4* materialIndices, int length)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9751410", Offset = "0x974FE10", VA = "0x189751410")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ClusterLODs.SupportsVertexCompression_000000F0$PostfixBurstDelegate))]
		public unsafe static bool SZWDNINSZTC(float4* a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9751340", Offset = "0x974FD40", VA = "0x189751340")]
		[BurstCompile]
		internal unsafe static bool KHVDVLFFTRV(float4* a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	public struct CompressVerticesJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[ReadOnly]
		private NativeList<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private NativeList<float3> Verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private NativeArray<float3> Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private NativeArray<float4> Tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private NativeArray<float4> MaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[WriteOnly]
		public NativeArray<bool> supportsVertexCompressionOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public NativeList<ushort> compressedIndexBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9746B30", Offset = "0x9745530", VA = "0x189746B30")]
		public CompressVerticesJob(NativeMesh resultMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x97467E0", Offset = "0x97451E0", VA = "0x1897467E0", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	public struct CompressVerticesWithSharedAdditionalMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[ReadOnly]
		private NativeList<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private NativeList<float3> Verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private NativeArray<float3> Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private NativeArray<float4> Tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private NativeArray<float4> MaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private NativeList<int> SharedAdditionalIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private NativeList<float3> SharedAdditionalVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private NativeArray<float3> SharedAdditionalNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private NativeArray<float4> SharedAdditionalTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private NativeArray<float4> SharedAdditionalMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private NativeArray<float2> SharedAdditionalUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[WriteOnly]
		public NativeArray<bool> supportsVertexCompressionOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public NativeList<ushort> compressedIndexBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9747160", Offset = "0x9745B60", VA = "0x189747160")]
		public CompressVerticesWithSharedAdditionalMeshJob(NativeMesh resultMesh, NativeMesh sharedAdditionalMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9746B90", Offset = "0x9745590", VA = "0x189746B90", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DQTVXIQRGHS : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private NativeMesh DOXALXRQSON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private NativeMesh FZWTTVIYKNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NativeArray<bool> SHKHYRIJSHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NativeList<ushort> EGMVCGYWFSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> TMLXZKSKFAR;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static NativeMesh GHDVGWWSQJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private JSCNPHTBQWJ SMQMCTHBUPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private GBYOZJZBVMA YAKQIQPBCCW;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JobHandle GFDVTJYDVMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF410", VA = "0x180F00A10")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xF00A30", Offset = "0xEFF430", VA = "0x180F00A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TINOHVOICRJ.APVLPHXVARI AWDGMKLWSUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DDFQWVDUOHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x21837B0", Offset = "0x21821B0", VA = "0x1821837B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9747BA0", Offset = "0x97465A0", VA = "0x189747BA0")]
		[RRPostPlayModeMethod(PostPlayModePhase.EnteredEditMode, 0)]
		private static void FXDMSSOPJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9747C20", Offset = "0x9746620", VA = "0x189747C20")]
		public void WNCQWZWPKZY(TINOHVOICRJ.APVLPHXVARI a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9747320", Offset = "0x9745D20", VA = "0x189747320")]
		public void ECVGDJOFIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9747250", Offset = "0x9745C50", VA = "0x189747250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9747210", Offset = "0x9745C10", VA = "0x189747210")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x97488D0", Offset = "0x97472D0", VA = "0x1897488D0")]
		public DQTVXIQRGHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface ZFYGOROBVQZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		Vector3 EyePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface LOOJDVXPPDW
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WaitForShapes(StackTimer<string>.PAADRJAOOOL worldStackTimer, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface ZMOIQOZATNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZMOIQOZATNA BCOSDPDPNYK(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZMOIQOZATNA VLSHHJUFHAL(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class YAZKNEBGDWQ : ZMOIQOZATNA
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class BBRTNTVYVYU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public Action SFHSTPEKUBR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public YAZKNEBGDWQ DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public Action UMHJAZHEOEF;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
				public BBRTNTVYVYU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x9743AF0", Offset = "0x97424F0", VA = "0x189743AF0")]
				internal void LCVZAAWKUDT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x9743AA0", Offset = "0x97424A0", VA = "0x189743AA0")]
				internal void LCQSCUCNKSK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x9743A50", Offset = "0x9742450", VA = "0x189743A50")]
				internal void LCLLFNIQBHB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private Func<JobHandle> NTTZTXPUKQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Action DPQCJWDZAWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action PMYHQXHKUJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private QWGMRBYEPLN AZXRDQBNYLR;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action HWBTSLATZOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action YMAQDYSEFWU
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE510", Offset = "0x2AFCF10", VA = "0x182AFE510", Slot = "4")]
			public ZMOIQOZATNA BCOSDPDPNYK(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x90392C0", Offset = "0x9037CC0", VA = "0x1890392C0", Slot = "5")]
			public ZMOIQOZATNA VLSHHJUFHAL(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
			public YAZKNEBGDWQ(Func<JobHandle> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x975A1D0", Offset = "0x9758BD0", VA = "0x18975A1D0")]
			public void Run(Action removeJob, Action startNext)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x975A040", Offset = "0x9758A40", VA = "0x18975A040")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public YAZKNEBGDWQ BDBJTQHONBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JobQueue DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9759290", Offset = "0x9757C90", VA = "0x189759290")]
			internal void GZFAWLHQMHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public ZMOIQOZATNA GFDVTJYDVMR;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x9759280", Offset = "0x9757C80", VA = "0x189759280")]
			internal bool UOSQUVZKUPI(YAZKNEBGDWQ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Queue<YAZKNEBGDWQ> DXEIZDKZSXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<YAZKNEBGDWQ> ELFWEXJKDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private YDHSMJLFZLP SVBCLBXAWBK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FQIMSMPJIOJ FQIMSMPJIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF2F30", VA = "0x180CF4530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x97490E0", Offset = "0x9747AE0", VA = "0x1897490E0")]
		public ZMOIQOZATNA Add(Func<JobHandle> createJob)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9749400", Offset = "0x9747E00", VA = "0x189749400")]
		public void Remove(ZMOIQOZATNA jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9749230", Offset = "0x9747C30", VA = "0x189749230", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x97495D0", Offset = "0x9747FD0", VA = "0x1897495D0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9749870", Offset = "0x9748270", VA = "0x189749870")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9749220", Offset = "0x9747C20", VA = "0x189749220")]
		[CompilerGenerated]
		private void LLPRFFIIMKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface QWGMRBYEPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QWGMRBYEPLN BCOSDPDPNYK(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		QWGMRBYEPLN ZUWLNBRIYEP(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QWGMRBYEPLN VLSHHJUFHAL(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, AWBPBYERTJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class AZSPCWAPUHL : QWGMRBYEPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private JobHandle TJSKHGAIJMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private Action DPQCJWDZAWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action XKRJFEUMZJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action YMAQDYSEFWU;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool SQVJFZTNKTD
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x97439F0", Offset = "0x97423F0", VA = "0x1897439F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5B42D20", Offset = "0x5B41720", VA = "0x185B42D20", Slot = "4")]
			public QWGMRBYEPLN BCOSDPDPNYK(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5B432F0", Offset = "0x5B41CF0", VA = "0x185B432F0", Slot = "5")]
			public QWGMRBYEPLN ZUWLNBRIYEP(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x90392C0", Offset = "0x9037CC0", VA = "0x1890392C0", Slot = "6")]
			public QWGMRBYEPLN VLSHHJUFHAL(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x10FB2E0", Offset = "0x10F9CE0", VA = "0x1810FB2E0")]
			public AZSPCWAPUHL(JobHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x97439A0", Offset = "0x97423A0", VA = "0x1897439A0")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9743A00", Offset = "0x9742400", VA = "0x189743A00")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private List<AZSPCWAPUHL> WZYDGJKWXNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly List<IDisposable> XUECSDLQMRF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DAD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9749E80", Offset = "0x9748880", VA = "0x189749E80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1465D80", Offset = "0x1464780", VA = "0x181465D80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9749940", Offset = "0x9748340", VA = "0x189749940")]
		public QWGMRBYEPLN Add(JobHandle job)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x974A1B0", Offset = "0x9748BB0", VA = "0x18974A1B0")]
		public void Remove(QWGMRBYEPLN jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9749CB0", Offset = "0x97486B0", VA = "0x189749CB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9749B00", Offset = "0x9748500", VA = "0x189749B00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9749A30", Offset = "0x9748430", VA = "0x189749A30")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x974A2B0", Offset = "0x9748CB0", VA = "0x18974A2B0")]
		public JobTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xD1B0D0", Offset = "0xD19AD0", VA = "0x180D1B0D0", Slot = "6")]
		private bool FSAWUCEYRAZ()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__752318198
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x975A4D0", Offset = "0x9758ED0", VA = "0x18975A4D0")]
	public static void JUZPHBOHHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x975A4C0", Offset = "0x9758EC0", VA = "0x18975A4C0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x97567D0", Offset = "0x97551D0", VA = "0x1897567D0")]
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
