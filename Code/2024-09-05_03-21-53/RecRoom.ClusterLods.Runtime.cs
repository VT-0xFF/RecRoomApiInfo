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
				[Cpp2IlInjected.Address(RVA = "0x6ADBA70", Offset = "0x6ADA470", VA = "0x186ADBA70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x178EDA0", Offset = "0x178D7A0", VA = "0x18178EDA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBA30", Offset = "0x6ADA430", VA = "0x186ADBA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ACBE70", Offset = "0x6ACA870", VA = "0x186ACBE70")]
		public LODSettings IGAICLAPONI(KALLCKNDJCE NDKONLLHKBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBE50", Offset = "0x6ACA850", VA = "0x186ACBE50")]
		public int BAHHBKMDEHK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBE80", Offset = "0x6ACA880", VA = "0x186ACBE80")]
		public int IKHKBCJJEHH(bool OKHBPJIKMMP, Vector3 GKCOMKPDHGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBF20", Offset = "0x6ACA920", VA = "0x186ACBF20")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AKHIJPDIDIN
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
public interface KHIHGMBEOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNFAALCABCD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BDHIJOEICPN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int NCFELCDDHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KMPAAOEDKEB> IHOJMACAICH
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
	void UpdateClusterDistances(Vector3 OADBGCPFPOE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(LFDHENDANBM PHMJIJLHMJK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KMPAAOEDKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int HNKJCDNPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int IDNCOJEOPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float LJFCDAAKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BCNOPHDKEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte CLFOFJJLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MBEOCPFJHBC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Control,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LowQualityShadow
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DPPHNAGIGGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PJAILNIGHPG
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
	private struct NFBHMIDBDGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DPPHNAGIGGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PFEDKLFBPJA<string>.BEABGGDOFCM stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBAF0", Offset = "0x6ADA4F0", VA = "0x186ADBAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC280", Offset = "0x6ADAC80", VA = "0x186ADC280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EKCDJLKHMBA : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DPPHNAGIGGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public EKCDJLKHMBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3DC0", Offset = "0x6AD27C0", VA = "0x186AD3DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3ED0", Offset = "0x6AD28D0", VA = "0x186AD3ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OGEKBJBEIEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DPPHNAGIGGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PFEDKLFBPJA<string>.BEABGGDOFCM worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private PFEDKLFBPJA<string>.BEABGGDOFCM <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD510", Offset = "0x6ADBF10", VA = "0x186ADD510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADED40", Offset = "0x6ADD740", VA = "0x186ADED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HLGFLAPEDHK : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public DPPHNAGIGGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public HLGFLAPEDHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6620", Offset = "0x6AD5020", VA = "0x186AD6620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7300", Offset = "0x6AD5D00", VA = "0x186AD7300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const int HJPPMEBAMDI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly TimeSpan ODOKKNJOPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ClusterMeshRenderer GEKIMHOEKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public MeshFilter LIDJHFIGMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GameObject KHJJECDDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject PEOOGOHHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NMLFHLJDNLL LOKLCBAJGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<LFDHENDANBM> JLHIDAGBICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<LFDHENDANBM> PDFNLBLCBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<LFDHENDANBM> CMIBGJJFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int IBBOIBJEFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PJAILNIGHPG IABOBPJIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public List<BDHIJOEICPN>[] BNPJLCKGEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private List<KMPAAOEDKEB>[] MIMGEPGHMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CancellationTokenSource LANEOKFBBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool GEKJDCCCAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private DABMKCAGAIA IJODJAAIDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DABMKCAGAIA HBGBAMPOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int CCFGKIGHNKF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static DPPHNAGIGGA NNFKEDJBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly BGFNGEFDJCH MGDGMJAKIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EOOEOLIJAMI MGOEDLHHNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MonoBehaviour DAFMOLIFFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Material FGNKCDMMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Material EKICMIIMCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Material LBHNPODEBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MBEOCPFJHBC FEJFPIMCGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<KHIHGMBEOEO> GNPIBMHBILB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig MLBGKFONLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 HJFJAIACEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8956B0", Offset = "0x8940B0", VA = "0x1808956B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x895430", Offset = "0x893E30", VA = "0x180895430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private PJAILNIGHPG PIBGKEIBOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92BE60", Offset = "0x92A860", VA = "0x18092BE60")]
		get
		{
			return default(PJAILNIGHPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE2D0", Offset = "0x6ACCCD0", VA = "0x186ACE2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DPPHNAGIGGA LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE9D0", Offset = "0x6ACD3D0", VA = "0x186ACE9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool CKDDCHGAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ACED00", Offset = "0x6ACD700", VA = "0x186ACED00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool FLEDLFAOOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0980", Offset = "0x6ACF380", VA = "0x186AD0980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> DNKBIPEOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD03C0", Offset = "0x6ACEDC0", VA = "0x186AD03C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0750", Offset = "0x6ACF150", VA = "0x186AD0750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LBBAMLHIAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF770", Offset = "0x6ACE170", VA = "0x186ACF770")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE820", Offset = "0x6ACD220", VA = "0x186ACE820")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0E20", Offset = "0x6ACF820", VA = "0x186AD0E20")]
	public DPPHNAGIGGA(BGFNGEFDJCH MGDGMJAKIKC, EOOEOLIJAMI MGOEDLHHNHN, ClusterLODConfig FPDKHBKKDNO, MonoBehaviour DAFMOLIFFNM, Material FGNKCDMMEFI, ClusterMeshRenderer GEKIMHOEKKJ, MeshFilter LIDJHFIGMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE140", Offset = "0x6ACCB40", VA = "0x186ACE140")]
	public void BMBKMCPDJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE8D0", Offset = "0x6ACD2D0", VA = "0x186ACE8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE010", Offset = "0x6ACCA10", VA = "0x186ACE010")]
	public static void AGIIKJGPALG(Vector3 OOGEJAILKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEDF0", Offset = "0x6ACD7F0", VA = "0x186ACEDF0")]
	private void HCMDCPFEJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF620", Offset = "0x6ACE020", VA = "0x186ACF620")]
	private void HPDGNFBFNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEE80", Offset = "0x6ACD880", VA = "0x186ACEE80")]
	private void HGCBGHNJMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEFD0", Offset = "0x6ACD9D0", VA = "0x186ACEFD0")]
	public void HLOJPLFOLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0630", Offset = "0x6ACF030", VA = "0x186AD0630")]
	[AsyncStateMachine(typeof(NFBHMIDBDGO))]
	public Task MJEKCDLPCBA(PFEDKLFBPJA<string>.BEABGGDOFCM BPFOFDNLKCD, CancellationToken OFDGBDFAIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF820", Offset = "0x6ACE220", VA = "0x186ACF820")]
	[IteratorStateMachine(typeof(EKCDJLKHMBA))]
	private IEnumerator<IHLHBLBKNMF> JLFLMKACPFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE700", Offset = "0x6ACD100", VA = "0x186ACE700")]
	[AsyncStateMachine(typeof(OGEKBJBEIEF))]
	private Task COAFKIEDFEB(PFEDKLFBPJA<string>.BEABGGDOFCM GLBJGAMPGIP, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEA20", Offset = "0x6ACD420", VA = "0x186ACEA20")]
	public void FFHEANBODCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF8A0", Offset = "0x6ACE2A0", VA = "0x186ACF8A0")]
	public void JNANGGNCKCN(IEnumerable<BDHIJOEICPN> AOFPBAFFMDH, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE400", Offset = "0x6ACCE00", VA = "0x186ACE400")]
	public void CHFOMNENIIK(IEnumerable<BDHIJOEICPN> AOFPBAFFMDH, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFCE0", Offset = "0x6ACE6E0", VA = "0x186ACFCE0")]
	public List<ClusterMeshRenderer> LMPKBPMKAAG(List<LFDHENDANBM> OKJEADAJJBB, HPFOPEMMFAI MGPJOGDJPHA, AKHIJPDIDIN MMOIPMHDPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEC20", Offset = "0x6ACD620", VA = "0x186ACEC20")]
	public void FJHKCNJBPNG(KHIHGMBEOEO MECEAHHOGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF960", Offset = "0x6ACE360", VA = "0x186ACF960")]
	public bool KJLCPKAFLGO(KHIHGMBEOEO MECEAHHOGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDFB0", Offset = "0x6ACC9B0", VA = "0x186ACDFB0")]
	public void AEKMPEGJBFI(LFDHENDANBM JKFOJBNDNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEC80", Offset = "0x6ACD680", VA = "0x186ACEC80")]
	public void GBOMMLHGOJM(KMPAAOEDKEB NKKPFKFLMOH, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF9C0", Offset = "0x6ACE3C0", VA = "0x186ACF9C0")]
	public void KKGFKODBOOB(KMPAAOEDKEB NKKPFKFLMOH, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFBA0", Offset = "0x6ACE5A0", VA = "0x186ACFBA0")]
	private void LIBHFINPEBN(Vector3 OADBGCPFPOE, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFA40", Offset = "0x6ACE440", VA = "0x186ACFA40")]
	private void LCECEOMNFNG(Vector3 OADBGCPFPOE, AKHIJPDIDIN MMOIPMHDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF6F0", Offset = "0x6ACE0F0", VA = "0x186ACF6F0")]
	[IteratorStateMachine(typeof(HLGFLAPEDHK))]
	private IEnumerator<IHLHBLBKNMF> IHEDKIBFIBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0810", Offset = "0x6ACF210", VA = "0x186AD0810")]
	private int NFEDCCHNNCH(int EBDDHAPIAHH, int HFHGIAAEPIL, List<KMPAAOEDKEB> EDEEKCELOMA, byte NDKONLLHKBF, int JBKMKHKNMFA, float OFNJLLBFLKL = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0480", Offset = "0x6ACEE80", VA = "0x186AD0480")]
	public void MIOFMOMIMDC(LFDHENDANBM PHMJIJLHMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF920", Offset = "0x6ACE320", VA = "0x186ACF920")]
	public bool JPMAJGHMIME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x93A2C0", Offset = "0x938CC0", VA = "0x18093A2C0")]
	public Material MIPALLKNDBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8DCF00", Offset = "0x8DB900", VA = "0x1808DCF00")]
	public Material PGBFKJKIDBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8882F0", Offset = "0x886CF0", VA = "0x1808882F0")]
	public Material BBLEKINPMPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE100", Offset = "0x6ACCB00", VA = "0x186ACE100")]
	public int BAHHBKMDEHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0A40", Offset = "0x6ACF440", VA = "0x186AD0A40")]
	public long OJBEMNHNFKH()
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
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct GNGBBNNLIGI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeList<float3> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float3> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeArray<float2> AIHJGKCDNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NativeArray<float4> ELCLOMHBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NativeList<int> KMBCFLOJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<float3> MBOHOPAGKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private float3 HAPKMNFKGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private float KCMAKPKENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeParallelMultiHashMap<int, int> GIDHIKKPOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AKCCLODIEHK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5F00", Offset = "0x6AD4900", VA = "0x186AD5F00")]
	public GNGBBNNLIGI(LCFLAENFPKH ANBKEJJPIHH, NativeList<float3> MBOHOPAGKGG, NativeParallelMultiHashMap<int, int> GIDHIKKPOCF, NativeArray<int> AKCCLODIEHK, Vector3 HAPKMNFKGAE, float KCMAKPKENAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5EA0", Offset = "0x6AD48A0", VA = "0x186AD5EA0")]
	private int INLLKNMGNIH(float3 OADBGCPFPOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5800", Offset = "0x6AD4200", VA = "0x186AD5800")]
	private int BEHGOOMDPHP(int PPNCECJAFNC, int JODEIIFHAPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5A70", Offset = "0x6AD4470", VA = "0x186AD5A70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OPCNDKLKBGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NativeParallelMultiHashMap<int, int> GIDHIKKPOCF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static NativeArray<int> AKCCLODIEHK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int PNINOBAJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> HPDBNLIBCBO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE80", Offset = "0x6ADD880", VA = "0x186ADEE80")]
	public void JAKKOBEPFMA(int OJDOODEMIJC, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEDA0", Offset = "0x6ADD7A0", VA = "0x186ADEDA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OPCNDKLKBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct CKDKGKOOCBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	public NativeList<int> MCKKPPDGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<int> BJBJGIMKJMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBE20", Offset = "0x6ACA820", VA = "0x186ACBE20")]
	public CKDKGKOOCBL(OPCNDKLKBGK AJBDODDKHOO, LCFLAENFPKH ANBKEJJPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBD70", Offset = "0x6ACA770", VA = "0x186ACBD70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EJDGBGKKDII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeList<float3> DGOFNOKMDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float3> AKEEMMFMAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> KBDDHLGDLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private NativeArray<float2> BGBKIENJFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private NativeArray<float4> KNKNMIHHKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<int> HPDBNLIBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<int> MCKKPPDGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<float3> OPKADPCBFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float3> AGMLKAOAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float4> IPBECDFAINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeArray<float4> EFHMMFJGIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<float2> NFAHKDIJBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<int> HCJCMOMKMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float BLJJCGIBILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	public float DFKCOAIHPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float3 JMACEJCBKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private float LBFLEIOBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private float JJLMBGGCKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	public float NGBAMCDGGDI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3C80", Offset = "0x6AD2680", VA = "0x186AD3C80")]
	public EJDGBGKKDII(OPCNDKLKBGK POGHPHAOGBN, LCFLAENFPKH ANBKEJJPIHH, LCFLAENFPKH FMIGLNNECOB, float JJLMBGGCKEB, float NGBAMCDGGDI, Vector3 JMACEJCBKBK, float LBFLEIOBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AD38E0", Offset = "0x6AD22E0", VA = "0x186AD38E0")]
	private float3 JAAIOBAMKLE(int PPNCECJAFNC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AD34E0", Offset = "0x6AD1EE0", VA = "0x186AD34E0")]
	private void GEABJMFAFNG(int PPNCECJAFNC, [Out] float3 IKDAHJHLDHG, [Out] float3 MBACPFMDOLG, [Out] float4 PHOHCADHKIB, [Out] float4 KBALDINPDKP, [Out] float2 EKBDFGGAPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3990", Offset = "0x6AD2390", VA = "0x186AD3990")]
	private int PGIHMFNDBIH(int EPKHLKKHDGK, int HKKPMDLDMDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AD36C0", Offset = "0x6AD20C0", VA = "0x186AD36C0")]
	private void HKNFAAGEOGK(int EPKHLKKHDGK, int HKKPMDLDMDC, int BKMGHPEEGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2A10", Offset = "0x6AD1410", VA = "0x186AD2A10")]
	private bool EHKAHAIDHAK(int EPKHLKKHDGK, int HKKPMDLDMDC, float ONJPBNPCHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AD26F0", Offset = "0x6AD10F0", VA = "0x186AD26F0")]
	private bool ACDNFLHLKOM(int EPKHLKKHDGK, int HKKPMDLDMDC, int BKMGHPEEGHA, float ONJPBNPCHAO, bool NMHLCPJDEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AD27B0", Offset = "0x6AD11B0", VA = "0x186AD27B0")]
	private bool DENLHLMFJBB(int EPKHLKKHDGK, int HKKPMDLDMDC, int BKMGHPEEGHA, float ONJPBNPCHAO, bool NMHLCPJDEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AD38C0", Offset = "0x6AD22C0", VA = "0x186AD38C0")]
	private void IHGHIOOJEKF(int EPKHLKKHDGK, int HKKPMDLDMDC, int BKMGHPEEGHA, [Out] int KPKFAOPAKEJ, [Out] int JLCDNCPAOLE, [Out] int HNNNGLJIAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2B60", Offset = "0x6AD1560", VA = "0x186AD2B60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EMEGHJJMLBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DNOGLPBOCLD : IDisposable, KMPAAOEDKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Bounds OBCBNEIIHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public List<LFDHENDANBM> OKJEADAJJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3 BGNIDAKDKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Vector3 BBOBCJAOEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int DDOKADMIGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LCFLAENFPKH FDEKOBEEKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long ICBMNACJDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OPCNDKLKBGK CJCJEJACOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Transform MGPJOGDJPHA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DJOJGLCOBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDB70", Offset = "0x6ACC570", VA = "0x186ACDB70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh HBDFONAOPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Mesh EHNHJFLLOIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float LJFCDAAKLDC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9ECC90", Offset = "0x9EB690", VA = "0x1809ECC90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x612AD50", Offset = "0x6129750", VA = "0x18612AD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public byte CLFOFJJLPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x907950", Offset = "0x906350", VA = "0x180907950")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x907970", Offset = "0x906370", VA = "0x180907970", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int HNKJCDNPOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9098C0", Offset = "0x9082C0", VA = "0x1809098C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x908A70", Offset = "0x907470", VA = "0x180908A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IDNCOJEOPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1058EE0", Offset = "0x10578E0", VA = "0x181058EE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1058A80", Offset = "0x1057480", VA = "0x181058A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float BCNOPHDKEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD7D0", Offset = "0x6ACC1D0", VA = "0x186ACD7D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDC50", Offset = "0x6ACC650", VA = "0x186ACDC50")]
		public void PIGIDPIGGNN(KALLCKNDJCE NDKONLLHKBF, [Out] int NBBEBMFLJHD, [Out] int AAFJIHGKCMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD9A0", Offset = "0x6ACC3A0", VA = "0x186ACD9A0")]
		public void FFAPCMHGNMM(KALLCKNDJCE NDKONLLHKBF, IEBIJPNOIHK OAENGBHPIII, int JKKHHBDKLJB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDBB0", Offset = "0x6ACC5B0", VA = "0x186ACDBB0")]
		public void MOLIIJIEALC(Mesh ANBKEJJPIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD740", Offset = "0x6ACC140", VA = "0x186ACD740")]
		public void BDJKHNPLNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD7F0", Offset = "0x6ACC1F0", VA = "0x186ACD7F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDEB0", Offset = "0x6ACC8B0", VA = "0x186ACDEB0")]
		public DNOGLPBOCLD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Bounds OBCBNEIIHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<DNOGLPBOCLD> OCKOCOKAGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public KDKIPEMKNLC HBOPFKOBCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ClusterMeshRenderer OMFPMCIAPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int MHIOGOPCJKC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh GLAHKBPOCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x886770", Offset = "0x885170", VA = "0x180886770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HEIMJLGKCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xC622D0", Offset = "0xC60CD0", VA = "0x180C622D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NCFELCDDHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD40A0", Offset = "0x6AD2AA0", VA = "0x186AD40A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3F20", Offset = "0x6AD2920", VA = "0x186AD3F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4710", Offset = "0x6AD3110", VA = "0x186AD4710")]
	public int JINNPEEPFOA(int HKNJBEDIBDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4740", Offset = "0x6AD3140", VA = "0x186AD4740")]
	public void LOEAOIJFDIC(PJCLJHDLNNP NEOOOPCCPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4B90", Offset = "0x6AD3590", VA = "0x186AD4B90")]
	public void MLHKPHOGMLE(Transform KLBJBBMLEPC, bool EMAKCACIOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5310", Offset = "0x6AD3D10", VA = "0x186AD5310")]
	public bool PJJJDJJELCG(bool GGLLKJDEPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AD40F0", Offset = "0x6AD2AF0", VA = "0x186AD40F0")]
	public void IFJAOKEPIIM(Transform MGPJOGDJPHA, bool EMAKCACIOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4920", Offset = "0x6AD3320", VA = "0x186AD4920")]
	public bool MIOFMOMIMDC(LFDHENDANBM PHMJIJLHMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AD54D0", Offset = "0x6AD3ED0", VA = "0x186AD54D0")]
	public EMEGHJJMLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NMLFHLJDNLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Queue<EMEGHJJMLBH.DNOGLPBOCLD> JEPHPCAJFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EEPPGMLIICF KJLKOOHJKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<EMEGHJJMLBH.DNOGLPBOCLD> FDCKMMCHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int CONDJPMEMEB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC570", Offset = "0x6ADAF70", VA = "0x186ADC570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC750", Offset = "0x6ADB150", VA = "0x186ADC750")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC5F0", Offset = "0x6ADAFF0", VA = "0x186ADC5F0")]
	public void EGHPKMGPEOO(EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC, Transform MGPJOGDJPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC830", Offset = "0x6ADB230", VA = "0x186ADC830")]
	public void MIOFMOMIMDC(EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCAB0", Offset = "0x6ADB4B0", VA = "0x186ADCAB0")]
	private EMEGHJJMLBH.DNOGLPBOCLD OAGKDEDANPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC6B0", Offset = "0x6ADB0B0", VA = "0x186ADC6B0")]
	private bool HDGLFJKEANG(EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC7D0", Offset = "0x6ADB1D0", VA = "0x186ADC7D0")]
	private void KKDFEMCOEPJ(EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCA10", Offset = "0x6ADB410", VA = "0x186ADCA10")]
	public bool MODCENIACIA(EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC2E0", Offset = "0x6ADACE0", VA = "0x186ADC2E0")]
	public bool DBMELBLEALE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCA40", Offset = "0x6ADB440", VA = "0x186ADCA40")]
	private EMEGHJJMLBH.DNOGLPBOCLD NEIEHCIEPDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCBF0", Offset = "0x6ADB5F0", VA = "0x186ADCBF0")]
	public long OJBEMNHNFKH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCF10", Offset = "0x6ADB910", VA = "0x186ADCF10")]
	public NMLFHLJDNLL()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HBDJFBMCCKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int NDHAHGOAHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int PCAEAIKCBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float FGNBHMBDEBI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<EMEGHJJMLBH> BLFKFNLHEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6570", Offset = "0x6AD4F70", VA = "0x186AD6570")]
	public HBDJFBMCCKJ(int NDHAHGOAHKB, int PCAEAIKCBON, float LELANPEJAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD62B0", Offset = "0x6AD4CB0", VA = "0x186AD62B0")]
	public void OMGMGJCLJMA(GENJDMJECGB BNGJOEGCJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5FC0", Offset = "0x6AD49C0", VA = "0x186AD5FC0")]
	private int KCOKAOKMHDB(PJCLJHDLNNP AJIEBFICGCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6360", Offset = "0x6AD4D60", VA = "0x186AD6360")]
	private void OMGMGJCLJMA(PJCLJHDLNNP AJIEBFICGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6070", Offset = "0x6AD4A70", VA = "0x186AD6070")]
	private void OFLNNDNNIJI(PJCLJHDLNNP AJIEBFICGCI, EMEGHJJMLBH LDPLGICPGND)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ClusterMeshRenderer : MonoBehaviour, BDHIJOEICPN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ILOHOANBKHJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
			[DebuggerHidden]
			public ILOHOANBKHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6AD95A0", Offset = "0x6AD7FA0", VA = "0x186AD95A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6AD9760", Offset = "0x6AD8160", VA = "0x186AD9760", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6AD96B0", Offset = "0x6AD80B0", VA = "0x186AD96B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6AD96B0", Offset = "0x6AD80B0", VA = "0x186AD96B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int NCFELCDDHJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD6E0", Offset = "0x6ACC0E0", VA = "0x186ACD6E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IEnumerable<KMPAAOEDKEB> IHOJMACAICH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD6C0", Offset = "0x6ACC0C0", VA = "0x186ACD6C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<MeshFilter> OCKOCOKAGKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public EMEGHJJMLBH GLAHKBPOCKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AKHIJPDIDIN EEOJBPACOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(AKHIJPDIDIN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x889420", Offset = "0x887E20", VA = "0x180889420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool LDEBFLBIBHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1D67AD0", Offset = "0x1D664D0", VA = "0x181D67AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBF80", Offset = "0x6ACA980", VA = "0x186ACBF80")]
		public static ClusterMeshRenderer Create(EMEGHJJMLBH ANBKEJJPIHH, ClusterMeshRenderer GEKIMHOEKKJ, MeshFilter LIDJHFIGMGO, HPFOPEMMFAI MGPJOGDJPHA, AKHIJPDIDIN MMOIPMHDPJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC2E0", Offset = "0x6ACACE0", VA = "0x186ACC2E0", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCBC0", Offset = "0x6ACB5C0", VA = "0x186ACCBC0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(LFDHENDANBM PHMJIJLHMJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC970", Offset = "0x6ACB370", VA = "0x186ACC970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC550", Offset = "0x6ACAF50", VA = "0x186ACC550")]
		public void Init(EMEGHJJMLBH ANBKEJJPIHH, MeshFilter LIDJHFIGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC340", Offset = "0x6ACAD40", VA = "0x186ACC340")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCCF0", Offset = "0x6ACB6F0", VA = "0x186ACCCF0", Slot = "7")]
		public void UpdateClusterDistances(Vector3 OADBGCPFPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCFA0", Offset = "0x6ACB9A0", VA = "0x186ACCFA0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC4D0", Offset = "0x6ACAED0", VA = "0x186ACC4D0")]
		[IteratorStateMachine(typeof(ILOHOANBKHJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCA00", Offset = "0x6ACB400", VA = "0x186ACCA00")]
		public void SetupTagAndLayer(string HAEMEJAGICK, int MMOIPMHDPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC9E0", Offset = "0x6ACB3E0", VA = "0x186ACC9E0")]
		public bool Remove(LFDHENDANBM PHMJIJLHMJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JPJFCBCDNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int BCMLGDGELOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int GLCOHEPGOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int AAFJIHGKCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NBBEBMFLJHD;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD97B0", Offset = "0x6AD81B0", VA = "0x186AD97B0")]
	public JPJFCBCDNBK(int GLCOHEPGOCK, int AAFJIHGKCMC, int BCMLGDGELOG, int NBBEBMFLJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KDKIPEMKNLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<float3> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<int> HPDBNLIBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<int> KMBCFLOJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<JPJFCBCDNBK> MHKDJGINCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<int> CPPHPNMDAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float3> NAHECOKOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<float> CGDGBOEFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public JobHandle KPAOAOAPKHJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LKCOBPNALCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x939760", Offset = "0x938160", VA = "0x180939760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x93AB90", Offset = "0x939590", VA = "0x18093AB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA720", Offset = "0x6AD9120", VA = "0x186ADA720")]
	public void FKBEJNBPEHL(LCFLAENFPKH KBKMOJHPPCD, NativeList<JPJFCBCDNBK> MHKDJGINCIK, float ADJNFMJNIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB600", Offset = "0x6ADA000", VA = "0x186ADB600")]
	public void OMLBDNNALKG(Transform MGPJOGDJPHA, bool EMAKCACIOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB890", Offset = "0x6ADA290", VA = "0x186ADB890")]
	public void PJJJDJJELCG(EMEGHJJMLBH OMFPMCIAPMD, bool GGLLKJDEPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA610", Offset = "0x6AD9010", VA = "0x186ADA610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB5D0", Offset = "0x6AD9FD0", VA = "0x186ADB5D0")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public KDKIPEMKNLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
public struct PPFEOMDPHFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	public NativeList<int> HPDBNLIBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<JPJFCBCDNBK> HHGPOLOILNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeArray<int> CPPHPNMDAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private float3 JMACEJCBKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<float3> NAHECOKOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private NativeArray<float> CGDGBOEFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private bool EMAKCACIOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private float OFGJAHJILHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private float HGNDJLEDJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float APPPJHNMCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeList<int> KMBCFLOJGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF600", Offset = "0x6ADE000", VA = "0x186ADF600")]
	public PPFEOMDPHFD(KDKIPEMKNLC CFNFAFIENHJ, Vector3 JMACEJCBKBK, bool EMAKCACIOGJ, float OFGJAHJILHI, float HGNDJLEDJPI, float APPPJHNMCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF0F0", Offset = "0x6ADDAF0", VA = "0x186ADF0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LFDHENDANBM : CIFAILKDFMK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Bounds HMHDFIIPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PJCLJHDLNNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public List<LFDHENDANBM> OKJEADAJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public PJCLJHDLNNP DLPGBMPJIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public PJCLJHDLNNP NACLMMIADBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public PJCLJHDLNNP MHALPBDEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public int NBBEBMFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Bounds OBCBNEIIHJO;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF070", Offset = "0x6ADDA70", VA = "0x186ADF070")]
	public PJCLJHDLNNP(List<LFDHENDANBM> OKJEADAJJBB, [Optional] PJCLJHDLNNP DLPGBMPJIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GENJDMJECGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public List<PJCLJHDLNNP> KMKHJEDEHNI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PJCLJHDLNNP AAHAADHCHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5730", Offset = "0x6AD4130", VA = "0x186AD5730")]
	public GENJDMJECGB(PJCLJHDLNNP MGPJOGDJPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HMHLPOLOFEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GCEHCLCAGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int FNFEILBHDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int MCFGAILKOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int GPNEIHDPIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int IMNEGHIJKMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct HIBJJOHMLJD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int MDEEJJEMNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float ADDEDKHHDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<LFDHENDANBM> OKJEADAJJBB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD65C0", Offset = "0x6AD4FC0", VA = "0x186AD65C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum KHOLOODPGLP
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
	private GCEHCLCAGOC BMJEJJPLHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int KAGKNLCCMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int NDHAHGOAHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int PCAEAIKCBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float LELANPEJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float JAILAIHJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Stack<PJCLJHDLNNP> OJILGGHHKLO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GENJDMJECGB JBACILNIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9540", Offset = "0x6AD7F40", VA = "0x186AD9540")]
	public HMHLPOLOFEJ(int NDHAHGOAHKB, int PCAEAIKCBON, float LELANPEJAIC, int KAGKNLCCMIB, float JAILAIHJANM = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7810", Offset = "0x6AD6210", VA = "0x186AD7810")]
	public void LCFKDOBEJGD(List<LFDHENDANBM> OKJEADAJJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD77A0", Offset = "0x6AD61A0", VA = "0x186AD77A0")]
	public bool FCFEGALCJPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7350", Offset = "0x6AD5D50", VA = "0x186AD7350")]
	private float BAPPGAGPJKO(Vector3 NLBIFNGGFFK, Vector3 AAGMKEOFFOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD73A0", Offset = "0x6AD5DA0", VA = "0x186AD73A0")]
	private float BAPPGAGPJKO(Vector3 MPLHLKNKHIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8B60", Offset = "0x6AD7560", VA = "0x186AD8B60")]
	private bool PDCIPEKPGHH(PJCLJHDLNNP LBFPLCODPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD79E0", Offset = "0x6AD63E0", VA = "0x186AD79E0")]
	private HIBJJOHMLJD OOICBHHKCAO(List<LFDHENDANBM> BCKEHLFOBGP, KHOLOODPGLP DAGJHAHCIND)
	{
		return default(HIBJJOHMLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD73C0", Offset = "0x6AD5DC0", VA = "0x186AD73C0")]
	private void CPEBOEBHLGE(List<LFDHENDANBM> OKJEADAJJBB, Span<Vector3> OGEBCNDJAMA, Span<Vector3> FEOEHEBJMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class BEKLBGIBKOA
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBB90", Offset = "0x6ACA590", VA = "0x186ACBB90")]
	public static Bounds JJAENFBHMNN(List<LFDHENDANBM> OKJEADAJJBB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB9C0", Offset = "0x6ACA3C0", VA = "0x186ACB9C0")]
	public static int CHNABFMIGAD(List<LFDHENDANBM> OKJEADAJJBB, KALLCKNDJCE NDKONLLHKBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EEPPGMLIICF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private LCFLAENFPKH CGCBNLGJIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LCFLAENFPKH PCMCMHJOMAM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static LCFLAENFPKH FBKIMFBAGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private JBIFMCPAACK GHCNMJDALHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IEBIJPNOIHK OAENGBHPIII;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JobHandle KPAOAOAPKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x94B370", Offset = "0x949D70", VA = "0x18094B370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EMEGHJJMLBH.DNOGLPBOCLD LBFPLCODPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GOGJBBMHHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x197ACE0", Offset = "0x19796E0", VA = "0x18197ACE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1EE0", Offset = "0x6AD08E0", VA = "0x186AD1EE0")]
	[ALOHFLAKNNE(OOMJJAJIPFF.ExitingPlayMode, 0)]
	private static void IHFNFMOJFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1650", Offset = "0x6AD0050", VA = "0x186AD1650")]
	public void FKBEJNBPEHL(EMEGHJJMLBH.DNOGLPBOCLD HHGPOLOILNA, Transform GCBODKHHFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1F50", Offset = "0x6AD0950", VA = "0x186AD1F50")]
	public void ILIHFPNLOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD15E0", Offset = "0x6ACFFE0", VA = "0x186AD15E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2600", Offset = "0x6AD1000", VA = "0x186AD2600")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2640", Offset = "0x6AD1040", VA = "0x186AD2640")]
	public EEPPGMLIICF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EOOEOLIJAMI
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Vector3 NLFHHDMFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BGFNGEFDJCH
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(PFEDKLFBPJA<string>.BEABGGDOFCM GLBJGAMPGIP, CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PGNFHAPCHPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGNFHAPCHPJ GCAOFBHMKEH(Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGNFHAPCHPJ CKFOFCHPAHM(Action ENNGIICFMFD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class OCAGALFGKKB : PGNFHAPCHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class FAJCMDOMMAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public OCAGALFGKKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public FAJCMDOMMAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6AD56E0", Offset = "0x6AD40E0", VA = "0x186AD56E0")]
				internal void MIBEJACPEHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6AD5690", Offset = "0x6AD4090", VA = "0x186AD5690")]
				internal void ECGOMNLAAEJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x6AD5640", Offset = "0x6AD4040", VA = "0x186AD5640")]
				internal void BAILLGGMDGC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private Func<JobHandle> AELEFHLBLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private Action OGOOOBHCMOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action CNMOABEIGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private MPHKNLPAIEM ABHEOFKALFK;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public Action IGMINNGEHPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Action IGPNOEOMGMH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x43191D0", Offset = "0x4317BD0", VA = "0x1843191D0", Slot = "4")]
			public PGNFHAPCHPJ GCAOFBHMKEH(Action ENNGIICFMFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x65970B0", Offset = "0x6595AB0", VA = "0x1865970B0", Slot = "5")]
			public PGNFHAPCHPJ CKFOFCHPAHM(Action ENNGIICFMFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
			public OCAGALFGKKB(Func<JobHandle> AIENPMNDEJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD0C0", Offset = "0x6ADBAC0", VA = "0x186ADD0C0")]
			public void IIGKFMPFNHH(Action BJGOGCAEBBF, Action KDIIKHKAFBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD380", Offset = "0x6ADBD80", VA = "0x186ADD380")]
			public void MIOFMOMIMDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CBDBMLHIDFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public PGNFHAPCHPJ jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public CBDBMLHIDFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBD60", Offset = "0x6ACA760", VA = "0x186ACBD60")]
			internal bool KOHDEHNABNB(OCAGALFGKKB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class MKDAJGNMGDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public OCAGALFGKKB newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public MKDAJGNMGDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBA90", Offset = "0x6ADA490", VA = "0x186ADBA90")]
			internal void KIIIDNJFAPO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Queue<OCAGALFGKKB> JEGFIHBHMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<OCAGALFGKKB> KJHHOOKJFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private DABMKCAGAIA FLKPEIAOFKI;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public LKIIJMPMNFD NLDCMPOBPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD97D0", Offset = "0x6AD81D0", VA = "0x186AD97D0")]
		public PGNFHAPCHPJ Add(Func<JobHandle> AIENPMNDEJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9B00", Offset = "0x6AD8500", VA = "0x186AD9B00")]
		public void Remove(PGNFHAPCHPJ KPAOAOAPKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9930", Offset = "0x6AD8330", VA = "0x186AD9930", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9CD0", Offset = "0x6AD86D0", VA = "0x186AD9CD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9F30", Offset = "0x6AD8930", VA = "0x186AD9F30")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9920", Offset = "0x6AD8320", VA = "0x186AD9920")]
		[CompilerGenerated]
		private void INONJIIBGOB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MPHKNLPAIEM
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPHKNLPAIEM GCAOFBHMKEH(Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPHKNLPAIEM NLDPJJODJJJ(Action ENNGIICFMFD);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPHKNLPAIEM CKFOFCHPAHM(Action ENNGIICFMFD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class ENJLMPIDFHB : MPHKNLPAIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private JobHandle BDHKPBOMKDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Action OGOOOBHCMOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Action NHKHPOCLCGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private Action IGPNOEOMGMH;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public bool BDNJHNKEMGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x6AD5630", Offset = "0x6AD4030", VA = "0x186AD5630")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x64A8930", Offset = "0x64A7330", VA = "0x1864A8930", Slot = "4")]
			public MPHKNLPAIEM GCAOFBHMKEH(Action ENNGIICFMFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x64A8950", Offset = "0x64A7350", VA = "0x1864A8950", Slot = "5")]
			public MPHKNLPAIEM NLDPJJODJJJ(Action ENNGIICFMFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x65970B0", Offset = "0x6595AB0", VA = "0x1865970B0", Slot = "6")]
			public MPHKNLPAIEM CKFOFCHPAHM(Action ENNGIICFMFD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x94B4C0", Offset = "0x949EC0", VA = "0x18094B4C0")]
			public ENJLMPIDFHB(JobHandle BHJADNCPAIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5590", Offset = "0x6AD3F90", VA = "0x186AD5590")]
			public void IEGBLMMEELB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6AD55E0", Offset = "0x6AD3FE0", VA = "0x186AD55E0")]
			public void MIOFMOMIMDC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<ENJLMPIDFHB> AMICIHFPIDH;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA430", Offset = "0x6AD8E30", VA = "0x186ADA430")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA010", Offset = "0x6AD8A10", VA = "0x186ADA010")]
		public MPHKNLPAIEM Add(JobHandle BHJADNCPAIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA330", Offset = "0x6AD8D30", VA = "0x186ADA330")]
		public void Remove(MPHKNLPAIEM KPAOAOAPKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA180", Offset = "0x6AD8B80", VA = "0x186ADA180", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA0B0", Offset = "0x6AD8AB0", VA = "0x186ADA0B0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA570", Offset = "0x6AD8F70", VA = "0x186ADA570")]
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
