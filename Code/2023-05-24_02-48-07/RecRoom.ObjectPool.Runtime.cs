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
		[Cpp2IlInjected.Address(RVA = "0x6F46760", Offset = "0x6F45360", VA = "0x186F46760")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OGIDMIHPCNI, float LMAKPJHEOHA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F46560", Offset = "0x6F45160", VA = "0x186F46560")]
		public void SetDamageValue(float LMAKPJHEOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F468F0", Offset = "0x6F454F0", VA = "0x186F468F0")]
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
		private static PersistentGlobalPool KHHLOMGCPAK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static GameObject ABDCJKBCAEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PersistentGlobalPool EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6F463D0", Offset = "0x6F44FD0", VA = "0x186F463D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F46300", Offset = "0x6F44F00", VA = "0x186F46300")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F44A50", Offset = "0x6F43650", VA = "0x186F44A50")]
		public PersistentGlobalPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FOPHEOFDJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JIAKPPMDFHO(PooledParticle.HHHKOFADJAF KBBEMPODLCC);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum HLLGFJGIJKA
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
		public enum HHHKOFADJAF
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
		public interface DDIOLAFGNMI
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool JEPHPFEOHOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			Vector3 MKGANECBNDI
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			Camera CDEDFJNNGBP
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
			[Cpp2IlInjected.Address(RVA = "0x6F445B0", Offset = "0x6F431B0", VA = "0x186F445B0")]
			public ColorConfiguration(ParticleSystem HNJENNKJJBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F443C0", Offset = "0x6F42FC0", VA = "0x186F443C0")]
			public void IEBJGHFKLDD(Color OPOEPBAFNOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class IHHNHMPIJMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public IHHNHMPIJMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F452F0", Offset = "0x6F43EF0", VA = "0x186F452F0")]
			internal void LEPPJKMFABE(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HBBIAHHENEP : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private DDIOLAFGNMI <dependencies>5__1;

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
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public HBBIAHHENEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F44BB0", Offset = "0x6F437B0", VA = "0x186F44BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F452B0", Offset = "0x6F43EB0", VA = "0x186F452B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IINLKBAPKNI : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public IINLKBAPKNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F45320", Offset = "0x6F43F20", VA = "0x186F45320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F453E0", Offset = "0x6F43FE0", VA = "0x186F453E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CAPIOEAHCNE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly Lazy<FOPHEOFDJHP> OHOGNMMNCDD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static List<PooledParticle> NDHINOHFDPH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static CMHJCDCDCHH AFHLEAEKDNL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const float GNFOAFGKDDM = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static bool DJFBMPEDGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected int LCBKNDIDMOE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private HHHKOFADJAF category;

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
		private ParticleSystem.MinMaxGradient[] PPKALMADHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool DNMAKGFFLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float EOHCDEBGLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float NBBGFIILKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Transform KOELHPAEPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 HBIBILDKNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 KPEMDCFDOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HLLGFJGIJKA GCBOAIIJBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CMHJCDCDCHH BCEKIKNBBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		protected bool OPLEACHKEBN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IEnumerable<PooledParticle> JOAGFGCFPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4A220", Offset = "0x6F48E20", VA = "0x186F4A220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HHHKOFADJAF ADEBPOJNONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x852CF0", Offset = "0x8518F0", VA = "0x180852CF0")]
			get
			{
				return default(HHHKOFADJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JHHINHFCBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x837B50", Offset = "0x836750", VA = "0x180837B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GOEJILIBOLA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F49F10", Offset = "0x6F48B10", VA = "0x186F49F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static int HMPFKJNBDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F4A0A0", Offset = "0x6F48CA0", VA = "0x186F4A0A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static bool GDGNHADFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F47760", Offset = "0x6F46360", VA = "0x186F47760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ParticleSystem GBDLINNDJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7F0400", Offset = "0x7EF000", VA = "0x1807F0400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ParticleSystem[] HLFEGHGKMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private ParticleSystemRenderer[] KKBLLMBPNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D720", VA = "0x18083EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HLLGFJGIJKA JLGEKHEEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAA7FD0", Offset = "0xAA6BD0", VA = "0x180AA7FD0")]
			get
			{
				return default(HLLGFJGIJKA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F48290", Offset = "0x6F46E90", VA = "0x186F48290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IBLLIMFBFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F49E70", Offset = "0x6F48A70", VA = "0x186F49E70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F4A280", Offset = "0x6F48E80", VA = "0x186F4A280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F499F0", Offset = "0x6F485F0", VA = "0x186F499F0")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGIDMIHPCNI, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F49830", Offset = "0x6F48430", VA = "0x186F49830")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGIDMIHPCNI, Vector3 NABPHMOHNDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F48E80", Offset = "0x6F47A80", VA = "0x186F48E80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F46CD0", Offset = "0x6F458D0", VA = "0x186F46CD0")]
		private void BJONDEFPEEL(bool PKDEOIANGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F480D0", Offset = "0x6F46CD0", VA = "0x186F480D0")]
		[IteratorStateMachine(typeof(HBBIAHHENEP))]
		private static IEnumerator<EDDHBDCNFKM> MEEHPHCFGPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F47A90", Offset = "0x6F46690", VA = "0x186F47A90")]
		private static void LIDOLFGNJLJ(Stopwatch IDIJCJCNEPO, Vector3 OIHJBHMOJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F469E0", Offset = "0x6F455E0", VA = "0x186F469E0")]
		private static int AMLHLLIHOPM(PooledParticle EOEOFNCKKHJ, PooledParticle AOEAFBFCPPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F477F0", Offset = "0x6F463F0", VA = "0x186F477F0")]
		private static int JIAKPPMDFHO(HHHKOFADJAF KBBEMPODLCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F46DB0", Offset = "0x6F459B0", VA = "0x186F46DB0")]
		protected void EAHPLBGLCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F47030", Offset = "0x6F45C30", VA = "0x186F47030")]
		protected void FOAFAHKJMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F46A90", Offset = "0x6F45690", VA = "0x186F46A90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F47E30", Offset = "0x6F46A30", VA = "0x186F47E30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F482B0", Offset = "0x6F46EB0", VA = "0x186F482B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F46FB0", Offset = "0x6F45BB0", VA = "0x186F46FB0")]
		[IteratorStateMachine(typeof(IINLKBAPKNI))]
		private IEnumerator<EDDHBDCNFKM> FJAJJKKNOBF(float NCOPMNKMGPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F475E0", Offset = "0x6F461E0", VA = "0x186F475E0")]
		private void GCNLFMGFLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F49640", Offset = "0x6F48240", VA = "0x186F49640")]
		public void SetDuration(float NCOPMNKMGPG, bool KPIBCMOEKFN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F48B60", Offset = "0x6F47760", VA = "0x186F48B60")]
		public void Play(Transform KJKNBICLIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F48540", Offset = "0x6F47140", VA = "0x186F48540")]
		public void Play(Transform KJKNBICLIAN, bool HJNHPLLDCEJ, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F48690", Offset = "0x6F47290", VA = "0x186F48690")]
		public void Play(Transform KJKNBICLIAN, Vector3 KPEMDCFDOAN, bool HJNHPLLDCEJ, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F48910", Offset = "0x6F47510", VA = "0x186F48910")]
		public void Play(Transform LCCAEKKBJIJ, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F487E0", Offset = "0x6F473E0", VA = "0x186F487E0")]
		public void Play(Transform LCCAEKKBJIJ, Vector3 KPEMDCFDOAN, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F48470", Offset = "0x6F47070", VA = "0x186F48470")]
		public void Play(Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, Vector3 PPJHGOCBPCK, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F48CA0", Offset = "0x6F478A0", VA = "0x186F48CA0")]
		public void Play(Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F48A50", Offset = "0x6F47650", VA = "0x186F48A50")]
		public void Play(bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F497A0", Offset = "0x6F483A0", VA = "0x186F497A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F49710", Offset = "0x6F48310", VA = "0x186F49710")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F47900", Offset = "0x6F46500", VA = "0x186F47900")]
		private void KIFABHFEKPD(float NCOPMNKMGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F48120", Offset = "0x6F46D20", VA = "0x186F48120")]
		private void NINGENLJPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F48D60", Offset = "0x6F47960", VA = "0x186F48D60")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F49040", Offset = "0x6F47C40", VA = "0x186F49040")]
		public void SetColor(Color OPOEPBAFNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F48330", Offset = "0x6F46F30", VA = "0x186F48330")]
		private void PFAGHHNABNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F49DD0", Offset = "0x6F489D0", VA = "0x186F49DD0")]
		public PooledParticle()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CPFJMCHBOBJ<T> : global::NBFPPJGKGOH<T>, EILHPPDHBHH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GDADBLIENOK<T> : EILHPPDHBHH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NCGDABJJKMI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LBIBOEJBBFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class AIEKDCBKJPG<T> : global::GBNOCCBNCBC<T>, global::CPFJMCHBOBJ<T>, global::NBFPPJGKGOH<T>, EILHPPDHBHH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OEIHEMHOIHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AIEKDCBKJPG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public OEIHEMHOIHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4066770", Offset = "0x4065370", VA = "0x184066770")]
			internal void CMOMFNDMDFO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2891790", Offset = "0x2890390", VA = "0x182891790")]
			internal void HPOPKBBAEKB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private global::BMMLLBKLJDM<T> EKDDLNFDCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ObjectPool FBJOFLADCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private T PKIKEDNMDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool FNDAICJNELC;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x43898C0", Offset = "0x43884C0", VA = "0x1843898C0")]
		public AIEKDCBKJPG(global::BMMLLBKLJDM<T> EKDDLNFDCKF, ObjectPool FBJOFLADCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4389780", Offset = "0x4388380", VA = "0x184389780", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class CGGMCKGIHLL<T> : GIELIJKIODJ, global::GDADBLIENOK<T>, EILHPPDHBHH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OFEGOCCOJGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CGGMCKGIHLL<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
			public OFEGOCCOJGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4067520", Offset = "0x4066120", VA = "0x184067520")]
			internal void CMOMFNDMDFO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x4067600", Offset = "0x4066200", VA = "0x184067600")]
			internal void HPOPKBBAEKB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private global::BMMLLBKLJDM<T> EKDDLNFDCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool FNDAICJNELC;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x33E2F10", Offset = "0x33E1B10", VA = "0x1833E2F10")]
		public CGGMCKGIHLL(global::BMMLLBKLJDM<T> EKDDLNFDCKF, ObjectPool FBJOFLADCOM, int LECBAHMFIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x33E2EC0", Offset = "0x33E1AC0", VA = "0x1833E2EC0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DNCPJFOIION<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LBIBOEJBBFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public global::GBNOCCBNCBC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public global::BMMLLBKLJDM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public DNCPJFOIION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x36D7720", Offset = "0x36D6320", VA = "0x1836D7720")]
		internal void AEOMGDFILJM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x36D7810", Offset = "0x36D6410", VA = "0x1836D7810")]
		internal void OMDOMGFLMMB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x36D77C0", Offset = "0x36D63C0", VA = "0x1836D77C0")]
		internal void KKLFDMFEFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly List<NCGDABJJKMI> BCAADPLHJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IINABMBHBAO CCPOPFDNGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private ObjectPool FBJOFLADCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ObjectPool GMLJCMPJNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F45800", Offset = "0x6F44400", VA = "0x186F45800")]
	private static void MABJHNDIPDH(Component DPLEBJGMEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F45AE0", Offset = "0x6F446E0", VA = "0x186F45AE0")]
	public LBIBOEJBBFD(string FMCIPDNGKPD, int LHNJPONCPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x262AFB0", Offset = "0x2629BB0", VA = "0x18262AFB0")]
	public global::CPFJMCHBOBJ<T> HOMPIJPBAAK<T>(AssetReference IOCBPBHMMJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x262B040", Offset = "0x2629C40", VA = "0x18262B040")]
	public global::GDADBLIENOK<T> MGHEHJGIJJC<T>(AssetReference IOCBPBHMMJH, int FGHOJPFDCIA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x262B0F0", Offset = "0x2629CF0", VA = "0x18262B0F0")]
	public global::NBFPPJGKGOH<bool> PFHINLDLMKG<T>(AssetReference IOCBPBHMMJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F45420", Offset = "0x6F44020", VA = "0x186F45420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F45530", Offset = "0x6F44130", VA = "0x186F45530")]
	private void HDMKDMCCNPI(UnityEngine.Object AOFPLCKJDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F45670", Offset = "0x6F44270", VA = "0x186F45670")]
	private ObjectPool LEFFLMGALMM(string FMCIPDNGKPD)
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
		private static GlobalPool KHHLOMGCPAK;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static GameObject ABDCJKBCAEB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static GlobalPool EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F44A60", Offset = "0x6F43660", VA = "0x186F44A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B77DA0", Offset = "0x2B769A0", VA = "0x182B77DA0")]
		public static void SafeRelease<T>(T HHNPCHNMLMA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F44980", Offset = "0x6F43580", VA = "0x186F44980")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F44A50", Offset = "0x6F43650", VA = "0x186F44A50")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Dictionary<Component, GJIONPIMLDK> IIKIFMIMLCP;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2101FF0", Offset = "0x2100BF0", VA = "0x182101FF0")]
		public T Acquire<T>(T OGIDMIHPCNI, [Optional] Action<Component> FHBPFBINPFK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2102370", Offset = "0x2100F70", VA = "0x182102370")]
		public bool Release<T>(T HHNPCHNMLMA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2102310", Offset = "0x2100F10", VA = "0x182102310")]
		public void Prefill<T>(T OGIDMIHPCNI, int MAGOINHIJBM, [Optional] Action<Component> MAFHAPKEHFE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2102130", Offset = "0x2100D30", VA = "0x182102130")]
		public bool Exists<T>(T OGIDMIHPCNI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2102080", Offset = "0x2100C80", VA = "0x182102080")]
		public void Clear<T>(T OGIDMIHPCNI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F46130", Offset = "0x6F44D30", VA = "0x186F46130")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x21021E0", Offset = "0x2100DE0", VA = "0x1821021E0")]
		private GJIONPIMLDK OIIIMGHDDFO<T>(T OGIDMIHPCNI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		public void TrackInstantiation(string IPANIBCMPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		public void EnableStats(bool DPKNJAGKEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F46280", Offset = "0x6F44E80", VA = "0x186F46280")]
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
		public GJIONPIMLDK PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1575EC0", Offset = "0x1574AC0", VA = "0x181575EC0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class GJIONPIMLDK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface BDAHNLFJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CGKOGMFALHJ(bool JACPCCGHLHM);
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public abstract Component FPLPEAJBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public abstract int JIPHPDOEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void MGHEHJGIJJC(int FGHOJPFDCIA, Action<Component> MAFHAPKEHFE);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component HOMPIJPBAAK(Action<Component> FHBPFBINPFK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool GCNLFMGFLMB(Component CBPNGHBBIDH);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ELJLHOEKJGC();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F44610", Offset = "0x6F43210", VA = "0x186F44610")]
	protected void NPAOGKLKBAE(Component HHNPCHNMLMA, bool JACPCCGHLHM, bool DEJGACILOIN, bool FIEMBLBFPPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F44790", Offset = "0x6F43390", VA = "0x186F44790")]
	protected void PEKNDEEEIHE(Transform EFJNJLMNIDA, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	protected GJIONPIMLDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EOMBHEFDOGG<T> : GJIONPIMLDK where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T OGIDMIHPCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ObjectPool HHFLIFDLEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool DEJGACILOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private Queue<T> MIKGABNJPIM;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override Component FPLPEAJBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x954D50", Offset = "0x953950", VA = "0x180954D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x353DF30", Offset = "0x353CB30", VA = "0x18353DF30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override int JIPHPDOEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x353E140", Offset = "0x353CD40", VA = "0x18353E140", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x353E680", Offset = "0x353D280", VA = "0x18353E680")]
	public EOMBHEFDOGG(T OGIDMIHPCNI, ObjectPool HHFLIFDLEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x353E570", Offset = "0x353D170", VA = "0x18353E570", Slot = "7")]
	public override void MGHEHJGIJJC(int FGHOJPFDCIA, Action<Component> FHBPFBINPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x353E300", Offset = "0x353CF00", VA = "0x18353E300", Slot = "8")]
	public override Component HOMPIJPBAAK(Action<Component> FHBPFBINPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x353E170", Offset = "0x353CD70", VA = "0x18353E170", Slot = "9")]
	public override bool GCNLFMGFLMB(Component CBPNGHBBIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x353DF50", Offset = "0x353CB50", VA = "0x18353DF50", Slot = "10")]
	public override void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x353DDD0", Offset = "0x353C9D0", VA = "0x18353DDD0")]
	private T BEIJMPHLGFG()
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
		public interface JIOHGBMAAFM
		{
			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			GameObject FEOJPOAINBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F45D80", Offset = "0x6F44980", VA = "0x186F45D80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F460B0", Offset = "0x6F44CB0", VA = "0x186F460B0")]
		public ObjectPoolPreFill()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
