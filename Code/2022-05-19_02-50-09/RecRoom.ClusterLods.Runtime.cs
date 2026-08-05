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
				[Cpp2IlInjected.Address(RVA = "0x15AA6B0", Offset = "0x15A92B0", VA = "0x1815AA6B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xCBE660", Offset = "0xCBD260", VA = "0x180CBE660")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x15AA670", Offset = "0x15A9270", VA = "0x1815AA670")]
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
		[Cpp2IlInjected.Address(RVA = "0x159F3A0", Offset = "0x159DFA0", VA = "0x18159F3A0")]
		public LODSettings KGNOKMCDHMM(NEILPEOKPHE NCLMJKKJONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x159F280", Offset = "0x159DE80", VA = "0x18159F280")]
		public int AILHLBOHFBJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x159F2A0", Offset = "0x159DEA0", VA = "0x18159F2A0")]
		public int BNGLDMIMCCI(bool MLJEHAGIAKG, Vector3 MIDCAOLOIKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x159F3B0", Offset = "0x159DFB0", VA = "0x18159F3B0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ACNLPBMJADK
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
public interface NPPHKNCDDGG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGKEJIMHOCG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ICCANLCLEBI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ABCCNPONMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<PKGONOFHIPO> JCHDNPCPGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ACNLPBMJADK HJLNKPCDMNP
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
	void UpdateClusterDistances(Vector3 DPBKPCMIPBG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(HEAFGEIIGPC FCANJIFOAJB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PKGONOFHIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int EDDOMPIMHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int NGGBNAODNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FMJDFMKNNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float PAKHHHHHNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte EDAHGFAHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JKMMGCANMEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KBKEBKOLEIC
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
	private sealed class PDEOFLDINHF : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JKMMGCANMEE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public PDEOFLDINHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x15AC1F0", Offset = "0x15AADF0", VA = "0x1815AC1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x15AC2B0", Offset = "0x15AAEB0", VA = "0x1815AC2B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GMFCHPHGANO : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IGHAECBNBLN <>2__current;

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
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public GMFCHPHGANO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x15A2C40", Offset = "0x15A1840", VA = "0x1815A2C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x15A2D90", Offset = "0x15A1990", VA = "0x1815A2D90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LMBJHMNCJAG : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JKMMGCANMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<IGHAECBNBLN> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public LMBJHMNCJAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x15A9BA0", Offset = "0x15A87A0", VA = "0x1815A9BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x15AA620", Offset = "0x15A9220", VA = "0x1815AA620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KAJHLKFBCEL : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IGHAECBNBLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public JKMMGCANMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
		[DebuggerHidden]
		public KAJHLKFBCEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x15A76A0", Offset = "0x15A62A0", VA = "0x1815A76A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x15A8590", Offset = "0x15A7190", VA = "0x1815A8590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int HLAIDLFNOBA = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer ALPENHEANEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter DHKNNMBLHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject IJNICFPJIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject AAFLBFDLJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public EDCHKANBKHL IGKNGJPBDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<HEAFGEIIGPC> JJODDFIDOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<HEAFGEIIGPC> POBLIBNKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<HEAFGEIIGPC> FABKECFKBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int LOAJPKONFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KBKEBKOLEIC IPNIPBKOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<ICCANLCLEBI>[] EAPHOPFCKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<PKGONOFHIPO>[] NJELABMKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private OLAOJJPOAKP MIANNKKDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private OLAOJJPOAKP CJIHKJKLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private OLAOJJPOAKP CIILDJOLOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int MKBIEPPKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int BJAOFBMHELH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static JKMMGCANMEE DNPKCAGFDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OENPCHDFIFK AKJKOABKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NNIGGEPIAJD DAMOACLJBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour AJDOKAMHILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material BMCJBIOILME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NPPHKNCDDGG> DHHALAFLGEG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig PFMJAFGKINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 KHOFLKLJEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15A6220", Offset = "0x15A4E20", VA = "0x1815A6220")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15A63F0", Offset = "0x15A4FF0", VA = "0x1815A63F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private KBKEBKOLEIC KLLOEBIPLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58A950", Offset = "0x589550", VA = "0x18058A950")]
		get
		{
			return default(KBKEBKOLEIC);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15A5BF0", Offset = "0x15A47F0", VA = "0x1815A5BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JKMMGCANMEE APCGFOPGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15A4AC0", Offset = "0x15A36C0", VA = "0x1815A4AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PMMADFBGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x15A4A40", Offset = "0x15A3640", VA = "0x1815A4A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EOOCPHIGKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15A5340", Offset = "0x15A3F40", VA = "0x1815A5340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> HKAOGFLBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15A58F0", Offset = "0x15A44F0", VA = "0x1815A58F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x15A4E10", Offset = "0x15A3A10", VA = "0x1815A4E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NFNCNCFPPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15A49A0", Offset = "0x15A35A0", VA = "0x1815A49A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15A5050", Offset = "0x15A3C50", VA = "0x1815A5050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x15A6510", Offset = "0x15A5110", VA = "0x1815A6510")]
	public JKMMGCANMEE(OENPCHDFIFK AKJKOABKKKG, NNIGGEPIAJD DAMOACLJBPO, ClusterLODConfig HLBLELNKAEA, MonoBehaviour AJDOKAMHILN, Material BMCJBIOILME, ClusterMeshRenderer ALPENHEANEC, MeshFilter DHKNNMBLHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x15A53A0", Offset = "0x15A3FA0", VA = "0x1815A53A0")]
	private void FNICJGIBMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x15A4F20", Offset = "0x15A3B20", VA = "0x1815A4F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x15A6480", Offset = "0x15A5080", VA = "0x1815A6480")]
	public static void PICLBGAFEEG(Vector3 CFIICOFKKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15A6180", Offset = "0x15A4D80", VA = "0x1815A6180")]
	private void NCHMJLLCCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x15A5D20", Offset = "0x15A4920", VA = "0x1815A5D20")]
	private void KIOAHPCNHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x15A6240", Offset = "0x15A4E40", VA = "0x1815A6240")]
	private void NGPNNOCGMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x15A4B40", Offset = "0x15A3740", VA = "0x1815A4B40")]
	public void BOOFLFNLEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15A6110", Offset = "0x15A4D10", VA = "0x1815A6110")]
	[IteratorStateMachine(typeof(PDEOFLDINHF))]
	private IEnumerator<IGHAECBNBLN> NABCMNGCJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x15A50F0", Offset = "0x15A3CF0", VA = "0x1815A50F0")]
	[IteratorStateMachine(typeof(GMFCHPHGANO))]
	private IEnumerator<IGHAECBNBLN> EPKECPJANEN(Func<bool> CAFGJLIIDEM, float HIHLHOIOIEF, Func<string> EJBKCDBJOJA, float JJBJCCDLJGG = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x15A4EB0", Offset = "0x15A3AB0", VA = "0x1815A4EB0")]
	[IteratorStateMachine(typeof(LMBJHMNCJAG))]
	private IEnumerator<IGHAECBNBLN> CIANFGMODEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x15A5990", Offset = "0x15A4590", VA = "0x1815A5990")]
	public void JGKAPMJKJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x15A5190", Offset = "0x15A3D90", VA = "0x1815A5190")]
	public void FDFJONKEFJM(IEnumerable<ICCANLCLEBI> FDJHKLMIIKI, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x15A5490", Offset = "0x15A4090", VA = "0x1815A5490")]
	public void HAKNHBOFIGJ(IEnumerable<ICCANLCLEBI> FDJHKLMIIKI, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x15A41F0", Offset = "0x15A2DF0", VA = "0x1815A41F0")]
	public List<ClusterMeshRenderer> AGALEPNODCM(List<HEAFGEIIGPC> ENGAGIAHIFE, Transform LGLMPHDPDPB, ACNLPBMJADK HILKLOMPPOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15A58B0", Offset = "0x15A44B0", VA = "0x1815A58B0")]
	public ACNLPBMJADK HMCBJJLDBOE(Vector3 KDFNIDEKDFN)
	{
		return default(ACNLPBMJADK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15A5EE0", Offset = "0x15A4AE0", VA = "0x1815A5EE0")]
	public void LNHJDKBNGKJ(NPPHKNCDDGG DBLNPBIJGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x15A5430", Offset = "0x15A4030", VA = "0x1815A5430")]
	public bool HAACNGIIGHL(NPPHKNCDDGG DBLNPBIJGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x15A5F40", Offset = "0x15A4B40", VA = "0x1815A5F40")]
	public void MDCDFKHLMJB(HEAFGEIIGPC CCPCLHEMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x15A5E20", Offset = "0x15A4A20", VA = "0x1815A5E20")]
	public void KONKJEOPAAM(PKGONOFHIPO MPBBADKKMHG, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x15A6400", Offset = "0x15A5000", VA = "0x1815A6400")]
	public void OLHDFOHDEGE(PKGONOFHIPO MPBBADKKMHG, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15A5210", Offset = "0x15A3E10", VA = "0x1815A5210")]
	private void FDNIGDHIADP(Vector3 DPBKPCMIPBG, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15A5FA0", Offset = "0x15A4BA0", VA = "0x1815A5FA0")]
	private void MNJKAONKCNI(Vector3 DPBKPCMIPBG, ACNLPBMJADK HILKLOMPPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x15A6380", Offset = "0x15A4F80", VA = "0x1815A6380")]
	[IteratorStateMachine(typeof(KAJHLKFBCEL))]
	private IEnumerator<IGHAECBNBLN> OHJKPMHHAII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x15A5740", Offset = "0x15A4340", VA = "0x1815A5740")]
	private int HBKMABBMFLN(int KMCFICBBFCD, int LBGGKFGLEDI, List<PKGONOFHIPO> HEOAOFEEGJH, byte NCLMJKKJONF, ref int LOHEKINOKOM, float LMKHBIIAOPI = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x15A4020", Offset = "0x15A2C20", VA = "0x1815A4020")]
	public void AFEKNPNIBII(HEAFGEIIGPC FCANJIFOAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x15A5EA0", Offset = "0x15A4AA0", VA = "0x1815A5EA0")]
	public bool LDIEOGFEFAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5527F0", Offset = "0x5513F0", VA = "0x1805527F0")]
	public Material DLDHJCOEIPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x15A4960", Offset = "0x15A3560", VA = "0x1815A4960")]
	public int AILHLBOHFBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x15A5BA0", Offset = "0x15A47A0", VA = "0x1815A5BA0")]
	[CompilerGenerated]
	private bool JMDALDGIIPF()
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
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HIECIGNNMFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> IIAMKEPDNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> OHKOHPDDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> KKJMMAGOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> BMGAJCDIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> MODAABPOICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> GLOIMKGLFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> BLDFGLBIOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 KHGIKICBCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float ILKHJPOMDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> IHHHDBPFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> JOKEMKMIJMF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x15A3590", Offset = "0x15A2190", VA = "0x1815A3590")]
	public HIECIGNNMFP(MKONELHAHOE NBBCOGHADLE, NativeList<float3> BLDFGLBIOFA, NativeMultiHashMap<int, int> IHHHDBPFHCN, NativeArray<int> JOKEMKMIJMF, Vector3 KHGIKICBCII, float ILKHJPOMDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x15A3530", Offset = "0x15A2130", VA = "0x1815A3530")]
	private int IEIMNMLAMAM(float3 DPBKPCMIPBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x15A2EA0", Offset = "0x15A1AA0", VA = "0x1815A2EA0")]
	private int DIILPBGPCOO(int EPHKOIPAMCK, int GMCMHIFODNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x15A3140", Offset = "0x15A1D40", VA = "0x1815A3140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FLCKODDCPBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> IHHHDBPFHCN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> JOKEMKMIJMF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int HIEKJLEAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> JKNKONLKEGM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x15A2AA0", Offset = "0x15A16A0", VA = "0x1815A2AA0")]
	public void MMAAFBCKLCJ(int PPBFNCJGLCI, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15A29F0", Offset = "0x15A15F0", VA = "0x1815A29F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public FLCKODDCPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct HDHOALIKEHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> IJILNEDBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> IHOLIJLFFNP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x15A2E70", Offset = "0x15A1A70", VA = "0x1815A2E70")]
	public HDHOALIKEHE(FLCKODDCPBF HOCBONJMHHA, MKONELHAHOE NBBCOGHADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x15A2DE0", Offset = "0x15A19E0", VA = "0x1815A2DE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct LONIKNNIIFC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> DNGDBDMJCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> HIHFCDHMFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> GIFIJPCHKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> EHNJDLHFDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> FLBJCDLNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> JKNKONLKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> IJILNEDBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> OGMGLINHAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> FMPFPFEEMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> FDPFHLEJLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> EBGHKGCDFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> PDFJGNPBKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> EHDCEKLCBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float GJFCGCEEHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float MDGJKDCKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 AGBNAMPHNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float OEILNPKCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float GCLHPPNAHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float AAGCHNKPMPA;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x15ABCB0", Offset = "0x15AA8B0", VA = "0x1815ABCB0")]
	public LONIKNNIIFC(FLCKODDCPBF PIDGKAONBCP, MKONELHAHOE NBBCOGHADLE, MKONELHAHOE EPJLMIKHDBB, float GCLHPPNAHBH, float AAGCHNKPMPA, Vector3 AGBNAMPHNLN, float OEILNPKCIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x15AA6D0", Offset = "0x15A92D0", VA = "0x1815AA6D0")]
	private float3 BBALCKFONMG(int EPHKOIPAMCK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x15ABAB0", Offset = "0x15AA6B0", VA = "0x1815ABAB0")]
	private void OACABGKDOLC(int EPHKOIPAMCK, out float3 GOPAOCKGEJH, out float3 OKDPANGABAB, out float4 IABDOJOIEHL, out float4 OJIBIKOMHKJ, out float2 FBIBLDOILEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x15AA9D0", Offset = "0x15A95D0", VA = "0x1815AA9D0")]
	private int DABGCDIGFKO(int CPBCKMCLBDP, int BMBHCICOMNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x15AB8B0", Offset = "0x15AA4B0", VA = "0x1815AB8B0")]
	private void MHBMGGCGBHI(int CPBCKMCLBDP, int BMBHCICOMNK, int PPMEGHEHLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x15AB720", Offset = "0x15AA320", VA = "0x1815AB720")]
	private bool LDLDGPBCEDF(int CPBCKMCLBDP, int BMBHCICOMNK, float CPEOKOCJABF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x15AB660", Offset = "0x15AA260", VA = "0x1815AB660")]
	private bool IGDMCOFPJJM(int CPBCKMCLBDP, int BMBHCICOMNK, int PPMEGHEHLFH, float CPEOKOCJABF, bool AIHKHECDDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x15AA770", Offset = "0x15A9370", VA = "0x1815AA770")]
	private bool CKOHNKFILJL(int CPBCKMCLBDP, int BMBHCICOMNK, int PPMEGHEHLFH, float CPEOKOCJABF, bool AIHKHECDDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x15ABC90", Offset = "0x15AA890", VA = "0x1815ABC90")]
	private void PDNMEFLBPKF(int CPBCKMCLBDP, int BMBHCICOMNK, int PPMEGHEHLFH, out int CKEMHBEOHDO, out int HBKFNJNJDME, out int GFPOEOEPCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x15AAD00", Offset = "0x15A9900", VA = "0x1815AAD00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LDGIMFLEKPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BBFEBEKANPA : IDisposable, PKGONOFHIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds NFBIDFHJAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<HEAFGEIIGPC> ENGAGIAHIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 ONFLBAKFGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 CMOJMBIBDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int CDOECLHPMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MKONELHAHOE ONICKFIMEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FLCKODDCPBF NLPNLAJGDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform LGLMPHDPDPB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int LOLBJIAENDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x159C970", Offset = "0x159B570", VA = "0x18159C970")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh EGNAIHLIEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh OHBBJGBMEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x5520A0", VA = "0x1805534A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5768D0", VA = "0x180577CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FMJDFMKNNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x556190", Offset = "0x554D90", VA = "0x180556190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x556530", Offset = "0x555130", VA = "0x180556530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte EDAHGFAHJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5F9780", Offset = "0x5F8380", VA = "0x1805F9780")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x808580", Offset = "0x807180", VA = "0x180808580", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int EDDOMPIMHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8170B0", Offset = "0x815CB0", VA = "0x1808170B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x894420", Offset = "0x893020", VA = "0x180894420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int NGGBNAODNME
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA2CA30", Offset = "0xA2B630", VA = "0x180A2CA30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x693110", Offset = "0x691D10", VA = "0x180693110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float PAKHHHHHNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x159C7E0", Offset = "0x159B3E0", VA = "0x18159C7E0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x159CA50", Offset = "0x159B650", VA = "0x18159CA50")]
		public void JDDLGAIGNMH(NEILPEOKPHE NCLMJKKJONF, out int DDEMDHHCHHL, out int NLGAGPNAJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x159C5A0", Offset = "0x159B1A0", VA = "0x18159C5A0")]
		public void BKFOOEOKGML(NEILPEOKPHE NCLMJKKJONF, AODGPNCLJGB FEKGOBDFACC, int IGGMNLHEJGA = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x159CC80", Offset = "0x159B880", VA = "0x18159CC80")]
		public void OKEKHPLCPDK(NativeList<BICMMAMDAKJ> OFFDIDGGOME, Transform GMDFFJHDCAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x159C9B0", Offset = "0x159B5B0", VA = "0x18159C9B0")]
		public void GGPBGDKFKDA(Mesh NBBCOGHADLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x159C740", Offset = "0x159B340", VA = "0x18159C740")]
		public void BLBDLEMPNGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x159C800", Offset = "0x159B400", VA = "0x18159C800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x159CFA0", Offset = "0x159BBA0", VA = "0x18159CFA0")]
		public BBFEBEKANPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds NFBIDFHJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<BBFEBEKANPA> DPPIMBPOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public DEJOOFNJNCH CFKOMGFGKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer DEEJIANJDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int BIOBFPLIAOC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh HDFCNDCNIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64DDB0", Offset = "0x64C9B0", VA = "0x18064DDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GNEFLKEIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x695C60", Offset = "0x694860", VA = "0x180695C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x695C80", Offset = "0x694880", VA = "0x180695C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ABCCNPONMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x15A85E0", Offset = "0x15A71E0", VA = "0x1815A85E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x15A9530", Offset = "0x15A8130", VA = "0x1815A9530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x15A99D0", Offset = "0x15A85D0", VA = "0x1815A99D0")]
	public int PAEEEOGJMBL(int AKAMOMKGFAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x15A9690", Offset = "0x15A8290", VA = "0x1815A9690")]
	public void EJMJBHBHJEK(CEECFCEGKJJ OIILLNNKNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x15A8890", Offset = "0x15A7490", VA = "0x1815A8890")]
	public void BOABICDENAG(Transform GMDFFJHDCAO, bool GINOPEAEGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x15A9820", Offset = "0x15A8420", VA = "0x1815A9820")]
	public bool NLHKCLDHGGJ(bool JONELMFBHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x15A8FA0", Offset = "0x15A7BA0", VA = "0x1815A8FA0")]
	public void CBFNGFFPFNP(Transform LGLMPHDPDPB, bool GINOPEAEGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x15A8630", Offset = "0x15A7230", VA = "0x1815A8630")]
	public bool AFEKNPNIBII(HEAFGEIIGPC FCANJIFOAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x15A9A00", Offset = "0x15A8600", VA = "0x1815A9A00")]
	public LDGIMFLEKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EDCHKANBKHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<LDGIMFLEKPG.BBFEBEKANPA> MCILGJJBPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private PLEMJHAIPEE DLAFGMLFIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<LDGIMFLEKPG.BBFEBEKANPA> MBFPEIOGCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int GGBLNFNHPJK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x15A24A0", Offset = "0x15A10A0", VA = "0x1815A24A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x15A25A0", Offset = "0x15A11A0", VA = "0x1815A25A0")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x15A23F0", Offset = "0x15A0FF0", VA = "0x1815A23F0")]
	public void DLPDCPCMKFM(LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN, Transform LGLMPHDPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x15A2180", Offset = "0x15A0D80", VA = "0x1815A2180")]
	public void AFEKNPNIBII(LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x15A2050", Offset = "0x15A0C50", VA = "0x1815A2050")]
	private LDGIMFLEKPG.BBFEBEKANPA AAIDIBPIBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x15A2510", Offset = "0x15A1110", VA = "0x1815A2510")]
	private bool FCHNCMCPFBL(LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x15A2390", Offset = "0x15A0F90", VA = "0x1815A2390")]
	private void DJGMCDPGMFD(LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x15A2870", Offset = "0x15A1470", VA = "0x1815A2870")]
	public bool PNDOHBOOLNC(LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x15A2620", Offset = "0x15A1220", VA = "0x1815A2620")]
	public bool NOJNEJFMGMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x15A2330", Offset = "0x15A0F30", VA = "0x1815A2330")]
	private LDGIMFLEKPG.BBFEBEKANPA BKEBKPNJNLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x15A28B0", Offset = "0x15A14B0", VA = "0x1815A28B0")]
	public EDCHKANBKHL()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JGPECIKMPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BNDOPMJEBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int JCAJDCHBLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float CKBECCBDLBL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<LDGIMFLEKPG> HHKNMANMNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x15A3FD0", Offset = "0x15A2BD0", VA = "0x1815A3FD0")]
	public JGPECIKMPML(int BNDOPMJEBKC, int JCAJDCHBLAD, float AFEMOBCKAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x15A3A80", Offset = "0x15A2680", VA = "0x1815A3A80")]
	public void CFJIBBJJPJB(EAJCOLOGLCB MCCDKPAEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x15A3F30", Offset = "0x15A2B30", VA = "0x1815A3F30")]
	private int OOOBMEIEBLO(CEECFCEGKJJ ILAIGPHHGCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x15A3B20", Offset = "0x15A2720", VA = "0x1815A3B20")]
	private void CFJIBBJJPJB(CEECFCEGKJJ ILAIGPHHGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x15A3D50", Offset = "0x15A2950", VA = "0x1815A3D50")]
	private void IHJBIHIIOAN(CEECFCEGKJJ ILAIGPHHGCD, LDGIMFLEKPG KFJKIFGBIFE)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, ICCANLCLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class PHCPPEMDDCL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
			[DebuggerHidden]
			public PHCPPEMDDCL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x15AC300", Offset = "0x15AAF00", VA = "0x1815AC300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x15AC490", Offset = "0x15AB090", VA = "0x1815AC490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x15AC3F0", Offset = "0x15AAFF0", VA = "0x1815AC3F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x15AC3F0", Offset = "0x15AAFF0", VA = "0x1815AC3F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int ABCCNPONMJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x15A06F0", Offset = "0x159F2F0", VA = "0x1815A06F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<PKGONOFHIPO> JCHDNPCPGBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x15A06D0", Offset = "0x159F2D0", VA = "0x1815A06D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> DPPIMBPOMDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LDGIMFLEKPG HDFCNDCNIFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public ACNLPBMJADK HJLNKPCDMNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x578040", Offset = "0x576C40", VA = "0x180578040", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(ACNLPBMJADK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6865A0", Offset = "0x6851A0", VA = "0x1806865A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ICFCLHLAHID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x15A06E0", Offset = "0x159F2E0", VA = "0x1815A06E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x159F410", Offset = "0x159E010", VA = "0x18159F410")]
		public static ClusterMeshRenderer Create(LDGIMFLEKPG NBBCOGHADLE, ClusterMeshRenderer ALPENHEANEC, MeshFilter DHKNNMBLHJO, Transform LGLMPHDPDPB, ACNLPBMJADK HILKLOMPPOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x159F520", Offset = "0x159E120", VA = "0x18159F520", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x159FC80", Offset = "0x159E880", VA = "0x18159FC80", Slot = "10")]
		public bool TryRemoveClusterLODComponent(HEAFGEIIGPC FCANJIFOAJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x159FA50", Offset = "0x159E650", VA = "0x18159FA50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x159F780", Offset = "0x159E380", VA = "0x18159F780")]
		public void Init(LDGIMFLEKPG NBBCOGHADLE, MeshFilter DHKNNMBLHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x159F580", Offset = "0x159E180", VA = "0x18159F580")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x159FDB0", Offset = "0x159E9B0", VA = "0x18159FDB0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 DPBKPCMIPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x159FFF0", Offset = "0x159EBF0", VA = "0x18159FFF0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x159F710", Offset = "0x159E310", VA = "0x18159F710")]
		[IteratorStateMachine(typeof(PHCPPEMDDCL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x159FAD0", Offset = "0x159E6D0", VA = "0x18159FAD0")]
		public void SetupTagAndLayer(string DAHAHKIMHHE, int HILKLOMPPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x159FAB0", Offset = "0x159E6B0", VA = "0x18159FAB0")]
		public bool Remove(HEAFGEIIGPC FCANJIFOAJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LGLKBJEHFGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int NJFKNADNEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NJKMJOGIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int NLGAGPNAJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int DDEMDHHCHHL;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x15A9B80", Offset = "0x15A8780", VA = "0x1815A9B80")]
	public LGLKBJEHFGL(int NJKMJOGIJKL, int NLGAGPNAJIO, int NJFKNADNEKK, int DDEMDHHCHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DEJOOFNJNCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> IIAMKEPDNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> JKNKONLKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> GLOIMKGLFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<LGLKBJEHFGL> CPHNENPANJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> BJFNIDEINDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> JHJMHEJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> LCJNMABBGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle CJMENMLHCDE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MPEBOGALDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2BB60", Offset = "0xA2A760", VA = "0x180A2BB60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDE0", Offset = "0xA2A9E0", VA = "0x180A2BDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x15A0A70", Offset = "0x159F670", VA = "0x1815A0A70")]
	public void HNFMCJIPMMF(MKONELHAHOE KIOICANPDJB, NativeList<LGLKBJEHFGL> CPHNENPANJP, float GMCBFJIKDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x15A0820", Offset = "0x159F420", VA = "0x1815A0820")]
	public void GJANKPMLNFE(Transform LGLMPHDPDPB, bool GINOPEAEGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x15A1820", Offset = "0x15A0420", VA = "0x1815A1820")]
	public void NLHKCLDHGGJ(LDGIMFLEKPG DEEJIANJDED, bool JONELMFBHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x15A0750", Offset = "0x159F350", VA = "0x1815A0750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x15A17F0", Offset = "0x15A03F0", VA = "0x1815A17F0")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DEJOOFNJNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CIMPBBDIPOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> IIAMKEPDNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> JKNKONLKEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<LGLKBJEHFGL> CFFNLILOIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> BJFNIDEINDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 AGBNAMPHNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> JHJMHEJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> LCJNMABBGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GINOPEAEGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float DOOPLPKAMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float LLAIDCHCFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float PJKLHEPOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> GLOIMKGLFDE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x159F1B0", Offset = "0x159DDB0", VA = "0x18159F1B0")]
	public CIMPBBDIPOM(DEJOOFNJNCH OCCCEDJHIFD, Vector3 AGBNAMPHNLN, bool GINOPEAEGBI, float DOOPLPKAMHN, float LLAIDCHCFOD, float PJKLHEPOLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x159ED10", Offset = "0x159D910", VA = "0x18159ED10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HEAFGEIIGPC : EJAPNHGCPCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds MCJMCBFMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BICMMAMDAKJ IPLINPNLACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CEECFCEGKJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<HEAFGEIIGPC> ENGAGIAHIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public CEECFCEGKJJ IDFFNMDMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public CEECFCEGKJJ GEMFGIJEOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public CEECFCEGKJJ HADMMECBBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int DDEMDHHCHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds NFBIDFHJAJG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x159D060", Offset = "0x159BC60", VA = "0x18159D060")]
	public CEECFCEGKJJ(List<HEAFGEIIGPC> ENGAGIAHIFE, [Optional] CEECFCEGKJJ IDFFNMDMLBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EAJCOLOGLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<CEECFCEGKJJ> CFEOMOPODPG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CEECFCEGKJJ IEPGIADAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x15A1FA0", Offset = "0x15A0BA0", VA = "0x1815A1FA0")]
	public EAJCOLOGLCB(CEECFCEGKJJ LGLMPHDPDPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CEPCEPKIHOI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct OANBGGJGKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int FGHBBFOHKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int NLNHLOIIGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int BNLPHDGJCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int KKEOFOCOGJC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DDNOOABOMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DMKJMCGMJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float JHDFIPGJBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<HEAFGEIIGPC> ENGAGIAHIFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum ACIOFOOADFB
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
	private OANBGGJGKGD LDBLPPAGHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int DNEOOHPFPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int BNDOPMJEBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int JCAJDCHBLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float AFEMOBCKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float PHILPFAMHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<CEECFCEGKJJ> BPKIDGHFMBM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public EAJCOLOGLCB LLIHHGOBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x159ECB0", Offset = "0x159D8B0", VA = "0x18159ECB0")]
	public CEPCEPKIHOI(int BNDOPMJEBKC, int JCAJDCHBLAD, float AFEMOBCKAFK, int DNEOOHPFPNN, float PHILPFAMHHJ = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x159D0E0", Offset = "0x159BCE0", VA = "0x18159D0E0")]
	public void ABMINALCDPM(List<HEAFGEIIGPC> ENGAGIAHIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x159D2A0", Offset = "0x159BEA0", VA = "0x18159D2A0")]
	public bool AEMKOHEBFFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x159EB00", Offset = "0x159D700", VA = "0x18159EB00")]
	private float PKJFMFKBEBN(Vector3 CDKHOMPCPAP, Vector3 HHNPPNHMFNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x159EC10", Offset = "0x159D810", VA = "0x18159EC10")]
	private float PKJFMFKBEBN(Vector3 CFIGNJHENGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x159D6A0", Offset = "0x159C2A0", VA = "0x18159D6A0")]
	private bool LDPCKADCHPI(CEECFCEGKJJ DHFOJLHKDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x159DFB0", Offset = "0x159CBB0", VA = "0x18159DFB0")]
	private DDNOOABOMAI OIDDKJKICBA(List<HEAFGEIIGPC> KHGNBEKHNEM, ACIOFOOADFB HEKCCNNOKNI)
	{
		return default(DDNOOABOMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x159D310", Offset = "0x159BF10", VA = "0x18159D310")]
	private void GOKLFEAKJJB(List<HEAFGEIIGPC> ENGAGIAHIFE, Vector3[] PMNIDIBFLEP, Vector3[] PINLPOECKCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class NJBFBBCFEKP
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x15ABF80", Offset = "0x15AAB80", VA = "0x1815ABF80")]
	public static Bounds IABFBKFOIED(List<HEAFGEIIGPC> ENGAGIAHIFE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x15ABDF0", Offset = "0x15AA9F0", VA = "0x1815ABDF0")]
	public static int DKMJBMGDMAL(List<HEAFGEIIGPC> ENGAGIAHIFE, NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PLEMJHAIPEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private MKONELHAHOE OMKCEALBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private MKONELHAHOE CKJCCAJIMGA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static MKONELHAHOE LJMLKJHAFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private BNAEMOLHHNM PDLEJALIHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AODGPNCLJGB FEKGOBDFACC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle CJMENMLHCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60B9A0", Offset = "0x60A5A0", VA = "0x18060B9A0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA486A0", Offset = "0xA472A0", VA = "0x180A486A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LDGIMFLEKPG.BBFEBEKANPA DHFOJLHKDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BFGMPDPJHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9064C0", Offset = "0x9050C0", VA = "0x1809064C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x15AD4D0", Offset = "0x15AC0D0", VA = "0x1815AD4D0")]
	[BIEDHDEFKGL(LOMHOCOLDLE.ExitingPlayMode, 0)]
	private void MIALIKKGHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x15ACB10", Offset = "0x15AB710", VA = "0x1815ACB10")]
	public void HNFMCJIPMMF(LDGIMFLEKPG.BBFEBEKANPA CFFNLILOIBM, Transform JIJNCECNMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x15AC4E0", Offset = "0x15AB0E0", VA = "0x1815AC4E0")]
	public void CPLDJPHPLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x15ACAA0", Offset = "0x15AB6A0", VA = "0x1815ACAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x15AD490", Offset = "0x15AC090", VA = "0x1815AD490")]
	public void IJBCCCJHCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x15AD540", Offset = "0x15AC140", VA = "0x1815AD540")]
	public PLEMJHAIPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PHGBDHDGFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JKMMGCANMEE GFNNLEEBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NNIGGEPIAJD
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 GAMLDPDNINH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OENPCHDFIFK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JJDPLGCFKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GKBKMLNMONG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action OJEBPLAFEGI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NBOJBFHEKAC
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBOJBFHEKAC GHLEKPEFLLF(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBOJBFHEKAC BJFGFNJFEMF(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBOJBFHEKAC GJKHAENIAJI(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBOJBFHEKAC BHILHOGODFA(Action LKFICPAOGAF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class HKDFKOOMGNH : NBOJBFHEKAC
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class LFKMMEGKAKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public HKDFKOOMGNH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public LFKMMEGKAKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x15A9AA0", Offset = "0x15A86A0", VA = "0x1815A9AA0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x15A9AF0", Offset = "0x15A86F0", VA = "0x1815A9AF0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x15A9B40", Offset = "0x15A8740", VA = "0x1815A9B40")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> LIGKKFNEPNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action CKIIJJPAFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action JLFHJMNHKIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NGJDNHMMIEO DMBLHMFPEMM;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action ADJBMBFLNPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x64DDB0", Offset = "0x64C9B0", VA = "0x18064DDB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action MCACFMMAHPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA19760", Offset = "0xA18360", VA = "0x180A19760", Slot = "4")]
			public NBOJBFHEKAC GHLEKPEFLLF(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x946560", Offset = "0x945160", VA = "0x180946560", Slot = "5")]
			public NBOJBFHEKAC BJFGFNJFEMF(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1047D60", Offset = "0x1046960", VA = "0x181047D60", Slot = "6")]
			public NBOJBFHEKAC GJKHAENIAJI(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB30", Offset = "0xD29730", VA = "0x180D2AB30", Slot = "7")]
			public NBOJBFHEKAC BHILHOGODFA(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B97A0", Offset = "0x5B83A0", VA = "0x1805B97A0")]
			public HKDFKOOMGNH(Func<JobHandle> ABAIEIFDJOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x15A37B0", Offset = "0x15A23B0", VA = "0x1815A37B0")]
			public void LLAGDPBIDMA(Action ANDKCBONLAF, Action MLFOCMCBKBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x15A3650", Offset = "0x15A2250", VA = "0x1815A3650")]
			public void AFEKNPNIBII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class INFPMCCJJMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public NBOJBFHEKAC jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public INFPMCCJJMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x15A39E0", Offset = "0x15A25E0", VA = "0x1815A39E0")]
			internal bool <Remove>b__0(HKDFKOOMGNH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class OAMEKAKLPMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public HKDFKOOMGNH newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public OAMEKAKLPMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x15AC130", Offset = "0x15AAD30", VA = "0x1815AC130")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<HKDFKOOMGNH> HPMDDJMNLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<HKDFKOOMGNH> HMGAOOPDOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private OLAOJJPOAKP FDNJOJGIFDO;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x15A6A90", Offset = "0x15A5690", VA = "0x1815A6A90")]
		public NBOJBFHEKAC Add(Func<JobHandle> ABAIEIFDJOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x15A6D30", Offset = "0x15A5930", VA = "0x1815A6D30")]
		public void Remove(NBOJBFHEKAC CJMENMLHCDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x15A6BB0", Offset = "0x15A57B0", VA = "0x1815A6BB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x15A6EB0", Offset = "0x15A5AB0", VA = "0x1815A6EB0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x15A7080", Offset = "0x15A5C80", VA = "0x1815A7080")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x15A6BA0", Offset = "0x15A57A0", VA = "0x1815A6BA0")]
		[CompilerGenerated]
		private void ENHPCCCABGE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NGJDNHMMIEO
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGJDNHMMIEO GHLEKPEFLLF(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGJDNHMMIEO DPADCFFOJGA(Action LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGJDNHMMIEO BHILHOGODFA(Action LKFICPAOGAF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class JDCKKHFLIHP : NGJDNHMMIEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle MEMGOEIAPDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action CKIIJJPAFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action PMEIFONCFAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action MCACFMMAHPO;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool MONCEHKLPEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x15A3A70", Offset = "0x15A2670", VA = "0x1815A3A70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x946560", Offset = "0x945160", VA = "0x180946560", Slot = "4")]
			public NGJDNHMMIEO GHLEKPEFLLF(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1047D60", Offset = "0x1046960", VA = "0x181047D60", Slot = "5")]
			public NGJDNHMMIEO DPADCFFOJGA(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB30", Offset = "0xD29730", VA = "0x180D2AB30", Slot = "6")]
			public NGJDNHMMIEO BHILHOGODFA(Action LKFICPAOGAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x14C1750", Offset = "0x14C0350", VA = "0x1814C1750")]
			public JDCKKHFLIHP(JobHandle CPKPLGDNIEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x15A3A30", Offset = "0x15A2630", VA = "0x1815A3A30")]
			public void OMAIJKDLOLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x15A39F0", Offset = "0x15A25F0", VA = "0x1815A39F0")]
			public void AFEKNPNIBII()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<JDCKKHFLIHP> PJMBGFNBHNB;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x15A7500", Offset = "0x15A6100", VA = "0x1815A7500")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x15A7140", Offset = "0x15A5D40", VA = "0x1815A7140")]
		public NGJDNHMMIEO Add(JobHandle CPKPLGDNIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x15A7410", Offset = "0x15A6010", VA = "0x1815A7410")]
		public void Remove(NGJDNHMMIEO CJMENMLHCDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x15A72B0", Offset = "0x15A5EB0", VA = "0x1815A72B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x15A71D0", Offset = "0x15A5DD0", VA = "0x1815A71D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x15A7610", Offset = "0x15A6210", VA = "0x1815A7610")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x15A19B0", Offset = "0x15A05B0", VA = "0x1815A19B0")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x15A1AB0", Offset = "0x15A06B0", VA = "0x1815A1AB0")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
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
