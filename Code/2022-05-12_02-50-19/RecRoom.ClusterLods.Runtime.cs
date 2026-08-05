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
				[Cpp2IlInjected.Address(RVA = "0x43FC380", Offset = "0x43FB780", VA = "0x1843FC380")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x19709A0", Offset = "0x196FDA0", VA = "0x1819709A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x43FC340", Offset = "0x43FB740", VA = "0x1843FC340")]
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
		[Cpp2IlInjected.Address(RVA = "0x43F4BF0", Offset = "0x43F3FF0", VA = "0x1843F4BF0")]
		public LODSettings GIMKHDPMKGD(CKOBBCCFDDO EAENLCOCJLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x43F4BD0", Offset = "0x43F3FD0", VA = "0x1843F4BD0")]
		public int FPFIKFKKKND()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x43F4AD0", Offset = "0x43F3ED0", VA = "0x1843F4AD0")]
		public int ELLGBOLFMFD(bool PFDIDLCEOOF, Vector3 AHDBMKOEIMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x43F4C00", Offset = "0x43F4000", VA = "0x1843F4C00")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BFNLFODHLBO
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
public interface AINNHCDNCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGIJBONPFOE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KLKBFCHFNJF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int EGJPBBPBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<DMIJKLOADGM> LIHFPODJEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BFNLFODHLBO JCIJOALAFAB
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
	void UpdateClusterDistances(Vector3 BHPPHCAFHBD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(JOJKPIPHDPJ GDJGGGALMJF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DMIJKLOADGM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int COOAGPHLBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int IALPOKHJMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NKALBPNNCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LJJOFBJLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte DMCOOEHPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MEKOJCNHFMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum NMKJHGHLFIE
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
	private sealed class BCPLHAMBENJ : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private HBFHEEBHGHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public MEKOJCNHFMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
		[DebuggerHidden]
		public BCPLHAMBENJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x43F2470", Offset = "0x43F1870", VA = "0x1843F2470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x43F2530", Offset = "0x43F1930", VA = "0x1843F2530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IIEFFMKBIPA : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HBFHEEBHGHK <>2__current;

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
		private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
		[DebuggerHidden]
		public IIEFFMKBIPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x43F97D0", Offset = "0x43F8BD0", VA = "0x1843F97D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x43F9920", Offset = "0x43F8D20", VA = "0x1843F9920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JDEPOHHKEOL : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HBFHEEBHGHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MEKOJCNHFMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<HBFHEEBHGHK> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
		[DebuggerHidden]
		public JDEPOHHKEOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x43FABD0", Offset = "0x43F9FD0", VA = "0x1843FABD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x43FB650", Offset = "0x43FAA50", VA = "0x1843FB650", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DJOCKJKEBDD : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HBFHEEBHGHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MEKOJCNHFMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
		[DebuggerHidden]
		public DJOCKJKEBDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x43F5FA0", Offset = "0x43F53A0", VA = "0x1843F5FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x43F6E90", Offset = "0x43F6290", VA = "0x1843F6E90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HHOGLANFIIB = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer KDNIHNHGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter KJALCMHLFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject BOMKPMCCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject MIJDLGFMCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NCMACNFAKDM PHJFKDKFJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<JOJKPIPHDPJ> JANOLJNFBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JOJKPIPHDPJ> GLCPGOHLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JOJKPIPHDPJ> EFFIPFLIJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int MMDCLIGLPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NMKJHGHLFIE MCEDOLJMOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<KLKBFCHFNJF>[] FLGNOHMBHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<DMIJKLOADGM>[] FKGJJHMHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private BHFIPLDLAEJ DHKFMHINGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private BHFIPLDLAEJ GLGDMFEEAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private BHFIPLDLAEJ IBMBEPJBLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NBEGPHCHPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int PLKNLPMBEEL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static MEKOJCNHFMJ JPHKFMHOIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PJGCLKPAOAN KKAEFNMFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DIKFMJMHPKH HDACAOGHBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour LPEBNEBOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material ACOICLPKJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<AINNHCDNCMM> CFMEOGPEALB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig GGFINCKPNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 KIBLEEEHHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xEE12F0", Offset = "0xEE06F0", VA = "0x180EE12F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xEE1200", Offset = "0xEE0600", VA = "0x180EE1200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private NMKJHGHLFIE JBBINBHMOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x565CD0", Offset = "0x5650D0", VA = "0x180565CD0")]
		get
		{
			return default(NMKJHGHLFIE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43FD0B0", Offset = "0x43FC4B0", VA = "0x1843FD0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MEKOJCNHFMJ KFKKKAOCIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43FE7E0", Offset = "0x43FDBE0", VA = "0x1843FE7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JKKEHBGMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x43FE2B0", Offset = "0x43FD6B0", VA = "0x1843FE2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool LDNOMFJBDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43FE700", Offset = "0x43FDB00", VA = "0x1843FE700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> AHAAEFECFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43FC690", Offset = "0x43FBA90", VA = "0x1843FC690")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43FDEF0", Offset = "0x43FD2F0", VA = "0x1843FDEF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CBKELGKJNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43FE440", Offset = "0x43FD840", VA = "0x1843FE440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43FD5A0", Offset = "0x43FC9A0", VA = "0x1843FD5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43FE860", Offset = "0x43FDC60", VA = "0x1843FE860")]
	public MEKOJCNHFMJ(PJGCLKPAOAN KKAEFNMFGND, DIKFMJMHPKH HDACAOGHBBL, ClusterLODConfig MIJALEGLPIC, MonoBehaviour LPEBNEBOELE, Material ACOICLPKJJL, ClusterMeshRenderer KDNIHNHGMOH, MeshFilter KJALCMHLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43FE330", Offset = "0x43FD730", VA = "0x1843FE330")]
	private void KDBHODAKHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43FD640", Offset = "0x43FCA40", VA = "0x1843FD640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43FD4B0", Offset = "0x43FC8B0", VA = "0x1843FD4B0")]
	public static void CGHGHDGMDCO(Vector3 FMHACIMDIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x43FDDF0", Offset = "0x43FD1F0", VA = "0x1843FDDF0")]
	private void HKIGAFMIJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x43FD770", Offset = "0x43FCB70", VA = "0x1843FD770")]
	private void ELGDFMEMIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43FC550", Offset = "0x43FB950", VA = "0x1843FC550")]
	private void AOPMJOKHJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43FD1E0", Offset = "0x43FC5E0", VA = "0x1843FD1E0")]
	public void CFPLGBPLMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43FDA40", Offset = "0x43FCE40", VA = "0x1843FDA40")]
	[IteratorStateMachine(typeof(BCPLHAMBENJ))]
	private IEnumerator<HBFHEEBHGHK> FJLEIHCOEGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43FD010", Offset = "0x43FC410", VA = "0x1843FD010")]
	[IteratorStateMachine(typeof(IIEFFMKBIPA))]
	private IEnumerator<HBFHEEBHGHK> BMHAFELGMPK(Func<bool> NGHFOONOFMA, float OPOIFNPNEEK, Func<string> JPGOECFBNGD, float IPBEEONOFOB = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43FDD00", Offset = "0x43FD100", VA = "0x1843FDD00")]
	[IteratorStateMachine(typeof(JDEPOHHKEOL))]
	private IEnumerator<HBFHEEBHGHK> GHLJLGLGIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43FDAB0", Offset = "0x43FCEB0", VA = "0x1843FDAB0")]
	public void FNBNNELADNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43FE760", Offset = "0x43FDB60", VA = "0x1843FE760")]
	public void OMNMLDJBOIH(IEnumerable<KLKBFCHFNJF> FOKEDANENNM, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43FE000", Offset = "0x43FD400", VA = "0x1843FE000")]
	public void JJKNJCKDOFN(IEnumerable<KLKBFCHFNJF> FOKEDANENNM, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43FC8A0", Offset = "0x43FBCA0", VA = "0x1843FC8A0")]
	public List<ClusterMeshRenderer> BMDFGIAFFJJ(List<JOJKPIPHDPJ> GMGAPAGMKKE, Transform PGMAAINPEGN, BFNLFODHLBO JBNBBJMEEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43FE6C0", Offset = "0x43FDAC0", VA = "0x1843FE6C0")]
	public BFNLFODHLBO OAAJMKBPIJD(Vector3 CFKKBLANHKC)
	{
		return default(BFNLFODHLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x43FE660", Offset = "0x43FDA60", VA = "0x1843FE660")]
	public void NHCCDEJCPID(AINNHCDNCMM FLJILAGPPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x43FD540", Offset = "0x43FC940", VA = "0x1843FD540")]
	public bool DLHCEEHGBII(AINNHCDNCMM FLJILAGPPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x43FDE90", Offset = "0x43FD290", VA = "0x1843FDE90")]
	public void IDKLIFLGHJN(JOJKPIPHDPJ LGPMONIJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43FDD70", Offset = "0x43FD170", VA = "0x1843FDD70")]
	public void GPOCMJGDONO(DMIJKLOADGM KLNNIKJBGAF, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43FE3C0", Offset = "0x43FD7C0", VA = "0x1843FE3C0")]
	public void KIDABLOGGHI(DMIJKLOADGM KLNNIKJBGAF, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43FE4E0", Offset = "0x43FD8E0", VA = "0x1843FE4E0")]
	private void LOOKFIEADAA(Vector3 BHPPHCAFHBD, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43FC730", Offset = "0x43FBB30", VA = "0x1843FC730")]
	private void BHAPCLEMPJJ(Vector3 BHPPHCAFHBD, BFNLFODHLBO JBNBBJMEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43FDF90", Offset = "0x43FD390", VA = "0x1843FDF90")]
	[IteratorStateMachine(typeof(DJOCKJKEBDD))]
	private IEnumerator<HBFHEEBHGHK> IMFJLEAKMFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x43FC3A0", Offset = "0x43FB7A0", VA = "0x1843FC3A0")]
	private int ADHLHEFPHNF(int DBFCFFLFJDL, int FDLJMINNPBG, List<DMIJKLOADGM> JADIHHONOIM, byte EAENLCOCJLC, ref int JCMHDJACBCB, float EIFOKEKIAEF = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x43FD870", Offset = "0x43FCC70", VA = "0x1843FD870")]
	public void EPGMMIBEDJL(JOJKPIPHDPJ GDJGGGALMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43FC510", Offset = "0x43FB910", VA = "0x1843FC510")]
	public bool ALKJFHFFHOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8F0", Offset = "0x5DACF0", VA = "0x1805DB8F0")]
	public Material OMBCKIJJABL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x43FDCC0", Offset = "0x43FD0C0", VA = "0x1843FDCC0")]
	public int FPFIKFKKKND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43FE610", Offset = "0x43FDA10", VA = "0x1843FE610")]
	[CompilerGenerated]
	private bool MANOAEONIPJ()
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
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct NKDIACFLOOJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> GBLILJOOAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> MEHIJDJFNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> KDEPAJLNHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> AIJNDGFALJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> NILLMFDLNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> MJPBLJNGCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> HMNBGOJEIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 ILLEADKJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float HHKOJIIIFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> OILEIDBMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> ENFAFFICICF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4401AA0", Offset = "0x4400EA0", VA = "0x184401AA0")]
	public NKDIACFLOOJ(LJCGODPDPOD HGKBCBNOCFB, NativeList<float3> HMNBGOJEIKD, NativeMultiHashMap<int, int> OILEIDBMPPF, NativeArray<int> ENFAFFICICF, Vector3 ILLEADKJECM, float HHKOJIIIFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x44013B0", Offset = "0x44007B0", VA = "0x1844013B0")]
	private int CKGFNEKANPO(float3 BHPPHCAFHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4401800", Offset = "0x4400C00", VA = "0x184401800")]
	private int MILKMFGHEEB(int BOPGJDPNNAI, int KACNOLACOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4401410", Offset = "0x4400810", VA = "0x184401410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EEKEIJCKGEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> OILEIDBMPPF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> ENFAFFICICF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int BNOALKDCAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> NACBDFEEGBF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x43F7530", Offset = "0x43F6930", VA = "0x1843F7530")]
	public void JIJHLLEDIMF(int IPBBHAOFOMI, Allocator APEEBDDMKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x43F7480", Offset = "0x43F6880", VA = "0x1843F7480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EEKEIJCKGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GHDCELEHLGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> OOOANIGAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> PIAJGEKALFC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x43F8DC0", Offset = "0x43F81C0", VA = "0x1843F8DC0")]
	public GHDCELEHLGM(EEKEIJCKGEC NCJMGKDOHNI, LJCGODPDPOD HGKBCBNOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43F8D30", Offset = "0x43F8130", VA = "0x1843F8D30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct NLMIDHCDIHF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> KDAEKANDJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> ONFJHGOPIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> DKCALLILNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> ECDFAGPBHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> MFFKBNLOCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> NACBDFEEGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> OOOANIGAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> LOGKNNOKIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> DLNNOIKKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> NFPGAGFOHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> BELAJGAPLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> ABHMBOHLDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> GAJLKNJFCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float KAEMIFFCAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float NOLGHCNJIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 FMAEIHEJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float AFEJPPEKFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float ONLIOKPPCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float FMCBLLGMMFB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4403140", Offset = "0x4402540", VA = "0x184403140")]
	public NLMIDHCDIHF(EEKEIJCKGEC ODHPDMBBAJO, LJCGODPDPOD HGKBCBNOCFB, LJCGODPDPOD CFLBMLOOKJG, float ONLIOKPPCKB, float FMCBLLGMMFB, Vector3 FMAEIHEJDNA, float AFEJPPEKFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4402EA0", Offset = "0x44022A0", VA = "0x184402EA0")]
	private float3 OBFLIONMAHC(int BOPGJDPNNAI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4401E90", Offset = "0x4401290", VA = "0x184401E90")]
	private void BOBNMDHJNNB(int BOPGJDPNNAI, out float3 LBCOHEJPOFC, out float3 DFMBOCOBKMP, out float4 APDLKIAJNJI, out float4 PPCLJNCIOBB, out float2 OELBJDHHPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4401B60", Offset = "0x4400F60", VA = "0x184401B60")]
	private int BGFBKPELGNK(int NEIEJOPGKAJ, int POJPLPFBPMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4402F40", Offset = "0x4402340", VA = "0x184402F40")]
	private void OLLKIICGPHJ(int NEIEJOPGKAJ, int POJPLPFBPMD, int NKFKOMMDBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4402A90", Offset = "0x4401E90", VA = "0x184402A90")]
	private bool IDKANJMELLM(int NEIEJOPGKAJ, int POJPLPFBPMD, float CJANJBGMJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4402070", Offset = "0x4401470", VA = "0x184402070")]
	private bool DEEMLJENOAG(int NEIEJOPGKAJ, int POJPLPFBPMD, int NKFKOMMDBEO, float CJANJBGMJJF, bool GJHJAHIKDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4402C40", Offset = "0x4402040", VA = "0x184402C40")]
	private bool NGACHJJLKND(int NEIEJOPGKAJ, int POJPLPFBPMD, int NKFKOMMDBEO, float CJANJBGMJJF, bool GJHJAHIKDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4402C20", Offset = "0x4402020", VA = "0x184402C20")]
	private void IGFJCIFBFML(int NEIEJOPGKAJ, int POJPLPFBPMD, int NKFKOMMDBEO, out int FEIIINANABF, out int ILEFJGEHLNP, out int ADEENBEPHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4402130", Offset = "0x4401530", VA = "0x184402130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BHLDIALIDEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BJHKJCPJFOK : IDisposable, DMIJKLOADGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds PPDOGEAJJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<JOJKPIPHDPJ> GMGAPAGMKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 MDPEBMKLHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 EEHAGKLFOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int KMEJPKCOCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LJCGODPDPOD DPNDHGLLMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EEKEIJCKGEC HFCIPLFEHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform PGMAAINPEGN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int LPAFDCCCGMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x43F4460", Offset = "0x43F3860", VA = "0x1843F4460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh DKKFKEFIHIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh CDBDILDJHEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x553010", Offset = "0x552410", VA = "0x180553010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x553020", Offset = "0x552420", VA = "0x180553020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NKALBPNNCEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE6FFF0", Offset = "0xE6F3F0", VA = "0x180E6FFF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E346C0", Offset = "0x1E33AC0", VA = "0x181E346C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte DMCOOEHPMNP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6CEC50", Offset = "0x6CE050", VA = "0x1806CEC50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6CEDE0", Offset = "0x6CE1E0", VA = "0x1806CEDE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int COOAGPHLBKE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7364C0", Offset = "0x7358C0", VA = "0x1807364C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x735B50", Offset = "0x734F50", VA = "0x180735B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int IALPOKHJMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4E0", Offset = "0xB198E0", VA = "0x180B1A4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD80080", Offset = "0xD7F480", VA = "0x180D80080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float LJJOFBJLJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x43F4070", Offset = "0x43F3470", VA = "0x1843F4070", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x43F4090", Offset = "0x43F3490", VA = "0x1843F4090")]
		public void KHCPMDHMMBG(CKOBBCCFDDO EAENLCOCJLC, out int IJLHEAGHGFK, out int JJLIKJCCNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x43F42C0", Offset = "0x43F36C0", VA = "0x1843F42C0")]
		public void LJMDJONNCIJ(CKOBBCCFDDO EAENLCOCJLC, OJPIEEFGLNM GPOGJDEILFE, int CGMOAFBDHFN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43F3D50", Offset = "0x43F3150", VA = "0x1843F3D50")]
		public void IIHLLLEPPAI(NativeList<OEDOMAIFGLJ> HNGDDLBEOAO, Transform NINJACGOAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x43F3CB0", Offset = "0x43F30B0", VA = "0x1843F3CB0")]
		public void EHAFOABEPGI(Mesh HGKBCBNOCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x43F3AA0", Offset = "0x43F2EA0", VA = "0x1843F3AA0")]
		public void CDDINIEFAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x43F3B40", Offset = "0x43F2F40", VA = "0x1843F3B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x43F44A0", Offset = "0x43F38A0", VA = "0x1843F44A0")]
		public BJHKJCPJFOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds PPDOGEAJJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<BJHKJCPJFOK> HNIOOBGBDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public IPDCNEPCNBE JFKBOFHELGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer BJBBMMOBBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int BFKLMFLHDAL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh JKMPGAJJDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x675A90", Offset = "0x674E90", VA = "0x180675A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GJNBAIPEAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7A9C20", Offset = "0x7A9020", VA = "0x1807A9C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A9CA0", Offset = "0x7A90A0", VA = "0x1807A9CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EGJPBBPBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x43F2B80", Offset = "0x43F1F80", VA = "0x1843F2B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x43F2610", Offset = "0x43F1A10", VA = "0x1843F2610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x43F25E0", Offset = "0x43F19E0", VA = "0x1843F25E0")]
	public int CHKMBGFGOKL(int EOCPMELJBJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x43F2BD0", Offset = "0x43F1FD0", VA = "0x1843F2BD0")]
	public void MDPNBLDCKKB(PHANMNMKDDO LLOCIDPANFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x43F32F0", Offset = "0x43F26F0", VA = "0x1843F32F0")]
	public void OJDHAPLIFJO(Transform NINJACGOAMC, bool HHFCPMIDKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x43F29D0", Offset = "0x43F1DD0", VA = "0x1843F29D0")]
	public bool FOEMANLJDCC(bool LFMMFLPGPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x43F2D60", Offset = "0x43F2160", VA = "0x1843F2D60")]
	public void ODHNGHPBPNL(Transform PGMAAINPEGN, bool HHFCPMIDKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x43F2770", Offset = "0x43F1B70", VA = "0x1843F2770")]
	public bool EPGMMIBEDJL(JOJKPIPHDPJ GDJGGGALMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x43F3A00", Offset = "0x43F2E00", VA = "0x1843F3A00")]
	public BHLDIALIDEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NCMACNFAKDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<BHLDIALIDEC.BJHKJCPJFOK> EHOHDBPFBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private EPDMJINIHEJ KEDMLGBDENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<BHLDIALIDEC.BJHKJCPJFOK> PGAEOLLCPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int DPNLMIAIMBF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43FEDE0", Offset = "0x43FE1E0", VA = "0x1843FEDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x43FF370", Offset = "0x43FE770", VA = "0x1843FF370")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x43FF1D0", Offset = "0x43FE5D0", VA = "0x1843FF1D0")]
	public void KCLLGEJMGAB(BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB, Transform PGMAAINPEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x43FEE50", Offset = "0x43FE250", VA = "0x1843FEE50")]
	public void EPGMMIBEDJL(BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x43FF060", Offset = "0x43FE460", VA = "0x1843FF060")]
	private BHLDIALIDEC.BJHKJCPJFOK HFEIIGCKBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x43FF280", Offset = "0x43FE680", VA = "0x1843FF280")]
	private bool LMOIBHOJHCC(BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x43FF310", Offset = "0x43FE710", VA = "0x1843FF310")]
	private void MJJPPOLJDMO(BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x43FF190", Offset = "0x43FE590", VA = "0x1843FF190")]
	public bool HPFNHPHKLIA(BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x43FF3F0", Offset = "0x43FE7F0", VA = "0x1843FF3F0")]
	public bool PKNIMKAHKBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x43FF000", Offset = "0x43FE400", VA = "0x1843FF000")]
	private BHLDIALIDEC.BJHKJCPJFOK FAJFACOLIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x43FF640", Offset = "0x43FEA40", VA = "0x1843FF640")]
	public NCMACNFAKDM()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EEBHNIMKEAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int FNADEJMJMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int LEKMPAOJNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float GJOCCPOEAGP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<BHLDIALIDEC> OOHOAGHJIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x43F7430", Offset = "0x43F6830", VA = "0x1843F7430")]
	public EEBHNIMKEAB(int FNADEJMJMDD, int LEKMPAOJNKI, float CEGLGOOBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x43F7160", Offset = "0x43F6560", VA = "0x1843F7160")]
	public void LDPMDIJEKPN(HDEKPFJIKGL OLLJDGLBEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x43F6EE0", Offset = "0x43F62E0", VA = "0x1843F6EE0")]
	private int AJCCDJNAONJ(PHANMNMKDDO FKKCOCJCKAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x43F7200", Offset = "0x43F6600", VA = "0x1843F7200")]
	private void LDPMDIJEKPN(PHANMNMKDDO FKKCOCJCKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x43F6F80", Offset = "0x43F6380", VA = "0x1843F6F80")]
	private void GKCLEOLEEND(PHANMNMKDDO FKKCOCJCKAD, BHLDIALIDEC NCDAMPGMFLA)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, KLKBFCHFNJF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BOCGGKIKOMD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
			[DebuggerHidden]
			public BOCGGKIKOMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x43F4560", Offset = "0x43F3960", VA = "0x1843F4560", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x43F46F0", Offset = "0x43F3AF0", VA = "0x1843F46F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x43F4650", Offset = "0x43F3A50", VA = "0x1843F4650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x43F4650", Offset = "0x43F3A50", VA = "0x1843F4650", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int EGJPBBPBJHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x43F5F40", Offset = "0x43F5340", VA = "0x1843F5F40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<DMIJKLOADGM> LIHFPODJEBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x43F5F20", Offset = "0x43F5320", VA = "0x1843F5F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> HNIOOBGBDEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public BHLDIALIDEC JKMPGAJJDAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public BFNLFODHLBO JCIJOALAFAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x553390", Offset = "0x552790", VA = "0x180553390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(BFNLFODHLBO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x693E90", Offset = "0x693290", VA = "0x180693E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HCAHMLFECKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x43F5F30", Offset = "0x43F5330", VA = "0x1843F5F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x43F4C60", Offset = "0x43F4060", VA = "0x1843F4C60")]
		public static ClusterMeshRenderer Create(BHLDIALIDEC HGKBCBNOCFB, ClusterMeshRenderer KDNIHNHGMOH, MeshFilter KJALCMHLFPM, Transform PGMAAINPEGN, BFNLFODHLBO JBNBBJMEEEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x43F4D70", Offset = "0x43F4170", VA = "0x1843F4D70", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x43F54D0", Offset = "0x43F48D0", VA = "0x1843F54D0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JOJKPIPHDPJ GDJGGGALMJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x43F52A0", Offset = "0x43F46A0", VA = "0x1843F52A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x43F4FD0", Offset = "0x43F43D0", VA = "0x1843F4FD0")]
		public void Init(BHLDIALIDEC HGKBCBNOCFB, MeshFilter KJALCMHLFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x43F4DD0", Offset = "0x43F41D0", VA = "0x1843F4DD0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x43F5600", Offset = "0x43F4A00", VA = "0x1843F5600", Slot = "8")]
		public void UpdateClusterDistances(Vector3 BHPPHCAFHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x43F5840", Offset = "0x43F4C40", VA = "0x1843F5840", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x43F4F60", Offset = "0x43F4360", VA = "0x1843F4F60")]
		[IteratorStateMachine(typeof(BOCGGKIKOMD))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x43F5320", Offset = "0x43F4720", VA = "0x1843F5320")]
		public void SetupTagAndLayer(string JEAGDIEOIOP, int JBNBBJMEEEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x43F5300", Offset = "0x43F4700", VA = "0x1843F5300")]
		public bool Remove(JOJKPIPHDPJ GDJGGGALMJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OBELNOFCFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int FICKAFKIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LLBPABECDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int JJLIKJCCNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int IJLHEAGHGFK;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4403290", Offset = "0x4402690", VA = "0x184403290")]
	public OBELNOFCFJH(int LLBPABECDNP, int JJLIKJCCNID, int FICKAFKIMPM, int IJLHEAGHGFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IPDCNEPCNBE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> GBLILJOOAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> NACBDFEEGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> MJPBLJNGCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<OBELNOFCFJH> CGOODLNMGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> FIFKMCLELNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> PKGCOFMDCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> EFMOCHIBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle DPEEOCHHMKN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DLILJOKMPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71EE40", Offset = "0x71E240", VA = "0x18071EE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71EE60", Offset = "0x71E260", VA = "0x18071EE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x43F9C90", Offset = "0x43F9090", VA = "0x1843F9C90")]
	public void EEKOKJGOMAH(LJCGODPDPOD PLFJINDCFIL, NativeList<OBELNOFCFJH> CGOODLNMGBI, float HMDOOIHLCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x43F9970", Offset = "0x43F8D70", VA = "0x1843F9970")]
	public void DJFDPCBGEDD(Transform PGMAAINPEGN, bool HHFCPMIDKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x43FAA10", Offset = "0x43F9E10", VA = "0x1843FAA10")]
	public void FOEMANLJDCC(BHLDIALIDEC BJBBMMOBBBD, bool LFMMFLPGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x43F9BC0", Offset = "0x43F8FC0", VA = "0x1843F9BC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x43FABA0", Offset = "0x43F9FA0", VA = "0x1843FABA0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public IPDCNEPCNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct FAOHHHICCCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> GBLILJOOAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> NACBDFEEGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<OBELNOFCFJH> LDAFJIGDOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> FIFKMCLELNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 FMAEIHEJDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> PKGCOFMDCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> EFMOCHIBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool HHFCPMIDKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float BCOKBECCGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float GDDAJJGEGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float FOKJIMDBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> MJPBLJNGCNA;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x43F8C60", Offset = "0x43F8060", VA = "0x1843F8C60")]
	public FAOHHHICCCF(IPDCNEPCNBE BMLODNIACAG, Vector3 FMAEIHEJDNA, bool HHFCPMIDKIH, float BCOKBECCGID, float GDDAJJGEGJD, float FOKJIMDBOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x43F87C0", Offset = "0x43F7BC0", VA = "0x1843F87C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JOJKPIPHDPJ : ALEIHAPCDEM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds EPJNBENNCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OEDOMAIFGLJ POOLNAEKKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PHANMNMKDDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<JOJKPIPHDPJ> GMGAPAGMKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public PHANMNMKDDO PDIGOPINEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public PHANMNMKDDO GLBJOJILPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public PHANMNMKDDO FOLLKEICEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int IJLHEAGHGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds PPDOGEAJJLF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4403390", Offset = "0x4402790", VA = "0x184403390")]
	public PHANMNMKDDO(List<JOJKPIPHDPJ> GMGAPAGMKKE, [Optional] PHANMNMKDDO PDIGOPINEPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HDEKPFJIKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<PHANMNMKDDO> ADLGEFBGNLN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PHANMNMKDDO CGAFANNDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x43F93E0", Offset = "0x43F87E0", VA = "0x1843F93E0")]
	public HDEKPFJIKGL(PHANMNMKDDO PGMAAINPEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NDJJBFOGBGN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OIKEDJPANOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int AEAMJCGHEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int LDAOLEKAKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int CAEMAOMDCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int ANNGBFDDPGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JMOEJAPCJFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int AINKEMKBNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float ABKGKELIOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<JOJKPIPHDPJ> GMGAPAGMKKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NJIEPEHJEIJ
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
	private OIKEDJPANOK EGFMBGGMEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int GLKEIGGLOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int FNADEJMJMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int LEKMPAOJNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float CEGLGOOBIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float MDCKMFOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<PHANMNMKDDO> GMHGIFOLKHP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HDEKPFJIKGL POAOAJEMAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4401350", Offset = "0x4400750", VA = "0x184401350")]
	public NDJJBFOGBGN(int FNADEJMJMDD, int LEKMPAOJNKI, float CEGLGOOBIJL, int GLKEIGGLOMG, float MDCKMFOLLGN = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x43FF930", Offset = "0x43FED30", VA = "0x1843FF930")]
	public void BAPBEDACMMF(List<JOJKPIPHDPJ> GMGAPAGMKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x44012E0", Offset = "0x44006E0", VA = "0x1844012E0")]
	public bool MNDHKKBFINA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x43FF780", Offset = "0x43FEB80", VA = "0x1843FF780")]
	private float AFJCFBMCCML(Vector3 AANMGJFAJAH, Vector3 KFNCJNENKCK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x43FF890", Offset = "0x43FEC90", VA = "0x1843FF890")]
	private float AFJCFBMCCML(Vector3 IJHNFJCHOAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4400640", Offset = "0x43FFA40", VA = "0x184400640")]
	private bool IFFOFHDDHBK(PHANMNMKDDO LEKFJHCHEIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x43FFAF0", Offset = "0x43FEEF0", VA = "0x1843FFAF0")]
	private JMOEJAPCJFG EJDMLFAGMJG(List<JOJKPIPHDPJ> ALMPKFMILHB, NJIEPEHJEIJ OAGBOMACKDC)
	{
		return default(JMOEJAPCJFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4400F50", Offset = "0x4400350", VA = "0x184400F50")]
	private void LHHMFAMIOHE(List<JOJKPIPHDPJ> GMGAPAGMKKE, Vector3[] HPIJKIKIPOF, Vector3[] EEGILPLLJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IEEJPNJNMNE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x43F9490", Offset = "0x43F8890", VA = "0x1843F9490")]
	public static Bounds ALIAHJHNGHM(List<JOJKPIPHDPJ> GMGAPAGMKKE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x43F9640", Offset = "0x43F8A40", VA = "0x1843F9640")]
	public static int PBLDBHMICNC(List<JOJKPIPHDPJ> GMGAPAGMKKE, CKOBBCCFDDO EAENLCOCJLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EPDMJINIHEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private LJCGODPDPOD NCEDHGGNDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LJCGODPDPOD KEAPBMMNCPP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static LJCGODPDPOD DKIJOBLBFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private ELHLMLCKDAA CMBMJFIOICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private OJPIEEFGLNM GPOGJDEILFE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle DPEEOCHHMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8864E0", Offset = "0x8858E0", VA = "0x1808864E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x886500", Offset = "0x885900", VA = "0x180886500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BHLDIALIDEC.BJHKJCPJFOK LEKFJHCHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JLLNCMLGJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B2CA0", Offset = "0x6B20A0", VA = "0x1806B2CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x43F86C0", Offset = "0x43F7AC0", VA = "0x1843F86C0")]
	[KLMIIILDGMA(LHKHIKFHCPH.ExitingPlayMode, 0)]
	private void PENDDFLCDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x43F7D00", Offset = "0x43F7100", VA = "0x1843F7D00")]
	public void EEKOKJGOMAH(BHLDIALIDEC.BJHKJCPJFOK LDAFJIGDOCG, Transform LPEKHAHIKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x43F76D0", Offset = "0x43F6AD0", VA = "0x1843F76D0")]
	public void AHEGKKDBDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x43F7C90", Offset = "0x43F7090", VA = "0x1843F7C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x43F8680", Offset = "0x43F7A80", VA = "0x1843F8680")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x43F8730", Offset = "0x43F7B30", VA = "0x1843F8730")]
	public EPDMJINIHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KDKCHPHMPKF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MEKOJCNHFMJ AJIEKPBKONK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DIKFMJMHPKH
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 GEANCGMMMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PJGCLKPAOAN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JFKPECPLEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NNNOPCFHIAN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action EDKCABMBMHI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FNEPLGJKHLE
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNEPLGJKHLE IHHAINCHAFD(Action MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNEPLGJKHLE KNNNDJCKJBL(Action MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNEPLGJKHLE LELNECGFLED(Action MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNEPLGJKHLE LONOGAMDCCK(Action MOOMHHEHKEJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class CEIBNAHAIIJ : FNEPLGJKHLE
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PAKNCNFLHGH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public CEIBNAHAIIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
				public PAKNCNFLHGH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x44032B0", Offset = "0x44026B0", VA = "0x1844032B0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x4403300", Offset = "0x4402700", VA = "0x184403300")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4403350", Offset = "0x4402750", VA = "0x184403350")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> CGHALHAJLJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action HKDCNGFCOHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action LENGKEOPINP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private CBNPAJIFFHA NHIGFBDGDID;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action MLNGCNLIACJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x675A90", Offset = "0x674E90", VA = "0x180675A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action HPIBFPJEENC
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x255EBE0", Offset = "0x255DFE0", VA = "0x18255EBE0", Slot = "4")]
			public FNEPLGJKHLE IHHAINCHAFD(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x27E1160", Offset = "0x27E0560", VA = "0x1827E1160", Slot = "5")]
			public FNEPLGJKHLE KNNNDJCKJBL(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2955DF0", Offset = "0x29551F0", VA = "0x182955DF0", Slot = "6")]
			public FNEPLGJKHLE LELNECGFLED(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xF1ABD0", Offset = "0xF19FD0", VA = "0x180F1ABD0", Slot = "7")]
			public FNEPLGJKHLE LONOGAMDCCK(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6B3A70", Offset = "0x6B2E70", VA = "0x1806B3A70")]
			public CEIBNAHAIIJ(Func<JobHandle> EOGMDKDHNPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x43F4740", Offset = "0x43F3B40", VA = "0x1843F4740")]
			public void BJMGFHMHFHD(Action EPAAFGOLNHK, Action NCCCFHLFIPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x43F4970", Offset = "0x43F3D70", VA = "0x1843F4970")]
			public void EPGMMIBEDJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OAKCFHCPEKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public FNEPLGJKHLE jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public OAKCFHCPEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4403280", Offset = "0x4402680", VA = "0x184403280")]
			internal bool <Remove>b__0(CEIBNAHAIIJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BGIKHPBECBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public CEIBNAHAIIJ newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public BGIKHPBECBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x43F2580", Offset = "0x43F1980", VA = "0x1843F2580")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<CEIBNAHAIIJ> MPMIFJLKOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<CEIBNAHAIIJ> PIAODCIAPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private BHFIPLDLAEJ MHGDIAKEGLC;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x43FB740", Offset = "0x43FAB40", VA = "0x1843FB740")]
		public FNEPLGJKHLE Add(Func<JobHandle> EOGMDKDHNPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x43FB9D0", Offset = "0x43FADD0", VA = "0x1843FB9D0")]
		public void Remove(FNEPLGJKHLE DPEEOCHHMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x43FB850", Offset = "0x43FAC50", VA = "0x1843FB850", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x43FBB50", Offset = "0x43FAF50", VA = "0x1843FBB50")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x43FBD20", Offset = "0x43FB120", VA = "0x1843FBD20")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x43FB730", Offset = "0x43FAB30", VA = "0x1843FB730")]
		[CompilerGenerated]
		private void APFKJAJHKDB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CBNPAJIFFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBNPAJIFFHA IHHAINCHAFD(Action MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBNPAJIFFHA JIEAIPOCJCG(Action MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBNPAJIFFHA LONOGAMDCCK(Action MOOMHHEHKEJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class JDJGIDELHKH : CBNPAJIFFHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle JAGDGJEMBPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action HKDCNGFCOHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action JBCKHPGMBHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action HPIBFPJEENC;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool NLIAJPDLOIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x43FB720", Offset = "0x43FAB20", VA = "0x1843FB720")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x27E1160", Offset = "0x27E0560", VA = "0x1827E1160", Slot = "4")]
			public CBNPAJIFFHA IHHAINCHAFD(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2955DF0", Offset = "0x29551F0", VA = "0x182955DF0", Slot = "5")]
			public CBNPAJIFFHA JIEAIPOCJCG(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xF1ABD0", Offset = "0xF19FD0", VA = "0x180F1ABD0", Slot = "6")]
			public CBNPAJIFFHA LONOGAMDCCK(Action MOOMHHEHKEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCB0200", Offset = "0xCAF600", VA = "0x180CB0200")]
			public JDJGIDELHKH(JobHandle JOGNJMFMLEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x43FB6E0", Offset = "0x43FAAE0", VA = "0x1843FB6E0")]
			public void KNOFFOGILML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x43FB6A0", Offset = "0x43FAAA0", VA = "0x1843FB6A0")]
			public void EPGMMIBEDJL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<JDJGIDELHKH> OHKAFGJILPF;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x43FC1A0", Offset = "0x43FB5A0", VA = "0x1843FC1A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x43FBDE0", Offset = "0x43FB1E0", VA = "0x1843FBDE0")]
		public CBNPAJIFFHA Add(JobHandle JOGNJMFMLEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x43FC0B0", Offset = "0x43FB4B0", VA = "0x1843FC0B0")]
		public void Remove(CBNPAJIFFHA DPEEOCHHMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x43FBF50", Offset = "0x43FB350", VA = "0x1843FBF50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x43FBE70", Offset = "0x43FB270", VA = "0x1843FBE70")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x43FC2B0", Offset = "0x43FB6B0", VA = "0x1843FC2B0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x43F8DF0", Offset = "0x43F81F0", VA = "0x1843F8DF0")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x43F8EF0", Offset = "0x43F82F0", VA = "0x1843F8EF0")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
