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
				[Cpp2IlInjected.Address(RVA = "0x422F620", Offset = "0x422E620", VA = "0x18422F620")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x1979BA0", Offset = "0x1978BA0", VA = "0x181979BA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x422F5E0", Offset = "0x422E5E0", VA = "0x18422F5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4222A80", Offset = "0x4221A80", VA = "0x184222A80")]
		public LODSettings NBKGNNNDAOC(ABJFDOIBOPB ECNEJMHHLNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4222960", Offset = "0x4221960", VA = "0x184222960")]
		public int BAFJGCCNBNA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4222980", Offset = "0x4221980", VA = "0x184222980")]
		public int FJLPPPAHLEH(bool KGGPNHCGBIO, Vector3 NAJFBIBJCDK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4222A90", Offset = "0x4221A90", VA = "0x184222A90")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JAIFKEBDKAA
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
public interface GMNAJKEMGAA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAPMDEIFIFA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KHDFLBMFNPE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BDMDLNBELDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<MGPAGHMPPGI> HDNLBNOOMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JAIFKEBDKAA MDNPBLAEOCI
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
	void UpdateClusterDistances(Vector3 AOBOHODOFOM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(IAPDBFKLOFK MBDAGOAGDIP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGPAGHMPPGI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int BIDLHFGHKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int APFHKEPJOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float IKJFLLLBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float AHGHCFKEGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte INIMKHGLPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EKNCOAJCCJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GOEOAMBIGPB
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
	private sealed class HJDKEMKGFHD : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EKNCOAJCCJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public HJDKEMKGFHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x422D350", Offset = "0x422C350", VA = "0x18422D350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x422D410", Offset = "0x422C410", VA = "0x18422D410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NOHEPLJJNPG : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private OKFJJPCKHDN <>2__current;

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
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public NOHEPLJJNPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x422FF30", Offset = "0x422EF30", VA = "0x18422FF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4230080", Offset = "0x422F080", VA = "0x184230080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BFHKGBMOHJF : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EKNCOAJCCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<OKFJJPCKHDN> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public BFHKGBMOHJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4221E90", Offset = "0x4220E90", VA = "0x184221E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4222910", Offset = "0x4221910", VA = "0x184222910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ACKMAGLOFCE : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EKNCOAJCCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public ACKMAGLOFCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4220C10", Offset = "0x421FC10", VA = "0x184220C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4221B00", Offset = "0x4220B00", VA = "0x184221B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int DEOPJMPBEGJ = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer CPKLCHGGFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter AEJMPMPEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject PCFHBDGBIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LPKEDCMCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public PHJOOIPIJKL AALALAIKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<IAPDBFKLOFK> LONBHDFCFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<IAPDBFKLOFK> JKKOEOFOEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<IAPDBFKLOFK> FAECFJCEOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int OOPHKPDIIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GOEOAMBIGPB JHAIAMEFLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<KHDFLBMFNPE>[] DBHFIGMEEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<MGPAGHMPPGI>[] DDAOFAPCCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private PHEIIEMLJCG IKAIBDIGOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PHEIIEMLJCG AAPJHPHAHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PHEIIEMLJCG DAHMIHOIALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int AOODPHPDJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int DCCCGOABLPO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static EKNCOAJCCJN NFFECOKBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FNBFFOKIMFM KABKBJHBFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GPGBOJNFFBC KOKOOJGOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour ILNMNDHOEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material LPENCFBEFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<GMNAJKEMGAA> EOICNHMOGBL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig EJCLJNAKPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 EFONDHAFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x109AB50", Offset = "0x1099B50", VA = "0x18109AB50")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x109AA70", Offset = "0x1099A70", VA = "0x18109AA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private GOEOAMBIGPB LDEBNDLCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x536CD0", Offset = "0x535CD0", VA = "0x180536CD0")]
		get
		{
			return default(GOEOAMBIGPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x42256C0", Offset = "0x42246C0", VA = "0x1842256C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static EKNCOAJCCJN HGCFOCCEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4224DD0", Offset = "0x4223DD0", VA = "0x184224DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OMGEOKDIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4224C90", Offset = "0x4223C90", VA = "0x184224C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool FEHNBELDHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x42260C0", Offset = "0x42250C0", VA = "0x1842260C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LCKJNHNADDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x42255A0", Offset = "0x42245A0", VA = "0x1842255A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x42246E0", Offset = "0x42236E0", VA = "0x1842246E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action APNCIJLDALA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4226220", Offset = "0x4225220", VA = "0x184226220")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4225500", Offset = "0x4224500", VA = "0x184225500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4226B00", Offset = "0x4225B00", VA = "0x184226B00")]
	public EKNCOAJCCJN(FNBFFOKIMFM KABKBJHBFJE, GPGBOJNFFBC KOKOOJGOGLP, ClusterLODConfig CFMFPGFLAAN, MonoBehaviour ILNMNDHOEJG, Material LPENCFBEFJO, ClusterMeshRenderer CPKLCHGGFFF, MeshFilter AEJMPMPEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4224C00", Offset = "0x4223C00", VA = "0x184224C00")]
	private void EHHCFONEILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4224820", Offset = "0x4223820", VA = "0x184224820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4224F80", Offset = "0x4223F80", VA = "0x184224F80")]
	public static void FOBPOBMFDBM(Vector3 KGKANDPKMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4225A60", Offset = "0x4224A60", VA = "0x184225A60")]
	private void JOFFKBMBDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4226120", Offset = "0x4225120", VA = "0x184226120")]
	private void OCNFAAJNJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4225F80", Offset = "0x4224F80", VA = "0x184225F80")]
	private void MGCPOIEOGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4225B00", Offset = "0x4224B00", VA = "0x184225B00")]
	public void KBNNNMBLNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4225EA0", Offset = "0x4224EA0", VA = "0x184225EA0")]
	[IteratorStateMachine(typeof(HJDKEMKGFHD))]
	private IEnumerator<OKFJJPCKHDN> LMOPCBFGAKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4224780", Offset = "0x4223780", VA = "0x184224780")]
	[IteratorStateMachine(typeof(NOHEPLJJNPG))]
	private IEnumerator<OKFJJPCKHDN> DNGKLCGGNJI(Func<bool> EHLHCGPEFKO, float MCNLFKGPGGD, Func<string> CEIODEIIMCH, float FBKAHEBGFGB = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4225F10", Offset = "0x4224F10", VA = "0x184225F10")]
	[IteratorStateMachine(typeof(BFHKGBMOHJF))]
	private IEnumerator<OKFJJPCKHDN> MCNGMOJJIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42252F0", Offset = "0x42242F0", VA = "0x1842252F0")]
	public void GPIOKKJCLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4225E20", Offset = "0x4224E20", VA = "0x184225E20")]
	public void KFAHGKEMDGM(IEnumerable<KHDFLBMFNPE> MPLNHMBOIGM, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950")]
	public void EGOMPPELOKA(IEnumerable<KHDFLBMFNPE> MPLNHMBOIGM, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42262C0", Offset = "0x42252C0", VA = "0x1842262C0")]
	public List<ClusterMeshRenderer> OJIIBCAPKAM(List<IAPDBFKLOFK> LGJPFLLOFNF, Transform CJCHFFFELDO, JAIFKEBDKAA MANGBAHNIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42257F0", Offset = "0x42247F0", VA = "0x1842257F0")]
	public JAIFKEBDKAA JBANEBENDCN(Vector3 JDEDKBKPANF)
	{
		return default(JAIFKEBDKAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4225A00", Offset = "0x4224A00", VA = "0x184225A00")]
	public void JIADMBBIBDC(GMNAJKEMGAA ELAEFNCJOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4224640", Offset = "0x4223640", VA = "0x184224640")]
	public bool AEPFMCIICPF(GMNAJKEMGAA ELAEFNCJOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4226AA0", Offset = "0x4225AA0", VA = "0x184226AA0")]
	public void PFLNFIPIDHC(IAPDBFKLOFK IAFGNPEDDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4225640", Offset = "0x4224640", VA = "0x184225640")]
	public void IFKHLMDEKKF(MGPAGHMPPGI DHIIJPMDCBJ, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4224D10", Offset = "0x4223D10", VA = "0x184224D10")]
	public void ELCFBFEODIF(MGPAGHMPPGI DHIIJPMDCBJ, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4224E50", Offset = "0x4223E50", VA = "0x184224E50")]
	private void FLMFNNOHFPM(Vector3 AOBOHODOFOM, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4225180", Offset = "0x4224180", VA = "0x184225180")]
	private void GJKFMAEAAKC(Vector3 AOBOHODOFOM, JAIFKEBDKAA MANGBAHNIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4226A30", Offset = "0x4225A30", VA = "0x184226A30")]
	[IteratorStateMachine(typeof(ACKMAGLOFCE))]
	private IEnumerator<OKFJJPCKHDN> OLOHEJAJMGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4225010", Offset = "0x4224010", VA = "0x184225010")]
	private int GFIBGKGIBBG(int EKKABPEEACK, int EDOFHLCHDIP, List<MGPAGHMPPGI> NBIOFMDDMEF, byte ECNEJMHHLNH, ref int IMMLKDNEGGE, float NGELFJKLGIE = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4225830", Offset = "0x4224830", VA = "0x184225830")]
	public void JBOIIODGKNN(IAPDBFKLOFK MBDAGOAGDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4224D90", Offset = "0x4223D90", VA = "0x184224D90")]
	public bool FDGDPDEJHNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8F0", Offset = "0x5AB8F0", VA = "0x1805AC8F0")]
	public Material DNHCLJMJCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x42246A0", Offset = "0x42236A0", VA = "0x1842246A0")]
	public int BAFJGCCNBNA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4225DD0", Offset = "0x4224DD0", VA = "0x184225DD0")]
	[CompilerGenerated]
	private bool KDPIKDPECLA()
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
		[Cpp2IlInjected.Address(RVA = "0xD6F9B0", Offset = "0xD6E9B0", VA = "0x180D6F9B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EHJDNCFHKHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> ENLJNPEEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> JGLLICMFMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> CLGLEFLIKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> OHLJFPCHKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> LFADDJMKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> CIKHEPGIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> NFAFAGEIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 HAGFCBCEGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float JHCHEKCKPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> KJMLPAMGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> IOKMDDAIHKN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4224580", Offset = "0x4223580", VA = "0x184224580")]
	public EHJDNCFHKHP(AKGANDGEINC FILEFGGGGMO, NativeList<float3> NFAFAGEIICO, NativeMultiHashMap<int, int> KJMLPAMGAFP, NativeArray<int> IOKMDDAIHKN, Vector3 HAGFCBCEGGG, float JHCHEKCKPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4223E90", Offset = "0x4222E90", VA = "0x184223E90")]
	private int AMJEJJBHOOC(float3 AOBOHODOFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42242E0", Offset = "0x42232E0", VA = "0x1842242E0")]
	private int JBEMDHJDBDA(int BHMABHNBMJE, int ACPAGAEJCEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4223EF0", Offset = "0x4222EF0", VA = "0x184223EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKDEBJBHHCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> KJMLPAMGAFP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> IOKMDDAIHKN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int CLJKPGNNDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> HOHIEAHCHLM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x422FD70", Offset = "0x422ED70", VA = "0x18422FD70")]
	public void LBJLMOGJEEE(int DECEEKGFAOC, Allocator DDJLMPOGDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x422FCC0", Offset = "0x422ECC0", VA = "0x18422FCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public NKDEBJBHHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GANMPNNJPHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> GNBNKMAKHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> BLPLPINIIKI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x422A2A0", Offset = "0x42292A0", VA = "0x18422A2A0")]
	public GANMPNNJPHP(NKDEBJBHHCD AJPIACNIICO, AKGANDGEINC FILEFGGGGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x422A210", Offset = "0x4229210", VA = "0x18422A210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ENAPHPOGENP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> AEGELBDNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> DCAOKOMIJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> NDCALODNIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> OANBBEGKCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> AHKDDDJCIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> HOHIEAHCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> GNBNKMAKHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> KKGNMNFLHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> DHKJGGLEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> CHFJDEMOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> JMLIHCLILGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> IFMMOODNLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> OFGNHGKMLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float ANJLNDGONEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float CABAKOPPBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 ACJPOCADKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float GDLMDPCOCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float CJFNFHEJCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float CILLCACKBKH;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4228FE0", Offset = "0x4227FE0", VA = "0x184228FE0")]
	public ENAPHPOGENP(NKDEBJBHHCD BDFBEFOEIBF, AKGANDGEINC FILEFGGGGMO, AKGANDGEINC PJMNHFMKAFD, float CJFNFHEJCBI, float CILLCACKBKH, Vector3 ACJPOCADKJF, float GDLMDPCOCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4228770", Offset = "0x4227770", VA = "0x184228770")]
	private float3 MBJIPNFIKNK(int BHMABHNBMJE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4228C00", Offset = "0x4227C00", VA = "0x184228C00")]
	private void OHBNIPDBEBM(int BHMABHNBMJE, out float3 JLMIKHKOELK, out float3 GLDNMLFDPNE, out float4 BMNMPDPCEPB, out float4 MCFDBOBCBCA, out float2 PBADCJEPBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4227A00", Offset = "0x4226A00", VA = "0x184227A00")]
	private int EDIEFOHAGCL(int MGNLINOGKEG, int PCDPGJNIBNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4228DE0", Offset = "0x4227DE0", VA = "0x184228DE0")]
	private void OOOMCMBNBGN(int MGNLINOGKEG, int PCDPGJNIBNH, int BCHHKALFNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4228810", Offset = "0x4227810", VA = "0x184228810")]
	private bool NHKHACPBPKI(int MGNLINOGKEG, int PCDPGJNIBNH, float EEOCCPOMGBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x42286B0", Offset = "0x42276B0", VA = "0x1842286B0")]
	private bool HBLHBFOJNDB(int MGNLINOGKEG, int PCDPGJNIBNH, int BCHHKALFNEJ, float EEOCCPOMGBO, bool OPGEPKLKPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x42289A0", Offset = "0x42279A0", VA = "0x1842289A0")]
	private bool OBIOCOCMBAK(int MGNLINOGKEG, int PCDPGJNIBNH, int BCHHKALFNEJ, float EEOCCPOMGBO, bool OPGEPKLKPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4228690", Offset = "0x4227690", VA = "0x184228690")]
	private void GMHHAIOOLCK(int MGNLINOGKEG, int PCDPGJNIBNH, int BCHHKALFNEJ, out int MEDECLDADMB, out int CHELNILGBNI, out int OONBLEMOEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4227D30", Offset = "0x4226D30", VA = "0x184227D30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IKLNNECKHLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PPBAPNKDFEK : IDisposable, MGPAGHMPPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds IDFDMFFIPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<IAPDBFKLOFK> LGJPFLLOFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 CLNADJBJOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 LLOICKIBDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int PCAKOOGMAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AKGANDGEINC MFHNCDJKAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NKDEBJBHHCD PNDAMJBOPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform CJCHFFFELDO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int IEIFEFGCMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4231640", Offset = "0x4230640", VA = "0x184231640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh NBJAJGHACGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh BOEDAADJJCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x524010", Offset = "0x523010", VA = "0x180524010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x524020", Offset = "0x523020", VA = "0x180524020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IKJFLLLBJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x13E47D0", Offset = "0x13E37D0", VA = "0x1813E47D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1D795C0", Offset = "0x1D785C0", VA = "0x181D795C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte INIMKHGLPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x69FC50", Offset = "0x69EC50", VA = "0x18069FC50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x69FDE0", Offset = "0x69EDE0", VA = "0x18069FDE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BIDLHFGHKMO
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7074C0", Offset = "0x7064C0", VA = "0x1807074C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705B50", VA = "0x180706B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int APFHKEPJOFD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAEB4E0", Offset = "0xAEA4E0", VA = "0x180AEB4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD51080", Offset = "0xD50080", VA = "0x180D51080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float AHGHCFKEGGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x42317F0", Offset = "0x42307F0", VA = "0x1842317F0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x42310F0", Offset = "0x42300F0", VA = "0x1842310F0")]
		public void CHGIGIDFDLJ(ABJFDOIBOPB ECNEJMHHLNH, out int KPJKIBADMOJ, out int OPIDPBALBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4231810", Offset = "0x4230810", VA = "0x184231810")]
		public void IHCLNPOJDGC(ABJFDOIBOPB ECNEJMHHLNH, MLCLCJCONDF EMCBGKDPJIB, int JGDJMBAHABE = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4231320", Offset = "0x4230320", VA = "0x184231320")]
		public void DAMNLFKPPAP(NativeList<MKOCPODDIAM> GGAHOKJJKOB, Transform JEEGMCFFGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x42319B0", Offset = "0x42309B0", VA = "0x1842319B0")]
		public void KPOHFAICCOH(Mesh FILEFGGGGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4231A50", Offset = "0x4230A50", VA = "0x184231A50")]
		public void ONPOJIMFFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4231680", Offset = "0x4230680", VA = "0x184231680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4231AF0", Offset = "0x4230AF0", VA = "0x184231AF0")]
		public PPBAPNKDFEK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds IDFDMFFIPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<PPBAPNKDFEK> CLIHDAMFEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HCNFMNHIPAA KCJJJLNFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer JOBJBNJBKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int AIEGHKDCIFE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh ONMNNIFCJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54C0C0", Offset = "0x54B0C0", VA = "0x18054C0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x646A90", Offset = "0x645A90", VA = "0x180646A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CFMCKKENDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77AC20", Offset = "0x779C20", VA = "0x18077AC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77ACA0", Offset = "0x779CA0", VA = "0x18077ACA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BDMDLNBELDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x422D780", Offset = "0x422C780", VA = "0x18422D780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x422D5F0", Offset = "0x422C5F0", VA = "0x18422D5F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x422D750", Offset = "0x422C750", VA = "0x18422D750")]
	public int EGIABMFIEBD(int ILMBPBGKDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x422D460", Offset = "0x422C460", VA = "0x18422D460")]
	public void AIDMLGKIJJB(MOLPCIJHMMC EEPELFMFNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x422E170", Offset = "0x422D170", VA = "0x18422E170")]
	public void NBGFMJAAEOF(Transform JEEGMCFFGAG, bool GABGMDEIFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x422D7D0", Offset = "0x422C7D0", VA = "0x18422D7D0")]
	public bool GMFBKJKHNPB(bool OCPKLEDLCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x422D980", Offset = "0x422C980", VA = "0x18422D980")]
	public void IFEBOABDGIO(Transform CJCHFFFELDO, bool GABGMDEIFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x422DF10", Offset = "0x422CF10", VA = "0x18422DF10")]
	public bool JBOIIODGKNN(IAPDBFKLOFK MBDAGOAGDIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x422E880", Offset = "0x422D880", VA = "0x18422E880")]
	public IKLNNECKHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PHJOOIPIJKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<IKLNNECKHLH.PPBAPNKDFEK> JLMLOIPEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GAICDHIFACP ODMJNIPAJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<IKLNNECKHLH.PPBAPNKDFEK> LEMGDOGABOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int NFJAFGAEOOG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42307B0", Offset = "0x422F7B0", VA = "0x1842307B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4230820", Offset = "0x422F820", VA = "0x184230820")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x42308A0", Offset = "0x422F8A0", VA = "0x1842308A0")]
	public void IPMJFBAMOHP(IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ, Transform CJCHFFFELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4230950", Offset = "0x422F950", VA = "0x184230950")]
	public void JBOIIODGKNN(IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4230BF0", Offset = "0x422FBF0", VA = "0x184230BF0")]
	private IKLNNECKHLH.PPBAPNKDFEK LAOGONJNOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4230B60", Offset = "0x422FB60", VA = "0x184230B60")]
	private bool KBDFCIFMKAB(IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4230750", Offset = "0x422F750", VA = "0x184230750")]
	private void AGIDPEMIKAC(IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4230D20", Offset = "0x422FD20", VA = "0x184230D20")]
	public bool NMGMCFJBNBH(IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4230D60", Offset = "0x422FD60", VA = "0x184230D60")]
	public bool OKEBEOJEDHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4230B00", Offset = "0x422FB00", VA = "0x184230B00")]
	private IKLNNECKHLH.PPBAPNKDFEK JJDAMCFBCOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4230FB0", Offset = "0x422FFB0", VA = "0x184230FB0")]
	public PHJOOIPIJKL()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F9B0", Offset = "0xD6E9B0", VA = "0x180D6F9B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NOKDIAOCFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int IMAGOKEMKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int APLMJHHAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float OPPCICALLHP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<IKLNNECKHLH> OFAINDBDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4230620", Offset = "0x422F620", VA = "0x184230620")]
	public NOKDIAOCFHK(int IMAGOKEMKJA, int APLMJHHAGOO, float COCGJHBHODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42304E0", Offset = "0x422F4E0", VA = "0x1842304E0")]
	public void FPKKKMFAFGJ(KPEELECHKIP EHDPBDMACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4230580", Offset = "0x422F580", VA = "0x184230580")]
	private int GMLOJBHBCAK(MOLPCIJHMMC ODGFBBJPCEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42302B0", Offset = "0x422F2B0", VA = "0x1842302B0")]
	private void FPKKKMFAFGJ(MOLPCIJHMMC ODGFBBJPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42300D0", Offset = "0x422F0D0", VA = "0x1842300D0")]
	private void DBBLDGJBHOB(MOLPCIJHMMC ODGFBBJPCEB, IKLNNECKHLH CGHCPFONOAL)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, KHDFLBMFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HGGHEMOJCFK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6343E0", Offset = "0x6333E0", VA = "0x1806343E0")]
			[DebuggerHidden]
			public HGGHEMOJCFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x422D170", Offset = "0x422C170", VA = "0x18422D170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x422D300", Offset = "0x422C300", VA = "0x18422D300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x422D260", Offset = "0x422C260", VA = "0x18422D260", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x422D260", Offset = "0x422C260", VA = "0x18422D260", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int BDMDLNBELDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4223DD0", Offset = "0x4222DD0", VA = "0x184223DD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<MGPAGHMPPGI> HDNLBNOOMIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x4223DB0", Offset = "0x4222DB0", VA = "0x184223DB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> CLIHDAMFEDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IKLNNECKHLH ONMNNIFCJBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JAIFKEBDKAA MDNPBLAEOCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x524390", Offset = "0x523390", VA = "0x180524390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(JAIFKEBDKAA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x664E90", Offset = "0x663E90", VA = "0x180664E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool BMNCLCBKFMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4223DC0", Offset = "0x4222DC0", VA = "0x184223DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4222AF0", Offset = "0x4221AF0", VA = "0x184222AF0")]
		public static ClusterMeshRenderer Create(IKLNNECKHLH FILEFGGGGMO, ClusterMeshRenderer CPKLCHGGFFF, MeshFilter AEJMPMPEFEF, Transform CJCHFFFELDO, JAIFKEBDKAA MANGBAHNIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4222C00", Offset = "0x4221C00", VA = "0x184222C00", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4223360", Offset = "0x4222360", VA = "0x184223360", Slot = "10")]
		public bool TryRemoveClusterLODComponent(IAPDBFKLOFK MBDAGOAGDIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4223130", Offset = "0x4222130", VA = "0x184223130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4222E60", Offset = "0x4221E60", VA = "0x184222E60")]
		public void Init(IKLNNECKHLH FILEFGGGGMO, MeshFilter AEJMPMPEFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4222C60", Offset = "0x4221C60", VA = "0x184222C60")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4223490", Offset = "0x4222490", VA = "0x184223490", Slot = "8")]
		public void UpdateClusterDistances(Vector3 AOBOHODOFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x42236D0", Offset = "0x42226D0", VA = "0x1842236D0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4222DF0", Offset = "0x4221DF0", VA = "0x184222DF0")]
		[IteratorStateMachine(typeof(HGGHEMOJCFK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x42231B0", Offset = "0x42221B0", VA = "0x1842231B0")]
		public void SetupTagAndLayer(string JBMDEDFNMPJ, int MANGBAHNIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4223190", Offset = "0x4222190", VA = "0x184223190")]
		public bool Remove(IAPDBFKLOFK MBDAGOAGDIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD6F9B0", Offset = "0xD6E9B0", VA = "0x180D6F9B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NOFJLKDEOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int PIJEAJPHGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int JIBJAEPFHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int OPIDPBALBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int KPJKIBADMOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x422FF10", Offset = "0x422EF10", VA = "0x18422FF10")]
	public NOFJLKDEOMH(int JIBJAEPFHMH, int OPIDPBALBCN, int PIJEAJPHGHB, int KPJKIBADMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HCNFMNHIPAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> ENLJNPEEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> HOHIEAHCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> CIKHEPGIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<NOFJLKDEOMH> HGBIGAHJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> OIAHGEIPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> JCBJIMDMAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> JHPKHBOLBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle OCHCPBLAHMC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FKEKHHJDIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE40", Offset = "0x6EEE40", VA = "0x1806EFE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE60", Offset = "0x6EEE60", VA = "0x1806EFE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x422A560", Offset = "0x4229560", VA = "0x18422A560")]
	public void NHKFNHPJJEL(AKGANDGEINC GIHFCFICEGE, NativeList<NOFJLKDEOMH> HGBIGAHJNMO, float FCKGBFJBABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x422B2E0", Offset = "0x422A2E0", VA = "0x18422B2E0")]
	public void PGIMBNFEHND(Transform CJCHFFFELDO, bool GABGMDEIFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x422A3D0", Offset = "0x42293D0", VA = "0x18422A3D0")]
	public void GMFBKJKHNPB(IKLNNECKHLH JOBJBNJBKEE, bool OCPKLEDLCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x422A2D0", Offset = "0x42292D0", VA = "0x18422A2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x422A3A0", Offset = "0x42293A0", VA = "0x18422A3A0")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public HCNFMNHIPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct NBHIGBEMILJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> ENLJNPEEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> HOHIEAHCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<NOFJLKDEOMH> GCKHHLDAMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> OIAHGEIPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 ACJPOCADKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> JCBJIMDMAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> JHPKHBOLBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GABGMDEIFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float OMLDBCHLCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float ICPDDBKEHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float JCNPKHJBHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> CIKHEPGIILC;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x422FB60", Offset = "0x422EB60", VA = "0x18422FB60")]
	public NBHIGBEMILJ(HCNFMNHIPAA OMDLMNGKCIL, Vector3 ACJPOCADKJF, bool GABGMDEIFHE, float OMLDBCHLCJI, float ICPDDBKEHMA, float JCNPKHJBHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x422F6C0", Offset = "0x422E6C0", VA = "0x18422F6C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IAPDBFKLOFK : AFEEDLOKIJP
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds DNHAALABPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MKOCPODDIAM GHIOGNDGCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MOLPCIJHMMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<IAPDBFKLOFK> LGJPFLLOFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public MOLPCIJHMMC BMCODBFOLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public MOLPCIJHMMC FIJDCMOKFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public MOLPCIJHMMC EKOEENIFDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int KPJKIBADMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds IDFDMFFIPCF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x422F640", Offset = "0x422E640", VA = "0x18422F640")]
	public MOLPCIJHMMC(List<IAPDBFKLOFK> LGJPFLLOFNF, [Optional] MOLPCIJHMMC BMCODBFOLMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KPEELECHKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<MOLPCIJHMMC> PGPDCANLLME;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MOLPCIJHMMC CHMPCBBJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x422F530", Offset = "0x422E530", VA = "0x18422F530")]
	public KPEELECHKIP(MOLPCIJHMMC CJCHFFFELDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HGFKJPEOIDF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct FIHMPBNKDMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int DHHHPOEPPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int BLLJDHLEEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int GDNFKGKKKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int CPPJOENHCKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct FKDKAPJDHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int HIKDFPJFHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float PADNEMNHFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<IAPDBFKLOFK> LGJPFLLOFNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum DLDKJIGJKLL
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
	private FIHMPBNKDMC EKGMOOBFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int PNCOGFMPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int IMAGOKEMKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int APLMJHHAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float COCGJHBHODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float KABFFNANILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<MOLPCIJHMMC> IECODNBGHMA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KPEELECHKIP OBFAFHLDAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x422D110", Offset = "0x422C110", VA = "0x18422D110")]
	public HGFKJPEOIDF(int IMAGOKEMKJA, int APLMJHHAGOO, float COCGJHBHODE, int PNCOGFMPMFC, float KABFFNANILL = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x422CEE0", Offset = "0x422BEE0", VA = "0x18422CEE0")]
	public void GPJACCAGPIM(List<IAPDBFKLOFK> LGJPFLLOFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x422D0A0", Offset = "0x422C0A0", VA = "0x18422D0A0")]
	public bool KCFIPNFGCPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x422B8D0", Offset = "0x422A8D0", VA = "0x18422B8D0")]
	private float CKGCKKBGIPE(Vector3 AIGBMIKHPNK, Vector3 DHPKJINMPEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x422B9E0", Offset = "0x422A9E0", VA = "0x18422B9E0")]
	private float CKGCKKBGIPE(Vector3 BGJKLECOEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x422C5D0", Offset = "0x422B5D0", VA = "0x18422C5D0")]
	private bool FLLLHDEAANF(MOLPCIJHMMC FHGGAEBLEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x422BA80", Offset = "0x422AA80", VA = "0x18422BA80")]
	private FKDKAPJDHHN FGIHDHAMNPO(List<IAPDBFKLOFK> FNKJLJKJLJD, DLDKJIGJKLL FBFIEHPHLKL)
	{
		return default(FKDKAPJDHHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x422B540", Offset = "0x422A540", VA = "0x18422B540")]
	private void BMFKEFMHGJG(List<IAPDBFKLOFK> LGJPFLLOFNF, Vector3[] HEOBJJKIFOI, Vector3[] EFLDOOADJGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class AEEPOFIKJIP
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4221B50", Offset = "0x4220B50", VA = "0x184221B50")]
	public static Bounds FKOIGGLJOIE(List<IAPDBFKLOFK> LGJPFLLOFNF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4221D00", Offset = "0x4220D00", VA = "0x184221D00")]
	public static int JKGFLHIPKEO(List<IAPDBFKLOFK> LGJPFLLOFNF, ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GAICDHIFACP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AKGANDGEINC MFHOOLFABJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AKGANDGEINC EGLDHEIIGCH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static AKGANDGEINC FAICMMLFKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private LAPBCCOMLON LLGMAKKJGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MLCLCJCONDF EMCBGKDPJIB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle OCHCPBLAHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8574E0", Offset = "0x8564E0", VA = "0x1808574E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x857500", Offset = "0x856500", VA = "0x180857500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IKLNNECKHLH.PPBAPNKDFEK FHGGAEBLEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FDPNBPOHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x683CA0", Offset = "0x682CA0", VA = "0x180683CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4229120", Offset = "0x4228120", VA = "0x184229120")]
	[HNDGNKOOMOO(MBIOIPKMLMP.ExitingPlayMode, 0)]
	private void BJGNLHCKFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4229800", Offset = "0x4228800", VA = "0x184229800")]
	public void NHKFNHPJJEL(IKLNNECKHLH.PPBAPNKDFEK GCKHHLDAMCM, Transform MADCANFDKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4229240", Offset = "0x4228240", VA = "0x184229240")]
	public void FKIIFKKBAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4229190", Offset = "0x4228190", VA = "0x184229190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4229200", Offset = "0x4228200", VA = "0x184229200")]
	public void EMKEODJBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x422A180", Offset = "0x4229180", VA = "0x18422A180")]
	public GAICDHIFACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CLNGEKCALPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EKNCOAJCCJN EGGJOMNCANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GPGBOJNFFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 EJHPMPHADBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FNBFFOKIMFM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KCOHJPBGELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CIEDDKHDNLE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action OFEMKOLDCII;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CBLLNIJBKJL
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBLLNIJBKJL OFBDMONENNH(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBLLNIJBKJL NDPBOEAPGIN(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBLLNIJBKJL JNMPOPGECIK(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBLLNIJBKJL BIHFDBEJBLL(Action HCODLMJPEMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class ELEJHDKIJEF : CBLLNIJBKJL
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class OHNFFLOMHAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public ELEJHDKIJEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
				public OHNFFLOMHAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x4230670", Offset = "0x422F670", VA = "0x184230670")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x42306C0", Offset = "0x422F6C0", VA = "0x1842306C0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4230710", Offset = "0x422F710", VA = "0x184230710")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> ADNHMNDFHNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action BLHEEOJADIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action GHABFJPKJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private MEGFLBMNIOO GKCONJDOANA;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action OGPLGHLJABJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x54C0C0", Offset = "0x54B0C0", VA = "0x18054C0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x646A90", Offset = "0x645A90", VA = "0x180646A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action HHADKCKPOHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2404EE0", Offset = "0x2403EE0", VA = "0x182404EE0", Slot = "4")]
			public CBLLNIJBKJL OFBDMONENNH(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x26C9410", Offset = "0x26C8410", VA = "0x1826C9410", Slot = "5")]
			public CBLLNIJBKJL NDPBOEAPGIN(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2848580", Offset = "0x2847580", VA = "0x182848580", Slot = "6")]
			public CBLLNIJBKJL JNMPOPGECIK(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x15B7750", Offset = "0x15B6750", VA = "0x1815B7750", Slot = "7")]
			public CBLLNIJBKJL BIHFDBEJBLL(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x684A70", Offset = "0x683A70", VA = "0x180684A70")]
			public ELEJHDKIJEF(Func<JobHandle> EGAJKEINDMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x42271E0", Offset = "0x42261E0", VA = "0x1842271E0")]
			public void KFDFODBMCKG(Action BMGLJCPKCBF, Action OEOBHBMLGCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4227080", Offset = "0x4226080", VA = "0x184227080")]
			public void JBOIIODGKNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HDLEKECFOFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public CBLLNIJBKJL jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public HDLEKECFOFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x422B530", Offset = "0x422A530", VA = "0x18422B530")]
			internal bool <Remove>b__0(ELEJHDKIJEF a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class DNCIDIEIMPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public ELEJHDKIJEF newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public DNCIDIEIMPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4223E30", Offset = "0x4222E30", VA = "0x184223E30")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<ELEJHDKIJEF> DKDGBELHJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<ELEJHDKIJEF> HELBLHAIOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private PHEIIEMLJCG AGFEMOGCEEA;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x422E920", Offset = "0x422D920", VA = "0x18422E920")]
		public CBLLNIJBKJL Add(Func<JobHandle> EGAJKEINDMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x422EBC0", Offset = "0x422DBC0", VA = "0x18422EBC0")]
		public void Remove(CBLLNIJBKJL OCHCPBLAHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x422EA30", Offset = "0x422DA30", VA = "0x18422EA30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x422ED40", Offset = "0x422DD40", VA = "0x18422ED40")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x422EF10", Offset = "0x422DF10", VA = "0x18422EF10")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x422EBB0", Offset = "0x422DBB0", VA = "0x18422EBB0")]
		[CompilerGenerated]
		private void PNANBHAGAEE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MEGFLBMNIOO
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEGFLBMNIOO OFBDMONENNH(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEGFLBMNIOO KGNIFIBPGOH(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MEGFLBMNIOO BIHFDBEJBLL(Action HCODLMJPEMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class NCLBAOBNPML : MEGFLBMNIOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle BJLLGINCIML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action BLHEEOJADIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action IMMNDEHLPFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action HHADKCKPOHI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool FGOBIOLNBAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x422FCB0", Offset = "0x422ECB0", VA = "0x18422FCB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x26C9410", Offset = "0x26C8410", VA = "0x1826C9410", Slot = "4")]
			public MEGFLBMNIOO OFBDMONENNH(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2848580", Offset = "0x2847580", VA = "0x182848580", Slot = "5")]
			public MEGFLBMNIOO KGNIFIBPGOH(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x15B7750", Offset = "0x15B6750", VA = "0x1815B7750", Slot = "6")]
			public MEGFLBMNIOO BIHFDBEJBLL(Action HCODLMJPEMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC81200", Offset = "0xC80200", VA = "0x180C81200")]
			public NCLBAOBNPML(JobHandle KIEAALANHGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x422FC30", Offset = "0x422EC30", VA = "0x18422FC30")]
			public void GJKAPAPOEHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x422FC70", Offset = "0x422EC70", VA = "0x18422FC70")]
			public void JBOIIODGKNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<NCLBAOBNPML> OOHFHGCCMOK;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x422F390", Offset = "0x422E390", VA = "0x18422F390")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x422EFD0", Offset = "0x422DFD0", VA = "0x18422EFD0")]
		public MEGFLBMNIOO Add(JobHandle KIEAALANHGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x422F2A0", Offset = "0x422E2A0", VA = "0x18422F2A0")]
		public void Remove(MEGFLBMNIOO OCHCPBLAHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x422F140", Offset = "0x422E140", VA = "0x18422F140", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x422F060", Offset = "0x422E060", VA = "0x18422F060")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x422F4A0", Offset = "0x422E4A0", VA = "0x18422F4A0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4227740", Offset = "0x4226740", VA = "0x184227740")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4227410", Offset = "0x4226410", VA = "0x184227410")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
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
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
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
