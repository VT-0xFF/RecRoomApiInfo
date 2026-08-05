using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
	[CreateAssetMenu]
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
				[Cpp2IlInjected.Address(RVA = "0x4406B30", Offset = "0x4405530", VA = "0x184406B30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xBD2B30", Offset = "0xBD1530", VA = "0x180BD2B30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4406AF0", Offset = "0x44054F0", VA = "0x184406AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x43FDE80", Offset = "0x43FC880", VA = "0x1843FDE80")]
		public LODSettings AIACNHGPKMF(FNAOJINHLPB OPAANEOCAHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x43FDE90", Offset = "0x43FC890", VA = "0x1843FDE90")]
		public int MCFJIBGJCLE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x43FDEB0", Offset = "0x43FC8B0", VA = "0x1843FDEB0")]
		public int MOLCDNEMGBA(bool GAHJMKPGLLP, Vector3 EGJGGHOJDGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x43FDFB0", Offset = "0x43FC9B0", VA = "0x1843FDFB0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KOFDKIKGCEJ
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
public interface NKMGCNOGOGF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGDNFCPCDAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LKDIOJCMHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LIMKAOENHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<EKJHEBEFBCE> GLJOLBMFGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KOFDKIKGCEJ PFKCFIIDCHE
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
	void UpdateClusterDistances(Vector3 JFCDBGEGOGI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(EAEJMALDCGI ENHKEICGIAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKJHEBEFBCE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NBPHIALCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int EGJLEHJBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LOBCJBGCMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OAKBJFBPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte FPEGECKFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OJHCLKMGAMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FPGLAPKPGMA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Running
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KJNKBIIGADK : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public KJNKBIIGADK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4406210", Offset = "0x4404C10", VA = "0x184406210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x44062D0", Offset = "0x4404CD0", VA = "0x1844062D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JDIPPINILOP : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<string> createWarningMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float warningInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float <start>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float <nextWarningLogTime>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public JDIPPINILOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44053B0", Offset = "0x4403DB0", VA = "0x1844053B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4405500", Offset = "0x4403F00", VA = "0x184405500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HDFEKCNNEMG : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<CBGPFCCMDJP> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public HDFEKCNNEMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4404820", Offset = "0x4403220", VA = "0x184404820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4405290", Offset = "0x4403C90", VA = "0x184405290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PEDAPAPEJFM : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public OJHCLKMGAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public PEDAPAPEJFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x440D570", Offset = "0x440BF70", VA = "0x18440D570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x440E460", Offset = "0x440CE60", VA = "0x18440E460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CGJFOOFIDNH = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer OLDHCMHFELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter IFODMDNACEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject PBHJFBEEDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject FOOONPPABIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OBCALNNIEEN GPOGKALCCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<EAEJMALDCGI> DJFFBMCLCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<EAEJMALDCGI> CHGGAAHKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EAEJMALDCGI> LAEBNHENLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int LMGLHFFMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private FPGLAPKPGMA CIKCHMDPHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<LKDIOJCMHLE>[] PKPICCHIGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<EKJHEBEFBCE>[] EGFLKOJPGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LMANBCGFHOA BBHOLCEOCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LMANBCGFHOA MPCEOEDMBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private LMANBCGFHOA PDOELFEIHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int EHAAOCADLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int EGJEAKCGHJK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static OJHCLKMGAMM OHFIIBJBHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AEBMEDJCFPO KCAOLFOHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HHBKIKIGDAP DEJCNJPDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour IOIICOIBEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material DLNHBJFMBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NKMGCNOGOGF> MKOJEPNIEGE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig AIKEFJHMOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 INNOGBCFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4390", Offset = "0x1BB2D90", VA = "0x181BB4390")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1BB42B0", Offset = "0x1BB2CB0", VA = "0x181BB42B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private FPGLAPKPGMA PEFCKDMJIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58A950", Offset = "0x589350", VA = "0x18058A950")]
		get
		{
			return default(FPGLAPKPGMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x440BC40", Offset = "0x440A640", VA = "0x18440BC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OJHCLKMGAMM JMMDLCEKNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x440B240", Offset = "0x4409C40", VA = "0x18440B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool LLKDDADOJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x440C890", Offset = "0x440B290", VA = "0x18440C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CGIMKJHHGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x440CB70", Offset = "0x440B570", VA = "0x18440CB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OBPOHIBCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x440CA80", Offset = "0x440B480", VA = "0x18440CA80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x440BA30", Offset = "0x440A430", VA = "0x18440BA30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JKBDOMEHONN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x440B7D0", Offset = "0x440A1D0", VA = "0x18440B7D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x440BAD0", Offset = "0x440A4D0", VA = "0x18440BAD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x440CE80", Offset = "0x440B880", VA = "0x18440CE80")]
	public OJHCLKMGAMM(AEBMEDJCFPO KCAOLFOHFIN, HHBKIKIGDAP DEJCNJPDBPF, ClusterLODConfig BFKAALILDNB, MonoBehaviour IOIICOIBEMM, Material DLNHBJFMBNL, ClusterMeshRenderer OLDHCMHFELL, MeshFilter IFODMDNACEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x440B930", Offset = "0x440A330", VA = "0x18440B930")]
	private void IEPGFGHJLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x440B2C0", Offset = "0x4409CC0", VA = "0x18440B2C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x440ABC0", Offset = "0x44095C0", VA = "0x18440ABC0")]
	public static void BIICPMJKHIC(Vector3 HKOMFOGOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x440AC50", Offset = "0x4409650", VA = "0x18440AC50")]
	private void CCALFEBFGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x440C660", Offset = "0x440B060", VA = "0x18440C660")]
	private void NENKDIHPAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x440AA80", Offset = "0x4409480", VA = "0x18440AA80")]
	private void BGCKMJLNGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x440B510", Offset = "0x4409F10", VA = "0x18440B510")]
	public void GHOOMPADHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x440C590", Offset = "0x440AF90", VA = "0x18440C590")]
	[IteratorStateMachine(typeof(KJNKBIIGADK))]
	private IEnumerator<CBGPFCCMDJP> MCNIBDICEJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x440A9E0", Offset = "0x44093E0", VA = "0x18440A9E0")]
	[IteratorStateMachine(typeof(JDIPPINILOP))]
	private IEnumerator<CBGPFCCMDJP> BDLCEDCCNIG(Func<bool> DMNFPOCCJPC, float BMNHOPLJPGO, Func<string> EFBCOEMNPOD, float CKDLNFCJMMA = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x440BB70", Offset = "0x440A570", VA = "0x18440BB70")]
	[IteratorStateMachine(typeof(HDFEKCNNEMG))]
	private IEnumerator<CBGPFCCMDJP> KKGPOINNAEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x440ACF0", Offset = "0x44096F0", VA = "0x18440ACF0")]
	public void DCNEBEJLHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x440B3F0", Offset = "0x4409DF0", VA = "0x18440B3F0")]
	public void EEMIBEJOAAB(IEnumerable<LKDIOJCMHLE> APJFLNNKPNH, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x440CBD0", Offset = "0x440B5D0", VA = "0x18440CBD0")]
	public void POJNGMIJPPG(IEnumerable<LKDIOJCMHLE> APJFLNNKPNH, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x440BDE0", Offset = "0x440A7E0", VA = "0x18440BDE0")]
	public List<ClusterMeshRenderer> LHPHKEFGCBA(List<EAEJMALDCGI> HBILPAFBEMD, Transform DDLLFFEEEME, KOFDKIKGCEJ PJKOCALJJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x440B870", Offset = "0x440A270", VA = "0x18440B870")]
	public KOFDKIKGCEJ HGNCFNEMOPK(Vector3 MAGMMCBKBLI)
	{
		return default(KOFDKIKGCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x440BBE0", Offset = "0x440A5E0", VA = "0x18440BBE0")]
	public void KLGEKHEMBAC(NKMGCNOGOGF MOACHMCGBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x440C600", Offset = "0x440B000", VA = "0x18440C600")]
	public bool MJOLFKNCBHI(NKMGCNOGOGF MOACHMCGBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x440B470", Offset = "0x4409E70", VA = "0x18440B470")]
	public void GBLCAJJKBEL(EAEJMALDCGI MINIDPOJPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x440B8B0", Offset = "0x440A2B0", VA = "0x18440B8B0")]
	public void HKGHJCANJED(EKJHEBEFBCE EEHCANMAMAN, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x440BD60", Offset = "0x440A760", VA = "0x18440BD60")]
	public void LHHPEGJCFPJ(EKJHEBEFBCE EEHCANMAMAN, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x440C760", Offset = "0x440B160", VA = "0x18440C760")]
	private void NHMOJMJPDGN(Vector3 JFCDBGEGOGI, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x440AF00", Offset = "0x4409900", VA = "0x18440AF00")]
	private void DELAHGMIJJE(Vector3 JFCDBGEGOGI, KOFDKIKGCEJ PJKOCALJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x440B9C0", Offset = "0x440A3C0", VA = "0x18440B9C0")]
	[IteratorStateMachine(typeof(PEDAPAPEJFM))]
	private IEnumerator<CBGPFCCMDJP> IFGLPDBKFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x440C910", Offset = "0x440B310", VA = "0x18440C910")]
	private int OIFHBFJANJP(int LGBFGOJBLFK, int BAHCGFOAKGO, List<EKJHEBEFBCE> KDIOEBIIJBE, byte OPAANEOCAHH, ref int JNGPIMDPHCA, float MNLOJPLLAKA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x440B070", Offset = "0x4409A70", VA = "0x18440B070")]
	public void DFDJPGANONL(EAEJMALDCGI ENHKEICGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x440B4D0", Offset = "0x4409ED0", VA = "0x18440B4D0")]
	public bool GHCMPHNIINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5527F0", Offset = "0x5511F0", VA = "0x1805527F0")]
	public Material LBGHMEHPHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x440C550", Offset = "0x440AF50", VA = "0x18440C550")]
	public int MCFJIBGJCLE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x440CB20", Offset = "0x440B520", VA = "0x18440CB20")]
	[CompilerGenerated]
	private bool PBBCPIOFMMI()
	{
		return default(bool);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EABCNJJHCNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> AEJIBMMHGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> KIKIJAKBNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> CIACFHAPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> LPBEMELBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> FPFDDPDMOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 BFBEHIFJNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float MLJOICPGJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> PNEFKENCLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> JHDAECBFOMA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x43FFA40", Offset = "0x43FE440", VA = "0x1843FFA40")]
	public EABCNJJHCNM(FDNGLNHKOBP EALEDNNEEBC, NativeList<float3> FPFDDPDMOKJ, NativeMultiHashMap<int, int> PNEFKENCLLC, NativeArray<int> JHDAECBFOMA, Vector3 BFBEHIFJNON, float MLJOICPGJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x43FF740", Offset = "0x43FE140", VA = "0x1843FF740")]
	private int HEMMELPLJED(float3 JFCDBGEGOGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x43FF7A0", Offset = "0x43FE1A0", VA = "0x1843FF7A0")]
	private int OFHOJPHHHNN(int PFAINNECIEO, int IPKOPOLJGIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43FF350", Offset = "0x43FDD50", VA = "0x1843FF350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFFKNKMCENK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> PNEFKENCLLC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> JHDAECBFOMA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int PJKGFEEOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4408780", Offset = "0x4407180", VA = "0x184408780")]
	public void COLIIHLGNOH(int JJDBOJDNNBD, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4408920", Offset = "0x4407320", VA = "0x184408920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public NFFKNKMCENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IJFNECCBCNH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> AKIOJOAFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> KFHPEADNNEP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4405370", Offset = "0x4403D70", VA = "0x184405370")]
	public IJFNECCBCNH(NFFKNKMCENK JFBKHGFMMAJ, FDNGLNHKOBP EALEDNNEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x44052E0", Offset = "0x4403CE0", VA = "0x1844052E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EKINMNFPICA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> GCMEDGBLOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> KEOCEFDICKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> LNNHKGOJONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> NOOEJLPLHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> LCNMLLANIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> AKIOJOAFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> AKPNHHMJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> EAJLANLCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> JNJBFJOMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> CMCHHENIPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> KMBNAEGBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> LOEGOAFELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float AOBMANEPLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float BMJBDCALIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 NPFGBLLKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float GCNEAIBPHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float CMAMLOLKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float JJPDDGGNEBJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x44010E0", Offset = "0x43FFAE0", VA = "0x1844010E0")]
	public EKINMNFPICA(NFFKNKMCENK GANJDACMIDO, FDNGLNHKOBP EALEDNNEEBC, FDNGLNHKOBP GPBFGAALIFF, float CMAMLOLKGLC, float JJPDDGGNEBJ, Vector3 NPFGBLLKMKP, float GCNEAIBPHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4400DA0", Offset = "0x43FF7A0", VA = "0x184400DA0")]
	private float3 MGKKGCGEILP(int PFAINNECIEO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4400F00", Offset = "0x43FF900", VA = "0x184400F00")]
	private void PHFFEHDDJOA(int PFAINNECIEO, out float3 NEKFECMMHJC, out float3 ILENLIGBFMB, out float4 OKMJKFFEMGG, out float4 OCFNHBIHLHM, out float2 DLPLIGMENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4400870", Offset = "0x43FF270", VA = "0x184400870")]
	private int JEBFNKJMDCJ(int BEOMFMOJIBH, int APNBFONMINB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4400BA0", Offset = "0x43FF5A0", VA = "0x184400BA0")]
	private void LHDMGJJBOKB(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x44006E0", Offset = "0x43FF0E0", VA = "0x1844006E0")]
	private bool IOEHDLNLPAB(int BEOMFMOJIBH, int APNBFONMINB, float NLFNEACDHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4400E40", Offset = "0x43FF840", VA = "0x184400E40")]
	private bool ONEINGIKIHF(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, float NLFNEACDHPF, bool NBBOIPEBOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4400480", Offset = "0x43FEE80", VA = "0x184400480")]
	private bool HLMKJAANMLI(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, float NLFNEACDHPF, bool NBBOIPEBOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4400460", Offset = "0x43FEE60", VA = "0x184400460")]
	private void GLCAOJPFIJN(int BEOMFMOJIBH, int APNBFONMINB, int MIMHCCDDGOH, out int KKDFBKHBFJL, out int GEHBNJHJJOP, out int HPDDAHPLLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x43FFB00", Offset = "0x43FE500", VA = "0x1843FFB00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GDFHEJFHPNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HCLGAICCBEB : IDisposable, EKJHEBEFBCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds MJKIPNFICIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<EAEJMALDCGI> HBILPAFBEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 MCOPODNHBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 FOEAPOKCGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int BMHCHIPGKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public FDNGLNHKOBP JMFJEJAJBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NFFKNKMCENK NAEKDHBEGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform DDLLFFEEEME;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int JELIKHAFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4404130", Offset = "0x4402B30", VA = "0x184404130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh ENLOMPLCLJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh MGBDNGEMKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x551EA0", VA = "0x1805534A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5766D0", VA = "0x180577CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LOBCJBGCMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x556190", Offset = "0x554B90", VA = "0x180556190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x556530", Offset = "0x554F30", VA = "0x180556530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte FPEGECKFKIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5F21A0", Offset = "0x5F0BA0", VA = "0x1805F21A0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7D7CD0", Offset = "0x7D66D0", VA = "0x1807D7CD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int NBPHIALCGHP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7E67F0", Offset = "0x7E51F0", VA = "0x1807E67F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x867800", Offset = "0x866200", VA = "0x180867800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int EGJLEHJBLDB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x99DDF0", Offset = "0x99C7F0", VA = "0x18099DDF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xFE8AB0", Offset = "0xFE74B0", VA = "0x180FE8AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float OAKBJFBPNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4404110", Offset = "0x4402B10", VA = "0x184404110", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4404170", Offset = "0x4402B70", VA = "0x184404170")]
		public void NPCPEJPDAED(FNAOJINHLPB OPAANEOCAHH, out int HIFFGNNDLLF, out int NFHCBCLHELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4403F70", Offset = "0x4402970", VA = "0x184403F70")]
		public void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x44043A0", Offset = "0x4402DA0", VA = "0x1844043A0")]
		public void PGIOEJFHBIM(NativeList<EOKOJNFCPLK> FMFGIFCHDBI, Transform NPJNJHOFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x44046C0", Offset = "0x44030C0", VA = "0x1844046C0")]
		public void PKAGLAEHODD(Mesh EALEDNNEEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4403ED0", Offset = "0x44028D0", VA = "0x184403ED0")]
		public void EIBBCHCMGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4403D60", Offset = "0x4402760", VA = "0x184403D60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4404760", Offset = "0x4403160", VA = "0x184404760")]
		public HCLGAICCBEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds MJKIPNFICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<HCLGAICCBEB> JPIMDNHDKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public ODEKPKOGJNI JPJHPHFMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer DADDDHJHLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int IFGPCJHBPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh BMGOPFBLNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x66D3A0", Offset = "0x66BDA0", VA = "0x18066D3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GCOPBGFICIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7045A0", Offset = "0x702FA0", VA = "0x1807045A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7046C0", Offset = "0x7030C0", VA = "0x1807046C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LIMKAOENHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4402290", Offset = "0x4400C90", VA = "0x184402290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4401BA0", Offset = "0x44005A0", VA = "0x184401BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x44022E0", Offset = "0x4400CE0", VA = "0x1844022E0")]
	public int LIAIKBDJJPF(int PGJBANBCOAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4402A20", Offset = "0x4401420", VA = "0x184402A20")]
	public void NHBOEGMLJLN(NPIFNLMNIEG KDADPJPLDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4402310", Offset = "0x4400D10", VA = "0x184402310")]
	public void MKPBJEBGLME(Transform NPJNJHOFJCH, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4401790", Offset = "0x4400190", VA = "0x184401790")]
	public bool AAEMPGLDAGC(bool MCPMFKOAOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4401D00", Offset = "0x4400700", VA = "0x184401D00")]
	public void IFBBOAFPOAK(Transform DDLLFFEEEME, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4401940", Offset = "0x4400340", VA = "0x184401940")]
	public bool DFDJPGANONL(EAEJMALDCGI ENHKEICGIAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4402BB0", Offset = "0x44015B0", VA = "0x184402BB0")]
	public GDFHEJFHPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OBCALNNIEEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<GDFHEJFHPNM.HCLGAICCBEB> JNKHJPHFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GPMMGDLBMIA HBIINJCFNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<GDFHEJFHPNM.HCLGAICCBEB> ELFLEFIPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int KCPICMNIAKE;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4408CB0", Offset = "0x44076B0", VA = "0x184408CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4409230", Offset = "0x4407C30", VA = "0x184409230")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4408A50", Offset = "0x4407450", VA = "0x184408A50")]
	public void CEGAKGBDODP(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM, Transform DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4408B00", Offset = "0x4407500", VA = "0x184408B00")]
	public void DFDJPGANONL(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4409100", Offset = "0x4407B00", VA = "0x184409100")]
	private GDFHEJFHPNM.HCLGAICCBEB KGMEMIIFLBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4408FD0", Offset = "0x44079D0", VA = "0x184408FD0")]
	private bool JNNOAIJPDNJ(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4408D20", Offset = "0x4407720", VA = "0x184408D20")]
	private void EBNDDOOKMFN(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4409060", Offset = "0x4407A60", VA = "0x184409060")]
	public bool KFEKPLMKJFI(GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4408D80", Offset = "0x4407780", VA = "0x184408D80")]
	public bool JCPEDGKMAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44090A0", Offset = "0x4407AA0", VA = "0x1844090A0")]
	private GDFHEJFHPNM.HCLGAICCBEB KFHNCHFIJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x44092B0", Offset = "0x4407CB0", VA = "0x1844092B0")]
	public OBCALNNIEEN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ADACILJPECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HOFMJIHFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int BMHMCKFPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float GDCICMPJJOF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<GDFHEJFHPNM> JAPCFAIGMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x43FDAF0", Offset = "0x43FC4F0", VA = "0x1843FDAF0")]
	public ADACILJPECD(int HOFMJIHFPCG, int BMHMCKFPIDM, float CDNEHLAFBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x43FD820", Offset = "0x43FC220", VA = "0x1843FD820")]
	public void MBFCHLFDCLE(JDJCFBCJGDF KPBIKGIKDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x43FD5A0", Offset = "0x43FBFA0", VA = "0x1843FD5A0")]
	private int BAANGJCCABJ(NPIFNLMNIEG DAMODCEKDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x43FD8C0", Offset = "0x43FC2C0", VA = "0x1843FD8C0")]
	private void MBFCHLFDCLE(NPIFNLMNIEG DAMODCEKDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x43FD640", Offset = "0x43FC040", VA = "0x1843FD640")]
	private void BDLJOJBJKEL(NPIFNLMNIEG DAMODCEKDNG, GDFHEJFHPNM KIBHDAFDKHE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LKDIOJCMHLE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KNKJANHBKOM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
			[DebuggerHidden]
			public KNKJANHBKOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4406320", Offset = "0x4404D20", VA = "0x184406320", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x44064B0", Offset = "0x4404EB0", VA = "0x1844064B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4406410", Offset = "0x4404E10", VA = "0x184406410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4406410", Offset = "0x4404E10", VA = "0x184406410", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LIMKAOENHPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x43FF2F0", Offset = "0x43FDCF0", VA = "0x1843FF2F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<EKJHEBEFBCE> GLJOLBMFGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x43FF2D0", Offset = "0x43FDCD0", VA = "0x1843FF2D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> JPIMDNHDKFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public GDFHEJFHPNM BMGOPFBLNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public KOFDKIKGCEJ PFKCFIIDCHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x578040", Offset = "0x576A40", VA = "0x180578040", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(KOFDKIKGCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6A3760", Offset = "0x6A2160", VA = "0x1806A3760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ECEEJCKAEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x43FF2E0", Offset = "0x43FDCE0", VA = "0x1843FF2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x43FE010", Offset = "0x43FCA10", VA = "0x1843FE010")]
		public static ClusterMeshRenderer Create(GDFHEJFHPNM EALEDNNEEBC, ClusterMeshRenderer OLDHCMHFELL, MeshFilter IFODMDNACEG, Transform DDLLFFEEEME, KOFDKIKGCEJ PJKOCALJJDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x43FE120", Offset = "0x43FCB20", VA = "0x1843FE120", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x43FE880", Offset = "0x43FD280", VA = "0x1843FE880", Slot = "10")]
		public bool TryRemoveClusterLODComponent(EAEJMALDCGI ENHKEICGIAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x43FE650", Offset = "0x43FD050", VA = "0x1843FE650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x43FE380", Offset = "0x43FCD80", VA = "0x1843FE380")]
		public void Init(GDFHEJFHPNM EALEDNNEEBC, MeshFilter IFODMDNACEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x43FE180", Offset = "0x43FCB80", VA = "0x1843FE180")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x43FE9B0", Offset = "0x43FD3B0", VA = "0x1843FE9B0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 JFCDBGEGOGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x43FEBF0", Offset = "0x43FD5F0", VA = "0x1843FEBF0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x43FE310", Offset = "0x43FCD10", VA = "0x1843FE310")]
		[IteratorStateMachine(typeof(KNKJANHBKOM))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x43FE6D0", Offset = "0x43FD0D0", VA = "0x1843FE6D0")]
		public void SetupTagAndLayer(string FGHLLAMJFFM, int PJKOCALJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x43FE6B0", Offset = "0x43FD0B0", VA = "0x1843FE6B0")]
		public bool Remove(EAEJMALDCGI ENHKEICGIAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GILPAGICMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int OFPEMKLONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int KLJIMEJKFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int NFHCBCLHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HIFFGNNDLLF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4402C50", Offset = "0x4401650", VA = "0x184402C50")]
	public GILPAGICMAJ(int KLJIMEJKFHH, int NFHCBCLHELA, int OFPEMKLONFL, int HIFFGNNDLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ODEKPKOGJNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<GILPAGICMAJ> FOEHHGHJJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> HPDODGMOMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> LGMEEKFDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> KCKNCHCDJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle JCKNIOCFKBC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83F7D0", Offset = "0x83E1D0", VA = "0x18083F7D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83F7F0", Offset = "0x83E1F0", VA = "0x18083F7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4409C60", Offset = "0x4408660", VA = "0x184409C60")]
	public void OAIFMBNPDMM(FDNGLNHKOBP MKNABPNMBBF, NativeList<GILPAGICMAJ> FOEHHGHJJNO, float APOENGOBFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4409A10", Offset = "0x4408410", VA = "0x184409A10")]
	public void KOFKHDDEJGL(Transform DDLLFFEEEME, bool JFJAAKFLIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4409780", Offset = "0x4408180", VA = "0x184409780")]
	public void AAEMPGLDAGC(GDFHEJFHPNM DADDDHJHLLC, bool MCPMFKOAOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4409910", Offset = "0x4408310", VA = "0x184409910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x44099E0", Offset = "0x44083E0", VA = "0x1844099E0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public ODEKPKOGJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct ELJKMKKDAIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> KHFJDLGNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> JGEJLOGFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<GILPAGICMAJ> DAEPCBDLGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> HPDODGMOMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 NPFGBLLKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> LGMEEKFDOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> KCKNCHCDJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool JFJAAKFLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float DPLIMIIKIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float LOBPFPPFNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float CMBEBJPHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> HIJHAILLOIP;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x44016C0", Offset = "0x44000C0", VA = "0x1844016C0")]
	public ELJKMKKDAIO(ODEKPKOGJNI LFLNAFNFFMD, Vector3 NPFGBLLKMKP, bool JFJAAKFLIHG, float DPLIMIIKIHF, float LOBPFPPFNEI, float CMBEBJPHGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4401220", Offset = "0x43FFC20", VA = "0x184401220", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EAEJMALDCGI : FKIIHBDDFPH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds JKDFLENDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NPIFNLMNIEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<EAEJMALDCGI> HBILPAFBEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public NPIFNLMNIEG MMEAACHMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public NPIFNLMNIEG ILIDAILMKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public NPIFNLMNIEG DMDFDBBLFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int HIFFGNNDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds MJKIPNFICIA;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x44089D0", Offset = "0x44073D0", VA = "0x1844089D0")]
	public NPIFNLMNIEG(List<EAEJMALDCGI> HBILPAFBEMD, [Optional] NPIFNLMNIEG MMEAACHMALE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JDJCFBCJGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<NPIFNLMNIEG> EOPLCFGOOPO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public NPIFNLMNIEG OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4405550", Offset = "0x4403F50", VA = "0x184405550")]
	public JDJCFBCJGDF(NPIFNLMNIEG DDLLFFEEEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MNHEIIKJNAH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MMNAJGJFGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int GDKFODFBHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int HLKLGJCNGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int JOCCLAIPLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int LGILIBEIHME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AKHIBBLBGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int AIHKHDHHFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float EJDELIMGNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<EAEJMALDCGI> HBILPAFBEMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PEDDODEMLBC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MMNAJGJFGHB AMNFDEJLGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int DHCBAKKLIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int HOFMJIHFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BMHMCKFPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float CDNEHLAFBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float OGJBDCEPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<NPIFNLMNIEG> BEPFEAMGOOF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JDJCFBCJGDF BPAFEPBDAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4408720", Offset = "0x4407120", VA = "0x184408720")]
	public MNHEIIKJNAH(int HOFMJIHFPCG, int BMHMCKFPIDM, float CDNEHLAFBHF, int DHCBAKKLIGB, float OGJBDCEPBIN = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4408560", Offset = "0x4406F60", VA = "0x184408560")]
	public void ODMEPIDONMK(List<EAEJMALDCGI> HBILPAFBEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4408340", Offset = "0x4406D40", VA = "0x184408340")]
	public bool MBCOOAGPIML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4408450", Offset = "0x4406E50", VA = "0x184408450")]
	private float NMJCPDEGBDP(Vector3 CJILIEPCADK, Vector3 AOLLHLFGLAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x44083B0", Offset = "0x4406DB0", VA = "0x1844083B0")]
	private float NMJCPDEGBDP(Vector3 OCEBHFCGEGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4407A30", Offset = "0x4406430", VA = "0x184407A30")]
	private bool JGKKCLOKCAH(NPIFNLMNIEG JIKNJANAMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4406B50", Offset = "0x4405550", VA = "0x184406B50")]
	private AKHIBBLBGKC CANGEIHGHOE(List<EAEJMALDCGI> CCNBHOGMLHC, PEDDODEMLBC JELKBKBBOAA)
	{
		return default(AKHIBBLBGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x44076A0", Offset = "0x44060A0", VA = "0x1844076A0")]
	private void HFGFPGGBICA(List<EAEJMALDCGI> HBILPAFBEMD, Vector3[] FJMBJJAGEEM, Vector3[] DMFEFCEOEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class BGHCPJAOHAI
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x43FDCD0", Offset = "0x43FC6D0", VA = "0x1843FDCD0")]
	public static Bounds NHHHMEPGPBD(List<EAEJMALDCGI> HBILPAFBEMD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x43FDB40", Offset = "0x43FC540", VA = "0x1843FDB40")]
	public static int AMDABMDFAGE(List<EAEJMALDCGI> HBILPAFBEMD, FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GPMMGDLBMIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private FDNGLNHKOBP GFPDHNLOAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private FDNGLNHKOBP OJBCEBOOLBE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static FDNGLNHKOBP BJFOEKILKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private IOMMINGJLHB FLHJJMCFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private DDNJIGMIAPI FLCPIGBNHNH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle JCKNIOCFKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6043C0", Offset = "0x602DC0", VA = "0x1806043C0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9B9A60", Offset = "0x9B8460", VA = "0x1809B9A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GDFHEJFHPNM.HCLGAICCBEB JIKNJANAMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EMNDGGHFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC00", Offset = "0x7BA600", VA = "0x1807BBC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4402CE0", Offset = "0x44016E0", VA = "0x184402CE0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private void EIMDHMCFDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4403350", Offset = "0x4401D50", VA = "0x184403350")]
	public void OAIFMBNPDMM(GDFHEJFHPNM.HCLGAICCBEB DAEPCBDLGAK, Transform BEDJIMAHPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4402D90", Offset = "0x4401790", VA = "0x184402D90")]
	public void LCPPGPMOOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4402C70", Offset = "0x4401670", VA = "0x184402C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4402D50", Offset = "0x4401750", VA = "0x184402D50")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4403CD0", Offset = "0x44026D0", VA = "0x184403CD0")]
	public GPMMGDLBMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EIHKLLHAFGL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OJHCLKMGAMM HACJFNOPBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HHBKIKIGDAP
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 AJJBMKIFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AEBMEDJCFPO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DNOMONCNAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CKBJAAJJMJJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action BFAMIOJEAPL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PMDPHBDMHMF
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMDPHBDMHMF FBAAIPPFAMK(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMDPHBDMHMF LILECGPJGLN(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMDPHBDMHMF JKHKOCHNLOC(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMDPHBDMHMF OJLPBNJJKDI(Action APBFEHIGAIL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class OBLGHEHKMNF : PMDPHBDMHMF
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PAJNOFPCIAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public OBLGHEHKMNF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
				public PAJNOFPCIAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x440D400", Offset = "0x440BE00", VA = "0x18440D400")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x440D450", Offset = "0x440BE50", VA = "0x18440D450")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x440D4A0", Offset = "0x440BEA0", VA = "0x18440D4A0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Func<JobHandle> NNMPHDINGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action EFIJHMIPCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private Action OFLAMKMGIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private FJNPIDOKNHN IFDCJCIOOBK;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action BCCPDMCKGPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x66D3A0", Offset = "0x66BDA0", VA = "0x18066D3A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Action MFNKEHCFOHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xC59B00", Offset = "0xC58500", VA = "0x180C59B00", Slot = "4")]
			public PMDPHBDMHMF FBAAIPPFAMK(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2F59430", Offset = "0x2F57E30", VA = "0x182F59430", Slot = "5")]
			public PMDPHBDMHMF LILECGPJGLN(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x30B77A0", Offset = "0x30B61A0", VA = "0x1830B77A0", Slot = "6")]
			public PMDPHBDMHMF JKHKOCHNLOC(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xC59AE0", Offset = "0xC584E0", VA = "0x180C59AE0", Slot = "7")]
			public PMDPHBDMHMF OJLPBNJJKDI(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7078F0", Offset = "0x7062F0", VA = "0x1807078F0")]
			public OBLGHEHKMNF(Func<JobHandle> GKHPIBLJDAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x44093F0", Offset = "0x4407DF0", VA = "0x1844093F0")]
			public void ADLAMHIBLDH(Action ACPJCBCGDBJ, Action NKJDMKAGMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4409620", Offset = "0x4408020", VA = "0x184409620")]
			public void DFDJPGANONL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JCFDNFMNIOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PMDPHBDMHMF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			public JCFDNFMNIOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x44053A0", Offset = "0x4403DA0", VA = "0x1844053A0")]
			internal bool <Remove>b__0(OBLGHEHKMNF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PHGDBGIAAJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public OBLGHEHKMNF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			public PHGDBGIAAJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x440E4B0", Offset = "0x440CEB0", VA = "0x18440E4B0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<OBLGHEHKMNF> JMMHCJCICGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<OBLGHEHKMNF> DPGDALCEADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private LMANBCGFHOA JICFBJJIJOO;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public OMKIBIOOPMK OKEBNHKPMJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4405600", Offset = "0x4404000", VA = "0x184405600")]
		public PMDPHBDMHMF Add(Func<JobHandle> GKHPIBLJDAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x44058A0", Offset = "0x44042A0", VA = "0x1844058A0")]
		public void Remove(PMDPHBDMHMF JCKNIOCFKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4405720", Offset = "0x4404120", VA = "0x184405720", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4405A20", Offset = "0x4404420", VA = "0x184405A20")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4405BF0", Offset = "0x44045F0", VA = "0x184405BF0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4405710", Offset = "0x4404110", VA = "0x184405710")]
		[CompilerGenerated]
		private void KJHABLLJJAM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FJNPIDOKNHN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJNPIDOKNHN FBAAIPPFAMK(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJNPIDOKNHN EHGPGIPJKPF(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJNPIDOKNHN OJLPBNJJKDI(Action APBFEHIGAIL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PDIMEIAIBEO : FJNPIDOKNHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private JobHandle LDENLMPPLEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action EFIJHMIPCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action LFAHLKOHKGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private Action MFNKEHCFOHC;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool LBBAFOKHDHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x440D4E0", Offset = "0x440BEE0", VA = "0x18440D4E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2F59430", Offset = "0x2F57E30", VA = "0x182F59430", Slot = "4")]
			public FJNPIDOKNHN FBAAIPPFAMK(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x30B77A0", Offset = "0x30B61A0", VA = "0x1830B77A0", Slot = "5")]
			public FJNPIDOKNHN EHGPGIPJKPF(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC59AE0", Offset = "0xC584E0", VA = "0x180C59AE0", Slot = "6")]
			public FJNPIDOKNHN OJLPBNJJKDI(Action APBFEHIGAIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x115CAD0", Offset = "0x115B4D0", VA = "0x18115CAD0")]
			public PDIMEIAIBEO(JobHandle ABJPODFEJGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x440D4F0", Offset = "0x440BEF0", VA = "0x18440D4F0")]
			public void DCGILHLCDMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x440D530", Offset = "0x440BF30", VA = "0x18440D530")]
			public void DFDJPGANONL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<PDIMEIAIBEO> ELELGFHHLNB;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4406070", Offset = "0x4404A70", VA = "0x184406070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4405CB0", Offset = "0x44046B0", VA = "0x184405CB0")]
		public FJNPIDOKNHN Add(JobHandle ABJPODFEJGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4405F80", Offset = "0x4404980", VA = "0x184405F80")]
		public void Remove(FJNPIDOKNHN JCKNIOCFKBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4405E20", Offset = "0x4404820", VA = "0x184405E20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4405D40", Offset = "0x4404740", VA = "0x184405D40")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4406180", Offset = "0x4404B80", VA = "0x184406180")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4406830", Offset = "0x4405230", VA = "0x184406830")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4406500", Offset = "0x4404F00", VA = "0x184406500")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
