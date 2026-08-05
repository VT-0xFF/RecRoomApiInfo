using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
		[SerializeField]
		[Header("Impact Particle System")]
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
		[SerializeField]
		[Header("Impact Particle Start Lifetime")]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[Header("Spray Particle System")]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Header("Spray Particle Burst Count")]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4169690", Offset = "0x4167E90", VA = "0x184169690")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IIFCAFGLJID, float ECKAOCIHFCC, Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4169400", Offset = "0x4167C00", VA = "0x184169400")]
		public void SetDamageValue(float ECKAOCIHFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4169830", Offset = "0x4168030", VA = "0x184169830")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IEMFKNMMDOE<T> : global::DCBCPMGHAFG<T>, JFMFFKHCJLK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FHEMBKOOEDN<T> : JFMFFKHCJLK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AAFHBIMMJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IGBMKGGEJGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MEJFPJJEPKP<T> : global::HDCMNDPJECI<T>, global::IEMFKNMMDOE<T>, global::DCBCPMGHAFG<T>, JFMFFKHCJLK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DOJMKAJGOON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MEJFPJJEPKP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
			public DOJMKAJGOON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x549CC20", Offset = "0x549B420", VA = "0x18549CC20")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xE2A470", Offset = "0xE28C70", VA = "0x180E2A470")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::CNAGBPIDIJA<T> NIDHLCHJDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool MLPFLGFOFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T LHFAIDGNGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x54AF760", Offset = "0x54ADF60", VA = "0x1854AF760")]
		public MEJFPJJEPKP(global::CNAGBPIDIJA<T> NIDHLCHJDOP, ObjectPool MLPFLGFOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x54AF620", Offset = "0x54ADE20", VA = "0x1854AF620", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DBCIPEKANOO<T> : CBHCDHNKCAP, global::FHEMBKOOEDN<T>, JFMFFKHCJLK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PIGBPEKHHEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DBCIPEKANOO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
			public PIGBPEKHHEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x54BBC40", Offset = "0x54BA440", VA = "0x1854BBC40")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D10", Offset = "0x4C28510", VA = "0x184C29D10")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::CNAGBPIDIJA<T> NIDHLCHJDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x549C9E0", Offset = "0x549B1E0", VA = "0x18549C9E0")]
		public DBCIPEKANOO(global::CNAGBPIDIJA<T> NIDHLCHJDOP, ObjectPool MLPFLGFOFNA, int CBJBIDOICCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x549C990", Offset = "0x549B190", VA = "0x18549C990", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BOANNJFJLNC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IGBMKGGEJGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::HDCMNDPJECI<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::CNAGBPIDIJA<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public BOANNJFJLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x549C840", Offset = "0x549B040", VA = "0x18549C840")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x549C8E0", Offset = "0x549B0E0", VA = "0x18549C8E0")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x549C940", Offset = "0x549B140", VA = "0x18549C940")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<AAFHBIMMJHB> AAHGODKMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LDODHAJGLLF CENBDCGDHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool MLPFLGFOFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool NHGDDMJPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4167800", Offset = "0x4166000", VA = "0x184167800")]
	private static void GHOLLIMFGJG(Component CFCFGDKOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4167A60", Offset = "0x4166260", VA = "0x184167A60")]
	public IGBMKGGEJGM(string GEMEDDNALGH, int ANIKAPPBEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5254780", Offset = "0x5252F80", VA = "0x185254780")]
	public global::IEMFKNMMDOE<T> IAFOJPBAIIN<T>(AssetReference CJAIHNCNNBJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52546D0", Offset = "0x5252ED0", VA = "0x1852546D0")]
	public global::FHEMBKOOEDN<T> HKAAMLMLKPI<T>(AssetReference CJAIHNCNNBJ, int FKDPJOHPNNG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F27FA0", Offset = "0x4F267A0", VA = "0x184F27FA0")]
	public global::DCBCPMGHAFG<bool> NKBMJECLOCI<T>(AssetReference CJAIHNCNNBJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41675A0", Offset = "0x4165DA0", VA = "0x1841675A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4167470", Offset = "0x4165C70", VA = "0x184167470")]
	private void AEFONGAECPH(UnityEngine.Object EGGAMCNGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41676B0", Offset = "0x4165EB0", VA = "0x1841676B0")]
	private ObjectPool GHLPJDLLAKF(string GEMEDDNALGH)
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
		private static GlobalPool MNDJBFKKLBM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject LGIDHKAOFAK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool AAMGPJBHPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4166F70", Offset = "0x4165770", VA = "0x184166F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4166E20", Offset = "0x4165620", VA = "0x184166E20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4166F00", Offset = "0x4165700", VA = "0x184166F00")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, HJDCCNCEHLJ> GFMBAKNIILE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA89DB0", Offset = "0xA885B0", VA = "0x180A89DB0")]
		public T Acquire<T>(T IIFCAFGLJID, [Optional] Action<Component> KOLOOFLAHMK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xFA8130", Offset = "0xFA6930", VA = "0x180FA8130")]
		public bool Release<T>(T DEGGOOGCHFA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50043C0", Offset = "0x5002BC0", VA = "0x1850043C0")]
		public void Prefill<T>(T IIFCAFGLJID, int NPJDHCOBKNJ, [Optional] Action<Component> JEHFMGBBIOC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFA8090", Offset = "0xFA6890", VA = "0x180FA8090")]
		public bool Exists<T>(T IIFCAFGLJID) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5004320", Offset = "0x5002B20", VA = "0x185004320")]
		public void Clear<T>(T IIFCAFGLJID) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4168A30", Offset = "0x4167230", VA = "0x184168A30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x525E0F0", Offset = "0x525C8F0", VA = "0x18525E0F0")]
		private HJDCCNCEHLJ HBIFKOLCCCB<T>(T IIFCAFGLJID) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public void TrackInstantiation(string CPOIMOFCNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public void EnableStats(bool PBHAJPPPPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4166F00", Offset = "0x4165700", VA = "0x184166F00")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class HJDCCNCEHLJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ABHFCHONFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HHNFLFMHDIK(bool NIJAIOIBGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component IFJLPGNFMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int GJEEHEFBGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void HKAAMLMLKPI(int FKDPJOHPNNG, Action<Component> JEHFMGBBIOC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component IAFOJPBAIIN(Action<Component> KOLOOFLAHMK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool OIFOPNNBDMP(Component ICFEOMHIGHK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void IDPJIGKEBOL();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x41672F0", Offset = "0x4165AF0", VA = "0x1841672F0")]
	protected void KKCBLGAKIMA(Component DEGGOOGCHFA, bool NIJAIOIBGDE, bool PCMDFPAELBB, bool GIABNIIGFEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4167100", Offset = "0x4165900", VA = "0x184167100")]
	protected void FADLMGMIOPF(Transform OLLDPHCJLDK, bool NIJAIOIBGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected HJDCCNCEHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HMNCMHIMCAJ<T> : HJDCCNCEHLJ where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T IIFCAFGLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool DBEINJDCOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool PCMDFPAELBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> OJEHJMCIPGP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component IFJLPGNFMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x56983A0", Offset = "0x5696BA0", VA = "0x1856983A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int GJEEHEFBGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5698370", Offset = "0x5696B70", VA = "0x185698370", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5698C20", Offset = "0x5697420", VA = "0x185698C20")]
	public HMNCMHIMCAJ(T IIFCAFGLJID, ObjectPool DBEINJDCOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5698510", Offset = "0x5696D10", VA = "0x185698510", Slot = "7")]
	public override void HKAAMLMLKPI(int FKDPJOHPNNG, Action<Component> KOLOOFLAHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5698620", Offset = "0x5696E20", VA = "0x185698620", Slot = "8")]
	public override Component IAFOJPBAIIN(Action<Component> KOLOOFLAHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5698A90", Offset = "0x5697290", VA = "0x185698A90", Slot = "9")]
	public override bool OIFOPNNBDMP(Component ICFEOMHIGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5698850", Offset = "0x5697050", VA = "0x185698850", Slot = "10")]
	public override void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56983C0", Offset = "0x5696BC0", VA = "0x1856983C0")]
	private T GPBNABOGPNH()
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
		public interface HOANBCJEEKB
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject AOKBBEFJPHE
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41686E0", Offset = "0x4166EE0", VA = "0x1841686E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41689C0", Offset = "0x41671C0", VA = "0x1841689C0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MNDJBFKKLBM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject LGIDHKAOFAK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool AAMGPJBHPCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4169240", Offset = "0x4167A40", VA = "0x184169240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4169160", Offset = "0x4167960", VA = "0x184169160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4166F00", Offset = "0x4165700", VA = "0x184166F00")]
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
		public HJDCCNCEHLJ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum BJKECMMFFAG
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public interface ECKAJHOJJDE
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool NDHOFGKEACC
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 PPBGKBPPCKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera OPMEPFKDHNF
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x213DA90", Offset = "0x213C290", VA = "0x18213DA90")]
			public ColorConfiguration(ParticleSystem IAKMBHDPDPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4166C10", Offset = "0x4165410", VA = "0x184166C10")]
			public void BELINALPHON(Color NDEHEJIJFDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ILNDLHMFKDA : IEnumerator<AADBNPIPHNH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private AADBNPIPHNH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private ECKAJHOJJDE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private AADBNPIPHNH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
			[DebuggerHidden]
			public ILNDLHMFKDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4167C80", Offset = "0x4166480", VA = "0x184167C80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4168690", Offset = "0x4166E90", VA = "0x184168690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ADILBFPKEPH : IEnumerator<AADBNPIPHNH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private AADBNPIPHNH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private AADBNPIPHNH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
			[DebuggerHidden]
			public ADILBFPKEPH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4166B00", Offset = "0x4165300", VA = "0x184166B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4166BC0", Offset = "0x41653C0", VA = "0x184166BC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FDENLACKADI;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> HJLGGAMDJNL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static EMIHBMNJEOE OGPHDOPABNH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float DOMBPMNPHPH = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool DLLJNNLABKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int EHKIMGAMHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ParticleSystem.MinMaxGradient[] GJGGJCOAFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool HMHDLBLAGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float HBOAMJEOICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float EIFCAGMGDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform KMOCGGPJEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 PJMOLLEKBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 EHKANPNKMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private BJKECMMFFAG HPPCALPHEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private EMIHBMNJEOE DIDBJPMHFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool KDBAFLMIJIM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool IFBMIJKMOGF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4169B00", Offset = "0x4168300", VA = "0x184169B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem LBBNLOACINB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] PJNILHIGJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] GMLDOPKMECF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private BJKECMMFFAG ELHJGOGHMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDE8140", Offset = "0xDE6940", VA = "0x180DE8140")]
			get
			{
				return default(BJKECMMFFAG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x416A6A0", Offset = "0x4168EA0", VA = "0x18416A6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OAALAJLIFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x416C4F0", Offset = "0x416ACF0", VA = "0x18416C4F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x416C590", Offset = "0x416AD90", VA = "0x18416C590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x416C190", Offset = "0x416A990", VA = "0x18416C190")]
		public static PooledParticle TryPlayPrefab(PooledParticle IIFCAFGLJID, Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x416BFA0", Offset = "0x416A7A0", VA = "0x18416BFA0")]
		public static PooledParticle TryPlayPrefab(PooledParticle IIFCAFGLJID, Vector3 BAFCICKIIDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x416B7E0", Offset = "0x4169FE0", VA = "0x18416B7E0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x416AC10", Offset = "0x4169410", VA = "0x18416AC10")]
		private void OJDFKPCDKIL(bool IMIPLIDOHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x416A9A0", Offset = "0x41691A0", VA = "0x18416A9A0")]
		[IteratorStateMachine(typeof(ILNDLHMFKDA))]
		private static IEnumerator<AADBNPIPHNH> NBOICLGPCCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x416A520", Offset = "0x4168D20", VA = "0x18416A520")]
		protected void HAIEEBGMOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x416A070", Offset = "0x4168870", VA = "0x18416A070")]
		protected void FADEPNDAJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4169910", Offset = "0x4168110", VA = "0x184169910", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x416A6C0", Offset = "0x4168EC0", VA = "0x18416A6C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x416AC90", Offset = "0x4169490", VA = "0x18416AC90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x416A9F0", Offset = "0x41691F0", VA = "0x18416A9F0")]
		[IteratorStateMachine(typeof(ADILBFPKEPH))]
		private IEnumerator<AADBNPIPHNH> OIBPHDKEPNB(float GPEKMAMGHIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x416AA70", Offset = "0x4169270", VA = "0x18416AA70")]
		private void OIFOPNNBDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x416BD80", Offset = "0x416A580", VA = "0x18416BD80")]
		public void SetDuration(float GPEKMAMGHIO, bool ODIPPBIMLLO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x416B540", Offset = "0x4169D40", VA = "0x18416B540")]
		public void Play(Transform FPMJMNAFJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x416B3B0", Offset = "0x4169BB0", VA = "0x18416B3B0")]
		public void Play(Transform FPMJMNAFJED, bool OGPDBNHBICD, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x416B020", Offset = "0x4169820", VA = "0x18416B020")]
		public void Play(Transform FPMJMNAFJED, Vector3 EHKANPNKMJH, bool OGPDBNHBICD, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x416ADD0", Offset = "0x41695D0", VA = "0x18416ADD0")]
		public void Play(Transform JIFAKINMNPA, Quaternion ALKIIOKOBPG, bool OGPDBNHBICD = false, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x416B170", Offset = "0x4169970", VA = "0x18416B170")]
		public void Play(Transform JIFAKINMNPA, Vector3 EHKANPNKMJH, Quaternion ALKIIOKOBPG, bool OGPDBNHBICD = false, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x416AF50", Offset = "0x4169750", VA = "0x18416AF50")]
		public void Play(Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG, Vector3 NLCPOCMNNGD, bool OGPDBNHBICD = false, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x416AD10", Offset = "0x4169510", VA = "0x18416AD10")]
		public void Play(Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG, bool OGPDBNHBICD = false, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x416B2A0", Offset = "0x4169AA0", VA = "0x18416B2A0")]
		public void Play(bool OGPDBNHBICD = false, float NPNGCKFNMIG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x416BF10", Offset = "0x416A710", VA = "0x18416BF10")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x416BE60", Offset = "0x416A660", VA = "0x18416BE60")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4169EF0", Offset = "0x41686F0", VA = "0x184169EF0")]
		private void EJDPKJBONDK(float GPEKMAMGHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4169D80", Offset = "0x4168580", VA = "0x184169D80")]
		private void DPAPJEFDKJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x416B6C0", Offset = "0x4169EC0", VA = "0x18416B6C0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x416B960", Offset = "0x416A160", VA = "0x18416B960")]
		public void SetColor(Color NDEHEJIJFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4169BB0", Offset = "0x41683B0", VA = "0x184169BB0")]
		private void BIEDNEPCMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x416C460", Offset = "0x416AC60", VA = "0x18416C460")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4169D50", Offset = "0x4168550", VA = "0x184169D50")]
		[CompilerGenerated]
		private void DCBIACBBMLK(ParticleSystemRenderer MFNAOJHGPFM)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4168B70", Offset = "0x4167370", VA = "0x184168B70")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4168C70", Offset = "0x4167470", VA = "0x184168C70")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
