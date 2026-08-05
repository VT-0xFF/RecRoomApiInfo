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
		[Cpp2IlInjected.Address(RVA = "0x5E831F0", Offset = "0x5E825F0", VA = "0x185E831F0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FOHPGKLHLGD, float IHEHDFGOFFI, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E82E90", Offset = "0x5E82290", VA = "0x185E82E90")]
		public void SetDamageValue(float IHEHDFGOFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E83370", Offset = "0x5E82770", VA = "0x185E83370")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JNAKKCMIPFH<T> : OCKEEDNGMLO<T>, AFGBDCJCGDG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FICJAHDEODL<T> : AFGBDCJCGDG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MMFMHFEIPLH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JIGNIAENHGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OEAOCECDDDF<T> : MIEFKLHAHKE<T>, JNAKKCMIPFH<T>, OCKEEDNGMLO<T>, AFGBDCJCGDG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JPJHCOALJKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OEAOCECDDDF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public JPJHCOALJKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3866890", Offset = "0x3865C90", VA = "0x183866890")]
			internal void PMAJCPFCLBG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2D0C270", Offset = "0x2D0B670", VA = "0x182D0C270")]
			internal void FBGPFDICPDB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EJOGLAHGLBK<T> BBLLAKAIINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool NFOEPJCFJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T LDFPHDMIKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EJHKEMCAIJC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5680", Offset = "0x3CE4A80", VA = "0x183CE5680")]
		public OEAOCECDDDF(EJOGLAHGLBK<T> BBLLAKAIINK, ObjectPool NFOEPJCFJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5540", Offset = "0x3CE4940", VA = "0x183CE5540", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LACGJDEBHLO<T> : NFBEAPPNOOK, FICJAHDEODL<T>, AFGBDCJCGDG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DKJIENPAIBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LACGJDEBHLO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public DKJIENPAIBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4CA2280", Offset = "0x4CA1680", VA = "0x184CA2280")]
			internal void PMAJCPFCLBG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CC790", Offset = "0x8CBB90", VA = "0x1808CC790")]
			internal void FBGPFDICPDB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private EJOGLAHGLBK<T> BBLLAKAIINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool EJHKEMCAIJC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3968BB0", Offset = "0x3967FB0", VA = "0x183968BB0")]
		public LACGJDEBHLO(EJOGLAHGLBK<T> BBLLAKAIINK, ObjectPool NFOEPJCFJJL, int EPHIOICFMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3968B50", Offset = "0x3967F50", VA = "0x183968B50", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JKAAMLJCLIE<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JIGNIAENHGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MIEFKLHAHKE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EJOGLAHGLBK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public JKAAMLJCLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x384A610", Offset = "0x3849A10", VA = "0x18384A610")]
		internal void PKFJCDNEMCH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x384A5B0", Offset = "0x38499B0", VA = "0x18384A5B0")]
		internal void MHDDNELMGLM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x384A560", Offset = "0x3849960", VA = "0x18384A560")]
		internal void HKCLKEBCGEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<MMFMHFEIPLH> PIJNHJDAHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OJKDHCJKAML JIIEDOMHDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool NFOEPJCFJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool DBPFFPFFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E816F0", Offset = "0x5E80AF0", VA = "0x185E816F0")]
	private static void HKGBDFFEKKJ(Component NCKHGGMLODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E819C0", Offset = "0x5E80DC0", VA = "0x185E819C0")]
	public JIGNIAENHGD(string NAKFLJFKNJL, int JGKLHFIEELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23F4270", Offset = "0x23F3670", VA = "0x1823F4270")]
	public JNAKKCMIPFH<T> EGIAKDPNIKC<T>(AssetReference APLINBLNKBE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x23F4310", Offset = "0x23F3710", VA = "0x1823F4310")]
	public FICJAHDEODL<T> GGGNLLLLKJA<T>(AssetReference APLINBLNKBE, int OGEHFGGOGMJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23F3E70", Offset = "0x23F3270", VA = "0x1823F3E70")]
	public OCKEEDNGMLO<bool> AOKIEGPHIBB<T>(AssetReference APLINBLNKBE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E81600", Offset = "0x5E80A00", VA = "0x185E81600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E814D0", Offset = "0x5E808D0", VA = "0x185E814D0")]
	private void CHGBENLBIDK(UnityEngine.Object MEPPCFMLFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E81340", Offset = "0x5E80740", VA = "0x185E81340")]
	private ObjectPool BKIAIBDGEDH(string NAKFLJFKNJL)
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
		private static GlobalPool MDEGMHMCNPI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject LKJHLGPGHMH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool PFONNHJIIHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E811A0", Offset = "0x5E805A0", VA = "0x185E811A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23A4080", Offset = "0x23A3480", VA = "0x1823A4080")]
		public static void SafeRelease<T>(T BAFDGKKJJJD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E810D0", Offset = "0x5E804D0", VA = "0x185E810D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E81190", Offset = "0x5E80590", VA = "0x185E81190")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MFKPMLNNEGA> FDFDJADDHBG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2507180", Offset = "0x2506580", VA = "0x182507180")]
		public T Acquire<T>(T FOHPGKLHLGD, [Optional] Action<Component> JFMBKAFOMGF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x25073B0", Offset = "0x25067B0", VA = "0x1825073B0")]
		public bool Release<T>(T BAFDGKKJJJD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2507360", Offset = "0x2506760", VA = "0x182507360")]
		public void Prefill<T>(T FOHPGKLHLGD, int ADODFANMLNE, [Optional] Action<Component> GGOAHGJMOCP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25072C0", Offset = "0x25066C0", VA = "0x1825072C0")]
		public bool Exists<T>(T FOHPGKLHLGD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2507210", Offset = "0x2506610", VA = "0x182507210")]
		public void Clear<T>(T FOHPGKLHLGD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E82A30", Offset = "0x5E81E30", VA = "0x185E82A30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2507040", Offset = "0x2506440", VA = "0x182507040")]
		private MFKPMLNNEGA AIGKJFBMHFI<T>(T FOHPGKLHLGD) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		public void TrackInstantiation(string KAMPAGDCDJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		public void EnableStats(bool KPKNKGJJELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E82BA0", Offset = "0x5E81FA0", VA = "0x185E82BA0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MFKPMLNNEGA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FMMLOGLFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DKFDGMECGHO(bool ELBHFFKMPJI);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int CAJDCDDLAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void GGGNLLLLKJA(int OGEHFGGOGMJ, Action<Component> GGOAHGJMOCP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component EGIAKDPNIKC(Action<Component> JFMBKAFOMGF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NPAMHCDPFNF(Component CEDGDHLDPAK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BPHEMFKLBDC();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E81C50", Offset = "0x5E81050", VA = "0x185E81C50")]
	protected void DLGCHOOGJMO(Component BAFDGKKJJJD, bool ELBHFFKMPJI, bool LLPOJGADAOF, bool GEPJAJCOOMH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E81DD0", Offset = "0x5E811D0", VA = "0x185E81DD0")]
	protected void PIEKOFAADPJ(Transform EKJICKBGGII, bool ELBHFFKMPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected MFKPMLNNEGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PJMCLOBMNMD<T> : MFKPMLNNEGA where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FOHPGKLHLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool OANEDGDOFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool LLPOJGADAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> MGNABBGKEMB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3D40", Offset = "0x3DE3140", VA = "0x183DE3D40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int CAJDCDDLAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3980", Offset = "0x3DE2D80", VA = "0x183DE3980", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4070", Offset = "0x3DE3470", VA = "0x183DE4070")]
	public PJMCLOBMNMD(T FOHPGKLHLGD, ObjectPool OANEDGDOFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3C30", Offset = "0x3DE3030", VA = "0x183DE3C30", Slot = "6")]
	public override void GGGNLLLLKJA(int OGEHFGGOGMJ, Action<Component> JFMBKAFOMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE39C0", Offset = "0x3DE2DC0", VA = "0x183DE39C0", Slot = "7")]
	public override Component EGIAKDPNIKC(Action<Component> JFMBKAFOMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3ED0", Offset = "0x3DE32D0", VA = "0x183DE3ED0", Slot = "8")]
	public override bool NPAMHCDPFNF(Component CEDGDHLDPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE37A0", Offset = "0x3DE2BA0", VA = "0x183DE37A0", Slot = "9")]
	public override void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3D60", Offset = "0x3DE3160", VA = "0x183DE3D60")]
	private T JOLLPIEJEFC()
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
		public interface MLJFCEIIFJN
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject MBPOBGFPGCJ
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
		[Cpp2IlInjected.Address(RVA = "0x5E826B0", Offset = "0x5E81AB0", VA = "0x185E826B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E829A0", Offset = "0x5E81DA0", VA = "0x185E829A0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MDEGMHMCNPI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject LKJHLGPGHMH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool PFONNHJIIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5E82CF0", Offset = "0x5E820F0", VA = "0x185E82CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E82C30", Offset = "0x5E82030", VA = "0x185E82C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E81190", Offset = "0x5E80590", VA = "0x185E81190")]
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
		public MFKPMLNNEGA PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NBCJABOCHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GCJNHCHCLJA(PooledParticle.JFLCJNEIHCH MLFNDGDNGPD);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum LHKDONJEGDB
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
		public enum JFLCJNEIHCH
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
		public interface EKHLKANMMKM
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool MMMHKBNLMDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 EOLPJGADKNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera COEAECLGIIB
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
			[Cpp2IlInjected.Address(RVA = "0x4F79DD0", Offset = "0x4F791D0", VA = "0x184F79DD0")]
			public ColorConfiguration(ParticleSystem MMIFFCNDBLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E80EE0", Offset = "0x5E802E0", VA = "0x185E80EE0")]
			public void LJNCDHKJADA(Color DJDNAMFLFCL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JENPEFOBIPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public JENPEFOBIPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E81310", Offset = "0x5E80710", VA = "0x185E81310")]
			internal void EPKJMLDAKED(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NBNECFOPPCK : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private EKHLKANMMKM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public NBNECFOPPCK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5E82050", Offset = "0x5E81450", VA = "0x185E82050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E82660", Offset = "0x5E81A60", VA = "0x185E82660", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CGHGBNNGBOJ : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public CGHGBNNGBOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E80E20", Offset = "0x5E80220", VA = "0x185E80E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5E80E90", Offset = "0x5E80290", VA = "0x185E80E90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> EKAKBLCNFNE;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<NBCJABOCHKL> IOOMJOMEGPL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> DIOEHPLELBI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static MICMLGMLJFD KALJPHCPCPF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float DCOIKKHKEFC = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool JFICKBPEOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int GFGCCAHNFOM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JFLCJNEIHCH category;

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
		private ParticleSystem.MinMaxGradient[] EFCKBIJOCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool AECPAKIHOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float EAHOEFIJCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float JCJOGPADIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform NGODIIEFNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 CPHDGADDMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 JABAKKAPMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LHKDONJEGDB OMLCHHMAFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private MICMLGMLJFD LFHNIDKFLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool KCCDMIHHCMK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> IOFONLGMMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E86BC0", Offset = "0x5E85FC0", VA = "0x185E86BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JFLCJNEIHCH DDACLMPPPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x785BA0", Offset = "0x784FA0", VA = "0x180785BA0")]
			get
			{
				return default(JFLCJNEIHCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NNPAHADDGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FGAOPKACOEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5E868F0", Offset = "0x5E85CF0", VA = "0x185E868F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int CPPJGINNFON
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5E86A70", Offset = "0x5E85E70", VA = "0x185E86A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool MGABAGIDPHL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E84D50", Offset = "0x5E84150", VA = "0x185E84D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem FGNNMCLGODE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] MNKJJHLEMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] PGOANHCLNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LHKDONJEGDB LFDAAHKGGJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD02A10", Offset = "0xD01E10", VA = "0x180D02A10")]
			get
			{
				return default(LHKDONJEGDB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5E83FD0", Offset = "0x5E833D0", VA = "0x185E83FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EKBIBFGBDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E86850", Offset = "0x5E85C50", VA = "0x185E86850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5E86C10", Offset = "0x5E86010", VA = "0x185E86C10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E861E0", Offset = "0x5E855E0", VA = "0x185E861E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle FOHPGKLHLGD, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E86350", Offset = "0x5E85750", VA = "0x185E86350")]
		public static PooledParticle TryPlayPrefab(PooledParticle FOHPGKLHLGD, Vector3 LPAPEIIOLFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E85890", Offset = "0x5E84C90", VA = "0x185E85890")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E84C80", Offset = "0x5E84080", VA = "0x185E84C80")]
		private void OAOFINIIKBD(bool MBDDGEBPNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E84990", Offset = "0x5E83D90", VA = "0x185E84990")]
		[IteratorStateMachine(typeof(NBNECFOPPCK))]
		private static IEnumerator<KALNLPJNFEA> NMGPJHCEEJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E84500", Offset = "0x5E83900", VA = "0x185E84500")]
		private static void MMJGHBAOIKE(Stopwatch GJEJDECMIMK, Vector3 FPNGGNAGLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E84850", Offset = "0x5E83C50", VA = "0x185E84850")]
		private static int NBCIOBECGMN(PooledParticle IBOMHLKOLJB, PooledParticle FFDHLLBEMJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E83FF0", Offset = "0x5E833F0", VA = "0x185E83FF0")]
		private static int GCJNHCHCLJA(JFLCJNEIHCH MLFNDGDNGPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E83DD0", Offset = "0x5E831D0", VA = "0x185E83DD0")]
		protected void DOOBOEDFIFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E837C0", Offset = "0x5E82BC0", VA = "0x185E837C0")]
		protected void BAAKPNFPOLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E83590", Offset = "0x5E82990", VA = "0x185E83590", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E84290", Offset = "0x5E83690", VA = "0x185E84290")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E84DD0", Offset = "0x5E841D0", VA = "0x185E84DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E84900", Offset = "0x5E83D00", VA = "0x185E84900")]
		[IteratorStateMachine(typeof(CGHGBNNGBOJ))]
		private IEnumerator<KALNLPJNFEA> NKFLECDEABG(float DNJBPNBAMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E84B20", Offset = "0x5E83F20", VA = "0x185E84B20")]
		private void NPAMHCDPFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E85FF0", Offset = "0x5E853F0", VA = "0x185E85FF0")]
		public void SetDuration(float DNJBPNBAMFI, bool EFDEAJPFBBL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E84E50", Offset = "0x5E84250", VA = "0x185E84E50")]
		public void Play(Transform JHENCLLLAJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E85500", Offset = "0x5E84900", VA = "0x185E85500")]
		public void Play(Transform JHENCLLLAJG, bool HGHMBMCJIBC, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E84FB0", Offset = "0x5E843B0", VA = "0x185E84FB0")]
		public void Play(Transform JHENCLLLAJG, Vector3 JABAKKAPMFF, bool HGHMBMCJIBC, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E85100", Offset = "0x5E84500", VA = "0x185E85100")]
		public void Play(Transform NMOELGHMKEH, Quaternion KBKHJHIFKGI, bool HGHMBMCJIBC = false, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E85670", Offset = "0x5E84A70", VA = "0x185E85670")]
		public void Play(Transform NMOELGHMKEH, Vector3 JABAKKAPMFF, Quaternion KBKHJHIFKGI, bool HGHMBMCJIBC = false, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E85320", Offset = "0x5E84720", VA = "0x185E85320")]
		public void Play(Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, Vector3 GKMPFMKFGID, bool HGHMBMCJIBC = false, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E85260", Offset = "0x5E84660", VA = "0x185E85260")]
		public void Play(Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, bool HGHMBMCJIBC = false, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E853F0", Offset = "0x5E847F0", VA = "0x185E853F0")]
		public void Play(bool HGHMBMCJIBC = false, float NEHOKPMEPPD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E86150", Offset = "0x5E85550", VA = "0x185E86150")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E860C0", Offset = "0x5E854C0", VA = "0x185E860C0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E84100", Offset = "0x5E83500", VA = "0x185E84100")]
		private void JEBLDNABINI(float DNJBPNBAMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E83450", Offset = "0x5E82850", VA = "0x185E83450")]
		private void AEEOGHGLNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E857A0", Offset = "0x5E84BA0", VA = "0x185E857A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E85A10", Offset = "0x5E84E10", VA = "0x185E85A10")]
		public void SetColor(Color DJDNAMFLFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E849F0", Offset = "0x5E83DF0", VA = "0x185E849F0")]
		private void NMIGGJFCELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E867C0", Offset = "0x5E85BC0", VA = "0x185E867C0")]
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
