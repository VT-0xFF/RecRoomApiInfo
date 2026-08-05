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
				[Cpp2IlInjected.Address(RVA = "0x41C6AD0", Offset = "0x41C52D0", VA = "0x1841C6AD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1179BE0", Offset = "0x11783E0", VA = "0x181179BE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41C6A90", Offset = "0x41C5290", VA = "0x1841C6A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BE980", Offset = "0x41BD180", VA = "0x1841BE980")]
		public LODSettings AAKPFEGMPPK(HPGKNDLHNMK KILPIDLBIPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x41BE990", Offset = "0x41BD190", VA = "0x1841BE990")]
		public int DHKKKNKEMPI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41BE9B0", Offset = "0x41BD1B0", VA = "0x1841BE9B0")]
		public int EIAKMEMAKBN(bool ODICHOPOFOD, Vector3 NJKJEJFDLCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x41BEAB0", Offset = "0x41BD2B0", VA = "0x1841BEAB0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CEKMMKIHGOK
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
public interface KMFFBHPIMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLHJMMJAECB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NLHECKBMJDK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int CLMMKBONMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LBLMPPELDBB> OAAOJMAOONH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CEKMMKIHGOK DBLPHKEPCII
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
	void UpdateClusterDistances(Vector3 KOFFMKGKNNI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(DFNLBKEBKBB HFHBPDDENLH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LBLMPPELDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FELEPFJBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int BALCLOAPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MNMCOHMPJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JKGMAMIEGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte GJNGOELKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CKAGNMKPCOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum JCCGEGLFMEB
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
	private sealed class LCKFILOANNE : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CKAGNMKPCOC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public LCKFILOANNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41C67F0", Offset = "0x41C4FF0", VA = "0x1841C67F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41C68B0", Offset = "0x41C50B0", VA = "0x1841C68B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EJPPEBAMBKM : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NJCBPLHFLJK <>2__current;

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
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public EJPPEBAMBKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x41C1B00", Offset = "0x41C0300", VA = "0x1841C1B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x41C1C50", Offset = "0x41C0450", VA = "0x1841C1C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CBMPADODNNG : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CKAGNMKPCOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<NJCBPLHFLJK> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public CBMPADODNNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x41BB470", Offset = "0x41B9C70", VA = "0x1841BB470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x41BBEF0", Offset = "0x41BA6F0", VA = "0x1841BBEF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MFNAOCGAAHB : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CKAGNMKPCOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public MFNAOCGAAHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x41C7650", Offset = "0x41C5E50", VA = "0x1841C7650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41C8540", Offset = "0x41C6D40", VA = "0x1841C8540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int BNBAJFKAKIK = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer JALIAMBNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter CFIEEEFPDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject HLOPIDKHCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject HLALCOKAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public BGMCFCFKNMI MFPNDBOFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<DFNLBKEBKBB> HIIOOJOIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DFNLBKEBKBB> DCLACLGKJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DFNLBKEBKBB> CMGKFFGFFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int COONCOKGJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JCCGEGLFMEB OOJPBKPLOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<NLHECKBMJDK>[] CMFEIIJDHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<LBLMPPELDBB>[] BHJBJKCDACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NJIHFLFDJJB CCACNDILMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NJIHFLFDJJB IDHDKPIEJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NJIHFLFDJJB EGIFLFHBENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int MJONNCDHOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int JODMONMOEHK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static CKAGNMKPCOC HNPJABFGGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KGCMOHKMGFN PPPHMLFBCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PCMKKJEGBOM FLHCIGIMOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour IIGGDMLLLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material IENFKIPNNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<KMFFBHPIMBP> HCALOFCGFGE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig MJJBNAIKLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 MMCGICBKKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x125E710", Offset = "0x125CF10", VA = "0x18125E710")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x125B310", Offset = "0x1259B10", VA = "0x18125B310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private JCCGEGLFMEB IJKPHHKAMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x534CD0", Offset = "0x5334D0", VA = "0x180534CD0")]
		get
		{
			return default(JCCGEGLFMEB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41BC090", Offset = "0x41BA890", VA = "0x1841BC090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CKAGNMKPCOC IPNCHOCFJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41BE250", Offset = "0x41BCA50", VA = "0x1841BE250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KONNCHDECOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41BBFB0", Offset = "0x41BA7B0", VA = "0x1841BBFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OKFDDBNGMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41BD120", Offset = "0x41BB920", VA = "0x1841BD120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LBGGOMGKNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41BD810", Offset = "0x41BC010", VA = "0x1841BD810")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41BE320", Offset = "0x41BCB20", VA = "0x1841BE320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OLHANJLOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41BC4B0", Offset = "0x41BACB0", VA = "0x1841BC4B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41BD180", Offset = "0x41BB980", VA = "0x1841BD180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41BE400", Offset = "0x41BCC00", VA = "0x1841BE400")]
	public CKAGNMKPCOC(KGCMOHKMGFN PPPHMLFBCJH, PCMKKJEGBOM FLHCIGIMOIB, ClusterLODConfig ACDKCJOPMIC, MonoBehaviour IIGGDMLLLCB, Material IENFKIPNNKF, ClusterMeshRenderer JALIAMBNFEP, MeshFilter CFIEEEFPDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x41BDB10", Offset = "0x41BC310", VA = "0x1841BDB10")]
	private void MKKHHNHHJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41BC550", Offset = "0x41BAD50", VA = "0x1841BC550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x41BE1C0", Offset = "0x41BC9C0", VA = "0x1841BE1C0")]
	public static void NPIDJFAIIBN(Vector3 MPFMAODHNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41BD8B0", Offset = "0x41BC0B0", VA = "0x1841BD8B0")]
	private void KLIJKOOHGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41BDA10", Offset = "0x41BC210", VA = "0x1841BDA10")]
	private void LMJGOFLEEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41BD5C0", Offset = "0x41BBDC0", VA = "0x1841BD5C0")]
	private void IPMJLPNEHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41BCE50", Offset = "0x41BB650", VA = "0x1841BCE50")]
	public void FHHAEACIFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41BE050", Offset = "0x41BC850", VA = "0x1841BE050")]
	[IteratorStateMachine(typeof(LCKFILOANNE))]
	private IEnumerator<NJCBPLHFLJK> NHNGPMDIEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41BD770", Offset = "0x41BBF70", VA = "0x1841BD770")]
	[IteratorStateMachine(typeof(EJPPEBAMBKM))]
	private IEnumerator<NJCBPLHFLJK> JKLKALKOIOG(Func<bool> GEPNAANOJMK, float JNCIOJNBIMI, Func<string> CIHKPMKNPGC, float JOPABKHGBCE = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41BBF40", Offset = "0x41BA740", VA = "0x1841BBF40")]
	[IteratorStateMachine(typeof(CBMPADODNNG))]
	private IEnumerator<NJCBPLHFLJK> CJCNJOADBKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41BDBA0", Offset = "0x41BC3A0", VA = "0x1841BDBA0")]
	public void MKPCOABMJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x41BE0C0", Offset = "0x41BC8C0", VA = "0x1841BE0C0")]
	public void NJCLDCDFIOD(IEnumerable<NLHECKBMJDK> HHPHFGJMIFM, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41BC200", Offset = "0x41BAA00", VA = "0x1841BC200")]
	public void DKBCDEJGLNF(IEnumerable<NLHECKBMJDK> HHPHFGJMIFM, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41BC680", Offset = "0x41BAE80", VA = "0x1841BC680")]
	public List<ClusterMeshRenderer> FBGKODEGGLL(List<DFNLBKEBKBB> OBJLFKFHOOP, Transform MHMECKKACOC, CEKMMKIHGOK GGJKHBOKBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41BD9D0", Offset = "0x41BC1D0", VA = "0x1841BD9D0")]
	public CEKMMKIHGOK LGGOANPDDCB(Vector3 MLABFIDNGDL)
	{
		return default(CEKMMKIHGOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x41BC030", Offset = "0x41BA830", VA = "0x1841BC030")]
	public void DAJNGLGOLEP(KMFFBHPIMBP BHGFDNOMFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x41BD3F0", Offset = "0x41BBBF0", VA = "0x1841BD3F0")]
	public bool IGHEHPPBNNC(KMFFBHPIMBP BHGFDNOMFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x41BCDF0", Offset = "0x41BB5F0", VA = "0x1841BCDF0")]
	public void FDBKAECPCDE(DFNLBKEBKBB DGAFNKNIBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x41BE140", Offset = "0x41BC940", VA = "0x1841BE140")]
	public void NKAHJPJONPC(LBLMPPELDBB JPCNLNKGAEI, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x41BD950", Offset = "0x41BC150", VA = "0x1841BD950")]
	public void KOOAIDHHONH(LBLMPPELDBB JPCNLNKGAEI, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41BDDB0", Offset = "0x41BC5B0", VA = "0x1841BDDB0")]
	private void NACAFFMDFCC(Vector3 KOFFMKGKNNI, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41BD450", Offset = "0x41BBC50", VA = "0x1841BD450")]
	private void IGKJNBEJFBK(Vector3 KOFFMKGKNNI, CEKMMKIHGOK GGJKHBOKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41BD700", Offset = "0x41BBF00", VA = "0x1841BD700")]
	[IteratorStateMachine(typeof(MFNAOCGAAHB))]
	private IEnumerator<NJCBPLHFLJK> JDLCIFOBELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41BDEE0", Offset = "0x41BC6E0", VA = "0x1841BDEE0")]
	private int NGIMAMOEKGH(int MPFAEFMOAIE, int DFEENLCMKHG, List<LBLMPPELDBB> HPBLLJMGJNN, byte KILPIDLBIPL, ref int JFPAGJAJOFN, float OMKLOJCNFHL = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41BD220", Offset = "0x41BBA20", VA = "0x1841BD220")]
	public void HICPDAONBIK(DFNLBKEBKBB HFHBPDDENLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41BE3C0", Offset = "0x41BCBC0", VA = "0x1841BE3C0")]
	public bool PGNPKNOJBHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8F0", Offset = "0x5A90F0", VA = "0x1805AA8F0")]
	public Material AENEOKMAGOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41BC1C0", Offset = "0x41BA9C0", VA = "0x1841BC1C0")]
	public int DHKKKNKEMPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x41BE2D0", Offset = "0x41BCAD0", VA = "0x1841BE2D0")]
	[CompilerGenerated]
	private bool OLJDKMMHEAH()
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
		[Cpp2IlInjected.Address(RVA = "0xD192F0", Offset = "0xD17AF0", VA = "0x180D192F0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct IHFGMBFHPBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> NFGKBCKIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> CLBMBAGKDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> LGIMIHGBHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> MGJAJJBJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> CIHMLIFHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> IKGGIIPIJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> EICGEBABFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 GHKIHBJBEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float ACEJJNKDMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> KBEAHJCDOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> HNNPLHCLKJE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41C40B0", Offset = "0x41C28B0", VA = "0x1841C40B0")]
	public IHFGMBFHPBO(HJLLFEBGKOE NMNGNBOGDJB, NativeList<float3> EICGEBABFPM, NativeMultiHashMap<int, int> KBEAHJCDOCE, NativeArray<int> HNNPLHCLKJE, Vector3 GHKIHBJBEHI, float ACEJJNKDMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x41C4050", Offset = "0x41C2850", VA = "0x1841C4050")]
	private int FJGBHAHHKFM(float3 KOFFMKGKNNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41C39C0", Offset = "0x41C21C0", VA = "0x1841C39C0")]
	private int DJOCABPBBKA(int DBEFKGHKNPJ, int MHAAPGJKGCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41C3C60", Offset = "0x41C2460", VA = "0x1841C3C60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DIFPOAHFMAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> KBEAHJCDOCE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> HNNPLHCLKJE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int BKAFKJLAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> DFOPFJPLKDA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41C1620", Offset = "0x41BFE20", VA = "0x1841C1620")]
	public void IGGOAJCCNAF(int GPELDCLJDEI, Allocator DCOPLJJMOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x41C1570", Offset = "0x41BFD70", VA = "0x1841C1570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public DIFPOAHFMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HLDMNKMNDJJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> HMLJINLAHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> PEIOHICOLBO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x41C2ED0", Offset = "0x41C16D0", VA = "0x1841C2ED0")]
	public HLDMNKMNDJJ(DIFPOAHFMAN CCLMEPGGBIJ, HJLLFEBGKOE NMNGNBOGDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41C2E40", Offset = "0x41C1640", VA = "0x1841C2E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DDEIFOONOMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> JDOBHPEAONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> CAHIPDDAGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> HOEIDAEPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> EJHHLJKIENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> GMMLHLOCECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> DFOPFJPLKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> HMLJINLAHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> CIJLAHJJJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> FEGLDEOHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> INPAJGNHOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> KAOGIKAFEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> JCOOADDAIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> IDDKDMFAKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float LONGAJBIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float PDDMMEJPBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 NIAPOPKMDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float HKPLJPGBJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float GBGFDDGIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float HHKHGPHGNJB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x41C1430", Offset = "0x41BFC30", VA = "0x1841C1430")]
	public DDEIFOONOMO(DIFPOAHFMAN OHIPJOJACHH, HJLLFEBGKOE NMNGNBOGDJB, HJLLFEBGKOE MCJOHGLFHMP, float GBGFDDGIEBG, float HHKHGPHGNJB, Vector3 NIAPOPKMDFA, float HKPLJPGBJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x41C1190", Offset = "0x41BF990", VA = "0x1841C1190")]
	private float3 MBONKHBNGMJ(int DBEFKGHKNPJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41C0E00", Offset = "0x41BF600", VA = "0x1841C0E00")]
	private void ILHCDLENPNH(int DBEFKGHKNPJ, out float3 IOFFGKMJEDJ, out float3 EOBOKDPADNM, out float4 PPFIALOFIOB, out float4 JLAPDKFMPGL, out float2 EIKOGNHPHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41BFE50", Offset = "0x41BE650", VA = "0x1841BFE50")]
	private int BAEBLEDEMAO(int PAFNGHNAFFO, int LDKKJFJHEKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41C1230", Offset = "0x41BFA30", VA = "0x1841C1230")]
	private void NAEOMMFBIKJ(int PAFNGHNAFFO, int LDKKJFJHEKB, int EEGFFCHMGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41C1000", Offset = "0x41BF800", VA = "0x1841C1000")]
	private bool LJKJFKHFALC(int PAFNGHNAFFO, int LDKKJFJHEKB, float AIDCPOFENOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41C03E0", Offset = "0x41BEBE0", VA = "0x1841C03E0")]
	private bool BIANJNNJMNO(int PAFNGHNAFFO, int LDKKJFJHEKB, int EEGFFCHMGKA, float AIDCPOFENOB, bool GLAJEHPMHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x41C0180", Offset = "0x41BE980", VA = "0x1841C0180")]
	private bool BGHNIEDNJIJ(int PAFNGHNAFFO, int LDKKJFJHEKB, int EEGFFCHMGKA, float AIDCPOFENOB, bool GLAJEHPMHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x41C0FE0", Offset = "0x41BF7E0", VA = "0x1841C0FE0")]
	private void KPBAJINOKFA(int PAFNGHNAFFO, int LDKKJFJHEKB, int EEGFFCHMGKA, out int PKCHOBGPKGG, out int PHIMNACAEIH, out int GMGKDGFNNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x41C04A0", Offset = "0x41BECA0", VA = "0x1841C04A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IIIAIOGGGII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IAECMMMJCOH : IDisposable, LBLMPPELDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds OLPLEHOCCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<DFNLBKEBKBB> OBJLFKFHOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 IPKFLPIKOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 CPCDOPAGBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int MMLJBIHBHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HJLLFEBGKOE BHMPFMDFMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DIFPOAHFMAN PJNHPMDCOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform MHMECKKACOC;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int PBPIAJMBFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41C3360", Offset = "0x41C1B60", VA = "0x1841C3360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh ACNMGFEOEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh ILBLNGLEGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x522010", Offset = "0x520810", VA = "0x180522010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x522020", Offset = "0x520820", VA = "0x180522020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MNMCOHMPJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD8B5C0", Offset = "0xD89DC0", VA = "0x180D8B5C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1D223A0", Offset = "0x1D20BA0", VA = "0x181D223A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte GJNGOELKCGB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x671530", Offset = "0x66FD30", VA = "0x180671530")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6716C0", Offset = "0x66FEC0", VA = "0x1806716C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FELEPFJBCJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x765E60", Offset = "0x764660", VA = "0x180765E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BALCLOAPOCO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA98E10", Offset = "0xA97610", VA = "0x180A98E10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCF9A00", Offset = "0xCF8200", VA = "0x180CF9A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float JKGMAMIEGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x41C3110", Offset = "0x41C1910", VA = "0x1841C3110", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x41C3130", Offset = "0x41C1930", VA = "0x1841C3130")]
		public void JAAAIIKJELB(HPGKNDLHNMK KILPIDLBIPL, out int EFNDBAFCCED, out int IEIBNDCCGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41C3760", Offset = "0x41C1F60", VA = "0x1841C3760")]
		public void OJJJENDKKHO(HPGKNDLHNMK KILPIDLBIPL, CDHGHEMGMAO NAIJKIKKMLG, int OKBJMFFONAF = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x41C33A0", Offset = "0x41C1BA0", VA = "0x1841C33A0")]
		public void JHLJKACFLEF(NativeList<ACBKJDJEAOB> KNMOIKGJCCN, Transform BBJCKDALINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x41C36C0", Offset = "0x41C1EC0", VA = "0x1841C36C0")]
		public void KPIAHNCEBEN(Mesh NMNGNBOGDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x41C2F00", Offset = "0x41C1700", VA = "0x1841C2F00")]
		public void BHGAMKBIHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41C2FA0", Offset = "0x41C17A0", VA = "0x1841C2FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x41C3900", Offset = "0x41C2100", VA = "0x1841C3900")]
		public IAECMMMJCOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds OLPLEHOCCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<IAECMMMJCOH> ELGHLLKMFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AMGCLIABPJG HCHNCPKIAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer GNHALPBJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int IBPHOLBLDAA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh CCNGPKIGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x644A90", Offset = "0x643290", VA = "0x180644A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OMNLKGAGMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x771A50", Offset = "0x770250", VA = "0x180771A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x771AD0", Offset = "0x7702D0", VA = "0x180771AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CLMMKBONMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x41C5390", Offset = "0x41C3B90", VA = "0x1841C5390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x41C4880", Offset = "0x41C3080", VA = "0x1841C4880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x41C5360", Offset = "0x41C3B60", VA = "0x1841C5360")]
	public int IAPKCHLICOD(int NAALEKIHAMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x41C51D0", Offset = "0x41C39D0", VA = "0x1841C51D0")]
	public void HMKNIEDPFCJ(OHPBNKDLHIL LLFBGDMAEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x41C4170", Offset = "0x41C2970", VA = "0x1841C4170")]
	public void DBEJPODCBEK(Transform BBJCKDALINM, bool NHLHLDOMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x41C53E0", Offset = "0x41C3BE0", VA = "0x1841C53E0")]
	public bool MKJFEFINIHA(bool GFJPFMBPGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x41C49E0", Offset = "0x41C31E0", VA = "0x1841C49E0")]
	public void FCOKNLIBCEK(Transform MHMECKKACOC, bool NHLHLDOMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x41C4F70", Offset = "0x41C3770", VA = "0x1841C4F70")]
	public bool HICPDAONBIK(DFNLBKEBKBB HFHBPDDENLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41C5590", Offset = "0x41C3D90", VA = "0x1841C5590")]
	public IIIAIOGGGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BGMCFCFKNMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<IIIAIOGGGII.IAECMMMJCOH> DBPOHLENMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GKGNBEHLHHN DIHBPOLNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<IIIAIOGGGII.IAECMMMJCOH> NGFKOGNDGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int JHANFCKECAL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41BA950", Offset = "0x41B9150", VA = "0x1841BA950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x41BA8D0", Offset = "0x41B90D0", VA = "0x1841BA8D0")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x41BA9C0", Offset = "0x41B91C0", VA = "0x1841BA9C0")]
	public void EFDMEADFFJF(IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI, Transform MHMECKKACOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41BACC0", Offset = "0x41B94C0", VA = "0x1841BACC0")]
	public void HICPDAONBIK(IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x41BA740", Offset = "0x41B8F40", VA = "0x1841BA740")]
	private IIIAIOGGGII.IAECMMMJCOH BBJMPFGEFNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x41BAF10", Offset = "0x41B9710", VA = "0x1841BAF10")]
	private bool LOOADKFMKDE(IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x41BA870", Offset = "0x41B9070", VA = "0x1841BA870")]
	private void CJELKIDHJBE(IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41BAED0", Offset = "0x41B96D0", VA = "0x1841BAED0")]
	public bool LICEGBLLANP(IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x41BAA70", Offset = "0x41B9270", VA = "0x1841BAA70")]
	public bool GNNANHCHACC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x41BAE70", Offset = "0x41B9670", VA = "0x1841BAE70")]
	private IIIAIOGGGII.IAECMMMJCOH JHNHBHJPEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x41BAFA0", Offset = "0x41B97A0", VA = "0x1841BAFA0")]
	public BGMCFCFKNMI()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD192F0", Offset = "0xD17AF0", VA = "0x180D192F0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JIKBLMAFPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int KIICEFGLEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int EGMONOALJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float LIBPBONJFOE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<IIIAIOGGGII> DMKKFHAPGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x41C5B90", Offset = "0x41C4390", VA = "0x1841C5B90")]
	public JIKBLMAFPOD(int KIICEFGLEGA, int EGMONOALJEK, float NMHDMOHDEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x41C5870", Offset = "0x41C4070", VA = "0x1841C5870")]
	public void ANGNPMCBIAD(EOGHPBFPCIL JEDLLPLPPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x41C5910", Offset = "0x41C4110", VA = "0x1841C5910")]
	private int FJLBFNFMCIH(OHPBNKDLHIL BNMBBMFILCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41C5640", Offset = "0x41C3E40", VA = "0x1841C5640")]
	private void ANGNPMCBIAD(OHPBNKDLHIL BNMBBMFILCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x41C59B0", Offset = "0x41C41B0", VA = "0x1841C59B0")]
	private void KLDJFAKOPFI(OHPBNKDLHIL BNMBBMFILCA, IIIAIOGGGII NCEKMGIDKNL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, NLHECKBMJDK
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OODMOFIBPEB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
			[DebuggerHidden]
			public OODMOFIBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x41C8610", Offset = "0x41C6E10", VA = "0x1841C8610", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x41C87A0", Offset = "0x41C6FA0", VA = "0x1841C87A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x41C8700", Offset = "0x41C6F00", VA = "0x1841C8700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x41C8700", Offset = "0x41C6F00", VA = "0x1841C8700", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int CLMMKBONMAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x41BFDF0", Offset = "0x41BE5F0", VA = "0x1841BFDF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<LBLMPPELDBB> OAAOJMAOONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x41BFDD0", Offset = "0x41BE5D0", VA = "0x1841BFDD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> ELGHLLKMFED
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IIIAIOGGGII CCNGPKIGEIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public CEKMMKIHGOK DBLPHKEPCII
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x522390", Offset = "0x520B90", VA = "0x180522390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(CEKMMKIHGOK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x70FDE0", Offset = "0x70E5E0", VA = "0x18070FDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IFBHNKIAOEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x41BFDE0", Offset = "0x41BE5E0", VA = "0x1841BFDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x41BEB10", Offset = "0x41BD310", VA = "0x1841BEB10")]
		public static ClusterMeshRenderer Create(IIIAIOGGGII NMNGNBOGDJB, ClusterMeshRenderer JALIAMBNFEP, MeshFilter CFIEEEFPDEN, Transform MHMECKKACOC, CEKMMKIHGOK GGJKHBOKBPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41BEC20", Offset = "0x41BD420", VA = "0x1841BEC20", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x41BF380", Offset = "0x41BDB80", VA = "0x1841BF380", Slot = "10")]
		public bool TryRemoveClusterLODComponent(DFNLBKEBKBB HFHBPDDENLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x41BF150", Offset = "0x41BD950", VA = "0x1841BF150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x41BEE80", Offset = "0x41BD680", VA = "0x1841BEE80")]
		public void Init(IIIAIOGGGII NMNGNBOGDJB, MeshFilter CFIEEEFPDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x41BEC80", Offset = "0x41BD480", VA = "0x1841BEC80")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x41BF4B0", Offset = "0x41BDCB0", VA = "0x1841BF4B0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 KOFFMKGKNNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x41BF6F0", Offset = "0x41BDEF0", VA = "0x1841BF6F0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x41BEE10", Offset = "0x41BD610", VA = "0x1841BEE10")]
		[IteratorStateMachine(typeof(OODMOFIBPEB))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41BF1D0", Offset = "0x41BD9D0", VA = "0x1841BF1D0")]
		public void SetupTagAndLayer(string FPGJIKIOACI, int GGJKHBOKBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x41BF1B0", Offset = "0x41BD9B0", VA = "0x1841BF1B0")]
		public bool Remove(DFNLBKEBKBB HFHBPDDENLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD192F0", Offset = "0xD17AF0", VA = "0x180D192F0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LFOHDJJJKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int FMMEIEDKCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LFFIOCBDPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int IEIBNDCCGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int EFNDBAFCCED;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x41C6900", Offset = "0x41C5100", VA = "0x1841C6900")]
	public LFOHDJJJKBI(int LFFIOCBDPNK, int IEIBNDCCGFH, int FMMEIEDKCDK, int EFNDBAFCCED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AMGCLIABPJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> NFGKBCKIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> DFOPFJPLKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> IKGGIIPIJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<LFOHDJJJKBI> GNCDNLHDCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> GLBNKNIBOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> BCLDMBDGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> AADEHFOIKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle HMMOMOBDFED;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NDHIHOPJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C1720", Offset = "0x6BFF20", VA = "0x1806C1720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C1740", Offset = "0x6BFF40", VA = "0x1806C1740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x41B94E0", Offset = "0x41B7CE0", VA = "0x1841B94E0")]
	public void BGMLIEBECGB(HJLLFEBGKOE FKIOIFHMOLO, NativeList<LFOHDJJJKBI> GNCDNLHDCNG, float IFILJBGOAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x41BA4F0", Offset = "0x41B8CF0", VA = "0x1841BA4F0")]
	public void PDBPNFHLFMO(Transform MHMECKKACOC, bool NHLHLDOMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x41BA360", Offset = "0x41B8B60", VA = "0x1841BA360")]
	public void MKJFEFINIHA(IIIAIOGGGII GNHALPBJHCH, bool GFJPFMBPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41BA290", Offset = "0x41B8A90", VA = "0x1841BA290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x41BA260", Offset = "0x41B8A60", VA = "0x1841BA260")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public AMGCLIABPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct MCLPFIMNODK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> NFGKBCKIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> DFOPFJPLKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<LFOHDJJJKBI> FOHLEEGODIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> GLBNKNIBOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 NIAPOPKMDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> BCLDMBDGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> AADEHFOIKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool NHLHLDOMICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float AFBICNIEEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float PCDKNKKKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float KLNDHJFKOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> IKGGIIPIJPD;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x41C7580", Offset = "0x41C5D80", VA = "0x1841C7580")]
	public MCLPFIMNODK(AMGCLIABPJG IGLPCAMOOFB, Vector3 NIAPOPKMDFA, bool NHLHLDOMICD, float AFBICNIEEGO, float PCDKNKKKLPI, float KLNDHJFKOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x41C70E0", Offset = "0x41C58E0", VA = "0x1841C70E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DFNLBKEBKBB : CNHNDMINLMM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds LHILMIAMCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ACBKJDJEAOB CNNPDNPIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OHPBNKDLHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<DFNLBKEBKBB> OBJLFKFHOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public OHPBNKDLHIL AIECLMDDNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public OHPBNKDLHIL HEGJHCMKEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public OHPBNKDLHIL LNNGPJNBPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int EFNDBAFCCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds OLPLEHOCCGB;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41C8590", Offset = "0x41C6D90", VA = "0x1841C8590")]
	public OHPBNKDLHIL(List<DFNLBKEBKBB> OBJLFKFHOOP, [Optional] OHPBNKDLHIL AIECLMDDNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EOGHPBFPCIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<OHPBNKDLHIL> FHELAIPLFKH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public OHPBNKDLHIL CNMJPCHFBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x41C1CA0", Offset = "0x41C04A0", VA = "0x1841C1CA0")]
	public EOGHPBFPCIL(OHPBNKDLHIL MHMECKKACOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PEOMEKILDPH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct EOJDJFKPIIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int BFKFBJFLJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int HEMMLOHJGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int PPGCCLGNGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int MKDNIIBNODI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LEHBAHMJOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int MFHAOBJFBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float OGFOLKCOBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<DFNLBKEBKBB> OBJLFKFHOOP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum GNBNLJBDMGE
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
	private EOJDJFKPIIF OCALFNHDBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int OHMFLAJGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int KIICEFGLEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int EGMONOALJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float NMHDMOHDEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float HDGKJGIPJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<OHPBNKDLHIL> LLLNCJMFHBG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public EOGHPBFPCIL FJKPEBNLOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x41CA420", Offset = "0x41C8C20", VA = "0x1841CA420")]
	public PEOMEKILDPH(int KIICEFGLEGA, int EGMONOALJEK, float NMHDMOHDEDH, int OHMFLAJGMPB, float HDGKJGIPJCH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x41C98E0", Offset = "0x41C80E0", VA = "0x1841C98E0")]
	public void KNJKLOILAJJ(List<DFNLBKEBKBB> OBJLFKFHOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x41CA3B0", Offset = "0x41C8BB0", VA = "0x1841CA3B0")]
	public bool OHPLMFKOPBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41C8BE0", Offset = "0x41C73E0", VA = "0x1841C8BE0")]
	private float DBOANLFNPCF(Vector3 OFBJHBMBFOG, Vector3 BCHCMKEJPMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41C8CF0", Offset = "0x41C74F0", VA = "0x1841C8CF0")]
	private float DBOANLFNPCF(Vector3 LGIEDJBGIJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x41C9AA0", Offset = "0x41C82A0", VA = "0x1841C9AA0")]
	private bool MMMEGACBKCM(OHPBNKDLHIL HOPKMDNBHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x41C8D90", Offset = "0x41C7590", VA = "0x1841C8D90")]
	private LEHBAHMJOIF GEPBMHHEJOI(List<DFNLBKEBKBB> ILEBPNFAOFC, GNBNLJBDMGE LMABPPPLLJI)
	{
		return default(LEHBAHMJOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x41C8850", Offset = "0x41C7050", VA = "0x1841C8850")]
	private void BJBJPHBAEJO(List<DFNLBKEBKBB> OBJLFKFHOOP, Vector3[] ODGEKLLODNO, Vector3[] HLCGPHIPOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DPAFCPMOGIB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x41C1950", Offset = "0x41C0150", VA = "0x1841C1950")]
	public static Bounds PPDKDPGBOKD(List<DFNLBKEBKBB> OBJLFKFHOOP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x41C17C0", Offset = "0x41BFFC0", VA = "0x1841C17C0")]
	public static int CPBGOLCBNKA(List<DFNLBKEBKBB> OBJLFKFHOOP, HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GKGNBEHLHHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HJLLFEBGKOE DAJHKDHKAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HJLLFEBGKOE DBCKNJDMEJH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static HJLLFEBGKOE CDMBCFOKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private HCBHCCBKJMP MOGBFIMILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CDHGHEMGMAO NAIJKIKKMLG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle HMMOMOBDFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x836CC0", Offset = "0x8354C0", VA = "0x180836CC0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x836CE0", Offset = "0x8354E0", VA = "0x180836CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IIIAIOGGGII.IAECMMMJCOH HOPKMDNBHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GCLLCMMGNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x743BC0", Offset = "0x7423C0", VA = "0x180743BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x41C2D40", Offset = "0x41C1540", VA = "0x1841C2D40")]
	[DIOLCMJEKCJ(DMCKANKCBMH.ExitingPlayMode, 0)]
	private void HLHKFCADKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x41C1D50", Offset = "0x41C0550", VA = "0x1841C1D50")]
	public void BGMLIEBECGB(IIIAIOGGGII.IAECMMMJCOH FOHLEEGODIJ, Transform MPOODOGAEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x41C26D0", Offset = "0x41C0ED0", VA = "0x1841C26D0")]
	public void DKADFMHJAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x41C2CD0", Offset = "0x41C14D0", VA = "0x1841C2CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x41C2C90", Offset = "0x41C1490", VA = "0x1841C2C90")]
	public void DKOADGNIPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x41C2DB0", Offset = "0x41C15B0", VA = "0x1841C2DB0")]
	public GKGNBEHLHHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ENBMIDJDNMO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CKAGNMKPCOC CAJFKANKMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PCMKKJEGBOM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 KEDBCEKOEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KGCMOHKMGFN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JONKJBKJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PHOEHELALNA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action KAKDNNKOAHK;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IIFCCJCNIHM
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IIFCCJCNIHM JJLFPIKPMMM(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIFCCJCNIHM IONAIPPDOKE(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IIFCCJCNIHM PHKNNFJGMJJ(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIFCCJCNIHM OPPAOCAPKMN(Action BOJLOMGNIOM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class BIIGJABIPJF : IIFCCJCNIHM
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class LKNEMIPHGCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public BIIGJABIPJF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public LKNEMIPHGCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x41C69B0", Offset = "0x41C51B0", VA = "0x1841C69B0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x41C6A00", Offset = "0x41C5200", VA = "0x1841C6A00")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x41C6A50", Offset = "0x41C5250", VA = "0x1841C6A50")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> MDKOIBMJPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action MKKNNDFNNGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action PLMFIGJHKCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private BPHFJIPGNDF NBAGHDHOIOP;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action PNCLOODEIDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x54A0C0", Offset = "0x5488C0", VA = "0x18054A0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x644A90", Offset = "0x643290", VA = "0x180644A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action KLBKFABJGNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2438C80", Offset = "0x2437480", VA = "0x182438C80", Slot = "4")]
			public IIFCCJCNIHM JJLFPIKPMMM(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x27D0110", Offset = "0x27CE910", VA = "0x1827D0110", Slot = "5")]
			public IIFCCJCNIHM IONAIPPDOKE(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x28A0390", Offset = "0x289EB90", VA = "0x1828A0390", Slot = "6")]
			public IIFCCJCNIHM PHKNNFJGMJJ(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x12CB3D0", Offset = "0x12C9BD0", VA = "0x1812CB3D0", Slot = "7")]
			public IIFCCJCNIHM OPPAOCAPKMN(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x656320", Offset = "0x654B20", VA = "0x180656320")]
			public BIIGJABIPJF(Func<JobHandle> BKKOLILIDEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x41BB240", Offset = "0x41B9A40", VA = "0x1841BB240")]
			public void MPLILEEGLKO(Action OEHBJBDPGCF, Action MAEFMIPDEHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x41BB0E0", Offset = "0x41B98E0", VA = "0x1841BB0E0")]
			public void HICPDAONBIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JCHLOJOLDFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public IIFCCJCNIHM jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public JCHLOJOLDFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x41C5630", Offset = "0x41C3E30", VA = "0x1841C5630")]
			internal bool <Remove>b__0(BIIGJABIPJF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PBCAPLLFANG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public BIIGJABIPJF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public PBCAPLLFANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x41C87F0", Offset = "0x41C6FF0", VA = "0x1841C87F0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<BIIGJABIPJF> ADIHEELLKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<BIIGJABIPJF> NNAFNPNBEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private NJIHFLFDJJB KCOEBPENBHD;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x41C5BF0", Offset = "0x41C43F0", VA = "0x1841C5BF0")]
		public IIFCCJCNIHM Add(Func<JobHandle> BKKOLILIDEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x41C5E80", Offset = "0x41C4680", VA = "0x1841C5E80")]
		public void Remove(IIFCCJCNIHM HMMOMOBDFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x41C5D00", Offset = "0x41C4500", VA = "0x1841C5D00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x41C6000", Offset = "0x41C4800", VA = "0x1841C6000")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x41C61D0", Offset = "0x41C49D0", VA = "0x1841C61D0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x41C5BE0", Offset = "0x41C43E0", VA = "0x1841C5BE0")]
		[CompilerGenerated]
		private void AAIIDDKCMAO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BPHFJIPGNDF
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPHFJIPGNDF JJLFPIKPMMM(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BPHFJIPGNDF BJKDPIFPCID(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BPHFJIPGNDF OPPAOCAPKMN(Action BOJLOMGNIOM);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LIDJGFIKNDC : BPHFJIPGNDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle FGJLCCJGJFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action MKKNNDFNNGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action JADALIPFMBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action KLBKFABJGNA;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool DOFIHGIMLDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x41C69A0", Offset = "0x41C51A0", VA = "0x1841C69A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x27D0110", Offset = "0x27CE910", VA = "0x1827D0110", Slot = "4")]
			public BPHFJIPGNDF JJLFPIKPMMM(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x28A0390", Offset = "0x289EB90", VA = "0x1828A0390", Slot = "5")]
			public BPHFJIPGNDF BJKDPIFPCID(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x12CB3D0", Offset = "0x12C9BD0", VA = "0x1812CB3D0", Slot = "6")]
			public BPHFJIPGNDF OPPAOCAPKMN(Action BOJLOMGNIOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC486F0", Offset = "0xC46EF0", VA = "0x180C486F0")]
			public LIDJGFIKNDC(JobHandle ANJMDNLMBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x41C6960", Offset = "0x41C5160", VA = "0x1841C6960")]
			public void HOCHBDLCMIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x41C6920", Offset = "0x41C5120", VA = "0x1841C6920")]
			public void HICPDAONBIK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<LIDJGFIKNDC> HOBAHGONMAK;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x41C6650", Offset = "0x41C4E50", VA = "0x1841C6650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x41C6290", Offset = "0x41C4A90", VA = "0x1841C6290")]
		public BPHFJIPGNDF Add(JobHandle ANJMDNLMBEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x41C6560", Offset = "0x41C4D60", VA = "0x1841C6560")]
		public void Remove(BPHFJIPGNDF HMMOMOBDFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x41C6400", Offset = "0x41C4C00", VA = "0x1841C6400", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x41C6320", Offset = "0x41C4B20", VA = "0x1841C6320")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x41C6760", Offset = "0x41C4F60", VA = "0x1841C6760")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x41C6AF0", Offset = "0x41C52F0", VA = "0x1841C6AF0")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x41C6BF0", Offset = "0x41C53F0", VA = "0x1841C6BF0")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
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
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
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
