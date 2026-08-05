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
				[Cpp2IlInjected.Address(RVA = "0x96964D0", Offset = "0x96958D0", VA = "0x1896964D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF1D750", Offset = "0xF1CB50", VA = "0x180F1D750")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9696490", Offset = "0x9695890", VA = "0x189696490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9689AF0", Offset = "0x9688EF0", VA = "0x189689AF0")]
		public LODSettings GetSettings(SystemLOD lod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9689AD0", Offset = "0x9688ED0", VA = "0x189689AD0")]
		public int GetMaxNumActiveLOD0Verts()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9689A30", Offset = "0x9688E30", VA = "0x189689A30")]
		public int GetDetailFromHalfSize(bool isNear, Vector3 halfSize)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9689B00", Offset = "0x9688F00", VA = "0x189689B00")]
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
	public interface OZXUPFPTEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetupClusterLOD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface XQYIDLVHFAZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int YOKGTQFXLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IEnumerable<CTCIWKAHEBC> AKJBDKXFQEC
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
		bool TryRemoveClusterLODComponent(UQOMZHAYZGX component);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CTCIWKAHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int SYWTEMTCHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int HTKWRUQOSRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float ZKFHGXEEOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float JRXZNORIYRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		byte CHJWAQPTUJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LDFKAXNIPXU : IDisposable
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
		private sealed class TMOEYHZDCNA : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public LDFKAXNIPXU IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int WZWZSLGVGQX;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public TMOEYHZDCNA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9699B20", Offset = "0x9698F20", VA = "0x189699B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x969A840", Offset = "0x9699C40", VA = "0x18969A840", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
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
			public LDFKAXNIPXU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public StackTimer<string>.OEAKSWPXIMF worldStackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private StackTimer<string>.OEAKSWPXIMF <waitForShapesTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x969A8C0", Offset = "0x9699CC0", VA = "0x18969A8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x969C1B0", Offset = "0x969B5B0", VA = "0x18969C1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PEXUVGCKCSL : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public LDFKAXNIPXU IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public PEXUVGCKCSL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9697E10", Offset = "0x9697210", VA = "0x189697E10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9698080", Offset = "0x9697480", VA = "0x189698080", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
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
			public LDFKAXNIPXU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public StackTimer<string>.OEAKSWPXIMF stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private StackTimer<string>.OEAKSWPXIMF <createWorldTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x969C210", Offset = "0x969B610", VA = "0x18969C210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x969C9A0", Offset = "0x969BDA0", VA = "0x18969C9A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int ALMEQUHNYSO = 3;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly TimeSpan REMVKWVTOUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ClusterMeshRenderer FEJTNHCTZFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MeshFilter MIKOKQEHJYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject KWEUCVRMCNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject JZXOYREIDJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GKGFQGYTHMD GKGFQGYTHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<UQOMZHAYZGX> FZHWJWACPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<UQOMZHAYZGX> TGKPRXIDCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<UQOMZHAYZGX> QZYJYZIIVPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EGEHNDZLXGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private double KNHDSXZPOTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long SYTZEZHUSPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private long ICKLPBCVZUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private long WPWQGYWSAXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private long JRLSTILHUAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private State MUKTTGVOUFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<XQYIDLVHFAZ>[] KMGXJPAECIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<CTCIWKAHEBC>[] XSGEXJJLCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CancellationTokenSource SSZKVMYBRUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool PYOTXUFSNHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private NDLSPIRTFEP ZBTHSEWBXHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NDLSPIRTFEP THCBVZZXEXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int GLJJVIVNCRL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static LDFKAXNIPXU AYDGKFWFJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly SMONZUQVBZQ WWARKSCJAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly ZBMNIBQLWLB WXSADSFGQNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly MonoBehaviour CVBNLUDNAUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Material RUIITUBGEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<Material> GHWXGJNHKIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Material ADISWHGEWZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<Material> QJCAMYHSMRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[CompilerGenerated]
		private Action IWEHODBFOHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool WUASAIFTTQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<OZXUPFPTEMF> VZEXGFEZQZN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ClusterLODConfig EQOYIAUZYKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector3 LYMKCYJXELZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1F19EE0", Offset = "0x1F192E0", VA = "0x181F19EE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x94ACCE0", Offset = "0x94AC0E0", VA = "0x1894ACCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public State FKUJDYVEEIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18B13D0", Offset = "0x18B07D0", VA = "0x1818B13D0")]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9694F10", Offset = "0x9694310", VA = "0x189694F10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static LDFKAXNIPXU LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9694010", Offset = "0x9693410", VA = "0x189694010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static bool XTRALLHEMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9695A90", Offset = "0x9694E90", VA = "0x189695A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool CVXWQPOAUEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9692A80", Offset = "0x9691E80", VA = "0x189692A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Vector3> OQWMEFOSKSG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9693F50", Offset = "0x9693350", VA = "0x189693F50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9695B80", Offset = "0x9694F80", VA = "0x189695B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9695D60", Offset = "0x9695160", VA = "0x189695D60")]
		public LDFKAXNIPXU(SMONZUQVBZQ a, ZBMNIBQLWLB b, ClusterLODConfig c, MonoBehaviour d, Material e, ClusterMeshRenderer f, MeshFilter g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9695170", Offset = "0x9694570", VA = "0x189695170")]
		private void VCROXXVWGKL(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96934A0", Offset = "0x96928A0", VA = "0x1896934A0")]
		public void BJWHFMSUYMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9695040", Offset = "0x9694440", VA = "0x189695040")]
		public void UpdateMaterials(Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9693180", Offset = "0x9692580", VA = "0x189693180")]
		public static NativeMesh.UnityMeshFormat AYEZINBQKOD(NativeMesh.UnityMeshFormat a)
		{
			return default(NativeMesh.UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9693540", Offset = "0x9692940", VA = "0x189693540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9693AE0", Offset = "0x9692EE0", VA = "0x189693AE0")]
		public static void HDTGXFMEJGC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9693A50", Offset = "0x9692E50", VA = "0x189693A50")]
		private void FTICVMGSLUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96946F0", Offset = "0x9693AF0", VA = "0x1896946F0")]
		private void MGFWHLTDVKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9695450", Offset = "0x9694850", VA = "0x189695450")]
		private void WWVSHVARZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9692B40", Offset = "0x9691F40", VA = "0x189692B40")]
		public void ARJYTKZXPVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9695330", Offset = "0x9694730", VA = "0x189695330")]
		[AsyncStateMachine(typeof(<StartCreateWorld>d__78))]
		public Task WPXIXQKKRIK(StackTimer<string>.OEAKSWPXIMF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9694B30", Offset = "0x9693F30", VA = "0x189694B30")]
		[IteratorStateMachine(typeof(PEXUVGCKCSL))]
		private IEnumerator<KHZACSYKHRO> OXPIXWIPVID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9694D60", Offset = "0x9694160", VA = "0x189694D60")]
		[AsyncStateMachine(typeof(<CreateWorld>d__80))]
		private Task STWVCQMPIHA(StackTimer<string>.OEAKSWPXIMF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96947C0", Offset = "0x9693BC0", VA = "0x1896947C0")]
		public void NWVKSGACJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9694670", Offset = "0x9693A70", VA = "0x189694670")]
		public void LFDDMXCSMHK(IEnumerable<XQYIDLVHFAZ> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96931A0", Offset = "0x96925A0", VA = "0x1896931A0")]
		public void BIEYBBQBLEP(IEnumerable<XQYIDLVHFAZ> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96940E0", Offset = "0x96934E0", VA = "0x1896940E0")]
		public List<ClusterMeshRenderer> LBAMNBMVHII(List<UQOMZHAYZGX> a, RRTransform b, RenderLayer c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9695C40", Offset = "0x9695040", VA = "0x189695C40")]
		public void ZTBHIIGWFFJ(OZXUPFPTEMF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96952D0", Offset = "0x96946D0", VA = "0x1896952D0")]
		public bool VEZGQMWSUUF(OZXUPFPTEMF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9695590", Offset = "0x9694990", VA = "0x189695590")]
		public void XCHWRIXAZNU(UQOMZHAYZGX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9694A50", Offset = "0x9693E50", VA = "0x189694A50")]
		public void NZGUTAOWYRS(CTCIWKAHEBC a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96949D0", Offset = "0x9693DD0", VA = "0x1896949D0")]
		public void NXYQAHUBUER(CTCIWKAHEBC a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9693910", Offset = "0x9692D10", VA = "0x189693910")]
		private void FIZOHXVAJQO(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9693DE0", Offset = "0x96931E0", VA = "0x189693DE0")]
		private void IYNDOCOMNGR(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9695640", Offset = "0x9694A40", VA = "0x189695640")]
		[IteratorStateMachine(typeof(TMOEYHZDCNA))]
		private IEnumerator<KHZACSYKHRO> XXOUBFNKJBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9693BE0", Offset = "0x9692FE0", VA = "0x189693BE0")]
		private int IIPFHSRRTHV(int a, int b, List<CTCIWKAHEBC> c, byte d, int e, float f = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9694BA0", Offset = "0x9693FA0", VA = "0x189694BA0")]
		public void Remove(UQOMZHAYZGX component)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9694060", Offset = "0x9693460", VA = "0x189694060")]
		public bool KHYGKSSIWOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xF65A40", Offset = "0xF64E40", VA = "0x180F65A40")]
		public Material IKNQWXCBCJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9693D50", Offset = "0x9693150", VA = "0x189693D50")]
		public Material IKNQWXCBCJG(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF11740", Offset = "0xF10B40", VA = "0x180F11740")]
		public Material UDEHLMXZKTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9694E80", Offset = "0x9694280", VA = "0x189694E80")]
		public Material UDEHLMXZKTB(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96940A0", Offset = "0x96934A0", VA = "0x1896940A0")]
		public int KTWWWIMQATH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96956B0", Offset = "0x9694AB0", VA = "0x1896956B0")]
		public (long, int) YEPTHERHVUD()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
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
		[Cpp2IlInjected.Address(RVA = "0x968A3B0", Offset = "0x96897B0", VA = "0x18968A3B0")]
		public ClusterLODMergeVertsJob(NativeMesh mesh, NativeList<float3> origVerts, NativeParallelMultiHashMap<int, int> vertexMap, NativeArray<int> indexRemap, Vector3 centerPos, float resolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x968A350", Offset = "0x9689750", VA = "0x18968A350")]
		private int URBZUTBLCAJ(float3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x968A060", Offset = "0x9689460", VA = "0x18968A060")]
		private int FPXSSHCEZHZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9689B60", Offset = "0x9688F60", VA = "0x189689B60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class YEZPKBBLYKA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static NativeParallelMultiHashMap<int, int> ZBRQKNRBTLI;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NativeArray<int> DKBKTHHCGUH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int TBXFUBLROBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NativeList<int> QYLRTKIRNTG;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x969F4E0", Offset = "0x969E8E0", VA = "0x18969F4E0")]
		public void BIZYEAMGFJB(int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x969F6D0", Offset = "0x969EAD0", VA = "0x18969F6D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public YEZPKBBLYKA()
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
		[Cpp2IlInjected.Address(RVA = "0x9690350", Offset = "0x968F750", VA = "0x189690350")]
		public InitSubdivideMeshData(YEZPKBBLYKA subdivideData, NativeMesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9690260", Offset = "0x968F660", VA = "0x189690260", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9699930", Offset = "0x9698D30", VA = "0x189699930")]
		public SubdivideMeshJob(YEZPKBBLYKA subdiveData, NativeMesh mesh, NativeMesh additionalMesh, float maxEdgeSize, float maxDistance, Vector3 eyePos, float rootScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9699730", Offset = "0x9698B30", VA = "0x189699730")]
		private float3 TMPAVJTJPPD(int a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x96990B0", Offset = "0x96984B0", VA = "0x1896990B0")]
		private void OPACCDDPZZG(int a, [Out] float3 b, [Out] float3 c, [Out] float4 d, [Out] float4 e, [Out] float2 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x96992E0", Offset = "0x96986E0", VA = "0x1896992E0")]
		private int RFWEAUBHWJT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x96981D0", Offset = "0x96975D0", VA = "0x1896981D0")]
		private void EDBRANBVSKB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x96995E0", Offset = "0x96989E0", VA = "0x1896995E0")]
		private bool SAHWZOWKAAP(int a, int b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9699850", Offset = "0x9698C50", VA = "0x189699850")]
		private bool UQENDIPMUAW(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9698E50", Offset = "0x9698250", VA = "0x189698E50")]
		private bool IMRCRXDIPJP(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9699910", Offset = "0x9698D10", VA = "0x189699910")]
		private void WXTGZYYTXLR(int a, int b, int c, [Out] int d, [Out] int e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x96983D0", Offset = "0x96977D0", VA = "0x1896983D0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GTXQWFRBAFL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class HDRMJNLFDYY : IDisposable, CTCIWKAHEBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Bounds YMSIDHFPQQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public List<UQOMZHAYZGX> DGTQWESWAEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Vector3 SIWRBTWJIRH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Vector3 UFXGAUHNHWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int IKPLSAATXJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public NativeMesh LAXEYYFZNRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public long KRYCJONODCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public YEZPKBBLYKA JJNXHYZPHAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeMesh.UnityMeshFormat FXWGQZVKEDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Transform JBSQCTQPIEC;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int YYPLHEZYOHW
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x968F9F0", Offset = "0x968EDF0", VA = "0x18968F9F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Mesh OWOXJGCPXOD
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public NativeMesh.UnityMeshFormat QBIOKLBRPOM
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xD24210", Offset = "0xD23610", VA = "0x180D24210")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xE09150", Offset = "0xE08550", VA = "0x180E09150")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Mesh OOWNSIUFPZH
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public NativeMesh.UnityMeshFormat OAHZONZZWVQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xD6C420", Offset = "0xD6B820", VA = "0x180D6C420")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xD6D6D0", Offset = "0xD6CAD0", VA = "0x180D6D6D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float ZKFHGXEEOJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x12C8E10", Offset = "0x12C8210", VA = "0x1812C8E10", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x14BC000", Offset = "0x14BB400", VA = "0x1814BC000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public byte CHJWAQPTUJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xD88A20", Offset = "0xD87E20", VA = "0x180D88A20")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xD88A80", Offset = "0xD87E80", VA = "0x180D88A80", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public int SYWTEMTCHBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xEE4740", Offset = "0xEE3B40", VA = "0x180EE4740", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x2AB5000", Offset = "0x2AB4400", VA = "0x182AB5000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public int HTKWRUQOSRS
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x1286E90", Offset = "0x1286290", VA = "0x181286E90", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x1840C40", Offset = "0x1840040", VA = "0x181840C40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public float JRXZNORIYRZ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x968F9D0", Offset = "0x968EDD0", VA = "0x18968F9D0", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x968FD20", Offset = "0x968F120", VA = "0x18968FD20")]
			public void SRYJBVOLODN(SystemLOD a, [Out] int b, [Out] int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x968FF90", Offset = "0x968F390", VA = "0x18968FF90")]
			public void YXWAIPTOUYD(SystemLOD a, KNJQHXKWQJI b, int c = -1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x968FC70", Offset = "0x968F070", VA = "0x18968FC70")]
			public void PNQSTCYVAFE(Mesh a, NativeMesh.UnityMeshFormat b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x968FBE0", Offset = "0x968EFE0", VA = "0x18968FBE0")]
			public void JMOCBQMDIXM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x968FA30", Offset = "0x968EE30", VA = "0x18968FA30", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9690160", Offset = "0x968F560", VA = "0x189690160")]
			public HDRMJNLFDYY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Bounds YMSIDHFPQQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeMesh.UnityMeshFormat FXWGQZVKEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<HDRMJNLFDYY> VFUMPISLDFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public KRTWJXRKUKL MMBVQXTVNJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ClusterMeshRenderer YYTJGPQWDSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int NSGXLDFEUUM;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Mesh QLORZUMUMRV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool SAPXUBRINMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD4E320", Offset = "0xD4D720", VA = "0x180D4E320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int YOKGTQFXLCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x968F280", Offset = "0x968E680", VA = "0x18968F280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x968E1F0", Offset = "0x968D5F0", VA = "0x18968E1F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x968E1C0", Offset = "0x968D5C0", VA = "0x18968E1C0")]
		public int AXTKYQRAKDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x968F6F0", Offset = "0x968EAF0", VA = "0x18968F6F0")]
		public void YKKTMMJOLBP(BTQWHHKZGXG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x968E970", Offset = "0x968DD70", VA = "0x18968E970")]
		public void FOHYUXKQVPH(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x968F550", Offset = "0x968E950", VA = "0x18968F550")]
		public bool WFDNEOXFSJD(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x968E370", Offset = "0x968D770", VA = "0x18968E370")]
		public void FHFPNIMPXOS(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x968F2E0", Offset = "0x968E6E0", VA = "0x18968F2E0")]
		public bool Remove(UQOMZHAYZGX component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x968F910", Offset = "0x968ED10", VA = "0x18968F910")]
		public GTXQWFRBAFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class GKGFQGYTHMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Queue<GTXQWFRBAFL.HDRMJNLFDYY> WWVAFSBZNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private LZUEHGHBIMO LMCXKCAGUIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly List<GTXQWFRBAFL.HDRMJNLFDYY> FUEJSFQOYKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int PAOGIOOWFFC;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x968D710", Offset = "0x968CB10", VA = "0x18968D710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x968D620", Offset = "0x968CA20", VA = "0x18968D620")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x968D560", Offset = "0x968C960", VA = "0x18968D560")]
		public void Add(GTXQWFRBAFL.HDRMJNLFDYY cluster, Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x968D960", Offset = "0x968CD60", VA = "0x18968D960")]
		public void Remove(GTXQWFRBAFL.HDRMJNLFDYY cluster)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x968D7F0", Offset = "0x968CBF0", VA = "0x18968D7F0")]
		private GTXQWFRBAFL.HDRMJNLFDYY JGPBGHFYQFZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x968DE30", Offset = "0x968D230", VA = "0x18968DE30")]
		private bool VIKHAWDAPXM(GTXQWFRBAFL.HDRMJNLFDYY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x968DED0", Offset = "0x968D2D0", VA = "0x18968DED0")]
		private void ZAFJGGAARIL(GTXQWFRBAFL.HDRMJNLFDYY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x968D930", Offset = "0x968CD30", VA = "0x18968D930")]
		public bool QLULCOTFYNH(GTXQWFRBAFL.HDRMJNLFDYY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x968DB50", Offset = "0x968CF50", VA = "0x18968DB50")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x968D6A0", Offset = "0x968CAA0", VA = "0x18968D6A0")]
		private GTXQWFRBAFL.HDRMJNLFDYY DFPFMJKJMRD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x968D240", Offset = "0x968C640", VA = "0x18968D240")]
		public long ADQAFOAACXY()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x968DF80", Offset = "0x968D380", VA = "0x18968DF80")]
		public GKGFQGYTHMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ZREMUWEZAXE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int BHUMQBSTJPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int IVMNOACNIRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float TOFJXHXEXMP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<GTXQWFRBAFL> OOJNYZCMFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x969FD40", Offset = "0x969F140", VA = "0x18969FD40")]
		public ZREMUWEZAXE(int a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x969FBE0", Offset = "0x969EFE0", VA = "0x18969FBE0")]
		public void RSFMPSTVTZB(CMOAXCTAWMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x969FC90", Offset = "0x969F090", VA = "0x18969FC90")]
		private int XEWKHIWGRKA(BTQWHHKZGXG a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x969F930", Offset = "0x969ED30", VA = "0x18969F930")]
		private void RSFMPSTVTZB(BTQWHHKZGXG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x969F890", Offset = "0x969EC90", VA = "0x18969F890")]
		private void NSQQBMNRLOU(BTQWHHKZGXG a, GTXQWFRBAFL b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, XQYIDLVHFAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DGJJYCPTHZC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int ZWVNFXOIPAU;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private Renderer FBANEXUHRMF
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public DGJJYCPTHZC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x968D050", Offset = "0x968C450", VA = "0x18968D050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x968D200", Offset = "0x968C600", VA = "0x18968D200", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x968D160", Offset = "0x968C560", VA = "0x18968D160", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> YYSOZQQKYFM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x968D160", Offset = "0x968C560", VA = "0x18968D160", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int YOKGTQFXLCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x968BFB0", Offset = "0x968B3B0", VA = "0x18968BFB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<CTCIWKAHEBC> AKJBDKXFQEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x968BF80", Offset = "0x968B380", VA = "0x18968BF80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> VFUMPISLDFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GTXQWFRBAFL QLORZUMUMRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RenderLayer LVILFNGZTVF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD01820", Offset = "0xD00C20", VA = "0x180D01820", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(RenderLayer);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD01480", Offset = "0xD00880", VA = "0x180D01480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool OLAAPDLTPUX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x968BFA0", Offset = "0x968B3A0", VA = "0x18968BFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x968A460", Offset = "0x9689860", VA = "0x18968A460")]
		public static ClusterMeshRenderer Create(GTXQWFRBAFL mesh, ClusterMeshRenderer clusterMeshRendererPrefab, MeshFilter clusterPrefab, RRTransform root, RenderLayer layer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x968A6D0", Offset = "0x9689AD0", VA = "0x18968A6D0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x968B210", Offset = "0x968A610", VA = "0x18968B210", Slot = "9")]
		public bool TryRemoveClusterLODComponent(UQOMZHAYZGX component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x968AFC0", Offset = "0x968A3C0", VA = "0x18968AFC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x968AC00", Offset = "0x968A000", VA = "0x18968AC00")]
		public void Init(GTXQWFRBAFL mesh, MeshFilter clusterPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x968A730", Offset = "0x9689B30", VA = "0x18968A730")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x968B380", Offset = "0x968A780", VA = "0x18968B380", Slot = "7")]
		public void UpdateClusterDistances(Vector3 pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x968B630", Offset = "0x968AA30", VA = "0x18968B630", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x968AB80", Offset = "0x9689F80", VA = "0x18968AB80")]
		[IteratorStateMachine(typeof(DGJJYCPTHZC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x968B050", Offset = "0x968A450", VA = "0x18968B050")]
		public void SetupTagAndLayer(string tag, int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x968B030", Offset = "0x968A430", VA = "0x18968B030")]
		public bool Remove(UQOMZHAYZGX component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
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
		[Cpp2IlInjected.Address(RVA = "0x9697CB0", Offset = "0x96970B0", VA = "0x189697CB0")]
		public MeshComponentInfo(int startIndex, int indexCount, int startVertex, int vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class KRTWJXRKUKL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeList<float3> KQPGLOHWLWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeList<int> QYLRTKIRNTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NativeList<int> MVSLMZUJDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NativeList<MeshComponentInfo> BURYBCCMKZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NativeArray<int> JITVNOOFSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NativeArray<float3> JPYXBRMTVDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NativeArray<float> HTETHXHFUBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JobHandle UQRSIJKHIJV;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PDOLUVAGPUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD75CE0", VA = "0x180D768E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD75860", Offset = "0xD74C60", VA = "0x180D75860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x96919C0", Offset = "0x9690DC0", VA = "0x1896919C0")]
		public void ORLMZSMEYLO(NativeMesh a, NativeList<MeshComponentInfo> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9691750", Offset = "0x9690B50", VA = "0x189691750")]
		public void OAVAIOIAPCS(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x96928F0", Offset = "0x9691CF0", VA = "0x1896928F0")]
		public void WFDNEOXFSJD(GTXQWFRBAFL a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9691650", Offset = "0x9690A50", VA = "0x189691650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9691630", Offset = "0x9690A30", VA = "0x189691630")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KRTWJXRKUKL()
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
		[Cpp2IlInjected.Address(RVA = "0x968C560", Offset = "0x968B960", VA = "0x18968C560")]
		public ClusterMeshUpdateJob(KRTWJXRKUKL jobData, Vector3 eyePos, bool dynamicCluster, float faceFactor, float meshScale, float distFactor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x968C020", Offset = "0x968B420", VA = "0x18968C020", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface UQOMZHAYZGX : WXXOSYJIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Bounds YKOWNTJGUCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BTQWHHKZGXG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public List<UQOMZHAYZGX> DGTQWESWAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public BTQWHHKZGXG SYLHKQLEBTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public BTQWHHKZGXG EMMCMPYVJLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BTQWHHKZGXG EMRJJWSSSXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int EVQYHILNRPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Bounds YMSIDHFPQQP;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9689890", Offset = "0x9688C90", VA = "0x189689890")]
		public BTQWHHKZGXG(List<UQOMZHAYZGX> a, [Optional] BTQWHHKZGXG b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class CMOAXCTAWMY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<BTQWHHKZGXG> YCPLIEHAKBR;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BTQWHHKZGXG XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9689910", Offset = "0x9688D10", VA = "0x189689910")]
		public CMOAXCTAWMY(BTQWHHKZGXG a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class UOYEDHIUTJP
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
			public List<UQOMZHAYZGX> components;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x9698170", Offset = "0x9697570", VA = "0x189698170", Slot = "4")]
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
		private Stats PASSAFVLGXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int KRJNPONOADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int BHUMQBSTJPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int IVMNOACNIRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private float OCEMSHEYTOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private float UQZBVSUXLUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Stack<BTQWHHKZGXG> LVUPHXGPHAM;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public CMOAXCTAWMY VHIKXUNIHQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x969EFF0", Offset = "0x969E3F0", VA = "0x18969EFF0")]
		public UOYEDHIUTJP(int a, int b, float c, int d, float e = 0.5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x969DB30", Offset = "0x969CF30", VA = "0x18969DB30")]
		public void PWDUXWLFJEY(List<UQOMZHAYZGX> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x969DAC0", Offset = "0x969CEC0", VA = "0x18969DAC0")]
		public bool JRSAHIYKOZP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x969DA70", Offset = "0x969CE70", VA = "0x18969DA70")]
		private float GCAJVJULOCQ(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x969DA50", Offset = "0x969CE50", VA = "0x18969DA50")]
		private float GCAJVJULOCQ(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x969CF00", Offset = "0x969C300", VA = "0x18969CF00")]
		private bool ENZTVRFDOAY(BTQWHHKZGXG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x969DD30", Offset = "0x969D130", VA = "0x18969DD30")]
		private SplitResult WRIEERVWBMP(List<UQOMZHAYZGX> a, Axis b)
		{
			return default(SplitResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x969EC50", Offset = "0x969E050", VA = "0x18969EC50")]
		private void XEEGCWHDQTO(List<UQOMZHAYZGX> a, NativeArray<Vector3> b, NativeArray<Vector3> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class ZUKJLOEHTCU
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x969FD90", Offset = "0x969F190", VA = "0x18969FD90")]
		public static Bounds BZHUCESJCKP(List<UQOMZHAYZGX> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x969FF60", Offset = "0x969F360", VA = "0x18969FF60")]
		public static int YEEZYEDMBHV(List<UQOMZHAYZGX> a, SystemLOD b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal class OQRPEJWJHLQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate bool SupportsVertexCompression_000000F0$PostfixBurstDelegate(float4* materialIndices, int length);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal static class AQAVWXBSQIG
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private static IntPtr LZCUBCGCEZV;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x96892E0", Offset = "0x96886E0", VA = "0x1896892E0")]
			[BurstDiscard]
			private static void DLIEWRUGLGL(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9689710", Offset = "0x9688B10", VA = "0x189689710")]
			private static IntPtr JTCUYQYXPHF()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9689470", Offset = "0x9688870", VA = "0x189689470")]
			public unsafe static bool Invoke(float4* materialIndices, int length)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9697D30", Offset = "0x9697130", VA = "0x189697D30")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ClusterLODs.SupportsVertexCompression_000000F0$PostfixBurstDelegate))]
		public unsafe static bool ELHODYMXRWS(float4* a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9697D40", Offset = "0x9697140", VA = "0x189697D40")]
		[BurstCompile]
		internal unsafe static bool XPKJYUWOKBH(float4* a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x968C970", Offset = "0x968BD70", VA = "0x18968C970")]
		public CompressVerticesJob(NativeMesh resultMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x968C620", Offset = "0x968BA20", VA = "0x18968C620", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x968CFA0", Offset = "0x968C3A0", VA = "0x18968CFA0")]
		public CompressVerticesWithSharedAdditionalMeshJob(NativeMesh resultMesh, NativeMesh sharedAdditionalMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x968C9D0", Offset = "0x968BDD0", VA = "0x18968C9D0", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class LZUEHGHBIMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private NativeMesh SQBASTIJIYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private NativeMesh YTXDOPKQNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NativeArray<bool> MCGIQSOMZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NativeList<ushort> YKOQQVBRTHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> VVNGGZJNNNZ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static NativeMesh DPNKUZOMDNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private ZQEPNKYGNTZ KYOOGHVLVZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private KNJQHXKWQJI MNBSLOHMVTC;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JobHandle UQRSIJKHIJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xF151D0", Offset = "0xF145D0", VA = "0x180F151D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public GTXQWFRBAFL.HDRMJNLFDYY JANZFKTIUKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OPHYJOWEXLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2184210", Offset = "0x2183610", VA = "0x182184210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9697AE0", Offset = "0x9696EE0", VA = "0x189697AE0")]
		[RRPostPlayModeMethod(PostPlayModePhase.EnteredEditMode, 0)]
		private static void SZBFTQPIWAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9696E60", Offset = "0x9696260", VA = "0x189696E60")]
		public void ORLMZSMEYLO(GTXQWFRBAFL.HDRMJNLFDYY a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9696600", Offset = "0x9695A00", VA = "0x189696600")]
		public void KVKLLXXHGZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9696530", Offset = "0x9695930", VA = "0x189696530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x96964F0", Offset = "0x96958F0", VA = "0x1896964F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9697B50", Offset = "0x9696F50", VA = "0x189697B50")]
		public LZUEHGHBIMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface ZBMNIBQLWLB
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
	public interface SMONZUQVBZQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WaitForShapes(StackTimer<string>.OEAKSWPXIMF worldStackTimer, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface AZLXICDJSIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AZLXICDJSIA KSRYDQJTEQQ(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AZLXICDJSIA FJNMGKTNRSJ(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class VTSPARLFKJM : AZLXICDJSIA
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class YSXXGNAWFKS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public Action LMYSAKDLEOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public VTSPARLFKJM IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public Action LDSKDQZZVJV;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public YSXXGNAWFKS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x969F7F0", Offset = "0x969EBF0", VA = "0x18969F7F0")]
				internal void HZKFFBMTDTZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x969F7A0", Offset = "0x969EBA0", VA = "0x18969F7A0")]
				internal void HZEYHUSVUIQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x969F840", Offset = "0x969EC40", VA = "0x18969F840")]
				internal void HZUSZPANWQR()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private Func<JobHandle> WAUSWCZHXBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Action CQAUFXHRLDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action RVXUWCBLVMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private MPQVEDFOYBX LGZPQMOHMQJ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action HHIMAPOWYKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action RMWQHIVBYVM
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF4B0", Offset = "0x2AFE8B0", VA = "0x182AFF4B0", Slot = "4")]
			public AZLXICDJSIA KSRYDQJTEQQ(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8F89630", Offset = "0x8F88A30", VA = "0x188F89630", Slot = "5")]
			public AZLXICDJSIA FJNMGKTNRSJ(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
			public VTSPARLFKJM(Func<JobHandle> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x969F1F0", Offset = "0x969E5F0", VA = "0x18969F1F0")]
			public void Run(Action removeJob, Action startNext)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x969F060", Offset = "0x969E460", VA = "0x18969F060")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class NCLLTQFRZHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public VTSPARLFKJM URTGLBZQNHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JobQueue IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public NCLLTQFRZHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9697CD0", Offset = "0x96970D0", VA = "0x189697CD0")]
			internal void RWVLIXDEPYU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class UQEFQITABRG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public AZLXICDJSIA UQRSIJKHIJV;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public UQEFQITABRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x969F050", Offset = "0x969E450", VA = "0x18969F050")]
			internal bool ESKRBSNQEQA(VTSPARLFKJM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Queue<VTSPARLFKJM> EFTERJKDSZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<VTSPARLFKJM> MGYYYXIEIWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private NDLSPIRTFEP YVKASOGXYPY;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ATROJJJVUTN ATROJJJVUTN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E50", Offset = "0xCF4250", VA = "0x180CF4E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9690380", Offset = "0x968F780", VA = "0x189690380")]
		public AZLXICDJSIA Add(Func<JobHandle> createJob)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x96906A0", Offset = "0x968FAA0", VA = "0x1896906A0")]
		public void Remove(AZLXICDJSIA jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x96904C0", Offset = "0x968F8C0", VA = "0x1896904C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9690870", Offset = "0x968FC70", VA = "0x189690870")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9690B10", Offset = "0x968FF10", VA = "0x189690B10")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9690690", Offset = "0x968FA90", VA = "0x189690690")]
		[CompilerGenerated]
		private void RULKJZYSXCJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface MPQVEDFOYBX
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MPQVEDFOYBX KSRYDQJTEQQ(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MPQVEDFOYBX RCLYWQKRDNP(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MPQVEDFOYBX FJNMGKTNRSJ(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, PBUFILHXHAU
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class QSAQGBLPNWH : MPQVEDFOYBX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private JobHandle SDWLSHDVSSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private Action CQAUFXHRLDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action NMHEVREKDPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action RMWQHIVBYVM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool FCMKGLSMPJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x9698160", Offset = "0x9697560", VA = "0x189698160")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7296810", Offset = "0x7295C10", VA = "0x187296810", Slot = "4")]
			public MPQVEDFOYBX KSRYDQJTEQQ(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x72961F0", Offset = "0x72955F0", VA = "0x1872961F0", Slot = "5")]
			public MPQVEDFOYBX RCLYWQKRDNP(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8F89630", Offset = "0x8F88A30", VA = "0x188F89630", Slot = "6")]
			public MPQVEDFOYBX FJNMGKTNRSJ(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x110C990", Offset = "0x110BD90", VA = "0x18110C990")]
			public QSAQGBLPNWH(JobHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x96980C0", Offset = "0x96974C0", VA = "0x1896980C0")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9698110", Offset = "0x9697510", VA = "0x189698110")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private List<QSAQGBLPNWH> CAMJSOYPGSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly List<IDisposable> XQTMOCTHXYR;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xD4E320", Offset = "0xD4D720", VA = "0x180D4E320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9691130", Offset = "0x9690530", VA = "0x189691130")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x146B080", Offset = "0x146A480", VA = "0x18146B080")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9690BE0", Offset = "0x968FFE0", VA = "0x189690BE0")]
		public MPQVEDFOYBX Add(JobHandle job)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9691460", Offset = "0x9690860", VA = "0x189691460")]
		public void Remove(MPQVEDFOYBX jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9690F50", Offset = "0x9690350", VA = "0x189690F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9690DA0", Offset = "0x96901A0", VA = "0x189690DA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9690CD0", Offset = "0x96900D0", VA = "0x189690CD0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9691560", Offset = "0x9690960", VA = "0x189691560")]
		public JobTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xD214F0", Offset = "0xD208F0", VA = "0x180D214F0", Slot = "6")]
		private bool XZHRBZXTEGD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1697942249
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x96A0140", Offset = "0x969F540", VA = "0x1896A0140")]
	public static void ZGEXVVNGJIY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x96A0130", Offset = "0x969F530", VA = "0x1896A0130")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x969A880", Offset = "0x9699C80", VA = "0x18969A880")]
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
