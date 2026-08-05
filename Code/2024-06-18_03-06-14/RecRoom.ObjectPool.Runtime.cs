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
		[Cpp2IlInjected.Address(RVA = "0x6B3FFB0", Offset = "0x6B3E9B0", VA = "0x186B3FFB0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles GJEJJJDCBIG, float EGFEIDDHFGK, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FC50", Offset = "0x6B3E650", VA = "0x186B3FC50")]
		public void SetDamageValue(float EGFEIDDHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B40130", Offset = "0x6B3EB30", VA = "0x186B40130")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CGCAIDPDBEF<T> : CPAHEHFKIFF<T>, BIIHIAPDGKK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ILDEOFACGPG<T> : BIIHIAPDGKK, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IHKKIFNAHFK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HINOACAAAAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class IAIHPGPIENB<T> : DFGMIACLJJF<T>, CGCAIDPDBEF<T>, CPAHEHFKIFF<T>, BIIHIAPDGKK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EEPEDBGMBAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IAIHPGPIENB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public EEPEDBGMBAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3840C90", Offset = "0x383F690", VA = "0x183840C90")]
			internal void DBFCLFEJFAB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2833400", Offset = "0x2831E00", VA = "0x182833400")]
			internal void HDNKAJEMLCO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AMHDMMJJKND<T> DGBJEIHCGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GABGDFCPMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T LGHIKPMCACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MENBJDNCHDA;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A780", Offset = "0x3E89180", VA = "0x183E8A780")]
		public IAIHPGPIENB(AMHDMMJJKND<T> DGBJEIHCGJC, ObjectPool GABGDFCPMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A610", Offset = "0x3E89010", VA = "0x183E8A610", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KCHFLDLGMDP<T> : EJAAPNKDHLA, ILDEOFACGPG<T>, BIIHIAPDGKK, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OFLCEKCPNFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KCHFLDLGMDP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public OFLCEKCPNFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x45FC860", Offset = "0x45FB260", VA = "0x1845FC860")]
			internal void DBFCLFEJFAB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB90B10", Offset = "0xB8F510", VA = "0x180B90B10")]
			internal void HDNKAJEMLCO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AMHDMMJJKND<T> DGBJEIHCGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MENBJDNCHDA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x41B5160", Offset = "0x41B3B60", VA = "0x1841B5160")]
		public KCHFLDLGMDP(AMHDMMJJKND<T> DGBJEIHCGJC, ObjectPool GABGDFCPMMH, int BBEGPLBBAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41B5100", Offset = "0x41B3B00", VA = "0x1841B5100", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BOBEAODFHFA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HINOACAAAAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DFGMIACLJJF<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AMHDMMJJKND<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BOBEAODFHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E35F20", Offset = "0x4E34920", VA = "0x184E35F20")]
		internal void DGOEBPAJCCL(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4E36020", Offset = "0x4E34A20", VA = "0x184E36020")]
		internal void PGABJIEMDOP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4E35FD0", Offset = "0x4E349D0", VA = "0x184E35FD0")]
		internal void LIDECKELNNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<IHKKIFNAHFK> MIOOKMFMGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KNFHBIHKFEO MEBCOGOJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GABGDFCPMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MENBJDNCHDA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool KNGGLJDPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E490", Offset = "0x6B3CE90", VA = "0x186B3E490")]
	private static void KHMAAKGPKMJ(Component BHOOAGJPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E760", Offset = "0x6B3D160", VA = "0x186B3E760")]
	public HINOACAAAAN(string MLBCIJADJGF, int GBNJPOLAKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B3EDB0", Offset = "0x2B3D7B0", VA = "0x182B3EDB0")]
	public CGCAIDPDBEF<T> GCHNOJACEIH<T>(AssetReference AOELBIDHBMN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B3EE80", Offset = "0x2B3D880", VA = "0x182B3EE80")]
	public ILDEOFACGPG<T> NLBFPJFILKJ<T>(AssetReference AOELBIDHBMN, int OHELHAFFKFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E980", Offset = "0x2B3D380", VA = "0x182B3E980")]
	public CPAHEHFKIFF<bool> DBBOGLGLBCM<T>(AssetReference AOELBIDHBMN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E270", Offset = "0x6B3CC70", VA = "0x186B3E270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E360", Offset = "0x6B3CD60", VA = "0x186B3E360")]
	private void FDFCLFHOHKK(UnityEngine.Object GPOGKDPFADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E0E0", Offset = "0x6B3CAE0", VA = "0x186B3E0E0")]
	private ObjectPool AAKDGKHANMC(string MLBCIJADJGF)
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
		private static GlobalPool BANLMJLLLJM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MHIJBHLHEEO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool OHJMENPNAKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DF70", Offset = "0x6B3C970", VA = "0x186B3DF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D9F0", Offset = "0x2B2C3F0", VA = "0x182B2D9F0")]
		public static void SafeRelease<T>(T GKHPLGCJCPF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DEA0", Offset = "0x6B3C8A0", VA = "0x186B3DEA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DF60", Offset = "0x6B3C960", VA = "0x186B3DF60")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MCFLFLAECKI> HPGJNKKHNJH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CCEAA0", Offset = "0x2CCD4A0", VA = "0x182CCEAA0")]
		public T Acquire<T>(T GJEJJJDCBIG, [Optional] Action<Component> MAEJJGCHBPG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2CCEE60", Offset = "0x2CCD860", VA = "0x182CCEE60")]
		public bool Release<T>(T GKHPLGCJCPF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CCEDF0", Offset = "0x2CCD7F0", VA = "0x182CCEDF0")]
		public void Prefill<T>(T GJEJJJDCBIG, int GNPOOFOANAI, [Optional] Action<Component> MNGEOOACLIM) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CCEC10", Offset = "0x2CCD610", VA = "0x182CCEC10")]
		public bool Exists<T>(T GJEJJJDCBIG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CCEB60", Offset = "0x2CCD560", VA = "0x182CCEB60")]
		public void Clear<T>(T GJEJJJDCBIG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F7F0", Offset = "0x6B3E1F0", VA = "0x186B3F7F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CCECB0", Offset = "0x2CCD6B0", VA = "0x182CCECB0")]
		private MCFLFLAECKI MAFGMBJMFNK<T>(T GJEJJJDCBIG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public void TrackInstantiation(string EHCDPANHAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public void EnableStats(bool KNKFPAFPAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F960", Offset = "0x6B3E360", VA = "0x186B3F960")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MCFLFLAECKI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AFJNCOAOINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ANMBEFJFNHK(bool GEBFAKFHJEB);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int FBNPBGKHPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void NLBFPJFILKJ(int OHELHAFFKFF, Action<Component> MNGEOOACLIM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component GCHNOJACEIH(Action<Component> MAEJJGCHBPG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IPJKJLPDPPI(Component AAMJFFFBCHF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EIMPLACCFNH();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F070", Offset = "0x6B3DA70", VA = "0x186B3F070")]
	protected void FBFKNNIFLGH(Component GKHPLGCJCPF, bool GEBFAKFHJEB, bool KIFICENBCMG, bool LAOOHOJFMBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F1F0", Offset = "0x6B3DBF0", VA = "0x186B3F1F0")]
	protected void OEAILMDOLFI(Transform HFIJKOMLGDM, bool GEBFAKFHJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected MCFLFLAECKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AIOEOCAIHKG<T> : MCFLFLAECKI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T GJEJJJDCBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool MGKBOMLNEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool KIFICENBCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> CCKMMFOPAOO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CE78B0", Offset = "0x3CE62B0", VA = "0x183CE78B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int FBNPBGKHPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CE78D0", Offset = "0x3CE62D0", VA = "0x183CE78D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7920", Offset = "0x3CE6320", VA = "0x183CE7920")]
	public AIOEOCAIHKG(T GJEJJJDCBIG, ObjectPool MGKBOMLNEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7780", Offset = "0x3CE6180", VA = "0x183CE7780", Slot = "6")]
	public override void NLBFPJFILKJ(int OHELHAFFKFF, Action<Component> MAEJJGCHBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7340", Offset = "0x3CE5D40", VA = "0x183CE7340", Slot = "7")]
	public override Component GCHNOJACEIH(Action<Component> MAEJJGCHBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE75D0", Offset = "0x3CE5FD0", VA = "0x183CE75D0", Slot = "8")]
	public override bool IPJKJLPDPPI(Component AAMJFFFBCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7140", Offset = "0x3CE5B40", VA = "0x183CE7140", Slot = "9")]
	public override void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6FC0", Offset = "0x3CE59C0", VA = "0x183CE6FC0")]
	private T CCHILOCCEEC()
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
		public interface AMLIMNGNOND
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject HJANGGPDIKP
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
		[Cpp2IlInjected.Address(RVA = "0x6B3F470", Offset = "0x6B3DE70", VA = "0x186B3F470")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F760", Offset = "0x6B3E160", VA = "0x186B3F760")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool BANLMJLLLJM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MHIJBHLHEEO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool OHJMENPNAKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6B3FAB0", Offset = "0x6B3E4B0", VA = "0x186B3FAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F9F0", Offset = "0x6B3E3F0", VA = "0x186B3F9F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DF60", Offset = "0x6B3C960", VA = "0x186B3DF60")]
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
		public MCFLFLAECKI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HJKEPFKFBOK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BKJEELGKMIG(PooledParticle.JAAMPFOKAGG FOPHJHABPPA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum HADLALFPEHO
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
		public enum JAAMPFOKAGG
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
		public interface GCAKNILGILG
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool IKNHHPJJDPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 JLPKPHELEDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera BDCOMJGCOCA
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
			[Cpp2IlInjected.Address(RVA = "0x5A90300", Offset = "0x5A8ED00", VA = "0x185A90300")]
			public ColorConfiguration(ParticleSystem OGNHEGCLIBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DBF0", Offset = "0x6B3C5F0", VA = "0x186B3DBF0")]
			public void CCKHBCCKFEH(Color COGPPELINPO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class JIGCHFFLKGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public JIGCHFFLKGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6B3F040", Offset = "0x6B3DA40", VA = "0x186B3F040")]
			internal void EMDOHPDDDPG(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IOGLLKFLNBF : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private IHLELHJPJMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GCAKNILGILG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
			[DebuggerHidden]
			public IOGLLKFLNBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6B3E9F0", Offset = "0x6B3D3F0", VA = "0x186B3E9F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6B3EFF0", Offset = "0x6B3D9F0", VA = "0x186B3EFF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EPKCKEDBFCF : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private IHLELHJPJMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
			[DebuggerHidden]
			public EPKCKEDBFCF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DDE0", Offset = "0x6B3C7E0", VA = "0x186B3DDE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DE50", Offset = "0x6B3C850", VA = "0x186B3DE50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> AFDFFKNCKBP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<HJKEPFKFBOK> OKNAGABDBFE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> JGCHAGBPMPO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static JLKEMPIKEGF JNLCMEHHMKG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float PDEBJLMIMDE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool BPEACGLLEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int MOLOJKNCLKN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JAAMPFOKAGG category;

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
		private ParticleSystem.MinMaxGradient[] NLGBFHGFPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool JNLCKMFDIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float HIINJOOJNCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float OICOBOILECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JOGIALODPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 OEONCNCNJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 NPLOKEJGHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HADLALFPEHO CJAPBMICHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JLKEMPIKEGF JBHHMKKAPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool PNEOIFPLMFB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> GEHHGPOIMNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6B439A0", Offset = "0x6B423A0", VA = "0x186B439A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JAAMPFOKAGG DDFCLCGAHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x874E20", Offset = "0x873820", VA = "0x180874E20")]
			get
			{
				return default(JAAMPFOKAGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MAJFECEDJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CEPCMMODIML
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6B436D0", Offset = "0x6B420D0", VA = "0x186B436D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int CPHKJLEGBPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6B43850", Offset = "0x6B42250", VA = "0x186B43850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IJECMOHGJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6B40750", Offset = "0x6B3F150", VA = "0x186B40750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem EBNEHADNNEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] BAONAGGJENP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] HPDODIFHIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x84EC90", Offset = "0x84D690", VA = "0x18084EC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private HADLALFPEHO IFDMFFJNLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1006490", Offset = "0x1004E90", VA = "0x181006490")]
			get
			{
				return default(HADLALFPEHO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B40C60", Offset = "0x6B3F660", VA = "0x186B40C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OIAIGGFKIBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6B43630", Offset = "0x6B42030", VA = "0x186B43630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6B439F0", Offset = "0x6B423F0", VA = "0x186B439F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B42FC0", Offset = "0x6B419C0", VA = "0x186B42FC0")]
		public static PooledParticle TryPlayPrefab(PooledParticle GJEJJJDCBIG, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B43130", Offset = "0x6B41B30", VA = "0x186B43130")]
		public static PooledParticle TryPlayPrefab(PooledParticle GJEJJJDCBIG, Vector3 GLNEOPDBMFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B42670", Offset = "0x6B41070", VA = "0x186B42670")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B41860", Offset = "0x6B40260", VA = "0x186B41860")]
		private void MAANMELACAK(bool MOPHDJCHLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B41930", Offset = "0x6B40330", VA = "0x186B41930")]
		[IteratorStateMachine(typeof(IOGLLKFLNBF))]
		private static IEnumerator<IHLELHJPJMK> NHJIGAHDDKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B407D0", Offset = "0x6B3F1D0", VA = "0x186B407D0")]
		private static void ELKPFLLMIPL(Stopwatch GJLENOHHOLD, Vector3 MPGGEPLABEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B41540", Offset = "0x6B3FF40", VA = "0x186B41540")]
		private static int JNCCAAKFAJN(PooledParticle NNEJNMNIIPM, PooledParticle MENCHHOFOIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B40640", Offset = "0x6B3F040", VA = "0x186B40640")]
		private static int BKJEELGKMIG(JAAMPFOKAGG FOPHJHABPPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B40440", Offset = "0x6B3EE40", VA = "0x186B40440")]
		protected void BHCADCPBJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B40C80", Offset = "0x6B3F680", VA = "0x186B40C80")]
		protected void HNBJFDGMGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B40210", Offset = "0x6B3EC10", VA = "0x186B40210", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6B415F0", Offset = "0x6B3FFF0", VA = "0x186B415F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B41990", Offset = "0x6B40390", VA = "0x186B41990")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B41A10", Offset = "0x6B40410", VA = "0x186B41A10")]
		[IteratorStateMachine(typeof(EPKCKEDBFCF))]
		private IEnumerator<IHLELHJPJMK> PKNHKPKCPLD(float IHJBBHNOLLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B413E0", Offset = "0x6B3FDE0", VA = "0x186B413E0")]
		private void IPJKJLPDPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B42DD0", Offset = "0x6B417D0", VA = "0x186B42DD0")]
		public void SetDuration(float IHJBBHNOLLJ, bool CPNNAEPGNCN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B41C30", Offset = "0x6B40630", VA = "0x186B41C30")]
		public void Play(Transform NBMPBNALKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B422E0", Offset = "0x6B40CE0", VA = "0x186B422E0")]
		public void Play(Transform NBMPBNALKCM, bool ONOCBCAAEEP, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B41D90", Offset = "0x6B40790", VA = "0x186B41D90")]
		public void Play(Transform NBMPBNALKCM, Vector3 NPLOKEJGHPD, bool ONOCBCAAEEP, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B41EE0", Offset = "0x6B408E0", VA = "0x186B41EE0")]
		public void Play(Transform BEIHIDOIKOF, Quaternion NGGFFKDNCFB, bool ONOCBCAAEEP = false, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B42450", Offset = "0x6B40E50", VA = "0x186B42450")]
		public void Play(Transform BEIHIDOIKOF, Vector3 NPLOKEJGHPD, Quaternion NGGFFKDNCFB, bool ONOCBCAAEEP = false, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B42100", Offset = "0x6B40B00", VA = "0x186B42100")]
		public void Play(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, Vector3 PBGBFAMBAMF, bool ONOCBCAAEEP = false, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B42040", Offset = "0x6B40A40", VA = "0x186B42040")]
		public void Play(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, bool ONOCBCAAEEP = false, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B421D0", Offset = "0x6B40BD0", VA = "0x186B421D0")]
		public void Play(bool ONOCBCAAEEP = false, float FGHLAOAJACK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B42F30", Offset = "0x6B41930", VA = "0x186B42F30")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B42EA0", Offset = "0x6B418A0", VA = "0x186B42EA0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B41AA0", Offset = "0x6B404A0", VA = "0x186B41AA0")]
		private void POBBEIHLLPG(float IHJBBHNOLLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B40B20", Offset = "0x6B3F520", VA = "0x186B40B20")]
		private void GIEGKCIOADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B42580", Offset = "0x6B40F80", VA = "0x186B42580")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B427F0", Offset = "0x6B411F0", VA = "0x186B427F0")]
		public void SetColor(Color COGPPELINPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B412B0", Offset = "0x6B3FCB0", VA = "0x186B412B0")]
		private void IJAAFBFHNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B435A0", Offset = "0x6B41FA0", VA = "0x186B435A0")]
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
