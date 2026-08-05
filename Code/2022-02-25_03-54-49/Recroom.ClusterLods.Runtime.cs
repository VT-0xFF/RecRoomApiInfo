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
				[Cpp2IlInjected.Address(RVA = "0x28973F0", Offset = "0x28959F0", VA = "0x1828973F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xC63C90", Offset = "0xC62290", VA = "0x180C63C90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28973B0", Offset = "0x28959B0", VA = "0x1828973B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2891FA0", Offset = "0x28905A0", VA = "0x182891FA0")]
		public LODSettings NHJGNFKAHCD(OMKDNPMGFDI AFHBDAOJPEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2891F80", Offset = "0x2890580", VA = "0x182891F80")]
		public int LFCOFDIPGBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2891E80", Offset = "0x2890480", VA = "0x182891E80")]
		public int EEGHEMEPANL(bool NNFJGMNGKBJ, Vector3 DNJOGCKNMDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2891FB0", Offset = "0x28905B0", VA = "0x182891FB0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DCNNFLDIBBO
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
public interface OEIIAFIJODH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAOGIJEFIBI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GABOKMNBENI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CJMLAMHBMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<JFNKJPLFECL> OBKGFKFACJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DCNNFLDIBBO MIPGBFBDPMG
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
	void UpdateClusterDistances(Vector3 NBIMAHALLDA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(NLNGEBEIFGN LMGNHHOKMNA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JFNKJPLFECL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int LDJMBKJALJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int CKBMCIMBNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ECCIBPGDOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NCGEDCMNLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte CHBMPKJGADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BNIIMGKBKHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IADGNOIHCIB
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
	private sealed class COHEIDLHJGJ : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BNIIMGKBKHK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public COHEIDLHJGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2891D70", Offset = "0x2890370", VA = "0x182891D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2891E30", Offset = "0x2890430", VA = "0x182891E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HIGHHJJFFOM : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NHGKJABNDLI <>2__current;

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
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public HIGHHJJFFOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28948D0", Offset = "0x2892ED0", VA = "0x1828948D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2894A20", Offset = "0x2893020", VA = "0x182894A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NDNEKHNBNMF : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BNIIMGKBKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<NHGKJABNDLI> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public NDNEKHNBNMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x289C980", Offset = "0x289AF80", VA = "0x18289C980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x289D400", Offset = "0x289BA00", VA = "0x18289D400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MNNBNALDOCP : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public BNIIMGKBKHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public MNNBNALDOCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x289A580", Offset = "0x2898B80", VA = "0x18289A580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x289B470", Offset = "0x2899A70", VA = "0x18289B470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int GLKBDDJPCIL = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer OALGGDHJEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter PPPPAKABCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject EBCBOOFEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject ICJFCKLFLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public IEGOCOMFNHO HPOFEKOGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<NLNGEBEIFGN> PBPHABIKLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NLNGEBEIFGN> JIGDHJHCJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NLNGEBEIFGN> OMCLNPDICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int BOLALJEJMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IADGNOIHCIB KMHHNAEAAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<GABOKMNBENI>[] JGOBJOPDELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<JFNKJPLFECL>[] BFBDDMNENCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private JEPECMMDIGN BJGDOENBAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private JEPECMMDIGN KLMFCEPHHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private JEPECMMDIGN OCNAHJNAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NBGOMHIJCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int JNFHOEMFCLN;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static BNIIMGKBKHK HMJIIKOIMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BHPNMPNNEDG JAKKLIJMFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GLLNKDGFPGE PGADGFEJCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour GDEMHFDKFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material CKCBFKDPLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<OEIIAFIJODH> GKLCJJJJLGN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JGKCHDMCFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 ECJGJCEPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2891050", Offset = "0x288F650", VA = "0x182891050")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2890F80", Offset = "0x288F580", VA = "0x182890F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IADGNOIHCIB ONNPPDALKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BD0", Offset = "0x7F81D0", VA = "0x1807F9BD0")]
		get
		{
			return default(IADGNOIHCIB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x288F430", Offset = "0x288DA30", VA = "0x18288F430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BNIIMGKBKHK EJBAJGKCNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2891320", Offset = "0x288F920", VA = "0x182891320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool FCBEBJHEGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28905D0", Offset = "0x288EBD0", VA = "0x1828905D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool NKOPADHADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2891790", Offset = "0x288FD90", VA = "0x182891790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OFAEBCBGNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2891520", Offset = "0x288FB20", VA = "0x182891520")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2890650", Offset = "0x288EC50", VA = "0x182890650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LIOGKCEHPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28913A0", Offset = "0x288F9A0", VA = "0x1828913A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x288FB20", Offset = "0x288E120", VA = "0x18288FB20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28917F0", Offset = "0x288FDF0", VA = "0x1828917F0")]
	public BNIIMGKBKHK(BHPNMPNNEDG JAKKLIJMFFP, GLLNKDGFPGE PGADGFEJCAC, ClusterLODConfig JOCDEAOKKJF, MonoBehaviour GDEMHFDKFBO, Material CKCBFKDPLGA, ClusterMeshRenderer OALGGDHJEGG, MeshFilter PPPPAKABCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2891490", Offset = "0x288FA90", VA = "0x182891490")]
	private void OEOLACMCAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x288F8A0", Offset = "0x288DEA0", VA = "0x18288F8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2890540", Offset = "0x288EB40", VA = "0x182890540")]
	public static void IGDJGBIGEHP(Vector3 KIJCGHGGOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x288F9D0", Offset = "0x288DFD0", VA = "0x18288F9D0")]
	private void EDMHGHFCDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x288FF40", Offset = "0x288E540", VA = "0x18288FF40")]
	private void FLGJIADDFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2891070", Offset = "0x288F670", VA = "0x182891070")]
	private void MBLDNINNFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x288FBC0", Offset = "0x288E1C0", VA = "0x18288FBC0")]
	public void EHLJLFHNBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x288F560", Offset = "0x288DB60", VA = "0x18288F560")]
	[IteratorStateMachine(typeof(COHEIDLHJGJ))]
	private IEnumerator<NHGKJABNDLI> BOIKLLEIBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2890EE0", Offset = "0x288F4E0", VA = "0x182890EE0")]
	[IteratorStateMachine(typeof(HIGHHJJFFOM))]
	private IEnumerator<NHGKJABNDLI> KNMCIBHHIHO(Func<bool> EBBDNDEIBIM, float KOBMBDIHKBN, Func<string> KEIPGDIANDG, float JAPOFOACBNI = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x288FED0", Offset = "0x288E4D0", VA = "0x18288FED0")]
	[IteratorStateMachine(typeof(NDNEKHNBNMF))]
	private IEnumerator<NHGKJABNDLI> FKGGHNIHFCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x288F5D0", Offset = "0x288DBD0", VA = "0x18288F5D0")]
	public void CPKDADOJANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2890F90", Offset = "0x288F590", VA = "0x182890F90")]
	public void LECOGLKGJOG(IEnumerable<GABOKMNBENI> HFHKPJHBJEP, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2890120", Offset = "0x288E720", VA = "0x182890120")]
	public void HBGCIKLMMBP(IEnumerable<GABOKMNBENI> HFHKPJHBJEP, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2890770", Offset = "0x288ED70", VA = "0x182890770")]
	public List<ClusterMeshRenderer> KFNFMKHDBDN(List<NLNGEBEIFGN> CIPIPNBKNGM, Transform MKDDPCAJMGN, DCNNFLDIBBO FMGIBAGPCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x288FE90", Offset = "0x288E490", VA = "0x18288FE90")]
	public DCNNFLDIBBO EMMEOAJPJIF(Vector3 HHPAJPDGEPB)
	{
		return default(DCNNFLDIBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x288F840", Offset = "0x288DE40", VA = "0x18288F840")]
	public void DMHJKLHPALE(OEIIAFIJODH EENBIGAOLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2890040", Offset = "0x288E640", VA = "0x182890040")]
	public bool FMNIGCDHGAP(OEIIAFIJODH EENBIGAOLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x288F7E0", Offset = "0x288DDE0", VA = "0x18288F7E0")]
	public void DEEPGABECEO(NLNGEBEIFGN CCJDGMBCCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28906F0", Offset = "0x288ECF0", VA = "0x1828906F0")]
	public void JNKPKLPBMAJ(JFNKJPLFECL FEJBJJDFPDK, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28900A0", Offset = "0x288E6A0", VA = "0x1828900A0")]
	public void GGIIMGEIADJ(JFNKJPLFECL FEJBJJDFPDK, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x288F300", Offset = "0x288D900", VA = "0x18288F300")]
	private void ANAAPBBNJIN(Vector3 NBIMAHALLDA, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28911B0", Offset = "0x288F7B0", VA = "0x1828911B0")]
	private void MBNGECCPEON(Vector3 NBIMAHALLDA, DCNNFLDIBBO FMGIBAGPCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x288FAB0", Offset = "0x288E0B0", VA = "0x18288FAB0")]
	[IteratorStateMachine(typeof(MNNBNALDOCP))]
	private IEnumerator<NHGKJABNDLI> EFKKDIEBGMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28903D0", Offset = "0x288E9D0", VA = "0x1828903D0")]
	private int HIOCCFDPKJE(int OEELHFBMNBJ, int OLDDPAAJENM, List<JFNKJPLFECL> AIBHEBOFDIO, byte AFHBDAOJPEH, ref int AACAADIBJHO, float BMLDHPIINBP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28915C0", Offset = "0x288FBC0", VA = "0x1828915C0")]
	public void PFBLIKHMAGM(NLNGEBEIFGN LMGNHHOKMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x288FA70", Offset = "0x288E070", VA = "0x18288FA70")]
	public bool EDNBIPEGPKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1770", Offset = "0x5DFD70", VA = "0x1805E1770")]
	public Material GJNDCEIPMDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2891010", Offset = "0x288F610", VA = "0x182891010")]
	public int LFCOFDIPGBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2891440", Offset = "0x288FA40", VA = "0x182891440")]
	[CompilerGenerated]
	private bool NOMOAPFFALC()
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
		[Cpp2IlInjected.Address(RVA = "0x50D600", Offset = "0x50BC00", VA = "0x18050D600")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct FOCAOGFHHFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> IPIELLPKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> MFDOLPIICKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> HLJMMDMKAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> OFILHEHJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> DBFJGHGPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> ABLNBNJIKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> APBLDMIPLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 KIBJLJOHBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float DOHIDGBGBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> FOIODBFBODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> KNDHHKMLHJH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28947B0", Offset = "0x2892DB0", VA = "0x1828947B0")]
	public FOCAOGFHHFE(EIDDMAEKOAL NLKJHCLIEAL, NativeList<float3> APBLDMIPLDD, NativeMultiHashMap<int, int> FOIODBFBODM, NativeArray<int> KNDHHKMLHJH, Vector3 KIBJLJOHBFE, float DOHIDGBGBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28940C0", Offset = "0x28926C0", VA = "0x1828940C0")]
	private int ACKKLNCPOIH(float3 NBIMAHALLDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2894120", Offset = "0x2892720", VA = "0x182894120")]
	private int EOPNNDCCCKD(int BFJPGBKBCMP, int CAOGILCCJKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28943C0", Offset = "0x28929C0", VA = "0x1828943C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JNHLCAJCIDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> FOIODBFBODM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> KNDHHKMLHJH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int GCFEBHMEGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> NLKMGMHGFOG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2895B40", Offset = "0x2894140", VA = "0x182895B40")]
	public void EPDBEEPDOPP(int EDOEPBPGJNJ, Allocator ABCKFPJDLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2895A90", Offset = "0x2894090", VA = "0x182895A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public JNHLCAJCIDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct MHMIBPLJIJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LAHIEJNLJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> IJHKMGNBHJO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2898920", Offset = "0x2896F20", VA = "0x182898920")]
	public MHMIBPLJIJB(JNHLCAJCIDO CBGGKPNGJJO, EIDDMAEKOAL NLKJHCLIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2898890", Offset = "0x2896E90", VA = "0x182898890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PEBIFHCCBCM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> ONKPHOJAFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> AIIFMOCHFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> LEHEJOHMEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> NFPPGKEHGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> DEEOJPLHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> NLKMGMHGFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LAHIEJNLJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> NGKPLNIOAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> IHPMJFOFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> IMDMJMFLBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> MNEDOOPMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> GCHAHNJHAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> JHPLPAFEDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float FJAEPKCELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float LKKFMBDHHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 NDLIIACHOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float PPDDIJBJNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float FBDNJMDHAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float ONPHJLIBDBE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x289FD20", Offset = "0x289E320", VA = "0x18289FD20")]
	public PEBIFHCCBCM(JNHLCAJCIDO BCPAOIGGFAL, EIDDMAEKOAL NLKJHCLIEAL, EIDDMAEKOAL GMFOPBLKCDP, float FBDNJMDHAEP, float ONPHJLIBDBE, Vector3 NDLIIACHOPI, float PPDDIJBJNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x289F950", Offset = "0x289DF50", VA = "0x18289F950")]
	private float3 PDOGKBAHIPF(int BFJPGBKBCMP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x289F6B0", Offset = "0x289DCB0", VA = "0x18289F6B0")]
	private void JODJHNIKCKJ(int BFJPGBKBCMP, out float3 BMHKJJODBFO, out float3 PKEKDODNHCC, out float4 OOMLPCHEMDJ, out float4 IMPBIOLCLGH, out float2 PGDDHHFNMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x289F9F0", Offset = "0x289DFF0", VA = "0x18289F9F0")]
	private int PGBDABHCEIC(int DAHOIGDHPBN, int LGEOAGPJIND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x289E760", Offset = "0x289CD60", VA = "0x18289E760")]
	private void BLBACAENENL(int DAHOIGDHPBN, int LGEOAGPJIND, int GAIMAAFAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x289E960", Offset = "0x289CF60", VA = "0x18289E960")]
	private bool CCMNFKDJBCJ(int DAHOIGDHPBN, int LGEOAGPJIND, float MPLPMNFBKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x289F890", Offset = "0x289DE90", VA = "0x18289F890")]
	private bool LBIDNMOPPPN(int DAHOIGDHPBN, int LGEOAGPJIND, int GAIMAAFAPEL, float MPLPMNFBKFD, bool BNCOOPBNJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x289EAF0", Offset = "0x289D0F0", VA = "0x18289EAF0")]
	private bool DGDOODMFMCE(int DAHOIGDHPBN, int LGEOAGPJIND, int GAIMAAFAPEL, float MPLPMNFBKFD, bool BNCOOPBNJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x289E740", Offset = "0x289CD40", VA = "0x18289E740")]
	private void ALKNJJDDNFJ(int DAHOIGDHPBN, int LGEOAGPJIND, int GAIMAAFAPEL, out int BENIBNKNCPP, out int KGNGPOKBADK, out int PGCLPFFFOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x289ED50", Offset = "0x289D350", VA = "0x18289ED50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NBNPACAOOOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KBJFMEOBLNH : IDisposable, JFNKJPLFECL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds JKLMPHADJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<NLNGEBEIFGN> CIPIPNBKNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 EFEAANLGLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 BPIMAAKLIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int CBBLMFCNMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public EIDDMAEKOAL MKBMOODKDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public JNHLCAJCIDO HNMMBAHNDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform MKDDPCAJMGN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int IDNCDNIGJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x28972B0", Offset = "0x28958B0", VA = "0x1828972B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh OEJPHLAFIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh LCCFCDCEJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x57F1A0", Offset = "0x57D7A0", VA = "0x18057F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x58A2A0", Offset = "0x5888A0", VA = "0x18058A2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ECCIBPGDOAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x608720", Offset = "0x606D20", VA = "0x180608720", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1CE9A60", Offset = "0x1CE8060", VA = "0x181CE9A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte CHBMPKJGADG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD20", Offset = "0x5CE320", VA = "0x1805CFD20")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D30", Offset = "0x7B7330", VA = "0x1807B8D30", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int LDJMBKJALJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x709670", Offset = "0x707C70", VA = "0x180709670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x709680", Offset = "0x707C80", VA = "0x180709680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int CKBMCIMBNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x124C650", Offset = "0x124AC50", VA = "0x18124C650", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA84A30", VA = "0x180A86430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float NCGEDCMNLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2896BA0", Offset = "0x28951A0", VA = "0x182896BA0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2897080", Offset = "0x2895680", VA = "0x182897080")]
		public void MOJGBGIDIGG(OMKDNPMGFDI AFHBDAOJPEH, out int MAGABEDGIFF, out int LBONHGJPFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2896EE0", Offset = "0x28954E0", VA = "0x182896EE0")]
		public void MBGEPHLGFAL(OMKDNPMGFDI AFHBDAOJPEH, AEBIJCECNOB JOKKOOPDHJP, int BKOANJHDJGE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2896BC0", Offset = "0x28951C0", VA = "0x182896BC0")]
		public void JNLFJAHNLDL(NativeList<EIALAHJEFGD> HEGPIJKJFEK, Transform HKKBCEEACMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2896990", Offset = "0x2894F90", VA = "0x182896990")]
		public void CIGDNENFPFB(Mesh NLKJHCLIEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28968F0", Offset = "0x2894EF0", VA = "0x1828968F0")]
		public void CCOPMKGBKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2896A30", Offset = "0x2895030", VA = "0x182896A30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28972F0", Offset = "0x28958F0", VA = "0x1828972F0")]
		public KBJFMEOBLNH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds JKLMPHADJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<KBJFMEOBLNH> BMPHPKCBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public ONEGJNEIENI BMJLIPJFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer CKNNFNMCEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int MNNDNCPHPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh AMKKFHNOPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x56D4E0", Offset = "0x56BAE0", VA = "0x18056D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EGHCNMJJDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x93E5B0", Offset = "0x93CBB0", VA = "0x18093E5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x93E950", Offset = "0x93CF50", VA = "0x18093E950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CJMLAMHBMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x289BEF0", Offset = "0x289A4F0", VA = "0x18289BEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x289B4F0", Offset = "0x2899AF0", VA = "0x18289B4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x289B4C0", Offset = "0x2899AC0", VA = "0x18289B4C0")]
	public int CIBNGMNLJJH(int MIKCDAPBKMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x289BD60", Offset = "0x289A360", VA = "0x18289BD60")]
	public void JDEPOHACCKO(AHMBNILDGCK BFIHNICNCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x289B650", Offset = "0x2899C50", VA = "0x18289B650")]
	public void GPGOBDAABEB(Transform HKKBCEEACMD, bool NMBMLMPAEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x289C4D0", Offset = "0x289AAD0", VA = "0x18289C4D0")]
	public bool PEBNEMPHPOK(bool KFFNGHKPHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x289BF40", Offset = "0x289A540", VA = "0x18289BF40")]
	public void OCBOHCPBBAI(Transform MKDDPCAJMGN, bool NMBMLMPAEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x289C680", Offset = "0x289AC80", VA = "0x18289C680")]
	public bool PFBLIKHMAGM(NLNGEBEIFGN LMGNHHOKMNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x289C8E0", Offset = "0x289AEE0", VA = "0x18289C8E0")]
	public NBNPACAOOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IEGOCOMFNHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NBNPACAOOOJ.KBJFMEOBLNH> ALNJKACDDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private LPDLJDAPECD FHKNHLBJDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<NBNPACAOOOJ.KBJFMEOBLNH> JNJAGKOHAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int AOMGBIEAMIO;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2895010", Offset = "0x2893610", VA = "0x182895010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2895080", Offset = "0x2893680", VA = "0x182895080")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2895610", Offset = "0x2893C10", VA = "0x182895610")]
	public void OAKCALBAGFG(NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO, Transform MKDDPCAJMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x28956C0", Offset = "0x2893CC0", VA = "0x1828956C0")]
	public void PFBLIKHMAGM(NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2895440", Offset = "0x2893A40", VA = "0x182895440")]
	private NBNPACAOOOJ.KBJFMEOBLNH KNIBFMIFEEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2895160", Offset = "0x2893760", VA = "0x182895160")]
	private bool GKMNFGHIADJ(NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2895100", Offset = "0x2893700", VA = "0x182895100")]
	private void FGCJFHFBJOE(NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x28955D0", Offset = "0x2893BD0", VA = "0x1828955D0")]
	public bool LMNBIHFOILP(NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x28951F0", Offset = "0x28937F0", VA = "0x1828951F0")]
	public bool HLFBHDKMFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2895570", Offset = "0x2893B70", VA = "0x182895570")]
	private NBNPACAOOOJ.KBJFMEOBLNH LEPEGJJLGEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2895870", Offset = "0x2893E70", VA = "0x182895870")]
	public IEGOCOMFNHO()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x50D600", Offset = "0x50BC00", VA = "0x18050D600")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DJGBIHHDKIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BAOIPOLFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int LILDBCOEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float FCALKOBLNIC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<NBNPACAOOOJ> DDIFICAODNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28938A0", Offset = "0x2891EA0", VA = "0x1828938A0")]
	public DJGBIHHDKIA(int BAOIPOLFCNL, int LILDBCOEFBL, float MCJOKAGAGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2893800", Offset = "0x2891E00", VA = "0x182893800")]
	public void MCEFBGAOAON(BHHPIBPOOBF LLGAPJBGPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2893530", Offset = "0x2891B30", VA = "0x182893530")]
	private int GPAHOMDCGIE(AHMBNILDGCK HKAHEJFPDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x28935D0", Offset = "0x2891BD0", VA = "0x1828935D0")]
	private void MCEFBGAOAON(AHMBNILDGCK HKAHEJFPDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2893350", Offset = "0x2891950", VA = "0x182893350")]
	private void FBGKIEAILHG(AHMBNILDGCK HKAHEJFPDGM, NBNPACAOOOJ PFHAMJKMKAG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, GABOKMNBENI
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EFKICBMIPKC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
			[DebuggerHidden]
			public EFKICBMIPKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x28938F0", Offset = "0x2891EF0", VA = "0x1828938F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x2893A80", Offset = "0x2892080", VA = "0x182893A80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x28939E0", Offset = "0x2891FE0", VA = "0x1828939E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x28939E0", Offset = "0x2891FE0", VA = "0x1828939E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int CJMLAMHBMBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x28932F0", Offset = "0x28918F0", VA = "0x1828932F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<JFNKJPLFECL> OBKGFKFACJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x28932D0", Offset = "0x28918D0", VA = "0x1828932D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> BMPHPKCBBCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public NBNPACAOOOJ AMKKFHNOPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public DCNNFLDIBBO MIPGBFBDPMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x717480", Offset = "0x715A80", VA = "0x180717480", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(DCNNFLDIBBO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7174A0", Offset = "0x715AA0", VA = "0x1807174A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool GCDOBGIHEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x28932E0", Offset = "0x28918E0", VA = "0x1828932E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2892010", Offset = "0x2890610", VA = "0x182892010")]
		public static ClusterMeshRenderer Create(NBNPACAOOOJ NLKJHCLIEAL, ClusterMeshRenderer OALGGDHJEGG, MeshFilter PPPPAKABCNH, Transform MKDDPCAJMGN, DCNNFLDIBBO FMGIBAGPCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2892120", Offset = "0x2890720", VA = "0x182892120", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2892880", Offset = "0x2890E80", VA = "0x182892880", Slot = "10")]
		public bool TryRemoveClusterLODComponent(NLNGEBEIFGN LMGNHHOKMNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2892650", Offset = "0x2890C50", VA = "0x182892650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2892380", Offset = "0x2890980", VA = "0x182892380")]
		public void Init(NBNPACAOOOJ NLKJHCLIEAL, MeshFilter PPPPAKABCNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2892180", Offset = "0x2890780", VA = "0x182892180")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x28929B0", Offset = "0x2890FB0", VA = "0x1828929B0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 NBIMAHALLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2892BF0", Offset = "0x28911F0", VA = "0x182892BF0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2892310", Offset = "0x2890910", VA = "0x182892310")]
		[IteratorStateMachine(typeof(EFKICBMIPKC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28926D0", Offset = "0x2890CD0", VA = "0x1828926D0")]
		public void SetupTagAndLayer(string ICFPNICMEME, int FMGIBAGPCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28926B0", Offset = "0x2890CB0", VA = "0x1828926B0")]
		public bool Remove(NLNGEBEIFGN LMGNHHOKMNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x50D600", Offset = "0x50BC00", VA = "0x18050D600")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HMELIJGPBJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int MCILIOFHJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int HOGJMFJENKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int LBONHGJPFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MAGABEDGIFF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2894FE0", Offset = "0x28935E0", VA = "0x182894FE0")]
	public HMELIJGPBJP(int HOGJMFJENKM, int LBONHGJPFNJ, int MCILIOFHJNI, int MAGABEDGIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ONEGJNEIENI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> IPIELLPKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> NLKMGMHGFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> ABLNBNJIKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<HMELIJGPBJP> JPKGIDIOEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> NIJHIKDNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> HGKDPKCBJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> FPOBJAGAEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle CGAMGILMAIB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NGGLIMDLKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x955730", Offset = "0x953D30", VA = "0x180955730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x582E10", Offset = "0x581410", VA = "0x180582E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x289D5E0", Offset = "0x289BBE0", VA = "0x18289D5E0")]
	public void GLOABFLDJMH(EIDDMAEKOAL CAEJJMDLMMI, NativeList<HMELIJGPBJP> JPKGIDIOEGK, float DIHNGNHDPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x289E360", Offset = "0x289C960", VA = "0x18289E360")]
	public void LEMOKNFAIDD(Transform MKDDPCAJMGN, bool NMBMLMPAEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x289E5B0", Offset = "0x289CBB0", VA = "0x18289E5B0")]
	public void PEBNEMPHPOK(NBNPACAOOOJ CKNNFNMCEAH, bool KFFNGHKPHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x289D4E0", Offset = "0x289BAE0", VA = "0x18289D4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x289D5B0", Offset = "0x289BBB0", VA = "0x18289D5B0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ONEGJNEIENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HJNJLMAJDCP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> IPIELLPKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> NLKMGMHGFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<HMELIJGPBJP> OGMPMOGKJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> NIJHIKDNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 NDLIIACHOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> HGKDPKCBJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> FPOBJAGAEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool NMBMLMPAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float HHEEJNDJELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float DLPNOOBPPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float HHHMIOPKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> ABLNBNJIKJM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2894F10", Offset = "0x2893510", VA = "0x182894F10")]
	public HJNJLMAJDCP(ONEGJNEIENI NKMMEHEAKCP, Vector3 NDLIIACHOPI, bool NMBMLMPAEEF, float HHEEJNDJELD, float DLPNOOBPPID, float HHHMIOPKGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2894A70", Offset = "0x2893070", VA = "0x182894A70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NLNGEBEIFGN : DPOPELIIBAP
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds PAEEADNDFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EIALAHJEFGD POIDJGFNODP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AHMBNILDGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<NLNGEBEIFGN> CIPIPNBKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public AHMBNILDGCK IJHBOGOHCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public AHMBNILDGCK CNAMFDLKLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public AHMBNILDGCK ALJICAMCFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int MAGABEDGIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds JKLMPHADJKN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x288F1D0", Offset = "0x288D7D0", VA = "0x18288F1D0")]
	public AHMBNILDGCK(List<NLNGEBEIFGN> CIPIPNBKNGM, [Optional] AHMBNILDGCK IJHBOGOHCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BHHPIBPOOBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<AHMBNILDGCK> KMGIOKPOFKM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public AHMBNILDGCK JEAEKLPDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x288F250", Offset = "0x288D850", VA = "0x18288F250")]
	public BHHPIBPOOBF(AHMBNILDGCK MKDDPCAJMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MLICPEJPNPH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct HKMPCPCPGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int GILOHAOODGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int ABAOFKHGKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int HPONCOCEIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int PEOACDDIILO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JAPCOKBANKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int EHILPLHMHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float BHACAIDNNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<NLNGEBEIFGN> CIPIPNBKNGM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MNAEPDGIBPP
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
	private HKMPCPCPGMO IMHAEKAMOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int JLMJFNMMKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int BAOIPOLFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int LILDBCOEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float MCJOKAGAGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float CCDBKDGIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<AHMBNILDGCK> LKMNOPCCOHA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public BHHPIBPOOBF LBJFPCDJCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x289A520", Offset = "0x2898B20", VA = "0x18289A520")]
	public MLICPEJPNPH(int BAOIPOLFCNL, int LILDBCOEFBL, float MCJOKAGAGCJ, int JLMJFNMMKKC, float CCDBKDGIKBF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x289A2F0", Offset = "0x28988F0", VA = "0x18289A2F0")]
	public void KEHOCIPFBON(List<NLNGEBEIFGN> CIPIPNBKNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x289A4B0", Offset = "0x2898AB0", VA = "0x18289A4B0")]
	public bool OMGNKOAPEAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x289A140", Offset = "0x2898740", VA = "0x18289A140")]
	private float JKCOAILCMBI(Vector3 GFBDCKFLKIE, Vector3 ENBPHMLENNM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x289A250", Offset = "0x2898850", VA = "0x18289A250")]
	private float JKCOAILCMBI(Vector3 OGHBEIMLJPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28994A0", Offset = "0x2897AA0", VA = "0x1828994A0")]
	private bool HNLGICMCAMH(AHMBNILDGCK NJFPLIEBMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2898950", Offset = "0x2896F50", VA = "0x182898950")]
	private JAPCOKBANKM DEHGAEBDNKL(List<NLNGEBEIFGN> OEHMAAPAFFN, MNAEPDGIBPP NHCPONCOPPJ)
	{
		return default(JAPCOKBANKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2899DB0", Offset = "0x28983B0", VA = "0x182899DB0")]
	private void ILFIEDMKCBL(List<NLNGEBEIFGN> CIPIPNBKNGM, Vector3[] NBDPGDEDBHD, Vector3[] DBHHJNPCMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class AEJKFODOOCF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x288F020", Offset = "0x288D620", VA = "0x18288F020")]
	public static Bounds NPEEAHJDOGN(List<NLNGEBEIFGN> CIPIPNBKNGM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x288EE90", Offset = "0x288D490", VA = "0x18288EE90")]
	public static int NJPJADPKPIJ(List<NLNGEBEIFGN> CIPIPNBKNGM, OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LPDLJDAPECD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private EIDDMAEKOAL NBMLMBKKIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EIDDMAEKOAL CGJCKNOEAHG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static EIDDMAEKOAL ONPMCNPENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NOMNABFJLDB PKJKMLIIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AEBIJCECNOB JOKKOOPDHJP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle CGAMGILMAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x704100", Offset = "0x702700", VA = "0x180704100")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x704120", Offset = "0x702720", VA = "0x180704120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NBNPACAOOOJ.KBJFMEOBLNH NJFPLIEBMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JOEALCAIJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xFD15E0", Offset = "0xFCFBE0", VA = "0x180FD15E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28974C0", Offset = "0x2895AC0", VA = "0x1828974C0")]
	[NNMDMIMABNG(GBGLFHCKFBK.ExitingPlayMode, 0)]
	private void EOGIINCFDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2897530", Offset = "0x2895B30", VA = "0x182897530")]
	public void GLOABFLDJMH(NBNPACAOOOJ.KBJFMEOBLNH OGMPMOGKJGN, Transform HFPAFPDOEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2897EB0", Offset = "0x28964B0", VA = "0x182897EB0")]
	public void IOPHGKCJIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2897410", Offset = "0x2895A10", VA = "0x182897410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2897480", Offset = "0x2895A80", VA = "0x182897480")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2898470", Offset = "0x2896A70", VA = "0x182898470")]
	public LPDLJDAPECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EGPCAOFJPPC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BNIIMGKBKHK AEPDNNAOIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GLLNKDGFPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 CDCBDKIDBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BHPNMPNNEDG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool FJBFLLMNKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EACBEGPEECF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action DEJHNFLMDLD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OECKKBCACPH
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OECKKBCACPH KDANGNMPEFK(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OECKKBCACPH LOIOAMNBMII(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OECKKBCACPH BAKADLEGJEP(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OECKKBCACPH CGGBKAKPPEL(Action DAENONOLDPH);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MDKOLLDNENI : OECKKBCACPH
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class JEJMOPEIOME
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public MDKOLLDNENI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public JEJMOPEIOME()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x28959B0", Offset = "0x2893FB0", VA = "0x1828959B0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x2895A00", Offset = "0x2894000", VA = "0x182895A00")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2895A50", Offset = "0x2894050", VA = "0x182895A50")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> PKIMHHOCGHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action LOPGGCLMBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action DOFHOEOCMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private AFIEAFPLBPK BDMBBFPAJAB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action BPGPDEHAMDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x56D4E0", Offset = "0x56BAE0", VA = "0x18056D4E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action ALFADHHGIMJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x11945B0", Offset = "0x1192BB0", VA = "0x1811945B0", Slot = "4")]
			public OECKKBCACPH KDANGNMPEFK(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x10D88C0", Offset = "0x10D6EC0", VA = "0x1810D88C0", Slot = "5")]
			public OECKKBCACPH LOIOAMNBMII(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x11945D0", Offset = "0x1192BD0", VA = "0x1811945D0", Slot = "6")]
			public OECKKBCACPH BAKADLEGJEP(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xBF8890", Offset = "0xBF6E90", VA = "0x180BF8890", Slot = "7")]
			public OECKKBCACPH CGGBKAKPPEL(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57D820", VA = "0x18057F220")]
			public MDKOLLDNENI(Func<JobHandle> ICFBBGDAJCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2898500", Offset = "0x2896B00", VA = "0x182898500")]
			public void OBBPJAKBAAD(Action MKFIICBDMNB, Action CBOFEBJJELD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x2898730", Offset = "0x2896D30", VA = "0x182898730")]
			public void PFBLIKHMAGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class IDLODHKCMGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public OECKKBCACPH jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public IDLODHKCMGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2895000", Offset = "0x2893600", VA = "0x182895000")]
			internal bool <Remove>b__0(MDKOLLDNENI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class FODONEIHKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public MDKOLLDNENI newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public FODONEIHKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2894870", Offset = "0x2892E70", VA = "0x182894870")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<MDKOLLDNENI> BGCNMCAJOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<MDKOLLDNENI> LEBBJFKNCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private JEPECMMDIGN NNCBNDJFCDK;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2895CF0", Offset = "0x28942F0", VA = "0x182895CF0")]
		public OECKKBCACPH Add(Func<JobHandle> ICFBBGDAJCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2895F80", Offset = "0x2894580", VA = "0x182895F80")]
		public void Remove(OECKKBCACPH CGAMGILMAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2895E00", Offset = "0x2894400", VA = "0x182895E00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2896100", Offset = "0x2894700", VA = "0x182896100")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28962D0", Offset = "0x28948D0", VA = "0x1828962D0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2895CE0", Offset = "0x28942E0", VA = "0x182895CE0")]
		[CompilerGenerated]
		private void AHEJBANOCMG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AFIEAFPLBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AFIEAFPLBPK KDANGNMPEFK(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AFIEAFPLBPK NLNLNHJGNHK(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AFIEAFPLBPK CGGBKAKPPEL(Action DAENONOLDPH);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class OJJOBMBPDAN : AFIEAFPLBPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle PGLNCJNCELL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action LOPGGCLMBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action ALFFGIFMIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action ALFADHHGIMJ;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool OHNJNPGAIOA
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x289D450", Offset = "0x289BA50", VA = "0x18289D450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x10D88C0", Offset = "0x10D6EC0", VA = "0x1810D88C0", Slot = "4")]
			public AFIEAFPLBPK KDANGNMPEFK(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x11945D0", Offset = "0x1192BD0", VA = "0x1811945D0", Slot = "5")]
			public AFIEAFPLBPK NLNLNHJGNHK(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xBF8890", Offset = "0xBF6E90", VA = "0x180BF8890", Slot = "6")]
			public AFIEAFPLBPK CGGBKAKPPEL(Action DAENONOLDPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x91D5E0", Offset = "0x91BBE0", VA = "0x18091D5E0")]
			public OJJOBMBPDAN(JobHandle NHFFCMNHMPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x289D460", Offset = "0x289BA60", VA = "0x18289D460")]
			public void JCIBKDPCAKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x289D4A0", Offset = "0x289BAA0", VA = "0x18289D4A0")]
			public void PFBLIKHMAGM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<OJJOBMBPDAN> JFIAGMEJLND;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2896750", Offset = "0x2894D50", VA = "0x182896750")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2896390", Offset = "0x2894990", VA = "0x182896390")]
		public AFIEAFPLBPK Add(JobHandle NHFFCMNHMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2896660", Offset = "0x2894C60", VA = "0x182896660")]
		public void Remove(AFIEAFPLBPK CGAMGILMAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2896500", Offset = "0x2894B00", VA = "0x182896500", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2896420", Offset = "0x2894A20", VA = "0x182896420")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2896860", Offset = "0x2894E60", VA = "0x182896860")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2893AD0", Offset = "0x28920D0", VA = "0x182893AD0")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2893BD0", Offset = "0x28921D0", VA = "0x182893BD0")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
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

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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
