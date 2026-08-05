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
		[Cpp2IlInjected.Address(RVA = "0x619C2A0", Offset = "0x619ACA0", VA = "0x18619C2A0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles NBDBCPOMLLA, float GOIIAEJMMIG, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x619BF40", Offset = "0x619A940", VA = "0x18619BF40")]
		public void SetDamageValue(float GOIIAEJMMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x619C420", Offset = "0x619AE20", VA = "0x18619C420")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DFPHIHOKAHD<T> : JMGBCNAMNAH<T>, BCACLFKFPHI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KPIBCDENEGP<T> : BCACLFKFPHI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KLNHBBPIAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DOAEIKDHJHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JFNFJMNKMDJ<T> : FPEMLHHDDKL<T>, DFPHIHOKAHD<T>, JMGBCNAMNAH<T>, BCACLFKFPHI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EAAGLJHGKAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JFNFJMNKMDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public EAAGLJHGKAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x31FCDC0", Offset = "0x31FB7C0", VA = "0x1831FCDC0")]
			internal void GOCEDAKMJLI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x223D900", Offset = "0x223C300", VA = "0x18223D900")]
			internal void GGEFPLMPLFI(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NGHKODLOGKF<T> FIPPBHGNAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool HPACMHLPDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CONPDDCOPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KJJCMGKHPAB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D430", Offset = "0x3A0BE30", VA = "0x183A0D430")]
		public JFNFJMNKMDJ(NGHKODLOGKF<T> FIPPBHGNAFL, ObjectPool HPACMHLPDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D2F0", Offset = "0x3A0BCF0", VA = "0x183A0D2F0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FKLLOGIMPBE<T> : LCADBCNGFBM, KPIBCDENEGP<T>, BCACLFKFPHI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class IHAPHGKBNPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FKLLOGIMPBE<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public IHAPHGKBNPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x37D8F60", Offset = "0x37D7960", VA = "0x1837D8F60")]
			internal void GOCEDAKMJLI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9986A0", Offset = "0x9970A0", VA = "0x1809986A0")]
			internal void GGEFPLMPLFI(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NGHKODLOGKF<T> FIPPBHGNAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KJJCMGKHPAB;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x35BC040", Offset = "0x35BAA40", VA = "0x1835BC040")]
		public FKLLOGIMPBE(NGHKODLOGKF<T> FIPPBHGNAFL, ObjectPool HPACMHLPDJG, int HAGJNBGJDIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35BBFE0", Offset = "0x35BA9E0", VA = "0x1835BBFE0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NIDJBEHKJKC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DOAEIKDHJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FPEMLHHDDKL<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NGHKODLOGKF<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public NIDJBEHKJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E34E70", Offset = "0x3E33870", VA = "0x183E34E70")]
		internal void OIBHBHBKCHF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E34DC0", Offset = "0x3E337C0", VA = "0x183E34DC0")]
		internal void EEJPLKCJKFN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E34E20", Offset = "0x3E33820", VA = "0x183E34E20")]
		internal void IMNAJIMPFIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<KLNHBBPIAIH> KBDLJMPIDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NEIHBCGEDLG GCFDIDJEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool HPACMHLPDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool KKBKKJBAIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x619A870", Offset = "0x6199270", VA = "0x18619A870")]
	private static void PJIHNCJKOKB(Component EGDKIFALJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x619AB40", Offset = "0x6199540", VA = "0x18619AB40")]
	public DOAEIKDHJHP(string BBEJDLOJLLM, int MEJIDMNLNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x253FF30", Offset = "0x253E930", VA = "0x18253FF30")]
	public DFPHIHOKAHD<T> FJPADMGMHOB<T>(AssetReference AAMKJFAGALA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x253FFD0", Offset = "0x253E9D0", VA = "0x18253FFD0")]
	public KPIBCDENEGP<T> PJCPIFGKLDD<T>(AssetReference AAMKJFAGALA, int DPBEIPGOMHN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x253FB30", Offset = "0x253E530", VA = "0x18253FB30")]
	public JMGBCNAMNAH<bool> EHGNOLKCNDM<T>(AssetReference AAMKJFAGALA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x619A4C0", Offset = "0x6198EC0", VA = "0x18619A4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x619A5B0", Offset = "0x6198FB0", VA = "0x18619A5B0")]
	private void FOMANNDJHDF(UnityEngine.Object PIOOCACHCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x619A6E0", Offset = "0x61990E0", VA = "0x18619A6E0")]
	private ObjectPool JFADPDKHCIP(string BBEJDLOJLLM)
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
		private static GlobalPool CELOHIPLBAC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject LDEIJLOHBAG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool MEGHANKAOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x619AF60", Offset = "0x6199960", VA = "0x18619AF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x269ABA0", Offset = "0x26995A0", VA = "0x18269ABA0")]
		public static void SafeRelease<T>(T MBCPMMHPENP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x619AE90", Offset = "0x6199890", VA = "0x18619AE90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x619AF50", Offset = "0x6199950", VA = "0x18619AF50")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ADAMBLLCEEG> FDMNJNANPIB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27F0890", Offset = "0x27EF290", VA = "0x1827F0890")]
		public T Acquire<T>(T NBDBCPOMLLA, [Optional] Action<Component> BIIFKDDDBJJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27F0AC0", Offset = "0x27EF4C0", VA = "0x1827F0AC0")]
		public bool Release<T>(T MBCPMMHPENP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27F0A70", Offset = "0x27EF470", VA = "0x1827F0A70")]
		public void Prefill<T>(T NBDBCPOMLLA, int NOFFIIJIEEA, [Optional] Action<Component> EHBGGMBADCH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x27F09D0", Offset = "0x27EF3D0", VA = "0x1827F09D0")]
		public bool Exists<T>(T NBDBCPOMLLA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27F0920", Offset = "0x27EF320", VA = "0x1827F0920")]
		public void Clear<T>(T NBDBCPOMLLA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x619BAE0", Offset = "0x619A4E0", VA = "0x18619BAE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27F0750", Offset = "0x27EF150", VA = "0x1827F0750")]
		private ADAMBLLCEEG AEKBHFMACGI<T>(T NBDBCPOMLLA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		public void TrackInstantiation(string EPCNOHPJEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		public void EnableStats(bool IFLEBFFLFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x619BC50", Offset = "0x619A650", VA = "0x18619BC50")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ADAMBLLCEEG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MBHJIOEDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MGIHFJIPHFP(bool KJBMNCKNIIK);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int KPEPOJBCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void PJCPIFGKLDD(int DPBEIPGOMHN, Action<Component> EHBGGMBADCH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component FJPADMGMHOB(Action<Component> BIIFKDDDBJJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool FLLAKBFBGHI(Component HBOAILJIBKK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NJLBNDAIMDB();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x619A150", Offset = "0x6198B50", VA = "0x18619A150")]
	protected void PANPLAMLDJE(Component MBCPMMHPENP, bool KJBMNCKNIIK, bool AIFNNAJGHGK, bool DMNCACDBEFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6199ED0", Offset = "0x61988D0", VA = "0x186199ED0")]
	protected void GDAFHLDCBCB(Transform IOFLNHMAMLN, bool KJBMNCKNIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected ADAMBLLCEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PGNBKNADEPJ<T> : ADAMBLLCEEG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T NBDBCPOMLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FPACBHGBMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool AIFNNAJGHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> GIEAGIDENDO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCF50", Offset = "0x3FDB950", VA = "0x183FDCF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int KPEPOJBCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCF70", Offset = "0x3FDB970", VA = "0x183FDCF70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD2A0", Offset = "0x3FDBCA0", VA = "0x183FDD2A0")]
	public PGNBKNADEPJ(T NBDBCPOMLLA, ObjectPool FPACBHGBMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD190", Offset = "0x3FDBB90", VA = "0x183FDD190", Slot = "6")]
	public override void PJCPIFGKLDD(int DPBEIPGOMHN, Action<Component> BIIFKDDDBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC9D0", Offset = "0x3FDB3D0", VA = "0x183FDC9D0", Slot = "7")]
	public override Component FJPADMGMHOB(Action<Component> BIIFKDDDBJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3FDCC40", Offset = "0x3FDB640", VA = "0x183FDCC40", Slot = "8")]
	public override bool FLLAKBFBGHI(Component HBOAILJIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDCFB0", Offset = "0x3FDB9B0", VA = "0x183FDCFB0", Slot = "9")]
	public override void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FDCDE0", Offset = "0x3FDB7E0", VA = "0x183FDCDE0")]
	private T JPAKEPPFPJD()
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
		public interface MNMNFFHOLFG
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject PIBOJLJDFIJ
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
		[Cpp2IlInjected.Address(RVA = "0x619B760", Offset = "0x619A160", VA = "0x18619B760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x619BA50", Offset = "0x619A450", VA = "0x18619BA50")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CELOHIPLBAC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject LDEIJLOHBAG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool MEGHANKAOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x619BDA0", Offset = "0x619A7A0", VA = "0x18619BDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x619BCE0", Offset = "0x619A6E0", VA = "0x18619BCE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x619AF50", Offset = "0x6199950", VA = "0x18619AF50")]
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
		public ADAMBLLCEEG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FCNIKMEPDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ECBHHNPMDAN(PooledParticle.IDAIPKOLAGJ OGLPHFKFGKE);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JCFDFDGACHP
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
		public enum IDAIPKOLAGJ
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
		public interface EOFDFLCBPAN
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool KIDAAGIEGHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 PEPACLEEGDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera NPGAPNFMCDI
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
			[Cpp2IlInjected.Address(RVA = "0x5218630", Offset = "0x5217030", VA = "0x185218630")]
			public ColorConfiguration(ParticleSystem EJAPBHJBKBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x619A2D0", Offset = "0x6198CD0", VA = "0x18619A2D0")]
			public void AENPOKNIIBO(Color IKNGOAKEJAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IMLKIKKILGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public IMLKIKKILGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x619B0D0", Offset = "0x6199AD0", VA = "0x18619B0D0")]
			internal void AINAEGIMLJL(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MLHCNCKHDPP : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private EOFDFLCBPAN <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public MLHCNCKHDPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x619B100", Offset = "0x6199B00", VA = "0x18619B100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x619B710", Offset = "0x619A110", VA = "0x18619B710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GGNFPEONFNI : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public GGNFPEONFNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x619ADD0", Offset = "0x61997D0", VA = "0x18619ADD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x619AE40", Offset = "0x6199840", VA = "0x18619AE40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FOCDANNENBE;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<FCNIKMEPDMO> NPEJNBOMJMO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> PEIAFKEIIGC;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static DHBMNMGGJAH AKDEDAIPLGB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float OCPCDOHFNBM = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool ACLFNGKBIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int LDAGNKNGJHB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private IDAIPKOLAGJ category;

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
		private ParticleSystem.MinMaxGradient[] GHBJKHPIBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool ODKAEJGMKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float JEJANCGDEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float LHLOIGNJKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JDNCPKGONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 CAMNNIFOIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 PELHFIAOJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JCFDFDGACHP NFIDKMIDPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private DHBMNMGGJAH EOHPPNNCKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool DBEPDAMIBKL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> JOCINAAKHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x619FC70", Offset = "0x619E670", VA = "0x18619FC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IDAIPKOLAGJ MCLDOOBFHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7CF6D0", Offset = "0x7CE0D0", VA = "0x1807CF6D0")]
			get
			{
				return default(IDAIPKOLAGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DLIKALFPCGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DGMFHIGLCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x619F9A0", Offset = "0x619E3A0", VA = "0x18619F9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int FOKHPHKCBJL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x619FB20", Offset = "0x619E520", VA = "0x18619FB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IIDEAFDOCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x619C790", Offset = "0x619B190", VA = "0x18619C790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem JNMHDAJDKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] DHACNNHLLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] HHNPJJIINOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7A9430", Offset = "0x7A7E30", VA = "0x1807A9430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JCFDFDGACHP OELFJILCNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDFCF40", Offset = "0xDFB940", VA = "0x180DFCF40")]
			get
			{
				return default(JCFDFDGACHP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x619CF30", Offset = "0x619B930", VA = "0x18619CF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FCHBIDKGFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x619F900", Offset = "0x619E300", VA = "0x18619F900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x619FCC0", Offset = "0x619E6C0", VA = "0x18619FCC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x619F290", Offset = "0x619DC90", VA = "0x18619F290")]
		public static PooledParticle TryPlayPrefab(PooledParticle NBDBCPOMLLA, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x619F400", Offset = "0x619DE00", VA = "0x18619F400")]
		public static PooledParticle TryPlayPrefab(PooledParticle NBDBCPOMLLA, Vector3 HGKJDOIPDNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x619E940", Offset = "0x619D340", VA = "0x18619E940")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x619D240", Offset = "0x619BC40", VA = "0x18619D240")]
		private void LAOCHKJIHDE(bool MDFPOPFCPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x619C730", Offset = "0x619B130", VA = "0x18619C730")]
		[IteratorStateMachine(typeof(MLHCNCKHDPP))]
		private static IEnumerator<FLFEOAPLLLI> BBLICICOIOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x619DA80", Offset = "0x619C480", VA = "0x18619DA80")]
		private static void PBAIPOGLDCL(Stopwatch CBPCKBLKEKD, Vector3 DIJOAPBILDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x619D610", Offset = "0x619C010", VA = "0x18619D610")]
		private static int MLMHMNLPAIN(PooledParticle CGDDINAJAOB, PooledParticle GIFBDNCPDKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x619C810", Offset = "0x619B210", VA = "0x18619C810")]
		private static int ECBHHNPMDAN(IDAIPKOLAGJ OGLPHFKFGKE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x619D800", Offset = "0x619C200", VA = "0x18619D800")]
		protected void OLBMBKAKALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x619C920", Offset = "0x619B320", VA = "0x18619C920")]
		protected void EGHOAOODNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x619C500", Offset = "0x619AF00", VA = "0x18619C500", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x619D3A0", Offset = "0x619BDA0", VA = "0x18619D3A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x619DA00", Offset = "0x619C400", VA = "0x18619DA00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x619D310", Offset = "0x619BD10", VA = "0x18619D310")]
		[IteratorStateMachine(typeof(GGNFPEONFNI))]
		private IEnumerator<FLFEOAPLLLI> LMAINEENFAM(float DAMPBKHPLCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x619CF50", Offset = "0x619B950", VA = "0x18619CF50")]
		private void FLLAKBFBGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x619F0A0", Offset = "0x619DAA0", VA = "0x18619F0A0")]
		public void SetDuration(float DAMPBKHPLCH, bool HGMLHOPFAGG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x619DF00", Offset = "0x619C900", VA = "0x18619DF00")]
		public void Play(Transform BNFJPCKKDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x619E5B0", Offset = "0x619CFB0", VA = "0x18619E5B0")]
		public void Play(Transform BNFJPCKKDAC, bool GGDFBAONOEE, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x619E060", Offset = "0x619CA60", VA = "0x18619E060")]
		public void Play(Transform BNFJPCKKDAC, Vector3 PELHFIAOJGI, bool GGDFBAONOEE, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x619E1B0", Offset = "0x619CBB0", VA = "0x18619E1B0")]
		public void Play(Transform KBALGNDPPIC, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x619E720", Offset = "0x619D120", VA = "0x18619E720")]
		public void Play(Transform KBALGNDPPIC, Vector3 PELHFIAOJGI, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x619E3D0", Offset = "0x619CDD0", VA = "0x18619E3D0")]
		public void Play(Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, Vector3 HLPPLJDPLMM, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x619E310", Offset = "0x619CD10", VA = "0x18619E310")]
		public void Play(Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x619E4A0", Offset = "0x619CEA0", VA = "0x18619E4A0")]
		public void Play(bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x619F200", Offset = "0x619DC00", VA = "0x18619F200")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x619F170", Offset = "0x619DB70", VA = "0x18619F170")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x619D0B0", Offset = "0x619BAB0", VA = "0x18619D0B0")]
		private void KFNIKAIFMOA(float DAMPBKHPLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x619D6C0", Offset = "0x619C0C0", VA = "0x18619D6C0")]
		private void OALPBDEPDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x619E850", Offset = "0x619D250", VA = "0x18619E850")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x619EAC0", Offset = "0x619D4C0", VA = "0x18619EAC0")]
		public void SetColor(Color IKNGOAKEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x619DDD0", Offset = "0x619C7D0", VA = "0x18619DDD0")]
		private void PCADJDLNDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x619F870", Offset = "0x619E270", VA = "0x18619F870")]
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
