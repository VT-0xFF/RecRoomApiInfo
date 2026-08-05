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
		[Cpp2IlInjected.Address(RVA = "0x51A1FD0", Offset = "0x51A0FD0", VA = "0x1851A1FD0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LCEPMNHAOBK, float HMLHKHLPOMH, Vector3 CAIONMHOLNJ, Quaternion IPKDODBLLOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x51A1D40", Offset = "0x51A0D40", VA = "0x1851A1D40")]
		public void SetDamageValue(float HMLHKHLPOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x51A2170", Offset = "0x51A1170", VA = "0x1851A2170")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FDAMNINMDHF<T> : global::IHDAFNHGAJF<T>, CFBFBBBFDFL, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PCJFNJBNBEA<T> : CFBFBBBFDFL, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCIKAKADJKC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LEDNDJMNLEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GJJGKCKLOCL<T> : global::AADOKEPFDDG<T>, global::FDAMNINMDHF<T>, global::IHDAFNHGAJF<T>, CFBFBBBFDFL, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BCACMOIEHKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public GJJGKCKLOCL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
			public BCACMOIEHKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3183840", Offset = "0x3182840", VA = "0x183183840")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x27F62E0", Offset = "0x27F52E0", VA = "0x1827F62E0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::MIJJEEPKDNA<T> DHBMJHLJJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KDGJOEIKKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PFFIJAIAFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FFEBDMPJINN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x31855F0", Offset = "0x31845F0", VA = "0x1831855F0")]
		public GJJGKCKLOCL(global::MIJJEEPKDNA<T> DHBMJHLJJEP, ObjectPool KDGJOEIKKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x31854B0", Offset = "0x31844B0", VA = "0x1831854B0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PJCBLIFNELJ<T> : FKDIGOMJOEO, global::PCJFNJBNBEA<T>, CFBFBBBFDFL, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EDBCEHGONOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PJCBLIFNELJ<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
			public EDBCEHGONOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3184B50", Offset = "0x3183B50", VA = "0x183184B50")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x10E2B70", Offset = "0x10E1B70", VA = "0x1810E2B70")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::MIJJEEPKDNA<T> DHBMJHLJJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool FFEBDMPJINN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x31978D0", Offset = "0x31968D0", VA = "0x1831978D0")]
		public PJCBLIFNELJ(global::MIJJEEPKDNA<T> DHBMJHLJJEP, ObjectPool KDGJOEIKKOJ, int NKNGHJDPNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3197880", Offset = "0x3196880", VA = "0x183197880", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HPJDDBAONBH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LEDNDJMNLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::AADOKEPFDDG<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::MIJJEEPKDNA<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public HPJDDBAONBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3185A70", Offset = "0x3184A70", VA = "0x183185A70")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3185B00", Offset = "0x3184B00", VA = "0x183185B00")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3185B60", Offset = "0x3184B60", VA = "0x183185B60")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<GCIKAKADJKC> PFFODHIKJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BBHGACLKFJJ IJHNOOFEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KDGJOEIKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool FFEBDMPJINN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool DJPKHCALIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x519FFC0", Offset = "0x519EFC0", VA = "0x18519FFC0")]
	private static void AJFIOCMINCH(Component IMENKKCALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51A05B0", Offset = "0x519F5B0", VA = "0x1851A05B0")]
	public LEDNDJMNLEK(string GNLFENDNOAM, int NAKHDCKJOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2603030", Offset = "0x2602030", VA = "0x182603030")]
	public global::FDAMNINMDHF<T> LFOGKPCDJPM<T>(AssetReference PNFNBFKJMEE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2286AE0", Offset = "0x2285AE0", VA = "0x182286AE0")]
	public global::PCJFNJBNBEA<T> CPBDOGMKINI<T>(AssetReference PNFNBFKJMEE, int NGOMPCKMIBL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D77EA0", Offset = "0x1D76EA0", VA = "0x181D77EA0")]
	public global::IHDAFNHGAJF<bool> HMOLHLDKLLF<T>(AssetReference PNFNBFKJMEE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51A02F0", Offset = "0x519F2F0", VA = "0x1851A02F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51A01C0", Offset = "0x519F1C0", VA = "0x1851A01C0")]
	private void DFBBFFFPADC(UnityEngine.Object EDCIOCEFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51A0400", Offset = "0x519F400", VA = "0x1851A0400")]
	private ObjectPool HFIAPKEOIAN(string GNLFENDNOAM)
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
		private static GlobalPool AOOGANDJKHI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KNDOJKPMCLK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LOBJDNDFAIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x519FE30", Offset = "0x519EE30", VA = "0x18519FE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x519FCE0", Offset = "0x519ECE0", VA = "0x18519FCE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x519FDC0", Offset = "0x519EDC0", VA = "0x18519FDC0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LJNANEGJPKE> AAJDAOKOIKH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF7A0", Offset = "0x1FDE7A0", VA = "0x181FDF7A0")]
		public T Acquire<T>(T LCEPMNHAOBK, [Optional] Action<Component> JGLDHAAENGB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x265F530", Offset = "0x265E530", VA = "0x18265F530")]
		public bool Release<T>(T OOJKHPLJJMJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24CA540", Offset = "0x24C9540", VA = "0x1824CA540")]
		public void Prefill<T>(T LCEPMNHAOBK, int DNBEIBMGPJA, [Optional] Action<Component> GBDPPNEGDFB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x265F490", Offset = "0x265E490", VA = "0x18265F490")]
		public bool Exists<T>(T LCEPMNHAOBK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24CA4A0", Offset = "0x24C94A0", VA = "0x1824CA4A0")]
		public void Clear<T>(T LCEPMNHAOBK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x51A1960", Offset = "0x51A0960", VA = "0x1851A1960")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x228E3C0", Offset = "0x228D3C0", VA = "0x18228E3C0")]
		private LJNANEGJPKE PPILBIBCAJC<T>(T LCEPMNHAOBK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80")]
		public void TrackInstantiation(string EOPKOBPDGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80")]
		public void EnableStats(bool HFOMBKLIGNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x519FDC0", Offset = "0x519EDC0", VA = "0x18519FDC0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LJNANEGJPKE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JINCCKAPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GPAPEMGMEPI(bool LLNMBMGHFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component CNNKFOCMEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int JABLFDINMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void CPBDOGMKINI(int NGOMPCKMIBL, Action<Component> GBDPPNEGDFB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component LFOGKPCDJPM(Action<Component> JGLDHAAENGB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool FDONFDGPDGF(Component EGIJCCMEKBG);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void BFHLNDADIAA();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51A07D0", Offset = "0x519F7D0", VA = "0x1851A07D0")]
	protected void HPKEJJKMOJK(Component OOJKHPLJJMJ, bool LLNMBMGHFMF, bool CGFHAAODLMD, bool MCADGDBNMDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51A0950", Offset = "0x519F950", VA = "0x1851A0950")]
	protected void MABJAGFAPEO(Transform CIBAGGAKFAB, bool LLNMBMGHFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	protected LJNANEGJPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JOLDOIHDJIM<T> : LJNANEGJPKE where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LCEPMNHAOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool KMANMFNNCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CGFHAAODLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> BEBKECMOKNE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component CNNKFOCMEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42C4610", Offset = "0x42C3610", VA = "0x1842C4610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int JABLFDINMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x42C4630", Offset = "0x42C3630", VA = "0x1842C4630", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x42C4C80", Offset = "0x42C3C80", VA = "0x1842C4C80")]
	public JOLDOIHDJIM(T LCEPMNHAOBK, ObjectPool KMANMFNNCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42C4660", Offset = "0x42C3660", VA = "0x1842C4660", Slot = "7")]
	public override void CPBDOGMKINI(int NGOMPCKMIBL, Action<Component> JGLDHAAENGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x42C4900", Offset = "0x42C3900", VA = "0x1842C4900", Slot = "8")]
	public override Component LFOGKPCDJPM(Action<Component> JGLDHAAENGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x42C4770", Offset = "0x42C3770", VA = "0x1842C4770", Slot = "9")]
	public override bool FDONFDGPDGF(Component EGIJCCMEKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x42C43D0", Offset = "0x42C33D0", VA = "0x1842C43D0", Slot = "10")]
	public override void BFHLNDADIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x42C4B30", Offset = "0x42C3B30", VA = "0x1842C4B30")]
	private T PKKJNBGOKDN()
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
		public interface MAPONIGBIPP
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject IDLHOMGHAKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51A1610", Offset = "0x51A0610", VA = "0x1851A1610")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51A18F0", Offset = "0x51A08F0", VA = "0x1851A18F0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool AOOGANDJKHI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject KNDOJKPMCLK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool LOBJDNDFAIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x51A1B80", Offset = "0x51A0B80", VA = "0x1851A1B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51A1AA0", Offset = "0x51A0AA0", VA = "0x1851A1AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x519FDC0", Offset = "0x519EDC0", VA = "0x18519FDC0")]
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
		public LJNANEGJPKE PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum DHINLENHDEE
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public interface ACFHCBNALDN
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool ODPPBPHHDNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 KHMGPAAKKBO
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera KCAGJPFECGO
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA1A900", Offset = "0xA19900", VA = "0x180A1A900")]
			public ColorConfiguration(ParticleSystem NKBPBAKOPHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x519F4E0", Offset = "0x519E4E0", VA = "0x18519F4E0")]
			public void PDBFPMHCDIK(Color DKGKEIAPEFP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class NPAJOIFGJCP : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private CNHILGIAPIF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private ACFHCBNALDN <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
			[DebuggerHidden]
			public NPAJOIFGJCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x51A0B40", Offset = "0x519FB40", VA = "0x1851A0B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x51A15C0", Offset = "0x51A05C0", VA = "0x1851A15C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class BIGOKMLDFPI : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private CNHILGIAPIF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
			[DebuggerHidden]
			public BIGOKMLDFPI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x519F3D0", Offset = "0x519E3D0", VA = "0x18519F3D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x519F490", Offset = "0x519E490", VA = "0x18519F490", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JFKFPGLEIDC;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> MFLBMBHDKAA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static DMIEKLLPPEA COIOAJBLJML;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float PIGBKNALBGP = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool BPEBAIILINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int NPLCBFNPPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ParticleSystem.MinMaxGradient[] CNPNGCBPPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool KBDCDPNGBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float NOGPNEFNENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float PBAOGAPKJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform AAPAOJJHNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 HCMCBFOIAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 LOPEGBBIBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private DHINLENHDEE GMBPKJMLNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private DMIEKLLPPEA MKLHCCBJAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool MHALFECNKLO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool GHMAEFMIGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x51A2EA0", Offset = "0x51A1EA0", VA = "0x1851A2EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem EILJAOKIANA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6AFCC0", Offset = "0x6AECC0", VA = "0x1806AFCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] BELJPACNFIL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B4A30", Offset = "0x5B3A30", VA = "0x1805B4A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C4580", Offset = "0x6C3580", VA = "0x1806C4580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] LIFDGJKKMKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x58D010", Offset = "0x58C010", VA = "0x18058D010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x58D020", Offset = "0x58C020", VA = "0x18058D020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DHINLENHDEE DEJOAGNEAMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x657380", Offset = "0x656380", VA = "0x180657380")]
			get
			{
				return default(DHINLENHDEE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x51A34B0", Offset = "0x51A24B0", VA = "0x1851A34B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PIDOKPFHLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x51A4E30", Offset = "0x51A3E30", VA = "0x1851A4E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x51A4ED0", Offset = "0x51A3ED0", VA = "0x1851A4ED0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51A4AD0", Offset = "0x51A3AD0", VA = "0x1851A4AD0")]
		public static PooledParticle TryPlayPrefab(PooledParticle LCEPMNHAOBK, Vector3 CAIONMHOLNJ, Quaternion IPKDODBLLOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51A48E0", Offset = "0x51A38E0", VA = "0x1851A48E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle LCEPMNHAOBK, Vector3 CAIONMHOLNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x51A4120", Offset = "0x51A3120", VA = "0x1851A4120")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x51A2440", Offset = "0x51A1440", VA = "0x1851A2440")]
		private void EIJIPHLBKGH(bool APGPMHJCJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x51A27E0", Offset = "0x51A17E0", VA = "0x1851A27E0")]
		[IteratorStateMachine(typeof(NPAJOIFGJCP))]
		private static IEnumerator<CNHILGIAPIF> HCLBPIBCCGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x51A34D0", Offset = "0x51A24D0", VA = "0x1851A34D0")]
		protected void PNKJNPLMAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51A2F80", Offset = "0x51A1F80", VA = "0x1851A2F80")]
		protected void OCNIPNIGPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51A2250", Offset = "0x51A1250", VA = "0x1851A2250", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x51A2BC0", Offset = "0x51A1BC0", VA = "0x1851A2BC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x51A3430", Offset = "0x51A2430", VA = "0x1851A3430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x51A2830", Offset = "0x51A1830", VA = "0x1851A2830")]
		[IteratorStateMachine(typeof(BIGOKMLDFPI))]
		private IEnumerator<CNHILGIAPIF> INMLEMGAPPP(float FJIIENLHOEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x51A24C0", Offset = "0x51A14C0", VA = "0x1851A24C0")]
		private void FDONFDGPDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51A46C0", Offset = "0x51A36C0", VA = "0x1851A46C0")]
		public void SetDuration(float FJIIENLHOEJ, bool MBCNMHHDDHC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x51A3E80", Offset = "0x51A2E80", VA = "0x1851A3E80")]
		public void Play(Transform BBKIJPBDABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x51A3CF0", Offset = "0x51A2CF0", VA = "0x1851A3CF0")]
		public void Play(Transform BBKIJPBDABA, bool KELIDOHEIOD, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x51A3960", Offset = "0x51A2960", VA = "0x1851A3960")]
		public void Play(Transform BBKIJPBDABA, Vector3 LOPEGBBIBHK, bool KELIDOHEIOD, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x51A3710", Offset = "0x51A2710", VA = "0x1851A3710")]
		public void Play(Transform ODHGBGKHPJN, Quaternion IPKDODBLLOB, bool KELIDOHEIOD = false, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x51A3AB0", Offset = "0x51A2AB0", VA = "0x1851A3AB0")]
		public void Play(Transform ODHGBGKHPJN, Vector3 LOPEGBBIBHK, Quaternion IPKDODBLLOB, bool KELIDOHEIOD = false, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x51A3890", Offset = "0x51A2890", VA = "0x1851A3890")]
		public void Play(Vector3 CAIONMHOLNJ, Quaternion IPKDODBLLOB, Vector3 IDEKMPBMJNA, bool KELIDOHEIOD = false, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x51A3650", Offset = "0x51A2650", VA = "0x1851A3650")]
		public void Play(Vector3 CAIONMHOLNJ, Quaternion IPKDODBLLOB, bool KELIDOHEIOD = false, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x51A3BE0", Offset = "0x51A2BE0", VA = "0x1851A3BE0")]
		public void Play(bool KELIDOHEIOD = false, float GNGNCFLDFFK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51A4850", Offset = "0x51A3850", VA = "0x1851A4850")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51A47A0", Offset = "0x51A37A0", VA = "0x1851A47A0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x51A2660", Offset = "0x51A1660", VA = "0x1851A2660")]
		private void FKGGGMPMBLB(float FJIIENLHOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x51A2A50", Offset = "0x51A1A50", VA = "0x1851A2A50")]
		private void LJIMFPKEFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x51A4000", Offset = "0x51A3000", VA = "0x1851A4000")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x51A42A0", Offset = "0x51A32A0", VA = "0x1851A42A0")]
		public void SetColor(Color DKGKEIAPEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x51A28B0", Offset = "0x51A18B0", VA = "0x1851A28B0")]
		private void LEEBOLEDLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x51A4DA0", Offset = "0x51A3DA0", VA = "0x1851A4DA0")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x51A2F50", Offset = "0x51A1F50", VA = "0x1851A2F50")]
		[CompilerGenerated]
		private void MOLHCPEGEDP(ParticleSystemRenderer CPMOHHNKKCP)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x519F6F0", Offset = "0x519E6F0", VA = "0x18519F6F0")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x519F7F0", Offset = "0x519E7F0", VA = "0x18519F7F0")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
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
