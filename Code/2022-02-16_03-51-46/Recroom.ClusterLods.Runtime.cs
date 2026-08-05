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
				[Cpp2IlInjected.Address(RVA = "0x416C370", Offset = "0x416AB70", VA = "0x18416C370")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x100E170", Offset = "0x100C970", VA = "0x18100E170")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x416C330", Offset = "0x416AB30", VA = "0x18416C330")]
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
		[Cpp2IlInjected.Address(RVA = "0x4160430", Offset = "0x415EC30", VA = "0x184160430")]
		public LODSettings NHKOKHEMOKM(NLJOEGOODPP GAKEOHNAFFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4160310", Offset = "0x415EB10", VA = "0x184160310")]
		public int JEIAKCDHCBH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4160330", Offset = "0x415EB30", VA = "0x184160330")]
		public int MBOEJHPJCPC(bool LINMLPKAACK, Vector3 HNFNCMEGJCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4160440", Offset = "0x415EC40", VA = "0x184160440")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CJGDFBONLDC
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
public interface PHIICEBDCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPAILAEPEMM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HONFDAAJEFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DNBOLHEIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BFDKHAKAPFM> NCOMGCDBLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CJGDFBONLDC LDBFHMIOOOD
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
	void UpdateClusterDistances(Vector3 CGBDHCOLCMM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(DDLDJJBOBFK DMKKOEDDCFE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFDKHAKAPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int FJEBBNOBILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int NCJPBNMPMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CABGHMCKOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DBEKBPDCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte EDAEPKFJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IDJAPKJLGEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum EMCLGBNHDCG
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
	private sealed class CHONNAGBAMC : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public IDJAPKJLGEH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public CHONNAGBAMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4160200", Offset = "0x415EA00", VA = "0x184160200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41602C0", Offset = "0x415EAC0", VA = "0x1841602C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LBFBAPMGLGF : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AAPMNJMBGEO <>2__current;

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
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public LBFBAPMGLGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x416C100", Offset = "0x416A900", VA = "0x18416C100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x416C250", Offset = "0x416AA50", VA = "0x18416C250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OEENHCHIJJE : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IDJAPKJLGEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<AAPMNJMBGEO> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public OEENHCHIJJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x416E9F0", Offset = "0x416D1F0", VA = "0x18416E9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x416F470", Offset = "0x416DC70", VA = "0x18416F470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KGHLNAKLJIA : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IDJAPKJLGEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public KGHLNAKLJIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x416B1C0", Offset = "0x41699C0", VA = "0x18416B1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x416C0B0", Offset = "0x416A8B0", VA = "0x18416C0B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int BLELGNPGHGO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer ILJFIGOOJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter CKJLFOELNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject MPGIBACDOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject OECIIIDKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public IAAOCJHNIKP EOGEEFMCBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<DDLDJJBOBFK> IJFCBLNEJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<DDLDJJBOBFK> FKANEOANEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<DDLDJJBOBFK> FGDDPAFEKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int EHDGHNOBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EMCLGBNHDCG FPMJLLFIKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<HONFDAAJEFJ>[] GJCBMBOCEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<BFDKHAKAPFM>[] BOPMNDJPHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private JEOMIDCJMHN GNGAKJFKPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private JEOMIDCJMHN KCGGBEHKADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private JEOMIDCJMHN KNFHJLALOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int OLHHIGNGFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int DDLNFGILPGF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static IDJAPKJLGEH IOINHFJGLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IDMNNDCJFLM DDMGGODACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AKHCDNBLMEN EPDEPALDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour GPMIDAGMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material MJBJOGEBLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<PHIICEBDCDP> PKALEFHPBMM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig NOICFDGECMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 ACLBBCJPNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4370", Offset = "0x1EA2B70", VA = "0x181EA4370")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1EA42A0", Offset = "0x1EA2AA0", VA = "0x181EA42A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private EMCLGBNHDCG ONMLLIEEING
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x542660", Offset = "0x540E60", VA = "0x180542660")]
		get
		{
			return default(EMCLGBNHDCG);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41650D0", Offset = "0x41638D0", VA = "0x1841650D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IDJAPKJLGEH OONGLDHDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4165240", Offset = "0x4163A40", VA = "0x184165240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OKBCDBFGIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4165900", Offset = "0x4164100", VA = "0x184165900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool BPIJGBCHAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41640C0", Offset = "0x41628C0", VA = "0x1841640C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> OJCMOMFKPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4165AB0", Offset = "0x41642B0", VA = "0x184165AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4165550", Offset = "0x4163D50", VA = "0x184165550")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LAJEOHIEGON
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4164580", Offset = "0x4162D80", VA = "0x184164580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41644E0", Offset = "0x4162CE0", VA = "0x1841644E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4165EC0", Offset = "0x41646C0", VA = "0x184165EC0")]
	public IDJAPKJLGEH(IDMNNDCJFLM DDMGGODACGJ, AKHCDNBLMEN EPDEPALDADK, ClusterLODConfig GFBGNDKJGFN, MonoBehaviour GPMIDAGMHHI, Material MJBJOGEBLDK, ClusterMeshRenderer ILJFIGOOJMF, MeshFilter CKJLFOELNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x41656A0", Offset = "0x4163EA0", VA = "0x1841656A0")]
	private void JJMPJCCKOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41641A0", Offset = "0x41629A0", VA = "0x1841641A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4165040", Offset = "0x4163840", VA = "0x184165040")]
	public static void GLJKKIAIDKP(Vector3 BEMLJHBGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4165E20", Offset = "0x4164620", VA = "0x184165E20")]
	private void PMCGANJIKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4163A40", Offset = "0x4162240", VA = "0x184163A40")]
	private void ALICBHPACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4163C60", Offset = "0x4162460", VA = "0x184163C60")]
	private void BHBIIJNIPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4165280", Offset = "0x4163A80", VA = "0x184165280")]
	public void IKFHFPGNFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4165A40", Offset = "0x4164240", VA = "0x184165A40")]
	[IteratorStateMachine(typeof(CHONNAGBAMC))]
	private IEnumerator<AAPMNJMBGEO> NKONLOPHGPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4163B40", Offset = "0x4162340", VA = "0x184163B40")]
	[IteratorStateMachine(typeof(LBFBAPMGLGF))]
	private IEnumerator<AAPMNJMBGEO> ANOHLLOBJLM(Func<bool> ODJIFODEFBD, float JDNBBLPEPKJ, Func<string> MOLLAPIOBHC, float DKMOICIFJCJ = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4165630", Offset = "0x4163E30", VA = "0x184165630")]
	[IteratorStateMachine(typeof(OEENHCHIJJE))]
	private IEnumerator<AAPMNJMBGEO> JGEIMIHFKDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4165B50", Offset = "0x4164350", VA = "0x184165B50")]
	public void OIKMNPNAION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4164120", Offset = "0x4162920", VA = "0x184164120")]
	public void DFNEJOMFBOA(IEnumerable<HONFDAAJEFJ> KKKPDAPNJCN, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4164620", Offset = "0x4162E20", VA = "0x184164620")]
	public void GBGDNLNIMMG(IEnumerable<HONFDAAJEFJ> KKKPDAPNJCN, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41648D0", Offset = "0x41630D0", VA = "0x1841648D0")]
	public List<ClusterMeshRenderer> GEKJEPFDMAE(List<DDLDJJBOBFK> BNEIKAOFBID, Transform MIBMGGCCOAE, CJGDFBONLDC EFHCHKNBIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41644A0", Offset = "0x4162CA0", VA = "0x1841644A0")]
	public CJGDFBONLDC ENFFDKJCPMO(Vector3 JIKIGJFBCLH)
	{
		return default(CJGDFBONLDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4165730", Offset = "0x4163F30", VA = "0x184165730")]
	public void JKIFPGCBGHG(PHIICEBDCDP MPJLONNKGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4165D60", Offset = "0x4164560", VA = "0x184165D60")]
	public bool ONHCKLOCDAK(PHIICEBDCDP MPJLONNKGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4165DC0", Offset = "0x41645C0", VA = "0x184165DC0")]
	public void PANELJGJJAK(DDLDJJBOBFK IIHANHELEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4164040", Offset = "0x4162840", VA = "0x184164040")]
	public void DCGPPIPAEAI(BFDKHAKAPFM MODDMIDMILD, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4163BE0", Offset = "0x41623E0", VA = "0x184163BE0")]
	public void AOCGDBHLGHN(BFDKHAKAPFM MODDMIDMILD, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4163DA0", Offset = "0x41625A0", VA = "0x184163DA0")]
	private void CAFIBBJPDEP(Vector3 CGBDHCOLCMM, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4163ED0", Offset = "0x41626D0", VA = "0x184163ED0")]
	private void CNPBBCOKONL(Vector3 CGBDHCOLCMM, CJGDFBONLDC EFHCHKNBIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41659D0", Offset = "0x41641D0", VA = "0x1841659D0")]
	[IteratorStateMachine(typeof(KGHLNAKLJIA))]
	private IEnumerator<AAPMNJMBGEO> MPKDAMBKCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4165790", Offset = "0x4163F90", VA = "0x184165790")]
	private int KGNBHGOMDED(int INFKIDFCOKN, int CHKFLAMBECK, List<BFDKHAKAPFM> IKKMNAEIMMF, byte GAKEOHNAFFD, ref int JELEPPBMFAG, float DJLHONJOJJP = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41642D0", Offset = "0x4162AD0", VA = "0x1841642D0")]
	public void EHAJBJDJBJH(DDLDJJBOBFK DMKKOEDDCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4165200", Offset = "0x4163A00", VA = "0x184165200")]
	public bool GOAIPNGJNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50A7C0", Offset = "0x508FC0", VA = "0x18050A7C0")]
	public Material ADGJKFJLLNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41655F0", Offset = "0x4163DF0", VA = "0x1841655F0")]
	public int JEIAKCDHCBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4165980", Offset = "0x4164180", VA = "0x184165980")]
	[CompilerGenerated]
	private bool MLDOOAFEHHK()
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
		[Cpp2IlInjected.Address(RVA = "0x507A60", Offset = "0x506260", VA = "0x180507A60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct AOHJLHBHICO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> MCFMCOFMNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> FBFLOLJFMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> EEKDCFKAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> GMCIPNGFALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> BENBKEOLIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> IPBBAGNEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> KHOKHJGEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 CMECANCNIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float KCCPEODFAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> BGMNGDFNEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> ACLPFDFHEKL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4160140", Offset = "0x415E940", VA = "0x184160140")]
	public AOHJLHBHICO(PHCNKNNAIOD NMCFIAPNHNL, NativeList<float3> KHOKHJGEJID, NativeMultiHashMap<int, int> BGMNGDFNEPI, NativeArray<int> ACLPFDFHEKL, Vector3 CMECANCNIHM, float KCCPEODFAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x415FA50", Offset = "0x415E250", VA = "0x18415FA50")]
	private int DEBAGPNBACF(float3 CGBDHCOLCMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x415FEA0", Offset = "0x415E6A0", VA = "0x18415FEA0")]
	private int JNHKLJKCFDN(int NKKJIADADPE, int DOMICNELCFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x415FAB0", Offset = "0x415E2B0", VA = "0x18415FAB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IEAFLABKGOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> BGMNGDFNEPI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> ACLPFDFHEKL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int IPLEIIACCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> DCCLBEJLIEF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41664F0", Offset = "0x4164CF0", VA = "0x1841664F0")]
	public void GAEJIHNGFEL(int GIJEFCNLFIB, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4166440", Offset = "0x4164C40", VA = "0x184166440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IEAFLABKGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct JLELKILIFPL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> GDDJFNAJKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> JLNFHOJEHMH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x416A010", Offset = "0x4168810", VA = "0x18416A010")]
	public JLELKILIFPL(IEAFLABKGOK DFCGNPMENBA, PHCNKNNAIOD NMCFIAPNHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4169F80", Offset = "0x4168780", VA = "0x184169F80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct JGDCGLBOGAD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> PFHHGFLNONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> CGKEJCJNFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> MNIGPNFABDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> EGGMLDEFJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> AKCKNHLHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> DCCLBEJLIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> GDDJFNAJKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> JKCNAPJOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> AKJDDOPPIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> BHHFHBJBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> EMIDILLBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> FHBJLDKBPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> ICCLBOKNICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float AHHLDJOPKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float CIFIPNDPDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 LFMJMMOFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float OAPNMPNPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float PLAHGJFIIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float AOIKGELEGAP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4168210", Offset = "0x4166A10", VA = "0x184168210")]
	public JGDCGLBOGAD(IEAFLABKGOK IAPLBFBCBJH, PHCNKNNAIOD NMCFIAPNHNL, PHCNKNNAIOD DAHJFLOILFD, float PLAHGJFIIAH, float AOIKGELEGAP, Vector3 LFMJMMOFNLA, float OAPNMPNPJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4167900", Offset = "0x4166100", VA = "0x184167900")]
	private float3 FIPMAHBBENF(int NKKJIADADPE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4166DC0", Offset = "0x41655C0", VA = "0x184166DC0")]
	private void DJPEBLOGGFN(int NKKJIADADPE, out float3 BAOAEHDHNPM, out float3 MMCIKJFBDPC, out float4 CDFPHKOGFPJ, out float4 GBFJGNGMIMH, out float2 NHCOGLJCKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4167C80", Offset = "0x4166480", VA = "0x184167C80")]
	private int JAIDIODACOK(int BPLKLFAFDIC, int OJDOFGEHGIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41679A0", Offset = "0x41661A0", VA = "0x1841679A0")]
	private void FLGGPLJLKKE(int BPLKLFAFDIC, int OJDOFGEHGIP, int HLKKPNKLJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4166C30", Offset = "0x4165430", VA = "0x184166C30")]
	private bool AEMJILHBMPB(int BPLKLFAFDIC, int OJDOFGEHGIP, float FBPPCNIPHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4167BC0", Offset = "0x41663C0", VA = "0x184167BC0")]
	private bool HELEJMEMDGC(int BPLKLFAFDIC, int OJDOFGEHGIP, int HLKKPNKLJIA, float FBPPCNIPHOL, bool HPAAHILBEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4167FB0", Offset = "0x41667B0", VA = "0x184167FB0")]
	private bool JCEBCBNICGE(int BPLKLFAFDIC, int OJDOFGEHGIP, int HLKKPNKLJIA, float FBPPCNIPHOL, bool HPAAHILBEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4167BA0", Offset = "0x41663A0", VA = "0x184167BA0")]
	private void GNPMBNPMPFO(int BPLKLFAFDIC, int OJDOFGEHGIP, int HLKKPNKLJIA, out int IOAPODCCHNG, out int BOLHJBFPFDI, out int GAABDJJHNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4166FA0", Offset = "0x41657A0", VA = "0x184166FA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PNHLBMBKBAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IDAHLMGIPII : IDisposable, BFDKHAKAPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds MKNDOOPGPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<DDLDJJBOBFK> BNEIKAOFBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 KPHGIBIHBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 BJGOBPBAJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int PFOFKMMFEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PHCNKNNAIOD IENKNHJMELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public IEAFLABKGOK JJKHHEKPIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform MIBMGGCCOAE;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ONBIOCHHKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41637E0", Offset = "0x4161FE0", VA = "0x1841637E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh ABKODCCJBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh IEPIMALDBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x50B470", Offset = "0x509C70", VA = "0x18050B470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x52F9E0", Offset = "0x52E1E0", VA = "0x18052F9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CABGHMCKOOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x50E160", Offset = "0x50C960", VA = "0x18050E160", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x50E500", Offset = "0x50CD00", VA = "0x18050E500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte EDAEPKFJOAG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5A97B0", Offset = "0x5A7FB0", VA = "0x1805A97B0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644600", VA = "0x180645E00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FJEBBNOBILC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x731830", Offset = "0x730030", VA = "0x180731830", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x731800", Offset = "0x730000", VA = "0x180731800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NCJPBNMPMJN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCDADD0", Offset = "0xCD95D0", VA = "0x180CDADD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6C5B00", Offset = "0x6C4300", VA = "0x1806C5B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float DBEKBPDCFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x41638C0", Offset = "0x41620C0", VA = "0x1841638C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x41632A0", Offset = "0x4161AA0", VA = "0x1841632A0")]
		public void CDPPAMIEPGI(NLJOEGOODPP GAKEOHNAFFD, out int DGHLPJOODLF, out int GEKOJFOGBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41634D0", Offset = "0x4161CD0", VA = "0x1841634D0")]
		public void COPHFCAFBBM(NLJOEGOODPP GAKEOHNAFFD, HKBINMDMLII GMKBNFKFIKL, int LOEPDAJAABD = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4162F80", Offset = "0x4161780", VA = "0x184162F80")]
		public void AMKLHHEBNNF(NativeList<LLOBECALIDD> IOIMPLEIJJK, Transform OAHELJOADID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x41638E0", Offset = "0x41620E0", VA = "0x1841638E0")]
		public void PNAFMFELCEF(Mesh NMCFIAPNHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4163820", Offset = "0x4162020", VA = "0x184163820")]
		public void LODCJBCFLMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4163670", Offset = "0x4161E70", VA = "0x184163670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4163980", Offset = "0x4162180", VA = "0x184163980")]
		public IDAHLMGIPII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds MKNDOOPGPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<IDAHLMGIPII> LKEJAADADMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public LOEPDOFKEKD AHFEMKADPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer HFAOLNFLEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int HEAMNJLOIJN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh OHAKDFDIABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50B460", Offset = "0x509C60", VA = "0x18050B460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D40", Offset = "0x5E2540", VA = "0x1805E3D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IDIMIBDFOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EB520", Offset = "0x6E9D20", VA = "0x1806EB520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EB640", Offset = "0x6E9E40", VA = "0x1806EB640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DNBOLHEIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x41702D0", Offset = "0x416EAD0", VA = "0x1841702D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x416F4C0", Offset = "0x416DCC0", VA = "0x18416F4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x41708B0", Offset = "0x416F0B0", VA = "0x1841708B0")]
	public int OILMDDEHLHI(int EMKLKGHDAMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x416FF90", Offset = "0x416E790", VA = "0x18416FF90")]
	public void IMBMMPOANAG(MBDJHPLNCKM HPLJBCKDHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x416F880", Offset = "0x416E080", VA = "0x18416F880")]
	public void FBOGCLHOJKK(Transform OAHELJOADID, bool GGNBAFIPPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4170120", Offset = "0x416E920", VA = "0x184170120")]
	public bool IOGHANNJLPF(bool IALHLDJLOCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4170320", Offset = "0x416EB20", VA = "0x184170320")]
	public void MCBHJKCJJBB(Transform MIBMGGCCOAE, bool GGNBAFIPPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x416F620", Offset = "0x416DE20", VA = "0x18416F620")]
	public bool EHAJBJDJBJH(DDLDJJBOBFK DMKKOEDDCFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41708E0", Offset = "0x416F0E0", VA = "0x1841708E0")]
	public PNHLBMBKBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IAAOCJHNIKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<PNHLBMBKBAD.IDAHLMGIPII> BHHBFFLPOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NJGLLGILDPF OPNMFICCPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<PNHLBMBKBAD.IDAHLMGIPII> ODBKFLHIPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int IGNPFPDONDG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41620F0", Offset = "0x41608F0", VA = "0x1841620F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4162310", Offset = "0x4160B10", VA = "0x184162310")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x41627A0", Offset = "0x4160FA0", VA = "0x1841627A0")]
	public void MFDJFDLHFHG(PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH, Transform MIBMGGCCOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4162160", Offset = "0x4160960", VA = "0x184162160")]
	public void EHAJBJDJBJH(PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4162390", Offset = "0x4160B90", VA = "0x184162390")]
	private PNHLBMBKBAD.IDAHLMGIPII GCLOJEBLEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4162710", Offset = "0x4160F10", VA = "0x184162710")]
	private bool LLMMBOJHFCM(PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4161FF0", Offset = "0x41607F0", VA = "0x184161FF0")]
	private void CDKNHDOBOOE(PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41620B0", Offset = "0x41608B0", VA = "0x1841620B0")]
	public bool DIFFKDFIKMC(PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x41624C0", Offset = "0x4160CC0", VA = "0x1841624C0")]
	public bool GMABKAMPIOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4162050", Offset = "0x4160850", VA = "0x184162050")]
	private PNHLBMBKBAD.IDAHLMGIPII CLCAGCPLPJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4162850", Offset = "0x4161050", VA = "0x184162850")]
	public IAAOCJHNIKP()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x507A60", Offset = "0x506260", VA = "0x180507A60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IEBFNDEIJJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int JEBIFNMADDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int MCEDEBHPMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float AKEJOEBKANJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<PNHLBMBKBAD> IALKHMKBMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4166BE0", Offset = "0x41653E0", VA = "0x184166BE0")]
	public IEBFNDEIJJO(int JEBIFNMADDA, int MCEDEBHPMCJ, float IHNDIEBLIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4166AA0", Offset = "0x41652A0", VA = "0x184166AA0")]
	public void EGEIGKJEBBH(NHDKDCEHONM BFDCGMCFBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4166B40", Offset = "0x4165340", VA = "0x184166B40")]
	private int MKNNNJOFCJK(MBDJHPLNCKM MDPGPMLNPNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4166870", Offset = "0x4165070", VA = "0x184166870")]
	private void EGEIGKJEBBH(MBDJHPLNCKM MDPGPMLNPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4166690", Offset = "0x4164E90", VA = "0x184166690")]
	private void AAAGKBFJFAE(MBDJHPLNCKM MDPGPMLNPNN, PNHLBMBKBAD HDHDGKAMFHK)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, HONFDAAJEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MLGMFCEBKHO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
			[DebuggerHidden]
			public MLGMFCEBKHO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x416D670", Offset = "0x416BE70", VA = "0x18416D670", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x416D800", Offset = "0x416C000", VA = "0x18416D800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x416D760", Offset = "0x416BF60", VA = "0x18416D760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x416D760", Offset = "0x416BF60", VA = "0x18416D760", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int DNBOLHEIJFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4161780", Offset = "0x415FF80", VA = "0x184161780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<BFDKHAKAPFM> NCOMGCDBLNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x4161760", Offset = "0x415FF60", VA = "0x184161760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> LKEJAADADMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PNHLBMBKBAD OHAKDFDIABA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public CJGDFBONLDC LDBFHMIOOOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x52FD50", Offset = "0x52E550", VA = "0x18052FD50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(CJGDFBONLDC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6BA0C0", Offset = "0x6B88C0", VA = "0x1806BA0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HAJEGLPHDAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4161770", Offset = "0x415FF70", VA = "0x184161770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x41604A0", Offset = "0x415ECA0", VA = "0x1841604A0")]
		public static ClusterMeshRenderer Create(PNHLBMBKBAD NMCFIAPNHNL, ClusterMeshRenderer ILJFIGOOJMF, MeshFilter CKJLFOELNOP, Transform MIBMGGCCOAE, CJGDFBONLDC EFHCHKNBIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41605B0", Offset = "0x415EDB0", VA = "0x1841605B0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4160D10", Offset = "0x415F510", VA = "0x184160D10", Slot = "10")]
		public bool TryRemoveClusterLODComponent(DDLDJJBOBFK DMKKOEDDCFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4160AE0", Offset = "0x415F2E0", VA = "0x184160AE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4160810", Offset = "0x415F010", VA = "0x184160810")]
		public void Init(PNHLBMBKBAD NMCFIAPNHNL, MeshFilter CKJLFOELNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4160610", Offset = "0x415EE10", VA = "0x184160610")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4160E40", Offset = "0x415F640", VA = "0x184160E40", Slot = "8")]
		public void UpdateClusterDistances(Vector3 CGBDHCOLCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4161080", Offset = "0x415F880", VA = "0x184161080", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x41607A0", Offset = "0x415EFA0", VA = "0x1841607A0")]
		[IteratorStateMachine(typeof(MLGMFCEBKHO))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4160B60", Offset = "0x415F360", VA = "0x184160B60")]
		public void SetupTagAndLayer(string ICKPFDJNKEG, int EFHCHKNBIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4160B40", Offset = "0x415F340", VA = "0x184160B40")]
		public bool Remove(DDLDJJBOBFK DMKKOEDDCFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x507A60", Offset = "0x506260", VA = "0x180507A60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AJALBILAFPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int OGJOGGCJPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AHCEFDPBKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int GEKOJFOGBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int DGHLPJOODLF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x415FA30", Offset = "0x415E230", VA = "0x18415FA30")]
	public AJALBILAFPB(int AHCEFDPBKKA, int GEKOJFOGBEC, int OGJOGGCJPPH, int DGHLPJOODLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LOEPDOFKEKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> MCFMCOFMNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> DCCLBEJLIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> IPBBAGNEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<AJALBILAFPB> NAKGJBIAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> ACLCELANFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> AJOJENEGOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> PAPMINBEFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle IEOOCNAEGNG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NCGACBLCLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x97DF90", Offset = "0x97C790", VA = "0x18097DF90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x97DFB0", Offset = "0x97C7B0", VA = "0x18097DFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x416C390", Offset = "0x416AB90", VA = "0x18416C390")]
	public void APFJAIJHKIL(PHCNKNNAIOD EEBMIFJNLOA, NativeList<AJALBILAFPB> NAKGJBIAHKC, float DEIMMMPFLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x416D210", Offset = "0x416BA10", VA = "0x18416D210")]
	public void IGOHOELKFLD(Transform MIBMGGCCOAE, bool GGNBAFIPPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x416D460", Offset = "0x416BC60", VA = "0x18416D460")]
	public void IOGHANNJLPF(PNHLBMBKBAD HFAOLNFLEGF, bool IALHLDJLOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x416D110", Offset = "0x416B910", VA = "0x18416D110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x416D1E0", Offset = "0x416B9E0", VA = "0x18416D1E0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public LOEPDOFKEKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct KAGKEELPDCO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> MCFMCOFMNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> DCCLBEJLIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<AJALBILAFPB> KNCDODBFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> ACLCELANFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 LFMJMMOFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> AJOJENEGOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> PAPMINBEFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GGNBAFIPPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float GFACOILONOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float FPOHGOGPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float COPOCBCLCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> IPBBAGNEJHK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x416B0F0", Offset = "0x41698F0", VA = "0x18416B0F0")]
	public KAGKEELPDCO(LOEPDOFKEKD PDDOAMCCBFJ, Vector3 LFMJMMOFNLA, bool GGNBAFIPPNP, float GFACOILONOI, float FPOHGOGPJHK, float COPOCBCLCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x416AC50", Offset = "0x4169450", VA = "0x18416AC50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DDLDJJBOBFK : GEJPNAHJOCC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds CEEOGGIHEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LLOBECALIDD FILCKEBHMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MBDJHPLNCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<DDLDJJBOBFK> BNEIKAOFBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public MBDJHPLNCKM ECKBOFJGCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public MBDJHPLNCKM INFCBBJOLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public MBDJHPLNCKM HONGPMBAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int DGHLPJOODLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds MKNDOOPGPKA;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x416D5F0", Offset = "0x416BDF0", VA = "0x18416D5F0")]
	public MBDJHPLNCKM(List<DDLDJJBOBFK> BNEIKAOFBID, [Optional] MBDJHPLNCKM ECKBOFJGCOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NHDKDCEHONM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<MBDJHPLNCKM> POAHIHMLPGH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MBDJHPLNCKM JLLLOONDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x416D850", Offset = "0x416C050", VA = "0x18416D850")]
	public NHDKDCEHONM(MBDJHPLNCKM MIBMGGCCOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JJDBOBGKLCC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct ALJHGLOCLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int OPCJJEIMIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int EICCDBHBLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int GHFEHJKJEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int PDGLIHNPBOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BIDNNCIKHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int CFFIDCGCCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float JKAMOOHMOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<DDLDJJBOBFK> BNEIKAOFBID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum GPOJNGGDIBK
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
	private ALJHGLOCLDL KPGJGMNKMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int HDGGDGJGFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int JEBIFNMADDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int MCEDEBHPMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float IHNDIEBLIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float PLEHCBAEBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<MBDJHPLNCKM> GGIKFJJNOFD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NHDKDCEHONM EMICOGDIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4169F20", Offset = "0x4168720", VA = "0x184169F20")]
	public JJDBOBGKLCC(int JEBIFNMADDA, int MCEDEBHPMCJ, float IHNDIEBLIOL, int HDGGDGJGFHD, float PLEHCBAEBJD = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4169230", Offset = "0x4167A30", VA = "0x184169230")]
	public void EPKCMEILAII(List<DDLDJJBOBFK> BNEIKAOFBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x41693F0", Offset = "0x4167BF0", VA = "0x1841693F0")]
	public bool FILEGKGBHHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4169E10", Offset = "0x4168610", VA = "0x184169E10")]
	private float JKADFEPBMMD(Vector3 HCNLLMNMBJJ, Vector3 GLCPDOBBLPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4169D70", Offset = "0x4168570", VA = "0x184169D70")]
	private float JKADFEPBMMD(Vector3 GDBDJPILDNP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4169460", Offset = "0x4167C60", VA = "0x184169460")]
	private bool JHFANOILENJ(MBDJHPLNCKM KMMDFECFCJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x41686E0", Offset = "0x4166EE0", VA = "0x1841686E0")]
	private BIDNNCIKHIF EPIIFHEINAB(List<DDLDJJBOBFK> OGBIAGIMBJI, GPOJNGGDIBK AICMPAMDPCO)
	{
		return default(BIDNNCIKHIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4168350", Offset = "0x4166B50", VA = "0x184168350")]
	private void AFGPDAEBIHE(List<DDLDJJBOBFK> BNEIKAOFBID, Vector3[] DIHFFIIAGEM, Vector3[] FAMKHEBGLOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DFJKJNGKMHM
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x41617E0", Offset = "0x415FFE0", VA = "0x1841617E0")]
	public static Bounds FEMJKFJOFIO(List<DDLDJJBOBFK> BNEIKAOFBID)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4161990", Offset = "0x4160190", VA = "0x184161990")]
	public static int OOKDBLJACML(List<DDLDJJBOBFK> BNEIKAOFBID, NLJOEGOODPP GAKEOHNAFFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NJGLLGILDPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PHCNKNNAIOD LFJEBKLEGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PHCNKNNAIOD BIFCFBPLHIB;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static PHCNKNNAIOD FJMPNEKBBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private AFPAIFCAGMP AAEMFMDODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HKBINMDMLII GMKBNFKFIKL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle IEOOCNAEGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB90", Offset = "0x5BA390", VA = "0x1805BBB90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8544D0", Offset = "0x852CD0", VA = "0x1808544D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PNHLBMBKBAD.IDAHLMGIPII KMMDFECFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CCLPDPEPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xB249B0", Offset = "0xB231B0", VA = "0x180B249B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x416E8F0", Offset = "0x416D0F0", VA = "0x18416E8F0")]
	[IHAEEOOOIEN(HNJFJNMDEKM.ExitingPlayMode, 0)]
	private void LMOPHILPGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x416D900", Offset = "0x416C100", VA = "0x18416D900")]
	public void APFJAIJHKIL(PNHLBMBKBAD.IDAHLMGIPII KNCDODBFOGN, Transform NDFGBDJCFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x416E2F0", Offset = "0x416CAF0", VA = "0x18416E2F0")]
	public void EFCEFBJJBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x416E280", Offset = "0x416CA80", VA = "0x18416E280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x416E8B0", Offset = "0x416D0B0", VA = "0x18416E8B0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x416E960", Offset = "0x416D160", VA = "0x18416E960")]
	public NJGLLGILDPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LJMLDDMEAKN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IDJAPKJLGEH PCJFMJNHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AKHCDNBLMEN
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 DCGJIOHFADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IDMNNDCJFLM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool OGOHODHMKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PBOCAGEBFJC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action LLJAFGLLEHE;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MKAALACOFDE
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKAALACOFDE PMKNAMPEHGD(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKAALACOFDE ENFNDMNICEF(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MKAALACOFDE KNHANJGDGPB(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKAALACOFDE CBNPKPHPNFG(Action HPPFCEEDPMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class DGNBABPEPJO : MKAALACOFDE
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class HJHPIAKEFJM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public DGNBABPEPJO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public HJHPIAKEFJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x4161F10", Offset = "0x4160710", VA = "0x184161F10")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x4161F60", Offset = "0x4160760", VA = "0x184161F60")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4161FB0", Offset = "0x41607B0", VA = "0x184161FB0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> IDCAJIDBOII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action IDFBLLEBEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action LGPOLLIKEDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private GFAEBHLECCC IBOLMNGBOKB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action EJKCAAAIFBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x50B460", Offset = "0x509C60", VA = "0x18050B460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5E3D40", Offset = "0x5E2540", VA = "0x1805E3D40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action FFEAHLKJADA
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x801940", Offset = "0x800140", VA = "0x180801940", Slot = "4")]
			public MKAALACOFDE PMKNAMPEHGD(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA52C40", Offset = "0xA51440", VA = "0x180A52C40", Slot = "5")]
			public MKAALACOFDE ENFNDMNICEF(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA74B40", Offset = "0xA73340", VA = "0x180A74B40", Slot = "6")]
			public MKAALACOFDE KNHANJGDGPB(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA74BC0", Offset = "0xA733C0", VA = "0x180A74BC0", Slot = "7")]
			public MKAALACOFDE CBNPKPHPNFG(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6B5950", Offset = "0x6B4150", VA = "0x1806B5950")]
			public DGNBABPEPJO(Func<JobHandle> HGILCGICLGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4161B20", Offset = "0x4160320", VA = "0x184161B20")]
			public void DFPPOJLMNPG(Action NHOKDOBLGPF, Action LBGELHBIABM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4161D50", Offset = "0x4160550", VA = "0x184161D50")]
			public void EHAJBJDJBJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class OMLEOLJLLFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public MKAALACOFDE jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public OMLEOLJLLFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x1B6F4D0", Offset = "0x1B6DCD0", VA = "0x181B6F4D0")]
			internal bool <Remove>b__0(DGNBABPEPJO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class GNMILNHCCNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public DGNBABPEPJO newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public GNMILNHCCNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4161EB0", Offset = "0x41606B0", VA = "0x184161EB0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<DGNBABPEPJO> KPENKHHLEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<DGNBABPEPJO> NAMCCOHFBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private JEOMIDCJMHN MJIAKCIOCLL;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x416A040", Offset = "0x4168840", VA = "0x18416A040")]
		public MKAALACOFDE Add(Func<JobHandle> HGILCGICLGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x416A2E0", Offset = "0x4168AE0", VA = "0x18416A2E0")]
		public void Remove(MKAALACOFDE IEOOCNAEGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x416A150", Offset = "0x4168950", VA = "0x18416A150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x416A460", Offset = "0x4168C60", VA = "0x18416A460")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x416A630", Offset = "0x4168E30", VA = "0x18416A630")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x416A2D0", Offset = "0x4168AD0", VA = "0x18416A2D0")]
		[CompilerGenerated]
		private void PMJLHBEMNHP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GFAEBHLECCC
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GFAEBHLECCC PMKNAMPEHGD(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GFAEBHLECCC PFBIJGDPABC(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GFAEBHLECCC CBNPKPHPNFG(Action HPPFCEEDPMJ);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LGDADJEPBFL : GFAEBHLECCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle MMAMFGNHCBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action IDFBLLEBEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action GMFOEFKHLGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action FFEAHLKJADA;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool EKBFMLMDEEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x416C2E0", Offset = "0x416AAE0", VA = "0x18416C2E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA52C40", Offset = "0xA51440", VA = "0x180A52C40", Slot = "4")]
			public GFAEBHLECCC PMKNAMPEHGD(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA74B40", Offset = "0xA73340", VA = "0x180A74B40", Slot = "5")]
			public GFAEBHLECCC PFBIJGDPABC(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA74BC0", Offset = "0xA733C0", VA = "0x180A74BC0", Slot = "6")]
			public GFAEBHLECCC CBNPKPHPNFG(Action HPPFCEEDPMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x18F5EE0", Offset = "0x18F46E0", VA = "0x1818F5EE0")]
			public LGDADJEPBFL(JobHandle CMDMKDCMKKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x416C2A0", Offset = "0x416AAA0", VA = "0x18416C2A0")]
			public void BDHAHGNBAKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x416C2F0", Offset = "0x416AAF0", VA = "0x18416C2F0")]
			public void EHAJBJDJBJH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<LGDADJEPBFL> NDIEDKFGPCH;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x416AAB0", Offset = "0x41692B0", VA = "0x18416AAB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x416A6F0", Offset = "0x4168EF0", VA = "0x18416A6F0")]
		public GFAEBHLECCC Add(JobHandle CMDMKDCMKKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x416A9C0", Offset = "0x41691C0", VA = "0x18416A9C0")]
		public void Remove(GFAEBHLECCC IEOOCNAEGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x416A860", Offset = "0x4169060", VA = "0x18416A860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x416A780", Offset = "0x4168F80", VA = "0x18416A780")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x416ABC0", Offset = "0x41693C0", VA = "0x18416ABC0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class IAGGKLCNKGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] LHMKKNGADDJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int MGOKGGCOJHO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int FHPCKBOKGPL;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger KMAGGJIIKDL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IAGGKLCNKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4162CC0", Offset = "0x41614C0", VA = "0x184162CC0")]
	private static string POIGIBFCCMB(byte[] LANKPNEAHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4162990", Offset = "0x4161190", VA = "0x184162990")]
	public static string MHKKELLNKIL(byte[] OCICGABDCEM, bool MDIDJMNJINP)
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
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
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
