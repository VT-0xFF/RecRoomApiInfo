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
				[Cpp2IlInjected.Address(RVA = "0x81174B0", Offset = "0x81168B0", VA = "0x1881174B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xC6F7A0", Offset = "0xC6EBA0", VA = "0x180C6F7A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8117470", Offset = "0x8116870", VA = "0x188117470")]
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
		[Cpp2IlInjected.Address(RVA = "0x810F510", Offset = "0x810E910", VA = "0x18810F510")]
		public LODSettings GetSettings(SystemLOD lod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x810F4F0", Offset = "0x810E8F0", VA = "0x18810F4F0")]
		public int GetMaxNumActiveLOD0Verts()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x810F450", Offset = "0x810E850", VA = "0x18810F450")]
		public int GetDetailFromHalfSize(bool isNear, Vector3 halfSize)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x810F520", Offset = "0x810E920", VA = "0x18810F520")]
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
	public interface WKKVUWUQJCR
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetupClusterLOD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface LGCQDPTANXH
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int EXOSTBXGKFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IEnumerable<ULRQNHMURTG> NXLCZDJIQAW
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
		bool TryRemoveClusterLODComponent(OAJLDMDENHJ component);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ULRQNHMURTG
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int ECBFVXQNLZD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int KPIWHONIKQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float NBYFAUFCQZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float CXYIKJQXDCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		byte TAFNLCBCBCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MOWWKCWTWDE : IDisposable
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
		private sealed class YLBFWUHCMRE : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public MOWWKCWTWDE ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int GFEPCHZDYUT;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public YLBFWUHCMRE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8123D60", Offset = "0x8123160", VA = "0x188123D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8123D20", Offset = "0x8123120", VA = "0x188123D20", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
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
			public MOWWKCWTWDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public StackTimer<string>.MZHKLLPGBGJ worldStackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private StackTimer<string>.MZHKLLPGBGJ <waitForShapesTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x811F860", Offset = "0x811EC60", VA = "0x18811F860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8121150", Offset = "0x8120550", VA = "0x188121150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class WHPXMLITGCH : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public MOWWKCWTWDE ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public WHPXMLITGCH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x81222E0", Offset = "0x81216E0", VA = "0x1881222E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x81222A0", Offset = "0x81216A0", VA = "0x1881222A0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
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
			public MOWWKCWTWDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public StackTimer<string>.MZHKLLPGBGJ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private StackTimer<string>.MZHKLLPGBGJ <createWorldTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x81211B0", Offset = "0x81205B0", VA = "0x1881211B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8121940", Offset = "0x8120D40", VA = "0x188121940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int OBIWARLBUGC = 3;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly TimeSpan IDYYHSLTCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ClusterMeshRenderer VEYDVTJJXBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MeshFilter RUKUXHSZYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject NJWIYIVWLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject DFWRCJISSAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DHRPVIZZOBR DHRPVIZZOBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<OAJLDMDENHJ> DGPNODKDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<OAJLDMDENHJ> GWPAIMBQNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<OAJLDMDENHJ> IODQJTNCZLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int RTYTUAQGXXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private double FSFBGZTZTHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long GFBIYWBURLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private long CYKGPQZUPXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private long ANHRBXQTGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private long QSVXCOVYFCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private State IETVWXAISFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<LGCQDPTANXH>[] ZTSFPQGATDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<ULRQNHMURTG>[] KNEHFZEDKDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CancellationTokenSource BDDBNYWNQPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool MIYIMPVCDZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ARAECGCQSWT FBNTDXIAYTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ARAECGCQSWT TJBKDXIUYER;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int IGDUIPHBRLH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static MOWWKCWTWDE WKYSXCBTISI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly TTTCSOXJIHU QOWMNUPHMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly JVKGUURJXMP TSRYNVLMKRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly MonoBehaviour LGBIRLQQYXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Material FOGZXZVCHLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<Material> DEETDELWUHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Material FMGXADUEYOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<Material> GENVJNNHHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[CompilerGenerated]
		private Action GGWIWAIJYBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool MLZDHNHPEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<WKKVUWUQJCR> QOJDKWCOFTB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ClusterLODConfig SZDZOIBFIVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector3 ZZBZMFEJBAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1CFAEB0", Offset = "0x1CFA2B0", VA = "0x181CFAEB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F495B0", Offset = "0x7F489B0", VA = "0x187F495B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public State YQDLFVGMFKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15B1060", Offset = "0x15B0460", VA = "0x1815B1060")]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x811AE40", Offset = "0x811A240", VA = "0x18811AE40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static MOWWKCWTWDE ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x81196C0", Offset = "0x8118AC0", VA = "0x1881196C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static bool SJWNEKRPWZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8117F80", Offset = "0x8117380", VA = "0x188117F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool HSEOKXGQFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8119710", Offset = "0x8118B10", VA = "0x188119710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Vector3> HNZJURHFXDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8117D80", Offset = "0x8117180", VA = "0x188117D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8118D20", Offset = "0x8118120", VA = "0x188118D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x811B060", Offset = "0x811A460", VA = "0x18811B060")]
		public MOWWKCWTWDE(TTTCSOXJIHU a, JVKGUURJXMP b, ClusterLODConfig c, MonoBehaviour d, Material e, ClusterMeshRenderer f, MeshFilter g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81186D0", Offset = "0x8117AD0", VA = "0x1881186D0")]
		private void DYTEINQFWTV(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x811AB30", Offset = "0x8119F30", VA = "0x18811AB30")]
		public void UPYZQNZTTCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x811ABD0", Offset = "0x8119FD0", VA = "0x18811ABD0")]
		public void UpdateMaterials(Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81192C0", Offset = "0x81186C0", VA = "0x1881192C0")]
		public static NativeMesh.UnityMeshFormat KZJXEMHJECX(NativeMesh.UnityMeshFormat a)
		{
			return default(NativeMesh.UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8118830", Offset = "0x8117C30", VA = "0x188118830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8119810", Offset = "0x8118C10", VA = "0x188119810")]
		public static void OOYGDOTNGOC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x811ADB0", Offset = "0x811A1B0", VA = "0x18811ADB0")]
		private void XFZZRLLJDMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8118600", Offset = "0x8117A00", VA = "0x188118600")]
		private void DUXPNYZPHPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8117E40", Offset = "0x8117240", VA = "0x188117E40")]
		private void AGSXRINTVHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8119910", Offset = "0x8118D10", VA = "0x188119910")]
		public void ORQOZFBNHJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8118C00", Offset = "0x8118000", VA = "0x188118C00")]
		[AsyncStateMachine(typeof(<StartCreateWorld>d__78))]
		public Task EPJPVUOXMSW(StackTimer<string>.MZHKLLPGBGJ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8119570", Offset = "0x8118970", VA = "0x188119570")]
		[IteratorStateMachine(typeof(WHPXMLITGCH))]
		private IEnumerator<QAEGIZFUAOU> LJRWNUGDAVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81192E0", Offset = "0x81186E0", VA = "0x1881192E0")]
		[AsyncStateMachine(typeof(<CreateWorld>d__80))]
		private Task LBMZXVPHGHU(StackTimer<string>.MZHKLLPGBGJ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8119000", Offset = "0x8118400", VA = "0x188119000")]
		public void IMDIZCAIJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x811A6D0", Offset = "0x8119AD0", VA = "0x18811A6D0")]
		public void TDKRFHFBJGE(IEnumerable<LGCQDPTANXH> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8119F50", Offset = "0x8119350", VA = "0x188119F50")]
		public void OXWTXTFVIOT(IEnumerable<LGCQDPTANXH> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8118070", Offset = "0x8117470", VA = "0x188118070")]
		public List<ClusterMeshRenderer> BWSGMNGEKIQ(List<OAJLDMDENHJ> a, RRTransform b, RenderLayer c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x811AD00", Offset = "0x811A100", VA = "0x18811AD00")]
		public void WUPPYMLKTOT(WKKVUWUQJCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x811A250", Offset = "0x8119650", VA = "0x18811A250")]
		public bool PJAVWUIGHXX(WKKVUWUQJCR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8118DE0", Offset = "0x81181E0", VA = "0x188118DE0")]
		public void HYJPGTCBJES(OAJLDMDENHJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81195E0", Offset = "0x81189E0", VA = "0x1881195E0")]
		public void LLWHFJTGLUM(ULRQNHMURTG a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x811AF70", Offset = "0x811A370", VA = "0x18811AF70")]
		public void ZRZXWOBUSAN(ULRQNHMURTG a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x811A2B0", Offset = "0x81196B0", VA = "0x18811A2B0")]
		private void PLXYPHULJJA(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8119400", Offset = "0x8118800", VA = "0x188119400")]
		private void LHJWJNPGXUZ(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8119210", Offset = "0x8118610", VA = "0x188119210")]
		[IteratorStateMachine(typeof(YLBFWUHCMRE))]
		private IEnumerator<QAEGIZFUAOU> IVTCOKTWLXV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8118E90", Offset = "0x8118290", VA = "0x188118E90")]
		private int IGDNEHGPDUX(int a, int b, List<ULRQNHMURTG> c, byte d, int e, float f = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x811A510", Offset = "0x8119910", VA = "0x18811A510")]
		public void Remove(OAJLDMDENHJ component)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81197D0", Offset = "0x8118BD0", VA = "0x1881197D0")]
		public bool OOAZZPLTIOU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC97B80", Offset = "0xC96F80", VA = "0x180C97B80")]
		public Material PQKXMZADYIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x811A3F0", Offset = "0x81197F0", VA = "0x18811A3F0")]
		public Material PQKXMZADYIE(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC25060", Offset = "0xC24460", VA = "0x180C25060")]
		public Material RGDZQMNXYBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x811A480", Offset = "0x8119880", VA = "0x18811A480")]
		public Material RGDZQMNXYBB(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8119280", Offset = "0x8118680", VA = "0x188119280")]
		public int KXFVCIEVLKZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x811A750", Offset = "0x8119B50", VA = "0x18811A750")]
		public (long, int) TRXRMQBTCID()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
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
		[Cpp2IlInjected.Address(RVA = "0x810FDD0", Offset = "0x810F1D0", VA = "0x18810FDD0")]
		public ClusterLODMergeVertsJob(NativeMesh mesh, NativeList<float3> origVerts, NativeParallelMultiHashMap<int, int> vertexMap, NativeArray<int> indexRemap, Vector3 centerPos, float resolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x810F870", Offset = "0x810EC70", VA = "0x18810F870")]
		private int DMAEKVDRTBH(float3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x810F580", Offset = "0x810E980", VA = "0x18810F580")]
		private int BBHERWDOHIL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x810F8D0", Offset = "0x810ECD0", VA = "0x18810F8D0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class INCDSXGUEDK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static NativeParallelMultiHashMap<int, int> XTVQVRBZCKC;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NativeArray<int> KDVFHQGPATF;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int BOXCPGAHCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NativeList<int> CUOJQRASVSU;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8115500", Offset = "0x8114900", VA = "0x188115500")]
		public void SHATGCSKQPF(int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8115430", Offset = "0x8114830", VA = "0x188115430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public INCDSXGUEDK()
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
		[Cpp2IlInjected.Address(RVA = "0x81157E0", Offset = "0x8114BE0", VA = "0x1881157E0")]
		public InitSubdivideMeshData(INCDSXGUEDK subdivideData, NativeMesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81156F0", Offset = "0x8114AF0", VA = "0x1881156F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x811F630", Offset = "0x811EA30", VA = "0x18811F630")]
		public SubdivideMeshJob(INCDSXGUEDK subdiveData, NativeMesh mesh, NativeMesh additionalMesh, float maxEdgeSize, float maxDistance, Vector3 eyePos, float rootScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x811F2B0", Offset = "0x811E6B0", VA = "0x18811F2B0")]
		private float3 UQEDRCVFZLH(int a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x811EA10", Offset = "0x811DE10", VA = "0x18811EA10")]
		private void FDQWJFJGYDK(int a, [Out] float3 b, [Out] float3 c, [Out] float4 d, [Out] float4 e, [Out] float2 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x811EF90", Offset = "0x811E390", VA = "0x18811EF90")]
		private int IMBUAHCNXRL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x811ED90", Offset = "0x811E190", VA = "0x18811ED90")]
		private void IBPEXIYYWKF(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x811EC40", Offset = "0x811E040", VA = "0x18811EC40")]
		private bool FHJVIZUVJMP(int a, int b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x811DED0", Offset = "0x811D2D0", VA = "0x18811DED0")]
		private bool BRPSBFFCRBU(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x811F3D0", Offset = "0x811E7D0", VA = "0x18811F3D0")]
		private bool UQUVQROGDPP(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x811F290", Offset = "0x811E690", VA = "0x18811F290")]
		private void KXTVMASJODJ(int a, int b, int c, [Out] int d, [Out] int e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x811DF90", Offset = "0x811D390", VA = "0x18811DF90", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZMMFTUHMGQR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class JCPSJIODGII : IDisposable, ULRQNHMURTG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Bounds IYSJBXQHEBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public List<OAJLDMDENHJ> WZOUFBHBQWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Vector3 LREYDPXNZWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Vector3 UGWGTGFGVFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int KJVMPTCKGYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public NativeMesh ZAYBXJLLTDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public long OFHXNDBDPNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public INCDSXGUEDK MMRAZPMNUYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeMesh.UnityMeshFormat OTVSEAHMVEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Transform BRWFJBTAWNM;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int BGAGGUVVZQM
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x8115CD0", Offset = "0x81150D0", VA = "0x188115CD0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Mesh KHKTQFBYDED
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public NativeMesh.UnityMeshFormat JESIBFHVJQU
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xAD3250", Offset = "0xAD2650", VA = "0x180AD3250")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xB3ACC0", Offset = "0xB3A0C0", VA = "0x180B3ACC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Mesh OIKOXEBXPAV
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xAA9AB0", Offset = "0xAA8EB0", VA = "0x180AA9AB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public NativeMesh.UnityMeshFormat ENWYNFBRXMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xD14640", Offset = "0xD13A40", VA = "0x180D14640")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xD143D0", Offset = "0xD137D0", VA = "0x180D143D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float NBYFAUFCQZD
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xFF1540", Offset = "0xFF0940", VA = "0x180FF1540", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x11BE8C0", Offset = "0x11BDCC0", VA = "0x1811BE8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public byte TAFNLCBCBCV
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xD3CA50", Offset = "0xD3BE50", VA = "0x180D3CA50")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xD3B460", Offset = "0xD3A860", VA = "0x180D3B460", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public int ECBFVXQNLZD
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xBFA890", Offset = "0xBF9C90", VA = "0x180BFA890", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x27F2D90", Offset = "0x27F2190", VA = "0x1827F2D90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public int KPIWHONIKQA
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xFC8D60", Offset = "0xFC8160", VA = "0x180FC8D60", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x15608D0", Offset = "0x155FCD0", VA = "0x1815608D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public float CXYIKJQXDCX
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x8115D10", Offset = "0x8115110", VA = "0x188115D10", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8115D30", Offset = "0x8115130", VA = "0x188115D30")]
			public void XIPSJXMLNVZ(SystemLOD a, [Out] int b, [Out] int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8115B00", Offset = "0x8114F00", VA = "0x188115B00")]
			public void MIUFTZXMRXF(SystemLOD a, GXVAMBDUICC b, int c = -1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8115A50", Offset = "0x8114E50", VA = "0x188115A50")]
			public void LIEVMRVCRQO(Mesh a, NativeMesh.UnityMeshFormat b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8115810", Offset = "0x8114C10", VA = "0x188115810")]
			public void CFPNOFTQOWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x81158A0", Offset = "0x8114CA0", VA = "0x1881158A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8115FA0", Offset = "0x81153A0", VA = "0x188115FA0")]
			public JCPSJIODGII()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Bounds IYSJBXQHEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeMesh.UnityMeshFormat OTVSEAHMVEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<JCPSJIODGII> OWKWRMZTVEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HZTABBKVQFZ CQQUUPGDSLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ClusterMeshRenderer JRVTUZNDINT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int CXCKYCSAZFC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Mesh WTLRLNZKNCT
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool SMNDQOIQGGW
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAF9ED0", Offset = "0xAF92D0", VA = "0x180AF9ED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F40", Offset = "0xAF9340", VA = "0x180AF9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int EXOSTBXGKFR
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x81255C0", Offset = "0x81249C0", VA = "0x1881255C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8124A80", Offset = "0x8123E80", VA = "0x188124A80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81261A0", Offset = "0x81255A0", VA = "0x1881261A0")]
		public int TRGPHRSEXUJ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8125200", Offset = "0x8124600", VA = "0x188125200")]
		public void HFIMJQJPEER(SMOMURLOLNS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8125890", Offset = "0x8124C90", VA = "0x188125890")]
		public void TLRQQHFAHWV(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8125420", Offset = "0x8124820", VA = "0x188125420")]
		public bool IAWIQJIVWHD(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8124C00", Offset = "0x8124000", VA = "0x188124C00")]
		public void FNPIGEPVYZM(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8125620", Offset = "0x8124A20", VA = "0x188125620")]
		public bool Remove(OAJLDMDENHJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81261D0", Offset = "0x81255D0", VA = "0x1881261D0")]
		public ZMMFTUHMGQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DHRPVIZZOBR : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Queue<ZMMFTUHMGQR.JCPSJIODGII> WLWCMUNVNQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private YBESMAZSYBY SGLEBWDZUJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly List<ZMMFTUHMGQR.JCPSJIODGII> SIJFTATRGLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int PWUEXHXQQRC;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8112DA0", Offset = "0x81121A0", VA = "0x188112DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8112BE0", Offset = "0x8111FE0", VA = "0x188112BE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8112B20", Offset = "0x8111F20", VA = "0x188112B20")]
		public void Add(ZMMFTUHMGQR.JCPSJIODGII cluster, Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8112FC0", Offset = "0x81123C0", VA = "0x188112FC0")]
		public void Remove(ZMMFTUHMGQR.JCPSJIODGII cluster)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8112C60", Offset = "0x8112060", VA = "0x188112C60")]
		private ZMMFTUHMGQR.JCPSJIODGII DCFXFJPSYAX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8112EF0", Offset = "0x81122F0", VA = "0x188112EF0")]
		private bool JGISAQJLQHE(ZMMFTUHMGQR.JCPSJIODGII a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81137B0", Offset = "0x8112BB0", VA = "0x1881137B0")]
		private void XXQJMTIAGLN(ZMMFTUHMGQR.JCPSJIODGII a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8112F90", Offset = "0x8112390", VA = "0x188112F90")]
		public bool OBBADZEAAOB(ZMMFTUHMGQR.JCPSJIODGII a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81131B0", Offset = "0x81125B0", VA = "0x1881131B0")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8112E80", Offset = "0x8112280", VA = "0x188112E80")]
		private ZMMFTUHMGQR.JCPSJIODGII FDWPBVEMWNX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8113490", Offset = "0x8112890", VA = "0x188113490")]
		public long WAJOKYEYNAO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8113860", Offset = "0x8112C60", VA = "0x188113860")]
		public DHRPVIZZOBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class FBUDHSQOEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int YNZXABTAGJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int BPIKLGKDZMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float MIRKTRVDZMD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<ZMMFTUHMGQR> BJYTGYSMZDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8113F50", Offset = "0x8113350", VA = "0x188113F50")]
		public FBUDHSQOEGC(int a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8113EA0", Offset = "0x81132A0", VA = "0x188113EA0")]
		public void ZEQDRCUAETF(JLTBDUEGWZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8113AA0", Offset = "0x8112EA0", VA = "0x188113AA0")]
		private int HPQVAZHJJFO(SMOMURLOLNS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8113BF0", Offset = "0x8112FF0", VA = "0x188113BF0")]
		private void ZEQDRCUAETF(SMOMURLOLNS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8113B50", Offset = "0x8112F50", VA = "0x188113B50")]
		private void VHNAQSWXJHG(SMOMURLOLNS a, ZMMFTUHMGQR b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LGCQDPTANXH
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MDREQANESOY : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int LPLBTFNQDEY;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private Renderer PRQBZRKSNDL
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public MDREQANESOY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8117BC0", Offset = "0x8116FC0", VA = "0x188117BC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8117B80", Offset = "0x8116F80", VA = "0x188117B80", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8117AE0", Offset = "0x8116EE0", VA = "0x188117AE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> CEGXFSZBCNA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8117AE0", Offset = "0x8116EE0", VA = "0x188117AE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int EXOSTBXGKFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8111A80", Offset = "0x8110E80", VA = "0x188111A80", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<ULRQNHMURTG> NXLCZDJIQAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8111A50", Offset = "0x8110E50", VA = "0x188111A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> OWKWRMZTVEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ZMMFTUHMGQR WTLRLNZKNCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RenderLayer YUQWWHPOJVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9DC0", Offset = "0xAA91C0", VA = "0x180AA9DC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(RenderLayer);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AC0", Offset = "0xAA8EC0", VA = "0x180AA9AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KMYWCMEDNIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8111A70", Offset = "0x8110E70", VA = "0x188111A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x810FE80", Offset = "0x810F280", VA = "0x18810FE80")]
		public static ClusterMeshRenderer Create(ZMMFTUHMGQR mesh, ClusterMeshRenderer clusterMeshRendererPrefab, MeshFilter clusterPrefab, RRTransform root, RenderLayer layer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8110100", Offset = "0x810F500", VA = "0x188110100", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8110C60", Offset = "0x8110060", VA = "0x188110C60", Slot = "9")]
		public bool TryRemoveClusterLODComponent(OAJLDMDENHJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8110A10", Offset = "0x810FE10", VA = "0x188110A10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8110640", Offset = "0x810FA40", VA = "0x188110640")]
		public void Init(ZMMFTUHMGQR mesh, MeshFilter clusterPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8110160", Offset = "0x810F560", VA = "0x188110160")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8110E50", Offset = "0x8110250", VA = "0x188110E50", Slot = "7")]
		public void UpdateClusterDistances(Vector3 pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8111100", Offset = "0x8110500", VA = "0x188111100", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81105C0", Offset = "0x810F9C0", VA = "0x1881105C0")]
		[IteratorStateMachine(typeof(MDREQANESOY))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8110AA0", Offset = "0x810FEA0", VA = "0x188110AA0")]
		public void SetupTagAndLayer(string tag, int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8110A80", Offset = "0x810FE80", VA = "0x188110A80")]
		public bool Remove(OAJLDMDENHJ component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
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
		[Cpp2IlInjected.Address(RVA = "0x811B7A0", Offset = "0x811ABA0", VA = "0x18811B7A0")]
		public MeshComponentInfo(int startIndex, int indexCount, int startVertex, int vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class HZTABBKVQFZ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeList<float3> HYFOWPCAASW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeList<int> CUOJQRASVSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NativeList<int> UIIMOYXVLFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NativeList<MeshComponentInfo> PYDHHIAYBOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NativeArray<int> TUSKGTZNTBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NativeArray<float3> MYUBSUFDIZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NativeArray<float> JGOSHABBHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JobHandle TLDZVZKMJXZ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool NAFUZWRYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xBFA870", Offset = "0xBF9C70", VA = "0x180BFA870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD70160", Offset = "0xD6F560", VA = "0x180D70160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x81140D0", Offset = "0x81134D0", VA = "0x1881140D0")]
		public void HGSJECSPXBK(NativeMesh a, NativeList<MeshComponentInfo> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x81151C0", Offset = "0x81145C0", VA = "0x1881151C0")]
		public void JLQFWCDDHWW(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8115030", Offset = "0x8114430", VA = "0x188115030")]
		public void IAWIQJIVWHD(ZMMFTUHMGQR a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8113FD0", Offset = "0x81133D0", VA = "0x188113FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8113FB0", Offset = "0x81133B0", VA = "0x188113FB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public HZTABBKVQFZ()
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
		[Cpp2IlInjected.Address(RVA = "0x8112030", Offset = "0x8111430", VA = "0x188112030")]
		public ClusterMeshUpdateJob(HZTABBKVQFZ jobData, Vector3 eyePos, bool dynamicCluster, float faceFactor, float meshScale, float distFactor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8111AF0", Offset = "0x8110EF0", VA = "0x188111AF0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface OAJLDMDENHJ : IJRRPHFTTAI
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Bounds EIKQVMUVTIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SMOMURLOLNS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public List<OAJLDMDENHJ> WZOUFBHBQWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public SMOMURLOLNS ZXFWECNPPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public SMOMURLOLNS KCNYOZCBHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public SMOMURLOLNS KCTFMFVYQMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int KIMTNYYTKDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Bounds IYSJBXQHEBB;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x811DDF0", Offset = "0x811D1F0", VA = "0x18811DDF0")]
		public SMOMURLOLNS(List<OAJLDMDENHJ> a, [Optional] SMOMURLOLNS b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class JLTBDUEGWZS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<SMOMURLOLNS> TZVRERSFBYL;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public SMOMURLOLNS TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x81160A0", Offset = "0x81154A0", VA = "0x1881160A0")]
		public JLTBDUEGWZS(SMOMURLOLNS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class QVTYWKTVIYB
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
			public List<OAJLDMDENHJ> components;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x811DE70", Offset = "0x811D270", VA = "0x18811DE70", Slot = "4")]
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
		private Stats WXXYMHWNHOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int DZLHLVTUXKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int YNZXABTAGJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int BPIKLGKDZMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private float WWUOKMOYTSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private float ZKCKGVWNXHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Stack<SMOMURLOLNS> SAMSNKWKYSQ;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JLTBDUEGWZS SPLESXJJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x811DD90", Offset = "0x811D190", VA = "0x18811DD90")]
		public QVTYWKTVIYB(int a, int b, float c, int d, float e = 0.5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x811D710", Offset = "0x811CB10", VA = "0x18811D710")]
		public void NJPZQIDZOGU(List<OAJLDMDENHJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x811DD20", Offset = "0x811D120", VA = "0x18811DD20")]
		public bool ZBQTIDSHXJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x811DCD0", Offset = "0x811D0D0", VA = "0x18811DCD0")]
		private float WVMHUOBJQHS(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x811DCB0", Offset = "0x811D0B0", VA = "0x18811DCB0")]
		private float WVMHUOBJQHS(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x811BC40", Offset = "0x811B040", VA = "0x18811BC40")]
		private bool LGYVUEYWETG(SMOMURLOLNS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x811C800", Offset = "0x811BC00", VA = "0x18811C800")]
		private SplitResult MNEWBYAXCWD(List<OAJLDMDENHJ> a, Axis b)
		{
			return default(SplitResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x811D910", Offset = "0x811CD10", VA = "0x18811D910")]
		private void NNIVNUASRNK(List<OAJLDMDENHJ> a, NativeArray<Vector3> b, NativeArray<Vector3> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class CNBMJCNCCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x810F0B0", Offset = "0x810E4B0", VA = "0x18810F0B0")]
		public static Bounds LWHDOVNBESD(List<OAJLDMDENHJ> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x810F280", Offset = "0x810E680", VA = "0x18810F280")]
		public static int MHMYZYPIQTF(List<OAJLDMDENHJ> a, SystemLOD b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal class WBRGKNGVZPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate bool SupportsVertexCompression_000000F0$PostfixBurstDelegate(float4* materialIndices, int length);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal static class LVUGLMOSOCG
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private static IntPtr SFNQWWGNGJJ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x81174D0", Offset = "0x81168D0", VA = "0x1881174D0")]
			[BurstDiscard]
			private static void BLWLEECSSFF(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8117900", Offset = "0x8116D00", VA = "0x188117900")]
			private static IntPtr ONEWNOTNXCL()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8117660", Offset = "0x8116A60", VA = "0x188117660")]
			public unsafe static bool Invoke(float4* materialIndices, int length)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x81221C0", Offset = "0x81215C0", VA = "0x1881221C0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ClusterLODs.SupportsVertexCompression_000000F0$PostfixBurstDelegate))]
		public unsafe static bool PJKNCCBKLHM(float4* a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81221D0", Offset = "0x81215D0", VA = "0x1881221D0")]
		[BurstCompile]
		public unsafe static bool TLMGNNSHRSV(float4* a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x8112440", Offset = "0x8111840", VA = "0x188112440")]
		public CompressVerticesJob(NativeMesh resultMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x81120F0", Offset = "0x81114F0", VA = "0x1881120F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8112A70", Offset = "0x8111E70", VA = "0x188112A70")]
		public CompressVerticesWithSharedAdditionalMeshJob(NativeMesh resultMesh, NativeMesh sharedAdditionalMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x81124A0", Offset = "0x81118A0", VA = "0x1881124A0", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class YBESMAZSYBY : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private NativeMesh ZJDLYRNVJTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private NativeMesh KIYIUDVHWJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NativeArray<bool> UVJNDYGDQQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NativeList<ushort> WHBIEFLELBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> IQPZULZHAFB;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static NativeMesh QZZNWMGFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private VWHJQFJUDFZ PKTFHCAIWUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private GXVAMBDUICC QPPIEEJIGVG;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JobHandle TLDZVZKMJXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xC28720", Offset = "0xC27B20", VA = "0x180C28720")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xC28740", Offset = "0xC27B40", VA = "0x180C28740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public ZMMFTUHMGQR.JCPSJIODGII BCBSOGVQCWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TFIUIOYCAVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E857B0", Offset = "0x1E84BB0", VA = "0x181E857B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8123B50", Offset = "0x8122F50", VA = "0x188123B50")]
		[RRPostPlayModeMethod(PostPlayModePhase.EnteredEditMode, 0)]
		private static void RXQXWQJAFYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8122660", Offset = "0x8121A60", VA = "0x188122660")]
		public void HGSJECSPXBK(ZMMFTUHMGQR.JCPSJIODGII a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81232E0", Offset = "0x81226E0", VA = "0x1881232E0")]
		public void JGOLPUGJFUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8122590", Offset = "0x8121990", VA = "0x188122590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8122550", Offset = "0x8121950", VA = "0x188122550")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8123BC0", Offset = "0x8122FC0", VA = "0x188123BC0")]
		public YBESMAZSYBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface JVKGUURJXMP
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
	public interface TTTCSOXJIHU
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WaitForShapes(StackTimer<string>.MZHKLLPGBGJ worldStackTimer, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface FWEQBNOJHLS
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FWEQBNOJHLS JONIGSSTGLG(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FWEQBNOJHLS TQMMTJWXSQN(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class NIVUFHSGJVU : FWEQBNOJHLS
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class ZXQGLVKSKWS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public Action MFNCRMUFDFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public NIVUFHSGJVU ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public Action MROEMIWJSAX;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public ZXQGLVKSKWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x81262E0", Offset = "0x81256E0", VA = "0x1881262E0")]
				internal void LTCJOWMVUXB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x8126290", Offset = "0x8125690", VA = "0x188126290")]
				internal void LSXCRPSYLLS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8126330", Offset = "0x8125730", VA = "0x188126330")]
				internal void LTMXJKAQNTT()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private Func<JobHandle> CZFKTQIROFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Action CPBTUUXDNCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action VMQIHMOYYQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private WYUZDOABINT YDHNENKQBBP;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action PTNYJEZSVAY
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action ABSTXTXXWUS
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x283D2F0", Offset = "0x283C6F0", VA = "0x18283D2F0", Slot = "4")]
			public FWEQBNOJHLS JONIGSSTGLG(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7A35090", Offset = "0x7A34490", VA = "0x187A35090", Slot = "5")]
			public FWEQBNOJHLS TQMMTJWXSQN(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
			public NIVUFHSGJVU(Func<JobHandle> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x811B950", Offset = "0x811AD50", VA = "0x18811B950")]
			public void Run(Action removeJob, Action startNext)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x811B7C0", Offset = "0x811ABC0", VA = "0x18811B7C0")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LYTSFHXTFCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public NIVUFHSGJVU UDGAUCXLYDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JobQueue ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public LYTSFHXTFCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8117A80", Offset = "0x8116E80", VA = "0x188117A80")]
			internal void OBXOJYCDMNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class GEAWGGTCVVK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public FWEQBNOJHLS TLDZVZKMJXZ;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public GEAWGGTCVVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8113FA0", Offset = "0x81133A0", VA = "0x188113FA0")]
			internal bool PDMBQMLNZCU(NIVUFHSGJVU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Queue<NIVUFHSGJVU> XCFFDOLXLTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<NIVUFHSGJVU> EVMBDDTQBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ARAECGCQSWT XTAYWJSWVTI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public EVTHCUAIRNJ EVTHCUAIRNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAF000", Offset = "0xAAE400", VA = "0x180AAF000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81161C0", Offset = "0x81155C0", VA = "0x1881161C0")]
		public FWEQBNOJHLS Add(Func<JobHandle> createJob)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x81164E0", Offset = "0x81158E0", VA = "0x1881164E0")]
		public void Remove(FWEQBNOJHLS jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8116300", Offset = "0x8115700", VA = "0x188116300", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81166B0", Offset = "0x8115AB0", VA = "0x1881166B0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8116950", Offset = "0x8115D50", VA = "0x188116950")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81164D0", Offset = "0x81158D0", VA = "0x1881164D0")]
		[CompilerGenerated]
		private void PCBXZZUARLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface WYUZDOABINT
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WYUZDOABINT JONIGSSTGLG(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WYUZDOABINT DGFOEJVEZQV(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WYUZDOABINT TQMMTJWXSQN(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, BOJTUJLTPPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class MKXFOQRMTTR : WYUZDOABINT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private JobHandle ODLAWEOBLBX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private Action CPBTUUXDNCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action ETSKDGSDCUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action ABSTXTXXWUS;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool MTEWKTUNLIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8117D70", Offset = "0x8117170", VA = "0x188117D70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x794C750", Offset = "0x794BB50", VA = "0x18794C750", Slot = "4")]
			public WYUZDOABINT JONIGSSTGLG(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x794C770", Offset = "0x794BB70", VA = "0x18794C770", Slot = "5")]
			public WYUZDOABINT DGFOEJVEZQV(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7A35090", Offset = "0x7A34490", VA = "0x187A35090", Slot = "6")]
			public WYUZDOABINT TQMMTJWXSQN(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xE3DDD0", Offset = "0xE3D1D0", VA = "0x180E3DDD0")]
			public MKXFOQRMTTR(JobHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8117CD0", Offset = "0x81170D0", VA = "0x188117CD0")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8117D20", Offset = "0x8117120", VA = "0x188117D20")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private List<MKXFOQRMTTR> YTZTKIVMMTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly List<IDisposable> TACJBQRBHRT;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAF9ED0", Offset = "0xAF92D0", VA = "0x180AF9ED0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F40", Offset = "0xAF9340", VA = "0x180AF9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8116F70", Offset = "0x8116370", VA = "0x188116F70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1199840", Offset = "0x1198C40", VA = "0x181199840")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8116A20", Offset = "0x8115E20", VA = "0x188116A20")]
		public WYUZDOABINT Add(JobHandle job)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x81172A0", Offset = "0x81166A0", VA = "0x1881172A0")]
		public void Remove(WYUZDOABINT jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8116D90", Offset = "0x8116190", VA = "0x188116D90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8116BE0", Offset = "0x8115FE0", VA = "0x188116BE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8116B10", Offset = "0x8115F10", VA = "0x188116B10")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x81173A0", Offset = "0x81167A0", VA = "0x1881173A0")]
		public JobTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAD03D0", Offset = "0xACF7D0", VA = "0x180AD03D0", Slot = "6")]
		private bool WNYETKALIBJ()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4230234020
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8126390", Offset = "0x8125790", VA = "0x188126390")]
	public static void JRNZJIULILS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8126380", Offset = "0x8125780", VA = "0x188126380")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x811F820", Offset = "0x811EC20", VA = "0x18811F820")]
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
