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
				[Cpp2IlInjected.Address(RVA = "0x83A2BE0", Offset = "0x83A1BE0", VA = "0x1883A2BE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xCC0400", Offset = "0xCBF400", VA = "0x180CC0400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x83A2BA0", Offset = "0x83A1BA0", VA = "0x1883A2BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x839A5A0", Offset = "0x83995A0", VA = "0x18839A5A0")]
		public LODSettings GetSettings(SystemLOD lod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x839A580", Offset = "0x8399580", VA = "0x18839A580")]
		public int GetMaxNumActiveLOD0Verts()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x839A4E0", Offset = "0x83994E0", VA = "0x18839A4E0")]
		public int GetDetailFromHalfSize(bool isNear, Vector3 halfSize)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x839A5B0", Offset = "0x83995B0", VA = "0x18839A5B0")]
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
	public interface CHYBHVRHTSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetupClusterLOD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KBGXPVPYFUQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int CPHIEYZKBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IEnumerable<HHRZZIYJSYZ> XMYDHUQWSNB
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
		bool TryRemoveClusterLODComponent(RZWSMYYDNYK component);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HHRZZIYJSYZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int JLOUZGTJZCY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int OSDRYZHOEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float KDIZDYXWAZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float MQWVCPVOSXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		byte KTXEQOCSFYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AUVELXIQZEV : IDisposable
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
		private sealed class OHPQOGYWUWF : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AUVELXIQZEV SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int NDWVDMZYBNM;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public OHPQOGYWUWF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83A2C20", Offset = "0x83A1C20", VA = "0x1883A2C20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83A3940", Offset = "0x83A2940", VA = "0x1883A3940", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
			public AUVELXIQZEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public StackTimer<string>.MESVLYROYNG worldStackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private StackTimer<string>.MESVLYROYNG <waitForShapesTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83A76B0", Offset = "0x83A66B0", VA = "0x1883A76B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83A8FA0", Offset = "0x83A7FA0", VA = "0x1883A8FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DFJNWBITRUU : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AUVELXIQZEV SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public DFJNWBITRUU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x839DB90", Offset = "0x839CB90", VA = "0x18839DB90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x839DE00", Offset = "0x839CE00", VA = "0x18839DE00", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
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
			public AUVELXIQZEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public StackTimer<string>.MESVLYROYNG stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private CancellationTokenSource <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private StackTimer<string>.MESVLYROYNG <createWorldTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83A9000", Offset = "0x83A8000", VA = "0x1883A9000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83A9790", Offset = "0x83A8790", VA = "0x1883A9790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int ZDUFAIJWJIN = 3;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly TimeSpan SYXUPEBYRXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ClusterMeshRenderer SHCLJODSISD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MeshFilter EOFHJKUELYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject AGVIGAJWNRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject RQMJKCFWPRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HSSOJDNDCRC HSSOJDNDCRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<RZWSMYYDNYK> QSUJCIHRFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<RZWSMYYDNYK> LMLFTRJJSNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<RZWSMYYDNYK> GNMLAMLDERE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int DKWXZYVVBMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private double TWMFJMTDQBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long GSARBYHTZQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private long PDHDQUQTEJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private long KQQUJTYZILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private long KAREMQJEXJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private State PGEGETRSFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<KBGXPVPYFUQ>[] KMXPWCVUCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private List<HHRZZIYJSYZ>[] TYHGNGRCYSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CancellationTokenSource GWVRNCTYJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool GPLSVDTJXYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ALZORZCQSFK HYVIJJVVVMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ALZORZCQSFK STULKOLOGVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int VAWCQWAYROK;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static AUVELXIQZEV BQYDEMZZJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly IYGKUMCZZEN WIUXRRICKXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly XYFRISKVMKC CIUHOGLFEZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly MonoBehaviour GEWDMVOMVOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Material MVNZYPXTVNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<Material> CASDSJXFDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Material LHEHTRLBPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<Material> TPAEVRCMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[CompilerGenerated]
		private Action IWWTKLGLMKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool VKTTBTVMLYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<CHYBHVRHTSY> ZVGENPNFXSU;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ClusterLODConfig TSUDRDUYBZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector3 DNWWARQDSYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1C9FAE0", Offset = "0x1C9EAE0", VA = "0x181C9FAE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x81BA170", Offset = "0x81B9170", VA = "0x1881BA170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public State BFIYEJIRRQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1616DD0", Offset = "0x1615DD0", VA = "0x181616DD0")]
			get
			{
				return default(State);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8396D80", Offset = "0x8395D80", VA = "0x188396D80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static AUVELXIQZEV QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8396A80", Offset = "0x8395A80", VA = "0x188396A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static bool FNUMNDYWCVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8397820", Offset = "0x8396820", VA = "0x188397820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool NYGGSKQYIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8398330", Offset = "0x8397330", VA = "0x188398330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Vector3> HXHPSMEGTYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8397A50", Offset = "0x8396A50", VA = "0x188397A50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8399470", Offset = "0x8398470", VA = "0x188399470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8399CC0", Offset = "0x8398CC0", VA = "0x188399CC0")]
		public AUVELXIQZEV(IYGKUMCZZEN a, XYFRISKVMKC b, ClusterLODConfig c, MonoBehaviour d, Material e, ClusterMeshRenderer f, MeshFilter g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8399530", Offset = "0x8398530", VA = "0x188399530")]
		private void XIBCUOAJFOE(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8396CE0", Offset = "0x8395CE0", VA = "0x188396CE0")]
		public void DPKSIMLCJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8399340", Offset = "0x8398340", VA = "0x188399340")]
		public void UpdateMaterials(Action<Material> updateFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8399320", Offset = "0x8398320", VA = "0x188399320")]
		public static NativeMesh.UnityMeshFormat TKDBUWBHBHM(NativeMesh.UnityMeshFormat a)
		{
			return default(NativeMesh.UnityMeshFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8396EB0", Offset = "0x8395EB0", VA = "0x188396EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8399690", Offset = "0x8398690", VA = "0x188399690")]
		public static void XPPBZUJDFXR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83982A0", Offset = "0x83972A0", VA = "0x1883982A0")]
		private void KOVRWDDBGFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8399A90", Offset = "0x8398A90", VA = "0x188399A90")]
		private void YEKBLPBGNRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8397910", Offset = "0x8396910", VA = "0x188397910")]
		private void GIVYWOSZRLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8397C60", Offset = "0x8396C60", VA = "0x188397C60")]
		public void KMPAAMDMZYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8398A60", Offset = "0x8397A60", VA = "0x188398A60")]
		[AsyncStateMachine(typeof(<StartCreateWorld>d__78))]
		public Task QURLEDQVYIL(StackTimer<string>.MESVLYROYNG a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8398530", Offset = "0x8397530", VA = "0x188398530")]
		[IteratorStateMachine(typeof(DFJNWBITRUU))]
		private IEnumerator<ADJUPIXYSVF> NUTFRKBANQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8398B80", Offset = "0x8397B80", VA = "0x188398B80")]
		[AsyncStateMachine(typeof(<CreateWorld>d__80))]
		private Task RNCZJCTPGOR(StackTimer<string>.MESVLYROYNG a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8396AD0", Offset = "0x8395AD0", VA = "0x188396AD0")]
		public void CMWXXYVCJUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8397BE0", Offset = "0x8396BE0", VA = "0x188397BE0")]
		public void ITAUNQIKDEX(IEnumerable<KBGXPVPYFUQ> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8399790", Offset = "0x8398790", VA = "0x188399790")]
		public void XYBTMEPNRCK(IEnumerable<KBGXPVPYFUQ> a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8397280", Offset = "0x8396280", VA = "0x188397280")]
		public List<ClusterMeshRenderer> ECSPWVMXJUT(List<RZWSMYYDNYK> a, RRTransform b, RenderLayer c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83969D0", Offset = "0x83959D0", VA = "0x1883969D0")]
		public void APLSJVVGBGA(CHYBHVRHTSY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83985A0", Offset = "0x83975A0", VA = "0x1883985A0")]
		public bool OGWOSVUPDKE(CHYBHVRHTSY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8399B60", Offset = "0x8398B60", VA = "0x188399B60")]
		public void ZCIUNPWAIER(RZWSMYYDNYK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8399240", Offset = "0x8398240", VA = "0x188399240")]
		public void THVHRJMDQRP(HHRZZIYJSYZ a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83989E0", Offset = "0x83979E0", VA = "0x1883989E0")]
		public void PSATZUTLDXE(HHRZZIYJSYZ a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83983F0", Offset = "0x83973F0", VA = "0x1883983F0")]
		private void MJVQCSQPOGX(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83990D0", Offset = "0x83980D0", VA = "0x1883990D0")]
		private void TCCWMQOFQPK(Vector3 a, RenderLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8399060", Offset = "0x8398060", VA = "0x188399060")]
		[IteratorStateMachine(typeof(OHPQOGYWUWF))]
		private IEnumerator<ADJUPIXYSVF> SYGHZBLNVUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8398EF0", Offset = "0x8397EF0", VA = "0x188398EF0")]
		private int SOTTYDEQROC(int a, int b, List<HHRZZIYJSYZ> c, byte d, int e, float f = 0f)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8398D30", Offset = "0x8397D30", VA = "0x188398D30")]
		public void Remove(RZWSMYYDNYK component)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8399C10", Offset = "0x8398C10", VA = "0x188399C10")]
		public bool ZOWYKOBGRGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD064C0", Offset = "0xD054C0", VA = "0x180D064C0")]
		public Material RRKFHQCUCGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8398CA0", Offset = "0x8397CA0", VA = "0x188398CA0")]
		public Material RRKFHQCUCGJ(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC99400", Offset = "0xC98400", VA = "0x180C99400")]
		public Material HWPSEGWFREM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8397B10", Offset = "0x8396B10", VA = "0x188397B10")]
		public Material HWPSEGWFREM(NativeMesh.UnityMeshFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8397BA0", Offset = "0x8396BA0", VA = "0x188397BA0")]
		public int ILYSDFESONW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8398600", Offset = "0x8397600", VA = "0x188398600")]
		public (long, int) OJLDPKLKEAO()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x839AE60", Offset = "0x8399E60", VA = "0x18839AE60")]
		public ClusterLODMergeVertsJob(NativeMesh mesh, NativeList<float3> origVerts, NativeParallelMultiHashMap<int, int> vertexMap, NativeArray<int> indexRemap, Vector3 centerPos, float resolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x839AE00", Offset = "0x8399E00", VA = "0x18839AE00")]
		private int LCCUSNJOYXS(float3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x839A610", Offset = "0x8399610", VA = "0x18839A610")]
		private int EXCWKJRYCAC(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x839A900", Offset = "0x8399900", VA = "0x18839A900", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class EYLDEENUJTR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static NativeParallelMultiHashMap<int, int> PRPSFBIIJNP;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NativeArray<int> NZQSJLWKCYW;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static int YZPCLVQJSGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NativeList<int> VCBLDOTOGJJ;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x839E870", Offset = "0x839D870", VA = "0x18839E870")]
		public void IETRXXJFQRI(int a, Allocator b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x839E7A0", Offset = "0x839D7A0", VA = "0x18839E7A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public EYLDEENUJTR()
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
		[Cpp2IlInjected.Address(RVA = "0x83A0460", Offset = "0x839F460", VA = "0x1883A0460")]
		public InitSubdivideMeshData(EYLDEENUJTR subdivideData, NativeMesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83A0370", Offset = "0x839F370", VA = "0x1883A0370", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x83A73D0", Offset = "0x83A63D0", VA = "0x1883A73D0")]
		public SubdivideMeshJob(EYLDEENUJTR subdiveData, NativeMesh mesh, NativeMesh additionalMesh, float maxEdgeSize, float maxDistance, Vector3 eyePos, float rootScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83A5C90", Offset = "0x83A4C90", VA = "0x1883A5C90")]
		private float3 CADERBYODSG(int a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83A6D90", Offset = "0x83A5D90", VA = "0x1883A6D90")]
		private void UNJOWRMRGDP(int a, [Out] float3 b, [Out] float3 c, [Out] float4 d, [Out] float4 e, [Out] float2 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83A5DB0", Offset = "0x83A4DB0", VA = "0x1883A5DB0")]
		private int DJJIPFXJGIU(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83A6FC0", Offset = "0x83A5FC0", VA = "0x1883A6FC0")]
		private void UOIGWSLZTXQ(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83A71C0", Offset = "0x83A61C0", VA = "0x1883A71C0")]
		private bool XDBSNQAPMSQ(int a, int b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x83A7310", Offset = "0x83A6310", VA = "0x1883A7310")]
		private bool ZXNSTNFAZQV(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83A6B10", Offset = "0x83A5B10", VA = "0x1883A6B10")]
		private bool FEDHLKXKZSS(int a, int b, int c, float d, bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83A6D70", Offset = "0x83A5D70", VA = "0x1883A6D70")]
		private void NOPVZDJEVIU(int a, int b, int c, [Out] int d, [Out] int e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83A60B0", Offset = "0x83A50B0", VA = "0x1883A60B0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZOPFBDBHQIC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class SVTAZPSSBBV : IDisposable, HHRZZIYJSYZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Bounds AEVRRBQOTDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public List<RZWSMYYDNYK> GHFEATYSDVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Vector3 JHVYGXTYZFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Vector3 CABBCGNYEKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int CZEUTXBPBMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public NativeMesh CPHZUFNEURP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public long QWOAZIXPMJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public EYLDEENUJTR IEOUDQNMLZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeMesh.UnityMeshFormat SHMCWJWGELL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Transform EQMHNAKVRHZ;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int VSSIVVVOZOJ
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x83A5800", Offset = "0x83A4800", VA = "0x1883A5800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Mesh UFNNGBMYVLO
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public NativeMesh.UnityMeshFormat FRLCPHRDIOP
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xB835C0", Offset = "0xB825C0", VA = "0x180B835C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Mesh OBTJNHVVJWI
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F10", Offset = "0xAD1F10", VA = "0x180AD2F10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public NativeMesh.UnityMeshFormat KDJGYLFPTKL
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0xD8F670", Offset = "0xD8E670", VA = "0x180D8F670")]
				[CompilerGenerated]
				get
				{
					return default(NativeMesh.UnityMeshFormat);
				}
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xD8F8D0", Offset = "0xD8E8D0", VA = "0x180D8F8D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public float KDIZDYXWAZU
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x104D480", Offset = "0x104C480", VA = "0x18104D480", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x121EEF0", Offset = "0x121DEF0", VA = "0x18121EEF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public byte KTXEQOCSFYI
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xD9C5D0", Offset = "0xD9B5D0", VA = "0x180D9C5D0")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xD9C360", Offset = "0xD9B360", VA = "0x180D9C360", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public int JLOUZGTJZCY
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xC516E0", Offset = "0xC506E0", VA = "0x180C516E0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x28559F0", Offset = "0x28549F0", VA = "0x1828559F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public int OSDRYZHOEAB
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x1026460", Offset = "0x1025460", VA = "0x181026460", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x15C6560", Offset = "0x15C5560", VA = "0x1815C6560")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public float MQWVCPVOSXI
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x83A5280", Offset = "0x83A4280", VA = "0x1883A5280", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83A52A0", Offset = "0x83A42A0", VA = "0x1883A52A0")]
			public void BPEBDTLCAYA(SystemLOD a, [Out] int b, [Out] int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83A5840", Offset = "0x83A4840", VA = "0x1883A5840")]
			public void RIAHTKYEOKC(SystemLOD a, IDXABTLUUXN b, int c = -1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83A5750", Offset = "0x83A4750", VA = "0x1883A5750")]
			public void IYALTZKNHCX(Mesh a, NativeMesh.UnityMeshFormat b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x83A56C0", Offset = "0x83A46C0", VA = "0x1883A56C0")]
			public void FSEQSMTCUYF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x83A5510", Offset = "0x83A4510", VA = "0x1883A5510", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83A5A10", Offset = "0x83A4A10", VA = "0x1883A5A10")]
			public SVTAZPSSBBV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Bounds AEVRRBQOTDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NativeMesh.UnityMeshFormat SHMCWJWGELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<SVTAZPSSBBV> LEISSQBKXMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LJIKIRISSJI UDXYEPSUILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ClusterMeshRenderer KQHNAOZIGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int KMJUZUAVGAZ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Mesh QSWLRJOTYLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool DCHOXBKPVAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int CPHIEYZKBME
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83AC350", Offset = "0x83AB350", VA = "0x1883AC350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83AC1D0", Offset = "0x83AB1D0", VA = "0x1883AC1D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83AD910", Offset = "0x83AC910", VA = "0x1883AD910")]
		public int YTPYCXTXUMU(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83AD6E0", Offset = "0x83AC6E0", VA = "0x1883AD6E0")]
		public void XNEAFNPHIAY(ALGZDTCDABV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83AC550", Offset = "0x83AB550", VA = "0x1883AC550")]
		public void NAVUUQAFNAW(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83AC3B0", Offset = "0x83AB3B0", VA = "0x1883AC3B0")]
		public bool JEVBPDVTXLC(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83AD0E0", Offset = "0x83AC0E0", VA = "0x1883AD0E0")]
		public void TJYGBVRGRZB(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83ACE70", Offset = "0x83ABE70", VA = "0x1883ACE70")]
		public bool Remove(RZWSMYYDNYK component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83AD940", Offset = "0x83AC940", VA = "0x1883AD940")]
		public ZOPFBDBHQIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class HSSOJDNDCRC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Queue<ZOPFBDBHQIC.SVTAZPSSBBV> NBOJIFQKUNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private PJDBENPEANB JVQXPMRBKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly List<ZOPFBDBHQIC.SVTAZPSSBBV> EJYKRHAJRVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int SSXZPFRJVNX;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x839F5C0", Offset = "0x839E5C0", VA = "0x18839F5C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x839F4A0", Offset = "0x839E4A0", VA = "0x18839F4A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x839F3E0", Offset = "0x839E3E0", VA = "0x18839F3E0")]
		public void Add(ZOPFBDBHQIC.SVTAZPSSBBV cluster, Transform root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x839FAE0", Offset = "0x839EAE0", VA = "0x18839FAE0")]
		public void Remove(ZOPFBDBHQIC.SVTAZPSSBBV cluster)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x839FFF0", Offset = "0x839EFF0", VA = "0x18839FFF0")]
		private ZOPFBDBHQIC.SVTAZPSSBBV ZUSQPZMYFHS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x839F520", Offset = "0x839E520", VA = "0x18839F520")]
		private bool DWTPTTKNNGF(ZOPFBDBHQIC.SVTAZPSSBBV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x839F710", Offset = "0x839E710", VA = "0x18839F710")]
		private void PVJVJNEKKCS(ZOPFBDBHQIC.SVTAZPSSBBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x839FFC0", Offset = "0x839EFC0", VA = "0x18839FFC0")]
		public bool XCIDZYOQZMM(ZOPFBDBHQIC.SVTAZPSSBBV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x839FCD0", Offset = "0x839ECD0", VA = "0x18839FCD0")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x839F6A0", Offset = "0x839E6A0", VA = "0x18839F6A0")]
		private ZOPFBDBHQIC.SVTAZPSSBBV MUHCYJUUHWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x839F7C0", Offset = "0x839E7C0", VA = "0x18839F7C0")]
		public long RNLXKHNVTLL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83A0130", Offset = "0x839F130", VA = "0x1883A0130")]
		public HSSOJDNDCRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class FCVORULMBZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int TEFWYTMHVHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int XHXLITLGGGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float AMTSYIDVZHW;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<ZOPFBDBHQIC> GNAZMASTCCW
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x839EF10", Offset = "0x839DF10", VA = "0x18839EF10")]
		public FCVORULMBZJ(int a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x839ED10", Offset = "0x839DD10", VA = "0x18839ED10")]
		public void BIOWOXOMTJU(SWREEJSVDXB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x839EDC0", Offset = "0x839DDC0", VA = "0x18839EDC0")]
		private int XEZOKVKYLMH(ALGZDTCDABV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x839EA60", Offset = "0x839DA60", VA = "0x18839EA60")]
		private void BIOWOXOMTJU(ALGZDTCDABV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x839EE70", Offset = "0x839DE70", VA = "0x18839EE70")]
		private void YPONNAINLBB(ALGZDTCDABV a, ZOPFBDBHQIC b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, KBGXPVPYFUQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ZVHVUSPPLTT : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private Renderer GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ClusterMeshRenderer SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int RRJFDMGHLWT;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			private Renderer PBCPVJDBHHS
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public ZVHVUSPPLTT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x83ADAA0", Offset = "0x83ACAA0", VA = "0x1883ADAA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x83ADBB0", Offset = "0x83ACBB0", VA = "0x1883ADBB0", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x83ADA00", Offset = "0x83ACA00", VA = "0x1883ADA00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> GNRHZFCLESL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x83ADA00", Offset = "0x83ACA00", VA = "0x1883ADA00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int CPHIEYZKBME
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x839CAF0", Offset = "0x839BAF0", VA = "0x18839CAF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<HHRZZIYJSYZ> XMYDHUQWSNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x839CAC0", Offset = "0x839BAC0", VA = "0x18839CAC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> LEISSQBKXMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ZOPFBDBHQIC QSWLRJOTYLU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RenderLayer ZFHZYTMIXUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAD6FE0", Offset = "0xAD5FE0", VA = "0x180AD6FE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(RenderLayer);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAD7820", Offset = "0xAD6820", VA = "0x180AD7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool TIXWZVPNLDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x839CAE0", Offset = "0x839BAE0", VA = "0x18839CAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x839AF10", Offset = "0x8399F10", VA = "0x18839AF10")]
		public static ClusterMeshRenderer Create(ZOPFBDBHQIC mesh, ClusterMeshRenderer clusterMeshRendererPrefab, MeshFilter clusterPrefab, RRTransform root, RenderLayer layer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x839B180", Offset = "0x839A180", VA = "0x18839B180", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x839BCD0", Offset = "0x839ACD0", VA = "0x18839BCD0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(RZWSMYYDNYK component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x839BA80", Offset = "0x839AA80", VA = "0x18839BA80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x839B6B0", Offset = "0x839A6B0", VA = "0x18839B6B0")]
		public void Init(ZOPFBDBHQIC mesh, MeshFilter clusterPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x839B1E0", Offset = "0x839A1E0", VA = "0x18839B1E0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x839BEC0", Offset = "0x839AEC0", VA = "0x18839BEC0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x839C170", Offset = "0x839B170", VA = "0x18839C170", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x839B630", Offset = "0x839A630", VA = "0x18839B630")]
		[IteratorStateMachine(typeof(ZVHVUSPPLTT))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x839BB10", Offset = "0x839AB10", VA = "0x18839BB10")]
		public void SetupTagAndLayer(string tag, int layer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x839BAF0", Offset = "0x839AAF0", VA = "0x18839BAF0")]
		public bool Remove(RZWSMYYDNYK component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x83A2C00", Offset = "0x83A1C00", VA = "0x1883A2C00")]
		public MeshComponentInfo(int startIndex, int indexCount, int startVertex, int vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class LJIKIRISSJI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public NativeList<float3> YHYOLQRAFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NativeList<int> VCBLDOTOGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NativeList<int> ZCJBBBRYXVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NativeList<MeshComponentInfo> TCWUTETCZWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NativeArray<int> ANZPXKTRFQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NativeArray<float3> QCYFQWDIVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public NativeArray<float> LYALEBFHNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public JobHandle QNNOODFKOCM;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xC516D0", Offset = "0xC506D0", VA = "0x180C516D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xDFD880", Offset = "0xDFC880", VA = "0x180DFD880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83A1AE0", Offset = "0x83A0AE0", VA = "0x1883A1AE0")]
		public void GRLRHMOCTOZ(NativeMesh a, NativeList<MeshComponentInfo> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83A1750", Offset = "0x83A0750", VA = "0x1883A1750")]
		public void AAACUGMABUV(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83A2A10", Offset = "0x83A1A10", VA = "0x1883A2A10")]
		public void JEVBPDVTXLC(ZOPFBDBHQIC a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83A19E0", Offset = "0x83A09E0", VA = "0x1883A19E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83A19C0", Offset = "0x83A09C0", VA = "0x1883A19C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public LJIKIRISSJI()
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
		[Cpp2IlInjected.Address(RVA = "0x839D0A0", Offset = "0x839C0A0", VA = "0x18839D0A0")]
		public ClusterMeshUpdateJob(LJIKIRISSJI jobData, Vector3 eyePos, bool dynamicCluster, float faceFactor, float meshScale, float distFactor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x839CB60", Offset = "0x839BB60", VA = "0x18839CB60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface RZWSMYYDNYK : WOJAAUUBYVH
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Bounds HGUNVENTOCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ALGZDTCDABV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public List<RZWSMYYDNYK> GHFEATYSDVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ALGZDTCDABV CGKCNLBHYUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ALGZDTCDABV UICXXRSUZLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public ALGZDTCDABV UHXRAKYXPZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int LLSGQPEFTYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Bounds AEVRRBQOTDI;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8396950", Offset = "0x8395950", VA = "0x188396950")]
		public ALGZDTCDABV(List<RZWSMYYDNYK> a, [Optional] ALGZDTCDABV b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SWREEJSVDXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<ALGZDTCDABV> UCSOJHWAODG;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ALGZDTCDABV SYFXSLEPKPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83A5B10", Offset = "0x83A4B10", VA = "0x1883A5B10")]
		public SWREEJSVDXB(ALGZDTCDABV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class WZUHQYUXLWA
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
			public List<RZWSMYYDNYK> components;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x83A5C30", Offset = "0x83A4C30", VA = "0x1883A5C30", Slot = "4")]
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
		private Stats QIQXRZRPPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int RVIWGPJPYWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int TEFWYTMHVHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int XHXLITLGGGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private float EVZUNKTALXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private float NJSIADUAUGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Stack<ALGZDTCDABV> WSNRDLUWQPJ;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public SWREEJSVDXB VFETNAFLZFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83AC170", Offset = "0x83AB170", VA = "0x1883AC170")]
		public WZUHQYUXLWA(int a, int b, float c, int d, float e = 0.5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83AAC50", Offset = "0x83A9C50", VA = "0x1883AAC50")]
		public void MUVJCTHWTXX(List<RZWSMYYDNYK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83AC100", Offset = "0x83AB100", VA = "0x1883AC100")]
		public bool XDWXROERHTI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83AA030", Offset = "0x83A9030", VA = "0x1883AA030")]
		private float EENLCRJKQHV(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83AA010", Offset = "0x83A9010", VA = "0x1883AA010")]
		private float EENLCRJKQHV(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83AA080", Offset = "0x83A9080", VA = "0x1883AA080")]
		private bool JNYZTOPDCUV(ALGZDTCDABV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83AB1F0", Offset = "0x83AA1F0", VA = "0x1883AB1F0")]
		private SplitResult RGHQRTUEEQO(List<RZWSMYYDNYK> a, Axis b)
		{
			return default(SplitResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83AAE50", Offset = "0x83A9E50", VA = "0x1883AAE50")]
		private void PMLRAXIRXNH(List<RZWSMYYDNYK> a, NativeArray<Vector3> b, NativeArray<Vector3> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class EECSOXJKTAX
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x839E5C0", Offset = "0x839D5C0", VA = "0x18839E5C0")]
		public static Bounds ZBAMZMETCWI(List<RZWSMYYDNYK> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x839E3F0", Offset = "0x839D3F0", VA = "0x18839E3F0")]
		public static int JYOQKYUSDHQ(List<RZWSMYYDNYK> a, SystemLOD b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal class SENXNBSVBDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate bool SupportsVertexCompression_000000F0$PostfixBurstDelegate(float4* materialIndices, int length);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		internal static class DMEGVURXVQX
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private static IntPtr RRRBRXCHXBW;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x839E260", Offset = "0x839D260", VA = "0x18839E260")]
			[BurstDiscard]
			private static void QSTKGPBCEDO(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x839DE40", Offset = "0x839CE40", VA = "0x18839DE40")]
			private static IntPtr IUQYFJLMUJA()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x839DFC0", Offset = "0x839CFC0", VA = "0x18839DFC0")]
			public unsafe static bool Invoke(float4* materialIndices, int length)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83A5270", Offset = "0x83A4270", VA = "0x1883A5270")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ClusterLODs.SupportsVertexCompression_000000F0$PostfixBurstDelegate))]
		public unsafe static bool SHNHLTUPBKV(float4* a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83A51A0", Offset = "0x83A41A0", VA = "0x1883A51A0")]
		[BurstCompile]
		internal unsafe static bool HZNGNBSQFLS(float4* a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x839D4B0", Offset = "0x839C4B0", VA = "0x18839D4B0")]
		public CompressVerticesJob(NativeMesh resultMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x839D160", Offset = "0x839C160", VA = "0x18839D160", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x839DAE0", Offset = "0x839CAE0", VA = "0x18839DAE0")]
		public CompressVerticesWithSharedAdditionalMeshJob(NativeMesh resultMesh, NativeMesh sharedAdditionalMesh, NativeArray<bool> supportsVertexCompressionOut, NativeList<ushort> compressedIndexBuffer, NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> compressedVertexBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x839D510", Offset = "0x839C510", VA = "0x18839D510", Slot = "4")]
		[BurstCompile]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class PJDBENPEANB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private NativeMesh OOZWGTSXFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private NativeMesh JALQZMFIRIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NativeArray<bool> EDNLJCADRWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NativeList<ushort> SUWXRCMBNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private NativeList<NativeMesh.VertexFormat_NormTanOct8MatUi> OVWKRLANCZQ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static NativeMesh HHVTFVKTWGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private SXYRTEOHPAS JMAUYNRHQOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IDXABTLUUXN YCCFZHOLVIX;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JobHandle QNNOODFKOCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0")]
			[CompilerGenerated]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7E0", Offset = "0xC9C7E0", VA = "0x180C9D7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public ZOPFBDBHQIC.SVTAZPSSBBV UDGBDXIXEPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LCCDZWLLBBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F09DA0", Offset = "0x1F08DA0", VA = "0x181F09DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83A39E0", Offset = "0x83A29E0", VA = "0x1883A39E0")]
		[RRPostPlayModeMethod(PostPlayModePhase.EnteredEditMode, 0)]
		private static void CQBPIBOTORC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83A3B60", Offset = "0x83A2B60", VA = "0x1883A3B60")]
		public void GRLRHMOCTOZ(ZOPFBDBHQIC.SVTAZPSSBBV a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83A47E0", Offset = "0x83A37E0", VA = "0x1883A47E0")]
		public void TREXNYFIHXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83A3A90", Offset = "0x83A2A90", VA = "0x1883A3A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83A3A50", Offset = "0x83A2A50", VA = "0x1883A3A50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83A5040", Offset = "0x83A4040", VA = "0x1883A5040")]
		public PJDBENPEANB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface XYFRISKVMKC
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
	public interface IYGKUMCZZEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WaitForShapes(StackTimer<string>.MESVLYROYNG worldStackTimer, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface YGZPVEKQIXZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YGZPVEKQIXZ SRYOFWGHDSP(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YGZPVEKQIXZ MREYEZZHAQG(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class GUHYRRTDSMZ : YGZPVEKQIXZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class CTXVCQSNWXT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public Action GZNUYPABHDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public GUHYRRTDSMZ SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public Action LLJEUTOICZO;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
				public CTXVCQSNWXT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x839A3F0", Offset = "0x83993F0", VA = "0x18839A3F0")]
				internal void AHTRBSORMYM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x839A440", Offset = "0x8399440", VA = "0x18839A440")]
				internal void AHYXYZIOWJV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x839A490", Offset = "0x8399490", VA = "0x18839A490")]
				internal void AIEEWGCMFVE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private Func<JobHandle> EPUAQIWBHJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private Action HJRIVUDMQSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private Action PDECSOMYRVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private MLQPBUJEIYI YNQYRCGMGDC;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action RWZOCZBPERD
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action PURTUABVVQB
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x28AD410", Offset = "0x28AC410", VA = "0x1828AD410", Slot = "4")]
			public YGZPVEKQIXZ SRYOFWGHDSP(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7C9A180", Offset = "0x7C99180", VA = "0x187C9A180", Slot = "5")]
			public YGZPVEKQIXZ MREYEZZHAQG(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
			public GUHYRRTDSMZ(Func<JobHandle> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x839F0F0", Offset = "0x839E0F0", VA = "0x18839F0F0")]
			public void Run(Action removeJob, Action startNext)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x839EF60", Offset = "0x839DF60", VA = "0x18839EF60")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class ORMYCPIHDTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public GUHYRRTDSMZ HWZGKFEDSGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JobQueue SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ORMYCPIHDTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x83A3980", Offset = "0x83A2980", VA = "0x1883A3980")]
			internal void MRVGWUKEXMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class EKVYHUESGOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public YGZPVEKQIXZ QNNOODFKOCM;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EKVYHUESGOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x839E790", Offset = "0x839D790", VA = "0x18839E790")]
			internal bool DYNIUEQIXVT(GUHYRRTDSMZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Queue<GUHYRRTDSMZ> TKXIIXNBRTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<GUHYRRTDSMZ> UENEZBJHCDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ALZORZCQSFK RPJXNBLEAJH;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public VIWWKGOHNSM VIWWKGOHNSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAD3540", Offset = "0xAD2540", VA = "0x180AD3540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83A0490", Offset = "0x839F490", VA = "0x1883A0490")]
		public YGZPVEKQIXZ Add(Func<JobHandle> createJob)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x83A07B0", Offset = "0x839F7B0", VA = "0x1883A07B0")]
		public void Remove(YGZPVEKQIXZ jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83A05E0", Offset = "0x839F5E0", VA = "0x1883A05E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83A0980", Offset = "0x839F980", VA = "0x1883A0980")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x83A0C20", Offset = "0x839FC20", VA = "0x1883A0C20")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83A05D0", Offset = "0x839F5D0", VA = "0x1883A05D0")]
		[CompilerGenerated]
		private void EENONBAGIBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface MLQPBUJEIYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MLQPBUJEIYI SRYOFWGHDSP(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MLQPBUJEIYI DFQAMWKZAAO(Action a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MLQPBUJEIYI MREYEZZHAQG(Action a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, OLEOLWASEVR
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class TSPVTAXKUMW : MLQPBUJEIYI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private JobHandle IODLUHMMBKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private Action HJRIVUDMQSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private Action XHATLUXQAWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private Action PURTUABVVQB;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool GJOEZEWWJNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x83A7610", Offset = "0x83A6610", VA = "0x1883A7610")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7BB09C0", Offset = "0x7BAF9C0", VA = "0x187BB09C0", Slot = "4")]
			public MLQPBUJEIYI SRYOFWGHDSP(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7BB09E0", Offset = "0x7BAF9E0", VA = "0x187BB09E0", Slot = "5")]
			public MLQPBUJEIYI DFQAMWKZAAO(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7C9A180", Offset = "0x7C99180", VA = "0x187C9A180", Slot = "6")]
			public MLQPBUJEIYI MREYEZZHAQG(Action a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xEB88D0", Offset = "0xEB78D0", VA = "0x180EB88D0")]
			public TSPVTAXKUMW(JobHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x83A75C0", Offset = "0x83A65C0", VA = "0x1883A75C0")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x83A7620", Offset = "0x83A6620", VA = "0x1883A7620")]
			public void Remove()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private List<TSPVTAXKUMW> VWLJQWPQQVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly List<IDisposable> RBSFCOTKQQA;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83A1240", Offset = "0x83A0240", VA = "0x1883A1240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x11F9D70", Offset = "0x11F8D70", VA = "0x1811F9D70")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83A0CF0", Offset = "0x839FCF0", VA = "0x1883A0CF0")]
		public MLQPBUJEIYI Add(JobHandle job)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83A1580", Offset = "0x83A0580", VA = "0x1883A1580")]
		public void Remove(MLQPBUJEIYI jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83A1060", Offset = "0x83A0060", VA = "0x1883A1060")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83A0EB0", Offset = "0x839FEB0", VA = "0x1883A0EB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83A0DE0", Offset = "0x839FDE0", VA = "0x1883A0DE0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83A1680", Offset = "0x83A0680", VA = "0x1883A1680")]
		public JobTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAF83D0", Offset = "0xAF73D0", VA = "0x180AF83D0", Slot = "6")]
		private bool MYJWFGSQJIY()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2263361147
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x83ADC00", Offset = "0x83ACC00", VA = "0x1883ADC00")]
	public static void WGYJPSYGJZZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x83ADBF0", Offset = "0x83ACBF0", VA = "0x1883ADBF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x83A7670", Offset = "0x83A6670", VA = "0x1883A7670")]
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
