using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Pools;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Header("Impact Particle System")]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Header("Impact Particle Start Lifetime")]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[Header("Spray Particle System")]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Header("Spray Particle Burst Count")]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F03EA0", Offset = "0x6F024A0", VA = "0x186F03EA0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LMLNLGDAFGM, float LOELNHKGCOC, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F03CA0", Offset = "0x6F022A0", VA = "0x186F03CA0")]
		public void SetDamageValue(float LOELNHKGCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F04030", Offset = "0x6F02630", VA = "0x186F04030")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static PersistentGlobalPool LNAMEKLDEPH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static GameObject ABFGMKBGCJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PersistentGlobalPool HAMPJMKDJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6F03B10", Offset = "0x6F02110", VA = "0x186F03B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F03A40", Offset = "0x6F02040", VA = "0x186F03A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F027C0", Offset = "0x6F00DC0", VA = "0x186F027C0")]
		public PersistentGlobalPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LENLEHAPHEB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KDGGCAEAIHE(PooledParticle.HMEACDOHCBL ILLGCEENAAK);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum JDOPJHPMODD
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum HMEACDOHCBL
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public interface ALCGDPJJABJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool PJLGOABJBKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			Vector3 MBIKBPOEIPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			Camera DEKIKPAJMPO
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F01D30", Offset = "0x6F00330", VA = "0x186F01D30")]
			public ColorConfiguration(ParticleSystem COPIBHMICGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F01B20", Offset = "0x6F00120", VA = "0x186F01B20")]
			public void FBCGGPPNCPF(Color CMDNLIJPJJE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PBNHKDFAJFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public PBNHKDFAJFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F03A10", Offset = "0x6F02010", VA = "0x186F03A10")]
			internal void LLECMHBDACI(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OKCFDKIKDOB : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private FOLOHDFBANO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private ALCGDPJJABJ <dependencies>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private Stopwatch <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private Plane[] <frustumPlanes>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private Vector3 <playerPosition>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private Camera <cam>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int <enabledCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private List<PooledParticle>.Enumerator <>s__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private PooledParticle <pooledParticle>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Bounds <particleSystemBounds>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int <i>5__10;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public OKCFDKIKDOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F02D40", Offset = "0x6F01340", VA = "0x186F02D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F03450", Offset = "0x6F01A50", VA = "0x186F03450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HHBCKBLJFBB : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private FOLOHDFBANO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public HHBCKBLJFBB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F02920", Offset = "0x6F00F20", VA = "0x186F02920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F02990", Offset = "0x6F00F90", VA = "0x186F02990", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> PAFOOFMFIFH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly Lazy<LENLEHAPHEB> EDNFJHNABKH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static List<PooledParticle> DECELKLDJBO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static BDPNFFCBKDC IIBAMANDMPG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const float HIAPKMEBOKM = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static bool EPDBLPKMAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected int NFAEAMMCNHN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private HMEACDOHCBL category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ParticleSystem.MinMaxGradient[] IOBNFPLFCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool CDHPPMKFFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float KDAECNKECJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float CGOLECGICJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Transform CONDPNNOAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 LAOEHDDGNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 FBEKAFILECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JDOPJHPMODD EPJNABDONDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private BDPNFFCBKDC IGONAEHMFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		protected bool NEGCKBAILMF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IEnumerable<PooledParticle> PBEMIIHECCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F07750", Offset = "0x6F05D50", VA = "0x186F07750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HMEACDOHCBL MPAKAIAJBMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA59820", Offset = "0xA57E20", VA = "0x180A59820")]
			get
			{
				return default(HMEACDOHCBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AHBCDIADNNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLMOFFAFBKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F07440", Offset = "0x6F05A40", VA = "0x186F07440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static int CLDGMBLIAGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F075D0", Offset = "0x6F05BD0", VA = "0x186F075D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static bool FNMGPFHOMBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F04CA0", Offset = "0x6F032A0", VA = "0x186F04CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ParticleSystem KKCCONAIGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ParticleSystem[] HCHDNDMDGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private ParticleSystemRenderer[] NGIFFALKFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private JDOPJHPMODD BJLJLKEFHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xDCF470", Offset = "0xDCDA70", VA = "0x180DCF470")]
			get
			{
				return default(JDOPJHPMODD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F04C80", Offset = "0x6F03280", VA = "0x186F04C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FBKLNNJHHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F073A0", Offset = "0x6F059A0", VA = "0x186F073A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F077B0", Offset = "0x6F05DB0", VA = "0x186F077B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F06F20", Offset = "0x6F05520", VA = "0x186F06F20")]
		public static PooledParticle TryPlayPrefab(PooledParticle LMLNLGDAFGM, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F06D60", Offset = "0x6F05360", VA = "0x186F06D60")]
		public static PooledParticle TryPlayPrefab(PooledParticle LMLNLGDAFGM, Vector3 POOFJFBIOJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F065A0", Offset = "0x6F04BA0", VA = "0x186F065A0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F04120", Offset = "0x6F02720", VA = "0x186F04120")]
		private void ALCDCIINBJH(bool GKJOEINIIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F04EB0", Offset = "0x6F034B0", VA = "0x186F04EB0")]
		[IteratorStateMachine(typeof(OKCFDKIKDOB))]
		private static IEnumerator<FOLOHDFBANO> KBBJGPALIOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F05700", Offset = "0x6F03D00", VA = "0x186F05700")]
		private static void NMGDJMGMAPH(Stopwatch MHKBFIBGEFP, Vector3 NCEIFGHPNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F04640", Offset = "0x6F02C40", VA = "0x186F04640")]
		private static int BLNAHGIOHJK(PooledParticle MBOGNALMNPH, PooledParticle NDCLMFPKHPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F04F00", Offset = "0x6F03500", VA = "0x186F04F00")]
		private static int KDGGCAEAIHE(HMEACDOHCBL ILLGCEENAAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F04200", Offset = "0x6F02800", VA = "0x186F04200")]
		protected void AMNCACLLJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F046F0", Offset = "0x6F02CF0", VA = "0x186F046F0")]
		protected void CHAENOAOFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F04400", Offset = "0x6F02A00", VA = "0x186F04400", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F052C0", Offset = "0x6F038C0", VA = "0x186F052C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F05A90", Offset = "0x6F04090", VA = "0x186F05A90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F05B10", Offset = "0x6F04110", VA = "0x186F05B10")]
		[IteratorStateMachine(typeof(HHBCKBLJFBB))]
		private IEnumerator<FOLOHDFBANO> PJKGPAKHDDM(float NJGFFBPLEDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F04D30", Offset = "0x6F03330", VA = "0x186F04D30")]
		private void GIBKAEADFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F06B70", Offset = "0x6F05170", VA = "0x186F06B70")]
		public void SetDuration(float NJGFFBPLEDK, bool IGLDMOOIFFM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F06280", Offset = "0x6F04880", VA = "0x186F06280")]
		public void Play(Transform DFPKCMNMGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F05C60", Offset = "0x6F04260", VA = "0x186F05C60")]
		public void Play(Transform DFPKCMNMGGA, bool FLHCNKCPOPK, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F05DB0", Offset = "0x6F043B0", VA = "0x186F05DB0")]
		public void Play(Transform DFPKCMNMGGA, Vector3 FBEKAFILECL, bool FLHCNKCPOPK, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F06030", Offset = "0x6F04630", VA = "0x186F06030")]
		public void Play(Transform PMOLFMLDLHC, Quaternion MEHKCJCIOOL, bool FLHCNKCPOPK = false, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F05F00", Offset = "0x6F04500", VA = "0x186F05F00")]
		public void Play(Transform PMOLFMLDLHC, Vector3 FBEKAFILECL, Quaternion MEHKCJCIOOL, bool FLHCNKCPOPK = false, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F05B90", Offset = "0x6F04190", VA = "0x186F05B90")]
		public void Play(Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, Vector3 KEMGHPMICGF, bool FLHCNKCPOPK = false, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F063C0", Offset = "0x6F049C0", VA = "0x186F063C0")]
		public void Play(Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, bool FLHCNKCPOPK = false, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F06170", Offset = "0x6F04770", VA = "0x186F06170")]
		public void Play(bool FLHCNKCPOPK = false, float BKPIEGLIIHK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F06CD0", Offset = "0x6F052D0", VA = "0x186F06CD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F06C40", Offset = "0x6F05240", VA = "0x186F06C40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F05570", Offset = "0x6F03B70", VA = "0x186F05570")]
		private void NJKDNGDMMMP(float NJGFFBPLEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F05010", Offset = "0x6F03610", VA = "0x186F05010")]
		private void KLCIJEOCDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F06480", Offset = "0x6F04A80", VA = "0x186F06480")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F06760", Offset = "0x6F04D60", VA = "0x186F06760")]
		public void SetColor(Color CMDNLIJPJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F05180", Offset = "0x6F03780", VA = "0x186F05180")]
		private void LKCNICJNHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F07300", Offset = "0x6F05900", VA = "0x186F07300")]
		public PooledParticle()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ANHFNBKPCKN<T> : MFBKDKPGMNP<T>, HHGLIBCDIDA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MNMLOBHHOIP<T> : HHGLIBCDIDA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CDOIGJCLPCD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GJJELMBHOAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class OOEHCNMIMMG<T> : FIKNOBAKBJH<T>, ANHFNBKPCKN<T>, MFBKDKPGMNP<T>, HHGLIBCDIDA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FCAJIJPELEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public OOEHCNMIMMG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public FCAJIJPELEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x49D42D0", Offset = "0x49D28D0", VA = "0x1849D42D0")]
			internal void JBOBNDEBFPJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x17B5580", Offset = "0x17B3B80", VA = "0x1817B5580")]
			internal void NIFFGBFKJBC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private GNLDNMJDMJM<T> ONJKCFCNFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ObjectPool BOOPGKKHPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private T DFKGLOBLDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool IBKDBEFOCFL;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2917B90", Offset = "0x2916190", VA = "0x182917B90")]
		public OOEHCNMIMMG(GNLDNMJDMJM<T> ONJKCFCNFDD, ObjectPool BOOPGKKHPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2917A50", Offset = "0x2916050", VA = "0x182917A50", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class KOBPMPBJICE<T> : NOKBHGDKGNF, MNMLOBHHOIP<T>, HHGLIBCDIDA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NAKJHNGABFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public KOBPMPBJICE<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public NAKJHNGABFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x277CB80", Offset = "0x277B180", VA = "0x18277CB80")]
			internal void JBOBNDEBFPJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xC6D450", Offset = "0xC6BA50", VA = "0x180C6D450")]
			internal void NIFFGBFKJBC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GNLDNMJDMJM<T> ONJKCFCNFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool IBKDBEFOCFL;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x353E990", Offset = "0x353CF90", VA = "0x18353E990")]
		public KOBPMPBJICE(GNLDNMJDMJM<T> ONJKCFCNFDD, ObjectPool BOOPGKKHPLC, int DBIOCPBCLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x353E940", Offset = "0x353CF40", VA = "0x18353E940", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LFNKHLGOEPD<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public GJJELMBHOAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FIKNOBAKBJH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GNLDNMJDMJM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public LFNKHLGOEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2635DF0", Offset = "0x26343F0", VA = "0x182635DF0")]
		internal void GAGCPECBEOC(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2635D90", Offset = "0x2634390", VA = "0x182635D90")]
		internal void BLONFKEJAPL(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2635E90", Offset = "0x2634490", VA = "0x182635E90")]
		internal void HKEKHPOBAFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly List<CDOIGJCLPCD> HFBACMJEPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private CHDKIKJHEKC MNFHMIBDBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private ObjectPool BOOPGKKHPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ObjectPool JMGHJMNMLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F01D90", Offset = "0x6F00390", VA = "0x186F01D90")]
	private static void AABKGNKODFK(Component JPNJMHFMKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F02450", Offset = "0x6F00A50", VA = "0x186F02450")]
	public GJJELMBHOAB(string MCLGIMEHNKA, int PAEIOPBNABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B40520", Offset = "0x2B3EB20", VA = "0x182B40520")]
	public ANHFNBKPCKN<T> LOHOBJFJPFF<T>(AssetReference EGLGKNNPJMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B40470", Offset = "0x2B3EA70", VA = "0x182B40470")]
	public MNMLOBHHOIP<T> AKHDIPMBLDN<T>(AssetReference EGLGKNNPJMF, int FJLPCOJGEJP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B400C0", Offset = "0x2B3E6C0", VA = "0x182B400C0")]
	public MFBKDKPGMNP<bool> AFPHGIBLJIN<T>(AssetReference EGLGKNNPJMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F01FF0", Offset = "0x6F005F0", VA = "0x186F01FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F02100", Offset = "0x6F00700", VA = "0x186F02100")]
	private void EBDALCPDGEE(UnityEngine.Object OBDAPNDAKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F02240", Offset = "0x6F00840", VA = "0x186F02240")]
	private ObjectPool MOJNCGEANLD(string MCLGIMEHNKA)
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static GlobalPool LNAMEKLDEPH;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static GameObject ABFGMKBGCJK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static GlobalPool HAMPJMKDJOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F027D0", Offset = "0x6F00DD0", VA = "0x186F027D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B44D80", Offset = "0x2B43380", VA = "0x182B44D80")]
		public static void SafeRelease<T>(T NKFOPKJGBEM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F026F0", Offset = "0x6F00CF0", VA = "0x186F026F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F027C0", Offset = "0x6F00DC0", VA = "0x186F027C0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Dictionary<Component, LBAFIKOEDOL> FBHBNJBHIFB;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x23041C0", Offset = "0x23027C0", VA = "0x1823041C0")]
		public T Acquire<T>(T LMLNLGDAFGM, [Optional] Action<Component> AJNPHJBKECC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2304540", Offset = "0x2302B40", VA = "0x182304540")]
		public bool Release<T>(T NKFOPKJGBEM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x23044E0", Offset = "0x2302AE0", VA = "0x1823044E0")]
		public void Prefill<T>(T LMLNLGDAFGM, int FFDHLPGGDNB, [Optional] Action<Component> EAGMEGEEAKI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2304300", Offset = "0x2302900", VA = "0x182304300")]
		public bool Exists<T>(T LMLNLGDAFGM) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2304250", Offset = "0x2302850", VA = "0x182304250")]
		public void Clear<T>(T LMLNLGDAFGM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F03830", Offset = "0x6F01E30", VA = "0x186F03830")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23043B0", Offset = "0x23029B0", VA = "0x1823043B0")]
		private LBAFIKOEDOL NEPMEFPLJCB<T>(T LMLNLGDAFGM) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public void TrackInstantiation(string GLLPPCEOHKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public void EnableStats(bool PGFGKAFPHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F03990", Offset = "0x6F01F90", VA = "0x186F03990")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LBAFIKOEDOL PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DF0", Offset = "0x7F53F0", VA = "0x1807F6DF0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class LBAFIKOEDOL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface JIAKLNCJMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NDAPGPHJNGL(bool OLELHLONAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public abstract string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract int MDJGNNLLGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void AKHDIPMBLDN(int FJLPCOJGEJP, Action<Component> EAGMEGEEAKI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component LOHOBJFJPFF(Action<Component> AJNPHJBKECC);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool GIBKAEADFCC(Component CPDPMINGACC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void FBJOPIHCMHF();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F029D0", Offset = "0x6F00FD0", VA = "0x186F029D0")]
	protected void EIGEGJAEFGG(Component NKFOPKJGBEM, bool OLELHLONAJO, bool IPENGEHNJJM, bool AIPHILPBPDG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F02B50", Offset = "0x6F01150", VA = "0x186F02B50")]
	protected void JGDHCHJPLJE(Transform DOIPNPMLOBN, bool OLELHLONAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected LBAFIKOEDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KHIAGDCGAMM<T> : LBAFIKOEDOL where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T LMLNLGDAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ObjectPool BGJCEFHHLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool IPENGEHNJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private Queue<T> LLGBDBEABBC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2657050", Offset = "0x2655650", VA = "0x182657050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int MDJGNNLLGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2656E90", Offset = "0x2655490", VA = "0x182656E90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26572E0", Offset = "0x26558E0", VA = "0x1826572E0")]
	public KHIAGDCGAMM(T LMLNLGDAFGM, ObjectPool BGJCEFHHLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2656A30", Offset = "0x2655030", VA = "0x182656A30", Slot = "6")]
	public override void AKHDIPMBLDN(int FJLPCOJGEJP, Action<Component> AJNPHJBKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2657070", Offset = "0x2655670", VA = "0x182657070", Slot = "7")]
	public override Component LOHOBJFJPFF(Action<Component> AJNPHJBKECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2656EC0", Offset = "0x26554C0", VA = "0x182656EC0", Slot = "8")]
	public override bool GIBKAEADFCC(Component CPDPMINGACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2656CA0", Offset = "0x26552A0", VA = "0x182656CA0", Slot = "9")]
	public override void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2656B40", Offset = "0x2655140", VA = "0x182656B40")]
	private T DAELPEMECAH()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public interface JNMJFKBHNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			GameObject BPNKBLLBHPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F03490", Offset = "0x6F01A90", VA = "0x186F03490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F037B0", Offset = "0x6F01DB0", VA = "0x186F037B0")]
		public ObjectPoolPreFill()
		{
		}
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
