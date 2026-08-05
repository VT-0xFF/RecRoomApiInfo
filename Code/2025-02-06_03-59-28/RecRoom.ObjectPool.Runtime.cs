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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x755C170", Offset = "0x755AF70", VA = "0x18755C170")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles MFDHKPDFMNP, float IANENJDLPKM, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x755BE10", Offset = "0x755AC10", VA = "0x18755BE10")]
		public void SetDamageValue(float IANENJDLPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x755C340", Offset = "0x755B140", VA = "0x18755C340")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DAEIDFHFNHO<T> : MNHDJBCOCND<T>, LDHIGNIGDAL, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CKEOEGEIGPH<T> : LDHIGNIGDAL, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DEAELKGKJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JAAPEOBMPKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JLLNBGELJKP<T> : EFBNHMMLLCH<T>, DAEIDFHFNHO<T>, MNHDJBCOCND<T>, LDHIGNIGDAL, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FNAKBPEPOFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JLLNBGELJKP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public FNAKBPEPOFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x43D0950", Offset = "0x43CF750", VA = "0x1843D0950")]
			internal void HKOLEGPFFOA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x32FC000", Offset = "0x32FAE00", VA = "0x1832FC000")]
			internal void HBOGFEDCIHD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MEPEJIIMKOI<T> CIMOJDIGNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool NGLCMNIIKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PMGDCKPCODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BBDDFKFCEGM;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x48D2850", Offset = "0x48D1650", VA = "0x1848D2850")]
		public JLLNBGELJKP(MEPEJIIMKOI<T> CIMOJDIGNMD, ObjectPool NGLCMNIIKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x48D26E0", Offset = "0x48D14E0", VA = "0x1848D26E0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JFEKIANNMCJ<T> : IFLNFKMEDGB, CKEOEGEIGPH<T>, LDHIGNIGDAL, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CPLPAKPALFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JFEKIANNMCJ<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CPLPAKPALFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A57600", Offset = "0x5A56400", VA = "0x185A57600")]
			internal void HKOLEGPFFOA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x11F7880", Offset = "0x11F6680", VA = "0x1811F7880")]
			internal void HBOGFEDCIHD(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MEPEJIIMKOI<T> CIMOJDIGNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool BBDDFKFCEGM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x48BD550", Offset = "0x48BC350", VA = "0x1848BD550")]
		public JFEKIANNMCJ(MEPEJIIMKOI<T> CIMOJDIGNMD, ObjectPool NGLCMNIIKIM, int GBLAJGHKDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x48BD4F0", Offset = "0x48BC2F0", VA = "0x1848BD4F0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HGIECCIFACN<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JAAPEOBMPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EFBNHMMLLCH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MEPEJIIMKOI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HGIECCIFACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x456FF20", Offset = "0x456ED20", VA = "0x18456FF20")]
		internal void IAJCMLKEDCK(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x456FFD0", Offset = "0x456EDD0", VA = "0x18456FFD0")]
		internal void IPGMJDFLMHP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x456FED0", Offset = "0x456ECD0", VA = "0x18456FED0")]
		internal void EGOLKEEIIJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DEAELKGKJMJ> BJLMMCMPBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PNDKNDHKCOP KBMNBOIOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool NGLCMNIIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x755A380", Offset = "0x7559180", VA = "0x18755A380")]
	private static void ILDKGIHBIGO(Component MMJIAOCMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x755A930", Offset = "0x7559730", VA = "0x18755A930")]
	public JAAPEOBMPKF(string FDOHOLOFKDI, int JODABBLNPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3337880", Offset = "0x3336680", VA = "0x183337880")]
	public DAEIDFHFNHO<T> ECBHJOIKIMH<T>(AssetReference LOLNIOCHIFB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3337950", Offset = "0x3336750", VA = "0x183337950")]
	public CKEOEGEIGPH<T> GLDBLBMHLDM<T>(AssetReference LOLNIOCHIFB, int BMGBDLLODJK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3337400", Offset = "0x3336200", VA = "0x183337400")]
	public MNHDJBCOCND<bool> DMOEJHJGHMI<T>(AssetReference LOLNIOCHIFB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x755A290", Offset = "0x7559090", VA = "0x18755A290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x755A760", Offset = "0x7559560", VA = "0x18755A760")]
	private void PFAOFNKLLMI(UnityEngine.Object JEFDFDCFDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x755A5D0", Offset = "0x75593D0", VA = "0x18755A5D0")]
	private ObjectPool JHHOONMLAML(string FDOHOLOFKDI)
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
		private static GlobalPool HJEOMNLFFFE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject OFMEPECNHAL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool GGJCMHODIEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x755A0F0", Offset = "0x7558EF0", VA = "0x18755A0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x32B8810", Offset = "0x32B7610", VA = "0x1832B8810")]
		public static void SafeRelease<T>(T JOOHPPHJKMI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x755A020", Offset = "0x7558E20", VA = "0x18755A020")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x755A0E0", Offset = "0x7558EE0", VA = "0x18755A0E0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LPEMEIDPDGH> LNJOPNCFFKD;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x34999F0", Offset = "0x34987F0", VA = "0x1834999F0")]
		public T Acquire<T>(T MFDHKPDFMNP, [Optional] Action<Component> CCGOPCFBHNA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3499DB0", Offset = "0x3498BB0", VA = "0x183499DB0")]
		public bool Release<T>(T JOOHPPHJKMI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3499D40", Offset = "0x3498B40", VA = "0x183499D40")]
		public void Prefill<T>(T MFDHKPDFMNP, int POHBOHFIBJK, [Optional] Action<Component> JEJCANMGHKD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3499B60", Offset = "0x3498960", VA = "0x183499B60")]
		public bool Exists<T>(T MFDHKPDFMNP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3499AB0", Offset = "0x34988B0", VA = "0x183499AB0")]
		public void Clear<T>(T MFDHKPDFMNP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x755B9B0", Offset = "0x755A7B0", VA = "0x18755B9B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3499C00", Offset = "0x3498A00", VA = "0x183499C00")]
		private LPEMEIDPDGH KAENMKHBPGP<T>(T MFDHKPDFMNP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		public void TrackInstantiation(string MFFJIMOPLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		public void EnableStats(bool MBAMDOCHNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x755BB20", Offset = "0x755A920", VA = "0x18755BB20")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LPEMEIDPDGH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JGGNCPIPDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PNGFBOKIIDA(bool BNMEJFFHBGD);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int GKIKEOADIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void GLDBLBMHLDM(int BMGBDLLODJK, Action<Component> JEJCANMGHKD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component ECBHJOIKIMH(Action<Component> CCGOPCFBHNA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool PBAOHHFJIIL(Component BJIPLNEIFBB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NCEIDOKFHPG();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x755AE40", Offset = "0x7559C40", VA = "0x18755AE40")]
	protected void GFNFPEDBAOK(Component JOOHPPHJKMI, bool BNMEJFFHBGD, bool OCPMPPGKJPN, bool LKEOCOMGAAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x755ABC0", Offset = "0x75599C0", VA = "0x18755ABC0")]
	protected void FKNPKMDEMCB(Transform DMCLHMMMGJK, bool BNMEJFFHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected LPEMEIDPDGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKOPKFGNMJD<T> : LPEMEIDPDGH where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T MFDHKPDFMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool DIPJEAEKOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool OCPMPPGKJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> NNMHNADJJKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x48CC2F0", Offset = "0x48CB0F0", VA = "0x1848CC2F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int GKIKEOADIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x48CB9A0", Offset = "0x48CA7A0", VA = "0x1848CB9A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48CC310", Offset = "0x48CB110", VA = "0x1848CC310")]
	public JKOPKFGNMJD(T MFDHKPDFMNP, ObjectPool DIPJEAEKOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48CBC80", Offset = "0x48CAA80", VA = "0x1848CBC80", Slot = "6")]
	public override void GLDBLBMHLDM(int BMGBDLLODJK, Action<Component> CCGOPCFBHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48CB9F0", Offset = "0x48CA7F0", VA = "0x1848CB9F0", Slot = "7")]
	public override Component ECBHJOIKIMH(Action<Component> CCGOPCFBHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48CBFC0", Offset = "0x48CADC0", VA = "0x1848CBFC0", Slot = "8")]
	public override bool PBAOHHFJIIL(Component BJIPLNEIFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48CBDB0", Offset = "0x48CABB0", VA = "0x1848CBDB0", Slot = "9")]
	public override void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48CC170", Offset = "0x48CAF70", VA = "0x1848CC170")]
	private T PGPBHIJOKHD()
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
		public interface IHHNGPNMMJI
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject JBMPGFJEPBB
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
		[Cpp2IlInjected.Address(RVA = "0x755B630", Offset = "0x755A430", VA = "0x18755B630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x755B920", Offset = "0x755A720", VA = "0x18755B920")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool HJEOMNLFFFE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject OFMEPECNHAL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool GGJCMHODIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x755BC70", Offset = "0x755AA70", VA = "0x18755BC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x755BBB0", Offset = "0x755A9B0", VA = "0x18755BBB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x755A0E0", Offset = "0x7558EE0", VA = "0x18755A0E0")]
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
		public LPEMEIDPDGH PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KBODNNCNLMH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NHPIOBLHPBI(PooledParticle.PKCFBOOMEAP INPCIJAHNDH);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum EMOFNBOEIJF
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum PKCFBOOMEAP
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface OJGMADLKAJO
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool JBPKCFOIIFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 NGIEDJEENMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera IDFLLEAEKIL
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
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6393F30", Offset = "0x6392D30", VA = "0x186393F30")]
			public ColorConfiguration(ParticleSystem JNGBFMLOAEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7559D70", Offset = "0x7558B70", VA = "0x187559D70")]
			public void KKJLGMEMAKL(Color EDAHAPFCLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IODJDECOAOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IODJDECOAOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x755A260", Offset = "0x7559060", VA = "0x18755A260")]
			internal void HBIBOJALBIK(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NIKCPNHHGCA : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private OJGMADLKAJO <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public NIKCPNHHGCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x755AFC0", Offset = "0x7559DC0", VA = "0x18755AFC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x755B5E0", Offset = "0x755A3E0", VA = "0x18755B5E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DLBCLEOHOCI : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public DLBCLEOHOCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7559F60", Offset = "0x7558D60", VA = "0x187559F60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7559FD0", Offset = "0x7558DD0", VA = "0x187559FD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JJBDEKILGHL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<KBODNNCNLMH> ACAGGACMFLM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> GMABFFMOLPH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static CPMKHKOAIIG FOLAHGGEHGJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float KKCBLLOEHGI = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool HMDAJEKEMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int CJAKBABOLJK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private PKCFBOOMEAP category;

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
		private ParticleSystem.MinMaxGradient[] MKKLDNMJBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool GHGLPIBBDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LKAHDOJNBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float AOBCODKBMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform MJPIDCIGDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 PDBMLPKDNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 KMPCFEPOOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EMOFNBOEIJF JEICNDGCJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CPMKHKOAIIG FOMIOHAKBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool OFIDGOMDNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Transform LPCIHLAMILD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> PIGFFAJHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x755FEC0", Offset = "0x755ECC0", VA = "0x18755FEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PKCFBOOMEAP CEENMCKGOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x91E390", Offset = "0x91D190", VA = "0x18091E390")]
			get
			{
				return default(PKCFBOOMEAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MEFNMPLKJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IJHDOOBJGHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x755FBF0", Offset = "0x755E9F0", VA = "0x18755FBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int KGLEBKKBJEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x755FD70", Offset = "0x755EB70", VA = "0x18755FD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool DLJOCGDHANC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x755CF60", Offset = "0x755BD60", VA = "0x18755CF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem NNKAJNJOHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B40", Offset = "0x8F6940", VA = "0x1808F7B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] OPNABMHDCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] LFHHFBNIILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EMOFNBOEIJF NFPOCHDMKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB03A60", Offset = "0xB02860", VA = "0x180B03A60")]
			get
			{
				return default(EMOFNBOEIJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x755CF40", Offset = "0x755BD40", VA = "0x18755CF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform KAEMFHJNGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x755FF10", Offset = "0x755ED10", VA = "0x18755FF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HEMBDFGCNKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x755FB50", Offset = "0x755E950", VA = "0x18755FB50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x755FF60", Offset = "0x755ED60", VA = "0x18755FF60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x755F450", Offset = "0x755E250", VA = "0x18755F450")]
		public static PooledParticle TryPlayPrefab(PooledParticle MFDHKPDFMNP, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x755F600", Offset = "0x755E400", VA = "0x18755F600")]
		public static PooledParticle TryPlayPrefab(PooledParticle MFDHKPDFMNP, Vector3 AKEODPFBHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x755EB10", Offset = "0x755D910", VA = "0x18755EB10")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x755C650", Offset = "0x755B450", VA = "0x18755C650")]
		private void DFEMGBAFMMP(bool OHPJAPBNBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x755DD40", Offset = "0x755CB40", VA = "0x18755DD40")]
		[IteratorStateMachine(typeof(NIKCPNHHGCA))]
		private static IEnumerator<HLGDLHCLDFE> POIDCHNNLNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x755D2C0", Offset = "0x755C0C0", VA = "0x18755D2C0")]
		private static void MLGNGKHKCOB(Stopwatch HPEGCCHCIAG, Vector3 LNFDHNIGILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x755C720", Offset = "0x755B520", VA = "0x18755C720")]
		private static int DFEPGMILMMN(PooledParticle NMOPBJNEFKL, PooledParticle KCJDGOIFCIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x755D8C0", Offset = "0x755C6C0", VA = "0x18755D8C0")]
		private static int NHPIOBLHPBI(PKCFBOOMEAP INPCIJAHNDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x755D6C0", Offset = "0x755C4C0", VA = "0x18755D6C0")]
		protected void NGEIEMBAOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x755C910", Offset = "0x755B710", VA = "0x18755C910")]
		protected void GBHEBIADIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x755C420", Offset = "0x755B220", VA = "0x18755C420", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x755CFE0", Offset = "0x755BDE0", VA = "0x18755CFE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x755DB60", Offset = "0x755C960", VA = "0x18755DB60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x755D630", Offset = "0x755C430", VA = "0x18755D630")]
		[IteratorStateMachine(typeof(DLBCLEOHOCI))]
		private IEnumerator<HLGDLHCLDFE> MMENHIKNMKD(float ENFBFHBOFDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x755DBE0", Offset = "0x755C9E0", VA = "0x18755DBE0")]
		private void PBAOHHFJIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x755F260", Offset = "0x755E060", VA = "0x18755F260")]
		public void SetDuration(float ENFBFHBOFDG, bool KMOPBKCHGJD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x755DED0", Offset = "0x755CCD0", VA = "0x18755DED0")]
		public void Play(Transform PBAAEHCJPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x755E6E0", Offset = "0x755D4E0", VA = "0x18755E6E0")]
		public void Play(Transform PBAAEHCJPDP, bool JENOHIGNBPP, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x755E070", Offset = "0x755CE70", VA = "0x18755E070")]
		public void Play(Transform PBAAEHCJPDP, Vector3 KMPCFEPOOBO, bool JENOHIGNBPP, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x755E200", Offset = "0x755D000", VA = "0x18755E200")]
		public void Play(Transform GJOJFIGBMDF, Quaternion CKABIAOPKPM, bool JENOHIGNBPP = false, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x755E8A0", Offset = "0x755D6A0", VA = "0x18755E8A0")]
		public void Play(Transform GJOJFIGBMDF, Vector3 KMPCFEPOOBO, Quaternion CKABIAOPKPM, bool JENOHIGNBPP = false, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x755E4B0", Offset = "0x755D2B0", VA = "0x18755E4B0")]
		public void Play(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, Vector3 PHFLICDNCII, bool JENOHIGNBPP = false, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x755E3B0", Offset = "0x755D1B0", VA = "0x18755E3B0")]
		public void Play(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, bool JENOHIGNBPP = false, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x755E5D0", Offset = "0x755D3D0", VA = "0x18755E5D0")]
		public void Play(bool JENOHIGNBPP = false, float AOHKEBLMLGH = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x755F3C0", Offset = "0x755E1C0", VA = "0x18755F3C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x755F330", Offset = "0x755E130", VA = "0x18755F330")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x755D9D0", Offset = "0x755C7D0", VA = "0x18755D9D0")]
		private void NOPJIIONDIL(float ENFBFHBOFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x755C7D0", Offset = "0x755B5D0", VA = "0x18755C7D0")]
		private void DKMKAEBDOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x755EA20", Offset = "0x755D820", VA = "0x18755EA20")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x755EC90", Offset = "0x755DA90", VA = "0x18755EC90")]
		public void SetColor(Color EDAHAPFCLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x755DDA0", Offset = "0x755CBA0", VA = "0x18755DDA0")]
		private void PPACLIBNHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x755FAC0", Offset = "0x755E8C0", VA = "0x18755FAC0")]
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
