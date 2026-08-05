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
				[Cpp2IlInjected.Address(RVA = "0x7386580", Offset = "0x7385980", VA = "0x187386580")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xC0ABB0", Offset = "0xC09FB0", VA = "0x180C0ABB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7386540", Offset = "0x7385940", VA = "0x187386540")]
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
		[Cpp2IlInjected.Address(RVA = "0x7376C50", Offset = "0x7376050", VA = "0x187376C50")]
		public LODSettings CLKNEFDAEAD(NNLGOHCCLAH GNAJNFCKONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7376C60", Offset = "0x7376060", VA = "0x187376C60")]
		public int LPCHNBGBGEA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7376BB0", Offset = "0x7375FB0", VA = "0x187376BB0")]
		public int BECEIJNKLDF(bool MAGODMJNKFE, Vector3 JHKFGPKFBII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7376C80", Offset = "0x7376080", VA = "0x187376C80")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DDCKELEONED
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
public interface GAKNKMDFLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOLAGDPNCLF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MIFNAPBCGHP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int NALFAFDKMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BFLPMOCJHIK> DIKAFDDACAA
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
	void UpdateClusterDistances(Vector3 MIGPGADKMKK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool TryRemoveClusterLODComponent(EJOALOBPCHE MEFMJJOMDFE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFLPMOCJHIK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int IELKCBODMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int MBNLDPKNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NNOLELLJELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CJEAMCILIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	byte JJPCCOLOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ILCFEDCEABB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IIJPBEKOMKK
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
	private struct EOLMBKAIFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ILCFEDCEABB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CancellationTokenSource <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <createWorldTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x737A680", Offset = "0x7379A80", VA = "0x18737A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x737AE10", Offset = "0x737A210", VA = "0x18737AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MAEOOBFEPFP : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ILCFEDCEABB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public MAEOOBFEPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73865A0", Offset = "0x73859A0", VA = "0x1873865A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73866D0", Offset = "0x7385AD0", VA = "0x1873866D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NOMONHHKLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ILCFEDCEABB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <waitForShapesTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x73870A0", Offset = "0x73864A0", VA = "0x1873870A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7388900", Offset = "0x7387D00", VA = "0x187388900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ODCBEJMMIHB : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ILCFEDCEABB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public ODCBEJMMIHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7388960", Offset = "0x7387D60", VA = "0x187388960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7389650", Offset = "0x7388A50", VA = "0x187389650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int FFBJFMAANMA = 3;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly TimeSpan DGHDBIBFLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ClusterMeshRenderer FKFDNBMFMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MeshFilter DAAAFJCCKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject BAJJLEPIKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject ILCEIELJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public AIFKEAKDEPK EMFIDGGCHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<EJOALOBPCHE> KEBEJGOEBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EJOALOBPCHE> CMEMOAMOKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<EJOALOBPCHE> FFNCPCAHKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int JHCOPEHEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IIJPBEKOMKK PNKBCGGFPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<MIFNAPBCGHP>[] ODEFLKGDKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<BFLPMOCJHIK>[] ALEKCGOHIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CancellationTokenSource BIOEBMDLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool CLGNIFPIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HPLGDNGCOKN AJFMGMCNEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HPLGDNGCOKN BCIFHNNJGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int NMKKKKCCLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static ILCFEDCEABB NHILJKJCKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DAEPAPJGIEM NCPLBEKPGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OELBKMGOPHF CLKCNBNOJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MonoBehaviour OELIBIJNFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Material KBAKBCFNAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<Material> CLCDLMKHNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Material LBCCHEGIDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<Material> FOKMNJIEBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LCFCJLEPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<GAKNKMDFLHA> PDPKEEBEMOA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ClusterLODConfig OFABDIKCLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 CKFLDEGAALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B69CF0", Offset = "0x1B690F0", VA = "0x181B69CF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B69C20", Offset = "0x1B69020", VA = "0x181B69C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private IIJPBEKOMKK CKDJDBNIEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD72810", Offset = "0xD71C10", VA = "0x180D72810")]
		get
		{
			return default(IIJPBEKOMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7381E40", Offset = "0x7381240", VA = "0x187381E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ILCFEDCEABB IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7381DF0", Offset = "0x73811F0", VA = "0x187381DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool GLJKLFKPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x737FE60", Offset = "0x737F260", VA = "0x18737FE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MNDEFMEBJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7382200", Offset = "0x7381600", VA = "0x187382200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> KNNCAHANIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7381D30", Offset = "0x7381130", VA = "0x187381D30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7380BF0", Offset = "0x737FFF0", VA = "0x187380BF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LCFFGNAEDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x737F5B0", Offset = "0x737E9B0", VA = "0x18737F5B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7380B40", Offset = "0x737FF40", VA = "0x187380B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73827F0", Offset = "0x7381BF0", VA = "0x1873827F0")]
	public ILCFEDCEABB(DAEPAPJGIEM NCPLBEKPGAL, OELBKMGOPHF CLKCNBNOJLD, ClusterLODConfig BKBDEOCMNIE, MonoBehaviour OELIBIJNFJL, Material JDCLDGHNLKK, ClusterMeshRenderer FKFDNBMFMCL, MeshFilter DAAAFJCCKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7381FF0", Offset = "0x73813F0", VA = "0x187381FF0")]
	private void NHHEDOOIEPM(Material JDCLDGHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7382160", Offset = "0x7381560", VA = "0x187382160")]
	public void NLDMGJFNKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7381F70", Offset = "0x7381370", VA = "0x187381F70")]
	public static FBFDINCPKFI.KMIBOCLMOJF MNBDKLBHBNO(FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA)
	{
		return default(FBFDINCPKFI.KMIBOCLMOJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x737FFF0", Offset = "0x737F3F0", VA = "0x18737FFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7380FD0", Offset = "0x73803D0", VA = "0x187380FD0")]
	public static void HBBBKHHECHM(Vector3 HLBKGEDLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7380F40", Offset = "0x7380340", VA = "0x187380F40")]
	private void HBBAJCPONGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7380570", Offset = "0x737F970", VA = "0x187380570")]
	private void FLELBCIPMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73825B0", Offset = "0x73819B0", VA = "0x1873825B0")]
	private void PEPABJIIJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73811B0", Offset = "0x73805B0", VA = "0x1873811B0")]
	public void IJHODLJEFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7380CB0", Offset = "0x73800B0", VA = "0x187380CB0")]
	[AsyncStateMachine(typeof(EOLMBKAIFIN))]
	public Task GIGNIMJPHBB(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7381130", Offset = "0x7380530", VA = "0x187381130")]
	[IteratorStateMachine(typeof(MAEOOBFEPFP))]
	private IEnumerator<FBLKJCIOKGP> IALHMGBEFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x737FD40", Offset = "0x737F140", VA = "0x18737FD40")]
	[AsyncStateMachine(typeof(NOMONHHKLIK))]
	private Task BKBMIIDCDJC(FGFDKLMANEA<string>.ICBJPFEBGDJ GIBFPHEODKG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7380940", Offset = "0x737FD40", VA = "0x187380940")]
	public void FNPHJMHKEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7381810", Offset = "0x7380C10", VA = "0x187381810")]
	public void IKEFCDPMKFM(IEnumerable<MIFNAPBCGHP> NHCGJLBPAHO, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7380640", Offset = "0x737FA40", VA = "0x187380640")]
	public void FMBDECHDMAA(IEnumerable<MIFNAPBCGHP> NHCGJLBPAHO, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x737F660", Offset = "0x737EA60", VA = "0x18737F660")]
	public List<ClusterMeshRenderer> BIHGGFPEHHD(List<EJOALOBPCHE> HNJACBMPMEA, LCHJICBNMPB JGHOOBNHEJB, DDCKELEONED GKKHJGBAALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73810D0", Offset = "0x73804D0", VA = "0x1873810D0")]
	public void HGCGKOKHHNK(GAKNKMDFLHA ODCILPJBJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7380510", Offset = "0x737F910", VA = "0x187380510")]
	public bool FDEJAGEDCHD(GAKNKMDFLHA ODCILPJBJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7381F90", Offset = "0x7381390", VA = "0x187381F90")]
	public void NDNMMIHAKIJ(EJOALOBPCHE NEGHHGFHGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x73824B0", Offset = "0x73818B0", VA = "0x1873824B0")]
	public void PDBHIAMPMCL(BFLPMOCJHIK MKJPICMBEDC, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7382530", Offset = "0x7381930", VA = "0x187382530")]
	public void PEIFPFOEBHH(BFLPMOCJHIK MKJPICMBEDC, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73803C0", Offset = "0x737F7C0", VA = "0x1873803C0")]
	private void EBIBCJMKENI(Vector3 MIGPGADKMKK, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x737F450", Offset = "0x737E850", VA = "0x18737F450")]
	private void AKLKEFMPFEJ(Vector3 MIGPGADKMKK, DDCKELEONED GKKHJGBAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7382700", Offset = "0x7381B00", VA = "0x187382700")]
	[IteratorStateMachine(typeof(ODCBEJMMIHB))]
	private IEnumerator<FBLKJCIOKGP> PFHPLGBGOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7380DD0", Offset = "0x73801D0", VA = "0x187380DD0")]
	private int GIPHFENLFCJ(int EAHKFAJBNDN, int AFEEMGEBBFA, List<BFLPMOCJHIK> OKDAGBFLEPN, byte GNAJNFCKONF, int MNKKPLFEAAH, float MDEBAEEKPMP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73822C0", Offset = "0x73816C0", VA = "0x1873822C0")]
	public void OCDDHDAHAOD(EJOALOBPCHE MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7382470", Offset = "0x7381870", VA = "0x187382470")]
	public bool PAPENBICGKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB6EF10", Offset = "0xB6E310", VA = "0x180B6EF10")]
	public Material LAEGCIDMCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7381C60", Offset = "0x7381060", VA = "0x187381C60")]
	public Material LAEGCIDMCBP(FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x94E8C0", Offset = "0x94DCC0", VA = "0x18094E8C0")]
	public Material DJKNEBNLHBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x737FF60", Offset = "0x737F360", VA = "0x18737FF60")]
	public Material DJKNEBNLHBI(FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7381CF0", Offset = "0x73810F0", VA = "0x187381CF0")]
	public int LPCHNBGBGEA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7381890", Offset = "0x7380C90", VA = "0x187381890")]
	public (long, int) JCBIOGAOGBD()
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
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BAANNKNFBGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeList<float3> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<float3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<float4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<float2> KHGMOPNBFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NativeArray<float4> EDEDDIPBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private NativeList<int> HKAJIOBOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> ODJMKNBGNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private float3 BGKJNHJMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private float FLCOPMAEDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeParallelMultiHashMap<int, int> DCBCECIPOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> JDCNFHIBGIA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73763E0", Offset = "0x73757E0", VA = "0x1873763E0")]
	public BAANNKNFBGA(FBFDINCPKFI LCGHOEMEOEK, NativeList<float3> ODJMKNBGNAJ, NativeParallelMultiHashMap<int, int> DCBCECIPOKN, NativeArray<int> JDCNFHIBGIA, Vector3 BGKJNHJMBDM, float FLCOPMAEDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7376380", Offset = "0x7375780", VA = "0x187376380")]
	private int IFJAJMOGHEA(float3 MIGPGADKMKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7375CE0", Offset = "0x73750E0", VA = "0x187375CE0")]
	private int AGDNCOGGDJJ(int BKHEBBAMMAK, int LKMGECEEGEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7375F50", Offset = "0x7375350", VA = "0x187375F50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GHAPEJPPKIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static NativeParallelMultiHashMap<int, int> DCBCECIPOKN;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static NativeArray<int> JDCNFHIBGIA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static int AMKCELBMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeList<int> GFKEJMENGMJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x737E850", Offset = "0x737DC50", VA = "0x18737E850")]
	public void NLKPFDGIMDD(int LMFBKOOOEDD, Allocator LEILKJFLDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x737E770", Offset = "0x737DB70", VA = "0x18737E770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GHAPEJPPKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct CIGKHPMABGH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	public NativeList<int> JPEGACICKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeList<int> NEBMBDKJDFH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7376B80", Offset = "0x7375F80", VA = "0x187376B80")]
	public CIGKHPMABGH(GHAPEJPPKIB IBLBGHEDIAF, FBFDINCPKFI LCGHOEMEOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7376AD0", Offset = "0x7375ED0", VA = "0x187376AD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EGNOFDONIAB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> MDINJBMBKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<float3> HGLFOJPFINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private NativeArray<float4> EPFOAFDPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeArray<float2> MLNAKENDILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private NativeArray<float4> GKABEBKBPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeList<int> GFKEJMENGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeList<int> JPEGACICKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<float3> HAAAAGEOMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<float3> AENEJNKBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<float4> CAHIOBLNJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeArray<float4> OLHPDNEMLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeArray<float2> IENOHCCDFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<int> NIKNDNIKPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	private float INJJMEBFKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public float NCOPNALABIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[ReadOnly]
	private float3 HLLEBBDLEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private float FLMPFEGLJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private float IPDKGCNDPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	public float HIAAOMCAGFP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x737A530", Offset = "0x7379930", VA = "0x18737A530")]
	public EGNOFDONIAB(GHAPEJPPKIB CGMGKHOKPCG, FBFDINCPKFI LCGHOEMEOEK, FBFDINCPKFI JHLLFBMECMK, float IPDKGCNDPMB, float HIAAOMCAGFP, Vector3 HLLEBBDLEMI, float FLMPFEGLJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x737A480", Offset = "0x7379880", VA = "0x18737A480")]
	private float3 OMPMBHKDNII(int BKHEBBAMMAK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7379D80", Offset = "0x7379180", VA = "0x187379D80")]
	private void LFFIILNKNKB(int BKHEBBAMMAK, [Out] float3 OOCPEAOIFNH, [Out] float3 JAHKDKFHNFA, [Out] float4 EOODIDAIACK, [Out] float4 JIOIBPMDIPC, [Out] float2 ECIOAOABMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7378FB0", Offset = "0x73783B0", VA = "0x187378FB0")]
	private int BIAMICLIPOC(int LAPJPBODJNE, int IAEDFOPLMLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7379F60", Offset = "0x7379360", VA = "0x187379F60")]
	private void MFJIEJKGJGB(int LAPJPBODJNE, int IAEDFOPLMLA, int KPAHBOKLIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7379290", Offset = "0x7378690", VA = "0x187379290")]
	private bool CEHJFPHPNNB(int LAPJPBODJNE, int IAEDFOPLMLA, float LDHHELHKJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x737A3C0", Offset = "0x73797C0", VA = "0x18737A3C0")]
	private bool NPDJEJHOKAL(int LAPJPBODJNE, int IAEDFOPLMLA, int KPAHBOKLIBE, float LDHHELHKJDB, bool MGMKKHAEPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x737A160", Offset = "0x7379560", VA = "0x18737A160")]
	private bool MLEDEBPGMBJ(int LAPJPBODJNE, int IAEDFOPLMLA, int KPAHBOKLIBE, float LDHHELHKJDB, bool MGMKKHAEPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7379D60", Offset = "0x7379160", VA = "0x187379D60")]
	private void IKAPHEBIJNG(int LAPJPBODJNE, int IAEDFOPLMLA, int KPAHBOKLIBE, [Out] int JBNJCGDAEGM, [Out] int HLPCDIAIOOP, [Out] int LHPMBPAJKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x73793E0", Offset = "0x73787E0", VA = "0x1873793E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FEKKDMCCMFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NFAPNHOCOEM : IDisposable, BFLPMOCJHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Bounds LMEMOMNCOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public List<EJOALOBPCHE> HNJACBMPMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Vector3 LPFCFBAAANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Vector3 LGDFJGFEIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int ICOPNBGDAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public FBFDINCPKFI KCLIAJAONIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public long GOJNPFKHBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GHAPEJPPKIB FMOPIANEOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Transform JGHOOBNHEJB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int FLKGIKALDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7386F40", Offset = "0x7386340", VA = "0x187386F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Mesh NKFLJMJIFKL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public FBFDINCPKFI.KMIBOCLMOJF BHBGJFNOFCG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x968620", Offset = "0x967A20", VA = "0x180968620")]
			[CompilerGenerated]
			get
			{
				return default(FBFDINCPKFI.KMIBOCLMOJF);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBF5FE0", Offset = "0xBF53E0", VA = "0x180BF5FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Mesh MGMMDPNJPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x94B7F0", Offset = "0x94ABF0", VA = "0x18094B7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public FBFDINCPKFI.KMIBOCLMOJF DEIEKDJFNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCED280", Offset = "0xCEC680", VA = "0x180CED280")]
			[CompilerGenerated]
			get
			{
				return default(FBFDINCPKFI.KMIBOCLMOJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xCEFDC0", Offset = "0xCEF1C0", VA = "0x180CEFDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float NNOLELLJELL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xED9A50", Offset = "0xED8E50", VA = "0x180ED9A50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x151EAC0", Offset = "0x151DEC0", VA = "0x18151EAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public byte JJPCCOLOEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1460FC0", Offset = "0x14603C0", VA = "0x181460FC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1460FD0", Offset = "0x14603D0", VA = "0x181460FD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int IELKCBODMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9811A0", Offset = "0x9805A0", VA = "0x1809811A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1108470", Offset = "0x1107870", VA = "0x181108470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MBNLDPKNIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x971C10", Offset = "0x971010", VA = "0x180971C10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1108C40", Offset = "0x1108040", VA = "0x181108C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CJEAMCILIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x73867F0", Offset = "0x7385BF0", VA = "0x1873867F0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7386CE0", Offset = "0x73860E0", VA = "0x187386CE0")]
		public void PLMFMGBKBMI(NNLGOHCCLAH GNAJNFCKONF, [Out] int EJENEKIJBLE, [Out] int BHEMEOKJHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7386B10", Offset = "0x7385F10", VA = "0x187386B10")]
		public void OOEKFELFHKF(NNLGOHCCLAH GNAJNFCKONF, AIIDIKHPDOL EALLMICPGEN, int NILELNIMHMO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7386A60", Offset = "0x7385E60", VA = "0x187386A60")]
		public void NELDKDGCAIN(Mesh LCGHOEMEOEK, FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73869D0", Offset = "0x7385DD0", VA = "0x1873869D0")]
		public void MFPGNJCEHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7386810", Offset = "0x7385C10", VA = "0x187386810", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7386F80", Offset = "0x7386380", VA = "0x187386F80")]
		public NFAPNHOCOEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Bounds LMEMOMNCOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public FBFDINCPKFI.KMIBOCLMOJF EAMOBEHFECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<NFAPNHOCOEM> IEDNNPILDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public JHMAOHFGPHC EEADHPPHNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ClusterMeshRenderer ADMEOFCKKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int KLICKGNNCCM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HBCKFNLBLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NHCGFMGBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x977EC0", Offset = "0x9772C0", VA = "0x180977EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NALFAFDKMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x737B810", Offset = "0x737AC10", VA = "0x18737B810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x737B4A0", Offset = "0x737A8A0", VA = "0x18737B4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x737B620", Offset = "0x737AA20", VA = "0x18737B620")]
	public int FDMEEFCGILK(int JDOANHGOPCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x737BAD0", Offset = "0x737AED0", VA = "0x18737BAD0")]
	public void OFIEHNDBDEM(GMGKEPEMFDE CKMFLOHMGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x737BCC0", Offset = "0x737B0C0", VA = "0x18737BCC0")]
	public void OOKACGDBADG(Transform JCKCCIGACED, bool OMFIAAEKLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x737B650", Offset = "0x737AA50", VA = "0x18737B650")]
	public bool LBLGMEJKDHJ(bool DBKJGACNCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x737AE70", Offset = "0x737A270", VA = "0x18737AE70")]
	public void CFOECCFKHPP(Transform JGHOOBNHEJB, bool OMFIAAEKLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x737B860", Offset = "0x737AC60", VA = "0x18737B860")]
	public bool OCDDHDAHAOD(EJOALOBPCHE MEFMJJOMDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x737C510", Offset = "0x737B910", VA = "0x18737C510")]
	public FEKKDMCCMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AIFKEAKDEPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Queue<FEKKDMCCMFK.NFAPNHOCOEM> KOOPILPHFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ALGEADBKCOD KNANIOMHHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<FEKKDMCCMFK.NFAPNHOCOEM> PPLHIICBMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int AMPFKOABHMK;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7373760", Offset = "0x7372B60", VA = "0x187373760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7373960", Offset = "0x7372D60", VA = "0x187373960")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73738A0", Offset = "0x7372CA0", VA = "0x1873738A0")]
	public void HBHDBABAKDP(FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID, Transform JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7373E40", Offset = "0x7373240", VA = "0x187373E40")]
	public void OCDDHDAHAOD(FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73739E0", Offset = "0x7372DE0", VA = "0x1873739E0")]
	private FEKKDMCCMFK.NFAPNHOCOEM NJPGBGAIKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7374020", Offset = "0x7373420", VA = "0x187374020")]
	private bool PFMIHCDJANA(FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7373840", Offset = "0x7372C40", VA = "0x187373840")]
	private void ECIHHGDOPDO(FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73736C0", Offset = "0x7372AC0", VA = "0x1873736C0")]
	public bool AFJIOAHCDPG(FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x73740C0", Offset = "0x73734C0", VA = "0x1873740C0")]
	public bool PLJNMJIHBJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x73736F0", Offset = "0x7372AF0", VA = "0x1873736F0")]
	private FEKKDMCCMFK.NFAPNHOCOEM DKMFOEGLLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7373B20", Offset = "0x7372F20", VA = "0x187373B20")]
	public long NPPOKBLGEOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7374350", Offset = "0x7373750", VA = "0x187374350")]
	public AIFKEAKDEPK()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LCHMHNFOCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int CLANDLEMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int CIKEPCMPMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float MEHLPDBBAGC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public List<FEKKDMCCMFK> HBEJPKEEAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x73860E0", Offset = "0x73854E0", VA = "0x1873860E0")]
	public LCHMHNFOCLG(int CLANDLEMCFJ, int CIKEPCMPMPI, float LBBMKNKOKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7386030", Offset = "0x7385430", VA = "0x187386030")]
	public void OOCPDJMNGDM(MKJHCBIGKEL DKLMGMKPPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7385C70", Offset = "0x7385070", VA = "0x187385C70")]
	private int CDPMNDGMGNC(GMGKEPEMFDE HPEELAFENFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7385DC0", Offset = "0x73851C0", VA = "0x187385DC0")]
	private void OOCPDJMNGDM(GMGKEPEMFDE HPEELAFENFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7385D20", Offset = "0x7385120", VA = "0x187385D20")]
	private void HIMEIKIANHE(GMGKEPEMFDE HPEELAFENFB, FEKKDMCCMFK ENCJDBBFIGD)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, MIFNAPBCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DPDJKNPEHOP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
			[DebuggerHidden]
			public DPDJKNPEHOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7378810", Offset = "0x7377C10", VA = "0x187378810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x73789D0", Offset = "0x7377DD0", VA = "0x1873789D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7378920", Offset = "0x7377D20", VA = "0x187378920", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7378920", Offset = "0x7377D20", VA = "0x187378920", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NALFAFDKMDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x73787B0", Offset = "0x7377BB0", VA = "0x1873787B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IEnumerable<BFLPMOCJHIK> DIKAFDDACAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7378790", Offset = "0x7377B90", VA = "0x187378790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<MeshFilter> IEDNNPILDOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FEKKDMCCMFK HBCKFNLBLKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public DDCKELEONED BGHCFMNFCJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DDCKELEONED);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x94DBD0", Offset = "0x94CFD0", VA = "0x18094DBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PCJEJCLODEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB00230", Offset = "0xAFF630", VA = "0x180B00230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7376CE0", Offset = "0x73760E0", VA = "0x187376CE0")]
		public static ClusterMeshRenderer Create(FEKKDMCCMFK LCGHOEMEOEK, ClusterMeshRenderer FKFDNBMFMCL, MeshFilter DAAAFJCCKKN, LCHJICBNMPB JGHOOBNHEJB, DDCKELEONED GKKHJGBAALN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7376F60", Offset = "0x7376360", VA = "0x187376F60", Slot = "8")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7377A60", Offset = "0x7376E60", VA = "0x187377A60", Slot = "9")]
		public bool TryRemoveClusterLODComponent(EJOALOBPCHE MEFMJJOMDFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7377810", Offset = "0x7376C10", VA = "0x187377810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73774A0", Offset = "0x73768A0", VA = "0x1873774A0")]
		public void Init(FEKKDMCCMFK LCGHOEMEOEK, MeshFilter DAAAFJCCKKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7376FC0", Offset = "0x73763C0", VA = "0x187376FC0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7377B90", Offset = "0x7376F90", VA = "0x187377B90", Slot = "7")]
		public void UpdateClusterDistances(Vector3 MIGPGADKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7377E40", Offset = "0x7377240", VA = "0x187377E40", Slot = "6")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7377420", Offset = "0x7376820", VA = "0x187377420")]
		[IteratorStateMachine(typeof(DPDJKNPEHOP))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73778A0", Offset = "0x7376CA0", VA = "0x1873778A0")]
		public void SetupTagAndLayer(string FHGNCBECHHF, int GKKHJGBAALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7377880", Offset = "0x7376C80", VA = "0x187377880")]
		public bool Remove(EJOALOBPCHE MEFMJJOMDFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AEOIILDBGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int LPCGKGGDNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EKDINNHMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BHEMEOKJHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int EJENEKIJBLE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x73736A0", Offset = "0x7372AA0", VA = "0x1873736A0")]
	public AEOIILDBGHB(int EKDINNHMJFC, int BHEMEOKJHOM, int LPCGKGGDNDB, int EJENEKIJBLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JHMAOHFGPHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeList<float3> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeList<int> GFKEJMENGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<int> HKAJIOBOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<AEOIILDBGHB> MJNBBHAMODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public NativeArray<int> HBFPHEMCCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public NativeArray<float3> GMHOFHINGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NativeArray<float> EMJMBMINBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public JobHandle NIJHHKONNDH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PKFLGBGJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x97A660", Offset = "0x979A60", VA = "0x18097A660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x979880", Offset = "0x978C80", VA = "0x180979880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7383030", Offset = "0x7382430", VA = "0x187383030")]
	public void CIDIOEOELJF(FBFDINCPKFI CKFAJHBOOLL, NativeList<AEOIILDBGHB> MJNBBHAMODP, float JJCKONKIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7384010", Offset = "0x7383410", VA = "0x187384010")]
	public void EKOAPNJOFGJ(Transform JGHOOBNHEJB, bool OMFIAAEKLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x73842D0", Offset = "0x73836D0", VA = "0x1873842D0")]
	public void LBLGMEJKDHJ(FEKKDMCCMFK ADMEOFCKKPF, bool DBKJGACNCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7383F00", Offset = "0x7383300", VA = "0x187383F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x73842A0", Offset = "0x73836A0", VA = "0x1873842A0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public JHMAOHFGPHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct BFGDHAOFPAG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<float3> KCNAIMLCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public NativeList<int> GFKEJMENGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeList<AEOIILDBGHB> CAOCMPFBAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<int> HBFPHEMCCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private float3 HLLEBBDLEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private NativeArray<float3> GMHOFHINGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ReadOnly]
	private NativeArray<float> EMJMBMINBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[ReadOnly]
	private bool OMFIAAEKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[ReadOnly]
	private float KKLILCOPMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	private float ODGCFAOFLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float FOOAHHNPCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NativeList<int> HKAJIOBOKII;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73769A0", Offset = "0x7375DA0", VA = "0x1873769A0")]
	public BFGDHAOFPAG(JHMAOHFGPHC LGIAGONGJCJ, Vector3 HLLEBBDLEMI, bool OMFIAAEKLIK, float KKLILCOPMPF, float ODGCFAOFLJH, float FOOAHHNPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73764A0", Offset = "0x73758A0", VA = "0x1873764A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EJOALOBPCHE : LOFFCANAFML
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	Bounds GGLGNDMHGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GMGKEPEMFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public List<EJOALOBPCHE> HNJACBMPMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public GMGKEPEMFDE LDIAONMHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public GMGKEPEMFDE LMHNPJKMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public GMGKEPEMFDE CPFJOCAAHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public int EJENEKIJBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Bounds LMEMOMNCOOO;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x737F3D0", Offset = "0x737E7D0", VA = "0x18737F3D0")]
	public GMGKEPEMFDE(List<EJOALOBPCHE> HNJACBMPMEA, [Optional] GMGKEPEMFDE LDIAONMHHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MKJHCBIGKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public List<GMGKEPEMFDE> GADFMCLGIDD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public GMGKEPEMFDE HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7386720", Offset = "0x7385B20", VA = "0x187386720")]
	public MKJHCBIGKEL(GMGKEPEMFDE JGHOOBNHEJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FLAAEFJLHKB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct EOBPJNPJBDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int CNKFDCMINGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int HBMCLJGFCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int DPHBBAEIMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int JHLAHDKMHDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GFDKIDLNMHI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int MLCDOKNLLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public float CIKBFDBACHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public List<EJOALOBPCHE> HNJACBMPMEA;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x737E710", Offset = "0x737DB10", VA = "0x18737E710", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MONKAFDDJAL
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
	private EOBPJNPJBDO OIHGODDBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int EKCHNJOCHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int CLANDLEMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int CIKEPCMPMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LBBMKNKOKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float FFCCPJELCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Stack<GMGKEPEMFDE> INAPHFIEFIA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MKJHCBIGKEL FGGGLMPJJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x737E6B0", Offset = "0x737DAB0", VA = "0x18737E6B0")]
	public FLAAEFJLHKB(int CLANDLEMCFJ, int CIKEPCMPMPI, float LBBMKNKOKBN, int EKCHNJOCHFK, float FFCCPJELCJG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x737C9A0", Offset = "0x737BDA0", VA = "0x18737C9A0")]
	public void EFLFKLELCGA(List<EJOALOBPCHE> HNJACBMPMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x737CB70", Offset = "0x737BF70", VA = "0x18737CB70")]
	public bool IEOKOFIDLIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x737CBE0", Offset = "0x737BFE0", VA = "0x18737CBE0")]
	private float JMMHDGKPJEG(Vector3 CDIPILBCKFB, Vector3 HCEBABCAMLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x737CC30", Offset = "0x737C030", VA = "0x18737CC30")]
	private float JMMHDGKPJEG(Vector3 IBMHAIHIDJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x737DCD0", Offset = "0x737D0D0", VA = "0x18737DCD0")]
	private bool LLONPHOCPPN(GMGKEPEMFDE ELKFMHJLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x737CC50", Offset = "0x737C050", VA = "0x18737CC50")]
	private GFDKIDLNMHI KEIFOMFGCOJ(List<EJOALOBPCHE> CHJGCPDBKNO, MONKAFDDJAL KKAMPHCBAHE)
	{
		return default(GFDKIDLNMHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x737C5E0", Offset = "0x737B9E0", VA = "0x18737C5E0")]
	private void ALHELKCKNLI(List<EJOALOBPCHE> HNJACBMPMEA, NativeArray<Vector3> ALELNEDFNGN, NativeArray<Vector3> JMHGOBGEJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KDBDJOCKPLI
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x73855B0", Offset = "0x73849B0", VA = "0x1873855B0")]
	public static Bounds AHMLIDFIJIH(List<EJOALOBPCHE> HNJACBMPMEA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7385780", Offset = "0x7384B80", VA = "0x187385780")]
	public static int OOONHBLCKPL(List<EJOALOBPCHE> HNJACBMPMEA, NNLGOHCCLAH GNAJNFCKONF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal class LIAFAJKMEPG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public unsafe delegate bool LJJNCIOKCBG(float4* EDEDDIPBAKP, int GIGAFKHMOHH);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class GJFDDDDNDCO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x737EBB0", Offset = "0x737DFB0", VA = "0x18737EBB0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x737EA50", Offset = "0x737DE50", VA = "0x18737EA50")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x737EED0", Offset = "0x737E2D0", VA = "0x18737EED0")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x737ECE0", Offset = "0x737E0E0", VA = "0x18737ECE0")]
		public unsafe static bool CNDNDIPPKBE(float4* EDEDDIPBAKP, int GIGAFKHMOHH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7386130", Offset = "0x7385530", VA = "0x187386130")]
	[BurstCompile]
	public unsafe static bool AJIAPJEDJFP(float4* EDEDDIPBAKP, int GIGAFKHMOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x73734B0", Offset = "0x73728B0", VA = "0x1873734B0")]
	[BurstCompile]
	public unsafe static bool JDFEHONINCL(float4* EDEDDIPBAKP, int GIGAFKHMOHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
public struct KPCOMPIEJBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[ReadOnly]
	private NativeList<int> EPLKJIAFONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeList<float3> BLEBKCPGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float3> LLOIIOBGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float4> OIEPNGPMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<float4> KAGJJOCEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<float2> KHGMOPNBFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[WriteOnly]
	public NativeArray<bool> NCGCFFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeList<ushort> KNADDHPHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<FBFDINCPKFI.GOCIBCNPJJK> IFMGBJPNCCB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7385C00", Offset = "0x7385000", VA = "0x187385C00")]
	public KPCOMPIEJBD(FBFDINCPKFI HPPKEDMGOLB, NativeArray<bool> NCGCFFAMOGF, NativeList<ushort> KNADDHPHBKK, NativeList<FBFDINCPKFI.GOCIBCNPJJK> IFMGBJPNCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7385950", Offset = "0x7384D50", VA = "0x187385950", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct EBFGADJEDIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private NativeList<int> EPLKJIAFONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NativeList<float3> BLEBKCPGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<float3> LLOIIOBGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float4> OIEPNGPMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<float4> KAGJJOCEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float2> KHGMOPNBFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeList<int> JNOMLHHPOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeList<float3> ABCCCLAPKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float3> PNKOHNHMFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float4> EHALHOPICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<float4> BAKJPBIAHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<float2> NLLIINKHJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[WriteOnly]
	public NativeArray<bool> NCGCFFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeList<ushort> KNADDHPHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeList<FBFDINCPKFI.GOCIBCNPJJK> IFMGBJPNCCB;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7378EF0", Offset = "0x73782F0", VA = "0x187378EF0")]
	public EBFGADJEDIC(FBFDINCPKFI HPPKEDMGOLB, FBFDINCPKFI OHDCHIIGPHG, NativeArray<bool> NCGCFFAMOGF, NativeList<ushort> KNADDHPHBKK, NativeList<FBFDINCPKFI.GOCIBCNPJJK> IFMGBJPNCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7378A20", Offset = "0x7377E20", VA = "0x187378A20", Slot = "4")]
	[BurstCompile]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ALGEADBKCOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private FBFDINCPKFI BKGJBJJDHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private FBFDINCPKFI HPPKEDMGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NativeArray<bool> CAAIACGEFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NativeList<ushort> KNADDHPHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NativeList<FBFDINCPKFI.GOCIBCNPJJK> IFMGBJPNCCB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static FBFDINCPKFI OOLLCJBAMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NFBJNLMOOIN GBAGKPNELCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private AIIDIKHPDOL EALLMICPGEN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JobHandle NIJHHKONNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xACB990", Offset = "0xACAD90", VA = "0x180ACB990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FEKKDMCCMFK.NFAPNHOCOEM ELKFMHJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AOHFGGDCFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x20CBAA0", Offset = "0x20CAEA0", VA = "0x1820CBAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7375AF0", Offset = "0x7374EF0", VA = "0x187375AF0")]
	[JBPLEELDMPC(GALPNODIPPP.EnteredEditMode, 0)]
	private static void PDJBCMJJIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7374EA0", Offset = "0x73742A0", VA = "0x187374EA0")]
	public void CIDIOEOELJF(FEKKDMCCMFK.NFAPNHOCOEM CAOCMPFBAHN, Transform AAIABIALBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x73745C0", Offset = "0x73739C0", VA = "0x1873745C0")]
	public void ANKBIHJNCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x73759E0", Offset = "0x7374DE0", VA = "0x1873759E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7375AB0", Offset = "0x7374EB0", VA = "0x187375AB0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7375B70", Offset = "0x7374F70", VA = "0x187375B70")]
	public ALGEADBKCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OELBKMGOPHF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Vector3 AMKLHENKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DAEPAPJGIEM
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(FGFDKLMANEA<string>.ICBJPFEBGDJ GIBFPHEODKG, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IMAJDBCGAGL
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMAJDBCGAGL KHDCGAKLAKC(Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMAJDBCGAGL HLOECJEMEOA(Action PJDAFKMDDCG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class GLMABHMMJJM : IMAJDBCGAGL
		{
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			[CompilerGenerated]
			private sealed class LNNFCIKMHJD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public GLMABHMMJJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
				public LNNFCIKMHJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7386450", Offset = "0x7385850", VA = "0x187386450")]
				internal void EOCKDMDNAIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x73864F0", Offset = "0x73858F0", VA = "0x1873864F0")]
				internal void MMEEHMDAIMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x73864A0", Offset = "0x73858A0", VA = "0x1873864A0")]
				internal void GDPGBMAMEIJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private Func<JobHandle> KEFFNBNPNIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private Action AJFGKMMHKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private Action PANENMFMLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private PJENLLKBFNP HMDCDGIDEPE;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public Action GGHIDGLOBPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public Action FKDOHLJCDIP
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x62B50F0", Offset = "0x62B44F0", VA = "0x1862B50F0", Slot = "4")]
			public IMAJDBCGAGL KHDCGAKLAKC(Action PJDAFKMDDCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6DB3050", Offset = "0x6DB2450", VA = "0x186DB3050", Slot = "5")]
			public IMAJDBCGAGL HLOECJEMEOA(Action PJDAFKMDDCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
			public GLMABHMMJJM(Func<JobHandle> KFHABKCGFAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x737EF80", Offset = "0x737E380", VA = "0x18737EF80")]
			public void IKIFLPOJPIB(Action OIPBGEIGNBM, Action BCIJAGBBHJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x737F240", Offset = "0x737E640", VA = "0x18737F240")]
			public void OCDDHDAHAOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class EODKOKADBGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public IMAJDBCGAGL jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public EODKOKADBGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x737A670", Offset = "0x7379A70", VA = "0x18737A670")]
			internal bool GAKANDAJCAB(GLMABHMMJJM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class BKLCJKAHKAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public GLMABHMMJJM newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public BKLCJKAHKAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7376A70", Offset = "0x7375E70", VA = "0x187376A70")]
			internal void BKCOGOFPOND()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Queue<GLMABHMMJJM> KINPADHLOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private List<GLMABHMMJJM> NAEGHJNKCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private HPLGDNGCOKN JAKEGOBEKKM;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public EKKELDDHIIG KHKNLMKMLAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7384470", Offset = "0x7383870", VA = "0x187384470")]
		public IMAJDBCGAGL Add(Func<JobHandle> KFHABKCGFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x73847A0", Offset = "0x7383BA0", VA = "0x1873847A0")]
		public void Remove(IMAJDBCGAGL NIJHHKONNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x73845D0", Offset = "0x73839D0", VA = "0x1873845D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7384980", Offset = "0x7383D80", VA = "0x187384980")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7384BE0", Offset = "0x7383FE0", VA = "0x187384BE0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x73845C0", Offset = "0x73839C0", VA = "0x1873845C0")]
		[CompilerGenerated]
		private void EFBJNJIEBAC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PJENLLKBFNP
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PJENLLKBFNP KHDCGAKLAKC(Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PJENLLKBFNP FOFLLOEIMMH(Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PJENLLKBFNP HLOECJEMEOA(Action PJDAFKMDDCG);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>, NFEDKEMNHKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private class JHCLCGMOPLI : PJENLLKBFNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private JobHandle FBHPLDCFCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Action AJFGKMMHKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private Action ICBKKFJOOIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private Action FKDOHLJCDIP;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public bool INNLJOEIPDH
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x7382F80", Offset = "0x7382380", VA = "0x187382F80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6CC7420", Offset = "0x6CC6820", VA = "0x186CC7420", Slot = "4")]
			public PJENLLKBFNP KHDCGAKLAKC(Action PJDAFKMDDCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6CC7440", Offset = "0x6CC6840", VA = "0x186CC7440", Slot = "5")]
			public PJENLLKBFNP FOFLLOEIMMH(Action PJDAFKMDDCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6DB3050", Offset = "0x6DB2450", VA = "0x186DB3050", Slot = "6")]
			public PJENLLKBFNP HLOECJEMEOA(Action PJDAFKMDDCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xD93040", Offset = "0xD92440", VA = "0x180D93040")]
			public JHCLCGMOPLI(JobHandle CKILBLBOFFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7382F90", Offset = "0x7382390", VA = "0x187382F90")]
			public void HMABCBLNCNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7382FE0", Offset = "0x73823E0", VA = "0x187382FE0")]
			public void OCDDHDAHAOD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private List<JHCLCGMOPLI> PKBFDJIDGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly List<IDisposable> HLDICMIJJFI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x73851C0", Offset = "0x73845C0", VA = "0x1873851C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x11C6600", Offset = "0x11C5A00", VA = "0x1811C6600")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7384CC0", Offset = "0x73840C0", VA = "0x187384CC0")]
		public PJENLLKBFNP Add(JobHandle CKILBLBOFFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x73853D0", Offset = "0x73847D0", VA = "0x1873853D0")]
		public void Remove(PJENLLKBFNP NIJHHKONNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7384FE0", Offset = "0x73843E0", VA = "0x187384FE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7384E30", Offset = "0x7384230", VA = "0x187384E30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7384D60", Offset = "0x7384160", VA = "0x187384D60")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x73854D0", Offset = "0x73848D0", VA = "0x1873854D0")]
		public JobTracker()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x976B50", Offset = "0x975F50", VA = "0x180976B50", Slot = "6")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x73896A0", Offset = "0x7388AA0", VA = "0x1873896A0")]
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
