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
				[Cpp2IlInjected.Address(RVA = "0x3B63720", Offset = "0x3B61F20", VA = "0x183B63720")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x886AD0", Offset = "0x8852D0", VA = "0x180886AD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3B636E0", Offset = "0x3B61EE0", VA = "0x183B636E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B57D20", Offset = "0x3B56520", VA = "0x183B57D20")]
		public LODSettings PCJEIFDCDHA(NEMIOKPMGJC LGLCJGAGAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3B57C00", Offset = "0x3B56400", VA = "0x183B57C00")]
		public int AJMHGNMHBLB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3B57C20", Offset = "0x3B56420", VA = "0x183B57C20")]
		public int KIDGNPNOJOD(bool GKMOLDCMBCP, Vector3 PGDJKANLBPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3B57D30", Offset = "0x3B56530", VA = "0x183B57D30")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HNJGHGOBGNF
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
public interface EHEFPKMLOKN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKPAIFAJIBC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PGILDLJJKOG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DMIPNDKPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<DPFLNHGMNFH> DIJPHKECPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HNJGHGOBGNF LIGDAMADCDL
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
	void UpdateClusterDistances(Vector3 PHONGPMEEAJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(NDHHMAGGOLL NHGFCDFBGDF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DPFLNHGMNFH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int DNFCDLLBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int BHHIKGDNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float EPJIEHOLCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JBPJNIECNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte FDJHKBKFIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LKGKGDGCONB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LOJELKDNLLE
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
	private sealed class OILFECKJDHD : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LKGKGDGCONB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public OILFECKJDHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B65400", Offset = "0x3B63C00", VA = "0x183B65400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B654B0", Offset = "0x3B63CB0", VA = "0x183B654B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IKMOFHIEBKB : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private OPGJILMPEBL <>2__current;

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
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public IKMOFHIEBKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CA30", Offset = "0x3B5B230", VA = "0x183B5CA30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CB80", Offset = "0x3B5B380", VA = "0x183B5CB80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BKAEENAJNAL : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LKGKGDGCONB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<OPGJILMPEBL> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public BKAEENAJNAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3B56000", Offset = "0x3B54800", VA = "0x183B56000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B569F0", Offset = "0x3B551F0", VA = "0x183B569F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LOCFIKEINAN : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public LKGKGDGCONB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public LOCFIKEINAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3B62800", Offset = "0x3B61000", VA = "0x183B62800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3B63690", Offset = "0x3B61E90", VA = "0x183B63690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int IKKECFAOANI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer AKOJEOCNBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter HDPKMHGDAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject PPCGHPNNDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OEIHMJPMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public PCGHDANFDDN EOOHMCFCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<NDHHMAGGOLL> OEFOOLKPIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NDHHMAGGOLL> OGPPBPBKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NDHHMAGGOLL> ICJMANLIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int PGMFCKFFGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LOJELKDNLLE OKCHBLAGPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<PGILDLJJKOG>[] EBGNDCMMKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<DPFLNHGMNFH>[] CGKGALMBHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private PMAFHAMHOLN ADFIHFFNGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PMAFHAMHOLN HCEEDNGDMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PMAFHAMHOLN LKKNCEMFPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int DHFLHAABGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int JGKELGMNAOL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static LKGKGDGCONB PPPBOCKACHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BILFPGJAOJO GIPEIFMACHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PNKGFCCIKBI CPCPIHMALFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour GOJEIMFHIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material IAOLHEDLGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<EHEFPKMLOKN> HHDFBMFJLDB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig DKPCPIBPHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 NGFNPOBGMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x577350", Offset = "0x575B50", VA = "0x180577350")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x575BA0", Offset = "0x5743A0", VA = "0x180575BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LOJELKDNLLE FLBOOILCDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x527DD0", Offset = "0x5265D0", VA = "0x180527DD0")]
		get
		{
			return default(LOJELKDNLLE);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B60240", Offset = "0x3B5EA40", VA = "0x183B60240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LKGKGDGCONB LFFPMMLBFND
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B603B0", Offset = "0x3B5EBB0", VA = "0x183B603B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool CALCIBHEBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B61290", Offset = "0x3B5FA90", VA = "0x183B61290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CONLHJHFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B601E0", Offset = "0x3B5E9E0", VA = "0x183B601E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LIOAPKGDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B622E0", Offset = "0x3B60AE0", VA = "0x183B622E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B61FC0", Offset = "0x3B607C0", VA = "0x183B61FC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FABJGEAMCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B61020", Offset = "0x3B5F820", VA = "0x183B61020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B60C80", Offset = "0x3B5F480", VA = "0x183B60C80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B62380", Offset = "0x3B60B80", VA = "0x183B62380")]
	public LKGKGDGCONB(BILFPGJAOJO GIPEIFMACHI, PNKGFCCIKBI CPCPIHMALFG, ClusterLODConfig MDHBOGHOIAO, MonoBehaviour GOJEIMFHIPP, Material IAOLHEDLGIG, ClusterMeshRenderer AKOJEOCNBNH, MeshFilter HDPKMHGDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B62060", Offset = "0x3B60860", VA = "0x183B62060")]
	private void OEFFIGFLALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B60D80", Offset = "0x3B5F580", VA = "0x183B60D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B61790", Offset = "0x3B5FF90", VA = "0x183B61790")]
	public static void LACLPGEGLLN(Vector3 OGDMOPEPMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B61F40", Offset = "0x3B60740", VA = "0x183B61F40")]
	private void NOFGCPODBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B60F20", Offset = "0x3B5F720", VA = "0x183B60F20")]
	private void EDDOCMMMPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B60430", Offset = "0x3B5EC30", VA = "0x183B60430")]
	private void CECPIHODJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A30", Offset = "0x3B60230", VA = "0x183B61A30")]
	public void LKJEMBBPPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B61150", Offset = "0x3B5F950", VA = "0x183B61150")]
	[IteratorStateMachine(typeof(OILFECKJDHD))]
	private IEnumerator<OPGJILMPEBL> HPNFOPGEBMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B610C0", Offset = "0x3B5F8C0", VA = "0x183B610C0")]
	[IteratorStateMachine(typeof(IKMOFHIEBKB))]
	private IEnumerator<OPGJILMPEBL> HJONPGGJHPK(Func<bool> OOKPGPEBHEP, float PFLJKPKAOKJ, Func<string> MHAIOMJNINL, float MIDAMJKNAKL = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B60180", Offset = "0x3B5E980", VA = "0x183B60180")]
	[IteratorStateMachine(typeof(BKAEENAJNAL))]
	private IEnumerator<OPGJILMPEBL> AKDKFJJMDNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B61820", Offset = "0x3B60020", VA = "0x183B61820")]
	public void LIBKAPFFHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B611B0", Offset = "0x3B5F9B0", VA = "0x183B611B0")]
	public void IBFFLOKIEGH(IEnumerable<PGILDLJJKOG> PIDOMHPMOBK, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B61480", Offset = "0x3B5FC80", VA = "0x183B61480")]
	public void JMAGPCNHKEH(IEnumerable<PGILDLJJKOG> PIDOMHPMOBK, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B60540", Offset = "0x3B5ED40", VA = "0x183B60540")]
	public List<ClusterMeshRenderer> CIFCFMDNFCL(List<NDHHMAGGOLL> AOPLIANOLPB, Transform LHEBAIHADCN, HNJGHGOBGNF HAJKCKBPKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B61F00", Offset = "0x3B60700", VA = "0x183B61F00")]
	public HNJGHGOBGNF NMHMLAHFFMD(Vector3 OMLMCLDLDBN)
	{
		return default(HNJGHGOBGNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B61EA0", Offset = "0x3B606A0", VA = "0x183B61EA0")]
	public void MNMDMCBECIH(EHEFPKMLOKN GLILJHHOLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3B61230", Offset = "0x3B5FA30", VA = "0x183B61230")]
	public bool IEHGGMABBPI(EHEFPKMLOKN GLILJHHOLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3B61730", Offset = "0x3B5FF30", VA = "0x183B61730")]
	public void KJGGIEJFDCP(NDHHMAGGOLL IFFOEBADHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B60EA0", Offset = "0x3B5F6A0", VA = "0x183B60EA0")]
	public void ECCBIPGODIB(DPFLNHGMNFH KJCEMNLPKKJ, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B62260", Offset = "0x3B60A60", VA = "0x183B62260")]
	public void PCIMKOBBBDP(DPFLNHGMNFH KJCEMNLPKKJ, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B60020", Offset = "0x3B5E820", VA = "0x183B60020")]
	private void AEPOIMKGFAN(Vector3 PHONGPMEEAJ, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B61310", Offset = "0x3B5FB10", VA = "0x183B61310")]
	private void JKBPPADLLNC(Vector3 PHONGPMEEAJ, HNJGHGOBGNF HAJKCKBPKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B60D20", Offset = "0x3B5F520", VA = "0x183B60D20")]
	[IteratorStateMachine(typeof(LOCFIKEINAN))]
	private IEnumerator<OPGJILMPEBL> DPALELMIJKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B620F0", Offset = "0x3B608F0", VA = "0x183B620F0")]
	private int PCIJKAJKKPE(int MPFKOFCNLNB, int IJIGOBJHBDC, List<DPFLNHGMNFH> CNLICBGLNCB, byte LGLCJGAGAEP, ref int NOBJLJDKLKJ, float NGEAMLMDBGA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B61CD0", Offset = "0x3B604D0", VA = "0x183B61CD0")]
	public void MEHJLGGLJCP(NDHHMAGGOLL NHGFCDFBGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B60C40", Offset = "0x3B5F440", VA = "0x183B60C40")]
	public bool DBINJJMKAND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x548640", Offset = "0x546E40", VA = "0x180548640")]
	public Material PDPCDDLGIKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B60140", Offset = "0x3B5E940", VA = "0x183B60140")]
	public int AJMHGNMHBLB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B60360", Offset = "0x3B5EB60", VA = "0x183B60360")]
	[CompilerGenerated]
	private bool AOBJIAOBDED()
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
		[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct PILDDCJGNNF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> NLPBHPGJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> OAKJEBAFCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> OHACNBJPPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> AFENDNEHPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> EMPCPDKFGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> MEKOFMMICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> FHFDANOIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 PFMHAOJJBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float NADCFFMCGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> HEMOPNPDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> GHLEFMJFEHJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3B66610", Offset = "0x3B64E10", VA = "0x183B66610")]
	public PILDDCJGNNF(BBALKBLIGPE IFPHMJDNGCM, NativeList<float3> FHFDANOIDPK, NativeMultiHashMap<int, int> HEMOPNPDMNI, NativeArray<int> GHLEFMJFEHJ, Vector3 PFMHAOJJBKB, float NADCFFMCGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B65F20", Offset = "0x3B64720", VA = "0x183B65F20")]
	private int AHOOBCGNBLN(float3 PHONGPMEEAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B66370", Offset = "0x3B64B70", VA = "0x183B66370")]
	private int IICFACJAHHB(int FFMHFGAHPLF, int PONAFPGHKNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B65F80", Offset = "0x3B64780", VA = "0x183B65F80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GBDGCCNMBNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> HEMOPNPDMNI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> GHLEFMJFEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int JFALAPOGBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> JEHHKCNFEMG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AE30", Offset = "0x3B59630", VA = "0x183B5AE30")]
	public void ONKEGPIFEPA(int NELLGOHPCCK, Allocator DCKLODCHAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AD80", Offset = "0x3B59580", VA = "0x183B5AD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public GBDGCCNMBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IFODGGKBDBI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LHCPKGOIDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> AKCBJCHGIID;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CA00", Offset = "0x3B5B200", VA = "0x183B5CA00")]
	public IFODGGKBDBI(GBDGCCNMBNM EPHPGLCDLPN, BBALKBLIGPE IFPHMJDNGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C970", Offset = "0x3B5B170", VA = "0x183B5C970", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DOMADDEKGLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> BILOEAPBIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> JEDFPDGDJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> GNBFHEDJDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> KHIBGHJECMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> NKKCNNGCKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> JEHHKCNFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LHCPKGOIDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> BCPOGFCCBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> HDEDJCKJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> GHHEFFALEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> KCGDHKAOJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> NCLPKEJCHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> MBIIIECAMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float GFHFGHFJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float POHJHIPIECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 KHMLMJNGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float INBEPNDFMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float JPFOHHAGGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float LKLHGOPMJHM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A6E0", Offset = "0x3B58EE0", VA = "0x183B5A6E0")]
	public DOMADDEKGLJ(GBDGCCNMBNM BLNFONIPJCC, BBALKBLIGPE IFPHMJDNGCM, BBALKBLIGPE DDHNEBCLLIP, float JPFOHHAGGMM, float LKLHGOPMJHM, Vector3 KHMLMJNGEGF, float INBEPNDFMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A250", Offset = "0x3B58A50", VA = "0x183B5A250")]
	private float3 GDMFKOFFJMI(int FFMHFGAHPLF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3B59430", Offset = "0x3B57C30", VA = "0x183B59430")]
	private void DNMIIKDNJDA(int FFMHFGAHPLF, out float3 EOODKHFFAGH, out float3 PMFNBDNBPDD, out float4 FECLHPFNOJP, out float4 FGNDBKENBJC, out float2 KJECDFMBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B59100", Offset = "0x3B57900", VA = "0x183B59100")]
	private int ABPLENNKHHH(int JHIAECKODLA, int MMINEFFIHDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3B59F90", Offset = "0x3B58790", VA = "0x183B59F90")]
	private void FEBEDBECKMN(int JHIAECKODLA, int MMINEFFIHDE, int BLKPJCNJIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A550", Offset = "0x3B58D50", VA = "0x183B5A550")]
	private bool ONNKNIBHFBF(int JHIAECKODLA, int MMINEFFIHDE, float ALLPIFCACJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A190", Offset = "0x3B58990", VA = "0x183B5A190")]
	private bool FKDKPBKPGPJ(int JHIAECKODLA, int MMINEFFIHDE, int BLKPJCNJIJL, float ALLPIFCACJM, bool EAEBDKAKBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A2F0", Offset = "0x3B58AF0", VA = "0x183B5A2F0")]
	private bool HMOGABKDOFE(int JHIAECKODLA, int MMINEFFIHDE, int BLKPJCNJIJL, float ALLPIFCACJM, bool EAEBDKAKBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3B59610", Offset = "0x3B57E10", VA = "0x183B59610")]
	private void ELBGIIMGLAB(int JHIAECKODLA, int MMINEFFIHDE, int BLKPJCNJIJL, out int OBOLIDNGKGM, out int IFOOCOBOMDJ, out int COBDOFLNLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3B59630", Offset = "0x3B57E30", VA = "0x183B59630", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GFNKFIPOPDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KCMHKMMECPD : IDisposable, DPFLNHGMNFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds NEHFEFOGHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<NDHHMAGGOLL> AOPLIANOLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 BICJGPNBABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 LNIMOEAKMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int PKKJPBHCGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BBALKBLIGPE GNHHLDGFMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GBDGCCNMBNM MLGHDDBDJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform LHEBAIHADCN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int NMLGGDIDFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3B5FF20", Offset = "0x3B5E720", VA = "0x183B5FF20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh NIHFMLBDAGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh OJHHFJCFBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD40", Offset = "0x4DA540", VA = "0x1804DBD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD80", Offset = "0x4DA580", VA = "0x1804DBD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EPJIEHOLCKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC2CCB0", Offset = "0xC2B4B0", VA = "0x180C2CCB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x12EEED0", Offset = "0x12ED6D0", VA = "0x1812EEED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte FDJHKBKFIIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x59A270", Offset = "0x598A70", VA = "0x18059A270")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x833160", Offset = "0x831960", VA = "0x180833160", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DNFCDLLBFFM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A30", Offset = "0x5E7230", VA = "0x1805E8A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x937000", Offset = "0x935800", VA = "0x180937000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BHHIKGDNAOH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A20", Offset = "0x5E7220", VA = "0x1805E8A20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9370D0", Offset = "0x9358D0", VA = "0x1809370D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float JBPJNIECNIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3B5FF60", Offset = "0x3B5E760", VA = "0x183B5FF60", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F930", Offset = "0x3B5E130", VA = "0x183B5F930")]
		public void FOGOJJNIALN(NEMIOKPMGJC LGLCJGAGAEP, out int FPGPDEPIKPG, out int BJHAOJJACKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F650", Offset = "0x3B5DE50", VA = "0x183B5F650")]
		public void DFMKKOMEPKA(NEMIOKPMGJC LGLCJGAGAEP, PMMHIBIOLKN KBLFEOAKGAA, int JNIJNHBIDBB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FC00", Offset = "0x3B5E400", VA = "0x183B5FC00")]
		public void HMEPKBMOGOF(NativeList<JFNGNGFNHLC> MJLIEHPHCIB, Transform OOJBNDMOHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FB60", Offset = "0x3B5E360", VA = "0x183B5FB60")]
		public void HIPIFDJKPKI(Mesh IFPHMJDNGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F5C0", Offset = "0x3B5DDC0", VA = "0x183B5F5C0")]
		public void APCMNMOCHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F7F0", Offset = "0x3B5DFF0", VA = "0x183B5F7F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FF80", Offset = "0x3B5E780", VA = "0x183B5FF80")]
		public KCMHKMMECPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds NEHFEFOGHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<KCMHKMMECPD> ONMHOKBBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public CCJDBDEFHHN LGDDHPCGJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer CMAHILOLIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int ADOIAACNKFK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh LOJJJEPAAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4DBDA0", Offset = "0x4DA5A0", VA = "0x1804DBDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD30", Offset = "0x4DA530", VA = "0x1804DBD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IALJLJMBINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5A3730", Offset = "0x5A1F30", VA = "0x1805A3730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5A3740", Offset = "0x5A1F40", VA = "0x1805A3740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DMIPNDKPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C330", Offset = "0x3B5AB30", VA = "0x183B5C330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B860", Offset = "0x3B5A060", VA = "0x183B5B860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C300", Offset = "0x3B5AB00", VA = "0x183B5C300")]
	public int OBBDPEFEHJJ(int FPLCFOFFPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B710", Offset = "0x3B59F10", VA = "0x183B5B710")]
	public void DOOPHJGJEOI(DDNIHEDGNDB ANDADMCAGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3B5BC00", Offset = "0x3B5A400", VA = "0x183B5BC00")]
	public void MKAOPDDGDAI(Transform OOJBNDMOHID, bool LCGNIEGIDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B560", Offset = "0x3B59D60", VA = "0x183B5B560")]
	public bool DDFNJKAOOGM(bool OCLBCINMMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AFD0", Offset = "0x3B597D0", VA = "0x183B5AFD0")]
	public void AHNLGOODMKP(Transform LHEBAIHADCN, bool LCGNIEGIDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B9A0", Offset = "0x3B5A1A0", VA = "0x183B5B9A0")]
	public bool MEHJLGGLJCP(NDHHMAGGOLL NHGFCDFBGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C380", Offset = "0x3B5AB80", VA = "0x183B5C380")]
	public GFNKFIPOPDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PCGHDANFDDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<GFNKFIPOPDK.KCMHKMMECPD> LIBIPJGBMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MCPNNNKOAPK CKMBNIIELNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<GFNKFIPOPDK.KCMHKMMECPD> IBCPLENIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int MOGPIHKNLLF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B655F0", Offset = "0x3B63DF0", VA = "0x183B655F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B658F0", Offset = "0x3B640F0", VA = "0x183B658F0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B65970", Offset = "0x3B64170", VA = "0x183B65970")]
	public void GMBMAEFCBMN(GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL, Transform LHEBAIHADCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B65AD0", Offset = "0x3B642D0", VA = "0x183B65AD0")]
	public void MEHJLGGLJCP(GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B65C60", Offset = "0x3B64460", VA = "0x183B65C60")]
	private GFNKFIPOPDK.KCMHKMMECPD OGMGLABJBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B65560", Offset = "0x3B63D60", VA = "0x183B65560")]
	private bool DCLLFJBNFJD(GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B65A10", Offset = "0x3B64210", VA = "0x183B65A10")]
	private void HCOGOMNLCBA(GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B65660", Offset = "0x3B63E60", VA = "0x183B65660")]
	public bool FEICDJPGEAE(GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B656A0", Offset = "0x3B63EA0", VA = "0x183B656A0")]
	public bool GEBMKMPLJAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B65A70", Offset = "0x3B64270", VA = "0x183B65A70")]
	private GFNKFIPOPDK.KCMHKMMECPD JAEMFFPLCPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B65D90", Offset = "0x3B64590", VA = "0x183B65D90")]
	public PCGHDANFDDN()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EFDIEMOFLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int LPHAIOLOENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int FOHHIOGBDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float FAFNAPNPLKA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<GFNKFIPOPDK> FCJMFHBNDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AD30", Offset = "0x3B59530", VA = "0x183B5AD30")]
	public EFDIEMOFLGK(int LPHAIOLOENI, int FOHHIOGBDNL, float LFKEHGMKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A8C0", Offset = "0x3B590C0", VA = "0x183B5A8C0")]
	public void HOBAMGONJNI(KANKFPGEOJC EMCJEHKBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A820", Offset = "0x3B59020", VA = "0x183B5A820")]
	private int BOGGMKGADPE(DDNIHEDGNDB BMIEINLMCHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A950", Offset = "0x3B59150", VA = "0x183B5A950")]
	private void HOBAMGONJNI(DDNIHEDGNDB BMIEINLMCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AB70", Offset = "0x3B59370", VA = "0x183B5AB70")]
	private void NAHLGLOKMAA(DDNIHEDGNDB BMIEINLMCHG, GFNKFIPOPDK DDPFFMPDJGG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, PGILDLJJKOG
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class IONLGFEHPID : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7748B0", Offset = "0x7730B0", VA = "0x1807748B0")]
			[DebuggerHidden]
			public IONLGFEHPID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3B5CBD0", Offset = "0x3B5B3D0", VA = "0x183B5CBD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3B5CD50", Offset = "0x3B5B550", VA = "0x183B5CD50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3B5CCB0", Offset = "0x3B5B4B0", VA = "0x183B5CCB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3B5CCB0", Offset = "0x3B5B4B0", VA = "0x183B5CCB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int DMIPNDKPNEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3B59030", Offset = "0x3B57830", VA = "0x183B59030", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<DPFLNHGMNFH> DIJPHKECPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3B59010", Offset = "0x3B57810", VA = "0x183B59010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> ONMHOKBBJAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4D7820", Offset = "0x4D6020", VA = "0x1804D7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public GFNKFIPOPDK LOJJJEPAAMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public HNJGHGOBGNF LIGDAMADCDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x62CF40", Offset = "0x62B740", VA = "0x18062CF40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(HNJGHGOBGNF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x632090", Offset = "0x630890", VA = "0x180632090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool LAOJACBKABF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B59020", Offset = "0x3B57820", VA = "0x183B59020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B57D90", Offset = "0x3B56590", VA = "0x183B57D90")]
		public static ClusterMeshRenderer Create(GFNKFIPOPDK IFPHMJDNGCM, ClusterMeshRenderer AKOJEOCNBNH, MeshFilter HDPKMHGDAOB, Transform LHEBAIHADCN, HNJGHGOBGNF HAJKCKBPKBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B57EA0", Offset = "0x3B566A0", VA = "0x183B57EA0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B585D0", Offset = "0x3B56DD0", VA = "0x183B585D0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(NDHHMAGGOLL NHGFCDFBGDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B583A0", Offset = "0x3B56BA0", VA = "0x183B583A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B58100", Offset = "0x3B56900", VA = "0x183B58100")]
		public void Init(GFNKFIPOPDK IFPHMJDNGCM, MeshFilter HDPKMHGDAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B57F00", Offset = "0x3B56700", VA = "0x183B57F00")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B58700", Offset = "0x3B56F00", VA = "0x183B58700", Slot = "8")]
		public void UpdateClusterDistances(Vector3 PHONGPMEEAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B58940", Offset = "0x3B57140", VA = "0x183B58940", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B58090", Offset = "0x3B56890", VA = "0x183B58090")]
		[IteratorStateMachine(typeof(IONLGFEHPID))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B58420", Offset = "0x3B56C20", VA = "0x183B58420")]
		public void SetupTagAndLayer(string NEOEGGNNCOO, int HAJKCKBPKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B58400", Offset = "0x3B56C00", VA = "0x183B58400")]
		public bool Remove(NDHHMAGGOLL NHGFCDFBGDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KABABGAHHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int LFFDFPFFCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int CKGEEMEHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int BJHAOJJACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FPGPDEPIKPG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F510", Offset = "0x3B5DD10", VA = "0x183B5F510")]
	public KABABGAHHBG(int CKGEEMEHNFN, int BJHAOJJACKB, int LFFDFPFFCOK, int FPGPDEPIKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CCJDBDEFHHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> NLPBHPGJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> JEHHKCNFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> MEKOFMMICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<KABABGAHHBG> MGNMKPAFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> FNFBIBBFCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> HDGKCJPNEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> MMPOAMPPNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle EKHIACNLHLK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NHDMENHJNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E9DC0", Offset = "0x7E85C0", VA = "0x1807E9DC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E9410", Offset = "0x7E7C10", VA = "0x1807E9410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B56F20", Offset = "0x3B55720", VA = "0x183B56F20")]
	public void MNAKDNHCDHC(BBALKBLIGPE KHANDGJIMAB, NativeList<KABABGAHHBG> MGNMKPAFPDH, float DBOCAJHMLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B56CD0", Offset = "0x3B554D0", VA = "0x183B56CD0")]
	public void JFNKGPNEEAG(Transform LHEBAIHADCN, bool LCGNIEGIDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B56A40", Offset = "0x3B55240", VA = "0x183B56A40")]
	public void DDFNJKAOOGM(GFNKFIPOPDK CMAHILOLIAD, bool OCLBCINMMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3B56BD0", Offset = "0x3B553D0", VA = "0x183B56BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3B56CA0", Offset = "0x3B554A0", VA = "0x183B56CA0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public CCJDBDEFHHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct GHFBIBAHLKO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> NLPBHPGJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> JEHHKCNFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<KABABGAHHBG> OGIHFBOCBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> FNFBIBBFCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 KHMLMJNGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> HDGKCJPNEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> MMPOAMPPNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool LCGNIEGIDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float JHCMMDBKHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float ACJHNDMGOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float FCKFHEICBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> MEKOFMMICAN;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C8A0", Offset = "0x3B5B0A0", VA = "0x183B5C8A0")]
	public GHFBIBAHLKO(CCJDBDEFHHN NIPKBPFDKLC, Vector3 KHMLMJNGEGF, bool LCGNIEGIDCA, float JHCMMDBKHDB, float ACJHNDMGOEP, float FCKFHEICBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C400", Offset = "0x3B5AC00", VA = "0x183B5C400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NDHHMAGGOLL : AEOAHPKBJJA
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds DBCBJPAEKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JFNGNGFNHLC HMAOPCHBLID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DDNIHEDGNDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<NDHHMAGGOLL> AOPLIANOLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public DDNIHEDGNDB PJIPIGLGNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public DDNIHEDGNDB GEOIJKBAJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public DDNIHEDGNDB NAACCEGFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int FPGPDEPIKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds NEHFEFOGHKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3B59090", Offset = "0x3B57890", VA = "0x183B59090")]
	public DDNIHEDGNDB(List<NDHHMAGGOLL> AOPLIANOLPB, [Optional] DDNIHEDGNDB PJIPIGLGNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KANKFPGEOJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<DDNIHEDGNDB> AKPBMAALFMM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public DDNIHEDGNDB IOHEHEBKIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F530", Offset = "0x3B5DD30", VA = "0x183B5F530")]
	public KANKFPGEOJC(DDNIHEDGNDB LHEBAIHADCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMMHIGADAMM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct MGCOPHABAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int AAHLDMPPJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int NMIDDNODDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int GLGPNNPNGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int PJFNHMFHGDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LILLCGCJAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DOKCDHCPFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float NNKAOACAIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<NDHHMAGGOLL> AOPLIANOLPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum AEAJBMADMDN
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
	private MGCOPHABAHE GKCJBBJCCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int CEJEJMJDFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int LPHAIOLOENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int FOHHIOGBDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float LFKEHGMKDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float HGLEEKJMMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<DDNIHEDGNDB> GAJPNJEPMBB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KANKFPGEOJC ACDECOEEKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E920", Offset = "0x3B5D120", VA = "0x183B5E920")]
	public JMMHIGADAMM(int LPHAIOLOENI, int FOHHIOGBDNL, float LFKEHGMKDJM, int CEJEJMJDFJM, float HGLEEKJMMNO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CE10", Offset = "0x3B5B610", VA = "0x183B5CE10")]
	public void FAOLNKKEJCD(List<NDHHMAGGOLL> AOPLIANOLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CDA0", Offset = "0x3B5B5A0", VA = "0x183B5CDA0")]
	public bool ECFHMANDCJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E810", Offset = "0x3B5D010", VA = "0x183B5E810")]
	private float LKIGPBGBFMB(Vector3 CGJLHCNEEOO, Vector3 NGAPIFAHFIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E770", Offset = "0x3B5CF70", VA = "0x183B5E770")]
	private float LKIGPBGBFMB(Vector3 HMOCDAEHBDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B5CF70", Offset = "0x3B5B770", VA = "0x183B5CF70")]
	private bool FIMGMFHNNFE(DDNIHEDGNDB ILNCHNCCDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DC40", Offset = "0x3B5C440", VA = "0x183B5DC40")]
	private LILLCGCJAIK IMFLCGPKPLM(List<NDHHMAGGOLL> OKENECIMPBI, AEAJBMADMDN OJJOKPIEEFG)
	{
		return default(LILLCGCJAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D8B0", Offset = "0x3B5C0B0", VA = "0x183B5D8B0")]
	private void GLCNHCNIJCD(List<NDHHMAGGOLL> AOPLIANOLPB, Vector3[] APFCJAOMAFO, Vector3[] LAANFGOCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OHDNPNDGMGE
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3B650C0", Offset = "0x3B638C0", VA = "0x183B650C0")]
	public static Bounds BJAGHKLDIOK(List<NDHHMAGGOLL> AOPLIANOLPB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B65270", Offset = "0x3B63A70", VA = "0x183B65270")]
	public static int HCCGGHNPNGE(List<NDHHMAGGOLL> AOPLIANOLPB, NEMIOKPMGJC LGLCJGAGAEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MCPNNNKOAPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private BBALKBLIGPE BBBJJFFAGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BBALKBLIGPE FDGOBNCNHMP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static BBALKBLIGPE KOAGDMJPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JJNGGMCPIAK EGAEFCOJPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PMMHIBIOLKN KBLFEOAKGAA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle EKHIACNLHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AA810", Offset = "0x5A9010", VA = "0x1805AA810")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x632D00", Offset = "0x631500", VA = "0x180632D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GFNKFIPOPDK.KCMHKMMECPD ILNCHNCCDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EACGDAMAFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x96A980", Offset = "0x969180", VA = "0x18096A980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B63D50", Offset = "0x3B62550", VA = "0x183B63D50")]
	[CCBCLBBLEBF(APPEKHCMHHD.ExitingPlayMode, 0)]
	private void LJGHIIHLBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3B63DC0", Offset = "0x3B625C0", VA = "0x183B63DC0")]
	public void MNAKDNHCDHC(GFNKFIPOPDK.KCMHKMMECPD OGIHFBOCBMO, Transform OJMHDKHMEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3B637E0", Offset = "0x3B61FE0", VA = "0x183B637E0")]
	public void HHBOAPHGDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B63740", Offset = "0x3B61F40", VA = "0x183B63740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B637B0", Offset = "0x3B61FB0", VA = "0x183B637B0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3B64700", Offset = "0x3B62F00", VA = "0x183B64700")]
	public MCPNNNKOAPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface IDMOKMEKFLM
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LKGKGDGCONB KOFBDNCNPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PNKGFCCIKBI
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 PNOFDDILLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BILFPGJAOJO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool BCOGIEMLMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CGNOOBOGACP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action PIBAELGHPJD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CMLHLHBIEME
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMLHLHBIEME AFIDOONHPHI(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMLHLHBIEME EECNOFAJAKP(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMLHLHBIEME OJEKHHJBMJM(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMLHLHBIEME BNBFHHKIFMI(Action PDPDEJOFENK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MIAEGJMHACO : CMLHLHBIEME
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class BGAMJGGAEOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public MIAEGJMHACO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public BGAMJGGAEOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x3B55F20", Offset = "0x3B54720", VA = "0x183B55F20")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x3B55F70", Offset = "0x3B54770", VA = "0x183B55F70")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x3B55FC0", Offset = "0x3B547C0", VA = "0x183B55FC0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> CJHKPGGALPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action MDBFBOOLHMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action NLAPDPNJJOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private GJMNNFEJJBM MOIHNGOGHMK;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action BALNJLNDENI
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x4DBDA0", Offset = "0x4DA5A0", VA = "0x1804DBDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD30", Offset = "0x4DA530", VA = "0x1804DBD30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action CJMGKMBAPMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x16A43F0", Offset = "0x16A2BF0", VA = "0x1816A43F0", Slot = "4")]
			public CMLHLHBIEME AFIDOONHPHI(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F08590", Offset = "0x1F06D90", VA = "0x181F08590", Slot = "5")]
			public CMLHLHBIEME EECNOFAJAKP(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x267A640", Offset = "0x2678E40", VA = "0x18267A640", Slot = "6")]
			public CMLHLHBIEME OJEKHHJBMJM(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5A6D20", Offset = "0x5A5520", VA = "0x1805A6D20", Slot = "7")]
			public CMLHLHBIEME BNBFHHKIFMI(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x59DDB0", Offset = "0x59C5B0", VA = "0x18059DDB0")]
			public MIAEGJMHACO(Func<JobHandle> AEDBKPFMMAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3B64780", Offset = "0x3B62F80", VA = "0x183B64780")]
			public void GLHFPKIGJKB(Action OOCONDHAMOP, Action ILNGIEDBKOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3B64980", Offset = "0x3B63180", VA = "0x183B64980")]
			public void MEHJLGGLJCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CHBHFKFEIOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public CMLHLHBIEME jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public CHBHFKFEIOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xEE4680", Offset = "0xEE2E80", VA = "0x180EE4680")]
			internal bool <Remove>b__0(MIAEGJMHACO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class OPHEBNJPPKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public MIAEGJMHACO newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public OPHEBNJPPKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3B65500", Offset = "0x3B63D00", VA = "0x183B65500")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<MIAEGJMHACO> JEJHAMLNHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<MIAEGJMHACO> COCIGPBOFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private PMAFHAMHOLN CKNHJMKBCIM;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EB30", Offset = "0x3B5D330", VA = "0x183B5EB30")]
		public CMLHLHBIEME Add(Func<JobHandle> AEDBKPFMMAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EDA0", Offset = "0x3B5D5A0", VA = "0x183B5EDA0")]
		public void Remove(CMLHLHBIEME EKHIACNLHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EC20", Offset = "0x3B5D420", VA = "0x183B5EC20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E980", Offset = "0x3B5D180", VA = "0x183B5E980")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EF00", Offset = "0x3B5D700", VA = "0x183B5EF00")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E980", Offset = "0x3B5D180", VA = "0x183B5E980")]
		[CompilerGenerated]
		private void AIOBEEKGHHJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GJMNNFEJJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJMNNFEJJBM AFIDOONHPHI(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJMNNFEJJBM BNACBMDOLMM(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GJMNNFEJJBM BNBFHHKIFMI(Action PDPDEJOFENK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PHHBNEDGJNE : GJMNNFEJJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle LICCIJINJHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action MDBFBOOLHMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action IDIGOOLEEOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action CJMGKMBAPMD;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool CPBHKCLAOOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x3B65F10", Offset = "0x3B64710", VA = "0x183B65F10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1F08590", Offset = "0x1F06D90", VA = "0x181F08590", Slot = "4")]
			public GJMNNFEJJBM AFIDOONHPHI(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x267A640", Offset = "0x2678E40", VA = "0x18267A640", Slot = "5")]
			public GJMNNFEJJBM BNACBMDOLMM(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5A6D20", Offset = "0x5A5520", VA = "0x1805A6D20", Slot = "6")]
			public GJMNNFEJJBM BNBFHHKIFMI(Action PDPDEJOFENK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x11AA450", Offset = "0x11A8C50", VA = "0x1811AA450")]
			public PHHBNEDGJNE(JobHandle MCMKGPJPMLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3B65ED0", Offset = "0x3B646D0", VA = "0x183B65ED0")]
			public void MIJPJJEKELF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3B65E90", Offset = "0x3B64690", VA = "0x183B65E90")]
			public void MEHJLGGLJCP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<PHHBNEDGJNE> PFLNCKCAEOD;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F370", Offset = "0x3B5DB70", VA = "0x183B5F370")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EFB0", Offset = "0x3B5D7B0", VA = "0x183B5EFB0")]
		public GJMNNFEJJBM Add(JobHandle MCMKGPJPMLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F280", Offset = "0x3B5DA80", VA = "0x183B5F280")]
		public void Remove(GJMNNFEJJBM EKHIACNLHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F120", Offset = "0x3B5D920", VA = "0x183B5F120", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F040", Offset = "0x3B5D840", VA = "0x183B5F040")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3B5F480", Offset = "0x3B5DC80", VA = "0x183B5F480")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NNEGPLICMMD
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] JIMKOONODID;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int NMMFCBLNDCI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int PHIEOBCOOJB;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger DPMJLFEPCLI;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public NNEGPLICMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3B64AE0", Offset = "0x3B632E0", VA = "0x183B64AE0")]
	private static string CFIIEEFNNDM(byte[] DALEFJAMHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3B64BE0", Offset = "0x3B633E0", VA = "0x183B64BE0")]
	public static string DHILBOIALCB(byte[] EGBGAEKCIGK, bool DAJGEBLMHFN)
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
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
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
