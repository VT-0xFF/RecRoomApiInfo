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
				[Cpp2IlInjected.Address(RVA = "0x433AA20", Offset = "0x4339820", VA = "0x18433AA20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xEEF2D0", Offset = "0xEEE0D0", VA = "0x180EEF2D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x433A9E0", Offset = "0x43397E0", VA = "0x18433A9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x432BBD0", Offset = "0x432A9D0", VA = "0x18432BBD0")]
		public LODSettings CADHFLECLMM(IKGOJPAHHIL DPMBBGBAAPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x432BBE0", Offset = "0x432A9E0", VA = "0x18432BBE0")]
		public int PLAILILGNEC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x432BAD0", Offset = "0x432A8D0", VA = "0x18432BAD0")]
		public int ACILBABODAA(bool GPEHHONCJCP, Vector3 DLIHKMLEOPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x432BC00", Offset = "0x432AA00", VA = "0x18432BC00")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NJHBAJHHNLI
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
public interface IEEFANIPICD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDBOKONEBAI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LGBNNHALGFP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JDBBGCJBMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<PFIPNJNJMBM> LINBDBGIGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NJHBAJHHNLI EEEAGDKMDBB
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
	void UpdateClusterDistances(Vector3 HDNEDKDBLMB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(PMFIJNFKJMD DPMAGKBINEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFIPNJNJMBM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FLAPICHGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GLOMDPNKKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OGEOIDCMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OHFNFJAGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte BHLIIKHPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNHMPHNDKAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum DBAPDCIBBAD
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
	private sealed class HKLNHEDLCHO : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LNHMPHNDKAO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public HKLNHEDLCHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x43354D0", Offset = "0x43342D0", VA = "0x1843354D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4335590", Offset = "0x4334390", VA = "0x184335590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JNHABCLHMAG : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MKGJCNMEMBO <>2__current;

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
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public JNHABCLHMAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4336BF0", Offset = "0x43359F0", VA = "0x184336BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4336D40", Offset = "0x4335B40", VA = "0x184336D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GOKADIKHLEE : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LNHMPHNDKAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<MKGJCNMEMBO> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public GOKADIKHLEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4334A00", Offset = "0x4333800", VA = "0x184334A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4335480", Offset = "0x4334280", VA = "0x184335480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PPMBBBAIEOO : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public LNHMPHNDKAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public PPMBBBAIEOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x433B8D0", Offset = "0x433A6D0", VA = "0x18433B8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x433C7C0", Offset = "0x433B5C0", VA = "0x18433C7C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HEGDPOLBIAD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer DGMHJLPGIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter AHBEJHAOFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject GMKAGAMOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DJAFALNMNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public ELIKBMOHEPJ OECFMGECFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<PMFIJNFKJMD> NDPAPGODCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<PMFIJNFKJMD> CCCPDJFNNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<PMFIJNFKJMD> BGIHFPCIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int PENCOJJHJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private DBAPDCIBBAD MENANNJNAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<LGBNNHALGFP>[] DECOINLHEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<PFIPNJNJMBM>[] JAHLNKKMDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private ONFMLALHBOC GENKCCDCDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private ONFMLALHBOC HCJHLGFCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ONFMLALHBOC NJJHMBCJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int PJABJFHHCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int KANBMEKALMI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static LNHMPHNDKAO JGBKGNILAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GBHJBGHDEEB NGLDIFFBPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EMLHFDLLFJM AJPKNHDFEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour NOADOPBPDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material DGFKECGLBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<IEEFANIPICD> GJJIOJBHJBN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig EEBHEEFABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 FFOCEGIOAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x22A3CA0", Offset = "0x22A2AA0", VA = "0x1822A3CA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x22A3BC0", Offset = "0x22A29C0", VA = "0x1822A3BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private DBAPDCIBBAD JOBLJBMACFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57FDB0", Offset = "0x57EBB0", VA = "0x18057FDB0")]
		get
		{
			return default(DBAPDCIBBAD);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4339380", Offset = "0x4338180", VA = "0x184339380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LNHMPHNDKAO OECOELJNNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4338170", Offset = "0x4336F70", VA = "0x184338170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HGCFEALGCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x43388C0", Offset = "0x43376C0", VA = "0x1843388C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool JOADPLMEDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4339320", Offset = "0x4338120", VA = "0x184339320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> GMPDAGHONLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4337FA0", Offset = "0x4336DA0", VA = "0x184337FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x433A180", Offset = "0x4338F80", VA = "0x18433A180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NHGFJMDCNME
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4338FF0", Offset = "0x4337DF0", VA = "0x184338FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43381F0", Offset = "0x4336FF0", VA = "0x1843381F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x433A460", Offset = "0x4339260", VA = "0x18433A460")]
	public LNHMPHNDKAO(GBHJBGHDEEB NGLDIFFBPPJ, EMLHFDLLFJM AJPKNHDFEJI, ClusterLODConfig FBFCPCIJFMM, MonoBehaviour NOADOPBPDFI, Material DGFKECGLBLG, ClusterMeshRenderer DGMHJLPGIFE, MeshFilter AHBEJHAOFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4338EB0", Offset = "0x4337CB0", VA = "0x184338EB0")]
	private void GDIEEGHEKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43389C0", Offset = "0x43377C0", VA = "0x1843389C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4338400", Offset = "0x4337200", VA = "0x184338400")]
	public static void CABEMGCOIHD(Vector3 CDCECCHMOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x43397F0", Offset = "0x43385F0", VA = "0x1843397F0")]
	private void MGECCFLJIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x433A360", Offset = "0x4339160", VA = "0x18433A360")]
	private void POFHOCMBOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43398D0", Offset = "0x43386D0", VA = "0x1843398D0")]
	private void OFBDLLBBJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4338B70", Offset = "0x4337970", VA = "0x184338B70")]
	public void FJHMLNAIIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43387B0", Offset = "0x43375B0", VA = "0x1843387B0")]
	[IteratorStateMachine(typeof(HKLNHEDLCHO))]
	private IEnumerator<MKGJCNMEMBO> DADNFDLFLJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4338820", Offset = "0x4337620", VA = "0x184338820")]
	[IteratorStateMachine(typeof(JNHABCLHMAG))]
	private IEnumerator<MKGJCNMEMBO> DGOMOAJLOEI(Func<bool> OMHHJLHPANH, float GNBALKHJDDP, Func<string> DGCPIOALCOB, float PKCJGFCDFBP = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4338490", Offset = "0x4337290", VA = "0x184338490")]
	[IteratorStateMachine(typeof(GOKADIKHLEE))]
	private IEnumerator<MKGJCNMEMBO> CDCCKJGMIDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4339090", Offset = "0x4337E90", VA = "0x184339090")]
	public void IIPKGJJKHEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4338AF0", Offset = "0x43378F0", VA = "0x184338AF0")]
	public void FBBPCADLDEO(IEnumerable<LGBNNHALGFP> FEFDIPFENOE, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4338500", Offset = "0x4337300", VA = "0x184338500")]
	public void CHIGBJCNJIE(IEnumerable<LGBNNHALGFP> FEFDIPFENOE, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4339A10", Offset = "0x4338810", VA = "0x184339A10")]
	public List<ClusterMeshRenderer> OFPCKFEJALI(List<PMFIJNFKJMD> GGJMFCNMHAH, Transform FEAMLIHDEIF, NJHBAJHHNLI IBANBDKLALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x433A220", Offset = "0x4339020", VA = "0x18433A220")]
	public NJHBAJHHNLI PAKKONMAJOH(Vector3 IPAMEEEKNDN)
	{
		return default(NJHBAJHHNLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x433A260", Offset = "0x4339060", VA = "0x18433A260")]
	public void PBCJOKJNHIJ(IEEFANIPICD EGFKGIPJGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4338F40", Offset = "0x4337D40", VA = "0x184338F40")]
	public bool GNJPIIEFAIM(IEEFANIPICD EGFKGIPJGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x433A2C0", Offset = "0x43390C0", VA = "0x18433A2C0")]
	public void PHBBLMDLFMB(PMFIJNFKJMD HGGMMBMDIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43392A0", Offset = "0x43380A0", VA = "0x1843392A0")]
	public void IJLOLAEDGPH(PFIPNJNJMBM NEJEEGBOFLB, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4338940", Offset = "0x4337740", VA = "0x184338940")]
	public void DOMMHNAJGJM(PFIPNJNJMBM NEJEEGBOFLB, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4338040", Offset = "0x4336E40", VA = "0x184338040")]
	private void BGGCPNMPJAC(Vector3 HDNEDKDBLMB, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4338290", Offset = "0x4337090", VA = "0x184338290")]
	private void BOPEOBKCLDG(Vector3 HDNEDKDBLMB, NJHBAJHHNLI IBANBDKLALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4338E40", Offset = "0x4337C40", VA = "0x184338E40")]
	[IteratorStateMachine(typeof(PPMBBBAIEOO))]
	private IEnumerator<MKGJCNMEMBO> GDGBGHJENJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x43394B0", Offset = "0x43382B0", VA = "0x1843394B0")]
	private int JAEKCHFHALH(int HLONBDLBPCF, int EHOKIODGGBJ, List<PFIPNJNJMBM> GOJEMEOHHLF, byte DPMBBGBAAPB, ref int HGHLJKFCOHN, float LLPBJPCLFDG = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4339620", Offset = "0x4338420", VA = "0x184339620")]
	public void MDMFJHECCDC(PMFIJNFKJMD DPMAGKBINEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4339890", Offset = "0x4338690", VA = "0x184339890")]
	public bool NIANJMEGCBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5267F0", Offset = "0x5255F0", VA = "0x1805267F0")]
	public Material FFLPAJEFDDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x433A320", Offset = "0x4339120", VA = "0x18433A320")]
	public int PLAILILGNEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4338FA0", Offset = "0x4337DA0", VA = "0x184338FA0")]
	[CompilerGenerated]
	private bool HADMPKJLGEH()
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
		[Cpp2IlInjected.Address(RVA = "0x523A60", Offset = "0x522860", VA = "0x180523A60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct DCDGBNLOGKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> DJLMBCMIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> BEIHLCMALNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> BJHHBANNAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> LCFCCJBLNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> NCCLLHDCLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> IGDFKELDABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> DFPBJFAGNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 OHPKGOBPLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float JAHNMLCJKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> PHJFICOIPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> MMOAHGKBIIF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x432D690", Offset = "0x432C490", VA = "0x18432D690")]
	public DCDGBNLOGKM(BOFFGMEMCAF KNAMODKBDNN, NativeList<float3> DFPBJFAGNEH, NativeMultiHashMap<int, int> PHJFICOIPMG, NativeArray<int> MMOAHGKBIIF, Vector3 OHPKGOBPLHM, float JAHNMLCJKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x432D390", Offset = "0x432C190", VA = "0x18432D390")]
	private int GMAELCGNPHK(float3 HDNEDKDBLMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x432D3F0", Offset = "0x432C1F0", VA = "0x18432D3F0")]
	private int HFJNBAODHLF(int JOJIIFJCHGB, int IIIMPJEHMOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x432CFA0", Offset = "0x432BDA0", VA = "0x18432CFA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CLAPDHMPIKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> PHJFICOIPMG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> MMOAHGKBIIF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int DCIOAEGNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> KAJDHKDOILD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x432B930", Offset = "0x432A730", VA = "0x18432B930")]
	public void KDCHNNGPMDC(int CPPNBPNIIGE, Allocator DKMKADJBHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x432B880", Offset = "0x432A680", VA = "0x18432B880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public CLAPDHMPIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GCGDEKKFEJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> ECKJIBCFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> ELELBIDLFEE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4333860", Offset = "0x4332660", VA = "0x184333860")]
	public GCGDEKKFEJC(CLAPDHMPIKB CCIDCLNBGHI, BOFFGMEMCAF KNAMODKBDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43337D0", Offset = "0x43325D0", VA = "0x1843337D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct EIMMBCFDLDG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> HOBKEGPELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> CMFKILNEKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> PBBDJADJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> MGKFOKLAPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> KBPHHLJGEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> KAJDHKDOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> ECKJIBCFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> JIMDKNJMDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> IBPOFHLFLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> CLKLLLCCLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> PGJPMALEEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> GCCECMGAMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> MAABDDGBPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float DFMBHFAHKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float KOLJCGKFFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 HMLKJCJLLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float AICDCDHGCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float BMMCJEOPDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float HHOKKADJIKP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43307E0", Offset = "0x432F5E0", VA = "0x1843307E0")]
	public EIMMBCFDLDG(CLAPDHMPIKB OLAPPFJNHKM, BOFFGMEMCAF KNAMODKBDNN, BOFFGMEMCAF KPJDMBHJPLP, float BMMCJEOPDIB, float HHOKKADJIKP, Vector3 HMLKJCJLLDP, float AICDCDHGCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4330520", Offset = "0x432F320", VA = "0x184330520")]
	private float3 JCMCAMEPLCG(int JOJIIFJCHGB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x432F390", Offset = "0x432E190", VA = "0x18432F390")]
	private void EBPMBGDEKLM(int JOJIIFJCHGB, out float3 KAKOODPPDHJ, out float3 GEFHEAFDJBE, out float4 KKAKGPPHLGN, out float4 EKNCOEFBPPI, out float2 HBAHAEADKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x43301F0", Offset = "0x432EFF0", VA = "0x1843301F0")]
	private int IGKNFHLIADP(int NNFOLIKCPIG, int MKKNDKMJOJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x43305E0", Offset = "0x432F3E0", VA = "0x1843305E0")]
	private void OMGIPGOECLH(int NNFOLIKCPIG, int MKKNDKMJOJN, int NKIDJCAPGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x432F200", Offset = "0x432E000", VA = "0x18432F200")]
	private bool CHPGHHMMLLD(int NNFOLIKCPIG, int MKKNDKMJOJN, float FFICJCOBMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x432FED0", Offset = "0x432ECD0", VA = "0x18432FED0")]
	private bool FEJJNFMPLAJ(int NNFOLIKCPIG, int MKKNDKMJOJN, int NKIDJCAPGBJ, float FFICJCOBMNB, bool DPBIJBJAPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x432FF90", Offset = "0x432ED90", VA = "0x18432FF90")]
	private bool HPOJGADMCNM(int NNFOLIKCPIG, int MKKNDKMJOJN, int NKIDJCAPGBJ, float FFICJCOBMNB, bool DPBIJBJAPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x43305C0", Offset = "0x432F3C0", VA = "0x1843305C0")]
	private void LILLPFEBEON(int NNFOLIKCPIG, int MKKNDKMJOJN, int NKIDJCAPGBJ, out int BCEHDOJDCJB, out int CGNACJNLDFH, out int CCKMHGLDNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x432F570", Offset = "0x432E370", VA = "0x18432F570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBCBIPPEGGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class POJLDFNDMOC : IDisposable, PFIPNJNJMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds LKJAGHOKCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<PMFIJNFKJMD> GGJMFCNMHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 JMMPEEGLLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 LBHAGLBPNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int KCKKHPEHCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BOFFGMEMCAF ICPBEODNNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CLAPDHMPIKB OHLNABMLKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform FEAMLIHDEIF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FDNMBKHLHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x433B730", Offset = "0x433A530", VA = "0x18433B730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh DHGDLNLOOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh JGCIMAEMBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5262A0", VA = "0x1805274A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x54EB50", Offset = "0x54D950", VA = "0x18054EB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OGEOIDCMPEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x52A190", Offset = "0x528F90", VA = "0x18052A190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x52A530", Offset = "0x529330", VA = "0x18052A530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte BHLIIKHPFHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5EAAC0", Offset = "0x5E98C0", VA = "0x1805EAAC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x664250", Offset = "0x663050", VA = "0x180664250", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FLAPICHGIPB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x91C740", Offset = "0x91B540", VA = "0x18091C740", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94A4B0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int GLOMDPNKKFL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xF8BCB0", Offset = "0xF8AAB0", VA = "0x180F8BCB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x726880", Offset = "0x725680", VA = "0x180726880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float OHFNFJAGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x433AE10", Offset = "0x4339C10", VA = "0x18433AE10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x433AFA0", Offset = "0x4339DA0", VA = "0x18433AFA0")]
		public void GPDHNKNDKOA(IKGOJPAHHIL DPMBBGBAAPB, out int FOCEIMHIGBD, out int KMPAFAIBBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x433B1D0", Offset = "0x4339FD0", VA = "0x18433B1D0")]
		public void JMADOJPOLBB(IKGOJPAHHIL DPMBBGBAAPB, PFEOBINIJOH BADPADCJJBC, int FOGNFIMOBEP = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x433B410", Offset = "0x433A210", VA = "0x18433B410")]
		public void NELAAPOCDLJ(NativeList<HCECKOMJOEC> JDDBHKNDECF, Transform JLMPBMFBCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x433B770", Offset = "0x433A570", VA = "0x18433B770")]
		public void OABDLGGHNPE(Mesh KNAMODKBDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x433B370", Offset = "0x433A170", VA = "0x18433B370")]
		public void LPMCAPBCLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x433AE30", Offset = "0x4339C30", VA = "0x18433AE30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x433B810", Offset = "0x433A610", VA = "0x18433B810")]
		public POJLDFNDMOC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds LKJAGHOKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<POJLDFNDMOC> CFFKHIMOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public JFGHEGALFKD ADLGLOHDLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer IOFLGNGIBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int HABJJEAFIFF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh KFGFLJEMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526290", VA = "0x180527490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x54D510", Offset = "0x54C310", VA = "0x18054D510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DPKPFGHNJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x74C310", Offset = "0x74B110", VA = "0x18074C310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int JDBBGCJBMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x432EA00", Offset = "0x432D800", VA = "0x18432EA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x432E640", Offset = "0x432D440", VA = "0x18432E640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x432DD40", Offset = "0x432CB40", VA = "0x18432DD40")]
	public int APBNFGIEJGD(int HMNGCJBGDDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x432DD70", Offset = "0x432CB70", VA = "0x18432DD70")]
	public void BJAGKJLNEJL(GKJICBKKIMN GLMCGELLPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x432EA50", Offset = "0x432D850", VA = "0x18432EA50")]
	public void PKBFCHKOALO(Transform JLMPBMFBCBE, bool KANCPDMEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x432E490", Offset = "0x432D290", VA = "0x18432E490")]
	public bool DLMBPAMGEMN(bool CJCGNDOCLPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x432DF00", Offset = "0x432CD00", VA = "0x18432DF00")]
	public void BLCJKKPKCDB(Transform FEAMLIHDEIF, bool KANCPDMEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x432E7A0", Offset = "0x432D5A0", VA = "0x18432E7A0")]
	public bool MDMFJHECCDC(PMFIJNFKJMD DPMAGKBINEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x432F160", Offset = "0x432DF60", VA = "0x18432F160")]
	public EBCBIPPEGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ELIKBMOHEPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<EBCBIPPEGGH.POJLDFNDMOC> MHGPKJFDJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GLDDKNJINMI NKPILIGMFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<EBCBIPPEGGH.POJLDFNDMOC> JNIJFMDMKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int BJDNGDEPHPM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4330AB0", Offset = "0x432F8B0", VA = "0x184330AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4330A30", Offset = "0x432F830", VA = "0x184330A30")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4330920", Offset = "0x432F720", VA = "0x184330920")]
	public void ACLEHGEDHGC(EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK, Transform FEAMLIHDEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4330F90", Offset = "0x432FD90", VA = "0x184330F90")]
	public void MDMFJHECCDC(EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4330B80", Offset = "0x432F980", VA = "0x184330B80")]
	private EBCBIPPEGGH.POJLDFNDMOC IJLEHMIANEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4330F00", Offset = "0x432FD00", VA = "0x184330F00")]
	private bool MBCJOLHCEIP(EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x43309D0", Offset = "0x432F7D0", VA = "0x1843309D0")]
	private void BALLLBIDKHK(EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4331140", Offset = "0x432FF40", VA = "0x184331140")]
	public bool MKLEFAPHAKK(EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4330CB0", Offset = "0x432FAB0", VA = "0x184330CB0")]
	public bool LAILODAHAHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4330B20", Offset = "0x432F920", VA = "0x184330B20")]
	private EBCBIPPEGGH.POJLDFNDMOC HKEHFDFCILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4331180", Offset = "0x432FF80", VA = "0x184331180")]
	public ELIKBMOHEPJ()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x523A60", Offset = "0x522860", VA = "0x180523A60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GCBICMJKCOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int KGJPGIKAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int PEGEMIPCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float EODHALHCJCC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<EBCBIPPEGGH> LKLCPAHMIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4333780", Offset = "0x4332580", VA = "0x184333780")]
	public GCBICMJKCOD(int KGJPGIKAOCP, int PEGEMIPCIFE, float FFAAPNEHPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4333640", Offset = "0x4332440", VA = "0x184333640")]
	public void NJHMKGCMCAP(PICKEHHCPKG ABBKDLFHBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x43336E0", Offset = "0x43324E0", VA = "0x1843336E0")]
	private int NPGOIOLJGAD(GKJICBKKIMN KCNHGDMDEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4333410", Offset = "0x4332210", VA = "0x184333410")]
	private void NJHMKGCMCAP(GKJICBKKIMN KCNHGDMDEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4333230", Offset = "0x4332030", VA = "0x184333230")]
	private void MELDLEPBLKD(GKJICBKKIMN KCNHGDMDEHK, EBCBIPPEGGH HBGBPABBGFF)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LGBNNHALGFP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MMFLCKCHDMJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA6C0", VA = "0x1807BB8C0")]
			[DebuggerHidden]
			public MMFLCKCHDMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x433AA40", Offset = "0x4339840", VA = "0x18433AA40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x433ABD0", Offset = "0x43399D0", VA = "0x18433ABD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x433AB30", Offset = "0x4339930", VA = "0x18433AB30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x433AB30", Offset = "0x4339930", VA = "0x18433AB30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int JDBBGCJBMIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x432CF40", Offset = "0x432BD40", VA = "0x18432CF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<PFIPNJNJMBM> LINBDBGIGOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x432CF20", Offset = "0x432BD20", VA = "0x18432CF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> CFFKHIMOABF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public EBCBIPPEGGH KFGFLJEMKDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public NJHBAJHHNLI EEEAGDKMDBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x56D510", Offset = "0x56C310", VA = "0x18056D510", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(NJHBAJHHNLI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C6990", Offset = "0x6C5790", VA = "0x1806C6990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool BGPODLPGHEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x432CF30", Offset = "0x432BD30", VA = "0x18432CF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x432BC60", Offset = "0x432AA60", VA = "0x18432BC60")]
		public static ClusterMeshRenderer Create(EBCBIPPEGGH KNAMODKBDNN, ClusterMeshRenderer DGMHJLPGIFE, MeshFilter AHBEJHAOFMC, Transform FEAMLIHDEIF, NJHBAJHHNLI IBANBDKLALF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x432BD70", Offset = "0x432AB70", VA = "0x18432BD70", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x432C4D0", Offset = "0x432B2D0", VA = "0x18432C4D0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(PMFIJNFKJMD DPMAGKBINEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x432C2A0", Offset = "0x432B0A0", VA = "0x18432C2A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x432BFD0", Offset = "0x432ADD0", VA = "0x18432BFD0")]
		public void Init(EBCBIPPEGGH KNAMODKBDNN, MeshFilter AHBEJHAOFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x432BDD0", Offset = "0x432ABD0", VA = "0x18432BDD0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x432C600", Offset = "0x432B400", VA = "0x18432C600", Slot = "8")]
		public void UpdateClusterDistances(Vector3 HDNEDKDBLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x432C840", Offset = "0x432B640", VA = "0x18432C840", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x432BF60", Offset = "0x432AD60", VA = "0x18432BF60")]
		[IteratorStateMachine(typeof(MMFLCKCHDMJ))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x432C320", Offset = "0x432B120", VA = "0x18432C320")]
		public void SetupTagAndLayer(string PHJNFJDBPLL, int IBANBDKLALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x432C300", Offset = "0x432B100", VA = "0x18432C300")]
		public bool Remove(PMFIJNFKJMD DPMAGKBINEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x523A60", Offset = "0x522860", VA = "0x180523A60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JAKNNAAMAFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int GHGGGHPMFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int ECAGHKFKCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KMPAFAIBBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FOCEIMHIGBD;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4335970", Offset = "0x4334770", VA = "0x184335970")]
	public JAKNNAAMAFC(int ECAGHKFKCAE, int KMPAFAIBBCD, int GHGGGHPMFPK, int FOCEIMHIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JFGHEGALFKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> DJLMBCMIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> KAJDHKDOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> IGDFKELDABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<JAKNNAAMAFC> IBDABBLHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> DLPDGIBICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> FMPGAPJLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> NDPFAENJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle NIGBLMOEMBM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AOFPCPJBBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991570", VA = "0x180992770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x992790", Offset = "0x991590", VA = "0x180992790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4335E70", Offset = "0x4334C70", VA = "0x184335E70")]
	public void PNHOOELEAKC(BOFFGMEMCAF ONFEKDNLKGP, NativeList<JAKNNAAMAFC> IBDABBLHHPC, float APPFHANHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4335C20", Offset = "0x4334A20", VA = "0x184335C20")]
	public void PKINODJDLHM(Transform FEAMLIHDEIF, bool KANCPDMEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x43359C0", Offset = "0x43347C0", VA = "0x1843359C0")]
	public void DLMBPAMGEMN(EBCBIPPEGGH IOFLGNGIBDJ, bool CJCGNDOCLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4335B50", Offset = "0x4334950", VA = "0x184335B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4335990", Offset = "0x4334790", VA = "0x184335990")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public JFGHEGALFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct LCOJKEDKMMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> DJLMBCMIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> KAJDHKDOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<JAKNNAAMAFC> OHJGFNBIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> DLPDGIBICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 HMLKJCJLLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> FMPGAPJLLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> NDPFAENJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool KANCPDMEGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float ILGEIPMBNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float KGIGEDANDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float JICGFEDPPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> IGDFKELDABI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4337ED0", Offset = "0x4336CD0", VA = "0x184337ED0")]
	public LCOJKEDKMMJ(JFGHEGALFKD BBCAOHHEKNP, Vector3 HMLKJCJLLDP, bool KANCPDMEGHG, float ILGEIPMBNNA, float KGIGEDANDAI, float JICGFEDPPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4337A30", Offset = "0x4336830", VA = "0x184337A30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PMFIJNFKJMD : HCOPHBCLFIP
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds EJKIHMHOLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HCECKOMJOEC EOIGNGFNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GKJICBKKIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<PMFIJNFKJMD> GGJMFCNMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public GKJICBKKIMN MGDGFFLAOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public GKJICBKKIMN NPMLEAJMHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GKJICBKKIMN OLBOPKGLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int FOCEIMHIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds LKJAGHOKCEF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4333890", Offset = "0x4332690", VA = "0x184333890")]
	public GKJICBKKIMN(List<PMFIJNFKJMD> GGJMFCNMHAH, [Optional] GKJICBKKIMN MGDGFFLAOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PICKEHHCPKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<GKJICBKKIMN> EEGPEOBAICB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GKJICBKKIMN BLGMEJFMEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x433AD60", Offset = "0x4339B60", VA = "0x18433AD60")]
	public PICKEHHCPKG(GKJICBKKIMN FEAMLIHDEIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FGNJNEAKBGC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BGMELOJEGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int GPFLLNGOIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int CGMHDKKCGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int EOILEHFIBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int HHJKEPPFLMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GGAMCMOMHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int ODPJEEJHMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float CIOMACKFFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<PMFIJNFKJMD> GGJMFCNMHAH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JCKJMNAIFCF
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
	private BGMELOJEGAI ANMHLGANBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int OMEHLDDOBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int KGJPGIKAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int PEGEMIPCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float FFAAPNEHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float OKGFJLKEPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<GKJICBKKIMN> DPCLFDDMNJF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PICKEHHCPKG INKEOPBAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x43331D0", Offset = "0x4331FD0", VA = "0x1843331D0")]
	public FGNJNEAKBGC(int KGJPGIKAOCP, int PEGEMIPCIFE, float FFAAPNEHPCO, int OMEHLDDOBDC, float OKGFJLKEPAD = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4333010", Offset = "0x4331E10", VA = "0x184333010")]
	public void OABHKNGJFLC(List<PMFIJNFKJMD> GGJMFCNMHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4332FA0", Offset = "0x4331DA0", VA = "0x184332FA0")]
	public bool NDHCMBDEFPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4331600", Offset = "0x4330400", VA = "0x184331600")]
	private float BFCOBGHMHLL(Vector3 BBHFOEPLAPA, Vector3 NINBHHFOEAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4331710", Offset = "0x4330510", VA = "0x184331710")]
	private float BFCOBGHMHLL(Vector3 NEPCFDJCABD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x43317B0", Offset = "0x43305B0", VA = "0x1843317B0")]
	private bool EJHFCJHFPJP(GKJICBKKIMN FMAMHBDMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4332450", Offset = "0x4331250", VA = "0x184332450")]
	private GGAMCMOMHFD LALHDEOJGEI(List<PMFIJNFKJMD> KFKELILKDNI, JCKJMNAIFCF BJKCGNOBOAG)
	{
		return default(GGAMCMOMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x43320C0", Offset = "0x4330EC0", VA = "0x1843320C0")]
	private void HBMIJFGEPJF(List<PMFIJNFKJMD> GGJMFCNMHAH, Vector3[] MPHLKFDEIIK, Vector3[] DDBCCNKAGFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class FBDAEFJPKBL
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4331450", Offset = "0x4330250", VA = "0x184331450")]
	public static Bounds NHKMKIPAPDB(List<PMFIJNFKJMD> GGJMFCNMHAH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x43312C0", Offset = "0x43300C0", VA = "0x1843312C0")]
	public static int NGIFLNIPECE(List<PMFIJNFKJMD> GGJMFCNMHAH, IKGOJPAHHIL DPMBBGBAAPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GLDDKNJINMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private BOFFGMEMCAF PJGECLFDJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BOFFGMEMCAF KKNJJDDKEFE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static BOFFGMEMCAF FKHDOCFHBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private LFNDGDNNKBF PCKBLCGNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PFEOBINIJOH BADPADCJJBC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle NIGBLMOEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2A0", Offset = "0x5D90A0", VA = "0x1805DA2A0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xC0A380", Offset = "0xC09180", VA = "0x180C0A380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EBCBIPPEGGH.POJLDFNDMOC FMAMHBDMNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool OLPJGNLGHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8889A0", Offset = "0x8877A0", VA = "0x1808889A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x43339C0", Offset = "0x43327C0", VA = "0x1843339C0")]
	[NONPLMHAFKG(NKOBICDJAEL.ExitingPlayMode, 0)]
	private void GNJHIBDNBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4333FF0", Offset = "0x4332DF0", VA = "0x184333FF0")]
	public void PNHOOELEAKC(EBCBIPPEGGH.POJLDFNDMOC OHJGFNBIGBM, Transform HAPKAOPCKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4333A30", Offset = "0x4332830", VA = "0x184333A30")]
	public void MCIGHJFCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4333950", Offset = "0x4332750", VA = "0x184333950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4333910", Offset = "0x4332710", VA = "0x184333910")]
	public void CBNDPJOBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4334970", Offset = "0x4333770", VA = "0x184334970")]
	public GLDDKNJINMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FIPECNLENKF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LNHMPHNDKAO FGIFHOGDKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EMLHFDLLFJM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 EPAPGGJAEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GBHJBGHDEEB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LNOPCOABBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AACIEEBOGOO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action BBDGFFEFKBH;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KELGIOPGHNO
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KELGIOPGHNO BNIMJDJMDCI(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KELGIOPGHNO ABLPNDNKGGD(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KELGIOPGHNO ENGFHNGAPHH(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KELGIOPGHNO CGEPMMGOAFC(Action CHNALKMKMGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class INCBJIKHOPE : KELGIOPGHNO
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PGIEBCOHGHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public INCBJIKHOPE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public PGIEBCOHGHH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x433AC80", Offset = "0x4339A80", VA = "0x18433AC80")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x433ACD0", Offset = "0x4339AD0", VA = "0x18433ACD0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x433AD20", Offset = "0x4339B20", VA = "0x18433AD20")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> AGJOMBJNMBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action AGCPALIBBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action EPKAOJHKLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private HKKGJAIKCLK HFLAJMNPIMA;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action NHMAIAPCAMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526290", VA = "0x180527490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x54D510", Offset = "0x54C310", VA = "0x18054D510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action EPKOFJELLIA
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x88E9C0", Offset = "0x88D7C0", VA = "0x18088E9C0", Slot = "4")]
			public KELGIOPGHNO BNIMJDJMDCI(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA4B320", Offset = "0xA4A120", VA = "0x180A4B320", Slot = "5")]
			public KELGIOPGHNO ABLPNDNKGGD(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA6D220", Offset = "0xA6C020", VA = "0x180A6D220", Slot = "6")]
			public KELGIOPGHNO ENGFHNGAPHH(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA6D2A0", Offset = "0xA6C0A0", VA = "0x180A6D2A0", Slot = "7")]
			public KELGIOPGHNO CGEPMMGOAFC(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7166E0", Offset = "0x7154E0", VA = "0x1807166E0")]
			public INCBJIKHOPE(Func<JobHandle> ALIIMPAKJEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x43355E0", Offset = "0x43343E0", VA = "0x1843355E0")]
			public void BKPHBCPGJGO(Action MKBKIJDJMLA, Action LPIOECEPGCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4335810", Offset = "0x4334610", VA = "0x184335810")]
			public void MDMFJHECCDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BOPLNCLKKOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public KELGIOPGHNO jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public BOPLNCLKKOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1A7A9C0", Offset = "0x1A797C0", VA = "0x181A7A9C0")]
			internal bool <Remove>b__0(INCBJIKHOPE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class MOFAMICEELC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public INCBJIKHOPE newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public MOFAMICEELC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x433AC20", Offset = "0x4339A20", VA = "0x18433AC20")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<INCBJIKHOPE> ELJANEAMPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<INCBJIKHOPE> ELLFOCPKLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ONFMLALHBOC NDCEHNPKJLL;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4336D90", Offset = "0x4335B90", VA = "0x184336D90")]
		public KELGIOPGHNO Add(Func<JobHandle> ALIIMPAKJEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4337030", Offset = "0x4335E30", VA = "0x184337030")]
		public void Remove(KELGIOPGHNO NIGBLMOEMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4336EB0", Offset = "0x4335CB0", VA = "0x184336EB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x43371B0", Offset = "0x4335FB0", VA = "0x1843371B0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4337380", Offset = "0x4336180", VA = "0x184337380")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4336EA0", Offset = "0x4335CA0", VA = "0x184336EA0")]
		[CompilerGenerated]
		private void IEKDMJDPOPG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HKKGJAIKCLK
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKKGJAIKCLK BNIMJDJMDCI(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKKGJAIKCLK BKADAJIOFIM(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKKGJAIKCLK CGEPMMGOAFC(Action CHNALKMKMGL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class KDOBAEDFCDD : HKKGJAIKCLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle CBOBFHBIPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action AGCPALIBBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action OAONKEEPHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action EPKOFJELLIA;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool AJNHNOEMLGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x43379A0", Offset = "0x43367A0", VA = "0x1843379A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA4B320", Offset = "0xA4A120", VA = "0x180A4B320", Slot = "4")]
			public HKKGJAIKCLK BNIMJDJMDCI(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D220", Offset = "0xA6C020", VA = "0x180A6D220", Slot = "5")]
			public HKKGJAIKCLK BKADAJIOFIM(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D2A0", Offset = "0xA6C0A0", VA = "0x180A6D2A0", Slot = "6")]
			public HKKGJAIKCLK CGEPMMGOAFC(Action CHNALKMKMGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x83BC80", Offset = "0x83AA80", VA = "0x18083BC80")]
			public KDOBAEDFCDD(JobHandle KCANCKAGMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x43379B0", Offset = "0x43367B0", VA = "0x1843379B0")]
			public void ELGHEPGNNBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x43379F0", Offset = "0x43367F0", VA = "0x1843379F0")]
			public void MDMFJHECCDC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<KDOBAEDFCDD> GLICMICCCIP;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4337800", Offset = "0x4336600", VA = "0x184337800")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4337440", Offset = "0x4336240", VA = "0x184337440")]
		public HKKGJAIKCLK Add(JobHandle KCANCKAGMAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4337710", Offset = "0x4336510", VA = "0x184337710")]
		public void Remove(HKKGJAIKCLK NIGBLMOEMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x43375B0", Offset = "0x43363B0", VA = "0x1843375B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x43374D0", Offset = "0x43362D0", VA = "0x1843374D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4337910", Offset = "0x4336710", VA = "0x184337910")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x432DA80", Offset = "0x432C880", VA = "0x18432DA80")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x432D750", Offset = "0x432C550", VA = "0x18432D750")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
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
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
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
