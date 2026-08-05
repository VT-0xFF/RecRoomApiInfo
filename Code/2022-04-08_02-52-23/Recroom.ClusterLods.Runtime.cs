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
				[Cpp2IlInjected.Address(RVA = "0x425E210", Offset = "0x425D010", VA = "0x18425E210")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0xCA5860", Offset = "0xCA4660", VA = "0x180CA5860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x425E1D0", Offset = "0x425CFD0", VA = "0x18425E1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4253580", Offset = "0x4252380", VA = "0x184253580")]
		public LODSettings DGFIKBKOELI(BIILLACIGHK DABPDAEJKAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4253560", Offset = "0x4252360", VA = "0x184253560")]
		public int BJNLKPNMKAN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4253590", Offset = "0x4252390", VA = "0x184253590")]
		public int OJHKBJJINGH(bool GGAFAOCJIEM, Vector3 FCGAONCLBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4253690", Offset = "0x4252490", VA = "0x184253690")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DFMGKKGHDMP
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
public interface PJGNJGJGMNK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBELMHOHHDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DGLFGACPCKD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KMOHMMMNDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IEnumerable<LGGCOLEEDMG> GJHGAIIMHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DFMGKKGHDMP FEHCJDNDKFM
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
	void UpdateClusterDistances(Vector3 GDKKMBGFNIB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(PFLLNHBIMOA OLNLGGPFPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LGGCOLEEDMG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HGLJFCEJLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int BOEAPIAMHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JMBIPCAAGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NNDBAPEDLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	byte ODMAHPBEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KAJJEBOMDKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum BMBNNDKAMLK
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
	private sealed class LMBDAMIFPAA : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KAJJEBOMDKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public LMBDAMIFPAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x425E0C0", Offset = "0x425CEC0", VA = "0x18425E0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x425E180", Offset = "0x425CF80", VA = "0x18425E180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PHPJOIHDKDD : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JBHCACLLONB <>2__current;

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
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public PHPJOIHDKDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x425F300", Offset = "0x425E100", VA = "0x18425F300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x425F450", Offset = "0x425E250", VA = "0x18425F450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CMIHNOAOMOA : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KAJJEBOMDKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IEnumerator<JBHCACLLONB> <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public CMIHNOAOMOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4252A10", Offset = "0x4251810", VA = "0x184252A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4253490", Offset = "0x4252290", VA = "0x184253490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NBGGMBEBNBK : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public KAJJEBOMDKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public NBGGMBEBNBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x425E250", Offset = "0x425D050", VA = "0x18425E250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x425F140", Offset = "0x425DF40", VA = "0x18425F140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const int GHOHBFHJCKF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ClusterMeshRenderer ENIMHGDNMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MeshFilter CBAFPIIKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GameObject EGNBHDAEIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject HIJLFHCADKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public AFFCHGGMLEF HCJMCDJGLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private List<PFLLNHBIMOA> HCHBABIGFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<PFLLNHBIMOA> PCEOODBLDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<PFLLNHBIMOA> PJCFECNLOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NGIDGECJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BMBNNDKAMLK KLGKLGOOCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<DGLFGACPCKD>[] BDEKGPEPAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<LGGCOLEEDMG>[] GDHPJFCMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private OIOIEKMKHHG JPILFLECPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private OIOIEKMKHHG JJBGFJNHEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private OIOIEKMKHHG AHCFGOFGOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int JOPGLPILNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int BFPDBPFPCFP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static KAJJEBOMDKE MJNEBAACEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NBMDKMGPDFI LJMLKGJEBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NPICPABBEGA OFJGKCPADKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MonoBehaviour KLNKLDIFCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Material DKHJFPDBLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<PJGNJGJGMNK> EELBCBLPKJC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ClusterLODConfig FCKOLCBKBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 CFNPAELNNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F12A50", Offset = "0x1F11850", VA = "0x181F12A50")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1F12970", Offset = "0x1F11770", VA = "0x181F12970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private BMBNNDKAMLK ANEECOPNHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x535CD0", Offset = "0x534AD0", VA = "0x180535CD0")]
		get
		{
			return default(BMBNNDKAMLK);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x425C1F0", Offset = "0x425AFF0", VA = "0x18425C1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KAJJEBOMDKE MHOGIHBANHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x425D100", Offset = "0x425BF00", VA = "0x18425D100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool ICMAPBHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x425BFD0", Offset = "0x425ADD0", VA = "0x18425BFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EHPMFOIJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x425C0F0", Offset = "0x425AEF0", VA = "0x18425C0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> BKNDCIMAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x425B130", Offset = "0x4259F30", VA = "0x18425B130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x425C150", Offset = "0x425AF50", VA = "0x18425C150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KCFOJMGBALH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x425C440", Offset = "0x425B240", VA = "0x18425C440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x425B770", Offset = "0x425A570", VA = "0x18425B770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x425D5F0", Offset = "0x425C3F0", VA = "0x18425D5F0")]
	public KAJJEBOMDKE(NBMDKMGPDFI LJMLKGJEBLD, NPICPABBEGA OFJGKCPADKD, ClusterLODConfig GPGOADCMNEH, MonoBehaviour KLNKLDIFCAK, Material DKHJFPDBLHF, ClusterMeshRenderer ENIMHGDNMHP, MeshFilter CBAFPIIKHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x425B560", Offset = "0x425A360", VA = "0x18425B560")]
	private void COKAFHONGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x425B810", Offset = "0x425A610", VA = "0x18425B810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x425D180", Offset = "0x425BF80", VA = "0x18425D180")]
	public static void NJFEJJHPMFI(Vector3 HELOKPCDMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x425B210", Offset = "0x425A010", VA = "0x18425B210")]
	private void BNCEEGEPMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x425B9A0", Offset = "0x425A7A0", VA = "0x18425B9A0")]
	private void EHGOAFLFKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x425B5F0", Offset = "0x425A3F0", VA = "0x18425B5F0")]
	private void DGJAOAPNFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x425BC90", Offset = "0x425AA90", VA = "0x18425BC90")]
	public void FHFFOAGMHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x425BF60", Offset = "0x425AD60", VA = "0x18425BF60")]
	[IteratorStateMachine(typeof(LMBDAMIFPAA))]
	private IEnumerator<JBHCACLLONB> GBAOJKPKFMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x425C050", Offset = "0x425AE50", VA = "0x18425C050")]
	[IteratorStateMachine(typeof(PHPJOIHDKDD))]
	private IEnumerator<JBHCACLLONB> GNHOLEPLCMC(Func<bool> HLGLPNKFAOI, float MNLAFBMAMBF, Func<string> PHONDEDHNCB, float ALPLOHHNIKO = 5f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x425C650", Offset = "0x425B450", VA = "0x18425C650")]
	[IteratorStateMachine(typeof(CMIHNOAOMOA))]
	private IEnumerator<JBHCACLLONB> LEAJFNPPGEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x425D3E0", Offset = "0x425C1E0", VA = "0x18425D3E0")]
	public void PEADMPEAJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x425C3C0", Offset = "0x425B1C0", VA = "0x18425C3C0")]
	public void KAAFLNKOLGL(IEnumerable<DGLFGACPCKD> AJEEBHKMBHL, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x425B2B0", Offset = "0x425A0B0", VA = "0x18425B2B0")]
	public void CBAMHIPHFNC(IEnumerable<DGLFGACPCKD> AJEEBHKMBHL, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x425C730", Offset = "0x425B530", VA = "0x18425C730")]
	public List<ClusterMeshRenderer> MANIAJJMPCC(List<PFLLNHBIMOA> HKIAIHNNBBP, Transform MIJPOFHLMNP, DFMGKKGHDMP CMHKFIGAEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x425B730", Offset = "0x425A530", VA = "0x18425B730")]
	public DFMGKKGHDMP DLAFEGNDHIG(Vector3 PLBODHHLLBD)
	{
		return default(DFMGKKGHDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x425B940", Offset = "0x425A740", VA = "0x18425B940")]
	public void EBCDGOIAJFO(PJGNJGJGMNK HKBOMGECNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x425D0A0", Offset = "0x425BEA0", VA = "0x18425D0A0")]
	public bool NFAPNBGKMKM(PJGNJGJGMNK HKBOMGECNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x425C320", Offset = "0x425B120", VA = "0x18425C320")]
	public void JKKEAOBPMBC(PFLLNHBIMOA CBIDGAANGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x425CFD0", Offset = "0x425BDD0", VA = "0x18425CFD0")]
	public void NBAFHEEKCAN(LGGCOLEEDMG HOHHDPMJFFP, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x425BC10", Offset = "0x425AA10", VA = "0x18425BC10")]
	public void ENIGOHGEMND(LGGCOLEEDMG HOHHDPMJFFP, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x425CEA0", Offset = "0x425BCA0", VA = "0x18425CEA0")]
	private void MCICNGGJMJB(Vector3 GDKKMBGFNIB, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x425C4E0", Offset = "0x425B2E0", VA = "0x18425C4E0")]
	private void KLBNPGNEDGG(Vector3 GDKKMBGFNIB, DFMGKKGHDMP CMHKFIGAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x425C6C0", Offset = "0x425B4C0", VA = "0x18425C6C0")]
	[IteratorStateMachine(typeof(NBGGMBEBNBK))]
	private IEnumerator<JBHCACLLONB> LIJLODBCKCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x425BAA0", Offset = "0x425A8A0", VA = "0x18425BAA0")]
	private int EIEDMOGHMJA(int IMDCPBGFCMD, int JNAHINHHNKB, List<LGGCOLEEDMG> GEOLOJLAJLB, byte DABPDAEJKAL, ref int BLCBFHPPMBF, float IDDBFFACJEA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x425D210", Offset = "0x425C010", VA = "0x18425D210")]
	public void OGCMIFMLPGF(PFLLNHBIMOA OLNLGGPFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x425C380", Offset = "0x425B180", VA = "0x18425C380")]
	public bool JLGFMACLMBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x634570", Offset = "0x633370", VA = "0x180634570")]
	public Material EAEIPFOMNDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x425B1D0", Offset = "0x4259FD0", VA = "0x18425B1D0")]
	public int BJNLKPNMKAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x425D050", Offset = "0x425BE50", VA = "0x18425D050")]
	[CompilerGenerated]
	private bool NEIGAFPDJDD()
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
		[Cpp2IlInjected.Address(RVA = "0x5CDBD0", Offset = "0x5CC9D0", VA = "0x1805CDBD0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct DDHIDKBBOFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeList<float3> DGCJPGGCJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<float3> GBOOPCPBCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<float4> FCMANFIGMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<float2> CPOHAHPODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NativeArray<float4> OBMIDEKIJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeList<int> HFMJOIPJGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private NativeList<float3> AJDHEDHCFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private float3 ECNGHIBNPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float AMLNFKANGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeMultiHashMap<int, int> PGDFMCHLDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> MDLAPMLOAEO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4255120", Offset = "0x4253F20", VA = "0x184255120")]
	public DDHIDKBBOFP(AAGPMNPENHB EAAEDGJDCOJ, NativeList<float3> AJDHEDHCFNF, NativeMultiHashMap<int, int> PGDFMCHLDDE, NativeArray<int> MDLAPMLOAEO, Vector3 ECNGHIBNPFA, float AMLNFKANGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x42550C0", Offset = "0x4253EC0", VA = "0x1842550C0")]
	private int NFKIEKGJHPO(float3 GDKKMBGFNIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4254A30", Offset = "0x4253830", VA = "0x184254A30")]
	private int DPOHNPKCNLK(int KOHLIKKCMDH, int IFKOMGEEEMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4254CD0", Offset = "0x4253AD0", VA = "0x184254CD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LJBDOBKNAAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static NativeMultiHashMap<int, int> PGDFMCHLDDE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static NativeArray<int> MDLAPMLOAEO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int MDNMFDBKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeList<int> MPPKILDCCDI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x425DF20", Offset = "0x425CD20", VA = "0x18425DF20")]
	public void KKHIONDNCIJ(int NPJBIEMGNFK, Allocator IAGLBGCBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x425DE70", Offset = "0x425CC70", VA = "0x18425DE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public LJBDOBKNAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KMNFMJIOBDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	public NativeList<int> LALDPMBJHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeList<int> HHMDJMJACDA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x425DC60", Offset = "0x425CA60", VA = "0x18425DC60")]
	public KMNFMJIOBDN(LJBDOBKNAAH JGFAMCNLMLE, AAGPMNPENHB EAAEDGJDCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x425DBD0", Offset = "0x425C9D0", VA = "0x18425DBD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile]
public struct GDPLPLAPENI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<float3> KBJCEGALCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private NativeArray<float3> OHKIMABPDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private NativeArray<float4> JBJEABNJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[ReadOnly]
	private NativeArray<float2> PNDLDLDAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<float4> MOPKMAJHOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeList<int> MPPKILDCCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeList<int> LALDPMBJHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeList<float3> GLFDNLDECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<float3> PPNGMHBMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<float4> OFNBLLDGELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<float4> OBAFOOOKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<float2> JLJLICOFAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private NativeList<int> KCALCCCLENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float AKEGFPNBNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	public float FGHLNNKBHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 OBDGAOEAIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[ReadOnly]
	private float LDNPHOBGOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ReadOnly]
	private float HDIPJMLFOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ReadOnly]
	public float OOFCIGONOCK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4257CF0", Offset = "0x4256AF0", VA = "0x184257CF0")]
	public GDPLPLAPENI(LJBDOBKNAAH BEAONJDFOIH, AAGPMNPENHB EAAEDGJDCOJ, AAGPMNPENHB HAOIGMGEKOI, float HDIPJMLFOKD, float OOFCIGONOCK, Vector3 OBDGAOEAIGO, float LDNPHOBGOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4256710", Offset = "0x4255510", VA = "0x184256710")]
	private float3 AKANBAOBLLK(int KOHLIKKCMDH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4257B10", Offset = "0x4256910", VA = "0x184257B10")]
	private void PCAIFAONBCM(int KOHLIKKCMDH, out float3 KMHPAGPGEHB, out float3 PHMLEAIDJLN, out float4 FOBAHCLJFDD, out float4 EIPPBOHAIKK, out float2 DMGEIEDBOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x42577E0", Offset = "0x42565E0", VA = "0x1842577E0")]
	private int OOAOACFLHCO(int CAIPAJDGBNN, int BPOHNIMBEAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x42567B0", Offset = "0x42555B0", VA = "0x1842567B0")]
	private void CLMICKEIPBJ(int CAIPAJDGBNN, int BPOHNIMBEAO, int ONOOMDMNCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4257570", Offset = "0x4256370", VA = "0x184257570")]
	private bool LBIOKAADNDP(int CAIPAJDGBNN, int BPOHNIMBEAO, float PBCBGKKPBJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4257720", Offset = "0x4256520", VA = "0x184257720")]
	private bool NOPOCCBFKMF(int CAIPAJDGBNN, int BPOHNIMBEAO, int ONOOMDMNCPC, float PBCBGKKPBJE, bool MAMCILMLHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4257310", Offset = "0x4256110", VA = "0x184257310")]
	private bool HFBFOKKMPIK(int CAIPAJDGBNN, int BPOHNIMBEAO, int ONOOMDMNCPC, float PBCBGKKPBJE, bool MAMCILMLHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4257700", Offset = "0x4256500", VA = "0x184257700")]
	private void NNMJHMOHMMK(int CAIPAJDGBNN, int BPOHNIMBEAO, int ONOOMDMNCPC, out int APNBMCMJNPI, out int AJPPLNJEPMO, out int LGAMHPCOEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42569B0", Offset = "0x42557B0", VA = "0x1842569B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CDPDKEMAPFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ILCNDEBJMFP : IDisposable, LGGCOLEEDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Bounds CDNDMGOKKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<PFLLNHBIMOA> HKIAIHNNBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 PJJGHDPJFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Vector3 BGNCMADNDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int HLPOLCCBKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AAGPMNPENHB KANEJHKFOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LJBDOBKNAAH MAGPJPCMOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Transform MIJPOFHLMNP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int MPHEPEIILEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4257E50", Offset = "0x4256C50", VA = "0x184257E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Mesh HJFNFBNLOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Mesh LLOADIGIBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x523010", Offset = "0x521E10", VA = "0x180523010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x523020", Offset = "0x521E20", VA = "0x180523020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMBIPCAAGPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1542A50", Offset = "0x1541850", VA = "0x181542A50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1542A90", Offset = "0x1541890", VA = "0x181542A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public byte ODMAHPBEHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D50", Offset = "0x5D5B50", VA = "0x1805D6D50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x76E4D0", Offset = "0x76D2D0", VA = "0x18076E4D0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HGLJFCEJLGI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7D02A0", Offset = "0x7CF0A0", VA = "0x1807D02A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x86A340", Offset = "0x869140", VA = "0x18086A340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BOEAPIAMHHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA51F60", Offset = "0xA50D60", VA = "0x180A51F60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x695740", Offset = "0x694540", VA = "0x180695740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float NNDBAPEDLAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4257E30", Offset = "0x4256C30", VA = "0x184257E30", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x42583C0", Offset = "0x42571C0", VA = "0x1842583C0")]
		public void ILMJMBNNCHM(BIILLACIGHK DABPDAEJKAL, out int DFEHDPDPCPD, out int DIGGHHHDOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x42585F0", Offset = "0x42573F0", VA = "0x1842585F0")]
		public void NIHAPHBHPHD(BIILLACIGHK DABPDAEJKAL, DOAMMKGGBFH EEIKMLKALFB, int DJMHAMCLDEI = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x42580A0", Offset = "0x4256EA0", VA = "0x1842580A0")]
		public void HCOINNDCHIC(NativeList<MPCNKBFIJDJ> LDFFLMGJJIB, Transform JFNACPNFFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4258790", Offset = "0x4257590", VA = "0x184258790")]
		public void OCFHAJPBFPF(Mesh EAAEDGJDCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4258000", Offset = "0x4256E00", VA = "0x184258000")]
		public void FHIDAGKCDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4257E90", Offset = "0x4256C90", VA = "0x184257E90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4258830", Offset = "0x4257630", VA = "0x184258830")]
		public ILCNDEBJMFP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Bounds CDNDMGOKKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public List<ILCNDEBJMFP> PLEFKBMMBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public BAPAEDJOFFO EPCBKDKOEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public ClusterMeshRenderer APPKCAMLICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int PLDJBDKJPFO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Mesh NLLDCFANJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54B0C0", Offset = "0x549EC0", VA = "0x18054B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x650410", Offset = "0x64F210", VA = "0x180650410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LCKPGJNFIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x698290", Offset = "0x697090", VA = "0x180698290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6982B0", Offset = "0x6970B0", VA = "0x1806982B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int KMOHMMMNDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4250FE0", Offset = "0x424FDE0", VA = "0x184250FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4251030", Offset = "0x424FE30", VA = "0x184251030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4251A60", Offset = "0x4250860", VA = "0x184251A60")]
	public int KCLAIFEAHEC(int HAOHNMMCGDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4251190", Offset = "0x424FF90", VA = "0x184251190")]
	public void EBAIFCGFAIO(CNHPCCNOPMD LDLNBFHGNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4251A90", Offset = "0x4250890", VA = "0x184251A90")]
	public void NMBECOJJOMF(Transform JFNACPNFFCD, bool CEPNJOFMHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x42518B0", Offset = "0x42506B0", VA = "0x1842518B0")]
	public bool GIOMFNANOKE(bool BNBMLPPMBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4251320", Offset = "0x4250120", VA = "0x184251320")]
	public void EKKJEFJGLGF(Transform MIJPOFHLMNP, bool CEPNJOFMHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x42521A0", Offset = "0x4250FA0", VA = "0x1842521A0")]
	public bool OGCMIFMLPGF(PFLLNHBIMOA OLNLGGPFPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4252400", Offset = "0x4251200", VA = "0x184252400")]
	public CDPDKEMAPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AFFCHGGMLEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<CDPDKEMAPFF.ILCNDEBJMFP> OHJGMOBCCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private EHNNJPIFJAF JDPIGFNBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<CDPDKEMAPFF.ILCNDEBJMFP> NLLLJDFGAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int GAECPLLDNAB;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x424EE90", Offset = "0x424DC90", VA = "0x18424EE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x424EF40", Offset = "0x424DD40", VA = "0x18424EF40")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x424F3A0", Offset = "0x424E1A0", VA = "0x18424F3A0")]
	public void NGPIMMKGFMI(CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD, Transform MIJPOFHLMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x424F4E0", Offset = "0x424E2E0", VA = "0x18424F4E0")]
	public void OGCMIFMLPGF(CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x424F270", Offset = "0x424E070", VA = "0x18424F270")]
	private CDPDKEMAPFF.ILCNDEBJMFP LJFHHGCEBNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x424F450", Offset = "0x424E250", VA = "0x18424F450")]
	private bool OCNBAGCGKHO(CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x424F210", Offset = "0x424E010", VA = "0x18424F210")]
	private void KDLADNBKALM(CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x424EF00", Offset = "0x424DD00", VA = "0x18424EF00")]
	public bool FAEEBPEBFAN(CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x424EFC0", Offset = "0x424DDC0", VA = "0x18424EFC0")]
	public bool IFLCLMJCIDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x424EE30", Offset = "0x424DC30", VA = "0x18424EE30")]
	private CDPDKEMAPFF.ILCNDEBJMFP CFGKLMDCOCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x424F690", Offset = "0x424E490", VA = "0x18424F690")]
	public AFFCHGGMLEF()
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBD0", Offset = "0x5CC9D0", VA = "0x1805CDBD0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class APJICEIDMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int KPEAMOMIGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int CAJKIJLJNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float OIFPPOODPPC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<CDPDKEMAPFF> KFEDCJLNLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x424FD30", Offset = "0x424EB30", VA = "0x18424FD30")]
	public APJICEIDMHM(int KPEAMOMIGMP, int CAJKIJLJNCJ, float DBOLOACCOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x424FA10", Offset = "0x424E810", VA = "0x18424FA10")]
	public void EKNFLFBDBBB(ENANEDAHJCL DJBJOFNOBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x424FC90", Offset = "0x424EA90", VA = "0x18424FC90")]
	private int PFAIPNDBCCC(CNHPCCNOPMD OBJPKPCAKNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x424F7E0", Offset = "0x424E5E0", VA = "0x18424F7E0")]
	private void EKNFLFBDBBB(CNHPCCNOPMD OBJPKPCAKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x424FAB0", Offset = "0x424E8B0", VA = "0x18424FAB0")]
	private void NHMCLMHAMBD(CNHPCCNOPMD OBJPKPCAKNL, CDPDKEMAPFF DDMHNCFLDFB)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ClusterMeshRenderer : MonoBehaviour, DGLFGACPCKD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LDLMDABEGOE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
			[DebuggerHidden]
			public LDLMDABEGOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x425DC90", Offset = "0x425CA90", VA = "0x18425DC90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x425DE20", Offset = "0x425CC20", VA = "0x18425DE20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x425DD80", Offset = "0x425CB80", VA = "0x18425DD80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x425DD80", Offset = "0x425CB80", VA = "0x18425DD80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int KMOHMMMNDFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x42549D0", Offset = "0x42537D0", VA = "0x1842549D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IEnumerable<LGGCOLEEDMG> GJHGAIIMHGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x42549B0", Offset = "0x42537B0", VA = "0x1842549B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public List<MeshFilter> PLEFKBMMBND
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public CDPDKEMAPFF NLLDCFANJLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public DFMGKKGHDMP FEHCJDNDKFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x523390", Offset = "0x522190", VA = "0x180523390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(DFMGKKGHDMP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x688BD0", Offset = "0x6879D0", VA = "0x180688BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IECHLLHMNKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x42549C0", Offset = "0x42537C0", VA = "0x1842549C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x42536F0", Offset = "0x42524F0", VA = "0x1842536F0")]
		public static ClusterMeshRenderer Create(CDPDKEMAPFF EAAEDGJDCOJ, ClusterMeshRenderer ENIMHGDNMHP, MeshFilter CBAFPIIKHAK, Transform MIJPOFHLMNP, DFMGKKGHDMP CMHKFIGAEOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4253800", Offset = "0x4252600", VA = "0x184253800", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4253F60", Offset = "0x4252D60", VA = "0x184253F60", Slot = "10")]
		public bool TryRemoveClusterLODComponent(PFLLNHBIMOA OLNLGGPFPEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4253D30", Offset = "0x4252B30", VA = "0x184253D30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4253A60", Offset = "0x4252860", VA = "0x184253A60")]
		public void Init(CDPDKEMAPFF EAAEDGJDCOJ, MeshFilter CBAFPIIKHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4253860", Offset = "0x4252660", VA = "0x184253860")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4254090", Offset = "0x4252E90", VA = "0x184254090", Slot = "8")]
		public void UpdateClusterDistances(Vector3 GDKKMBGFNIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x42542D0", Offset = "0x42530D0", VA = "0x1842542D0", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x42539F0", Offset = "0x42527F0", VA = "0x1842539F0")]
		[IteratorStateMachine(typeof(LDLMDABEGOE))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4253DB0", Offset = "0x4252BB0", VA = "0x184253DB0")]
		public void SetupTagAndLayer(string DGDNBGHIHJL, int CMHKFIGAEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4253D90", Offset = "0x4252B90", VA = "0x184253D90")]
		public bool Remove(PFLLNHBIMOA OLNLGGPFPEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBD0", Offset = "0x5CC9D0", VA = "0x1805CDBD0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MHBBJIGJOHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int CALHDGOEFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int CHMJDGBLLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int DIGGHHHDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int DFEHDPDPCPD;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x425E230", Offset = "0x425D030", VA = "0x18425E230")]
	public MHBBJIGJOHL(int CHMJDGBLLOG, int DIGGHHHDOBM, int CALHDGOEFIC, int DFEHDPDPCPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BAPAEDJOFFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public NativeList<float3> DGCJPGGCJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public NativeList<int> MPPKILDCCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public NativeList<int> HFMJOIPJGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<MHBBJIGJOHL> NNKJFPMENIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<int> FIFDDKPOMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float3> AKEHOEBEJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float> BJDHNNMCKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public JobHandle MOALDDBNAFG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FKCJFLILBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7190", Offset = "0x5E5F90", VA = "0x1805E7190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x842290", Offset = "0x841090", VA = "0x180842290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x424FD80", Offset = "0x424EB80", VA = "0x18424FD80")]
	public void CAKGGANFDAA(AAGPMNPENHB NKBNGBLEIOJ, NativeList<MHBBJIGJOHL> NNKJFPMENIF, float PMOEONHENGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4250BD0", Offset = "0x424F9D0", VA = "0x184250BD0")]
	public void EAHIGHBDIJP(Transform MIJPOFHLMNP, bool CEPNJOFMHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4250E20", Offset = "0x424FC20", VA = "0x184250E20")]
	public void GIOMFNANOKE(CDPDKEMAPFF APPKCAMLICI, bool BNBMLPPMBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4250B00", Offset = "0x424F900", VA = "0x184250B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4250FB0", Offset = "0x424FDB0", VA = "0x184250FB0")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BAPAEDJOFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
public struct CJKGCBNEDHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private NativeList<float3> DGCJPGGCJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ReadOnly]
	public NativeList<int> MPPKILDCCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ReadOnly]
	private NativeList<MHBBJIGJOHL> BNNLLLANHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	private NativeArray<int> FIFDDKPOMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private float3 OBDGAOEAIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> AKEHOEBEJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeArray<float> BJDHNNMCKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private bool CEPNJOFMHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float AEBGMFPGONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private float BHOOJEDPAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private float HNOHDDGCHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeList<int> HFMJOIPJGBD;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4252940", Offset = "0x4251740", VA = "0x184252940")]
	public CJKGCBNEDHP(BAPAEDJOFFO LPAOMLAIDEJ, Vector3 OBDGAOEAIGO, bool CEPNJOFMHKJ, float AEBGMFPGONG, float BHOOJEDPAIM, float HNOHDDGCHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x42524A0", Offset = "0x42512A0", VA = "0x1842524A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PFLLNHBIMOA : FJCHKHMHAGE
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Bounds GDPIFJJGKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MPCNKBFIJDJ NFMBNLLIAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CNHPCCNOPMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public List<PFLLNHBIMOA> HKIAIHNNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public CNHPCCNOPMD ABHIDEANEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public CNHPCCNOPMD DAHHCFFDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public CNHPCCNOPMD IJLBFOEPEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public int DFEHDPDPCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Bounds CDNDMGOKKHO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x42534E0", Offset = "0x42522E0", VA = "0x1842534E0")]
	public CNHPCCNOPMD(List<PFLLNHBIMOA> HKIAIHNNBBP, [Optional] CNHPCCNOPMD ABHIDEANEGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ENANEDAHJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public List<CNHPCCNOPMD> DLFBGCGIJHO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CNHPCCNOPMD IBMKHGGBBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4256660", Offset = "0x4255460", VA = "0x184256660")]
	public ENANEDAHJCL(CNHPCCNOPMD MIJPOFHLMNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JEHDCMOLJIA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct FOKCEFHDGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int CHOMPPENDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int LPGMBIKDFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int KBOJPKJNKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int IKGFAAMMDFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DGACGOKAHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int HLLKPBNMKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float CDPAEFHCKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<PFLLNHBIMOA> HKIAIHNNBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum GDJABNAAHLO
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
	private FOKCEFHDGAB IDLPPFOECGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int AFOPEJFFHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int KPEAMOMIGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int CAJKIJLJNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private float DBOLOACCOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float MLPHKGFHFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Stack<CNHPCCNOPMD> IBAKNPIAGKN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ENANEDAHJCL BIMJGHNEFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x425A4C0", Offset = "0x42592C0", VA = "0x18425A4C0")]
	public JEHDCMOLJIA(int KPEAMOMIGMP, int CAJKIJLJNCJ, float DBOLOACCOMJ, int AFOPEJFFHID, float MLPHKGFHFIO = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x425A290", Offset = "0x4259090", VA = "0x18425A290")]
	public void MCOJJKKHOCD(List<PFLLNHBIMOA> HKIAIHNNBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x425A450", Offset = "0x4259250", VA = "0x18425A450")]
	public bool MKMADOJAFEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4259200", Offset = "0x4258000", VA = "0x184259200")]
	private float IOEMAPPPENH(Vector3 GJMMLPKFABI, Vector3 IPDCECLMOMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4259310", Offset = "0x4258110", VA = "0x184259310")]
	private float IOEMAPPPENH(Vector3 ILOELBIABFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x42588F0", Offset = "0x42576F0", VA = "0x1842588F0")]
	private bool IBLJNFFHECA(CNHPCCNOPMD DJKIHOELKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x42593B0", Offset = "0x42581B0", VA = "0x1842593B0")]
	private DGACGOKAHAG KFFMGKHDGJI(List<PFLLNHBIMOA> HFEMHBFDKLL, GDJABNAAHLO HBDOEGBOCAC)
	{
		return default(DGACGOKAHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4259F00", Offset = "0x4258D00", VA = "0x184259F00")]
	private void LPGBKJEKOMI(List<PFLLNHBIMOA> HKIAIHNNBBP, Vector3[] LPFEBLNFBKC, Vector3[] GBAMBJILACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ABJEMIFIEGG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x424EC80", Offset = "0x424DA80", VA = "0x18424EC80")]
	public static Bounds BJKLHBPMBAO(List<PFLLNHBIMOA> HKIAIHNNBBP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x424EAF0", Offset = "0x424D8F0", VA = "0x18424EAF0")]
	public static int AHKDFANCECL(List<PFLLNHBIMOA> HKIAIHNNBBP, BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EHNNJPIFJAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AAGPMNPENHB DDODPIFGPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AAGPMNPENHB LGNMPODHGPN;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static AAGPMNPENHB KBPHIIHDBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JHOPPNABKFG ECJHBGMGEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private DOAMMKGGBFH EEIKMLKALFB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JobHandle MOALDDBNAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C6390", Offset = "0x5C5190", VA = "0x1805C6390")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA1CB20", Offset = "0xA1B920", VA = "0x180A1CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CDPDKEMAPFF.ILCNDEBJMFP DJKIHOELKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MGNDJGICFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x946700", Offset = "0x945500", VA = "0x180946700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4256560", Offset = "0x4255360", VA = "0x184256560")]
	[LNPBCMJNPOF(KMPCCFGDDMG.ExitingPlayMode, 0)]
	private void NLLOPHHMEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4255570", Offset = "0x4254370", VA = "0x184255570")]
	public void CAKGGANFDAA(CDPDKEMAPFF.ILCNDEBJMFP BNNLLLANHNI, Transform CKLEJIBDAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4255FA0", Offset = "0x4254DA0", VA = "0x184255FA0")]
	public void KCGNEAKOPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4255EF0", Offset = "0x4254CF0", VA = "0x184255EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4255F60", Offset = "0x4254D60", VA = "0x184255F60")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x42565D0", Offset = "0x42553D0", VA = "0x1842565D0")]
	public EHNNJPIFJAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CHEHAGHGEIC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KAJJEBOMDKE JAPCEIDHNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NPICPABBEGA
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Vector3 EEDGBGMOCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NBMDKMGPDFI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool PBECELMKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ONFBAJGKCBL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action LKBMGCLEKMM;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BNFLPJDHPPI
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BNFLPJDHPPI HGLDIIEOABP(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNFLPJDHPPI ABPEOKFGLLG(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BNFLPJDHPPI PHKBBJBMJMF(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNFLPJDHPPI IGGJMOPALHD(Action DIKCECEKHKC);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private class DIGHGLCKNAE : BNFLPJDHPPI
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			[CompilerGenerated]
			private sealed class PDPGALLCPOD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public DIGHGLCKNAE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public PDPGALLCPOD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x425F220", Offset = "0x425E020", VA = "0x18425F220")]
				internal void <Run>b__0()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x425F270", Offset = "0x425E070", VA = "0x18425F270")]
				internal void <Run>b__1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x425F2C0", Offset = "0x425E0C0", VA = "0x18425F2C0")]
				internal void <Run>b__2()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private Func<JobHandle> HCKJKGBINKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private Action MPFKPLGEKKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private Action EFPFKAKFLFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private KAPJPFLJKJO ELOADFFJMFI;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public Action IOFMBMGGNMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x54B0C0", Offset = "0x549EC0", VA = "0x18054B0C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x650410", Offset = "0x64F210", VA = "0x180650410")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public Action NEJMCKMGCKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9E6A00", Offset = "0x9E5800", VA = "0x1809E6A00", Slot = "4")]
			public BNFLPJDHPPI HGLDIIEOABP(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x977220", Offset = "0x976020", VA = "0x180977220", Slot = "5")]
			public BNFLPJDHPPI ABPEOKFGLLG(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9E6A20", Offset = "0x9E5820", VA = "0x1809E6A20", Slot = "6")]
			public BNFLPJDHPPI PHKBBJBMJMF(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9E6AF0", Offset = "0x9E58F0", VA = "0x1809E6AF0", Slot = "7")]
			public BNFLPJDHPPI IGGJMOPALHD(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x593550", Offset = "0x592350", VA = "0x180593550")]
			public DIGHGLCKNAE(Func<JobHandle> LFIELFDNMDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x42551E0", Offset = "0x4253FE0", VA = "0x1842551E0")]
			public void NBOIKDEMCMI(Action DPLNIJMFPPC, Action MHHMBHBLCOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4255410", Offset = "0x4254210", VA = "0x184255410")]
			public void OGCMIFMLPGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class AOOBGPGCJDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public BNFLPJDHPPI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public AOOBGPGCJDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x424F7D0", Offset = "0x424E5D0", VA = "0x18424F7D0")]
			internal bool <Remove>b__0(DIGHGLCKNAE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class KIGLNAHEKJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public DIGHGLCKNAE newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public KIGLNAHEKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x425DB70", Offset = "0x425C970", VA = "0x18425DB70")]
			internal void <ScheduleQueuedJobs>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Queue<DIGHGLCKNAE> NOCKMGCIEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private List<DIGHGLCKNAE> PDGEGIMAADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private OIOIEKMKHHG JGLBKOAMNEK;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x425A520", Offset = "0x4259320", VA = "0x18425A520")]
		public BNFLPJDHPPI Add(Func<JobHandle> LFIELFDNMDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x425A7C0", Offset = "0x42595C0", VA = "0x18425A7C0")]
		public void Remove(BNFLPJDHPPI MOALDDBNAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x425A640", Offset = "0x4259440", VA = "0x18425A640", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x425A940", Offset = "0x4259740", VA = "0x18425A940")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x425AB10", Offset = "0x4259910", VA = "0x18425AB10")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x425A630", Offset = "0x4259430", VA = "0x18425A630")]
		[CompilerGenerated]
		private void FDMICJOIKMJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KAPJPFLJKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KAPJPFLJKJO HGLDIIEOABP(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KAPJPFLJKJO IAJGBBCNDBJ(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KAPJPFLJKJO IGGJMOPALHD(Action DIKCECEKHKC);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class NGHIAOAKPBI : KAPJPFLJKJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JobHandle JDNPEGPNAIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private Action MPFKPLGEKKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private Action BJMGHEOIKKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private Action NEJMCKMGCKA;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool OMCHJFIANBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x425F1D0", Offset = "0x425DFD0", VA = "0x18425F1D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x977220", Offset = "0x976020", VA = "0x180977220", Slot = "4")]
			public KAPJPFLJKJO HGLDIIEOABP(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6A20", Offset = "0x9E5820", VA = "0x1809E6A20", Slot = "5")]
			public KAPJPFLJKJO IAJGBBCNDBJ(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6AF0", Offset = "0x9E58F0", VA = "0x1809E6AF0", Slot = "6")]
			public KAPJPFLJKJO IGGJMOPALHD(Action DIKCECEKHKC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1496BC0", Offset = "0x14959C0", VA = "0x181496BC0")]
			public NGHIAOAKPBI(JobHandle PNOIBKDOPAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x425F190", Offset = "0x425DF90", VA = "0x18425F190")]
			public void ALCOILIHPJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x425F1E0", Offset = "0x425DFE0", VA = "0x18425F1E0")]
			public void OGCMIFMLPGF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<NGHIAOAKPBI> HGNMPBFNKGM;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x425AF90", Offset = "0x4259D90", VA = "0x18425AF90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x425ABD0", Offset = "0x42599D0", VA = "0x18425ABD0")]
		public KAPJPFLJKJO Add(JobHandle PNOIBKDOPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x425AEA0", Offset = "0x4259CA0", VA = "0x18425AEA0")]
		public void Remove(KAPJPFLJKJO MOALDDBNAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x425AD40", Offset = "0x4259B40", VA = "0x18425AD40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x425AC60", Offset = "0x4259A60", VA = "0x18425AC60")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x425B0A0", Offset = "0x4259EA0", VA = "0x18425B0A0")]
		public JobTracker()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x425F4A0", Offset = "0x425E2A0", VA = "0x18425F4A0")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x425F5A0", Offset = "0x425E3A0", VA = "0x18425F5A0")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
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
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
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
