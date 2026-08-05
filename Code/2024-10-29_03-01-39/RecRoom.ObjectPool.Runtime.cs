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
		[Cpp2IlInjected.Address(RVA = "0x71424C0", Offset = "0x71414C0", VA = "0x1871424C0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles MBJCMFAMEBD, float OGFHJOMPDOO, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7142160", Offset = "0x7141160", VA = "0x187142160")]
		public void SetDamageValue(float OGFHJOMPDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7142640", Offset = "0x7141640", VA = "0x187142640")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MIFBICIFKCB<T> : OBJFFICJNII<T>, KKJPAEAJCIM, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JFCHHKDCAJH<T> : KKJPAEAJCIM, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NJFBOFNIMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BGJNIILMMAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OLMBBFOIJMB<T> : DIGLOOLIBBM<T>, MIFBICIFKCB<T>, OBJFFICJNII<T>, KKJPAEAJCIM, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BLNHPGPKNEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OLMBBFOIJMB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public BLNHPGPKNEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x53624C0", Offset = "0x53614C0", VA = "0x1853624C0")]
			internal void LHMCPEBOPFA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2E76930", Offset = "0x2E75930", VA = "0x182E76930")]
			internal void NOEMCLGBEJF(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DIHMDMOKEDJ<T> BOJKEHHCCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GNMPMLEEKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T DKOIJBOMAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool PPKGDGFGJOG;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4B21E70", Offset = "0x4B20E70", VA = "0x184B21E70")]
		public OLMBBFOIJMB(DIHMDMOKEDJ<T> BOJKEHHCCDL, ObjectPool GNMPMLEEKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B21D00", Offset = "0x4B20D00", VA = "0x184B21D00", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CBEBGCEDHPD<T> : IIAHDMFNNHP, JFCHHKDCAJH<T>, KKJPAEAJCIM, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FGHCNMFBMFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CBEBGCEDHPD<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FGHCNMFBMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3FFAAE0", Offset = "0x3FF9AE0", VA = "0x183FFAAE0")]
			internal void LHMCPEBOPFA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xF82910", Offset = "0xF81910", VA = "0x180F82910")]
			internal void NOEMCLGBEJF(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DIHMDMOKEDJ<T> BOJKEHHCCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool PPKGDGFGJOG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57068D0", Offset = "0x57058D0", VA = "0x1857068D0")]
		public CBEBGCEDHPD(DIHMDMOKEDJ<T> BOJKEHHCCDL, ObjectPool GNMPMLEEKPE, int PKIEBBCJGDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5706870", Offset = "0x5705870", VA = "0x185706870", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OOLDEDADFDC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BGJNIILMMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DIGLOOLIBBM<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DIHMDMOKEDJ<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OOLDEDADFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B33260", Offset = "0x4B32260", VA = "0x184B33260")]
		internal void GAMBCFDOCNB(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B33200", Offset = "0x4B32200", VA = "0x184B33200")]
		internal void DKDHOCJFKID(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4B33310", Offset = "0x4B32310", VA = "0x184B33310")]
		internal void GDKLBLFGOKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NJFBOFNIMLM> KLGFMAPBIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PNIKDDKHIEL BCMDLLFMKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GNMPMLEEKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7140340", Offset = "0x713F340", VA = "0x187140340")]
	private static void FFIBMMJCDEG(Component GEICOLLOJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71407A0", Offset = "0x713F7A0", VA = "0x1871407A0")]
	public BGJNIILMMAC(string MHHGEPFPLHI, int LAEGFBOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF170", Offset = "0x2CFE170", VA = "0x182CFF170")]
	public MIFBICIFKCB<T> EDGCLAMDNDK<T>(AssetReference LEEBKLCALGO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF660", Offset = "0x2CFE660", VA = "0x182CFF660")]
	public JFCHHKDCAJH<T> LFPGAELEHAE<T>(AssetReference LEEBKLCALGO, int DCEOMHJEBBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF240", Offset = "0x2CFE240", VA = "0x182CFF240")]
	public OBJFFICJNII<bool> KDIAAAJKNAC<T>(AssetReference LEEBKLCALGO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7140110", Offset = "0x713F110", VA = "0x187140110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7140200", Offset = "0x713F200", VA = "0x187140200")]
	private void FDCNAEFAIIA(UnityEngine.Object INIMEJEGHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7140580", Offset = "0x713F580", VA = "0x187140580")]
	private ObjectPool JENHIDGMIKJ(string MHHGEPFPLHI)
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
		private static GlobalPool IOOACGMIAEM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject IIMNMOJPPBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7141450", Offset = "0x7140450", VA = "0x187141450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2F88F00", Offset = "0x2F87F00", VA = "0x182F88F00")]
		public static void SafeRelease<T>(T IFPBFCLBBDP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7141380", Offset = "0x7140380", VA = "0x187141380")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7141440", Offset = "0x7140440", VA = "0x187141440")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, KCAKCJPBECH> ONKGMMAJEGE;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x31509A0", Offset = "0x314F9A0", VA = "0x1831509A0")]
		public T Acquire<T>(T MBJCMFAMEBD, [Optional] Action<Component> IENHPADNIAN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3150D60", Offset = "0x314FD60", VA = "0x183150D60")]
		public bool Release<T>(T IFPBFCLBBDP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3150CF0", Offset = "0x314FCF0", VA = "0x183150CF0")]
		public void Prefill<T>(T MBJCMFAMEBD, int NMOAOCFEBFD, [Optional] Action<Component> LLEDLOCBAAF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3150B10", Offset = "0x314FB10", VA = "0x183150B10")]
		public bool Exists<T>(T MBJCMFAMEBD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3150A60", Offset = "0x314FA60", VA = "0x183150A60")]
		public void Clear<T>(T MBJCMFAMEBD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7141D20", Offset = "0x7140D20", VA = "0x187141D20")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3150BB0", Offset = "0x314FBB0", VA = "0x183150BB0")]
		private KCAKCJPBECH JNBJADLEJEF<T>(T MBJCMFAMEBD) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public void TrackInstantiation(string AICOLAJKFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public void EnableStats(bool CDEDIJLBCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7141E90", Offset = "0x7140E90", VA = "0x187141E90")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KCAKCJPBECH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OMGBFIDPIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EINBMAALGMG(bool PHLFEEMONCD);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int NCGKBOIAKON
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LFPGAELEHAE(int DCEOMHJEBBP, Action<Component> LLEDLOCBAAF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component EDGCLAMDNDK(Action<Component> IENHPADNIAN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool DIPKALJLHOB(Component NDEOLIKHBMH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EGPGCHCMHIK();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71415A0", Offset = "0x71405A0", VA = "0x1871415A0")]
	protected void DHHKBFHBOON(Component IFPBFCLBBDP, bool PHLFEEMONCD, bool KHIFMIEGCDC, bool MKCDGBAJCCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7141720", Offset = "0x7140720", VA = "0x187141720")]
	protected void IOMIIJFNGDB(Transform DFFECANJFDE, bool PHLFEEMONCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected KCAKCJPBECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JPFPNFOADIG<T> : KCAKCJPBECH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T MBJCMFAMEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool COPIKGNHLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool KHIFMIEGCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> EPFOJMHHFGP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x45BF180", Offset = "0x45BE180", VA = "0x1845BF180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int NCGKBOIAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45BEFF0", Offset = "0x45BDFF0", VA = "0x1845BEFF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x45BF320", Offset = "0x45BE320", VA = "0x1845BF320")]
	public JPFPNFOADIG(T MBJCMFAMEBD, ObjectPool COPIKGNHLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x45BF050", Offset = "0x45BE050", VA = "0x1845BF050", Slot = "6")]
	public override void LFPGAELEHAE(int DCEOMHJEBBP, Action<Component> IENHPADNIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x45BEB40", Offset = "0x45BDB40", VA = "0x1845BEB40", Slot = "7")]
	public override Component EDGCLAMDNDK(Action<Component> IENHPADNIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x45BE980", Offset = "0x45BD980", VA = "0x1845BE980", Slot = "8")]
	public override bool DIPKALJLHOB(Component NDEOLIKHBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x45BEDD0", Offset = "0x45BDDD0", VA = "0x1845BEDD0", Slot = "9")]
	public override void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45BF1A0", Offset = "0x45BE1A0", VA = "0x1845BF1A0")]
	private T NKDEAONBJCL()
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
		public interface EFFDCIGGNCM
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject AFDOELKDAHE
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
		[Cpp2IlInjected.Address(RVA = "0x71419A0", Offset = "0x71409A0", VA = "0x1871419A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7141C90", Offset = "0x7140C90", VA = "0x187141C90")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool IOOACGMIAEM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject IIMNMOJPPBF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7141FE0", Offset = "0x7140FE0", VA = "0x187141FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7141F20", Offset = "0x7140F20", VA = "0x187141F20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7141440", Offset = "0x7140440", VA = "0x187141440")]
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
		public KCAKCJPBECH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EOCLOHALPGM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PFAFFFGOGHE(PooledParticle.ONOGBBKKBKN GGGCMBBMAME);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum OFGCACMACNP
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
		public enum ONOGBBKKBKN
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
		public interface MMAOGJMMEKB
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool EOEKCHPGODO
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 HLLDDGEKGFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera KHKHJEMBCOB
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
			[Cpp2IlInjected.Address(RVA = "0x6041F30", Offset = "0x6040F30", VA = "0x186041F30")]
			public ColorConfiguration(ParticleSystem IBFIABKMJIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7140A30", Offset = "0x713FA30", VA = "0x187140A30")]
			public void BLADOCPAFKK(Color DANHKIEIFNH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FKAGKFEPIBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FKAGKFEPIBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7140C20", Offset = "0x713FC20", VA = "0x187140C20")]
			internal void JILBJKFGKHO(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GAFCAEAHIII : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private MMAOGJMMEKB <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public GAFCAEAHIII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7140C50", Offset = "0x713FC50", VA = "0x187140C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7141270", Offset = "0x7140270", VA = "0x187141270", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GOCCCAJOIAL : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public GOCCCAJOIAL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x71412C0", Offset = "0x71402C0", VA = "0x1871412C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7141330", Offset = "0x7140330", VA = "0x187141330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> PGHCNGJMFEH;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<EOCLOHALPGM> GOEDEFIMDJF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> HGAHKECAHBP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static DDGDFMBPLHP BBIMJPJGMGH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float CILBHDBBEPG = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool LFDALBLEGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int HABDKFKALAG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private ONOGBBKKBKN category;

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
		private ParticleSystem.MinMaxGradient[] PIGGGPCCBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool GJBPIIHEMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float AOMPDJOHLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KFGNLJKAGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JLGKFAPMJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 OAOHIFNAMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DBPNPMOPKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private OFGCACMACNP FGAHJKPMMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private DDGDFMBPLHP KCDGNMIHHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool ALGHKLJDIGN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> OCJLGNFKPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7145DF0", Offset = "0x7144DF0", VA = "0x187145DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ONOGBBKKBKN GGGOKJDFNEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAC0", Offset = "0x8DCAC0", VA = "0x1808DDAC0")]
			get
			{
				return default(ONOGBBKKBKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int FLDCMEMECPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PLIGKKFGJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144B40", VA = "0x187145B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int MBAICJHFPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7145CB0", Offset = "0x7144CB0", VA = "0x187145CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool BPCIIGOKEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7143E00", Offset = "0x7142E00", VA = "0x187143E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem GIMHPNOHDKP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] NOLLFCKGOAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] LMJAJFNLALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8B9ED0", Offset = "0x8B8ED0", VA = "0x1808B9ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OFGCACMACNP CEKJMLPIAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1404B50", Offset = "0x1403B50", VA = "0x181404B50")]
			get
			{
				return default(OFGCACMACNP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7143F30", Offset = "0x7142F30", VA = "0x187143F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NNGNNJKJKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7145AA0", Offset = "0x7144AA0", VA = "0x187145AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7145E40", Offset = "0x7144E40", VA = "0x187145E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7145460", Offset = "0x7144460", VA = "0x187145460")]
		public static PooledParticle TryPlayPrefab(PooledParticle MBJCMFAMEBD, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71455D0", Offset = "0x71445D0", VA = "0x1871455D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle MBJCMFAMEBD, Vector3 PAMMLHPIJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7144B20", Offset = "0x7143B20", VA = "0x187144B20")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7143980", Offset = "0x7142980", VA = "0x187143980")]
		private void LKOIANDBMIF(bool EJMENMMDJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7142A50", Offset = "0x7141A50", VA = "0x187142A50")]
		[IteratorStateMachine(typeof(GAFCAEAHIII))]
		private static IEnumerator<MIAEKAOKMEH> AKLNCPAGNKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7142710", Offset = "0x7141710", VA = "0x187142710")]
		private static void AAOEABNJPCP(Stopwatch FCPMHEOCJMB, Vector3 BAFNLLBCIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7143E80", Offset = "0x7142E80", VA = "0x187143E80")]
		private static int OJNOJDLGLLD(PooledParticle LOPBCKBMJBH, PooledParticle BMJGCJANGHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7143FD0", Offset = "0x7142FD0", VA = "0x187143FD0")]
		private static int PFAFFFGOGHE(ONOGBBKKBKN GGGCMBBMAME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7142EC0", Offset = "0x7141EC0", VA = "0x187142EC0")]
		protected void EHKKEJCCOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x71430B0", Offset = "0x71420B0", VA = "0x1871430B0")]
		protected void EIMGNPEKDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7142AB0", Offset = "0x7141AB0", VA = "0x187142AB0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7143A50", Offset = "0x7142A50", VA = "0x187143A50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7143F50", Offset = "0x7142F50", VA = "0x187143F50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7142CD0", Offset = "0x7141CD0", VA = "0x187142CD0")]
		[IteratorStateMachine(typeof(GOCCCAJOIAL))]
		private IEnumerator<MIAEKAOKMEH> CEODDEJCKHN(float DHLFCHNFAOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7142D60", Offset = "0x7141D60", VA = "0x187142D60")]
		private void DIPKALJLHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7145270", Offset = "0x7144270", VA = "0x187145270")]
		public void SetDuration(float DHLFCHNFAOO, bool KBJGDEEAMCD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71440E0", Offset = "0x71430E0", VA = "0x1871440E0")]
		public void Play(Transform FIOOAIFEBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7144790", Offset = "0x7143790", VA = "0x187144790")]
		public void Play(Transform FIOOAIFEBBM, bool MDNKFGNHDDP, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7144240", Offset = "0x7143240", VA = "0x187144240")]
		public void Play(Transform FIOOAIFEBBM, Vector3 DBPNPMOPKEC, bool MDNKFGNHDDP, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7144390", Offset = "0x7143390", VA = "0x187144390")]
		public void Play(Transform PANBMDKILKA, Quaternion JKJHCABJJIO, bool MDNKFGNHDDP = false, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7144900", Offset = "0x7143900", VA = "0x187144900")]
		public void Play(Transform PANBMDKILKA, Vector3 DBPNPMOPKEC, Quaternion JKJHCABJJIO, bool MDNKFGNHDDP = false, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x71445B0", Offset = "0x71435B0", VA = "0x1871445B0")]
		public void Play(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, Vector3 DLJIHGEKHEP, bool MDNKFGNHDDP = false, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x71444F0", Offset = "0x71434F0", VA = "0x1871444F0")]
		public void Play(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, bool MDNKFGNHDDP = false, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7144680", Offset = "0x7143680", VA = "0x187144680")]
		public void Play(bool MDNKFGNHDDP = false, float GOEEEKLNMEL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71453D0", Offset = "0x71443D0", VA = "0x1871453D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7145340", Offset = "0x7144340", VA = "0x187145340")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71437E0", Offset = "0x71427E0", VA = "0x1871437E0")]
		private void LHILAFBFJKG(float DHLFCHNFAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7143CC0", Offset = "0x7142CC0", VA = "0x187143CC0")]
		private void NCHGMGNAFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7144A30", Offset = "0x7143A30", VA = "0x187144A30")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7144CA0", Offset = "0x7143CA0", VA = "0x187144CA0")]
		public void SetColor(Color DANHKIEIFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71436B0", Offset = "0x71426B0", VA = "0x1871436B0")]
		private void JFCKCFHPHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7145A10", Offset = "0x7144A10", VA = "0x187145A10")]
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
