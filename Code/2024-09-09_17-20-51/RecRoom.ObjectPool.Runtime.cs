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
		[Cpp2IlInjected.Address(RVA = "0x6E272F0", Offset = "0x6E25CF0", VA = "0x186E272F0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IGOFBEPEIGI, float IMIKLBMFNCM, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E26F90", Offset = "0x6E25990", VA = "0x186E26F90")]
		public void SetDamageValue(float IMIKLBMFNCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E27470", Offset = "0x6E25E70", VA = "0x186E27470")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NNBEKIHKIFC<T> : HABLMKCEIGL<T>, KGIOENCPIOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PGAOGNMJPKM<T> : KGIOENCPIOK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OGDOFCBFBOB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LLEKPJLLEOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FNEAIFKPEOE<T> : NGCENHNNOLH<T>, NNBEKIHKIFC<T>, HABLMKCEIGL<T>, KGIOENCPIOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EFGKCBCHOCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FNEAIFKPEOE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public EFGKCBCHOCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3A0E8A0", Offset = "0x3A0D2A0", VA = "0x183A0E8A0")]
			internal void HNJIKPCIEHG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2BF8050", Offset = "0x2BF6A50", VA = "0x182BF8050")]
			internal void BPPEMKOAMMP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NNLLBGLJADF<T> ONOMPOCGMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool ONJHPOPHBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MHOPBKMJKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NMOEEADIFFA;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E06340", Offset = "0x3E04D40", VA = "0x183E06340")]
		public FNEAIFKPEOE(NNLLBGLJADF<T> ONOMPOCGMLG, ObjectPool ONJHPOPHBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E061D0", Offset = "0x3E04BD0", VA = "0x183E061D0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NCOHHPMMJKN<T> : BAEJNDBEMHP, PGAOGNMJPKM<T>, KGIOENCPIOK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CKOFGJKBHLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NCOHHPMMJKN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public CKOFGJKBHLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x55CA2F0", Offset = "0x55C8CF0", VA = "0x1855CA2F0")]
			internal void HNJIKPCIEHG(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xDED4D0", Offset = "0xDEBED0", VA = "0x180DED4D0")]
			internal void BPPEMKOAMMP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NNLLBGLJADF<T> ONOMPOCGMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool NMOEEADIFFA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4792770", Offset = "0x4791170", VA = "0x184792770")]
		public NCOHHPMMJKN(NNLLBGLJADF<T> ONOMPOCGMLG, ObjectPool ONJHPOPHBBB, int MENPFBMDKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4792710", Offset = "0x4791110", VA = "0x184792710", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EEAAGAIJPAB<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LLEKPJLLEOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NGCENHNNOLH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NNLLBGLJADF<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EEAAGAIJPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A05190", Offset = "0x3A03B90", VA = "0x183A05190")]
		internal void MFILMPICGME(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3A050E0", Offset = "0x3A03AE0", VA = "0x183A050E0")]
		internal void FCHICCLNEKI(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3A05140", Offset = "0x3A03B40", VA = "0x183A05140")]
		internal void IOPKKJBENDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<OGDOFCBFBOB> AKIEKHNKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private JHOEGELAEOP IOIFPFHLLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool ONJHPOPHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E26120", Offset = "0x6E24B20", VA = "0x186E26120")]
	private static void GGCFDBPGMIL(Component ANHGADCFANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E26540", Offset = "0x6E24F40", VA = "0x186E26540")]
	public LLEKPJLLEOF(string JOGNFAPCOHE, int NAHHKJAKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E52BF0", Offset = "0x2E515F0", VA = "0x182E52BF0")]
	public NNBEKIHKIFC<T> DJJCLMNJKEF<T>(AssetReference PJDFBOFKBGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E52CC0", Offset = "0x2E516C0", VA = "0x182E52CC0")]
	public PGAOGNMJPKM<T> EACLBHOAAGL<T>(AssetReference PJDFBOFKBGN, int CMNDBGDABDM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E52DA0", Offset = "0x2E517A0", VA = "0x182E52DA0")]
	public HABLMKCEIGL<bool> GHBEHEKGDOG<T>(AssetReference PJDFBOFKBGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E25EA0", Offset = "0x6E248A0", VA = "0x186E25EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E26360", Offset = "0x6E24D60", VA = "0x186E26360")]
	private void IKHCDDEPMMI(UnityEngine.Object JKCFJMIBMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E25F90", Offset = "0x6E24990", VA = "0x186E25F90")]
	private ObjectPool GGBLJPNEPIJ(string JOGNFAPCOHE)
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
		private static GlobalPool KHNFDPNFCEA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject APEKLBKFABO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E25D50", Offset = "0x6E24750", VA = "0x186E25D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2D76340", Offset = "0x2D74D40", VA = "0x182D76340")]
		public static void SafeRelease<T>(T FHFDEAHMMBI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E25C80", Offset = "0x6E24680", VA = "0x186E25C80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E25D40", Offset = "0x6E24740", VA = "0x186E25D40")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, CEPIJCJGKLC> GOIKLNCJKMC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2F05160", Offset = "0x2F03B60", VA = "0x182F05160")]
		public T Acquire<T>(T IGOFBEPEIGI, [Optional] Action<Component> IHOFBCCDFMO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F05520", Offset = "0x2F03F20", VA = "0x182F05520")]
		public bool Release<T>(T FHFDEAHMMBI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2F054B0", Offset = "0x2F03EB0", VA = "0x182F054B0")]
		public void Prefill<T>(T IGOFBEPEIGI, int NMCBMEPPNPB, [Optional] Action<Component> IMFHPGIOLPA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2F052D0", Offset = "0x2F03CD0", VA = "0x182F052D0")]
		public bool Exists<T>(T IGOFBEPEIGI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2F05220", Offset = "0x2F03C20", VA = "0x182F05220")]
		public void Clear<T>(T IGOFBEPEIGI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E26B50", Offset = "0x6E25550", VA = "0x186E26B50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2F05370", Offset = "0x2F03D70", VA = "0x182F05370")]
		private CEPIJCJGKLC MJFBFKINNMA<T>(T IGOFBEPEIGI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public void TrackInstantiation(string HKHFEAGOHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public void EnableStats(bool IHJGEPPNIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E26CC0", Offset = "0x6E256C0", VA = "0x186E26CC0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class CEPIJCJGKLC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EFDCDMDPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HOMIIBBPMGD(bool GJHDHJFGOFN);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int CLAGJDONJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void EACLBHOAAGL(int CMNDBGDABDM, Action<Component> IMFHPGIOLPA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component DJJCLMNJKEF(Action<Component> IHOFBCCDFMO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool CADFCIHNIMB(Component DHMHMCMKLBP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ODPBLJHKGDP();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E24FF0", Offset = "0x6E239F0", VA = "0x186E24FF0")]
	protected void DGMDADMDDKD(Component FHFDEAHMMBI, bool GJHDHJFGOFN, bool FMKDCJIPFNE, bool IMKINLNGPOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E25170", Offset = "0x6E23B70", VA = "0x186E25170")]
	protected void LIODAJNLCJA(Transform FAICPINNPHJ, bool GJHDHJFGOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected CEPIJCJGKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IPNOHABMPGP<T> : CEPIJCJGKLC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T IGOFBEPEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool PMIGAJFKJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FMKDCJIPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> GFJGGBJENPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x40D6480", Offset = "0x40D4E80", VA = "0x1840D6480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int CLAGJDONJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x40D6DA0", Offset = "0x40D57A0", VA = "0x1840D6DA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x40D6DF0", Offset = "0x40D57F0", VA = "0x1840D6DF0")]
	public IPNOHABMPGP(T IGOFBEPEIGI, ObjectPool PMIGAJFKJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40D68E0", Offset = "0x40D52E0", VA = "0x1840D68E0", Slot = "6")]
	public override void EACLBHOAAGL(int CMNDBGDABDM, Action<Component> IHOFBCCDFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40D6650", Offset = "0x40D5050", VA = "0x1840D6650", Slot = "7")]
	public override Component DJJCLMNJKEF(Action<Component> IHOFBCCDFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40D64A0", Offset = "0x40D4EA0", VA = "0x1840D64A0", Slot = "8")]
	public override bool CADFCIHNIMB(Component DHMHMCMKLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40D6B90", Offset = "0x40D5590", VA = "0x1840D6B90", Slot = "9")]
	public override void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40D6A10", Offset = "0x40D5410", VA = "0x1840D6A10")]
	private T LNPJFOBLBNG()
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
		public interface DADOKJMLOEM
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject BDKFKIGCKLK
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
		[Cpp2IlInjected.Address(RVA = "0x6E267D0", Offset = "0x6E251D0", VA = "0x186E267D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E26AC0", Offset = "0x6E254C0", VA = "0x186E26AC0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KHNFDPNFCEA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject APEKLBKFABO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6E26E10", Offset = "0x6E25810", VA = "0x186E26E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E26D50", Offset = "0x6E25750", VA = "0x186E26D50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6E25D40", Offset = "0x6E24740", VA = "0x186E25D40")]
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
		public CEPIJCJGKLC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LIJFNAOMDOM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MHOFPIJDMLM(PooledParticle.GNMJDJNNJFF DDIOFMABBBG);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JPIIBLGBOBI
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
		public enum GNMJDJNNJFF
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
		public interface NDMCECEOEEG
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			bool FILONHMONCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			Vector3 KEPAFNBCOMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Camera MBBNLCIEGNH
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
			[Cpp2IlInjected.Address(RVA = "0x5D4A700", Offset = "0x5D49100", VA = "0x185D4A700")]
			public ColorConfiguration(ParticleSystem OAFOFEALPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6E253F0", Offset = "0x6E23DF0", VA = "0x186E253F0")]
			public void HMMOHDKMJGC(Color BJCIGJMGMBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GHIPHBKEFOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GHIPHBKEFOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6E25C50", Offset = "0x6E24650", VA = "0x186E25C50")]
			internal void HGDHCFGGCFE(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EDFNDPIOPJN : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private DKMFPOPNNKA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private NDMCECEOEEG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
			[DebuggerHidden]
			public EDFNDPIOPJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E255E0", Offset = "0x6E23FE0", VA = "0x186E255E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6E25C00", Offset = "0x6E24600", VA = "0x186E25C00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BAAEKKOJGGP : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private DKMFPOPNNKA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
			[DebuggerHidden]
			public BAAEKKOJGGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6E24F30", Offset = "0x6E23930", VA = "0x186E24F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6E24FA0", Offset = "0x6E239A0", VA = "0x186E24FA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> EMEAEAABLNL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<LIJFNAOMDOM> OPBHEHPECHF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> BFEJMJFCGIH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static CHBCKIOGPHP ANNNJADAMCH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float EJFFHHHMKPI = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool KCCDGMIAHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int FPABJGBJJHJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private GNMJDJNNJFF category;

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
		private ParticleSystem.MinMaxGradient[] CMADEHKNCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool BEJOMMGOHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LHKAMDJGCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float CDJLAFNMIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform HDNPMHOBBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 AJOEFPCKLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 EJMCDMELLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JPIIBLGBOBI LODMLPBDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CHBCKIOGPHP FCEGOFDOPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool OBBHCEBFACC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> EJJLKGMJFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E2AC20", Offset = "0x6E29620", VA = "0x186E2AC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public GNMJDJNNJFF FCGJLGBCGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8AC4A0", Offset = "0x8AAEA0", VA = "0x1808AC4A0")]
			get
			{
				return default(GNMJDJNNJFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int IKMNGLKHFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LPLMCBCEJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E2A970", Offset = "0x6E29370", VA = "0x186E2A970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int PCJNHACFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6E2AAE0", Offset = "0x6E294E0", VA = "0x186E2AAE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool CDAONNIPDOK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E280E0", Offset = "0x6E26AE0", VA = "0x186E280E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem IIHMHLEJABK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] HECGNKNMIAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] LOBKHPCDLDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JPIIBLGBOBI NKCDAPEBCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x124B9E0", Offset = "0x124A3E0", VA = "0x18124B9E0")]
			get
			{
				return default(JPIIBLGBOBI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E27EC0", Offset = "0x6E268C0", VA = "0x186E27EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ODCEPDJNKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E2A8D0", Offset = "0x6E292D0", VA = "0x186E2A8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E2AC70", Offset = "0x6E29670", VA = "0x186E2AC70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A290", Offset = "0x6E28C90", VA = "0x186E2A290")]
		public static PooledParticle TryPlayPrefab(PooledParticle IGOFBEPEIGI, Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A400", Offset = "0x6E28E00", VA = "0x186E2A400")]
		public static PooledParticle TryPlayPrefab(PooledParticle IGOFBEPEIGI, Vector3 EJEBFMEPKGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E29950", Offset = "0x6E28350", VA = "0x186E29950")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E27AA0", Offset = "0x6E264A0", VA = "0x186E27AA0")]
		private void BJPPFMNOAJB(bool MPFEOFHFNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E28080", Offset = "0x6E26A80", VA = "0x186E28080")]
		[IteratorStateMachine(typeof(EDFNDPIOPJN))]
		private static IEnumerator<DKMFPOPNNKA> HJMIHJDPBOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E27540", Offset = "0x6E25F40", VA = "0x186E27540")]
		private static void AINEJFONEHH(Stopwatch MBHLFFACPEB, Vector3 KLFEFEHNNOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E286A0", Offset = "0x6E270A0", VA = "0x186E286A0")]
		private static int NGOELIEKMAE(PooledParticle MFLKJAHENBP, PooledParticle PLHCHKLJLJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E28590", Offset = "0x6E26F90", VA = "0x186E28590")]
		private static int MHOFPIJDMLM(GNMJDJNNJFF DDIOFMABBBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E27CD0", Offset = "0x6E266D0", VA = "0x186E27CD0")]
		protected void GALNMKDGFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E28750", Offset = "0x6E27150", VA = "0x186E28750")]
		protected void NODDIBEBIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E27880", Offset = "0x6E26280", VA = "0x186E27880", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E28320", Offset = "0x6E26D20", VA = "0x186E28320")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E28D50", Offset = "0x6E27750", VA = "0x186E28D50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E28160", Offset = "0x6E26B60", VA = "0x186E28160")]
		[IteratorStateMachine(typeof(BAAEKKOJGGP))]
		private IEnumerator<DKMFPOPNNKA> KBMLGJPEDGP(float GLIHGPEPPCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E27B70", Offset = "0x6E26570", VA = "0x186E27B70")]
		private void CADFCIHNIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A0A0", Offset = "0x6E28AA0", VA = "0x186E2A0A0")]
		public void SetDuration(float GLIHGPEPPCD, bool EBGLLECDJGE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E28F10", Offset = "0x6E27910", VA = "0x186E28F10")]
		public void Play(Transform BKLMAADIHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E295C0", Offset = "0x6E27FC0", VA = "0x186E295C0")]
		public void Play(Transform BKLMAADIHMK, bool PEJPOMDLJOF, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E29070", Offset = "0x6E27A70", VA = "0x186E29070")]
		public void Play(Transform BKLMAADIHMK, Vector3 EJMCDMELLBG, bool PEJPOMDLJOF, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E291C0", Offset = "0x6E27BC0", VA = "0x186E291C0")]
		public void Play(Transform JMFBAEAHPCI, Quaternion PCIAHIPKDFG, bool PEJPOMDLJOF = false, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E29730", Offset = "0x6E28130", VA = "0x186E29730")]
		public void Play(Transform JMFBAEAHPCI, Vector3 EJMCDMELLBG, Quaternion PCIAHIPKDFG, bool PEJPOMDLJOF = false, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E293E0", Offset = "0x6E27DE0", VA = "0x186E293E0")]
		public void Play(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, Vector3 DPBIGMHBMBN, bool PEJPOMDLJOF = false, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E29320", Offset = "0x6E27D20", VA = "0x186E29320")]
		public void Play(Vector3 EJEBFMEPKGF, Quaternion PCIAHIPKDFG, bool PEJPOMDLJOF = false, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E294B0", Offset = "0x6E27EB0", VA = "0x186E294B0")]
		public void Play(bool PEJPOMDLJOF = false, float GLEFIHBIFNH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A200", Offset = "0x6E28C00", VA = "0x186E2A200")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A170", Offset = "0x6E28B70", VA = "0x186E2A170")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E27EE0", Offset = "0x6E268E0", VA = "0x186E27EE0")]
		private void GJGEGPPEKGP(float GLIHGPEPPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E28DD0", Offset = "0x6E277D0", VA = "0x186E28DD0")]
		private void PNOLLICCAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E29860", Offset = "0x6E28260", VA = "0x186E29860")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E29AD0", Offset = "0x6E284D0", VA = "0x186E29AD0")]
		public void SetColor(Color BJCIGJMGMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E281F0", Offset = "0x6E26BF0", VA = "0x186E281F0")]
		private void LCGCCGNCPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A840", Offset = "0x6E29240", VA = "0x186E2A840")]
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
