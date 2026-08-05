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
		[Cpp2IlInjected.Address(RVA = "0x77C7840", Offset = "0x77C6440", VA = "0x1877C7840")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles DLFNGKIHPEG, float FMNEPBJKLIA, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77C74E0", Offset = "0x77C60E0", VA = "0x1877C74E0")]
		public void SetDamageValue(float FMNEPBJKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77C7980", Offset = "0x77C6580", VA = "0x1877C7980")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GNCCNHOFMKO<T> : JOIICJDLMNO<T>, HAGJNGKFIOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PJEPAAJBHGO<T> : HAGJNGKFIOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GJEIBHBEIKO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class INBKICDOMLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GMPHGIDPJDF<T> : NJNAONPKMIH<T>, GNCCNHOFMKO<T>, JOIICJDLMNO<T>, HAGJNGKFIOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LCFFJFECNNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GMPHGIDPJDF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public LCFFJFECNNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4B1FF00", Offset = "0x4B1EB00", VA = "0x184B1FF00")]
			internal void IAJIPBONKMF(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x32AAB10", Offset = "0x32A9710", VA = "0x1832AAB10")]
			internal void EHAFEAADPFP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OBLFPJIHAJD<T> AIILKJPNMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool IKOMCHEPDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T ONEEJFNLBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EIHBPFOIIHI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4517A20", Offset = "0x4516620", VA = "0x184517A20")]
		public GMPHGIDPJDF(OBLFPJIHAJD<T> AIILKJPNMJG, ObjectPool IKOMCHEPDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x45178B0", Offset = "0x45164B0", VA = "0x1845178B0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BJOBELKFPDF<T> : CPONDHIMEMO, PJEPAAJBHGO<T>, HAGJNGKFIOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DEEIMMPKBGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BJOBELKFPDF<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DEEIMMPKBGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63012C0", Offset = "0x62FFEC0", VA = "0x1863012C0")]
			internal void IAJIPBONKMF(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x11D8A70", Offset = "0x11D7670", VA = "0x1811D8A70")]
			internal void EHAFEAADPFP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private OBLFPJIHAJD<T> AIILKJPNMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool EIHBPFOIIHI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x580A220", Offset = "0x5808E20", VA = "0x18580A220")]
		public BJOBELKFPDF(OBLFPJIHAJD<T> AIILKJPNMJG, ObjectPool IKOMCHEPDEG, int MKFIABKBOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x580A1C0", Offset = "0x5808DC0", VA = "0x18580A1C0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GHICKBKEIDK<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public INBKICDOMLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NJNAONPKMIH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OBLFPJIHAJD<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GHICKBKEIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44D9AC0", Offset = "0x44D86C0", VA = "0x1844D9AC0")]
		internal void FGLBIDGCHDF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44D9B70", Offset = "0x44D8770", VA = "0x1844D9B70")]
		internal void OFJDBAMCGGK(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x44D9A70", Offset = "0x44D8670", VA = "0x1844D9A70")]
		internal void CAIMADODJLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<GJEIBHBEIKO> MGMFBLONJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OAKMCCPDBGJ BLNDKGNNEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool IKOMCHEPDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77C6230", Offset = "0x77C4E30", VA = "0x1877C6230")]
	private static void MIHCDKDJLMD(Component AKHNIBOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77C6690", Offset = "0x77C5290", VA = "0x1877C6690")]
	public INBKICDOMLN(string JLDGAOJPDBN, int CENOGIFFLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x33C23A0", Offset = "0x33C0FA0", VA = "0x1833C23A0")]
	public GNCCNHOFMKO<T> FDMJAGPJNJE<T>(AssetReference OIEJJIOJOBI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x33C2470", Offset = "0x33C1070", VA = "0x1833C2470")]
	public PJEPAAJBHGO<T> LEAFMMMEGOO<T>(AssetReference OIEJJIOJOBI, int EBDKDADIOBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x33C2550", Offset = "0x33C1150", VA = "0x1833C2550")]
	public JOIICJDLMNO<bool> NMMFNCKLIDM<T>(AssetReference OIEJJIOJOBI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77C6000", Offset = "0x77C4C00", VA = "0x1877C6000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77C60F0", Offset = "0x77C4CF0", VA = "0x1877C60F0")]
	private void JJNCCGHNEBK(UnityEngine.Object IOLJFAAJANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77C6470", Offset = "0x77C5070", VA = "0x1877C6470")]
	private ObjectPool MMIJEPONPLD(string JLDGAOJPDBN)
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
		private static GlobalPool JHOMDMKMMKD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject PANLPBPGMNC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool FFLNCJPMHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x77C5E80", Offset = "0x77C4A80", VA = "0x1877C5E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x33862A0", Offset = "0x3384EA0", VA = "0x1833862A0")]
		public static void SafeRelease<T>(T CFMCKCBBBKK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77C5DB0", Offset = "0x77C49B0", VA = "0x1877C5DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77C5E70", Offset = "0x77C4A70", VA = "0x1877C5E70")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, NAGCDCIBHBC> POLMFMDNNCH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3550640", Offset = "0x354F240", VA = "0x183550640")]
		public T Acquire<T>(T DLFNGKIHPEG, [Optional] Action<Component> LEGELACDNNN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3550A00", Offset = "0x354F600", VA = "0x183550A00")]
		public bool Release<T>(T CFMCKCBBBKK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3550990", Offset = "0x354F590", VA = "0x183550990")]
		public void Prefill<T>(T DLFNGKIHPEG, int AEFDAGOKGPA, [Optional] Action<Component> DHBGDODBAFB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35507B0", Offset = "0x354F3B0", VA = "0x1835507B0")]
		public bool Exists<T>(T DLFNGKIHPEG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3550700", Offset = "0x354F300", VA = "0x183550700")]
		public void Clear<T>(T DLFNGKIHPEG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77C70A0", Offset = "0x77C5CA0", VA = "0x1877C70A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3550850", Offset = "0x354F450", VA = "0x183550850")]
		private NAGCDCIBHBC OFMEEIDKHHF<T>(T DLFNGKIHPEG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public void TrackInstantiation(string MIIGGBFNOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public void EnableStats(bool HEMKCALBEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77C7210", Offset = "0x77C5E10", VA = "0x1877C7210")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class NAGCDCIBHBC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LPNANMNMECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HBIEHOGAPEF(bool LBOHKFHGEJF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int IDLIEBJEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LEAFMMMEGOO(int EBDKDADIOBA, Action<Component> DHBGDODBAFB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component FDMJAGPJNJE(Action<Component> LEGELACDNNN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool GFEMBPJJFIN(Component DIFAGCOONAH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NGMONOEHMBH();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77C6BA0", Offset = "0x77C57A0", VA = "0x1877C6BA0")]
	protected void KCNFCAKJNCE(Component CFMCKCBBBKK, bool LBOHKFHGEJF, bool BEIDNHFNNOO, bool JPOANDAKAMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77C6920", Offset = "0x77C5520", VA = "0x1877C6920")]
	protected void GNBNJPGKFIJ(Transform JBBFEDBLMCK, bool LBOHKFHGEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected NAGCDCIBHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EKLAPIPDOEO<T> : NAGCDCIBHBC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T DLFNGKIHPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool GBPLDDGFAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BEIDNHFNNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> AIGOFBHPPGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB9D0", Offset = "0x3FDA5D0", VA = "0x183FDB9D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int IDLIEBJEMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB010", Offset = "0x3FD9C10", VA = "0x183FDB010", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB9F0", Offset = "0x3FDA5F0", VA = "0x183FDB9F0")]
	public EKLAPIPDOEO(T DLFNGKIHPEG, ObjectPool GBPLDDGFAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB680", Offset = "0x3FDA280", VA = "0x183FDB680", Slot = "6")]
	public override void LEAFMMMEGOO(int EBDKDADIOBA, Action<Component> LEGELACDNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB070", Offset = "0x3FD9C70", VA = "0x183FDB070", Slot = "7")]
	public override Component FDMJAGPJNJE(Action<Component> LEGELACDNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB300", Offset = "0x3FD9F00", VA = "0x183FDB300", Slot = "8")]
	public override bool GFEMBPJJFIN(Component DIFAGCOONAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB7B0", Offset = "0x3FDA3B0", VA = "0x183FDB7B0", Slot = "9")]
	public override void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB4C0", Offset = "0x3FDA0C0", VA = "0x183FDB4C0")]
	private T GIBBMDDKJIC()
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
		public interface CGDGONOPMLP
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject KLCEOLMLPHA
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
		[Cpp2IlInjected.Address(RVA = "0x77C6D20", Offset = "0x77C5920", VA = "0x1877C6D20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77C7010", Offset = "0x77C5C10", VA = "0x1877C7010")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool JHOMDMKMMKD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject PANLPBPGMNC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool FFLNCJPMHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x77C7360", Offset = "0x77C5F60", VA = "0x1877C7360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77C72A0", Offset = "0x77C5EA0", VA = "0x1877C72A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77C5E70", Offset = "0x77C4A70", VA = "0x1877C5E70")]
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
		public NAGCDCIBHBC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KAPJFFJHEMA
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BANOAKPHPPN(PooledParticle.EJHPFCJDENF HFLMMIGMFBB);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum OAILCALLEBC
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
		public enum EJHPFCJDENF
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
		public interface ANJIHGPGMDK
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool IILDCCGCFAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 AEOOKGPCHHC
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera HPAMBKDEBFM
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
			[Cpp2IlInjected.Address(RVA = "0x65C1900", Offset = "0x65C0500", VA = "0x1865C1900")]
			public ColorConfiguration(ParticleSystem JOABFHGMFKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x77C5490", Offset = "0x77C4090", VA = "0x1877C5490")]
			public void EIDEKJGGHAJ(Color PFOKHHCFPNE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IKAJIEJHNJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IKAJIEJHNJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x77C5FD0", Offset = "0x77C4BD0", VA = "0x1877C5FD0")]
			internal void JBFEPDGMOOO(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DFMKOLHHMFC : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private ANJIHGPGMDK <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public DFMKOLHHMFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x77C5680", Offset = "0x77C4280", VA = "0x1877C5680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x77C5CA0", Offset = "0x77C48A0", VA = "0x1877C5CA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EBKJNOCONNI : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public EBKJNOCONNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x77C5CF0", Offset = "0x77C48F0", VA = "0x1877C5CF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x77C5D60", Offset = "0x77C4960", VA = "0x1877C5D60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> BDKLOOJONKO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<KAPJFFJHEMA> DGOJBNEGDNI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> DIJNGGDECBI;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static NAEMDCMJKFJ CPFHPJCMHJH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float CAGPGKLPFMN = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool MMPAFONHDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int LKLDLEEDCAH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private EJHPFCJDENF category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? CCEOCPDHOAI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] BIOOHICKKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool KKJPMBPHBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float LGHNBMKCJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float DHDKKNPIGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform APEHJGPDCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 DGNJLNDBDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 JGMCECDJBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private OAILCALLEBC IJAFIFPDKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NAEMDCMJKFJ NPAFNBHDODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool FMOOPBANFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform COIANACMHAK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> HEELFFJLNLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x77CB600", Offset = "0x77CA200", VA = "0x1877CB600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EJHPFCJDENF ELKEDAKEDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x980AE0", Offset = "0x97F6E0", VA = "0x180980AE0")]
			get
			{
				return default(EJHPFCJDENF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int CEEDAPOOPFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DMHGNEEJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x77CB350", Offset = "0x77C9F50", VA = "0x1877CB350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int FFDBCPLOBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x77CB4C0", Offset = "0x77CA0C0", VA = "0x1877CB4C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool DFIPFKCPAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x77C87F0", Offset = "0x77C73F0", VA = "0x1877C87F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem OFJBGLHIEOE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] EFOJMLMLMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] ABFKFIODNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OAILCALLEBC PONHLCNCIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x963140", Offset = "0x961D40", VA = "0x180963140")]
			get
			{
				return default(OAILCALLEBC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x77C9600", Offset = "0x77C8200", VA = "0x1877C9600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform FDCDPIOJPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x77CB650", Offset = "0x77CA250", VA = "0x1877CB650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KALLAJDKGCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x77CB2B0", Offset = "0x77C9EB0", VA = "0x1877CB2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x77CB6A0", Offset = "0x77CA2A0", VA = "0x1877CB6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77CACF0", Offset = "0x77C98F0", VA = "0x1877CACF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle DLFNGKIHPEG, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77CAE10", Offset = "0x77C9A10", VA = "0x1877CAE10")]
		public static PooledParticle TryPlayPrefab(PooledParticle DLFNGKIHPEG, Vector3 FCININPMBGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77CA2E0", Offset = "0x77C8EE0", VA = "0x1877CA2E0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77C9530", Offset = "0x77C8130", VA = "0x1877C9530")]
		private void NJOEJJGCLFL(bool KOGJFECFIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77C83D0", Offset = "0x77C6FD0", VA = "0x1877C83D0")]
		[IteratorStateMachine(typeof(DFMKOLHHMFC))]
		private static IEnumerator<LNKBBFODFEI> EEDBOLHACEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77C7FD0", Offset = "0x77C6BD0", VA = "0x1877C7FD0")]
		private static void CAEFMDKKLJI(Stopwatch IFHLDBMAMPN, Vector3 BBAPNHLPPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77C9340", Offset = "0x77C7F40", VA = "0x1877C9340")]
		private static int NANKNEALDEB(PooledParticle IFMENDFGFGN, PooledParticle DPEOCFNLADP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77C7CD0", Offset = "0x77C68D0", VA = "0x1877C7CD0")]
		private static int BANOAKPHPPN(EJHPFCJDENF HFLMMIGMFBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77C7DE0", Offset = "0x77C69E0", VA = "0x1877C7DE0")]
		protected void BLJFAIPJEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77C8870", Offset = "0x77C7470", VA = "0x1877C8870")]
		protected void KIEHLGDDEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77C7A60", Offset = "0x77C6660", VA = "0x1877C7A60", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77C9010", Offset = "0x77C7C10", VA = "0x1877C9010")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77C9620", Offset = "0x77C8220", VA = "0x1877C9620")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77C8340", Offset = "0x77C6F40", VA = "0x1877C8340")]
		[IteratorStateMachine(typeof(EBKJNOCONNI))]
		private IEnumerator<LNKBBFODFEI> EDHHNHFAMOJ(float ALPIBOHIFKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77C84F0", Offset = "0x77C70F0", VA = "0x1877C84F0")]
		private void GFEMBPJJFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77CAA30", Offset = "0x77C9630", VA = "0x1877CAA30")]
		public void SetDuration(float ALPIBOHIFKI, bool FNEJFMHJDGF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77C96B0", Offset = "0x77C82B0", VA = "0x1877C96B0")]
		public void Play(Transform IHNMFGCECIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77C9F50", Offset = "0x77C8B50", VA = "0x1877C9F50")]
		public void Play(Transform IHNMFGCECIC, bool BBMFIMBJBNL, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77C9800", Offset = "0x77C8400", VA = "0x1877C9800")]
		public void Play(Transform IHNMFGCECIC, Vector3 JGMCECDJBEE, bool BBMFIMBJBNL, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77C9950", Offset = "0x77C8550", VA = "0x1877C9950")]
		public void Play(Transform JLLPKHOGMBD, Quaternion APLHHNGOEFP, bool BBMFIMBJBNL = false, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x77CA0C0", Offset = "0x77C8CC0", VA = "0x1877CA0C0")]
		public void Play(Transform JLLPKHOGMBD, Vector3 JGMCECDJBEE, Quaternion APLHHNGOEFP, bool BBMFIMBJBNL = false, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x77C9BF0", Offset = "0x77C87F0", VA = "0x1877C9BF0")]
		public void Play(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, Vector3 CNPDFOJECOP, bool BBMFIMBJBNL = false, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77C9A90", Offset = "0x77C8690", VA = "0x1877C9A90")]
		public void Play(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, bool BBMFIMBJBNL = false, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x77C9D70", Offset = "0x77C8970", VA = "0x1877C9D70")]
		public void Play(bool BBMFIMBJBNL = false, float NMJKLEFBDHM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x77CAC50", Offset = "0x77C9850", VA = "0x1877CAC50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x77CAB00", Offset = "0x77C9700", VA = "0x1877CAB00")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77C8650", Offset = "0x77C7250", VA = "0x1877C8650")]
		private void HAIIGGCEMFH(float ALPIBOHIFKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77C93F0", Offset = "0x77C7FF0", VA = "0x1877C93F0")]
		private void NANLBIPBLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77CA1F0", Offset = "0x77C8DF0", VA = "0x1877CA1F0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77CA460", Offset = "0x77C9060", VA = "0x1877CA460")]
		public void SetColor(Color PFOKHHCFPNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77C8430", Offset = "0x77C7030", VA = "0x1877C8430")]
		private void FFEFDPIPOAK(float? MKKLKGKOEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x77C8FA0", Offset = "0x77C7BA0", VA = "0x1877C8FA0")]
		private void LMAFGHEJBKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x77C8E70", Offset = "0x77C7A70", VA = "0x1877C8E70")]
		private void LJDMEPMBKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77CB220", Offset = "0x77C9E20", VA = "0x1877CB220")]
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
