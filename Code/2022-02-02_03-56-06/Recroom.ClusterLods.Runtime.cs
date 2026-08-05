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
				[Cpp2IlInjected.Address(RVA = "0x3E09ED0", Offset = "0x3E08ED0", VA = "0x183E09ED0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xF789F0", Offset = "0xF779F0", VA = "0x180F789F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3E09E90", Offset = "0x3E08E90", VA = "0x183E09E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFFE50", Offset = "0x3DFEE50", VA = "0x183DFFE50")]
		public LODSettings JMGKAGFLDFO(BPICDCNJEKC DMIKFDNHDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFE30", Offset = "0x3DFEE30", VA = "0x183DFFE30")]
		public int ENMANBIICBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFE60", Offset = "0x3DFEE60", VA = "0x183DFFE60")]
		public int NFPHMLDHIJL(bool JNOHPAKNEGF, Vector3 LEIAPGJCGGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFF60", Offset = "0x3DFEF60", VA = "0x183DFFF60")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PALPFNOFDFN
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
public interface JPNAPLMGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOOFKOMMJGB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface APHBOFOBIDM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int FJIOPJMACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<ABNEAMNCIKF> LICNDCNFJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PALPFNOFDFN DLPEHMPGEEH
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
	void UpdateClusterDistances(Vector3 BLEDLAABCLI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(BGPDOMEBKNI INOINFMPGFK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ABNEAMNCIKF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int AAKCKADHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int MEIFNFDJFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JOAAEHHCOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float ABBKCCBLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte IMMHAKBLMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DNHHPHGCGOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OPDHHGKKIKG
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
	private sealed class PHPEFMEGKAP : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DNHHPHGCGOD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public PHPEFMEGKAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DC80", Offset = "0x3E0CC80", VA = "0x183E0DC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DD40", Offset = "0x3E0CD40", VA = "0x183E0DD40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ONGOBHLKFIE : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MFENADOJIIE <>2__current;

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
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public ONGOBHLKFIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DA80", Offset = "0x3E0CA80", VA = "0x183E0DA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DBD0", Offset = "0x3E0CBD0", VA = "0x183E0DBD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OFJPNNJGLLD : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DNHHPHGCGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<MFENADOJIIE> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public OFJPNNJGLLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CFB0", Offset = "0x3E0BFB0", VA = "0x183E0CFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DA30", Offset = "0x3E0CA30", VA = "0x183E0DA30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HPEJIGHIKPC : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DNHHPHGCGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public HPEJIGHIKPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3E04610", Offset = "0x3E03610", VA = "0x183E04610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3E05500", Offset = "0x3E04500", VA = "0x183E05500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int PDKJAIOCJFN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer CCDDFKOFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter BPIMNBABEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject BPMBENHENMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject EPDHCICOIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MKNHFDCONDL AGHAFLDDIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<BGPDOMEBKNI> LFOCGAPEGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<BGPDOMEBKNI> FMAKDAOBAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<BGPDOMEBKNI> AOLDHGNMAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NOGKDHLHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OPDHHGKKIKG DMOCHOCPHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<APHBOFOBIDM>[] IAGJGLKMHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<ABNEAMNCIKF>[] KDPAEBELBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LBEACJDEKDN IOPNDKCBJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LBEACJDEKDN JIHHEDIIIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private LBEACJDEKDN ACGAPCLFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NNKMFCKPOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int CGOEFFCCBJP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static DNHHPHGCGOD EGMAIKDHHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NHECMKHHIMD AIPNHNEAIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PHJBCPPJLIO BPAOOOLLPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour FGEDNJAHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material OKLOEBBKALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<JPNAPLMGKPJ> EHGEBHJOILB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig FKHLJFOEPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 LKIEAKCICBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5C0", Offset = "0xD4E5C0", VA = "0x180D4F5C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD4E030", Offset = "0xD4D030", VA = "0x180D4E030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private OPDHHGKKIKG FCCGIJHPLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CD0", Offset = "0x4F5CD0", VA = "0x1804F6CD0")]
		get
		{
			return default(OPDHHGKKIKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E02B90", Offset = "0x3E01B90", VA = "0x183E02B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DNHHPHGCGOD BGMCCDCKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E033B0", Offset = "0x3E023B0", VA = "0x183E033B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool LOGEFNCGBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E01900", Offset = "0x3E00900", VA = "0x183E01900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool LBGGHDAGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E030B0", Offset = "0x3E020B0", VA = "0x183E030B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NFNJEFPOOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E029C0", Offset = "0x3E019C0", VA = "0x183E029C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E01DB0", Offset = "0x3E00DB0", VA = "0x183E01DB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HOIJBEFIPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E03640", Offset = "0x3E02640", VA = "0x183E03640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E02D00", Offset = "0x3E01D00", VA = "0x183E02D00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E03DC0", Offset = "0x3E02DC0", VA = "0x183E03DC0")]
	public DNHHPHGCGOD(NHECMKHHIMD AIPNHNEAIEC, PHJBCPPJLIO BPAOOOLLPAL, ClusterLODConfig HKHEHFBHJKD, MonoBehaviour FGEDNJAHJHH, Material OKLOEBBKALK, ClusterMeshRenderer CCDDFKOFHML, MeshFilter BPIMNBABEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3E02930", Offset = "0x3E01930", VA = "0x183E02930")]
	private void DOKFEOMMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E02A60", Offset = "0x3E01A60", VA = "0x183E02A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E01FC0", Offset = "0x3E00FC0", VA = "0x183E01FC0")]
	public static void DKDEEBDJPAM(Vector3 ACIEKLNKKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E039C0", Offset = "0x3E029C0", VA = "0x183E039C0")]
	private void NPJDBKHMABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E01E50", Offset = "0x3E00E50", VA = "0x183E01E50")]
	private void BPPENHDKNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E03270", Offset = "0x3E02270", VA = "0x183E03270")]
	private void ICGMLOFJJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E02DE0", Offset = "0x3E01DE0", VA = "0x183E02DE0")]
	public void FFLFACIDHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E01C80", Offset = "0x3E00C80", VA = "0x183E01C80")]
	[IteratorStateMachine(typeof(PHPEFMEGKAP))]
	private IEnumerator<MFENADOJIIE> BCJEKFNIGAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E038C0", Offset = "0x3E028C0", VA = "0x183E038C0")]
	[IteratorStateMachine(typeof(ONGOBHLKFIE))]
	private IEnumerator<MFENADOJIIE> NJCOLGDGCHF(Func<bool> FOPIJABADPP, float GKIOCKNNKGM, Func<string> LIEOJNNEPPI, float IPOGKLBCJHO = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E03850", Offset = "0x3E02850", VA = "0x183E03850")]
	[IteratorStateMachine(typeof(OFJPNNJGLLD))]
	private IEnumerator<MFENADOJIIE> NAKMMLGDIIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E03430", Offset = "0x3E02430", VA = "0x183E03430")]
	public void IFDKHJIJFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E01D30", Offset = "0x3E00D30", VA = "0x183E01D30")]
	public void BGCBIDPHGEL(IEnumerable<APHBOFOBIDM> HLNMIHIBGPL, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E01980", Offset = "0x3E00980", VA = "0x183E01980")]
	public void ABKKHEMIDDL(IEnumerable<APHBOFOBIDM> HLNMIHIBGPL, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E02050", Offset = "0x3E01050", VA = "0x183E02050")]
	public List<ClusterMeshRenderer> DKJMBGDLCML(List<BGPDOMEBKNI> PMPOKIAPDCN, Transform HKCIGEFNNOB, PALPFNOFDFN BGAEFDGLOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E02DA0", Offset = "0x3E01DA0", VA = "0x183E02DA0")]
	public PALPFNOFDFN EODONKLKHCG(Vector3 EHFLAMIEADP)
	{
		return default(PALPFNOFDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E03960", Offset = "0x3E02960", VA = "0x183E03960")]
	public void NNBHLHGIOPG(JPNAPLMGKPJ PMCOPEBIBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E03210", Offset = "0x3E02210", VA = "0x183E03210")]
	public bool HOCLHHNDEJB(JPNAPLMGKPJ PMCOPEBIBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E03B90", Offset = "0x3E02B90", VA = "0x183E03B90")]
	public void PFEAHNBFGHC(BGPDOMEBKNI FLHKCIPDCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E03190", Offset = "0x3E02190", VA = "0x183E03190")]
	public void HBPLFODCHCE(ABNEAMNCIKF IBFANKIHDNB, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E03110", Offset = "0x3E02110", VA = "0x183E03110")]
	public void GKIAGOGPMHI(ABNEAMNCIKF IBFANKIHDNB, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E03A60", Offset = "0x3E02A60", VA = "0x183E03A60")]
	private void ONJMFFEDPOC(Vector3 BLEDLAABCLI, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E027C0", Offset = "0x3E017C0", VA = "0x183E027C0")]
	private void DLJAAAIHGGC(Vector3 BLEDLAABCLI, PALPFNOFDFN BGAEFDGLOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E01F50", Offset = "0x3E00F50", VA = "0x183E01F50")]
	[IteratorStateMachine(typeof(HPEJIGHIKPC))]
	private IEnumerator<MFENADOJIIE> DEJDHEEACDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E036E0", Offset = "0x3E026E0", VA = "0x183E036E0")]
	private int MHDPKIMMOCJ(int ODKCMELFFGF, int FNNPNGJDGHI, List<ABNEAMNCIKF> PLPBOIBNBHD, byte DMIKFDNHDCC, ref int JFHBKFGNDIC, float ICNHHMKKOMI = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E03BF0", Offset = "0x3E02BF0", VA = "0x183E03BF0")]
	public void PMCHHOBKDIO(BGPDOMEBKNI INOINFMPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E01CF0", Offset = "0x3E00CF0", VA = "0x183E01CF0")]
	public bool BFGNIHBGKAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x591C10", Offset = "0x590C10", VA = "0x180591C10")]
	public Material HNDPMCIMHKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E02CC0", Offset = "0x3E01CC0", VA = "0x183E02CC0")]
	public int ENMANBIICBN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E01C30", Offset = "0x3E00C30", VA = "0x183E01C30")]
	[CompilerGenerated]
	private bool AOKFGNBMBAO()
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
		[Cpp2IlInjected.Address(RVA = "0xC75CE0", Offset = "0xC74CE0", VA = "0x180C75CE0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct CEHNOMENJIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> IOPPBPHBOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> LPNACGAPFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> GPMNNIHIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> LJJCMGLFMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> LLFIPIDPKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> HHGBINNENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> EAOGPPHAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 JGAPHBIPOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float NMGNOOHOMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> CDKAOOJDIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> HHGNNMMFMLG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFC90", Offset = "0x3DFEC90", VA = "0x183DFFC90")]
	public CEHNOMENJIC(EDMDJOLCDFN DLNIEOMAIFB, NativeList<float3> EAOGPPHAJAD, NativeMultiHashMap<int, int> CDKAOOJDIIE, NativeArray<int> HHGNNMMFMLG, Vector3 JGAPHBIPOAA, float NMGNOOHOMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF990", Offset = "0x3DFE990", VA = "0x183DFF990")]
	private int GKNCOHFKBNI(float3 BLEDLAABCLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF9F0", Offset = "0x3DFE9F0", VA = "0x183DFF9F0")]
	private int NKJAAKJHBCM(int OPLFCDPHHFO, int GOLKIAIKMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF5A0", Offset = "0x3DFE5A0", VA = "0x183DFF5A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GIAMEPDCGDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> CDKAOOJDIIE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> HHGNNMMFMLG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int EPFGMPBGOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> MHOIKLAMBHI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3E04470", Offset = "0x3E03470", VA = "0x183E04470")]
	public void JMMDENOLFID(int KKKOBONIANN, Allocator LBPFGGOFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3E043C0", Offset = "0x3E033C0", VA = "0x183E043C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public GIAMEPDCGDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct AFLFNGFAEML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> HGDNNAJMBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> DGAFMOHDIMI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3DFCE80", Offset = "0x3DFBE80", VA = "0x183DFCE80")]
	public AFLFNGFAEML(GIAMEPDCGDO BEPPIMJKIOA, EDMDJOLCDFN DLNIEOMAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3DFCDF0", Offset = "0x3DFBDF0", VA = "0x183DFCDF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct IILJLIOOCJK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> LFEFJJDDMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> GIOIODNJDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> IMNGGPIHIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> KEPOIOEOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> JBCOKCHGFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> MHOIKLAMBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> HGDNNAJMBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> EEOOEFFGKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> AGOENJGPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> IMHGGJJCFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> NLCKCHPIGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> HBDNJNNNIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> BMPCGKFFCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float FEIOMOILHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float JBPPJFIBONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 FOBCCPEDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float BJOGFMINFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float MADIKJBLOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float KOMFMCDHIAA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3E06BE0", Offset = "0x3E05BE0", VA = "0x183E06BE0")]
	public IILJLIOOCJK(GIAMEPDCGDO DOBCOLICKLE, EDMDJOLCDFN DLNIEOMAIFB, EDMDJOLCDFN IBALOAIDMLH, float MADIKJBLOEN, float KOMFMCDHIAA, Vector3 FOBCCPEDNKK, float BJOGFMINFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3E06550", Offset = "0x3E05550", VA = "0x183E06550")]
	private float3 IAGOMFGDGDN(int OPLFCDPHHFO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3E06A00", Offset = "0x3E05A00", VA = "0x183E06A00")]
	private void OKDFCLPEKNF(int OPLFCDPHHFO, out float3 LFOMLCPGGFK, out float3 HDKDFFOGODI, out float4 GJFLOJKIEPD, out float4 FLCAGBINBNB, out float2 APIELCMFPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3E058C0", Offset = "0x3E048C0", VA = "0x183E058C0")]
	private int ENNGJHBEKNH(int PDJPFCJBODI, int DCGCKHNOKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3E05600", Offset = "0x3E04600", VA = "0x183E05600")]
	private void ACAOJPHNIEI(int PDJPFCJBODI, int DCGCKHNOKKM, int CMFNLBNAIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3E06870", Offset = "0x3E05870", VA = "0x183E06870")]
	private bool OEENNEJLAEI(int PDJPFCJBODI, int DCGCKHNOKKM, float EBGJALEPPPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3E05800", Offset = "0x3E04800", VA = "0x183E05800")]
	private bool COFALGCACEL(int PDJPFCJBODI, int DCGCKHNOKKM, int CMFNLBNAIHA, float EBGJALEPPPB, bool FHDJIAJFDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E06610", Offset = "0x3E05610", VA = "0x183E06610")]
	private bool MGDLLNEOEIN(int PDJPFCJBODI, int DCGCKHNOKKM, int CMFNLBNAIHA, float EBGJALEPPPB, bool FHDJIAJFDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3E065F0", Offset = "0x3E055F0", VA = "0x183E065F0")]
	private void KKBIFMEKAOP(int PDJPFCJBODI, int DCGCKHNOKKM, int CMFNLBNAIHA, out int CANGIPJGIDB, out int OADKOKDLGLC, out int MHCFEEGOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3E05BF0", Offset = "0x3E04BF0", VA = "0x183E05BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MKEEHOHGPPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JFNHADHOCOD : IDisposable, ABNEAMNCIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds DFKEBPEGDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<BGPDOMEBKNI> PMPOKIAPDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 JACLHABHKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 BKHJOICMCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int HGMIPBJPCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public EDMDJOLCDFN IKHMKIKNHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GIAMEPDCGDO JFDCDGBFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform HKCIGEFNNOB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int AJOBKMJDMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3E07180", Offset = "0x3E06180", VA = "0x183E07180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh AKGEKPHCPAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh PKONAPMPOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x4E4010", Offset = "0x4E3010", VA = "0x1804E4010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4E4020", Offset = "0x4E3020", VA = "0x1804E4020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JOAAEHHCOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xEE7DA0", Offset = "0xEE6DA0", VA = "0x180EE7DA0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1076840", Offset = "0x1075840", VA = "0x181076840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte IMMHAKBLMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E0640", Offset = "0x5DF640", VA = "0x1805E0640")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E07D0", Offset = "0x5DF7D0", VA = "0x1805E07D0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AAKCKADHLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x62C590", Offset = "0x62B590", VA = "0x18062C590", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x62BC20", Offset = "0x62AC20", VA = "0x18062BC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MEIFNFDJFEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA069F0", Offset = "0xA059F0", VA = "0x180A069F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xC55350", Offset = "0xC54350", VA = "0x180C55350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float ABBKCCBLKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3E06D20", Offset = "0x3E05D20", VA = "0x183E06D20", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3E06F50", Offset = "0x3E05F50", VA = "0x183E06F50")]
		public void GDBJKDGBFNH(BPICDCNJEKC DMIKFDNHDCC, out int JFCDFCMLCPF, out int OAJACDBGGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3E071C0", Offset = "0x3E061C0", VA = "0x183E071C0")]
		public void IBNBJAJDANB(BPICDCNJEKC DMIKFDNHDCC, BEEPDOCNEHB PGFNFBDGMHO, int EIOLMJCOIAI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3E07360", Offset = "0x3E06360", VA = "0x183E07360")]
		public void LBNKBOINEII(NativeList<JHCPHBENKBF> KDKFDOKJMNP, Transform HCAAJDELMPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E06EB0", Offset = "0x3E05EB0", VA = "0x183E06EB0")]
		public void FHOIMMDDMDP(Mesh DLNIEOMAIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E07680", Offset = "0x3E06680", VA = "0x183E07680")]
		public void OPPKPBOHFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3E06D40", Offset = "0x3E05D40", VA = "0x183E06D40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3E07720", Offset = "0x3E06720", VA = "0x183E07720")]
		public JFNHADHOCOD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds DFKEBPEGDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<JFNHADHOCOD> ICNJNHFDMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NGEHOGGPEHL OKNOLOOLPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer AJMDOGNODKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int CPDJOCHDGFD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh IMJHGMLANBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50C0C0", Offset = "0x50B0C0", VA = "0x18050C0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5DE190", Offset = "0x5DD190", VA = "0x1805DE190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OKINFKAPBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C5300", Offset = "0x6C4300", VA = "0x1806C5300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C5380", Offset = "0x6C4380", VA = "0x1806C5380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FJIOPJMACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B060", Offset = "0x3E0A060", VA = "0x183E0B060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A480", Offset = "0x3E09480", VA = "0x183E0A480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A770", Offset = "0x3E09770", VA = "0x183E0A770")]
	public int FELLAHNNGPH(int LONOBCBECKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A5E0", Offset = "0x3E095E0", VA = "0x183E0A5E0")]
	public void EECALAIMGBB(GHIKOHFHAMN FNBEPDKBIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A950", Offset = "0x3E09950", VA = "0x183E0A950")]
	public void JFOGBBCMAKJ(Transform HCAAJDELMPH, bool KKEAMFENCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A7A0", Offset = "0x3E097A0", VA = "0x183E0A7A0")]
	public bool GPJBLCCIGAA(bool NDNFOFIPICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E09EF0", Offset = "0x3E08EF0", VA = "0x183E09EF0")]
	public void DGKACODJBDF(Transform HKCIGEFNNOB, bool KKEAMFENCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B0B0", Offset = "0x3E0A0B0", VA = "0x183E0B0B0")]
	public bool PMCHHOBKDIO(BGPDOMEBKNI INOINFMPGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B310", Offset = "0x3E0A310", VA = "0x183E0B310")]
	public MKEEHOHGPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MKNHFDCONDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<MKEEHOHGPPL.JFNHADHOCOD> BEPLDCAGJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private LLFLNCCPDCH HKECPIGLOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<MKEEHOHGPPL.JFNHADHOCOD> PBOLOLBDNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int JELEONKDBNC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B6A0", Offset = "0x3E0A6A0", VA = "0x183E0B6A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B9E0", Offset = "0x3E0A9E0", VA = "0x183E0B9E0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B930", Offset = "0x3E0A930", VA = "0x183E0B930")]
	public void IDCEJGBHLFK(MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN, Transform HKCIGEFNNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BA60", Offset = "0x3E0AA60", VA = "0x183E0BA60")]
	public void PMCHHOBKDIO(MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B800", Offset = "0x3E0A800", VA = "0x183E0B800")]
	private MKEEHOHGPPL.JFNHADHOCOD FOHCEFGDGGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B770", Offset = "0x3E0A770", VA = "0x183E0B770")]
	private bool ELLOHJDPCGJ(MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B600", Offset = "0x3E0A600", VA = "0x183E0B600")]
	private void BEFALFDNJIA(MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B660", Offset = "0x3E0A660", VA = "0x183E0B660")]
	public bool DEDJPMLNEOK(MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B3B0", Offset = "0x3E0A3B0", VA = "0x183E0B3B0")]
	public bool ANEHKFACJGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B710", Offset = "0x3E0A710", VA = "0x183E0B710")]
	private MKEEHOHGPPL.JFNHADHOCOD ELCCDDEEEAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BC10", Offset = "0x3E0AC10", VA = "0x183E0BC10")]
	public MKNHFDCONDL()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC75CE0", Offset = "0xC74CE0", VA = "0x180C75CE0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BFAFCPFHDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int FIAIBJFOFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int KLAGBHBKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float PDPIGLJNIBK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<MKEEHOHGPPL> KLLLICFGEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD920", Offset = "0x3DFC920", VA = "0x183DFD920")]
	public BFAFCPFHDHB(int FIAIBJFOFGI, int KLAGBHBKNJL, float HNILKPCMLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD600", Offset = "0x3DFC600", VA = "0x183DFD600")]
	public void CAEOBBBIIAG(KJFFNKBIAKI DPFOKNONCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD6A0", Offset = "0x3DFC6A0", VA = "0x183DFD6A0")]
	private int KPBKPEGCCEM(GHIKOHFHAMN AGPKFNBHLMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD3D0", Offset = "0x3DFC3D0", VA = "0x183DFD3D0")]
	private void CAEOBBBIIAG(GHIKOHFHAMN AGPKFNBHLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD740", Offset = "0x3DFC740", VA = "0x183DFD740")]
	private void NEPHIPKPEGC(GHIKOHFHAMN AGPKFNBHLMB, MKEEHOHGPPL KPOFBIJPEAG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, APHBOFOBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AKNGDJAOGNH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xBF0DD0", Offset = "0xBEFDD0", VA = "0x180BF0DD0")]
			[DebuggerHidden]
			public AKNGDJAOGNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCEB0", Offset = "0x3DFBEB0", VA = "0x183DFCEB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD040", Offset = "0x3DFC040", VA = "0x183DFD040", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCFA0", Offset = "0x3DFBFA0", VA = "0x183DFCFA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCFA0", Offset = "0x3DFBFA0", VA = "0x183DFCFA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int FJIOPJMACML
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3E012A0", Offset = "0x3E002A0", VA = "0x183E012A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<ABNEAMNCIKF> LICNDCNFJOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3E01280", Offset = "0x3E00280", VA = "0x183E01280", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> ICNJNHFDMPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4E34A0", Offset = "0x4E24A0", VA = "0x1804E34A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MKEEHOHGPPL IMJHGMLANBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public PALPFNOFDFN DLPEHMPGEEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4E4390", Offset = "0x4E3390", VA = "0x1804E4390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(PALPFNOFDFN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x660220", Offset = "0x65F220", VA = "0x180660220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool NLIHEONJDCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E01290", Offset = "0x3E00290", VA = "0x183E01290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFC0", Offset = "0x3DFEFC0", VA = "0x183DFFFC0")]
		public static ClusterMeshRenderer Create(MKEEHOHGPPL DLNIEOMAIFB, ClusterMeshRenderer CCDDFKOFHML, MeshFilter BPIMNBABEMC, Transform HKCIGEFNNOB, PALPFNOFDFN BGAEFDGLOFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E000D0", Offset = "0x3DFF0D0", VA = "0x183E000D0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E00830", Offset = "0x3DFF830", VA = "0x183E00830", Slot = "10")]
		public bool TryRemoveClusterLODComponent(BGPDOMEBKNI INOINFMPGFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E00600", Offset = "0x3DFF600", VA = "0x183E00600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E00330", Offset = "0x3DFF330", VA = "0x183E00330")]
		public void Init(MKEEHOHGPPL DLNIEOMAIFB, MeshFilter BPIMNBABEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E00130", Offset = "0x3DFF130", VA = "0x183E00130")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E00960", Offset = "0x3DFF960", VA = "0x183E00960", Slot = "8")]
		public void UpdateClusterDistances(Vector3 BLEDLAABCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E00BA0", Offset = "0x3DFFBA0", VA = "0x183E00BA0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E002C0", Offset = "0x3DFF2C0", VA = "0x183E002C0")]
		[IteratorStateMachine(typeof(AKNGDJAOGNH))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E00680", Offset = "0x3DFF680", VA = "0x183E00680")]
		public void SetupTagAndLayer(string KNJNIJCHLLG, int BGAEFDGLOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E00660", Offset = "0x3DFF660", VA = "0x183E00660")]
		public bool Remove(BGPDOMEBKNI INOINFMPGFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC75CE0", Offset = "0xC74CE0", VA = "0x180C75CE0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IGIBCFKBOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int DLEBCDFHBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int IGAJMLAENFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int OAJACDBGGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JFCDFCMLCPF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E055E0", Offset = "0x3E045E0", VA = "0x183E055E0")]
	public IGIBCFKBOMF(int IGAJMLAENFA, int OAJACDBGGNK, int DLEBCDFHBEN, int JFCDFCMLCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NGEHOGGPEHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> IOPPBPHBOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> MHOIKLAMBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> HHGBINNENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<IGIBCFKBOMF> KKIKJFPKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> HGCMNMPEGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> LCGHGJOKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> KADGAEPNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle HPHFIHCMBCD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FICIMHHAHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1430", Offset = "0x6E0430", VA = "0x1806E1430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1450", Offset = "0x6E0450", VA = "0x1806E1450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C230", Offset = "0x3E0B230", VA = "0x183E0C230")]
	public void POLGAHHBJDF(EDMDJOLCDFN DJPKDOLOKHB, NativeList<IGIBCFKBOMF> KKIKJFPKJOI, float BLGFOCHPGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BFE0", Offset = "0x3E0AFE0", VA = "0x183E0BFE0")]
	public void NKCFHPJOFFN(Transform HKCIGEFNNOB, bool KKEAMFENCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BE20", Offset = "0x3E0AE20", VA = "0x183E0BE20")]
	public void GPJBLCCIGAA(MKEEHOHGPPL AJMDOGNODKP, bool NDNFOFIPICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BD50", Offset = "0x3E0AD50", VA = "0x183E0BD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BFB0", Offset = "0x3E0AFB0", VA = "0x183E0BFB0")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public NGEHOGGPEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct JJHIAEFAALP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> IOPPBPHBOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> MHOIKLAMBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<IGIBCFKBOMF> GMMFKBGBFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> HGCMNMPEGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 FOBCCPEDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> LCGHGJOKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> KADGAEPNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool KKEAMFENCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float DFNPBCMCNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float HFNJBJPDGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float HNHBNFCOHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> HHGBINNENKI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E07C80", Offset = "0x3E06C80", VA = "0x183E07C80")]
	public JJHIAEFAALP(NGEHOGGPEHL PDMPBFKANGD, Vector3 FOBCCPEDNKK, bool KKEAMFENCMC, float DFNPBCMCNFI, float HFNJBJPDGIF, float HNHBNFCOHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E077E0", Offset = "0x3E067E0", VA = "0x183E077E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BGPDOMEBKNI : JPDLHFDHKHA
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds AOGADJAEBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JHCPHBENKBF ONHHHNJFNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GHIKOHFHAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<BGPDOMEBKNI> PMPOKIAPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public GHIKOHFHAMN DOGKMHLECMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public GHIKOHFHAMN DHOAJNKNLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GHIKOHFHAMN EAIFMOGLLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int JFCDFCMLCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds DFKEBPEGDHN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E04340", Offset = "0x3E03340", VA = "0x183E04340")]
	public GHIKOHFHAMN(List<BGPDOMEBKNI> PMPOKIAPDCN, [Optional] GHIKOHFHAMN DOGKMHLECMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KJFFNKBIAKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<GHIKOHFHAMN> JMDMHLCKMGE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GHIKOHFHAMN FEOJFLNDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E08CF0", Offset = "0x3E07CF0", VA = "0x183E08CF0")]
	public KJFFNKBIAKI(GHIKOHFHAMN HKCIGEFNNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BPAMBINKNEP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct BLIKIEBEFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int JPFGAALKHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int BJBJKIAGKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int PKLNPHJAFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int AOPOLMJHFOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct ICMADDIALJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int CHEGOEJBIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float EBIMBHFFKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<BGPDOMEBKNI> PMPOKIAPDCN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum IIPDJBFAPBE
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
	private BLIKIEBEFLG NDNDMJNCJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int JFFJAGJBDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int FIAIBJFOFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KLAGBHBKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float HNILKPCMLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float KMHPIOLFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<GHIKOHFHAMN> IPDCKKDOHDC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KJFFNKBIAKI AEKEMOIHOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF540", Offset = "0x3DFE540", VA = "0x183DFF540")]
	public BPAMBINKNEP(int FIAIBJFOFGI, int KLAGBHBKNJL, float HNILKPCMLAN, int JFFJAGJBDHA, float KMHPIOLFOPH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD970", Offset = "0x3DFC970", VA = "0x183DFD970")]
	public void CJGKGHPACED(List<BGPDOMEBKNI> PMPOKIAPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE7D0", Offset = "0x3DFD7D0", VA = "0x183DFE7D0")]
	public bool LJECAPILDPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF430", Offset = "0x3DFE430", VA = "0x183DFF430")]
	private float NNMDFKFNDEA(Vector3 PABKDOMHIBA, Vector3 GDLKCENOMFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF390", Offset = "0x3DFE390", VA = "0x183DFF390")]
	private float NNMDFKFNDEA(Vector3 MMNEHHBHOKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDEC0", Offset = "0x3DFCEC0", VA = "0x183DFDEC0")]
	private bool IEMDGIMLLBJ(GHIKOHFHAMN KPEHPPDMKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE840", Offset = "0x3DFD840", VA = "0x183DFE840")]
	private ICMADDIALJL MOMJFHHMOCB(List<BGPDOMEBKNI> CGJILACCDDA, IIPDJBFAPBE ELBENCAEKIN)
	{
		return default(ICMADDIALJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDB30", Offset = "0x3DFCB30", VA = "0x183DFDB30")]
	private void HCMPFKAIPDD(List<BGPDOMEBKNI> PMPOKIAPDCN, Vector3[] JPKFNBMPBAM, Vector3[] KCBCMFFBMIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class AKONKBFMHMF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD090", Offset = "0x3DFC090", VA = "0x183DFD090")]
	public static Bounds EMDIHKHDMJJ(List<BGPDOMEBKNI> PMPOKIAPDCN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD240", Offset = "0x3DFC240", VA = "0x183DFD240")]
	public static int GBLGGAHCMIJ(List<BGPDOMEBKNI> PMPOKIAPDCN, BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LLFLNCCPDCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private EDMDJOLCDFN NJMHCNIMHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EDMDJOLCDFN BKDHICMIAPD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static EDMDJOLCDFN JDBNJLIJBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private FIBBIAAPDLL JCKHBHJJEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private BEEPDOCNEHB PGFNFBDGMHO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle HPHFIHCMBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA10", Offset = "0xB8AA10", VA = "0x180B8BA10")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB92570", Offset = "0xB91570", VA = "0x180B92570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MKEEHOHGPPL.JFNHADHOCOD KPEHPPDMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PMMNLFAKNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67C150", Offset = "0x67B150", VA = "0x18067C150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E08E10", Offset = "0x3E07E10", VA = "0x183E08E10")]
	[NECNNIDGOFF(IELBKHEMIMD.ExitingPlayMode, 0)]
	private void IGIJEIOPHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E09480", Offset = "0x3E08480", VA = "0x183E09480")]
	public void POLGAHHBJDF(MKEEHOHGPPL.JFNHADHOCOD GMMFKBGBFIJ, Transform BNONFMMJAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E08EC0", Offset = "0x3E07EC0", VA = "0x183E08EC0")]
	public void PIBMLBEHCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E08DA0", Offset = "0x3E07DA0", VA = "0x183E08DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E08E80", Offset = "0x3E07E80", VA = "0x183E08E80")]
	public void JFKIAFPDGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E09E00", Offset = "0x3E08E00", VA = "0x183E09E00")]
	public LLFLNCCPDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OABFINDGDDI
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DNHHPHGCGOD PLEPFHIHIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PHJBCPPJLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 LAAFOMKEAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NHECMKHHIMD
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ALGNGHCLHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EMFKJDPGCDN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action GBNFCBHKHCM;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LMBBPJENBPG
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMBBPJENBPG DLJOOMPHNLE(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMBBPJENBPG COHICJMIIOG(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LMBBPJENBPG PFCEFGCNJOE(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMBBPJENBPG JPBGKHGDIGE(Action PGICAAEJFJD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class KGFBBGDHMJA : LMBBPJENBPG
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class CHGOBCNJPCJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public KGFBBGDHMJA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public CHGOBCNJPCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x3DFFD50", Offset = "0x3DFED50", VA = "0x183DFFD50")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x3DFFDA0", Offset = "0x3DFEDA0", VA = "0x183DFFDA0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x3DFFDF0", Offset = "0x3DFEDF0", VA = "0x183DFFDF0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> FDCECLJDNCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action FBIPDFCNDEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action ECOCFNBFIPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private PLPNJJNLKEE IPPCEDIHHMH;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action DIIBGDJBJJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x50C0C0", Offset = "0x50B0C0", VA = "0x18050C0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5DE190", Offset = "0x5DD190", VA = "0x1805DE190")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action IEADIECHBOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3F20", Offset = "0x1EA2F20", VA = "0x181EA3F20", Slot = "4")]
			public LMBBPJENBPG DLJOOMPHNLE(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x270BD00", Offset = "0x270AD00", VA = "0x18270BD00", Slot = "5")]
			public LMBBPJENBPG COHICJMIIOG(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2786DE0", Offset = "0x2785DE0", VA = "0x182786DE0", Slot = "6")]
			public LMBBPJENBPG PFCEFGCNJOE(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62290", VA = "0x180D63290", Slot = "7")]
			public LMBBPJENBPG JPBGKHGDIGE(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5C53C0", Offset = "0x5C43C0", VA = "0x1805C53C0")]
			public KGFBBGDHMJA(Func<JobHandle> CCADCOLAFJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3E08960", Offset = "0x3E07960", VA = "0x183E08960")]
			public void CAICCIAKDBD(Action OFHPACPINNA, Action ILAAOINBOKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3E08B90", Offset = "0x3E07B90", VA = "0x183E08B90")]
			public void PMCHHOBKDIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class DFACPILHJJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public LMBBPJENBPG jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public DFACPILHJJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3E01300", Offset = "0x3E00300", VA = "0x183E01300")]
			internal bool <Remove>b__0(KGFBBGDHMJA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class PFHLPGBINNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public KGFBBGDHMJA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public PFHLPGBINNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3E0DC20", Offset = "0x3E0CC20", VA = "0x183E0DC20")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<KGFBBGDHMJA> HBMKHEGNHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<KGFBBGDHMJA> BIDEMAAJKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private LBEACJDEKDN KHMMNMOGPOA;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E07D50", Offset = "0x3E06D50", VA = "0x183E07D50")]
		public LMBBPJENBPG Add(Func<JobHandle> CCADCOLAFJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E07FF0", Offset = "0x3E06FF0", VA = "0x183E07FF0")]
		public void Remove(LMBBPJENBPG HPHFIHCMBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E07E70", Offset = "0x3E06E70", VA = "0x183E07E70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E08170", Offset = "0x3E07170", VA = "0x183E08170")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E08340", Offset = "0x3E07340", VA = "0x183E08340")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3E07E60", Offset = "0x3E06E60", VA = "0x183E07E60")]
		[CompilerGenerated]
		private void LFAFLLKCJJG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PLPNJJNLKEE
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLPNJJNLKEE DLJOOMPHNLE(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PLPNJJNLKEE KJHCAOCNCAK(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLPNJJNLKEE JPBGKHGDIGE(Action PGICAAEJFJD);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class IDIHJNDECIL : PLPNJJNLKEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle LDAJEOOEIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action FBIPDFCNDEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action GFEACOBGECJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action IEADIECHBOB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool CCGNLFKDAJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x3E05590", Offset = "0x3E04590", VA = "0x183E05590")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x270BD00", Offset = "0x270AD00", VA = "0x18270BD00", Slot = "4")]
			public PLPNJJNLKEE DLJOOMPHNLE(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2786DE0", Offset = "0x2785DE0", VA = "0x182786DE0", Slot = "5")]
			public PLPNJJNLKEE KJHCAOCNCAK(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62290", VA = "0x180D63290", Slot = "6")]
			public PLPNJJNLKEE JPBGKHGDIGE(Action PGICAAEJFJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xB8B9E0", Offset = "0xB8A9E0", VA = "0x180B8B9E0")]
			public IDIHJNDECIL(JobHandle NGBAHGGJFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3E05550", Offset = "0x3E04550", VA = "0x183E05550")]
			public void BCGFEGFKBJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3E055A0", Offset = "0x3E045A0", VA = "0x183E055A0")]
			public void PMCHHOBKDIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<IDIHJNDECIL> NOKCEHHCEBL;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3E087C0", Offset = "0x3E077C0", VA = "0x183E087C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3E08400", Offset = "0x3E07400", VA = "0x183E08400")]
		public PLPNJJNLKEE Add(JobHandle NGBAHGGJFDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3E086D0", Offset = "0x3E076D0", VA = "0x183E086D0")]
		public void Remove(PLPNJJNLKEE HPHFIHCMBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3E08570", Offset = "0x3E07570", VA = "0x183E08570", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3E08490", Offset = "0x3E07490", VA = "0x183E08490")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3E088D0", Offset = "0x3E078D0", VA = "0x183E088D0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DFIKEAFJCGD
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] FPMGPNDCJGI;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int HLAPLPHEDOF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int DIHDAAMIHIE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger CBFIPIFMBJA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DFIKEAFJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E01310", Offset = "0x3E00310", VA = "0x183E01310")]
	private static string FCGBJJFHIPJ(byte[] DJHKGFLFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3E01410", Offset = "0x3E00410", VA = "0x183E01410")]
	public static string JDIAMALCPMN(byte[] ONAFAFJGCAI, bool NMLDFLAABOD)
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
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
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
