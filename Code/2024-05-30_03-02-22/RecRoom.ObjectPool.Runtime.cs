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
		[Cpp2IlInjected.Address(RVA = "0x660F870", Offset = "0x660EA70", VA = "0x18660F870")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles PFEBHHJNIAE, float DLBJLDJCIKA, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x660F510", Offset = "0x660E710", VA = "0x18660F510")]
		public void SetDamageValue(float DLBJLDJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x660F9F0", Offset = "0x660EBF0", VA = "0x18660F9F0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BJFCOPIMGAK<T> : PMIHBBCEMHD<T>, BNCJCHBDCBI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DGGDIHJMDII<T> : BNCJCHBDCBI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DJOEEBJGKGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KGIKMBCAGPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KDNIANEGCGJ<T> : ACKCNCGOGDB<T>, BJFCOPIMGAK<T>, PMIHBBCEMHD<T>, BNCJCHBDCBI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ALNIGDGINKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KDNIANEGCGJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ALNIGDGINKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3D641A0", Offset = "0x3D633A0", VA = "0x183D641A0")]
			internal void MBFHJGINPHH(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x274B7A0", Offset = "0x274A9A0", VA = "0x18274B7A0")]
			internal void GPEPMCEFMIG(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AECHCDNEFCI<T> PMOFEGODNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KKFOPCMNJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PNLOKOBAKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JOHIIOJDHKN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C050", Offset = "0x3E4B250", VA = "0x183E4C050")]
		public KDNIANEGCGJ(AECHCDNEFCI<T> PMOFEGODNGM, ObjectPool KKFOPCMNJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BF10", Offset = "0x3E4B110", VA = "0x183E4BF10", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OFFFNIBBIIG<T> : MFGPODLAJFB, DGGDIHJMDII<T>, BNCJCHBDCBI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AMJBNADEHLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OFFFNIBBIIG<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public AMJBNADEHLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3D642B0", Offset = "0x3D634B0", VA = "0x183D642B0")]
			internal void MBFHJGINPHH(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AF0", Offset = "0xAD0CF0", VA = "0x180AD1AF0")]
			internal void GPEPMCEFMIG(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AECHCDNEFCI<T> PMOFEGODNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JOHIIOJDHKN;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x428EFA0", Offset = "0x428E1A0", VA = "0x18428EFA0")]
		public OFFFNIBBIIG(AECHCDNEFCI<T> PMOFEGODNGM, ObjectPool KKFOPCMNJLI, int NPODDAELFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x428EF40", Offset = "0x428E140", VA = "0x18428EF40", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IOLEEOLNGDH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KGIKMBCAGPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ACKCNCGOGDB<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AECHCDNEFCI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public IOLEEOLNGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A550", Offset = "0x3B39750", VA = "0x183B3A550")]
		internal void FGKPCMGNDMM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A5F0", Offset = "0x3B397F0", VA = "0x183B3A5F0")]
		internal void MHGBFCMCNLH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A650", Offset = "0x3B39850", VA = "0x183B3A650")]
		internal void PGFLMANHJEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DJOEEBJGKGJ> LAGDOONCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HNBMDCFJEHD GHBLLMPPIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KKFOPCMNJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JOHIIOJDHKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool FHKDGGIIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x660E7D0", Offset = "0x660D9D0", VA = "0x18660E7D0")]
	private static void IMGNGLMGBOH(Component NPBKACHANBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x660EAA0", Offset = "0x660DCA0", VA = "0x18660EAA0")]
	public KGIKMBCAGPA(string IFMOJFKAOHA, int PCJDCLHMPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FD40", Offset = "0x2A1EF40", VA = "0x182A1FD40")]
	public BJFCOPIMGAK<T> ENFMDAGMBIP<T>(AssetReference JMOPPDDNKFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FDE0", Offset = "0x2A1EFE0", VA = "0x182A1FDE0")]
	public DGGDIHJMDII<T> LILMAOACOOP<T>(AssetReference JMOPPDDNKFH, int BIFLOKBJAPK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A1F940", Offset = "0x2A1EB40", VA = "0x182A1F940")]
	public PMIHBBCEMHD<bool> ABDMLBNKFOD<T>(AssetReference JMOPPDDNKFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x660E6E0", Offset = "0x660D8E0", VA = "0x18660E6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x660E5B0", Offset = "0x660D7B0", VA = "0x18660E5B0")]
	private void BNINEEGOPIH(UnityEngine.Object LELIFLCLGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x660E420", Offset = "0x660D620", VA = "0x18660E420")]
	private ObjectPool AEPALCOFDHC(string IFMOJFKAOHA)
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
		private static GlobalPool HOJNAKDDMMC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MEBOPPAEANM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LNFBMICMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x660DC60", Offset = "0x660CE60", VA = "0x18660DC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29ACA80", Offset = "0x29ABC80", VA = "0x1829ACA80")]
		public static void SafeRelease<T>(T CDJAKLIPEBF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x660DB90", Offset = "0x660CD90", VA = "0x18660DB90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x660DC50", Offset = "0x660CE50", VA = "0x18660DC50")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EFFDFKBKOKF> POKFJLLAHMH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B06EB0", Offset = "0x2B060B0", VA = "0x182B06EB0")]
		public T Acquire<T>(T PFEBHHJNIAE, [Optional] Action<Component> PNNIOCBJGPA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B07220", Offset = "0x2B06420", VA = "0x182B07220")]
		public bool Release<T>(T CDJAKLIPEBF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B071D0", Offset = "0x2B063D0", VA = "0x182B071D0")]
		public void Prefill<T>(T PFEBHHJNIAE, int BCKLLLMCPAK, [Optional] Action<Component> HMNMEAPNIBP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B07130", Offset = "0x2B06330", VA = "0x182B07130")]
		public bool Exists<T>(T PFEBHHJNIAE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B07080", Offset = "0x2B06280", VA = "0x182B07080")]
		public void Clear<T>(T PFEBHHJNIAE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x660F0B0", Offset = "0x660E2B0", VA = "0x18660F0B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B06F40", Offset = "0x2B06140", VA = "0x182B06F40")]
		private EFFDFKBKOKF BEGCJBAGKDB<T>(T PFEBHHJNIAE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public void TrackInstantiation(string ECBDHBICAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public void EnableStats(bool JKJPPDGAJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x660F220", Offset = "0x660E420", VA = "0x18660F220")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EFFDFKBKOKF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PJKHINJHFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IEPGDDELNLO(bool OAPODLLOLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int NGLMCKFGHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void LILMAOACOOP(int BIFLOKBJAPK, Action<Component> HMNMEAPNIBP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component ENFMDAGMBIP(Action<Component> PNNIOCBJGPA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool BNPNHCAJEDK(Component MNJAELFPAAK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BFDHFEEMFPE();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x660D760", Offset = "0x660C960", VA = "0x18660D760")]
	protected void BCPAELLOGLM(Component CDJAKLIPEBF, bool OAPODLLOLMF, bool HHFIBAGJIFG, bool DBFNLJBMEEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x660D8E0", Offset = "0x660CAE0", VA = "0x18660D8E0")]
	protected void OIFLDNMPGGH(Transform CFLMMGADIOP, bool OAPODLLOLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected EFFDFKBKOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JGAEDEIGFOC<T> : EFFDFKBKOKF where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T PFEBHHJNIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FBFHLHAGLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HHFIBAGJIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> ADEJONCDLBC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C060", Offset = "0x3D4B260", VA = "0x183D4C060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int NGLMCKFGHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BA60", Offset = "0x3D4AC60", VA = "0x183D4BA60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C2F0", Offset = "0x3D4B4F0", VA = "0x183D4C2F0")]
	public JGAEDEIGFOC(T PFEBHHJNIAE, ObjectPool FBFHLHAGLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C080", Offset = "0x3D4B280", VA = "0x183D4C080", Slot = "6")]
	public override void LILMAOACOOP(int BIFLOKBJAPK, Action<Component> PNNIOCBJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BE00", Offset = "0x3D4B000", VA = "0x183D4BE00", Slot = "7")]
	public override Component ENFMDAGMBIP(Action<Component> PNNIOCBJGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BC70", Offset = "0x3D4AE70", VA = "0x183D4BC70", Slot = "8")]
	public override bool BNPNHCAJEDK(Component MNJAELFPAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BAA0", Offset = "0x3D4ACA0", VA = "0x183D4BAA0", Slot = "9")]
	public override void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C180", Offset = "0x3D4B380", VA = "0x183D4C180")]
	private T NKCLGOIKCJI()
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
		public interface AGDCLCPKNEL
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject OPHIBOCBCFA
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
		[Cpp2IlInjected.Address(RVA = "0x660ED30", Offset = "0x660DF30", VA = "0x18660ED30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x660F020", Offset = "0x660E220", VA = "0x18660F020")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool HOJNAKDDMMC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MEBOPPAEANM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool LNFBMICMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x660F370", Offset = "0x660E570", VA = "0x18660F370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x660F2B0", Offset = "0x660E4B0", VA = "0x18660F2B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x660DC50", Offset = "0x660CE50", VA = "0x18660DC50")]
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
		public EFFDFKBKOKF PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PFJOLGEMBPF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OBEFKLNPMNM(PooledParticle.BDDKOBJMPNN NHNEIBODNPK);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum AHJBFMJGFGM
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
		public enum BDDKOBJMPNN
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
		public interface MNGNNKKIJML
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool BGCAHLKGILH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 FFKKJEPFPGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera BMKCKIBCFKL
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
			[Cpp2IlInjected.Address(RVA = "0x55FE2F0", Offset = "0x55FD4F0", VA = "0x1855FE2F0")]
			public ColorConfiguration(ParticleSystem OHBHLAHAIFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x660D4B0", Offset = "0x660C6B0", VA = "0x18660D4B0")]
			public void GGAPGKDHCJH(Color LHAAJEOMGEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GGJHCNMGCJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public GGJHCNMGCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x660DB60", Offset = "0x660CD60", VA = "0x18660DB60")]
			internal void DMOIEMHFBGA(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JMOAEDNJHBP : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private MNGNNKKIJML <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public JMOAEDNJHBP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x660DDD0", Offset = "0x660CFD0", VA = "0x18660DDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x660E3D0", Offset = "0x660D5D0", VA = "0x18660E3D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DAKEOFLHEAH : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public DAKEOFLHEAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x660D6A0", Offset = "0x660C8A0", VA = "0x18660D6A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x660D710", Offset = "0x660C910", VA = "0x18660D710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JDCEPLDLMOP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<PFJOLGEMBPF> LBFPAHEIDOH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> AKMNCGFCNOA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static MGBJAGNHOEE KNIGPNPICPD;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float AGDBBKHOMFG = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool AFPNNMICCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int AKBDCKNOKAB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private BDDKOBJMPNN category;

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
		private ParticleSystem.MinMaxGradient[] EONFIHAPEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool OEADMODFDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LDDJCEHNCBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float LONIGKFLPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform GCBPLMECDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 LFNDJIPMLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 KNHLNHFCFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private AHJBFMJGFGM MADGGDPBBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private MGBJAGNHOEE IJJNIPBCHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool GLEKJJCKPMC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> JMNNAEBPOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6613230", Offset = "0x6612430", VA = "0x186613230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BDDKOBJMPNN OGJHPEFLPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7F0D10", Offset = "0x7EFF10", VA = "0x1807F0D10")]
			get
			{
				return default(BDDKOBJMPNN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GCFLBHAPGMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EHNLPDCDCKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6612F60", Offset = "0x6612160", VA = "0x186612F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int FDJEOAKHAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x66130E0", Offset = "0x66122E0", VA = "0x1866130E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool OAOCMMFJIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66112B0", Offset = "0x66104B0", VA = "0x1866112B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem BBEDFALLDIM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] NIJCEDMBIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] GJJBOKHIHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7CE970", Offset = "0x7CDB70", VA = "0x1807CE970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private AHJBFMJGFGM PNBIGGHGLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xF53F30", Offset = "0xF53130", VA = "0x180F53F30")]
			get
			{
				return default(AHJBFMJGFGM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66102C0", Offset = "0x660F4C0", VA = "0x1866102C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JAGFLIPPECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6612EC0", Offset = "0x66120C0", VA = "0x186612EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6613280", Offset = "0x6612480", VA = "0x186613280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6612850", Offset = "0x6611A50", VA = "0x186612850")]
		public static PooledParticle TryPlayPrefab(PooledParticle PFEBHHJNIAE, Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x66129C0", Offset = "0x6611BC0", VA = "0x1866129C0")]
		public static PooledParticle TryPlayPrefab(PooledParticle PFEBHHJNIAE, Vector3 CAOOPLKANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6611F00", Offset = "0x6611100", VA = "0x186611F00")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x660FAD0", Offset = "0x660ECD0", VA = "0x18660FAD0")]
		private void AIMKDAJAFHJ(bool AIDBJIBCPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6610600", Offset = "0x660F800", VA = "0x186610600")]
		[IteratorStateMachine(typeof(JMOAEDNJHBP))]
		private static IEnumerator<AEBIBAEBDOJ> HGHJECFGIGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6610660", Offset = "0x660F860", VA = "0x186610660")]
		private static void JJOPANOJBJA(Stopwatch MPHIGPEIAAC, Vector3 EIJJOHDAAMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6610420", Offset = "0x660F620", VA = "0x186610420")]
		private static int DIJKFKOKEMD(PooledParticle GFINPEICFEL, PooledParticle ENBAOKALGHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6611330", Offset = "0x6610530", VA = "0x186611330")]
		private static int OBEFKLNPMNM(BDDKOBJMPNN NHNEIBODNPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x660FDD0", Offset = "0x660EFD0", VA = "0x18660FDD0")]
		protected void BBIABNFGEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6610CB0", Offset = "0x660FEB0", VA = "0x186610CB0")]
		protected void MEBDDAJBFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x660FBA0", Offset = "0x660EDA0", VA = "0x18660FBA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6610A40", Offset = "0x660FC40", VA = "0x186610A40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6611440", Offset = "0x6610640", VA = "0x186611440")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x66109B0", Offset = "0x660FBB0", VA = "0x1866109B0")]
		[IteratorStateMachine(typeof(DAKEOFLHEAH))]
		private IEnumerator<AEBIBAEBDOJ> JNEBKPFGPEJ(float FEFLPFIAOEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6610160", Offset = "0x660F360", VA = "0x186610160")]
		private void BNPNHCAJEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6612660", Offset = "0x6611860", VA = "0x186612660")]
		public void SetDuration(float FEFLPFIAOEI, bool PEKMBPOJNGM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66114C0", Offset = "0x66106C0", VA = "0x1866114C0")]
		public void Play(Transform FHJDHELEBHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6611B70", Offset = "0x6610D70", VA = "0x186611B70")]
		public void Play(Transform FHJDHELEBHM, bool MAOKOANDHME, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6611620", Offset = "0x6610820", VA = "0x186611620")]
		public void Play(Transform FHJDHELEBHM, Vector3 KNHLNHFCFAG, bool MAOKOANDHME, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6611770", Offset = "0x6610970", VA = "0x186611770")]
		public void Play(Transform NFBNMIKMECD, Quaternion JCCMNAMJFGM, bool MAOKOANDHME = false, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6611CE0", Offset = "0x6610EE0", VA = "0x186611CE0")]
		public void Play(Transform NFBNMIKMECD, Vector3 KNHLNHFCFAG, Quaternion JCCMNAMJFGM, bool MAOKOANDHME = false, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6611990", Offset = "0x6610B90", VA = "0x186611990")]
		public void Play(Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, Vector3 OAFPAEEDKIL, bool MAOKOANDHME = false, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x66118D0", Offset = "0x6610AD0", VA = "0x1866118D0")]
		public void Play(Vector3 CAOOPLKANIG, Quaternion JCCMNAMJFGM, bool MAOKOANDHME = false, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6611A60", Offset = "0x6610C60", VA = "0x186611A60")]
		public void Play(bool MAOKOANDHME = false, float AAPJLGNPDHH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x66127C0", Offset = "0x66119C0", VA = "0x1866127C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6612730", Offset = "0x6611930", VA = "0x186612730")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x660FFD0", Offset = "0x660F1D0", VA = "0x18660FFD0")]
		private void BNANNKMFCEI(float FEFLPFIAOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x66102E0", Offset = "0x660F4E0", VA = "0x1866102E0")]
		private void DEAPFGDGIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6611E10", Offset = "0x6611010", VA = "0x186611E10")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6612080", Offset = "0x6611280", VA = "0x186612080")]
		public void SetColor(Color LHAAJEOMGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x66104D0", Offset = "0x660F6D0", VA = "0x1866104D0")]
		private void DOACGFKEHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6612E30", Offset = "0x6612030", VA = "0x186612E30")]
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
