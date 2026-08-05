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
		[Cpp2IlInjected.Address(RVA = "0x6BE8960", Offset = "0x6BE7960", VA = "0x186BE8960")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FIFJHOIIJHB, float IHJMBBDBPAJ, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8600", Offset = "0x6BE7600", VA = "0x186BE8600")]
		public void SetDamageValue(float IHJMBBDBPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8AE0", Offset = "0x6BE7AE0", VA = "0x186BE8AE0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AACKMBGKAKP<T> : HCGNNEJAOHI<T>, PGILFKJEHOF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EIFAEGAAECD<T> : PGILFKJEHOF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IOJBHJCAOBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BEEMNGGBLAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NKLFKNCOAPB<T> : EJMFGCNAEMH<T>, AACKMBGKAKP<T>, HCGNNEJAOHI<T>, PGILFKJEHOF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JIDGHFBOPKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NKLFKNCOAPB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JIDGHFBOPKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x40A3180", Offset = "0x40A2180", VA = "0x1840A3180")]
			internal void KHJIJLCBBPO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x274BB40", Offset = "0x274AB40", VA = "0x18274BB40")]
			internal void HBAJDHGENCM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FMHOFFFMGIN<T> LODCMGMFIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GGAGHMELKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MGNNEDNHDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MMNAIEEGDFD;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4595BE0", Offset = "0x4594BE0", VA = "0x184595BE0")]
		public NKLFKNCOAPB(FMHOFFFMGIN<T> LODCMGMFIFJ, ObjectPool GGAGHMELKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4595A00", Offset = "0x4594A00", VA = "0x184595A00", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LJGDJDEDJDI<T> : NIIIJMDBGHD, EIFAEGAAECD<T>, PGILFKJEHOF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LBBOCAFCBCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LJGDJDEDJDI<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public LBBOCAFCBCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x42C09E0", Offset = "0x42BF9E0", VA = "0x1842C09E0")]
			internal void KHJIJLCBBPO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xBB6480", Offset = "0xBB5480", VA = "0x180BB6480")]
			internal void HBAJDHGENCM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FMHOFFFMGIN<T> LODCMGMFIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MMNAIEEGDFD;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x42E6F70", Offset = "0x42E5F70", VA = "0x1842E6F70")]
		public LJGDJDEDJDI(FMHOFFFMGIN<T> LODCMGMFIFJ, ObjectPool GGAGHMELKCE, int OIIHOAGFLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x42E6F10", Offset = "0x42E5F10", VA = "0x1842E6F10", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HDBECNBGKPA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BEEMNGGBLAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EJMFGCNAEMH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FMHOFFFMGIN<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public HDBECNBGKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC76A0", Offset = "0x3DC66A0", VA = "0x183DC76A0")]
		internal void PECHMDICHMD(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC75F0", Offset = "0x3DC65F0", VA = "0x183DC75F0")]
		internal void BGLLBGDMMPL(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7650", Offset = "0x3DC6650", VA = "0x183DC7650")]
		internal void FCNPPMJAGAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<IOJBHJCAOBO> IAIEINAPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LDMAEHCJBEA CANBMLIGBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GGAGHMELKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool CJOADCBBDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6810", Offset = "0x6BE5810", VA = "0x186BE6810")]
	private static void OKLAHGMECLP(Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6C10", Offset = "0x6BE5C10", VA = "0x186BE6C10")]
	public BEEMNGGBLAC(string KJABOHKGPKO, int KJJMEDNKCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28C0150", Offset = "0x28BF150", VA = "0x1828C0150")]
	public AACKMBGKAKP<T> EBAPBDCJHHO<T>(AssetReference BEMEGNHIOOO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28C06B0", Offset = "0x28BF6B0", VA = "0x1828C06B0")]
	public EIFAEGAAECD<T> KKGLOBOENAP<T>(AssetReference BEMEGNHIOOO, int JPBPNOCHNLG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28C0220", Offset = "0x28BF220", VA = "0x1828C0220")]
	public HCGNNEJAOHI<bool> EKGDBOHPAIM<T>(AssetReference BEMEGNHIOOO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6720", Offset = "0x6BE5720", VA = "0x186BE6720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6A50", Offset = "0x6BE5A50", VA = "0x186BE6A50")]
	private void PPHNMFACLOB(UnityEngine.Object EKOJIMJFJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6590", Offset = "0x6BE5590", VA = "0x186BE6590")]
	private ObjectPool DBKIALFLIEI(string KJABOHKGPKO)
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
		private static GlobalPool HIGFDGEHMAP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject OEHHDFAGGEF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool IBMHAACFGKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6BE7220", Offset = "0x6BE6220", VA = "0x186BE7220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E9E0", Offset = "0x2B1D9E0", VA = "0x182B1E9E0")]
		public static void SafeRelease<T>(T HBFCGFKGCAF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7150", Offset = "0x6BE6150", VA = "0x186BE7150")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7210", Offset = "0x6BE6210", VA = "0x186BE7210")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JDOMIFMNLFH> KAFFOOCHIOL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1520", Offset = "0x2CC0520", VA = "0x182CC1520")]
		public T Acquire<T>(T FIFJHOIIJHB, [Optional] Action<Component> FINKLPDHOPB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2CC18E0", Offset = "0x2CC08E0", VA = "0x182CC18E0")]
		public bool Release<T>(T HBFCGFKGCAF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1870", Offset = "0x2CC0870", VA = "0x182CC1870")]
		public void Prefill<T>(T FIFJHOIIJHB, int MEBMPKIFHBB, [Optional] Action<Component> MJNOMJHAJMM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1690", Offset = "0x2CC0690", VA = "0x182CC1690")]
		public bool Exists<T>(T FIFJHOIIJHB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CC15E0", Offset = "0x2CC05E0", VA = "0x182CC15E0")]
		public void Clear<T>(T FIFJHOIIJHB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7B40", Offset = "0x6BE6B40", VA = "0x186BE7B40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1730", Offset = "0x2CC0730", VA = "0x182CC1730")]
		private JDOMIFMNLFH HAJHLINAJDH<T>(T FIFJHOIIJHB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public void TrackInstantiation(string HHEIHOJLNFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public void EnableStats(bool IEKDHOGCJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7CB0", Offset = "0x6BE6CB0", VA = "0x186BE7CB0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JDOMIFMNLFH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GMMEIFIFMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GIEPBKLJDLH(bool GMNLPDCHGDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int DAHGHBONBME
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void KKGLOBOENAP(int JPBPNOCHNLG, Action<Component> MJNOMJHAJMM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component EBAPBDCJHHO(Action<Component> FINKLPDHOPB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool HLGENIPLFCF(Component ALFBHFDIDMA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OAIAOCAHOEL();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7390", Offset = "0x6BE6390", VA = "0x186BE7390")]
	protected void OLPMCIKKMFE(Component HBFCGFKGCAF, bool GMNLPDCHGDJ, bool FBAPOEOIJDL, bool FEENHBBMNCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7510", Offset = "0x6BE6510", VA = "0x186BE7510")]
	protected void PJDIPAGOBPK(Transform JBBOMKAMFHD, bool GMNLPDCHGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	protected JDOMIFMNLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ADMKDNHOMBP<T> : JDOMIFMNLFH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FIFJHOIIJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FNCPGAEHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FBAPOEOIJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> KKACBINNDHE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7740", Offset = "0x3CE6740", VA = "0x183CE7740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int DAHGHBONBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7BD0", Offset = "0x3CE6BD0", VA = "0x183CE7BD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7E40", Offset = "0x3CE6E40", VA = "0x183CE7E40")]
	public ADMKDNHOMBP(T FIFJHOIIJHB, ObjectPool FNCPGAEHJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7AA0", Offset = "0x3CE6AA0", VA = "0x183CE7AA0", Slot = "6")]
	public override void KKGLOBOENAP(int JPBPNOCHNLG, Action<Component> FINKLPDHOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE74B0", Offset = "0x3CE64B0", VA = "0x183CE74B0", Slot = "7")]
	public override Component EBAPBDCJHHO(Action<Component> FINKLPDHOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7760", Offset = "0x3CE6760", VA = "0x183CE7760", Slot = "8")]
	public override bool HLGENIPLFCF(Component ALFBHFDIDMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7C30", Offset = "0x3CE6C30", VA = "0x183CE7C30", Slot = "9")]
	public override void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7920", Offset = "0x3CE6920", VA = "0x183CE7920")]
	private T IPOAJHADALK()
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
		public interface JNGGEOOPPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject BDGDOILKODH
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
		[Cpp2IlInjected.Address(RVA = "0x6BE77C0", Offset = "0x6BE67C0", VA = "0x186BE77C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7AB0", Offset = "0x6BE6AB0", VA = "0x186BE7AB0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool HIGFDGEHMAP;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject OEHHDFAGGEF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool IBMHAACFGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6BE8460", Offset = "0x6BE7460", VA = "0x186BE8460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BE83A0", Offset = "0x6BE73A0", VA = "0x186BE83A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7210", Offset = "0x6BE6210", VA = "0x186BE7210")]
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
		public JDOMIFMNLFH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FPFAHCFOGBA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OOAIGCNHCNN(PooledParticle.BJJIADMDFHC CMLHNBIJFFM);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum MBGIBLDKEIP
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
		public enum BJJIADMDFHC
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
		public interface CPOLCJPFOJN
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool APEPIPJLHEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 CMPIIBHNKAB
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera MPFDIACNMIA
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
			[Cpp2IlInjected.Address(RVA = "0x5B36D40", Offset = "0x5B35D40", VA = "0x185B36D40")]
			public ColorConfiguration(ParticleSystem ENEJICBNNHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6BE6EA0", Offset = "0x6BE5EA0", VA = "0x186BE6EA0")]
			public void IJHNLIJFIEH(Color MKAJENPGJDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MOMEGKHLJIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public MOMEGKHLJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6BE7790", Offset = "0x6BE6790", VA = "0x186BE7790")]
			internal void CICKLMCLCEG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PFAKPAGABDN : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private CPOLCJPFOJN <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public PFAKPAGABDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6BE7D40", Offset = "0x6BE6D40", VA = "0x186BE7D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6BE8350", Offset = "0x6BE7350", VA = "0x186BE8350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GHMEDJDDCCJ : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public GHMEDJDDCCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6BE7090", Offset = "0x6BE6090", VA = "0x186BE7090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6BE7100", Offset = "0x6BE6100", VA = "0x186BE7100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MJJDNNOKACK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<FPFAHCFOGBA> LLIBLPNDOCC;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> BBACEOEEFEJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static JMPIHICOHFM DHLHOKPLJCP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float JKPDGCCPBJG = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool LDIHPNGIDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int BMEHJMHGOMM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private BJJIADMDFHC category;

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
		private ParticleSystem.MinMaxGradient[] EGMBOJEMBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool MHLCPPDENJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KKHJEPONADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KAMFMHNPDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform BCEHPPGPEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 EMGMCJJEPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 HJOHMHICPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private MBGIBLDKEIP DDODOMJOBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JMPIHICOHFM KJGJHKLPPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool MLBBLLIKIHL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> PHILPIMDMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6BEC350", Offset = "0x6BEB350", VA = "0x186BEC350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BJJIADMDFHC BEJAGKALAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88DC00", Offset = "0x88CC00", VA = "0x18088DC00")]
			get
			{
				return default(BJJIADMDFHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NMAAAIGJEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AJKIJLIKGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6BEC080", Offset = "0x6BEB080", VA = "0x186BEC080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int HDOHJANJAAC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6BEC200", Offset = "0x6BEB200", VA = "0x186BEC200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IGFDDMLAMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6BE9370", Offset = "0x6BE8370", VA = "0x186BE9370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem GJDENABCFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x869500", Offset = "0x868500", VA = "0x180869500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] BLDKGGMKHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] GOEGGANMIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86FF10", Offset = "0x86EF10", VA = "0x18086FF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private MBGIBLDKEIP FPKLCLAFJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x101DEC0", Offset = "0x101CEC0", VA = "0x18101DEC0")]
			get
			{
				return default(MBGIBLDKEIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BEA430", Offset = "0x6BE9430", VA = "0x186BEA430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IIFLOIIGIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BEBFE0", Offset = "0x6BEAFE0", VA = "0x186BEBFE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BEC3A0", Offset = "0x6BEB3A0", VA = "0x186BEC3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB970", Offset = "0x6BEA970", VA = "0x186BEB970")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIFJHOIIJHB, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBAE0", Offset = "0x6BEAAE0", VA = "0x186BEBAE0")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIFJHOIIJHB, Vector3 MOIICCIPACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB020", Offset = "0x6BEA020", VA = "0x186BEB020")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BE93F0", Offset = "0x6BE83F0", VA = "0x186BE93F0")]
		private void GJCKBCMNNHL(bool OHFAELGDCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9C50", Offset = "0x6BE8C50", VA = "0x186BE9C50")]
		[IteratorStateMachine(typeof(PFAKPAGABDN))]
		private static IEnumerator<MBMMHILCGCA> JBIIHHDOBIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9DE0", Offset = "0x6BE8DE0", VA = "0x186BE9DE0")]
		private static void KLFAKKHFLNM(Stopwatch OPELNCJDKIK, Vector3 GDLBPLMMIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9130", Offset = "0x6BE8130", VA = "0x186BE9130")]
		private static int EHGDLJEOANB(PooledParticle ILBMPADICAD, PooledParticle BEOPIALHGPL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA450", Offset = "0x6BE9450", VA = "0x186BEA450")]
		private static int OOAIGCNHCNN(BJJIADMDFHC CMLHNBIJFFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8F30", Offset = "0x6BE7F30", VA = "0x186BE8F30")]
		protected void DCGPHBMHIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9620", Offset = "0x6BE8620", VA = "0x186BE9620")]
		protected void HMPIEGFLBHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8BC0", Offset = "0x6BE7BC0", VA = "0x186BE8BC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA1C0", Offset = "0x6BE91C0", VA = "0x186BEA1C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA560", Offset = "0x6BE9560", VA = "0x186BEA560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA130", Offset = "0x6BE9130", VA = "0x186BEA130")]
		[IteratorStateMachine(typeof(GHMEDJDDCCJ))]
		private IEnumerator<MBMMHILCGCA> LPPPEJAAFNA(float DACHNPNJPDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BE94C0", Offset = "0x6BE84C0", VA = "0x186BE94C0")]
		private void HLGENIPLFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB780", Offset = "0x6BEA780", VA = "0x186BEB780")]
		public void SetDuration(float DACHNPNJPDB, bool AJGFEJIHAEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA5E0", Offset = "0x6BE95E0", VA = "0x186BEA5E0")]
		public void Play(Transform LEJABIDPHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAC90", Offset = "0x6BE9C90", VA = "0x186BEAC90")]
		public void Play(Transform LEJABIDPHJJ, bool JKDGDJBDNEJ, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA740", Offset = "0x6BE9740", VA = "0x186BEA740")]
		public void Play(Transform LEJABIDPHJJ, Vector3 HJOHMHICPPA, bool JKDGDJBDNEJ, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA890", Offset = "0x6BE9890", VA = "0x186BEA890")]
		public void Play(Transform GOAJEEIKOHH, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAE00", Offset = "0x6BE9E00", VA = "0x186BEAE00")]
		public void Play(Transform GOAJEEIKOHH, Vector3 HJOHMHICPPA, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAAB0", Offset = "0x6BE9AB0", VA = "0x186BEAAB0")]
		public void Play(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 EFBILKIFBJD, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA9F0", Offset = "0x6BE99F0", VA = "0x186BEA9F0")]
		public void Play(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAB80", Offset = "0x6BE9B80", VA = "0x186BEAB80")]
		public void Play(bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB8E0", Offset = "0x6BEA8E0", VA = "0x186BEB8E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB850", Offset = "0x6BEA850", VA = "0x186BEB850")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BE91E0", Offset = "0x6BE81E0", VA = "0x186BE91E0")]
		private void FEGDKJBLAEL(float DACHNPNJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8DF0", Offset = "0x6BE7DF0", VA = "0x186BE8DF0")]
		private void CFEJLCGDAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAF30", Offset = "0x6BE9F30", VA = "0x186BEAF30")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB1A0", Offset = "0x6BEA1A0", VA = "0x186BEB1A0")]
		public void SetColor(Color MKAJENPGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9CB0", Offset = "0x6BE8CB0", VA = "0x186BE9CB0")]
		private void KHGGFEDDFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBF50", Offset = "0x6BEAF50", VA = "0x186BEBF50")]
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
