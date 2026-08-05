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
				[Cpp2IlInjected.Address(RVA = "0x1DDB2A0", Offset = "0x1DD98A0", VA = "0x181DDB2A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x755B20", Offset = "0x754120", VA = "0x180755B20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1DDB260", Offset = "0x1DD9860", VA = "0x181DDB260")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DCE940", Offset = "0x1DCCF40", VA = "0x181DCE940")]
		public LODSettings FMDPCBNBEPA(AIFPIFCMLEF NDFHABBPPKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEA50", Offset = "0x1DCD050", VA = "0x181DCEA50")]
		public int MNNOKPALAJE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE950", Offset = "0x1DCCF50", VA = "0x181DCE950")]
		public int MAFBFGEHIKH(bool MPONIKPPAFD, Vector3 NCFMJDNAJDG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEA70", Offset = "0x1DCD070", VA = "0x181DCEA70")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CNNANFBAPJK
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
public interface NKEECDBBFHO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGJMGNBNOED();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IBLJOHEJKHG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KMDCOOBGKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<FNHDKLIIJDB> JCGAMIKALGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CNNANFBAPJK OCAAKIKKLGB
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
	void UpdateClusterDistances(Vector3 KIPNKGHJMCM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(KNNBPHMCEBH AJCPBFDANOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FNHDKLIIJDB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int BKCJHOKKIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int FNLNAGHIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BEOKMGEKBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EMDOCBPLCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte PHBOJCABLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GMMGFNBOIEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PBFHPFEMKMN
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
	private sealed class EBJJGIEBDCB : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GMMGFNBOIEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public EBJJGIEBDCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0F00", Offset = "0x1DCF500", VA = "0x181DD0F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1DD0FC0", Offset = "0x1DCF5C0", VA = "0x181DD0FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LEHKKJHGLGO : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MNMANPNLMCB <>2__current;

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
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public LEHKKJHGLGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9C00", Offset = "0x1DD8200", VA = "0x181DD9C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9D50", Offset = "0x1DD8350", VA = "0x181DD9D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CJBBPBMJELF : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GMMGFNBOIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<MNMANPNLMCB> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public CJBBPBMJELF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDE70", Offset = "0x1DCC470", VA = "0x181DCDE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE8F0", Offset = "0x1DCCEF0", VA = "0x181DCE8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FCJIDFJECLB : IEnumerator<MNMANPNLMCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MNMANPNLMCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GMMGFNBOIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MNMANPNLMCB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x513210", Offset = "0x511810", VA = "0x180513210")]
		[DebuggerHidden]
		public FCJIDFJECLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1020", Offset = "0x1DCF620", VA = "0x181DD1020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1F10", Offset = "0x1DD0510", VA = "0x181DD1F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int CONEMHFHDPO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer GCJBCMECGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter GMLLFEHJALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject DOPBAMNKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject PBIHJDIGEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public HDDECIHJHGF HOMFBAIAIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<KNNBPHMCEBH> MGECJNEIJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<KNNBPHMCEBH> KHCEAEJGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<KNNBPHMCEBH> JKCGGBOGKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int JOBCNFDCEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private PBFHPFEMKMN AOPJJMGGNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<IBLJOHEJKHG>[] KILOLAGEKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<FNHDKLIIJDB>[] JJDOKFGGNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NIKIHPIPFGJ GDAFBDLDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NIKIHPIPFGJ EDABINGKBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NIKIHPIPFGJ NABMBKAAOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int FCLCGJHANJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int JPKHAABFKNL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static GMMGFNBOIEJ PANFEPNMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GPMCKJNDPIG IMNKKELGNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BPJGAJGAFPB BOADHBMGCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour CNKJNPOGKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material KIBGPBCLCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NKEECDBBFHO> HJGPINALHAP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig KKILJHBDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 EINPCNGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3150", Offset = "0x1DD1750", VA = "0x181DD3150")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3140", Offset = "0x1DD1740", VA = "0x181DD3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private PBFHPFEMKMN NNFKCKHDCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x637A90", Offset = "0x636090", VA = "0x180637A90")]
		get
		{
			return default(PBFHPFEMKMN);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD31D0", Offset = "0x1DD17D0", VA = "0x181DD31D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static GMMGFNBOIEJ KIFJOHLMIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD42D0", Offset = "0x1DD28D0", VA = "0x181DD42D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool BELGAKELKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DD1FF0", Offset = "0x1DD05F0", VA = "0x181DD1FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KNJCENEFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4350", Offset = "0x1DD2950", VA = "0x181DD4350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> GCAOHIAOJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2A90", Offset = "0x1DD1090", VA = "0x181DD2A90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2D00", Offset = "0x1DD1300", VA = "0x181DD2D00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PGFBCPKNKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3C00", Offset = "0x1DD2200", VA = "0x181DD3C00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD33A0", Offset = "0x1DD19A0", VA = "0x181DD33A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DD44E0", Offset = "0x1DD2AE0", VA = "0x181DD44E0")]
	public GMMGFNBOIEJ(GPMCKJNDPIG IMNKKELGNLP, BPJGAJGAFPB BOADHBMGCED, ClusterLODConfig MJMNEGCDDMP, MonoBehaviour CNKJNPOGKPN, Material KIBGPBCLCLH, ClusterMeshRenderer GCJBCMECGCP, MeshFilter GMLLFEHJALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3D40", Offset = "0x1DD2340", VA = "0x181DD3D40")]
	private void MJAAIDPAHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2820", Offset = "0x1DD0E20", VA = "0x181DD2820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3070", Offset = "0x1DD1670", VA = "0x181DD3070")]
	public static void GMBPFAFGKEC(Vector3 EMHAHKLIOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3300", Offset = "0x1DD1900", VA = "0x181DD3300")]
	private void KKFIFCKCFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2720", Offset = "0x1DD0D20", VA = "0x181DD2720")]
	private void DHJCJGMEOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2950", Offset = "0x1DD0F50", VA = "0x181DD2950")]
	private void EMJJKMFHCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2DA0", Offset = "0x1DD13A0", VA = "0x181DD2DA0")]
	public void GCKEINGCBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD21E0", Offset = "0x1DD07E0", VA = "0x181DD21E0")]
	[IteratorStateMachine(typeof(EBJJGIEBDCB))]
	private IEnumerator<MNMANPNLMCB> AMLBKJOMJEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3CA0", Offset = "0x1DD22A0", VA = "0x181DD3CA0")]
	[IteratorStateMachine(typeof(LEHKKJHGLGO))]
	private IEnumerator<MNMANPNLMCB> LPBBLHHGAHC(Func<bool> LPMGCAFFAMA, float ADFNJODNGHB, Func<string> OEAGJDJDCLM, float ABNGHKMDKNH = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2630", Offset = "0x1DD0C30", VA = "0x181DD2630")]
	[IteratorStateMachine(typeof(CJBBPBMJELF))]
	private IEnumerator<MNMANPNLMCB> CKLIIFDOJGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD23C0", Offset = "0x1DD09C0", VA = "0x181DD23C0")]
	public void BPODKJMMLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD26A0", Offset = "0x1DD0CA0", VA = "0x181DD26A0")]
	public void CPMAKDJLAFL(IEnumerable<IBLJOHEJKHG> FJHKBLPOFNN, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3E90", Offset = "0x1DD2490", VA = "0x181DD3E90")]
	public void MPFPACMAOOF(IEnumerable<IBLJOHEJKHG> FJHKBLPOFNN, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3490", Offset = "0x1DD1A90", VA = "0x181DD3490")]
	public List<ClusterMeshRenderer> LHKKPKNADPH(List<KNNBPHMCEBH> HHOANJNOFOA, Transform HLALHACAGEL, CNNANFBAPJK IJIAFANNEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3100", Offset = "0x1DD1700", VA = "0x181DD3100")]
	public CNNANFBAPJK HFOEPELKKDO(Vector3 JMNLABIMGJB)
	{
		return default(CNNANFBAPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4270", Offset = "0x1DD2870", VA = "0x181DD4270")]
	public void NEIKJEAMFPM(NKEECDBBFHO MFADGJJJPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3170", Offset = "0x1DD1770", VA = "0x181DD3170")]
	public bool IMOBJFOMKLD(NKEECDBBFHO MFADGJJJPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DD25D0", Offset = "0x1DD0BD0", VA = "0x181DD25D0")]
	public void CKJDCHHLMDA(KNNBPHMCEBH NKNGLIBDEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DD43B0", Offset = "0x1DD29B0", VA = "0x181DD43B0")]
	public void OPHGKLFPGOO(FNHDKLIIJDB FEIDDDOGNAA, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3E10", Offset = "0x1DD2410", VA = "0x181DD3E10")]
	public void MPDGIDCCOGN(FNHDKLIIJDB FEIDDDOGNAA, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4140", Offset = "0x1DD2740", VA = "0x181DD4140")]
	private void NDIKJBEBIPG(Vector3 KIPNKGHJMCM, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2250", Offset = "0x1DD0850", VA = "0x181DD2250")]
	private void BGFIKAGHACO(Vector3 KIPNKGHJMCM, CNNANFBAPJK IJIAFANNEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4470", Offset = "0x1DD2A70", VA = "0x181DD4470")]
	[IteratorStateMachine(typeof(FCJIDFJECLB))]
	private IEnumerator<MNMANPNLMCB> PNPIFEPBFNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2070", Offset = "0x1DD0670", VA = "0x181DD2070")]
	private int AIBDFLEIJCN(int JGJLGOCHIGF, int HGIACHPNFPP, List<FNHDKLIIJDB> PCLNEAFNNHB, byte NDFHABBPPKD, ref int JOCJHLLPNCJ, float AGIENAIIKCG = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2B30", Offset = "0x1DD1130", VA = "0x181DD2B30")]
	public void FJHOKKOHPIB(KNNBPHMCEBH AJCPBFDANOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4430", Offset = "0x1DD2A30", VA = "0x181DD4430")]
	public bool PHNAMCBOBLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDD0", Offset = "0x5FE3D0", VA = "0x1805FFDD0")]
	public Material HAOKEENMMGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3DD0", Offset = "0x1DD23D0", VA = "0x181DD3DD0")]
	public int MNNOKPALAJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3440", Offset = "0x1DD1A40", VA = "0x181DD3440")]
	[CompilerGenerated]
	private bool LFMACGDPCMA()
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
		[Cpp2IlInjected.Address(RVA = "0x517B90", Offset = "0x516190", VA = "0x180517B90")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct BCIDBNOKOLC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> HDOADPDJAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> NDPJPNAACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> AMKMPKKODHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> EDKCEMMJJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> GMDPMIOOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> CKEGBFIOEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> IAPANBOMHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 LAFIGPGIOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float NPHPCJCJHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> ACHGBOJOLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> CPOHCAKHIHF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD940", Offset = "0x1DCBF40", VA = "0x181DCD940")]
	public BCIDBNOKOLC(ALPJLPHKHND PEINLHOIDLL, NativeList<float3> IAPANBOMHHE, NativeMultiHashMap<int, int> ACHGBOJOLIE, NativeArray<int> CPOHCAKHIHF, Vector3 LAFIGPGIOFH, float NPHPCJCJHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD250", Offset = "0x1DCB850", VA = "0x181DCD250")]
	private int ENMENDLNBML(float3 KIPNKGHJMCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD6A0", Offset = "0x1DCBCA0", VA = "0x181DCD6A0")]
	private int JFNOAMLMLAL(int JGJNFKKDEKE, int DOICKNFOJNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD2B0", Offset = "0x1DCB8B0", VA = "0x181DCD2B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OLDBBDNDBNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> ACHGBOJOLIE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> CPOHCAKHIHF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int FBAFMNFNHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> HDMPBFLDJIB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCEB0", Offset = "0x1DDB4B0", VA = "0x181DDCEB0")]
	public void GCGGBKOGFKJ(int MJBFAPCDONL, Allocator NLMMKCIOOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCE00", Offset = "0x1DDB400", VA = "0x181DDCE00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public OLDBBDNDBNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct PADOOBEPMKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> AKALDGKCNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> PGCIFKJLDEN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD0E0", Offset = "0x1DDB6E0", VA = "0x181DDD0E0")]
	public PADOOBEPMKM(OLDBBDNDBNG NGEPFFLEFCK, ALPJLPHKHND PEINLHOIDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD050", Offset = "0x1DDB650", VA = "0x181DDD050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct MNDNCNOIGNA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> CLBIPKLKBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> IBEKPBMHPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> NKMCLDCLGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> BADCEAPONNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> KOKMPICHANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> HDMPBFLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> AKALDGKCNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> BCCPOOFGBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> GLNKBGMCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> MIPEEFGHPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> EBINJDIBAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> GHEJAMNDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> CKECKNDDGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float LHHCFLPCDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float KBPGGMHOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 CJPEBCALHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float MJEHBIGEBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float GPKJDODDGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float GOCINGFGKAL;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC980", Offset = "0x1DDAF80", VA = "0x181DDC980")]
	public MNDNCNOIGNA(OLDBBDNDBNG GJCGKNDBCGH, ALPJLPHKHND PEINLHOIDLL, ALPJLPHKHND MIKOBOAKAJI, float GPKJDODDGKN, float GOCINGFGKAL, Vector3 CJPEBCALHNB, float MJEHBIGEBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBEE0", Offset = "0x1DDA4E0", VA = "0x181DDBEE0")]
	private float3 GAAKLBFBMHF(int JGJNFKKDEKE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB3A0", Offset = "0x1DD99A0", VA = "0x181DDB3A0")]
	private void EOLGICFPDIL(int JGJNFKKDEKE, out float3 PADFFGEPOHP, out float3 KOOIGPBBDNP, out float4 KCLMBAKGJGC, out float4 LJHIGKIJPFC, out float2 BFGGBPDOMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC110", Offset = "0x1DDA710", VA = "0x181DDC110")]
	private int HBFCKNMMGIA(int BJGLMHACKHF, int DKMJGMPGEEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC500", Offset = "0x1DDAB00", VA = "0x181DDC500")]
	private void JLCIFKKAKBK(int BJGLMHACKHF, int DKMJGMPGEEE, int DGBFCGOJPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBF80", Offset = "0x1DDA580", VA = "0x181DDBF80")]
	private bool GHJCLFOEJHB(int BJGLMHACKHF, int DKMJGMPGEEE, float PONILFEJMOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC440", Offset = "0x1DDAA40", VA = "0x181DDC440")]
	private bool INNJPPHCMIA(int BJGLMHACKHF, int DKMJGMPGEEE, int DGBFCGOJPED, float PONILFEJMOG, bool NBHMAGGKEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC700", Offset = "0x1DDAD00", VA = "0x181DDC700")]
	private bool NAFCAEGFAKK(int BJGLMHACKHF, int DKMJGMPGEEE, int DGBFCGOJPED, float PONILFEJMOG, bool NBHMAGGKEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC960", Offset = "0x1DDAF60", VA = "0x181DDC960")]
	private void NNCGLELPOON(int BJGLMHACKHF, int DKMJGMPGEEE, int DGBFCGOJPED, out int KBHNDIKJOIB, out int FKELLGGPFCF, out int MFNNHDLIAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB580", Offset = "0x1DD9B80", VA = "0x181DDB580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LEOJHIJCFAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ADNOMHIKFJP : IDisposable, FNHDKLIIJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds OEAENKHFGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<KNNBPHMCEBH> HHOANJNOFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 EFLJALOCBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 NHJFKNIINLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int NPEIAKNLDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public ALPJLPHKHND PHPNKABFOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public OLDBBDNDBNG OFGOLPPBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform HLALHACAGEL;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MMPPCOAPHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1DCCAC0", Offset = "0x1DCB0C0", VA = "0x181DCCAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh DOJJDCIIAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh FEFINOMFLJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5718F0", Offset = "0x56FEF0", VA = "0x1805718F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x572850", Offset = "0x570E50", VA = "0x180572850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BEOKMGEKBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x603680", Offset = "0x601C80", VA = "0x180603680", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x603A10", Offset = "0x602010", VA = "0x180603A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte PHBOJCABLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6E3A30", Offset = "0x6E2030", VA = "0x1806E3A30")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x81D240", Offset = "0x81B840", VA = "0x18081D240", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BKCJHOKKIEA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6CB0", Offset = "0x8B52B0", VA = "0x1808B6CB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B6CC0", Offset = "0x8B52C0", VA = "0x1808B6CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int FNLNAGHIBDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAB98A0", Offset = "0xAB7EA0", VA = "0x180AB98A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8EAF20", Offset = "0x8E9520", VA = "0x1808EAF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float EMDOCBPLCDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1DCC930", Offset = "0x1DCAF30", VA = "0x181DCC930", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCCE20", Offset = "0x1DCB420", VA = "0x181DCCE20")]
		public void KAIPAFLAKCA(AIFPIFCMLEF NDFHABBPPKD, out int GPOCMILCLKE, out int MFILNFOCIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC790", Offset = "0x1DCAD90", VA = "0x181DCC790")]
		public void BBDJALPNJHJ(AIFPIFCMLEF NDFHABBPPKD, BBOMJFBCLGN PICIJPFPNPJ, int GOELMEEBFDG = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1DCCB00", Offset = "0x1DCB100", VA = "0x181DCCB00")]
		public void ICIOIPKNNHA(NativeList<FCCFFKGIEDF> KHMLNOENPNP, Transform DLMECIOPMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD050", Offset = "0x1DCB650", VA = "0x181DCD050")]
		public void KHONHAFNAKL(Mesh PEINLHOIDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD0F0", Offset = "0x1DCB6F0", VA = "0x181DCD0F0")]
		public void NIPENBBOIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC950", Offset = "0x1DCAF50", VA = "0x181DCC950", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DCD190", Offset = "0x1DCB790", VA = "0x181DCD190")]
		public ADNOMHIKFJP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds OEAENKHFGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<ADNOMHIKFJP> OEOENHPLGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HFGNAGGKBIH MKKHGIBHBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer NDFGNGKJCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int EKHGDMFEEFK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh JBBAKKGLLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x535290", Offset = "0x533890", VA = "0x180535290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x55A680", Offset = "0x558C80", VA = "0x18055A680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool KIBGJAAHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7566E0", Offset = "0x754CE0", VA = "0x1807566E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x757E10", Offset = "0x756410", VA = "0x180757E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int KMDCOOBGKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA330", Offset = "0x1DD8930", VA = "0x181DDA330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA380", Offset = "0x1DD8980", VA = "0x181DDA380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB190", Offset = "0x1DD9790", VA = "0x181DDB190")]
	public int PDAFKDIDDEG(int CAPICKKNDLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB000", Offset = "0x1DD9600", VA = "0x181DDB000")]
	public void MEBPKOJMGKN(CAEDPCLJKNH BKFFLPNIADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA8F0", Offset = "0x1DD8EF0", VA = "0x181DDA8F0")]
	public void GLJDNNGAKMH(Transform DLMECIOPMAP, bool PJCNDCFJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA4E0", Offset = "0x1DD8AE0", VA = "0x181DDA4E0")]
	public bool EJJNDONOKEE(bool NCDGBCDECHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9DA0", Offset = "0x1DD83A0", VA = "0x181DD9DA0")]
	public void CDPKJBPGFJA(Transform HLALHACAGEL, bool PJCNDCFJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA690", Offset = "0x1DD8C90", VA = "0x181DDA690")]
	public bool FJHOKKOHPIB(KNNBPHMCEBH AJCPBFDANOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB1C0", Offset = "0x1DD97C0", VA = "0x181DDB1C0")]
	public LEOJHIJCFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDDECIHJHGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<LEOJHIJCFAL.ADNOMHIKFJP> EDLDJBMOGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private DIBELNIOPAI ANCLEDADOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<LEOJHIJCFAL.ADNOMHIKFJP> JDGNGFFKCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int PJGFGJHIKCK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4BF0", Offset = "0x1DD31F0", VA = "0x181DD4BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4EA0", Offset = "0x1DD34A0", VA = "0x181DD4EA0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5210", Offset = "0x1DD3810", VA = "0x181DD5210")]
	public void MEEOIBACLCF(LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE, Transform HLALHACAGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4CF0", Offset = "0x1DD32F0", VA = "0x181DD4CF0")]
	public void FJHOKKOHPIB(LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4A60", Offset = "0x1DD3060", VA = "0x181DD4A60")]
	private LEOJHIJCFAL.ADNOMHIKFJP AEMCGMILGOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4C60", Offset = "0x1DD3260", VA = "0x181DD4C60")]
	private bool EODHMICOHLO(LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4B90", Offset = "0x1DD3190", VA = "0x181DD4B90")]
	private void ANHNEJOIKDA(LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4F20", Offset = "0x1DD3520", VA = "0x181DD4F20")]
	public bool HGJALEFPMKF(LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4FC0", Offset = "0x1DD35C0", VA = "0x181DD4FC0")]
	public bool LHCLGJALOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD4F60", Offset = "0x1DD3560", VA = "0x181DD4F60")]
	private LEOJHIJCFAL.ADNOMHIKFJP HGLNFBIIGJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD52C0", Offset = "0x1DD38C0", VA = "0x181DD52C0")]
	public HDDECIHJHGF()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x517B90", Offset = "0x516190", VA = "0x180517B90")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PLMIMJFNABM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HEFPGPMJADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int AEGLJAEIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float NKKHCEEOGMM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<LEOJHIJCFAL> CDNECJAAGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD710", Offset = "0x1DDBD10", VA = "0x181DDD710")]
	public PLMIMJFNABM(int HEFPGPMJADK, int AEGLJAEIMED, float BMMMBHCADGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD3A0", Offset = "0x1DDB9A0", VA = "0x181DDD3A0")]
	public void CBJGKLJEKPN(PEPKLKOCNMN EHMDNLCBGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD670", Offset = "0x1DDBC70", VA = "0x181DDD670")]
	private int EINMIPFFHIC(CAEDPCLJKNH LJEFIDNOOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD440", Offset = "0x1DDBA40", VA = "0x181DDD440")]
	private void CBJGKLJEKPN(CAEDPCLJKNH LJEFIDNOOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD1C0", Offset = "0x1DDB7C0", VA = "0x181DDD1C0")]
	private void ACKGOFOJJAG(CAEDPCLJKNH LJEFIDNOOMO, LEOJHIJCFAL HOFFEPNGPOJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, IBLJOHEJKHG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KGBKNNHKFGD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x792C00", Offset = "0x791200", VA = "0x180792C00")]
			[DebuggerHidden]
			public KGBKNNHKFGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9410", Offset = "0x1DD7A10", VA = "0x181DD9410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DD95A0", Offset = "0x1DD7BA0", VA = "0x181DD95A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9500", Offset = "0x1DD7B00", VA = "0x181DD9500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1DD9500", Offset = "0x1DD7B00", VA = "0x181DD9500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int KMDCOOBGKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DCFDB0", Offset = "0x1DCE3B0", VA = "0x181DCFDB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<FNHDKLIIJDB> JCGAMIKALGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1DCFD90", Offset = "0x1DCE390", VA = "0x181DCFD90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> OEOENHPLGIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5131A0", Offset = "0x5117A0", VA = "0x1805131A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5898D0", Offset = "0x587ED0", VA = "0x1805898D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LEOJHIJCFAL JBBAKKGLLMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public CNNANFBAPJK OCAAKIKKLGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x625220", Offset = "0x623820", VA = "0x180625220", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(CNNANFBAPJK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6B82A0", Offset = "0x6B68A0", VA = "0x1806B82A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool GAEFEANNEEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1DCFDA0", Offset = "0x1DCE3A0", VA = "0x181DCFDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEAD0", Offset = "0x1DCD0D0", VA = "0x181DCEAD0")]
		public static ClusterMeshRenderer Create(LEOJHIJCFAL PEINLHOIDLL, ClusterMeshRenderer GCJBCMECGCP, MeshFilter GMLLFEHJALI, Transform HLALHACAGEL, CNNANFBAPJK IJIAFANNEME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEBE0", Offset = "0x1DCD1E0", VA = "0x181DCEBE0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF340", Offset = "0x1DCD940", VA = "0x181DCF340", Slot = "10")]
		public bool TryRemoveClusterLODComponent(KNNBPHMCEBH AJCPBFDANOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF110", Offset = "0x1DCD710", VA = "0x181DCF110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEE40", Offset = "0x1DCD440", VA = "0x181DCEE40")]
		public void Init(LEOJHIJCFAL PEINLHOIDLL, MeshFilter GMLLFEHJALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEC40", Offset = "0x1DCD240", VA = "0x181DCEC40")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF470", Offset = "0x1DCDA70", VA = "0x181DCF470", Slot = "8")]
		public void UpdateClusterDistances(Vector3 KIPNKGHJMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF6B0", Offset = "0x1DCDCB0", VA = "0x181DCF6B0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEDD0", Offset = "0x1DCD3D0", VA = "0x181DCEDD0")]
		[IteratorStateMachine(typeof(KGBKNNHKFGD))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF190", Offset = "0x1DCD790", VA = "0x181DCF190")]
		public void SetupTagAndLayer(string KIOCDDFPCNE, int IJIAFANNEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1DCF170", Offset = "0x1DCD770", VA = "0x181DCF170")]
		public bool Remove(KNNBPHMCEBH AJCPBFDANOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x517B90", Offset = "0x516190", VA = "0x180517B90")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LDABKNONKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int HCLHJLCIPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GKFKJKKLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MFILNFOCIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int GPOCMILCLKE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9BE0", Offset = "0x1DD81E0", VA = "0x181DD9BE0")]
	public LDABKNONKGK(int GKFKJKKLIEB, int MFILNFOCIIO, int HCLHJLCIPPM, int GPOCMILCLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HFGNAGGKBIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> HDOADPDJAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> HDMPBFLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> CKEGBFIOEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<LDABKNONKGK> JGPODKIOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> IGHLGELBGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> DNECBBLDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> HOJIMIODFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle OGAKLFCKNOO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JEKDHLPJBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x536FA0", Offset = "0x5355A0", VA = "0x180536FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x536FE0", Offset = "0x5355E0", VA = "0x180536FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5660", Offset = "0x1DD3C60", VA = "0x181DD5660")]
	public void GKBLFPDLMNH(ALPJLPHKHND GDIPCGKNCOB, NativeList<LDABKNONKGK> JGPODKIOIHM, float DIOMGDDLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6410", Offset = "0x1DD4A10", VA = "0x181DD6410")]
	public void MMKKAEEPOPO(Transform HLALHACAGEL, bool PJCNDCFJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DD54D0", Offset = "0x1DD3AD0", VA = "0x181DD54D0")]
	public void EJJNDONOKEE(LEOJHIJCFAL NDFGNGKJCPJ, bool NCDGBCDECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5400", Offset = "0x1DD3A00", VA = "0x181DD5400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DD63E0", Offset = "0x1DD49E0", VA = "0x181DD63E0")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public HFGNAGGKBIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct HIPEOFMONEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> HDOADPDJAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> HDMPBFLDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<LDABKNONKGK> COAHKLMLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> IGHLGELBGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 CJPEBCALHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> DNECBBLDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> HOJIMIODFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool PJCNDCFJHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float IIIIMGLANHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float KONMDHJIANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float FIHGNOOMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> CKEGBFIOEFB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6B00", Offset = "0x1DD5100", VA = "0x181DD6B00")]
	public HIPEOFMONEH(HFGNAGGKBIH EDOEBNBILLH, Vector3 CJPEBCALHNB, bool PJCNDCFJHJC, float IIIIMGLANHI, float KONMDHJIANF, float FIHGNOOMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6660", Offset = "0x1DD4C60", VA = "0x181DD6660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KNNBPHMCEBH : DHBPPONOPHL
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds KBCCFICONPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FCCFFKGIEDF GEEOOIOEJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CAEDPCLJKNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<KNNBPHMCEBH> HHOANJNOFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public CAEDPCLJKNH EPJKFCLNEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public CAEDPCLJKNH FCJLBNLKCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public CAEDPCLJKNH HNKBALFDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int GPOCMILCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds OEAENKHFGHG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDD90", Offset = "0x1DCC390", VA = "0x181DCDD90")]
	public CAEDPCLJKNH(List<KNNBPHMCEBH> HHOANJNOFOA, [Optional] CAEDPCLJKNH EPJKFCLNEED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PEPKLKOCNMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<CAEDPCLJKNH> JABIOPJLOHP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CAEDPCLJKNH KDOCDFLBPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5734D0", Offset = "0x571AD0", VA = "0x1805734D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x513000", Offset = "0x511600", VA = "0x180513000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD110", Offset = "0x1DDB710", VA = "0x181DDD110")]
	public PEPKLKOCNMN(CAEDPCLJKNH HLALHACAGEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KDCMKCOGFNP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct CIFHOCANDID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int NCKNKHFJLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int CPLNEPDPGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int KOOGHILBGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int BANIHCIDLDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JHIHMBEMANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int KBDIPHKJBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float JGKDDOMJJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<KNNBPHMCEBH> HHOANJNOFOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum FJBMHIEMNKP
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
	private CIFHOCANDID CBFKHLAOCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int EJJCLNNPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int HEFPGPMJADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int AEGLJAEIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float BMMMBHCADGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float CAJPKKMANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<CAEDPCLJKNH> MEDBPLDCCPH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PEPKLKOCNMN EHAAIEPFFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DD93B0", Offset = "0x1DD79B0", VA = "0x181DD93B0")]
	public KDCMKCOGFNP(int HEFPGPMJADK, int AEGLJAEIMED, float BMMMBHCADGC, int EJJCLNNPHIO, float CAJPKKMANMG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DD91F0", Offset = "0x1DD77F0", VA = "0x181DD91F0")]
	public void PECBGNGEJEH(List<KNNBPHMCEBH> HHOANJNOFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9180", Offset = "0x1DD7780", VA = "0x181DD9180")]
	public bool OAFMPAHIEHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DD80F0", Offset = "0x1DD66F0", VA = "0x181DD80F0")]
	private float EADBLLCMMFG(Vector3 GMDMMMLINFB, Vector3 FNEMCMIGGIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8200", Offset = "0x1DD6800", VA = "0x181DD8200")]
	private float EADBLLCMMFG(Vector3 MMFNMECEIOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1DD77E0", Offset = "0x1DD5DE0", VA = "0x181DD77E0")]
	private bool DLKDFBDJHAP(CAEDPCLJKNH GGCCONOCMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8630", Offset = "0x1DD6C30", VA = "0x181DD8630")]
	private JHIHMBEMANG MEOMODBCNED(List<KNNBPHMCEBH> EABDEAPBHHA, FJBMHIEMNKP ENJOOMGIOHP)
	{
		return default(JHIHMBEMANG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DD82A0", Offset = "0x1DD68A0", VA = "0x181DD82A0")]
	private void KKGLCOPMPFJ(List<KNNBPHMCEBH> HHOANJNOFOA, Vector3[] DAKMCPNJGGE, Vector3[] JHOEPDNCNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OIAHJECIHBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCC50", Offset = "0x1DDB250", VA = "0x181DDCC50")]
	public static Bounds OKMLJDIFFFE(List<KNNBPHMCEBH> HHOANJNOFOA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCAC0", Offset = "0x1DDB0C0", VA = "0x181DDCAC0")]
	public static int NBADLNBNIHF(List<KNNBPHMCEBH> HHOANJNOFOA, AIFPIFCMLEF NDFHABBPPKD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DIBELNIOPAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private ALPJLPHKHND DPDKKNHHMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ALPJLPHKHND JDDBKLFJEFN;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static ALPJLPHKHND EKNNGEJPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private OKLOJLCOEFN PCNHECMLNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private BBOMJFBCLGN PICIJPFPNPJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle OGAKLFCKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x64D6A0", Offset = "0x64BCA0", VA = "0x18064D6A0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAB58F0", Offset = "0xAB3EF0", VA = "0x180AB58F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LEOJHIJCFAL.ADNOMHIKFJP GGCCONOCMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PCKJAJJMOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD620", Offset = "0x5CBC20", VA = "0x1805CD620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0840", Offset = "0x1DCEE40", VA = "0x181DD0840")]
	[OOPBCBLKHLO(BLHLEKHDLFO.ExitingPlayMode, 0)]
	private void KJJMPGOCAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFE80", Offset = "0x1DCE480", VA = "0x181DCFE80")]
	public void GKBLFPDLMNH(LEOJHIJCFAL.ADNOMHIKFJP COAHKLMLNGI, Transform PBJLGECDKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DD08B0", Offset = "0x1DCEEB0", VA = "0x181DD08B0")]
	public void MNCCHHLACBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFE10", Offset = "0x1DCE410", VA = "0x181DCFE10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0800", Offset = "0x1DCEE00", VA = "0x181DD0800")]
	public void GMBCIADOMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0E70", Offset = "0x1DCF470", VA = "0x181DD0E70")]
	public DIBELNIOPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AMOFKOEHKIP
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GMMGFNBOIEJ ILPDPJEHKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BPJGAJGAFPB
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 ANNBLDOPOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GPMCKJNDPIG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool NDKDJGONDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ADEDIOKHBHM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action CAFHNAHLIAL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BCFFFEFAFHK
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCFFFEFAFHK KHOFOONJNJL(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BCFFFEFAFHK BBCCJGLIDFD(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BCFFFEFAFHK HDJNILHHPIN(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCFFFEFAFHK KGMMDGIJIDL(Action EMFPEPGCJKF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class BMIFMAMMNCI : BCFFFEFAFHK
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class MEHNCCPIGFM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public BMIFMAMMNCI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
				public MEHNCCPIGFM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x1DDB2C0", Offset = "0x1DD98C0", VA = "0x181DDB2C0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x1DDB310", Offset = "0x1DD9910", VA = "0x181DDB310")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x1DDB360", Offset = "0x1DD9960", VA = "0x181DDB360")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> KKCNFIEDBDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action HEJFGHOOEDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action GIBDJCGJEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private AGBEJKCGLOO ADBEPKKOFEI;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action ALNCJOLDHNP
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x535290", Offset = "0x533890", VA = "0x180535290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x55A680", Offset = "0x558C80", VA = "0x18055A680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action IOEMAFNAIDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x534830", Offset = "0x532E30", VA = "0x180534830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x534510", Offset = "0x532B10", VA = "0x180534510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA3E540", Offset = "0xA3CB40", VA = "0x180A3E540", Slot = "4")]
			public BCFFFEFAFHK KHOFOONJNJL(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xC75070", Offset = "0xC73670", VA = "0x180C75070", Slot = "5")]
			public BCFFFEFAFHK BBCCJGLIDFD(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCACD00", Offset = "0xCAB300", VA = "0x180CACD00", Slot = "6")]
			public BCFFFEFAFHK HDJNILHHPIN(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xCACD80", Offset = "0xCAB380", VA = "0x180CACD80", Slot = "7")]
			public BCFFFEFAFHK KGMMDGIJIDL(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x57A1E0", Offset = "0x5787E0", VA = "0x18057A1E0")]
			public BMIFMAMMNCI(Func<JobHandle> DOILGJOLGLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDB60", Offset = "0x1DCC160", VA = "0x181DCDB60")]
			public void LMMFKACGHOJ(Action OFEJAPHMEPN, Action BOLICLNMOME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDA00", Offset = "0x1DCC000", VA = "0x181DCDA00")]
			public void FJHOKKOHPIB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EJCHHEHOMCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public BCFFFEFAFHK jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public EJCHHEHOMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1DD1010", Offset = "0x1DCF610", VA = "0x181DD1010")]
			internal bool <Remove>b__0(BMIFMAMMNCI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CHIDIBOMGCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public BMIFMAMMNCI newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public CHIDIBOMGCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1DCDE10", Offset = "0x1DCC410", VA = "0x181DCDE10")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<BMIFMAMMNCI> JDPGFMEOOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<BMIFMAMMNCI> NHOALNJACCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private NIKIHPIPFGJ IGGAFJGKCNF;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6BD0", Offset = "0x1DD51D0", VA = "0x181DD6BD0")]
		public BCFFFEFAFHK Add(Func<JobHandle> DOILGJOLGLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6E70", Offset = "0x1DD5470", VA = "0x181DD6E70")]
		public void Remove(BCFFFEFAFHK OGAKLFCKNOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6CF0", Offset = "0x1DD52F0", VA = "0x181DD6CF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6FF0", Offset = "0x1DD55F0", VA = "0x181DD6FF0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DD71C0", Offset = "0x1DD57C0", VA = "0x181DD71C0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6CE0", Offset = "0x1DD52E0", VA = "0x181DD6CE0")]
		[CompilerGenerated]
		private void IPMJKLCJKMK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AGBEJKCGLOO
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AGBEJKCGLOO KHOFOONJNJL(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGBEJKCGLOO IDNMEJCGEAJ(Action EMFPEPGCJKF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGBEJKCGLOO KGMMDGIJIDL(Action EMFPEPGCJKF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class FDINAFHMPCK : AGBEJKCGLOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle HPAFJHAMBFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action HEJFGHOOEDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action PCGAAHJNLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action IOEMAFNAIDI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool KEIHJMFNJKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x1DD1FE0", Offset = "0x1DD05E0", VA = "0x181DD1FE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC75070", Offset = "0xC73670", VA = "0x180C75070", Slot = "4")]
			public AGBEJKCGLOO KHOFOONJNJL(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xCACD00", Offset = "0xCAB300", VA = "0x180CACD00", Slot = "5")]
			public AGBEJKCGLOO IDNMEJCGEAJ(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCACD80", Offset = "0xCAB380", VA = "0x180CACD80", Slot = "6")]
			public AGBEJKCGLOO KGMMDGIJIDL(Action EMFPEPGCJKF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x64D670", Offset = "0x64BC70", VA = "0x18064D670")]
			public FDINAFHMPCK(JobHandle BMCNLOMODAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1DD1F60", Offset = "0x1DD0560", VA = "0x181DD1F60")]
			public void FHDFGHEFBIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1DD1FA0", Offset = "0x1DD05A0", VA = "0x181DD1FA0")]
			public void FJHOKKOHPIB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<FDINAFHMPCK> HKFFLHKHPAG;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7640", Offset = "0x1DD5C40", VA = "0x181DD7640")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7280", Offset = "0x1DD5880", VA = "0x181DD7280")]
		public AGBEJKCGLOO Add(JobHandle BMCNLOMODAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7550", Offset = "0x1DD5B50", VA = "0x181DD7550")]
		public void Remove(AGBEJKCGLOO OGAKLFCKNOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD73F0", Offset = "0x1DD59F0", VA = "0x181DD73F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7310", Offset = "0x1DD5910", VA = "0x181DD7310")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7750", Offset = "0x1DD5D50", VA = "0x181DD7750")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9920", Offset = "0x1DD7F20", VA = "0x181DD9920")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1DD95F0", Offset = "0x1DD7BF0", VA = "0x181DD95F0")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
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
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
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
