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
				[Cpp2IlInjected.Address(RVA = "0x3DF0860", Offset = "0x3DEF660", VA = "0x183DF0860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xFC7650", Offset = "0xFC6450", VA = "0x180FC7650")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3DF0820", Offset = "0x3DEF620", VA = "0x183DF0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DEA6B0", Offset = "0x3DE94B0", VA = "0x183DEA6B0")]
		public LODSettings DLBPPOMDAFN(DMMEFAOHKAI KPEFNKLAHLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA6C0", Offset = "0x3DE94C0", VA = "0x183DEA6C0")]
		public int EBANEDGCKJM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA6E0", Offset = "0x3DE94E0", VA = "0x183DEA6E0")]
		public int EMIOGHFOPAI(bool BKPHHOAIIGH, Vector3 FAKPEPGEJML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA7E0", Offset = "0x3DE95E0", VA = "0x183DEA7E0")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HICJMGGLOFA
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
public interface AAKOHCJNEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJEIKKKDNLD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KPFPGGOODDC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GFGCNCBPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<IPDCIPDPFFD> OIMHNJNILCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HICJMGGLOFA NNMDIAAPKOG
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
	void UpdateClusterDistances(Vector3 CCLGFGCMLBB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(KPCAGAHCJHB JCGLGNAMOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IPDCIPDPFFD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NGHDKGBNFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LGINHLBKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NGOAMDJFFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OPMALGKPBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte EPIEMBBKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NDLKNPDGHPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GLCJLOHGCAI
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
	private sealed class NEBBOOHNDHO : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NDLKNPDGHPE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public NEBBOOHNDHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3380", Offset = "0x3DF2180", VA = "0x183DF3380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3440", Offset = "0x3DF2240", VA = "0x183DF3440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EHJLPJLLOAE : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private CNLGKCMJFDJ <>2__current;

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
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public EHJLPJLLOAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC770", Offset = "0x3DEB570", VA = "0x183DEC770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC8C0", Offset = "0x3DEB6C0", VA = "0x183DEC8C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GOIGDIICPOF : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NDLKNPDGHPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<CNLGKCMJFDJ> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public GOIGDIICPOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC910", Offset = "0x3DEB710", VA = "0x183DEC910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3DED390", Offset = "0x3DEC190", VA = "0x183DED390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LLGFHOHHCPD : IEnumerator<CNLGKCMJFDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private CNLGKCMJFDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NDLKNPDGHPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private CNLGKCMJFDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6086A0", Offset = "0x6074A0", VA = "0x1806086A0")]
		[DebuggerHidden]
		public LLGFHOHHCPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF8E0", Offset = "0x3DEE6E0", VA = "0x183DEF8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF07D0", Offset = "0x3DEF5D0", VA = "0x183DF07D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int IEGJOEAKLEM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer HEIHFKKDEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter IPKNGMJFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject FOKPCNLNPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject MBNCDLKOJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public EFONPPEFEEM MCFKHNDLPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<KPCAGAHCJHB> ODKHOGJDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<KPCAGAHCJHB> PLFHCKPJLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<KPCAGAHCJHB> FJDOIIBDOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int OMHHHJCFFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GLCJLOHGCAI AONJIOPKBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<KPFPGGOODDC>[] BEBHDJKIMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<IPDCIPDPFFD>[] MCCJELDDLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LKIEAODIPPJ ANOBIEBLIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private LKIEAODIPPJ LCFAFKDDOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private LKIEAODIPPJ HDMFLFGKJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int MNNAPMPICAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int IPFLCBGJEDP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static NDLKNPDGHPE MEHOFLOGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CHHEHJMFAMI HHLOIMDDAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LNFJMFLHKAB FHOOHCIIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour ABIIIDCDJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material LAFHALHBBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<AAKOHCJNEAA> LNAEMENACCC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig INLKLFKHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 DPEOLNABGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCC3BF0", Offset = "0xCC29F0", VA = "0x180CC3BF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCC2560", Offset = "0xCC1360", VA = "0x180CC2560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private GLCJLOHGCAI JGMBOFFAOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FCCD0", Offset = "0x4FBAD0", VA = "0x1804FCCD0")]
		get
		{
			return default(GLCJLOHGCAI);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1980", Offset = "0x3DF0780", VA = "0x183DF1980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NDLKNPDGHPE OPFHHPKJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1340", Offset = "0x3DF0140", VA = "0x183DF1340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool KPFHPLDABCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2110", Offset = "0x3DF0F10", VA = "0x183DF2110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool MMEIKOIGEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3DF13C0", Offset = "0x3DF01C0", VA = "0x183DF13C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> NIHIMCGEOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1730", Offset = "0x3DF0530", VA = "0x183DF1730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0C70", Offset = "0x3DEFA70", VA = "0x183DF0C70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JEIKICDIGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF14C0", Offset = "0x3DF02C0", VA = "0x183DF14C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2D60", Offset = "0x3DF1B60", VA = "0x183DF2D60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2E00", Offset = "0x3DF1C00", VA = "0x183DF2E00")]
	public NDLKNPDGHPE(CHHEHJMFAMI HHLOIMDDAPL, LNFJMFLHKAB FHOOHCIIGJI, ClusterLODConfig JDHDHEOEGAB, MonoBehaviour ABIIIDCDJJL, Material LAFHALHBBEA, ClusterMeshRenderer HEIHFKKDEHM, MeshFilter IPKNGMJFNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DF17D0", Offset = "0x3DF05D0", VA = "0x183DF17D0")]
	private void HPMBJAGKKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0FC0", Offset = "0x3DEFDC0", VA = "0x183DF0FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0940", Offset = "0x3DEF740", VA = "0x183DF0940")]
	public static void AIJAGBJNJLM(Vector3 CBLKOPKNCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1860", Offset = "0x3DF0660", VA = "0x183DF1860")]
	private void IAENMPCGPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DF09D0", Offset = "0x3DEF7D0", VA = "0x183DF09D0")]
	private void APFLOPPIFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1E60", Offset = "0x3DF0C60", VA = "0x183DF1E60")]
	private void MBIFKEKMOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DF22B0", Offset = "0x3DF10B0", VA = "0x183DF22B0")]
	public void NEIPDJEGKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1D90", Offset = "0x3DF0B90", VA = "0x183DF1D90")]
	[IteratorStateMachine(typeof(NEBBOOHNDHO))]
	private IEnumerator<CNLGKCMJFDJ> KKFEEBAMDGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2190", Offset = "0x3DF0F90", VA = "0x183DF2190")]
	[IteratorStateMachine(typeof(EHJLPJLLOAE))]
	private IEnumerator<CNLGKCMJFDJ> MMKCHKNFCLL(Func<bool> GNAGAPJFADK, float DJGMBHNKCOD, Func<string> JFFHMPFNPEK, float EDLKKKEHEIO = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0AD0", Offset = "0x3DEF8D0", VA = "0x183DF0AD0")]
	[IteratorStateMachine(typeof(GOIGDIICPOF))]
	private IEnumerator<CNLGKCMJFDJ> BMNDBAJEKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1130", Offset = "0x3DEFF30", VA = "0x183DF1130")]
	public void EICOFKFNJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1D10", Offset = "0x3DF0B10", VA = "0x183DF1D10")]
	public void KJMLGOJKKHC(IEnumerable<KPFPGGOODDC> FADHHOKCFFP, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0D10", Offset = "0x3DEFB10", VA = "0x183DF0D10")]
	public void CPNCOIIDPNP(IEnumerable<KPFPGGOODDC> FADHHOKCFFP, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2580", Offset = "0x3DF1380", VA = "0x183DF2580")]
	public List<ClusterMeshRenderer> NELGLFLPFPB(List<KPCAGAHCJHB> HCDPPCJLAFM, Transform ILMCIJGNPKB, HICJMGGLOFA BIHMJBCKDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1B00", Offset = "0x3DF0900", VA = "0x183DF1B00")]
	public HICJMGGLOFA KGHPMNMBPII(Vector3 EIOILGJKIOJ)
	{
		return default(HICJMGGLOFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1E00", Offset = "0x3DF0C00", VA = "0x183DF1E00")]
	public void LIOCDECBDOI(AAKOHCJNEAA MJJNLGMPFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1420", Offset = "0x3DF0220", VA = "0x183DF1420")]
	public bool GLFLEBBGFII(AAKOHCJNEAA MJJNLGMPFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1560", Offset = "0x3DF0360", VA = "0x183DF1560")]
	public void HGLPIFPBNKP(KPCAGAHCJHB JJACJHJCGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1900", Offset = "0x3DF0700", VA = "0x183DF1900")]
	public void IIDLFCGAIIJ(IPDCIPDPFFD EGLDEENDOPH, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2230", Offset = "0x3DF1030", VA = "0x183DF2230")]
	public void MPLMAMFHCAM(IPDCIPDPFFD EGLDEENDOPH, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0B40", Offset = "0x3DEF940", VA = "0x183DF0B40")]
	private void CKABEKEJEJD(Vector3 CCLGFGCMLBB, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3DF15C0", Offset = "0x3DF03C0", VA = "0x183DF15C0")]
	private void HKPONJLCICG(Vector3 CCLGFGCMLBB, HICJMGGLOFA BIHMJBCKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2CF0", Offset = "0x3DF1AF0", VA = "0x183DF2CF0")]
	[IteratorStateMachine(typeof(LLGFHOHHCPD))]
	private IEnumerator<CNLGKCMJFDJ> OLLFLAEDBIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1FA0", Offset = "0x3DF0DA0", VA = "0x183DF1FA0")]
	private int MFFCJKHJMII(int NCKDNOGOLME, int KDJKDFNGDPI, List<IPDCIPDPFFD> GPIGEGCNFIG, byte KPEFNKLAHLE, ref int ADOJOCAOCPI, float DKGOJOLPJJJ = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1B40", Offset = "0x3DF0940", VA = "0x183DF1B40")]
	public void KGKIHAGANBK(KPCAGAHCJHB JCGLGNAMOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1480", Offset = "0x3DF0280", VA = "0x183DF1480")]
	public bool HAPGMEKJDJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9610", Offset = "0x6B8410", VA = "0x1806B9610")]
	public Material DLBBJPCJKPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF10F0", Offset = "0x3DEFEF0", VA = "0x183DF10F0")]
	public int EBANEDGCKJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1AB0", Offset = "0x3DF08B0", VA = "0x183DF1AB0")]
	[CompilerGenerated]
	private bool JFMEGMIHADH()
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
		[Cpp2IlInjected.Address(RVA = "0xC67C20", Offset = "0xC66A20", VA = "0x180C67C20")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct KAHFKBALBDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> NPPECAEINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> CEOCJLFMOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> MCPOFAOFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> KFIOOEBLMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> KOAGABOHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> JFEFPJLHNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> PMPOBHIMEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 NCMPGBGGPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float BDONFPDIOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> OJAFJGEEIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> CKKPHGPFOEO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF230", Offset = "0x3DEE030", VA = "0x183DEF230")]
	public KAHFKBALBDD(BPHOGJLMOEJ LBIDBAEJDLB, NativeList<float3> PMPOBHIMEEM, NativeMultiHashMap<int, int> OJAFJGEEIDK, NativeArray<int> CKKPHGPFOEO, Vector3 NCMPGBGGPPM, float BDONFPDIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEDE0", Offset = "0x3DEDBE0", VA = "0x183DEEDE0")]
	private int EIJKKOOLNHF(float3 CCLGFGCMLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEB40", Offset = "0x3DED940", VA = "0x183DEEB40")]
	private int DKMIHOGNEPJ(int LJMKFDJKKDN, int MLBLCDKAFED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3DEEE40", Offset = "0x3DEDC40", VA = "0x183DEEE40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBKBFHDNEAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> OJAFJGEEIDK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> CKKPHGPFOEO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int HKBOHPMLAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> CGGGMIHLIOE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBC30", Offset = "0x3DEAA30", VA = "0x183DEBC30")]
	public void IHHODEDJKGD(int EAAKFIPDOGE, Allocator IDIPGFLNONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBB80", Offset = "0x3DEA980", VA = "0x183DEBB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public DBKBFHDNEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct MCGBLOLJLHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> INNIJJHNMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> AOLJEINONJD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0910", Offset = "0x3DEF710", VA = "0x183DF0910")]
	public MCGBLOLJLHN(DBKBFHDNEAM PLKIMFCNLFP, BPHOGJLMOEJ LBIDBAEJDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0880", Offset = "0x3DEF680", VA = "0x183DF0880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct OFKLHHFMBKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> COBEBECDCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> CFOHJKAHHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> FLODMKMMKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> MBOODDHMJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> LCDBKHILNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> CGGGMIHLIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> INNIJJHNMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> ELCKBFDEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> MBFMHHDIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> LELAMOLBNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> MCFMLKBLAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> OEMAJDPILNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> GGBILFDKJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float HCFFDCJKBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float CDABMEGONKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 NEHIFDOIBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float EPNNFJCDFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float KJNJGOGMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float KAEKBLOCFHO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4F90", Offset = "0x3DF3D90", VA = "0x183DF4F90")]
	public OFKLHHFMBKE(DBKBFHDNEAM EANBCANDACI, BPHOGJLMOEJ LBIDBAEJDLB, BPHOGJLMOEJ GNPCKHNLOGI, float KJNJGOGMDPB, float KAEKBLOCFHO, Vector3 NEHIFDOIBLP, float EPNNFJCDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4940", Offset = "0x3DF3740", VA = "0x183DF4940")]
	private float3 HKKAOJOMAAH(int LJMKFDJKKDN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4560", Offset = "0x3DF3360", VA = "0x183DF4560")]
	private void FMMFNMCBHOG(int LJMKFDJKKDN, out float3 EKCIJBMBPOE, out float3 JMIAJPFGALB, out float4 AGBCBHKMEGN, out float4 ECOFFLAJMIL, out float2 CAKKOKGPGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF49E0", Offset = "0x3DF37E0", VA = "0x183DF49E0")]
	private int INMPEOGBDEE(int OFMECGILJEO, int OJLGGIAIHEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4740", Offset = "0x3DF3540", VA = "0x183DF4740")]
	private void HIBIALHGBIO(int OFMECGILJEO, int OJLGGIAIHEG, int GKCBECENONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF43D0", Offset = "0x3DF31D0", VA = "0x183DF43D0")]
	private bool FHGNMDCPMGA(int OFMECGILJEO, int OJLGGIAIHEG, float ENCMKFLEFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF39B0", Offset = "0x3DF27B0", VA = "0x183DF39B0")]
	private bool ALLLKCKPMLG(int OFMECGILJEO, int OJLGGIAIHEG, int GKCBECENONO, float ENCMKFLEFPL, bool ENBDDDAOOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4D10", Offset = "0x3DF3B10", VA = "0x183DF4D10")]
	private bool LDOLOMFNDGM(int OFMECGILJEO, int OJLGGIAIHEG, int GKCBECENONO, float ENCMKFLEFPL, bool ENBDDDAOOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4F70", Offset = "0x3DF3D70", VA = "0x183DF4F70")]
	private void LFCKNIENOKN(int OFMECGILJEO, int OJLGGIAIHEG, int GKCBECENONO, out int EHOINPJOHEG, out int PIIMGGDDAOG, out int GMMJODIKDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3A70", Offset = "0x3DF2870", VA = "0x183DF3A70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ANCGNONLBKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BMKBKLKKHOL : IDisposable, IPDCIPDPFFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds NLBALGBILIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<KPCAGAHCJHB> HCDPPCJLAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 CHBFEKMOBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 LOOPKFPFECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int CMEKLOJODFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BPHOGJLMOEJ PMAMAIDDGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DBKBFHDNEAM POKMOHBEMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform ILMCIJGNPKB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MHMEGONFDAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3DE85D0", Offset = "0x3DE73D0", VA = "0x183DE85D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh EPHDHHAKKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh PMHGHLPBFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x4EA010", Offset = "0x4E8E10", VA = "0x1804EA010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4EA020", Offset = "0x4E8E20", VA = "0x1804EA020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NGOAMDJFFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD8190", Offset = "0xCD6F90", VA = "0x180CD8190", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xEE04A0", Offset = "0xEDF2A0", VA = "0x180EE04A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte EPIEMBBKMFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5C66E0", Offset = "0x5C54E0", VA = "0x1805C66E0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5C6880", Offset = "0x5C5680", VA = "0x1805C6880", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int NGHDKGBNFND
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x62E020", Offset = "0x62CE20", VA = "0x18062E020", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x62D6B0", Offset = "0x62C4B0", VA = "0x18062D6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int LGINHLBKPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9D0AF0", Offset = "0x9CF8F0", VA = "0x1809D0AF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xC04DC0", Offset = "0xC03BC0", VA = "0x180C04DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float OPMALGKPBFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8D80", Offset = "0x3DE7B80", VA = "0x183DE8D80", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE83A0", Offset = "0x3DE71A0", VA = "0x183DE83A0")]
		public void BLPFHDHDOOB(DMMEFAOHKAI KPEFNKLAHLE, out int HNCJIBNGFMC, out int GNMIEBGHIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8780", Offset = "0x3DE7580", VA = "0x183DE8780")]
		public void GMAFPOMEJFG(DMMEFAOHKAI KPEFNKLAHLE, OFGFGEDIPGM LGIBOCGIBCG, int KJHFIIEBDOC = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89C0", Offset = "0x3DE77C0", VA = "0x183DE89C0")]
		public void LCLGIGCBIGG(NativeList<AAPODEOBBEG> KNJKNMJBECM, Transform CHNJKDKPJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CE0", Offset = "0x3DE7AE0", VA = "0x183DE8CE0")]
		public void LKLBBPFLJAK(Mesh LBIDBAEJDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8920", Offset = "0x3DE7720", VA = "0x183DE8920")]
		public void IMMCJPNAFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8610", Offset = "0x3DE7410", VA = "0x183DE8610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8DA0", Offset = "0x3DE7BA0", VA = "0x183DE8DA0")]
		public BMKBKLKKHOL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds NLBALGBILIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<BMKBKLKKHOL> OAGMIGIKHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public BMPNOCBDJEN BEAKGHBGFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer MKLINLGDHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int ECAJOLOBCGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh OOAPAKOLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5120C0", Offset = "0x510EC0", VA = "0x1805120C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5C4220", Offset = "0x5C3020", VA = "0x1805C4220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DGKEBPMKBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C7540", Offset = "0x6C6340", VA = "0x1806C7540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C75C0", Offset = "0x6C63C0", VA = "0x1806C75C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GFGCNCBPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5F50", Offset = "0x3DE4D50", VA = "0x183DE5F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5DF0", Offset = "0x3DE4BF0", VA = "0x183DE5DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5FA0", Offset = "0x3DE4DA0", VA = "0x183DE5FA0")]
	public int GJCIPBONKDM(int HDDMFNGCKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6AF0", Offset = "0x3DE58F0", VA = "0x183DE6AF0")]
	public void KNCOINBGPCB(CICNFALMCGE FLIJGLBLNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6180", Offset = "0x3DE4F80", VA = "0x183DE6180")]
	public void IBHLKENAAME(Transform CHNJKDKPJAH, bool GNJOOBIAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5FD0", Offset = "0x3DE4DD0", VA = "0x183DE5FD0")]
	public bool GMIPEBMJALB(bool MKHNFDMIDFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6C80", Offset = "0x3DE5A80", VA = "0x183DE6C80")]
	public void OEEOKNNJFAO(Transform ILMCIJGNPKB, bool GNJOOBIAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6890", Offset = "0x3DE5690", VA = "0x183DE6890")]
	public bool KGKIHAGANBK(KPCAGAHCJHB JCGLGNAMOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7210", Offset = "0x3DE6010", VA = "0x183DE7210")]
	public ANCGNONLBKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EFONPPEFEEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<ANCGNONLBKH.BMKBKLKKHOL> IBMEICENMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BAKEIBOKOOD HEAFBLJKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<ANCGNONLBKH.BMKBKLKKHOL> JIGEEAMFJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int PEKFECENBMG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC020", Offset = "0x3DEAE20", VA = "0x183DEC020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC5B0", Offset = "0x3DEB3B0", VA = "0x183DEC5B0")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC090", Offset = "0x3DEAE90", VA = "0x183DEC090")]
	public void EFHDBFNBKGH(ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK, Transform ILMCIJGNPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC270", Offset = "0x3DEB070", VA = "0x183DEC270")]
	public void KGKIHAGANBK(ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC420", Offset = "0x3DEB220", VA = "0x183DEC420")]
	private ANCGNONLBKH.BMKBKLKKHOL LOAMGELEBIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC1E0", Offset = "0x3DEAFE0", VA = "0x183DEC1E0")]
	private bool ICGEOMCOCLG(ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC140", Offset = "0x3DEAF40", VA = "0x183DEC140")]
	private void EKJEDKGAADM(ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC1A0", Offset = "0x3DEAFA0", VA = "0x183DEC1A0")]
	public bool FFPNPEAFLJJ(ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBDD0", Offset = "0x3DEABD0", VA = "0x183DEBDD0")]
	public bool CNIMBBBDAOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC550", Offset = "0x3DEB350", VA = "0x183DEC550")]
	private ANCGNONLBKH.BMKBKLKKHOL MNKKELEDEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC630", Offset = "0x3DEB430", VA = "0x183DEC630")]
	public EFONPPEFEEM()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC67C20", Offset = "0xC66A20", VA = "0x180C67C20")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class INKDFBIOAAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BKPIOACCDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int GBBFJBKPBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float MPMCOFHGBAE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<ANCGNONLBKH> NNOBIHFCJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDED0", Offset = "0x3DECCD0", VA = "0x183DEDED0")]
	public INKDFBIOAAJ(int BKPIOACCDDN, int GBBFJBKPBGI, float DAOFGNPCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDBB0", Offset = "0x3DEC9B0", VA = "0x183DEDBB0")]
	public void JHBJKMNJEHH(HDDECDHGEHN OBDNJJGHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDE30", Offset = "0x3DECC30", VA = "0x183DEDE30")]
	private int OJBICCKIJDB(CICNFALMCGE JBDLAIAOJCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DED980", Offset = "0x3DEC780", VA = "0x183DED980")]
	private void JHBJKMNJEHH(CICNFALMCGE JBDLAIAOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DEDC50", Offset = "0x3DECA50", VA = "0x183DEDC50")]
	private void KPPBOIPNDBH(CICNFALMCGE JBDLAIAOJCN, ANCGNONLBKH LCNGJOFEBJI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, KPFPGGOODDC
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OAAFMABIKCP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C0C0", VA = "0x18089D2C0")]
			[DebuggerHidden]
			public OAAFMABIKCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3490", Offset = "0x3DF2290", VA = "0x183DF3490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3620", Offset = "0x3DF2420", VA = "0x183DF3620", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3580", Offset = "0x3DF2380", VA = "0x183DF3580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DF3580", Offset = "0x3DF2380", VA = "0x183DF3580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int GFGCNCBPPNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBB20", Offset = "0x3DEA920", VA = "0x183DEBB20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<IPDCIPDPFFD> OIMHNJNILCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBB00", Offset = "0x3DEA900", VA = "0x183DEBB00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> OAGMIGIKHKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4E94A0", Offset = "0x4E82A0", VA = "0x1804E94A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public ANCGNONLBKH OOAPAKOLCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public HICJMGGLOFA NNMDIAAPKOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4EA390", Offset = "0x4E9190", VA = "0x1804EA390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(HICJMGGLOFA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x67CC70", Offset = "0x67BA70", VA = "0x18067CC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool GEBAMCNDDCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBB10", Offset = "0x3DEA910", VA = "0x183DEBB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA840", Offset = "0x3DE9640", VA = "0x183DEA840")]
		public static ClusterMeshRenderer Create(ANCGNONLBKH LBIDBAEJDLB, ClusterMeshRenderer HEIHFKKDEHM, MeshFilter IPKNGMJFNAM, Transform ILMCIJGNPKB, HICJMGGLOFA BIHMJBCKDOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA950", Offset = "0x3DE9750", VA = "0x183DEA950", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB0B0", Offset = "0x3DE9EB0", VA = "0x183DEB0B0", Slot = "10")]
		public bool TryRemoveClusterLODComponent(KPCAGAHCJHB JCGLGNAMOPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAE80", Offset = "0x3DE9C80", VA = "0x183DEAE80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DEABB0", Offset = "0x3DE99B0", VA = "0x183DEABB0")]
		public void Init(ANCGNONLBKH LBIDBAEJDLB, MeshFilter IPKNGMJFNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA9B0", Offset = "0x3DE97B0", VA = "0x183DEA9B0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB1E0", Offset = "0x3DE9FE0", VA = "0x183DEB1E0", Slot = "8")]
		public void UpdateClusterDistances(Vector3 CCLGFGCMLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB420", Offset = "0x3DEA220", VA = "0x183DEB420", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAB40", Offset = "0x3DE9940", VA = "0x183DEAB40")]
		[IteratorStateMachine(typeof(OAAFMABIKCP))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAF00", Offset = "0x3DE9D00", VA = "0x183DEAF00")]
		public void SetupTagAndLayer(string MFALBPMFFCK, int BIHMJBCKDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAEE0", Offset = "0x3DE9CE0", VA = "0x183DEAEE0")]
		public bool Remove(KPCAGAHCJHB JCGLGNAMOPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC67C20", Offset = "0xC66A20", VA = "0x180C67C20")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IBJFBBFFIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int GLNDPFNOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DDMFICCMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int GNMIEBGHIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HNCJIBNGFMC;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3DED570", Offset = "0x3DEC370", VA = "0x183DED570")]
	public IBJFBBFFIME(int DDMFICCMNLL, int GNMIEBGHIIH, int GLNDPFNOKDF, int HNCJIBNGFMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMPNOCBDJEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> NPPECAEINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> CGGGMIHLIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> JFEFPJLHNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<IBJFBBFFIME> HLFLJAPDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> BFEPAIBNDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> DINBAPKOKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> KOJPPGJOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle FPBALMCKLGH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BEDLHACDLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x616980", Offset = "0x615780", VA = "0x180616980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6169A0", Offset = "0x6157A0", VA = "0x1806169A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8E60", Offset = "0x3DE7C60", VA = "0x183DE8E60")]
	public void BCNBLIENBGL(BPHOGJLMOEJ GGKLAIPBLLN, NativeList<IBJFBBFFIME> HLFLJAPDEOF, float HMFGGIMACNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9E40", Offset = "0x3DE8C40", VA = "0x183DE9E40")]
	public void MNCKJBGEBPJ(Transform ILMCIJGNPKB, bool GNJOOBIAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9CB0", Offset = "0x3DE8AB0", VA = "0x183DE9CB0")]
	public void GMIPEBMJALB(ANCGNONLBKH MKLINLGDHPN, bool MKHNFDMIDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9BE0", Offset = "0x3DE89E0", VA = "0x183DE9BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA090", Offset = "0x3DE8E90", VA = "0x183DEA090")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public BMPNOCBDJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct COIGDDAHNBA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> NPPECAEINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> CGGGMIHLIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<IBJFBBFFIME> CNBDPPBOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> BFEPAIBNDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 NEHIFDOIBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> DINBAPKOKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> KOJPPGJOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool GNJOOBIAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float PFPJGPCGEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float ALGMNEDAGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float IJNNGCEFGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> JFEFPJLHNBL;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA5E0", Offset = "0x3DE93E0", VA = "0x183DEA5E0")]
	public COIGDDAHNBA(BMPNOCBDJEN BOLCOPFMHJF, Vector3 NEHIFDOIBLP, bool GNJOOBIAOKG, float PFPJGPCGEOL, float ALGMNEDAGBL, float IJNNGCEFGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA140", Offset = "0x3DE8F40", VA = "0x183DEA140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KPCAGAHCJHB : KJPKDAMLGIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds KHDAJPHDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AAPODEOBBEG KGOAMHEECIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CICNFALMCGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<KPCAGAHCJHB> HCDPPCJLAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public CICNFALMCGE EBLJNNNHKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public CICNFALMCGE PKEBCEMHHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public CICNFALMCGE AILEPAMLGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int HNCJIBNGFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds NLBALGBILIE;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA0C0", Offset = "0x3DE8EC0", VA = "0x183DEA0C0")]
	public CICNFALMCGE(List<KPCAGAHCJHB> HCDPPCJLAFM, [Optional] CICNFALMCGE EBLJNNNHKDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HDDECDHGEHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<CICNFALMCGE> FOBGPADHBME;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CICNFALMCGE KAKHKOLAJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DED3E0", Offset = "0x3DEC1E0", VA = "0x183DED3E0")]
	public HDDECDHGEHN(CICNFALMCGE ILMCIJGNPKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PAOIDDPOLMA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PGAGIMEFMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int IHNNONGJDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int JMOLJPKBHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int GJMLNFIDIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int JDOHDBEIPLI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct ENCCMLEADDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int AEDAFCLIGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float AHDMLACBKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<KPCAGAHCJHB> HCDPPCJLAFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JGPHIFLGBDL
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
	private PGAGIMEFMNL LFOLNCLOLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int DHBIGJPIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int BKPIOACCDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GBBFJBKPBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float DAOFGNPCAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float NCAKLJIKBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<CICNFALMCGE> CCAKMFKCBDF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HDDECDHGEHN PLLDCHEEECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6CA0", Offset = "0x3DF5AA0", VA = "0x183DF6CA0")]
	public PAOIDDPOLMA(int BKPIOACCDDN, int GBBFJBKPBGI, float DAOFGNPCAFN, int DHBIGJPIKCP, float NCAKLJIKBIB = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6AE0", Offset = "0x3DF58E0", VA = "0x183DF6AE0")]
	public void NDNNJHEGOFO(List<KPCAGAHCJHB> HCDPPCJLAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6160", Offset = "0x3DF4F60", VA = "0x183DF6160")]
	public bool IJODDADDMEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DF50D0", Offset = "0x3DF3ED0", VA = "0x183DF50D0")]
	private float APDAAHLGFOL(Vector3 KPELLGFACNH, Vector3 GGDDBFGMJPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DF51E0", Offset = "0x3DF3FE0", VA = "0x183DF51E0")]
	private float APDAAHLGFOL(Vector3 AHCNLPEMKEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DF61D0", Offset = "0x3DF4FD0", VA = "0x183DF61D0")]
	private bool JJDLGHIANHN(CICNFALMCGE NGANFBHMPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5280", Offset = "0x3DF4080", VA = "0x183DF5280")]
	private ENCCMLEADDH CEMKMBCHEJD(List<KPCAGAHCJHB> LAILMHJPLOJ, JGPHIFLGBDL IIAKPALEDNP)
	{
		return default(ENCCMLEADDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5DD0", Offset = "0x3DF4BD0", VA = "0x183DF5DD0")]
	private void EFEEIDGHIOP(List<KPCAGAHCJHB> HCDPPCJLAFM, Vector3[] JFNCMLMFCIH, Vector3[] HPLEDFGLHDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OAOCAJNLBEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3670", Offset = "0x3DF2470", VA = "0x183DF3670")]
	public static Bounds MPLDIODCGIG(List<KPCAGAHCJHB> HCDPPCJLAFM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3820", Offset = "0x3DF2620", VA = "0x183DF3820")]
	public static int PJFMKOGOLPM(List<KPCAGAHCJHB> HCDPPCJLAFM, DMMEFAOHKAI KPEFNKLAHLE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BAKEIBOKOOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private BPHOGJLMOEJ AMKKAFOBMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BPHOGJLMOEJ GICGOHEFECI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static BPHOGJLMOEJ EGKOJDDKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private HIJMDDPKMDG MFIFENGMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private OFGFGEDIPGM LGIBOCGIBCG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle FPBALMCKLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x78CA00", Offset = "0x78B800", VA = "0x18078CA00")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x78CA20", Offset = "0x78B820", VA = "0x18078CA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ANCGNONLBKH.BMKBKLKKHOL NGANFBHMPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PMINONOAHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x698B90", Offset = "0x697990", VA = "0x180698B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7CA0", Offset = "0x3DE6AA0", VA = "0x183DE7CA0")]
	[JCLDHOBNPEL(PBHFHEIAOOM.ExitingPlayMode, 0)]
	private void LELKCFMIPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3DE72B0", Offset = "0x3DE60B0", VA = "0x183DE72B0")]
	public void BCNBLIENBGL(ANCGNONLBKH.BMKBKLKKHOL CNBDPPBOHEH, Transform LMLAPAAHGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7D10", Offset = "0x3DE6B10", VA = "0x183DE7D10")]
	public void MPGGPIDIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7C30", Offset = "0x3DE6A30", VA = "0x183DE7C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE82D0", Offset = "0x3DE70D0", VA = "0x183DE82D0")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8310", Offset = "0x3DE7110", VA = "0x183DE8310")]
	public BAKEIBOKOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LPJFCHFEGFN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	NDLKNPDGHPE KCCOCLPFDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LNFJMFLHKAB
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 KCIGIDKAPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CHHEHJMFAMI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EIJMPHDLAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HEOLLINJKGC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action IHCBPNIBOHO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BECMBNIGMIH
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BECMBNIGMIH HDKAJDOFAED(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BECMBNIGMIH EILHIEBIMKN(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BECMBNIGMIH FCFCAKBDMPK(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BECMBNIGMIH NJIPOJOIGJA(Action ILFANDGNKPL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class ICOHCHEAIDA : BECMBNIGMIH
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class HJKGKHOAAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public ICOHCHEAIDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
				public HJKGKHOAAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x3DED490", Offset = "0x3DEC290", VA = "0x183DED490")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x3DED4E0", Offset = "0x3DEC2E0", VA = "0x183DED4E0")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x3DED530", Offset = "0x3DEC330", VA = "0x183DED530")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> LNKEGGALEPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action FGGACLBGPHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action OEGOLKDKHAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NBCHBGKONFG FBLCDDCDHHD;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action BFJHKMPMFNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5120C0", Offset = "0x510EC0", VA = "0x1805120C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x5C4220", Offset = "0x5C3020", VA = "0x1805C4220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action CNIOMLLLIGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2955240", Offset = "0x2954040", VA = "0x182955240", Slot = "4")]
			public BECMBNIGMIH HDKAJDOFAED(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x28EB2D0", Offset = "0x28EA0D0", VA = "0x1828EB2D0", Slot = "5")]
			public BECMBNIGMIH EILHIEBIMKN(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2955260", Offset = "0x2954060", VA = "0x182955260", Slot = "6")]
			public BECMBNIGMIH FCFCAKBDMPK(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1522FC0", Offset = "0x1521DC0", VA = "0x181522FC0", Slot = "7")]
			public BECMBNIGMIH NJIPOJOIGJA(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5AB430", Offset = "0x5AA230", VA = "0x1805AB430")]
			public ICOHCHEAIDA(Func<JobHandle> KDBFDCHMAPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3DED590", Offset = "0x3DEC390", VA = "0x183DED590")]
			public void GLBDDOAKNLG(Action NJAAINNIEMB, Action HOGDOAFPDCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3DED7C0", Offset = "0x3DEC5C0", VA = "0x183DED7C0")]
			public void KGKIHAGANBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class JPKCKIBIPCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public BECMBNIGMIH jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public JPKCKIBIPCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDF20", Offset = "0x3DECD20", VA = "0x183DEDF20")]
			internal bool <Remove>b__0(ICOHCHEAIDA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class IMJGCFDLNEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public ICOHCHEAIDA newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public IMJGCFDLNEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3DED920", Offset = "0x3DEC720", VA = "0x183DED920")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<ICOHCHEAIDA> OGHDBIAOPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<ICOHCHEAIDA> ODCPPOEKFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private LKIEAODIPPJ KHCDAIJKKCJ;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDF30", Offset = "0x3DECD30", VA = "0x183DEDF30")]
		public BECMBNIGMIH Add(Func<JobHandle> KDBFDCHMAPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE1D0", Offset = "0x3DECFD0", VA = "0x183DEE1D0")]
		public void Remove(BECMBNIGMIH FPBALMCKLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE050", Offset = "0x3DECE50", VA = "0x183DEE050", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE350", Offset = "0x3DED150", VA = "0x183DEE350")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE520", Offset = "0x3DED320", VA = "0x183DEE520")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE040", Offset = "0x3DECE40", VA = "0x183DEE040")]
		[CompilerGenerated]
		private void BCPHPKGKFJO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NBCHBGKONFG
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBCHBGKONFG HDKAJDOFAED(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBCHBGKONFG NNPAABKNBMO(Action ILFANDGNKPL);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBCHBGKONFG NJIPOJOIGJA(Action ILFANDGNKPL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PBOILILHHDE : NBCHBGKONFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle IAAMBOLIHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action FGGACLBGPHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action FMDNEJGBHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action CNIOMLLLIGI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool IEDCFCACBJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x3DF6D00", Offset = "0x3DF5B00", VA = "0x183DF6D00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x28EB2D0", Offset = "0x28EA0D0", VA = "0x1828EB2D0", Slot = "4")]
			public NBCHBGKONFG HDKAJDOFAED(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2955260", Offset = "0x2954060", VA = "0x182955260", Slot = "5")]
			public NBCHBGKONFG NNPAABKNBMO(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1522FC0", Offset = "0x1521DC0", VA = "0x181522FC0", Slot = "6")]
			public NBCHBGKONFG NJIPOJOIGJA(Action ILFANDGNKPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xB534C0", Offset = "0xB522C0", VA = "0x180B534C0")]
			public PBOILILHHDE(JobHandle CBJGHNDPOBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3DF6D10", Offset = "0x3DF5B10", VA = "0x183DF6D10")]
			public void IGGCAGCIHAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3DF6D50", Offset = "0x3DF5B50", VA = "0x183DF6D50")]
			public void KGKIHAGANBK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<PBOILILHHDE> OJNEKJFDICB;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE9A0", Offset = "0x3DED7A0", VA = "0x183DEE9A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE5E0", Offset = "0x3DED3E0", VA = "0x183DEE5E0")]
		public NBCHBGKONFG Add(JobHandle CBJGHNDPOBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE8B0", Offset = "0x3DED6B0", VA = "0x183DEE8B0")]
		public void Remove(NBCHBGKONFG FPBALMCKLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE750", Offset = "0x3DED550", VA = "0x183DEE750", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE670", Offset = "0x3DED470", VA = "0x183DEE670")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEAB0", Offset = "0x3DED8B0", VA = "0x183DEEAB0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KBKCNEEIGLD
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] HKOBKFJLJAG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int ADAIBBEDLAL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int PDJAKEHAIFF;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger NCCPNIBEFHO;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	public KBKCNEEIGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF620", Offset = "0x3DEE420", VA = "0x183DEF620")]
	private static string PLNBGBJHHON(byte[] DPEJHFONKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF2F0", Offset = "0x3DEE0F0", VA = "0x183DEF2F0")]
	public static string GFPOJAMMFIA(byte[] EMAHDMOPMEP, bool FCMNFAHODMM)
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
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
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
