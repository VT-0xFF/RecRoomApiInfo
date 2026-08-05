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
		[Cpp2IlInjected.Address(RVA = "0x61220E0", Offset = "0x61214E0", VA = "0x1861220E0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles NBDBCPOMLLA, float GOIIAEJMMIG, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6121D80", Offset = "0x6121180", VA = "0x186121D80")]
		public void SetDamageValue(float GOIIAEJMMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6122260", Offset = "0x6121660", VA = "0x186122260")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public EAAGLJHGKAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x31CD560", Offset = "0x31CC960", VA = "0x1831CD560")]
			internal void GOCEDAKMJLI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x221A2A0", Offset = "0x22196A0", VA = "0x18221A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x39C45D0", Offset = "0x39C39D0", VA = "0x1839C45D0")]
		public JFNFJMNKMDJ(NGHKODLOGKF<T> FIPPBHGNAFL, ObjectPool HPACMHLPDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39C4490", Offset = "0x39C3890", VA = "0x1839C4490", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public IHAPHGKBNPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x379FC70", Offset = "0x379F070", VA = "0x18379FC70")]
			internal void GOCEDAKMJLI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x98CFE0", Offset = "0x98C3E0", VA = "0x18098CFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x358F2C0", Offset = "0x358E6C0", VA = "0x18358F2C0")]
		public FKLLOGIMPBE(NGHKODLOGKF<T> FIPPBHGNAFL, ObjectPool HPACMHLPDJG, int HAGJNBGJDIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x358F260", Offset = "0x358E660", VA = "0x18358F260", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NIDJBEHKJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE970", Offset = "0x3DFDD70", VA = "0x183DFE970")]
		internal void OIBHBHBKCHF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE8C0", Offset = "0x3DFDCC0", VA = "0x183DFE8C0")]
		internal void EEJPLKCJKFN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE920", Offset = "0x3DFDD20", VA = "0x183DFE920")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61206B0", Offset = "0x611FAB0", VA = "0x1861206B0")]
	private static void PJIHNCJKOKB(Component EGDKIFALJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6120980", Offset = "0x611FD80", VA = "0x186120980")]
	public DOAEIKDHJHP(string BBEJDLOJLLM, int MEJIDMNLNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24EDFA0", Offset = "0x24ED3A0", VA = "0x1824EDFA0")]
	public DFPHIHOKAHD<T> FJPADMGMHOB<T>(AssetReference AAMKJFAGALA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24EE040", Offset = "0x24ED440", VA = "0x1824EE040")]
	public KPIBCDENEGP<T> PJCPIFGKLDD<T>(AssetReference AAMKJFAGALA, int DPBEIPGOMHN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24EDBA0", Offset = "0x24ECFA0", VA = "0x1824EDBA0")]
	public JMGBCNAMNAH<bool> EHGNOLKCNDM<T>(AssetReference AAMKJFAGALA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6120300", Offset = "0x611F700", VA = "0x186120300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61203F0", Offset = "0x611F7F0", VA = "0x1861203F0")]
	private void FOMANNDJHDF(UnityEngine.Object PIOOCACHCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6120520", Offset = "0x611F920", VA = "0x186120520")]
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
			[Cpp2IlInjected.Address(RVA = "0x6120DA0", Offset = "0x61201A0", VA = "0x186120DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26457B0", Offset = "0x2644BB0", VA = "0x1826457B0")]
		public static void SafeRelease<T>(T MBCPMMHPENP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6120CD0", Offset = "0x61200D0", VA = "0x186120CD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6120D90", Offset = "0x6120190", VA = "0x186120D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x279A860", Offset = "0x2799C60", VA = "0x18279A860")]
		public T Acquire<T>(T NBDBCPOMLLA, [Optional] Action<Component> BIIFKDDDBJJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x279AA90", Offset = "0x2799E90", VA = "0x18279AA90")]
		public bool Release<T>(T MBCPMMHPENP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x279AA40", Offset = "0x2799E40", VA = "0x18279AA40")]
		public void Prefill<T>(T NBDBCPOMLLA, int NOFFIIJIEEA, [Optional] Action<Component> EHBGGMBADCH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x279A9A0", Offset = "0x2799DA0", VA = "0x18279A9A0")]
		public bool Exists<T>(T NBDBCPOMLLA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x279A8F0", Offset = "0x2799CF0", VA = "0x18279A8F0")]
		public void Clear<T>(T NBDBCPOMLLA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6121920", Offset = "0x6120D20", VA = "0x186121920")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x279A720", Offset = "0x2799B20", VA = "0x18279A720")]
		private ADAMBLLCEEG AEKBHFMACGI<T>(T NBDBCPOMLLA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		public void TrackInstantiation(string EPCNOHPJEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		public void EnableStats(bool IFLEBFFLFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6121A90", Offset = "0x6120E90", VA = "0x186121A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x611FF90", Offset = "0x611F390", VA = "0x18611FF90")]
	protected void PANPLAMLDJE(Component MBCPMMHPENP, bool KJBMNCKNIIK, bool AIFNNAJGHGK, bool DMNCACDBEFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x611FD10", Offset = "0x611F110", VA = "0x18611FD10")]
	protected void GDAFHLDCBCB(Transform IOFLNHMAMLN, bool KJBMNCKNIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA5F80", Offset = "0x3FA5380", VA = "0x183FA5F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int KPEPOJBCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5FA0", Offset = "0x3FA53A0", VA = "0x183FA5FA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3FA62D0", Offset = "0x3FA56D0", VA = "0x183FA62D0")]
	public PGNBKNADEPJ(T NBDBCPOMLLA, ObjectPool FPACBHGBMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3FA61C0", Offset = "0x3FA55C0", VA = "0x183FA61C0", Slot = "6")]
	public override void PJCPIFGKLDD(int DPBEIPGOMHN, Action<Component> BIIFKDDDBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5A00", Offset = "0x3FA4E00", VA = "0x183FA5A00", Slot = "7")]
	public override Component FJPADMGMHOB(Action<Component> BIIFKDDDBJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5C70", Offset = "0x3FA5070", VA = "0x183FA5C70", Slot = "8")]
	public override bool FLLAKBFBGHI(Component HBOAILJIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5FE0", Offset = "0x3FA53E0", VA = "0x183FA5FE0", Slot = "9")]
	public override void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5E10", Offset = "0x3FA5210", VA = "0x183FA5E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x61215A0", Offset = "0x61209A0", VA = "0x1861215A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6121890", Offset = "0x6120C90", VA = "0x186121890")]
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
			[Cpp2IlInjected.Address(RVA = "0x6121BE0", Offset = "0x6120FE0", VA = "0x186121BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6121B20", Offset = "0x6120F20", VA = "0x186121B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6120D90", Offset = "0x6120190", VA = "0x186120D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
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
			[Cpp2IlInjected.Address(RVA = "0x51B05C0", Offset = "0x51AF9C0", VA = "0x1851B05C0")]
			public ColorConfiguration(ParticleSystem EJAPBHJBKBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6120110", Offset = "0x611F510", VA = "0x186120110")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public IMLKIKKILGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6120F10", Offset = "0x6120310", VA = "0x186120F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
			[DebuggerHidden]
			public MLHCNCKHDPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6120F40", Offset = "0x6120340", VA = "0x186120F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6121550", Offset = "0x6120950", VA = "0x186121550", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
			[DebuggerHidden]
			public GGNFPEONFNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6120C10", Offset = "0x6120010", VA = "0x186120C10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6120C80", Offset = "0x6120080", VA = "0x186120C80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6125AB0", Offset = "0x6124EB0", VA = "0x186125AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IDAIPKOLAGJ MCLDOOBFHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C56D0", Offset = "0x7C4AD0", VA = "0x1807C56D0")]
			get
			{
				return default(IDAIPKOLAGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DLIKALFPCGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DGMFHIGLCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61257E0", Offset = "0x6124BE0", VA = "0x1861257E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int FOKHPHKCBJL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6125960", Offset = "0x6124D60", VA = "0x186125960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IIDEAFDOCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61225D0", Offset = "0x61219D0", VA = "0x1861225D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem JNMHDAJDKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] DHACNNHLLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] HHNPJJIINOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x79F430", Offset = "0x79E830", VA = "0x18079F430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private JCFDFDGACHP OELFJILCNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDECF80", Offset = "0xDEC380", VA = "0x180DECF80")]
			get
			{
				return default(JCFDFDGACHP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6122D70", Offset = "0x6122170", VA = "0x186122D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FCHBIDKGFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6125740", Offset = "0x6124B40", VA = "0x186125740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6125B00", Offset = "0x6124F00", VA = "0x186125B00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61250D0", Offset = "0x61244D0", VA = "0x1861250D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle NBDBCPOMLLA, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6125240", Offset = "0x6124640", VA = "0x186125240")]
		public static PooledParticle TryPlayPrefab(PooledParticle NBDBCPOMLLA, Vector3 HGKJDOIPDNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6124780", Offset = "0x6123B80", VA = "0x186124780")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6123080", Offset = "0x6122480", VA = "0x186123080")]
		private void LAOCHKJIHDE(bool MDFPOPFCPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6122570", Offset = "0x6121970", VA = "0x186122570")]
		[IteratorStateMachine(typeof(MLHCNCKHDPP))]
		private static IEnumerator<FLFEOAPLLLI> BBLICICOIOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x61238C0", Offset = "0x6122CC0", VA = "0x1861238C0")]
		private static void PBAIPOGLDCL(Stopwatch CBPCKBLKEKD, Vector3 DIJOAPBILDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6123450", Offset = "0x6122850", VA = "0x186123450")]
		private static int MLMHMNLPAIN(PooledParticle CGDDINAJAOB, PooledParticle GIFBDNCPDKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6122650", Offset = "0x6121A50", VA = "0x186122650")]
		private static int ECBHHNPMDAN(IDAIPKOLAGJ OGLPHFKFGKE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6123640", Offset = "0x6122A40", VA = "0x186123640")]
		protected void OLBMBKAKALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6122760", Offset = "0x6121B60", VA = "0x186122760")]
		protected void EGHOAOODNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6122340", Offset = "0x6121740", VA = "0x186122340", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61231E0", Offset = "0x61225E0", VA = "0x1861231E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6123840", Offset = "0x6122C40", VA = "0x186123840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6123150", Offset = "0x6122550", VA = "0x186123150")]
		[IteratorStateMachine(typeof(GGNFPEONFNI))]
		private IEnumerator<FLFEOAPLLLI> LMAINEENFAM(float DAMPBKHPLCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6122D90", Offset = "0x6122190", VA = "0x186122D90")]
		private void FLLAKBFBGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6124EE0", Offset = "0x61242E0", VA = "0x186124EE0")]
		public void SetDuration(float DAMPBKHPLCH, bool HGMLHOPFAGG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6123D40", Offset = "0x6123140", VA = "0x186123D40")]
		public void Play(Transform BNFJPCKKDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x61243F0", Offset = "0x61237F0", VA = "0x1861243F0")]
		public void Play(Transform BNFJPCKKDAC, bool GGDFBAONOEE, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6123EA0", Offset = "0x61232A0", VA = "0x186123EA0")]
		public void Play(Transform BNFJPCKKDAC, Vector3 PELHFIAOJGI, bool GGDFBAONOEE, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6123FF0", Offset = "0x61233F0", VA = "0x186123FF0")]
		public void Play(Transform KBALGNDPPIC, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6124560", Offset = "0x6123960", VA = "0x186124560")]
		public void Play(Transform KBALGNDPPIC, Vector3 PELHFIAOJGI, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6124210", Offset = "0x6123610", VA = "0x186124210")]
		public void Play(Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, Vector3 HLPPLJDPLMM, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6124150", Offset = "0x6123550", VA = "0x186124150")]
		public void Play(Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61242E0", Offset = "0x61236E0", VA = "0x1861242E0")]
		public void Play(bool GGDFBAONOEE = false, float GFGLCBIOFDE = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6125040", Offset = "0x6124440", VA = "0x186125040")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6124FB0", Offset = "0x61243B0", VA = "0x186124FB0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6122EF0", Offset = "0x61222F0", VA = "0x186122EF0")]
		private void KFNIKAIFMOA(float DAMPBKHPLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6123500", Offset = "0x6122900", VA = "0x186123500")]
		private void OALPBDEPDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6124690", Offset = "0x6123A90", VA = "0x186124690")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6124900", Offset = "0x6123D00", VA = "0x186124900")]
		public void SetColor(Color IKNGOAKEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6123C10", Offset = "0x6123010", VA = "0x186123C10")]
		private void PCADJDLNDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61256B0", Offset = "0x6124AB0", VA = "0x1861256B0")]
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
