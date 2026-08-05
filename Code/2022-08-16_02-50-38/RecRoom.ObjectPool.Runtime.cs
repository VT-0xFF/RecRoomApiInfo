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
		[Cpp2IlInjected.Address(RVA = "0x57D0570", Offset = "0x57CF170", VA = "0x1857D0570")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LILAAJNNHHA, float MLHIMCEDEMN, Vector3 AJODAOPNJGC, Quaternion HMDLEIFEMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x57D02E0", Offset = "0x57CEEE0", VA = "0x1857D02E0")]
		public void SetDamageValue(float MLHIMCEDEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x57D0710", Offset = "0x57CF310", VA = "0x1857D0710")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BGJBFKDCCLH<T> : global::OEKDNOIOMEB<T>, IHEBICEMHFG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GJHAFGMDAGM<T> : IHEBICEMHFG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FLHNGABKMPM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FEIPDOOEENJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class AOLJIPMCFFN<T> : global::DDFBBDKIGCD<T>, global::BGJBFKDCCLH<T>, global::OEKDNOIOMEB<T>, IHEBICEMHFG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LFKHMGKPMAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AOLJIPMCFFN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
			public LFKHMGKPMAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3C07A20", Offset = "0x3C06620", VA = "0x183C07A20")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2F789C0", Offset = "0x2F775C0", VA = "0x182F789C0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::GHDPIMKJGAM<T> LBJIFAKJDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool HEDOLDJNDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CPEJHBAMMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool ONBALJNPLJC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6AF0", Offset = "0x3BF56F0", VA = "0x183BF6AF0")]
		public AOLJIPMCFFN(global::GHDPIMKJGAM<T> LBJIFAKJDAG, ObjectPool HEDOLDJNDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BF69B0", Offset = "0x3BF55B0", VA = "0x183BF69B0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GPLADMLODKP<T> : DLLPNBKFAHM, global::GJHAFGMDAGM<T>, IHEBICEMHFG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AEENIMLAHAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GPLADMLODKP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
			public AEENIMLAHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3BF68F0", Offset = "0x3BF54F0", VA = "0x183BF68F0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1C424E0", Offset = "0x1C410E0", VA = "0x181C424E0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::GHDPIMKJGAM<T> LBJIFAKJDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool ONBALJNPLJC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C03200", Offset = "0x3C01E00", VA = "0x183C03200")]
		public GPLADMLODKP(global::GHDPIMKJGAM<T> LBJIFAKJDAG, ObjectPool HEDOLDJNDKL, int MKNEKMBGJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C031B0", Offset = "0x3C01DB0", VA = "0x183C031B0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BEGFIKGDPDF<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FEIPDOOEENJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::DDFBBDKIGCD<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::GHDPIMKJGAM<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public BEGFIKGDPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6D20", Offset = "0x3BF5920", VA = "0x183BF6D20")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6DC0", Offset = "0x3BF59C0", VA = "0x183BF6DC0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6E20", Offset = "0x3BF5A20", VA = "0x183BF6E20")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<FLHNGABKMPM> HEHHEFBEOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FHCCEMGEEDA IHHHOFNEKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool HEDOLDJNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool DHDNBBIJCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x57CEAF0", Offset = "0x57CD6F0", VA = "0x1857CEAF0")]
	private static void OMOFKJCJFFL(Component GPCFBGLDMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x57CED50", Offset = "0x57CD950", VA = "0x1857CED50")]
	public FEIPDOOEENJ(string EHNIBBMIAJN, int FBNJKLBHJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x238B270", Offset = "0x2389E70", VA = "0x18238B270")]
	public global::BGJBFKDCCLH<T> HDHCDMEAMMM<T>(AssetReference KGLKHDLNDBM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2186CD0", Offset = "0x21858D0", VA = "0x182186CD0")]
	public global::GJHAFGMDAGM<T> DJFKFEDFMNB<T>(AssetReference KGLKHDLNDBM, int GCKMDOIKFCL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6CB0", Offset = "0x1DF58B0", VA = "0x181DF6CB0")]
	public global::OEKDNOIOMEB<bool> MDNKFKLILBA<T>(AssetReference KGLKHDLNDBM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57CE890", Offset = "0x57CD490", VA = "0x1857CE890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57CE760", Offset = "0x57CD360", VA = "0x1857CE760")]
	private void BOOINFNLEDD(UnityEngine.Object JGNEEPKNCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57CE9A0", Offset = "0x57CD5A0", VA = "0x1857CE9A0")]
	private ObjectPool HCIGHBKNCFE(string EHNIBBMIAJN)
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
		private static GlobalPool NKJOPPHMOJN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject LDMMLDMBDDC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool PPLIIACIKDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x57CFA20", Offset = "0x57CE620", VA = "0x1857CFA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57CF8D0", Offset = "0x57CE4D0", VA = "0x1857CF8D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57CF9B0", Offset = "0x57CE5B0", VA = "0x1857CF9B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, FLFMPKEHHFO> IBIHPLPENBM;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x22510F0", Offset = "0x224FCF0", VA = "0x1822510F0")]
		public T Acquire<T>(T LILAAJNNHHA, [Optional] Action<Component> JIKAIHPHCII) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2328210", Offset = "0x2326E10", VA = "0x182328210")]
		public bool Release<T>(T HLJJNKOAONN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2230070", Offset = "0x222EC70", VA = "0x182230070")]
		public void Prefill<T>(T LILAAJNNHHA, int KEBIMDLDCBF, [Optional] Action<Component> JDABMAAPBBL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2328170", Offset = "0x2326D70", VA = "0x182328170")]
		public bool Exists<T>(T LILAAJNNHHA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x222FFD0", Offset = "0x222EBD0", VA = "0x18222FFD0")]
		public void Clear<T>(T LILAAJNNHHA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57CFF00", Offset = "0x57CEB00", VA = "0x1857CFF00")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2745010", Offset = "0x2743C10", VA = "0x182745010")]
		private FLFMPKEHHFO FBBPEGEGBCN<T>(T LILAAJNNHHA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public void TrackInstantiation(string APAGPDAKJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public void EnableStats(bool DOFKELAHJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x57CF9B0", Offset = "0x57CE5B0", VA = "0x1857CF9B0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class FLFMPKEHHFO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BEECIANDMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void APHMOPGGAKJ(bool IBNFCBHHOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component BAJBNMLKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int GIODFEGKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void DJFKFEDFMNB(int GCKMDOIKFCL, Action<Component> JDABMAAPBBL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component HDHCDMEAMMM(Action<Component> JIKAIHPHCII);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool FNAPKEMHLBG(Component NMCNJGIBDPP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void MNHBKLHOOAC();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57CF750", Offset = "0x57CE350", VA = "0x1857CF750")]
	protected void LINOJIHFOOJ(Component HLJJNKOAONN, bool IBNFCBHHOIK, bool KPLAIENKFML, bool DPOLOPKNHEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57CF560", Offset = "0x57CE160", VA = "0x1857CF560")]
	protected void GFEDCLGJMKE(Transform BJGNCMDPJLM, bool IBNFCBHHOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected FLFMPKEHHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OIBHJLABNJN<T> : FLFMPKEHHFO where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LILAAJNNHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool GJIMBBDPJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool KPLAIENKFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> HCIAIFFNFEG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component BAJBNMLKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A595C0", Offset = "0x2A581C0", VA = "0x182A595C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int GIODFEGKJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2A59080", Offset = "0x2A57C80", VA = "0x182A59080", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A59820", Offset = "0x2A58420", VA = "0x182A59820")]
	public OIBHJLABNJN(T LILAAJNNHHA, ObjectPool GJIMBBDPJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A58F70", Offset = "0x2A57B70", VA = "0x182A58F70", Slot = "7")]
	public override void DJFKFEDFMNB(int GCKMDOIKFCL, Action<Component> JIKAIHPHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A59390", Offset = "0x2A57F90", VA = "0x182A59390", Slot = "8")]
	public override Component HDHCDMEAMMM(Action<Component> JIKAIHPHCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A590B0", Offset = "0x2A57CB0", VA = "0x182A590B0", Slot = "9")]
	public override bool FNAPKEMHLBG(Component NMCNJGIBDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A595E0", Offset = "0x2A581E0", VA = "0x182A595E0", Slot = "10")]
	public override void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A59240", Offset = "0x2A57E40", VA = "0x182A59240")]
	private T GMACEFDLPEI()
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
		public interface CBCFMKNMBLO
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject EDFBONHJLJF
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
		[Cpp2IlInjected.Address(RVA = "0x57CFBB0", Offset = "0x57CE7B0", VA = "0x1857CFBB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57CFE90", Offset = "0x57CEA90", VA = "0x1857CFE90")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool NKJOPPHMOJN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject LDMMLDMBDDC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool PPLIIACIKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x57D0120", Offset = "0x57CED20", VA = "0x1857D0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57D0040", Offset = "0x57CEC40", VA = "0x1857D0040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57CF9B0", Offset = "0x57CE5B0", VA = "0x1857CF9B0")]
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
		public FLFMPKEHHFO PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum MBMCPIEKFIP
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
		public interface DIDJKPMCGCC
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool ABEFKLDJJFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 FOAPJEFINLD
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera INNJGBNHGBK
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
			[Cpp2IlInjected.Address(RVA = "0xA72C00", Offset = "0xA71800", VA = "0x180A72C00")]
			public ColorConfiguration(ParticleSystem AGAKIEFEDCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x57CE550", Offset = "0x57CD150", VA = "0x1857CE550")]
			public void JANAOJNCCDA(Color GOKDGJHFBBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CJLMHHANJJH : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private DIDJKPMCGCC <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public CJLMHHANJJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x57CDA80", Offset = "0x57CC680", VA = "0x1857CDA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x57CE500", Offset = "0x57CD100", VA = "0x1857CE500", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class AGINPFDHPII : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public AGINPFDHPII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x57CD970", Offset = "0x57CC570", VA = "0x1857CD970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x57CDA30", Offset = "0x57CC630", VA = "0x1857CDA30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NIAPCMHFOLI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> DBCMDGBMNIF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static ILEKNFOCKKN IACKOBIFLEN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float IGPDMCEKKJG = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool BDNJFCGJCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int EOKFLNFFAPK;

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
		private ParticleSystem.MinMaxGradient[] JCIHMHNLGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool DAOLEPPHCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float ALEPEAODKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float DPCKKPADLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform JOMCPOKMJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 HHHONGKOMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 FHBJLNPLIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private MBMCPIEKFIP GAHONKAICPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ILEKNFOCKKN IONPKMNBNCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool GEBMHKFAIID;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool KPMLEAPMBNA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x57D1440", Offset = "0x57D0040", VA = "0x1857D1440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem KAFODBFALON
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] LECONGDNPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] DMKGECDDBCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MBMCPIEKFIP KALBDHBOKAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6AF380", Offset = "0x6ADF80", VA = "0x1806AF380")]
			get
			{
				return default(MBMCPIEKFIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x57D1420", Offset = "0x57D0020", VA = "0x1857D1420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HNEJPOCONMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x57D33D0", Offset = "0x57D1FD0", VA = "0x1857D33D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x57D3470", Offset = "0x57D2070", VA = "0x1857D3470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x57D3070", Offset = "0x57D1C70", VA = "0x1857D3070")]
		public static PooledParticle TryPlayPrefab(PooledParticle LILAAJNNHHA, Vector3 AJODAOPNJGC, Quaternion HMDLEIFEMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x57D2E80", Offset = "0x57D1A80", VA = "0x1857D2E80")]
		public static PooledParticle TryPlayPrefab(PooledParticle LILAAJNNHHA, Vector3 AJODAOPNJGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x57D26C0", Offset = "0x57D12C0", VA = "0x1857D26C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x57D13A0", Offset = "0x57CFFA0", VA = "0x1857D13A0")]
		private void MINPGOCMEGA(bool DICKNPIGMGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x57D16F0", Offset = "0x57D02F0", VA = "0x1857D16F0")]
		[IteratorStateMachine(typeof(CJLMHHANJJH))]
		private static IEnumerator<GGCFHHNCLAL> PKKBFPHBBMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57D0B80", Offset = "0x57CF780", VA = "0x1857D0B80")]
		protected void EKPEGLJMBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57D1740", Offset = "0x57D0340", VA = "0x1857D1740")]
		protected void PNLPAOLNBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57D07F0", Offset = "0x57CF3F0", VA = "0x1857D07F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x57D10C0", Offset = "0x57CFCC0", VA = "0x1857D10C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57D1670", Offset = "0x57D0270", VA = "0x1857D1670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x57D0EA0", Offset = "0x57CFAA0", VA = "0x1857D0EA0")]
		[IteratorStateMachine(typeof(AGINPFDHPII))]
		private IEnumerator<GGCFHHNCLAL> JCJBAPOKCKE(float IFKOCEIICKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57D0D00", Offset = "0x57CF900", VA = "0x1857D0D00")]
		private void FNAPKEMHLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x57D2C60", Offset = "0x57D1860", VA = "0x1857D2C60")]
		public void SetDuration(float IFKOCEIICKC, bool JPAGJBEPPLJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x57D2420", Offset = "0x57D1020", VA = "0x1857D2420")]
		public void Play(Transform FLGOJEMACIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x57D2290", Offset = "0x57D0E90", VA = "0x1857D2290")]
		public void Play(Transform FLGOJEMACIC, bool OMNPCLJMAPM, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x57D1F00", Offset = "0x57D0B00", VA = "0x1857D1F00")]
		public void Play(Transform FLGOJEMACIC, Vector3 FHBJLNPLIFI, bool OMNPCLJMAPM, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57D1CB0", Offset = "0x57D08B0", VA = "0x1857D1CB0")]
		public void Play(Transform OFPHOPJIBKL, Quaternion HMDLEIFEMBE, bool OMNPCLJMAPM = false, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x57D2050", Offset = "0x57D0C50", VA = "0x1857D2050")]
		public void Play(Transform OFPHOPJIBKL, Vector3 FHBJLNPLIFI, Quaternion HMDLEIFEMBE, bool OMNPCLJMAPM = false, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x57D1E30", Offset = "0x57D0A30", VA = "0x1857D1E30")]
		public void Play(Vector3 AJODAOPNJGC, Quaternion HMDLEIFEMBE, Vector3 EGPMCPBBKLM, bool OMNPCLJMAPM = false, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x57D1BF0", Offset = "0x57D07F0", VA = "0x1857D1BF0")]
		public void Play(Vector3 AJODAOPNJGC, Quaternion HMDLEIFEMBE, bool OMNPCLJMAPM = false, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x57D2180", Offset = "0x57D0D80", VA = "0x1857D2180")]
		public void Play(bool OMNPCLJMAPM = false, float BIAJDJDPHIF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57D2DF0", Offset = "0x57D19F0", VA = "0x1857D2DF0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x57D2D40", Offset = "0x57D1940", VA = "0x1857D2D40")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x57D14F0", Offset = "0x57D00F0", VA = "0x1857D14F0")]
		private void ODKGOGJFOKH(float IFKOCEIICKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x57D0F50", Offset = "0x57CFB50", VA = "0x1857D0F50")]
		private void LKFJGPJDJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x57D25A0", Offset = "0x57D11A0", VA = "0x1857D25A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57D2840", Offset = "0x57D1440", VA = "0x1857D2840")]
		public void SetColor(Color GOKDGJHFBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57D09E0", Offset = "0x57CF5E0", VA = "0x1857D09E0")]
		private void BMBMEIPECHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x57D3340", Offset = "0x57D1F40", VA = "0x1857D3340")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57D0F20", Offset = "0x57CFB20", VA = "0x1857D0F20")]
		[CompilerGenerated]
		private void KAJGANIEIIO(ParticleSystemRenderer IJJIHFBLBBJ)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57CF2A0", Offset = "0x57CDEA0", VA = "0x1857CF2A0")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57CEF70", Offset = "0x57CDB70", VA = "0x1857CEF70")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
