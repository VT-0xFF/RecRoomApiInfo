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
				[Cpp2IlInjected.Address(RVA = "0x40E38B0", Offset = "0x40E1EB0", VA = "0x1840E38B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xDB3440", Offset = "0xDB1A40", VA = "0x180DB3440")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x40E3870", Offset = "0x40E1E70", VA = "0x1840E3870")]
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
		[Cpp2IlInjected.Address(RVA = "0x40DAB80", Offset = "0x40D9180", VA = "0x1840DAB80")]
		public LODSettings HIHGGCCAIIB(EJDOKGPECCP HPMCIOMIFLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x40DAB60", Offset = "0x40D9160", VA = "0x1840DAB60")]
		public int DNMPPHFAOGL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40DAB90", Offset = "0x40D9190", VA = "0x1840DAB90")]
		public int LMPLPLAOJPE(bool ACAFNNEAPDN, Vector3 IBMBHELBOGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40DAC90", Offset = "0x40D9290", VA = "0x1840DAC90")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IJOEJNDINHL
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
public interface DPLBJALAIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKOJDAOLAPM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CBFJGOEFCOD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GLOINABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IGDJNEFBHIA> HEMIIGIBMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IJOEJNDINHL GAOEFBFMOGC
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
	void UpdateClusterDistances(Vector3 JEMEDOGFIKH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(NOGMKPHNPLB FCDBKPGBIPA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IGDJNEFBHIA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int CPDKPKAIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GIOAEJBPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float GANOHEMHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BPOJKHMMNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte MIOKGNAMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OGDFBPJBKIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CLIAACLCDCD
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
	private sealed class ELCADLBOCPP : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OGDFBPJBKIJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public ELCADLBOCPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40DF450", Offset = "0x40DDA50", VA = "0x1840DF450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40DF510", Offset = "0x40DDB10", VA = "0x1840DF510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FNLBNHEHONI : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private KBDFKOBHGAA <>2__current;

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
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public FNLBNHEHONI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x40DF570", Offset = "0x40DDB70", VA = "0x1840DF570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x40DF6C0", Offset = "0x40DDCC0", VA = "0x1840DF6C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MOFEBKBHNAO : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OGDFBPJBKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<KBDFKOBHGAA> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public MOFEBKBHNAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40E3C10", Offset = "0x40E2210", VA = "0x1840E3C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x40E4690", Offset = "0x40E2C90", VA = "0x1840E4690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GDHKMMMLFIL : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public OGDFBPJBKIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public GDHKMMMLFIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x40DF8F0", Offset = "0x40DDEF0", VA = "0x1840DF8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x40E07E0", Offset = "0x40DEDE0", VA = "0x1840E07E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int KGDAJNAEKFJ = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer MFIEFKEAPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter KFPJPGDHMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject NCPIIBGPLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject DIHFDOCKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public JFBHCJHIDHA PIJKGJPCBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<NOGMKPHNPLB> JDIGLFOOOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<NOGMKPHNPLB> NILAAIDECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<NOGMKPHNPLB> OANJFDIBGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int JCDAECKEABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private CLIAACLCDCD IEKDPFMCJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<CBFJGOEFCOD>[] EBNEMNMBMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<IGDJNEFBHIA>[] GNIGHEJFOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private JHKLLFHDHJL PONJCCNIJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private JHKLLFHDHJL GECMPNAMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private JHKLLFHDHJL MCMIPBPCIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KCHFDODANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int LFHAMGLBIIN;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static OGDFBPJBKIJ LMMJKMMFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HMAJHKBELDG PGGPHANKJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OODONAABFIJ BKKCDMFHHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour CCJEOCJFGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material PLKILINNFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<DPLBJALAIHO> OHKOBGJHLBF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig JBDIBOJAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HAHFPGAFDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB96470", Offset = "0xB94A70", VA = "0x180B96470")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB96380", Offset = "0xB94980", VA = "0x180B96380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CLIAACLCDCD DNGDPHKJINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x533CD0", Offset = "0x5322D0", VA = "0x180533CD0")]
		get
		{
			return default(CLIAACLCDCD);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x40E6F80", Offset = "0x40E5580", VA = "0x1840E6F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OGDFBPJBKIJ KPCEMOHFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x40E8500", Offset = "0x40E6B00", VA = "0x1840E8500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KMFEOBPCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x40E7670", Offset = "0x40E5C70", VA = "0x1840E7670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool HMHKPOIPGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40E6850", Offset = "0x40E4E50", VA = "0x1840E6850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IOBEHCLKONG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x40E62A0", Offset = "0x40E48A0", VA = "0x1840E62A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x40E8290", Offset = "0x40E6890", VA = "0x1840E8290")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GMGEEPEAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40E71A0", Offset = "0x40E57A0", VA = "0x1840E71A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40E6200", Offset = "0x40E4800", VA = "0x1840E6200")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40E8620", Offset = "0x40E6C20", VA = "0x1840E8620")]
	public OGDFBPJBKIJ(HMAJHKBELDG PGGPHANKJGN, OODONAABFIJ BKKCDMFHHDN, ClusterLODConfig MEELMGDMEKB, MonoBehaviour CCJEOCJFGLC, Material PLKILINNFMJ, ClusterMeshRenderer MFIEFKEAPLH, MeshFilter KFPJPGDHMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40E70B0", Offset = "0x40E56B0", VA = "0x1840E70B0")]
	private void GAJKFHIOKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x40E6980", Offset = "0x40E4F80", VA = "0x1840E6980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40E68B0", Offset = "0x40E4EB0", VA = "0x1840E68B0")]
	public static void DKLJIMGJCNK(Vector3 OHJOMHPNGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40E6160", Offset = "0x40E4760", VA = "0x1840E6160")]
	private void ACAFOJIAIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40E7240", Offset = "0x40E5840", VA = "0x1840E7240")]
	private void GNPOGJODLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40E63C0", Offset = "0x40E49C0", VA = "0x1840E63C0")]
	private void BJPDCGPEMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40E6500", Offset = "0x40E4B00", VA = "0x1840E6500")]
	public void BKIFPJJBOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40E7E60", Offset = "0x40E6460", VA = "0x1840E7E60")]
	[IteratorStateMachine(typeof(ELCADLBOCPP))]
	private IEnumerator<KBDFKOBHGAA> KJKBBOONBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40E8580", Offset = "0x40E6B80", VA = "0x1840E8580")]
	[IteratorStateMachine(typeof(FNLBNHEHONI))]
	private IEnumerator<KBDFKOBHGAA> PDCKJPKADAK(Func<bool> OKBKPNJGBAE, float KMLCKFCMLLB, Func<string> BCBMDFFJAHG, float DIKEMKOAODD = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40E7340", Offset = "0x40E5940", VA = "0x1840E7340")]
	[IteratorStateMachine(typeof(MOFEBKBHNAO))]
	private IEnumerator<KBDFKOBHGAA> HAMNMHJBLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40E8040", Offset = "0x40E6640", VA = "0x1840E8040")]
	public void MIEEAKJAEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x40E67D0", Offset = "0x40E4DD0", VA = "0x1840E67D0")]
	public void CIBNJNLKCBI(IEnumerable<CBFJGOEFCOD> AGPCHDENECK, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x40E6AB0", Offset = "0x40E50B0", VA = "0x1840E6AB0")]
	public void EDMNAGBEMGL(IEnumerable<CBFJGOEFCOD> AGPCHDENECK, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40E76F0", Offset = "0x40E5CF0", VA = "0x1840E76F0")]
	public List<ClusterMeshRenderer> KIGNMNDLOOO(List<NOGMKPHNPLB> PLPIBFCIHCD, Transform LKGACHNFEHO, IJOEJNDINHL MLGADDGJDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40E7500", Offset = "0x40E5B00", VA = "0x1840E7500")]
	public IJOEJNDINHL JGHEBMIEPNM(Vector3 KIKHEHKLFBG)
	{
		return default(IJOEJNDINHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40E7140", Offset = "0x40E5740", VA = "0x1840E7140")]
	public void GBGDGPBKONB(DPLBJALAIHO FGJBCMHHHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x40E6DB0", Offset = "0x40E53B0", VA = "0x1840E6DB0")]
	public bool ELKJHHLLIAK(DPLBJALAIHO FGJBCMHHHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x40E73B0", Offset = "0x40E59B0", VA = "0x1840E73B0")]
	public void IDBFCJHDDCB(NOGMKPHNPLB HFEIBGLMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x40E7480", Offset = "0x40E5A80", VA = "0x1840E7480")]
	public void JGDHCOLIHHM(IGDJNEFBHIA MNBBGAPKLBD, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x40E6340", Offset = "0x40E4940", VA = "0x1840E6340")]
	public void BGHPECPKGDL(IGDJNEFBHIA MNBBGAPKLBD, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x40E7540", Offset = "0x40E5B40", VA = "0x1840E7540")]
	private void JLMEKIDKLDF(Vector3 JEMEDOGFIKH, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40E6E10", Offset = "0x40E5410", VA = "0x1840E6E10")]
	private void FEKKJGJJNIG(Vector3 JEMEDOGFIKH, IJOEJNDINHL MLGADDGJDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40E7410", Offset = "0x40E5A10", VA = "0x1840E7410")]
	[IteratorStateMachine(typeof(GDHKMMMLFIL))]
	private IEnumerator<KBDFKOBHGAA> JBOIMBFCMOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40E7ED0", Offset = "0x40E64D0", VA = "0x1840E7ED0")]
	private int KNELAONDBFI(int ACNPMFDBMJN, int IFDBBEAODCC, List<IGDJNEFBHIA> IOMOFOEKADE, byte HPMCIOMIFLO, ref int JPJHNPCAMBG, float MKNLPGLADKM = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40E8330", Offset = "0x40E6930", VA = "0x1840E8330")]
	public void OKJFIGBMPNL(NOGMKPHNPLB FCDBKPGBIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40E8250", Offset = "0x40E6850", VA = "0x1840E8250")]
	public bool NEPNPPAKBNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5542D0", Offset = "0x5528D0", VA = "0x1805542D0")]
	public Material BCIGAHGBABF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x40E6940", Offset = "0x40E4F40", VA = "0x1840E6940")]
	public int DNMPPHFAOGL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40E6D60", Offset = "0x40E5360", VA = "0x1840E6D60")]
	[CompilerGenerated]
	private bool EJLAJMMNEJN()
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
		[Cpp2IlInjected.Address(RVA = "0x9E59B0", Offset = "0x9E3FB0", VA = "0x1809E59B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HEKDMLEGAJN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> AINECFJJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> MNBCDDHNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> IGPBOMJODAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> BINKCMAOPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> MELMKFLGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> HPDFHGBGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> EPNGNEBOADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 IGKEBOADAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float MENCAFGHCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> EHIEHAMGNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> FGMBKPAKMMC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40E0F20", Offset = "0x40DF520", VA = "0x1840E0F20")]
	public HEKDMLEGAJN(JAJOOMHGIEJ APPECPLMDCP, NativeList<float3> EPNGNEBOADL, NativeMultiHashMap<int, int> EHIEHAMGNGE, NativeArray<int> FGMBKPAKMMC, Vector3 IGKEBOADAHJ, float MENCAFGHCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40E0EC0", Offset = "0x40DF4C0", VA = "0x1840E0EC0")]
	private int NMCOBFFEBML(float3 JEMEDOGFIKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40E0830", Offset = "0x40DEE30", VA = "0x1840E0830")]
	private int ENLLPJGOGPE(int BPOGJBAOFOB, int DHLOMKIAOHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40E0AD0", Offset = "0x40DF0D0", VA = "0x1840E0AD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DLDDDBGCEFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> EHIEHAMGNGE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> FGMBKPAKMMC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int JECGKDHDNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> PJJBNKAAKCI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x40DD800", Offset = "0x40DBE00", VA = "0x1840DD800")]
	public void ODEFNOLDOBJ(int PCFHBFBFCHH, Allocator LKKEMIPDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x40DD750", Offset = "0x40DBD50", VA = "0x1840DD750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public DLDDDBGCEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KDDJCOBBCMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> MPFJOHILJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> LFGPFHAGION;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x40E2D00", Offset = "0x40E1300", VA = "0x1840E2D00")]
	public KDDJCOBBCMG(DLDDDBGCEFC JLLMHDPIIEE, JAJOOMHGIEJ APPECPLMDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x40E2C70", Offset = "0x40E1270", VA = "0x1840E2C70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct DKNAJPEMMEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> IPODFODMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> IFJNLCHFFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> EHCCIBHPBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> HMEOBPKAGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> MPMAANINHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> PJJBNKAAKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> MPFJOHILJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> BGOHCMIBCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> AHFNNJAGNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> OOBDHKDFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> PNFEGLICFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> IKMLGCMJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> CFNAOBKKFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float LFBKAEALBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float KJCNAHGPFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 EENLFCPFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float BLOLJGKJEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float EPAEGCLACAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float OOPGLDFGHJN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x40DD610", Offset = "0x40DBC10", VA = "0x1840DD610")]
	public DKNAJPEMMEE(DLDDDBGCEFC BAPNPMNAHNB, JAJOOMHGIEJ APPECPLMDCP, JAJOOMHGIEJ LOHBBFJHKDN, float EPAEGCLACAF, float OOPGLDFGHJN, Vector3 EENLFCPFHPE, float BLOLJGKJEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x40DCFA0", Offset = "0x40DB5A0", VA = "0x1840DCFA0")]
	private float3 GMNJBDKDIJK(int BPOGJBAOFOB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x40DD430", Offset = "0x40DBA30", VA = "0x1840DD430")]
	private void ODJKDMNPJGF(int BPOGJBAOFOB, out float3 NNLKGPJHIAG, out float3 KKMLLCNPNIF, out float4 GDLFAOCLCDI, out float4 JHEJIIKFNJK, out float2 ACOHCKMIHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x40DD100", Offset = "0x40DB700", VA = "0x1840DD100")]
	private int IIEFIMCFLHP(int HEJEJOKKDAP, int IDFBGKMCEMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40DC1C0", Offset = "0x40DA7C0", VA = "0x1840DC1C0")]
	private void EAEHALAKDOK(int HEJEJOKKDAP, int IDFBGKMCEMO, int BOFOLCCOGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40DC030", Offset = "0x40DA630", VA = "0x1840DC030")]
	private bool ALDGNDHHEAN(int HEJEJOKKDAP, int IDFBGKMCEMO, float PDDNKFHKGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40DD040", Offset = "0x40DB640", VA = "0x1840DD040")]
	private bool HOIONKGOIPP(int HEJEJOKKDAP, int IDFBGKMCEMO, int BOFOLCCOGPF, float PDDNKFHKGBF, bool MNBDDAJAMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40DCD40", Offset = "0x40DB340", VA = "0x1840DCD40")]
	private bool GHKJPKEAOPH(int HEJEJOKKDAP, int IDFBGKMCEMO, int BOFOLCCOGPF, float PDDNKFHKGBF, bool MNBDDAJAMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x40DC3C0", Offset = "0x40DA9C0", VA = "0x1840DC3C0")]
	private void EONJIFHJGHP(int HEJEJOKKDAP, int IDFBGKMCEMO, int BOFOLCCOGPF, out int PEHDJPPNKBL, out int MMJACKDNMEB, out int DEHFFFKKIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x40DC3E0", Offset = "0x40DA9E0", VA = "0x1840DC3E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EIMIPMIHIJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KEKBMCKKMMD : IDisposable, IGDJNEFBHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds DDMIHMKBOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<NOGMKPHNPLB> PLPIBFCIHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 PGHNGAJLJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 LABHLANBGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int FBCHKOIKMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JAJOOMHGIEJ IIHEACLGPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DLDDDBGCEFC FAOBMMIHDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform LKGACHNFEHO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FMIKKJAGGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x40E2EA0", Offset = "0x40E14A0", VA = "0x1840E2EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh DFNJGPBCJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh KMELLFIIMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x521010", Offset = "0x51F610", VA = "0x180521010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x521020", Offset = "0x51F620", VA = "0x180521020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GANOHEMHPMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB0A40", Offset = "0xAAF040", VA = "0x180AB0A40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x19C4A40", Offset = "0x19C3040", VA = "0x1819C4A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte MIOKGNAMFAD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5F86A0", Offset = "0x5F6CA0", VA = "0x1805F86A0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5F8830", Offset = "0x5F6E30", VA = "0x1805F8830", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CPDKPKAIIND
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x655F40", Offset = "0x654540", VA = "0x180655F40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x655F50", Offset = "0x654550", VA = "0x180655F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int GIOAEJBPEDP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x84B4A0", Offset = "0x849AA0", VA = "0x18084B4A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9CDEA0", Offset = "0x9CC4A0", VA = "0x1809CDEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float BPOJKHMMNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x40E3340", Offset = "0x40E1940", VA = "0x1840E3340", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x40E3500", Offset = "0x40E1B00", VA = "0x1840E3500")]
		public void OGOELNMLJON(EJDOKGPECCP HPMCIOMIFLO, out int LCECCKHFMBE, out int JJLKICABBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x40E3360", Offset = "0x40E1960", VA = "0x1840E3360")]
		public void NFFDEFEBGDJ(EJDOKGPECCP HPMCIOMIFLO, PGMFCEPEFHN BNDCBPIMNIM, int CGAOLPOFHLB = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x40E2F80", Offset = "0x40E1580", VA = "0x1840E2F80")]
		public void FEHGLJABDAG(NativeList<OOMPAIAHFMI> ILJJHAPBDFB, Transform BPBOCDPDEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x40E2EE0", Offset = "0x40E14E0", VA = "0x1840E2EE0")]
		public void FABNGHOPGGD(Mesh APPECPLMDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x40E32A0", Offset = "0x40E18A0", VA = "0x1840E32A0")]
		public void KKLHIKAHLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40E2D30", Offset = "0x40E1330", VA = "0x1840E2D30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x40E3730", Offset = "0x40E1D30", VA = "0x1840E3730")]
		public KEKBMCKKMMD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds DDMIHMKBOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<KEKBMCKKMMD> AELBIGADMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public BPEEEIGEFFC AFPLEBCLJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer GJKDKMFPDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int KFNKIHFJPLB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh KKPKLPFPIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x595E30", Offset = "0x594430", VA = "0x180595E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F61E0", Offset = "0x5F47E0", VA = "0x1805F61E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CNNEICMCFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x661BD0", Offset = "0x6601D0", VA = "0x180661BD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x661C50", Offset = "0x660250", VA = "0x180661C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GLOINABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x40DDF90", Offset = "0x40DC590", VA = "0x1840DDF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x40DDFE0", Offset = "0x40DC5E0", VA = "0x1840DDFE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x40DEC70", Offset = "0x40DD270", VA = "0x1840DEC70")]
	public int OLGLLEMGGFM(int GMDBFJCKJIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x40DE880", Offset = "0x40DCE80", VA = "0x1840DE880")]
	public void LILAPPJDHPP(KJKADPBFCCH NHPKCHCCMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x40DECA0", Offset = "0x40DD2A0", VA = "0x1840DECA0")]
	public void PEAHBOFMJCE(Transform BPBOCDPDEMJ, bool OJJHIPLLLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x40DE6D0", Offset = "0x40DCCD0", VA = "0x1840DE6D0")]
	public bool JNPAFGDNOLA(bool IOPDFLNFGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x40DE140", Offset = "0x40DC740", VA = "0x1840DE140")]
	public void GJLFBLHPGFA(Transform LKGACHNFEHO, bool OJJHIPLLLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x40DEA10", Offset = "0x40DD010", VA = "0x1840DEA10")]
	public bool OKJFIGBMPNL(NOGMKPHNPLB FCDBKPGBIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x40DF3B0", Offset = "0x40DD9B0", VA = "0x1840DF3B0")]
	public EIMIPMIHIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JFBHCJHIDHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<EIMIPMIHIJN.KEKBMCKKMMD> BIIHIONGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NKILJLCGAAL KMKMJIKJGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<EIMIPMIHIJN.KEKBMCKKMMD> FCJCDDDIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int OJKALEJDMCE;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40E1200", Offset = "0x40DF800", VA = "0x1840E1200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x40E1500", Offset = "0x40DFB00", VA = "0x1840E1500")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40E1580", Offset = "0x40DFB80", VA = "0x1840E1580")]
	public void KNBMMGKPMNM(EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB, Transform LKGACHNFEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x40E1690", Offset = "0x40DFC90", VA = "0x1840E1690")]
	public void OKJFIGBMPNL(EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40E10D0", Offset = "0x40DF6D0", VA = "0x1840E10D0")]
	private EIMIPMIHIJN.KEKBMCKKMMD DAJFEPABKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40E0FE0", Offset = "0x40DF5E0", VA = "0x1840E0FE0")]
	private bool AKKMCDKHGGJ(EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x40E1630", Offset = "0x40DFC30", VA = "0x1840E1630")]
	private void LIFBIGELGNK(EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x40E14C0", Offset = "0x40DFAC0", VA = "0x1840E14C0")]
	public bool HHENCBOIPLC(EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x40E1270", Offset = "0x40DF870", VA = "0x1840E1270")]
	public bool ELGGEIDNLDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x40E1070", Offset = "0x40DF670", VA = "0x1840E1070")]
	private EIMIPMIHIJN.KEKBMCKKMMD BABABHMIIPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40E1840", Offset = "0x40DFE40", VA = "0x1840E1840")]
	public JFBHCJHIDHA()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9E59B0", Offset = "0x9E3FB0", VA = "0x1809E59B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JHLJKIKCIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int IONLBKJHOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int KNHOHBKPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float IBPPNCEKIHI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<EIMIPMIHIJN> PPCDEDGKJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x40E1ED0", Offset = "0x40E04D0", VA = "0x1840E1ED0")]
	public JHLJKIKCIGL(int IONLBKJHOOB, int KNHOHBKPMHH, float NEMEBCMHBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x40E1E30", Offset = "0x40E0430", VA = "0x1840E1E30")]
	public void PLEFMAIKNEH(OKAKPBMLKNC EIBMFAOGCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x40E1B60", Offset = "0x40E0160", VA = "0x1840E1B60")]
	private int LNHCIIDCIFB(KJKADPBFCCH LEBKLFJFIIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x40E1C00", Offset = "0x40E0200", VA = "0x1840E1C00")]
	private void PLEFMAIKNEH(KJKADPBFCCH LEBKLFJFIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x40E1980", Offset = "0x40DFF80", VA = "0x1840E1980")]
	private void IFGOAGBCHKM(KJKADPBFCCH LEBKLFJFIIP, EIMIPMIHIJN NOEDHEACOEG)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, CBFJGOEFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FOKIFHHGKFM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEE0", Offset = "0x5DA4E0", VA = "0x1805DBEE0")]
			[DebuggerHidden]
			public FOKIFHHGKFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x40DF710", Offset = "0x40DDD10", VA = "0x1840DF710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x40DF8A0", Offset = "0x40DDEA0", VA = "0x1840DF8A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x40DF800", Offset = "0x40DDE00", VA = "0x1840DF800", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x40DF800", Offset = "0x40DDE00", VA = "0x1840DF800", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int GLOINABNEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x40DBFD0", Offset = "0x40DA5D0", VA = "0x1840DBFD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<IGDJNEFBHIA> HEMIIGIBMMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x40DBFB0", Offset = "0x40DA5B0", VA = "0x1840DBFB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> AELBIGADMCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public EIMIPMIHIJN KKPKLPFPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public IJOEJNDINHL GAOEFBFMOGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x521390", Offset = "0x51F990", VA = "0x180521390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(IJOEJNDINHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6CAB60", Offset = "0x6C9160", VA = "0x1806CAB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool AJFAAMIDGAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x40DBFC0", Offset = "0x40DA5C0", VA = "0x1840DBFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x40DACF0", Offset = "0x40D92F0", VA = "0x1840DACF0")]
		public static ClusterMeshRenderer Create(EIMIPMIHIJN APPECPLMDCP, ClusterMeshRenderer MFIEFKEAPLH, MeshFilter KFPJPGDHMDN, Transform LKGACHNFEHO, IJOEJNDINHL MLGADDGJDFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x40DAE00", Offset = "0x40D9400", VA = "0x1840DAE00", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x40DB560", Offset = "0x40D9B60", VA = "0x1840DB560", Slot = "10")]
		public bool TryRemoveClusterLODComponent(NOGMKPHNPLB FCDBKPGBIPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x40DB330", Offset = "0x40D9930", VA = "0x1840DB330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x40DB060", Offset = "0x40D9660", VA = "0x1840DB060")]
		public void Init(EIMIPMIHIJN APPECPLMDCP, MeshFilter KFPJPGDHMDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x40DAE60", Offset = "0x40D9460", VA = "0x1840DAE60")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x40DB690", Offset = "0x40D9C90", VA = "0x1840DB690", Slot = "8")]
		public void UpdateClusterDistances(Vector3 JEMEDOGFIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x40DB8D0", Offset = "0x40D9ED0", VA = "0x1840DB8D0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x40DAFF0", Offset = "0x40D95F0", VA = "0x1840DAFF0")]
		[IteratorStateMachine(typeof(FOKIFHHGKFM))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x40DB3B0", Offset = "0x40D99B0", VA = "0x1840DB3B0")]
		public void SetupTagAndLayer(string OPJBAFIEHOG, int MLGADDGJDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x40DB390", Offset = "0x40D9990", VA = "0x1840DB390")]
		public bool Remove(NOGMKPHNPLB FCDBKPGBIPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9E59B0", Offset = "0x9E3FB0", VA = "0x1809E59B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CJONCJELLNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int KHOMNJCGGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AMGFIMAOBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int JJLKICABBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LCECCKHFMBE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40DAB40", Offset = "0x40D9140", VA = "0x1840DAB40")]
	public CJONCJELLNK(int AMGFIMAOBNL, int JJLKICABBGF, int KHOMNJCGGIC, int LCECCKHFMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BPEEEIGEFFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> AINECFJJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> PJJBNKAAKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> HPDFHGBGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<CJONCJELLNK> CJFBOBONMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> JDPPPHMJLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> HIPGHMNFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> KGFKINDJEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle HFEDFKFBGCH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AOEKMLPBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D36F0", Offset = "0x6D1CF0", VA = "0x1806D36F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D10", Offset = "0x6D2310", VA = "0x1806D3D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x40D7CB0", Offset = "0x40D62B0", VA = "0x1840D7CB0")]
	public void DENALEMOHII(JAJOOMHGIEJ PBBKGLKKOMC, NativeList<CJONCJELLNK> CJFBOBONMOJ, float GCOPOKEGOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x40D8CC0", Offset = "0x40D72C0", VA = "0x1840D8CC0")]
	public void LLDMAINLKKO(Transform LKGACHNFEHO, bool OJJHIPLLLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x40D8B30", Offset = "0x40D7130", VA = "0x1840D8B30")]
	public void JNPAFGDNOLA(EIMIPMIHIJN GJKDKMFPDCI, bool IOPDFLNFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x40D8A30", Offset = "0x40D7030", VA = "0x1840D8A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x40D8B00", Offset = "0x40D7100", VA = "0x1840D8B00")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public BPEEEIGEFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct NKMMAMMBGDM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> AINECFJJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> PJJBNKAAKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<CJONCJELLNK> OBLKNJNKAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> JDPPPHMJLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 EENLFCPFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> HIPGHMNFPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> KGFKINDJEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool OJJHIPLLLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float MLMGMKJAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float PGNFODPKBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float GFBODMNDFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> HPDFHGBGIGK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x40E5D00", Offset = "0x40E4300", VA = "0x1840E5D00")]
	public NKMMAMMBGDM(BPEEEIGEFFC PKLMJNDLJHE, Vector3 EENLFCPFHPE, bool OJJHIPLLLMI, float MLMGMKJAAHF, float PGNFODPKBOO, float GFBODMNDFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x40E5860", Offset = "0x40E3E60", VA = "0x1840E5860", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NOGMKPHNPLB : EOJDPKDJPOM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds NDGLKBLPIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OOMPAIAHFMI PNBHKOLMFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KJKADPBFCCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<NOGMKPHNPLB> PLPIBFCIHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public KJKADPBFCCH ODFEOHMNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public KJKADPBFCCH HLHAFNEKOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public KJKADPBFCCH CAHJHDIMMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int LCECCKHFMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds DDMIHMKBOGG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x40E37F0", Offset = "0x40E1DF0", VA = "0x1840E37F0")]
	public KJKADPBFCCH(List<NOGMKPHNPLB> PLPIBFCIHCD, [Optional] KJKADPBFCCH ODFEOHMNKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OKAKPBMLKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<KJKADPBFCCH> JJEMJCHPIPD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KJKADPBFCCH JLJGCJNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x40E8BA0", Offset = "0x40E71A0", VA = "0x1840E8BA0")]
	public OKAKPBMLKNC(KJKADPBFCCH LKGACHNFEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CIABLHADLAK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PHCGMNNJEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int JINNIJCMIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int EGPDJLNJGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int DMOCLEJHFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int FNODNEBLLAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BCEPKOJDANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int GJNGLFFJNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float CIPMAFCELHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<NOGMKPHNPLB> PLPIBFCIHCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum MBKDNDNLDGK
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
	private PHCGMNNJEAN GNJEIOLMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int IMKIMJPLCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int IONLBKJHOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KNHOHBKPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float NEMEBCMHBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float GBGDNJJAOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<KJKADPBFCCH> HLBINPEAMPE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OKAKPBMLKNC FNAPINMEHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x40DAAE0", Offset = "0x40D90E0", VA = "0x1840DAAE0")]
	public CIABLHADLAK(int IONLBKJHOOB, int KNHOHBKPMHH, float NEMEBCMHBFO, int IMKIMJPLCIK, float GBGDNJJAOBG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40D92A0", Offset = "0x40D78A0", VA = "0x1840D92A0")]
	public void CIGJLMILCBP(List<NOGMKPHNPLB> PLPIBFCIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x40D9460", Offset = "0x40D7A60", VA = "0x1840D9460")]
	public bool DPHAKJHMBJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x40DA0C0", Offset = "0x40D86C0", VA = "0x1840DA0C0")]
	private float MFDMBCKMMCL(Vector3 LIGMIPBMNAG, Vector3 JGHLGFPKNEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x40DA020", Offset = "0x40D8620", VA = "0x1840DA020")]
	private float MFDMBCKMMCL(Vector3 IFBIFKFKIDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x40DA1D0", Offset = "0x40D87D0", VA = "0x1840DA1D0")]
	private bool OCCKLHKMAKK(KJKADPBFCCH PMHJCMKNLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x40D94D0", Offset = "0x40D7AD0", VA = "0x1840D94D0")]
	private BCEPKOJDANI KECEAFKCJCA(List<NOGMKPHNPLB> MACAFCEEHJD, MBKDNDNLDGK INJEHFILFHE)
	{
		return default(BCEPKOJDANI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x40D8F10", Offset = "0x40D7510", VA = "0x1840D8F10")]
	private void ACADDKHIDEC(List<NOGMKPHNPLB> PLPIBFCIHCD, Vector3[] KMOMDDBFJHF, Vector3[] EJLFFHNCFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class MCDBOJBCFND
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x40E38D0", Offset = "0x40E1ED0", VA = "0x1840E38D0")]
	public static Bounds AHPFLNOPCHJ(List<NOGMKPHNPLB> PLPIBFCIHCD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40E3A80", Offset = "0x40E2080", VA = "0x1840E3A80")]
	public static int PGJLJNJMLKB(List<NOGMKPHNPLB> PLPIBFCIHCD, EJDOKGPECCP HPMCIOMIFLO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NKILJLCGAAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private JAJOOMHGIEJ CABBBELJDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private JAJOOMHGIEJ GLOIOAPMLAG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static JAJOOMHGIEJ JAPFLOLCGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private HFEJKKMELDA OPNLGDOBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PGMFCEPEFHN BNDCBPIMNIM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle HFEDFKFBGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7092F0", Offset = "0x7078F0", VA = "0x1807092F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x709310", Offset = "0x707910", VA = "0x180709310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EIMIPMIHIJN.KEKBMCKKMMD PMHJCMKNLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AMBJFCHIIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x63EF00", Offset = "0x63D500", VA = "0x18063EF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x40E5760", Offset = "0x40E3D60", VA = "0x1840E5760")]
	[BFFCGBPBDIO(MHIIHFJKCKA.ExitingPlayMode, 0)]
	private void OHKFNGHDICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x40E4D30", Offset = "0x40E3330", VA = "0x1840E4D30")]
	public void DENALEMOHII(EIMIPMIHIJN.KEKBMCKKMMD OBLKNJNKAIP, Transform JLOLIHJAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x40E4770", Offset = "0x40E2D70", VA = "0x1840E4770")]
	public void BMGCKCDBLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x40E56B0", Offset = "0x40E3CB0", VA = "0x1840E56B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x40E5720", Offset = "0x40E3D20", VA = "0x1840E5720")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x40E57D0", Offset = "0x40E3DD0", VA = "0x1840E57D0")]
	public NKILJLCGAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OOJPHFBKNKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OGDFBPJBKIJ BHAIOIKKCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OODONAABFIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 NIFOFMIGLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HMAJHKBELDG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KILDHINLNND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PIPNHLEFHIF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action JAPHJKKEAGH;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IIIGMJBIDON
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IIIGMJBIDON KECAPJDOHLJ(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIIGMJBIDON GMNLDHNGCEE(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IIIGMJBIDON GOILCIDMONI(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIIGMJBIDON NPFLJEBIHFM(Action JLOPFCBGFOB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class OFIOJGCPOAB : IIIGMJBIDON
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class JIPBJEOJKHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public OFIOJGCPOAB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
				public JIPBJEOJKHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x40E1F20", Offset = "0x40E0520", VA = "0x1840E1F20")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x40E1F70", Offset = "0x40E0570", VA = "0x1840E1F70")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x40E1FC0", Offset = "0x40E05C0", VA = "0x1840E1FC0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> NNDKMMPMFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action PAPCHNJGPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action AJPEOEFGOFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NOIGMFJMJBE PJPKHBELFPF;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action FOJFLBMJBNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x595E30", Offset = "0x594430", VA = "0x180595E30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5F61E0", Offset = "0x5F47E0", VA = "0x1805F61E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action MCELEEDEHBB
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2754040", Offset = "0x2752640", VA = "0x182754040", Slot = "4")]
			public IIIGMJBIDON KECAPJDOHLJ(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x27E7D20", Offset = "0x27E6320", VA = "0x1827E7D20", Slot = "5")]
			public IIIGMJBIDON GMNLDHNGCEE(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x290FD00", Offset = "0x290E300", VA = "0x18290FD00", Slot = "6")]
			public IIIGMJBIDON GOILCIDMONI(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA5D070", Offset = "0xA5B670", VA = "0x180A5D070", Slot = "7")]
			public IIIGMJBIDON NPFLJEBIHFM(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5DD330", Offset = "0x5DB930", VA = "0x1805DD330")]
			public OFIOJGCPOAB(Func<JobHandle> BADHEGJGJEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x40E5DD0", Offset = "0x40E43D0", VA = "0x1840E5DD0")]
			public void KJALCGNLDOB(Action AIPECNEOHOL, Action NODHCLBJFNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x40E6000", Offset = "0x40E4600", VA = "0x1840E6000")]
			public void OKJFIGBMPNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FNFBNJJEFMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public IIIGMJBIDON jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public FNFBNJJEFMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x40DF560", Offset = "0x40DDB60", VA = "0x1840DF560")]
			internal bool <Remove>b__0(OFIOJGCPOAB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JLJLLFIJEMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public OFIOJGCPOAB newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public JLJLLFIJEMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x40E2000", Offset = "0x40E0600", VA = "0x1840E2000")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<OFIOJGCPOAB> KEHNCEANBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<OFIOJGCPOAB> PFIJONNEEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private JHKLLFHDHJL CCCBJHFHMGJ;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x40E2060", Offset = "0x40E0660", VA = "0x1840E2060")]
		public IIIGMJBIDON Add(Func<JobHandle> BADHEGJGJEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x40E2300", Offset = "0x40E0900", VA = "0x1840E2300")]
		public void Remove(IIIGMJBIDON HFEDFKFBGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x40E2180", Offset = "0x40E0780", VA = "0x1840E2180", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x40E2480", Offset = "0x40E0A80", VA = "0x1840E2480")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x40E2650", Offset = "0x40E0C50", VA = "0x1840E2650")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x40E2170", Offset = "0x40E0770", VA = "0x1840E2170")]
		[CompilerGenerated]
		private void LDAHLAKLPAJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NOIGMFJMJBE
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOIGMFJMJBE KECAPJDOHLJ(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NOIGMFJMJBE BCOONCKJIGN(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOIGMFJMJBE NPFLJEBIHFM(Action JLOPFCBGFOB);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class NENLMEIBFJH : NOIGMFJMJBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle ILFHDMCLLIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action PAPCHNJGPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action ECPNFEIPIAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action MCELEEDEHBB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool IAIOGGPIMFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x40E4720", Offset = "0x40E2D20", VA = "0x1840E4720")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x27E7D20", Offset = "0x27E6320", VA = "0x1827E7D20", Slot = "4")]
			public NOIGMFJMJBE KECAPJDOHLJ(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x290FD00", Offset = "0x290E300", VA = "0x18290FD00", Slot = "5")]
			public NOIGMFJMJBE BCOONCKJIGN(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA5D070", Offset = "0xA5B670", VA = "0x180A5D070", Slot = "6")]
			public NOIGMFJMJBE NPFLJEBIHFM(Action JLOPFCBGFOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1FABAD0", Offset = "0x1FAA0D0", VA = "0x181FABAD0")]
			public NENLMEIBFJH(JobHandle EBNIMJJEOLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x40E46E0", Offset = "0x40E2CE0", VA = "0x1840E46E0")]
			public void BJNNNCFMPEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x40E4730", Offset = "0x40E2D30", VA = "0x1840E4730")]
			public void OKJFIGBMPNL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<NENLMEIBFJH> EPLCLIKHEAM;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x40E2AD0", Offset = "0x40E10D0", VA = "0x1840E2AD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x40E2710", Offset = "0x40E0D10", VA = "0x1840E2710")]
		public NOIGMFJMJBE Add(JobHandle EBNIMJJEOLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x40E29E0", Offset = "0x40E0FE0", VA = "0x1840E29E0")]
		public void Remove(NOIGMFJMJBE HFEDFKFBGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x40E2880", Offset = "0x40E0E80", VA = "0x1840E2880", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x40E27A0", Offset = "0x40E0DA0", VA = "0x1840E27A0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x40E2BE0", Offset = "0x40E11E0", VA = "0x1840E2BE0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x40DDCD0", Offset = "0x40DC2D0", VA = "0x1840DDCD0")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x40DD9A0", Offset = "0x40DBFA0", VA = "0x1840DD9A0")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
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
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
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
