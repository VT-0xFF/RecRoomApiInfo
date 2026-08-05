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
		[Cpp2IlInjected.Address(RVA = "0x7200D50", Offset = "0x71FFD50", VA = "0x187200D50")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles HPPLDHGJPNF, float JPFEHGHCEPI, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7200B50", Offset = "0x71FFB50", VA = "0x187200B50")]
		public void SetDamageValue(float JPFEHGHCEPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7200EE0", Offset = "0x71FFEE0", VA = "0x187200EE0")]
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
		private static PersistentGlobalPool HPHEIPDJOGN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static GameObject LFCPKLCIDGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PersistentGlobalPool HIEJPGCOIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72009C0", Offset = "0x71FF9C0", VA = "0x1872009C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72008F0", Offset = "0x71FF8F0", VA = "0x1872008F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71FFD70", Offset = "0x71FED70", VA = "0x1871FFD70")]
		public PersistentGlobalPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ALIKCLOJDOH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MKHDKCHGGCM(PooledParticle.NKAPKDGKPIH FHJIOGDDBKF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum FMNOPEKGOKL
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
		public enum NKAPKDGKPIH
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
		public interface DDFBJDMGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool DNECPEKKOJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			Vector3 MNACOHFLKPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			Camera EJAGAPNGHKF
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
			[Cpp2IlInjected.Address(RVA = "0x71FF4C0", Offset = "0x71FE4C0", VA = "0x1871FF4C0")]
			public ColorConfiguration(ParticleSystem GMDHPGGBOIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71FF2B0", Offset = "0x71FE2B0", VA = "0x1871FF2B0")]
			public void ADCPOFMNGIN(Color IFAEOGGHLKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class IKILOJEDGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public IKILOJEDGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71FFED0", Offset = "0x71FEED0", VA = "0x1871FFED0")]
			internal void DEHEEOFBLFF(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DMLHDJCDANE : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private DDFBJDMGFHM <dependencies>5__1;

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
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public DMLHDJCDANE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71FF520", Offset = "0x71FE520", VA = "0x1871FF520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x71FFC60", Offset = "0x71FEC60", VA = "0x1871FFC60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KPCIFMBEPJG : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public KPCIFMBEPJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71FFF00", Offset = "0x71FEF00", VA = "0x1871FFF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x71FFFC0", Offset = "0x71FEFC0", VA = "0x1871FFFC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> DOEMJPDIFFP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly Lazy<ALIKCLOJDOH> EPAMPGAPNBJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static List<PooledParticle> NFAAPDBGEOP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static HKMCLDHFALI BBFMEDGACNL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const float JDKEEFGDALB = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static bool FALEEKCPHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected int KOCBIGHNPGJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private NKAPKDGKPIH category;

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
		private ParticleSystem.MinMaxGradient[] IOMIELNFKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool DLKODICMJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float GAAGABKACLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float JHGPGIABGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Transform PEMINEDHBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 CEDKMPAFGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 PCFMHDLNMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FMNOPEKGOKL NABEIPJLHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HKMCLDHFALI NLGKBDDEKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		protected bool NEJNEBPAAKN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IEnumerable<PooledParticle> KDLDKANLLIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7204600", Offset = "0x7203600", VA = "0x187204600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NKAPKDGKPIH FCEOEPGEBOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9110", Offset = "0xAA8110", VA = "0x180AA9110")]
			get
			{
				return default(NKAPKDGKPIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MDBBGMNJPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAB0", Offset = "0x9ADAB0", VA = "0x1809AEAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OAEPAJFJIBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72042F0", Offset = "0x72032F0", VA = "0x1872042F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static int HFHBNNLNLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7204480", Offset = "0x7203480", VA = "0x187204480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static bool KMJNOHBFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7200FD0", Offset = "0x71FFFD0", VA = "0x187200FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ParticleSystem OMIELINHFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ParticleSystem[] MMBNDPKFNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private ParticleSystemRenderer[] BJNIAIFKKPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x871150", Offset = "0x870150", VA = "0x180871150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private FMNOPEKGOKL GIGBOHNMKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF89430", Offset = "0xF88430", VA = "0x180F89430")]
			get
			{
				return default(FMNOPEKGOKL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7201B10", Offset = "0x7200B10", VA = "0x187201B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BFBNNKAPKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7204250", Offset = "0x7203250", VA = "0x187204250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7204660", Offset = "0x7203660", VA = "0x187204660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7203DD0", Offset = "0x7202DD0", VA = "0x187203DD0")]
		public static PooledParticle TryPlayPrefab(PooledParticle HPPLDHGJPNF, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7203C10", Offset = "0x7202C10", VA = "0x187203C10")]
		public static PooledParticle TryPlayPrefab(PooledParticle HPPLDHGJPNF, Vector3 NKMKMKDMOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7203450", Offset = "0x7202450", VA = "0x187203450")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72012A0", Offset = "0x72002A0", VA = "0x1872012A0")]
		private void DBKJEGDOLHO(bool LJGOKJPEPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72029F0", Offset = "0x72019F0", VA = "0x1872029F0")]
		[IteratorStateMachine(typeof(DMLHDJCDANE))]
		private static IEnumerator<OJAHJFHMFIA> PALOPADLNEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7202450", Offset = "0x7201450", VA = "0x187202450")]
		private static void MNHMGDKIDAD(Stopwatch PPHNMHNDCPA, Vector3 FMOCLFBIOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7201DE0", Offset = "0x7200DE0", VA = "0x187201DE0")]
		private static int LPMIKNGGCLD(PooledParticle JMKFPOOBMEL, PooledParticle OIMIHNAHPGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7202340", Offset = "0x7201340", VA = "0x187202340")]
		private static int MKHDKCHGGCM(NKAPKDGKPIH FHJIOGDDBKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7202140", Offset = "0x7201140", VA = "0x187202140")]
		protected void MHNAFFBBKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7201500", Offset = "0x7200500", VA = "0x187201500")]
		protected void HHFGAOAHLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7201060", Offset = "0x7200060", VA = "0x187201060", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7201E90", Offset = "0x7200E90", VA = "0x187201E90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7202970", Offset = "0x7201970", VA = "0x187202970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7201A90", Offset = "0x7200A90", VA = "0x187201A90")]
		[IteratorStateMachine(typeof(KPCIFMBEPJG))]
		private IEnumerator<OJAHJFHMFIA> HMPINICPOBL(float PNCIGIECCCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7201380", Offset = "0x7200380", VA = "0x187201380")]
		private void FMLBILFGLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7203A20", Offset = "0x7202A20", VA = "0x187203A20")]
		public void SetDuration(float PNCIGIECCCP, bool MFPDCHIOLGI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7203130", Offset = "0x7202130", VA = "0x187203130")]
		public void Play(Transform NOPMMHJONMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7202B10", Offset = "0x7201B10", VA = "0x187202B10")]
		public void Play(Transform NOPMMHJONMF, bool OOEJDOPFKJO, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7202C60", Offset = "0x7201C60", VA = "0x187202C60")]
		public void Play(Transform NOPMMHJONMF, Vector3 PCFMHDLNMME, bool OOEJDOPFKJO, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7202EE0", Offset = "0x7201EE0", VA = "0x187202EE0")]
		public void Play(Transform KEEMOIGMDCD, Quaternion NMKLOHCPMNL, bool OOEJDOPFKJO = false, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7202DB0", Offset = "0x7201DB0", VA = "0x187202DB0")]
		public void Play(Transform KEEMOIGMDCD, Vector3 PCFMHDLNMME, Quaternion NMKLOHCPMNL, bool OOEJDOPFKJO = false, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7202A40", Offset = "0x7201A40", VA = "0x187202A40")]
		public void Play(Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, Vector3 DIGLJLOIALF, bool OOEJDOPFKJO = false, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7203270", Offset = "0x7202270", VA = "0x187203270")]
		public void Play(Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, bool OOEJDOPFKJO = false, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7203020", Offset = "0x7202020", VA = "0x187203020")]
		public void Play(bool OOEJDOPFKJO = false, float FKEEHGDPHCO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7203B80", Offset = "0x7202B80", VA = "0x187203B80")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7203AF0", Offset = "0x7202AF0", VA = "0x187203AF0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72027E0", Offset = "0x72017E0", VA = "0x1872027E0")]
		private void NAPLKPHKDAL(float PNCIGIECCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7201B30", Offset = "0x7200B30", VA = "0x187201B30")]
		private void JJGMKFFHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7203330", Offset = "0x7202330", VA = "0x187203330")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7203610", Offset = "0x7202610", VA = "0x187203610")]
		public void SetColor(Color IFAEOGGHLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7201CA0", Offset = "0x7200CA0", VA = "0x187201CA0")]
		private void KFHIFIEEAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72041B0", Offset = "0x72031B0", VA = "0x1872041B0")]
		public PooledParticle()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELPJLFPFKJD<T> : IBHBGBJGJHP<T>, GAEMIFNLIHB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GFAHJDINKHN<T> : GAEMIFNLIHB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DFILFHBDIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AHJDNAHIEJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class HKABACEDGJM<T> : FPHCELGDGAI<T>, ELPJLFPFKJD<T>, IBHBGBJGJHP<T>, GAEMIFNLIHB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JJHIPMGMMAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HKABACEDGJM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public JJHIPMGMMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2DF71C0", Offset = "0x2DF61C0", VA = "0x182DF71C0")]
			internal void CKJNPEBKMCD(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x12E5470", Offset = "0x12E4470", VA = "0x1812E5470")]
			internal void MJJEDNNJMFO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private ODMBHKBFLMB<T> GJANHAPLEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ObjectPool BJFCDHBHODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private T NHLNFFHEKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool GPPEICIHMBJ;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28453D0", Offset = "0x28443D0", VA = "0x1828453D0")]
		public HKABACEDGJM(ODMBHKBFLMB<T> GJANHAPLEON, ObjectPool BJFCDHBHODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2845290", Offset = "0x2844290", VA = "0x182845290", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class GMIACLCAONJ<T> : NHFPGJIFDOB, GFAHJDINKHN<T>, GAEMIFNLIHB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CJJBAMPPFDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public GMIACLCAONJ<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public CJJBAMPPFDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x21862B0", Offset = "0x21852B0", VA = "0x1821862B0")]
			internal void CKJNPEBKMCD(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2186390", Offset = "0x2185390", VA = "0x182186390")]
			internal void MJJEDNNJMFO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private ODMBHKBFLMB<T> GJANHAPLEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool GPPEICIHMBJ;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x322F040", Offset = "0x322E040", VA = "0x18322F040")]
		public GMIACLCAONJ(ODMBHKBFLMB<T> GJANHAPLEON, ObjectPool BJFCDHBHODM, int FNKGEANBDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x322EFF0", Offset = "0x322DFF0", VA = "0x18322EFF0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HDCIFLDCOCE<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AHJDNAHIEJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FPHCELGDGAI<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ODMBHKBFLMB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HDCIFLDCOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x203BAC0", Offset = "0x203AAC0", VA = "0x18203BAC0")]
		internal void NBJKBJMNILH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x203BBB0", Offset = "0x203ABB0", VA = "0x18203BBB0")]
		internal void OAODODOJKLB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x203BB60", Offset = "0x203AB60", VA = "0x18203BB60")]
		internal void NDCDBLGKGPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly List<DFILFHBDIJP> LFDAPGFGBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private KKPOJEECCIP OKPKGKLIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private ObjectPool BJFCDHBHODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ObjectPool NBJANKGMCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x71FEBA0", Offset = "0x71FDBA0", VA = "0x1871FEBA0")]
	private static void HDNBMMLECOB(Component GDOIACLJEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x71FF010", Offset = "0x71FE010", VA = "0x1871FF010")]
	public AHJDNAHIEJB(string MHDPLHDMGFC, int AEKMHDAHHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x199DC40", Offset = "0x199CC40", VA = "0x18199DC40")]
	public ELPJLFPFKJD<T> HKLNJDIFBOK<T>(AssetReference EMEBLKGMPPH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x199DCD0", Offset = "0x199CCD0", VA = "0x18199DCD0")]
	public GFAHJDINKHN<T> HLOBKBAKFLG<T>(AssetReference EMEBLKGMPPH, int LEOAEOJMCHD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x199D9A0", Offset = "0x199C9A0", VA = "0x18199D9A0")]
	public IBHBGBJGJHP<bool> EKIJMHGPMDN<T>(AssetReference EMEBLKGMPPH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71FEA90", Offset = "0x71FDA90", VA = "0x1871FEA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71FE950", Offset = "0x71FD950", VA = "0x1871FE950")]
	private void DGKJGAAHDPK(UnityEngine.Object AMIAGGOJNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x71FEE00", Offset = "0x71FDE00", VA = "0x1871FEE00")]
	private ObjectPool KMHNHIILFBI(string MHDPLHDMGFC)
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
		private static GlobalPool HPHEIPDJOGN;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static GameObject LFCPKLCIDGI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static GlobalPool HIEJPGCOIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71FFD80", Offset = "0x71FED80", VA = "0x1871FFD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26DF370", Offset = "0x26DE370", VA = "0x1826DF370")]
		public static void SafeRelease<T>(T EOHGDDIECBJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71FFCA0", Offset = "0x71FECA0", VA = "0x1871FFCA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71FFD70", Offset = "0x71FED70", VA = "0x1871FFD70")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Dictionary<Component, OBJHJKGJMFC> GCCNHJHJHBK;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3374CE0", Offset = "0x3373CE0", VA = "0x183374CE0")]
		public T Acquire<T>(T HPPLDHGJPNF, [Optional] Action<Component> KEICKEFAOOP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3375060", Offset = "0x3374060", VA = "0x183375060")]
		public bool Release<T>(T EOHGDDIECBJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3375000", Offset = "0x3374000", VA = "0x183375000")]
		public void Prefill<T>(T HPPLDHGJPNF, int PFGHDPJEHLP, [Optional] Action<Component> FGJNMDPNNDH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3374E20", Offset = "0x3373E20", VA = "0x183374E20")]
		public bool Exists<T>(T HPPLDHGJPNF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3374D70", Offset = "0x3373D70", VA = "0x183374D70")]
		public void Clear<T>(T HPPLDHGJPNF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7200710", Offset = "0x71FF710", VA = "0x187200710")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3374ED0", Offset = "0x3373ED0", VA = "0x183374ED0")]
		private OBJHJKGJMFC NAPCPKPCECJ<T>(T HPPLDHGJPNF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		public void TrackInstantiation(string GFFLLPMFKMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		public void EnableStats(bool GEPDFCKNDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7200870", Offset = "0x71FF870", VA = "0x187200870")]
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
		public OBJHJKGJMFC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x868710", Offset = "0x867710", VA = "0x180868710")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class OBJHJKGJMFC
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface KPBHINPKFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MHFANCLDDLN(bool MHCBMAAPDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public abstract Component FAMICBLAKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public abstract int CKEDBMKNEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void HLOBKBAKFLG(int LEOAEOJMCHD, Action<Component> FGJNMDPNNDH);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component HKLNJDIFBOK(Action<Component> KEICKEFAOOP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool FMLBILFGLCO(Component KNPEDAOHAGF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void PPNJFNMKMCA();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7200000", Offset = "0x71FF000", VA = "0x187200000")]
	protected void FEDKGFBLKLL(Component EOHGDDIECBJ, bool MHCBMAAPDGB, bool NBNDCNMEHDC, bool GPEGDPKLPDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7200180", Offset = "0x71FF180", VA = "0x187200180")]
	protected void GOJPJDNLMJD(Transform BCHAEHHPCMI, bool MHCBMAAPDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected OBJHJKGJMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NILMGLHEJLA<T> : OBJHJKGJMFC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T HPPLDHGJPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ObjectPool NPILGFBIMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool NBNDCNMEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private Queue<T> KOEDNLEEJEM;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override Component FAMICBLAKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2437700", Offset = "0x2436700", VA = "0x182437700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override int CKEDBMKNEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2437570", Offset = "0x2436570", VA = "0x182437570", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2437910", Offset = "0x2436910", VA = "0x182437910")]
	public NILMGLHEJLA(T HPPLDHGJPNF, ObjectPool NPILGFBIMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2437460", Offset = "0x2436460", VA = "0x182437460", Slot = "7")]
	public override void HLOBKBAKFLG(int LEOAEOJMCHD, Action<Component> KEICKEFAOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24371F0", Offset = "0x24361F0", VA = "0x1824371F0", Slot = "8")]
	public override Component HKLNJDIFBOK(Action<Component> KEICKEFAOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2437060", Offset = "0x2436060", VA = "0x182437060", Slot = "9")]
	public override bool FMLBILFGLCO(Component KNPEDAOHAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2437720", Offset = "0x2436720", VA = "0x182437720", Slot = "10")]
	public override void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x24375A0", Offset = "0x24365A0", VA = "0x1824375A0")]
	private T LEEHGDJPNEP()
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
		public interface HHOBLDMPKDN
		{
			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			GameObject CAHPIFBDELN
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
		[Cpp2IlInjected.Address(RVA = "0x7200370", Offset = "0x71FF370", VA = "0x187200370")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7200690", Offset = "0x71FF690", VA = "0x187200690")]
		public ObjectPoolPreFill()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
