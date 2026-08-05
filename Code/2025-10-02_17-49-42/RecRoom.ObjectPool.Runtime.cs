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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88B1160", Offset = "0x88AFB60", VA = "0x1888B1160")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IGAKMAMDNNB, float LBNJLNLGLGC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88B0E00", Offset = "0x88AF800", VA = "0x1888B0E00")]
		public void SetDamageValue(float LBNJLNLGLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88B12A0", Offset = "0x88AFCA0", VA = "0x1888B12A0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MOCAOJBCJKF<T> : FKFADEBPFBK<T>, CNBBKAECPOB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DONNHIMNCCB<T> : CNBBKAECPOB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BAEAHIALNOA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NBMCKLBGJAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NGMEBKLFGKM<T> : MKNKHCFGBKA<T>, MOCAOJBCJKF<T>, FKFADEBPFBK<T>, CNBBKAECPOB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ACKFEPPINOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NGMEBKLFGKM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public ACKFEPPINOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5301F20", Offset = "0x5300920", VA = "0x185301F20")]
			internal void DFKCOOJLNMK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3F28480", Offset = "0x3F26E80", VA = "0x183F28480")]
			internal void AFLDGJHNCCJ(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AACADPLMCLK<T> JHKNHJKPHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool DNPJIJJOMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T GMFHHDBKLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JPNPFIIDGCJ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A870", Offset = "0x5A59270", VA = "0x185A5A870")]
		public NGMEBKLFGKM(AACADPLMCLK<T> JHKNHJKPHIL, ObjectPool DNPJIJJOMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A730", Offset = "0x5A59130", VA = "0x185A5A730", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GGFOJKKIOHG<T> : FNHGFPOHNDG, DONNHIMNCCB<T>, CNBBKAECPOB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ANIJKCHPCIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GGFOJKKIOHG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public ANIJKCHPCIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x54E03D0", Offset = "0x54DEDD0", VA = "0x1854E03D0")]
			internal void DFKCOOJLNMK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x173D3D0", Offset = "0x173BDD0", VA = "0x18173D3D0")]
			internal void AFLDGJHNCCJ(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AACADPLMCLK<T> JHKNHJKPHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JPNPFIIDGCJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x512AD60", Offset = "0x5129760", VA = "0x18512AD60")]
		public GGFOJKKIOHG(AACADPLMCLK<T> JHKNHJKPHIL, ObjectPool DNPJIJJOMGD, int CJCMLCLGCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x512AD00", Offset = "0x5129700", VA = "0x18512AD00", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OPLNDBCIIBM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NBMCKLBGJAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MKNKHCFGBKA<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AACADPLMCLK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OPLNDBCIIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE790", Offset = "0x5BDD190", VA = "0x185BDE790")]
		internal void PEOOLIKMGIH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE730", Offset = "0x5BDD130", VA = "0x185BDE730")]
		internal void PBAPDBFKPCC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE6E0", Offset = "0x5BDD0E0", VA = "0x185BDE6E0")]
		internal void JCIHKDFCGOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<BAEAHIALNOA> ILPGIPNFDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LFMGKEHKAGB NCLEJOKHAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool DNPJIJJOMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88AFF70", Offset = "0x88AE970", VA = "0x1888AFF70")]
	private static void INBBMKLCPIA(Component ADKKEOFFDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88B0390", Offset = "0x88AED90", VA = "0x1888B0390")]
	public NBMCKLBGJAO(string JLLMPMKJKMF, int NEMICMIOFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3F04AE0", Offset = "0x3F034E0", VA = "0x183F04AE0")]
	public MOCAOJBCJKF<T> MEFJCANOAEB<T>(AssetReference DHOJDOPBGKO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F04630", Offset = "0x3F03030", VA = "0x183F04630")]
	public DONNHIMNCCB<T> ACLFHPABEFL<T>(AssetReference DHOJDOPBGKO, int MHMCOJIKNCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F046E0", Offset = "0x3F030E0", VA = "0x183F046E0")]
	public FKFADEBPFBK<bool> JBKJHIIAKGB<T>(AssetReference DHOJDOPBGKO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x88AFE80", Offset = "0x88AE880", VA = "0x1888AFE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88B01C0", Offset = "0x88AEBC0", VA = "0x1888B01C0")]
	private void OBAKJFNDHNB(UnityEngine.Object IKIAAJPCBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88AFCF0", Offset = "0x88AE6F0", VA = "0x1888AFCF0")]
	private ObjectPool ACCBEACIDNL(string JLLMPMKJKMF)
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GlobalPool GHBNEILHBAO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject DPFMPAAMCGL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool FLGHCDNLMND
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88AFB80", Offset = "0x88AE580", VA = "0x1888AFB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBC170", Offset = "0x3DBAB70", VA = "0x183DBC170")]
		public static void SafeRelease<T>(T PMNHIPACJLN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88AFAB0", Offset = "0x88AE4B0", VA = "0x1888AFAB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88AFB70", Offset = "0x88AE570", VA = "0x1888AFB70")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct LLPPOAPAJOG<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T PFBHGMMFEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool DDFKDPINPIO;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T AFPBILBCKEL
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
			internal LLPPOAPAJOG(T KMAFNKGMDCF, ObjectPool DDFKDPINPIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5741770", Offset = "0x5740170", VA = "0x185741770", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, FAJBLBHJMMC> IKBHGEAIBON;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D1B0", Offset = "0x3F5BBB0", VA = "0x183F5D1B0")]
		public T Acquire<T>(T IGAKMAMDNNB, [Optional] Action<Component> JLODAAMHHNB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D130", Offset = "0x3F5BB30", VA = "0x183F5D130")]
		public LLPPOAPAJOG<T> AcquirePooledObject<T>(T IGAKMAMDNNB, [Optional] Action<Component> JLODAAMHHNB) where T : Component
		{
			return default(LLPPOAPAJOG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D520", Offset = "0x3F5BF20", VA = "0x183F5D520")]
		public bool Release<T>(T PMNHIPACJLN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D4D0", Offset = "0x3F5BED0", VA = "0x183F5D4D0")]
		public void Prefill<T>(T IGAKMAMDNNB, int NBFNJKLKPMO, [Optional] Action<Component> ANDBOOMMJJN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D2F0", Offset = "0x3F5BCF0", VA = "0x183F5D2F0")]
		public bool Exists<T>(T IGAKMAMDNNB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D240", Offset = "0x3F5BC40", VA = "0x183F5D240")]
		public void Clear<T>(T IGAKMAMDNNB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88B09A0", Offset = "0x88AF3A0", VA = "0x1888B09A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D390", Offset = "0x3F5BD90", VA = "0x183F5D390")]
		private FAJBLBHJMMC PNAKFAMPBEH<T>(T IGAKMAMDNNB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public void TrackInstantiation(string GIJPKBFOPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public void EnableStats(bool PCFJJDEKPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88B0B10", Offset = "0x88AF510", VA = "0x1888B0B10")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FAJBLBHJMMC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface HIFBKFBCBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LHOFAKEMFFK(bool JNNEMJKMKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int BNKCLHLIMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void ACLFHPABEFL(int MHMCOJIKNCI, Action<Component> ANDBOOMMJJN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component MEFJCANOAEB(Action<Component> JLODAAMHHNB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool KKMANOPBDMJ(Component JMEDJALIAEG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EMMOLKMNHIK();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88AF2C0", Offset = "0x88ADCC0", VA = "0x1888AF2C0")]
	protected void LIFPMLINAIF(Component PMNHIPACJLN, bool JNNEMJKMKNP, bool HNCPNHLDLOG, bool KDDNGPBAJKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88AF040", Offset = "0x88ADA40", VA = "0x1888AF040")]
	protected void IFGKDIAJOCA(Transform JNFDPPPBEAB, bool JNNEMJKMKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected FAJBLBHJMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OENKFHKLHJE<T> : FAJBLBHJMMC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T IGAKMAMDNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool EPIBNMOGOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool HNCPNHLDLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> ABJGHBLGNFB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BA97C0", Offset = "0x5BA81C0", VA = "0x185BA97C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int BNKCLHLIMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BA93E0", Offset = "0x5BA7DE0", VA = "0x185BA93E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9BF0", Offset = "0x5BA85F0", VA = "0x185BA9BF0")]
	public OENKFHKLHJE(T IGAKMAMDNNB, ObjectPool EPIBNMOGOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5BA92D0", Offset = "0x5BA7CD0", VA = "0x185BA92D0", Slot = "6")]
	public override void ACLFHPABEFL(int MHMCOJIKNCI, Action<Component> JLODAAMHHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9980", Offset = "0x5BA8380", VA = "0x185BA9980", Slot = "7")]
	public override Component MEFJCANOAEB(Action<Component> JLODAAMHHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5BA97E0", Offset = "0x5BA81E0", VA = "0x185BA97E0", Slot = "8")]
	public override bool KKMANOPBDMJ(Component JMEDJALIAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9420", Offset = "0x5BA7E20", VA = "0x185BA9420", Slot = "9")]
	public override void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5BA9610", Offset = "0x5BA8010", VA = "0x185BA9610")]
	private T ENKLBKGICPK()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public interface BAMNHDMDBMF
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject AHFGKNCNHPM
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88B0620", Offset = "0x88AF020", VA = "0x1888B0620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88B0910", Offset = "0x88AF310", VA = "0x1888B0910")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool GHBNEILHBAO;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject DPFMPAAMCGL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool FLGHCDNLMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C60", Offset = "0x88AF660", VA = "0x1888B0C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88B0BA0", Offset = "0x88AF5A0", VA = "0x1888B0BA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88AFB70", Offset = "0x88AE570", VA = "0x1888AFB70")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public FAJBLBHJMMC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JOIOPGKFCKG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KEGBADGHMLC(PooledParticle.GLCFNCCKCCN NOJNONODDMI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum JCAAOOAECIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum GLCFNCCKCCN
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface EIEIDPAANDD
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool MLNDKOGMFCN
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 KEJIGFBGDPB
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera APIKMINLPNM
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x74276E0", Offset = "0x74260E0", VA = "0x1874276E0")]
			public ColorConfiguration(ParticleSystem AIIJOJMBFEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x88AEE50", Offset = "0x88AD850", VA = "0x1888AEE50")]
			public void BAEOBNAPOHN(Color EOGEFFOIIOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CBGNKCGCCMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public CBGNKCGCCMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88AEE20", Offset = "0x88AD820", VA = "0x1888AEE20")]
			internal void IFBLBPBCIKA(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FGMCFENFGPA : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JFFMJDIOLAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private EIEIDPAANDD <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public FGMCFENFGPA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x88AF440", Offset = "0x88ADE40", VA = "0x1888AF440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x88AFA60", Offset = "0x88AE460", VA = "0x1888AFA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> OBHMEELEPFA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<JOIOPGKFCKG> ELILGAALJOE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static List<PooledParticle> EBIGMALBEHP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static LCOHCCBKPLJ JJHNFDHDMEK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float MIKDLNKDHNI = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static bool AADMDKPDNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected int GGGHABOEDHB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private GLCFNCCKCCN category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float? CEGDHIABHCP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] FOLOKFNLOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] EHBHNCHGFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool JMJOEBKONJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float NBGACEBHIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float GEJMJHHNPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Transform KNJGJFPCEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 OOLMACPHPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 PPHGHCFBNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private JCAAOOAECIN ENDFGMIJMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LCOHCCBKPLJ FFCAGFOICFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected bool OHKCLKIOIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Transform OAEEPEDFFEE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> ELALGKNHMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88B4DD0", Offset = "0x88B37D0", VA = "0x1888B4DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GLCFNCCKCCN KIKCDFHIPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			get
			{
				return default(GLCFNCCKCCN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JIFLKKJMOPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool APIHKJHKGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88B4B00", Offset = "0x88B3500", VA = "0x1888B4B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int HHKMBIIDCDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88B4C80", Offset = "0x88B3680", VA = "0x1888B4C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool NDMMMHLOLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88B1B80", Offset = "0x88B0580", VA = "0x1888B1B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem NMAMECKKCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] PMGHFHBHAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] IHCAMBPCOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JCAAOOAECIN JCEMEODNPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF68C90", Offset = "0xF67690", VA = "0x180F68C90")]
			get
			{
				return default(JCAAOOAECIN);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88B2210", Offset = "0x88B0C10", VA = "0x1888B2210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform HALOMIKDIAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x88B4E20", Offset = "0x88B3820", VA = "0x1888B4E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MOMIBDCEFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88B4A60", Offset = "0x88B3460", VA = "0x1888B4A60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88B4E70", Offset = "0x88B3870", VA = "0x1888B4E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88B4470", Offset = "0x88B2E70", VA = "0x1888B4470")]
		public static PooledParticle TryPlayPrefab(PooledParticle IGAKMAMDNNB, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88B4590", Offset = "0x88B2F90", VA = "0x1888B4590")]
		public static PooledParticle TryPlayPrefab(PooledParticle IGAKMAMDNNB, Vector3 KFJFDPLEJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88B3BD0", Offset = "0x88B25D0", VA = "0x1888B3BD0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88B2420", Offset = "0x88B0E20", VA = "0x1888B2420")]
		private void JMOBEKFLPAK(bool FCCCGLOCDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88B2D10", Offset = "0x88B1710", VA = "0x1888B2D10")]
		[IteratorStateMachine(typeof(FGMCFENFGPA))]
		private static IEnumerator<JFFMJDIOLAN> NONKACPGOMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88B1810", Offset = "0x88B0210", VA = "0x1888B1810")]
		private static void CLNBIOBFFHL(Stopwatch KIGHMIAOFFO, Vector3 IKKAAGBOBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88B2930", Offset = "0x88B1330", VA = "0x1888B2930")]
		private static int LCEOLFFLABI(PooledParticle CFAKKPGMPGD, PooledParticle KMGOFHJBCKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88B2620", Offset = "0x88B1020", VA = "0x1888B2620")]
		private static int KEGBADGHMLC(GLCFNCCKCCN NOJNONODDMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88B2230", Offset = "0x88B0C30", VA = "0x1888B2230")]
		protected void IOMBIGBOBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88B1C00", Offset = "0x88B0600", VA = "0x1888B1C00")]
		protected void IBGPJMDJFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88B1380", Offset = "0x88AFD80", VA = "0x1888B1380", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88B29E0", Offset = "0x88B13E0", VA = "0x1888B29E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88B2DE0", Offset = "0x88B17E0", VA = "0x1888B2DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88B2730", Offset = "0x88B1130", VA = "0x1888B2730")]
		private void KKMANOPBDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88B4200", Offset = "0x88B2C00", VA = "0x1888B4200")]
		public void SetDuration(float NDKGEJPCLBH, bool FJBAGINIHMO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88B2F30", Offset = "0x88B1930", VA = "0x1888B2F30")]
		public void Play(Transform EEMIGBABKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88B37A0", Offset = "0x88B21A0", VA = "0x1888B37A0")]
		public void Play(Transform EEMIGBABKIJ, bool HPAGPEBDHDF, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88B3090", Offset = "0x88B1A90", VA = "0x1888B3090")]
		public void Play(Transform EEMIGBABKIJ, Vector3 PPHGHCFBNLP, bool HPAGPEBDHDF, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88B31E0", Offset = "0x88B1BE0", VA = "0x1888B31E0")]
		public void Play(Transform DOHNPGNIECB, Quaternion AMHDLJKDJBK, bool HPAGPEBDHDF = false, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88B3910", Offset = "0x88B2310", VA = "0x1888B3910")]
		public void Play(Transform DOHNPGNIECB, Vector3 PPHGHCFBNLP, Quaternion AMHDLJKDJBK, bool HPAGPEBDHDF = false, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88B3480", Offset = "0x88B1E80", VA = "0x1888B3480")]
		public void Play(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, Vector3 GMOGCJLCJBF, bool HPAGPEBDHDF = false, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88B3320", Offset = "0x88B1D20", VA = "0x1888B3320")]
		public void Play(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, bool HPAGPEBDHDF = false, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x88B3600", Offset = "0x88B2000", VA = "0x1888B3600")]
		public void Play(bool HPAGPEBDHDF = false, float NNIGLKCCIAJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88B43D0", Offset = "0x88B2DD0", VA = "0x1888B43D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88B42D0", Offset = "0x88B2CD0", VA = "0x1888B42D0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88B1600", Offset = "0x88B0000", VA = "0x1888B1600")]
		private void BKPJJDOLMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88B3A40", Offset = "0x88B2440", VA = "0x1888B3A40")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88B3D50", Offset = "0x88B2750", VA = "0x1888B3D50")]
		public void SetColor(Color EOGEFFOIIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88B2E70", Offset = "0x88B1870", VA = "0x1888B2E70")]
		private void PNPLFBDBKEN(float? LKKNOPLOOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88B2D70", Offset = "0x88B1770", VA = "0x1888B2D70")]
		private void OLLJEHODPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88B24F0", Offset = "0x88B0EF0", VA = "0x1888B24F0")]
		private void JOEMCLFJAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88B49C0", Offset = "0x88B33C0", VA = "0x1888B49C0")]
		public PooledParticle()
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
