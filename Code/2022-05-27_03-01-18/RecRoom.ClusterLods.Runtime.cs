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
				[Cpp2IlInjected.Address(RVA = "0x45358F0", Offset = "0x45348F0", VA = "0x1845358F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xBE9420", Offset = "0xBE8420", VA = "0x180BE9420")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x45358B0", Offset = "0x45348B0", VA = "0x1845358B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x452D5D0", Offset = "0x452C5D0", VA = "0x18452D5D0")]
		public LODSettings HFDPHOMNEJF(POMHGFHEEKJ AILOIIHNAGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x452D5B0", Offset = "0x452C5B0", VA = "0x18452D5B0")]
		public int DCJGPEFAJFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x452D5E0", Offset = "0x452C5E0", VA = "0x18452D5E0")]
		public int LCEEPHPFHOB(bool MCIEMGCPDAC, Vector3 JHAAGIJNPGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x452D6E0", Offset = "0x452C6E0", VA = "0x18452D6E0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FDEFJGAIGLI
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
public interface JMNHOLDFBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBLAHAODIBL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EOEOCCMILJH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KMDNPNBGJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<CPIKDOKDLIP> LALHLHGAGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FDEFJGAIGLI IHNJGHAOBNH
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
	void UpdateClusterDistances(Vector3 BLAFHLFJGAO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(LBKOJFHLGEN LPKJELLIJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CPIKDOKDLIP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FHAKFKCCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int PLFDHIHAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LJPKGLLODMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MIDHLNAJEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte JHBFPHJOBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KPGBNLPOLND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DJAMNHCEBDP
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
	private sealed class IIKNDDGKPPP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
		[DebuggerHidden]
		public IIKNDDGKPPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4531540", Offset = "0x4530540", VA = "0x184531540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4531600", Offset = "0x4530600", VA = "0x184531600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NFAFAEMKKHP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MCOOOHEMEPE <>2__current;

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
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
		[DebuggerHidden]
		public NFAFAEMKKHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4537790", Offset = "0x4536790", VA = "0x184537790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x45378E0", Offset = "0x45368E0", VA = "0x1845378E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ONMOHMGLNEC : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<MCOOOHEMEPE> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
		[DebuggerHidden]
		public ONMOHMGLNEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4539C80", Offset = "0x4538C80", VA = "0x184539C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x453A6F0", Offset = "0x45396F0", VA = "0x18453A6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MIGCNABLKCM : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public KPGBNLPOLND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5EF540", Offset = "0x5EE540", VA = "0x1805EF540")]
		[DebuggerHidden]
		public MIGCNABLKCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4535910", Offset = "0x4534910", VA = "0x184535910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4536800", Offset = "0x4535800", VA = "0x184536800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int EAGOECCIHEI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer KBIDCABBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter MOCJEBLHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject DPNCNCBPGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject JHHOMMGLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MKKJNKDCMFB IMPAEBPJOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<LBKOJFHLGEN> AJLKGEIAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<LBKOJFHLGEN> ABDAOBKMIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<LBKOJFHLGEN> CFLLEMPHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int JDBONGNAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private DJAMNHCEBDP MFNOKCKMAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<EOEOCCMILJH>[] DHEOMOLIPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<CPIKDOKDLIP>[] KHHKANLFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private JPGLPKCHKEM CPBCLOIKHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private JPGLPKCHKEM HALCLFNOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private JPGLPKCHKEM CCFICBMBPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KPMDDKOMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int AJPNOACBDLK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static KPGBNLPOLND KOIDPFHNKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GNANNLFBEEB NLLAAABFKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FAENLNEJNFO ADIGMPGONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour IDIODGAKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material ILLBDIKBEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<JMNHOLDFBHG> JFECPPFHHPF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JNGBEHOBDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DDIBCEAPCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x22F6220", Offset = "0x22F5220", VA = "0x1822F6220")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x22F6140", Offset = "0x22F5140", VA = "0x1822F6140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private DJAMNHCEBDP KHPHPHHNJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x603180", Offset = "0x602180", VA = "0x180603180")]
		get
		{
			return default(DJAMNHCEBDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4534500", Offset = "0x4533500", VA = "0x184534500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KPGBNLPOLND NNHENCBEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x45346A0", Offset = "0x45336A0", VA = "0x1845346A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BNCJJGAENOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4533750", Offset = "0x4532750", VA = "0x184533750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HILCAJBCOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4533910", Offset = "0x4532910", VA = "0x184533910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NFFDAFLDOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4532D70", Offset = "0x4531D70", VA = "0x184532D70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4532400", Offset = "0x4531400", VA = "0x184532400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FOBLGBHFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4533B20", Offset = "0x4532B20", VA = "0x184533B20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x45347C0", Offset = "0x45337C0", VA = "0x1845347C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4534860", Offset = "0x4533860", VA = "0x184534860")]
	public KPGBNLPOLND(GNANNLFBEEB NLLAAABFKDL, FAENLNEJNFO ADIGMPGONIN, ClusterLODConfig NJAPJMBPPCB, MonoBehaviour IDIODGAKJEN, Material ILLBDIKBEHI, ClusterMeshRenderer KBIDCABBFLH, MeshFilter MOCJEBLHKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4532BB0", Offset = "0x4531BB0", VA = "0x184532BB0")]
	private void DJNEBDEPIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4532C40", Offset = "0x4531C40", VA = "0x184532C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4533290", Offset = "0x4532290", VA = "0x184533290")]
	public static void HFCGKKEEPFE(Vector3 LFBABJAEIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45324A0", Offset = "0x45314A0", VA = "0x1845324A0")]
	private void AMGGPDNPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4533650", Offset = "0x4532650", VA = "0x184533650")]
	private void JPMCBCABMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x45337D0", Offset = "0x45327D0", VA = "0x1845337D0")]
	private void LCPKDMGFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4532540", Offset = "0x4531540", VA = "0x184532540")]
	public void BLGEDAAGMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x45331D0", Offset = "0x45321D0", VA = "0x1845331D0")]
	[IteratorStateMachine(typeof(IIKNDDGKPPP))]
	private IEnumerator<MCOOOHEMEPE> GABLENPOHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x45346E0", Offset = "0x45336E0", VA = "0x1845346E0")]
	[IteratorStateMachine(typeof(NFAFAEMKKHP))]
	private IEnumerator<MCOOOHEMEPE> PKLAOAHDMGN(Func<bool> JFOHMDJAGHO, float HFMGPPJGPEM, Func<string> CLIAJPEGGNJ, float GPOLLDHIKAK = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4533160", Offset = "0x4532160", VA = "0x184533160")]
	[IteratorStateMachine(typeof(ONMOHMGLNEC))]
	private IEnumerator<MCOOOHEMEPE> FPDAACFJADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4532E10", Offset = "0x4531E10", VA = "0x184532E10")]
	public void ELMFKCALKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x45330E0", Offset = "0x45320E0", VA = "0x1845330E0")]
	public void FMGNBBMKPPA(IEnumerable<EOEOCCMILJH> DAFKGGCFHKE, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45333A0", Offset = "0x45323A0", VA = "0x1845333A0")]
	public void JEBNLGMCFHF(IEnumerable<EOEOCCMILJH> DAFKGGCFHKE, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4533D90", Offset = "0x4532D90", VA = "0x184533D90")]
	public List<ClusterMeshRenderer> NGDDPKPKLGE(List<LBKOJFHLGEN> HHCAAMAPGPK, Transform PFOHKHPLBFI, FDEFJGAIGLI MHDHIIHJHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4534780", Offset = "0x4533780", VA = "0x184534780")]
	public FDEFJGAIGLI PKLJLOOLGBH(Vector3 ENHAFCAMOMK)
	{
		return default(FDEFJGAIGLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x45329E0", Offset = "0x45319E0", VA = "0x1845329E0")]
	public void CNAINGNDLHL(JMNHOLDFBHG EEILLLKBOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4533020", Offset = "0x4532020", VA = "0x184533020")]
	public bool EPMEHOJOFAI(JMNHOLDFBHG EEILLLKBOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4533080", Offset = "0x4532080", VA = "0x184533080")]
	public void FCJBMPKNPHJ(LBKOJFHLGEN FDLDOMOMGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4533320", Offset = "0x4532320", VA = "0x184533320")]
	public void IBGONDOADNP(CPIKDOKDLIP OONMAFOODBN, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4534620", Offset = "0x4533620", VA = "0x184534620")]
	public void OBACFOPIABH(CPIKDOKDLIP OONMAFOODBN, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4532A80", Offset = "0x4531A80", VA = "0x184532A80")]
	private void DFCDHGGIIPD(Vector3 BLAFHLFJGAO, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4532800", Offset = "0x4531800", VA = "0x184532800")]
	private void CIALPNLBBPK(Vector3 BLAFHLFJGAO, FDEFJGAIGLI MHDHIIHJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4532970", Offset = "0x4531970", VA = "0x184532970")]
	[IteratorStateMachine(typeof(MIGCNABLKCM))]
	private IEnumerator<MCOOOHEMEPE> CLABFFFBGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x45339B0", Offset = "0x45329B0", VA = "0x1845339B0")]
	private int MGAGKAPBCLL(int HOOANEAGKNH, int PDBJJDLABLI, List<CPIKDOKDLIP> BKMBJKPOCBF, byte AILOIIHNAGP, ref int HNFHLNHGINM, float LOPKGDOPGIA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4533BC0", Offset = "0x4532BC0", VA = "0x184533BC0")]
	public void MNHCGCIEOKP(LBKOJFHLGEN LPKJELLIJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4533970", Offset = "0x4532970", VA = "0x184533970")]
	public bool LKMGMNKOEAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB170", Offset = "0x5CA170", VA = "0x1805CB170")]
	public Material PPGAJKPMKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4532A40", Offset = "0x4531A40", VA = "0x184532A40")]
	public int DCJGPEFAJFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4533240", Offset = "0x4532240", VA = "0x184533240")]
	[CompilerGenerated]
	private bool GNPDJMFHOJN()
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
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GOHDMFMOCJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> MEEJMFMKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> ECEGHMLEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> DPOLBOMBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> MGCOIIFNAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> HCGDLOECDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 BKIOFCECEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float HEDLEIOCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> BFMGPAEPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> CIPLJEJIPBM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4530E00", Offset = "0x452FE00", VA = "0x184530E00")]
	public GOHDMFMOCJO(GMPJPDMCHBE FCHIEFHJLOJ, NativeList<float3> HCGDLOECDMO, NativeMultiHashMap<int, int> BFMGPAEPLGE, NativeArray<int> CIPLJEJIPBM, Vector3 BKIOFCECEJF, float HEDLEIOCNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x45309B0", Offset = "0x452F9B0", VA = "0x1845309B0")]
	private int DIJOMKJBIGJ(float3 BLAFHLFJGAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4530710", Offset = "0x452F710", VA = "0x184530710")]
	private int AHPMHHCNIDI(int CKOCCIDDCLA, int MKDJIBNCKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4530A10", Offset = "0x452FA10", VA = "0x184530A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CAFAIOBMGPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> BFMGPAEPLGE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> CIPLJEJIPBM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int BDOKFKNNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x452D030", Offset = "0x452C030", VA = "0x18452D030")]
	public void IJFCHAHKPJL(int DDDKIEOJEJK, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x452CF80", Offset = "0x452BF80", VA = "0x18452CF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public CAFAIOBMGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KHAKDPEBAPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LPAFEMKKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> NIKCDEBFLHL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x45322F0", Offset = "0x45312F0", VA = "0x1845322F0")]
	public KHAKDPEBAPB(CAFAIOBMGPE KMIPPFPIMPG, GMPJPDMCHBE FCHIEFHJLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4532260", Offset = "0x4531260", VA = "0x184532260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ENFLPOGLAKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> FDGKCBIDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> OBCFOPACBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> PINKDDDNFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> HIAHLHAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> HPNFFEPAHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LPAFEMKKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> FBKGGDAMOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> GHCPDCNCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> IPPKHKMMOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> DMLKLAFPCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> LBIJGPKFJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> FNFEJOAONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float JOBCMOCLCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float NOCBPDKHMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 EFIAJFLJHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float HKEBGKGPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float HAPELBHHFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float NFELGDCJCGA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45303F0", Offset = "0x452F3F0", VA = "0x1845303F0")]
	public ENFLPOGLAKF(CAFAIOBMGPE HPKMOIPICJA, GMPJPDMCHBE FCHIEFHJLOJ, GMPJPDMCHBE FNHDENHGNKP, float HAPELBHHFPE, float NFELGDCJCGA, Vector3 EFIAJFLJHPD, float HKEBGKGPCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x452FEF0", Offset = "0x452EEF0", VA = "0x18452FEF0")]
	private float3 KNPODPMLDBL(int CKOCCIDDCLA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x452FB60", Offset = "0x452EB60", VA = "0x18452FB60")]
	private void GGDPNLKDCOL(int CKOCCIDDCLA, out float3 BAFPOHIKDIC, out float3 EKJFBCGJGCF, out float4 BGOLOJBCGAM, out float4 LAPCKCNHANN, out float2 EMKNBOPKKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x452EE10", Offset = "0x452DE10", VA = "0x18452EE10")]
	private int ADKFCGCPBKK(int IGNMKIOPNBJ, int POLHDOKGPMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x45301F0", Offset = "0x452F1F0", VA = "0x1845301F0")]
	private void OFGIACLHEBI(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x452FD60", Offset = "0x452ED60", VA = "0x18452FD60")]
	private bool JNOKHPIOHJE(int IGNMKIOPNBJ, int POLHDOKGPMF, float KAIJDJCEGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x452F140", Offset = "0x452E140", VA = "0x18452F140")]
	private bool CPHFDFLKHOD(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, float KAIJDJCEGJC, bool AIIGBOPGMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x452FF90", Offset = "0x452EF90", VA = "0x18452FF90")]
	private bool MPKMPGFJHPL(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, float KAIJDJCEGJC, bool AIIGBOPGMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x452FD40", Offset = "0x452ED40", VA = "0x18452FD40")]
	private void IKHAGCGOOKE(int IGNMKIOPNBJ, int POLHDOKGPMF, int OLGHJHFEDBO, out int OPGDEKLLEIF, out int MJDGHCPPIKG, out int CIOHGOFCBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x452F200", Offset = "0x452E200", VA = "0x18452F200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PFFNEOFKMIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LDFNAGEIOID : IDisposable, CPIKDOKDLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds LKAHHEMJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<LBKOJFHLGEN> HHCAAMAPGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 HEPJHADPLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 GPAPBDIJIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int LOKOGEKFABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public GMPJPDMCHBE GFDOJBLDHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CAFAIOBMGPE ECAAEMIMPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform PFOHKHPLBFI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BHBCKMOAJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4535340", Offset = "0x4534340", VA = "0x184535340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh CDIMFHEHOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh LCHKJABKPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5CBDE0", Offset = "0x5CADE0", VA = "0x1805CBDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5F0560", Offset = "0x5EF560", VA = "0x1805F0560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LJPKGLLODMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5CEAC0", Offset = "0x5CDAC0", VA = "0x1805CEAC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5CEE40", Offset = "0x5CDE40", VA = "0x1805CEE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte JHBFPHJOBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x686B90", Offset = "0x685B90", VA = "0x180686B90")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x722FB0", Offset = "0x721FB0", VA = "0x180722FB0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FHAKFKCCDFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5AAD80", Offset = "0x5A9D80", VA = "0x1805AAD80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5AAD70", Offset = "0x5A9D70", VA = "0x1805AAD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int PLFDHIHAMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xBE9600", Offset = "0xBE8600", VA = "0x180BE9600", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9260F0", Offset = "0x9250F0", VA = "0x1809260F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float MIDHLNAJEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4535630", Offset = "0x4534630", VA = "0x184535630", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4535110", Offset = "0x4534110", VA = "0x184535110")]
		public void BDELPLCMBMK(POMHGFHEEKJ AILOIIHNAGP, out int MHDCFAJEMPJ, out int ENLELCDJLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4535650", Offset = "0x4534650", VA = "0x184535650")]
		public void NJDCCNCOOHC(POMHGFHEEKJ AILOIIHNAGP, MINNFNFMJEB PPCPOJNGOMJ, int PEPKJOMFLHN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4534DF0", Offset = "0x4533DF0", VA = "0x184534DF0")]
		public void AGJLCDICPEF(NativeList<DHPPIAAJBJB> OOJAMBILCHN, Transform OIJAJOJNFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x45354F0", Offset = "0x45344F0", VA = "0x1845354F0")]
		public void HMFMECDMMHC(Mesh FCHIEFHJLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4535590", Offset = "0x4534590", VA = "0x184535590")]
		public void LDMLKODGGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4535380", Offset = "0x4534380", VA = "0x184535380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x45357F0", Offset = "0x45347F0", VA = "0x1845357F0")]
		public LDFNAGEIOID()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds LKAHHEMJOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<LDFNAGEIOID> DFNMDEJPPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NPCPNMFEDNL KFOBDBKNPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer OGIOFICPCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int LEKKNALFCOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh PDKMCKDACHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F20", Offset = "0x6BFF20", VA = "0x1806C0F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool BAOMOAFIJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85CB20", Offset = "0x85BB20", VA = "0x18085CB20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85CC40", Offset = "0x85BC40", VA = "0x18085CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int KMDNPNBGJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x453B5D0", Offset = "0x453A5D0", VA = "0x18453B5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x453AEE0", Offset = "0x4539EE0", VA = "0x18453AEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x453A7A0", Offset = "0x45397A0", VA = "0x18453A7A0")]
	public int CCHDIDECNBK(int MEIEGGCKEGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x453B620", Offset = "0x453A620", VA = "0x18453B620")]
	public void LPBDEFLIJNM(CBDDFBINNBH BLHINANEKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x453A7D0", Offset = "0x45397D0", VA = "0x18453A7D0")]
	public void DNCMOAGDELK(Transform OIJAJOJNFJD, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x453BA10", Offset = "0x453AA10", VA = "0x18453BA10")]
	public bool OLIIMNGMEME(bool KOPNNMKHPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x453B040", Offset = "0x453A040", VA = "0x18453B040")]
	public void GILCDBFNOIH(Transform PFOHKHPLBFI, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x453B7B0", Offset = "0x453A7B0", VA = "0x18453B7B0")]
	public bool MNHCGCIEOKP(LBKOJFHLGEN LPKJELLIJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x453BBC0", Offset = "0x453ABC0", VA = "0x18453BBC0")]
	public PFFNEOFKMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MKKJNKDCMFB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<PFFNEOFKMIJ.LDFNAGEIOID> OCIACKNLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NJDAKPMJAJM FLAHGBOJFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<PFFNEOFKMIJ.LDFNAGEIOID> BHCHLICKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int JDCDINJGGJF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4536AC0", Offset = "0x4535AC0", VA = "0x184536AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4536A40", Offset = "0x4535A40", VA = "0x184536A40")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4536FC0", Offset = "0x4535FC0", VA = "0x184536FC0")]
	public void NENJMCKJAJO(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ, Transform PFOHKHPLBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4536E10", Offset = "0x4535E10", VA = "0x184536E10")]
	public void MNHCGCIEOKP(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4536850", Offset = "0x4535850", VA = "0x184536850")]
	private PFFNEOFKMIJ.LDFNAGEIOID AIMBCAKNIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4536B30", Offset = "0x4535B30", VA = "0x184536B30")]
	private bool GBMGADGGPJA(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45369E0", Offset = "0x45359E0", VA = "0x1845369E0")]
	private void CGDFAODKIIK(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4537070", Offset = "0x4536070", VA = "0x184537070")]
	public bool OFBHFIGDMKC(PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4536BC0", Offset = "0x4535BC0", VA = "0x184536BC0")]
	public bool IFFNNMKLCCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4536980", Offset = "0x4535980", VA = "0x184536980")]
	private PFFNEOFKMIJ.LDFNAGEIOID BCENAJOFKOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x45370B0", Offset = "0x45360B0", VA = "0x1845370B0")]
	public MKKJNKDCMFB()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MNEMCHIGFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int NKDMBMAIGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int CPKJECPONJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float CGOMCFKJMLD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<PFFNEOFKMIJ> OHEHMKAEMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4537740", Offset = "0x4536740", VA = "0x184537740")]
	public MNEMCHIGFHN(int NKDMBMAIGPH, int CPKJECPONJE, float CNKLEJPEOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x45376A0", Offset = "0x45366A0", VA = "0x1845376A0")]
	public void LICCBMBMGDI(ALMPPELKLDK CBMJLFGKDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45373D0", Offset = "0x45363D0", VA = "0x1845373D0")]
	private int HDGGEIIBJEN(CBDDFBINNBH BOKLJENJLOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4537470", Offset = "0x4536470", VA = "0x184537470")]
	private void LICCBMBMGDI(CBDDFBINNBH BOKLJENJLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45371F0", Offset = "0x45361F0", VA = "0x1845371F0")]
	private void EPCGNDALNLE(CBDDFBINNBH BOKLJENJLOP, PFFNEOFKMIJ EDKICBHOIAC)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, EOEOCCMILJH
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GEPDBPJFPCN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x81C050", Offset = "0x81B050", VA = "0x18081C050")]
			[DebuggerHidden]
			public GEPDBPJFPCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4530530", Offset = "0x452F530", VA = "0x184530530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x45306C0", Offset = "0x452F6C0", VA = "0x1845306C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4530620", Offset = "0x452F620", VA = "0x184530620", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4530620", Offset = "0x452F620", VA = "0x184530620", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int KMDNPNBGJDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x452EA20", Offset = "0x452DA20", VA = "0x18452EA20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<CPIKDOKDLIP> LALHLHGAGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x452EA00", Offset = "0x452DA00", VA = "0x18452EA00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> DFNMDEJPPCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PFFNEOFKMIJ PDKMCKDACHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public FDEFJGAIGLI IHNJGHAOBNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5AA1D0", Offset = "0x5A91D0", VA = "0x1805AA1D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(FDEFJGAIGLI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5AA210", Offset = "0x5A9210", VA = "0x1805AA210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HIEEIFBKMJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x452EA10", Offset = "0x452DA10", VA = "0x18452EA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x452D740", Offset = "0x452C740", VA = "0x18452D740")]
		public static ClusterMeshRenderer Create(PFFNEOFKMIJ FCHIEFHJLOJ, ClusterMeshRenderer KBIDCABBFLH, MeshFilter MOCJEBLHKIJ, Transform PFOHKHPLBFI, FDEFJGAIGLI MHDHIIHJHAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x452D850", Offset = "0x452C850", VA = "0x18452D850", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x452DFB0", Offset = "0x452CFB0", VA = "0x18452DFB0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(LBKOJFHLGEN LPKJELLIJFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x452DD80", Offset = "0x452CD80", VA = "0x18452DD80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x452DAB0", Offset = "0x452CAB0", VA = "0x18452DAB0")]
		public void Init(PFFNEOFKMIJ FCHIEFHJLOJ, MeshFilter MOCJEBLHKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x452D8B0", Offset = "0x452C8B0", VA = "0x18452D8B0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x452E0E0", Offset = "0x452D0E0", VA = "0x18452E0E0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 BLAFHLFJGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x452E320", Offset = "0x452D320", VA = "0x18452E320", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x452DA40", Offset = "0x452CA40", VA = "0x18452DA40")]
		[IteratorStateMachine(typeof(GEPDBPJFPCN))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x452DE00", Offset = "0x452CE00", VA = "0x18452DE00")]
		public void SetupTagAndLayer(string FJLIOINDIMA, int MHDHIIHJHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x452DDE0", Offset = "0x452CDE0", VA = "0x18452DDE0")]
		public bool Remove(LBKOJFHLGEN LPKJELLIJFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CJMPPCLJLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int JJLDEEEMFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AHNBCGDLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int ENLELCDJLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MHDCFAJEMPJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x452D250", Offset = "0x452C250", VA = "0x18452D250")]
	public CJMPPCLJLPE(int AHNBCGDLBJF, int ENLELCDJLGN, int JJLDEEEMFEA, int MHDCFAJEMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NPCPNMFEDNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<CJMPPCLJLPE> ACDGKKJEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> BAFPCHPGMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> HEJMBEMECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> AIBMNFOFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle BJOELKKLLNF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ELPPJMJNBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB64DA0", Offset = "0xB63DA0", VA = "0x180B64DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xB64DC0", Offset = "0xB63DC0", VA = "0x180B64DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4538B20", Offset = "0x4537B20", VA = "0x184538B20")]
	public void GELLHDINKCG(GMPJPDMCHBE ENICKBJPBHG, NativeList<CJMPPCLJLPE> ACDGKKJEIHJ, float FJJOIFJEGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x45398A0", Offset = "0x45388A0", VA = "0x1845398A0")]
	public void HMJCLPNGLNC(Transform PFOHKHPLBFI, bool GPEDFAEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4539AF0", Offset = "0x4538AF0", VA = "0x184539AF0")]
	public void OLIIMNGMEME(PFFNEOFKMIJ OGIOFICPCOK, bool KOPNNMKHPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4538A50", Offset = "0x4537A50", VA = "0x184538A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4538A20", Offset = "0x4537A20", VA = "0x184538A20")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public NPCPNMFEDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct AADIOKMKGMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> AMCMOHMLBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> HBHGEOHLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<CJMPPCLJLPE> BKOFDJGFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> BAFPCHPGMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 EFIAJFLJHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> HEJMBEMECKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> AIBMNFOFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GPEDFAEJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float LBNOBIOAFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float NMPOGJLAOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float ICNAPOOIPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> PBAMPFKDJCA;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x452B1D0", Offset = "0x452A1D0", VA = "0x18452B1D0")]
	public AADIOKMKGMO(NPCPNMFEDNL OBKJCGHFNGC, Vector3 EFIAJFLJHPD, bool GPEDFAEJAAE, float LBNOBIOAFDN, float NMPOGJLAOGO, float ICNAPOOIPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x452AD30", Offset = "0x4529D30", VA = "0x18452AD30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LBKOJFHLGEN : EHLGKNDONGG
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds GODKIDCOFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DHPPIAAJBJB ACOBFGEFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CBDDFBINNBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<LBKOJFHLGEN> HHCAAMAPGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public CBDDFBINNBH COLFLONKFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public CBDDFBINNBH OJKNAGPFBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public CBDDFBINNBH APKBBKCKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int MHDCFAJEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds LKAHHEMJOBH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x452D1D0", Offset = "0x452C1D0", VA = "0x18452D1D0")]
	public CBDDFBINNBH(List<LBKOJFHLGEN> HHCAAMAPGPK, [Optional] CBDDFBINNBH COLFLONKFJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ALMPPELKLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<CBDDFBINNBH> GOGBGMMFNFA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CBDDFBINNBH MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x452CED0", Offset = "0x452BED0", VA = "0x18452CED0")]
	public ALMPPELKLDK(CBDDFBINNBH PFOHKHPLBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AGDMDJOHJEI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BNPLNEIIMEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int EEKOODIKLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int JKPMDBCJAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int KPELOEFBHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int KAKLMGCGFDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FAOBACGMMHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int ACJIDOOCDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float AJKDHJOJNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<LBKOJFHLGEN> HHCAAMAPGPK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JLOFKMOOGDF
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
	private BNPLNEIIMEO FCDHBHNDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int GKMFAJALHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int NKDMBMAIGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int CPKJECPONJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float CNKLEJPEOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float JCAEGJGOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<CBDDFBINNBH> LICPPKLDIDA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ALMPPELKLDK GCFLOOHKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x452CE70", Offset = "0x452BE70", VA = "0x18452CE70")]
	public AGDMDJOHJEI(int NKDMBMAIGPH, int CPKJECPONJE, float CNKLEJPEOPJ, int GKMFAJALHIG, float JCAEGJGOAAF = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x452B2A0", Offset = "0x452A2A0", VA = "0x18452B2A0")]
	public void FHLCAJJCLBJ(List<LBKOJFHLGEN> HHCAAMAPGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x452BD70", Offset = "0x452AD70", VA = "0x18452BD70")]
	public bool LKNPDJHDKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x452BDE0", Offset = "0x452ADE0", VA = "0x18452BDE0")]
	private float MNFIEDIMNLJ(Vector3 EEIGLGPCDBO, Vector3 GPKLECHELAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x452BEF0", Offset = "0x452AEF0", VA = "0x18452BEF0")]
	private float MNFIEDIMNLJ(Vector3 KMCJMFPOINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x452B460", Offset = "0x452A460", VA = "0x18452B460")]
	private bool KFIMCJCJCIH(CBDDFBINNBH DPLNLAAKNGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x452BF90", Offset = "0x452AF90", VA = "0x18452BF90")]
	private FAOBACGMMHG NOKCJAJDPBC(List<LBKOJFHLGEN> PFHAAIKHHJH, JLOFKMOOGDF PNLMCDIBOLC)
	{
		return default(FAOBACGMMHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x452CAE0", Offset = "0x452BAE0", VA = "0x18452CAE0")]
	private void PMCGHJMLKPL(List<LBKOJFHLGEN> HHCAAMAPGPK, Vector3[] MJJFGBIJOHP, Vector3[] IHBNPPMEEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CMEDGEBGEBG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x452D270", Offset = "0x452C270", VA = "0x18452D270")]
	public static Bounds EKCPCNGHLIP(List<LBKOJFHLGEN> HHCAAMAPGPK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x452D420", Offset = "0x452C420", VA = "0x18452D420")]
	public static int LGDNDEGFFDD(List<LBKOJFHLGEN> HHCAAMAPGPK, POMHGFHEEKJ AILOIIHNAGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NJDAKPMJAJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private GMPJPDMCHBE IPAEFCKILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private GMPJPDMCHBE IHEMEOBEOJC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static GMPJPDMCHBE HKJLBDMDAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private FPCNMIJJHDP LOBBMILCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MINNFNFMJEB PPCPOJNGOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle BJOELKKLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x698DB0", Offset = "0x697DB0", VA = "0x180698DB0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E32C0", Offset = "0x7E22C0", VA = "0x1807E32C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PFFNEOFKMIJ.LDFNAGEIOID DPLNLAAKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HENGMGJFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2BB0", Offset = "0x9F1BB0", VA = "0x1809F2BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4538920", Offset = "0x4537920", VA = "0x184538920")]
	[NAOLMNKNAMK(DKCHBDLNPEE.ExitingPlayMode, 0)]
	private void KOJKAJHDHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x45379E0", Offset = "0x45369E0", VA = "0x1845379E0")]
	public void GELLHDINKCG(PFFNEOFKMIJ.LDFNAGEIOID BKOFDJGFENC, Transform FOMIJDEBKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4538360", Offset = "0x4537360", VA = "0x184538360")]
	public void JKKEFOAMGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4537970", Offset = "0x4536970", VA = "0x184537970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4537930", Offset = "0x4536930", VA = "0x184537930")]
	public void CGFAFPCCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4538990", Offset = "0x4537990", VA = "0x184538990")]
	public NJDAKPMJAJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KAJAGDGENKE
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KPGBNLPOLND GHPIIIMPJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FAENLNEJNFO
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 BPLGKLMHCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GNANNLFBEEB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ILCAELDJKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BMDCNJCOKDC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action HEEGEHJBMCK;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FKMPEFALPCD
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKMPEFALPCD LAHALOJBENP(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKMPEFALPCD HLNPNBAOBBN(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKMPEFALPCD LBAPBAGNNHI(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKMPEFALPCD JMOJJNENGBL(Action BKCLKIJOKLP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class EKHDBGLFICN : FKMPEFALPCD
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class KNKILFMJHHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public EKHDBGLFICN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
				public KNKILFMJHHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4532320", Offset = "0x4531320", VA = "0x184532320")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x4532370", Offset = "0x4531370", VA = "0x184532370")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x45323C0", Offset = "0x45313C0", VA = "0x1845323C0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Func<JobHandle> KDCNBPADJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action FKAHPDKCMML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private Action KPJMOKCIIPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private LICOPOJIKBN KNPFNLMMMNC;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action BPLHCAEFDDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x6C0F20", Offset = "0x6BFF20", VA = "0x1806C0F20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Action DGNHHFNLFEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9F8BC0", Offset = "0x9F7BC0", VA = "0x1809F8BC0", Slot = "4")]
			public FKMPEFALPCD LAHALOJBENP(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC62AF0", Offset = "0xC61AF0", VA = "0x180C62AF0", Slot = "5")]
			public FKMPEFALPCD HLNPNBAOBBN(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1085C30", Offset = "0x1084C30", VA = "0x181085C30", Slot = "6")]
			public FKMPEFALPCD LBAPBAGNNHI(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xB40B20", Offset = "0xB3FB20", VA = "0x180B40B20", Slot = "7")]
			public FKMPEFALPCD JMOJJNENGBL(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x74E8A0", Offset = "0x74D8A0", VA = "0x18074E8A0")]
			public EKHDBGLFICN(Func<JobHandle> BHFKDHGKMLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x452EBE0", Offset = "0x452DBE0", VA = "0x18452EBE0")]
			public void OBHHENOOAOJ(Action BAIEKHIKCGG, Action FHPKEGMMJHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x452EA80", Offset = "0x452DA80", VA = "0x18452EA80")]
			public void MNHCGCIEOKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class LAHLLBNHING
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public FKMPEFALPCD jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public LAHLLBNHING()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4534DE0", Offset = "0x4533DE0", VA = "0x184534DE0")]
			internal bool <Remove>b__0(EKHDBGLFICN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PCENLBAHBDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public EKHDBGLFICN newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public PCENLBAHBDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x453A740", Offset = "0x4539740", VA = "0x18453A740")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<EKHDBGLFICN> DJCJEADNBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<EKHDBGLFICN> PKAPBDDLJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private JPGLPKCHKEM HBAPDMHJLAB;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public MBHNFDOCNFI JFAFFCMDOIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4531650", Offset = "0x4530650", VA = "0x184531650")]
		public FKMPEFALPCD Add(Func<JobHandle> BHFKDHGKMLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x45318F0", Offset = "0x45308F0", VA = "0x1845318F0")]
		public void Remove(FKMPEFALPCD BJOELKKLLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4531770", Offset = "0x4530770", VA = "0x184531770", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4531A70", Offset = "0x4530A70", VA = "0x184531A70")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4531C40", Offset = "0x4530C40", VA = "0x184531C40")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4531760", Offset = "0x4530760", VA = "0x184531760")]
		[CompilerGenerated]
		private void KHELHPBPDFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LICOPOJIKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LICOPOJIKBN LAHALOJBENP(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LICOPOJIKBN NENIJEOINOO(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LICOPOJIKBN JMOJJNENGBL(Action BKCLKIJOKLP);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class HKBCGJLKECG : LICOPOJIKBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private JobHandle GIMMFIDPNIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action FKAHPDKCMML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action LBGNGCAAOHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private Action DGNHHFNLFEI;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool EHMINPKKADE
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x45314F0", Offset = "0x45304F0", VA = "0x1845314F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC62AF0", Offset = "0xC61AF0", VA = "0x180C62AF0", Slot = "4")]
			public LICOPOJIKBN LAHALOJBENP(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1085C30", Offset = "0x1084C30", VA = "0x181085C30", Slot = "5")]
			public LICOPOJIKBN NENIJEOINOO(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB40B20", Offset = "0xB3FB20", VA = "0x180B40B20", Slot = "6")]
			public LICOPOJIKBN JMOJJNENGBL(Action BKCLKIJOKLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7EC460", Offset = "0x7EB460", VA = "0x1807EC460")]
			public HKBCGJLKECG(JobHandle CMJNCGOCEKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x45314B0", Offset = "0x45304B0", VA = "0x1845314B0")]
			public void AKPIIOLAJBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4531500", Offset = "0x4530500", VA = "0x184531500")]
			public void MNHCGCIEOKP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<HKBCGJLKECG> OJKNKAOKOAK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x45320C0", Offset = "0x45310C0", VA = "0x1845320C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4531D00", Offset = "0x4530D00", VA = "0x184531D00")]
		public LICOPOJIKBN Add(JobHandle CMJNCGOCEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4531FD0", Offset = "0x4530FD0", VA = "0x184531FD0")]
		public void Remove(LICOPOJIKBN BJOELKKLLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4531E70", Offset = "0x4530E70", VA = "0x184531E70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4531D90", Offset = "0x4530D90", VA = "0x184531D90")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x45321D0", Offset = "0x45311D0", VA = "0x1845321D0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4530EC0", Offset = "0x452FEC0", VA = "0x184530EC0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4530FC0", Offset = "0x452FFC0", VA = "0x184530FC0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
