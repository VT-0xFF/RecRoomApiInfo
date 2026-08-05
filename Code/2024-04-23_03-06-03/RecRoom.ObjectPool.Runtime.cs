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
		[Cpp2IlInjected.Address(RVA = "0x64C04F0", Offset = "0x64BF4F0", VA = "0x1864C04F0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles CFIHBPMHFDG, float NPKHPIJHJMB, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64C0190", Offset = "0x64BF190", VA = "0x1864C0190")]
		public void SetDamageValue(float NPKHPIJHJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64C0670", Offset = "0x64BF670", VA = "0x1864C0670")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CGDICEDLDOD<T> : MLBHOBCFFDI<T>, PGOMONKDBKH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LNAFFFOPCMM<T> : PGOMONKDBKH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OEIMAOPANMB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MAKFEIMAKNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DKMLIFFJAPO<T> : AGLJGCDAHHO<T>, CGDICEDLDOD<T>, MLBHOBCFFDI<T>, PGOMONKDBKH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JHHFCMFMKHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public DKMLIFFJAPO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public JHHFCMFMKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3CD12C0", Offset = "0x3CD02C0", VA = "0x183CD12C0")]
			internal void EECIPEGFNGI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x26AF660", Offset = "0x26AE660", VA = "0x1826AF660")]
			internal void OEPHNIMKKHP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DBHPMDCPDMB<T> OLHGAAPFAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool JJMMKFKLHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T ILCIGJJMCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FFEBLLHHGBH;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x520A6C0", Offset = "0x52096C0", VA = "0x18520A6C0")]
		public DKMLIFFJAPO(DBHPMDCPDMB<T> OLHGAAPFAPH, ObjectPool JJMMKFKLHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x520A580", Offset = "0x5209580", VA = "0x18520A580", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GHMGEHCECMK<T> : KODAAIAJNHH, LNAFFFOPCMM<T>, PGOMONKDBKH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DLHHGKGLNFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GHMGEHCECMK<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public DLHHGKGLNFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x520E720", Offset = "0x520D720", VA = "0x18520E720")]
			internal void EECIPEGFNGI(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA34150", Offset = "0xA33150", VA = "0x180A34150")]
			internal void OEPHNIMKKHP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DBHPMDCPDMB<T> OLHGAAPFAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool FFEBLLHHGBH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39A0560", Offset = "0x399F560", VA = "0x1839A0560")]
		public GHMGEHCECMK(DBHPMDCPDMB<T> OLHGAAPFAPH, ObjectPool JJMMKFKLHFJ, int GNKDJFFFGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39A0500", Offset = "0x399F500", VA = "0x1839A0500", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MFCLBKIIINF<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MAKFEIMAKNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AGLJGCDAHHO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DBHPMDCPDMB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MFCLBKIIINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x40267B0", Offset = "0x40257B0", VA = "0x1840267B0")]
		internal void KJNCAKLPIDD(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4026860", Offset = "0x4025860", VA = "0x184026860")]
		internal void KMJBIJGADND(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x40268C0", Offset = "0x40258C0", VA = "0x1840268C0")]
		internal void PKONKOKNFGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<OEIMAOPANMB> FLCBBCHDGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EOPGEGHPMLH KNHJOAKANBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool JJMMKFKLHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool FFEBLLHHGBH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool KHKOJDKKBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64BEA70", Offset = "0x64BDA70", VA = "0x1864BEA70")]
	private static void FDNNHNBMGPB(Component MPHIHJDJBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64BF000", Offset = "0x64BE000", VA = "0x1864BF000")]
	public MAKFEIMAKNG(string PAHKLFLPMNI, int NCMPEIPENFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2972F50", Offset = "0x2971F50", VA = "0x182972F50")]
	public CGDICEDLDOD<T> FPIGBFIIFEB<T>(AssetReference GICAAIHONEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2972FF0", Offset = "0x2971FF0", VA = "0x182972FF0")]
	public LNAFFFOPCMM<T> NNILBBEHPIN<T>(AssetReference GICAAIHONEF, int MJMIIGGLEFB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2972B50", Offset = "0x2971B50", VA = "0x182972B50")]
	public MLBHOBCFFDI<bool> AGICPGAMDKF<T>(AssetReference GICAAIHONEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64BE980", Offset = "0x64BD980", VA = "0x1864BE980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64BECB0", Offset = "0x64BDCB0", VA = "0x1864BECB0")]
	private void GIAJLAMDDMH(UnityEngine.Object OLLNPCEBHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64BEDE0", Offset = "0x64BDDE0", VA = "0x1864BEDE0")]
	private ObjectPool LIHDHFDHAJE(string PAHKLFLPMNI)
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
		private static GlobalPool HLLAOLEIIGL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject OOKIDPMNLLL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool AFPJCELPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x64BE410", Offset = "0x64BD410", VA = "0x1864BE410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28CC9D0", Offset = "0x28CB9D0", VA = "0x1828CC9D0")]
		public static void SafeRelease<T>(T KDEEPMDJGFD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64BE340", Offset = "0x64BD340", VA = "0x1864BE340")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64BE400", Offset = "0x64BD400", VA = "0x1864BE400")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, KONMCHLILED> ICBJDIDLFLK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A48940", Offset = "0x2A47940", VA = "0x182A48940")]
		public T Acquire<T>(T CFIHBPMHFDG, [Optional] Action<Component> GBKPBLHGGHB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A48CB0", Offset = "0x2A47CB0", VA = "0x182A48CB0")]
		public bool Release<T>(T KDEEPMDJGFD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A48C60", Offset = "0x2A47C60", VA = "0x182A48C60")]
		public void Prefill<T>(T CFIHBPMHFDG, int PLOLPFKPGOE, [Optional] Action<Component> JMNAIDBFJDH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A48A80", Offset = "0x2A47A80", VA = "0x182A48A80")]
		public bool Exists<T>(T CFIHBPMHFDG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A489D0", Offset = "0x2A479D0", VA = "0x182A489D0")]
		public void Clear<T>(T CFIHBPMHFDG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64BFD30", Offset = "0x64BED30", VA = "0x1864BFD30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A48B20", Offset = "0x2A47B20", VA = "0x182A48B20")]
		private KONMCHLILED LEABPEGICCI<T>(T CFIHBPMHFDG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public void TrackInstantiation(string IKIJMPPPPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public void EnableStats(bool ANDPOJHHPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64BFEA0", Offset = "0x64BEEA0", VA = "0x1864BFEA0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KONMCHLILED
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KOPCLHGKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IFHLEHAKCFF(bool PPMCKDBJGCH);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int NJNLKJEGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void NNILBBEHPIN(int MJMIIGGLEFB, Action<Component> JMNAIDBFJDH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component FPIGBFIIFEB(Action<Component> GBKPBLHGGHB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool OMHEABKHJKG(Component ODNBCIDMCKP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HCLIMFMHPCF();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64BE800", Offset = "0x64BD800", VA = "0x1864BE800")]
	protected void LODBLJCNPAC(Component KDEEPMDJGFD, bool PPMCKDBJGCH, bool CANDOPIGHNJ, bool JBMEPIMAANK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x64BE580", Offset = "0x64BD580", VA = "0x1864BE580")]
	protected void BOJMLAMABNP(Transform FKALGOEDMJA, bool PPMCKDBJGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected KONMCHLILED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MBHMGBHJFLE<T> : KONMCHLILED where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T CFIHBPMHFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FJMOGMBKPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CANDOPIGHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> GGPLOCOMMGD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4018BE0", Offset = "0x4017BE0", VA = "0x184018BE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int NJNLKJEGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4019050", Offset = "0x4018050", VA = "0x184019050", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40194B0", Offset = "0x40184B0", VA = "0x1840194B0")]
	public MBHMGBHJFLE(T CFIHBPMHFDG, ObjectPool FJMOGMBKPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4019200", Offset = "0x4018200", VA = "0x184019200", Slot = "6")]
	public override void NNILBBEHPIN(int MJMIIGGLEFB, Action<Component> GBKPBLHGGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4018C00", Offset = "0x4017C00", VA = "0x184018C00", Slot = "7")]
	public override Component FPIGBFIIFEB(Action<Component> GBKPBLHGGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4019310", Offset = "0x4018310", VA = "0x184019310", Slot = "8")]
	public override bool OMHEABKHJKG(Component ODNBCIDMCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4018E70", Offset = "0x4017E70", VA = "0x184018E70", Slot = "9")]
	public override void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4019090", Offset = "0x4018090", VA = "0x184019090")]
	private T NNCGBPDHJLL()
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
		public interface AHHHOCDEIKK
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject OCAMFGGAKJP
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
		[Cpp2IlInjected.Address(RVA = "0x64BF9B0", Offset = "0x64BE9B0", VA = "0x1864BF9B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x64BFCA0", Offset = "0x64BECA0", VA = "0x1864BFCA0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool HLLAOLEIIGL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject OOKIDPMNLLL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool AFPJCELPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x64BFFF0", Offset = "0x64BEFF0", VA = "0x1864BFFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64BFF30", Offset = "0x64BEF30", VA = "0x1864BFF30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64BE400", Offset = "0x64BD400", VA = "0x1864BE400")]
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
		public KONMCHLILED PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OGLKPNGPCFN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GELGKPLLFCO(PooledParticle.JCKJLLDBJDL BLHNBHEKLGI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum DDJNEGKMINM
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
		public enum JCKJLLDBJDL
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
		public interface FIPNOOJLJOO
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool BIFOLDBGFDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 FPCPFNJFLEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera JJANEFPPEFL
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
			[Cpp2IlInjected.Address(RVA = "0x54E1350", Offset = "0x54E0350", VA = "0x1854E1350")]
			public ColorConfiguration(ParticleSystem KNEFFNCCCPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x64BE120", Offset = "0x64BD120", VA = "0x1864BE120")]
			public void LONCLLPKENA(Color IODHIPGGADP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GEKJLODALLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public GEKJLODALLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x64BE310", Offset = "0x64BD310", VA = "0x1864BE310")]
			internal void NOAHDABBFMF(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OLHNINGPFOO : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private JHIBCIKJMBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private FIPNOOJLJOO <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
			[DebuggerHidden]
			public OLHNINGPFOO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x64BF350", Offset = "0x64BE350", VA = "0x1864BF350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x64BF960", Offset = "0x64BE960", VA = "0x1864BF960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NNMHDMNPBII : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JHIBCIKJMBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
			[DebuggerHidden]
			public NNMHDMNPBII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x64BF290", Offset = "0x64BE290", VA = "0x1864BF290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x64BF300", Offset = "0x64BE300", VA = "0x1864BF300", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NECNEPKEIHH;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<OGLKPNGPCFN> KBBEMEIONNL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> KCCLDGNKKKL;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static EOCGEKKEBMP LHEKPKHNHJH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float KKDAHEMFOCB = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool GFNGIOCCFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int KADOJPOEKAM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JCKJLLDBJDL category;

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
		private ParticleSystem.MinMaxGradient[] DLFAEBGJLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool FAMFDGMMHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float CDKLJBEEKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float CCFPDHLJKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform DNMMIPNBCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 HEJAMGKNNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DCMHDFONEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private DDJNEGKMINM JOFECPBEBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EOCGEKKEBMP OCFNEKCDBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool JGIJDFEEHAL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> ADOCFLJHACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x64C3EC0", Offset = "0x64C2EC0", VA = "0x1864C3EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JCKJLLDBJDL JFAHJKHLHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7E88A0", Offset = "0x7E78A0", VA = "0x1807E88A0")]
			get
			{
				return default(JCKJLLDBJDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DAKINAOEIGG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PNBCBOBDPIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64C3BF0", Offset = "0x64C2BF0", VA = "0x1864C3BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int COMANJLEFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x64C3D70", Offset = "0x64C2D70", VA = "0x1864C3D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool ENLDEANIFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x64C1C90", Offset = "0x64C0C90", VA = "0x1864C1C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem AEOJFNEKMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] KECKOHKAMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] LALBOCHGNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DDJNEGKMINM EBHAAJBLOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xEAD750", Offset = "0xEAC750", VA = "0x180EAD750")]
			get
			{
				return default(DDJNEGKMINM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x64C10B0", Offset = "0x64C00B0", VA = "0x1864C10B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBCMGBOMOFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x64C3B50", Offset = "0x64C2B50", VA = "0x1864C3B50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x64C3F10", Offset = "0x64C2F10", VA = "0x1864C3F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64C34E0", Offset = "0x64C24E0", VA = "0x1864C34E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFIHBPMHFDG, Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64C3650", Offset = "0x64C2650", VA = "0x1864C3650")]
		public static PooledParticle TryPlayPrefab(PooledParticle CFIHBPMHFDG, Vector3 BJIKBOECFPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64C2B90", Offset = "0x64C1B90", VA = "0x1864C2B90")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64C2080", Offset = "0x64C1080", VA = "0x1864C2080")]
		private void PNLGKPAHLNO(bool GEEDEEIHDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x64C1C30", Offset = "0x64C0C30", VA = "0x1864C1C30")]
		[IteratorStateMachine(typeof(OLHNINGPFOO))]
		private static IEnumerator<JHIBCIKJMBL> MFIDKBMGLGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x64C0CB0", Offset = "0x64BFCB0", VA = "0x1864C0CB0")]
		private static void CGPMEMLCCPG(Stopwatch OCBBLMCOHCB, Vector3 OOHEPJOCPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x64C1000", Offset = "0x64C0000", VA = "0x1864C1000")]
		private static int EIOKNCDKHIO(PooledParticle LEGDDGHJEMC, PooledParticle KNJHKKJANOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x64C1160", Offset = "0x64C0160", VA = "0x1864C1160")]
		private static int GELGKPLLFCO(JCKJLLDBJDL BLHNBHEKLGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64C0980", Offset = "0x64BF980", VA = "0x1864C0980")]
		protected void BABCPEOIKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x64C1620", Offset = "0x64C0620", VA = "0x1864C1620")]
		protected void MEKGEBGPBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x64C0750", Offset = "0x64BF750", VA = "0x1864C0750", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64C13B0", Offset = "0x64C03B0", VA = "0x1864C13B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64C2000", Offset = "0x64C1000", VA = "0x1864C2000")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64C10D0", Offset = "0x64C00D0", VA = "0x1864C10D0")]
		[IteratorStateMachine(typeof(NNMHDMNPBII))]
		private IEnumerator<JHIBCIKJMBL> GDFFAHDBICH(float NALPHCAAKLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64C1EA0", Offset = "0x64C0EA0", VA = "0x1864C1EA0")]
		private void OMHEABKHJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64C32F0", Offset = "0x64C22F0", VA = "0x1864C32F0")]
		public void SetDuration(float NALPHCAAKLP, bool ONGDHOGIFGN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64C2150", Offset = "0x64C1150", VA = "0x1864C2150")]
		public void Play(Transform DKBKCIHJACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64C2800", Offset = "0x64C1800", VA = "0x1864C2800")]
		public void Play(Transform DKBKCIHJACG, bool AGJHPMIPIDD, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64C22B0", Offset = "0x64C12B0", VA = "0x1864C22B0")]
		public void Play(Transform DKBKCIHJACG, Vector3 DCMHDFONEAL, bool AGJHPMIPIDD, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64C2400", Offset = "0x64C1400", VA = "0x1864C2400")]
		public void Play(Transform HFEIDKHFMNN, Quaternion CKCOAEGKOKA, bool AGJHPMIPIDD = false, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64C2970", Offset = "0x64C1970", VA = "0x1864C2970")]
		public void Play(Transform HFEIDKHFMNN, Vector3 DCMHDFONEAL, Quaternion CKCOAEGKOKA, bool AGJHPMIPIDD = false, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64C2620", Offset = "0x64C1620", VA = "0x1864C2620")]
		public void Play(Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, Vector3 KKLIKHAJECJ, bool AGJHPMIPIDD = false, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64C2560", Offset = "0x64C1560", VA = "0x1864C2560")]
		public void Play(Vector3 BJIKBOECFPB, Quaternion CKCOAEGKOKA, bool AGJHPMIPIDD = false, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64C26F0", Offset = "0x64C16F0", VA = "0x1864C26F0")]
		public void Play(bool AGJHPMIPIDD = false, float OFJLLFOMEGA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64C3450", Offset = "0x64C2450", VA = "0x1864C3450")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x64C33C0", Offset = "0x64C23C0", VA = "0x1864C33C0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64C1D10", Offset = "0x64C0D10", VA = "0x1864C1D10")]
		private void OHIJFAGONPE(float NALPHCAAKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x64C1270", Offset = "0x64C0270", VA = "0x1864C1270")]
		private void LMFGHOKBMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64C2AA0", Offset = "0x64C1AA0", VA = "0x1864C2AA0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64C2D10", Offset = "0x64C1D10", VA = "0x1864C2D10")]
		public void SetColor(Color IODHIPGGADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64C0B80", Offset = "0x64BFB80", VA = "0x1864C0B80")]
		private void CBNEJCMIAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64C3AC0", Offset = "0x64C2AC0", VA = "0x1864C3AC0")]
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
