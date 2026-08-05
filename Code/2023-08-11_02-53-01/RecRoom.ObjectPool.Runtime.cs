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
		[Cpp2IlInjected.Address(RVA = "0x6E32F90", Offset = "0x6E31790", VA = "0x186E32F90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ALNJPMNLFGF, float ALFBENKHCNH, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E32D90", Offset = "0x6E31590", VA = "0x186E32D90")]
		public void SetDamageValue(float ALFBENKHCNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E33120", Offset = "0x6E31920", VA = "0x186E33120")]
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
		private static PersistentGlobalPool NMCGONNHGCC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static GameObject JDMNPIMJKLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PersistentGlobalPool OEFAOPMNMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6E32C00", Offset = "0x6E31400", VA = "0x186E32C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E32B30", Offset = "0x6E31330", VA = "0x186E32B30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E31FB0", Offset = "0x6E307B0", VA = "0x186E31FB0")]
		public PersistentGlobalPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ANOGOJKEHBG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NCIILPBKHLG(PooledParticle.HDJIFIEIJNH FDDLGGHNBKN);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum BKPHLLJBHHP
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
		public enum HDJIFIEIJNH
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
		public interface LJKODBABEEO
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool JEFJKLPIGMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			Vector3 AFFHHDEFCLL
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			Camera PEFNCEPPBNO
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
			[Cpp2IlInjected.Address(RVA = "0x6E31520", Offset = "0x6E2FD20", VA = "0x186E31520")]
			public ColorConfiguration(ParticleSystem MEDLNCNCIJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E31310", Offset = "0x6E2FB10", VA = "0x186E31310")]
			public void DKFLPAMBJAG(Color JIINIIPALJJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class HHBDBBCAKAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public HHBDBBCAKAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E32110", Offset = "0x6E30910", VA = "0x186E32110")]
			internal void BNKMLAFPOCJ(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class CICHFMFAPNJ : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private LJKODBABEEO <dependencies>5__1;

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
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public CICHFMFAPNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E30B90", Offset = "0x6E2F390", VA = "0x186E30B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E312D0", Offset = "0x6E2FAD0", VA = "0x186E312D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LDJOLGPENJA : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public LDJOLGPENJA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E32140", Offset = "0x6E30940", VA = "0x186E32140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6E32200", Offset = "0x6E30A00", VA = "0x186E32200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> OEHAEMKFFFI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly Lazy<ANOGOJKEHBG> JDHMKFLPMLF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static List<PooledParticle> OOCDBGBONFP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static IIFKIJJEKEP IODHPIEODJI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const float ADJLJHIHOLM = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static bool CPPNBABJBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected int PDMBLPHFJFN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private HDJIFIEIJNH category;

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
		private ParticleSystem.MinMaxGradient[] JOICDBFIKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool FMEFGHPFHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float JNHLDJBGNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float PJPIJHKEHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Transform GGFMJJGPBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Vector3 JDAPEIBIBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Vector3 PLENDAMEIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private BKPHLLJBHHP EBADOABIGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IIFKIJJEKEP MFOMLMKJDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		protected bool GJMCCBIHLAC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IEnumerable<PooledParticle> EKJMFKIMPNK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6E36840", Offset = "0x6E35040", VA = "0x186E36840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HDJIFIEIJNH OPLNMKNNAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAD9880", Offset = "0xAD8080", VA = "0x180AD9880")]
			get
			{
				return default(HDJIFIEIJNH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MILEKFMMEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLFBNHADDGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6E36530", Offset = "0x6E34D30", VA = "0x186E36530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static int HKCFHILAEFH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E366C0", Offset = "0x6E34EC0", VA = "0x186E366C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected static bool KNIFEFMDFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E337D0", Offset = "0x6E31FD0", VA = "0x186E337D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ParticleSystem GKDBNAGGPGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8A97C0", Offset = "0x8A7FC0", VA = "0x1808A97C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ParticleSystem[] BAALFAEIOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private ParticleSystemRenderer[] JPNLLNILOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private BKPHLLJBHHP IAECCOFFCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE8FF80", Offset = "0xE8E780", VA = "0x180E8FF80")]
			get
			{
				return default(BKPHLLJBHHP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E342A0", Offset = "0x6E32AA0", VA = "0x186E342A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NIEJPGLLCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E36490", Offset = "0x6E34C90", VA = "0x186E36490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E368A0", Offset = "0x6E350A0", VA = "0x186E368A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E36010", Offset = "0x6E34810", VA = "0x186E36010")]
		public static PooledParticle TryPlayPrefab(PooledParticle ALNJPMNLFGF, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E35E50", Offset = "0x6E34650", VA = "0x186E35E50")]
		public static PooledParticle TryPlayPrefab(PooledParticle ALNJPMNLFGF, Vector3 PAOMABBDKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E35690", Offset = "0x6E33E90", VA = "0x186E35690")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E34AA0", Offset = "0x6E332A0", VA = "0x186E34AA0")]
		private void OOGPGADJBEI(bool JEABKFCMDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E33FA0", Offset = "0x6E327A0", VA = "0x186E33FA0")]
		[IteratorStateMachine(typeof(CICHFMFAPNJ))]
		private static IEnumerator<EPHOKNIGMNK> KIAAJGJJNFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E33910", Offset = "0x6E32110", VA = "0x186E33910")]
		private static void FHIFGEPPMDF(Stopwatch FMGNKDAMMIM, Vector3 BHHCLAJJOBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E33860", Offset = "0x6E32060", VA = "0x186E33860")]
		private static int CNGHBNBOGOD(PooledParticle BENALFHNIOG, PooledParticle EMAOEIAIOHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E34850", Offset = "0x6E33050", VA = "0x186E34850")]
		private static int NCIILPBKHLG(HDJIFIEIJNH FDDLGGHNBKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E335D0", Offset = "0x6E31DD0", VA = "0x186E335D0")]
		protected void CINLOJOLLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E342C0", Offset = "0x6E32AC0", VA = "0x186E342C0")]
		protected void MOCLFKBPBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E33210", Offset = "0x6E31A10", VA = "0x186E33210", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E33FF0", Offset = "0x6E327F0", VA = "0x186E33FF0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E34B80", Offset = "0x6E33380", VA = "0x186E34B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E34C00", Offset = "0x6E33400", VA = "0x186E34C00")]
		[IteratorStateMachine(typeof(LDJOLGPENJA))]
		private IEnumerator<EPHOKNIGMNK> PGJMDFGKFAP(float DBCGMGMJHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E33450", Offset = "0x6E31C50", VA = "0x186E33450")]
		private void CEEMIOIEFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E35C60", Offset = "0x6E34460", VA = "0x186E35C60")]
		public void SetDuration(float DBCGMGMJHMI, bool JBEBDHPLEPA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E35370", Offset = "0x6E33B70", VA = "0x186E35370")]
		public void Play(Transform OFFKKCKEDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E34D50", Offset = "0x6E33550", VA = "0x186E34D50")]
		public void Play(Transform OFFKKCKEDOJ, bool EGMPHJFGDHP, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E34EA0", Offset = "0x6E336A0", VA = "0x186E34EA0")]
		public void Play(Transform OFFKKCKEDOJ, Vector3 PLENDAMEIMA, bool EGMPHJFGDHP, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E35120", Offset = "0x6E33920", VA = "0x186E35120")]
		public void Play(Transform CKNIMDBOJEA, Quaternion APAHFEOKBOD, bool EGMPHJFGDHP = false, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E34FF0", Offset = "0x6E337F0", VA = "0x186E34FF0")]
		public void Play(Transform CKNIMDBOJEA, Vector3 PLENDAMEIMA, Quaternion APAHFEOKBOD, bool EGMPHJFGDHP = false, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E34C80", Offset = "0x6E33480", VA = "0x186E34C80")]
		public void Play(Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, Vector3 KFENDEDNACE, bool EGMPHJFGDHP = false, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E354B0", Offset = "0x6E33CB0", VA = "0x186E354B0")]
		public void Play(Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, bool EGMPHJFGDHP = false, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E35260", Offset = "0x6E33A60", VA = "0x186E35260")]
		public void Play(bool EGMPHJFGDHP = false, float ONGOGCHJHMN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E35DC0", Offset = "0x6E345C0", VA = "0x186E35DC0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E35D30", Offset = "0x6E34530", VA = "0x186E35D30")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E33E10", Offset = "0x6E32610", VA = "0x186E33E10")]
		private void ILDGCMKIGMN(float DBCGMGMJHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E33CA0", Offset = "0x6E324A0", VA = "0x186E33CA0")]
		private void HAFPOKJMCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E35570", Offset = "0x6E33D70", VA = "0x186E35570")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E35850", Offset = "0x6E34050", VA = "0x186E35850")]
		public void SetColor(Color JIINIIPALJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E34960", Offset = "0x6E33160", VA = "0x186E34960")]
		private void OBNBLMHEJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E363F0", Offset = "0x6E34BF0", VA = "0x186E363F0")]
		public PooledParticle()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IFPEJALJNJL<T> : JJMNNLLBAJO<T>, GHJKEMFHLHG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NHLMCGCKPIH<T> : GHJKEMFHLHG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ENFIPNHEEHD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FEHHKEKHGFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IDDCGNMEFME<T> : NBKOKFNHPDK<T>, IFPEJALJNJL<T>, JJMNNLLBAJO<T>, GHJKEMFHLHG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GDNHODELGOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public IDDCGNMEFME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public GDNHODELGOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2777F40", Offset = "0x2776740", VA = "0x182777F40")]
			internal void DCAPKAENBHC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1AAA820", Offset = "0x1AA9020", VA = "0x181AAA820")]
			internal void AFBKOBLJPLD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private NMAKHDNAMLE<T> JBDENDKBPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ObjectPool JBFMGALCEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private T KLLABPMEFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool PMADFOMNIPK;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x19D2410", Offset = "0x19D0C10", VA = "0x1819D2410")]
		public IDDCGNMEFME(NMAKHDNAMLE<T> JBDENDKBPFI, ObjectPool JBFMGALCEIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19D2270", Offset = "0x19D0A70", VA = "0x1819D2270", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class NCJNCLLOKEF<T> : ACOJIJEEGAO, NHLMCGCKPIH<T>, GHJKEMFHLHG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class IIBMGLLINJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public NCJNCLLOKEF<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public IIBMGLLINJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x249A4F0", Offset = "0x2498CF0", VA = "0x18249A4F0")]
			internal void DCAPKAENBHC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB09A50", Offset = "0xB08250", VA = "0x180B09A50")]
			internal void AFBKOBLJPLD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NMAKHDNAMLE<T> JBDENDKBPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool PMADFOMNIPK;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x402AF40", Offset = "0x4029740", VA = "0x18402AF40")]
		public NCJNCLLOKEF(NMAKHDNAMLE<T> JBDENDKBPFI, ObjectPool JBFMGALCEIO, int CLFMCDMMCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x402AEF0", Offset = "0x40296F0", VA = "0x18402AEF0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CPFAHJICEKA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FEHHKEKHGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NBKOKFNHPDK<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public NMAKHDNAMLE<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public CPFAHJICEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2447310", Offset = "0x2445B10", VA = "0x182447310")]
		internal void PLGFBLOGPIJ(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x24472B0", Offset = "0x2445AB0", VA = "0x1824472B0")]
		internal void OKPKDCAGGHA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2447200", Offset = "0x2445A00", VA = "0x182447200")]
		internal void ENBOGADPCAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly List<ENFIPNHEEHD> PHPIONOPEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private AOLIFDHHMEB NBJMLNFJBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private ObjectPool JBFMGALCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ObjectPool APMCAEJLHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E31960", Offset = "0x6E30160", VA = "0x186E31960")]
	private static void PMNFANJHDGI(Component CAOCJIHJELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E31C40", Offset = "0x6E30440", VA = "0x186E31C40")]
	public FEHHKEKHGFC(string NBKOLIOINOJ, int OCDJEOBNPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2376E60", Offset = "0x2375660", VA = "0x182376E60")]
	public IFPEJALJNJL<T> PPBDMLEBJHI<T>(AssetReference FKNDPBGMCOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2376A00", Offset = "0x2375200", VA = "0x182376A00")]
	public NHLMCGCKPIH<T> LOIOMFFBIMM<T>(AssetReference FKNDPBGMCOF, int JMKNAPEFDDB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2376AB0", Offset = "0x23752B0", VA = "0x182376AB0")]
	public JJMNNLLBAJO<bool> PINCLHPNEDE<T>(AssetReference FKNDPBGMCOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E31850", Offset = "0x6E30050", VA = "0x186E31850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E31580", Offset = "0x6E2FD80", VA = "0x186E31580")]
	private void CBDOGGLOIJE(UnityEngine.Object JNGFKHADOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E316C0", Offset = "0x6E2FEC0", VA = "0x186E316C0")]
	private ObjectPool DIKNILDFBJF(string NBKOLIOINOJ)
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
		private static GlobalPool NMCGONNHGCC;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static GameObject JDMNPIMJKLD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static GlobalPool OEFAOPMNMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E31FC0", Offset = "0x6E307C0", VA = "0x186E31FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1CAA700", Offset = "0x1CA8F00", VA = "0x181CAA700")]
		public static void SafeRelease<T>(T CEPDEAHBHLF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E31EE0", Offset = "0x6E306E0", VA = "0x186E31EE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E31FB0", Offset = "0x6E307B0", VA = "0x186E31FB0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Dictionary<Component, OONIIOJGNNG> IBFLGHCDICK;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x22F21A0", Offset = "0x22F09A0", VA = "0x1822F21A0")]
		public T Acquire<T>(T ALNJPMNLFGF, [Optional] Action<Component> BHFHAJBGKEK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x22F2520", Offset = "0x22F0D20", VA = "0x1822F2520")]
		public bool Release<T>(T CEPDEAHBHLF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x22F24C0", Offset = "0x22F0CC0", VA = "0x1822F24C0")]
		public void Prefill<T>(T ALNJPMNLFGF, int FCHJPHFDGOD, [Optional] Action<Component> IKKMFDHDGDE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x22F2410", Offset = "0x22F0C10", VA = "0x1822F2410")]
		public bool Exists<T>(T ALNJPMNLFGF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x22F2360", Offset = "0x22F0B60", VA = "0x1822F2360")]
		public void Clear<T>(T ALNJPMNLFGF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E32950", Offset = "0x6E31150", VA = "0x186E32950")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x22F2230", Offset = "0x22F0A30", VA = "0x1822F2230")]
		private OONIIOJGNNG BDLGOHPABOG<T>(T ALNJPMNLFGF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public void TrackInstantiation(string FNCCJPPPKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public void EnableStats(bool GMHKBNMGNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E32AB0", Offset = "0x6E312B0", VA = "0x186E32AB0")]
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
		public OONIIOJGNNG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2D0", Offset = "0xA4AAD0", VA = "0x180A4C2D0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class OONIIOJGNNG
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface HMMBKGCDFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KFPDLFMGKFL(bool LLMANHIAOLE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public abstract string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract int GEFPCDOCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LOIOMFFBIMM(int JMKNAPEFDDB, Action<Component> IKKMFDHDGDE);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PPBDMLEBJHI(Action<Component> BHFHAJBGKEK);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool CEEMIOIEFPP(Component OIMMFDPCJIJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EEMEPIGIECC();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E32430", Offset = "0x6E30C30", VA = "0x186E32430")]
	protected void DFMNOPCIDOD(Component CEPDEAHBHLF, bool LLMANHIAOLE, bool EGAILLBOOEM, bool JELFOEKOBPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E32240", Offset = "0x6E30A40", VA = "0x186E32240")]
	protected void BPGNOEKNOEM(Transform NFHABCEGAFB, bool LLMANHIAOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected OONIIOJGNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LPPEAMIMFJP<T> : OONIIOJGNNG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T ALNJPMNLFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ObjectPool MBJHNFLEOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool EGAILLBOOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private Queue<T> GBBJKDPBNJO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2A64310", Offset = "0x2A62B10", VA = "0x182A64310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int GEFPCDOCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2A645A0", Offset = "0x2A62DA0", VA = "0x182A645A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A64840", Offset = "0x2A63040", VA = "0x182A64840")]
	public LPPEAMIMFJP(T ALNJPMNLFGF, ObjectPool MBJHNFLEOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A64490", Offset = "0x2A62C90", VA = "0x182A64490", Slot = "6")]
	public override void LOIOMFFBIMM(int JMKNAPEFDDB, Action<Component> BHFHAJBGKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A645D0", Offset = "0x2A62DD0", VA = "0x182A645D0", Slot = "7")]
	public override Component PPBDMLEBJHI(Action<Component> BHFHAJBGKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A63F90", Offset = "0x2A62790", VA = "0x182A63F90", Slot = "8")]
	public override bool CEEMIOIEFPP(Component OIMMFDPCJIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A64120", Offset = "0x2A62920", VA = "0x182A64120", Slot = "9")]
	public override void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A64330", Offset = "0x2A62B30", VA = "0x182A64330")]
	private T IBLMIBMONPK()
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
		public interface CNIACMPCCCE
		{
			[Cpp2IlInjected.Token(Token = "0x17000019")]
			GameObject JFGADNLFGPJ
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
		[Cpp2IlInjected.Address(RVA = "0x6E325B0", Offset = "0x6E30DB0", VA = "0x186E325B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E328D0", Offset = "0x6E310D0", VA = "0x186E328D0")]
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
