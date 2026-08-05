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
				[Cpp2IlInjected.Address(RVA = "0x426F4D0", Offset = "0x426E6D0", VA = "0x18426F4D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x19F4A80", Offset = "0x19F3C80", VA = "0x1819F4A80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x426F490", Offset = "0x426E690", VA = "0x18426F490")]
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
		[Cpp2IlInjected.Address(RVA = "0x4265810", Offset = "0x4264A10", VA = "0x184265810")]
		public LODSettings PLDBACBJHMA(GCPOJHCCJAJ JNHBFGDICNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x42657F0", Offset = "0x42649F0", VA = "0x1842657F0")]
		public int HNJFDBGEKHB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42656F0", Offset = "0x42648F0", VA = "0x1842656F0")]
		public int GFBCDDJHHNM(bool NOKBCEIHLIP, Vector3 ACMGFINEDIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4265820", Offset = "0x4264A20", VA = "0x184265820")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OBHKBBCGHMM
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
public interface DGHPDDKFODH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPNCDFLBMMD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NKCOMCIAMAP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PADGAOCEIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<BJCNNAGCAHF> OKLLALIEMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OBHKBBCGHMM CINGBHALIOF
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
	void UpdateClusterDistances(Vector3 MELLGBJNEMH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(APMLIKJDHMI POKGMNGDFOO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BJCNNAGCAHF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HACLCIANAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int NAIDDOIOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MJENIDJHANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LGAIOFJMKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte PIOJIEJLHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GMLEINAAGOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum EBGBMFOOIFF
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
	private sealed class EKKAPIJNCNJ : IEnumerator<JHIBAGNJJHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private JHIBAGNJJHH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GMLEINAAGOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JHIBAGNJJHH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
		[DebuggerHidden]
		public EKKAPIJNCNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4268910", Offset = "0x4267B10", VA = "0x184268910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x42689D0", Offset = "0x4267BD0", VA = "0x1842689D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IFCOEODBKDH : IEnumerator<JHIBAGNJJHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JHIBAGNJJHH <>2__current;

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
		private JHIBAGNJJHH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
		[DebuggerHidden]
		public IFCOEODBKDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x426E2D0", Offset = "0x426D4D0", VA = "0x18426E2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x426E420", Offset = "0x426D620", VA = "0x18426E420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DLGFLAPABOC : IEnumerator<JHIBAGNJJHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private JHIBAGNJJHH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GMLEINAAGOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<JHIBAGNJJHH> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private JHIBAGNJJHH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
		[DebuggerHidden]
		public DLGFLAPABOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4266BC0", Offset = "0x4265DC0", VA = "0x184266BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4267640", Offset = "0x4266840", VA = "0x184267640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EHFMOOCBFPC : IEnumerator<JHIBAGNJJHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JHIBAGNJJHH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GMLEINAAGOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private JHIBAGNJJHH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6387D0", Offset = "0x6379D0", VA = "0x1806387D0")]
		[DebuggerHidden]
		public EHFMOOCBFPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x42679D0", Offset = "0x4266BD0", VA = "0x1842679D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x42688C0", Offset = "0x4267AC0", VA = "0x1842688C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int OFIPGOJMEPM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer NJOGPFPLNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter DFCGKMGMMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject HOLMDCIILKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject FOELANCDNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public AMPGAOGENJC GLPOOCEKICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<APMLIKJDHMI> ILPFHMDPOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<APMLIKJDHMI> NOLIDMCDHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<APMLIKJDHMI> APIGOGFEMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int IALOOAHEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EBGBMFOOIFF PKOALFCJOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<NKCOMCIAMAP>[] DBPLMOFFKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<BJCNNAGCAHF>[] LEPKDOPBPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private FMGMHOFHKCI MBFINNCOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private FMGMHOFHKCI HFJCHABPKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private FMGMHOFHKCI NDLHOEDAHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int FNJHHKCCGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int CMNCFIGNPMI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static GMLEINAAGOI MGMBJGKIHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OHDGIBDHFKO FMLALMEOKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EDGMAIJPLEO CCANCBDDOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour EHBMLNAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material DCOAOLMKOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<DGHPDDKFODH> PPHEKDFLHCG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig ECEMKOIOHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HOJCMEOHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD8D880", Offset = "0xD8CA80", VA = "0x180D8D880")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD8D790", Offset = "0xD8C990", VA = "0x180D8D790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private EBGBMFOOIFF LKENGIFPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53ACD0", Offset = "0x539ED0", VA = "0x18053ACD0")]
		get
		{
			return default(EBGBMFOOIFF);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4269730", Offset = "0x4268930", VA = "0x184269730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static GMLEINAAGOI AACNHMOEADN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x426A690", Offset = "0x4269890", VA = "0x18426A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OFODMPNAAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x426A610", Offset = "0x4269810", VA = "0x18426A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HCHLOJEFOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x426A0B0", Offset = "0x42692B0", VA = "0x18426A0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NECJMHOJPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x426A110", Offset = "0x4269310", VA = "0x18426A110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4269860", Offset = "0x4268A60", VA = "0x184269860")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IGHMGKELDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42694E0", Offset = "0x42686E0", VA = "0x1842694E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x426AFB0", Offset = "0x426A1B0", VA = "0x18426AFB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x426B790", Offset = "0x426A990", VA = "0x18426B790")]
	public GMLEINAAGOI(OHDGIBDHFKO FMLALMEOKNL, EDGMAIJPLEO CCANCBDDOIM, ClusterLODConfig LHKNHGNPKFO, MonoBehaviour EHBMLNAHEEK, Material DCOAOLMKOFF, ClusterMeshRenderer NJOGPFPLNGK, MeshFilter DFCGKMGMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x426B6B0", Offset = "0x426A8B0", VA = "0x18426B6B0")]
	private void PDHHNHGMJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4269600", Offset = "0x4268800", VA = "0x184269600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x426A1F0", Offset = "0x42693F0", VA = "0x18426A1F0")]
	public static void JELMOEDJEJF(Vector3 JALICJDEOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x426B320", Offset = "0x426A520", VA = "0x18426B320")]
	private void OFMEKFBMIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4269310", Offset = "0x4268510", VA = "0x184269310")]
	private void BIALLBCHAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x426A4D0", Offset = "0x42696D0", VA = "0x18426A4D0")]
	private void KBELIEIFECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4269980", Offset = "0x4268B80", VA = "0x184269980")]
	public void FBDGMKEAJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4269470", Offset = "0x4268670", VA = "0x184269470")]
	[IteratorStateMachine(typeof(EKKAPIJNCNJ))]
	private IEnumerator<JHIBAGNJJHH> BKJNKLFFGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4269E40", Offset = "0x4269040", VA = "0x184269E40")]
	[IteratorStateMachine(typeof(IFCOEODBKDH))]
	private IEnumerator<JHIBAGNJJHH> FNOBMJLDNBA(Func<bool> HPPHKJFEINA, float BEGHGGLCMIP, Func<string> GMLEIFLIDLE, float LHDAHDHPOAA = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x426A3F0", Offset = "0x42695F0", VA = "0x18426A3F0")]
	[IteratorStateMachine(typeof(DLGFLAPABOC))]
	private IEnumerator<JHIBAGNJJHH> JLCNLCOPHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x426B050", Offset = "0x426A250", VA = "0x18426B050")]
	public void NGICIKNJLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4269580", Offset = "0x4268780", VA = "0x184269580")]
	public void DPAKFNDNBPE(IEnumerable<NKCOMCIAMAP> JINKFLIIMAK, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x426B400", Offset = "0x426A600", VA = "0x18426B400")]
	public void PBFFOLEENOG(IEnumerable<NKCOMCIAMAP> JINKFLIIMAK, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x426A840", Offset = "0x4269A40", VA = "0x18426A840")]
	public List<ClusterMeshRenderer> MGFCBCBDMMD(List<APMLIKJDHMI> IPELIJOCGMA, Transform AOFPBKDCBAI, OBHKBBCGHMM DNFEMGFCDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42692D0", Offset = "0x42684D0", VA = "0x1842692D0")]
	public OBHKBBCGHMM AIHKCHOFONF(Vector3 DBFALGHBACB)
	{
		return default(OBHKBBCGHMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x426B260", Offset = "0x426A460", VA = "0x18426B260")]
	public void NKDKBPPOFAO(DGHPDDKFODH PFABOHNFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x426B2C0", Offset = "0x426A4C0", VA = "0x18426B2C0")]
	public bool NMAPOFFNIFL(DGHPDDKFODH PFABOHNFPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4269410", Offset = "0x4268610", VA = "0x184269410")]
	public void BICAMJGPKII(APMLIKJDHMI FFANAPJLDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4269C50", Offset = "0x4268E50", VA = "0x184269C50")]
	public void FKJPECNPBEM(BJCNNAGCAHF GPLDLIFCHLE, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4269900", Offset = "0x4268B00", VA = "0x184269900")]
	public void EODNIMKAPJH(BJCNNAGCAHF GPLDLIFCHLE, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x426A710", Offset = "0x4269910", VA = "0x18426A710")]
	private void KGKBIENOMAI(Vector3 MELLGBJNEMH, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4269CD0", Offset = "0x4268ED0", VA = "0x184269CD0")]
	private void FLDLFKGEAJM(Vector3 MELLGBJNEMH, OBHKBBCGHMM DNFEMGFCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x426A460", Offset = "0x4269660", VA = "0x18426A460")]
	[IteratorStateMachine(typeof(EHFMOOCBFPC))]
	private IEnumerator<JHIBAGNJJHH> KADONMMBNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x426A280", Offset = "0x4269480", VA = "0x18426A280")]
	private int JIPBBAHHKHL(int NCBDKCDKIIG, int FEENNEOAPHG, List<BJCNNAGCAHF> EHOPOEINMEE, byte JNHBFGDICNI, ref int NCMOKHIANKA, float PIJDFBECBBK = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4269EE0", Offset = "0x42690E0", VA = "0x184269EE0")]
	public void FPHPJLPLMOJ(APMLIKJDHMI POKGMNGDFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x426B3C0", Offset = "0x426A5C0", VA = "0x18426B3C0")]
	public bool PAPBCJJNBBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B08F0", Offset = "0x5AFAF0", VA = "0x1805B08F0")]
	public Material BMCCOIBGILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x426A1B0", Offset = "0x42693B0", VA = "0x18426A1B0")]
	public int HNJFDBGEKHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x426B740", Offset = "0x426A940", VA = "0x18426B740")]
	[CompilerGenerated]
	private bool PFKGMHPNAGM()
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
		[Cpp2IlInjected.Address(RVA = "0xD72680", Offset = "0xD71880", VA = "0x180D72680")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HPPOFPGAABB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> JGGHIKHIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> CIGKCPMMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> JGILPHKMGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> IMIGNNKIFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> KPDJIGCDKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> PCAPBAGPGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> JBALHLBKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 CDLDNCGGNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float CJBDPDDOMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> DAOKCLNHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> EDHBOEJBNHD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x426E210", Offset = "0x426D410", VA = "0x18426E210")]
	public HPPOFPGAABB(OGNOIBAIHLG BBEEEJLCJOC, NativeList<float3> JBALHLBKDPJ, NativeMultiHashMap<int, int> DAOKCLNHMNM, NativeArray<int> EDHBOEJBNHD, Vector3 CDLDNCGGNNG, float CJBDPDDOMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x426DF10", Offset = "0x426D110", VA = "0x18426DF10")]
	private int KHPOPJBIMLG(float3 MELLGBJNEMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x426DF70", Offset = "0x426D170", VA = "0x18426DF70")]
	private int PNBOBJONDMJ(int JBMKKAKPADN, int FOOEPPOEAPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x426DB20", Offset = "0x426CD20", VA = "0x18426DB20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EOFJABKIGGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> DAOKCLNHMNM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> EDHBOEJBNHD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int KEGONDDFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> ILCMFOPLJAA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4268AD0", Offset = "0x4267CD0", VA = "0x184268AD0")]
	public void GDKNPELOOBI(int AHIOBFMLIDC, Allocator MBJHKFOJELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4268A20", Offset = "0x4267C20", VA = "0x184268A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public EOFJABKIGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct FPECLNDKOHD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> BJHADPBICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> ILDGHONJICD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x42692A0", Offset = "0x42684A0", VA = "0x1842692A0")]
	public FPECLNDKOHD(EOFJABKIGGF OKJCKONMLCE, OGNOIBAIHLG BBEEEJLCJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4269210", Offset = "0x4268410", VA = "0x184269210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct PMDHENJHIEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> CFEKDHOIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> HLIJPNAEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> HDJLPDJDBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> MBLCMNDJBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> LPEAHKOJFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> ILCMFOPLJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> BJHADPBICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> EAABKJJIOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> EOAHAEAFJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> NKEPOMCOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> CKLGHHNIFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> BHECOAFONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> IAKCMCFJNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float AEIPIOBGPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float MLAJJCJPEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 CLNGALLIAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float HOECPJKOIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float KNNBNLDEJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float GOLKANOJBKK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4275A90", Offset = "0x4274C90", VA = "0x184275A90")]
	public PMDHENJHIEJ(EOFJABKIGGF GIBOGKPADBD, OGNOIBAIHLG BBEEEJLCJOC, OGNOIBAIHLG HGFJDNOELOC, float KNNBNLDEJPH, float GOLKANOJBKK, Vector3 CLNGALLIAMC, float HOECPJKOIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4275140", Offset = "0x4274340", VA = "0x184275140")]
	private float3 IHILEICGFCC(int JBMKKAKPADN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x42756B0", Offset = "0x42748B0", VA = "0x1842756B0")]
	private void LJAKKEMNFFI(int JBMKKAKPADN, out float3 EBIDOPEDKOF, out float3 BLKDIHFDMOM, out float4 ALLEHIOGMAL, out float4 FJCEFPKEDOK, out float2 IKABGABBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4274E10", Offset = "0x4274010", VA = "0x184274E10")]
	private int HBFGJNNGDFD(int EJBLHAJNJHE, int JIBFELHLBDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4275890", Offset = "0x4274A90", VA = "0x184275890")]
	private void OKPFNJDPDKL(int EJBLHAJNJHE, int JIBFELHLBDE, int CLCOHIOKADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42751E0", Offset = "0x42743E0", VA = "0x1842751E0")]
	private bool KACLOONNAOO(int EJBLHAJNJHE, int JIBFELHLBDE, float INGDKFFCPHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4275370", Offset = "0x4274570", VA = "0x184275370")]
	private bool KICKLNGNHJN(int EJBLHAJNJHE, int JIBFELHLBDE, int CLCOHIOKADF, float INGDKFFCPHF, bool JLIHMKICNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4275450", Offset = "0x4274650", VA = "0x184275450")]
	private bool LFFNGHPLMHB(int EJBLHAJNJHE, int JIBFELHLBDE, int CLCOHIOKADF, float INGDKFFCPHF, bool JLIHMKICNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4275430", Offset = "0x4274630", VA = "0x184275430")]
	private void KINGJBOPMPM(int EJBLHAJNJHE, int JIBFELHLBDE, int CLCOHIOKADF, out int BKLNPGGCODG, out int ELANLAAKCMG, out int IHLENMKEJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42744B0", Offset = "0x42736B0", VA = "0x1842744B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OPOBNJBBIJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NNDMMALOCPD : IDisposable, BJCNNAGCAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds NIEPJDKJDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<APMLIKJDHMI> IPELIJOCGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 KMKOGHJCLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 EOJAENKCKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int HHPJEODMALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public OGNOIBAIHLG HDONPGDCHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EOFJABKIGGF FBBOJKABGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform AOFPBKDCBAI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int DBMMKFLGNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4270E60", Offset = "0x4270060", VA = "0x184270E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh FBKMOGCPBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh FEHPDFLBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x528010", Offset = "0x527210", VA = "0x180528010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x528020", Offset = "0x527220", VA = "0x180528020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MJENIDJHANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE21EC0", Offset = "0xE210C0", VA = "0x180E21EC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1DB2360", Offset = "0x1DB1560", VA = "0x181DB2360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte PIOJIEJLHLL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C50", Offset = "0x6A2E50", VA = "0x1806A3C50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6A3DE0", Offset = "0x6A2FE0", VA = "0x1806A3DE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HACLCIANAIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x70B4C0", Offset = "0x70A6C0", VA = "0x18070B4C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x70AB50", Offset = "0x709D50", VA = "0x18070AB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NAIDDOIOBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAEF4E0", Offset = "0xAEE6E0", VA = "0x180AEF4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD55080", Offset = "0xD54280", VA = "0x180D55080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float LGAIOFJMKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4270810", Offset = "0x426FA10", VA = "0x184270810", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4270EA0", Offset = "0x42700A0", VA = "0x184270EA0")]
		public void MALKPBNMJKJ(GCPOJHCCJAJ JNHBFGDICNI, out int LCKFCPPOHAO, out int MKDEAPNNDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4270CC0", Offset = "0x426FEC0", VA = "0x184270CC0")]
		public void JGLPKMFFHHG(GCPOJHCCJAJ JNHBFGDICNI, BPGGFIADKDC JGGCNLIJCPH, int DEAPKKJJNME = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4270830", Offset = "0x426FA30", VA = "0x184270830")]
		public void DLOAMKDCEOC(NativeList<HIDEMNMNBKB> KJMMKKFDBBI, Transform PPJGENLLLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4270770", Offset = "0x426F970", VA = "0x184270770")]
		public void AOBNGPDHNHM(Mesh BBEEEJLCJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42710D0", Offset = "0x42702D0", VA = "0x1842710D0")]
		public void PCPJEOEFCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4270B50", Offset = "0x426FD50", VA = "0x184270B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4271170", Offset = "0x4270370", VA = "0x184271170")]
		public NNDMMALOCPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds NIEPJDKJDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<NNDMMALOCPD> NLNGONCMDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public OHFBFFFBEJA NHLLDHDANLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer IHLDAMDNKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int DDAHMNPKHHO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh JBLPLBGIDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5500C0", Offset = "0x54F2C0", VA = "0x1805500C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64AA90", Offset = "0x649C90", VA = "0x18064AA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DLEKBIGEOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DE20", VA = "0x18077EC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77ECA0", Offset = "0x77DEA0", VA = "0x18077ECA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int PADGAOCEIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x42736D0", Offset = "0x42728D0", VA = "0x1842736D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4272D50", Offset = "0x4271F50", VA = "0x184272D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4273440", Offset = "0x4272640", VA = "0x184273440")]
	public int ELOPJCMAIKN(int ACNEBGJOLMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4273720", Offset = "0x4272920", VA = "0x184273720")]
	public void LADJBEDBEBL(ALDAPGCAGEJ GGNIACOFCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4272640", Offset = "0x4271840", VA = "0x184272640")]
	public void DNMJLHFNDJO(Transform PPJGENLLLFF, bool GOBMHIGLIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4272490", Offset = "0x4271690", VA = "0x184272490")]
	public bool CGJCMKDDNDI(bool HAGHACMOILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4272EB0", Offset = "0x42720B0", VA = "0x184272EB0")]
	public void ECHKPOAGMDG(Transform AOFPBKDCBAI, bool GOBMHIGLIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4273470", Offset = "0x4272670", VA = "0x184273470")]
	public bool FPHPJLPLMOJ(APMLIKJDHMI POKGMNGDFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x42738B0", Offset = "0x4272AB0", VA = "0x1842738B0")]
	public OPOBNJBBIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AMPGAOGENJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<OPOBNJBBIJP.NNDMMALOCPD> HNHJMBHAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MLHNMHGLIJP FGPBKNJDBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<OPOBNJBBIJP.NNDMMALOCPD> ALMMGFLFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int LEMLFFOECII;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4264D60", Offset = "0x4263F60", VA = "0x184264D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4264DD0", Offset = "0x4263FD0", VA = "0x184264DD0")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4265410", Offset = "0x4264610", VA = "0x184265410")]
	public void JPGLGPDLMNH(OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN, Transform AOFPBKDCBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4264E50", Offset = "0x4264050", VA = "0x184264E50")]
	public void FPHPJLPLMOJ(OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x42652E0", Offset = "0x42644E0", VA = "0x1842652E0")]
	private OPOBNJBBIJP.NNDMMALOCPD INOADAFNONK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4265000", Offset = "0x4264200", VA = "0x184265000")]
	private bool HKHLOKACCNI(OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42654C0", Offset = "0x42646C0", VA = "0x1842654C0")]
	private void OKAFILJFIAM(OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4264CC0", Offset = "0x4263EC0", VA = "0x184264CC0")]
	public bool AEINIGGDCDP(OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4265090", Offset = "0x4264290", VA = "0x184265090")]
	public bool IGIHOBELMJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4264D00", Offset = "0x4263F00", VA = "0x184264D00")]
	private OPOBNJBBIJP.NNDMMALOCPD BDGGBMNOBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4265520", Offset = "0x4264720", VA = "0x184265520")]
	public AMPGAOGENJC()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD72680", Offset = "0xD71880", VA = "0x180D72680")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FGEOILGCOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int AICLAJMKHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int GGFAIEKHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float JPPEJKOAGGL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<OPOBNJBBIJP> CNBJKDDIAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x42691C0", Offset = "0x42683C0", VA = "0x1842691C0")]
	public FGEOILGCOOM(int AICLAJMKHOJ, int GGFAIEKHMDG, float MEKJGDBMAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4269080", Offset = "0x4268280", VA = "0x184269080")]
	public void IFIIDIDGLNJ(MHKLKFIOJJM OBNIPGGHNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4269120", Offset = "0x4268320", VA = "0x184269120")]
	private int IGFKOBHGKED(ALDAPGCAGEJ BABNEKFABNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4268E50", Offset = "0x4268050", VA = "0x184268E50")]
	private void IFIIDIDGLNJ(ALDAPGCAGEJ BABNEKFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4268C70", Offset = "0x4267E70", VA = "0x184268C70")]
	private void FKDDGKOKIPL(ALDAPGCAGEJ BABNEKFABNN, OPOBNJBBIJP KGDDMCAFFEK)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, NKCOMCIAMAP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HAHAEHICOFD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
			[DebuggerHidden]
			public HAHAEHICOFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x426BD10", Offset = "0x426AF10", VA = "0x18426BD10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x426BEA0", Offset = "0x426B0A0", VA = "0x18426BEA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x426BE00", Offset = "0x426B000", VA = "0x18426BE00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x426BE00", Offset = "0x426B000", VA = "0x18426BE00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int PADGAOCEIFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4266B60", Offset = "0x4265D60", VA = "0x184266B60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<BJCNNAGCAHF> OKLLALIEMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x4266B40", Offset = "0x4265D40", VA = "0x184266B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> NLNGONCMDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public OPOBNJBBIJP JBLPLBGIDHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public OBHKBBCGHMM CINGBHALIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x528390", Offset = "0x527590", VA = "0x180528390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(OBHKBBCGHMM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x668E90", Offset = "0x668090", VA = "0x180668E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HOGCDMDEHEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4266B50", Offset = "0x4265D50", VA = "0x184266B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4265880", Offset = "0x4264A80", VA = "0x184265880")]
		public static ClusterMeshRenderer Create(OPOBNJBBIJP BBEEEJLCJOC, ClusterMeshRenderer NJOGPFPLNGK, MeshFilter DFCGKMGMMCO, Transform AOFPBKDCBAI, OBHKBBCGHMM DNFEMGFCDJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4265990", Offset = "0x4264B90", VA = "0x184265990", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x42660F0", Offset = "0x42652F0", VA = "0x1842660F0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(APMLIKJDHMI POKGMNGDFOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4265EC0", Offset = "0x42650C0", VA = "0x184265EC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4265BF0", Offset = "0x4264DF0", VA = "0x184265BF0")]
		public void Init(OPOBNJBBIJP BBEEEJLCJOC, MeshFilter DFCGKMGMMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x42659F0", Offset = "0x4264BF0", VA = "0x1842659F0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4266220", Offset = "0x4265420", VA = "0x184266220", Slot = "8")]
		public void UpdateClusterDistances(Vector3 MELLGBJNEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4266460", Offset = "0x4265660", VA = "0x184266460", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4265B80", Offset = "0x4264D80", VA = "0x184265B80")]
		[IteratorStateMachine(typeof(HAHAEHICOFD))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4265F40", Offset = "0x4265140", VA = "0x184265F40")]
		public void SetupTagAndLayer(string CALNPGGIJAH, int DNFEMGFCDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4265F20", Offset = "0x4265120", VA = "0x184265F20")]
		public bool Remove(APMLIKJDHMI POKGMNGDFOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD72680", Offset = "0xD71880", VA = "0x180D72680")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LFADKCEOJAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int BHCNKFCKJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GAHGFCKGLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MKDEAPNNDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LCKFCPPOHAO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x426F470", Offset = "0x426E670", VA = "0x18426F470")]
	public LFADKCEOJAP(int GAHGFCKGLIO, int MKDEAPNNDJI, int BHCNKFCKJID, int LCKFCPPOHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OHFBFFFBEJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> JGGHIKHIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> ILCMFOPLJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> PCAPBAGPGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<LFADKCEOJAP> DKDGAIMLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> JBNLBGABFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> AEOJLHCLLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> MIOHIOODEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle IEJGNHPLMOP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FOHHHJOHKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E40", Offset = "0x6F3040", VA = "0x1806F3E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E60", Offset = "0x6F3060", VA = "0x1806F3E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4271710", Offset = "0x4270910", VA = "0x184271710")]
	public void JKGEAPANBJD(OGNOIBAIHLG AABLDJOABLC, NativeList<LFADKCEOJAP> DKDGAIMLMFM, float KOODODKFGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x42714C0", Offset = "0x42706C0", VA = "0x1842714C0")]
	public void IOIKLENHHDE(Transform AOFPBKDCBAI, bool GOBMHIGLIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4271230", Offset = "0x4270430", VA = "0x184271230")]
	public void CGJCMKDDNDI(OPOBNJBBIJP IHLDAMDNKLJ, bool HAGHACMOILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x42713C0", Offset = "0x42705C0", VA = "0x1842713C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4271490", Offset = "0x4270690", VA = "0x184271490")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public OHFBFFFBEJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct PDFDAPANJLD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> JGGHIKHIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> ILCMFOPLJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<LFADKCEOJAP> IPINLCPNLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> JBNLBGABFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 CLNGALLIAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> AEOJLHCLLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> MIOHIOODEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GOBMHIGLIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float NEFAKKOMNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float FDAPGGPLEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float LHNAMKFMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> PCAPBAGPGEI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4273DF0", Offset = "0x4272FF0", VA = "0x184273DF0")]
	public PDFDAPANJLD(OHFBFFFBEJA HMEMLGDDAOO, Vector3 CLNGALLIAMC, bool GOBMHIGLIME, float NEFAKKOMNNC, float FDAPGGPLEAN, float LHNAMKFMMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4273950", Offset = "0x4272B50", VA = "0x184273950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface APMLIKJDHMI : DOHHFHAJLJD
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds KMCGCCLLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HIDEMNMNBKB OHIBILPJFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ALDAPGCAGEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<APMLIKJDHMI> IPELIJOCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public ALDAPGCAGEJ KJAPOBPIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public ALDAPGCAGEJ EEFPEMPODLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public ALDAPGCAGEJ CPIINHFMIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int LCKFCPPOHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds NIEPJDKJDIF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4264C40", Offset = "0x4263E40", VA = "0x184264C40")]
	public ALDAPGCAGEJ(List<APMLIKJDHMI> IPELIJOCGMA, [Optional] ALDAPGCAGEJ KJAPOBPIAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MHKLKFIOJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<ALDAPGCAGEJ> BEHJCLFDOHJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ALDAPGCAGEJ AJOEJMPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x426F4F0", Offset = "0x426E6F0", VA = "0x18426F4F0")]
	public MHKLKFIOJJM(ALDAPGCAGEJ AOFPBKDCBAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HOLOACICMKH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct GAJKGBJPMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int EENOPOEPINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int AHFANBBCLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int ELIJDEALOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int MCAEIEMFGLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct LBFAAKNDFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DOHEAKBBLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float FCGAENAHAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<APMLIKJDHMI> IPELIJOCGMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum KCLBABMNMKA
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
	private GAJKGBJPMNP NIJGGKMFFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int PELOGENBFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int AICLAJMKHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GGFAIEKHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float MEKJGDBMAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float EIEAMDEPKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<ALDAPGCAGEJ> DGJDOLBEBLJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MHKLKFIOJJM EHCLHNABJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x426DAC0", Offset = "0x426CCC0", VA = "0x18426DAC0")]
	public HOLOACICMKH(int AICLAJMKHOJ, int GGFAIEKHMDG, float MEKJGDBMAHM, int PELOGENBFMI, float EIEAMDEPKOA = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x426D350", Offset = "0x426C550", VA = "0x18426D350")]
	public void GEANKPEHAIP(List<APMLIKJDHMI> IPELIJOCGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x426DA50", Offset = "0x426CC50", VA = "0x18426DA50")]
	public bool MIADGNCAPMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x426D5B0", Offset = "0x426C7B0", VA = "0x18426D5B0")]
	private float LBDHIKNAPJP(Vector3 JGLPPLOILDC, Vector3 COHOBPFBJCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x426D510", Offset = "0x426C710", VA = "0x18426D510")]
	private float LBDHIKNAPJP(Vector3 AADFONHDDBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x426BEF0", Offset = "0x426B0F0", VA = "0x18426BEF0")]
	private bool EILFNNJJAFE(ALDAPGCAGEJ IAOLJFFEKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x426C800", Offset = "0x426BA00", VA = "0x18426C800")]
	private LBFAAKNDFIC FDKMFGNKBPO(List<APMLIKJDHMI> OLNECOPCAME, KCLBABMNMKA KDGPDLPEBOK)
	{
		return default(LBFAAKNDFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x426D6C0", Offset = "0x426C8C0", VA = "0x18426D6C0")]
	private void LMCIBMEEKMM(List<APMLIKJDHMI> IPELIJOCGMA, Vector3[] NHAHIGAPABO, Vector3[] HDNBGJAOAGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DOIEGCLBBFM
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4267820", Offset = "0x4266A20", VA = "0x184267820")]
	public static Bounds KGCEDLOOPJB(List<APMLIKJDHMI> IPELIJOCGMA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4267690", Offset = "0x4266890", VA = "0x184267690")]
	public static int GJMJDEGLGPE(List<APMLIKJDHMI> IPELIJOCGMA, GCPOJHCCJAJ JNHBFGDICNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MLHNMHGLIJP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private OGNOIBAIHLG EKJKPCNLMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private OGNOIBAIHLG PADAMELJMGG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static OGNOIBAIHLG FBFBPKCIKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private CBNEKMIEHKE FFCLKKCBKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private BPGGFIADKDC JGGCNLIJCPH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle IEJGNHPLMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85B4E0", Offset = "0x85A6E0", VA = "0x18085B4E0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85B500", Offset = "0x85A700", VA = "0x18085B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public OPOBNJBBIJP.NNDMMALOCPD IAOLJFFEKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ADELHHFOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x687CA0", Offset = "0x686EA0", VA = "0x180687CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x426FFD0", Offset = "0x426F1D0", VA = "0x18426FFD0")]
	[CLKPILCBOON(IMMNKPOABLM.ExitingPlayMode, 0)]
	private void LGEKKBHMDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x426F650", Offset = "0x426E850", VA = "0x18426F650")]
	public void JKGEAPANBJD(OPOBNJBBIJP.NNDMMALOCPD IPINLCPNLDM, Transform OMFFPGNGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4270040", Offset = "0x426F240", VA = "0x184270040")]
	public void OMODFOPCKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x426F5A0", Offset = "0x426E7A0", VA = "0x18426F5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x426F610", Offset = "0x426E810", VA = "0x18426F610")]
	public void FGLHFGIEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4270600", Offset = "0x426F800", VA = "0x184270600")]
	public MLHNMHGLIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NBIMIMLFDLI
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GMLEINAAGOI KBGMEANAGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EDGMAIJPLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 LKBLCJIBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OHDGIBDHFKO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool BOKCAEANPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NHHANGNFFAL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action MPEEPIJFACD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GLMONBKJILN
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLMONBKJILN FOKFDICBEKM(Action EPOOCOJOAOK);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GLMONBKJILN HPKCHMPAPIA(Action EPOOCOJOAOK);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GLMONBKJILN OMIADKIHHGO(Action EPOOCOJOAOK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLMONBKJILN AHHNKIHEELI(Action EPOOCOJOAOK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class KJBKMEIJEIA : GLMONBKJILN
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class MODJKFEJKCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public KJBKMEIJEIA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
				public MODJKFEJKCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x4270690", Offset = "0x426F890", VA = "0x184270690")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x42706E0", Offset = "0x426F8E0", VA = "0x1842706E0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4270730", Offset = "0x426F930", VA = "0x184270730")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> JEMOCBIOBHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action BAEBNBCEKAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action ICGOJECFLGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private OPGJELJMPPN BOGDPNEFOED;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action GIKBPKEIKNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5500C0", Offset = "0x54F2C0", VA = "0x1805500C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x64AA90", Offset = "0x649C90", VA = "0x18064AA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action ANJPNCIOEOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x24A8F10", Offset = "0x24A8110", VA = "0x1824A8F10", Slot = "4")]
			public GLMONBKJILN FOKFDICBEKM(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x285DD60", Offset = "0x285CF60", VA = "0x18285DD60", Slot = "5")]
			public GLMONBKJILN HPKCHMPAPIA(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x285DD80", Offset = "0x285CF80", VA = "0x18285DD80", Slot = "6")]
			public GLMONBKJILN OMIADKIHHGO(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1563050", Offset = "0x1562250", VA = "0x181563050", Slot = "7")]
			public GLMONBKJILN AHHNKIHEELI(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x688A70", Offset = "0x687C70", VA = "0x180688A70")]
			public KJBKMEIJEIA(Func<JobHandle> DEOGLMELIHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x426F0E0", Offset = "0x426E2E0", VA = "0x18426F0E0")]
			public void FDBMIANHBGI(Action JPKCOFEMGIF, Action OIOOALNAFFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x426F310", Offset = "0x426E510", VA = "0x18426F310")]
			public void FPHPJLPLMOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class PMMNKNNNGGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public GLMONBKJILN jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public PMMNKNNNGGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4275BD0", Offset = "0x4274DD0", VA = "0x184275BD0")]
			internal bool <Remove>b__0(KJBKMEIJEIA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KEMMHKECJPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public KJBKMEIJEIA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public KEMMHKECJPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x426F080", Offset = "0x426E280", VA = "0x18426F080")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<KJBKMEIJEIA> LDNIMOAMAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<KJBKMEIJEIA> DJGLEIPBPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private FMGMHOFHKCI PKMNDPHNENN;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x426E470", Offset = "0x426D670", VA = "0x18426E470")]
		public GLMONBKJILN Add(Func<JobHandle> DEOGLMELIHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x426E710", Offset = "0x426D910", VA = "0x18426E710")]
		public void Remove(GLMONBKJILN IEJGNHPLMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x426E590", Offset = "0x426D790", VA = "0x18426E590", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x426E890", Offset = "0x426DA90", VA = "0x18426E890")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x426EA60", Offset = "0x426DC60", VA = "0x18426EA60")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x426E580", Offset = "0x426D780", VA = "0x18426E580")]
		[CompilerGenerated]
		private void GAICDIMKDGB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OPGJELJMPPN
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPGJELJMPPN FOKFDICBEKM(Action EPOOCOJOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPGJELJMPPN LCLMMJJKLCM(Action EPOOCOJOAOK);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPGJELJMPPN AHHNKIHEELI(Action EPOOCOJOAOK);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BAKBLNIGMBI : OPGJELJMPPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle DKJBPNJINJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action BAEBNBCEKAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action FEPOKDKJAAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action ANJPNCIOEOE;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool PEFJEEBPCFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x42656A0", Offset = "0x42648A0", VA = "0x1842656A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x285DD60", Offset = "0x285CF60", VA = "0x18285DD60", Slot = "4")]
			public OPGJELJMPPN FOKFDICBEKM(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x285DD80", Offset = "0x285CF80", VA = "0x18285DD80", Slot = "5")]
			public OPGJELJMPPN LCLMMJJKLCM(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1563050", Offset = "0x1562250", VA = "0x181563050", Slot = "6")]
			public OPGJELJMPPN AHHNKIHEELI(Action EPOOCOJOAOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC85200", Offset = "0xC84400", VA = "0x180C85200")]
			public BAKBLNIGMBI(JobHandle LNJLCJKCOOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x42656B0", Offset = "0x42648B0", VA = "0x1842656B0")]
			public void LLIICMGDJCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4265660", Offset = "0x4264860", VA = "0x184265660")]
			public void FPHPJLPLMOJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<BAKBLNIGMBI> CJOCBHODPID;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x426EEE0", Offset = "0x426E0E0", VA = "0x18426EEE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x426EB20", Offset = "0x426DD20", VA = "0x18426EB20")]
		public OPGJELJMPPN Add(JobHandle LNJLCJKCOOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x426EDF0", Offset = "0x426DFF0", VA = "0x18426EDF0")]
		public void Remove(OPGJELJMPPN IEJGNHPLMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x426EC90", Offset = "0x426DE90", VA = "0x18426EC90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x426EBB0", Offset = "0x426DDB0", VA = "0x18426EBB0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x426EFF0", Offset = "0x426E1F0", VA = "0x18426EFF0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class PEGOPLHHMHI
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] HIBFFCCJJHD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int BICBCGELOBK;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int ILHMFLHJGFF;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger OJJMNJJEBED;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PEGOPLHHMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x42741F0", Offset = "0x42733F0", VA = "0x1842741F0")]
	private static string MCCHLMPJJNK(byte[] DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4273EC0", Offset = "0x42730C0", VA = "0x184273EC0")]
	public static string ACFPKMGBPMA(byte[] GMBNEFEOHLO, bool EDLKFPFOADI)
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
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
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
