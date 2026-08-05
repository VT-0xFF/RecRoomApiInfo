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
		[Cpp2IlInjected.Address(RVA = "0x6BB3FB0", Offset = "0x6BB25B0", VA = "0x186BB3FB0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FIFJHOIIJHB, float IHJMBBDBPAJ, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3C50", Offset = "0x6BB2250", VA = "0x186BB3C50")]
		public void SetDamageValue(float IHJMBBDBPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4130", Offset = "0x6BB2730", VA = "0x186BB4130")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JIDGHFBOPKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4085880", Offset = "0x4083E80", VA = "0x184085880")]
			internal void KHJIJLCBBPO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x27420B0", Offset = "0x27406B0", VA = "0x1827420B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4573DE0", Offset = "0x45723E0", VA = "0x184573DE0")]
		public NKLFKNCOAPB(FMHOFFFMGIN<T> LODCMGMFIFJ, ObjectPool GGAGHMELKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4573C70", Offset = "0x4572270", VA = "0x184573C70", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LBBOCAFCBCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x42A1170", Offset = "0x429F770", VA = "0x1842A1170")]
			internal void KHJIJLCBBPO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xBB05D0", Offset = "0xBAEBD0", VA = "0x180BB05D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42C7760", Offset = "0x42C5D60", VA = "0x1842C7760")]
		public LJGDJDEDJDI(FMHOFFFMGIN<T> LODCMGMFIFJ, ObjectPool GGAGHMELKCE, int OIIHOAGFLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x42C7700", Offset = "0x42C5D00", VA = "0x1842C7700", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HDBECNBGKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1270", Offset = "0x3DAF870", VA = "0x183DB1270")]
		internal void PECHMDICHMD(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3DB11C0", Offset = "0x3DAF7C0", VA = "0x183DB11C0")]
		internal void BGLLBGDMMPL(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1220", Offset = "0x3DAF820", VA = "0x183DB1220")]
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
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1E60", Offset = "0x6BB0460", VA = "0x186BB1E60")]
	private static void OKLAHGMECLP(Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2260", Offset = "0x6BB0860", VA = "0x186BB2260")]
	public BEEMNGGBLAC(string KJABOHKGPKO, int KJJMEDNKCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28B0C20", Offset = "0x28AF220", VA = "0x1828B0C20")]
	public AACKMBGKAKP<T> EBAPBDCJHHO<T>(AssetReference BEMEGNHIOOO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28B1180", Offset = "0x28AF780", VA = "0x1828B1180")]
	public EIFAEGAAECD<T> KKGLOBOENAP<T>(AssetReference BEMEGNHIOOO, int JPBPNOCHNLG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28B0CF0", Offset = "0x28AF2F0", VA = "0x1828B0CF0")]
	public HCGNNEJAOHI<bool> EKGDBOHPAIM<T>(AssetReference BEMEGNHIOOO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1D70", Offset = "0x6BB0370", VA = "0x186BB1D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB20A0", Offset = "0x6BB06A0", VA = "0x186BB20A0")]
	private void PPHNMFACLOB(UnityEngine.Object EKOJIMJFJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1BE0", Offset = "0x6BB01E0", VA = "0x186BB1BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BB2870", Offset = "0x6BB0E70", VA = "0x186BB2870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B05CB0", Offset = "0x2B042B0", VA = "0x182B05CB0")]
		public static void SafeRelease<T>(T HBFCGFKGCAF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB27A0", Offset = "0x6BB0DA0", VA = "0x186BB27A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2860", Offset = "0x6BB0E60", VA = "0x186BB2860")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CA79D0", Offset = "0x2CA5FD0", VA = "0x182CA79D0")]
		public T Acquire<T>(T FIFJHOIIJHB, [Optional] Action<Component> FINKLPDHOPB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7D90", Offset = "0x2CA6390", VA = "0x182CA7D90")]
		public bool Release<T>(T HBFCGFKGCAF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7D20", Offset = "0x2CA6320", VA = "0x182CA7D20")]
		public void Prefill<T>(T FIFJHOIIJHB, int MEBMPKIFHBB, [Optional] Action<Component> MJNOMJHAJMM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7B40", Offset = "0x2CA6140", VA = "0x182CA7B40")]
		public bool Exists<T>(T FIFJHOIIJHB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7A90", Offset = "0x2CA6090", VA = "0x182CA7A90")]
		public void Clear<T>(T FIFJHOIIJHB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3190", Offset = "0x6BB1790", VA = "0x186BB3190")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7BE0", Offset = "0x2CA61E0", VA = "0x182CA7BE0")]
		private JDOMIFMNLFH HAJHLINAJDH<T>(T FIFJHOIIJHB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public void TrackInstantiation(string HHEIHOJLNFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public void EnableStats(bool IEKDHOGCJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3300", Offset = "0x6BB1900", VA = "0x186BB3300")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BB29E0", Offset = "0x6BB0FE0", VA = "0x186BB29E0")]
	protected void OLPMCIKKMFE(Component HBFCGFKGCAF, bool GMNLPDCHGDJ, bool FBAPOEOIJDL, bool FEENHBBMNCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2B60", Offset = "0x6BB1160", VA = "0x186BB2B60")]
	protected void PJDIPAGOBPK(Transform JBBOMKAMFHD, bool GMNLPDCHGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CCCC70", Offset = "0x3CCB270", VA = "0x183CCCC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int DAHGHBONBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD100", Offset = "0x3CCB700", VA = "0x183CCD100", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD370", Offset = "0x3CCB970", VA = "0x183CCD370")]
	public ADMKDNHOMBP(T FIFJHOIIJHB, ObjectPool FNCPGAEHJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCFD0", Offset = "0x3CCB5D0", VA = "0x183CCCFD0", Slot = "6")]
	public override void KKGLOBOENAP(int JPBPNOCHNLG, Action<Component> FINKLPDHOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CCC9E0", Offset = "0x3CCAFE0", VA = "0x183CCC9E0", Slot = "7")]
	public override Component EBAPBDCJHHO(Action<Component> FINKLPDHOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCC90", Offset = "0x3CCB290", VA = "0x183CCCC90", Slot = "8")]
	public override bool HLGENIPLFCF(Component ALFBHFDIDMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD160", Offset = "0x3CCB760", VA = "0x183CCD160", Slot = "9")]
	public override void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCE50", Offset = "0x3CCB450", VA = "0x183CCCE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BB2E10", Offset = "0x6BB1410", VA = "0x186BB2E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3100", Offset = "0x6BB1700", VA = "0x186BB3100")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BB3AB0", Offset = "0x6BB20B0", VA = "0x186BB3AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BB39F0", Offset = "0x6BB1FF0", VA = "0x186BB39F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2860", Offset = "0x6BB0E60", VA = "0x186BB2860")]
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
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B0E820", Offset = "0x5B0CE20", VA = "0x185B0E820")]
			public ColorConfiguration(ParticleSystem ENEJICBNNHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB24F0", Offset = "0x6BB0AF0", VA = "0x186BB24F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public MOMEGKHLJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2DE0", Offset = "0x6BB13E0", VA = "0x186BB2DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
			[DebuggerHidden]
			public PFAKPAGABDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3390", Offset = "0x6BB1990", VA = "0x186BB3390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB39A0", Offset = "0x6BB1FA0", VA = "0x186BB39A0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
			[DebuggerHidden]
			public GHMEDJDDCCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB26E0", Offset = "0x6BB0CE0", VA = "0x186BB26E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2750", Offset = "0x6BB0D50", VA = "0x186BB2750", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BB79A0", Offset = "0x6BB5FA0", VA = "0x186BB79A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BJJIADMDFHC BEJAGKALAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88AC00", Offset = "0x889200", VA = "0x18088AC00")]
			get
			{
				return default(BJJIADMDFHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NMAAAIGJEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AJKIJLIKGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB76D0", Offset = "0x6BB5CD0", VA = "0x186BB76D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int HDOHJANJAAC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7850", Offset = "0x6BB5E50", VA = "0x186BB7850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IGFDDMLAMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6BB49C0", Offset = "0x6BB2FC0", VA = "0x186BB49C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem GJDENABCFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] BLDKGGMKHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] GOEGGANMIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86CF10", Offset = "0x86B510", VA = "0x18086CF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private MBGIBLDKEIP FPKLCLAFJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x10158A0", Offset = "0x1013EA0", VA = "0x1810158A0")]
			get
			{
				return default(MBGIBLDKEIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5A80", Offset = "0x6BB4080", VA = "0x186BB5A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IIFLOIIGIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7630", Offset = "0x6BB5C30", VA = "0x186BB7630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6BB79F0", Offset = "0x6BB5FF0", VA = "0x186BB79F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6FC0", Offset = "0x6BB55C0", VA = "0x186BB6FC0")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIFJHOIIJHB, Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7130", Offset = "0x6BB5730", VA = "0x186BB7130")]
		public static PooledParticle TryPlayPrefab(PooledParticle FIFJHOIIJHB, Vector3 MOIICCIPACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6670", Offset = "0x6BB4C70", VA = "0x186BB6670")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4A40", Offset = "0x6BB3040", VA = "0x186BB4A40")]
		private void GJCKBCMNNHL(bool OHFAELGDCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB52A0", Offset = "0x6BB38A0", VA = "0x186BB52A0")]
		[IteratorStateMachine(typeof(PFAKPAGABDN))]
		private static IEnumerator<MBMMHILCGCA> JBIIHHDOBIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5430", Offset = "0x6BB3A30", VA = "0x186BB5430")]
		private static void KLFAKKHFLNM(Stopwatch OPELNCJDKIK, Vector3 GDLBPLMMIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4780", Offset = "0x6BB2D80", VA = "0x186BB4780")]
		private static int EHGDLJEOANB(PooledParticle ILBMPADICAD, PooledParticle BEOPIALHGPL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5AA0", Offset = "0x6BB40A0", VA = "0x186BB5AA0")]
		private static int OOAIGCNHCNN(BJJIADMDFHC CMLHNBIJFFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4580", Offset = "0x6BB2B80", VA = "0x186BB4580")]
		protected void DCGPHBMHIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4C70", Offset = "0x6BB3270", VA = "0x186BB4C70")]
		protected void HMPIEGFLBHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4210", Offset = "0x6BB2810", VA = "0x186BB4210", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5810", Offset = "0x6BB3E10", VA = "0x186BB5810")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5BB0", Offset = "0x6BB41B0", VA = "0x186BB5BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5780", Offset = "0x6BB3D80", VA = "0x186BB5780")]
		[IteratorStateMachine(typeof(GHMEDJDDCCJ))]
		private IEnumerator<MBMMHILCGCA> LPPPEJAAFNA(float DACHNPNJPDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4B10", Offset = "0x6BB3110", VA = "0x186BB4B10")]
		private void HLGENIPLFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6DD0", Offset = "0x6BB53D0", VA = "0x186BB6DD0")]
		public void SetDuration(float DACHNPNJPDB, bool AJGFEJIHAEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5C30", Offset = "0x6BB4230", VA = "0x186BB5C30")]
		public void Play(Transform LEJABIDPHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BB62E0", Offset = "0x6BB48E0", VA = "0x186BB62E0")]
		public void Play(Transform LEJABIDPHJJ, bool JKDGDJBDNEJ, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5D90", Offset = "0x6BB4390", VA = "0x186BB5D90")]
		public void Play(Transform LEJABIDPHJJ, Vector3 HJOHMHICPPA, bool JKDGDJBDNEJ, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5EE0", Offset = "0x6BB44E0", VA = "0x186BB5EE0")]
		public void Play(Transform GOAJEEIKOHH, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6450", Offset = "0x6BB4A50", VA = "0x186BB6450")]
		public void Play(Transform GOAJEEIKOHH, Vector3 HJOHMHICPPA, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6100", Offset = "0x6BB4700", VA = "0x186BB6100")]
		public void Play(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, Vector3 EFBILKIFBJD, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6040", Offset = "0x6BB4640", VA = "0x186BB6040")]
		public void Play(Vector3 MOIICCIPACK, Quaternion ADNGPFKNGFI, bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB61D0", Offset = "0x6BB47D0", VA = "0x186BB61D0")]
		public void Play(bool JKDGDJBDNEJ = false, float NDPHEGMEHPJ = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6F30", Offset = "0x6BB5530", VA = "0x186BB6F30")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6EA0", Offset = "0x6BB54A0", VA = "0x186BB6EA0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4830", Offset = "0x6BB2E30", VA = "0x186BB4830")]
		private void FEGDKJBLAEL(float DACHNPNJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4440", Offset = "0x6BB2A40", VA = "0x186BB4440")]
		private void CFEJLCGDAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6580", Offset = "0x6BB4B80", VA = "0x186BB6580")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BB67F0", Offset = "0x6BB4DF0", VA = "0x186BB67F0")]
		public void SetColor(Color MKAJENPGJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5300", Offset = "0x6BB3900", VA = "0x186BB5300")]
		private void KHGGFEDDFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BB75A0", Offset = "0x6BB5BA0", VA = "0x186BB75A0")]
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
