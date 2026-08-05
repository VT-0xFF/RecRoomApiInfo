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
		[Cpp2IlInjected.Address(RVA = "0x5E84D50", Offset = "0x5E83B50", VA = "0x185E84D50")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LHMPGCOFOMN, float GEKEEGPHIOH, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E849F0", Offset = "0x5E837F0", VA = "0x185E849F0")]
		public void SetDamageValue(float GEKEEGPHIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E84ED0", Offset = "0x5E83CD0", VA = "0x185E84ED0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OGCPLOLFPKE<T> : MIDEJKJPMAF<T>, MMMPEMHFGNJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface INNMMKLLGII<T> : MMMPEMHFGNJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AEHNPGMLGKN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BJODEDHHDFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OCINEOGMALL<T> : CHDLLIBCNCN<T>, OGCPLOLFPKE<T>, MIDEJKJPMAF<T>, MMMPEMHFGNJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EICEMLLFLGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OCINEOGMALL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public EICEMLLFLGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3032CB0", Offset = "0x3031AB0", VA = "0x183032CB0")]
			internal void JFNJDBFGGNA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2181240", Offset = "0x2180040", VA = "0x182181240")]
			internal void CGPEBOJMCJK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FBMLADGOGPH<T> ILIMEGMHAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool MBNBLGCGGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T BBDPDFCKIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FGEBCHHJFIF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6AA0", Offset = "0x3CC58A0", VA = "0x183CC6AA0")]
		public OCINEOGMALL(FBMLADGOGPH<T> ILIMEGMHAKK, ObjectPool MBNBLGCGGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6900", Offset = "0x3CC5700", VA = "0x183CC6900", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DCEEGKAGDFD<T> : OGKAMIBOIGC, INNMMKLLGII<T>, MMMPEMHFGNJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NALJJKIKJPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DCEEGKAGDFD<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public NALJJKIKJPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3BCF440", Offset = "0x3BCE240", VA = "0x183BCF440")]
			internal void JFNJDBFGGNA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8DD690", Offset = "0x8DC490", VA = "0x1808DD690")]
			internal void CGPEBOJMCJK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FBMLADGOGPH<T> ILIMEGMHAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool FGEBCHHJFIF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4C436B0", Offset = "0x4C424B0", VA = "0x184C436B0")]
		public DCEEGKAGDFD(FBMLADGOGPH<T> ILIMEGMHAKK, ObjectPool MBNBLGCGGFG, int CCDEMECAMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4C43650", Offset = "0x4C42450", VA = "0x184C43650", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DLBFPLAMNJP<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BJODEDHHDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CHDLLIBCNCN<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FBMLADGOGPH<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DLBFPLAMNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C83570", Offset = "0x4C82370", VA = "0x184C83570")]
		internal void IMEIHBEBIOI(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C83620", Offset = "0x4C82420", VA = "0x184C83620")]
		internal void LEAAIMMDPKP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4C83520", Offset = "0x4C82320", VA = "0x184C83520")]
		internal void DJHPCFPJBKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<AEHNPGMLGKN> JNBPFFNDHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KCLIDHGPIPM IJKIFAIGALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool MBNBLGCGGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool MBDEEOFEOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E82BA0", Offset = "0x5E819A0", VA = "0x185E82BA0")]
	private static void LPBLLPIJDDM(Component KDELPFFKINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E83000", Offset = "0x5E81E00", VA = "0x185E83000")]
	public BJODEDHHDFD(string PEJNLGAGBJB, int DGPKCPPLBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x218C9F0", Offset = "0x218B7F0", VA = "0x18218C9F0")]
	public OGCPLOLFPKE<T> EEOAGFEOHIM<T>(AssetReference PADEGDNBIFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x218CA90", Offset = "0x218B890", VA = "0x18218CA90")]
	public INNMMKLLGII<T> JKEDLACMFIJ<T>(AssetReference PADEGDNBIFE, int NENAAIFMEME) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x218CB40", Offset = "0x218B940", VA = "0x18218CB40")]
	public MIDEJKJPMAF<bool> MDCAPFCGBJE<T>(AssetReference PADEGDNBIFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E82AB0", Offset = "0x5E818B0", VA = "0x185E82AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E82980", Offset = "0x5E81780", VA = "0x185E82980")]
	private void BIAPIPBGBJN(UnityEngine.Object AFKGONAPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E82DE0", Offset = "0x5E81BE0", VA = "0x185E82DE0")]
	private ObjectPool OPJKCGFGPBK(string PEJNLGAGBJB)
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
		private static GlobalPool FLNFHFFEHKN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CKNDLANJBPJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool IFFGEIGBEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E83A10", Offset = "0x5E82810", VA = "0x185E83A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23A9270", Offset = "0x23A8070", VA = "0x1823A9270")]
		public static void SafeRelease<T>(T DGPHOMINFCK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E83940", Offset = "0x5E82740", VA = "0x185E83940")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E83A00", Offset = "0x5E82800", VA = "0x185E83A00")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, CHFFMHOOGFH> LBFLDAELNGJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x250C6A0", Offset = "0x250B4A0", VA = "0x18250C6A0")]
		public T Acquire<T>(T LHMPGCOFOMN, [Optional] Action<Component> KELEHBFININ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x250CA10", Offset = "0x250B810", VA = "0x18250CA10")]
		public bool Release<T>(T DGPHOMINFCK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x250C9C0", Offset = "0x250B7C0", VA = "0x18250C9C0")]
		public void Prefill<T>(T LHMPGCOFOMN, int HIGDDHJLNAM, [Optional] Action<Component> BHLAPKNHBJK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x250C7E0", Offset = "0x250B5E0", VA = "0x18250C7E0")]
		public bool Exists<T>(T LHMPGCOFOMN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x250C730", Offset = "0x250B530", VA = "0x18250C730")]
		public void Clear<T>(T LHMPGCOFOMN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E84590", Offset = "0x5E83390", VA = "0x185E84590")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x250C880", Offset = "0x250B680", VA = "0x18250C880")]
		private CHFFMHOOGFH OMFMPCHHBMF<T>(T LHMPGCOFOMN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		public void TrackInstantiation(string ODOFACCLDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		public void EnableStats(bool ODHPNPHGPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E84700", Offset = "0x5E83500", VA = "0x185E84700")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class CHFFMHOOGFH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MAIHFOICHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IGAJCIJGBGH(bool MMCBDJIKKAM);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int LHILGNAAIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void JKEDLACMFIJ(int NENAAIFMEME, Action<Component> BHLAPKNHBJK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component EEOAGFEOHIM(Action<Component> KELEHBFININ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NDCOKDMKIND(Component POCMKOMIDEC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LHLJEDFLAKN();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E83290", Offset = "0x5E82090", VA = "0x185E83290")]
	protected void GHANLFHDCDL(Component DGPHOMINFCK, bool MMCBDJIKKAM, bool EJHGPGHNDDL, bool IKKJOKKNEBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E83410", Offset = "0x5E82210", VA = "0x185E83410")]
	protected void JPBOBNCPKAG(Transform APPAJPCINFM, bool MMCBDJIKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected CHFFMHOOGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IEEOPFBDAEP<T> : CHFFMHOOGFH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LHMPGCOFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool HPEODAGNIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EJHGPGHNDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> ECOECKDCPHC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3676CF0", Offset = "0x3675AF0", VA = "0x183676CF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int LHILGNAAIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3676B10", Offset = "0x3675910", VA = "0x183676B10", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3676D10", Offset = "0x3675B10", VA = "0x183676D10")]
	public IEEOPFBDAEP(T LHMPGCOFOMN, ObjectPool HPEODAGNIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3676820", Offset = "0x3675620", VA = "0x183676820", Slot = "6")]
	public override void JKEDLACMFIJ(int NENAAIFMEME, Action<Component> KELEHBFININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3676440", Offset = "0x3675240", VA = "0x183676440", Slot = "7")]
	public override Component EEOAGFEOHIM(Action<Component> KELEHBFININ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3676B50", Offset = "0x3675950", VA = "0x183676B50", Slot = "8")]
	public override bool NDCOKDMKIND(Component POCMKOMIDEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3676930", Offset = "0x3675730", VA = "0x183676930", Slot = "9")]
	public override void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36766B0", Offset = "0x36754B0", VA = "0x1836766B0")]
	private T JHKHMKEJCIK()
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
		public interface HHGMMDIEFKN
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject EHCLIDINJOL
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
		[Cpp2IlInjected.Address(RVA = "0x5E84210", Offset = "0x5E83010", VA = "0x185E84210")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E84500", Offset = "0x5E83300", VA = "0x185E84500")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool FLNFHFFEHKN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject CKNDLANJBPJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool IFFGEIGBEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5E84850", Offset = "0x5E83650", VA = "0x185E84850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E84790", Offset = "0x5E83590", VA = "0x185E84790")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E83A00", Offset = "0x5E82800", VA = "0x185E83A00")]
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
		public CHFFMHOOGFH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HCPKGEBAIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KDNPEDIHMHP(PooledParticle.AOFMBDLGDCO HEFMIBGKDFH);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum COBCKPIJCAK
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
		public enum AOFMBDLGDCO
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
		public interface PAPHMAGJFAN
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool FNHMMHOCLAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 ACCHGLONJGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera NLDMBEGCPHO
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
			[Cpp2IlInjected.Address(RVA = "0x4F7B930", Offset = "0x4F7A730", VA = "0x184F7B930")]
			public ColorConfiguration(ParticleSystem JAMBLAPBGHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E83690", Offset = "0x5E82490", VA = "0x185E83690")]
			public void CGEFCHKLDLA(Color CEPDKAIKDOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KEPFJGGFHIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public KEPFJGGFHIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E83B80", Offset = "0x5E82980", VA = "0x185E83B80")]
			internal void CAJGHELGFMB(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class LEAIHPOPNKP : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private PAPHMAGJFAN <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public LEAIHPOPNKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5E83BB0", Offset = "0x5E829B0", VA = "0x185E83BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E841C0", Offset = "0x5E82FC0", VA = "0x185E841C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DAOKCNPGJAL : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public DAOKCNPGJAL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E83880", Offset = "0x5E82680", VA = "0x185E83880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5E838F0", Offset = "0x5E826F0", VA = "0x185E838F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> GAMAMGJOBIJ;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<HCPKGEBAIMF> MHLFABAEAOD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> FFLHOPDALIO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static KFKJPENGGJI DLCHGNJHBGE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float JBNFPBAFEBK = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool KOAAOOAFADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int CBJHIJOEDLI;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private AOFMBDLGDCO category;

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
		private ParticleSystem.MinMaxGradient[] OEKOIPPLABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool JDJBBFHPADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float MOABKJFCONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float MHBMMPFNMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform CINMLPIBEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 ICFAJFENKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 FECGOLIPGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private COBCKPIJCAK MMMOALBMOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KFKJPENGGJI BDNJEGABKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool GCBNBNFGDBF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> JNEEGLDHHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E88720", Offset = "0x5E87520", VA = "0x185E88720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AOFMBDLGDCO HNKMKJGONLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x786F50", Offset = "0x785D50", VA = "0x180786F50")]
			get
			{
				return default(AOFMBDLGDCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GDOHONOBGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ENEODBALKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5E88450", Offset = "0x5E87250", VA = "0x185E88450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int AFDMPFCPHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5E885D0", Offset = "0x5E873D0", VA = "0x185E885D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool KAPHEIFMJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E85760", Offset = "0x5E84560", VA = "0x185E85760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem GKCNOCNFDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] PGFNKADFOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] HMAMKJHHACG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private COBCKPIJCAK GFJGDIBMHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD04070", Offset = "0xD02E70", VA = "0x180D04070")]
			get
			{
				return default(COBCKPIJCAK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5E85740", Offset = "0x5E84540", VA = "0x185E85740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ABLIPPNLPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E883B0", Offset = "0x5E871B0", VA = "0x185E883B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5E88770", Offset = "0x5E87570", VA = "0x185E88770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E87D40", Offset = "0x5E86B40", VA = "0x185E87D40")]
		public static PooledParticle TryPlayPrefab(PooledParticle LHMPGCOFOMN, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E87EB0", Offset = "0x5E86CB0", VA = "0x185E87EB0")]
		public static PooledParticle TryPlayPrefab(PooledParticle LHMPGCOFOMN, Vector3 CMKBDFOJBFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E873F0", Offset = "0x5E861F0", VA = "0x185E873F0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E85670", Offset = "0x5E84470", VA = "0x185E85670")]
		private void CHIBHNDJDOF(bool FHMOAAILLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E85C30", Offset = "0x5E84A30", VA = "0x185E85C30")]
		[IteratorStateMachine(typeof(LEAIHPOPNKP))]
		private static IEnumerator<JHKLHFOKPOC> LPLFEMLPLMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E85320", Offset = "0x5E84120", VA = "0x185E85320")]
		private static void BPJFNACNFEA(Stopwatch DNLFOGHCHDI, Vector3 ONDCJHOKLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E857E0", Offset = "0x5E845E0", VA = "0x185E857E0")]
		private static int JKEKCILOFAJ(PooledParticle MNLOCDHFJKE, PooledParticle CHEKOKJNNFE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E85890", Offset = "0x5E84690", VA = "0x185E85890")]
		private static int KDNPEDIHMHP(AOFMBDLGDCO HEFMIBGKDFH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E859A0", Offset = "0x5E847A0", VA = "0x185E859A0")]
		protected void LDBBHFIMDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E86060", Offset = "0x5E84E60", VA = "0x185E86060")]
		protected void OBIPDJNEAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E84FB0", Offset = "0x5E83DB0", VA = "0x185E84FB0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E85C90", Offset = "0x5E84A90", VA = "0x185E85C90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E86670", Offset = "0x5E85470", VA = "0x185E86670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E85BA0", Offset = "0x5E849A0", VA = "0x185E85BA0")]
		[IteratorStateMachine(typeof(DAOKCNPGJAL))]
		private IEnumerator<JHKLHFOKPOC> LIKHJCFMPOC(float DCKCDNEGBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E85F00", Offset = "0x5E84D00", VA = "0x185E85F00")]
		private void NDCOKDMKIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E87B50", Offset = "0x5E86950", VA = "0x185E87B50")]
		public void SetDuration(float DCKCDNEGBLL, bool GAMAJFAAGMP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E869B0", Offset = "0x5E857B0", VA = "0x185E869B0")]
		public void Play(Transform DMEDBAJKLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E87060", Offset = "0x5E85E60", VA = "0x185E87060")]
		public void Play(Transform DMEDBAJKLMP, bool OHEOFLCPJCO, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E86B10", Offset = "0x5E85910", VA = "0x185E86B10")]
		public void Play(Transform DMEDBAJKLMP, Vector3 FECGOLIPGID, bool OHEOFLCPJCO, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E86C60", Offset = "0x5E85A60", VA = "0x185E86C60")]
		public void Play(Transform GHBHKMAAKAO, Quaternion ALADLBOMNEP, bool OHEOFLCPJCO = false, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E871D0", Offset = "0x5E85FD0", VA = "0x185E871D0")]
		public void Play(Transform GHBHKMAAKAO, Vector3 FECGOLIPGID, Quaternion ALADLBOMNEP, bool OHEOFLCPJCO = false, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E86E80", Offset = "0x5E85C80", VA = "0x185E86E80")]
		public void Play(Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, Vector3 JIJAOBLIPMH, bool OHEOFLCPJCO = false, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E86DC0", Offset = "0x5E85BC0", VA = "0x185E86DC0")]
		public void Play(Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, bool OHEOFLCPJCO = false, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E86F50", Offset = "0x5E85D50", VA = "0x185E86F50")]
		public void Play(bool OHEOFLCPJCO = false, float HFFJJOLNOGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E87CB0", Offset = "0x5E86AB0", VA = "0x185E87CB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E87C20", Offset = "0x5E86A20", VA = "0x185E87C20")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E866F0", Offset = "0x5E854F0", VA = "0x185E866F0")]
		private void PCDPBLAOJCB(float DCKCDNEGBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E851E0", Offset = "0x5E83FE0", VA = "0x185E851E0")]
		private void BJLHDPKKPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E87300", Offset = "0x5E86100", VA = "0x185E87300")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E87570", Offset = "0x5E86370", VA = "0x185E87570")]
		public void SetColor(Color CEPDKAIKDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E86880", Offset = "0x5E85680", VA = "0x185E86880")]
		private void PCGFPPBGPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E88320", Offset = "0x5E87120", VA = "0x185E88320")]
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
