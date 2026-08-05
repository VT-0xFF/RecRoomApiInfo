using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
		[Cpp2IlInjected.Address(RVA = "0x6558740", Offset = "0x6556F40", VA = "0x186558740")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ONIHIIPCKEF, float EOLDCEADDFO, Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6558540", Offset = "0x6556D40", VA = "0x186558540")]
		public void SetDamageValue(float EOLDCEADDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6558900", Offset = "0x6557100", VA = "0x186558900")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GPGHAFDDALI<T> : global::FGLDKEJLAKB<T>, LDGADANDBIO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GGDGKBAOGLH<T> : LDGADANDBIO, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ANLMMCDAKKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IHHBJOAGIPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MJPOGLECCLG<T> : global::OGBIEJAIDCG<T>, global::GPGHAFDDALI<T>, global::FGLDKEJLAKB<T>, LDGADANDBIO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KOCMNCECDDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MJPOGLECCLG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public KOCMNCECDDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2A35F40", Offset = "0x2A34740", VA = "0x182A35F40")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x26F99F0", Offset = "0x26F81F0", VA = "0x1826F99F0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::FHFGABMPMPC<T> MLPNOENCNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool CKDGGKFHHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T HBJDGFDOIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1DC0", Offset = "0x2FB05C0", VA = "0x182FB1DC0")]
		public MJPOGLECCLG(global::FHFGABMPMPC<T> MLPNOENCNNO, ObjectPool CKDGGKFHHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1C80", Offset = "0x2FB0480", VA = "0x182FB1C80", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CIMJPBLEIKG<T> : MAMJDBJDFAF, global::GGDGKBAOGLH<T>, LDGADANDBIO, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class KFLPCNOLLJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CIMJPBLEIKG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public KFLPCNOLLJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2601F50", Offset = "0x2600750", VA = "0x182601F50")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x14E3AD0", Offset = "0x14E22D0", VA = "0x1814E3AD0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::FHFGABMPMPC<T> MLPNOENCNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D59C0", Offset = "0x28D41C0", VA = "0x1828D59C0")]
		public CIMJPBLEIKG(global::FHFGABMPMPC<T> MLPNOENCNNO, ObjectPool CKDGGKFHHKN, int GFDJPGOJPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D5970", Offset = "0x28D4170", VA = "0x1828D5970", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GJFBNMLLNNF<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IHHBJOAGIPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::OGBIEJAIDCG<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::FHFGABMPMPC<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GJFBNMLLNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2730690", Offset = "0x272EE90", VA = "0x182730690")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2730730", Offset = "0x272EF30", VA = "0x182730730")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2730790", Offset = "0x272EF90", VA = "0x182730790")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<ANLMMCDAKKJ> NFLFNLOHJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MHECGKMLJNM CKBKGOACADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool CKDGGKFHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool ACEEBJKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65569A0", Offset = "0x65551A0", VA = "0x1865569A0")]
	private static void ILBAAIKLAJF(Component DMKJFEIEPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6556F40", Offset = "0x6555740", VA = "0x186556F40")]
	public IHHBJOAGIPO(string MNPEFBDEFJK, int HOLADNMIDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36E4600", Offset = "0x36E2E00", VA = "0x1836E4600")]
	public global::GPGHAFDDALI<T> PGMJAIHGBCK<T>(AssetReference BCCKNNMKAHE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36E4260", Offset = "0x36E2A60", VA = "0x1836E4260")]
	public global::GGDGKBAOGLH<T> BENDBGEOCOP<T>(AssetReference BCCKNNMKAHE, int FCKFNIPNJCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36E4310", Offset = "0x36E2B10", VA = "0x1836E4310")]
	public global::FGLDKEJLAKB<bool> JONADHNAPOD<T>(AssetReference BCCKNNMKAHE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6556890", Offset = "0x6555090", VA = "0x186556890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6556D80", Offset = "0x6555580", VA = "0x186556D80")]
	private void PEDCLOBOOEE(UnityEngine.Object BHFMHOBNEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6556BF0", Offset = "0x65553F0", VA = "0x186556BF0")]
	private ObjectPool MHOGALOGIDI(string MNPEFBDEFJK)
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
		private static GlobalPool HJDDFGGNABE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject DIAHKJODCJD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool PDCOCJBICGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x65566D0", Offset = "0x6554ED0", VA = "0x1865566D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x255C930", Offset = "0x255B130", VA = "0x18255C930")]
		public static void SafeRelease<T>(T BFHAMCLNCKB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65565D0", Offset = "0x6554DD0", VA = "0x1865565D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65566C0", Offset = "0x6554EC0", VA = "0x1865566C0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, KJBEEAGGGNJ> COJNCBCPDLM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2291270", Offset = "0x228FA70", VA = "0x182291270")]
		public T Acquire<T>(T ONIHIIPCKEF, [Optional] Action<Component> LEEIHAPDPNG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2291600", Offset = "0x228FE00", VA = "0x182291600")]
		public bool Release<T>(T BFHAMCLNCKB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22915A0", Offset = "0x228FDA0", VA = "0x1822915A0")]
		public void Prefill<T>(T ONIHIIPCKEF, int FNDGDFINCBH, [Optional] Action<Component> DJHPOJPOHDF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22913B0", Offset = "0x228FBB0", VA = "0x1822913B0")]
		public bool Exists<T>(T ONIHIIPCKEF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2291300", Offset = "0x228FB00", VA = "0x182291300")]
		public void Clear<T>(T ONIHIIPCKEF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6557A60", Offset = "0x6556260", VA = "0x186557A60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2291460", Offset = "0x228FC60", VA = "0x182291460")]
		private KJBEEAGGGNJ LDBFMNFPAKE<T>(T ONIHIIPCKEF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public void TrackInstantiation(string NABCMMKNNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public void EnableStats(bool JCEPKBHHKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6557BB0", Offset = "0x65563B0", VA = "0x186557BB0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KJBEEAGGGNJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CNEGBHOHNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IPJJAEKMJNE(bool NBJFHLJMABH);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component LAFOIAMBKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int MMIFNFLBIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void BENDBGEOCOP(int FCKFNIPNJCI, Action<Component> DJHPOJPOHDF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component PGMJAIHGBCK(Action<Component> LEEIHAPDPNG);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool BBLGJGOPDHE(Component OBOMOBPDMCG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void MMLFENDEPMM();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65573E0", Offset = "0x6555BE0", VA = "0x1865573E0")]
	protected void LEEIIAKBJLE(Component BFHAMCLNCKB, bool NBJFHLJMABH, bool HKPAHHJOPIL, bool LLMOAKHNBGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65571E0", Offset = "0x65559E0", VA = "0x1865571E0")]
	protected void FKEIMBOGDLC(Transform HEOMJLLHJHA, bool NBJFHLJMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected KJBEEAGGGNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JHOLKKBFGEI<T> : KJBEEAGGGNJ where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T ONIHIIPCKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FMCPKBHDGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HKPAHHJOPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> FOEONCFPFPH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component LAFOIAMBKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x259E940", Offset = "0x259D140", VA = "0x18259E940", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int MMIFNFLBIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x259E910", Offset = "0x259D110", VA = "0x18259E910", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x259EBD0", Offset = "0x259D3D0", VA = "0x18259EBD0")]
	public JHOLKKBFGEI(T ONIHIIPCKEF, ObjectPool FMCPKBHDGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x259E4B0", Offset = "0x259CCB0", VA = "0x18259E4B0", Slot = "7")]
	public override void BENDBGEOCOP(int FCKFNIPNJCI, Action<Component> LEEIHAPDPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x259E960", Offset = "0x259D160", VA = "0x18259E960", Slot = "8")]
	public override Component PGMJAIHGBCK(Action<Component> LEEIHAPDPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x259E320", Offset = "0x259CB20", VA = "0x18259E320", Slot = "9")]
	public override bool BBLGJGOPDHE(Component OBOMOBPDMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x259E720", Offset = "0x259CF20", VA = "0x18259E720", Slot = "10")]
	public override void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x259E5C0", Offset = "0x259CDC0", VA = "0x18259E5C0")]
	private T KEHFIFCKBLJ()
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
		public interface MIDCLJJPFHF
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject NBOAKBDFGKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6557690", Offset = "0x6555E90", VA = "0x186557690")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65579E0", Offset = "0x65561E0", VA = "0x1865579E0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool HJDDFGGNABE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject DIAHKJODCJD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool PDCOCJBICGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6558350", Offset = "0x6556B50", VA = "0x186558350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6558260", Offset = "0x6556A60", VA = "0x186558260")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x65566C0", Offset = "0x6554EC0", VA = "0x1865566C0")]
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
		public KJBEEAGGGNJ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HHLOGLOJDPL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HCNFPGCNMHC(PooledParticle.ALLMKKFGIIK HPHDEPJJNMO);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum HFMEFANDEAE
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
		public enum ALLMKKFGIIK
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
		public interface KMMOCADLMFH
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool JGJGLHLHJPG
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 BGLGJPLCLJN
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera FJBHEJANJOH
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
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

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCD2E40", Offset = "0xCD1640", VA = "0x180CD2E40")]
			public ColorConfiguration(ParticleSystem LLCBCCKGALE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x65563E0", Offset = "0x6554BE0", VA = "0x1865563E0")]
			public void FMLOAIKJCML(Color LCCPJBCAOGP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OLKCDLJEJEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public OLKCDLJEJEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6557660", Offset = "0x6555E60", VA = "0x186557660")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class AEGIHIGJLML : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private KMMOCADLMFH <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public AEGIHIGJLML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6555D00", Offset = "0x6554500", VA = "0x186555D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x65563A0", Offset = "0x6554BA0", VA = "0x1865563A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OCAJBOMDEIC : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public OCAJBOMDEIC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6557560", Offset = "0x6555D60", VA = "0x186557560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6557620", Offset = "0x6555E20", VA = "0x186557620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> HBKOCPJEHNI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<HHLOGLOJDPL> PNPIOGBNGKG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> CPPDNFFADIJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static BGFJNOHFIGD ABHEHMIOHGN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float ILAMIHGILJG = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool KLDAJMBPPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int EECPELLEJCN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private ALLMKKFGIIK category;

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
		private ParticleSystem.MinMaxGradient[] PAIKPNIENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool LFEKPPEMEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float PGOMAGGKLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KAOMACIPNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform HMGKOJDJPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 HPDPEANOMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 ALEAHGFIMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HFMEFANDEAE OIGMDMGLIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BGFJNOHFIGD JIKIDOPAOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool FEJHJBDOKAH;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> LNHDEOAPCML
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x655C1F0", Offset = "0x655A9F0", VA = "0x18655C1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ALLMKKFGIIK JHJHIBDNJFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F0C90", Offset = "0x6EF490", VA = "0x1806F0C90")]
			get
			{
				return default(ALLMKKFGIIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NFPFBEILCMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NELKOMOKEAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x655BEE0", Offset = "0x655A6E0", VA = "0x18655BEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int LBDAAMODJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x655C070", Offset = "0x655A870", VA = "0x18655C070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool PPHOLNHMAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6559140", Offset = "0x6557940", VA = "0x186559140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem HFLIPFPNAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] BEHECFHMBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] HKDHJCCOGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private HFMEFANDEAE EPEHBFMIFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x90FB10", Offset = "0x90E310", VA = "0x18090FB10")]
			get
			{
				return default(HFMEFANDEAE);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6559280", Offset = "0x6557A80", VA = "0x186559280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GLLOILJKLJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x655BE40", Offset = "0x655A640", VA = "0x18655BE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x655C250", Offset = "0x655AA50", VA = "0x18655C250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x655B9E0", Offset = "0x655A1E0", VA = "0x18655B9E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle ONIHIIPCKEF, Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x655B7F0", Offset = "0x6559FF0", VA = "0x18655B7F0")]
		public static PooledParticle TryPlayPrefab(PooledParticle ONIHIIPCKEF, Vector3 LMLCHIPKJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x655AE60", Offset = "0x6559660", VA = "0x18655AE60")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6558D90", Offset = "0x6557590", VA = "0x186558D90")]
		private void CFMLLBKALKH(bool LAFALKKKKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6559540", Offset = "0x6557D40", VA = "0x186559540")]
		[IteratorStateMachine(typeof(AEGIHIGJLML))]
		private static IEnumerator<MBIPJOOACNE> MBILFNMJBCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6559590", Offset = "0x6557D90", VA = "0x186559590")]
		private static void NNMJNMCHBPB(Stopwatch KBGFBMKMFNL, Vector3 HAIFGGFCDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x65591D0", Offset = "0x65579D0", VA = "0x1865591D0")]
		private static int JEPJMOCCEOA(PooledParticle EHDPPFDCEJK, PooledParticle NPIMFLIIAHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6559030", Offset = "0x6557830", VA = "0x186559030")]
		private static int HCNFPGCNMHC(ALLMKKFGIIK HPHDEPJJNMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6559920", Offset = "0x6558120", VA = "0x186559920")]
		protected void OBHHJGBNKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6559B20", Offset = "0x6558320", VA = "0x186559B20")]
		protected void OGMAJJFNNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65589A0", Offset = "0x65571A0", VA = "0x1865589A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x65592A0", Offset = "0x6557AA0", VA = "0x1865592A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x655A240", Offset = "0x6558A40", VA = "0x18655A240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6558FB0", Offset = "0x65577B0", VA = "0x186558FB0")]
		[IteratorStateMachine(typeof(OCAJBOMDEIC))]
		private IEnumerator<MBIPJOOACNE> EPNCIFAPGEG(float IGHCILDIJKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6558BE0", Offset = "0x65573E0", VA = "0x186558BE0")]
		private void BBLGJGOPDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x655B600", Offset = "0x6559E00", VA = "0x18655B600")]
		public void SetDuration(float IGHCILDIJKH, bool JBKELFIFDAL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x655AB40", Offset = "0x6559340", VA = "0x18655AB40")]
		public void Play(Transform GBIKFJAHLGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x655A520", Offset = "0x6558D20", VA = "0x18655A520")]
		public void Play(Transform GBIKFJAHLGL, bool HADLDHGKFEB, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x655A670", Offset = "0x6558E70", VA = "0x18655A670")]
		public void Play(Transform GBIKFJAHLGL, Vector3 ALEAHGFIMFO, bool HADLDHGKFEB, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x655A8F0", Offset = "0x65590F0", VA = "0x18655A8F0")]
		public void Play(Transform KAACKJIABDN, Quaternion ILBCPDKFKMC, bool HADLDHGKFEB = false, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x655A7C0", Offset = "0x6558FC0", VA = "0x18655A7C0")]
		public void Play(Transform KAACKJIABDN, Vector3 ALEAHGFIMFO, Quaternion ILBCPDKFKMC, bool HADLDHGKFEB = false, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x655A450", Offset = "0x6558C50", VA = "0x18655A450")]
		public void Play(Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC, Vector3 KDOCAGECAOO, bool HADLDHGKFEB = false, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x655AC80", Offset = "0x6559480", VA = "0x18655AC80")]
		public void Play(Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC, bool HADLDHGKFEB = false, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x655AA30", Offset = "0x6559230", VA = "0x18655AA30")]
		public void Play(bool HADLDHGKFEB = false, float FAGJNCICGCN = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x655B760", Offset = "0x6559F60", VA = "0x18655B760")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x655B6D0", Offset = "0x6559ED0", VA = "0x18655B6D0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x655A2C0", Offset = "0x6558AC0", VA = "0x18655A2C0")]
		private void PCABLJPBKEG(float IGHCILDIJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x655A0D0", Offset = "0x65588D0", VA = "0x18655A0D0")]
		private void OJHLMKJCEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x655AD40", Offset = "0x6559540", VA = "0x18655AD40")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x655B000", Offset = "0x6559800", VA = "0x18655B000")]
		public void SetColor(Color LCCPJBCAOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6558E70", Offset = "0x6557670", VA = "0x186558E70")]
		private void DLDLGFGPHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x655BDE0", Offset = "0x655A5E0", VA = "0x18655BDE0")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6557F80", Offset = "0x6556780", VA = "0x186557F80")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6557C30", Offset = "0x6556430", VA = "0x186557C30")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
