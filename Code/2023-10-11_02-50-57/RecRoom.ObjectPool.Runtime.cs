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
		[Cpp2IlInjected.Address(RVA = "0x5ED4E70", Offset = "0x5ED3C70", VA = "0x185ED4E70")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles MCMNAIINBFO, float JBPAEDBPOBJ, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4B10", Offset = "0x5ED3910", VA = "0x185ED4B10")]
		public void SetDamageValue(float JBPAEDBPOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4FF0", Offset = "0x5ED3DF0", VA = "0x185ED4FF0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PELNPDGDDLK<T> : BOOMHLJDOCA<T>, KKKGKPAKNDP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PBPGHAOMLKA<T> : KKKGKPAKNDP, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LPKKMGPJKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJKFHMIILKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MNMBIEKDCFK<T> : HAHMAHGOHIO<T>, PELNPDGDDLK<T>, BOOMHLJDOCA<T>, KKKGKPAKNDP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IFNOACELNLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MNMBIEKDCFK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public IFNOACELNLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x36585A0", Offset = "0x36573A0", VA = "0x1836585A0")]
			internal void ALHPMIMOIKG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BCDC60", Offset = "0x2BCCA60", VA = "0x182BCDC60")]
			internal void LCKCBPFJFIB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DMPKAHEOBML<T> MHHCKJIEONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool PKHEGFNNJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JGOGHBIKMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool GIDFIEECIAK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B74C10", Offset = "0x3B73A10", VA = "0x183B74C10")]
		public MNMBIEKDCFK(DMPKAHEOBML<T> MHHCKJIEONH, ObjectPool PKHEGFNNJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B74AD0", Offset = "0x3B738D0", VA = "0x183B74AD0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EMDINJKABIC<T> : PFGLJDAMMPM, PBPGHAOMLKA<T>, KKKGKPAKNDP, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PBHEHBLHIFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EMDINJKABIC<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public PBHEHBLHIFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9C20", Offset = "0x3DC8A20", VA = "0x183DC9C20")]
			internal void ALHPMIMOIKG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89D330", Offset = "0x89C130", VA = "0x18089D330")]
			internal void LCKCBPFJFIB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DMPKAHEOBML<T> MHHCKJIEONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool GIDFIEECIAK;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3063410", Offset = "0x3062210", VA = "0x183063410")]
		public EMDINJKABIC(DMPKAHEOBML<T> MHHCKJIEONH, ObjectPool PKHEGFNNJOH, int CCCNFPHJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30633B0", Offset = "0x30621B0", VA = "0x1830633B0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OOPFBCPPMDH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OJKFHMIILKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HAHMAHGOHIO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DMPKAHEOBML<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OOPFBCPPMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C0A0", Offset = "0x3D3AEA0", VA = "0x183D3C0A0")]
		internal void FLFKECDCKDE(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C040", Offset = "0x3D3AE40", VA = "0x183D3C040")]
		internal void ELEJMBHALHO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C150", Offset = "0x3D3AF50", VA = "0x183D3C150")]
		internal void GGGLHONMEPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<LPKKMGPJKGA> FPCJOAPGBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CIBJNCJGLPF EIKOKJIAKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool PKHEGFNNJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool CBHCJMBGIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3A50", Offset = "0x5ED2850", VA = "0x185ED3A50")]
	private static void IJJONFFHNMO(Component PMEJDDFHMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3FE0", Offset = "0x5ED2DE0", VA = "0x185ED3FE0")]
	public OJKFHMIILKL(string JFGIJEKPOBI, int BGJOJAOMKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24F3DF0", Offset = "0x24F2BF0", VA = "0x1824F3DF0")]
	public PELNPDGDDLK<T> MPJIKIDJOGP<T>(AssetReference PNDNBAGMPEJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24F3D40", Offset = "0x24F2B40", VA = "0x1824F3D40")]
	public PBPGHAOMLKA<T> LPJBFOEKJNI<T>(AssetReference PNDNBAGMPEJ, int HLFCMANHPKF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24F3940", Offset = "0x24F2740", VA = "0x1824F3940")]
	public BOOMHLJDOCA<bool> HCAMIAJDHEM<T>(AssetReference PNDNBAGMPEJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3960", Offset = "0x5ED2760", VA = "0x185ED3960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3E20", Offset = "0x5ED2C20", VA = "0x185ED3E20")]
	private void MLHCAMCELGP(UnityEngine.Object LFKHAHCGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3C90", Offset = "0x5ED2A90", VA = "0x185ED3C90")]
	private ObjectPool INGFKJPLMMB(string JFGIJEKPOBI)
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
		private static GlobalPool GPOLBIGKDJI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GMBKPGGIIBL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool GOPCOAILBIE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3190", Offset = "0x5ED1F90", VA = "0x185ED3190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23657F0", Offset = "0x23645F0", VA = "0x1823657F0")]
		public static void SafeRelease<T>(T HBDENJGMDDF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED30C0", Offset = "0x5ED1EC0", VA = "0x185ED30C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3180", Offset = "0x5ED1F80", VA = "0x185ED3180")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ADEPANJPLOA> GKANGJDEALM;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x24FEB90", Offset = "0x24FD990", VA = "0x1824FEB90")]
		public T Acquire<T>(T MCMNAIINBFO, [Optional] Action<Component> DJFKJHIOJON) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24FEF00", Offset = "0x24FDD00", VA = "0x1824FEF00")]
		public bool Release<T>(T HBDENJGMDDF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24FEEB0", Offset = "0x24FDCB0", VA = "0x1824FEEB0")]
		public void Prefill<T>(T MCMNAIINBFO, int MJFAAFGILKB, [Optional] Action<Component> KMFFPEBJBCF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24FECD0", Offset = "0x24FDAD0", VA = "0x1824FECD0")]
		public bool Exists<T>(T MCMNAIINBFO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24FEC20", Offset = "0x24FDA20", VA = "0x1824FEC20")]
		public void Clear<T>(T MCMNAIINBFO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5ED45F0", Offset = "0x5ED33F0", VA = "0x185ED45F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x24FED70", Offset = "0x24FDB70", VA = "0x1824FED70")]
		private ADEPANJPLOA FLCAFKFLLOL<T>(T MCMNAIINBFO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		public void TrackInstantiation(string CIBEFMDFFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		public void EnableStats(bool FMCONCHCCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4760", Offset = "0x5ED3560", VA = "0x185ED4760")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ADEPANJPLOA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NFECIPALNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BNLNCFEGHFC(bool JHIOODBNMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int POFNBGBABNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LPJBFOEKJNI(int HLFCMANHPKF, Action<Component> KMFFPEBJBCF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component MPJIKIDJOGP(Action<Component> DJFKJHIOJON);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool GFINLAFBDPN(Component OLPNFBGADIK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EOCKAINKMIG();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2AA0", Offset = "0x5ED18A0", VA = "0x185ED2AA0")]
	protected void BIBMNMCFFFO(Component HBDENJGMDDF, bool JHIOODBNMMI, bool BBDLFHGEJPG, bool CPGJKOBDCNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2C20", Offset = "0x5ED1A20", VA = "0x185ED2C20")]
	protected void IHNMOPMAHKO(Transform FNOFMPMPBLL, bool JHIOODBNMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected ADEPANJPLOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HCNOHDHNOED<T> : ADEPANJPLOA where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T MCMNAIINBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool KJLKDPMLAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BBDLFHGEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> EKLJGBFONKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x356B650", Offset = "0x356A450", VA = "0x18356B650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int POFNBGBABNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x356B500", Offset = "0x356A300", VA = "0x18356B500", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x356BA50", Offset = "0x356A850", VA = "0x18356BA50")]
	public HCNOHDHNOED(T MCMNAIINBFO, ObjectPool KJLKDPMLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x356B540", Offset = "0x356A340", VA = "0x18356B540", Slot = "6")]
	public override void LPJBFOEKJNI(int HLFCMANHPKF, Action<Component> DJFKJHIOJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x356B670", Offset = "0x356A470", VA = "0x18356B670", Slot = "7")]
	public override Component MPJIKIDJOGP(Action<Component> DJFKJHIOJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x356B360", Offset = "0x356A160", VA = "0x18356B360", Slot = "8")]
	public override bool GFINLAFBDPN(Component OLPNFBGADIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x356B180", Offset = "0x3569F80", VA = "0x18356B180", Slot = "9")]
	public override void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x356B8E0", Offset = "0x356A6E0", VA = "0x18356B8E0")]
	private T OKMCHAJCBOF()
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
		public interface AOJGAAEJLLI
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject HJOIEMOJAIH
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
		[Cpp2IlInjected.Address(RVA = "0x5ED4270", Offset = "0x5ED3070", VA = "0x185ED4270")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4560", Offset = "0x5ED3360", VA = "0x185ED4560")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GPOLBIGKDJI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GMBKPGGIIBL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool GOPCOAILBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5ED4970", Offset = "0x5ED3770", VA = "0x185ED4970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5ED48B0", Offset = "0x5ED36B0", VA = "0x185ED48B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3180", Offset = "0x5ED1F80", VA = "0x185ED3180")]
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
		public ADEPANJPLOA PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ANINGIAIHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EDNDALMIJFP(PooledParticle.GOJAHJPDJFN NAJJMEMOCNI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum FAGNEOECDBB
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
		public enum GOJAHJPDJFN
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
		public interface CDJKCEDAPLN
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool MLACFDDDJIM
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 ADHMPBDLKHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera ENDLNGGOOEF
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
			[Cpp2IlInjected.Address(RVA = "0x4FF5F90", Offset = "0x4FF4D90", VA = "0x184FF5F90")]
			public ColorConfiguration(ParticleSystem BAEGPPKGJCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED2EA0", Offset = "0x5ED1CA0", VA = "0x185ED2EA0")]
			public void IKLIHAGOGAK(Color BJLKCDOCMJA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FMAHEGELFCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public FMAHEGELFCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3090", Offset = "0x5ED1E90", VA = "0x185ED3090")]
			internal void EEIGJDCLIFJ(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NEDAOIMPBGL : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private CDJKCEDAPLN <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public NEDAOIMPBGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3300", Offset = "0x5ED2100", VA = "0x185ED3300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5ED3910", Offset = "0x5ED2710", VA = "0x185ED3910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PEJAKHHFHEA : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public PEJAKHHFHEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5ED47F0", Offset = "0x5ED35F0", VA = "0x185ED47F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5ED4860", Offset = "0x5ED3660", VA = "0x185ED4860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FIGAGMBMLKF;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<ANINGIAIHAN> KAPPBOPJELF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> PHDGBGNOABH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static FFHNDEGIGAM KJIMKEKCBPN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float DPLPKPBLDGN = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool JNFGBDGKDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int HCPBIEDPBCC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private GOJAHJPDJFN category;

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
		private ParticleSystem.MinMaxGradient[] JLADHNDEPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool OGMIPEFBOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float NBCGHDMCOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float GDFINEFLJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform KKPCMLGKOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 OLDOKGHJHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DJDMCIONKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FAGNEOECDBB GEHILBBCEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FFHNDEGIGAM DFNOJOBMNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool FEALFJFLNMO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> LPNPGMJAGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8840", Offset = "0x5ED7640", VA = "0x185ED8840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GOJAHJPDJFN GAEDDAEHKLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x78A780", Offset = "0x789580", VA = "0x18078A780")]
			get
			{
				return default(GOJAHJPDJFN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OJPBHAHJGBI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NBMNKGOJOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8570", Offset = "0x5ED7370", VA = "0x185ED8570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int BKAMLGIOKGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5ED86F0", Offset = "0x5ED74F0", VA = "0x185ED86F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool GCEODHOHBEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED6800", Offset = "0x5ED5600", VA = "0x185ED6800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem PBCAACBKAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] KHOANKKFACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] FPHKNCCIHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private FAGNEOECDBB OKIIPDOLLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE92E0", Offset = "0xCE80E0", VA = "0x180CE92E0")]
			get
			{
				return default(FAGNEOECDBB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5300", Offset = "0x5ED4100", VA = "0x185ED5300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OLGHBABLDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5ED84D0", Offset = "0x5ED72D0", VA = "0x185ED84D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8890", Offset = "0x5ED7690", VA = "0x185ED8890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7E60", Offset = "0x5ED6C60", VA = "0x185ED7E60")]
		public static PooledParticle TryPlayPrefab(PooledParticle MCMNAIINBFO, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7FD0", Offset = "0x5ED6DD0", VA = "0x185ED7FD0")]
		public static PooledParticle TryPlayPrefab(PooledParticle MCMNAIINBFO, Vector3 AILFIIEAPKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7510", Offset = "0x5ED6310", VA = "0x185ED7510")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ED64C0", Offset = "0x5ED52C0", VA = "0x185ED64C0")]
		private void LEGDMJJCNOM(bool CLDLJEEKFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5630", Offset = "0x5ED4430", VA = "0x185ED5630")]
		[IteratorStateMachine(typeof(NEDAOIMPBGL))]
		private static IEnumerator<CCMEGKBIKJP> FOANJPJDKNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5980", Offset = "0x5ED4780", VA = "0x185ED5980")]
		private static void HCLEOALIEDI(Stopwatch JICPEFHJENB, Vector3 BKOELPGHJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5CD0", Offset = "0x5ED4AD0", VA = "0x185ED5CD0")]
		private static int IFKBBNMDLIA(PooledParticle KNEDKAAPLCI, PooledParticle FPBOJHIIPAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5520", Offset = "0x5ED4320", VA = "0x185ED5520")]
		private static int EDNDALMIJFP(GOJAHJPDJFN NAJJMEMOCNI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5320", Offset = "0x5ED4120", VA = "0x185ED5320")]
		protected void DGPAIINFJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5EB0", Offset = "0x5ED4CB0", VA = "0x185ED5EB0")]
		protected void KDPIINFHBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5ED50D0", Offset = "0x5ED3ED0", VA = "0x185ED50D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6590", Offset = "0x5ED5390", VA = "0x185ED6590")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6910", Offset = "0x5ED5710", VA = "0x185ED6910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6880", Offset = "0x5ED5680", VA = "0x185ED6880")]
		[IteratorStateMachine(typeof(PEJAKHHFHEA))]
		private IEnumerator<CCMEGKBIKJP> MMHFLONNKAP(float IBPBGABDEAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5820", Offset = "0x5ED4620", VA = "0x185ED5820")]
		private void GFINLAFBDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7C70", Offset = "0x5ED6A70", VA = "0x185ED7C70")]
		public void SetDuration(float IBPBGABDEAO, bool IEHFCONJHGC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6AD0", Offset = "0x5ED58D0", VA = "0x185ED6AD0")]
		public void Play(Transform MODOFECOCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7180", Offset = "0x5ED5F80", VA = "0x185ED7180")]
		public void Play(Transform MODOFECOCFH, bool LBLLCJEAFMF, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6C30", Offset = "0x5ED5A30", VA = "0x185ED6C30")]
		public void Play(Transform MODOFECOCFH, Vector3 DJDMCIONKGA, bool LBLLCJEAFMF, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6D80", Offset = "0x5ED5B80", VA = "0x185ED6D80")]
		public void Play(Transform PLLDLMGPKIK, Quaternion GIBIBDOGOLL, bool LBLLCJEAFMF = false, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED72F0", Offset = "0x5ED60F0", VA = "0x185ED72F0")]
		public void Play(Transform PLLDLMGPKIK, Vector3 DJDMCIONKGA, Quaternion GIBIBDOGOLL, bool LBLLCJEAFMF = false, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6FA0", Offset = "0x5ED5DA0", VA = "0x185ED6FA0")]
		public void Play(Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, Vector3 HPJBBHHJIEL, bool LBLLCJEAFMF = false, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6EE0", Offset = "0x5ED5CE0", VA = "0x185ED6EE0")]
		public void Play(Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, bool LBLLCJEAFMF = false, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7070", Offset = "0x5ED5E70", VA = "0x185ED7070")]
		public void Play(bool LBLLCJEAFMF = false, float IMCGNHDBFJN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7DD0", Offset = "0x5ED6BD0", VA = "0x185ED7DD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D40", Offset = "0x5ED6B40", VA = "0x185ED7D40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5690", Offset = "0x5ED4490", VA = "0x185ED5690")]
		private void GAEPMLLIEOI(float IBPBGABDEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6990", Offset = "0x5ED5790", VA = "0x185ED6990")]
		private void POPKDHJEHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7420", Offset = "0x5ED6220", VA = "0x185ED7420")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7690", Offset = "0x5ED6490", VA = "0x185ED7690")]
		public void SetColor(Color BJLKCDOCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5D80", Offset = "0x5ED4B80", VA = "0x185ED5D80")]
		private void IOBHPHOHHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8440", Offset = "0x5ED7240", VA = "0x185ED8440")]
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
