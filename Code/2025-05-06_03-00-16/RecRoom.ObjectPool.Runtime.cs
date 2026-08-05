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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E777C0", Offset = "0x7E75FC0", VA = "0x187E777C0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles GLNOEJGIDBO, float FPKNNBMPJKP, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E77460", Offset = "0x7E75C60", VA = "0x187E77460")]
		public void SetDamageValue(float FPKNNBMPJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E77900", Offset = "0x7E76100", VA = "0x187E77900")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BLKKOIGFBCD<T> : KJPDFMLMKLI<T>, ELBPMMKABPA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PBPMPJJKGFI<T> : ELBPMMKABPA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AFNEOBHNJCE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HNGMKEFPBAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OPNBEOEGNKM<T> : NIBMKOGNDNO<T>, BLKKOIGFBCD<T>, KJPDFMLMKLI<T>, ELBPMMKABPA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CDPMIOPHBPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OPNBEOEGNKM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CDPMIOPHBPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x630CA90", Offset = "0x630B290", VA = "0x18630CA90")]
			internal void GJLCNIACNFJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3856530", Offset = "0x3854D30", VA = "0x183856530")]
			internal void BEKBLGGLCKL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GOANNPAHNKI<T> IILDALNLCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool IKHPACCHHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CHKHGNKGCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool IHDAJILAEEC;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x548F0C0", Offset = "0x548D8C0", VA = "0x18548F0C0")]
		public OPNBEOEGNKM(GOANNPAHNKI<T> IILDALNLCIJ, ObjectPool IKHPACCHHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x548EF50", Offset = "0x548D750", VA = "0x18548EF50", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CGJBCLEMBPA<T> : ADBHNDANFKF, PBPMPJJKGFI<T>, ELBPMMKABPA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AGCEAFJIBEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CGJBCLEMBPA<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public AGCEAFJIBEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x49E8990", Offset = "0x49E7190", VA = "0x1849E8990")]
			internal void GJLCNIACNFJ(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x13E21A0", Offset = "0x13E09A0", VA = "0x1813E21A0")]
			internal void BEKBLGGLCKL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GOANNPAHNKI<T> IILDALNLCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IHDAJILAEEC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63E74D0", Offset = "0x63E5CD0", VA = "0x1863E74D0")]
		public CGJBCLEMBPA(GOANNPAHNKI<T> IILDALNLCIJ, ObjectPool IKHPACCHHFP, int CMICLIBNLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63E7470", Offset = "0x63E5C70", VA = "0x1863E7470", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IBIPEONOHAN<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HNGMKEFPBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NIBMKOGNDNO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GOANNPAHNKI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IBIPEONOHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B56170", Offset = "0x4B54970", VA = "0x184B56170")]
		internal void PGINAGJKHKI(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B56110", Offset = "0x4B54910", VA = "0x184B56110")]
		internal void NBIGIBDJNJB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4B560C0", Offset = "0x4B548C0", VA = "0x184B560C0")]
		internal void LNHFDLNOHMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<AFNEOBHNJCE> AOGCDJFDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DPNBIGBDADA GDCOGCBMAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool IKHPACCHHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E76250", Offset = "0x7E74A50", VA = "0x187E76250")]
	private static void ELDEHDIBEIN(Component IKKBFHNKIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E76520", Offset = "0x7E74D20", VA = "0x187E76520")]
	public HNGMKEFPBAC(string JNGEILKPDIM, int IOBDNOGNKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37BFCD0", Offset = "0x37BE4D0", VA = "0x1837BFCD0")]
	public BLKKOIGFBCD<T> GDNGJAGCHOI<T>(AssetReference LHNFGDEANCN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37C01C0", Offset = "0x37BE9C0", VA = "0x1837C01C0")]
	public PBPMPJJKGFI<T> POAHCOANDAP<T>(AssetReference LHNFGDEANCN, int PCFOAHIEPDL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37BFDA0", Offset = "0x37BE5A0", VA = "0x1837BFDA0")]
	public KJPDFMLMKLI<bool> IPJBOCLFEHF<T>(AssetReference LHNFGDEANCN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E76160", Offset = "0x7E74960", VA = "0x187E76160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E75E90", Offset = "0x7E74690", VA = "0x187E75E90")]
	private void BAHNPPEFBEA(UnityEngine.Object MDDOBOKJJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E75FD0", Offset = "0x7E747D0", VA = "0x187E75FD0")]
	private ObjectPool BMPMLPMMMIM(string JNGEILKPDIM)
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
		private static GlobalPool GHLJPPEGBLN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject FEFKJCNLPME;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DJLOIKDDKCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7E75D40", Offset = "0x7E74540", VA = "0x187E75D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x379E9F0", Offset = "0x379D1F0", VA = "0x18379E9F0")]
		public static void SafeRelease<T>(T PNHCNFOFAFI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E75C70", Offset = "0x7E74470", VA = "0x187E75C70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E75D30", Offset = "0x7E74530", VA = "0x187E75D30")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ILFFAANPDIJ> IPOJINGAGJF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3962B90", Offset = "0x3961390", VA = "0x183962B90")]
		public T Acquire<T>(T GLNOEJGIDBO, [Optional] Action<Component> NILAGKPGIEH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3962F50", Offset = "0x3961750", VA = "0x183962F50")]
		public bool Release<T>(T PNHCNFOFAFI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3962EE0", Offset = "0x39616E0", VA = "0x183962EE0")]
		public void Prefill<T>(T GLNOEJGIDBO, int FKKPFCFANEB, [Optional] Action<Component> DFNAAMEBCLC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3962D00", Offset = "0x3961500", VA = "0x183962D00")]
		public bool Exists<T>(T GLNOEJGIDBO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3962C50", Offset = "0x3961450", VA = "0x183962C50")]
		public void Clear<T>(T GLNOEJGIDBO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E77020", Offset = "0x7E75820", VA = "0x187E77020")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3962DA0", Offset = "0x39615A0", VA = "0x183962DA0")]
		private ILFFAANPDIJ NEDBKDGDJBI<T>(T GLNOEJGIDBO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public void TrackInstantiation(string CGCFHCOPEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public void EnableStats(bool NOGOINBNOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E77190", Offset = "0x7E75990", VA = "0x187E77190")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ILFFAANPDIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HNGFGGLGADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NBCCPGOPMKN(bool AKADIMLNNID);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int DMBOOLECNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void POAHCOANDAP(int PCFOAHIEPDL, Action<Component> DFNAAMEBCLC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component GDNGJAGCHOI(Action<Component> NILAGKPGIEH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IHLFGIKCBJJ(Component OLFMBCENCHB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NNEMBDPLFBE();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E76A30", Offset = "0x7E75230", VA = "0x187E76A30")]
	protected void PEKEPHINFHC(Component PNHCNFOFAFI, bool AKADIMLNNID, bool MIBKOMOBGLH, bool PHLEMKHEKHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E767B0", Offset = "0x7E74FB0", VA = "0x187E767B0")]
	protected void KOFIEFGEAOL(Transform OOHFGJMGHKP, bool AKADIMLNNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected ILFFAANPDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JLAJBODOONB<T> : ILFFAANPDIJ where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T GLNOEJGIDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool MKFEGDIECNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MIBKOMOBGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> OAMFDIDBDGM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9380", Offset = "0x4DC7B80", VA = "0x184DC9380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int DMBOOLECNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4DC8B20", Offset = "0x4DC7320", VA = "0x184DC8B20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4DC94D0", Offset = "0x4DC7CD0", VA = "0x184DC94D0")]
	public JLAJBODOONB(T GLNOEJGIDBO, ObjectPool MKFEGDIECNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4DC93A0", Offset = "0x4DC7BA0", VA = "0x184DC93A0", Slot = "6")]
	public override void POAHCOANDAP(int PCFOAHIEPDL, Action<Component> NILAGKPGIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8B70", Offset = "0x4DC7370", VA = "0x184DC8B70", Slot = "7")]
	public override Component GDNGJAGCHOI(Action<Component> NILAGKPGIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8FC0", Offset = "0x4DC77C0", VA = "0x184DC8FC0", Slot = "8")]
	public override bool IHLFGIKCBJJ(Component OLFMBCENCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC9170", Offset = "0x4DC7970", VA = "0x184DC9170", Slot = "9")]
	public override void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8E00", Offset = "0x4DC7600", VA = "0x184DC8E00")]
	private T HDCFICHPGLM()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public interface AAJHAEGEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject JADDCPCKJOO
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E76CA0", Offset = "0x7E754A0", VA = "0x187E76CA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E76F90", Offset = "0x7E75790", VA = "0x187E76F90")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GHLJPPEGBLN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject FEFKJCNLPME;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool DJLOIKDDKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7E772E0", Offset = "0x7E75AE0", VA = "0x187E772E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E77220", Offset = "0x7E75A20", VA = "0x187E77220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E75D30", Offset = "0x7E74530", VA = "0x187E75D30")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ILFFAANPDIJ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KMDKPJNOMMO
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PAMPHHEAPGG(PooledParticle.CHLIAHCKEMA NACCBIPFJIO);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum BNPBJOMBJEK
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum CHLIAHCKEMA
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface APKEAFBMFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool OBGLEHIOIAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 DBGALDFHFOH
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera ENOIEKJDPLE
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6B37FA0", Offset = "0x6B367A0", VA = "0x186B37FA0")]
			public ColorConfiguration(ParticleSystem IHBPCPHHIFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7E75410", Offset = "0x7E73C10", VA = "0x187E75410")]
			public void GNHKIJLCOIB(Color AGNHOOELDII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MKDBBLHEBBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public MKDBBLHEBBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7E76BB0", Offset = "0x7E753B0", VA = "0x187E76BB0")]
			internal void NLIDLMFCDEG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EOBNDGKGDID : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private APKEAFBMFOJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public EOBNDGKGDID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7E75600", Offset = "0x7E73E00", VA = "0x187E75600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7E75C20", Offset = "0x7E74420", VA = "0x187E75C20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NKPMEMDKAOA : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public NKPMEMDKAOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7E76BE0", Offset = "0x7E753E0", VA = "0x187E76BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7E76C50", Offset = "0x7E75450", VA = "0x187E76C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FKCACAHLIOG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<KMDKPJNOMMO> JIIEEEEDHBH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> MILAHCIBFCI;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static KIJPFMOACHH GEKJNAMAFIA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float CNMKHDAFOIO = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool CFJGDDJEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int MGOGBIPKMNM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private CHLIAHCKEMA category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? IAMMPCLELMK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] PHDJMPNCKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FGBKJKOLELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float LEHBKCFPGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float PCBHLHLKIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform PEFANECKOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 HOECCGCLJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 JGLIOFFJNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private BNPBJOMBJEK LBIBABEPFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private KIJPFMOACHH OIMOOBEBPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool MKJOJFGAGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform KACHHHIDHKG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> MNCDPBEJEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B580", Offset = "0x7E79D80", VA = "0x187E7B580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CHLIAHCKEMA OJPIDIEENOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
			get
			{
				return default(CHLIAHCKEMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int GGGLDKJEIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ACOHCKOENBE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B2D0", Offset = "0x7E79AD0", VA = "0x187E7B2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int CENOMHEKFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B440", Offset = "0x7E79C40", VA = "0x187E7B440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool DMMEMGAHKJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7E78F20", Offset = "0x7E77720", VA = "0x187E78F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem NIPGALAMMKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] GLHFOBBJEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] KBBBNHHCFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BNPBJOMBJEK HNBEFJIKGLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E7C40", VA = "0x1809E9440")]
			get
			{
				return default(BNPBJOMBJEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7E792D0", Offset = "0x7E77AD0", VA = "0x187E792D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform POFBAOBKAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B5D0", Offset = "0x7E79DD0", VA = "0x187E7B5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OFMKBNCFEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B230", Offset = "0x7E79A30", VA = "0x187E7B230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E7B620", Offset = "0x7E79E20", VA = "0x187E7B620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E7AC70", Offset = "0x7E79470", VA = "0x187E7AC70")]
		public static PooledParticle TryPlayPrefab(PooledParticle GLNOEJGIDBO, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E7AD90", Offset = "0x7E79590", VA = "0x187E7AD90")]
		public static PooledParticle TryPlayPrefab(PooledParticle GLNOEJGIDBO, Vector3 NCGKJMOKFAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E7A260", Offset = "0x7E78A60", VA = "0x187E7A260")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E77DB0", Offset = "0x7E765B0", VA = "0x187E77DB0")]
		private void BLMOOGBNGEE(bool CEHDHOOIGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E77D50", Offset = "0x7E76550", VA = "0x187E77D50")]
		[IteratorStateMachine(typeof(EOBNDGKGDID))]
		private static IEnumerator<IGCELENFGND> BJKJCHFNBIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E785B0", Offset = "0x7E76DB0", VA = "0x187E785B0")]
		private static void JLJCCBFFNJJ(Stopwatch NIBJMJJGOBF, Vector3 GBDLBAFAGJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E783A0", Offset = "0x7E76BA0", VA = "0x187E783A0")]
		private static int GAJCICEENFB(PooledParticle ANGFJALIIBO, PooledParticle LNEMONKDKMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E79520", Offset = "0x7E77D20", VA = "0x187E79520")]
		private static int PAMPHHEAPGG(CHLIAHCKEMA NACCBIPFJIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E781B0", Offset = "0x7E769B0", VA = "0x187E781B0")]
		protected void EONEAKCHNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E78920", Offset = "0x7E77120", VA = "0x187E78920")]
		protected void KMPCOJJPNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E77A70", Offset = "0x7E76270", VA = "0x187E77A70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E78FA0", Offset = "0x7E777A0", VA = "0x187E78FA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E79490", Offset = "0x7E77C90", VA = "0x187E79490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7E779E0", Offset = "0x7E761E0", VA = "0x187E779E0")]
		[IteratorStateMachine(typeof(NKPMEMDKAOA))]
		private IEnumerator<IGCELENFGND> ANCICBPNKGJ(float DJFBMECKBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E78450", Offset = "0x7E76C50", VA = "0x187E78450")]
		private void IHLFGIKCBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7E7A9B0", Offset = "0x7E791B0", VA = "0x187E7A9B0")]
		public void SetDuration(float DJFBMECKBEL, bool ADJFDFMBEPG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E79630", Offset = "0x7E77E30", VA = "0x187E79630")]
		public void Play(Transform FALNFDPOLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E79ED0", Offset = "0x7E786D0", VA = "0x187E79ED0")]
		public void Play(Transform FALNFDPOLFG, bool NCANPLCFOCE, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E79780", Offset = "0x7E77F80", VA = "0x187E79780")]
		public void Play(Transform FALNFDPOLFG, Vector3 JGLIOFFJNJE, bool NCANPLCFOCE, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E798D0", Offset = "0x7E780D0", VA = "0x187E798D0")]
		public void Play(Transform BELIIBLFAEK, Quaternion PMHMEKBKJJA, bool NCANPLCFOCE = false, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E7A040", Offset = "0x7E78840", VA = "0x187E7A040")]
		public void Play(Transform BELIIBLFAEK, Vector3 JGLIOFFJNJE, Quaternion PMHMEKBKJJA, bool NCANPLCFOCE = false, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E79B70", Offset = "0x7E78370", VA = "0x187E79B70")]
		public void Play(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, Vector3 CPDFCHMENBI, bool NCANPLCFOCE = false, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E79A10", Offset = "0x7E78210", VA = "0x187E79A10")]
		public void Play(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, bool NCANPLCFOCE = false, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E79CF0", Offset = "0x7E784F0", VA = "0x187E79CF0")]
		public void Play(bool NCANPLCFOCE = false, float JHFBBIBMFHB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E7ABD0", Offset = "0x7E793D0", VA = "0x187E7ABD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E7AA80", Offset = "0x7E79280", VA = "0x187E7AA80")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E792F0", Offset = "0x7E77AF0", VA = "0x187E792F0")]
		private void OIPMLDHINIO(float DJFBMECKBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E77FB0", Offset = "0x7E767B0", VA = "0x187E77FB0")]
		private void CLEGDFLMOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7E7A170", Offset = "0x7E78970", VA = "0x187E7A170")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7E7A3E0", Offset = "0x7E78BE0", VA = "0x187E7A3E0")]
		public void SetColor(Color AGNHOOELDII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E780F0", Offset = "0x7E768F0", VA = "0x187E780F0")]
		private void COINGNKJPHD(float? OIKKJHNFKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E77CE0", Offset = "0x7E764E0", VA = "0x187E77CE0")]
		private void BHHBHHGMOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E77E80", Offset = "0x7E76680", VA = "0x187E77E80")]
		private void CDGGCFNBIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E7B1A0", Offset = "0x7E799A0", VA = "0x187E7B1A0")]
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
