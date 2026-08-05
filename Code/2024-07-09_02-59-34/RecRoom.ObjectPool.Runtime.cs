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
		[Cpp2IlInjected.Address(RVA = "0x6C49E40", Offset = "0x6C48A40", VA = "0x186C49E40")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles GKHPLJIBDDP, float PFNCIDMJPDL, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C49AE0", Offset = "0x6C486E0", VA = "0x186C49AE0")]
		public void SetDamageValue(float PFNCIDMJPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C49FC0", Offset = "0x6C48BC0", VA = "0x186C49FC0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FGJGCIJHAME<T> : AMIFHJEHCND<T>, HNHMCBNIKDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NECIDAOJIDA<T> : HNHMCBNIKDD, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NPPLBLLJKLB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PMANOHHIJNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EKJFCFCLOEE<T> : CCBLGHEBJNN<T>, FGJGCIJHAME<T>, AMIFHJEHCND<T>, HNHMCBNIKDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HPBNMKGEKIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EKJFCFCLOEE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public HPBNMKGEKIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF4B0", Offset = "0x3DEE0B0", VA = "0x183DEF4B0")]
			internal void DOBNEHIALON(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A75530", Offset = "0x2A74130", VA = "0x182A75530")]
			internal void JFEJINMILAB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MOKKMPAFINF<T> LGJAHJEJEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool DANAKBDMDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AGABHBIFGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KLBJCIGNEHB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x384F130", Offset = "0x384DD30", VA = "0x18384F130")]
		public EKJFCFCLOEE(MOKKMPAFINF<T> LGJAHJEJEID, ObjectPool DANAKBDMDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x384EFC0", Offset = "0x384DBC0", VA = "0x18384EFC0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FBIBMPGNDNF<T> : KLIFOCPDGIA, NECIDAOJIDA<T>, HNHMCBNIKDD, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HPBGPMMBDMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FBIBMPGNDNF<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public HPBGPMMBDMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF3C0", Offset = "0x3DEDFC0", VA = "0x183DEF3C0")]
			internal void DOBNEHIALON(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xBAE880", Offset = "0xBAD480", VA = "0x180BAE880")]
			internal void JFEJINMILAB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MOKKMPAFINF<T> LGJAHJEJEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KLBJCIGNEHB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0DB0", Offset = "0x3BBF9B0", VA = "0x183BC0DB0")]
		public FBIBMPGNDNF(MOKKMPAFINF<T> LGJAHJEJEID, ObjectPool DANAKBDMDEJ, int JHNKNKILLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0D50", Offset = "0x3BBF950", VA = "0x183BC0D50", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LCJLLMHBOIF<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PMANOHHIJNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CCBLGHEBJNN<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MOKKMPAFINF<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LCJLLMHBOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x424F4A0", Offset = "0x424E0A0", VA = "0x18424F4A0")]
		internal void PLGCAPFOMOC(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x424F440", Offset = "0x424E040", VA = "0x18424F440")]
		internal void MGHJGGCPHCB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x424F3F0", Offset = "0x424DFF0", VA = "0x18424F3F0")]
		internal void ECPIKBDMBEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NPPLBLLJKLB> OABAPKMDPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CNOEFKJLLNN CMOBKPJJLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool DANAKBDMDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KLBJCIGNEHB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool AHDKAFKKEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C49060", Offset = "0x6C47C60", VA = "0x186C49060")]
	private static void ENACILMHJJI(Component BFLHJMMHBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C495F0", Offset = "0x6C481F0", VA = "0x186C495F0")]
	public PMANOHHIJNO(string AIFLFFEHDCG, int PNJCBDDMPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9000", Offset = "0x2CE7C00", VA = "0x182CE9000")]
	public FGJGCIJHAME<T> JJDEFHBJCMN<T>(AssetReference HHPBGMBFPDN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8F30", Offset = "0x2CE7B30", VA = "0x182CE8F30")]
	public NECIDAOJIDA<T> FKLMHHIPBJB<T>(AssetReference HHPBGMBFPDN, int LLHINFJPPOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8B30", Offset = "0x2CE7730", VA = "0x182CE8B30")]
	public AMIFHJEHCND<bool> BCICDOOEJDJ<T>(AssetReference HHPBGMBFPDN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C48F70", Offset = "0x6C47B70", VA = "0x186C48F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C49430", Offset = "0x6C48030", VA = "0x186C49430")]
	private void LIBNFAIMKOF(UnityEngine.Object BPCEJJBOLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C492A0", Offset = "0x6C47EA0", VA = "0x186C492A0")]
	private ObjectPool FJOODCGGAMC(string AIFLFFEHDCG)
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
		private static GlobalPool MJIDDCGELIA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject AAIKCGFGLKK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool NKKNEDDGFMP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6C47E30", Offset = "0x6C46A30", VA = "0x186C47E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B850", Offset = "0x2B3A450", VA = "0x182B3B850")]
		public static void SafeRelease<T>(T APKAFMDACKK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C47D60", Offset = "0x6C46960", VA = "0x186C47D60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C47E20", Offset = "0x6C46A20", VA = "0x186C47E20")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, KGGMMPLBAJD> HMHLOBBFFCE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC9C0", Offset = "0x2CDB5C0", VA = "0x182CDC9C0")]
		public T Acquire<T>(T GKHPLJIBDDP, [Optional] Action<Component> NGCPKPNLKCC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCD80", Offset = "0x2CDB980", VA = "0x182CDCD80")]
		public bool Release<T>(T APKAFMDACKK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCD10", Offset = "0x2CDB910", VA = "0x182CDCD10")]
		public void Prefill<T>(T GKHPLJIBDDP, int LAAAGNEFOND, [Optional] Action<Component> LBHGCMABMLE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCC70", Offset = "0x2CDB870", VA = "0x182CDCC70")]
		public bool Exists<T>(T GKHPLJIBDDP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCBC0", Offset = "0x2CDB7C0", VA = "0x182CDCBC0")]
		public void Clear<T>(T GKHPLJIBDDP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C48D70", Offset = "0x6C47970", VA = "0x186C48D70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCA80", Offset = "0x2CDB680", VA = "0x182CDCA80")]
		private KGGMMPLBAJD BDHNEKJENLB<T>(T GKHPLJIBDDP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public void TrackInstantiation(string HBCHPOMLMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public void EnableStats(bool NMBHODECGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C48EE0", Offset = "0x6C47AE0", VA = "0x186C48EE0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KGGMMPLBAJD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FHLKJDIAOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BCLHIHPCNDJ(bool NIKNNKAMGHO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int LKEJELENHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void FKLMHHIPBJB(int LLHINFJPPOH, Action<Component> LBHGCMABMLE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component JJDEFHBJCMN(Action<Component> NGCPKPNLKCC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NNDEKLEFPFP(Component GNLCCILBHCO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void AFPCPCPKMJJ();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C48220", Offset = "0x6C46E20", VA = "0x186C48220")]
	protected void KPNDDPJFOAF(Component APKAFMDACKK, bool NIKNNKAMGHO, bool CGHCDNCKNNE, bool IFLKIILPEKJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C47FA0", Offset = "0x6C46BA0", VA = "0x186C47FA0")]
	protected void CNIDCBNBLAM(Transform HNLCGMOPOKE, bool NIKNNKAMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected KGGMMPLBAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IMNAAAMPPCK<T> : KGGMMPLBAJD where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T GKHPLJIBDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool HDAKGKEKBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CGHCDNCKNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> JCANFPMMMEK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5C90", Offset = "0x3EB4890", VA = "0x183EB5C90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int LKEJELENHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3EB57E0", Offset = "0x3EB43E0", VA = "0x183EB57E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5E30", Offset = "0x3EB4A30", VA = "0x183EB5E30")]
	public IMNAAAMPPCK(T GKHPLJIBDDP, ObjectPool HDAKGKEKBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EB56B0", Offset = "0x3EB42B0", VA = "0x183EB56B0", Slot = "6")]
	public override void FKLMHHIPBJB(int LLHINFJPPOH, Action<Component> NGCPKPNLKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5840", Offset = "0x3EB4440", VA = "0x183EB5840", Slot = "7")]
	public override Component JJDEFHBJCMN(Action<Component> NGCPKPNLKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5AD0", Offset = "0x3EB46D0", VA = "0x183EB5AD0", Slot = "8")]
	public override bool NNDEKLEFPFP(Component GNLCCILBHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB54A0", Offset = "0x3EB40A0", VA = "0x183EB54A0", Slot = "9")]
	public override void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5CB0", Offset = "0x3EB48B0", VA = "0x183EB5CB0")]
	private T OPCGOLFJLKP()
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
		public interface EJBJLCOGFBI
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject KEOLPHPPBGP
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
		[Cpp2IlInjected.Address(RVA = "0x6C489F0", Offset = "0x6C475F0", VA = "0x186C489F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C48CE0", Offset = "0x6C478E0", VA = "0x186C48CE0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MJIDDCGELIA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject AAIKCGFGLKK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool NKKNEDDGFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C49940", Offset = "0x6C48540", VA = "0x186C49940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C49880", Offset = "0x6C48480", VA = "0x186C49880")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C47E20", Offset = "0x6C46A20", VA = "0x186C47E20")]
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
		public KGGMMPLBAJD PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DCMHGADONCD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KHNGCCPFOOJ(PooledParticle.OOCPMDICAPN AOCABHFPLAH);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum PNIPJFCDPJF
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
		public enum OOCPMDICAPN
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
		public interface IDAFCMIEAFB
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool MOCAHNBHEAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 FJKOFCMDKAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera PMNHKHENGKD
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
			[Cpp2IlInjected.Address(RVA = "0x5B884F0", Offset = "0x5B870F0", VA = "0x185B884F0")]
			public ColorConfiguration(ParticleSystem CDPBGDAGKEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6C47B40", Offset = "0x6C46740", VA = "0x186C47B40")]
			public void GCNJNLPCJBB(Color NMMFNOOBBFO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EPODCBGKNOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public EPODCBGKNOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6C47D30", Offset = "0x6C46930", VA = "0x186C47D30")]
			internal void LAOJPALMKPH(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ONHMHFOGCOJ : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private ELFHCGFNHNJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IDAFCMIEAFB <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
			[DebuggerHidden]
			public ONHMHFOGCOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C483A0", Offset = "0x6C46FA0", VA = "0x186C483A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6C489A0", Offset = "0x6C475A0", VA = "0x186C489A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BPFHOAPHBCE : IEnumerator<ELFHCGFNHNJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private ELFHCGFNHNJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private ELFHCGFNHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
			[DebuggerHidden]
			public BPFHOAPHBCE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6C47A80", Offset = "0x6C46680", VA = "0x186C47A80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6C47AF0", Offset = "0x6C466F0", VA = "0x186C47AF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> AFGENHPHDJA;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<DCMHGADONCD> FNOAKODBLFJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> LENEGFEIIMK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static NHMNIEJFONC KKPPDJGEAMO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float IBNDDDMOBOL = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool FOCGEPFDLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int IODKGMLDKEN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private OOCPMDICAPN category;

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
		private ParticleSystem.MinMaxGradient[] IBDLODOHFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool IHIAOENEPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LPCBECDANGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float JNMFAGFBKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform BCMFJJLAOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 IIAKOEKBBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 BECPFFLMCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PNIPJFCDPJF AJPJGKKBCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NHMNIEJFONC KOMPOFBAINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool EBFPLGPAACL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> HKILPKGGCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D830", Offset = "0x6C4C430", VA = "0x186C4D830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OOCPMDICAPN ACEIALOPHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88E1E0", Offset = "0x88CDE0", VA = "0x18088E1E0")]
			get
			{
				return default(OOCPMDICAPN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GFIOKJIEPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FOKNBPHHGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D560", Offset = "0x6C4C160", VA = "0x186C4D560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int BHEOOPIOJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D6E0", Offset = "0x6C4C2E0", VA = "0x186C4D6E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool GIFJCOAJKLO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6C4B9C0", Offset = "0x6C4A5C0", VA = "0x186C4B9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem GDEEAGGPKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] BLIMJOHGIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] GKEEEKBBDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86C780", Offset = "0x86B380", VA = "0x18086C780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private PNIPJFCDPJF BCDGMDPNJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1023870", Offset = "0x1022470", VA = "0x181023870")]
			get
			{
				return default(PNIPJFCDPJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6C4A0A0", Offset = "0x6C48CA0", VA = "0x186C4A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KHGAGLLOKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D4C0", Offset = "0x6C4C0C0", VA = "0x186C4D4C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D880", Offset = "0x6C4C480", VA = "0x186C4D880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CE50", Offset = "0x6C4BA50", VA = "0x186C4CE50")]
		public static PooledParticle TryPlayPrefab(PooledParticle GKHPLJIBDDP, Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CFC0", Offset = "0x6C4BBC0", VA = "0x186C4CFC0")]
		public static PooledParticle TryPlayPrefab(PooledParticle GKHPLJIBDDP, Vector3 DCDKACDAEIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C500", Offset = "0x6C4B100", VA = "0x186C4C500")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C4ACD0", Offset = "0x6C498D0", VA = "0x186C4ACD0")]
		private void IOONBOCBAGG(bool NCJAANPMPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4ADA0", Offset = "0x6C499A0", VA = "0x186C4ADA0")]
		[IteratorStateMachine(typeof(ONHMHFOGCOJ))]
		private static IEnumerator<ELFHCGFNHNJ> JEIGFKMDMDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A510", Offset = "0x6C49110", VA = "0x186C4A510")]
		private static void EEHBPKNHAIB(Stopwatch IFGCIHPEHMO, Vector3 LBDKMJPAENE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B540", Offset = "0x6C4A140", VA = "0x186C4B540")]
		private static int LLCOAOODCHJ(PooledParticle HFIDNJCGLJB, PooledParticle MGPFNHKFBHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AE00", Offset = "0x6C49A00", VA = "0x186C4AE00")]
		private static int KHNGCCPFOOJ(OOCPMDICAPN AOCABHFPLAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A860", Offset = "0x6C49460", VA = "0x186C4A860")]
		protected void FFPFFBCIKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AF10", Offset = "0x6C49B10", VA = "0x186C4AF10")]
		protected void LBDEECNPKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A0C0", Offset = "0x6C48CC0", VA = "0x186C4A0C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B5F0", Offset = "0x6C4A1F0", VA = "0x186C4B5F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BA40", Offset = "0x6C4A640", VA = "0x186C4BA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A480", Offset = "0x6C49080", VA = "0x186C4A480")]
		[IteratorStateMachine(typeof(BPFHOAPHBCE))]
		private IEnumerator<ELFHCGFNHNJ> DPGMJHOJALD(float CNHHDPPEEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B860", Offset = "0x6C4A460", VA = "0x186C4B860")]
		private void NNDEKLEFPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CC60", Offset = "0x6C4B860", VA = "0x186C4CC60")]
		public void SetDuration(float CNHHDPPEEFN, bool DLOMIKLLOKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BAC0", Offset = "0x6C4A6C0", VA = "0x186C4BAC0")]
		public void Play(Transform BDIMLIIDLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C170", Offset = "0x6C4AD70", VA = "0x186C4C170")]
		public void Play(Transform BDIMLIIDLAH, bool CPLMGDAOMHA, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BC20", Offset = "0x6C4A820", VA = "0x186C4BC20")]
		public void Play(Transform BDIMLIIDLAH, Vector3 BECPFFLMCLC, bool CPLMGDAOMHA, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BD70", Offset = "0x6C4A970", VA = "0x186C4BD70")]
		public void Play(Transform EBBFNLPEIBB, Quaternion GPEICHFGELO, bool CPLMGDAOMHA = false, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C2E0", Offset = "0x6C4AEE0", VA = "0x186C4C2E0")]
		public void Play(Transform EBBFNLPEIBB, Vector3 BECPFFLMCLC, Quaternion GPEICHFGELO, bool CPLMGDAOMHA = false, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BF90", Offset = "0x6C4AB90", VA = "0x186C4BF90")]
		public void Play(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, Vector3 IFAKEJMGKPK, bool CPLMGDAOMHA = false, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4BED0", Offset = "0x6C4AAD0", VA = "0x186C4BED0")]
		public void Play(Vector3 DCDKACDAEIJ, Quaternion GPEICHFGELO, bool CPLMGDAOMHA = false, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C060", Offset = "0x6C4AC60", VA = "0x186C4C060")]
		public void Play(bool CPLMGDAOMHA = false, float HBFBEODGCDI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CDC0", Offset = "0x6C4B9C0", VA = "0x186C4CDC0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CD30", Offset = "0x6C4B930", VA = "0x186C4CD30")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A2F0", Offset = "0x6C48EF0", VA = "0x186C4A2F0")]
		private void CCBFBFNHAHG(float CNHHDPPEEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AA60", Offset = "0x6C49660", VA = "0x186C4AA60")]
		private void GAHEODJCPFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C410", Offset = "0x6C4B010", VA = "0x186C4C410")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C680", Offset = "0x6C4B280", VA = "0x186C4C680")]
		public void SetColor(Color NMMFNOOBBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C4ABA0", Offset = "0x6C497A0", VA = "0x186C4ABA0")]
		private void GJFEKOMFNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D430", Offset = "0x6C4C030", VA = "0x186C4D430")]
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
