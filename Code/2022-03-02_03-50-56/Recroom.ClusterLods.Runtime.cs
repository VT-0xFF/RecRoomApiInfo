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
				[Cpp2IlInjected.Address(RVA = "0x41765B0", Offset = "0x41755B0", VA = "0x1841765B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xB90810", Offset = "0xB8F810", VA = "0x180B90810")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4176570", Offset = "0x4175570", VA = "0x184176570")]
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
		[Cpp2IlInjected.Address(RVA = "0x4168E20", Offset = "0x4167E20", VA = "0x184168E20")]
		public LODSettings EFCEKDILHMP(NPKGMAFKBIH DANEEPACMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4168E30", Offset = "0x4167E30", VA = "0x184168E30")]
		public int INKJIFHKBBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4168E50", Offset = "0x4167E50", VA = "0x184168E50")]
		public int LACHPGOADKP(bool HFOHAJPFJOM, Vector3 CKMECEGPIID)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4168F50", Offset = "0x4167F50", VA = "0x184168F50")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PLLFEDKBGKH
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
public interface HHBAGMIJCJM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGOHFNMFBLA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AMBCPCKOPHD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OJAJJIOONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<GKPEFKIFFPI> JDEDLKJKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PLLFEDKBGKH AKGPCFJPEGE
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
	void UpdateClusterDistances(Vector3 BFHGNBMBLKN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(AKGCLELBDKN PGAOKOADAHN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GKPEFKIFFPI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int KHPHAEMHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LHEFANDLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MBMKJOPAMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BALJGLGEAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte NJIGMGIBNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FMFOGLJNCJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum IBKAHNFFFLJ
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
	private sealed class NKEJHOIGKEH : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FMFOGLJNCJF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public NKEJHOIGKEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4176BB0", Offset = "0x4175BB0", VA = "0x184176BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4176C70", Offset = "0x4175C70", VA = "0x184176C70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DOJCMCHJION : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JFAHKOGHLOL <>2__current;

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
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public DOJCMCHJION(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x416AE90", Offset = "0x4169E90", VA = "0x18416AE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x416AFE0", Offset = "0x4169FE0", VA = "0x18416AFE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KDENLDLDBII : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FMFOGLJNCJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<JFAHKOGHLOL> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public KDENLDLDBII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x41725E0", Offset = "0x41715E0", VA = "0x1841725E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4173060", Offset = "0x4172060", VA = "0x184173060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JGHNOLCHLEG : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public FMFOGLJNCJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public JGHNOLCHLEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x416F370", Offset = "0x416E370", VA = "0x18416F370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4170260", Offset = "0x416F260", VA = "0x184170260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int PAHGFLCKNCK = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer EOLPHDHGPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter KLCMFAFELBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject KMPBFOAGMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject FJIHFGNFNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public PBLGKNGALGB JGDPHBMPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<AKGCLELBDKN> AILLGLJEKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<AKGCLELBDKN> IEMKLIKAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<AKGCLELBDKN> JMOHHOLKKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int ICBEJCDKIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IBKAHNFFFLJ IBJGIMODDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<AMBCPCKOPHD>[] BGENHJPGADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<GKPEFKIFFPI>[] FAODDHJKMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private OBBEAJINNHP BAFBLMBPAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private OBBEAJINNHP JKIJPBIHDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private OBBEAJINNHP NLBLIJHJKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int JKCBPFGGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int FFNODLNPHCM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static FMFOGLJNCJF INMJIFILJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GOGEADGJPPP NOHHHMLKHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HKKDHGGODGF LLONFIGKGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour HNKGBKFNEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material MKPJEFHAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<HHBAGMIJCJM> JHLJDNMCKKH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig ELOIECNALPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 HDBCFBFIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x13B4CA0", Offset = "0x13B3CA0", VA = "0x1813B4CA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13B17D0", Offset = "0x13B07D0", VA = "0x1813B17D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private IBKAHNFFFLJ KJDDIMLFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x548660", Offset = "0x547660", VA = "0x180548660")]
		get
		{
			return default(IBKAHNFFFLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x416C6E0", Offset = "0x416B6E0", VA = "0x18416C6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static FMFOGLJNCJF BBILGMKNANF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x416D070", Offset = "0x416C070", VA = "0x18416D070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool EOEFCLBOMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x416CAA0", Offset = "0x416BAA0", VA = "0x18416CAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool ANMKEDJHMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x416B680", Offset = "0x416A680", VA = "0x18416B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IJEGLCGNFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x416C490", Offset = "0x416B490", VA = "0x18416C490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x416BA10", Offset = "0x416AA10", VA = "0x18416BA10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EPLAAHFDLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x416BB50", Offset = "0x416AB50", VA = "0x18416BB50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x416BAB0", Offset = "0x416AAB0", VA = "0x18416BAB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x416DB40", Offset = "0x416CB40", VA = "0x18416DB40")]
	public FMFOGLJNCJF(GOGEADGJPPP NOHHHMLKHPL, HKKDHGGODGF LLONFIGKGFP, ClusterLODConfig AIIAFPLDOJA, MonoBehaviour HNKGBKFNEOA, Material MKPJEFHAGOI, ClusterMeshRenderer EOLPHDHGPBL, MeshFilter KLCMFAFELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x416B750", Offset = "0x416A750", VA = "0x18416B750")]
	private void BBCMNKOLDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x416BC50", Offset = "0x416AC50", VA = "0x18416BC50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x416C400", Offset = "0x416B400", VA = "0x18416C400")]
	public static void GKFJMLAFBGJ(Vector3 HGJGFOKJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x416B830", Offset = "0x416A830", VA = "0x18416B830")]
	private void CFOJDCKEBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x416CC90", Offset = "0x416BC90", VA = "0x18416CC90")]
	private void KEIIGAHHGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x416B8D0", Offset = "0x416A8D0", VA = "0x18416B8D0")]
	private void CKDFHBDJKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x416BE00", Offset = "0x416AE00", VA = "0x18416BE00")]
	public void FNKCKDKNFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x416B6E0", Offset = "0x416A6E0", VA = "0x18416B6E0")]
	[IteratorStateMachine(typeof(NKEJHOIGKEH))]
	private IEnumerator<JFAHKOGHLOL> AMJBNAOMIEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x416CD90", Offset = "0x416BD90", VA = "0x18416CD90")]
	[IteratorStateMachine(typeof(DOJCMCHJION))]
	private IEnumerator<JFAHKOGHLOL> KGPFAMNAMPO(Func<bool> BPDAEPFBCIH, float ADMOHDKINDO, Func<string> PEBJLABGEHL, float CNHBFNBNNHH = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x416C670", Offset = "0x416B670", VA = "0x18416C670")]
	[IteratorStateMachine(typeof(KDENLDLDBII))]
	private IEnumerator<JFAHKOGHLOL> JCJBECHAMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x416C810", Offset = "0x416B810", VA = "0x18416C810")]
	public void JGBLPHCOOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x416C380", Offset = "0x416B380", VA = "0x18416C380")]
	public void GICHDBDHGBA(IEnumerable<AMBCPCKOPHD> CPIFMBMKNFC, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x416C0D0", Offset = "0x416B0D0", VA = "0x18416C0D0")]
	public void GCBAFLJKJEG(IEnumerable<AMBCPCKOPHD> CPIFMBMKNFC, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x416D390", Offset = "0x416C390", VA = "0x18416D390")]
	public List<ClusterMeshRenderer> NKIDJEFIHBD(List<AKGCLELBDKN> IEDBJAIOKOI, Transform COCNNHFBEEP, PLLFEDKBGKH DPIBPHELKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x416DB00", Offset = "0x416CB00", VA = "0x18416DB00")]
	public PLLFEDKBGKH PPNENANICJH(Vector3 BALJPEIHHFM)
	{
		return default(PLLFEDKBGKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x416BBF0", Offset = "0x416ABF0", VA = "0x18416BBF0")]
	public void DNFDFOLIGDH(HHBAGMIJCJM GGPHGKCCIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x416C530", Offset = "0x416B530", VA = "0x18416C530")]
	public bool HIHJMFIHHAO(HHBAGMIJCJM GGPHGKCCIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x416C5D0", Offset = "0x416B5D0", VA = "0x18416C5D0")]
	public void HODCIPACKFJ(AKGCLELBDKN CFDKPOABEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x416CA20", Offset = "0x416BA20", VA = "0x18416CA20")]
	public void JGLFFMHPKBO(GKPEFKIFFPI IAPOEGMMNBD, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x416BD80", Offset = "0x416AD80", VA = "0x18416BD80")]
	public void EGDCEHDNPLB(GKPEFKIFFPI IAPOEGMMNBD, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x416D260", Offset = "0x416C260", VA = "0x18416D260")]
	private void NDJDPACEDMA(Vector3 BFHGNBMBLKN, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x416CB20", Offset = "0x416BB20", VA = "0x18416CB20")]
	private void JPHPPCANEGL(Vector3 BFHGNBMBLKN, PLLFEDKBGKH DPIBPHELKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x416CE30", Offset = "0x416BE30", VA = "0x18416CE30")]
	[IteratorStateMachine(typeof(JGHNOLCHLEG))]
	private IEnumerator<JFAHKOGHLOL> KHNIJOBCOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x416D0F0", Offset = "0x416C0F0", VA = "0x18416D0F0")]
	private int LPFCINLBNPK(int IDCLMAKCIEP, int NAAGJFLLNKM, List<GKPEFKIFFPI> BJNFAJFDEKD, byte DANEEPACMAP, ref int JNEJKEMFKHL, float LMGILNJJJDH = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x416CEA0", Offset = "0x416BEA0", VA = "0x18416CEA0")]
	public void KOAAEEDJIKB(AKGCLELBDKN PGAOKOADAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x416C590", Offset = "0x416B590", VA = "0x18416C590")]
	public bool HLEDFBAHKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5107C0", Offset = "0x50F7C0", VA = "0x1805107C0")]
	public Material MJECOHHNIGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x416C630", Offset = "0x416B630", VA = "0x18416C630")]
	public int INKJIFHKBBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x416B7E0", Offset = "0x416A7E0", VA = "0x18416B7E0")]
	[CompilerGenerated]
	private bool BPJEPPJOJOK()
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
		[Cpp2IlInjected.Address(RVA = "0x50DA60", Offset = "0x50CA60", VA = "0x18050DA60")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OIOAEAGEGAA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> PDMAOIHOGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> PDCMPDJLPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> LACEMFCGBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> DLIADFAFADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> DEIHGAGBJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> OPHFJGDMFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> BMCKFHIFDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 PEGOENGOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float JIADEBBDJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> BAHKGGDMEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> POPGCAFMICM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4177640", Offset = "0x4176640", VA = "0x184177640")]
	public OIOAEAGEGAA(BAONMGEIEPA OOBCOIKNJHA, NativeList<float3> BMCKFHIFDEO, NativeMultiHashMap<int, int> BAHKGGDMEOJ, NativeArray<int> POPGCAFMICM, Vector3 PEGOENGOHHN, float JIADEBBDJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4177340", Offset = "0x4176340", VA = "0x184177340")]
	private int NCMAFECNIEE(float3 BFHGNBMBLKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41773A0", Offset = "0x41763A0", VA = "0x1841773A0")]
	private int OEACGNLMHCJ(int JBBLPPAEOAH, int MNGGKJHHPNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4176F50", Offset = "0x4175F50", VA = "0x184176F50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MIIAFPLLHKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> BAHKGGDMEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> POPGCAFMICM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int FEDIEILPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> FEKKKBPINAP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4176A10", Offset = "0x4175A10", VA = "0x184176A10")]
	public void OKLGCBAOCJF(int DKMOCDOBMHP, Allocator IOFDCBCNMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4176960", Offset = "0x4175960", VA = "0x184176960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public MIIAFPLLHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct GHLJMGCKDOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LOLJEOAMGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> LDFDCODKCJA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x416E150", Offset = "0x416D150", VA = "0x18416E150")]
	public GHLJMGCKDOM(MIIAFPLLHKD ODCDLGEIDMA, BAONMGEIEPA OOBCOIKNJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x416E0C0", Offset = "0x416D0C0", VA = "0x18416E0C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct JNOFJEOECON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> NCJPGCIPDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> BEFMIPFDMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> IKIFLMAFOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> PJKCKJMHAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> HHPEFIBHHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> FEKKKBPINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LOLJEOAMGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> OOOPBFHKGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> DDOBJPHCEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> IIKOBHCOCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> FBCPBNBGLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> NIKAFLBIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> BFKFOCHALHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float KLNKMMGBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float IHNKIMJMBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 KJBJMCEFLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float LIPBHLJGADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float KJFAFIBJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float LCLIGIOMHMF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4171890", Offset = "0x4170890", VA = "0x184171890")]
	public JNOFJEOECON(MIIAFPLLHKD OCCOJAJMCLM, BAONMGEIEPA OOBCOIKNJHA, BAONMGEIEPA JDECDCCICAK, float KJFAFIBJBMG, float LCLIGIOMHMF, Vector3 KJBJMCEFLPF, float LIPBHLJGADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x41702B0", Offset = "0x416F2B0", VA = "0x1841702B0")]
	private float3 APLIFCONLEL(int JBBLPPAEOAH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41715F0", Offset = "0x41705F0", VA = "0x1841715F0")]
	private void NCPLGONOMCE(int JBBLPPAEOAH, out float3 KHHPFJOBNJJ, out float3 CGALGGMCGJN, out float4 HAAHGJOBMCG, out float4 IOLLBCALLCO, out float2 IPOMOLEHHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41712A0", Offset = "0x41702A0", VA = "0x1841712A0")]
	private int IMHOJHCHAFE(int GPKLMFFMAEF, int JPGKEPODKCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4170CB0", Offset = "0x416FCB0", VA = "0x184170CB0")]
	private void FFMIPMPIGIO(int GPKLMFFMAEF, int JPGKEPODKCK, int NPCJAJNGGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4170EB0", Offset = "0x416FEB0", VA = "0x184170EB0")]
	private bool GGGNMELFNJE(int GPKLMFFMAEF, int JPGKEPODKCK, float DGOGEOPHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41717D0", Offset = "0x41707D0", VA = "0x1841717D0")]
	private bool OGPPJGOGJHJ(int GPKLMFFMAEF, int JPGKEPODKCK, int NPCJAJNGGCO, float DGOGEOPHMOP, bool LOOGHFFNGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4171040", Offset = "0x4170040", VA = "0x184171040")]
	private bool HLGCKAJELPK(int GPKLMFFMAEF, int JPGKEPODKCK, int NPCJAJNGGCO, float DGOGEOPHMOP, bool LOOGHFFNGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x41715D0", Offset = "0x41705D0", VA = "0x1841715D0")]
	private void JHAIFKLPNAA(int GPKLMFFMAEF, int JPGKEPODKCK, int NPCJAJNGGCO, out int MMHKLKEIOJJ, out int HKCDKPOMHDD, out int KNMJAPACKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4170350", Offset = "0x416F350", VA = "0x184170350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LIJHNAJBBNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BJLDEGACGFP : IDisposable, GKPEFKIFFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds KHOBCBHKHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<AKGCLELBDKN> IEDBJAIOKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 AMIHICAEBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 JGHFBBOCELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int JGONGGKJHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BAONMGEIEPA JHJJDBJHEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MIIAFPLLHKD OHOGHLDDFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform COCNNHFBEEP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BCHDBBECEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4168710", Offset = "0x4167710", VA = "0x184168710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh AJBCGHIBEDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh PPOAEDEEENE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x511470", Offset = "0x510470", VA = "0x180511470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5359E0", Offset = "0x5349E0", VA = "0x1805359E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MBMKJOPAMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x514160", Offset = "0x513160", VA = "0x180514160", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x514500", Offset = "0x513500", VA = "0x180514500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte NJIGMGIBNGG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5AF920", Offset = "0x5AE920", VA = "0x1805AF920")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x768130", Offset = "0x767130", VA = "0x180768130", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int KHPHAEMHJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x776C50", Offset = "0x775C50", VA = "0x180776C50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8D3EF0", Offset = "0x8D2EF0", VA = "0x1808D3EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int LHEFANDLPAB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x973F30", Offset = "0x972F30", VA = "0x180973F30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xFD0190", Offset = "0xFCF190", VA = "0x180FD0190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float BALJGLGEAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4168750", Offset = "0x4167750", VA = "0x184168750", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4168A90", Offset = "0x4167A90", VA = "0x184168A90")]
		public void HGJMOFLNKKC(NPKGMAFKBIH DANEEPACMAP, out int OINDILCCFOF, out int HEALEAJACBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4168360", Offset = "0x4167360", VA = "0x184168360")]
		public void AHGHKCKKHNH(NPKGMAFKBIH DANEEPACMAP, NIODFNAFOGH KPGGCKBEAFM, int APONGIMHPDN = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4168770", Offset = "0x4167770", VA = "0x184168770")]
		public void GHAPJPKEDKG(NativeList<LFPHMBOOPCI> AHBJOABHMEA, Transform GELDGOJCEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4168500", Offset = "0x4167500", VA = "0x184168500")]
		public void DHMEBIEKMPM(Mesh OOBCOIKNJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4168CC0", Offset = "0x4167CC0", VA = "0x184168CC0")]
		public void OGKCOHNNIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41685A0", Offset = "0x41675A0", VA = "0x1841685A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4168D60", Offset = "0x4167D60", VA = "0x184168D60")]
		public BJLDEGACGFP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds KHOBCBHKHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<BJLDEGACGFP> GIGOEEIACOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public OLJGFOKAFEJ KODCMKADLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer FFILKFELCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int JOPDNBGEKCL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh PHDDLJOOHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x511460", Offset = "0x510460", VA = "0x180511460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62AB60", Offset = "0x629B60", VA = "0x18062AB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool FIGACFBFJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69F4B0", Offset = "0x69E4B0", VA = "0x18069F4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69F5D0", Offset = "0x69E5D0", VA = "0x18069F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OJAJJIOONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4173700", Offset = "0x4172700", VA = "0x184173700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x41735A0", Offset = "0x41725A0", VA = "0x1841735A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x41747E0", Offset = "0x41737E0", VA = "0x1841747E0")]
	public int OBPHPHIFDAH(int NBMBBCODEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4174650", Offset = "0x4173650", VA = "0x184174650")]
	public void LFBNHGDPBPF(GPGNKGLJAIO GOCLNAGENOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4173750", Offset = "0x4172750", VA = "0x184173750")]
	public void ICLNKFBIHMO(Transform GELDGOJCEBO, bool PFBLFFJGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x41733F0", Offset = "0x41723F0", VA = "0x1841733F0")]
	public bool BEKKJIBKOFN(bool IANIICIBOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4173E60", Offset = "0x4172E60", VA = "0x184173E60")]
	public void JLEPCIFEIEP(Transform COCNNHFBEEP, bool PFBLFFJGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x41743F0", Offset = "0x41733F0", VA = "0x1841743F0")]
	public bool KOAAEEDJIKB(AKGCLELBDKN PGAOKOADAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4174810", Offset = "0x4173810", VA = "0x184174810")]
	public LIJHNAJBBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PBLGKNGALGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<LIJHNAJBBNB.BJLDEGACGFP> MICGDKENNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GLCALGFMPHF DLAGCGKDMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<LIJHNAJBBNB.BJLDEGACGFP> KNFCKFKEFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int LGCEPFMEHLC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x41789A0", Offset = "0x41779A0", VA = "0x1841789A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4178D90", Offset = "0x4177D90", VA = "0x184178D90")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4179110", Offset = "0x4178110", VA = "0x184179110")]
	public void ONGBLFOLDCH(LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI, Transform COCNNHFBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4178E70", Offset = "0x4177E70", VA = "0x184178E70")]
	public void KOAAEEDJIKB(LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4178C60", Offset = "0x4177C60", VA = "0x184178C60")]
	private LIJHNAJBBNB.BJLDEGACGFP FBEELDHDCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4179020", Offset = "0x4178020", VA = "0x184179020")]
	private bool KOGEGJIDKOF(LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4178E10", Offset = "0x4177E10", VA = "0x184178E10")]
	private void GOOPLKLLAKB(LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4178960", Offset = "0x4177960", VA = "0x184178960")]
	public bool BJHKNMJDGEG(LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4178A10", Offset = "0x4177A10", VA = "0x184178A10")]
	public bool EBPLJKLJNDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x41790B0", Offset = "0x41780B0", VA = "0x1841790B0")]
	private LIJHNAJBBNB.BJLDEGACGFP NIHKGFBLMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x41791C0", Offset = "0x41781C0", VA = "0x1841791C0")]
	public PBLGKNGALGB()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x50DA60", Offset = "0x50CA60", VA = "0x18050DA60")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DINGODPLMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int LKBFDFPLALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int GHPEJABFJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float BFPMNICECPJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<LIJHNAJBBNB> HKEMFAHCAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x416A850", Offset = "0x4169850", VA = "0x18416A850")]
	public DINGODPLMHI(int LKBFDFPLALG, int GHPEJABFJFC, float NFKHGDFNLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x416A530", Offset = "0x4169530", VA = "0x18416A530")]
	public void KBGMNJMPJMG(NKPFMMKFFFA JKGNBCMMEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x416A7B0", Offset = "0x41697B0", VA = "0x18416A7B0")]
	private int NCJEFGLPEBH(GPGNKGLJAIO EBOMLHHEIIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x416A300", Offset = "0x4169300", VA = "0x18416A300")]
	private void KBGMNJMPJMG(GPGNKGLJAIO EBOMLHHEIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x416A5D0", Offset = "0x41695D0", VA = "0x18416A5D0")]
	private void NBKNMPCKPOA(GPGNKGLJAIO EBOMLHHEIIO, LIJHNAJBBNB DJEDFBPKONJ)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, AMBCPCKOPHD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NOBBOFHLAPK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
			[DebuggerHidden]
			public NOBBOFHLAPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4176D70", Offset = "0x4175D70", VA = "0x184176D70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4176F00", Offset = "0x4175F00", VA = "0x184176F00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4176E60", Offset = "0x4175E60", VA = "0x184176E60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4176E60", Offset = "0x4175E60", VA = "0x184176E60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int OJAJJIOONNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x416A290", Offset = "0x4169290", VA = "0x18416A290", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<GKPEFKIFFPI> JDEDLKJKLAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x416A270", Offset = "0x4169270", VA = "0x18416A270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> GIGOEEIACOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LIJHNAJBBNB PHDDLJOOHBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public PLLFEDKBGKH AKGPCFJPEGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x535D50", Offset = "0x534D50", VA = "0x180535D50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(PLLFEDKBGKH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x69F600", Offset = "0x69E600", VA = "0x18069F600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool POOEDJPGFDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x416A280", Offset = "0x4169280", VA = "0x18416A280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4168FB0", Offset = "0x4167FB0", VA = "0x184168FB0")]
		public static ClusterMeshRenderer Create(LIJHNAJBBNB OOBCOIKNJHA, ClusterMeshRenderer EOLPHDHGPBL, MeshFilter KLCMFAFELBJ, Transform COCNNHFBEEP, PLLFEDKBGKH DPIBPHELKEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41690C0", Offset = "0x41680C0", VA = "0x1841690C0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4169820", Offset = "0x4168820", VA = "0x184169820", Slot = "10")]
		public bool TryRemoveClusterLODComponent(AKGCLELBDKN PGAOKOADAHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x41695F0", Offset = "0x41685F0", VA = "0x1841695F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4169320", Offset = "0x4168320", VA = "0x184169320")]
		public void Init(LIJHNAJBBNB OOBCOIKNJHA, MeshFilter KLCMFAFELBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4169120", Offset = "0x4168120", VA = "0x184169120")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4169950", Offset = "0x4168950", VA = "0x184169950", Slot = "8")]
		public void UpdateClusterDistances(Vector3 BFHGNBMBLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4169B90", Offset = "0x4168B90", VA = "0x184169B90", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x41692B0", Offset = "0x41682B0", VA = "0x1841692B0")]
		[IteratorStateMachine(typeof(NOBBOFHLAPK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4169670", Offset = "0x4168670", VA = "0x184169670")]
		public void SetupTagAndLayer(string FDNJIFJDAFA, int DPIBPHELKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4169650", Offset = "0x4168650", VA = "0x184169650")]
		public bool Remove(AKGCLELBDKN PGAOKOADAHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x50DA60", Offset = "0x50CA60", VA = "0x18050DA60")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JAGBPMJNNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int GNDNJJKNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int JGPOOACBJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HEALEAJACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OINDILCCFOF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x416F350", Offset = "0x416E350", VA = "0x18416F350")]
	public JAGBPMJNNBN(int JGPOOACBJKE, int HEALEAJACBB, int GNDNJJKNMPA, int OINDILCCFOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OLJGFOKAFEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> PDMAOIHOGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> FEKKKBPINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> OPHFJGDMFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<JAGBPMJNNBN> DEPDOAFOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> NPLBIOGCPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> MOJAMKDIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> KMBGCKAGOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle HEEJLMHKFJN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HANLLFBPLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA500", Offset = "0x7E9500", VA = "0x1807EA500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA520", Offset = "0x7E9520", VA = "0x1807EA520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4177BE0", Offset = "0x4176BE0", VA = "0x184177BE0")]
	public void LBMPAGBAIMI(BAONMGEIEPA HOCFBCIJOCP, NativeList<JAGBPMJNNBN> DEPDOAFOHFD, float GBICONMPHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4177990", Offset = "0x4176990", VA = "0x184177990")]
	public void KMECHGCIHHH(Transform COCNNHFBEEP, bool PFBLFFJGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4177700", Offset = "0x4176700", VA = "0x184177700")]
	public void BEKKJIBKOFN(LIJHNAJBBNB FFILKFELCGK, bool IANIICIBOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4177890", Offset = "0x4176890", VA = "0x184177890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4177960", Offset = "0x4176960", VA = "0x184177960")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public OLJGFOKAFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct EAFANBHDAHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> PDMAOIHOGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> FEKKKBPINAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<JAGBPMJNNBN> IPNLLBGPPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> NPLBIOGCPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 KJBJMCEFLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> MOJAMKDIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> KMBGCKAGOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool PFBLFFJGNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float EJJEBPJBNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float ACKPGAELGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float MNAKBNCINKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> OPHFJGDMFOI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x416B4D0", Offset = "0x416A4D0", VA = "0x18416B4D0")]
	public EAFANBHDAHE(OLJGFOKAFEJ HAJOCPJMEDL, Vector3 KJBJMCEFLPF, bool PFBLFFJGNPF, float EJJEBPJBNOL, float ACKPGAELGLD, float MNAKBNCINKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x416B030", Offset = "0x416A030", VA = "0x18416B030", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface AKGCLELBDKN : GENINMMIIEN
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds CFKCMIHPDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LFPHMBOOPCI NECDPGPHHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GPGNKGLJAIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<AKGCLELBDKN> IEDBJAIOKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public GPGNKGLJAIO OACJHOOKBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public GPGNKGLJAIO MMCMOEIHBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GPGNKGLJAIO NLLBBDFCCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int OINDILCCFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds KHOBCBHKHNC;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x416F270", Offset = "0x416E270", VA = "0x18416F270")]
	public GPGNKGLJAIO(List<AKGCLELBDKN> IEDBJAIOKOI, [Optional] GPGNKGLJAIO OACJHOOKBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NKPFMMKFFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<GPGNKGLJAIO> HNJKIAOKPLK;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GPGNKGLJAIO AALDJPJFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4176CC0", Offset = "0x4175CC0", VA = "0x184176CC0")]
	public NKPFMMKFFFA(GPGNKGLJAIO COCNNHFBEEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LMPDAPHAHEK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct AHLBDNOICLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int NLDNIKPDJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int JGAMDMCLCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int MLCENKEKPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int PKNEFOKAPFI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OFCNGLONONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int IMJONDEAJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float EAHLPHDJLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<AKGCLELBDKN> IEDBJAIOKOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum OIAPNMPEGKF
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
	private AHLBDNOICLK CPGBGFLNDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int IBEDMDMBANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int LKBFDFPLALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GHPEJABFJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float NFKHGDFNLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float IGNNBKAEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<GPGNKGLJAIO> NFNIOAIHMDI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NKPFMMKFFFA DJKJKBEHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4176480", Offset = "0x4175480", VA = "0x184176480")]
	public LMPDAPHAHEK(int LKBFDFPLALG, int GHPEJABFJFC, float NFKHGDFNLBG, int IBEDMDMBANP, float IGNNBKAEBJG = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x41755B0", Offset = "0x41745B0", VA = "0x1841755B0")]
	public void DPHEJCHBANN(List<AKGCLELBDKN> IEDBJAIOKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4175770", Offset = "0x4174770", VA = "0x184175770")]
	public bool FAFEBBCPDBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4174950", Offset = "0x4173950", VA = "0x184174950")]
	private float ADAAJJKFMJF(Vector3 LMLCFNGPGDH, Vector3 OECPNENFJIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41748B0", Offset = "0x41738B0", VA = "0x1841748B0")]
	private float ADAAJJKFMJF(Vector3 ACFAACNMEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x41757E0", Offset = "0x41747E0", VA = "0x1841757E0")]
	private bool IGNGJHDLLDD(GPGNKGLJAIO EMPKAHFFDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4174A60", Offset = "0x4173A60", VA = "0x184174A60")]
	private OFCNGLONONB DOFGKNEJPBN(List<AKGCLELBDKN> BIICIHNJPNC, OIAPNMPEGKF CMAMLANCPEO)
	{
		return default(OFCNGLONONB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x41760F0", Offset = "0x41750F0", VA = "0x1841760F0")]
	private void INCLGNMLEHJ(List<AKGCLELBDKN> IEDBJAIOKOI, Vector3[] FDDNEPAKODI, Vector3[] FNANLECIJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KPPLEKLFJGA
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x41730B0", Offset = "0x41720B0", VA = "0x1841730B0")]
	public static Bounds EIANLLPOODE(List<AKGCLELBDKN> IEDBJAIOKOI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4173260", Offset = "0x4172260", VA = "0x184173260")]
	public static int FBALPPEHPKM(List<AKGCLELBDKN> IEDBJAIOKOI, NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GLCALGFMPHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private BAONMGEIEPA IPDJFCDELOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BAONMGEIEPA OOBFCIFPAMO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static BAONMGEIEPA EAJBONOJIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private KANLMDOGECJ EHALBBJLFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NIODFNAFOGH KPGGCKBEAFM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle HEEJLMHKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C1B70", Offset = "0x5C0B70", VA = "0x1805C1B70")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x957AD0", Offset = "0x956AD0", VA = "0x180957AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LIJHNAJBBNB.BJLDEGACGFP EMPKAHFFDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool OAJEEIEHIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CE0", Offset = "0x8B0CE0", VA = "0x1808B1CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x416E180", Offset = "0x416D180", VA = "0x18416E180")]
	[IDFKLDKOEJK(NEKAKBMJKEC.ExitingPlayMode, 0)]
	private void CLFEPGDOKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x416E860", Offset = "0x416D860", VA = "0x18416E860")]
	public void LBMPAGBAIMI(LIJHNAJBBNB.BJLDEGACGFP IPNLLBGPPGK, Transform EPINJPFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x416E260", Offset = "0x416D260", VA = "0x18416E260")]
	public void EDBDIEJDOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x416E1F0", Offset = "0x416D1F0", VA = "0x18416E1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x416E820", Offset = "0x416D820", VA = "0x18416E820")]
	public void FLOPBJIDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x416F1E0", Offset = "0x416E1E0", VA = "0x18416F1E0")]
	public GLCALGFMPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HOBLODJMLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FMFOGLJNCJF BNHGCPNHLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HKKDHGGODGF
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 HCHFDEDGDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GOGEADGJPPP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ECCKMFKOACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FKLPOOMPCAM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action AHJDLMLOMAN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NEEHHAFFBOI
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEEHHAFFBOI OMDPMDLPMGB(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NEEHHAFFBOI ADCBDDKFBGN(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NEEHHAFFBOI ELMJKGBDDAF(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NEEHHAFFBOI KMKCEOGPIFH(Action EDHAOFHJENI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class MAMIJPFDLMP : NEEHHAFFBOI
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class EMCOGHDOHCG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public MAMIJPFDLMP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public EMCOGHDOHCG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x416B5A0", Offset = "0x416A5A0", VA = "0x18416B5A0")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x416B5F0", Offset = "0x416A5F0", VA = "0x18416B5F0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x416B640", Offset = "0x416A640", VA = "0x18416B640")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> FADKMLNNCKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action FFEMOOJGNPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action DGEOOKEAPJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private OBLPDBBCKDF PCNDPCKCFLI;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action PHKKOGBHKGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x511460", Offset = "0x510460", VA = "0x180511460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x62AB60", Offset = "0x629B60", VA = "0x18062AB60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action PKNAPAOHFBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xC176A0", Offset = "0xC166A0", VA = "0x180C176A0", Slot = "4")]
			public NEEHHAFFBOI OMDPMDLPMGB(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2BB39F0", Offset = "0x2BB29F0", VA = "0x182BB39F0", Slot = "5")]
			public NEEHHAFFBOI ADCBDDKFBGN(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2BB3A10", Offset = "0x2BB2A10", VA = "0x182BB3A10", Slot = "6")]
			public NEEHHAFFBOI ELMJKGBDDAF(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC17680", Offset = "0xC16680", VA = "0x180C17680", Slot = "7")]
			public NEEHHAFFBOI KMKCEOGPIFH(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6A2810", Offset = "0x6A1810", VA = "0x1806A2810")]
			public MAMIJPFDLMP(Func<JobHandle> IOLIHBIACFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4176730", Offset = "0x4175730", VA = "0x184176730")]
			public void PDHGCNGFKGG(Action POJFIKPNHHB, Action KGKMMEJLDHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x41765D0", Offset = "0x41755D0", VA = "0x1841765D0")]
			public void KOAAEEDJIKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class DDCBMONFNLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public NEEHHAFFBOI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public DDCBMONFNLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x416A2F0", Offset = "0x41692F0", VA = "0x18416A2F0")]
			internal bool <Remove>b__0(MAMIJPFDLMP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HOLDPLPFKIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public MAMIJPFDLMP newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public HOLDPLPFKIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x416F2F0", Offset = "0x416E2F0", VA = "0x18416F2F0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<MAMIJPFDLMP> NNIOIKKABBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<MAMIJPFDLMP> DHIGHDEIKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private OBBEAJINNHP AFAGHFGAELC;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x41719D0", Offset = "0x41709D0", VA = "0x1841719D0")]
		public NEEHHAFFBOI Add(Func<JobHandle> IOLIHBIACFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4171C70", Offset = "0x4170C70", VA = "0x184171C70")]
		public void Remove(NEEHHAFFBOI HEEJLMHKFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4171AF0", Offset = "0x4170AF0", VA = "0x184171AF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4171DF0", Offset = "0x4170DF0", VA = "0x184171DF0")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4171FC0", Offset = "0x4170FC0", VA = "0x184171FC0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4171AE0", Offset = "0x4170AE0", VA = "0x184171AE0")]
		[CompilerGenerated]
		private void BHALKDDAMAO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OBLPDBBCKDF
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBLPDBBCKDF OMDPMDLPMGB(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBLPDBBCKDF KCPBFGMOGHB(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBLPDBBCKDF KMKCEOGPIFH(Action EDHAOFHJENI);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LNLNNKBJHMA : OBLPDBBCKDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle GKOICCFENDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action FFEMOOJGNPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action DELPGAKOOHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action PKNAPAOHFBD;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool IJMNMBHIIMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x4176520", Offset = "0x4175520", VA = "0x184176520")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB39F0", Offset = "0x2BB29F0", VA = "0x182BB39F0", Slot = "4")]
			public OBLPDBBCKDF OMDPMDLPMGB(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB3A10", Offset = "0x2BB2A10", VA = "0x182BB3A10", Slot = "5")]
			public OBLPDBBCKDF KCPBFGMOGHB(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC17680", Offset = "0xC16680", VA = "0x180C17680", Slot = "6")]
			public OBLPDBBCKDF KMKCEOGPIFH(Action EDHAOFHJENI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x11172C0", Offset = "0x11162C0", VA = "0x1811172C0")]
			public LNLNNKBJHMA(JobHandle KDPCOHBLAEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x41764E0", Offset = "0x41754E0", VA = "0x1841764E0")]
			public void FAMKCJJIIKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4176530", Offset = "0x4175530", VA = "0x184176530")]
			public void KOAAEEDJIKB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<LNLNNKBJHMA> FNGGLJMPOME;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4172440", Offset = "0x4171440", VA = "0x184172440")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4172080", Offset = "0x4171080", VA = "0x184172080")]
		public OBLPDBBCKDF Add(JobHandle KDPCOHBLAEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4172350", Offset = "0x4171350", VA = "0x184172350")]
		public void Remove(OBLPDBBCKDF HEEJLMHKFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x41721F0", Offset = "0x41711F0", VA = "0x1841721F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4172110", Offset = "0x4171110", VA = "0x184172110")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4172550", Offset = "0x4171550", VA = "0x184172550")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x416ABD0", Offset = "0x4169BD0", VA = "0x18416ABD0")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x416A8A0", Offset = "0x41698A0", VA = "0x18416A8A0")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
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
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
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
