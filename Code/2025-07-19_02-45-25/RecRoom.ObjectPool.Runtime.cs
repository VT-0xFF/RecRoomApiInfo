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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8527090", Offset = "0x8526090", VA = "0x188527090")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OCKHDKNFOGO, float PAMONLDLGED, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8526D30", Offset = "0x8525D30", VA = "0x188526D30")]
		public void SetDamageValue(float PAMONLDLGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85271D0", Offset = "0x85261D0", VA = "0x1885271D0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OMINEPJNHDI<T> : KPIPLFECKNC<T>, JCFICNGFDLA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JDFELNPFLII<T> : JCFICNGFDLA, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGAJOCEJBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PEOMJIKHNGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FEMPPHIBCDL<T> : PFLOHFCJELO<T>, OMINEPJNHDI<T>, KPIPLFECKNC<T>, JCFICNGFDLA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NLKPMJGMGDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FEMPPHIBCDL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public NLKPMJGMGDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x57988D0", Offset = "0x57978D0", VA = "0x1857988D0")]
			internal void IPHOKKAPDOM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3D69C90", Offset = "0x3D68C90", VA = "0x183D69C90")]
			internal void CIKAONDHCLP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PHNCGCCJBCF<T> MOBJBCJNIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KMGEDJEAOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T KLKDHLJDBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MCHGOAKENIE;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D892D0", Offset = "0x4D882D0", VA = "0x184D892D0")]
		public FEMPPHIBCDL(PHNCGCCJBCF<T> MOBJBCJNIAE, ObjectPool KMGEDJEAOBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D89190", Offset = "0x4D88190", VA = "0x184D89190", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AAMHDFDGNKM<T> : JFNOOGODOOA, JDFELNPFLII<T>, JCFICNGFDLA, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PEALBKKJAAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AAMHDFDGNKM<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public PEALBKKJAAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A38740", Offset = "0x5A37740", VA = "0x185A38740")]
			internal void IPHOKKAPDOM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x165ED70", Offset = "0x165DD70", VA = "0x18165ED70")]
			internal void CIKAONDHCLP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PHNCGCCJBCF<T> MOBJBCJNIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MCHGOAKENIE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50BEC60", Offset = "0x50BDC60", VA = "0x1850BEC60")]
		public AAMHDFDGNKM(PHNCGCCJBCF<T> MOBJBCJNIAE, ObjectPool KMGEDJEAOBN, int NDKIFINEEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x50BEC00", Offset = "0x50BDC00", VA = "0x1850BEC00", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MJHBMJLHOPM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PEOMJIKHNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PFLOHFCJELO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PHNCGCCJBCF<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MJHBMJLHOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56DC080", Offset = "0x56DB080", VA = "0x1856DC080")]
		internal void OENEBECGNLH(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56DC020", Offset = "0x56DB020", VA = "0x1856DC020")]
		internal void HHCEDJMHHLA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56DBFD0", Offset = "0x56DAFD0", VA = "0x1856DBFD0")]
		internal void GFONHKFHKGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<MGAJOCEJBEO> LDNEPOICCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ACCKLBAENAA GEGOHJJOCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KMGEDJEAOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8526330", Offset = "0x8525330", VA = "0x188526330")]
	private static void CKBMICMNBGO(Component LDEFIHHDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8526840", Offset = "0x8525840", VA = "0x188526840")]
	public PEOMJIKHNGA(string NGBNCPKJGKC, int APDKEEANEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E37A40", Offset = "0x3E36A40", VA = "0x183E37A40")]
	public OMINEPJNHDI<T> LHJKIDHMHHP<T>(AssetReference LKCBNIGJDFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E375A0", Offset = "0x3E365A0", VA = "0x183E375A0")]
	public JDFELNPFLII<T> AMHEMLILDOE<T>(AssetReference LKCBNIGJDFI, int MFFPIAPMHCN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E37650", Offset = "0x3E36650", VA = "0x183E37650")]
	public KPIPLFECKNC<bool> KLJIOEKBNLN<T>(AssetReference LKCBNIGJDFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8526580", Offset = "0x8525580", VA = "0x188526580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8526670", Offset = "0x8525670", VA = "0x188526670")]
	private void OGAEJLOPNHI(UnityEngine.Object JIJOLLBNLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85261A0", Offset = "0x85251A0", VA = "0x1885261A0")]
	private ObjectPool BODHLKDMGHB(string NGBNCPKJGKC)
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
		private static GlobalPool CDKAGGBGIII;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ALCJCBOLNDG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool KONBGMLOLPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8525000", Offset = "0x8524000", VA = "0x188525000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C67A40", Offset = "0x3C66A40", VA = "0x183C67A40")]
		public static void SafeRelease<T>(T PGIOEBKALDP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8524F30", Offset = "0x8523F30", VA = "0x188524F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8524FF0", Offset = "0x8523FF0", VA = "0x188524FF0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, HMIJHODNCKG> EBBBHPDNJKH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E30D80", Offset = "0x3E2FD80", VA = "0x183E30D80")]
		public T Acquire<T>(T OCKHDKNFOGO, [Optional] Action<Component> MLGKEMOIKGO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E310F0", Offset = "0x3E300F0", VA = "0x183E310F0")]
		public bool Release<T>(T PGIOEBKALDP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E310A0", Offset = "0x3E300A0", VA = "0x183E310A0")]
		public void Prefill<T>(T OCKHDKNFOGO, int LOBFANMJLHD, [Optional] Action<Component> DHAOLACBIGA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E31000", Offset = "0x3E30000", VA = "0x183E31000")]
		public bool Exists<T>(T OCKHDKNFOGO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E30E10", Offset = "0x3E2FE10", VA = "0x183E30E10")]
		public void Clear<T>(T OCKHDKNFOGO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8525FA0", Offset = "0x8524FA0", VA = "0x188525FA0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E30EC0", Offset = "0x3E2FEC0", VA = "0x183E30EC0")]
		private HMIJHODNCKG ENDLFAIGKOC<T>(T OCKHDKNFOGO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public void TrackInstantiation(string PBIHDPEFMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public void EnableStats(bool IMBKJHOGODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8526110", Offset = "0x8525110", VA = "0x188526110")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class HMIJHODNCKG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CMGPNCMNHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CAICHOHGKBL(bool OJKKBHHDPOF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int FMFEFMIHFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void AMHEMLILDOE(int MFFPIAPMHCN, Action<Component> DHAOLACBIGA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component LHJKIDHMHHP(Action<Component> MLGKEMOIKGO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool ECPMCGAOIHB(Component BBHPMOACMFB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void JPJFAMEFLHG();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85253F0", Offset = "0x85243F0", VA = "0x1885253F0")]
	protected void IKDGBFDEPAJ(Component PGIOEBKALDP, bool OJKKBHHDPOF, bool FJGGGACFOLA, bool BDKGIDGOCKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8525170", Offset = "0x8524170", VA = "0x188525170")]
	protected void BLEKDHGGCMK(Transform HKCBPFKFCMM, bool OJKKBHHDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected HMIJHODNCKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EPEMEAGMFIN<T> : HMIJHODNCKG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T OCKHDKNFOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool CPIAGJIMNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FJGGGACFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> NPODKEHCENL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4928DB0", Offset = "0x4927DB0", VA = "0x184928DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int FMFEFMIHFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4929650", Offset = "0x4928650", VA = "0x184929650", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4929690", Offset = "0x4928690", VA = "0x184929690")]
	public EPEMEAGMFIN(T OCKHDKNFOGO, ObjectPool CPIAGJIMNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4928DD0", Offset = "0x4927DD0", VA = "0x184928DD0", Slot = "6")]
	public override void AMHEMLILDOE(int MFFPIAPMHCN, Action<Component> MLGKEMOIKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49293F0", Offset = "0x49283F0", VA = "0x1849293F0", Slot = "7")]
	public override Component LHJKIDHMHHP(Action<Component> MLGKEMOIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4929080", Offset = "0x4928080", VA = "0x184929080", Slot = "8")]
	public override bool ECPMCGAOIHB(Component BBHPMOACMFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4929210", Offset = "0x4928210", VA = "0x184929210", Slot = "9")]
	public override void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4928ED0", Offset = "0x4927ED0", VA = "0x184928ED0")]
	private T CBOJCJFIGMA()
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
		public interface OEHJOLIKPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject FMEKOCOHDGD
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
		[Cpp2IlInjected.Address(RVA = "0x8525C20", Offset = "0x8524C20", VA = "0x188525C20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8525F10", Offset = "0x8524F10", VA = "0x188525F10")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CDKAGGBGIII;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ALCJCBOLNDG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool KONBGMLOLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8526B90", Offset = "0x8525B90", VA = "0x188526B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8526AD0", Offset = "0x8525AD0", VA = "0x188526AD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8524FF0", Offset = "0x8523FF0", VA = "0x188524FF0")]
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
		public HMIJHODNCKG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MCGKDIPOAAC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OJLEDCGDAIP(PooledParticle.LEEGDMIGJLA AJJONCKACFM);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum EKFFOKFMKNF
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum LEEGDMIGJLA
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface MMKINAJLEIC
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool OJDJMIHDMCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 EOPLJBFMOBD
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera IKLEHCKGJCF
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x70E54C0", Offset = "0x70E44C0", VA = "0x1870E54C0")]
			public ColorConfiguration(ParticleSystem PDONLFIGOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8524C80", Offset = "0x8523C80", VA = "0x188524C80")]
			public void LACEALEKEFI(Color AHIICABHHJO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LAOJEPAFNMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public LAOJEPAFNMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8525BF0", Offset = "0x8524BF0", VA = "0x188525BF0")]
			internal void KKPIBIHKJLL(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IHMFDNNMOJN : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private CMMCHACHDBH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MMKINAJLEIC <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public IHMFDNNMOJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8525570", Offset = "0x8524570", VA = "0x188525570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8525BA0", Offset = "0x8524BA0", VA = "0x188525BA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DKMIAGAKHON : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private CMMCHACHDBH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public DKMIAGAKHON(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8524E70", Offset = "0x8523E70", VA = "0x188524E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8524EE0", Offset = "0x8523EE0", VA = "0x188524EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NHDENGMPKJH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<MCGKDIPOAAC> GKHDGBNKEJF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> HOJILBOFADN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static HHGNPNNJJPG GKOIKBMDICF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float MLJMBAJLIFI = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool KGPCMNJHEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int BDBKEAPENDP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private LEEGDMIGJLA category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? DLAFGHHGPIF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] GBLPKGEMDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] KOJLCBOJJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool BBCOFOABEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float JMIJMEKGBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float JLIGAJPMEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform FKPHCGHECHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 DGMLPLEMKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 PGMOKLDOLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EKFFOKFMKNF LFDLEKNPCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private HHGNPNNJJPG EMDOCLJGICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool FEMBKJFOLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Transform IKIDCDOOPHC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> PMBDDBNGBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x852AFB0", Offset = "0x8529FB0", VA = "0x18852AFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LEEGDMIGJLA CDAPJBDFFFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			get
			{
				return default(LEEGDMIGJLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int GOJAJDPDGDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EDNAKOIKBKC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x852ACE0", Offset = "0x8529CE0", VA = "0x18852ACE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int PNMDADDMPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x852AE60", Offset = "0x8529E60", VA = "0x18852AE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool OAOONPCLJBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8527EF0", Offset = "0x8526EF0", VA = "0x188527EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem IPBKMGOKPMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] FFIPBEPJFII
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] CBBMIHEHEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EKFFOKFMKNF GOCBACEELJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xEF07B0", Offset = "0xEEF7B0", VA = "0x180EF07B0")]
			get
			{
				return default(EKFFOKFMKNF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x85285C0", Offset = "0x85275C0", VA = "0x1885285C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform PLPGMCABFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x852B000", Offset = "0x852A000", VA = "0x18852B000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LMLNGAJOCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x852AC40", Offset = "0x8529C40", VA = "0x18852AC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x852B050", Offset = "0x852A050", VA = "0x18852B050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x852A650", Offset = "0x8529650", VA = "0x18852A650")]
		public static PooledParticle TryPlayPrefab(PooledParticle OCKHDKNFOGO, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x852A770", Offset = "0x8529770", VA = "0x18852A770")]
		public static PooledParticle TryPlayPrefab(PooledParticle OCKHDKNFOGO, Vector3 EBGKGBGFPOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8529D60", Offset = "0x8528D60", VA = "0x188529D60")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8527620", Offset = "0x8526620", VA = "0x188527620")]
		private void APELFNOCPEM(bool DAKNLGLKCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8529020", Offset = "0x8528020", VA = "0x188529020")]
		[IteratorStateMachine(typeof(IHMFDNNMOJN))]
		private static IEnumerator<CMMCHACHDBH> POJINEBEPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85272B0", Offset = "0x85262B0", VA = "0x1885272B0")]
		private static void AJLIKPGPEEM(Stopwatch HDAJLMNMKDM, Vector3 NNBLHCNPACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8527E40", Offset = "0x8526E40", VA = "0x188527E40")]
		private static int GBEDPHLBHLH(PooledParticle MLCJFBKFHOP, PooledParticle FPNPAOBAPAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8528C70", Offset = "0x8527C70", VA = "0x188528C70")]
		private static int OJLEDCGDAIP(LEEGDMIGJLA AJJONCKACFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85280A0", Offset = "0x85270A0", VA = "0x1885280A0")]
		protected void KMPAIJIJNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85285E0", Offset = "0x85275E0", VA = "0x1885285E0")]
		protected void MHONPIJCNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85276F0", Offset = "0x85266F0", VA = "0x1885276F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8528290", Offset = "0x8527290", VA = "0x188528290")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8528D80", Offset = "0x8527D80", VA = "0x188528D80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8528BE0", Offset = "0x8527BE0", VA = "0x188528BE0")]
		[IteratorStateMachine(typeof(DKMIAGAKHON))]
		private IEnumerator<CMMCHACHDBH> ODFFHGEMJAL(float MFKAPIFDPJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8527B80", Offset = "0x8526B80", VA = "0x188527B80")]
		private void ECPMCGAOIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x852A390", Offset = "0x8529390", VA = "0x18852A390")]
		public void SetDuration(float MFKAPIFDPJJ, bool NBOALCHCPJD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8529080", Offset = "0x8528080", VA = "0x188529080")]
		public void Play(Transform FPJKJFDABMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8529930", Offset = "0x8528930", VA = "0x188529930")]
		public void Play(Transform FPJKJFDABMO, bool HKCMJMIAACC, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85291E0", Offset = "0x85281E0", VA = "0x1885291E0")]
		public void Play(Transform FPJKJFDABMO, Vector3 PGMOKLDOLAC, bool HKCMJMIAACC, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8529330", Offset = "0x8528330", VA = "0x188529330")]
		public void Play(Transform LIBJBJIBBGE, Quaternion KDHLIJMPIFF, bool HKCMJMIAACC = false, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8529AA0", Offset = "0x8528AA0", VA = "0x188529AA0")]
		public void Play(Transform LIBJBJIBBGE, Vector3 PGMOKLDOLAC, Quaternion KDHLIJMPIFF, bool HKCMJMIAACC = false, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85295D0", Offset = "0x85285D0", VA = "0x1885295D0")]
		public void Play(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, Vector3 PJFEPLADHFM, bool HKCMJMIAACC = false, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8529470", Offset = "0x8528470", VA = "0x188529470")]
		public void Play(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, bool HKCMJMIAACC = false, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8529750", Offset = "0x8528750", VA = "0x188529750")]
		public void Play(bool HKCMJMIAACC = false, float IILELJGIDAG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x852A5B0", Offset = "0x85295B0", VA = "0x18852A5B0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x852A460", Offset = "0x8529460", VA = "0x18852A460")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8527970", Offset = "0x8526970", VA = "0x188527970")]
		private void BICGOBKIPEJ(float MFKAPIFDPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8528E10", Offset = "0x8527E10", VA = "0x188528E10")]
		private void PJNALOEHMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8529BD0", Offset = "0x8528BD0", VA = "0x188529BD0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8529EE0", Offset = "0x8528EE0", VA = "0x188529EE0")]
		public void SetColor(Color AHIICABHHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8527D80", Offset = "0x8526D80", VA = "0x188527D80")]
		private void EGBFCBHDDFJ(float? JAPNNLNNKKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8527B10", Offset = "0x8526B10", VA = "0x188527B10")]
		private void CHFKLKAJFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8527F70", Offset = "0x8526F70", VA = "0x188527F70")]
		private void KHMHNOJPNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x852ABA0", Offset = "0x8529BA0", VA = "0x18852ABA0")]
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
