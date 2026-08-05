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
				[Cpp2IlInjected.Address(RVA = "0x4472F50", Offset = "0x4471B50", VA = "0x184472F50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x18DC750", Offset = "0x18DB350", VA = "0x1818DC750")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4472F10", Offset = "0x4471B10", VA = "0x184472F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x446C480", Offset = "0x446B080", VA = "0x18446C480")]
		public LODSettings JJDEPKCHHJK(IMCEDJCLDKI DOHMILLIOJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x446C460", Offset = "0x446B060", VA = "0x18446C460")]
		public int GFPDFHDCPCP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x446C360", Offset = "0x446AF60", VA = "0x18446C360")]
		public int ADBACNJAFEN(bool IJAIKKHBGBO, Vector3 FDKOACIBOCP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x446C490", Offset = "0x446B090", VA = "0x18446C490")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GENDKDKKJNM
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
public interface NHFKLBBFDLH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLHJPONFLKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DLDKCCAKLAE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OJHJDPMBBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<CFPLBAHOLOE> BGGIDNNJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GENDKDKKJNM NABKLDFDEDI
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
	void UpdateClusterDistances(Vector3 DJIMDDMFBKK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(PBFGMFODGGJ MHMLJIFKLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CFPLBAHOLOE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int BPBABNHAMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GPLGPEFBOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JMBNCFGAAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float LEFFJLANGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte MIGMMAABECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CEAFBAIGMGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GFNJCNGOHMJ
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
	private sealed class JKCIJHIJKCH : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CEAFBAIGMGM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public JKCIJHIJKCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x44718A0", Offset = "0x44704A0", VA = "0x1844718A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4471960", Offset = "0x4470560", VA = "0x184471960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KNNMDANEOHE : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EPJBAFONDLI <>2__current;

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
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public KNNMDANEOHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44725C0", Offset = "0x44711C0", VA = "0x1844725C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4472710", Offset = "0x4471310", VA = "0x184472710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IPCLAOOJCBB : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CEAFBAIGMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<EPJBAFONDLI> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public IPCLAOOJCBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4470DE0", Offset = "0x446F9E0", VA = "0x184470DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4471850", Offset = "0x4470450", VA = "0x184471850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CAFMPADEBND : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CEAFBAIGMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public CAFMPADEBND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4468A00", Offset = "0x4467600", VA = "0x184468A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x44698F0", Offset = "0x44684F0", VA = "0x1844698F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int POALPEDHKKD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer IMDEKMAAJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter HIMGKKODILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject OMFMLDKAECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject BBJLCHBEKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public BGOGHDLJNDH EFJLMLGCGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<PBFGMFODGGJ> HGMEBDHJEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<PBFGMFODGGJ> NFFNCNMIMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<PBFGMFODGGJ> DGNEPLMBCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int KFKELDIHCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GFNJCNGOHMJ FOKMEBBENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<DLDKCCAKLAE>[] GOPIGPFCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<CFPLBAHOLOE>[] IFAFMCMPLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private HGNPLDPHFIE DCFIKDECNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private HGNPLDPHFIE DONIMKFJGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HGNPLDPHFIE EEOKEMKMDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int EPMEBCNGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int GFHDMAPLMHH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static CEAFBAIGMGM MOGCDGMPNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GIHBHELJJOL KLAPKMFIFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ODIDOJGEBJJ BLFBDBPINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour IEBLJMHOOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material JDMDIFOHMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NHFKLBBFDLH> BLMNBJBJDOI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig GIGPHPONEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 CJJDJJBKBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15663F0", Offset = "0x1564FF0", VA = "0x1815663F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1566320", Offset = "0x1564F20", VA = "0x181566320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private GFNJCNGOHMJ OEFHOOCGFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56FCD0", Offset = "0x56E8D0", VA = "0x18056FCD0")]
		get
		{
			return default(GFNJCNGOHMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x446BCC0", Offset = "0x446A8C0", VA = "0x18446BCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CEAFBAIGMGM PMDDBIJFNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x446A7E0", Offset = "0x44693E0", VA = "0x18446A7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool OAGOBGFKAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x446AD20", Offset = "0x4469920", VA = "0x18446AD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool LJLHLIKIENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x446BA90", Offset = "0x446A690", VA = "0x18446BA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NPJLKNKLJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x446A860", Offset = "0x4469460", VA = "0x18446A860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4469F40", Offset = "0x4468B40", VA = "0x184469F40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ICJKHEHKEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4469B40", Offset = "0x4468740", VA = "0x184469B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x446AE30", Offset = "0x4469A30", VA = "0x18446AE30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x446BDE0", Offset = "0x446A9E0", VA = "0x18446BDE0")]
	public CEAFBAIGMGM(GIHBHELJJOL KLAPKMFIFAJ, ODIDOJGEBJJ BLFBDBPINMA, ClusterLODConfig OPHNLOBBKFP, MonoBehaviour IEBLJMHOOII, Material JDMDIFOHMHP, ClusterMeshRenderer IMDEKMAAJMG, MeshFilter HIMGKKODILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x446ADA0", Offset = "0x44699A0", VA = "0x18446ADA0")]
	private void JHLLLDKKBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x446A2A0", Offset = "0x4468EA0", VA = "0x18446A2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x446AA20", Offset = "0x4469620", VA = "0x18446AA20")]
	public static void INOCEIHFJFG(Vector3 BPNBFAAIFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x446AC80", Offset = "0x4469880", VA = "0x18446AC80")]
	private void JHBBHEJKGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x446A4B0", Offset = "0x44690B0", VA = "0x18446A4B0")]
	private void ENCELILKJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4469A00", Offset = "0x4468600", VA = "0x184469A00")]
	private void BLJCFDOANMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4469FE0", Offset = "0x4468BE0", VA = "0x184469FE0")]
	public void DOLEILHBJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x446A3D0", Offset = "0x4468FD0", VA = "0x18446A3D0")]
	[IteratorStateMachine(typeof(JKCIJHIJKCH))]
	private IEnumerator<EPJBAFONDLI> EDALDAMABJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x446A900", Offset = "0x4469500", VA = "0x18446A900")]
	[IteratorStateMachine(typeof(KNNMDANEOHE))]
	private IEnumerator<EPJBAFONDLI> HNFEKCBBFJO(Func<bool> ANJNLLEMOOJ, float COIACHHEFBM, Func<string> KAMKLKADFMA, float FLHLCCMEKAF = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x446B850", Offset = "0x446A450", VA = "0x18446B850")]
	[IteratorStateMachine(typeof(IPCLAOOJCBB))]
	private IEnumerator<EPJBAFONDLI> LINAIAMLIJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x446B640", Offset = "0x446A240", VA = "0x18446B640")]
	public void LFILLMKEEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x446A9A0", Offset = "0x44695A0", VA = "0x18446A9A0")]
	public void ILFBJNPLEKO(IEnumerable<DLDKCCAKLAE> ABOOJAADNGO, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4469C90", Offset = "0x4468890", VA = "0x184469C90")]
	public void DNFHIJNOAEC(IEnumerable<DLDKCCAKLAE> ABOOJAADNGO, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x446AED0", Offset = "0x4469AD0", VA = "0x18446AED0")]
	public List<ClusterMeshRenderer> KPNDFGHCMPM(List<PBFGMFODGGJ> JBBIHCMEAGD, Transform AMKOBFEBOFJ, GENDKDKKJNM CEHCHEPGPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4469940", Offset = "0x4468540", VA = "0x184469940")]
	public GENDKDKKJNM AKIAEFHDFIK(Vector3 DJEENFAFPJE)
	{
		return default(GENDKDKKJNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4469BE0", Offset = "0x44687E0", VA = "0x184469BE0")]
	public void DCBMPIDBOCI(NHFKLBBFDLH FCENFGODABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x446BC60", Offset = "0x446A860", VA = "0x18446BC60")]
	public bool PAEGJPDGFLF(NHFKLBBFDLH FCENFGODABG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x446B8C0", Offset = "0x446A4C0", VA = "0x18446B8C0")]
	public void NJPJKBHPALJ(PBFGMFODGGJ GBPKILEHMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x446A5B0", Offset = "0x44691B0", VA = "0x18446A5B0")]
	public void FCCEBPPBLHK(CFPLBAHOLOE GCMEGDICJNC, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4469980", Offset = "0x4468580", VA = "0x184469980")]
	public void ANECMACKPHM(CFPLBAHOLOE GCMEGDICJNC, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x446BB30", Offset = "0x446A730", VA = "0x18446BB30")]
	private void OPFMMGNJKNK(Vector3 DJIMDDMFBKK, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x446A630", Offset = "0x4469230", VA = "0x18446A630")]
	private void FGDLIKKCKLJ(Vector3 DJIMDDMFBKK, GENDKDKKJNM CEHCHEPGPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x446A440", Offset = "0x4469040", VA = "0x18446A440")]
	[IteratorStateMachine(typeof(CAFMPADEBND))]
	private IEnumerator<EPJBAFONDLI> EIMGGAKHGMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x446B920", Offset = "0x446A520", VA = "0x18446B920")]
	private int OBEGHNKPEAD(int PMMFOLCEJEJ, int LDJFKKHBJJE, List<CFPLBAHOLOE> PINLGPDHCIO, byte DOHMILLIOJG, ref int DCOLIPHLCNG, float LJPMAANNOAB = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x446AAB0", Offset = "0x44696B0", VA = "0x18446AAB0")]
	public void JGCOEHFAOLL(PBFGMFODGGJ MHMLJIFKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x446BAF0", Offset = "0x446A6F0", VA = "0x18446BAF0")]
	public bool ONACPICKICH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F0", Offset = "0x5E44F0", VA = "0x1805E58F0")]
	public Material IPKMNCGGPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x446A7A0", Offset = "0x44693A0", VA = "0x18446A7A0")]
	public int GFPDFHDCPCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4469C40", Offset = "0x4468840", VA = "0x184469C40")]
	[CompilerGenerated]
	private bool DMNFEIHCAHH()
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
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct LELIJLPFHFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> OJMHOCKEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> AMEACCBOPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> DGMCGABFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> ANGJOEFPBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> PNCGDIMNNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> NIDDNGABBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> EOEOGCGCPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 GFKGOCNEOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float FPEFIDJFCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> LEIOBAPGODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> KHIPAOPJGGK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4472E50", Offset = "0x4471A50", VA = "0x184472E50")]
	public LELIJLPFHFD(LBINJGCGJPI BOPDJBBKDBP, NativeList<float3> EOEOGCGCPOD, NativeMultiHashMap<int, int> LEIOBAPGODM, NativeArray<int> KHIPAOPJGGK, Vector3 GFKGOCNEOOG, float FPEFIDJFCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4472DF0", Offset = "0x44719F0", VA = "0x184472DF0")]
	private int IIJEKKPLKBE(float3 DJIMDDMFBKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4472760", Offset = "0x4471360", VA = "0x184472760")]
	private int BPDLICPNHOD(int DAEOPGECNJN, int OMAJLLKKGPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4472A00", Offset = "0x4471600", VA = "0x184472A00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DEBBMPLOBBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> LEIOBAPGODM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> KHIPAOPJGGK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int FDAMGBMJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> FMEFIOKOIJG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x446D970", Offset = "0x446C570", VA = "0x18446D970")]
	public void LOHGCAAGMDC(int KDIDPAFPFDN, Allocator OFODLBFFFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x446D8C0", Offset = "0x446C4C0", VA = "0x18446D8C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public DEBBMPLOBBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GBIPFPALINH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LJHLOOGOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> KNMKMPAJJEK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x44701C0", Offset = "0x446EDC0", VA = "0x1844701C0")]
	public GBIPFPALINH(DEBBMPLOBBN MPALMEDPKKK, LBINJGCGJPI BOPDJBBKDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4470130", Offset = "0x446ED30", VA = "0x184470130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct ONDJLHIFHIM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> GMLHDMNHGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> JHNBIPOBLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> BIBIBNGLPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> FLDANIFNCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> GELENHIOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> FMEFIOKOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LJHLOOGOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> OACHLJODOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> GMDHFAKCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> OMOGGDJCFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> NIGCCIBDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> KPKGCEKHHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> LMEAAKOEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float LADPGJIPAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float KFGFAAHKNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 LOJFDHDBNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float BANLDMMMDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float CBLAEGHHBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float JPFDCDJFECB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4478AE0", Offset = "0x44776E0", VA = "0x184478AE0")]
	public ONDJLHIFHIM(DEBBMPLOBBN BLNACNEALFE, LBINJGCGJPI BOPDJBBKDBP, LBINJGCGJPI JNLOKHIHAKF, float CBLAEGHHBFB, float JPFDCDJFECB, Vector3 LOJFDHDBNKG, float BANLDMMMDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x44787D0", Offset = "0x44773D0", VA = "0x1844787D0")]
	private float3 LPMAFAPLALM(int DAEOPGECNJN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4477500", Offset = "0x4476100", VA = "0x184477500")]
	private void ALBLMDLGLDL(int DAEOPGECNJN, out float3 KBFPJIPNFEG, out float3 LCLEFKIACPP, out float4 BOANMPPBLBL, out float4 GJNKKGAEGPB, out float2 OJIALCCIAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4478040", Offset = "0x4476C40", VA = "0x184478040")]
	private int FKKGAEICKDD(int BLJBPNJEKLO, int PAKGOBNCLIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x44785D0", Offset = "0x44771D0", VA = "0x1844785D0")]
	private void LEKKHGFBIDC(int BLJBPNJEKLO, int PAKGOBNCLIA, int OLGMLJJJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4478870", Offset = "0x4477470", VA = "0x184478870")]
	private bool OJKGDPFEPFK(int BLJBPNJEKLO, int PAKGOBNCLIA, float ONONEBLDBDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4478A20", Offset = "0x4477620", VA = "0x184478A20")]
	private bool PPCOJGIPNKH(int BLJBPNJEKLO, int PAKGOBNCLIA, int OLGMLJJJPAI, float ONONEBLDBDA, bool KKGCOBJJKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4478370", Offset = "0x4476F70", VA = "0x184478370")]
	private bool FPEGIPMMIOA(int BLJBPNJEKLO, int PAKGOBNCLIA, int OLGMLJJJPAI, float ONONEBLDBDA, bool KKGCOBJJKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4478A00", Offset = "0x4477600", VA = "0x184478A00")]
	private void OOONDINJIBM(int BLJBPNJEKLO, int PAKGOBNCLIA, int OLGMLJJJPAI, out int CPOKHLLAGLH, out int INJGGCKOAMA, out int BOHGGAODEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44776E0", Offset = "0x44762E0", VA = "0x1844776E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NBIOIMKKKCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OJMKNAIJFOI : IDisposable, CFPLBAHOLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds OIBAKLLOCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<PBFGMFODGGJ> JBBIHCMEAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 MMPBGENCNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 IPLGJCKAPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int JFDDHKJCKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LBINJGCGJPI EANEFFINKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DEBBMPLOBBN PLKPJNJGHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform AMKOBFEBOFJ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int OMPLOOGPLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4476A40", Offset = "0x4475640", VA = "0x184476A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh BNPNFMKNEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh OIDMNMMEEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x55D010", Offset = "0x55BC10", VA = "0x18055D010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x55D020", Offset = "0x55BC20", VA = "0x18055D020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMBNCFGAAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD7DCF0", Offset = "0xD7C8F0", VA = "0x180D7DCF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E24CF0", Offset = "0x1E238F0", VA = "0x181E24CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte MIGMMAABECK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x689A50", Offset = "0x688650", VA = "0x180689A50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x689BE0", Offset = "0x6887E0", VA = "0x180689BE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BPBABNHAMBB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6F12D0", Offset = "0x6EFED0", VA = "0x1806F12D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6F0960", Offset = "0x6EF560", VA = "0x1806F0960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int GPLGPEFBOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA6B370", Offset = "0xA69F70", VA = "0x180A6B370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCCB4A0", Offset = "0xCCA0A0", VA = "0x180CCB4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float LEFFJLANGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4476E20", Offset = "0x4475A20", VA = "0x184476E20", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4476A80", Offset = "0x4475680", VA = "0x184476A80")]
		public void CJNMHDMJMGD(IMCEDJCLDKI DOHMILLIOJG, out int JPADELPMENJ, out int DCGIINMLNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4476F80", Offset = "0x4475B80", VA = "0x184476F80")]
		public void OFJILKDDBBF(IMCEDJCLDKI DOHMILLIOJG, GCHGOLJHCBO JIDMNHPGIDN, int IBFFAMJJMEO = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4477120", Offset = "0x4475D20", VA = "0x184477120")]
		public void PFNEAOPFCJE(NativeList<PDLKBNNDGAA> HOLALDDEOOG, Transform KAOJBAPHGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4476EE0", Offset = "0x4475AE0", VA = "0x184476EE0")]
		public void KHNKKGFOHJB(Mesh BOPDJBBKDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4476E40", Offset = "0x4475A40", VA = "0x184476E40")]
		public void INDDACBHGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4476CB0", Offset = "0x44758B0", VA = "0x184476CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4477440", Offset = "0x4476040", VA = "0x184477440")]
		public OJMKNAIJFOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds OIBAKLLOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<OJMKNAIJFOI> JCEKHONNCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public OJCIFKNBBDL DEPGBMGBDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer FGMFLLPICOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int EMNFOEHKNKL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh LEAAFFMBIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6875A0", Offset = "0x6861A0", VA = "0x1806875A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DOFMKNELLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72F740", Offset = "0x72E340", VA = "0x18072F740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72F7C0", Offset = "0x72E3C0", VA = "0x18072F7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OJHJDPMBBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4474580", Offset = "0x4473180", VA = "0x184474580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4474270", Offset = "0x4472E70", VA = "0x184474270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4474240", Offset = "0x4472E40", VA = "0x184474240")]
	public int DFJEEPGLNJC(int PJLEGKNDLCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x44754D0", Offset = "0x44740D0", VA = "0x1844754D0")]
	public void MCDMDHBFEBO(DAPGNMGHIJI EGCFAPCMLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4474B60", Offset = "0x4473760", VA = "0x184474B60")]
	public void JCPDDCODFDL(Transform KAOJBAPHGMK, bool PCDIEIICGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x44743D0", Offset = "0x4472FD0", VA = "0x1844743D0")]
	public bool FJFEBJBPIJE(bool NOINEDJBAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x44745D0", Offset = "0x44731D0", VA = "0x1844745D0")]
	public void HGOCEMACJDL(Transform AMKOBFEBOFJ, bool PCDIEIICGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4475270", Offset = "0x4473E70", VA = "0x184475270")]
	public bool JGCOEHFAOLL(PBFGMFODGGJ MHMLJIFKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4475660", Offset = "0x4474260", VA = "0x184475660")]
	public NBIOIMKKKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BGOGHDLJNDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NBIOIMKKKCC.OJMKNAIJFOI> ENNNJOINING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MODJIOEOPOD HNMBPGKLBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<NBIOIMKKKCC.OJMKNAIJFOI> BCFKHKMEMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int CBKPFBFKJGN;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4467DE0", Offset = "0x44669E0", VA = "0x184467DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4467CB0", Offset = "0x44668B0", VA = "0x184467CB0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4467D30", Offset = "0x4466930", VA = "0x184467D30")]
	public void DNJODILJGAL(NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE, Transform AMKOBFEBOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44682C0", Offset = "0x4466EC0", VA = "0x1844682C0")]
	public void JGCOEHFAOLL(NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4467EE0", Offset = "0x4466AE0", VA = "0x184467EE0")]
	private NBIOIMKKKCC.OJMKNAIJFOI HJFIBMPDDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4467E50", Offset = "0x4466A50", VA = "0x184467E50")]
	private bool FEPOKPGLJIH(NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4468260", Offset = "0x4466E60", VA = "0x184468260")]
	private void JDIKGHJEBMM(NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44684D0", Offset = "0x44670D0", VA = "0x1844684D0")]
	public bool PPICJCHFCAI(NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4468010", Offset = "0x4466C10", VA = "0x184468010")]
	public bool JCFJPEDKEOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4468470", Offset = "0x4467070", VA = "0x184468470")]
	private NBIOIMKKKCC.OJMKNAIJFOI MMEECBMOOPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4468510", Offset = "0x4467110", VA = "0x184468510")]
	public BGOGHDLJNDH()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ILFLJDPDJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int NJIHCLMDBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int KBCALCKPDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float LBAFMJCOOAH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<NBIOIMKKKCC> CKJCAKCDHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4470D90", Offset = "0x446F990", VA = "0x184470D90")]
	public ILFLJDPDJII(int NJIHCLMDBFG, int KBCALCKPDKD, float AIBDJMKDHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4470840", Offset = "0x446F440", VA = "0x184470840")]
	public void CMENKODDOIP(FLJFAAECBPO FDNJLMHHIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4470B10", Offset = "0x446F710", VA = "0x184470B10")]
	private int CPLFGFAKMAL(DAPGNMGHIJI AECOIJJOAMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44708E0", Offset = "0x446F4E0", VA = "0x1844708E0")]
	private void CMENKODDOIP(DAPGNMGHIJI AECOIJJOAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4470BB0", Offset = "0x446F7B0", VA = "0x184470BB0")]
	private void MLLJHABBGEJ(DAPGNMGHIJI AECOIJJOAMC, NBIOIMKKKCC ODMAPPNMGAN)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, DLDKCCAKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MAFPIJOLCMC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
			[DebuggerHidden]
			public MAFPIJOLCMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4472F70", Offset = "0x4471B70", VA = "0x184472F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4473100", Offset = "0x4471D00", VA = "0x184473100", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4473060", Offset = "0x4471C60", VA = "0x184473060", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4473060", Offset = "0x4471C60", VA = "0x184473060", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int OJHJDPMBBJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x446D7D0", Offset = "0x446C3D0", VA = "0x18446D7D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<CFPLBAHOLOE> BGGIDNNJKAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x446D7B0", Offset = "0x446C3B0", VA = "0x18446D7B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> JCEKHONNCHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public NBIOIMKKKCC LEAAFFMBIMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public GENDKDKKJNM NABKLDFDEDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x55D390", Offset = "0x55BF90", VA = "0x18055D390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(GENDKDKKJNM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x711970", Offset = "0x710570", VA = "0x180711970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DEDIMALEHDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x446D7C0", Offset = "0x446C3C0", VA = "0x18446D7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x446C4F0", Offset = "0x446B0F0", VA = "0x18446C4F0")]
		public static ClusterMeshRenderer Create(NBIOIMKKKCC BOPDJBBKDBP, ClusterMeshRenderer IMDEKMAAJMG, MeshFilter HIMGKKODILI, Transform AMKOBFEBOFJ, GENDKDKKJNM CEHCHEPGPIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x446C600", Offset = "0x446B200", VA = "0x18446C600", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x446CD60", Offset = "0x446B960", VA = "0x18446CD60", Slot = "10")]
		public bool TryRemoveClusterLODComponent(PBFGMFODGGJ MHMLJIFKLGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x446CB30", Offset = "0x446B730", VA = "0x18446CB30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x446C860", Offset = "0x446B460", VA = "0x18446C860")]
		public void Init(NBIOIMKKKCC BOPDJBBKDBP, MeshFilter HIMGKKODILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x446C660", Offset = "0x446B260", VA = "0x18446C660")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x446CE90", Offset = "0x446BA90", VA = "0x18446CE90", Slot = "8")]
		public void UpdateClusterDistances(Vector3 DJIMDDMFBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x446D0D0", Offset = "0x446BCD0", VA = "0x18446D0D0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x446C7F0", Offset = "0x446B3F0", VA = "0x18446C7F0")]
		[IteratorStateMachine(typeof(MAFPIJOLCMC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x446CBB0", Offset = "0x446B7B0", VA = "0x18446CBB0")]
		public void SetupTagAndLayer(string FJKGLKMDBMJ, int CEHCHEPGPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x446CB90", Offset = "0x446B790", VA = "0x18446CB90")]
		public bool Remove(PBFGMFODGGJ MHMLJIFKLGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BMFPPGKJGLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int HBIOGKGNGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NAIHDOIDODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int DCGIINMLNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JPADELPMENJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x44689E0", Offset = "0x44675E0", VA = "0x1844689E0")]
	public BMFPPGKJGLP(int NAIHDOIDODJ, int DCGIINMLNMB, int HBIOGKGNGLG, int JPADELPMENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OJCIFKNBBDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> OJMHOCKEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> FMEFIOKOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> NIDDNGABBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<BMFPPGKJGLP> PJMEPJOGNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> EJCCMJIHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> OKHKFEPGIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> FEGPBDBMBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle BHJBIIINCII;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LGAGHLEMPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C50", Offset = "0x6D8850", VA = "0x1806D9C50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C70", Offset = "0x6D8870", VA = "0x1806D9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4475A60", Offset = "0x4474660", VA = "0x184475A60")]
	public void DMABPKIBKAO(LBINJGCGJPI KHNKAKBMFBK, NativeList<BMFPPGKJGLP> PJMEPJOGNNK, float OHGJMHHFFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4475810", Offset = "0x4474410", VA = "0x184475810")]
	public void CAHLPDAFKKB(Transform AMKOBFEBOFJ, bool PCDIEIICGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44768B0", Offset = "0x44754B0", VA = "0x1844768B0")]
	public void FJFEBJBPIJE(NBIOIMKKKCC FGMFLLPICOA, bool NOINEDJBAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x44767E0", Offset = "0x44753E0", VA = "0x1844767E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x44757E0", Offset = "0x44743E0", VA = "0x1844757E0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OJCIFKNBBDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct DHLLMLDLBNO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> OJMHOCKEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> FMEFIOKOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<BMFPPGKJGLP> CCLEHMICIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> EJCCMJIHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 LOJFDHDBNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> OKHKFEPGIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> FEGPBDBMBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool PCDIEIICGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float BBILCMMPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float LKCNADPMMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float NNLICJNIDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> NIDDNGABBBB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x446DFB0", Offset = "0x446CBB0", VA = "0x18446DFB0")]
	public DHLLMLDLBNO(OJCIFKNBBDL BBPDEPGBGEB, Vector3 LOJFDHDBNKG, bool PCDIEIICGBJ, float BBILCMMPHJG, float LKCNADPMMGI, float NNLICJNIDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x446DB10", Offset = "0x446C710", VA = "0x18446DB10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PBFGMFODGGJ : JNGGENGNNGN
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds LFCNGOFLBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PDLKBNNDGAA HCGLNOFIEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DAPGNMGHIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<PBFGMFODGGJ> JBBIHCMEAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public DAPGNMGHIJI JNKAEALDKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public DAPGNMGHIJI JJHJPAFODEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public DAPGNMGHIJI KDDJOAFLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int JPADELPMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds OIBAKLLOCJM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x446D840", Offset = "0x446C440", VA = "0x18446D840")]
	public DAPGNMGHIJI(List<PBFGMFODGGJ> JBBIHCMEAGD, [Optional] DAPGNMGHIJI JNKAEALDKKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FLJFAAECBPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<DAPGNMGHIJI> NHLKNNJFIFN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public DAPGNMGHIJI DPAECMOKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x446FFF0", Offset = "0x446EBF0", VA = "0x18446FFF0")]
	public FLJFAAECBPO(DAPGNMGHIJI AMKOBFEBOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ELJMNCBANDP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct JPEPAKJIIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int ANHCFPFPKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int PKFMGOGNMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int GFFGDBHHANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int AEIFNAACPFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct IFCEAIKKGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int HAGBMEKDHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float PBFENODKIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<PBFGMFODGGJ> JBBIHCMEAGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum IJCGPOPJDBN
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
	private JPEPAKJIIFJ KLIJNGGPMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int MDLPCCPDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int NJIHCLMDBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KBCALCKPDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float AIBDJMKDHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float JFMBIGPEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<DAPGNMGHIJI> EKKFKOPNEGA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FLJFAAECBPO CANFOEKFJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x446FF90", Offset = "0x446EB90", VA = "0x18446FF90")]
	public ELJMNCBANDP(int NJIHCLMDBFG, int KBCALCKPDKD, float AIBDJMKDHPF, int MDLPCCPDAHI, float JFMBIGPEBFO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x446FC20", Offset = "0x446E820", VA = "0x18446FC20")]
	public void LEFAIMNHLFP(List<PBFGMFODGGJ> JBBIHCMEAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x446E3C0", Offset = "0x446CFC0", VA = "0x18446E3C0")]
	public bool COECEONCBNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x446FE80", Offset = "0x446EA80", VA = "0x18446FE80")]
	private float MKFJGBKPMBP(Vector3 OCAJMDJLGFP, Vector3 DOMFGMBOICJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x446FDE0", Offset = "0x446E9E0", VA = "0x18446FDE0")]
	private float MKFJGBKPMBP(Vector3 BNLHOMCBDLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x446F310", Offset = "0x446DF10", VA = "0x18446F310")]
	private bool IOHJJNEJIIK(DAPGNMGHIJI JOGAHPBGEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x446E430", Offset = "0x446D030", VA = "0x18446E430")]
	private IFCEAIKKGMN EANDOPMAPPL(List<PBFGMFODGGJ> GDKKCODBKIN, IJCGPOPJDBN PEMOHBLFEDN)
	{
		return default(IFCEAIKKGMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x446EF80", Offset = "0x446DB80", VA = "0x18446EF80")]
	private void HNHIKPEPMIL(List<PBFGMFODGGJ> JBBIHCMEAGD, Vector3[] ADNNFNOMPAA, Vector3[] OIACCIMHBHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DOIJCJJOJPF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x446E210", Offset = "0x446CE10", VA = "0x18446E210")]
	public static Bounds GGEHNIGHJMA(List<PBFGMFODGGJ> JBBIHCMEAGD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x446E080", Offset = "0x446CC80", VA = "0x18446E080")]
	public static int DPIKMNHHOBI(List<PBFGMFODGGJ> JBBIHCMEAGD, IMCEDJCLDKI DOHMILLIOJG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MODJIOEOPOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private LBINJGCGJPI JNEIFOBPKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LBINJGCGJPI OMHFOCFNDJC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static LBINJGCGJPI IKOAKJMKLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private OMAHFAEOKBD EMAJGOBPCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private GCHGOLJHCBO JIDMNHPGIDN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle BHJBIIINCII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E90", Offset = "0x7F3A90", VA = "0x1807F4E90")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EB0", Offset = "0x7F3AB0", VA = "0x1807F4EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NBIOIMKKKCC.OJMKNAIJFOI JOGAHPBGEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EDPIANJCCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x759B10", Offset = "0x758710", VA = "0x180759B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4474140", Offset = "0x4472D40", VA = "0x184474140")]
	[ACEHNGBCINE(FAJKELLEMII.ExitingPlayMode, 0)]
	private void IHEMCJFFBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4473750", Offset = "0x4472350", VA = "0x184473750")]
	public void DMABPKIBKAO(NBIOIMKKKCC.OJMKNAIJFOI CCLEHMICIIL, Transform OJKJBHANAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4473190", Offset = "0x4471D90", VA = "0x184473190")]
	public void AOHBMHOOEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x44740D0", Offset = "0x4472CD0", VA = "0x1844740D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4473150", Offset = "0x4471D50", VA = "0x184473150")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x44741B0", Offset = "0x4472DB0", VA = "0x1844741B0")]
	public MODJIOEOPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GECLECGLICO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CEAFBAIGMGM CDFJDAJPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ODIDOJGEBJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 CBOLKKOGPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GIHBHELJJOL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool OFIJMCJDOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BKNEFLFGICD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action PCLCNJHCPDG;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PIMICJLNABA
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIMICJLNABA DIGAPGKPEHP(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIMICJLNABA KDNFCJIPHMD(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIMICJLNABA MNOAJLEMOPC(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIMICJLNABA MKOOGCFEPIG(Action EMKOBNDJJHF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class BMAHFNNBKAD : PIMICJLNABA
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class OFPPAJGNMIM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public BMAHFNNBKAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
				public OFPPAJGNMIM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x4475700", Offset = "0x4474300", VA = "0x184475700")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x4475750", Offset = "0x4474350", VA = "0x184475750")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x44757A0", Offset = "0x44743A0", VA = "0x1844757A0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Func<JobHandle> EHEIFHKBNGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action KKEEDJEBDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private Action HGCDMMBLBDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private MPGGFKOPFME IHNHIEMBMFN;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action CKANNCEPBNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x6875A0", Offset = "0x6861A0", VA = "0x1806875A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public Action KCBNOODBPCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2C153A0", Offset = "0x2C13FA0", VA = "0x182C153A0", Slot = "4")]
			public PIMICJLNABA DIGAPGKPEHP(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A060", Offset = "0x2B18C60", VA = "0x182B1A060", Slot = "5")]
			public PIMICJLNABA KDNFCJIPHMD(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2C153C0", Offset = "0x2C13FC0", VA = "0x182C153C0", Slot = "6")]
			public PIMICJLNABA MNOAJLEMOPC(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1198DC0", Offset = "0x11979C0", VA = "0x181198DC0", Slot = "7")]
			public PIMICJLNABA MKOOGCFEPIG(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x66E830", Offset = "0x66D430", VA = "0x18066E830")]
			public BMAHFNNBKAD(Func<JobHandle> CMKOOAFNOBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4468650", Offset = "0x4467250", VA = "0x184468650")]
			public void BMAAMPIADME(Action BNBHNJDJMIF, Action JPMAAGFABKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4468880", Offset = "0x4467480", VA = "0x184468880")]
			public void JGCOEHFAOLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class DAEMOLJDEBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PIMICJLNABA jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public DAEMOLJDEBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x446D830", Offset = "0x446C430", VA = "0x18446D830")]
			internal bool <Remove>b__0(BMAHFNNBKAD a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HIOGEHAOHOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public BMAHFNNBKAD newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public HIOGEHAOHOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x44701F0", Offset = "0x446EDF0", VA = "0x1844701F0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<BMAHFNNBKAD> BCOJEHAHAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<BMAHFNNBKAD> HHGMMCAHEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private HGNPLDPHFIE APIKIPANCLP;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public EICCBOLJANE HDBLPMIJGGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x44719B0", Offset = "0x44705B0", VA = "0x1844719B0")]
		public PIMICJLNABA Add(Func<JobHandle> CMKOOAFNOBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4471C50", Offset = "0x4470850", VA = "0x184471C50")]
		public void Remove(PIMICJLNABA BHJBIIINCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4471AD0", Offset = "0x44706D0", VA = "0x184471AD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4471DD0", Offset = "0x44709D0", VA = "0x184471DD0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4471FA0", Offset = "0x4470BA0", VA = "0x184471FA0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4471AC0", Offset = "0x44706C0", VA = "0x184471AC0")]
		[CompilerGenerated]
		private void HMDLLEGKOFE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MPGGFKOPFME
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPGGFKOPFME DIGAPGKPEHP(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPGGFKOPFME GPOAGJFEFBG(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPGGFKOPFME MKOOGCFEPIG(Action EMKOBNDJJHF);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class FNJBCEJMFMG : MPGGFKOPFME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private JobHandle OHDEJACEHIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action KKEEDJEBDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action CKIKOMCFGPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private Action KCBNOODBPCO;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool GJGMEKODLFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x4470120", Offset = "0x446ED20", VA = "0x184470120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2B1A060", Offset = "0x2B18C60", VA = "0x182B1A060", Slot = "4")]
			public MPGGFKOPFME DIGAPGKPEHP(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2C153C0", Offset = "0x2C13FC0", VA = "0x182C153C0", Slot = "5")]
			public MPGGFKOPFME GPOAGJFEFBG(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x1198DC0", Offset = "0x11979C0", VA = "0x181198DC0", Slot = "6")]
			public MPGGFKOPFME MKOOGCFEPIG(Action EMKOBNDJJHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xC18FC0", Offset = "0xC17BC0", VA = "0x180C18FC0")]
			public FNJBCEJMFMG(JobHandle KOEEIGLBLFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x44700A0", Offset = "0x446ECA0", VA = "0x1844700A0")]
			public void DPCLEGEILBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x44700E0", Offset = "0x446ECE0", VA = "0x1844700E0")]
			public void JGCOEHFAOLL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<FNJBCEJMFMG> IFAJPIHDCPH;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4472420", Offset = "0x4471020", VA = "0x184472420")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4472060", Offset = "0x4470C60", VA = "0x184472060")]
		public MPGGFKOPFME Add(JobHandle KOEEIGLBLFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4472330", Offset = "0x4470F30", VA = "0x184472330")]
		public void Remove(MPGGFKOPFME BHJBIIINCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x44721D0", Offset = "0x4470DD0", VA = "0x1844721D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x44720F0", Offset = "0x4470CF0", VA = "0x1844720F0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4472530", Offset = "0x4471130", VA = "0x184472530")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4470250", Offset = "0x446EE50", VA = "0x184470250")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4470350", Offset = "0x446EF50", VA = "0x184470350")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
