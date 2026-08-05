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
		[Cpp2IlInjected.Address(RVA = "0x63FBB90", Offset = "0x63FAD90", VA = "0x1863FBB90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ICCEKMKAHCK, float NIJGJMMHEHP, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63FB830", Offset = "0x63FAA30", VA = "0x1863FB830")]
		public void SetDamageValue(float NIJGJMMHEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x63FBD10", Offset = "0x63FAF10", VA = "0x1863FBD10")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IPLALNAAMFG<T> : JGFOKFMCODN<T>, OFPHFCMJPLJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CPFEHMLOACI<T> : OFPHFCMJPLJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JAAEABGPMNM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KPDHBPAPNIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DBBEGBDMILM<T> : NHDHJDKFKLE<T>, IPLALNAAMFG<T>, JGFOKFMCODN<T>, OFPHFCMJPLJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CJEDDAHJBEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public DBBEGBDMILM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public CJEDDAHJBEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4C37C80", Offset = "0x4C36E80", VA = "0x184C37C80")]
			internal void FNOIMPLHEIM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2577B10", Offset = "0x2576D10", VA = "0x182577B10")]
			internal void AGKNEAELMCN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IKCNFNMPLNN<T> EJEKBNDFLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool FCMCILHNEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T JHPIMPOFIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool OEJOJKGONDA;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x50FCC80", Offset = "0x50FBE80", VA = "0x1850FCC80")]
		public DBBEGBDMILM(IKCNFNMPLNN<T> EJEKBNDFLLD, ObjectPool FCMCILHNEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50FCB40", Offset = "0x50FBD40", VA = "0x1850FCB40", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GOLKMJGGAFN<T> : ACJIGECFCHH, CPFEHMLOACI<T>, OFPHFCMJPLJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MMFFGMNMNEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GOLKMJGGAFN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public MMFFGMNMNEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3F975B0", Offset = "0x3F967B0", VA = "0x183F975B0")]
			internal void FNOIMPLHEIM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA349A0", Offset = "0xA33BA0", VA = "0x180A349A0")]
			internal void AGKNEAELMCN(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IKCNFNMPLNN<T> EJEKBNDFLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool OEJOJKGONDA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x38C9240", Offset = "0x38C8440", VA = "0x1838C9240")]
		public GOLKMJGGAFN(IKCNFNMPLNN<T> EJEKBNDFLLD, ObjectPool FCMCILHNEGL, int EOAGPHAAKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38C91E0", Offset = "0x38C83E0", VA = "0x1838C91E0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AKLDNDNJGCD<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KPDHBPAPNIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NHDHJDKFKLE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IKCNFNMPLNN<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AKLDNDNJGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EEA0", Offset = "0x3A0E0A0", VA = "0x183A0EEA0")]
		internal void KFADAGMIGGL(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EF40", Offset = "0x3A0E140", VA = "0x183A0EF40")]
		internal void MCPJNOFOLMD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EE50", Offset = "0x3A0E050", VA = "0x183A0EE50")]
		internal void GBJBKNNDECA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JAAEABGPMNM> ADJFCCBOFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LGMLJGJELKJ MDFIALDJCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool FCMCILHNEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OEJOJKGONDA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool NPHJKLFBEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63FA290", Offset = "0x63F9490", VA = "0x1863FA290")]
	private static void FGHIEGAOLKD(Component EFNFBPDAPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63FA690", Offset = "0x63F9890", VA = "0x1863FA690")]
	public KPDHBPAPNIF(string PICCOCLNMEB, int PEKLAOHLAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x297EFA0", Offset = "0x297E1A0", VA = "0x18297EFA0")]
	public IPLALNAAMFG<T> NCBKMOIGMJN<T>(AssetReference DDDMABPOMGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x297E840", Offset = "0x297DA40", VA = "0x18297E840")]
	public CPFEHMLOACI<T> DGELLLLCACG<T>(AssetReference DDDMABPOMGE, int KIGJDGACGDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x297E8F0", Offset = "0x297DAF0", VA = "0x18297E8F0")]
	public JGFOKFMCODN<bool> FJFIJPOJCAC<T>(AssetReference DDDMABPOMGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63FA1A0", Offset = "0x63F93A0", VA = "0x1863FA1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63FA4D0", Offset = "0x63F96D0", VA = "0x1863FA4D0")]
	private void OCNJPCDEHMD(UnityEngine.Object HAMCKCEBJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63FA010", Offset = "0x63F9210", VA = "0x1863FA010")]
	private ObjectPool DNNBFPKHHOI(string PICCOCLNMEB)
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
		private static GlobalPool FCFONCKEJKH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject OPDLCFBGJBB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool KMGHIJMKCHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63F9EC0", Offset = "0x63F90C0", VA = "0x1863F9EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28FA100", Offset = "0x28F9300", VA = "0x1828FA100")]
		public static void SafeRelease<T>(T JFJMICPDNDH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63F9DF0", Offset = "0x63F8FF0", VA = "0x1863F9DF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63F9EB0", Offset = "0x63F90B0", VA = "0x1863F9EB0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, BAEFCAHAJFI> BDKNBDGCGBO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A50D50", Offset = "0x2A4FF50", VA = "0x182A50D50")]
		public T Acquire<T>(T ICCEKMKAHCK, [Optional] Action<Component> AEEGHKLBHMD) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A510C0", Offset = "0x2A502C0", VA = "0x182A510C0")]
		public bool Release<T>(T JFJMICPDNDH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A51070", Offset = "0x2A50270", VA = "0x182A51070")]
		public void Prefill<T>(T ICCEKMKAHCK, int AACEMJPONLL, [Optional] Action<Component> EKCELOFGOJI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A50E90", Offset = "0x2A50090", VA = "0x182A50E90")]
		public bool Exists<T>(T ICCEKMKAHCK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A50DE0", Offset = "0x2A4FFE0", VA = "0x182A50DE0")]
		public void Clear<T>(T ICCEKMKAHCK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63FAD90", Offset = "0x63F9F90", VA = "0x1863FAD90")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A50F30", Offset = "0x2A50130", VA = "0x182A50F30")]
		private BAEFCAHAJFI JMAELKEFKLL<T>(T ICCEKMKAHCK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public void TrackInstantiation(string LFDJAMHOBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public void EnableStats(bool ILJAOPIDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x63FAF00", Offset = "0x63FA100", VA = "0x1863FAF00")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class BAEFCAHAJFI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LAANGOGCHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NHAAMHDKCAD(bool IPJGMHONMIO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int LNNJNJDLJON
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void DGELLLLCACG(int KIGJDGACGDD, Action<Component> EKCELOFGOJI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component NCBKMOIGMJN(Action<Component> AEEGHKLBHMD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool EJBBKCPFFPM(Component IJGJBOIKBJJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NDGKPACNNFE();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63F9800", Offset = "0x63F8A00", VA = "0x1863F9800")]
	protected void ELMBJCLCCJL(Component JFJMICPDNDH, bool IPJGMHONMIO, bool CDPJGBCHKPL, bool DBMDILHMCPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63F9980", Offset = "0x63F8B80", VA = "0x1863F9980")]
	protected void MAPFLKDGEIF(Transform KLJHKELNFIJ, bool IPJGMHONMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected BAEFCAHAJFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FJMNFJLMFLF<T> : BAEFCAHAJFI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T ICCEKMKAHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool AHIKGKDECNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CDPJGBCHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DCCKJJOENJB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3806A40", Offset = "0x3805C40", VA = "0x183806A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int LNNJNJDLJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3806600", Offset = "0x3805800", VA = "0x183806600", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3806E90", Offset = "0x3806090", VA = "0x183806E90")]
	public FJMNFJLMFLF(T ICCEKMKAHCK, ObjectPool AHIKGKDECNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38067B0", Offset = "0x38059B0", VA = "0x1838067B0", Slot = "6")]
	public override void DGELLLLCACG(int KIGJDGACGDD, Action<Component> AEEGHKLBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3806A60", Offset = "0x3805C60", VA = "0x183806A60", Slot = "7")]
	public override Component NCBKMOIGMJN(Action<Component> AEEGHKLBHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38068B0", Offset = "0x3805AB0", VA = "0x1838068B0", Slot = "8")]
	public override bool EJBBKCPFFPM(Component IJGJBOIKBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3806CC0", Offset = "0x3805EC0", VA = "0x183806CC0", Slot = "9")]
	public override void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3806640", Offset = "0x3805840", VA = "0x183806640")]
	private T CBGIOHELGAI()
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
		public interface MABCCBPDKIG
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject LFKADLFMMKB
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
		[Cpp2IlInjected.Address(RVA = "0x63FAA10", Offset = "0x63F9C10", VA = "0x1863FAA10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63FAD00", Offset = "0x63F9F00", VA = "0x1863FAD00")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool FCFONCKEJKH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject OPDLCFBGJBB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool KMGHIJMKCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63FB6B0", Offset = "0x63FA8B0", VA = "0x1863FB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63FB5F0", Offset = "0x63FA7F0", VA = "0x1863FB5F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63F9EB0", Offset = "0x63F90B0", VA = "0x1863F9EB0")]
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
		public BAEFCAHAJFI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BDCLPIFINHO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CKHANNADCIB(PooledParticle.OENIGCLHLCH MAKBJPMDNMF);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum DIPABCMFHLA
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
		public enum OENIGCLHLCH
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
		public interface HKFMOGEOFCK
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool JAGGPBIONDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 NCBEDAEJLAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera GJDDGPLMBEK
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
			[Cpp2IlInjected.Address(RVA = "0x5419210", Offset = "0x5418410", VA = "0x185419210")]
			public ColorConfiguration(ParticleSystem FJPOMDHIPFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x63F9C00", Offset = "0x63F8E00", VA = "0x1863F9C00")]
			public void PHDGBCGLLAI(Color NHDAKDKKMHH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OLCNNJOHEED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public OLCNNJOHEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x63FA9E0", Offset = "0x63F9BE0", VA = "0x1863FA9E0")]
			internal void ACFKHLLJJGN(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PAMLOBGAIFJ : IEnumerator<JGIJKBAPGME>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private JGIJKBAPGME <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private HKFMOGEOFCK <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JGIJKBAPGME System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
			[DebuggerHidden]
			public PAMLOBGAIFJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63FAF90", Offset = "0x63FA190", VA = "0x1863FAF90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x63FB5A0", Offset = "0x63FA7A0", VA = "0x1863FB5A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NECJNLMPKID : IEnumerator<JGIJKBAPGME>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JGIJKBAPGME <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JGIJKBAPGME System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
			[DebuggerHidden]
			public NECJNLMPKID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA920", Offset = "0x63F9B20", VA = "0x1863FA920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x63FA990", Offset = "0x63F9B90", VA = "0x1863FA990", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> ODFEIFHMANG;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<BDCLPIFINHO> DMGCLAMFPCF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> GNEOKECPJPD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static HDONKFMMCKJ HMJFLDJCIGH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float BPCNCCDJIII = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool ENNEHCPHCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int ILAHCLKBBFJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private OENIGCLHLCH category;

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
		private ParticleSystem.MinMaxGradient[] DAPFOCENBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool HOMJGAOGKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float NLKMHMHFNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float LKHFGDKBDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform MNPPAAJCFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 PEIMAJNAHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 HEHBMCOPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private DIPABCMFHLA IHICMPDBDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private HDONKFMMCKJ CNPBJGIAHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool CODCKICGKLJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> NEIGFIEPOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63FF4B0", Offset = "0x63FE6B0", VA = "0x1863FF4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OENIGCLHLCH ENMJLFFMMCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7DCE60", Offset = "0x7DC060", VA = "0x1807DCE60")]
			get
			{
				return default(OENIGCLHLCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HMJJFOKMFMA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool JDLAAFJNJPK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63FF1F0", Offset = "0x63FE3F0", VA = "0x1863FF1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int KDCJOIANEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63FF360", Offset = "0x63FE560", VA = "0x1863FF360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool EFODNFBBBPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63FC470", Offset = "0x63FB670", VA = "0x1863FC470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem CPHMFJBDNFP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] NJHONKOACBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] CHEHNKGKGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DIPABCMFHLA FNGOCAHOHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xEB46B0", Offset = "0xEB38B0", VA = "0x180EB46B0")]
			get
			{
				return default(DIPABCMFHLA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63FC110", Offset = "0x63FB310", VA = "0x1863FC110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PODFHJCHNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63FF150", Offset = "0x63FE350", VA = "0x1863FF150")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63FF500", Offset = "0x63FE700", VA = "0x1863FF500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63FEB10", Offset = "0x63FDD10", VA = "0x1863FEB10")]
		public static PooledParticle TryPlayPrefab(PooledParticle ICCEKMKAHCK, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63FEC80", Offset = "0x63FDE80", VA = "0x1863FEC80")]
		public static PooledParticle TryPlayPrefab(PooledParticle ICCEKMKAHCK, Vector3 DHMMMGDKPCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63FE1C0", Offset = "0x63FD3C0", VA = "0x1863FE1C0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63FC700", Offset = "0x63FB900", VA = "0x1863FC700")]
		private void GCKBACLLCIJ(bool COENLOODJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63FC7D0", Offset = "0x63FB9D0", VA = "0x1863FC7D0")]
		[IteratorStateMachine(typeof(PAMLOBGAIFJ))]
		private static IEnumerator<JGIJKBAPGME> HLNIGINNKGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63FC130", Offset = "0x63FB330", VA = "0x1863FC130")]
		private static void EECOEOKNMDP(Stopwatch NEKANGAICOD, Vector3 FKGDMNPLMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63FC650", Offset = "0x63FB850", VA = "0x1863FC650")]
		private static int FBHBJPGOICL(PooledParticle EFLJLNCMHDD, PooledParticle DJDKOLONKNI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63FC000", Offset = "0x63FB200", VA = "0x1863FC000")]
		private static int CKHANNADCIB(OENIGCLHLCH MAKBJPMDNMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63FCFB0", Offset = "0x63FC1B0", VA = "0x1863FCFB0")]
		protected void PGKNMKALCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63FD1A0", Offset = "0x63FC3A0", VA = "0x1863FD1A0")]
		protected void PKMAKEEBBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63FBDE0", Offset = "0x63FAFE0", VA = "0x1863FBDE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63FC970", Offset = "0x63FBB70", VA = "0x1863FC970")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63FCEA0", Offset = "0x63FC0A0", VA = "0x1863FCEA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63FCF20", Offset = "0x63FC120", VA = "0x1863FCF20")]
		[IteratorStateMachine(typeof(NECJNLMPKID))]
		private IEnumerator<JGIJKBAPGME> PGIGIHEODAL(float EFGIMEOKMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63FC4F0", Offset = "0x63FB6F0", VA = "0x1863FC4F0")]
		private void EJBBKCPFFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63FE920", Offset = "0x63FDB20", VA = "0x1863FE920")]
		public void SetDuration(float EFGIMEOKMHC, bool JLDIOPOOPFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x63FD780", Offset = "0x63FC980", VA = "0x1863FD780")]
		public void Play(Transform OKMJJBKMEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x63FDE30", Offset = "0x63FD030", VA = "0x1863FDE30")]
		public void Play(Transform OKMJJBKMEJE, bool EDOCFICFFIG, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63FD8E0", Offset = "0x63FCAE0", VA = "0x1863FD8E0")]
		public void Play(Transform OKMJJBKMEJE, Vector3 HEHBMCOPEIK, bool EDOCFICFFIG, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63FDA30", Offset = "0x63FCC30", VA = "0x1863FDA30")]
		public void Play(Transform AAMCGNEKLIG, Quaternion HBCECKEGCGH, bool EDOCFICFFIG = false, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63FDFA0", Offset = "0x63FD1A0", VA = "0x1863FDFA0")]
		public void Play(Transform AAMCGNEKLIG, Vector3 HEHBMCOPEIK, Quaternion HBCECKEGCGH, bool EDOCFICFFIG = false, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63FDC50", Offset = "0x63FCE50", VA = "0x1863FDC50")]
		public void Play(Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, Vector3 JPMMLNGJNDB, bool EDOCFICFFIG = false, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63FDB90", Offset = "0x63FCD90", VA = "0x1863FDB90")]
		public void Play(Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, bool EDOCFICFFIG = false, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63FDD20", Offset = "0x63FCF20", VA = "0x1863FDD20")]
		public void Play(bool EDOCFICFFIG = false, float ANAHMMAPDCP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63FEA80", Offset = "0x63FDC80", VA = "0x1863FEA80")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63FE9F0", Offset = "0x63FDBF0", VA = "0x1863FE9F0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63FCBE0", Offset = "0x63FBDE0", VA = "0x1863FCBE0")]
		private void NBJIGHCAAMC(float EFGIMEOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63FC830", Offset = "0x63FBA30", VA = "0x1863FC830")]
		private void JFKMHFDLFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63FE0D0", Offset = "0x63FD2D0", VA = "0x1863FE0D0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63FE340", Offset = "0x63FD540", VA = "0x1863FE340")]
		public void SetColor(Color NHDAKDKKMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63FCD70", Offset = "0x63FBF70", VA = "0x1863FCD70")]
		private void OCEKEOCNEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63FF0C0", Offset = "0x63FE2C0", VA = "0x1863FF0C0")]
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
