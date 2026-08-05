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
		[SerializeField]
		[Header("Impact Particle Start Size")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FEFA80", Offset = "0x6FEEE80", VA = "0x186FEFA80")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ACHABLJAHGP, float IPBDHKJBKPK, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF720", Offset = "0x6FEEB20", VA = "0x186FEF720")]
		public void SetDamageValue(float IPBDHKJBKPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFC00", Offset = "0x6FEF000", VA = "0x186FEFC00")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OEMNECOGKHN<T> : ELLFHPNCMJG<T>, NNKCIMLKELB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EOGEONJLGLN<T> : NNKCIMLKELB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PGOHGGEAPEM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MMEIKGKMHEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LCPGPHDNCKG<T> : JGFPMDAOPIA<T>, OEMNECOGKHN<T>, ELLFHPNCMJG<T>, NNKCIMLKELB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DHLKDEKPJHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LCPGPHDNCKG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public DHLKDEKPJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4930", Offset = "0x5BF3D30", VA = "0x185BF4930")]
			internal void LJGJHBLLKLC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2DCD330", Offset = "0x2DCC730", VA = "0x182DCD330")]
			internal void FBJPEOLDBPA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OELCFEONCJD<T> DEBMALHNGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GMMDFLGDEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T NAEMIMNOMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool AAFPLDAFGFB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x45E17D0", Offset = "0x45E0BD0", VA = "0x1845E17D0")]
		public LCPGPHDNCKG(OELCFEONCJD<T> DEBMALHNGBM, ObjectPool GMMDFLGDEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x45E1660", Offset = "0x45E0A60", VA = "0x1845E1660", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ONKMJFOKMKN<T> : ONPFBNMJAGM, EOGEONJLGLN<T>, NNKCIMLKELB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GAKNINNGJMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ONKMJFOKMKN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public GAKNINNGJMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x40004A0", Offset = "0x3FFF8A0", VA = "0x1840004A0")]
			internal void LJGJHBLLKLC(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xEC1DB0", Offset = "0xEC11B0", VA = "0x180EC1DB0")]
			internal void FBJPEOLDBPA(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private OELCFEONCJD<T> DEBMALHNGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool AAFPLDAFGFB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4A81580", Offset = "0x4A80980", VA = "0x184A81580")]
		public ONKMJFOKMKN(OELCFEONCJD<T> DEBMALHNGBM, ObjectPool GMMDFLGDEAL, int FANHNLAFDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A81520", Offset = "0x4A80920", VA = "0x184A81520", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BBDOJLKGLJM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MMEIKGKMHEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JGFPMDAOPIA<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OELCFEONCJD<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BBDOJLKGLJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52179B0", Offset = "0x5216DB0", VA = "0x1852179B0")]
		internal void ELMOHMLBPHI(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5217A60", Offset = "0x5216E60", VA = "0x185217A60")]
		internal void KADDNIHFEEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5217AC0", Offset = "0x5216EC0", VA = "0x185217AC0")]
		internal void NOCOPGHLDMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<PGOHGGEAPEM> LJDACMGPJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HBLJNOLIMGB KLILNHMABMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GMMDFLGDEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool AAFPLDAFGFB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE610", Offset = "0x6FEDA10", VA = "0x186FEE610")]
	private static void AEFHDNMCKDH(Component COMALCPHDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FEECB0", Offset = "0x6FEE0B0", VA = "0x186FEECB0")]
	public MMEIKGKMHEG(string NJNIIEFNNGN, int JBKCDOMACAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FC69C0", Offset = "0x2FC5DC0", VA = "0x182FC69C0")]
	public OEMNECOGKHN<T> PBBCGENJODN<T>(AssetReference LFDHDKKAIGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FC68E0", Offset = "0x2FC5CE0", VA = "0x182FC68E0")]
	public EOGEONJLGLN<T> LALPEKLCANO<T>(AssetReference LFDHDKKAIGE, int GMOPHNCDIJO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FC64A0", Offset = "0x2FC58A0", VA = "0x182FC64A0")]
	public ELLFHPNCMJG<bool> ICLDDBMHILA<T>(AssetReference LFDHDKKAIGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE860", Offset = "0x6FEDC60", VA = "0x186FEE860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEAE0", Offset = "0x6FEDEE0", VA = "0x186FEEAE0")]
	private void NEJONOEIHKI(UnityEngine.Object EMNPOOCPPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE950", Offset = "0x6FEDD50", VA = "0x186FEE950")]
	private ObjectPool JBANCMOOEDC(string NJNIIEFNNGN)
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
		private static GlobalPool GCEFLAOMCHN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CALNOHMIHCD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool GHDNHBBFDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FED940", Offset = "0x6FECD40", VA = "0x186FED940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4D00", Offset = "0x2EC4100", VA = "0x182EC4D00")]
		public static void SafeRelease<T>(T FAKGLFFOLFI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FED870", Offset = "0x6FECC70", VA = "0x186FED870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FED930", Offset = "0x6FECD30", VA = "0x186FED930")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LFKFLMMEJBM> HPOOOHAPKDO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3098B20", Offset = "0x3097F20", VA = "0x183098B20")]
		public T Acquire<T>(T ACHABLJAHGP, [Optional] Action<Component> LKOKHINKKNG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3098EE0", Offset = "0x30982E0", VA = "0x183098EE0")]
		public bool Release<T>(T FAKGLFFOLFI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3098E70", Offset = "0x3098270", VA = "0x183098E70")]
		public void Prefill<T>(T ACHABLJAHGP, int MNOBAEHNJIO, [Optional] Action<Component> AGMDMKAOBNP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3098DD0", Offset = "0x30981D0", VA = "0x183098DD0")]
		public bool Exists<T>(T ACHABLJAHGP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3098BE0", Offset = "0x3097FE0", VA = "0x183098BE0")]
		public void Clear<T>(T ACHABLJAHGP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF2C0", Offset = "0x6FEE6C0", VA = "0x186FEF2C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3098C90", Offset = "0x3098090", VA = "0x183098C90")]
		private LFKFLMMEJBM EJPKEGENHOO<T>(T ACHABLJAHGP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public void TrackInstantiation(string EPCAINKIKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public void EnableStats(bool DCNCGILMHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF430", Offset = "0x6FEE830", VA = "0x186FEF430")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LFKFLMMEJBM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MMPLKOPPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PDGMJEKPCGJ(bool PNJBBPJHGNF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int PJDIFEKHENB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LALPEKLCANO(int GMOPHNCDIJO, Action<Component> AGMDMKAOBNP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PBBCGENJODN(Action<Component> LKOKHINKKNG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool AFNCKMDLBLN(Component LDNLNKHKMPL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void FEPOBOIDOBF();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE210", Offset = "0x6FED610", VA = "0x186FEE210")]
	protected void JIEHEHKMMAM(Component FAKGLFFOLFI, bool PNJBBPJHGNF, bool LOEJBLJPJPM, bool LCNBIPHAABP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE390", Offset = "0x6FED790", VA = "0x186FEE390")]
	protected void POGBAALADHA(Transform PDPOFGDPJNJ, bool PNJBBPJHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected LFKFLMMEJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OGIAFGHGBCO<T> : LFKFLMMEJBM where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T ACHABLJAHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool EANFNMADBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool LOEJBLJPJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> FBMPAEOCLCF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4A53BB0", Offset = "0x4A52FB0", VA = "0x184A53BB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int PJDIFEKHENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4A53DE0", Offset = "0x4A531E0", VA = "0x184A53DE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A541F0", Offset = "0x4A535F0", VA = "0x184A541F0")]
	public OGIAFGHGBCO(T ACHABLJAHGP, ObjectPool EANFNMADBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E30", Offset = "0x4A53230", VA = "0x184A53E30", Slot = "6")]
	public override void LALPEKLCANO(int GMOPHNCDIJO, Action<Component> LKOKHINKKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A53F60", Offset = "0x4A53360", VA = "0x184A53F60", Slot = "7")]
	public override Component PBBCGENJODN(Action<Component> LKOKHINKKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4A53880", Offset = "0x4A52C80", VA = "0x184A53880", Slot = "8")]
	public override bool AFNCKMDLBLN(Component LDNLNKHKMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A53BD0", Offset = "0x4A52FD0", VA = "0x184A53BD0", Slot = "9")]
	public override void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A53A30", Offset = "0x4A52E30", VA = "0x184A53A30")]
	private T CDJBMNMHFCC()
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
		public interface BPMFFCMFCJB
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject GLHFMILCCJB
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
		[Cpp2IlInjected.Address(RVA = "0x6FEEF40", Offset = "0x6FEE340", VA = "0x186FEEF40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF230", Offset = "0x6FEE630", VA = "0x186FEF230")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GCEFLAOMCHN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject CALNOHMIHCD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool GHDNHBBFDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF580", Offset = "0x6FEE980", VA = "0x186FEF580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF4C0", Offset = "0x6FEE8C0", VA = "0x186FEF4C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FED930", Offset = "0x6FECD30", VA = "0x186FED930")]
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
		public LFKFLMMEJBM PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OPLLLEHLACG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FLMKCMCIDGE(PooledParticle.JDHNBNFAHBC CENOIGEPJMG);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum KAHIJFEIPNM
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
		public enum JDHNBNFAHBC
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
		public interface JPNCMEGBLBM
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool EKIBPCDIIOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 ANKLDIEJMNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera AIHHHPPIBHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCAC0", Offset = "0x5ECBEC0", VA = "0x185ECCAC0")]
			public ColorConfiguration(ParticleSystem IIJCOOMCNJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6FED680", Offset = "0x6FECA80", VA = "0x186FED680")]
			public void NJNHHHAKPIM(Color FKCCOIADMAE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IJLCKMPBODF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public IJLCKMPBODF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE120", Offset = "0x6FED520", VA = "0x186FEE120")]
			internal void CLJJHJJJNGE(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IBAIFMAOOMK : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private JPNCMEGBLBM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public IBAIFMAOOMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6FEDAB0", Offset = "0x6FECEB0", VA = "0x186FEDAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE0D0", Offset = "0x6FED4D0", VA = "0x186FEE0D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ILOOJEBEJMC : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public ILOOJEBEJMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE150", Offset = "0x6FED550", VA = "0x186FEE150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE1C0", Offset = "0x6FED5C0", VA = "0x186FEE1C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MDGLOLNMMLL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<OPLLLEHLACG> FAILMKDLODD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> NFNPPKHILDF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IDFKLKAPHIN HGJAGHLCIKJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float INIGHFDMFOH = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool MGNLCJDGHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int FKILGMFNKNA;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JDHNBNFAHBC category;

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
		private ParticleSystem.MinMaxGradient[] OANHCJAFFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool FHCCGAJPIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float DDPOEEIJIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KBMHDHGMFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JMCBEDBJPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 DFADAKKMDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 LDPCNOIGNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KAHIJFEIPNM ELNHIAEJOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IDFKLKAPHIN NHEJLGAKKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool LAJAMEGNDJN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> EFOEABGEBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3460", Offset = "0x6FF2860", VA = "0x186FF3460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JDHNBNFAHBC ACEHNFDNFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C3890", Offset = "0x8C2C90", VA = "0x1808C3890")]
			get
			{
				return default(JDHNBNFAHBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HEIDAJNCCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MLOJNNLOHEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3190", Offset = "0x6FF2590", VA = "0x186FF3190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int FEHOOIHHODG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF3310", Offset = "0x6FF2710", VA = "0x186FF3310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool ACLDHLGGPDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1420", Offset = "0x6FF0820", VA = "0x186FF1420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem EHFLKEPJJCH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89EF00", Offset = "0x89E300", VA = "0x18089EF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] HPFCLKNGMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] EIMLPPOADCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F10", Offset = "0x8A1310", VA = "0x1808A1F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KAHIJFEIPNM CMMGNGLGBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x135B770", Offset = "0x135AB70", VA = "0x18135B770")]
			get
			{
				return default(KAHIJFEIPNM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6FF13A0", Offset = "0x6FF07A0", VA = "0x186FF13A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DODPGKMMLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6FF30F0", Offset = "0x6FF24F0", VA = "0x186FF30F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FF34B0", Offset = "0x6FF28B0", VA = "0x186FF34B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2A80", Offset = "0x6FF1E80", VA = "0x186FF2A80")]
		public static PooledParticle TryPlayPrefab(PooledParticle ACHABLJAHGP, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2BF0", Offset = "0x6FF1FF0", VA = "0x186FF2BF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle ACHABLJAHGP, Vector3 OGKCMCMHLOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2140", Offset = "0x6FF1540", VA = "0x186FF2140")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1060", Offset = "0x6FF0460", VA = "0x186FF1060")]
		private void KDCCBLNOHDG(bool HLIJMCFPGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FF13C0", Offset = "0x6FF07C0", VA = "0x186FF13C0")]
		[IteratorStateMachine(typeof(IBAIFMAOOMK))]
		private static IEnumerator<MLEAAPMIINP> NNGNKGAIHNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0A80", Offset = "0x6FEFE80", VA = "0x186FF0A80")]
		private static void JCAJEGEBBMM(Stopwatch PJIAIBMJLCJ, Vector3 EHLIGJLPMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1650", Offset = "0x6FF0A50", VA = "0x186FF1650")]
		private static int PMMHEAHIDGO(PooledParticle MMHCOKHACHF, PooledParticle DEOGINMLLDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF07E0", Offset = "0x6FEFBE0", VA = "0x186FF07E0")]
		private static int FLMKCMCIDGE(JDHNBNFAHBC CENOIGEPJMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0E60", Offset = "0x6FF0260", VA = "0x186FF0E60")]
		protected void JHHBHLLALID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF01B0", Offset = "0x6FEF5B0", VA = "0x186FF01B0")]
		protected void DOLOLCANABH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFE40", Offset = "0x6FEF240", VA = "0x186FEFE40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1130", Offset = "0x6FF0530", VA = "0x186FF1130")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6FF14A0", Offset = "0x6FF08A0", VA = "0x186FF14A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0DD0", Offset = "0x6FF01D0", VA = "0x186FF0DD0")]
		[IteratorStateMachine(typeof(ILOOJEBEJMC))]
		private IEnumerator<MLEAAPMIINP> JFFEANFKNND(float IKJGJGIMFPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFCE0", Offset = "0x6FEF0E0", VA = "0x186FEFCE0")]
		private void AFNCKMDLBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2890", Offset = "0x6FF1C90", VA = "0x186FF2890")]
		public void SetDuration(float IKJGJGIMFPJ, bool DOAPCMLLFBF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1700", Offset = "0x6FF0B00", VA = "0x186FF1700")]
		public void Play(Transform HIMDAKHMEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1DB0", Offset = "0x6FF11B0", VA = "0x186FF1DB0")]
		public void Play(Transform HIMDAKHMEPK, bool OGNLABNOEIE, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1860", Offset = "0x6FF0C60", VA = "0x186FF1860")]
		public void Play(Transform HIMDAKHMEPK, Vector3 LDPCNOIGNLD, bool OGNLABNOEIE, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FF19B0", Offset = "0x6FF0DB0", VA = "0x186FF19B0")]
		public void Play(Transform FEAHMIBOLLP, Quaternion GEMHEIIKJKD, bool OGNLABNOEIE = false, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1F20", Offset = "0x6FF1320", VA = "0x186FF1F20")]
		public void Play(Transform FEAHMIBOLLP, Vector3 LDPCNOIGNLD, Quaternion GEMHEIIKJKD, bool OGNLABNOEIE = false, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1BD0", Offset = "0x6FF0FD0", VA = "0x186FF1BD0")]
		public void Play(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, Vector3 IKJAACJPELI, bool OGNLABNOEIE = false, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1B10", Offset = "0x6FF0F10", VA = "0x186FF1B10")]
		public void Play(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, bool OGNLABNOEIE = false, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1CA0", Offset = "0x6FF10A0", VA = "0x186FF1CA0")]
		public void Play(bool OGNLABNOEIE = false, float DJBLCFBIDKD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF29F0", Offset = "0x6FF1DF0", VA = "0x186FF29F0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2960", Offset = "0x6FF1D60", VA = "0x186FF2960")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF08F0", Offset = "0x6FEFCF0", VA = "0x186FF08F0")]
		private void JBGJEKNGJAA(float IKJGJGIMFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0070", Offset = "0x6FEF470", VA = "0x186FF0070")]
		private void CGDFHGDBAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2050", Offset = "0x6FF1450", VA = "0x186FF2050")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FF22C0", Offset = "0x6FF16C0", VA = "0x186FF22C0")]
		public void SetColor(Color FKCCOIADMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1520", Offset = "0x6FF0920", VA = "0x186FF1520")]
		private void PLKHKMNKGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3060", Offset = "0x6FF2460", VA = "0x186FF3060")]
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
