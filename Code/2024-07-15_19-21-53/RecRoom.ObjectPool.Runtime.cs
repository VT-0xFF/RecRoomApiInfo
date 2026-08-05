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
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B52470", Offset = "0x6B50C70", VA = "0x186B52470")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OGCFILPLNFJ, float EPEOLMOBLGD, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B52110", Offset = "0x6B50910", VA = "0x186B52110")]
		public void SetDamageValue(float EPEOLMOBLGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B525F0", Offset = "0x6B50DF0", VA = "0x186B525F0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EMMCFOBGMIM<T> : MAKKFMNHCEA<T>, OABICBNODGM, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NANDCHMEDGB<T> : OABICBNODGM, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KJFDKBKLAFA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BFDEINJEGEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EACCPIKOCPL<T> : DPHELOEKPOL<T>, EMMCFOBGMIM<T>, MAKKFMNHCEA<T>, OABICBNODGM, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IIHKIBDENDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EACCPIKOCPL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public IIHKIBDENDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3E5F480", Offset = "0x3E5DC80", VA = "0x183E5F480")]
			internal void GJADKLJHKOE(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2748CD0", Offset = "0x27474D0", VA = "0x182748CD0")]
			internal void MELGEIOFEDA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GBMNPHMLGKB<T> MDMCEMFHACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool LPEADONKEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T BOLGDNNEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool LOOMHHLOKGF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37CDCA0", Offset = "0x37CC4A0", VA = "0x1837CDCA0")]
		public EACCPIKOCPL(GBMNPHMLGKB<T> MDMCEMFHACB, ObjectPool LPEADONKEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37CDB40", Offset = "0x37CC340", VA = "0x1837CDB40", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HOEJAMELDLG<T> : CNPNGJHMILJ, NANDCHMEDGB<T>, OABICBNODGM, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JLAAKPPMBEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HOEJAMELDLG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public JLAAKPPMBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x40A4C00", Offset = "0x40A3400", VA = "0x1840A4C00")]
			internal void GJADKLJHKOE(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB9FDA0", Offset = "0xB9E5A0", VA = "0x180B9FDA0")]
			internal void MELGEIOFEDA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GBMNPHMLGKB<T> MDMCEMFHACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LOOMHHLOKGF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D52650", Offset = "0x3D50E50", VA = "0x183D52650")]
		public HOEJAMELDLG(GBMNPHMLGKB<T> MDMCEMFHACB, ObjectPool LPEADONKEOK, int DGLGBEIJCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D525F0", Offset = "0x3D50DF0", VA = "0x183D525F0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PBDMGFKNOKD<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BFDEINJEGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DPHELOEKPOL<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GBMNPHMLGKB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PBDMGFKNOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x474DDD0", Offset = "0x474C5D0", VA = "0x18474DDD0")]
		internal void JNAMOLKOFAD(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x474DD70", Offset = "0x474C570", VA = "0x18474DD70")]
		internal void FJKJCDCEKFF(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x474DD20", Offset = "0x474C520", VA = "0x18474DD20")]
		internal void BACPOINEILG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<KJFDKBKLAFA> DBEGFMOMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FKLALLHDJKF HEDMNOGFIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool LPEADONKEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool NEAFMFNLEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B501C0", Offset = "0x6B4E9C0", VA = "0x186B501C0")]
	private static void GPCNCFJPNNE(Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B50750", Offset = "0x6B4EF50", VA = "0x186B50750")]
	public BFDEINJEGEL(string ODFKELNLEML, int EPHLKACLLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28BF710", Offset = "0x28BDF10", VA = "0x1828BF710")]
	public EMMCFOBGMIM<T> MCBLJONGBGM<T>(AssetReference PINPCFFKMLK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28BF220", Offset = "0x28BDA20", VA = "0x1828BF220")]
	public NANDCHMEDGB<T> CPBLDHDHPIH<T>(AssetReference PINPCFFKMLK, int IHGHLPOONHD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28BF2F0", Offset = "0x28BDAF0", VA = "0x1828BF2F0")]
	public MAKKFMNHCEA<bool> LNFEOGNEOOI<T>(AssetReference PINPCFFKMLK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B500D0", Offset = "0x6B4E8D0", VA = "0x186B500D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B50590", Offset = "0x6B4ED90", VA = "0x186B50590")]
	private void KFHOKLGNAFP(UnityEngine.Object DHHONPMBNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B50400", Offset = "0x6B4EC00", VA = "0x186B50400")]
	private ObjectPool HCHCOMDGDDD(string ODFKELNLEML)
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
		private static GlobalPool JPIINIOEAHL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject JEHCBOKKLEN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6B51160", Offset = "0x6B4F960", VA = "0x186B51160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B38920", Offset = "0x2B37120", VA = "0x182B38920")]
		public static void SafeRelease<T>(T MEAFIMADMKA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B51090", Offset = "0x6B4F890", VA = "0x186B51090")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B51150", Offset = "0x6B4F950", VA = "0x186B51150")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, DNDAGOOIEHM> FOFIIECDNJJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF560", Offset = "0x2CBDD60", VA = "0x182CBF560")]
		public T Acquire<T>(T OGCFILPLNFJ, [Optional] Action<Component> FDBIJKFHEOA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF910", Offset = "0x2CBE110", VA = "0x182CBF910")]
		public bool Release<T>(T MEAFIMADMKA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF8B0", Offset = "0x2CBE0B0", VA = "0x182CBF8B0")]
		public void Prefill<T>(T OGCFILPLNFJ, int MFALLPLNBBM, [Optional] Action<Component> BMNDGKOPMMH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF6D0", Offset = "0x2CBDED0", VA = "0x182CBF6D0")]
		public bool Exists<T>(T OGCFILPLNFJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF620", Offset = "0x2CBDE20", VA = "0x182CBF620")]
		public void Clear<T>(T OGCFILPLNFJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B51CB0", Offset = "0x6B504B0", VA = "0x186B51CB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF770", Offset = "0x2CBDF70", VA = "0x182CBF770")]
		private DNDAGOOIEHM OBMONMEFPIB<T>(T OGCFILPLNFJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public void TrackInstantiation(string IPEDCCFMFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public void EnableStats(bool CHKPOGJOJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B51E20", Offset = "0x6B50620", VA = "0x186B51E20")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DNDAGOOIEHM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MFGHMOJCIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MJBKDLJMAKK(bool ECOAPNDMJEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int EAHINMDHIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void CPBLDHDHPIH(int IHGHLPOONHD, Action<Component> BMNDGKOPMMH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component MCBLJONGBGM(Action<Component> FDBIJKFHEOA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NLCHOINDCPP(Component EIFNDIABMHD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void IMJJLGNDCEN();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B50E50", Offset = "0x6B4F650", VA = "0x186B50E50")]
	protected void LPLLKOBCDHA(Component MEAFIMADMKA, bool ECOAPNDMJEJ, bool HLDJAOEAOCB, bool JKDEFOBCNBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B50BD0", Offset = "0x6B4F3D0", VA = "0x186B50BD0")]
	protected void FAGEPDAMBPG(Transform OPEPBCJIPPN, bool ECOAPNDMJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	protected DNDAGOOIEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EMMJFDKOOAF<T> : DNDAGOOIEHM where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T OGCFILPLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool DELCNHOHOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HLDJAOEAOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> IDFADBPDLAB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3802AE0", Offset = "0x38012E0", VA = "0x183802AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int EAHINMDHIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3802DA0", Offset = "0x38015A0", VA = "0x183802DA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3803420", Offset = "0x3801C20", VA = "0x183803420")]
	public EMMJFDKOOAF(T OGCFILPLNFJ, ObjectPool DELCNHOHOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3802C70", Offset = "0x3801470", VA = "0x183802C70", Slot = "6")]
	public override void CPBLDHDHPIH(int IHGHLPOONHD, Action<Component> FDBIJKFHEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3802FF0", Offset = "0x38017F0", VA = "0x183802FF0", Slot = "7")]
	public override Component MCBLJONGBGM(Action<Component> FDBIJKFHEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3803270", Offset = "0x3801A70", VA = "0x183803270", Slot = "8")]
	public override bool NLCHOINDCPP(Component EIFNDIABMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3802DF0", Offset = "0x38015F0", VA = "0x183802DF0", Slot = "9")]
	public override void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3802B00", Offset = "0x3801300", VA = "0x183802B00")]
	private T CFBMDFNECPM()
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
		public interface OBJJNMCMGHA
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject KDMNFGPMMCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B51930", Offset = "0x6B50130", VA = "0x186B51930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B51C20", Offset = "0x6B50420", VA = "0x186B51C20")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool JPIINIOEAHL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject JEHCBOKKLEN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6B51F70", Offset = "0x6B50770", VA = "0x186B51F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B51EB0", Offset = "0x6B506B0", VA = "0x186B51EB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B51150", Offset = "0x6B4F950", VA = "0x186B51150")]
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
		public DNDAGOOIEHM PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NEJAMHOOPKN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PEHHIALCAPP(PooledParticle.LBLMHPPCKPJ GGKCNFLLBEE);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum EHFEPKKHKMA
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum LBLMHPPCKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface OHABCAHPIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool IOIPMPKKEHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 HGNDIHJPIJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera KBLLALGJDMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5A8B170", Offset = "0x5A89970", VA = "0x185A8B170")]
			public ColorConfiguration(ParticleSystem OGOEOBPLKLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6B509E0", Offset = "0x6B4F1E0", VA = "0x186B509E0")]
			public void EMALGMKGMMH(Color KIJNHGNFMMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class AHIPDLGPJBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public AHIPDLGPJBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6B500A0", Offset = "0x6B4E8A0", VA = "0x186B500A0")]
			internal void LPKGBDCOPFJ(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MEBKPJPGANI : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private OHABCAHPIPJ <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public MEBKPJPGANI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6B512D0", Offset = "0x6B4FAD0", VA = "0x186B512D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6B518E0", Offset = "0x6B500E0", VA = "0x186B518E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EHFPFHABFMC : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public EHFPFHABFMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6B50FD0", Offset = "0x6B4F7D0", VA = "0x186B50FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6B51040", Offset = "0x6B4F840", VA = "0x186B51040", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> EAPOHHEJHCI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<NEJAMHOOPKN> GBLHHELDEGE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> OAPPJENAFJJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GOOHGCNPLOF LAGNCODOANN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LMLONCMJHJE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool BADJABPHHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int JFJEHFPOCOB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private LBLMHPPCKPJ category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ParticleSystem.MinMaxGradient[] NMCLJJOKOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool JCPONIGABPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float NAGFDBEAANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float HCKLFPNBJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JOMBADMBPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 FEABBDBKAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 KBBCBFDPCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EHFEPKKHKMA AKOGCKGAFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GOOHGCNPLOF MDGEDMKBNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool BMHNJMJPIGF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> CNIAENIMLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6B55E50", Offset = "0x6B54650", VA = "0x186B55E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LBLMHPPCKPJ GINPNCFNIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8791F0", VA = "0x18087A9F0")]
			get
			{
				return default(LBLMHPPCKPJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IEONNLMMOMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool INMPDDDBHHD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6B55B80", Offset = "0x6B54380", VA = "0x186B55B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int MJIHEGFBKNE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6B55D00", Offset = "0x6B54500", VA = "0x186B55D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool NKHFCIHMIIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6B53730", Offset = "0x6B51F30", VA = "0x186B53730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem BMKILEPLIFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] HLAIDOMOIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] DJFDLMNENHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x856920", Offset = "0x855120", VA = "0x180856920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private EHFEPKKHKMA PBJIGPKHLAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x100E810", Offset = "0x100D010", VA = "0x18100E810")]
			get
			{
				return default(EHFEPKKHKMA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B53DD0", Offset = "0x6B525D0", VA = "0x186B53DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EDLDJPGGKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6B55AE0", Offset = "0x6B542E0", VA = "0x186B55AE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6B55EA0", Offset = "0x6B546A0", VA = "0x186B55EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B55470", Offset = "0x6B53C70", VA = "0x186B55470")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGCFILPLNFJ, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B555E0", Offset = "0x6B53DE0", VA = "0x186B555E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle OGCFILPLNFJ, Vector3 HGDCPNGLIKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B54B20", Offset = "0x6B53320", VA = "0x186B54B20")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B53260", Offset = "0x6B51A60", VA = "0x186B53260")]
		private void JDKPOOGNHEK(bool ALCIEIPEFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B53330", Offset = "0x6B51B30", VA = "0x186B53330")]
		[IteratorStateMachine(typeof(MEBKPJPGANI))]
		private static IEnumerator<JMPDKMJKKGA> JHMNJHHKGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B526D0", Offset = "0x6B50ED0", VA = "0x186B526D0")]
		private static void AMLCDIEJAJH(Stopwatch GFNLGFOFJFM, Vector3 PBMCJHDPGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B52CE0", Offset = "0x6B514E0", VA = "0x186B52CE0")]
		private static int EAHPANNLLGM(PooledParticle DIAAOCPNHKC, PooledParticle LLLBDLGIMPP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B53FD0", Offset = "0x6B527D0", VA = "0x186B53FD0")]
		private static int PEHHIALCAPP(LBLMHPPCKPJ GGKCNFLLBEE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B52D90", Offset = "0x6B51590", VA = "0x186B52D90")]
		protected void EHGNCICKNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B537B0", Offset = "0x6B51FB0", VA = "0x186B537B0")]
		protected void MJLBMHIGAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B52A20", Offset = "0x6B51220", VA = "0x186B52A20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6B53390", Offset = "0x6B51B90", VA = "0x186B53390")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B53F50", Offset = "0x6B52750", VA = "0x186B53F50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B52C50", Offset = "0x6B51450", VA = "0x186B52C50")]
		[IteratorStateMachine(typeof(EHFPFHABFMC))]
		private IEnumerator<JMPDKMJKKGA> BACCOLFFKFC(float HIEBMCLPBGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B53DF0", Offset = "0x6B525F0", VA = "0x186B53DF0")]
		private void NLCHOINDCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B55280", Offset = "0x6B53A80", VA = "0x186B55280")]
		public void SetDuration(float HIEBMCLPBGB, bool DCGGGIJDDJI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B540E0", Offset = "0x6B528E0", VA = "0x186B540E0")]
		public void Play(Transform EMCEBMCIEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B54790", Offset = "0x6B52F90", VA = "0x186B54790")]
		public void Play(Transform EMCEBMCIEAD, bool MMMBBNPOIGN, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B54240", Offset = "0x6B52A40", VA = "0x186B54240")]
		public void Play(Transform EMCEBMCIEAD, Vector3 KBBCBFDPCFD, bool MMMBBNPOIGN, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B54390", Offset = "0x6B52B90", VA = "0x186B54390")]
		public void Play(Transform KOHLDNDKJGK, Quaternion LCDJINCAHMD, bool MMMBBNPOIGN = false, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B54900", Offset = "0x6B53100", VA = "0x186B54900")]
		public void Play(Transform KOHLDNDKJGK, Vector3 KBBCBFDPCFD, Quaternion LCDJINCAHMD, bool MMMBBNPOIGN = false, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B545B0", Offset = "0x6B52DB0", VA = "0x186B545B0")]
		public void Play(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, Vector3 GPJLHMNPICC, bool MMMBBNPOIGN = false, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B544F0", Offset = "0x6B52CF0", VA = "0x186B544F0")]
		public void Play(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, bool MMMBBNPOIGN = false, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B54680", Offset = "0x6B52E80", VA = "0x186B54680")]
		public void Play(bool MMMBBNPOIGN = false, float JEDINHEMFGO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B553E0", Offset = "0x6B53BE0", VA = "0x186B553E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B55350", Offset = "0x6B53B50", VA = "0x186B55350")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B52F90", Offset = "0x6B51790", VA = "0x186B52F90")]
		private void EPIHNCLGNEK(float HIEBMCLPBGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B53120", Offset = "0x6B51920", VA = "0x186B53120")]
		private void HJLCHJDLHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B54A30", Offset = "0x6B53230", VA = "0x186B54A30")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B54CA0", Offset = "0x6B534A0", VA = "0x186B54CA0")]
		public void SetColor(Color KIJNHGNFMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B53600", Offset = "0x6B51E00", VA = "0x186B53600")]
		private void MJECEAMAPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B55A50", Offset = "0x6B54250", VA = "0x186B55A50")]
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
