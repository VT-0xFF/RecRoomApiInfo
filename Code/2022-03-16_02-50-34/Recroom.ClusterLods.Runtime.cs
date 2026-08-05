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
				[Cpp2IlInjected.Address(RVA = "0x4168D90", Offset = "0x4167B90", VA = "0x184168D90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x11BE240", Offset = "0x11BD040", VA = "0x1811BE240")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4168D50", Offset = "0x4167B50", VA = "0x184168D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x415D230", Offset = "0x415C030", VA = "0x18415D230")]
		public LODSettings OHAICCKDDFO(NAMEMILJEON KDJHNALPMDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x415D240", Offset = "0x415C040", VA = "0x18415D240")]
		public int PKOCGNMIBCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x415D130", Offset = "0x415BF30", VA = "0x18415D130")]
		public int GIMJGEPJHJD(bool PMGKJABBLFL, Vector3 GMKLLJMDEBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x415D260", Offset = "0x415C060", VA = "0x18415D260")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ABBDGBMMMGF
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
public interface CLDOBCIEEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJJHHDDMEAP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LBPFPPMPNKO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JAKBFPAJFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<PANDFKHDBNL> HKGIKPGLPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ABBDGBMMMGF DNGFKKONFNI
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
	void UpdateClusterDistances(Vector3 PLEAHKOHNBF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(JNAFBFAIOCJ LFKGOLJOIDI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PANDFKHDBNL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int CCDMHKODFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int AOALIBCBCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float EIFCNEDFOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MJOJCJFJMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte CHNBPMDIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DMNFPOPEOLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum POPFJKFPFMA
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
	private sealed class HGCMGDODJFJ : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DMNFPOPEOLM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public HGCMGDODJFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41622A0", Offset = "0x41610A0", VA = "0x1841622A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4162360", Offset = "0x4161160", VA = "0x184162360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LCONEAKGIAC : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private DOOLAEBGDFI <>2__current;

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
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public LCONEAKGIAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4168BB0", Offset = "0x41679B0", VA = "0x184168BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4168D00", Offset = "0x4167B00", VA = "0x184168D00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AIFBPHJMHHC : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DMNFPOPEOLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<DOOLAEBGDFI> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public AIFBPHJMHHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x415B550", Offset = "0x415A350", VA = "0x18415B550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x415BFD0", Offset = "0x415ADD0", VA = "0x18415BFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OODOJNHDHJP : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DMNFPOPEOLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public OODOJNHDHJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4169F10", Offset = "0x4168D10", VA = "0x184169F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x416AE00", Offset = "0x4169C00", VA = "0x18416AE00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int IGAGMBNFEGD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer HLOAIOHJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter OPODDGNFHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject LCNJMLJJDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject EFDHEEMLNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public BEFOAFIDDPO GJFFNCKAKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<JNAFBFAIOCJ> LIICNJBLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<JNAFBFAIOCJ> MKAHONFBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<JNAFBFAIOCJ> LJJBECLOHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int BAHFKFFIEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private POPFJKFPFMA EOBDEHMNDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<LBPFPPMPNKO>[] OOAELGIGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<PANDFKHDBNL>[] AMHJBJAEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private HOAOHLFJCKG HAAJNJFLLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private HOAOHLFJCKG KAFNPMCOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HOAOHLFJCKG NKBPMKEGDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int LIDFJBAOKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int MMHDHGDKAPK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static DMNFPOPEOLM MLECHDMLCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DELJKMIKDIG KENKFODFMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DKIJECOGBEC EPGDPPIHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour BCOHAIGAOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material HFAFNLKIEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<CLDOBCIEEBM> KACAACGLEHF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig GJOLDGEBNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 MNCMEOPEOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xE074C0", Offset = "0xE062C0", VA = "0x180E074C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE029E0", VA = "0x180E03BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private POPFJKFPFMA BKPLLPPLDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52FCD0", Offset = "0x52EAD0", VA = "0x18052FCD0")]
		get
		{
			return default(POPFJKFPFMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x415F9F0", Offset = "0x415E7F0", VA = "0x18415F9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DMNFPOPEOLM GDKAJIKDHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x415EB60", Offset = "0x415D960", VA = "0x18415EB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool MEPAHILFLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4160870", Offset = "0x415F670", VA = "0x184160870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KDPNHPOLGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x415F990", Offset = "0x415E790", VA = "0x18415F990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NBKAJLGACCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4160060", Offset = "0x415EE60", VA = "0x184160060")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x415FCF0", Offset = "0x415EAF0", VA = "0x18415FCF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MOEAAFALCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41608F0", Offset = "0x415F6F0", VA = "0x1841608F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x415E950", Offset = "0x415D750", VA = "0x18415E950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4160AC0", Offset = "0x415F8C0", VA = "0x184160AC0")]
	public DMNFPOPEOLM(DELJKMIKDIG KENKFODFMHB, DKIJECOGBEC EPGDPPIHIPB, ClusterLODConfig MFJEKLPLCKO, MonoBehaviour BCOHAIGAOIG, Material HFAFNLKIEBE, ClusterMeshRenderer HLOAIOHJAGE, MeshFilter OPODDGNFHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x415F290", Offset = "0x415E090", VA = "0x18415F290")]
	private void EACODEEHNNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x415F160", Offset = "0x415DF60", VA = "0x18415F160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x415F8C0", Offset = "0x415E6C0", VA = "0x18415F8C0")]
	public static void ICDHHJOAEPK(Vector3 LJJOGCEJJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x415FB80", Offset = "0x415E980", VA = "0x18415FB80")]
	private void JOJLFGBOOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x415F4F0", Offset = "0x415E2F0", VA = "0x18415F4F0")]
	private void GADLNDPKEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x415F650", Offset = "0x415E450", VA = "0x18415F650")]
	private void HGDAKOENDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x415EE90", Offset = "0x415DC90", VA = "0x18415EE90")]
	public void DMNCABONCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x415FC20", Offset = "0x415EA20", VA = "0x18415FC20")]
	[IteratorStateMachine(typeof(HGCMGDODJFJ))]
	private IEnumerator<DOOLAEBGDFI> KIJAOGDHHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x415E9F0", Offset = "0x415D7F0", VA = "0x18415E9F0")]
	[IteratorStateMachine(typeof(LCONEAKGIAC))]
	private IEnumerator<DOOLAEBGDFI> BKDGALJPFGB(Func<bool> PHNEOBLDPHG, float DMCOFMLLNKP, Func<string> PLIELHIBFAF, float FHCBCPPJCME = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x415E600", Offset = "0x415D400", VA = "0x18415E600")]
	[IteratorStateMachine(typeof(AIFBPHJMHHC))]
	private IEnumerator<DOOLAEBGDFI> ABLLOHKNLHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x415FE50", Offset = "0x415EC50", VA = "0x18415FE50")]
	public void MGKDNOIBFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4160A40", Offset = "0x415F840", VA = "0x184160A40")]
	public void PNNHINMNIJG(IEnumerable<LBPFPPMPNKO> DNBNEBBGFEC, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x415EBE0", Offset = "0x415D9E0", VA = "0x18415EBE0")]
	public void DCNIEHPKLKC(IEnumerable<LBPFPPMPNKO> DNBNEBBGFEC, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4160100", Offset = "0x415EF00", VA = "0x184160100")]
	public List<ClusterMeshRenderer> MNHPMLLNGIE(List<JNAFBFAIOCJ> EOIIJJEEOHI, Transform FBADHAKMLIA, ABBDGBMMMGF NJJGPLFCFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x415F950", Offset = "0x415E750", VA = "0x18415F950")]
	public ABBDGBMMMGF IGBOBMDIJNC(Vector3 DLBJDOEBKHA)
	{
		return default(ABBDGBMMMGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x415FB20", Offset = "0x415E920", VA = "0x18415FB20")]
	public void JLKMHNOFOLC(CLDOBCIEEBM ABJDBGOIGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x415FC90", Offset = "0x415EA90", VA = "0x18415FC90")]
	public bool KPKOBDDLKHB(CLDOBCIEEBM ABJDBGOIGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x415F5F0", Offset = "0x415E3F0", VA = "0x18415F5F0")]
	public void HEKOLMBFFMK(JNAFBFAIOCJ EPCPLIILEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x415FDD0", Offset = "0x415EBD0", VA = "0x18415FDD0")]
	public void MBCEJGPMFMI(PANDFKHDBNL LIGOHHDCFFK, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x415EAE0", Offset = "0x415D8E0", VA = "0x18415EAE0")]
	public void CEACJOGIBLI(PANDFKHDBNL LIGOHHDCFFK, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x415F790", Offset = "0x415E590", VA = "0x18415F790")]
	private void HPGLBFGAHFA(Vector3 PLEAHKOHNBF, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x415E670", Offset = "0x415D470", VA = "0x18415E670")]
	private void ACLHEEOGINF(Vector3 PLEAHKOHNBF, ABBDGBMMMGF NJJGPLFCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4160990", Offset = "0x415F790", VA = "0x184160990")]
	[IteratorStateMachine(typeof(OODOJNHDHJP))]
	private IEnumerator<DOOLAEBGDFI> PKEGHICGKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x415E7E0", Offset = "0x415D5E0", VA = "0x18415E7E0")]
	private int AGHMICMIGIB(int CKPFCCCIOFE, int JOOPIOBGAMC, List<PANDFKHDBNL> GDKMHJMCDKH, byte KDJHNALPMDH, ref int BOPADGIDPIP, float OCCBNKLHELI = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x415F320", Offset = "0x415E120", VA = "0x18415F320")]
	public void FKDIFICKHIH(JNAFBFAIOCJ LFKGOLJOIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x415FD90", Offset = "0x415EB90", VA = "0x18415FD90")]
	public bool MAIAFJKHJHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A58F0", Offset = "0x5A46F0", VA = "0x1805A58F0")]
	public Material MJCGPMCJDGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4160A00", Offset = "0x415F800", VA = "0x184160A00")]
	public int PKOCGNMIBCC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x415EA90", Offset = "0x415D890", VA = "0x18415EA90")]
	[CompilerGenerated]
	private bool BMCBLCIBJAM()
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
		[Cpp2IlInjected.Address(RVA = "0xD85B10", Offset = "0xD84910", VA = "0x180D85B10")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KHHPMJGEOOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> JCNDFKBJKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> FADHFNHMAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> HCIINPAEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> NIGNGPMKGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> JAFEECMCNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> NIFICMKGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> OKOPBJHOEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 FMDFALAEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float PNJFCDKEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> CMEGGKDJLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> PNGFELOBIJJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41662E0", Offset = "0x41650E0", VA = "0x1841662E0")]
	public KHHPMJGEOOL(DEBDNLBMIJH JJINPOBHIAK, NativeList<float3> OKOPBJHOEIB, NativeMultiHashMap<int, int> CMEGGKDJLHF, NativeArray<int> PNGFELOBIJJ, Vector3 FMDFALAEAGN, float PNJFCDKEPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4165FE0", Offset = "0x4164DE0", VA = "0x184165FE0")]
	private int MFLJHEGGKDA(float3 PLEAHKOHNBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4166040", Offset = "0x4164E40", VA = "0x184166040")]
	private int NLEFCKEJKIL(int CKCPKBAGJMN, int LHOJNLGGKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4165BF0", Offset = "0x41649F0", VA = "0x184165BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BJODNAGIABG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> CMEGGKDJLHF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> PNGFELOBIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int ENICADNFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> JIBNIDOPLKO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x415CE00", Offset = "0x415BC00", VA = "0x18415CE00")]
	public void PCAMJIKKLAP(int HIHKGALDNFO, Allocator JPPBKHJDJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x415CD50", Offset = "0x415BB50", VA = "0x18415CD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BJODNAGIABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IEBIMMEDNAM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> DINBCGOFKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> DFPAGPHKDAA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4164130", Offset = "0x4162F30", VA = "0x184164130")]
	public IEBIMMEDNAM(BJODNAGIABG BPCPKHAJBLP, DEBDNLBMIJH JJINPOBHIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41640A0", Offset = "0x4162EA0", VA = "0x1841640A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct KLFBBDIFMFI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> ONPEFFNLIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> PBNJGLKDFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> EMGNFHADPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> GACIJMNLPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> EOKEJCDPJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> JIBNIDOPLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> DINBCGOFKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> GAEKNODBIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> CDPAIPNHEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> GBCDLPGFBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> MLBOOIOLDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> IGLEAKLHGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> LKFLLFALKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float BEGFLPABKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float DLCHCFIMHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 DBJODHEDEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float BGOJNNPCADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float IBFLFJNHMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float JBDKFLPNGEJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4168A70", Offset = "0x4167870", VA = "0x184168A70")]
	public KLFBBDIFMFI(BJODNAGIABG MNJAEBGFBJB, DEBDNLBMIJH JJINPOBHIAK, DEBDNLBMIJH ONCMKNKDADN, float IBFLFJNHMHM, float JBDKFLPNGEJ, Vector3 DBJODHEDEPJ, float BGOJNNPCADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x41685E0", Offset = "0x41673E0", VA = "0x1841685E0")]
	private float3 LCCDCJGKJHF(int CKCPKBAGJMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4168050", Offset = "0x4166E50", VA = "0x184168050")]
	private void ICDBDCCDOBO(int CKCPKBAGJMN, out float3 PJFIAKCAJHO, out float3 GNIIFHNKEEI, out float4 IKOCPHPLPEO, out float4 DJKJGJLFDKN, out float2 MCAGGNOOOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4168680", Offset = "0x4167480", VA = "0x184168680")]
	private int MOOMGHCBBDK(int IJNIPCOOPFK, int PKGPPPMLLMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4168230", Offset = "0x4167030", VA = "0x184168230")]
	private void KGLKHAEJCEF(int IJNIPCOOPFK, int PKGPPPMLLMC, int OAKHECLOGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4168450", Offset = "0x4167250", VA = "0x184168450")]
	private bool LACLFLHLOJP(int IJNIPCOOPFK, int PKGPPPMLLMC, float LIPMBNBFCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41689B0", Offset = "0x41677B0", VA = "0x1841689B0")]
	private bool OKMNCGDELMG(int IJNIPCOOPFK, int PKGPPPMLLMC, int OAKHECLOGDD, float LIPMBNBFCBH, bool FLHDGNHKPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4167DF0", Offset = "0x4166BF0", VA = "0x184167DF0")]
	private bool GIHPPDLJKNB(int IJNIPCOOPFK, int PKGPPPMLLMC, int OAKHECLOGDD, float LIPMBNBFCBH, bool FLHDGNHKPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4168430", Offset = "0x4167230", VA = "0x184168430")]
	private void KMGFNBOKALB(int IJNIPCOOPFK, int PKGPPPMLLMC, int OAKHECLOGDD, out int DDEOKCCBCJK, out int NEHHJFPGJGE, out int FBDLJKPDKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4167490", Offset = "0x4166290", VA = "0x184167490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PJLCHNNOJBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JDMLIPFLLAB : IDisposable, PANDFKHDBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds NNLDFIOPKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<JNAFBFAIOCJ> EOIIJJEEOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 LBOPKCHKHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 EHOKIHCICHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int ICOKHFFGGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DEBDNLBMIJH EDALIBPIGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BJODNAGIABG MJNKHIGMJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform FBADHAKMLIA;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int GDPJHOGPHPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41646D0", Offset = "0x41634D0", VA = "0x1841646D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh IBMBPAMLAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh JIKAEPMMCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x51D010", Offset = "0x51BE10", VA = "0x18051D010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x51D020", Offset = "0x51BE20", VA = "0x18051D020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EIFCNEDFOFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE6BC60", Offset = "0xE6AA60", VA = "0x180E6BC60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1D09EA0", Offset = "0x1D08CA0", VA = "0x181D09EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte CHNBPMDIBGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x66C530", Offset = "0x66B330", VA = "0x18066C530")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x66C6C0", Offset = "0x66B4C0", VA = "0x18066C6C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CCDMHKODFFB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6D3DC0", Offset = "0x6D2BC0", VA = "0x1806D3DC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D3450", Offset = "0x6D2250", VA = "0x1806D3450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AOALIBCBCEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xACA040", Offset = "0xAC8E40", VA = "0x180ACA040", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD47000", Offset = "0xD45E00", VA = "0x180D47000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float MJOJCJFJMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4164610", Offset = "0x4163410", VA = "0x184164610", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4164710", Offset = "0x4163510", VA = "0x184164710")]
		public void INPHPMAGDMA(NAMEMILJEON KDJHNALPMDH, out int ANCJPNHHEKP, out int HAHIOMMPPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4164940", Offset = "0x4163740", VA = "0x184164940")]
		public void KCCACPKKHMF(NAMEMILJEON KDJHNALPMDH, JPLPDGOBJNE CCEMHDFCGEF, int NJIEEEGMLCA = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4164B80", Offset = "0x4163980", VA = "0x184164B80")]
		public void NKLCJJBCBOP(NativeList<ILHGJLIBIMO> GKMGOBEHMKA, Transform MHHAEEJGCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4164AE0", Offset = "0x41638E0", VA = "0x184164AE0")]
		public void MMLKPGKEHEA(Mesh JJINPOBHIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4164630", Offset = "0x4163430", VA = "0x184164630")]
		public void HNKMBPLGMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41644A0", Offset = "0x41632A0", VA = "0x1841644A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4164EA0", Offset = "0x4163CA0", VA = "0x184164EA0")]
		public JDMLIPFLLAB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds NNLDFIOPKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<JDMLIPFLLAB> ODGDGFFOPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public FBHHKFKHNKH CABGIPAENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer EOCMEEPKAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int JNKEOHOPMOJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh JAOAFNLHICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5450C0", Offset = "0x543EC0", VA = "0x1805450C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63FA90", Offset = "0x63E890", VA = "0x18063FA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CHCICBCMFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x78A9E0", Offset = "0x7897E0", VA = "0x18078A9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78AA60", Offset = "0x789860", VA = "0x18078AA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int JAKBFPAJFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x416AE50", Offset = "0x4169C50", VA = "0x18416AE50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x416B080", Offset = "0x4169E80", VA = "0x18416B080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x416AEA0", Offset = "0x4169CA0", VA = "0x18416AEA0")]
	public int AOGOOKKLIFE(int ILMCBJDKBCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x416C0E0", Offset = "0x416AEE0", VA = "0x18416C0E0")]
	public void NMLBGDKCCCP(JPEELPAPAPE BBCAGBFEBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x416B440", Offset = "0x416A240", VA = "0x18416B440")]
	public void GKLNAGIEIOP(Transform MHHAEEJGCCM, bool NEHLDMILJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x416AED0", Offset = "0x4169CD0", VA = "0x18416AED0")]
	public bool CCBCBEHMKDN(bool JMMJHIFLJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x416BB50", Offset = "0x416A950", VA = "0x18416BB50")]
	public void MBNGOLAMBAE(Transform FBADHAKMLIA, bool NEHLDMILJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x416B1E0", Offset = "0x4169FE0", VA = "0x18416B1E0")]
	public bool FKDIFICKHIH(JNAFBFAIOCJ LFKGOLJOIDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x416C270", Offset = "0x416B070", VA = "0x18416C270")]
	public PJLCHNNOJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BEFOAFIDDPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<PJLCHNNOJBI.JDMLIPFLLAB> HAGHOPNLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private KLEOGNHFLGE MAGJJIHFGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<PJLCHNNOJBI.JDMLIPFLLAB> MCOMKLNAEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int JICFMHLNGCH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x415C110", Offset = "0x415AF10", VA = "0x18415C110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x415C390", Offset = "0x415B190", VA = "0x18415C390")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x415C7D0", Offset = "0x415B5D0", VA = "0x18415C7D0")]
	public void PEIDOEKHNGH(PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA, Transform FBADHAKMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x415C1E0", Offset = "0x415AFE0", VA = "0x18415C1E0")]
	public void FKDIFICKHIH(PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x415C410", Offset = "0x415B210", VA = "0x18415C410")]
	private PJLCHNNOJBI.JDMLIPFLLAB HFEHMDOIEMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x415C020", Offset = "0x415AE20", VA = "0x18415C020")]
	private bool AGGOCDDADPP(PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x415C0B0", Offset = "0x415AEB0", VA = "0x18415C0B0")]
	private void BLMGPEGLKBA(PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x415C540", Offset = "0x415B340", VA = "0x18415C540")]
	public bool LOCOOLBMGKH(PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x415C580", Offset = "0x415B380", VA = "0x18415C580")]
	public bool OLEACKIIGIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x415C180", Offset = "0x415AF80", VA = "0x18415C180")]
	private PJLCHNNOJBI.JDMLIPFLLAB FJKIOAHLPMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x415C880", Offset = "0x415B680", VA = "0x18415C880")]
	public BEFOAFIDDPO()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD85B10", Offset = "0xD84910", VA = "0x180D85B10")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NAFCMHCDMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GLCCLMNONFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int MFOBAPAFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float GPHMCNMPJPP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<PJLCHNNOJBI> CFNHFKOPECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x41698F0", Offset = "0x41686F0", VA = "0x1841698F0")]
	public NAFCMHCDMJE(int GLCCLMNONFE, int MFOBAPAFMKF, float JBMEGCAGMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x41695D0", Offset = "0x41683D0", VA = "0x1841695D0")]
	public void IGNLCHIBFJI(HPPHCKOMNJP PPCICGNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4169850", Offset = "0x4168650", VA = "0x184169850")]
	private int PPKDFFMFJIA(JPEELPAPAPE BNPACBIBAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x41693A0", Offset = "0x41681A0", VA = "0x1841693A0")]
	private void IGNLCHIBFJI(JPEELPAPAPE BNPACBIBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4169670", Offset = "0x4168470", VA = "0x184169670")]
	private void JBCIPKGOAMH(JPEELPAPAPE BNPACBIBAJO, PJLCHNNOJBI BOMDKBCOHOM)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, LBPFPPMPNKO
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class PKBHHJEGKGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
			[DebuggerHidden]
			public PKBHHJEGKGK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x416C310", Offset = "0x416B110", VA = "0x18416C310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x416C4A0", Offset = "0x416B2A0", VA = "0x18416C4A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x416C400", Offset = "0x416B200", VA = "0x18416C400", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x416C400", Offset = "0x416B200", VA = "0x18416C400", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int JAKBFPAJFHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x415E5A0", Offset = "0x415D3A0", VA = "0x18415E5A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<PANDFKHDBNL> HKGIKPGLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x415E580", Offset = "0x415D380", VA = "0x18415E580", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> ODGDGFFOPEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PJLCHNNOJBI JAOAFNLHICA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public ABBDGBMMMGF DNGFKKONFNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x51D390", Offset = "0x51C190", VA = "0x18051D390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(ABBDGBMMMGF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727B90", VA = "0x180728D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JIHGFHPAOAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x415E590", Offset = "0x415D390", VA = "0x18415E590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x415D2C0", Offset = "0x415C0C0", VA = "0x18415D2C0")]
		public static ClusterMeshRenderer Create(PJLCHNNOJBI JJINPOBHIAK, ClusterMeshRenderer HLOAIOHJAGE, MeshFilter OPODDGNFHBJ, Transform FBADHAKMLIA, ABBDGBMMMGF NJJGPLFCFHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x415D3D0", Offset = "0x415C1D0", VA = "0x18415D3D0", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x415DB30", Offset = "0x415C930", VA = "0x18415DB30", Slot = "10")]
		public bool TryRemoveClusterLODComponent(JNAFBFAIOCJ LFKGOLJOIDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x415D900", Offset = "0x415C700", VA = "0x18415D900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x415D630", Offset = "0x415C430", VA = "0x18415D630")]
		public void Init(PJLCHNNOJBI JJINPOBHIAK, MeshFilter OPODDGNFHBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x415D430", Offset = "0x415C230", VA = "0x18415D430")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x415DC60", Offset = "0x415CA60", VA = "0x18415DC60", Slot = "8")]
		public void UpdateClusterDistances(Vector3 PLEAHKOHNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x415DEA0", Offset = "0x415CCA0", VA = "0x18415DEA0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x415D5C0", Offset = "0x415C3C0", VA = "0x18415D5C0")]
		[IteratorStateMachine(typeof(PKBHHJEGKGK))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x415D980", Offset = "0x415C780", VA = "0x18415D980")]
		public void SetupTagAndLayer(string NJBECPJAJKP, int NJJGPLFCFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x415D960", Offset = "0x415C760", VA = "0x18415D960")]
		public bool Remove(JNAFBFAIOCJ LFKGOLJOIDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD85B10", Offset = "0xD84910", VA = "0x180D85B10")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CIAOPEJFNBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int IMIEKFACDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int CJMMDDOFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HAHIOMMPPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int ANCJPNHHEKP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x415D030", Offset = "0x415BE30", VA = "0x18415D030")]
	public CIAOPEJFNBD(int CJMMDDOFLDK, int HAHIOMMPPNP, int IMIEKFACDCA, int ANCJPNHHEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FBHHKFKHNKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> JCNDFKBJKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> JIBNIDOPLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> NIFICMKGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<CIAOPEJFNBD> DGMNONLDIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> LEGLNPLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> GLBPLEBOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> MBGCEJFALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle PJGJHPOJEFE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IBCDBFECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC720", Offset = "0x6BB520", VA = "0x1806BC720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC740", Offset = "0x6BB540", VA = "0x1806BC740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x41614F0", Offset = "0x41602F0", VA = "0x1841614F0")]
	public void FDKPJNJEAKE(DEBDNLBMIJH EIIAPIEEAGO, NativeList<CIAOPEJFNBD> DGMNONLDIOE, float CHFCJIJPKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x41612A0", Offset = "0x41600A0", VA = "0x1841612A0")]
	public void EDICLAPHFPJ(Transform FBADHAKMLIA, bool NEHLDMILJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4161040", Offset = "0x415FE40", VA = "0x184161040")]
	public void CCBCBEHMKDN(PJLCHNNOJBI EOCMEEPKAME, bool JMMJHIFLJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41611D0", Offset = "0x415FFD0", VA = "0x1841611D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4162270", Offset = "0x4161070", VA = "0x184162270")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public FBHHKFKHNKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct NHGJCFPGLEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> JCNDFKBJKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> JIBNIDOPLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<CIAOPEJFNBD> CCAOHKONLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> LEGLNPLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 DBJODHEDEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> GLBPLEBOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> MBGCEJFALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool NEHLDMILJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float MLFLKEKGFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float OLNAOPNAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float CFCFIFDIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> NIFICMKGADL;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4169DE0", Offset = "0x4168BE0", VA = "0x184169DE0")]
	public NHGJCFPGLEM(FBHHKFKHNKH POAFICOLHLJ, Vector3 DBJODHEDEPJ, bool NEHLDMILJEL, float MLFLKEKGFNL, float OLNAOPNAKIM, float CFCFIFDIFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4169940", Offset = "0x4168740", VA = "0x184169940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JNAFBFAIOCJ : PKNECAEPMKC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds FFBBIOBKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ILHGJLIBIMO FBAFGPDDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JPEELPAPAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<JNAFBFAIOCJ> EOIIJJEEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public JPEELPAPAPE DEGLKKAFDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public JPEELPAPAPE DOCEDNPJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public JPEELPAPAPE OGIHBNKBLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int ANCJPNHHEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds NNLDFIOPKCK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4164F60", Offset = "0x4163D60", VA = "0x184164F60")]
	public JPEELPAPAPE(List<JNAFBFAIOCJ> EOIIJJEEOHI, [Optional] JPEELPAPAPE DEGLKKAFDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HPPHCKOMNJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<JPEELPAPAPE> IIBIFEIKECE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JPEELPAPAPE GGOGHAHJCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4163FF0", Offset = "0x4162DF0", VA = "0x184163FF0")]
	public HPPHCKOMNJP(JPEELPAPAPE FBADHAKMLIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HPOHAAEKIJL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct IBECGFFNDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int FFFOCBDCCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int INFKLLJOEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int MEHEOKMACMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int EFMEEAKHKAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OGKJOBLPGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int BCOCFFANPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float AFALDKMJOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<JNAFBFAIOCJ> EOIIJJEEOHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum GLODDFAIGLM
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
	private IBECGFFNDHD PABNHDFEEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int CHPLPAAIGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int GLCCLMNONFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int MFOBAPAFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float JBMEGCAGMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float BANAGANLNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<JPEELPAPAPE> INNOMGOBMHC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HPPHCKOMNJP NMOAOLBDDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4163F90", Offset = "0x4162D90", VA = "0x184163F90")]
	public HPOHAAEKIJL(int GLCCLMNONFE, int MFOBAPAFMKF, float JBMEGCAGMAD, int CHPLPAAIGMG, float BANAGANLNNH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x41623C0", Offset = "0x41611C0", VA = "0x1841623C0")]
	public void AILIFDPIGFF(List<JNAFBFAIOCJ> EOIIJJEEOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4163B90", Offset = "0x4162990", VA = "0x184163B90")]
	public bool JPAPHFICCPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41639E0", Offset = "0x41627E0", VA = "0x1841639E0")]
	private float ILFBEMPDHHP(Vector3 HBLINDDGOHP, Vector3 GAJLIJGLIBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4163AF0", Offset = "0x41628F0", VA = "0x184163AF0")]
	private float ILFBEMPDHHP(Vector3 DPKPMBGBJLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x41630D0", Offset = "0x4161ED0", VA = "0x1841630D0")]
	private bool DNOOAIBPABP(JPEELPAPAPE HPIAANJPONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4162580", Offset = "0x4161380", VA = "0x184162580")]
	private OGKJOBLPGEB DDOAPAOFGEH(List<JNAFBFAIOCJ> LCMPMNLEFKJ, GLODDFAIGLM ANOKKEGIIIH)
	{
		return default(OGKJOBLPGEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4163C00", Offset = "0x4162A00", VA = "0x184163C00")]
	private void NGDCIPMBAFC(List<JNAFBFAIOCJ> EOIIJJEEOHI, Vector3[] NCKOECNKOHD, Vector3[] CEBDOBDOMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class IKPECGMMBPO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4164160", Offset = "0x4162F60", VA = "0x184164160")]
	public static Bounds EPLINMIAMEO(List<JNAFBFAIOCJ> EOIIJJEEOHI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4164310", Offset = "0x4163110", VA = "0x184164310")]
	public static int OOEELGAOHNI(List<JNAFBFAIOCJ> EOIIJJEEOHI, NAMEMILJEON KDJHNALPMDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KLEOGNHFLGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private DEBDNLBMIJH MDAPBDPPCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DEBDNLBMIJH FBIFGENHNCI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static DEBDNLBMIJH JDENCKBLCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private PGBEDJFNKBH EPHGOMLCNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private JPLPDGOBJNE CCEMHDFCGEF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle PJGJHPOJEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84FC10", Offset = "0x84EA10", VA = "0x18084FC10")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84FC30", Offset = "0x84EA30", VA = "0x18084FC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PJLCHNNOJBI.JDMLIPFLLAB HPIAANJPONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PEJPEDPGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x75CB70", Offset = "0x75B970", VA = "0x18075CB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4166DD0", Offset = "0x4165BD0", VA = "0x184166DD0")]
	[OENDEPLIANP(AJFNGMOAHIK.ExitingPlayMode, 0)]
	private void HHBLMFLJKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4166410", Offset = "0x4165210", VA = "0x184166410")]
	public void FDKPJNJEAKE(PJLCHNNOJBI.JDMLIPFLLAB CCAOHKONLEM, Transform AFKFBFKKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4166E40", Offset = "0x4165C40", VA = "0x184166E40")]
	public void NKONBCDGDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x41663A0", Offset = "0x41651A0", VA = "0x1841663A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4166D90", Offset = "0x4165B90", VA = "0x184166D90")]
	public void GGFJFJEKGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4167400", Offset = "0x4166200", VA = "0x184167400")]
	public KLEOGNHFLGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OEOFHGJMJKH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DMNFPOPEOLM DGKOANKFFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DKIJECOGBEC
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 BHHOIPGPGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DELJKMIKDIG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ECOIGABICGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PHIGNIBDPJG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action FEANFPGOEOF;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FFNFNMALHEF
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFNFNMALHEF EJEIDKGKIJE(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFNFNMALHEF KMLGFFGFKGG(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFNFNMALHEF FLDFCIHLKBL(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FFNFNMALHEF GBKBLPPAKHN(Action JJOAKFFHFLE);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class BIMFEFAFOBD : FFNFNMALHEF
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class CKNBBNEEAMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public BIMFEFAFOBD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public CKNBBNEEAMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x415D050", Offset = "0x415BE50", VA = "0x18415D050")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x415D0A0", Offset = "0x415BEA0", VA = "0x18415D0A0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x415D0F0", Offset = "0x415BEF0", VA = "0x18415D0F0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> LAFOECINMLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action ACIONLPCMPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action FIKIHOOMGJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private DNCKLIGMBCP KABOFDGEFJC;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action COGHIOPIAFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5450C0", Offset = "0x543EC0", VA = "0x1805450C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x63FA90", Offset = "0x63E890", VA = "0x18063FA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action PEPPAEPPBON
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B8F0", Offset = "0x2A3A6F0", VA = "0x182A3B8F0", Slot = "4")]
			public FFNFNMALHEF EJEIDKGKIJE(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x294FF60", Offset = "0x294ED60", VA = "0x18294FF60", Slot = "5")]
			public FFNFNMALHEF KMLGFFGFKGG(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B910", Offset = "0x2A3A710", VA = "0x182A3B910", Slot = "6")]
			public FFNFNMALHEF FLDFCIHLKBL(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xEEAA60", Offset = "0xEE9860", VA = "0x180EEAA60", Slot = "7")]
			public FFNFNMALHEF GBKBLPPAKHN(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x651320", Offset = "0x650120", VA = "0x180651320")]
			public BIMFEFAFOBD(Func<JobHandle> LPNIBFCJLGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x415C9C0", Offset = "0x415B7C0", VA = "0x18415C9C0")]
			public void COPFLBHJBJL(Action GEJOHHJAIFO, Action PCFKJJHBIOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x415CBF0", Offset = "0x415B9F0", VA = "0x18415CBF0")]
			public void FKDIFICKHIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HHJJDGIHDEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public FFNFNMALHEF jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public HHJJDGIHDEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x41623B0", Offset = "0x41611B0", VA = "0x1841623B0")]
			internal bool <Remove>b__0(BIMFEFAFOBD a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class NIOKDKFKDIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public BIMFEFAFOBD newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public NIOKDKFKDIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4169EB0", Offset = "0x4168CB0", VA = "0x184169EB0")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<BIMFEFAFOBD> BOIIGEIEKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<BIMFEFAFOBD> DNJCGJJCNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private HOAOHLFJCKG DFFNABDGMLI;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4164FE0", Offset = "0x4163DE0", VA = "0x184164FE0")]
		public FFNFNMALHEF Add(Func<JobHandle> LPNIBFCJLGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4165280", Offset = "0x4164080", VA = "0x184165280")]
		public void Remove(FFNFNMALHEF PJGJHPOJEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4165100", Offset = "0x4163F00", VA = "0x184165100", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4165400", Offset = "0x4164200", VA = "0x184165400")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x41655D0", Offset = "0x41643D0", VA = "0x1841655D0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x41650F0", Offset = "0x4163EF0", VA = "0x1841650F0")]
		[CompilerGenerated]
		private void MFPNMHMCIOB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DNCKLIGMBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DNCKLIGMBCP EJEIDKGKIJE(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNCKLIGMBCP ACOMEOJDEKF(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNCKLIGMBCP GBKBLPPAKHN(Action JJOAKFFHFLE);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class CHIKKFHIDHN : DNCKLIGMBCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle ACGMFFIGDJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action ACIONLPCMPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action NCBNDLBFBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action PEPPAEPPBON;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool EFGCFHIDIDJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x415CFA0", Offset = "0x415BDA0", VA = "0x18415CFA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x294FF60", Offset = "0x294ED60", VA = "0x18294FF60", Slot = "4")]
			public DNCKLIGMBCP EJEIDKGKIJE(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2A3B910", Offset = "0x2A3A710", VA = "0x182A3B910", Slot = "5")]
			public DNCKLIGMBCP ACOMEOJDEKF(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xEEAA60", Offset = "0xEE9860", VA = "0x180EEAA60", Slot = "6")]
			public DNCKLIGMBCP GBKBLPPAKHN(Action JJOAKFFHFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC79910", Offset = "0xC78710", VA = "0x180C79910")]
			public CHIKKFHIDHN(JobHandle OGCIPIPOFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x415CFF0", Offset = "0x415BDF0", VA = "0x18415CFF0")]
			public void IANFCFBCFJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x415CFB0", Offset = "0x415BDB0", VA = "0x18415CFB0")]
			public void FKDIFICKHIH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<CHIKKFHIDHN> JIHLLBIICNB;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4165A50", Offset = "0x4164850", VA = "0x184165A50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4165690", Offset = "0x4164490", VA = "0x184165690")]
		public DNCKLIGMBCP Add(JobHandle OGCIPIPOFDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4165960", Offset = "0x4164760", VA = "0x184165960")]
		public void Remove(DNCKLIGMBCP PJGJHPOJEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4165800", Offset = "0x4164600", VA = "0x184165800", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4165720", Offset = "0x4164520", VA = "0x184165720")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4165B60", Offset = "0x4164960", VA = "0x184165B60")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4168DB0", Offset = "0x4167BB0", VA = "0x184168DB0")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4168EB0", Offset = "0x4167CB0", VA = "0x184168EB0")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
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
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
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
