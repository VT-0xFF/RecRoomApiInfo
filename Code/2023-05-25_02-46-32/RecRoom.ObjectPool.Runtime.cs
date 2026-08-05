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
		[Cpp2IlInjected.Address(RVA = "0x6F7F1A0", Offset = "0x6F7D9A0", VA = "0x186F7F1A0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OGIDMIHPCNI, float LMAKPJHEOHA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EFA0", Offset = "0x6F7D7A0", VA = "0x186F7EFA0")]
		public void SetDamageValue(float LMAKPJHEOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F330", Offset = "0x6F7DB30", VA = "0x186F7F330")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7EE10", Offset = "0x6F7D610", VA = "0x186F7EE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ED40", Offset = "0x6F7D540", VA = "0x186F7ED40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D490", Offset = "0x6F7BC90", VA = "0x186F7D490")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7CFF0", Offset = "0x6F7B7F0", VA = "0x186F7CFF0")]
			public ColorConfiguration(ParticleSystem HNJENNKJJBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7CE00", Offset = "0x6F7B600", VA = "0x186F7CE00")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public IHHNHMPIJMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DD30", Offset = "0x6F7C530", VA = "0x186F7DD30")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
			[DebuggerHidden]
			public HBBIAHHENEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D5F0", Offset = "0x6F7BDF0", VA = "0x186F7D5F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DCF0", Offset = "0x6F7C4F0", VA = "0x186F7DCF0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B15D0", Offset = "0x8AFDD0", VA = "0x1808B15D0")]
			[DebuggerHidden]
			public IINLKBAPKNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DD60", Offset = "0x6F7C560", VA = "0x186F7DD60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DE20", Offset = "0x6F7C620", VA = "0x186F7DE20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F82C60", Offset = "0x6F81460", VA = "0x186F82C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HHHKOFADJAF ADEBPOJNONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8C8AE0", Offset = "0x8C72E0", VA = "0x1808C8AE0")]
			get
			{
				return default(HHHKOFADJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JHHINHFCBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GOEJILIBOLA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F82950", Offset = "0x6F81150", VA = "0x186F82950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static int HMPFKJNBDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F82AE0", Offset = "0x6F812E0", VA = "0x186F82AE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static bool GDGNHADFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F801A0", Offset = "0x6F7E9A0", VA = "0x186F801A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ParticleSystem GBDLINNDJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x80EE60", Offset = "0x80D660", VA = "0x18080EE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ParticleSystem[] HLFEGHGKMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private ParticleSystemRenderer[] KKBLLMBPNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8B4920", Offset = "0x8B3120", VA = "0x1808B4920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HLLGFJGIJKA JLGEKHEEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB460A0", Offset = "0xB448A0", VA = "0x180B460A0")]
			get
			{
				return default(HLLGFJGIJKA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F80CD0", Offset = "0x6F7F4D0", VA = "0x186F80CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IBLLIMFBFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F828B0", Offset = "0x6F810B0", VA = "0x186F828B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F82CC0", Offset = "0x6F814C0", VA = "0x186F82CC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F82430", Offset = "0x6F80C30", VA = "0x186F82430")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGIDMIHPCNI, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F82270", Offset = "0x6F80A70", VA = "0x186F82270")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGIDMIHPCNI, Vector3 NABPHMOHNDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F818C0", Offset = "0x6F800C0", VA = "0x186F818C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F710", Offset = "0x6F7DF10", VA = "0x186F7F710")]
		private void BJONDEFPEEL(bool PKDEOIANGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F80B10", Offset = "0x6F7F310", VA = "0x186F80B10")]
		[IteratorStateMachine(typeof(HBBIAHHENEP))]
		private static IEnumerator<EDDHBDCNFKM> MEEHPHCFGPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F804D0", Offset = "0x6F7ECD0", VA = "0x186F804D0")]
		private static void LIDOLFGNJLJ(Stopwatch IDIJCJCNEPO, Vector3 OIHJBHMOJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F420", Offset = "0x6F7DC20", VA = "0x186F7F420")]
		private static int AMLHLLIHOPM(PooledParticle EOEOFNCKKHJ, PooledParticle AOEAFBFCPPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F80230", Offset = "0x6F7EA30", VA = "0x186F80230")]
		private static int JIAKPPMDFHO(HHHKOFADJAF KBBEMPODLCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F7F0", Offset = "0x6F7DFF0", VA = "0x186F7F7F0")]
		protected void EAHPLBGLCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FA70", Offset = "0x6F7E270", VA = "0x186F7FA70")]
		protected void FOAFAHKJMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F4D0", Offset = "0x6F7DCD0", VA = "0x186F7F4D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F80870", Offset = "0x6F7F070", VA = "0x186F80870")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F80CF0", Offset = "0x6F7F4F0", VA = "0x186F80CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F9F0", Offset = "0x6F7E1F0", VA = "0x186F7F9F0")]
		[IteratorStateMachine(typeof(IINLKBAPKNI))]
		private IEnumerator<EDDHBDCNFKM> FJAJJKKNOBF(float NCOPMNKMGPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F80020", Offset = "0x6F7E820", VA = "0x186F80020")]
		private void GCNLFMGFLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F82080", Offset = "0x6F80880", VA = "0x186F82080")]
		public void SetDuration(float NCOPMNKMGPG, bool KPIBCMOEKFN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F815A0", Offset = "0x6F7FDA0", VA = "0x186F815A0")]
		public void Play(Transform KJKNBICLIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F80F80", Offset = "0x6F7F780", VA = "0x186F80F80")]
		public void Play(Transform KJKNBICLIAN, bool HJNHPLLDCEJ, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F810D0", Offset = "0x6F7F8D0", VA = "0x186F810D0")]
		public void Play(Transform KJKNBICLIAN, Vector3 KPEMDCFDOAN, bool HJNHPLLDCEJ, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F81350", Offset = "0x6F7FB50", VA = "0x186F81350")]
		public void Play(Transform LCCAEKKBJIJ, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F81220", Offset = "0x6F7FA20", VA = "0x186F81220")]
		public void Play(Transform LCCAEKKBJIJ, Vector3 KPEMDCFDOAN, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F80EB0", Offset = "0x6F7F6B0", VA = "0x186F80EB0")]
		public void Play(Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, Vector3 PPJHGOCBPCK, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F816E0", Offset = "0x6F7FEE0", VA = "0x186F816E0")]
		public void Play(Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F81490", Offset = "0x6F7FC90", VA = "0x186F81490")]
		public void Play(bool HJNHPLLDCEJ = false, float EBPNEHBFBKC = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F821E0", Offset = "0x6F809E0", VA = "0x186F821E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F82150", Offset = "0x6F80950", VA = "0x186F82150")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F80340", Offset = "0x6F7EB40", VA = "0x186F80340")]
		private void KIFABHFEKPD(float NCOPMNKMGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F80B60", Offset = "0x6F7F360", VA = "0x186F80B60")]
		private void NINGENLJPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F817A0", Offset = "0x6F7FFA0", VA = "0x186F817A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F81A80", Offset = "0x6F80280", VA = "0x186F81A80")]
		public void SetColor(Color OPOEPBAFNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F80D70", Offset = "0x6F7F570", VA = "0x186F80D70")]
		private void PFAGHHNABNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F82810", Offset = "0x6F81010", VA = "0x186F82810")]
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
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public OEIHEMHOIHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3130", Offset = "0x3AA1930", VA = "0x183AA3130")]
			internal void CMOMFNDMDFO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2315F20", Offset = "0x2314720", VA = "0x182315F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x462EE30", Offset = "0x462D630", VA = "0x18462EE30")]
		public AIEKDCBKJPG(global::BMMLLBKLJDM<T> EKDDLNFDCKF, ObjectPool FBJOFLADCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x462ECF0", Offset = "0x462D4F0", VA = "0x18462ECF0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public OFEGOCCOJGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3EE0", Offset = "0x3AA26E0", VA = "0x183AA3EE0")]
			internal void CMOMFNDMDFO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3FC0", Offset = "0x3AA27C0", VA = "0x183AA3FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D523F0", Offset = "0x2D50BF0", VA = "0x182D523F0")]
		public CGGMCKGIHLL(global::BMMLLBKLJDM<T> EKDDLNFDCKF, ObjectPool FBJOFLADCOM, int LECBAHMFIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D523A0", Offset = "0x2D50BA0", VA = "0x182D523A0", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public DNCPJFOIION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2F86660", Offset = "0x2F84E60", VA = "0x182F86660")]
		internal void AEOMGDFILJM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2F86750", Offset = "0x2F84F50", VA = "0x182F86750")]
		internal void OMDOMGFLMMB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2F86700", Offset = "0x2F84F00", VA = "0x182F86700")]
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
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E240", Offset = "0x6F7CA40", VA = "0x186F7E240")]
	private static void MABJHNDIPDH(Component DPLEBJGMEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E520", Offset = "0x6F7CD20", VA = "0x186F7E520")]
	public LBIBOEJBBFD(string FMCIPDNGKPD, int LHNJPONCPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28F4A10", Offset = "0x28F3210", VA = "0x1828F4A10")]
	public global::CPFJMCHBOBJ<T> HOMPIJPBAAK<T>(AssetReference IOCBPBHMMJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28F4AA0", Offset = "0x28F32A0", VA = "0x1828F4AA0")]
	public global::GDADBLIENOK<T> MGHEHJGIJJC<T>(AssetReference IOCBPBHMMJH, int FGHOJPFDCIA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28F4B50", Offset = "0x28F3350", VA = "0x1828F4B50")]
	public global::NBFPPJGKGOH<bool> PFHINLDLMKG<T>(AssetReference IOCBPBHMMJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DE60", Offset = "0x6F7C660", VA = "0x186F7DE60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DF70", Offset = "0x6F7C770", VA = "0x186F7DF70")]
	private void HDMKDMCCNPI(UnityEngine.Object AOFPLCKJDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E0B0", Offset = "0x6F7C8B0", VA = "0x186F7E0B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7D4A0", Offset = "0x6F7BCA0", VA = "0x186F7D4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD77C0", Offset = "0x2DD5FC0", VA = "0x182DD77C0")]
		public static void SafeRelease<T>(T HHNPCHNMLMA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D3C0", Offset = "0x6F7BBC0", VA = "0x186F7D3C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D490", Offset = "0x6F7BC90", VA = "0x186F7D490")]
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
		[Cpp2IlInjected.Address(RVA = "0x23CF000", Offset = "0x23CD800", VA = "0x1823CF000")]
		public T Acquire<T>(T OGIDMIHPCNI, [Optional] Action<Component> FHBPFBINPFK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x23CF380", Offset = "0x23CDB80", VA = "0x1823CF380")]
		public bool Release<T>(T HHNPCHNMLMA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x23CF320", Offset = "0x23CDB20", VA = "0x1823CF320")]
		public void Prefill<T>(T OGIDMIHPCNI, int MAGOINHIJBM, [Optional] Action<Component> MAFHAPKEHFE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x23CF140", Offset = "0x23CD940", VA = "0x1823CF140")]
		public bool Exists<T>(T OGIDMIHPCNI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x23CF090", Offset = "0x23CD890", VA = "0x1823CF090")]
		public void Clear<T>(T OGIDMIHPCNI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EB70", Offset = "0x6F7D370", VA = "0x186F7EB70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23CF1F0", Offset = "0x23CD9F0", VA = "0x1823CF1F0")]
		private GJIONPIMLDK OIIIMGHDDFO<T>(T OGIDMIHPCNI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		public void TrackInstantiation(string IPANIBCMPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		public void EnableStats(bool DPKNJAGKEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ECC0", Offset = "0x6F7D4C0", VA = "0x186F7ECC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBC2C40", Offset = "0xBC1440", VA = "0x180BC2C40")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F7D050", Offset = "0x6F7B850", VA = "0x186F7D050")]
	protected void NPAOGKLKBAE(Component HHNPCHNMLMA, bool JACPCCGHLHM, bool DEJGACILOIN, bool FIEMBLBFPPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D1D0", Offset = "0x6F7B9D0", VA = "0x186F7D1D0")]
	protected void PEKNDEEEIHE(Transform EFJNJLMNIDA, bool JACPCCGHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
		[Cpp2IlInjected.Address(RVA = "0x841940", Offset = "0x840140", VA = "0x180841940", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x185E720", Offset = "0x185CF20", VA = "0x18185E720", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override int JIPHPDOEPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x185E930", Offset = "0x185D130", VA = "0x18185E930", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x185EE70", Offset = "0x185D670", VA = "0x18185EE70")]
	public EOMBHEFDOGG(T OGIDMIHPCNI, ObjectPool HHFLIFDLEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x185ED60", Offset = "0x185D560", VA = "0x18185ED60", Slot = "7")]
	public override void MGHEHJGIJJC(int FGHOJPFDCIA, Action<Component> FHBPFBINPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x185EAF0", Offset = "0x185D2F0", VA = "0x18185EAF0", Slot = "8")]
	public override Component HOMPIJPBAAK(Action<Component> FHBPFBINPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x185E960", Offset = "0x185D160", VA = "0x18185E960", Slot = "9")]
	public override bool GCNLFMGFLMB(Component CBPNGHBBIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x185E740", Offset = "0x185CF40", VA = "0x18185E740", Slot = "10")]
	public override void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x185E5C0", Offset = "0x185CDC0", VA = "0x18185E5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F7E7C0", Offset = "0x6F7CFC0", VA = "0x186F7E7C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EAF0", Offset = "0x6F7D2F0", VA = "0x186F7EAF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
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
