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
				[Cpp2IlInjected.Address(RVA = "0x77EACE0", Offset = "0x77EA0E0", VA = "0x1877EACE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xCC34A0", Offset = "0xCC28A0", VA = "0x180CC34A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x77EACA0", Offset = "0x77EA0A0", VA = "0x1877EACA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77DC800", Offset = "0x77DBC00", VA = "0x1877DC800")]
		public LODSettings HBFGCJMBJEL(ICNEIPPCAOC KHCIAPOHNBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77DC810", Offset = "0x77DBC10", VA = "0x1877DC810")]
		public int LKGPEKNDPBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77DC760", Offset = "0x77DBB60", VA = "0x1877DC760")]
		public int BMFJJNKLMEK(bool DMLEKPLJMIG, Vector3 NOPGNMBEFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77DC830", Offset = "0x77DBC30", VA = "0x1877DC830")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MPPPKKOECLI
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
public interface KEOOGJDDLAC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAHLDIOCGGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AEAACOKMDIA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ALDHPHBDNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<KPPCPIFKCKH> NHLCCACHPAE
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
	void UpdateClusterDistances(Vector3 HDCIJLICBPE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(BGFHOFOIIDK DMJKAPFLGHP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KPPCPIFKCKH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int NDGAPMJFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JBACHKAOKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float ODEGOMADFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FAMEKLILKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte CKLHJAIKFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NJGOHLIGODB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IGMNKMEPLKK
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
	private struct NKBCCMPHFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NJGOHLIGODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public APGKENHKANG<string>.EEEKGBDKLHP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private APGKENHKANG<string>.EEEKGBDKLHP <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77EEB00", Offset = "0x77EDF00", VA = "0x1877EEB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77EF290", Offset = "0x77EE690", VA = "0x1877EF290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JECMAMGPKEN : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NJGOHLIGODB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public JECMAMGPKEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77E5100", Offset = "0x77E4500", VA = "0x1877E5100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77E5230", Offset = "0x77E4630", VA = "0x1877E5230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JPNCEFAJJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NJGOHLIGODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public APGKENHKANG<string>.EEEKGBDKLHP worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private APGKENHKANG<string>.EEEKGBDKLHP <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77E5380", Offset = "0x77E4780", VA = "0x1877E5380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77E6BE0", Offset = "0x77E5FE0", VA = "0x1877E6BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HKDGEMFOJEC : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NJGOHLIGODB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public HKDGEMFOJEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E90", Offset = "0x77E3290", VA = "0x1877E3E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77E4B80", Offset = "0x77E3F80", VA = "0x1877E4B80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int IHFIELNJADC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan AEEEJAGANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer NPOCGEPCOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter FJCHKGCCEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject CGEDDMMDIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject JCMJFGPPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EAOOMOBPHKK BLLKBLIOOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<BGFHOFOIIDK> CGCJPFKGJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<BGFHOFOIIDK> BMFCPPIOBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<BGFHOFOIIDK> JCAICBHENLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DGPLDNPEPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IGMNKMEPLKK OIKDPAMOHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<AEAACOKMDIA>[] DEDDHMGECEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KPPCPIFKCKH>[] AENHNKHDEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource KHMPINDCMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool NDMIDFLGLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LBKCJDEOHAA GGEHFIDEJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LBKCJDEOHAA PKFABKCANMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int KDJFINJNPHP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static NJGOHLIGODB CIGDLNGNHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly POCHECLLBPF IDKPBNNBBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OBILEAHDDBD FDAAPODDAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour ABAEAMLMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material ENCPAOAPGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> IIHEEENOMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material ILMEFBDLGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> OJOAPJMBMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool OFJAADDEEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<KEOOGJDDLAC> FIKFKFKNAHL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig EGIALEKFNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 BHIPLJMDHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1CAA860", Offset = "0x1CA9C60", VA = "0x181CAA860")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1CAA780", Offset = "0x1CA9B80", VA = "0x181CAA780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IGMNKMEPLKK ODANBIMJDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE62A20", Offset = "0xE61E20", VA = "0x180E62A20")]
		get
		{
			return default(IGMNKMEPLKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77ED8D0", Offset = "0x77ECCD0", VA = "0x1877ED8D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NJGOHLIGODB DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77ED750", Offset = "0x77ECB50", VA = "0x1877ED750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool EEIBGMMAPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77ED530", Offset = "0x77EC930", VA = "0x1877ED530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BHCCMEKGAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77EB2C0", Offset = "0x77EA6C0", VA = "0x1877EB2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> CKJECKBJJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77EB020", Offset = "0x77EA420", VA = "0x1877EB020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77ECAC0", Offset = "0x77EBEC0", VA = "0x1877ECAC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AHGBIKJKNKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77ED7A0", Offset = "0x77ECBA0", VA = "0x1877ED7A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77EB380", Offset = "0x77EA780", VA = "0x1877EB380")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77EE380", Offset = "0x77ED780", VA = "0x1877EE380")]
	public NJGOHLIGODB(POCHECLLBPF IDKPBNNBBEA, OBILEAHDDBD FDAAPODDAIH, ClusterLODConfig BAMICBAFFEM, MonoBehaviour ABAEAMLMBOD, Material MKMAEKJHLIH, ClusterMeshRenderer NPOCGEPCOON, MeshFilter FJCHKGCCEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77EC000", Offset = "0x77EB400", VA = "0x1877EC000")]
	private void GCHFMCJCAAD(Material MKMAEKJHLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77EB620", Offset = "0x77EAA20", VA = "0x1877EB620")]
	public void DFIBOEEPLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77EB600", Offset = "0x77EAA00", VA = "0x1877EB600")]
	public static NPAHDDNJHLF.MNELIAFCNOE CKGABCFHBCF(NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG)
	{
		return default(NPAHDDNJHLF.MNELIAFCNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77EBAE0", Offset = "0x77EAEE0", VA = "0x1877EBAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77EC990", Offset = "0x77EBD90", VA = "0x1877EC990")]
	public static void HFAKGADPCDP(Vector3 NPFNFDLLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77EE200", Offset = "0x77ED600", VA = "0x1877EE200")]
	private void OLLHLJHDGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77ED460", Offset = "0x77EC860", VA = "0x1877ED460")]
	private void KAGLIJBIPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x77EBEB0", Offset = "0x77EB2B0", VA = "0x1877EBEB0")]
	private void ELCHNMILIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77EC2B0", Offset = "0x77EB6B0", VA = "0x1877EC2B0")]
	public void HAEPHMPBALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77EB9C0", Offset = "0x77EADC0", VA = "0x1877EB9C0")]
	[AsyncStateMachine(typeof(NKBCCMPHFMG))]
	public Task DPDEIIOKPDM(APGKENHKANG<string>.EEEKGBDKLHP FBCIPEGJMHP, CancellationToken BOHHBCNKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77ECFB0", Offset = "0x77EC3B0", VA = "0x1877ECFB0")]
	[IteratorStateMachine(typeof(JECMAMGPKEN))]
	private IEnumerator<CIKDDGFOAFI> IGLCEBKLOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77EDA00", Offset = "0x77ECE00", VA = "0x1877EDA00")]
	[AsyncStateMachine(typeof(JPNCEFAJJBN))]
	private Task NEJOAHIOIMA(APGKENHKANG<string>.EEEKGBDKLHP CBFCMIOBFGP, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77ED260", Offset = "0x77EC660", VA = "0x1877ED260")]
	public void JHGBDIEKKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77ED030", Offset = "0x77EC430", VA = "0x1877ED030")]
	public void JACMOHINMPL(IEnumerable<AEAACOKMDIA> PLCPFJAFOKG, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77EB6C0", Offset = "0x77EAAC0", VA = "0x1877EB6C0")]
	public void DKFKOHNIGNL(IEnumerable<AEAACOKMDIA> PLCPFJAFOKG, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77EDB20", Offset = "0x77ECF20", VA = "0x1877EDB20")]
	public List<ClusterMeshRenderer> OEIDICKLAOJ(List<BGFHOFOIIDK> JJBMHDOLHOO, FGCPOOOBBED BKHMOJGGBFN, MPPPKKOECLI DMGLPHIJGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77ED6B0", Offset = "0x77ECAB0", VA = "0x1877ED6B0")]
	public void KPBNOGEOHMN(KEOOGJDDLAC IIIMKNJHFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77EB5A0", Offset = "0x77EA9A0", VA = "0x1877EB5A0")]
	public bool BLKAMJNLMNO(KEOOGJDDLAC IIIMKNJHFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77ECF50", Offset = "0x77EC350", VA = "0x1877ECF50")]
	public void IEOHCFMNKHH(BGFHOFOIIDK PIMLKCMKMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77EB0E0", Offset = "0x77EA4E0", VA = "0x1877EB0E0")]
	public void AKEOENAGIME(KPPCPIFKCKH KEEIIFLKIND, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77EE290", Offset = "0x77ED690", VA = "0x1877EE290")]
	public void PKPBBIBFAHO(KPPCPIFKCKH KEEIIFLKIND, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77EC170", Offset = "0x77EB570", VA = "0x1877EC170")]
	private void GMMBFCEHGLA(Vector3 HDCIJLICBPE, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77EB160", Offset = "0x77EA560", VA = "0x1877EB160")]
	private void BBMKDMHEJHB(Vector3 HDCIJLICBPE, MPPPKKOECLI DMGLPHIJGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77ED850", Offset = "0x77ECC50", VA = "0x1877ED850")]
	[IteratorStateMachine(typeof(HKDGEMFOJEC))]
	private IEnumerator<CIKDDGFOAFI> MBKGOLOMJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77EB430", Offset = "0x77EA830", VA = "0x1877EB430")]
	private int BGODJIBFPGC(int CJFNAFNJJLB, int CIMLNCBKELJ, List<KPPCPIFKCKH> DPPCALJPCCP, byte KHCIAPOHNBN, int NGEEAMCGOPA, float NENFMNFDAGF = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77ED0B0", Offset = "0x77EC4B0", VA = "0x1877ED0B0")]
	public void JEBJOEBLLEI(BGFHOFOIIDK DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77ECA80", Offset = "0x77EBE80", VA = "0x1877ECA80")]
	public bool HGAMFHDPDME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xC20DF0", Offset = "0xC201F0", VA = "0x180C20DF0")]
	public Material KLEOLFFJODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77ED620", Offset = "0x77ECA20", VA = "0x1877ED620")]
	public Material KLEOLFFJODN(NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x9B2AC0", Offset = "0x9B1EC0", VA = "0x1809B2AC0")]
	public Material HBLEOPMBENF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x77EC900", Offset = "0x77EBD00", VA = "0x1877EC900")]
	public Material HBLEOPMBENF(NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x77ED710", Offset = "0x77ECB10", VA = "0x1877ED710")]
	public int LKGPEKNDPBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x77ECB80", Offset = "0x77EBF80", VA = "0x1877ECB80")]
	public (long, int) HMJMHBPJEKP()
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
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct LEDMDOKODPC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> FKOFBGGNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> FPLAKNMCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> CDJLDGBLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> HIHCPAHEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> PEGFIHJCACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> NKPICFABLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> MNLPIAIBLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 LPJNOLHCOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float DHMPOMHNJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> OJBIJBCDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> ILNOGJMMMIM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x77E8F10", Offset = "0x77E8310", VA = "0x1877E8F10")]
	public LEDMDOKODPC(NPAHDDNJHLF MPJNANLNCGP, NativeList<float3> MNLPIAIBLMG, NativeParallelMultiHashMap<int, int> OJBIJBCDGOA, NativeArray<int> ILNOGJMMMIM, Vector3 LPJNOLHCOGA, float DHMPOMHNJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x77E8810", Offset = "0x77E7C10", VA = "0x1877E8810")]
	private int BAKMEAEJNKH(float3 HDCIJLICBPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77E8870", Offset = "0x77E7C70", VA = "0x1877E8870")]
	private int CBCPPOLAAFL(int JKHIIFLAPEC, int DJBLFBEBKGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x77E8AE0", Offset = "0x77E7EE0", VA = "0x1877E8AE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FOCAJLCLHEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> OJBIJBCDGOA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> ILNOGJMMMIM;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int HCHLCNCEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> DFIGKNJPMPD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x77E1A90", Offset = "0x77E0E90", VA = "0x1877E1A90")]
	public void PGGKGNOIBPG(int EBKIEOFJOIJ, Allocator JMEGNHGDHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x77E19B0", Offset = "0x77E0DB0", VA = "0x1877E19B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FOCAJLCLHEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HLOAMKNHMOG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> FABDBBHCOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> IBCEGPDBIGA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x77E4C80", Offset = "0x77E4080", VA = "0x1877E4C80")]
	public HLOAMKNHMOG(FOCAJLCLHEL PMBJDLCBPCJ, NPAHDDNJHLF MPJNANLNCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x77E4BD0", Offset = "0x77E3FD0", VA = "0x1877E4BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LHHPKAPDCIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> JOJHPNKCILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> KIIJKEJAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> LEDPDOGJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> EECMJFPAENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> IHIEMJOKKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> DFIGKNJPMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> FABDBBHCOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> AIBAOKHOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> KMHCEGKNOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> CBNFEDPGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> MBCPEJBKEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> ECKEGEMHDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> PENENNMCBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float FFNLJKNIBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float LMAOKENOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 HNHNFIPFKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float KALCJDFJAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float LGMMAAHHGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float KGELMMBOFHJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x77EA550", Offset = "0x77E9950", VA = "0x1877EA550")]
	public LHHPKAPDCIK(FOCAJLCLHEL EDPLCHMINOM, NPAHDDNJHLF MPJNANLNCGP, NPAHDDNJHLF ELECJLGIBJO, float LGMMAAHHGPB, float KGELMMBOFHJ, Vector3 HNHNFIPFKJP, float KALCJDFJAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77EA4A0", Offset = "0x77E98A0", VA = "0x1877EA4A0")]
	private float3 MNMNCPPKLGI(int JKHIIFLAPEC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77E9140", Offset = "0x77E8540", VA = "0x1877E9140")]
	private void CIMMKMDEKKP(int JKHIIFLAPEC, [Out] float3 HBHJHECONBP, [Out] float3 PCGACNGFLMC, [Out] float4 BPAHNEACHFH, [Out] float4 PJOPFBPGPDM, [Out] float2 CLGCPOCDEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77EA1C0", Offset = "0x77E95C0", VA = "0x1877EA1C0")]
	private int MAMCINKHCDP(int DMDFMLCFCFM, int MHEGJBPONAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77E9F00", Offset = "0x77E9300", VA = "0x1877E9F00")]
	private void FFHEOJJAGAJ(int DMDFMLCFCFM, int MHEGJBPONAH, int EAFEOFPFPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x77E8FF0", Offset = "0x77E83F0", VA = "0x1877E8FF0")]
	private bool CAFEGPOACKM(int DMDFMLCFCFM, int MHEGJBPONAH, float BKOBKPKDGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77EA100", Offset = "0x77E9500", VA = "0x1877EA100")]
	private bool LJPMNIDAHIH(int DMDFMLCFCFM, int MHEGJBPONAH, int EAFEOFPFPJE, float BKOBKPKDGAA, bool PCECIFPLKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x77E9320", Offset = "0x77E8720", VA = "0x1877E9320")]
	private bool DAIIEHDOMMP(int DMDFMLCFCFM, int MHEGJBPONAH, int EAFEOFPFPJE, float BKOBKPKDGAA, bool PCECIFPLKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77E8FD0", Offset = "0x77E83D0", VA = "0x1877E8FD0")]
	private void BAGONAJGKPN(int DMDFMLCFCFM, int MHEGJBPONAH, int EAFEOFPFPJE, [Out] int KJPPBBGBFEN, [Out] int PMKFJBPIIIL, [Out] int KHFOPOFOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x77E9580", Offset = "0x77E8980", VA = "0x1877E9580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJBOBNELGCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HHBHJNNEHOJ : IDisposable, KPPCPIFKCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds KHEPMHAMELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<BGFHOFOIIDK> JJBMHDOLHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 ANOGNGJFFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 DGJFKABCOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int MALLNLHPMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NPAHDDNJHLF GBBFMJOJLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long HHDNOCBNJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FOCAJLCLHEL IJGCEGFNFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform BKHMOJGGBFN;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int PAFDHPMJHBF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x77E22B0", Offset = "0x77E16B0", VA = "0x1877E22B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh HMMLCPEBGOL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NPAHDDNJHLF.MNELIAFCNOE FLNOCHLOJLD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9C86A0", Offset = "0x9C7AA0", VA = "0x1809C86A0")]
			[CompilerGenerated]
			get
			{
				return default(NPAHDDNJHLF.MNELIAFCNOE);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCA56F0", Offset = "0xCA4AF0", VA = "0x180CA56F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh PIDPIHHEDJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9AA480", Offset = "0x9A9880", VA = "0x1809AA480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NPAHDDNJHLF.MNELIAFCNOE HIMBEHCONNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD9F9D0", Offset = "0xD9EDD0", VA = "0x180D9F9D0")]
			[CompilerGenerated]
			get
			{
				return default(NPAHDDNJHLF.MNELIAFCNOE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xDB5190", Offset = "0xDB4590", VA = "0x180DB5190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ODEGOMADFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xFBE920", Offset = "0xFBDD20", VA = "0x180FBE920", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1636E00", Offset = "0x1636200", VA = "0x181636E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte CKLHJAIKFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x159FCD0", Offset = "0x159F0D0", VA = "0x18159FCD0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x159D710", Offset = "0x159CB10", VA = "0x18159D710", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NDGAPMJFNMD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9E1050", Offset = "0x9E0450", VA = "0x1809E1050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x11E83A0", Offset = "0x11E77A0", VA = "0x1811E83A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int JBACHKAOKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9D1DA0", Offset = "0x9D11A0", VA = "0x1809D1DA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x11E84D0", Offset = "0x11E78D0", VA = "0x1811E84D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FAMEKLILKPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x77E2600", Offset = "0x77E1A00", VA = "0x1877E2600", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x77E1E90", Offset = "0x77E1290", VA = "0x1877E1E90")]
		public void DMHJGAABJAB(ICNEIPPCAOC KHCIAPOHNBN, [Out] int DJKABJIJCCF, [Out] int DHBNIJGGDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77E2430", Offset = "0x77E1830", VA = "0x1877E2430")]
		public void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x77E2380", Offset = "0x77E1780", VA = "0x1877E2380")]
		public void OACEINODMOE(Mesh MPJNANLNCGP, NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x77E22F0", Offset = "0x77E16F0", VA = "0x1877E22F0")]
		public void NILCBOFDLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77E2100", Offset = "0x77E1500", VA = "0x1877E2100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77E2620", Offset = "0x77E1A20", VA = "0x1877E2620")]
		public HHBHJNNEHOJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds KHEPMHAMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NPAHDDNJHLF.MNELIAFCNOE PHLGKODAEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<HHBHJNNEHOJ> KFJAIOKIHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public CMCLMOCFNEI BOPPCFKHCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer EAOBCLAGGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int BLJIFOIFPGH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh COEDCAHAAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ABKMJEPINCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F20", Offset = "0x9D7320", VA = "0x1809D7F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9D7D40", Offset = "0x9D7140", VA = "0x1809D7D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ALDHPHBDNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77E2930", Offset = "0x77E1D30", VA = "0x1877E2930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77E2980", Offset = "0x77E1D80", VA = "0x1877E2980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77E3D90", Offset = "0x77E3190", VA = "0x1877E3D90")]
	public int PAMOBLAOCLB(int AOLNGGAOIJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77E2740", Offset = "0x77E1B40", VA = "0x1877E2740")]
	public void CHIOFBIAAKG(LIJBJALIFKA PCHDCBKMDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x77E2F30", Offset = "0x77E2330", VA = "0x1877E2F30")]
	public void JMEGMJAELBO(Transform NPPOIBIJFKH, bool OPACCOAAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x77E2B00", Offset = "0x77E1F00", VA = "0x1877E2B00")]
	public bool FGBPKOBKNDG(bool CCAAKKGAOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77E3770", Offset = "0x77E2B70", VA = "0x1877E3770")]
	public void LOBCDLIANJG(Transform BKHMOJGGBFN, bool OPACCOAAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77E2CC0", Offset = "0x77E20C0", VA = "0x1877E2CC0")]
	public bool JEBJOEBLLEI(BGFHOFOIIDK DMJKAPFLGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77E3DC0", Offset = "0x77E31C0", VA = "0x1877E3DC0")]
	public HJBOBNELGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EAOOMOBPHKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<HJBOBNELGCO.HHBHJNNEHOJ> EPDIEPIAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ODBKHMGNCBJ EKJNJAGHFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<HJBOBNELGCO.HHBHJNNEHOJ> MGMLJBDANGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int HIBEAGCGLBA;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x77DE430", Offset = "0x77DD830", VA = "0x1877DE430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x77DE3B0", Offset = "0x77DD7B0", VA = "0x1877DE3B0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x77DE7C0", Offset = "0x77DDBC0", VA = "0x1877DE7C0")]
	public void JJBKLNLGAIJ(HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF, Transform BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77DE5E0", Offset = "0x77DD9E0", VA = "0x1877DE5E0")]
	public void JEBJOEBLLEI(HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77DEE90", Offset = "0x77DE290", VA = "0x1877DEE90")]
	private HJBOBNELGCO.HHBHJNNEHOJ PDJBJMIKAEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x77DE540", Offset = "0x77DD940", VA = "0x1877DE540")]
	private bool GCHCIKJBDBL(HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77DEE30", Offset = "0x77DE230", VA = "0x1877DEE30")]
	private void PDIEHNCFFOP(HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77DE510", Offset = "0x77DD910", VA = "0x1877DE510")]
	public bool EJINNIIMILE(HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77DEBA0", Offset = "0x77DDFA0", VA = "0x1877DEBA0")]
	public bool ODNOMLGNGJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77DEFD0", Offset = "0x77DE3D0", VA = "0x1877DEFD0")]
	private HJBOBNELGCO.HHBHJNNEHOJ POHNNKELOLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77DE880", Offset = "0x77DDC80", VA = "0x1877DE880")]
	public long KLCNEJOFFNL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x77DF040", Offset = "0x77DE440", VA = "0x1877DF040")]
	public EAOOMOBPHKK()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KFMEDAHDCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int COGBOBOBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int GGGDELKBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float GGOMLIDGJEP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<HJBOBNELGCO> FPECPJEBIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77E81F0", Offset = "0x77E75F0", VA = "0x1877E81F0")]
	public KFMEDAHDCKI(int COGBOBOBCOC, int GGGDELKBALA, float OIEHEKCFNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x77E7E30", Offset = "0x77E7230", VA = "0x1877E7E30")]
	public void HHEDKKCLJMG(FJFEOAIPIKA GOBKFGNKJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77E7D80", Offset = "0x77E7180", VA = "0x1877E7D80")]
	private int DMNFJMOFPAB(LIJBJALIFKA BLGGFHHEDNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77E7EE0", Offset = "0x77E72E0", VA = "0x1877E7EE0")]
	private void HHEDKKCLJMG(LIJBJALIFKA BLGGFHHEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x77E8150", Offset = "0x77E7550", VA = "0x1877E8150")]
	private void LPFADMCBCKN(LIJBJALIFKA BLGGFHHEDNC, HJBOBNELGCO PECPAHNEFOO)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, AEAACOKMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GHLJEBFKLNJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
			[DebuggerHidden]
			public GHLJEBFKLNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x77E1C80", Offset = "0x77E1080", VA = "0x1877E1C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x77E1E40", Offset = "0x77E1240", VA = "0x1877E1E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x77E1D90", Offset = "0x77E1190", VA = "0x1877E1D90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x77E1D90", Offset = "0x77E1190", VA = "0x1877E1D90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int ALDHPHBDNEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x77DE340", Offset = "0x77DD740", VA = "0x1877DE340", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<KPPCPIFKCKH> NHLCCACHPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x77DE320", Offset = "0x77DD720", VA = "0x1877DE320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> KFJAIOKIHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HJBOBNELGCO COEDCAHAAKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public MPPPKKOECLI DKLNIOELLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(MPPPKKOECLI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9A91B0", Offset = "0x9A85B0", VA = "0x1809A91B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool OILGCNCMMOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xBBE280", Offset = "0xBBD680", VA = "0x180BBE280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x77DC890", Offset = "0x77DBC90", VA = "0x1877DC890")]
		public static ClusterMeshRenderer Create(HJBOBNELGCO MPJNANLNCGP, ClusterMeshRenderer NPOCGEPCOON, MeshFilter FJCHKGCCEBL, FGCPOOOBBED BKHMOJGGBFN, MPPPKKOECLI DMGLPHIJGLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x77DCB00", Offset = "0x77DBF00", VA = "0x1877DCB00", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77DD5F0", Offset = "0x77DC9F0", VA = "0x1877DD5F0", Slot = "9")]
		public bool TryRemoveClusterLODComponent(BGFHOFOIIDK DMJKAPFLGHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x77DD3A0", Offset = "0x77DC7A0", VA = "0x1877DD3A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x77DD030", Offset = "0x77DC430", VA = "0x1877DD030")]
		public void Init(HJBOBNELGCO MPJNANLNCGP, MeshFilter FJCHKGCCEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x77DCB60", Offset = "0x77DBF60", VA = "0x1877DCB60")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x77DD720", Offset = "0x77DCB20", VA = "0x1877DD720", Slot = "7")]
		public void UpdateClusterDistances(Vector3 HDCIJLICBPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x77DD9D0", Offset = "0x77DCDD0", VA = "0x1877DD9D0", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77DCFB0", Offset = "0x77DC3B0", VA = "0x1877DCFB0")]
		[IteratorStateMachine(typeof(GHLJEBFKLNJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x77DD430", Offset = "0x77DC830", VA = "0x1877DD430")]
		public void SetupTagAndLayer(string AAOLLMPNAHE, int DMGLPHIJGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77DD410", Offset = "0x77DC810", VA = "0x1877DD410")]
		public bool Remove(BGFHOFOIIDK DMJKAPFLGHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BIDKLCNPIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int ECGDANDAHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int GNPKFMEIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int DHBNIJGGDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int DJKABJIJCCF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x77DB120", Offset = "0x77DA520", VA = "0x1877DB120")]
	public BIDKLCNPIBA(int GNPKFMEIDNL, int DHBNIJGGDPM, int ECGDANDAHIA, int DJKABJIJCCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CMCLMOCFNEI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> FKOFBGGNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> DFIGKNJPMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> NKPICFABLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<BIDKLCNPIBA> LJPPJEAPPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> DLIHCGGPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> LAKIEALCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> DMGKHBGILPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle CNINKJDDJFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ECMLJIKMDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2B0", Offset = "0x9D96B0", VA = "0x1809DA2B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9D9360", Offset = "0x9D8760", VA = "0x1809D9360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x77DB350", Offset = "0x77DA750", VA = "0x1877DB350")]
	public void BECHPFCMIHE(NPAHDDNJHLF EEEGCFLOPMM, NativeList<BIDKLCNPIBA> LJPPJEAPPKC, float KJPCKOGHHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x77DC220", Offset = "0x77DB620", VA = "0x1877DC220")]
	public void CLNANDHFBOO(Transform BKHMOJGGBFN, bool OPACCOAAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x77DC5C0", Offset = "0x77DB9C0", VA = "0x1877DC5C0")]
	public void FGBPKOBKNDG(HJBOBNELGCO EAOBCLAGGPD, bool CCAAKKGAOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x77DC4B0", Offset = "0x77DB8B0", VA = "0x1877DC4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x77DC1F0", Offset = "0x77DB5F0", VA = "0x1877DC1F0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CMCLMOCFNEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct KGBABHMCHEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> FKOFBGGNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> DFIGKNJPMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<BIDKLCNPIBA> LIFNEEMNLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> DLIHCGGPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 HNHNFIPFKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> LAKIEALCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> DMGKHBGILPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool OPACCOAAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float PHGJNMIKHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float GECCGOJLBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float FBECANLJHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> NKPICFABLHD;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x77E8740", Offset = "0x77E7B40", VA = "0x1877E8740")]
	public KGBABHMCHEB(CMCLMOCFNEI FKBLNLLKCBD, Vector3 HNHNFIPFKJP, bool OPACCOAAIIP, float PHGJNMIKHHI, float GECCGOJLBBJ, float FBECANLJHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77E8240", Offset = "0x77E7640", VA = "0x1877E8240", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BGFHOFOIIDK : AIOFPJFDDDB
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds ADCNOCOKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LIJBJALIFKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<BGFHOFOIIDK> JJBMHDOLHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public LIJBJALIFKA KLDFHLFOOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public LIJBJALIFKA FAEAKHGMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public LIJBJALIFKA PGOPCGDFAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int DJKABJIJCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds KHEPMHAMELG;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x77EA690", Offset = "0x77E9A90", VA = "0x1877EA690")]
	public LIJBJALIFKA(List<BGFHOFOIIDK> JJBMHDOLHOO, [Optional] LIJBJALIFKA KLDFHLFOOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FJFEOAIPIKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<LIJBJALIFKA> KDGBJAMIJLO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LIJBJALIFKA HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x77E1880", Offset = "0x77E0C80", VA = "0x1877E1880")]
	public FJFEOAIPIKA(LIJBJALIFKA BKHMOJGGBFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EIIBDLKCPCI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LMOMGOMMNIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int KBHELEJMHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int NBLHBJMLMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int HHFLLIFMEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int ALJBJCHDEHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FKKBJONCHID : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int DNNFELDLDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float JCBAGABCENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<BGFHOFOIIDK> JJBMHDOLHOO;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x77E1950", Offset = "0x77E0D50", VA = "0x1877E1950", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum KGCPGIHLJNG
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
	private LMOMGOMMNIA LFMIHOIKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int KJGKONBNABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int COGBOBOBCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int GGGDELKBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float OIEHEKCFNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float APELFIOOEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<LIJBJALIFKA> JEHKNJFLHMB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FJFEOAIPIKA KHPDOINDAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x77E1480", Offset = "0x77E0880", VA = "0x1877E1480")]
	public EIIBDLKCPCI(int COGBOBOBCOC, int GGGDELKBALA, float OIEHEKCFNNE, int KJGKONBNABC, float APELFIOOEOF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x77DFE50", Offset = "0x77DF250", VA = "0x1877DFE50")]
	public void JFEFHKHNOAO(List<BGFHOFOIIDK> JJBMHDOLHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x77E1060", Offset = "0x77E0460", VA = "0x1877E1060")]
	public bool NBKCKEFHJMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x77DFE00", Offset = "0x77DF200", VA = "0x1877DFE00")]
	private float CBPMIFHDOIJ(Vector3 GCDIMBKCOPF, Vector3 IPOFNNMKDAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x77DFDE0", Offset = "0x77DF1E0", VA = "0x1877DFDE0")]
	private float CBPMIFHDOIJ(Vector3 MNDMOIHIBEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x77DF400", Offset = "0x77DE800", VA = "0x1877DF400")]
	private bool ADJGIPENEAM(LIJBJALIFKA AKPNDAHOCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x77E0020", Offset = "0x77DF420", VA = "0x1877E0020")]
	private FKKBJONCHID KMDNOMKFFLB(List<BGFHOFOIIDK> MNNKGOELPMM, KGCPGIHLJNG PDLPPFJPHCL)
	{
		return default(FKKBJONCHID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x77E10D0", Offset = "0x77E04D0", VA = "0x1877E10D0")]
	private void NMNLOJPEHEF(List<BGFHOFOIIDK> JJBMHDOLHOO, NativeArray<Vector3> FDNDCDFBDEB, NativeArray<Vector3> NJIIHBKKGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class FCBKLPMONLN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x77E16B0", Offset = "0x77E0AB0", VA = "0x1877E16B0")]
	public static Bounds LMJIAAGDFMD(List<BGFHOFOIIDK> JJBMHDOLHOO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x77E14E0", Offset = "0x77E08E0", VA = "0x1877E14E0")]
	public static int GGBILADAFKN(List<BGFHOFOIIDK> JJBMHDOLHOO, ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class CFKKGAFOPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool JICGKLLGEKK(float4* PEGFIHJCACG, int BFBCILDCBHG);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class OFIHHODEENL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr JKIHMMIKKLA;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr NKIPCAKCKGD;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x77F0C40", Offset = "0x77F0040", VA = "0x1877F0C40")]
		[BurstDiscard]
		private static void JLEHOHLGDMG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77F0D60", Offset = "0x77F0160", VA = "0x1877F0D60")]
		private static IntPtr PDAHEBPHBOM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77F09C0", Offset = "0x77EFDC0", VA = "0x1877F09C0")]
		public static void CJDCHOGEOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		public static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x77F0A60", Offset = "0x77EFE60", VA = "0x1877F0A60")]
		public unsafe static bool HKANHPMMIAO(float4* PEGFIHJCACG, int BFBCILDCBHG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x77DB140", Offset = "0x77DA540", VA = "0x1877DB140")]
	[BurstCompile]
	public unsafe static bool DDAEHCAPGNE(float4* PEGFIHJCACG, int BFBCILDCBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x77DAE80", Offset = "0x77DA280", VA = "0x1877DAE80")]
	[BurstCompile]
	public unsafe static bool EJOCEGEOADO(float4* PEGFIHJCACG, int BFBCILDCBHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct MJJAAOKKMEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> ONANBCEJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> FPPIMOICMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> LPHGMNCAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> JIPMDEDALBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> MBGNOGACFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> HIHCPAHEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> IJKLFIGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> IAPOHLPNAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<NPAHDDNJHLF.BPODABCKDGP> FEBFJFFOJBK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x77EAFB0", Offset = "0x77EA3B0", VA = "0x1877EAFB0")]
	public MJJAAOKKMEH(NPAHDDNJHLF MHPOBKGFIFD, NativeArray<bool> IJKLFIGNELJ, NativeList<ushort> IAPOHLPNAOL, NativeList<NPAHDDNJHLF.BPODABCKDGP> FEBFJFFOJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x77EAD00", Offset = "0x77EA100", VA = "0x1877EAD00", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct LLACACGCOKO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> ONANBCEJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> FPPIMOICMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> LPHGMNCAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> JIPMDEDALBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> MBGNOGACFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> HIHCPAHEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> PHGMJGMFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> DGOKPIFHEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> FNAMHLAFOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> BFHEFMIPOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> IECJHLPPAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> GIOKFDDDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> IJKLFIGNELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> IAPOHLPNAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<NPAHDDNJHLF.BPODABCKDGP> FEBFJFFOJBK;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x77EABE0", Offset = "0x77E9FE0", VA = "0x1877EABE0")]
	public LLACACGCOKO(NPAHDDNJHLF MHPOBKGFIFD, NPAHDDNJHLF ACJFIAOCMPO, NativeArray<bool> IJKLFIGNELJ, NativeList<ushort> IAPOHLPNAOL, NativeList<NPAHDDNJHLF.BPODABCKDGP> FEBFJFFOJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x77EA710", Offset = "0x77E9B10", VA = "0x1877EA710", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ODBKHMGNCBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NPAHDDNJHLF IMEBGOFEKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private NPAHDDNJHLF MHPOBKGFIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> INPOLEGMDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> IAPOHLPNAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<NPAHDDNJHLF.BPODABCKDGP> FEBFJFFOJBK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static NPAHDDNJHLF JHCHOBFBBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private LKLKEOMLKBG OPJGGABFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DGAEOBIFNFN MPFLNIDPMNK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle CNINKJDDJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F10", Offset = "0xBA3310", VA = "0x180BA3F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HJBOBNELGCO.HHBHJNNEHOJ AKPNDAHOCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AIGBDIKOIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x223F6F0", Offset = "0x223EAF0", VA = "0x18223F6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x77EFF20", Offset = "0x77EF320", VA = "0x1877EFF20")]
	[IDEKGKHHECE(MPEIPIAKFID.EnteredEditMode, 0)]
	private static void ECHHEBFPDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x77EF2F0", Offset = "0x77EE6F0", VA = "0x1877EF2F0")]
	public void BECHPFCMIHE(HJBOBNELGCO.HHBHJNNEHOJ LIFNEEMNLGO, Transform MAFOALGILDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x77EFF90", Offset = "0x77EF390", VA = "0x1877EFF90")]
	public void MLIAGCENJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x77EFE50", Offset = "0x77EF250", VA = "0x1877EFE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x77EFE10", Offset = "0x77EF210", VA = "0x1877EFE10")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x77F0850", Offset = "0x77EFC50", VA = "0x1877F0850")]
	public ODBKHMGNCBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OBILEAHDDBD
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 BNPDGAFAKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface POCHECLLBPF
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(APGKENHKANG<string>.EEEKGBDKLHP CBFCMIOBFGP, CancellationToken LMNHDKIFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KPAMOMNGCCD
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPAMOMNGCCD EBJJNAKELMP(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPAMOMNGCCD NCPKNLKGKBI(Action IOPCFKOHPBF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class IOELFIHACGC : KPAMOMNGCCD
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class EEIFBMKDOEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public IOELFIHACGC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
				public EEIFBMKDOEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x77DF3B0", Offset = "0x77DE7B0", VA = "0x1877DF3B0")]
				internal void NOHIFMNCGAO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x77DF360", Offset = "0x77DE760", VA = "0x1877DF360")]
				internal void MFBLKHJDHJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x77DF310", Offset = "0x77DE710", VA = "0x1877DF310")]
				internal void LMIDEPIDMLC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> ABMOBJFMIJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action NDIDNJOHMEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action CAFJLKOAKEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private OMIOCKFPBNH IAIFMMGDKNL;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action IMPLFHBKOPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action EDOAAINCOBA
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E6C0", Offset = "0x4C0DAC0", VA = "0x184C0E6C0", Slot = "4")]
			public KPAMOMNGCCD EBJJNAKELMP(Action IOPCFKOHPBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x71B51F0", Offset = "0x71B45F0", VA = "0x1871B51F0", Slot = "5")]
			public KPAMOMNGCCD NCPKNLKGKBI(Action IOPCFKOHPBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
			public IOELFIHACGC(Func<JobHandle> FIFKCBIJEKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x77E4CB0", Offset = "0x77E40B0", VA = "0x1877E4CB0")]
			public void AMNMBKBGPIL(Action JIOICOEHAMN, Action MAIPHHKDABH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x77E4F70", Offset = "0x77E4370", VA = "0x1877E4F70")]
			public void JEBJOEBLLEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class DLBABGLCCEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public KPAMOMNGCCD jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public DLBABGLCCEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x77DE3A0", Offset = "0x77DD7A0", VA = "0x1877DE3A0")]
			internal bool AFNGAGMICKL(IOELFIHACGC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ECLBLAIHBMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public IOELFIHACGC newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public ECLBLAIHBMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x77DF2B0", Offset = "0x77DE6B0", VA = "0x1877DF2B0")]
			internal void CAHNGJIOMIJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<IOELFIHACGC> EKFKOKPAKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<IOELFIHACGC> HDHNHELOMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private LBKCJDEOHAA EJOKOEIIKLI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public JHLMMGOJCLI ONBMELGEDCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77E6C40", Offset = "0x77E6040", VA = "0x1877E6C40")]
		public KPAMOMNGCCD Add(Func<JobHandle> FIFKCBIJEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77E6F70", Offset = "0x77E6370", VA = "0x1877E6F70")]
		public void Remove(KPAMOMNGCCD CNINKJDDJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77E6DA0", Offset = "0x77E61A0", VA = "0x1877E6DA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77E7150", Offset = "0x77E6550", VA = "0x1877E7150")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77E73B0", Offset = "0x77E67B0", VA = "0x1877E73B0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x77E6D90", Offset = "0x77E6190", VA = "0x1877E6D90")]
		[CompilerGenerated]
		private void JABADHFLMOJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OMIOCKFPBNH
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMIOCKFPBNH EBJJNAKELMP(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMIOCKFPBNH HHAOONEMMAB(Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMIOCKFPBNH NCPKNLKGKBI(Action IOPCFKOHPBF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, LEGAGIOCBAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class AMPCONEJOGH : OMIOCKFPBNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle PBLGHCLCAJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action NDIDNJOHMEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action HJOFJNMLEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action EDOAAINCOBA;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool IAEHNHFNHAH
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x77DB110", Offset = "0x77DA510", VA = "0x1877DB110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA840", Offset = "0x6FB9C40", VA = "0x186FBA840", Slot = "4")]
			public OMIOCKFPBNH EBJJNAKELMP(Action IOPCFKOHPBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA4D0", Offset = "0x6FB98D0", VA = "0x186FBA4D0", Slot = "5")]
			public OMIOCKFPBNH HHAOONEMMAB(Action IOPCFKOHPBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x71B51F0", Offset = "0x71B45F0", VA = "0x1871B51F0", Slot = "6")]
			public OMIOCKFPBNH NCPKNLKGKBI(Action IOPCFKOHPBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xE918F0", Offset = "0xE90CF0", VA = "0x180E918F0")]
			public AMPCONEJOGH(JobHandle MHLMPJCGGFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x77DB070", Offset = "0x77DA470", VA = "0x1877DB070")]
			public void CKDFENAGPAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x77DB0C0", Offset = "0x77DA4C0", VA = "0x1877DB0C0")]
			public void JEBJOEBLLEI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<AMPCONEJOGH> NCHHLJJONNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> HDCGONPCKJO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x77E7990", Offset = "0x77E6D90", VA = "0x1877E7990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1303030", Offset = "0x1302430", VA = "0x181303030")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77E7490", Offset = "0x77E6890", VA = "0x1877E7490")]
		public OMIOCKFPBNH Add(JobHandle MHLMPJCGGFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x77E7BA0", Offset = "0x77E6FA0", VA = "0x1877E7BA0")]
		public void Remove(OMIOCKFPBNH CNINKJDDJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x77E77B0", Offset = "0x77E6BB0", VA = "0x1877E77B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x77E7600", Offset = "0x77E6A00", VA = "0x1877E7600", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x77E7530", Offset = "0x77E6930", VA = "0x1877E7530")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x77E7CA0", Offset = "0x77E70A0", VA = "0x1877E7CA0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9D6930", Offset = "0x9D5D30", VA = "0x1809D6930", Slot = "6")]
		private bool CBMMHJLPIMM()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x77F0EB0", Offset = "0x77F02B0", VA = "0x1877F0EB0")]
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
