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
		[Cpp2IlInjected.Address(RVA = "0x6423800", Offset = "0x6422600", VA = "0x186423800")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IHFDHAEOMFG, float DEEIDOHBMIB, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64234A0", Offset = "0x64222A0", VA = "0x1864234A0")]
		public void SetDamageValue(float DEEIDOHBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6423980", Offset = "0x6422780", VA = "0x186423980")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKLNHDPGABE<T> : NPCIDDLFILB<T>, LKLLCIBDBNN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AGLCNLGJCFM<T> : LKLLCIBDBNN, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OAPNEKNDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CCGAIEIFFKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BHCGHAOIKGM<T> : BOOHFGEKJLO<T>, IKLNHDPGABE<T>, NPCIDDLFILB<T>, LKLLCIBDBNN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HCCFGAGJKFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BHCGHAOIKGM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public HCCFGAGJKFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x39AF400", Offset = "0x39AE200", VA = "0x1839AF400")]
			internal void BINFDPDIDCH(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x27C6330", Offset = "0x27C5130", VA = "0x1827C6330")]
			internal void ICFKMGMFGAD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BCJOGHANCKE<T> JOFJBLDIEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool JCAJKLCOFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T LOMIFCBLBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool COIBHEFKPKD;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4855DF0", Offset = "0x4854BF0", VA = "0x184855DF0")]
		public BHCGHAOIKGM(BCJOGHANCKE<T> JOFJBLDIEBB, ObjectPool JCAJKLCOFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4855CB0", Offset = "0x4854AB0", VA = "0x184855CB0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FGPFLFCIEIE<T> : JGKLBIBCBIK, AGLCNLGJCFM<T>, LKLLCIBDBNN, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class KLEFCMLOKAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FGPFLFCIEIE<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public KLEFCMLOKAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3D143F0", Offset = "0x3D131F0", VA = "0x183D143F0")]
			internal void BINFDPDIDCH(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA253D0", Offset = "0xA241D0", VA = "0x180A253D0")]
			internal void ICFKMGMFGAD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BCJOGHANCKE<T> JOFJBLDIEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool COIBHEFKPKD;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3838830", Offset = "0x3837630", VA = "0x183838830")]
		public FGPFLFCIEIE(BCJOGHANCKE<T> JOFJBLDIEBB, ObjectPool JCAJKLCOFMJ, int BJBPHGHLCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38387D0", Offset = "0x38375D0", VA = "0x1838387D0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JIGFGBPOHPM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CCGAIEIFFKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BOOHFGEKJLO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BCJOGHANCKE<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JIGFGBPOHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C32DF0", Offset = "0x3C31BF0", VA = "0x183C32DF0")]
		internal void AMOALIGABPC(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C32E90", Offset = "0x3C31C90", VA = "0x183C32E90")]
		internal void JBNOLDGHGIC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C32EF0", Offset = "0x3C31CF0", VA = "0x183C32EF0")]
		internal void JPFANABLJHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<OAPNEKNDMCJ> FBGMMNFDFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DCDIGCOABAH EBICNGMMFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool JCAJKLCOFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool COIBHEFKPKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool IAFNPPKACCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6421710", Offset = "0x6420510", VA = "0x186421710")]
	private static void NOOPGNFCMFA(Component FFDKILKJFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6421B10", Offset = "0x6420910", VA = "0x186421B10")]
	public CCGAIEIFFKP(string HMNIBMPKHAC, int BOBOLKONOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2711B00", Offset = "0x2710900", VA = "0x182711B00")]
	public IKLNHDPGABE<T> APGDKGKLOIJ<T>(AssetReference NKOJOIMHJME) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2711BA0", Offset = "0x27109A0", VA = "0x182711BA0")]
	public AGLCNLGJCFM<T> EPLKENFPMAF<T>(AssetReference NKOJOIMHJME, int NJKDAMEBDBN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2711C50", Offset = "0x2710A50", VA = "0x182711C50")]
	public NPCIDDLFILB<bool> NKPMKKDPBBC<T>(AssetReference NKOJOIMHJME) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6421620", Offset = "0x6420420", VA = "0x186421620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6421950", Offset = "0x6420750", VA = "0x186421950")]
	private void PCKLONPJGLB(UnityEngine.Object OIFIKIKOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6421490", Offset = "0x6420290", VA = "0x186421490")]
	private ObjectPool DGBLHNBDBAK(string HMNIBMPKHAC)
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
		private static GlobalPool GEMABFADPAK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ICFKHOHEGBF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LLCJIHIKEMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6422B90", Offset = "0x6421990", VA = "0x186422B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4510", Offset = "0x28E3310", VA = "0x1828E4510")]
		public static void SafeRelease<T>(T EIFMADKIHON) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6422AC0", Offset = "0x64218C0", VA = "0x186422AC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6422B80", Offset = "0x6421980", VA = "0x186422B80")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, DKMJOHPNJIP> PCGPNJPEMPC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A40E60", Offset = "0x2A3FC60", VA = "0x182A40E60")]
		public T Acquire<T>(T IHFDHAEOMFG, [Optional] Action<Component> BIJLFELDCEK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A411D0", Offset = "0x2A3FFD0", VA = "0x182A411D0")]
		public bool Release<T>(T EIFMADKIHON) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A41180", Offset = "0x2A3FF80", VA = "0x182A41180")]
		public void Prefill<T>(T IHFDHAEOMFG, int FIKKPNHLJMF, [Optional] Action<Component> AEKCLCBLOLE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A410E0", Offset = "0x2A3FEE0", VA = "0x182A410E0")]
		public bool Exists<T>(T IHFDHAEOMFG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A41030", Offset = "0x2A3FE30", VA = "0x182A41030")]
		public void Clear<T>(T IHFDHAEOMFG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6423060", Offset = "0x6421E60", VA = "0x186423060")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A40EF0", Offset = "0x2A3FCF0", VA = "0x182A40EF0")]
		private DKMJOHPNJIP CKONGMLCMIO<T>(T IHFDHAEOMFG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public void TrackInstantiation(string ADLNCJIHJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public void EnableStats(bool FOLBPNMGGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64231D0", Offset = "0x6421FD0", VA = "0x1864231D0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DKMJOHPNJIP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CCDINJDHHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FOFHEFJBGBL(bool PKGLPIFLEIB);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int ACBCJCAPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void EPLKENFPMAF(int NJKDAMEBDBN, Action<Component> AEKCLCBLOLE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component APGDKGKLOIJ(Action<Component> BIJLFELDCEK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IHAHIMEKHEN(Component MBBOOCKAMOE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HOCLBDDCDMI();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64225D0", Offset = "0x64213D0", VA = "0x1864225D0")]
	protected void JDOIHHIFMGM(Component EIFMADKIHON, bool PKGLPIFLEIB, bool EKPAKECDIJG, bool CMPNCILKCPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6422750", Offset = "0x6421550", VA = "0x186422750")]
	protected void KICLHBOPHOG(Transform FKFKIEKEGAH, bool PKGLPIFLEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected DKMJOHPNJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BOMKPNLBFIK<T> : DKMJOHPNJIP where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T IHFDHAEOMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool JFMCFKOMNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EKPAKECDIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> HHAGPFGOHHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x488BD40", Offset = "0x488AB40", VA = "0x18488BD40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int ACBCJCAPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x488C590", Offset = "0x488B390", VA = "0x18488C590", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x488C5D0", Offset = "0x488B3D0", VA = "0x18488C5D0")]
	public BOMKPNLBFIK(T IHFDHAEOMFG, ObjectPool JFMCFKOMNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x488C130", Offset = "0x488AF30", VA = "0x18488C130", Slot = "6")]
	public override void EPLKENFPMAF(int NJKDAMEBDBN, Action<Component> BIJLFELDCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x488BD60", Offset = "0x488AB60", VA = "0x18488BD60", Slot = "7")]
	public override Component APGDKGKLOIJ(Action<Component> BIJLFELDCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x488C400", Offset = "0x488B200", VA = "0x18488C400", Slot = "8")]
	public override bool IHAHIMEKHEN(Component MBBOOCKAMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x488C230", Offset = "0x488B030", VA = "0x18488C230", Slot = "9")]
	public override void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x488BFC0", Offset = "0x488ADC0", VA = "0x18488BFC0")]
	private T DOCPPNKCFHF()
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
		public interface HHAHFEEEBDC
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject FENPDADLBDO
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
		[Cpp2IlInjected.Address(RVA = "0x6422CE0", Offset = "0x6421AE0", VA = "0x186422CE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6422FD0", Offset = "0x6421DD0", VA = "0x186422FD0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GEMABFADPAK;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ICFKHOHEGBF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool LLCJIHIKEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6423320", Offset = "0x6422120", VA = "0x186423320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6423260", Offset = "0x6422060", VA = "0x186423260")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6422B80", Offset = "0x6421980", VA = "0x186422B80")]
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
		public DKMJOHPNJIP PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DABGCPKJLPM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BDCGCMIKOEG(PooledParticle.BJGKLAGHGJB BELJPLDIFOP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum CJGOEDDCOBP
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
		public enum BJGKLAGHGJB
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
		public interface CMACALNOELG
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool KHCGEMEOKJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 MENKFPNPONJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera KOEOHLBEAME
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
			[Cpp2IlInjected.Address(RVA = "0x543F070", Offset = "0x543DE70", VA = "0x18543F070")]
			public ColorConfiguration(ParticleSystem HMJBGFEBGBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x64223E0", Offset = "0x64211E0", VA = "0x1864223E0")]
			public void AGFCIBLOHOB(Color BGJPICBMDGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FFKKHEPJHMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public FFKKHEPJHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6422A90", Offset = "0x6421890", VA = "0x186422A90")]
			internal void KHDGIOANMEN(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CCGGNCBEAHJ : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private CMACALNOELG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public CCGGNCBEAHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6421DA0", Offset = "0x6420BA0", VA = "0x186421DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6422390", Offset = "0x6421190", VA = "0x186422390", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EAADBPBOAGM : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public EAADBPBOAGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x64229D0", Offset = "0x64217D0", VA = "0x1864229D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6422A40", Offset = "0x6421840", VA = "0x186422A40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NGDKAMAJONG;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<DABGCPKJLPM> DGFKACFDIBJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> MJLAADFEOCN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static DPFFPCFAMJN FPANGDDCKJO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LAHGIAIMNPD = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool MKOFMAFEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int BNLIAHFKJFM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private BJGKLAGHGJB category;

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
		private ParticleSystem.MinMaxGradient[] PEOCCMILOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool GHFJJKNOPPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float HGPIBHGIHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float GGPBLGHLDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform OGPDNDKFLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 PHMACBCGFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 OOOPIIDKEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CJGOEDDCOBP IFEHNAPKJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private DPFFPCFAMJN BDHDIEDFJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool POJLFCGKIGA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> IIGPBINNDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x64270F0", Offset = "0x6425EF0", VA = "0x1864270F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BJGKLAGHGJB MECDAELPCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7D7BB0", Offset = "0x7D69B0", VA = "0x1807D7BB0")]
			get
			{
				return default(BJGKLAGHGJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CKIJEFAAAEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EHLPLJOEEHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6426E40", Offset = "0x6425C40", VA = "0x186426E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int NOMFEKKEGLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6426FB0", Offset = "0x6425DB0", VA = "0x186426FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IHOIJDMIIGO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6424120", Offset = "0x6422F20", VA = "0x186424120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem MGFMLAFOKIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] MABMFLMHEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] DNIEDLJLPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BA8A0", Offset = "0x7B96A0", VA = "0x1807BA8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private CJGOEDDCOBP CCMOOEKBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xE9FCE0", Offset = "0xE9EAE0", VA = "0x180E9FCE0")]
			get
			{
				return default(CJGOEDDCOBP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6424E80", Offset = "0x6423C80", VA = "0x186424E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PFNADAPOCDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6426DA0", Offset = "0x6425BA0", VA = "0x186426DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6427140", Offset = "0x6425F40", VA = "0x186427140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6426760", Offset = "0x6425560", VA = "0x186426760")]
		public static PooledParticle TryPlayPrefab(PooledParticle IHFDHAEOMFG, Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64268D0", Offset = "0x64256D0", VA = "0x1864268D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle IHFDHAEOMFG, Vector3 JPLKOMKCHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6425E10", Offset = "0x6424C10", VA = "0x186425E10")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6424AC0", Offset = "0x64238C0", VA = "0x186424AC0")]
		private void LJJCJHLBHIH(bool AIBEMFNIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x64248D0", Offset = "0x64236D0", VA = "0x1864248D0")]
		[IteratorStateMachine(typeof(CCGGNCBEAHJ))]
		private static IEnumerator<KMOACDBBKNB> IPDAIKBAAEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6424EA0", Offset = "0x6423CA0", VA = "0x186424EA0")]
		private static void PHNOLGGCBFE(Stopwatch DPOENBOPPGM, Vector3 DLMIOJDPCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6424070", Offset = "0x6422E70", VA = "0x186424070")]
		private static int DOGAFLLPOLI(PooledParticle MAEINFGKCEL, PooledParticle FLBFHNBPNFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6423DA0", Offset = "0x6422BA0", VA = "0x186423DA0")]
		private static int BDCGCMIKOEG(BJGKLAGHGJB BELJPLDIFOP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64251E0", Offset = "0x6423FE0", VA = "0x1864251E0")]
		protected void PMNLDFFHHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x64241A0", Offset = "0x6422FA0", VA = "0x1864241A0")]
		protected void GIHGOGLLGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6423A50", Offset = "0x6422850", VA = "0x186423A50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6424B90", Offset = "0x6423990", VA = "0x186424B90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6424E00", Offset = "0x6423C00", VA = "0x186424E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6423EA0", Offset = "0x6422CA0", VA = "0x186423EA0")]
		[IteratorStateMachine(typeof(EAADBPBOAGM))]
		private IEnumerator<KMOACDBBKNB> BOCIAGAIGIG(float GAPIMALKIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6424770", Offset = "0x6423570", VA = "0x186424770")]
		private void IHAHIMEKHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6426570", Offset = "0x6425370", VA = "0x186426570")]
		public void SetDuration(float GAPIMALKIHE, bool EDEAJMJIDHN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64253D0", Offset = "0x64241D0", VA = "0x1864253D0")]
		public void Play(Transform LCFHFIOEIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6425A80", Offset = "0x6424880", VA = "0x186425A80")]
		public void Play(Transform LCFHFIOEIGM, bool LAAEAEEBOGJ, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6425530", Offset = "0x6424330", VA = "0x186425530")]
		public void Play(Transform LCFHFIOEIGM, Vector3 OOOPIIDKEJE, bool LAAEAEEBOGJ, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6425680", Offset = "0x6424480", VA = "0x186425680")]
		public void Play(Transform MPDKPHHOPOM, Quaternion IHHAEIJMAPE, bool LAAEAEEBOGJ = false, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6425BF0", Offset = "0x64249F0", VA = "0x186425BF0")]
		public void Play(Transform MPDKPHHOPOM, Vector3 OOOPIIDKEJE, Quaternion IHHAEIJMAPE, bool LAAEAEEBOGJ = false, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64258A0", Offset = "0x64246A0", VA = "0x1864258A0")]
		public void Play(Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, Vector3 PKCNPDCOCJE, bool LAAEAEEBOGJ = false, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64257E0", Offset = "0x64245E0", VA = "0x1864257E0")]
		public void Play(Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, bool LAAEAEEBOGJ = false, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6425970", Offset = "0x6424770", VA = "0x186425970")]
		public void Play(bool LAAEAEEBOGJ = false, float HKCBALLIDLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64266D0", Offset = "0x64254D0", VA = "0x1864266D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6426640", Offset = "0x6425440", VA = "0x186426640")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6424930", Offset = "0x6423730", VA = "0x186424930")]
		private void LAJMDOCBMDK(float GAPIMALKIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6423F30", Offset = "0x6422D30", VA = "0x186423F30")]
		private void DNJEFKDHJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6425D20", Offset = "0x6424B20", VA = "0x186425D20")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6425F90", Offset = "0x6424D90", VA = "0x186425F90")]
		public void SetColor(Color BGJPICBMDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6423C70", Offset = "0x6422A70", VA = "0x186423C70")]
		private void BBFHDILEBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6426D10", Offset = "0x6425B10", VA = "0x186426D10")]
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
