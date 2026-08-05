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
				[Cpp2IlInjected.Address(RVA = "0x42B99C0", Offset = "0x42B89C0", VA = "0x1842B99C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x10CB8A0", Offset = "0x10CA8A0", VA = "0x1810CB8A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x42B9980", Offset = "0x42B8980", VA = "0x1842B9980")]
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
		[Cpp2IlInjected.Address(RVA = "0x42ADAD0", Offset = "0x42ACAD0", VA = "0x1842ADAD0")]
		public LODSettings LDEAFBJEJOE(GMFMCAOCJOB FJMMOCNCCBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x42ADAB0", Offset = "0x42ACAB0", VA = "0x1842ADAB0")]
		public int JFLJPNLGNHP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42AD9B0", Offset = "0x42AC9B0", VA = "0x1842AD9B0")]
		public int CCBAPMMBPOD(bool ILGDDNPDKNM, Vector3 HNLGFMAOCAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x42ADAE0", Offset = "0x42ACAE0", VA = "0x1842ADAE0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KEINEHKFDKL
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
public interface NMEAKKDPDIG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNOHBPNCEAI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ODFCOPMILHB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FGDCHAGDKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LHCHHDLHEJF> HEELNHKEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KEINEHKFDKL ADPGKJEOLMK
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
	void UpdateClusterDistances(Vector3 PLCNPPEEDPM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(OOELDOIPJKM DHLJMKBEJFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LHCHHDLHEJF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int GFPNILNEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KACGGCOMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float DBGDBJACMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CHINNIMMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte PJADPOLFFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IOKFKIINCPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LONOENGFJNA
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
	private sealed class IDODPIBNFLN : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public IDODPIBNFLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x42B3DE0", Offset = "0x42B2DE0", VA = "0x1842B3DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x42B3EA0", Offset = "0x42B2EA0", VA = "0x1842B3EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IBHHFJCCLPL : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FBNJPIMJMDI <>2__current;

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
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public IBHHFJCCLPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x42B3C40", Offset = "0x42B2C40", VA = "0x1842B3C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42B3D90", Offset = "0x42B2D90", VA = "0x1842B3D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FNKMKMOJPJO : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<FBNJPIMJMDI> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public FNKMKMOJPJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x42AFE20", Offset = "0x42AEE20", VA = "0x1842AFE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x42B0890", Offset = "0x42AF890", VA = "0x1842B0890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PGBDINACGGK : IEnumerator<FBNJPIMJMDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private FBNJPIMJMDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IOKFKIINCPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private FBNJPIMJMDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x583700", Offset = "0x582700", VA = "0x180583700")]
		[DebuggerHidden]
		public PGBDINACGGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x42BA510", Offset = "0x42B9510", VA = "0x1842BA510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x42BB400", Offset = "0x42BA400", VA = "0x1842BB400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int OPOPNFMEKDN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer NOKBHLFADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter INLIOGPAFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject HMNEEJAAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject FFKMJACICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public EFEHPJFIJAP AJFILELOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<OOELDOIPJKM> OKDEGGAALKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<OOELDOIPJKM> MCFDJLMNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<OOELDOIPJKM> HBLCCPEENED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int IKCHOJNDFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LONOENGFJNA HDLJKHPNBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<ODFCOPMILHB>[] BDJHCPKNOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<LHCHHDLHEJF>[] EPEJCEGGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NGEEMJOOCBL EDIMPHMLEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NGEEMJOOCBL BGCICJIMPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NGEEMJOOCBL LGCMPPKKOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int FHJGGLEBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int KELMEILIEPE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static IOKFKIINCPC JJIFKCBGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CGKJMKKLGDJ MFCCEMLPMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HJIKPJJPHPI GABFCGGMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour BNDKEKIIMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material LILGPBFAHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NMEAKKDPDIG> INIOFHMFNDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig LKHGJDHHFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 NNPCFPHKKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E3250", Offset = "0x5E2250", VA = "0x1805E3250")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E3130", Offset = "0x5E2130", VA = "0x1805E3130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LONOENGFJNA PKOGHNALJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68E7C0", Offset = "0x68D7C0", VA = "0x18068E7C0")]
		get
		{
			return default(LONOENGFJNA);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x42B40D0", Offset = "0x42B30D0", VA = "0x1842B40D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IOKFKIINCPC GBAAOFDIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x42B3FC0", Offset = "0x42B2FC0", VA = "0x1842B3FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CINHOMBKDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x42B60C0", Offset = "0x42B50C0", VA = "0x1842B60C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool PPHKAIEBCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x42B5C90", Offset = "0x42B4C90", VA = "0x1842B5C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LAFKNIDOKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x42B4B30", Offset = "0x42B3B30", VA = "0x1842B4B30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x42B48D0", Offset = "0x42B38D0", VA = "0x1842B48D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PDHJCMABPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42B4A20", Offset = "0x42B3A20", VA = "0x1842B4A20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x42B5A40", Offset = "0x42B4A40", VA = "0x1842B5A40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42B6390", Offset = "0x42B5390", VA = "0x1842B6390")]
	public IOKFKIINCPC(CGKJMKKLGDJ MFCCEMLPMFN, HJIKPJJPHPI GABFCGGMAAJ, ClusterLODConfig GBAOEHOEOMP, MonoBehaviour BNDKEKIIMGB, Material LILGPBFAHAB, ClusterMeshRenderer NOKBHLFADHM, MeshFilter INLIOGPAFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42B4040", Offset = "0x42B3040", VA = "0x1842B4040")]
	private void BCAEGDLMNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x42B45D0", Offset = "0x42B35D0", VA = "0x1842B45D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x42B4DB0", Offset = "0x42B3DB0", VA = "0x1842B4DB0")]
	public static void JGHGGNPHEOL(Vector3 EAJFNAIKEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42B61B0", Offset = "0x42B51B0", VA = "0x1842B61B0")]
	private void PGBGCJDNEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42B4C10", Offset = "0x42B3C10", VA = "0x1842B4C10")]
	private void IKEALBNNLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42B6250", Offset = "0x42B5250", VA = "0x1842B6250")]
	private void PLCEKDFPHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42B4E40", Offset = "0x42B3E40", VA = "0x1842B4E40")]
	public void JLIFOLOFJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42B4970", Offset = "0x42B3970", VA = "0x1842B4970")]
	[IteratorStateMachine(typeof(IDODPIBNFLN))]
	private IEnumerator<FBNJPIMJMDI> HAJGPNJJNKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42B5D70", Offset = "0x42B4D70", VA = "0x1842B5D70")]
	[IteratorStateMachine(typeof(IBHHFJCCLPL))]
	private IEnumerator<FBNJPIMJMDI> NEHAGDFEGLK(Func<bool> DAEMEOMJDKL, float IIONOJOHBFG, Func<string> KAHFPPNAFML, float FHNGFBHKJIC = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42B6140", Offset = "0x42B5140", VA = "0x1842B6140")]
	[IteratorStateMachine(typeof(FNKMKMOJPJO))]
	private IEnumerator<FBNJPIMJMDI> OLDJENBGGKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42B43C0", Offset = "0x42B33C0", VA = "0x1842B43C0")]
	public void DGAKGPDAHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42B3EF0", Offset = "0x42B2EF0", VA = "0x1842B3EF0")]
	public void ANGODEPCELI(IEnumerable<ODFCOPMILHB> JNLNIJCHKHN, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42B5E10", Offset = "0x42B4E10", VA = "0x1842B5E10")]
	public void OJMICHNHOBG(IEnumerable<ODFCOPMILHB> JNLNIJCHKHN, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42B5100", Offset = "0x42B4100", VA = "0x1842B5100")]
	public List<ClusterMeshRenderer> JMAKGMOANAF(List<OOELDOIPJKM> PJBBGDLBNHO, Transform FFGCFPCOLFD, KEINEHKFDKL PEANCNOGNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42B49E0", Offset = "0x42B39E0", VA = "0x1842B49E0")]
	public KEINEHKFDKL HKMGABCOBEG(Vector3 LCELPDLNIFH)
	{
		return default(KEINEHKFDKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42B4360", Offset = "0x42B3360", VA = "0x1842B4360")]
	public void DDJBIDKOFCD(NMEAKKDPDIG EHEGKJAGKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x42B4D10", Offset = "0x42B3D10", VA = "0x1842B4D10")]
	public bool JAIBAKJIIAI(NMEAKKDPDIG EHEGKJAGKBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x42B4700", Offset = "0x42B3700", VA = "0x1842B4700")]
	public void EFOJAEMEAHD(OOELDOIPJKM CJAPAINALDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42B5AE0", Offset = "0x42B4AE0", VA = "0x1842B5AE0")]
	public void KFHNHDABPGB(LHCHHDLHEJF KEKKEELMMKA, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42B5CF0", Offset = "0x42B4CF0", VA = "0x1842B5CF0")]
	public void MNJHMGEDFEP(LHCHHDLHEJF KEKKEELMMKA, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42B5B60", Offset = "0x42B4B60", VA = "0x1842B5B60")]
	private void LKJOPAMBBAD(Vector3 PLCNPPEEDPM, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x42B41F0", Offset = "0x42B31F0", VA = "0x1842B41F0")]
	private void DCPFFNGAPLH(Vector3 PLCNPPEEDPM, KEINEHKFDKL PEANCNOGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42B4AC0", Offset = "0x42B3AC0", VA = "0x1842B4AC0")]
	[IteratorStateMachine(typeof(PGBDINACGGK))]
	private IEnumerator<FBNJPIMJMDI> IFIAPIEENFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x42B4760", Offset = "0x42B3760", VA = "0x1842B4760")]
	private int FNLBDELNLBE(int CFANIPEBCPB, int NIDFLPMLOBC, List<LHCHHDLHEJF> JAOPBCKMKNJ, byte FJMMOCNCCBH, ref int NMLHGGCLNCH, float NNLKMGMFLPP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42B5870", Offset = "0x42B4870", VA = "0x1842B5870")]
	public void JPAMCOIJOBL(OOELDOIPJKM DHLJMKBEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x42B4BD0", Offset = "0x42B3BD0", VA = "0x1842B4BD0")]
	public bool IGAFNAKNAFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA30", Offset = "0x5D9A30", VA = "0x1805DAA30")]
	public Material NGBHNFDDJDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x42B4D70", Offset = "0x42B3D70", VA = "0x1842B4D70")]
	public int JFLJPNLGNHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x42B3F70", Offset = "0x42B2F70", VA = "0x1842B3F70")]
	[CompilerGenerated]
	private bool APOGOAIGLKH()
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
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OHANJOKHJME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> AEPOFLKAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> FBKIDAKIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> GKAILPPINDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> JHCEOMGGPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> MGFOHLCCBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 HCPANBNFHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float ENJBHDJNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> OBIANBOMJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> GJACGOKLKND;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x42BA150", Offset = "0x42B9150", VA = "0x1842BA150")]
	public OHANJOKHJME(HEHFIMBCOJI ACEMLDCDLCF, NativeList<float3> MGFOHLCCBBI, NativeMultiHashMap<int, int> OBIANBOMJBJ, NativeArray<int> GJACGOKLKND, Vector3 HCPANBNFHJA, float ENJBHDJNLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x42BA0F0", Offset = "0x42B90F0", VA = "0x1842BA0F0")]
	private int LLDNKODBJFL(float3 PLCNPPEEDPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42B9E50", Offset = "0x42B8E50", VA = "0x1842B9E50")]
	private int JABMGHNKCKJ(int APEAIJJLBLJ, int BJKKIOODGOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x42B9A60", Offset = "0x42B8A60", VA = "0x1842B9A60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PAJBEJIMLCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> OBIANBOMJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> GJACGOKLKND;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int NINJJDNBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x42BA370", Offset = "0x42B9370", VA = "0x1842BA370")]
	public void IDPBFOLPBJK(int IOLKGOCEIDO, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x42BA2C0", Offset = "0x42B92C0", VA = "0x1842BA2C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public PAJBEJIMLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KDOCJCMELDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> HJHBFBGBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> FBLFGIKMGIE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x42B9280", Offset = "0x42B8280", VA = "0x1842B9280")]
	public KDOCJCMELDD(PAJBEJIMLCP NAGJIEGOAKC, HEHFIMBCOJI ACEMLDCDLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x42B91F0", Offset = "0x42B81F0", VA = "0x1842B91F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PJEIPCAIBLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> CEIMKPFIEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> BPPJNFKMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> BKGLDDGNPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> MCKKKFGLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> BLMANHFEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> HJHBFBGBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> NLMBHMKPINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> DKINLOMLLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> HPPIIGMNAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> KHJDMECFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> FOBFIPECCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> DMLBBHBBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float FFAMIOPEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float HPEPIKHBLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 GOLLHPLLPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float OAEFJMBMHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float ABMCBCLDOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float GNKOKACBJGG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x42BCA30", Offset = "0x42BBA30", VA = "0x1842BCA30")]
	public PJEIPCAIBLG(PAJBEJIMLCP MEGLDLNNMEG, HEHFIMBCOJI ACEMLDCDLCF, HEHFIMBCOJI CGIIENMHLIC, float ABMCBCLDOFH, float GNKOKACBJGG, Vector3 GOLLHPLLPKH, float OAEFJMBMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x42BB450", Offset = "0x42BA450", VA = "0x1842BB450")]
	private float3 AFHJMFKBGKO(int APEAIJJLBLJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x42BB820", Offset = "0x42BA820", VA = "0x1842BB820")]
	private void EGFMELHCFCN(int APEAIJJLBLJ, out float3 BCBLJPOHOJN, out float3 NGFHHMHANFD, out float4 IBELJANNJGH, out float4 OFMGKHEJGOK, out float2 PCKAMMNKKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x42BB4F0", Offset = "0x42BA4F0", VA = "0x1842BB4F0")]
	private int BNELKMNBLFG(int ICIFGCOGHNJ, int JMDMDMGHCIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x42BC830", Offset = "0x42BB830", VA = "0x1842BC830")]
	private void OLFIEMKEFHF(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42BC680", Offset = "0x42BB680", VA = "0x1842BC680")]
	private bool GKIPKEKIJHM(int ICIFGCOGHNJ, int JMDMDMGHCIL, float COKGMODPCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x42BC5C0", Offset = "0x42BB5C0", VA = "0x1842BC5C0")]
	private bool GEEJGFCEHBD(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, float COKGMODPCAA, bool MOBHKALHPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x42BC360", Offset = "0x42BB360", VA = "0x1842BC360")]
	private bool FCHABDPJLEM(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, float COKGMODPCAA, bool MOBHKALHPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x42BC810", Offset = "0x42BB810", VA = "0x1842BC810")]
	private void KEKIDMLMIAM(int ICIFGCOGHNJ, int JMDMDMGHCIL, int IDEBJEKIIDG, out int NLFLEMPONBD, out int PHCGNPLCDCC, out int NGKNIOCOGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42BBA00", Offset = "0x42BAA00", VA = "0x1842BBA00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJMINPIFBFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CBCHFCCFFLK : IDisposable, LHCHHDLHEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds IMMOIOCNOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<OOELDOIPJKM> PJBBGDLBNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 IJGMGGAOBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 CPEBMAEALLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int MHOLIINCBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HEHFIMBCOJI NJHIHJJMMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PAJBEJIMLCP HOMIEHMKKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform FFGCFPCOLFD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int NHMFOEELNDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x42AD2F0", Offset = "0x42AC2F0", VA = "0x1842AD2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh BLNMCFPJKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh JHKHKAKKFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5D8550", Offset = "0x5D7550", VA = "0x1805D8550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5D84D0", Offset = "0x5D74D0", VA = "0x1805D84D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DBGDBJACMPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC53F40", Offset = "0xC52F40", VA = "0x180C53F40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x15F5210", Offset = "0x15F4210", VA = "0x1815F5210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte PJADPOLFFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5B62D0", Offset = "0x5B52D0", VA = "0x1805B62D0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5D8490", Offset = "0x5D7490", VA = "0x1805D8490", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GFPNILNEEIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x584F00", Offset = "0x583F00", VA = "0x180584F00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x584B20", Offset = "0x583B20", VA = "0x180584B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int KACGGCOMFPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x584B50", Offset = "0x583B50", VA = "0x180584B50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x584F10", Offset = "0x583F10", VA = "0x180584F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float CHINNIMMFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x42AD130", Offset = "0x42AC130", VA = "0x1842AD130", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x42ACCF0", Offset = "0x42ABCF0", VA = "0x1842ACCF0")]
		public void AOFGDBBDGHG(GMFMCAOCJOB FJMMOCNCCBH, out int OGEIIPHGPPF, out int GMNEOPJLKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x42AD150", Offset = "0x42AC150", VA = "0x1842AD150")]
		public void LEDBKMAFOMD(GMFMCAOCJOB FJMMOCNCCBH, HEEPHPELEBO LEHANDPMPPM, int EPNNCKJAFLP = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x42AD3D0", Offset = "0x42AC3D0", VA = "0x1842AD3D0")]
		public void NBGAHDIBNJH(NativeList<CEHABHFAEKI> CEFGLJKFEGN, Transform OOKCBIBCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x42AD330", Offset = "0x42AC330", VA = "0x1842AD330")]
		public void MPBMPEBJEPI(Mesh ACEMLDCDLCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42ACF20", Offset = "0x42ABF20", VA = "0x1842ACF20")]
		public void BLJEEFDDFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x42ACFC0", Offset = "0x42ABFC0", VA = "0x1842ACFC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x42AD6F0", Offset = "0x42AC6F0", VA = "0x1842AD6F0")]
		public CBCHFCCFFLK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds IMMOIOCNOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<CBCHFCCFFLK> PIGJPBIKDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GNOBKHKEJDB CLIPPKGHDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer OHIDPFBACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int KDCPKJECNDA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh FLOCMKDBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x58C000", Offset = "0x58B000", VA = "0x18058C000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DEHIKNPBBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x584B00", Offset = "0x583B00", VA = "0x180584B00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x584AD0", Offset = "0x583AD0", VA = "0x180584AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FGDCHAGDKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x42B3B50", Offset = "0x42B2B50", VA = "0x1842B3B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x42B2910", Offset = "0x42B1910", VA = "0x1842B2910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x42B3330", Offset = "0x42B2330", VA = "0x1842B3330")]
	public int IHABBCPBIDB(int KKEMAPFBKKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x42B2780", Offset = "0x42B1780", VA = "0x1842B2780")]
	public void BCJNCGAHHOO(LPHJGHFKKLH JGOKBKDGPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x42B2A70", Offset = "0x42B1A70", VA = "0x1842B2A70")]
	public void GFAFNGDIGCI(Transform OOKCBIBCJCI, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x42B3180", Offset = "0x42B2180", VA = "0x1842B3180")]
	public bool ICLHEODHGJA(bool FOPBILLNNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x42B3360", Offset = "0x42B2360", VA = "0x1842B3360")]
	public void JIEINEKHIKJ(Transform FFGCFPCOLFD, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x42B38F0", Offset = "0x42B28F0", VA = "0x1842B38F0")]
	public bool JPAMCOIJOBL(OOELDOIPJKM DHLJMKBEJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x42B3BA0", Offset = "0x42B2BA0", VA = "0x1842B3BA0")]
	public HJMINPIFBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EFEHPJFIJAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<HJMINPIFBFP.CBCHFCCFFLK> IOKECFFPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BCGPEPNKDPL LEBBCHPOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<HJMINPIFBFP.CBCHFCCFFLK> DBOBLGLJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int GAFFCHFLDJD;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42AF2E0", Offset = "0x42AE2E0", VA = "0x1842AF2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x42AF0D0", Offset = "0x42AE0D0", VA = "0x1842AF0D0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x42AF390", Offset = "0x42AE390", VA = "0x1842AF390")]
	public void IONNJMGFDPB(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI, Transform FFGCFPCOLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x42AF440", Offset = "0x42AE440", VA = "0x1842AF440")]
	public void JPAMCOIJOBL(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x42AF150", Offset = "0x42AE150", VA = "0x1842AF150")]
	private HJMINPIFBFP.CBCHFCCFFLK CAPFEAIBPGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x42AF650", Offset = "0x42AE650", VA = "0x1842AF650")]
	private bool NJLNBAADCJG(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42AF5F0", Offset = "0x42AE5F0", VA = "0x1842AF5F0")]
	private void MLGFBNINKCA(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42AF350", Offset = "0x42AE350", VA = "0x1842AF350")]
	public bool HDAGBCHPGJP(HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x42AEE80", Offset = "0x42ADE80", VA = "0x1842AEE80")]
	public bool ADBHOPCDBIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x42AF280", Offset = "0x42AE280", VA = "0x1842AF280")]
	private HJMINPIFBFP.CBCHFCCFFLK CDOCEJENIOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42AF6E0", Offset = "0x42AE6E0", VA = "0x1842AF6E0")]
	public EFEHPJFIJAP()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EJCEDFHAJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int FPFINHCMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int AEECOPCAPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float OACLOJPCPBA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<HJMINPIFBFP> EPCKAPIDGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x42AFDD0", Offset = "0x42AEDD0", VA = "0x1842AFDD0")]
	public EJCEDFHAJNE(int FPFINHCMNKL, int AEECOPCAPOC, float GDBFDJNBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42AFAB0", Offset = "0x42AEAB0", VA = "0x1842AFAB0")]
	public void BDIOELHPFME(OOOOEBEMICC MPDHFFFKLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x42AFB50", Offset = "0x42AEB50", VA = "0x1842AFB50")]
	private int CCGJICLKHHN(LPHJGHFKKLH HCLJNIDPDDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42AF880", Offset = "0x42AE880", VA = "0x1842AF880")]
	private void BDIOELHPFME(LPHJGHFKKLH HCLJNIDPDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42AFBF0", Offset = "0x42AEBF0", VA = "0x1842AFBF0")]
	private void HKCKPHKNMMG(LPHJGHFKKLH HCLJNIDPDDK, HJMINPIFBFP CDPCKEOMHOA)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ODFCOPMILHB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CHDFPINOAHG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5EB910", Offset = "0x5EA910", VA = "0x1805EB910")]
			[DebuggerHidden]
			public CHDFPINOAHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x42AD7B0", Offset = "0x42AC7B0", VA = "0x1842AD7B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x42AD940", Offset = "0x42AC940", VA = "0x1842AD940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x42AD8A0", Offset = "0x42AC8A0", VA = "0x1842AD8A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x42AD8A0", Offset = "0x42AC8A0", VA = "0x1842AD8A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int FGDCHAGDKNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x42AEE20", Offset = "0x42ADE20", VA = "0x1842AEE20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<LHCHHDLHEJF> HEELNHKEKNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x42AEE00", Offset = "0x42ADE00", VA = "0x1842AEE00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> PIGJPBIKDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public HJMINPIFBFP FLOCMKDBCLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public KEINEHKFDKL ADPGKJEOLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x584ED0", Offset = "0x583ED0", VA = "0x180584ED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(KEINEHKFDKL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x584E70", Offset = "0x583E70", VA = "0x180584E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MHGPMFFKHDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x42AEE10", Offset = "0x42ADE10", VA = "0x1842AEE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x42ADB40", Offset = "0x42ACB40", VA = "0x1842ADB40")]
		public static ClusterMeshRenderer Create(HJMINPIFBFP ACEMLDCDLCF, ClusterMeshRenderer NOKBHLFADHM, MeshFilter INLIOGPAFLO, Transform FFGCFPCOLFD, KEINEHKFDKL PEANCNOGNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x42ADC50", Offset = "0x42ACC50", VA = "0x1842ADC50", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x42AE3B0", Offset = "0x42AD3B0", VA = "0x1842AE3B0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(OOELDOIPJKM DHLJMKBEJFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x42AE180", Offset = "0x42AD180", VA = "0x1842AE180")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x42ADEB0", Offset = "0x42ACEB0", VA = "0x1842ADEB0")]
		public void Init(HJMINPIFBFP ACEMLDCDLCF, MeshFilter INLIOGPAFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x42ADCB0", Offset = "0x42ACCB0", VA = "0x1842ADCB0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x42AE4E0", Offset = "0x42AD4E0", VA = "0x1842AE4E0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 PLCNPPEEDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x42AE720", Offset = "0x42AD720", VA = "0x1842AE720", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x42ADE40", Offset = "0x42ACE40", VA = "0x1842ADE40")]
		[IteratorStateMachine(typeof(CHDFPINOAHG))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x42AE200", Offset = "0x42AD200", VA = "0x1842AE200")]
		public void SetupTagAndLayer(string AFNLFJKEJHJ, int PEANCNOGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x42AE1E0", Offset = "0x42AD1E0", VA = "0x1842AE1E0")]
		public bool Remove(OOELDOIPJKM DHLJMKBEJFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct COCBCMBDAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int KAFEOIBCEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int HKONJCKHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int GMNEOPJLKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OGEIIPHGPPF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x42AD990", Offset = "0x42AC990", VA = "0x1842AD990")]
	public COCBCMBDAFI(int HKONJCKHNHA, int GMNEOPJLKEJ, int KAFEOIBCEGC, int OGEIIPHGPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GNOBKHKEJDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<COCBCMBDAFI> AIDCGDDGMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> ONLOEFEDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> BLHLHPBDEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> NOKNCIJCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle KLACIAPNOBO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EJBIELGFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4550", Offset = "0x8D3550", VA = "0x1808D4550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D0500", Offset = "0x8CF500", VA = "0x1808D0500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x42B0B70", Offset = "0x42AFB70", VA = "0x1842B0B70")]
	public void MLLKPFPDJFM(HEHFIMBCOJI HHFJEJINKCD, NativeList<COCBCMBDAFI> AIDCGDDGMJP, float FMODKECMJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x42B18F0", Offset = "0x42B08F0", VA = "0x1842B18F0")]
	public void PFNKOGCIAGO(Transform FFGCFPCOLFD, bool ACPDHMBNBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42B09E0", Offset = "0x42AF9E0", VA = "0x1842B09E0")]
	public void ICLHEODHGJA(HJMINPIFBFP OHIDPFBACFG, bool FOPBILLNNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x42B0910", Offset = "0x42AF910", VA = "0x1842B0910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x42B08E0", Offset = "0x42AF8E0", VA = "0x1842B08E0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public GNOBKHKEJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HBCLKJOCPCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> AKKLCPJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> GCLLJBDGOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<COCBCMBDAFI> GPNKDEOOKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> ONLOEFEDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 GOLLHPLLPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> BLHLHPBDEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> NOKNCIJCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool ACPDHMBNBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float MCNIKEDPOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float MOONBGFALAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float KJDKEIIEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> OKFGMHECAEO;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x42B2370", Offset = "0x42B1370", VA = "0x1842B2370")]
	public HBCLKJOCPCF(GNOBKHKEJDB OMLMACKKNLD, Vector3 GOLLHPLLPKH, bool ACPDHMBNBPG, float MCNIKEDPOGD, float MOONBGFALAB, float KJDKEIIEAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x42B1ED0", Offset = "0x42B0ED0", VA = "0x1842B1ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OOELDOIPJKM : PABLPJMAJCM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds MOGOMPMIDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CEHABHFAEKI HPKIDHLMPPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LPHJGHFKKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<OOELDOIPJKM> PJBBGDLBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public LPHJGHFKKLH HNINKJAJDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public LPHJGHFKKLH PINIGDGGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public LPHJGHFKKLH EAPKCACPDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int OGEIIPHGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds IMMOIOCNOME;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x42B99E0", Offset = "0x42B89E0", VA = "0x1842B99E0")]
	public LPHJGHFKKLH(List<OOELDOIPJKM> PJBBGDLBNHO, [Optional] LPHJGHFKKLH HNINKJAJDDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OOOOEBEMICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<LPHJGHFKKLH> CKHOAODDLJL;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LPHJGHFKKLH APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x42BA210", Offset = "0x42B9210", VA = "0x1842BA210")]
	public OOOOEBEMICC(LPHJGHFKKLH FFGCFPCOLFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JJPIIHKKOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PBOFKJFOGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int CKBHFPLLPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int MHBDJBKCFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int OAILFJGCMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int OBIABCHIGKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GOEGLMFFILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int FAKFABHICGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float AKLBEFKPAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<OOELDOIPJKM> PJBBGDLBNHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum PGKPKKEENMH
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
	private PBOFKJFOGOO HGBLFMCHBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int EPCILDPJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int FPFINHCMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int AEECOPCAPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float GDBFDJNBHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float DACDFFEBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<LPHJGHFKKLH> IHAJAGLHDHG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OOOOEBEMICC EPHDDINLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x42B8580", Offset = "0x42B7580", VA = "0x1842B8580")]
	public JJPIIHKKOJN(int FPFINHCMNKL, int AEECOPCAPOC, float GDBFDJNBHHB, int EPCILDPJFNG, float DACDFFEBHAI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x42B83C0", Offset = "0x42B73C0", VA = "0x1842B83C0")]
	public void IHCOKIBELBM(List<OOELDOIPJKM> PJBBGDLBNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x42B6EF0", Offset = "0x42B5EF0", VA = "0x1842B6EF0")]
	public bool FAGNJDALDNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x42B69B0", Offset = "0x42B59B0", VA = "0x1842B69B0")]
	private float CJBDFHJPNCB(Vector3 OBJPCHOBPAB, Vector3 JDMPDBLFGGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x42B6AC0", Offset = "0x42B5AC0", VA = "0x1842B6AC0")]
	private float CJBDFHJPNCB(Vector3 DDMFGCPNLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x42B7AB0", Offset = "0x42B6AB0", VA = "0x1842B7AB0")]
	private bool HKPDLCMBLCH(LPHJGHFKKLH FMDDFLLHNGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x42B6F60", Offset = "0x42B5F60", VA = "0x1842B6F60")]
	private GOEGLMFFILF HEJOPANLMDC(List<OOELDOIPJKM> AIBIHPCGOIK, PGKPKKEENMH KPLGBEPCDBO)
	{
		return default(GOEGLMFFILF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x42B6B60", Offset = "0x42B5B60", VA = "0x1842B6B60")]
	private void CLAMLEGHAGK(List<OOELDOIPJKM> PJBBGDLBNHO, Vector3[] IHEDEABJLPD, Vector3[] AOAJOEAJCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class HHCEAAPNOMI
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x42B2440", Offset = "0x42B1440", VA = "0x1842B2440")]
	public static Bounds GJIFBDGAHFK(List<OOELDOIPJKM> PJBBGDLBNHO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x42B25F0", Offset = "0x42B15F0", VA = "0x1842B25F0")]
	public static int JFMFJCOGOHB(List<OOELDOIPJKM> PJBBGDLBNHO, GMFMCAOCJOB FJMMOCNCCBH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BCGPEPNKDPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HEHFIMBCOJI DKIGOABCBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HEHFIMBCOJI BDOLPPHDAKO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static HEHFIMBCOJI MGNNPOANPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private BJJDECDFOKP ELDNDJLGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HEEPHPELEBO LEHANDPMPPM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle KLACIAPNOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x5604A0", VA = "0x1805614A0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5614C0", Offset = "0x5604C0", VA = "0x1805614C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public HJMINPIFBFP.CBCHFCCFFLK FMDDFLLHNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HCDIOCGLABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5B00B0", Offset = "0x5AF0B0", VA = "0x1805B00B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x42AC270", Offset = "0x42AB270", VA = "0x1842AC270")]
	[OMDJHDHMGFL(MFFCDMKLBEG.ExitingPlayMode, 0)]
	private void EJDHMECJAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x42AC2E0", Offset = "0x42AB2E0", VA = "0x1842AC2E0")]
	public void MLLKPFPDJFM(HJMINPIFBFP.CBCHFCCFFLK GPNKDEOOKBJ, Transform NGPLIOECNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x42ABC40", Offset = "0x42AAC40", VA = "0x1842ABC40")]
	public void BPBALMFJPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x42AC200", Offset = "0x42AB200", VA = "0x1842AC200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x42ABC00", Offset = "0x42AAC00", VA = "0x1842ABC00")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x42ACC60", Offset = "0x42ABC60", VA = "0x1842ACC60")]
	public BCGPEPNKDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LKHLDPLBOIC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IOKFKIINCPC KCIGLGBKDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HJIKPJJPHPI
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 AIIJOMGJNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CGKJMKKLGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool COJLIKFAGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PGBAPPLOIPN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action IFLFEJNINJN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LECOGMKDAFL
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LECOGMKDAFL HMHEIODENOA(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LECOGMKDAFL FPBNMDALFPO(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LECOGMKDAFL HCEPMODPGFG(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LECOGMKDAFL CEJNOCJEFBG(Action DJBODGKMGGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class GPCMHBBGLGC : LECOGMKDAFL
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KOAONOOFINK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public GPCMHBBGLGC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
				public KOAONOOFINK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x42B92B0", Offset = "0x42B82B0", VA = "0x1842B92B0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x42B9300", Offset = "0x42B8300", VA = "0x1842B9300")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x42B9350", Offset = "0x42B8350", VA = "0x1842B9350")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Func<JobHandle> MGPLNPFAEKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action INIPOLAPKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private Action EEAJAKDNPIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private LNBPFPKJCLA CEHLLAAFCLG;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action LKAEOPBFBHP
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x58C000", Offset = "0x58B000", VA = "0x18058C000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Action BMDDJPBFPMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF570", Offset = "0x1DFE570", VA = "0x181DFF570", Slot = "4")]
			public LECOGMKDAFL HMHEIODENOA(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x225E480", Offset = "0x225D480", VA = "0x18225E480", Slot = "5")]
			public LECOGMKDAFL FPBNMDALFPO(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x225E4A0", Offset = "0x225D4A0", VA = "0x18225E4A0", Slot = "6")]
			public LECOGMKDAFL HCEPMODPGFG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x83E5E0", Offset = "0x83D5E0", VA = "0x18083E5E0", Slot = "7")]
			public LECOGMKDAFL CEJNOCJEFBG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5B9040", Offset = "0x5B8040", VA = "0x1805B9040")]
			public GPCMHBBGLGC(Func<JobHandle> OHMIJAHECFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x42B1B40", Offset = "0x42B0B40", VA = "0x1842B1B40")]
			public void IOHEKBDABGH(Action EAIBKKJMIEL, Action IJEFNINLBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x42B1D70", Offset = "0x42B0D70", VA = "0x1842B1D70")]
			public void JPAMCOIJOBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JJMPOAODFFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public LECOGMKDAFL jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public JJMPOAODFFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x42B69A0", Offset = "0x42B59A0", VA = "0x1842B69A0")]
			internal bool <Remove>b__0(GPCMHBBGLGC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class EGJIMNFNMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public GPCMHBBGLGC newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public EGJIMNFNMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x42AF820", Offset = "0x42AE820", VA = "0x1842AF820")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<GPCMHBBGLGC> DCFDNAMONII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<GPCMHBBGLGC> FGDFHADDNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private NGEEMJOOCBL GILEANECDAO;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CHJKBOBFOHJ GMNMMEOMJHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x42B85E0", Offset = "0x42B75E0", VA = "0x1842B85E0")]
		public LECOGMKDAFL Add(Func<JobHandle> OHMIJAHECFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x42B8880", Offset = "0x42B7880", VA = "0x1842B8880")]
		public void Remove(LECOGMKDAFL KLACIAPNOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x42B8700", Offset = "0x42B7700", VA = "0x1842B8700", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x42B8A00", Offset = "0x42B7A00", VA = "0x1842B8A00")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x42B8BD0", Offset = "0x42B7BD0", VA = "0x1842B8BD0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x42B86F0", Offset = "0x42B76F0", VA = "0x1842B86F0")]
		[CompilerGenerated]
		private void KCNGLAJDOOP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LNBPFPKJCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNBPFPKJCLA HMHEIODENOA(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNBPFPKJCLA CKLFPJADKEO(Action DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNBPFPKJCLA CEJNOCJEFBG(Action DJBODGKMGGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class JDDBFICACJC : LNBPFPKJCLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private JobHandle ADFMGBFGCAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action INIPOLAPKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action BEHPCIKIELE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private Action BMDDJPBFPMD;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool OPGCJKPKIOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x42B6910", Offset = "0x42B5910", VA = "0x1842B6910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x225E480", Offset = "0x225D480", VA = "0x18225E480", Slot = "4")]
			public LNBPFPKJCLA HMHEIODENOA(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x225E4A0", Offset = "0x225D4A0", VA = "0x18225E4A0", Slot = "5")]
			public LNBPFPKJCLA CKLFPJADKEO(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83E5E0", Offset = "0x83D5E0", VA = "0x18083E5E0", Slot = "6")]
			public LNBPFPKJCLA CEJNOCJEFBG(Action DJBODGKMGGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1508670", Offset = "0x1507670", VA = "0x181508670")]
			public JDDBFICACJC(JobHandle BDGBAEHKENH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x42B6920", Offset = "0x42B5920", VA = "0x1842B6920")]
			public void GLIJLNLELKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x42B6960", Offset = "0x42B5960", VA = "0x1842B6960")]
			public void JPAMCOIJOBL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<JDDBFICACJC> IMCGNFKDGHD;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x42B9050", Offset = "0x42B8050", VA = "0x1842B9050")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x42B8C90", Offset = "0x42B7C90", VA = "0x1842B8C90")]
		public LNBPFPKJCLA Add(JobHandle BDGBAEHKENH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x42B8F60", Offset = "0x42B7F60", VA = "0x1842B8F60")]
		public void Remove(LNBPFPKJCLA KLACIAPNOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x42B8E00", Offset = "0x42B7E00", VA = "0x1842B8E00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x42B8D20", Offset = "0x42B7D20", VA = "0x1842B8D20")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x42B9160", Offset = "0x42B8160", VA = "0x1842B9160")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42B9390", Offset = "0x42B8390", VA = "0x1842B9390")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x42B9490", Offset = "0x42B8490", VA = "0x1842B9490")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
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
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
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
