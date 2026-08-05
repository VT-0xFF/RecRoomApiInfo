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
				[Cpp2IlInjected.Address(RVA = "0x88F6070", Offset = "0x88F4C70", VA = "0x1888F6070")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF9E0F0", Offset = "0xF9CCF0", VA = "0x180F9E0F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x88F6030", Offset = "0x88F4C30", VA = "0x1888F6030")]
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
		[Cpp2IlInjected.Address(RVA = "0x88EA7B0", Offset = "0x88E93B0", VA = "0x1888EA7B0")]
		public LODSettings GetSettings(SystemLOD lod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88EA790", Offset = "0x88E9390", VA = "0x1888EA790")]
		public int GetMaxNumActiveLOD0Verts()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88EA6F0", Offset = "0x88E92F0", VA = "0x1888EA6F0")]
		public int GetDetailFromHalfSize(bool isNear, Vector3 halfSize)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88EA7C0", Offset = "0x88E93C0", VA = "0x1888EA7C0")]
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
	public interface LSXIKPFJEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetupClusterLOD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BUUTGZGVJAC
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int JFEOGNIJOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IEnumerable<MDJFIBNSVQT> FKBCDBKRSSJ
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
		bool TryRemoveClusterLODComponent(UBHDCQVRLYE component);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MDJFIBNSVQT
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int WWRTUNIVLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int NNXGDLGWHSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float MGUYTBVICSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float GKILQRKMRWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		byte RWATATXZLVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class EXDKSGTAARV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum State
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

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class VBINOFDALDA : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public EXDKSGTAARV VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int NQOOLLHXSXS;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public VBINOFDALDA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88FCB60", Offset = "0x88FB760", VA = "0x1888FCB60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88FD850", Offset = "0x88FC450", VA = "0x1888FD850", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <CreateWorld>d__65 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public EXDKSGTAARV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public StackTimer<string>.YOQUQHZDBKW worldStackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private StackTimer<string>.YOQUQHZDBKW <waitForShapesTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88F8960", Offset = "0x88F7560", VA = "0x1888F8960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88FA1B0", Offset = "0x88F8DB0", VA = "0x1888FA1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class QDHZRMGDNTO : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public EXDKSGTAARV VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public QDHZRMGDNTO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x88F6970", Offset = "0x88F5570", VA = "0x1888F6970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x88F6AA0", Offset = "0x88F56A0", VA = "0x1888F6AA0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <StartCreateWorld>d__63 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public EXDKSGTAARV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private StackTimer<string>.YOQUQHZDBKW <createWorldTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x88FA210", Offset = "0x88F8E10", VA = "0x1888FA210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x88FA9A0", Offset = "0x88F95A0", VA = "0x1888FA9A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int QQWEIPAAMMT = 3;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly TimeSpan AYPPTFQKRIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ClusterMeshRenderer QCZADNJUQXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MeshFilter CZRTZPNAWVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject MRENALOOIRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject MBRVGKSVMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public VMFVWFPYPEC VMFVWFPYPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<UBHDCQVRLYE> HUTGKROWXHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<UBHDCQVRLYE> BLMKEOMKQTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<UBHDCQVRLYE> DJTXZLMEXKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EYHSGPOLGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private State QBKWPLYEOOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public List<BUUTGZGVJAC>[] FMIJXLMJLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<MDJFIBNSVQT>[] QSMRMVUBTJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private CancellationTokenSource MRCRDGRXGOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool MBMPWYNQFST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private GEUHFRHGIWS VWGSNUFXDRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GEUHFRHGIWS VUWWTMSBSCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int LVBBPFBECLS;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static EXDKSGTAARV FWICIAVHZHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly ERIUFZGMMLZ NQHUIGTMXGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly CPYSGJSUKBW VOIOXARTEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly MonoBehaviour MQYGWPJARDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Material GUKXVLDLZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private List<Material> EWZVRJTBTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Material UOXHLSGJRKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<Material> EUFMJJFTUEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[CompilerGenerated]
		private Action GPBLDCFXIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool TZOTJCCWKOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly List<LSXIKPFJEMK> JNTBATWEPWW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ClusterLODConfig JLJDOZDIUIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector3 NVVEEJRKXBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x88F2420", Offset = "0x88F1020", VA = "0x1888F2420")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x88F1A90", Offset = "0x88F0690", VA = "0x1888F1A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public State OHPRKDADPUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x10FC340", Offset = "0x10FAF40", VA = "0x1810FC340")]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x88F24F0", Offset = "0x88F10F0", VA = "0x1888F24F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static EXDKSGTAARV CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88F1DB0", Offset = "0x88F09B0", VA = "0x1888F1DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static bool EFBDLRWMTEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88F2A20", Offset = "0x88F1620", VA = "0x1888F2A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool SYXHNZDHXUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88F11A0", Offset = "0x88EFDA0", VA = "0x1888F11A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Vector3> ARZXRHFLSRR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88F0740", Offset = "0x88EF340", VA = "0x1888F0740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x88F3350", Offset = "0x88F1F50", VA = "0x1888F3350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88F3480", Offset = "0x88F2080", VA = "0x1888F3480")]
		public EXDKSGTAARV(ERIUFZGMMLZ a, CPYSGJSUKBW b, ClusterLODConfig c, MonoBehaviour d, Material e, ClusterMeshRenderer f, MeshFilter g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88F0D50", Offset = "0x88EF950", VA = "0x1888F0D50")]
		private void GRBEHIWJXJA(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88F21D0", Offset = "0x88F0DD0", VA = "0x1888F21D0")]
		public void RXIODYFTKBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88F28F0", Offset = "0x88F14F0", VA = "0x1888F28F0")]
		public void UpdateMaterials(Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88F1A70", Offset = "0x88F0670", VA = "0x1888F1A70")]
		public static NativeMesh.UnityMeshFormat MUEGIDLXHKA(NativeMesh.UnityMeshFormat a)
		{
			return default(NativeMesh.UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88F0800", Offset = "0x88EF400", VA = "0x1888F0800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88F0C50", Offset = "0x88EF850", VA = "0x1888F0C50")]
		public static void EZQTNRGHYLL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88F1880", Offset = "0x88F0480", VA = "0x1888F1880")]
		private void LKCTTCKDRTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88F0670", Offset = "0x88EF270", VA = "0x1888F0670")]
		private void DRBQSUURYQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88F0F40", Offset = "0x88EFB40", VA = "0x1888F0F40")]
		private void HSBRJFGMBWW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88F2B20", Offset = "0x88F1720", VA = "0x1888F2B20")]
		public void VQFHYVDTDUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88F2690", Offset = "0x88F1290", VA = "0x1888F2690")]
		[AsyncStateMachine(typeof(<StartCreateWorld>d__63))]
		public Task USIMACFXTLT(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88F2620", Offset = "0x88F1220", VA = "0x1888F2620")]
		[IteratorStateMachine(typeof(QDHZRMGDNTO))]
		private IEnumerator<UGECMBPSTCZ> UONTUAQIUOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88F1080", Offset = "0x88EFC80", VA = "0x1888F1080")]
		[AsyncStateMachine(typeof(<CreateWorld>d__65))]
		private Task IQYYIGNLTDJ(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88F1AA0", Offset = "0x88F06A0", VA = "0x1888F1AA0")]
		public void NRMWFZDTUDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88F0BD0", Offset = "0x88EF7D0", VA = "0x1888F0BD0")]
		public void EMGTRBKILQV(IEnumerable<BUUTGZGVJAC> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88F0280", Offset = "0x88EEE80", VA = "0x1888F0280")]
		public void BGWZNMEDWAY(IEnumerable<BUUTGZGVJAC> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88F12F0", Offset = "0x88EFEF0", VA = "0x1888F12F0")]
		public List<ClusterMeshRenderer> KMCBBEMTPDD(List<UBHDCQVRLYE> a, RRTransform b, RenderLayer c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88F2440", Offset = "0x88F1040", VA = "0x1888F2440")]
		public void UARVWEJGZSO(LSXIKPFJEMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88F1D50", Offset = "0x88F0950", VA = "0x1888F1D50")]
		public bool QDYKRDKIMJY(LSXIKPFJEMK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88F1CA0", Offset = "0x88F08A0", VA = "0x1888F1CA0")]
		public void OYEMMOSQGHR(UBHDCQVRLYE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88F01A0", Offset = "0x88EEDA0", VA = "0x1888F01A0")]
		public void BCJXLYFOSUH(MDJFIBNSVQT a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88F0580", Offset = "0x88EF180", VA = "0x1888F0580")]
		public void CUTHDHTKTNG(MDJFIBNSVQT a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88F27B0", Offset = "0x88F13B0", VA = "0x1888F27B0")]
		private void USXUZJDUGLL(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88F1910", Offset = "0x88F0510", VA = "0x1888F1910")]
		private void MPHAFCVXNSS(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88F0600", Offset = "0x88EF200", VA = "0x1888F0600")]
		[IteratorStateMachine(typeof(VBINOFDALDA))]
		private IEnumerator<UGECMBPSTCZ> DANXAZBLTCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88F3160", Offset = "0x88F1D60", VA = "0x1888F3160")]
		private int XLJIBUMDKEU(int a, int b, List<MDJFIBNSVQT> c, byte d, int e, float f = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88F2270", Offset = "0x88F0E70", VA = "0x1888F2270")]
		public void Remove(UBHDCQVRLYE component)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88F3310", Offset = "0x88F1F10", VA = "0x1888F3310")]
		public bool ZDNMUUGQQKX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBD4160", Offset = "0xBD2D60", VA = "0x180BD4160")]
		public Material HHFOFVPTSUT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88F0EB0", Offset = "0x88EFAB0", VA = "0x1888F0EB0")]
		public Material HHFOFVPTSUT(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB1B7A0", Offset = "0xB1A3A0", VA = "0x180B1B7A0")]
		public Material JRGMJSHJPCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88F1260", Offset = "0x88EFE60", VA = "0x1888F1260")]
		public Material JRGMJSHJPCO(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88F32D0", Offset = "0x88F1ED0", VA = "0x1888F32D0")]
		public int ZCDBRLZRKKS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88F1E00", Offset = "0x88F0A00", VA = "0x1888F1E00")]
		public (long, int) QWAFWFTTBTW()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct ClusterLODMergeVertsJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<float3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<float4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private NativeArray<float4> materialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NativeList<int> indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[ReadOnly]
		private NativeList<float3> origVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		private float3 centerPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private float resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private NativeParallelMultiHashMap<int, int> vertexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NativeArray<int> indexRemap;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88EB070", Offset = "0x88E9C70", VA = "0x1888EB070")]
		public ClusterLODMergeVertsJob(NativeMesh mesh, NativeList<float3> origVerts, NativeParallelMultiHashMap<int, int> vertexMap, NativeArray<int> indexRemap, Vector3 centerPos, float resolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88EAD20", Offset = "0x88E9920", VA = "0x1888EAD20")]
		private int GGQVHARYDTU(float3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88EAD80", Offset = "0x88E9980", VA = "0x1888EAD80")]
		private int IORJOQVTKBW(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88EA820", Offset = "0x88E9420", VA = "0x1888EA820", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MADKSOIZDAR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static NativeParallelMultiHashMap<int, int> PJPRIDSGZVB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static NativeArray<int> WUZBEWCVJQI;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static int BQMOASXWDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeList<int> LBJYMWWELZX;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88F6250", Offset = "0x88F4E50", VA = "0x1888F6250")]
		public void LGCZUKOKWZK(int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88F6180", Offset = "0x88F4D80", VA = "0x1888F6180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MADKSOIZDAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct InitSubdivideMeshData : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		public NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeList<int> destIndices;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88F4C70", Offset = "0x88F3870", VA = "0x1888F4C70")]
		public InitSubdivideMeshData(MADKSOIZDAR subdivideData, NativeMesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88F4B80", Offset = "0x88F3780", VA = "0x1888F4B80", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	public struct SubdivideMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[ReadOnly]
		private NativeList<float3> srcVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[ReadOnly]
		private NativeArray<float3> srcNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[ReadOnly]
		private NativeArray<float4> srcTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[ReadOnly]
		private NativeArray<float2> srcUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[ReadOnly]
		private NativeArray<float4> srcMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private NativeList<int> origIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NativeList<int> srcIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeList<float3> newVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NativeArray<float3> newNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private NativeArray<float4> newTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private NativeArray<float4> newMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private NativeArray<float2> newUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NativeList<int> newIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ReadOnly]
		private float maxEdgeSizeSq;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnly]
		public float maxDistanceSq;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnly]
		private float3 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnly]
		private float rootScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[ReadOnly]
		private float maxEdgeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[ReadOnly]
		public float maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88F82A0", Offset = "0x88F6EA0", VA = "0x1888F82A0")]
		public SubdivideMeshJob(MADKSOIZDAR subdiveData, NativeMesh mesh, NativeMesh additionalMesh, float maxEdgeSize, float maxDistance, Vector3 eyePos, float rootScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88F78C0", Offset = "0x88F64C0", VA = "0x1888F78C0")]
		private float3 FGVVDSMPNQQ(int a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88F7F90", Offset = "0x88F6B90", VA = "0x1888F7F90")]
		private void PXFMQIMAFTV(int a, [Out] float3 b, [Out] float3 c, [Out] float4 d, [Out] float4 e, [Out] float2 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88F6B40", Offset = "0x88F5740", VA = "0x1888F6B40")]
		private int ASAQGSPPMEK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88F7B30", Offset = "0x88F6730", VA = "0x1888F7B30")]
		private void NJRLZKGCBOA(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88F79E0", Offset = "0x88F65E0", VA = "0x1888F79E0")]
		private bool KTGKVLQZCZQ(int a, int b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88F81C0", Offset = "0x88F6DC0", VA = "0x1888F81C0")]
		private bool UBWRXODXZWD(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88F7D30", Offset = "0x88F6930", VA = "0x1888F7D30")]
		private bool PMMAMCUBLSQ(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88F8280", Offset = "0x88F6E80", VA = "0x1888F8280")]
		private void UQLMOEJFJJQ(int a, int b, int c, [Out] int d, [Out] int e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88F6E40", Offset = "0x88F5A40", VA = "0x1888F6E40", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UKZMEIVMGCY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class GDBWHJQQAMV : IDisposable, MDJFIBNSVQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Bounds FZCJFUVFILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public List<UBHDCQVRLYE> VJGCWUPFRCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public Vector3 NTJDTSLASOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Vector3 SIQZYDSNSOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int YXWLXHSKLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public NativeMesh ZXBHAENBQZB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public long PIAXWEGAUGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public MADKSOIZDAR XMTWHZAMOHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public NativeMesh.UnityMeshFormat GJUBWQZYSRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Transform PPGZRRIGXVH;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int XTRHZYSVTAL
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x88F4070", Offset = "0x88F2C70", VA = "0x1888F4070")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Mesh DQKBSFLVATQ
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public NativeMesh.UnityMeshFormat NYGINEFIHON
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB433A0", VA = "0x180B447A0")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xE76570", Offset = "0xE75170", VA = "0x180E76570")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Mesh RHZPEWPZQHE
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public NativeMesh.UnityMeshFormat FHNXLSJLYLL
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x104E340", Offset = "0x104CF40", VA = "0x18104E340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float MGUYTBVICSQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x1371CD0", Offset = "0x13708D0", VA = "0x181371CD0", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x1D83F30", Offset = "0x1D82B30", VA = "0x181D83F30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public byte RWATATXZLVA
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xDD5500", Offset = "0xDD4100", VA = "0x180DD5500")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xDD47D0", Offset = "0xDD33D0", VA = "0x180DD47D0", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public int WWRTUNIVLIG
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xF343D0", Offset = "0xF32FD0", VA = "0x180F343D0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x2D6DFD0", Offset = "0x2D6CBD0", VA = "0x182D6DFD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public int NNXGDLGWHSD
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x18E6FC0", Offset = "0x18E5BC0", VA = "0x1818E6FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public float GKILQRKMRWU
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x88F4050", Offset = "0x88F2C50", VA = "0x1888F4050", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x88F4140", Offset = "0x88F2D40", VA = "0x1888F4140")]
			public void NGLCVPQJPXU(SystemLOD a, [Out] int b, [Out] int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x88F3D70", Offset = "0x88F2970", VA = "0x1888F3D70")]
			public void EDPWXWTKRJG(SystemLOD a, BAEZTLIQVHX b, int c = -1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x88F43B0", Offset = "0x88F2FB0", VA = "0x1888F43B0")]
			public void UPLMNUQWHOZ(Mesh a, NativeMesh.UnityMeshFormat b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x88F40B0", Offset = "0x88F2CB0", VA = "0x1888F40B0")]
			public void JHVPJXJCNVZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x88F3BB0", Offset = "0x88F27B0", VA = "0x1888F3BB0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x88F3F40", Offset = "0x88F2B40", VA = "0x1888F3F40", Slot = "1")]
			~GDBWHJQQAMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x88F4460", Offset = "0x88F3060", VA = "0x1888F4460")]
			public GDBWHJQQAMV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Bounds FZCJFUVFILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NativeMesh.UnityMeshFormat GJUBWQZYSRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public List<GDBWHJQQAMV> TQGGMVDAIZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public VMVGBNDPTIQ VJBVLMAKUVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public ClusterMeshRenderer TPGTEFQVGCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int EDDHOQFKAGD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Mesh TZGQPRMHTPC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool UMCSRPBLTVV
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int JFEOGNIJOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x88FB3A0", Offset = "0x88F9FA0", VA = "0x1888FB3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x88FB220", Offset = "0x88F9E20", VA = "0x1888FB220", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88FB400", Offset = "0x88FA000", VA = "0x1888FB400", Slot = "1")]
		~UKZMEIVMGCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88FCA70", Offset = "0x88FB670", VA = "0x1888FCA70")]
		public int ZYYNOTYVPQW(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88FBF30", Offset = "0x88FAB30", VA = "0x1888FBF30")]
		public void ZIWFJJJTHMO(XQVCWMXGMUN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88FC150", Offset = "0x88FAD50", VA = "0x1888FC150")]
		public void ZSVYBJJSCEI(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88FB780", Offset = "0x88FA380", VA = "0x1888FB780")]
		public bool WGLWXRMITBY(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88FB920", Offset = "0x88FA520", VA = "0x1888FB920")]
		public void XJKMYDHYXMF(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88FB510", Offset = "0x88FA110", VA = "0x1888FB510")]
		public bool Remove(UBHDCQVRLYE component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88FCAA0", Offset = "0x88FB6A0", VA = "0x1888FCAA0")]
		public UKZMEIVMGCY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class VMFVWFPYPEC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Queue<UKZMEIVMGCY.GDBWHJQQAMV> QABQXARITUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private BBVBSPWGVOZ UHZIBVELQEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly List<UKZMEIVMGCY.GDBWHJQQAMV> CBKZHINIQIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int CPWUCSNBTFV;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88FDA00", Offset = "0x88FC600", VA = "0x1888FDA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88FD980", Offset = "0x88FC580", VA = "0x1888FD980")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x88FD8C0", Offset = "0x88FC4C0", VA = "0x1888FD8C0")]
		public void Add(UKZMEIVMGCY.GDBWHJQQAMV cluster, Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x88FE090", Offset = "0x88FCC90", VA = "0x1888FE090")]
		public void Remove(UKZMEIVMGCY.GDBWHJQQAMV cluster)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x88FDF50", Offset = "0x88FCB50", VA = "0x1888FDF50")]
		private UKZMEIVMGCY.GDBWHJQQAMV NTFRHCENWZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x88FDE00", Offset = "0x88FCA00", VA = "0x1888FDE00")]
		private bool MBEKOXCHXIT(UKZMEIVMGCY.GDBWHJQQAMV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88FDEA0", Offset = "0x88FCAA0", VA = "0x1888FDEA0")]
		private void MOSVBMILQQI(UKZMEIVMGCY.GDBWHJQQAMV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88FD890", Offset = "0x88FC490", VA = "0x1888FD890")]
		public bool AYERYLRHWKC(UKZMEIVMGCY.GDBWHJQQAMV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88FE280", Offset = "0x88FCE80", VA = "0x1888FE280")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88FE570", Offset = "0x88FD170", VA = "0x1888FE570")]
		private UKZMEIVMGCY.GDBWHJQQAMV VPIFAPLPAVM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88FDAE0", Offset = "0x88FC6E0", VA = "0x1888FDAE0")]
		public long HHDTQBLJYRZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x88FE5E0", Offset = "0x88FD1E0", VA = "0x1888FE5E0")]
		public VMFVWFPYPEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PGTLJHORWON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int KVFSDZUIOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int MSWZIFCGWVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private float CYAHYVRASGW;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<UKZMEIVMGCY> OBYQQKRNBGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88F6920", Offset = "0x88F5520", VA = "0x1888F6920")]
		public PGTLJHORWON(int a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x88F6720", Offset = "0x88F5320", VA = "0x1888F6720")]
		public void MRBJHPETBAQ(YGQPJPORLER a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x88F6870", Offset = "0x88F5470", VA = "0x1888F6870")]
		private int XXVQXOODCER(XQVCWMXGMUN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88F6470", Offset = "0x88F5070", VA = "0x1888F6470")]
		private void MRBJHPETBAQ(XQVCWMXGMUN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88F67D0", Offset = "0x88F53D0", VA = "0x1888F67D0")]
		private void XDBIVRVPOLH(XQVCWMXGMUN a, UKZMEIVMGCY b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, BUUTGZGVJAC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DYGALYEOZET : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private Renderer DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public ClusterMeshRenderer VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int NAMOISTICOB;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private Renderer JUHGKFBEHEG
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public DYGALYEOZET(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x88F0050", Offset = "0x88EEC50", VA = "0x1888F0050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x88F0160", Offset = "0x88EED60", VA = "0x1888F0160", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x88EFFB0", Offset = "0x88EEBB0", VA = "0x1888EFFB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> LQUEDDEXWGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x88EFFB0", Offset = "0x88EEBB0", VA = "0x1888EFFB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int JFEOGNIJOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x88ECD20", Offset = "0x88EB920", VA = "0x1888ECD20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<MDJFIBNSVQT> FKBCDBKRSSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x88ECCF0", Offset = "0x88EB8F0", VA = "0x1888ECCF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> TQGGMVDAIZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public UKZMEIVMGCY TZGQPRMHTPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RenderLayer HYIYEMDNURE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xB18830", Offset = "0xB17430", VA = "0x180B18830", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(RenderLayer);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB18820", Offset = "0xB17420", VA = "0x180B18820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LMGVJZYHUTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x88ECD10", Offset = "0x88EB910", VA = "0x1888ECD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88EB120", Offset = "0x88E9D20", VA = "0x1888EB120")]
		public static ClusterMeshRenderer Create(UKZMEIVMGCY mesh, ClusterMeshRenderer clusterMeshRendererPrefab, MeshFilter clusterPrefab, RRTransform root, RenderLayer layer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x88EB3A0", Offset = "0x88E9FA0", VA = "0x1888EB3A0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x88EBF00", Offset = "0x88EAB00", VA = "0x1888EBF00", Slot = "9")]
		public bool TryRemoveClusterLODComponent(UBHDCQVRLYE component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88EBCB0", Offset = "0x88EA8B0", VA = "0x1888EBCB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88EB8E0", Offset = "0x88EA4E0", VA = "0x1888EB8E0")]
		public void Init(UKZMEIVMGCY mesh, MeshFilter clusterPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x88EB400", Offset = "0x88EA000", VA = "0x1888EB400")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x88EC0F0", Offset = "0x88EACF0", VA = "0x1888EC0F0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x88EC3A0", Offset = "0x88EAFA0", VA = "0x1888EC3A0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x88EB860", Offset = "0x88EA460", VA = "0x1888EB860")]
		[IteratorStateMachine(typeof(DYGALYEOZET))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x88EBD40", Offset = "0x88EA940", VA = "0x1888EBD40")]
		public void SetupTagAndLayer(string tag, int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x88EBD20", Offset = "0x88EA920", VA = "0x1888EBD20")]
		public bool Remove(UBHDCQVRLYE component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public ClusterMeshRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct MeshComponentInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int startVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int vertexCount;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x88F6450", Offset = "0x88F5050", VA = "0x1888F6450")]
		public MeshComponentInfo(int startIndex, int indexCount, int startVertex, int vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class VMVGBNDPTIQ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public NativeList<float3> LJHNXXWBXQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public NativeList<int> LBJYMWWELZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public NativeList<int> PIJISQOYEWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NativeList<MeshComponentInfo> LCOFCICGIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NativeArray<int> WWWYRJVVNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeArray<float3> PTBFMUUVCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeArray<float> AIGTKTILRII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public JobHandle KOYYCIUAEVQ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xF343C0", Offset = "0xF32FC0", VA = "0x180F343C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x111EE80", Offset = "0x111DA80", VA = "0x18111EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x88FE940", Offset = "0x88FD540", VA = "0x1888FE940")]
		public void HRTIXRMSTIX(NativeMesh a, NativeList<MeshComponentInfo> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88FFA30", Offset = "0x88FE630", VA = "0x1888FFA30")]
		public void ZHYUHQCTJPN(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x88FF8A0", Offset = "0x88FE4A0", VA = "0x1888FF8A0")]
		public void WGLWXRMITBY(UKZMEIVMGCY a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x88FE840", Offset = "0x88FD440", VA = "0x1888FE840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x88FE820", Offset = "0x88FD420", VA = "0x1888FE820")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VMVGBNDPTIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[BurstCompile]
	public struct ClusterMeshUpdateJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[ReadOnly]
		private NativeList<float3> verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ReadOnly]
		public NativeList<int> origIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[ReadOnly]
		private NativeList<MeshComponentInfo> clusterInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[ReadOnly]
		private NativeArray<int> componentLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[ReadOnly]
		private float3 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[ReadOnly]
		private NativeArray<float3> triNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[ReadOnly]
		private NativeArray<float> triSizes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[ReadOnly]
		private bool dynamicCluster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[ReadOnly]
		private float faceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[ReadOnly]
		private float meshScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[ReadOnly]
		private float distFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private NativeList<int> indices;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x88ED2D0", Offset = "0x88EBED0", VA = "0x1888ED2D0")]
		public ClusterMeshUpdateJob(VMVGBNDPTIQ jobData, Vector3 eyePos, bool dynamicCluster, float faceFactor, float meshScale, float distFactor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x88ECD90", Offset = "0x88EB990", VA = "0x1888ECD90", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface UBHDCQVRLYE : WUIPFZRTCEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Bounds PBDLNVNSUEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class XQVCWMXGMUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public List<UBHDCQVRLYE> VJGCWUPFRCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public XQVCWMXGMUN GUMKFVWGXHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public XQVCWMXGMUN BLRPCXLPTCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public XQVCWMXGMUN BMHJURTHVKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int RNWXKCRXZMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Bounds FZCJFUVFILC;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x88FFCA0", Offset = "0x88FE8A0", VA = "0x1888FFCA0")]
		public XQVCWMXGMUN(List<UBHDCQVRLYE> a, [Optional] XQVCWMXGMUN b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class YGQPJPORLER
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<XQVCWMXGMUN> ZEWWYYSKYRA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public XQVCWMXGMUN DXAPXCCARDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x88FFD20", Offset = "0x88FE920", VA = "0x1888FFD20")]
		public YGQPJPORLER(XQVCWMXGMUN a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DKRQLSPYXZE
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct Stats
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int numOverSized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int xSplits;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int ySplits;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public int zSplits;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct SplitResult : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int bestIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public float bestVolume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public List<UBHDCQVRLYE> components;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x88F6AE0", Offset = "0x88F56E0", VA = "0x1888F6AE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private enum Axis
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
		private Stats VFKKHYGELZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int EYEUCMPNGQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int KVFSDZUIOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int MSWZIFCGWVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private float RDLQCPFJGHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private float KSJSKEFZQLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Stack<XQVCWMXGMUN> SDJUSLZSOLD;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public YGQPJPORLER ERTOZDLSFIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x88EFF50", Offset = "0x88EEB50", VA = "0x1888EFF50")]
		public DKRQLSPYXZE(int a, int b, float c, int d, float e = 0.5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x88EFD50", Offset = "0x88EE950", VA = "0x1888EFD50")]
		public void UUGZBONWUXZ(List<UBHDCQVRLYE> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x88EDE30", Offset = "0x88ECA30", VA = "0x1888EDE30")]
		public bool DCJEEOKPGLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88EDDC0", Offset = "0x88EC9C0", VA = "0x1888EDDC0")]
		private float BCJMNZAATSR(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x88EDE10", Offset = "0x88ECA10", VA = "0x1888EDE10")]
		private float BCJMNZAATSR(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x88EDEA0", Offset = "0x88ECAA0", VA = "0x1888EDEA0")]
		private bool OVSSGYJBKED(XQVCWMXGMUN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x88EEA60", Offset = "0x88ED660", VA = "0x1888EEA60")]
		private SplitResult RSDKTDMRXBW(List<UBHDCQVRLYE> a, Axis b)
		{
			return default(SplitResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x88EF9B0", Offset = "0x88EE5B0", VA = "0x1888EF9B0")]
		private void TNHHTIHFKHR(List<UBHDCQVRLYE> a, NativeArray<Vector3> b, NativeArray<Vector3> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class BUXRLCGWHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x88EA520", Offset = "0x88E9120", VA = "0x1888EA520")]
		public static Bounds UBYSIHJOUJI(List<UBHDCQVRLYE> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x88EA350", Offset = "0x88E8F50", VA = "0x1888EA350")]
		public static int IFRGRGSHWVO(List<UBHDCQVRLYE> a, SystemLOD b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal class KSQIONEEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate bool SupportsVertexCompression_000000ED$PostfixBurstDelegate(float4* materialIndices, int length);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal static class IOAQUUMMGIK
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private static IntPtr XETOYWLYCVA;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x88F4870", Offset = "0x88F3470", VA = "0x1888F4870")]
			[BurstDiscard]
			private static void RLIOJMJDVKW(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x88F4A00", Offset = "0x88F3600", VA = "0x1888F4A00")]
			private static IntPtr RQYUINAFRNW()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x88F45C0", Offset = "0x88F31C0", VA = "0x1888F45C0")]
			public unsafe static bool Invoke(float4* materialIndices, int length)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x88F6020", Offset = "0x88F4C20", VA = "0x1888F6020")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ClusterLODs.SupportsVertexCompression_000000ED$PostfixBurstDelegate))]
		public unsafe static bool TOCEFSORIGP(float4* a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x88F5F50", Offset = "0x88F4B50", VA = "0x1888F5F50")]
		[BurstCompile]
		public unsafe static bool GBJHVAZIJBU(float4* a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	public struct CompressVerticesJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[ReadOnly]
		private NativeList<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private NativeList<float3> Verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private NativeArray<float3> Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private NativeArray<float4> Tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private NativeArray<float4> MaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[WriteOnly]
		public NativeArray<bool> supportsVertexCompressionOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NativeList<ushort> compressedIndexBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x88ED6E0", Offset = "0x88EC2E0", VA = "0x1888ED6E0")]
		public CompressVerticesJob(NativeMesh resultMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x88ED390", Offset = "0x88EBF90", VA = "0x1888ED390", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[ReadOnly]
		private NativeList<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeList<float3> Verts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private NativeArray<float3> Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private NativeArray<float4> Tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private NativeArray<float4> MaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private NativeArray<float2> UVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private NativeList<int> SharedAdditionalIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private NativeList<float3> SharedAdditionalVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private NativeArray<float3> SharedAdditionalNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private NativeArray<float4> SharedAdditionalTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private NativeArray<float4> SharedAdditionalMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private NativeArray<float2> SharedAdditionalUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[WriteOnly]
		public NativeArray<bool> supportsVertexCompressionOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NativeList<ushort> compressedIndexBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x88EDD10", Offset = "0x88EC910", VA = "0x1888EDD10")]
		public CompressVerticesWithSharedAdditionalMeshJob(NativeMesh resultMesh, NativeMesh sharedAdditionalMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x88ED740", Offset = "0x88EC340", VA = "0x1888ED740", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class BBVBSPWGVOZ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private NativeMesh HDPIPSMNUEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private NativeMesh EUYQMMOKQXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private NativeArray<bool> OMLGLWCXSGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private NativeList<ushort> ZSNYDRDAVEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> FMIFAYIDOKI;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static NativeMesh FCFPYDPEMCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private MWSUROXMZRO CNAODGXSBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private BAEZTLIQVHX CRNQTXTRFNH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JobHandle KOYYCIUAEVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xF212A0", Offset = "0xF1FEA0", VA = "0x180F212A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public UKZMEIVMGCY.GDBWHJQQAMV UUKAACKHYMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AMANALQVWEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x261A900", Offset = "0x2619500", VA = "0x18261A900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x88EA0C0", Offset = "0x88E8CC0", VA = "0x1888EA0C0")]
		[RRPostPlayModeMethod(PostPlayModePhase.EnteredEditMode, 0)]
		private static void WIDYPWKPHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x88E8B90", Offset = "0x88E7790", VA = "0x1888E8B90")]
		public void HRTIXRMSTIX(UKZMEIVMGCY.GDBWHJQQAMV a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x88E9840", Offset = "0x88E8440", VA = "0x1888E9840")]
		public void QVNBMCHIRGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88E8AC0", Offset = "0x88E76C0", VA = "0x1888E8AC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x88E8A80", Offset = "0x88E7680", VA = "0x1888E8A80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x88EA140", Offset = "0x88E8D40", VA = "0x1888EA140")]
		public BBVBSPWGVOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface CPYSGJSUKBW
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		Vector3 EyePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface ERIUFZGMMLZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WaitForShapes(StackTimer<string>.YOQUQHZDBKW worldStackTimer, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface ZQGFPKVEBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZQGFPKVEBEN JADSOETMOZX(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZQGFPKVEBEN AFPXYRQZMNO(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class TCECVONXMTB : ZQGFPKVEBEN
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class LOJPDCGXZIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public Action RCGVCQMSHXS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public TCECVONXMTB VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public Action WOTAVUMLVZY;

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LOJPDCGXZIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x88F60E0", Offset = "0x88F4CE0", VA = "0x1888F60E0")]
				internal void HJZPPMASNVA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x88F6130", Offset = "0x88F4D30", VA = "0x1888F6130")]
				internal void HKEWMSUPXGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x88F6090", Offset = "0x88F4C90", VA = "0x1888F6090")]
				internal void HJPBUYMXUYI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private Func<JobHandle> KIPPWTZPQFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Action UUFNZUPYXKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action XNFKCTMHGKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private GOBIAMTAPNM TGXRVCYDCCW;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action ENATEXZMVBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action EDFIRRXHXKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C630", Offset = "0x2D5B230", VA = "0x182D5C630", Slot = "4")]
			public ZQGFPKVEBEN JADSOETMOZX(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8242030", Offset = "0x8240C30", VA = "0x188242030", Slot = "5")]
			public ZQGFPKVEBEN AFPXYRQZMNO(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
			public TCECVONXMTB(Func<JobHandle> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x88F8620", Offset = "0x88F7220", VA = "0x1888F8620")]
			public void Run(Action removeJob, Action startNext)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x88F8490", Offset = "0x88F7090", VA = "0x1888F8490")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public TCECVONXMTB LDEQMDRQJVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public JobQueue VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x88F4560", Offset = "0x88F3160", VA = "0x1888F4560")]
			internal void FOGFHJCDPJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public ZQGFPKVEBEN KOYYCIUAEVQ;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x88F8910", Offset = "0x88F7510", VA = "0x1888F8910")]
			internal bool UAQPYSZWRYX(TCECVONXMTB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Queue<TCECVONXMTB> RIRJFVHUYJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private List<TCECVONXMTB> RZEZQDZDSAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private GEUHFRHGIWS QDBPWGQOWOX;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AJBIPVUFGCW AJBIPVUFGCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x88F4CA0", Offset = "0x88F38A0", VA = "0x1888F4CA0")]
		public ZQGFPKVEBEN Add(Func<JobHandle> createJob)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x88F4FC0", Offset = "0x88F3BC0", VA = "0x1888F4FC0")]
		public void Remove(ZQGFPKVEBEN jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x88F4DF0", Offset = "0x88F39F0", VA = "0x1888F4DF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x88F5190", Offset = "0x88F3D90", VA = "0x1888F5190")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x88F5430", Offset = "0x88F4030", VA = "0x1888F5430")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x88F4DE0", Offset = "0x88F39E0", VA = "0x1888F4DE0")]
		[CompilerGenerated]
		private void NXCOTSZHQVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface GOBIAMTAPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GOBIAMTAPNM JADSOETMOZX(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GOBIAMTAPNM XVOFMKUJXDS(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GOBIAMTAPNM AFPXYRQZMNO(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, QKMOLDHPCOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class BJJBEYLTPEY : GOBIAMTAPNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private JobHandle KXRWLYEXFTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private Action UUFNZUPYXKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action WSJFDEMGMKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action EDFIRRXHXKH;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool JZXUPAMYITE
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x88EA2F0", Offset = "0x88E8EF0", VA = "0x1888EA2F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8170160", Offset = "0x816ED60", VA = "0x188170160", Slot = "4")]
			public GOBIAMTAPNM JADSOETMOZX(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8170180", Offset = "0x816ED80", VA = "0x188170180", Slot = "5")]
			public GOBIAMTAPNM XVOFMKUJXDS(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8242030", Offset = "0x8240C30", VA = "0x188242030", Slot = "6")]
			public GOBIAMTAPNM AFPXYRQZMNO(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x11E9A20", Offset = "0x11E8620", VA = "0x1811E9A20")]
			public BJJBEYLTPEY(JobHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x88EA2A0", Offset = "0x88E8EA0", VA = "0x1888EA2A0")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x88EA300", Offset = "0x88E8F00", VA = "0x1888EA300")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private List<BJJBEYLTPEY> RQVMVCCZAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<IDisposable> CSIJEKTGALY;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ESOPMAEKFHE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x88F5A50", Offset = "0x88F4650", VA = "0x1888F5A50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1518320", Offset = "0x1516F20", VA = "0x181518320")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x88F5500", Offset = "0x88F4100", VA = "0x1888F5500")]
		public GOBIAMTAPNM Add(JobHandle job)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x88F5D80", Offset = "0x88F4980", VA = "0x1888F5D80")]
		public void Remove(GOBIAMTAPNM jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88F5870", Offset = "0x88F4470", VA = "0x1888F5870")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x88F56C0", Offset = "0x88F42C0", VA = "0x1888F56C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x88F55F0", Offset = "0x88F41F0", VA = "0x1888F55F0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x88F5E80", Offset = "0x88F4A80", VA = "0x1888F5E80")]
		public JobTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB40790", Offset = "0xB3F390", VA = "0x180B40790", Slot = "6")]
		private bool LQQJYPNELKO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3847892874
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x88FFE50", Offset = "0x88FEA50", VA = "0x1888FFE50")]
	public static void TGIQTAWGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x88FFE40", Offset = "0x88FEA40", VA = "0x1888FFE40")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x88F8920", Offset = "0x88F7520", VA = "0x1888F8920")]
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
