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
		[SerializeField]
		[Header("Impact Particle Start Size")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EFF070", Offset = "0x6EFE270", VA = "0x186EFF070")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles ONCGCDCCCBH, float DIMJHKOKJOE, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EFED10", Offset = "0x6EFDF10", VA = "0x186EFED10")]
		public void SetDamageValue(float DIMJHKOKJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF1F0", Offset = "0x6EFE3F0", VA = "0x186EFF1F0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KEPGENBLGHB<T> : PIHPPMDHIHB<T>, KAHDNIHNJDF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AAGDPEKLOEN<T> : KAHDNIHNJDF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ICCKKGAPKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CPNANEOMJJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MJEKGKBNCEB<T> : GJPMFEFCDNC<T>, KEPGENBLGHB<T>, PIHPPMDHIHB<T>, KAHDNIHNJDF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CHMIENLMMHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MJEKGKBNCEB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public CHMIENLMMHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x56D3FB0", Offset = "0x56D31B0", VA = "0x1856D3FB0")]
			internal void IKGCEPPOOKO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2CA79E0", Offset = "0x2CA6BE0", VA = "0x182CA79E0")]
			internal void AOBJFGIBDOD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NMANDIAIDGE<T> ICNMOIKDLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool LBFDMMEDDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PPKIGCGEAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HLBKMNGGNJD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x47A67B0", Offset = "0x47A59B0", VA = "0x1847A67B0")]
		public MJEKGKBNCEB(NMANDIAIDGE<T> ICNMOIKDLJC, ObjectPool LBFDMMEDDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x47A6640", Offset = "0x47A5840", VA = "0x1847A6640", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PMNBBBCCOND<T> : KOKEAEPGGEH, AAGDPEKLOEN<T>, KAHDNIHNJDF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HOIAAHGODNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PMNBBBCCOND<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public HOIAAHGODNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4050D20", Offset = "0x404FF20", VA = "0x184050D20")]
			internal void IKGCEPPOOKO(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xE51060", Offset = "0xE50260", VA = "0x180E51060")]
			internal void AOBJFGIBDOD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NMANDIAIDGE<T> ICNMOIKDLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HLBKMNGGNJD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4AB75F0", Offset = "0x4AB67F0", VA = "0x184AB75F0")]
		public PMNBBBCCOND(NMANDIAIDGE<T> ICNMOIKDLJC, ObjectPool LBFDMMEDDOM, int DMONDIDCKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7590", Offset = "0x4AB6790", VA = "0x184AB7590", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KDMKBKEHHGC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CPNANEOMJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GJPMFEFCDNC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NMANDIAIDGE<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KDMKBKEHHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4492760", Offset = "0x4491960", VA = "0x184492760")]
		internal void POKLFLDFNDL(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44926B0", Offset = "0x44918B0", VA = "0x1844926B0")]
		internal void CNFIPFCINMK(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4492710", Offset = "0x4491910", VA = "0x184492710")]
		internal void NFAMHDKGPKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<ICCKKGAPKMF> OKNNBCAPCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LGJBIKDGFJB NLPPMPEBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool LBFDMMEDDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HLBKMNGGNJD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCCB0", Offset = "0x6EFBEB0", VA = "0x186EFCCB0")]
	private static void DKBOAOBOIEO(Component OPAHHNBNPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD350", Offset = "0x6EFC550", VA = "0x186EFD350")]
	public CPNANEOMJJP(string HFKACMMIPME, int NOLAMAFJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C38320", Offset = "0x2C37520", VA = "0x182C38320")]
	public KEPGENBLGHB<T> MIINEHAMMLL<T>(AssetReference NPJFCNFMKBF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C38240", Offset = "0x2C37440", VA = "0x182C38240")]
	public AAGDPEKLOEN<T> GILCBFHKNLF<T>(AssetReference NPJFCNFMKBF, int NDEFEFEFLCE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C37DB0", Offset = "0x2C36FB0", VA = "0x182C37DB0")]
	public PIHPPMDHIHB<bool> BBGJCOKFMOM<T>(AssetReference NPJFCNFMKBF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD080", Offset = "0x6EFC280", VA = "0x186EFD080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFD170", Offset = "0x6EFC370", VA = "0x186EFD170")]
	private void EGHFODKEKKG(UnityEngine.Object FGAGFKGABDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCEF0", Offset = "0x6EFC0F0", VA = "0x186EFCEF0")]
	private ObjectPool DNNKFEEPPJM(string HFKACMMIPME)
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
		private static GlobalPool PPMGFGKKDEE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GNEDCEPNAMI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool FAKOKDPOOAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6EFE000", Offset = "0x6EFD200", VA = "0x186EFE000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2E131C0", Offset = "0x2E123C0", VA = "0x182E131C0")]
		public static void SafeRelease<T>(T JMJAOKJJFGJ) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDF30", Offset = "0x6EFD130", VA = "0x186EFDF30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDFF0", Offset = "0x6EFD1F0", VA = "0x186EFDFF0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, IDNFEAFAHIG> FODADMCHDMC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2FB38D0", Offset = "0x2FB2AD0", VA = "0x182FB38D0")]
		public T Acquire<T>(T ONCGCDCCCBH, [Optional] Action<Component> LEOLJBJEDAN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3C90", Offset = "0x2FB2E90", VA = "0x182FB3C90")]
		public bool Release<T>(T JMJAOKJJFGJ) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3C20", Offset = "0x2FB2E20", VA = "0x182FB3C20")]
		public void Prefill<T>(T ONCGCDCCCBH, int IGJHAMOHFOF, [Optional] Action<Component> AAHKNAPCFDL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3A40", Offset = "0x2FB2C40", VA = "0x182FB3A40")]
		public bool Exists<T>(T ONCGCDCCCBH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3990", Offset = "0x2FB2B90", VA = "0x182FB3990")]
		public void Clear<T>(T ONCGCDCCCBH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE8D0", Offset = "0x6EFDAD0", VA = "0x186EFE8D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3AE0", Offset = "0x2FB2CE0", VA = "0x182FB3AE0")]
		private IDNFEAFAHIG LOOAJNIFHLE<T>(T ONCGCDCCCBH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void TrackInstantiation(string KFGEPIGHLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void EnableStats(bool FPOPFJAHJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEA40", Offset = "0x6EFDC40", VA = "0x186EFEA40")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class IDNFEAFAHIG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FBMFMKMFMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GJCHMMFCHNM(bool OFBHOKEDBEB);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int BIFJIGKMEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void GILCBFHKNLF(int NDEFEFEFLCE, Action<Component> AAHKNAPCFDL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component MIINEHAMMLL(Action<Component> LEOLJBJEDAN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IMHGPOENCOG(Component DANPBMMGEMC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void AODHOHPPLKC();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE3D0", Offset = "0x6EFD5D0", VA = "0x186EFE3D0")]
	protected void MCKJDHBLBHB(Component JMJAOKJJFGJ, bool OFBHOKEDBEB, bool FOOBKAOHBAE, bool AHFDBLEKPOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EFE150", Offset = "0x6EFD350", VA = "0x186EFE150")]
	protected void EAIACKGDHFK(Transform EBKBJNDAKOM, bool OFBHOKEDBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected IDNFEAFAHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LIBCINIPDPJ<T> : IDNFEAFAHIG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T ONCGCDCCCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool ACEEEGACILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FOOBKAOHBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> CBEBPDHGOOI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4554F80", Offset = "0x4554180", VA = "0x184554F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int BIFJIGKMEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4554F30", Offset = "0x4554130", VA = "0x184554F30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4555690", Offset = "0x4554890", VA = "0x184555690")]
	public LIBCINIPDPJ(T ONCGCDCCCBH, ObjectPool ACEEEGACILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4555120", Offset = "0x4554320", VA = "0x184555120", Slot = "6")]
	public override void GILCBFHKNLF(int NDEFEFEFLCE, Action<Component> LEOLJBJEDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4555400", Offset = "0x4554600", VA = "0x184555400", Slot = "7")]
	public override Component MIINEHAMMLL(Action<Component> LEOLJBJEDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4555250", Offset = "0x4554450", VA = "0x184555250", Slot = "8")]
	public override bool IMHGPOENCOG(Component DANPBMMGEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4554D20", Offset = "0x4553F20", VA = "0x184554D20", Slot = "9")]
	public override void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4554FA0", Offset = "0x45541A0", VA = "0x184554FA0")]
	private T FINPCDHBIAC()
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
		public interface PLHPFMFHEPL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject MDPLMJJBDFG
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
		[Cpp2IlInjected.Address(RVA = "0x6EFE550", Offset = "0x6EFD750", VA = "0x186EFE550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFE840", Offset = "0x6EFDA40", VA = "0x186EFE840")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool PPMGFGKKDEE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GNEDCEPNAMI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool FAKOKDPOOAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6EFEB90", Offset = "0x6EFDD90", VA = "0x186EFEB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EFEAD0", Offset = "0x6EFDCD0", VA = "0x186EFEAD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EFDFF0", Offset = "0x6EFD1F0", VA = "0x186EFDFF0")]
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
		public IDNFEAFAHIG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PNIIBFFBPPI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DIMJCPLAABN(PooledParticle.APFHBHLMIKC OOGDAKLIBDA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum BLBGALAAPPH
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
		public enum APFHBHLMIKC
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
		public interface GMDLFIEHDIE
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool LNMJJMOLNMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 JFFLAJLDKGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera NPOJFBCNALE
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E02A00", Offset = "0x5E01C00", VA = "0x185E02A00")]
			public ColorConfiguration(ParticleSystem LGAIONPFGGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6EFD5E0", Offset = "0x6EFC7E0", VA = "0x186EFD5E0")]
			public void FAKMKKCJAEG(Color CIHDHJMCJNM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FBDNMFGLFME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public FBDNMFGLFME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6EFD890", Offset = "0x6EFCA90", VA = "0x186EFD890")]
			internal void DAOMAOBHEFM(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class FPNJECAOADG : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GMDLFIEHDIE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public FPNJECAOADG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6EFD8C0", Offset = "0x6EFCAC0", VA = "0x186EFD8C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6EFDEE0", Offset = "0x6EFD0E0", VA = "0x186EFDEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DFAGLHFECDC : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public DFAGLHFECDC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6EFD7D0", Offset = "0x6EFC9D0", VA = "0x186EFD7D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6EFD840", Offset = "0x6EFCA40", VA = "0x186EFD840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> HHCLJCOEDNL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<PNIIBFFBPPI> NHBGPFLGDGH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> MNPJPNEFOLI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GMLIOGMHHKE BNDNNECANIP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float ICOEJLAICHP = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool KONLDKIPCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int MLJHHBFGONO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private APFHBHLMIKC category;

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
		private ParticleSystem.MinMaxGradient[] HPLFLNKAIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool CLJGHNOMKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KNJLPHBNCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float JANMODKPPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform ADOMLAOKLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 GBJIIOCLGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 EKCIIMEOIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BLBGALAAPPH KLFMECLHKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GMLIOGMHHKE FDMFMIIDOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool PIPOBPCMMDI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> POPAJLNFCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F02980", Offset = "0x6F01B80", VA = "0x186F02980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public APFHBHLMIKC KIHOOLJJMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BD900", Offset = "0x8BCB00", VA = "0x1808BD900")]
			get
			{
				return default(APFHBHLMIKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HFILFPBLBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HDPKHAJIFPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F026D0", Offset = "0x6F018D0", VA = "0x186F026D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int MKDEFNCECOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F02840", Offset = "0x6F01A40", VA = "0x186F02840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OMNJIHLEIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6EFF820", Offset = "0x6EFEA20", VA = "0x186EFF820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem ONIEJIOGPOE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] ECGICMBBAFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] HEPNADLHMCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BLBGALAAPPH EEHCFKFNCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x12E4580", Offset = "0x12E3780", VA = "0x1812E4580")]
			get
			{
				return default(BLBGALAAPPH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6EFFBC0", Offset = "0x6EFEDC0", VA = "0x186EFFBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GGINDMEICDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F02630", Offset = "0x6F01830", VA = "0x186F02630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F029D0", Offset = "0x6F01BD0", VA = "0x186F029D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F01FF0", Offset = "0x6F011F0", VA = "0x186F01FF0")]
		public static PooledParticle TryPlayPrefab(PooledParticle ONCGCDCCCBH, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F02160", Offset = "0x6F01360", VA = "0x186F02160")]
		public static PooledParticle TryPlayPrefab(PooledParticle ONCGCDCCCBH, Vector3 FJFKFIAGEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F016B0", Offset = "0x6F008B0", VA = "0x186F016B0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F00490", Offset = "0x6EFF690", VA = "0x186F00490")]
		private void NHOGEFOFOLO(bool CIBBAIKMIFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F00430", Offset = "0x6EFF630", VA = "0x186F00430")]
		[IteratorStateMachine(typeof(FPNJECAOADG))]
		private static IEnumerator<CKLDDHMAHNL> NGIBFAIDJCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFBE0", Offset = "0x6EFEDE0", VA = "0x186EFFBE0")]
		private static void HJFGLPPPLAK(Stopwatch MOKDAJBBPHK, Vector3 DCEEFAKFOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF2C0", Offset = "0x6EFE4C0", VA = "0x186EFF2C0")]
		private static int AOAIDEICMKG(PooledParticle ICLLFDEBJIO, PooledParticle JPMAPOMKNPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF590", Offset = "0x6EFE790", VA = "0x186EFF590")]
		private static int DIMJCPLAABN(APFHBHLMIKC OOGDAKLIBDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF9D0", Offset = "0x6EFEBD0", VA = "0x186EFF9D0")]
		protected void GCKCKKMHMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F005F0", Offset = "0x6EFF7F0", VA = "0x186F005F0")]
		protected void OPAGGNPHEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF370", Offset = "0x6EFE570", VA = "0x186EFF370", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F001C0", Offset = "0x6EFF3C0", VA = "0x186F001C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F00BF0", Offset = "0x6EFFDF0", VA = "0x186F00BF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F00560", Offset = "0x6EFF760", VA = "0x186F00560")]
		[IteratorStateMachine(typeof(DFAGLHFECDC))]
		private IEnumerator<CKLDDHMAHNL> OMIFJJLIEBE(float OIHNKNJFMCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F00060", Offset = "0x6EFF260", VA = "0x186F00060")]
		private void IMHGPOENCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F01E00", Offset = "0x6F01000", VA = "0x186F01E00")]
		public void SetDuration(float OIHNKNJFMCF, bool PJFGFEFBPNK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F00C70", Offset = "0x6EFFE70", VA = "0x186F00C70")]
		public void Play(Transform NGCDJHCAIMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F01320", Offset = "0x6F00520", VA = "0x186F01320")]
		public void Play(Transform NGCDJHCAIMB, bool NDBKKMHLHPL, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F00DD0", Offset = "0x6EFFFD0", VA = "0x186F00DD0")]
		public void Play(Transform NGCDJHCAIMB, Vector3 EKCIIMEOIPP, bool NDBKKMHLHPL, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F00F20", Offset = "0x6F00120", VA = "0x186F00F20")]
		public void Play(Transform JFEECHDNCNM, Quaternion MBMKLLFOFFL, bool NDBKKMHLHPL = false, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F01490", Offset = "0x6F00690", VA = "0x186F01490")]
		public void Play(Transform JFEECHDNCNM, Vector3 EKCIIMEOIPP, Quaternion MBMKLLFOFFL, bool NDBKKMHLHPL = false, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F01140", Offset = "0x6F00340", VA = "0x186F01140")]
		public void Play(Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, Vector3 BEEOMEJFEKJ, bool NDBKKMHLHPL = false, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F01080", Offset = "0x6F00280", VA = "0x186F01080")]
		public void Play(Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, bool NDBKKMHLHPL = false, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F01210", Offset = "0x6F00410", VA = "0x186F01210")]
		public void Play(bool NDBKKMHLHPL = false, float DMCKAFFOAPA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F01F60", Offset = "0x6F01160", VA = "0x186F01F60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F01ED0", Offset = "0x6F010D0", VA = "0x186F01ED0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF690", Offset = "0x6EFE890", VA = "0x186EFF690")]
		private void EFBHIKKBGDM(float OIHNKNJFMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFF20", Offset = "0x6EFF120", VA = "0x186EFFF20")]
		private void IDFDAKBHOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F015C0", Offset = "0x6F007C0", VA = "0x186F015C0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F01830", Offset = "0x6F00A30", VA = "0x186F01830")]
		public void SetColor(Color CIHDHJMCJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EFF8A0", Offset = "0x6EFEAA0", VA = "0x186EFF8A0")]
		private void FOOJOCLNKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F025A0", Offset = "0x6F017A0", VA = "0x186F025A0")]
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
